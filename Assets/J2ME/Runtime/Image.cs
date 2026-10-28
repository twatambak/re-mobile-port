// javax.microedition.lcdui.Image backed by an ARGB int[].
namespace J2ME
{
    public class Image
    {
        internal const int AlphaNone = 0;    // every pixel opaque
        internal const int AlphaBinary = 1;  // alpha is 0 or 255 only
        internal const int AlphaFull = 2;    // translucent pixels present

        internal int[] pixels;
        internal int width, height;
        internal bool mutable;
        internal int alphaKind;

        Image(int w, int h, int[] px, bool mutable, int alphaKind)
        {
            width = w;
            height = h;
            pixels = px;
            this.mutable = mutable;
            this.alphaKind = alphaKind;
        }

        internal static int ClassifyAlpha(int[] px)
        {
            int kind = AlphaNone;
            foreach (int c in px)
            {
                int a = (int)((uint)c >> 24);
                if (a == 255) continue;
                if (a != 0) return AlphaFull;
                kind = AlphaBinary;
            }
            return kind;
        }

        public static Image createImage(int width, int height)
        {
            if (width <= 0 || height <= 0) throw new System.ArgumentException("bad image size");
            var px = new int[width * height];
            for (int i = 0; i < px.Length; i++) px[i] = -1; // opaque white
            return new Image(width, height, px, true, AlphaNone);
        }

        public static Image createImage(string name)
        {
            var data = Midp.GetResourceBytes(name);
            if (data == null) throw new IOException("Resource not found: " + name);
            return createImage(data, 0, data.Length);
        }

        public static Image createImage(sbyte[] data, int offset, int length)
        {
            if (!PngDecoder.TryDecode(ByteConv.ToUnsigned(data, offset, length), 0, length, out var px, out int w, out int h))
                throw new System.ArgumentException("Unsupported image data");
            return new Image(w, h, px, false, ClassifyAlpha(px));
        }

        public static Image createImage(InputStream stream)
        {
            var bytes = new ByteArrayOutputStream(4096);
            var buf = new sbyte[4096];
            int n;
            while ((n = stream.read(buf, 0, buf.Length)) > 0) bytes.write(buf, 0, n);
            var data = bytes.toByteArray();
            return createImage(data, 0, data.Length);
        }

        public static Image createImage(Image source)
        {
            if (!source.mutable) return source;
            return new Image(source.width, source.height, (int[])source.pixels.Clone(), false, AlphaNone);
        }

        public static Image createImage(Image image, int x, int y, int width, int height, int transform)
        {
            bool swap = (transform & 4) != 0;
            int dw = swap ? height : width, dh = swap ? width : height;
            var px = new int[dw * dh];
            var g = new Graphics(px, dw, dh, false);
            g.Blit(image.pixels, 0, image.width, x, y, width, height, transform, 0, 0, AlphaNone);
            // Blit with AlphaNone forces opacity; restore the source alpha channel exactly.
            if (image.alphaKind != AlphaNone)
            {
                var alphaOnly = new int[dw * dh];
                var ga = new Graphics(alphaOnly, dw, dh, false);
                var src = new int[image.pixels.Length];
                for (int i = 0; i < src.Length; i++) src[i] = (int)((uint)image.pixels[i] >> 24);
                ga.Blit(src, 0, image.width, x, y, width, height, transform, 0, 0, AlphaNone);
                for (int i = 0; i < px.Length; i++) px[i] = (px[i] & 0xFFFFFF) | ((alphaOnly[i] & 0xFF) << 24);
            }
            return new Image(dw, dh, px, false, ClassifyAlpha(px));
        }

        public static Image createRGBImage(int[] rgb, int width, int height, bool processAlpha)
        {
            var px = new int[width * height];
            System.Array.Copy(rgb, px, px.Length);
            if (!processAlpha)
                for (int i = 0; i < px.Length; i++) px[i] |= unchecked((int)0xFF000000);
            return new Image(width, height, px, false, processAlpha ? ClassifyAlpha(px) : AlphaNone);
        }

        public Graphics getGraphics()
        {
            if (!mutable) throw new System.InvalidOperationException("Image is immutable");
            return new Graphics(pixels, width, height, true);
        }

        public int getWidth() { return width; }
        public int getHeight() { return height; }
        public bool isMutable() { return mutable; }

        public void getRGB(int[] rgbData, int offset, int scanlength, int x, int y, int w, int h)
        {
            for (int j = 0; j < h; j++)
                System.Array.Copy(pixels, (y + j) * width + x, rgbData, offset + j * scanlength, w);
        }
    }
}
