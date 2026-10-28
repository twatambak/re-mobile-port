// Transpiled from Java (class_10.java) by Tools/J2meToCs. Regenerate rather than hand-edit where possible.
#pragma warning disable CS0162, CS0164, CS0168, CS0169, CS0219, CS0414, CS0649, CS1717, CS0108, CS0659, CS0661
using J2ME;

namespace REUprising.Gameloft
{
// $VF: renamed from: w
public class HudRenderer {
   static HudRenderer() { }

   // $VF: renamed from: a f
   public static GameCanvas gameCanvas;

   public HudRenderer(GameCanvas var1) {
      gameCanvas = var1;
   }

   // $VF: renamed from: a (int, int) void
   public static void updateHudMeter(int var0, int var1) {
      gameCanvas.setActorAttribute(222, 38, var1);
      if (var1 > 46) {
         gameCanvas.deactivateActorRuntimeState(222);
      } else {
         gameCanvas.activateActorRuntimeState(222);
      }

      gameCanvas.setActorAttribute(190, 38, var1 + 1);
      if (var1 + 1 > 46) {
         gameCanvas.deactivateActorRuntimeState(190);
      } else {
         gameCanvas.activateActorRuntimeState(190);
      }

      gameCanvas.setActorAttribute(191, 38, var1 + 2);
      if (var1 + 2 > 46) {
         gameCanvas.deactivateActorRuntimeState(191);
      } else {
         gameCanvas.activateActorRuntimeState(191);
      }

      gameCanvas.setActorAttribute(192, 38, var1 + 3);
      if (var1 + 3 > 46) {
         gameCanvas.deactivateActorRuntimeState(192);
      } else {
         gameCanvas.activateActorRuntimeState(192);
      }

      gameCanvas.setActorAttribute(193, 38, var1 + 4);
      if (var1 + 4 > 46) {
         gameCanvas.deactivateActorRuntimeState(193);
      } else {
         gameCanvas.activateActorRuntimeState(193);
      }

      gameCanvas.setActorAttribute(194, 38, var1 + 5);
      if (var1 + 5 > 46) {
         gameCanvas.deactivateActorRuntimeState(194);
      } else {
         gameCanvas.activateActorRuntimeState(194);
      }

      gameCanvas.setActorAttribute(195, 38, var1 + 6);
      if (var1 + 6 > 46) {
         gameCanvas.deactivateActorRuntimeState(195);
      } else {
         gameCanvas.activateActorRuntimeState(195);
      }

      gameCanvas.setActorAttribute(196, 38, var1 + 7);
      if (var1 + 7 > 46) {
         gameCanvas.deactivateActorRuntimeState(196);
      } else {
         gameCanvas.activateActorRuntimeState(196);
      }

      gameCanvas.setActorAttribute(197, 38, var1 + 8);
      if (var1 + 8 > 46) {
         gameCanvas.deactivateActorRuntimeState(197);
      } else {
         gameCanvas.activateActorRuntimeState(197);
      }

      gameCanvas.setActorAttribute(198, 38, var1 + 9);
      if (var1 + 9 > 46) {
         gameCanvas.deactivateActorRuntimeState(198);
      } else {
         gameCanvas.activateActorRuntimeState(198);
      }

      gameCanvas.setActorAttribute(199, 38, var1 + 10);
      if (var1 + 10 > 46) {
         gameCanvas.deactivateActorRuntimeState(199);
      } else {
         gameCanvas.activateActorRuntimeState(199);
      }

      gameCanvas.setActorAttribute(200, 38, var1 + 11);
      if (var1 + 11 > 46) {
         gameCanvas.deactivateActorRuntimeState(200);
      } else {
         gameCanvas.activateActorRuntimeState(200);
      }

      gameCanvas.setActorAttribute(201, 38, var1 + 12);
      if (var1 + 12 > 46) {
         gameCanvas.deactivateActorRuntimeState(201);
      } else {
         gameCanvas.activateActorRuntimeState(201);
      }

      gameCanvas.setActorAttribute(202, 38, var1 + 13);
      if (var1 + 13 > 46) {
         gameCanvas.deactivateActorRuntimeState(202);
      } else {
         gameCanvas.activateActorRuntimeState(202);
      }

      gameCanvas.setActorAttribute(203, 38, var1 + 14);
      if (var1 + 14 > 46) {
         gameCanvas.deactivateActorRuntimeState(203);
      } else {
         gameCanvas.activateActorRuntimeState(203);
      }

      gameCanvas.setActorAttribute(204, 38, var1 + 15);
      if (var1 + 15 > 46) {
         gameCanvas.deactivateActorRuntimeState(204);
      } else {
         gameCanvas.activateActorRuntimeState(204);
      }

      gameCanvas.setActorAttribute(223, 35, var1 - 2);
      if (var1 - 2 > 44) {
         gameCanvas.deactivateActorRuntimeState(223);
      } else {
         gameCanvas.activateActorRuntimeState(223);
      }

      gameCanvas.setActorAttribute(205, 35, var1 + 1 - 2);
      if (var1 + 1 - 2 > 44) {
         gameCanvas.deactivateActorRuntimeState(205);
      } else {
         gameCanvas.activateActorRuntimeState(205);
      }

      gameCanvas.setActorAttribute(206, 35, var1 + 2 - 2);
      if (var1 + 2 - 2 > 44) {
         gameCanvas.deactivateActorRuntimeState(206);
      } else {
         gameCanvas.activateActorRuntimeState(206);
      }

      gameCanvas.setActorAttribute(207, 35, var1 + 3 - 2);
      if (var1 + 3 - 2 > 44) {
         gameCanvas.deactivateActorRuntimeState(207);
      } else {
         gameCanvas.activateActorRuntimeState(207);
      }

      gameCanvas.setActorAttribute(208, 35, var1 + 4 - 2);
      if (var1 + 4 - 2 > 44) {
         gameCanvas.deactivateActorRuntimeState(208);
      } else {
         gameCanvas.activateActorRuntimeState(208);
      }

      gameCanvas.setActorAttribute(209, 35, var1 + 5 - 2);
      if (var1 + 5 - 2 > 44) {
         gameCanvas.deactivateActorRuntimeState(209);
      } else {
         gameCanvas.activateActorRuntimeState(209);
      }

      gameCanvas.setActorAttribute(210, 35, var1 + 6 - 2);
      if (var1 + 6 - 2 > 44) {
         gameCanvas.deactivateActorRuntimeState(210);
      } else {
         gameCanvas.activateActorRuntimeState(210);
      }

      gameCanvas.setActorAttribute(211, 35, var1 + 7 - 2);
      if (var1 + 7 - 2 > 44) {
         gameCanvas.deactivateActorRuntimeState(211);
      } else {
         gameCanvas.activateActorRuntimeState(211);
      }

      gameCanvas.setActorAttribute(212, 35, var1 + 8 - 2);
      if (var1 + 8 - 2 > 44) {
         gameCanvas.deactivateActorRuntimeState(212);
      } else {
         gameCanvas.activateActorRuntimeState(212);
      }

      gameCanvas.setActorAttribute(213, 35, var1 + 9 - 2);
      if (var1 + 9 - 2 > 44) {
         gameCanvas.deactivateActorRuntimeState(213);
      } else {
         gameCanvas.activateActorRuntimeState(213);
      }

      gameCanvas.setActorAttribute(214, 35, var1 + 10 - 2);
      if (var1 + 10 - 2 > 44) {
         gameCanvas.deactivateActorRuntimeState(214);
      } else {
         gameCanvas.activateActorRuntimeState(214);
      }

      gameCanvas.setActorAttribute(215, 35, var1 + 11 - 2);
      if (var1 + 11 - 2 > 44) {
         gameCanvas.deactivateActorRuntimeState(215);
      } else {
         gameCanvas.activateActorRuntimeState(215);
      }

      gameCanvas.setActorAttribute(216, 35, var1 + 12 - 2);
      if (var1 + 12 - 2 > 44) {
         gameCanvas.deactivateActorRuntimeState(216);
      } else {
         gameCanvas.activateActorRuntimeState(216);
      }

      gameCanvas.setActorAttribute(217, 35, var1 + 13 - 2);
      if (var1 + 13 - 2 > 44) {
         gameCanvas.deactivateActorRuntimeState(217);
      } else {
         gameCanvas.activateActorRuntimeState(217);
      }

      gameCanvas.setActorAttribute(218, 35, var1 + 14 - 2);
      if (var1 + 14 - 2 > 44) {
         gameCanvas.deactivateActorRuntimeState(218);
      } else {
         gameCanvas.activateActorRuntimeState(218);
      }

      gameCanvas.setActorAttribute(219, 35, var1 + 15 - 2);
      if (var1 + 15 - 2 > 44) {
         gameCanvas.deactivateActorRuntimeState(219);
      } else {
         gameCanvas.activateActorRuntimeState(219);
      }

      gameCanvas.setActorAttribute(226, 35, var1 + 16);
      if (var1 + 16 > 46) {
         gameCanvas.deactivateActorRuntimeState(226);
      } else {
         gameCanvas.activateActorRuntimeState(226);
      }
   }

   // $VF: renamed from: a (boolean) void
   public static void renderHud(bool var0) {
      if (GameCanvas.gameByteValue07 != 2) {
         if (!var0) {
            if (GameCanvas.gameByteValue07 != 0 && GameCanvas.gameByteValue07 != 3) {
               GameCanvas.gameByteValue07 = 0;
               GameCanvas.gameShortValue01++;
            } else {
               GameCanvas.gameByteValue07 = 1;
            }
         } else {
            GameCanvas.gameByteValue07 = 2;
            GameCanvas.gameShortValue01 = 0;
            if (GameCanvas.gameBooleanFlag62) {
               if (gameCanvas.gameByteValue04 != 3 || GameCanvas.gameIntegerValue124 != 5) {
                  gameCanvas.transitionGameState(2);
                  return;
               }
            } else if (gameCanvas.gameByteValue04 != 3 || !GameCanvas.isAudioEnabled()) {
               gameCanvas.transitionGameState(2);
            }
         }
      }
   }

   // $VF: renamed from: a () int
   public int getElapsedGameTime() {
      long var1 = gameCanvas.gameLongValue06 - gameCanvas.gameLongValue08;
      switch (GameCanvas.gameShortValue01) {
         case 530:
            switch (GameCanvas.gameByteValue07) {
               case 0:
                  gameCanvas.showGameMessage(0, 2, GameCanvas.getLocalizedText(108), 0);
                  gameCanvas.gameBooleanFlag48 = false;
                  renderHud(false);
                  break;
               case 1:
                  if (GameCanvas.gameIntegerValue50 != 131) {
                     renderHud(true);
                  } break;
            }

            return 1;
         case 640:
            switch (GameCanvas.gameByteValue07) {
               case 0:
                  gameCanvas.gameActorGroupReference01.byteValue05 = 2;
                  gameCanvas.gameActorGroupReference01.actorStateReference01.booleanFlag01 = false;
                  gameCanvas.gameActorGroupReference02.byteValue05 = 2;
                  gameCanvas.gameActorGroupReference02.actorStateReference01.booleanFlag01 = false;
                  gameCanvas.gameIntegerValue66 = 0;
                  gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                  renderHud(false);
                  break;
               case 1:
                  switch (gameCanvas.gameIntegerValue66) {
                     case 0:
                        if (var1 > 50L) {
                           gameCanvas.processActorAction(35);
                           updateHudMeter(35, 39);
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        }
                        break;
                     case 1:
                        if (var1 > 50L) {
                           updateHudMeter(35, 38);
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        }
                        break;
                     case 2:
                        if (var1 > 50L) {
                           updateHudMeter(35, 37);
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        }
                        break;
                     case 3:
                        if (var1 > 100L) {
                           updateHudMeter(35, 36);
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        }
                        break;
                     case 4:
                        if (var1 > 200L) {
                           updateHudMeter(35, 35);
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        }
                        break;
                     case 5:
                        if (var1 > 300L) {
                           updateHudMeter(35, 34);
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        }
                        break;
                     case 6:
                        if (var1 > 450L) {
                           updateHudMeter(35, 33);
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        }
                        break;
                     case 7:
                        if (var1 > 600L) {
                           updateHudMeter(35, 32);
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        }
                        break;
                     case 8:
                        if (var1 > 750L) {
                           updateHudMeter(35, 31);
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        }
                        break;
                     case 9:
                        if (var1 > 900L) {
                           updateHudMeter(35, 30);
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        }
                        break;
                     case 10:
                        if (var1 > 1050L) {
                           updateHudMeter(35, 29);
                           gameCanvas.gameIntegerValue83 = 750;
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        }
                        break;
                     case 11:
                        if (var1 > 2000L) {
                           gameCanvas.processActorAction(19);
                           gameCanvas.activateActorRuntimeState(220);
                           gameCanvas.activateActorRuntimeState(221);
                           gameCanvas.deactivateActorRuntimeState(192);
                           gameCanvas.deactivateActorRuntimeState(191);
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        }
                        break;
                     case 12:
                        if (var1 > 250L) {
                           gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue01 = 38;
                           gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue02 = 31;
                           gameCanvas.gameActorGroupReference01.actorStateReference01.booleanFlag01 = true;
                           gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue07 = 1;
                           gameCanvas.gameActorGroupReference02.actorStateReference01.byteValue01 = 38;
                           gameCanvas.gameActorGroupReference02.actorStateReference01.byteValue02 = 32;
                           gameCanvas.gameActorGroupReference02.actorStateReference01.booleanFlag01 = true;
                           gameCanvas.gameActorGroupReference02.actorStateReference01.byteValue07 = 1;
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        }
                        break;
                     case 13:
                        if (var1 > 250L) {
                           gameCanvas.processActorAction(19);
                           gameCanvas.activateActorRuntimeState(192);
                           gameCanvas.activateActorRuntimeState(191);
                           gameCanvas.deactivateActorRuntimeState(220);
                           gameCanvas.deactivateActorRuntimeState(221);
                           renderHud(true);
                           gameCanvas.hasSavedGameData();
                           GameCanvas.gameBooleanFlag59 = true;
                        } break;
                  } break;
            }

            return 1;
         case 650:
            switch (GameCanvas.gameByteValue07) {
               case 0:
                  gameCanvas.setActorAnimationState(GameCanvas.getLocalizedText(88), (short)0, (sbyte)5);
                  renderHud(false);
                  break;
               case 1:
                  if (GameCanvas.gameIntegerValue50 != 137) {
                     if (gameCanvas.gameStringBufferReference01.charAt(0) == 'G'
                        && gameCanvas.gameStringBufferReference01.charAt(1) == 'U'
                        && gameCanvas.gameStringBufferReference01.charAt(2) == 'E'
                        && gameCanvas.gameStringBufferReference01.charAt(3) == 'S'
                        && gameCanvas.gameStringBufferReference01.charAt(4) == 'T') {
                        gameCanvas.deactivateActorRuntimeState(225);
                        gameCanvas.processActorAction(12);
                     } else {
                        gameCanvas.showGameMessage(0, 2, GameCanvas.getLocalizedText(89), 0);
                     }

                     renderHud(true);
                  } break;
            }

            return 1;
         case 670:
            switch (GameCanvas.gameByteValue07) {
               case 0:
                  sbyte var3 = gameCanvas.gameByteMatrix02[18][17];
                  if (gameCanvas.gameByteMatrix02[gameCanvas.gameActorGroupReference02.actorStateReference01.byteValue01][gameCanvas.gameActorGroupReference02.actorStateReference01.byteValue02] == var3
                     && gameCanvas.gameActorGroupReference02.actorStateReference01.booleanFlag01) {
                     for (int var5 = 0; var5 < gameCanvas.gameClass20ReferenceArray01[var3].byteValue01; var5++) {
                        gameCanvas.gameClass19ReferenceArray01[gameCanvas.gameClass20ReferenceArray01[var3].tileCoordinateReferenceArray01[var5].byteValue02].booleanFlag02 = false;
                     }

                     renderHud(true);
                     return 1;
                  } else {
                     if (gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue01 == 22 && gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue02 == 24) {
                        gameCanvas.gameIntegerValue66 = 0;
                        gameCanvas.gameActorStateReference02 = gameCanvas.createActorState(7, 18, 16, 3);
                        gameCanvas.moveActorToTile(gameCanvas.gameActorGroupReference01.actorStateReference01, 23, 17);
                        renderHud(false);
                        return 1;
                     }

                     for (int var4 = 0; var4 < gameCanvas.gameClass20ReferenceArray01[var3].byteValue01; var4++) {
                        gameCanvas.gameClass19ReferenceArray01[gameCanvas.gameClass20ReferenceArray01[var3].tileCoordinateReferenceArray01[var4].byteValue02].booleanFlag02 = false;
                     }

                     renderHud(true);
                     return 1;
                  } goto case 1;
               case 1:
                  switch (gameCanvas.gameIntegerValue66) {
                     case 0:
                        if (!GameCanvas.isActorDefeated(gameCanvas.gameActorGroupReference01.actorStateReference01)
                           && gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue01 == 23
                           && gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue02 == 17) {
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.moveActorToTile(gameCanvas.gameActorGroupReference01.actorStateReference01, 20, 16);
                        }
                        break;
                     case 1:
                        if (gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue01 < 22) {
                           GameCanvas.setActorFacingDirection(gameCanvas.gameActorStateReference02, 1);
                        }

                        if (!GameCanvas.isActorDefeated(gameCanvas.gameActorGroupReference01.actorStateReference01)
                           && gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue01 == 20
                           && gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue02 == 16) {
                           GameCanvas.setActorFacingDirection(gameCanvas.gameActorGroupReference01.actorStateReference01, 5);
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                           gameCanvas.transitionGameState(1);
                        }
                        break;
                     case 2:
                        if (var1 > 500L) {
                           gameCanvas.showGameMessage(0, 2, GameCanvas.getLocalizedText(239), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 3:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.updateActorDisplayState(gameCanvas.gameActorStateReference02, true);
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 4:
                        if (var1 > 500L) {
                           gameCanvas.showGameMessage(0, 4, GameCanvas.getLocalizedText(240), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 5:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.faceActorTowardPosition(gameCanvas.gameActorStateReference02, 8);
                           GameCanvas.setActorFacingDirection(gameCanvas.gameActorStateReference02, 1);
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 6:
                        if (var1 > 1000L) {
                           gameCanvas.showGameMessage(0, 2, GameCanvas.getLocalizedText(241), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 7:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.showGameMessage(0, 4, GameCanvas.getLocalizedText(242), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 8:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.showGameMessage(0, 4, GameCanvas.getLocalizedText(243), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 9:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 10:
                        if (var1 > 1000L) {
                           gameCanvas.showGameMessage(0, 2, GameCanvas.getLocalizedText(244), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 11:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.showGameMessage(0, 2, GameCanvas.getLocalizedText(245), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 12:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.showGameMessage(0, 2, GameCanvas.getLocalizedText(246), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 13:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.faceActorTowardPosition(gameCanvas.gameActorStateReference02, 0);
                           GameCanvas.setActorFacingDirection(gameCanvas.gameActorStateReference02, 1);
                           gameCanvas.showGameMessage(0, 4, GameCanvas.getLocalizedText(247), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 14:
                        gameCanvas.gameIntegerValue66++;
                        gameCanvas.gameActorStateReference03 = gameCanvas.createActorState(5, 18, 24, 3);
                        gameCanvas.gameActorStateReference03.booleanFlag05 = true;
                        gameCanvas.updateActorDisplayState(gameCanvas.gameActorStateReference03, true);
                        gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        gameCanvas.faceActorTowardPosition(gameCanvas.gameActorGroupReference01.actorStateReference01, 11);
                        GameCanvas.setActorFacingDirection(gameCanvas.gameActorGroupReference01.actorStateReference01, 7);
                        gameCanvas.transitionGameState(5);
                        gameCanvas.processActorAction(36);
                        break;
                     case 15:
                        if (var1 > 1000L) {
                           GameCanvas.setActorFacingDirection(gameCanvas.gameActorStateReference02, 7);
                           gameCanvas.updateActorDisplayState(gameCanvas.gameActorStateReference02, true);
                           gameCanvas.moveActorToTile(gameCanvas.gameActorStateReference03, 18, 18);
                           gameCanvas.showGameMessage(0, 4, GameCanvas.getLocalizedText(248), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 16:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.moveActorToTile(gameCanvas.gameActorStateReference02, 18, 17);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 17:
                        if (gameCanvas.gameActorStateReference02.byteValue01 == 18
                           && gameCanvas.gameActorStateReference02.byteValue02 == 17
                           && gameCanvas.gameActorStateReference03.byteValue01 == 18
                           && gameCanvas.gameActorStateReference03.byteValue02 == 18) {
                           gameCanvas.faceActorTowardPosition(gameCanvas.gameActorStateReference03, 5);
                           GameCanvas.setActorFacingDirection(gameCanvas.gameActorGroupReference01.actorStateReference01, 5);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 18:
                        if (gameCanvas.gameActorStateReference03.byteValue03 > 4) {
                           gameCanvas.faceActorTowardPosition(gameCanvas.gameActorStateReference02, 3);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 19:
                        if (gameCanvas.gameActorStateReference02.byteValue05 == 3 && (gameCanvas.gameActorStateReference02.byteValue03 == 1 || gameCanvas.gameActorStateReference02.byteValue03 == 2)) {
                           gameCanvas.deactivateActorRuntimeState(134);
                           gameCanvas.activateActorRuntimeState(180);
                        }

                        if (gameCanvas.gameActorStateReference02.byteValue05 == 4) {
                           GameCanvas.gameIntegerValue50 = 384;
                           GameCanvas.setActorFacingDirection(gameCanvas.gameActorGroupReference01.actorStateReference01, 7);
                           gameCanvas.moveActorToTile(gameCanvas.gameActorStateReference03, 22, 25);
                           gameCanvas.gameActorGroupReference02.actorStateReference01.booleanFlag01 = false;
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 20:
                        if (gameCanvas.gameActorStateReference03.byteValue01 == 22 && gameCanvas.gameActorStateReference03.byteValue02 == 25) {
                           gameCanvas.transitionGameState(2);
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.gameActorStateReference03.booleanFlag01 = false;
                           gameCanvas.gameActorGroupReference02.actorStateReference01.booleanFlag01 = true;
                           gameCanvas.moveActorToTile(gameCanvas.gameActorGroupReference01.actorStateReference01, 19, 16);
                        }
                        break;
                     case 21:
                        if (!GameCanvas.isActorDefeated(gameCanvas.gameActorGroupReference01.actorStateReference01)
                           && gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue01 == 19
                           && gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue02 == 16) {
                           GameCanvas.setActorFacingDirection(gameCanvas.gameActorGroupReference01.actorStateReference01, 5);
                           gameCanvas.showGameMessage(0, 4, GameCanvas.getLocalizedText(249), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 22:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.showGameMessage(0, 2, GameCanvas.getLocalizedText(250), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 23:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 24:
                        if (var1 > 1500L) {
                           gameCanvas.showGameMessage(0, 4, GameCanvas.getLocalizedText(251), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 25:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.setActiveActorGroup(52);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 26:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.setActiveActorGroup(40);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 27:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 28:
                        if (var1 > 1000L) {
                           gameCanvas.showGameMessage(0, 4, GameCanvas.getLocalizedText(252), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 29:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 30:
                        if (var1 > 1000L) {
                           gameCanvas.showGameMessage(0, 4, GameCanvas.getLocalizedText(253), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 31:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.showGameMessage(0, 2, GameCanvas.getLocalizedText(254), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 32:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.updateActorDisplayState(gameCanvas.gameActorGroupReference01.actorStateReference01, true);
                           renderHud(true);
                        } break;
                  } goto default;
               default:
                  return 1;
            } goto case 680;
         case 680:
         case 690:
            switch (GameCanvas.gameByteValue07) {
               case 0:
                  if (GameCanvas.gameShortValue01 == 680) {
                     gameCanvas.gameByteValue24 = (sbyte)(gameCanvas.gameByteValue24 | 1);
                     gameCanvas.setActiveActorGroupDirection((sbyte)39);
                     gameCanvas.showGameMessage(0, 2, GameCanvas.getLocalizedText(104), 0);
                  } else if (GameCanvas.gameShortValue01 == 690) {
                     gameCanvas.gameByteValue24 = (sbyte)(gameCanvas.gameByteValue24 | 2);
                     gameCanvas.setActiveActorGroupDirection((sbyte)40);
                     gameCanvas.showGameMessage(0, 2, GameCanvas.getLocalizedText(105), 0);
                  }

                  if ((~gameCanvas.gameByteValue24 & 3) == 0) {
                     gameCanvas.gameIntegerValue66 = 0;
                     gameCanvas.gameIntegerValue83 = 500;
                     gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                     renderHud(false);
                  } else {
                     renderHud(true);
                  }
                  break;
               case 1:
                  switch (gameCanvas.gameIntegerValue66) {
                     case 0:
                        if (var1 >= 750L) {
                           gameCanvas.showGameMessage(0, 2, GameCanvas.getLocalizedText(103), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 1:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.setActiveActorGroup(38);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 2:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           renderHud(true);
                        } break;
                  } break;
            }

            return 1;
         case 700:
            switch (GameCanvas.gameByteValue07) {
               case 0:
                  gameCanvas.setActiveActorGroupDirection((sbyte)41);
                  gameCanvas.gameIntegerValue83 = 500;
                  gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                  gameCanvas.gameIntegerValue66 = 0;
                  renderHud(false);
                  break;
               case 1:
                  switch (gameCanvas.gameIntegerValue66) {
                     case 0:
                        if (var1 >= 750L) {
                           gameCanvas.showGameMessage(0, 2, GameCanvas.getLocalizedText(102), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 1:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.setActiveActorGroup(39);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 2:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           renderHud(true);
                        } break;
                  } break;
            }

            return 1;
         case 710:
            switch (GameCanvas.gameByteValue07) {
               case 0:
                  if (gameCanvas.gameBooleanFlag48) {
                     gameCanvas.gameIntegerValue66 = 0;
                     gameCanvas.showGameMessage(0, 2, GameCanvas.getLocalizedText(78), 0);
                  } else if (!gameCanvas.gameBooleanFlag47) {
                     gameCanvas.gameIntegerValue66 = 0;
                     gameCanvas.showGameMessage(0, 2, GameCanvas.getLocalizedText(99), 0);
                  } else if (gameCanvas.getActorStateValue(gameCanvas.gameActorGroupReference01.actorStateReference01) == gameCanvas.getActorStateValue(gameCanvas.gameActorGroupReference02.actorStateReference01)) {
                     gameCanvas.setActorState(gameCanvas.gameByteValue03 == 1 ? 2 : 1);
                     gameCanvas.gameActorGroupReference01.booleanFlag04 = true;
                     gameCanvas.gameIntegerValue66 = 3;
                  } else {
                     gameCanvas.gameIntegerValue66 = 1;
                     gameCanvas.showGameMessage(0, 2, GameCanvas.getLocalizedText(100), 0);
                  }

                  renderHud(false);
                  break;
               case 1:
                  switch (gameCanvas.gameIntegerValue66) {
                     case 0:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           renderHud(true);
                        }
                        break;
                     case 1:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 2:
                        gameCanvas.gameActorGroupReference02.actorStateReference01.booleanFlag01 = true;
                        gameCanvas.gameActorGroupReference02.actorStateReference01.byteValue01 = 39;
                        gameCanvas.gameActorGroupReference02.actorStateReference01.byteValue02 = 22;
                        gameCanvas.setActorState(gameCanvas.gameByteValue03 == 1 ? 2 : 1);
                        gameCanvas.gameActorGroupReference01.booleanFlag04 = true;
                        gameCanvas.gameIntegerValue66++;
                        break;
                     case 3:
                        if (gameCanvas.gameActorGroupReference02.actorStateReference01.byteValue02 == 32) {
                           gameCanvas.moveActorToTile(gameCanvas.gameActorGroupReference01.actorStateReference01, 38, 31);
                        } else {
                           gameCanvas.moveActorToTile(gameCanvas.gameActorGroupReference01.actorStateReference01, 38, 32);
                        }

                        gameCanvas.gameIntegerValue66++;
                        break;
                     case 4:
                        if (gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue12 == -1 && gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue13 == -1) {
                           GameCanvas.setActorFacingDirection(gameCanvas.gameActorGroupReference01.actorStateReference01, 5);
                           gameCanvas.gameActorGroupReference01.booleanFlag04 = false;
                           gameCanvas.showGameMessage(0, gameCanvas.gameByteValue03 == 1 ? 1 : 0, GameCanvas.getLocalizedText(101), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 5:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.processActorAction(19);
                           gameCanvas.deactivateActorRuntimeState(192);
                           gameCanvas.deactivateActorRuntimeState(191);
                           gameCanvas.activateActorRuntimeState(220);
                           gameCanvas.activateActorRuntimeState(221);
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 6:
                        if (var1 > 500L) {
                           gameCanvas.gameActorGroupReference02.actorStateReference01.byteValue01--;
                           gameCanvas.gameActorGroupReference02.actorStateReference01.booleanFlag01 = false;
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        }
                        break;
                     case 7:
                        if (var1 > 500L) {
                           gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue01--;
                           gameCanvas.gameActorGroupReference01.actorStateReference01.booleanFlag01 = false;
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        }
                        break;
                     case 8:
                        if (var1 > 500L) {
                           gameCanvas.processActorAction(19);
                           gameCanvas.activateActorRuntimeState(192);
                           gameCanvas.activateActorRuntimeState(191);
                           gameCanvas.deactivateActorRuntimeState(220);
                           gameCanvas.deactivateActorRuntimeState(221);
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        }
                        break;
                     case 9:
                        if (var1 > 100L) {
                           gameCanvas.gameIntegerValue83 = 1000;
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        }
                        break;
                     case 10:
                        if (var1 > 800L) {
                           gameCanvas.processActorAction(35);
                           updateHudMeter(35, 29);
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        }
                        break;
                     case 11:
                        if (var1 > 700L) {
                           updateHudMeter(35, 30);
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        }
                        break;
                     case 12:
                        if (var1 > 550L) {
                           updateHudMeter(35, 31);
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        }
                        break;
                     case 13:
                        if (var1 > 400L) {
                           updateHudMeter(35, 32);
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        }
                        break;
                     case 14:
                        if (var1 > 250L) {
                           updateHudMeter(35, 33);
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        }
                        break;
                     case 15:
                        if (var1 > 100L) {
                           updateHudMeter(35, 34);
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        }
                        break;
                     case 16:
                        if (var1 > 50L) {
                           updateHudMeter(35, 35);
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        } goto case 17;
                     case 17:
                        if (var1 > 50L) {
                           updateHudMeter(35, 36);
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        } goto case 18;
                     case 18:
                        if (var1 > 50L) {
                           updateHudMeter(35, 37);
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        } goto case 19;
                     case 19:
                        if (var1 > 50L) {
                           updateHudMeter(35, 38);
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        } goto case 20;
                     case 20:
                        if (var1 > 50L) {
                           updateHudMeter(35, 39);
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        }
                        break;
                     case 21:
                        if (var1 > 50L) {
                           renderHud(true);
                           gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue01 = 5;
                           gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue02 = 8;
                           gameCanvas.gameActorGroupReference02.actorStateReference01.byteValue01 = 5;
                           gameCanvas.gameActorGroupReference02.actorStateReference01.byteValue02 = 9;
                           gameCanvas.processLevelEntity(3, true);
                           GameCanvas.gameBooleanFlag59 = false;
                           gameCanvas.gameActorGroupReference01.actorStateReference01.booleanFlag01 = true;
                           gameCanvas.gameActorGroupReference02.actorStateReference01.booleanFlag01 = true;
                           gameCanvas.gameActorGroupReference02.byteValue05 = 3;
                        } break;
                  } break;
            }

            return 1;
         case 720:
            switch (GameCanvas.gameByteValue07) {
               case 0:
                  gameCanvas.gameIntegerValue66 = 0;
                  gameCanvas.moveActorToTile(gameCanvas.gameActorGroupReference04.actorStateReference01, 3, 8);
                  renderHud(false);
                  break;
               case 1:
                  switch (gameCanvas.gameIntegerValue66) {
                     case 0:
                        if (gameCanvas.gameActorGroupReference04.actorStateReference01.byteValue12 == -1 && gameCanvas.gameActorGroupReference04.actorStateReference01.byteValue13 == -1) {
                           gameCanvas.gameActorGroupReference04.actorStateReference01.byteValue07 = 7;
                           gameCanvas.gameActorStateReference01 = gameCanvas.createActorState(3, 3, 8, 7);
                           gameCanvas.moveActorToTile(gameCanvas.gameActorGroupReference04.actorStateReference01, 3, 7);
                           gameCanvas.faceActorTowardPosition(gameCanvas.gameActorStateReference01, 4);
                           gameCanvas.moveActorToTile(gameCanvas.gameActorGroupReference03.actorStateReference01, 4, 8);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 1:
                        if (gameCanvas.gameActorGroupReference04.actorStateReference01.byteValue12 == -1 && gameCanvas.gameActorGroupReference04.actorStateReference01.byteValue13 == -1) {
                           gameCanvas.gameActorGroupReference04.actorStateReference01.byteValue07 = 7;
                           gameCanvas.showGameMessage(0, 1, GameCanvas.getLocalizedText(109), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 2:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 3:
                        if (gameCanvas.gameActorGroupReference03.actorStateReference01.byteValue12 == -1 && gameCanvas.gameActorGroupReference03.actorStateReference01.byteValue13 == -1) {
                           gameCanvas.gameActorGroupReference03.actorStateReference01.byteValue07 = 5;
                           gameCanvas.showGameMessage(0, 0, gameCanvas.gameActorGroupReference03.entitySnapshotReferenceArray01[38].booleanFlag01 ? GameCanvas.getLocalizedText(110) : GameCanvas.getLocalizedText(111), 0);
                           gameCanvas.gameActorGroupReference03.entitySnapshotReferenceArray01[38].booleanFlag01 = true;
                           gameCanvas.gameActorGroupReference04.entitySnapshotReferenceArray01[38].booleanFlag01 = false;
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 4:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 5:
                        if (var1 > 1000L) {
                           gameCanvas.showGameMessage(0, 1, GameCanvas.getLocalizedText(112), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 6:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.showGameMessage(0, 0, GameCanvas.getLocalizedText(113), 0);
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.gameActorGroupReference03.entitySnapshotReferenceArray01[38].booleanFlag01 = false;
                           gameCanvas.gameActorGroupReference04.entitySnapshotReferenceArray01[38].booleanFlag01 = true;
                        }
                        break;
                     case 7:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.showGameMessage(0, 0, GameCanvas.getLocalizedText(114), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 8:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 9:
                        if (var1 > 3000L) {
                           gameCanvas.faceActorTowardPosition(gameCanvas.gameActorStateReference01, 0);
                           gameCanvas.showGameMessage(0, 3, GameCanvas.getLocalizedText(115), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 10:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.showGameMessage(0, 1, GameCanvas.getLocalizedText(116), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 11:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.showGameMessage(0, 0, GameCanvas.getLocalizedText(117), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 12:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.showGameMessage(0, 1, GameCanvas.getLocalizedText(118), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 13:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.showGameMessage(0, 0, GameCanvas.getLocalizedText(119), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 14:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.showGameMessage(0, 1, GameCanvas.getLocalizedText(120), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 15:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.moveActorToTile(gameCanvas.gameActorGroupReference04.actorStateReference01, 3, 10);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 16:
                        if (gameCanvas.gameActorGroupReference04.actorStateReference01.byteValue12 == -1 && gameCanvas.gameActorGroupReference04.actorStateReference01.byteValue13 == -1) {
                           gameCanvas.moveActorToTile(gameCanvas.gameActorGroupReference04.actorStateReference01, 3, 16);
                           gameCanvas.moveActorToTile(gameCanvas.gameActorGroupReference03.actorStateReference01, 3, 11);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 17:
                        if (gameCanvas.gameActorGroupReference03.actorStateReference01.byteValue12 == -1 && gameCanvas.gameActorGroupReference03.actorStateReference01.byteValue13 == -1) {
                           gameCanvas.moveActorToTile(gameCanvas.gameActorStateReference01, 3, 12);
                           gameCanvas.moveActorToTile(gameCanvas.gameActorGroupReference03.actorStateReference01, 3, 13);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 18:
                        if (gameCanvas.gameActorGroupReference03.actorStateReference01.byteValue12 == -1 && gameCanvas.gameActorGroupReference03.actorStateReference01.byteValue13 == -1) {
                           gameCanvas.faceActorTowardPosition(gameCanvas.gameActorGroupReference03.actorStateReference01, 10);
                           gameCanvas.faceActorTowardPosition(gameCanvas.gameActorGroupReference04.actorStateReference01, 9);
                           gameCanvas.faceActorTowardPosition(gameCanvas.gameActorStateReference01, 8);
                           gameCanvas.gameIntegerValue83 = 500;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 19:
                        if (var1 > 1000L) {
                           gameCanvas.gameActorGroupReference03.actorStateReference01.byteValue09 = 127;
                           gameCanvas.gameActorGroupReference04.actorStateReference01.byteValue09 = 127;
                           gameCanvas.setActorState(0);
                           gameCanvas.faceActorTowardPosition(gameCanvas.gameActorGroupReference03.actorStateReference01, 0);
                           gameCanvas.faceActorTowardPosition(gameCanvas.gameActorGroupReference04.actorStateReference01, 0);
                           gameCanvas.gameActorGroupReference04.booleanFlag04 = true;
                           gameCanvas.faceActorTowardPosition(gameCanvas.gameActorStateReference01, 0);
                           gameCanvas.showGameMessage(0, 1, GameCanvas.getLocalizedText(121), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 20:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.processActorAction(19);
                           gameCanvas.activateActorRuntimeState(6);
                           gameCanvas.moveActorToTile(gameCanvas.gameActorGroupReference04.actorStateReference01, 3, 14);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 21:
                        if (gameCanvas.gameActorGroupReference04.actorStateReference01.byteValue12 == -1 && gameCanvas.gameActorGroupReference04.actorStateReference01.byteValue13 == -1) {
                           gameCanvas.showGameMessage(0, 1, GameCanvas.getLocalizedText(122), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 22:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.transitionGameState(5);
                           gameCanvas.showGameMessage(0, 6, GameCanvas.getLocalizedText(123), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 23:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.setActorState(1);
                           gameCanvas.gameActorGroupReference04.booleanFlag04 = false;
                           gameCanvas.showGameMessage(0, 0, GameCanvas.getLocalizedText(124), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 24:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.showGameMessage(0, 1, GameCanvas.getLocalizedText(125), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 25:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.gameActorGroupReference03.actorStateReference01.byteValue07 = 3;
                           gameCanvas.gameActorStateReference01.byteValue07 = 3;
                           gameCanvas.gameIntegerValue83 = 500;
                           gameCanvas.deactivateActorRuntimeState(7);
                           gameCanvas.activateActorRuntimeState(19);
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 26:
                        if (var1 > 1000L) {
                           gameCanvas.createActorState(5, 3, 3, 7);
                           gameCanvas.moveActorToTile(gameCanvas.gameActorStateReference01, 1, 12);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 27:
                        if (gameCanvas.gameActorStateReference01.byteValue12 == -1 && gameCanvas.gameActorStateReference01.byteValue13 == -1) {
                           gameCanvas.gameActorStateReference01.byteValue07 = 1;
                           gameCanvas.faceActorTowardPosition(gameCanvas.gameActorStateReference01, 8);
                           gameCanvas.updatePlayerActor();
                           renderHud(true);
                           gameCanvas.processActorAction(36);
                           GameCanvas.gameBooleanFlag59 = true;
                        } break;
                  } break;
            }

            return 1;
         case 730:
            switch (GameCanvas.gameByteValue07) {
               case 0:
                  gameCanvas.faceActorTowardPosition(gameCanvas.gameActorStateReference03, 4);
                  gameCanvas.updatePlayerActor();
                  gameCanvas.transitionGameState(2);
                  gameCanvas.faceActorTowardPosition(gameCanvas.gameActorStateReference01, 0);
                  gameCanvas.moveActorToTile(gameCanvas.gameActorGroupReference03.actorStateReference01, 2, 12);
                  gameCanvas.gameIntegerValue66 = 0;
                  renderHud(false);
                  break;
               case 1:
                  switch (gameCanvas.gameIntegerValue66) {
                     case 0:
                        if (gameCanvas.gameActorGroupReference03.actorStateReference01.byteValue12 == -1 && gameCanvas.gameActorGroupReference03.actorStateReference01.byteValue13 == -1) {
                           gameCanvas.gameActorGroupReference03.actorStateReference01.byteValue07 = 5;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 1:
                        if (var1 > 1000L) {
                           gameCanvas.processActorAction(19);
                           gameCanvas.deactivateActorRuntimeState(6);
                           gameCanvas.gameActorGroupReference03.actorStateReference01.byteValue07 = 7;
                           gameCanvas.gameActorGroupReference03.actorStateReference01.byteValue09 = 2;
                           gameCanvas.faceActorTowardPosition(gameCanvas.gameActorGroupReference03.actorStateReference01, 0);
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.gameActorGroupReference03.actorStateReference01.byteValue09 = 127;
                        }
                        break;
                     case 2:
                        if (var1 > 500L) {
                           gameCanvas.gameActorGroupReference04.actorStateReference01.byteValue01 = 3;
                           gameCanvas.gameActorGroupReference04.actorStateReference01.byteValue02 = 14;
                           gameCanvas.moveActorToTile(gameCanvas.gameActorGroupReference04.actorStateReference01, 3, 13);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 3:
                        if (gameCanvas.gameActorGroupReference04.actorStateReference01.byteValue12 == -1 && gameCanvas.gameActorGroupReference04.actorStateReference01.byteValue13 == -1) {
                           gameCanvas.gameActorGroupReference04.actorStateReference01.byteValue07 = 3;
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        }
                        break;
                     case 4:
                        if (var1 > 1000L) {
                           gameCanvas.gameActorGroupReference03.actorStateReference01.byteValue09 = 127;
                           gameCanvas.faceActorTowardPosition(gameCanvas.gameActorGroupReference03.actorStateReference01, 0);
                           gameCanvas.showGameMessage(0, 0, GameCanvas.getLocalizedText(126), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 5:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.gameActorGroupReference03.actorStateReference01.byteValue07 = 5;
                           gameCanvas.showGameMessage(0, 0, GameCanvas.getLocalizedText(127), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 6:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.showGameMessage(0, 3, GameCanvas.getLocalizedText(128), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 7:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 8:
                        if (var1 > 1000L) {
                           gameCanvas.gameIntegerValue83 = 1000;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 9:
                        if (var1 > 1500L) {
                           gameCanvas.gameActorGroupReference03.actorStateReference01.byteValue07 = 7;
                           gameCanvas.showGameMessage(0, 1, GameCanvas.getLocalizedText(129), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 10:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.showGameMessage(0, 1, GameCanvas.getLocalizedText(130), 0);
                           gameCanvas.moveActorToTile(gameCanvas.gameActorGroupReference04.actorStateReference01, 3, 11);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 11:
                        if (GameCanvas.gameIntegerValue50 != 131 && gameCanvas.gameActorGroupReference04.actorStateReference01.byteValue12 == -1 && gameCanvas.gameActorGroupReference04.actorStateReference01.byteValue13 == -1) {
                           gameCanvas.gameActorGroupReference03.actorStateReference01.byteValue07 = 1;
                           gameCanvas.showGameMessage(0, 0, GameCanvas.getLocalizedText(131), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 12:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.gameActorGroupReference03.actorStateReference01.byteValue07 = 1;
                           gameCanvas.showGameMessage(0, 1, GameCanvas.getLocalizedText(132), 0);
                           gameCanvas.moveActorToTile(gameCanvas.gameActorGroupReference04.actorStateReference01, 4, 10);
                           gameCanvas.moveActorToTile(gameCanvas.gameActorGroupReference03.actorStateReference01, 3, 11);
                           gameCanvas.moveActorToTile(gameCanvas.gameActorStateReference01, 3, 10);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 13:
                        if (GameCanvas.gameIntegerValue50 != 131
                           && gameCanvas.gameActorGroupReference04.actorStateReference01.byteValue12 == -1
                           && gameCanvas.gameActorGroupReference03.actorStateReference01.byteValue13 == -1
                           && gameCanvas.gameActorGroupReference03.actorStateReference01.byteValue12 == -1
                           && gameCanvas.gameActorGroupReference04.actorStateReference01.byteValue13 == -1) {
                           if (gameCanvas.gameActorStateReference01.byteValue01 != 4 && gameCanvas.gameActorStateReference01.byteValue02 != 9) {
                              gameCanvas.gameActorStateReference01.byteValue12 = -1;
                              gameCanvas.gameActorStateReference01.byteValue13 = -1;
                              gameCanvas.moveActorToTile(gameCanvas.gameActorStateReference01, 4, 9);
                           }

                           gameCanvas.gameActorGroupReference03.actorStateReference01.byteValue07 = 1;
                           gameCanvas.showGameMessage(0, 0, GameCanvas.getLocalizedText(133), 0);
                           gameCanvas.moveActorToTile(gameCanvas.gameActorGroupReference04.actorStateReference01, 5, 9);
                           gameCanvas.moveActorToTile(gameCanvas.gameActorGroupReference03.actorStateReference01, 5, 8);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 14:
                        if (GameCanvas.gameIntegerValue50 != 131
                           && gameCanvas.gameActorGroupReference04.actorStateReference01.byteValue12 == -1
                           && gameCanvas.gameActorGroupReference03.actorStateReference01.byteValue13 == -1
                           && gameCanvas.gameActorGroupReference03.actorStateReference01.byteValue12 == -1
                           && gameCanvas.gameActorGroupReference04.actorStateReference01.byteValue13 == -1) {
                           gameCanvas.gameActorGroupReference03.actorStateReference01.byteValue07 = 7;
                           gameCanvas.gameActorGroupReference04.actorStateReference01.byteValue07 = 3;
                           gameCanvas.showGameMessage(0, 1, GameCanvas.getLocalizedText(134), 0);
                           gameCanvas.moveActorToTile(gameCanvas.gameActorStateReference01, 4, 9);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 15:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.processActorAction(19);
                           gameCanvas.gameActorGroupReference03.actorStateReference01.byteValue07 = 1;
                           gameCanvas.gameActorGroupReference04.actorStateReference01.byteValue07 = 1;
                           gameCanvas.deactivateActorRuntimeState(10);
                           gameCanvas.deactivateActorRuntimeState(9);
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        }
                        break;
                     case 16:
                        if (var1 > 2000L) {
                           gameCanvas.gameActorGroupReference04.actorStateReference01.booleanFlag01 = false;
                           gameCanvas.moveActorToTile(gameCanvas.gameActorStateReference01, 5, 9);
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        }
                        break;
                     case 17:
                        if (var1 > 1000L) {
                           gameCanvas.gameActorGroupReference03.actorStateReference01.booleanFlag01 = false;
                           if (gameCanvas.gameActorStateReference01.byteValue01 != 5 && gameCanvas.gameActorStateReference01.byteValue02 != 9) {
                              gameCanvas.gameActorStateReference01.byteValue12 = -1;
                              gameCanvas.gameActorStateReference01.byteValue13 = -1;
                              gameCanvas.moveActorToTile(gameCanvas.gameActorStateReference01, 5, 9);
                           }

                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        }
                        break;
                     case 18:
                        if (var1 > 1000L && gameCanvas.gameActorStateReference01.byteValue12 == -1 && gameCanvas.gameActorStateReference01.byteValue13 == -1) {
                           gameCanvas.gameActorStateReference01.booleanFlag01 = false;
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        } else if (var1 > 1000L && gameCanvas.gameActorStateReference01.byteValue01 != 5 && gameCanvas.gameActorStateReference01.byteValue02 != 9) {
                           gameCanvas.gameActorStateReference01.byteValue12 = -1;
                           gameCanvas.gameActorStateReference01.byteValue13 = -1;
                           gameCanvas.moveActorToTile(gameCanvas.gameActorStateReference01, 5, 9);
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        }
                        break;
                     case 19:
                        if (var1 > 2000L) {
                           renderHud(false);
                           GameCanvas.gameBooleanFlag59 = false;
                        } break;
                  } break;
            }

            return 1;
         case 731:
            switch (GameCanvas.gameByteValue07) {
               case 0:
                  gameCanvas.gameIntegerValue90 = 50;
                  gameCanvas.gameIntegerValue66 = 0;
                  gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                  gameCanvas.transitionGameState(6);
                  renderHud(false);
                  return 1;
               case 1:
                  switch (gameCanvas.gameIntegerValue66) {
                     case 2:
                        if (var1 > 2000L) {
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.gameIntegerValue90++;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        }
                        break;
                     case 5:
                        if (GameCanvas.getCurrentInputCode() != 0 || GameCanvas.gameRectangleBoundsReference01 != null && GameCanvas.gameRectangleBoundsReference01.boundsId == 1003 && GameCanvas.gameBooleanFlag22) {
                           GameCanvas.clearInteractionBounds();
                           GameCanvas.clearCollisionBounds();
                           gameCanvas.changeActorAction(10, 0);
                           GameCanvas.gameBooleanFlag51 = true;
                           if (GameCanvas.gameBooleanFlag24) {
                              GameCanvas.gameBooleanFlag50 = true;
                           }

                           if (GameCanvas.isGameInputPressed(3)) {
                              GameCanvas.clearGameInput(3);
                           }
                        }
                        break;
                     default:
                        if (gameCanvas.gameIntegerValue90 == 53 && gameCanvas.isGameModeActive(2821)
                           || GameCanvas.gameRectangleBoundsReference01 != null && GameCanvas.gameBooleanFlag22
                           || gameCanvas.gameIntegerValue90 != 53 && var1 > 2000L) {
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.gameIntegerValue90++;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                           GameCanvas.clearInteractionBounds();
                           GameCanvas.clearCollisionBounds();
                        } break;
                  }

                  return 1;
               default:
                  return 0;
            } goto case 732;
         case 732:
            switch (GameCanvas.gameByteValue07) {
               case 0:
                  gameCanvas.gameIntegerValue66 = 0;
                  renderHud(false);
                  return 1;
               case 1:
                  if (GameCanvas.gameIntegerValue50 != 131) {
                     gameCanvas.updateLevelEvents();
                     gameCanvas.setViewport(1, 297, 24);
                  }

                  return 1;
               default:
                  return 0;
            } goto case 750;
         case 750:
            switch (GameCanvas.gameByteValue07) {
               case 0:
                  if (gameCanvas.gameBooleanFlag46 && !gameCanvas.gameClass9ReferenceArray01[11].booleanFlag02) {
                     renderHud(true);
                  } else {
                     gameCanvas.showGameMessage(0, 1, GameCanvas.getLocalizedText(138), 0);
                     gameCanvas.gameIntegerValue66 = 0;
                     renderHud(false);
                  }
                  break;
               case 1:
                  switch (gameCanvas.gameIntegerValue66) {
                     case 0:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           if (!gameCanvas.gameBooleanFlag46) {
                              gameCanvas.showGameMessage(0, 6, GameCanvas.getLocalizedText(135), 0);
                           } else if (gameCanvas.gameClass9ReferenceArray01[11].booleanFlag02) {
                              gameCanvas.deactivateActorRuntimeState(11);
                              gameCanvas.deactivateActorRuntimeState(8);
                              gameCanvas.deactivateActorRuntimeState(19);
                              gameCanvas.activateActorRuntimeState(20);
                              gameCanvas.activateActorRuntimeState(22);
                              gameCanvas.activateActorRuntimeState(21);
                              gameCanvas.showGameMessage(0, 0, GameCanvas.getLocalizedText(137), 0);
                           }

                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 1:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           renderHud(true);
                        } break;
                  } break;
            }

            return 1;
         case 760:
            switch (GameCanvas.gameByteValue07) {
               case 0:
                  gameCanvas.gameBooleanFlag46 = true;
                  gameCanvas.showGameMessage(0, 6, GameCanvas.getLocalizedText(136), 0);
                  renderHud(false);
                  break;
               case 1:
                  if (GameCanvas.gameIntegerValue50 != 131) {
                     renderHud(true);
                  } break;
            }

            return 1;
         case 770:
            switch (GameCanvas.gameByteValue07) {
               case 0:
                  switch (gameCanvas.gameActorGroupReference03.byteValue04) {
                     case 1:
                        gameCanvas.gameActorGroupReference01.byteArray01[gameCanvas.gameActorGroupReference03.byteValue04] = (sbyte)(gameCanvas.gameActorGroupReference01.byteArray01[gameCanvas.gameActorGroupReference03.byteValue04] + 10);
                        break;
                     case 2:
                        gameCanvas.gameActorGroupReference01.byteArray01[gameCanvas.gameActorGroupReference03.byteValue04] = (sbyte)(gameCanvas.gameActorGroupReference01.byteArray01[gameCanvas.gameActorGroupReference03.byteValue04] + 10);
                        break;
                     case 3:
                        gameCanvas.gameActorGroupReference01.byteArray01[gameCanvas.gameActorGroupReference03.byteValue04] = (sbyte)(gameCanvas.gameActorGroupReference01.byteArray01[gameCanvas.gameActorGroupReference03.byteValue04] + 10);
                        break;
                     case 4:
                        gameCanvas.gameActorGroupReference01.byteArray01[gameCanvas.gameActorGroupReference03.byteValue04] = (sbyte)(gameCanvas.gameActorGroupReference01.byteArray01[gameCanvas.gameActorGroupReference03.byteValue04] + 5);
                        break;
                     default:
                        renderHud(false);
                        return 1;
                  }

                  if (gameCanvas.gameActorGroupReference01.byteArray01[gameCanvas.gameActorGroupReference03.byteValue04] > 100) {
                     gameCanvas.gameActorGroupReference01.byteArray01[gameCanvas.gameActorGroupReference03.byteValue04] = 100;
                  }

                  renderHud(false);
                  gameCanvas.showGameMessage(2, GameCanvas.gameIntegerArray02[gameCanvas.gameActorGroupReference03.byteValue04], GameCanvas.getLocalizedText(31), 0);
                  break;
               case 1:
                  if (GameCanvas.gameIntegerValue50 != 131) {
                     gameCanvas.deactivateActorRuntimeState(24);
                     gameCanvas.activateActorRuntimeState(0);
                     renderHud(true);
                     GameCanvas.gameBooleanFlag61 = false;
                  } break;
            }

            return 1;
         case 780:
            switch (GameCanvas.gameByteValue07) {
               case 0:
                  gameCanvas.showGameMessage(0, 0, GameCanvas.getLocalizedText(139), 0);
                  renderHud(false);
                  break;
               case 1:
                  if (GameCanvas.gameIntegerValue50 != 131) {
                     renderHud(true);
                  } break;
            }

            return 1;
         case 840:
            switch (GameCanvas.gameByteValue07) {
               case 0:
                  if (gameCanvas.gameByteValue03 == 1) {
                     gameCanvas.moveActorToTile(gameCanvas.gameActorGroupReference01.actorStateReference01, 36, 19);
                  } else {
                     gameCanvas.moveActorToTile(gameCanvas.gameActorGroupReference01.actorStateReference01, 36, 16);
                  }

                  gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                  gameCanvas.gameIntegerValue66 = 0;
                  renderHud(false);
                  break;
               case 1:
                  switch (gameCanvas.gameIntegerValue66) {
                     case 0:
                        if (var1 > 1000L) {
                           gameCanvas.gameActorGroupReference02.actorStateReference01.byteValue01 = 39;
                           gameCanvas.gameActorGroupReference02.actorStateReference01.byteValue02 = 21;
                           if (gameCanvas.gameByteValue03 == 1) {
                              gameCanvas.moveActorToTile(gameCanvas.gameActorGroupReference02.actorStateReference01, 36, 16);
                           } else {
                              gameCanvas.moveActorToTile(gameCanvas.gameActorGroupReference02.actorStateReference01, 36, 19);
                           }

                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 1:
                        if (gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue12 == -1 && gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue13 == -1) {
                           if (gameCanvas.gameByteValue03 == 1) {
                              GameCanvas.setActorFacingDirection(gameCanvas.gameActorGroupReference01.actorStateReference01, 3);
                           } else {
                              GameCanvas.setActorFacingDirection(gameCanvas.gameActorGroupReference01.actorStateReference01, 7);
                           }
                        }

                        if (gameCanvas.gameActorGroupReference02.actorStateReference01.byteValue12 == -1 && gameCanvas.gameActorGroupReference02.actorStateReference01.byteValue13 == -1) {
                           if (gameCanvas.gameByteValue03 == 1) {
                              GameCanvas.setActorFacingDirection(gameCanvas.gameActorGroupReference02.actorStateReference01, 7);
                           } else {
                              GameCanvas.setActorFacingDirection(gameCanvas.gameActorGroupReference02.actorStateReference01, 3);
                           }
                        }

                        if (gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue12 == -1
                           && gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue13 == -1
                           && gameCanvas.gameActorGroupReference02.actorStateReference01.byteValue12 == -1
                           && gameCanvas.gameActorGroupReference02.actorStateReference01.byteValue13 == -1) {
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.showGameMessage(0, 1, GameCanvas.getLocalizedText(93), 0);
                        }
                        break;
                     case 2:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.gameActorStateReference01 = gameCanvas.createActorState(3, 36, 17, 1);
                           gameCanvas.faceActorTowardPosition(gameCanvas.gameActorStateReference01, 4);
                           gameCanvas.gameActorStateReference01.booleanFlag01 = false;
                           gameCanvas.faceActorTowardPosition(gameCanvas.gameActorGroupReference04.actorStateReference01, 11);
                           gameCanvas.gameIntegerValue90 = 35;
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 3:
                     case 4:
                     case 5:
                     case 6:
                        if (var1 > 200L) {
                           gameCanvas.gameIntegerValue90++;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                           gameCanvas.gameIntegerValue66++;
                           if (gameCanvas.gameIntegerValue90 >= 39) {
                              gameCanvas.gameActorStateReference01.booleanFlag01 = true;
                              gameCanvas.gameActorStateReference01.byteValue01 = 36;
                              gameCanvas.gameActorStateReference01.byteValue02 = 17;
                              gameCanvas.gameIntegerValue90 = 0;
                           }
                        }
                        break;
                     case 7:
                        if (var1 > 1000L) {
                           gameCanvas.updatePlayerActor();
                           gameCanvas.faceActorTowardPosition(gameCanvas.gameActorGroupReference04.actorStateReference01, 0);
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.showGameMessage(0, 0, GameCanvas.getLocalizedText(94), 0);
                        }
                        break;
                     case 8:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           renderHud(true);
                        } break;
                  } break;
            }

            return 1;
         case 850:
            switch (GameCanvas.gameByteValue07) {
               case 0:
                  if (!gameCanvas.gameActorGroupReference03.entitySnapshotReferenceArray01[38].booleanFlag01 && !gameCanvas.gameActorGroupReference04.entitySnapshotReferenceArray01[38].booleanFlag01) {
                     gameCanvas.showGameMessage(0, 2, GameCanvas.getLocalizedText(93), 0);
                     gameCanvas.gameIntegerValue66 = 0;
                  } else {
                     gameCanvas.showGameMessage(0, 2, GameCanvas.getLocalizedText(95), 0);
                     gameCanvas.gameIntegerValue66 = 1;
                  }

                  renderHud(false);
                  break;
               case 1:
                  switch (gameCanvas.gameIntegerValue66) {
                     case 0:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           renderHud(true);
                        }
                        break;
                     case 1:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           if (gameCanvas.gameByteMatrix02[gameCanvas.gameActorGroupReference02.actorStateReference01.byteValue01][gameCanvas.gameActorGroupReference02.actorStateReference01.byteValue02] == gameCanvas.gameByteMatrix02[36][16]
                              )
                            {
                              gameCanvas.moveActorToTile(gameCanvas.gameActorGroupReference02.actorStateReference01, 38, 17);
                              gameCanvas.gameIntegerValue66++;
                           } else {
                              gameCanvas.moveActorToTile(gameCanvas.gameActorGroupReference01.actorStateReference01, 36, 16);
                              gameCanvas.gameIntegerValue66 = 3;
                           }
                        }
                        break;
                     case 2:
                        if (!GameCanvas.isActorDefeated(gameCanvas.gameActorGroupReference02.actorStateReference01)
                           && gameCanvas.gameActorGroupReference02.actorStateReference01.byteValue01 == 38
                           && gameCanvas.gameActorGroupReference02.actorStateReference01.byteValue02 == 17) {
                           GameCanvas.setActorFacingDirection(gameCanvas.gameActorGroupReference02.actorStateReference01, 5);
                           gameCanvas.moveActorToTile(gameCanvas.gameActorGroupReference01.actorStateReference01, 36, 16);
                           gameCanvas.gameIntegerValue66 = 3;
                        }
                        break;
                     case 3:
                        if (!GameCanvas.isActorDefeated(gameCanvas.gameActorGroupReference01.actorStateReference01)
                           && gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue01 == 36
                           && gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue02 == 16) {
                           GameCanvas.setActorFacingDirection(gameCanvas.gameActorGroupReference01.actorStateReference01, 7);
                           gameCanvas.showGameMessage(0, 2, GameCanvas.getLocalizedText(96), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 4:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.faceActorTowardPosition(gameCanvas.gameActorGroupReference01.actorStateReference01, 8);
                           gameCanvas.gameIntegerValue90 = 39;
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.gameActorStateReference01.booleanFlag01 = false;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        }
                        break;
                     case 5:
                     case 6:
                     case 7:
                     case 8:
                        if (var1 > 200L) {
                           gameCanvas.gameIntegerValue90++;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 9:
                        if (var1 > 250L) {
                           gameCanvas.faceActorTowardPosition(gameCanvas.gameActorGroupReference01.actorStateReference01, 0);
                           gameCanvas.showGameMessage(0, 2, GameCanvas.getLocalizedText(97), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 10:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.deactivateActorRuntimeState(227);
                           gameCanvas.gameBooleanFlag47 = true;
                           renderHud(true);
                        } break;
                  } break;
            }

            return 1;
         case 860:
            switch (GameCanvas.gameByteValue07) {
               case 0:
                  GameCanvas.gameByteValue07 = 3;
                  return 1;
               case 3:
                  if (GameCanvas.gameIntegerValue50 == 384) {
                     renderHud(true);
                  }

                  return 1;
               default:
                  return 0;
            } goto case 870;
         case 870:
             {
               if ((gameCanvas.gameByteValue24 & 1) == 0 || (gameCanvas.gameByteValue24 & 2) == 0) {
                  if ((gameCanvas.gameByteValue24 & 1) != 0) {
                     gameCanvas.showGameMessage(0, 2, GameCanvas.getLocalizedText(104), 0);
                     goto label934_brk;
                  }

                  if ((gameCanvas.gameByteValue24 & 2) != 0) {
                     gameCanvas.showGameMessage(0, 2, GameCanvas.getLocalizedText(105), 0);
                     goto label934_brk;
                  }
               }

               gameCanvas.showGameMessage(0, 2, GameCanvas.getLocalizedText(106), 0);
            } label934_brk:;

            renderHud(true);
            return 1;
         default:
            return 0;
      }
   }
}
}
