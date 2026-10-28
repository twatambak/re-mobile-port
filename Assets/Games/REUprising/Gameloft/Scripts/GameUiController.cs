// Transpiled from Java (class_17.java) by Tools/J2meToCs. Regenerate rather than hand-edit where possible.
#pragma warning disable CS0162, CS0164, CS0168, CS0169, CS0219, CS0414, CS0649, CS1717, CS0108, CS0659, CS0661
using J2ME;

namespace REUprising.Gameloft
{
// $VF: renamed from: m
public class GameUiController : Runnable, CommandListener {
   static GameUiController() { }

   // $VF: renamed from: a java.lang.String
   public static string mobileLibraryVersion = "2.1";
   // $VF: renamed from: b java.lang.String
   public static string mobileLibrarySignature = "IGP-Signature=" + mobileLibraryVersion;
   // $VF: renamed from: c java.lang.String
   public static string mobileLibraryRequest = "";
   // $VF: renamed from: a int
   public static int uiIntegerValue01 = 0;
   // $VF: renamed from: d java.lang.String
   public static string uiTextValue01;
   // $VF: renamed from: a javax.microedition.lcdui.Font
   public static Font uiFontReference01;
   // $VF: renamed from: b int
   public static int uiIntegerValue02 = 13568256;
   // $VF: renamed from: c int
   public static int uiIntegerValue03 = 2;
   // $VF: renamed from: d int
   public static int uiIntegerValue04 = 2;
   // $VF: renamed from: e int
   public static int uiIntegerValue05;
   // $VF: renamed from: f int
   public static int uiIntegerValue06;
   // $VF: renamed from: g int
   public static int uiIntegerValue07;
   // $VF: renamed from: h int
   public static int uiIntegerValue08 = 0;
   // $VF: renamed from: a boolean[]
   public static bool[] uiBooleanArray01 = new bool[1];
   // $VF: renamed from: a int[]
   public static int[] uiIntegerArray01 = new int[1];
   // $VF: renamed from: i int
   public static int uiIntegerValue09;
   // $VF: renamed from: j int
   public static int uiIntegerValue10 = -1;
   // $VF: renamed from: k int
   public static int uiIntegerValue11 = 8;
   // $VF: renamed from: l int
   public static int uiIntegerValue12;
   // $VF: renamed from: m int
   public static int uiIntegerValue13;
   // $VF: renamed from: n int
   public static int uiIntegerValue14;
   // $VF: renamed from: o int
   public static int uiIntegerValue15;
   // $VF: renamed from: p int
   public static int uiIntegerValue16;
   // $VF: renamed from: q int
   public static int uiIntegerValue17;
   // $VF: renamed from: r int
   public static int uiIntegerValue18;
   // $VF: renamed from: s int
   public static int uiIntegerValue19;
   // $VF: renamed from: t int
   public static int uiIntegerValue20;
   // $VF: renamed from: u int
   public static int uiIntegerValue21;
   // $VF: renamed from: v int
   public static int uiIntegerValue22;
   // $VF: renamed from: w int
   public static int uiIntegerValue23;
   // $VF: renamed from: x int
   public static int uiIntegerValue24;
   // $VF: renamed from: y int
   public static int uiIntegerValue25;
   // $VF: renamed from: z int
   public static int uiIntegerValue26;
   // $VF: renamed from: A int
   public static int uiIntegerValue27;
   // $VF: renamed from: B int
   public static int uiIntegerValue28;
   // $VF: renamed from: C int
   public static int uiIntegerValue29;
   // $VF: renamed from: D int
   public static int uiIntegerValue30;
   // $VF: renamed from: E int
   public static int uiIntegerValue31;
   // $VF: renamed from: F int
   public static int uiIntegerValue32;
   // $VF: renamed from: G int
   public static int uiIntegerValue33;
   // $VF: renamed from: H int
   public static int uiIntegerValue34;
   // $VF: renamed from: I int
   public static int uiIntegerValue35;
   // $VF: renamed from: J int
   public static int uiIntegerValue36 = 14;
   // $VF: renamed from: K int
   public static int uiIntegerValue37;
   // $VF: renamed from: b int[]
   public static int[] uiIntegerArray02;
   // $VF: renamed from: a byte[][]
   public static sbyte[][] uiByteMatrix01;
   // $VF: renamed from: L int
   public static int uiIntegerValue38;
   // $VF: renamed from: a byte[]
   public static sbyte[] uiByteArray01;
   // $VF: renamed from: M int
   public static int uiIntegerValue39;
   // $VF: renamed from: N int
   public static int uiIntegerValue40 = 0;
   // $VF: renamed from: O int
   public static int uiIntegerValue41 = 1;
   // $VF: renamed from: P int
   public static int uiIntegerValue42 = 2;
   // $VF: renamed from: Q int
   public static int uiIntegerValue43 = 3;
   // $VF: renamed from: a javax.microedition.lcdui.Image[]
   public static Image[] uiImageReferenceArray01;
   // $VF: renamed from: R int
   public static int uiIntegerValue44;
   // $VF: renamed from: c int[]
   public static int[] uiIntegerArray03;
   // $VF: renamed from: S int
   public static int uiIntegerValue45;
   // $VF: renamed from: T int
   public static int uiIntegerValue46;
   // $VF: renamed from: a boolean
   public static bool uiBooleanFlag01;
   // $VF: renamed from: a java.lang.String[]
   public static string[] uiTextArray01 = new string[]{"URL-WN", "URL-BS", "URL"};
   // $VF: renamed from: e java.lang.String
   public static string uiTextValue02;
   // $VF: renamed from: b boolean
   public static bool uiBooleanFlag02;
   // $VF: renamed from: c boolean
   public static bool uiBooleanFlag03;
   // $VF: renamed from: b java.lang.String[]
   public static string[] uiTextArray02 = new string[0];
   // $VF: renamed from: c java.lang.String[]
   public static string[] uiTextArray03;
   // $VF: renamed from: d java.lang.String[]
   public static string[] uiTextArray04;
   // $VF: renamed from: e java.lang.String[]
   public static string[] uiTextArray05;
   // $VF: renamed from: U int
   public static int uiIntegerValue47;
   // $VF: renamed from: V int
   public static int uiIntegerValue48;
   // $VF: renamed from: f java.lang.String[]
   public static string[] uiTextArray06;
   // $VF: renamed from: a short[]
   public static short[] uiShortArray01;
   // $VF: renamed from: W int
   public static int uiIntegerValue49;
   // $VF: renamed from: d boolean
   public static bool uiBooleanFlag04;
   // $VF: renamed from: e boolean
   public static bool uiBooleanFlag05;
   // $VF: renamed from: f boolean
   public static bool uiBooleanFlag06 = false;
   // $VF: renamed from: g boolean
   public static bool uiBooleanFlag07 = false;
   // $VF: renamed from: a long
   public static long uiLongValue01 = 0L;
   // $VF: renamed from: h boolean
   public static bool uiBooleanFlag08 = true;
   // $VF: renamed from: a javax.microedition.midlet.MIDlet
   public static MIDlet midlet;
   // $VF: renamed from: a javax.microedition.lcdui.Canvas
   public static Canvas displayCanvas;
   // $VF: renamed from: f java.lang.String
   public static string uiTextValue03;
   // $VF: renamed from: i boolean
   public static bool uiBooleanFlag09 = false;
   // $VF: renamed from: a javax.microedition.lcdui.CommandListener
   public static CommandListener uiCommandListenerReference01 = null;
   // $VF: renamed from: a m
   public static GameUiController gameUiController = null;
   // $VF: renamed from: j boolean
   public static bool uiBooleanFlag10 = false;
   // $VF: renamed from: g java.lang.String
   public static string uiTextValue04 = null;
   // $VF: renamed from: k boolean
   public static bool uiBooleanFlag11 = false;
   // $VF: renamed from: l boolean
   public static bool uiBooleanFlag12 = false;
   // $VF: renamed from: X int
   public static int uiIntegerValue50;
   // $VF: renamed from: Y int
   public static int uiIntegerValue51;
   // $VF: renamed from: Z int
   public static int uiIntegerValue52;
   // $VF: renamed from: aa int
   public static int uiIntegerValue53;
   // $VF: renamed from: ab int
   public static int uiIntegerValue54;
   // $VF: renamed from: b javax.microedition.lcdui.Image[]
   public static Image[] uiImageReferenceArray02;
   // $VF: renamed from: c javax.microedition.lcdui.Image[]
   public static Image[] uiImageReferenceArray03;
   // $VF: renamed from: a javax.microedition.lcdui.Image
   public static Image uiImageReference01;
   // $VF: renamed from: b javax.microedition.lcdui.Image
   public static Image uiImageReference02;
   // $VF: renamed from: c javax.microedition.lcdui.Image
   public static Image uiImageReference03;
   // $VF: renamed from: d javax.microedition.lcdui.Image
   public static Image uiImageReference04;
   // $VF: renamed from: e javax.microedition.lcdui.Image
   public static Image uiImageReference05;
   // $VF: renamed from: f javax.microedition.lcdui.Image
   public static Image uiImageReference06;
   // $VF: renamed from: g javax.microedition.lcdui.Image
   public static Image uiImageReference07;
   // $VF: renamed from: h javax.microedition.lcdui.Image
   public static Image uiImageReference08;
   // $VF: renamed from: i javax.microedition.lcdui.Image
   public static Image uiImageReference09;
   // $VF: renamed from: j javax.microedition.lcdui.Image
   public static Image uiImageReference10;
   // $VF: renamed from: d javax.microedition.lcdui.Image[]
   public static Image[] uiImageReferenceArray04;
   // $VF: renamed from: k javax.microedition.lcdui.Image
   public static Image uiImageReference11;
   // $VF: renamed from: a javax.microedition.lcdui.Image[][]
   public static Image[][] uiImageReferenceArrayArray01;
   // $VF: renamed from: a java.lang.String[][]
   public static string[][] uiTextMatrix01;
   // $VF: renamed from: a int[][]
   public static int[][] uiIntegerMatrix01;
   // $VF: renamed from: b int[][]
   public static int[][] uiIntegerMatrix02;
   // $VF: renamed from: d int[]
   public static int[] uiIntegerArray04;
   // $VF: renamed from: ac int
   public static int uiIntegerValue55;
   // $VF: renamed from: ad int
   public static int uiIntegerValue56;
   // $VF: renamed from: ae int
   public static int uiIntegerValue57;
   // $VF: renamed from: af int
   public static int uiIntegerValue58;
   // $VF: renamed from: ag int
   public static int uiIntegerValue59;
   // $VF: renamed from: ah int
   public static int uiIntegerValue60;
   // $VF: renamed from: ai int
   public static int uiIntegerValue61;
   // $VF: renamed from: aj int
   public static int uiIntegerValue62;
   // $VF: renamed from: ak int
   public static int uiIntegerValue63;
   // $VF: renamed from: al int
   public static int uiIntegerValue64;
   // $VF: renamed from: am int
   public static int uiIntegerValue65 = -1;
   // $VF: renamed from: g java.lang.String[]
   public static string[] uiTextArray07;
   // $VF: renamed from: e int[]
   public static int[] uiIntegerArray05;
   // $VF: renamed from: b boolean[]
   public static bool[] uiBooleanArray02;
   // $VF: renamed from: an int
   public static int uiIntegerValue66 = 0;
   // $VF: renamed from: ao int
   public static int uiIntegerValue67;
   // $VF: renamed from: m boolean
   public static bool uiBooleanFlag13;
   // $VF: renamed from: a byte
   public static sbyte uiByteValue01;
   // $VF: renamed from: b byte
   public static sbyte uiByteValue02;
   // $VF: renamed from: n boolean
   public static bool uiBooleanFlag14;
   // $VF: renamed from: ap int
   public static int uiIntegerValue68;
   // $VF: renamed from: aq int
   public static int uiIntegerValue69;
   // $VF: renamed from: ar int
   public static int uiIntegerValue70;
   // $VF: renamed from: as int
   public static int uiIntegerValue71;
   // $VF: renamed from: at int
   public static int uiIntegerValue72;
   // $VF: renamed from: au int
   public static int uiIntegerValue73;
   // $VF: renamed from: h java.lang.String
   public static string uiTextValue05;
   // $VF: renamed from: i java.lang.String
   public static string uiTextValue06;
   // $VF: renamed from: j java.lang.String
   public static string uiTextValue07 = "";
   // $VF: renamed from: k java.lang.String
   public static string uiTextValue08;
   // $VF: renamed from: av int
   public static int uiIntegerValue74;
   // $VF: renamed from: aw int
   public static int uiIntegerValue75;
   // $VF: renamed from: ax int
   public static int uiIntegerValue76;
   // $VF: renamed from: ay int
   public static int uiIntegerValue77;
   // $VF: renamed from: a javax.microedition.lcdui.Command
   public static Command uiCommandReference01;
   // $VF: renamed from: b javax.microedition.lcdui.Command
   public static Command uiCommandReference02;
   // $VF: renamed from: az int
   public static int uiIntegerValue78 = 0;
   // $VF: renamed from: o boolean
   public static bool uiBooleanFlag15 = false;
   // $VF: renamed from: p boolean
   public static bool uiBooleanFlag16 = false;
   // $VF: renamed from: aA int
   public static int uiIntegerValue79 = -1;
   // $VF: renamed from: aB int
   public static int uiIntegerValue80 = -1;
   // $VF: renamed from: aC int
   public static int uiIntegerValue81 = -1;
   // $VF: renamed from: aD int
   public static int uiIntegerValue82 = -1;
   // $VF: renamed from: aE int
   public static int uiIntegerValue83;
   // $VF: renamed from: aF int
   public static int uiIntegerValue84;
   // $VF: renamed from: aG int
   public static int uiIntegerValue85;
   // $VF: renamed from: a java.util.Hashtable
   public static Hashtable uiHashtableReference01 = new Hashtable();
   // $VF: renamed from: q boolean
   public static bool uiBooleanFlag17 = false;
   // $VF: renamed from: aH int
   public static int uiIntegerValue86 = 0;
   // $VF: renamed from: b short[]
   public static short[] uiShortArray02 = new short[50];

   // $VF: renamed from: c () boolean
   public static bool initializeUiController() {
      resetUiState();

      try {
         InputStream var0;
         uiIntegerArray02 = new int[uiIntegerValue37 = (uiIntegerValue37 = (var0 = openUiResourceStream("/dataIGP")).read() & 0xFF) + ((var0.read() & 0xFF) << 8)];

         for (int var1 = 0; var1 < uiIntegerValue37; var1++) {
            uiIntegerArray02[var1] = var0.read() & 0xFF;
            uiIntegerArray02[var1] = uiIntegerArray02[var1] + ((var0.read() & 0xFF) << 8);
            uiIntegerArray02[var1] = uiIntegerArray02[var1] + ((var0.read() & 0xFF) << 16);
            uiIntegerArray02[var1] = uiIntegerArray02[var1] + ((var0.read() & 0xFF) << 24);
         }

         var0.close();
         return true;
      } catch (System.Exception var2) {
         return false;
      }
   }

   // $VF: renamed from: b () void
   public static void resetUiState() {
      uiIntegerArray02 = null;
      uiByteMatrix01 = null;
      uiIntegerValue37 = 0;
      JSystem.gc();
   }

   // $VF: renamed from: a (int) byte[]
   public static sbyte[] getUiResourceBytes(int var0) {
      if (var0 >= 0 && var0 < uiIntegerValue37 - 1) {
         int var1;
         if ((var1 = uiIntegerArray02[var0 + 1] - uiIntegerArray02[var0]) == 0) {
            return null;
         } else {
            sbyte[] var2 = null;

            try {
               InputStream var3;
               (var3 = openUiResourceStream("/dataIGP")).skip((long)(2 + 4 * uiIntegerValue37 + uiIntegerArray02[var0]));
               int var5 = (var2 = new sbyte[var1]).Length;

               while (var5 > 0) {
                  var5 -= var3.read(var2);
               }

               var3.close();
            } catch (System.Exception var4) {
            }

            return var2;
         }
      } else {
         return null;
      }
   }

   // $VF: renamed from: a (byte[]) int
   public static int readUiUnsignedByte(sbyte[] var0) {
      return (var0[uiIntegerValue38++] & 0xFF) + ((var0[uiIntegerValue38++] & 0xFF) << 8);
   }

   // $VF: renamed from: a (byte[]) byte[]
   public static sbyte[] decodeUiImageBytes(sbyte[] var0) {
      int var1;
      sbyte[] var2 = new sbyte[var1 = readUiUnsignedByte(var0)];
      JSystem.arraycopy(var0, uiIntegerValue38, var2, 0, var1);
      uiIntegerValue38 += var1;
      return var2;
   }

   // $VF: renamed from: a (byte[]) javax.microedition.lcdui.Image
   public static Image createUiImage(sbyte[] var0) {
      sbyte[] var1;
      return Image.createImage(var1 = decodeUiImageBytes(var0), 0, var1.Length);
   }

   // $VF: renamed from: a (int) java.lang.String
   public static string getUiText(int var0) {
      return "" + uiTextArray06[var0];
   }

   // $VF: renamed from: a (int, int) int
   public static int measureUiText(int var0, int var1) {
      if (uiIntegerValue86 != 0) {
         if (var1 != 0 && var1 != uiIntegerValue41) {
            return uiByteArray01[var0 * 6 + var1] & 0xFF;
         } else {
            int var2 = uiByteArray01[var0 * 6 + var1] & 255;
            var0 = uiByteArray01[var0 * 6 + var1 + 1] & 255;
            int var4;
            return (var4 = 0 | (var0 & 0xFF) << 8) | var2 & 0xFF;
         }
      } else {
         return uiByteArray01[(var0 << 2) + var1] & 0xFF;
      }
   }

   // $VF: renamed from: a (int, javax.microedition.lcdui.Graphics, int, int, int) void
   public static void drawUiTextById(int var0, Graphics var1, int var2, int var3, int var4) {
      drawUiText(getUiText(var0), var1, uiIntegerValue74, var2, var3, var4);
   }

   // $VF: renamed from: a (java.lang.String, javax.microedition.lcdui.Graphics, int, int, int, int) void
   public static void drawUiText(string var0, Graphics var1, int var2, int var3, int var4, int var5) {
      drawWrappedUiText(var0, var1, var3, var4, var5);
   }

   // $VF: renamed from: a (java.lang.String, javax.microedition.lcdui.Graphics, int, int, int) void
   public static void drawWrappedUiText(string var0, Graphics var1, int var2, int var3, int var4) {
      string var21 = var0;
      uiIntegerArray03[0] = 0;
      uiIntegerValue46 = 0;
      int var5 = 0;
      int var10 = var0.length();
      sbyte var11 = 0;
      if (uiIntegerValue74 <= 176 && uiIntegerArray05[uiIntegerValue52] == 4) {
         var11 += 2;
      }

      for (int var7 = 0; var7 < var10; var7++) {
         char var6;
         if ((var6 = var21.charAt(var7)) != '\n' || var5 >= 10) {
            if (var6 != '\\' || var21.charAt(++var7) != 'N') {
               if (var6 != 0 && var6 != 1) {
                  uiIntegerArray03[var5] = uiIntegerArray03[var5] + measureUiText(var6, uiIntegerValue42) + uiIntegerValue08;
               }
               continue;
            }
         }

         uiIntegerArray03[var5] = uiIntegerArray03[var5] - uiIntegerValue08;
         if (uiIntegerArray03[var5] > uiIntegerValue46) {
            uiIntegerValue46 = uiIntegerArray03[var5];
         }

         var5++;
         uiIntegerArray03[var5] = 0;
      }

      uiIntegerArray03[var5] = uiIntegerArray03[var5] - uiIntegerValue08;
      if (uiIntegerArray03[var5] > uiIntegerValue46) {
         uiIntegerValue46 = uiIntegerArray03[var5];
      }

      uiIntegerValue45 = (var5 + 1) * uiIntegerValue39 + var5 * (var11 + 0);
      if (uiBooleanFlag01) {
         uiBooleanFlag01 = false;
      } else {
         int var22 = var3 + (var11 + 0) * var5 / 2;
         int var23 = 0;
         if ((var4 & 32) != 0) {
            var22 -= uiIntegerValue45;
         } else if ((var4 & 2) != 0) {
            var22 -= uiIntegerValue45 >> 1;
         }

         int var12 = var2;
         bool var8 = true;
         bool var9 = false;
         drawUiProgressBar(var1, 0, 0, uiIntegerValue74, uiIntegerValue75);

         for (int var25 = 0; var25 < var10; var25++) {
            char var24 = var21.charAt(var25);
            if (var8) {
               var12 = var2;
               if ((var4 & 8) != 0) {
                  var12 = var2 - uiIntegerArray03[var23];
               } else if ((var4 & 1) != 0) {
                  var12 = var2 - (uiIntegerArray03[var23] >> 1);
               }

               var8 = false;
            }

            
            if (var24 != '\n' || var23 >= 10) {
               if (var24 == '\\') {
                  if (var21.charAt(++var25) == 'N') {
                     goto label82_brk;
                  }
               }

               if (var9) {
                  var9 = false;
                  char var13;
                  if ((var13 = var21.charAt(var25 - 2)) == ' ') {
                     var12 -= measureUiText(var13, uiIntegerValue42) + uiIntegerValue08 >> 1;
                  }

                  if (var24 == ' ') {
                     var12 += measureUiText(var24, uiIntegerValue42) + uiIntegerValue08 >> 1;
                     continue;
                  }
               }

               drawUiProgressBar(var1, var12, var22, measureUiText(var24, uiIntegerValue42), measureUiText(var24, uiIntegerValue43));
               Image var10001 = uiImageReferenceArray01[uiIntegerValue44];
               int var10002 = measureUiText(var24, 0);
               int var10003 = measureUiText(var24, uiIntegerValue41);
               int var10004 = measureUiText(var24, uiIntegerValue42);
               int var18 = measureUiText(var24, uiIntegerValue43);
               int var17 = var10004;
               int var16 = var10003;
               int var15 = var10002;
               Image var14 = var10001;
               var1.drawRegion(var14, var15, var16, var17, var18, 0, var12, var22, 20);
               var12 += measureUiText(var24, uiIntegerValue42) + uiIntegerValue08;
               continue;
            } label82_brk:;

            var22 += uiIntegerValue39 + var11 - 1;
            var23++;
            var8 = true;
            var9 = true;
         }

         drawUiProgressBar(var1, 0, 0, uiIntegerValue74, uiIntegerValue75);
         uiIntegerValue44 = 1;
      }
   }

   // $VF: renamed from: a (javax.microedition.midlet.MIDlet, javax.microedition.lcdui.Canvas, int, int) void
   public static void configureUiDisplay(MIDlet var0, Canvas var1, int var2, int var3) {
      object var4 = null;
      new StringBuffer()
         .append("initialize(midlet = ")
         .append(var0)
         .append(", game = ")
         .append(var1)
         .append(", screenWidth = ")
         .append(var2)
         .append(", screenHeight = ")
         .append(var3)
         .append(", cmdListener = ")
         .append((string)null)
         .append(")");
      uiIntegerValue74 = var2;
      uiIntegerValue75 = var3;
      uiIntegerValue76 = uiIntegerValue74 >> 1;
      uiIntegerValue77 = uiIntegerValue75 >> 1;
      uiIntegerValue05 = uiIntegerValue75 * 5 / 100;
      uiIntegerValue06 = uiIntegerValue75 / 2;
      uiIntegerValue07 = uiIntegerValue75 * 93 / 100;
      if (2 > uiIntegerValue74) {
         uiIntegerValue03 = 2;
      }

      if (2 > uiIntegerValue74) {
         uiIntegerValue04 = 2;
      }

      if (midlet == null && var1 != null) {
         midlet = var0;
         displayCanvas = var1;
         loadLocalizedUiStrings();
         string var6 = mobileLibrarySignature;
         new StringBuffer().append(var6).append("");
      }
   }

   // $VF: renamed from: a (java.lang.String, int) boolean
   public static bool isUiStringValid(string var0, int var1) {
      if (var0 == null) {
         return (var1 & 1) == 0;
      } else {
         var0 = var0.trim();
         return ((var1 & 1) == 0 || var0.length() != 0)
            && ((var1 & 2) == 0 || var0.toUpperCase().compareTo("DEL") != 0)
            && ((var1 & 4) == 0 || var0.toUpperCase().compareTo("NO") != 0 && var0.toUpperCase().compareTo("0") != 0);
      }
   }

   // $VF: renamed from: a (java.lang.String, java.lang.String, java.lang.String) java.lang.String
   public static string buildMobileLibraryUrl(string var0, string var1, string var2) {
      string var3 = "";

      try {
         if (var2 != null && var0 != null && var1 != null) {
            int var4 = var0.indexOf(var1 + "=");
            string var7 = var2.trim();
            if (var4 >= 0 && var7.length() > 0) {
               var4 += var1.length() + 1;
               int var8;
               if ((var8 = var0.indexOf(";", var4)) < 0) {
                  var8 = var0.length();
               }

               if ((var3 = var0.substring(var4, var8).trim()).length() == 0 || var3.compareTo("0") == 0 || var3.toUpperCase().compareTo("NO") == 0) {
                  var3 = "";
               } else if (var3.toUpperCase().compareTo("DEL") != 0 && var1.compareTo("OP") != 0) {
                  int var6;
                  if ((var6 = var7.indexOf("XXXX")) >= 0) {
                     var3 = var7.substring(0, var6) + var3 + var7.substring(var6 + "XXXX".length());
                  } else {
                     var3 = var7;
                  }
               }
            }
         }
      } catch (System.Exception var5) {
         var3 = "";
      }

      return var3;
   }

   // $VF: renamed from: a (int, java.lang.String, int, java.lang.String, java.lang.String) void
   public static void openMobileLibraryPage(int var0, string var1, int var2, string var3, string var4) {
      try {
         if (uiBooleanFlag03) {
            var1 = buildMobileLibraryUrl(midlet.getAppProperty(var3), var1, var4);
         } else {
            string var7 = "URL-" + var1;
            var1 = midlet.getAppProperty(var7);
         }

         if (isUiStringValid(var1, 7) && (var1.toUpperCase().compareTo("NO") != 0 || var1.toUpperCase().compareTo("0") != 0)) {
            uiBooleanArray02[var0] = true;
            uiTextArray07[var0] = var1;
            if (uiBooleanArray02[var0] && var0 != uiIntegerValue12) {
               uiIntegerValue66++;
               uiIntegerArray05[var0] = 4;
               if (uiBooleanFlag02) {
                  uiTextArray07[var0] = uiTextArray07[var0] + "&ctg=SC" + (uiIntegerValue66 < 10 ? "0" : "") + uiIntegerValue66;
               }
            }
         }
      } catch (System.Exception var5) {
      }
   }

   // $VF: renamed from: a (int, java.lang.String[], int, java.lang.String) void
   public static void setMenuOptions(int var0, string[] var1, int var2, string var3) {
      int var4 = var1.Length;
      uiTextMatrix01[var0] = new string[var4];
      uiIntegerMatrix01[var0] = new int[var4];
      uiIntegerMatrix02[var0] = new int[var4];
      int var5 = 0;
      if (!uiBooleanArray01[0]) {
         string var6 = "";
         if (uiBooleanFlag03) {
            try {
               var3 = midlet.getAppProperty(var3);
               if (var0 != 2) {
                  var6 = uiTextValue02;
               } else if (uiTextValue07.length() > 0 && uiBooleanFlag02) {
                  var6 = uiTextValue07 + "&ctg=XXXX";
               } else if (uiTextValue07.length() > 0) {
                  var6 = uiTextValue07;
               }
            } catch (System.Exception var10) {
            }
         }

         for (int var7 = 0; var7 < var1.Length; var7++) {
            try {
               string var8 = "";
               if (var0 != 2 && var7 == var4 - 1) {
                  if (!uiBooleanFlag03) {
                     var8 = uiTextArray01[var0];
                     var8 = midlet.getAppProperty(var8);
                  } else if (uiTextValue07.length() > 0) {
                     var8 = "IGP-CATEGORIES";
                     var8 = buildMobileLibraryUrl(midlet.getAppProperty(var8), var1[var7], uiTextValue07 + (uiBooleanFlag02 ? "&ctg=XXXX" : ""));
                  }
               } else if (uiBooleanFlag03) {
                  if (var1[var7].compareTo("GLDT") == 0) {
                     var8 = buildMobileLibraryUrl(var3, var1[var7], uiTextValue02);
                  } else if (var1[var7].compareTo("CATALOG") == 0) {
                     var8 = uiTextValue07;
                  } else {
                     var8 = buildMobileLibraryUrl(var3, var1[var7], var6);
                  }
               } else {
                  var8 = uiTextArray01[var0] + "-" + var1[var7];
                  var8 = midlet.getAppProperty(var8);
               }

               if (isUiStringValid(var8, 7)) {
                  uiTextMatrix01[var0][var5] = var8;
                  uiIntegerMatrix01[var0][var5++] = var7;
                  int var14 = var2 - (var1.Length - 1) + var7;
                  uiIntegerMatrix02[var0][var7] = var14;
               }
            } catch (System.Exception var9) {
            }
         }

         if (var5 > 0) {
            uiBooleanArray02[uiIntegerValue13 + var0] = true;
            uiIntegerArray04[var0] = var5;
         }
      }
   }

   // $VF: renamed from: a (byte[]) java.lang.String[]
   public static string[] decodeUiStringArray(sbyte[] var0) {
      string[] var1 = new string[readUiUnsignedByte(var0)];

      for (int var2 = 0; var2 < var1.Length; var2++) {
         int var3 = readUiUnsignedByte(var0);
         var1[var2] = JString.New(var0, uiIntegerValue38, var3);
         uiIntegerValue38 += var3;
      }

      return var1;
   }

   // $VF: renamed from: c () void
   public static void loadLocalizedUiStrings() {
      string[] var8;
      try {
         if (!initializeUiController()) {
            uiBooleanFlag11 = false;
            return;
         }

         sbyte[] var1;
         readUiUnsignedByte(var1 = getUiResourceBytes(0));
         int var0 = readUiUnsignedByte(var1);
         uiIntegerValue38 += var0;
         uiTextArray02 = decodeUiStringArray(var1);
         var8 = decodeUiStringArray(var1);
         uiTextArray03 = decodeUiStringArray(var1);
         uiTextArray04 = decodeUiStringArray(var1);
         uiTextArray05 = decodeUiStringArray(var1);

         for (int var2 = 0; var2 < uiBooleanArray01.Length; var2++) {
            uiBooleanArray01[var2] = readUiUnsignedByte(var1) == 1;
         }

         try {
            int var19 = readUiUnsignedByte(var1);
            if ((mobileLibraryRequest = JString.New(var1, uiIntegerValue38, var19)).equals("2.1z")) {
               uiIntegerValue86 = 2;
               uiIntegerValue41 = 2;
               uiIntegerValue42 = 4;
               uiIntegerValue43 = 5;
            }

            if (!mobileLibraryRequest.startsWith(mobileLibraryVersion)) {
               new StringBuffer().append("Invalid dataIGP file, dataIGP file IGP Version : ").append(mobileLibraryRequest);
               new StringBuffer().append("IGP Class version : ").append(mobileLibraryVersion);
            }
         } catch (System.Exception var6) {
            uiBooleanFlag11 = false;
         }

         resetUiState();
      } catch (System.Exception var7) {
         uiBooleanFlag11 = false;
         return;
      }

      int var9 = (var8.Length - 1 > 0 ? var8.Length - 1 : 0) + 4;
      uiIntegerValue17 = ++var9;
      int var11 = uiIntegerValue29 = (
            uiIntegerValue28 = (
                  uiIntegerValue27 = (
                        uiIntegerValue26 = (
                              uiIntegerValue25 = (
                                    uiIntegerValue24 = (uiIntegerValue23 = (uiIntegerValue22 = (uiIntegerValue21 = (uiIntegerValue20 = (uiIntegerValue19 = (uiIntegerValue18 = var9 + 1) + 1) + 1) + 1) + 1) + 1)
                                       + 1
                                 )
                                 + 1
                           )
                           + 1
                     )
                     + 1
               )
               + 1
         )
         + 1;
      if (uiTextArray03.Length > 1) {
         uiIntegerValue31 = (uiIntegerValue30 = var11 + 1) + (uiTextArray03.Length - 1);
      } else {
         uiIntegerValue31 = var11 + 1;
      }

      var9 = uiIntegerValue31;
      if (uiTextArray04.Length > 1) {
         uiIntegerValue33 = (uiIntegerValue32 = var9 + 1) + (uiTextArray04.Length - 1);
      } else {
         uiIntegerValue33 = var9 + 1;
      }

      var9 = uiIntegerValue33;
      uiIntegerValue35 = (uiIntegerValue34 = uiIntegerValue33 + 1) + 1;
      uiImageReferenceArray04 = new Image[uiIntegerValue47 = var8.Length];
      uiIntegerValue48 = uiIntegerValue47 + 1 + 1 + 1 + 1 + (uiBooleanArray01[0] ? 1 : 0);

      for (int var14 = 0; var14 < uiBooleanArray01.Length; var14++) {
         if (uiBooleanArray01[var14]) {
            uiIntegerArray01[var14] = ++uiIntegerValue11;
         } else {
            uiIntegerArray01[var14] = --uiIntegerValue10;
         }
      }

      uiIntegerValue09 = ++uiIntegerValue11;
      uiTextArray07 = new string[uiIntegerValue48];
      uiBooleanArray02 = new bool[uiIntegerValue48];
      uiIntegerArray05 = new int[uiIntegerValue48];

      for (int var15 = 0; var15 < uiBooleanArray02.Length; var15++) {
         uiBooleanArray02[var15] = false;
      }

      uiIntegerValue16 = (uiIntegerValue15 = (uiIntegerValue14 = (uiIntegerValue13 = (uiIntegerValue12 = uiIntegerValue47) + 1) + 1) + 1) + 1;
      uiTextMatrix01 = new string[3][];
      uiIntegerMatrix01 = new int[3][];
      uiIntegerMatrix02 = new int[3][];
      uiIntegerArray04 = new int[3];

      try {
         string var20 = "URL-TEMPLATE-GAME";
         if ((uiTextValue02 = midlet.getAppProperty(var20)) != null) {
            uiTextValue02 = uiTextValue02.trim();
            uiBooleanFlag03 = true;
            if (uiTextValue02.indexOf("ingameads.gameloft.com/redir") != -1) {
               uiBooleanFlag02 = true;
            }
         }
      } catch (System.Exception var5) {
      }

      for (int var16 = 0; var16 < uiIntegerValue47; var16++) {
         openMobileLibraryPage(var16, var8[var16], 7, "IGP-PROMOS", uiTextValue02);
      }

      try {
         string var21 = "URL-OPERATOR";
         string var17;
         if (isUiStringValid(var17 = midlet.getAppProperty(var21).trim(), 7)) {
            uiTextValue07 = var17;
         }

         var21 = "URL-PT";
         uiTextValue05 = midlet.getAppProperty(var21);
      } catch (System.Exception var4) {
      }

      if (!uiBooleanArray01[0]) {
         if (uiBooleanFlag03) {
            if (isUiStringValid(uiTextValue07, 7)) {
               openMobileLibraryPage(uiIntegerValue47, "PROMO", 7, "IGP-CATEGORIES", uiTextValue07 + (uiBooleanFlag02 ? "&ctg=XXXX" : ""));
            }
         } else {
            string var23 = "URL-PROMO";
            string var18;
            if ((var18 = midlet.getAppProperty(var23)) != null) {
               var23 = "URL-PROMO";
               if (isUiStringValid(midlet.getAppProperty(var23), 7)) {
                  uiTextArray07[uiIntegerValue12] = var18;
                  uiBooleanArray02[uiIntegerValue12] = true;
                  uiIntegerArray05[uiIntegerValue12] = 5;
               }
            }
         }
      }

      setMenuOptions(0, uiTextArray03, uiIntegerValue31, "IGP-WN");
      setMenuOptions(1, uiTextArray04, uiIntegerValue33, "IGP-BS");
      if (!uiBooleanArray01[0]) {
         if (uiBooleanFlag03) {
            string var25 = "IGP-CATEGORIES";
            if (isUiStringValid(buildMobileLibraryUrl(midlet.getAppProperty(var25), "OP", uiTextValue07), 7)) {
               if (isUiStringValid(uiTextValue07, 7)) {
                  uiBooleanArray02[uiIntegerValue15] = true;
               }

               uiTextArray07[uiIntegerValue15] = uiTextValue07;
            }
         } else if (isUiStringValid(uiTextValue07, 7)) {
            uiTextArray07[uiIntegerValue15] = uiTextValue07;
            uiBooleanArray02[uiIntegerValue15] = true;
         }

         if (uiBooleanArray02[uiIntegerValue15] && uiBooleanFlag02) {
            uiTextArray07[uiIntegerValue15] = uiTextArray07[uiIntegerValue15] + "&ctg=CCTL";
         }
      }

      if (uiBooleanArray01[0]) {
         try {
            if (isUiStringValid(uiTextValue07, 7)) {
               uiTextArray07[uiIntegerValue16] = uiTextValue07;
               uiBooleanArray02[uiIntegerValue16] = true;
            }
         } catch (System.Exception var3) {
         }
      }

      if ((uiIntegerValue65 = getSelectedMenuItem()) > 0) {
         uiBooleanFlag11 = true;
      }

      new StringBuffer().append("isAvailable = ").append(uiBooleanFlag11);
   }

   // $VF: renamed from: a () boolean
   public static bool isUiScreenActive() {
      return (uiBooleanFlag11 && getSelectedMenuItem() > 0 ? 0 : -1) != -1;
   }

   // $VF: renamed from: a (java.lang.String, int) void
   public static void openMobileLibraryLink(string var0, int var1) {
      new StringBuffer().append("enterIGP(loadingMsg = ").append(var0).append(", appLanguage = ").append(0).append(" (").append(uiTextArray02[0]).append(")");
      uiIntegerValue51 = 0;
      uiIntegerValue78 = 0;
      uiBooleanFlag15 = true;
      uiBooleanFlag16 = false;
      uiBooleanFlag17 = false;
      sbyte var6 = 0;
      if (var6 >= 0 && var6 < uiTextArray02.Length) {
         uiIntegerValue73 = var6 <= uiTextArray02.Length ? var6 : 0;
         uiTextValue06 = var0;
         uiIntegerValue53 = -1;
         uiIntegerValue50 = 0;
         uiIntegerValue52 = 0;
         uiIntegerValue58 = 0;
         uiIntegerValue59 = 0;
         uiIntegerArray03 = new int[10];
         uiBooleanFlag10 = true;
         uiFontReference01 = Font.getFont(0, 0, 8);
         uiByteValue01 = 0;
         uiByteValue02 = 0;
      }

      uiIntegerValue54 = 4 + uiIntegerValue48;
      uiBooleanFlag06 = true;
      uiBooleanFlag07 = true;
      RecordStore var5 = null;

      try {
         var5 = RecordStore.openRecordStore("igp19", false);
      } catch (System.Exception var4) {
         try {
            var5 = RecordStore.openRecordStore("igp19", true);
         } catch (System.Exception var3) {
         }
      }

      try {
         if (var5 != null) {
            var5.closeRecordStore();
         }
      } catch (System.Exception var2) {
      }

      uiIntegerValue52 = findMenuOption();
      if (uiBooleanFlag09) {
         displayCanvas.setCommandListener(gameUiController);
      }
   }

   // $VF: renamed from: a () void
   public static void initializeMenuState() {
      uiBooleanFlag17 = true;
      if (isMainMenuVisible()) {
         uiIntegerValue50 = 7;
         uiTextValue01 = uiTextValue08;
      }
   }

   // $VF: renamed from: b () boolean
   public static bool isMainMenuVisible() {
      int var0 = 0;

      for (int var1 = 0; var1 < uiTextArray02.Length; var1++) {
         if (uiTextArray02[var1].equals("SP")) {
            var0 = 1;
         }
      }

      if (var0 == 0) {
         return false;
      } else {
         try {
            string var4 = "IGP-CATEGORIES";
            string var8;
            if ((var8 = midlet.getAppProperty(var4)) == null || var8.indexOf("ZVIP") == -1) {
               string var7 = "URL-ZVIP";
               if ((uiTextValue08 = midlet.getAppProperty(var7)) == null) {
                  return false;
               }

               uiBooleanFlag12 = true;
               return true;
            }

            int var2;
            if ((var2 = (var0 = var8.indexOf("ZVIP") + "ZVIP".length() + 1) + "ZVIP".length()) >= var8.length()) {
               return false;
            }

            if (!var8.substring(var0, var2).equals("ZVIP")) {
               return false;
            }

            uiTextValue08 = uiTextValue07;
            if (uiBooleanFlag02) {
               if ((var0 = (uiTextValue08 = uiTextValue08 + "&ctg=XXXX").indexOf("XXXX")) >= 0) {
                  uiTextValue08 = uiTextValue08.substring(0, var0) + "ZVIP" + uiTextValue08.substring(var0 + "XXXX".length());
               }

               if (uiTextValue08.length() == 0) {
                  return false;
               }
            }
         } catch (System.Exception var3) {
            return false;
         }

         uiBooleanFlag12 = true;
         return true;
      }
   }

   // $VF: renamed from: a () int
   public static int getSelectedMenuItem() {
      int var0 = 0;

      for (int var1 = 0; var1 < uiBooleanArray02.Length; var1++) {
         if (uiBooleanArray02[var1]) {
            var0++;
         }
      }

      return var0;
   }

   // $VF: renamed from: b () int
   public static int findMenuOption() {
      for (int var0 = 0; var0 < uiBooleanArray02.Length; var0++) {
         if (uiBooleanArray02[var0]) {
            return var0;
         }
      }

      return -1;
   }

   // $VF: renamed from: d () void
   public static void showUiMessage() {
      if (uiTextValue05 != null) {
         int var0;
         if ((var0 = uiTextValue05.length()) <= 0) {
            uiTextValue05 = null;
         } else {
            bool var1 = false;
            int var2 = 0;
            int var3 = 0;
            int var4 = 0;
            int var5 = 1;
            string var6 = "";
            uiTextValue05 = uiTextValue05.toUpperCase();

            for (int var7 = 0; var7 < var0; var7++) {
               char var8;
               if (((var8 = uiTextValue05.charAt(var7)) < ' ' || var8 > 'z') && var8 != 130 && var8 != '\n') {
                  var6 = null;
                  break;
               }

               if (var8 == '\n') {
                  var1 = true;
               } else if (var7 < var0 - 1 && var8 == '\\' && (uiTextValue05.charAt(var7 + 1) == 'n' || uiTextValue05.charAt(var7 + 1) == 'N')) {
                  var1 = true;
                  var7++;
               }

               if (var1) {
                  if (var6.length() > 0) {
                     if (++var5 == 3) {
                        var6 = null;
                        break;
                     }

                     var6 = var6 + '\n';
                     var3 = 0;
                  } else {
                     var6 = var6 + "";
                  }

                  var1 = false;
               } else {
                  var6 = var6 + var8;
                  var3 += measureUiText(var8, uiIntegerValue42);
                  if (var8 == ' ') {
                     var2 = var6.length() - 1;
                     var4 = var3;
                  }
               }

               if (var3 >= uiIntegerValue74) {
                  if (var5 >= 3) {
                     var6 = null;
                     break;
                  }

                  if (var2 == var7) {
                     var6 = var6 + "\n";
                     var3 = 0;
                  } else {
                     if (var2 == 0) {
                        var6 = null;
                        break;
                     }

                     var6 = var6.substring(0, var2) + "\n" + var6.substring(var2 + 1, var6.length());
                     var3 -= var4;
                  }

                  var5++;
               }
            }

            if (var6 != null && !isUiStringValid(var6, 7)) {
               var6 = null;
            }

            uiTextValue05 = var6;
         }
      }
   }

   // $VF: renamed from: a (int) void
   public static void loadUiImageData(int var0) {
      object var1 = null;
      uiIntegerValue38 = 0;
      switch (var0) {
         case -1:
            uiImageReferenceArray02 = new Image[uiIntegerValue36];
            uiImageReferenceArray03 = new Image[uiIntegerValue48];
            (uiImageReferenceArrayArray01 = new Image[3][])[0] = new Image[uiTextArray03.Length];
            uiImageReferenceArrayArray01[1] = new Image[uiTextArray04.Length];
            uiImageReferenceArrayArray01[2] = new Image[uiTextArray05.Length];
            return;
         case 0:
            initializeUiController();
            return;
         case 1:
            var1 = getUiResourceBytes(var0);

            for (int var24 = 0; var24 < uiIntegerValue73; var24++) {
               var0 = readUiUnsignedByte((sbyte[])var1);
               uiIntegerValue38 += var0;
            }

            readUiUnsignedByte((sbyte[])var1);
            uiTextArray06 = new string[var0 = readUiUnsignedByte((sbyte[])var1)];
            sbyte[] var25 = new sbyte[var0];
            JSystem.arraycopy(var1, uiIntegerValue38, var25, 0, var0);
            uiIntegerValue38 += var0;
            readUiUnsignedByte((sbyte[])var1);
            int var31;
            uiShortArray01 = new short[var31 = ((sbyte[])var1)[uiIntegerValue38++] & 255 | (((sbyte[])var1)[uiIntegerValue38++] & 255) << 8];

            for (int var33 = 0; var33 < var31 - 1; var33++) {
               uiShortArray01[var33] = (short)((((sbyte[])var1)[uiIntegerValue38++] & 255) + ((((sbyte[])var1)[uiIntegerValue38++] & 255) << 8));
            }

            uiShortArray01[var31 - 1] = (short)var0;

            for (int var34 = 0; var34 < var31; var34++) {
               var0 = var34 == 0 ? 0 : uiShortArray01[var34 - 1] & '\uffff';
               int var35;
               if ((var35 = (uiShortArray01[var34] & '\uffff') - var0) != 0) {
                  try {
                     uiTextArray06[var34] = JString.New(var25, var0, var35, "UTF-8");
                  } catch (System.Exception var6) {
                  }
               }
            }

            if (uiBooleanFlag09) {
               uiCommandReference01 = new Command(getUiText(uiIntegerValue23), 4, 1);
               uiCommandReference02 = new Command(getUiText(uiIntegerValue24), 2, 1);
               bool var12 = true;
               var12 = true;
               if (uiCommandReference02 != null) {
                  displayCanvas.removeCommand(uiCommandReference02);
               }

               if (uiCommandReference01 != null) {
                  displayCanvas.removeCommand(uiCommandReference01);
               }

               displayCanvas.addCommand(uiCommandReference01);
               displayCanvas.addCommand(uiCommandReference02);
               return;
            }
            break;
         case 2:
            uiImageReferenceArray01 = new Image[3];
            sbyte[] var32 = new sbyte[((object[])(var1 = getUiResourceBytes(var0))).Length];
            JSystem.arraycopy(var1, 0, var32, 0, ((sbyte[])var1).Length);
            var0 = readUiUnsignedByte((sbyte[])var1);
            uiIntegerValue38 = 0;
            uiImageReferenceArray01[0] = createUiImage((sbyte[])var1);
            uiImageReferenceArray01[1] = decodeUiImage(var32, 2, var0, 1, 46319);
            uiImageReferenceArray01[2] = decodeUiImage(var32, 2, var0, 1, 16711680);
            int var5 = readUiUnsignedByte((sbyte[])var1);
            uiByteArray01 = new sbyte[(readUiUnsignedByte((sbyte[])var1) + 1) * (4 + uiIntegerValue86)];
            var0 = var5 / (6 + uiIntegerValue86);

            for (int var30 = 0; var30 < var0; var30++) {
               int var23 = readUiUnsignedByte((sbyte[])var1) * (4 + uiIntegerValue86);
               JSystem.arraycopy(var1, uiIntegerValue38, uiByteArray01, var23, 4 + uiIntegerValue86);
               uiIntegerValue38 = uiIntegerValue38 + 4 + uiIntegerValue86;
            }

            uiIntegerValue08 = (uiIntegerValue39 = uiByteArray01[32 * (4 + uiIntegerValue86) + uiIntegerValue43]) == 13 ? 0 : -1;
            showUiMessage();
            return;
         case 3:
            var1 = getUiResourceBytes(var0);

            for (int var29 = 0; var29 < uiIntegerValue36; var29++) {
               uiImageReferenceArray02[var29] = createUiImage((sbyte[])var1);
            }

            return;
         case 4:
            for (int var28 = 0; var28 < uiIntegerValue47; var28++) {
               uiImageReferenceArray03[var28] = createUiImage(getUiResourceBytes(var0));
            }

            return;
         case 5:
            sbyte[] var26 = decodeUiImageBytes((sbyte[])(var1 = getUiResourceBytes(var0)));
            int var27 = var26.Length;
            sbyte var21 = 0;
            uiImageReferenceArray03[uiIntegerValue12] = Image.createImage(var26, var21, var27);

            for (int var22 = 0; var22 < uiIntegerValue73; var22++) {
               createUiImage((sbyte[])var1);
            }

            uiImageReference01 = createUiImage((sbyte[])var1);
            return;
         case 6:
         case 7:
            int var2 = (var0 == 6 ? uiTextArray03.Length : uiTextArray04.Length) - 1;
            int var3 = var0 == 6 ? 0 : 1;
            var1 = getUiResourceBytes(var0);

            int var4;
            for (var4 = 0; var4 < var2; var4++) {
               uiImageReferenceArrayArray01[var3][var4] = createUiImage((sbyte[])var1);
            }

            uiImageReferenceArrayArray01[var3][var4] = uiImageReferenceArray02[11];
            uiImageReferenceArray03[var0 == 6 ? uiIntegerValue13 : uiIntegerValue14] = uiImageReferenceArray02[10];
            return;
         case 8:
            var1 = getUiResourceBytes(var0);
            uiImageReferenceArray03[uiIntegerValue15] = createUiImage((sbyte[])var1);
            if ((uiTextArray02[uiIntegerValue73].equals("JP") || uiTextArray02[uiIntegerValue73].equals("DOCOMO")) && uiImageReference02 == null) {
               uiImageReference02 = createUiImage((sbyte[])var1);
               return;
            }
            break;
         default:
            if (var0 == uiIntegerArray01[0]) {
               var1 = getUiResourceBytes(var0);
               uiImageReferenceArray03[uiIntegerValue16] = createUiImage((sbyte[])var1);
               return;
            }

            if (var0 == uiIntegerValue09) {
               resetUiState();
            } break;
      }
   }

   // $VF: renamed from: a (boolean) void
   public static void releaseUiImages(bool var0) {
      for (int var1 = 0; var1 < uiImageReferenceArrayArray01.Length; var1++) {
         if (uiImageReferenceArrayArray01[var1] != null) {
            for (int var2 = 0; var2 < uiImageReferenceArrayArray01[var1].Length; var2++) {
               uiImageReferenceArrayArray01[var1][var2] = null;
            }
         }
      }

      for (int var3 = 0; var3 < uiImageReferenceArray03.Length; var3++) {
         uiImageReferenceArray03[var3] = null;
      }

      uiImageReference01 = null;
      uiImageReference02 = null;
      if (var0) {
         resetUiState();
         uiByteArray01 = null;
         uiImageReferenceArray01 = null;

         for (int var4 = 0; var4 < uiIntegerValue36; var4++) {
            uiImageReferenceArray02[var4] = null;
         }

         uiImageReferenceArray02 = null;
         uiShortArray01 = null;
         uiTextArray06 = null;
         uiIntegerArray03 = null;
         uiTextValue06 = null;
         uiImageReferenceArray03 = null;
         uiImageReferenceArrayArray01 = null;
         uiImageReference03 = null;
         uiImageReference04 = null;
         uiImageReference05 = null;
         uiImageReference06 = null;
         uiImageReference07 = null;
         uiImageReference08 = null;
         uiImageReference09 = null;
         uiImageReference10 = null;
         uiImageReference11 = null;

         for (int var5 = 0; var5 < uiImageReferenceArray04.Length; var5++) {
            uiImageReferenceArray04[var5] = null;
         }
      }

      JSystem.gc();
   }

   // $VF: renamed from: a (int) boolean
   public static bool shouldShowMobileLibrary(int var0) {
      if (uiBooleanFlag17) {
         return !uiBooleanFlag12 ? true : uiIntegerValue50 == 4;
      } else if (!uiBooleanFlag11) {
         return true;
      } else {
         if (uiBooleanFlag15) {
            uiBooleanFlag15 = false;
         } else {
            uiIntegerValue51 = var0;
         }

         switch (uiIntegerValue50) {
            case 0:
               if (uiIntegerValue53 >= uiIntegerValue54) {
                  loadUiAssets();
                  uiIntegerValue50 = 1;
                  updateMenuTransition();
               } else {
                  loadUiImageData(uiIntegerValue53);
               }

               uiIntegerValue53++;
               break;
            case 1:
               switch (uiIntegerValue51) {
                  case 21:
                     if (uiBooleanFlag14 && uiIntegerValue59 > 0 && --uiIntegerValue59 - uiIntegerValue58 < 0) {
                        uiIntegerValue58--;
                     }

                     return false;
                  case 22:
                  case 28:
                  case 29:
                  case 30:
                  case 31:
                  default:
                     return false;
                  case 23:
                     if (uiIntegerValue65 <= 1) {
                        return false;
                     }

                     if (uiIntegerValue52 == 0) {
                        uiIntegerValue52 = uiIntegerValue48 - 1;
                     } else {
                        uiIntegerValue52--;
                     }

                     while (!uiBooleanArray02[uiIntegerValue52]) {
                        if (uiIntegerValue52 == 0) {
                           uiIntegerValue52 = uiIntegerValue48 - 1;
                        } else {
                           uiIntegerValue52--;
                        }
                     }

                     uiBooleanFlag04 = true; goto case 24;
                  case 24:
                     if (uiIntegerValue65 > 1) {
                        if (!uiBooleanFlag04) {
                           if (uiIntegerValue52 == uiIntegerValue48 - 1) {
                              uiIntegerValue52 = 0;
                           } else {
                              uiIntegerValue52++;
                           }

                           while (!uiBooleanArray02[uiIntegerValue52]) {
                              if (uiIntegerValue52 == uiIntegerValue48 - 1) {
                                 uiIntegerValue52 = 0;
                              } else {
                                 uiIntegerValue52++;
                              }
                           }

                           uiBooleanFlag05 = true;
                        }

                        uiIntegerValue58 = 0;
                        uiIntegerValue59 = 0;
                        updateMenuTransition();
                     }

                     return false;
                  case 25:
                  case 27:
                     uiIntegerValue50 = 6;
                     return false;
                  case 26:
                     uiIntegerValue50 = 4;
                     return false;
                  case 32:
                     if (uiBooleanFlag14 && uiIntegerValue59 < uiIntegerValue56 - 1 && ++uiIntegerValue59 - uiIntegerValue58 >= uiIntegerValue57) {
                        uiIntegerValue58++;
                     }

                     return false;
               } goto case 2;
            case 2:
               releaseUiImages(false);
               var0 = uiIntegerValue52;
               loadUiImageData(
                  uiIntegerValue53 = uiIntegerArray05[var0] == 4
                     ? uiIntegerArray05[var0]
                     : (
                        var0 == uiIntegerValue12
                           ? 5
                           : (var0 == uiIntegerValue13 ? 6 : (var0 == uiIntegerValue14 ? 7 : (var0 == uiIntegerValue15 ? 8 : (var0 == uiIntegerValue16 ? uiIntegerArray01[0] : -1))))
                     )
               );
               loadUiAssets();
               uiIntegerValue50 = 1;
               break;
            case 3:
               switch (uiIntegerValue51) {
                  case 25:
                     uiTextValue01 = null;
                     return false;
                  case 26:
                     uiIntegerValue50 = 1;
                     uiTextValue03 = null;
                     return false;
                  default:
                     return false;
               } goto case 4;
            case 4:
               releaseUiImages(true);
               if (uiBooleanFlag09) {
                  displayCanvas.setCommandListener(uiCommandListenerReference01);
                  if (uiCommandReference02 != null) {
                     displayCanvas.removeCommand(uiCommandReference02);
                     uiCommandReference02 = null;
                  }

                  if (uiCommandReference01 != null) {
                     displayCanvas.removeCommand(uiCommandReference01);
                     uiCommandReference01 = null;
                  }
               }

               uiBooleanFlag10 = false;
               return true;
            case 5:
            default:
               break;
            case 6:
               string var2 = uiTextArray07[uiIntegerValue52];
               if (uiBooleanFlag14) {
                  var2 = uiTextMatrix01[uiIntegerValue55][uiIntegerValue59];
               }

               if (var2 != null && var2.length() > 0) {
                  if (uiBooleanFlag02) {
                     int var1;
                     if ((var1 = var2.indexOf("&lg=")) == -1) {
                        var2 = var2 + "&lg=" + uiTextArray02[uiIntegerValue73];
                     } else {
                        var2 = var2.substring(0, var1) + "&lg=" + uiTextArray02[uiIntegerValue73] + var2.substring(var1 + "&lg=".length() + 2);
                     }
                  }

                  uiTextValue01 = var2;
               } break;
         }

         return false;
      }
   }

   // $VF: renamed from: a (int, int) void
   public static void drawMenuSelection(int var0, int var1) {
      if ((var0 = fitImageToBounds(var0, var1)) != 0) {
         uiIntegerValue51 = var0;
         uiBooleanFlag15 = true;
      }

      uiIntegerValue78 = 0;
      uiBooleanFlag16 = false;
   }

   // $VF: renamed from: b (int, int) void
   public static void drawMenuEntry(int var0, int var1) {
      if ((var0 = fitImageToBounds(var0, var1)) != 0) {
         uiIntegerValue78 = var0;
      }
   }

   // $VF: renamed from: c (int, int) void
   public static void initializeMenuTransition(int var0, int var1) {
      uiIntegerValue51 = 0;
      uiIntegerValue78 = 0;
      uiBooleanFlag16 = false;
      drawMenuEntry(var0, var1);
   }

   // $VF: renamed from: b (int, int) int
   public static int fitImageToBounds(int var0, int var1) {
      if (var0 < 1 || var1 < 1) {
         return 0;
      } else if (uiIntegerValue50 != 0 && uiBooleanFlag10) {
         if (uiBooleanFlag14) {
            int var2 = uiIntegerValue75 * 5 / 100;
            var2 = var2 + 1 + uiImageReferenceArray02[5].getWidth();
            int var3 = uiIntegerValue74 / 100;
            int var4 = var2 + uiImageReferenceArrayArray01[uiIntegerValue55][0].getWidth() + var3;
            var3 *= 3;
            bool var5 = var0 > uiIntegerValue61 + var3 && var0 < uiIntegerValue61 + uiIntegerValue63 - var3;

            for (int var7 = uiIntegerValue58; var7 < uiIntegerValue58 + uiIntegerValue57; var7++) {
               if (var5 && var1 > uiIntegerValue83 + uiIntegerValue64 * (var7 - uiIntegerValue58) && var1 < uiIntegerValue83 + uiIntegerValue64 * (var7 - uiIntegerValue58) + uiIntegerValue64) {
                  if (uiIntegerValue59 == var7) {
                     return 25;
                  }

                  uiIntegerValue59 = var7;
                  return 0;
               }
            }

            if (var5) {
               var5 = var0 > uiImageReferenceArray02[12].getWidth() * 3 / 2 + 2 && var0 < uiIntegerValue74 - (uiImageReferenceArray02[12].getWidth() * 3 / 2 - 2);
            }

            if (uiIntegerValue57 < uiIntegerValue56 && var5) {
               if (uiIntegerValue59 > 0 && var1 > uiIntegerValue84 - (var4 - 2) / 2 && var1 < uiIntegerValue84 + (var4 - 2)) {
                  return 21;
               }

               if (uiIntegerValue59 < uiIntegerValue56 - 1 && var1 > uiIntegerValue85 - (var4 - 2) / 2 && var1 < uiIntegerValue85 + (var4 - 2)) {
                  return 32;
               }
            }
         } else {
            if (var0 > uiIntegerValue71 && var0 < uiIntegerValue71 + uiIntegerValue69 && var1 > uiIntegerValue72 && var1 < uiIntegerValue72 + uiIntegerValue70) {
               return 27;
            }

            if (var0 > uiIntegerValue79 && var0 < uiIntegerValue79 + uiIntegerValue81 && var1 > uiIntegerValue80 && var1 < uiIntegerValue80 + uiIntegerValue82) {
               return 27;
            }
         }

         int var8 = uiIntegerValue74 - uiImageReferenceArray02[7].getWidth();
         int var10 = (uiIntegerValue75 >> 1) - uiImageReferenceArray02[7].getHeight();
         int var11 = uiImageReferenceArray02[7].getHeight() << 1;
         int var12 = uiImageReferenceArray02[7].getWidth() << 1;
         if (var1 > var10 && var1 < var10 + var11) {
            if (var0 > 0 && var0 < var12 + 0) {
               return 23;
            }

            if (var0 > var8 - var12 / 2 && var0 < var8 + var12) {
               return 24;
            }
         }

         if (uiBooleanFlag09) {
            return 0;
         } else {
            if (var1 >= uiIntegerValue75 - (uiImageReferenceArray02[13].getHeight() << 1) && var1 <= uiIntegerValue75) {
               if (var0 > uiIntegerValue03 && var0 < (uiImageReferenceArray02[13].getWidth() << 1) + uiIntegerValue03) {
                  return 0;
               }

               if (var0 > uiIntegerValue74 - uiIntegerValue04 - (uiImageReferenceArray02[13].getWidth() << 1) && var0 < uiIntegerValue74 - uiIntegerValue04) {
                  return 26;
               }
            }

            return 0;
         }
      } else {
         return 0;
      }
   }

   // $VF: renamed from: e () void
   public static void updateMenuTransition() {
      uiIntegerValue67 = uiIntegerValue52;
      uiIntegerValue59 = 0;
      uiIntegerValue56 = 0;
      uiIntegerValue58 = 0;
      uiBooleanFlag14 = false;
      uiBooleanFlag13 = uiTextArray07[uiIntegerValue52] != null && uiTextArray07[uiIntegerValue52].length() > 0 && uiTextArray07[uiIntegerValue52].compareTo("DEL") != 0;
      if (uiIntegerValue52 == uiIntegerValue13) {
         uiIntegerValue55 = 0;
         uiBooleanFlag14 = true;
         uiBooleanFlag13 = false;
      }

      if (uiIntegerValue52 == uiIntegerValue14) {
         uiIntegerValue55 = 1;
         uiBooleanFlag14 = true;
         uiBooleanFlag13 = false;
      }

      if (uiIntegerValue52 == uiIntegerValue15 || uiIntegerValue52 == uiIntegerValue16) {
         uiBooleanFlag13 = true;
      }

      uiIntegerValue68 = uiIntegerValue25;
      if (uiIntegerArray05[uiIntegerValue52] == 4) {
         uiIntegerValue68 = uiIntegerValue26;
      }

      if (uiBooleanFlag14) {
         uiIntegerValue56 = uiIntegerArray04[uiIntegerValue55];
      }
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics) void
   public static void renderUiOverlay(Graphics var0) {
      if (uiBooleanFlag11 || uiBooleanFlag17) {
         if (uiTextValue01 != null) {
            if (uiTextValue01 != null && uiTextValue01.length() > 0) {
               string var9 = uiTextValue01;
               uiTextValue01 = null;
               new StringBuffer().append("urlPlatformRequest = ").append(var9);

               try {
                  midlet.platformRequest(var9);
                  Thread.sleep(200L);
               } catch (System.Exception var7) {
               }

               if (!uiBooleanFlag17) {
                  uiIntegerValue50 = 1;
               } else {
                  uiIntegerValue50 = 4;
               }

               midlet.notifyDestroyed();
            }
         } else if (!uiBooleanFlag17) {
            drawUiProgressBar(var0, 0, 0, uiIntegerValue74, uiIntegerValue75);
            drawUiProgressBar(var0, 0, 0, uiIntegerValue74, uiIntegerValue75);
            switch (uiIntegerValue50) {
               case 0:
                  var0.setColor(0);
                  var0.fillRect(0, 0, uiIntegerValue74, uiIntegerValue75);
                  int var10002 = uiIntegerValue74 * 3 / 4;
                  int var5 = uiIntegerValue54;
                  int var4 = uiIntegerValue53;
                  int var3 = var10002;
                  int var11 = uiIntegerValue77;
                  if (var4 > var5) {
                     var4 = var5;
                  }

                  int var6 = (uiIntegerValue74 - var3) / 2;
                  var0.setColor(16777215);
                  var0.drawRect(var6, var11, var3, 6);
                  var3 = (var3 - 2 - 2) * var4 / var5 + 1;
                  var0.setColor(16711680);
                  var0.fillRect(var6 + 1 + 1, var11 + 1 + 1, var3, 3);
                  if (uiTextValue06 != null && !uiTextValue06.trim().equals("")) {
                     var0.setColor(16777215);
                     var0.setFont(uiFontReference01);
                     var0.drawString(uiTextValue06, uiIntegerValue76, uiIntegerValue77 - 5, 33);
                     return;
                  }
                  break;
               case 1:
                  initializeUiResources(var0);
                  if (JSystem.currentTimeMillis() % 1000L <= 500L && uiIntegerValue78 != 27) {
                     break;
                  }

                  if (uiBooleanFlag13) {
                     var0.setColor(uiIntegerValue02);
                     if (uiBooleanArray01[0]) {
                        var0.setColor(16744192);
                     }

                     if (uiIntegerValue78 == 27) {
                        var0.setColor(14588928);
                        var0.drawRect(uiIntegerValue71 - 2, uiIntegerValue72 - 2, uiIntegerValue69 + 3, uiIntegerValue70 + 4);
                        var0.drawRect(uiIntegerValue71 - 1, uiIntegerValue72 - 1, uiIntegerValue69 + 1, uiIntegerValue70 + 2);
                        var0.setColor(5767410);
                     }

                     uiIntegerValue44 = 0;
                     var0.fillRect(uiIntegerValue71, uiIntegerValue72, uiIntegerValue69, uiIntegerValue70 + 1);
                     drawUiTextById(uiIntegerValue68, var0, uiIntegerValue76, uiIntegerValue72 + (uiIntegerValue70 >> 1), 3);
                  }

                  return;
               case 2:
                  int var8 = uiFontReference01.getHeight();
                  var0.setColor(255);
                  var0.fillRect(0, uiIntegerValue77 - var8 - 5, uiIntegerValue74, var8 << 1);
                  int var10 = uiIntegerValue44;
                  uiIntegerValue44 = 0;
                  drawUiTextById(uiIntegerValue35, var0, uiIntegerValue76, uiIntegerValue77 - var8, 65);
                  uiIntegerValue44 = var10;
                  return;
               case 3:
                  initializeUiResources(var0);
                  int var1 = uiIntegerValue75 * 40 / 100;
                  int var2 = uiIntegerValue74;
                  drawUiPattern(var0, 0, var1, var2, uiIntegerValue75 - (var1 << 1), -220209185);
                  var0.setColor(39423);
                  var0.drawRect(0, var1, var2 - 1, uiIntegerValue75 - (var1 << 1) - 1);
                  var0.drawRect(1, var1 + 1, var2 - 3, uiIntegerValue75 - (var1 << 1) - 3);
                  drawUiTextById(uiIntegerValue29, var0, uiIntegerValue76, uiIntegerValue77, 3);
                  renderUiMenu(var0); goto case 4;
               case 4:
               default:
                  break;
               case 5:
                  return;
            }
         }
      }
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, int, int, int, int, int) void
   public static void drawUiPattern(Graphics var0, int var1, int var2, int var3, int var4, int var5) {
      int[] var7 = new int[var3 * var4];

      for (int var6 = 0; var6 < var7.Length; var6++) {
         var7[var6] = var5;
      }

      var0.drawRGB(var7, 0, var3, 0, var2, var3, var4, true);
   }

   // $VF: renamed from: b (javax.microedition.lcdui.Graphics) void
   public static void initializeUiResources(Graphics var0) {
      uiBooleanFlag01 = true;
      drawUiTextById(uiIntegerValue68, null, 0, 0, 3);
      int var2 = measureUiText(32, uiIntegerValue42) / 2;
      int var3 = measureUiText(32, uiIntegerValue43) / 3;
      uiIntegerValue69 = uiIntegerValue46 + var2;
      uiIntegerValue70 = uiIntegerValue45 + var3;
      if ((uiIntegerValue45 + uiIntegerValue70) % 2 != 0) {
         uiIntegerValue70++;
      }

      uiIntegerValue71 = uiIntegerValue76 - uiIntegerValue69 / 2;
      if (uiIntegerArray05[uiIntegerValue52] == 4 || uiIntegerValue52 == uiIntegerValue16) {
         uiIntegerValue72 = uiIntegerValue06 - uiIntegerValue70 / 2;
      } else if (uiIntegerValue52 == uiIntegerValue12 || uiIntegerValue52 == uiIntegerValue15) {
         uiIntegerValue72 = uiIntegerValue07 - uiIntegerValue70 / 2;
      }

      if (uiBooleanArray01[0] && uiIntegerValue52 == uiIntegerValue16) {
         uiIntegerValue72 = uiIntegerValue75 * 80 / 100;
      }

      var0.setColor(16777215);
      if (uiBooleanArray01[0]) {
         var0.setColor(0);
      }

      var0.fillRect(0, 0, uiIntegerValue74, uiIntegerValue75);
      if (uiBooleanFlag14) {
         Graphics var18 = var0;
         int var28 = uiIntegerValue05;
         if (uiIntegerValue75 > 128) {
            drawUiImage(var0, uiImageReferenceArray03[uiIntegerValue52], uiIntegerValue76, uiIntegerValue05, 17);
            var28 += uiImageReferenceArray03[uiIntegerValue52].getHeight();
         }

         uiIntegerValue44 = 2;
         drawUiTextById(uiIntegerValue67, var0, uiIntegerValue76, var28, 17);
         int var5 = JMath.max(2 * uiIntegerValue39, uiImageReferenceArrayArray01[uiIntegerValue55][uiIntegerMatrix01[uiIntegerValue55][0]].getHeight());
         uiBooleanFlag01 = true;
         drawUiTextById(uiIntegerValue67, null, 0, 0, 0);
         int var6 = var28 + uiIntegerValue45;
         int var4 = var3 = uiIntegerValue75 * 7 / 100;
         int var7 = uiIntegerValue75 / 2 - var6 << 1;
         int var1 = uiIntegerValue75 - uiImageReferenceArray02[12].getHeight() - 2 - var6;
         uiIntegerValue57 = uiIntegerValue56;
         if (var7 / var5 >= uiIntegerValue56) {
            var6 = var6 + var7 / 2 - uiIntegerValue57 * var5 / 2;
         } else {
            if (var1 / var5 < uiIntegerValue56) {
               uiIntegerValue57 = (var1 - var4 * 2) / var5;
            }

            var6 = var6 + var1 / 2 - uiIntegerValue57 * var5 / 2;
         }

         if (uiIntegerValue57 < uiIntegerValue56) {
            int var58 = 16777215;
            if (uiIntegerValue58 > 0) {
               if (uiIntegerValue78 == 21) {
                  var58 = 46319;
               }

               drawUiPanel(var0, uiIntegerValue76, var6 - var4, var3, var58, true, false);
               uiIntegerValue84 = var6 - var4;
            }

            if (uiIntegerValue58 + uiIntegerValue57 < uiIntegerValue56) {
               if (uiIntegerValue78 == 32) {
                  var58 = 46319;
               }

               drawUiPanel(var0, uiIntegerValue76, var6 + uiIntegerValue57 * var5 + var4, var3, var58, true, true);
               uiIntegerValue85 = var6 + uiIntegerValue57 * var5;
            }
         }

         int var11 = var6 + var5 / 2 + 1;
         uiIntegerValue63 = uiIntegerValue74 - 3 * uiImageReferenceArray02[5].getWidth();
         if (uiIntegerValue74 > uiIntegerValue75) {
            uiIntegerValue63 = uiIntegerValue63 - uiImageReferenceArray02[5].getWidth() / 2;
         }

         uiIntegerValue61 = (uiIntegerValue74 >> 1) - (uiIntegerValue63 >> 1);
         var7 = uiIntegerValue74 / 100;
         var4 = (var3 = uiIntegerValue61 + var7) + uiImageReferenceArrayArray01[uiIntegerValue55][0].getWidth() + var7;

         for (int var60 = uiIntegerValue58; var60 < uiIntegerValue58 + uiIntegerValue57; var60++) {
            int var8 = uiIntegerMatrix01[uiIntegerValue55][var60];
            drawUiImage(var18, uiImageReferenceArrayArray01[uiIntegerValue55][var8], var3, var11, 6);
            if (uiIntegerValue55 == 2 || var8 == uiIntegerMatrix02[uiIntegerValue55].Length - 1) {
               uiIntegerValue44 = 2;
            }

            drawWrappedUiText(getUiText(uiIntegerMatrix02[uiIntegerValue55][var8]), var18, var4, var11, 6);
            var11 += var5;
         }

         uiIntegerValue60 = uiIntegerValue59 - uiIntegerValue58;
         uiIntegerValue62 = var6 + var5 * uiIntegerValue60;
         uiIntegerValue64 = var5;
         uiIntegerValue83 = var6;
         var18.setColor(16545540);
         var18.drawRect(uiIntegerValue61, uiIntegerValue62, uiIntegerValue63, uiIntegerValue64);
      } else if (uiIntegerValue52 == uiIntegerValue16) {
         int var12 = uiIntegerValue74 / 2;
         var2 = (uiIntegerValue75 << 3) / 100;
         drawUiImage(var0, uiImageReferenceArray03[uiIntegerValue16], var12, var2, 17);
         uiBooleanFlag01 = true;
         drawUiTextById(uiIntegerValue17, null, 0, 0, 0);
         uiImageReferenceArray03[uiIntegerValue52].getHeight();
         if (uiBooleanArray01[0]) {
            uiIntegerValue44 = 0;
         }

         drawUiText(getUiText(uiIntegerValue18), var0, uiIntegerValue74 - (uiImageReferenceArray02[4].getWidth() + 8 << 1), uiIntegerValue74 / 2, uiIntegerValue75 * 60 / 100, 3);
      } else if (uiIntegerValue52 == uiIntegerValue12) {
         bool var13 = uiIntegerValue75 >= 128;
         bool var20 = uiTextValue05 != null && uiTextValue05.length() > 0;
         var3 = var13 ? uiImageReferenceArray02[10].getHeight() : 0;
         int var38 = uiIntegerValue05 + var3 * 3 / 5;
         if (uiImageReferenceArray03[uiIntegerValue12].getWidth() > 220) {
            var0.setColor(13421772);
            var0.fillRect(uiIntegerValue76 + 20, var38, 3, 54);
            var38 += 54;
         } else if (uiImageReferenceArray03[uiIntegerValue12].getWidth() > 140) {
            var0.setColor(14145495);
            var0.fillRect(uiIntegerValue76 + 14, var38, 2, 37);
            var38 += 37;
         } else if (uiImageReferenceArray03[uiIntegerValue12].getWidth() > 100) {
            var0.setColor(14465464);
            var0.fillRect(uiIntegerValue76 + 11, var38, 1, 26);
            var38 += 26;
         }

         int var39 = var38 + uiImageReferenceArray03[uiIntegerValue12].getHeight();
         drawUiImage(var0, uiImageReferenceArray03[uiIntegerValue12], uiIntegerValue76, var39, 33);
         drawUiImage(var0, uiImageReference01, uiIntegerValue76 + (uiImageReferenceArray03[uiIntegerValue12].getWidth() >> 1) + 1, var39, 40);
         uiIntegerValue81 = uiImageReferenceArray03[uiIntegerValue12].getWidth();
         uiIntegerValue82 = uiImageReferenceArray03[uiIntegerValue12].getHeight();
         uiIntegerValue79 = uiIntegerValue76 - 1 - uiIntegerValue81 / 2;
         uiIntegerValue80 = var39 - uiImageReferenceArray03[uiIntegerValue12].getHeight();
         if (var13) {
            drawUiImage(var0, uiImageReferenceArray02[10], uiIntegerValue76, uiIntegerValue05, 17);
         }

         if (var20) {
            uiIntegerValue44 = 2;
            int var45 = uiIntegerValue72 - var39;
            sbyte var53 = 3;
            if (uiIntegerValue39 << 1 > var45) {
               var38 = var39 + uiIntegerValue39 / 3;
               var53 = 17;
            } else {
               var38 = var39 + var45 / 2;
            }

            drawUiText(uiTextValue05, var0, uiIntegerValue74, uiIntegerValue76, var38, var53);
         }
      } else if (uiIntegerValue52 == uiIntegerValue15) {
         bool var14 = uiIntegerValue75 >= 128;
         var2 = uiImageReferenceArray03[uiIntegerValue52].getWidth() * 70 / 100;
         var3 = uiImageReferenceArray03[uiIntegerValue52].getHeight() >> 1;
         int var41 = (uiIntegerValue74 >> 1) - (var2 >> 1);
         int var46 = (uiIntegerValue75 >> 1) - (var3 >> 1);
         bool var61 = false;
         int var42 = 15812117;
         int var33 = 16437549;
         int var54 = var3;
         int var47 = var2;
         int var43 = var46;
         var3 = var41;
         Graphics var22 = var0;
         if (var46 + var3 > uiIntegerValue75) {
            var54 = uiIntegerValue75 - var46;
         }

         if (var41 + var2 > uiIntegerValue74) {
            var47 = uiIntegerValue74 - var41;
         }

         for (int var62 = var46; var62 < var43 + var54; var62++) {
            int var64 = 250 + (var62 - var43) * -9 / var54;
            int var9 = 209 + (var62 - var43) * -139 / var54;
            int var10 = 45 + (var62 - var43) * -24 / var54;
            var22.setColor(var64, var9, var10);
            var22.drawLine(var3, var62, var3 + var47, var62);
         }

         int var65 = uiIntegerValue75 / 2;
         drawUiImage(var0, uiImageReferenceArray03[uiIntegerValue52], uiIntegerValue76, var65, 3);
         uiIntegerValue81 = (uiIntegerValue81 = uiImageReferenceArray03[uiIntegerValue52].getWidth()) - 2 * uiImageReferenceArray02[5].getWidth();
         uiIntegerValue82 = uiImageReferenceArray03[uiIntegerValue52].getHeight();
         uiIntegerValue79 = uiIntegerValue76 - uiIntegerValue81 / 2;
         uiIntegerValue80 = var65 - uiIntegerValue82 / 2;
         if (var14) {
            drawUiImage(var0, uiImageReferenceArray02[10], uiIntegerValue76, uiIntegerValue05, 17);
         }

         if (uiImageReference02 == null) {
            uiBooleanFlag01 = true;
            drawUiText(getUiText(uiIntegerValue67), null, 0, 0, 0, 0);
            var65 -= uiIntegerValue45 / 2;
            var2 = uiIntegerValue44;
            uiIntegerValue44 = 0;
            drawUiText(getUiText(uiIntegerValue67), var0, uiImageReferenceArray03[uiIntegerValue52].getWidth() / 2, uiIntegerValue76, var65, 17);
            uiIntegerValue44 = var2;
         } else {
            drawUiImage(var0, uiImageReference02, uiIntegerValue76, uiIntegerValue75 / 2, 3);
         }
      } else {
         uiBooleanFlag01 = true;
         drawUiText(getUiText(uiIntegerValue67), var0, 0, 0, 0, 0);
         int var15 = uiImageReferenceArray03[uiIntegerValue52].getHeight();
         int var24 = 0;
         int var35 = 0;
         bool var44 = false;
         if (uiIntegerValue46 > uiIntegerValue74 - (uiImageReferenceArray02[12].getWidth() << 1)) {
            var24 = uiImageReferenceArray02[12].getHeight();
         } else if (uiIntegerValue46 > uiIntegerValue74 - (uiImageReferenceArray02[9].getWidth() << 1)) {
            var24 = uiImageReferenceArray02[9].getHeight();
         }

         int var48 = var15 + uiIntegerValue45 + var24;
         int var55 = JMath.max(0, uiIntegerValue75 - var48);
         int var63 = uiIntegerValue74 <= 176 ? 2 : 0;
         if (uiIntegerValue45 > (uiIntegerValue39 << 1) + var63 && var55 / 3 > (uiIntegerValue39 + var63) / 2) {
            var48 = var15 + (uiIntegerValue39 << 1) + var24;
            var55 = JMath.max(0, uiIntegerValue75 - var48);
            var44 = true;
         }

         int var67 = var55 / 3;
         if (var24 > 0) {
            var2 = uiIntegerValue75 - uiImageReferenceArray02[12].getHeight();
            var48 = var15 + uiIntegerValue45;
            int var56 = JMath.max(0, uiIntegerValue75 - var48);
            if (uiIntegerValue45 > (uiIntegerValue39 << 1) + var63 && var56 / 3 > uiIntegerValue45 - (uiIntegerValue39 + var63 << 1)) {
               var48 = var15 + (uiIntegerValue39 << 1);
               var56 = JMath.max(0, uiIntegerValue75 - var48);
               var44 = true;
            }

            var15 = var56 / 3;
            if (var15 * 2 + uiIntegerValue45 + uiImageReferenceArray03[uiIntegerValue52].getHeight() < var2) {
               var67 = var15;
            }
         }

         drawUiImage(var0, uiImageReferenceArray03[uiIntegerValue52], uiIntegerValue76, var67, 17);
         uiIntegerValue81 = (uiIntegerValue81 = uiImageReferenceArray03[uiIntegerValue52].getWidth()) - 2 * uiImageReferenceArray02[5].getWidth();
         uiIntegerValue82 = uiImageReferenceArray03[uiIntegerValue52].getHeight();
         uiIntegerValue79 = uiIntegerValue76 - uiIntegerValue81 / 2;
         uiIntegerValue80 = var67;
         var2 = var67 + var67 + uiImageReferenceArray03[uiIntegerValue52].getHeight();
         if (uiBooleanArray01[0]) {
            uiIntegerValue44 = 0;
         }

         if (var44) {
            var35 = -(uiIntegerValue39 / 2);
         }

         drawUiText(getUiText(uiIntegerValue67), var0, 0, uiIntegerValue76, var2 + var35, 17);
      }

      renderUiMenu(var0);
      if (uiIntegerValue65 > 1) {
         int var17 = JMath.abs((int)(JSystem.currentTimeMillis() / 80L % 8L) - 4);
         sbyte var27 = 5;
         sbyte var36 = 7;
         if (uiBooleanFlag04 || uiIntegerValue78 == 23) {
            var27 = 4;
            uiIntegerValue49++;
         }

         if (uiBooleanFlag05 || uiIntegerValue78 == 24) {
            var36 = 6;
            uiIntegerValue49++;
         }

         int var57 = var17 + 1 + uiImageReferenceArray02[var27].getWidth();
         uiImageReferenceArray02[var27].getWidth();
         drawUiImage(var0, uiImageReferenceArray02[var27], var57, uiIntegerValue77, 10);
         drawUiImage(var0, uiImageReferenceArray02[var36], uiIntegerValue74 - var57, uiIntegerValue77, 6);
         if (uiIntegerValue49 > 4) {
            uiBooleanFlag04 = false;
            uiBooleanFlag05 = false;
            uiIntegerValue49 = 0;
         }
      }
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, int, int, int, int, boolean, boolean) void
   public static void drawUiPanel(Graphics var0, int var1, int var2, int var3, int var4, bool var5, bool var6) {
      int var5i = var6 ? -1 : 1;
      if (var3 % 2 == 0) {
         var3--;
      }

      var0.setColor(46319);
      drawUiTriangle(var0, var1, var2, var1 - (var3 >> 1), var2 + var5i * (var3 >> 1), var1 + (var3 >> 1), var2 + var5i * (var3 >> 1));
      var0.setColor(var4);
      drawUiTriangle(var0, var1, var2 + var5i, var1 - (var3 >> 1) + 2, var2 + var5i * (var3 >> 1) - var5i, var1 + (var3 >> 1) - 2, var2 + var5i * (var3 >> 1) - var5i);
   }

   // $VF: renamed from: c (javax.microedition.lcdui.Graphics) void
   public static void renderUiMenu(Graphics var0) {
      int var1 = uiIntegerValue75 - 2;
      int var2 = uiIntegerValue03;
      int var3 = uiIntegerValue74 - uiIntegerValue04;
      if (!uiBooleanFlag09) {
         Image var4 = uiImageReferenceArray02[12];
         Image var5 = uiImageReferenceArray02[12];
         if (uiIntegerValue78 == 26) {
            var5 = uiImageReferenceArray02[13];
         }

         uiByteValue02 = (sbyte)(uiByteValue02 | 2);
         uiByteValue01 = (sbyte)(uiByteValue01 | 2);
         if ((uiByteValue02 & 1) != 0) {
            drawUiImage(var0, var4, var2, var1, 36);
         }

         if ((uiByteValue02 & 2) != 0) {
            drawUiImage(var0, var5, var3, var1, 40);
         }

         int var7 = var2 + (uiImageReferenceArray02[12].getWidth() / 2 - uiImageReferenceArray02[9].getWidth() / 2);
         int var8 = var3 + -uiImageReferenceArray02[12].getWidth() / 2 + uiImageReferenceArray02[8].getWidth() / 2;
         int var6 = var1 + -uiImageReferenceArray02[12].getHeight() / 2 + uiImageReferenceArray02[9].getHeight() / 2;
         if (((uiByteValue01 = (sbyte)(uiByteValue01 | 2)) & 1) != 0) {
            drawUiImage(var0, uiImageReferenceArray02[9], var7, var6, 36);
         }

         if ((uiByteValue01 & 2) != 0) {
            drawUiImage(var0, uiImageReferenceArray02[8], var8, var6, 40);
         }
      }
   }

   // $VF: renamed from: a (byte[], int, int, int, int) javax.microedition.lcdui.Image
   public static Image decodeUiImage(sbyte[] var0, int var1, int var2, int var3, int var4) {
      int var10 = 0;

      for (int var12 = 2; var10 == 0 && var12 < var2 + 2; var12++) {
         if ((var0[var12] & 255) == 80 && (var0[var12 + 1] & 255) == 76 && (var0[var12 + 2] & 255) == 84 && (var0[var12 + 3] & 255) == 69) {
            var10 = var12;
         }
      }

      var3 = (var0[var10 - 4] << 24 & unchecked((int)0xFF000000)) + (var0[var10 - 3] << 16 & 0xFF0000) + (var0[var10 - 2] << 8 & 0xFF00) + (var0[var10 - 1] & 255);
      var0[var10 + 4 + 3] = (sbyte)(var4 >> 16 & 0xFF);
      var0[var10 + 4 + 3 + 1] = (sbyte)(var4 >> 8 & 0xFF);
      var0[var10 + 4 + 3 + 2] = (sbyte)var4;
      sbyte[] var14 = new sbyte[var3 + 4];
      JSystem.arraycopy(var0, var10, var14, 0, var3 + 4);
      long[] var5 = new long[256];

      for (int var6 = 0; var6 < 256; var6++) {
         long var7 = (long)var6;

         for (int var9 = 0; var9 < 8; var9++) {
            if ((var7 & 1L) == 1L) {
               var7 = 3988292384L ^ var7 >> 1;
            } else {
               var7 >>= 1;
            }
         }

         var5[var6] = var7;
      }

      long var16 = 4294967295L;

      for (int var15 = 0; var15 < var14.Length; var15++) {
         var16 = var5[(int)(var16 ^ (long)var14[var15]) & 0xFF] ^ var16 >> 8;
      }

      var16 ^= 4294967295L;
      var0[var10 + 4 + var3] = (sbyte)((int)((var16 & -16777216L) >> 24));
      var0[var10 + 4 + var3 + 1] = (sbyte)((int)((var16 & 16711680L) >> 16));
      var0[var10 + 4 + var3 + 2] = (sbyte)((int)((var16 & 65280L) >> 8));
      var0[var10 + 4 + var3 + 3] = (sbyte)((int)(var16 & 255L));
      JSystem.gc();
      sbyte var11 = 2;
      return Image.createImage(var0, var11, var2);
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, int, int, int, int, int, int) void
   public static void drawUiTriangle(Graphics var0, int var1, int var2, int var3, int var4, int var5, int var6) {
      var0.fillTriangle(var1, var2, var3, var4, var5, var6);
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, javax.microedition.lcdui.Image, int, int, int) void
   public static void drawUiImage(Graphics var0, Image var1, int var2, int var3, int var4) {
      var0.drawImage(var1, var2, var3, var4);
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, int, int, int, int) void
   public static void drawUiProgressBar(Graphics var0, int var1, int var2, int var3, int var4) {
      var1 = JMath.max(var1, 0);
      var2 = JMath.max(var2, 0);
      var3 = JMath.min(var3, uiIntegerValue74);
      var4 = JMath.min(var4, uiIntegerValue75);
      var0.setClip(var1, var2, var3, var4);
   }

   // $VF: renamed from: run () void
   public void run() {
   }

   // $VF: renamed from: d () boolean
   public static bool isUiTransitionActive() {
      if (uiBooleanFlag11) {
         if (uiBooleanFlag07) {
            return uiBooleanFlag06;
         }

         try {
            RecordStore.openRecordStore("igp19", false).closeRecordStore();
            uiBooleanFlag06 = true;
         } catch (System.Exception var1) {
         }

         uiBooleanFlag07 = true;
      }

      return uiBooleanFlag06;
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, javax.microedition.lcdui.Image, int, int, int) boolean
   public static bool drawUiImageTransition(Graphics var0, Image var1, int var2, int var3, int var4) {
      if (isUiTransitionActive()) {
         return false;
      } else if (uiBooleanFlag11 && var1 != null && var0 != null) {
         if (JSystem.currentTimeMillis() - uiLongValue01 > 800L) {
            uiBooleanFlag08 = !uiBooleanFlag08;
            uiLongValue01 = JSystem.currentTimeMillis();
         }

         if (uiBooleanFlag08) {
            drawUiImage(var0, var1, var2, var3, 20);
            return true;
         } else {
            return true;
         }
      } else {
         return false;
      }
   }

   public void commandAction(Command var1, Displayable var2) {
      if (uiBooleanFlag09) {
         if (var1 == uiCommandReference01) {
            shouldShowMobileLibrary(25);
            return;
         }

         if (var1 == uiCommandReference02) {
            shouldShowMobileLibrary(26);
         }
      }
   }

   // $VF: renamed from: a (java.lang.String) java.io.InputStream
   public static InputStream openUiResourceStream(string var0) {
      return "a".getClass().getResourceAsStream(var0);
   }

   // $VF: renamed from: f () void
   public static void loadUiAssets() {
      int var0 = uiIntegerValue74;

      try {
         int var1 = uiIntegerValue74 - 3 * uiImageReferenceArray02[5].getWidth();
         if (uiIntegerValue74 > uiIntegerValue75) {
            var1 -= uiImageReferenceArray02[5].getWidth() / 2;
         }

         int var2 = (uiIntegerValue74 >> 1) - (var1 >> 1);
         int var3 = uiIntegerValue74 / 100;
         int var4;
         var3 = (var4 = var2 + var3) + uiImageReferenceArrayArray01[uiIntegerValue55][0].getWidth() + var3;
         var0 = var2 + var1 - var3;
      } catch (System.Exception var11) {
      }

      try {
         for (int var13 = 0; var13 < uiTextArray06.Length; var13++) {
            if (uiTextArray06[var13] != null
               && (
                  var13 == uiIntegerValue19
                     || var13 == uiIntegerValue21
                     || var13 == uiIntegerValue25
                     || var13 == uiIntegerValue18
                     || var13 < uiIntegerValue17
                     || var13 >= uiIntegerValue30 && var13 < uiIntegerValue32 + uiTextArray04.Length
               )) {
               int var14;
               sbyte var20;
                {
                  var14 = uiIntegerValue74;
                  var20 = 3;
                  int var10000;
                  if ((uiTextArray03.Length <= 1 || var13 < uiIntegerValue30 || var13 >= uiIntegerValue30 + uiTextArray03.Length)
                     && (uiTextArray04.Length <= 1 || var13 < uiIntegerValue32 || var13 >= uiIntegerValue32 + uiTextArray04.Length)
                     && var13 != uiIntegerValue18) {
                     if (var13 != uiIntegerValue19 && var13 != uiIntegerValue21 && var13 != uiIntegerValue25) {
                        if (var13 != uiIntegerValue17 - 1) {
                           goto label164_brk;
                        }

                        var10000 = uiImageReferenceArray03[uiIntegerValue15] != null ? uiImageReferenceArray03[uiIntegerValue15].getWidth() >> 1 : uiIntegerValue74;
                     } else {
                        var20 = 2;
                        var10000 = uiIntegerValue74 - (uiImageReferenceArray02[12].getWidth() << 1) - 8;
                     }
                  } else {
                     var10000 = var0;
                  }

                  var14 = var10000;
               } label164_brk:;

               string[] var26 = uiTextArray06;
               string var10002 = uiTextArray06[var13];
               bool var15 = true;
               sbyte var23 = var20;
               string var16 = var10002;
               string var5 = "";
               int var6 = 0;
               int var7 = 0;
               string var17 = var16;
               string var8 = "";
               char[] var9 = var16.toCharArray();

               for (int var10 = 0; var10 < var17.length(); var10++) {
                  if (var9[var10] == '，' || var9[var10] == '！' || var9[var10] == '？' || var9[var10] == '；' || var9[var10] == '：') {
                     var8 = var8 + var9[var10];
                     var8 = var8 + '|';
                  } else if (var9[var10] == '\b') {
                     var8 = var8 + '|';
                  } else if (var9[var10] == '\n') {
                     var8 = var8 + ' ';
                  } else {
                     var8 = var8 + var9[var10];
                  }
               }

               if (uiTextArray02[uiIntegerValue73].equals("ZH-TW") && var8.indexOf(124) == -1 && var8.indexOf(32) == -1 && var8.length() > 5) {
                  var8 = var8.substring(0, var8.length() >> 1) + "|" + var8.substring(var8.length() >> 1, var8.length());
               }

               string var18 = var8;
               short[] var22 = loadUiFontMetrics(var8, var14, true);

               for (int var25 = 0; var25 < var22[0]; var25++) {
                  if (var6 != 0) {
                     var7++;
                     var5 = var5.trim();
                     if (var7 >= var23) {
                        break;
                     }

                     var5 = var5 + "\n";
                  }

                  var5 = var5 + var18.substring(var6, var22[(var25 << 1) + 1]);
                  var6 = var22[(var25 << 1) + 1];
                  if (var18.length() != var6 && var18.charAt(var22[(var25 << 1) + 1]) == '\n') {
                     var6++;
                  }
               }

               var26[var13] = var5;
               uiTextArray06[var13] = urlEncodeUiText(uiTextArray06[var13]);
            }
         }
      } catch (System.Exception var12) {
      }
   }

   // $VF: renamed from: a (java.lang.String, int, boolean) short[]
   public static short[] loadUiFontMetrics(string var0, int var1, bool var2) {
      int var3 = var0.length();
      short var4 = 0;
      short var5 = 1;
      short var6 = 0;
      bool var8 = false;
      short var9 = 0;

      for (int var10 = 0; var10 < var3; var10++) {
         char var7;
         if ((var7 = var0.charAt(var10)) == ' ') {
            var4 = (short)(var4 + measureUiText(var7, uiIntegerValue42));
            short var18 = var6;
            var6 = (short)var10;
            var8 = true;
            var9 = 0;
            if (var6 == var3 - 2 && var4 + measureUiText(var0.charAt(var6 + 1), uiIntegerValue42) > var1) {
               var6 = var18;
               uiShortArray02[var5++] = (short)(var18 + 1);
               uiShortArray02[var5++] = (short)var4;
               var4 = 0;
            }

            if (var4 > var1) {
               var8 = false;

               for (int var11 = var6; var11 >= 0 && var0.charAt(var11) == ' '; var4 = (short)(var4 - measureUiText(32, uiIntegerValue42))) {
                  var11--;
               }

               int var19;
               for (var19 = 0; var6 < var3 && var0.charAt(var6) == ' '; var19++) {
                  var6++;
               }

               if (var19 == 1 && var10 == var3 - 2) {
                  var6 = var18;
               } else {
                  var10 = --var6;
               }

               uiShortArray02[var5++] = (short)(var6 + 1);
               uiShortArray02[var5++] = (short)var4;
               var4 = 0;
            }
         } else if (var7 == '|') {
            if (!var2) {
               break;
            }

            var4 = (short)(var4 + measureUiText(var7, uiIntegerValue42));
            var6 = (short)var10;
            var8 = true;
            var9 = 0;
            if (var4 > var1) {
               var8 = false;

               for (int var20 = var6; var20 >= 0 && var0.charAt(var20) == ' '; var4 = (short)(var4 - measureUiText(32, uiIntegerValue42))) {
                  var20--;
               }

               while (var6 < var3 && var0.charAt(var6) == ' ') {
                  var6++;
               }

               var10 = --var6;
               uiShortArray02[var5++] = (short)(var6 + 1);
               uiShortArray02[var5++] = (short)var4;
               var4 = 0;
            }
         } else if (var7 == '\n') {
            uiShortArray02[var5++] = (short)var10;
            uiShortArray02[var5++] = var4;
            var4 = 0;
            var9 = 0;
         } else {
            int var21 = measureUiText(var7, uiIntegerValue42) + uiIntegerValue08;
            var9 = (short)(var9 + var21);
            if ((var4 = (short)(var4 + var21)) > var1 && var8) {
               var8 = false;

               for (int var22 = var6; var22 >= 0 && var0.charAt(var22) == ' '; var4 = (short)(var4 - measureUiText(32, uiIntegerValue43))) {
                  var22--;
               }

               uiShortArray02[var5++] = (short)(var6 + 1);
               uiShortArray02[var5++] = (short)(var4 - var9);
               var4 = 0;
               var10 = var6;
            }
         }
      }

      if (var4 != 0) {
         uiShortArray02[var5++] = (short)var3;
         uiShortArray02[var5++] = var4;
      }

      uiShortArray02[0] = (short)(var5 / 2);
      return uiShortArray02;
   }

   // $VF: renamed from: a (java.lang.String) java.lang.String
   public static string urlEncodeUiText(string var0) {
      string var1 = "";
      char[] var2 = var0.toCharArray();

      for (int var3 = 0; var3 < var0.length(); var3++) {
         if (var2[var3] != '|') {
            var1 = var1 + var2[var3];
         }
      }

      return var1;
   }
}
}
