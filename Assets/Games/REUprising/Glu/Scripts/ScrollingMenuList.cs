// Transpiled from Java (ScrollingMenuList.java) by Tools/J2meToCs. Regenerate rather than hand-edit where possible.
#pragma warning disable CS0162, CS0164, CS0168, CS0169, CS0219, CS0414, CS0649, CS1717, CS0108, CS0659, CS0661
using J2ME;

namespace REUprising.Glu
{
// $VF: renamed from: y
public class ScrollingMenuList : AbstractMenuList {
   static ScrollingMenuList() { }

   // $VF: renamed from: n int
   public static int scrollAnimationOffset = 0;
   // $VF: renamed from: l byte
   public sbyte scrollAnimationStep = 0;
   // $VF: renamed from: m byte
   public sbyte scrollAnimationPeriod = 0;
   // $VF: renamed from: o byte
   public sbyte scrollAnimationTicks = 0;
   // $VF: renamed from: p o
   public IAudioCommandSink audioCommandSink = null;
   // $VF: renamed from: q boolean
   public static bool isMenuSoundEnabled = false;
   // $VF: renamed from: r int
   public int menuCenterX = 0;
   // $VF: renamed from: s int
   public int menuCenterY = 0;
   // $VF: renamed from: t byte
   public sbyte visibleRowCount = 0;
   // $VF: renamed from: u int
   public int menuWidth = 0;
   // $VF: renamed from: v int
   public int rowHeight = 0;
   // $VF: renamed from: w int
   public int scrollOffset = 0;
   // $VF: renamed from: x int
   public int rowSpacing = 0;
   // $VF: renamed from: y byte
   public sbyte visibleRowHalfCount = 0;
   // $VF: renamed from: z int
   public int firstRowY = 0;
   // $VF: renamed from: A int
   public int menuContentHeight = 0;
   // $VF: renamed from: B java.lang.String[]
   public string[] visibleMenuItems = null;
   // $VF: renamed from: C java.lang.String[]
   public string[] truncatedMenuItems = null;
   // $VF: renamed from: D byte
   public sbyte textAlignment = 0;
   // $VF: renamed from: E javax.microedition.lcdui.Image
   public Image menuBackgroundImage = null;
   // $VF: renamed from: F javax.microedition.lcdui.Image
   public Image menuSelectionImage = null;
   // $VF: renamed from: G int
   public int scrollTargetOffset = 0;
   // $VF: renamed from: H int
   public int scrollCurrentOffset = 0;
   // $VF: renamed from: I byte[]
   public sbyte[] menuItemStates = null;
   // $VF: renamed from: J byte[]
   public sbyte[] visibleRowStates = null;
   // $VF: renamed from: K byte
   public sbyte previousSelectedIndex = -1;
   // $VF: renamed from: L boolean
   public bool isMenuAnimated = false;
   // $VF: renamed from: M boolean
   public bool truncateMenuLabels = false;
   // $VF: renamed from: N int
   public int menuAnimationTicks = 0;
   // $VF: renamed from: O byte
   public sbyte menuState = 0;
   // $VF: renamed from: P int
   public int topVisibleBoundary = 0;
   // $VF: renamed from: Q int
   public int topScrollBoundary = 0;
   // $VF: renamed from: R int
   public int menuTopBoundary = 0;
   // $VF: renamed from: S int
   public int menuBottomBoundary = 0;
   // $VF: renamed from: T int
   public int bottomScrollBoundary = 0;
   // $VF: renamed from: U boolean
   public bool wrapSelection = true;
   // $VF: renamed from: V int
   public int visibleRows = 6;

   public ScrollingMenuList() {
      this.rowHeight = 0;
      this.rowSpacing = 0;
      this.enableMenuSounds();
   }

   public ScrollingMenuList(BitmapFontRenderer var1, int var2, int var3, GameCanvas var4, bool var5) : base(var1, var2, var3, var4) {
      
      this.rowHeight = 0;
      this.rowSpacing = 0;
      this.c();
      this.c(0);
      if (var5) {
         this.enableMenuSounds();
      }
   }

   // $VF: renamed from: a (java.lang.String[], int, int, int, int, int, int, int, byte, boolean, boolean) void
   public override void configureMenuItems(string[] var1, int var2, int var3, int var4, int var5, int var6, int var7, int var8, sbyte var9, bool var10, bool var11) {
      this.resetScrollingMenu();
      if (var1.Length <= var4) {
         var4 = var1.Length;
      }

      this.menuItemCount = (sbyte)var1.Length;
      this.menuItems = var1;
      if (var11) {
         int var12 = GameController.canvasWidth;
         if (var9 == 1) {
            var12 = var5;
         }

         this.truncatedMenuItems = new string[this.menuItems.Length];

         for (int var13 = 0; var13 < this.truncatedMenuItems.Length; var13++) {
            for (int var14 = 0; var14 < this.menuItems[var13].length(); var14++) {
               if (this.fontRenderer.measureTextWidth(this.menuItems[var13].substring(0, var14 + 1), var8) >= var12) {
                  this.truncatedMenuItems[var13] = this.menuItems[var13].substring(0, var14 - 3) + "...";
                  break;
               }

               this.truncatedMenuItems[var13] = this.menuItems[var13].substring(0, var14 + 1);
            }
         }
      }

      this.menuCenterX = var2;
      this.menuCenterY = var3;
      this.visibleRowCount = (sbyte)var4;
      this.menuWidth = var5;
      if (var9 == 0) {
         this.rowHeight = this.fontRenderer.getFontBaselineOffset(var8) + 2;
      } else if (var9 == 1) {
         this.rowHeight = var6;
      } else if (var9 == 2) {
         this.rowHeight = this.fontRenderer.getFontBaselineOffset(var8) + 2;
      }

      this.rowSpacing = var7;
      this.rowHeight = (sbyte)(this.rowHeight + this.rowSpacing);
      this.rowSpacing = this.rowHeight;
      this.visibleRowHalfCount = (sbyte)((this.visibleRowCount + 2) / 2);
      this.firstRowY = this.menuCenterY - this.visibleRowCount * (this.rowHeight + this.rowSpacing) / 2;
      this.menuContentHeight = this.visibleRowCount * (this.rowHeight + this.rowSpacing);
      this.visibleMenuItems = new string[this.visibleRowCount + 2];

      for (int var15 = 0; var15 < this.visibleMenuItems.Length; var15++) {
         this.visibleMenuItems[var15] = "";
      }

      this.c(var8);
      this.fontIndex = var8;
      this.textAlignment = var9;
      this.isMenuAnimated = var10;
      this.truncateMenuLabels = var11;
      this.menuItemStates = new sbyte[this.menuItems.Length];
      this.visibleRowStates = new sbyte[this.menuItems.Length + 2];
      this.loadOverlayResources();
      switch (this.textAlignment) {
         case 2:
            this.topVisibleBoundary = this.menuCenterY - ((this.visibleRowCount - 1) * (this.rowHeight + this.rowSpacing) + this.scrollOffset + this.rowSpacing) / 2;
            this.topScrollBoundary = this.menuCenterY - ((this.visibleRowCount + 1) * (this.rowHeight + this.rowSpacing) + this.scrollOffset + this.rowSpacing) / 2;
            this.menuTopBoundary = this.menuCenterY - ((this.visibleRowCount - 1) * (this.rowHeight + this.rowSpacing) + this.scrollOffset + this.rowSpacing) / 2;
            this.menuBottomBoundary = this.menuCenterY + ((this.visibleRowCount - 1) * (this.rowHeight + this.rowSpacing) + this.scrollOffset + this.rowSpacing) / 2;
            this.bottomScrollBoundary = this.menuCenterY - ((this.visibleRowCount + 1) * (this.rowHeight + this.rowSpacing) + this.scrollOffset) / 2;
            break;
         default:
            this.topVisibleBoundary = this.menuCenterY - this.visibleRowCount * (this.rowHeight + this.rowSpacing) / 2;
            this.topScrollBoundary = this.menuCenterY - (this.visibleRowCount + 2) * (this.rowHeight + this.rowSpacing) / 2;
            this.menuTopBoundary = this.menuCenterY - this.visibleRowCount * (this.rowHeight + this.rowSpacing) / 2;
            this.menuBottomBoundary = this.menuCenterY + this.visibleRowCount * (this.rowHeight + this.rowSpacing) / 2;
            this.bottomScrollBoundary = this.menuCenterY - (this.visibleRowCount + 2) * (this.rowHeight + this.rowSpacing) / 2; break;
      }

      this.refreshVisibleMenuItems();
   }

   // $VF: renamed from: g () void
   public void resetScrollingMenu() {
      this.selectedItemIndex = 0;
      this.menuItemCount = 0;
      this.animationTick = 0;
      this.menuAnimationTicks = 0;
      this.scrollAnimationTicks = 0;
      this.menuItems = null;
      this.isMenuVisible = false;
      scrollAnimationOffset = 0;
      this.scrollCurrentOffset = 0;
      this.c((sbyte)32);
      this.c((sbyte)8);
      this.c((sbyte)16);
      this.c();
      this.truncateMenuLabels = false;
      this.wrapSelection = true;
      this.menuState = 0;
      JSystem.gc();
   }

   // $VF: renamed from: e () void
   public override void updateOverlayAnimation() {
      this.animationTick++;
      this.menuAnimationTicks++;
      if (this.d((sbyte)32)) {
         if (this.d((sbyte)8)) {
            scrollAnimationOffset += 5;
            if (this.textAlignment == 2) {
               this.scrollCurrentOffset = this.scrollCurrentOffset + this.scrollTargetOffset;
            }

            if (scrollAnimationOffset >= this.rowSpacing) {
               this.scrollAnimationTicks--;
               if (this.scrollAnimationTicks < 0) {
                  this.scrollAnimationTicks = 0;
               }

               if (this.scrollAnimationTicks == 0) {
                  this.c((sbyte)32);
                  this.c((sbyte)8);
               }

               scrollAnimationOffset = 0;
               this.scrollCurrentOffset = 0;
               this.rowSpacing = this.rowHeight;
               this.selectedItemIndex--;
               if (this.selectedItemIndex < 0) {
                  this.selectedItemIndex = (sbyte)(this.menuItemCount - 1);
               }

               if (this.menuItemStates[this.selectedItemIndex] == 1) {
                  this.handleOverlayInput(-1);
               }

               this.refreshVisibleMenuItems();
            }
         }

         if (this.d((sbyte)16)) {
            scrollAnimationOffset -= 5;
            if (this.textAlignment == 2) {
               this.scrollCurrentOffset = this.scrollCurrentOffset - this.scrollTargetOffset;
            }

            if (scrollAnimationOffset <= -this.rowSpacing) {
               this.scrollAnimationTicks--;
               if (this.scrollAnimationTicks < 0) {
                  this.scrollAnimationTicks = 0;
               }

               if (this.scrollAnimationTicks == 0) {
                  this.c((sbyte)32);
                  this.c((sbyte)16);
               }

               scrollAnimationOffset = 0;
               this.scrollCurrentOffset = 0;
               this.rowSpacing = this.rowHeight;
               this.selectedItemIndex++;
               if (this.selectedItemIndex >= this.menuItemCount) {
                  this.selectedItemIndex = 0;
               }

               if (this.menuItemStates[this.selectedItemIndex] == 1) {
                  this.handleOverlayInput(-2);
               }

               this.refreshVisibleMenuItems();
            }
         }
      }
   }

   // $VF: renamed from: h () void
   public void refreshVisibleMenuItems() {
      int var1 = 0;

      for (int var2 = this.visibleRowHalfCount; var2 < this.visibleMenuItems.Length; var2++) {
         string[] var3 = this.truncateMenuLabels && this.visibleRowHalfCount == var2 ? this.menuItems : (this.truncateMenuLabels ? this.truncatedMenuItems : this.menuItems);
         this.visibleMenuItems[var2] = var3[(this.selectedItemIndex + var1) % var3.Length];
         if (this.menuItemStates[(this.selectedItemIndex + var1) % var3.Length] == 1) {
            this.visibleRowStates[var2] = 1;
         } else {
            this.visibleRowStates[var2] = 0;
         }

         var1++;
      }

      int var5 = 0;

      for (int var6 = this.visibleRowHalfCount - 1; var6 >= 0; var6--) {
         string[] var7 = this.truncateMenuLabels ? this.truncatedMenuItems : this.menuItems;
         int var4 = this.selectedItemIndex - 1 - var5;
         if (var4 < 0) {
            var4 += var7.Length;
         }

         this.visibleMenuItems[var6] = var7[var4];
         if (this.menuItemStates[var4] == 1) {
            this.visibleRowStates[var6] = 1;
         } else {
            this.visibleRowStates[var6] = 0;
         }

         var5++;
      }
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics) void
   public override void drawOverlay(Graphics var1) {
      if (this.wrapSelection) {
         this.refreshVisibleMenuItems();
         this.wrapSelection = false;
      }

      this.gameCanvas.setGraphicsColor(var1, 16777215);
      this.gameCanvas.setGraphicsClip(var1, 0, this.firstRowY, this.menuCenterX, this.menuContentHeight);

      for (int var2 = 0; var2 < this.visibleRowCount + 2; var2++) {
         if (this.textAlignment == 1) {
            this.gameCanvas
               .fillCanvasRectangle(
                  var1,
                  this.menuCenterX - this.menuWidth / 2,
                  this.bottomScrollBoundary + var2 * (this.rowHeight + this.rowSpacing) + scrollAnimationOffset,
                  this.menuWidth,
                  this.rowHeight
               );
         } else {
            if (this.textAlignment != 2) {
               break;
            }

            if (this.menuItemCount <= this.visibleRowCount) {
               if (var2 == this.selectedItemIndex + 1) {
                  this.drawScrollingMenuBackground(var1, this.menuCenterX, this.bottomScrollBoundary + var2 * (this.rowHeight + this.rowSpacing) + scrollAnimationOffset, this.menuCenterX);
               }
            } else if (var2 == this.visibleRowHalfCount && !this.d((sbyte)32)) {
               this.drawScrollingMenuBackground(var1, this.menuCenterX, this.bottomScrollBoundary + var2 * (this.rowHeight + this.rowSpacing) + scrollAnimationOffset, this.menuCenterX);
            }
         }
      }

      this.gameCanvas.setGraphicsColor(var1, 4348185);
      if (this.menuItemCount <= this.visibleRowCount) {
         this.drawScrollingMenuText(var1);
      } else {
         this.drawScrollingMenuItems(var1);
      }

      this.gameCanvas.setGraphicsClip(var1, 0, 0, this.menuCenterX, this.menuCenterY);
      if (this.menuItemCount > this.visibleRowCount) {
         this.drawScrollingMenuIndicators(var1);
      }
   }

   // $VF: renamed from: b (javax.microedition.lcdui.Graphics) void
   public void drawScrollingMenuText(Graphics var1) {
      try {
         bool var2 = true;
         int var3 = 0;
         bool var4 = false;
         bool var5 = false;

         for (int var6 = 0; var6 < this.visibleRowCount; var6++) {
            bool var7 = false;
            string var8 = this.menuItems[var6];
            bool var12 = true;
            int var9 = this.rowHeight;
            int var14 = 4348185;
            int var13 = 7537664;
            if (var6 == this.selectedItemIndex) {
               if (this.animationTick % 10 == 0) {
                  var12 = false;
               }

               var14 = 16777215;
               var13 = 7537664;
               var3 = 0;
               if (this.textAlignment == 2) {
                  var9 = this.scrollOffset;
               }

               var7 = true;
            } else if (var6 > this.selectedItemIndex && this.textAlignment == 2) {
               var3 = this.scrollOffset - this.rowHeight;
            }

            if (this.menuItemStates[var6] == 1) {
               var14 = 9868950;
               var13 = 9868950;
            }

            if (var12) {
               if (this.truncateMenuLabels && var7) {
                  int var10 = var9 / 2 - this.fontRenderer.getFontBaselineOffset(this.fontIndex) / 2;
                  this.gameCanvas.setGraphicsColor(var1, var13);
                  this.fontRenderer
                     .drawClippedOrScrollingText(
                        var1,
                        var8,
                        this.menuCenterX - (this.textAlignment == 2 ? this.menuCenterX / 2 : this.menuWidth / 2) + 1,
                        this.topVisibleBoundary + var6 * (this.rowHeight + this.rowSpacing) + var3 + 1 + var10,
                        this.textAlignment == 2 ? this.menuCenterX : this.menuWidth,
                        1,
                        this.fontIndex,
                        this.menuAnimationTicks * 2,
                        this.textAlignment == 2 ? this.menuCenterX / 4 : this.menuWidth / 4,
                        10
                     );
                  this.gameCanvas.setGraphicsColor(var1, var14);
                  this.fontRenderer
                     .drawClippedOrScrollingText(
                        var1,
                        var8,
                        this.menuCenterX - (this.textAlignment == 2 ? this.menuCenterX / 2 : this.menuWidth / 2),
                        this.topVisibleBoundary + var6 * (this.rowHeight + this.rowSpacing) + var3 + var10,
                        this.textAlignment == 2 ? this.menuCenterX : this.menuWidth,
                        1,
                        this.fontIndex,
                        this.menuAnimationTicks * 2,
                        this.textAlignment == 2 ? this.menuCenterX / 4 : this.menuWidth / 4,
                        10
                     );
                  this.gameCanvas.setGraphicsClip(var1, 0, this.firstRowY, this.menuCenterX, this.menuContentHeight);
               } else {
                  if (this.truncateMenuLabels) {
                     var8 = this.truncatedMenuItems[var6];
                  }

                  this.gameCanvas.setGraphicsColor(var1, var13);
                  this.fontRenderer
                     .drawVerticallyCenteredText(
                        var1,
                        var8,
                        this.menuCenterX - this.menuWidth / 2 + 1,
                        this.topVisibleBoundary + var6 * (this.rowHeight + this.rowSpacing) + var3 + 1,
                        this.menuWidth + 1,
                        var9,
                        1,
                        this.fontIndex
                     );
                  this.gameCanvas.setGraphicsColor(var1, var14);
                  this.fontRenderer
                     .drawVerticallyCenteredText(
                        var1,
                        var8,
                        this.menuCenterX - this.menuWidth / 2,
                        this.topVisibleBoundary + var6 * (this.rowHeight + this.rowSpacing) + var3,
                        this.menuWidth,
                        var9,
                        1,
                        this.fontIndex
                     );
               }
            }
         }
      } catch (System.Exception var11) {
      }
   }

   // $VF: renamed from: c (javax.microedition.lcdui.Graphics) void
   public void drawScrollingMenuItems(Graphics var1) {
      sbyte var2 = 0;

      try {
         bool var3 = true;
         int var4 = 0;
         bool var5 = false;
         bool var6 = false;
         bool var7 = false;

         for (int var8 = 0; var8 < this.visibleMenuItems.Length; var8++) {
            bool var9 = false;
            int var17 = this.scrollCurrentOffset;
            bool var14 = true;
            int var15 = 4348185;
            int var16 = 7537664;
            int var10 = this.rowHeight;
            sbyte var11 = 0;
            if (var8 == this.visibleRowHalfCount) {
               if (this.animationTick % 10 == 0 && !this.d((sbyte)32)) {
                  var14 = false;
               }

               if (!this.d((sbyte)32)) {
                  var15 = 16777215;
                  var16 = 7537664;
               } else {
                  var15 = 4348185;
                  var16 = 7537664;
               }

               if (this.textAlignment == 2) {
                  var10 = this.scrollOffset;
               }

               var9 = true;
            } else if (var8 > this.visibleRowHalfCount && this.textAlignment == 2) {
               var4 = this.scrollOffset - this.rowHeight;
            }

            if (this.d((sbyte)8)) {
               if (var8 > this.visibleRowHalfCount || var8 < this.visibleRowHalfCount - 1) {
                  var17 = 0;
               }
            } else if (this.d((sbyte)16) && (var8 < this.visibleRowHalfCount || var8 > this.visibleRowHalfCount + 1)) {
               var17 = 0;
            }

            if (this.visibleRowStates[var8] == 1) {
               var15 = 9868950;
               var16 = 9868950;
            }

            if (var14) {
               if (this.truncateMenuLabels && var9) {
                  int var12 = var10 / 2 - this.fontRenderer.getFontBaselineOffset(this.fontIndex) / 2;
                  this.gameCanvas.setGraphicsColor(var1, var16);
                  this.fontRenderer
                     .drawClippedOrScrollingText(
                        var1,
                        this.visibleMenuItems[var8],
                        this.menuCenterX - (this.textAlignment == 2 ? this.menuCenterX / 2 : this.menuWidth / 2) + 1,
                        this.topScrollBoundary + (var8 - var11) * (this.rowHeight + this.rowSpacing) + scrollAnimationOffset + var17 + var4 + 1 + var12,
                        this.textAlignment == 2 ? this.menuCenterX : this.menuWidth,
                        1,
                        this.fontIndex,
                        this.menuAnimationTicks * 2,
                        this.textAlignment == 2 ? this.menuCenterX / 4 : this.menuWidth / 4,
                        10
                     );
                  this.gameCanvas.setGraphicsColor(var1, var15);
                  this.fontRenderer
                     .drawClippedOrScrollingText(
                        var1,
                        this.visibleMenuItems[var8],
                        this.menuCenterX - (this.textAlignment == 2 ? this.menuCenterX / 2 : this.menuWidth / 2),
                        this.topScrollBoundary + (var8 - var11) * (this.rowHeight + this.rowSpacing) + scrollAnimationOffset + var17 + var4 + var12,
                        this.textAlignment == 2 ? this.menuCenterX : this.menuWidth,
                        1,
                        this.fontIndex,
                        this.menuAnimationTicks * 2,
                        this.textAlignment == 2 ? this.menuCenterX / 4 : this.menuWidth / 4,
                        10
                     );
                  this.gameCanvas.setGraphicsClip(var1, 0, this.firstRowY, this.menuCenterX, this.menuContentHeight);
               } else {
                  this.gameCanvas.setGraphicsColor(var1, var16);
                  this.fontRenderer
                     .drawVerticallyCenteredText(
                        var1,
                        this.visibleMenuItems[var8],
                        this.menuCenterX - this.menuWidth / 2 + 1,
                        this.topScrollBoundary + (var8 - var11) * (this.rowHeight + this.rowSpacing) + scrollAnimationOffset + var17 + var4 + 1,
                        this.menuWidth,
                        var10,
                        1,
                        this.fontIndex
                     );
                  this.gameCanvas.setGraphicsColor(var1, var15);
                  this.fontRenderer
                     .drawVerticallyCenteredText(
                        var1,
                        this.visibleMenuItems[var8],
                        this.menuCenterX - this.menuWidth / 2,
                        this.topScrollBoundary + (var8 - var11) * (this.rowHeight + this.rowSpacing) + scrollAnimationOffset + var17 + var4,
                        this.menuWidth,
                        var10,
                        1,
                        this.fontIndex
                     );
               }
            }
         }
      } catch (System.Exception var13) {
         GameDiagnostics.logMessage("Text ID: " + var2 + var13.toString());
      }
   }

   // $VF: renamed from: d (javax.microedition.lcdui.Graphics) void
   public void drawScrollingMenuIndicators(Graphics var1) {
      bool var2 = false;
      if (this.d((sbyte)8)) {
         GameCanvas.drawTriangle(var1, this.menuCenterX - 3, this.menuTopBoundary - this.visibleRows, 0, this.visibleRows, 16777215);
      } else {
         GameCanvas.drawTriangle(var1, this.menuCenterX - 3, this.menuTopBoundary - this.visibleRows, 0, this.visibleRows, 11184810);
      }

      if (this.d((sbyte)16)) {
         GameCanvas.drawTriangle(var1, this.menuCenterX - 3, this.menuBottomBoundary, 1, this.visibleRows, 16777215);
      } else {
         GameCanvas.drawTriangle(var1, this.menuCenterX - 3, this.menuBottomBoundary, 1, this.visibleRows, 11184810);
      }
   }

   // $VF: renamed from: f () void
   public override void loadOverlayResources() {
      if (this.textAlignment == 2) {
         if (this.menuBackgroundImage == null || this.previousSelectedIndex != 0) {
            this.menuBackgroundImage = GameCanvas.loadImageResource("/img/line_horizontal_6x6_bold.png");
         }

         if (this.menuSelectionImage == null || this.previousSelectedIndex != 0) {
            this.menuSelectionImage = GameCanvas.loadImageResource("/img/line_vertical_6x6_normal.png");
         }

         if (this.menuSelectionImage != null) {
            this.scrollOffset = this.menuBackgroundImage.getWidth();
            if (this.scrollOffset < this.rowHeight) {
               this.scrollOffset = this.rowHeight;
            }

            this.firstRowY = this.menuCenterY - ((this.visibleRowCount - 1) * (this.rowHeight + this.rowSpacing) + this.scrollOffset + this.rowSpacing) / 2;
            this.menuContentHeight = (this.visibleRowCount - 1) * (this.rowHeight + this.rowSpacing) + this.scrollOffset + this.rowSpacing;
            if (this.scrollOffset > this.rowHeight) {
               this.scrollTargetOffset = (sbyte)((this.scrollOffset - this.rowHeight) / 5 / 2);
            } else {
               this.scrollTargetOffset = 0;
            }

            this.rowSpacing = this.rowHeight;
         }
      }

      this.previousSelectedIndex = 0;
   }

   // $VF: renamed from: d (int) void
   public void handleScrollingMenuUp(int var1) {
      if (var1 == -1 || var1 == 50) {
         this.menuAnimationTicks = 0;
         sbyte var3 = this.selectedItemIndex--;
         if (this.selectedItemIndex < 0) {
            this.selectedItemIndex = (sbyte)(this.menuItemCount - 1);
         }

         while (this.menuItemStates[this.selectedItemIndex] == 1) {
            this.selectedItemIndex--;
            if (this.selectedItemIndex < 0) {
               this.selectedItemIndex = (sbyte)(this.menuItemCount - 1);
            }

            if (this.selectedItemIndex == var3) {
               break;
            }
         }

         this.playMenuSound(8, 4);
         this.refreshVisibleMenuItems();
      } else if (var1 != -2 && var1 != 56) {
         if (var1 == -5 || var1 == -6 && this.isMenuAnimated || var1 == 53) {
            this.playMenuSound(6, 1);
            this.isMenuVisible = true;
         }
      } else {
         this.menuAnimationTicks = 0;
         sbyte var2 = this.selectedItemIndex++;
         if (this.selectedItemIndex >= this.menuItemCount) {
            this.selectedItemIndex = 0;
         }

         while (this.menuItemStates[this.selectedItemIndex] == 1) {
            this.selectedItemIndex++;
            if (this.selectedItemIndex >= this.menuItemCount) {
               this.selectedItemIndex = 0;
            }

            if (this.selectedItemIndex == var2) {
               break;
            }
         }

         this.playMenuSound(8, 4);
         this.refreshVisibleMenuItems();
      }
   }

   // $VF: renamed from: e (int) void
   public void handleScrollingMenuSelection(int var1) {
      if (var1 != -1 && var1 != 50) {
         if (var1 != -2 && var1 != 56) {
            if ((var1 == -5 || var1 == -6 && this.isMenuAnimated || var1 == -6 && this.isMenuAnimated || var1 == 53) && !this.d((sbyte)32)) {
               this.playMenuSound(6, 1);
               this.isMenuVisible = true;
            }
         } else {
            if (!this.d((sbyte)32)) {
               this.menuAnimationTicks = 0;
               this.b((sbyte)32);
               this.b((sbyte)16);
               scrollAnimationOffset = 0;
               this.scrollCurrentOffset = 0;
               this.scrollAnimationTicks++;
            } else {
               if (this.scrollAnimationTicks + 1 < 5) {
                  this.scrollAnimationTicks++;
               }

               if (this.d((sbyte)8)) {
                  this.scrollAnimationTicks = 0;
               }
            }

            this.playMenuSound(8, 4);
            this.refreshVisibleMenuItems();
         }
      } else {
         if (!this.d((sbyte)32)) {
            this.menuAnimationTicks = 0;
            this.b((sbyte)32);
            this.b((sbyte)8);
            scrollAnimationOffset = 0;
            this.scrollCurrentOffset = 0;
            this.scrollAnimationTicks++;
         } else {
            if (this.scrollAnimationTicks + 1 < 5) {
               this.scrollAnimationTicks++;
            }

            if (this.d((sbyte)16)) {
               this.scrollAnimationTicks = 0;
            }
         }

         this.playMenuSound(8, 4);
         this.refreshVisibleMenuItems();
      }
   }

   // $VF: renamed from: b (int) void
   public override void handleOverlayInput(int var1) {
      if (this.menuItemCount <= this.visibleRowCount) {
         this.handleScrollingMenuUp(var1);
      } else {
         this.handleScrollingMenuSelection(var1);
      }
   }

   // $VF: renamed from: i () void
   public void enableMenuSounds() {
      isMenuSoundEnabled = true;
   }

   // $VF: renamed from: a (int, int) void
   public void playMenuSound(int var1, int var2) {
      if (isMenuSoundEnabled && this.audioCommandSink != null && var1 >= 0) {
         if (isMenuSoundEnabled) {
            if ((var2 & 1) != 0) {
               this.audioCommandSink.stopCuePlayback((sbyte)var1);
            }

            if ((var2 & 4) != 0) {
               this.audioCommandSink.requestCuePlayback((sbyte)var1);
            } else {
               this.audioCommandSink.enqueueAudioCommand((sbyte)var1);
            }
         }
      }
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, int, int, int) void
   public void drawScrollingMenuBackground(Graphics var1, int var2, int var3, int var4) {
      this.gameCanvas.setGraphicsColor(var1, 1907997);
      this.gameCanvas.fillCanvasRectangle(var1, var2 - var4 / 2, var3, var4, this.scrollOffset);
      int var5 = this.menuBackgroundImage.getWidth() - this.menuBackgroundImage.getHeight();
      int var6 = var4 / var5 + 1;

      for (int var7 = 0; var7 < var6; var7++) {
         this.gameCanvas.drawImage(var1, this.menuBackgroundImage, var2 - var4 / 2 + var7 * var5, var3, 20);
         this.gameCanvas.drawImage(var1, this.menuBackgroundImage, var2 - var4 / 2 + var7 * var5, var3 + this.scrollOffset - this.menuBackgroundImage.getHeight(), 20);
      }
   }

   // $VF: renamed from: a (java.lang.String, int) void
   public override void setMenuItemText(string var1, int var2) {
      if (var2 >= 0 && var2 < this.menuItemStates.Length) {
         this.menuItems[var2] = var1;
         if (this.truncateMenuLabels) {
            int var3 = GameController.canvasWidth;
            if (this.textAlignment == 1) {
               var3 = this.menuWidth;
            }

            for (int var4 = 0; var4 < this.menuItems[var2].length(); var4++) {
               if (this.fontRenderer.measureTextWidth(this.menuItems[var2].substring(0, var4 + 1), this.fontIndex) >= var3) {
                  this.truncatedMenuItems[var2] = this.menuItems[var2].substring(0, var4 - 3) + "...";
                  break;
               }

               this.truncatedMenuItems[var2] = this.menuItems[var2].substring(0, var4 + 1);
            }
         }

         this.refreshVisibleMenuItems();
      }
   }

   // $VF: renamed from: a (int) void
   public override void setMenuVerticalPosition(int var1) {
      this.menuCenterY = var1;
      this.firstRowY = this.menuCenterY - ((this.visibleRowCount - 1) * (this.rowHeight + this.rowSpacing) + this.scrollOffset + this.rowSpacing) / 2;
      switch (this.textAlignment) {
         case 2:
            this.topVisibleBoundary = this.menuCenterY - ((this.visibleRowCount - 1) * (this.rowHeight + this.rowSpacing) + this.scrollOffset + this.rowSpacing) / 2;
            this.topScrollBoundary = this.menuCenterY - ((this.visibleRowCount + 1) * (this.rowHeight + this.rowSpacing) + this.scrollOffset + this.rowSpacing) / 2;
            this.menuTopBoundary = this.menuCenterY - ((this.visibleRowCount - 1) * (this.rowHeight + this.rowSpacing) + this.scrollOffset + this.rowSpacing) / 2;
            this.menuBottomBoundary = this.menuCenterY + ((this.visibleRowCount - 1) * (this.rowHeight + this.rowSpacing) + this.scrollOffset + this.rowSpacing) / 2;
            this.bottomScrollBoundary = this.menuCenterY - ((this.visibleRowCount + 1) * (this.rowHeight + this.rowSpacing) + this.scrollOffset) / 2;
            break;
         default:
            this.topVisibleBoundary = this.menuCenterY - this.visibleRowCount * (this.rowHeight + this.rowSpacing) / 2;
            this.topScrollBoundary = this.menuCenterY - (this.visibleRowCount + 2) * (this.rowHeight + this.rowSpacing) / 2;
            this.menuTopBoundary = this.menuCenterY - this.visibleRowCount * (this.rowHeight + this.rowSpacing) / 2;
            this.menuBottomBoundary = this.menuCenterY + this.visibleRowCount * (this.rowHeight + this.rowSpacing) / 2;
            this.bottomScrollBoundary = this.menuCenterY - (this.visibleRowCount + 2) * (this.rowHeight + this.rowSpacing) / 2; break;
      }
   }

   // $VF: renamed from: d () int
   public override int getMenuContentHeight() {
      int var1 = 0;
      if (this.menuItemCount <= this.visibleRowCount) {
         var1 = 0;
      } else {
         var1 = this.visibleRows + this.visibleRows;
      }

      return this.textAlignment == 2
         ? (this.visibleRowCount - 1) * (this.rowHeight + this.rowSpacing) + this.scrollOffset + this.rowSpacing + var1
         : this.visibleRowCount * (this.rowHeight + this.rowSpacing) + var1;
   }

   // alias for obfuscated name 'a'
   public void a(string[] var1, int var2, int var3, int var4, int var5, int var6, int var7, int var8, sbyte var9, bool var10, bool var11) { configureMenuItems(var1, var2, var3, var4, var5, var6, var7, var8, var9, var10, var11); }

   // alias for obfuscated name 'g'
   public void g() { resetScrollingMenu(); }

   // alias for obfuscated name 'e'
   public void e() { updateOverlayAnimation(); }

   // alias for obfuscated name 'h'
   public void h() { refreshVisibleMenuItems(); }

   // alias for obfuscated name 'a'
   public void a(Graphics var1) { drawOverlay(var1); }

   // alias for obfuscated name 'b'
   public void b(Graphics var1) { drawScrollingMenuText(var1); }

   // alias for obfuscated name 'c'
   public void c(Graphics var1) { drawScrollingMenuItems(var1); }

   // alias for obfuscated name 'd'
   public void d(Graphics var1) { drawScrollingMenuIndicators(var1); }

   // alias for obfuscated name 'f'
   public void f() { loadOverlayResources(); }

   // alias for obfuscated name 'd'
   public void d(int var1) { handleScrollingMenuUp(var1); }

   // alias for obfuscated name 'e'
   public void e(int var1) { handleScrollingMenuSelection(var1); }

   // alias for obfuscated name 'b'
   public void b(int var1) { handleOverlayInput(var1); }

   // alias for obfuscated name 'i'
   public void i() { enableMenuSounds(); }

   // alias for obfuscated name 'a'
   public void a(int var1, int var2) { playMenuSound(var1, var2); }

   // alias for obfuscated name 'a'
   public void a(Graphics var1, int var2, int var3, int var4) { drawScrollingMenuBackground(var1, var2, var3, var4); }

   // alias for obfuscated name 'a'
   public void a(string var1, int var2) { setMenuItemText(var1, var2); }

   // alias for obfuscated name 'a'
   public void a(int var1) { setMenuVerticalPosition(var1); }

   // alias for obfuscated name 'd'
   public int d() { return getMenuContentHeight(); }

   // alias for obfuscated name 'a'
   public void a(sbyte var1) { setSelectedMenuItem(var1); }

   // alias for obfuscated name 'a'
   public sbyte a() { return getSelectedMenuItem(); }

   // alias for obfuscated name 'b'
   public bool b() { return isMenuCurrentlyVisible(); }

   // alias for obfuscated name 'c'
   public void c() { hideMenu(); }

   // alias for obfuscated name 'b'
   public void b(sbyte var1) { enableMenuStateFlags(var1); }

   // alias for obfuscated name 'c'
   public void c(sbyte var1) { disableMenuStateFlags(var1); }

   // alias for obfuscated name 'd'
   public bool d(sbyte var1) { return hasMenuStateFlag(var1); }

   // alias for obfuscated name 'c'
   public void c(int var1) { setOverlayFont(var1); }
}
}
