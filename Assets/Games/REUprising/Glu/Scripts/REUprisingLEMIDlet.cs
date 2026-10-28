// Transpiled from Java (REUprisingLEMIDlet.java) by Tools/J2meToCs. Regenerate rather than hand-edit where possible.
#pragma warning disable CS0162, CS0164, CS0168, CS0169, CS0219, CS0414, CS0649, CS1717, CS0108, CS0659, CS0661
using J2ME;

namespace REUprising.Glu
{
public class REUprisingLEMIDlet : CapcomMIDlet {
   static REUprisingLEMIDlet() { }

   // $VF: renamed from: a () m
   public override IGameScreenController createGameScreenController() {
      return new GameController(this);
   }

   // alias for obfuscated name 'a'
   public IGameScreenController a() { return createGameScreenController(); }

   // alias for obfuscated name 'b'
   public void b() { shutdownMidlet(); }
}
}
