// Lenient PNG decoder. CRCs and the zlib Adler-32 are ignored on purpose: J2ME games commonly patch
// palettes inside in-memory PNGs without recomputing checksums, and handsets accepted that.
using System.IO;
using System.IO.Compression;

namespace J2ME
{
    public static class PngDecoder
    {
        public static bool TryDecode(byte[] data, int offset, int length, out int[] argb, out int width, out int height)
        {
            argb = null;
            width = height = 0;
            try { return Decode(data, offset, length, out argb, out width, out height); }
            catch (System.Exception e)
            {
                Midp.Log("PNG decode failed: " + e.Message);
                return false;
            }
        }

        static int BE32(byte[] d, int p) { return (d[p] << 24) | (d[p + 1] << 16) | (d[p + 2] << 8) | d[p + 3]; }

        static bool Decode(byte[] d, int off, int len, out int[] argb, out int width, out int height)
        {
            argb = null;
            width = height = 0;
            int end = off + len;
            if (len < 8 || d[off] != 0x89 || d[off + 1] != 'P' || d[off + 2] != 'N' || d[off + 3] != 'G') return false;

            int bitDepth = 0, colorType = 0, interlace = 0;
            int[] palette = null;
            byte[] trns = null;
            var idat = new MemoryStream();
            int p = off + 8;
            while (p + 8 <= end)
            {
                int clen = BE32(d, p);
                int type = BE32(d, p + 4);
                int cdata = p + 8;
                if (clen < 0 || cdata + clen > end) clen = System.Math.Max(0, end - cdata);
                switch (type)
                {
                    case 0x49484452: // IHDR
                        width = BE32(d, cdata);
                        height = BE32(d, cdata + 4);
                        bitDepth = d[cdata + 8];
                        colorType = d[cdata + 9];
                        interlace = d[cdata + 12];
                        break;
                    case 0x504C5445: // PLTE
                        palette = new int[256];
                        for (int i = 0; i < clen / 3; i++)
                            palette[i] = unchecked((int)0xFF000000) | (d[cdata + i * 3] << 16) | (d[cdata + i * 3 + 1] << 8) | d[cdata + i * 3 + 2];
                        break;
                    case 0x74524E53: // tRNS
                        trns = new byte[clen];
                        System.Buffer.BlockCopy(d, cdata, trns, 0, clen);
                        break;
                    case 0x49444154: // IDAT
                        idat.Write(d, cdata, clen);
                        break;
                }
                if (type == 0x49454E44) break; // IEND
                p = cdata + clen + 4;
            }
            if (width <= 0 || height <= 0) return false;

            byte[] raw;
            var z = idat.ToArray();
            using (var input = new MemoryStream(z, 2, System.Math.Max(0, z.Length - 2)))
            using (var inflater = new DeflateStream(input, CompressionMode.Decompress))
            using (var output = new MemoryStream())
            {
                try { inflater.CopyTo(output); }
                catch (InvalidDataException) { /* truncated stream: keep what was inflated */ }
                raw = output.ToArray();
            }

            int channels;
            switch (colorType)
            {
                case 0: channels = 1; break;
                case 2: channels = 3; break;
                case 3: channels = 1; break;
                case 4: channels = 2; break;
                case 6: channels = 4; break;
                default: return false;
            }
            int bpp = channels * bitDepth;              // bits per pixel
            int bytesPP = System.Math.Max(1, bpp / 8);  // filter unit

            if (palette != null && trns != null)
                for (int i = 0; i < trns.Length && i < 256; i++)
                    palette[i] = (palette[i] & 0xFFFFFF) | (trns[i] << 24);

            argb = new int[width * height];
            if (interlace == 0)
            {
                DecodePass(raw, 0, width, height, bpp, bytesPP, bitDepth, colorType, palette, trns, argb, width, 0, 0, 1, 1);
            }
            else
            {
                int[] sx = { 0, 4, 0, 2, 0, 1, 0 }, sy = { 0, 0, 4, 0, 2, 0, 1 };
                int[] dx = { 8, 8, 4, 4, 2, 2, 1 }, dy = { 8, 8, 8, 4, 4, 2, 2 };
                int pos = 0;
                for (int pass = 0; pass < 7; pass++)
                {
                    int pw = (width - sx[pass] + dx[pass] - 1) / dx[pass];
                    int ph = (height - sy[pass] + dy[pass] - 1) / dy[pass];
                    if (pw <= 0 || ph <= 0) continue;
                    pos = DecodePass(raw, pos, pw, ph, bpp, bytesPP, bitDepth, colorType, palette, trns, argb, width, sx[pass], sy[pass], dx[pass], dy[pass]);
                }
            }
            return true;
        }

        static int DecodePass(byte[] raw, int pos, int w, int h, int bpp, int bytesPP, int bitDepth, int colorType,
                              int[] palette, byte[] trns, int[] dst, int dstW, int ox, int oy, int sx, int sy)
        {
            int stride = (w * bpp + 7) / 8;
            var prev = new byte[stride];
            var cur = new byte[stride];
            for (int y = 0; y < h; y++)
            {
                if (pos >= raw.Length) break;
                int filter = raw[pos++];
                int n = System.Math.Min(stride, raw.Length - pos);
                System.Array.Clear(cur, 0, stride);
                System.Buffer.BlockCopy(raw, pos, cur, 0, n);
                pos += stride;
                Unfilter(filter, cur, prev, bytesPP);
                int row = (oy + y * sy) * dstW;
                for (int x = 0; x < w; x++)
                    dst[row + ox + x * sx] = Pixel(cur, x, bitDepth, colorType, palette, trns);
                var t = prev; prev = cur; cur = t;
            }
            return pos;
        }

        static void Unfilter(int filter, byte[] cur, byte[] prev, int bpp)
        {
            int n = cur.Length;
            switch (filter)
            {
                case 1:
                    for (int i = bpp; i < n; i++) cur[i] = (byte)(cur[i] + cur[i - bpp]);
                    break;
                case 2:
                    for (int i = 0; i < n; i++) cur[i] = (byte)(cur[i] + prev[i]);
                    break;
                case 3:
                    for (int i = 0; i < n; i++) cur[i] = (byte)(cur[i] + (((i >= bpp ? cur[i - bpp] : 0) + prev[i]) >> 1));
                    break;
                case 4:
                    for (int i = 0; i < n; i++)
                    {
                        int a = i >= bpp ? cur[i - bpp] : 0, b = prev[i], c = i >= bpp ? prev[i - bpp] : 0;
                        int pp = a + b - c, pa = System.Math.Abs(pp - a), pb = System.Math.Abs(pp - b), pc = System.Math.Abs(pp - c);
                        cur[i] = (byte)(cur[i] + (pa <= pb && pa <= pc ? a : pb <= pc ? b : c));
                    }
                    break;
            }
        }

        static int Sample(byte[] row, int index, int bitDepth)
        {
            switch (bitDepth)
            {
                case 8: return row[index];
                case 16: return row[index * 2];
                default:
                    int bit = index * bitDepth;
                    int shift = 8 - bitDepth - (bit & 7);
                    return (row[bit >> 3] >> shift) & ((1 << bitDepth) - 1);
            }
        }

        static int Pixel(byte[] row, int x, int bitDepth, int colorType, int[] palette, byte[] trns)
        {
            switch (colorType)
            {
                case 3:
                {
                    int i = Sample(row, x, bitDepth);
                    return palette != null ? palette[i] : unchecked((int)0xFF000000);
                }
                case 0:
                {
                    int v = Sample(row, x, bitDepth);
                    int raw16 = bitDepth == 16 ? (row[x * 2] << 8) | row[x * 2 + 1] : v;
                    int g = bitDepth < 8 ? v * 255 / ((1 << bitDepth) - 1) : v;
                    int a = 255;
                    if (trns != null && trns.Length >= 2 && ((trns[0] << 8) | trns[1]) == raw16) a = 0;
                    return (a << 24) | (g << 16) | (g << 8) | g;
                }
                case 2:
                {
                    int r = Sample(row, x * 3, bitDepth), g = Sample(row, x * 3 + 1, bitDepth), b = Sample(row, x * 3 + 2, bitDepth);
                    int a = 255;
                    if (trns != null && trns.Length >= 6)
                    {
                        int k = bitDepth == 16 ? 0 : 1;
                        if (trns[k] == r && trns[2 + k] == g && trns[4 + k] == b) a = 0;
                    }
                    return (a << 24) | (r << 16) | (g << 8) | b;
                }
                case 4:
                {
                    int g = Sample(row, x * 2, bitDepth), a = Sample(row, x * 2 + 1, bitDepth);
                    return (a << 24) | (g << 16) | (g << 8) | g;
                }
                default:
                {
                    int r = Sample(row, x * 4, bitDepth), g = Sample(row, x * 4 + 1, bitDepth);
                    int b = Sample(row, x * 4 + 2, bitDepth), a = Sample(row, x * 4 + 3, bitDepth);
                    return (a << 24) | (r << 16) | (g << 8) | b;
                }
            }
        }
    }
}
