// Transpiled from Java (BitmapFontRenderer.java) by Tools/J2meToCs. Regenerate rather than hand-edit where possible.
#pragma warning disable CS0162, CS0164, CS0168, CS0169, CS0219, CS0414, CS0649, CS1717, CS0108, CS0659, CS0661
using J2ME;

namespace REUprising.Glu
{
// $VF: renamed from: p
public class BitmapFontRenderer {
   static BitmapFontRenderer() { }

   // $VF: renamed from: a javax.microedition.lcdui.Image[]
   public static Image[] fontImages;
   // $VF: renamed from: b byte[][]
   public static sbyte[][] bitmapFontData;
   // $VF: renamed from: c java.lang.String[]
   public static string[] fontCharacterSets;
   // $VF: renamed from: d byte[][]
   public static sbyte[][] glyphWidths;
   // $VF: renamed from: e short[][]
   public static short[][] glyphSourceOffsets;
   // $VF: renamed from: f byte[]
   public static sbyte[] fontHeights;
   // $VF: renamed from: g byte[]
   public static sbyte[] fontLineHeights;
   // $VF: renamed from: h byte[]
   public static sbyte[] fontBaselineOffsets;
   // $VF: renamed from: i short[]
   public static short[] glyphAdvanceWidths;
   // $VF: renamed from: j byte[]
   public static sbyte[] fontStorageFormats;
   // $VF: renamed from: k java.lang.String[]
   public static string[] fontResourceNames;

   public BitmapFontRenderer(int var1) {
      try {
         fontImages = new Image[var1];
         bitmapFontData = new sbyte[var1][];
         fontCharacterSets = new string[var1];
         glyphWidths = new sbyte[var1][];
         glyphSourceOffsets = new short[var1][];
         fontHeights = new sbyte[var1];
         fontLineHeights = new sbyte[var1];
         fontBaselineOffsets = new sbyte[var1];
         glyphAdvanceWidths = new short[var1];
         fontStorageFormats = new sbyte[var1];
      } catch (System.Exception var3) {
      }
   }

   // $VF: renamed from: a (int, java.lang.String, byte, byte, byte, short, byte) void
   public void loadFont(int var1, string var2, sbyte var3, sbyte var4, sbyte var5, short var6, sbyte var7) {
      try {
         if (var7 == 0) {
            fontImages[var1] = Image.createImage("/" + var2 + ".png");
         } else if (var7 == 1 || var7 == 2) {
            bitmapFontData[var1] = this.loadBinaryFontData("/" + var2 + ".bin");
         }

         fontHeights[var1] = var3;
         fontLineHeights[var1] = var4;
         fontBaselineOffsets[var1] = var5;
         glyphAdvanceWidths[var1] = var6;
         fontStorageFormats[var1] = var7;
         this.loadFontGlyphMetrics(var1, var2);
      } catch (System.Exception var9) {
      }
   }

   // $VF: renamed from: a (int, java.lang.String) void
   public void loadFontGlyphMetrics(int var1, string var2) {
      try {
         InputStream var3 = this.getClass().getResourceAsStream("/" + var2 + ".bmf");
         DataInputStream var4 = new DataInputStream(var3);
         fontCharacterSets[var1] = var4.readUTF();
         int var5 = fontCharacterSets[var1].length();
         glyphWidths[var1] = new sbyte[var5];
         glyphSourceOffsets[var1] = new short[var5];
         short var6 = 0;

         for (int var7 = 0; var7 < var5; var7++) {
            glyphWidths[var1][var7] = var4.readByte();
            glyphSourceOffsets[var1][var7] = var6;
            var6 = (short)(var6 + glyphWidths[var1][var7]);
         }

         try {
            var4.close();
         } catch (IOException var8) {
         }
      } catch (System.Exception var9) {
      }
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, java.lang.String, int, int, int, int, int) void
   public void drawText(Graphics var1, string var2, int var3, int var4, int var5, int var6, int var7) {
      int var8 = 0;

      try {
         if (var6 == 1 || var6 == 8) {
            var8 = this.measureTextWidth(var2, var7);
            if (var6 == 1) {
               var3 += var5 / 2 - var8 / 2;
            } else if (var6 == 8) {
               var3 -= var8;
            }
         }

         for (int var9 = 0; var9 < var2.length(); var9++) {
            char var10 = var2.charAt(var9);
            if (fontStorageFormats[var7] == 0) {
               var3 += this.drawImageGlyph(var1, var10, var3, var4, var7);
            } else if (fontStorageFormats[var7] == 1) {
               var3 += this.drawBitmapGlyph(var1, var10, var3, var4, var7);
            } else if (fontStorageFormats[var7] == 2) {
               var3 += this.drawPackedGlyph(var1, var10, var3, var4, var7);
            }
         }
      } catch (System.Exception var11) {
      }
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, java.lang.String, int, int, int, int, int, int) void
   public void drawVerticallyCenteredText(Graphics var1, string var2, int var3, int var4, int var5, int var6, int var7, int var8) {
      int var9 = 0;
      int var10 = var4 + (var6 - fontBaselineOffsets[var8]) / 2;
      if (fontBaselineOffsets[var8] % 2 > 0) {
         var10++;
      }

      try {
         if (var7 == 1 || var7 == 8) {
            var9 = this.measureTextWidth(var2, var8);
            if (var7 == 1) {
               var3 += var5 / 2 - var9 / 2;
            } else if (var7 == 8) {
               var3 -= var9;
            }
         }

         for (int var11 = 0; var11 < var2.length(); var11++) {
            char var12 = var2.charAt(var11);
            if (fontStorageFormats[var8] == 0) {
               var3 += this.drawImageGlyph(var1, var12, var3, var10, var8);
            } else if (fontStorageFormats[var8] == 1) {
               var3 += this.drawBitmapGlyph(var1, var12, var3, var10, var8);
            } else if (fontStorageFormats[var8] == 2) {
               var3 += this.drawPackedGlyph(var1, var12, var3, var10, var8);
            }
         }
      } catch (System.Exception var13) {
      }
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, java.lang.String, int, int, int, int, int, int, int, int) void
   public void drawClippedOrScrollingText(Graphics var1, string var2, int var3, int var4, int var5, int var6, int var7, int var8, int var9, int var10) {
      int var11 = this.measureTextWidth(var2, var7);
      if (var11 >= var5) {
         int var12 = var1.getClipX();
         int var13 = var1.getClipY();
         int var14 = var1.getClipWidth();
         int var15 = var1.getClipHeight();
         var1.setClip(var3, var13, var5, var15);
         if (var8 > 0) {
            int var16 = var11 + var9;

            for (int var17 = 0; var17 < 2; var17++) {
               this.drawText(var1, var2, var3 + var10 - var8 % var16 + var17 * var16, var4, var5, 4, var7);
            }
         } else {
            this.drawText(var1, var2, var3 + var10, var4, var5, 4, var7);
         }

         var1.setClip(var12, var13, var14, var15);
      } else {
         this.drawText(var1, var2, var3, var4, var5, var6, var7);
      }
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, java.lang.String, int, int, int, int, int, int, boolean) int
   public int drawWrappedText(Graphics var1, string var2, int var3, int var4, int var5, int var6, int var7, int var8, bool var9) {
      int var10 = 1;
      if (!var9 && !this.textExceedsWidth(var2, var3, var5, var7)) {
         this.drawText(var1, var2, var3, var4, var5, var6, var7);
      } else {
         string[] var11 = this.wrapText(var2, var5, var7, 128);

         for (int var12 = 0; var12 < var11.Length; var12++) {
            this.drawText(var1, var11[var12], var3, var4 + var12 * var8, var5, var6, var7);
         }

         var10 = var11.Length;
      }

      return var10;
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, char, int, int, int) int
   public int drawImageGlyph(Graphics var1, char var2, int var3, int var4, int var5) {
      if (this.isFontWhitespace(var2)) {
         return fontLineHeights[var5];
      } else {
         int var6 = fontCharacterSets[var5].indexOf(var2);
         if (var6 >= 0) {
            var1.drawRegion(
               fontImages[var5],
               glyphSourceOffsets[var5][var6] % glyphAdvanceWidths[var5],
               0 + glyphSourceOffsets[var5][var6] / glyphAdvanceWidths[var5] * fontBaselineOffsets[var5],
               glyphWidths[var5][var6],
               fontBaselineOffsets[var5],
               0,
               var3,
               var4,
               20
            );
            return glyphWidths[var5][var6] + fontHeights[var5];
         } else {
            return 0;
         }
      }
   }

   // $VF: renamed from: b (javax.microedition.lcdui.Graphics, char, int, int, int) int
   public int drawBitmapGlyph(Graphics var1, char var2, int var3, int var4, int var5) {
      if (this.isFontWhitespace(var2)) {
         return fontLineHeights[var5];
      } else {
         int var6 = fontCharacterSets[var5].indexOf(var2);
         if (var6 < 0) {
            return 0;
         } else {
            int var7 = 2 * var6;
            int var8 = bitmapFontData[var5][var7] * 128 + bitmapFontData[var5][var7 + 1];

            for (int var9 = 0; var9 < bitmapFontData[var5][var8]; var9++) {
               int var10 = var8 + 2 + 2 * var9;
               int var13 = bitmapFontData[var5][var10] & 15;
               int var14 = bitmapFontData[var5][var10 + 1] & 15;
               int var11 = (bitmapFontData[var5][var10] >> 4 & 15) + var3;
               int var12 = (bitmapFontData[var5][var10 + 1] >> 4 & 15) + var4;
               var1.fillRect(var11, var12, var13, var14);
            }

            return glyphWidths[var5][var6] + fontHeights[var5];
         }
      }
   }

   // $VF: renamed from: c (javax.microedition.lcdui.Graphics, char, int, int, int) int
   public int drawPackedGlyph(Graphics var1, char var2, int var3, int var4, int var5) {
      if (this.isFontWhitespace(var2)) {
         return fontLineHeights[var5];
      } else {
         int var6 = fontCharacterSets[var5].indexOf(var2);
         if (var6 < 0) {
            return 0;
         } else {
            int var7 = 4 * var6;
            int var8 = bitmapFontData[var5][var7] * 128 + bitmapFontData[var5][var7 + 1];

            for (int var9 = 0; var9 < bitmapFontData[var5][var8]; var9++) {
               int var10 = var8 + 3 + 4 * var9;
               sbyte var13 = bitmapFontData[var5][var10 + 2];
               sbyte var14 = bitmapFontData[var5][var10 + 3];
               int var11 = bitmapFontData[var5][var10] + var3;
               int var12 = bitmapFontData[var5][var10 + 1] + var4;
               var1.fillRect(var11, var12, var13, var14);
            }

            return glyphWidths[var5][var6] + fontHeights[var5];
         }
      }
   }

   // $VF: renamed from: a (java.lang.String, int) int
   public int measureTextWidth(string var1, int var2) {
      int var3 = 0;
      sbyte var4 = 32;

      try {
         for (int var5 = 0; var5 < var1.length(); var5++) {
            char var7 = var1.charAt(var5);
            if (this.isFontWhitespace(var7)) {
               var3 += fontLineHeights[var2];
            } else {
               var3 += glyphWidths[var2][fontCharacterSets[var2].indexOf(var7)] + fontHeights[var2];
            }
         }

         var3 -= fontHeights[var2];
      } catch (System.Exception var6) {
      }

      return var3;
   }

   // $VF: renamed from: a (java.lang.String, int, int) java.lang.String
   public string trimTextToFit(string var1, int var2, int var3) {
      try {
         int var4 = 0;

         for (int var5 = 0; var5 < var1.length(); var5++) {
            if (var1.charAt(var5) == ' ' || var1.charAt(var5) == '\n') {
               if (this.measureTextWidth(var1.substring(var4, var5), var3) < var2) {
                  var4 = var5 + 1;
               } else {
                  int var6 = var4;

                  while (this.measureTextWidth(var1.substring(var4, var6) + "- ", var3) < var2) {
                     var6++;
                  }

                  var1 = var1.substring(0, --var6) + "- " + var1.substring(var6);
                  var5 = var4;
               }
            }
         }
      } catch (System.Exception var7) {
         GameDiagnostics.reportException("fixUnsplittableWords error:", var7);
      }

      return var1;
   }

   // $VF: renamed from: a (java.lang.String, int, int, int) java.lang.String[]
   public string[] wrapText(string var1, int var2, int var3, int var4) {
      string[] var5 = null;
      string var12 = this.trimTextToFit(var1, var2, var3);

      try {
         if (var12 == null || var12.equals("")) {
            return null;
         }

         int var6 = 0;
         int var7 = 0;
         int var8 = 0;
         fontResourceNames = new string[var4];

         for (int var9 = 0; var9 < var12.length(); var9++) {
            if (var12.charAt(var9) == ' ' || var12.charAt(var9) == '\n' || var12.charAt(var9) == '~') {
               if (var12.charAt(var9) != '\n' && var12.charAt(var9) != '~') {
                  if (this.measureTextWidth(var12.substring(var7, var9), var3) >= var2) {
                     fontResourceNames[var8++] = var12.substring(var7, var6);
                     var7 = var6 + 1;
                     var6 = var9;
                  } else {
                     var6 = var9;
                  }
               } else {
                  if (this.measureTextWidth(var12.substring(var7, var9), var3) >= var2) {
                     fontResourceNames[var8++] = var12.substring(var7, var6);
                     var7 = var6 + 1;
                  }

                  fontResourceNames[var8++] = var12.substring(var7, var9);
                  var7 = var9 + 1;
                  var6 = var9;
               }
            }
         }

         if (this.measureTextWidth(var12.substring(var7, var12.length() - 1), var3) >= var2) {
            fontResourceNames[var8++] = var12.substring(var7, var6);
            var7 = var6 + 1;
         }

         fontResourceNames[var8++] = var12.substring(var7);
         var5 = new string[var8];
         JSystem.arraycopy(fontResourceNames, 0, var5, 0, var5.Length);
      } catch (System.Exception var11) {
      }

      return var5;
   }

   // $VF: renamed from: a (int) int
   public int getFontBaselineOffset(int var1) {
      return fontBaselineOffsets[var1];
   }

   // $VF: renamed from: b (java.lang.String, int, int) int
   public int countWrappedLines(string var1, int var2, int var3) {
      return this.wrapText(var1, var2, var3, 128).Length;
   }

   // $VF: renamed from: a (char) boolean
   public bool isFontWhitespace(char var1) {
      return var1 == ' ' || var1 == 160 || var1 == '~';
   }

   // $VF: renamed from: b (java.lang.String, int, int, int) boolean
   public bool textExceedsWidth(string var1, int var2, int var3, int var4) {
      return this.measureTextWidth(var1, var4) >= var3;
   }

   // $VF: renamed from: a (java.lang.String) byte[]
   public sbyte[] loadBinaryFontData(string var1) {
      sbyte[] var4 = null;
      sbyte[] var5 = new sbyte[256];

      try {
         InputStream var3 = this.getClass().getResourceAsStream(var1);
         ByteArrayOutputStream var2 = new ByteArrayOutputStream();

         int var6;
         while ((var6 = var3.read(var5)) > 0) {
            var2.write(var5, 0, var6);
         }

         var4 = var2.toByteArray();
      } catch (System.Exception var8) {
      }

      return var4;
   }

   // alias for obfuscated name 'a'
   public void a(int var1, string var2, sbyte var3, sbyte var4, sbyte var5, short var6, sbyte var7) { loadFont(var1, var2, var3, var4, var5, var6, var7); }

   // alias for obfuscated name 'a'
   public void a(int var1, string var2) { loadFontGlyphMetrics(var1, var2); }

   // alias for obfuscated name 'a'
   public void a(Graphics var1, string var2, int var3, int var4, int var5, int var6, int var7) { drawText(var1, var2, var3, var4, var5, var6, var7); }

   // alias for obfuscated name 'a'
   public void a(Graphics var1, string var2, int var3, int var4, int var5, int var6, int var7, int var8) { drawVerticallyCenteredText(var1, var2, var3, var4, var5, var6, var7, var8); }

   // alias for obfuscated name 'a'
   public void a(Graphics var1, string var2, int var3, int var4, int var5, int var6, int var7, int var8, int var9, int var10) { drawClippedOrScrollingText(var1, var2, var3, var4, var5, var6, var7, var8, var9, var10); }

   // alias for obfuscated name 'a'
   public int a(Graphics var1, string var2, int var3, int var4, int var5, int var6, int var7, int var8, bool var9) { return drawWrappedText(var1, var2, var3, var4, var5, var6, var7, var8, var9); }

   // alias for obfuscated name 'a'
   public int a(Graphics var1, char var2, int var3, int var4, int var5) { return drawImageGlyph(var1, var2, var3, var4, var5); }

   // alias for obfuscated name 'b'
   public int b(Graphics var1, char var2, int var3, int var4, int var5) { return drawBitmapGlyph(var1, var2, var3, var4, var5); }

   // alias for obfuscated name 'c'
   public int c(Graphics var1, char var2, int var3, int var4, int var5) { return drawPackedGlyph(var1, var2, var3, var4, var5); }

   // alias for obfuscated name 'a'
   public int a(string var1, int var2) { return measureTextWidth(var1, var2); }

   // alias for obfuscated name 'a'
   public string a(string var1, int var2, int var3) { return trimTextToFit(var1, var2, var3); }

   // alias for obfuscated name 'a'
   public string[] a(string var1, int var2, int var3, int var4) { return wrapText(var1, var2, var3, var4); }

   // alias for obfuscated name 'a'
   public int a(int var1) { return getFontBaselineOffset(var1); }

   // alias for obfuscated name 'b'
   public int b(string var1, int var2, int var3) { return countWrappedLines(var1, var2, var3); }

   // alias for obfuscated name 'a'
   public bool a(char var1) { return isFontWhitespace(var1); }

   // alias for obfuscated name 'b'
   public bool b(string var1, int var2, int var3, int var4) { return textExceedsWidth(var1, var2, var3, var4); }

   // alias for obfuscated name 'a'
   public sbyte[] a(string var1) { return loadBinaryFontData(var1); }
}
}
