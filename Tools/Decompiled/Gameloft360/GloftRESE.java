import javax.microedition.lcdui.Display;
import javax.microedition.midlet.MIDlet;

public final class GloftRESE extends MIDlet {
   // $VF: renamed from: a f
   public static class_27 field_860;
   // $VF: renamed from: a GloftRESE
   public static GloftRESE field_861;

   public GloftRESE() {
      field_861 = this;
   }

   public final void startApp() {
      if (field_860 == null) {
         (field_860 = new class_27(this, null)).method_323();
         (class_27.field_795 = Display.getDisplay(this)).setCurrent(field_860);
         class_27.field_795.callSerially(field_860);
      } else {
         class_27.field_795.setCurrent(field_860);
         field_860.method_311();
      }
   }

   public final void pauseApp() {
      field_860.method_310();
   }

   public final void destroyApp(boolean var1) {
      if (field_860 != null) {
         class_27.field_791 = -1;
      }
   }
}
