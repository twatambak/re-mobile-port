using System;

namespace J2ME.Audio
{
    /// <summary>
    /// Entry point used by the MIDP Manager.createPlayer emulation: sniffs the blob and dispatches
    /// to the WAV decoder or the MIDI synthesizer. Unsupported formats (AMR, MP3, AAC, PMD, ...)
    /// return false. Never throws.
    /// </summary>
    public static class AudioDecoder
    {
        public static bool TryDecode(byte[] data, string mimeType, int midiSampleRate,
            out float[] samples, out int channels, out int sampleRate)
        {
            samples = Array.Empty<float>();
            channels = 0;
            sampleRate = 0;
            try
            {
                if (data == null || data.Length < 4)
                    return false;

                Kind kind = Sniff(data);
                if (kind == Kind.Unknown)
                    kind = FromMime(mimeType);

                switch (kind)
                {
                    case Kind.Wav:
                        return WavDecoder.TryDecode(data, out samples, out channels, out sampleRate);
                    case Kind.Midi:
                    {
                        int sr = midiSampleRate;
                        if (sr <= 0) sr = 22050;
                        if (sr < 8000) sr = 8000;
                        if (sr > 96000) sr = 96000;
                        int ch;
                        float[] s = MidiSynth.Render(data, sr, out ch);
                        if (s == null || s.Length == 0)
                        {
                            samples = Array.Empty<float>();
                            return false;
                        }
                        samples = s;
                        channels = ch;
                        sampleRate = sr;
                        return true;
                    }
                    default:
                        return false;
                }
            }
            catch (Exception)
            {
                samples = Array.Empty<float>();
                channels = 0;
                sampleRate = 0;
                return false;
            }
        }

        enum Kind { Unknown, Wav, Midi, Unsupported }

        static Kind Sniff(byte[] d)
        {
            if (Tag(d, 0, "MThd"))
                return Kind.Midi;
            if (d.Length >= 12 && Tag(d, 0, "RIFF"))
            {
                if (Tag(d, 8, "WAVE")) return Kind.Wav;
                if (Tag(d, 8, "RMID")) return Kind.Midi;
            }
            // Known unsupported signatures: let the caller fall back gracefully.
            if (d.Length >= 5 && Tag(d, 0, "#!AM")) return Kind.Unsupported;           // AMR / AMR-WB
            if (Tag(d, 0, "ID3")) return Kind.Unsupported;                              // MP3 with ID3
            if (d.Length >= 2 && d[0] == 0xFF && (d[1] & 0xE0) == 0xE0) return Kind.Unsupported; // MPEG/ADTS sync
            if (Tag(d, 4, "ftyp")) return Kind.Unsupported;                             // MP4 / 3GP / M4A
            if (Tag(d, 0, "melo") || Tag(d, 0, "MMMD")) return Kind.Unsupported;       // PMD / SMAF
            return Kind.Unknown;
        }

        static Kind FromMime(string mime)
        {
            if (string.IsNullOrEmpty(mime))
                return Kind.Unknown;
            string m = mime.Trim().ToLowerInvariant();
            int semi = m.IndexOf(';');
            if (semi >= 0) m = m.Substring(0, semi).Trim();
            switch (m)
            {
                case "audio/x-wav":
                case "audio/wav":
                case "audio/wave":
                case "audio/vnd.wave":
                    return Kind.Wav;
                case "audio/midi":
                case "audio/mid":
                case "audio/x-midi":
                case "audio/sp-midi":
                case "audio/x-mid":
                    return Kind.Midi;
                default:
                    return Kind.Unknown;
            }
        }

        static bool Tag(byte[] d, int p, string t)
        {
            if (p + t.Length > d.Length) return false;
            for (int i = 0; i < t.Length; i++)
                if (d[p + i] != (byte)t[i]) return false;
            return true;
        }
    }
}
