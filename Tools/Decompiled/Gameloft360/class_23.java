// $VF: renamed from: c
public final class class_23 {
   // $VF: renamed from: a byte[]
   private byte[] field_438;
   // $VF: renamed from: a int
   int field_439;

   public class_23(byte[] var1) {
      Object var2 = null;
      short[] var10000 = new short[]{(short)var1.length};
      this.field_438 = var1;
      this.field_439 = 0;
   }

   // $VF: renamed from: a () boolean
   public final boolean method_123() {
      return this.field_438[this.field_439++] != 0;
   }

   // $VF: renamed from: a () byte
   public final byte method_124() {
      return this.field_438[this.field_439++];
   }

   // $VF: renamed from: a () short
   public final short method_125() {
      return (short)(this.field_438[this.field_439++] & 255);
   }

   // $VF: renamed from: b () short
   public final short method_126() {
      return (short)((this.field_438[this.field_439++] & 255) << 8 | this.field_438[this.field_439++] & 255);
   }

   // $VF: renamed from: a (int) java.lang.String
   public final String method_127(int var1) {
      String var2 = new String(this.field_438, this.field_439, var1);
      this.field_439 += var1;
      return var2;
   }
}
