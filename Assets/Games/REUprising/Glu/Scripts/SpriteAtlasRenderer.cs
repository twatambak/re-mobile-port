// Transpiled from Java (SpriteAtlasRenderer.java) by Tools/J2meToCs. Regenerate rather than hand-edit where possible.
#pragma warning disable CS0162, CS0164, CS0168, CS0169, CS0219, CS0414, CS0649, CS1717, CS0108, CS0659, CS0661
using J2ME;

namespace REUprising.Glu
{
// $VF: renamed from: q
public class SpriteAtlasRenderer {
   static SpriteAtlasRenderer() { }

   // $VF: renamed from: a short[][]
   public short[][] regionRectangles;
   // $VF: renamed from: b javax.microedition.lcdui.Image
   public Image spriteSheetImage;
   // $VF: renamed from: c int
   public int sourceXIndex = 0;
   // $VF: renamed from: d int
   public int sourceYIndex = 1;
   // $VF: renamed from: e int
   public int sourceWidthIndex = 2;
   // $VF: renamed from: f int
   public int sourceHeightIndex = 3;

   // $VF: renamed from: a (int) int
   public int getRegionX(int var1) {
      return this.regionRectangles[var1][0];
   }

   // $VF: renamed from: b (int) int
   public int getRegionY(int var1) {
      return this.regionRectangles[var1][1];
   }

   // $VF: renamed from: c (int) int
   public int getRegionWidth(int var1) {
      return this.regionRectangles[var1][2];
   }

   // $VF: renamed from: d (int) int
   public int getRegionHeight(int var1) {
      return this.regionRectangles[var1][3];
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Image, short[][]) void
   public void setSpriteAtlas(Image var1, short[][] var2) {
      this.spriteSheetImage = var1;
      this.regionRectangles = var2;
   }

   // $VF: renamed from: a () void
   public void clearSpriteAtlas() {
      this.regionRectangles = (short[][])null;
      this.spriteSheetImage = null;
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, int, int, int) void
   public void drawSpriteRegion(Graphics var1, int var2, int var3, int var4) {
      int var5 = this.getRegionWidth(var4);
      int var6 = this.getRegionHeight(var4);
      this.drawTransformedSpriteRegion(var1, var2, var3, var4, 0, 0, var5, var6);
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, int, int, int, int, int, int, int) void
   public void drawTransformedSpriteRegion(Graphics var1, int var2, int var3, int var4, int var5, int var6, int var7, int var8) {
      int var9 = this.getRegionX(var4);
      int var10 = this.getRegionY(var4);
      int var11 = this.getRegionWidth(var4);
      int var12 = this.getRegionHeight(var4);
      if (var5 + var7 > var11) {
         var7 = var11 - var5;
      }

      if (var6 + var8 > var12) {
         var8 = var12 - var6;
      }

      var1.drawRegion(this.spriteSheetImage, var9 + var5, var10 + var6, var7, var8, 0, var2, var3, 20);
   }

   // alias for obfuscated name 'a'
   public int a(int var1) { return getRegionX(var1); }

   // alias for obfuscated name 'b'
   public int b(int var1) { return getRegionY(var1); }

   // alias for obfuscated name 'c'
   public int c(int var1) { return getRegionWidth(var1); }

   // alias for obfuscated name 'd'
   public int d(int var1) { return getRegionHeight(var1); }

   // alias for obfuscated name 'a'
   public void a(Image var1, short[][] var2) { setSpriteAtlas(var1, var2); }

   // alias for obfuscated name 'a'
   public void a() { clearSpriteAtlas(); }

   // alias for obfuscated name 'a'
   public void a(Graphics var1, int var2, int var3, int var4) { drawSpriteRegion(var1, var2, var3, var4); }

   // alias for obfuscated name 'a'
   public void a(Graphics var1, int var2, int var3, int var4, int var5, int var6, int var7, int var8) { drawTransformedSpriteRegion(var1, var2, var3, var4, var5, var6, var7, var8); }
}
}
