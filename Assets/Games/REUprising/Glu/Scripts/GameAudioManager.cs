// Transpiled from Java (GameAudioManager.java) by Tools/J2meToCs. Regenerate rather than hand-edit where possible.
#pragma warning disable CS0162, CS0164, CS0168, CS0169, CS0219, CS0414, CS0649, CS1717, CS0108, CS0659, CS0661
using J2ME;

namespace REUprising.Glu
{
// $VF: renamed from: e
public class GameAudioManager : PlayerListener, IAudioCommandSink {
   static GameAudioManager() { }

   // $VF: renamed from: a javax.microedition.media.Player[]
   public Player[] players;
   // $VF: renamed from: b java.lang.String[]
   public static string[] audioMimeTypes = new string[]{"audio/midi", "audio/x-wav", "audio/amr", "audio/mp3"};
   // $VF: renamed from: c java.lang.String[]
   public static string[] audioFileExtensions = new string[]{".mid", ".wav", ".amr", ".mp3"};
   // $VF: renamed from: d byte[]
   public sbyte[] soundFormatByCue;
   // $VF: renamed from: e byte[]
   public sbyte[] soundLoopCounts;
   // $VF: renamed from: f byte[]
   public sbyte[] soundResourceIds;
   // $VF: renamed from: g byte[]
   public sbyte[] playerSlotByCue;
   // $VF: renamed from: h byte[]
   public sbyte[] soundVolumeLevels;
   // $VF: renamed from: i byte[]
   public sbyte[] activeCueByPlayer;
   // $VF: renamed from: j byte
   public sbyte lastQueuedCue = -1;
   // $VF: renamed from: k byte[]
   public sbyte[] pendingAudioCommands;
   // $VF: renamed from: l byte
   public sbyte lastQueuedCommandIndex;
   // $VF: renamed from: m boolean
   public bool isAudioPaused;
   // $VF: renamed from: n byte
   public sbyte commandDelayTicks;
   // $VF: renamed from: o byte
   public sbyte masterVolume;
   // $VF: renamed from: p boolean
   public bool isCommandQueueEnabled = true;
   // $VF: renamed from: q int
   public static int playerStateWaitLimit = 10;
   // $VF: renamed from: r int
   public static int audioCommandDelayLimit = 2;

   public GameAudioManager(int var1, int var2, int var3) {
      this.players = new Player[var1];
      this.activeCueByPlayer = new sbyte[var1];
      this.playerSlotByCue = new sbyte[var2];
      this.soundLoopCounts = new sbyte[var2];
      this.soundVolumeLevels = new sbyte[var2];
      this.pendingAudioCommands = new sbyte[var3];
      this.clearAudioQueue();
   }

   // $VF: renamed from: a (byte[], byte[], byte[], byte[]) void
   public void configureCueMetadata(sbyte[] var1, sbyte[] var2, sbyte[] var3, sbyte[] var4) {
      this.soundFormatByCue = var1;
      this.soundResourceIds = var2;
      this.playerSlotByCue = var3;
      this.soundLoopCounts = var4;
   }

   // $VF: renamed from: a () void
   public void processNextAudioCommand() {
      if (!this.isAudioPaused) {
         if (--this.commandDelayTicks <= 0) {
            this.commandDelayTicks = 0;
            if (this.lastQueuedCommandIndex >= 0 && this.pendingAudioCommands[0] == 63) {
               this.dequeueAudioCommand();
               this.disposeAllPlayers();
            } else if (this.lastQueuedCommandIndex >= 0 && this.pendingAudioCommands[0] >= 64) {
               this.stopCuePlayback((sbyte)(this.dequeueAudioCommand() - 64));
            } else {
               if (this.lastQueuedCommandIndex >= 0 && !this.isPlayerPrefetched(this.pendingAudioCommands[0])) {
                  this.playCue(this.dequeueAudioCommand());
               }
            }
         }
      }
   }

   // $VF: renamed from: a (byte) void
   public void enqueueAudioCommand(sbyte var1) {
      this.lastQueuedCommandIndex = (sbyte)(this.lastQueuedCommandIndex + 1 > this.pendingAudioCommands.Length - 1 ? this.pendingAudioCommands.Length - 1 : this.lastQueuedCommandIndex + 1);
      this.pendingAudioCommands[this.lastQueuedCommandIndex] = var1;
   }

   // $VF: renamed from: b (byte) void
   public void requestCuePlayback(sbyte var1) {
      if (!this.isCuePlaying(var1)) {
         this.enqueueAudioCommand(var1);
      }
   }

   // $VF: renamed from: b () void
   public void clearAudioQueue() {
      for (int var1 = 0; var1 < this.pendingAudioCommands.Length; var1++) {
         this.pendingAudioCommands[var1] = -1;
      }

      this.lastQueuedCommandIndex = -1;
   }

   // $VF: renamed from: c () void
   public void disposeAllPlayers() {
      for (int var1 = 0; var1 < this.players.Length; var1++) {
         if (this.players[var1] != null) {
            this.stopPlayer(var1);
         }
      }

      this.clearAudioQueue();
      this.lastQueuedCue = -1;
   }

   // $VF: renamed from: c (byte) void
   public void stopCuePlayback(sbyte var1) {
      this.stopPlayer(this.playerSlotByCue[var1]);
   }

   // $VF: renamed from: a (byte[]) void
   public void setCueVolumeLevels(sbyte[] var1) {
      this.soundVolumeLevels = var1;
   }

   // $VF: renamed from: d (byte) void
   public void setMasterVolume(sbyte var1) {
      this.masterVolume = var1;
   }

   // $VF: renamed from: a (int) void
   public void stopPlayer(int var1) {
      try {
         if (this.players[var1] != null && this.players[var1].getState() != 0) {
            this.players[var1].stop();

            for (int var2 = 0; var2 <= playerStateWaitLimit && this.players[var1].getState() == 400; var2++) {
               Thread.sleep(1L);
            }
         }
      } catch (System.Exception var3) {
      }
   }

   // $VF: renamed from: d () byte
   public sbyte dequeueAudioCommand() {
      sbyte var1 = this.pendingAudioCommands[0];

      for (int var2 = 0; var2 < this.pendingAudioCommands.Length - 1; var2++) {
         this.pendingAudioCommands[var2] = this.pendingAudioCommands[var2 + 1];
      }

      this.pendingAudioCommands[this.pendingAudioCommands.Length - 1] = -1;
      this.lastQueuedCommandIndex = (sbyte)(this.lastQueuedCommandIndex - 1 < -1 ? -1 : this.lastQueuedCommandIndex - 1);
      return var1;
   }

   // $VF: renamed from: e (byte) void
   public void playCue(sbyte var1) {
      try {
         if (!this.prepareCuePlayer(var1) && this.isCommandQueueEnabled) {
            this.enqueueAudioCommand(var1);
            return;
         }

         this.applyCueVolume(var1);
         if (!this.startPreparedCue(var1) && this.isCommandQueueEnabled) {
            this.enqueueAudioCommand(var1);
            return;
         }
      } catch (System.Exception var3) {
      }
   }

   // $VF: renamed from: b (int) boolean
   public bool prepareCuePlayer(int var1) {
      try {
         if (this.players[this.playerSlotByCue[var1]] != null && var1 == this.activeCueByPlayer[this.playerSlotByCue[var1]]) {
         }

         if (this.players[this.playerSlotByCue[var1]] != null) {
            this.players[this.playerSlotByCue[var1]].close();
         }

         this.players[this.playerSlotByCue[var1]] = null;
         JSystem.gc();
         Thread.sleep(1L);
         this.players[this.playerSlotByCue[var1]] = this.createPlayer(
            "/snd/" + this.soundResourceIds[var1] + "" + audioFileExtensions[this.soundFormatByCue[var1]], audioMimeTypes[this.soundFormatByCue[var1]]
         );
         this.players[this.playerSlotByCue[var1]].realize();

         for (int var2 = 0; var2 <= playerStateWaitLimit && this.players[this.playerSlotByCue[var1]].getState() != 200; var2++) {
            if (var2 == playerStateWaitLimit) {
               return false;
            }

            Thread.sleep(1L);
         }

         this.players[this.playerSlotByCue[var1]].prefetch();
         return true;
      } catch (System.Exception var3) {
         return false;
      }
   }

   // $VF: renamed from: c (int) void
   public void applyCueVolume(int var1) {
      VolumeControl var2 = (VolumeControl)this.players[this.playerSlotByCue[var1]].getControl("VolumeControl");
      var2.setLevel(this.soundVolumeLevels[var1] * this.masterVolume / 100);
   }

   // $VF: renamed from: f (byte) boolean
   public bool startPreparedCue(sbyte var1) {
      try {
         if (this.soundLoopCounts[var1] != 1) {
            this.players[this.playerSlotByCue[var1]].setLoopCount(this.soundLoopCounts[var1]);
         }

         this.players[this.playerSlotByCue[var1]].start();
         this.activeCueByPlayer[this.playerSlotByCue[var1]] = var1;
         if (this.soundLoopCounts[var1] != 1) {
            this.lastQueuedCue = var1;
         }

         return true;
      } catch (System.Exception var3) {
         return false;
      }
   }

   // $VF: renamed from: d (int) boolean
   public bool isCuePlaying(int var1) {
      return this.isPlayerPrefetched(var1) && this.activeCueByPlayer[this.playerSlotByCue[var1]] == var1;
   }

   // $VF: renamed from: a (java.lang.String, java.lang.String) javax.microedition.media.Player
   public Player createPlayer(string var1, string var2) {
      try {
         return Manager.createPlayer(this.getClass().getResourceAsStream(var1), var2);
      } catch (System.Exception var4) {
         return null;
      }
   }

   // $VF: renamed from: e (int) boolean
   public bool isPlayerPrefetched(int var1) {
      return this.players[this.playerSlotByCue[var1]] != null && this.players[this.playerSlotByCue[var1]].getState() == 400;
   }

   // $VF: renamed from: a (javax.microedition.media.Player) byte
   public sbyte findPlayerSlot(Player var1) {
      for (sbyte var2 = 0; var2 < this.players.Length; var2++) {
         if (this.players[var2] == var1) {
            return var2;
         }
      }

      return -1;
   }

   public void playerUpdate(Player var1, string var2, object var3) {
      try {
         if (var2 == "endOfMedia") {
            sbyte var4 = this.findPlayerSlot(var1);
            if (var4 != -1) {
               this.enqueueAudioCommand(this.activeCueByPlayer[var4]);
            }
         }
      } catch (System.Exception var5) {
      }
   }

   // alias for obfuscated name 'a'
   public void a(sbyte[] var1, sbyte[] var2, sbyte[] var3, sbyte[] var4) { configureCueMetadata(var1, var2, var3, var4); }

   // alias for obfuscated name 'a'
   public void a() { processNextAudioCommand(); }

   // alias for obfuscated name 'a'
   public void a(sbyte var1) { enqueueAudioCommand(var1); }

   // alias for obfuscated name 'b'
   public void b(sbyte var1) { requestCuePlayback(var1); }

   // alias for obfuscated name 'b'
   public void b() { clearAudioQueue(); }

   // alias for obfuscated name 'c'
   public void c() { disposeAllPlayers(); }

   // alias for obfuscated name 'c'
   public void c(sbyte var1) { stopCuePlayback(var1); }

   // alias for obfuscated name 'a'
   public void a(sbyte[] var1) { setCueVolumeLevels(var1); }

   // alias for obfuscated name 'd'
   public void d(sbyte var1) { setMasterVolume(var1); }

   // alias for obfuscated name 'a'
   public void a(int var1) { stopPlayer(var1); }

   // alias for obfuscated name 'd'
   public sbyte d() { return dequeueAudioCommand(); }

   // alias for obfuscated name 'e'
   public void e(sbyte var1) { playCue(var1); }

   // alias for obfuscated name 'b'
   public bool b(int var1) { return prepareCuePlayer(var1); }

   // alias for obfuscated name 'c'
   public void c(int var1) { applyCueVolume(var1); }

   // alias for obfuscated name 'f'
   public bool f(sbyte var1) { return startPreparedCue(var1); }

   // alias for obfuscated name 'd'
   public bool d(int var1) { return isCuePlaying(var1); }

   // alias for obfuscated name 'a'
   public Player a(string var1, string var2) { return createPlayer(var1, var2); }

   // alias for obfuscated name 'e'
   public bool e(int var1) { return isPlayerPrefetched(var1); }

   // alias for obfuscated name 'a'
   public sbyte a(Player var1) { return findPlayerSlot(var1); }
}
}
