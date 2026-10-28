// Transpiled from Java (class_11.java) by Tools/J2meToCs. Regenerate rather than hand-edit where possible.
#pragma warning disable CS0162, CS0164, CS0168, CS0169, CS0219, CS0414, CS0649, CS1717, CS0108, CS0659, CS0661
using J2ME;

namespace REUprising.Gameloft
{
// $VF: renamed from: v
public class SpriteAnimation : Runnable {
   static SpriteAnimation() { }

   // $VF: renamed from: a int
   public int drawX;
   // $VF: renamed from: b int
   public int drawY;
   // $VF: renamed from: d int
   public int integerValue03;
   // $VF: renamed from: a g
   public SpriteResourceDecoder spriteDecoderReference01;
   // $VF: renamed from: c int
   public int animationId;
   // $VF: renamed from: e int
   public int currentFrameIndex;
   // $VF: renamed from: f int
   public int frameElapsedTicks;
   // $VF: renamed from: g int
   public int remainingLoopCount;
   // $VF: renamed from: a boolean
   public bool animationComplete;
   // $VF: renamed from: h int
   public static int frameTimingScale = 28;
   // $VF: renamed from: i int
   public int graphicsTransform;
   // $VF: renamed from: j int
   public static int noAnimationId = -1;
   // $VF: renamed from: k int
   public static int integerValue11 = 2;
   // $VF: renamed from: b boolean
   public static bool booleanFlag02 = false;
   // $VF: renamed from: c boolean
   public static bool booleanFlag03 = false;
   // $VF: renamed from: l int
   public static int integerValue12 = 4;
   // $VF: renamed from: m int
   public static int integerValue13 = -1;
   // $VF: renamed from: n int
   public static int integerValue14 = -1;
   // $VF: renamed from: o int
   public static int integerValue15 = 0;
   // $VF: renamed from: a int[]
   public static int[] integerArray01;
   // $VF: renamed from: a int[][]
   public static int[][] integerMatrix01;
   // $VF: renamed from: a byte[][][]
   public static sbyte[][][] byteCube01;
   // $VF: renamed from: a javax.microedition.lcdui.Image[][]
   public static Image[][] imageReferenceArrayArray01;
   // $VF: renamed from: a javax.microedition.lcdui.Graphics[][]
   public static Graphics[][] graphicsReferenceArrayArray01;
   // $VF: renamed from: a int[][][]
   public static int[][][] integerCube01;
   // $VF: renamed from: p int
   public static int integerValue16;
   // $VF: renamed from: a g[]
   public static SpriteResourceDecoder[] spriteDecoderReferenceArray01;

   public SpriteAnimation() {
      this.resetAnimation();
   }

   public SpriteAnimation(SpriteResourceDecoder var1, int var2, int var3) {
      this.resetAnimation();
      this.drawX = 0;
      this.drawY = 0;
      this.spriteDecoderReference01 = var1;
      this.playAnimation(noAnimationId, -1);
   }

   // $VF: renamed from: e () void
   public void resetAnimation() {
      this.drawX = 0;
      this.drawY = 0;
      this.animationId = noAnimationId;
      this.currentFrameIndex = 0;
      this.spriteDecoderReference01 = null;
      this.integerValue03 = 0;
      this.frameElapsedTicks = 0;
      this.remainingLoopCount = 1;
      this.graphicsTransform = -1;
      this.animationComplete = true;
   }

   // $VF: renamed from: a (int, int) void
   public void playAnimation(int var1, int var2) {
      if (this.animationComplete || var1 != this.animationId) {
         this.animationId = var1;
         int var3 = 0;
         if (this.animationId < 0) {
            sbyte var10000 = -1;
         } else {
            int var4 = this.animationId >= 0 ? this.spriteDecoderReference01.getAnimationFrameCount(this.animationId) : -1;

            while (var3 > var4) {
               var3 -= var4;
            }

            this.currentFrameIndex = var3;
            this.frameElapsedTicks = 0;
         }

         this.remainingLoopCount = var2 - 1;
         this.animationComplete = false;
      }
   }

   // $VF: renamed from: a () boolean
   public bool isAnimationFinished() {
      if (this.animationId < 0) {
         return true;
      } else {
         return this.remainingLoopCount < 0 ? false : this.animationComplete;
      }
   }

   // $VF: renamed from: a () void
   public void drawCurrentFrame() {
      if (this.animationId >= 0) {
         if (!this.animationComplete) {
            if (this.graphicsTransform != -1) {
               int var1 = this.spriteDecoderReference01.getGraphicsTransform();
               this.spriteDecoderReference01.setGraphicsTransform(this.graphicsTransform);
               this.spriteDecoderReference01.drawSpriteFrame(GameCanvas.gameGraphicsReference02, this.animationId, this.currentFrameIndex, this.drawX, this.drawY, 0, 0, 0);
               this.spriteDecoderReference01.setGraphicsTransform(var1);
            } else {
               this.spriteDecoderReference01.drawSpriteFrame(GameCanvas.gameGraphicsReference02, this.animationId, this.currentFrameIndex, this.drawX, this.drawY, 0, 0, 0);
            }
         }
      }
   }

   // $VF: renamed from: a (int) void
   public void advanceAnimation(int var1) {
      if (!this.animationComplete && this.animationId >= 0) {
         int var2;
         if ((var2 = this.animationId >= 0 ? this.spriteDecoderReference01.getFrameDuration(this.animationId, this.currentFrameIndex) * frameTimingScale : 0) != 0) {
            while (this.frameElapsedTicks >= var2) {
               this.frameElapsedTicks -= var2;
               if (this.currentFrameIndex < this.spriteDecoderReference01.getAnimationFrameCount(this.animationId) - 1) {
                  this.currentFrameIndex++;
               } else {
                  if (this.remainingLoopCount == 0) {
                     this.animationComplete = true;
                     break;
                  }

                  if (this.remainingLoopCount > 0) {
                     this.remainingLoopCount--;
                  }

                  this.currentFrameIndex = 0;
               }

               if ((var2 = this.animationId >= 0 ? this.spriteDecoderReference01.getFrameDuration(this.animationId, this.currentFrameIndex) * frameTimingScale : 0) == 0) {
                  break;
               }
            }

            this.frameElapsedTicks += var1;
         }
      }
   }

   // $VF: renamed from: a (int, int, int, int, int, int) void
   [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)] public static void noOpSpriteRegionUpdate(int var0, int var1, int var2, int var3, int var4, int var5) {
   }

   // $VF: renamed from: b () void
   public static void noOpAnimationSetup() {
   }

   // $VF: renamed from: run () void
   public void run() {
   }

   // $VF: renamed from: c () void
   public static void loadAnimationTables() {
      for (int var0 = 0; var0 < integerValue11; var0++) {
         sbyte var1 = 4;
         var1 = -1;
         var1 = -1;
         var1 = -1;
         var1 = -1;
         sbyte var2 = 4;
         noOpSpriteRegionUpdate(var0, var2, -1, -1, -1, -1);
      }

      bool var10001 = true;
   }

   // $VF: renamed from: d () void
   public static void loadAnimationResources() {
      try {
         loadAnimationTables();
         bool var10001 = true;
      } catch (System.Exception var0) {
      }
   }

   // $VF: renamed from: a (int, int, int, int) void
   public static void initializeAnimationFrames(int var0, int var1, int var2, int var3) {
      integerArray01 = new int[8];
      integerMatrix01 = JArr.New2<int>(integerValue12, 16);
      byteCube01 = JArr.New2<sbyte[]>(integerValue12, 2);
      imageReferenceArrayArray01 = JArr.New2<Image>(integerValue12, 1);
      graphicsReferenceArrayArray01 = JArr.New2<Graphics>(integerValue12, 1);
      spriteDecoderReferenceArray01 = new SpriteResourceDecoder[integerValue12];
      integerCube01 = JArr.New3<int>(integerValue12, 6, 4);
      integerArray01[0] = var0;
      integerArray01[1] = var1;
      integerArray01[2] = 54;
      integerArray01[4] = 0;
      integerArray01[5] = 27;
      integerArray01[7] = 0;
      booleanFlag03 = true;
   }

   // $VF: renamed from: a (int, int, boolean) void
   public static void setAnimationFlag(int var0, int var1, bool var2) {
      if (var2) {
         integerMatrix01[var0][15] = integerMatrix01[var0][15] | var1;
      } else {
         integerMatrix01[var0][15] = integerMatrix01[var0][15] & ~var1;
      }
   }

   // $VF: renamed from: a (int, byte[], byte[], byte[], g, boolean, int, int, int) void
   public static void decodeAnimationSprite(int var0, sbyte[] var1, sbyte[] var2, sbyte[] var3, SpriteResourceDecoder var4, bool var5, int var6, int var7, int var8) {
      sbyte var20 = 2;
      sbyte var19 = 2;
      sbyte var18 = 16;
      int var5i = 0;
      object var16 = null;
      sbyte var11 = 0;
      if (booleanFlag03) {
         bool var9 = false;
         if (booleanFlag03) {
            integerMatrix01[var11] = new int[16];
            byteCube01[var11] = new sbyte[2][];
            spriteDecoderReferenceArray01[var11] = null;
         }

         byteCube01[var11][0] = var2;
         byteCube01[var11][1] = (sbyte[])var16;
         integerMatrix01[var11][2] = GameCanvas.readShortBigEndian(var1, 0);
         integerMatrix01[var11][3] = GameCanvas.readShortBigEndian(var1, 2);
         integerMatrix01[var11][5] = integerMatrix01[var11][2] * integerArray01[2];
         integerMatrix01[var11][6] = integerMatrix01[var11][3] * integerArray01[5];
         spriteDecoderReferenceArray01[var11] = var4;
         if (var5i > -1) {
            try {
               int var12 = integerArray01[0] % integerArray01[2];
               int var14 = 1 + (var12 != 0 ? 1 : 0);
               integerMatrix01[var11][7] = integerArray01[0] - var12 + var14 * integerArray01[2];
               int var13 = integerArray01[1] % integerArray01[5];
               int var15 = 1 + (var13 != 0 ? 1 : 0);
               integerMatrix01[var11][8] = integerArray01[1] - var13 + var15 * integerArray01[5];
               if (var5i == var11) {
                  if (imageReferenceArrayArray01[var11][0] == null
                     || imageReferenceArrayArray01[var11][0].getWidth() != integerMatrix01[var11][7]
                     || imageReferenceArrayArray01[var11][0].getHeight() != integerMatrix01[var11][8]) {
                     imageReferenceArrayArray01[var11][0] = Image.createImage(integerMatrix01[var11][7], integerMatrix01[var11][8]);
                     graphicsReferenceArrayArray01[var11][0] = imageReferenceArrayArray01[var11][0].getGraphics();
                     setAnimationFlag(var11, 64, true);
                  }
               } else {
                  imageReferenceArrayArray01[var11][0] = imageReferenceArrayArray01[var5i][0];
                  graphicsReferenceArrayArray01[var11][0] = graphicsReferenceArrayArray01[var5i][0];
               }

               setAnimationFlag(var11, 4, true);
            } catch (System.Exception var10) {
            }
         }

         integerMatrix01[var11][9] = -1;
         integerMatrix01[var11][10] = -1;
         integerMatrix01[var11][11] = -1;
         integerMatrix01[var11][12] = -1;
         integerMatrix01[var11][0] = 1;
         integerMatrix01[var11][1] = 1;
         integerMatrix01[var11][13] = 0;
         integerMatrix01[var11][14] = 0;
         setAnimationFlag(var11, 1, var19 == 1);
         setAnimationFlag(var11, 16, var19 == 0);
         setAnimationFlag(var11, 2, var20 == 1);
         setAnimationFlag(var11, 32, var20 == 0);
         setAnimationFlag(var11, 8, var18 == 32);
      }
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, int, int, int) void
   public static void drawAnimationSprite(Graphics var0, int var1, int var2, int var3) {
      if (booleanFlag03) {
         int var4 = integerArray01[0];
         int var5 = integerArray01[1];
         if (var3 == -1) {
            for (int var25 = 0; var25 < integerValue12; var25++) {
               drawAnimationSprite(var0, var1, var2, var25);
            }
         } else {
            int[] var6;
            if ((var6 = integerMatrix01[var3])[0] == 1 && var6[1] == 1) {
               int var7 = var6[13];
               int var8 = var6[14];
               if ((integerMatrix01[var3][15] & 4) != 0) {
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
                     var17 = var7 - integerArray01[2];
                  }

                  if (var8 < 0) {
                     var18 = var8 - integerArray01[5];
                  }

                  int var31 = var17 / integerArray01[2];
                  int var33 = var18 / integerArray01[5];
                  int var34 = var31 + var6[7] / integerArray01[2] - 1;
                  int var35 = var33 + var6[8] / integerArray01[5] - 1;
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

                  if ((integerMatrix01[var3][15] & 64) != 0) {
                     integerValue16 = 0;
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
                        drawScaledSprite(graphicsReferenceArrayArray01[var3][0], var3, var17, var22, var18 - var17, var21, 0, 0);
                     }

                     var6[9] = var31;
                     var6[11] = var34;
                  }

                  if (var6[10] != var33 || var6[12] != var35) {
                     drawScaledSprite(graphicsReferenceArrayArray01[var3][0], var3, var31, var19, var34 - var31, var20 - var19, 0, 0);
                     var6[10] = var33;
                     var6[12] = var35;
                  }

                  if (var0 != null) {
                     bool var38 = false;
                     if ((integerMatrix01[var3][15] & 17) == 0) {
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

                     if ((integerMatrix01[var3][15] & 34) == 0) {
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
                     GameCanvas.setGraphicsClip(var0, var27, var28, var29, var30);
                     if (var26 > var39) {
                        if (var24 > var31) {
                           drawSpriteRegion(var0, var3, var39, var31, var4, var5, var1 + 0, var2 + 0, var38);
                        } else {
                           drawSpriteRegion(var0, var3, var39, var31, var4, var5 - var24, var1 + 0, var2 + 0, var38);
                           GameCanvas.setGraphicsClip(var0, var27, var28, var29, var30);
                           drawSpriteRegion(var0, var3, var39, 0, var4, var24, var1 + 0, var5 - var24 + var2, var38);
                        }
                     } else if (var24 > var31) {
                        drawSpriteRegion(var0, var3, var39, var31, var4 - var26, var5, var1 + 0, var2 + 0, var38);
                        GameCanvas.setGraphicsClip(var0, var27, var28, var29, var30);
                        drawSpriteRegion(var0, var3, 0, var31, var26, var5, var4 - var26 + var1, var2 + 0, var38);
                     } else {
                        drawSpriteRegion(var0, var3, var39, var31, var4 - var26, var5 - var24, var1 + 0, var2 + 0, var38);
                        GameCanvas.setGraphicsClip(var0, var27, var28, var29, var30);
                        drawSpriteRegion(var0, var3, var39, 0, var4 - var26, var24, var1 + 0, var5 - var24 + var2, var38);
                        GameCanvas.setGraphicsClip(var0, var27, var28, var29, var30);
                        drawSpriteRegion(var0, var3, 0, var31, var26, var5 - var24, var4 - var26 + var1, var2 + 0, var38);
                        GameCanvas.setGraphicsClip(var0, var27, var28, var29, var30);
                        drawSpriteRegion(var0, var3, 0, 0, var26, var24, var4 - var26 + var1, var5 - var24 + var2, var38);
                     }

                     GameCanvas.setGraphicsClip(var0, var27, var28, var29, var30);
                  }
               } else {
                  if (var0 != null) {
                     int var15 = var7;
                     int var16 = var8;
                     if (var7 < 0) {
                        var15 = var7 - integerArray01[2];
                     }

                     if (var8 < 0) {
                        var16 = var8 - integerArray01[5];
                     }

                     int var9 = var15 / integerArray01[2];
                     int var10 = var16 / integerArray01[5];
                     int var11;
                     if ((var11 = var4 / integerArray01[2]) * integerArray01[2] < var4) {
                        var11++;
                     }

                     int var12;
                     if ((var12 = var5 / integerArray01[5]) * integerArray01[5] < var5) {
                        var12++;
                     }

                     int var13 = var9 * integerArray01[2] - var7;
                     int var14 = var10 * integerArray01[5] - var8;
                     drawScaledSprite(var0, var3, var9, var10, var11, var12, var13 + var1, var14 + var2);
                  }
               }
            }
         }
      }
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, int, int, int, int, int, int, int, boolean) void
   public static void drawSpriteRegion(Graphics var0, int var1, int var2, int var3, int var4, int var5, int var6, int var7, bool var8) {
      if (var8) {
         if (var6 <= GameCanvas.screenWidth && var7 <= GameCanvas.screenHeight && var6 + var4 >= 0 && var7 + var5 >= 0) {
            GameCanvas.clipGraphics(var0, var6, var7, var4, var5);
            GameCanvas.clipGraphics(var0, 0, 0, GameCanvas.screenWidth, GameCanvas.screenHeight);
            var0.drawImage(imageReferenceArrayArray01[var1][0], var6 - var2, var7 - var3, 0);
         }
      } else {
         GameCanvas.clipGraphics(var0, var6, var7, var4, var5);
         var0.drawImage(imageReferenceArrayArray01[var1][0], var6 - var2, var7 - var3, 0);
      }
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, int, int, int, int, int, int, int) void
   public static void drawScaledSprite(Graphics var0, int var1, int var2, int var3, int var4, int var5, int var6, int var7) {
      bool var8 = (integerMatrix01[var1][15] & 4) != 0;
      bool var9 = (integerMatrix01[var1][15] & 1) != 0;
      bool var10 = (integerMatrix01[var1][15] & 2) != 0;
      int var11 = integerMatrix01[var1][2];
      int var12 = integerMatrix01[var1][3];
      sbyte[] var13 = byteCube01[var1][0];
      sbyte[] var14 = byteCube01[var1][1];
      int var15 = integerArray01[2];
      int var16 = integerArray01[5];
      if (var8) {
         var6 = var2 * integerArray01[2] % integerMatrix01[var1][7] + var6;
         var7 = var3 * integerArray01[5] % integerMatrix01[var1][8] + var7;
         if (var6 < 0) {
            var6 += integerMatrix01[var1][7];
         }

         if (var7 < 0) {
            var7 += integerMatrix01[var1][8];
         }
      } else {
         var6 = var6;
         var7 = var7;
      }

      if (!var9) {
         if ((integerMatrix01[var1][15] & 16) == 0) {
            if (var2 < 0) {
               var6 -= var2 * var15;
               var4 += var2;
               var2 = 0;
               if (var8 && var6 >= integerMatrix01[var1][7]) {
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
         if ((integerMatrix01[var1][15] & 32) == 0) {
            if (var3 < 0) {
               var7 -= var3 * var16;
               var5 += var3;
               var3 = 0;
               if (var8 && var7 >= integerMatrix01[var1][8]) {
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
            if ((var21 = var20 + var3 * var11) < var13.Length && (var22 = var13[var21] & 255) != 255) {
               if (var14 == null) {
                  var21 = 0;
               } else {
                  var21 = var14[var21] & 255;
               }

               if (spriteDecoderReferenceArray01[var1].getSpriteFrameCount() == 0) {
                  spriteDecoderReferenceArray01[var1].drawSpriteBounds(var0, var22, var17, var18, var21);
               } else {
                  int var23 = var17;
                  int var24 = var18;
                  if ((var21 & 1) != 0) {
                     var23 = var17 + var15;
                  }

                  if ((var21 & 2) != 0) {
                     var24 = var18 + var16;
                  }

                  spriteDecoderReferenceArray01[var1].drawSpriteFrameTransformed(var0, var22, var23, var24, var21, 0, 0);
               }
            }

            var17 += var15;
            if (++var20 >= var11) {
               if (!var9) {
                  break;
               }

               var20 = 0;
            }

            if (var8 && var17 >= integerMatrix01[var1][7]) {
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

         if (var8 && var18 >= integerMatrix01[var1][8]) {
            var18 = 0;
         }
      }

      if ((integerMatrix01[var1][15] & 64) != 0) {
         int var35;
         int var36;
         if (var17 > var6) {
            var35 = var17;
            var36 = 0;
         } else {
            var35 = integerMatrix01[var1][7];
            var36 = var17;
         }

         int var28;
         if (var18 > var7) {
            var28 = var18;
            var2 = 0;
         } else {
            var28 = integerMatrix01[var1][8];
            var2 = var18;
         }

         for (int var30 = 0; var30 < 4; var30++) {
            if ((var30 != 1 && var30 != 3 || var36 != 0) && (var30 != 2 && var30 != 3 || var2 != 0)) {
               int[] var31;
               (var31 = integerCube01[var1][integerValue16])[0] = var30 != 0 && var30 != 2 ? 0 : var6;
               var31[1] = var30 != 0 && var30 != 1 ? 0 : var7;
               var31[2] = var30 != 0 && var30 != 2 ? var36 : var35 - var6;
               var31[3] = var30 != 0 && var30 != 1 ? var2 : var28 - var7;
               integerValue16++;
            }
         }
      }
   }

   // $VF: renamed from: a (int, int, int) void
   public static void setAnimationFrameRegion(int var0, int var1, int var2) {
      integerMatrix01[0][13] = var1;
      int[] var10000 = integerMatrix01[0];
      sbyte var3 = 0;
      var10000[14] = (integerMatrix01[var3][15] & 8) != 0 ? integerMatrix01[var3][6] - integerArray01[1] - var2 : var2;
      if ((integerMatrix01[0][15] & 16) != 0) {
         if (integerMatrix01[0][13] < 0) {
            integerMatrix01[0][13] = 0;
         } else if (integerMatrix01[0][13] + integerArray01[0] > integerMatrix01[0][5]) {
            integerMatrix01[0][13] = integerMatrix01[0][5] - integerArray01[0];
         }
      }

      if ((integerMatrix01[0][15] & 32) != 0) {
         if (integerMatrix01[0][14] < 0) {
            integerMatrix01[0][14] = 0;
            return;
         }

         if (integerMatrix01[0][14] + integerArray01[1] > integerMatrix01[0][6]) {
            integerMatrix01[0][14] = integerMatrix01[0][6] - integerArray01[1];
         }
      }
   }
}
}
