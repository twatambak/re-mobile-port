// Transpiled from Java (AbstractMenuList.java) by Tools/J2meToCs. Regenerate rather than hand-edit where possible.
#pragma warning disable CS0162, CS0164, CS0168, CS0169, CS0219, CS0414, CS0649, CS1717, CS0108, CS0659, CS0661
using J2ME;

namespace REUprising.Glu
{
// $VF: renamed from: k
public abstract class AbstractMenuList : MenuOverlay {
   static AbstractMenuList() { }

   public AbstractMenuList() {
   }

   public AbstractMenuList(BitmapFontRenderer var1, int var2, int var3, GameCanvas var4) : base(var1, var2, var3, var4) {
      
   }

   // $VF: renamed from: a (java.lang.String[], int, int, int, int, int, int, int, byte, boolean, boolean) void
   public abstract void configureMenuItems(string[] var1, int var2, int var3, int var4, int var5, int var6, int var7, int var8, sbyte var9, bool var10, bool var11);

   // $VF: renamed from: a (java.lang.String, int) void
   public abstract void setMenuItemText(string var1, int var2);

   // $VF: renamed from: a (int) void
   public abstract void setMenuVerticalPosition(int var1);

   // $VF: renamed from: d () int
   public abstract int getMenuContentHeight();

   // alias for obfuscated name 'a'
   public void a(string[] var1, int var2, int var3, int var4, int var5, int var6, int var7, int var8, sbyte var9, bool var10, bool var11) { configureMenuItems(var1, var2, var3, var4, var5, var6, var7, var8, var9, var10, var11); }

   // alias for obfuscated name 'a'
   public void a(string var1, int var2) { setMenuItemText(var1, var2); }

   // alias for obfuscated name 'a'
   public void a(int var1) { setMenuVerticalPosition(var1); }

   // alias for obfuscated name 'd'
   public int d() { return getMenuContentHeight(); }

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
