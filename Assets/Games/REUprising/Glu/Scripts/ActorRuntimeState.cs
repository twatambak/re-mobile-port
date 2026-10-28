// Transpiled from Java (ActorRuntimeState.java) by Tools/J2meToCs. Regenerate rather than hand-edit where possible.
#pragma warning disable CS0162, CS0164, CS0168, CS0169, CS0219, CS0414, CS0649, CS1717, CS0108, CS0659, CS0661
using J2ME;

namespace REUprising.Glu
{
// $VF: renamed from: u
public class ActorRuntimeState {
   static ActorRuntimeState() { }

   // $VF: renamed from: a boolean
   public bool isActive;
   // $VF: renamed from: b byte
   public sbyte tileX;
   // $VF: renamed from: c byte
   public sbyte tileY;
   // $VF: renamed from: d byte
   public sbyte currentShadowDepth;
   // $VF: renamed from: e byte
   public sbyte previousShadowDepth;
   // $VF: renamed from: f byte
   public sbyte animationFrameIndex;
   // $VF: renamed from: g byte
   public sbyte previousAnimationFrameIndex;
   // $VF: renamed from: h int
   public int movementProgressFixedPoint;
   // $VF: renamed from: i byte
   public sbyte movementDirection;
   // $VF: renamed from: j byte
   public sbyte animationSetIndex;
   // $VF: renamed from: k byte
   public sbyte animationOverrideFrame;
   // $VF: renamed from: l byte
   public sbyte actionCounter;
   // $VF: renamed from: m byte
   public sbyte actionCounterLimit;
   // $VF: renamed from: n byte
   public sbyte targetTileX;
   // $VF: renamed from: o byte
   public sbyte targetTileY;
   // $VF: renamed from: p boolean
   public bool actorRuntimeFlagB;
   // $VF: renamed from: q boolean
   public bool actorRuntimeFlagC;
   // $VF: renamed from: r boolean
   public bool actorRuntimeFlagD;
   // $VF: renamed from: s long
   public long elapsedTimerA;
   // $VF: renamed from: t long
   public long elapsedTimerB;
   // $VF: renamed from: u boolean
   public bool actorRuntimeFlagE;
   // $VF: renamed from: v long
   public long optionalTimer;
   // $VF: renamed from: w boolean
   public bool actorRuntimeFlagF;
   // $VF: renamed from: x byte
   public sbyte actorRuntimeByteStateN;
   // $VF: renamed from: y c
   public GameController gameController;

   public ActorRuntimeState(GameController var1) {
      this.gameController = var1;
   }
}
}
