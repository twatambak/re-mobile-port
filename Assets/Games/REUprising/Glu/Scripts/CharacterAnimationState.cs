// Transpiled from Java (CharacterAnimationState.java) by Tools/J2meToCs. Regenerate rather than hand-edit where possible.
#pragma warning disable CS0162, CS0164, CS0168, CS0169, CS0219, CS0414, CS0649, CS1717, CS0108, CS0659, CS0661
using J2ME;

namespace REUprising.Glu
{
// $VF: renamed from: g
public class CharacterAnimationState {
   static CharacterAnimationState() { }

   // $VF: renamed from: a u
   public ActorRuntimeState characterAnimationObjectReferenceA;
   // $VF: renamed from: b byte
   public sbyte characterAnimationByteStateA;
   // $VF: renamed from: c v[]
   public AnimationSequenceData[] characterAnimationObjectReferenceArrayA;
   // $VF: renamed from: d byte
   public sbyte characterAnimationByteStateB;
   // $VF: renamed from: e byte
   public sbyte characterAnimationByteStateC;
   // $VF: renamed from: f byte[]
   public sbyte[] characterAnimationByteStateArrayA;
   // $VF: renamed from: g byte
   public sbyte characterAnimationByteStateD;
   // $VF: renamed from: h boolean
   public bool characterAnimationFlagA;
   // $VF: renamed from: i boolean
   public bool characterAnimationFlagB;
   // $VF: renamed from: j boolean
   public bool characterAnimationFlagC;
   // $VF: renamed from: k byte
   public sbyte characterAnimationByteStateE;
   // $VF: renamed from: l boolean
   public bool characterAnimationFlagD;
   // $VF: renamed from: m boolean[]
   public bool[] characterAnimationFlagArrayA;
   // $VF: renamed from: n c
   public GameController characterAnimationObjectReferenceB;

   public CharacterAnimationState(GameController var1) {
      this.characterAnimationObjectReferenceB = var1;
      this.characterAnimationObjectReferenceA = new ActorRuntimeState(this.characterAnimationObjectReferenceB);
      this.characterAnimationByteStateArrayA = new sbyte[6];
      this.characterAnimationFlagArrayA = new bool[6];
   }
}
}
