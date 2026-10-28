// Transpiled from Java (IGameScreenController.java) by Tools/J2meToCs. Regenerate rather than hand-edit where possible.
#pragma warning disable CS0162, CS0164, CS0168, CS0169, CS0219, CS0414, CS0649, CS1717, CS0108, CS0659, CS0661
using J2ME;

namespace REUprising.Glu
{
// $VF: renamed from: m
public interface IGameScreenController {
   // $VF: renamed from: y () void
   void updateScreen();

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics) void
   void renderScreen(Graphics var1);

   // $VF: renamed from: a (w) void
   void attachCanvas(GameCanvas var1);

   // $VF: renamed from: c (int) void
   void onKeyPressed(int var1);

   // $VF: renamed from: d (int) void
   void onKeyRepeated(int var1);

   // $VF: renamed from: e (int) void
   void onKeyReleased(int var1);

   // $VF: renamed from: a (int, int) void
   void onPointerPressed(int var1, int var2);

   // $VF: renamed from: b (int, int) void
   void onPointerReleased(int var1, int var2);

   // $VF: renamed from: c () void
   void onCanvasHidden();

   // $VF: renamed from: d () void
   void onCanvasShown();

   // $VF: renamed from: c (int, int) void
   void onCanvasSizeChanged(int var1, int var2);
}
}
