// javax.microedition.lcdui.Graphics: a software rasterizer over an ARGB int[] surface.
// Coordinates follow MIDP: translation applies to everything, the clip is kept in absolute surface space.
namespace J2ME
{
    public class Graphics
    {
        public const int HCENTER = 1, VCENTER = 2, LEFT = 4, RIGHT = 8, TOP = 16, BOTTOM = 32, BASELINE = 64;
        public const int SOLID = 0, DOTTED = 1;

        internal readonly int[] pix;
        internal readonly int tw, th;
        int tx, ty;
        int cx0, cy0, cx1, cy1;
        int color = unchecked((int)0xFF000000);
        int stroke;
        Font font;

        internal Graphics(int[] pixels, int width, int height, bool opaque)
        {
            pix = pixels;
            tw = width;
            th = height;
            ResetForPaint();
        }

        internal void ResetForPaint()
        {
            tx = ty = 0;
            cx0 = cy0 = 0;
            cx1 = tw;
            cy1 = th;
            color = unchecked((int)0xFF000000);
            stroke = SOLID;
            font = Font.getDefaultFont();
        }

        // ------------------------------------------------------------ state

        public void translate(int x, int y) { tx += x; ty += y; }
        public int getTranslateX() { return tx; }
        public int getTranslateY() { return ty; }

        public void setColor(int rgb) { color = rgb | unchecked((int)0xFF000000); }
        public void setColor(int r, int g, int b) { color = unchecked((int)0xFF000000) | ((r & 0xFF) << 16) | ((g & 0xFF) << 8) | (b & 0xFF); }
        public int getColor() { return color & 0xFFFFFF; }
        public int getRedComponent() { return (color >> 16) & 0xFF; }
        public int getGreenComponent() { return (color >> 8) & 0xFF; }
        public int getBlueComponent() { return color & 0xFF; }
        public void setGrayScale(int v) { setColor(v, v, v); }
        public int getGrayScale() { return (getRedComponent() + getGreenComponent() + getBlueComponent()) / 3; }
        public int getDisplayColor(int c) { return c & 0xFFFFFF; }
        public void setStrokeStyle(int s) { stroke = s; }
        public int getStrokeStyle() { return stroke; }
        public void setFont(Font f) { font = f ?? Font.getDefaultFont(); }
        public Font getFont() { return font; }

        public int getClipX() { return cx0 - tx; }
        public int getClipY() { return cy0 - ty; }
        public int getClipWidth() { return cx1 - cx0; }
        public int getClipHeight() { return cy1 - cy0; }

        public void setClip(int x, int y, int w, int h)
        {
            long x0 = (long)x + tx, y0 = (long)y + ty;
            long x1 = x0 + System.Math.Max(w, 0), y1 = y0 + System.Math.Max(h, 0);
            cx0 = (int)Clamp(x0, 0, tw);
            cy0 = (int)Clamp(y0, 0, th);
            cx1 = (int)Clamp(x1, cx0, tw);
            cy1 = (int)Clamp(y1, cy0, th);
        }

        public void clipRect(int x, int y, int w, int h)
        {
            long x0 = (long)x + tx, y0 = (long)y + ty;
            long x1 = x0 + System.Math.Max(w, 0), y1 = y0 + System.Math.Max(h, 0);
            int nx0 = (int)Clamp(System.Math.Max(x0, cx0), 0, tw);
            int ny0 = (int)Clamp(System.Math.Max(y0, cy0), 0, th);
            int nx1 = (int)Clamp(System.Math.Min(x1, cx1), nx0, tw);
            int ny1 = (int)Clamp(System.Math.Min(y1, cy1), ny0, th);
            cx0 = nx0; cy0 = ny0; cx1 = nx1; cy1 = ny1;
        }

        static long Clamp(long v, long lo, long hi) { return v < lo ? lo : v > hi ? hi : v; }

        // ------------------------------------------------------------ primitives

        void FillAbs(long x0, long y0, long x1, long y1, int c)
        {
            if (x0 < cx0) x0 = cx0;
            if (y0 < cy0) y0 = cy0;
            if (x1 > cx1) x1 = cx1;
            if (y1 > cy1) y1 = cy1;
            if (x0 >= x1 || y0 >= y1) return;
            int w = (int)(x1 - x0);
            for (int y = (int)y0; y < y1; y++)
                new System.Span<int>(pix, y * tw + (int)x0, w).Fill(c);
        }

        void Plot(int ax, int ay)
        {
            if (ax >= cx0 && ax < cx1 && ay >= cy0 && ay < cy1) pix[ay * tw + ax] = color;
        }

        public void fillRect(int x, int y, int w, int h)
        {
            if (w <= 0 || h <= 0) return;
            long x0 = (long)x + tx, y0 = (long)y + ty;
            FillAbs(x0, y0, x0 + w, y0 + h, color);
        }

        public void drawRect(int x, int y, int w, int h)
        {
            if (w < 0 || h < 0) return;
            long x0 = (long)x + tx, y0 = (long)y + ty;
            FillAbs(x0, y0, x0 + w + 1, y0 + 1, color);
            if (h > 0) FillAbs(x0, y0 + h, x0 + w + 1, y0 + h + 1, color);
            if (h > 1)
            {
                FillAbs(x0, y0 + 1, x0 + 1, y0 + h, color);
                if (w > 0) FillAbs(x0 + w, y0 + 1, x0 + w + 1, y0 + h, color);
            }
        }

        public void drawLine(int x1, int y1, int x2, int y2)
        {
            x1 += tx; y1 += ty; x2 += tx; y2 += ty;
            if (y1 == y2) { FillAbs(System.Math.Min(x1, x2), y1, System.Math.Max(x1, x2) + 1L, y1 + 1L, color); return; }
            if (x1 == x2) { FillAbs(x1, System.Math.Min(y1, y2), x1 + 1L, System.Math.Max(y1, y2) + 1L, color); return; }
            int dx = System.Math.Abs(x2 - x1), sx = x1 < x2 ? 1 : -1;
            int dy = -System.Math.Abs(y2 - y1), sy = y1 < y2 ? 1 : -1;
            int err = dx + dy, n = 0;
            while (true)
            {
                if (stroke == SOLID || (n & 2) == 0) Plot(x1, y1);
                n++;
                if (x1 == x2 && y1 == y2) break;
                int e2 = 2 * err;
                if (e2 >= dy) { err += dy; x1 += sx; }
                if (e2 <= dx) { err += dx; y1 += sy; }
            }
        }

        public void fillTriangle(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            double ax = x1 + tx, ay = y1 + ty, bx = x2 + tx, by = y2 + ty, qx = x3 + tx, qy = y3 + ty;
            int minY = (int)System.Math.Max(cy0, System.Math.Min(ay, System.Math.Min(by, qy)));
            int maxY = (int)System.Math.Min(cy1 - 1, System.Math.Max(ay, System.Math.Max(by, qy)));
            for (int y = minY; y <= maxY; y++)
            {
                double sy = y + 0.5;
                double lo = double.MaxValue, hi = double.MinValue;
                EdgeSpan(ax, ay, bx, by, sy, ref lo, ref hi);
                EdgeSpan(bx, by, qx, qy, sy, ref lo, ref hi);
                EdgeSpan(qx, qy, ax, ay, sy, ref lo, ref hi);
                if (lo > hi) continue;
                long xs = (long)System.Math.Ceiling(lo - 0.5), xe = (long)System.Math.Floor(hi - 0.5) + 1;
                if (xe <= xs) xe = xs + 1;
                FillAbs(xs, y, xe, y + 1, color);
            }
        }

        static void EdgeSpan(double x0, double y0, double x1, double y1, double sy, ref double lo, ref double hi)
        {
            if (y0 == y1)
            {
                if (System.Math.Abs(sy - y0) <= 0.5)
                {
                    lo = System.Math.Min(lo, System.Math.Min(x0, x1));
                    hi = System.Math.Max(hi, System.Math.Max(x0, x1));
                }
                return;
            }
            if (sy < System.Math.Min(y0, y1) || sy > System.Math.Max(y0, y1)) return;
            double x = x0 + (sy - y0) * (x1 - x0) / (y1 - y0);
            if (x < lo) lo = x;
            if (x > hi) hi = x;
        }

        static bool AngleInArc(double ang, int start, int arc)
        {
            if (arc >= 360 || arc <= -360) return true;
            if (arc < 0) { start += arc; arc = -arc; }
            double rel = (ang - start) % 360.0;
            if (rel < 0) rel += 360.0;
            return rel <= arc;
        }

        public void fillArc(int x, int y, int w, int h, int startAngle, int arcAngle)
        {
            if (w <= 0 || h <= 0 || arcAngle == 0) return;
            double rx = w / 2.0, ry = h / 2.0, ccx = x + tx + rx, ccy = y + ty + ry;
            int x0 = System.Math.Max(cx0, x + tx), x1 = System.Math.Min(cx1, x + tx + w);
            int y0 = System.Math.Max(cy0, y + ty), y1 = System.Math.Min(cy1, y + ty + h);
            for (int py = y0; py < y1; py++)
            {
                double ny = (py + 0.5 - ccy) / ry;
                for (int px = x0; px < x1; px++)
                {
                    double nx = (px + 0.5 - ccx) / rx;
                    if (nx * nx + ny * ny > 1.0) continue;
                    double ang = System.Math.Atan2(-ny, nx) * 180.0 / System.Math.PI;
                    if (AngleInArc(ang, startAngle, arcAngle)) pix[py * tw + px] = color;
                }
            }
        }

        public void drawArc(int x, int y, int w, int h, int startAngle, int arcAngle)
        {
            if (w < 0 || h < 0) return;
            double rx = w / 2.0, ry = h / 2.0, ccx = x + tx + rx, ccy = y + ty + ry;
            int steps = (int)System.Math.Max(16, (rx + ry) * 4);
            if (arcAngle < 0) { startAngle += arcAngle; arcAngle = -arcAngle; }
            if (arcAngle > 360) arcAngle = 360;
            for (int i = 0; i <= steps; i++)
            {
                double a = (startAngle + arcAngle * (double)i / steps) * System.Math.PI / 180.0;
                Plot((int)System.Math.Floor(ccx + System.Math.Cos(a) * rx), (int)System.Math.Floor(ccy - System.Math.Sin(a) * ry));
            }
        }

        public void fillRoundRect(int x, int y, int w, int h, int arcW, int arcH)
        {
            if (w <= 0 || h <= 0) return;
            arcW = System.Math.Min(System.Math.Abs(arcW), w);
            arcH = System.Math.Min(System.Math.Abs(arcH), h);
            if (arcW == 0 || arcH == 0) { fillRect(x, y, w, h); return; }
            double rx = arcW / 2.0, ry = arcH / 2.0;
            int ax = x + tx, ay = y + ty;
            for (int py = 0; py < h; py++)
            {
                double dy = 0;
                if (py + 0.5 < ry) dy = ry - (py + 0.5);
                else if (py + 0.5 > h - ry) dy = (py + 0.5) - (h - ry);
                int inset = 0;
                if (dy > 0)
                {
                    double t = 1.0 - (dy * dy) / (ry * ry);
                    inset = t <= 0 ? (int)rx : (int)System.Math.Round(rx - rx * System.Math.Sqrt(t));
                }
                FillAbs(ax + inset, ay + py, ax + w - inset, ay + py + 1, color);
            }
        }

        public void drawRoundRect(int x, int y, int w, int h, int arcW, int arcH)
        {
            if (w < 0 || h < 0) return;
            arcW = System.Math.Min(System.Math.Abs(arcW), w);
            arcH = System.Math.Min(System.Math.Abs(arcH), h);
            int rx = arcW / 2, ry = arcH / 2;
            drawLine(x + rx, y, x + w - rx, y);
            drawLine(x + rx, y + h, x + w - rx, y + h);
            drawLine(x, y + ry, x, y + h - ry);
            drawLine(x + w, y + ry, x + w, y + h - ry);
            if (arcW > 0 && arcH > 0)
            {
                drawArc(x, y, arcW, arcH, 90, 90);
                drawArc(x + w - arcW, y, arcW, arcH, 0, 90);
                drawArc(x, y + h - arcH, arcW, arcH, 180, 90);
                drawArc(x + w - arcW, y + h - arcH, arcW, arcH, 270, 90);
            }
        }

        // ------------------------------------------------------------ images

        internal static void ApplyAnchor(ref int x, ref int y, int w, int h, int anchor)
        {
            if (anchor == 0) return;
            if ((anchor & HCENTER) != 0) x -= w / 2;
            else if ((anchor & RIGHT) != 0) x -= w;
            if ((anchor & VCENTER) != 0) y -= h / 2;
            else if ((anchor & (BOTTOM | BASELINE)) != 0) y -= h;
        }

        public void drawImage(Image img, int x, int y, int anchor)
        {
            if (img == null) throw new System.NullReferenceException();
            ApplyAnchor(ref x, ref y, img.width, img.height, anchor);
            Blit(img.pixels, 0, img.width, 0, 0, img.width, img.height, 0, x + tx, y + ty, img.alphaKind);
        }

        public void drawRegion(Image src, int xSrc, int ySrc, int width, int height, int transform, int xDest, int yDest, int anchor)
        {
            if (src == null) throw new System.NullReferenceException();
            if (width <= 0 || height <= 0) return;
            bool swap = (transform & 4) != 0;
            int dw = swap ? height : width, dh = swap ? width : height;
            ApplyAnchor(ref xDest, ref yDest, dw, dh, anchor);
            Blit(src.pixels, 0, src.width, xSrc, ySrc, width, height, transform, xDest + tx, yDest + ty, src.alphaKind);
        }

        public void drawRGB(int[] rgb, int offset, int scanlength, int x, int y, int width, int height, bool processAlpha)
        {
            if (rgb == null) throw new System.NullReferenceException();
            if (width <= 0 || height <= 0) return;
            Blit(rgb, offset, scanlength, 0, 0, width, height, 0, x + tx, y + ty, processAlpha ? Image.AlphaFull : Image.AlphaNone);
        }

        public void copyArea(int xSrc, int ySrc, int width, int height, int xDest, int yDest, int anchor)
        {
            var tmp = new int[width * height];
            for (int j = 0; j < height; j++)
                for (int i = 0; i < width; i++)
                {
                    int sx = xSrc + tx + i, sy = ySrc + ty + j;
                    tmp[j * width + i] = sx >= 0 && sy >= 0 && sx < tw && sy < th ? pix[sy * tw + sx] : 0;
                }
            ApplyAnchor(ref xDest, ref yDest, width, height, anchor);
            Blit(tmp, 0, width, 0, 0, width, height, 0, xDest + tx, yDest + ty, Image.AlphaNone);
        }

        /// <summary>
        /// Copies a (transformed) w*h region of src, whose top-left is (sx,sy), to absolute surface position (dx,dy).
        /// Source pixel (u,v) is read at src[srcOff + v*scan + u].
        /// </summary>
        internal void Blit(int[] src, int srcOff, int scan, int sx, int sy, int w, int h, int transform, int dx, int dy, int alphaKind)
        {
            bool swap = (transform & 4) != 0;
            int dw = swap ? h : w, dh = swap ? w : h;

            // Inverse mapping: dest (i,j) -> source (u,v) = (u0 + ui*i + uj*j, v0 + vi*i + vj*j)
            int u0, ui, uj, v0, vi, vj;
            switch (transform)
            {
                default: u0 = 0; ui = 1; uj = 0; v0 = 0; vi = 0; vj = 1; break;            // NONE
                case 1: u0 = 0; ui = 1; uj = 0; v0 = h - 1; vi = 0; vj = -1; break;        // MIRROR_ROT180
                case 2: u0 = w - 1; ui = -1; uj = 0; v0 = 0; vi = 0; vj = 1; break;        // MIRROR
                case 3: u0 = w - 1; ui = -1; uj = 0; v0 = h - 1; vi = 0; vj = -1; break;   // ROT180
                case 4: u0 = 0; ui = 0; uj = 1; v0 = 0; vi = 1; vj = 0; break;             // MIRROR_ROT270
                case 5: u0 = 0; ui = 0; uj = 1; v0 = h - 1; vi = -1; vj = 0; break;        // ROT90
                case 6: u0 = w - 1; ui = 0; uj = -1; v0 = 0; vi = 1; vj = 0; break;        // ROT270
                case 7: u0 = w - 1; ui = 0; uj = -1; v0 = h - 1; vi = -1; vj = 0; break;   // MIRROR_ROT90
            }

            int i0 = System.Math.Max(0, cx0 - dx), j0 = System.Math.Max(0, cy0 - dy);
            int i1 = System.Math.Min(dw, cx1 - dx), j1 = System.Math.Min(dh, cy1 - dy);
            if (i0 >= i1 || j0 >= j1) return;

            int srcLen = src.Length;
            for (int j = j0; j < j1; j++)
            {
                int d = (dy + j) * tw + dx + i0;
                int u = u0 + ui * i0 + uj * j, v = v0 + vi * i0 + vj * j;
                int s = srcOff + (sy + v) * scan + sx + u;
                int step = ui + vi * scan;
                if (alphaKind == Image.AlphaNone)
                {
                    if (step == 1 && s >= 0 && s + (i1 - i0) <= srcLen)
                    {
                        for (int i = i0; i < i1; i++) pix[d++] = src[s++] | unchecked((int)0xFF000000);
                    }
                    else
                    {
                        for (int i = i0; i < i1; i++, s += step, d++)
                            if ((uint)s < (uint)srcLen) pix[d] = src[s] | unchecked((int)0xFF000000);
                    }
                }
                else
                {
                    for (int i = i0; i < i1; i++, s += step, d++)
                    {
                        if ((uint)s >= (uint)srcLen) continue;
                        int c = src[s];
                        int a = (int)((uint)c >> 24);
                        if (a == 0) continue;
                        if (a == 255) { pix[d] = c; continue; }
                        int b = pix[d];
                        int ia = 255 - a;
                        int r = (((c >> 16) & 0xFF) * a + ((b >> 16) & 0xFF) * ia + 127) / 255;
                        int g = (((c >> 8) & 0xFF) * a + ((b >> 8) & 0xFF) * ia + 127) / 255;
                        int bl = ((c & 0xFF) * a + (b & 0xFF) * ia + 127) / 255;
                        pix[d] = unchecked((int)0xFF000000) | (r << 16) | (g << 8) | bl;
                    }
                }
            }
        }

        // ------------------------------------------------------------ text

        public void drawString(string str, int x, int y, int anchor) { font.Draw(this, str, x + tx, y + ty, anchor, color); }
        public void drawSubstring(string str, int offset, int len, int x, int y, int anchor) { drawString(str.Substring(offset, len), x, y, anchor); }
        public void drawChar(char c, int x, int y, int anchor) { drawString(c.ToString(), x, y, anchor); }
        public void drawChars(char[] data, int offset, int length, int x, int y, int anchor) { drawString(new string(data, offset, length), x, y, anchor); }

        /// <summary>Glyph helper for Font: sets one absolute pixel if inside the clip.</summary>
        internal void SetPixelAbs(int ax, int ay, int c)
        {
            if (ax >= cx0 && ax < cx1 && ay >= cy0 && ay < cy1) pix[ay * tw + ax] = c;
        }
    }
}
