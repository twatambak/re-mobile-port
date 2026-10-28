// Transpiled from Java (class_12.java) by Tools/J2meToCs. Regenerate rather than hand-edit where possible.
#pragma warning disable CS0162, CS0164, CS0168, CS0169, CS0219, CS0414, CS0649, CS1717, CS0108, CS0659, CS0661
using J2ME;

namespace REUprising.Gameloft
{
// $VF: renamed from: t
public class GameplaySequenceController {
   static GameplaySequenceController() { }

   // $VF: renamed from: a f
   public static GameCanvas gameCanvas;
   // $VF: renamed from: a short[]
   public short[] leftFacingAnimationFrames = new short[]{8, 292, 293, 12, 9, 10, 11};
   // $VF: renamed from: b short[]
   public short[] rightFacingAnimationFrames = new short[]{13, 14, 15, 16, 17, 18, 19};

   public GameplaySequenceController(GameCanvas var1) {
      gameCanvas = var1;
   }

   // $VF: renamed from: a () void
   public static void beginPlayerActionSequence() {
      GameCanvas.setActorFacingDirection(gameCanvas.gameActorGroupReference01.actorStateReference01, 3);
      gameCanvas.gameActorGroupReference01.booleanFlag04 = false;
      gameCanvas.gameBooleanFlag37 = true;
      gameCanvas.gameIntegerValue90 = 1;
      gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
   }

   // $VF: renamed from: a () boolean
   public static bool advancePlayerActionSequence() {
      if (gameCanvas.gameLongValue06 - gameCanvas.gameLongValue08 > 100L) {
         gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
         gameCanvas.gameIntegerValue90++;
         if (gameCanvas.gameIntegerValue90 >= 13) {
            gameCanvas.gameBooleanFlag37 = false;
            gameCanvas.gameIntegerValue90 = 0;
            return true;
         }
      }

      return false;
   }

   // $VF: renamed from: b () void
   public static void beginEnemyActionSequence() {
      GameCanvas.setActorFacingDirection(gameCanvas.gameActorGroupReference01.actorStateReference01, 7);
      gameCanvas.gameActorGroupReference01.booleanFlag04 = false;
      gameCanvas.gameBooleanFlag37 = true;
      gameCanvas.gameIntegerValue90 = 13;
      gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
   }

   // $VF: renamed from: b () boolean
   public static bool advanceEnemyActionSequence() {
      if (gameCanvas.gameLongValue06 - gameCanvas.gameLongValue08 > 100L) {
         gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
         gameCanvas.gameIntegerValue90++;
         if (gameCanvas.gameIntegerValue90 >= 20) {
            gameCanvas.gameBooleanFlag37 = false;
            gameCanvas.gameIntegerValue90 = 0;
            return true;
         }
      }

      return false;
   }

   // $VF: renamed from: a (int, int) void
   public void updateBossHealthBar(int var1, int var2) {
      gameCanvas.setActorAttribute(291, 30, var2);

      for (int var3 = 1; var3 < 8; var3++) {
         gameCanvas.setActorAttribute(this.leftFacingAnimationFrames[var3 - 1], 33, var2 - var3);
         if (var2 - var3 < 11) {
            gameCanvas.deactivateActorRuntimeState(this.leftFacingAnimationFrames[var3 - 1]);
         }
      }

      for (int var4 = 1; var4 < 8; var4++) {
         gameCanvas.setActorAttribute(this.rightFacingAnimationFrames[var4 - 1], 30, var2 - var4 - 2);
         if (var2 - var4 < 11) {
            gameCanvas.deactivateActorRuntimeState(this.rightFacingAnimationFrames[var4 - 1]);
         }
      }
   }

   // $VF: renamed from: a (boolean) void
   public static void setGameplayMode(bool var0) {
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

   // $VF: renamed from: a (p, int, int) boolean
   public static bool isActorAtTile(ActorState var0, int var1, int var2) {
      return var0.byteValue01 == var1 && var0.byteValue02 == var2;
   }

   // $VF: renamed from: a (p, int, int) void
   public static void setActorTilePosition(ActorState var0, int var1, int var2) {
      var0.byteValue01 = (sbyte)var1;
      var0.byteValue02 = (sbyte)var2;
   }

   // $VF: renamed from: a () int
   public int getElapsedGameTime() {
      long var3 = gameCanvas.gameLongValue06 - gameCanvas.gameLongValue08;
      switch (GameCanvas.gameShortValue01) {
         case 140:
            switch (GameCanvas.gameByteValue07) {
               case 0:
                  setGameplayMode(false);
                  return 1;
               case 1:
                  gameCanvas.processLevelEntity(1, true);
                  if (gameCanvas.gameActorStateReference01 != null) {
                     gameCanvas.gameActorStateReference01.booleanFlag01 = false;
                  }

                  if (gameCanvas.gameActorStateReference03 != null) {
                     gameCanvas.gameActorStateReference03.booleanFlag01 = false;
                  }

                  if (gameCanvas.gameActorStateReference02 != null) {
                     gameCanvas.gameActorStateReference02.booleanFlag01 = false;
                  }

                  if (isActorAtTile(gameCanvas.gameActorGroupReference02.actorStateReference01, 14, 5) && gameCanvas.gameActorGroupReference02.byteValue05 == 1) {
                     setActorTilePosition(gameCanvas.gameActorGroupReference02.actorStateReference01, 13, 5);
                     gameCanvas.faceActorTowardPosition(gameCanvas.gameActorGroupReference02.actorStateReference01, 0);
                     GameCanvas.setActorFacingDirection(gameCanvas.gameActorGroupReference02.actorStateReference01, 1);
                  } else if (isActorAtTile(gameCanvas.gameActorGroupReference02.actorStateReference01, 14, 5) && gameCanvas.gameActorGroupReference02.byteValue05 == 1) {
                     setActorTilePosition(gameCanvas.gameActorGroupReference02.actorStateReference01, 13, 5);
                     gameCanvas.faceActorTowardPosition(gameCanvas.gameActorGroupReference02.actorStateReference01, 0);
                     GameCanvas.setActorFacingDirection(gameCanvas.gameActorGroupReference02.actorStateReference01, 1);
                  }

                  setActorTilePosition(gameCanvas.gameActorGroupReference01.actorStateReference01, 14, 5);
                  gameCanvas.updateActorGroups();
                  gameCanvas.setCameraPosition(
                     gameCanvas.getTilePixelX(gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue01, gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue02) - GameCanvas.gameIntegerValue43 / 2,
                     GameCanvas.getTilePixelY(gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue01, gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue02) - GameCanvas.gameIntegerValue44 / 2
                  );
                  gameCanvas.updateActorDisplayState(gameCanvas.gameActorGroupReference01.actorStateReference01, false);
                  GameCanvas.setActorFacingDirection(gameCanvas.gameActorGroupReference01.actorStateReference01, 7);
                  gameCanvas.faceActorTowardPosition(gameCanvas.gameActorGroupReference01.actorStateReference01, 1);
                  setGameplayMode(true);
                  return 1;
               default:
                  return 1;
            } goto case 400;
         case 400:
            switch (GameCanvas.gameByteValue07) {
               case 0:
                  setGameplayMode(false);
                  return 1;
               case 1:
                  if (isActorAtTile(gameCanvas.gameActorGroupReference02.actorStateReference01, 23, 41) && gameCanvas.gameActorGroupReference02.byteValue05 == 1) {
                     setActorTilePosition(gameCanvas.gameActorGroupReference01.actorStateReference01, 24, 40);
                  } else {
                     setActorTilePosition(gameCanvas.gameActorGroupReference01.actorStateReference01, 23, 40);
                  }

                  gameCanvas.setCameraPosition(gameCanvas.getTilePixelX(23, 41) - GameCanvas.gameIntegerValue43 / 2, GameCanvas.getTilePixelY(23, 41) - GameCanvas.gameIntegerValue44 / 2);
                  GameCanvas.setActorFacingDirection(gameCanvas.gameActorGroupReference01.actorStateReference01, 7);
                  gameCanvas.faceActorTowardPosition(gameCanvas.gameActorGroupReference01.actorStateReference01, 1);
                  setGameplayMode(true);
                  gameCanvas.updateActorGroups(); goto default;
               default:
                  return 1;
            } goto case 410;
         case 410:
            switch (GameCanvas.gameByteValue07) {
               case 0:
                  setGameplayMode(false);
                  return 1;
               case 1:
                  if (isActorAtTile(gameCanvas.gameActorGroupReference02.actorStateReference01, 46, 41) && gameCanvas.gameActorGroupReference02.byteValue05 == 1) {
                     setActorTilePosition(gameCanvas.gameActorGroupReference02.actorStateReference01, 45, 41);
                  }

                  setActorTilePosition(gameCanvas.gameActorGroupReference01.actorStateReference01, 46, 40);
                  gameCanvas.setCameraPosition(gameCanvas.getTilePixelX(46, 41) - GameCanvas.gameIntegerValue43 / 2, GameCanvas.getTilePixelY(46, 41) - GameCanvas.gameIntegerValue44 / 2);
                  GameCanvas.setActorFacingDirection(gameCanvas.gameActorGroupReference01.actorStateReference01, 7);
                  gameCanvas.faceActorTowardPosition(gameCanvas.gameActorGroupReference01.actorStateReference01, 1);
                  setGameplayMode(true);
                  gameCanvas.updateActorGroups();
                  return 1;
               default:
                  return 1;
            } goto case 430;
         case 430:
            switch (GameCanvas.gameByteValue07) {
               case 0:
                  if (gameCanvas.gameByteValue20 == 0) {
                     gameCanvas.gameByteValue20 = 1;
                  } else if (gameCanvas.gameByteValue20 == 2) {
                     gameCanvas.gameByteValue20 = -1;
                     gameCanvas.gameActorStateReference04 = gameCanvas.createActorState(10, 33, 32, 7);
                  }

                  gameCanvas.enableActorActionFlag(157, 0);
                  gameCanvas.saveEntitySnapshot(157);
                  gameCanvas.setActiveActorGroupDirection((sbyte)34);
                  if (gameCanvas.gameByteValue20 == -1) {
                     gameCanvas.loadActorResources();
                  }

                  gameCanvas.updateLevelEntities();
                  gameCanvas.updateTimedEntities();
                  setActorTilePosition(gameCanvas.gameActorGroupReference01.actorStateReference01, 23, 15);
                  gameCanvas.updateActorGroups();
                  gameCanvas.gameActorGroupReference01.actorStateReference01.booleanFlag01 = false;
                  gameCanvas.updateActorDisplayState(gameCanvas.gameActorGroupReference01.actorStateReference01, true);
                  gameCanvas.setCameraPosition(
                     gameCanvas.getTilePixelX(gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue01, gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue02) - GameCanvas.gameIntegerValue43 / 2,
                     GameCanvas.getTilePixelY(gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue01, gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue02) - GameCanvas.gameIntegerValue44 / 2
                  );
                  gameCanvas.gameIntegerValue66 = gameCanvas.gameByteValue20 == -1 ? 0 : 1;
                  gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                  setGameplayMode(false);
                  return 1;
               case 1:
                  switch (gameCanvas.gameIntegerValue66) {
                     case 0:
                        if (var3 > 2000L) {
                           gameCanvas.processActorAction(39);
                           gameCanvas.gameIntegerValue66++;
                           setActorTilePosition(gameCanvas.gameActorGroupReference01.actorStateReference01, 33, 31);
                           gameCanvas.setCameraPosition(
                              gameCanvas.getTilePixelX(gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue01, gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue02) - GameCanvas.gameIntegerValue43 / 2,
                              GameCanvas.getTilePixelY(gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue01, gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue02) - GameCanvas.gameIntegerValue44 / 2
                           );
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                           gameCanvas.updateActorDisplayState(gameCanvas.gameActorGroupReference01.actorStateReference01, false);
                        }
                        break;
                     case 1:
                        if (var3 > 3000L) {
                           gameCanvas.gameIntegerValue66++;
                           setActorTilePosition(gameCanvas.gameActorGroupReference01.actorStateReference01, (sbyte)(gameCanvas.gameClass9ReferenceArray01[157].byteValue02 + 1), gameCanvas.gameClass9ReferenceArray01[157].byteValue03);
                           gameCanvas.updateActorGroups();
                           gameCanvas.gameActorGroupReference01.actorStateReference01.booleanFlag01 = true;
                           gameCanvas.updateActorDisplayState(gameCanvas.gameActorGroupReference01.actorStateReference01, true);
                        }
                        break;
                     case 2:
                        setGameplayMode(true); break;
                  } goto default;
               default:
                  return 1;
            } goto case 440;
         case 440:
            switch (GameCanvas.gameByteValue07) {
               case 0:
                  if (gameCanvas.gameClass9ReferenceArray01[158].actorFlagsReferenceArray01[0].booleanFlag01) {
                     if (gameCanvas.gameActorGroupReference01 == gameCanvas.gameActorGroupReference03) {
                        gameCanvas.showGameMessage(0, gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue08, GameCanvas.getLocalizedText(45), 0);
                        setGameplayMode(false);
                        gameCanvas.gameIntegerValue66 = 0;
                     } else {
                        gameCanvas.showGameMessage(0, gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue08, GameCanvas.getLocalizedText(46), 0);
                        setGameplayMode(false);
                        gameCanvas.gameIntegerValue66 = 0;
                     }
                  } else if (gameCanvas.gameByteValue20 >= 0 && gameCanvas.gameByteValue20 != 2) {
                     gameCanvas.gameIntegerValue66 = 1;
                     setGameplayMode(false);
                  } else {
                     setGameplayMode(true);
                  }
                  break;
               case 1:
                  switch (gameCanvas.gameIntegerValue66) {
                     case 0:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           if (gameCanvas.gameActorGroupReference01 == gameCanvas.gameActorGroupReference04) {
                              gameCanvas.disableActorActionFlag(158, 0);
                              gameCanvas.processActorAction(34);
                           }

                           setGameplayMode(true);
                        }
                        break;
                     case 1:
                        if (gameCanvas.gameByteValue20 == 0) {
                           gameCanvas.gameByteValue20 = 2;
                        } else if (gameCanvas.gameByteValue20 == 1) {
                           gameCanvas.gameByteValue20 = -1;
                           gameCanvas.gameActorStateReference04 = gameCanvas.createActorState(10, 33, 32, 7);
                           gameCanvas.processActorAction(39);
                        }

                        if (gameCanvas.gameByteValue20 == -1) {
                           gameCanvas.loadActorResources();
                        }

                        gameCanvas.updateLevelEntities();
                        gameCanvas.updateTimedEntities();
                        setActorTilePosition(gameCanvas.gameActorGroupReference01.actorStateReference01, 33, 32);
                        gameCanvas.updateActorGroups();
                        gameCanvas.gameActorGroupReference01.actorStateReference01.booleanFlag01 = false;
                        gameCanvas.updateActorDisplayState(gameCanvas.gameActorGroupReference01.actorStateReference01, true);
                        gameCanvas.setCameraPosition(
                           gameCanvas.getTilePixelX(gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue01, gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue02) - GameCanvas.gameIntegerValue43 / 2,
                           GameCanvas.getTilePixelY(gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue01, gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue02) - GameCanvas.gameIntegerValue44 / 2
                        );
                        gameCanvas.gameIntegerValue66++;
                        gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        break;
                     case 2:
                        if (var3 > 3000L) {
                           gameCanvas.gameIntegerValue66++;
                           setActorTilePosition(gameCanvas.gameActorGroupReference01.actorStateReference01, gameCanvas.gameClass9ReferenceArray01[158].byteValue02, gameCanvas.gameClass9ReferenceArray01[158].byteValue03);
                           gameCanvas.updateActorGroups();
                           gameCanvas.gameActorGroupReference01.actorStateReference01.booleanFlag01 = true;
                           gameCanvas.updateActorDisplayState(gameCanvas.gameActorGroupReference01.actorStateReference01, true);
                        }
                        break;
                     case 3:
                        setGameplayMode(true); break;
                  } break;
            }

            return 1;
         case 460:
            switch (GameCanvas.gameByteValue07) {
               case 0:
                  setGameplayMode(false);
                  return 1;
               case 1:
                  if (isActorAtTile(gameCanvas.gameActorGroupReference02.actorStateReference01, 21, 30) && gameCanvas.gameActorGroupReference02.byteValue05 == 1) {
                     setActorTilePosition(gameCanvas.gameActorGroupReference01.actorStateReference01, 20, 31);
                  } else {
                     setActorTilePosition(gameCanvas.gameActorGroupReference01.actorStateReference01, 21, 31);
                  }

                  gameCanvas.setCameraPosition(gameCanvas.getTilePixelX(21, 30) - GameCanvas.gameIntegerValue43 / 2, GameCanvas.getTilePixelY(21, 30) - GameCanvas.gameIntegerValue44 / 2);
                  GameCanvas.setActorFacingDirection(gameCanvas.gameActorGroupReference01.actorStateReference01, 3);
                  gameCanvas.faceActorTowardPosition(gameCanvas.gameActorGroupReference01.actorStateReference01, 1);
                  setGameplayMode(true);
                  gameCanvas.updateActorGroups();
                  return 1;
               default:
                  return 1;
            } goto case 470;
         case 470:
            switch (GameCanvas.gameByteValue07) {
               case 0:
                  setGameplayMode(false);
                  return 1;
               case 1:
                  if (isActorAtTile(gameCanvas.gameActorGroupReference02.actorStateReference01, 41, 34) && gameCanvas.gameActorGroupReference02.byteValue05 == 1) {
                     setActorTilePosition(gameCanvas.gameActorGroupReference01.actorStateReference01, 40, 35);
                  } else {
                     setActorTilePosition(gameCanvas.gameActorGroupReference01.actorStateReference01, 41, 35);
                  }

                  gameCanvas.updateActorDisplayState(gameCanvas.gameActorGroupReference01.actorStateReference01, true);
                  gameCanvas.setCameraPosition(gameCanvas.getTilePixelX(41, 34) - GameCanvas.gameIntegerValue43 / 2, GameCanvas.getTilePixelY(41, 34) - GameCanvas.gameIntegerValue44 / 2);
                  GameCanvas.setActorFacingDirection(gameCanvas.gameActorGroupReference01.actorStateReference01, 3);
                  gameCanvas.faceActorTowardPosition(gameCanvas.gameActorGroupReference01.actorStateReference01, 1);
                  setGameplayMode(true);
                  gameCanvas.updateActorGroups();
                  return 1;
               default:
                  return 1;
            } goto case 480;
         case 480:
            switch (GameCanvas.gameByteValue07) {
               case 0:
                  if (!gameCanvas.gameClass9ReferenceArray01[291].booleanFlag02) {
                     gameCanvas.showGameMessage(0, 2, GameCanvas.getLocalizedText(78), 0);
                     setGameplayMode(true);
                     return 1;
                  }

                  if (gameCanvas.gameByteValue17 != 2) {
                     gameCanvas.showGameMessage(0, 2, GameCanvas.getLocalizedText(73), 0);
                     setGameplayMode(true);
                     return 1;
                  }

                  if (!gameCanvas.gameActorGroupReference03.entitySnapshotReferenceArray01[11].booleanFlag01 && !gameCanvas.gameActorGroupReference04.entitySnapshotReferenceArray01[11].booleanFlag01
                     || !gameCanvas.gameActorGroupReference03.entitySnapshotReferenceArray01[10].booleanFlag01 && !gameCanvas.gameActorGroupReference04.entitySnapshotReferenceArray01[10].booleanFlag01) {
                     gameCanvas.showGameMessage(0, 2, GameCanvas.getLocalizedText(74), 0);
                     setGameplayMode(true);
                     return 1;
                  }

                  if (gameCanvas.gameActorGroupReference01.byteValue05 != gameCanvas.gameActorGroupReference02.byteValue05
                     || gameCanvas.getActorStateValue(gameCanvas.gameActorGroupReference01.actorStateReference01) != gameCanvas.getActorStateValue(gameCanvas.gameActorGroupReference02.actorStateReference01)) {
                     gameCanvas.gameIntegerValue66 = 5;
                     gameCanvas.showGameMessage(0, 2, GameCanvas.getLocalizedText(77), 0);
                  } else if ((gameCanvas.gameActorGroupReference02.actorStateReference01.byteValue01 < 39 || gameCanvas.gameActorGroupReference02.actorStateReference01.byteValue02 < 30)
                     && (gameCanvas.gameActorGroupReference02.actorStateReference01.byteValue01 < 37 || gameCanvas.gameActorGroupReference02.actorStateReference01.byteValue02 < 34)) {
                     if (gameCanvas.gameActorGroupReference02.actorStateReference01.byteValue01 <= 22) {
                        gameCanvas.gameIntegerValue66 = 1;
                        gameCanvas.showGameMessage(0, 2, GameCanvas.getLocalizedText(77), 0);
                     } else if (gameCanvas.gameActorGroupReference02.actorStateReference01.byteValue01 <= 34 && gameCanvas.gameActorGroupReference02.actorStateReference01.byteValue02 <= 21) {
                        gameCanvas.gameIntegerValue66 = 21;
                        if (!isActorAtTile(gameCanvas.gameActorGroupReference01.actorStateReference01, 33, 16) && !isActorAtTile(gameCanvas.gameActorGroupReference01.actorStateReference01, 33, 15)
                           || !isActorAtTile(gameCanvas.gameActorGroupReference02.actorStateReference01, 33, 16) && !isActorAtTile(gameCanvas.gameActorGroupReference02.actorStateReference01, 33, 15)) {
                           gameCanvas.setActorState(gameCanvas.gameByteValue03 == 1 ? 2 : 1);
                        }
                     } else {
                        gameCanvas.gameIntegerValue66 = 10;
                     }
                  } else {
                     gameCanvas.gameIntegerValue66 = 0;
                     gameCanvas.showGameMessage(0, 2, GameCanvas.getLocalizedText(77), 0);
                  }

                  setGameplayMode(false);
                  break;
               case 1:
                  switch (gameCanvas.gameIntegerValue66) {
                     case 0:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.gameActorGroupReference02.booleanFlag04 = true;
                           gameCanvas.moveActorToTile(gameCanvas.gameActorGroupReference02.actorStateReference01, 41, 34);
                           gameCanvas.updateActorDisplayState(gameCanvas.gameActorGroupReference02.actorStateReference01, true);
                           gameCanvas.gameIntegerValue66 = 2;
                        }
                        break;
                     case 1:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.gameActorGroupReference02.booleanFlag04 = true;
                           gameCanvas.moveActorToTile(gameCanvas.gameActorGroupReference02.actorStateReference01, 21, 30);
                           gameCanvas.updateActorDisplayState(gameCanvas.gameActorGroupReference02.actorStateReference01, true);
                           gameCanvas.gameIntegerValue66 = 2;
                        }
                        break;
                     case 2:
                        gameCanvas.updateActorDisplayState(gameCanvas.gameActorGroupReference02.actorStateReference01, true);
                        if (gameCanvas.gameActorGroupReference02.actorStateReference01.byteValue12 == -1 && gameCanvas.gameActorGroupReference02.actorStateReference01.byteValue13 == -1) {
                           gameCanvas.gameActorGroupReference02.actorStateReference01.booleanFlag01 = false;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 3:
                        if (var3 > 500L) {
                           gameCanvas.gameIntegerValue66 = 8;
                        } goto case 4;
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
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.gameIntegerValue66 = 8;
                        }
                        break;
                     case 8:
                        gameCanvas.gameActorGroupReference02.byteValue05 = 1;
                        gameCanvas.gameActorGroupReference02.actorStateReference01.booleanFlag01 = true;
                        setActorTilePosition(gameCanvas.gameActorGroupReference02.actorStateReference01, 33, 35);
                        gameCanvas.updateActorDisplayState(gameCanvas.gameActorGroupReference02.actorStateReference01, true);
                        gameCanvas.gameIntegerValue66 = 10;
                        break;
                     case 10:
                        gameCanvas.gameActorGroupReference02.booleanFlag04 = true;
                        gameCanvas.moveActorToTile(gameCanvas.gameActorGroupReference02.actorStateReference01, 35, 27);
                        gameCanvas.updateActorDisplayState(gameCanvas.gameActorGroupReference02.actorStateReference01, true);
                        gameCanvas.gameIntegerValue66++;
                        break;
                     case 11:
                        gameCanvas.updateActorDisplayState(gameCanvas.gameActorGroupReference02.actorStateReference01, true);
                        if (gameCanvas.gameActorGroupReference02.actorStateReference01.byteValue12 == -1 && gameCanvas.gameActorGroupReference02.actorStateReference01.byteValue13 == -1) {
                           gameCanvas.setActorState(gameCanvas.gameByteValue03 == 1 ? 2 : 1);
                           beginPlayerActionSequence();
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 12:
                        if (advancePlayerActionSequence()) {
                           setActorTilePosition(gameCanvas.gameActorGroupReference01.actorStateReference01, 32, 22);
                           gameCanvas.gameActorGroupReference01.actorStateReference01.booleanFlag01 = true;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                           gameCanvas.gameIntegerValue66 = 20;
                           gameCanvas.gameBooleanFlag37 = true;
                           gameCanvas.faceActorTowardPosition(gameCanvas.gameActorGroupReference01.actorStateReference01, 1);
                        }
                        break;
                     case 20:
                        if (gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue05 == 0 && gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue03 == 0) {
                           gameCanvas.gameBooleanFlag37 = false;
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 21:
                        gameCanvas.moveActorToTile(gameCanvas.gameActorGroupReference01.actorStateReference01, 33, gameCanvas.gameActorGroupReference02.actorStateReference01.byteValue02 == 16 ? 15 : 16);
                        gameCanvas.gameActorGroupReference01.booleanFlag04 = false;
                        gameCanvas.gameIntegerValue66++;
                        break;
                     case 22:
                        if (gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue12 == -1 && gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue13 == -1) {
                           GameCanvas.setActorFacingDirection(gameCanvas.gameActorGroupReference01.actorStateReference01, 5);
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 23:
                        if (var3 > 500L) {
                           gameCanvas.processActorAction(19);
                           gameCanvas.setActorAnimationPair(294, 292);
                           gameCanvas.setActorAnimationPair(295, 293);
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 24:
                        if (var3 > 500L) {
                           gameCanvas.gameActorGroupReference02.actorStateReference01.byteValue01--;
                           gameCanvas.gameActorGroupReference02.actorStateReference01.booleanFlag01 = false;
                           gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue01--;
                           gameCanvas.gameActorGroupReference01.actorStateReference01.booleanFlag01 = false;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 25:
                        if (var3 > 500L) {
                           gameCanvas.processActorAction(19);
                           gameCanvas.setActorAnimationPair(292, 294);
                           gameCanvas.setActorAnimationPair(293, 295);
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                           gameCanvas.gameIntegerValue83 = 1000;
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 26:
                        if (var3 > 800L) {
                           gameCanvas.processActorAction(35);
                           this.updateBossHealthBar(30, 17);
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        }
                        break;
                     case 27:
                        if (var3 > 700L) {
                           this.updateBossHealthBar(30, 16);
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        }
                        break;
                     case 28:
                        if (var3 > 550L) {
                           this.updateBossHealthBar(30, 15);
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        }
                        break;
                     case 29:
                        if (var3 > 400L) {
                           this.updateBossHealthBar(30, 14);
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        }
                        break;
                     case 30:
                        if (var3 > 250L) {
                           this.updateBossHealthBar(30, 13);
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        }
                        break;
                     case 31:
                        if (var3 > 100L) {
                           this.updateBossHealthBar(30, 12);
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        }
                        break;
                     case 32:
                        if (var3 > 50L) {
                           this.updateBossHealthBar(30, 11);
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        }
                        break;
                     case 33:
                        if (var3 > 50L) {
                           this.updateBossHealthBar(30, 10);
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        }
                        break;
                     case 34:
                        if (var3 > 50L) {
                           setGameplayMode(true);
                           gameCanvas.setActorState(gameCanvas.gameByteValue03 == 1 ? 2 : 1);
                           setActorTilePosition(gameCanvas.gameActorGroupReference01.actorStateReference01, 38, 31);
                           setActorTilePosition(gameCanvas.gameActorGroupReference02.actorStateReference01, 38, 33);
                           gameCanvas.gameBooleanFlag03 = true;
                           gameCanvas.gameActorGroupReference02.byteValue05 = 2;
                           gameCanvas.processLevelEntity(2, true);
                           gameCanvas.gameActorGroupReference01.actorStateReference01.booleanFlag01 = false;
                           gameCanvas.gameActorGroupReference02.actorStateReference01.booleanFlag01 = false;
                           GameCanvas.gameBooleanFlag59 = false;
                        } break;
                  } break;
            }

            return 1;
         case 490:
            switch (GameCanvas.gameByteValue07) {
               case 0:
                  if (isActorAtTile(gameCanvas.gameActorGroupReference02.actorStateReference01, 32, 21) && gameCanvas.gameActorGroupReference02.byteValue05 == 1) {
                     setGameplayMode(true);
                     return 1;
                  }

                  if (isActorAtTile(gameCanvas.gameActorGroupReference02.actorStateReference01, 35, 27) && gameCanvas.gameActorGroupReference02.byteValue05 == 1) {
                     setGameplayMode(true);
                     return 1;
                  }

                  if (!isActorAtTile(gameCanvas.gameActorGroupReference01.actorStateReference01, 35, 27)) {
                     gameCanvas.advanceGameplaySimulation();
                     gameCanvas.findPathToTile(gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue01, gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue02, 35, 27);
                     if (gameCanvas.gameClass14Reference01 == null) {
                        setGameplayMode(true);
                        return 1;
                     }

                     gameCanvas.moveActorToTile(gameCanvas.gameActorGroupReference01.actorStateReference01, 35, 27);
                     gameCanvas.gameIntegerValue66 = 0;
                  } else {
                     beginPlayerActionSequence();
                     gameCanvas.gameIntegerValue66 = 1;
                  }

                  setGameplayMode(false);
                  return 1;
               case 1:
                  switch (gameCanvas.gameIntegerValue66) {
                     case 0:
                        if (!GameCanvas.isActorDefeated(gameCanvas.gameActorGroupReference01.actorStateReference01) && !isActorAtTile(gameCanvas.gameActorGroupReference01.actorStateReference01, 35, 27)) {
                           gameCanvas.advanceGameplaySimulation();
                           gameCanvas.findPathToTile(gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue01, gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue02, 35, 27);
                           if (gameCanvas.gameClass14Reference01 == null) {
                              gameCanvas.faceActorTowardPosition(gameCanvas.gameActorGroupReference01.actorStateReference01, 0);
                              setGameplayMode(true);
                              return 1;
                           }

                           gameCanvas.moveActorToTile(gameCanvas.gameActorGroupReference01.actorStateReference01, 35, 27);
                        }

                        if (!GameCanvas.isActorDefeated(gameCanvas.gameActorGroupReference01.actorStateReference01) && isActorAtTile(gameCanvas.gameActorGroupReference01.actorStateReference01, 35, 27)) {
                           beginPlayerActionSequence();
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 1:
                        if (advancePlayerActionSequence()) {
                           setActorTilePosition(gameCanvas.gameActorGroupReference01.actorStateReference01, 32, 22);
                           gameCanvas.updateActorDisplayState(gameCanvas.gameActorGroupReference01.actorStateReference01, false);
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                           gameCanvas.gameIntegerValue66 = 9;
                           gameCanvas.gameBooleanFlag37 = true;
                           gameCanvas.faceActorTowardPosition(gameCanvas.gameActorGroupReference01.actorStateReference01, 1);
                        }
                        break;
                     case 9:
                        if (!GameCanvas.isActorDefeated(gameCanvas.gameActorGroupReference01.actorStateReference01)) {
                           gameCanvas.gameBooleanFlag37 = false;
                           setGameplayMode(true);
                        } break;
                  } goto default;
               default:
                  return 1;
            } goto case 500;
         case 500:
            switch (GameCanvas.gameByteValue07) {
               case 0:
                  if (isActorAtTile(gameCanvas.gameActorGroupReference02.actorStateReference01, 35, 27) && gameCanvas.gameActorGroupReference02.byteValue05 == 1) {
                     setGameplayMode(true);
                     return 1;
                  }

                  if (isActorAtTile(gameCanvas.gameActorGroupReference02.actorStateReference01, 32, 21) && gameCanvas.gameActorGroupReference02.byteValue05 == 1) {
                     setGameplayMode(true);
                     return 1;
                  }

                  if (!isActorAtTile(gameCanvas.gameActorGroupReference01.actorStateReference01, 32, 21)) {
                     gameCanvas.advanceGameplaySimulation();
                     gameCanvas.findPathToTile(gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue01, gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue02, 32, 21);
                     if (gameCanvas.gameClass14Reference01 == null) {
                        setGameplayMode(true);
                        return 1;
                     }

                     gameCanvas.moveActorToTile(gameCanvas.gameActorGroupReference01.actorStateReference01, 32, 21);
                     gameCanvas.gameIntegerValue66 = 0;
                  } else {
                     beginEnemyActionSequence();
                     gameCanvas.gameIntegerValue66 = 1;
                  }

                  setGameplayMode(false);
                  return 1;
               case 1:
                  switch (gameCanvas.gameIntegerValue66) {
                     case 0:
                        if (!GameCanvas.isActorDefeated(gameCanvas.gameActorGroupReference01.actorStateReference01) && !isActorAtTile(gameCanvas.gameActorGroupReference01.actorStateReference01, 32, 21)) {
                           gameCanvas.advanceGameplaySimulation();
                           gameCanvas.findPathToTile(gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue01, gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue02, 32, 21);
                           if (gameCanvas.gameClass14Reference01 == null) {
                              gameCanvas.faceActorTowardPosition(gameCanvas.gameActorGroupReference01.actorStateReference01, 0);
                              setGameplayMode(true);
                              return 1;
                           }

                           gameCanvas.moveActorToTile(gameCanvas.gameActorGroupReference01.actorStateReference01, 32, 21);
                        }

                        if (!GameCanvas.isActorDefeated(gameCanvas.gameActorGroupReference01.actorStateReference01) && isActorAtTile(gameCanvas.gameActorGroupReference01.actorStateReference01, 32, 21)) {
                           beginEnemyActionSequence();
                           gameCanvas.gameIntegerValue66 = 1;
                        }
                        break;
                     case 1:
                        if (advanceEnemyActionSequence()) {
                           setActorTilePosition(gameCanvas.gameActorGroupReference01.actorStateReference01, 35, 27);
                           gameCanvas.gameActorGroupReference01.actorStateReference01.booleanFlag01 = true;
                           gameCanvas.updateActorDisplayState(gameCanvas.gameActorGroupReference01.actorStateReference01, false);
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                           gameCanvas.gameIntegerValue66 = 5;
                           gameCanvas.faceActorTowardPosition(gameCanvas.gameActorGroupReference01.actorStateReference01, 1);
                        }
                        break;
                     case 5:
                        if (var3 > 2000L) {
                           setGameplayMode(true);
                        } break;
                  } goto default;
               default:
                  return 1;
            } goto case 510;
         case 510:
            switch (GameCanvas.gameByteValue07) {
               case 0:
                  gameCanvas.activateActorRuntimeState(3);
                  gameCanvas.gameIntegerValue83 = 2000;
                  gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                  setGameplayMode(false);
                  gameCanvas.processActorAction(35);
                  break;
               case 1:
                  if (var3 > 2000L) {
                     gameCanvas.initializeActorStates(true);
                     setGameplayMode(true);
                  } break;
            }

            return 1;
         case 540:
            switch (GameCanvas.gameByteValue07) {
               case 0:
                  gameCanvas.gameIntegerValue66 = 0;
                  gameCanvas.deactivateActorRuntimeState(31);
                  gameCanvas.gameIntegerValue90 = 45;
                  setGameplayMode(false);
                  return 1;
               case 1:
                  switch (gameCanvas.gameIntegerValue66) {
                     case 0:
                        if (!GameCanvas.isActorDefeated(gameCanvas.gameActorGroupReference01.actorStateReference01)) {
                           gameCanvas.transitionGameState(1);
                           gameCanvas.showGameMessage(0, 5, GameCanvas.getLocalizedText(189), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 1:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue09 = 127;
                           gameCanvas.faceActorTowardPosition(gameCanvas.gameActorGroupReference01.actorStateReference01, 11);
                           GameCanvas.setActorFacingDirection(gameCanvas.gameActorGroupReference01.actorStateReference01, 5);
                           gameCanvas.showGameMessage(0, 5, GameCanvas.getLocalizedText(190), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 2:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.showGameMessage(0, 2, GameCanvas.getLocalizedText(191), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 3:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.showGameMessage(0, 5, GameCanvas.getLocalizedText(192), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 4:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.showGameMessage(0, 5, GameCanvas.getLocalizedText(193), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 5:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.showGameMessage(0, 5, GameCanvas.getLocalizedText(194), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 6:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.faceActorTowardPosition(gameCanvas.gameActorGroupReference01.actorStateReference01, 0);
                           GameCanvas.setActorFacingDirection(gameCanvas.gameActorGroupReference01.actorStateReference01, 5);
                           gameCanvas.showGameMessage(0, 2, GameCanvas.getLocalizedText(195), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 7:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.showGameMessage(0, 5, GameCanvas.getLocalizedText(196), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 8:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.showGameMessage(0, 5, GameCanvas.getLocalizedText(197), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 9:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.faceActorTowardPosition(gameCanvas.gameActorGroupReference01.actorStateReference01, 0);
                           GameCanvas.setActorFacingDirection(gameCanvas.gameActorGroupReference01.actorStateReference01, 7);
                           gameCanvas.showGameMessage(0, 2, GameCanvas.getLocalizedText(198), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 10:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.showGameMessage(0, 5, GameCanvas.getLocalizedText(199), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 11:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.showGameMessage(0, 5, GameCanvas.getLocalizedText(200), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 12:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.showGameMessage(0, 5, GameCanvas.getLocalizedText(201), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 13:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.gameIntegerValue83 = 2000;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.processActorAction(36);
                        }
                        break;
                     case 14:
                        if (var3 > 1200L) {
                           gameCanvas.showGameMessage(0, 5, GameCanvas.getLocalizedText(202), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 15:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.gameActorStateReference03 = gameCanvas.createActorState(5, 36, 9, 3);
                           gameCanvas.moveActorToTile(gameCanvas.gameActorStateReference03, 36, 7);
                           GameCanvas.setActorFacingDirection(gameCanvas.gameActorGroupReference01.actorStateReference01, 5);
                           gameCanvas.updatePlayerActor();
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 16:
                        if (isActorAtTile(gameCanvas.gameActorStateReference03, 36, 7)) {
                           gameCanvas.activateActorRuntimeState(31);
                        }

                        if (!GameCanvas.isActorDefeated(gameCanvas.gameActorStateReference03) && isActorAtTile(gameCanvas.gameActorStateReference03, 36, 7)) {
                           gameCanvas.transitionGameState(5);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 17:
                        gameCanvas.setCameraPosition(
                           gameCanvas.getTilePixelX(gameCanvas.gameActorStateReference03.byteValue01, gameCanvas.gameActorStateReference03.byteValue02) - GameCanvas.gameIntegerValue43 / 2,
                           GameCanvas.getTilePixelY(gameCanvas.gameActorStateReference03.byteValue01, gameCanvas.gameActorStateReference03.byteValue02) - GameCanvas.gameIntegerValue44 / 2
                        );
                        gameCanvas.updateActorDisplayState(gameCanvas.gameActorStateReference03, false);
                        gameCanvas.gameIntegerValue90 = 0;
                        gameCanvas.faceActorTowardPosition(gameCanvas.gameActorStateReference03, 5);
                        gameCanvas.gameIntegerValue66++;
                        break;
                     case 18:
                        if (gameCanvas.gameActorStateReference03.byteValue05 == 0) {
                           gameCanvas.faceActorTowardPosition(gameCanvas.gameActorStateReference03, 5);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 19:
                        if (gameCanvas.gameActorStateReference03.byteValue05 == 0) {
                           GameCanvas.setActorFacingDirection(gameCanvas.gameActorStateReference03, 1);
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        }
                        break;
                     case 20:
                        if (var3 > 500L) {
                           gameCanvas.setCameraPosition(
                              gameCanvas.getTilePixelX(gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue01, gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue02) - GameCanvas.gameIntegerValue43 / 2,
                              GameCanvas.getTilePixelY(gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue01, gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue02) - GameCanvas.gameIntegerValue44 / 2
                           );
                           gameCanvas.updateActorDisplayState(gameCanvas.gameActorGroupReference01.actorStateReference01, false);
                           gameCanvas.gameIntegerValue66++;
                           GameCanvas.gameByteValue07 = 3;
                        }
                        break;
                     case 21:
                        gameCanvas.gameActorStateReference03.byteValue10 = 100;
                        gameCanvas.faceActorTowardPosition(gameCanvas.gameActorStateReference03, 0);
                        if (gameCanvas.gameActorGroupReference02.byteValue05 == gameCanvas.gameByteValue04) {
                           gameCanvas.gameActorGroupReference02.actorStateReference01.booleanFlag01 = false;
                        }

                        gameCanvas.moveActorToTile(gameCanvas.gameActorGroupReference01.actorStateReference01, 42, 6);
                        gameCanvas.moveActorToTile(gameCanvas.gameActorStateReference03, 45, 3);
                        GameCanvas.gameIntegerValue50 = 384;
                        gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        gameCanvas.gameIntegerValue66++;
                        break;
                     case 22:
                        if (!GameCanvas.isActorDefeated(gameCanvas.gameActorGroupReference01.actorStateReference01) && !isActorAtTile(gameCanvas.gameActorGroupReference01.actorStateReference01, 42, 6)) {
                           gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue12 = -1;
                           gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue13 = -1;
                           gameCanvas.moveActorToTile(gameCanvas.gameActorGroupReference01.actorStateReference01, 42, 6);
                        }

                        if (!GameCanvas.isActorDefeated(gameCanvas.gameActorStateReference03) && !isActorAtTile(gameCanvas.gameActorStateReference03, 45, 3)) {
                           gameCanvas.gameActorStateReference03.byteValue12 = -1;
                           gameCanvas.gameActorStateReference03.byteValue13 = -1;
                           gameCanvas.moveActorToTile(gameCanvas.gameActorStateReference03, 45, 3);
                        }

                        if (!GameCanvas.isActorDefeated(gameCanvas.gameActorGroupReference01.actorStateReference01) && isActorAtTile(gameCanvas.gameActorGroupReference01.actorStateReference01, 42, 6)) {
                           if (gameCanvas.gameActorStateReference03.byteValue01 < 42) {
                              GameCanvas.setActorFacingDirection(gameCanvas.gameActorGroupReference01.actorStateReference01, 5);
                           } else {
                              GameCanvas.setActorFacingDirection(gameCanvas.gameActorGroupReference01.actorStateReference01, 1);
                           }
                        }

                        if (!GameCanvas.isActorDefeated(gameCanvas.gameActorStateReference03)
                           && isActorAtTile(gameCanvas.gameActorStateReference03, 45, 3)
                           && !GameCanvas.isActorDefeated(gameCanvas.gameActorGroupReference01.actorStateReference01)
                           && isActorAtTile(gameCanvas.gameActorGroupReference01.actorStateReference01, 42, 6)) {
                           gameCanvas.gameIntegerValue66++;
                        }

                        if (gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue10 <= 0) {
                           gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue10 = 2;
                        }
                        break;
                     case 23:
                        gameCanvas.gameActorStateReference03.booleanFlag01 = false;
                        gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        gameCanvas.gameIntegerValue66++;
                        gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue12 = -1;
                        gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue13 = -1;
                        gameCanvas.transitionGameState(2);
                        if (gameCanvas.gameActorGroupReference02.byteValue05 == gameCanvas.gameByteValue04) {
                           gameCanvas.gameActorGroupReference02.actorStateReference01.booleanFlag01 = true;
                        }
                        break;
                     case 24:
                        if (var3 > 2000L) {
                           gameCanvas.showGameMessage(0, 2, gameCanvas.gameByteValue03 == 1 ? GameCanvas.getLocalizedText(203) : GameCanvas.getLocalizedText(204), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 25:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.updatePlayerActor();
                           gameCanvas.moveActorToTile(gameCanvas.gameActorGroupReference01.actorStateReference01, 36, 7);
                           gameCanvas.gameIntegerValue66++;
                        } goto case 26;
                     case 26:
                        if (!GameCanvas.isActorDefeated(gameCanvas.gameActorGroupReference01.actorStateReference01) && isActorAtTile(gameCanvas.gameActorGroupReference01.actorStateReference01, 36, 7)) {
                           GameCanvas.setActorFacingDirection(gameCanvas.gameActorGroupReference01.actorStateReference01, 3);
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 27:
                        if (var3 > 1000L) {
                           gameCanvas.showGameMessage(0, 2, gameCanvas.gameByteValue03 == 1 ? GameCanvas.getLocalizedText(205) : GameCanvas.getLocalizedText(206), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 28:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.moveActorToTile(gameCanvas.gameActorGroupReference01.actorStateReference01, 35, 6);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 29:
                        if (!GameCanvas.isActorDefeated(gameCanvas.gameActorGroupReference01.actorStateReference01) && isActorAtTile(gameCanvas.gameActorGroupReference01.actorStateReference01, 35, 6)) {
                           GameCanvas.setActorFacingDirection(gameCanvas.gameActorGroupReference01.actorStateReference01, 5);
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 30:
                        if (var3 > 1000L) {
                           gameCanvas.showGameMessage(0, 2, gameCanvas.gameByteValue03 == 1 ? GameCanvas.getLocalizedText(207) : GameCanvas.getLocalizedText(208), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 31:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.moveActorToTile(gameCanvas.gameActorGroupReference01.actorStateReference01, 36, 7);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 32:
                        if (!GameCanvas.isActorDefeated(gameCanvas.gameActorGroupReference01.actorStateReference01) && isActorAtTile(gameCanvas.gameActorGroupReference01.actorStateReference01, 36, 7)) {
                           GameCanvas.setActorFacingDirection(gameCanvas.gameActorGroupReference01.actorStateReference01, 1);
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 33:
                        if (var3 > 500L) {
                           gameCanvas.showGameMessage(0, 2, GameCanvas.getLocalizedText(90), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 34:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           GameCanvas.setActorFacingDirection(gameCanvas.gameActorGroupReference01.actorStateReference01, 3);
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 35:
                        if (var3 > 500L) {
                           gameCanvas.showGameMessage(0, 2, GameCanvas.getLocalizedText(91), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 36:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.faceActorTowardPosition(gameCanvas.gameActorGroupReference01.actorStateReference01, 2);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 37:
                        if (!GameCanvas.isActorDefeated(gameCanvas.gameActorGroupReference01.actorStateReference01) && isActorAtTile(gameCanvas.gameActorGroupReference01.actorStateReference01, 36, 8)) {
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 38:
                        gameCanvas.gameActorStateReference05 = gameCanvas.createActorState(8, 36, 6, 7);
                        gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                        gameCanvas.updatePlayerActor();
                        gameCanvas.gameIntegerValue66++;
                        gameCanvas.processActorAction(38);
                        break;
                     case 39:
                        if (var3 > 500L) {
                           gameCanvas.gameIntegerValue66++;
                           GameCanvas.gameByteValue07 = 3;
                        }
                        break;
                     case 40:
                        gameCanvas.gameByteValue18 = 1;
                        setGameplayMode(true); break;
                  }

                  return 1;
               case 3:
                  switch (gameCanvas.gameIntegerValue66) {
                     case 21:
                        if (gameCanvas.gameActorStateReference03.byteValue10 < gameCanvas.gameActorStateReference03.byteValue11 - 45) {
                           gameCanvas.gameActorStateReference03.byteValue10 = (sbyte)(gameCanvas.gameActorStateReference03.byteValue11 - 45);
                        }

                        if (gameCanvas.gameActorStateReference03.byteValue10 > gameCanvas.gameActorStateReference03.byteValue11 - 45) {
                           return 1;
                        }
                        break;
                     case 40:
                        if (gameCanvas.gameActorStateReference05.byteValue05 != 3 && gameCanvas.gameActorStateReference05.byteValue05 != 4) {
                           return 1;
                        }
                        break;
                     default:
                        return 1;
                  }

                  GameCanvas.gameByteValue07 = 1; goto case 2;
               case 2:
               default:
                  return 1;
            } goto case 550;
         case 550:
            if (gameCanvas.gameByteMatrix02[gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue01][gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue02] == 11) {
               switch (GameCanvas.gameByteValue07) {
                  case 0:
                     if (gameCanvas.gameByteValue19 != 1) {
                        setGameplayMode(true);
                        return 1;
                     }

                     gameCanvas.gameIntegerValue66 = 0;
                     gameCanvas.gameActorStateReference02 = gameCanvas.createActorState(7, 33, 35, 7);
                     gameCanvas.updatePlayerActor();
                     setGameplayMode(false);
                     gameCanvas.moveActorToTile(gameCanvas.gameActorGroupReference01.actorStateReference01, 33, 40);
                     gameCanvas.gameBooleanFlag49 = false;
                     if (gameCanvas.gameActorGroupReference02.byteValue05 == gameCanvas.gameByteValue04
                        && gameCanvas.gameByteMatrix02[gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue01][gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue02]
                           == gameCanvas.gameByteMatrix02[gameCanvas.gameActorGroupReference02.actorStateReference01.byteValue01][gameCanvas.gameActorGroupReference02.actorStateReference01.byteValue02]) {
                        gameCanvas.gameBooleanFlag49 = true;
                        gameCanvas.moveActorToTile(gameCanvas.gameActorGroupReference02.actorStateReference01, 34, 41);
                     }

                     gameCanvas.gameActorGroupReference03.booleanFlag04 = false;
                     gameCanvas.gameActorGroupReference04.booleanFlag04 = false;
                     return 1;
                  case 1:
                     switch (gameCanvas.gameIntegerValue66) {
                        case 0:
                           if (gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue02 < 42) {
                              gameCanvas.gameIntegerValue66++;
                              gameCanvas.deactivateActorRuntimeState(297);
                              gameCanvas.deactivateActorRuntimeState(296);
                              gameCanvas.advanceGameplaySimulation();
                              gameCanvas.moveActorToTile(gameCanvas.gameActorStateReference02, 33, 37);
                           }
                           break;
                        case 1:
                           if (!GameCanvas.isActorDefeated(gameCanvas.gameActorStateReference02) && !isActorAtTile(gameCanvas.gameActorStateReference02, 33, 37)) {
                              gameCanvas.moveActorToTile(gameCanvas.gameActorStateReference02, 33, 37);
                           }

                           if (!GameCanvas.isActorDefeated(gameCanvas.gameActorGroupReference01.actorStateReference01) && !isActorAtTile(gameCanvas.gameActorGroupReference01.actorStateReference01, 33, 40)) {
                              gameCanvas.moveActorToTile(gameCanvas.gameActorGroupReference01.actorStateReference01, 33, 40);
                           }

                           if (gameCanvas.gameBooleanFlag49 && !GameCanvas.isActorDefeated(gameCanvas.gameActorGroupReference02.actorStateReference01) && !isActorAtTile(gameCanvas.gameActorGroupReference02.actorStateReference01, 34, 41)) {
                              gameCanvas.moveActorToTile(gameCanvas.gameActorGroupReference02.actorStateReference01, 34, 41);
                           }

                           if (!GameCanvas.isActorDefeated(gameCanvas.gameActorGroupReference01.actorStateReference01) && isActorAtTile(gameCanvas.gameActorGroupReference01.actorStateReference01, 33, 40)) {
                              GameCanvas.setActorFacingDirection(gameCanvas.gameActorGroupReference01.actorStateReference01, 3);
                           }

                           if (!GameCanvas.isActorDefeated(gameCanvas.gameActorStateReference02) && isActorAtTile(gameCanvas.gameActorStateReference02, 33, 37)) {
                              GameCanvas.setActorFacingDirection(gameCanvas.gameActorStateReference02, 7);
                           }

                           if (gameCanvas.gameBooleanFlag49 && !GameCanvas.isActorDefeated(gameCanvas.gameActorGroupReference02.actorStateReference01) && isActorAtTile(gameCanvas.gameActorGroupReference02.actorStateReference01, 34, 41)) {
                              GameCanvas.setActorFacingDirection(gameCanvas.gameActorGroupReference02.actorStateReference01, 3);
                           }

                           if (!GameCanvas.isActorDefeated(gameCanvas.gameActorGroupReference01.actorStateReference01)
                              && isActorAtTile(gameCanvas.gameActorGroupReference01.actorStateReference01, 33, 40)
                              && !GameCanvas.isActorDefeated(gameCanvas.gameActorStateReference02)
                              && isActorAtTile(gameCanvas.gameActorStateReference02, 33, 37)
                              && (
                                 !gameCanvas.gameBooleanFlag49
                                    || !GameCanvas.isActorDefeated(gameCanvas.gameActorGroupReference02.actorStateReference01) && isActorAtTile(gameCanvas.gameActorGroupReference02.actorStateReference01, 34, 41)
                              )) {
                              gameCanvas.faceActorTowardPosition(gameCanvas.gameActorStateReference02, 8);
                              GameCanvas.setActorFacingDirection(gameCanvas.gameActorStateReference02, 7);
                              gameCanvas.gameIntegerValue66++;
                              gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                              gameCanvas.updateActorDisplayState(gameCanvas.gameActorStateReference02, false);
                           }
                           break;
                        case 2:
                           if (var3 > 500L) {
                              gameCanvas.gameIntegerValue66++;
                              gameCanvas.showGameMessage(0, 4, GameCanvas.getLocalizedText(209), 0);
                           }
                           break;
                        case 3:
                           if (GameCanvas.gameIntegerValue50 != 131) {
                              gameCanvas.gameIntegerValue66++;
                              if (gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue08 == 1) {
                                 gameCanvas.showGameMessage(0, 4, GameCanvas.getLocalizedText(210), 0);
                              } else {
                                 gameCanvas.showGameMessage(0, 4, GameCanvas.getLocalizedText(211), 0);
                              }
                           }
                           break;
                        case 4:
                           if (GameCanvas.gameIntegerValue50 != 131) {
                              gameCanvas.gameIntegerValue66++;
                              if (gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue08 == 1) {
                                 gameCanvas.showGameMessage(0, 1, GameCanvas.getLocalizedText(212), 0);
                              } else {
                                 gameCanvas.showGameMessage(0, 0, GameCanvas.getLocalizedText(213), 0);
                              }
                           }
                           break;
                        case 5:
                           if (GameCanvas.gameIntegerValue50 != 131) {
                              gameCanvas.gameIntegerValue66++;
                              gameCanvas.showGameMessage(0, 4, GameCanvas.getLocalizedText(214), 0);
                           }
                           break;
                        case 6:
                           if (GameCanvas.gameIntegerValue50 != 131) {
                              gameCanvas.gameIntegerValue66++;
                              gameCanvas.showGameMessage(0, 4, GameCanvas.getLocalizedText(215), 0);
                           }
                           break;
                        case 7:
                           if (GameCanvas.gameIntegerValue50 != 131) {
                              gameCanvas.gameIntegerValue66++;
                              gameCanvas.showGameMessage(0, 2, GameCanvas.getLocalizedText(216), 0);
                           }
                           break;
                        case 8:
                           if (GameCanvas.gameIntegerValue50 != 131) {
                              gameCanvas.gameIntegerValue66++;
                              gameCanvas.showGameMessage(0, 4, GameCanvas.getLocalizedText(217), 0);
                           }
                           break;
                        case 9:
                           if (GameCanvas.gameIntegerValue50 != 131) {
                              gameCanvas.gameIntegerValue66++;
                              gameCanvas.showGameMessage(0, 4, GameCanvas.getLocalizedText(218), 0);
                           }
                           break;
                        case 10:
                           if (GameCanvas.gameIntegerValue50 != 131) {
                              gameCanvas.gameIntegerValue66++;
                              gameCanvas.showGameMessage(0, 2, GameCanvas.getLocalizedText(219), 0);
                           }
                           break;
                        case 11:
                           if (GameCanvas.gameIntegerValue50 != 131) {
                              gameCanvas.gameIntegerValue66++;
                              gameCanvas.showGameMessage(0, 4, GameCanvas.getLocalizedText(220), 0);
                           }
                           break;
                        case 12:
                           if (GameCanvas.gameIntegerValue50 != 131) {
                              gameCanvas.gameIntegerValue66++;
                              gameCanvas.showGameMessage(0, 2, GameCanvas.getLocalizedText(221), 0);
                           }
                           break;
                        case 13:
                           if (GameCanvas.gameIntegerValue50 != 131) {
                              gameCanvas.gameIntegerValue66++;
                              gameCanvas.showGameMessage(0, 4, GameCanvas.getLocalizedText(222), 0);
                           }
                           break;
                        case 14:
                           if (GameCanvas.gameIntegerValue50 != 131) {
                              gameCanvas.gameIntegerValue66++;
                              gameCanvas.showGameMessage(0, 2, GameCanvas.getLocalizedText(223), 0);
                           }
                           break;
                        case 15:
                           if (GameCanvas.gameIntegerValue50 != 131) {
                              gameCanvas.gameIntegerValue66++;
                              gameCanvas.faceActorTowardPosition(gameCanvas.gameActorStateReference02, 0);
                              gameCanvas.showGameMessage(0, 4, GameCanvas.getLocalizedText(224), 0);
                           }
                           break;
                        case 16:
                           if (GameCanvas.gameIntegerValue50 != 131) {
                              gameCanvas.gameIntegerValue66++;
                              gameCanvas.showGameMessage(0, 4, GameCanvas.getLocalizedText(225), 0);
                           }
                           break;
                        case 17:
                           GameCanvas.setActorFacingDirection(gameCanvas.gameActorStateReference02, 1);
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                           gameCanvas.gameIntegerValue66++;
                           break;
                        case 18:
                           if (var3 > 1000L) {
                              gameCanvas.gameIntegerValue66++;
                              gameCanvas.showGameMessage(0, 4, GameCanvas.getLocalizedText(226), 0);
                           }
                           break;
                        case 19:
                           if (GameCanvas.gameIntegerValue50 != 131) {
                              gameCanvas.gameIntegerValue66++;
                              gameCanvas.showGameMessage(0, 2, GameCanvas.getLocalizedText(227), 0);
                           }
                           break;
                        case 20:
                           if (GameCanvas.gameIntegerValue50 != 131) {
                              gameCanvas.gameIntegerValue66++;
                              gameCanvas.showGameMessage(0, 4, GameCanvas.getLocalizedText(228), 0);
                           }
                           break;
                        case 21:
                           if (var3 > 1000L) {
                              gameCanvas.gameIntegerValue66++;
                              gameCanvas.showGameMessage(0, 4, GameCanvas.getLocalizedText(229), 0);
                           }
                           break;
                        case 22:
                           if (GameCanvas.gameIntegerValue50 != 131) {
                              gameCanvas.gameIntegerValue66++;
                              gameCanvas.showGameMessage(0, 2, GameCanvas.getLocalizedText(230), 0);
                           }
                           break;
                        case 23:
                           if (GameCanvas.gameIntegerValue50 != 131) {
                              gameCanvas.gameIntegerValue66++;
                              GameCanvas.setActorFacingDirection(gameCanvas.gameActorStateReference02, 7);
                              gameCanvas.showGameMessage(0, 4, GameCanvas.getLocalizedText(231), 0);
                           }
                           break;
                        case 24:
                           if (GameCanvas.gameIntegerValue50 != 131) {
                              gameCanvas.gameIntegerValue66++;
                              gameCanvas.showGameMessage(0, 2, GameCanvas.getLocalizedText(232), 0);
                           }
                           break;
                        case 25:
                           if (GameCanvas.gameIntegerValue50 != 131) {
                              gameCanvas.gameIntegerValue66++;
                              gameCanvas.showGameMessage(0, 4, GameCanvas.getLocalizedText(233), 0);
                           }
                           break;
                        case 26:
                           if (GameCanvas.gameIntegerValue50 != 131) {
                              gameCanvas.gameIntegerValue66++;
                              gameCanvas.showGameMessage(0, 2, GameCanvas.getLocalizedText(234), 0);
                           }
                           break;
                        case 27:
                           if (GameCanvas.gameIntegerValue50 != 131) {
                              gameCanvas.gameIntegerValue66++;
                              gameCanvas.showGameMessage(0, 4, GameCanvas.getLocalizedText(235), 0);
                              gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                           }
                           break;
                        case 28:
                           if (GameCanvas.gameIntegerValue50 != 131) {
                              gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                              gameCanvas.gameIntegerValue66++;
                           }
                           break;
                        case 29:
                           if (var3 > 1000L) {
                              gameCanvas.gameIntegerValue66++;
                              GameCanvas.setActorFacingDirection(gameCanvas.gameActorGroupReference01.actorStateReference01, 1);
                              gameCanvas.showGameMessage(0, 6, GameCanvas.getLocalizedText(236), 0);
                           }
                           break;
                        case 30:
                           if (GameCanvas.gameIntegerValue50 != 131) {
                              gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                              gameCanvas.gameIntegerValue66++;
                           }
                           break;
                        case 31:
                           if (var3 > 1000L) {
                              gameCanvas.gameIntegerValue66 = 34;
                              gameCanvas.showGameMessage(0, 6, GameCanvas.getLocalizedText(237), 0);
                           }
                           break;
                        case 32:
                           if (GameCanvas.gameIntegerValue50 != 131) {
                              gameCanvas.gameIntegerValue66++;
                              gameCanvas.showGameMessage(0, 4, GameCanvas.getLocalizedText(238), 0);
                           }
                           break;
                        case 33:
                           if (GameCanvas.gameIntegerValue50 != 131) {
                              gameCanvas.gameIntegerValue66++;
                              gameCanvas.setActiveActorGroup(38);
                           }
                           break;
                        case 34:
                           if (GameCanvas.gameIntegerValue50 != 131) {
                              gameCanvas.moveActorToTile(gameCanvas.gameActorStateReference02, 33, 35);
                              gameCanvas.gameIntegerValue66++;
                           }
                           break;
                        case 35:
                           if (!GameCanvas.isActorDefeated(gameCanvas.gameActorStateReference02)) {
                              gameCanvas.gameIntegerValue66++;
                              gameCanvas.gameActorStateReference02.booleanFlag01 = false;
                              gameCanvas.gameByteValue17 = 1;
                              gameCanvas.gameByteValue19 = 2;
                              setGameplayMode(true);
                              gameCanvas.updateActorDisplayState(gameCanvas.gameActorGroupReference01.actorStateReference01, false);
                           } break;
                     } goto default;
                  default:
                     return 1;
               }
            }
            break;
         case 560:
            switch (GameCanvas.gameByteValue07) {
               case 0:
                  if (gameCanvas.gameActorGroupReference02.byteValue05 != 1
                     || !isActorAtTile(gameCanvas.gameActorGroupReference02.actorStateReference01, 31, 45) && !isActorAtTile(gameCanvas.gameActorGroupReference02.actorStateReference01, 38, 45)
                     || !gameCanvas.gameActorGroupReference02.entitySnapshotReferenceArray01[36].booleanFlag01 && !gameCanvas.gameActorGroupReference02.entitySnapshotReferenceArray01[37].booleanFlag01) {
                     gameCanvas.showGameMessage(0, gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue08, GameCanvas.getLocalizedText(39), 0);
                     gameCanvas.gameIntegerValue66 = 0;
                  } else {
                     gameCanvas.showGameMessage(0, gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue08, GameCanvas.getLocalizedText(40), 0);
                     gameCanvas.gameIntegerValue66 = 1;
                  }

                  setGameplayMode(false);
                  break;
               case 1:
                  switch (gameCanvas.gameIntegerValue66) {
                     case 0:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           setGameplayMode(true);
                        }
                        break;
                     case 1:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.showGameMessage(0, gameCanvas.gameActorGroupReference02.actorStateReference01.byteValue08, GameCanvas.getLocalizedText(41), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 2:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.showGameMessage(0, gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue08, GameCanvas.getLocalizedText(42), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 3:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.showGameMessage(0, gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue08, GameCanvas.getLocalizedText(43), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 4:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.showGameMessage(0, gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue08, GameCanvas.getLocalizedText(44), 0);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 5:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.deactivateActorRuntimeState(5);
                           gameCanvas.deactivateActorRuntimeState(6);
                           gameCanvas.setActorGroupTargetPosition((sbyte)36, (sbyte)2);
                           gameCanvas.setActorGroupTargetPosition((sbyte)36, (sbyte)1);
                           gameCanvas.setActorGroupTargetPosition((sbyte)37, (sbyte)2);
                           gameCanvas.setActorGroupTargetPosition((sbyte)37, (sbyte)1);
                           setGameplayMode(true);
                           gameCanvas.processActorAction(12);
                        } break;
                  } break;
            }

            return 1;
         case 570:
            switch (GameCanvas.gameByteValue07) {
               case 0:
                  bool var5;
                  if (gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue01 > 31
                     && gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue01 < 34
                     && gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue02 > 32
                     && gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue02 < 36) {
                     var5 = true;
                  } else {
                     var5 = false;
                  }

                  bool var1;
                  if (gameCanvas.gameActorGroupReference02.actorStateReference01.byteValue01 > 31
                     && gameCanvas.gameActorGroupReference02.actorStateReference01.byteValue01 < 34
                     && gameCanvas.gameActorGroupReference02.actorStateReference01.byteValue02 > 32
                     && gameCanvas.gameActorGroupReference02.actorStateReference01.byteValue02 < 36) {
                     var1 = true;
                  } else {
                     var1 = false;
                  }

                  if (!var5 && !var1) {
                     setGameplayMode(true);
                     return 1;
                  }

                  if (gameCanvas.gameActorStateReference04.byteValue05 != 3 && gameCanvas.gameActorStateReference04.byteValue05 != 4) {
                     if (var5) {
                        gameCanvas.moveActorToTile(gameCanvas.gameActorGroupReference01.actorStateReference01, 33, 33);
                        gameCanvas.gameIntegerValue66 = 0;
                     } else {
                        gameCanvas.updateActorDisplayState(gameCanvas.gameActorGroupReference02.actorStateReference01, true);
                        gameCanvas.moveActorToTile(gameCanvas.gameActorGroupReference02.actorStateReference01, 33, 33);
                        gameCanvas.gameIntegerValue66 = 2;
                     }

                     setGameplayMode(false);
                     return 1;
                  }

                  setGameplayMode(true);
                  return 1;
               case 1:
                  switch (gameCanvas.gameIntegerValue66) {
                     case 0:
                        if (isActorAtTile(gameCanvas.gameActorGroupReference01.actorStateReference01, 33, 33)) {
                           setActorTilePosition(gameCanvas.gameActorStateReference04, 33, 34);
                           gameCanvas.faceActorTowardPosition(gameCanvas.gameActorGroupReference01.actorStateReference01, 4);
                           GameCanvas.setActorFacingDirection(gameCanvas.gameActorStateReference04, 7);
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.processActorAction(gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue08 == 0 ? 9 : 18);
                        }
                        break;
                     case 1:
                        gameCanvas.findEntityFrameData(0, gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue01, gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue02, 54, 2);
                        gameCanvas.setActorStatus(gameCanvas.gameActorGroupReference01.actorStateReference01, -50);
                        setGameplayMode(true);
                        break;
                     case 2:
                        if (isActorAtTile(gameCanvas.gameActorGroupReference02.actorStateReference01, 33, 33)) {
                           setActorTilePosition(gameCanvas.gameActorStateReference04, 33, 34);
                           gameCanvas.faceActorTowardPosition(gameCanvas.gameActorGroupReference02.actorStateReference01, 4);
                           GameCanvas.setActorFacingDirection(gameCanvas.gameActorStateReference04, 7);
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 3:
                        gameCanvas.findEntityFrameData(0, gameCanvas.gameActorGroupReference02.actorStateReference01.byteValue01, gameCanvas.gameActorGroupReference02.actorStateReference01.byteValue02, 54, 2);
                        gameCanvas.setActorStatus(gameCanvas.gameActorGroupReference02.actorStateReference01, -50);
                        setGameplayMode(true); break;
                  }

                  return 1;
               default:
                  return 0;
            } goto case 580;
         case 580:
            switch (GameCanvas.gameByteValue07) {
               case 0:
                  if (gameCanvas.gameByteValue20 < 0) {
                     gameCanvas.deactivateActorRuntimeState(297);
                     gameCanvas.deactivateActorRuntimeState(296);
                     gameCanvas.gameClass19ReferenceArray02[GameCanvas.gameByteValue10].booleanFlag02 = true;
                     setGameplayMode(true);
                     gameCanvas.processActorAction(12);
                  } else {
                     gameCanvas.showGameMessage(0, gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue08, GameCanvas.getLocalizedText(38), 0);
                     setGameplayMode(false);
                  }

                  return 1;
               case 1:
                  if (GameCanvas.gameIntegerValue50 != 131) {
                     gameCanvas.gameClass19ReferenceArray02[GameCanvas.gameByteValue10].booleanFlag02 = false;
                     setGameplayMode(true);
                  } goto default;
               default:
                  return 1;
            } goto case 590;
         case 590:
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
                        setGameplayMode(true);
                        break;
                     }

                     gameCanvas.showGameMessage(0, 1, GameCanvas.getLocalizedText(160), 0);
                  }

                  setGameplayMode(false);
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
                        setGameplayMode(true);
                     }
                  } break;
            }

            return 1;
         case 600:
            if (GameCanvas.gameByteValue07 == 0) {
               gameCanvas.setActiveActorGroupDirection((sbyte)28);
               gameCanvas.gameByteValue23 = (sbyte)(gameCanvas.gameByteValue23 | 1);
               gameCanvas.updateActorBehavior();
               setGameplayMode(false);
            } else if (GameCanvas.gameIntegerValue50 != 131) {
               setGameplayMode(true);
            }

            return 1;
         case 610:
            if (GameCanvas.gameByteValue07 == 0) {
               gameCanvas.setActiveActorGroupDirection((sbyte)30);
               gameCanvas.gameByteValue23 = (sbyte)(gameCanvas.gameByteValue23 | 2);
               gameCanvas.updateActorBehavior();
               setGameplayMode(false);
            } else if (GameCanvas.gameIntegerValue50 != 131) {
               setGameplayMode(true);
            }

            return 1;
         case 620:
            if (GameCanvas.gameByteValue07 == 0) {
               gameCanvas.setActiveActorGroupDirection((sbyte)29);
               gameCanvas.gameByteValue23 = (sbyte)(gameCanvas.gameByteValue23 | 4);
               gameCanvas.updateActorBehavior();
               setGameplayMode(false);
            } else if (GameCanvas.gameIntegerValue50 != 131) {
               setGameplayMode(true);
            }

            return 1;
         case 630:
            switch (GameCanvas.gameByteValue07) {
               case 0:
                  if (gameCanvas.gameByteValue20 > -1) {
                     setGameplayMode(true);
                     return 1;
                  }

                  if (!gameCanvas.gameActorGroupReference01.entitySnapshotReferenceArray01[18].booleanFlag01) {
                     gameCanvas.showGameMessage(0, 2, GameCanvas.getLocalizedText(92), 0);
                     setGameplayMode(true);
                     return 1;
                  }

                  gameCanvas.gameIntegerValue66 = 0;
                  setGameplayMode(false);
                  return 1;
               case 1:
                  switch (gameCanvas.gameIntegerValue66) {
                     case 0:
                        gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue09 = 127;
                        gameCanvas.faceActorTowardPosition(gameCanvas.gameActorGroupReference01.actorStateReference01, 11);
                        GameCanvas.setActorFacingDirection(gameCanvas.gameActorGroupReference01.actorStateReference01, 5);
                        gameCanvas.showGameMessage(0, 2, GameCanvas.getLocalizedText(36), 0);
                        gameCanvas.gameIntegerValue66++;
                        break;
                     case 1:
                        if (GameCanvas.gameIntegerValue50 != 131) {
                           gameCanvas.updateActorDisplayState(gameCanvas.gameActorStateReference04, false);
                           gameCanvas.setActiveActorGroupDirection((sbyte)22);
                           gameCanvas.setActiveActorGroupDirection((sbyte)18);
                           gameCanvas.findActorRuntimeState(
                              8,
                              gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue01,
                              gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue02,
                              gameCanvas.gameActorStateReference04.byteValue01,
                              gameCanvas.gameActorStateReference04.byteValue02,
                              (sbyte)5
                           );
                           gameCanvas.gameIntegerValue64 = gameCanvas.gameActorStateReference04.byteValue01;
                           gameCanvas.gameIntegerValue65 = gameCanvas.gameActorStateReference04.byteValue02;
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 2:
                        if (!gameCanvas.gameClass22ReferenceArray01[0].booleanFlag01) {
                           gameCanvas.faceActorTowardPosition(gameCanvas.gameActorStateReference04, 3);
                           gameCanvas.gameIntegerValue66++;
                           gameCanvas.processActorAction(13);
                        }
                        break;
                     case 3:
                        if (gameCanvas.gameActorStateReference04.byteValue05 == 3) {
                           gameCanvas.updateActorDisplayState(gameCanvas.gameActorGroupReference01.actorStateReference01, true);
                           gameCanvas.gameLongValue08 = gameCanvas.gameLongValue06;
                           gameCanvas.gameIntegerValue66++;
                        }
                        break;
                     case 4:
                        if (var3 > 1000L) {
                           gameCanvas.faceActorTowardPosition(gameCanvas.gameActorGroupReference01.actorStateReference01, 0);
                           gameCanvas.deactivateActorRuntimeState(134);
                           gameCanvas.deactivateActorRuntimeState(80);
                           gameCanvas.gameClass19ReferenceArray02[GameCanvas.gameByteValue10].booleanFlag02 = true;
                           setGameplayMode(true);
                        } break;
                  }

                  return 1;
               default:
                  return 1;
            } goto case 810;
         case 810:
            if (gameCanvas.gameByteMatrix02[gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue01][gameCanvas.gameActorGroupReference01.actorStateReference01.byteValue02]
                  != gameCanvas.gameByteMatrix02[gameCanvas.gameClass9ReferenceArray01[281].byteValue02][gameCanvas.gameClass9ReferenceArray01[281].byteValue03]
               && gameCanvas.gameByteValue16 == 0) {
               gameCanvas.initializeActorStates(false);
            }

            gameCanvas.deactivateActorRuntimeState(3);
            setGameplayMode(true);
            gameCanvas.processActorAction(12);
            return 1;
         case 830:
            switch (GameCanvas.gameByteValue07) {
               case 0:
                  if (gameCanvas.gameByteValue20 > -1) {
                     gameCanvas.showGameMessage(0, 2, GameCanvas.getLocalizedText(75), 0);
                  } else {
                     gameCanvas.showGameMessage(0, 2, GameCanvas.getLocalizedText(76), 0);
                  }

                  setGameplayMode(false);
                  break;
               case 1:
                  if (GameCanvas.gameIntegerValue50 != 131) {
                     setGameplayMode(true);
                  } break;
            }

            return 1;
      }

      return 0;
   }
}
}
