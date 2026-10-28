// Transpiled from Java (class_21.java) by Tools/J2meToCs. Regenerate rather than hand-edit where possible.
#pragma warning disable CS0162, CS0164, CS0168, CS0169, CS0219, CS0414, CS0649, CS1717, CS0108, CS0659, CS0661
using J2ME;

namespace REUprising.Gameloft
{
// $VF: renamed from: g
public class SpriteResourceDecoder {
   // $VF: renamed from: a byte[]
   public static sbyte[] pngFileSignature = new sbyte[]{-119, 80, 78, 71, 13, 10, 26, 10};
   // $VF: renamed from: b byte[]
   public static sbyte[] pngHeaderChunkName = new sbyte[]{73, 72, 68, 82};
   // $VF: renamed from: c byte[]
   public static sbyte[] pngPaletteChunkName = new sbyte[]{80, 76, 84, 69};
   // $VF: renamed from: d byte[]
   public static sbyte[] pngTransparencyChunkName = new sbyte[]{116, 82, 78, 83};
   // $VF: renamed from: e byte[]
   public static sbyte[] pngImageDataChunkName = new sbyte[]{73, 68, 65, 84};
   // $VF: renamed from: f byte[]
   public static sbyte[] pngImageFormatBytes = new sbyte[]{8, 3, 0, 0, 0};
   // $VF: renamed from: g byte[]
   public static sbyte[] pngEndChunk = new sbyte[]{0, 0, 0, 0, 73, 69, 78, 68, -82, 66, 96, -126};
   // $VF: renamed from: h byte[]
   public static sbyte[] zlibCompressedBlockHeader = new sbyte[]{120, -100, 1};
   // $VF: renamed from: b int[]
   public static int[] crcLookupTable = new int[256];
   // $VF: renamed from: a boolean
   public static bool spriteBooleanFlag01 = false;
   // $VF: renamed from: b boolean
   public static bool spriteBooleanFlag02 = false;
   // $VF: renamed from: a int
   public static int spriteIntegerValue01 = 0;
   // $VF: renamed from: b int
   public static int spriteIntegerValue02 = 0;
   // $VF: renamed from: e int
   public int spriteIntegerValue03 = -1;
   // $VF: renamed from: f int
   public int spriteIntegerValue04 = -1;
   // $VF: renamed from: g int
   public int spriteIntegerValue05 = -1;
   // $VF: renamed from: d boolean
   public static bool spriteBooleanFlag03 = false;
   // $VF: renamed from: c int[]
   public static int[] spriteIntegerArray01 = null;
   // $VF: renamed from: e boolean
   public bool spriteBooleanFlag04 = false;
   // $VF: renamed from: h int
   public static int spriteIntegerValue06;
   // $VF: renamed from: c int
   public static int spriteIntegerValue07;
   // $VF: renamed from: i int
   public static int spriteIntegerValue08;
   // $VF: renamed from: j int
   public int spriteIntegerValue09;
   // $VF: renamed from: k int
   public int spriteIntegerValue10;
   // $VF: renamed from: l int
   public int spriteIntegerValue11;
   // $VF: renamed from: m int
   public int spriteIntegerValue12;
   // $VF: renamed from: f boolean
   public bool spriteBooleanFlag05 = false;
   // $VF: renamed from: g boolean
   public bool spriteBooleanFlag06 = false;
   // $VF: renamed from: i byte[]
   public sbyte[] spriteByteArray01 = null;
   // $VF: renamed from: a short[][]
   public short[][] spriteShortMatrix01;
   // $VF: renamed from: a short
   public short spriteShortValue01;
   // $VF: renamed from: n int
   public int spriteIntegerValue13 = -1;
   // $VF: renamed from: d int[]
   public int[] spriteIntegerArray02 = new int[4];
   // $VF: renamed from: a short[]
   public static short[] spriteShortArray01;
   // $VF: renamed from: o int
   public static int spriteIntegerValue14 = -1;
   // $VF: renamed from: p int
   public static int spriteIntegerValue15 = -1;
   // $VF: renamed from: q int
   public static int spriteIntegerValue16 = -1;
   // $VF: renamed from: r int
   public static int spriteIntegerValue17 = -1;
   // $VF: renamed from: s int
   public static int spriteIntegerValue18 = -1;
   // $VF: renamed from: t int
   public static int spriteIntegerValue19 = 0;
   // $VF: renamed from: a int[]
   public static int[] spriteIntegerArray03;
   // $VF: renamed from: e int[]
   public static int[] spriteIntegerArray04;
   // $VF: renamed from: u int
   public int spriteIntegerValue20;
   // $VF: renamed from: b short[]
   public short[] spriteShortArray02;
   // $VF: renamed from: c short[]
   public short[] spriteShortArray03;
   // $VF: renamed from: d short[]
   public short[] spriteShortArray04;
   // $VF: renamed from: e short[]
   public short[] spriteShortArray05;
   // $VF: renamed from: j byte[]
   public sbyte[] spriteByteArray02;
   // $VF: renamed from: f short[]
   public short[] spriteShortArray06;
   // $VF: renamed from: k byte[]
   public sbyte[] spriteByteArray03;
   // $VF: renamed from: g short[]
   public short[] spriteShortArray07;
   // $VF: renamed from: l byte[]
   public sbyte[] spriteByteArray04;
   // $VF: renamed from: h short[]
   public short[] spriteShortArray08;
   // $VF: renamed from: i short[]
   public short[] spriteShortArray09;
   // $VF: renamed from: m byte[]
   public sbyte[] spriteByteArray05;
   // $VF: renamed from: n byte[]
   public sbyte[] spriteByteArray06;
   // $VF: renamed from: j short[]
   public short[] spriteShortArray10;
   // $VF: renamed from: k short[]
   public short[] spriteShortArray11;
   // $VF: renamed from: o byte[]
   public sbyte[] spriteByteArray07;
   // $VF: renamed from: p byte[]
   public sbyte[] spriteByteArray08;
   // $VF: renamed from: l short[]
   public short[] spriteShortArray12;
   // $VF: renamed from: q byte[]
   public sbyte[] spriteByteArray09;
   // $VF: renamed from: r byte[]
   public sbyte[] spriteByteArray10;
   // $VF: renamed from: m short[]
   public short[] spriteShortArray13;
   // $VF: renamed from: n short[]
   public short[] spriteShortArray14;
   // $VF: renamed from: s byte[]
   public sbyte[] spriteByteArray11;
   // $VF: renamed from: b short[][]
   public short[][] spriteShortMatrix02;
   // $VF: renamed from: v int
   public int spriteIntegerValue21;
   // $VF: renamed from: t byte[]
   public sbyte[] spriteByteArray12;
   // $VF: renamed from: f int[]
   public int[] spriteIntegerArray05;
   // $VF: renamed from: w int
   public int spriteIntegerValue22;
   // $VF: renamed from: c short[][]
   public short[][] spriteShortMatrix03;
   // $VF: renamed from: a int[][]
   public int[][] spriteIntegerMatrix01;
   // $VF: renamed from: u byte[]
   public sbyte[] spriteByteArray13;
   // $VF: renamed from: d int
   public int spriteIntegerValue23;
   // $VF: renamed from: x int
   public int spriteIntegerValue24;
   // $VF: renamed from: y int
   public int spriteIntegerValue25;
   // $VF: renamed from: h boolean
   public bool spriteBooleanFlag07;
   // $VF: renamed from: i boolean
   public bool spriteBooleanFlag08;
   // $VF: renamed from: b short
   public short spriteShortValue02;
   // $VF: renamed from: z int
   public int spriteIntegerValue26;
   // $VF: renamed from: A int
   public int spriteIntegerValue27;
   // $VF: renamed from: a int[][][]
   public int[][][] spriteIntegerCube01;
   // $VF: renamed from: a javax.microedition.lcdui.Image[][]
   public Image[][] spriteImageReferenceArrayArray01;
   // $VF: renamed from: g int[]
   public static int[] spriteIntegerArray06 = new int[]{0, 2, 1, 3, 5, 7, 4, 6};
   // $VF: renamed from: h int[]
   public static int[] spriteIntegerArray07 = new int[]{1, 0, 3, 2, 6, 7, 4, 5};
   // $VF: renamed from: i int[]
   public static int[] spriteIntegerArray08 = new int[]{2, 3, 0, 1, 5, 4, 7, 6};
   // $VF: renamed from: j int[]
   public static int[] spriteIntegerArray09 = new int[]{4, 5, 6, 7, 3, 2, 1, 0};
   // $VF: renamed from: v byte[]
   public sbyte[] spriteByteArray14;
   // $VF: renamed from: k int[]
   public int[] spriteIntegerArray10;
   // $VF: renamed from: B int
   public static int spriteIntegerValue28;
   // $VF: renamed from: C int
   public static int spriteIntegerValue29;
   // $VF: renamed from: D int
   public static int spriteIntegerValue30;
   // $VF: renamed from: E int
   public static int spriteIntegerValue31;
   // $VF: renamed from: l int[]
   public static int[] spriteIntegerArray11 = new int[4];
   // $VF: renamed from: j boolean
   public static bool spriteBooleanFlag09 = true;
   // $VF: renamed from: c boolean
   public static bool spriteBooleanFlag10 = false;

   // $VF: renamed from: a (byte[], int) void
   public void loadSpriteData(sbyte[] var1, int var2) {
      object var15 = null;
      bool var16 = true;
      int var3 = 16777215;
      int var20 = 0;
      sbyte[] var18 = var1;
      SpriteResourceDecoder var17 = this;
      if (var1 != null) {
         try {
            if (spriteBooleanFlag09) {
               JSystem.gc();
            }

            var20++;
            int var10002 = ++var20;
            var20++;
            var17.spriteIntegerValue22 = (var18[var10002] & 255) + ((var18[var20++] & 255) << 8) + ((var18[var20++] & 255) << 16) + ((var18[var20++] & 255) << 24);
            sbyte[] var5 = var18;
            SpriteResourceDecoder var27 = var17;
            int var4 = var20 + 1;
            var17.spriteIntegerValue20 = (short)((var18[var20] & 255) + ((var18[var4++] & 255) << 8));
            if (var17.spriteIntegerValue20 > 0) {
               var17.spriteShortArray02 = new short[var17.spriteIntegerValue20];
               var17.spriteShortArray03 = new short[var17.spriteIntegerValue20];
               int var6 = 0;
               sbyte var7 = 0;
               short[][] var8 = null;
               var17.spriteByteArray14 = new sbyte[var17.spriteIntegerValue20];
               var17.spriteIntegerArray10 = new int[var17.spriteIntegerValue20];
               bool var9 = false;
               bool var10 = false;

               for (int var13 = 0; var13 < var27.spriteIntegerValue20; var13++) {
                  bool var11 = false;
                  bool var12 = false;
                  if ((var5[var4] & 255) == 0) {
                     var4++;
                     var27.spriteByteArray14[var13] = 0;
                     var9 = false;
                     var10 = true;
                  } else if ((var5[var4] & 255) == 255) {
                     var4++;
                     var27.spriteByteArray14[var13] = 1;
                     var9 = true;
                     var10 = true;
                  } else if ((var5[var4] & 255) == 254) {
                     var4++;
                     var27.spriteByteArray14[var13] = 2;
                     var9 = true;
                     var10 = true;
                  } else if ((var5[var4] & 255) == 253) {
                     var4++;
                     var27.spriteByteArray14[var13] = 5;
                     var9 = false;
                     var10 = true;
                  } else if ((var5[var4] & 255) == 252) {
                     var4++;
                     var27.spriteByteArray14[var13] = 3;
                     var9 = true;
                     var10 = true;
                     var11 = true;
                  } else if ((var5[var4] & 255) == 251) {
                     var4++;
                     var27.spriteByteArray14[var13] = 4;
                     var9 = true;
                     var10 = true;
                     var11 = true;
                  } else if ((var5[var4] & 255) == 250) {
                     var4++;
                     var27.spriteByteArray14[var13] = 6;
                     var9 = true;
                     var10 = false;
                     var12 = true;
                  } else if ((var5[var4] & 255) == 249) {
                     var4++;
                     var27.spriteByteArray14[var13] = 7;
                     var9 = true;
                     var10 = false;
                     var12 = true;
                  }

                  if (var9) {
                     var27.spriteIntegerArray10[var13] = (var5[var4++] & 255) + ((var5[var4++] & 255) << 8) + ((var5[var4++] & 255) << 16) + ((var5[var4++] & 255) << 24);
                  }

                  if (var10) {
                     if ((var27.spriteIntegerValue22 & 16) == 0) {
                        var27.spriteShortArray02[var13] = (short)(var5[var4++] & 255);
                        var27.spriteShortArray03[var13] = (short)(var5[var4++] & 255);
                     } else {
                        var27.spriteShortArray02[var13] = (short)((var5[var4++] & 255) + ((var5[var4++] & 255) << 8));
                        var27.spriteShortArray03[var13] = (short)((var5[var4++] & 255) + ((var5[var4++] & 255) << 8));
                     }
                  }

                  if (var11) {
                     if (var8 == null) {
                        var8 = new short[var27.spriteIntegerValue20][];
                     }

                     short[] var155;
                     (var155 = new short[2])[0] = (short)((var5[var4++] & 255) + ((var5[var4++] & 255) << 8));
                     var155[1] = (short)((var5[var4++] & 255) + ((var5[var4++] & 255) << 8));
                     var8[var13] = var155;
                     var6++;
                     var7 += 2;
                  }

                  if (var12) {
                     if (var8 == null) {
                        var8 = new short[var27.spriteIntegerValue20][];
                     }

                     short[] var156;
                     (var156 = new short[4])[0] = (short)((var5[var4++] & 255) + ((var5[var4++] & 255) << 8));
                     var156[1] = (short)((var5[var4++] & 255) + ((var5[var4++] & 255) << 8));
                     var156[2] = (short)((var5[var4++] & 255) + ((var5[var4++] & 255) << 8));
                     var156[3] = (short)((var5[var4++] & 255) + ((var5[var4++] & 255) << 8));
                     var8[var13] = var156;
                     var6++;
                     var7 += 4;
                  }
               }

               if (var6 > 0) {
                  var27.spriteShortArray04 = new short[var7];
                  var27.spriteShortArray05 = new short[var6 << 1];
                  int var163 = 0;
                  short var157 = 0;

                  for (short var121 = 0; var121 < var27.spriteIntegerValue20; var121++) {
                     sbyte var115;
                     if (var27.spriteByteArray14[var121] == 3 || var27.spriteByteArray14[var121] == 4) {
                        var115 = 2;
                     } else if (var27.spriteByteArray14[var121] != 6 && var27.spriteByteArray14[var121] != 7) {
                        var115 = -1;
                     } else {
                        var115 = 4;
                     }

                     if (var115 > 0) {
                        var27.spriteShortArray05[var163 << 1] = var121;
                        var27.spriteShortArray05[(var163 << 1) + 1] = var157;

                        for (int var136 = 0; var136 < var115; var136++) {
                           var27.spriteShortArray04[var157] = var8[var121][var136];
                           var157++;
                        }

                        var8[var121] = null;
                        var163++;
                     }
                  }
               }
            }

            var5 = var18;
            SpriteResourceDecoder var28 = var17;
            int var122;
            if ((var122 = (short)((var18[var4++] & 255) + ((var18[var4++] & 255) << 8))) > 0) {
               var17.spriteByteArray05 = new sbyte[var122];
               var17.spriteShortArray10 = new short[var122];
               var17.spriteShortArray11 = new short[var122];
               var17.spriteByteArray06 = new sbyte[var122];
               if ((var17.spriteIntegerValue22 & 16384) != 0) {
                  var17.spriteByteArray07 = new sbyte[var122];
               }

               for (int var137 = 0; var137 < var122; var137++) {
                  var28.spriteByteArray05[var137] = var5[var4++];
                  if ((var28.spriteIntegerValue22 & 1024) == 0) {
                     var28.spriteShortArray10[var137] = (short)var5[var4++];
                     var28.spriteShortArray11[var137] = (short)var5[var4++];
                  } else {
                     var28.spriteShortArray10[var137] = (short)((var5[var4++] & 255) + ((var5[var4++] & 255) << 8));
                     var28.spriteShortArray11[var137] = (short)((var5[var4++] & 255) + ((var5[var4++] & 255) << 8));
                  }

                  if ((var28.spriteIntegerValue22 & 16384) != 0) {
                     var28.spriteByteArray07[var137] = var5[var4++];
                  }

                  var28.spriteByteArray06[var137] = var5[var4++];
               }
            }

            var5 = var18;
            SpriteResourceDecoder var29 = var17;
            if ((var17.spriteIntegerValue22 & 32768) != 0) {
               var122 = (short)((var18[var4++] & 255) + ((var18[var4++] & 255) << 8));
               if ((var17.spriteIntegerValue22 & 1024) == 0) {
                  var17.spriteByteArray04 = new sbyte[var122 << 2];
                  JSystem.arraycopy(var18, var4, var17.spriteByteArray04, 0, var122 << 2);
                  var4 += var122 << 2;
               } else {
                  var17.spriteShortArray08 = new short[var122 << 2];
                  var4 = decodePngPixels(var18, var4, var17.spriteShortArray08, 0, var122 << 2, false);
               }
            }

            if ((var122 = (short)((var18[var4++] & 255) + ((var18[var4++] & 255) << 8))) > 0) {
               var17.spriteByteArray02 = new sbyte[var122];
               var17.spriteShortArray06 = new short[var122];
               if ((var17.spriteIntegerValue22 & 32768) != 0) {
                  var17.spriteShortArray09 = new short[var122 + 1];
               }

               short var140 = 0;

               for (int var143 = 0; var143 < var122; var143++) {
                  var29.spriteByteArray02[var143] = var5[var4++];
                  var29.spriteShortArray06[var143] = (short)((var5[var4++] & 255) + ((var5[var4++] & 255) << 8));
                  if ((var29.spriteIntegerValue22 & 32768) != 0 && (var29.spriteIntegerValue22 & 32768) != 0) {
                     var29.spriteShortArray09[var143] = var140;
                     var140 = (short)(var140 + var5[var4++]);
                  }
               }

               if ((var29.spriteIntegerValue22 & 32768) != 0) {
                  var29.spriteShortArray09[var29.spriteShortArray09.Length - 1] = var140;
               }

               if ((var29.spriteIntegerValue22 & 4096) == 0) {
                  int var144 = var122 << 2;
                  if ((var29.spriteIntegerValue22 & 1024) == 0) {
                     var29.spriteByteArray03 = new sbyte[var144];

                     for (int var125 = 0; var125 < var144; var125++) {
                        var29.spriteByteArray03[var125] = var5[var4++];
                     }
                  } else {
                     var29.spriteShortArray07 = new short[var144];

                     for (int var126 = 0; var126 < var144; var126++) {
                        var29.spriteShortArray07[var126] = (short)((var5[var4++] & 255) + ((var5[var4++] & 255) << 8));
                     }
                  }
               }
            }

            var5 = var18;
            SpriteResourceDecoder var30 = var17;
            if ((var122 = (short)((var18[var4++] & 255) + ((var18[var4++] & 255) << 8))) > 0) {
               var17.spriteByteArray09 = new sbyte[var122];
               var17.spriteByteArray10 = new sbyte[var122];
               var17.spriteShortArray13 = new short[var122];
               var17.spriteShortArray14 = new short[var122];
               var17.spriteByteArray11 = new sbyte[var122];

               for (int var138 = 0; var138 < var122; var138++) {
                  var30.spriteByteArray09[var138] = var5[var4++];
                  var30.spriteByteArray10[var138] = var5[var4++];
                  if ((var30.spriteIntegerValue22 & 262144) == 0) {
                     var30.spriteShortArray13[var138] = (short)var5[var4++];
                     var30.spriteShortArray14[var138] = (short)var5[var4++];
                  } else {
                     var30.spriteShortArray13[var138] = (short)((var5[var4++] & 255) + ((var5[var4++] & 255) << 8));
                     var30.spriteShortArray14[var138] = (short)((var5[var4++] & 255) + ((var5[var4++] & 255) << 8));
                  }

                  var30.spriteByteArray11[var138] = var5[var4++];
               }
            }

            var5 = var18;
            SpriteResourceDecoder var31 = var17;
            if ((var122 = (short)((var18[var4++] & 255) + ((var18[var4++] & 255) << 8))) > 0) {
               var17.spriteByteArray08 = new sbyte[var122];
               var17.spriteShortArray12 = new short[var122];

               for (int var141 = 0; var141 < var122; var141++) {
                  var31.spriteByteArray08[var141] = var5[var4++];
                  var31.spriteShortArray12[var141] = (short)((var5[var4++] & 255) + ((var5[var4++] & 255) << 8));
               }
            }

            if (var17.spriteIntegerValue20 <= 0) {
               if (spriteBooleanFlag09) {
                  JSystem.gc();
               }
            } else {
               if ((var17.spriteIntegerValue22 & 16777216) != 0) {
                  bool var139 = true;
                  var5 = var18;
                  SpriteResourceDecoder var32 = var17;
                  if ((var17.spriteIntegerValue22 & 16777216) != 0 && var4 < var18.Length) {
                     short var142 = (short)((var18[var4++] & 255) + ((var18[var4++] & 255) << 8));
                     var17.spriteIntegerValue23 = var18[var4++] & 255;
                     var17.spriteIntegerValue24 = var18[var4++] & 255;
                     if (var17.spriteIntegerValue24 == 0) {
                        var17.spriteIntegerValue24 = 256;
                     }

                     if (var17.spriteIntegerMatrix01 == null) {
                        var17.spriteIntegerMatrix01 = new int[16][];
                     }

                     for (int var145 = 0; var145 < var32.spriteIntegerValue23; var145++) {
                        var32.spriteIntegerMatrix01[var145] = new int[var32.spriteIntegerValue24];
                        if (var142 == -30584) {
                           for (int var133 = 0; var133 < var32.spriteIntegerValue24; var133++) {
                              int var153;
                              if ((
                                    (
                                          var153 = (var5[var4++] & 255)
                                             + ((var5[var4++] & 255) << 8)
                                             + ((var5[var4++] & 255) << 16)
                                             + ((var5[var4++] & 255) << 24)
                                       )
                                       & unchecked((int)0xFF000000)
                                 )
                                 != -16777216) {
                                 var32.spriteBooleanFlag07 = true;
                                 if ((var153 & unchecked((int)0xFF000000)) != 0) {
                                    var32.spriteBooleanFlag08 = true;
                                 }
                              }

                              var32.spriteIntegerMatrix01[var145][var133] = var153;
                           }
                        } else if (var142 == 17476) {
                           for (int var132 = 0; var132 < var32.spriteIntegerValue24; var132++) {
                              short var152;
                              if (((var152 = (short)((var5[var4++] & 255) + ((var5[var4++] & 255) << 8))) & '\uf000') != 61440) {
                                 var32.spriteBooleanFlag07 = true;
                                 if ((var152 & '\uf000') != 0) {
                                    var32.spriteBooleanFlag08 = true;
                                 }
                              }

                              var32.spriteIntegerMatrix01[var145][var132] = (var152 & '\uf000') << 16
                                 | (var152 & '\uf000') << 12
                                 | (var152 & 3840) << 12
                                 | (var152 & 3840) << 8
                                 | (var152 & 240) << 8
                                 | (var152 & 240) << 4
                                 | (var152 & 15) << 4
                                 | var152 & 15;
                           }
                        } else if (var142 == 21781) {
                           for (int var131 = 0; var131 < var32.spriteIntegerValue24; var131++) {
                              short var151 = (short)((var5[var4++] & 255) + ((var5[var4++] & 255) << 8));
                              int var159 = -16777216;
                              if ((var151 & '耀') != 32768) {
                                 var159 = 0;
                                 var32.spriteBooleanFlag07 = true;
                              }

                              int var162;
                              if ((var162 = var159 | (var151 & 31744) << 9 | (var151 & 992) << 6 | (var151 & 31) << 3) == 16253176) {
                                 var162 = 16711935;
                              }

                              var32.spriteIntegerMatrix01[var145][var131] = var162;
                           }
                        } else if (var142 == 25861) {
                           for (int var130 = 0; var130 < var32.spriteIntegerValue24; var130++) {
                              short var150 = (short)((var5[var4++] & 255) + ((var5[var4++] & 255) << 8));
                              int var158 = -16777216;
                              if ((var150 & '\uffff') == 63519) {
                                 var158 = 0;
                                 var32.spriteBooleanFlag07 = true;
                              }

                              int var161;
                              if ((var161 = var158 | (var150 & '\uf800') << 8 | (var150 & 2016) << 5 | (var150 & 31) << 3) == 16253176) {
                                 var161 = 16711935;
                              }

                              var32.spriteIntegerMatrix01[var145][var130] = var161;
                           }
                        } else if (var142 == -30712) {
                           var32.spriteBooleanFlag08 = false;

                           for (int var129 = 0; var129 < var32.spriteIntegerValue24; var129++) {
                              int var149;
                              if ((var149 = (var5[var4++] & 255) + ((var5[var4++] & 255) << 8) + ((var5[var4++] & 255) << 16)) == 16711935) {
                                 var32.spriteBooleanFlag07 = true;
                              } else {
                                 var149 |= -16777216;
                              }

                              var32.spriteIntegerMatrix01[var145][var129] = var149;
                           }
                        }
                     }

                     var32.spriteShortValue02 = (short)((var5[var4++] & 255) + ((var5[var4++] & 255) << 8));
                     if (var32.spriteShortValue02 == -23978 || var32.spriteShortValue02 == -23198) {
                        var32.spriteBooleanFlag07 = true;
                        var32.spriteBooleanFlag08 = true;
                     }

                     if (var32.spriteShortValue02 == 25840 || var32.spriteShortValue02 == -22976) {
                        int var146 = var32.spriteIntegerValue24 - 1;
                        var32.spriteIntegerValue26 = 1;

                        for (var32.spriteIntegerValue27 = 0; var146 != 0; var32.spriteIntegerValue27++) {
                           var146 >>= 1;
                           var32.spriteIntegerValue26 <<= 1;
                        }

                        var32.spriteIntegerValue26--;
                     }

                     if (var32.spriteIntegerValue20 > 0) {
                        var32.spriteIntegerArray05 = new int[var32.spriteIntegerValue20];
                        int var147 = 0;
                        var122 = var4;

                        for (int var154 = 0; var154 < var32.spriteIntegerValue20; var154++) {
                           int var160;
                           if ((var32.spriteIntegerValue22 & 128) != 0) {
                              var160 = (var5[var4++] & 255) + ((var5[var4++] & 255) << 8) + ((var5[var4++] & 255) << 16) + ((var5[var4++] & 255) << 24);
                           } else {
                              var160 = (short)((var5[var4++] & 255) + ((var5[var4++] & 255) << 8));
                           }

                           var32.spriteIntegerArray05[var154] = var147;
                           var147 += var160;
                           var4 += var160;
                        }

                        int var109 = var122;
                        var32.spriteByteArray12 = new sbyte[var147];

                        for (int var148 = 0; var148 < var32.spriteIntegerValue20; var148++) {
                           if ((var32.spriteIntegerValue22 & 128) != 0) {
                              var122 = (var5[var109++] & 255) + ((var5[var109++] & 255) << 8) + ((var5[var109++] & 255) << 16) + ((var5[var109++] & 255) << 24);
                           } else {
                              var122 = (short)((var5[var109++] & 255) + ((var5[var109++] & 255) << 8));
                           }

                           JSystem.arraycopy(var5, var109, var32.spriteByteArray12, var32.spriteIntegerArray05[var148], var122);
                           var109 += var122;
                        }
                     }
                  }
               }

               var17.spriteShortMatrix02 = new short[16][];
               var17.spriteIntegerValue21 = -1;
               int var19;
               if ((var17.spriteIntegerValue22 & 4096) != 0 && (var19 = var17.getSpriteFrameCount()) > 0) {
                  int var33 = 0;
                  if ((var17.spriteIntegerValue22 & 1024) == 0) {
                     var17.spriteByteArray03 = new sbyte[var19 << 2];

                     for (int var40 = 0; var40 < var19; var40++) {
                        var17.calculateSpriteBounds(spriteIntegerArray11, var40, 0, 0, 0);
                        var17.spriteByteArray03[var33++] = (sbyte)spriteIntegerArray11[0];
                        var17.spriteByteArray03[var33++] = (sbyte)spriteIntegerArray11[1];
                        var17.spriteByteArray03[var33++] = (sbyte)(spriteIntegerArray11[2] - spriteIntegerArray11[0]);
                        var17.spriteByteArray03[var33++] = (sbyte)(spriteIntegerArray11[3] - spriteIntegerArray11[1]);
                     }
                  } else {
                     var17.spriteShortArray07 = new short[var19 << 2];

                     for (int var41 = 0; var41 < var19; var41++) {
                        var17.calculateSpriteBounds(spriteIntegerArray11, var41, 0, 0, 0);
                        var17.spriteShortArray07[var33++] = (short)spriteIntegerArray11[0];
                        var17.spriteShortArray07[var33++] = (short)spriteIntegerArray11[1];
                        var17.spriteShortArray07[var33++] = (short)(spriteIntegerArray11[2] - spriteIntegerArray11[0]);
                        var17.spriteShortArray07[var33++] = (short)(spriteIntegerArray11[3] - spriteIntegerArray11[1]);
                     }
                  }
               }

               if (spriteBooleanFlag09) {
                  JSystem.gc();
               }
            }
         } catch (System.Exception var14) {
         }
      }
   }

   // $VF: renamed from: a (boolean) void
   public void clearSpriteData(bool var1) {
      this.spriteByteArray13 = null;
      this.spriteShortMatrix03 = null;
      this.spriteIntegerMatrix01 = null;
      this.spriteByteArray12 = null;
      this.spriteIntegerArray05 = null;
      if (spriteBooleanFlag09) {
         JSystem.gc();
      }
   }

   // $VF: renamed from: a (int, int) int
   public int getFrameDuration(int var1, int var2) {
      return this.spriteByteArray10[this.spriteShortArray12[var1] + var2] & 0xFF;
   }

   // $VF: renamed from: a (int) int
   public int getAnimationFrameCount(int var1) {
      return this.spriteByteArray08[var1] & 0xFF;
   }

   // $VF: renamed from: d (int) int
   public int getSpriteFrameMetadata(int var1) {
      return this.spriteByteArray02[var1] & 0xFF;
   }

   // $VF: renamed from: b (int, int) int
   public int getSpriteFrameXOffset(int var1, int var2) {
      var1 = this.spriteShortArray12[var1] + var2;
      return this.spriteShortArray13[var1];
   }

   // $VF: renamed from: c (int, int) int
   public int getSpriteFrameYOffset(int var1, int var2) {
      var1 = this.spriteShortArray12[var1] + var2;
      return this.spriteShortArray14[var1];
   }

   // $VF: renamed from: b (int) int
   public int getSpriteWidth(int var1) {
      return (this.spriteIntegerValue22 & 1024) == 0 ? this.spriteByteArray03[(var1 << 2) + 2] & 0xFF : this.spriteShortArray07[(var1 << 2) + 2] & 65535;
   }

   // $VF: renamed from: c (int) int
   public int getSpriteHeight(int var1) {
      return (this.spriteIntegerValue22 & 1024) == 0 ? this.spriteByteArray03[(var1 << 2) + 3] & 0xFF : this.spriteShortArray07[(var1 << 2) + 3] & 65535;
   }

   // $VF: renamed from: d (int, int) int
   public int getFrameWidth(int var1, int var2) {
      var1 = this.spriteShortArray06[var1] + var2;
      return this.spriteShortArray10[var1];
   }

   // $VF: renamed from: e (int, int) int
   public int getFrameHeight(int var1, int var2) {
      var1 = this.spriteShortArray06[var1] + var2;
      return this.spriteShortArray11[var1];
   }

   // $VF: renamed from: a (int[], int, int, int, int) void
   public void calculateSpriteBounds(int[] var1, int var2, int var3, int var4, int var5) {
      spriteIntegerValue28 = Integer.MAX_VALUE;
      spriteIntegerValue29 = Integer.MAX_VALUE;
      spriteIntegerValue30 = Integer.MIN_VALUE;
      spriteIntegerValue31 = Integer.MIN_VALUE;
      spriteIntegerValue19 = 1;
      this.drawSpriteFrameTransformed(null, var2, 0, 0, 0, 0, 0);
      spriteIntegerValue19 = 0;
      var1[0] = spriteIntegerValue28;
      var1[1] = spriteIntegerValue29;
      var1[2] = spriteIntegerValue30;
      var1[3] = spriteIntegerValue31;
   }

   // $VF: renamed from: a () int
   public int getSpriteFrameCount() {
      return this.spriteByteArray02 == null ? 0 : this.spriteByteArray02.Length;
   }

   // $VF: renamed from: a (int) boolean
   public bool hasSpriteImageData(int var1) {
      return this.spriteIntegerArray05 == null ? false : this.spriteByteArray12 != null;
   }

   // $VF: renamed from: a (int, int[], int, int) int[]
   public int[] copySpritePalette(int var1, int[] var2, int var3, int var4) {
      int var5 = 0;
      var4 = var1;
      SpriteResourceDecoder var12 = this;
      int var6 = this.getSpriteFrameMetadata(var1);
      int var7 = 0;

      for (int var10 = 0; var10 < var6; var10++) {
         int var8 = var12.spriteShortArray06[var4] + var10;
         int var9 = var12.spriteByteArray06[var8] & 255;
         var8 = var12.spriteByteArray05[var8] & 255;
         if ((var9 & 16) == 0 && var12.spriteByteArray14[var8] == 5 && (var5 == -1 || var5 == var8)) {
            var7++;
         }
      }

      if (var7 <= 0) {
         return null;
      } else {
         sbyte var17 = 0;
         int[] var11 = var2;
         int var14 = var3 = var7 << 1;
         if (var2 == null || var2.Length < var14) {
            var11 = new int[var14];
         }

         var3 = this.getSpriteFrameMetadata(var1);

         for (int var21 = 0; var21 < var3; var21++) {
            var5 = this.spriteShortArray06[var1] + var21;
            var6 = this.spriteByteArray06[var5] & 255;
            var5 = this.spriteByteArray05[var5] & 255;
            if ((var6 & 16) == 0 && this.spriteByteArray14[var5] == 5 && 0 == var5) {
               var11[var17] = this.getFrameWidth(var1, var21);
               var11[var17 + 1] = this.getFrameHeight(var1, var21);
               var17 += 2;
            }
         }

         return var11;
      }
   }

   // $VF: renamed from: a (int[]) int[]
   public static int[] acquireColorBuffer(int[] var0) {
      if (var0 != null && var0 == spriteIntegerArray03) {
         if (var0 != null && var0 == spriteIntegerArray04) {
            return null;
         } else {
            if (spriteIntegerArray04 == null) {
               spriteIntegerArray04 = new int[51200];
            }

            return spriteIntegerArray04;
         }
      } else {
         if (spriteIntegerArray03 == null) {
            spriteIntegerArray03 = new int[51200];
         }

         return spriteIntegerArray03;
      }
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, int, int, int, int, int, int, int) void
   public void drawSpriteFrame(Graphics var1, int var2, int var3, int var4, int var5, int var6, int var7, int var8) {
      var2 = this.spriteShortArray12[var2] + var3;
      var3 = this.spriteByteArray09[var2] & 255;
      int var13 = this.spriteShortArray13[var2];
      int var14 = this.spriteShortArray14[var2];
      int var9 = this.spriteByteArray11[var2] & 15;
      if ((var6 & 1) != 0) {
         var9 = spriteIntegerArray07[var9 & 7] | var9 & -8;
         var13 = -var13;
      }

      if ((var6 & 2) != 0) {
         var9 = spriteIntegerArray08[var9 & 7] | var9 & -8;
         var14 = -var14;
      }

      if ((var6 & 4) != 0) {
         var9 = spriteIntegerArray09[var9 & 7] | var9 & -8;
         var2 = var13;
         var13 = -var14;
         var14 = var2;
      }

      this.drawSpriteFrameTransformed(var1, var3, var4 + var13, var5 + var14, var9, 0, 0);
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, int, int, int, int, int, int) void
   public void drawSpriteFrameTransformed(Graphics var1, int var2, int var3, int var4, int var5, int var6, int var7) {
      int var8;
      if ((var8 = this.getSpriteFrameMetadata(var2)) > 0) {
         for (int var9 = 0; var9 < var8; var9++) {
            int var12 = this.spriteShortArray06[var2] + var9;
            int var13 = this.spriteByteArray06[var12] & 255;
            int var19 = this.spriteByteArray05[var12] & 255;
            if ((this.spriteIntegerValue22 & 16384) != 0) {
               this.spriteIntegerValue25 = this.spriteByteArray07[var12] & 255;
            }

            int var20 = var19;
            if ((var13 & 16) == 0 && this.spriteIntegerValue21 >= 0) {
               var19 = this.spriteShortMatrix02[this.spriteIntegerValue21][var19];
            }

            int var23 = 0;
            int var24 = 0;
            if ((var13 & 16) == 0) {
               var23 = this.spriteShortArray02[var19] & '\uffff';
               var24 = this.spriteShortArray03[var19] & '\uffff';
            }

            int var21 = this.spriteShortArray10[var12];
            int var22 = this.spriteShortArray11[var12];
            if ((var13 & 4) != 0) {
               var12 = var23;
               var23 = var24;
               var24 = var12;
            }

            if ((var5 & 1) != 0) {
               var13 = spriteIntegerArray07[var13 & 7] | var13 & -8;
               var21 = -var21 - var23;
            }

            if ((var5 & 2) != 0) {
               var13 = spriteIntegerArray08[var13 & 7] | var13 & -8;
               var22 = -var22 - var24;
            }

            if ((var5 & 4) != 0) {
               var13 = spriteIntegerArray09[var13 & 7] | var13 & -8;
               var12 = var21;
               var21 = -var22 - var24;
               var22 = var12;
            }

            int var14 = var3 + var21;
            int var15 = var4 + var22;
            if ((var13 & 16) != 0) {
               this.drawSpriteFrameTransformed(var1, var19, var14, var15, var13 & 15, var6, var7);
            } else {
               this.drawSpriteBounds(var1, var20, var14, var15, var13 & 15);
            }
         }
      }
   }

   // $VF: renamed from: a (int, int, int, int) void
   public void configureSpriteImage(int var1, int var2, int var3, int var4) {
      this.clearSpriteImageCache(var1);
      if (this.spriteIntegerValue20 != 0) {
         if (var3 == -1) {
            var3 = this.spriteIntegerValue20 - 1;
         }

         if ((this.spriteIntegerValue22 & 16777224) != 0) {
            var2 = this.spriteIntegerValue25;
            this.spriteIntegerValue25 = var1;
            if (spriteBooleanFlag09) {
               JSystem.gc();
            }

            for (int var15 = 0; var15 <= var3; var15++) {
               if (this.spriteByteArray14[var15] == 0) {
                  int var5 = this.spriteShortArray02[var15] & '\uffff';
                  int var6 = this.spriteShortArray03[var15] & '\uffff';
                  int[] var7;
                  if (var5 > 0 && var6 > 0 && (var7 = this.getSpritePalette(var15)) != null) {
                     int[] var16 = var7;
                     int var11 = var5 * var6;
                     bool var12 = false;

                     for (int var13 = 0; var13 < var11; var13++) {
                        if ((var16[var13] & unchecked((int)0xFF000000)) != -16777216) {
                           var12 = true;
                           break;
                        }
                     }

                     this.spriteImageReferenceArrayArray01[var1][var15] = Image.createRGBImage(var16, var5, var6, var12);
                  }
               }
            }

            if (spriteBooleanFlag09) {
               JSystem.gc();
            }

            this.spriteIntegerValue25 = var2;
         }

         if (spriteBooleanFlag09) {
            JSystem.gc();
         }
      }
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Image, int, int) void
   public void cacheSpriteImage(Image var1, int var2, int var3) {
      if (this.spriteImageReferenceArrayArray01 != null) {
         if (0 < this.spriteImageReferenceArrayArray01.Length && this.spriteImageReferenceArrayArray01[0] != null && var2 >= 0 && var2 < this.spriteImageReferenceArrayArray01[0].Length) {
            this.spriteImageReferenceArrayArray01[0][var2] = var1;
         }
      }
   }

   // $VF: renamed from: b (int) void
   public void clearSpriteImageCache(int var1) {
      if (this.spriteImageReferenceArrayArray01 == null) {
         this.spriteImageReferenceArrayArray01 = new Image[this.spriteIntegerValue23][];
      }

      if (this.spriteImageReferenceArrayArray01[var1] == null) {
         this.spriteImageReferenceArrayArray01[var1] = new Image[this.spriteIntegerValue20];
      }
   }

   // $VF: renamed from: e (int) int
   public int getSpritePaletteIndex(int var1) {
      if (this.spriteShortArray05 != null) {
         for (sbyte var2 = 0; var2 < this.spriteShortArray05.Length; var2 += 2) {
            if (this.spriteShortArray05[var2] == var1) {
               return this.spriteShortArray05[var2 + 1];
            }
         }
      }

      return -1;
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, int, int, int, int) void
   public void drawSpriteBounds(Graphics var1, int var2, int var3, int var4, int var5) {
      if (this.spriteIntegerValue21 >= 0) {
         var2 = this.spriteShortMatrix02[this.spriteIntegerValue21][var2];
      }

      int var6 = this.spriteShortArray02[var2] & '\uffff';
      int var7 = this.spriteShortArray03[var2] & '\uffff';
      int var8 = var6;
      int var9 = var7;
      if ((var5 & 4) != 0) {
         int var10 = var6;
         var6 = var7;
         var7 = var10;
      }

      if (this.spriteByteArray14[var2] != 0 && var1 != null) {
         var1.setColor(this.spriteIntegerArray10[var2]);
         switch (this.spriteByteArray14[var2]) {
            case 1:
               GameCanvas.drawGraphicsRectangle(var3, var4, --var6, --var7);
               return;
            case 2:
               if ((this.spriteIntegerArray10[var2] & unchecked((int)0xFF000000)) != -16777216 && (this.spriteIntegerArray10[var2] & unchecked((int)0xFF000000)) != 0) {
                  GameCanvas.setScreenSize(this.spriteIntegerArray10[var2]);
                  GameCanvas.copyGraphicsRegion(var1, var3, var4, var6, var7);
                  return;
               }

               GameCanvas.fillGraphicsRectangle(var1, var3, var4, var6, var7);
               return;
            case 3:
            case 4:
               int var25;
               if ((var25 = this.getSpritePaletteIndex(var2)) == -1) {
                  return;
               }

               int var28 = this.spriteShortArray04[var25];
               int var30 = this.spriteShortArray04[var25 + 1];
               if ((var5 & 1) != 0) {
                  var28 = 90 - var28;
               }

               if ((var5 & 2) != 0) {
                  var28 = -var28;
                  var30 = -var30;
               }

               if ((var5 & 4) != 0) {
                  var28 -= 90;
               }

               if (this.spriteByteArray14[var2] != 3) {
                  var1.fillArc(var3, var4, var6, var7, var28, var30);
                  return;
               }

               var1.drawArc(var3, var4, var6, var7, var28, var30); goto case 5;
            case 5:
            default:
               break;
            case 6:
            case 7:
               int var24;
               if ((var24 = this.getSpritePaletteIndex(var2)) != -1) {
                  short var27 = this.spriteShortArray04[var24];
                  short var29 = this.spriteShortArray04[var24 + 1];
                  short var32 = this.spriteShortArray04[var24 + 2];
                  short var18 = this.spriteShortArray04[var24 + 3];
                  if (this.spriteByteArray14[var2] == 6) {
                     var1.drawLine(var3, var4, var3 + var27, var4 + var29);
                     var1.drawLine(var3 + var27, var4 + var29, var3 + var32, var4 + var18);
                     var1.drawLine(var3, var4, var3 + var32, var4 + var18);
                     return;
                  }

                  var1.fillTriangle(var3, var4, var3 + var27, var4 + var29, var3 + var32, var4 + var18);
               } break;
         }
      } else if (var6 > 0 && var7 > 0) {
         if (var1 != null) {
            int var22 = var1.getClipX();
            int var11 = var1.getClipY();
            int var12 = var1.getClipWidth();
            int var13 = var1.getClipHeight();
            if (var3 + var6 < var22 || var4 + var7 < var11 || var3 >= var22 + var12 || var4 >= var11 + var13) {
               return;
            }
         }

         int[] var23 = null;
         Image var26 = null;
         if ((this.spriteIntegerValue22 & 16777224) != 0) {
            if (this.spriteImageReferenceArrayArray01 != null && this.spriteImageReferenceArrayArray01[this.spriteIntegerValue25] != null) {
               var26 = this.spriteImageReferenceArrayArray01[this.spriteIntegerValue25][var2];
            }

            if (this.spriteIntegerCube01 != null && this.spriteIntegerCube01[this.spriteIntegerValue25] != null) {
               var23 = this.spriteIntegerCube01[this.spriteIntegerValue25][var2];
            }

            bool var31 = this.spriteBooleanFlag07;
            if (var26 == null) {
               int[] var17 = var23;
               if (var23 == null) {
                  var17 = this.getSpritePalette(var2);
               }

               if (var17 == null) {
                  return;
               }

               GameCanvas.drawTransformedImage(var1, var17, 0, var8, var3, var4, var8, var9, var31, var31, var5);
               return;
            }

            var6 = var26.getWidth();
            var7 = var26.getHeight();
            int var10006 = spriteIntegerArray06[var5 & 7];
            bool var14 = false;
            bool var15 = false;
            if (var26 != null) {
               if (spriteIntegerArray06[var5 & 7] == 0) {
                  var1.drawImage(var26, var3, var4, 0);
                  return;
               }

               var1.drawRegion(var26, 0, 0, var6, var7, spriteIntegerArray06[var5 & 7], var3, var4, 0);
            }
         }
      }
   }

   // $VF: renamed from: a (int) int[]
   public int[] getSpritePalette(int var1) {
      return this.hasSpriteImageData(var1) && this.decodeSpriteImage(this.spriteByteArray12, this.spriteIntegerArray05[var1], this.spriteShortArray02[var1] & '\uffff', this.spriteShortArray03[var1] & '\uffff')
         ? spriteIntegerArray03
         : null;
   }

   // $VF: renamed from: a (byte[], int, int, int) boolean
   public bool decodeSpriteImage(sbyte[] var1, int var2, int var3, int var4) {
      int var5 = 0;
      int var13 = var3 * var4;
      if (spriteIntegerArray03 == null) {
         spriteIntegerArray03 = new int[51200];
      }

      object var21 = null;
      if (this.spriteIntegerMatrix01 == null) {
         return false;
      } else {
         int[] var22;
         if ((var22 = this.spriteIntegerMatrix01[this.spriteIntegerValue25]) == null) {
            return false;
         } else {
            int var6 = 0;
            if (this.spriteShortValue02 != 25840) {
               if (this.spriteShortValue02 == 10225) {
                  while (var5 < var13) {
                     int var50;
                     if ((var50 = var1[var2++] & 255) > 127) {
                        int var9 = var1[var2++] & 255;
                        var6 = var22[var9];
                        var50 -= 128;

                        while (var50-- > 0) {
                           spriteIntegerArray03[var5++] = var6;
                        }
                     } else {
                        spriteIntegerArray03[var5++] = var22[var50];
                     }
                  }
               } else if (this.spriteShortValue02 == 22258) {
                  var2--;
                  var5--;
                  var13--;

                  while (var5 < var13) {
                     int var41;
                     if ((var41 = var1[++var2]) < 0) {
                        var41 += 128;

                        while (true) {
                           var5++;
                           spriteIntegerArray03[var5] = var22[var1[++var2] & 255];
                           if (--var41 <= 0) {
                              break;
                           }
                        }
                     } else {
                        var6 = var22[var1[++var2] & 255];

                        while (true) {
                           var5++;
                           spriteIntegerArray03[var5] = var6;
                           if (--var41 <= 0) {
                              break;
                           }
                        }
                     }
                  }
               } else if (this.spriteShortValue02 == 5632) {
                  var3 = (var3 = var13 + ((var13 & 1) == 0 ? 0 : 2)) >> 1;

                  while (--var3 >= 0) {
                     sbyte var43 = var1[var2++];
                     spriteIntegerArray03[var5++] = var22[var43 >> 4 & 15];
                     spriteIntegerArray03[var5++] = var22[var43 & 15];
                  }
               } else if (this.spriteShortValue02 == 1024) {
                  var3 = (var3 = var13 + ((var13 & 3) == 0 ? 0 : 4)) >> 2;

                  while (--var3 >= 0) {
                     sbyte var44 = var1[var2++];
                     spriteIntegerArray03[var5++] = var22[var44 >> 6 & 3];
                     spriteIntegerArray03[var5++] = var22[var44 >> 4 & 3];
                     spriteIntegerArray03[var5++] = var22[var44 >> 2 & 3];
                     spriteIntegerArray03[var5++] = var22[var44 & 3];
                  }
               } else if (this.spriteShortValue02 == 512) {
                  var3 = (var3 = var13 + ((var13 & 7) == 0 ? 0 : 8)) >> 3;

                  while (--var3 >= 0) {
                     sbyte var45 = var1[var2++];
                     spriteIntegerArray03[var5++] = var22[var45 >> 7 & 1];
                     spriteIntegerArray03[var5++] = var22[var45 >> 6 & 1];
                     spriteIntegerArray03[var5++] = var22[var45 >> 5 & 1];
                     spriteIntegerArray03[var5++] = var22[var45 >> 4 & 1];
                     spriteIntegerArray03[var5++] = var22[var45 >> 3 & 1];
                     spriteIntegerArray03[var5++] = var22[var45 >> 2 & 1];
                     spriteIntegerArray03[var5++] = var22[var45 >> 1 & 1];
                     spriteIntegerArray03[var5++] = var22[var45 & 1];
                  }
               } else if (this.spriteShortValue02 == -23198) {
                  while (--var13 >= 0) {
                     spriteIntegerArray03[var5++] = (var1[var2++] & 255) << 24 | var22[var1[var2++] & 255] & 16777215;
                  }
               } else if (this.spriteShortValue02 == -23978) {
                  while (var5 < var13) {
                     int var46;
                     if ((var46 = var1[var2++] & 255) > 127) {
                        var46 -= 128;

                        while (var46-- > 0) {
                           spriteIntegerArray03[var5++] = var22[var1[var2++] & 255];
                        }
                     } else {
                        var6 = var22[var1[var2++] & 255];

                        while (var46-- > 0) {
                           spriteIntegerArray03[var5++] = var6;
                        }
                     }
                  }

                  int var35 = 0;

                  while (var35 < var13) {
                     int var48;
                     if ((var48 = var1[var2++] & 255) == 254) {
                        int var8 = var1[var2++] & 255;

                        for (int var49 = var1[var2++] & 255; var8-- > 0; var35++) {
                           spriteIntegerArray03[var35] = var49 << 24 | spriteIntegerArray03[var35] & 16777215;
                        }
                     } else {
                        spriteIntegerArray03[var35] = var48 << 24 | spriteIntegerArray03[var35] & 16777215;
                        var35++;
                     }
                  }
               }
            } else {
               while (var5 < var13) {
                  int var7 = var1[var2++] & 255;
                  var6 = var22[var7 & this.spriteIntegerValue26];
                  var7 >>= this.spriteIntegerValue27;

                  while (var7-- >= 0) {
                     spriteIntegerArray03[var5++] = var6;
                  }
               }
            }

            return true;
         }
      }
   }

   // $VF: renamed from: a (short[]) void
   public void setSpritePaletteData(short[] var1) {
      this.spriteShortValue01 = var1[0];
      this.spriteShortMatrix01 = new short[this.spriteShortValue01][];
      int var2 = 1;

      for (int var3 = 0; var3 < this.spriteShortValue01; var3++) {
         this.spriteShortMatrix01[var3] = new short[2];
         this.spriteShortMatrix01[var3][0] = var1[var2++];
         this.spriteShortMatrix01[var3][1] = var1[var2++];
      }

      int var10 = var2;

      while (var10 < var1.Length) {
         short var9 = var1[var10++];
         short var4;
         short[] var5;
         (var5 = new short[((var4 = var1[var10++]) << 1) + 2])[0] = this.spriteShortMatrix01[var9][0];
         var5[1] = this.spriteShortMatrix01[var9][1];

         for (int var6 = 0; var6 < var4; var6++) {
            var5[(var6 << 1) + 2] = var1[var10++];
            var5[(var6 << 1) + 3] = var1[var10++];
         }

         this.spriteShortMatrix01[var9] = var5;
      }

      this.spriteIntegerValue12 = -this.getFrameHeight(0, 0);
      int var7 = this.getFrameHeight(0, 1);
      this.spriteIntegerValue09 = this.spriteIntegerValue12 + var7;
      this.spriteIntegerValue10 = this.getFrameHeight(0, 2) - this.getFrameHeight(0, 1);
      this.spriteIntegerValue11 = this.getFrameWidth(this.getSpriteColorIndex(32), 0);
   }

   // $VF: renamed from: f (int) int
   public int getSpriteColorIndex(int var1) {
      if (this.spriteShortMatrix01 == null) {
         return 0;
      } else {
         int var2 = var1 % this.spriteShortValue01;
         if (this.spriteShortMatrix01[var2][0] == var1) {
            return this.spriteShortMatrix01[var2][1];
         } else {
            sbyte var3 = 2;
            int var4 = this.spriteShortMatrix01[var2].Length;

            while (var3 < var4 && this.spriteShortMatrix01[var2][var3] != var1) {
               var3 += 2;
            }

            return var3 >= var4 ? 1 : this.spriteShortMatrix01[var2][var3 + 1];
         }
      }
   }

   // $VF: renamed from: b () int
   public int getSpriteImageWidth() {
      return this.spriteIntegerValue10;
   }

   // $VF: renamed from: c () int
   public int getSpriteImageHeight() {
      return this.spriteIntegerValue09;
   }

   // $VF: renamed from: d () int
   public int getSpriteCanvasWidth() {
      return this.spriteIntegerValue09;
   }

   // $VF: renamed from: a (java.lang.String, int, boolean) short[]
   public short[] loadBitmapFont(string var1, int var2, bool var3) {
      if (spriteShortArray01 == null) {
         spriteShortArray01 = new short[300];
      }

      int var3i = var1.length();
      short var4 = 0;
      short var5 = 1;
      short var6 = 0;
      bool var7 = this.spriteBooleanFlag06;
      bool var8 = false;
      short var9 = 0;
      bool var10 = this.spriteBooleanFlag06;

      for (int var11 = 0; var11 < var3i; var11++) {
         int var12;
         if ((var12 = var1.charAt(var11)) == 32) {
            if (var12 == 32) {
               var4 = (short)(var4 + this.spriteIntegerValue11);
            }

            var6 = (short)var11;
            var7 = var10;
            var8 = true;
            var9 = 0;
            if (var4 > var2) {
               var8 = false;

               for (int var23 = var6; var23 >= 0 && var1.charAt(var23) == ' '; var23--) {
                  if (var1.charAt(var23) == ' ') {
                     var4 = (short)(var4 - this.spriteIntegerValue11);
                  }
               }

               while (var6 < var3i && var1.charAt(var6) == ' ') {
                  var6++;
               }

               var11 = --var6;
               var10 = var10;
               spriteShortArray01[var5++] = (short)(var6 + 1);
               spriteShortArray01[var5++] = (short)var4;
               var4 = 0;
            }
         } else if (var12 == 92) {
            if (var1.charAt(++var11) == '^') {
               var10 = !var10;
            }
         } else if (var12 == 10) {
            spriteShortArray01[var5++] = (short)var11;
            spriteShortArray01[var5++] = var4;
            var4 = 0;
            var9 = 0;
         } else {
            if (var12 < 32) {
               if (var12 == 1) {
                  var11++;
                  continue;
               }

               if (var12 != 2) {
                  continue;
               }

               var12 = var1.charAt(++var11);
            } else {
               var12 = this.getSpriteColorIndex(var12);
            }

            if (var12 > this.getSpriteFrameCount()) {
               var12 = 0;
            }

            int var22 = this.getFrameWidth(var12, 0);
            if (var10) {
               var22++;
            }

            var9 = (short)(var9 + var22);
            if ((var4 = (short)(var4 + var22)) > var2 && var8) {
               var8 = false;

               for (int var20 = var6; var20 >= 0 && var1.charAt(var20) == ' '; var20--) {
                  if (var1.charAt(var20) == ' ') {
                     var4 = (short)(var4 - this.spriteIntegerValue11);
                  }
               }

               spriteShortArray01[var5++] = (short)(var6 + 1);
               spriteShortArray01[var5++] = (short)(var4 - var9);
               var4 = 0;
               var11 = var6;
               var10 = var7;
            }
         }
      }

      spriteShortArray01[var5++] = (short)var3i;
      spriteShortArray01[var5++] = var4;
      spriteShortArray01[0] = (short)(var5 / 2);
      return spriteShortArray01;
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, java.lang.String, short[], int, int, int, int, int, int) void
   public void drawBitmapText(Graphics var1, string var2, short[] var3, int var4, int var5, int var6, int var7, int var8, int var9) {
      short var14 = var3[0];
      var9 = this.spriteIntegerValue09;
      short var15 = var14;
      if (var14 + 0 > var14) {
         var15 = var14;
      }

      int var17 = this.spriteIntegerValue10 + var9;
      if ((var8 & 32) != 0) {
         var5 -= var17 * (var15 - 1);
      } else if ((var8 & 2) != 0) {
         var5 -= var17 * (var15 - 1) >> 1;
      }

      spriteIntegerValue06 = this.spriteIntegerValue25;
      int var10 = 0;

      for (int var11 = 0; var11 < var14 && var10 <= var15 - 1; var10++) {
         spriteIntegerValue14 = var11 > 0 ? var3[(var11 - 1 << 1) + 1] : 0;
         spriteIntegerValue15 = var3[(var11 << 1) + 1];
         if (spriteIntegerValue14 < var2.length() && var2.charAt(spriteIntegerValue14) == '\n') {
            spriteIntegerValue14++;
         }

         int var12 = var4;
         int var13 = var5 + var10 * var17;
         if ((var8 & 43) != 0) {
            if ((var8 & 8) != 0) {
               var12 = var4 - var3[var11 + 1 << 1];
            } else if ((var8 & 1) != 0) {
               var12 = var4 - (var3[var11 + 1 << 1] >> 1);
            }

            if ((var8 & 32) != 0) {
               var13 -= this.spriteIntegerValue09;
            } else if ((var8 & 2) != 0) {
               var13 -= this.spriteIntegerValue09 >> 1;
            }
         }

         this.drawBitmapTextLine(var1, var2, var12, var13, 0, false);
         var11++;
      }

      spriteIntegerValue14 = -1;
      spriteIntegerValue15 = -1;
      spriteIntegerValue16 = -1;
      this.spriteIntegerValue25 = spriteIntegerValue06;
   }

   // $VF: renamed from: a (java.lang.String, char[]) void
   public void configureBitmapFont(string var1, char[] var2) {
      if (var1 != null || var2 != null) {
         spriteIntegerValue07 = 0;
         spriteIntegerValue08 = this.spriteIntegerValue09;
         int var3 = 0;
         bool var4 = var1 != null;
         int var5 = spriteIntegerValue14 >= 0 ? spriteIntegerValue14 : 0;
         int var6;
         if (var4) {
            var6 = spriteIntegerValue15 >= 0 ? spriteIntegerValue15 : var1.length();
         } else {
            var6 = spriteIntegerValue15 >= 0 ? spriteIntegerValue15 : var2.Length;
         }

         bool var7 = this.spriteBooleanFlag06;

         for (int var9 = var5; var9 < var6; var9++) {
            int var8;
            if ((var8 = var4 ? var1.charAt(var9) : var2[var9]) == 92) {
               var9++;
               if ((var4 ? var1.charAt(var9) : var2[var9]) == '^') {
                  var7 = !var7;
               }
            } else {
               int var10000;
               if (var8 > 32) {
                  var10000 = this.getSpriteColorIndex(var8);
               } else {
                  if (var8 == 32) {
                     if (var8 == 32) {
                        var3 += this.spriteIntegerValue11;
                     }
                     continue;
                  }

                  if (var8 == 32) {
                     var3 += this.spriteIntegerValue11;
                     continue;
                  }

                  if (var8 == 10) {
                     if (var3 > spriteIntegerValue07) {
                        spriteIntegerValue07 = var3;
                     }

                     var3 = 0;
                     spriteIntegerValue08 = spriteIntegerValue08 + this.spriteIntegerValue10 + this.spriteIntegerValue09;
                     continue;
                  }

                  if (var8 == 1) {
                     var9++;
                     continue;
                  }

                  if (var8 != 2) {
                     continue;
                  }

                  var9++;
                  var10000 = var4 ? var1.charAt(var9) : var2[var9];
               }

               var8 = var10000;
               var3 += this.getFrameWidth(var8, 0);
               if (var7) {
                  var3++;
               }
            }
         }

         if (var3 > spriteIntegerValue07) {
            spriteIntegerValue07 = var3;
         }

         if (spriteIntegerValue07 > 0) {
            spriteIntegerValue07 = spriteIntegerValue07;
         }
      }
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, java.lang.String, int, int, int, boolean) void
   public void drawBitmapTextLine(Graphics var1, string var2, int var3, int var4, int var5, bool var6) {
      int var20 = var3;
      object var16 = null;
      string var19 = var2;
      Graphics var18 = var1;
      SpriteResourceDecoder var17 = this;
      if (var2 != null) {
         int var21 = var4 + this.spriteIntegerValue12;
         bool var7 = var2 != null;
         this.configureBitmapFont(var2, null);
         if ((var5 & 43) != 0) {
            if ((var5 & 8) != 0) {
               var20 = var3 - spriteIntegerValue07;
            } else if ((var5 & 1) != 0) {
               var20 = var3 - (spriteIntegerValue07 >> 1);
            }

            if ((var5 & 32) != 0) {
               var21 -= spriteIntegerValue08;
            } else if ((var5 & 2) != 0) {
               var21 -= spriteIntegerValue08 >> 1;
            }
         }

         int var23 = var20;
         int var22 = var21;
         if (var6) {
            spriteIntegerValue06 = this.spriteIntegerValue25;
         }

         int var8 = spriteIntegerValue14 >= 0 ? spriteIntegerValue14 : 0;
         int var10;
         if (var7) {
            var10 = spriteIntegerValue15 >= 0 ? spriteIntegerValue15 : var2.length();
         } else {
            var10 = spriteIntegerValue15 >= 0 ? spriteIntegerValue15 : ((char[])null).Length;
         }

         if (spriteIntegerValue16 >= 0 && var10 > spriteIntegerValue16) {
            var10 = spriteIntegerValue16;
         }

         for (int var11 = var8; var11 < var10; var11++) {
            int var12;
            if ((var12 = var7 ? var19.charAt(var11) : ((char[])null)[var11]) == 92) {
               var11++;
               char var24;
               if ((var24 = var7 ? var19.charAt(var11) : ((char[])null)[var11]) == '_') {
                  var17.spriteBooleanFlag05 = !var17.spriteBooleanFlag05;
               } else if (var24 == '^') {
                  var17.spriteBooleanFlag06 = !var17.spriteBooleanFlag06;
               } else {
                  var12 = var24 & 255;
                  var17.setGraphicsTransform(var12 - 48);
               }
            } else {
               int var31;
               if (var12 > 32) {
                  var31 = var17.getSpriteColorIndex(var12);
               } else {
                  if (var12 == 32) {
                     if (var17.spriteBooleanFlag05) {
                        int var28 = var17.getSpriteColorIndex(95);
                        var8 = var23 + (var17.spriteIntegerValue11 - var17.getFrameWidth(var28, 0) >> 1);
                        var17.drawSpriteFrameTransformed(var18, var28, var8, var22, 0, 0, 0);
                     }

                     var23 += var17.spriteIntegerValue11;
                     continue;
                  }

                  if (var12 == 10) {
                     var23 = var20;
                     var22 += var17.spriteIntegerValue10 + var17.spriteIntegerValue09;
                     continue;
                  }

                  if (var12 == 1) {
                     var11++;
                     char var26;
                     if ((var26 = var7 ? var19.charAt(var11) : ((char[])null)[var11]) < var17.spriteIntegerValue23) {
                        var17.setGraphicsTransform(var26);
                     }

                     if (var26 == 255) {
                        var17.spriteIntegerValue25 = spriteIntegerValue06;
                     }
                     continue;
                  }

                  if (var12 != 2) {
                     continue;
                  }

                  var11++;
                  var31 = var7 ? var19.charAt(var11) : ((char[])null)[var11];
               }

               var12 = var31;
               var17.drawSpriteFrameTransformed(var18, var12, var23, var22, 0, 0, 0);
               if (var17.spriteBooleanFlag05) {
                  int var9 = var17.getSpriteColorIndex(95);
                  var8 = var23 + (var17.getFrameWidth(var12, 0) - var17.getFrameWidth(var9, 0) >> 1);
                  var17.drawSpriteFrameTransformed(var18, var9, var8, var22, 0, 0, 0);
               }

               if (var17.spriteBooleanFlag06) {
                  var17.drawSpriteFrameTransformed(var18, var12, ++var23, var22, 0, 0, 0);
               }

               var23 += var17.getFrameWidth(var12, 0);
            }
         }

         if (var6) {
            var17.spriteIntegerValue25 = spriteIntegerValue06;
         }
      }
   }

   // $VF: renamed from: a (char) int
   public int getCharacterWidth(char var1) {
      if (var1 == 32) {
         return this.spriteIntegerValue11;
      } else {
         var1 = (char)this.getSpriteColorIndex(var1);
         return this.getFrameWidth(var1, 0);
      }
   }

   // $VF: renamed from: a (int) void
   public void setGraphicsTransform(int var1) {
      if (var1 < this.spriteIntegerValue23 && var1 >= 0) {
         this.spriteIntegerValue25 = var1;
      }
   }

   // $VF: renamed from: e () int
   public int getGraphicsTransform() {
      return this.spriteIntegerValue25;
   }

   // $VF: renamed from: a (byte[], int, short[], int, int, boolean) int
   public static int decodePngPixels(sbyte[] var0, int var1, short[] var2, int var3, int var4, bool var5) {
      for (int var7 = 0; var7 < var4; var7++) {
         var2[var7] = var5 ? (short)var0[var1++] : (short)((var0[var1++] & 255) + ((var0[var1++] & 255) << 8));
      }

      return var1;
   }

   // $VF: renamed from: a (int[], int, int, int) int[]
   public static int[] transformColorArray(int[] var0, int var1, int var2, int var3) {
      if ((var3 & 7) == 0) {
         return var0;
      } else {
         int[] var4 = acquireColorBuffer(var0);
         int var5 = 0;
         int var6 = 0;
         switch (var3 & 7) {
            case 1:
               int var19 = var1 * var2;
               var6 = var1 * (var2 - 1);

               for (int var30 = var2; --var30 >= 0; var6 -= var1 << 1) {
                  for (int var13 = var1; --var13 >= 0; var4[var19] = var0[var6++]) {
                     var19--;
                  }
               }
               break;
            case 2:
               int var18 = (var2 - 1) * var1;

               for (int var29 = var2; --var29 >= 0; var6 += var1) {
                  JSystem.arraycopy(var0, var6, var4, var18, var1);
                  var18 -= var1;
               }
               break;
            case 3:
               int var24 = var1 * var2 - 1;

               while (var24 >= 0) {
                  var4[var5++] = var0[var24--];
               }
               break;
            case 4:
               int var17 = var1 * var2;
               int var28 = var2;

               while (--var28 >= 0) {
                  var6 = var28;

                  for (int var12 = var1; --var12 >= 0; var6 += var2) {
                     var17--;
                     var4[var17] = var0[var6];
                  }
               }
               break;
            case 5:
               int var16 = var1 * var2;
               int var27 = var2;

               while (--var27 >= 0) {
                  var6 = var2 - 1 - var27;

                  for (int var11 = var1; --var11 >= 0; var6 += var2) {
                     var16--;
                     var4[var16] = var0[var6];
                  }
               }
               break;
            case 6:
               int var31 = (var5 = var1 * var2) - 1;
               int var26 = var2;

               while (--var26 >= 0) {
                  var6 = var31--;

                  for (int var10 = var1; --var10 >= 0; var6 -= var2) {
                     var5--;
                     var4[var5] = var0[var6];
                  }
               }
               break;
            case 7:
               int var8 = (var5 = var1 * var2) - var2;
               int var7 = var2;

               while (--var7 >= 0) {
                  var6 = var8++;

                  for (int var9 = var1; --var9 >= 0; var6 -= var2) {
                     var5--;
                     var4[var5] = var0[var6];
                  }
               } break;
         }

         return var4;
      }
   }

   public SpriteResourceDecoder() {
   }

   static SpriteResourceDecoder() {
      sbyte[] var10000 = new sbyte[]{73, 69, 78, 68};
      var10000 = new sbyte[]{8, 6, 0, 0, 0};
   }
}
}
