import javax.microedition.lcdui.Alert;
import javax.microedition.lcdui.AlertType;
import javax.microedition.lcdui.Display;

// $VF: renamed from: l
public class class_9 {
   // $VF: renamed from: a (java.lang.String, java.lang.Exception) void
   public static void method_44(String var0, Exception var1) {
      System.out.println(var0 + " : " + var1);
      method_45(var0 + " : " + var1);
   }

   // $VF: renamed from: a (java.lang.String) void
   public static void method_45(String var0) {
      Alert var1 = new Alert("Error", var0, null, AlertType.INFO);
      var1.setTimeout(-2);
      Display.getDisplay(class_25.method_341()).setCurrent(var1);
   }

   // $VF: renamed from: b (java.lang.String) void
   public static void method_46(String var0) {
      System.out.println(var0);
   }
}
