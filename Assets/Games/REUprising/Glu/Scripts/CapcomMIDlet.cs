// Transpiled from Java (CapcomMIDlet.java) by Tools/J2meToCs. Regenerate rather than hand-edit where possible.
#pragma warning disable CS0162, CS0164, CS0168, CS0169, CS0219, CS0414, CS0649, CS1717, CS0108, CS0659, CS0661
using J2ME;

namespace REUprising.Glu
{
public abstract class CapcomMIDlet : MIDlet {
   static CapcomMIDlet() { }

   // $VF: renamed from: g w
   public GameCanvas gameCanvas;
   // $VF: renamed from: h boolean
   public bool hasStarted;
   // $VF: renamed from: a int
   public static int canvasHeight;
   // $VF: renamed from: b int
   public static int canvasWidth;
   // $VF: renamed from: c java.lang.String
   public static string mobileAdvertisingEnabled;
   // $VF: renamed from: d java.lang.String
   public static string mobileAdvertisingUrl;
   // $VF: renamed from: e boolean
   public static bool cheatsEnabled = false;
   // $VF: renamed from: f java.lang.String
   public static string buildIdentifier = "";

   // $VF: renamed from: a () m
   public abstract IGameScreenController createGameScreenController();

   public CapcomMIDlet() {
      canvasHeight = Integer.parseInt(this.getAppProperty("Glu-Canvas-Height"));
      canvasWidth = Integer.parseInt(this.getAppProperty("Glu-Canvas-Width"));

      try {
         mobileAdvertisingEnabled = this.getAppProperty("Glu-GMG-Enable");
         if (mobileAdvertisingEnabled.equals("true")) {
            mobileAdvertisingUrl = this.getAppProperty("Glu-GMG-URL");
         }
      } catch (System.Exception var2) {
      }

      this.gameCanvas = new GameCanvas(this);
      this.gameCanvas.attachScreenController(this.createGameScreenController(), 30);
   }

   public override void startApp() {
      try {
         cheatsEnabled = this.getAppProperty("Glu-Cheats-Enable").toLowerCase().equals("true");
      } catch (System.Exception var3) {
      }

      try {
         buildIdentifier = "RESEVIL5_20091124-1000_J";
      } catch (System.Exception var2) {
         buildIdentifier = "BUILD NOT TAGGED";
      }

      if (!this.hasStarted) {
         this.hasStarted = true;
         Display.getDisplay(this).setCurrent(this.gameCanvas);
         Thread var1 = new Thread(this.gameCanvas);
         var1.start();
      }
   }

   public override void pauseApp() {
      this.gameCanvas.hideNotify();
   }

   public override void destroyApp(bool var1) {
   }

   // $VF: renamed from: b () void
   public void shutdownMidlet() {
      try {
         this.gameCanvas = null;
         this.destroyApp(true);
         this.notifyDestroyed();
      } catch (MIDletStateChangeException var2) {
      }
   }

   // alias for obfuscated name 'a'
   public IGameScreenController a() { return createGameScreenController(); }

   // alias for obfuscated name 'b'
   public void b() { shutdownMidlet(); }
}
}
