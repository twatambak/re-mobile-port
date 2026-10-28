// $VF: renamed from: a
public abstract class class_21 extends class_19 {
   // $VF: renamed from: a java.lang.String[]
   protected String[] field_446 = null;
   // $VF: renamed from: b byte
   protected byte field_447 = 0;
   // $VF: renamed from: c byte
   protected byte field_448 = -1;
   // $VF: renamed from: d boolean
   protected boolean field_449 = false;
   // $VF: renamed from: e int
   protected int field_450 = 0;
   // $VF: renamed from: f int
   protected int field_451 = 0;
   // $VF: renamed from: g int
   int field_452;

   public class_21() {
   }

   public class_21(class_7 var1, int var2, int var3, class_25 var4) {
      super(var1, var4, 0);
      this.field_447 = 0;
      this.field_450 = var2;
      this.field_451 = var3;
   }

   // $VF: renamed from: a (byte) void
   public void method_284(byte var1) {
      this.field_447 = var1;
   }

   // $VF: renamed from: a () byte
   public byte method_285() {
      return this.field_447;
   }

   // $VF: renamed from: b () boolean
   public boolean method_286() {
      return this.field_449;
   }

   // $VF: renamed from: c () void
   public void method_287() {
      this.field_449 = false;
   }

   // $VF: renamed from: b (byte) void
   protected void method_288(byte var1) {
      this.field_452 |= var1;
   }

   // $VF: renamed from: c (byte) void
   protected void method_289(byte var1) {
      this.field_452 &= ~var1;
   }

   // $VF: renamed from: d (byte) boolean
   protected boolean method_290(byte var1) {
      return (this.field_452 & var1) != 0;
   }
}
