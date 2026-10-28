import javax.microedition.lcdui.Graphics;
import javax.microedition.lcdui.Image;

// $VF: renamed from: v
final class class_11 implements Runnable {
   // $VF: renamed from: a int
   int field_87;
   // $VF: renamed from: b int
   int field_88;
   // $VF: renamed from: d int
   private int field_89;
   // $VF: renamed from: a g
   private class_21 field_90;
   // $VF: renamed from: c int
   int field_91;
   // $VF: renamed from: e int
   private int field_92;
   // $VF: renamed from: f int
   private int field_93;
   // $VF: renamed from: g int
   private int field_94;
   // $VF: renamed from: a boolean
   private boolean field_95;
   // $VF: renamed from: h int
   private static int field_96 = 28;
   // $VF: renamed from: i int
   private int field_97;
   // $VF: renamed from: j int
   private static int field_98 = -1;
   // $VF: renamed from: k int
   private static final int field_99 = 2;
   // $VF: renamed from: b boolean
   private static boolean field_100 = false;
   // $VF: renamed from: c boolean
   private static boolean field_101 = false;
   // $VF: renamed from: l int
   private static int field_102 = 4;
   // $VF: renamed from: m int
   private static int field_103 = -1;
   // $VF: renamed from: n int
   private static int field_104 = -1;
   // $VF: renamed from: o int
   private static int field_105 = 0;
   // $VF: renamed from: a int[]
   private static int[] field_106;
   // $VF: renamed from: a int[][]
   static int[][] field_107;
   // $VF: renamed from: a byte[][][]
   private static byte[][][] field_108;
   // $VF: renamed from: a javax.microedition.lcdui.Image[][]
   private static Image[][] field_109;
   // $VF: renamed from: a javax.microedition.lcdui.Graphics[][]
   private static Graphics[][] field_110;
   // $VF: renamed from: a int[][][]
   private static int[][][] field_111;
   // $VF: renamed from: p int
   private static int field_112;
   // $VF: renamed from: a g[]
   private static class_21[] field_113;

   class_11() {
      this.method_4();
   }

   class_11(class_21 var1, int var2, int var3) {
      this.method_4();
      this.field_87 = 0;
      this.field_88 = 0;
      this.field_90 = var1;
      this.method_5(field_98, -1);
   }

   // $VF: renamed from: e () void
   private void method_4() {
      this.field_87 = 0;
      this.field_88 = 0;
      this.field_91 = field_98;
      this.field_92 = 0;
      this.field_90 = null;
      this.field_89 = 0;
      this.field_93 = 0;
      this.field_94 = 1;
      this.field_97 = -1;
      this.field_95 = true;
   }

   // $VF: renamed from: a (int, int) void
   final void method_5(int var1, int var2) {
      if (this.field_95 || var1 != this.field_91) {
         this.field_91 = var1;
         int var3 = 0;
         if (this.field_91 < 0) {
            byte var10000 = -1;
         } else {
            int var4 = this.field_91 >= 0 ? this.field_90.method_87(this.field_91) : -1;

            while (var3 > var4) {
               var3 -= var4;
            }

            this.field_92 = var3;
            this.field_93 = 0;
         }

         this.field_94 = var2 - 1;
         this.field_95 = false;
      }
   }

   // $VF: renamed from: a () boolean
   final boolean method_6() {
      if (this.field_91 < 0) {
         return true;
      } else {
         return this.field_94 < 0 ? false : this.field_95;
      }
   }

   // $VF: renamed from: a () void
   final void method_7() {
      if (this.field_91 >= 0) {
         if (!this.field_95) {
            if (this.field_97 != -1) {
               int var1 = this.field_90.method_120();
               this.field_90.method_119(this.field_97);
               this.field_90.method_100(class_27.field_788, this.field_91, this.field_92, this.field_87, this.field_88, 0, 0, 0);
               this.field_90.method_119(var1);
            } else {
               this.field_90.method_100(class_27.field_788, this.field_91, this.field_92, this.field_87, this.field_88, 0, 0, 0);
            }
         }
      }
   }

   // $VF: renamed from: a (int) void
   final void method_8(int var1) {
      if (!this.field_95 && this.field_91 >= 0) {
         int var2;
         if ((var2 = this.field_91 >= 0 ? this.field_90.method_86(this.field_91, this.field_92) * field_96 : 0) != 0) {
            while (this.field_93 >= var2) {
               this.field_93 -= var2;
               if (this.field_92 < this.field_90.method_87(this.field_91) - 1) {
                  this.field_92++;
               } else {
                  if (this.field_94 == 0) {
                     this.field_95 = true;
                     break;
                  }

                  if (this.field_94 > 0) {
                     this.field_94--;
                  }

                  this.field_92 = 0;
               }

               if ((var2 = this.field_91 >= 0 ? this.field_90.method_86(this.field_91, this.field_92) * field_96 : 0) == 0) {
                  break;
               }
            }

            this.field_93 += var1;
         }
      }
   }

   // $VF: renamed from: a (int, int, int, int, int, int) void
   private static synchronized void method_9(int var0, int var1, int var2, int var3, int var4, int var5) {
   }

   // $VF: renamed from: b () void
   static void method_10() {
   }

   // $VF: renamed from: run () void
   public final void run() {
   }

   // $VF: renamed from: c () void
   static void method_11() {
      for (int var0 = 0; var0 < field_99; var0++) {
         byte var1 = 4;
         var1 = -1;
         var1 = -1;
         var1 = -1;
         var1 = -1;
         byte var2 = 4;
         method_9(var0, var2, -1, -1, -1, -1);
      }

      boolean var10001 = true;
   }

   // $VF: renamed from: d () void
   static void method_12() {
      try {
         method_11();
         boolean var10001 = true;
      } catch (Exception var0) {
      }
   }

   // $VF: renamed from: a (int, int, int, int) void
   static void method_13(int var0, int var1, int var2, int var3) {
      field_106 = new int[8];
      field_107 = new int[field_102][16];
      field_108 = new byte[field_102][2][];
      field_109 = new Image[field_102][1];
      field_110 = new Graphics[field_102][1];
      field_113 = new class_21[field_102];
      field_111 = new int[field_102][6][4];
      field_106[0] = var0;
      field_106[1] = var1;
      field_106[2] = 54;
      field_106[4] = 0;
      field_106[5] = 27;
      field_106[7] = 0;
      field_101 = true;
   }

   // $VF: renamed from: a (int, int, boolean) void
   private static final void method_14(int var0, int var1, boolean var2) {
      if (var2) {
         field_107[var0][15] = field_107[var0][15] | var1;
      } else {
         field_107[var0][15] = field_107[var0][15] & ~var1;
      }
   }

   // $VF: renamed from: a (int, byte[], byte[], byte[], g, boolean, int, int, int) void
   static void method_15(int var0, byte[] var1, byte[] var2, byte[] var3, class_21 var4, boolean var5, int var6, int var7, int var8) {
      byte var20 = 2;
      byte var19 = 2;
      byte var18 = 16;
      int var5i = 0;
      Object var16 = null;
      byte var11 = 0;
      if (field_101) {
         boolean var9 = false;
         if (field_101) {
            field_107[var11] = new int[16];
            field_108[var11] = new byte[2][];
            field_113[var11] = null;
         }

         field_108[var11][0] = var2;
         field_108[var11][1] = (byte[])var16;
         field_107[var11][2] = class_27.method_354(var1, 0);
         field_107[var11][3] = class_27.method_354(var1, 2);
         field_107[var11][5] = field_107[var11][2] * field_106[2];
         field_107[var11][6] = field_107[var11][3] * field_106[5];
         field_113[var11] = var4;
         if (var5i > -1) {
            try {
               int var12 = field_106[0] % field_106[2];
               int var14 = 1 + (var12 != 0 ? 1 : 0);
               field_107[var11][7] = field_106[0] - var12 + var14 * field_106[2];
               int var13 = field_106[1] % field_106[5];
               int var15 = 1 + (var13 != 0 ? 1 : 0);
               field_107[var11][8] = field_106[1] - var13 + var15 * field_106[5];
               if (var5i == var11) {
                  if (field_109[var11][0] == null
                     || field_109[var11][0].getWidth() != field_107[var11][7]
                     || field_109[var11][0].getHeight() != field_107[var11][8]) {
                     field_109[var11][0] = Image.createImage(field_107[var11][7], field_107[var11][8]);
                     field_110[var11][0] = field_109[var11][0].getGraphics();
                     method_14(var11, 64, true);
                  }
               } else {
                  field_109[var11][0] = field_109[var5i][0];
                  field_110[var11][0] = field_110[var5i][0];
               }

               method_14(var11, 4, true);
            } catch (Exception var10) {
            }
         }

         field_107[var11][9] = -1;
         field_107[var11][10] = -1;
         field_107[var11][11] = -1;
         field_107[var11][12] = -1;
         field_107[var11][0] = 1;
         field_107[var11][1] = 1;
         field_107[var11][13] = 0;
         field_107[var11][14] = 0;
         method_14(var11, 1, var19 == 1);
         method_14(var11, 16, var19 == 0);
         method_14(var11, 2, var20 == 1);
         method_14(var11, 32, var20 == 0);
         method_14(var11, 8, var18 == 32);
      }
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, int, int, int) void
   static void method_16(Graphics var0, int var1, int var2, int var3) {
      if (field_101) {
         int var4 = field_106[0];
         int var5 = field_106[1];
         if (var3 == -1) {
            for (int var25 = 0; var25 < field_102; var25++) {
               method_16(var0, var1, var2, var25);
            }
         } else {
            int[] var6;
            if ((var6 = field_107[var3])[0] == 1 && var6[1] == 1) {
               int var7 = var6[13];
               int var8 = var6[14];
               if ((field_107[var3][15] & 4) != 0) {
                  int var27 = 0;
                  int var28 = 0;
                  int var29 = 0;
                  int var30 = 0;
                  if (var0 != null) {
                     var27 = var0.getClipX();
                     var28 = var0.getClipY();
                     var29 = var0.getClipWidth();
                     var30 = var0.getClipHeight();
                  }

                  int var17 = var7;
                  int var18 = var8;
                  if (var7 < 0) {
                     var17 = var7 - field_106[2];
                  }

                  if (var8 < 0) {
                     var18 = var8 - field_106[5];
                  }

                  int var31 = var17 / field_106[2];
                  int var33 = var18 / field_106[5];
                  int var34 = var31 + var6[7] / field_106[2] - 1;
                  int var35 = var33 + var6[8] / field_106[5] - 1;
                  int var19 = 0;
                  int var20 = 0;
                  if (var6[10] != var33 || var6[12] != var35) {
                     if (var6[10] >= var33 && var6[12] >= var35) {
                        if (var6[10] > var35) {
                           var19 = var33;
                           var20 = var35;
                        } else {
                           var19 = var33;
                           var20 = var6[10] - 1;
                        }
                     } else if (var6[12] < var33) {
                        var19 = var33;
                        var20 = var35;
                     } else {
                        var19 = var6[12] + 1;
                        var20 = var35;
                     }
                  }

                  if ((field_107[var3][15] & 64) != 0) {
                     field_112 = 0;
                  }

                  if (var6[9] != var31 || var6[11] != var34) {
                     if (var6[9] >= var31 && var6[11] >= var34) {
                        if (var6[9] > var34) {
                           var17 = var31;
                           var18 = var34;
                        } else {
                           var17 = var31;
                           var18 = var6[9] - 1;
                        }
                     } else if (var6[11] < var31) {
                        var17 = var31;
                        var18 = var34;
                     } else {
                        var17 = var6[11] + 1;
                        var18 = var34;
                     }

                     int var21 = var35 - var33;
                     int var22 = var33;
                     if (var6[10] != var33 || var6[12] != var35) {
                        if (var6[10] >= var33 && var6[12] >= var35) {
                           var21 -= var20 - var19 + 1;
                           var22 = var33 + var20 - var19 + 1;
                        } else {
                           var21 -= var20 - var19 + 1;
                        }
                     }

                     if (var21 >= 0) {
                        method_18(field_110[var3][0], var3, var17, var22, var18 - var17, var21, 0, 0);
                     }

                     var6[9] = var31;
                     var6[11] = var34;
                  }

                  if (var6[10] != var33 || var6[12] != var35) {
                     method_18(field_110[var3][0], var3, var31, var19, var34 - var31, var20 - var19, 0, 0);
                     var6[10] = var33;
                     var6[12] = var35;
                  }

                  if (var0 != null) {
                     boolean var38 = false;
                     if ((field_107[var3][15] & 17) == 0) {
                        if (var7 < 0) {
                           var1 -= var7;
                           var7 = 0;
                           var38 = true;
                        } else if (var7 > var6[5] - var4) {
                           var1 -= var7 - (var6[5] - var4);
                           var7 = var6[5] - var4;
                           var38 = true;
                        }
                     } else {
                        while (var7 < 0) {
                           var7 += var6[7];
                        }
                     }

                     if ((field_107[var3][15] & 34) == 0) {
                        if (var8 < 0) {
                           var2 -= var8;
                           var8 = 0;
                           var38 = true;
                        } else if (var8 > var6[6] - var5) {
                           var2 -= var8 - (var6[6] - var5);
                           var8 = var6[6] - var5;
                           var38 = true;
                        }
                     } else {
                        while (var8 < 0) {
                           var8 += var6[8];
                        }
                     }

                     int var39 = var7 % var6[7];
                     var31 = var8 % var6[8];
                     int var26 = (var7 + var4) % var6[7];
                     int var24 = (var8 + var5) % var6[8];
                     class_27.method_349(var0, var27, var28, var29, var30);
                     if (var26 > var39) {
                        if (var24 > var31) {
                           method_17(var0, var3, var39, var31, var4, var5, var1 + 0, var2 + 0, var38);
                        } else {
                           method_17(var0, var3, var39, var31, var4, var5 - var24, var1 + 0, var2 + 0, var38);
                           class_27.method_349(var0, var27, var28, var29, var30);
                           method_17(var0, var3, var39, 0, var4, var24, var1 + 0, var5 - var24 + var2, var38);
                        }
                     } else if (var24 > var31) {
                        method_17(var0, var3, var39, var31, var4 - var26, var5, var1 + 0, var2 + 0, var38);
                        class_27.method_349(var0, var27, var28, var29, var30);
                        method_17(var0, var3, 0, var31, var26, var5, var4 - var26 + var1, var2 + 0, var38);
                     } else {
                        method_17(var0, var3, var39, var31, var4 - var26, var5 - var24, var1 + 0, var2 + 0, var38);
                        class_27.method_349(var0, var27, var28, var29, var30);
                        method_17(var0, var3, var39, 0, var4 - var26, var24, var1 + 0, var5 - var24 + var2, var38);
                        class_27.method_349(var0, var27, var28, var29, var30);
                        method_17(var0, var3, 0, var31, var26, var5 - var24, var4 - var26 + var1, var2 + 0, var38);
                        class_27.method_349(var0, var27, var28, var29, var30);
                        method_17(var0, var3, 0, 0, var26, var24, var4 - var26 + var1, var5 - var24 + var2, var38);
                     }

                     class_27.method_349(var0, var27, var28, var29, var30);
                  }
               } else {
                  if (var0 != null) {
                     int var15 = var7;
                     int var16 = var8;
                     if (var7 < 0) {
                        var15 = var7 - field_106[2];
                     }

                     if (var8 < 0) {
                        var16 = var8 - field_106[5];
                     }

                     int var9 = var15 / field_106[2];
                     int var10 = var16 / field_106[5];
                     int var11;
                     if ((var11 = var4 / field_106[2]) * field_106[2] < var4) {
                        var11++;
                     }

                     int var12;
                     if ((var12 = var5 / field_106[5]) * field_106[5] < var5) {
                        var12++;
                     }

                     int var13 = var9 * field_106[2] - var7;
                     int var14 = var10 * field_106[5] - var8;
                     method_18(var0, var3, var9, var10, var11, var12, var13 + var1, var14 + var2);
                  }
               }
            }
         }
      }
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, int, int, int, int, int, int, int, boolean) void
   private static void method_17(Graphics var0, int var1, int var2, int var3, int var4, int var5, int var6, int var7, boolean var8) {
      if (var8) {
         if (var6 <= class_27.field_793 && var7 <= class_27.field_794 && var6 + var4 >= 0 && var7 + var5 >= 0) {
            class_27.method_348(var0, var6, var7, var4, var5);
            class_27.method_348(var0, 0, 0, class_27.field_793, class_27.field_794);
            var0.drawImage(field_109[var1][0], var6 - var2, var7 - var3, 0);
         }
      } else {
         class_27.method_348(var0, var6, var7, var4, var5);
         var0.drawImage(field_109[var1][0], var6 - var2, var7 - var3, 0);
      }
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, int, int, int, int, int, int, int) void
   private static void method_18(Graphics var0, int var1, int var2, int var3, int var4, int var5, int var6, int var7) {
      boolean var8 = (field_107[var1][15] & 4) != 0;
      boolean var9 = (field_107[var1][15] & 1) != 0;
      boolean var10 = (field_107[var1][15] & 2) != 0;
      int var11 = field_107[var1][2];
      int var12 = field_107[var1][3];
      byte[] var13 = field_108[var1][0];
      byte[] var14 = field_108[var1][1];
      int var15 = field_106[2];
      int var16 = field_106[5];
      if (var8) {
         var6 = var2 * field_106[2] % field_107[var1][7] + var6;
         var7 = var3 * field_106[5] % field_107[var1][8] + var7;
         if (var6 < 0) {
            var6 += field_107[var1][7];
         }

         if (var7 < 0) {
            var7 += field_107[var1][8];
         }
      } else {
         var6 = var6;
         var7 = var7;
      }

      if (!var9) {
         if ((field_107[var1][15] & 16) == 0) {
            if (var2 < 0) {
               var6 -= var2 * var15;
               var4 += var2;
               var2 = 0;
               if (var8 && var6 >= field_107[var1][7]) {
                  var6 = 0;
               }
            }

            if (var2 + var4 >= var11) {
               var4 = var11 - var2 - 1;
            }

            if (var4 < 0) {
               return;
            }
         }
      } else {
         while (var2 < 0) {
            var2 += var11;
         }

         while (var2 >= var11) {
            var2 -= var11;
         }
      }

      if (!var10) {
         if ((field_107[var1][15] & 32) == 0) {
            if (var3 < 0) {
               var7 -= var3 * var16;
               var5 += var3;
               var3 = 0;
               if (var8 && var7 >= field_107[var1][8]) {
                  var7 = 0;
               }
            }

            if (var3 + var5 >= var12) {
               var5 = var12 - var3 - 1;
            }

            if (var5 < 0) {
               return;
            }
         }
      } else {
         while (var3 < 0) {
            var3 += var12;
         }

         while (var3 >= var12) {
            var3 -= var12;
         }
      }

      int var17 = var6;
      int var18 = var7;

      while (var5-- >= 0) {
         var17 = var6;
         int var19 = var4;
         int var20 = var2;

         while (var19-- >= 0) {
            int var21;
            int var22;
            if ((var21 = var20 + var3 * var11) < var13.length && (var22 = var13[var21] & 255) != 255) {
               if (var14 == null) {
                  var21 = 0;
               } else {
                  var21 = var14[var21] & 255;
               }

               if (field_113[var1].method_96() == 0) {
                  field_113[var1].method_106(var0, var22, var17, var18, var21);
               } else {
                  int var23 = var17;
                  int var24 = var18;
                  if ((var21 & 1) != 0) {
                     var23 = var17 + var15;
                  }

                  if ((var21 & 2) != 0) {
                     var24 = var18 + var16;
                  }

                  field_113[var1].method_101(var0, var22, var23, var24, var21, 0, 0);
               }
            }

            var17 += var15;
            if (++var20 >= var11) {
               if (!var9) {
                  break;
               }

               var20 = 0;
            }

            if (var8 && var17 >= field_107[var1][7]) {
               var17 = 0;
            }
         }

         var18 += var16;
         if (++var3 >= var12) {
            if (!var10) {
               break;
            }

            var3 = 0;
         }

         if (var8 && var18 >= field_107[var1][8]) {
            var18 = 0;
         }
      }

      if ((field_107[var1][15] & 64) != 0) {
         int var35;
         int var36;
         if (var17 > var6) {
            var35 = var17;
            var36 = 0;
         } else {
            var35 = field_107[var1][7];
            var36 = var17;
         }

         int var28;
         if (var18 > var7) {
            var28 = var18;
            var2 = 0;
         } else {
            var28 = field_107[var1][8];
            var2 = var18;
         }

         for (int var30 = 0; var30 < 4; var30++) {
            if ((var30 != 1 && var30 != 3 || var36 != 0) && (var30 != 2 && var30 != 3 || var2 != 0)) {
               int[] var31;
               (var31 = field_111[var1][field_112])[0] = var30 != 0 && var30 != 2 ? 0 : var6;
               var31[1] = var30 != 0 && var30 != 1 ? 0 : var7;
               var31[2] = var30 != 0 && var30 != 2 ? var36 : var35 - var6;
               var31[3] = var30 != 0 && var30 != 1 ? var2 : var28 - var7;
               field_112++;
            }
         }
      }
   }

   // $VF: renamed from: a (int, int, int) void
   static final void method_19(int var0, int var1, int var2) {
      field_107[0][13] = var1;
      int[] var10000 = field_107[0];
      byte var3 = 0;
      var10000[14] = (field_107[var3][15] & 8) != 0 ? field_107[var3][6] - field_106[1] - var2 : var2;
      if ((field_107[0][15] & 16) != 0) {
         if (field_107[0][13] < 0) {
            field_107[0][13] = 0;
         } else if (field_107[0][13] + field_106[0] > field_107[0][5]) {
            field_107[0][13] = field_107[0][5] - field_106[0];
         }
      }

      if ((field_107[0][15] & 32) != 0) {
         if (field_107[0][14] < 0) {
            field_107[0][14] = 0;
            return;
         }

         if (field_107[0][14] + field_106[1] > field_107[0][6]) {
            field_107[0][14] = field_107[0][6] - field_106[1];
         }
      }
   }
}
