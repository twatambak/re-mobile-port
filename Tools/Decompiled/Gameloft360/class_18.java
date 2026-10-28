// $VF: renamed from: l
public final class class_18 {
   // $VF: renamed from: a f
   private static class_27 field_319;

   public class_18(class_27 var1) {
      field_319 = var1;
   }

   // $VF: renamed from: a () void
   private static void method_77() {
      class_27.method_279(field_319.field_587.field_452, 3);
      field_319.field_587.field_463 = false;
      field_319.field_691 = true;
      field_319.field_706 = 1;
      field_319.field_619 = field_319.field_574;
   }

   // $VF: renamed from: a () boolean
   private static boolean method_78() {
      if (field_319.field_574 - field_319.field_619 > 100L) {
         field_319.field_619 = field_319.field_574;
         field_319.field_706++;
         if (field_319.field_706 >= 8) {
            field_319.field_691 = false;
            field_319.field_706 = 0;
            return true;
         }
      }

      return false;
   }

   // $VF: renamed from: b () void
   private static void method_79() {
      class_27.method_279(field_319.field_587.field_452, 7);
      field_319.field_587.field_463 = false;
      field_319.field_691 = true;
      field_319.field_706 = 13;
      field_319.field_619 = field_319.field_574;
   }

   // $VF: renamed from: b () boolean
   private static boolean method_80() {
      if (field_319.field_574 - field_319.field_619 > 100L) {
         field_319.field_619 = field_319.field_574;
         field_319.field_706++;
         if (field_319.field_706 == 14) {
            field_319.field_691 = false;
            field_319.field_706 = 0;
            return true;
         }

         if (field_319.field_706 >= 20) {
            field_319.field_691 = false;
            field_319.field_706 = 0;
            return true;
         }
      }

      return false;
   }

   // $VF: renamed from: a (p, int, int) boolean
   private static boolean method_81(class_15 var0, int var1, int var2) {
      return var0.field_131 == var1 && var0.field_132 == var2;
   }

   // $VF: renamed from: a (p, int, int) void
   private static void method_82(class_15 var0, int var1, int var2) {
      var0.field_131 = (byte)var1;
      var0.field_132 = (byte)var2;
   }

   // $VF: renamed from: a () int
   public final int method_83() {
      int var2 = 0;
      int var1 = 0;
      long var4 = field_319.field_574 - field_319.field_619;
      switch (class_27.field_617) {
         case 0:
            switch (class_27.field_618) {
               case 0:
                  field_319.method_145(1);
                  field_319.field_587 = field_319.field_589;
                  field_319.field_588 = field_319.field_590;
                  field_319.field_591 = 1;
                  field_319.method_233(field_319.field_587.field_452, true);
                  field_319.method_286(3, 0, class_27.method_185(47), 0);
                  method_82(field_319.field_590.field_452, 1, 0);
                  field_319.field_616 = 0;
                  class_27.method_273(false);
                  class_27.field_781 = true;
                  return 1;
               case 1:
                  if (class_27.field_594 != 131) {
                     class_27.method_273(true);
                  }

                  return 1;
               default:
                  return 0;
            }
         case 10:
            switch (class_27.field_618) {
               case 0:
                  field_319.method_145(2);
                  field_319.method_197(0, 29, 47, 3);
                  field_319.field_625 = field_319.method_197(2, 25, 37, 3);
                  field_319.method_242(field_319.field_625, 0);
                  field_319.field_625.field_150 = true;
                  field_319.method_251(field_319.field_589.field_452, 27, 43);
                  field_319.field_616 = 0;
                  class_27.method_273(false);
                  return 1;
               case 1:
                  switch (field_319.field_616) {
                     case 0:
                        if (!class_27.method_203(field_319.field_589.field_452) && method_81(field_319.field_589.field_452, 27, 43)) {
                           field_319.field_616++;
                           field_319.field_619 = field_319.field_574;
                        }
                        break;
                     case 1:
                        if (var4 > 1000L) {
                           field_319.field_616++;
                           field_319.method_287(0, 0, class_27.method_185(49), 0);
                        }
                        break;
                     case 2:
                        if (class_27.field_594 != 131) {
                           class_27.method_279(field_319.field_589.field_452, 1);
                           field_319.field_616++;
                           field_319.field_619 = field_319.field_574;
                        }
                        break;
                     case 3:
                        if (var4 > 1000L) {
                           field_319.method_251(field_319.field_589.field_452, 25, 40);
                           field_319.field_616++;
                        }
                        break;
                     case 4:
                        if (!class_27.method_203(field_319.field_589.field_452) && method_81(field_319.field_589.field_452, 25, 40)) {
                           field_319.field_616++;
                           class_27.method_279(field_319.field_589.field_452, 3);
                           field_319.method_287(0, 0, class_27.method_185(50), 0);
                        }
                        break;
                     case 5:
                        if (class_27.field_594 != 131) {
                           field_319.field_616++;
                           field_319.field_619 = field_319.field_574;
                        }
                        break;
                     case 6:
                        if (var4 > 500L) {
                           field_319.field_616++;
                           field_319.field_619 = field_319.field_574;
                           class_27.method_279(field_319.field_625, 7);
                           field_319.method_144(25);
                           field_319.method_197(1, 30, 47, 3);
                           field_319.field_590.field_463 = true;
                           field_319.field_590.field_452.field_140 = 127;
                           field_319.method_251(field_319.field_590.field_452, 25, 42);
                        }
                        break;
                     case 7:
                        if (var4 > 1000L) {
                           field_319.field_616++;
                           field_319.method_242(field_319.field_625, 1);
                        }
                        break;
                     case 8:
                        if (method_81(field_319.field_625, 25, 38)) {
                           field_319.field_616++;
                           field_319.method_287(0, 0, class_27.method_185(51), 0);
                        }
                        break;
                     case 9:
                        if (!class_27.method_203(field_319.field_590.field_452) && method_81(field_319.field_590.field_452, 25, 42)) {
                           class_27.method_279(field_319.field_590.field_452, 3);
                           field_319.field_590.field_463 = false;
                           field_319.method_199(1, 2);
                           field_319.field_590.field_452.field_140 = 6;
                           field_319.method_242(field_319.field_590.field_452, 9);
                           field_319.field_616++;
                           class_27.method_279(field_319.field_589.field_452, 7);
                           field_319.field_619 = field_319.field_574;
                        }
                        break;
                     case 10:
                        if (var4 > 500L) {
                           field_319.method_199(127, 1);
                           field_319.field_589.field_452.field_140 = 127;
                           field_319.method_242(field_319.field_589.field_452, 11);
                           field_319.field_616++;
                           field_319.method_287(0, 0, class_27.method_185(52), 0);
                        }
                        break;
                     case 11:
                        if (class_27.field_594 != 131) {
                           field_319.field_616++;
                           field_319.method_287(0, 1, class_27.method_185(53), 0);
                           class_27.method_152();
                        }
                        break;
                     case 12:
                        if (class_27.field_594 != 131) {
                           field_319.field_616++;
                           field_319.method_206(
                              21 + field_319.field_590.field_452.field_138,
                              field_319.field_590.field_452.field_131,
                              field_319.field_590.field_452.field_132,
                              0,
                              0
                           );
                           field_319.field_693 = 100;
                           field_319.field_619 = field_319.field_574;
                        }
                        break;
                     case 13:
                        if (var4 > 500L) {
                           field_319.method_242(field_319.field_625, 3);
                           field_319.field_625.field_141 = 0;
                           field_319.field_616++;
                           field_319.field_619 = field_319.field_574;
                        }
                        break;
                     case 14:
                        if (var4 > 1000L) {
                           field_319.method_242(field_319.field_590.field_452, 0);
                           field_319.method_242(field_319.field_589.field_452, 0);
                           class_27.method_279(field_319.field_589.field_452, 3);
                           field_319.field_616++;
                           field_319.field_619 = field_319.field_574;
                        }
                        break;
                     case 15:
                        if (var4 > 1000L) {
                           class_27.method_279(field_319.field_589.field_452, 7);
                           field_319.field_616++;
                           field_319.field_619 = field_319.field_574;
                        }
                        break;
                     case 16:
                        if (var4 > 500L) {
                           field_319.field_616++;
                           field_319.method_287(0, 0, class_27.method_185(54), 0);
                        }
                        break;
                     case 17:
                        if (class_27.field_594 != 131) {
                           field_319.field_616++;
                           field_319.method_251(field_319.field_590.field_452, 25, 41);
                        }
                        break;
                     case 18:
                        if (field_319.field_590.field_452.field_143 == -1 && field_319.field_590.field_452.field_144 == -1) {
                           field_319.method_145(2);
                           field_319.field_616++;
                           field_319.method_287(0, 0, class_27.method_185(55), 0);
                        }
                        break;
                     case 19:
                        if (class_27.field_594 != 131) {
                           field_319.field_616++;
                           field_319.method_287(0, 1, class_27.method_185(56), 0);
                        }
                        break;
                     case 20:
                        if (class_27.field_594 != 131) {
                           field_319.field_616++;
                           field_319.method_286(0, 1, class_27.method_185(57), 0);
                        }
                        break;
                     case 21:
                        if (class_27.field_594 != 131) {
                           field_319.field_616++;
                           field_319.method_286(0, 0, class_27.method_185(58), 0);
                        }
                        break;
                     case 22:
                        if (class_27.field_594 != 131) {
                           field_319.field_616++;
                           field_319.method_286(0, 1, class_27.method_185(59), 0);
                        }
                        break;
                     case 23:
                        if (class_27.field_594 != 131) {
                           field_319.field_616++;
                           field_319.method_291(2);
                        }
                        break;
                     case 24:
                        if (class_27.field_594 != 131) {
                           field_319.field_616++;
                           field_319.method_286(0, 1, class_27.method_185(60), 0);
                        }
                        break;
                     case 25:
                        if (class_27.field_594 != 131) {
                           field_319.field_616++;
                           field_319.method_286(0, 6, class_27.method_185(61), 0);
                        }
                        break;
                     case 26:
                        if (class_27.field_594 != 131) {
                           field_319.field_616++;
                           field_319.method_286(0, 6, class_27.method_185(62), 0);
                        }
                        break;
                     case 27:
                        if (class_27.field_594 != 131) {
                           class_27.field_554 = true;
                           class_27.method_273(true);
                           class_27.field_780 = true;
                           class_27.method_153();
                           class_27.field_749 = false;
                        }
                  }

                  return 1;
               default:
                  return 0;
            }
         case 20:
            if (field_319.field_623 != null) {
               method_82(field_319.field_623, 5, 0);
               field_319.field_623.field_130 = false;
            } else {
               for (int var13 = 0; var13 < 25; var13++) {
                  if (field_319.field_620[var13].field_139 == 5) {
                     method_82(field_319.field_620[var13], 5, 0);
                     field_319.field_620[var13].field_130 = false;
                  }
               }
            }

            class_27.method_273(true);
            return 1;
         case 30:
            switch (class_27.field_618) {
               case 0:
                  field_319.method_292((byte)31);
                  if (field_319.field_722 == 0) {
                     field_319.method_265(2, 7);
                     field_319.method_264(2, 0);
                     field_319.method_264(2, 3);
                     field_319.field_722 = 2;
                     class_27.method_273(true);
                  } else {
                     field_319.method_265(2, 1);
                     field_319.method_265(2, 4);
                     field_319.method_264(2, 2);
                     field_319.method_264(2, 5);
                     field_319.method_264(2, 6);
                     field_319.field_722 = 3;
                     field_319.method_291(8);
                     field_319.field_616 = 0;
                     class_27.method_273(false);
                  }

                  return 2;
               case 1:
                  if (class_27.field_594 != 131) {
                     if (field_319.field_616 != 0) {
                        class_27.method_273(true);
                        return 2;
                     }

                     field_319.method_291(26);
                     field_319.field_616 = 1;
                  }

                  return 1;
               default:
                  return 0;
            }
         case 40:
            switch (class_27.field_618) {
               case 0:
                  if (field_319.field_586) {
                     class_27.method_273(true);
                     return 1;
                  } else {
                     field_319.method_288(class_27.method_185(87), (short)0, (byte)5);
                     class_27.method_273(false);
                  }
               default:
                  return 1;
               case 1:
                  if (class_27.field_594 != 137) {
                     if (field_319.field_688.charAt(0) == 'R'
                        && field_319.field_688.charAt(1) == 'A'
                        && field_319.field_688.charAt(2) == 'V'
                        && field_319.field_688.charAt(3) == 'E'
                        && field_319.field_688.charAt(4) == 'N') {
                        field_319.field_672[field_319.field_641[545].field_76][field_319.field_641[545].field_77] = -1;
                        field_319.field_586 = true;
                        field_319.field_716 = 0;
                        field_319.method_262(545);
                        field_319.method_244();
                        field_319.method_144(12);
                     } else {
                        field_319.method_286(0, 2, class_27.method_185(89), 0);
                     }

                     class_27.method_273(true);
                  }

                  return 1;
            }
         case 50:
            switch (class_27.field_618) {
               case 0:
                  field_319.method_245();
                  if (field_319.field_588.field_452.field_131 == 29 && field_319.field_588.field_452.field_132 == 30) {
                     field_319.field_625 = field_319.method_197(2, 30, 30, 7);
                  } else {
                     field_319.field_625 = field_319.method_197(2, 29, 30, 7);
                  }

                  field_319.method_211(true);
                  field_319.method_233(field_319.field_625, true);
                  field_319.method_286(0, 2, class_27.method_185(63), 0);
                  field_319.field_616 = 0;
                  class_27.method_273(false);
                  return 2;
               case 1:
                  switch (field_319.field_616) {
                     case 0:
                        field_319.method_233(field_319.field_625, true);
                        if (class_27.field_594 != 131) {
                           field_319.field_616++;
                           field_319.method_233(field_319.field_587.field_452, true);
                           class_27.field_618 = 3;
                        }
                     default:
                        return 1;
                  }
               case 2:
               default:
                  return 0;
               case 3:
                  if (field_319.field_625.field_135 == 4) {
                     class_27.method_273(true);
                     return 2;
                  }

                  return 1;
            }
         case 60:
            switch (class_27.field_618) {
               case 0:
                  field_319.method_292((byte)32);
                  if (field_319.field_722 == 0) {
                     field_319.method_265(2, 7);
                     field_319.method_264(2, 1);
                     field_319.method_264(2, 4);
                     field_319.field_722 = 1;
                     class_27.method_273(true);
                  } else {
                     field_319.method_265(2, 0);
                     field_319.method_265(2, 3);
                     field_319.method_264(2, 2);
                     field_319.method_264(2, 5);
                     field_319.method_264(2, 6);
                     field_319.field_722 = 3;
                     field_319.method_291(8);
                     field_319.field_616 = 0;
                     class_27.method_273(false);
                  }

                  return 2;
               case 1:
                  if (class_27.field_594 != 131) {
                     if (field_319.field_616 != 0) {
                        class_27.method_273(true);
                        return 2;
                     }

                     field_319.method_291(26);
                     field_319.field_616 = 1;
                  }

                  return 1;
               default:
                  return 0;
            }
         case 70:
            switch (class_27.field_618) {
               case 0:
                  field_319.field_621 = field_319.method_197(3, 33, 19, 1);
                  field_319.field_625 = field_319.method_197(11, 37, 21, 7);
                  field_319.field_626 = field_319.method_197(11, 24, 19, 1);
                  field_319.method_211(true);
                  field_319.field_616 = 0;
                  class_27.method_273(false);
                  field_319.method_233(field_319.field_621, true);
                  return 1;
               case 1:
                  switch (field_319.field_616) {
                     case 0:
                        field_319.method_286(0, 3, class_27.method_185(64), 0);
                        field_319.field_616++;
                        break;
                     case 1:
                        field_319.method_233(field_319.field_621, true);
                        if (class_27.field_594 != 131) {
                           field_319.method_233(field_319.field_587.field_452, true);
                           class_27.field_618 = 3;
                        }
                     case 2:
                     default:
                        break;
                     case 3:
                        if (field_319.field_587 == field_319.field_589) {
                           if (method_81(field_319.field_589.field_452, 29, 29)) {
                              method_82(field_319.field_590.field_452, 30, 29);
                           } else {
                              field_319.field_590.field_462 = 0;
                              field_319.field_590.field_452.field_130 = true;
                              method_82(field_319.field_590.field_452, 29, 29);
                           }
                        } else if (method_81(field_319.field_590.field_452, 30, 29)) {
                           method_82(field_319.field_589.field_452, 29, 29);
                        } else {
                           field_319.field_589.field_462 = 0;
                           field_319.field_589.field_452.field_130 = true;
                           method_82(field_319.field_589.field_452, 30, 29);
                        }

                        field_319.field_590.field_463 = true;
                        field_319.field_590.field_452.field_140 = 127;
                        field_319.field_589.field_463 = true;
                        field_319.field_589.field_452.field_140 = 127;
                        if (Math.abs(field_319.field_589.field_452.field_131 - 32) < Math.abs(field_319.field_589.field_452.field_131 - 35)) {
                           field_319.method_251(field_319.field_589.field_452, 32, 21);
                        } else {
                           field_319.method_251(field_319.field_589.field_452, 35, 21);
                        }

                        field_319.method_251(field_319.field_590.field_452, 32, 24);
                        field_319.field_616++;
                        break;
                     case 4:
                        if (field_319.field_591 == 2) {
                           field_319.method_200(1);
                           field_319.field_680 = 2;
                        }

                        if (!class_27.method_203(field_319.field_590.field_452) && method_81(field_319.field_590.field_452, 32, 24)) {
                           field_319.field_590.field_463 = false;
                           field_319.method_242(field_319.field_590.field_452, 0);
                           class_27.method_279(field_319.field_590.field_452, 1);
                        }

                        if (!class_27.method_203(field_319.field_589.field_452)
                           && field_319.field_589.field_452.field_143 == -1
                           && field_319.field_589.field_452.field_144 == -1) {
                           field_319.field_589.field_463 = false;
                           field_319.method_242(field_319.field_589.field_452, 0);
                           class_27.method_279(field_319.field_589.field_452, 3);
                           field_319.method_251(field_319.field_621, 39, 24);
                           field_319.field_616++;
                           field_319.field_619 = field_319.field_574;
                        }
                        break;
                     case 5:
                        if (var4 > 250L) {
                           field_319.method_286(0, 0, class_27.method_185(65), 0);
                           field_319.field_616++;
                        }
                        break;
                     case 6:
                        if (!class_27.method_203(field_319.field_590.field_452) && method_81(field_319.field_590.field_452, 32, 24)) {
                           field_319.field_590.field_463 = false;
                           field_319.method_242(field_319.field_590.field_452, 0);
                           class_27.method_279(field_319.field_590.field_452, 1);
                        }

                        if (class_27.field_594 != 131) {
                           field_319.method_251(field_319.field_589.field_452, 33, 19);
                           field_319.field_616++;
                        }
                        break;
                     case 7:
                        if (!class_27.method_203(field_319.field_590.field_452) && method_81(field_319.field_590.field_452, 32, 24)) {
                           field_319.field_590.field_463 = false;
                           field_319.method_242(field_319.field_590.field_452, 0);
                           class_27.method_279(field_319.field_590.field_452, 1);
                        }

                        if (field_319.field_589.field_452.field_143 == -1 && field_319.field_589.field_452.field_144 == -1) {
                           field_319.field_589.field_452.field_138 = 1;
                           field_319.field_616++;
                        }
                        break;
                     case 8:
                        if (!class_27.method_203(field_319.field_590.field_452) && method_81(field_319.field_590.field_452, 32, 24)) {
                           field_319.field_590.field_463 = false;
                           field_319.method_242(field_319.field_590.field_452, 0);
                           class_27.method_279(field_319.field_590.field_452, 1);
                        }

                        if (field_319.field_621.field_143 == -1 && field_319.field_621.field_144 == -1) {
                           field_319.method_251(field_319.field_621, 51, 26);
                           field_319.method_251(field_319.field_589.field_452, 33, 24);
                           field_319.field_616++;
                        }
                        break;
                     case 9:
                        if (field_319.field_589.field_452.field_143 == -1 && field_319.field_589.field_452.field_144 == -1) {
                           field_319.field_589.field_452.field_138 = 5;
                           field_319.field_616++;
                           field_319.field_619 = field_319.field_574;
                        }
                        break;
                     case 10:
                        if (var4 > 500L) {
                           field_319.field_616++;
                           field_319.method_286(0, 1, class_27.method_185(66), 0);
                        }
                        break;
                     case 11:
                        if (class_27.field_594 != 131) {
                           field_319.field_616++;
                           class_27.method_279(field_319.field_589.field_452, 1);
                           field_319.field_619 = field_319.field_574;
                        }
                        break;
                     case 12:
                        if (var4 > 1000L) {
                           field_319.field_616++;
                           field_319.method_286(0, 0, class_27.method_185(67), 0);
                        }
                        break;
                     case 13:
                        if (class_27.field_594 != 131) {
                           field_319.field_616++;
                           field_319.method_286(0, 1, class_27.method_185(68), 0);
                        }
                        break;
                     case 14:
                        field_319.method_242(field_319.field_589.field_452, 1);
                        field_319.field_616++;
                        break;
                     case 15:
                        if (!class_27.method_203(field_319.field_589.field_452)) {
                           field_319.field_616++;
                           field_319.method_286(0, 0, class_27.method_185(69), 0);
                        }
                        break;
                     case 16:
                        if (class_27.field_594 != 131) {
                           field_319.field_616++;
                           field_319.method_286(0, 0, class_27.method_185(70), 0);
                        }
                        break;
                     case 17:
                        if (class_27.field_594 != 131) {
                           field_319.field_616++;
                           field_319.method_242(field_319.field_590.field_452, 1);
                        }
                        break;
                     case 18:
                        if (!class_27.method_203(field_319.field_590.field_452)) {
                           field_319.field_616++;
                           field_319.method_286(0, 1, class_27.method_185(71), 0);
                        }
                        break;
                     case 19:
                        if (class_27.field_594 != 131) {
                           if (field_319.field_680 != 0) {
                              field_319.method_200(field_319.field_680);
                              field_319.field_680 = 0;
                           }

                           field_319.field_621.field_130 = false;
                           class_27.method_273(true);
                        }
                  }

                  return 1;
               case 2:
               default:
                  return 0;
               case 3:
                  if ((field_319.field_625.field_135 == 4 || !field_319.field_625.field_130)
                     && (field_319.field_626.field_135 == 4 || !field_319.field_626.field_130)) {
                     class_27.field_618 = 1;
                     field_319.field_616 = 3;
                  }

                  return 1;
            }
         case 80:
            switch (class_27.field_618) {
               case 0:
                  field_319.method_262(521);
                  field_319.field_616 = 0;
                  field_319.field_619 = field_319.field_574;
                  class_27.method_273(false);
                  return 1;
               case 1:
                  switch (field_319.field_616) {
                     case 0:
                        if (var4 > 500L) {
                           field_319.method_144(17);
                           field_319.field_616++;
                           field_319.method_286(0, 6, class_27.method_185(85), 0);
                        }
                        break;
                     case 1:
                        if (class_27.field_594 != 131) {
                           class_27.method_279(field_319.field_587.field_452, 1);
                           field_319.field_619 = field_319.field_574;
                           field_319.field_616++;
                        }
                        break;
                     case 2:
                        if (var4 > 1000L) {
                           field_319.field_616++;
                           field_319.method_286(0, 2, class_27.method_185(168), 0);
                        }
                        break;
                     case 3:
                        if (class_27.field_594 != 131) {
                           class_27.method_273(true);
                        }
                  }

                  return 1;
               default:
                  return 0;
            }
         case 90:
            switch (class_27.field_618) {
               case 0:
                  field_319.method_251(field_319.field_589.field_452, 64, 20);
                  field_319.field_616 = 0;
                  field_319.method_200(1);
                  class_27.method_273(false);
                  return 1;
               case 1:
                  switch (field_319.field_616) {
                     case 0:
                        if (field_319.method_204(field_319.field_589.field_452)
                           && field_319.field_589.field_452.field_131 == 64
                           && field_319.field_589.field_452.field_132 == 20) {
                           field_319.method_286(0, 0, class_27.method_185(169), 0);
                           field_319.field_616++;
                        }
                        break;
                     case 1:
                        if (class_27.field_594 != 131) {
                           class_27.method_279(field_319.field_589.field_452, 5);
                           field_319.field_619 = field_319.field_574;
                           field_319.field_616++;
                        }
                        break;
                     case 2:
                        if (var4 > 2000L) {
                           field_319.field_623 = field_319.method_197(5, 58, 25, 3);
                           field_319.method_233(field_319.field_623, true);
                           class_27.method_279(field_319.field_623, 1);
                           field_319.method_242(field_319.field_623, 1);
                           field_319.field_616++;
                        }
                        break;
                     case 3:
                     case 4:
                        if (field_319.field_623.field_135 == 0) {
                           field_319.method_242(field_319.field_623, 5);
                           field_319.field_616++;
                        }
                        break;
                     case 5:
                        if (field_319.field_623.field_135 == 0) {
                           field_319.field_619 = field_319.field_574;
                           field_319.field_616++;
                        }
                     case 6:
                        if (var4 > 700L) {
                           class_27.method_279(field_319.field_623, 3);
                           field_319.field_619 = field_319.field_574;
                           field_319.field_616++;
                        }
                        break;
                     case 7:
                        if (var4 > 500L) {
                           field_319.method_242(field_319.field_623, 5);
                           field_319.field_616++;
                        }
                     case 8:
                        if (field_319.field_623.field_135 == 0) {
                           field_319.method_210();
                           field_319.method_233(field_319.field_589.field_452, false);
                           class_27.field_618 = 3;
                           field_319.field_616++;
                        }
                     case 9:
                     default:
                        break;
                     case 10:
                        field_319.field_623.field_150 = true;
                        field_319.method_251(field_319.field_623, 57, 24);
                        field_319.field_616++;
                        if (field_319.field_587.field_452.field_131 <= 62 && field_319.field_587.field_452.field_132 == 19) {
                           field_319.method_251(field_319.field_587.field_452, 63, 19);
                        }
                        break;
                     case 11:
                        if (!class_27.method_203(field_319.field_587.field_452)) {
                           field_319.method_249(field_319.field_587.field_452, field_319.field_623.field_131, field_319.field_623.field_132);
                        }

                        if (field_319.field_623.field_143 == -1 && field_319.field_623.field_144 == -1) {
                           field_319.field_623.field_130 = false;
                           field_319.field_623.field_150 = false;
                           field_319.method_210();
                           class_27.method_273(true);
                           field_319.method_242(field_319.field_590.field_452, 0);
                        } else if (field_319.field_623.field_135 != 1) {
                           field_319.method_242(field_319.field_623, 1);
                        }
                  }

                  return 1;
               case 2:
               default:
                  return 0;
               case 3:
                  if (field_319.field_623.field_141 < field_319.field_623.field_142 - 45) {
                     field_319.field_623.field_141 = (byte)(field_319.field_623.field_142 - 45);
                  }

                  if (field_319.field_623.field_141 <= field_319.field_623.field_142 - 45) {
                     field_319.field_616 = 10;
                     class_27.method_273(false);
                  }

                  return 1;
            }
         case 100:
            if (field_319.field_641[11].field_82[1].field_155) {
               field_319.method_265(11, 1);
               field_319.method_291(47);
            } else {
               field_319.method_286(0, 2, class_27.method_185(72), 0);
            }

            class_27.method_273(true);
            return 1;
         case 110:
            switch (class_27.field_618) {
               case 0:
                  if (field_319.field_673[field_319.field_588.field_452.field_131][field_319.field_588.field_452.field_132] == field_319.field_673[53][30]
                     && field_319.field_588.field_452.field_130) {
                     class_27.method_273(true);
                     return 1;
                  } else {
                     if (!method_81(field_319.field_587.field_452, 55, 27)) {
                        class_27.method_273(true);
                        return 1;
                     }

                     if (field_319.field_717 != 1) {
                        class_27.method_273(true);
                     } else {
                        field_319.field_621 = field_319.method_197(3, 53, 30, 1);
                        field_319.method_242(field_319.field_621, 4);
                        field_319.method_233(field_319.field_621, true);
                        field_319.field_587.field_463 = true;
                        field_319.field_587.field_452.field_140 = 127;
                        field_319.method_251(field_319.field_587.field_452, 53, 29);
                        field_319.field_616 = 0;
                        class_27.method_273(false);
                     }

                     return 1;
                  }
               case 1:
                  switch (field_319.field_616) {
                     case 0:
                        if (!class_27.method_203(field_319.field_587.field_452) && method_81(field_319.field_587.field_452, 53, 29)) {
                           field_319.field_587.field_463 = false;
                           field_319.method_242(field_319.field_587.field_452, 11);
                           class_27.method_279(field_319.field_587.field_452, 7);
                           field_319.field_619 = field_319.field_574;
                           field_319.field_616++;
                        }
                        break;
                     case 1:
                        if (var4 > 1000L) {
                           field_319.method_286(0, 2, class_27.method_185(183), 0);
                           field_319.field_616++;
                        }
                        break;
                     case 2:
                        if (class_27.field_594 != 131) {
                           field_319.field_619 = field_319.field_574;
                           field_319.field_616++;
                        }
                        break;
                     case 3:
                        if (var4 > 2000L) {
                           field_319.method_286(0, 3, class_27.method_185(184), 0);
                           field_319.field_616++;
                        }
                        break;
                     case 4:
                        if (class_27.field_594 != 131) {
                           field_319.method_286(0, 3, class_27.method_185(185), 0);
                           field_319.field_616++;
                        }
                        break;
                     case 5:
                        if (class_27.field_594 != 131) {
                           field_319.method_242(field_319.field_587.field_452, 0);
                           class_27.method_279(field_319.field_587.field_452, 7);
                           field_319.method_233(field_319.field_587.field_452, false);
                           field_319.field_619 = field_319.field_574;
                           field_319.field_616++;
                        }
                        break;
                     case 6:
                        if (var4 > 2000L) {
                           field_319.method_286(0, 2, class_27.method_185(186), 0);
                           field_319.field_616++;
                        }
                        break;
                     case 7:
                        if (class_27.field_594 != 131) {
                           field_319.method_286(0, 2, class_27.method_185(187), 0);
                           field_319.field_616++;
                        }
                        break;
                     case 8:
                        if (class_27.field_594 != 131) {
                           field_319.method_242(field_319.field_587.field_452, 11);
                           class_27.method_279(field_319.field_587.field_452, 7);
                           field_319.field_621.field_130 = false;
                           field_319.field_706 = 30;
                           field_319.field_619 = field_319.field_574;
                           field_319.field_616++;
                        }
                        break;
                     case 9:
                     case 10:
                     case 11:
                     case 12:
                        if (var4 > 200L) {
                           field_319.field_706++;
                           field_319.field_619 = field_319.field_574;
                           field_319.field_616++;
                        }
                        break;
                     case 13:
                        if (var4 > 1500L) {
                           field_319.field_706 = 0;
                           field_319.field_619 = field_319.field_574;
                           field_319.field_616++;
                        }
                        break;
                     case 14:
                        field_319.method_242(field_319.field_587.field_452, 0);
                        field_319.method_286(0, 2, class_27.method_185(188), 0);
                        field_319.field_616++;
                        break;
                     case 15:
                        if (class_27.field_594 != 131) {
                           class_27.method_279(field_319.field_587.field_452, 1);
                           field_319.field_717 = 2;
                           class_27.method_273(true);
                        }
                  }

                  return 1;
               default:
                  return 0;
            }
         case 120:
            switch (class_27.field_618) {
               case 0:
                  if (field_319.field_710) {
                     class_27.method_273(true);
                  }

                  field_319.field_587.field_455 = 0;
                  if (field_319.field_588.field_462 == 0 && method_81(field_319.field_588.field_452, 29, 12)) {
                     field_319.field_616 = 0;
                     field_319.method_251(field_319.field_588.field_452, 29, 13);
                     class_27.method_273(false);
                     return 1;
                  }

                  field_319.field_726 = 532;
                  field_319.field_727 = 0;
                  field_319.field_728 = 0;
                  class_27.field_618 = 3;
                  return 1;
               case 1:
                  switch (field_319.field_616) {
                     case 0:
                        if (!class_27.method_203(field_319.field_588.field_452) && method_81(field_319.field_588.field_452, 29, 13)) {
                           field_319.field_726 = 532;
                           field_319.field_727 = 0;
                           field_319.field_728 = 0;
                           class_27.field_618 = 3;
                        }
                     default:
                        return 1;
                  }
               case 2:
               default:
                  return 0;
               case 3:
                  if (field_319.field_728 >= 35) {
                     field_319.method_263(532);
                     field_319.method_262(74);
                     field_319.method_262(536);
                     field_319.field_710 = true;
                     class_27.method_273(true);
                     return 2;
                  }

                  field_319.field_728++;
                  return 1;
            }
         case 130:
            switch (class_27.field_618) {
               case 0:
                  if (field_319.field_587.field_452.field_139 != 0) {
                     class_27.method_273(true);
                     return 1;
                  } else if (field_319.field_673[field_319.field_588.field_452.field_131][field_319.field_588.field_452.field_132]
                        == field_319.field_673[64][20]
                     && field_319.field_588.field_452.field_130) {
                     class_27.method_273(true);
                     return 1;
                  } else if (!method_81(field_319.field_587.field_452, 67, 18)
                     && !method_81(field_319.field_587.field_452, 58, 25)
                     && !method_81(field_319.field_587.field_452, 58, 24)) {
                     class_27.method_273(true);
                     return 1;
                  } else {
                     if (field_319.field_718 != 1) {
                        class_27.method_273(true);
                        return 1;
                     }

                     field_319.field_621 = field_319.method_197(3, 64, 21, 5);
                     field_319.field_616 = 0;
                     class_27.method_273(false);
                     if (field_319.field_587.field_452.field_131 > field_319.field_621.field_131) {
                        byte var12 = field_319.field_587.field_452.field_141;
                        field_319.field_732 = true;
                        field_319.method_197(0, field_319.field_641[545].field_76, field_319.field_641[545].field_77, 7);
                        class_27.method_279(field_319.field_589.field_452, 7);
                        field_319.method_251(field_319.field_589.field_452, field_319.field_641[545].field_76, field_319.field_641[545].field_77 + 2);
                        field_319.field_587.field_452.field_141 = var12;
                     } else {
                        field_319.field_732 = false;
                        field_319.method_251(field_319.field_587.field_452, 62, 23);
                     }

                     field_319.method_233(field_319.field_621, true);
                     return 1;
                  }
               case 1:
                  switch (field_319.field_616) {
                     case 0:
                        if (!class_27.method_203(field_319.field_589.field_452)) {
                           field_319.field_616++;
                           field_319.field_619 = field_319.field_574;
                           if (field_319.field_732) {
                              class_27.method_279(field_319.field_621, 1);
                           } else {
                              class_27.method_279(field_319.field_621, 7);
                           }
                        }
                        break;
                     case 1:
                        if (var4 > 1000L) {
                           if (field_319.field_732) {
                              field_319.method_251(field_319.field_621, field_319.field_589.field_452.field_131, field_319.field_589.field_452.field_132 + 1);
                              class_27.method_279(field_319.field_589.field_452, 5);
                           } else {
                              field_319.method_251(field_319.field_621, field_319.field_589.field_452.field_131 + 1, field_319.field_589.field_452.field_132);
                              class_27.method_279(field_319.field_589.field_452, 3);
                           }

                           field_319.field_616++;
                        }
                        break;
                     case 2:
                        if (field_319.field_732) {
                           if (field_319.field_621.field_132 > field_319.field_589.field_452.field_132 - 1) {
                              class_27.method_279(field_319.field_589.field_452, 7);
                           }

                           if (method_81(field_319.field_621, field_319.field_589.field_452.field_131, field_319.field_589.field_452.field_132 + 1)
                              && !class_27.method_203(field_319.field_621)) {
                              class_27.method_279(field_319.field_621, 3);
                              field_319.field_616++;
                              field_319.field_619 = field_319.field_574;
                           }
                        } else {
                           if (field_319.field_621.field_131 > field_319.field_589.field_452.field_131 + 1) {
                              class_27.method_279(field_319.field_589.field_452, 1);
                           }

                           if (method_81(field_319.field_621, field_319.field_589.field_452.field_131 + 1, field_319.field_589.field_452.field_132)
                              && !class_27.method_203(field_319.field_621)) {
                              class_27.method_279(field_319.field_621, 5);
                              field_319.field_616++;
                              field_319.field_619 = field_319.field_574;
                           }
                        }
                        break;
                     case 3:
                        if (var4 > 500L) {
                           field_319.field_616++;
                           field_319.method_286(0, 0, class_27.method_185(170), 0);
                        }
                        break;
                     case 4:
                        if (class_27.field_594 != 131) {
                           field_319.field_616++;
                           field_319.method_286(0, 3, class_27.method_185(171), 0);
                        }
                        break;
                     case 5:
                        if (class_27.field_594 != 131) {
                           field_319.method_233(field_319.field_589.field_452, true);
                           field_319.field_616++;
                           field_319.method_286(0, 3, class_27.method_185(172), 0);
                        }
                        break;
                     case 6:
                        if (class_27.field_594 != 131) {
                           field_319.method_291(37);
                           field_319.field_616++;
                        }
                        break;
                     case 7:
                        if (class_27.field_594 != 131) {
                           field_319.method_233(field_319.field_589.field_452, true);
                           field_319.field_616++;
                           field_319.method_286(0, 0, class_27.method_185(173), 0);
                        }
                        break;
                     case 8:
                        if (class_27.field_594 != 131) {
                           field_319.field_616++;
                           field_319.field_619 = field_319.field_574;
                        }
                        break;
                     case 9:
                        if (var4 > 1000L) {
                           field_319.field_616++;
                           field_319.method_286(0, 3, class_27.method_185(174), 0);
                        }
                        break;
                     case 10:
                        if (class_27.field_594 != 131) {
                           field_319.field_616++;
                           field_319.method_286(0, 0, class_27.method_185(175), 0);
                        }
                        break;
                     case 11:
                        if (class_27.field_594 != 131) {
                           field_319.field_616++;
                           field_319.method_286(0, 0, class_27.method_185(176), 0);
                        }
                        break;
                     case 12:
                        if (class_27.field_594 != 131) {
                           field_319.field_616++;
                           field_319.method_233(field_319.field_621, false);
                           if (field_319.field_732) {
                              field_319.method_251(
                                 field_319.field_621, field_319.field_589.field_452.field_131 - 2, field_319.field_589.field_452.field_132 + 2
                              );
                           } else {
                              field_319.method_251(field_319.field_621, field_319.field_589.field_452.field_131 + 2, field_319.field_589.field_452.field_132);
                           }
                        }
                        break;
                     case 13:
                        if (!class_27.method_203(field_319.field_621)) {
                           field_319.field_616++;
                           if (field_319.field_732) {
                              class_27.method_279(field_319.field_621, 5);
                           } else {
                              class_27.method_279(field_319.field_621, 1);
                           }

                           field_319.method_286(0, 3, class_27.method_185(177), 0);
                        }
                        break;
                     case 14:
                        if (class_27.field_594 != 131) {
                           field_319.field_616++;
                           field_319.method_286(0, 0, class_27.method_185(178), 0);
                        }
                        break;
                     case 15:
                        if (class_27.field_594 != 131) {
                           field_319.field_616++;
                           field_319.field_619 = field_319.field_574;
                        }
                        break;
                     case 16:
                        if (var4 > 500L) {
                           field_319.field_616++;
                           if (field_319.field_732) {
                              class_27.method_279(field_319.field_621, 1);
                           } else {
                              class_27.method_279(field_319.field_621, 5);
                           }

                           field_319.field_619 = field_319.field_574;
                        }
                        break;
                     case 17:
                        if (var4 > 1000L) {
                           field_319.field_616++;
                           field_319.method_286(0, 3, class_27.method_185(179), 0);
                        }
                        break;
                     case 18:
                        if (class_27.field_594 != 131) {
                           field_319.field_616++;
                           field_319.method_286(0, 3, class_27.method_185(180), 0);
                        }
                        break;
                     case 19:
                        if (class_27.field_594 != 131) {
                           field_319.field_616++;
                           field_319.method_286(0, 3, class_27.method_185(181), 0);
                        }
                     case 20:
                        if (class_27.field_594 != 131) {
                           field_319.field_616++;
                           field_319.method_251(field_319.field_621, 64, 18);
                        }
                        break;
                     case 21:
                        if (field_319.field_621.field_132 == field_319.field_589.field_452.field_132) {
                           if (field_319.field_732) {
                              class_27.method_279(field_319.field_589.field_452, 5);
                              field_319.method_242(field_319.field_589.field_452, 1);
                           } else {
                              class_27.method_279(field_319.field_589.field_452, 1);
                              field_319.method_242(field_319.field_589.field_452, 1);
                           }
                        }

                        if (!class_27.method_203(field_319.field_621) && method_81(field_319.field_621, 64, 18)) {
                           field_319.field_616++;
                           class_27.method_279(field_319.field_621, 3);
                           field_319.method_242(field_319.field_621, 5);
                           field_319.field_675 = true;
                        }
                        break;
                     case 22:
                        if (!class_27.method_203(field_319.field_589.field_452)) {
                           class_27.method_279(field_319.field_589.field_452, 3);
                        }

                        if (field_319.field_621.field_133 == 2) {
                           field_319.method_263(235);
                           field_319.method_262(234);
                        }

                        if (!class_27.method_203(field_319.field_621) && method_81(field_319.field_621, 64, 17)) {
                           field_319.field_675 = false;
                           field_319.method_263(234);
                           field_319.method_262(235);
                           field_319.method_233(field_319.field_587.field_452, false);
                           field_319.field_621.field_130 = false;
                           field_319.field_619 = field_319.field_574;
                           field_319.field_616++;
                           class_27.method_279(field_319.field_589.field_452, 3);
                           field_319.method_242(field_319.field_589.field_452, 1);
                        }
                        break;
                     case 23:
                        if (var4 > 1000L) {
                           field_319.field_616++;
                           field_319.method_286(0, 0, class_27.method_185(182), 0);
                        }
                        break;
                     case 24:
                        if (class_27.field_594 != 131) {
                           field_319.field_718 = 2;
                           field_319.field_719 = 1;
                           field_319.field_657[165].field_323 = true;
                           class_27.method_273(true);
                        }
                  }

                  return 1;
               default:
                  return 0;
            }
         case 150:
            switch (class_27.field_618) {
               case 0:
                  if (method_81(field_319.field_588.field_452, 36, 8) && field_319.field_588.field_462 == 0) {
                     class_27.method_273(true);
                     return 1;
                  } else if (method_81(field_319.field_588.field_452, 29, 13) && field_319.field_588.field_462 == field_319.field_587.field_462) {
                     class_27.method_273(true);
                     return 1;
                  } else if (field_319.field_588.field_452.field_143 == 36
                     && field_319.field_588.field_452.field_144 == 8
                     && field_319.field_588.field_462 == 0) {
                     class_27.method_273(true);
                     return 1;
                  } else if (method_81(field_319.field_588.field_452, 29, 13) && field_319.field_588.field_462 == 0) {
                     class_27.method_273(true);
                     return 1;
                  } else if (field_319.field_588.field_452.field_143 == 29
                     && field_319.field_588.field_452.field_144 == 13
                     && field_319.field_588.field_462 == 0) {
                     class_27.method_273(true);
                     return 1;
                  } else {
                     if (field_319.field_587.field_452.field_131 == 29 && field_319.field_587.field_452.field_132 == 13) {
                        method_77();
                        field_319.field_616 = 1;
                     } else {
                        if (method_81(field_319.field_588.field_452, 28, 13) && field_319.field_588.field_462 == 0) {
                           class_27.method_273(true);
                           return 1;
                        }

                        if (field_319.field_588.field_452.field_143 == 28
                           && field_319.field_588.field_452.field_144 == 13
                           && field_319.field_588.field_462 == 0) {
                           class_27.method_273(true);
                           return 1;
                        }

                        field_319.method_251(field_319.field_587.field_452, 29, 13);
                        field_319.field_616 = 0;
                     }

                     class_27.method_273(false);
                     return 1;
                  }
               case 1:
                  switch (field_319.field_616) {
                     case 0:
                        if (!class_27.method_203(field_319.field_587.field_452) && method_81(field_319.field_587.field_452, 29, 13)) {
                           method_77();
                           field_319.field_616++;
                        }
                        break;
                     case 1:
                        if (method_78()) {
                           method_82(field_319.field_587.field_452, 36, 9);
                           field_319.field_587.field_452.field_130 = true;
                           field_319.method_213();
                           field_319.method_232(
                              field_319.method_228(field_319.field_587.field_452.field_131, field_319.field_587.field_452.field_132) - class_27.field_570 / 2,
                              class_27.method_229(field_319.field_587.field_452.field_131, field_319.field_587.field_452.field_132) - class_27.field_571 / 2
                           );
                           field_319.method_233(field_319.field_587.field_452, false);
                           field_319.field_619 = field_319.field_574;
                           field_319.field_616 = 9;
                           field_319.method_242(field_319.field_587.field_452, 1);
                        }
                        break;
                     case 9:
                        if (var4 > 1000L) {
                           class_27.method_273(true);
                        }
                  }

                  return 1;
               default:
                  return 0;
            }
         case 160:
            switch (class_27.field_618) {
               case 0:
                  if (method_81(field_319.field_588.field_452, 29, 13) && field_319.field_588.field_462 == 0) {
                     class_27.method_273(true);
                     return 1;
                  } else if (method_81(field_319.field_588.field_452, 36, 8) && field_319.field_588.field_462 == field_319.field_587.field_462) {
                     class_27.method_273(true);
                     return 1;
                  } else if (field_319.field_588.field_452.field_143 == 29
                     && field_319.field_588.field_452.field_144 == 13
                     && field_319.field_588.field_462 == 0) {
                     class_27.method_273(true);
                     return 1;
                  } else {
                     if (field_319.field_587.field_452.field_131 == 36 && field_319.field_587.field_452.field_132 == 8) {
                        method_79();
                        field_319.field_616 = 1;
                     } else {
                        field_319.method_245();
                        field_319.method_247(field_319.field_587.field_452.field_131, field_319.field_587.field_452.field_132, 36, 8);
                        if (field_319.field_684 == null) {
                           class_27.method_273(true);
                           return 1;
                        }

                        field_319.method_251(field_319.field_587.field_452, 36, 8);
                        field_319.field_616 = 0;
                     }

                     class_27.method_273(false);
                     return 1;
                  }
               case 1:
                  switch (field_319.field_616) {
                     case 0:
                        if (!class_27.method_203(field_319.field_587.field_452)
                           && (field_319.field_587.field_452.field_131 != 36 || field_319.field_587.field_452.field_132 != 8)) {
                           field_319.method_245();
                           field_319.method_247(field_319.field_587.field_452.field_131, field_319.field_587.field_452.field_132, 36, 8);
                           if (field_319.field_684 == null) {
                              field_319.method_242(field_319.field_587.field_452, 0);
                              class_27.method_273(true);
                              return 1;
                           }

                           field_319.method_251(field_319.field_587.field_452, 36, 8);
                        }

                        if (!class_27.method_203(field_319.field_587.field_452) && method_81(field_319.field_587.field_452, 36, 8)) {
                           method_79();
                           field_319.field_616 = 1;
                        }
                        break;
                     case 1:
                        if (method_80()) {
                           method_82(field_319.field_587.field_452, 29, 12);
                           field_319.field_587.field_452.field_130 = true;
                           field_319.method_213();
                           field_319.method_232(
                              field_319.method_228(field_319.field_587.field_452.field_131, field_319.field_587.field_452.field_132) - class_27.field_570 / 2,
                              class_27.method_229(field_319.field_587.field_452.field_131, field_319.field_587.field_452.field_132) - class_27.field_571 / 2
                           );
                           field_319.method_233(field_319.field_587.field_452, false);
                           field_319.field_619 = field_319.field_574;
                           field_319.field_616 = 5;
                           field_319.method_242(field_319.field_587.field_452, 1);
                        }
                        break;
                     case 5:
                        if (var4 > 1000L) {
                           class_27.method_273(true);
                        }
                  }

                  return 1;
               default:
                  return 0;
            }
         case 170:
            switch (class_27.field_618) {
               case 0:
                  if (field_319.field_587.field_452.field_139 == 0) {
                     if (!field_319.field_589.field_454[17].field_117) {
                        field_319.method_286(0, 0, class_27.method_185(79), 0);
                     } else {
                        field_319.method_286(0, 0, class_27.method_185(80), 0);
                     }
                  } else if (field_319.field_587.field_452.field_139 == 1) {
                     if (!field_319.field_590.field_454[17].field_117) {
                        field_319.method_286(0, 1, class_27.method_185(81), 0);
                     } else if (!field_319.field_590.field_454[16].field_117) {
                        field_319.method_286(0, 1, class_27.method_185(83), 0);
                     } else {
                        class_27.field_780 = false;
                        field_319.method_286(0, 1, class_27.method_185(82), 0);
                     }
                  }

                  class_27.method_273(false);
                  return 1;
               case 1:
                  if (class_27.field_594 != 131) {
                     if (field_319.field_587.field_452.field_139 != 0) {
                        if (field_319.field_587.field_452.field_139 != 1) {
                           return 1;
                        }

                        if (field_319.field_590.field_454[17].field_117 && field_319.field_590.field_454[16].field_117) {
                           class_27.method_273(false);
                           return 1;
                        }
                     }

                     class_27.method_273(true);
                  }

                  return 1;
               default:
                  return 0;
            }
         case 171:
            switch (class_27.field_618) {
               case 0:
                  field_319.field_590.field_454[16].field_117 = false;
                  field_319.field_590.field_454[17].field_117 = false;
                  field_319.field_590.field_456 = (byte)(field_319.field_590.field_456 - 2);
                  field_319.field_590.field_455 = 0;
                  if (field_319.field_589.field_452.field_131 > 44
                     && field_319.field_589.field_452.field_131 < 58
                     && field_319.field_589.field_452.field_132 > 22
                     && field_319.field_589.field_452.field_132 < 27
                     && field_319.field_589.field_462 == 0) {
                     field_319.field_616 = 0;
                     field_319.field_589.field_463 = true;
                     field_319.method_251(field_319.field_589.field_452, 42, 25);
                  } else {
                     field_319.field_616 = 1;
                     field_319.field_590.field_463 = true;
                     if (method_81(field_319.field_589.field_452, 44, 24)) {
                        field_319.method_251(field_319.field_590.field_452, 44, 25);
                     } else {
                        field_319.method_251(field_319.field_590.field_452, 44, 24);
                     }

                     field_319.method_233(field_319.field_590.field_452, true);
                  }

                  class_27.method_273(false);
                  return 1;
               case 1:
                  switch (field_319.field_616) {
                     case 0:
                        if (field_319.field_589.field_452.field_131 < 50) {
                           field_319.field_590.field_463 = true;
                           if (method_81(field_319.field_589.field_452, 44, 24)) {
                              field_319.method_251(field_319.field_590.field_452, 44, 25);
                           } else {
                              field_319.method_251(field_319.field_590.field_452, 44, 24);
                           }

                           field_319.method_233(field_319.field_590.field_452, true);
                           field_319.field_616++;
                        }
                        break;
                     case 1:
                        if (field_319.field_589.field_463
                           && !class_27.method_203(field_319.field_589.field_452)
                           && method_81(field_319.field_589.field_452, 42, 25)) {
                           field_319.field_589.field_463 = false;
                           field_319.method_242(field_319.field_589.field_452, 0);
                           class_27.method_279(field_319.field_589.field_452, 1);
                        }

                        if (field_319.field_590.field_452.field_131 < 48) {
                           field_319.field_590.field_463 = false;
                           field_319.field_590.field_452.field_143 = -1;
                           field_319.field_590.field_452.field_144 = -1;
                           field_319.method_242(field_319.field_590.field_452, 0);
                           class_27.method_279(field_319.field_590.field_452, 1);
                           field_319.field_589.field_463 = false;
                           class_27.method_273(false);
                        }
                  }

                  return 1;
               default:
                  return 1;
            }
         case 172:
            switch (class_27.field_618) {
               case 0:
                  field_319.field_616 = 0;
                  class_27.method_273(false);
                  return 1;
               case 1:
                  field_319.method_232(field_319.method_228(50, 23) - class_27.field_570 / 2, class_27.method_229(50, 24) - class_27.field_571 / 2);
                  if (field_319.field_616 > 3 && field_319.field_616 < 10 && field_319.method_164() % 10 < 6) {
                     var1 = field_319.method_164() % 5 - 2;
                     var2 = field_319.method_164() % 5 - 2;
                     field_319.method_206(4, var1 + 54, var2 + 24, 54, 0);
                  }

                  switch (field_319.field_616) {
                     case 0:
                        field_319.field_616++;
                        break;
                     case 1:
                        field_319.field_693 = 7000;
                        field_319.field_616++;
                        break;
                     case 2:
                        field_319.field_706 = 20;
                        field_319.method_263(538);
                        field_319.field_616++;
                        field_319.field_619 = field_319.field_574;
                        break;
                     case 3:
                        if (var4 > 3000L) {
                           field_319.method_144(13);
                           field_319.field_706 = 21;
                           field_319.field_616++;
                           field_319.field_619 = field_319.field_574;
                        }
                        break;
                     case 4:
                        if (var4 > 100L) {
                           field_319.field_706 = 22;
                           field_319.field_616++;
                           field_319.field_619 = field_319.field_574;
                        }
                        break;
                     case 5:
                        if (var4 > 100L) {
                           field_319.field_706 = 23;
                           field_319.field_616++;
                           field_319.field_619 = field_319.field_574;
                        }
                        break;
                     case 6:
                        if (var4 > 100L) {
                           field_319.field_706 = 24;
                           field_319.field_616++;
                           field_319.field_619 = field_319.field_574;
                        }
                        break;
                     case 7:
                        if (var4 > 100L) {
                           field_319.field_706 = 25;
                           field_319.field_616++;
                           field_319.field_619 = field_319.field_574;
                        }
                        break;
                     case 8:
                        if (var4 > 500L) {
                           field_319.field_706 = 0;
                           field_319.field_616++;
                           field_319.field_619 = field_319.field_574;
                        }
                        break;
                     case 9:
                        if (var4 > 1000L) {
                           field_319.field_616++;
                        }
                        break;
                     case 10:
                        if (field_319.field_693 <= 0) {
                           field_319.method_263(538);
                           class_27.method_273(true);
                           class_27.field_780 = true;
                        }
                  }

                  return 1;
            }
         case 220:
         case 230:
         case 240:
            switch (class_27.field_618) {
               case 0:
                  if (field_319.field_709[0] == -2) {
                     class_27.method_273(true);
                     return 1;
                  }

                  byte var9 = 0;
                  if (class_27.field_617 == 220) {
                     var9 = 0;
                     var1 = 501;
                  } else if (class_27.field_617 == 230) {
                     var9 = 1;
                     var1 = 505;
                  } else if (class_27.field_617 == 240) {
                     var9 = 2;
                     var1 = 502;
                  }

                  if (field_319.field_709[var9] == -1) {
                     field_319.method_286(0, 2, class_27.method_185(159), 0);
                  } else {
                     field_319.method_265(var1, 0);
                     field_319.method_265(var1, 1);
                     field_319.method_265(var1, 2);
                     field_319.method_291(field_319.field_709[var9]);
                     field_319.field_709[var9] = -1;
                     if (field_319.field_709[0] != 23) {
                        class_9 var10;
                        (var10 = field_319.field_641[508]).field_76 = 2;
                        var10.field_77 = 22;
                        var10.field_84 = (short)field_319.method_228(var10.field_76, var10.field_77);
                        var10.field_85 = (short)class_27.method_229(var10.field_76, var10.field_77);
                        field_319.method_320();
                     }

                     if (field_319.field_709[1] != 24) {
                        class_9 var11;
                        (var11 = field_319.field_641[507]).field_76 = 2;
                        var11.field_77 = 21;
                        var11.field_84 = (short)field_319.method_228(var11.field_76, var11.field_77);
                        var11.field_85 = (short)class_27.method_229(var11.field_76, var11.field_77);
                        field_319.method_320();
                     }
                  }

                  class_27.method_273(false);
                  return 2;
               case 1:
                  if (class_27.field_594 != 131) {
                     class_27.method_273(true);
                  }

                  return 1;
               default:
                  return 0;
            }
         case 180:
            switch (class_27.field_618) {
               case 0:
                  field_319.field_616 = 1;
                  if (field_319.field_590.field_462 == 0
                     && field_319.method_186(field_319.field_590.field_452) == field_319.field_609
                     && field_319.field_590.field_452.field_131 >= 44
                     && field_319.field_590.field_452.field_132 <= 26) {
                     field_319.method_286(0, 1, class_27.method_185(141), 0);
                     field_319.field_616 = 0;
                  }

                  class_27.method_273(false);
                  return 1;
               case 1:
                  switch (field_319.field_616) {
                     case 0:
                        if (class_27.field_594 != 131) {
                           field_319.field_590.field_463 = true;
                           field_319.method_251(field_319.field_590.field_452, 29, 29);
                           field_319.field_616++;
                        }
                        break;
                     case 1:
                        field_319.method_263(164);
                        field_319.method_263(163);
                        field_319.field_621 = field_319.method_197(3, 60, 25, 5);
                        field_319.field_616++;
                        break;
                     case 2:
                        if (field_319.field_590.field_462 != 0
                           || field_319.method_186(field_319.field_590.field_452) != field_319.field_609
                           || !field_319.field_590.field_463) {
                           field_319.field_616++;
                        } else if (field_319.field_590.field_452.field_131 < 47) {
                           field_319.field_616++;
                        }
                        break;
                     case 3:
                        if (field_319.field_589.field_452.field_132 == 24) {
                           field_319.method_251(field_319.field_621, 57, 25);
                        } else {
                           field_319.method_251(field_319.field_621, 57, 24);
                        }

                        class_27.method_273(false);
                  }
               default:
                  return 1;
            }
         case 181:
            switch (class_27.field_618) {
               case 0:
                  field_319.field_616 = 0;
                  field_319.field_619 = field_319.field_574;
                  class_27.method_273(false);
                  return 1;
               case 1:
                  switch (field_319.field_616) {
                     case 0:
                        if (!class_27.method_203(field_319.field_621) && field_319.field_621.field_143 == -1 && field_319.field_621.field_144 == -1) {
                           if (field_319.field_621.field_132 == 24) {
                              class_27.method_279(field_319.field_589.field_452, 3);
                           } else {
                              class_27.method_279(field_319.field_589.field_452, 7);
                           }

                           field_319.field_619 = field_319.field_574;
                           field_319.field_616++;
                        }
                        break;
                     case 1:
                        if (var4 > 1000L) {
                           if (field_319.field_621.field_132 == 24) {
                              class_27.method_279(field_319.field_621, 3);
                           } else {
                              class_27.method_279(field_319.field_621, 7);
                           }

                           field_319.field_616++;
                           field_319.field_619 = field_319.field_574;
                        }
                        break;
                     case 2:
                        if (var4 > 1000L) {
                           if (field_319.field_621.field_132 == 24) {
                              class_27.method_279(field_319.field_621, 7);
                           } else {
                              class_27.method_279(field_319.field_621, 3);
                           }

                           field_319.field_616++;
                           field_319.field_619 = field_319.field_574;
                        }
                        break;
                     case 3:
                        if (var4 > 2500L) {
                           class_27.method_279(field_319.field_621, 1);
                           field_319.method_242(field_319.field_621, 1);
                           if (field_319.method_204(field_319.field_590.field_452)) {
                              field_319.field_590.field_463 = false;
                              field_319.method_242(field_319.field_590.field_452, 0);
                           }

                           class_27.method_273(false);
                        }
                  }

                  return 1;
               default:
                  return 0;
            }
         case 182:
            switch (class_27.field_618) {
               case 0:
                  field_319.field_590.field_463 = false;
                  field_319.field_616 = 0;
                  class_27.method_273(false);
                  return 1;
               case 1:
                  switch (field_319.field_616) {
                     case 0:
                        if (field_319.field_621.field_133 > 3) {
                           field_319.method_242(field_319.field_621, 0);
                           class_27.method_279(field_319.field_621, 1);
                           if (field_319.field_589.field_452.field_132 == 24) {
                              field_319.field_621.field_132 = 25;
                           } else {
                              field_319.field_621.field_132 = 24;
                           }

                           field_319.field_621.field_131 = 57;
                           field_319.field_616++;
                        }
                        break;
                     case 1:
                        field_319.method_286(0, 0, class_27.method_185(142), 0);
                        field_319.field_616++;
                        break;
                     case 2:
                        if (class_27.field_594 != 131) {
                           field_319.field_616++;
                           field_319.field_619 = field_319.field_574;
                        }
                        break;
                     case 3:
                        if (var4 > 1000L) {
                           field_319.method_286(0, 3, class_27.method_185(143), 0);
                           field_319.field_616++;
                        }
                        break;
                     case 4:
                        if (class_27.field_594 != 131) {
                           field_319.field_616++;
                           field_319.field_619 = field_319.field_574;
                        }
                        break;
                     case 5:
                        if (var4 > 1000L) {
                           field_319.method_286(0, 0, class_27.method_185(144), 0);
                           field_319.field_616++;
                        }
                        break;
                     case 6:
                        if (class_27.field_594 != 131) {
                           field_319.method_286(0, 6, class_27.method_185(84), 0);
                           field_319.field_616++;
                        }
                        break;
                     case 7:
                        if (class_27.field_594 != 131) {
                           field_319.method_286(0, 0, class_27.method_185(145), 0);
                           field_319.field_616++;
                        }
                        break;
                     case 8:
                        if (class_27.field_594 != 131) {
                           field_319.field_616++;
                           field_319.field_619 = field_319.field_574;
                        }
                        break;
                     case 9:
                        if (var4 > 1000L) {
                           field_319.method_286(0, 1, class_27.method_185(146), 0);
                           field_319.field_616++;
                        }
                        break;
                     case 10:
                        if (class_27.field_594 != 131) {
                           if (field_319.field_589.field_452.field_132 == 24) {
                              class_27.method_279(field_319.field_621, 3);
                           } else {
                              class_27.method_279(field_319.field_621, 7);
                           }

                           field_319.method_286(0, 0, class_27.method_185(147), 0);
                           field_319.field_616++;
                        }
                        break;
                     case 11:
                        if (class_27.field_594 != 131) {
                           field_319.method_286(0, 3, class_27.method_185(148), 0);
                           field_319.field_616++;
                        }
                        break;
                     case 12:
                        if (class_27.field_594 != 131) {
                           field_319.method_286(0, 0, class_27.method_185(149), 0);
                           field_319.field_616++;
                        }
                        break;
                     case 13:
                        if (class_27.field_594 != 131) {
                           field_319.method_286(0, 3, class_27.method_185(150), 0);
                           field_319.field_616++;
                        }
                        break;
                     case 14:
                        if (class_27.field_594 != 131) {
                           field_319.method_286(0, 0, class_27.method_185(151), 0);
                           field_319.field_616++;
                        }
                        break;
                     case 15:
                        if (class_27.field_594 != 131) {
                           field_319.method_286(0, 3, class_27.method_185(152), 0);
                           field_319.field_616++;
                        }
                        break;
                     case 16:
                        if (class_27.field_594 != 131) {
                           field_319.method_286(0, 0, class_27.method_185(153), 0);
                           field_319.field_616++;
                        }
                        break;
                     case 17:
                        if (class_27.field_594 != 131) {
                           field_319.method_286(0, 3, class_27.method_185(154), 0);
                           field_319.field_616++;
                        }
                        break;
                     case 18:
                        if (class_27.field_594 != 131) {
                           field_319.field_616++;
                           field_319.field_619 = field_319.field_574;
                        }
                        break;
                     case 19:
                        if (var4 > 1000L) {
                           field_319.method_144(36);
                           field_319.method_286(0, 6, class_27.method_185(155), 0);
                           field_319.field_616++;
                        }
                        break;
                     case 20:
                        if (class_27.field_594 != 131) {
                           field_319.field_616++;
                           field_319.field_619 = field_319.field_574;
                        }
                        break;
                     case 21:
                        if (var4 > 1000L) {
                           class_27.method_279(field_319.field_589.field_452, 5);
                           field_319.method_286(0, 0, class_27.method_185(156), 0);
                           field_319.field_616++;
                        }
                        break;
                     case 22:
                        if (class_27.field_594 != 131) {
                           class_27.method_279(field_319.field_621, 1);
                           field_319.method_286(0, 3, class_27.method_185(157), 0);
                           field_319.field_616++;
                        }
                        break;
                     case 23:
                        if (class_27.field_594 != 131) {
                           field_319.method_286(0, 0, class_27.method_185(158), 0);
                           field_319.field_616++;
                        }
                        break;
                     case 24:
                        field_319.method_251(field_319.field_621, 60, 25);
                        field_319.field_619 = field_319.field_574;
                        field_319.field_616++;
                        break;
                     case 25:
                        class_27.method_279(field_319.field_589.field_452, 1);
                        if (var4 > 2000L) {
                           method_82(field_319.field_621, 3, 3);
                           field_319.field_621.field_143 = -1;
                           field_319.field_621.field_144 = -1;
                           field_319.field_621.field_130 = false;
                           field_319.method_242(field_319.field_589.field_452, 1);
                           field_319.field_616++;
                        }
                        break;
                     case 26:
                        if (field_319.field_589.field_452.field_131 > 57) {
                           class_27.method_273(true);
                        }
                  }

                  return 1;
               default:
                  return 1;
            }
         case 190:
            switch (class_27.field_618) {
               case 0:
                  field_319.field_619 = field_319.field_574;
                  field_319.field_616 = 0;
                  class_27.method_273(false);
                  return 1;
               case 1:
                  switch (field_319.field_616) {
                     case 0:
                        if (var4 > 600L) {
                           field_319.field_701 = false;
                           class_27.method_273(false);
                        }
                     default:
                        return 1;
                  }
               default:
                  return 0;
            }
         case 191:
            switch (class_27.field_618) {
               case 0:
                  if (field_319.field_703 && field_319.field_704) {
                     field_319.method_263(214);
                     field_319.method_262(215);
                     field_319.method_262(542);
                     field_319.method_262(541);
                     field_319.field_616 = 0;
                  } else {
                     field_319.field_616 = 4;
                     field_319.field_619 = field_319.field_574;
                  }

                  class_27.method_273(false);
                  return 1;
               case 1:
                  switch (field_319.field_616) {
                     case 0:
                        method_82(field_319.field_587.field_452, field_319.field_641[542].field_76, (byte)(field_319.field_641[542].field_77 + 1));
                        field_319.field_619 = field_319.field_574;
                        field_319.field_616++;
                        break;
                     case 1:
                        if (var4 > 4000L) {
                           method_82(field_319.field_587.field_452, 58, 26);
                           field_319.field_619 = field_319.field_574;
                           field_319.field_616++;
                        }
                        break;
                     case 2:
                        if (var4 > 2000L) {
                           field_319.method_242(field_319.field_587.field_452, 0);
                           class_27.method_279(field_319.field_587.field_452, 3);
                           class_27.method_273(false);
                        }
                     case 3:
                     default:
                        break;
                     case 4:
                        if (var4 > 1500L) {
                           if (field_319.field_587.field_452.field_139 == 0) {
                              field_319.method_286(0, 0, class_27.method_185(166), 0);
                           } else {
                              field_319.method_286(0, 1, class_27.method_185(167), 0);
                           }

                           class_27.method_279(field_319.field_587.field_452, 5);
                           field_319.field_616++;
                        }
                        break;
                     case 5:
                        if (class_27.field_594 != 131) {
                           class_27.method_273(false);
                        }
                  }

                  return 1;
               default:
                  return 0;
            }
         case 192:
            switch (class_27.field_618) {
               case 0:
                  if (field_319.field_703 && field_319.field_704) {
                     field_319.method_263(215);
                     field_319.method_263(542);
                     field_319.method_263(541);
                     field_319.method_262(214);
                     field_319.method_263(212);
                     field_319.method_262(213);
                  }

                  field_319.field_619 = field_319.field_574;
                  field_319.field_616 = 0;
                  class_27.method_273(false);
                  return 1;
               case 1:
                  if (var4 > (long)class_0.field_4[field_319.field_616]) {
                     field_319.field_701 = !field_319.field_701;
                     field_319.field_616++;
                     if (field_319.field_616 > 8) {
                        class_27.method_273(true);
                        class_27.field_780 = true;
                     }
                  }

                  return 1;
               default:
                  return 0;
            }
         case 200:
            switch (class_27.field_618) {
               case 0:
                  field_319.method_144(17);
                  field_319.field_703 = true;
                  field_319.field_587.field_454[26].field_117 = false;
                  field_319.field_587.field_456--;
                  field_319.field_587.field_455 = 0;
                  field_319.method_286(0, 2, class_27.method_185(161), 0);
                  class_27.method_273(false);
                  return 1;
               case 1:
                  if (class_27.field_594 != 131) {
                     class_27.method_273(true);
                  }

                  return 1;
               default:
                  return 1;
            }
         case 210:
            switch (class_27.field_618) {
               case 0:
                  field_319.method_144(17);
                  field_319.field_704 = true;
                  field_319.field_587.field_454[27].field_117 = false;
                  field_319.field_587.field_456--;
                  field_319.field_587.field_455 = 0;
                  field_319.field_619 = field_319.field_574;
                  field_319.method_286(0, 2, class_27.method_185(162), 0);
                  class_27.method_273(false);
                  return 1;
               case 1:
                  if (class_27.field_594 != 131) {
                     class_27.method_273(true);
                  }

                  return 1;
               default:
                  return 1;
            }
         case 250:
         case 260:
         case 270:
         case 280:
         case 290:
         case 300:
         case 310:
         case 320:
         case 330:
            byte var6 = 0;
            if (class_27.field_617 == 310 || class_27.field_617 == 280 || class_27.field_617 == 250) {
               var6 = 0;
               var1 = 501;
            } else if (class_27.field_617 == 320 || class_27.field_617 == 290 || class_27.field_617 == 260) {
               var6 = 1;
               var1 = 505;
            } else if (class_27.field_617 == 330 || class_27.field_617 == 300 || class_27.field_617 == 270) {
               var6 = 2;
               var1 = 502;
            }

            if (field_319.field_709[var6] != -1) {
               class_27.method_273(true);
               return 2;
            }

            if (class_27.field_617 == 310 || class_27.field_617 == 320 || class_27.field_617 == 330) {
               field_319.field_709[var6] = 25;
               var2 = 2;
            } else if (class_27.field_617 == 280 || class_27.field_617 == 290 || class_27.field_617 == 300) {
               field_319.field_709[var6] = 24;
               var2 = 1;
            } else if (class_27.field_617 == 250 || class_27.field_617 == 260 || class_27.field_617 == 270) {
               field_319.field_709[var6] = 23;
               var2 = 0;
            }

            field_319.method_292(field_319.field_709[var6]);
            field_319.method_264(var1, var2);
            if (field_319.field_709[0] == 23) {
               class_9 var7;
               (var7 = field_319.field_641[508]).field_76 = 2;
               var7.field_77 = 23;
               var7.field_84 = (short)field_319.method_228(var7.field_76, var7.field_77);
               var7.field_85 = (short)class_27.method_229(var7.field_76, var7.field_77);
               field_319.method_320();
            }

            if (field_319.field_709[1] == 24) {
               class_9 var8;
               (var8 = field_319.field_641[507]).field_76 = 2;
               var8.field_77 = 20;
               var8.field_84 = (short)field_319.method_228(var8.field_76, var8.field_77);
               var8.field_85 = (short)class_27.method_229(var8.field_76, var8.field_77);
               field_319.method_320();
            }

            if (field_319.field_709[2] == 25 && field_319.field_709[0] == 23 && field_319.field_709[1] == 24) {
               field_319.field_641[506].field_79 = false;
               field_319.field_641[531].field_79 = true;
               field_319.field_709[0] = -2;
               field_319.field_709[1] = -2;
               field_319.field_709[2] = -2;
               field_319.method_320();
               field_319.method_144(12);
               field_319.method_286(0, 2, class_27.method_185(901), 0);
            }

            class_27.method_273(true);
            return 1;
         case 340:
            switch (class_27.field_618) {
               case 0:
                  field_319.method_288(class_27.method_185(86), (short)0, (byte)4);
                  class_27.method_273(false);
                  return 1;
               case 1:
                  if (class_27.field_594 != 137) {
                     if (field_319.field_688.charAt(0) == '2'
                        && field_319.field_688.charAt(1) == '2'
                        && field_319.field_688.charAt(2) == '3'
                        && field_319.field_688.charAt(3) == '6') {
                        field_319.method_263(531);
                        field_319.method_262(530);
                        field_319.method_144(12);
                     } else {
                        field_319.method_286(0, 2, class_27.method_185(89), 0);
                     }

                     class_27.method_273(true);
                  }

                  return 1;
               default:
                  return 0;
            }
         case 350:
            class_27.method_273(true);
            return 1;
         case 360:
            switch (class_27.field_618) {
               case 0:
                  field_319.method_289(class_27.method_185(29), (short)0);
                  class_27.method_273(false);
                  return 1;
               case 1:
                  if (class_27.field_594 != 139) {
                     if (field_319.field_725 == 3 && !field_319.field_711) {
                        field_319.field_711 = true;
                        field_319.method_292((byte)33);
                        field_319.method_291(28);
                        field_319.field_657[119].field_323 = true;
                     } else {
                        field_319.method_286(0, 2, class_27.method_185(30), 0);
                     }

                     class_27.method_273(true);
                  }

                  return 1;
               default:
                  return 0;
            }
         case 370:
            switch (class_27.field_618) {
               case 0:
                  if (field_319.field_589.field_454[19].field_117 && field_319.field_589.field_454[20].field_117 && field_319.field_589.field_454[21].field_117
                     )
                   {
                     field_319.method_286(0, 0, class_27.method_185(160), 0);
                  } else {
                     if (!field_319.field_590.field_454[19].field_117
                        || !field_319.field_590.field_454[20].field_117
                        || !field_319.field_590.field_454[21].field_117) {
                        class_27.method_273(true);
                        break;
                     }

                     field_319.method_286(0, 1, class_27.method_185(160), 0);
                  }

                  class_27.method_273(false);
                  field_319.field_616 = 0;
                  break;
               case 1:
                  if (class_27.field_594 != 131) {
                     if (field_319.field_616 == 0) {
                        field_319.field_616++;
                        if (field_319.field_589.field_454[19].field_117
                           && field_319.field_589.field_454[20].field_117
                           && field_319.field_589.field_454[21].field_117) {
                           field_319.method_294((byte)19, (byte)1);
                           field_319.method_294((byte)20, (byte)1);
                           field_319.method_294((byte)21, (byte)1);
                           field_319.method_290(22, (byte)1);
                        } else if (field_319.field_590.field_454[19].field_117
                           && field_319.field_590.field_454[20].field_117
                           && field_319.field_590.field_454[21].field_117) {
                           field_319.method_294((byte)19, (byte)2);
                           field_319.method_294((byte)20, (byte)2);
                           field_319.method_294((byte)21, (byte)2);
                           field_319.method_290(22, (byte)2);
                        }
                     } else {
                        class_27.method_273(true);
                     }
                  }
            }

            return 1;
         case 380:
            switch (class_27.field_618) {
               case 0:
                  field_319.method_262(545);
                  field_319.field_693 = 2000;
                  field_319.field_619 = field_319.field_574;
                  class_27.method_273(false);
                  field_319.method_144(35);
                  break;
               case 1:
                  if (var4 > 2000L) {
                     field_319.method_187(true);
                     class_27.method_273(true);
                  }
            }

            return 1;
         case 390:
            switch (class_27.field_618) {
               case 0:
                  class_27.method_273(false);
                  return 1;
               case 1:
                  field_319.method_222(0, true);
                  if (field_319.field_621 != null) {
                     field_319.field_621.field_130 = false;
                  }

                  if (field_319.field_623 != null) {
                     field_319.field_623.field_130 = false;
                  }

                  if (field_319.field_622 != null) {
                     field_319.field_622.field_130 = false;
                  }

                  if (method_81(field_319.field_588.field_452, 36, 18) && field_319.field_588.field_462 == 0) {
                     method_82(field_319.field_588.field_452, 35, 18);
                     field_319.method_242(field_319.field_588.field_452, 0);
                     class_27.method_279(field_319.field_588.field_452, 1);
                  } else if (field_319.field_588.field_452.field_143 == 36
                     && field_319.field_588.field_452.field_144 == 18
                     && field_319.field_588.field_462 == 0) {
                     method_82(field_319.field_588.field_452, 35, 18);
                     field_319.method_242(field_319.field_588.field_452, 0);
                     class_27.method_279(field_319.field_588.field_452, 1);
                  }

                  method_82(field_319.field_587.field_452, 36, 18);
                  field_319.method_213();
                  field_319.method_232(field_319.method_228(36, 18) - class_27.field_570 / 2, class_27.method_229(36, 18) - class_27.field_571 / 2);
                  class_27.method_279(field_319.field_587.field_452, 7);
                  field_319.method_242(field_319.field_587.field_452, 1);
                  class_27.method_273(true);
                  return 1;
               default:
                  return 0;
            }
         case 800:
            if (field_319.field_673[field_319.field_587.field_452.field_131][field_319.field_587.field_452.field_132]
                  != field_319.field_673[field_319.field_641[543].field_76][field_319.field_641[543].field_77]
               && field_319.field_716 == 1) {
               field_319.method_187(false);
            }

            field_319.method_263(545);
            class_27.method_273(true);
            field_319.method_144(12);
            return 1;
         case 820:
            switch (class_27.field_618) {
               case 0:
                  if (field_319.field_703 && field_319.field_704) {
                     field_319.method_286(0, 2, class_27.method_185(165), 0);
                  } else if (!field_319.field_703 && !field_319.field_704) {
                     field_319.method_286(0, 2, class_27.method_185(163), 0);
                  } else {
                     field_319.method_286(0, 2, class_27.method_185(164), 0);
                  }

                  class_27.method_273(false);
               default:
                  return 1;
               case 1:
                  if (class_27.field_594 != 131) {
                     class_27.method_273(true);
                  }

                  return 1;
            }
         default:
            return 0;
      }
   }
}
