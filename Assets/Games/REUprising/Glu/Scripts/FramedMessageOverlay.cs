// Transpiled from Java (FramedMessageOverlay.java) by Tools/J2meToCs. Regenerate rather than hand-edit where possible.
#pragma warning disable CS0162, CS0164, CS0168, CS0169, CS0219, CS0414, CS0649, CS1717, CS0108, CS0659, CS0661
using J2ME;

namespace REUprising.Glu
{
// $VF: renamed from: t
public class FramedMessageOverlay : GameOverlay {
   static FramedMessageOverlay() { }

   // $VF: renamed from: o boolean
   public bool isCentered = true;
   // $VF: renamed from: a int
   public int textColor = 1907997;
   // $VF: renamed from: b int
   public int frameColor = 16777215;
   // $VF: renamed from: p int
   public static int dialogCenterX = 0;
   // $VF: renamed from: q int
   public static int dialogCenterY = 0;
   // $VF: renamed from: r int
   public static int dialogWidth = 0;
   // $VF: renamed from: s int
   public static int dialogHeight = 0;
   // $VF: renamed from: t int
   public static int textLeft = 0;
   // $VF: renamed from: u int
   public static int textTop = 0;
   // $VF: renamed from: v int
   public static int textAreaWidth = 0;
   // $VF: renamed from: w int
   public static int textAreaHeight = 0;
   // $VF: renamed from: x int
   public static int visibleLineLimit = 0;
   // $VF: renamed from: y int
   public static int horizontalBorderInset = 0;
   // $VF: renamed from: z int
   public static int verticalBorderInset = 0;
   // $VF: renamed from: A int
   public int lineHeight = 0;
   // $VF: renamed from: B int
   public int lineSpacing = 2;
   // $VF: renamed from: C int
   public int horizontalTileCount = 0;
   // $VF: renamed from: D int
   public int verticalTileCount = 0;
   // $VF: renamed from: E byte
   public sbyte scrollOffset = 0;
   // $VF: renamed from: F byte
   public sbyte selectedLineIndex = -1;
   // $VF: renamed from: G java.lang.String[]
   public string[] wrappedTextLines = null;
   // $VF: renamed from: H int
   public int wrappedLineCount = 0;
   // $VF: renamed from: I boolean
   public bool hasSelection;
   // $VF: renamed from: c javax.microedition.lcdui.Image
   public Image topBorderImage = null;
   // $VF: renamed from: d javax.microedition.lcdui.Image
   public Image bottomBorderImage = null;
   // $VF: renamed from: e javax.microedition.lcdui.Image
   public Image leftBorderImage = null;
   // $VF: renamed from: f javax.microedition.lcdui.Image
   public Image rightBorderImage = null;
   // $VF: renamed from: g javax.microedition.lcdui.Image
   public Image topLeftCornerImage = null;
   // $VF: renamed from: l javax.microedition.lcdui.Image
   public Image topRightCornerImage = null;
   // $VF: renamed from: m javax.microedition.lcdui.Image
   public Image bottomLeftCornerImage = null;
   // $VF: renamed from: n javax.microedition.lcdui.Image
   public Image bottomRightCornerImage = null;

   public FramedMessageOverlay(GameCanvas var1, BitmapFontRenderer var2, sbyte var3) : base(var2, var1, var3) {
      
      this.fontRenderer = var2;
      this.fontIndex = var3;
      this.lineHeight = this.fontRenderer.getFontBaselineOffset(this.fontIndex);
      horizontalBorderInset = 7;
      verticalBorderInset = 4;
      this.loadOverlayResources();
   }

   // $VF: renamed from: a (java.lang.String, int, int, int, int, int, int, boolean) void
   public void configureMessageOverlay(string var1, int var2, int var3, int var4, int var5, int var6, int var7, bool var8) {
      this.loadOverlayResources();
      this.fontIndex = var6;
      this.lineHeight = this.fontRenderer.getFontBaselineOffset(this.fontIndex);
      this.lineSpacing = var7;
      textAreaWidth = var4 - (this.leftBorderImage.getWidth() + this.rightBorderImage.getWidth()) - horizontalBorderInset - 2;
      textAreaHeight = var5 - (this.topBorderImage.getHeight() + this.bottomBorderImage.getHeight());
      this.wrappedTextLines = this.fontRenderer.wrapText(var1, textAreaWidth, this.fontIndex, 200);
      this.wrappedLineCount = this.wrappedTextLines.Length;
      dialogCenterX = var2;
      dialogCenterY = var3;
      dialogWidth = var4;
      dialogHeight = var5;
      textLeft = dialogCenterX - var4 / 2 + this.leftBorderImage.getWidth() + 2;
      textTop = dialogCenterY - textAreaHeight / 2;
      this.horizontalTileCount = dialogWidth / this.topBorderImage.getWidth() + 1;
      this.verticalTileCount = dialogHeight / this.leftBorderImage.getWidth() + 1;
      this.scrollOffset = 0;
      visibleLineLimit = (sbyte)(textAreaHeight / (this.fontRenderer.getFontBaselineOffset(this.fontIndex) + this.lineSpacing));
      this.isCentered = var8;
      this.hasSelection = false;
   }

   // $VF: renamed from: e () void
   public override void updateOverlayAnimation() {
      this.animationTick++;
   }

   // $VF: renamed from: f () void
   public override void loadOverlayResources() {
      if (this.topBorderImage == null) {
         this.topBorderImage = GameCanvas.loadImageResource("/img/top.png");
      }

      if (this.bottomBorderImage == null) {
         this.bottomBorderImage = GameCanvas.loadImageResource("/img/bottom.png");
      }

      if (this.leftBorderImage == null) {
         this.leftBorderImage = GameCanvas.loadImageResource("/img/left.png");
      }

      if (this.rightBorderImage == null) {
         this.rightBorderImage = GameCanvas.loadImageResource("/img/right.png");
      }

      if (this.topLeftCornerImage == null) {
         this.topLeftCornerImage = GameCanvas.loadImageResource("/img/corner01.png");
      }

      if (this.topRightCornerImage == null) {
         this.topRightCornerImage = GameCanvas.loadImageResource("/img/corner02.png");
      }

      if (this.bottomLeftCornerImage == null) {
         this.bottomLeftCornerImage = GameCanvas.loadImageResource("/img/corner03.png");
      }

      if (this.bottomRightCornerImage == null) {
         this.bottomRightCornerImage = GameCanvas.loadImageResource("/img/corner04.png");
      }
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics) void
   public override void drawOverlay(Graphics var1) {
      short var2 = 360;
      short var3 = 384;
      this.gameCanvas.setGraphicsColor(var1, this.textColor);
      this.gameCanvas
         .fillCanvasRectangle(
            var1,
            dialogCenterX - dialogWidth / 2 + this.leftBorderImage.getWidth() - 2,
            dialogCenterY - dialogHeight / 2 + this.topBorderImage.getHeight() - 2,
            dialogWidth - this.leftBorderImage.getWidth() - this.rightBorderImage.getWidth() + 4,
            dialogHeight - this.topBorderImage.getHeight() - this.bottomBorderImage.getHeight() + 4
         );
      this.gameCanvas
         .setGraphicsClip(
            var1, dialogCenterX - dialogWidth / 2 + this.topLeftCornerImage.getWidth() / 2, dialogCenterY - dialogHeight / 2, dialogWidth - this.topLeftCornerImage.getWidth(), dialogHeight
         );

      for (int var4 = 0; var4 < this.horizontalTileCount; var4++) {
         this.gameCanvas.drawImage(var1, this.topBorderImage, dialogCenterX - dialogWidth / 2 + var4 * this.topBorderImage.getWidth(), dialogCenterY - dialogHeight / 2, 20);
         this.gameCanvas.drawImage(var1, this.bottomBorderImage, dialogCenterX - dialogWidth / 2 + var4 * this.bottomBorderImage.getWidth(), dialogCenterY + dialogHeight / 2, 36);
      }

      this.gameCanvas
         .setGraphicsClip(
            var1, dialogCenterX - dialogWidth / 2, dialogCenterY - dialogHeight / 2 + this.bottomLeftCornerImage.getHeight() / 2, dialogWidth, dialogHeight - this.bottomLeftCornerImage.getHeight()
         );

      for (int var9 = 0; var9 < this.verticalTileCount; var9++) {
         this.gameCanvas.drawImage(var1, this.leftBorderImage, dialogCenterX - dialogWidth / 2, dialogCenterY - dialogHeight / 2 + var9 * this.leftBorderImage.getHeight(), 20);
         this.gameCanvas.drawImage(var1, this.rightBorderImage, dialogCenterX + dialogWidth / 2, dialogCenterY - dialogHeight / 2 + var9 * this.rightBorderImage.getHeight(), 24);
      }

      this.gameCanvas.setGraphicsClip(var1, 0, 0, 360, 384);
      this.gameCanvas.drawImage(var1, this.topLeftCornerImage, dialogCenterX - dialogWidth / 2 + this.leftBorderImage.getWidth(), dialogCenterY - dialogHeight / 2 + this.topBorderImage.getHeight(), 3);
      this.gameCanvas.drawImage(var1, this.topRightCornerImage, dialogCenterX + dialogWidth / 2 - this.rightBorderImage.getWidth(), dialogCenterY - dialogHeight / 2 + this.topBorderImage.getHeight(), 3);
      this.gameCanvas.drawImage(var1, this.bottomLeftCornerImage, dialogCenterX + dialogWidth / 2 - this.leftBorderImage.getWidth(), dialogCenterY + dialogHeight / 2 - this.bottomBorderImage.getHeight(), 3);
      this.gameCanvas.drawImage(var1, this.bottomRightCornerImage, dialogCenterX - dialogWidth / 2 + this.leftBorderImage.getWidth(), dialogCenterY + dialogHeight / 2 - this.bottomBorderImage.getHeight(), 3);
      this.gameCanvas.setGraphicsColor(var1, this.frameColor);
      int var10 = 0;
      int var5 = 0;
      int var6 = 0;
      if (this.isCentered) {
         for (int var7 = this.scrollOffset; var7 < this.wrappedLineCount && var6 < visibleLineLimit; var7++) {
            var6++;
         }

         var5 = dialogCenterY - var6 * (this.lineHeight + this.lineSpacing) / 2;
      }

      try {
         for (int var11 = this.scrollOffset; var11 < this.wrappedLineCount && var10 < visibleLineLimit; var11++) {
            if (this.isCentered) {
               this.fontRenderer.drawText(var1, this.wrappedTextLines[var11], textLeft, var5 + (this.lineHeight + this.lineSpacing) * var10, textAreaWidth, 1, this.fontIndex);
            } else {
               this.fontRenderer.drawText(var1, this.wrappedTextLines[var11], textLeft, textTop + (this.lineHeight + this.lineSpacing) * var10, textAreaWidth, 4, this.fontIndex);
            }

            var10++;
         }
      } catch (System.Exception var8) {
      }

      if (this.animationTick % 10 != 0) {
         if (this.scrollOffset > 0) {
            GameCanvas.drawTriangle(var1, textLeft + textAreaWidth, textTop + 1, 0, verticalBorderInset, 16777215);
         }

         if (this.wrappedLineCount > visibleLineLimit && this.scrollOffset < this.wrappedLineCount - visibleLineLimit) {
            GameCanvas.drawTriangle(var1, textLeft + textAreaWidth, textTop + textAreaHeight - verticalBorderInset - 1, 1, verticalBorderInset, 16777215);
         }
      }

      this.gameCanvas.setGraphicsClip(var1, 0, 0, 360, 384);
   }

   // $VF: renamed from: b (int) void
   public override void handleOverlayInput(int var1) {
      if (var1 == -1 || var1 == 50) {
         this.scrollOffset = (sbyte)(this.scrollOffset - (visibleLineLimit - 1));
         if (this.scrollOffset < 0) {
            this.scrollOffset = 0;
         }
      }

      if ((var1 == -2 || var1 == 56) && this.scrollOffset < this.wrappedLineCount - visibleLineLimit) {
         this.scrollOffset = (sbyte)(this.scrollOffset + (visibleLineLimit - 1));
      }
   }

   // $VF: renamed from: a () int
   public int getVisibleMessageLineCount() {
      return visibleLineLimit;
   }

   // alias for obfuscated name 'a'
   public void a(string var1, int var2, int var3, int var4, int var5, int var6, int var7, bool var8) { configureMessageOverlay(var1, var2, var3, var4, var5, var6, var7, var8); }

   // alias for obfuscated name 'e'
   public void e() { updateOverlayAnimation(); }

   // alias for obfuscated name 'f'
   public void f() { loadOverlayResources(); }

   // alias for obfuscated name 'a'
   public void a(Graphics var1) { drawOverlay(var1); }

   // alias for obfuscated name 'b'
   public void b(int var1) { handleOverlayInput(var1); }

   // alias for obfuscated name 'a'
   public int a() { return getVisibleMessageLineCount(); }

   // alias for obfuscated name 'c'
   public void c(int var1) { setOverlayFont(var1); }
}
}
