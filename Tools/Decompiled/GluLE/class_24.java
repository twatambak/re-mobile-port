import javax.microedition.lcdui.Graphics;

// $VF: renamed from: x
public class class_24 extends class_22 {
   // $VF: renamed from: l int
   private int field_490 = 0;
   // $VF: renamed from: m int
   private int field_491 = 0;
   // $VF: renamed from: n byte
   private byte field_492 = 0;
   // $VF: renamed from: o int
   private int field_493 = 0;
   // $VF: renamed from: p int
   private int field_494 = 0;
   // $VF: renamed from: q int
   private int field_495 = 26;
   // $VF: renamed from: r int
   private int field_496 = 0;
   // $VF: renamed from: s byte
   private byte field_497 = 0;
   // $VF: renamed from: t int
   private int field_498 = 0;
   // $VF: renamed from: u int
   private int field_499 = 0;
   // $VF: renamed from: v java.lang.String[]
   private String[] field_500 = null;
   // $VF: renamed from: w java.lang.String[]
   private String[] field_501 = null;
   // $VF: renamed from: x byte
   private byte field_502 = 0;
   // $VF: renamed from: y byte[]
   private byte[] field_503 = null;
   // $VF: renamed from: z byte[]
   private byte[] field_504 = null;
   // $VF: renamed from: A byte
   private byte field_505 = -1;
   // $VF: renamed from: B boolean
   private boolean field_506 = false;
   // $VF: renamed from: C boolean
   private boolean field_507 = false;
   // $VF: renamed from: D int
   private int field_508 = 0;
   // $VF: renamed from: E byte
   private byte field_509 = 17;
   // $VF: renamed from: F byte
   private byte field_510 = 9;
   // $VF: renamed from: G byte
   private byte field_511 = 0;
   // $VF: renamed from: H int
   private int field_512 = 0;
   // $VF: renamed from: I int
   private int field_513 = 0;
   // $VF: renamed from: J int
   private int field_514 = 0;
   // $VF: renamed from: K int
   private int field_515 = 0;
   // $VF: renamed from: L int
   private int field_516 = 0;
   // $VF: renamed from: M boolean
   private boolean field_517 = true;

   public class_24() {
   }

   public class_24(class_7 var1, int var2, int var3, class_25 var4) {
      super(var1, var2, var3, var4);
      this.c();
      this.c(0);
   }

   // $VF: renamed from: a (java.lang.String[], int, int, int, int, int, int, int, byte, boolean, boolean) void
   public void method_291(String[] var1, int var2, int var3, int var4, int var5, int var6, int var7, int var8, byte var9, boolean var10, boolean var11) {
      this.method_305();
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

         this.field_501 = new String[this.a.length];

         for (int var13 = 0; var13 < this.field_501.length; var13++) {
            for (int var14 = 0; var14 < this.a[var13].length(); var14++) {
               if (this.h.method_36(this.a[var13].substring(0, var14 + 1), var8) >= var12) {
                  this.field_501[var13] = this.a[var13].substring(0, var14 - 3) + "...";
                  break;
               }

               this.field_501[var13] = this.a[var13].substring(0, var14 + 1);
            }
         }
      }

      this.field_490 = var2;
      this.field_491 = var3;
      this.field_492 = (byte)var4;
      this.field_493 = var5;
      if (var9 == 0) {
         this.field_494 = this.h.method_39(var8) + 2;
      } else if (var9 == 1) {
         this.field_494 = var6;
      } else if (var9 == 2) {
         this.field_494 = this.h.method_39(var8) + 2;
      }

      this.field_496 = var7;
      this.field_497 = (byte)((this.field_492 + 2) / 2);
      this.field_498 = this.field_491 - this.field_492 * (this.field_494 + this.field_496) / 2;
      this.field_499 = this.field_492 * (this.field_494 + this.field_496);
      this.field_500 = new String[this.field_492 + 2];

      for (int var15 = 0; var15 < this.field_500.length; var15++) {
         this.field_500[var15] = "";
      }

      this.c(var8);
      this.j = var8;
      this.field_502 = var9;
      this.field_506 = var10;
      this.field_507 = var11;
      this.field_503 = new byte[this.a.length];
      this.field_504 = new byte[this.a.length + 2];
      this.method_278();
      switch (this.field_502) {
         case 2:
            this.field_512 = this.field_491 - ((this.field_492 - 1) * (this.field_494 + this.field_496) + this.field_495 + this.field_496) / 2;
            this.field_513 = this.field_491 - ((this.field_492 + 1) * (this.field_494 + this.field_496) + this.field_495 + this.field_496) / 2;
            this.field_514 = this.field_491 - ((this.field_492 - 1) * (this.field_494 + this.field_496) + this.field_495 + this.field_496) / 2;
            this.field_515 = this.field_491 + ((this.field_492 - 1) * (this.field_494 + this.field_496) + this.field_495 + this.field_496) / 2;
            this.field_516 = this.field_491 - ((this.field_492 + 1) * (this.field_494 + this.field_496) + this.field_495) / 2;
            break;
         default:
            this.field_512 = this.field_491 - this.field_492 * (this.field_494 + this.field_496) / 2;
            this.field_513 = this.field_491 - (this.field_492 + 2) * (this.field_494 + this.field_496) / 2;
            this.field_514 = this.field_491 - this.field_492 * (this.field_494 + this.field_496) / 2;
            this.field_515 = this.field_491 + this.field_492 * (this.field_494 + this.field_496) / 2;
            this.field_516 = this.field_491 - (this.field_492 + 2) * (this.field_494 + this.field_496) / 2;
      }

      this.method_306();
   }

   // $VF: renamed from: g () void
   public void method_305() {
      this.b = 0;
      this.c = 0;
      this.k = 0;
      this.field_508 = 0;
      this.a = null;
      this.d = false;
      this.c((byte)32);
      this.c((byte)8);
      this.c((byte)16);
      this.c();
      this.field_507 = false;
      this.field_517 = true;
      System.gc();
   }

   // $VF: renamed from: e () void
   public void method_277() {
      this.k++;
      this.field_508++;
      if (this.d((byte)8)) {
         if (this.field_511 == 0) {
            this.field_511 = 3;
         } else {
            this.field_511--;
            if (this.field_511 == 0) {
               this.c((byte)8);
            }
         }
      } else if (this.d((byte)16)) {
         if (this.field_511 == 0) {
            this.field_511 = 3;
         } else {
            this.field_511--;
            if (this.field_511 == 0) {
               this.c((byte)16);
            }
         }
      }
   }

   // $VF: renamed from: h () void
   public void method_306() {
      int var1 = 0;

      for (int var2 = this.field_497; var2 < this.field_500.length; var2++) {
         String[] var3 = this.field_507 && this.field_497 == var2 ? this.a : (this.field_507 ? this.field_501 : this.a);
         this.field_500[var2] = var3[(this.b + var1) % var3.length];
         if (this.field_503[(this.b + var1) % var3.length] == 1) {
            this.field_504[var2] = 1;
         } else {
            this.field_504[var2] = 0;
         }

         var1++;
      }

      int var5 = 0;

      for (int var6 = this.field_497 - 1; var6 >= 0; var6--) {
         String[] var7 = this.field_507 ? this.field_501 : this.a;
         int var4 = this.b - 1 - var5;
         if (var4 < 0) {
            var4 += var7.length;
         }

         this.field_500[var6] = var7[var4];
         if (this.field_503[var4] == 1) {
            this.field_504[var6] = 1;
         } else {
            this.field_504[var6] = 0;
         }

         var5++;
      }
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics) void
   public void method_279(Graphics var1) {
      if (this.field_517) {
         this.method_306();
         this.field_517 = false;
      }

      this.i.method_346(var1, 16777215);
      this.i.method_345(var1, 0, this.field_498, this.e, this.field_499);

      for (int var2 = 0; var2 < this.field_492 + 2; var2++) {
         if (this.field_502 == 1) {
            this.i
               .method_344(var1, this.field_490 - this.field_493 / 2, this.field_516 + var2 * (this.field_494 + this.field_496), this.field_493, this.field_494);
         } else {
            if (this.field_502 != 2) {
               break;
            }

            if (this.c <= this.field_492) {
               if (var2 == this.b + 1) {
                  this.method_312(var1, this.field_490, this.field_516 + var2 * (this.field_494 + this.field_496), this.e);
               }
            } else if (var2 == this.field_497 && !this.d((byte)32)) {
               this.method_312(var1, this.field_490, this.field_516 + var2 * (this.field_494 + this.field_496), this.e);
            }
         }
      }

      this.i.method_346(var1, 4348185);
      if (this.c <= this.field_492) {
         this.method_307(var1);
      } else {
         this.method_308(var1);
      }

      this.i.method_345(var1, 0, 0, this.e, this.f);
      if (this.c > this.field_492) {
         this.method_309(var1);
      }
   }

   // $VF: renamed from: b (javax.microedition.lcdui.Graphics) void
   public void method_307(Graphics var1) {
      try {
         boolean var2 = true;
         int var3 = 0;
         boolean var4 = false;
         boolean var5 = false;

         for (int var6 = 0; var6 < this.field_492; var6++) {
            boolean var7 = false;
            String var8 = this.a[var6];
            boolean var12 = true;
            int var9 = this.field_494;
            int var14 = 4348185;
            int var13 = 7537664;
            if (var6 == this.b) {
               if (this.k % 10 == 0) {
                  var12 = false;
               }

               var14 = 16777215;
               var13 = 7537664;
               var3 = 0;
               if (this.field_502 == 2) {
                  var9 = this.field_495;
               }

               var7 = true;
            } else if (var6 > this.b && this.field_502 == 2) {
               var3 = this.field_495 - this.field_494;
            }

            if (this.field_503[var6] == 1) {
               var14 = 9868950;
               var13 = 9868950;
            }

            if (var12) {
               if (this.field_507 && var7) {
                  int var10 = var9 / 2 - this.h.method_39(this.j) / 2;
                  this.i.method_346(var1, var13);
                  this.h
                     .method_31(
                        var1,
                        var8,
                        this.field_490 - (this.field_502 == 2 ? this.e / 2 : this.field_493 / 2) + 1,
                        this.field_512 + var6 * (this.field_494 + this.field_496) + var3 + 1 + var10,
                        this.field_502 == 2 ? this.e : this.field_493,
                        1,
                        this.j,
                        this.field_508 * 2,
                        this.field_502 == 2 ? this.e / 4 : this.field_493 / 4,
                        10
                     );
                  this.i.method_346(var1, var14);
                  this.h
                     .method_31(
                        var1,
                        var8,
                        this.field_490 - (this.field_502 == 2 ? this.e / 2 : this.field_493 / 2),
                        this.field_512 + var6 * (this.field_494 + this.field_496) + var3 + var10,
                        this.field_502 == 2 ? this.e : this.field_493,
                        1,
                        this.j,
                        this.field_508 * 2,
                        this.field_502 == 2 ? this.e / 4 : this.field_493 / 4,
                        10
                     );
                  this.i.method_345(var1, 0, this.field_498, this.e, this.field_499);
               } else {
                  if (this.field_507) {
                     var8 = this.field_501[var6];
                  }

                  this.i.method_346(var1, var13);
                  this.h
                     .method_30(
                        var1,
                        var8,
                        this.field_490 - this.field_493 / 2 + 1,
                        this.field_512 + var6 * (this.field_494 + this.field_496) + var3 + 1,
                        this.field_493 + 1,
                        var9,
                        1,
                        this.j
                     );
                  this.i.method_346(var1, var14);
                  this.h
                     .method_30(
                        var1,
                        var8,
                        this.field_490 - this.field_493 / 2,
                        this.field_512 + var6 * (this.field_494 + this.field_496) + var3,
                        this.field_493,
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
   public void method_308(Graphics var1) {
      byte var2 = 0;

      try {
         boolean var3 = true;
         int var4 = 0;
         boolean var5 = false;
         boolean var6 = false;

         for (int var7 = 0; var7 < this.field_500.length; var7++) {
            boolean var8 = false;
            boolean var13 = true;
            int var14 = 4348185;
            int var15 = 7537664;
            int var9 = this.field_494;
            byte var10 = 0;
            if (var7 == this.field_497) {
               if (this.k % 10 == 0 && !this.d((byte)32)) {
                  var13 = false;
               }

               if (!this.d((byte)32)) {
                  var14 = 16777215;
                  var15 = 7537664;
               } else {
                  var14 = 4348185;
                  var15 = 7537664;
               }

               if (this.field_502 == 2) {
                  var9 = this.field_495;
               }

               var8 = true;
            } else if (var7 > this.field_497 && this.field_502 == 2) {
               var4 = this.field_495 - this.field_494;
            }

            if (!this.d((byte)8) && this.d((byte)16)) {
            }

            if (this.field_504[var7] == 1) {
               var14 = 9868950;
               var15 = 9868950;
            }

            if (var13) {
               if (this.field_507 && var8) {
                  int var11 = var9 / 2 - this.h.method_39(this.j) / 2;
                  this.i.method_346(var1, var15);
                  this.h
                     .method_31(
                        var1,
                        this.field_500[var7],
                        this.field_490 - (this.field_502 == 2 ? this.e / 2 : this.field_493 / 2) + 1,
                        this.field_513 + (var7 - var10) * (this.field_494 + this.field_496) + var4 + 1 + var11,
                        this.field_502 == 2 ? this.e : this.field_493,
                        1,
                        this.j,
                        this.field_508 * 2,
                        this.field_502 == 2 ? this.e / 4 : this.field_493 / 4,
                        10
                     );
                  this.i.method_346(var1, var14);
                  this.h
                     .method_31(
                        var1,
                        this.field_500[var7],
                        this.field_490 - (this.field_502 == 2 ? this.e / 2 : this.field_493 / 2),
                        this.field_513 + (var7 - var10) * (this.field_494 + this.field_496) + var4 + var11,
                        this.field_502 == 2 ? this.e : this.field_493,
                        1,
                        this.j,
                        this.field_508 * 2,
                        this.field_502 == 2 ? this.e / 4 : this.field_493 / 4,
                        10
                     );
                  this.i.method_345(var1, 0, this.field_498, this.e, this.field_499);
               } else {
                  this.i.method_346(var1, var15);
                  this.h
                     .method_30(
                        var1,
                        this.field_500[var7],
                        this.field_490 - this.field_493 / 2 + 1,
                        this.field_513 + (var7 - var10) * (this.field_494 + this.field_496) + var4 + 1,
                        this.field_493,
                        var9,
                        1,
                        this.j
                     );
                  this.i.method_346(var1, var14);
                  this.h
                     .method_30(
                        var1,
                        this.field_500[var7],
                        this.field_490 - this.field_493 / 2,
                        this.field_513 + (var7 - var10) * (this.field_494 + this.field_496) + var4,
                        this.field_493,
                        var9,
                        1,
                        this.j
                     );
               }
            }
         }
      } catch (Exception var12) {
         class_9.method_46("Text ID: " + var2 + var12.toString());
      }
   }

   // $VF: renamed from: d (javax.microedition.lcdui.Graphics) void
   public void method_309(Graphics var1) {
      int var2 = 0;
      boolean var3 = false;
      if (!this.d((byte)8)) {
         var2 = 0;
      } else {
         var2 = 10310687;
      }

      class_25.method_321(var1, this.field_490 - 4, this.field_514 - this.field_510, 0, this.field_510, var2);
      if (!this.d((byte)16)) {
         var2 = 0;
      } else {
         var2 = 10310687;
      }

      class_25.method_321(var1, this.field_490 - 4, this.field_515, 1, this.field_510, var2);
   }

   // $VF: renamed from: f () void
   public void method_278() {
      if (this.field_502 == 2) {
         this.field_498 = this.field_491 - ((this.field_492 - 1) * (this.field_494 + this.field_496) + this.field_495 + this.field_496) / 2;
         this.field_499 = (this.field_492 - 1) * (this.field_494 + this.field_496) + this.field_495 + this.field_496;
      }

      this.field_505 = 0;
   }

   // $VF: renamed from: d (int) void
   public void method_310(int var1) {
      if (var1 == -1) {
         this.field_508 = 0;
         byte var2 = this.b--;
         if (this.b < 0) {
            this.b = (byte)(this.c - 1);
         }

         while (this.field_503[this.b] == 1) {
            this.b--;
            if (this.b < 0) {
               this.b = (byte)(this.c - 1);
            }

            if (this.b == var2) {
               break;
            }
         }

         this.method_306();
      } else if (var1 == -2) {
         this.field_508 = 0;
         byte var3 = this.b++;
         if (this.b >= this.c) {
            this.b = 0;
         }

         while (this.field_503[this.b] == 1) {
            this.b++;
            if (this.b >= this.c) {
               this.b = 0;
            }

            if (this.b == var3) {
               break;
            }
         }

         this.method_306();
      } else if (var1 == -5 || var1 == -6 && this.field_506) {
         this.d = true;
         this.method_306();
      }
   }

   // $VF: renamed from: e (int) void
   public void method_311(int var1) {
      if (var1 == -1) {
         this.field_508 = 0;
         this.b((byte)8);
         this.field_511 = 0;
         this.c((byte)16);
         byte var2 = this.b--;
         if (this.b < 0) {
            this.b = (byte)(this.c - 1);
         }

         while (this.field_503[this.b] == 1) {
            this.b--;
            if (this.b < 0) {
               this.b = (byte)(this.c - 1);
            }

            if (this.b == var2) {
               break;
            }
         }

         this.method_306();
      } else if (var1 == -2) {
         this.field_508 = 0;
         this.b((byte)16);
         this.field_511 = 0;
         this.c((byte)8);
         byte var3 = this.b++;
         if (this.b >= this.c) {
            this.b = 0;
         }

         while (this.field_503[this.b] == 1) {
            this.b++;
            if (this.b >= this.c) {
               this.b = 0;
            }

            if (this.b == var3) {
               break;
            }
         }

         this.method_306();
      } else if (var1 == -5 || var1 == -6 && this.field_506) {
         this.d = true;
         this.method_306();
      }
   }

   // $VF: renamed from: b (int) void
   public void method_280(int var1) {
      if (this.c <= this.field_492) {
         this.method_310(var1);
      } else {
         this.method_311(var1);
      }
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, int, int, int) void
   public void method_312(Graphics var1, int var2, int var3, int var4) {
      this.i.method_346(var1, 16767112);
      this.i.method_344(var1, var2 - var4 / 2, var3, var4, this.field_495);
      this.i.method_346(var1, 0);
      this.i.method_344(var1, var2 - var4 / 2, var3, var4, 3);
      this.i.method_344(var1, var2 - var4 / 2, var3 + this.field_495 - 3, var4, 3);
   }

   // $VF: renamed from: a (java.lang.String, int) void
   public void method_292(String var1, int var2) {
      if (var2 >= 0 && var2 < this.field_503.length) {
         this.a[var2] = var1;
         if (this.field_507) {
            int var3 = class_17.field_152;
            if (this.field_502 == 1) {
               var3 = this.field_493;
            }

            for (int var4 = 0; var4 < this.a[var2].length(); var4++) {
               if (this.h.method_36(this.a[var2].substring(0, var4 + 1), this.j) >= var3) {
                  this.field_501[var2] = this.a[var2].substring(0, var4 - 3) + "...";
                  break;
               }

               this.field_501[var2] = this.a[var2].substring(0, var4 + 1);
            }
         }

         this.method_306();
      }
   }

   // $VF: renamed from: a (int) void
   public void method_293(int var1) {
      this.field_491 = var1;
      this.field_498 = this.field_491 - ((this.field_492 - 1) * (this.field_494 + this.field_496) + this.field_495 + this.field_496) / 2;
      switch (this.field_502) {
         case 2:
            this.field_512 = this.field_491 - ((this.field_492 - 1) * (this.field_494 + this.field_496) + this.field_495 + this.field_496) / 2;
            this.field_513 = this.field_491 - ((this.field_492 + 1) * (this.field_494 + this.field_496) + this.field_495 + this.field_496) / 2;
            this.field_514 = this.field_491 - ((this.field_492 - 1) * (this.field_494 + this.field_496) + this.field_495 + this.field_496) / 2;
            this.field_515 = this.field_491 + ((this.field_492 - 1) * (this.field_494 + this.field_496) + this.field_495 + this.field_496) / 2;
            this.field_516 = this.field_491 - ((this.field_492 + 1) * (this.field_494 + this.field_496) + this.field_495) / 2;
            break;
         default:
            this.field_512 = this.field_491 - this.field_492 * (this.field_494 + this.field_496) / 2;
            this.field_513 = this.field_491 - (this.field_492 + 2) * (this.field_494 + this.field_496) / 2;
            this.field_514 = this.field_491 - this.field_492 * (this.field_494 + this.field_496) / 2;
            this.field_515 = this.field_491 + this.field_492 * (this.field_494 + this.field_496) / 2;
            this.field_516 = this.field_491 - (this.field_492 + 2) * (this.field_494 + this.field_496) / 2;
      }
   }

   // $VF: renamed from: d () int
   public int method_294() {
      return this.field_502 == 2
         ? (this.field_492 - 1) * (this.field_494 + this.field_496) + this.field_495 + this.field_496
         : this.field_492 * (this.field_494 + this.field_496);
   }
}
