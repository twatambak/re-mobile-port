// javax.microedition.lcdui.Font rendered from pre-baked 1bpp glyphs (see FontData.cs).
using System.Collections.Generic;

namespace J2ME
{
    public sealed class Font
    {
        public const int FACE_SYSTEM = 0, FACE_MONOSPACE = 32, FACE_PROPORTIONAL = 64;
        public const int STYLE_PLAIN = 0, STYLE_BOLD = 1, STYLE_ITALIC = 2, STYLE_UNDERLINED = 4;
        public const int SIZE_SMALL = 8, SIZE_MEDIUM = 0, SIZE_LARGE = 16;
        public const int FONT_STATIC_TEXT = 0, FONT_INPUT_TEXT = 1;

        sealed class Glyphs
        {
            public int Height, Ascent;
            public readonly int[] Width = new int[224];
            public readonly int[] Offset = new int[224];
            public byte[] Bits;
        }

        static readonly Dictionary<int, Font> cache = new Dictionary<int, Font>();
        static readonly Dictionary<int, Glyphs> glyphCache = new Dictionary<int, Glyphs>();

        readonly int face, style, size;
        readonly Glyphs glyphs;

        Font(int face, int style, int size)
        {
            this.face = face;
            this.style = style;
            this.size = size;
            glyphs = LoadGlyphs(PixelSizeFor(size), (style & STYLE_BOLD) != 0);
        }

        /// <summary>Phone UI fonts scale with the screen; pick a baked size relative to a 240px-wide reference.</summary>
        static int PixelSizeFor(int size)
        {
            float scale = System.Math.Max(0.75f, Midp.ScreenWidth / 240f);
            float want = (size == SIZE_SMALL ? 11 : size == SIZE_LARGE ? 15 : 13) * scale;
            int best = FontData.PixelSizes[0];
            foreach (int s in FontData.PixelSizes)
                if (System.Math.Abs(s - want) < System.Math.Abs(best - want)) best = s;
            return best;
        }

        static Glyphs LoadGlyphs(int pixelSize, bool bold)
        {
            int key = pixelSize * 2 + (bold ? 1 : 0);
            lock (glyphCache)
            {
                if (glyphCache.TryGetValue(key, out var g)) return g;
                foreach (var e in FontData.Fonts)
                {
                    if (e.PixelSize != pixelSize || e.Bold != bold) continue;
                    g = new Glyphs { Height = e.Height, Ascent = e.Ascent, Bits = System.Convert.FromBase64String(e.Data) };
                    int p = 0;
                    for (int i = 0; i < 224; i++)
                    {
                        int w = g.Bits[p];
                        g.Width[i] = w;
                        g.Offset[i] = p + 1;
                        p += 1 + ((w + 7) / 8) * e.Height;
                    }
                    glyphCache[key] = g;
                    return g;
                }
                throw new System.InvalidOperationException("No baked font for size " + pixelSize);
            }
        }

        public static Font getFont(int face, int style, int size)
        {
            int key = (face << 16) | (style << 8) | size;
            lock (cache)
            {
                if (!cache.TryGetValue(key, out var f)) cache[key] = f = new Font(face, style, size);
                return f;
            }
        }

        public static Font getDefaultFont() { return getFont(FACE_SYSTEM, STYLE_PLAIN, SIZE_MEDIUM); }
        public static Font getFont(int specifier) { return getDefaultFont(); }

        public int getFace() { return face; }
        public int getStyle() { return style; }
        public int getSize() { return size; }
        public bool isPlain() { return style == 0; }
        public bool isBold() { return (style & STYLE_BOLD) != 0; }
        public bool isItalic() { return (style & STYLE_ITALIC) != 0; }
        public bool isUnderlined() { return (style & STYLE_UNDERLINED) != 0; }
        public int getHeight() { return glyphs.Height; }
        public int getBaselinePosition() { return glyphs.Ascent; }

        static int Index(char c)
        {
            int i = c - 32;
            return i >= 0 && i < 224 ? i : '?' - 32;
        }

        public int charWidth(char c) { return glyphs.Width[Index(c)]; }

        public int stringWidth(string s)
        {
            int w = 0;
            foreach (char c in s) w += glyphs.Width[Index(c)];
            return w;
        }

        public int substringWidth(string s, int offset, int len) { return stringWidth(s.Substring(offset, len)); }
        public int charsWidth(char[] ch, int offset, int length) { return stringWidth(new string(ch, offset, length)); }

        internal void Draw(Graphics g, string s, int x, int y, int anchor, int color)
        {
            if (s == null) throw new System.NullReferenceException();
            int w = stringWidth(s);
            if ((anchor & Graphics.HCENTER) != 0) x -= w / 2;
            else if ((anchor & Graphics.RIGHT) != 0) x -= w;
            if ((anchor & Graphics.BASELINE) != 0) y -= glyphs.Ascent;
            else if ((anchor & Graphics.BOTTOM) != 0) y -= glyphs.Height;

            int h = glyphs.Height;
            bool italic = (style & STYLE_ITALIC) != 0;
            foreach (char ch in s)
            {
                int i = Index(ch);
                int gw = glyphs.Width[i], bpr = (gw + 7) / 8, p = glyphs.Offset[i];
                for (int row = 0; row < h; row++)
                {
                    int slant = italic ? (h - row) / 4 : 0;
                    for (int col = 0; col < gw; col++)
                        if ((glyphs.Bits[p + row * bpr + (col >> 3)] & (0x80 >> (col & 7))) != 0)
                            g.SetPixelAbs(x + col + slant, y + row, color);
                }
                x += gw;
            }
            if ((style & STYLE_UNDERLINED) != 0)
                for (int i = 0; i < w; i++) g.SetPixelAbs(x - w + i, y + glyphs.Ascent + 1, color);
        }
    }
}
