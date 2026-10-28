import com.capcomeuro.midp.CapcomMIDlet;
import java.io.ByteArrayInputStream;
import java.io.ByteArrayOutputStream;
import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.IOException;
import javax.microedition.lcdui.Canvas;
import javax.microedition.lcdui.Display;
import javax.microedition.lcdui.Graphics;
import javax.microedition.lcdui.Image;
import javax.microedition.rms.RecordStore;

// $VF: renamed from: w
public class class_25 extends Canvas implements Runnable {
   // $VF: renamed from: c int
   private int field_526;
   // $VF: renamed from: d com.capcomeuro.midp.CapcomMIDlet
   private static CapcomMIDlet field_527;
   // $VF: renamed from: e int
   private int field_528;
   // $VF: renamed from: a m
   public static class_0 field_529;
   // $VF: renamed from: f byte[][][]
   private static byte[][][] field_530;
   // $VF: renamed from: g long[]
   private static long[] field_531 = new long[256];
   // $VF: renamed from: h boolean
   private static boolean field_532 = false;
   // $VF: renamed from: b boolean
   public static boolean field_533 = false;

   public class_25(CapcomMIDlet var1) {
      field_527 = var1;
      this.setFullScreenMode(true);
   }

   // $VF: renamed from: a (m, int) void
   public void method_315(class_0 var1, int var2) {
      field_529 = var1;
      field_529.method_2(this);
      this.field_526 = 1000 / var2;
   }

   // $VF: renamed from: run () void
   public void run() {
      long var1 = 0L;
      long var3 = 0L;

      try {
         var1 = System.currentTimeMillis();
         field_529.method_0();
         var3 = System.currentTimeMillis();
         long var5 = (long)this.field_526 - (var3 - var1);

         try {
            if (var5 > 3L) {
               Thread.sleep(var5);
            } else {
               Thread.sleep(3L);
            }
         } catch (InterruptedException var8) {
         }
      } catch (Exception var9) {
      }

      Display.getDisplay(field_527).callSerially(this);
   }

   protected void paint(Graphics var1) {
      field_529.method_1(var1);
   }

   // $VF: renamed from: a () void
   public void method_316() {
      this.repaint();
      this.serviceRepaints();
   }

   protected void keyPressed(int var1) {
      field_529.method_3(var1);
   }

   protected void keyRepeated(int var1) {
      field_529.method_4(var1);
   }

   protected void keyReleased(int var1) {
      field_529.method_5(var1);
   }

   protected void pointerPressed(int var1, int var2) {
      field_529.method_6(var1, var2);
   }

   protected void pointerReleased(int var1, int var2) {
      field_529.method_7(var1, var2);
   }

   public void hideNotify() {
      field_533 = true;
      field_529.method_8();
   }

   protected void showNotify() {
      field_529.method_9();
   }

   protected void sizeChanged(int var1, int var2) {
      field_529.method_10(var1, var2);
   }

   // $VF: renamed from: a (int) void
   public void method_317(int var1) {
      this.field_528 = var1;
   }

   // $VF: renamed from: a (java.lang.String) javax.microedition.lcdui.Image
   public static Image method_318(String var0) {
      try {
         return Image.createImage(var0);
      } catch (Exception var2) {
         return null;
      }
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, javax.microedition.lcdui.Image, int, int, int, int, int, int, int, int) void
   public static void method_319(Graphics var0, Image var1, int var2, int var3, int var4, int var5, int var6, int var7, int var8, int var9) {
      var0.drawRegion(var1, var2, var3, var4, var5, var6, var7, var8, var9);
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, javax.microedition.lcdui.Image, int, int, int, int) void
   public static void method_320(Graphics var0, Image var1, int var2, int var3, int var4, int var5) {
      method_319(var0, var1, 0, 0, var1.getWidth(), var1.getHeight(), var4, var2, var3, var5);
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, int, int, int, int, int) void
   public static void method_321(Graphics var0, int var1, int var2, int var3, int var4, int var5) {
      try {
         var0.setColor(var5);
         byte var6 = 1;
         int var7 = 3;
         if (var3 == 0) {
            for (int var8 = 0; var8 < var4; var8++) {
               var0.fillRect(var1 + var7, var2 + var8, var6, 1);
               var6 += 2;
               var7--;
            }
         } else if (var3 == 1) {
            for (int var10 = var4 - 1; var10 >= 0; var10--) {
               var0.fillRect(var1 + var7, var2 + var10, var6, 1);
               var6 += 2;
               var7--;
            }
         } else if (var3 == 2) {
            for (int var11 = 0; var11 < var4; var11++) {
               var0.fillRect(var1 + var11, var2 + var7 - 3, 1, var6);
               var6 += 2;
               var7--;
            }
         } else if (var3 == 3) {
            for (int var12 = var4; var12 > 0; var12--) {
               var0.fillRect(var1 + var12, var2 + var7 - 3, 1, var6);
               var6 += 2;
               var7--;
            }
         }
      } catch (Exception var9) {
      }
   }

   // $VF: renamed from: b (java.lang.String) boolean
   public static boolean method_322(String var0) {
      try {
         field_527.platformRequest(var0);
         return true;
      } catch (Exception var2) {
         return false;
      }
   }

   // $VF: renamed from: b () boolean
   public static boolean method_323() {
      Object var0 = null;
      var0 = field_527.getAppProperty("CAPCOM-GMG-Display");
      return var0 == null ? false : var0.equals("true");
   }

   // $VF: renamed from: b (int) void
   public static void method_324(int var0) {
      field_530 = new byte[var0][][];
   }

   // $VF: renamed from: a (int, int) void
   public static void method_325(int var0, int var1) {
      field_530[var0] = new byte[var1][];
   }

   // $VF: renamed from: c () void
   public static void method_326() {
      field_530 = (byte[][][])null;
   }

   // $VF: renamed from: a (int, int, boolean) void
   public static void method_327(int var0, int var1, boolean var2) {
      field_530[var0][var1] = new byte[1];
      field_530[var0][var1][0] = (byte)(var2 ? 1 : 0);
   }

   // $VF: renamed from: a (int, int, byte) void
   public static void method_328(int var0, int var1, byte var2) {
      field_530[var0][var1] = new byte[1];
      field_530[var0][var1][0] = var2;
   }

   // $VF: renamed from: a (int, int, int) void
   public static void method_329(int var0, int var1, int var2) {
      field_530[var0][var1] = new byte[4];
      field_530[var0][var1] = method_340(var2);
   }

   // $VF: renamed from: b (int, int) boolean
   public static boolean method_330(int var0, int var1) {
      return field_530[var0][var1][0] == 1;
   }

   // $VF: renamed from: c (int, int) byte
   public static byte method_331(int var0, int var1) {
      return field_530[var0][var1][0];
   }

   // $VF: renamed from: d (int, int) int
   public static int method_332(int var0, int var1) {
      return method_339(field_530[var0][var1]);
   }

   // $VF: renamed from: a (int, java.lang.String) boolean
   public static boolean method_333(int var0, String var1) {
      if (!method_335(var1)) {
         return false;
      } else {
         RecordStore var2 = null;
         DataInputStream var3 = null;

         try {
            var2 = RecordStore.openRecordStore(var1, true);
            if (var2.getNumRecords() == 0) {
               return false;
            }

            byte[] var4 = var2.getRecord(1);
            var3 = new DataInputStream(new ByteArrayInputStream(var4));

            for (int var19 = 0; var19 < field_530[var0].length; var19++) {
               int var6 = var3.readInt();
               if (var6 != 0) {
                  field_530[var0][var19] = new byte[var6];
                  var3.readFully(field_530[var0][var19]);
               }
            }
         } catch (Exception var16) {
            return false;
         } finally {
            try {
               if (var3 != null) {
                  var3.close();
               }

               if (var2 != null) {
                  var2.closeRecordStore();
               }
            } catch (Exception var15) {
            }
         }

         return true;
      }
   }

   // $VF: renamed from: b (int, java.lang.String) void
   public static void method_334(int var0, String var1) {
      RecordStore var2 = null;
      DataOutputStream var4 = null;

      try {
         if (method_335(var1)) {
            RecordStore.deleteRecordStore(var1);
         }
      } catch (Exception var16) {
      }

      try {
         var2 = RecordStore.openRecordStore(var1, true);
         ByteArrayOutputStream var3 = new ByteArrayOutputStream();
         var4 = new DataOutputStream(var3);

         for (int var6 = 0; var6 < field_530[var0].length; var6++) {
            if (field_530[var0][var6] == null) {
               var4.writeInt(0);
            } else {
               var4.writeInt(field_530[var0][var6].length);
               var4.write(field_530[var0][var6]);
            }
         }

         byte[] var5 = var3.toByteArray();
         var2.addRecord(var5, 0, var5.length);
      } catch (Exception var17) {
      } finally {
         try {
            if (var4 != null) {
               var4.close();
            }

            if (var2 != null) {
               var2.closeRecordStore();
            }
         } catch (Exception var15) {
         }
      }
   }

   // $VF: renamed from: c (java.lang.String) boolean
   public static boolean method_335(String var0) {
      String[] var1 = RecordStore.listRecordStores();
      if (var1 == null) {
         return false;
      } else {
         for (int var2 = 0; var2 < var1.length; var2++) {
            if (var1[var2].equals(var0)) {
               return true;
            }
         }

         return false;
      }
   }

   // $VF: renamed from: a (java.lang.String[], java.lang.String) void
   public final void method_336(String[] var1, String var2) {
      DataInputStream var3 = new DataInputStream(this.getClass().getResourceAsStream("/" + var2));

      try {
         var3.readInt();

         for (int var4 = 0; var4 < var1.length; var4++) {
            var1[var4] = var3.readUTF();
         }
      } catch (IOException var6) {
         var6.printStackTrace();
      }

      try {
         var3.close();
      } catch (IOException var5) {
         var5.printStackTrace();
      }
   }

   // $VF: renamed from: a (java.lang.String[], java.lang.String, int, int, int, boolean, int) java.lang.String
   public String method_337(String[] var1, String var2, int var3, int var4, int var5, boolean var6, int var7) {
      this.method_336(var1, var2);
      return null;
   }

   // $VF: renamed from: d () java.lang.String[]
   public String[] method_338() {
      String[] var1 = new String[3];

      try {
         var1[0] = "ENGLISH";
         var1[1] = new String("ESPAÃ\u0091OL".getBytes("ISO-8859-1"), "UTF-8");
         var1[2] = new String("PORTUGUÃ\u008aS".getBytes("ISO-8859-1"), "UTF-8");
      } catch (Exception var3) {
      }

      return var1;
   }

   // $VF: renamed from: a (byte[]) int
   public static final int method_339(byte[] var0) {
      int var1 = 0;

      for (int var2 = 0; var2 < 4; var2++) {
         int var3 = (3 - var2) * 8;
         var1 += (var0[var2] & 255) << var3;
      }

      return var1;
   }

   // $VF: renamed from: c (int) byte[]
   public static byte[] method_340(int var0) {
      byte[] var1 = new byte[4];

      for (int var2 = 0; var2 < 4; var2++) {
         int var3 = (var1.length - 1 - var2) * 8;
         var1[var2] = (byte)(var0 >>> var3 & 0xFF);
      }

      return var1;
   }

   // $VF: renamed from: e () com.capcomeuro.midp.CapcomMIDlet
   public static CapcomMIDlet method_341() {
      return field_527;
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, javax.microedition.lcdui.Image, int, int, int) void
   public void method_342(Graphics var1, Image var2, int var3, int var4, int var5) {
      var1.drawImage(var2, var3, var4, var5);
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, int, int, int, int) void
   public void method_343(Graphics var1, int var2, int var3, int var4, int var5) {
      var1.drawRect(var2, var3, var4, var5);
   }

   // $VF: renamed from: b (javax.microedition.lcdui.Graphics, int, int, int, int) void
   public void method_344(Graphics var1, int var2, int var3, int var4, int var5) {
      var1.fillRect(var2, var3, var4, var5);
   }

   // $VF: renamed from: c (javax.microedition.lcdui.Graphics, int, int, int, int) void
   public void method_345(Graphics var1, int var2, int var3, int var4, int var5) {
      var1.setClip(var2, var3, var4, var5);
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, int) void
   public void method_346(Graphics var1, int var2) {
      var1.setColor(var2);
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, int, int, int) void
   public void method_347(Graphics var1, int var2, int var3, int var4) {
      var1.setColor(var2, var3, var4);
   }

   // $VF: renamed from: d (int) void
   public void method_348(int var1) {
      this.field_526 = 1000 / var1;
   }
}
