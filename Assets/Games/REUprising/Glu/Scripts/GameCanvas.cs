// Transpiled from Java (GameCanvas.java) by Tools/J2meToCs. Regenerate rather than hand-edit where possible.
#pragma warning disable CS0162, CS0164, CS0168, CS0169, CS0219, CS0414, CS0649, CS1717, CS0108, CS0659, CS0661
using J2ME;

namespace REUprising.Glu
{
// $VF: renamed from: w
public class GameCanvas : Canvas, Runnable {
   static GameCanvas() { }

   // $VF: renamed from: c int
   public int frameIntervalMs;
   // $VF: renamed from: d com.capcomeuro.midp.CapcomMIDlet
   public static CapcomMIDlet midlet;
   // $VF: renamed from: e int
   public int exitCode;
   // $VF: renamed from: a m
   public static IGameScreenController screenController;
   // $VF: renamed from: f byte[][][]
   public static sbyte[][][] persistentGameData;
   // $VF: renamed from: g long[]
   public static long[] frameTimingSamples = new long[256];
   // $VF: renamed from: h boolean
   public static bool isCanvasActive = false;
   // $VF: renamed from: b boolean
   public static bool isCanvasHidden = false;

   public GameCanvas(CapcomMIDlet var1) {
      midlet = var1;
      this.setFullScreenMode(true);
   }

   // $VF: renamed from: a (m, int) void
   public void attachScreenController(IGameScreenController var1, int var2) {
      screenController = var1;
      screenController.attachCanvas(this);
      this.frameIntervalMs = 1000 / var2;
   }

   // $VF: renamed from: run () void
   public void run() {
      long var1 = 0L;
      long var3 = 0L;

      try {
         var1 = JSystem.currentTimeMillis();
         screenController.updateScreen();
         var3 = JSystem.currentTimeMillis();
         long var5 = (long)this.frameIntervalMs - (var3 - var1);

         try {
            if (var5 > 3L) {
               Thread.sleep(var5);
            } else {
               Thread.sleep(3L);
            }
         } catch (InterruptedException var8) {
         }
      } catch (System.Exception var9) {
      }

      Display.getDisplay(midlet).callSerially(this);
   }

   public override void paint(Graphics var1) {
      screenController.renderScreen(var1);
   }

   // $VF: renamed from: a () void
   public void repaintImmediately() {
      this.repaint();
      this.serviceRepaints();
   }

   public override void keyPressed(int var1) {
      screenController.onKeyPressed(var1);
   }

   public override void keyRepeated(int var1) {
      screenController.onKeyRepeated(var1);
   }

   public override void keyReleased(int var1) {
      screenController.onKeyReleased(var1);
   }

   public override void pointerPressed(int var1, int var2) {
      screenController.onPointerPressed(var1, var2);
   }

   public override void pointerReleased(int var1, int var2) {
      screenController.onPointerReleased(var1, var2);
   }

   public override void hideNotify() {
      isCanvasHidden = true;
      screenController.onCanvasHidden();
   }

   public override void showNotify() {
      screenController.onCanvasShown();
   }

   public override void sizeChanged(int var1, int var2) {
      screenController.onCanvasSizeChanged(var1, var2);
   }

   // $VF: renamed from: a (int) void
   public void setCanvasExitCode(int var1) {
      this.exitCode = var1;
   }

   // $VF: renamed from: a (java.lang.String) javax.microedition.lcdui.Image
   public static Image loadImageResource(string var0) {
      try {
         return Image.createImage(var0);
      } catch (System.Exception var2) {
         return null;
      }
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, javax.microedition.lcdui.Image, int, int, int, int, int, int, int, int) void
   public static void drawImageRegion(Graphics var0, Image var1, int var2, int var3, int var4, int var5, int var6, int var7, int var8, int var9) {
      var0.drawRegion(var1, var2, var3, var4, var5, var6, var7, var8, var9);
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, javax.microedition.lcdui.Image, int, int, int, int) void
   public static void drawImageAtAnchor(Graphics var0, Image var1, int var2, int var3, int var4, int var5) {
      drawImageRegion(var0, var1, 0, 0, var1.getWidth(), var1.getHeight(), var4, var2, var3, var5);
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, int, int, int, int, int) void
   public static void drawTriangle(Graphics var0, int var1, int var2, int var3, int var4, int var5) {
      try {
         var0.setColor(var5);
         sbyte var6 = 1;
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
      } catch (System.Exception var9) {
      }
   }

   // $VF: renamed from: b (java.lang.String) boolean
   public static bool requestPlatformUrl(string var0) {
      try {
         midlet.platformRequest(var0);
         return true;
      } catch (System.Exception var2) {
         return false;
      }
   }

   // $VF: renamed from: b () boolean
   public static bool isAdvertisingDisplayEnabled() {
      object var0 = null;
      var0 = midlet.getAppProperty("CAPCOM-GMG-Display");
      return var0 == null ? false : var0.equals("true");
   }

   // $VF: renamed from: b (int) void
   public static void initializePersistentGameData(int var0) {
      persistentGameData = new sbyte[var0][][];
   }

   // $VF: renamed from: a (int, int) void
   public static void initializePersistentDataSlot(int var0, int var1) {
      persistentGameData[var0] = new sbyte[var1][];
   }

   // $VF: renamed from: c () void
   public static void clearPersistentGameData() {
      persistentGameData = (sbyte[][][])null;
   }

   // $VF: renamed from: a (int, int, boolean) void
   public static void writePersistentBoolean(int var0, int var1, bool var2) {
      persistentGameData[var0][var1] = new sbyte[1];
      persistentGameData[var0][var1][0] = (sbyte)(var2 ? 1 : 0);
   }

   // $VF: renamed from: a (int, int, byte) void
   public static void writePersistentByte(int var0, int var1, sbyte var2) {
      persistentGameData[var0][var1] = new sbyte[1];
      persistentGameData[var0][var1][0] = var2;
   }

   // $VF: renamed from: a (int, int, int) void
   public static void writePersistentInteger(int var0, int var1, int var2) {
      persistentGameData[var0][var1] = new sbyte[4];
      persistentGameData[var0][var1] = encodeIntegerBytes(var2);
   }

   // $VF: renamed from: b (int, int) boolean
   public static bool readPersistentBoolean(int var0, int var1) {
      return persistentGameData[var0][var1][0] == 1;
   }

   // $VF: renamed from: c (int, int) byte
   public static sbyte readPersistentByte(int var0, int var1) {
      return persistentGameData[var0][var1][0];
   }

   // $VF: renamed from: d (int, int) int
   public static int readPersistentInteger(int var0, int var1) {
      return decodeIntegerBytes(persistentGameData[var0][var1]);
   }

   // $VF: renamed from: a (int, java.lang.String) boolean
   public static bool readPersistentRecord(int var0, string var1) {
      if (!persistentRecordExists(var1)) {
         return false;
      } else {
         RecordStore var2 = null;
         DataInputStream var3 = null;

         try {
            var2 = RecordStore.openRecordStore(var1, true);
            if (var2.getNumRecords() == 0) {
               return false;
            }

            sbyte[] var4 = var2.getRecord(1);
            var3 = new DataInputStream(new ByteArrayInputStream(var4));

            for (int var19 = 0; var19 < persistentGameData[var0].Length; var19++) {
               int var6 = var3.readInt();
               if (var6 != 0) {
                  persistentGameData[var0][var19] = new sbyte[var6];
                  var3.readFully(persistentGameData[var0][var19]);
               }
            }
         } catch (System.Exception var16) {
            return false;
         } finally {
            try {
               if (var3 != null) {
                  var3.close();
               }

               if (var2 != null) {
                  var2.closeRecordStore();
               }
            } catch (System.Exception var15) {
            }
         }

         return true;
      }
   }

   // $VF: renamed from: b (int, java.lang.String) void
   public static void writePersistentRecord(int var0, string var1) {
      RecordStore var2 = null;
      DataOutputStream var4 = null;

      try {
         if (persistentRecordExists(var1)) {
            RecordStore.deleteRecordStore(var1);
         }
      } catch (System.Exception var16) {
      }

      try {
         var2 = RecordStore.openRecordStore(var1, true);
         ByteArrayOutputStream var3 = new ByteArrayOutputStream();
         var4 = new DataOutputStream(var3);

         for (int var6 = 0; var6 < persistentGameData[var0].Length; var6++) {
            if (persistentGameData[var0][var6] == null) {
               var4.writeInt(0);
            } else {
               var4.writeInt(persistentGameData[var0][var6].Length);
               var4.write(persistentGameData[var0][var6]);
            }
         }

         sbyte[] var5 = var3.toByteArray();
         var2.addRecord(var5, 0, var5.Length);
      } catch (System.Exception var17) {
      } finally {
         try {
            if (var4 != null) {
               var4.close();
            }

            if (var2 != null) {
               var2.closeRecordStore();
            }
         } catch (System.Exception var15) {
         }
      }
   }

   // $VF: renamed from: c (java.lang.String) boolean
   public static bool persistentRecordExists(string var0) {
      string[] var1 = RecordStore.listRecordStores();
      if (var1 == null) {
         return false;
      } else {
         for (int var2 = 0; var2 < var1.Length; var2++) {
            if (var1[var2].equals(var0)) {
               return true;
            }
         }

         return false;
      }
   }

   // $VF: renamed from: a (java.lang.String[], java.lang.String) void
   public void readTextResource(string[] var1, string var2) {
      DataInputStream var3 = new DataInputStream(this.getClass().getResourceAsStream("/" + var2));

      try {
         var3.readInt();

         for (int var4 = 0; var4 < var1.Length; var4++) {
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
   public string readLocalizedResourceValue(string[] var1, string var2, int var3, int var4, int var5, bool var6, int var7) {
      this.readTextResource(var1, var2);
      return null;
   }

   // $VF: renamed from: d () java.lang.String[]
   public string[] getDisplayConfiguration() {
      string[] var1 = new string[3];

      try {
         var1[0] = "ENGLISH";
         var1[1] = JString.New("ESPA\u00C3\u0091OL".getBytes("ISO-8859-1"), "UTF-8");
         var1[2] = JString.New("PORTUGU\u00C3\u008aS".getBytes("ISO-8859-1"), "UTF-8");
      } catch (System.Exception var3) {
      }

      return var1;
   }

   // $VF: renamed from: a (byte[]) int
   public static int decodeIntegerBytes(sbyte[] var0) {
      int var1 = 0;

      for (int var2 = 0; var2 < 4; var2++) {
         int var3 = (3 - var2) * 8;
         var1 += (var0[var2] & 255) << var3;
      }

      return var1;
   }

   // $VF: renamed from: c (int) byte[]
   public static sbyte[] encodeIntegerBytes(int var0) {
      sbyte[] var1 = new sbyte[4];

      for (int var2 = 0; var2 < 4; var2++) {
         int var3 = (var1.Length - 1 - var2) * 8;
         var1[var2] = (sbyte)(JOps.Ushr(var0, var3) & 0xFF);
      }

      return var1;
   }

   // $VF: renamed from: e () com.capcomeuro.midp.CapcomMIDlet
   public static CapcomMIDlet getMidlet() {
      return midlet;
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, javax.microedition.lcdui.Image, int, int, int) void
   public void drawImage(Graphics var1, Image var2, int var3, int var4, int var5) {
      var1.drawImage(var2, var3, var4, var5);
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, int, int, int, int) void
   public void drawRectangle(Graphics var1, int var2, int var3, int var4, int var5) {
      var1.drawRect(var2, var3, var4, var5);
   }

   // $VF: renamed from: b (javax.microedition.lcdui.Graphics, int, int, int, int) void
   public void fillCanvasRectangle(Graphics var1, int var2, int var3, int var4, int var5) {
      var1.fillRect(var2, var3, var4, var5);
   }

   // $VF: renamed from: c (javax.microedition.lcdui.Graphics, int, int, int, int) void
   public void setGraphicsClip(Graphics var1, int var2, int var3, int var4, int var5) {
      var1.setClip(var2, var3, var4, var5);
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, int) void
   public void setGraphicsColor(Graphics var1, int var2) {
      var1.setColor(var2);
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, int, int, int) void
   public void setGraphicsRgbColor(Graphics var1, int var2, int var3, int var4) {
      var1.setColor(var2, var3, var4);
   }

   // $VF: renamed from: d (int) void
   public void setTargetFrameRate(int var1) {
      this.frameIntervalMs = 1000 / var1;
   }

   // alias for obfuscated name 'a'
   public void a(IGameScreenController var1, int var2) { attachScreenController(var1, var2); }

   // alias for obfuscated name 'a'
   public void a() { repaintImmediately(); }

   // alias for obfuscated name 'a'
   public void a(int var1) { setCanvasExitCode(var1); }

   // alias for obfuscated name 'a'
   public static Image a(string var0) { return loadImageResource(var0); }

   // alias for obfuscated name 'a'
   public static void a(Graphics var0, Image var1, int var2, int var3, int var4, int var5, int var6, int var7, int var8, int var9) { drawImageRegion(var0, var1, var2, var3, var4, var5, var6, var7, var8, var9); }

   // alias for obfuscated name 'a'
   public static void a(Graphics var0, Image var1, int var2, int var3, int var4, int var5) { drawImageAtAnchor(var0, var1, var2, var3, var4, var5); }

   // alias for obfuscated name 'a'
   public static void a(Graphics var0, int var1, int var2, int var3, int var4, int var5) { drawTriangle(var0, var1, var2, var3, var4, var5); }

   // alias for obfuscated name 'b'
   public static bool b(string var0) { return requestPlatformUrl(var0); }

   // alias for obfuscated name 'b'
   public static bool b() { return isAdvertisingDisplayEnabled(); }

   // alias for obfuscated name 'b'
   public static void b(int var0) { initializePersistentGameData(var0); }

   // alias for obfuscated name 'a'
   public static void a(int var0, int var1) { initializePersistentDataSlot(var0, var1); }

   // alias for obfuscated name 'c'
   public static void c() { clearPersistentGameData(); }

   // alias for obfuscated name 'a'
   public static void a(int var0, int var1, bool var2) { writePersistentBoolean(var0, var1, var2); }

   // alias for obfuscated name 'a'
   public static void a(int var0, int var1, sbyte var2) { writePersistentByte(var0, var1, var2); }

   // alias for obfuscated name 'a'
   public static void a(int var0, int var1, int var2) { writePersistentInteger(var0, var1, var2); }

   // alias for obfuscated name 'b'
   public static bool b(int var0, int var1) { return readPersistentBoolean(var0, var1); }

   // alias for obfuscated name 'c'
   public static sbyte c(int var0, int var1) { return readPersistentByte(var0, var1); }

   // alias for obfuscated name 'd'
   public static int d(int var0, int var1) { return readPersistentInteger(var0, var1); }

   // alias for obfuscated name 'a'
   public static bool a(int var0, string var1) { return readPersistentRecord(var0, var1); }

   // alias for obfuscated name 'b'
   public static void b(int var0, string var1) { writePersistentRecord(var0, var1); }

   // alias for obfuscated name 'c'
   public static bool c(string var0) { return persistentRecordExists(var0); }

   // alias for obfuscated name 'a'
   public void a(string[] var1, string var2) { readTextResource(var1, var2); }

   // alias for obfuscated name 'a'
   public string a(string[] var1, string var2, int var3, int var4, int var5, bool var6, int var7) { return readLocalizedResourceValue(var1, var2, var3, var4, var5, var6, var7); }

   // alias for obfuscated name 'd'
   public string[] d() { return getDisplayConfiguration(); }

   // alias for obfuscated name 'a'
   public static int a(sbyte[] var0) { return decodeIntegerBytes(var0); }

   // alias for obfuscated name 'c'
   public static sbyte[] c(int var0) { return encodeIntegerBytes(var0); }

   // alias for obfuscated name 'e'
   public static CapcomMIDlet e() { return getMidlet(); }

   // alias for obfuscated name 'a'
   public void a(Graphics var1, Image var2, int var3, int var4, int var5) { drawImage(var1, var2, var3, var4, var5); }

   // alias for obfuscated name 'a'
   public void a(Graphics var1, int var2, int var3, int var4, int var5) { drawRectangle(var1, var2, var3, var4, var5); }

   // alias for obfuscated name 'b'
   public void b(Graphics var1, int var2, int var3, int var4, int var5) { fillCanvasRectangle(var1, var2, var3, var4, var5); }

   // alias for obfuscated name 'c'
   public void c(Graphics var1, int var2, int var3, int var4, int var5) { setGraphicsClip(var1, var2, var3, var4, var5); }

   // alias for obfuscated name 'a'
   public void a(Graphics var1, int var2) { setGraphicsColor(var1, var2); }

   // alias for obfuscated name 'a'
   public void a(Graphics var1, int var2, int var3, int var4) { setGraphicsRgbColor(var1, var2, var3, var4); }

   // alias for obfuscated name 'd'
   public void d(int var1) { setTargetFrameRate(var1); }
}
}
