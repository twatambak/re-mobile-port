import java.io.InputStream;
import java.util.Hashtable;
import javax.microedition.lcdui.Canvas;
import javax.microedition.lcdui.Command;
import javax.microedition.lcdui.CommandListener;
import javax.microedition.lcdui.Displayable;
import javax.microedition.lcdui.Font;
import javax.microedition.lcdui.Graphics;
import javax.microedition.lcdui.Image;
import javax.microedition.midlet.MIDlet;
import javax.microedition.rms.RecordStore;

// $VF: renamed from: m
public final class class_17 implements Runnable, CommandListener {
   // $VF: renamed from: a java.lang.String
   private static String field_157 = "2.1";
   // $VF: renamed from: b java.lang.String
   private static String field_158 = "IGP-Signature=" + field_157;
   // $VF: renamed from: c java.lang.String
   private static String field_159 = "";
   // $VF: renamed from: a int
   private static int field_160 = 0;
   // $VF: renamed from: d java.lang.String
   private static String field_161;
   // $VF: renamed from: a javax.microedition.lcdui.Font
   private static Font field_162;
   // $VF: renamed from: b int
   private static int field_163 = 13568256;
   // $VF: renamed from: c int
   private static int field_164 = 2;
   // $VF: renamed from: d int
   private static int field_165 = 2;
   // $VF: renamed from: e int
   private static int field_166;
   // $VF: renamed from: f int
   private static int field_167;
   // $VF: renamed from: g int
   private static int field_168;
   // $VF: renamed from: h int
   private static int field_169 = 0;
   // $VF: renamed from: a boolean[]
   private static boolean[] field_170 = new boolean[1];
   // $VF: renamed from: a int[]
   private static int[] field_171 = new int[1];
   // $VF: renamed from: i int
   private static int field_172;
   // $VF: renamed from: j int
   private static int field_173 = -1;
   // $VF: renamed from: k int
   private static int field_174 = 8;
   // $VF: renamed from: l int
   private static int field_175;
   // $VF: renamed from: m int
   private static int field_176;
   // $VF: renamed from: n int
   private static int field_177;
   // $VF: renamed from: o int
   private static int field_178;
   // $VF: renamed from: p int
   private static int field_179;
   // $VF: renamed from: q int
   private static int field_180;
   // $VF: renamed from: r int
   private static int field_181;
   // $VF: renamed from: s int
   private static int field_182;
   // $VF: renamed from: t int
   private static int field_183;
   // $VF: renamed from: u int
   private static int field_184;
   // $VF: renamed from: v int
   private static int field_185;
   // $VF: renamed from: w int
   private static int field_186;
   // $VF: renamed from: x int
   private static int field_187;
   // $VF: renamed from: y int
   private static int field_188;
   // $VF: renamed from: z int
   private static int field_189;
   // $VF: renamed from: A int
   private static int field_190;
   // $VF: renamed from: B int
   private static int field_191;
   // $VF: renamed from: C int
   private static int field_192;
   // $VF: renamed from: D int
   private static int field_193;
   // $VF: renamed from: E int
   private static int field_194;
   // $VF: renamed from: F int
   private static int field_195;
   // $VF: renamed from: G int
   private static int field_196;
   // $VF: renamed from: H int
   private static int field_197;
   // $VF: renamed from: I int
   private static int field_198;
   // $VF: renamed from: J int
   private static int field_199 = 14;
   // $VF: renamed from: K int
   private static int field_200;
   // $VF: renamed from: b int[]
   private static int[] field_201;
   // $VF: renamed from: a byte[][]
   private static byte[][] field_202;
   // $VF: renamed from: L int
   private static int field_203;
   // $VF: renamed from: a byte[]
   private static byte[] field_204;
   // $VF: renamed from: M int
   private static int field_205;
   // $VF: renamed from: N int
   private static int field_206 = 0;
   // $VF: renamed from: O int
   private static int field_207 = 1;
   // $VF: renamed from: P int
   private static int field_208 = 2;
   // $VF: renamed from: Q int
   private static int field_209 = 3;
   // $VF: renamed from: a javax.microedition.lcdui.Image[]
   private static Image[] field_210;
   // $VF: renamed from: R int
   private static int field_211;
   // $VF: renamed from: c int[]
   private static int[] field_212;
   // $VF: renamed from: S int
   private static int field_213;
   // $VF: renamed from: T int
   private static int field_214;
   // $VF: renamed from: a boolean
   private static boolean field_215;
   // $VF: renamed from: a java.lang.String[]
   private static final String[] field_216 = new String[]{"URL-WN", "URL-BS", "URL"};
   // $VF: renamed from: e java.lang.String
   private static String field_217;
   // $VF: renamed from: b boolean
   private static boolean field_218;
   // $VF: renamed from: c boolean
   private static boolean field_219;
   // $VF: renamed from: b java.lang.String[]
   private static String[] field_220 = new String[0];
   // $VF: renamed from: c java.lang.String[]
   private static String[] field_221;
   // $VF: renamed from: d java.lang.String[]
   private static String[] field_222;
   // $VF: renamed from: e java.lang.String[]
   private static String[] field_223;
   // $VF: renamed from: U int
   private static int field_224;
   // $VF: renamed from: V int
   private static int field_225;
   // $VF: renamed from: f java.lang.String[]
   private static String[] field_226;
   // $VF: renamed from: a short[]
   private static short[] field_227;
   // $VF: renamed from: W int
   private static int field_228;
   // $VF: renamed from: d boolean
   private static boolean field_229;
   // $VF: renamed from: e boolean
   private static boolean field_230;
   // $VF: renamed from: f boolean
   private static boolean field_231 = false;
   // $VF: renamed from: g boolean
   private static boolean field_232 = false;
   // $VF: renamed from: a long
   private static long field_233 = 0L;
   // $VF: renamed from: h boolean
   private static boolean field_234 = true;
   // $VF: renamed from: a javax.microedition.midlet.MIDlet
   private static MIDlet field_235;
   // $VF: renamed from: a javax.microedition.lcdui.Canvas
   private static Canvas field_236;
   // $VF: renamed from: f java.lang.String
   private static String field_237;
   // $VF: renamed from: i boolean
   private static boolean field_238 = false;
   // $VF: renamed from: a javax.microedition.lcdui.CommandListener
   private static CommandListener field_239 = null;
   // $VF: renamed from: a m
   private static class_17 field_240 = null;
   // $VF: renamed from: j boolean
   private static boolean field_241 = false;
   // $VF: renamed from: g java.lang.String
   private static String field_242 = null;
   // $VF: renamed from: k boolean
   private static boolean field_243 = false;
   // $VF: renamed from: l boolean
   private static boolean field_244 = false;
   // $VF: renamed from: X int
   private static int field_245;
   // $VF: renamed from: Y int
   private static int field_246;
   // $VF: renamed from: Z int
   private static int field_247;
   // $VF: renamed from: aa int
   private static int field_248;
   // $VF: renamed from: ab int
   private static int field_249;
   // $VF: renamed from: b javax.microedition.lcdui.Image[]
   private static Image[] field_250;
   // $VF: renamed from: c javax.microedition.lcdui.Image[]
   private static Image[] field_251;
   // $VF: renamed from: a javax.microedition.lcdui.Image
   private static Image field_252;
   // $VF: renamed from: b javax.microedition.lcdui.Image
   private static Image field_253;
   // $VF: renamed from: c javax.microedition.lcdui.Image
   private static Image field_254;
   // $VF: renamed from: d javax.microedition.lcdui.Image
   private static Image field_255;
   // $VF: renamed from: e javax.microedition.lcdui.Image
   private static Image field_256;
   // $VF: renamed from: f javax.microedition.lcdui.Image
   private static Image field_257;
   // $VF: renamed from: g javax.microedition.lcdui.Image
   private static Image field_258;
   // $VF: renamed from: h javax.microedition.lcdui.Image
   private static Image field_259;
   // $VF: renamed from: i javax.microedition.lcdui.Image
   private static Image field_260;
   // $VF: renamed from: j javax.microedition.lcdui.Image
   private static Image field_261;
   // $VF: renamed from: d javax.microedition.lcdui.Image[]
   private static Image[] field_262;
   // $VF: renamed from: k javax.microedition.lcdui.Image
   private static Image field_263;
   // $VF: renamed from: a javax.microedition.lcdui.Image[][]
   private static Image[][] field_264;
   // $VF: renamed from: a java.lang.String[][]
   private static String[][] field_265;
   // $VF: renamed from: a int[][]
   private static int[][] field_266;
   // $VF: renamed from: b int[][]
   private static int[][] field_267;
   // $VF: renamed from: d int[]
   private static int[] field_268;
   // $VF: renamed from: ac int
   private static int field_269;
   // $VF: renamed from: ad int
   private static int field_270;
   // $VF: renamed from: ae int
   private static int field_271;
   // $VF: renamed from: af int
   private static int field_272;
   // $VF: renamed from: ag int
   private static int field_273;
   // $VF: renamed from: ah int
   private static int field_274;
   // $VF: renamed from: ai int
   private static int field_275;
   // $VF: renamed from: aj int
   private static int field_276;
   // $VF: renamed from: ak int
   private static int field_277;
   // $VF: renamed from: al int
   private static int field_278;
   // $VF: renamed from: am int
   private static int field_279 = -1;
   // $VF: renamed from: g java.lang.String[]
   private static String[] field_280;
   // $VF: renamed from: e int[]
   private static int[] field_281;
   // $VF: renamed from: b boolean[]
   private static boolean[] field_282;
   // $VF: renamed from: an int
   private static int field_283 = 0;
   // $VF: renamed from: ao int
   private static int field_284;
   // $VF: renamed from: m boolean
   private static boolean field_285;
   // $VF: renamed from: a byte
   private static byte field_286;
   // $VF: renamed from: b byte
   private static byte field_287;
   // $VF: renamed from: n boolean
   private static boolean field_288;
   // $VF: renamed from: ap int
   private static int field_289;
   // $VF: renamed from: aq int
   private static int field_290;
   // $VF: renamed from: ar int
   private static int field_291;
   // $VF: renamed from: as int
   private static int field_292;
   // $VF: renamed from: at int
   private static int field_293;
   // $VF: renamed from: au int
   private static int field_294;
   // $VF: renamed from: h java.lang.String
   private static String field_295;
   // $VF: renamed from: i java.lang.String
   private static String field_296;
   // $VF: renamed from: j java.lang.String
   private static String field_297 = "";
   // $VF: renamed from: k java.lang.String
   private static String field_298;
   // $VF: renamed from: av int
   private static int field_299;
   // $VF: renamed from: aw int
   private static int field_300;
   // $VF: renamed from: ax int
   private static int field_301;
   // $VF: renamed from: ay int
   private static int field_302;
   // $VF: renamed from: a javax.microedition.lcdui.Command
   private static Command field_303;
   // $VF: renamed from: b javax.microedition.lcdui.Command
   private static Command field_304;
   // $VF: renamed from: az int
   private static int field_305 = 0;
   // $VF: renamed from: o boolean
   private static boolean field_306 = false;
   // $VF: renamed from: p boolean
   private static boolean field_307 = false;
   // $VF: renamed from: aA int
   private static int field_308 = -1;
   // $VF: renamed from: aB int
   private static int field_309 = -1;
   // $VF: renamed from: aC int
   private static int field_310 = -1;
   // $VF: renamed from: aD int
   private static int field_311 = -1;
   // $VF: renamed from: aE int
   private static int field_312;
   // $VF: renamed from: aF int
   private static int field_313;
   // $VF: renamed from: aG int
   private static int field_314;
   // $VF: renamed from: a java.util.Hashtable
   private static Hashtable field_315 = new Hashtable();
   // $VF: renamed from: q boolean
   private static boolean field_316 = false;
   // $VF: renamed from: aH int
   private static int field_317 = 0;
   // $VF: renamed from: b short[]
   private static short[] field_318 = new short[50];

   // $VF: renamed from: c () boolean
   private static boolean method_29() {
      method_30();

      try {
         InputStream var0;
         field_201 = new int[field_200 = (field_200 = (var0 = method_73("/dataIGP")).read() & 0xFF) + ((var0.read() & 0xFF) << 8)];

         for (int var1 = 0; var1 < field_200; var1++) {
            field_201[var1] = var0.read() & 0xFF;
            field_201[var1] = field_201[var1] + ((var0.read() & 0xFF) << 8);
            field_201[var1] = field_201[var1] + ((var0.read() & 0xFF) << 16);
            field_201[var1] = field_201[var1] + ((var0.read() & 0xFF) << 24);
         }

         var0.close();
         return true;
      } catch (Exception var2) {
         return false;
      }
   }

   // $VF: renamed from: b () void
   private static void method_30() {
      field_201 = null;
      field_202 = null;
      field_200 = 0;
      System.gc();
   }

   // $VF: renamed from: a (int) byte[]
   private static byte[] method_31(int var0) {
      if (var0 >= 0 && var0 < field_200 - 1) {
         int var1;
         if ((var1 = field_201[var0 + 1] - field_201[var0]) == 0) {
            return null;
         } else {
            byte[] var2 = null;

            try {
               InputStream var3;
               (var3 = method_73("/dataIGP")).skip((long)(2 + 4 * field_200 + field_201[var0]));
               int var5 = (var2 = new byte[var1]).length;

               while (var5 > 0) {
                  var5 -= var3.read(var2);
               }

               var3.close();
            } catch (Exception var4) {
            }

            return var2;
         }
      } else {
         return null;
      }
   }

   // $VF: renamed from: a (byte[]) int
   private static int method_32(byte[] var0) {
      return (var0[field_203++] & 0xFF) + ((var0[field_203++] & 0xFF) << 8);
   }

   // $VF: renamed from: a (byte[]) byte[]
   private static byte[] method_33(byte[] var0) {
      int var1;
      byte[] var2 = new byte[var1 = method_32(var0)];
      System.arraycopy(var0, field_203, var2, 0, var1);
      field_203 += var1;
      return var2;
   }

   // $VF: renamed from: a (byte[]) javax.microedition.lcdui.Image
   private static Image method_34(byte[] var0) {
      byte[] var1;
      return Image.createImage(var1 = method_33(var0), 0, var1.length);
   }

   // $VF: renamed from: a (int) java.lang.String
   private static String method_35(int var0) {
      return "" + field_226[var0];
   }

   // $VF: renamed from: a (int, int) int
   private static int method_36(int var0, int var1) {
      if (field_317 != 0) {
         if (var1 != 0 && var1 != field_207) {
            return field_204[var0 * 6 + var1] & 0xFF;
         } else {
            int var2 = field_204[var0 * 6 + var1] & 255;
            var0 = field_204[var0 * 6 + var1 + 1] & 255;
            int var4;
            return (var4 = 0 | (var0 & 0xFF) << 8) | var2 & 0xFF;
         }
      } else {
         return field_204[(var0 << 2) + var1] & 0xFF;
      }
   }

   // $VF: renamed from: a (int, javax.microedition.lcdui.Graphics, int, int, int) void
   private static void method_37(int var0, Graphics var1, int var2, int var3, int var4) {
      method_38(method_35(var0), var1, field_299, var2, var3, var4);
   }

   // $VF: renamed from: a (java.lang.String, javax.microedition.lcdui.Graphics, int, int, int, int) void
   private static void method_38(String var0, Graphics var1, int var2, int var3, int var4, int var5) {
      method_39(var0, var1, var3, var4, var5);
   }

   // $VF: renamed from: a (java.lang.String, javax.microedition.lcdui.Graphics, int, int, int) void
   private static void method_39(String var0, Graphics var1, int var2, int var3, int var4) {
      String var21 = var0;
      field_212[0] = 0;
      field_214 = 0;
      int var5 = 0;
      int var10 = var0.length();
      byte var11 = 0;
      if (field_299 <= 176 && field_281[field_247] == 4) {
         var11 += 2;
      }

      for (int var7 = 0; var7 < var10; var7++) {
         char var6;
         if ((var6 = var21.charAt(var7)) != '\n' || var5 >= 10) {
            if (var6 != '\\' || var21.charAt(++var7) != 'N') {
               if (var6 != 0 && var6 != 1) {
                  field_212[var5] = field_212[var5] + method_36(var6, field_208) + field_169;
               }
               continue;
            }
         }

         field_212[var5] = field_212[var5] - field_169;
         if (field_212[var5] > field_214) {
            field_214 = field_212[var5];
         }

         var5++;
         field_212[var5] = 0;
      }

      field_212[var5] = field_212[var5] - field_169;
      if (field_212[var5] > field_214) {
         field_214 = field_212[var5];
      }

      field_213 = (var5 + 1) * field_205 + var5 * (var11 + 0);
      if (field_215) {
         field_215 = false;
      } else {
         int var22 = var3 + (var11 + 0) * var5 / 2;
         int var23 = 0;
         if ((var4 & 32) != 0) {
            var22 -= field_213;
         } else if ((var4 & 2) != 0) {
            var22 -= field_213 >> 1;
         }

         int var12 = var2;
         boolean var8 = true;
         boolean var9 = false;
         method_70(var1, 0, 0, field_299, field_300);

         for (int var25 = 0; var25 < var10; var25++) {
            char var24 = var21.charAt(var25);
            if (var8) {
               var12 = var2;
               if ((var4 & 8) != 0) {
                  var12 = var2 - field_212[var23];
               } else if ((var4 & 1) != 0) {
                  var12 = var2 - (field_212[var23] >> 1);
               }

               var8 = false;
            }

            label82:
            if (var24 != '\n' || var23 >= 10) {
               if (var24 == '\\') {
                  if (var21.charAt(++var25) == 'N') {
                     break label82;
                  }
               }

               if (var9) {
                  var9 = false;
                  char var13;
                  if ((var13 = var21.charAt(var25 - 2)) == ' ') {
                     var12 -= method_36(var13, field_208) + field_169 >> 1;
                  }

                  if (var24 == ' ') {
                     var12 += method_36(var24, field_208) + field_169 >> 1;
                     continue;
                  }
               }

               method_70(var1, var12, var22, method_36(var24, field_208), method_36(var24, field_209));
               Image var10001 = field_210[field_211];
               int var10002 = method_36(var24, 0);
               int var10003 = method_36(var24, field_207);
               int var10004 = method_36(var24, field_208);
               int var18 = method_36(var24, field_209);
               int var17 = var10004;
               int var16 = var10003;
               int var15 = var10002;
               Image var14 = var10001;
               var1.drawRegion(var14, var15, var16, var17, var18, 0, var12, var22, 20);
               var12 += method_36(var24, field_208) + field_169;
               continue;
            }

            var22 += field_205 + var11 - 1;
            var23++;
            var8 = true;
            var9 = true;
         }

         method_70(var1, 0, 0, field_299, field_300);
         field_211 = 1;
      }
   }

   // $VF: renamed from: a (javax.microedition.midlet.MIDlet, javax.microedition.lcdui.Canvas, int, int) void
   public static void method_40(MIDlet var0, Canvas var1, int var2, int var3) {
      Object var4 = null;
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
         .append((String)null)
         .append(")");
      field_299 = var2;
      field_300 = var3;
      field_301 = field_299 >> 1;
      field_302 = field_300 >> 1;
      field_166 = field_300 * 5 / 100;
      field_167 = field_300 / 2;
      field_168 = field_300 * 93 / 100;
      if (2 > field_299) {
         field_164 = 2;
      }

      if (2 > field_299) {
         field_165 = 2;
      }

      if (field_235 == null && var1 != null) {
         field_235 = var0;
         field_236 = var1;
         method_46();
         String var6 = field_158;
         new StringBuffer().append(var6).append("");
      }
   }

   // $VF: renamed from: a (java.lang.String, int) boolean
   private static boolean method_41(String var0, int var1) {
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
   private static String method_42(String var0, String var1, String var2) {
      String var3 = "";

      try {
         if (var2 != null && var0 != null && var1 != null) {
            int var4 = var0.indexOf(var1 + "=");
            String var7 = var2.trim();
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
      } catch (Exception var5) {
         var3 = "";
      }

      return var3;
   }

   // $VF: renamed from: a (int, java.lang.String, int, java.lang.String, java.lang.String) void
   private static void method_43(int var0, String var1, int var2, String var3, String var4) {
      try {
         if (field_219) {
            var1 = method_42(field_235.getAppProperty(var3), var1, var4);
         } else {
            String var7 = "URL-" + var1;
            var1 = field_235.getAppProperty(var7);
         }

         if (method_41(var1, 7) && (var1.toUpperCase().compareTo("NO") != 0 || var1.toUpperCase().compareTo("0") != 0)) {
            field_282[var0] = true;
            field_280[var0] = var1;
            if (field_282[var0] && var0 != field_175) {
               field_283++;
               field_281[var0] = 4;
               if (field_218) {
                  field_280[var0] = field_280[var0] + "&ctg=SC" + (field_283 < 10 ? "0" : "") + field_283;
               }
            }
         }
      } catch (Exception var5) {
      }
   }

   // $VF: renamed from: a (int, java.lang.String[], int, java.lang.String) void
   private static void method_44(int var0, String[] var1, int var2, String var3) {
      int var4 = var1.length;
      field_265[var0] = new String[var4];
      field_266[var0] = new int[var4];
      field_267[var0] = new int[var4];
      int var5 = 0;
      if (!field_170[0]) {
         String var6 = "";
         if (field_219) {
            try {
               var3 = field_235.getAppProperty(var3);
               if (var0 != 2) {
                  var6 = field_217;
               } else if (field_297.length() > 0 && field_218) {
                  var6 = field_297 + "&ctg=XXXX";
               } else if (field_297.length() > 0) {
                  var6 = field_297;
               }
            } catch (Exception var10) {
            }
         }

         for (int var7 = 0; var7 < var1.length; var7++) {
            try {
               String var8 = "";
               if (var0 != 2 && var7 == var4 - 1) {
                  if (!field_219) {
                     var8 = field_216[var0];
                     var8 = field_235.getAppProperty(var8);
                  } else if (field_297.length() > 0) {
                     var8 = "IGP-CATEGORIES";
                     var8 = method_42(field_235.getAppProperty(var8), var1[var7], field_297 + (field_218 ? "&ctg=XXXX" : ""));
                  }
               } else if (field_219) {
                  if (var1[var7].compareTo("GLDT") == 0) {
                     var8 = method_42(var3, var1[var7], field_217);
                  } else if (var1[var7].compareTo("CATALOG") == 0) {
                     var8 = field_297;
                  } else {
                     var8 = method_42(var3, var1[var7], var6);
                  }
               } else {
                  var8 = field_216[var0] + "-" + var1[var7];
                  var8 = field_235.getAppProperty(var8);
               }

               if (method_41(var8, 7)) {
                  field_265[var0][var5] = var8;
                  field_266[var0][var5++] = var7;
                  int var14 = var2 - (var1.length - 1) + var7;
                  field_267[var0][var7] = var14;
               }
            } catch (Exception var9) {
            }
         }

         if (var5 > 0) {
            field_282[field_176 + var0] = true;
            field_268[var0] = var5;
         }
      }
   }

   // $VF: renamed from: a (byte[]) java.lang.String[]
   private static String[] method_45(byte[] var0) {
      String[] var1 = new String[method_32(var0)];

      for (int var2 = 0; var2 < var1.length; var2++) {
         int var3 = method_32(var0);
         var1[var2] = new String(var0, field_203, var3);
         field_203 += var3;
      }

      return var1;
   }

   // $VF: renamed from: c () void
   private static void method_46() {
      String[] var8;
      try {
         if (!method_29()) {
            field_243 = false;
            return;
         }

         byte[] var1;
         method_32(var1 = method_31(0));
         int var0 = method_32(var1);
         field_203 += var0;
         field_220 = method_45(var1);
         var8 = method_45(var1);
         field_221 = method_45(var1);
         field_222 = method_45(var1);
         field_223 = method_45(var1);

         for (int var2 = 0; var2 < field_170.length; var2++) {
            field_170[var2] = method_32(var1) == 1;
         }

         try {
            int var19 = method_32(var1);
            if ((field_159 = new String(var1, field_203, var19)).equals("2.1z")) {
               field_317 = 2;
               field_207 = 2;
               field_208 = 4;
               field_209 = 5;
            }

            if (!field_159.startsWith(field_157)) {
               new StringBuffer().append("Invalid dataIGP file, dataIGP file IGP Version : ").append(field_159);
               new StringBuffer().append("IGP Class version : ").append(field_157);
            }
         } catch (Exception var6) {
            field_243 = false;
         }

         method_30();
      } catch (Exception var7) {
         field_243 = false;
         return;
      }

      int var9 = (var8.length - 1 > 0 ? var8.length - 1 : 0) + 4;
      field_180 = ++var9;
      int var11 = field_192 = (
            field_191 = (
                  field_190 = (
                        field_189 = (
                              field_188 = (
                                    field_187 = (field_186 = (field_185 = (field_184 = (field_183 = (field_182 = (field_181 = var9 + 1) + 1) + 1) + 1) + 1) + 1)
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
      if (field_221.length > 1) {
         field_194 = (field_193 = var11 + 1) + (field_221.length - 1);
      } else {
         field_194 = var11 + 1;
      }

      var9 = field_194;
      if (field_222.length > 1) {
         field_196 = (field_195 = var9 + 1) + (field_222.length - 1);
      } else {
         field_196 = var9 + 1;
      }

      var9 = field_196;
      field_198 = (field_197 = field_196 + 1) + 1;
      field_262 = new Image[field_224 = var8.length];
      field_225 = field_224 + 1 + 1 + 1 + 1 + (field_170[0] ? 1 : 0);

      for (int var14 = 0; var14 < field_170.length; var14++) {
         if (field_170[var14]) {
            field_171[var14] = ++field_174;
         } else {
            field_171[var14] = --field_173;
         }
      }

      field_172 = ++field_174;
      field_280 = new String[field_225];
      field_282 = new boolean[field_225];
      field_281 = new int[field_225];

      for (int var15 = 0; var15 < field_282.length; var15++) {
         field_282[var15] = false;
      }

      field_179 = (field_178 = (field_177 = (field_176 = (field_175 = field_224) + 1) + 1) + 1) + 1;
      field_265 = new String[3][];
      field_266 = new int[3][];
      field_267 = new int[3][];
      field_268 = new int[3];

      try {
         String var20 = "URL-TEMPLATE-GAME";
         if ((field_217 = field_235.getAppProperty(var20)) != null) {
            field_217 = field_217.trim();
            field_219 = true;
            if (field_217.indexOf("ingameads.gameloft.com/redir") != -1) {
               field_218 = true;
            }
         }
      } catch (Exception var5) {
      }

      for (int var16 = 0; var16 < field_224; var16++) {
         method_43(var16, var8[var16], 7, "IGP-PROMOS", field_217);
      }

      try {
         String var21 = "URL-OPERATOR";
         String var17;
         if (method_41(var17 = field_235.getAppProperty(var21).trim(), 7)) {
            field_297 = var17;
         }

         var21 = "URL-PT";
         field_295 = field_235.getAppProperty(var21);
      } catch (Exception var4) {
      }

      if (!field_170[0]) {
         if (field_219) {
            if (method_41(field_297, 7)) {
               method_43(field_224, "PROMO", 7, "IGP-CATEGORIES", field_297 + (field_218 ? "&ctg=XXXX" : ""));
            }
         } else {
            String var23 = "URL-PROMO";
            String var18;
            if ((var18 = field_235.getAppProperty(var23)) != null) {
               var23 = "URL-PROMO";
               if (method_41(field_235.getAppProperty(var23), 7)) {
                  field_280[field_175] = var18;
                  field_282[field_175] = true;
                  field_281[field_175] = 5;
               }
            }
         }
      }

      method_44(0, field_221, field_194, "IGP-WN");
      method_44(1, field_222, field_196, "IGP-BS");
      if (!field_170[0]) {
         if (field_219) {
            String var25 = "IGP-CATEGORIES";
            if (method_41(method_42(field_235.getAppProperty(var25), "OP", field_297), 7)) {
               if (method_41(field_297, 7)) {
                  field_282[field_178] = true;
               }

               field_280[field_178] = field_297;
            }
         } else if (method_41(field_297, 7)) {
            field_280[field_178] = field_297;
            field_282[field_178] = true;
         }

         if (field_282[field_178] && field_218) {
            field_280[field_178] = field_280[field_178] + "&ctg=CCTL";
         }
      }

      if (field_170[0]) {
         try {
            if (method_41(field_297, 7)) {
               field_280[field_179] = field_297;
               field_282[field_179] = true;
            }
         } catch (Exception var3) {
         }
      }

      if ((field_279 = method_51()) > 0) {
         field_243 = true;
      }

      new StringBuffer().append("isAvailable = ").append(field_243);
   }

   // $VF: renamed from: a () boolean
   public static boolean method_47() {
      return (field_243 && method_51() > 0 ? 0 : -1) != -1;
   }

   // $VF: renamed from: a (java.lang.String, int) void
   public static void method_48(String var0, int var1) {
      new StringBuffer().append("enterIGP(loadingMsg = ").append(var0).append(", appLanguage = ").append(0).append(" (").append(field_220[0]).append(")");
      field_246 = 0;
      field_305 = 0;
      field_306 = true;
      field_307 = false;
      field_316 = false;
      byte var6 = 0;
      if (var6 >= 0 && var6 < field_220.length) {
         field_294 = var6 <= field_220.length ? var6 : 0;
         field_296 = var0;
         field_248 = -1;
         field_245 = 0;
         field_247 = 0;
         field_272 = 0;
         field_273 = 0;
         field_212 = new int[10];
         field_241 = true;
         field_162 = Font.getFont(0, 0, 8);
         field_286 = 0;
         field_287 = 0;
      }

      field_249 = 4 + field_225;
      field_231 = true;
      field_232 = true;
      RecordStore var5 = null;

      try {
         var5 = RecordStore.openRecordStore("igp19", false);
      } catch (Exception var4) {
         try {
            var5 = RecordStore.openRecordStore("igp19", true);
         } catch (Exception var3) {
         }
      }

      try {
         if (var5 != null) {
            var5.closeRecordStore();
         }
      } catch (Exception var2) {
      }

      field_247 = method_52();
      if (field_238) {
         field_236.setCommandListener(field_240);
      }
   }

   // $VF: renamed from: a () void
   public static void method_49() {
      field_316 = true;
      if (method_50()) {
         field_245 = 7;
         field_161 = field_298;
      }
   }

   // $VF: renamed from: b () boolean
   public static boolean method_50() {
      int var0 = 0;

      for (int var1 = 0; var1 < field_220.length; var1++) {
         if (field_220[var1].equals("SP")) {
            var0 = 1;
         }
      }

      if (var0 == 0) {
         return false;
      } else {
         try {
            String var4 = "IGP-CATEGORIES";
            String var8;
            if ((var8 = field_235.getAppProperty(var4)) == null || var8.indexOf("ZVIP") == -1) {
               String var7 = "URL-ZVIP";
               if ((field_298 = field_235.getAppProperty(var7)) == null) {
                  return false;
               }

               field_244 = true;
               return true;
            }

            int var2;
            if ((var2 = (var0 = var8.indexOf("ZVIP") + "ZVIP".length() + 1) + "ZVIP".length()) >= var8.length()) {
               return false;
            }

            if (!var8.substring(var0, var2).equals("ZVIP")) {
               return false;
            }

            field_298 = field_297;
            if (field_218) {
               if ((var0 = (field_298 = field_298 + "&ctg=XXXX").indexOf("XXXX")) >= 0) {
                  field_298 = field_298.substring(0, var0) + "ZVIP" + field_298.substring(var0 + "XXXX".length());
               }

               if (field_298.length() == 0) {
                  return false;
               }
            }
         } catch (Exception var3) {
            return false;
         }

         field_244 = true;
         return true;
      }
   }

   // $VF: renamed from: a () int
   private static int method_51() {
      int var0 = 0;

      for (int var1 = 0; var1 < field_282.length; var1++) {
         if (field_282[var1]) {
            var0++;
         }
      }

      return var0;
   }

   // $VF: renamed from: b () int
   private static int method_52() {
      for (int var0 = 0; var0 < field_282.length; var0++) {
         if (field_282[var0]) {
            return var0;
         }
      }

      return -1;
   }

   // $VF: renamed from: d () void
   private static void method_53() {
      if (field_295 != null) {
         int var0;
         if ((var0 = field_295.length()) <= 0) {
            field_295 = null;
         } else {
            boolean var1 = false;
            int var2 = 0;
            int var3 = 0;
            int var4 = 0;
            int var5 = 1;
            String var6 = "";
            field_295 = field_295.toUpperCase();

            for (int var7 = 0; var7 < var0; var7++) {
               char var8;
               if (((var8 = field_295.charAt(var7)) < ' ' || var8 > 'z') && var8 != 130 && var8 != '\n') {
                  var6 = null;
                  break;
               }

               if (var8 == '\n') {
                  var1 = true;
               } else if (var7 < var0 - 1 && var8 == '\\' && (field_295.charAt(var7 + 1) == 'n' || field_295.charAt(var7 + 1) == 'N')) {
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
                  var3 += method_36(var8, field_208);
                  if (var8 == ' ') {
                     var2 = var6.length() - 1;
                     var4 = var3;
                  }
               }

               if (var3 >= field_299) {
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

            if (var6 != null && !method_41(var6, 7)) {
               var6 = null;
            }

            field_295 = var6;
         }
      }
   }

   // $VF: renamed from: a (int) void
   private static void method_54(int var0) {
      Object var1 = null;
      field_203 = 0;
      switch (var0) {
         case -1:
            field_250 = new Image[field_199];
            field_251 = new Image[field_225];
            (field_264 = new Image[3][])[0] = new Image[field_221.length];
            field_264[1] = new Image[field_222.length];
            field_264[2] = new Image[field_223.length];
            return;
         case 0:
            method_29();
            return;
         case 1:
            var1 = method_31(var0);

            for (int var24 = 0; var24 < field_294; var24++) {
               var0 = method_32((byte[])var1);
               field_203 += var0;
            }

            method_32((byte[])var1);
            field_226 = new String[var0 = method_32((byte[])var1)];
            byte[] var25 = new byte[var0];
            System.arraycopy(var1, field_203, var25, 0, var0);
            field_203 += var0;
            method_32((byte[])var1);
            int var31;
            field_227 = new short[var31 = ((byte[])var1)[field_203++] & 255 | (((byte[])var1)[field_203++] & 255) << 8];

            for (int var33 = 0; var33 < var31 - 1; var33++) {
               field_227[var33] = (short)((((byte[])var1)[field_203++] & 255) + ((((byte[])var1)[field_203++] & 255) << 8));
            }

            field_227[var31 - 1] = (short)var0;

            for (int var34 = 0; var34 < var31; var34++) {
               var0 = var34 == 0 ? 0 : field_227[var34 - 1] & '\uffff';
               int var35;
               if ((var35 = (field_227[var34] & '\uffff') - var0) != 0) {
                  try {
                     field_226[var34] = new String(var25, var0, var35, "UTF-8");
                  } catch (Exception var6) {
                  }
               }
            }

            if (field_238) {
               field_303 = new Command(method_35(field_186), 4, 1);
               field_304 = new Command(method_35(field_187), 2, 1);
               boolean var12 = true;
               var12 = true;
               if (field_304 != null) {
                  field_236.removeCommand(field_304);
               }

               if (field_303 != null) {
                  field_236.removeCommand(field_303);
               }

               field_236.addCommand(field_303);
               field_236.addCommand(field_304);
               return;
            }
            break;
         case 2:
            field_210 = new Image[3];
            byte[] var32 = new byte[((Object[])(var1 = method_31(var0))).length];
            System.arraycopy(var1, 0, var32, 0, ((byte[])var1).length);
            var0 = method_32((byte[])var1);
            field_203 = 0;
            field_210[0] = method_34((byte[])var1);
            field_210[1] = method_67(var32, 2, var0, 1, 46319);
            field_210[2] = method_67(var32, 2, var0, 1, 16711680);
            int var5 = method_32((byte[])var1);
            field_204 = new byte[(method_32((byte[])var1) + 1) * (4 + field_317)];
            var0 = var5 / (6 + field_317);

            for (int var30 = 0; var30 < var0; var30++) {
               int var23 = method_32((byte[])var1) * (4 + field_317);
               System.arraycopy(var1, field_203, field_204, var23, 4 + field_317);
               field_203 = field_203 + 4 + field_317;
            }

            field_169 = (field_205 = field_204[32 * (4 + field_317) + field_209]) == 13 ? 0 : -1;
            method_53();
            return;
         case 3:
            var1 = method_31(var0);

            for (int var29 = 0; var29 < field_199; var29++) {
               field_250[var29] = method_34((byte[])var1);
            }

            return;
         case 4:
            for (int var28 = 0; var28 < field_224; var28++) {
               field_251[var28] = method_34(method_31(var0));
            }

            return;
         case 5:
            byte[] var26 = method_33((byte[])(var1 = method_31(var0)));
            int var27 = var26.length;
            byte var21 = 0;
            field_251[field_175] = Image.createImage(var26, var21, var27);

            for (int var22 = 0; var22 < field_294; var22++) {
               method_34((byte[])var1);
            }

            field_252 = method_34((byte[])var1);
            return;
         case 6:
         case 7:
            int var2 = (var0 == 6 ? field_221.length : field_222.length) - 1;
            int var3 = var0 == 6 ? 0 : 1;
            var1 = method_31(var0);

            int var4;
            for (var4 = 0; var4 < var2; var4++) {
               field_264[var3][var4] = method_34((byte[])var1);
            }

            field_264[var3][var4] = field_250[11];
            field_251[var0 == 6 ? field_176 : field_177] = field_250[10];
            return;
         case 8:
            var1 = method_31(var0);
            field_251[field_178] = method_34((byte[])var1);
            if ((field_220[field_294].equals("JP") || field_220[field_294].equals("DOCOMO")) && field_253 == null) {
               field_253 = method_34((byte[])var1);
               return;
            }
            break;
         default:
            if (var0 == field_171[0]) {
               var1 = method_31(var0);
               field_251[field_179] = method_34((byte[])var1);
               return;
            }

            if (var0 == field_172) {
               method_30();
            }
      }
   }

   // $VF: renamed from: a (boolean) void
   private static void method_55(boolean var0) {
      for (int var1 = 0; var1 < field_264.length; var1++) {
         if (field_264[var1] != null) {
            for (int var2 = 0; var2 < field_264[var1].length; var2++) {
               field_264[var1][var2] = null;
            }
         }
      }

      for (int var3 = 0; var3 < field_251.length; var3++) {
         field_251[var3] = null;
      }

      field_252 = null;
      field_253 = null;
      if (var0) {
         method_30();
         field_204 = null;
         field_210 = null;

         for (int var4 = 0; var4 < field_199; var4++) {
            field_250[var4] = null;
         }

         field_250 = null;
         field_227 = null;
         field_226 = null;
         field_212 = null;
         field_296 = null;
         field_251 = null;
         field_264 = null;
         field_254 = null;
         field_255 = null;
         field_256 = null;
         field_257 = null;
         field_258 = null;
         field_259 = null;
         field_260 = null;
         field_261 = null;
         field_263 = null;

         for (int var5 = 0; var5 < field_262.length; var5++) {
            field_262[var5] = null;
         }
      }

      System.gc();
   }

   // $VF: renamed from: a (int) boolean
   public static boolean method_56(int var0) {
      if (field_316) {
         return !field_244 ? true : field_245 == 4;
      } else if (!field_243) {
         return true;
      } else {
         if (field_306) {
            field_306 = false;
         } else {
            field_246 = var0;
         }

         switch (field_245) {
            case 0:
               if (field_248 >= field_249) {
                  method_74();
                  field_245 = 1;
                  method_61();
               } else {
                  method_54(field_248);
               }

               field_248++;
               break;
            case 1:
               switch (field_246) {
                  case 21:
                     if (field_288 && field_273 > 0 && --field_273 - field_272 < 0) {
                        field_272--;
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
                     if (field_279 <= 1) {
                        return false;
                     }

                     if (field_247 == 0) {
                        field_247 = field_225 - 1;
                     } else {
                        field_247--;
                     }

                     while (!field_282[field_247]) {
                        if (field_247 == 0) {
                           field_247 = field_225 - 1;
                        } else {
                           field_247--;
                        }
                     }

                     field_229 = true;
                  case 24:
                     if (field_279 > 1) {
                        if (!field_229) {
                           if (field_247 == field_225 - 1) {
                              field_247 = 0;
                           } else {
                              field_247++;
                           }

                           while (!field_282[field_247]) {
                              if (field_247 == field_225 - 1) {
                                 field_247 = 0;
                              } else {
                                 field_247++;
                              }
                           }

                           field_230 = true;
                        }

                        field_272 = 0;
                        field_273 = 0;
                        method_61();
                     }

                     return false;
                  case 25:
                  case 27:
                     field_245 = 6;
                     return false;
                  case 26:
                     field_245 = 4;
                     return false;
                  case 32:
                     if (field_288 && field_273 < field_270 - 1 && ++field_273 - field_272 >= field_271) {
                        field_272++;
                     }

                     return false;
               }
            case 2:
               method_55(false);
               var0 = field_247;
               method_54(
                  field_248 = field_281[var0] == 4
                     ? field_281[var0]
                     : (
                        var0 == field_175
                           ? 5
                           : (var0 == field_176 ? 6 : (var0 == field_177 ? 7 : (var0 == field_178 ? 8 : (var0 == field_179 ? field_171[0] : -1))))
                     )
               );
               method_74();
               field_245 = 1;
               break;
            case 3:
               switch (field_246) {
                  case 25:
                     field_161 = null;
                     return false;
                  case 26:
                     field_245 = 1;
                     field_237 = null;
                     return false;
                  default:
                     return false;
               }
            case 4:
               method_55(true);
               if (field_238) {
                  field_236.setCommandListener(field_239);
                  if (field_304 != null) {
                     field_236.removeCommand(field_304);
                     field_304 = null;
                  }

                  if (field_303 != null) {
                     field_236.removeCommand(field_303);
                     field_303 = null;
                  }
               }

               field_241 = false;
               return true;
            case 5:
            default:
               break;
            case 6:
               String var2 = field_280[field_247];
               if (field_288) {
                  var2 = field_265[field_269][field_273];
               }

               if (var2 != null && var2.length() > 0) {
                  if (field_218) {
                     int var1;
                     if ((var1 = var2.indexOf("&lg=")) == -1) {
                        var2 = var2 + "&lg=" + field_220[field_294];
                     } else {
                        var2 = var2.substring(0, var1) + "&lg=" + field_220[field_294] + var2.substring(var1 + "&lg=".length() + 2);
                     }
                  }

                  field_161 = var2;
               }
         }

         return false;
      }
   }

   // $VF: renamed from: a (int, int) void
   public static void method_57(int var0, int var1) {
      if ((var0 = method_60(var0, var1)) != 0) {
         field_246 = var0;
         field_306 = true;
      }

      field_305 = 0;
      field_307 = false;
   }

   // $VF: renamed from: b (int, int) void
   public static void method_58(int var0, int var1) {
      if ((var0 = method_60(var0, var1)) != 0) {
         field_305 = var0;
      }
   }

   // $VF: renamed from: c (int, int) void
   public static void method_59(int var0, int var1) {
      field_246 = 0;
      field_305 = 0;
      field_307 = false;
      method_58(var0, var1);
   }

   // $VF: renamed from: b (int, int) int
   private static int method_60(int var0, int var1) {
      if (var0 < 1 || var1 < 1) {
         return 0;
      } else if (field_245 != 0 && field_241) {
         if (field_288) {
            int var2 = field_300 * 5 / 100;
            var2 = var2 + 1 + field_250[5].getWidth();
            int var3 = field_299 / 100;
            int var4 = var2 + field_264[field_269][0].getWidth() + var3;
            var3 *= 3;
            boolean var5 = var0 > field_275 + var3 && var0 < field_275 + field_277 - var3;

            for (int var7 = field_272; var7 < field_272 + field_271; var7++) {
               if (var5 && var1 > field_312 + field_278 * (var7 - field_272) && var1 < field_312 + field_278 * (var7 - field_272) + field_278) {
                  if (field_273 == var7) {
                     return 25;
                  }

                  field_273 = var7;
                  return 0;
               }
            }

            if (var5) {
               var5 = var0 > field_250[12].getWidth() * 3 / 2 + 2 && var0 < field_299 - (field_250[12].getWidth() * 3 / 2 - 2);
            }

            if (field_271 < field_270 && var5) {
               if (field_273 > 0 && var1 > field_313 - (var4 - 2) / 2 && var1 < field_313 + (var4 - 2)) {
                  return 21;
               }

               if (field_273 < field_270 - 1 && var1 > field_314 - (var4 - 2) / 2 && var1 < field_314 + (var4 - 2)) {
                  return 32;
               }
            }
         } else {
            if (var0 > field_292 && var0 < field_292 + field_290 && var1 > field_293 && var1 < field_293 + field_291) {
               return 27;
            }

            if (var0 > field_308 && var0 < field_308 + field_310 && var1 > field_309 && var1 < field_309 + field_311) {
               return 27;
            }
         }

         int var8 = field_299 - field_250[7].getWidth();
         int var10 = (field_300 >> 1) - field_250[7].getHeight();
         int var11 = field_250[7].getHeight() << 1;
         int var12 = field_250[7].getWidth() << 1;
         if (var1 > var10 && var1 < var10 + var11) {
            if (var0 > 0 && var0 < var12 + 0) {
               return 23;
            }

            if (var0 > var8 - var12 / 2 && var0 < var8 + var12) {
               return 24;
            }
         }

         if (field_238) {
            return 0;
         } else {
            if (var1 >= field_300 - (field_250[13].getHeight() << 1) && var1 <= field_300) {
               if (var0 > field_164 && var0 < (field_250[13].getWidth() << 1) + field_164) {
                  return 0;
               }

               if (var0 > field_299 - field_165 - (field_250[13].getWidth() << 1) && var0 < field_299 - field_165) {
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
   private static void method_61() {
      field_284 = field_247;
      field_273 = 0;
      field_270 = 0;
      field_272 = 0;
      field_288 = false;
      field_285 = field_280[field_247] != null && field_280[field_247].length() > 0 && field_280[field_247].compareTo("DEL") != 0;
      if (field_247 == field_176) {
         field_269 = 0;
         field_288 = true;
         field_285 = false;
      }

      if (field_247 == field_177) {
         field_269 = 1;
         field_288 = true;
         field_285 = false;
      }

      if (field_247 == field_178 || field_247 == field_179) {
         field_285 = true;
      }

      field_289 = field_188;
      if (field_281[field_247] == 4) {
         field_289 = field_189;
      }

      if (field_288) {
         field_270 = field_268[field_269];
      }
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics) void
   public static void method_62(Graphics var0) {
      if (field_243 || field_316) {
         if (field_161 != null) {
            if (field_161 != null && field_161.length() > 0) {
               String var9 = field_161;
               field_161 = null;
               new StringBuffer().append("urlPlatformRequest = ").append(var9);

               try {
                  field_235.platformRequest(var9);
                  Thread.sleep(200L);
               } catch (Exception var7) {
               }

               if (!field_316) {
                  field_245 = 1;
               } else {
                  field_245 = 4;
               }

               field_235.notifyDestroyed();
            }
         } else if (!field_316) {
            method_70(var0, 0, 0, field_299, field_300);
            method_70(var0, 0, 0, field_299, field_300);
            switch (field_245) {
               case 0:
                  var0.setColor(0);
                  var0.fillRect(0, 0, field_299, field_300);
                  int var10002 = field_299 * 3 / 4;
                  int var5 = field_249;
                  int var4 = field_248;
                  int var3 = var10002;
                  int var11 = field_302;
                  if (var4 > var5) {
                     var4 = var5;
                  }

                  int var6 = (field_299 - var3) / 2;
                  var0.setColor(16777215);
                  var0.drawRect(var6, var11, var3, 6);
                  var3 = (var3 - 2 - 2) * var4 / var5 + 1;
                  var0.setColor(16711680);
                  var0.fillRect(var6 + 1 + 1, var11 + 1 + 1, var3, 3);
                  if (field_296 != null && !field_296.trim().equals("")) {
                     var0.setColor(16777215);
                     var0.setFont(field_162);
                     var0.drawString(field_296, field_301, field_302 - 5, 33);
                     return;
                  }
                  break;
               case 1:
                  method_64(var0);
                  if (System.currentTimeMillis() % 1000L <= 500L && field_305 != 27) {
                     break;
                  }

                  if (field_285) {
                     var0.setColor(field_163);
                     if (field_170[0]) {
                        var0.setColor(16744192);
                     }

                     if (field_305 == 27) {
                        var0.setColor(14588928);
                        var0.drawRect(field_292 - 2, field_293 - 2, field_290 + 3, field_291 + 4);
                        var0.drawRect(field_292 - 1, field_293 - 1, field_290 + 1, field_291 + 2);
                        var0.setColor(5767410);
                     }

                     field_211 = 0;
                     var0.fillRect(field_292, field_293, field_290, field_291 + 1);
                     method_37(field_289, var0, field_301, field_293 + (field_291 >> 1), 3);
                  }

                  return;
               case 2:
                  int var8 = field_162.getHeight();
                  var0.setColor(255);
                  var0.fillRect(0, field_302 - var8 - 5, field_299, var8 << 1);
                  int var10 = field_211;
                  field_211 = 0;
                  method_37(field_198, var0, field_301, field_302 - var8, 65);
                  field_211 = var10;
                  return;
               case 3:
                  method_64(var0);
                  int var1 = field_300 * 40 / 100;
                  int var2 = field_299;
                  method_63(var0, 0, var1, var2, field_300 - (var1 << 1), -220209185);
                  var0.setColor(39423);
                  var0.drawRect(0, var1, var2 - 1, field_300 - (var1 << 1) - 1);
                  var0.drawRect(1, var1 + 1, var2 - 3, field_300 - (var1 << 1) - 3);
                  method_37(field_192, var0, field_301, field_302, 3);
                  method_66(var0);
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
   private static void method_63(Graphics var0, int var1, int var2, int var3, int var4, int var5) {
      int[] var7 = new int[var3 * var4];

      for (int var6 = 0; var6 < var7.length; var6++) {
         var7[var6] = var5;
      }

      var0.drawRGB(var7, 0, var3, 0, var2, var3, var4, true);
   }

   // $VF: renamed from: b (javax.microedition.lcdui.Graphics) void
   private static void method_64(Graphics var0) {
      field_215 = true;
      method_37(field_289, null, 0, 0, 3);
      int var2 = method_36(32, field_208) / 2;
      int var3 = method_36(32, field_209) / 3;
      field_290 = field_214 + var2;
      field_291 = field_213 + var3;
      if ((field_213 + field_291) % 2 != 0) {
         field_291++;
      }

      field_292 = field_301 - field_290 / 2;
      if (field_281[field_247] == 4 || field_247 == field_179) {
         field_293 = field_167 - field_291 / 2;
      } else if (field_247 == field_175 || field_247 == field_178) {
         field_293 = field_168 - field_291 / 2;
      }

      if (field_170[0] && field_247 == field_179) {
         field_293 = field_300 * 80 / 100;
      }

      var0.setColor(16777215);
      if (field_170[0]) {
         var0.setColor(0);
      }

      var0.fillRect(0, 0, field_299, field_300);
      if (field_288) {
         Graphics var18 = var0;
         int var28 = field_166;
         if (field_300 > 128) {
            method_69(var0, field_251[field_247], field_301, field_166, 17);
            var28 += field_251[field_247].getHeight();
         }

         field_211 = 2;
         method_37(field_284, var0, field_301, var28, 17);
         int var5 = Math.max(2 * field_205, field_264[field_269][field_266[field_269][0]].getHeight());
         field_215 = true;
         method_37(field_284, null, 0, 0, 0);
         int var6 = var28 + field_213;
         int var4 = var3 = field_300 * 7 / 100;
         int var7 = field_300 / 2 - var6 << 1;
         int var1 = field_300 - field_250[12].getHeight() - 2 - var6;
         field_271 = field_270;
         if (var7 / var5 >= field_270) {
            var6 = var6 + var7 / 2 - field_271 * var5 / 2;
         } else {
            if (var1 / var5 < field_270) {
               field_271 = (var1 - var4 * 2) / var5;
            }

            var6 = var6 + var1 / 2 - field_271 * var5 / 2;
         }

         if (field_271 < field_270) {
            int var58 = 16777215;
            if (field_272 > 0) {
               if (field_305 == 21) {
                  var58 = 46319;
               }

               method_65(var0, field_301, var6 - var4, var3, var58, true, false);
               field_313 = var6 - var4;
            }

            if (field_272 + field_271 < field_270) {
               if (field_305 == 32) {
                  var58 = 46319;
               }

               method_65(var0, field_301, var6 + field_271 * var5 + var4, var3, var58, true, true);
               field_314 = var6 + field_271 * var5;
            }
         }

         int var11 = var6 + var5 / 2 + 1;
         field_277 = field_299 - 3 * field_250[5].getWidth();
         if (field_299 > field_300) {
            field_277 = field_277 - field_250[5].getWidth() / 2;
         }

         field_275 = (field_299 >> 1) - (field_277 >> 1);
         var7 = field_299 / 100;
         var4 = (var3 = field_275 + var7) + field_264[field_269][0].getWidth() + var7;

         for (int var60 = field_272; var60 < field_272 + field_271; var60++) {
            int var8 = field_266[field_269][var60];
            method_69(var18, field_264[field_269][var8], var3, var11, 6);
            if (field_269 == 2 || var8 == field_267[field_269].length - 1) {
               field_211 = 2;
            }

            method_39(method_35(field_267[field_269][var8]), var18, var4, var11, 6);
            var11 += var5;
         }

         field_274 = field_273 - field_272;
         field_276 = var6 + var5 * field_274;
         field_278 = var5;
         field_312 = var6;
         var18.setColor(16545540);
         var18.drawRect(field_275, field_276, field_277, field_278);
      } else if (field_247 == field_179) {
         int var12 = field_299 / 2;
         var2 = (field_300 << 3) / 100;
         method_69(var0, field_251[field_179], var12, var2, 17);
         field_215 = true;
         method_37(field_180, null, 0, 0, 0);
         field_251[field_247].getHeight();
         if (field_170[0]) {
            field_211 = 0;
         }

         method_38(method_35(field_181), var0, field_299 - (field_250[4].getWidth() + 8 << 1), field_299 / 2, field_300 * 60 / 100, 3);
      } else if (field_247 == field_175) {
         boolean var13 = field_300 >= 128;
         boolean var20 = field_295 != null && field_295.length() > 0;
         var3 = var13 ? field_250[10].getHeight() : 0;
         int var38 = field_166 + var3 * 3 / 5;
         if (field_251[field_175].getWidth() > 220) {
            var0.setColor(13421772);
            var0.fillRect(field_301 + 20, var38, 3, 54);
            var38 += 54;
         } else if (field_251[field_175].getWidth() > 140) {
            var0.setColor(14145495);
            var0.fillRect(field_301 + 14, var38, 2, 37);
            var38 += 37;
         } else if (field_251[field_175].getWidth() > 100) {
            var0.setColor(14465464);
            var0.fillRect(field_301 + 11, var38, 1, 26);
            var38 += 26;
         }

         int var39 = var38 + field_251[field_175].getHeight();
         method_69(var0, field_251[field_175], field_301, var39, 33);
         method_69(var0, field_252, field_301 + (field_251[field_175].getWidth() >> 1) + 1, var39, 40);
         field_310 = field_251[field_175].getWidth();
         field_311 = field_251[field_175].getHeight();
         field_308 = field_301 - 1 - field_310 / 2;
         field_309 = var39 - field_251[field_175].getHeight();
         if (var13) {
            method_69(var0, field_250[10], field_301, field_166, 17);
         }

         if (var20) {
            field_211 = 2;
            int var45 = field_293 - var39;
            byte var53 = 3;
            if (field_205 << 1 > var45) {
               var38 = var39 + field_205 / 3;
               var53 = 17;
            } else {
               var38 = var39 + var45 / 2;
            }

            method_38(field_295, var0, field_299, field_301, var38, var53);
         }
      } else if (field_247 == field_178) {
         boolean var14 = field_300 >= 128;
         var2 = field_251[field_247].getWidth() * 70 / 100;
         var3 = field_251[field_247].getHeight() >> 1;
         int var41 = (field_299 >> 1) - (var2 >> 1);
         int var46 = (field_300 >> 1) - (var3 >> 1);
         boolean var61 = false;
         int var42 = 15812117;
         int var33 = 16437549;
         int var54 = var3;
         int var47 = var2;
         int var43 = var46;
         var3 = var41;
         Graphics var22 = var0;
         if (var46 + var3 > field_300) {
            var54 = field_300 - var46;
         }

         if (var41 + var2 > field_299) {
            var47 = field_299 - var41;
         }

         for (int var62 = var46; var62 < var43 + var54; var62++) {
            int var64 = 250 + (var62 - var43) * -9 / var54;
            int var9 = 209 + (var62 - var43) * -139 / var54;
            int var10 = 45 + (var62 - var43) * -24 / var54;
            var22.setColor(var64, var9, var10);
            var22.drawLine(var3, var62, var3 + var47, var62);
         }

         int var65 = field_300 / 2;
         method_69(var0, field_251[field_247], field_301, var65, 3);
         field_310 = (field_310 = field_251[field_247].getWidth()) - 2 * field_250[5].getWidth();
         field_311 = field_251[field_247].getHeight();
         field_308 = field_301 - field_310 / 2;
         field_309 = var65 - field_311 / 2;
         if (var14) {
            method_69(var0, field_250[10], field_301, field_166, 17);
         }

         if (field_253 == null) {
            field_215 = true;
            method_38(method_35(field_284), null, 0, 0, 0, 0);
            var65 -= field_213 / 2;
            var2 = field_211;
            field_211 = 0;
            method_38(method_35(field_284), var0, field_251[field_247].getWidth() / 2, field_301, var65, 17);
            field_211 = var2;
         } else {
            method_69(var0, field_253, field_301, field_300 / 2, 3);
         }
      } else {
         field_215 = true;
         method_38(method_35(field_284), var0, 0, 0, 0, 0);
         int var15 = field_251[field_247].getHeight();
         int var24 = 0;
         int var35 = 0;
         boolean var44 = false;
         if (field_214 > field_299 - (field_250[12].getWidth() << 1)) {
            var24 = field_250[12].getHeight();
         } else if (field_214 > field_299 - (field_250[9].getWidth() << 1)) {
            var24 = field_250[9].getHeight();
         }

         int var48 = var15 + field_213 + var24;
         int var55 = Math.max(0, field_300 - var48);
         int var63 = field_299 <= 176 ? 2 : 0;
         if (field_213 > (field_205 << 1) + var63 && var55 / 3 > (field_205 + var63) / 2) {
            var48 = var15 + (field_205 << 1) + var24;
            var55 = Math.max(0, field_300 - var48);
            var44 = true;
         }

         int var67 = var55 / 3;
         if (var24 > 0) {
            var2 = field_300 - field_250[12].getHeight();
            var48 = var15 + field_213;
            int var56 = Math.max(0, field_300 - var48);
            if (field_213 > (field_205 << 1) + var63 && var56 / 3 > field_213 - (field_205 + var63 << 1)) {
               var48 = var15 + (field_205 << 1);
               var56 = Math.max(0, field_300 - var48);
               var44 = true;
            }

            var15 = var56 / 3;
            if (var15 * 2 + field_213 + field_251[field_247].getHeight() < var2) {
               var67 = var15;
            }
         }

         method_69(var0, field_251[field_247], field_301, var67, 17);
         field_310 = (field_310 = field_251[field_247].getWidth()) - 2 * field_250[5].getWidth();
         field_311 = field_251[field_247].getHeight();
         field_308 = field_301 - field_310 / 2;
         field_309 = var67;
         var2 = var67 + var67 + field_251[field_247].getHeight();
         if (field_170[0]) {
            field_211 = 0;
         }

         if (var44) {
            var35 = -(field_205 / 2);
         }

         method_38(method_35(field_284), var0, 0, field_301, var2 + var35, 17);
      }

      method_66(var0);
      if (field_279 > 1) {
         int var17 = Math.abs((int)(System.currentTimeMillis() / 80L % 8L) - 4);
         byte var27 = 5;
         byte var36 = 7;
         if (field_229 || field_305 == 23) {
            var27 = 4;
            field_228++;
         }

         if (field_230 || field_305 == 24) {
            var36 = 6;
            field_228++;
         }

         int var57 = var17 + 1 + field_250[var27].getWidth();
         field_250[var27].getWidth();
         method_69(var0, field_250[var27], var57, field_302, 10);
         method_69(var0, field_250[var36], field_299 - var57, field_302, 6);
         if (field_228 > 4) {
            field_229 = false;
            field_230 = false;
            field_228 = 0;
         }
      }
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, int, int, int, int, boolean, boolean) void
   private static void method_65(Graphics var0, int var1, int var2, int var3, int var4, boolean var5, boolean var6) {
      int var5i = var6 ? -1 : 1;
      if (var3 % 2 == 0) {
         var3--;
      }

      var0.setColor(46319);
      method_68(var0, var1, var2, var1 - (var3 >> 1), var2 + var5i * (var3 >> 1), var1 + (var3 >> 1), var2 + var5i * (var3 >> 1));
      var0.setColor(var4);
      method_68(var0, var1, var2 + var5i, var1 - (var3 >> 1) + 2, var2 + var5i * (var3 >> 1) - var5i, var1 + (var3 >> 1) - 2, var2 + var5i * (var3 >> 1) - var5i);
   }

   // $VF: renamed from: c (javax.microedition.lcdui.Graphics) void
   private static void method_66(Graphics var0) {
      int var1 = field_300 - 2;
      int var2 = field_164;
      int var3 = field_299 - field_165;
      if (!field_238) {
         Image var4 = field_250[12];
         Image var5 = field_250[12];
         if (field_305 == 26) {
            var5 = field_250[13];
         }

         field_287 = (byte)(field_287 | 2);
         field_286 = (byte)(field_286 | 2);
         if ((field_287 & 1) != 0) {
            method_69(var0, var4, var2, var1, 36);
         }

         if ((field_287 & 2) != 0) {
            method_69(var0, var5, var3, var1, 40);
         }

         int var7 = var2 + (field_250[12].getWidth() / 2 - field_250[9].getWidth() / 2);
         int var8 = var3 + -field_250[12].getWidth() / 2 + field_250[8].getWidth() / 2;
         int var6 = var1 + -field_250[12].getHeight() / 2 + field_250[9].getHeight() / 2;
         if (((field_286 = (byte)(field_286 | 2)) & 1) != 0) {
            method_69(var0, field_250[9], var7, var6, 36);
         }

         if ((field_286 & 2) != 0) {
            method_69(var0, field_250[8], var8, var6, 40);
         }
      }
   }

   // $VF: renamed from: a (byte[], int, int, int, int) javax.microedition.lcdui.Image
   private static Image method_67(byte[] var0, int var1, int var2, int var3, int var4) {
      int var10 = 0;

      for (int var12 = 2; var10 == 0 && var12 < var2 + 2; var12++) {
         if ((var0[var12] & 255) == 80 && (var0[var12 + 1] & 255) == 76 && (var0[var12 + 2] & 255) == 84 && (var0[var12 + 3] & 255) == 69) {
            var10 = var12;
         }
      }

      var3 = (var0[var10 - 4] << 24 & 0xFF000000) + (var0[var10 - 3] << 16 & 0xFF0000) + (var0[var10 - 2] << 8 & 0xFF00) + (var0[var10 - 1] & 255);
      var0[var10 + 4 + 3] = (byte)(var4 >> 16 & 0xFF);
      var0[var10 + 4 + 3 + 1] = (byte)(var4 >> 8 & 0xFF);
      var0[var10 + 4 + 3 + 2] = (byte)var4;
      byte[] var14 = new byte[var3 + 4];
      System.arraycopy(var0, var10, var14, 0, var3 + 4);
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

      for (int var15 = 0; var15 < var14.length; var15++) {
         var16 = var5[(int)(var16 ^ (long)var14[var15]) & 0xFF] ^ var16 >> 8;
      }

      var16 ^= 4294967295L;
      var0[var10 + 4 + var3] = (byte)((int)((var16 & -16777216L) >> 24));
      var0[var10 + 4 + var3 + 1] = (byte)((int)((var16 & 16711680L) >> 16));
      var0[var10 + 4 + var3 + 2] = (byte)((int)((var16 & 65280L) >> 8));
      var0[var10 + 4 + var3 + 3] = (byte)((int)(var16 & 255L));
      System.gc();
      byte var11 = 2;
      return Image.createImage(var0, var11, var2);
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, int, int, int, int, int, int) void
   private static void method_68(Graphics var0, int var1, int var2, int var3, int var4, int var5, int var6) {
      var0.fillTriangle(var1, var2, var3, var4, var5, var6);
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, javax.microedition.lcdui.Image, int, int, int) void
   private static void method_69(Graphics var0, Image var1, int var2, int var3, int var4) {
      var0.drawImage(var1, var2, var3, var4);
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, int, int, int, int) void
   private static void method_70(Graphics var0, int var1, int var2, int var3, int var4) {
      var1 = Math.max(var1, 0);
      var2 = Math.max(var2, 0);
      var3 = Math.min(var3, field_299);
      var4 = Math.min(var4, field_300);
      var0.setClip(var1, var2, var3, var4);
   }

   // $VF: renamed from: run () void
   public final void run() {
   }

   // $VF: renamed from: d () boolean
   private static boolean method_71() {
      if (field_243) {
         if (field_232) {
            return field_231;
         }

         try {
            RecordStore.openRecordStore("igp19", false).closeRecordStore();
            field_231 = true;
         } catch (Exception var1) {
         }

         field_232 = true;
      }

      return field_231;
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, javax.microedition.lcdui.Image, int, int, int) boolean
   public static boolean method_72(Graphics var0, Image var1, int var2, int var3, int var4) {
      if (method_71()) {
         return false;
      } else if (field_243 && var1 != null && var0 != null) {
         if (System.currentTimeMillis() - field_233 > 800L) {
            field_234 = !field_234;
            field_233 = System.currentTimeMillis();
         }

         if (field_234) {
            method_69(var0, var1, var2, var3, 20);
            return true;
         } else {
            return true;
         }
      } else {
         return false;
      }
   }

   public final void commandAction(Command var1, Displayable var2) {
      if (field_238) {
         if (var1 == field_303) {
            method_56(25);
            return;
         }

         if (var1 == field_304) {
            method_56(26);
         }
      }
   }

   // $VF: renamed from: a (java.lang.String) java.io.InputStream
   private static InputStream method_73(String var0) {
      return "a".getClass().getResourceAsStream(var0);
   }

   // $VF: renamed from: f () void
   private static void method_74() {
      int var0 = field_299;

      try {
         int var1 = field_299 - 3 * field_250[5].getWidth();
         if (field_299 > field_300) {
            var1 -= field_250[5].getWidth() / 2;
         }

         int var2 = (field_299 >> 1) - (var1 >> 1);
         int var3 = field_299 / 100;
         int var4;
         var3 = (var4 = var2 + var3) + field_264[field_269][0].getWidth() + var3;
         var0 = var2 + var1 - var3;
      } catch (Exception var11) {
      }

      try {
         for (int var13 = 0; var13 < field_226.length; var13++) {
            if (field_226[var13] != null
               && (
                  var13 == field_182
                     || var13 == field_184
                     || var13 == field_188
                     || var13 == field_181
                     || var13 < field_180
                     || var13 >= field_193 && var13 < field_195 + field_222.length
               )) {
               int var14;
               byte var20;
               label164: {
                  var14 = field_299;
                  var20 = 3;
                  int var10000;
                  if ((field_221.length <= 1 || var13 < field_193 || var13 >= field_193 + field_221.length)
                     && (field_222.length <= 1 || var13 < field_195 || var13 >= field_195 + field_222.length)
                     && var13 != field_181) {
                     if (var13 != field_182 && var13 != field_184 && var13 != field_188) {
                        if (var13 != field_180 - 1) {
                           break label164;
                        }

                        var10000 = field_251[field_178] != null ? field_251[field_178].getWidth() >> 1 : field_299;
                     } else {
                        var20 = 2;
                        var10000 = field_299 - (field_250[12].getWidth() << 1) - 8;
                     }
                  } else {
                     var10000 = var0;
                  }

                  var14 = var10000;
               }

               String[] var26 = field_226;
               String var10002 = field_226[var13];
               boolean var15 = true;
               byte var23 = var20;
               String var16 = var10002;
               String var5 = "";
               int var6 = 0;
               int var7 = 0;
               String var17 = var16;
               String var8 = "";
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

               if (field_220[field_294].equals("ZH-TW") && var8.indexOf(124) == -1 && var8.indexOf(32) == -1 && var8.length() > 5) {
                  var8 = var8.substring(0, var8.length() >> 1) + "|" + var8.substring(var8.length() >> 1, var8.length());
               }

               String var18 = var8;
               short[] var22 = method_75(var8, var14, true);

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
               field_226[var13] = method_76(field_226[var13]);
            }
         }
      } catch (Exception var12) {
      }
   }

   // $VF: renamed from: a (java.lang.String, int, boolean) short[]
   private static short[] method_75(String var0, int var1, boolean var2) {
      int var3 = var0.length();
      short var4 = 0;
      short var5 = 1;
      short var6 = 0;
      boolean var8 = false;
      short var9 = 0;

      for (int var10 = 0; var10 < var3; var10++) {
         char var7;
         if ((var7 = var0.charAt(var10)) == ' ') {
            var4 = (short)(var4 + method_36(var7, field_208));
            short var18 = var6;
            var6 = (short)var10;
            var8 = true;
            var9 = 0;
            if (var6 == var3 - 2 && var4 + method_36(var0.charAt(var6 + 1), field_208) > var1) {
               var6 = var18;
               field_318[var5++] = (short)(var18 + 1);
               field_318[var5++] = (short)var4;
               var4 = 0;
            }

            if (var4 > var1) {
               var8 = false;

               for (int var11 = var6; var11 >= 0 && var0.charAt(var11) == ' '; var4 = (short)(var4 - method_36(32, field_208))) {
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

               field_318[var5++] = (short)(var6 + 1);
               field_318[var5++] = (short)var4;
               var4 = 0;
            }
         } else if (var7 == '|') {
            if (!var2) {
               break;
            }

            var4 = (short)(var4 + method_36(var7, field_208));
            var6 = (short)var10;
            var8 = true;
            var9 = 0;
            if (var4 > var1) {
               var8 = false;

               for (int var20 = var6; var20 >= 0 && var0.charAt(var20) == ' '; var4 = (short)(var4 - method_36(32, field_208))) {
                  var20--;
               }

               while (var6 < var3 && var0.charAt(var6) == ' ') {
                  var6++;
               }

               var10 = --var6;
               field_318[var5++] = (short)(var6 + 1);
               field_318[var5++] = (short)var4;
               var4 = 0;
            }
         } else if (var7 == '\n') {
            field_318[var5++] = (short)var10;
            field_318[var5++] = var4;
            var4 = 0;
            var9 = 0;
         } else {
            int var21 = method_36(var7, field_208) + field_169;
            var9 = (short)(var9 + var21);
            if ((var4 = (short)(var4 + var21)) > var1 && var8) {
               var8 = false;

               for (int var22 = var6; var22 >= 0 && var0.charAt(var22) == ' '; var4 = (short)(var4 - method_36(32, field_209))) {
                  var22--;
               }

               field_318[var5++] = (short)(var6 + 1);
               field_318[var5++] = (short)(var4 - var9);
               var4 = 0;
               var10 = var6;
            }
         }
      }

      if (var4 != 0) {
         field_318[var5++] = (short)var3;
         field_318[var5++] = var4;
      }

      field_318[0] = (short)(var5 / 2);
      return field_318;
   }

   // $VF: renamed from: a (java.lang.String) java.lang.String
   private static String method_76(String var0) {
      String var1 = "";
      char[] var2 = var0.toCharArray();

      for (int var3 = 0; var3 < var0.length(); var3++) {
         if (var2[var3] != '|') {
            var1 = var1 + var2[var3];
         }
      }

      return var1;
   }
}
