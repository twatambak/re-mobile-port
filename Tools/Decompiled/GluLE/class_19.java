import javax.microedition.lcdui.Graphics;

// $VF: renamed from: s
public abstract class class_19 {
   // $VF: renamed from: h p
   protected class_7 field_411 = null;
   // $VF: renamed from: i w
   protected class_25 field_412 = null;
   // $VF: renamed from: j int
   protected int field_413 = -1;
   // $VF: renamed from: k int
   protected int field_414 = 0;

   public class_19() {
   }

   public class_19(class_7 var1, class_25 var2, int var3) {
      this.field_411 = var1;
      this.field_412 = var2;
      this.field_413 = var3;
   }

   // $VF: renamed from: e () void
   public abstract void method_277();

   // $VF: renamed from: f () void
   public abstract void method_278();

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics) void
   public abstract void method_279(Graphics var1);

   // $VF: renamed from: b (int) void
   public abstract void method_280(int var1);

   // $VF: renamed from: c (int) void
   public void method_281(int var1) {
      this.field_413 = var1;
   }
}
