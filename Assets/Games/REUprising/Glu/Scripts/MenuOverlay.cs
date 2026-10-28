// Transpiled from Java (MenuOverlay.java) by Tools/J2meToCs. Regenerate rather than hand-edit where possible.
#pragma warning disable CS0162, CS0164, CS0168, CS0169, CS0219, CS0414, CS0649, CS1717, CS0108, CS0659, CS0661
using J2ME;

namespace REUprising.Glu
{
// $VF: renamed from: a
public abstract class MenuOverlay : GameOverlay {
   static MenuOverlay() { }

   // $VF: renamed from: a java.lang.String[]
   public string[] menuItems = null;
   // $VF: renamed from: b byte
   public sbyte selectedItemIndex = 0;
   // $VF: renamed from: c byte
   public sbyte menuItemCount = -1;
   // $VF: renamed from: d boolean
   public bool isMenuVisible = false;
   // $VF: renamed from: e int
   public int menuCenterX = 0;
   // $VF: renamed from: f int
   public int menuCenterY = 0;
   // $VF: renamed from: g int
   public int menuStateFlags;

   public MenuOverlay() {
   }

   public MenuOverlay(BitmapFontRenderer var1, int var2, int var3, GameCanvas var4) : base(var1, var4, 0) {
      
      this.selectedItemIndex = 0;
      this.menuCenterX = var2;
      this.menuCenterY = var3;
   }

   // $VF: renamed from: a (byte) void
   public void setSelectedMenuItem(sbyte var1) {
      this.selectedItemIndex = var1;
   }

   // $VF: renamed from: a () byte
   public sbyte getSelectedMenuItem() {
      return this.selectedItemIndex;
   }

   // $VF: renamed from: b () boolean
   public bool isMenuCurrentlyVisible() {
      return this.isMenuVisible;
   }

   // $VF: renamed from: c () void
   public void hideMenu() {
      this.isMenuVisible = false;
   }

   // $VF: renamed from: b (byte) void
   public void enableMenuStateFlags(sbyte var1) {
      this.menuStateFlags |= var1;
   }

   // $VF: renamed from: c (byte) void
   public void disableMenuStateFlags(sbyte var1) {
      this.menuStateFlags &= ~var1;
   }

   // $VF: renamed from: d (byte) boolean
   public bool hasMenuStateFlag(sbyte var1) {
      return (this.menuStateFlags & var1) != 0;
   }

   // alias for obfuscated name 'a'
   public void a(sbyte var1) { setSelectedMenuItem(var1); }

   // alias for obfuscated name 'a'
   public sbyte a() { return getSelectedMenuItem(); }

   // alias for obfuscated name 'b'
   public bool b() { return isMenuCurrentlyVisible(); }

   // alias for obfuscated name 'c'
   public void c() { hideMenu(); }

   // alias for obfuscated name 'b'
   public void b(sbyte var1) { enableMenuStateFlags(var1); }

   // alias for obfuscated name 'c'
   public void c(sbyte var1) { disableMenuStateFlags(var1); }

   // alias for obfuscated name 'd'
   public bool d(sbyte var1) { return hasMenuStateFlag(var1); }

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
