import javax.microedition.lcdui.Graphics;
import javax.microedition.lcdui.Image;

// $VF: renamed from: q
public class class_6 {
   // $VF: renamed from: a short[][]
   short[][] field_44;
   // $VF: renamed from: b javax.microedition.lcdui.Image
   Image field_45;
   // $VF: renamed from: c int
   private final int field_46 = 0;
   // $VF: renamed from: d int
   private final int field_47 = 1;
   // $VF: renamed from: e int
   private final int field_48 = 2;
   // $VF: renamed from: f int
   private final int field_49 = 3;

   // $VF: renamed from: a (int) int
   public final int method_19(int var1) {
      return this.field_44[var1][0];
   }

   // $VF: renamed from: b (int) int
   public final int method_20(int var1) {
      return this.field_44[var1][1];
   }

   // $VF: renamed from: c (int) int
   public final int method_21(int var1) {
      return this.field_44[var1][2];
   }

   // $VF: renamed from: d (int) int
   public final int method_22(int var1) {
      return this.field_44[var1][3];
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Image, short[][]) void
   public void method_23(Image var1, short[][] var2) {
      this.field_45 = var1;
      this.field_44 = var2;
   }

   // $VF: renamed from: a () void
   public void method_24() {
      this.field_44 = (short[][])null;
      this.field_45 = null;
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, int, int, int) void
   public void method_25(Graphics var1, int var2, int var3, int var4) {
      int var5 = this.method_21(var4);
      int var6 = this.method_22(var4);
      this.method_26(var1, var2, var3, var4, 0, 0, var5, var6);
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, int, int, int, int, int, int, int) void
   public void method_26(Graphics var1, int var2, int var3, int var4, int var5, int var6, int var7, int var8) {
      int var9 = this.method_19(var4);
      int var10 = this.method_20(var4);
      int var11 = this.method_21(var4);
      int var12 = this.method_22(var4);
      if (var5 + var7 > var11) {
         var7 = var11 - var5;
      }

      if (var6 + var8 > var12) {
         var8 = var12 - var6;
      }

      var1.drawRegion(this.field_45, var9 + var5, var10 + var6, var7, var8, 0, var2, var3, 20);
   }
}
