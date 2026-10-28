import java.io.ByteArrayOutputStream;
import java.io.DataInputStream;
import java.io.IOException;
import java.io.InputStream;
import javax.microedition.lcdui.Graphics;
import javax.microedition.lcdui.Image;

// $VF: renamed from: p
public class class_7 {
   // $VF: renamed from: a javax.microedition.lcdui.Image[]
   private static Image[] field_50;
   // $VF: renamed from: b byte[][]
   private static byte[][] field_51;
   // $VF: renamed from: c java.lang.String[]
   private static String[] field_52;
   // $VF: renamed from: d byte[][]
   private static byte[][] field_53;
   // $VF: renamed from: e short[][]
   private static short[][] field_54;
   // $VF: renamed from: f byte[]
   private static byte[] field_55;
   // $VF: renamed from: g byte[]
   private static byte[] field_56;
   // $VF: renamed from: h byte[]
   private static byte[] field_57;
   // $VF: renamed from: i short[]
   private static short[] field_58;
   // $VF: renamed from: j byte[]
   private static byte[] field_59;
   // $VF: renamed from: k java.lang.String[]
   private static String[] field_60;

   public class_7(int var1) {
      try {
         field_50 = new Image[var1];
         field_51 = new byte[var1][];
         field_52 = new String[var1];
         field_53 = new byte[var1][];
         field_54 = new short[var1][];
         field_55 = new byte[var1];
         field_56 = new byte[var1];
         field_57 = new byte[var1];
         field_58 = new short[var1];
         field_59 = new byte[var1];
      } catch (Exception var3) {
      }
   }

   // $VF: renamed from: a (int, java.lang.String, byte, byte, byte, short, byte) void
   public void method_27(int var1, String var2, byte var3, byte var4, byte var5, short var6, byte var7) {
      try {
         if (var7 == 0) {
            field_50[var1] = Image.createImage("/" + var2 + ".png");
         } else if (var7 == 1 || var7 == 2) {
            field_51[var1] = this.method_43("/" + var2 + ".bin");
         }

         field_55[var1] = var3;
         field_56[var1] = var4;
         field_57[var1] = var5;
         field_58[var1] = var6;
         field_59[var1] = var7;
         this.method_28(var1, var2);
      } catch (Exception var9) {
      }
   }

   // $VF: renamed from: a (int, java.lang.String) void
   private void method_28(int var1, String var2) {
      try {
         InputStream var3 = this.getClass().getResourceAsStream("/" + var2 + ".bmf");
         DataInputStream var4 = new DataInputStream(var3);
         field_52[var1] = var4.readUTF();
         int var5 = field_52[var1].length();
         field_53[var1] = new byte[var5];
         field_54[var1] = new short[var5];
         short var6 = 0;

         for (int var7 = 0; var7 < var5; var7++) {
            field_53[var1][var7] = var4.readByte();
            field_54[var1][var7] = var6;
            var6 = (short)(var6 + field_53[var1][var7]);
         }

         try {
            var4.close();
         } catch (IOException var8) {
         }
      } catch (Exception var9) {
      }
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, java.lang.String, int, int, int, int, int) void
   public void method_29(Graphics var1, String var2, int var3, int var4, int var5, int var6, int var7) {
      int var8 = 0;

      try {
         if (var6 == 1 || var6 == 8) {
            var8 = this.method_36(var2, var7);
            if (var6 == 1) {
               var3 += var5 / 2 - var8 / 2;
            } else if (var6 == 8) {
               var3 -= var8;
            }
         }

         for (int var9 = 0; var9 < var2.length(); var9++) {
            char var10 = var2.charAt(var9);
            if (field_59[var7] == 0) {
               var3 += this.method_33(var1, var10, var3, var4, var7);
            } else if (field_59[var7] == 1) {
               var3 += this.method_34(var1, var10, var3, var4, var7);
            } else if (field_59[var7] == 2) {
               var3 += this.method_35(var1, var10, var3, var4, var7);
            }
         }
      } catch (Exception var11) {
      }
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, java.lang.String, int, int, int, int, int, int) void
   public void method_30(Graphics var1, String var2, int var3, int var4, int var5, int var6, int var7, int var8) {
      int var9 = 0;
      int var10 = var4 + (var6 - field_57[var8]) / 2;
      if (field_57[var8] % 2 > 0) {
         var10++;
      }

      try {
         if (var7 == 1 || var7 == 8) {
            var9 = this.method_36(var2, var8);
            if (var7 == 1) {
               var3 += var5 / 2 - var9 / 2;
            } else if (var7 == 8) {
               var3 -= var9;
            }
         }

         for (int var11 = 0; var11 < var2.length(); var11++) {
            char var12 = var2.charAt(var11);
            if (field_59[var8] == 0) {
               var3 += this.method_33(var1, var12, var3, var10, var8);
            } else if (field_59[var8] == 1) {
               var3 += this.method_34(var1, var12, var3, var10, var8);
            } else if (field_59[var8] == 2) {
               var3 += this.method_35(var1, var12, var3, var10, var8);
            }
         }
      } catch (Exception var13) {
      }
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, java.lang.String, int, int, int, int, int, int, int, int) void
   public void method_31(Graphics var1, String var2, int var3, int var4, int var5, int var6, int var7, int var8, int var9, int var10) {
      int var11 = this.method_36(var2, var7);
      if (var11 >= var5) {
         int var12 = var1.getClipX();
         int var13 = var1.getClipY();
         int var14 = var1.getClipWidth();
         int var15 = var1.getClipHeight();
         var1.setClip(var3, var13, var5, var15);
         if (var8 > 0) {
            int var16 = var11 + var9;

            for (int var17 = 0; var17 < 2; var17++) {
               this.method_29(var1, var2, var3 + var10 - var8 % var16 + var17 * var16, var4, var5, 4, var7);
            }
         } else {
            this.method_29(var1, var2, var3 + var10, var4, var5, 4, var7);
         }

         var1.setClip(var12, var13, var14, var15);
      } else {
         this.method_29(var1, var2, var3, var4, var5, var6, var7);
      }
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, java.lang.String, int, int, int, int, int, int, boolean) int
   public int method_32(Graphics var1, String var2, int var3, int var4, int var5, int var6, int var7, int var8, boolean var9) {
      int var10 = 1;
      if (!var9 && !this.method_42(var2, var3, var5, var7)) {
         this.method_29(var1, var2, var3, var4, var5, var6, var7);
      } else {
         String[] var11 = this.method_38(var2, var5, var7, 128);

         for (int var12 = 0; var12 < var11.length; var12++) {
            this.method_29(var1, var11[var12], var3, var4 + var12 * var8, var5, var6, var7);
         }

         var10 = var11.length;
      }

      return var10;
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, char, int, int, int) int
   public int method_33(Graphics var1, char var2, int var3, int var4, int var5) {
      if (this.method_41(var2)) {
         return field_56[var5];
      } else {
         int var6 = field_52[var5].indexOf(var2);
         if (var6 >= 0) {
            var1.drawRegion(
               field_50[var5],
               field_54[var5][var6] % field_58[var5],
               0 + field_54[var5][var6] / field_58[var5] * field_57[var5],
               field_53[var5][var6],
               field_57[var5],
               0,
               var3,
               var4,
               20
            );
            return field_53[var5][var6] + field_55[var5];
         } else {
            return 0;
         }
      }
   }

   // $VF: renamed from: b (javax.microedition.lcdui.Graphics, char, int, int, int) int
   public int method_34(Graphics var1, char var2, int var3, int var4, int var5) {
      if (this.method_41(var2)) {
         return field_56[var5];
      } else {
         int var6 = field_52[var5].indexOf(var2);
         if (var6 < 0) {
            return 0;
         } else {
            int var7 = 2 * var6;
            int var8 = field_51[var5][var7] * 128 + field_51[var5][var7 + 1];

            for (int var9 = 0; var9 < field_51[var5][var8]; var9++) {
               int var10 = var8 + 2 + 2 * var9;
               int var13 = field_51[var5][var10] & 15;
               int var14 = field_51[var5][var10 + 1] & 15;
               int var11 = (field_51[var5][var10] >> 4 & 15) + var3;
               int var12 = (field_51[var5][var10 + 1] >> 4 & 15) + var4;
               var1.fillRect(var11, var12, var13, var14);
            }

            return field_53[var5][var6] + field_55[var5];
         }
      }
   }

   // $VF: renamed from: c (javax.microedition.lcdui.Graphics, char, int, int, int) int
   public int method_35(Graphics var1, char var2, int var3, int var4, int var5) {
      if (this.method_41(var2)) {
         return field_56[var5];
      } else {
         int var6 = field_52[var5].indexOf(var2);
         if (var6 < 0) {
            return 0;
         } else {
            int var7 = 4 * var6;
            int var8 = field_51[var5][var7] * 128 + field_51[var5][var7 + 1];

            for (int var9 = 0; var9 < field_51[var5][var8]; var9++) {
               int var10 = var8 + 3 + 4 * var9;
               byte var13 = field_51[var5][var10 + 2];
               byte var14 = field_51[var5][var10 + 3];
               int var11 = field_51[var5][var10] + var3;
               int var12 = field_51[var5][var10 + 1] + var4;
               var1.fillRect(var11, var12, var13, var14);
            }

            return field_53[var5][var6] + field_55[var5];
         }
      }
   }

   // $VF: renamed from: a (java.lang.String, int) int
   public int method_36(String var1, int var2) {
      int var3 = 0;
      byte var4 = 32;

      try {
         for (int var5 = 0; var5 < var1.length(); var5++) {
            char var7 = var1.charAt(var5);
            if (this.method_41(var7)) {
               var3 += field_56[var2];
            } else {
               var3 += field_53[var2][field_52[var2].indexOf(var7)] + field_55[var2];
            }
         }

         var3 -= field_55[var2];
      } catch (Exception var6) {
      }

      return var3;
   }

   // $VF: renamed from: a (java.lang.String, int, int) java.lang.String
   public String method_37(String var1, int var2, int var3) {
      try {
         int var4 = 0;

         for (int var5 = 0; var5 < var1.length(); var5++) {
            if (var1.charAt(var5) == ' ' || var1.charAt(var5) == '\n') {
               if (this.method_36(var1.substring(var4, var5), var3) < var2) {
                  var4 = var5 + 1;
               } else {
                  int var6 = var4;

                  while (this.method_36(var1.substring(var4, var6) + "- ", var3) < var2) {
                     var6++;
                  }

                  var1 = var1.substring(0, --var6) + "- " + var1.substring(var6);
                  var5 = var4;
               }
            }
         }
      } catch (Exception var7) {
         class_9.method_44("fixUnsplittableWords error:", var7);
      }

      return var1;
   }

   // $VF: renamed from: a (java.lang.String, int, int, int) java.lang.String[]
   public String[] method_38(String var1, int var2, int var3, int var4) {
      String[] var5 = null;
      String var12 = this.method_37(var1, var2, var3);

      try {
         if (var12 == null || var12.equals("")) {
            return null;
         }

         int var6 = 0;
         int var7 = 0;
         int var8 = 0;
         field_60 = new String[var4];

         for (int var9 = 0; var9 < var12.length(); var9++) {
            if (var12.charAt(var9) == ' ' || var12.charAt(var9) == '\n' || var12.charAt(var9) == '~') {
               if (var12.charAt(var9) != '\n' && var12.charAt(var9) != '~') {
                  if (this.method_36(var12.substring(var7, var9), var3) >= var2) {
                     field_60[var8++] = var12.substring(var7, var6);
                     var7 = var6 + 1;
                     var6 = var9;
                  } else {
                     var6 = var9;
                  }
               } else {
                  if (this.method_36(var12.substring(var7, var9), var3) >= var2) {
                     field_60[var8++] = var12.substring(var7, var6);
                     var7 = var6 + 1;
                  }

                  field_60[var8++] = var12.substring(var7, var9);
                  var7 = var9 + 1;
                  var6 = var9;
               }
            }
         }

         if (this.method_36(var12.substring(var7, var12.length() - 1), var3) >= var2) {
            field_60[var8++] = var12.substring(var7, var6);
            var7 = var6 + 1;
         }

         field_60[var8++] = var12.substring(var7);
         var5 = new String[var8];
         System.arraycopy(field_60, 0, var5, 0, var5.length);
      } catch (Exception var11) {
      }

      return var5;
   }

   // $VF: renamed from: a (int) int
   public int method_39(int var1) {
      return field_57[var1];
   }

   // $VF: renamed from: b (java.lang.String, int, int) int
   public int method_40(String var1, int var2, int var3) {
      return this.method_38(var1, var2, var3, 128).length;
   }

   // $VF: renamed from: a (char) boolean
   private boolean method_41(char var1) {
      return var1 == ' ' || var1 == 160 || var1 == '~';
   }

   // $VF: renamed from: b (java.lang.String, int, int, int) boolean
   private boolean method_42(String var1, int var2, int var3, int var4) {
      return this.method_36(var1, var4) >= var3;
   }

   // $VF: renamed from: a (java.lang.String) byte[]
   private byte[] method_43(String var1) {
      byte[] var4 = null;
      byte[] var5 = new byte[256];

      try {
         InputStream var3 = this.getClass().getResourceAsStream(var1);
         ByteArrayOutputStream var2 = new ByteArrayOutputStream();

         int var6;
         while ((var6 = var3.read(var5)) > 0) {
            var2.write(var5, 0, var6);
         }

         var4 = var2.toByteArray();
      } catch (Exception var8) {
      }

      return var4;
   }
}
