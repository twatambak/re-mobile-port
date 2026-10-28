// Transpiled from Java (GameOverlay.java) by Tools/J2meToCs. Regenerate rather than hand-edit where possible.
#pragma warning disable CS0162, CS0164, CS0168, CS0169, CS0219, CS0414, CS0649, CS1717, CS0108, CS0659, CS0661
using J2ME;

namespace REUprising.Glu
{
// $VF: renamed from: s
public abstract class GameOverlay {
   static GameOverlay() { }

   // $VF: renamed from: h p
   public BitmapFontRenderer fontRenderer = null;
   // $VF: renamed from: i w
   public GameCanvas gameCanvas = null;
   // $VF: renamed from: j int
   public int fontIndex = -1;
   // $VF: renamed from: k int
   public int animationTick = 0;

   public GameOverlay() {
   }

   public GameOverlay(BitmapFontRenderer var1, GameCanvas var2, int var3) {
      this.fontRenderer = var1;
      this.gameCanvas = var2;
      this.fontIndex = var3;
   }

   // $VF: renamed from: e () void
   public abstract void updateOverlayAnimation();

   // $VF: renamed from: f () void
   public abstract void loadOverlayResources();

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics) void
   public abstract void drawOverlay(Graphics var1);

   // $VF: renamed from: b (int) void
   public abstract void handleOverlayInput(int var1);

   // $VF: renamed from: c (int) void
   public void setOverlayFont(int var1) {
      this.fontIndex = var1;
   }

   // alias for obfuscated name 'e'
   public void e() { updateOverlayAnimation(); }

   // alias for obfuscated name 'f'
   public void f() { loadOverlayResources(); }

   // alias for obfuscated name 'a'
   public void a(Graphics var1) { drawOverlay(var1); }

   // alias for obfuscated name 'b'
   public void b(int var1) { handleOverlayInput(var1); }

   // alias for obfuscated name 'c'
   public void c(int var1) { setOverlayFont(var1); }
}
}
