// Transpiled from Java (GameDiagnostics.java) by Tools/J2meToCs. Regenerate rather than hand-edit where possible.
#pragma warning disable CS0162, CS0164, CS0168, CS0169, CS0219, CS0414, CS0649, CS1717, CS0108, CS0659, CS0661
using J2ME;

namespace REUprising.Glu
{
// $VF: renamed from: l
public class GameDiagnostics {
   static GameDiagnostics() { }

   // $VF: renamed from: a (java.lang.String, java.lang.Exception) void
   public static void reportException(string var0, System.Exception var1) {
      JSystem.@out.println(var0 + " : " + var1);
      showErrorAlert(var0 + " : " + var1);
   }

   // $VF: renamed from: a (java.lang.String) void
   public static void showErrorAlert(string var0) {
      Alert var1 = new Alert("Error", var0, null, AlertType.INFO);
      var1.setTimeout(-2);
      Display.getDisplay(GameCanvas.getMidlet()).setCurrent(var1);
   }

   // $VF: renamed from: b (java.lang.String) void
   public static void logMessage(string var0) {
      JSystem.@out.println(var0);
   }

   // alias for obfuscated name 'a'
   public static void a(string var0, System.Exception var1) { reportException(var0, var1); }

   // alias for obfuscated name 'a'
   public static void a(string var0) { showErrorAlert(var0); }

   // alias for obfuscated name 'b'
   public static void b(string var0) { logMessage(var0); }
}
}
