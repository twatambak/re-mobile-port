import javax.microedition.media.Manager;
import javax.microedition.media.Player;
import javax.microedition.media.PlayerListener;
import javax.microedition.media.control.VolumeControl;

// $VF: renamed from: e
public class class_15 implements PlayerListener, class_1 {
   // $VF: renamed from: a javax.microedition.media.Player[]
   private Player[] field_103;
   // $VF: renamed from: b java.lang.String[]
   private static final String[] field_104 = new String[]{"audio/midi", "audio/x-wav", "audio/amr", "audio/mp3"};
   // $VF: renamed from: c java.lang.String[]
   private static final String[] field_105 = new String[]{".mid", ".wav", ".amr", ".mp3"};
   // $VF: renamed from: d byte[]
   private byte[] field_106;
   // $VF: renamed from: e byte[]
   private byte[] field_107;
   // $VF: renamed from: f byte[]
   private byte[] field_108;
   // $VF: renamed from: g byte[]
   private byte[] field_109;
   // $VF: renamed from: h byte[]
   private byte[] field_110;
   // $VF: renamed from: i byte[]
   private byte[] field_111;
   // $VF: renamed from: j byte
   private byte field_112 = -1;
   // $VF: renamed from: k byte[]
   private byte[] field_113;
   // $VF: renamed from: l byte
   private byte field_114;
   // $VF: renamed from: m boolean
   private boolean field_115;
   // $VF: renamed from: n byte
   private byte field_116;
   // $VF: renamed from: o byte
   private byte field_117;
   // $VF: renamed from: p boolean
   private boolean field_118 = true;
   // $VF: renamed from: q int
   private static int field_119 = 10;
   // $VF: renamed from: r int
   private static int field_120 = 2;

   public class_15(int var1, int var2, int var3) {
      this.field_103 = new Player[var1];
      this.field_111 = new byte[var1];
      this.field_109 = new byte[var2];
      this.field_107 = new byte[var2];
      this.field_110 = new byte[var2];
      this.field_113 = new byte[var3];
      this.method_47();
   }

   // $VF: renamed from: a (byte[], byte[], byte[], byte[]) void
   public void method_11(byte[] var1, byte[] var2, byte[] var3, byte[] var4) {
      this.field_106 = var1;
      this.field_108 = var2;
      this.field_109 = var3;
      this.field_107 = var4;
   }

   // $VF: renamed from: a () void
   public void method_16() {
      if (!this.field_115) {
         if (--this.field_116 <= 0) {
            this.field_116 = 0;
            if (this.field_114 >= 0 && this.field_113[0] == 63) {
               this.method_49();
               this.method_17();
            } else if (this.field_114 >= 0 && this.field_113[0] >= 64) {
               this.method_18((byte)(this.method_49() - 64));
            } else {
               if (this.field_114 >= 0 && !this.method_56(this.field_113[0])) {
                  this.method_50(this.method_49());
               }
            }
         }
      }
   }

   // $VF: renamed from: a (byte) void
   public void method_14(byte var1) {
      this.field_114 = (byte)(this.field_114 + 1 > this.field_113.length - 1 ? this.field_113.length - 1 : this.field_114 + 1);
      this.field_113[this.field_114] = var1;
   }

   // $VF: renamed from: b (byte) void
   public void method_15(byte var1) {
      if (!this.method_54(var1)) {
         this.method_14(var1);
      }
   }

   // $VF: renamed from: b () void
   public void method_47() {
      for (int var1 = 0; var1 < this.field_113.length; var1++) {
         this.field_113[var1] = -1;
      }

      this.field_114 = -1;
   }

   // $VF: renamed from: c () void
   public void method_17() {
      for (int var1 = 0; var1 < this.field_103.length; var1++) {
         if (this.field_103[var1] != null) {
            this.method_48(var1);
         }
      }

      this.method_47();
      this.field_112 = -1;
   }

   // $VF: renamed from: c (byte) void
   public void method_18(byte var1) {
      this.method_48(this.field_109[var1]);
   }

   // $VF: renamed from: a (byte[]) void
   public void method_12(byte[] var1) {
      this.field_110 = var1;
   }

   // $VF: renamed from: d (byte) void
   public void method_13(byte var1) {
      this.field_117 = var1;
   }

   // $VF: renamed from: a (int) void
   private void method_48(int var1) {
      try {
         if (this.field_103[var1] != null && this.field_103[var1].getState() != 0) {
            this.field_103[var1].stop();

            for (int var2 = 0; var2 <= field_119 && this.field_103[var1].getState() == 400; var2++) {
               Thread.sleep(1L);
            }
         }
      } catch (Exception var3) {
      }
   }

   // $VF: renamed from: d () byte
   private byte method_49() {
      byte var1 = this.field_113[0];

      for (int var2 = 0; var2 < this.field_113.length - 1; var2++) {
         this.field_113[var2] = this.field_113[var2 + 1];
      }

      this.field_113[this.field_113.length - 1] = -1;
      this.field_114 = (byte)(this.field_114 - 1 < -1 ? -1 : this.field_114 - 1);
      return var1;
   }

   // $VF: renamed from: e (byte) void
   private void method_50(byte var1) {
      try {
         if (!this.method_51(var1) && this.field_118) {
            this.method_14(var1);
            return;
         }

         this.method_52(var1);
         if (!this.method_53(var1) && this.field_118) {
            this.method_14(var1);
            return;
         }
      } catch (Exception var3) {
      }
   }

   // $VF: renamed from: b (int) boolean
   private boolean method_51(int var1) {
      try {
         if (this.field_103[this.field_109[var1]] != null && var1 == this.field_111[this.field_109[var1]]) {
         }

         if (this.field_103[this.field_109[var1]] != null) {
            this.field_103[this.field_109[var1]].close();
         }

         this.field_103[this.field_109[var1]] = null;
         System.gc();
         Thread.sleep(1L);
         this.field_103[this.field_109[var1]] = this.method_55(
            "/snd/" + this.field_108[var1] + "" + field_105[this.field_106[var1]], field_104[this.field_106[var1]]
         );
         this.field_103[this.field_109[var1]].realize();

         for (int var2 = 0; var2 <= field_119 && this.field_103[this.field_109[var1]].getState() != 200; var2++) {
            if (var2 == field_119) {
               return false;
            }

            Thread.sleep(1L);
         }

         this.field_103[this.field_109[var1]].prefetch();
         return true;
      } catch (Exception var3) {
         return false;
      }
   }

   // $VF: renamed from: c (int) void
   private void method_52(int var1) {
      VolumeControl var2 = (VolumeControl)this.field_103[this.field_109[var1]].getControl("VolumeControl");
      var2.setLevel(this.field_110[var1] * this.field_117 / 100);
   }

   // $VF: renamed from: f (byte) boolean
   private boolean method_53(byte var1) {
      try {
         if (this.field_107[var1] != 1) {
            this.field_103[this.field_109[var1]].setLoopCount(this.field_107[var1]);
         }

         this.field_103[this.field_109[var1]].start();
         this.field_111[this.field_109[var1]] = var1;
         if (this.field_107[var1] != 1) {
            this.field_112 = var1;
         }

         return true;
      } catch (Exception var3) {
         return false;
      }
   }

   // $VF: renamed from: d (int) boolean
   private boolean method_54(int var1) {
      return this.method_56(var1) && this.field_111[this.field_109[var1]] == var1;
   }

   // $VF: renamed from: a (java.lang.String, java.lang.String) javax.microedition.media.Player
   public Player method_55(String var1, String var2) {
      try {
         return Manager.createPlayer(this.getClass().getResourceAsStream(var1), var2);
      } catch (Exception var4) {
         return null;
      }
   }

   // $VF: renamed from: e (int) boolean
   private boolean method_56(int var1) {
      return this.field_103[this.field_109[var1]] != null && this.field_103[this.field_109[var1]].getState() == 400;
   }

   // $VF: renamed from: a (javax.microedition.media.Player) byte
   private byte method_57(Player var1) {
      for (byte var2 = 0; var2 < this.field_103.length; var2++) {
         if (this.field_103[var2] == var1) {
            return var2;
         }
      }

      return -1;
   }

   public void playerUpdate(Player var1, String var2, Object var3) {
      try {
         if (var2 == "endOfMedia") {
            byte var4 = this.method_57(var1);
            if (var4 != -1) {
               this.method_14(this.field_111[var4]);
            }
         }
      } catch (Exception var5) {
      }
   }
}
