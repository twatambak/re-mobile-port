// Headless runner: boots a MIDlet from its JAR, replays a key/touch script and dumps frames as PNG.
// usage: Runner <game> <jar> <outDir> [script]
//   game: gameloft | glu
//   script: semicolon-separated steps: "wait:ms", "key:code", "hold:code:ms", "tap:x:y", "shot:name"
using System.IO.Compression;
using J2ME;

static class Program
{
    static int Main(string[] args)
    {
        string game = args[0], jar = args[1], outDir = args[2];
        string script = args.Length > 3 ? args[3] : "wait:3000;shot:boot";
        Directory.CreateDirectory(outDir);
        Midp.StorageDirectory = Path.Combine(outDir, "rms");
        Midp.Verbose = Environment.GetEnvironmentVariable("J2ME_VERBOSE") == "1";
        Midp.Logger = s => Console.WriteLine("[midp] " + s);
        if (Environment.GetEnvironmentVariable("J2ME_FCE") == "1")
            AppDomain.CurrentDomain.FirstChanceException += (s, e) =>
                Console.WriteLine("[fce] " + e.Exception.GetType().Name + ": " + e.Exception.Message + "\n"
                                  + string.Join("\n", new System.Diagnostics.StackTrace(1, true).ToString().Split('\n').Take(6)));
        Midp.LoadJar(File.ReadAllBytes(jar));

        Func<MIDlet> factory;
        switch (game)
        {
            case "glu":
                Midp.ScreenWidth = int.Parse(Environment.GetEnvironmentVariable("J2ME_W") ?? "240"); Midp.ScreenHeight = int.Parse(Environment.GetEnvironmentVariable("J2ME_H") ?? "320");
                factory = () => new REUprising.Glu.REUprisingLEMIDlet();
                break;
            case "gameloft":
                Midp.ScreenWidth = 360; Midp.ScreenHeight = 640;
                factory = () => new REUprising.Gameloft.GloftRESE();
                break;
            default:
                Console.Error.WriteLine("unknown game " + game);
                return 1;
        }
        Midp.Launch(factory);

        foreach (var step in script.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries))
        {
            var p = step.Split(':');
            switch (p[0])
            {
                case "wait": System.Threading.Thread.Sleep(int.Parse(p[1])); break;
                case "key":
                    Midp.PostKeyPressed(int.Parse(p[1])); System.Threading.Thread.Sleep(120);
                    Midp.PostKeyReleased(int.Parse(p[1])); System.Threading.Thread.Sleep(200); break;
                case "hold":
                    Midp.PostKeyPressed(int.Parse(p[1])); System.Threading.Thread.Sleep(int.Parse(p[2]));
                    Midp.PostKeyReleased(int.Parse(p[1])); break;
                case "tap":
                    Midp.PostPointerPressed(int.Parse(p[1]), int.Parse(p[2])); System.Threading.Thread.Sleep(120);
                    Midp.PostPointerReleased(int.Parse(p[1]), int.Parse(p[2])); System.Threading.Thread.Sleep(200); break;
                case "shot": Shot(Path.Combine(outDir, p[1] + ".png")); break;
            }
        }
        Console.WriteLine($"frames presented: {Midp.FrameCount}");
        Midp.Shutdown();
        return 0;
    }

    static void Shot(string path)
    {
        int w = Midp.ScreenWidth, h = Midp.ScreenHeight;
        var px = new int[w * h];
        long frame = Midp.CopyFrame(px);
        var raw = new MemoryStream();
        for (int y = 0; y < h; y++)
        {
            raw.WriteByte(0);
            for (int x = 0; x < w; x++)
            {
                int c = px[y * w + x];
                raw.WriteByte((byte)(c >> 16)); raw.WriteByte((byte)(c >> 8)); raw.WriteByte((byte)c);
            }
        }
        var z = new MemoryStream();
        z.WriteByte(0x78); z.WriteByte(0x01);
        using (var ds = new DeflateStream(z, CompressionLevel.Fastest, true)) raw.WriteTo(ds);
        uint a = 1, b2 = 0;
        foreach (var by in raw.ToArray()) { a = (a + by) % 65521; b2 = (b2 + a) % 65521; }
        Put(z, BE((int)((b2 << 16) | a)));
        using var f = File.Create(path);
        Put(f, new byte[] { 0x89, 0x50, 0x4E, 0x47, 0x0D, 0x0A, 0x1A, 0x0A });
        Chunk(f, "IHDR", BE(w).Concat(BE(h)).Concat(new byte[] { 8, 2, 0, 0, 0 }).ToArray());
        Chunk(f, "IDAT", z.ToArray());
        Chunk(f, "IEND", Array.Empty<byte>());
        Console.WriteLine($"shot {path} (frame {frame})");
    }

    static void Put(Stream s, byte[] d) => s.Write(d, 0, d.Length);

    static byte[] BE(int v) => new[] { (byte)(v >> 24), (byte)(v >> 16), (byte)(v >> 8), (byte)v };

    static void Chunk(Stream s, string type, byte[] data)
    {
        var t = System.Text.Encoding.ASCII.GetBytes(type);
        Put(s, BE(data.Length));
        Put(s, t);
        Put(s, data);
        uint crc = 0xFFFFFFFF;
        foreach (var b in t.Concat(data))
        {
            crc ^= b;
            for (int k = 0; k < 8; k++) crc = (crc & 1) != 0 ? (crc >> 1) ^ 0xEDB88320 : crc >> 1;
        }
        Put(s, BE((int)~crc));
    }
}
