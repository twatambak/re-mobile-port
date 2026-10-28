// Transpiled from Java (EntityAnimationState.java) by Tools/J2meToCs. Regenerate rather than hand-edit where possible.
#pragma warning disable CS0162, CS0164, CS0168, CS0169, CS0219, CS0414, CS0649, CS1717, CS0108, CS0659, CS0661
using J2ME;

namespace REUprising.Glu
{
// $VF: renamed from: d
public class EntityAnimationState {
   static EntityAnimationState() { }

   // $VF: renamed from: a boolean
   public bool isAnimationActive;
   // $VF: renamed from: b f
   public WorldObjectState objectState;
   // $VF: renamed from: c long
   public long animationStartTime;
   // $VF: renamed from: d byte
   public sbyte animationType;
   // $VF: renamed from: e short
   public short positionX;
   // $VF: renamed from: f short
   public short positionY;
   // $VF: renamed from: g short
   public short destinationX;
   // $VF: renamed from: h short
   public short destinationY;
   // $VF: renamed from: i short
   public short animationFrame;
   // $VF: renamed from: j byte
   public sbyte animationFlags;
   // $VF: renamed from: k int
   public int horizontalVelocity;
   // $VF: renamed from: l int
   public int verticalVelocity;
   // $VF: renamed from: m c
   public GameController gameController;

   public EntityAnimationState(GameController var1) {
      this.gameController = var1;
      this.objectState = new WorldObjectState(this.gameController);
   }
}
}
