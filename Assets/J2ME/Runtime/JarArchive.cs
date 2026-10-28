// Minimal ZIP reader for MIDlet JARs (stored + deflate). Avoids System.IO.Compression.ZipArchive,
// which is not reliably available under every Unity scripting backend.
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;

namespace J2ME
{
    public sealed class JarArchive
    {
        struct Entry
        {
            public int LocalHeaderOffset;
            public int Method;
            public int CompressedSize;
            public int Size;
        }

        readonly byte[] data;
        readonly Dictionary<string, Entry> entries = new Dictionary<string, Entry>();
        readonly Dictionary<string, byte[]> cache = new Dictionary<string, byte[]>();

        public JarArchive(byte[] data)
        {
            this.data = data;
            ReadCentralDirectory();
        }

        public IEnumerable<string> Names => entries.Keys;

        public bool Contains(string name) { return entries.ContainsKey(name); }

        public byte[] GetBytes(string name)
        {
            lock (cache)
            {
                if (cache.TryGetValue(name, out var cached)) return cached;
                if (!entries.TryGetValue(name, out var e)) return null;
                var bytes = Extract(e);
                cache[name] = bytes;
                return bytes;
            }
        }

        int U16(int p) { return data[p] | (data[p + 1] << 8); }
        int I32(int p) { return data[p] | (data[p + 1] << 8) | (data[p + 2] << 16) | (data[p + 3] << 24); }

        void ReadCentralDirectory()
        {
            int eocd = -1;
            for (int p = data.Length - 22; p >= System.Math.Max(0, data.Length - 22 - 65535); p--)
            {
                if (I32(p) == 0x06054b50) { eocd = p; break; }
            }
            if (eocd < 0)
            {
                ScanLocalHeaders();
                return;
            }

            int count = U16(eocd + 10);
            int p2 = I32(eocd + 16);
            for (int i = 0; i < count && p2 + 46 <= data.Length; i++)
            {
                if (I32(p2) != 0x02014b50) break;
                int method = U16(p2 + 10);
                int csize = I32(p2 + 20);
                int size = I32(p2 + 24);
                int nameLen = U16(p2 + 28);
                int extraLen = U16(p2 + 30);
                int commentLen = U16(p2 + 32);
                int local = I32(p2 + 42);
                string name = System.Text.Encoding.UTF8.GetString(data, p2 + 46, nameLen);
                if (!name.EndsWith("/"))
                    entries[name] = new Entry { LocalHeaderOffset = local, Method = method, CompressedSize = csize, Size = size };
                p2 += 46 + nameLen + extraLen + commentLen;
            }
        }

        // Fallback for archives with a damaged central directory.
        void ScanLocalHeaders()
        {
            int p = 0;
            while (p + 30 <= data.Length && I32(p) == 0x04034b50)
            {
                int method = U16(p + 8);
                int csize = I32(p + 18);
                int size = I32(p + 22);
                int nameLen = U16(p + 26);
                int extraLen = U16(p + 28);
                string name = System.Text.Encoding.UTF8.GetString(data, p + 30, nameLen);
                if (!name.EndsWith("/"))
                    entries[name] = new Entry { LocalHeaderOffset = p, Method = method, CompressedSize = csize, Size = size };
                p += 30 + nameLen + extraLen + csize;
            }
        }

        byte[] Extract(Entry e)
        {
            int p = e.LocalHeaderOffset;
            int start = p + 30 + U16(p + 26) + U16(p + 28);
            int csize = System.Math.Min(e.CompressedSize, data.Length - start);
            if (e.Method == 0)
            {
                var r = new byte[csize];
                System.Buffer.BlockCopy(data, start, r, 0, csize);
                return r;
            }

            using (var input = new MemoryStream(data, start, csize, false))
            using (var inflater = new DeflateStream(input, CompressionMode.Decompress))
            using (var output = new MemoryStream(System.Math.Max(e.Size, 16)))
            {
                inflater.CopyTo(output);
                return output.ToArray();
            }
        }
    }
}
