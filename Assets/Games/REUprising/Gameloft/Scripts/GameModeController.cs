// Transpiled from Java (class_18.java) by Tools/J2meToCs. Regenerate rather than hand-edit where possible.
#pragma warning disable CS0162, CS0164, CS0168, CS0169, CS0219, CS0414, CS0649, CS1717, CS0108, CS0659, CS0661
using J2ME;

namespace REUprising.Gameloft
{
// $VF: renamed from: l
public class GameModeController {
   static GameModeController() { }

   // $VF: renamed from: a f
   public static GameCanvas gameCanvas;

   public GameModeController(GameCanvas var1) {
      gameCanvas = var1;
   }

   // $VF: renamed from: a () void
   public static void beginGameModeAction() {
      GameCanvas.setActorFacingDirection(gameCanvas.gameActorGroupReference01.actorStateReference01, 3);
      gameCanvas.gameActorGroupReference01.booleanFlag04 = false;
      gameCanvas.gameBooleanFlag37 = true;
      gameCanvas.gameIntegerValue90 = 1;
      gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
   }

   // $VF: renamed from: a () boolean
   public static bool advanceGameModeAction() {
      if (gameCanvas.gameLongValue06 - gameCanvas.gameLongValue08 > 100L) {
         gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
         gameCanvas.gameIntegerValue90++;
         if (gameCanvas.gameIntegerValue90 >= 8) {
            gameCanvas.gameBooleanFlag37 = false;
            gameCanvas.gameIntegerValue90 = 0;
            return true;
         }
      }

      return false;
   }

   // $VF: renamed from: b () void
   public static void beginGameModeFinishAction() {
      GameCanvas.setActorFacingDirection(gameCanvas.gameActorGroupReference01.actorStateReference01, 7);
      gameCanvas.gameActorGroupReference01.booleanFlag04 = false;
      gameCanvas.gameBooleanFlag37 = true;
      gameCanvas.gameIntegerValue90 = 13;
      gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
   }

   // $VF: renamed from: b () boolean
   public static bool advanceGameModeFinishAction() {
      if (gameCanvas.gameLongValue06 - gameCanvas.gameLongValue08 > 100L) {
         gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
         gameCanvas.gameIntegerValue90++;
         if (gameCanvas.gameIntegerValue90 == 14) {
            gameCanvas.gameBooleanFlag37 = false;
            gameCanvas.gameIntegerValue90 = 0;
            return true;
         }

         if (gameCanvas.gameIntegerValue90 >= 20) {
            gameCanvas.gameBooleanFlag37 = false;
            gameCanvas.gameIntegerValue90 = 0;
            return true;
         }
      }

      return false;
   }

   // $VF: renamed from: a (p, int, int) boolean
   public static bool isActorAtPosition(ActorState var0, int var1, int var2) {
      return var0.byteValue01 == var1 && var0.byteValue02 == var2;
   }

   // $VF: renamed from: a (p, int, int) void
   public static void setActorPosition(ActorState var0, int var1, int var2) {
      var0.byteValue01 = (sbyte)var1;
      var0.byteValue02 = (sbyte)var2;
   }

   // $VF: renamed from: a () int
   public int updateGameMode() {
      int var2 = 0;
      int var1 = 0;
      long var4 = gameCanvas.gameLongValue06 - gameCanvas.gameLongValue08;
      switch (GameCanvas.gameShortValue01) {
         case 0:
            switch (GameCanvas.gameByteValue07) {
               case 0:
                  gameCanvas.transitionGameState(1);
                  gameCanvas.gameActorGroupReference01 = gameCanvas.gameActorGroupReference03;
                  gameCanvas.gameActorGroupReference02 = gameCanvas.gameActorGroupReference04;
                  gameCanvas.gameByteValue03 = 1;
                  gameCanvas.updateActorDisplayState(gameCanvas.gameActorGroupReference01.actorStateReference01, true);
                  gameCanvas.showGameMessage(3, 0, GameCanvas.getLocalizedText(47), 0);
                  setActorPosition(gameCanvas.gameActorGroupReference04.actorStateReference01, 1, 0);
                  gameCanvas.gameIntegerValue66 = 0;
                  GameCanvas.setGamePaused(false);
                  GameCanvas.gameBooleanFlag60 = true;
                  return 1;
               case 1:
                  if (GameCanvas.gameIntegerValue50 != 131) {
                     GameCanvas.setGamePaused(true);
                  }

                  return 1;
               default:
                  return 0;
            } goto case 10;
         case 10:
            switch (GameCanvas.gameByteValue07) {
               case 0:
                  gameCanvas.transitionGameState(2);
                  gameCanvas.createActorState(0, 29, 47, 3);
                  gameCanvas.gameActorStateReference05 = gameCanvas.createActorState(2, 25, 37, 3);
                  gameCanvas.faceActorTowardPosition(gameCanvas.gameActorStateReference05, 0);
                  gameCanvas.gameActorStateReference05.booleanFlag05 = true;
                  gameCanvas.moveActorToTile(gameCanvas.gameActorGroupReference03.actorStateReference01, 27, 43);
                  gameCanvas.gameIntegerValue66 = 0;
                  GameCanvas.setGamePaused(false);
                  return 1;
               case 1:
                  switch (gameCanvas.gameIntegerValue66) {
                     case 0:
                        if (!GameCanvas.isActorDefeated(gameCanvas.gameActorGroupReference03.actorStateReference01) && isActorAtPosition(gameCanvas.gameActorGroupReference03.actorStateReference01, 27, 43)) {
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        }
                        break;
                     case 1:
                        if (var4 > 1000L) {
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.showGameMessageWithStyle(0, 0, GameCanvas.getLocalizedText(49), 0);
                        }
                        break;
                     case 2:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           GameCanvas.setActorFacingDirection(gameCanvas.gameActorGroupReference03.actorStateReference01, 1);
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        }
                        break;
                     case 3:
                        if (var4 > 1000L) {
                           gameCanvas.moveActorToTile(gameCanvas.gameActorGroupReference03.actorStateReference01, 25, 40);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 4:
                        if (!GameCanvas.isActorDefeated(gameCanvas.gameActorGroupReference03.actorStateReference01) && isActorAtPosition(gameCanvas.gameActorGroupReference03.actorStateReference01, 25, 40)) {
                           gameCanvas.gameIntegerValue66++;
                           GameCanvas.setActorFacingDirection(gameCanvas.gameActorGroupReference03.actorStateReference01, 3);
                           gameCanvas.showGameMessageWithStyle(0, 0, GameCanvas.getLocalizedText(50), 0);
                        }
                        break;
                     case 5:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        }
                        break;
                     case 6:
                        if (var4 > 500L) {
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                           GameCanvas.setActorFacingDirection(gameCanvas.gameActorStateReference05, 7);
                           gameCanvas.processActorAction(25);
                           gameCanvas.createActorState(1, 30, 47, 3);
                           gameCanvas.gameActorGroupReference04.booleanFlag04 = true;
                           gameCanvas.gameActorGroupReference04.actorStateReference01.byteValue09 = 127;
                           gameCanvas.moveActorToTile(gameCanvas.gameActorGroupReference04.actorStateReference01, 25, 42);
                        }
                        break;
                     case 7:
                        if (var4 > 1000L) {
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.faceActorTowardPosition(gameCanvas.gameActorStateReference05, 1);
                        }
                        break;
                     case 8:
                        if (isActorAtPosition(gameCanvas.gameActorStateReference05, 25, 38)) {
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.showGameMessageWithStyle(0, 0, GameCanvas.getLocalizedText(51), 0);
                        }
                        break;
                     case 9:
                        if (!GameCanvas.isActorDefeated(gameCanvas.gameActorGroupReference04.actorStateReference01) && isActorAtPosition(gameCanvas.gameActorGroupReference04.actorStateReference01, 25, 42)) {
                           GameCanvas.setActorFacingDirection(gameCanvas.gameActorGroupReference04.actorStateReference01, 3);
                           gameCanvas.gameActorGroupReference04.booleanFlag04 = false;
                           gameCanvas.updateActorGroup(1, 2);
                           gameCanvas.gameActorGroupReference04.actorStateReference01.byteValue09 = 6;
                           gameCanvas.faceActorTowardPosition(gameCanvas.gameActorGroupReference04.actorStateReference01, 9);
                           gameCanvas.gameIntegerValue66++;
                           GameCanvas.setActorFacingDirection(gameCanvas.gameActorGroupReference03.actorStateReference01, 7);
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        }
                        break;
                     case 10:
                        if (var4 > 500L) {
                           gameCanvas.updateActorGroup(127, 1);
                           gameCanvas.gameActorGroupReference03.actorStateReference01.byteValue09 = 127;
                           gameCanvas.faceActorTowardPosition(gameCanvas.gameActorGroupReference03.actorStateReference01, 11);
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.showGameMessageWithStyle(0, 0, GameCanvas.getLocalizedText(52), 0);
                        }
                        break;
                     case 11:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.showGameMessageWithStyle(0, 1, GameCanvas.getLocalizedText(53), 0);
                           GameCanvas.stopBackgroundMusic();
                        }
                        break;
                     case 12:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.findEntityFrameData(
                              21 + gameCanvas.gameActorGroupReference04.actorStateReference01.byteValue07,
                              gameCanvas.gameActorGroupReference04.actorStateReference01.byteValue01,
                              gameCanvas.gameActorGroupReference04.actorStateReference01.byteValue02,
                              0,
                              0
                           );
                           gameCanvas.gameIntegerValue83 = 100;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        }
                        break;
                     case 13:
                        if (var4 > 500L) {
                           gameCanvas.faceActorTowardPosition(gameCanvas.gameActorStateReference05, 3);
                           gameCanvas.gameActorStateReference05.byteValue10 = 0;
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        }
                        break;
                     case 14:
                        if (var4 > 1000L) {
                           gameCanvas.faceActorTowardPosition(gameCanvas.gameActorGroupReference04.actorStateReference01, 0);
                           gameCanvas.faceActorTowardPosition(gameCanvas.gameActorGroupReference03.actorStateReference01, 0);
                           GameCanvas.setActorFacingDirection(gameCanvas.gameActorGroupReference03.actorStateReference01, 3);
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        }
                        break;
                     case 15:
                        if (var4 > 1000L) {
                           GameCanvas.setActorFacingDirection(gameCanvas.gameActorGroupReference03.actorStateReference01, 7);
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        }
                        break;
                     case 16:
                        if (var4 > 500L) {
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.showGameMessageWithStyle(0, 0, GameCanvas.getLocalizedText(54), 0);
                        }
                        break;
                     case 17:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.moveActorToTile(gameCanvas.gameActorGroupReference04.actorStateReference01, 25, 41);
                        }
                        break;
                     case 18:
                        if (gameCanvas.gameActorGroupReference04.actorStateReference01.byteValue12 == -1 && gameCanvas.gameActorGroupReference04.actorStateReference01.byteValue13 == -1) {
                           gameCanvas.transitionGameState(2);
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.showGameMessageWithStyle(0, 0, GameCanvas.getLocalizedText(55), 0);
                        }
                        break;
                     case 19:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.showGameMessageWithStyle(0, 1, GameCanvas.getLocalizedText(56), 0);
                        }
                        break;
                     case 20:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.showGameMessage(0, 1, GameCanvas.getLocalizedText(57), 0);
                        }
                        break;
                     case 21:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.showGameMessage(0, 0, GameCanvas.getLocalizedText(58), 0);
                        }
                        break;
                     case 22:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.showGameMessage(0, 1, GameCanvas.getLocalizedText(59), 0);
                        }
                        break;
                     case 23:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.setActiveActorGroup(2);
                        }
                        break;
                     case 24:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.showGameMessage(0, 1, GameCanvas.getLocalizedText(60), 0);
                        }
                        break;
                     case 25:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.showGameMessage(0, 6, GameCanvas.getLocalizedText(61), 0);
                        }
                        break;
                     case 26:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.showGameMessage(0, 6, GameCanvas.getLocalizedText(62), 0);
                        }
                        break;
                     case 27:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           GameCanvas.gameBooleanFlag23 = true;
                           GameCanvas.setGamePaused(true);
                           GameCanvas.gameBooleanFlag59 = true;
                           GameCanvas.stopAudioPlayer();
                           GameCanvas.gameBooleanFlag53 = false;
                        } break;
                  }

                  return 1;
               default:
                  return 0;
            } goto case 20;
         case 20:
            if (gameCanvas.gameActorStateReference03 != null) {
               setActorPosition(gameCanvas.gameActorStateReference03, 5, 0);
               gameCanvas.gameActorStateReference03.booleanFlag01 = false;
            } else {
               for (int var13 = 0; var13 < 25; var13++) {
                  if (gameCanvas.gameActorStateReferenceArray01[var13].byteValue08 == 5) {
                     setActorPosition(gameCanvas.gameActorStateReferenceArray01[var13], 5, 0);
                     gameCanvas.gameActorStateReferenceArray01[var13].booleanFlag01 = false;
                  }
               }
            }

            GameCanvas.setGamePaused(true);
            return 1;
         case 30:
            switch (GameCanvas.gameByteValue07) {
               case 0:
                  gameCanvas.setActiveActorGroupDirection((sbyte)31);
                  if (gameCanvas.gameByteValue22 == 0) {
                     gameCanvas.disableActorActionFlag(2, 7);
                     gameCanvas.enableActorActionFlag(2, 0);
                     gameCanvas.enableActorActionFlag(2, 3);
                     gameCanvas.gameByteValue22 = 2;
                     GameCanvas.setGamePaused(true);
                  } else {
                     gameCanvas.disableActorActionFlag(2, 1);
                     gameCanvas.disableActorActionFlag(2, 4);
                     gameCanvas.enableActorActionFlag(2, 2);
                     gameCanvas.enableActorActionFlag(2, 5);
                     gameCanvas.enableActorActionFlag(2, 6);
                     gameCanvas.gameByteValue22 = 3;
                     gameCanvas.setActiveActorGroup(8);
                     gameCanvas.gameIntegerValue66 = 0;
                     GameCanvas.setGamePaused(false);
                  }

                  return 2;
               case 1:
                  if (GameCanvas.gameIntegerValue50 != 131) {
                     if (gameCanvas.gameIntegerValue66 != 0) {
                        GameCanvas.setGamePaused(true);
                        return 2;
                     }

                     gameCanvas.setActiveActorGroup(26);
                     gameCanvas.gameIntegerValue66 = 1;
                  }

                  return 1;
               default:
                  return 0;
            } goto case 40;
         case 40:
            switch (GameCanvas.gameByteValue07) {
               case 0:
                  if (gameCanvas.gameBooleanFlag35) {
                     GameCanvas.setGamePaused(true);
                     return 1;
                  } else {
                     gameCanvas.setActorAnimationState(GameCanvas.getLocalizedText(87), (short)0, (sbyte)5);
                     GameCanvas.setGamePaused(false);
                  } goto default;
               default:
                  return 1;
               case 1:
                  if (GameCanvas.gameIntegerValue50 != 137) {
                     if (gameCanvas.gameStringBufferReference01.charAt(0) == 'R'
                        && gameCanvas.gameStringBufferReference01.charAt(1) == 'A'
                        && gameCanvas.gameStringBufferReference01.charAt(2) == 'V'
                        && gameCanvas.gameStringBufferReference01.charAt(3) == 'E'
                        && gameCanvas.gameStringBufferReference01.charAt(4) == 'N') {
                        gameCanvas.gameShortMatrix02[gameCanvas.gameClass9ReferenceArray01[545].byteValue02][gameCanvas.gameClass9ReferenceArray01[545].byteValue03] = -1;
                        gameCanvas.gameBooleanFlag35 = true;
                        gameCanvas.gameByteValue16 = 0;
                        gameCanvas.activateActorRuntimeState(545);
                        gameCanvas.updateTimedEntities();
                        gameCanvas.processActorAction(12);
                     } else {
                        gameCanvas.showGameMessage(0, 2, GameCanvas.getLocalizedText(89), 0);
                     }

                     GameCanvas.setGamePaused(true);
                  }

                  return 1;
            } goto case 50;
         case 50:
            switch (GameCanvas.gameByteValue07) {
               case 0:
                  gameCanvas.advanceGameplaySimulation();
                  if (gameCanvas.gameActorGroupReference02.actorStateReference01.byteValue01 == 29 && gameCanvas.gameActorGroupReference02.actorStateReference01.byteValue02 == 30) {
                     gameCanvas.gameActorStateReference05 = gameCanvas.createActorState(2, 30, 30, 7);
                  } else {
                     gameCanvas.gameActorStateReference05 = gameCanvas.createActorState(2, 29, 30, 7);
                  }

                  gameCanvas.updateActorGroupState(true);
                  gameCanvas.updateActorDisplayState(gameCanvas.gameActorStateReference05, true);
                  gameCanvas.showGameMessage(0, 2, GameCanvas.getLocalizedText(63), 0);
                  gameCanvas.gameIntegerValue66 = 0;
                  GameCanvas.setGamePaused(false);
                  return 2;
               case 1:
                  switch (gameCanvas.gameIntegerValue66) {
                     case 0:
                        gameCanvas.updateActorDisplayState(gameCanvas.gameActorStateReference05, true);
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.updateActorDisplayState(gameCanvas.gameActorGroupReference01.actorStateReference01, true);
                           GameCanvas.gameByteValue07 = 3;
                        } goto default;
                     default:
                        return 1;
                  } goto case 2;
               case 2:
               default:
                  return 0;
               case 3:
                  if (gameCanvas.gameActorStateReference05.byteValue05 == 4) {
                     GameCanvas.setGamePaused(true);
                     return 2;
                  }

                  return 1;
            } goto case 60;
         case 60:
            switch (GameCanvas.gameByteValue07) {
               case 0:
                  gameCanvas.setActiveActorGroupDirection((sbyte)32);
                  if (gameCanvas.gameByteValue22 == 0) {
                     gameCanvas.disableActorActionFlag(2, 7);
                     gameCanvas.enableActorActionFlag(2, 1);
                     gameCanvas.enableActorActionFlag(2, 4);
                     gameCanvas.gameByteValue22 = 1;
                     GameCanvas.setGamePaused(true);
                  } else {
                     gameCanvas.disableActorActionFlag(2, 0);
                     gameCanvas.disableActorActionFlag(2, 3);
                     gameCanvas.enableActorActionFlag(2, 2);
                     gameCanvas.enableActorActionFlag(2, 5);
                     gameCanvas.enableActorActionFlag(2, 6);
                     gameCanvas.gameByteValue22 = 3;
                     gameCanvas.setActiveActorGroup(8);
                     gameCanvas.gameIntegerValue66 = 0;
                     GameCanvas.setGamePaused(false);
                  }

                  return 2;
               case 1:
                  if (GameCanvas.gameIntegerValue50 != 131) {
                     if (gameCanvas.gameIntegerValue66 != 0) {
                        GameCanvas.setGamePaused(true);
                        return 2;
                     }

                     gameCanvas.setActiveActorGroup(26);
                     gameCanvas.gameIntegerValue66 = 1;
                  }

                  return 1;
               default:
                  return 0;
            } goto case 70;
         case 70:
            switch (GameCanvas.gameByteValue07) {
               case 0:
                  gameCanvas.gameActorStateReference01 = gameCanvas.createActorState(3, 33, 19, 1);
                  gameCanvas.gameActorStateReference05 = gameCanvas.createActorState(11, 37, 21, 7);
                  gameCanvas.gameActorStateReference06 = gameCanvas.createActorState(11, 24, 19, 1);
                  gameCanvas.updateActorGroupState(true);
                  gameCanvas.gameIntegerValue66 = 0;
                  GameCanvas.setGamePaused(false);
                  gameCanvas.updateActorDisplayState(gameCanvas.gameActorStateReference01, true);
                  return 1;
               case 1:
                  switch (gameCanvas.gameIntegerValue66) {
                     case 0:
                        gameCanvas.showGameMessage(0, 3, GameCanvas.getLocalizedText(64), 0);
                        gameCanvas.gameIntegerValue66++;
                        break;
                     case 1:
                        gameCanvas.updateActorDisplayState(gameCanvas.gameActorStateReference01, true);
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.updateActorDisplayState(gameCanvas.gameActorGroupReference01.actorStateReference01, true);
                           GameCanvas.gameByteValue07 = 3;
                        } goto case 2;
                     case 2:
                     default:
                        break;
                     case 3:
                        if (gameCanvas.gameActorGroupReference01 == gameCanvas.gameActorGroupReference03) {
                           if (isActorAtPosition(gameCanvas.gameActorGroupReference03.actorStateReference01, 29, 29)) {
                              setActorPosition(gameCanvas.gameActorGroupReference04.actorStateReference01, 30, 29);
                           } else {
                              gameCanvas.gameActorGroupReference04.byteValue05 = 0;
                              gameCanvas.gameActorGroupReference04.actorStateReference01.booleanFlag01 = true;
                              setActorPosition(gameCanvas.gameActorGroupReference04.actorStateReference01, 29, 29);
                           }
                        } else if (isActorAtPosition(gameCanvas.gameActorGroupReference04.actorStateReference01, 30, 29)) {
                           setActorPosition(gameCanvas.gameActorGroupReference03.actorStateReference01, 29, 29);
                        } else {
                           gameCanvas.gameActorGroupReference03.byteValue05 = 0;
                           gameCanvas.gameActorGroupReference03.actorStateReference01.booleanFlag01 = true;
                           setActorPosition(gameCanvas.gameActorGroupReference03.actorStateReference01, 30, 29);
                        }

                        gameCanvas.gameActorGroupReference04.booleanFlag04 = true;
                        gameCanvas.gameActorGroupReference04.actorStateReference01.byteValue09 = 127;
                        gameCanvas.gameActorGroupReference03.booleanFlag04 = true;
                        gameCanvas.gameActorGroupReference03.actorStateReference01.byteValue09 = 127;
                        if (JMath.abs(gameCanvas.gameActorGroupReference03.actorStateReference01.byteValue01 - 32) < JMath.abs(gameCanvas.gameActorGroupReference03.actorStateReference01.byteValue01 - 35)) {
                           gameCanvas.moveActorToTile(gameCanvas.gameActorGroupReference03.actorStateReference01, 32, 21);
                        } else {
                           gameCanvas.moveActorToTile(gameCanvas.gameActorGroupReference03.actorStateReference01, 35, 21);
                        }

                        gameCanvas.moveActorToTile(gameCanvas.gameActorGroupReference04.actorStateReference01, 32, 24);
                        gameCanvas.gameIntegerValue66++;
                        break;
                     case 4:
                        if (gameCanvas.gameByteValue03 == 2) {
                           gameCanvas.setActorState(1);
                           gameCanvas.gameByteValue14 = 2;
                        }

                        if (!GameCanvas.isActorDefeated(gameCanvas.gameActorGroupReference04.actorStateReference01) && isActorAtPosition(gameCanvas.gameActorGroupReference04.actorStateReference01, 32, 24)) {
                           gameCanvas.gameActorGroupReference04.booleanFlag04 = false;
                           gameCanvas.faceActorTowardPosition(gameCanvas.gameActorGroupReference04.actorStateReference01, 0);
                           GameCanvas.setActorFacingDirection(gameCanvas.gameActorGroupReference04.actorStateReference01, 1);
                        }

                        if (!GameCanvas.isActorDefeated(gameCanvas.gameActorGroupReference03.actorStateReference01)
                           && gameCanvas.gameActorGroupReference03.actorStateReference01.byteValue12 == -1
                           && gameCanvas.gameActorGroupReference03.actorStateReference01.byteValue13 == -1) {
                           gameCanvas.gameActorGroupReference03.booleanFlag04 = false;
                           gameCanvas.faceActorTowardPosition(gameCanvas.gameActorGroupReference03.actorStateReference01, 0);
                           GameCanvas.setActorFacingDirection(gameCanvas.gameActorGroupReference03.actorStateReference01, 3);
                           gameCanvas.moveActorToTile(gameCanvas.gameActorStateReference01, 39, 24);
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        }
                        break;
                     case 5:
                        if (var4 > 250L) {
                           gameCanvas.showGameMessage(0, 0, GameCanvas.getLocalizedText(65), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 6:
                        if (!GameCanvas.isActorDefeated(gameCanvas.gameActorGroupReference04.actorStateReference01) && isActorAtPosition(gameCanvas.gameActorGroupReference04.actorStateReference01, 32, 24)) {
                           gameCanvas.gameActorGroupReference04.booleanFlag04 = false;
                           gameCanvas.faceActorTowardPosition(gameCanvas.gameActorGroupReference04.actorStateReference01, 0);
                           GameCanvas.setActorFacingDirection(gameCanvas.gameActorGroupReference04.actorStateReference01, 1);
                        }

                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.moveActorToTile(gameCanvas.gameActorGroupReference03.actorStateReference01, 33, 19);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 7:
                        if (!GameCanvas.isActorDefeated(gameCanvas.gameActorGroupReference04.actorStateReference01) && isActorAtPosition(gameCanvas.gameActorGroupReference04.actorStateReference01, 32, 24)) {
                           gameCanvas.gameActorGroupReference04.booleanFlag04 = false;
                           gameCanvas.faceActorTowardPosition(gameCanvas.gameActorGroupReference04.actorStateReference01, 0);
                           GameCanvas.setActorFacingDirection(gameCanvas.gameActorGroupReference04.actorStateReference01, 1);
                        }

                        if (gameCanvas.gameActorGroupReference03.actorStateReference01.byteValue12 == -1 && gameCanvas.gameActorGroupReference03.actorStateReference01.byteValue13 == -1) {
                           gameCanvas.gameActorGroupReference03.actorStateReference01.byteValue07 = 1;
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 8:
                        if (!GameCanvas.isActorDefeated(gameCanvas.gameActorGroupReference04.actorStateReference01) && isActorAtPosition(gameCanvas.gameActorGroupReference04.actorStateReference01, 32, 24)) {
                           gameCanvas.gameActorGroupReference04.booleanFlag04 = false;
                           gameCanvas.faceActorTowardPosition(gameCanvas.gameActorGroupReference04.actorStateReference01, 0);
                           GameCanvas.setActorFacingDirection(gameCanvas.gameActorGroupReference04.actorStateReference01, 1);
                        }

                        if (gameCanvas.gameActorStateReference01.byteValue12 == -1 && gameCanvas.gameActorStateReference01.byteValue13 == -1) {
                           gameCanvas.moveActorToTile(gameCanvas.gameActorStateReference01, 51, 26);
                           gameCanvas.moveActorToTile(gameCanvas.gameActorGroupReference03.actorStateReference01, 33, 24);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 9:
                        if (gameCanvas.gameActorGroupReference03.actorStateReference01.byteValue12 == -1 && gameCanvas.gameActorGroupReference03.actorStateReference01.byteValue13 == -1) {
                           gameCanvas.gameActorGroupReference03.actorStateReference01.byteValue07 = 5;
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        }
                        break;
                     case 10:
                        if (var4 > 500L) {
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.showGameMessage(0, 1, GameCanvas.getLocalizedText(66), 0);
                        }
                        break;
                     case 11:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.gameIntegerValue66++;
                           GameCanvas.setActorFacingDirection(gameCanvas.gameActorGroupReference03.actorStateReference01, 1);
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        }
                        break;
                     case 12:
                        if (var4 > 1000L) {
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.showGameMessage(0, 0, GameCanvas.getLocalizedText(67), 0);
                        }
                        break;
                     case 13:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.showGameMessage(0, 1, GameCanvas.getLocalizedText(68), 0);
                        }
                        break;
                     case 14:
                        gameCanvas.faceActorTowardPosition(gameCanvas.gameActorGroupReference03.actorStateReference01, 1);
                        gameCanvas.gameIntegerValue66++;
                        break;
                     case 15:
                        if (!GameCanvas.isActorDefeated(gameCanvas.gameActorGroupReference03.actorStateReference01)) {
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.showGameMessage(0, 0, GameCanvas.getLocalizedText(69), 0);
                        }
                        break;
                     case 16:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.showGameMessage(0, 0, GameCanvas.getLocalizedText(70), 0);
                        }
                        break;
                     case 17:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.faceActorTowardPosition(gameCanvas.gameActorGroupReference04.actorStateReference01, 1);
                        }
                        break;
                     case 18:
                        if (!GameCanvas.isActorDefeated(gameCanvas.gameActorGroupReference04.actorStateReference01)) {
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.showGameMessage(0, 1, GameCanvas.getLocalizedText(71), 0);
                        }
                        break;
                     case 19:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           if (gameCanvas.gameByteValue14 != 0) {
                              gameCanvas.setActorState(gameCanvas.gameByteValue14);
                              gameCanvas.gameByteValue14 = 0;
                           }

                           gameCanvas.gameActorStateReference01.booleanFlag01 = false;
                           GameCanvas.setGamePaused(true);
                        } break;
                  }

                  return 1;
               case 2:
               default:
                  return 0;
               case 3:
                  if ((gameCanvas.gameActorStateReference05.byteValue05 == 4 || !gameCanvas.gameActorStateReference05.booleanFlag01)
                     && (gameCanvas.gameActorStateReference06.byteValue05 == 4 || !gameCanvas.gameActorStateReference06.booleanFlag01)) {
                     GameCanvas.gameByteValue07 = 1;
                     gameCanvas.gameIntegerValue66 = 3;
                  }

                  return 1;
            } goto case 80;
         case 80:
            switch (GameCanvas.gameByteValue07) {
               case 0:
                  gameCanvas.activateActorRuntimeState(521);
                  gameCanvas.gameIntegerValue66 = 0;
                  gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                  GameCanvas.setGamePaused(false);
                  return 1;
               case 1:
                  switch (gameCanvas.gameIntegerValue66) {
                     case 0:
                        if (var4 > 500L) {
                           gameCanvas.processActorAction(17);
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.showGameMessage(0, 6, GameCanvas.getLocalizedText(85), 0);
                        }
                        break;
                     case 1:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           GameCanvas.setActorFacingDirection(gameCanvas.gameActorGroupReference01.actorStateReference01, 1);
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 2:
                        if (var4 > 1000L) {
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.showGameMessage(0, 2, GameCanvas.getLocalizedText(168), 0);
                        }
                        break;
                     case 3:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           GameCanvas.setGamePaused(true);
                        } break;
                  }

                  return 1;
               default:
                  return 0;
            } goto case 90;
         case 90:
            switch (GameCanvas.gameByteValue07) {
               case 0:
                  gameCanvas.moveActorToTile(gameCanvas.gameActorGroupReference03.actorStateReference01, 64, 20);
                  gameCanvas.gameIntegerValue66 = 0;
                  gameCanvas.setActorState(1);
                  GameCanvas.setGamePaused(false);
                  return 1;
               case 1:
                  switch (gameCanvas.gameIntegerValue66) {
                     case 0:
                        if (gameCanvas.hasActorStateChanged(gameCanvas.gameActorGroupReference03.actorStateReference01)
                           && gameCanvas.gameActorGroupReference03.actorStateReference01.byteValue01 == 64
                           && gameCanvas.gameActorGroupReference03.actorStateReference01.byteValue02 == 20) {
                           gameCanvas.showGameMessage(0, 0, GameCanvas.getLocalizedText(169), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 1:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           GameCanvas.setActorFacingDirection(gameCanvas.gameActorGroupReference03.actorStateReference01, 5);
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 2:
                        if (var4 > 2000L) {
                           gameCanvas.gameActorStateReference03 = gameCanvas.createActorState(5, 58, 25, 3);
                           gameCanvas.updateActorDisplayState(gameCanvas.gameActorStateReference03, true);
                           GameCanvas.setActorFacingDirection(gameCanvas.gameActorStateReference03, 1);
                           gameCanvas.faceActorTowardPosition(gameCanvas.gameActorStateReference03, 1);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 3:
                     case 4:
                        if (gameCanvas.gameActorStateReference03.byteValue05 == 0) {
                           gameCanvas.faceActorTowardPosition(gameCanvas.gameActorStateReference03, 5);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 5:
                        if (gameCanvas.gameActorStateReference03.byteValue05 == 0) {
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                           gameCanvas.gameIntegerValue66++;
                        } goto case 6;
                     case 6:
                        if (var4 > 700L) {
                           GameCanvas.setActorFacingDirection(gameCanvas.gameActorStateReference03, 3);
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 7:
                        if (var4 > 500L) {
                           gameCanvas.faceActorTowardPosition(gameCanvas.gameActorStateReference03, 5);
                           gameCanvas.gameIntegerValue66++;
                        } goto case 8;
                     case 8:
                        if (gameCanvas.gameActorStateReference03.byteValue05 == 0) {
                           gameCanvas.updatePlayerActor();
                           gameCanvas.updateActorDisplayState(gameCanvas.gameActorGroupReference03.actorStateReference01, false);
                           GameCanvas.gameByteValue07 = 3;
                           gameCanvas.gameIntegerValue66++;
                        } goto case 9;
                     case 9:
                     default:
                        break;
                     case 10:
                        gameCanvas.gameActorStateReference03.booleanFlag05 = true;
                        gameCanvas.moveActorToTile(gameCanvas.gameActorStateReference03, 57, 24);
                        gameCanvas.gameIntegerValue66++;
                        if (gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue01 <= 62 && gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue02 == 19) {
                           gameCanvas.moveActorToTile(gameCanvas.gameActorGroupReference01.actorStateReference01, 63, 19);
                        }
                        break;
                     case 11:
                        if (!GameCanvas.isActorDefeated(gameCanvas.gameActorGroupReference01.actorStateReference01)) {
                           gameCanvas.moveActorTowardTileY(gameCanvas.gameActorGroupReference01.actorStateReference01, gameCanvas.gameActorStateReference03.byteValue01, gameCanvas.gameActorStateReference03.byteValue02);
                        }

                        if (gameCanvas.gameActorStateReference03.byteValue12 == -1 && gameCanvas.gameActorStateReference03.byteValue13 == -1) {
                           gameCanvas.gameActorStateReference03.booleanFlag01 = false;
                           gameCanvas.gameActorStateReference03.booleanFlag05 = false;
                           gameCanvas.updatePlayerActor();
                           GameCanvas.setGamePaused(true);
                           gameCanvas.faceActorTowardPosition(gameCanvas.gameActorGroupReference04.actorStateReference01, 0);
                        } else if (gameCanvas.gameActorStateReference03.byteValue05 != 1) {
                           gameCanvas.faceActorTowardPosition(gameCanvas.gameActorStateReference03, 1);
                        } break;
                  }

                  return 1;
               case 2:
               default:
                  return 0;
               case 3:
                  if (gameCanvas.gameActorStateReference03.byteValue10 < gameCanvas.gameActorStateReference03.byteValue11 - 45) {
                     gameCanvas.gameActorStateReference03.byteValue10 = (sbyte)(gameCanvas.gameActorStateReference03.byteValue11 - 45);
                  }

                  if (gameCanvas.gameActorStateReference03.byteValue10 <= gameCanvas.gameActorStateReference03.byteValue11 - 45) {
                     gameCanvas.gameIntegerValue66 = 10;
                     GameCanvas.setGamePaused(false);
                  }

                  return 1;
            } goto case 100;
         case 100:
            if (gameCanvas.gameClass9ReferenceArray01[11].actorFlagsReferenceArray01[1].booleanFlag01) {
               gameCanvas.disableActorActionFlag(11, 1);
               gameCanvas.setActiveActorGroup(47);
            } else {
               gameCanvas.showGameMessage(0, 2, GameCanvas.getLocalizedText(72), 0);
            }

            GameCanvas.setGamePaused(true);
            return 1;
         case 110:
            switch (GameCanvas.gameByteValue07) {
               case 0:
                  if (gameCanvas.gameByteMatrix02[gameCanvas.gameActorGroupReference02.actorStateReference01.byteValue01][gameCanvas.gameActorGroupReference02.actorStateReference01.byteValue02] == gameCanvas.gameByteMatrix02[53][30]
                     && gameCanvas.gameActorGroupReference02.actorStateReference01.booleanFlag01) {
                     GameCanvas.setGamePaused(true);
                     return 1;
                  } else {
                     if (!isActorAtPosition(gameCanvas.gameActorGroupReference01.actorStateReference01, 55, 27)) {
                        GameCanvas.setGamePaused(true);
                        return 1;
                     }

                     if (gameCanvas.gameByteValue17 != 1) {
                        GameCanvas.setGamePaused(true);
                     } else {
                        gameCanvas.gameActorStateReference01 = gameCanvas.createActorState(3, 53, 30, 1);
                        gameCanvas.faceActorTowardPosition(gameCanvas.gameActorStateReference01, 4);
                        gameCanvas.updateActorDisplayState(gameCanvas.gameActorStateReference01, true);
                        gameCanvas.gameActorGroupReference01.booleanFlag04 = true;
                        gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue09 = 127;
                        gameCanvas.moveActorToTile(gameCanvas.gameActorGroupReference01.actorStateReference01, 53, 29);
                        gameCanvas.gameIntegerValue66 = 0;
                        GameCanvas.setGamePaused(false);
                     }

                     return 1;
                  } goto case 1;
               case 1:
                  switch (gameCanvas.gameIntegerValue66) {
                     case 0:
                        if (!GameCanvas.isActorDefeated(gameCanvas.gameActorGroupReference01.actorStateReference01) && isActorAtPosition(gameCanvas.gameActorGroupReference01.actorStateReference01, 53, 29)) {
                           gameCanvas.gameActorGroupReference01.booleanFlag04 = false;
                           gameCanvas.faceActorTowardPosition(gameCanvas.gameActorGroupReference01.actorStateReference01, 11);
                           GameCanvas.setActorFacingDirection(gameCanvas.gameActorGroupReference01.actorStateReference01, 7);
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 1:
                        if (var4 > 1000L) {
                           gameCanvas.showGameMessage(0, 2, GameCanvas.getLocalizedText(183), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 2:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 3:
                        if (var4 > 2000L) {
                           gameCanvas.showGameMessage(0, 3, GameCanvas.getLocalizedText(184), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 4:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.showGameMessage(0, 3, GameCanvas.getLocalizedText(185), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 5:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.faceActorTowardPosition(gameCanvas.gameActorGroupReference01.actorStateReference01, 0);
                           GameCanvas.setActorFacingDirection(gameCanvas.gameActorGroupReference01.actorStateReference01, 7);
                           gameCanvas.updateActorDisplayState(gameCanvas.gameActorGroupReference01.actorStateReference01, false);
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 6:
                        if (var4 > 2000L) {
                           gameCanvas.showGameMessage(0, 2, GameCanvas.getLocalizedText(186), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 7:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.showGameMessage(0, 2, GameCanvas.getLocalizedText(187), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 8:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.faceActorTowardPosition(gameCanvas.gameActorGroupReference01.actorStateReference01, 11);
                           GameCanvas.setActorFacingDirection(gameCanvas.gameActorGroupReference01.actorStateReference01, 7);
                           gameCanvas.gameActorStateReference01.booleanFlag01 = false;
                           gameCanvas.gameIntegerValue90 = 30;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 9:
                     case 10:
                     case 11:
                     case 12:
                        if (var4 > 200L) {
                           gameCanvas.gameIntegerValue90++;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 13:
                        if (var4 > 1500L) {
                           gameCanvas.gameIntegerValue90 = 0;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 14:
                        gameCanvas.faceActorTowardPosition(gameCanvas.gameActorGroupReference01.actorStateReference01, 0);
                        gameCanvas.showGameMessage(0, 2, GameCanvas.getLocalizedText(188), 0);
                        gameCanvas.gameIntegerValue66++;
                        break;
                     case 15:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           GameCanvas.setActorFacingDirection(gameCanvas.gameActorGroupReference01.actorStateReference01, 1);
                           gameCanvas.gameByteValue17 = 2;
                           GameCanvas.setGamePaused(true);
                        } break;
                  }

                  return 1;
               default:
                  return 0;
            } goto case 120;
         case 120:
            switch (GameCanvas.gameByteValue07) {
               case 0:
                  if (gameCanvas.gameBooleanFlag43) {
                     GameCanvas.setGamePaused(true);
                  }

                  gameCanvas.gameActorGroupReference01.byteValue02 = 0;
                  if (gameCanvas.gameActorGroupReference02.byteValue05 == 0 && isActorAtPosition(gameCanvas.gameActorGroupReference02.actorStateReference01, 29, 12)) {
                     gameCanvas.gameIntegerValue66 = 0;
                     gameCanvas.moveActorToTile(gameCanvas.gameActorGroupReference02.actorStateReference01, 29, 13);
                     GameCanvas.setGamePaused(false);
                     return 1;
                  }

                  gameCanvas.gameIntegerValue93 = 532;
                  gameCanvas.gameIntegerValue94 = 0;
                  gameCanvas.gameIntegerValue95 = 0;
                  GameCanvas.gameByteValue07 = 3;
                  return 1;
               case 1:
                  switch (gameCanvas.gameIntegerValue66) {
                     case 0:
                        if (!GameCanvas.isActorDefeated(gameCanvas.gameActorGroupReference02.actorStateReference01) && isActorAtPosition(gameCanvas.gameActorGroupReference02.actorStateReference01, 29, 13)) {
                           gameCanvas.gameIntegerValue93 = 532;
                           gameCanvas.gameIntegerValue94 = 0;
                           gameCanvas.gameIntegerValue95 = 0;
                           GameCanvas.gameByteValue07 = 3;
                        } goto default;
                     default:
                        return 1;
                  } goto case 2;
               case 2:
               default:
                  return 0;
               case 3:
                  if (gameCanvas.gameIntegerValue95 >= 35) {
                     gameCanvas.deactivateActorRuntimeState(532);
                     gameCanvas.activateActorRuntimeState(74);
                     gameCanvas.activateActorRuntimeState(536);
                     gameCanvas.gameBooleanFlag43 = true;
                     GameCanvas.setGamePaused(true);
                     return 2;
                  }

                  gameCanvas.gameIntegerValue95++;
                  return 1;
            } goto case 130;
         case 130:
            switch (GameCanvas.gameByteValue07) {
               case 0:
                  if (gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue08 != 0) {
                     GameCanvas.setGamePaused(true);
                     return 1;
                  } else if (gameCanvas.gameByteMatrix02[gameCanvas.gameActorGroupReference02.actorStateReference01.byteValue01][gameCanvas.gameActorGroupReference02.actorStateReference01.byteValue02]
                        == gameCanvas.gameByteMatrix02[64][20]
                     && gameCanvas.gameActorGroupReference02.actorStateReference01.booleanFlag01) {
                     GameCanvas.setGamePaused(true);
                     return 1;
                  } else if (!isActorAtPosition(gameCanvas.gameActorGroupReference01.actorStateReference01, 67, 18)
                     && !isActorAtPosition(gameCanvas.gameActorGroupReference01.actorStateReference01, 58, 25)
                     && !isActorAtPosition(gameCanvas.gameActorGroupReference01.actorStateReference01, 58, 24)) {
                     GameCanvas.setGamePaused(true);
                     return 1;
                  } else {
                     if (gameCanvas.gameByteValue18 != 1) {
                        GameCanvas.setGamePaused(true);
                        return 1;
                     }

                     gameCanvas.gameActorStateReference01 = gameCanvas.createActorState(3, 64, 21, 5);
                     gameCanvas.gameIntegerValue66 = 0;
                     GameCanvas.setGamePaused(false);
                     if (gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue01 > gameCanvas.gameActorStateReference01.byteValue01) {
                        sbyte var12 = gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue10;
                        gameCanvas.gameBooleanFlag49 = true;
                        gameCanvas.createActorState(0, gameCanvas.gameClass9ReferenceArray01[545].byteValue02, gameCanvas.gameClass9ReferenceArray01[545].byteValue03, 7);
                        GameCanvas.setActorFacingDirection(gameCanvas.gameActorGroupReference03.actorStateReference01, 7);
                        gameCanvas.moveActorToTile(gameCanvas.gameActorGroupReference03.actorStateReference01, gameCanvas.gameClass9ReferenceArray01[545].byteValue02, gameCanvas.gameClass9ReferenceArray01[545].byteValue03 + 2);
                        gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue10 = var12;
                     } else {
                        gameCanvas.gameBooleanFlag49 = false;
                        gameCanvas.moveActorToTile(gameCanvas.gameActorGroupReference01.actorStateReference01, 62, 23);
                     }

                     gameCanvas.updateActorDisplayState(gameCanvas.gameActorStateReference01, true);
                     return 1;
                  } goto case 1;
               case 1:
                  switch (gameCanvas.gameIntegerValue66) {
                     case 0:
                        if (!GameCanvas.isActorDefeated(gameCanvas.gameActorGroupReference03.actorStateReference01)) {
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                           if (gameCanvas.gameBooleanFlag49) {
                              GameCanvas.setActorFacingDirection(gameCanvas.gameActorStateReference01, 1);
                           } else {
                              GameCanvas.setActorFacingDirection(gameCanvas.gameActorStateReference01, 7);
                           }
                        }
                        break;
                     case 1:
                        if (var4 > 1000L) {
                           if (gameCanvas.gameBooleanFlag49) {
                              gameCanvas.moveActorToTile(gameCanvas.gameActorStateReference01, gameCanvas.gameActorGroupReference03.actorStateReference01.byteValue01, gameCanvas.gameActorGroupReference03.actorStateReference01.byteValue02 + 1);
                              GameCanvas.setActorFacingDirection(gameCanvas.gameActorGroupReference03.actorStateReference01, 5);
                           } else {
                              gameCanvas.moveActorToTile(gameCanvas.gameActorStateReference01, gameCanvas.gameActorGroupReference03.actorStateReference01.byteValue01 + 1, gameCanvas.gameActorGroupReference03.actorStateReference01.byteValue02);
                              GameCanvas.setActorFacingDirection(gameCanvas.gameActorGroupReference03.actorStateReference01, 3);
                           }

                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 2:
                        if (gameCanvas.gameBooleanFlag49) {
                           if (gameCanvas.gameActorStateReference01.byteValue02 > gameCanvas.gameActorGroupReference03.actorStateReference01.byteValue02 - 1) {
                              GameCanvas.setActorFacingDirection(gameCanvas.gameActorGroupReference03.actorStateReference01, 7);
                           }

                           if (isActorAtPosition(gameCanvas.gameActorStateReference01, gameCanvas.gameActorGroupReference03.actorStateReference01.byteValue01, gameCanvas.gameActorGroupReference03.actorStateReference01.byteValue02 + 1)
                              && !GameCanvas.isActorDefeated(gameCanvas.gameActorStateReference01)) {
                              GameCanvas.setActorFacingDirection(gameCanvas.gameActorStateReference01, 3);
                              gameCanvas.gameIntegerValue66++;
                              gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                           }
                        } else {
                           if (gameCanvas.gameActorStateReference01.byteValue01 > gameCanvas.gameActorGroupReference03.actorStateReference01.byteValue01 + 1) {
                              GameCanvas.setActorFacingDirection(gameCanvas.gameActorGroupReference03.actorStateReference01, 1);
                           }

                           if (isActorAtPosition(gameCanvas.gameActorStateReference01, gameCanvas.gameActorGroupReference03.actorStateReference01.byteValue01 + 1, gameCanvas.gameActorGroupReference03.actorStateReference01.byteValue02)
                              && !GameCanvas.isActorDefeated(gameCanvas.gameActorStateReference01)) {
                              GameCanvas.setActorFacingDirection(gameCanvas.gameActorStateReference01, 5);
                              gameCanvas.gameIntegerValue66++;
                              gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                           }
                        }
                        break;
                     case 3:
                        if (var4 > 500L) {
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.showGameMessage(0, 0, GameCanvas.getLocalizedText(170), 0);
                        }
                        break;
                     case 4:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.showGameMessage(0, 3, GameCanvas.getLocalizedText(171), 0);
                        }
                        break;
                     case 5:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.updateActorDisplayState(gameCanvas.gameActorGroupReference03.actorStateReference01, true);
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.showGameMessage(0, 3, GameCanvas.getLocalizedText(172), 0);
                        }
                        break;
                     case 6:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.setActiveActorGroup(37);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 7:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.updateActorDisplayState(gameCanvas.gameActorGroupReference03.actorStateReference01, true);
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.showGameMessage(0, 0, GameCanvas.getLocalizedText(173), 0);
                        }
                        break;
                     case 8:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        }
                        break;
                     case 9:
                        if (var4 > 1000L) {
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.showGameMessage(0, 3, GameCanvas.getLocalizedText(174), 0);
                        }
                        break;
                     case 10:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.showGameMessage(0, 0, GameCanvas.getLocalizedText(175), 0);
                        }
                        break;
                     case 11:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.showGameMessage(0, 0, GameCanvas.getLocalizedText(176), 0);
                        }
                        break;
                     case 12:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.updateActorDisplayState(gameCanvas.gameActorStateReference01, false);
                           if (gameCanvas.gameBooleanFlag49) {
                              gameCanvas.moveActorToTile(
                                 gameCanvas.gameActorStateReference01, gameCanvas.gameActorGroupReference03.actorStateReference01.byteValue01 - 2, gameCanvas.gameActorGroupReference03.actorStateReference01.byteValue02 + 2
                              );
                           } else {
                              gameCanvas.moveActorToTile(gameCanvas.gameActorStateReference01, gameCanvas.gameActorGroupReference03.actorStateReference01.byteValue01 + 2, gameCanvas.gameActorGroupReference03.actorStateReference01.byteValue02);
                           }
                        }
                        break;
                     case 13:
                        if (!GameCanvas.isActorDefeated(gameCanvas.gameActorStateReference01)) {
                           gameCanvas.gameIntegerValue66++;
                           if (gameCanvas.gameBooleanFlag49) {
                              GameCanvas.setActorFacingDirection(gameCanvas.gameActorStateReference01, 5);
                           } else {
                              GameCanvas.setActorFacingDirection(gameCanvas.gameActorStateReference01, 1);
                           }

                           gameCanvas.showGameMessage(0, 3, GameCanvas.getLocalizedText(177), 0);
                        }
                        break;
                     case 14:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.showGameMessage(0, 0, GameCanvas.getLocalizedText(178), 0);
                        }
                        break;
                     case 15:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        }
                        break;
                     case 16:
                        if (var4 > 500L) {
                           gameCanvas.gameIntegerValue66++;
                           if (gameCanvas.gameBooleanFlag49) {
                              GameCanvas.setActorFacingDirection(gameCanvas.gameActorStateReference01, 1);
                           } else {
                              GameCanvas.setActorFacingDirection(gameCanvas.gameActorStateReference01, 5);
                           }

                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        }
                        break;
                     case 17:
                        if (var4 > 1000L) {
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.showGameMessage(0, 3, GameCanvas.getLocalizedText(179), 0);
                        }
                        break;
                     case 18:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.showGameMessage(0, 3, GameCanvas.getLocalizedText(180), 0);
                        }
                        break;
                     case 19:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.showGameMessage(0, 3, GameCanvas.getLocalizedText(181), 0);
                        } goto case 20;
                     case 20:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.moveActorToTile(gameCanvas.gameActorStateReference01, 64, 18);
                        }
                        break;
                     case 21:
                        if (gameCanvas.gameActorStateReference01.byteValue02 == gameCanvas.gameActorGroupReference03.actorStateReference01.byteValue02) {
                           if (gameCanvas.gameBooleanFlag49) {
                              GameCanvas.setActorFacingDirection(gameCanvas.gameActorGroupReference03.actorStateReference01, 5);
                              gameCanvas.faceActorTowardPosition(gameCanvas.gameActorGroupReference03.actorStateReference01, 1);
                           } else {
                              GameCanvas.setActorFacingDirection(gameCanvas.gameActorGroupReference03.actorStateReference01, 1);
                              gameCanvas.faceActorTowardPosition(gameCanvas.gameActorGroupReference03.actorStateReference01, 1);
                           }
                        }

                        if (!GameCanvas.isActorDefeated(gameCanvas.gameActorStateReference01) && isActorAtPosition(gameCanvas.gameActorStateReference01, 64, 18)) {
                           gameCanvas.gameIntegerValue66++;
                           GameCanvas.setActorFacingDirection(gameCanvas.gameActorStateReference01, 3);
                           gameCanvas.faceActorTowardPosition(gameCanvas.gameActorStateReference01, 5);
                           gameCanvas.gameBooleanFlag36 = true;
                        }
                        break;
                     case 22:
                        if (!GameCanvas.isActorDefeated(gameCanvas.gameActorGroupReference03.actorStateReference01)) {
                           GameCanvas.setActorFacingDirection(gameCanvas.gameActorGroupReference03.actorStateReference01, 3);
                        }

                        if (gameCanvas.gameActorStateReference01.byteValue03 == 2) {
                           gameCanvas.deactivateActorRuntimeState(235);
                           gameCanvas.activateActorRuntimeState(234);
                        }

                        if (!GameCanvas.isActorDefeated(gameCanvas.gameActorStateReference01) && isActorAtPosition(gameCanvas.gameActorStateReference01, 64, 17)) {
                           gameCanvas.gameBooleanFlag36 = false;
                           gameCanvas.deactivateActorRuntimeState(234);
                           gameCanvas.activateActorRuntimeState(235);
                           gameCanvas.updateActorDisplayState(gameCanvas.gameActorGroupReference01.actorStateReference01, false);
                           gameCanvas.gameActorStateReference01.booleanFlag01 = false;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                           gameCanvas.gameIntegerValue66++;
                           GameCanvas.setActorFacingDirection(gameCanvas.gameActorGroupReference03.actorStateReference01, 3);
                           gameCanvas.faceActorTowardPosition(gameCanvas.gameActorGroupReference03.actorStateReference01, 1);
                        }
                        break;
                     case 23:
                        if (var4 > 1000L) {
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.showGameMessage(0, 0, GameCanvas.getLocalizedText(182), 0);
                        }
                        break;
                     case 24:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.gameByteValue18 = 2;
                           gameCanvas.gameByteValue19 = 1;
                           gameCanvas.gameClass19ReferenceArray01[165].booleanFlag02 = true;
                           GameCanvas.setGamePaused(true);
                        } break;
                  }

                  return 1;
               default:
                  return 0;
            } goto case 150;
         case 150:
            switch (GameCanvas.gameByteValue07) {
               case 0:
                  if (isActorAtPosition(gameCanvas.gameActorGroupReference02.actorStateReference01, 36, 8) && gameCanvas.gameActorGroupReference02.byteValue05 == 0) {
                     GameCanvas.setGamePaused(true);
                     return 1;
                  } else if (isActorAtPosition(gameCanvas.gameActorGroupReference02.actorStateReference01, 29, 13) && gameCanvas.gameActorGroupReference02.byteValue05 == gameCanvas.gameActorGroupReference01.byteValue05) {
                     GameCanvas.setGamePaused(true);
                     return 1;
                  } else if (gameCanvas.gameActorGroupReference02.actorStateReference01.byteValue12 == 36
                     && gameCanvas.gameActorGroupReference02.actorStateReference01.byteValue13 == 8
                     && gameCanvas.gameActorGroupReference02.byteValue05 == 0) {
                     GameCanvas.setGamePaused(true);
                     return 1;
                  } else if (isActorAtPosition(gameCanvas.gameActorGroupReference02.actorStateReference01, 29, 13) && gameCanvas.gameActorGroupReference02.byteValue05 == 0) {
                     GameCanvas.setGamePaused(true);
                     return 1;
                  } else if (gameCanvas.gameActorGroupReference02.actorStateReference01.byteValue12 == 29
                     && gameCanvas.gameActorGroupReference02.actorStateReference01.byteValue13 == 13
                     && gameCanvas.gameActorGroupReference02.byteValue05 == 0) {
                     GameCanvas.setGamePaused(true);
                     return 1;
                  } else {
                     if (gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue01 == 29 && gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue02 == 13) {
                        beginGameModeAction();
                        gameCanvas.gameIntegerValue66 = 1;
                     } else {
                        if (isActorAtPosition(gameCanvas.gameActorGroupReference02.actorStateReference01, 28, 13) && gameCanvas.gameActorGroupReference02.byteValue05 == 0) {
                           GameCanvas.setGamePaused(true);
                           return 1;
                        }

                        if (gameCanvas.gameActorGroupReference02.actorStateReference01.byteValue12 == 28
                           && gameCanvas.gameActorGroupReference02.actorStateReference01.byteValue13 == 13
                           && gameCanvas.gameActorGroupReference02.byteValue05 == 0) {
                           GameCanvas.setGamePaused(true);
                           return 1;
                        }

                        gameCanvas.moveActorToTile(gameCanvas.gameActorGroupReference01.actorStateReference01, 29, 13);
                        gameCanvas.gameIntegerValue66 = 0;
                     }

                     GameCanvas.setGamePaused(false);
                     return 1;
                  } goto case 1;
               case 1:
                  switch (gameCanvas.gameIntegerValue66) {
                     case 0:
                        if (!GameCanvas.isActorDefeated(gameCanvas.gameActorGroupReference01.actorStateReference01) && isActorAtPosition(gameCanvas.gameActorGroupReference01.actorStateReference01, 29, 13)) {
                           beginGameModeAction();
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 1:
                        if (advanceGameModeAction()) {
                           setActorPosition(gameCanvas.gameActorGroupReference01.actorStateReference01, 36, 9);
                           gameCanvas.gameActorGroupReference01.actorStateReference01.booleanFlag01 = true;
                           gameCanvas.updateActorGroups();
                           gameCanvas.setCameraPosition(
                              gameCanvas.getTilePixelX(gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue01, gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue02) - GameCanvas.gameIntegerValue43 / 2,
                              GameCanvas.getTilePixelY(gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue01, gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue02) - GameCanvas.gameIntegerValue44 / 2
                           );
                           gameCanvas.updateActorDisplayState(gameCanvas.gameActorGroupReference01.actorStateReference01, false);
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                           gameCanvas.gameIntegerValue66 = 9;
                           gameCanvas.faceActorTowardPosition(gameCanvas.gameActorGroupReference01.actorStateReference01, 1);
                        }
                        break;
                     case 9:
                        if (var4 > 1000L) {
                           GameCanvas.setGamePaused(true);
                        } break;
                  }

                  return 1;
               default:
                  return 0;
            } goto case 160;
         case 160:
            switch (GameCanvas.gameByteValue07) {
               case 0:
                  if (isActorAtPosition(gameCanvas.gameActorGroupReference02.actorStateReference01, 29, 13) && gameCanvas.gameActorGroupReference02.byteValue05 == 0) {
                     GameCanvas.setGamePaused(true);
                     return 1;
                  } else if (isActorAtPosition(gameCanvas.gameActorGroupReference02.actorStateReference01, 36, 8) && gameCanvas.gameActorGroupReference02.byteValue05 == gameCanvas.gameActorGroupReference01.byteValue05) {
                     GameCanvas.setGamePaused(true);
                     return 1;
                  } else if (gameCanvas.gameActorGroupReference02.actorStateReference01.byteValue12 == 29
                     && gameCanvas.gameActorGroupReference02.actorStateReference01.byteValue13 == 13
                     && gameCanvas.gameActorGroupReference02.byteValue05 == 0) {
                     GameCanvas.setGamePaused(true);
                     return 1;
                  } else {
                     if (gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue01 == 36 && gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue02 == 8) {
                        beginGameModeFinishAction();
                        gameCanvas.gameIntegerValue66 = 1;
                     } else {
                        gameCanvas.advanceGameplaySimulation();
                        gameCanvas.findPathToTile(gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue01, gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue02, 36, 8);
                        if (gameCanvas.gameClass14Reference01 == null) {
                           GameCanvas.setGamePaused(true);
                           return 1;
                        }

                        gameCanvas.moveActorToTile(gameCanvas.gameActorGroupReference01.actorStateReference01, 36, 8);
                        gameCanvas.gameIntegerValue66 = 0;
                     }

                     GameCanvas.setGamePaused(false);
                     return 1;
                  } goto case 1;
               case 1:
                  switch (gameCanvas.gameIntegerValue66) {
                     case 0:
                        if (!GameCanvas.isActorDefeated(gameCanvas.gameActorGroupReference01.actorStateReference01)
                           && (gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue01 != 36 || gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue02 != 8)) {
                           gameCanvas.advanceGameplaySimulation();
                           gameCanvas.findPathToTile(gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue01, gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue02, 36, 8);
                           if (gameCanvas.gameClass14Reference01 == null) {
                              gameCanvas.faceActorTowardPosition(gameCanvas.gameActorGroupReference01.actorStateReference01, 0);
                              GameCanvas.setGamePaused(true);
                              return 1;
                           }

                           gameCanvas.moveActorToTile(gameCanvas.gameActorGroupReference01.actorStateReference01, 36, 8);
                        }

                        if (!GameCanvas.isActorDefeated(gameCanvas.gameActorGroupReference01.actorStateReference01) && isActorAtPosition(gameCanvas.gameActorGroupReference01.actorStateReference01, 36, 8)) {
                           beginGameModeFinishAction();
                           gameCanvas.gameIntegerValue66 = 1;
                        }
                        break;
                     case 1:
                        if (advanceGameModeFinishAction()) {
                           setActorPosition(gameCanvas.gameActorGroupReference01.actorStateReference01, 29, 12);
                           gameCanvas.gameActorGroupReference01.actorStateReference01.booleanFlag01 = true;
                           gameCanvas.updateActorGroups();
                           gameCanvas.setCameraPosition(
                              gameCanvas.getTilePixelX(gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue01, gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue02) - GameCanvas.gameIntegerValue43 / 2,
                              GameCanvas.getTilePixelY(gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue01, gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue02) - GameCanvas.gameIntegerValue44 / 2
                           );
                           gameCanvas.updateActorDisplayState(gameCanvas.gameActorGroupReference01.actorStateReference01, false);
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                           gameCanvas.gameIntegerValue66 = 5;
                           gameCanvas.faceActorTowardPosition(gameCanvas.gameActorGroupReference01.actorStateReference01, 1);
                        }
                        break;
                     case 5:
                        if (var4 > 1000L) {
                           GameCanvas.setGamePaused(true);
                        } break;
                  }

                  return 1;
               default:
                  return 0;
            } goto case 170;
         case 170:
            switch (GameCanvas.gameByteValue07) {
               case 0:
                  if (gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue08 == 0) {
                     if (!gameCanvas.gameActorGroupReference03.entitySnapshotReferenceArray01[17].booleanFlag01) {
                        gameCanvas.showGameMessage(0, 0, GameCanvas.getLocalizedText(79), 0);
                     } else {
                        gameCanvas.showGameMessage(0, 0, GameCanvas.getLocalizedText(80), 0);
                     }
                  } else if (gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue08 == 1) {
                     if (!gameCanvas.gameActorGroupReference04.entitySnapshotReferenceArray01[17].booleanFlag01) {
                        gameCanvas.showGameMessage(0, 1, GameCanvas.getLocalizedText(81), 0);
                     } else if (!gameCanvas.gameActorGroupReference04.entitySnapshotReferenceArray01[16].booleanFlag01) {
                        gameCanvas.showGameMessage(0, 1, GameCanvas.getLocalizedText(83), 0);
                     } else {
                        GameCanvas.gameBooleanFlag59 = false;
                        gameCanvas.showGameMessage(0, 1, GameCanvas.getLocalizedText(82), 0);
                     }
                  }

                  GameCanvas.setGamePaused(false);
                  return 1;
               case 1:
                  if (GameCanvas.gameIntegerValue50 != 131) {
                     if (gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue08 != 0) {
                        if (gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue08 != 1) {
                           return 1;
                        }

                        if (gameCanvas.gameActorGroupReference04.entitySnapshotReferenceArray01[17].booleanFlag01 && gameCanvas.gameActorGroupReference04.entitySnapshotReferenceArray01[16].booleanFlag01) {
                           GameCanvas.setGamePaused(false);
                           return 1;
                        }
                     }

                     GameCanvas.setGamePaused(true);
                  }

                  return 1;
               default:
                  return 0;
            } goto case 171;
         case 171:
            switch (GameCanvas.gameByteValue07) {
               case 0:
                  gameCanvas.gameActorGroupReference04.entitySnapshotReferenceArray01[16].booleanFlag01 = false;
                  gameCanvas.gameActorGroupReference04.entitySnapshotReferenceArray01[17].booleanFlag01 = false;
                  gameCanvas.gameActorGroupReference04.byteValue03 = (sbyte)(gameCanvas.gameActorGroupReference04.byteValue03 - 2);
                  gameCanvas.gameActorGroupReference04.byteValue02 = 0;
                  if (gameCanvas.gameActorGroupReference03.actorStateReference01.byteValue01 > 44
                     && gameCanvas.gameActorGroupReference03.actorStateReference01.byteValue01 < 58
                     && gameCanvas.gameActorGroupReference03.actorStateReference01.byteValue02 > 22
                     && gameCanvas.gameActorGroupReference03.actorStateReference01.byteValue02 < 27
                     && gameCanvas.gameActorGroupReference03.byteValue05 == 0) {
                     gameCanvas.gameIntegerValue66 = 0;
                     gameCanvas.gameActorGroupReference03.booleanFlag04 = true;
                     gameCanvas.moveActorToTile(gameCanvas.gameActorGroupReference03.actorStateReference01, 42, 25);
                  } else {
                     gameCanvas.gameIntegerValue66 = 1;
                     gameCanvas.gameActorGroupReference04.booleanFlag04 = true;
                     if (isActorAtPosition(gameCanvas.gameActorGroupReference03.actorStateReference01, 44, 24)) {
                        gameCanvas.moveActorToTile(gameCanvas.gameActorGroupReference04.actorStateReference01, 44, 25);
                     } else {
                        gameCanvas.moveActorToTile(gameCanvas.gameActorGroupReference04.actorStateReference01, 44, 24);
                     }

                     gameCanvas.updateActorDisplayState(gameCanvas.gameActorGroupReference04.actorStateReference01, true);
                  }

                  GameCanvas.setGamePaused(false);
                  return 1;
               case 1:
                  switch (gameCanvas.gameIntegerValue66) {
                     case 0:
                        if (gameCanvas.gameActorGroupReference03.actorStateReference01.byteValue01 < 50) {
                           gameCanvas.gameActorGroupReference04.booleanFlag04 = true;
                           if (isActorAtPosition(gameCanvas.gameActorGroupReference03.actorStateReference01, 44, 24)) {
                              gameCanvas.moveActorToTile(gameCanvas.gameActorGroupReference04.actorStateReference01, 44, 25);
                           } else {
                              gameCanvas.moveActorToTile(gameCanvas.gameActorGroupReference04.actorStateReference01, 44, 24);
                           }

                           gameCanvas.updateActorDisplayState(gameCanvas.gameActorGroupReference04.actorStateReference01, true);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 1:
                        if (gameCanvas.gameActorGroupReference03.booleanFlag04
                           && !GameCanvas.isActorDefeated(gameCanvas.gameActorGroupReference03.actorStateReference01)
                           && isActorAtPosition(gameCanvas.gameActorGroupReference03.actorStateReference01, 42, 25)) {
                           gameCanvas.gameActorGroupReference03.booleanFlag04 = false;
                           gameCanvas.faceActorTowardPosition(gameCanvas.gameActorGroupReference03.actorStateReference01, 0);
                           GameCanvas.setActorFacingDirection(gameCanvas.gameActorGroupReference03.actorStateReference01, 1);
                        }

                        if (gameCanvas.gameActorGroupReference04.actorStateReference01.byteValue01 < 48) {
                           gameCanvas.gameActorGroupReference04.booleanFlag04 = false;
                           gameCanvas.gameActorGroupReference04.actorStateReference01.byteValue12 = -1;
                           gameCanvas.gameActorGroupReference04.actorStateReference01.byteValue13 = -1;
                           gameCanvas.faceActorTowardPosition(gameCanvas.gameActorGroupReference04.actorStateReference01, 0);
                           GameCanvas.setActorFacingDirection(gameCanvas.gameActorGroupReference04.actorStateReference01, 1);
                           gameCanvas.gameActorGroupReference03.booleanFlag04 = false;
                           GameCanvas.setGamePaused(false);
                        } break;
                  }

                  return 1;
               default:
                  return 1;
            } goto case 172;
         case 172:
            switch (GameCanvas.gameByteValue07) {
               case 0:
                  gameCanvas.gameIntegerValue66 = 0;
                  GameCanvas.setGamePaused(false);
                  return 1;
               case 1:
                  gameCanvas.setCameraPosition(gameCanvas.getTilePixelX(50, 23) - GameCanvas.gameIntegerValue43 / 2, GameCanvas.getTilePixelY(50, 24) - GameCanvas.gameIntegerValue44 / 2);
                  if (gameCanvas.gameIntegerValue66 > 3 && gameCanvas.gameIntegerValue66 < 10 && gameCanvas.nextRandomByte() % 10 < 6) {
                     var1 = gameCanvas.nextRandomByte() % 5 - 2;
                     var2 = gameCanvas.nextRandomByte() % 5 - 2;
                     gameCanvas.findEntityFrameData(4, var1 + 54, var2 + 24, 54, 0);
                  }

                  switch (gameCanvas.gameIntegerValue66) {
                     case 0:
                        gameCanvas.gameIntegerValue66++;
                        break;
                     case 1:
                        gameCanvas.gameIntegerValue83 = 7000;
                        gameCanvas.gameIntegerValue66++;
                        break;
                     case 2:
                        gameCanvas.gameIntegerValue90 = 20;
                        gameCanvas.deactivateActorRuntimeState(538);
                        gameCanvas.gameIntegerValue66++;
                        gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        break;
                     case 3:
                        if (var4 > 3000L) {
                           gameCanvas.processActorAction(13);
                           gameCanvas.gameIntegerValue90 = 21;
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        }
                        break;
                     case 4:
                        if (var4 > 100L) {
                           gameCanvas.gameIntegerValue90 = 22;
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        }
                        break;
                     case 5:
                        if (var4 > 100L) {
                           gameCanvas.gameIntegerValue90 = 23;
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        }
                        break;
                     case 6:
                        if (var4 > 100L) {
                           gameCanvas.gameIntegerValue90 = 24;
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        }
                        break;
                     case 7:
                        if (var4 > 100L) {
                           gameCanvas.gameIntegerValue90 = 25;
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        }
                        break;
                     case 8:
                        if (var4 > 500L) {
                           gameCanvas.gameIntegerValue90 = 0;
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        }
                        break;
                     case 9:
                        if (var4 > 1000L) {
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 10:
                        if (gameCanvas.gameIntegerValue83 <= 0) {
                           gameCanvas.deactivateActorRuntimeState(538);
                           GameCanvas.setGamePaused(true);
                           GameCanvas.gameBooleanFlag59 = true;
                        } break;
                  }

                  return 1;
            } goto case 220;
         case 220:
         case 230:
         case 240:
            switch (GameCanvas.gameByteValue07) {
               case 0:
                  if (gameCanvas.gameByteArray05[0] == -2) {
                     GameCanvas.setGamePaused(true);
                     return 1;
                  }

                  sbyte var9 = 0;
                  if (GameCanvas.gameShortValue01 == 220) {
                     var9 = 0;
                     var1 = 501;
                  } else if (GameCanvas.gameShortValue01 == 230) {
                     var9 = 1;
                     var1 = 505;
                  } else if (GameCanvas.gameShortValue01 == 240) {
                     var9 = 2;
                     var1 = 502;
                  }

                  if (gameCanvas.gameByteArray05[var9] == -1) {
                     gameCanvas.showGameMessage(0, 2, GameCanvas.getLocalizedText(159), 0);
                  } else {
                     gameCanvas.disableActorActionFlag(var1, 0);
                     gameCanvas.disableActorActionFlag(var1, 1);
                     gameCanvas.disableActorActionFlag(var1, 2);
                     gameCanvas.setActiveActorGroup(gameCanvas.gameByteArray05[var9]);
                     gameCanvas.gameByteArray05[var9] = -1;
                     if (gameCanvas.gameByteArray05[0] != 23) {
                        ActorRuntimeState var10;
                        (var10 = gameCanvas.gameClass9ReferenceArray01[508]).byteValue02 = 2;
                        var10.byteValue03 = 22;
                        var10.shortValue01 = (short)gameCanvas.getTilePixelX(var10.byteValue02, var10.byteValue03);
                        var10.shortValue02 = (short)GameCanvas.getTilePixelY(var10.byteValue02, var10.byteValue03);
                        gameCanvas.updateEnemyActorState();
                     }

                     if (gameCanvas.gameByteArray05[1] != 24) {
                        ActorRuntimeState var11;
                        (var11 = gameCanvas.gameClass9ReferenceArray01[507]).byteValue02 = 2;
                        var11.byteValue03 = 21;
                        var11.shortValue01 = (short)gameCanvas.getTilePixelX(var11.byteValue02, var11.byteValue03);
                        var11.shortValue02 = (short)GameCanvas.getTilePixelY(var11.byteValue02, var11.byteValue03);
                        gameCanvas.updateEnemyActorState();
                     }
                  }

                  GameCanvas.setGamePaused(false);
                  return 2;
               case 1:
                  if (GameCanvas.gameIntegerValue50 != 131) {
                     GameCanvas.setGamePaused(true);
                  }

                  return 1;
               default:
                  return 0;
            } goto case 180;
         case 180:
            switch (GameCanvas.gameByteValue07) {
               case 0:
                  gameCanvas.gameIntegerValue66 = 1;
                  if (gameCanvas.gameActorGroupReference04.byteValue05 == 0
                     && gameCanvas.getActorStateValue(gameCanvas.gameActorGroupReference04.actorStateReference01) == gameCanvas.gameByteValue05
                     && gameCanvas.gameActorGroupReference04.actorStateReference01.byteValue01 >= 44
                     && gameCanvas.gameActorGroupReference04.actorStateReference01.byteValue02 <= 26) {
                     gameCanvas.showGameMessage(0, 1, GameCanvas.getLocalizedText(141), 0);
                     gameCanvas.gameIntegerValue66 = 0;
                  }

                  GameCanvas.setGamePaused(false);
                  return 1;
               case 1:
                  switch (gameCanvas.gameIntegerValue66) {
                     case 0:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.gameActorGroupReference04.booleanFlag04 = true;
                           gameCanvas.moveActorToTile(gameCanvas.gameActorGroupReference04.actorStateReference01, 29, 29);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 1:
                        gameCanvas.deactivateActorRuntimeState(164);
                        gameCanvas.deactivateActorRuntimeState(163);
                        gameCanvas.gameActorStateReference01 = gameCanvas.createActorState(3, 60, 25, 5);
                        gameCanvas.gameIntegerValue66++;
                        break;
                     case 2:
                        if (gameCanvas.gameActorGroupReference04.byteValue05 != 0
                           || gameCanvas.getActorStateValue(gameCanvas.gameActorGroupReference04.actorStateReference01) != gameCanvas.gameByteValue05
                           || !gameCanvas.gameActorGroupReference04.booleanFlag04) {
                           gameCanvas.gameIntegerValue66++;
                        } else if (gameCanvas.gameActorGroupReference04.actorStateReference01.byteValue01 < 47) {
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 3:
                        if (gameCanvas.gameActorGroupReference03.actorStateReference01.byteValue02 == 24) {
                           gameCanvas.moveActorToTile(gameCanvas.gameActorStateReference01, 57, 25);
                        } else {
                           gameCanvas.moveActorToTile(gameCanvas.gameActorStateReference01, 57, 24);
                        }

                        GameCanvas.setGamePaused(false); break;
                  } goto default;
               default:
                  return 1;
            } goto case 181;
         case 181:
            switch (GameCanvas.gameByteValue07) {
               case 0:
                  gameCanvas.gameIntegerValue66 = 0;
                  gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                  GameCanvas.setGamePaused(false);
                  return 1;
               case 1:
                  switch (gameCanvas.gameIntegerValue66) {
                     case 0:
                        if (!GameCanvas.isActorDefeated(gameCanvas.gameActorStateReference01) && gameCanvas.gameActorStateReference01.byteValue12 == -1 && gameCanvas.gameActorStateReference01.byteValue13 == -1) {
                           if (gameCanvas.gameActorStateReference01.byteValue02 == 24) {
                              GameCanvas.setActorFacingDirection(gameCanvas.gameActorGroupReference03.actorStateReference01, 3);
                           } else {
                              GameCanvas.setActorFacingDirection(gameCanvas.gameActorGroupReference03.actorStateReference01, 7);
                           }

                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 1:
                        if (var4 > 1000L) {
                           if (gameCanvas.gameActorStateReference01.byteValue02 == 24) {
                              GameCanvas.setActorFacingDirection(gameCanvas.gameActorStateReference01, 3);
                           } else {
                              GameCanvas.setActorFacingDirection(gameCanvas.gameActorStateReference01, 7);
                           }

                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        }
                        break;
                     case 2:
                        if (var4 > 1000L) {
                           if (gameCanvas.gameActorStateReference01.byteValue02 == 24) {
                              GameCanvas.setActorFacingDirection(gameCanvas.gameActorStateReference01, 7);
                           } else {
                              GameCanvas.setActorFacingDirection(gameCanvas.gameActorStateReference01, 3);
                           }

                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        }
                        break;
                     case 3:
                        if (var4 > 2500L) {
                           GameCanvas.setActorFacingDirection(gameCanvas.gameActorStateReference01, 1);
                           gameCanvas.faceActorTowardPosition(gameCanvas.gameActorStateReference01, 1);
                           if (gameCanvas.hasActorStateChanged(gameCanvas.gameActorGroupReference04.actorStateReference01)) {
                              gameCanvas.gameActorGroupReference04.booleanFlag04 = false;
                              gameCanvas.faceActorTowardPosition(gameCanvas.gameActorGroupReference04.actorStateReference01, 0);
                           }

                           GameCanvas.setGamePaused(false);
                        } break;
                  }

                  return 1;
               default:
                  return 0;
            } goto case 182;
         case 182:
            switch (GameCanvas.gameByteValue07) {
               case 0:
                  gameCanvas.gameActorGroupReference04.booleanFlag04 = false;
                  gameCanvas.gameIntegerValue66 = 0;
                  GameCanvas.setGamePaused(false);
                  return 1;
               case 1:
                  switch (gameCanvas.gameIntegerValue66) {
                     case 0:
                        if (gameCanvas.gameActorStateReference01.byteValue03 > 3) {
                           gameCanvas.faceActorTowardPosition(gameCanvas.gameActorStateReference01, 0);
                           GameCanvas.setActorFacingDirection(gameCanvas.gameActorStateReference01, 1);
                           if (gameCanvas.gameActorGroupReference03.actorStateReference01.byteValue02 == 24) {
                              gameCanvas.gameActorStateReference01.byteValue02 = 25;
                           } else {
                              gameCanvas.gameActorStateReference01.byteValue02 = 24;
                           }

                           gameCanvas.gameActorStateReference01.byteValue01 = 57;
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 1:
                        gameCanvas.showGameMessage(0, 0, GameCanvas.getLocalizedText(142), 0);
                        gameCanvas.gameIntegerValue66++;
                        break;
                     case 2:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        }
                        break;
                     case 3:
                        if (var4 > 1000L) {
                           gameCanvas.showGameMessage(0, 3, GameCanvas.getLocalizedText(143), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 4:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        }
                        break;
                     case 5:
                        if (var4 > 1000L) {
                           gameCanvas.showGameMessage(0, 0, GameCanvas.getLocalizedText(144), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 6:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.showGameMessage(0, 6, GameCanvas.getLocalizedText(84), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 7:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.showGameMessage(0, 0, GameCanvas.getLocalizedText(145), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 8:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        }
                        break;
                     case 9:
                        if (var4 > 1000L) {
                           gameCanvas.showGameMessage(0, 1, GameCanvas.getLocalizedText(146), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 10:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           if (gameCanvas.gameActorGroupReference03.actorStateReference01.byteValue02 == 24) {
                              GameCanvas.setActorFacingDirection(gameCanvas.gameActorStateReference01, 3);
                           } else {
                              GameCanvas.setActorFacingDirection(gameCanvas.gameActorStateReference01, 7);
                           }

                           gameCanvas.showGameMessage(0, 0, GameCanvas.getLocalizedText(147), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 11:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.showGameMessage(0, 3, GameCanvas.getLocalizedText(148), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 12:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.showGameMessage(0, 0, GameCanvas.getLocalizedText(149), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 13:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.showGameMessage(0, 3, GameCanvas.getLocalizedText(150), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 14:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.showGameMessage(0, 0, GameCanvas.getLocalizedText(151), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 15:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.showGameMessage(0, 3, GameCanvas.getLocalizedText(152), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 16:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.showGameMessage(0, 0, GameCanvas.getLocalizedText(153), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 17:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.showGameMessage(0, 3, GameCanvas.getLocalizedText(154), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 18:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        }
                        break;
                     case 19:
                        if (var4 > 1000L) {
                           gameCanvas.processActorAction(36);
                           gameCanvas.showGameMessage(0, 6, GameCanvas.getLocalizedText(155), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 20:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        }
                        break;
                     case 21:
                        if (var4 > 1000L) {
                           GameCanvas.setActorFacingDirection(gameCanvas.gameActorGroupReference03.actorStateReference01, 5);
                           gameCanvas.showGameMessage(0, 0, GameCanvas.getLocalizedText(156), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 22:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           GameCanvas.setActorFacingDirection(gameCanvas.gameActorStateReference01, 1);
                           gameCanvas.showGameMessage(0, 3, GameCanvas.getLocalizedText(157), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 23:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.showGameMessage(0, 0, GameCanvas.getLocalizedText(158), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 24:
                        gameCanvas.moveActorToTile(gameCanvas.gameActorStateReference01, 60, 25);
                        gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        gameCanvas.gameIntegerValue66++;
                        break;
                     case 25:
                        GameCanvas.setActorFacingDirection(gameCanvas.gameActorGroupReference03.actorStateReference01, 1);
                        if (var4 > 2000L) {
                           setActorPosition(gameCanvas.gameActorStateReference01, 3, 3);
                           gameCanvas.gameActorStateReference01.byteValue12 = -1;
                           gameCanvas.gameActorStateReference01.byteValue13 = -1;
                           gameCanvas.gameActorStateReference01.booleanFlag01 = false;
                           gameCanvas.faceActorTowardPosition(gameCanvas.gameActorGroupReference03.actorStateReference01, 1);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 26:
                        if (gameCanvas.gameActorGroupReference03.actorStateReference01.byteValue01 > 57) {
                           GameCanvas.setGamePaused(true);
                        } break;
                  }

                  return 1;
               default:
                  return 1;
            } goto case 190;
         case 190:
            switch (GameCanvas.gameByteValue07) {
               case 0:
                  gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                  gameCanvas.gameIntegerValue66 = 0;
                  GameCanvas.setGamePaused(false);
                  return 1;
               case 1:
                  switch (gameCanvas.gameIntegerValue66) {
                     case 0:
                        if (var4 > 600L) {
                           gameCanvas.gameBooleanFlag38 = false;
                           GameCanvas.setGamePaused(false);
                        } goto default;
                     default:
                        return 1;
                  } goto default;
               default:
                  return 0;
            } goto case 191;
         case 191:
            switch (GameCanvas.gameByteValue07) {
               case 0:
                  if (gameCanvas.gameBooleanFlag40 && gameCanvas.gameBooleanFlag41) {
                     gameCanvas.deactivateActorRuntimeState(214);
                     gameCanvas.activateActorRuntimeState(215);
                     gameCanvas.activateActorRuntimeState(542);
                     gameCanvas.activateActorRuntimeState(541);
                     gameCanvas.gameIntegerValue66 = 0;
                  } else {
                     gameCanvas.gameIntegerValue66 = 4;
                     gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                  }

                  GameCanvas.setGamePaused(false);
                  return 1;
               case 1:
                  switch (gameCanvas.gameIntegerValue66) {
                     case 0:
                        setActorPosition(gameCanvas.gameActorGroupReference01.actorStateReference01, gameCanvas.gameClass9ReferenceArray01[542].byteValue02, (sbyte)(gameCanvas.gameClass9ReferenceArray01[542].byteValue03 + 1));
                        gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        gameCanvas.gameIntegerValue66++;
                        break;
                     case 1:
                        if (var4 > 4000L) {
                           setActorPosition(gameCanvas.gameActorGroupReference01.actorStateReference01, 58, 26);
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 2:
                        if (var4 > 2000L) {
                           gameCanvas.faceActorTowardPosition(gameCanvas.gameActorGroupReference01.actorStateReference01, 0);
                           GameCanvas.setActorFacingDirection(gameCanvas.gameActorGroupReference01.actorStateReference01, 3);
                           GameCanvas.setGamePaused(false);
                        } goto case 3;
                     case 3:
                     default:
                        break;
                     case 4:
                        if (var4 > 1500L) {
                           if (gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue08 == 0) {
                              gameCanvas.showGameMessage(0, 0, GameCanvas.getLocalizedText(166), 0);
                           } else {
                              gameCanvas.showGameMessage(0, 1, GameCanvas.getLocalizedText(167), 0);
                           }

                           GameCanvas.setActorFacingDirection(gameCanvas.gameActorGroupReference01.actorStateReference01, 5);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 5:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           GameCanvas.setGamePaused(false);
                        } break;
                  }

                  return 1;
               default:
                  return 0;
            } goto case 192;
         case 192:
            switch (GameCanvas.gameByteValue07) {
               case 0:
                  if (gameCanvas.gameBooleanFlag40 && gameCanvas.gameBooleanFlag41) {
                     gameCanvas.deactivateActorRuntimeState(215);
                     gameCanvas.deactivateActorRuntimeState(542);
                     gameCanvas.deactivateActorRuntimeState(541);
                     gameCanvas.activateActorRuntimeState(214);
                     gameCanvas.deactivateActorRuntimeState(212);
                     gameCanvas.activateActorRuntimeState(213);
                  }

                  gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                  gameCanvas.gameIntegerValue66 = 0;
                  GameCanvas.setGamePaused(false);
                  return 1;
               case 1:
                  if (var4 > (long)AnimationTables.integerArray01[gameCanvas.gameIntegerValue66]) {
                     gameCanvas.gameBooleanFlag38 = !gameCanvas.gameBooleanFlag38;
                     gameCanvas.gameIntegerValue66++;
                     if (gameCanvas.gameIntegerValue66 > 8) {
                        GameCanvas.setGamePaused(true);
                        GameCanvas.gameBooleanFlag59 = true;
                     }
                  }

                  return 1;
               default:
                  return 0;
            } goto case 200;
         case 200:
            switch (GameCanvas.gameByteValue07) {
               case 0:
                  gameCanvas.processActorAction(17);
                  gameCanvas.gameBooleanFlag40 = true;
                  gameCanvas.gameActorGroupReference01.entitySnapshotReferenceArray01[26].booleanFlag01 = false;
                  gameCanvas.gameActorGroupReference01.byteValue03--;
                  gameCanvas.gameActorGroupReference01.byteValue02 = 0;
                  gameCanvas.showGameMessage(0, 2, GameCanvas.getLocalizedText(161), 0);
                  GameCanvas.setGamePaused(false);
                  return 1;
               case 1:
                  if (GameCanvas.gameIntegerValue50 != 131) {
                     GameCanvas.setGamePaused(true);
                  }

                  return 1;
               default:
                  return 1;
            } goto case 210;
         case 210:
            switch (GameCanvas.gameByteValue07) {
               case 0:
                  gameCanvas.processActorAction(17);
                  gameCanvas.gameBooleanFlag41 = true;
                  gameCanvas.gameActorGroupReference01.entitySnapshotReferenceArray01[27].booleanFlag01 = false;
                  gameCanvas.gameActorGroupReference01.byteValue03--;
                  gameCanvas.gameActorGroupReference01.byteValue02 = 0;
                  gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                  gameCanvas.showGameMessage(0, 2, GameCanvas.getLocalizedText(162), 0);
                  GameCanvas.setGamePaused(false);
                  return 1;
               case 1:
                  if (GameCanvas.gameIntegerValue50 != 131) {
                     GameCanvas.setGamePaused(true);
                  }

                  return 1;
               default:
                  return 1;
            } goto case 250;
         case 250:
         case 260:
         case 270:
         case 280:
         case 290:
         case 300:
         case 310:
         case 320:
         case 330:
            sbyte var6 = 0;
            if (GameCanvas.gameShortValue01 == 310 || GameCanvas.gameShortValue01 == 280 || GameCanvas.gameShortValue01 == 250) {
               var6 = 0;
               var1 = 501;
            } else if (GameCanvas.gameShortValue01 == 320 || GameCanvas.gameShortValue01 == 290 || GameCanvas.gameShortValue01 == 260) {
               var6 = 1;
               var1 = 505;
            } else if (GameCanvas.gameShortValue01 == 330 || GameCanvas.gameShortValue01 == 300 || GameCanvas.gameShortValue01 == 270) {
               var6 = 2;
               var1 = 502;
            }

            if (gameCanvas.gameByteArray05[var6] != -1) {
               GameCanvas.setGamePaused(true);
               return 2;
            }

            if (GameCanvas.gameShortValue01 == 310 || GameCanvas.gameShortValue01 == 320 || GameCanvas.gameShortValue01 == 330) {
               gameCanvas.gameByteArray05[var6] = 25;
               var2 = 2;
            } else if (GameCanvas.gameShortValue01 == 280 || GameCanvas.gameShortValue01 == 290 || GameCanvas.gameShortValue01 == 300) {
               gameCanvas.gameByteArray05[var6] = 24;
               var2 = 1;
            } else if (GameCanvas.gameShortValue01 == 250 || GameCanvas.gameShortValue01 == 260 || GameCanvas.gameShortValue01 == 270) {
               gameCanvas.gameByteArray05[var6] = 23;
               var2 = 0;
            }

            gameCanvas.setActiveActorGroupDirection(gameCanvas.gameByteArray05[var6]);
            gameCanvas.enableActorActionFlag(var1, var2);
            if (gameCanvas.gameByteArray05[0] == 23) {
               ActorRuntimeState var7;
               (var7 = gameCanvas.gameClass9ReferenceArray01[508]).byteValue02 = 2;
               var7.byteValue03 = 23;
               var7.shortValue01 = (short)gameCanvas.getTilePixelX(var7.byteValue02, var7.byteValue03);
               var7.shortValue02 = (short)GameCanvas.getTilePixelY(var7.byteValue02, var7.byteValue03);
               gameCanvas.updateEnemyActorState();
            }

            if (gameCanvas.gameByteArray05[1] == 24) {
               ActorRuntimeState var8;
               (var8 = gameCanvas.gameClass9ReferenceArray01[507]).byteValue02 = 2;
               var8.byteValue03 = 20;
               var8.shortValue01 = (short)gameCanvas.getTilePixelX(var8.byteValue02, var8.byteValue03);
               var8.shortValue02 = (short)GameCanvas.getTilePixelY(var8.byteValue02, var8.byteValue03);
               gameCanvas.updateEnemyActorState();
            }

            if (gameCanvas.gameByteArray05[2] == 25 && gameCanvas.gameByteArray05[0] == 23 && gameCanvas.gameByteArray05[1] == 24) {
               gameCanvas.gameClass9ReferenceArray01[506].booleanFlag02 = false;
               gameCanvas.gameClass9ReferenceArray01[531].booleanFlag02 = true;
               gameCanvas.gameByteArray05[0] = -2;
               gameCanvas.gameByteArray05[1] = -2;
               gameCanvas.gameByteArray05[2] = -2;
               gameCanvas.updateEnemyActorState();
               gameCanvas.processActorAction(12);
               gameCanvas.showGameMessage(0, 2, GameCanvas.getLocalizedText(901), 0);
            }

            GameCanvas.setGamePaused(true);
            return 1;
         case 340:
            switch (GameCanvas.gameByteValue07) {
               case 0:
                  gameCanvas.setActorAnimationState(GameCanvas.getLocalizedText(86), (short)0, (sbyte)4);
                  GameCanvas.setGamePaused(false);
                  return 1;
               case 1:
                  if (GameCanvas.gameIntegerValue50 != 137) {
                     if (gameCanvas.gameStringBufferReference01.charAt(0) == '2'
                        && gameCanvas.gameStringBufferReference01.charAt(1) == '2'
                        && gameCanvas.gameStringBufferReference01.charAt(2) == '3'
                        && gameCanvas.gameStringBufferReference01.charAt(3) == '6') {
                        gameCanvas.deactivateActorRuntimeState(531);
                        gameCanvas.activateActorRuntimeState(530);
                        gameCanvas.processActorAction(12);
                     } else {
                        gameCanvas.showGameMessage(0, 2, GameCanvas.getLocalizedText(89), 0);
                     }

                     GameCanvas.setGamePaused(true);
                  }

                  return 1;
               default:
                  return 0;
            } goto case 350;
         case 350:
            GameCanvas.setGamePaused(true);
            return 1;
         case 360:
            switch (GameCanvas.gameByteValue07) {
               case 0:
                  gameCanvas.setActorDirection(GameCanvas.getLocalizedText(29), (short)0);
                  GameCanvas.setGamePaused(false);
                  return 1;
               case 1:
                  if (GameCanvas.gameIntegerValue50 != 139) {
                     if (gameCanvas.gameByteValue25 == 3 && !gameCanvas.gameBooleanFlag44) {
                        gameCanvas.gameBooleanFlag44 = true;
                        gameCanvas.setActiveActorGroupDirection((sbyte)33);
                        gameCanvas.setActiveActorGroup(28);
                        gameCanvas.gameClass19ReferenceArray01[119].booleanFlag02 = true;
                     } else {
                        gameCanvas.showGameMessage(0, 2, GameCanvas.getLocalizedText(30), 0);
                     }

                     GameCanvas.setGamePaused(true);
                  }

                  return 1;
               default:
                  return 0;
            } goto case 370;
         case 370:
            switch (GameCanvas.gameByteValue07) {
               case 0:
                  if (gameCanvas.gameActorGroupReference03.entitySnapshotReferenceArray01[19].booleanFlag01 && gameCanvas.gameActorGroupReference03.entitySnapshotReferenceArray01[20].booleanFlag01 && gameCanvas.gameActorGroupReference03.entitySnapshotReferenceArray01[21].booleanFlag01
                     )
                   {
                     gameCanvas.showGameMessage(0, 0, GameCanvas.getLocalizedText(160), 0);
                  } else {
                     if (!gameCanvas.gameActorGroupReference04.entitySnapshotReferenceArray01[19].booleanFlag01
                        || !gameCanvas.gameActorGroupReference04.entitySnapshotReferenceArray01[20].booleanFlag01
                        || !gameCanvas.gameActorGroupReference04.entitySnapshotReferenceArray01[21].booleanFlag01) {
                        GameCanvas.setGamePaused(true);
                        break;
                     }

                     gameCanvas.showGameMessage(0, 1, GameCanvas.getLocalizedText(160), 0);
                  }

                  GameCanvas.setGamePaused(false);
                  gameCanvas.gameIntegerValue66 = 0;
                  break;
               case 1:
                  if (GameCanvas.gameIntegerValue50 != 131) {
                     if (gameCanvas.gameIntegerValue66 == 0) {
                        gameCanvas.gameIntegerValue66++;
                        if (gameCanvas.gameActorGroupReference03.entitySnapshotReferenceArray01[19].booleanFlag01
                           && gameCanvas.gameActorGroupReference03.entitySnapshotReferenceArray01[20].booleanFlag01
                           && gameCanvas.gameActorGroupReference03.entitySnapshotReferenceArray01[21].booleanFlag01) {
                           gameCanvas.setActorGroupTargetPosition((sbyte)19, (sbyte)1);
                           gameCanvas.setActorGroupTargetPosition((sbyte)20, (sbyte)1);
                           gameCanvas.setActorGroupTargetPosition((sbyte)21, (sbyte)1);
                           gameCanvas.setActiveActorGroups(22, (sbyte)1);
                        } else if (gameCanvas.gameActorGroupReference04.entitySnapshotReferenceArray01[19].booleanFlag01
                           && gameCanvas.gameActorGroupReference04.entitySnapshotReferenceArray01[20].booleanFlag01
                           && gameCanvas.gameActorGroupReference04.entitySnapshotReferenceArray01[21].booleanFlag01) {
                           gameCanvas.setActorGroupTargetPosition((sbyte)19, (sbyte)2);
                           gameCanvas.setActorGroupTargetPosition((sbyte)20, (sbyte)2);
                           gameCanvas.setActorGroupTargetPosition((sbyte)21, (sbyte)2);
                           gameCanvas.setActiveActorGroups(22, (sbyte)2);
                        }
                     } else {
                        GameCanvas.setGamePaused(true);
                     }
                  } break;
            }

            return 1;
         case 380:
            switch (GameCanvas.gameByteValue07) {
               case 0:
                  gameCanvas.activateActorRuntimeState(545);
                  gameCanvas.gameIntegerValue83 = 2000;
                  gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                  GameCanvas.setGamePaused(false);
                  gameCanvas.processActorAction(35);
                  break;
               case 1:
                  if (var4 > 2000L) {
                     gameCanvas.initializeActorStates(true);
                     GameCanvas.setGamePaused(true);
                  } break;
            }

            return 1;
         case 390:
            switch (GameCanvas.gameByteValue07) {
               case 0:
                  GameCanvas.setGamePaused(false);
                  return 1;
               case 1:
                  gameCanvas.processLevelEntity(0, true);
                  if (gameCanvas.gameActorStateReference01 != null) {
                     gameCanvas.gameActorStateReference01.booleanFlag01 = false;
                  }

                  if (gameCanvas.gameActorStateReference03 != null) {
                     gameCanvas.gameActorStateReference03.booleanFlag01 = false;
                  }

                  if (gameCanvas.gameActorStateReference02 != null) {
                     gameCanvas.gameActorStateReference02.booleanFlag01 = false;
                  }

                  if (isActorAtPosition(gameCanvas.gameActorGroupReference02.actorStateReference01, 36, 18) && gameCanvas.gameActorGroupReference02.byteValue05 == 0) {
                     setActorPosition(gameCanvas.gameActorGroupReference02.actorStateReference01, 35, 18);
                     gameCanvas.faceActorTowardPosition(gameCanvas.gameActorGroupReference02.actorStateReference01, 0);
                     GameCanvas.setActorFacingDirection(gameCanvas.gameActorGroupReference02.actorStateReference01, 1);
                  } else if (gameCanvas.gameActorGroupReference02.actorStateReference01.byteValue12 == 36
                     && gameCanvas.gameActorGroupReference02.actorStateReference01.byteValue13 == 18
                     && gameCanvas.gameActorGroupReference02.byteValue05 == 0) {
                     setActorPosition(gameCanvas.gameActorGroupReference02.actorStateReference01, 35, 18);
                     gameCanvas.faceActorTowardPosition(gameCanvas.gameActorGroupReference02.actorStateReference01, 0);
                     GameCanvas.setActorFacingDirection(gameCanvas.gameActorGroupReference02.actorStateReference01, 1);
                  }

                  setActorPosition(gameCanvas.gameActorGroupReference01.actorStateReference01, 36, 18);
                  gameCanvas.updateActorGroups();
                  gameCanvas.setCameraPosition(gameCanvas.getTilePixelX(36, 18) - GameCanvas.gameIntegerValue43 / 2, GameCanvas.getTilePixelY(36, 18) - GameCanvas.gameIntegerValue44 / 2);
                  GameCanvas.setActorFacingDirection(gameCanvas.gameActorGroupReference01.actorStateReference01, 7);
                  gameCanvas.faceActorTowardPosition(gameCanvas.gameActorGroupReference01.actorStateReference01, 1);
                  GameCanvas.setGamePaused(true);
                  return 1;
               default:
                  return 0;
            } goto case 800;
         case 800:
            if (gameCanvas.gameByteMatrix02[gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue01][gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue02]
                  != gameCanvas.gameByteMatrix02[gameCanvas.gameClass9ReferenceArray01[543].byteValue02][gameCanvas.gameClass9ReferenceArray01[543].byteValue03]
               && gameCanvas.gameByteValue16 == 1) {
               gameCanvas.initializeActorStates(false);
            }

            gameCanvas.deactivateActorRuntimeState(545);
            GameCanvas.setGamePaused(true);
            gameCanvas.processActorAction(12);
            return 1;
         case 820:
            switch (GameCanvas.gameByteValue07) {
               case 0:
                  if (gameCanvas.gameBooleanFlag40 && gameCanvas.gameBooleanFlag41) {
                     gameCanvas.showGameMessage(0, 2, GameCanvas.getLocalizedText(165), 0);
                  } else if (!gameCanvas.gameBooleanFlag40 && !gameCanvas.gameBooleanFlag41) {
                     gameCanvas.showGameMessage(0, 2, GameCanvas.getLocalizedText(163), 0);
                  } else {
                     gameCanvas.showGameMessage(0, 2, GameCanvas.getLocalizedText(164), 0);
                  }

                  GameCanvas.setGamePaused(false); goto default;
               default:
                  return 1;
               case 1:
                  if (GameCanvas.gameIntegerValue50 != 131) {
                     GameCanvas.setGamePaused(true);
                  }

                  return 1;
            } goto default;
         default:
            return 0;
      }
   }
}
}
