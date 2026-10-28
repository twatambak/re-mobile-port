// $VF: renamed from: t
public final class class_12 {
   // $VF: renamed from: a f
   private static class_27 field_114;
   // $VF: renamed from: a short[]
   private short[] field_115 = new short[]{8, 292, 293, 12, 9, 10, 11};
   // $VF: renamed from: b short[]
   private short[] field_116 = new short[]{13, 14, 15, 16, 17, 18, 19};

   public class_12(class_27 var1) {
      field_114 = var1;
   }

   // $VF: renamed from: a () void
   private static void method_20() {
      class_27.method_279(field_114.field_587.field_452, 3);
      field_114.field_587.field_463 = false;
      field_114.field_691 = true;
      field_114.field_706 = 1;
      field_114.field_619 = field_114.field_574;
   }

   // $VF: renamed from: a () boolean
   private static boolean method_21() {
      if (field_114.field_574 - field_114.field_619 > 100L) {
         field_114.field_619 = field_114.field_574;
         field_114.field_706++;
         if (field_114.field_706 >= 13) {
            field_114.field_691 = false;
            field_114.field_706 = 0;
            return true;
         }
      }

      return false;
   }

   // $VF: renamed from: b () void
   private static void method_22() {
      class_27.method_279(field_114.field_587.field_452, 7);
      field_114.field_587.field_463 = false;
      field_114.field_691 = true;
      field_114.field_706 = 13;
      field_114.field_619 = field_114.field_574;
   }

   // $VF: renamed from: b () boolean
   private static boolean method_23() {
      if (field_114.field_574 - field_114.field_619 > 100L) {
         field_114.field_619 = field_114.field_574;
         field_114.field_706++;
         if (field_114.field_706 >= 20) {
            field_114.field_691 = false;
            field_114.field_706 = 0;
            return true;
         }
      }

      return false;
   }

   // $VF: renamed from: a (int, int) void
   private void method_24(int var1, int var2) {
      field_114.method_190(291, 30, var2);

      for (int var3 = 1; var3 < 8; var3++) {
         field_114.method_190(this.field_115[var3 - 1], 33, var2 - var3);
         if (var2 - var3 < 11) {
            field_114.method_263(this.field_115[var3 - 1]);
         }
      }

      for (int var4 = 1; var4 < 8; var4++) {
         field_114.method_190(this.field_116[var4 - 1], 30, var2 - var4 - 2);
         if (var2 - var4 < 11) {
            field_114.method_263(this.field_116[var4 - 1]);
         }
      }
   }

   // $VF: renamed from: a (boolean) void
   private static void method_25(boolean var0) {
      if (class_27.field_618 != 2) {
         if (!var0) {
            if (class_27.field_618 != 0 && class_27.field_618 != 3) {
               class_27.field_618 = 0;
               class_27.field_617++;
            } else {
               class_27.field_618 = 1;
            }
         } else {
            class_27.field_618 = 2;
            class_27.field_617 = 0;
            if (class_27.field_783) {
               if (field_114.field_607 != 3 || class_27.field_785 != 5) {
                  field_114.method_145(2);
                  return;
               }
            } else if (field_114.field_607 != 3 || !class_27.method_149()) {
               field_114.method_145(2);
            }
         }
      }
   }

   // $VF: renamed from: a (p, int, int) boolean
   private static boolean method_26(class_15 var0, int var1, int var2) {
      return var0.field_131 == var1 && var0.field_132 == var2;
   }

   // $VF: renamed from: a (p, int, int) void
   private static void method_27(class_15 var0, int var1, int var2) {
      var0.field_131 = (byte)var1;
      var0.field_132 = (byte)var2;
   }

   // $VF: renamed from: a () int
   public final int method_28() {
      long var3 = field_114.field_574 - field_114.field_619;
      switch (class_27.field_617) {
         case 140:
            switch (class_27.field_618) {
               case 0:
                  method_25(false);
                  return 1;
               case 1:
                  field_114.method_222(1, true);
                  if (field_114.field_621 != null) {
                     field_114.field_621.field_130 = false;
                  }

                  if (field_114.field_623 != null) {
                     field_114.field_623.field_130 = false;
                  }

                  if (field_114.field_622 != null) {
                     field_114.field_622.field_130 = false;
                  }

                  if (method_26(field_114.field_588.field_452, 14, 5) && field_114.field_588.field_462 == 1) {
                     method_27(field_114.field_588.field_452, 13, 5);
                     field_114.method_242(field_114.field_588.field_452, 0);
                     class_27.method_279(field_114.field_588.field_452, 1);
                  } else if (method_26(field_114.field_588.field_452, 14, 5) && field_114.field_588.field_462 == 1) {
                     method_27(field_114.field_588.field_452, 13, 5);
                     field_114.method_242(field_114.field_588.field_452, 0);
                     class_27.method_279(field_114.field_588.field_452, 1);
                  }

                  method_27(field_114.field_587.field_452, 14, 5);
                  field_114.method_213();
                  field_114.method_232(
                     field_114.method_228(field_114.field_587.field_452.field_131, field_114.field_587.field_452.field_132) - class_27.field_570 / 2,
                     class_27.method_229(field_114.field_587.field_452.field_131, field_114.field_587.field_452.field_132) - class_27.field_571 / 2
                  );
                  field_114.method_233(field_114.field_587.field_452, false);
                  class_27.method_279(field_114.field_587.field_452, 7);
                  field_114.method_242(field_114.field_587.field_452, 1);
                  method_25(true);
                  return 1;
               default:
                  return 1;
            }
         case 400:
            switch (class_27.field_618) {
               case 0:
                  method_25(false);
                  return 1;
               case 1:
                  if (method_26(field_114.field_588.field_452, 23, 41) && field_114.field_588.field_462 == 1) {
                     method_27(field_114.field_587.field_452, 24, 40);
                  } else {
                     method_27(field_114.field_587.field_452, 23, 40);
                  }

                  field_114.method_232(field_114.method_228(23, 41) - class_27.field_570 / 2, class_27.method_229(23, 41) - class_27.field_571 / 2);
                  class_27.method_279(field_114.field_587.field_452, 7);
                  field_114.method_242(field_114.field_587.field_452, 1);
                  method_25(true);
                  field_114.method_213();
               default:
                  return 1;
            }
         case 410:
            switch (class_27.field_618) {
               case 0:
                  method_25(false);
                  return 1;
               case 1:
                  if (method_26(field_114.field_588.field_452, 46, 41) && field_114.field_588.field_462 == 1) {
                     method_27(field_114.field_588.field_452, 45, 41);
                  }

                  method_27(field_114.field_587.field_452, 46, 40);
                  field_114.method_232(field_114.method_228(46, 41) - class_27.field_570 / 2, class_27.method_229(46, 41) - class_27.field_571 / 2);
                  class_27.method_279(field_114.field_587.field_452, 7);
                  field_114.method_242(field_114.field_587.field_452, 1);
                  method_25(true);
                  field_114.method_213();
                  return 1;
               default:
                  return 1;
            }
         case 430:
            switch (class_27.field_618) {
               case 0:
                  if (field_114.field_720 == 0) {
                     field_114.field_720 = 1;
                  } else if (field_114.field_720 == 2) {
                     field_114.field_720 = -1;
                     field_114.field_624 = field_114.method_197(10, 33, 32, 7);
                  }

                  field_114.method_264(157, 0);
                  field_114.method_274(157);
                  field_114.method_292((byte)34);
                  if (field_114.field_720 == -1) {
                     field_114.method_193();
                  }

                  field_114.method_223();
                  field_114.method_244();
                  method_27(field_114.field_587.field_452, 23, 15);
                  field_114.method_213();
                  field_114.field_587.field_452.field_130 = false;
                  field_114.method_233(field_114.field_587.field_452, true);
                  field_114.method_232(
                     field_114.method_228(field_114.field_587.field_452.field_131, field_114.field_587.field_452.field_132) - class_27.field_570 / 2,
                     class_27.method_229(field_114.field_587.field_452.field_131, field_114.field_587.field_452.field_132) - class_27.field_571 / 2
                  );
                  field_114.field_616 = field_114.field_720 == -1 ? 0 : 1;
                  field_114.field_619 = field_114.field_574;
                  method_25(false);
                  return 1;
               case 1:
                  switch (field_114.field_616) {
                     case 0:
                        if (var3 > 2000L) {
                           field_114.method_144(39);
                           field_114.field_616++;
                           method_27(field_114.field_587.field_452, 33, 31);
                           field_114.method_232(
                              field_114.method_228(field_114.field_587.field_452.field_131, field_114.field_587.field_452.field_132) - class_27.field_570 / 2,
                              class_27.method_229(field_114.field_587.field_452.field_131, field_114.field_587.field_452.field_132) - class_27.field_571 / 2
                           );
                           field_114.field_619 = field_114.field_574;
                           field_114.method_233(field_114.field_587.field_452, false);
                        }
                        break;
                     case 1:
                        if (var3 > 3000L) {
                           field_114.field_616++;
                           method_27(field_114.field_587.field_452, (byte)(field_114.field_641[157].field_76 + 1), field_114.field_641[157].field_77);
                           field_114.method_213();
                           field_114.field_587.field_452.field_130 = true;
                           field_114.method_233(field_114.field_587.field_452, true);
                        }
                        break;
                     case 2:
                        method_25(true);
                  }
               default:
                  return 1;
            }
         case 440:
            switch (class_27.field_618) {
               case 0:
                  if (field_114.field_641[158].field_82[0].field_155) {
                     if (field_114.field_587 == field_114.field_589) {
                        field_114.method_286(0, field_114.field_587.field_452.field_139, class_27.method_185(45), 0);
                        method_25(false);
                        field_114.field_616 = 0;
                     } else {
                        field_114.method_286(0, field_114.field_587.field_452.field_139, class_27.method_185(46), 0);
                        method_25(false);
                        field_114.field_616 = 0;
                     }
                  } else if (field_114.field_720 >= 0 && field_114.field_720 != 2) {
                     field_114.field_616 = 1;
                     method_25(false);
                  } else {
                     method_25(true);
                  }
                  break;
               case 1:
                  switch (field_114.field_616) {
                     case 0:
                        if (class_27.field_594 != 131) {
                           if (field_114.field_587 == field_114.field_590) {
                              field_114.method_265(158, 0);
                              field_114.method_144(34);
                           }

                           method_25(true);
                        }
                        break;
                     case 1:
                        if (field_114.field_720 == 0) {
                           field_114.field_720 = 2;
                        } else if (field_114.field_720 == 1) {
                           field_114.field_720 = -1;
                           field_114.field_624 = field_114.method_197(10, 33, 32, 7);
                           field_114.method_144(39);
                        }

                        if (field_114.field_720 == -1) {
                           field_114.method_193();
                        }

                        field_114.method_223();
                        field_114.method_244();
                        method_27(field_114.field_587.field_452, 33, 32);
                        field_114.method_213();
                        field_114.field_587.field_452.field_130 = false;
                        field_114.method_233(field_114.field_587.field_452, true);
                        field_114.method_232(
                           field_114.method_228(field_114.field_587.field_452.field_131, field_114.field_587.field_452.field_132) - class_27.field_570 / 2,
                           class_27.method_229(field_114.field_587.field_452.field_131, field_114.field_587.field_452.field_132) - class_27.field_571 / 2
                        );
                        field_114.field_616++;
                        field_114.field_619 = field_114.field_574;
                        break;
                     case 2:
                        if (var3 > 3000L) {
                           field_114.field_616++;
                           method_27(field_114.field_587.field_452, field_114.field_641[158].field_76, field_114.field_641[158].field_77);
                           field_114.method_213();
                           field_114.field_587.field_452.field_130 = true;
                           field_114.method_233(field_114.field_587.field_452, true);
                        }
                        break;
                     case 3:
                        method_25(true);
                  }
            }

            return 1;
         case 460:
            switch (class_27.field_618) {
               case 0:
                  method_25(false);
                  return 1;
               case 1:
                  if (method_26(field_114.field_588.field_452, 21, 30) && field_114.field_588.field_462 == 1) {
                     method_27(field_114.field_587.field_452, 20, 31);
                  } else {
                     method_27(field_114.field_587.field_452, 21, 31);
                  }

                  field_114.method_232(field_114.method_228(21, 30) - class_27.field_570 / 2, class_27.method_229(21, 30) - class_27.field_571 / 2);
                  class_27.method_279(field_114.field_587.field_452, 3);
                  field_114.method_242(field_114.field_587.field_452, 1);
                  method_25(true);
                  field_114.method_213();
                  return 1;
               default:
                  return 1;
            }
         case 470:
            switch (class_27.field_618) {
               case 0:
                  method_25(false);
                  return 1;
               case 1:
                  if (method_26(field_114.field_588.field_452, 41, 34) && field_114.field_588.field_462 == 1) {
                     method_27(field_114.field_587.field_452, 40, 35);
                  } else {
                     method_27(field_114.field_587.field_452, 41, 35);
                  }

                  field_114.method_233(field_114.field_587.field_452, true);
                  field_114.method_232(field_114.method_228(41, 34) - class_27.field_570 / 2, class_27.method_229(41, 34) - class_27.field_571 / 2);
                  class_27.method_279(field_114.field_587.field_452, 3);
                  field_114.method_242(field_114.field_587.field_452, 1);
                  method_25(true);
                  field_114.method_213();
                  return 1;
               default:
                  return 1;
            }
         case 480:
            switch (class_27.field_618) {
               case 0:
                  if (!field_114.field_641[291].field_79) {
                     field_114.method_286(0, 2, class_27.method_185(78), 0);
                     method_25(true);
                     return 1;
                  }

                  if (field_114.field_717 != 2) {
                     field_114.method_286(0, 2, class_27.method_185(73), 0);
                     method_25(true);
                     return 1;
                  }

                  if (!field_114.field_589.field_454[11].field_117 && !field_114.field_590.field_454[11].field_117
                     || !field_114.field_589.field_454[10].field_117 && !field_114.field_590.field_454[10].field_117) {
                     field_114.method_286(0, 2, class_27.method_185(74), 0);
                     method_25(true);
                     return 1;
                  }

                  if (field_114.field_587.field_462 != field_114.field_588.field_462
                     || field_114.method_186(field_114.field_587.field_452) != field_114.method_186(field_114.field_588.field_452)) {
                     field_114.field_616 = 5;
                     field_114.method_286(0, 2, class_27.method_185(77), 0);
                  } else if ((field_114.field_588.field_452.field_131 < 39 || field_114.field_588.field_452.field_132 < 30)
                     && (field_114.field_588.field_452.field_131 < 37 || field_114.field_588.field_452.field_132 < 34)) {
                     if (field_114.field_588.field_452.field_131 <= 22) {
                        field_114.field_616 = 1;
                        field_114.method_286(0, 2, class_27.method_185(77), 0);
                     } else if (field_114.field_588.field_452.field_131 <= 34 && field_114.field_588.field_452.field_132 <= 21) {
                        field_114.field_616 = 21;
                        if (!method_26(field_114.field_587.field_452, 33, 16) && !method_26(field_114.field_587.field_452, 33, 15)
                           || !method_26(field_114.field_588.field_452, 33, 16) && !method_26(field_114.field_588.field_452, 33, 15)) {
                           field_114.method_200(field_114.field_591 == 1 ? 2 : 1);
                        }
                     } else {
                        field_114.field_616 = 10;
                     }
                  } else {
                     field_114.field_616 = 0;
                     field_114.method_286(0, 2, class_27.method_185(77), 0);
                  }

                  method_25(false);
                  break;
               case 1:
                  switch (field_114.field_616) {
                     case 0:
                        if (class_27.field_594 != 131) {
                           field_114.field_588.field_463 = true;
                           field_114.method_251(field_114.field_588.field_452, 41, 34);
                           field_114.method_233(field_114.field_588.field_452, true);
                           field_114.field_616 = 2;
                        }
                        break;
                     case 1:
                        if (class_27.field_594 != 131) {
                           field_114.field_588.field_463 = true;
                           field_114.method_251(field_114.field_588.field_452, 21, 30);
                           field_114.method_233(field_114.field_588.field_452, true);
                           field_114.field_616 = 2;
                        }
                        break;
                     case 2:
                        field_114.method_233(field_114.field_588.field_452, true);
                        if (field_114.field_588.field_452.field_143 == -1 && field_114.field_588.field_452.field_144 == -1) {
                           field_114.field_588.field_452.field_130 = false;
                           field_114.field_619 = field_114.field_574;
                           field_114.field_616++;
                        }
                        break;
                     case 3:
                        if (var3 > 500L) {
                           field_114.field_616 = 8;
                        }
                     case 4:
                     case 6:
                     case 7:
                     case 9:
                     case 13:
                     case 14:
                     case 15:
                     case 16:
                     case 17:
                     case 18:
                     case 19:
                     default:
                        break;
                     case 5:
                        if (class_27.field_594 != 131) {
                           field_114.field_616 = 8;
                        }
                        break;
                     case 8:
                        field_114.field_588.field_462 = 1;
                        field_114.field_588.field_452.field_130 = true;
                        method_27(field_114.field_588.field_452, 33, 35);
                        field_114.method_233(field_114.field_588.field_452, true);
                        field_114.field_616 = 10;
                        break;
                     case 10:
                        field_114.field_588.field_463 = true;
                        field_114.method_251(field_114.field_588.field_452, 35, 27);
                        field_114.method_233(field_114.field_588.field_452, true);
                        field_114.field_616++;
                        break;
                     case 11:
                        field_114.method_233(field_114.field_588.field_452, true);
                        if (field_114.field_588.field_452.field_143 == -1 && field_114.field_588.field_452.field_144 == -1) {
                           field_114.method_200(field_114.field_591 == 1 ? 2 : 1);
                           method_20();
                           field_114.field_616++;
                        }
                        break;
                     case 12:
                        if (method_21()) {
                           method_27(field_114.field_587.field_452, 32, 22);
                           field_114.field_587.field_452.field_130 = true;
                           field_114.field_619 = field_114.field_574;
                           field_114.field_616 = 20;
                           field_114.field_691 = true;
                           field_114.method_242(field_114.field_587.field_452, 1);
                        }
                        break;
                     case 20:
                        if (field_114.field_587.field_452.field_135 == 0 && field_114.field_587.field_452.field_133 == 0) {
                           field_114.field_691 = false;
                           field_114.field_616++;
                        }
                        break;
                     case 21:
                        field_114.method_251(field_114.field_587.field_452, 33, field_114.field_588.field_452.field_132 == 16 ? 15 : 16);
                        field_114.field_587.field_463 = false;
                        field_114.field_616++;
                        break;
                     case 22:
                        if (field_114.field_587.field_452.field_143 == -1 && field_114.field_587.field_452.field_144 == -1) {
                           class_27.method_279(field_114.field_587.field_452, 5);
                           field_114.field_619 = field_114.field_574;
                           field_114.field_616++;
                        }
                        break;
                     case 23:
                        if (var3 > 500L) {
                           field_114.method_144(19);
                           field_114.method_272(294, 292);
                           field_114.method_272(295, 293);
                           field_114.field_619 = field_114.field_574;
                           field_114.field_616++;
                        }
                        break;
                     case 24:
                        if (var3 > 500L) {
                           field_114.field_588.field_452.field_131--;
                           field_114.field_588.field_452.field_130 = false;
                           field_114.field_587.field_452.field_131--;
                           field_114.field_587.field_452.field_130 = false;
                           field_114.field_619 = field_114.field_574;
                           field_114.field_616++;
                        }
                        break;
                     case 25:
                        if (var3 > 500L) {
                           field_114.method_144(19);
                           field_114.method_272(292, 294);
                           field_114.method_272(293, 295);
                           field_114.field_619 = field_114.field_574;
                           field_114.field_693 = 1000;
                           field_114.field_616++;
                        }
                        break;
                     case 26:
                        if (var3 > 800L) {
                           field_114.method_144(35);
                           this.method_24(30, 17);
                           field_114.field_616++;
                           field_114.field_619 = field_114.field_574;
                        }
                        break;
                     case 27:
                        if (var3 > 700L) {
                           this.method_24(30, 16);
                           field_114.field_616++;
                           field_114.field_619 = field_114.field_574;
                        }
                        break;
                     case 28:
                        if (var3 > 550L) {
                           this.method_24(30, 15);
                           field_114.field_616++;
                           field_114.field_619 = field_114.field_574;
                        }
                        break;
                     case 29:
                        if (var3 > 400L) {
                           this.method_24(30, 14);
                           field_114.field_616++;
                           field_114.field_619 = field_114.field_574;
                        }
                        break;
                     case 30:
                        if (var3 > 250L) {
                           this.method_24(30, 13);
                           field_114.field_616++;
                           field_114.field_619 = field_114.field_574;
                        }
                        break;
                     case 31:
                        if (var3 > 100L) {
                           this.method_24(30, 12);
                           field_114.field_616++;
                           field_114.field_619 = field_114.field_574;
                        }
                        break;
                     case 32:
                        if (var3 > 50L) {
                           this.method_24(30, 11);
                           field_114.field_616++;
                           field_114.field_619 = field_114.field_574;
                        }
                        break;
                     case 33:
                        if (var3 > 50L) {
                           this.method_24(30, 10);
                           field_114.field_616++;
                           field_114.field_619 = field_114.field_574;
                        }
                        break;
                     case 34:
                        if (var3 > 50L) {
                           method_25(true);
                           field_114.method_200(field_114.field_591 == 1 ? 2 : 1);
                           method_27(field_114.field_587.field_452, 38, 31);
                           method_27(field_114.field_588.field_452, 38, 33);
                           field_114.field_472 = true;
                           field_114.field_588.field_462 = 2;
                           field_114.method_222(2, true);
                           field_114.field_587.field_452.field_130 = false;
                           field_114.field_588.field_452.field_130 = false;
                           class_27.field_780 = false;
                        }
                  }
            }

            return 1;
         case 490:
            switch (class_27.field_618) {
               case 0:
                  if (method_26(field_114.field_588.field_452, 32, 21) && field_114.field_588.field_462 == 1) {
                     method_25(true);
                     return 1;
                  }

                  if (method_26(field_114.field_588.field_452, 35, 27) && field_114.field_588.field_462 == 1) {
                     method_25(true);
                     return 1;
                  }

                  if (!method_26(field_114.field_587.field_452, 35, 27)) {
                     field_114.method_245();
                     field_114.method_247(field_114.field_587.field_452.field_131, field_114.field_587.field_452.field_132, 35, 27);
                     if (field_114.field_684 == null) {
                        method_25(true);
                        return 1;
                     }

                     field_114.method_251(field_114.field_587.field_452, 35, 27);
                     field_114.field_616 = 0;
                  } else {
                     method_20();
                     field_114.field_616 = 1;
                  }

                  method_25(false);
                  return 1;
               case 1:
                  switch (field_114.field_616) {
                     case 0:
                        if (!class_27.method_203(field_114.field_587.field_452) && !method_26(field_114.field_587.field_452, 35, 27)) {
                           field_114.method_245();
                           field_114.method_247(field_114.field_587.field_452.field_131, field_114.field_587.field_452.field_132, 35, 27);
                           if (field_114.field_684 == null) {
                              field_114.method_242(field_114.field_587.field_452, 0);
                              method_25(true);
                              return 1;
                           }

                           field_114.method_251(field_114.field_587.field_452, 35, 27);
                        }

                        if (!class_27.method_203(field_114.field_587.field_452) && method_26(field_114.field_587.field_452, 35, 27)) {
                           method_20();
                           field_114.field_616++;
                        }
                        break;
                     case 1:
                        if (method_21()) {
                           method_27(field_114.field_587.field_452, 32, 22);
                           field_114.method_233(field_114.field_587.field_452, false);
                           field_114.field_619 = field_114.field_574;
                           field_114.field_616 = 9;
                           field_114.field_691 = true;
                           field_114.method_242(field_114.field_587.field_452, 1);
                        }
                        break;
                     case 9:
                        if (!class_27.method_203(field_114.field_587.field_452)) {
                           field_114.field_691 = false;
                           method_25(true);
                        }
                  }
               default:
                  return 1;
            }
         case 500:
            switch (class_27.field_618) {
               case 0:
                  if (method_26(field_114.field_588.field_452, 35, 27) && field_114.field_588.field_462 == 1) {
                     method_25(true);
                     return 1;
                  }

                  if (method_26(field_114.field_588.field_452, 32, 21) && field_114.field_588.field_462 == 1) {
                     method_25(true);
                     return 1;
                  }

                  if (!method_26(field_114.field_587.field_452, 32, 21)) {
                     field_114.method_245();
                     field_114.method_247(field_114.field_587.field_452.field_131, field_114.field_587.field_452.field_132, 32, 21);
                     if (field_114.field_684 == null) {
                        method_25(true);
                        return 1;
                     }

                     field_114.method_251(field_114.field_587.field_452, 32, 21);
                     field_114.field_616 = 0;
                  } else {
                     method_22();
                     field_114.field_616 = 1;
                  }

                  method_25(false);
                  return 1;
               case 1:
                  switch (field_114.field_616) {
                     case 0:
                        if (!class_27.method_203(field_114.field_587.field_452) && !method_26(field_114.field_587.field_452, 32, 21)) {
                           field_114.method_245();
                           field_114.method_247(field_114.field_587.field_452.field_131, field_114.field_587.field_452.field_132, 32, 21);
                           if (field_114.field_684 == null) {
                              field_114.method_242(field_114.field_587.field_452, 0);
                              method_25(true);
                              return 1;
                           }

                           field_114.method_251(field_114.field_587.field_452, 32, 21);
                        }

                        if (!class_27.method_203(field_114.field_587.field_452) && method_26(field_114.field_587.field_452, 32, 21)) {
                           method_22();
                           field_114.field_616 = 1;
                        }
                        break;
                     case 1:
                        if (method_23()) {
                           method_27(field_114.field_587.field_452, 35, 27);
                           field_114.field_587.field_452.field_130 = true;
                           field_114.method_233(field_114.field_587.field_452, false);
                           field_114.field_619 = field_114.field_574;
                           field_114.field_616 = 5;
                           field_114.method_242(field_114.field_587.field_452, 1);
                        }
                        break;
                     case 5:
                        if (var3 > 2000L) {
                           method_25(true);
                        }
                  }
               default:
                  return 1;
            }
         case 510:
            switch (class_27.field_618) {
               case 0:
                  field_114.method_262(3);
                  field_114.field_693 = 2000;
                  field_114.field_619 = field_114.field_574;
                  method_25(false);
                  field_114.method_144(35);
                  break;
               case 1:
                  if (var3 > 2000L) {
                     field_114.method_187(true);
                     method_25(true);
                  }
            }

            return 1;
         case 540:
            switch (class_27.field_618) {
               case 0:
                  field_114.field_616 = 0;
                  field_114.method_263(31);
                  field_114.field_706 = 45;
                  method_25(false);
                  return 1;
               case 1:
                  switch (field_114.field_616) {
                     case 0:
                        if (!class_27.method_203(field_114.field_587.field_452)) {
                           field_114.method_145(1);
                           field_114.method_286(0, 5, class_27.method_185(189), 0);
                           field_114.field_616++;
                        }
                        break;
                     case 1:
                        if (class_27.field_594 != 131) {
                           field_114.field_587.field_452.field_140 = 127;
                           field_114.method_242(field_114.field_587.field_452, 11);
                           class_27.method_279(field_114.field_587.field_452, 5);
                           field_114.method_286(0, 5, class_27.method_185(190), 0);
                           field_114.field_616++;
                        }
                        break;
                     case 2:
                        if (class_27.field_594 != 131) {
                           field_114.method_286(0, 2, class_27.method_185(191), 0);
                           field_114.field_616++;
                        }
                        break;
                     case 3:
                        if (class_27.field_594 != 131) {
                           field_114.method_286(0, 5, class_27.method_185(192), 0);
                           field_114.field_616++;
                        }
                        break;
                     case 4:
                        if (class_27.field_594 != 131) {
                           field_114.method_286(0, 5, class_27.method_185(193), 0);
                           field_114.field_616++;
                        }
                        break;
                     case 5:
                        if (class_27.field_594 != 131) {
                           field_114.method_286(0, 5, class_27.method_185(194), 0);
                           field_114.field_616++;
                        }
                        break;
                     case 6:
                        if (class_27.field_594 != 131) {
                           field_114.method_242(field_114.field_587.field_452, 0);
                           class_27.method_279(field_114.field_587.field_452, 5);
                           field_114.method_286(0, 2, class_27.method_185(195), 0);
                           field_114.field_616++;
                        }
                        break;
                     case 7:
                        if (class_27.field_594 != 131) {
                           field_114.method_286(0, 5, class_27.method_185(196), 0);
                           field_114.field_616++;
                        }
                        break;
                     case 8:
                        if (class_27.field_594 != 131) {
                           field_114.method_286(0, 5, class_27.method_185(197), 0);
                           field_114.field_616++;
                        }
                        break;
                     case 9:
                        if (class_27.field_594 != 131) {
                           field_114.method_242(field_114.field_587.field_452, 0);
                           class_27.method_279(field_114.field_587.field_452, 7);
                           field_114.method_286(0, 2, class_27.method_185(198), 0);
                           field_114.field_616++;
                        }
                        break;
                     case 10:
                        if (class_27.field_594 != 131) {
                           field_114.method_286(0, 5, class_27.method_185(199), 0);
                           field_114.field_616++;
                        }
                        break;
                     case 11:
                        if (class_27.field_594 != 131) {
                           field_114.method_286(0, 5, class_27.method_185(200), 0);
                           field_114.field_616++;
                        }
                        break;
                     case 12:
                        if (class_27.field_594 != 131) {
                           field_114.method_286(0, 5, class_27.method_185(201), 0);
                           field_114.field_616++;
                        }
                        break;
                     case 13:
                        if (class_27.field_594 != 131) {
                           field_114.field_693 = 2000;
                           field_114.field_619 = field_114.field_574;
                           field_114.field_616++;
                           field_114.method_144(36);
                        }
                        break;
                     case 14:
                        if (var3 > 1200L) {
                           field_114.method_286(0, 5, class_27.method_185(202), 0);
                           field_114.field_616++;
                        }
                        break;
                     case 15:
                        if (class_27.field_594 != 131) {
                           field_114.field_623 = field_114.method_197(5, 36, 9, 3);
                           field_114.method_251(field_114.field_623, 36, 7);
                           class_27.method_279(field_114.field_587.field_452, 5);
                           field_114.method_210();
                           field_114.field_616++;
                        }
                        break;
                     case 16:
                        if (method_26(field_114.field_623, 36, 7)) {
                           field_114.method_262(31);
                        }

                        if (!class_27.method_203(field_114.field_623) && method_26(field_114.field_623, 36, 7)) {
                           field_114.method_145(5);
                           field_114.field_616++;
                        }
                        break;
                     case 17:
                        field_114.method_232(
                           field_114.method_228(field_114.field_623.field_131, field_114.field_623.field_132) - class_27.field_570 / 2,
                           class_27.method_229(field_114.field_623.field_131, field_114.field_623.field_132) - class_27.field_571 / 2
                        );
                        field_114.method_233(field_114.field_623, false);
                        field_114.field_706 = 0;
                        field_114.method_242(field_114.field_623, 5);
                        field_114.field_616++;
                        break;
                     case 18:
                        if (field_114.field_623.field_135 == 0) {
                           field_114.method_242(field_114.field_623, 5);
                           field_114.field_616++;
                        }
                        break;
                     case 19:
                        if (field_114.field_623.field_135 == 0) {
                           class_27.method_279(field_114.field_623, 1);
                           field_114.field_616++;
                           field_114.field_619 = field_114.field_574;
                        }
                        break;
                     case 20:
                        if (var3 > 500L) {
                           field_114.method_232(
                              field_114.method_228(field_114.field_587.field_452.field_131, field_114.field_587.field_452.field_132) - class_27.field_570 / 2,
                              class_27.method_229(field_114.field_587.field_452.field_131, field_114.field_587.field_452.field_132) - class_27.field_571 / 2
                           );
                           field_114.method_233(field_114.field_587.field_452, false);
                           field_114.field_616++;
                           class_27.field_618 = 3;
                        }
                        break;
                     case 21:
                        field_114.field_623.field_141 = 100;
                        field_114.method_242(field_114.field_623, 0);
                        if (field_114.field_588.field_462 == field_114.field_607) {
                           field_114.field_588.field_452.field_130 = false;
                        }

                        field_114.method_251(field_114.field_587.field_452, 42, 6);
                        field_114.method_251(field_114.field_623, 45, 3);
                        class_27.field_594 = 384;
                        field_114.field_619 = field_114.field_574;
                        field_114.field_616++;
                        break;
                     case 22:
                        if (!class_27.method_203(field_114.field_587.field_452) && !method_26(field_114.field_587.field_452, 42, 6)) {
                           field_114.field_587.field_452.field_143 = -1;
                           field_114.field_587.field_452.field_144 = -1;
                           field_114.method_251(field_114.field_587.field_452, 42, 6);
                        }

                        if (!class_27.method_203(field_114.field_623) && !method_26(field_114.field_623, 45, 3)) {
                           field_114.field_623.field_143 = -1;
                           field_114.field_623.field_144 = -1;
                           field_114.method_251(field_114.field_623, 45, 3);
                        }

                        if (!class_27.method_203(field_114.field_587.field_452) && method_26(field_114.field_587.field_452, 42, 6)) {
                           if (field_114.field_623.field_131 < 42) {
                              class_27.method_279(field_114.field_587.field_452, 5);
                           } else {
                              class_27.method_279(field_114.field_587.field_452, 1);
                           }
                        }

                        if (!class_27.method_203(field_114.field_623)
                           && method_26(field_114.field_623, 45, 3)
                           && !class_27.method_203(field_114.field_587.field_452)
                           && method_26(field_114.field_587.field_452, 42, 6)) {
                           field_114.field_616++;
                        }

                        if (field_114.field_587.field_452.field_141 <= 0) {
                           field_114.field_587.field_452.field_141 = 2;
                        }
                        break;
                     case 23:
                        field_114.field_623.field_130 = false;
                        field_114.field_619 = field_114.field_574;
                        field_114.field_616++;
                        field_114.field_587.field_452.field_143 = -1;
                        field_114.field_587.field_452.field_144 = -1;
                        field_114.method_145(2);
                        if (field_114.field_588.field_462 == field_114.field_607) {
                           field_114.field_588.field_452.field_130 = true;
                        }
                        break;
                     case 24:
                        if (var3 > 2000L) {
                           field_114.method_286(0, 2, field_114.field_591 == 1 ? class_27.method_185(203) : class_27.method_185(204), 0);
                           field_114.field_616++;
                        }
                        break;
                     case 25:
                        if (class_27.field_594 != 131) {
                           field_114.method_210();
                           field_114.method_251(field_114.field_587.field_452, 36, 7);
                           field_114.field_616++;
                        }
                     case 26:
                        if (!class_27.method_203(field_114.field_587.field_452) && method_26(field_114.field_587.field_452, 36, 7)) {
                           class_27.method_279(field_114.field_587.field_452, 3);
                           field_114.field_619 = field_114.field_574;
                           field_114.field_616++;
                        }
                        break;
                     case 27:
                        if (var3 > 1000L) {
                           field_114.method_286(0, 2, field_114.field_591 == 1 ? class_27.method_185(205) : class_27.method_185(206), 0);
                           field_114.field_616++;
                        }
                        break;
                     case 28:
                        if (class_27.field_594 != 131) {
                           field_114.method_251(field_114.field_587.field_452, 35, 6);
                           field_114.field_616++;
                        }
                        break;
                     case 29:
                        if (!class_27.method_203(field_114.field_587.field_452) && method_26(field_114.field_587.field_452, 35, 6)) {
                           class_27.method_279(field_114.field_587.field_452, 5);
                           field_114.field_619 = field_114.field_574;
                           field_114.field_616++;
                        }
                        break;
                     case 30:
                        if (var3 > 1000L) {
                           field_114.method_286(0, 2, field_114.field_591 == 1 ? class_27.method_185(207) : class_27.method_185(208), 0);
                           field_114.field_616++;
                        }
                        break;
                     case 31:
                        if (class_27.field_594 != 131) {
                           field_114.method_251(field_114.field_587.field_452, 36, 7);
                           field_114.field_616++;
                        }
                        break;
                     case 32:
                        if (!class_27.method_203(field_114.field_587.field_452) && method_26(field_114.field_587.field_452, 36, 7)) {
                           class_27.method_279(field_114.field_587.field_452, 1);
                           field_114.field_619 = field_114.field_574;
                           field_114.field_616++;
                        }
                        break;
                     case 33:
                        if (var3 > 500L) {
                           field_114.method_286(0, 2, class_27.method_185(90), 0);
                           field_114.field_616++;
                        }
                        break;
                     case 34:
                        if (class_27.field_594 != 131) {
                           class_27.method_279(field_114.field_587.field_452, 3);
                           field_114.field_619 = field_114.field_574;
                           field_114.field_616++;
                        }
                        break;
                     case 35:
                        if (var3 > 500L) {
                           field_114.method_286(0, 2, class_27.method_185(91), 0);
                           field_114.field_616++;
                        }
                        break;
                     case 36:
                        if (class_27.field_594 != 131) {
                           field_114.method_242(field_114.field_587.field_452, 2);
                           field_114.field_616++;
                        }
                        break;
                     case 37:
                        if (!class_27.method_203(field_114.field_587.field_452) && method_26(field_114.field_587.field_452, 36, 8)) {
                           field_114.field_616++;
                        }
                        break;
                     case 38:
                        field_114.field_625 = field_114.method_197(8, 36, 6, 7);
                        field_114.field_619 = field_114.field_574;
                        field_114.method_210();
                        field_114.field_616++;
                        field_114.method_144(38);
                        break;
                     case 39:
                        if (var3 > 500L) {
                           field_114.field_616++;
                           class_27.field_618 = 3;
                        }
                        break;
                     case 40:
                        field_114.field_718 = 1;
                        method_25(true);
                  }

                  return 1;
               case 3:
                  switch (field_114.field_616) {
                     case 21:
                        if (field_114.field_623.field_141 < field_114.field_623.field_142 - 45) {
                           field_114.field_623.field_141 = (byte)(field_114.field_623.field_142 - 45);
                        }

                        if (field_114.field_623.field_141 > field_114.field_623.field_142 - 45) {
                           return 1;
                        }
                        break;
                     case 40:
                        if (field_114.field_625.field_135 != 3 && field_114.field_625.field_135 != 4) {
                           return 1;
                        }
                        break;
                     default:
                        return 1;
                  }

                  class_27.field_618 = 1;
               case 2:
               default:
                  return 1;
            }
         case 550:
            if (field_114.field_673[field_114.field_587.field_452.field_131][field_114.field_587.field_452.field_132] == 11) {
               switch (class_27.field_618) {
                  case 0:
                     if (field_114.field_719 != 1) {
                        method_25(true);
                        return 1;
                     }

                     field_114.field_616 = 0;
                     field_114.field_622 = field_114.method_197(7, 33, 35, 7);
                     field_114.method_210();
                     method_25(false);
                     field_114.method_251(field_114.field_587.field_452, 33, 40);
                     field_114.field_732 = false;
                     if (field_114.field_588.field_462 == field_114.field_607
                        && field_114.field_673[field_114.field_587.field_452.field_131][field_114.field_587.field_452.field_132]
                           == field_114.field_673[field_114.field_588.field_452.field_131][field_114.field_588.field_452.field_132]) {
                        field_114.field_732 = true;
                        field_114.method_251(field_114.field_588.field_452, 34, 41);
                     }

                     field_114.field_589.field_463 = false;
                     field_114.field_590.field_463 = false;
                     return 1;
                  case 1:
                     switch (field_114.field_616) {
                        case 0:
                           if (field_114.field_587.field_452.field_132 < 42) {
                              field_114.field_616++;
                              field_114.method_263(297);
                              field_114.method_263(296);
                              field_114.method_245();
                              field_114.method_251(field_114.field_622, 33, 37);
                           }
                           break;
                        case 1:
                           if (!class_27.method_203(field_114.field_622) && !method_26(field_114.field_622, 33, 37)) {
                              field_114.method_251(field_114.field_622, 33, 37);
                           }

                           if (!class_27.method_203(field_114.field_587.field_452) && !method_26(field_114.field_587.field_452, 33, 40)) {
                              field_114.method_251(field_114.field_587.field_452, 33, 40);
                           }

                           if (field_114.field_732 && !class_27.method_203(field_114.field_588.field_452) && !method_26(field_114.field_588.field_452, 34, 41)) {
                              field_114.method_251(field_114.field_588.field_452, 34, 41);
                           }

                           if (!class_27.method_203(field_114.field_587.field_452) && method_26(field_114.field_587.field_452, 33, 40)) {
                              class_27.method_279(field_114.field_587.field_452, 3);
                           }

                           if (!class_27.method_203(field_114.field_622) && method_26(field_114.field_622, 33, 37)) {
                              class_27.method_279(field_114.field_622, 7);
                           }

                           if (field_114.field_732 && !class_27.method_203(field_114.field_588.field_452) && method_26(field_114.field_588.field_452, 34, 41)) {
                              class_27.method_279(field_114.field_588.field_452, 3);
                           }

                           if (!class_27.method_203(field_114.field_587.field_452)
                              && method_26(field_114.field_587.field_452, 33, 40)
                              && !class_27.method_203(field_114.field_622)
                              && method_26(field_114.field_622, 33, 37)
                              && (
                                 !field_114.field_732
                                    || !class_27.method_203(field_114.field_588.field_452) && method_26(field_114.field_588.field_452, 34, 41)
                              )) {
                              field_114.method_242(field_114.field_622, 8);
                              class_27.method_279(field_114.field_622, 7);
                              field_114.field_616++;
                              field_114.field_619 = field_114.field_574;
                              field_114.method_233(field_114.field_622, false);
                           }
                           break;
                        case 2:
                           if (var3 > 500L) {
                              field_114.field_616++;
                              field_114.method_286(0, 4, class_27.method_185(209), 0);
                           }
                           break;
                        case 3:
                           if (class_27.field_594 != 131) {
                              field_114.field_616++;
                              if (field_114.field_587.field_452.field_139 == 1) {
                                 field_114.method_286(0, 4, class_27.method_185(210), 0);
                              } else {
                                 field_114.method_286(0, 4, class_27.method_185(211), 0);
                              }
                           }
                           break;
                        case 4:
                           if (class_27.field_594 != 131) {
                              field_114.field_616++;
                              if (field_114.field_587.field_452.field_139 == 1) {
                                 field_114.method_286(0, 1, class_27.method_185(212), 0);
                              } else {
                                 field_114.method_286(0, 0, class_27.method_185(213), 0);
                              }
                           }
                           break;
                        case 5:
                           if (class_27.field_594 != 131) {
                              field_114.field_616++;
                              field_114.method_286(0, 4, class_27.method_185(214), 0);
                           }
                           break;
                        case 6:
                           if (class_27.field_594 != 131) {
                              field_114.field_616++;
                              field_114.method_286(0, 4, class_27.method_185(215), 0);
                           }
                           break;
                        case 7:
                           if (class_27.field_594 != 131) {
                              field_114.field_616++;
                              field_114.method_286(0, 2, class_27.method_185(216), 0);
                           }
                           break;
                        case 8:
                           if (class_27.field_594 != 131) {
                              field_114.field_616++;
                              field_114.method_286(0, 4, class_27.method_185(217), 0);
                           }
                           break;
                        case 9:
                           if (class_27.field_594 != 131) {
                              field_114.field_616++;
                              field_114.method_286(0, 4, class_27.method_185(218), 0);
                           }
                           break;
                        case 10:
                           if (class_27.field_594 != 131) {
                              field_114.field_616++;
                              field_114.method_286(0, 2, class_27.method_185(219), 0);
                           }
                           break;
                        case 11:
                           if (class_27.field_594 != 131) {
                              field_114.field_616++;
                              field_114.method_286(0, 4, class_27.method_185(220), 0);
                           }
                           break;
                        case 12:
                           if (class_27.field_594 != 131) {
                              field_114.field_616++;
                              field_114.method_286(0, 2, class_27.method_185(221), 0);
                           }
                           break;
                        case 13:
                           if (class_27.field_594 != 131) {
                              field_114.field_616++;
                              field_114.method_286(0, 4, class_27.method_185(222), 0);
                           }
                           break;
                        case 14:
                           if (class_27.field_594 != 131) {
                              field_114.field_616++;
                              field_114.method_286(0, 2, class_27.method_185(223), 0);
                           }
                           break;
                        case 15:
                           if (class_27.field_594 != 131) {
                              field_114.field_616++;
                              field_114.method_242(field_114.field_622, 0);
                              field_114.method_286(0, 4, class_27.method_185(224), 0);
                           }
                           break;
                        case 16:
                           if (class_27.field_594 != 131) {
                              field_114.field_616++;
                              field_114.method_286(0, 4, class_27.method_185(225), 0);
                           }
                           break;
                        case 17:
                           class_27.method_279(field_114.field_622, 1);
                           field_114.field_619 = field_114.field_574;
                           field_114.field_616++;
                           break;
                        case 18:
                           if (var3 > 1000L) {
                              field_114.field_616++;
                              field_114.method_286(0, 4, class_27.method_185(226), 0);
                           }
                           break;
                        case 19:
                           if (class_27.field_594 != 131) {
                              field_114.field_616++;
                              field_114.method_286(0, 2, class_27.method_185(227), 0);
                           }
                           break;
                        case 20:
                           if (class_27.field_594 != 131) {
                              field_114.field_616++;
                              field_114.method_286(0, 4, class_27.method_185(228), 0);
                           }
                           break;
                        case 21:
                           if (var3 > 1000L) {
                              field_114.field_616++;
                              field_114.method_286(0, 4, class_27.method_185(229), 0);
                           }
                           break;
                        case 22:
                           if (class_27.field_594 != 131) {
                              field_114.field_616++;
                              field_114.method_286(0, 2, class_27.method_185(230), 0);
                           }
                           break;
                        case 23:
                           if (class_27.field_594 != 131) {
                              field_114.field_616++;
                              class_27.method_279(field_114.field_622, 7);
                              field_114.method_286(0, 4, class_27.method_185(231), 0);
                           }
                           break;
                        case 24:
                           if (class_27.field_594 != 131) {
                              field_114.field_616++;
                              field_114.method_286(0, 2, class_27.method_185(232), 0);
                           }
                           break;
                        case 25:
                           if (class_27.field_594 != 131) {
                              field_114.field_616++;
                              field_114.method_286(0, 4, class_27.method_185(233), 0);
                           }
                           break;
                        case 26:
                           if (class_27.field_594 != 131) {
                              field_114.field_616++;
                              field_114.method_286(0, 2, class_27.method_185(234), 0);
                           }
                           break;
                        case 27:
                           if (class_27.field_594 != 131) {
                              field_114.field_616++;
                              field_114.method_286(0, 4, class_27.method_185(235), 0);
                              field_114.field_619 = field_114.field_574;
                           }
                           break;
                        case 28:
                           if (class_27.field_594 != 131) {
                              field_114.field_619 = field_114.field_574;
                              field_114.field_616++;
                           }
                           break;
                        case 29:
                           if (var3 > 1000L) {
                              field_114.field_616++;
                              class_27.method_279(field_114.field_587.field_452, 1);
                              field_114.method_286(0, 6, class_27.method_185(236), 0);
                           }
                           break;
                        case 30:
                           if (class_27.field_594 != 131) {
                              field_114.field_619 = field_114.field_574;
                              field_114.field_616++;
                           }
                           break;
                        case 31:
                           if (var3 > 1000L) {
                              field_114.field_616 = 34;
                              field_114.method_286(0, 6, class_27.method_185(237), 0);
                           }
                           break;
                        case 32:
                           if (class_27.field_594 != 131) {
                              field_114.field_616++;
                              field_114.method_286(0, 4, class_27.method_185(238), 0);
                           }
                           break;
                        case 33:
                           if (class_27.field_594 != 131) {
                              field_114.field_616++;
                              field_114.method_291(38);
                           }
                           break;
                        case 34:
                           if (class_27.field_594 != 131) {
                              field_114.method_251(field_114.field_622, 33, 35);
                              field_114.field_616++;
                           }
                           break;
                        case 35:
                           if (!class_27.method_203(field_114.field_622)) {
                              field_114.field_616++;
                              field_114.field_622.field_130 = false;
                              field_114.field_717 = 1;
                              field_114.field_719 = 2;
                              method_25(true);
                              field_114.method_233(field_114.field_587.field_452, false);
                           }
                     }
                  default:
                     return 1;
               }
            }
            break;
         case 560:
            switch (class_27.field_618) {
               case 0:
                  if (field_114.field_588.field_462 != 1
                     || !method_26(field_114.field_588.field_452, 31, 45) && !method_26(field_114.field_588.field_452, 38, 45)
                     || !field_114.field_588.field_454[36].field_117 && !field_114.field_588.field_454[37].field_117) {
                     field_114.method_286(0, field_114.field_587.field_452.field_139, class_27.method_185(39), 0);
                     field_114.field_616 = 0;
                  } else {
                     field_114.method_286(0, field_114.field_587.field_452.field_139, class_27.method_185(40), 0);
                     field_114.field_616 = 1;
                  }

                  method_25(false);
                  break;
               case 1:
                  switch (field_114.field_616) {
                     case 0:
                        if (class_27.field_594 != 131) {
                           method_25(true);
                        }
                        break;
                     case 1:
                        if (class_27.field_594 != 131) {
                           field_114.method_286(0, field_114.field_588.field_452.field_139, class_27.method_185(41), 0);
                           field_114.field_616++;
                        }
                        break;
                     case 2:
                        if (class_27.field_594 != 131) {
                           field_114.method_286(0, field_114.field_587.field_452.field_139, class_27.method_185(42), 0);
                           field_114.field_616++;
                        }
                        break;
                     case 3:
                        if (class_27.field_594 != 131) {
                           field_114.method_286(0, field_114.field_587.field_452.field_139, class_27.method_185(43), 0);
                           field_114.field_616++;
                        }
                        break;
                     case 4:
                        if (class_27.field_594 != 131) {
                           field_114.method_286(0, field_114.field_587.field_452.field_139, class_27.method_185(44), 0);
                           field_114.field_616++;
                        }
                        break;
                     case 5:
                        if (class_27.field_594 != 131) {
                           field_114.method_263(5);
                           field_114.method_263(6);
                           field_114.method_294((byte)36, (byte)2);
                           field_114.method_294((byte)36, (byte)1);
                           field_114.method_294((byte)37, (byte)2);
                           field_114.method_294((byte)37, (byte)1);
                           method_25(true);
                           field_114.method_144(12);
                        }
                  }
            }

            return 1;
         case 570:
            switch (class_27.field_618) {
               case 0:
                  boolean var5;
                  if (field_114.field_587.field_452.field_131 > 31
                     && field_114.field_587.field_452.field_131 < 34
                     && field_114.field_587.field_452.field_132 > 32
                     && field_114.field_587.field_452.field_132 < 36) {
                     var5 = true;
                  } else {
                     var5 = false;
                  }

                  boolean var1;
                  if (field_114.field_588.field_452.field_131 > 31
                     && field_114.field_588.field_452.field_131 < 34
                     && field_114.field_588.field_452.field_132 > 32
                     && field_114.field_588.field_452.field_132 < 36) {
                     var1 = true;
                  } else {
                     var1 = false;
                  }

                  if (!var5 && !var1) {
                     method_25(true);
                     return 1;
                  }

                  if (field_114.field_624.field_135 != 3 && field_114.field_624.field_135 != 4) {
                     if (var5) {
                        field_114.method_251(field_114.field_587.field_452, 33, 33);
                        field_114.field_616 = 0;
                     } else {
                        field_114.method_233(field_114.field_588.field_452, true);
                        field_114.method_251(field_114.field_588.field_452, 33, 33);
                        field_114.field_616 = 2;
                     }

                     method_25(false);
                     return 1;
                  }

                  method_25(true);
                  return 1;
               case 1:
                  switch (field_114.field_616) {
                     case 0:
                        if (method_26(field_114.field_587.field_452, 33, 33)) {
                           method_27(field_114.field_624, 33, 34);
                           field_114.method_242(field_114.field_587.field_452, 4);
                           class_27.method_279(field_114.field_624, 7);
                           field_114.field_616++;
                           field_114.method_144(field_114.field_587.field_452.field_139 == 0 ? 9 : 18);
                        }
                        break;
                     case 1:
                        field_114.method_206(0, field_114.field_587.field_452.field_131, field_114.field_587.field_452.field_132, 54, 2);
                        field_114.method_260(field_114.field_587.field_452, -50);
                        method_25(true);
                        break;
                     case 2:
                        if (method_26(field_114.field_588.field_452, 33, 33)) {
                           method_27(field_114.field_624, 33, 34);
                           field_114.method_242(field_114.field_588.field_452, 4);
                           class_27.method_279(field_114.field_624, 7);
                           field_114.field_616++;
                        }
                        break;
                     case 3:
                        field_114.method_206(0, field_114.field_588.field_452.field_131, field_114.field_588.field_452.field_132, 54, 2);
                        field_114.method_260(field_114.field_588.field_452, -50);
                        method_25(true);
                  }

                  return 1;
               default:
                  return 0;
            }
         case 580:
            switch (class_27.field_618) {
               case 0:
                  if (field_114.field_720 < 0) {
                     field_114.method_263(297);
                     field_114.method_263(296);
                     field_114.field_661[class_27.field_659].field_323 = true;
                     method_25(true);
                     field_114.method_144(12);
                  } else {
                     field_114.method_286(0, field_114.field_587.field_452.field_139, class_27.method_185(38), 0);
                     method_25(false);
                  }

                  return 1;
               case 1:
                  if (class_27.field_594 != 131) {
                     field_114.field_661[class_27.field_659].field_323 = false;
                     method_25(true);
                  }
               default:
                  return 1;
            }
         case 590:
            switch (class_27.field_618) {
               case 0:
                  if (field_114.field_589.field_454[19].field_117 && field_114.field_589.field_454[20].field_117 && field_114.field_589.field_454[21].field_117
                     )
                   {
                     field_114.method_286(0, 0, class_27.method_185(160), 0);
                  } else {
                     if (!field_114.field_590.field_454[19].field_117
                        || !field_114.field_590.field_454[20].field_117
                        || !field_114.field_590.field_454[21].field_117) {
                        method_25(true);
                        break;
                     }

                     field_114.method_286(0, 1, class_27.method_185(160), 0);
                  }

                  method_25(false);
                  field_114.field_616 = 0;
                  break;
               case 1:
                  if (class_27.field_594 != 131) {
                     if (field_114.field_616 == 0) {
                        field_114.field_616++;
                        if (field_114.field_589.field_454[19].field_117
                           && field_114.field_589.field_454[20].field_117
                           && field_114.field_589.field_454[21].field_117) {
                           field_114.method_294((byte)19, (byte)1);
                           field_114.method_294((byte)20, (byte)1);
                           field_114.method_294((byte)21, (byte)1);
                           field_114.method_290(22, (byte)1);
                        } else if (field_114.field_590.field_454[19].field_117
                           && field_114.field_590.field_454[20].field_117
                           && field_114.field_590.field_454[21].field_117) {
                           field_114.method_294((byte)19, (byte)2);
                           field_114.method_294((byte)20, (byte)2);
                           field_114.method_294((byte)21, (byte)2);
                           field_114.method_290(22, (byte)2);
                        }
                     } else {
                        method_25(true);
                     }
                  }
            }

            return 1;
         case 600:
            if (class_27.field_618 == 0) {
               field_114.method_292((byte)28);
               field_114.field_723 = (byte)(field_114.field_723 | 1);
               field_114.method_191();
               method_25(false);
            } else if (class_27.field_594 != 131) {
               method_25(true);
            }

            return 1;
         case 610:
            if (class_27.field_618 == 0) {
               field_114.method_292((byte)30);
               field_114.field_723 = (byte)(field_114.field_723 | 2);
               field_114.method_191();
               method_25(false);
            } else if (class_27.field_594 != 131) {
               method_25(true);
            }

            return 1;
         case 620:
            if (class_27.field_618 == 0) {
               field_114.method_292((byte)29);
               field_114.field_723 = (byte)(field_114.field_723 | 4);
               field_114.method_191();
               method_25(false);
            } else if (class_27.field_594 != 131) {
               method_25(true);
            }

            return 1;
         case 630:
            switch (class_27.field_618) {
               case 0:
                  if (field_114.field_720 > -1) {
                     method_25(true);
                     return 1;
                  }

                  if (!field_114.field_587.field_454[18].field_117) {
                     field_114.method_286(0, 2, class_27.method_185(92), 0);
                     method_25(true);
                     return 1;
                  }

                  field_114.field_616 = 0;
                  method_25(false);
                  return 1;
               case 1:
                  switch (field_114.field_616) {
                     case 0:
                        field_114.field_587.field_452.field_140 = 127;
                        field_114.method_242(field_114.field_587.field_452, 11);
                        class_27.method_279(field_114.field_587.field_452, 5);
                        field_114.method_286(0, 2, class_27.method_185(36), 0);
                        field_114.field_616++;
                        break;
                     case 1:
                        if (class_27.field_594 != 131) {
                           field_114.method_233(field_114.field_624, false);
                           field_114.method_292((byte)22);
                           field_114.method_292((byte)18);
                           field_114.method_208(
                              8,
                              field_114.field_587.field_452.field_131,
                              field_114.field_587.field_452.field_132,
                              field_114.field_624.field_131,
                              field_114.field_624.field_132,
                              (byte)5
                           );
                           field_114.field_613 = field_114.field_624.field_131;
                           field_114.field_614 = field_114.field_624.field_132;
                           field_114.field_616++;
                        }
                        break;
                     case 2:
                        if (!field_114.field_629[0].field_425) {
                           field_114.method_242(field_114.field_624, 3);
                           field_114.field_616++;
                           field_114.method_144(13);
                        }
                        break;
                     case 3:
                        if (field_114.field_624.field_135 == 3) {
                           field_114.method_233(field_114.field_587.field_452, true);
                           field_114.field_619 = field_114.field_574;
                           field_114.field_616++;
                        }
                        break;
                     case 4:
                        if (var3 > 1000L) {
                           field_114.method_242(field_114.field_587.field_452, 0);
                           field_114.method_263(134);
                           field_114.method_263(80);
                           field_114.field_661[class_27.field_659].field_323 = true;
                           method_25(true);
                        }
                  }

                  return 1;
               default:
                  return 1;
            }
         case 810:
            if (field_114.field_673[field_114.field_587.field_452.field_131][field_114.field_587.field_452.field_132]
                  != field_114.field_673[field_114.field_641[281].field_76][field_114.field_641[281].field_77]
               && field_114.field_716 == 0) {
               field_114.method_187(false);
            }

            field_114.method_263(3);
            method_25(true);
            field_114.method_144(12);
            return 1;
         case 830:
            switch (class_27.field_618) {
               case 0:
                  if (field_114.field_720 > -1) {
                     field_114.method_286(0, 2, class_27.method_185(75), 0);
                  } else {
                     field_114.method_286(0, 2, class_27.method_185(76), 0);
                  }

                  method_25(false);
                  break;
               case 1:
                  if (class_27.field_594 != 131) {
                     method_25(true);
                  }
            }

            return 1;
      }

      return 0;
   }
}
