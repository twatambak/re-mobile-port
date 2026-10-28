// $VF: renamed from: y
final class class_8 {
   // $VF: renamed from: b int
   private int field_70;
   // $VF: renamed from: c int
   private int field_71;
   // $VF: renamed from: d int
   private int field_72;
   // $VF: renamed from: e int
   private int field_73;
   // $VF: renamed from: a int
   public int field_74;

   class_8(int var1, int var2, int var3, int var4, int var5) {
      this.field_70 = var1;
      this.field_71 = var2;
      this.field_72 = var4;
      this.field_73 = var3;
      this.field_74 = var5;
   }

   // $VF: renamed from: a (int, int) boolean
   public final boolean method_0(int var1, int var2) {
      return var1 > this.field_70 && var1 < this.field_70 + this.field_73 && var2 > this.field_71 && var2 < this.field_71 + this.field_72;
   }
}
