// Transpiled from Java (ScheduledEventNode.java) by Tools/J2meToCs. Regenerate rather than hand-edit where possible.
#pragma warning disable CS0162, CS0164, CS0168, CS0169, CS0219, CS0414, CS0649, CS1717, CS0108, CS0659, CS0661
using J2ME;

namespace REUprising.Glu
{
// $VF: renamed from: j
public class ScheduledEventNode {
   static ScheduledEventNode() { }

   // $VF: renamed from: a j
   public ScheduledEventNode previousNode;
   // $VF: renamed from: b j
   public ScheduledEventNode nextNode;
   // $VF: renamed from: c byte
   public sbyte eventType;
   // $VF: renamed from: d byte
   public sbyte eventDelay;
   // $VF: renamed from: e byte
   public sbyte eventParameter;
   // $VF: renamed from: f byte
   public sbyte eventFlags;
   // $VF: renamed from: g c
   public GameController gameController;

   public ScheduledEventNode(GameController var1) {
      this.gameController = var1;
   }
}
}
