package com.capcomeuro.midp;

import javax.microedition.lcdui.Display;
import javax.microedition.midlet.MIDlet;
import javax.microedition.midlet.MIDletStateChangeException;

public abstract class CapcomMIDlet extends MIDlet {
   // $VF: renamed from: g w
   private class_25 field_518;
   // $VF: renamed from: h boolean
   private boolean field_519;
   // $VF: renamed from: a int
   public static int field_520;
   // $VF: renamed from: b int
   public static int field_521;
   // $VF: renamed from: c java.lang.String
   public static String field_522;
   // $VF: renamed from: d java.lang.String
   public static String field_523;
   // $VF: renamed from: e boolean
   public static boolean field_524 = false;
   // $VF: renamed from: f java.lang.String
   public static String field_525 = "";

   // $VF: renamed from: a () m
   protected abstract class_0 method_313();

   public CapcomMIDlet() {
      field_520 = Integer.parseInt(this.getAppProperty("Glu-Canvas-Height"));
      field_521 = Integer.parseInt(this.getAppProperty("Glu-Canvas-Width"));

      try {
         field_522 = this.getAppProperty("Glu-GMG-Enable");
         if (field_522.equals("true")) {
            field_523 = this.getAppProperty("Glu-GMG-URL");
         }
      } catch (Exception var2) {
      }

      this.field_518 = new class_25(this);
      this.field_518.method_315(this.method_313(), 30);
   }

   protected void startApp() {
      try {
         field_524 = this.getAppProperty("Glu-Cheats-Enable").toLowerCase().equals("true");
      } catch (Exception var3) {
      }

      try {
         field_525 = "RESEVIL5_20091124-1000_J";
      } catch (Exception var2) {
         field_525 = "BUILD NOT TAGGED";
      }

      if (!this.field_519) {
         this.field_519 = true;
         Display.getDisplay(this).setCurrent(this.field_518);
         Thread var1 = new Thread(this.field_518);
         var1.start();
      }
   }

   protected void pauseApp() {
      this.field_518.hideNotify();
   }

   protected void destroyApp(boolean var1) {
   }

   // $VF: renamed from: b () void
   public void method_314() {
      try {
         this.field_518 = null;
         this.destroyApp(true);
         this.notifyDestroyed();
      } catch (MIDletStateChangeException var2) {
      }
   }
}
