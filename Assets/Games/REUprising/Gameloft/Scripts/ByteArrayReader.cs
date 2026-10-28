// Transpiled from Java (class_23.java) by Tools/J2meToCs. Regenerate rather than hand-edit where possible.
#pragma warning disable CS0162, CS0164, CS0168, CS0169, CS0219, CS0414, CS0649, CS1717, CS0108, CS0659, CS0661
using J2ME;

namespace REUprising.Gameloft
{
// $VF: renamed from: c
public class ByteArrayReader {
   static ByteArrayReader() { }

   // $VF: renamed from: a byte[]
   public sbyte[] data;
   // $VF: renamed from: a int
   public int position;

   public ByteArrayReader(sbyte[] var1) {
      object var2 = null;
      short[] var10000 = new short[]{(short)var1.Length};
      this.data = var1;
      this.position = 0;
   }

   // $VF: renamed from: a () boolean
   public bool readBoolean() {
      return this.data[this.position++] != 0;
   }

   // $VF: renamed from: a () byte
   public sbyte readSignedByte() {
      return this.data[this.position++];
   }

   // $VF: renamed from: a () short
   public short readUnsignedByte() {
      return (short)(this.data[this.position++] & 255);
   }

   // $VF: renamed from: b () short
   public short readUnsignedShortBigEndian() {
      return (short)((this.data[this.position++] & 255) << 8 | this.data[this.position++] & 255);
   }

   // $VF: renamed from: a (int) java.lang.String
   public string readString(int var1) {
      string var2 = JString.New(this.data, this.position, var1);
      this.position += var1;
      return var2;
   }
}
}
