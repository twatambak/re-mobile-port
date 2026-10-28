import javax.microedition.lcdui.Graphics;
import javax.microedition.lcdui.Image;

// $VF: renamed from: t
public class class_20 extends class_19 {
   // $VF: renamed from: o boolean
   private boolean field_415 = true;
   // $VF: renamed from: a int
   public int field_416 = 1907997;
   // $VF: renamed from: b int
   public int field_417 = 16777215;
   // $VF: renamed from: p int
   private static int field_418 = 0;
   // $VF: renamed from: q int
   private static int field_419 = 0;
   // $VF: renamed from: r int
   private static int field_420 = 0;
   // $VF: renamed from: s int
   private static int field_421 = 0;
   // $VF: renamed from: t int
   private static int field_422 = 0;
   // $VF: renamed from: u int
   private static int field_423 = 0;
   // $VF: renamed from: v int
   private static int field_424 = 0;
   // $VF: renamed from: w int
   private static int field_425 = 0;
   // $VF: renamed from: x int
   private static int field_426 = 0;
   // $VF: renamed from: y int
   private static int field_427 = 0;
   // $VF: renamed from: z int
   private static int field_428 = 0;
   // $VF: renamed from: A int
   private int field_429 = 0;
   // $VF: renamed from: B int
   private int field_430 = 2;
   // $VF: renamed from: C int
   private int field_431 = 0;
   // $VF: renamed from: D int
   private int field_432 = 0;
   // $VF: renamed from: E byte
   private byte field_433 = 0;
   // $VF: renamed from: F byte
   private byte field_434 = -1;
   // $VF: renamed from: G java.lang.String[]
   private String[] field_435 = null;
   // $VF: renamed from: H int
   private int field_436 = 0;
   // $VF: renamed from: I boolean
   private boolean field_437;
   // $VF: renamed from: c javax.microedition.lcdui.Image
   public Image field_438 = null;
   // $VF: renamed from: d javax.microedition.lcdui.Image
   public Image field_439 = null;
   // $VF: renamed from: e javax.microedition.lcdui.Image
   public Image field_440 = null;
   // $VF: renamed from: f javax.microedition.lcdui.Image
   public Image field_441 = null;
   // $VF: renamed from: g javax.microedition.lcdui.Image
   public Image field_442 = null;
   // $VF: renamed from: l javax.microedition.lcdui.Image
   public Image field_443 = null;
   // $VF: renamed from: m javax.microedition.lcdui.Image
   public Image field_444 = null;
   // $VF: renamed from: n javax.microedition.lcdui.Image
   public Image field_445 = null;

   public class_20(class_25 var1, class_7 var2, byte var3) {
      super(var2, var1, var3);
      this.h = var2;
      this.j = var3;
      this.field_429 = this.h.method_39(this.j);
      field_427 = 7;
      field_428 = 4;
      this.method_278();
   }

   // $VF: renamed from: a (java.lang.String, int, int, int, int, int, int, boolean) void
   public void method_282(String var1, int var2, int var3, int var4, int var5, int var6, int var7, boolean var8) {
      this.method_278();
      this.j = var6;
      this.field_429 = this.h.method_39(this.j);
      this.field_430 = var7;
      field_424 = var4 - (this.field_440.getWidth() + this.field_441.getWidth()) - field_427 - 2;
      field_425 = var5 - (this.field_438.getHeight() + this.field_439.getHeight());
      this.field_435 = this.h.method_38(var1, field_424, this.j, 200);
      this.field_436 = this.field_435.length;
      field_418 = var2;
      field_419 = var3;
      field_420 = var4;
      field_421 = var5;
      field_422 = field_418 - var4 / 2 + this.field_440.getWidth() + 2;
      field_423 = field_419 - field_425 / 2;
      this.field_431 = field_420 / this.field_438.getWidth() + 1;
      this.field_432 = field_421 / this.field_440.getWidth() + 1;
      this.field_433 = 0;
      field_426 = (byte)(field_425 / (this.h.method_39(this.j) + this.field_430));
      this.field_415 = var8;
      this.field_437 = false;
   }

   // $VF: renamed from: e () void
   public void method_277() {
      this.k++;
   }

   // $VF: renamed from: f () void
   public void method_278() {
      if (this.field_438 == null) {
         this.field_438 = class_25.method_318("/img/top.png");
      }

      if (this.field_439 == null) {
         this.field_439 = class_25.method_318("/img/bottom.png");
      }

      if (this.field_440 == null) {
         this.field_440 = class_25.method_318("/img/left.png");
      }

      if (this.field_441 == null) {
         this.field_441 = class_25.method_318("/img/right.png");
      }

      if (this.field_442 == null) {
         this.field_442 = class_25.method_318("/img/corner01.png");
      }

      if (this.field_443 == null) {
         this.field_443 = class_25.method_318("/img/corner02.png");
      }

      if (this.field_444 == null) {
         this.field_444 = class_25.method_318("/img/corner03.png");
      }

      if (this.field_445 == null) {
         this.field_445 = class_25.method_318("/img/corner04.png");
      }
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics) void
   public void method_279(Graphics var1) {
      short var2 = 360;
      short var3 = 384;
      this.i.method_346(var1, this.field_416);
      this.i
         .method_344(
            var1,
            field_418 - field_420 / 2 + this.field_440.getWidth() - 2,
            field_419 - field_421 / 2 + this.field_438.getHeight() - 2,
            field_420 - this.field_440.getWidth() - this.field_441.getWidth() + 4,
            field_421 - this.field_438.getHeight() - this.field_439.getHeight() + 4
         );
      this.i
         .method_345(
            var1, field_418 - field_420 / 2 + this.field_442.getWidth() / 2, field_419 - field_421 / 2, field_420 - this.field_442.getWidth(), field_421
         );

      for (int var4 = 0; var4 < this.field_431; var4++) {
         this.i.method_342(var1, this.field_438, field_418 - field_420 / 2 + var4 * this.field_438.getWidth(), field_419 - field_421 / 2, 20);
         this.i.method_342(var1, this.field_439, field_418 - field_420 / 2 + var4 * this.field_439.getWidth(), field_419 + field_421 / 2, 36);
      }

      this.i
         .method_345(
            var1, field_418 - field_420 / 2, field_419 - field_421 / 2 + this.field_444.getHeight() / 2, field_420, field_421 - this.field_444.getHeight()
         );

      for (int var9 = 0; var9 < this.field_432; var9++) {
         this.i.method_342(var1, this.field_440, field_418 - field_420 / 2, field_419 - field_421 / 2 + var9 * this.field_440.getHeight(), 20);
         this.i.method_342(var1, this.field_441, field_418 + field_420 / 2, field_419 - field_421 / 2 + var9 * this.field_441.getHeight(), 24);
      }

      this.i.method_345(var1, 0, 0, 360, 384);
      this.i.method_342(var1, this.field_442, field_418 - field_420 / 2 + this.field_440.getWidth(), field_419 - field_421 / 2 + this.field_438.getHeight(), 3);
      this.i.method_342(var1, this.field_443, field_418 + field_420 / 2 - this.field_441.getWidth(), field_419 - field_421 / 2 + this.field_438.getHeight(), 3);
      this.i.method_342(var1, this.field_444, field_418 + field_420 / 2 - this.field_440.getWidth(), field_419 + field_421 / 2 - this.field_439.getHeight(), 3);
      this.i.method_342(var1, this.field_445, field_418 - field_420 / 2 + this.field_440.getWidth(), field_419 + field_421 / 2 - this.field_439.getHeight(), 3);
      this.i.method_346(var1, this.field_417);
      int var10 = 0;
      int var5 = 0;
      int var6 = 0;
      if (this.field_415) {
         for (int var7 = this.field_433; var7 < this.field_436 && var6 < field_426; var7++) {
            var6++;
         }

         var5 = field_419 - var6 * (this.field_429 + this.field_430) / 2;
      }

      try {
         for (int var11 = this.field_433; var11 < this.field_436 && var10 < field_426; var11++) {
            if (this.field_415) {
               this.h.method_29(var1, this.field_435[var11], field_422, var5 + (this.field_429 + this.field_430) * var10, field_424, 1, this.j);
            } else {
               this.h.method_29(var1, this.field_435[var11], field_422, field_423 + (this.field_429 + this.field_430) * var10, field_424, 4, this.j);
            }

            var10++;
         }
      } catch (Exception var8) {
      }

      if (this.k % 10 != 0) {
         if (this.field_433 > 0) {
            class_25.method_321(var1, field_422 + field_424, field_423 + 1, 0, field_428, 16777215);
         }

         if (this.field_436 > field_426 && this.field_433 < this.field_436 - field_426) {
            class_25.method_321(var1, field_422 + field_424, field_423 + field_425 - field_428 - 1, 1, field_428, 16777215);
         }
      }

      this.i.method_345(var1, 0, 0, 360, 384);
   }

   // $VF: renamed from: b (int) void
   public void method_280(int var1) {
      if (var1 == -1 || var1 == 50) {
         this.field_433 = (byte)(this.field_433 - (field_426 - 1));
         if (this.field_433 < 0) {
            this.field_433 = 0;
         }
      }

      if ((var1 == -2 || var1 == 56) && this.field_433 < this.field_436 - field_426) {
         this.field_433 = (byte)(this.field_433 + (field_426 - 1));
      }
   }

   // $VF: renamed from: a () int
   public int method_283() {
      return field_426;
   }
}
