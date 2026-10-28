import javax.microedition.lcdui.Graphics;
import javax.microedition.lcdui.Image;

// $VF: renamed from: y
public class class_23 extends class_22 {
   // $VF: renamed from: n int
   private static int field_453 = 0;
   // $VF: renamed from: l byte
   byte field_454 = 0;
   // $VF: renamed from: m byte
   byte field_455 = 0;
   // $VF: renamed from: o byte
   private byte field_456 = 0;
   // $VF: renamed from: p o
   private class_1 field_457 = null;
   // $VF: renamed from: q boolean
   private static boolean field_458 = false;
   // $VF: renamed from: r int
   private int field_459 = 0;
   // $VF: renamed from: s int
   private int field_460 = 0;
   // $VF: renamed from: t byte
   private byte field_461 = 0;
   // $VF: renamed from: u int
   private int field_462 = 0;
   // $VF: renamed from: v int
   private int field_463 = 0;
   // $VF: renamed from: w int
   private int field_464 = 0;
   // $VF: renamed from: x int
   private int field_465 = 0;
   // $VF: renamed from: y byte
   private byte field_466 = 0;
   // $VF: renamed from: z int
   private int field_467 = 0;
   // $VF: renamed from: A int
   private int field_468 = 0;
   // $VF: renamed from: B java.lang.String[]
   private String[] field_469 = null;
   // $VF: renamed from: C java.lang.String[]
   private String[] field_470 = null;
   // $VF: renamed from: D byte
   private byte field_471 = 0;
   // $VF: renamed from: E javax.microedition.lcdui.Image
   private Image field_472 = null;
   // $VF: renamed from: F javax.microedition.lcdui.Image
   private Image field_473 = null;
   // $VF: renamed from: G int
   private int field_474 = 0;
   // $VF: renamed from: H int
   private int field_475 = 0;
   // $VF: renamed from: I byte[]
   private byte[] field_476 = null;
   // $VF: renamed from: J byte[]
   private byte[] field_477 = null;
   // $VF: renamed from: K byte
   private byte field_478 = -1;
   // $VF: renamed from: L boolean
   private boolean field_479 = false;
   // $VF: renamed from: M boolean
   private boolean field_480 = false;
   // $VF: renamed from: N int
   private int field_481 = 0;
   // $VF: renamed from: O byte
   private byte field_482 = 0;
   // $VF: renamed from: P int
   private int field_483 = 0;
   // $VF: renamed from: Q int
   private int field_484 = 0;
   // $VF: renamed from: R int
   private int field_485 = 0;
   // $VF: renamed from: S int
   private int field_486 = 0;
   // $VF: renamed from: T int
   private int field_487 = 0;
   // $VF: renamed from: U boolean
   private boolean field_488 = true;
   // $VF: renamed from: V int
   private int field_489 = 6;

   public class_23() {
      this.field_454 = 0;
      this.field_455 = 0;
      this.method_302();
   }

   public class_23(class_7 var1, int var2, int var3, class_25 var4, boolean var5) {
      super(var1, var2, var3, var4);
      this.field_454 = 0;
      this.field_455 = 0;
      this.c();
      this.c(0);
      if (var5) {
         this.method_302();
      }
   }

   // $VF: renamed from: a (java.lang.String[], int, int, int, int, int, int, int, byte, boolean, boolean) void
   public void method_291(String[] var1, int var2, int var3, int var4, int var5, int var6, int var7, int var8, byte var9, boolean var10, boolean var11) {
      this.method_295();
      if (var1.length <= var4) {
         var4 = var1.length;
      }

      this.c = (byte)var1.length;
      this.a = var1;
      if (var11) {
         int var12 = class_17.field_152;
         if (var9 == 1) {
            var12 = var5;
         }

         this.field_470 = new String[this.a.length];

         for (int var13 = 0; var13 < this.field_470.length; var13++) {
            for (int var14 = 0; var14 < this.a[var13].length(); var14++) {
               if (this.h.method_36(this.a[var13].substring(0, var14 + 1), var8) >= var12) {
                  this.field_470[var13] = this.a[var13].substring(0, var14 - 3) + "...";
                  break;
               }

               this.field_470[var13] = this.a[var13].substring(0, var14 + 1);
            }
         }
      }

      this.field_459 = var2;
      this.field_460 = var3;
      this.field_461 = (byte)var4;
      this.field_462 = var5;
      if (var9 == 0) {
         this.field_463 = this.h.method_39(var8) + 2;
      } else if (var9 == 1) {
         this.field_463 = var6;
      } else if (var9 == 2) {
         this.field_463 = this.h.method_39(var8) + 2;
      }

      this.field_465 = var7;
      this.field_454 = (byte)(this.field_463 + this.field_465);
      this.field_455 = this.field_454;
      this.field_466 = (byte)((this.field_461 + 2) / 2);
      this.field_467 = this.field_460 - this.field_461 * (this.field_463 + this.field_465) / 2;
      this.field_468 = this.field_461 * (this.field_463 + this.field_465);
      this.field_469 = new String[this.field_461 + 2];

      for (int var15 = 0; var15 < this.field_469.length; var15++) {
         this.field_469[var15] = "";
      }

      this.c(var8);
      this.j = var8;
      this.field_471 = var9;
      this.field_479 = var10;
      this.field_480 = var11;
      this.field_476 = new byte[this.a.length];
      this.field_477 = new byte[this.a.length + 2];
      this.method_278();
      switch (this.field_471) {
         case 2:
            this.field_483 = this.field_460 - ((this.field_461 - 1) * (this.field_463 + this.field_465) + this.field_464 + this.field_465) / 2;
            this.field_484 = this.field_460 - ((this.field_461 + 1) * (this.field_463 + this.field_465) + this.field_464 + this.field_465) / 2;
            this.field_485 = this.field_460 - ((this.field_461 - 1) * (this.field_463 + this.field_465) + this.field_464 + this.field_465) / 2;
            this.field_486 = this.field_460 + ((this.field_461 - 1) * (this.field_463 + this.field_465) + this.field_464 + this.field_465) / 2;
            this.field_487 = this.field_460 - ((this.field_461 + 1) * (this.field_463 + this.field_465) + this.field_464) / 2;
            break;
         default:
            this.field_483 = this.field_460 - this.field_461 * (this.field_463 + this.field_465) / 2;
            this.field_484 = this.field_460 - (this.field_461 + 2) * (this.field_463 + this.field_465) / 2;
            this.field_485 = this.field_460 - this.field_461 * (this.field_463 + this.field_465) / 2;
            this.field_486 = this.field_460 + this.field_461 * (this.field_463 + this.field_465) / 2;
            this.field_487 = this.field_460 - (this.field_461 + 2) * (this.field_463 + this.field_465) / 2;
      }

      this.method_296();
   }

   // $VF: renamed from: g () void
   public void method_295() {
      this.b = 0;
      this.c = 0;
      this.k = 0;
      this.field_481 = 0;
      this.field_456 = 0;
      this.a = null;
      this.d = false;
      field_453 = 0;
      this.field_475 = 0;
      this.c((byte)32);
      this.c((byte)8);
      this.c((byte)16);
      this.c();
      this.field_480 = false;
      this.field_488 = true;
      this.field_482 = 0;
      System.gc();
   }

   // $VF: renamed from: e () void
   public void method_277() {
      this.k++;
      this.field_481++;
      if (this.d((byte)32)) {
         if (this.d((byte)8)) {
            field_453 += 5;
            if (this.field_471 == 2) {
               this.field_475 = this.field_475 + this.field_474;
            }

            if (field_453 >= this.field_455) {
               this.field_456--;
               if (this.field_456 < 0) {
                  this.field_456 = 0;
               }

               if (this.field_456 == 0) {
                  this.c((byte)32);
                  this.c((byte)8);
               }

               field_453 = 0;
               this.field_475 = 0;
               this.field_455 = this.field_454;
               this.b--;
               if (this.b < 0) {
                  this.b = (byte)(this.c - 1);
               }

               if (this.field_476[this.b] == 1) {
                  this.method_280(-1);
               }

               this.method_296();
            }
         }

         if (this.d((byte)16)) {
            field_453 -= 5;
            if (this.field_471 == 2) {
               this.field_475 = this.field_475 - this.field_474;
            }

            if (field_453 <= -this.field_455) {
               this.field_456--;
               if (this.field_456 < 0) {
                  this.field_456 = 0;
               }

               if (this.field_456 == 0) {
                  this.c((byte)32);
                  this.c((byte)16);
               }

               field_453 = 0;
               this.field_475 = 0;
               this.field_455 = this.field_454;
               this.b++;
               if (this.b >= this.c) {
                  this.b = 0;
               }

               if (this.field_476[this.b] == 1) {
                  this.method_280(-2);
               }

               this.method_296();
            }
         }
      }
   }

   // $VF: renamed from: h () void
   public void method_296() {
      int var1 = 0;

      for (int var2 = this.field_466; var2 < this.field_469.length; var2++) {
         String[] var3 = this.field_480 && this.field_466 == var2 ? this.a : (this.field_480 ? this.field_470 : this.a);
         this.field_469[var2] = var3[(this.b + var1) % var3.length];
         if (this.field_476[(this.b + var1) % var3.length] == 1) {
            this.field_477[var2] = 1;
         } else {
            this.field_477[var2] = 0;
         }

         var1++;
      }

      int var5 = 0;

      for (int var6 = this.field_466 - 1; var6 >= 0; var6--) {
         String[] var7 = this.field_480 ? this.field_470 : this.a;
         int var4 = this.b - 1 - var5;
         if (var4 < 0) {
            var4 += var7.length;
         }

         this.field_469[var6] = var7[var4];
         if (this.field_476[var4] == 1) {
            this.field_477[var6] = 1;
         } else {
            this.field_477[var6] = 0;
         }

         var5++;
      }
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics) void
   public void method_279(Graphics var1) {
      if (this.field_488) {
         this.method_296();
         this.field_488 = false;
      }

      this.i.method_346(var1, 16777215);
      this.i.method_345(var1, 0, this.field_467, this.e, this.field_468);

      for (int var2 = 0; var2 < this.field_461 + 2; var2++) {
         if (this.field_471 == 1) {
            this.i
               .method_344(
                  var1,
                  this.field_459 - this.field_462 / 2,
                  this.field_487 + var2 * (this.field_463 + this.field_465) + field_453,
                  this.field_462,
                  this.field_463
               );
         } else {
            if (this.field_471 != 2) {
               break;
            }

            if (this.c <= this.field_461) {
               if (var2 == this.b + 1) {
                  this.method_304(var1, this.field_459, this.field_487 + var2 * (this.field_463 + this.field_465) + field_453, this.e);
               }
            } else if (var2 == this.field_466 && !this.d((byte)32)) {
               this.method_304(var1, this.field_459, this.field_487 + var2 * (this.field_463 + this.field_465) + field_453, this.e);
            }
         }
      }

      this.i.method_346(var1, 4348185);
      if (this.c <= this.field_461) {
         this.method_297(var1);
      } else {
         this.method_298(var1);
      }

      this.i.method_345(var1, 0, 0, this.e, this.f);
      if (this.c > this.field_461) {
         this.method_299(var1);
      }
   }

   // $VF: renamed from: b (javax.microedition.lcdui.Graphics) void
   public void method_297(Graphics var1) {
      try {
         boolean var2 = true;
         int var3 = 0;
         boolean var4 = false;
         boolean var5 = false;

         for (int var6 = 0; var6 < this.field_461; var6++) {
            boolean var7 = false;
            String var8 = this.a[var6];
            boolean var12 = true;
            int var9 = this.field_463;
            int var14 = 4348185;
            int var13 = 7537664;
            if (var6 == this.b) {
               if (this.k % 10 == 0) {
                  var12 = false;
               }

               var14 = 16777215;
               var13 = 7537664;
               var3 = 0;
               if (this.field_471 == 2) {
                  var9 = this.field_464;
               }

               var7 = true;
            } else if (var6 > this.b && this.field_471 == 2) {
               var3 = this.field_464 - this.field_463;
            }

            if (this.field_476[var6] == 1) {
               var14 = 9868950;
               var13 = 9868950;
            }

            if (var12) {
               if (this.field_480 && var7) {
                  int var10 = var9 / 2 - this.h.method_39(this.j) / 2;
                  this.i.method_346(var1, var13);
                  this.h
                     .method_31(
                        var1,
                        var8,
                        this.field_459 - (this.field_471 == 2 ? this.e / 2 : this.field_462 / 2) + 1,
                        this.field_483 + var6 * (this.field_463 + this.field_465) + var3 + 1 + var10,
                        this.field_471 == 2 ? this.e : this.field_462,
                        1,
                        this.j,
                        this.field_481 * 2,
                        this.field_471 == 2 ? this.e / 4 : this.field_462 / 4,
                        10
                     );
                  this.i.method_346(var1, var14);
                  this.h
                     .method_31(
                        var1,
                        var8,
                        this.field_459 - (this.field_471 == 2 ? this.e / 2 : this.field_462 / 2),
                        this.field_483 + var6 * (this.field_463 + this.field_465) + var3 + var10,
                        this.field_471 == 2 ? this.e : this.field_462,
                        1,
                        this.j,
                        this.field_481 * 2,
                        this.field_471 == 2 ? this.e / 4 : this.field_462 / 4,
                        10
                     );
                  this.i.method_345(var1, 0, this.field_467, this.e, this.field_468);
               } else {
                  if (this.field_480) {
                     var8 = this.field_470[var6];
                  }

                  this.i.method_346(var1, var13);
                  this.h
                     .method_30(
                        var1,
                        var8,
                        this.field_459 - this.field_462 / 2 + 1,
                        this.field_483 + var6 * (this.field_463 + this.field_465) + var3 + 1,
                        this.field_462 + 1,
                        var9,
                        1,
                        this.j
                     );
                  this.i.method_346(var1, var14);
                  this.h
                     .method_30(
                        var1,
                        var8,
                        this.field_459 - this.field_462 / 2,
                        this.field_483 + var6 * (this.field_463 + this.field_465) + var3,
                        this.field_462,
                        var9,
                        1,
                        this.j
                     );
               }
            }
         }
      } catch (Exception var11) {
      }
   }

   // $VF: renamed from: c (javax.microedition.lcdui.Graphics) void
   public void method_298(Graphics var1) {
      byte var2 = 0;

      try {
         boolean var3 = true;
         int var4 = 0;
         boolean var5 = false;
         boolean var6 = false;
         boolean var7 = false;

         for (int var8 = 0; var8 < this.field_469.length; var8++) {
            boolean var9 = false;
            int var17 = this.field_475;
            boolean var14 = true;
            int var15 = 4348185;
            int var16 = 7537664;
            int var10 = this.field_463;
            byte var11 = 0;
            if (var8 == this.field_466) {
               if (this.k % 10 == 0 && !this.d((byte)32)) {
                  var14 = false;
               }

               if (!this.d((byte)32)) {
                  var15 = 16777215;
                  var16 = 7537664;
               } else {
                  var15 = 4348185;
                  var16 = 7537664;
               }

               if (this.field_471 == 2) {
                  var10 = this.field_464;
               }

               var9 = true;
            } else if (var8 > this.field_466 && this.field_471 == 2) {
               var4 = this.field_464 - this.field_463;
            }

            if (this.d((byte)8)) {
               if (var8 > this.field_466 || var8 < this.field_466 - 1) {
                  var17 = 0;
               }
            } else if (this.d((byte)16) && (var8 < this.field_466 || var8 > this.field_466 + 1)) {
               var17 = 0;
            }

            if (this.field_477[var8] == 1) {
               var15 = 9868950;
               var16 = 9868950;
            }

            if (var14) {
               if (this.field_480 && var9) {
                  int var12 = var10 / 2 - this.h.method_39(this.j) / 2;
                  this.i.method_346(var1, var16);
                  this.h
                     .method_31(
                        var1,
                        this.field_469[var8],
                        this.field_459 - (this.field_471 == 2 ? this.e / 2 : this.field_462 / 2) + 1,
                        this.field_484 + (var8 - var11) * (this.field_463 + this.field_465) + field_453 + var17 + var4 + 1 + var12,
                        this.field_471 == 2 ? this.e : this.field_462,
                        1,
                        this.j,
                        this.field_481 * 2,
                        this.field_471 == 2 ? this.e / 4 : this.field_462 / 4,
                        10
                     );
                  this.i.method_346(var1, var15);
                  this.h
                     .method_31(
                        var1,
                        this.field_469[var8],
                        this.field_459 - (this.field_471 == 2 ? this.e / 2 : this.field_462 / 2),
                        this.field_484 + (var8 - var11) * (this.field_463 + this.field_465) + field_453 + var17 + var4 + var12,
                        this.field_471 == 2 ? this.e : this.field_462,
                        1,
                        this.j,
                        this.field_481 * 2,
                        this.field_471 == 2 ? this.e / 4 : this.field_462 / 4,
                        10
                     );
                  this.i.method_345(var1, 0, this.field_467, this.e, this.field_468);
               } else {
                  this.i.method_346(var1, var16);
                  this.h
                     .method_30(
                        var1,
                        this.field_469[var8],
                        this.field_459 - this.field_462 / 2 + 1,
                        this.field_484 + (var8 - var11) * (this.field_463 + this.field_465) + field_453 + var17 + var4 + 1,
                        this.field_462,
                        var10,
                        1,
                        this.j
                     );
                  this.i.method_346(var1, var15);
                  this.h
                     .method_30(
                        var1,
                        this.field_469[var8],
                        this.field_459 - this.field_462 / 2,
                        this.field_484 + (var8 - var11) * (this.field_463 + this.field_465) + field_453 + var17 + var4,
                        this.field_462,
                        var10,
                        1,
                        this.j
                     );
               }
            }
         }
      } catch (Exception var13) {
         class_9.method_46("Text ID: " + var2 + var13.toString());
      }
   }

   // $VF: renamed from: d (javax.microedition.lcdui.Graphics) void
   public void method_299(Graphics var1) {
      boolean var2 = false;
      if (this.d((byte)8)) {
         class_25.method_321(var1, this.field_459 - 3, this.field_485 - this.field_489, 0, this.field_489, 16777215);
      } else {
         class_25.method_321(var1, this.field_459 - 3, this.field_485 - this.field_489, 0, this.field_489, 11184810);
      }

      if (this.d((byte)16)) {
         class_25.method_321(var1, this.field_459 - 3, this.field_486, 1, this.field_489, 16777215);
      } else {
         class_25.method_321(var1, this.field_459 - 3, this.field_486, 1, this.field_489, 11184810);
      }
   }

   // $VF: renamed from: f () void
   public void method_278() {
      if (this.field_471 == 2) {
         if (this.field_472 == null || this.field_478 != 0) {
            this.field_472 = class_25.method_318("/img/line_horizontal_6x6_bold.png");
         }

         if (this.field_473 == null || this.field_478 != 0) {
            this.field_473 = class_25.method_318("/img/line_vertical_6x6_normal.png");
         }

         if (this.field_473 != null) {
            this.field_464 = this.field_472.getWidth();
            if (this.field_464 < this.field_463) {
               this.field_464 = this.field_463;
            }

            this.field_467 = this.field_460 - ((this.field_461 - 1) * (this.field_463 + this.field_465) + this.field_464 + this.field_465) / 2;
            this.field_468 = (this.field_461 - 1) * (this.field_463 + this.field_465) + this.field_464 + this.field_465;
            if (this.field_464 > this.field_463) {
               this.field_474 = (byte)((this.field_464 - this.field_463) / 5 / 2);
            } else {
               this.field_474 = 0;
            }

            this.field_455 = this.field_454;
         }
      }

      this.field_478 = 0;
   }

   // $VF: renamed from: d (int) void
   public void method_300(int var1) {
      if (var1 == -1 || var1 == 50) {
         this.field_481 = 0;
         byte var3 = this.b--;
         if (this.b < 0) {
            this.b = (byte)(this.c - 1);
         }

         while (this.field_476[this.b] == 1) {
            this.b--;
            if (this.b < 0) {
               this.b = (byte)(this.c - 1);
            }

            if (this.b == var3) {
               break;
            }
         }

         this.method_303(8, 4);
         this.method_296();
      } else if (var1 != -2 && var1 != 56) {
         if (var1 == -5 || var1 == -6 && this.field_479 || var1 == 53) {
            this.method_303(6, 1);
            this.d = true;
         }
      } else {
         this.field_481 = 0;
         byte var2 = this.b++;
         if (this.b >= this.c) {
            this.b = 0;
         }

         while (this.field_476[this.b] == 1) {
            this.b++;
            if (this.b >= this.c) {
               this.b = 0;
            }

            if (this.b == var2) {
               break;
            }
         }

         this.method_303(8, 4);
         this.method_296();
      }
   }

   // $VF: renamed from: e (int) void
   public void method_301(int var1) {
      if (var1 != -1 && var1 != 50) {
         if (var1 != -2 && var1 != 56) {
            if ((var1 == -5 || var1 == -6 && this.field_479 || var1 == -6 && this.field_479 || var1 == 53) && !this.d((byte)32)) {
               this.method_303(6, 1);
               this.d = true;
            }
         } else {
            if (!this.d((byte)32)) {
               this.field_481 = 0;
               this.b((byte)32);
               this.b((byte)16);
               field_453 = 0;
               this.field_475 = 0;
               this.field_456++;
            } else {
               if (this.field_456 + 1 < 5) {
                  this.field_456++;
               }

               if (this.d((byte)8)) {
                  this.field_456 = 0;
               }
            }

            this.method_303(8, 4);
            this.method_296();
         }
      } else {
         if (!this.d((byte)32)) {
            this.field_481 = 0;
            this.b((byte)32);
            this.b((byte)8);
            field_453 = 0;
            this.field_475 = 0;
            this.field_456++;
         } else {
            if (this.field_456 + 1 < 5) {
               this.field_456++;
            }

            if (this.d((byte)16)) {
               this.field_456 = 0;
            }
         }

         this.method_303(8, 4);
         this.method_296();
      }
   }

   // $VF: renamed from: b (int) void
   public void method_280(int var1) {
      if (this.c <= this.field_461) {
         this.method_300(var1);
      } else {
         this.method_301(var1);
      }
   }

   // $VF: renamed from: i () void
   public void method_302() {
      field_458 = true;
   }

   // $VF: renamed from: a (int, int) void
   private void method_303(int var1, int var2) {
      if (field_458 && this.field_457 != null && var1 >= 0) {
         if (field_458) {
            if ((var2 & 1) != 0) {
               this.field_457.method_18((byte)var1);
            }

            if ((var2 & 4) != 0) {
               this.field_457.method_15((byte)var1);
            } else {
               this.field_457.method_14((byte)var1);
            }
         }
      }
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, int, int, int) void
   public void method_304(Graphics var1, int var2, int var3, int var4) {
      this.i.method_346(var1, 1907997);
      this.i.method_344(var1, var2 - var4 / 2, var3, var4, this.field_464);
      int var5 = this.field_472.getWidth() - this.field_472.getHeight();
      int var6 = var4 / var5 + 1;

      for (int var7 = 0; var7 < var6; var7++) {
         this.i.method_342(var1, this.field_472, var2 - var4 / 2 + var7 * var5, var3, 20);
         this.i.method_342(var1, this.field_472, var2 - var4 / 2 + var7 * var5, var3 + this.field_464 - this.field_472.getHeight(), 20);
      }
   }

   // $VF: renamed from: a (java.lang.String, int) void
   public void method_292(String var1, int var2) {
      if (var2 >= 0 && var2 < this.field_476.length) {
         this.a[var2] = var1;
         if (this.field_480) {
            int var3 = class_17.field_152;
            if (this.field_471 == 1) {
               var3 = this.field_462;
            }

            for (int var4 = 0; var4 < this.a[var2].length(); var4++) {
               if (this.h.method_36(this.a[var2].substring(0, var4 + 1), this.j) >= var3) {
                  this.field_470[var2] = this.a[var2].substring(0, var4 - 3) + "...";
                  break;
               }

               this.field_470[var2] = this.a[var2].substring(0, var4 + 1);
            }
         }

         this.method_296();
      }
   }

   // $VF: renamed from: a (int) void
   public void method_293(int var1) {
      this.field_460 = var1;
      this.field_467 = this.field_460 - ((this.field_461 - 1) * (this.field_463 + this.field_465) + this.field_464 + this.field_465) / 2;
      switch (this.field_471) {
         case 2:
            this.field_483 = this.field_460 - ((this.field_461 - 1) * (this.field_463 + this.field_465) + this.field_464 + this.field_465) / 2;
            this.field_484 = this.field_460 - ((this.field_461 + 1) * (this.field_463 + this.field_465) + this.field_464 + this.field_465) / 2;
            this.field_485 = this.field_460 - ((this.field_461 - 1) * (this.field_463 + this.field_465) + this.field_464 + this.field_465) / 2;
            this.field_486 = this.field_460 + ((this.field_461 - 1) * (this.field_463 + this.field_465) + this.field_464 + this.field_465) / 2;
            this.field_487 = this.field_460 - ((this.field_461 + 1) * (this.field_463 + this.field_465) + this.field_464) / 2;
            break;
         default:
            this.field_483 = this.field_460 - this.field_461 * (this.field_463 + this.field_465) / 2;
            this.field_484 = this.field_460 - (this.field_461 + 2) * (this.field_463 + this.field_465) / 2;
            this.field_485 = this.field_460 - this.field_461 * (this.field_463 + this.field_465) / 2;
            this.field_486 = this.field_460 + this.field_461 * (this.field_463 + this.field_465) / 2;
            this.field_487 = this.field_460 - (this.field_461 + 2) * (this.field_463 + this.field_465) / 2;
      }
   }

   // $VF: renamed from: d () int
   public int method_294() {
      int var1 = 0;
      if (this.c <= this.field_461) {
         var1 = 0;
      } else {
         var1 = this.field_489 + this.field_489;
      }

      return this.field_471 == 2
         ? (this.field_461 - 1) * (this.field_463 + this.field_465) + this.field_464 + this.field_465 + var1
         : this.field_461 * (this.field_463 + this.field_465) + var1;
   }
}
