// Transpiled from Java (class_13.java) by Tools/J2meToCs. Regenerate rather than hand-edit where possible.
#pragma warning disable CS0162, CS0164, CS0168, CS0169, CS0219, CS0414, CS0649, CS1717, CS0108, CS0659, CS0661
using J2ME;

namespace REUprising.Gameloft
{
// $VF: renamed from: s
public class EntitySnapshot {
   static EntitySnapshot() { }

   // $VF: renamed from: a boolean
   public bool booleanFlag01;
   // $VF: renamed from: a byte
   public sbyte byteValue01;
   // $VF: renamed from: a int
   public int integerValue01;
   // $VF: renamed from: b byte
   public sbyte byteValue02;
   // $VF: renamed from: a short
   public short shortValue01;
   // $VF: renamed from: b short
   public short shortValue02;
   // $VF: renamed from: a b[]
   public TileCoordinate[] tileCoordinateReferenceArray01;

   public EntitySnapshot(GameCanvas var1) {
   }

   public EntitySnapshot(GameCanvas var1, EntitySnapshot var2) {
      this.booleanFlag01 = var2.booleanFlag01;
      this.byteValue01 = var2.byteValue01;
      this.integerValue01 = var2.integerValue01;
      this.byteValue02 = var2.byteValue02;
      this.shortValue01 = var2.shortValue01;
      this.shortValue02 = var2.shortValue02;
   }
}
}
