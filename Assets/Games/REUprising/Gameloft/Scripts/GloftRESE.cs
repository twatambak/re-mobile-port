// Transpiled from Java (GloftRESE.java) by Tools/J2meToCs. Regenerate rather than hand-edit where possible.
#pragma warning disable CS0162, CS0164, CS0168, CS0169, CS0219, CS0414, CS0649, CS1717, CS0108, CS0659, CS0661
using J2ME;

namespace REUprising.Gameloft
{
public class GloftRESE : MIDlet {
   static GloftRESE() { }

   // $VF: renamed from: a f
   public static GameCanvas gameCanvasReference01;
   // $VF: renamed from: a GloftRESE
   public static GloftRESE GloftRESEReference01;

   public GloftRESE() {
      GloftRESEReference01 = this;
   }

   public override void startApp() {
      if (gameCanvasReference01 == null) {
         (gameCanvasReference01 = new GameCanvas(this, null)).initializeCanvasDisplay();
         (GameCanvas.gameDisplayReference01 = Display.getDisplay(this)).setCurrent(gameCanvasReference01);
         GameCanvas.gameDisplayReference01.callSerially(gameCanvasReference01);
      } else {
         GameCanvas.gameDisplayReference01.setCurrent(gameCanvasReference01);
         gameCanvasReference01.loadGameCanvasState();
      }
   }

   public override void pauseApp() {
      gameCanvasReference01.initializeGameCanvas();
   }

   public override void destroyApp(bool var1) {
      if (gameCanvasReference01 != null) {
         GameCanvas.gameIntegerValue126 = -1;
      }
   }
}
}
