// Transpiled from Java (class_8.java) by Tools/J2meToCs. Regenerate rather than hand-edit where possible.
#pragma warning disable CS0162, CS0164, CS0168, CS0169, CS0219, CS0414, CS0649, CS1717, CS0108, CS0659, CS0661
using J2ME;

namespace REUprising.Gameloft
{
// $VF: renamed from: y
public class RectangleBounds {
   static RectangleBounds() { }

   // $VF: renamed from: b int
   public int left;
   // $VF: renamed from: c int
   public int top;
   // $VF: renamed from: d int
   public int height;
   // $VF: renamed from: e int
   public int width;
   // $VF: renamed from: a int
   public int boundsId;

   public RectangleBounds(int var1, int var2, int var3, int var4, int var5) {
      this.left = var1;
      this.top = var2;
      this.height = var4;
      this.width = var3;
      this.boundsId = var5;
   }

   // $VF: renamed from: a (int, int) boolean
   public bool containsPointStrictly(int var1, int var2) {
      return var1 > this.left && var1 < this.left + this.width && var2 > this.top && var2 < this.top + this.height;
   }
}
}
