using System;

namespace J2ME.Audio
{
    /// <summary>
    /// Tolerant RIFF/WAVE decoder producing interleaved float samples in [-1, 1].
    /// Supports PCM 8/16/24/32-bit, IEEE float 32/64, IMA ADPCM (0x11), Microsoft ADPCM (0x02),
    /// A-law (6) and mu-law (7), plus WAVE_FORMAT_EXTENSIBLE wrapping any of those.
    /// Never throws; returns false when nothing could be decoded.
    /// </summary>
    public static class WavDecoder
    {
        const int FormatPcm = 0x0001;
        const int FormatMsAdpcm = 0x0002;
        const int FormatFloat = 0x0003;
        const int FormatALaw = 0x0006;
        const int FormatMuLaw = 0x0007;
        const int FormatImaAdpcm = 0x0011;
        const int FormatExtensible = 0xFFFE;

        static readonly int[] ImaIndexTable =
        {
            -1, -1, -1, -1, 2, 4, 6, 8,
            -1, -1, -1, -1, 2, 4, 6, 8
        };

        static readonly int[] ImaStepTable =
        {
            7, 8, 9, 10, 11, 12, 13, 14, 16, 17,
            19, 21, 23, 25, 28, 31, 34, 37, 41, 45,
            50, 55, 60, 66, 73, 80, 88, 97, 107, 118,
            130, 143, 157, 173, 190, 209, 230, 253, 279, 307,
            337, 371, 408, 449, 494, 544, 598, 658, 724, 796,
            876, 963, 1060, 1166, 1282, 1411, 1552, 1707, 1878, 2066,
            2272, 2499, 2749, 3024, 3327, 3660, 4026, 4428, 4871, 5358,
            5894, 6484, 7132, 7845, 8630, 9493, 10442, 11487, 12635, 13899,
            15289, 16818, 18500, 20350, 22385, 24623, 27086, 29794, 32767
        };

        static readonly int[] MsAdaptationTable =
        {
            230, 230, 230, 230, 307, 409, 512, 614,
            768, 614, 512, 409, 307, 230, 230, 230
        };

        static readonly int[] MsDefaultCoef1 = { 256, 512, 0, 192, 240, 460, 392 };
        static readonly int[] MsDefaultCoef2 = { 0, -256, 0, 64, 0, -208, -232 };

        public static bool TryDecode(byte[] data, out float[] samples, out int channels, out int sampleRate)
        {
            samples = Array.Empty<float>();
            channels = 0;
            sampleRate = 0;
            if (data == null || data.Length < 12)
                return false;
            try
            {
                float[] s;
                int ch, sr;
                if (!DecodeInternal(data, out s, out ch, out sr) || s == null || s.Length == 0)
                    return false;
                samples = s;
                channels = ch;
                sampleRate = sr;
                return true;
            }
            catch (Exception)
            {
                samples = Array.Empty<float>();
                channels = 0;
                sampleRate = 0;
                return false;
            }
        }

        // ------------------------------------------------------------------ chunk parsing

        static bool DecodeInternal(byte[] d, out float[] samples, out int channels, out int sampleRate)
        {
            samples = null;
            channels = 0;
            sampleRate = 0;
            int len = d.Length;

            if (!(IsTag(d, 0, "RIFF") || IsTag(d, 0, "RIFX")) || !IsTag(d, 8, "WAVE"))
                return false;
            if (IsTag(d, 0, "RIFX"))
                return false; // big-endian WAV: practically never seen on phones

            int fmtPos = -1, fmtLen = 0, dataPos = -1, dataLen = 0;
            long pos = 12;
            while (pos + 8 <= len)
            {
                int p = (int)pos;
                uint size = U32(d, p + 4);
                int body = p + 8;
                long avail = len - body;
                bool sizeBad = size > avail;

                if (IsTag(d, p, "fmt ") && fmtPos < 0)
                {
                    fmtPos = body;
                    fmtLen = (int)Math.Min(size, (uint)avail);
                }
                else if (IsTag(d, p, "data") && dataPos < 0)
                {
                    dataPos = body;
                    dataLen = (size == 0 || sizeBad) ? (int)avail : (int)size;
                    if (size == 0)
                    {
                        // Size unknown (streamed writer). Data runs to the end of file.
                        break;
                    }
                }
                if (sizeBad)
                    break;

                long next = (long)body + size;
                if ((size & 1) != 0)
                {
                    // Word-alignment pad byte. Some writers omit it; detect that.
                    if (next + 1 + 4 <= len && LooksLikeTag(d, (int)next + 1))
                        next += 1;
                    else if (next + 4 <= len && LooksLikeTag(d, (int)next))
                    {
                        // pad omitted
                    }
                    else
                        next += 1;
                }
                pos = next;
            }

            // Fallback: brute-force search for chunk ids if the chunk walk failed (corrupt sizes).
            if (fmtPos < 0)
            {
                int f = Find(d, "fmt ", 12);
                if (f >= 0 && f + 8 + 14 <= len)
                {
                    fmtPos = f + 8;
                    fmtLen = (int)Math.Min(U32(d, f + 4), (uint)(len - fmtPos));
                }
            }
            if (dataPos < 0)
            {
                int f = Find(d, "data", 12);
                if (f >= 0 && f + 8 <= len)
                {
                    dataPos = f + 8;
                    uint size = U32(d, f + 4);
                    long avail = len - dataPos;
                    dataLen = (size == 0 || size > avail) ? (int)avail : (int)size;
                }
            }
            if (fmtPos < 0 || fmtLen < 14 || dataPos < 0 || dataLen <= 0)
                return false;

            int tag = U16(d, fmtPos);
            int ch = U16(d, fmtPos + 2);
            int sr = (int)Math.Min(U32(d, fmtPos + 4), int.MaxValue);
            int blockAlign = U16(d, fmtPos + 12);
            int bits = fmtLen >= 16 ? U16(d, fmtPos + 14) : 8;
            if (tag == FormatExtensible && fmtLen >= 26)
                tag = U16(d, fmtPos + 24);

            if (ch < 1 || ch > 16)
                return false;
            if (sr < 1 || sr > 1000000)
                return false;

            channels = ch;
            sampleRate = sr;

            switch (tag)
            {
                case FormatPcm:
                case FormatFloat:
                    samples = DecodeLinear(d, dataPos, dataLen, ch, bits, blockAlign, tag == FormatFloat);
                    break;
                case FormatALaw:
                case FormatMuLaw:
                    samples = DecodeG711(d, dataPos, dataLen, ch, tag == FormatALaw);
                    break;
                case FormatImaAdpcm:
                    samples = DecodeIma(d, fmtPos, fmtLen, dataPos, dataLen, ch, blockAlign);
                    break;
                case FormatMsAdpcm:
                    samples = DecodeMsAdpcm(d, fmtPos, fmtLen, dataPos, dataLen, ch, blockAlign);
                    break;
                default:
                    return false;
            }
            return samples != null && samples.Length > 0;
        }

        // ------------------------------------------------------------------ PCM / float

        static float[] DecodeLinear(byte[] d, int pos, int len, int ch, int bits, int blockAlign, bool isFloat)
        {
            int bps = (bits + 7) / 8;
            if (bps <= 0)
                bps = blockAlign > 0 ? blockAlign / ch : 2;
            // Container may be wider than the valid bits (e.g. 20 bits in 3 bytes, 24 in 4).
            if (blockAlign > 0 && blockAlign % ch == 0 && blockAlign / ch > bps && blockAlign / ch <= 8)
                bps = blockAlign / ch;
            if (isFloat)
            {
                if (bps != 4 && bps != 8)
                    return null;
            }
            else if (bps < 1 || bps > 4)
                return null;

            int frameBytes = bps * ch;
            int frames = len / frameBytes;
            if (frames <= 0)
                return null;
            float[] o = new float[frames * ch];
            int n = frames * ch;
            int p = pos;
            if (isFloat)
            {
                if (bps == 4)
                {
                    for (int i = 0; i < n; i++, p += 4)
                    {
                        float v = BitConverter.ToSingle(BitConverter.GetBytes((int)U32(d, p)), 0);
                        o[i] = Clamp(v);
                    }
                }
                else
                {
                    for (int i = 0; i < n; i++, p += 8)
                    {
                        long bitsL = (long)U32(d, p) | ((long)U32(d, p + 4) << 32);
                        o[i] = Clamp((float)BitConverter.Int64BitsToDouble(bitsL));
                    }
                }
                return o;
            }
            switch (bps)
            {
                case 1:
                    for (int i = 0; i < n; i++)
                        o[i] = (d[p + i] - 128) * (1f / 128f);
                    break;
                case 2:
                    for (int i = 0; i < n; i++, p += 2)
                        o[i] = (short)(d[p] | (d[p + 1] << 8)) * (1f / 32768f);
                    break;
                case 3:
                    for (int i = 0; i < n; i++, p += 3)
                        o[i] = ((d[p] << 8 | d[p + 1] << 16 | d[p + 2] << 24) >> 8) * (1f / 8388608f);
                    break;
                case 4:
                    for (int i = 0; i < n; i++, p += 4)
                        o[i] = (float)((int)U32(d, p) * (1.0 / 2147483648.0));
                    break;
            }
            return o;
        }

        static float Clamp(float v)
        {
            if (float.IsNaN(v)) return 0f;
            if (v > 1f) return 1f;
            if (v < -1f) return -1f;
            return v;
        }

        // ------------------------------------------------------------------ G.711

        static float[] DecodeG711(byte[] d, int pos, int len, int ch, bool alaw)
        {
            int frames = len / ch;
            if (frames <= 0)
                return null;
            int n = frames * ch;
            float[] table = new float[256];
            for (int i = 0; i < 256; i++)
                table[i] = (alaw ? ALawToLinear((byte)i) : MuLawToLinear((byte)i)) * (1f / 32768f);
            float[] o = new float[n];
            for (int i = 0; i < n; i++)
                o[i] = table[d[pos + i]];
            return o;
        }

        static int ALawToLinear(byte a)
        {
            int v = a ^ 0x55;
            int t = (v & 0x0F) << 4;
            int seg = (v & 0x70) >> 4;
            if (seg == 0) t += 8;
            else if (seg == 1) t += 0x108;
            else { t += 0x108; t <<= seg - 1; }
            return (v & 0x80) != 0 ? t : -t;
        }

        static int MuLawToLinear(byte u)
        {
            int v = ~u & 0xFF;
            int t = ((v & 0x0F) << 3) + 0x84;
            t <<= (v & 0x70) >> 4;
            return (v & 0x80) != 0 ? (0x84 - t) : (t - 0x84);
        }

        // ------------------------------------------------------------------ IMA ADPCM

        static float[] DecodeIma(byte[] d, int fmtPos, int fmtLen, int pos, int len, int ch, int blockAlign)
        {
            int headerBytes = 4 * ch;
            if (blockAlign <= headerBytes)
            {
                // Missing/broken blockAlign: guess the common phone values.
                blockAlign = ch == 1 ? 256 : 512;
                if (blockAlign > len) blockAlign = Math.Max(len, headerBytes + 4 * ch);
            }
            int maxSpb = (blockAlign - headerBytes) * 2 / ch + 1;
            int spb = maxSpb;
            if (fmtLen >= 20)
            {
                int cb = U16(d, fmtPos + 16);
                int given = U16(d, fmtPos + 18);
                if (cb >= 2 && given > 1 && given <= maxSpb)
                    spb = given;
            }

            int blocks = (len + blockAlign - 1) / blockAlign;
            long maxFrames = (long)blocks * spb;
            if (maxFrames <= 0 || maxFrames * ch > int.MaxValue / 2)
                return null;
            float[] o = new float[maxFrames * ch];
            int outFrames = 0;
            int end = pos + len;

            for (int b = 0; b < blocks; b++)
            {
                int bs = pos + b * blockAlign;
                int blen = Math.Min(blockAlign, end - bs);
                if (blen < headerBytes)
                    break;

                int framesAfterHeader;
                if (ch == 1)
                    framesAfterHeader = (blen - headerBytes) * 2;
                else
                    framesAfterHeader = ((blen - headerBytes) / (4 * ch)) * 8;
                if (framesAfterHeader > spb - 1)
                    framesAfterHeader = spb - 1;

                int dataStart = bs + headerBytes;
                for (int c = 0; c < ch; c++)
                {
                    int hp = bs + 4 * c;
                    int pred = (short)(d[hp] | (d[hp + 1] << 8));
                    int idx = d[hp + 2];
                    if (idx > 88) idx = 88;
                    o[outFrames * ch + c] = pred * (1f / 32768f);

                    for (int j = 0; j < framesAfterHeader; j++)
                    {
                        int byteIndex;
                        if (ch == 1)
                            byteIndex = dataStart + (j >> 1);
                        else
                            byteIndex = dataStart + (j >> 3) * 4 * ch + c * 4 + ((j & 7) >> 1);
                        int nib = (j & 1) == 0 ? (d[byteIndex] & 0x0F) : (d[byteIndex] >> 4);

                        int step = ImaStepTable[idx];
                        int diff = step >> 3;
                        if ((nib & 1) != 0) diff += step >> 2;
                        if ((nib & 2) != 0) diff += step >> 1;
                        if ((nib & 4) != 0) diff += step;
                        if ((nib & 8) != 0) pred -= diff; else pred += diff;
                        if (pred > 32767) pred = 32767; else if (pred < -32768) pred = -32768;
                        idx += ImaIndexTable[nib];
                        if (idx < 0) idx = 0; else if (idx > 88) idx = 88;

                        o[(outFrames + 1 + j) * ch + c] = pred * (1f / 32768f);
                    }
                }
                outFrames += 1 + framesAfterHeader;
            }
            return Trim(o, outFrames * ch);
        }

        // ------------------------------------------------------------------ Microsoft ADPCM

        static float[] DecodeMsAdpcm(byte[] d, int fmtPos, int fmtLen, int pos, int len, int ch, int blockAlign)
        {
            int headerBytes = 7 * ch;
            if (blockAlign <= headerBytes)
                return null;

            int[] coef1 = MsDefaultCoef1;
            int[] coef2 = MsDefaultCoef2;
            int maxSpb = (blockAlign - headerBytes) * 2 / ch + 2;
            int spb = maxSpb;
            if (fmtLen >= 22)
            {
                int cb = U16(d, fmtPos + 16);
                int given = U16(d, fmtPos + 18);
                if (cb >= 4 && given >= 2 && given <= maxSpb)
                    spb = given;
                int numCoef = U16(d, fmtPos + 20);
                if (cb >= 4 + numCoef * 4 && numCoef >= 1 && numCoef <= 256 && fmtLen >= 22 + numCoef * 4)
                {
                    coef1 = new int[numCoef];
                    coef2 = new int[numCoef];
                    for (int i = 0; i < numCoef; i++)
                    {
                        coef1[i] = (short)U16(d, fmtPos + 22 + i * 4);
                        coef2[i] = (short)U16(d, fmtPos + 24 + i * 4);
                    }
                }
            }

            int blocks = (len + blockAlign - 1) / blockAlign;
            long maxFrames = (long)blocks * spb;
            if (maxFrames <= 0 || maxFrames * ch > int.MaxValue / 2)
                return null;
            float[] o = new float[maxFrames * ch];
            int outFrames = 0;
            int end = pos + len;
            int[] s1 = new int[ch];
            int[] s2 = new int[ch];
            int[] delta = new int[ch];
            int[] c1 = new int[ch];
            int[] c2 = new int[ch];

            for (int b = 0; b < blocks; b++)
            {
                int bs = pos + b * blockAlign;
                int blen = Math.Min(blockAlign, end - bs);
                if (blen < headerBytes)
                    break;

                int p = bs;
                for (int c = 0; c < ch; c++)
                {
                    int pi = d[p++];
                    if (pi >= coef1.Length) pi = 0;
                    c1[c] = coef1[pi];
                    c2[c] = coef2[pi];
                }
                for (int c = 0; c < ch; c++, p += 2) delta[c] = (short)U16(d, p);
                for (int c = 0; c < ch; c++, p += 2) s1[c] = (short)U16(d, p);
                for (int c = 0; c < ch; c++, p += 2) s2[c] = (short)U16(d, p);

                for (int c = 0; c < ch; c++)
                {
                    o[outFrames * ch + c] = s2[c] * (1f / 32768f);
                    o[(outFrames + 1) * ch + c] = s1[c] * (1f / 32768f);
                }

                int nibbles = (blen - headerBytes) * 2;
                int framesAfterHeader = nibbles / ch;
                if (framesAfterHeader > spb - 2)
                    framesAfterHeader = spb - 2;
                if (framesAfterHeader < 0)
                    framesAfterHeader = 0;
                int totalNibbles = framesAfterHeader * ch;
                int dataStart = bs + headerBytes;
                int ob = (outFrames + 2) * ch;

                for (int k = 0; k < totalNibbles; k++)
                {
                    int byteVal = d[dataStart + (k >> 1)];
                    int nib = (k & 1) == 0 ? (byteVal >> 4) : (byteVal & 0x0F);
                    int c = k % ch;
                    int signedNib = nib >= 8 ? nib - 16 : nib;
                    int pred = (s1[c] * c1[c] + s2[c] * c2[c]) >> 8;
                    pred += signedNib * delta[c];
                    if (pred > 32767) pred = 32767; else if (pred < -32768) pred = -32768;
                    s2[c] = s1[c];
                    s1[c] = pred;
                    delta[c] = (MsAdaptationTable[nib] * delta[c]) >> 8;
                    if (delta[c] < 16) delta[c] = 16;
                    o[ob + k] = pred * (1f / 32768f);
                }
                outFrames += 2 + framesAfterHeader;
            }
            return Trim(o, outFrames * ch);
        }

        // ------------------------------------------------------------------ helpers

        static float[] Trim(float[] a, int n)
        {
            if (n <= 0) return null;
            if (n == a.Length) return a;
            float[] r = new float[n];
            Array.Copy(a, r, n);
            return r;
        }

        static bool IsTag(byte[] d, int p, string tag)
        {
            if (p < 0 || p + 4 > d.Length) return false;
            return d[p] == tag[0] && d[p + 1] == tag[1] && d[p + 2] == tag[2] && d[p + 3] == tag[3];
        }

        static bool LooksLikeTag(byte[] d, int p)
        {
            if (p < 0 || p + 4 > d.Length) return false;
            for (int i = 0; i < 4; i++)
            {
                byte b = d[p + i];
                if (b < 0x20 || b > 0x7E) return false;
            }
            // Chunk ids start with a letter in practice.
            byte f = d[p];
            return (f >= 'A' && f <= 'Z') || (f >= 'a' && f <= 'z');
        }

        static int Find(byte[] d, string tag, int start)
        {
            for (int i = Math.Max(0, start); i + 4 <= d.Length; i++)
                if (IsTag(d, i, tag)) return i;
            return -1;
        }

        static int U16(byte[] d, int p)
        {
            if (p < 0 || p + 2 > d.Length) return 0;
            return d[p] | (d[p + 1] << 8);
        }

        static uint U32(byte[] d, int p)
        {
            if (p < 0 || p + 4 > d.Length) return 0;
            return (uint)(d[p] | (d[p + 1] << 8) | (d[p + 2] << 16) | (d[p + 3] << 24));
        }
    }
}
