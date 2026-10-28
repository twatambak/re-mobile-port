// Transpiled from Java (GameController.java) by Tools/J2meToCs. Regenerate rather than hand-edit where possible.
#pragma warning disable CS0162, CS0164, CS0168, CS0169, CS0219, CS0414, CS0649, CS1717, CS0108, CS0659, CS0661
using J2ME;

namespace REUprising.Glu
{
// $VF: renamed from: c
public class GameController : IGameScreenController {
   static GameController() { }

   // $VF: renamed from: a boolean
   public bool isCheatModeEnabled = false;
   // $VF: renamed from: b boolean
   public bool gameFlagA = false;
   // $VF: renamed from: c byte
   public sbyte gameByteStateA = 0;
   // $VF: renamed from: bl com.capcomeuro.midp.CapcomMIDlet
   public CapcomMIDlet midlet;
   // $VF: renamed from: bm w
   public GameCanvas gameCanvas;
   // $VF: renamed from: bn p
   public BitmapFontRenderer fontRenderer;
   // $VF: renamed from: bo o
   public IAudioCommandSink audioCommandSink;
   // $VF: renamed from: bp javax.microedition.lcdui.Image
   public Image capcomLogoImage = null;
   // $VF: renamed from: bq javax.microedition.lcdui.Image[]
   public Image[] characterPortraitImages = null;
   // $VF: renamed from: br java.lang.String[]
   public string[] localizedText;
   // $VF: renamed from: bs java.lang.String[][]
   public string[][] startupTextByLanguage;
   // $VF: renamed from: bt byte
   public sbyte localizedTextVariant = 1;
   // $VF: renamed from: bu byte[]
   public sbyte[] audioFadeLevels = new sbyte[]{0, 20, 40, 60, 80, 100};
   // $VF: renamed from: bv byte[]
   public sbyte[] portraitImageIndices = new sbyte[2];
   // $VF: renamed from: bw java.lang.String
   public string pendingMessage = null;
   // $VF: renamed from: bx int
   public int updateTickCount = 0;
   // $VF: renamed from: by int
   public int renderTickCount = 0;
   // $VF: renamed from: d int
   public static int canvasHeight;
   // $VF: renamed from: e int
   public static int canvasWidth;
   // $VF: renamed from: f int
   public static int canvasCenterX;
   // $VF: renamed from: g int
   public static int canvasCenterY;
   // $VF: renamed from: h boolean
   public bool isScreenInitialized = false;
   // $VF: renamed from: i boolean
   public bool hasScreenStarted = false;
   // $VF: renamed from: bz boolean
   public bool isGameScreenActive = true;
   // $VF: renamed from: bA byte
   public sbyte gameByteStateB = 0;
   // $VF: renamed from: bB byte
   public sbyte gameByteStateC = 0;
   // $VF: renamed from: bC byte
   public sbyte gameByteStateD = 0;
   // $VF: renamed from: bD java.util.Random
   public static Random sharedRandom = new Random();
   // $VF: renamed from: bE boolean
   public bool isAudioDisposed;
   // $VF: renamed from: bF boolean
   public bool isGameAssetsLoaded = false;
   // $VF: renamed from: bG byte
   public sbyte currentControlKey = -1;
   // $VF: renamed from: bH byte
   public sbyte portraitControlKey = 0;
   // $VF: renamed from: bI byte
   public sbyte landscapeControlKey = 1;
   // $VF: renamed from: bJ int
   public int gameIntegerStateA;
   // $VF: renamed from: bK int
   public int gameIntegerStateB;
   // $VF: renamed from: bL int
   public int gameIntegerStateC;
   // $VF: renamed from: j byte
   public static sbyte gameModeCode = 0;
   // $VF: renamed from: k byte
   public static sbyte screenActionCodeA = -1;
   // $VF: renamed from: l byte
   public static sbyte screenActionCodeB = -1;
   // $VF: renamed from: m byte
   public static sbyte screenActionCodeC = 0;
   // $VF: renamed from: n k
   public AbstractMenuList mainMenu;
   // $VF: renamed from: bM byte
   public static sbyte menuOptionIndexA = -1;
   // $VF: renamed from: bN byte
   public static sbyte menuOptionIndexB = -1;
   // $VF: renamed from: bO byte
   public static sbyte menuOptionIndexC = -1;
   // $VF: renamed from: bP byte
   public static sbyte menuOptionIndexD = -1;
   // $VF: renamed from: bQ byte
   public static sbyte menuOptionIndexE = -1;
   // $VF: renamed from: bR byte
   public static sbyte menuOptionIndexF = -1;
   // $VF: renamed from: bS byte
   public static sbyte menuOptionIndexG = -1;
   // $VF: renamed from: bT byte
   public static sbyte menuOptionIndexH = -1;
   // $VF: renamed from: bU byte
   public static sbyte menuOptionIndexI = -1;
   // $VF: renamed from: bV byte
   public static sbyte menuOptionIndexJ = -1;
   // $VF: renamed from: bW byte
   public static sbyte menuOptionIndexK = -1;
   // $VF: renamed from: bX byte
   public static sbyte menuOptionIndexL = -1;
   // $VF: renamed from: bY byte
   public static sbyte menuOptionIndexM = -1;
   // $VF: renamed from: bZ byte
   public static sbyte menuOptionIndexN = -1;
   // $VF: renamed from: ca byte
   public static sbyte menuOptionIndexO = -1;
   // $VF: renamed from: cb byte
   public static sbyte menuOptionIndexP = -1;
   // $VF: renamed from: cc byte
   public static sbyte menuOptionIndexQ = -1;
   // $VF: renamed from: cd byte
   public static sbyte menuOptionIndexR = -1;
   // $VF: renamed from: ce byte
   public static sbyte menuOptionIndexS = -1;
   // $VF: renamed from: cf byte
   public static sbyte menuOptionIndexT = -1;
   // $VF: renamed from: cg byte
   public static sbyte menuOptionIndexU = -1;
   // $VF: renamed from: ch byte
   public static sbyte menuOptionIndexV = -1;
   // $VF: renamed from: ci java.lang.String[]
   public static string[] activeMenuLabels = null;
   // $VF: renamed from: cj t
   public FramedMessageOverlay messageDialog = null;
   // $VF: renamed from: o int
   public int messageDisplayTicks = 0;
   // $VF: renamed from: ck int
   public int gameIntegerStateD = 0;
   // $VF: renamed from: cl boolean
   public bool isMenuEnabled = true;
   // $VF: renamed from: cm long
   public long lastFrameTimeMs = 0L;
   // $VF: renamed from: cn byte
   public sbyte gameByteStateAE = 0;
   // $VF: renamed from: co byte
   public sbyte gameByteStateAF = 0;
   // $VF: renamed from: cp boolean
   public bool gameFlagB = false;
   // $VF: renamed from: cq java.util.Random
   public Random sessionRandom = new Random(JSystem.currentTimeMillis());
   // $VF: renamed from: cr java.lang.String[]
   public static string[] recordStoreNames = new string[]{"reulang", "reusettings", "reuwaves", "reumissions"};
   // $VF: renamed from: cs boolean
   public bool isMessageDialogOpen = false;
   // $VF: renamed from: ct byte
   public sbyte gameByteStateAG = -1;
   // $VF: renamed from: cu java.lang.String
   public string dialogMessage = null;
   // $VF: renamed from: cv java.lang.String
   public string statusMessage = null;
   // $VF: renamed from: cw byte
   public sbyte gameByteStateAH = -1;
   // $VF: renamed from: cx boolean
   public bool gameFlagC = false;
   // $VF: renamed from: cy int
   public int gameIntegerStateE = 0;
   // $VF: renamed from: cz int
   public int gameIntegerStateF = 0;
   // $VF: renamed from: p java.lang.String
   public static string advertisingUrl = null;
   // $VF: renamed from: cA boolean
   public bool isAdvertisingAvailable = false;
   // $VF: renamed from: cB java.lang.String[]
   public string[] activeMenuOptions = null;
   // $VF: renamed from: cC byte
   public sbyte gameByteStateAI = 0;
   // $VF: renamed from: cD boolean
   public static bool isMenuActionEnabled = false;
   // $VF: renamed from: cE boolean
   public bool isInputEnabled = true;
   // $VF: renamed from: q long
   public long gameClockTimeMs;
   // $VF: renamed from: r int
   public int frameDeltaMs;
   // $VF: renamed from: s int
   public int elapsedFrameTimeMs;
   // $VF: renamed from: t int
   public int targetFrameDurationMs;
   // $VF: renamed from: u int
   public int gameIntegerStateG;
   // $VF: renamed from: cF byte
   public sbyte gameByteStateAJ = 0;
   // $VF: renamed from: v int[]
   public static int[] directionByState = new int[]{0, 1, 2, 3, 4, 5};
   // $VF: renamed from: cG byte
   public sbyte itemPortraitCount = 6;
   // $VF: renamed from: cH javax.microedition.lcdui.Image[]
   public Image[] itemPortraitImages;
   // $VF: renamed from: cI short[][]
   public short[][] itemPriceByCategoryAndLevel = new short[][]{
      new short[] {500, 500, 2000, 1200, 10000},
      new short[] {0, 0, 10, 5, 70},
      new short[] {0, 3, 9, 6, 0},
      new short[] {50, 100, 200, 150, 0},
      new short[] {400, 400, 1500, 1000, 10000},
      new short[] {5, 5, 15, 10, 70},
      new short[] {0, 3, 10, 7, 0},
      new short[] {75, 200, 400, 300, 0},
      new short[] {300, 300, 1200, 800, 10000},
      new short[] {10, 10, 20, 15, 70},
      new short[] {0, 5, 11, 8, 0},
      new short[] {100, 500, 600, 550, 0},
      new short[] {300, 300, 800, 600, 10000},
      new short[] {15, 15, 25, 20, 70},
      new short[] {0, 6, 12, 9, 0}
   };
   // $VF: renamed from: cJ byte[][]
   public sbyte[][] levelGrid = JArr.New2<sbyte>(6, 3);
   // $VF: renamed from: cK byte[]
   public sbyte[] itemPriceByLevel = new sbyte[]{0, 99, 30, 60, 8, 3};
   // $VF: renamed from: cL int
   public int selectedItemIndex = 0;
   // $VF: renamed from: cM int
   public int selectedItemPage = 0;
   // $VF: renamed from: cN long[]
   public long[] entityTimeOffsets = new long[5];
   // $VF: renamed from: w byte
   public sbyte gameByteStateAK = 10;
   // $VF: renamed from: x byte
   public sbyte gameByteStateAL;
   // $VF: renamed from: y int[]
   public static int[] gameIntegerStateArrayA = new int[]{0, 6, 141, 0, 0, 0, 145, 0, 147, 0, 0, 0};
   // $VF: renamed from: z int[]
   public static int[] gameIntegerStateArrayB = new int[]{140, 140, 140, 140, 140, 150, 150, 150, 150, 150, 0};
   // $VF: renamed from: A int[][]
   public static int[][] gameIntegerStateArrayArrayA = new int[][]{new int[] {0, 0}, new int[] {0, 0}, new int[] {1, 4}, new int[] {0, 0}, new int[] {1, 4}, new int[] {1, 8}, new int[] {1, 8}, new int[] {0, 0}, new int[] {1, 5}, new int[] {1, 4}, new int[] {0, 0}, new int[] {1, 2}};
   // $VF: renamed from: B int
   public int currentEntityCenterX;
   // $VF: renamed from: C int
   public int currentEntityCenterY;
   // $VF: renamed from: D g
   public CharacterAnimationState activeCharacterState;
   // $VF: renamed from: E g
   public CharacterAnimationState primaryCharacterState;
   // $VF: renamed from: F byte
   public sbyte gameByteStateAM;
   // $VF: renamed from: G u[]
   public ActorRuntimeState[] actorStates;
   // $VF: renamed from: H u
   public ActorRuntimeState activeActorState;
   // $VF: renamed from: I f[]
   public WorldObjectState[] objectStates = new WorldObjectState[5];
   // $VF: renamed from: J d[]
   public EntityAnimationState[] animatedEntityStates = new EntityAnimationState[10];
   // $VF: renamed from: K short[]
   public short[] activeEntityIndices = new short[150];
   // $VF: renamed from: L byte[]
   public sbyte[] entityTypeByIndex = new sbyte[150];
   // $VF: renamed from: M short
   public short activeEntityCount;
   // $VF: renamed from: N byte[][]
   public sbyte[][] collisionMap = JArr.New2<sbyte>(72, 50);
   // $VF: renamed from: O j[]
   public ScheduledEventNode[] scheduledEvents;
   // $VF: renamed from: P j
   public ScheduledEventNode activeScheduledEvent;
   // $VF: renamed from: Q byte
   public sbyte gameByteStateAN;
   // $VF: renamed from: R byte
   public sbyte gameByteStateAO;
   // $VF: renamed from: S int
   public int gameIntegerStateH;
   // $VF: renamed from: T byte
   public sbyte gameByteStateAP;
   // $VF: renamed from: U boolean[]
   public bool[] isLayerEnabled = new bool[4];
   // $VF: renamed from: V byte
   public sbyte gameByteStateAQ;
   // $VF: renamed from: W byte
   public sbyte gameByteStateAR;
   // $VF: renamed from: X byte[][]
   public sbyte[][] levelTileFlags;
   // $VF: renamed from: Y short[][]
   public short[][] levelTileHeights;
   // $VF: renamed from: Z short[][]
   public short[][] levelTileWidths;
   // $VF: renamed from: aa byte[][]
   public sbyte[][] levelTileTypes;
   // $VF: renamed from: ab short
   public short gameShortValueA;
   // $VF: renamed from: ac short
   public short gameShortValueB;
   // $VF: renamed from: cO javax.microedition.lcdui.Image
   public Image levelArtworkImage;
   // $VF: renamed from: ad q
   public SpriteAtlasRenderer levelArtworkRenderer = new SpriteAtlasRenderer();
   // $VF: renamed from: ae int
   public int levelPixelWidthHalf;
   // $VF: renamed from: af int
   public int cameraX;
   // $VF: renamed from: ag int
   public int cameraY;
   // $VF: renamed from: ah int
   public int cameraMinX;
   // $VF: renamed from: ai int
   public int cameraMinY;
   // $VF: renamed from: aj int
   public int cameraMaxX;
   // $VF: renamed from: ak int
   public int cameraMaxY;
   // $VF: renamed from: al byte
   public sbyte currentTileType;
   // $VF: renamed from: am short
   public short levelObjectCount;
   // $VF: renamed from: an r[]
   public ActorAnimationState[] levelObjects;
   // $VF: renamed from: ao java.lang.String[]
   public static string[] levelDataPaths = new string[]{"/data/reu01_large.bin", "/data/reu02_large.bin", "/data/reu03_large.bin", "/data/reu04_large.bin"};
   // $VF: renamed from: ap int[]
   public static int[] levelDataLengths = new int[]{2698, 3113, 17891, 2940};
   // $VF: renamed from: aq short[][]
   public short[][] levelObjectProperties;
   // $VF: renamed from: ar boolean
   public bool gameFlagD;
   // $VF: renamed from: as int
   public int gameIntegerStateI = 0;
   // $VF: renamed from: at int[][]
   public static int[][] objectCollisionInsets = new int[][]{new int[] {1, 2}, new int[] {1, 2}, new int[] {1, 2}, new int[] {1, 1}, new int[] {1, 2}, new int[] {1, 1}, new int[] {1, 2}, new int[] {1, 2}, new int[] {1, 1}, new int[] {1, 1}, new int[] {3, 5}, new int[] {1, 1}};
   // $VF: renamed from: au boolean[]
   public bool[] objectVisibilityFlags = new bool[183];
   // $VF: renamed from: av javax.microedition.lcdui.Image[]
   public Image[] objectImages = new Image[183];
   // $VF: renamed from: aw boolean
   public bool gameFlagE = false;
   // $VF: renamed from: ax java.util.Random
   public Random gameplayRandom = new Random();
   // $VF: renamed from: ay boolean
   public bool gameFlagF;
   // $VF: renamed from: az short
   public short gameShortValueC;
   // $VF: renamed from: aA short
   public short gameShortValueD;
   // $VF: renamed from: aB int
   public int gameIntegerStateJ;
   // $VF: renamed from: aC int
   public int playerHealth;
   // $VF: renamed from: aD int
   public int playerAmmo;
   // $VF: renamed from: aE int
   public int playerGrenades;
   // $VF: renamed from: aF int
   public int playerCredits;
   // $VF: renamed from: aG int
   public int gameIntegerStateK;
   // $VF: renamed from: aH int
   public int gameIntegerStateL;
   // $VF: renamed from: aI int
   public int gameIntegerStateM;
   // $VF: renamed from: aJ byte
   public sbyte gameByteStateAS;
   // $VF: renamed from: aK long
   public long gameLongValueA;
   // $VF: renamed from: aL boolean
   public bool gameFlagG;
   // $VF: renamed from: aM int
   public int gameIntegerStateN;
   // $VF: renamed from: aN int
   public int gameIntegerStateO;
   // $VF: renamed from: aO int
   public int gameIntegerStateP;
   // $VF: renamed from: aP long
   public long gameLongValueB;
   // $VF: renamed from: aQ int[]
   public static int[] objectTypeByAction = new int[]{
      8,
      8,
      8,
      8,
      8,
      140,
      140,
      140,
      140,
      140,
      140,
      140,
      140,
      140,
      140,
      140,
      140,
      140,
      140,
      140,
      140,
      150,
      150,
      150,
      150,
      150,
      150,
      150,
      150,
      150,
      150,
      150,
      150,
      150,
      150,
      150,
      150,
      152,
      152,
      152,
      0
   };
   // $VF: renamed from: aR int[][]
   public static int[][] directionOffsets = new int[][]{new int[] {0, -1}, new int[] {-1, 0}, new int[] {0, 1}, new int[] {1, 0}};
   // $VF: renamed from: aS int
   public int gameIntegerStateQ;
   // $VF: renamed from: aT int
   public int gameIntegerStateR;
   // $VF: renamed from: aU byte
   public sbyte gameByteStateAT;
   // $VF: renamed from: aV boolean
   public bool gameFlagH;
   // $VF: renamed from: aW boolean
   public bool gameFlagI;
   // $VF: renamed from: aX boolean
   public bool gameFlagJ;
   // $VF: renamed from: cP boolean
   public bool gameFlagK = true;
   // $VF: renamed from: aY long
   public long gameLongValueC;
   // $VF: renamed from: cQ byte
   public sbyte gameByteStateAU;
   // $VF: renamed from: aZ int
   public int gameIntegerStateS;
   // $VF: renamed from: ba int
   public int gameIntegerStateT;
   // $VF: renamed from: bb int
   public int gameIntegerStateU;
   // $VF: renamed from: cR javax.microedition.lcdui.Image
   public Image zombiePortraitImage;
   // $VF: renamed from: cS javax.microedition.lcdui.Image
   public Image leonPortraitImage;
   // $VF: renamed from: bc r
   public ActorAnimationState medicalItemState;
   // $VF: renamed from: cT javax.microedition.lcdui.Image
   public Image medkitImage;
   // $VF: renamed from: cU byte
   public sbyte gameByteStateAV = 0;
   // $VF: renamed from: cV int
   public int gameIntegerStateV = 10;
   // $VF: renamed from: cW int
   public int gameIntegerStateW = 0;
   // $VF: renamed from: bd r
   public ActorAnimationState ammunitionItemState;
   // $VF: renamed from: cX javax.microedition.lcdui.Image
   public Image ammunitionImage;
   // $VF: renamed from: cY byte
   public sbyte gameByteStateAW = 0;
   // $VF: renamed from: cZ int
   public int gameIntegerStateX = 10;
   // $VF: renamed from: da int
   public int gameIntegerStateY = 0;
   // $VF: renamed from: be r
   public ActorAnimationState weaponItemState;
   // $VF: renamed from: db javax.microedition.lcdui.Image
   public Image weaponImage;
   // $VF: renamed from: dc byte
   public sbyte gameByteStateAX = 0;
   // $VF: renamed from: dd int
   public int gameIntegerStateZ = 3;
   // $VF: renamed from: de int
   public int gameIntegerStateAA = 0;
   // $VF: renamed from: df long
   public long gameLongValueD;
   // $VF: renamed from: dg int[][]
   public static int[][] collisionCoordinates;
   // $VF: renamed from: dh int
   public int timerIntervalMsA = 10000;
   // $VF: renamed from: di int
   public int timerIntervalMsB = 3000;
   // $VF: renamed from: dj int
   public int timerIntervalMsC = 1000;
   // $VF: renamed from: dk byte
   public sbyte gameByteStateAY = 3;
   // $VF: renamed from: dl byte
   public sbyte gameByteStateAZ = -1;
   // $VF: renamed from: dm short[]
   public short[] gameShortValueArrayA = new short[5];
   // $VF: renamed from: dn int
   public int timerElapsedOffset = 0;
   // $VF: renamed from: do int
   public int gameIntegerStateAF = 0;
   // $VF: renamed from: dp byte
   public sbyte gameByteStateBA = 1;
   // $VF: renamed from: dq byte
   public sbyte gameByteStateBB = 1;
   // $VF: renamed from: dr short
   public short gameShortValueE = 0;
   // $VF: renamed from: ds int
   public int gameIntegerStateAG = 0;
   // $VF: renamed from: dt int
   public int gameIntegerStateAH = 0;
   // $VF: renamed from: du byte
   public sbyte gameByteStateBC = 0;
   // $VF: renamed from: dv short[][]
   public short[][] animationDefinitions = new short[][]{
      new short[] {10, 1, 1, 0, 1, 0, 46},
      new short[] {12, 2, 1, 0, 3, 0, 54},
      new short[] {3, 1, 1, 0, 1, 1, 272},
      new short[] {15, 3, 1, 0, 2, 0, 68},
      new short[] {18, 3, 2, 1, 2, 0, 82},
      new short[] {1, 1, 1, 0, 1, 2, 300},
      new short[] {20, 2, 2, 2, 3, 0, 90},
      new short[] {12, 1, 1, 0, 1, 1, 340},
      new short[] {21, 3, 2, 2, 3, 0, 94},
      new short[] {2, 1, 1, 0, 1, 2, 350},
      new short[] {24, 3, 2, 2, 3, 0, 108},
      new short[] {32, 4, 3, 3, 4, 0, 96},
      new short[] {36, 4, 3, 3, 4, 0, 108},
      new short[] {16, 2, 1, 0, 1, 1, 370},
      new short[] {4, 2, 1, 0, 1, 2, 350},
      new short[] {40, 4, 3, 3, 4, 0, 120},
      new short[] {20, 2, 1, 0, 1, 1, 400},
      new short[] {44, 4, 3, 3, 4, 0, 132},
      new short[] {22, 2, 1, 0, 1, 1, 400},
      new short[] {6, 2, 1, 0, 1, 2, 350}
   };
   // $VF: renamed from: dw byte
   public sbyte gameByteStateBD;
   // $VF: renamed from: dx byte
   public sbyte gameByteStateBE = 0;
   // $VF: renamed from: dy byte
   public sbyte gameByteStateBF = 0;
   // $VF: renamed from: dz boolean
   public bool gameFlagL = true;
   // $VF: renamed from: dA boolean
   public bool gameFlagM = false;
   // $VF: renamed from: dB javax.microedition.lcdui.Image
   public Image unarmedWeaponImage;
   // $VF: renamed from: dC int
   public int gameIntegerStateAI = 0;
   // $VF: renamed from: dD short[]
   public short[] gameplayPriceMultipliers = new short[]{2, 8, 4, 50, 25, 400, 200, 1000};
   // $VF: renamed from: dE byte
   public sbyte gameByteStateBG;
   // $VF: renamed from: dF boolean
   public bool gameFlagN = false;
   // $VF: renamed from: dG byte
   public sbyte gameByteStateBH = 8;
   // $VF: renamed from: dH byte[]
   public sbyte[] gameByteStateArrayA;
   // $VF: renamed from: dI byte
   public sbyte gameByteStateBI = 0;
   // $VF: renamed from: dJ boolean
   public bool gameFlagO = false;
   // $VF: renamed from: dK boolean
   public bool gameFlagP = false;
   // $VF: renamed from: dL boolean
   public bool gameFlagQ = false;
   // $VF: renamed from: dM int
   public int gameIntegerStateAJ;
   // $VF: renamed from: dN int
   public int gameIntegerStateAK;
   // $VF: renamed from: dO int
   public int gameIntegerStateAL = 1;
   // $VF: renamed from: dP int[][]
   public int[][] levelEventDefinitions = new int[][]{
      new int[0],
      new int[] {0, 0, 16, 2, 3, 1, 16, 120000, 257},
      new int[] {1, 0, 3, 1, 33, 1, 16, 0, 288},
      new int[] {0, 0, 21, 3, 0, 3, 16, 90000, 3},
      new int[] {1, 0, 15, 3, 11, 1, 16, 0, 264},
      new int[] {0, 0, 21, 3, 48, 2, 16, 0, 16},
      new int[] {0, 0, 21, 3, 37, 3, 16, 110000, 257},
      new int[] {1, 0, 3, 1, 1, 1, 16, 0, 800},
      new int[] {0, 0, 16, 2, 11, 3, 16, 0, 772},
      new int[] {0, 0, 12, 3, 48, 2, 16, 9, 416},
      new int[] {1, 2, 3, 1, 43, 1, 16, 0, 256},
      new int[] {0, 0, 30, 3, 63, 2, 16, 180000, 323},
      new int[] {1, 0, 99, 3, 63, 3, 16, 50, 384}
   };
   // $VF: renamed from: dQ byte
   public sbyte gameByteStateBJ;
   // $VF: renamed from: dR byte[][]
   public sbyte[][] levelEventParameters = new sbyte[][]{
      new sbyte[0],
      new sbyte[] {0, 30, 0, 0, 0, 0},
      new sbyte[] {0, 0, 0, 0, 0, 1},
      new sbyte[] {0, 0, 0, 0, 0, 0},
      new sbyte[] {0, 25, 0, 10, 0, 0},
      new sbyte[] {0, 0, 0, 0, 2, 1},
      new sbyte[] {0, 0, 20, 0, 0, 2},
      new sbyte[] {0, 0, 0, 0, 0, 0},
      new sbyte[] {0, 25, 0, 10, 0, 0},
      new sbyte[] {0, 0, 0, 0, 3, 1},
      new sbyte[] {0, 30, 0, 15, 0, 1},
      new sbyte[] {0, 30, 8, 12, 5, 2},
      new sbyte[] {0, 40, 4, 12, 2, 1}
   };
   // $VF: renamed from: dS boolean[]
   public bool[] unlockedLevelFlags;
   // $VF: renamed from: dT long
   public long gameLongValueE;
   // $VF: renamed from: dU long
   public long gameLongValueF;
   // $VF: renamed from: dV long
   public long gameLongValueG;
   // $VF: renamed from: dW int
   public int gameIntegerStateAM = 0;
   // $VF: renamed from: dX boolean
   public bool gameFlagR = false;
   // $VF: renamed from: dY boolean
   public bool gameFlagS = true;
   // $VF: renamed from: dZ boolean
   public bool gameFlagT = false;
   // $VF: renamed from: ea long
   public long gameLongValueH;
   // $VF: renamed from: eb long
   public long gameLongValueI;
   // $VF: renamed from: ec byte
   public sbyte gameByteStateBK = 0;
   // $VF: renamed from: ed boolean
   public bool gameFlagU = false;
   // $VF: renamed from: ee boolean
   public bool gameFlagV = false;
   // $VF: renamed from: ef byte[]
   public sbyte[] animationTimingThresholds = new sbyte[]{12, 24, 42, 56};
   // $VF: renamed from: eg javax.microedition.lcdui.Image
   public Image gameLogoImage;
   // $VF: renamed from: eh javax.microedition.lcdui.Image
   public Image gameImageResourceA;
   // $VF: renamed from: ei javax.microedition.lcdui.Image
   public Image publisherLogoImage;
   // $VF: renamed from: bf long
   public long lastUpdateTimeMs;
   // $VF: renamed from: ej boolean
   public static bool gameFlagW = false;
   // $VF: renamed from: ek byte[]
   public sbyte[] gameByteStateArrayB;
   // $VF: renamed from: bg int
   public int gameIntegerStateAN;
   // $VF: renamed from: el boolean
   public bool gameFlagX = false;
   // $VF: renamed from: em int
   public int gameIntegerStateAO = 0;
   // $VF: renamed from: en boolean
   public bool gameFlagY = false;
   // $VF: renamed from: eo boolean
   public bool gameFlagZ = false;
   // $VF: renamed from: ep boolean
   public bool gameFlagAA = false;
   // $VF: renamed from: bh long
   public long sessionStartTimeMs;
   // $VF: renamed from: bi int
   public int sessionDurationMinutes;
   // $VF: renamed from: bj int
   public int sessionDurationSeconds;
   // $VF: renamed from: bk int
   public int previousSessionSecond = 0;
   // $VF: renamed from: eq int
   public int sessionTimerTicks = 0;

   // $VF: renamed from: O () void
   public void applyCheatPriceModifiers() {
      if (this.isCheatModeEnabled) {
         this.gameplayPriceMultipliers[0] = 1;
         this.gameplayPriceMultipliers[1] = 1;
         this.gameplayPriceMultipliers[2] = 1;
         this.gameplayPriceMultipliers[3] = 1;
         this.gameplayPriceMultipliers[4] = 1;
         this.gameplayPriceMultipliers[5] = 1;
         this.gameplayPriceMultipliers[6] = 1;
         this.gameplayPriceMultipliers[7] = 1;
      } else {
         this.gameplayPriceMultipliers[0] = 2;
         this.gameplayPriceMultipliers[1] = 8;
         this.gameplayPriceMultipliers[2] = 4;
         this.gameplayPriceMultipliers[3] = 50;
         this.gameplayPriceMultipliers[4] = 25;
         this.gameplayPriceMultipliers[5] = 400;
         this.gameplayPriceMultipliers[6] = 200;
         this.gameplayPriceMultipliers[7] = 1000;
      }
   }

   public GameController(CapcomMIDlet var1) { this.itemPortraitImages = new Image[this.itemPortraitCount]; this.primaryCharacterState = new CharacterAnimationState(this); this.gameByteStateBD = (sbyte)(this.animationDefinitions.Length - 1); this.gameByteStateArrayA = new sbyte[this.gameByteStateBH]; this.gameByteStateBJ = (sbyte)(this.levelEventDefinitions.Length - 1); this.unlockedLevelFlags = new bool[this.levelEventDefinitions.Length]; 
      this.midlet = var1;
      this.setCharacterPortraitIndices((sbyte)-1, (sbyte)-1);
   }

   // $VF: renamed from: a (w) void
   public void attachCanvas(GameCanvas var1) {
      this.gameCanvas = var1;
      this.gameClockTimeMs = JSystem.currentTimeMillis();
      if (var1.getHeight() >= var1.getWidth()) {
         canvasWidth = 360;
         canvasHeight = 384;
         if (CapcomMIDlet.canvasWidth != 0) {
            canvasWidth = CapcomMIDlet.canvasWidth;
         }

         if (CapcomMIDlet.canvasHeight != 0) {
            canvasHeight = CapcomMIDlet.canvasHeight;
         }

         canvasCenterX = canvasWidth / 2;
         canvasCenterY = canvasHeight / 2;
         this.currentControlKey = this.portraitControlKey;
      } else {
         canvasWidth = var1.getHeight();
         canvasHeight = var1.getWidth();
         canvasCenterX = canvasWidth / 2;
         canvasCenterY = canvasHeight / 2;
         this.currentControlKey = this.landscapeControlKey;
      }

      this.gameCanvas.setTargetFrameRate(12);
      this.capcomLogoImage = GameCanvas.loadImageResource("/img/capcom_logo.png");
      var1.setCanvasExitCode(2000);
      GameCanvas.clearPersistentGameData();
      GameCanvas.initializePersistentGameData(4);
      GameCanvas.initializePersistentDataSlot(0, 1);
      GameCanvas.initializePersistentDataSlot(1, 1);
      GameCanvas.initializePersistentDataSlot(2, 43);
      GameCanvas.initializePersistentDataSlot(3, 13);
      this.playSoundEffect((sbyte)0);
      this.playSoundEffect((sbyte)1);
      this.releaseFontResources();
      if (this.messageDialog == null) {
         this.messageDialog = new FramedMessageOverlay(var1, this.fontRenderer, (sbyte)1);
      }

      switch (0) {
         case 0:
            this.mainMenu = new ScrollingMenuList(this.fontRenderer, canvasWidth, canvasHeight, var1, false);
            break;
         case 1:
            this.mainMenu = new CarouselMenu(this.fontRenderer, canvasWidth, canvasHeight, var1);
            this.mainMenu.f();
            this.mainMenu.c(1); break;
      }

      this.startupTextByLanguage = JArr.New2<string>(3, 6);
      string var2 = "";

      for (int var3 = 0; var3 < 3; var3++) {
         if (var3 == 0) {
            var2 = "booten";
         } else if (var3 == 1) {
            var2 = "bootes";
         } else if (var3 == 2) {
            var2 = "bootptbr";
         }

         var1.readLocalizedResourceValue(this.startupTextByLanguage[var3], var2, 3, var3, 6, true, -1);
      }

      this.characterPortraitImages = new Image[6];

      for (int var4 = 0; var4 < this.characterPortraitImages.Length; var4++) {
         this.characterPortraitImages[var4] = GameCanvas.loadImageResource("/img/softkeys/icon_" + var4 + ".png");
      }

      gameModeCode = 0;
      advertisingUrl = CapcomMIDlet.mobileAdvertisingUrl;
      this.isAdvertisingAvailable = GameCanvas.isAdvertisingDisplayEnabled();
      this.configureLanguageSelectionMenu();
      this.activeCharacterState = this.primaryCharacterState;
      this.gameByteStateAP = 0;

      for (int var5 = 0; var5 < 5; var5++) {
         this.objectStates[var5] = new WorldObjectState(this);
      }

      for (int var6 = 0; var6 < 10; var6++) {
         this.animatedEntityStates[var6] = new EntityAnimationState(this);
      }

      this.gameIntegerStateAN = 0;
      this.resetPlayerEffectState();
      this.clearObjectImageCache();
   }

   // $VF: renamed from: a () void
   public void releaseFontResources() {
      this.fontRenderer = null;
      JSystem.gc();
      this.fontRenderer = new BitmapFontRenderer(2);
      this.fontRenderer.loadFont(0, "data/fontlib_title", (sbyte)2, (sbyte)11, (sbyte)13, (short)0, (sbyte)1);
      this.fontRenderer.loadFont(1, "data/fontlib_main", (sbyte)1, (sbyte)7, (sbyte)11, (short)0, (sbyte)1);
   }

   // $VF: renamed from: a (byte, boolean) void
   public void resetGameSession(sbyte var1, bool var2) {
      this.clearGameActionFlags();
      this.gameByteStateAE = 0;
      this.gameByteStateAF = 0;
      gameModeCode = var1;
      this.gameFlagB = var2;
   }

   // $VF: renamed from: b () void
   public void stopGameScreen() {
      this.isGameScreenActive = false;
      this.isAudioDisposed = true;
      this.audioCommandSink = null;
      this.fontRenderer = null;
      JSystem.gc();
      this.midlet.shutdownMidlet();
   }

   // $VF: renamed from: c () void
   public void onCanvasHidden() {
      this.isAudioDisposed = true;
      this.disposeAudioManager();
      this.gameIntegerStateH = 0;
      if (gameModeCode == 5 && this.gameIntegerStateG != 138) {
         this.beginScreenInitialization();
      }
   }

   // $VF: renamed from: d () void
   public void onCanvasShown() {
      this.isAudioDisposed = false;
      this.disposeAudioManager();
      this.gameIntegerStateH = 0;
      if (gameModeCode == 5 && this.gameIntegerStateG != 138) {
         this.resetScreenInitialization();
      }
   }

   // $VF: renamed from: a (int) void
   public void advanceGameplayStateTimer(int var1) {
      if (gameModeCode == 5 && this.gameIntegerStateG != 138) {
         for (int var2 = 0; var2 < 24; var2++) {
            this.actorStates[var2].elapsedTimerA += (long)var1;
            this.actorStates[var2].elapsedTimerB += (long)var1;
            if (this.actorStates[var2].optionalTimer != 0L) {
               this.actorStates[var2].optionalTimer += (long)var1;
            }
         }

         this.shiftAnimationStartTimes(var1);
      }
   }

   // $VF: renamed from: b (int) void
   public void shiftAnimationStartTimes(int var1) {
      for (int var2 = 0; var2 < 10; var2++) {
         this.animatedEntityStates[var2].animationStartTime += (long)var1;
      }
   }

   // $VF: renamed from: P () void
   public void beginScreenInitialization() {
      if (!this.hasScreenStarted) {
         screenActionCodeC = 5;
         screenActionCodeB = 18;
         this.resetGameSession((sbyte)3, false);
         this.hasScreenStarted = true;
         this.isScreenInitialized = true;
         this.gameIntegerStateA = 0;
         this.gameByteStateAU = 0;
         this.gameClockTimeMs = JSystem.currentTimeMillis();
         this.lastUpdateTimeMs = this.gameClockTimeMs;
      }
   }

   // $VF: renamed from: Q () void
   public void resetScreenInitialization() {
      if (this.hasScreenStarted) {
         this.isScreenInitialized = false;
         this.hasScreenStarted = false;
         this.playAudioCue(0, 1);
         this.gameClockTimeMs = JSystem.currentTimeMillis();
         this.advanceGameplayStateTimer((int)(this.gameClockTimeMs - this.lastUpdateTimeMs));
         this.gameLongValueD = this.gameLongValueD + (this.gameClockTimeMs - this.lastUpdateTimeMs);
         this.gameLongValueG = this.gameClockTimeMs - this.lastUpdateTimeMs;

         for (int var1 = 0; var1 < this.entityTimeOffsets.Length; var1++) {
            this.entityTimeOffsets[var1] = this.entityTimeOffsets[var1] + (this.gameClockTimeMs - this.lastUpdateTimeMs);
         }

         this.setCharacterPortraitIndices((sbyte)5, (sbyte)3);
      }
   }

   // $VF: renamed from: R () void
   public void clearGameActionFlags() {
      this.gameIntegerStateA = 0;
      this.gameIntegerStateB = 0;
      this.gameFlagC = false;
      this.gameIntegerStateE = 0;
      this.gameIntegerStateF = 0;
   }

   // $VF: renamed from: c (int) void
   public void onKeyPressed(int var1) {
      if (!this.isGameAssetsLoaded) {
         this.gameIntegerStateB = var1;
         if (var1 == -3) {
            this.gameIntegerStateA |= 2;
            this.gameByteStateAU = (sbyte)(this.gameByteStateAU | 2);
         } else if (var1 == -4) {
            this.gameIntegerStateA |= 4;
            this.gameByteStateAU = (sbyte)(this.gameByteStateAU | 4);
         } else if (var1 == -1) {
            this.gameIntegerStateA |= 8;
            this.gameByteStateAU = (sbyte)(this.gameByteStateAU | 8);
         } else if (var1 == -2) {
            this.gameIntegerStateA |= 16;
            this.gameByteStateAU = (sbyte)(this.gameByteStateAU | 16);
         } else if (var1 == -5) {
            this.gameIntegerStateA |= 32;
         } else if (var1 == -6 || var1 == 6) {
            this.gameIntegerStateA |= 256;
         } else if (var1 == -7 || var1 == 7) {
            this.gameIntegerStateA |= 512;
         } else if (var1 == 42) {
            this.gameIntegerStateA |= 64;
         } else if (var1 == 48) {
            this.gameIntegerStateA |= 524288;
         } else if (var1 == 49) {
            this.gameIntegerStateA |= 262144;
         } else if (var1 == 50) {
            this.gameIntegerStateA |= 131072;
            this.gameByteStateAU = (sbyte)(this.gameByteStateAU | 8);
         } else if (var1 == 51) {
            this.gameIntegerStateA |= 65536;
         } else if (var1 == 52) {
            this.gameIntegerStateA |= 32768;
            this.gameByteStateAU = (sbyte)(this.gameByteStateAU | 2);
         } else if (var1 == 53) {
            this.gameIntegerStateA |= 16384;
         } else if (var1 == 54) {
            this.gameIntegerStateA |= 8192;
            this.gameByteStateAU = (sbyte)(this.gameByteStateAU | 4);
         } else if (var1 == 55) {
            this.gameIntegerStateA |= 4096;
         } else if (var1 == 56) {
            this.gameIntegerStateA |= 2048;
            this.gameByteStateAU = (sbyte)(this.gameByteStateAU | 16);
         } else if (var1 == 57) {
            this.gameIntegerStateA |= 1024;
         } else if (var1 == 42) {
            this.gameIntegerStateA |= 64;
         } else if (var1 == 35) {
            this.gameIntegerStateA |= 128;
         }
      }
   }

   // $VF: renamed from: d (int) void
   public void onKeyRepeated(int var1) {
   }

   // $VF: renamed from: e (int) void
   public void onKeyReleased(int var1) {
      if (var1 == -3) {
         this.gameByteStateAU &= -3;
      } else if (var1 == -4) {
         this.gameByteStateAU &= -5;
      } else if (var1 == -1) {
         this.gameByteStateAU &= -9;
      } else if (var1 == -2) {
         this.gameByteStateAU &= -17;
      } else if (var1 == 50) {
         this.gameByteStateAU = (sbyte)(this.gameByteStateAU & -131073);
         this.gameByteStateAU &= -9;
      } else if (var1 == 52) {
         this.gameByteStateAU = (sbyte)(this.gameByteStateAU & -32769);
         this.gameByteStateAU &= -3;
      } else if (var1 == 54) {
         this.gameByteStateAU = (sbyte)(this.gameByteStateAU & -8193);
         this.gameByteStateAU &= -5;
      } else if (var1 == 56) {
         this.gameByteStateAU = (sbyte)(this.gameByteStateAU & -2049);
         this.gameByteStateAU &= -17;
      }

      this.clearGameActionFlags();
   }

   // $VF: renamed from: a (int, int) void
   public void onPointerPressed(int var1, int var2) {
   }

   // $VF: renamed from: b (int, int) void
   public void onPointerReleased(int var1, int var2) {
   }

   // $VF: renamed from: c (int, int) void
   public void onCanvasSizeChanged(int var1, int var2) {
   }

   // $VF: renamed from: f (int) boolean
   public bool consumeGameFlag(int var1) {
      bool var2;
      try {
         var2 = (this.gameIntegerStateA & var1) != 0;
      } finally {
         this.gameIntegerStateA &= ~var1;
      }

      return var2;
   }

   // $VF: renamed from: e () void
   public void updateFrameTiming() {
      this.elapsedFrameTimeMs = (int)(JSystem.currentTimeMillis() - this.gameClockTimeMs);
      this.gameClockTimeMs = this.gameClockTimeMs + (long)this.elapsedFrameTimeMs;
      this.frameDeltaMs = this.elapsedFrameTimeMs;
      this.targetFrameDurationMs = 20;
      if (this.gameFlagH) {
         this.frameDeltaMs = 0;
         this.gameFlagH = false;
      } else {
         this.frameDeltaMs = this.elapsedFrameTimeMs;
      }
   }

   // $VF: renamed from: S () void
   public void initializeCurrentScreen() {
      while (this.gameByteStateAE <= 16) {
         switch (this.gameByteStateAE) {
            case 1:
            default:
               this.gameByteStateAE++; break;
         }
      }
   }

   // $VF: renamed from: f () void
   public void configureAboutDialog() {
      while (this.gameByteStateAE < 16) {
         switch (this.gameByteStateAE) {
            case 1:
               this.setPendingMessage(this.localizedText[11]);
               string var1 = "";
               var1 = var1 + this.midlet.getAppProperty("MIDlet-Name").toUpperCase() + "\n";
               var1 = var1 + this.localizedText[56] + " " + this.midlet.getAppProperty("MIDlet-Version");
               var1 = var1 + "\n";
               var1 = var1 + this.localizedText[62];
               var1 = var1 + "\n";
               var1 = var1 + this.localizedText[57] + "";
               var1 = var1 + "\n";
               var1 = var1 + "\n" + this.localizedText[58];
               var1 = var1 + "\n" + this.localizedText[59];
               var1 = var1 + "\n" + this.localizedText[60];
               var1 = var1 + "\n";
               var1 = var1 + "\n";
               string var17 = var1 + "$Name:";

               try {
                  var17 = var17 + "\n" + CapcomMIDlet.buildIdentifier.substring(0, 18);
                  var17 = var17 + "\n" + CapcomMIDlet.buildIdentifier.substring(18, 24);
               } catch (System.Exception var4) {
                  var17 = var17 + "\nBUILD NOT TAGGED";
               }

               int var2 = canvasHeight - this.characterPortraitImages[0].getHeight() - 10 + -23;
               int var3 = canvasHeight - this.characterPortraitImages[0].getHeight() - 10 - var2 / 2 + 6;
               this.messageDialog.configureMessageOverlay(var17, canvasWidth / 2, var3, canvasWidth * 90 / 100, var2, 1, 2, true); goto default;
            default:
               this.gameByteStateAE++; break;
         }
      }
   }

   // $VF: renamed from: g () void
   public void initializeGameplay() {
      try {
         while (true) {
            if (this.gameByteStateAE <= 16) {
               switch (this.gameByteStateAE) {
                  case 1:
                     if (!this.loadObjectImage(6, 38)) {
                        return;
                     }

                     if (!this.loadObjectImage(150, 45)) {
                        return;
                     }

                     if (!this.loadObjectImage(8, 41)) {
                        return;
                     }

                     if (!this.loadObjectImage(2, 2)) {
                        return;
                     }

                     if (this.medkitImage == null) {
                        this.medkitImage = GameCanvas.loadImageResource("/img/medkit.png");
                     }

                     if (this.ammunitionImage == null) {
                        this.ammunitionImage = GameCanvas.loadImageResource("/img/ammo.png");
                     }

                     if (this.weaponImage == null) {
                        this.weaponImage = GameCanvas.loadImageResource("/img/weapon.png");
                     }

                     if (this.unarmedWeaponImage == null) {
                        this.unarmedWeaponImage = GameCanvas.loadImageResource("/img/no_wep.png");
                     }

                     for (int var1 = 0; var1 < this.itemPortraitCount; var1++) {
                        if (this.itemPortraitImages[var1] == null) {
                           this.itemPortraitImages[var1] = GameCanvas.loadImageResource("/img/item_" + var1 + ".png");
                        }
                     }

                     if (this.zombiePortraitImage == null) {
                        this.zombiePortraitImage = GameCanvas.loadImageResource("/img/zombie_head.png");
                     }

                     if (this.leonPortraitImage == null) {
                        this.leonPortraitImage = GameCanvas.loadImageResource("/img/leon_head.png");
                     }

                     this.actorStates = new ActorRuntimeState[24];
                     this.actorStates[0] = this.primaryCharacterState.characterAnimationObjectReferenceA;
                     this.actorStates[0].actorRuntimeFlagF = false;

                     for (int var4 = 1; var4 < 24; var4++) {
                        this.actorStates[var4] = new ActorRuntimeState(this);
                        this.actorStates[var4].isActive = false;
                        this.actorStates[var4].actorRuntimeFlagF = true;
                     }

                     this.activeEntityIndices = new short[150];
                     this.entityTypeByIndex = new sbyte[150];
                     this.gameFlagJ = true;
                     this.activeCharacterState.characterAnimationFlagA = false;
                     this.activeCharacterState.characterAnimationFlagB = false;
                     this.activeCharacterState.characterAnimationFlagC = false;
                     if (this.gameByteStateAZ != 1) {
                        for (int var5 = 0; var5 < 6; var5++) {
                           this.activeCharacterState.characterAnimationFlagArrayA[var5] = false;
                        }

                        this.activeCharacterState.characterAnimationFlagArrayA[0] = true;
                        this.activeCharacterState.characterAnimationFlagArrayA[5] = true;
                        this.activeCharacterState.characterAnimationFlagArrayA[1] = true;
                     }

                     this.spawnActor(1, 8, 11, 3);
                     this.scheduledEvents = new ScheduledEventNode[150];

                     for (int var6 = 0; var6 < 150; var6++) {
                        this.scheduledEvents[var6] = new ScheduledEventNode(this);
                     }

                     this.gameIntegerStateH = 0;
                     this.gameIntegerStateI = 0;
                     this.gameFlagJ = true;
                     this.primaryCharacterState.characterAnimationFlagD = true;

                     for (int var7 = 0; var7 < this.entityTimeOffsets.Length; var7++) {
                        this.entityTimeOffsets[var7] = 0L;
                     }

                     this.initializeMedicalItemState();
                     this.processGameState();
                     this.initializeGameObjects(this.gameByteStateAP, false);
                     this.gameLongValueD = this.gameClockTimeMs;
                     collisionCoordinates = JArr.New2<int>(this.gameByteStateAQ * this.gameByteStateAR, 2);
                     this.gameByteStateAV = 0;
                     this.gameByteStateAX = 0;
                     this.gameByteStateAW = 0;
                     this.gameIntegerStateA = 0;
                     this.gameByteStateAU = 0; goto case 2;
                  case 2:
                  case 3:
                  case 4:
                  case 5:
                  case 6:
                  case 7:
                  case 8:
                  case 9:
                  case 10:
                  case 11:
                  case 12:
                  case 13:
                  default:
                     this.gameByteStateAE++; break;
               }
            } else {
               this.playAudioCue(0, 4);
               break;
            }
         }
      } catch (System.Exception var3) {
      }
   }

   // $VF: renamed from: T () void
   public void processGameState() {
      switch (this.gameByteStateAZ) {
         case 0:
            this.gameByteStateAP = (sbyte)this.levelEventDefinitions[this.gameIntegerStateAL][0];

            for (int var1 = 0; var1 < 6; var1++) {
               this.activeCharacterState.characterAnimationFlagArrayA[var1] = false;
            }

            this.primaryCharacterState.characterAnimationByteStateD = 127;
            this.gameIntegerStateAJ = this.levelEventDefinitions[this.gameIntegerStateAL][4];
            this.gameIntegerStateAK = this.levelEventDefinitions[this.gameIntegerStateAL][8];
            if (this.isReleasedInputFlagSet(1)) {
               this.gameLongValueE = (long)this.levelEventDefinitions[this.gameIntegerStateAL][7];
            } else {
               this.gameLongValueE = 0L;
            }

            this.gameLongValueH = this.gameLongValueE;
            if (this.isPressedInputFlagSet(32)) {
               this.activeCharacterState.characterAnimationFlagArrayA[5] = true;
               this.primaryCharacterState.characterAnimationByteStateD = 5;
               this.primaryCharacterState.characterAnimationByteStateArrayA[5] = this.levelEventParameters[this.gameIntegerStateAL][5];
               this.setPlayerAction(5);
            }

            if (this.isPressedInputFlagSet(1)) {
               this.activeCharacterState.characterAnimationFlagArrayA[0] = true;
               this.primaryCharacterState.characterAnimationByteStateD = 0;
               this.setPlayerAction(0);
            }

            if (this.isPressedInputFlagSet(16)) {
               this.activeCharacterState.characterAnimationFlagArrayA[4] = true;
               this.primaryCharacterState.characterAnimationByteStateD = 4;
               this.primaryCharacterState.characterAnimationByteStateArrayA[4] = this.levelEventParameters[this.gameIntegerStateAL][4];
               this.setPlayerAction(4);
            }

            if (this.isPressedInputFlagSet(4)) {
               this.activeCharacterState.characterAnimationFlagArrayA[2] = true;
               this.primaryCharacterState.characterAnimationByteStateD = 2;
               this.primaryCharacterState.characterAnimationByteStateArrayA[2] = this.levelEventParameters[this.gameIntegerStateAL][2];
               this.setPlayerAction(2);
            }

            if (this.isPressedInputFlagSet(8)) {
               this.activeCharacterState.characterAnimationFlagArrayA[3] = true;
               this.primaryCharacterState.characterAnimationByteStateD = 3;
               this.primaryCharacterState.characterAnimationByteStateArrayA[3] = this.levelEventParameters[this.gameIntegerStateAL][3];
               this.setPlayerAction(3);
            }

            if (this.isPressedInputFlagSet(2)) {
               this.activeCharacterState.characterAnimationFlagArrayA[1] = true;
               this.primaryCharacterState.characterAnimationByteStateD = 1;
               this.primaryCharacterState.characterAnimationByteStateArrayA[1] = this.levelEventParameters[this.gameIntegerStateAL][1];
               this.setPlayerAction(1);
            }

            this.gameLongValueF = this.gameClockTimeMs;
            this.gameLongValueG = 0L;
            if (this.levelEventDefinitions[this.gameIntegerStateAL][1] == 0) {
               this.releaseObjectImage(145);
               this.releaseObjectImage(147);
               JSystem.gc();
               this.sleepForMilliseconds(1L);
               if (!this.loadObjectImage(141, 47)) {
                  return;
               }
            } else if (this.levelEventDefinitions[this.gameIntegerStateAL][1] == 2) {
               this.releaseObjectImage(141);
               this.releaseObjectImage(147);
               JSystem.gc();
               this.sleepForMilliseconds(1L);
               if (!this.loadObjectImage(145, 36)) {
                  return;
               }
            } else if (this.levelEventDefinitions[this.gameIntegerStateAL][1] == 1) {
               this.releaseObjectImage(141);
               this.releaseObjectImage(145);
               JSystem.gc();
               this.sleepForMilliseconds(1L);
               if (!this.loadObjectImage(147, 12)) {
                  return;
               }
            }
            break;
         case 1:
            this.gameByteStateAP = 0;
            if (this.animationDefinitions[this.gameByteStateBE][5] == 0) {
               this.releaseObjectImage(145);
               this.releaseObjectImage(147);
               JSystem.gc();
               this.sleepForMilliseconds(1L);
               if (!this.loadObjectImage(141, 47)) {
                  return;
               }
            } else if (this.animationDefinitions[this.gameByteStateBE][5] == 2) {
               this.releaseObjectImage(141);
               this.releaseObjectImage(147);
               JSystem.gc();
               this.sleepForMilliseconds(1L);
               if (!this.loadObjectImage(145, 36)) {
                  return;
               }
            } else if (this.animationDefinitions[this.gameByteStateBE][5] == 1) {
               this.releaseObjectImage(141);
               this.releaseObjectImage(145);
               JSystem.gc();
               this.sleepForMilliseconds(1L);
               if (!this.loadObjectImage(147, 12)) {
                  return;
               }
            }

            this.resetActiveActors(false);
            break;
         case 2:
            this.gameByteStateAP = 1;
            if (!this.loadObjectImage(141, 47)) {
               return;
            } break;
      }

      this.timerElapsedOffset = 0;
      this.gameIntegerStateAF = 0;
      this.gameByteStateBA = 1;
      this.gameByteStateBB = 1;
      this.gameShortValueE = 0;
      this.gameIntegerStateAM = 0;
      this.gameByteStateBK = 0;
      this.gameFlagU = false;
      this.gameFlagV = false;
      this.gameByteStateBI = 0;
      this.gameFlagO = false;
      this.gameFlagP = false;
      this.gameFlagQ = false;
      this.gameFlagS = true;
      this.gameFlagT = false;
      this.clearCollectedItemFlags();
   }

   // $VF: renamed from: m (int) boolean
   public bool isPressedInputFlagSet(int var1) {
      return (this.gameIntegerStateAJ & var1) != 0;
   }

   // $VF: renamed from: n (int) boolean
   public bool isReleasedInputFlagSet(int var1) {
      return (this.gameIntegerStateAK & var1) != 0;
   }

   // $VF: renamed from: U () void
   public void clearLevelGrid() {
      for (int var1 = 0; var1 < this.levelGrid.Length; var1++) {
         for (int var2 = 0; var2 < this.levelGrid[var1].Length; var2++) {
            this.levelGrid[var1][var2] = 0;
         }
      }

      this.levelGrid[4][2] = 3;
      this.levelGrid[4][1] = 3;
      this.levelGrid[4][0] = 3;
      this.levelGrid[0][0] = 3;
      this.levelGrid[0][2] = 3;
   }

   // $VF: renamed from: V () void
   public void initializeMedicalItemState() {
      if (this.medicalItemState == null) {
         this.medicalItemState = new ActorAnimationState(this);
      }

      this.medicalItemState.actorAnimationByteStateA = 0;
      this.medicalItemState.actorAnimationByteStateB = 0;
      this.medicalItemState.actorAnimationByteStateC = 0;
      this.medicalItemState.actorAnimationFlagA = false;
      this.medicalItemState.actorAnimationFlagB = false;
      this.medicalItemState.actorAnimationFlagC = true;
      this.medicalItemState.actorAnimationFlagD = false;
      if (this.ammunitionItemState == null) {
         this.ammunitionItemState = new ActorAnimationState(this);
      }

      this.ammunitionItemState.actorAnimationByteStateA = 0;
      this.ammunitionItemState.actorAnimationByteStateB = 0;
      this.ammunitionItemState.actorAnimationByteStateC = 0;
      this.ammunitionItemState.actorAnimationFlagA = false;
      this.ammunitionItemState.actorAnimationFlagB = false;
      this.ammunitionItemState.actorAnimationFlagC = true;
      this.ammunitionItemState.actorAnimationFlagD = false;
      if (this.weaponItemState == null) {
         this.weaponItemState = new ActorAnimationState(this);
      }

      this.weaponItemState.actorAnimationByteStateA = 0;
      this.weaponItemState.actorAnimationByteStateB = 0;
      this.weaponItemState.actorAnimationByteStateC = 0;
      this.weaponItemState.actorAnimationFlagA = false;
      this.weaponItemState.actorAnimationFlagB = false;
      this.weaponItemState.actorAnimationFlagC = true;
      this.weaponItemState.actorAnimationFlagD = false;
   }

   // $VF: renamed from: d (int, int) boolean
   public bool loadObjectImage(int var1, int var2) {
      string var3 = "";
      if (var1 >= 9 && var1 < 89) {
         var3 = var3 + "o" + var2;
      } else if (var1 >= 89 && var1 < 109) {
         var3 = var3 + "t" + var2;
      } else if (var1 >= 109 && var1 < 139) {
         var3 = var3 + "w" + var2;
      } else {
         var3 = GameSpriteAssetData.spriteResourceNames[var2];
      }

      debugLog(var3);
      JSystem.gc();

      try {
         if (this.objectImages[var1] == null) {
         }

         this.objectImages[var1] = Image.createImage("/img/" + var3 + ".png");
      } catch (System.Exception var5) {
         return false;
      }

      return this.objectImages[var1] != null;
   }

   // $VF: renamed from: g (int) void
   public void releaseObjectImage(int var1) {
      if (this.objectImages[var1] != null) {
         this.objectImages[var1] = null;
      }
   }

   // $VF: renamed from: a (int, boolean) void
   public void initializeGameObjects(int var1, bool var2) {
      this.resetActorStates();
      this.gameByteStateAP = (sbyte)var1;
      if (this.loadLevelData()) {
         var2 &= this.isLayerEnabled[this.gameByteStateAP];
         this.isLayerEnabled[this.gameByteStateAP] = true;
         this.activeCharacterState.characterAnimationByteStateE = this.gameByteStateAP;
         this.initializeLevelState();
         this.setActiveActor(this.activeCharacterState.characterAnimationObjectReferenceA, true);
      }
   }

   // $VF: renamed from: h () void
   public void resetWorldObjectStates() {
      for (int var1 = 0; var1 < 5; var1++) {
         this.objectStates[var1].worldObjectFlagA = false;
      }

      for (int var2 = 0; var2 < 10; var2++) {
         this.animatedEntityStates[var2].isAnimationActive = false;
      }
   }

   // $VF: renamed from: i () void
   public void initializeLevelState() {
      this.resetWorldObjectStates();
      this.currentTileType = this.levelTileTypes[this.activeCharacterState.characterAnimationObjectReferenceA.tileX][this.activeCharacterState.characterAnimationObjectReferenceA.tileY];
      this.cameraMinX = 65536;
      this.cameraMinY = 65536;
      this.cameraMaxX = 0;
      this.cameraMaxY = 0;

      for (int var1 = 0; var1 < this.gameByteStateAQ; var1++) {
         for (int var2 = 0; var2 < this.gameByteStateAR; var2++) {
            if (this.currentTileType == this.levelTileTypes[var1][var2]) {
               this.cameraMinX = JMath.min(this.cameraMinX, this.tileToScreenX(var1, var2) - 18);
               this.cameraMaxX = JMath.max(this.cameraMaxX, this.tileToScreenX(var1, var2) + 18 + 36 - this.cameraMinX);
               this.cameraMinY = JMath.min(this.cameraMinY, this.tileToScreenY(var1, var2) - 42);
               this.cameraMaxY = JMath.max(this.cameraMaxY, this.tileToScreenY(var1, var2) + 9 + 18 - this.cameraMinY);
            }
         }
      }

      this.updatePlayerAction();
   }

   // $VF: renamed from: a (u, boolean) void
   public void setActiveActor(ActorRuntimeState var1, bool var2) {
      if (!this.isScreenInitialized || var2) {
         this.activeActorState = var1;
         int var6 = this.tileToScreenX(var1.tileX, var1.tileY);
         int var8 = this.tileToScreenY(var1.tileX, var1.tileY);
         int var9 = var6 + (18 - canvasCenterX);
         int var12 = var8 + (9 - canvasCenterY);
         bool var3 = this.isDirectionWithinRange(var1, 2, 1);
         bool var4 = this.isDirectionWithinRange(var1, 0, 1);
         if (var1.animationFrameIndex == 2) {
            var3 = !var3;
            var4 = !var4;
         }

         if (SpriteAnimationFrameTable.characterShadowGeometry[var1.animationSetIndex][var1.animationFrameIndex][2] != 0) {
            if (var3) {
               var9 += var1.movementProgressFixedPoint * 18 / 65536;
               if (var1.currentShadowDepth >= SpriteAnimationFrameTable.characterShadowGeometry[var1.animationSetIndex][var1.animationFrameIndex][2]) {
                  var9 -= 18;
               }
            } else {
               var9 -= var1.movementProgressFixedPoint * 18 / 65536;
               if (var1.currentShadowDepth >= SpriteAnimationFrameTable.characterShadowGeometry[var1.animationSetIndex][var1.animationFrameIndex][2]) {
                  var9 += 18;
               }
            }

            if (var4) {
               var12 += var1.movementProgressFixedPoint * 9 / 65536;
               if (var1.currentShadowDepth >= SpriteAnimationFrameTable.characterShadowGeometry[var1.animationSetIndex][var1.animationFrameIndex][2]) {
                  var12 -= 9;
               }
            } else {
               var12 -= var1.movementProgressFixedPoint * 9 / 65536;
               if (var1.currentShadowDepth >= SpriteAnimationFrameTable.characterShadowGeometry[var1.animationSetIndex][var1.animationFrameIndex][2]) {
                  var12 += 9;
               }
            }
         }

         sbyte var5;
         if ((this.gameIntegerStateG & 512) == 0 && !this.gameFlagJ && !this.activeCharacterState.characterAnimationFlagD) {
            var5 = 4;
         } else {
            var5 = 8;
         }

         if (this.canActorMoveForward()) {
            var5 = 12;
         }

         if (canvasWidth < this.cameraMaxX) {
            var6 = JMath.min(var9, this.cameraMinX + this.cameraMaxX - canvasWidth);
            var6 = JMath.max(var6, this.cameraMinX);
         } else {
            var6 = this.cameraMinX + this.cameraMaxX / 2 - canvasCenterX;
         }

         if (canvasHeight < this.cameraMaxY) {
            var8 = JMath.min(var12, this.cameraMinY + this.cameraMaxY - canvasHeight);
            var8 = JMath.max(var8, this.cameraMinY);
         } else {
            var8 = this.cameraMinY + this.cameraMaxY / 2 - canvasCenterY;
         }

         if (!var2) {
            if (this.cameraX < var6) {
               var6 = this.cameraX + JMath.min(var6 - this.cameraX, var5);
            }

            if (this.cameraX > var6) {
               var6 = this.cameraX - JMath.min(this.cameraX - var6, var5);
            }

            if (this.cameraY < var8) {
               var8 = this.cameraY + JMath.min(var8 - this.cameraY, var5);
            }

            if (this.cameraY > var8) {
               var8 = this.cameraY - JMath.min(this.cameraY - var8, var5);
            }
         }

         if (var6 == this.cameraX && var8 == this.cameraY) {
            this.gameFlagF = false;
         } else {
            this.gameFlagF = true;
         }

         this.setCameraPosition(var6, var8);
      }
   }

   // $VF: renamed from: W () boolean
   public bool canActorMoveForward() {
      if (this.activeCharacterState.characterAnimationObjectReferenceA.movementDirection == 3) {
         sbyte var3 = (sbyte)(this.activeCharacterState.characterAnimationObjectReferenceA.tileY - 2);
         if (var3 < 0) {
            var3 = 0;
         }

         int var1 = this.tileToScreenX(this.activeCharacterState.characterAnimationObjectReferenceA.tileX, var3) - this.cameraX;
         int var2 = this.tileToScreenY(this.activeCharacterState.characterAnimationObjectReferenceA.tileX, var3) - this.cameraY;
         if (!this.rectanglesOverlap(var1, var2, 36, 18, 0, 0, canvasWidth, canvasHeight)) {
            return true;
         }
      } else if (this.activeCharacterState.characterAnimationObjectReferenceA.movementDirection == 5) {
         sbyte var10 = (sbyte)(this.activeCharacterState.characterAnimationObjectReferenceA.tileX - 2);
         if (var10 < 0) {
            var10 = 0;
         }

         int var4 = this.tileToScreenX(var10, this.activeCharacterState.characterAnimationObjectReferenceA.tileY) - this.cameraX;
         int var7 = this.tileToScreenY(var10, this.activeCharacterState.characterAnimationObjectReferenceA.tileY) - this.cameraY;
         if (!this.rectanglesOverlap(var4, var7, 36, 18, 0, 0, canvasWidth, canvasHeight)) {
            return true;
         }
      } else if (this.activeCharacterState.characterAnimationObjectReferenceA.movementDirection == 1) {
         sbyte var11 = (sbyte)(this.activeCharacterState.characterAnimationObjectReferenceA.tileX + 2);
         if (var11 < 0) {
            var11 = 0;
         }

         int var5 = this.tileToScreenX(var11, this.activeCharacterState.characterAnimationObjectReferenceA.tileY) - this.cameraX;
         int var8 = this.tileToScreenY(var11, this.activeCharacterState.characterAnimationObjectReferenceA.tileY) - this.cameraY;
         if (!this.rectanglesOverlap(var5, var8, 36, 18, 0, 0, canvasWidth, canvasHeight)) {
            return true;
         }
      } else if (this.activeCharacterState.characterAnimationObjectReferenceA.movementDirection == 7) {
         sbyte var12 = (sbyte)(this.activeCharacterState.characterAnimationObjectReferenceA.tileY + 2);
         if (var12 < 0) {
            var12 = 0;
         }

         int var6 = this.tileToScreenX(this.activeCharacterState.characterAnimationObjectReferenceA.tileX, var12) - this.cameraX;
         int var9 = this.tileToScreenY(this.activeCharacterState.characterAnimationObjectReferenceA.tileX, var12) - this.cameraY;
         if (!this.rectanglesOverlap(var6, var9, 36, 18, 0, 0, canvasWidth, canvasHeight)) {
            return true;
         }
      }

      return false;
   }

   // $VF: renamed from: j () boolean
   public bool clearObjectImageCache() {
      for (int var1 = 0; var1 < 183; var1++) {
         this.objectImages[var1] = null;
      }

      return true;
   }

   // $VF: renamed from: k () void
   public void resetActorStates() {
      for (int var1 = 2; var1 < 24; var1++) {
         this.actorStates[var1].isActive = false;
      }

      if (this.primaryCharacterState.characterAnimationObjectReferenceArrayA != null) {
         for (int var2 = 0; var2 < this.primaryCharacterState.characterAnimationByteStateA; var2++) {
            this.primaryCharacterState.characterAnimationObjectReferenceArrayA[var2].frameMarkers = null;
            this.primaryCharacterState.characterAnimationObjectReferenceArrayA[var2].frameDuration = 0;
         }
      }

      this.levelTileFlags = (sbyte[][])null;
      this.levelTileHeights = (short[][])null;
      this.levelTileWidths = (short[][])null;
      this.levelTileTypes = (sbyte[][])null;
   }

   // $VF: renamed from: a (int, int, int, int) u
   public ActorRuntimeState spawnActor(int var1, int var2, int var3, int var4) {
      ActorRuntimeState var5 = null;
      int var6 = 3;

      while (var6 < 24 && !this.actorStates[var6].actorRuntimeFlagF) {
         var6++;
      }

      if (var6 >= 24) {
         return var5;
      } else {
         switch (var1) {
            case 0:
               var5 = this.actorStates[1];
               break;
            case 1:
               var5 = this.actorStates[0]; goto case 5;
            case 5:
               break;
            default:
               var5 = this.actorStates[var6]; break;
         }

         var5.isActive = true;
         var5.animationSetIndex = (sbyte)var1;
         var5.tileX = (sbyte)var2;
         var5.tileY = (sbyte)var3;
         var5.currentShadowDepth = 0;
         var5.previousShadowDepth = 0;
         var5.animationFrameIndex = 0;
         var5.previousAnimationFrameIndex = -1;
         var5.movementProgressFixedPoint = 0;
         var5.targetTileX = -1;
         var5.targetTileY = -1;
         var5.actorRuntimeFlagB = false;
         var5.actorRuntimeFlagC = false;
         var5.actorRuntimeFlagD = false;
         var5.elapsedTimerA = 0L;
         var5.elapsedTimerB = 0L;
         var5.animationOverrideFrame = 127;
         var5.actorRuntimeFlagE = false;
         var5.optionalTimer = 0L;
         var5.actorRuntimeFlagF = false;
         var5.actorRuntimeByteStateN = 1;
         switch (var5.animationSetIndex) {
            case 0:
            case 1:
               var5.actionCounter = 16;
               var5.actionCounterLimit = 16;
               if (this.gameByteStateAZ == 0) {
                  var5.actionCounter = (sbyte)this.levelEventDefinitions[this.gameIntegerStateAL][6];
               }

               this.drawActorShadow(var5, 0);
               break;
            case 2:
            case 4:
               sbyte var9;
               if (this.gameByteStateAZ == 0) {
                  var9 = 20;
               } else if (this.gameByteStateAZ == 2) {
                  if (this.gameIntegerStateAF > this.animationTimingThresholds[this.animationTimingThresholds.Length - 1]) {
                     if (this.gameIntegerStateAF - this.animationTimingThresholds[this.animationTimingThresholds.Length - 1] > 10 && this.gameIntegerStateAF - this.animationTimingThresholds[this.animationTimingThresholds.Length - 1] < 20) {
                        var9 = 10;
                     } else if (this.gameIntegerStateAF - this.animationTimingThresholds[this.animationTimingThresholds.Length - 1] >= 20
                        && this.gameIntegerStateAF - this.animationTimingThresholds[this.animationTimingThresholds.Length - 1] < 30) {
                        var9 = 20;
                     } else if (this.gameIntegerStateAF - this.animationTimingThresholds[this.animationTimingThresholds.Length - 1] >= 30) {
                        var9 = 30;
                     } else {
                        var9 = 0;
                     }
                  } else {
                     var9 = 0;
                  }
               } else {
                  var9 = 0;
               }

               if (this.gameByteStateBA != 1) {
                  if (nextRandomBelow(100) < 40 + var9) {
                     var5.actorRuntimeByteStateN = this.gameByteStateBA;
                  }
               } else {
                  var5.actorRuntimeByteStateN = 1;
               }

               var5.actionCounter = 10;
               var5.actionCounterLimit = 10;
               this.drawActorShadow(var5, 0);
               break;
            case 3:
            case 5:
            case 7:
            default:
               var5.actionCounter = 10;
               var5.actionCounterLimit = 10;
               this.drawActorShadow(var5, 0);
               break;
            case 6:
               sbyte var8;
               if (this.gameByteStateAZ == 0) {
                  var8 = 60;
               } else if (this.gameByteStateAZ == 2) {
                  if (this.gameIntegerStateAF > this.animationTimingThresholds[this.animationTimingThresholds.Length - 1]) {
                     if (this.gameIntegerStateAF - this.animationTimingThresholds[this.animationTimingThresholds.Length - 1] > 10 && this.gameIntegerStateAF - this.animationTimingThresholds[this.animationTimingThresholds.Length - 1] < 20) {
                        var8 = 10;
                     } else if (this.gameIntegerStateAF - this.animationTimingThresholds[this.animationTimingThresholds.Length - 1] >= 20
                        && this.gameIntegerStateAF - this.animationTimingThresholds[this.animationTimingThresholds.Length - 1] < 30) {
                        var8 = 20;
                     } else if (this.gameIntegerStateAF - this.animationTimingThresholds[this.animationTimingThresholds.Length - 1] >= 30) {
                        var8 = 30;
                     } else {
                        var8 = 0;
                     }
                  } else {
                     var8 = 0;
                  }
               } else {
                  var8 = 0;
               }

               if (this.gameByteStateBA != 1) {
                  if (nextRandomBelow(100) < 40 + var8) {
                     var5.actorRuntimeByteStateN = this.gameByteStateBA;
                  }
               } else {
                  var5.actorRuntimeByteStateN = 1;
               }

               var5.actionCounter = 60;
               var5.actionCounterLimit = 60;
               this.drawActorShadow(var5, 0);
               break;
            case 8:
               sbyte var7;
               if (this.gameByteStateAZ == 0) {
                  var7 = 20;
               } else if (this.gameByteStateAZ == 2) {
                  if (this.gameIntegerStateAF > this.animationTimingThresholds[this.animationTimingThresholds.Length - 1]) {
                     if (this.gameIntegerStateAF - this.animationTimingThresholds[this.animationTimingThresholds.Length - 1] > 10 && this.gameIntegerStateAF - this.animationTimingThresholds[this.animationTimingThresholds.Length - 1] < 20) {
                        var7 = 10;
                     } else if (this.gameIntegerStateAF - this.animationTimingThresholds[this.animationTimingThresholds.Length - 1] >= 20
                        && this.gameIntegerStateAF - this.animationTimingThresholds[this.animationTimingThresholds.Length - 1] < 30) {
                        var7 = 20;
                     } else if (this.gameIntegerStateAF - this.animationTimingThresholds[this.animationTimingThresholds.Length - 1] >= 30) {
                        var7 = 30;
                     } else {
                        var7 = 0;
                     }
                  } else {
                     var7 = 0;
                  }
               } else {
                  var7 = 0;
               }

               if (this.gameByteStateBA != 1) {
                  if (nextRandomBelow(100) < 40 + var7) {
                     var5.actorRuntimeByteStateN = this.gameByteStateBA;
                  }
               } else {
                  var5.actorRuntimeByteStateN = 1;
               }

               var5.actionCounter = 20;
               var5.actionCounterLimit = 20;
               this.drawActorShadow(var5, 0); break;
         }

         this.setActorDirection(var5, var4);
         return var5;
      }
   }

   // $VF: renamed from: l () boolean
   public bool loadLevelData() {
      this.levelArtworkRenderer.clearSpriteAtlas();
      JSystem.gc();
      if (this.gameByteStateAP == 0) {
         this.loadLevelObjectCoordinates("/data/reu01_large_object_coords.bin");
         this.gameShortValueA = 9;
         this.gameShortValueB = 2;
         this.levelArtworkImage = GameCanvas.loadImageResource("/img/level_art_01.png");
         this.levelArtworkRenderer.setSpriteAtlas(this.levelArtworkImage, HudSpriteRegionTable.spriteRegions);
      } else if (this.gameByteStateAP == 1) {
         this.loadLevelObjectCoordinates("/data/reu02_large_object_coords.bin");
         this.gameShortValueA = 9;
         this.gameShortValueB = 2;
         this.levelArtworkImage = GameCanvas.loadImageResource("/img/level_art_01.png");
         this.levelArtworkRenderer.setSpriteAtlas(this.levelArtworkImage, HudSpriteRegionTable.spriteRegions);
      }

      short[] var3 = new short[levelDataLengths[this.gameByteStateAP]];
      if (!this.readUnsignedResourceBytes(var3, levelDataPaths[this.gameByteStateAP], levelDataLengths[this.gameByteStateAP])) {
         return false;
      } else {
         int var6 = 0;
         this.gameByteStateAQ = (sbyte)var3[var6++];
         this.gameByteStateAR = (sbyte)var3[var6++];
         this.levelPixelWidthHalf = this.gameByteStateAQ * 36 / 2;
         this.levelTileFlags = JArr.New2<sbyte>(this.gameByteStateAQ, this.gameByteStateAR);
         this.levelTileHeights = JArr.New2<short>(this.gameByteStateAQ, this.gameByteStateAR);
         this.levelTileWidths = JArr.New2<short>(this.gameByteStateAQ, this.gameByteStateAR);
         this.levelTileTypes = JArr.New2<sbyte>(this.gameByteStateAQ, this.gameByteStateAR);

         for (int var4 = 0; var4 < this.gameByteStateAQ; var4++) {
            for (int var5 = 0; var5 < this.gameByteStateAR; var5++) {
               this.levelTileFlags[var4][var5] = (sbyte)var3[var6++];
            }
         }

         for (int var8 = 0; var8 < this.gameByteStateAQ; var8++) {
            for (int var12 = 0; var12 < this.gameByteStateAR; var12++) {
               this.levelTileWidths[var8][var12] = var3[var6++];
               this.levelTileWidths[var8][var12] = (short)(this.levelTileWidths[var8][var12] << 8);
               this.levelTileWidths[var8][var12] = (short)(this.levelTileWidths[var8][var12] | var3[var6++]);
            }
         }

         for (int var9 = 0; var9 < this.gameByteStateAQ; var9++) {
            for (int var13 = 0; var13 < this.gameByteStateAR; var13++) {
               this.levelTileHeights[var9][var13] = var3[var6++];
               this.levelTileHeights[var9][var13] = (short)(this.levelTileHeights[var9][var13] << 8);
               this.levelTileHeights[var9][var13] = (short)(this.levelTileHeights[var9][var13] | var3[var6++]);
            }
         }

         for (int var10 = 0; var10 < this.gameByteStateAQ; var10++) {
            for (int var14 = 0; var14 < this.gameByteStateAR; var14++) {
               this.levelTileTypes[var10][var14] = (sbyte)var3[var6++];
            }
         }

         this.levelObjectCount = (short)(var3[var6++] << 8);
         this.levelObjectCount = (short)(this.levelObjectCount + var3[var6++]);
         this.levelObjects = new ActorAnimationState[this.levelObjectCount];

         for (int var11 = 0; var11 < this.levelObjectCount; var11++) {
            this.levelObjects[var11] = new ActorAnimationState(this);
            this.levelObjects[var11].actorAnimationByteStateA = (sbyte)var3[var6++];
            this.levelObjects[var11].actorAnimationByteStateB = (sbyte)var3[var6++];
            this.levelObjects[var11].actorAnimationByteStateC = (sbyte)var3[var6++];
            this.levelObjects[var11].actorAnimationFlagA = var3[var6++] != 0;
            this.levelObjects[var11].actorAnimationFlagB = var3[var6++] != 0;
            this.levelObjects[var11].actorAnimationFlagC = var3[var6++] != 0;
            this.levelObjects[var11].actorAnimationFlagD = var3[var6++] != 0;
            this.levelObjects[var11].actorAnimationByteStateD = (sbyte)var3[var6++];
            this.levelObjects[var11].actorAnimationObjectReferenceArrayA = new GameAnimationTrack[this.levelObjects[var11].actorAnimationByteStateD];

            for (int var15 = 0; var15 < this.levelObjects[var11].actorAnimationByteStateD; var15++) {
               this.levelObjects[var11].actorAnimationObjectReferenceArrayA[var15] = new GameAnimationTrack(this);
               this.levelObjects[var11].actorAnimationObjectReferenceArrayA[var15].gameAnimationByteStateA = (sbyte)var3[var6++];
               this.levelObjects[var11].actorAnimationObjectReferenceArrayA[var15].gameAnimationByteStateB = (sbyte)var3[var6++];
               this.levelObjects[var11].actorAnimationObjectReferenceArrayA[var15].gameAnimationByteStateC = (sbyte)var3[var6++];
               this.levelObjects[var11].actorAnimationObjectReferenceArrayA[var15].gameAnimationFlagA = var3[var6++] != 0;
               this.levelObjects[var11].actorAnimationObjectReferenceArrayA[var15].gameAnimationFlagB = var3[var6++] != 0;
            }
         }

         var3 = null;
         JSystem.gc();
         this.validateLevelData();
         return true;
      }
   }

   // $VF: renamed from: a (java.lang.String) void
   public void loadLevelObjectCoordinates(string var1) {
      InputStream var2 = null;
      DataInputStream var3 = null;

      try {
         var2 = this.getClass().getResourceAsStream(var1);
         var3 = new DataInputStream(var2);
         int var5 = var3.readShort() / 13;
         this.levelObjectProperties = new short[var5][];

         for (int var4 = 0; var4 < var5; var4++) {
            this.levelObjectProperties[var4] = new short[9];
            this.levelObjectProperties[var4][0] = var3.readShort();
            this.levelObjectProperties[var4][1] = var3.readShort();
            this.levelObjectProperties[var4][2] = var3.readShort();
            this.levelObjectProperties[var4][3] = var3.readShort();
            this.levelObjectProperties[var4][4] = (short)var3.readByte();
            this.levelObjectProperties[var4][5] = (short)var3.readByte();
            this.levelObjectProperties[var4][6] = (short)var3.readByte();
            this.levelObjectProperties[var4][7] = (short)var3.readByte();
            this.levelObjectProperties[var4][8] = (short)var3.readByte();
         }
      } catch (System.Exception var14) {
      } finally {
         try {
            if (var3 != null) {
               var3.close();
            }

            if (var2 != null) {
               var2.close();
            }
         } catch (IOException var13) {
         }
      }
   }

   // $VF: renamed from: a (short[], java.lang.String, int) boolean
   public bool readUnsignedResourceBytes(short[] var1, string var2, int var3) {
      InputStream var4 = null;
      DataInputStream var5 = null;

      bool var8;
      try {
         var4 = this.getClass().getResourceAsStream(var2);
         var5 = new DataInputStream(var4);

         for (int var6 = 0; var6 < var3; var6++) {
            var1[var6] = (short)var5.readByte();
            if (var1[var6] < 0) {
               var1[var6] = (short)(var1[var6] + 256);
            }
         }

         return true;
      } catch (System.Exception var18) {
         var8 = false;
      } finally {
         try {
            if (var4 != null) {
               var4.close();
            }

            if (var5 != null) {
               var5.close();
            }
         } catch (IOException var17) {
         }
      }

      return var8;
   }

   // $VF: renamed from: m () boolean
   public bool validateLevelData() {
      int var5 = 0;

      while (var5 < this.levelObjectCount) {
         var5++;
      }

      for (int var7 = 0; var7 < this.gameByteStateAQ; var7++) {
         for (int var6 = 0; var6 < this.gameByteStateAR; var6++) {
            if (this.levelTileFlags[var7][var6] == 127) {
            }
         }
      }

      for (int var8 = 0; var8 < this.gameByteStateAQ; var8++) {
         for (int var9 = 0; var9 < this.gameByteStateAR; var9++) {
            int var1 = this.levelTileHeights[var8][var9] >> 8 & 0xFF;
            int var2 = this.levelTileHeights[var8][var9] & 255;
            int var3 = this.levelTileWidths[var8][var9] >> 8 & 0xFF;
            int var4 = this.levelTileWidths[var8][var9] & 255;
            if (var1 != 255) {
            }

            if (var2 != 255) {
            }

            if (var3 != 255) {
            }

            if (var4 != 255) {
            }
         }
      }

      return true;
   }

   // $VF: renamed from: n () void
   public void initializeActorStates() {
      if (!this.isScreenInitialized) {
         for (int var1 = 0; var1 < 24; var1++) {
            if (this.actorStates[var1].isActive) {
               this.actorStates[var1].actorRuntimeFlagC = false;
            }
         }

         for (int var2 = 0; var2 < 5; var2++) {
            if (this.objectStates[var2].worldObjectFlagA) {
               this.objectStates[var2].worldObjectFlagB = false;
            }
         }

         for (int var3 = 0; var3 < 10; var3++) {
            if (this.animatedEntityStates[var3].isAnimationActive) {
               this.animatedEntityStates[var3].objectState.worldObjectFlagB = false;
            }
         }
      }
   }

   // $VF: renamed from: a (u, int) void
   public void drawActorShadow(ActorRuntimeState var1, int var2) {
      if (this.activeCharacterState.characterAnimationObjectReferenceA.actionCounter > 0 || var2 != 5) {
         if (SpriteAnimationFrameTable.characterShadowGeometry[var1.animationSetIndex][var2][0] == 0) {
            var2 = 1;
         }

         if ((this.gameIntegerStateG & 512) != 0 || this.gameFlagJ || var1.animationSetIndex == 1 && this.primaryCharacterState.characterAnimationFlagD) {
            if (var2 == 0 && SpriteAnimationFrameTable.characterShadowGeometry[var1.animationSetIndex].Length >= 8 && SpriteAnimationFrameTable.characterShadowGeometry[var1.animationSetIndex][8][0] != 0) {
               var2 = 8;
            }

            if (var2 == 1 && SpriteAnimationFrameTable.characterShadowGeometry[var1.animationSetIndex].Length >= 12 && SpriteAnimationFrameTable.characterShadowGeometry[var1.animationSetIndex][12][0] != 0) {
               var2 = 12;
            }

            if (var2 == 12 && var1.animationFrameIndex == 12) {
               var2 = 13;
            }

            if ((var1.animationSetIndex == 0 || var1.animationSetIndex == 1) && var1.animationOverrideFrame != 127) {
               if (var2 == 8 && (this.activeCharacterState.characterAnimationByteStateD == 1 || this.activeCharacterState.characterAnimationByteStateD == 2)) {
                  var2 = 9;
               }

               if (var2 == 8 && (this.activeCharacterState.characterAnimationByteStateD == 3 || this.activeCharacterState.characterAnimationByteStateD == 4)) {
                  var2 = 10;
               }

               if (var2 == 8 && this.activeCharacterState.characterAnimationByteStateD == 0) {
                  var2 = 11;
               }

               if (var2 == 5 && (this.activeCharacterState.characterAnimationByteStateD == 3 || this.activeCharacterState.characterAnimationByteStateD == 4)) {
                  var2 = 6;
               }
            }

            if ((var1.animationSetIndex == 0 || var1.animationSetIndex == 1) && var1.animationOverrideFrame == 127 && var2 == 8 && this.activeCharacterState.characterAnimationByteStateD == 0) {
               var2 = 11;
            }
         }

         var1.animationFrameIndex = (sbyte)var2;
         var1.movementProgressFixedPoint = 0;
         var1.currentShadowDepth = 0;
         var1.actorRuntimeFlagB = true;
         var1.actorRuntimeFlagC = true;
         var1.elapsedTimerA = this.gameClockTimeMs;
         if (var2 == 5 || var2 == 6 || var2 == 7 || var2 == 14) {
            var1.elapsedTimerB = this.gameClockTimeMs;
         }

         if (SpriteAnimationFrameTable.characterShadowGeometry[var1.animationSetIndex][var1.animationFrameIndex][2] != 0 && var1.movementDirection % 2 == 0) {
            this.setActorDirection(var1, var1.movementDirection + 1);
         }
      }
   }

   // $VF: renamed from: b (u, int) void
   public void setActorDirection(ActorRuntimeState var1, int var2) {
      var2 = (var2 + 8) % 8;
      var1.movementDirection = (sbyte)var2;
   }

   // $VF: renamed from: o () void
   public void prepareMainMenuImages() {
      while (this.gameByteStateAE <= 16) {
         switch (this.gameByteStateAE) {
            case 1:
               if (this.gameLogoImage == null) {
                  this.gameLogoImage = GameCanvas.loadImageResource("/img/logo.png");
               }

               if (this.gameImageResourceA == null) {
               }

               if (this.publisherLogoImage == null) {
                  this.publisherLogoImage = GameCanvas.loadImageResource("/img/capcom_2009.png");
               }

               this.gameFlagZ = false; goto case 2;
            case 2:
            case 3:
            case 4:
            case 5:
            default:
               break;
            case 6:
               screenActionCodeA = 0; break;
         }

         this.gameByteStateAE++;
      }
   }

   // $VF: renamed from: X () void
   public void advanceScreenInitializationMode10() {
      while (this.gameByteStateAE <= 16) {
         switch (this.gameByteStateAE) {
            case 1:
            default:
               this.gameByteStateAE++; break;
         }
      }
   }

   // $VF: renamed from: p () void
   public void setLocalizedScreenMessage() {
      while (this.gameByteStateAE <= 16) {
         switch (this.gameByteStateAE) {
            case 1:
               this.setPendingMessage(this.localizedText[9]); goto default;
            default:
               this.gameByteStateAE++; break;
         }
      }
   }

   // $VF: renamed from: q () void
   public void advanceScreenInitializationMode6() {
      while (this.gameByteStateAE <= 16) {
         switch (this.gameByteStateAE) {
            case 1:
            default:
               this.gameByteStateAE++; break;
         }
      }
   }

   // $VF: renamed from: r () void
   public void advanceScreenInitializationMode22() {
      while (this.gameByteStateAE <= 16) {
         switch (this.gameByteStateAE) {
            case 1:
            default:
               this.gameByteStateAE++; break;
         }
      }
   }

   // $VF: renamed from: s () void
   public void advanceScreenInitializationMode16() {
      while (this.gameByteStateAE <= 16) {
         switch (this.gameByteStateAE) {
            case 1:
            default:
               this.gameByteStateAE++; break;
         }
      }
   }

   // $VF: renamed from: t () void
   public void advanceScreenInitializationMode18() {
      while (this.gameByteStateAE <= 16) {
         switch (this.gameByteStateAE) {
            case 1:
            default:
               this.gameByteStateAE++; break;
         }
      }
   }

   // $VF: renamed from: u () void
   public void advanceScreenInitializationMode17() {
      while (this.gameByteStateAE <= 16) {
         switch (this.gameByteStateAE) {
            case 1:
            default:
               this.gameByteStateAE++; break;
         }
      }
   }

   // $VF: renamed from: v () void
   public void advanceScreenInitializationMode20() {
      while (this.gameByteStateAE <= 16) {
         switch (this.gameByteStateAE) {
            case 1:
            default:
               this.gameByteStateAE++; break;
         }
      }
   }

   // $VF: renamed from: w () void
   public void advanceScreenInitializationMode19() {
      while (this.gameByteStateAE <= 16) {
         switch (this.gameByteStateAE) {
            case 1:
            default:
               this.gameByteStateAE++; break;
         }
      }
   }

   // $VF: renamed from: x () void
   public void advanceScreenInitializationMode21() {
      while (this.gameByteStateAE <= 16) {
         switch (this.gameByteStateAE) {
            case 1:
            default:
               this.gameByteStateAE++; break;
         }
      }
   }

   // $VF: renamed from: Y () void
   public void advanceScreenInitializationMode8() {
      while (this.gameByteStateAE <= 16) {
         switch (this.gameByteStateAE) {
            case 1:
            default:
               this.gameByteStateAE++; break;
         }
      }
   }

   // $VF: renamed from: Z () void
   public void releaseResourcesForScreenAction() {
      switch (screenActionCodeC) {
         case 4:
            this.gameLogoImage = null;
            this.publisherLogoImage = null;
            break;
         case 5:
         case 19:
         case 20:
         case 21:
         case 22:
            debugLog("unloading game resources");
            this.releaseObjectImage(0);
            this.releaseObjectImage(6);
            this.releaseObjectImage(141);
            this.releaseObjectImage(140);
            this.releaseObjectImage(150);
            this.releaseObjectImage(8);
            this.releaseObjectImage(2);
            this.releaseObjectImage(145);

            for (int var1 = 0; var1 < this.itemPortraitCount; var1++) {
               this.itemPortraitImages[var1] = null;
            }

            this.medkitImage = null;
            this.levelArtworkImage = null;
            this.zombiePortraitImage = null;
            this.leonPortraitImage = null;
            this.ammunitionImage = null;
            this.weaponImage = null;
            this.unarmedWeaponImage = null;
            this.levelArtworkRenderer.clearSpriteAtlas(); goto case 6;
         case 6:
         case 7:
         case 8:
         case 9:
         case 10:
         case 11:
         case 12:
         case 13:
         case 14:
         case 15:
         case 16:
         case 17:
         case 18: break;
      }

      JSystem.gc();

      try {
         Thread.sleep(10L);
      } catch (System.Exception var3) {
      }
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics) void
   public void renderScreen(Graphics var1) {
      this.gameCanvas.setGraphicsClip(var1, 0, 0, canvasWidth, canvasHeight);
      if (GameCanvas.isCanvasHidden) {
         this.renderCanvasHiddenPrompt(var1);
      } else {
         bool var2 = true;
         switch (gameModeCode) {
            case 0:
               this.renderStartupScreen(var1);
               break;
            case 1:
               this.renderMenuOverlayMode1(var1); goto case 2;
            case 2:
            case 3:
            case 9:
            case 11:
            case 13:
            case 14:
            case 15:
            default:
               break;
            case 4:
               this.renderTitleScreen(var1);
               break;
            case 5:
               this.clearCanvas(var1);
               break;
            case 6:
               this.renderMenuOverlayMode6(var1);
               break;
            case 7:
               this.renderDialogMenuScreen(var1);
               break;
            case 8:
               this.renderActionScreen(var1);
               break;
            case 10:
               this.renderMessageDialogMode10(var1);
               break;
            case 12:
               this.renderConfirmationMenuScreen(var1);
               break;
            case 16:
               this.renderMenuWithDescriptionMode16(var1);
               break;
            case 17:
               this.renderLevelSelectionDialog(var1);
               break;
            case 18:
               this.renderMenuOverlayMode18(var1);
               break;
            case 19:
               this.renderMenuOverlayMode19(var1);
               break;
            case 20:
               this.renderDialogAndMenuMode20(var1);
               break;
            case 21:
               this.renderMenuOverlayMode21(var1);
               break;
            case 22:
               this.renderDialogAndMenuMode22(var1); break;
         }

         if (var2) {
            this.renderCharacterPortraitHud(var1);
         }

         if (this.isCheatModeEnabled) {
            this.gameCanvas.setGraphicsRgbColor(var1, 255, 0, 0);
            this.gameCanvas.fillCanvasRectangle(var1, 0, 0, 2, 2);
         }
      }
   }

   // $VF: renamed from: y () void
   public void updateScreen() {
      this.isCheatModeEnabled = CapcomMIDlet.cheatsEnabled;
      if (GameCanvas.isCanvasHidden) {
         this.gameCanvas.repaintImmediately();
         if ((this.gameIntegerStateA & 32) != 0) {
            GameCanvas.isCanvasHidden = false;
         }

         this.clearGameActionFlags();
      } else if (gameFlagW) {
         gameFlagW = false;
      } else {
         gameFlagW = true;
         if (this.isGameScreenActive) {
            try {
               if (!this.hasScreenStarted) {
                  this.updateFrameTiming();
               }

               switch (gameModeCode) {
                  case 0:
                     this.updateMissionCompletion();
                     break;
                  case 1:
                     this.configureCreditsScreen(); goto case 2;
                  case 2:
                  case 9:
                  case 11:
                  case 13:
                  case 14:
                  case 15:
                  default:
                     break;
                  case 3:
                     this.initializeGameMode();
                     break;
                  case 4:
                     this.processMenuAction();
                     break;
                  case 5:
                     this.updateGameModeState();
                     break;
                  case 6:
                     this.configureGameOverScreen();
                     break;
                  case 7:
                     this.closeMessageDialog();
                     break;
                  case 8:
                     this.processScreenAction();
                     break;
                  case 10:
                     this.clearMainMenu();
                     break;
                  case 12:
                     this.closeMessageAndMenu();
                     break;
                  case 16:
                     this.resetMenuState();
                     break;
                  case 17:
                     this.configureDialogChoiceLayout();
                     break;
                  case 18:
                     this.configureRestartConfirmation();
                     break;
                  case 19:
                     this.configureLanguageMenu();
                     break;
                  case 20:
                     this.configureSoundOptionsMenu();
                     break;
                  case 21:
                     this.configureControlOptionsMenu();
                     break;
                  case 22:
                     this.configureExitOptionsMenu(); break;
               }

               this.updateTickCount++;
               this.renderTickCount++;
               if (!this.isAudioDisposed && this.audioCommandSink != null) {
                  this.audioCommandSink.processNextAudioCommand();
               }

               if (this.mainMenu != null) {
                  this.mainMenu.c();
               }

               this.clearGameActionFlags();
               this.gameCanvas.repaintImmediately();
               Thread.sleep(1L);
            } catch (System.Exception var2) {
            }
         }
      }
   }

   // $VF: renamed from: aa () void
   public void initializeGameMode() {
      this.gameByteStateAF = 0;
      if (this.gameByteStateAE == 0) {
         bool var1 = true;
         switch (screenActionCodeB) {
            case 7:
            case 8:
            case 12:
               var1 = false; goto default;
            default:
               if (var1 && screenActionCodeB != 5 && screenActionCodeB != 18) {
                  this.releaseResourcesForScreenAction();
               } break;
         }
      }

      this.gameByteStateAE++;
      switch (screenActionCodeB) {
         case 1:
            this.gameFlagB = true;
            this.configureLanguageSelectionMenu();
            this.initializeCurrentScreen();
            switch (screenActionCodeC) {
               case 0:
                  this.setCharacterPortraitIndices((sbyte)0, (sbyte)4);
                  break;
               default:
                  this.setCharacterPortraitIndices((sbyte)0, (sbyte)2); break;
            } goto case 2;
         case 2:
         case 3:
         case 9:
         case 11:
         case 13:
         case 14:
         case 15:
         default:
            break;
         case 4:
            this.prepareMainMenuImages();
            this.configureMainMenu();
            this.setCharacterPortraitIndices((sbyte)0, (sbyte)4);
            break;
         case 5:
            this.gameFlagB = true;
            this.initializeGameplay();
            this.setCharacterPortraitIndices((sbyte)5, (sbyte)3);
            break;
         case 6:
            this.advanceScreenInitializationMode6();
            this.configureHelpMenu();
            this.setCharacterPortraitIndices((sbyte)0, (sbyte)2);
            break;
         case 7:
            this.configureAboutDialog();
            this.setCharacterPortraitIndices((sbyte)-1, (sbyte)2);
            break;
         case 8:
            this.advanceScreenInitializationMode8();
            this.configureContinueMenu();
            this.setCharacterPortraitIndices((sbyte)0, (sbyte)2);
            break;
         case 10:
            this.advanceScreenInitializationMode10();
            this.configureMessageAndChoiceMenu();
            if (screenActionCodeC != 0 && screenActionCodeC != 1) {
               this.setCharacterPortraitIndices((sbyte)0, (sbyte)2);
            } else {
               this.setCharacterPortraitIndices((sbyte)0, (sbyte)-1);
            }
            break;
         case 12:
            this.setLocalizedScreenMessage();
            this.configureInformationDialog();
            this.setCharacterPortraitIndices((sbyte)-1, (sbyte)2);
            break;
         case 16:
            this.advanceScreenInitializationMode16();
            this.configureMissionMenu();
            this.setCharacterPortraitIndices((sbyte)0, (sbyte)2);
            break;
         case 17:
            this.advanceScreenInitializationMode17();
            this.configureLevelSelectionMenu();
            this.setCharacterPortraitIndices((sbyte)0, (sbyte)2);
            break;
         case 18:
            this.advanceScreenInitializationMode18();
            this.configureOptionsMenu();
            this.setCharacterPortraitIndices((sbyte)0, (sbyte)2);
            break;
         case 19:
            this.advanceScreenInitializationMode19();
            this.configureNewGameMenu();
            this.setCharacterPortraitIndices((sbyte)0, (sbyte)-1);
            break;
         case 20:
            this.advanceScreenInitializationMode20();
            this.configureConfirmationDialog();
            this.setCharacterPortraitIndices((sbyte)0, (sbyte)-1);
            break;
         case 21:
            this.advanceScreenInitializationMode21();
            this.configureSaveGameMenu();
            this.setCharacterPortraitIndices((sbyte)0, (sbyte)-1);
            break;
         case 22:
            this.advanceScreenInitializationMode22();
            this.configureExitDialog();
            this.setCharacterPortraitIndices((sbyte)0, (sbyte)-1); break;
      }

      if (this.gameByteStateAE > 16) {
         gameModeCode = screenActionCodeB;
         this.updateTickCount = 0;
         this.gameFlagB = false;
      }
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, java.lang.String) void
   public void drawScrollingMessage(Graphics var1, string var2) {
      this.gameCanvas.setGraphicsRgbColor(var1, 0, 0, 0);
      this.gameCanvas.fillCanvasRectangle(var1, 0, 0, canvasWidth, canvasHeight);
      if (this.gameImageResourceA != null) {
      }

      sbyte var3 = 2;
      sbyte var4 = 4;
      sbyte var5 = 2;
      if (this.fontRenderer != null) {
         this.gameCanvas.setGraphicsColor(var1, 8355711);
         this.fontRenderer.drawClippedOrScrollingText(var1, var2, var3 + var5, var4 + 1, canvasWidth - var3 * 2, 1, 0, this.updateTickCount * 2, canvasWidth / 2, canvasWidth / 2);
         this.gameCanvas.setGraphicsColor(var1, 16777215);
         this.fontRenderer.drawClippedOrScrollingText(var1, var2, var3, var4, canvasWidth - var3 * 2, 1, 0, this.updateTickCount * 2, canvasWidth / 2, canvasWidth / 2);
      }
   }

   // $VF: renamed from: e (javax.microedition.lcdui.Graphics) void
   public void renderTitleScreen(Graphics var1) {
      this.drawScrollingMessage(var1, this.pendingMessage);
      if (this.gameLogoImage != null) {
         this.gameCanvas.drawImage(var1, this.gameLogoImage, canvasCenterX, 2, 17);
      }

      if (this.mainMenu != null) {
         this.mainMenu.a(var1);
      }

      if (this.publisherLogoImage != null) {
         this.gameCanvas.drawImage(var1, this.publisherLogoImage, canvasCenterX, canvasHeight - 4, 33);
      }
   }

   // $VF: renamed from: f (javax.microedition.lcdui.Graphics) void
   public void renderDialogMenuScreen(Graphics var1) {
      this.drawScrollingMessage(var1, this.pendingMessage);
      if (this.messageDialog != null) {
         this.messageDialog.drawOverlay(var1);
      }
   }

   // $VF: renamed from: g (javax.microedition.lcdui.Graphics) void
   public void renderConfirmationMenuScreen(Graphics var1) {
      this.drawScrollingMessage(var1, this.pendingMessage);
      if (this.messageDialog != null) {
         this.messageDialog.drawOverlay(var1);
      }
   }

   // $VF: renamed from: h (javax.microedition.lcdui.Graphics) void
   public void renderStartupScreen(Graphics var1) {
      int var2 = canvasWidth;
      int var3 = canvasHeight;
      this.gameCanvas.setGraphicsRgbColor(var1, 0, 0, 0);
      this.gameCanvas.fillCanvasRectangle(var1, 0, 0, canvasWidth, canvasHeight);
      if (this.isGameAssetsLoaded) {
         this.gameCanvas.setGraphicsClip(var1, 0, 0, this.gameCanvas.getWidth(), this.gameCanvas.getHeight());
         this.gameCanvas.fillCanvasRectangle(var1, 0, 0, this.gameCanvas.getWidth(), this.gameCanvas.getHeight());
         var2 = this.gameCanvas.getWidth();
         var3 = this.gameCanvas.getHeight();
         this.gameCanvas.setGraphicsClip(var1, 0, 0, canvasWidth, canvasHeight);
      }

      this.gameCanvas.drawImage(var1, this.capcomLogoImage, (var2 - this.capcomLogoImage.getWidth()) / 2, (var3 - this.capcomLogoImage.getHeight()) / 2, 20);
   }

   // $VF: renamed from: i (javax.microedition.lcdui.Graphics) void
   public void renderActionScreen(Graphics var1) {
      this.drawScrollingMessage(var1, this.pendingMessage);
      switch (screenActionCodeA) {
         case 0:
            if (this.messageDialog != null) {
               this.messageDialog.drawOverlay(var1);
            }

            if (this.mainMenu != null) {
               this.mainMenu.a(var1);
            }
            break;
         case 1:
            this.messageDialog.drawOverlay(var1); break;
      }
   }

   // $VF: renamed from: j (javax.microedition.lcdui.Graphics) void
   public void clearCanvas(Graphics var1) {
      this.gameCanvas.setGraphicsColor(var1, 0);
      this.gameCanvas.fillCanvasRectangle(var1, 0, 0, canvasWidth, canvasHeight);
      if (this.gameIntegerStateG == 138) {
         switch (this.gameByteStateAJ) {
            case 0:
               this.renderTitleBackground(var1);
               break;
            case 1:
               this.renderInventoryView(var1);
               break;
            case 2:
               this.renderGameplayView(var1); break;
         }
      } else {
         this.resetScreenState();
         this.renderLevelScene(var1);
         this.collectVisibleEntities(var1);
         if (this.gameByteStateAZ == 0 && !this.gameFlagS) {
            this.gameCanvas.setGraphicsColor(var1, 0);
            this.gameCanvas.fillCanvasRectangle(var1, 0, 0, canvasWidth, canvasHeight);
         }

         this.renderStatusHud(var1);
         if (this.isCheatModeEnabled && this.gameByteStateAZ == 1) {
            int var2;
            if (this.gameByteStateBE == this.gameByteStateBD) {
               var2 = this.animationDefinitions[this.gameByteStateBE][0] + this.gameByteStateBF;
            } else {
               var2 = this.animationDefinitions[this.gameByteStateBE][0];
            }

            this.fontRenderer.drawText(var1, "" + this.gameShortValueE + " / " + this.gameIntegerStateAM + " / " + var2, 2, canvasCenterY, canvasWidth, 4, 1);
         } else if (this.isCheatModeEnabled && this.gameByteStateAZ == 0) {
            this.fontRenderer
               .drawText(var1, "" + this.gameShortValueE + " / " + this.gameIntegerStateAM + " / " + this.levelEventDefinitions[this.gameIntegerStateAL][2], 2, canvasCenterY, canvasWidth, 4, 1);
         }
      }
   }

   // $VF: renamed from: z () void
   public void resetScreenState() {
      if (this.isScreenInitialized) {
         this.gameByteStateAO = 0;
      } else {
         if (this.gameIntegerStateH > 0) {
            this.gameIntegerStateH = this.gameIntegerStateH - this.frameDeltaMs;
            if (this.gameIntegerStateH % 100 > 50) {
               this.gameByteStateAO = 3;
            } else {
               this.gameByteStateAO = -3;
            }
         } else {
            this.gameByteStateAO = 0;
         }
      }
   }

   // $VF: renamed from: k (javax.microedition.lcdui.Graphics) void
   public void renderTitleBackground(Graphics var1) {
      this.gameCanvas.setGraphicsColor(var1, 14540253);
      this.drawScrollingMessage(var1, this.pendingMessage);
      if (this.mainMenu != null) {
         this.mainMenu.a(var1);
      }
   }

   // $VF: renamed from: l (javax.microedition.lcdui.Graphics) void
   public void renderGameplayView(Graphics var1) {
      int var5 = 0;
      int var7 = 0;
      int var10 = 0;
      string var14 = "";
      sbyte var15 = 0;
      sbyte var2 = 24;
      var15 = 2;
      int var4 = var2 + 4 + 4;
      this.gameCanvas.setGraphicsColor(var1, 0);
      this.gameCanvas.fillCanvasRectangle(var1, 0, 0, canvasWidth, canvasHeight);
      this.gameCanvas.setGraphicsColor(var1, 14540253);
      this.drawScrollingMessage(var1, this.pendingMessage);
      int var18 = this.fontRenderer.getFontBaselineOffset(0) + 4 + var15;
      int var8 = canvasHeight / 5 * 3;
      int var9 = (var8 - var18) / (var4 - 2);
      if (this.selectedItemIndex > var9 - 1) {
         var10 = this.selectedItemIndex - (var9 - 1);
      }

      this.gameCanvas.setGraphicsClip(var1, 0, var18 - 2, canvasWidth, var8 - var18);

      for (int var6 = 0; var6 < this.gameByteStateArrayA.Length && var6 <= var9 - 1; var6++) {
         this.drawHudFrame(var1, 8, var18, canvasWidth - 20, var2);
         if (var6 + var10 < 5) {
            this.drawItemPortrait(var1, (sbyte)(var6 + 1 + var10), 14, var18 + 5);
            if (var6 + 1 + var10 != 5) {
               GameCanvas.drawImageAtAnchor(var1, this.ammunitionImage, 22, var18 + 5 + 3, 0, 20);
            }

            if (!this.activeCharacterState.characterAnimationFlagArrayA[var6 + 1 + var10]) {
               GameCanvas.drawImageAtAnchor(var1, this.unarmedWeaponImage, 14, var18 + 5, 0, 20);
            }

            this.gameCanvas.setGraphicsColor(var1, 14540253);
            this.fontRenderer
               .drawText(
                  var1,
                  this.activeCharacterState.characterAnimationByteStateArrayA[var6 + 1 + var10] + " / " + this.itemPriceByLevel[var6 + 1 + var10],
                  22 + this.ammunitionImage.getWidth() + 3,
                  var18 + 5,
                  canvasWidth,
                  4,
                  1
               );
         } else {
            this.drawItemPortrait(var1, (sbyte)(var6 + var10 - 3), 14, var18 + 5);
            if (this.activeCharacterState.characterAnimationFlagArrayA[var6 + var10 - 3]) {
               GameCanvas.drawImageAtAnchor(var1, this.unarmedWeaponImage, 14, var18 + 5, 0, 20);
            }
         }

         var18 += var4 - 2;
      }

      var5 = this.fontRenderer.getFontBaselineOffset(0) + 4 + var15;
      if (this.selectedItemIndex > var9 - 1) {
         var7 = (var4 - 2) * (var9 - 1);
      } else {
         var7 = (var4 - 2) * this.selectedItemIndex;
      }

      this.gameCanvas.setGraphicsColor(var1, 16711680);
      this.gameCanvas.drawRectangle(var1, 8, var5 + var7, canvasWidth - 20, var2);
      if (this.selectedItemIndex < this.gameByteStateArrayA.Length - 1) {
         GameCanvas.drawTriangle(var1, canvasWidth - 8, var8 - 8, 1, 4, 16777215);
      }

      if (this.selectedItemIndex > 0) {
         GameCanvas.drawTriangle(var1, canvasWidth - 8, var5, 0, 4, 16777215);
      }

      if (this.gameFlagO) {
         int var11 = canvasCenterX - canvasWidth / 100 * 30 / 2;
         int var12 = var8 / 2 - var2 / 2;
         int var13 = canvasWidth / 100 * 30;
         this.gameCanvas.setGraphicsColor(var1, 0);
         this.gameCanvas.fillCanvasRectangle(var1, var11, var12, var13, var2);
         this.drawHudFrame(var1, var11, var12, var13, var2);
         if (this.updateTickCount % 10 != 0) {
            GameCanvas.drawTriangle(var1, canvasCenterX - 2, var12 - 4, 0, 4, 16777215);
            GameCanvas.drawTriangle(var1, canvasCenterX - 2, var12 + var2, 1, 4, 16777215);
            GameCanvas.drawTriangle(var1, var11 - 4, var12 + var2 / 2, 2, 4, 16777215);
            GameCanvas.drawTriangle(var1, var11 + var13, var12 + var2 / 2, 3, 4, 16777215);
         }

         this.gameCanvas.setGraphicsColor(var1, 14540253);
         string var16 = "";
         if (this.gameByteStateBI < 10) {
            var16 = var16 + "0" + this.gameByteStateBI;
         } else {
            var16 = var16 + this.gameByteStateBI;
         }

         int var17 = this.fontRenderer.measureTextWidth(var16, 1);
         this.fontRenderer.drawText(var1, var16, var11 + var13 / 2 - var17 / 2, var12 + var2 / 2 - this.fontRenderer.getFontBaselineOffset(1) / 2, canvasWidth, 4, 1);
      } else if (this.gameFlagP) {
         int var21 = canvasCenterX - canvasWidth / 100 * 90 / 2;
         int var22 = var8 / 2 - var2 / 2 * 3;
         int var23 = canvasWidth / 100 * 90;
         this.gameCanvas.setGraphicsColor(var1, 0);
         this.gameCanvas.fillCanvasRectangle(var1, var21, var22, var23, var2 * 2);
         this.drawHudFrame(var1, var21, var22, var23, var2 * 2);
         this.gameCanvas.setGraphicsColor(var1, 14540253);
         string var31 = this.localizedText[90] + "?";
         this.fontRenderer
            .drawClippedOrScrollingText(var1, var31, var21, var22 + var2 / 2 - this.fontRenderer.getFontBaselineOffset(1) / 2, var23, 1, 1, this.updateTickCount * 2, canvasCenterX, canvasCenterX);
         if (!this.gameFlagQ) {
            if (this.updateTickCount % 10 == 0) {
               this.gameCanvas.setGraphicsColor(var1, 16711680);
            } else {
               this.gameCanvas.setGraphicsColor(var1, 16777215);
            }
         } else {
            this.gameCanvas.setGraphicsColor(var1, 16777215);
         }

         this.fontRenderer.drawText(var1, this.localizedText[33], var21 + var23 / 2 - 4, var22 + var2 / 2 + this.fontRenderer.getFontBaselineOffset(1), canvasWidth, 8, 1);
         if (this.gameFlagQ) {
            if (this.updateTickCount % 10 == 0) {
               this.gameCanvas.setGraphicsColor(var1, 16711680);
            } else {
               this.gameCanvas.setGraphicsColor(var1, 16777215);
            }
         } else {
            this.gameCanvas.setGraphicsColor(var1, 16777215);
         }

         this.fontRenderer.drawText(var1, this.localizedText[32], var21 + var23 / 2 + 4, var22 + var2 / 2 + this.fontRenderer.getFontBaselineOffset(1), canvasWidth, 4, 1);
      }

      this.gameCanvas.setGraphicsClip(var1, 0, 0, canvasWidth, canvasHeight);
      int var3 = canvasHeight - var8 - (this.characterPortraitImages[this.portraitImageIndices[1]].getHeight() + 2) - 2 - 2;
      this.gameCanvas.setGraphicsColor(var1, 0);
      this.gameCanvas.fillCanvasRectangle(var1, 4, var8 + 2, canvasWidth - 8, var3);
      this.drawHudFrame(var1, 4, var8 + 2, canvasWidth - 8, var3);
      this.gameCanvas.setGraphicsColor(var1, 14540253);
      this.gameCanvas.setGraphicsClip(var1, 0, var8 + 2, canvasWidth, var3 - 2);
      if (this.selectedItemIndex < 5) {
         if (this.selectedItemIndex != 4) {
            var14 = this.localizedText[89];
         } else {
            var14 = this.localizedText[23];
         }

         var14 = var14 + " ";
         var14 = var14 + this.localizedText[79 + this.selectedItemIndex];
         if (this.gameFlagN) {
            var14 = this.localizedText[93];
         }
      } else {
         if (this.activeCharacterState.characterAnimationFlagArrayA[this.selectedItemIndex - 3]) {
            var14 = this.localizedText[92];
         } else {
            var14 = this.localizedText[90];
            var14 = var14 + ": ";
            var14 = var14 + this.localizedText[80 + (this.selectedItemIndex - 5)];
         }

         if (this.gameFlagN) {
            var14 = this.localizedText[93];
         }
      }

      int var32 = this.fontRenderer.countWrappedLines(var14, canvasWidth - 16, 1);
      if (var3 > this.fontRenderer.getFontBaselineOffset(1) * var32) {
         this.fontRenderer.drawWrappedText(var1, var14, 8, var8 + 2 + 2, canvasWidth - 16, 4, 1, this.fontRenderer.getFontBaselineOffset(1), false);
      } else {
         this.fontRenderer
            .drawClippedOrScrollingText(var1, var14, 8, var8 + 2 + var3 / 2 - this.fontRenderer.getFontBaselineOffset(1) / 2, canvasWidth - 16, 4, 1, this.updateTickCount * 2, canvasCenterX, canvasCenterX);
      }

      this.gameCanvas.setGraphicsClip(var1, 0, 0, canvasWidth, canvasHeight);
      this.gameCanvas.setGraphicsColor(var1, 14540253);
      if (!this.gameFlagO) {
         this.applyCheatPriceModifiers();
         this.fontRenderer
            .drawClippedOrScrollingText(
               var1,
               "$" + this.gameIntegerStateAI + " / $" + this.gameplayPriceMultipliers[this.selectedItemIndex],
               4 + this.characterPortraitImages[this.portraitImageIndices[1]].getWidth(),
               canvasHeight - this.fontRenderer.getFontBaselineOffset(1) - 2,
               canvasWidth - 4 - this.characterPortraitImages[this.portraitImageIndices[1]].getWidth() * 2,
               1,
               1,
               this.updateTickCount * 2,
               canvasCenterX,
               canvasCenterX
            );
      } else {
         this.fontRenderer
            .drawClippedOrScrollingText(
               var1,
               "$" + this.gameIntegerStateAI + " / $" + this.gameByteStateBI * this.gameplayPriceMultipliers[this.selectedItemIndex],
               4 + this.characterPortraitImages[this.portraitImageIndices[1]].getWidth(),
               canvasHeight - this.fontRenderer.getFontBaselineOffset(1) - 2,
               canvasWidth - 4 - this.characterPortraitImages[this.portraitImageIndices[1]].getWidth() * 2,
               1,
               1,
               this.updateTickCount * 2,
               canvasCenterX,
               canvasCenterX
            );
      }
   }

   // $VF: renamed from: m (javax.microedition.lcdui.Graphics) void
   public void renderInventoryView(Graphics var1) {
      int var5 = 0;
      int var7 = 0;
      string var9 = null;
      int var11 = 0;
      int var12 = 0;
      string var13 = "";
      sbyte var18 = 0;
      sbyte var2 = 24;
      var18 = 2;
      int var4 = var2 + 4 + 4;
      this.gameCanvas.setGraphicsColor(var1, 0);
      this.gameCanvas.fillCanvasRectangle(var1, 0, 0, canvasWidth, canvasHeight);
      this.gameCanvas.setGraphicsColor(var1, 14540253);
      this.drawScrollingMessage(var1, this.pendingMessage);
      int var23 = this.fontRenderer.getFontBaselineOffset(0) + 4 + var18;
      int var8 = canvasHeight / 5 * 3;
      this.gameCanvas.setGraphicsClip(var1, 0, var23 - 2, canvasWidth, var8 - var23);
      if (this.gameFlagL) {
         this.gameCanvas.setGraphicsColor(var1, 1118481);
         this.gameCanvas.fillCanvasRectangle(var1, 0, 0, canvasWidth / 2, var8);
         this.gameCanvas.setGraphicsColor(var1, 0);
         this.gameCanvas.fillCanvasRectangle(var1, canvasWidth / 2, 0, canvasWidth / 2, var8);
      } else {
         this.gameCanvas.setGraphicsColor(var1, 0);
         this.gameCanvas.fillCanvasRectangle(var1, 0, 0, canvasWidth / 2, var8);
         this.gameCanvas.setGraphicsColor(var1, 1118481);
         this.gameCanvas.fillCanvasRectangle(var1, canvasWidth / 2, 0, canvasWidth / 2, var8);
      }

      int var10 = (var8 - var23) / (var4 - 2);
      if (this.selectedItemIndex > var10 - 1) {
         var12 = this.selectedItemIndex - (var10 - 1);
      }

      for (int var6 = 0; var6 < this.gameByteStateBG && var6 <= var10 - 1; var6++) {
         this.drawHudFrame(var1, 8, var23, canvasCenterX - 20, var2);
         this.drawItemPortrait(var1, this.gameByteStateArrayB[var6 + var12], 14, var23 + 5);
         if (var6 == this.selectedItemIndex) {
            if (this.gameFlagL) {
               this.gameCanvas.setGraphicsColor(var1, 16711680);
            } else {
               this.gameCanvas.setGraphicsColor(var1, 255);
            }

            this.gameCanvas.drawRectangle(var1, 8, var23, canvasCenterX - 20, var2);
         }

         var23 += var4 - 2;
      }

      if (this.selectedItemIndex > var10 - 1) {
         if (this.gameFlagL) {
            this.gameCanvas.setGraphicsColor(var1, 16711680);
         } else {
            this.gameCanvas.setGraphicsColor(var1, 255);
         }

         this.gameCanvas.drawRectangle(var1, 8, var23 - (var4 - 2), canvasCenterX - 20, var2);
      }

      int var24 = this.fontRenderer.getFontBaselineOffset(0) + 4 + var18;
      if (this.gameFlagL && this.gameByteStateBG > var10) {
         if (this.selectedItemIndex < this.gameByteStateBG - 1) {
            GameCanvas.drawTriangle(var1, canvasCenterX - 8, var8 - 8, 1, 4, 16777215);
         }

         if (this.selectedItemIndex > 0) {
            GameCanvas.drawTriangle(var1, canvasCenterX - 8, var24, 0, 4, 16777215);
         }
      }

      if (this.selectedItemPage > var10 - 1) {
         var12 = this.selectedItemPage - (var10 - 1);
      } else {
         var12 = 0;
      }

      var7 = this.fontRenderer.measureTextWidth(": ", 1);
      if (this.gameByteStateArrayB != null) {
         for (int var26 = 0; var26 < 3 && var26 <= var10 - 1; var26++) {
            this.drawHudFrame(var1, canvasCenterX + 5, var24, canvasCenterX - 20, var2);
            sbyte var14 = (sbyte)(this.levelGrid[this.gameByteStateArrayB[this.selectedItemIndex]][var26 + var12] + 1);
            if (var14 > 3) {
               var14 = 3;
            }

            switch (var26 + var12) {
               case 0:
                  var13 = this.localizedText[67];
                  break;
               case 1:
                  var13 = this.localizedText[68];
                  break;
               case 2:
                  var13 = this.localizedText[69]; break;
            }

            this.gameCanvas.setGraphicsColor(var1, 14540253);
            this.fontRenderer
               .drawClippedOrScrollingText(
                  var1, var13, canvasCenterX + 12, var24 + 5 + 7 - this.fontRenderer.getFontBaselineOffset(1) / 2, (canvasCenterX - 20 - 12) / 3 * 2, 4, 1, this.updateTickCount, 10, 0
               );
            if (this.levelGrid[this.gameByteStateArrayB[this.selectedItemIndex]][var26 + var12] == 3) {
               this.fontRenderer
                  .drawText(var1, ": ", canvasCenterX + 12 + (canvasCenterX - 20 - 12) / 3 * 2 + 1, var24 + 5 + 7 - this.fontRenderer.getFontBaselineOffset(1) / 2, canvasWidth, 4, 1);
               this.fontRenderer
                  .drawClippedOrScrollingText(
                     var1,
                     this.localizedText[87],
                     canvasCenterX + 12 + (canvasCenterX - 20 - 12) / 3 * 2 + 1 + var7,
                     var24 + 5 + 7 - this.fontRenderer.getFontBaselineOffset(1) / 2,
                     (canvasCenterX - 20 - 12) / 3 - var7,
                     4,
                     1,
                     this.updateTickCount,
                     10,
                     0
                  );
            } else {
               this.fontRenderer
                  .drawText(
                     var1, ": " + var14, canvasCenterX + 12 + (canvasCenterX - 20 - 12) / 3 * 2 + 1, var24 + 5 + 7 - this.fontRenderer.getFontBaselineOffset(1) / 2, canvasWidth, 4, 1
                  );
            }

            var24 += var4 - 2;
         }
      }

      var5 = this.fontRenderer.getFontBaselineOffset(1) + 4 + 6;
      if (!this.gameFlagL && 3 > var10) {
         if (this.selectedItemPage < 2) {
            GameCanvas.drawTriangle(var1, canvasWidth - 8, var8 - 8, 1, 4, 16777215);
         }

         if (this.selectedItemPage > 0) {
            GameCanvas.drawTriangle(var1, canvasWidth - 8, var5, 0, 4, 16777215);
         }
      }

      if (this.selectedItemPage > var10 - 1) {
         var11 = (var4 - 2) * (var10 - 1);
      } else {
         var11 = (var4 - 2) * this.selectedItemPage;
      }

      if (!this.gameFlagL) {
         this.gameCanvas.setGraphicsColor(var1, 16711680);
         this.gameCanvas.drawRectangle(var1, canvasCenterX + 5, var5 + var11 - 2, canvasCenterX - 20, var2);
      }

      if (this.gameFlagO) {
         int var15 = canvasCenterX - canvasWidth / 100 * 90 / 2;
         int var16 = var8 / 2 - var2 / 2 * 3;
         int var17 = canvasWidth / 100 * 90;
         this.gameCanvas.setGraphicsColor(var1, 0);
         this.gameCanvas.fillCanvasRectangle(var1, var15, var16, var17, var2 * 2);
         this.drawHudFrame(var1, var15, var16, var17, var2 * 2);
         this.gameCanvas.setGraphicsColor(var1, 14540253);
         string var19 = this.localizedText[88];
         this.fontRenderer
            .drawClippedOrScrollingText(var1, var19, var15, var16 + var2 / 2 - this.fontRenderer.getFontBaselineOffset(1) / 2, var17, 1, 1, this.updateTickCount * 2, canvasCenterX, canvasCenterX);
         if (!this.gameFlagM) {
            if (this.updateTickCount % 10 == 0) {
               this.gameCanvas.setGraphicsColor(var1, 16711680);
            } else {
               this.gameCanvas.setGraphicsColor(var1, 16777215);
            }
         } else {
            this.gameCanvas.setGraphicsColor(var1, 16777215);
         }

         this.fontRenderer.drawText(var1, this.localizedText[33], var15 + var17 / 2 - 4, var16 + var2 / 2 + this.fontRenderer.getFontBaselineOffset(1), canvasWidth, 8, 1);
         if (this.gameFlagM) {
            if (this.updateTickCount % 10 == 0) {
               this.gameCanvas.setGraphicsColor(var1, 16711680);
            } else {
               this.gameCanvas.setGraphicsColor(var1, 16777215);
            }
         } else {
            this.gameCanvas.setGraphicsColor(var1, 16777215);
         }

         this.fontRenderer.drawText(var1, this.localizedText[32], var15 + var17 / 2 + 4, var16 + var2 / 2 + this.fontRenderer.getFontBaselineOffset(1), canvasWidth, 4, 1);
      }

      this.gameCanvas.setGraphicsClip(var1, 0, 0, canvasWidth, canvasHeight);
      int var3 = canvasHeight - var8 - (this.characterPortraitImages[this.portraitImageIndices[1]].getHeight() + 2) - 2 - 2;
      this.gameCanvas.setGraphicsColor(var1, 0);
      this.gameCanvas.fillCanvasRectangle(var1, 4, var8 + 2, canvasWidth - 8, var3);
      this.drawHudFrame(var1, 4, var8 + 2, canvasWidth - 8, var3);
      this.gameCanvas.setGraphicsColor(var1, 14540253);
      this.gameCanvas.setGraphicsClip(var1, 0, var8 + 2, canvasWidth, var3 - 2);
      if (this.gameByteStateArrayB != null) {
         if (this.gameFlagL) {
            var9 = this.localizedText[72 + this.gameByteStateArrayB[this.selectedItemIndex]];
         } else if (this.gameFlagN) {
            var9 = this.localizedText[93];
         } else {
            var9 = this.localizedText[84 + this.selectedItemPage];
         }
      }

      int var31 = 0;
      if (var9 != null) {
         var31 = this.fontRenderer.countWrappedLines(var9, canvasWidth - 16, 1);
      } else {
         var9 = " ";
      }

      if (var3 > this.fontRenderer.getFontBaselineOffset(1) * var31) {
         if (var9 != null) {
            this.fontRenderer.drawWrappedText(var1, var9, 8, var8 + 2 + 2, canvasWidth - 16, 4, 1, this.fontRenderer.getFontBaselineOffset(1), false);
         }
      } else if (var9 != null) {
         this.fontRenderer
            .drawClippedOrScrollingText(var1, var9, 8, var8 + 2 + var3 / 2 - this.fontRenderer.getFontBaselineOffset(1) / 2, canvasWidth - 16, 4, 1, this.updateTickCount * 2, canvasCenterX, canvasCenterX);
      }

      this.gameCanvas.setGraphicsClip(var1, 0, 0, canvasWidth, canvasHeight);
      this.gameCanvas.setGraphicsColor(var1, 14540253);
      sbyte var20 = 0;
      if (this.gameByteStateArrayB != null) {
         var20 = this.levelGrid[this.gameByteStateArrayB[this.selectedItemIndex]][this.selectedItemPage];
      }

      string var21 = "";
      if (this.gameFlagL) {
         var21 = "$" + this.gameIntegerStateAI + " / $--";
      } else {
         var21 = "$" + this.gameIntegerStateAI + " / $";
         if (var20 == 3) {
            var21 = var21 + "--";
         } else {
            sbyte var22 = this.getSelectedItemDirection();
            if (this.gameByteStateArrayB != null) {
               var21 = var21 + this.itemPriceByCategoryAndLevel[var22][this.gameByteStateArrayB[this.selectedItemIndex]];
            }
         }
      }

      this.fontRenderer
         .drawClippedOrScrollingText(
            var1,
            var21,
            4 + this.characterPortraitImages[this.portraitImageIndices[1]].getWidth(),
            canvasHeight - this.fontRenderer.getFontBaselineOffset(1) - 2,
            canvasWidth - 4 - this.characterPortraitImages[this.portraitImageIndices[1]].getWidth() * 2,
            1,
            1,
            this.updateTickCount * 2,
            canvasCenterX,
            canvasCenterX
         );
   }

   // $VF: renamed from: ab () byte
   public sbyte countSelectedInventoryItems() {
      sbyte var1 = 0;

      for (int var2 = 0; var2 < this.activeCharacterState.characterAnimationFlagArrayA.Length; var2++) {
         if (this.activeCharacterState.characterAnimationFlagArrayA[var2]) {
            var1++;
         }
      }

      return var1;
   }

   // $VF: renamed from: ac () void
   public void rebuildInventoryItemIndices() {
      this.gameByteStateArrayB = new sbyte[this.gameByteStateBG];
      int var2 = 0;

      for (int var1 = 0; var1 < this.activeCharacterState.characterAnimationFlagArrayA.Length - 1; var1++) {
         if (this.activeCharacterState.characterAnimationFlagArrayA[var1]) {
            this.gameByteStateArrayB[var2] = (sbyte)var1;
            var2++;
         }
      }
   }

   // $VF: renamed from: n (javax.microedition.lcdui.Graphics) void
   public void renderCanvasHiddenPrompt(Graphics var1) {
      if (GameCanvas.isCanvasHidden) {
         this.setPackedColor(var1, 0);
         this.fillRectangle(var1, 0, 0, canvasWidth, canvasHeight);
         this.setPackedColor(var1, 16777215);
         if (this.gameByteStateB == 0) {
            this.fontRenderer.drawText(var1, "Press Ok", canvasCenterX - this.fontRenderer.measureTextWidth("Press 0", 0) / 2, canvasCenterY, canvasWidth, 0, 0);
         } else if (this.gameByteStateB == 1) {
            this.fontRenderer.drawText(var1, "Pulsa Ok", canvasCenterX - this.fontRenderer.measureTextWidth("Pulsa 0", 0) / 2, canvasCenterY, canvasWidth, 0, 0);
         } else {
            this.fontRenderer.drawText(var1, "Pressione Ok", canvasCenterX - this.fontRenderer.measureTextWidth("Pressione 0", 0) / 2, canvasCenterY, canvasWidth, 0, 0);
         }
      }
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, int, int, int, int) void
   public void drawHudFrame(Graphics var1, int var2, int var3, int var4, int var5) {
      this.setRgbColor(var1, 8, 78, 86);
      this.drawRectangleOutline(var1, var2, var3, var4, var5);
      var2--;
      var3--;
      var4 += 2;
      var5 += 2;
      this.setRgbColor(var1, 81, 84, 76);
      this.drawLine(var1, var2 + 1, var3, var2 + var4 - 2, var3);
      this.drawLine(var1, var2 + 1, var3 + var5 - 1, var2 + var4 - 2, var3 + var5 - 1);
      this.drawLine(var1, var2, var3 + 1, var2, var3 + var5 - 2);
      this.drawLine(var1, var2 + var4 - 1, var3 + 1, var2 + var4 - 1, var3 + var5 - 2);
      var2--;
      var3--;
      var4 += 2;
      var5 += 2;
      this.setRgbColor(var1, 63, 88, 29);
      this.drawLine(var1, var2 + 2, var3, var2 + var4 - 3, var3);
      this.drawLine(var1, var2 + 2, var3 + var5 - 1, var2 + var4 - 3, var3 + var5 - 1);
      this.drawLine(var1, var2, var3 + 2, var2, var3 + var5 - 3);
      this.drawLine(var1, var2 + var4 - 1, var3 + 2, var2 + var4 - 1, var3 + var5 - 3);
      this.fillRectangle(var1, var2 + 1, var3 + 1, 1, 1);
      this.fillRectangle(var1, var2 + 1, var3 + var5 - 2, 1, 1);
      this.fillRectangle(var1, var2 + var4 - 2, var3 + 1, 1, 1);
      this.fillRectangle(var1, var2 + var4 - 2, var3 + var5 - 2, 1, 1);
   }

   // $VF: renamed from: b (javax.microedition.lcdui.Graphics) void
   public void renderStatusHud(Graphics var1) {
      bool var6 = true;
      int var2 = canvasWidth - 4 - 14 - 7 - 16;
      sbyte var4 = 14;
      sbyte var5 = 14;
      sbyte var3 = 2;
      this.setRgbColor(var1, 6, 78, 83);
      this.drawRectangleOutline(var1, var2, var3, var4 + 2, var5 + 2);
      this.setRgbColor(var1, 130, 135, 121);
      this.fillRectangle(var1, var2 + 1, var3 + 1, var4, var5);
      if (this.isCharacterActionComplete()) {
         this.setRgbColor(var1, 0, 255, 0);
      } else {
         this.setRgbColor(var1, 255, 0, 0);
      }

      this.drawLine(var1, var2 + 1, var3 - 1, var2 + var4, var3 - 1);
      this.drawLine(var1, var2 + 1, var3 + var5 + 2, var2 + var4, var3 + var5 + 2);
      this.drawLine(var1, var2 + var4 + 2, var3 + 1, var2 + var4 + 2, var3 + var5);
      this.drawLine(var1, var2 - 1, var3 + 1, var2 - 1, var3 + var5);
      this.drawRectangleOutline(var1, var2, var3, 1, 1);
      this.drawRectangleOutline(var1, var2 + var4 + 1, var3, 1, 1);
      this.drawRectangleOutline(var1, var2 + var4 + 1, var3 + var5 + 1, 1, 1);
      this.drawRectangleOutline(var1, var2, var3 + var5 + 1, 1, 1);
      this.setRgbColor(var1, 255, 255, 255);
      if (this.activeCharacterState.characterAnimationByteStateD != 127) {
         if (this.activeCharacterState.characterAnimationByteStateB == directionByState[this.activeCharacterState.characterAnimationByteStateD] && this.activeCharacterState.characterAnimationByteStateD != 0 && this.activeCharacterState.characterAnimationByteStateB != 0) {
            if (this.activeCharacterState.characterAnimationByteStateArrayA[this.activeCharacterState.characterAnimationByteStateD] <= 0 && (this.gameIntegerStateG & 512) != 0 && this.gameClockTimeMs % 600L < 300L) {
               this.setRgbColor(var1, 255, 0, 0);
            } else {
               this.setRgbColor(var1, 255, 255, 255);
            }
         }

         if (this.activeCharacterState.characterAnimationFlagArrayA[this.activeCharacterState.characterAnimationByteStateD] && this.activeCharacterState.characterAnimationByteStateD != 0) {
            this.gameCanvas.setGraphicsColor(var1, 0);
            this.fontRenderer
               .drawText(
                  var1, "" + this.activeCharacterState.characterAnimationByteStateArrayA[this.activeCharacterState.characterAnimationByteStateD], var2 - 3 + 1, var3 + 14 - this.fontRenderer.getFontBaselineOffset(1) + 1, canvasWidth, 8, 1
               );
            this.gameCanvas.setGraphicsColor(var1, 16777215);
            this.fontRenderer
               .drawText(var1, "" + this.activeCharacterState.characterAnimationByteStateArrayA[this.activeCharacterState.characterAnimationByteStateD], var2 - 3, var3 + 14 - this.fontRenderer.getFontBaselineOffset(1), canvasWidth, 8, 1);
         }

         this.drawItemPortrait(var1, this.activeCharacterState.characterAnimationByteStateD, var2 + 1, var3 + 1);
         if (!this.activeCharacterState.characterAnimationFlagArrayA[this.activeCharacterState.characterAnimationByteStateD]) {
            GameCanvas.drawImageAtAnchor(var1, this.unarmedWeaponImage, var2, var3, 0, 20);
         }
      } else {
         GameCanvas.drawImageAtAnchor(var1, this.unarmedWeaponImage, var2, var3, 0, 20);
      }

      int var10 = var2 + 21;
      if (this.activeCharacterState.characterAnimationObjectReferenceA.actionCounter < 5 && this.updateTickCount % 5 == 0) {
         var6 = false;
      }

      if (var6) {
         this.drawClippedSprite(var1, 2, var10, var3, 16, 16, 16, 0, 0);
         this.drawClippedSprite(
            var1,
            2,
            var10,
            var3 + 16 - 16 * this.activeCharacterState.characterAnimationObjectReferenceA.actionCounter / this.activeCharacterState.characterAnimationObjectReferenceA.actionCounterLimit,
            16,
            16 * this.activeCharacterState.characterAnimationObjectReferenceA.actionCounter / this.activeCharacterState.characterAnimationObjectReferenceA.actionCounterLimit,
            0,
            16 - 16 * this.activeCharacterState.characterAnimationObjectReferenceA.actionCounter / this.activeCharacterState.characterAnimationObjectReferenceA.actionCounterLimit,
            0
         );
      }

      if (this.gameByteStateAZ == 2) {
         GameCanvas.drawImageAtAnchor(var1, this.zombiePortraitImage, 2, 2, 0, 20);
         this.gameCanvas.setGraphicsColor(var1, 0);
         this.fontRenderer.drawText(var1, "" + this.gameIntegerStateAF, 4 + this.zombiePortraitImage.getWidth() + 1, 3, canvasWidth, 4, 1);
         this.gameCanvas.setGraphicsColor(var1, 16777215);
         this.fontRenderer.drawText(var1, "" + this.gameIntegerStateAF, 4 + this.zombiePortraitImage.getWidth(), 2, canvasWidth, 4, 1);
      } else if (this.gameByteStateAZ == 1) {
         GameCanvas.drawImageAtAnchor(var1, this.leonPortraitImage, 2, 2, 0, 20);
         this.gameCanvas.setGraphicsColor(var1, 0);
         this.fontRenderer.drawText(var1, "" + this.gameByteStateAL, 4 + this.leonPortraitImage.getWidth() + 1, 3, canvasWidth, 4, 1);
         this.gameCanvas.setGraphicsColor(var1, 16777215);
         this.fontRenderer.drawText(var1, "" + this.gameByteStateAL, 4 + this.leonPortraitImage.getWidth(), 2, canvasWidth, 4, 1);
      } else if (this.gameByteStateAZ == 0 && this.isReleasedInputFlagSet(1)) {
         int var7 = (int)(this.gameLongValueE / 1000L / 60L);
         int var8 = (int)(this.gameLongValueE / 1000L - (long)(var7 * 60));
         string var9 = "";
         if (var8 >= 10) {
            var9 = var9 + var8;
         } else {
            var9 = var9 + "0" + var8;
         }

         this.gameCanvas.setGraphicsColor(var1, 0);
         this.fontRenderer.drawText(var1, var7 + ":" + var9, 3, 3, canvasWidth, 4, 0);
         this.gameCanvas.setGraphicsColor(var1, 16777215);
         this.fontRenderer.drawText(var1, var7 + ":" + var9, 2, 2, canvasWidth, 4, 0);
      }

      if (this.gameByteStateAZ == 0 && this.isReleasedInputFlagSet(256)) {
         GameCanvas.drawImageAtAnchor(var1, this.zombiePortraitImage, canvasCenterX - 2, canvasHeight - this.zombiePortraitImage.getHeight() - 2, 0, 24);
         int var11;
         if (this.isReleasedInputFlagSet(128)) {
            var11 = this.levelEventDefinitions[this.gameIntegerStateAL][7];
         } else {
            var11 = this.levelEventDefinitions[this.gameIntegerStateAL][2];
         }

         this.gameCanvas.setGraphicsColor(var1, 0);
         this.fontRenderer.drawText(var1, "" + this.gameIntegerStateAF + " / " + var11, canvasCenterX + 2, canvasHeight - this.fontRenderer.getFontBaselineOffset(1) - 2, canvasWidth, 4, 1);
         this.gameCanvas.setGraphicsColor(var1, 16777215);
         this.fontRenderer.drawText(var1, "" + this.gameIntegerStateAF + " / " + var11, canvasCenterX + 2, canvasHeight - this.fontRenderer.getFontBaselineOffset(1) - 1, canvasWidth, 4, 1);
      }
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, byte, int, int) void
   public void drawItemPortrait(Graphics var1, sbyte var2, int var3, int var4) {
      GameCanvas.drawImageAtAnchor(var1, this.itemPortraitImages[var2], var3, var4, 0, 20);
   }

   // $VF: renamed from: ad () boolean
   public bool isCharacterActionComplete() {
      bool var1 = false;
      if (this.activeCharacterState.characterAnimationByteStateD == 127) {
         return false;
      } else if (this.activeCharacterState.characterAnimationByteStateD == 5) {
         return true;
      } else {
         if (this.entityTimeOffsets[this.activeCharacterState.characterAnimationByteStateD] > this.gameClockTimeMs) {
            var1 = false;
         } else {
            var1 = true;
         }

         return var1;
      }
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, int, int, int) void
   public void renderLevelRegion(Graphics var1, int var2, int var3, int var4) {
      int var8 = 0;
      int var9 = 0;
      sbyte var6 = this.levelObjects[var2].actorAnimationByteStateA;
      int var7 = 9 + var6;
      if (this.gameIntegerStateS == var2) {
         var8 = this.gameIntegerStateT;
         var9 = this.gameIntegerStateU;
      }

      this.drawObjectSprite(
         var1,
         var7,
         var3,
         var4,
         this.levelObjectProperties[var6][2] + var8,
         this.levelObjectProperties[var6][3] + var9,
         this.levelObjectProperties[var6][0],
         this.levelObjectProperties[var6][1],
         0,
         0,
         0,
         this.levelObjects[var2].actorAnimationFlagD
      );

      for (int var5 = 0; var5 < this.levelObjects[var2].actorAnimationByteStateD; var5++) {
         if (!this.levelObjects[var2].actorAnimationObjectReferenceArrayA[var5].gameAnimationFlagA) {
         }
      }
   }

   // $VF: renamed from: o (javax.microedition.lcdui.Graphics) void
   public void renderMedicalItem(Graphics var1) {
      if (this.medicalItemState.actorAnimationFlagB) {
         int var2 = this.tileToScreenX(this.medicalItemState.actorAnimationByteStateB, this.medicalItemState.actorAnimationByteStateC) - this.cameraX;
         int var3 = this.tileToScreenY(this.medicalItemState.actorAnimationByteStateB, this.medicalItemState.actorAnimationByteStateC) - this.cameraY;
         var2 += 10;
         var3 += 0;
         GameCanvas.drawImageAtAnchor(var1, this.medkitImage, var2, var3, 0, 20);
      }

      if (this.ammunitionItemState.actorAnimationFlagB) {
         int var5 = this.tileToScreenX(this.ammunitionItemState.actorAnimationByteStateB, this.ammunitionItemState.actorAnimationByteStateC) - this.cameraX;
         int var10 = this.tileToScreenY(this.ammunitionItemState.actorAnimationByteStateB, this.ammunitionItemState.actorAnimationByteStateC) - this.cameraY;
         var5 += 10;
         var10 += 0;
         GameCanvas.drawImageAtAnchor(var1, this.ammunitionImage, var5, var10, 0, 20);
      }

      if (this.weaponItemState.actorAnimationFlagB) {
         int var7 = this.tileToScreenX(this.weaponItemState.actorAnimationByteStateB, this.weaponItemState.actorAnimationByteStateC) - this.cameraX;
         int var12 = this.tileToScreenY(this.weaponItemState.actorAnimationByteStateB, this.weaponItemState.actorAnimationByteStateC) - this.cameraY;
         var7 += 3;
         var12 += 0;
         GameCanvas.drawImageAtAnchor(var1, this.weaponImage, var7, var12, 0, 20);
      }
   }

   // $VF: renamed from: c (javax.microedition.lcdui.Graphics) void
   public void collectVisibleEntities(Graphics var1) {
      this.activeEntityCount = 0;

      for (int var2 = 0; var2 < this.levelObjectCount; var2++) {
         if (this.levelObjects[var2].actorAnimationFlagB
            && this.currentTileType == this.levelTileTypes[this.levelObjects[var2].actorAnimationByteStateB][this.levelObjects[var2].actorAnimationByteStateC]
            && this.levelObjectProperties[this.levelObjects[var2].actorAnimationByteStateA][6] != 1
            && this.levelObjectProperties[this.levelObjects[var2].actorAnimationByteStateA][8] == 1) {
            int var5 = this.tileToScreenX(this.levelObjects[var2].actorAnimationByteStateB, this.levelObjects[var2].actorAnimationByteStateC) - this.cameraX;
            int var6 = this.tileToScreenY(this.levelObjects[var2].actorAnimationByteStateB, this.levelObjects[var2].actorAnimationByteStateC) - this.cameraY;
            this.renderLevelRegion(var1, var2, var5 + this.gameByteStateAN, var6 + this.gameByteStateAO);
         }
      }

      for (int var9 = 0; var9 < this.levelObjectCount; var9++) {
         if (this.levelObjects[var9].actorAnimationFlagB
            && this.currentTileType == this.levelTileTypes[this.levelObjects[var9].actorAnimationByteStateB][this.levelObjects[var9].actorAnimationByteStateC]
            && this.levelObjectProperties[this.levelObjects[var9].actorAnimationByteStateA][6] != 1
            && this.levelObjectProperties[this.levelObjects[var9].actorAnimationByteStateA][8] != 1) {
            int var24;
            int var33;
            if (this.levelObjects[var9].actorAnimationFlagD) {
               var24 = this.levelObjects[var9].actorAnimationByteStateB + this.levelObjectProperties[this.levelObjects[var9].actorAnimationByteStateA][5];
               var33 = this.levelObjects[var9].actorAnimationByteStateC + this.levelObjectProperties[this.levelObjects[var9].actorAnimationByteStateA][4];
            } else {
               var24 = this.levelObjects[var9].actorAnimationByteStateB + this.levelObjectProperties[this.levelObjects[var9].actorAnimationByteStateA][4];
               var33 = this.levelObjects[var9].actorAnimationByteStateC + this.levelObjectProperties[this.levelObjects[var9].actorAnimationByteStateA][5];
            }

            int var8 = -1;

            for (int var3 = 0; var3 < this.activeEntityCount; var3++) {
               if (this.containsPoint(this.levelObjects[this.activeEntityIndices[var3]].actorAnimationByteStateB, this.levelObjects[this.activeEntityIndices[var3]].actorAnimationByteStateC, 0, 0, var24, var33)) {
                  var8 = -1;
               } else if (var8 == -1) {
                  var8 = var3;
               }
            }

            if (var8 == -1) {
               this.activeEntityIndices[this.activeEntityCount] = (short)var9;
               this.entityTypeByIndex[this.activeEntityCount] = 0;
            } else {
               for (int var4 = this.activeEntityCount; var4 > var8; var4--) {
                  this.activeEntityIndices[var4] = this.activeEntityIndices[var4 - 1];
                  this.entityTypeByIndex[var4] = this.entityTypeByIndex[var4 - 1];
               }

               this.activeEntityIndices[var8] = (short)var9;
               this.entityTypeByIndex[var8] = 0;
            }

            this.activeEntityCount++;
         }
      }

      for (int var10 = 0; var10 < 24; var10++) {
         if (this.actorStates[var10].isActive
            && this.actorStates[var10].tileX < this.gameByteStateAQ
            && this.actorStates[var10].tileY < this.gameByteStateAR
            && this.actorStates[var10].animationSetIndex != 3
            && this.currentTileType == this.levelTileTypes[this.actorStates[var10].tileX][this.actorStates[var10].tileY]
            && this.actorStates[var10].animationFrameIndex == 4) {
            sbyte var25 = this.actorStates[var10].tileX;
            sbyte var34 = this.actorStates[var10].tileY;
            int var42 = -1;

            for (int var16 = 0; var16 < this.activeEntityCount; var16++) {
               if (this.entityTypeByIndex[var16] == 0) {
                  if (this.containsPoint(this.levelObjects[this.activeEntityIndices[var16]].actorAnimationByteStateB, this.levelObjects[this.activeEntityIndices[var16]].actorAnimationByteStateC, 0, 0, var25, var34)) {
                     var42 = -1;
                  } else if (var42 == -1) {
                     var42 = var16;
                  }
               } else if (this.entityTypeByIndex[var16] == 4) {
                  if (this.containsPoint(this.actorStates[this.activeEntityIndices[var16]].tileX, this.actorStates[this.activeEntityIndices[var16]].tileY, 0, 0, var25, var34)) {
                     var42 = -1;
                  } else if (var42 == -1) {
                     var42 = var16;
                  }
               }
            }

            if (var42 == -1) {
               this.activeEntityIndices[this.activeEntityCount] = (short)var10;
               this.entityTypeByIndex[this.activeEntityCount] = 4;
            } else {
               for (int var20 = this.activeEntityCount; var20 > var42; var20--) {
                  this.activeEntityIndices[var20] = this.activeEntityIndices[var20 - 1];
                  this.entityTypeByIndex[var20] = this.entityTypeByIndex[var20 - 1];
               }

               this.activeEntityIndices[var42] = (short)var10;
               this.entityTypeByIndex[var42] = 4;
            }

            this.activeEntityCount++;
         }
      }

      for (int var11 = 0; var11 < 24; var11++) {
         if (this.actorStates[var11].isActive
            && this.actorStates[var11].tileX < this.gameByteStateAQ
            && this.actorStates[var11].tileY < this.gameByteStateAR
            && this.currentTileType == this.levelTileTypes[this.actorStates[var11].tileX][this.actorStates[var11].tileY]
            && (this.actorStates[var11].animationFrameIndex != 4 || this.actorStates[var11].actorRuntimeFlagD || this.actorStates[var11].animationSetIndex == 3)) {
            int var26 = this.actorStates[var11].tileX + 1;
            int var35 = this.actorStates[var11].tileY + 1;
            int var43 = -1;

            for (int var17 = 0; var17 < this.activeEntityCount; var17++) {
               if (this.entityTypeByIndex[var17] == 0) {
                  if (this.containsPoint(this.levelObjects[this.activeEntityIndices[var17]].actorAnimationByteStateB, this.levelObjects[this.activeEntityIndices[var17]].actorAnimationByteStateC, 0, 0, var26, var35)) {
                     var43 = -1;
                  } else if (var43 == -1) {
                     var43 = var17;
                  }
               } else if (this.entityTypeByIndex[var17] == 1) {
                  if (this.containsPoint(this.actorStates[this.activeEntityIndices[var17]].tileX, this.actorStates[this.activeEntityIndices[var17]].tileY, 0, 0, var26, var35)) {
                     var43 = -1;
                  } else if (var43 == -1) {
                     var43 = var17;
                  }
               } else if (this.entityTypeByIndex[var17] == 4) {
                  if (this.actorStates[this.activeEntityIndices[var17]].movementDirection == 7) {
                     if (this.containsPoint(
                        this.actorStates[this.activeEntityIndices[var17]].tileX,
                        this.actorStates[this.activeEntityIndices[var17]].tileY - objectCollisionInsets[this.actorStates[this.activeEntityIndices[var17]].animationSetIndex][1] + 1,
                        0,
                        0,
                        var26,
                        var35
                     )) {
                        var43 = -1;
                     } else if (var43 == -1) {
                        var43 = var17;
                     }
                  } else if (this.actorStates[this.activeEntityIndices[var17]].movementDirection == 1) {
                     if (this.containsPoint(
                        this.actorStates[this.activeEntityIndices[var17]].tileX - objectCollisionInsets[this.actorStates[this.activeEntityIndices[var17]].animationSetIndex][1] + 1,
                        this.actorStates[this.activeEntityIndices[var17]].tileY,
                        0,
                        0,
                        var26,
                        var35
                     )) {
                        var43 = -1;
                     } else if (var43 == -1) {
                        var43 = var17;
                     }
                  } else if (this.containsPoint(this.actorStates[this.activeEntityIndices[var17]].tileX, this.actorStates[this.activeEntityIndices[var17]].tileY, 0, 0, var26, var35)
                     )
                   {
                     var43 = -1;
                  } else if (var43 == -1) {
                     var43 = var17;
                  }
               }
            }

            if (var43 == -1) {
               this.activeEntityIndices[this.activeEntityCount] = (short)var11;
               this.entityTypeByIndex[this.activeEntityCount] = 1;
            } else {
               for (int var21 = this.activeEntityCount; var21 > var43; var21--) {
                  this.activeEntityIndices[var21] = this.activeEntityIndices[var21 - 1];
                  this.entityTypeByIndex[var21] = this.entityTypeByIndex[var21 - 1];
               }

               this.activeEntityIndices[var43] = (short)var11;
               this.entityTypeByIndex[var43] = 1;
            }

            this.activeEntityCount++;
         }
      }

      for (int var12 = 0; var12 < 10; var12++) {
         if (this.animatedEntityStates[var12].isAnimationActive) {
            sbyte var27 = this.animatedEntityStates[var12].objectState.worldObjectByteStateB;
            sbyte var36 = this.animatedEntityStates[var12].objectState.worldObjectByteStateC;
            int var44 = -1;

            for (int var18 = 0; var18 < this.activeEntityCount; var18++) {
               if (this.entityTypeByIndex[var18] == 0) {
                  if (var27 >= this.levelObjects[this.activeEntityIndices[var18]].actorAnimationByteStateB && var36 >= this.levelObjects[this.activeEntityIndices[var18]].actorAnimationByteStateC) {
                     var44 = -1;
                  } else if (var44 == -1) {
                     var44 = var18;
                  }
               } else if (this.entityTypeByIndex[var18] != 1 && this.entityTypeByIndex[var18] != 4) {
                  if (this.entityTypeByIndex[var18] == 2) {
                     if (this.animatedEntityStates[var12].objectState.worldObjectShortValueB >= this.animatedEntityStates[this.activeEntityIndices[var18]].objectState.worldObjectShortValueB) {
                        var44 = -1;
                     } else if (var44 == -1) {
                        var44 = var18;
                     }
                  }
               } else if (var27 >= this.actorStates[this.activeEntityIndices[var18]].tileX && var36 >= this.actorStates[this.activeEntityIndices[var18]].tileY) {
                  var44 = -1;
               } else if (var44 == -1) {
                  var44 = var18;
               }
            }

            if (var44 == -1) {
               this.activeEntityIndices[this.activeEntityCount] = (short)var12;
               this.entityTypeByIndex[this.activeEntityCount] = 2;
            } else {
               for (int var22 = this.activeEntityCount; var22 > var44; var22--) {
                  this.activeEntityIndices[var22] = this.activeEntityIndices[var22 - 1];
                  this.entityTypeByIndex[var22] = this.entityTypeByIndex[var22 - 1];
               }

               this.activeEntityIndices[var44] = (short)var12;
               this.entityTypeByIndex[var44] = 2;
            }

            this.activeEntityCount++;
         }
      }

      for (int var13 = 0; var13 < 5; var13++) {
         if (this.objectStates[var13].worldObjectFlagA) {
            sbyte var28 = this.objectStates[var13].worldObjectByteStateB;
            sbyte var37 = this.objectStates[var13].worldObjectByteStateC;
            int var45 = -1;

            for (int var19 = 0; var19 < this.activeEntityCount; var19++) {
               if (this.entityTypeByIndex[var19] == 0) {
                  if (var28 >= this.levelObjects[this.activeEntityIndices[var19]].actorAnimationByteStateB && var37 >= this.levelObjects[this.activeEntityIndices[var19]].actorAnimationByteStateC) {
                     var45 = -1;
                  } else if (var45 == -1) {
                     var45 = var19;
                  }
               } else if (this.entityTypeByIndex[var19] != 1 && this.entityTypeByIndex[var19] != 4) {
                  if (this.entityTypeByIndex[var19] == 2) {
                     if (this.animatedEntityStates[var13].objectState.worldObjectShortValueB >= this.animatedEntityStates[this.activeEntityIndices[var19]].objectState.worldObjectShortValueB) {
                        var45 = -1;
                     } else if (var45 == -1) {
                        var45 = var19;
                     }
                  } else if (this.entityTypeByIndex[var19] == 3) {
                     if (this.objectStates[var13].worldObjectShortValueB >= this.objectStates[this.activeEntityIndices[var19]].worldObjectShortValueB) {
                        var45 = -1;
                     } else if (var45 == -1) {
                        var45 = var19;
                     }
                  }
               } else if (var28 >= this.actorStates[this.activeEntityIndices[var19]].tileX && var37 >= this.actorStates[this.activeEntityIndices[var19]].tileY) {
                  var45 = -1;
               } else if (var45 == -1) {
                  var45 = var19;
               }
            }

            if (var45 == -1) {
               this.activeEntityIndices[this.activeEntityCount] = (short)var13;
               this.entityTypeByIndex[this.activeEntityCount] = 3;
            } else {
               for (int var23 = this.activeEntityCount; var23 > var45; var23--) {
                  this.activeEntityIndices[var23] = this.activeEntityIndices[var23 - 1];
                  this.entityTypeByIndex[var23] = this.entityTypeByIndex[var23 - 1];
               }

               this.activeEntityIndices[var45] = (short)var13;
               this.entityTypeByIndex[var45] = 3;
            }

            this.activeEntityCount++;
         }
      }

      this.renderMedicalItem(var1);

      for (int var14 = 0; var14 < this.activeEntityCount; var14++) {
         if (this.entityTypeByIndex[var14] == 0) {
            int var29 = this.tileToScreenX(this.levelObjects[this.activeEntityIndices[var14]].actorAnimationByteStateB, this.levelObjects[this.activeEntityIndices[var14]].actorAnimationByteStateC) - this.cameraX;
            int var38 = this.tileToScreenY(this.levelObjects[this.activeEntityIndices[var14]].actorAnimationByteStateB, this.levelObjects[this.activeEntityIndices[var14]].actorAnimationByteStateC) - this.cameraY;
            this.renderLevelRegion(var1, this.activeEntityIndices[var14], var29 + this.gameByteStateAN, var38 + this.gameByteStateAO);
         } else if (this.entityTypeByIndex[var14] == 1) {
            if (this.activeEntityIndices[var14] != this.gameByteStateAM - 1 || this.gameIntegerStateI <= 0 || this.gameIntegerStateI >= 20) {
               int var30 = this.tileToScreenX(this.actorStates[this.activeEntityIndices[var14]].tileX, this.actorStates[this.activeEntityIndices[var14]].tileY) - this.cameraX;
               int var39 = this.tileToScreenY(this.actorStates[this.activeEntityIndices[var14]].tileX, this.actorStates[this.activeEntityIndices[var14]].tileY) - this.cameraY;
               this.drawActor(var1, this.actorStates[this.activeEntityIndices[var14]], var30 + this.gameByteStateAN, var39 + this.gameByteStateAO);
            }
         } else if (this.entityTypeByIndex[var14] == 2) {
            this.drawAnimatedEntity(var1, this.activeEntityIndices[var14]);
         } else if (this.entityTypeByIndex[var14] == 3) {
            this.drawLevelObject(var1, this.activeEntityIndices[var14]);
         } else if (this.entityTypeByIndex[var14] == 4) {
            int var31 = this.tileToScreenX(this.actorStates[this.activeEntityIndices[var14]].tileX, this.actorStates[this.activeEntityIndices[var14]].tileY) - this.cameraX;
            int var40 = this.tileToScreenY(this.actorStates[this.activeEntityIndices[var14]].tileX, this.actorStates[this.activeEntityIndices[var14]].tileY) - this.cameraY;
            this.drawActor(var1, this.actorStates[this.activeEntityIndices[var14]], var31 + this.gameByteStateAN, var40 + this.gameByteStateAO);
         }
      }

      bool var7 = false;

      for (int var15 = 0; var15 < this.levelObjectCount; var15++) {
         if (this.levelObjects[var15].actorAnimationFlagA
            && this.levelObjects[var15].actorAnimationFlagB
            && this.currentTileType != this.levelTileTypes[this.levelObjects[var15].actorAnimationByteStateB][this.levelObjects[var15].actorAnimationByteStateC]
            && (
               !this.levelObjects[var15].actorAnimationFlagD
                  ? this.levelObjects[var15].actorAnimationByteStateB != 0 && this.currentTileType == this.levelTileTypes[this.levelObjects[var15].actorAnimationByteStateB - 1][this.levelObjects[var15].actorAnimationByteStateC]
                  : this.levelObjects[var15].actorAnimationByteStateC != 0 && this.currentTileType == this.levelTileTypes[this.levelObjects[var15].actorAnimationByteStateB][this.levelObjects[var15].actorAnimationByteStateC - 1]
            )) {
            int var32 = this.tileToScreenX(this.levelObjects[var15].actorAnimationByteStateB, this.levelObjects[var15].actorAnimationByteStateC);
            int var41 = this.tileToScreenY(this.levelObjects[var15].actorAnimationByteStateB, this.levelObjects[var15].actorAnimationByteStateC);
            this.renderLevelRegion(var1, var15, var32 - this.cameraX + this.gameByteStateAN, var41 - this.cameraY + this.gameByteStateAO);
         }
      }
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, int) void
   public void drawAnimatedEntity(Graphics var1, int var2) {
      int var3 = SpriteAnimationFrameTable.frameOriginOffsets[this.animatedEntityStates[var2].objectState.worldObjectByteStateA][2] + this.animatedEntityStates[var2].objectState.worldObjectByteStateD;
      switch (this.animatedEntityStates[var2].animationType) {
         case 4:
            this.drawClippedSprite(
               var1,
               8,
               this.animatedEntityStates[var2].objectState.worldObjectShortValueA - this.cameraX + SpriteAnimationFrameTable.frameAnchorOffsets[var3][4],
               this.animatedEntityStates[var2].objectState.worldObjectShortValueB - this.animatedEntityStates[var2].objectState.worldObjectShortValueC - this.cameraY + SpriteAnimationFrameTable.frameAnchorOffsets[var3][5],
               SpriteAnimationFrameTable.frameAnchorOffsets[var3][2],
               SpriteAnimationFrameTable.frameAnchorOffsets[var3][3],
               SpriteAnimationFrameTable.frameAnchorOffsets[var3][0],
               SpriteAnimationFrameTable.frameAnchorOffsets[var3][1],
               0
            );
            this.setRgbColor(var1, 16, 16, 16);
            this.fillRectangle(
               var1,
               this.animatedEntityStates[var2].objectState.worldObjectShortValueA - this.cameraX + SpriteAnimationFrameTable.frameAnchorOffsets[var3][4],
               this.animatedEntityStates[var2].objectState.worldObjectShortValueB - this.cameraY + SpriteAnimationFrameTable.frameAnchorOffsets[var3][5],
               SpriteAnimationFrameTable.frameAnchorOffsets[var3][2],
               SpriteAnimationFrameTable.frameAnchorOffsets[var3][3]
            );
            break;
         default:
            this.drawClippedSprite(
               var1,
               objectTypeByAction[this.animatedEntityStates[var2].objectState.worldObjectByteStateA],
               this.animatedEntityStates[var2].objectState.worldObjectShortValueA - this.cameraX + SpriteAnimationFrameTable.frameAnchorOffsets[var3][4],
               this.animatedEntityStates[var2].objectState.worldObjectShortValueB - this.animatedEntityStates[var2].objectState.worldObjectShortValueC - this.cameraY + SpriteAnimationFrameTable.frameAnchorOffsets[var3][5],
               SpriteAnimationFrameTable.frameAnchorOffsets[var3][2],
               SpriteAnimationFrameTable.frameAnchorOffsets[var3][3],
               SpriteAnimationFrameTable.frameAnchorOffsets[var3][0],
               SpriteAnimationFrameTable.frameAnchorOffsets[var3][1],
               0
            ); break;
      }
   }

   // $VF: renamed from: b (javax.microedition.lcdui.Graphics, int) void
   public void drawLevelObject(Graphics var1, int var2) {
      int var3 = SpriteAnimationFrameTable.frameOriginOffsets[this.objectStates[var2].worldObjectByteStateA][2] + this.objectStates[var2].worldObjectByteStateD;
      if (this.objectStates[var2].worldObjectByteStateA >= 5 && this.objectStates[var2].worldObjectByteStateA <= 36) {
         bool var4 = this.objectStates[var2].worldObjectByteStateA > 9 && this.objectStates[var2].worldObjectByteStateA < 13
            || this.objectStates[var2].worldObjectByteStateA > 17 && this.objectStates[var2].worldObjectByteStateA <= 20
            || this.objectStates[var2].worldObjectByteStateA > 25 && this.objectStates[var2].worldObjectByteStateA < 29
            || this.objectStates[var2].worldObjectByteStateA > 33 && this.objectStates[var2].worldObjectByteStateA <= 36;
         this.drawObjectSprite(
            var1,
            objectTypeByAction[this.objectStates[var2].worldObjectByteStateA],
            this.objectStates[var2].worldObjectShortValueA - this.cameraX,
            this.objectStates[var2].worldObjectShortValueB - this.objectStates[var2].worldObjectShortValueC - this.cameraY,
            SpriteAnimationFrameTable.frameAnchorOffsets[var3][4],
            SpriteAnimationFrameTable.frameAnchorOffsets[var3][5],
            SpriteAnimationFrameTable.frameAnchorOffsets[var3][2],
            SpriteAnimationFrameTable.frameAnchorOffsets[var3][3],
            SpriteAnimationFrameTable.frameAnchorOffsets[var3][0],
            SpriteAnimationFrameTable.frameAnchorOffsets[var3][1],
            0,
            var4
         );
      } else if (this.objectStates[var2].worldObjectByteStateA == 39) {
         this.drawClippedSprite(
            var1,
            objectTypeByAction[this.objectStates[var2].worldObjectByteStateA],
            this.objectStates[var2].worldObjectShortValueA - this.cameraX + SpriteAnimationFrameTable.frameAnchorOffsets[var3][4],
            this.objectStates[var2].worldObjectShortValueB - this.objectStates[var2].worldObjectShortValueC - this.cameraY + SpriteAnimationFrameTable.frameAnchorOffsets[var3][5],
            SpriteAnimationFrameTable.frameAnchorOffsets[var3][2],
            SpriteAnimationFrameTable.frameAnchorOffsets[var3][3],
            SpriteAnimationFrameTable.frameAnchorOffsets[var3][0],
            SpriteAnimationFrameTable.frameAnchorOffsets[var3][1],
            0
         );
         if (var3 > 61 && var3 < 67) {
            var3 += 5;
            this.drawClippedSprite(
               var1,
               objectTypeByAction[this.objectStates[var2].worldObjectByteStateA],
               this.objectStates[var2].worldObjectShortValueA - this.cameraX + SpriteAnimationFrameTable.frameAnchorOffsets[var3][4],
               this.objectStates[var2].worldObjectShortValueB - this.objectStates[var2].worldObjectShortValueC - this.cameraY + SpriteAnimationFrameTable.frameAnchorOffsets[var3][5],
               SpriteAnimationFrameTable.frameAnchorOffsets[var3][2],
               SpriteAnimationFrameTable.frameAnchorOffsets[var3][3],
               SpriteAnimationFrameTable.frameAnchorOffsets[var3][0],
               SpriteAnimationFrameTable.frameAnchorOffsets[var3][1],
               0
            );
            var3 += 5;
            this.drawClippedSprite(
               var1,
               objectTypeByAction[this.objectStates[var2].worldObjectByteStateA],
               this.objectStates[var2].worldObjectShortValueA - this.cameraX + SpriteAnimationFrameTable.frameAnchorOffsets[var3][4],
               this.objectStates[var2].worldObjectShortValueB - this.objectStates[var2].worldObjectShortValueC - this.cameraY + SpriteAnimationFrameTable.frameAnchorOffsets[var3][5],
               SpriteAnimationFrameTable.frameAnchorOffsets[var3][2],
               SpriteAnimationFrameTable.frameAnchorOffsets[var3][3],
               SpriteAnimationFrameTable.frameAnchorOffsets[var3][0],
               SpriteAnimationFrameTable.frameAnchorOffsets[var3][1],
               0
            );
            var3 += 5;
            this.drawClippedSprite(
               var1,
               objectTypeByAction[this.objectStates[var2].worldObjectByteStateA],
               this.objectStates[var2].worldObjectShortValueA - this.cameraX + SpriteAnimationFrameTable.frameAnchorOffsets[var3][4],
               this.objectStates[var2].worldObjectShortValueB - this.objectStates[var2].worldObjectShortValueC - this.cameraY + SpriteAnimationFrameTable.frameAnchorOffsets[var3][5],
               SpriteAnimationFrameTable.frameAnchorOffsets[var3][2],
               SpriteAnimationFrameTable.frameAnchorOffsets[var3][3],
               SpriteAnimationFrameTable.frameAnchorOffsets[var3][0],
               SpriteAnimationFrameTable.frameAnchorOffsets[var3][1],
               0
            );
            var3 += 5;
            this.drawClippedSprite(
               var1,
               objectTypeByAction[this.objectStates[var2].worldObjectByteStateA],
               this.objectStates[var2].worldObjectShortValueA - this.cameraX + SpriteAnimationFrameTable.frameAnchorOffsets[var3][4],
               this.objectStates[var2].worldObjectShortValueB - this.objectStates[var2].worldObjectShortValueC - this.cameraY + SpriteAnimationFrameTable.frameAnchorOffsets[var3][5],
               SpriteAnimationFrameTable.frameAnchorOffsets[var3][2],
               SpriteAnimationFrameTable.frameAnchorOffsets[var3][3],
               SpriteAnimationFrameTable.frameAnchorOffsets[var3][0],
               SpriteAnimationFrameTable.frameAnchorOffsets[var3][1],
               0
            );
         }
      } else {
         this.drawClippedSprite(
            var1,
            objectTypeByAction[this.objectStates[var2].worldObjectByteStateA],
            this.objectStates[var2].worldObjectShortValueA - this.cameraX + SpriteAnimationFrameTable.frameAnchorOffsets[var3][4],
            this.objectStates[var2].worldObjectShortValueB - this.objectStates[var2].worldObjectShortValueC - this.cameraY + SpriteAnimationFrameTable.frameAnchorOffsets[var3][5],
            SpriteAnimationFrameTable.frameAnchorOffsets[var3][2],
            SpriteAnimationFrameTable.frameAnchorOffsets[var3][3],
            SpriteAnimationFrameTable.frameAnchorOffsets[var3][0],
            SpriteAnimationFrameTable.frameAnchorOffsets[var3][1],
            0
         );
      }
   }

   // $VF: renamed from: d (javax.microedition.lcdui.Graphics) void
   public void renderLevelScene(Graphics var1) {
      this.renderTileLayer(var1, this.cameraX, this.cameraY, canvasWidth, canvasHeight, 0 + this.gameByteStateAN, 0 + this.gameByteStateAO);
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, int, int, int, int, int, int) void
   public void renderTileLayer(Graphics var1, int var2, int var3, int var4, int var5, int var6, int var7) {
      if (var4 != 0) {
         if (var5 != 0) {
            this.gameCanvas.setGraphicsClip(var1, var6, var7, var4, var5);
            this.gameCanvas.setGraphicsRgbColor(var1, 0, 0, 0);
            this.gameCanvas.fillCanvasRectangle(var1, var6, var7, var4, var5);

            for (int var9 = 0; var9 < this.levelObjectCount; var9++) {
               if (this.levelObjects[var9].actorAnimationFlagA && !this.levelObjects[var9].actorAnimationFlagB) {
                  for (int var10 = 0; var10 < this.levelObjectProperties[this.levelObjects[var9].actorAnimationByteStateA][5]; var10++) {
                     sbyte var8;
                     int var11;
                     int var12;
                     if (this.currentTileType == this.levelTileTypes[this.levelObjects[var9].actorAnimationByteStateB][this.levelObjects[var9].actorAnimationByteStateC]) {
                        if (!this.levelObjects[var9].actorAnimationFlagD) {
                           if (this.levelObjects[var9].actorAnimationByteStateB == 0) {
                              continue;
                           }

                           var8 = this.levelTileFlags[this.levelObjects[var9].actorAnimationByteStateB - 1][this.levelObjects[var9].actorAnimationByteStateC + var10];
                           var11 = this.tileToScreenX(this.levelObjects[var9].actorAnimationByteStateB - 1, this.levelObjects[var9].actorAnimationByteStateC + var10) - var2;
                           var12 = this.tileToScreenY(this.levelObjects[var9].actorAnimationByteStateB - 1, this.levelObjects[var9].actorAnimationByteStateC + var10) - var3;
                        } else {
                           if (this.levelObjects[var9].actorAnimationByteStateC == 0) {
                              continue;
                           }

                           var8 = this.levelTileFlags[this.levelObjects[var9].actorAnimationByteStateB + var10][this.levelObjects[var9].actorAnimationByteStateC - 1];
                           var11 = this.tileToScreenX(this.levelObjects[var9].actorAnimationByteStateB + var10, this.levelObjects[var9].actorAnimationByteStateC - 1) - var2;
                           var12 = this.tileToScreenY(this.levelObjects[var9].actorAnimationByteStateB + var10, this.levelObjects[var9].actorAnimationByteStateC - 1) - var3;
                        }
                     } else if (!this.levelObjects[var9].actorAnimationFlagD) {
                        if (this.levelObjects[var9].actorAnimationByteStateB == 0
                           || this.currentTileType != this.levelTileTypes[this.levelObjects[var9].actorAnimationByteStateB - 1][this.levelObjects[var9].actorAnimationByteStateC]) {
                           continue;
                        }

                        var8 = this.levelTileFlags[this.levelObjects[var9].actorAnimationByteStateB][this.levelObjects[var9].actorAnimationByteStateC + var10];
                        var11 = this.tileToScreenX(this.levelObjects[var9].actorAnimationByteStateB, this.levelObjects[var9].actorAnimationByteStateC + var10) - var2;
                        var12 = this.tileToScreenY(this.levelObjects[var9].actorAnimationByteStateB, this.levelObjects[var9].actorAnimationByteStateC + var10) - var3;
                     } else {
                        if (this.levelObjects[var9].actorAnimationByteStateC == 0
                           || this.currentTileType != this.levelTileTypes[this.levelObjects[var9].actorAnimationByteStateB][this.levelObjects[var9].actorAnimationByteStateC - 1]) {
                           continue;
                        }

                        var8 = this.levelTileFlags[this.levelObjects[var9].actorAnimationByteStateB + var10][this.levelObjects[var9].actorAnimationByteStateC];
                        var11 = this.tileToScreenX(this.levelObjects[var9].actorAnimationByteStateB + var10, this.levelObjects[var9].actorAnimationByteStateC) - var2;
                        var12 = this.tileToScreenY(this.levelObjects[var9].actorAnimationByteStateB + var10, this.levelObjects[var9].actorAnimationByteStateC) - var3;
                     }

                     if (var8 != 127) {
                        this.drawClippedSprite(var1, 89 + var8, var11 + var6, var12 + var7, 36, 18, 0, 0, 0);
                     }
                  }
               }
            }

            for (int var14 = 0; var14 < this.gameByteStateAQ; var14++) {
               for (int var17 = 0; var17 < this.gameByteStateAR; var17++) {
                  if (this.levelTileTypes[var14][var17] == this.currentTileType) {
                     int var19 = this.tileToScreenX(var14, var17) - var2;
                     int var22 = this.tileToScreenY(var14, var17) - var3;
                     sbyte var13 = this.levelTileFlags[var14][var17];
                     if (var13 != 127) {
                        this.drawClippedSprite(var1, 89 + var13, var19 + var6, var22 + var7, 36, 18, 0, 0, 0);
                     }
                  }
               }
            }

            for (int var15 = 0; var15 < this.gameByteStateAQ; var15++) {
               for (int var18 = 0; var18 < this.gameByteStateAR; var18++) {
                  if (this.levelTileTypes[var15][var18] == this.currentTileType) {
                     int var20 = this.tileToScreenX(var15, var18) - var2;
                     int var23 = this.tileToScreenY(var15, var18) - var3;
                     this.drawTileSprite(var1, this.levelTileHeights[var15][var18], true, true, var20 + var6, var23 + var7);
                     this.drawTileSprite(var1, this.levelTileWidths[var15][var18], false, true, var20 + var6, var23 + var7);
                  }
               }
            }

            for (int var16 = 0; var16 < this.levelObjectCount; var16++) {
               if (this.levelObjects[var16].actorAnimationFlagB
                  && this.currentTileType == this.levelTileTypes[this.levelObjects[var16].actorAnimationByteStateB][this.levelObjects[var16].actorAnimationByteStateC]
                  && this.levelObjectProperties[this.levelObjects[var16].actorAnimationByteStateA][6] == 1) {
                  int var21 = this.tileToScreenX(this.levelObjects[var16].actorAnimationByteStateB, this.levelObjects[var16].actorAnimationByteStateC) - var2;
                  int var24 = this.tileToScreenY(this.levelObjects[var16].actorAnimationByteStateB, this.levelObjects[var16].actorAnimationByteStateC) - var3;
               }
            }
         }
      }
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, short, boolean, boolean, int, int) void
   public void drawTileSprite(Graphics var1, short var2, bool var3, bool var4, int var5, int var6) {
      if (var2 != -1) {
         sbyte var8;
         if (var3) {
            var8 = 0;
         } else {
            var5 += 18;
            var8 = 18;
         }

         int var7 = var2 & 255;
         if (var7 != 255) {
            this.drawClippedSprite(var1, 109 + var7, var5, var6 - 21, 18, 29, var8, 0, 0);
            this.drawClippedSprite(var1, 109 + var7, var5, var6 - 21 + 1, 18, 29, var8, 0, 0);
         }

         if (var4) {
            var7 = var2 >> 8 & 0xFF;
            if (var7 != 255) {
               this.drawClippedSprite(var1, 109 + var7, var5, var6 - 42 + 1, 18, 29, var8, 0, 0);
            }
         }
      }
   }

   // $VF: renamed from: b (javax.microedition.lcdui.Graphics, int, int, int, int) void
   public void drawLine(Graphics var1, int var2, int var3, int var4, int var5) {
      var1.drawLine(var2, var3, var4, var5);
   }

   // $VF: renamed from: c (javax.microedition.lcdui.Graphics, int, int, int, int) void
   public void drawRectangleOutline(Graphics var1, int var2, int var3, int var4, int var5) {
      var1.drawRect(var2, var3, var4 - 1, var5 - 1);
   }

   // $VF: renamed from: d (javax.microedition.lcdui.Graphics, int, int, int, int) void
   public void fillRectangle(Graphics var1, int var2, int var3, int var4, int var5) {
      var1.fillRect(var2, var3, var4, var5);
   }

   // $VF: renamed from: b (javax.microedition.lcdui.Graphics, int, int, int) void
   public void setRgbColor(Graphics var1, int var2, int var3, int var4) {
      var1.setColor(var2, var3, var4);
   }

   // $VF: renamed from: c (javax.microedition.lcdui.Graphics, int) void
   public void setPackedColor(Graphics var1, int var2) {
      this.setRgbColor(var1, var2 >> 16 & 0xFF, var2 >> 8 & 0xFF, var2 & 0xFF);
   }

   // $VF: renamed from: a (int, int, int, int, int, int, int, int) boolean
   public bool rectanglesOverlap(int var1, int var2, int var3, int var4, int var5, int var6, int var7, int var8) {
      return (var5 >= var1 && var5 < var1 + var3 || var5 < var1 && var5 + var7 > var1)
         && (var6 >= var2 && var6 < var2 + var4 || var6 < var2 && var6 + var8 > var2);
   }

   // $VF: renamed from: a (int, int, int, int, int, int) boolean
   public bool containsPoint(int var1, int var2, int var3, int var4, int var5, int var6) {
      return var1 >= var3 && var1 < var3 + var5 && var2 >= var4 && var2 < var4 + var6;
   }

   // $VF: renamed from: a (int, int, int) int
   public int clampInteger(int var1, int var2, int var3) {
      return var2 > var1 ? var2 : (var1 > var3 ? var3 : var1);
   }

   // $VF: renamed from: h (int) int
   public int squareInteger(int var1) {
      return var1 * var1;
   }

   // $VF: renamed from: A () int
   public int nextRandomByte() {
      return this.gameplayRandom.nextInt() & 0xFF;
   }

   // $VF: renamed from: i (int) int
   public static int nextRandomBelow(int var0) {
      return JMath.abs(sharedRandom.nextInt() % var0);
   }

   // $VF: renamed from: B () int
   public int nextRandomColor() {
      return JMath.abs(this.nextRandomByte() << 24 | this.nextRandomByte() << 16 | this.nextRandomByte() << 8 | this.nextRandomByte());
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, int, int, int, int, int, int, int, int) void
   public void drawClippedSprite(Graphics var1, int var2, int var3, int var4, int var5, int var6, int var7, int var8, int var9) {
      if (this.rectanglesOverlap(var3, var4, var5, var6, 0, 0, canvasWidth, canvasHeight)) {
         int var10 = var1.getClipX();
         int var11 = var1.getClipY();
         int var12 = var1.getClipWidth();
         int var13 = var1.getClipHeight();
         if ((var9 & 1) != 0) {
            for (int var14 = 0; var14 < var5; var14++) {
               var1.clipRect(var3 + var14, var4, 1, var6);
               if (var2 >= 9 && var2 < 89) {
                  this.levelArtworkRenderer.drawSpriteRegion(var1, var3 + var14 - (var7 + var5 - var14 - 1), var4 - var8, var2 - 9);
               } else if (var2 >= 89 && var2 < 109) {
                  this.levelArtworkRenderer.drawSpriteRegion(var1, var3 + var14 - (var7 + var5 - var14 - 1), var4 - var8, var2 - 89 + this.gameShortValueA);
               } else if (var2 >= 109 && var2 < 139) {
                  this.levelArtworkRenderer.drawSpriteRegion(var1, var3 + var14 - (var7 + var5 - var14 - 1), var4 - var8, var2 - 109 + this.gameShortValueA + this.gameShortValueB);
               } else {
                  var1.drawImage(this.objectImages[var2], var3 + var14 - (var7 + var5 - var14 - 1), var4 - var8, 20);
               }

               var1.setClip(var10, var11, var12, var13);
            }
         } else {
            var1.clipRect(var3, var4, var5, var6);
            if (var2 >= 9 && var2 < 89) {
               this.levelArtworkRenderer.drawSpriteRegion(var1, var3 - var7, var4 - var8, var2 - 9);
            } else if (var2 >= 89 && var2 < 109) {
               this.levelArtworkRenderer.drawSpriteRegion(var1, var3 - var7, var4 - var8, var2 - 89 + this.gameShortValueA);
            } else if (var2 >= 109 && var2 < 139) {
               this.levelArtworkRenderer.drawSpriteRegion(var1, var3 - var7, var4 - var8, var2 - 109 + this.gameShortValueA + this.gameShortValueB);
            } else {
               var1.drawImage(this.objectImages[var2], var3 - var7, var4 - var8, 20);
            }
         }

         var1.setClip(var10, var11, var12, var13);
      }
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, int, int, int, int, int, int, int, int, int, int, boolean) void
   public void drawObjectSprite(Graphics var1, int var2, int var3, int var4, int var5, int var6, int var7, int var8, int var9, int var10, int var11, bool var12) {
      if (this.objectVisibilityFlags[var2] != var12) {
         this.toggleObjectFlip(var2);
      }

      if (var9 < 0) {
         var9 += 256;
      }

      if (var10 < 0) {
         var10 += 256;
      }

      if (!var12) {
         var3 += var5;
         var4 += var6;
      } else {
         var3 = var3 + 36 - var5 - var7;
         var4 += var6;
      }

      if (var12) {
         var11 = 1;
      }

      this.drawClippedSprite(var1, var2, var3, var4, var7, var8, var9, var10, var11);
   }

   // $VF: renamed from: a (u) boolean
   public bool actorHasShadow(ActorRuntimeState var1) {
      return SpriteAnimationFrameTable.characterShadowGeometry[var1.animationSetIndex][var1.animationFrameIndex][2] != 0;
   }

   // $VF: renamed from: j (int) void
   public void toggleObjectFlip(int var1) {
      this.objectVisibilityFlags[var1] = !this.objectVisibilityFlags[var1];
   }

   // $VF: renamed from: C () void
   public void resetPlayerEffectState() {
      this.gameByteStateAS = 0;
      this.gameFlagD = false;
      this.gameFlagE = false;
      this.gameByteStateAT = 0;
      this.gameIntegerStateS = -1;
      this.gameIntegerStateT = 0;
      this.gameIntegerStateU = 0;
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, u, int, int) void
   public void drawActor(Graphics var1, ActorRuntimeState var2, int var3, int var4) {
      if (var2.animationSetIndex == 0) {
      }

      if (!this.isActorInTemporaryAnimation(var2)) {
         int var6 = gameIntegerStateArrayA[var2.animationSetIndex];
         int var5 = SpriteAnimationFrameTable.characterShadowGeometry[var2.animationSetIndex][var2.animationFrameIndex][4];
         bool var7 = var2.movementDirection > 4;
         if (SpriteAnimationFrameTable.characterShadowGeometry[var2.animationSetIndex][var2.animationFrameIndex][3] == 4) {
            var5 = SpriteAnimationFrameTable.characterOverlayGeometry[var2.animationSetIndex][var5][this.isDirectionWithinRange(var2, 0, 1) ? 0 : 1][var2.currentShadowDepth];
         } else {
            var5 = SpriteAnimationFrameTable.objectShadowGeometry[var5][var7 ? 8 - var2.movementDirection : var2.movementDirection][var2.currentShadowDepth];
         }

         this.drawObjectSprite(
            var1,
            var6,
            var3,
            var4,
            GameSpriteAssetData.spriteFrameGeometry[var2.animationSetIndex][var5][4],
            GameSpriteAssetData.spriteFrameGeometry[var2.animationSetIndex][var5][5],
            GameSpriteAssetData.spriteFrameGeometry[var2.animationSetIndex][var5][2],
            GameSpriteAssetData.spriteFrameGeometry[var2.animationSetIndex][var5][3],
            GameSpriteAssetData.spriteFrameGeometry[var2.animationSetIndex][var5][0],
            GameSpriteAssetData.spriteFrameGeometry[var2.animationSetIndex][var5][1],
            0,
            var7
         );
         if (var2 == this.activeCharacterState.characterAnimationObjectReferenceA) {
            if (!var7) {
               this.currentEntityCenterX = var3 + GameSpriteAssetData.spriteFrameGeometry[var2.animationSetIndex][var5][4] + GameSpriteAssetData.spriteFrameGeometry[var2.animationSetIndex][var5][2] / 2;
               this.currentEntityCenterY = var4 + GameSpriteAssetData.spriteFrameGeometry[var2.animationSetIndex][var5][5] + GameSpriteAssetData.spriteFrameGeometry[var2.animationSetIndex][var5][3] / 2;
            } else {
               this.currentEntityCenterX = var3 + 36 - GameSpriteAssetData.spriteFrameGeometry[var2.animationSetIndex][var5][4] - GameSpriteAssetData.spriteFrameGeometry[var2.animationSetIndex][var5][2] / 2;
               this.currentEntityCenterY = var4 + GameSpriteAssetData.spriteFrameGeometry[var2.animationSetIndex][var5][5] + GameSpriteAssetData.spriteFrameGeometry[var2.animationSetIndex][var5][3] / 2;
            }
         }

         this.drawActorAttachments(var1, var2, var6, var5, var3, var4, var7);
         this.drawActorOverrideFrame(var1, var2, var3, var4);
      }
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, u, int, int, int, int, boolean) void
   public void drawActorAttachments(Graphics var1, ActorRuntimeState var2, int var3, int var4, int var5, int var6, bool var7) {
      if (var2.animationSetIndex == 0 || var2.animationSetIndex == 1) {
         CharacterAnimationState var8 = this.primaryCharacterState;
         if (var4 > 9 && var4 < 22) {
            if (var8.characterAnimationObjectReferenceA.animationOverrideFrame == 127 || var8.characterAnimationByteStateD == 0) {
               var4 += 14;
               this.drawObjectSprite(
                  var1,
                  var3,
                  var5,
                  var6,
                  GameSpriteAssetData.spriteFrameAnimationData[var2.animationSetIndex][var4][4],
                  GameSpriteAssetData.spriteFrameAnimationData[var2.animationSetIndex][var4][5],
                  GameSpriteAssetData.spriteFrameAnimationData[var2.animationSetIndex][var4][2],
                  GameSpriteAssetData.spriteFrameAnimationData[var2.animationSetIndex][var4][3],
                  GameSpriteAssetData.spriteFrameAnimationData[var2.animationSetIndex][var4][0],
                  GameSpriteAssetData.spriteFrameAnimationData[var2.animationSetIndex][var4][1],
                  0,
                  var7
               );
            } else if (var8.characterAnimationByteStateD == 1 || var8.characterAnimationByteStateD == 2) {
               var4 -= 10;
               this.drawObjectSprite(
                  var1,
                  var3,
                  var5,
                  var6,
                  GameSpriteAssetData.spriteFrameAnimationData[var2.animationSetIndex][var4][4],
                  GameSpriteAssetData.spriteFrameAnimationData[var2.animationSetIndex][var4][5],
                  GameSpriteAssetData.spriteFrameAnimationData[var2.animationSetIndex][var4][2],
                  GameSpriteAssetData.spriteFrameAnimationData[var2.animationSetIndex][var4][3],
                  GameSpriteAssetData.spriteFrameAnimationData[var2.animationSetIndex][var4][0],
                  GameSpriteAssetData.spriteFrameAnimationData[var2.animationSetIndex][var4][1],
                  0,
                  var7
               );
            } else if (var8.characterAnimationByteStateD == 3 || var8.characterAnimationByteStateD == 4) {
               var4 += 2;
               this.drawObjectSprite(
                  var1,
                  var3,
                  var5,
                  var6,
                  GameSpriteAssetData.spriteFrameAnimationData[var2.animationSetIndex][var4][4],
                  GameSpriteAssetData.spriteFrameAnimationData[var2.animationSetIndex][var4][5],
                  GameSpriteAssetData.spriteFrameAnimationData[var2.animationSetIndex][var4][2],
                  GameSpriteAssetData.spriteFrameAnimationData[var2.animationSetIndex][var4][3],
                  GameSpriteAssetData.spriteFrameAnimationData[var2.animationSetIndex][var4][0],
                  GameSpriteAssetData.spriteFrameAnimationData[var2.animationSetIndex][var4][1],
                  0,
                  var7
               );
            }
         }
      }
   }

   // $VF: renamed from: b (javax.microedition.lcdui.Graphics, u, int, int) void
   public void drawActorOverrideFrame(Graphics var1, ActorRuntimeState var2, int var3, int var4) {
      if (var2.animationOverrideFrame != 127) {
         sbyte var7 = var2.animationOverrideFrame;
         int var6 = gameIntegerStateArrayB[var2.animationOverrideFrame];
         int var5 = SpriteAnimationFrameTable.characterShadowGeometry[var2.animationSetIndex][var2.animationFrameIndex][5];
         sbyte var8 = var2.movementDirection;
         if (var5 != 127) {
            bool var9 = var8 > 4;
            if (SpriteAnimationFrameTable.characterShadowGeometry[var2.animationSetIndex][var2.animationFrameIndex][3] == 4) {
               var5 = SpriteAnimationFrameTable.objectFrameGeometry[var5][this.isDirectionWithinRange(var2, 0, 1) ? 0 : 1][var2.currentShadowDepth];
            } else {
               var5 = SpriteAnimationFrameTable.objectShadowGeometry[var5][var9 ? 8 - var8 : var8][var2.currentShadowDepth];
            }

            if (var5 != 127) {
               this.drawObjectSprite(
                  var1,
                  var6,
                  var3,
                  var4,
                  SpriteAnimationFrameTable.characterFrameGeometry[var7][var5][4],
                  SpriteAnimationFrameTable.characterFrameGeometry[var7][var5][5],
                  SpriteAnimationFrameTable.characterFrameGeometry[var7][var5][2],
                  SpriteAnimationFrameTable.characterFrameGeometry[var7][var5][3],
                  SpriteAnimationFrameTable.characterFrameGeometry[var7][var5][0],
                  SpriteAnimationFrameTable.characterFrameGeometry[var7][var5][1],
                  0,
                  var9
               );
            }
         }
      }
   }

   // $VF: renamed from: f (u) boolean
   public bool isActorInTemporaryAnimation(ActorRuntimeState var1) {
      if (var1.animationFrameIndex == 4 && var1.animationSetIndex != 0 && var1.animationSetIndex != 1) {
         if (var1.optionalTimer + 3000L > this.gameClockTimeMs) {
            return var1.optionalTimer + 3000L - this.gameClockTimeMs >= 1000L ? false : this.updateTickCount % 3 != 0;
         } else {
            if (!var1.actorRuntimeFlagF) {
               this.gameIntegerStateAF++;
               this.gameIntegerStateAG++;
               this.gameIntegerStateAM--;
               if (this.gameIntegerStateAF >= this.animationDefinitions[this.gameByteStateBE][0] && this.gameByteStateAZ == 1) {
                  if (this.isCheatModeEnabled) {
                     this.gameIntegerStateAI = 9999;
                  } else {
                     this.gameIntegerStateAI = this.gameIntegerStateAI + this.animationDefinitions[this.gameByteStateBE][6];
                  }

                  if (this.gameIntegerStateAI > 9999) {
                     this.gameIntegerStateAI = 9999;
                  }

                  this.disposeAudioManager();
                  this.setPendingMessage(this.localizedText[19]);
                  this.gameByteStateBC++;
                  this.gameIntegerStateAH++;
                  this.gameIntegerStateG = 138;
                  this.gameByteStateAJ = 0;
                  this.configureBriefingMenu();
                  this.gameByteStateBI = 0;
                  this.gameFlagO = false;
                  this.gameFlagP = false;
                  this.gameFlagQ = false;
                  this.setCharacterPortraitIndices((sbyte)0, (sbyte)1);
               } else if (this.gameIntegerStateAF >= this.levelEventDefinitions[this.gameIntegerStateAL][2] && this.gameByteStateAZ == 0) {
                  this.disposeAudioManager();
                  screenActionCodeB = 19;
                  screenActionCodeC = 5;
                  this.resetGameSession((sbyte)3, false);
               }
            }

            var1.actorRuntimeFlagF = true;
            return true;
         }
      } else {
         return false;
      }
   }

   // $VF: renamed from: a (u, int, int) boolean
   public bool isDirectionWithinRange(ActorRuntimeState var1, int var2, int var3) {
      return JMath.abs(var1.movementDirection - var2) <= var3 ? true : JMath.abs(var1.movementDirection - var2) >= 8 - var3;
   }

   // $VF: renamed from: p (javax.microedition.lcdui.Graphics) void
   public void renderMenuOverlayMode1(Graphics var1) {
      this.drawScrollingMessage(var1, this.pendingMessage);
      if (this.mainMenu != null) {
         this.mainMenu.a(var1);
      }
   }

   // $VF: renamed from: q (javax.microedition.lcdui.Graphics) void
   public void renderMenuOverlayMode18(Graphics var1) {
      this.drawScrollingMessage(var1, this.pendingMessage);
      if (this.mainMenu != null) {
         this.mainMenu.a(var1);
      }
   }

   // $VF: renamed from: r (javax.microedition.lcdui.Graphics) void
   public void renderLevelSelectionDialog(Graphics var1) {
      this.drawScrollingMessage(var1, this.pendingMessage);
      if (this.messageDialog != null) {
         this.messageDialog.drawOverlay(var1);
      }

      int var3 = canvasHeight / 5 * 2;
      int var2 = var3 + this.fontRenderer.getFontBaselineOffset(1) * 4;
      this.gameCanvas.setGraphicsColor(var1, 16777215);
      this.fontRenderer.drawText(var1, this.localizedText[31] + " " + this.gameIntegerStateAL, 0, var2, canvasWidth, 1, 1);
      if (this.gameIntegerStateAL != 1) {
         GameCanvas.drawTriangle(var1, canvasWidth / 6 * 1, var2 + this.fontRenderer.getFontBaselineOffset(1) / 2, 2, 4, 16777215);
      }

      if (this.gameIntegerStateAL < this.gameByteStateBJ && this.unlockedLevelFlags[this.gameIntegerStateAL + 1]) {
         GameCanvas.drawTriangle(var1, canvasWidth / 6 * 5, var2 + this.fontRenderer.getFontBaselineOffset(1) / 2, 3, 4, 16777215);
      }
   }

   // $VF: renamed from: s (javax.microedition.lcdui.Graphics) void
   public void renderDialogAndMenuMode20(Graphics var1) {
      this.drawScrollingMessage(var1, this.pendingMessage);
      if (this.messageDialog != null) {
         this.messageDialog.drawOverlay(var1);
      }

      if (this.mainMenu != null) {
         this.mainMenu.a(var1);
      }
   }

   // $VF: renamed from: t (javax.microedition.lcdui.Graphics) void
   public void renderMenuOverlayMode19(Graphics var1) {
      this.drawScrollingMessage(var1, this.pendingMessage);
      if (this.mainMenu != null) {
         this.mainMenu.a(var1);
      }
   }

   // $VF: renamed from: u (javax.microedition.lcdui.Graphics) void
   public void renderMenuOverlayMode21(Graphics var1) {
      this.drawScrollingMessage(var1, this.pendingMessage);
      if (this.mainMenu != null) {
         this.mainMenu.a(var1);
      }
   }

   // $VF: renamed from: v (javax.microedition.lcdui.Graphics) void
   public void renderDialogAndMenuMode22(Graphics var1) {
      this.drawScrollingMessage(var1, this.pendingMessage);
      if (this.messageDialog != null) {
         this.messageDialog.drawOverlay(var1);
      }

      if (this.mainMenu != null) {
         this.mainMenu.a(var1);
      }
   }

   // $VF: renamed from: w (javax.microedition.lcdui.Graphics) void
   public void renderMenuWithDescriptionMode16(Graphics var1) {
      this.drawScrollingMessage(var1, this.pendingMessage);
      if (this.mainMenu != null) {
         this.mainMenu.a(var1);
      }

      this.gameCanvas.setGraphicsColor(var1, 16777215);
      if (this.gameFlagX) {
         this.fontRenderer.drawWrappedText(var1, this.localizedText[64 + this.mainMenu.a()], 2, this.gameIntegerStateAO, canvasWidth - 4, 1, 1, this.fontRenderer.getFontBaselineOffset(1), false);
      }
   }

   // $VF: renamed from: x (javax.microedition.lcdui.Graphics) void
   public void renderMenuOverlayMode6(Graphics var1) {
      this.drawScrollingMessage(var1, this.pendingMessage);
      if (this.mainMenu != null) {
         this.mainMenu.a(var1);
      }
   }

   // $VF: renamed from: y (javax.microedition.lcdui.Graphics) void
   public void renderMessageDialogMode10(Graphics var1) {
      this.drawScrollingMessage(var1, this.pendingMessage);
      if (this.messageDialog != null) {
         this.messageDialog.drawOverlay(var1);
      }

      if (this.mainMenu != null) {
         this.mainMenu.a(var1);
      }
   }

   // $VF: renamed from: z (javax.microedition.lcdui.Graphics) void
   public void renderCharacterPortraitHud(Graphics var1) {
      if (gameModeCode != 3) {
         if (this.portraitImageIndices[0] >= 0) {
            this.gameCanvas.drawImage(var1, this.characterPortraitImages[this.portraitImageIndices[0]], 2, canvasHeight - 2, 36);
         }

         if (this.portraitImageIndices[1] >= 0) {
            this.gameCanvas.drawImage(var1, this.characterPortraitImages[this.portraitImageIndices[1]], canvasWidth - 2, canvasHeight - 2, 40);
         }
      }
   }

   // $VF: renamed from: e (int, int) int
   public int tileToScreenX(int var1, int var2) {
      return this.levelPixelWidthHalf + (var1 - 1) * 18 - var2 * 18;
   }

   // $VF: renamed from: f (int, int) int
   public int tileToScreenY(int var1, int var2) {
      return var2 * 9 + var1 * 9;
   }

   // $VF: renamed from: g (int, int) int
   public int screenToTileX(int var1, int var2) {
      return (var2 - (var1 - this.levelPixelWidthHalf) / 2) / 18;
   }

   // $VF: renamed from: h (int, int) int
   public int screenToTileY(int var1, int var2) {
      return (var2 + (var1 - this.levelPixelWidthHalf) / 2) / 18;
   }

   // $VF: renamed from: i (int, int) void
   public void setCameraPosition(int var1, int var2) {
      this.cameraX = var1;
      this.cameraY = var2;
   }

   // $VF: renamed from: D () boolean
   public bool isCharacterAnimating() {
      bool var1 = this.activeCharacterState.characterAnimationObjectReferenceA.animationFrameIndex == 0
         || this.activeCharacterState.characterAnimationObjectReferenceA.animationFrameIndex == 8
         || this.activeCharacterState.characterAnimationObjectReferenceA.animationFrameIndex == 9
         || this.activeCharacterState.characterAnimationObjectReferenceA.animationFrameIndex == 10
         || this.activeCharacterState.characterAnimationObjectReferenceA.animationFrameIndex == 11;
      return var1
         | (
            SpriteAnimationFrameTable.characterShadowGeometry[this.activeCharacterState.characterAnimationObjectReferenceA.animationSetIndex][this.activeCharacterState.characterAnimationObjectReferenceA.animationFrameIndex][2] != 0
               && SpriteAnimationFrameTable.characterShadowGeometry[this.activeCharacterState.characterAnimationObjectReferenceA.animationSetIndex][this.activeCharacterState.characterAnimationObjectReferenceA.animationFrameIndex][2] < this.activeCharacterState.characterAnimationObjectReferenceA.currentShadowDepth
         );
   }

   // $VF: renamed from: j (int, int) int
   public int scaleByFrameDelta(int var1, int var2) {
      int var3 = var1 * this.frameDeltaMs >> 6;
      return this.clampInteger(var3, 1, 65536 / var2 + 1);
   }

   // $VF: renamed from: c (java.lang.String) void
   public void setPendingMessage(string var1) {
      this.pendingMessage = var1;
   }

   // $VF: renamed from: E () void
   public void configureLanguageSelectionMenu() {
      if (this.gameByteStateB == -1) {
         this.gameByteStateB = 0;
      }

      this.setPendingMessage(this.startupTextByLanguage[this.gameByteStateB == -1 ? 0 : this.gameByteStateB][1]);
      activeMenuLabels = null;
      activeMenuLabels = this.gameCanvas.getDisplayConfiguration();
      sbyte var1 = 3;
      int var2 = canvasHeight;
      int var3 = canvasHeight - var2 / 2 - 10;

      while (true) {
         this.mainMenu.configureMenuItems(activeMenuLabels, canvasWidth / 2, var3 + 0, var1, 0, 0, 2, this.gameIntegerStateAN, (sbyte)2, true, false);
         if (var1 == 1 || this.mainMenu.getMenuContentHeight() <= var2) {
            this.mainMenu.a(this.gameByteStateB);
            this.gameByteStateD = this.gameByteStateB;
            this.gameByteStateC = this.gameByteStateB;
            return;
         }

         var1 = (sbyte)(var1 - 2);
      }
   }

   // $VF: renamed from: ae () void
   public void configureMessageAndChoiceMenu() {
      this.setPendingMessage(this.statusMessage);
      string[] var1 = new string[]{this.startupTextByLanguage[this.gameByteStateB][4], this.startupTextByLanguage[this.gameByteStateB][5]};
      this.mainMenu.configureMenuItems(var1, canvasWidth / 2, canvasHeight / 2 + 0, 2, 0, 0, 2, this.gameIntegerStateAN, (sbyte)2, true, false);
      this.mainMenu.setMenuVerticalPosition(canvasHeight - this.characterPortraitImages[0].getHeight() - this.mainMenu.getMenuContentHeight() / 2 + 0);
      if (this.messageDialog == null) {
         this.messageDialog = new FramedMessageOverlay(this.gameCanvas, this.fontRenderer, (sbyte)1);
      }

      int var2 = 0;
      int var3 = 0;
      var2 = canvasHeight - this.characterPortraitImages[0].getHeight() - 10 - this.mainMenu.getMenuContentHeight() + -23;
      var3 = canvasHeight - this.characterPortraitImages[0].getHeight() - 10 - this.mainMenu.getMenuContentHeight() - var2 / 2;
      this.messageDialog.configureMessageOverlay(this.dialogMessage, canvasWidth / 2, var3, canvasWidth * 88 / 100, var2, 1, 2, true);
      if (this.messageDialog.getVisibleMessageLineCount() < 4) {
         var2 = this.messageDialog.topBorderImage.getHeight() + this.messageDialog.bottomBorderImage.getHeight() + 4 * (this.fontRenderer.getFontBaselineOffset(1) + 2);
         var3 = canvasHeight - this.characterPortraitImages[0].getHeight() - 10 - this.mainMenu.getMenuContentHeight() - var2 / 2 + 2;
         this.messageDialog.configureMessageOverlay(this.dialogMessage, canvasWidth / 2, var3, canvasWidth * 88 / 100, var2, 1, 2, true);
      }

      if (this.gameByteStateAH == -1) {
         this.mainMenu.a((sbyte)0);
      } else {
         this.mainMenu.a(this.gameByteStateAH);
      }

      this.gameByteStateAH = -1;
   }

   // $VF: renamed from: af () void
   public void configureInformationDialog() {
      string var3 = "";
      string var4 = "   ";
      string var5 = " / ";
      string var6 = "\n\n";
      this.setPendingMessage(this.localizedText[9]);
      int var2 = canvasHeight / 5 * 3;
      int var1 = var2 / 2 + this.fontRenderer.getFontBaselineOffset(1) * 3;
      var3 = var3 + this.localizedText[112];
      var3 = var3 + var6;
      var3 = var3 + this.localizedText[113];
      var3 = var3 + var6;
      var3 = var3 + this.localizedText[121];
      var3 = var3 + var6;
      var3 = var3 + this.localizedText[114];
      var3 = var3 + var6;
      var3 = var3 + this.localizedText[124];
      var3 = var3 + var6;
      var3 = var3 + this.localizedText[115];
      var3 = var3 + var6;
      var3 = var3 + this.localizedText[122];
      var3 = var3 + var6;
      var3 = var3 + this.localizedText[116];
      var3 = var3 + var6;
      var3 = var3 + this.localizedText[117];
      var3 = var3 + var6;
      var3 = var3 + this.localizedText[118];
      var3 = var3 + var6;
      var3 = var3 + this.localizedText[119];
      this.messageDialog.configureMessageOverlay(var3, canvasWidth / 2, var1, canvasWidth * 90 / 100, var2, 1, 2, false);
   }

   // $VF: renamed from: ag () void
   public void configureContinueMenu() {
      this.setPendingMessage(this.localizedText[14]);
      screenActionCodeA = 0;
      string[] var1 = new string[]{this.startupTextByLanguage[this.gameByteStateB][5], this.startupTextByLanguage[this.gameByteStateB][4]};
      short var2 = 360;
      short var3 = 384;
      this.mainMenu.configureMenuItems(var1, 180, 192, 2, 0, 0, 2, this.gameIntegerStateAN, (sbyte)2, true, false);
      this.mainMenu.setMenuVerticalPosition(384 - this.characterPortraitImages[0].getHeight() - this.mainMenu.getMenuContentHeight() / 2 + 0);
      int var4 = 384 - this.characterPortraitImages[0].getHeight() - 10 - this.mainMenu.getMenuContentHeight();
      int var5 = 384 - this.characterPortraitImages[0].getHeight() - 10 - this.mainMenu.getMenuContentHeight() - var4 / 2;
      this.messageDialog.configureMessageOverlay(this.localizedText[14], 180, var5, 316, var4, 1, 2, true);
      if (this.messageDialog.getVisibleMessageLineCount() < 3) {
         var4 = this.messageDialog.topBorderImage.getHeight() + this.messageDialog.bottomBorderImage.getHeight() + 3 * (this.fontRenderer.getFontBaselineOffset(1) + 2);
         var5 = 384 - this.characterPortraitImages[0].getHeight() - 10 - this.mainMenu.getMenuContentHeight() - var4 / 2;
         this.messageDialog.configureMessageOverlay(this.localizedText[14], 180, var5, 316, var4, 1, 2, true);
      }
   }

   // $VF: renamed from: ah () void
   public void configureMainMenu() {
      this.setPendingMessage("");
      activeMenuLabels = null;
      bool var1 = false;
      int var7 = 4;
      if (advertisingUrl != null) {
         var7++;
      }

      activeMenuLabels = new string[var7];
      sbyte var2 = 0;
      if (advertisingUrl != null) {
         activeMenuLabels[var2] = this.localizedText[49];
         menuOptionIndexE = var2++;
      }

      activeMenuLabels[var2] = this.localizedText[46];
      menuOptionIndexA = var2++;
      if (isMenuActionEnabled) {
         activeMenuLabels[var2] = this.localizedText[47];
         menuOptionIndexB = var2++;
      }

      activeMenuLabels[var2] = this.localizedText[44];
      menuOptionIndexC = var2++;
      activeMenuLabels[var2] = this.localizedText[45];
      menuOptionIndexD = var2++;
      activeMenuLabels[var2] = this.localizedText[48];
      menuOptionIndexF = var2++;
      int var3 = 0;
      if (this.gameLogoImage != null) {
         var3 = this.gameLogoImage.getHeight();
      }

      sbyte var4 = 5;
      int var5 = canvasHeight - this.characterPortraitImages[0].getHeight() - -23 - var3;
      int var6 = canvasHeight - this.characterPortraitImages[0].getHeight() - var5 / 2;

      while (true) {
         this.mainMenu.configureMenuItems(activeMenuLabels, canvasWidth / 2, var6 + 0, var4, 0, 0, 2, this.gameIntegerStateAN, (sbyte)2, true, false);
         if (var4 == 3 || this.mainMenu.getMenuContentHeight() <= var5) {
            return;
         }

         var4 = (sbyte)(var4 - 2);
      }
   }

   // $VF: renamed from: ai () void
   public void configureOptionsMenu() {
      this.setPendingMessage(this.localizedText[12]);
      activeMenuLabels = null;
      sbyte var1 = 0;
      var1 = 4;
      activeMenuLabels = new string[var1];
      sbyte var2 = 0;
      activeMenuLabels[var2] = this.localizedText[43];
      menuOptionIndexS = var2++;
      activeMenuLabels[var2] = this.localizedText[36] + " " + (this.localizedTextVariant > 0 ? this.localizedText[34] : this.localizedText[35]);
      menuOptionIndexT = var2++;
      activeMenuLabels[var2] = this.localizedText[54];
      menuOptionIndexU = var2++;
      activeMenuLabels[var2] = this.localizedText[55];
      menuOptionIndexV = var2++;
      sbyte var3 = 3;
      int var4 = canvasHeight - this.characterPortraitImages[0].getHeight() - -23;
      int var5 = canvasHeight - this.characterPortraitImages[0].getHeight() - var4 / 2;

      while (true) {
         this.mainMenu.configureMenuItems(activeMenuLabels, canvasWidth / 2, var5 + 0, var3, 0, 0, 2, this.gameIntegerStateAN, (sbyte)2, true, false);
         if (var3 == 3 || this.mainMenu.getMenuContentHeight() <= var4) {
            return;
         }

         var3 = (sbyte)(var3 - 2);
      }
   }

   // $VF: renamed from: aj () void
   public void configureMissionMenu() {
      this.setPendingMessage(this.localizedText[20]);
      activeMenuLabels = null;
      sbyte var1 = 0;
      var1 = 3;
      activeMenuLabels = new string[var1];
      sbyte var2 = 0;
      activeMenuLabels[var2] = this.localizedText[52];
      menuOptionIndexI = var2++;
      activeMenuLabels[var2] = this.localizedText[53];
      menuOptionIndexJ = var2++;
      activeMenuLabels[var2] = this.localizedText[51];
      menuOptionIndexH = var2++;
      sbyte var3 = 3;
      sbyte var4 = 2;
      int var5 = 4;
      int var6 = canvasHeight - this.characterPortraitImages[0].getHeight() - this.fontRenderer.getFontBaselineOffset(0) - var5;
      var5 = canvasHeight - this.characterPortraitImages[0].getHeight() - var6 / 2;

      while (true) {
         this.mainMenu.configureMenuItems(activeMenuLabels, canvasWidth / 2, var5 + 0, var3, 0, 0, 2, this.gameIntegerStateAN, (sbyte)2, true, false);
         if (var3 == 3 || this.mainMenu.getMenuContentHeight() <= var6) {
            int var8 = var5 + this.mainMenu.getMenuContentHeight() / 2 + 5;
            int var7 = canvasHeight - this.characterPortraitImages[0].getHeight() - var8;
            if (this.fontRenderer.countWrappedLines(this.localizedText[64], canvasWidth - 4, 1) * this.fontRenderer.getFontBaselineOffset(1) < var7
               && this.fontRenderer.countWrappedLines(this.localizedText[66], canvasWidth - 4, 1) * this.fontRenderer.getFontBaselineOffset(1) < var7
               && this.fontRenderer.countWrappedLines(this.localizedText[65], canvasWidth - 4, 1) * this.fontRenderer.getFontBaselineOffset(1) < var7) {
               this.gameFlagX = true;
               this.gameIntegerStateAO = var8;
            } else {
               this.gameFlagX = false;
            }

            return;
         }

         var3 = (sbyte)(var3 - 2);
      }
   }

   // $VF: renamed from: ak () void
   public void configureLevelSelectionMenu() {
      this.setPendingMessage(this.localizedText[26]);
      int var2 = canvasHeight / 5 * 2;
      int var1 = var2 / 2 + this.fontRenderer.getFontBaselineOffset(1) * 3;
      int var3 = this.gameIntegerStateAL - 1;
      this.messageDialog.configureMessageOverlay(this.localizedText[100 + var3], canvasWidth / 2, var1, canvasWidth * 90 / 100, var2, 1, 2, false);
   }

   // $VF: renamed from: al () void
   public void clearUnlockedLevelFlags() {
      for (int var1 = 0; var1 < this.unlockedLevelFlags.Length; var1++) {
         this.unlockedLevelFlags[var1] = false;
      }

      this.unlockedLevelFlags[1] = true;
   }

   // $VF: renamed from: am () void
   public void configureConfirmationDialog() {
      this.setPendingMessage(this.localizedText[28]);
      string[] var3 = new string[]{this.startupTextByLanguage[this.gameByteStateB][4], this.startupTextByLanguage[this.gameByteStateB][5]};
      this.mainMenu.configureMenuItems(var3, canvasWidth / 2, canvasHeight / 2 + 0, 2, 0, 0, 2, this.gameIntegerStateAN, (sbyte)2, true, false);
      this.mainMenu.setMenuVerticalPosition(canvasHeight - this.characterPortraitImages[0].getHeight() - this.mainMenu.getMenuContentHeight() / 2 + 0);
      int var2 = canvasHeight / 5 * 2;
      int var1 = var2 / 2 + this.fontRenderer.getFontBaselineOffset(1) * 3;
      int var4 = this.gameIntegerStateAL - 1;
      string var5 = this.localizedText[100 + var4] + "\n\n" + this.localizedText[70];
      this.messageDialog.configureMessageOverlay(var5, canvasWidth / 2, var1, canvasWidth * 90 / 100, var2, 1, 2, true);
   }

   // $VF: renamed from: an () void
   public void configureNewGameMenu() {
      this.setPendingMessage(this.localizedText[27]);
      string[] var1 = new string[]{this.localizedText[24]};
      this.mainMenu.configureMenuItems(var1, canvasWidth / 2, canvasHeight / 2 + 0, 1, 0, 0, 2, this.gameIntegerStateAN, (sbyte)2, true, false);
      this.mainMenu.setMenuVerticalPosition((canvasHeight - this.characterPortraitImages[0].getHeight() - this.mainMenu.getMenuContentHeight() / 2 + 0) / 2);
   }

   // $VF: renamed from: ao () void
   public void configureSaveGameMenu() {
      this.setPendingMessage(this.localizedText[29]);
      string[] var1 = new string[]{this.localizedText[24]};
      this.mainMenu.configureMenuItems(var1, canvasWidth / 2, canvasHeight / 2 + 0, 1, 0, 0, 2, this.gameIntegerStateAN, (sbyte)2, true, false);
      this.mainMenu.setMenuVerticalPosition((canvasHeight - this.characterPortraitImages[0].getHeight() - this.mainMenu.getMenuContentHeight() / 2 + 0) / 2);
   }

   // $VF: renamed from: ap () void
   public void configureExitDialog() {
      this.setPendingMessage(this.localizedText[30]);
      string var1 = "";
      int var2 = canvasHeight / 5 * 2;
      int var3 = var2 / 2 + this.fontRenderer.getFontBaselineOffset(1) * 3;
      switch (this.gameByteStateAZ) {
         case 1:
            var1 = var1 + this.localizedText[94] + ": " + this.playerHealth;
            var1 = var1 + "\n";
            var1 = var1 + this.localizedText[96] + ": " + this.playerAmmo;
            var1 = var1 + "\n";
            var1 = var1 + this.localizedText[95] + ": " + this.playerGrenades;
            var1 = var1 + "\n";
            var1 = var1 + this.localizedText[97] + ": " + this.playerCredits;
            var1 = var1 + "\n";
            var1 = var1 + this.localizedText[98] + ": " + this.gameIntegerStateAG;
            var1 = var1 + "\n";
            var1 = var1 + this.localizedText[99] + ": " + this.gameIntegerStateAH;
            break;
         case 2:
            var1 = var1 + this.localizedText[94] + ": " + this.playerHealth;
            var1 = var1 + "\n";
            var1 = var1 + this.localizedText[96] + ": " + this.playerAmmo;
            var1 = var1 + "\n";
            var1 = var1 + this.localizedText[95] + ": " + this.playerGrenades;
            var1 = var1 + "\n";
            var1 = var1 + this.localizedText[97] + ": " + this.playerCredits;
            var1 = var1 + "\n";
            var1 = var1 + this.localizedText[98] + ": " + this.gameIntegerStateAF; break;
      }

      this.messageDialog.configureMessageOverlay(var1, canvasWidth / 2, var3, canvasWidth * 90 / 100, var2, 1, 2, true);
      string[] var4 = new string[]{this.localizedText[24]};
      this.mainMenu.configureMenuItems(var4, canvasWidth / 2, canvasHeight / 2 + 0, 1, 0, 0, 2, this.gameIntegerStateAN, (sbyte)2, true, false);
      this.mainMenu.setMenuVerticalPosition(canvasHeight - this.characterPortraitImages[0].getHeight() - this.mainMenu.getMenuContentHeight() / 2 + 0);
   }

   // $VF: renamed from: aq () void
   public void configureBriefingMenu() {
      this.setPendingMessage(this.localizedText[21]);
      activeMenuLabels = null;
      sbyte var1 = 0;
      var1 = 3;
      activeMenuLabels = new string[var1];
      sbyte var2 = 0;
      activeMenuLabels[var2] = this.localizedText[22];
      menuOptionIndexK = var2++;
      activeMenuLabels[var2] = this.localizedText[23];
      menuOptionIndexL = var2++;
      activeMenuLabels[var2] = this.localizedText[25];
      menuOptionIndexM = var2++;
      sbyte var3 = 3;
      int var4 = canvasHeight - this.characterPortraitImages[0].getHeight() - -23;
      int var5 = canvasHeight - this.characterPortraitImages[0].getHeight() - var4 / 2;

      while (true) {
         this.mainMenu.configureMenuItems(activeMenuLabels, canvasWidth / 2, var5 + 0, var3, 0, 0, 2, this.gameIntegerStateAN, (sbyte)2, true, false);
         if (var3 == 3 || this.mainMenu.getMenuContentHeight() <= var4) {
            return;
         }

         var3 = (sbyte)(var3 - 2);
      }
   }

   // $VF: renamed from: ar () void
   public void configureHelpMenu() {
      this.setPendingMessage(this.localizedText[44]);
      int var1 = 4;
      activeMenuLabels = new string[++var1];
      sbyte var2 = 0;
      activeMenuLabels[var2] = this.localizedText[36] + " " + (this.localizedTextVariant > 0 ? this.localizedText[34] : this.localizedText[35]);
      menuOptionIndexN = var2++;
      activeMenuLabels[var2] = this.localizedText[38];
      menuOptionIndexO = var2++;
      activeMenuLabels[var2] = this.localizedText[40];
      menuOptionIndexP = var2++;
      activeMenuLabels[var2] = this.localizedText[41];
      menuOptionIndexQ = var2++;
      activeMenuLabels[var2] = this.localizedText[37];
      menuOptionIndexR = var2;
      sbyte var3 = 5;
      int var4 = canvasHeight - this.characterPortraitImages[0].getHeight() + -23;
      int var5 = canvasHeight - this.characterPortraitImages[0].getHeight() - var4 / 2;

      while (true) {
         this.mainMenu.configureMenuItems(activeMenuLabels, canvasWidth / 2, var5 + 0, var3, 0, 0, 2, this.gameIntegerStateAN, (sbyte)2, true, true);
         if (var3 == 3 || this.mainMenu.getMenuContentHeight() <= var4) {
            this.isMessageDialogOpen = false;
            return;
         }

         var3 = (sbyte)(var3 - 2);
      }
   }

   // $VF: renamed from: a (byte, byte) void
   public void setCharacterPortraitIndices(sbyte var1, sbyte var2) {
      this.portraitImageIndices[0] = var1;
      this.portraitImageIndices[1] = var2;
   }

   // $VF: renamed from: as () void
   public void closeMessageDialog() {
      if (this.messageDialog != null) {
         this.messageDialog.updateOverlayAnimation();
         this.messageDialog.handleOverlayInput(this.gameIntegerStateB);
      }

      if (this.consumeGameFlag(512)) {
         screenActionCodeB = 4;
         screenActionCodeC = 7;
         this.resetGameSession((sbyte)3, false);
      }
   }

   // $VF: renamed from: at () void
   public void closeMessageAndMenu() {
      if (this.messageDialog != null) {
         this.messageDialog.updateOverlayAnimation();
         this.messageDialog.handleOverlayInput(this.gameIntegerStateB);
      }

      if (this.consumeGameFlag(512)) {
         screenActionCodeB = 4;
         screenActionCodeC = 12;
         this.resetGameSession((sbyte)3, false);
      }
   }

   // $VF: renamed from: au () void
   public void updateMissionCompletion() {
      bool var1 = false;
      if (this.gameFlagY) {
         this.messageDisplayTicks++;
         if (this.messageDisplayTicks >= 50) {
            this.messageDisplayTicks = 0;
            var1 = true;
         }
      } else {
         this.messageDisplayTicks++;
         if (this.messageDisplayTicks >= 50) {
            this.messageDisplayTicks = 0;
            this.gameFlagY = true;
         }
      }

      if (this.gameFlagY) {
         this.capcomLogoImage = GameCanvas.loadImageResource("/gl");
      }

      if (var1) {
         this.capcomLogoImage = null;
         this.gameFlagY = false;
         JSystem.gc();
         this.initializeAudioManager();
         screenActionCodeB = 1;
         screenActionCodeC = 0;
         this.resetGameSession((sbyte)3, false);
      }
   }

   // $VF: renamed from: av () void
   public void clearMainMenu() {
      if (this.mainMenu != null) {
         this.mainMenu.e();
         this.mainMenu.b(this.gameIntegerStateB);
      }

      if (this.mainMenu.b()) {
         
         switch (this.mainMenu.a()) {
            case 0:
               switch (screenActionCodeC) {
                  case 0:
                  case 1:
                     screenActionCodeB = 4;
                     screenActionCodeC = 1;
                     this.resetGameSession((sbyte)3, true);
                     if (this.localizedTextVariant == 0) {
                        this.localizedTextVariant = 1;
                     }

                     this.playMusicTrack((sbyte)1);
                     this.audioCommandSink.setMasterVolume(this.audioFadeLevels[5]);
                     goto label42_brk;
                  case 4:
                     this.stopGameScreen();
                     goto label42_brk;
                  case 6:
                     switch (this.gameByteStateAG) {
                        case 2:
                           this.dispatchAudioEvent((sbyte)2, true);
                           break;
                        case 3:
                           this.dispatchAudioEvent((sbyte)3, true); break;
                     }

                     this.gameByteStateAG = -1;
                     screenActionCodeB = screenActionCodeC;
                     screenActionCodeC = gameModeCode;
                     this.resetGameSession((sbyte)3, false);
                     goto label42_brk;
                  case 18:
                     if (!this.gameFlagAA) {
                        screenActionCodeB = 4;
                        screenActionCodeC = 18;
                        this.hasScreenStarted = false;
                        this.isScreenInitialized = false;
                        this.resetGameSession((sbyte)3, true);
                     } else {
                        this.stopGameScreen();
                     } goto default;
                  default:
                     goto label42_brk;
               } goto case 1;
            case 1:
               switch (screenActionCodeC) {
                  case 0:
                  case 1:
                     screenActionCodeB = 4;
                     screenActionCodeC = 1;
                     this.resetGameSession((sbyte)3, true);
                     this.localizedTextVariant = 0;
                     this.playMusicTrack((sbyte)1);
                     break;
                  default:
                     screenActionCodeB = screenActionCodeC;
                     screenActionCodeC = gameModeCode;
                     this.gameByteStateAG = -1;
                     this.resetGameSession((sbyte)3, false); break;
               } break;
         } label42_brk:;
      }

      if (this.consumeGameFlag(512)) {
         switch (screenActionCodeC) {
            case 0:
            case 1:
               break;
            default:
               screenActionCodeB = screenActionCodeC;
               screenActionCodeC = gameModeCode;
               this.gameByteStateAG = -1;
               this.resetGameSession((sbyte)3, false); break;
         }
      }
   }

   // $VF: renamed from: aw () void
   public void processMenuAction() {
      switch (screenActionCodeA) {
         case 0:
            if (this.isInputEnabled) {
               if (this.mainMenu != null) {
                  this.mainMenu.e();
                  this.mainMenu.b(this.gameIntegerStateB);
               }

               if (this.mainMenu.b()) {
                  this.disposeAudioManager();
                  if (this.mainMenu.a() == menuOptionIndexF) {
                     screenActionCodeB = 7;
                     screenActionCodeC = 4;
                     this.resetGameSession((sbyte)3, false);
                  } else if (this.mainMenu.a() == menuOptionIndexE) {
                     screenActionCodeB = 8;
                     screenActionCodeC = 4;
                     this.resetGameSession((sbyte)3, false);
                  } else if (this.mainMenu.a() == menuOptionIndexD) {
                     screenActionCodeB = 12;
                     screenActionCodeC = 4;
                     this.resetGameSession((sbyte)3, false);
                  } else if (this.mainMenu.a() == menuOptionIndexC) {
                     screenActionCodeB = 6;
                     screenActionCodeC = 4;
                     this.resetGameSession((sbyte)3, false);
                  } else if (this.mainMenu.a() == menuOptionIndexB) {
                     screenActionCodeB = 13;
                     screenActionCodeC = 4;
                     this.resetGameSession((sbyte)3, false);
                  } else if (this.mainMenu.a() == menuOptionIndexA) {
                     screenActionCodeB = 16;
                     screenActionCodeC = 4;
                     this.resetGameSession((sbyte)3, false);
                  }
               }
            } else {
               if (this.consumeGameFlag(8)) {
                  this.gameByteStateAI--;
                  if (this.gameByteStateAI == menuOptionIndexB && !isMenuActionEnabled) {
                     this.gameByteStateAI--;
                  } else if (this.gameByteStateAI == menuOptionIndexE && advertisingUrl == null) {
                     this.gameByteStateAI--;
                  }

                  if (this.gameByteStateAI < 0) {
                     this.gameByteStateAI = (sbyte)(this.activeMenuOptions.Length - 1);
                  }
               }

               if (this.consumeGameFlag(16)) {
                  this.gameByteStateAI++;
                  if (this.gameByteStateAI == menuOptionIndexB && !isMenuActionEnabled) {
                     this.gameByteStateAI++;
                  } else if (this.gameByteStateAI == menuOptionIndexE && advertisingUrl == null) {
                     this.gameByteStateAI++;
                  }

                  if (this.gameByteStateAI >= this.activeMenuOptions.Length) {
                     this.gameByteStateAI = 0;
                  }
               }

               if (this.gameFlagC) {
                  this.gameFlagC = false;
               }

               if (this.consumeGameFlag(256) || this.consumeGameFlag(32)) {
                  this.disposeAudioManager();
                  if (this.gameByteStateAI == menuOptionIndexA) {
                     screenActionCodeB = 5;
                     screenActionCodeC = 4;
                     this.resetGameSession((sbyte)3, false);
                  } else if (this.gameByteStateAI == menuOptionIndexB) {
                     screenActionCodeB = 13;
                     screenActionCodeC = 4;
                     this.resetGameSession((sbyte)3, false);
                  } else if (this.gameByteStateAI == menuOptionIndexC) {
                     screenActionCodeB = 6;
                     screenActionCodeC = 4;
                     this.resetGameSession((sbyte)3, false);
                  } else if (this.gameByteStateAI == menuOptionIndexD) {
                     screenActionCodeB = 12;
                     screenActionCodeC = 4;
                     this.resetGameSession((sbyte)3, false);
                  } else if (this.gameByteStateAI == menuOptionIndexE) {
                     screenActionCodeB = 8;
                     screenActionCodeC = 4;
                     this.resetGameSession((sbyte)3, false);
                  } else if (this.gameByteStateAI == menuOptionIndexF) {
                     screenActionCodeB = 7;
                     screenActionCodeC = 4;
                     this.resetGameSession((sbyte)3, false);
                  }
               }
            }

            if (this.consumeGameFlag(512)) {
               this.disposeAudioManager();
               this.dialogMessage = this.localizedText[0];
               this.statusMessage = this.localizedText[4];
               screenActionCodeB = 10;
               screenActionCodeC = 4;
               this.resetGameSession((sbyte)3, false);
            }
            break;
         case 1:
            this.messageDialog.updateOverlayAnimation();
            this.messageDialog.handleOverlayInput(this.gameIntegerStateB);
            if (this.consumeGameFlag(256) || this.consumeGameFlag(32)) {
               screenActionCodeA = 0;
               this.setCharacterPortraitIndices((sbyte)0, (sbyte)4);
            } break;
      }
   }

   // $VF: renamed from: ax () void
   public void resetMenuState() {
      if (this.mainMenu != null) {
         this.mainMenu.e();
         this.mainMenu.b(this.gameIntegerStateB);
      }

      if (this.mainMenu.b()) {
         this.gameLogoImage = null;
         if (this.mainMenu.a() == menuOptionIndexH) {
            screenActionCodeB = 17;
            screenActionCodeC = 16;
            this.gameByteStateAZ = 0;
            this.clearUnlockedLevelFlags();
            this.playSoundEffect((sbyte)3);
            this.resetGameSession((sbyte)3, false);
         } else if (this.mainMenu.a() == menuOptionIndexI) {
            screenActionCodeB = 5;
            screenActionCodeC = 16;
            this.gameByteStateAZ = 1;
            this.initializeLevelTransition();
            this.playSoundEffect((sbyte)2);
            this.resetGameSession((sbyte)3, false);
         } else if (this.mainMenu.a() == menuOptionIndexJ) {
            screenActionCodeB = 5;
            screenActionCodeC = 16;
            this.gameByteStateAZ = 2;
            this.initializeLevelTransition();
            this.resetGameSession((sbyte)3, false);
         }
      }

      if (this.consumeGameFlag(512)) {
         screenActionCodeB = 4;
         screenActionCodeC = 16;
         this.resetGameSession((sbyte)3, false);
      }
   }

   // $VF: renamed from: ay () void
   public void configureDialogChoiceLayout() {
      int var2 = canvasHeight / 5 * 2;
      int var1 = var2 / 2 + this.fontRenderer.getFontBaselineOffset(1) * 3;
      this.messageDialog.updateOverlayAnimation();
      this.messageDialog.handleOverlayInput(this.gameIntegerStateB);
      if (this.consumeGameFlag(2) || this.consumeGameFlag(32768)) {
         this.gameIntegerStateAL--;
         if (this.gameIntegerStateAL < 1) {
            this.gameIntegerStateAL = 1;
         }

         int var4 = this.gameIntegerStateAL - 1;
         this.messageDialog.configureMessageOverlay(this.localizedText[100 + var4], canvasWidth / 2, var1, canvasWidth * 90 / 100, var2, 1, 2, false);
      } else if (this.consumeGameFlag(4) || this.consumeGameFlag(8192)) {
         this.gameIntegerStateAL++;
         if (this.gameIntegerStateAL <= this.gameByteStateBJ && !this.unlockedLevelFlags[this.gameIntegerStateAL]) {
            this.gameIntegerStateAL--;
         }

         if (this.gameIntegerStateAL > this.gameByteStateBJ) {
            this.gameIntegerStateAL = this.gameByteStateBJ;
         }

         int var3 = this.gameIntegerStateAL - 1;
         this.messageDialog.configureMessageOverlay(this.localizedText[100 + var3], canvasWidth / 2, var1, canvasWidth * 90 / 100, var2, 1, 2, false);
      } else if (this.consumeGameFlag(256) || this.consumeGameFlag(32) || this.consumeGameFlag(16384)) {
         this.initializeLevelTransition();
         screenActionCodeB = 5;
         screenActionCodeC = 17;
         this.gameByteStateAZ = 0;
         this.resetGameSession((sbyte)3, false);
      } else if (this.consumeGameFlag(512)) {
         screenActionCodeB = 16;
         screenActionCodeC = 17;
         this.resetGameSession((sbyte)3, false);
      }
   }

   // $VF: renamed from: az () void
   public void configureSoundOptionsMenu() {
      if (this.mainMenu != null) {
         this.mainMenu.e();
         this.mainMenu.b(this.gameIntegerStateB);
      }

      if (this.messageDialog != null) {
         this.messageDialog.updateOverlayAnimation();
         this.messageDialog.handleOverlayInput(this.gameIntegerStateB);
      }

      if (this.mainMenu.b()) {
         switch (this.mainMenu.a()) {
            case 0:
               screenActionCodeB = 5;
               screenActionCodeC = 20;
               this.gameIntegerStateG = 384;
               this.resetGameSession((sbyte)3, false);
               break;
            case 1:
               screenActionCodeB = 4;
               screenActionCodeC = 20;
               this.releaseResourcesForScreenAction();
               this.resetGameSession((sbyte)3, false); break;
         }
      }
   }

   // $VF: renamed from: aA () void
   public void configureLanguageMenu() {
      if (this.mainMenu != null) {
         this.mainMenu.e();
         this.mainMenu.b(this.gameIntegerStateB);
      }

      if (this.mainMenu.b()) {
         switch (this.mainMenu.a()) {
            case 0:
               screenActionCodeB = 17;
               screenActionCodeC = 19;
               this.completeGameTransition();
               this.playMusicTrack((sbyte)3);
               this.resetGameSession((sbyte)3, false); break;
         }
      }
   }

   // $VF: renamed from: aB () void
   public void configureControlOptionsMenu() {
      if (this.mainMenu != null) {
         this.mainMenu.e();
         this.mainMenu.b(this.gameIntegerStateB);
      }

      if (this.messageDialog != null) {
         this.messageDialog.updateOverlayAnimation();
         this.messageDialog.handleOverlayInput(this.gameIntegerStateB);
      }

      if (this.mainMenu.b()) {
         switch (this.mainMenu.a()) {
            case 0:
               screenActionCodeB = 4;
               screenActionCodeC = 21;
               this.releaseResourcesForScreenAction();
               this.resetGameSession((sbyte)3, false); break;
         }
      }
   }

   // $VF: renamed from: aC () void
   public void configureExitOptionsMenu() {
      if (this.mainMenu != null) {
         this.mainMenu.e();
         this.mainMenu.b(this.gameIntegerStateB);
      }

      if (this.messageDialog != null) {
         this.messageDialog.updateOverlayAnimation();
         this.messageDialog.handleOverlayInput(this.gameIntegerStateB);
      }

      if (this.mainMenu.b()) {
         switch (this.mainMenu.a()) {
            case 0:
               screenActionCodeB = 4;
               screenActionCodeC = 22;
               this.releaseResourcesForScreenAction();
               this.gameIntegerStateAG = 0;
               if (this.gameFlagZ) {
                  this.dispatchAudioEvent((sbyte)2, true);
                  this.gameFlagZ = false;
               }

               this.resetGameSession((sbyte)3, false); break;
         }
      }
   }

   // $VF: renamed from: aD () void
   public void configureRestartConfirmation() {
      if (this.mainMenu != null) {
         this.mainMenu.e();
         this.mainMenu.b(this.gameIntegerStateB);
      }

      if (this.mainMenu.b()) {
         if (this.mainMenu.a() == menuOptionIndexS) {
            if (this.isMessageDialogOpen) {
               this.playMusicTrack((sbyte)1);
               this.isMessageDialogOpen = false;
            }

            gameModeCode = 5;
            screenActionCodeC = 18;
            this.resetScreenInitialization();
         } else if (this.mainMenu.a() == menuOptionIndexT) {
            this.localizedTextVariant++;
            this.cycleLocalizationVariant(menuOptionIndexT);
         } else if (this.mainMenu.a() == menuOptionIndexU) {
            this.dialogMessage = this.localizedText[3];
            this.statusMessage = this.localizedText[4];
            screenActionCodeB = 10;
            screenActionCodeC = 18;
            this.gameByteStateAH = 1;
            this.gameFlagAA = false;
            this.resetGameSession((sbyte)3, false);
         } else if (this.mainMenu.a() == menuOptionIndexV) {
            this.dialogMessage = this.localizedText[0];
            this.statusMessage = this.localizedText[4];
            screenActionCodeB = 10;
            screenActionCodeC = 18;
            this.gameByteStateAH = 1;
            this.gameFlagAA = true;
            this.resetGameSession((sbyte)3, false);
         }
      }

      if (this.consumeGameFlag(2) || this.consumeGameFlag(32768)) {
         if (this.mainMenu.a() == menuOptionIndexT) {
            this.localizedTextVariant--;
            this.cycleLocalizationVariant(menuOptionIndexT);
         }
      } else if ((this.consumeGameFlag(4) || this.consumeGameFlag(8192)) && this.mainMenu.a() == menuOptionIndexT) {
         this.localizedTextVariant++;
         this.cycleLocalizationVariant(menuOptionIndexT);
      }

      if (this.consumeGameFlag(512)) {
         if (this.isMessageDialogOpen) {
            this.playMusicTrack((sbyte)1);
            this.isMessageDialogOpen = false;
         }

         gameModeCode = 5;
         screenActionCodeC = 18;
         this.resetScreenInitialization();
      }
   }

   // $VF: renamed from: aE () void
   public void completeGameTransition() {
      if (this.gameIntegerStateAL == this.gameByteStateBJ) {
         screenActionCodeB = 21;
         screenActionCodeC = 19;
         this.resetGameSession((sbyte)3, false);
      } else {
         this.gameIntegerStateAL++;
         if (this.gameIntegerStateAL > this.gameByteStateBJ) {
            this.gameIntegerStateAL = this.gameByteStateBJ;
         }

         if (this.gameIntegerStateAL <= this.gameByteStateBJ) {
            this.unlockedLevelFlags[this.gameIntegerStateAL] = true;
         }
      }
   }

   // $VF: renamed from: aF () void
   public void configureGameOverScreen() {
      if (this.mainMenu != null) {
         this.mainMenu.e();
         this.mainMenu.b(this.gameIntegerStateB);
      }

      if (this.mainMenu.b()) {
         if (this.mainMenu.a() == menuOptionIndexN) {
            this.localizedTextVariant++;
            this.cycleLocalizationVariant(menuOptionIndexN);
         } else if (this.mainMenu.a() == menuOptionIndexP) {
            this.dialogMessage = this.localizedText[1];
            this.statusMessage = this.localizedText[7];
            screenActionCodeB = 10;
            screenActionCodeC = 6;
            this.gameByteStateAH = 1;
            this.gameByteStateAG = 2;
            this.resetGameSession((sbyte)3, false);
         } else if (this.mainMenu.a() == menuOptionIndexQ) {
            this.dialogMessage = this.localizedText[1];
            this.statusMessage = this.localizedText[8];
            screenActionCodeB = 10;
            screenActionCodeC = 6;
            this.gameByteStateAH = 1;
            this.gameByteStateAG = 3;
            this.resetGameSession((sbyte)3, false);
         } else if (this.mainMenu.a() == menuOptionIndexR) {
            if (this.isMessageDialogOpen) {
               this.playMusicTrack((sbyte)1);
               this.isMessageDialogOpen = false;
            }

            screenActionCodeB = 4;
            screenActionCodeC = 6;
            this.resetGameSession((sbyte)3, false);
         } else if (this.mainMenu.a() == menuOptionIndexO) {
            screenActionCodeB = 1;
            screenActionCodeC = gameModeCode;
            this.resetGameSession((sbyte)3, false);
         }
      }

      if (this.consumeGameFlag(2) || this.consumeGameFlag(32768)) {
         if (this.mainMenu.a() == menuOptionIndexN) {
            this.localizedTextVariant--;
            this.cycleLocalizationVariant(menuOptionIndexN);
         }
      } else if ((this.consumeGameFlag(4) || this.consumeGameFlag(8192)) && this.mainMenu.a() == menuOptionIndexN) {
         this.localizedTextVariant++;
         this.cycleLocalizationVariant(menuOptionIndexN);
      }

      if (this.consumeGameFlag(512)) {
         if (this.isMessageDialogOpen) {
            this.playMusicTrack((sbyte)1);
            this.isMessageDialogOpen = false;
         }

         screenActionCodeB = 4;
         screenActionCodeC = 6;
         this.resetGameSession((sbyte)3, false);
      }
   }

   // $VF: renamed from: aG () void
   public void processScreenAction() {
      switch (screenActionCodeA) {
         case 0:
            if (this.mainMenu != null) {
               this.mainMenu.e();
               this.mainMenu.b(this.gameIntegerStateB);
            }

            if (this.mainMenu.b()) {
               switch (this.mainMenu.a()) {
                  case 0:
                     screenActionCodeB = 4;
                     screenActionCodeC = 8;
                     this.resetGameSession((sbyte)3, false);
                     break;
                  case 1:
                     bool var1 = GameCanvas.requestPlatformUrl(advertisingUrl);
                     short var2 = 360;
                     short var3 = 384;
                     if (var1) {
                        this.stopGameScreen();
                     } else {
                        this.messageDialog.configureMessageOverlay(this.localizedText[63], 180, 192, 324, 119, 1, 2, false);
                     }

                     this.setCharacterPortraitIndices((sbyte)-1, (sbyte)2);
                     screenActionCodeA = 1; break;
               }
            } goto default;
         default:
            if (this.consumeGameFlag(512)) {
               screenActionCodeB = 4;
               screenActionCodeC = 8;
               this.resetGameSession((sbyte)3, false);
               this.gameIntegerStateA = 0;
               this.gameIntegerStateB = 0;
            } break;
      }
   }

   // $VF: renamed from: aH () void
   public void configureCreditsScreen() {
      if (this.mainMenu != null) {
         this.mainMenu.e();
         this.mainMenu.b(this.gameIntegerStateB);
         if (this.mainMenu.a() != this.gameByteStateD) {
            this.updateTickCount = 0;
            this.setPendingMessage(this.startupTextByLanguage[this.mainMenu.a()][1]);
            this.gameByteStateB = this.mainMenu.a();
         }

         this.gameByteStateD = this.mainMenu.a();
      }

      if (this.mainMenu.b()) {
         this.gameByteStateB = this.mainMenu.a();
         this.playMusicTrack((sbyte)0);
         this.localizedText = new string[129];
         string var1 = "";
         if (this.gameByteStateB == 0) {
            var1 = "texten";
         } else if (this.gameByteStateB == 1) {
            var1 = "textes";
         } else if (this.gameByteStateB == 2) {
            var1 = "textptbr";
         }

         this.gameCanvas.readLocalizedResourceValue(this.localizedText, var1, 5, this.gameByteStateB, 129, true, -1);
         switch (screenActionCodeC) {
            case 0:
               this.statusMessage = this.localizedText[15];
               this.dialogMessage = this.localizedText[2];
               screenActionCodeB = 10;
               screenActionCodeC = 1;
               this.resetGameSession((sbyte)3, false);
               break;
            default:
               screenActionCodeB = screenActionCodeC;
               screenActionCodeC = gameModeCode;
               this.resetGameSession((sbyte)3, false); break;
         }
      }

      if (this.consumeGameFlag(512)) {
         this.gameByteStateB = this.gameByteStateC;
         switch (screenActionCodeC) {
            case 0:
               this.stopGameScreen();
               break;
            default:
               screenActionCodeB = screenActionCodeC;
               screenActionCodeC = gameModeCode;
               this.resetGameSession((sbyte)3, false); break;
         }
      }
   }

   // $VF: renamed from: a (byte) void
   public void cycleLocalizationVariant(sbyte var1) {
      if (this.localizedTextVariant > 1) {
         this.localizedTextVariant = 0;
      }

      if (this.localizedTextVariant < 0) {
         this.localizedTextVariant = 1;
      }

      this.audioCommandSink.setMasterVolume(this.audioFadeLevels[5]);
      this.mainMenu.setMenuItemText(this.localizedText[36] + " " + (this.localizedTextVariant > 0 ? this.localizedText[34] : this.localizedText[35]), var1);
      this.isMessageDialogOpen = true;
      if (this.localizedTextVariant > 0) {
         this.playAudioCue(1, 1);
      }
   }

   // $VF: renamed from: aI () void
   public void updateGameModeState() {
      if (this.gameIntegerStateG == 138) {
         switch (this.gameByteStateAJ) {
            case 0:
               if (this.mainMenu != null) {
                  this.mainMenu.e();
               }
               break;
            case 1:
               this.gameByteStateBG = (sbyte)(this.countSelectedInventoryItems() - 1);
               this.rebuildInventoryItemIndices(); break;
         }
      }

      this.updateCharacterEffects();
      if ((this.gameIntegerStateG & 256) != 0) {
         this.playItemCue();
         this.buildCollisionMap();
         this.updateWorldObjects();
         this.loadActorSprites();
         this.initializeActorStates();
         if (this.gameByteStateAZ == 0) {
            this.processGameInput();
            int var1 = this.getInventoryActionResult();
            if (var1 == 1) {
               this.disposeAudioManager();
               this.sleepForMilliseconds(500L);
               screenActionCodeB = 19;
               screenActionCodeC = 5;
               this.resetGameSession((sbyte)3, false);
            } else if (var1 == 0) {
               this.disposeAudioManager();
               this.sleepForMilliseconds(500L);
               screenActionCodeB = 20;
               screenActionCodeC = 5;
               this.resetGameSession((sbyte)3, false);
            }
         }
      }

      this.gameFlagF = false;
      this.setActiveActor(this.activeActorState, false);
   }

   // $VF: renamed from: aJ () void
   public void processGameInput() {
      if (this.gameByteStateAZ == 0) {
         if (this.isReleasedInputFlagSet(1)) {
            if (this.gameShortValueE > 0) {
               this.sessionStartTimeMs = JSystem.currentTimeMillis();
               this.sessionDurationMinutes = (int)(this.sessionStartTimeMs / 1000L / 60L);
               this.sessionDurationSeconds = (int)(this.sessionStartTimeMs / 1000L - (long)(this.sessionDurationMinutes * 60));
               this.previousSessionSecond = this.sessionDurationSeconds - this.previousSessionSecond;
               if (this.previousSessionSecond == 1) {
                  this.gameLongValueE -= 1000L;
               } else {
                  this.previousSessionSecond = this.sessionDurationSeconds;
               }
            } else {
               this.gameLongValueE = (long)this.levelEventDefinitions[this.gameIntegerStateAL][7];
               this.gameLongValueF = this.gameClockTimeMs;
               this.gameLongValueG = 0L;
            }
         } else if (this.gameShortValueE > 0) {
            this.gameLongValueE = this.gameClockTimeMs - this.gameLongValueF - this.gameLongValueG;
         } else {
            this.gameLongValueE = 0L;
            this.gameLongValueF = this.gameClockTimeMs;
            this.gameLongValueG = 0L;
         }

         if (this.isReleasedInputFlagSet(8)) {
            if (this.gameLongValueE < this.gameLongValueH + (long)(this.timerIntervalMsA / 2)) {
               this.gameFlagR = true;
            } else {
               this.gameFlagR = false;
            }

            if (!this.gameFlagR) {
               this.updateActorAnimation(this.activeCharacterState.characterAnimationObjectReferenceA, -1);
               this.gameFlagR = true;
               this.gameLongValueH = this.gameLongValueE;
            }
         }

         if (this.isReleasedInputFlagSet(64)) {
            if (this.gameShortValueE > 0) {
               if (this.gameFlagS && !this.gameFlagT) {
                  if (this.updateTickCount % 12 == 0 && nextRandomBelow(100) < 20) {
                     this.gameFlagS = false;
                     this.gameLongValueI = this.gameLongValueE;
                  }
               } else if (this.gameLongValueE < this.gameLongValueI - 2000L) {
                  this.gameFlagT = true;
                  if (this.updateTickCount % 3 == 0) {
                     this.gameFlagS = true;
                  } else {
                     this.gameFlagS = false;
                  }

                  if (this.gameLongValueE < this.gameLongValueI - 2500L) {
                     this.gameFlagT = false;
                  }
               }
            } else {
               this.gameLongValueI = this.gameLongValueE;
            }
         }

         if (this.gameLongValueE < 0L) {
            this.gameLongValueE = 0L;
         }
      }
   }

   // $VF: renamed from: aK () int
   public int getInventoryActionResult() {
      if (this.isReleasedInputFlagSet(1) && this.gameLongValueE <= 0L) {
         return this.isReleasedInputFlagSet(2) ? 1 : 0;
      } else {
         if (this.isReleasedInputFlagSet(4) && this.activeCharacterState.characterAnimationObjectReferenceA.actionCounter < this.activeCharacterState.characterAnimationObjectReferenceA.actionCounterLimit) {
            this.sessionTimerTicks++;
            if (this.sessionTimerTicks >= 8) {
               this.sessionTimerTicks = 0;
               return 0;
            }
         }

         if (this.isReleasedInputFlagSet(16)) {
            if (this.gameByteStateBK >= 3) {
               this.gameFlagU = true;
               this.gameFlagV = true;
            }

            if (this.gameFlagU && this.gameIntegerStateAF >= 3) {
               this.gameFlagU = false;
               this.gameFlagV = false;
               return 1;
            }

            if (this.activeCharacterState.characterAnimationByteStateArrayA[4] == 0 && !this.gameFlagU) {
               this.sessionTimerTicks++;
               if (this.sessionTimerTicks >= 8 && this.isCharacterActionComplete()) {
                  this.sessionTimerTicks = 0;
                  return 0;
               }
            }

            this.gameByteStateBK = 0;
         }

         if (this.isReleasedInputFlagSet(128) && this.gameIntegerStateAF >= this.levelEventDefinitions[this.gameIntegerStateAL][7]) {
            return 1;
         } else {
            if (this.isReleasedInputFlagSet(32) && this.activeCharacterState.characterAnimationByteStateArrayA[4] == 0 && !this.isPressedInputFlagSet(1)) {
               this.sessionTimerTicks++;
               if (this.sessionTimerTicks >= 8 && this.isCharacterActionComplete()) {
                  this.sessionTimerTicks = 0;
                  return 0;
               }
            }

            return -1;
         }
      }
   }

   // $VF: renamed from: aL () void
   public void playItemCue() {
      this.updateCharacterAnimation();
      sbyte var1 = 0;
      if (this.gameByteStateAZ == 1 && this.gameByteStateBE == this.gameByteStateBD) {
         var1 = this.gameByteStateBF;
      }

      if (this.gameShortValueE < this.animationDefinitions[this.gameByteStateBE][0] + var1 || this.gameByteStateAZ != 1) {
         if (this.gameShortValueE < this.levelEventDefinitions[this.gameIntegerStateAL][2] || this.gameByteStateAZ != 0) {
            if (this.gameLongValueD + (long)this.timerIntervalMsA - (long)this.timerElapsedOffset < this.gameClockTimeMs) {
               int var4 = 0;
               sbyte var5 = 0;

               for (int var2 = 0; var2 < this.gameByteStateAQ; var2++) {
                  for (int var3 = 0; var3 < this.gameByteStateAR; var3++) {
                     int var6 = this.tileToScreenX(var2, var3) - this.cameraX;
                     int var7 = this.tileToScreenY(var2, var3) - this.cameraY;
                     if (!this.rectanglesOverlap(var6, var7, 36, 18, 0, 0, canvasWidth, canvasHeight) && (this.collisionMap[var2][var3] & 240) == 0) {
                        collisionCoordinates[var4][0] = var2;
                        collisionCoordinates[var4][1] = var3;
                        var4++;
                     }
                  }
               }

               for (int var10 = 0;
                  var10 < this.gameByteStateBB
                     && this.gameIntegerStateAM < 12
                     && (this.gameShortValueE < this.animationDefinitions[this.gameByteStateBE][0] + var1 || this.gameByteStateAZ != 1)
                     && (this.gameShortValueE < this.levelEventDefinitions[this.gameIntegerStateAL][2] || this.gameByteStateAZ != 0);
                  var10++
               ) {
                  short var8;
                  do {
                     var8 = (short)nextRandomBelow(var4);
                     if (!this.hasCollectedItem(var8)) {
                        this.gameShortValueArrayA[var10] = var8;
                        break;
                     }
                  } while (++var5 < this.gameByteStateAK);

                  if (var5 >= this.gameByteStateAK) {
                     break;
                  }

                  sbyte var9;
                  if ((this.animationDefinitions[this.gameByteStateBE][5] != 0 || this.gameByteStateAZ != 1) && (this.levelEventDefinitions[this.gameIntegerStateAL][1] != 0 || this.gameByteStateAZ != 0)) {
                     if ((this.animationDefinitions[this.gameByteStateBE][5] != 2 || this.gameByteStateAZ != 1) && (this.levelEventDefinitions[this.gameIntegerStateAL][1] != 2 || this.gameByteStateAZ != 0)) {
                        if ((this.animationDefinitions[this.gameByteStateBE][5] != 1 || this.gameByteStateAZ != 1) && (this.levelEventDefinitions[this.gameIntegerStateAL][1] != 1 || this.gameByteStateAZ != 0)) {
                           var9 = 2;
                        } else {
                           var9 = 8;
                        }
                     } else {
                        var9 = 6;
                     }
                  } else {
                     var9 = 2;
                  }

                  this.spawnActor(var9, collisionCoordinates[var8][0], collisionCoordinates[var8][1], 7);
                  this.gameShortValueE++;
                  this.gameIntegerStateAM++;
               }

               this.updatePlayerAction();
               this.clearCollectedItemFlags();
               this.gameLongValueD = this.gameClockTimeMs;
            }
         }
      }
   }

   // $VF: renamed from: a (short) boolean
   public bool hasCollectedItem(short var1) {
      for (int var2 = 0; var2 < this.gameShortValueArrayA.Length; var2++) {
         if (var1 == this.gameShortValueArrayA[var2]) {
            return true;
         }
      }

      return false;
   }

   // $VF: renamed from: aM () void
   public void clearCollectedItemFlags() {
      for (int var1 = 0; var1 < this.gameShortValueArrayA.Length; var1++) {
         this.gameShortValueArrayA[var1] = -1;
      }
   }

   // $VF: renamed from: aN () void
   public void updateCharacterAnimation() {
      if (this.gameByteStateAZ == 2) {
         if (this.gameIntegerStateAF < this.animationTimingThresholds[0]) {
            this.timerElapsedOffset = 0;
            this.gameByteStateBA = 1;
            this.gameByteStateBB = 1;
         } else if (this.gameIntegerStateAF < this.animationTimingThresholds[1]) {
            this.timerElapsedOffset = 1;
            this.gameByteStateBA = 1;
            this.gameByteStateBB = 1;
         } else if (this.gameIntegerStateAF < this.animationTimingThresholds[2]) {
            this.timerElapsedOffset = 1;
            this.gameByteStateBA = 2;
            this.gameByteStateBB = 2;
         } else if (this.gameIntegerStateAF < this.animationTimingThresholds[3]) {
            this.timerElapsedOffset = 2;
            this.gameByteStateBA = 2;
            this.gameByteStateBB = 2;
         } else {
            this.timerElapsedOffset = 1;
            this.gameByteStateBA = 3;
            this.gameByteStateBB = 3;
         }
      } else if (this.gameByteStateAZ == 1) {
         this.timerElapsedOffset = this.animationDefinitions[this.gameByteStateBE][3];
         this.gameByteStateBA = (sbyte)this.animationDefinitions[this.gameByteStateBE][2];
         this.gameByteStateBB = (sbyte)this.animationDefinitions[this.gameByteStateBE][1];
      } else if (this.gameByteStateAZ == 0) {
         this.timerElapsedOffset = 0;
         this.gameByteStateBA = (sbyte)this.levelEventDefinitions[this.gameIntegerStateAL][5];
         this.gameByteStateBB = (sbyte)this.levelEventDefinitions[this.gameIntegerStateAL][3];
      }
   }

   // $VF: renamed from: a (boolean) void
   public void resetActiveActors(bool var1) {
      for (int var2 = 3; var2 < 24; var2++) {
         this.actorStates[var2].isActive = false;
         this.actorStates[var2].actorRuntimeFlagF = true;
      }

      this.gameIntegerStateAM = 0;
      this.gameShortValueE = 0;
      this.gameIntegerStateAF = 0;
      this.gameLongValueD = this.gameClockTimeMs;
      if (var1) {
         this.spawnActor(1, 8, 11, 3);
      }

      this.setPlayerAction(this.activeCharacterState.characterAnimationByteStateD);
   }

   // $VF: renamed from: F () void
   public void loadActorSprites() {
      if (!this.isScreenInitialized) {
         for (int var2 = 0; var2 < 24; var2++) {
            if (this.actorStates[var2].isActive
               && this.actorStates[var2].tileX < this.gameByteStateAQ
               && this.actorStates[var2].tileY < this.gameByteStateAR
               && (this.currentTileType == this.levelTileTypes[this.actorStates[var2].tileX][this.actorStates[var2].tileY] || this.isActorActionAllowed(this.actorStates[var2]))) {
               ActorRuntimeState var1 = this.actorStates[var2];
               sbyte var4 = var1.movementDirection;
               if (SpriteAnimationFrameTable.characterShadowGeometry[var1.animationSetIndex][var1.animationFrameIndex][2] != 0) {
                  if (var1.animationFrameIndex == 2 || var1.animationFrameIndex == 14) {
                     if (var4 == 1) {
                        var4 = 5;
                     } else if (var4 == 7) {
                        var4 = 3;
                     } else if (var4 == 5) {
                        var4 = 1;
                     } else if (var4 == 3) {
                        var4 = 7;
                     }
                  }

                  if (var1.actorRuntimeFlagB) {
                     if (!this.isTilePassable(var1.tileX, var1.tileY, var4, (this.gameIntegerStateG & 512) > 0)) {
                        var1.previousAnimationFrameIndex = var1.animationFrameIndex;
                        this.drawActorShadow(var1, 0);
                        continue;
                     }

                     var1.previousAnimationFrameIndex = -1;
                  }

                  if (var1.currentShadowDepth == SpriteAnimationFrameTable.characterShadowGeometry[var1.animationSetIndex][var1.animationFrameIndex][2] && var1.currentShadowDepth != var1.previousShadowDepth) {
                     int var5 = this.resolveCollision(var2, var1.tileX, var1.tileY, var1.movementDirection, false);
                     if (var5 != -1) {
                        if (var1.animationSetIndex != 11 && var1.animationSetIndex != 8) {
                           this.drawActorShadow(var1, 0);
                        } else {
                           this.setActorAnimationState(var1, var4);
                        }
                     } else if (var1.animationSetIndex != 2
                        && var1.animationSetIndex != 4
                        && var1.animationSetIndex != 6
                        && var1.animationSetIndex != 0
                        && var1.animationSetIndex != 1
                        && var1.animationSetIndex != 3) {
                        this.setActorAnimationState(var1, var4);
                     } else {
                        var5 = this.resolveCollision(var2, var1.tileX, var1.tileY, var1.movementDirection, true);
                        if (var5 != -1) {
                           this.drawActorShadow(var1, 0);
                        } else {
                           this.setActorAnimationState(var1, var4);
                        }
                     }

                     if ((var1.animationSetIndex == 0 || var1.animationSetIndex == 1)
                        && this.currentTileType != this.levelTileTypes[this.activeCharacterState.characterAnimationObjectReferenceA.tileX][this.activeCharacterState.characterAnimationObjectReferenceA.tileY]) {
                        this.initializeLevelState();
                     }
                  }
               } else if ((var1.targetTileX != -1 || var1.targetTileY != -1) && var1.animationFrameIndex != 3 && var1.previousAnimationFrameIndex != -1) {
                  if (this.isTilePassable(var1.tileX, var1.tileY, var4, false)) {
                     this.drawActorShadow(var1, var1.previousAnimationFrameIndex);
                     var1.previousAnimationFrameIndex = -1;
                  }
               } else if ((var1.targetTileX != -1 || var1.targetTileY != -1) && var1.animationFrameIndex == 0) {
                  this.drawActorShadow(var1, 1);
               }

               if (var1.currentShadowDepth != var1.previousShadowDepth) {
                  switch (var1.animationSetIndex) {
                     case 0:
                     case 1:
                        if (var1.animationFrameIndex == 7 && var1.currentShadowDepth == 1) {
                        }
                        break;
                     case 2:
                     case 4:
                        if (var1.animationFrameIndex == 5
                           && (var1.currentShadowDepth == 4 || var1.currentShadowDepth == 3)
                           && (
                              this.isActorAdjacentAndFacingTarget(var1, this.activeCharacterState.characterAnimationObjectReferenceA.tileX, this.activeCharacterState.characterAnimationObjectReferenceA.tileY)
                                 || var1.tileX == this.activeCharacterState.characterAnimationObjectReferenceA.tileX && var1.tileY == this.activeCharacterState.characterAnimationObjectReferenceA.tileY
                           )) {
                           this.createWorldObject(0, this.activeCharacterState.characterAnimationObjectReferenceA.tileX, this.activeCharacterState.characterAnimationObjectReferenceA.tileY, 18, -16);
                           if (!this.gameFlagV) {
                              this.updateActorAnimation(this.activeCharacterState.characterAnimationObjectReferenceA, -2);
                           }
                        } goto case 3;
                     case 3:
                     case 5:
                     case 7:
                     default:
                        break;
                     case 6:
                        if (var1.animationFrameIndex == 5
                           && (var1.currentShadowDepth == 2 || var1.currentShadowDepth == 3)
                           && (
                              this.isActorAdjacentAndFacingTarget(var1, this.activeCharacterState.characterAnimationObjectReferenceA.tileX, this.activeCharacterState.characterAnimationObjectReferenceA.tileY)
                                 || var1.tileX == this.activeCharacterState.characterAnimationObjectReferenceA.tileX && var1.tileY == this.activeCharacterState.characterAnimationObjectReferenceA.tileY
                           )) {
                           this.createWorldObject(0, this.activeCharacterState.characterAnimationObjectReferenceA.tileX, this.activeCharacterState.characterAnimationObjectReferenceA.tileY, 18, -16);
                           if (!this.gameFlagV) {
                              this.updateActorAnimation(this.activeCharacterState.characterAnimationObjectReferenceA, -4);
                           }
                        }
                        break;
                     case 8:
                        if ((var1.animationFrameIndex == 5 && var1.currentShadowDepth == 1 || var1.animationFrameIndex == 6 && var1.currentShadowDepth == 2)
                           && (
                              this.isActorAdjacentAndFacingTarget(var1, this.activeCharacterState.characterAnimationObjectReferenceA.tileX, this.activeCharacterState.characterAnimationObjectReferenceA.tileY)
                                 || var1.tileX == this.activeCharacterState.characterAnimationObjectReferenceA.tileX && var1.tileY == this.activeCharacterState.characterAnimationObjectReferenceA.tileY
                           )) {
                           this.createWorldObject(0, this.activeCharacterState.characterAnimationObjectReferenceA.tileX, this.activeCharacterState.characterAnimationObjectReferenceA.tileY, 18, -16);
                           if (!this.gameFlagV) {
                              this.updateActorAnimation(this.activeCharacterState.characterAnimationObjectReferenceA, -2);
                           }
                        } break;
                  }
               }
            }
         }

         if (this.gameIntegerStateG != 646 && this.gameIntegerStateG != 647) {
            for (int var8 = 0; var8 < 10; var8++) {
               if (this.animatedEntityStates[var8].isAnimationActive) {
                  switch (this.animatedEntityStates[var8].animationType) {
                     case 4:
                        int var7 = (int)(this.gameClockTimeMs - this.animatedEntityStates[var8].animationStartTime);
                        int var10 = this.animatedEntityStates[var8].positionX
                           + var7 * (this.animatedEntityStates[var8].destinationX - this.animatedEntityStates[var8].positionX) / (this.animatedEntityStates[var8].animationFrame * 5);
                        int var6 = this.animatedEntityStates[var8].positionY
                           + var7 * (this.animatedEntityStates[var8].destinationY - this.animatedEntityStates[var8].positionY) / (this.animatedEntityStates[var8].animationFrame * 5);
                        var7 = 20 - this.squareInteger(var7) * 20 / this.squareInteger(this.animatedEntityStates[var8].animationFrame * 5);
                        this.animatedEntityStates[var8].objectState.worldObjectShortValueA = (short)var10;
                        this.animatedEntityStates[var8].objectState.worldObjectShortValueB = (short)var6;
                        this.animatedEntityStates[var8].objectState.worldObjectShortValueC = (short)var7;
                        if (this.animatedEntityStates[var8].objectState.worldObjectShortValueC <= 0) {
                           this.animatedEntityStates[var8].isAnimationActive = false;

                           for (int var3 = 1; var3 < 24; var3++) {
                              if (this.actorStates[var3].isActive
                                 && !this.actorStates[var3].actorRuntimeFlagF
                                 && this.actorStates[var3].animationFrameIndex != 3
                                 && this.actorStates[var3].animationFrameIndex != 4
                                 && JMath.abs(this.gameIntegerStateO - this.actorStates[var3].tileX) <= 1
                                 && JMath.abs(this.gameIntegerStateP - this.actorStates[var3].tileY) <= 1) {
                                 this.playerAmmo++;
                                 this.updateActorAnimation(this.actorStates[var3], -20);
                                 if (this.actorStates[var3].animationSetIndex == 5 && this.actorStates[var3].actionCounter > 0) {
                                    this.drawActorShadow(this.actorStates[var3], 14);
                                 }

                                 if (this.actorStates[var3].animationSetIndex == 2 || this.actorStates[var3].animationSetIndex == 8) {
                                    if (this.actorStates[var3].actionCounter > 0) {
                                       this.drawActorShadow(this.actorStates[var3], 14);
                                    } else if (this.actorStates[var3].actionCounter <= 0) {
                                       this.actorStates[var3].optionalTimer = this.gameClockTimeMs;
                                       this.gameByteStateBK++;
                                       debugLog("unithit: " + var3);
                                    }
                                 }

                                 if (this.actorStates[var3].animationSetIndex == 6 && this.actorStates[var3].actionCounter <= 0) {
                                    this.actorStates[var3].optionalTimer = this.gameClockTimeMs;
                                    this.useAmmunition(this.actorStates[var3].tileX, this.actorStates[var3].tileY);
                                    this.gameByteStateBK++;
                                 }

                                 this.createWorldObject(0, this.actorStates[var3].tileX, this.actorStates[var3].tileY, 18, -16);
                              }
                           }

                           this.gameIntegerStateH = 100;
                        } goto default;
                     default:
                        this.animatedEntityStates[var8].objectState.worldObjectByteStateB = (sbyte)this.screenToTileY(
                           this.animatedEntityStates[var8].objectState.worldObjectShortValueA, this.animatedEntityStates[var8].objectState.worldObjectShortValueB
                        );
                        this.animatedEntityStates[var8].objectState.worldObjectByteStateC = (sbyte)this.screenToTileX(
                           this.animatedEntityStates[var8].objectState.worldObjectShortValueA, this.animatedEntityStates[var8].objectState.worldObjectShortValueB
                        ); break;
                  }
               }
            }
         }
      }
   }

   // $VF: renamed from: G () void
   public void initializeLevelTransition() {
      try {
         this.gameByteStateAP = 0;
         this.gameByteStateAL = 2;

         for (int var1 = 0; var1 < 4; var1++) {
            this.isLayerEnabled[var1] = false;
         }

         this.gameIntegerStateG = 384;
         this.resetPlayerEffectState();

         for (int var4 = 0; var4 < 6; var4++) {
            this.activeCharacterState.characterAnimationFlagArrayA[var4] = false;
         }

         this.activeCharacterState.characterAnimationFlagArrayA[0] = true;
         this.activeCharacterState.characterAnimationFlagArrayA[5] = true;
         this.activeCharacterState.characterAnimationFlagArrayA[1] = true;
         this.primaryCharacterState.characterAnimationByteStateC = 0;
         this.primaryCharacterState.characterAnimationByteStateB = 0;
         this.primaryCharacterState.characterAnimationByteStateD = 1;
         this.primaryCharacterState.characterAnimationByteStateArrayA[0] = 0;
         this.primaryCharacterState.characterAnimationByteStateArrayA[1] = 25;
         this.primaryCharacterState.characterAnimationByteStateArrayA[2] = 0;
         this.primaryCharacterState.characterAnimationByteStateArrayA[3] = 0;
         this.primaryCharacterState.characterAnimationByteStateArrayA[4] = 0;
         this.primaryCharacterState.characterAnimationByteStateArrayA[5] = 1;
         this.activeCharacterState = this.primaryCharacterState;
         this.gameByteStateAM = 1;
         this.activeCharacterState.characterAnimationByteStateE = 0;
         this.gameShortValueC = 0;
         this.gameShortValueD = 0;
         this.gameIntegerStateJ = 0;
         this.playerHealth = 0;
         this.playerAmmo = 0;
         this.playerGrenades = 0;
         this.playerCredits = 0;
         this.gameIntegerStateK = 0;
         this.gameIntegerStateL = 0;
         this.gameIntegerStateM = 0;
         this.gameByteStateBF = 0;
         this.clearLevelGrid();
      } catch (System.Exception var3) {
      }
   }

   // $VF: renamed from: c (u, int) void
   public void updateActorAnimation(ActorRuntimeState var1, int var2) {
      if (var1.animationFrameIndex != 3 && var1.animationFrameIndex != 4) {
         if (var2 >= 128) {
            var2 -= 256;
         }

         int var3 = var1.actionCounter + var2;
         if (var3 > 128) {
            var3 = 125;
         }

         if (var3 < -127) {
            var3 = 0;
         }

         var1.actionCounter = (sbyte)var3;
         if (var1.actionCounter < 0) {
            var1.actionCounter = 0;
         } else if (var1.actionCounter > var1.actionCounterLimit) {
            var1.actionCounter = var1.actionCounterLimit;
         }

         if (var1.actionCounter <= 0) {
            this.drawActorShadow(var1, 3);
         }
      }
   }

   // $VF: renamed from: H () void
   public void updateWorldObjects() {
      if (!this.isScreenInitialized) {
         this.updateActorTargeting();

         for (int var2 = 0; var2 < 24; var2++) {
            if (this.actorStates[var2].isActive
               && this.actorStates[var2].animationFrameIndex != 3
               && this.actorStates[var2].animationFrameIndex != 4
               && this.actorStates[var2].tileX < this.gameByteStateAQ
               && this.actorStates[var2].tileY < this.gameByteStateAR
               && (this.currentTileType == this.levelTileTypes[this.actorStates[var2].tileX][this.actorStates[var2].tileY] || this.isActorActionAllowed(this.actorStates[var2]))) {
               ActorRuntimeState var1 = this.actorStates[var2];
               if (var1.animationFrameIndex != 14) {
                  this.moveActorTowardTarget(var1);
               }

               switch (var1.animationSetIndex) {
                  case 2:
                  case 4:
                     if (var1.animationFrameIndex != 5 && var1.animationFrameIndex != 14) {
                        if (var1.actorRuntimeFlagE) {
                           if (var1.animationFrameIndex != 0 && var1.tileX == var1.targetTileX && var1.tileY == var1.targetTileY) {
                              var1.targetTileX = -1;
                              var1.targetTileY = -1;
                              this.drawActorShadow(var1, 0);
                           }
                        } else {
                           if ((JMath.abs(var1.tileX - this.activeCharacterState.characterAnimationObjectReferenceA.tileX) > 1 || var1.tileY != this.activeCharacterState.characterAnimationObjectReferenceA.tileY)
                              && (JMath.abs(var1.tileY - this.activeCharacterState.characterAnimationObjectReferenceA.tileY) > 1 || var1.tileX != this.activeCharacterState.characterAnimationObjectReferenceA.tileX)) {
                              if (var1.animationFrameIndex != 1 || var1.targetTileX >= 0 && var1.targetTileY >= 0) {
                                 if (var1.animationFrameIndex == 1
                                    && (var1.targetTileX != this.activeCharacterState.characterAnimationObjectReferenceA.tileX || var1.targetTileY != this.activeCharacterState.characterAnimationObjectReferenceA.tileY)) {
                                    var1.targetTileX = this.activeCharacterState.characterAnimationObjectReferenceA.tileX;
                                    var1.targetTileY = this.activeCharacterState.characterAnimationObjectReferenceA.tileY;
                                 }
                              } else {
                                 this.drawActorShadow(var1, 0);
                                 var1.elapsedTimerB = this.gameClockTimeMs;
                              }
                           } else {
                              this.drawActorShadow(var1, 0);
                           }

                           if (var1.animationFrameIndex == 0) {
                              this.faceActorTowardPoint(var1, this.activeCharacterState.characterAnimationObjectReferenceA.tileX, this.activeCharacterState.characterAnimationObjectReferenceA.tileY);
                              if (JMath.abs(var1.tileX - this.activeCharacterState.characterAnimationObjectReferenceA.tileX) <= 1 && var1.tileY == this.activeCharacterState.characterAnimationObjectReferenceA.tileY
                                 || JMath.abs(var1.tileY - this.activeCharacterState.characterAnimationObjectReferenceA.tileY) <= 1 && var1.tileX == this.activeCharacterState.characterAnimationObjectReferenceA.tileX) {
                                 var1.targetTileX = -1;
                                 var1.targetTileY = -1;
                                 if (this.gameClockTimeMs - var1.elapsedTimerB > 1400L) {
                                    this.drawActorShadow(var1, 5);
                                    var1.elapsedTimerB = this.gameClockTimeMs;
                                 }
                              } else if (this.gameClockTimeMs - var1.elapsedTimerB > 500L) {
                                 int var6 = this.isActorAtTile(var2, var1.tileX, var1.tileY, false);
                                 if (var6 != -1 && this.actorStates[var6].movementDirection == var1.movementDirection) {
                                    var1.movementDirection = (sbyte)(var1.movementDirection + (this.nextRandomByte() % 3 + 1) * 2);
                                 }

                                 var1.targetTileX = this.activeCharacterState.characterAnimationObjectReferenceA.tileX;
                                 var1.targetTileY = this.activeCharacterState.characterAnimationObjectReferenceA.tileY;
                                 this.drawActorShadow(var1, 1);
                              }
                           }
                        }
                     } goto case 3;
                  case 3:
                  case 5:
                  case 7:
                  default:
                     break;
                  case 6:
                     if (var1.animationFrameIndex == 5 || var1.actorRuntimeFlagE) {
                        break;
                     }

                     if ((JMath.abs(var1.tileX - this.activeCharacterState.characterAnimationObjectReferenceA.tileX) > 1 || var1.tileY != this.activeCharacterState.characterAnimationObjectReferenceA.tileY)
                        && (JMath.abs(var1.tileY - this.activeCharacterState.characterAnimationObjectReferenceA.tileY) > 1 || var1.tileX != this.activeCharacterState.characterAnimationObjectReferenceA.tileX)) {
                        if (var1.animationFrameIndex != 1 || var1.targetTileX >= 0 && var1.targetTileY >= 0) {
                           if (var1.animationFrameIndex == 1 && (var1.targetTileX != this.activeCharacterState.characterAnimationObjectReferenceA.tileX || var1.targetTileY != this.activeCharacterState.characterAnimationObjectReferenceA.tileY)) {
                              var1.targetTileX = this.activeCharacterState.characterAnimationObjectReferenceA.tileX;
                              var1.targetTileY = this.activeCharacterState.characterAnimationObjectReferenceA.tileY;
                           }
                        } else {
                           this.drawActorShadow(var1, 0);
                           var1.elapsedTimerB = this.gameClockTimeMs;
                        }
                     } else {
                        this.drawActorShadow(var1, 0);
                     }

                     if (var1.animationFrameIndex != 0) {
                        break;
                     }

                     this.faceActorTowardPoint(var1, this.activeCharacterState.characterAnimationObjectReferenceA.tileX, this.activeCharacterState.characterAnimationObjectReferenceA.tileY);
                     if (JMath.abs(var1.tileX - this.activeCharacterState.characterAnimationObjectReferenceA.tileX) <= 1 && var1.tileY == this.activeCharacterState.characterAnimationObjectReferenceA.tileY
                        || JMath.abs(var1.tileY - this.activeCharacterState.characterAnimationObjectReferenceA.tileY) <= 1 && var1.tileX == this.activeCharacterState.characterAnimationObjectReferenceA.tileX) {
                        var1.targetTileX = -1;
                        var1.targetTileY = -1;
                        if (this.gameClockTimeMs - var1.elapsedTimerB > 1400L) {
                           this.drawActorShadow(var1, 5);
                           var1.elapsedTimerB = this.gameClockTimeMs;
                        }
                     } else if (this.gameClockTimeMs - var1.elapsedTimerB > 500L) {
                        int var5 = this.isActorAtTile(var2, var1.tileX, var1.tileY, false);
                        if (var5 != -1 && this.actorStates[var5].movementDirection == var1.movementDirection) {
                           var1.movementDirection = (sbyte)(var1.movementDirection + (this.nextRandomByte() % 3 + 1) * 2);
                        }

                        var1.targetTileX = this.activeCharacterState.characterAnimationObjectReferenceA.tileX;
                        var1.targetTileY = this.activeCharacterState.characterAnimationObjectReferenceA.tileY;
                        this.drawActorShadow(var1, 1);
                     }
                     break;
                  case 8:
                     if (var1.animationFrameIndex != 5 && var1.animationFrameIndex != 6 && var1.animationFrameIndex != 14 && !var1.actorRuntimeFlagE) {
                        if ((JMath.abs(var1.tileX - this.activeCharacterState.characterAnimationObjectReferenceA.tileX) > 1 || var1.tileY != this.activeCharacterState.characterAnimationObjectReferenceA.tileY)
                           && (JMath.abs(var1.tileY - this.activeCharacterState.characterAnimationObjectReferenceA.tileY) > 1 || var1.tileX != this.activeCharacterState.characterAnimationObjectReferenceA.tileX)) {
                           if (!this.gameFlagG
                              || (JMath.abs(var1.tileX - this.activeCharacterState.characterAnimationObjectReferenceA.tileX) != 2 || var1.tileY != this.activeCharacterState.characterAnimationObjectReferenceA.tileY)
                                 && (JMath.abs(var1.tileY - this.activeCharacterState.characterAnimationObjectReferenceA.tileY) != 2 || var1.tileX != this.activeCharacterState.characterAnimationObjectReferenceA.tileX)) {
                              if (var1.animationFrameIndex != 1 || var1.targetTileX >= 0 && var1.targetTileY >= 0) {
                                 if (var1.animationFrameIndex == 1
                                    && (var1.targetTileX != this.activeCharacterState.characterAnimationObjectReferenceA.tileX || var1.targetTileY != this.activeCharacterState.characterAnimationObjectReferenceA.tileY)) {
                                    var1.targetTileX = this.activeCharacterState.characterAnimationObjectReferenceA.tileX;
                                    var1.targetTileY = this.activeCharacterState.characterAnimationObjectReferenceA.tileY;
                                 }
                              } else {
                                 this.drawActorShadow(var1, 0);
                                 var1.elapsedTimerB = this.gameClockTimeMs;
                              }
                           } else {
                              this.drawActorShadow(var1, 0);
                           }
                        } else {
                           this.gameFlagG = false;
                           this.drawActorShadow(var1, 0);
                        }

                        if (var1.animationFrameIndex == 0) {
                           this.faceActorTowardPoint(var1, this.activeCharacterState.characterAnimationObjectReferenceA.tileX, this.activeCharacterState.characterAnimationObjectReferenceA.tileY);
                           if ((JMath.abs(var1.tileX - this.activeCharacterState.characterAnimationObjectReferenceA.tileX) > 1 || var1.tileY != this.activeCharacterState.characterAnimationObjectReferenceA.tileY)
                              && (JMath.abs(var1.tileY - this.activeCharacterState.characterAnimationObjectReferenceA.tileY) > 1 || var1.tileX != this.activeCharacterState.characterAnimationObjectReferenceA.tileX)) {
                              if (this.gameFlagG
                                 && (
                                    JMath.abs(var1.tileX - this.activeCharacterState.characterAnimationObjectReferenceA.tileX) == 2 && var1.tileY == this.activeCharacterState.characterAnimationObjectReferenceA.tileY
                                       || JMath.abs(var1.tileY - this.activeCharacterState.characterAnimationObjectReferenceA.tileY) == 2 && var1.tileX == this.activeCharacterState.characterAnimationObjectReferenceA.tileX
                                 )) {
                                 var1.targetTileX = -1;
                                 var1.targetTileY = -1;
                                 if (this.gameClockTimeMs - var1.elapsedTimerB > 1000L) {
                                    this.drawActorShadow(var1, 6);
                                    this.gameFlagG = false;
                                 }
                              } else if (this.gameClockTimeMs - var1.elapsedTimerB > 1400L) {
                                 int var3 = this.isActorAtTile(var2, var1.tileX, var1.tileY, false);
                                 if (var3 != -1 && this.actorStates[var3].movementDirection == var1.movementDirection) {
                                    var1.movementDirection = (sbyte)(var1.movementDirection + (this.nextRandomByte() % 3 + 1) * 2);
                                 }

                                 var1.targetTileX = this.activeCharacterState.characterAnimationObjectReferenceA.tileX;
                                 var1.targetTileY = this.activeCharacterState.characterAnimationObjectReferenceA.tileY;
                                 this.drawActorShadow(var1, 1);
                                 if (this.nextRandomColor() % 100 < 25) {
                                    this.gameFlagG = true;
                                 }
                              }
                           } else {
                              var1.targetTileX = -1;
                              var1.targetTileY = -1;
                              if (this.gameClockTimeMs - var1.elapsedTimerB > 1000L) {
                                 if (this.nextRandomColor() % 100 < 40) {
                                    this.drawActorShadow(var1, 6);
                                 } else {
                                    this.drawActorShadow(var1, 5);
                                 }
                              }
                           }
                        }

                        if (var1.animationFrameIndex == 1 && this.gameIntegerStateG == 901 && this.gameIntegerStateO == var1.tileX && this.gameIntegerStateP == var1.tileY) {
                           int var4 = this.nextRandomColor() % 100;
                           if (var4 >= 40 && var4 > 40 && var4 < 80 && this.gameClockTimeMs - this.gameLongValueA > 2000L) {
                              this.drawActorShadow(var1, 2);
                              this.gameLongValueA = this.gameClockTimeMs;
                           }
                        }
                     } break;
               }

               if (var1.actorRuntimeFlagB) {
                  switch (var1.animationSetIndex) {
                     case 0:
                     case 1:
                        if (var1.targetTileX < 0 || var1.targetTileY < 0) {
                           break;
                        } goto default;
                     default:
                        if ((var1.tileX != var1.targetTileX || var1.tileY != var1.targetTileY) && var1.targetTileX >= 0 && var1.targetTileY >= 0) {
                           this.scheduleEvent(var1.tileX, var1.tileY, var1.targetTileX, var1.targetTileY);
                           if (this.activeScheduledEvent != null) {
                              this.faceActorTowardPoint(var1, this.activeScheduledEvent.eventType, this.activeScheduledEvent.eventDelay);
                           }
                        } break;
                  }
               }
            }
         }
      }
   }

   // $VF: renamed from: a (int, int, int, int, int, byte) int
   public int spawnAnimatedEffect(int var1, int var2, int var3, int var4, int var5, sbyte var6) {
      int var7 = 0;

      while (var7 < 10 && this.animatedEntityStates[var7].isAnimationActive) {
         var7++;
      }

      if (var7 >= 0 && var7 < 10) {
         this.animatedEntityStates[var7].isAnimationActive = true;
         this.animatedEntityStates[var7].animationType = (sbyte)var1;
         this.animatedEntityStates[var7].objectState.worldObjectFlagA = false;
         this.animatedEntityStates[var7].objectState.worldObjectFlagB = true;
         this.animatedEntityStates[var7].objectState.worldObjectShortValueA = 0;
         this.animatedEntityStates[var7].objectState.worldObjectShortValueB = 0;
         this.animatedEntityStates[var7].objectState.worldObjectShortValueC = 0;
         this.animatedEntityStates[var7].objectState.worldObjectByteStateD = 0;
         this.animatedEntityStates[var7].objectState.worldObjectIntegerStateA = 0;
         this.animatedEntityStates[var7].animationStartTime = this.gameClockTimeMs;
         this.animatedEntityStates[var7].animationFlags = var6;
         this.animatedEntityStates[var7].horizontalVelocity = var4;
         this.animatedEntityStates[var7].verticalVelocity = var5;
         switch (var1) {
            case 4:
               this.animatedEntityStates[var7].objectState.worldObjectByteStateB = (sbyte)var2;
               this.animatedEntityStates[var7].objectState.worldObjectByteStateC = (sbyte)var3;
               this.animatedEntityStates[var7].positionX = (short)(this.tileToScreenX(var2, var3) + 18);
               this.animatedEntityStates[var7].positionY = (short)(this.tileToScreenY(var2, var3) + 9);
               if (this.activeCharacterState.characterAnimationObjectReferenceA.movementDirection == 0) {
                  this.animatedEntityStates[var7].positionY = (short)(this.animatedEntityStates[var7].positionY + 12);
               } else if (this.activeCharacterState.characterAnimationObjectReferenceA.movementDirection == 4) {
                  this.animatedEntityStates[var7].positionY = (short)(this.animatedEntityStates[var7].positionY - 24);
               } else if (this.activeCharacterState.characterAnimationObjectReferenceA.movementDirection == 2) {
                  this.animatedEntityStates[var7].positionX = (short)(this.animatedEntityStates[var7].positionX + 40);
                  this.animatedEntityStates[var7].positionY = (short)(this.animatedEntityStates[var7].positionY - 20);
               } else if (this.activeCharacterState.characterAnimationObjectReferenceA.movementDirection == 6) {
                  this.animatedEntityStates[var7].positionX = (short)(this.animatedEntityStates[var7].positionX - 40);
                  this.animatedEntityStates[var7].positionY = (short)(this.animatedEntityStates[var7].positionY - 20);
               } else if (this.activeCharacterState.characterAnimationObjectReferenceA.movementDirection == 1) {
                  this.animatedEntityStates[var7].positionX = (short)(this.animatedEntityStates[var7].positionX + 24);
                  this.animatedEntityStates[var7].positionY = (short)(this.animatedEntityStates[var7].positionY + 4);
               } else if (this.activeCharacterState.characterAnimationObjectReferenceA.movementDirection == 7) {
                  this.animatedEntityStates[var7].positionX = (short)(this.animatedEntityStates[var7].positionX - 48);
                  this.animatedEntityStates[var7].positionY = (short)(this.animatedEntityStates[var7].positionY + 4);
               } else if (this.activeCharacterState.characterAnimationObjectReferenceA.movementDirection == 3) {
                  this.animatedEntityStates[var7].positionX = (short)(this.animatedEntityStates[var7].positionX + 32);
                  this.animatedEntityStates[var7].positionY = (short)(this.animatedEntityStates[var7].positionY - 32);
               } else if (this.activeCharacterState.characterAnimationObjectReferenceA.movementDirection == 5) {
                  this.animatedEntityStates[var7].positionX = (short)(this.animatedEntityStates[var7].positionX - 32);
                  this.animatedEntityStates[var7].positionY = (short)(this.animatedEntityStates[var7].positionY - 32);
               } goto default;
            default:
               switch (var1) {
                  case 4:
                     this.animatedEntityStates[var7].destinationX = (short)(this.tileToScreenX(var4, var5) + 18);
                     this.animatedEntityStates[var7].destinationY = (short)(this.tileToScreenY(var4, var5) + 9);
                     this.animatedEntityStates[var7].animationFrame = (short)normalizePositiveInteger(
                        this.squareInteger(this.animatedEntityStates[var7].destinationX - this.animatedEntityStates[var7].positionX)
                           + this.squareInteger(this.animatedEntityStates[var7].destinationY - this.animatedEntityStates[var7].positionY)
                     );
                     this.animatedEntityStates[var7].objectState.worldObjectFlagA = true;
                     this.animatedEntityStates[var7].objectState.worldObjectByteStateA = 2;
                     break;
                  default:
                     this.animatedEntityStates[var7].destinationX = this.animatedEntityStates[var7].positionX;
                     this.animatedEntityStates[var7].destinationY = this.animatedEntityStates[var7].positionY; break;
               }

               return var7;
         }
      } else {
         return var7;
      }
   }

   // $VF: renamed from: a (int, int, int, int, int) int
   public int createWorldObject(int var1, int var2, int var3, int var4, int var5) {
      int var6 = 0;

      while (var6 < 5 && this.objectStates[var6].worldObjectFlagA) {
         var6++;
      }

      if (var6 >= 5) {
         return var6;
      } else {
         this.objectStates[var6].worldObjectFlagA = true;
         this.objectStates[var6].worldObjectFlagB = true;
         this.objectStates[var6].worldObjectShortValueA = (short)(this.tileToScreenX(var2, var3) + var4);
         this.objectStates[var6].worldObjectShortValueB = (short)(this.tileToScreenY(var2, var3) + var5);
         this.objectStates[var6].worldObjectShortValueC = 0;
         this.objectStates[var6].worldObjectByteStateA = (sbyte)var1;
         this.objectStates[var6].worldObjectByteStateD = 0;
         this.objectStates[var6].worldObjectIntegerStateA = 0;
         this.objectStates[var6].worldObjectByteStateB = (sbyte)var2;
         this.objectStates[var6].worldObjectByteStateC = (sbyte)var3;
         return var6;
      }
   }

   // $VF: renamed from: b (u, int, int) void
   public void faceActorTowardPoint(ActorRuntimeState var1, int var2, int var3) {
      int var4 = var1.tileX - var2;
      int var5 = var1.tileY - var3;
      if (JMath.abs(var5) <= JMath.abs(var4)) {
         if (var4 <= 0) {
            this.setActorDirection(var1, 1);
         } else {
            this.setActorDirection(var1, 5);
         }
      } else if (var5 <= 0) {
         this.setActorDirection(var1, 7);
      } else {
         this.setActorDirection(var1, 3);
      }
   }

   // $VF: renamed from: b (u) void
   public void moveActorTowardTarget(ActorRuntimeState var1) {
      if (var1.targetTileX != -1 && var1.targetTileY != -1) {
         if (!this.actorHasShadow(var1) && (var1.tileX != var1.targetTileX || var1.tileY != var1.targetTileY)) {
            this.updateActorTargeting();
            this.setActorDestination(var1, var1.targetTileX, var1.targetTileY);
         }
      }
   }

   // $VF: renamed from: c (u, int, int) boolean
   public bool isActorAdjacentAndFacingTarget(ActorRuntimeState var1, int var2, int var3) {
      int var4 = var1.tileX - var2;
      int var5 = var1.tileY - var3;
      if (JMath.abs(var4) == 0 && JMath.abs(var5) == 1 || JMath.abs(var4) == 1 && JMath.abs(var5) == 0) {
         if (JMath.abs(var5) <= JMath.abs(var4)) {
            if (var4 <= 0) {
               if (var1.movementDirection == 1) {
                  return true;
               }
            } else if (var1.movementDirection == 5) {
               return true;
            }
         } else if (var5 <= 0) {
            if (var1.movementDirection == 7) {
               return true;
            }
         } else if (var1.movementDirection == 3) {
            return true;
         }

         return false;
      } else {
         return false;
      }
   }

   // $VF: renamed from: d (u, int, int) void
   public void setActorDestination(ActorRuntimeState var1, int var2, int var3) {
      if (var1.tileX != var2 || var1.tileY != var3) {
         var1.targetTileX = (sbyte)var2;
         var1.targetTileY = (sbyte)var3;
         this.scheduleEvent(var1.tileX, var1.tileY, var1.targetTileX, var1.targetTileY);
         if (this.activeScheduledEvent != null) {
            this.faceActorTowardPoint(var1, this.activeScheduledEvent.eventType, this.activeScheduledEvent.eventDelay);
            this.drawActorShadow(var1, 1);
         }
      }
   }

   // $VF: renamed from: I () void
   public void updateActorTargeting() {
      for (int var2 = 0; var2 < this.gameByteStateAQ; var2++) {
         for (int var3 = 0; var3 < this.gameByteStateAR; var3++) {
            this.collisionMap[var2][var3] = 0;
            if (this.levelTileHeights[var2][var3] != -1) {
               this.collisionMap[var2][var3] = (sbyte)(this.collisionMap[var2][var3] | 2);
            }

            if (this.levelTileWidths[var2][var3] != -1) {
               this.collisionMap[var2][var3] = (sbyte)(this.collisionMap[var2][var3] | 1);
            }

            if (this.levelTileFlags[var2][var3] == 127) {
               this.collisionMap[var2][var3] = (sbyte)(this.collisionMap[var2][var3] | 240);
            }
         }
      }

      for (int var5 = 0; var5 < 24; var5++) {
         if (this.actorStates[var5] != this.activeCharacterState.characterAnimationObjectReferenceA && this.actorStates[var5].isActive) {
            if (this.actorStates[var5].animationFrameIndex == 3 || this.actorStates[var5].animationFrameIndex == 4) {
               if (this.actorStates[var5].animationSetIndex == 5) {
                  continue;
               }

               if (this.actorStates[var5].animationSetIndex == 7) {
                  this.collisionMap[this.actorStates[var5].tileX][this.actorStates[var5].tileY] = (sbyte)(
                     this.collisionMap[this.actorStates[var5].tileX][this.actorStates[var5].tileY] | 240
                  );
                  this.collisionMap[this.actorStates[var5].tileX][this.actorStates[var5].tileY - 1] = (sbyte)(
                     this.collisionMap[this.actorStates[var5].tileX][this.actorStates[var5].tileY - 1] | 240
                  );
                  continue;
               }

               if (this.actorStates[var5].animationSetIndex == 3 || this.actorStates[var5].animationSetIndex == 9) {
                  this.collisionMap[this.actorStates[var5].tileX][this.actorStates[var5].tileY] = (sbyte)(
                     this.collisionMap[this.actorStates[var5].tileX][this.actorStates[var5].tileY] | 240
                  );
                  continue;
               }

               if (this.actorStates[var5].animationSetIndex != 10) {
                  continue;
               }

               this.collisionMap[this.actorStates[var5].tileX][this.actorStates[var5].tileY] = (sbyte)(
                  this.collisionMap[this.actorStates[var5].tileX][this.actorStates[var5].tileY] | 240
               );
               this.collisionMap[this.actorStates[var5].tileX][this.actorStates[var5].tileY - 1] = (sbyte)(
                  this.collisionMap[this.actorStates[var5].tileX][this.actorStates[var5].tileY - 1] | 240
               );
               this.collisionMap[this.actorStates[var5].tileX - 1][this.actorStates[var5].tileY - 1] = (sbyte)(
                  this.collisionMap[this.actorStates[var5].tileX - 1][this.actorStates[var5].tileY - 1] | 240
               );
               this.collisionMap[this.actorStates[var5].tileX + 1][this.actorStates[var5].tileY - 1] = (sbyte)(
                  this.collisionMap[this.actorStates[var5].tileX + 1][this.actorStates[var5].tileY - 1] | 240
               );
               this.collisionMap[this.actorStates[var5].tileX][this.actorStates[var5].tileY - 2] = (sbyte)(
                  this.collisionMap[this.actorStates[var5].tileX][this.actorStates[var5].tileY - 2] | 240
               );
               this.collisionMap[this.actorStates[var5].tileX - 1][this.actorStates[var5].tileY - 2] = (sbyte)(
                  this.collisionMap[this.actorStates[var5].tileX - 1][this.actorStates[var5].tileY - 2] | 240
               );
               this.collisionMap[this.actorStates[var5].tileX][this.actorStates[var5].tileY - 3] = (sbyte)(
                  this.collisionMap[this.actorStates[var5].tileX][this.actorStates[var5].tileY - 3] | 240
               );
               this.collisionMap[this.actorStates[var5].tileX - 1][this.actorStates[var5].tileY - 3] = (sbyte)(
                  this.collisionMap[this.actorStates[var5].tileX - 1][this.actorStates[var5].tileY - 3] | 240
               );
               this.collisionMap[this.actorStates[var5].tileX][this.actorStates[var5].tileY - 4] = (sbyte)(
                  this.collisionMap[this.actorStates[var5].tileX][this.actorStates[var5].tileY - 4] | 240
               );
               this.collisionMap[this.actorStates[var5].tileX - 1][this.actorStates[var5].tileY - 4] = (sbyte)(
                  this.collisionMap[this.actorStates[var5].tileX - 1][this.actorStates[var5].tileY - 4] | 240
               );
            }

            if (this.actorStates[var5].animationSetIndex != 0 && this.actorStates[var5].animationSetIndex != 1 && this.actorStates[var5].animationSetIndex != 3) {
               this.collisionMap[this.actorStates[var5].tileX][this.actorStates[var5].tileY] = (sbyte)(
                  this.collisionMap[this.actorStates[var5].tileX][this.actorStates[var5].tileY] | 240
               );
            } else {
               this.collisionMap[this.actorStates[var5].tileX][this.actorStates[var5].tileY] = (sbyte)(
                  this.collisionMap[this.actorStates[var5].tileX][this.actorStates[var5].tileY] | 240
               );
            }
         }
      }

      for (int var4 = 0; var4 < this.levelObjectCount; var4++) {
         if (this.levelObjects[var4].actorAnimationFlagB) {
            sbyte var1 = this.levelObjects[var4].actorAnimationByteStateA;
            if (this.levelObjectProperties[var1][7] != 0) {
               if (this.levelObjectProperties[var1][6] != 0) {
                  if (!this.levelObjects[var4].actorAnimationFlagD) {
                     if (this.levelObjects[var4].actorAnimationByteStateB != 0) {
                        for (int var9 = 0; var9 < this.levelObjectProperties[var1][5]; var9++) {
                           this.collisionMap[this.levelObjects[var4].actorAnimationByteStateB][this.levelObjects[var4].actorAnimationByteStateC + var9] = (sbyte)(
                              this.collisionMap[this.levelObjects[var4].actorAnimationByteStateB][this.levelObjects[var4].actorAnimationByteStateC + var9] | 2
                           );
                        }
                     }
                  } else if (this.levelObjects[var4].actorAnimationByteStateC != 0) {
                     for (int var8 = 0; var8 < this.levelObjectProperties[var1][5]; var8++) {
                        this.collisionMap[this.levelObjects[var4].actorAnimationByteStateB + var8][this.levelObjects[var4].actorAnimationByteStateC] = (sbyte)(
                           this.collisionMap[this.levelObjects[var4].actorAnimationByteStateB + var8][this.levelObjects[var4].actorAnimationByteStateC] | 1
                        );
                     }
                  }
               } else if (!this.levelObjects[var4].actorAnimationFlagD) {
                  for (int var7 = 0; var7 < this.levelObjectProperties[var1][4]; var7++) {
                     for (int var11 = 0; var11 < this.levelObjectProperties[var1][5]; var11++) {
                        this.collisionMap[this.levelObjects[var4].actorAnimationByteStateB + var7][this.levelObjects[var4].actorAnimationByteStateC + var11] = (sbyte)(
                           this.collisionMap[this.levelObjects[var4].actorAnimationByteStateB + var7][this.levelObjects[var4].actorAnimationByteStateC + var11] | 240
                        );
                     }
                  }
               } else {
                  for (int var6 = 0; var6 < this.levelObjectProperties[var1][5]; var6++) {
                     for (int var10 = 0; var10 < this.levelObjectProperties[var1][4]; var10++) {
                        this.collisionMap[this.levelObjects[var4].actorAnimationByteStateB + var6][this.levelObjects[var4].actorAnimationByteStateC + var10] = (sbyte)(
                           this.collisionMap[this.levelObjects[var4].actorAnimationByteStateB + var6][this.levelObjects[var4].actorAnimationByteStateC + var10] | 240
                        );
                     }
                  }
               }
            }
         }
      }

      if (this.medicalItemState.actorAnimationFlagB) {
         this.collisionMap[this.medicalItemState.actorAnimationByteStateB][this.medicalItemState.actorAnimationByteStateC] = (sbyte)(this.collisionMap[this.medicalItemState.actorAnimationByteStateB][this.medicalItemState.actorAnimationByteStateC] | 240);
      }

      if (this.ammunitionItemState.actorAnimationFlagB) {
         this.collisionMap[this.ammunitionItemState.actorAnimationByteStateB][this.ammunitionItemState.actorAnimationByteStateC] = (sbyte)(this.collisionMap[this.ammunitionItemState.actorAnimationByteStateB][this.ammunitionItemState.actorAnimationByteStateC] | 240);
      }

      if (this.weaponItemState.actorAnimationFlagB) {
         this.collisionMap[this.weaponItemState.actorAnimationByteStateB][this.weaponItemState.actorAnimationByteStateC] = (sbyte)(this.collisionMap[this.weaponItemState.actorAnimationByteStateB][this.weaponItemState.actorAnimationByteStateC] | 240);
      }

      if (this.gameIntegerStateG == 384) {
         this.collisionMap[this.activeCharacterState.characterAnimationObjectReferenceA.tileX][this.activeCharacterState.characterAnimationObjectReferenceA.tileY] = (sbyte)(
            this.collisionMap[this.activeCharacterState.characterAnimationObjectReferenceA.tileX][this.activeCharacterState.characterAnimationObjectReferenceA.tileY] | 240
         );
      } else {
         this.collisionMap[this.activeCharacterState.characterAnimationObjectReferenceA.tileX][this.activeCharacterState.characterAnimationObjectReferenceA.tileY] = (sbyte)(
            this.collisionMap[this.activeCharacterState.characterAnimationObjectReferenceA.tileX][this.activeCharacterState.characterAnimationObjectReferenceA.tileY] | 0
         );
      }
   }

   // $VF: renamed from: a (j, j) j
   public ScheduledEventNode unlinkScheduledEvent(ScheduledEventNode var1, ScheduledEventNode var2) {
      if (var1 == var2) {
         ScheduledEventNode var4 = var2.previousNode;
         var2.previousNode = null;
         return var4;
      } else {
         for (ScheduledEventNode var3 = var1; var3.previousNode != null; var3 = var3.previousNode) {
            if (var3.previousNode == var2) {
               if (var2.previousNode == null) {
                  var3.previousNode = null;
               } else {
                  var3.previousNode = var2.previousNode;
                  var2.previousNode = null;
               }
               break;
            }
         }

         return var1;
      }
   }

   // $VF: renamed from: b (j, j) j
   public ScheduledEventNode insertScheduledEvent(ScheduledEventNode var1, ScheduledEventNode var2) {
      var2.previousNode = var1;
      return var2;
   }

   // $VF: renamed from: b (int, int, int, int) void
   public void scheduleEvent(int var1, int var2, int var3, int var4) {
      bool[] var11 = new bool[4];
      object var5 = null;
      ScheduledEventNode var6 = null;
      int var14 = 0;
      ScheduledEventNode var7 = this.scheduledEvents[var14++];
      var7.eventType = (sbyte)var1;
      var7.eventDelay = (sbyte)var2;
      var7.eventParameter = 0;
      var7.eventFlags = (sbyte)(JMath.abs(var7.eventType - var3) + JMath.abs(var7.eventDelay - var4));
      var7.previousNode = null;
      var7.nextNode = null;
      ScheduledEventNode var10 = var7;
      if (var1 == var3 && var2 == var4) {
         this.activeScheduledEvent = var7;
      } else {
         sbyte var12 = this.collisionMap[var1][var2];
         sbyte var13 = this.collisionMap[var3][var4];
         if (this.collisionMap[var3][var4] == 240) {
            this.activeScheduledEvent = null;
         } else {
            this.collisionMap[var1][var2] = (sbyte)(this.collisionMap[var1][var2] & 15);
            this.collisionMap[var3][var4] = (sbyte)(this.collisionMap[var3][var4] & 15);
            ScheduledEventNode var17 = this.insertScheduledEvent((ScheduledEventNode)var5, var7);

            
            while (true) {
               ScheduledEventNode var8 = var17;
               ScheduledEventNode var9 = var17;
               if (var17 == null) {
                  break;
               }

               while (var8.previousNode != null) {
                  var8 = var8.previousNode;
                  if (var8.eventParameter + var8.eventFlags < var9.eventParameter + var9.eventFlags) {
                     var9 = var8;
                  }
               }

               if (var9.eventFlags < var10.eventFlags) {
                  var10 = var9;
               }

               if (var10.eventFlags == 0) {
                  break;
               }

               var11[0] = this.isTilePassable(var9.eventType, var9.eventDelay, 3, false);
               var11[1] = this.isTilePassable(var9.eventType, var9.eventDelay, 5, false);
               var11[2] = this.isTilePassable(var9.eventType, var9.eventDelay, 7, false);
               var11[3] = this.isTilePassable(var9.eventType, var9.eventDelay, 1, false);

               for (ScheduledEventNode var19 = var17; var19 != null; var19 = var19.previousNode) {
                  for (int var16 = 0; var16 < 4; var16++) {
                     if (var19.eventType == var9.eventType + directionOffsets[var16][0] && var19.eventDelay == var9.eventDelay + directionOffsets[var16][1]) {
                        var11[var16] = false;
                     }
                  }
               }

               ScheduledEventNode var20 = var6;

               while (true) {
                  if (var20 == null) {
                     int var15 = this.nextRandomByte() % 4;

                     for (int var24 = 0; var24 < 4; var6 = this.insertScheduledEvent(var6, var9)) {
                        if (var11[var15]) {
                           if (var14 == 150) {
                              var17 = this.unlinkScheduledEvent(var17, var9);
                              if (var14 == 150) {
                                 goto label111_brk;
                              }
                              break;
                           }

                           var7 = this.scheduledEvents[var14++];
                           var7.eventType = (sbyte)(var9.eventType + directionOffsets[var15][0]);
                           var7.eventDelay = (sbyte)(var9.eventDelay + directionOffsets[var15][1]);
                           var7.eventParameter = (sbyte)(var9.eventParameter + 1);
                           var7.eventFlags = (sbyte)(JMath.abs(var7.eventType - var3) + JMath.abs(var7.eventDelay - var4));
                           var7.previousNode = null;
                           var7.nextNode = var9;
                           var5 = this.insertScheduledEvent(var17, var7);
                        }

                        var15 = (var15 + 1) % 4;
                        var24++;
                     }
                  }

                  for (int var23 = 0; var23 < 4; var23++) {
                     if (var20.eventType == var9.eventType + directionOffsets[var23][0] && var20.eventDelay == var9.eventDelay + directionOffsets[var23][1]) {
                        var11[var23] = false;
                     }
                  }

                  var20 = var20.previousNode;
               }
            } label111_brk:;

            ScheduledEventNode var21;
            for (var21 = null; var10 != null; var10 = var10.nextNode) {
               var10.previousNode = var21;
               var21 = var10;
            }

            this.collisionMap[var1][var2] = var12;
            this.collisionMap[var3][var4] = var13;
            this.activeScheduledEvent = var21.previousNode;
         }
      }
   }

   // $VF: renamed from: J () void
   public void buildCollisionMap() {
      if (!this.isScreenInitialized) {
         for (int var2 = 0; var2 < 24; var2++) {
            if (this.actorStates[var2].isActive
               && !this.actorStates[var2].actorRuntimeFlagC
               && (this.currentTileType == this.levelTileTypes[this.actorStates[var2].tileX][this.actorStates[var2].tileY] || this.isActorActionAllowed(this.actorStates[var2]))) {
               ActorRuntimeState var1 = this.actorStates[var2];
               var1.actorRuntimeFlagB = false;
               if (SpriteAnimationFrameTable.characterShadowGeometry[var1.animationSetIndex][var1.animationFrameIndex][1] != 0) {
                  if (var1.animationSetIndex == 5) {
                     if (var1.animationFrameIndex == 1) {
                        if (var1.currentShadowDepth == 2 || var1.currentShadowDepth == 5) {
                           this.gameIntegerStateH = 100;
                        }
                     } else if (var1.animationFrameIndex == 2) {
                        if (var1.currentShadowDepth == 0 || var1.currentShadowDepth == 3) {
                           this.gameIntegerStateH = 100;
                        }
                     } else if (var1.animationFrameIndex == 6
                        && var1.currentShadowDepth > 3
                        && var1.currentShadowDepth < 8
                        && var1.previousShadowDepth != var1.currentShadowDepth
                        && this.isTilePassable(var1.tileX, var1.tileY, var1.movementDirection, true)) {
                        this.setActorAnimationState(var1, var1.movementDirection);
                     }
                  }

                  var1.movementProgressFixedPoint = var1.movementProgressFixedPoint
                     + this.scaleByFrameDelta(SpriteAnimationFrameTable.characterShadowGeometry[var1.animationSetIndex][var1.animationFrameIndex][1] * var1.actorRuntimeByteStateN * 256, SpriteAnimationFrameTable.characterShadowGeometry[var1.animationSetIndex][var1.animationFrameIndex][0]);
                  if (var1.movementProgressFixedPoint >= 65534) {
                     var1.movementProgressFixedPoint = 0;
                     var1.actorRuntimeFlagB = true;
                     if (SpriteAnimationFrameTable.characterShadowGeometry[var1.animationSetIndex][var1.animationFrameIndex][2] == SpriteAnimationFrameTable.characterShadowGeometry[var1.animationSetIndex][var1.animationFrameIndex][0]) {
                        int var3 = this.resolveCollision(var2, var1.tileX, var1.tileY, var1.movementDirection, false);
                        if (var3 != -1) {
                           if (var1.animationSetIndex != 11 && var1.animationSetIndex != 8) {
                              this.drawActorShadow(var1, 0);
                           } else {
                              this.setActorAnimationState(var1, var1.movementDirection);
                           }
                        } else if (var1.animationSetIndex != 2
                           && var1.animationSetIndex != 4
                           && var1.animationSetIndex != 6
                           && var1.animationSetIndex != 0
                           && var1.animationSetIndex != 1
                           && var1.animationSetIndex != 3) {
                           this.setActorAnimationState(var1, var1.movementDirection);
                        } else {
                           var3 = this.resolveCollision(var2, var1.tileX, var1.tileY, var1.movementDirection, true);
                           if (var3 != -1) {
                              this.drawActorShadow(var1, 0);
                           } else {
                              this.setActorAnimationState(var1, var1.movementDirection);
                           }
                        }
                     }

                     if (this.advanceActorMovement(var1)) {
                        var1.targetTileX = -1;
                        var1.targetTileY = -1;
                     }

                     
                     switch (var1.animationSetIndex) {
                        case 0:
                        case 1:
                           switch (var1.animationFrameIndex) {
                              case 1:
                              case 12:
                              case 13:
                                 if (this.activeCharacterState.characterAnimationFlagA) {
                                    this.setActorDirection(this.activeCharacterState.characterAnimationObjectReferenceA, this.activeCharacterState.characterAnimationObjectReferenceA.movementDirection + 2);
                                    this.drawActorShadow(this.activeCharacterState.characterAnimationObjectReferenceA, 0);
                                    this.activeCharacterState.characterAnimationFlagA = false;
                                 } else if (this.activeCharacterState.characterAnimationFlagB) {
                                    this.setActorDirection(this.activeCharacterState.characterAnimationObjectReferenceA, this.activeCharacterState.characterAnimationObjectReferenceA.movementDirection - 2);
                                    this.drawActorShadow(this.activeCharacterState.characterAnimationObjectReferenceA, 0);
                                    this.activeCharacterState.characterAnimationFlagB = false;
                                 } else if (this.activeCharacterState.characterAnimationFlagC) {
                                    this.setActorDirection(this.activeCharacterState.characterAnimationObjectReferenceA, this.activeCharacterState.characterAnimationObjectReferenceA.movementDirection + 4);
                                    this.drawActorShadow(this.activeCharacterState.characterAnimationObjectReferenceA, 0);
                                    this.activeCharacterState.characterAnimationFlagC = false;
                                 } else if (this.advanceActorMovement(var1)) {
                                    this.drawActorShadow(var1, 0);
                                 } else {
                                    this.drawActorShadow(var1, 1);
                                 }
                                 goto label144_brk;
                              case 2:
                              case 8:
                              case 9:
                              case 10:
                              case 11:
                              default:
                                 if (var1.elapsedTimerA != this.gameClockTimeMs) {
                                    this.drawActorShadow(var1, 0);
                                 }
                                 goto label144_brk;
                              case 3:
                                 if ((this.gameIntegerStateG & 512) != 0) {
                                    this.gameIntegerStateG = 900;
                                 }

                                 this.drawActorShadow(var1, 4);
                                 goto label144_brk;
                              case 4:
                                 switch (this.gameByteStateAZ) {
                                    case 0:
                                       screenActionCodeB = 20;
                                       screenActionCodeC = 5;
                                       this.disposeAudioManager();
                                       this.resetGameSession((sbyte)3, false);
                                       break;
                                    case 1:
                                       this.gameByteStateAL--;
                                       if (this.gameByteStateAL < 0) {
                                          screenActionCodeB = 22;
                                          screenActionCodeC = 5;
                                          this.disposeAudioManager();
                                          this.gameFlagZ = true;
                                          this.resetGameSession((sbyte)3, false);
                                       } else {
                                          this.resetActiveActors(true);
                                       }
                                       break;
                                    case 2:
                                       screenActionCodeB = 22;
                                       screenActionCodeC = 5;
                                       this.disposeAudioManager();
                                       this.resetGameSession((sbyte)3, false); break;
                                 }

                                 return;
                              case 5:
                              case 6:
                              case 7:
                                 this.drawActorShadow(var1, 0);
                                 this.updatePlayerAction();
                                 goto label144_brk;
                           } goto case 2;
                        case 2:
                        case 4:
                           switch (var1.animationFrameIndex) {
                              case 0:
                                 break;
                              case 1:
                                 if (!this.advanceActorMovement(var1)) {
                                    this.drawActorShadow(var1, 1);
                                 } else {
                                    this.drawActorShadow(var1, 0);
                                 }
                                 break;
                              case 2:
                              case 6:
                              case 7:
                              case 8:
                              case 9:
                              case 10:
                              case 11:
                              case 12:
                              case 13:
                              default:
                                 this.drawActorShadow(var1, 1);
                                 break;
                              case 3:
                              case 4:
                                 this.drawActorShadow(var1, 4);
                                 this.updatePlayerAction();
                                 break;
                              case 5:
                              case 14:
                                 this.drawActorShadow(var1, 0);
                                 this.updatePlayerAction(); break;
                           } goto case 3;
                        case 3:
                        case 7:
                        default:
                           break;
                        case 5:
                        case 6:
                        case 8:
                           switch (var1.animationFrameIndex) {
                              case 0:
                                 break;
                              case 1:
                                 if (!this.advanceActorMovement(var1)) {
                                    this.drawActorShadow(var1, 1);
                                 } else {
                                    this.drawActorShadow(var1, 0);
                                 }
                                 break;
                              case 2:
                              case 5:
                              case 6:
                              case 14:
                                 this.drawActorShadow(var1, 0);
                                 this.updatePlayerAction();
                                 break;
                              case 3:
                              case 4:
                                 this.drawActorShadow(var1, 4);
                                 this.updatePlayerAction();
                                 break;
                              case 7:
                              case 8:
                              case 9:
                              case 10:
                              case 11:
                              case 12:
                              case 13:
                              default:
                                 this.drawActorShadow(var1, 1); break;
                           } break;
                     } label144_brk:;
                  }

                  if (SpriteAnimationFrameTable.characterShadowGeometry[var1.animationSetIndex][var1.animationFrameIndex][2] != 0) {
                     var1.elapsedTimerA = this.gameClockTimeMs;
                  }

                  var1.previousShadowDepth = var1.currentShadowDepth;
                  var1.currentShadowDepth = (sbyte)(var1.movementProgressFixedPoint * SpriteAnimationFrameTable.characterShadowGeometry[var1.animationSetIndex][var1.animationFrameIndex][0] >> 16);
               }
            }
         }

         for (int var4 = 0; var4 < 5; var4++) {
            if (this.objectStates[var4].worldObjectFlagA && !this.objectStates[var4].worldObjectFlagB) {
               this.objectStates[var4].worldObjectIntegerStateA = this.objectStates[var4].worldObjectIntegerStateA
                  + this.scaleByFrameDelta(SpriteAnimationFrameTable.frameOriginOffsets[this.objectStates[var4].worldObjectByteStateA][1] * 256, SpriteAnimationFrameTable.frameOriginOffsets[this.objectStates[var4].worldObjectByteStateA][0]);
               this.objectStates[var4].worldObjectByteStateD = (sbyte)(this.objectStates[var4].worldObjectIntegerStateA * SpriteAnimationFrameTable.frameOriginOffsets[this.objectStates[var4].worldObjectByteStateA][0] >> 16);
               if (this.objectStates[var4].worldObjectIntegerStateA >= 65534) {
                  this.objectStates[var4].worldObjectFlagA = false;
               }
            }
         }

         if (this.gameIntegerStateG != 646 && this.gameIntegerStateG != 647) {
            for (int var5 = 0; var5 < 10; var5++) {
               if (this.animatedEntityStates[var5].isAnimationActive && !this.animatedEntityStates[var5].objectState.worldObjectFlagB) {
                  this.animatedEntityStates[var5].objectState.worldObjectIntegerStateA = this.animatedEntityStates[var5].objectState.worldObjectIntegerStateA
                     + this.scaleByFrameDelta(
                        SpriteAnimationFrameTable.frameOriginOffsets[this.animatedEntityStates[var5].objectState.worldObjectByteStateA][1] * 256, SpriteAnimationFrameTable.frameOriginOffsets[this.animatedEntityStates[var5].objectState.worldObjectByteStateA][0]
                     );
                  this.animatedEntityStates[var5].objectState.worldObjectByteStateD = (sbyte)(
                     this.animatedEntityStates[var5].objectState.worldObjectIntegerStateA * SpriteAnimationFrameTable.frameOriginOffsets[this.animatedEntityStates[var5].objectState.worldObjectByteStateA][0] >> 16
                  );
                  if (this.animatedEntityStates[var5].objectState.worldObjectIntegerStateA >= 65534) {
                     this.animatedEntityStates[var5].objectState.worldObjectIntegerStateA = 0;
                     this.animatedEntityStates[var5].objectState.worldObjectByteStateD = 0;
                  }
               }
            }
         }
      }
   }

   // $VF: renamed from: a (int, int, int, boolean) boolean
   public bool isTilePassable(int var1, int var2, int var3, bool var4) {
      switch (var3) {
         case 1:
            if (var1 == this.gameByteStateAQ - 1) {
               return false;
            }

            if ((this.collisionMap[var1 + 1][var2] & 240) != 0) {
               return false;
            }

            if ((this.collisionMap[var1][var2] & 8) != 0) {
               return false;
            }

            if ((this.collisionMap[var1 + 1][var2] & 2) != 0) {
               return false;
            }

            if (var4 && this.currentTileType != this.levelTileTypes[var1 + 1][var2]) {
               return false;
            } goto case 2;
         case 2:
         case 4:
         case 6:
         default:
            break;
         case 3:
            if (var2 == 0) {
               return false;
            }

            if ((this.collisionMap[var1][var2 - 1] & 240) != 0) {
               return false;
            }

            if ((this.collisionMap[var1][var2] & 1) != 0) {
               return false;
            }

            if ((this.collisionMap[var1][var2 - 1] & 4) != 0) {
               return false;
            }

            if (var4 && this.currentTileType != this.levelTileTypes[var1][var2 - 1]) {
               return false;
            }
            break;
         case 5:
            if (var1 == 0) {
               return false;
            }

            if ((this.collisionMap[var1 - 1][var2] & 240) != 0) {
               return false;
            }

            if ((this.collisionMap[var1][var2] & 2) != 0) {
               return false;
            }

            if ((this.collisionMap[var1 - 1][var2] & 8) != 0) {
               return false;
            }

            if (var4 && this.currentTileType != this.levelTileTypes[var1 - 1][var2]) {
               return false;
            }
            break;
         case 7:
            if (var2 == this.gameByteStateAR - 1) {
               return false;
            }

            if ((this.collisionMap[var1][var2 + 1] & 240) != 0) {
               return false;
            }

            if ((this.collisionMap[var1][var2] & 4) != 0) {
               return false;
            }

            if ((this.collisionMap[var1][var2 + 1] & 1) != 0) {
               return false;
            }

            if (var4 && this.currentTileType != this.levelTileTypes[var1][var2 + 1]) {
               return false;
            } break;
      }

      return true;
   }

   // $VF: renamed from: a (int, int, int, int, boolean) int
   public int resolveCollision(int var1, int var2, int var3, int var4, bool var5) {
      int var6;
      int var7;
      if (var4 == 1) {
         var6 = var2 + 1;
         var7 = var3;
      } else if (var4 == 7) {
         var6 = var2;
         var7 = var3 + 1;
      } else if (var4 == 5) {
         var6 = var2 - 1;
         var7 = var3;
      } else {
         if (var4 != 3) {
            return -1;
         }

         var6 = var2;
         var7 = var3 - 1;
      }

      return this.isActorAtTile(var1, var6, var7, var5);
   }

   // $VF: renamed from: b (int, int, int, boolean) int
   public int isActorAtTile(int var1, int var2, int var3, bool var4) {
      if (var4) {
         return this.primaryCharacterState.characterAnimationObjectReferenceA.tileX == var2 && this.primaryCharacterState.characterAnimationObjectReferenceA.tileY == var3 && this.primaryCharacterState.characterAnimationObjectReferenceA.isActive ? 1 : -1;
      } else {
         for (int var5 = 2; var5 < 24; var5++) {
            if (var5 != var1
               && this.actorStates[var5].isActive
               && this.actorStates[var5].animationFrameIndex != 3
               && this.actorStates[var5].animationFrameIndex != 4
               && this.actorStates[var5].tileX == var2
               && this.actorStates[var5].tileY == var3) {
               return var5;
            }
         }

         return -1;
      }
   }

   // $VF: renamed from: d (u, int) void
   public void setActorAnimationState(ActorRuntimeState var1, int var2) {
      sbyte var3;
      sbyte var4;
      bool var6;
      short[][] var8;
      if (var2 == 1) {
         var3 = (sbyte)(var1.tileX + 1);
         var4 = var1.tileY;
         var6 = false;
         var8 = this.levelTileHeights;
      } else if (var2 == 7) {
         var3 = var1.tileX;
         var4 = (sbyte)(var1.tileY + 1);
         var6 = true;
         var8 = this.levelTileWidths;
      } else if (var2 == 5) {
         var3 = (sbyte)(var1.tileX - 1);
         var4 = var1.tileY;
         var6 = false;
         var8 = this.levelTileHeights;
      } else {
         if (var2 != 3) {
            return;
         }

         var3 = var1.tileX;
         var4 = (sbyte)(var1.tileY - 1);
         var6 = true;
         var8 = this.levelTileWidths;
      }

      if (this.levelTileTypes[var1.tileX][var1.tileY] != this.levelTileTypes[var3][var4]) {
         if (!this.gameFlagE && var8[JMath.max(var1.tileX, var3)][JMath.max(var1.tileY, var4)] != -1) {
            return;
         }

         int var7 = this.findWorldObjectAtTile(var3, var4, var2);
         if (var7 != -1) {
            ActorAnimationState var5 = this.levelObjects[var7];
            if (var5.actorAnimationFlagA) {
               if (var5.actorAnimationFlagD == var6 && var5.actorAnimationFlagB) {
                  return;
               }
            } else if (var5.actorAnimationFlagB) {
               return;
            }
         }
      }

      var1.tileX = var3;
      var1.tileY = var4;
   }

   // $VF: renamed from: b (int, int, int) int
   public int findWorldObjectAtTile(int var1, int var2, int var3) {
      for (int var4 = 0; var4 < this.levelObjectCount; var4++) {
         if (this.levelObjects[var4].actorAnimationFlagB && this.levelObjects[var4].actorAnimationFlagC) {
            sbyte var5 = this.levelObjects[var4].actorAnimationByteStateA;
            if (this.levelObjectProperties[var5][6] == 0) {
               if (this.levelObjects[var4].actorAnimationFlagD) {
                  if (this.containsPoint(
                     var1, var2, this.levelObjects[var4].actorAnimationByteStateB, this.levelObjects[var4].actorAnimationByteStateC, this.levelObjectProperties[var5][5], this.levelObjectProperties[var5][4]
                  )) {
                     return var4;
                  }
               } else if (this.containsPoint(
                  var1, var2, this.levelObjects[var4].actorAnimationByteStateB, this.levelObjects[var4].actorAnimationByteStateC, this.levelObjectProperties[var5][4], this.levelObjectProperties[var5][5]
               )) {
                  return var4;
               }
            } else if (var3 == 1) {
               if (!this.levelObjects[var4].actorAnimationFlagD
                  && this.containsPoint(var1, var2, this.levelObjects[var4].actorAnimationByteStateB, this.levelObjects[var4].actorAnimationByteStateC, this.levelObjectProperties[var5][4], this.levelObjectProperties[var5][5])
                  )
                {
                  return var4;
               }
            } else if (var3 == 7) {
               if (this.levelObjects[var4].actorAnimationFlagD
                  && this.containsPoint(var1, var2, this.levelObjects[var4].actorAnimationByteStateB, this.levelObjects[var4].actorAnimationByteStateC, this.levelObjectProperties[var5][5], this.levelObjectProperties[var5][4])
                  )
                {
                  return var4;
               }
            } else if (var3 == 3) {
               if (this.levelObjects[var4].actorAnimationFlagD
                  && this.containsPoint(
                     var1, var2 + 1, this.levelObjects[var4].actorAnimationByteStateB, this.levelObjects[var4].actorAnimationByteStateC, this.levelObjectProperties[var5][5], this.levelObjectProperties[var5][4]
                  )) {
                  return var4;
               }
            } else if (var3 == 5
               && !this.levelObjects[var4].actorAnimationFlagD
               && this.containsPoint(
                  var1 + 1, var2, this.levelObjects[var4].actorAnimationByteStateB, this.levelObjects[var4].actorAnimationByteStateC, this.levelObjectProperties[var5][4], this.levelObjectProperties[var5][5]
               )) {
               return var4;
            }
         }
      }

      return -1;
   }

   // $VF: renamed from: c (u) boolean
   public bool advanceActorMovement(ActorRuntimeState var1) {
      if (var1.elapsedTimerA == this.gameClockTimeMs) {
         return false;
      } else {
         return var1.targetTileX < 0 || var1.targetTileY < 0 ? true : var1.tileX == var1.targetTileX && var1.tileY == var1.targetTileY;
      }
   }

   // $VF: renamed from: K () void
   public void updatePlayerAction() {
      if (this.activeCharacterState.characterAnimationObjectReferenceA.animationFrameIndex != 3 && this.activeCharacterState.characterAnimationObjectReferenceA.animationFrameIndex != 4) {
         bool var1 = false;

         for (int var2 = 0; var2 < 24; var2++) {
            if (this.actorStates[var2].isActive && this.actorStates[var2].animationFrameIndex != 4) {
               if (this.actorStates[var2].animationSetIndex == 5) {
                  if (this.currentTileType == this.levelTileTypes[this.actorStates[var2].tileX][this.actorStates[var2].tileY] && !this.actorStates[var2].actorRuntimeFlagE) {
                     var1 = true;
                  }
                  break;
               }

               if (!this.isActorActionAllowed(this.actorStates[var2])
                  && this.currentTileType == this.levelTileTypes[this.actorStates[var2].tileX][this.actorStates[var2].tileY]
                  && !this.actorStates[var2].actorRuntimeFlagE) {
                  var1 = true;
                  break;
               }
            }
         }

         if (this.gameIntegerStateG != 900 && this.gameIntegerStateG != 901) {
            if (this.gameIntegerStateG == 384) {
            }

            this.gameIntegerStateG = 900;
            if (SpriteAnimationFrameTable.characterShadowGeometry[this.activeCharacterState.characterAnimationObjectReferenceA.animationSetIndex][this.activeCharacterState.characterAnimationObjectReferenceA.animationFrameIndex][2] == 0) {
               this.drawActorShadow(this.activeCharacterState.characterAnimationObjectReferenceA, 0);
            }

            if (this.activeCharacterState.characterAnimationByteStateD != 127) {
               this.setPlayerAction(this.activeCharacterState.characterAnimationByteStateD);
               this.activeCharacterState.characterAnimationByteStateB = (sbyte)directionByState[this.activeCharacterState.characterAnimationByteStateD];
            } else {
               this.setPlayerAction(127);
            }
         }
      }
   }

   // $VF: renamed from: d (u) boolean
   public bool isActorActionAllowed(ActorRuntimeState var1) {
      return var1.animationSetIndex == 0 || var1.animationSetIndex == 1 || var1.animationSetIndex == 3 || var1.animationSetIndex == 7 || var1.animationSetIndex == 5 || var1.animationSetIndex == 10;
   }

   // $VF: renamed from: k (int) void
   public void setPlayerAction(int var1) {
      this.setCharacterAnimation(var1, this.gameByteStateAM);
   }

   // $VF: renamed from: k (int, int) void
   public void setCharacterAnimation(int var1, int var2) {
      CharacterAnimationState var3 = this.primaryCharacterState;
      if (var1 == 127) {
         var3.characterAnimationObjectReferenceA.animationOverrideFrame = 127;
      } else {
         var3.characterAnimationByteStateD = (sbyte)((var1 + 6) % 6);
         if (this.activeCharacterState.characterAnimationObjectReferenceA.animationSetIndex == 0) {
            this.activeCharacterState.characterAnimationObjectReferenceA.animationOverrideFrame = (sbyte)(0 + this.activeCharacterState.characterAnimationByteStateD);
         } else if (this.activeCharacterState.characterAnimationObjectReferenceA.animationSetIndex == 1) {
            this.activeCharacterState.characterAnimationObjectReferenceA.animationOverrideFrame = (sbyte)(5 + this.activeCharacterState.characterAnimationByteStateD);
         }

         if (var1 == 5) {
            var3.characterAnimationObjectReferenceA.animationOverrideFrame = 127;
         }

         if (this.isCharacterAnimating()) {
            this.drawActorShadow(var3.characterAnimationObjectReferenceA, 8);
         }
      }
   }

   // $VF: renamed from: o (int) void
   public void findActorInFront(int var1) {
      for (int var2 = 1; var2 < 24; var2++) {
         if (!this.actorStates[var2].actorRuntimeFlagF && var2 != var1 && this.isActorInFront(var2)) {
            this.updateActorAnimation(this.actorStates[var2], -2);
            if (this.actorStates[var2].animationSetIndex != 2 && this.actorStates[var2].animationSetIndex != 8) {
               if (this.actorStates[var2].animationSetIndex == 6 && this.actorStates[var2].actionCounter <= 0) {
                  this.actorStates[var2].optionalTimer = this.gameClockTimeMs;
                  this.useAmmunition(this.actorStates[var2].tileX, this.actorStates[var2].tileY);
               }
            } else if (this.actorStates[var2].actionCounter > 0) {
               if (this.activeCharacterState.characterAnimationByteStateD != 0) {
                  this.drawActorShadow(this.actorStates[var2], 14);
               }
            } else if (this.actorStates[var2].actionCounter <= 0) {
               this.actorStates[var2].optionalTimer = this.gameClockTimeMs;
               this.performWeaponAction(var2);
            }

            this.createWorldObject(0, this.actorStates[var2].tileX, this.actorStates[var2].tileY, 18, -16);
         }
      }
   }

   // $VF: renamed from: p (int) boolean
   public bool isActorInFront(int var1) {
      if (this.activeCharacterState.characterAnimationObjectReferenceA.movementDirection == 0) {
         if (this.actorStates[var1].tileX == this.activeCharacterState.characterAnimationObjectReferenceA.tileX + 2 && this.actorStates[var1].tileY == this.activeCharacterState.characterAnimationObjectReferenceA.tileY - 1
            || this.actorStates[var1].tileX == this.activeCharacterState.characterAnimationObjectReferenceA.tileX + 1 && this.actorStates[var1].tileY == this.activeCharacterState.characterAnimationObjectReferenceA.tileY - 2
            || this.actorStates[var1].tileX == this.activeCharacterState.characterAnimationObjectReferenceA.tileX + 1 && this.actorStates[var1].tileY == this.activeCharacterState.characterAnimationObjectReferenceA.tileY
            || this.actorStates[var1].tileX == this.activeCharacterState.characterAnimationObjectReferenceA.tileX && this.actorStates[var1].tileY == this.activeCharacterState.characterAnimationObjectReferenceA.tileY + 1) {
            return true;
         }
      } else if (this.activeCharacterState.characterAnimationObjectReferenceA.movementDirection == 4) {
         if (this.actorStates[var1].tileX == this.activeCharacterState.characterAnimationObjectReferenceA.tileX - 2 && this.actorStates[var1].tileY == this.activeCharacterState.characterAnimationObjectReferenceA.tileY + 1
            || this.actorStates[var1].tileX == this.activeCharacterState.characterAnimationObjectReferenceA.tileX - 1 && this.actorStates[var1].tileY == this.activeCharacterState.characterAnimationObjectReferenceA.tileY + 2
            || this.actorStates[var1].tileX == this.activeCharacterState.characterAnimationObjectReferenceA.tileX && this.actorStates[var1].tileY == this.activeCharacterState.characterAnimationObjectReferenceA.tileY - 1
            || this.actorStates[var1].tileX == this.activeCharacterState.characterAnimationObjectReferenceA.tileX - 1 && this.actorStates[var1].tileY == this.activeCharacterState.characterAnimationObjectReferenceA.tileY) {
            return true;
         }
      } else if (this.activeCharacterState.characterAnimationObjectReferenceA.movementDirection == 2) {
         if (this.actorStates[var1].tileX == this.activeCharacterState.characterAnimationObjectReferenceA.tileX + 2 && this.actorStates[var1].tileY == this.activeCharacterState.characterAnimationObjectReferenceA.tileY + 1
            || this.actorStates[var1].tileX == this.activeCharacterState.characterAnimationObjectReferenceA.tileX + 1 && this.actorStates[var1].tileY == this.activeCharacterState.characterAnimationObjectReferenceA.tileY + 2
            || this.actorStates[var1].tileX == this.activeCharacterState.characterAnimationObjectReferenceA.tileX && this.actorStates[var1].tileY == this.activeCharacterState.characterAnimationObjectReferenceA.tileY - 1
            || this.actorStates[var1].tileX == this.activeCharacterState.characterAnimationObjectReferenceA.tileX + 1 && this.actorStates[var1].tileY == this.activeCharacterState.characterAnimationObjectReferenceA.tileY) {
            return true;
         }
      } else if (this.activeCharacterState.characterAnimationObjectReferenceA.movementDirection == 6) {
         if (this.actorStates[var1].tileX == this.activeCharacterState.characterAnimationObjectReferenceA.tileX - 1 && this.actorStates[var1].tileY == this.activeCharacterState.characterAnimationObjectReferenceA.tileY - 2
            || this.actorStates[var1].tileX == this.activeCharacterState.characterAnimationObjectReferenceA.tileX - 2 && this.actorStates[var1].tileY == this.activeCharacterState.characterAnimationObjectReferenceA.tileY - 1
            || this.actorStates[var1].tileX == this.activeCharacterState.characterAnimationObjectReferenceA.tileX - 1 && this.actorStates[var1].tileY == this.activeCharacterState.characterAnimationObjectReferenceA.tileY
            || this.actorStates[var1].tileX == this.activeCharacterState.characterAnimationObjectReferenceA.tileX && this.actorStates[var1].tileY == this.activeCharacterState.characterAnimationObjectReferenceA.tileY + 1) {
            return true;
         }
      } else if (this.activeCharacterState.characterAnimationObjectReferenceA.movementDirection == 1) {
         if (this.actorStates[var1].tileX == this.activeCharacterState.characterAnimationObjectReferenceA.tileX + 1 && this.actorStates[var1].tileY == this.activeCharacterState.characterAnimationObjectReferenceA.tileY + 1
            || this.actorStates[var1].tileX == this.activeCharacterState.characterAnimationObjectReferenceA.tileX + 1 && this.actorStates[var1].tileY == this.activeCharacterState.characterAnimationObjectReferenceA.tileY
            || this.actorStates[var1].tileX == this.activeCharacterState.characterAnimationObjectReferenceA.tileX + 1 && this.actorStates[var1].tileY == this.activeCharacterState.characterAnimationObjectReferenceA.tileY - 1
            || this.actorStates[var1].tileX == this.activeCharacterState.characterAnimationObjectReferenceA.tileX + 2 && this.actorStates[var1].tileY == this.activeCharacterState.characterAnimationObjectReferenceA.tileY + 1
            || this.actorStates[var1].tileX == this.activeCharacterState.characterAnimationObjectReferenceA.tileX + 2 && this.actorStates[var1].tileY == this.activeCharacterState.characterAnimationObjectReferenceA.tileY
            || this.actorStates[var1].tileX == this.activeCharacterState.characterAnimationObjectReferenceA.tileX + 2 && this.actorStates[var1].tileY == this.activeCharacterState.characterAnimationObjectReferenceA.tileY - 1) {
            return true;
         }
      } else if (this.activeCharacterState.characterAnimationObjectReferenceA.movementDirection == 7) {
         if (this.actorStates[var1].tileX == this.activeCharacterState.characterAnimationObjectReferenceA.tileX - 1 && this.actorStates[var1].tileY == this.activeCharacterState.characterAnimationObjectReferenceA.tileY + 1
            || this.actorStates[var1].tileX == this.activeCharacterState.characterAnimationObjectReferenceA.tileX && this.actorStates[var1].tileY == this.activeCharacterState.characterAnimationObjectReferenceA.tileY + 1
            || this.actorStates[var1].tileX == this.activeCharacterState.characterAnimationObjectReferenceA.tileX + 1 && this.actorStates[var1].tileY == this.activeCharacterState.characterAnimationObjectReferenceA.tileY + 1
            || this.actorStates[var1].tileX == this.activeCharacterState.characterAnimationObjectReferenceA.tileX - 1 && this.actorStates[var1].tileY == this.activeCharacterState.characterAnimationObjectReferenceA.tileY + 2
            || this.actorStates[var1].tileX == this.activeCharacterState.characterAnimationObjectReferenceA.tileX && this.actorStates[var1].tileY == this.activeCharacterState.characterAnimationObjectReferenceA.tileY + 2
            || this.actorStates[var1].tileX == this.activeCharacterState.characterAnimationObjectReferenceA.tileX + 1 && this.actorStates[var1].tileY == this.activeCharacterState.characterAnimationObjectReferenceA.tileY + 2) {
            return true;
         }
      } else if (this.activeCharacterState.characterAnimationObjectReferenceA.movementDirection == 3) {
         if (this.actorStates[var1].tileX == this.activeCharacterState.characterAnimationObjectReferenceA.tileX - 1 && this.actorStates[var1].tileY == this.activeCharacterState.characterAnimationObjectReferenceA.tileY - 1
            || this.actorStates[var1].tileX == this.activeCharacterState.characterAnimationObjectReferenceA.tileX && this.actorStates[var1].tileY == this.activeCharacterState.characterAnimationObjectReferenceA.tileY - 1
            || this.actorStates[var1].tileX == this.activeCharacterState.characterAnimationObjectReferenceA.tileX + 1 && this.actorStates[var1].tileY == this.activeCharacterState.characterAnimationObjectReferenceA.tileY - 1
            || this.actorStates[var1].tileX == this.activeCharacterState.characterAnimationObjectReferenceA.tileX - 1 && this.actorStates[var1].tileY == this.activeCharacterState.characterAnimationObjectReferenceA.tileY - 2
            || this.actorStates[var1].tileX == this.activeCharacterState.characterAnimationObjectReferenceA.tileX && this.actorStates[var1].tileY == this.activeCharacterState.characterAnimationObjectReferenceA.tileY - 2
            || this.actorStates[var1].tileX == this.activeCharacterState.characterAnimationObjectReferenceA.tileX + 1 && this.actorStates[var1].tileY == this.activeCharacterState.characterAnimationObjectReferenceA.tileY - 2) {
            return true;
         }
      } else if (this.activeCharacterState.characterAnimationObjectReferenceA.movementDirection == 5
         && (
            this.actorStates[var1].tileX == this.activeCharacterState.characterAnimationObjectReferenceA.tileX - 1 && this.actorStates[var1].tileY == this.activeCharacterState.characterAnimationObjectReferenceA.tileY + 1
               || this.actorStates[var1].tileX == this.activeCharacterState.characterAnimationObjectReferenceA.tileX - 1 && this.actorStates[var1].tileY == this.activeCharacterState.characterAnimationObjectReferenceA.tileY
               || this.actorStates[var1].tileX == this.activeCharacterState.characterAnimationObjectReferenceA.tileX - 1
                  && this.actorStates[var1].tileY == this.activeCharacterState.characterAnimationObjectReferenceA.tileY - 1
               || this.actorStates[var1].tileX == this.activeCharacterState.characterAnimationObjectReferenceA.tileX - 2
                  && this.actorStates[var1].tileY == this.activeCharacterState.characterAnimationObjectReferenceA.tileY + 1
               || this.actorStates[var1].tileX == this.activeCharacterState.characterAnimationObjectReferenceA.tileX - 2 && this.actorStates[var1].tileY == this.activeCharacterState.characterAnimationObjectReferenceA.tileY
               || this.actorStates[var1].tileX == this.activeCharacterState.characterAnimationObjectReferenceA.tileX - 2
                  && this.actorStates[var1].tileY == this.activeCharacterState.characterAnimationObjectReferenceA.tileY - 1
         )) {
         return true;
      }

      return false;
   }

   // $VF: renamed from: aO () void
   public void updateCharacterEffects() {
      int var1 = 0;
      int var2 = 0;
      if (this.activeCharacterState.characterAnimationObjectReferenceA.animationFrameIndex != 3 && this.activeCharacterState.characterAnimationObjectReferenceA.animationFrameIndex != 4) {
         if ((this.gameIntegerStateA & 128) != 0 && this.isCheatModeEnabled) {
            if (this.gameByteStateAZ == 1) {
               this.disposeAudioManager();
               this.setPendingMessage(this.localizedText[22]);
               this.gameByteStateBC++;
               this.gameIntegerStateG = 138;
               this.gameByteStateAJ = 0;
               this.configureBriefingMenu();
               this.setCharacterPortraitIndices((sbyte)0, (sbyte)1);
            } else if (this.gameByteStateAZ == 0) {
               this.disposeAudioManager();
               screenActionCodeB = 19;
               screenActionCodeC = 5;
               this.resetGameSession((sbyte)3, false);
            }
         }

         if ((this.gameIntegerStateA & 512) != 0 && this.gameIntegerStateG != 138) {
            this.disposeAudioManager();
            this.beginScreenInitialization();
            this.setCharacterPortraitIndices((sbyte)0, (sbyte)2);
         }

         if (this.gameIntegerStateG != 138) {
            if ((this.gameIntegerStateA & 32) != 0 || (this.gameIntegerStateA & 16384) != 0) {
               if (this.isCharacterOnWorldObject()) {
                  return;
               }

               if (this.activeCharacterState.characterAnimationByteStateB == 5 && this.activeCharacterState.characterAnimationObjectReferenceA.targetTileX == -1 && this.activeCharacterState.characterAnimationObjectReferenceA.targetTileY == -1) {
                  this.consumeAmmunition();
                  return;
               }

               if (this.activeCharacterState.characterAnimationByteStateD == 127) {
                  return;
               }
            }

            if ((this.gameByteStateAU & 4) == 0 && (this.gameByteStateAU & 8192) == 0) {
               if ((this.gameByteStateAU & 2) == 0 && (this.gameByteStateAU & '\u8000') == 0) {
                  if ((this.gameByteStateAU & 16) == 0 && (this.gameByteStateAU & 2048) == 0) {
                     if ((this.gameByteStateAU & 8) != 0 || (this.gameByteStateAU & 131072) != 0) {
                        if (this.isCharacterAnimating()) {
                           this.setActorDirection(this.activeCharacterState.characterAnimationObjectReferenceA, 2);
                           this.drawActorShadow(this.activeCharacterState.characterAnimationObjectReferenceA, 1);
                        } else {
                           this.activeCharacterState.characterAnimationObjectReferenceA.elapsedTimerA = this.gameClockTimeMs;
                        }
                     }
                  } else if (this.isCharacterAnimating()) {
                     this.setActorDirection(this.activeCharacterState.characterAnimationObjectReferenceA, 6);
                     this.drawActorShadow(this.activeCharacterState.characterAnimationObjectReferenceA, 1);
                  } else {
                     this.activeCharacterState.characterAnimationObjectReferenceA.elapsedTimerA = this.gameClockTimeMs;
                  }
               } else if (this.isCharacterAnimating()) {
                  this.setActorDirection(this.activeCharacterState.characterAnimationObjectReferenceA, 4);
                  this.drawActorShadow(this.activeCharacterState.characterAnimationObjectReferenceA, 1);
               } else {
                  this.activeCharacterState.characterAnimationObjectReferenceA.elapsedTimerA = this.gameClockTimeMs;
               }
            } else if (this.isCharacterAnimating()) {
               this.setActorDirection(this.activeCharacterState.characterAnimationObjectReferenceA, 0);
               this.drawActorShadow(this.activeCharacterState.characterAnimationObjectReferenceA, 1);
            } else {
               this.activeCharacterState.characterAnimationObjectReferenceA.elapsedTimerA = this.gameClockTimeMs;
            }

            if ((this.gameIntegerStateA & 262144) != 0) {
               if (this.activeCharacterState.characterAnimationByteStateD == 127) {
                  return;
               }

               do {
                  this.activeCharacterState.characterAnimationByteStateD--;
               } while (this.activeCharacterState.characterAnimationByteStateD >= 0 && !this.activeCharacterState.characterAnimationFlagArrayA[this.activeCharacterState.characterAnimationByteStateD]);

               if (this.activeCharacterState.characterAnimationByteStateD < 0) {
                  this.activeCharacterState.characterAnimationByteStateD = 5;

                  while (!this.activeCharacterState.characterAnimationFlagArrayA[this.activeCharacterState.characterAnimationByteStateD]) {
                     this.activeCharacterState.characterAnimationByteStateD--;
                  }
               }

               this.activeCharacterState.characterAnimationByteStateB = this.activeCharacterState.characterAnimationByteStateD;
               if ((this.gameIntegerStateG & 512) != 0) {
                  this.setPlayerAction(this.activeCharacterState.characterAnimationByteStateD);
               }
            } else if ((this.gameIntegerStateA & 65536) != 0 || (this.gameIntegerStateA & 256) != 0) {
               if (this.activeCharacterState.characterAnimationByteStateD == 127) {
                  return;
               }

               do {
                  this.activeCharacterState.characterAnimationByteStateD++;
               } while (this.activeCharacterState.characterAnimationByteStateD <= 5 && !this.activeCharacterState.characterAnimationFlagArrayA[this.activeCharacterState.characterAnimationByteStateD]);

               if (this.activeCharacterState.characterAnimationByteStateD > 5) {
                  this.activeCharacterState.characterAnimationByteStateD = 0;

                  while (!this.activeCharacterState.characterAnimationFlagArrayA[this.activeCharacterState.characterAnimationByteStateD]) {
                     this.activeCharacterState.characterAnimationByteStateD++;
                  }
               }

               this.activeCharacterState.characterAnimationByteStateB = this.activeCharacterState.characterAnimationByteStateD;
               if ((this.gameIntegerStateG & 512) != 0) {
                  this.setPlayerAction(this.activeCharacterState.characterAnimationByteStateD);
               }
            }
         }

         switch (this.gameIntegerStateG) {
            case 138:
               switch (this.gameByteStateAJ) {
                  case 0:
                     this.mainMenu.b(this.gameIntegerStateB);
                     if (this.mainMenu.b()) {
                        if (this.mainMenu.a() == menuOptionIndexK) {
                           this.setPendingMessage(this.localizedText[22]);
                           this.gameByteStateAJ = 1;
                           this.setCharacterPortraitIndices((sbyte)0, (sbyte)2);
                           this.updateTickCount = 0;
                           this.gameFlagP = false;
                           this.gameFlagQ = false;
                        } else if (this.mainMenu.a() == menuOptionIndexL) {
                           this.setPendingMessage(this.localizedText[23]);
                           this.gameByteStateAJ = 2;
                           this.setCharacterPortraitIndices((sbyte)0, (sbyte)2);
                           this.updateTickCount = 0;
                           this.gameFlagP = false;
                           this.gameFlagQ = false;
                        } else if (this.mainMenu.a() == menuOptionIndexM) {
                           if (this.gameByteStateBC >= this.animationDefinitions[this.gameByteStateBE][4]) {
                              this.gameByteStateBC = 0;
                              this.gameByteStateBE++;
                              if (this.gameByteStateBE > this.gameByteStateBD) {
                                 this.gameByteStateBE = (sbyte)(this.gameByteStateBD - 2);
                                 this.gameByteStateBF++;
                                 if (this.gameByteStateBF > 99) {
                                    this.gameByteStateBF = 99;
                                 }
                              }
                           }

                           this.processGameState();
                           this.gameLongValueD = this.gameClockTimeMs;
                           this.gameByteStateAV = 0;
                           this.gameByteStateAX = 0;
                           this.gameByteStateAW = 0;
                           this.gameIntegerStateG = 384;
                           this.setCharacterPortraitIndices((sbyte)5, (sbyte)3);
                           this.gameIntegerStateA = 0;
                           this.gameIntegerStateB = 0;
                           this.gameIntegerStateC = 0;
                           this.updateTickCount = 0;
                           this.activeCharacterState.characterAnimationObjectReferenceA.targetTileX = -1;
                           this.activeCharacterState.characterAnimationObjectReferenceA.targetTileY = -1;
                           this.drawActorShadow(this.activeCharacterState.characterAnimationObjectReferenceA, 0);
                           this.playAudioCue(0, 1);
                           this.playMusicTrack((sbyte)2);
                           this.updatePlayerAction();
                        }
                     }

                     if ((this.gameIntegerStateA & 512) != 0) {
                        if (this.gameByteStateBC >= this.animationDefinitions[this.gameByteStateBE][4]) {
                           this.gameByteStateBC = 0;
                           this.gameByteStateBE++;
                           if (this.gameByteStateBE > this.gameByteStateBD) {
                              this.gameByteStateBE = (sbyte)(this.gameByteStateBD - 2);
                              this.gameByteStateBF++;
                           }
                        }

                        this.processGameState();
                        this.gameLongValueD = this.gameClockTimeMs;
                        this.gameByteStateAV = 0;
                        this.gameByteStateAX = 0;
                        this.gameByteStateAW = 0;
                        this.gameFlagP = false;
                        this.gameFlagQ = false;
                        this.gameIntegerStateG = 384;
                        this.setCharacterPortraitIndices((sbyte)5, (sbyte)3);
                        this.gameIntegerStateA = 0;
                        this.gameIntegerStateB = 0;
                        this.gameIntegerStateC = 0;
                        this.updateTickCount = 0;
                        this.activeCharacterState.characterAnimationObjectReferenceA.targetTileX = -1;
                        this.activeCharacterState.characterAnimationObjectReferenceA.targetTileY = -1;
                        this.drawActorShadow(this.activeCharacterState.characterAnimationObjectReferenceA, 0);
                        this.playAudioCue(0, 1);
                        this.playMusicTrack((sbyte)2);
                        this.updatePlayerAction();
                     }

                     return;
                  case 1:
                     if ((this.gameIntegerStateA & 32) == 0 && (this.gameIntegerStateA & 256) == 0 && (this.gameIntegerStateA & 16384) == 0) {
                        if ((this.gameIntegerStateA & 2) == 0 && (this.gameIntegerStateA & 32768) == 0) {
                           if ((this.gameIntegerStateA & 4) != 0 || (this.gameIntegerStateA & 8192) != 0) {
                              if (!this.gameFlagO) {
                                 this.gameFlagL = false;
                              } else {
                                 this.gameFlagM = !this.gameFlagM;
                              }

                              this.gameFlagN = false;
                           }
                        } else {
                           if (!this.gameFlagO) {
                              this.gameFlagL = true;
                              this.selectedItemPage = 0;
                           } else {
                              this.gameFlagM = !this.gameFlagM;
                           }

                           this.gameFlagN = false;
                        }

                        if ((this.gameIntegerStateA & 8) == 0 && (this.gameIntegerStateA & 131072) == 0) {
                           if ((this.gameIntegerStateA & 16) != 0 || (this.gameIntegerStateA & 2048) != 0) {
                              if (!this.gameFlagO) {
                                 if (this.gameFlagL) {
                                    this.selectedItemIndex++;
                                    if (this.selectedItemIndex > this.gameByteStateBG - 1) {
                                       this.selectedItemIndex = this.gameByteStateBG - 1;
                                    }
                                 } else {
                                    this.selectedItemPage++;
                                    if (this.selectedItemPage >= 2) {
                                       this.selectedItemPage = 2;
                                    }
                                 }
                              }

                              this.gameFlagN = false;
                           }
                        } else {
                           if (!this.gameFlagO) {
                              if (this.gameFlagL) {
                                 this.selectedItemIndex--;
                                 if (this.selectedItemIndex < 0) {
                                    this.selectedItemIndex = 0;
                                 }
                              } else {
                                 this.selectedItemPage--;
                                 if (this.selectedItemPage <= 0) {
                                    this.selectedItemPage = 0;
                                 }
                              }
                           }

                           this.gameFlagN = false;
                        }

                        if ((this.gameIntegerStateA & 512) != 0) {
                           if (!this.gameFlagO) {
                              this.setPendingMessage(this.localizedText[21]);
                              this.gameByteStateAJ = 0;
                              this.selectedItemIndex = 0;
                              this.selectedItemPage = 0;
                              this.gameFlagL = true;
                              this.gameFlagM = false;
                              this.setCharacterPortraitIndices((sbyte)0, (sbyte)1);
                           } else {
                              this.gameFlagO = false;
                              this.gameFlagM = false;
                           }

                           this.gameFlagN = false;
                        }

                        return;
                     }

                     if (!this.gameFlagL) {
                        if (this.gameFlagO) {
                           if (this.gameFlagM) {
                              if (this.levelGrid[this.gameByteStateArrayB[this.selectedItemIndex]][this.selectedItemPage] < 3) {
                                 sbyte var6 = this.getSelectedItemDirection();
                                 this.gameIntegerStateAI = this.gameIntegerStateAI - this.itemPriceByCategoryAndLevel[var6][this.gameByteStateArrayB[this.selectedItemIndex]];
                                 this.levelGrid[this.gameByteStateArrayB[this.selectedItemIndex]][this.selectedItemPage]++;
                              }

                              this.gameFlagM = false;
                           }

                           this.gameFlagO = false;
                        } else {
                           sbyte var7 = this.getSelectedItemDirection();
                           if (this.gameIntegerStateAI >= this.itemPriceByCategoryAndLevel[var7][this.gameByteStateArrayB[this.selectedItemIndex]]) {
                              if (this.levelGrid[this.gameByteStateArrayB[this.selectedItemIndex]][this.selectedItemPage] < 3) {
                                 this.gameFlagO = true;
                              }
                           } else if (this.levelGrid[this.gameByteStateArrayB[this.selectedItemIndex]][this.selectedItemPage] < 3) {
                              this.gameFlagN = true;
                           }
                        }
                     } else {
                        this.gameFlagL = false;
                        this.selectedItemPage = 0;
                     }

                     return;
                  case 2:
                     this.gameFlagL = false;
                     if ((this.gameIntegerStateA & 32) != 0 || (this.gameIntegerStateA & 256) != 0 || (this.gameIntegerStateA & 16384) != 0) {
                        if (!this.gameFlagO) {
                           if (this.selectedItemIndex < 5) {
                              if (this.gameIntegerStateAI >= this.gameplayPriceMultipliers[this.selectedItemIndex]) {
                                 if (this.activeCharacterState.characterAnimationFlagArrayA[this.selectedItemIndex + 1]) {
                                    this.gameFlagO = true;
                                 }
                              } else if (this.activeCharacterState.characterAnimationFlagArrayA[this.selectedItemIndex + 1]) {
                                 this.gameFlagN = true;
                              }
                           } else if (!this.gameFlagP) {
                              if (this.gameIntegerStateAI >= this.gameplayPriceMultipliers[this.selectedItemIndex]) {
                                 if (!this.activeCharacterState.characterAnimationFlagArrayA[this.selectedItemIndex - 3]) {
                                    this.gameFlagP = true;
                                    this.gameFlagQ = false;
                                 }
                              } else if (!this.activeCharacterState.characterAnimationFlagArrayA[this.selectedItemIndex - 3]) {
                                 this.gameFlagN = true;
                              }
                           } else {
                              if (this.gameFlagQ && !this.activeCharacterState.characterAnimationFlagArrayA[this.selectedItemIndex - 3]) {
                                 this.activeCharacterState.characterAnimationFlagArrayA[this.selectedItemIndex - 3] = true;
                                 switch (this.selectedItemIndex - 3) {
                                    case 2:
                                       this.activeCharacterState.characterAnimationByteStateArrayA[2] = (sbyte)(this.activeCharacterState.characterAnimationByteStateArrayA[2] + 5);
                                       break;
                                    case 3:
                                       this.activeCharacterState.characterAnimationByteStateArrayA[3] = (sbyte)(this.activeCharacterState.characterAnimationByteStateArrayA[3] + 10);
                                       break;
                                    case 4:
                                       this.activeCharacterState.characterAnimationByteStateArrayA[4] = (sbyte)(this.activeCharacterState.characterAnimationByteStateArrayA[4] + 5); break;
                                 }

                                 this.gameIntegerStateAI = this.gameIntegerStateAI - this.gameplayPriceMultipliers[this.selectedItemIndex];
                              }

                              this.gameFlagP = false;
                           }
                        } else {
                           this.activeCharacterState.characterAnimationByteStateArrayA[this.selectedItemIndex + 1] = (sbyte)(this.activeCharacterState.characterAnimationByteStateArrayA[this.selectedItemIndex + 1] + this.gameByteStateBI);
                           this.gameIntegerStateAI = this.gameIntegerStateAI - this.gameByteStateBI * this.gameplayPriceMultipliers[this.selectedItemIndex];
                           this.gameFlagO = false;
                           this.gameByteStateBI = 0;
                        }

                        return;
                     }

                     if ((this.gameIntegerStateA & 8) == 0 && (this.gameIntegerStateA & 131072) == 0) {
                        if ((this.gameIntegerStateA & 16) == 0 && (this.gameIntegerStateA & 2048) == 0) {
                           if ((this.gameIntegerStateA & 4) == 0 && (this.gameIntegerStateA & 8192) == 0) {
                              if ((this.gameIntegerStateA & 2) != 0 || (this.gameIntegerStateA & 32768) != 0) {
                                 if (this.gameFlagO) {
                                    this.gameByteStateBI = (sbyte)(this.gameByteStateBI - 10);
                                    if (this.gameByteStateBI < 0) {
                                       this.gameByteStateBI = 0;
                                    }
                                 } else if (this.gameFlagP) {
                                    this.gameFlagQ = !this.gameFlagQ;
                                 }

                                 this.gameFlagN = false;
                              }
                           } else {
                              if (this.gameFlagO) {
                                 this.gameByteStateBI = (sbyte)(this.gameByteStateBI + 10);
                                 if (this.gameByteStateBI * this.gameplayPriceMultipliers[this.selectedItemIndex] > this.gameIntegerStateAI) {
                                    this.gameByteStateBI = (sbyte)(this.gameIntegerStateAI / this.gameplayPriceMultipliers[this.selectedItemIndex]);
                                 }

                                 if (this.gameByteStateBI > this.itemPriceByLevel[this.selectedItemIndex + 1] - this.activeCharacterState.characterAnimationByteStateArrayA[this.selectedItemIndex + 1]) {
                                    this.gameByteStateBI = (sbyte)(this.itemPriceByLevel[this.selectedItemIndex + 1] - this.activeCharacterState.characterAnimationByteStateArrayA[this.selectedItemIndex + 1]);
                                 }
                              } else if (this.gameFlagP) {
                                 this.gameFlagQ = !this.gameFlagQ;
                              }

                              this.gameFlagN = false;
                           }
                        } else {
                           if (this.gameFlagP) {
                              return;
                           }

                           if (!this.gameFlagO) {
                              this.selectedItemIndex++;
                              if (this.selectedItemIndex > this.gameByteStateBH - 1) {
                                 this.selectedItemIndex = this.gameByteStateBH - 1;
                              }

                              this.updateTickCount = 0;
                           } else {
                              this.gameByteStateBI--;
                              if (this.gameByteStateBI < 0) {
                                 this.gameByteStateBI = 0;
                              }
                           }

                           this.gameFlagN = false;
                        }
                     } else {
                        if (this.gameFlagP) {
                           return;
                        }

                        if (!this.gameFlagO) {
                           this.selectedItemIndex--;
                           if (this.selectedItemIndex < 0) {
                              this.selectedItemIndex = 0;
                           }

                           this.updateTickCount = 0;
                        } else {
                           this.gameByteStateBI++;
                           if (this.gameByteStateBI > this.itemPriceByLevel[this.selectedItemIndex + 1] - this.activeCharacterState.characterAnimationByteStateArrayA[this.selectedItemIndex + 1]) {
                              this.gameByteStateBI = (sbyte)(this.itemPriceByLevel[this.selectedItemIndex + 1] - this.activeCharacterState.characterAnimationByteStateArrayA[this.selectedItemIndex + 1]);
                           }

                           if (this.gameByteStateBI * this.gameplayPriceMultipliers[this.selectedItemIndex] > this.gameIntegerStateAI) {
                              this.gameByteStateBI--;
                           }
                        }

                        this.gameFlagN = false;
                     }

                     if ((this.gameIntegerStateA & 512) != 0) {
                        if (!this.gameFlagO && !this.gameFlagP) {
                           this.setPendingMessage(this.localizedText[21]);
                           this.gameByteStateAJ = 0;
                           this.selectedItemIndex = 0;
                           this.selectedItemPage = 0;
                           this.gameFlagL = true;
                           this.setCharacterPortraitIndices((sbyte)0, (sbyte)1);
                        } else {
                           this.gameFlagO = false;
                           this.gameFlagP = false;
                           this.gameFlagQ = false;
                           this.gameByteStateBI = 0;
                        }

                        this.gameFlagN = false;
                     }

                     return;
                  default:
                     return;
               } goto case 384;
            case 384:
               if ((this.gameIntegerStateA & 64) != 0 && this.isCheatModeEnabled) {
                  this.spawnActor(2, 6, 6, 7);
                  this.updatePlayerAction();
               }
               break;
            case 646:
               if (this.actorStates[this.gameIntegerStateN].animationSetIndex != 5) {
                  switch (this.activeCharacterState.characterAnimationByteStateD) {
                     default:
                        int var4 = nextRandomBelow(100);
                        sbyte var5;
                        if (var4 < 3) {
                           var5 = 0;
                        } else if (var4 < 90 - this.itemPriceByCategoryAndLevel[this.getInventoryFacingDirection((sbyte)1)][this.activeCharacterState.characterAnimationByteStateD]) {
                           var5 = 1;
                        } else {
                           var5 = 2;
                        }

                        if (var5 == 2) {
                           this.playerCredits++;
                           if (this.activeCharacterState.characterAnimationByteStateD != 0) {
                              this.playerAmmo++;
                           }

                           if (this.activeCharacterState.characterAnimationByteStateD == 0) {
                              this.updateActorAnimation(this.actorStates[this.gameIntegerStateN], -10);
                              if ((this.actorStates[this.gameIntegerStateN].animationSetIndex == 5 || this.actorStates[this.gameIntegerStateN].animationSetIndex == 2)
                                 && this.actorStates[this.gameIntegerStateN].actionCounter > 0) {
                                 this.drawActorShadow(this.actorStates[this.gameIntegerStateN], 14);
                              }
                           } else if (this.activeCharacterState.characterAnimationByteStateD == 1) {
                              this.updateActorAnimation(this.actorStates[this.gameIntegerStateN], -10);
                              if ((this.actorStates[this.gameIntegerStateN].animationSetIndex == 5 || this.actorStates[this.gameIntegerStateN].animationSetIndex == 2)
                                 && this.actorStates[this.gameIntegerStateN].actionCounter > 0) {
                                 this.drawActorShadow(this.actorStates[this.gameIntegerStateN], 14);
                              }
                           } else if (this.activeCharacterState.characterAnimationByteStateD == 2) {
                              this.updateActorAnimation(this.actorStates[this.gameIntegerStateN], -30);
                              if (this.actorStates[this.gameIntegerStateN].animationSetIndex == 5 && this.actorStates[this.gameIntegerStateN].actionCounter > 0) {
                                 this.drawActorShadow(this.actorStates[this.gameIntegerStateN], 14);
                              }
                           } else if (this.activeCharacterState.characterAnimationByteStateD == 3) {
                              this.updateActorAnimation(this.actorStates[this.gameIntegerStateN], -20);
                              if (this.actorStates[this.gameIntegerStateN].animationSetIndex == 5 && this.actorStates[this.gameIntegerStateN].actionCounter > 0) {
                                 this.drawActorShadow(this.actorStates[this.gameIntegerStateN], 14);
                              }
                           }

                           if (this.actorStates[this.gameIntegerStateN].animationSetIndex != 2 && this.actorStates[this.gameIntegerStateN].animationSetIndex != 8) {
                              if (this.actorStates[this.gameIntegerStateN].animationSetIndex == 6 && this.actorStates[this.gameIntegerStateN].actionCounter <= 0) {
                                 this.actorStates[this.gameIntegerStateN].optionalTimer = this.gameClockTimeMs;
                                 this.useAmmunition(this.actorStates[this.gameIntegerStateN].tileX, this.actorStates[this.gameIntegerStateN].tileY);
                              }
                           } else if (this.actorStates[this.gameIntegerStateN].actionCounter > 0) {
                              this.drawActorShadow(this.actorStates[this.gameIntegerStateN], 14);
                           } else if (this.actorStates[this.gameIntegerStateN].actionCounter <= 0) {
                              this.actorStates[this.gameIntegerStateN].optionalTimer = this.gameClockTimeMs;
                              this.performWeaponAction(this.gameIntegerStateN);
                           }

                           this.gameIntegerStateH = 100;
                           this.createWorldObject(0, this.actorStates[this.gameIntegerStateN].tileX, this.actorStates[this.gameIntegerStateN].tileY, 18, -16);
                        } else if (var5 == 0) {
                           this.playerHealth++;
                           this.playerGrenades++;
                           this.createWorldObject(1, this.gameIntegerStateO, this.gameIntegerStateP, 18, 9);
                        } else {
                           if (this.activeCharacterState.characterAnimationByteStateD != 0) {
                              this.playerAmmo++;
                           }

                           if (this.activeCharacterState.characterAnimationByteStateD == 1) {
                              this.updateActorAnimation(this.actorStates[this.gameIntegerStateN], -this.itemPriceByCategoryAndLevel[this.getInventoryFacingDirection((sbyte)2)][1]);
                           } else if (this.activeCharacterState.characterAnimationByteStateD == 2) {
                              this.updateActorAnimation(this.actorStates[this.gameIntegerStateN], -this.itemPriceByCategoryAndLevel[this.getInventoryFacingDirection((sbyte)2)][2]);
                           } else if (this.activeCharacterState.characterAnimationByteStateD == 3) {
                              this.updateActorAnimation(this.actorStates[this.gameIntegerStateN], -this.itemPriceByCategoryAndLevel[this.getInventoryFacingDirection((sbyte)2)][3]);
                              this.findActorInFront(this.gameIntegerStateN);
                           }

                           this.updateActorAnimation(this.actorStates[this.gameIntegerStateN], -1);
                           if (this.actorStates[this.gameIntegerStateN].animationSetIndex != 2 && this.actorStates[this.gameIntegerStateN].animationSetIndex != 8) {
                              if (this.actorStates[this.gameIntegerStateN].animationSetIndex == 6 && this.actorStates[this.gameIntegerStateN].actionCounter <= 0) {
                                 this.actorStates[this.gameIntegerStateN].optionalTimer = this.gameClockTimeMs;
                                 this.useAmmunition(this.actorStates[this.gameIntegerStateN].tileX, this.actorStates[this.gameIntegerStateN].tileY);
                              }
                           } else if (this.actorStates[this.gameIntegerStateN].actionCounter > 0) {
                              if (this.activeCharacterState.characterAnimationByteStateD != 0) {
                                 this.drawActorShadow(this.actorStates[this.gameIntegerStateN], 14);
                              }
                           } else if (this.actorStates[this.gameIntegerStateN].actionCounter <= 0) {
                              this.actorStates[this.gameIntegerStateN].optionalTimer = this.gameClockTimeMs;
                              this.performWeaponAction(this.gameIntegerStateN);
                           }

                           this.createWorldObject(0, this.actorStates[this.gameIntegerStateN].tileX, this.actorStates[this.gameIntegerStateN].tileY, 18, -16);
                        }

                        if (this.activeCharacterState.characterAnimationByteStateD != 0) {
                           if (this.activeCharacterState.characterAnimationObjectReferenceA.animationSetIndex == 0) {
                              if (this.activeCharacterState.characterAnimationByteStateD == 3) {
                                 this.createWorldObject(
                                    13 + this.activeCharacterState.characterAnimationObjectReferenceA.movementDirection, this.activeCharacterState.characterAnimationObjectReferenceA.tileX, this.activeCharacterState.characterAnimationObjectReferenceA.tileY, 0, 0
                                 );
                              } else {
                                 this.createWorldObject(5 + this.activeCharacterState.characterAnimationObjectReferenceA.movementDirection, this.activeCharacterState.characterAnimationObjectReferenceA.tileX, this.activeCharacterState.characterAnimationObjectReferenceA.tileY, 0, 0);
                              }
                           } else if (this.activeCharacterState.characterAnimationByteStateD == 3) {
                              this.createWorldObject(29 + this.activeCharacterState.characterAnimationObjectReferenceA.movementDirection, this.activeCharacterState.characterAnimationObjectReferenceA.tileX, this.activeCharacterState.characterAnimationObjectReferenceA.tileY, 0, 0);
                           } else {
                              this.createWorldObject(21 + this.activeCharacterState.characterAnimationObjectReferenceA.movementDirection, this.activeCharacterState.characterAnimationObjectReferenceA.tileX, this.activeCharacterState.characterAnimationObjectReferenceA.tileY, 0, 0);
                           }
                        }

                        this.shiftAnimationStartTimes((int)(this.gameClockTimeMs - this.gameLongValueC));
                        if (this.activeCharacterState.characterAnimationByteStateD != 0) {
                           this.drawActorShadow(this.activeCharacterState.characterAnimationObjectReferenceA, 5);
                           if (!this.isCheatModeEnabled) {
                              this.activeCharacterState.characterAnimationByteStateArrayA[this.activeCharacterState.characterAnimationByteStateD]--;
                           }

                           this.gameIntegerStateG = 900;
                        } else {
                           this.drawActorShadow(this.activeCharacterState.characterAnimationObjectReferenceA, 7);
                           this.gameIntegerStateG = 900;
                        }

                        if (this.activeCharacterState.characterAnimationByteStateD != 5) {
                           this.entityTimeOffsets[this.activeCharacterState.characterAnimationByteStateD] = JSystem.currentTimeMillis()
                              + (long)this.itemPriceByCategoryAndLevel[this.getInventoryFacingDirection((sbyte)0)][this.activeCharacterState.characterAnimationByteStateD];
                        } break;
                  }
               } goto case 647;
            case 647:
            case 904:
            default:
               break;
            case 900:
               if (((this.gameIntegerStateA & 32) != 0 || (this.gameIntegerStateA & 16384) != 0)
                  && this.activeCharacterState.characterAnimationObjectReferenceA.targetTileX == -1
                  && this.activeCharacterState.characterAnimationObjectReferenceA.targetTileY == -1) {
                  if (!this.activeCharacterState.characterAnimationFlagArrayA[this.activeCharacterState.characterAnimationByteStateD]) {
                     return;
                  }

                  if (!this.isCharacterActionComplete()) {
                     return;
                  }

                  this.entityTimeOffsets[this.activeCharacterState.characterAnimationByteStateD] = this.gameClockTimeMs + (long)this.itemPriceByCategoryAndLevel[this.getInventoryFacingDirection((sbyte)0)][this.activeCharacterState.characterAnimationByteStateD];
                  if (this.gameFlagK && this.activeCharacterState.characterAnimationByteStateD != 0) {
                     if (this.activeCharacterState.characterAnimationByteStateArrayA[this.activeCharacterState.characterAnimationByteStateD] <= 0) {
                        return;
                     }

                     int var3 = this.findNearbyActor(this.activeCharacterState.characterAnimationObjectReferenceA);
                     if (var3 != -1 && this.activeCharacterState.characterAnimationByteStateD != 4) {
                        this.faceActorTowardTile(this.activeCharacterState.characterAnimationObjectReferenceA, this.actorStates[var3].tileX, this.actorStates[var3].tileY);
                        this.gameFlagI = true;
                        this.gameIntegerStateO = this.actorStates[var3].tileX;
                        this.gameIntegerStateP = this.actorStates[var3].tileY;
                        this.gameLongValueB = this.gameClockTimeMs;
                        if (this.activeCharacterState.characterAnimationByteStateD == 1 || this.activeCharacterState.characterAnimationByteStateD == 2) {
                           this.drawActorShadow(this.activeCharacterState.characterAnimationObjectReferenceA, 5);
                        } else if (this.activeCharacterState.characterAnimationByteStateD == 3 || this.activeCharacterState.characterAnimationByteStateD == 4) {
                           this.drawActorShadow(this.activeCharacterState.characterAnimationObjectReferenceA, 6);
                        }

                        this.playerHealth++;
                        this.gameIntegerStateK++;
                        this.gameIntegerStateN = var3;
                        this.gameIntegerStateG = 646;
                        this.gameLongValueC = this.gameClockTimeMs;
                        this.gameLongValueB = 0L;
                        this.gameIntegerStateQ = 0;
                        this.gameIntegerStateR = 65536;
                     } else {
                        this.playerHealth++;
                        this.gameIntegerStateK++;
                        if (this.activeCharacterState.characterAnimationByteStateD != 4) {
                           if (this.activeCharacterState.characterAnimationObjectReferenceA.animationSetIndex == 0) {
                              if (this.activeCharacterState.characterAnimationByteStateD == 3) {
                                 this.createWorldObject(
                                    13 + this.activeCharacterState.characterAnimationObjectReferenceA.movementDirection, this.activeCharacterState.characterAnimationObjectReferenceA.tileX, this.activeCharacterState.characterAnimationObjectReferenceA.tileY, 0, 0
                                 );
                              } else {
                                 this.createWorldObject(5 + this.activeCharacterState.characterAnimationObjectReferenceA.movementDirection, this.activeCharacterState.characterAnimationObjectReferenceA.tileX, this.activeCharacterState.characterAnimationObjectReferenceA.tileY, 0, 0);
                              }
                           } else if (this.activeCharacterState.characterAnimationByteStateD == 3) {
                              this.createWorldObject(29 + this.activeCharacterState.characterAnimationObjectReferenceA.movementDirection, this.activeCharacterState.characterAnimationObjectReferenceA.tileX, this.activeCharacterState.characterAnimationObjectReferenceA.tileY, 0, 0);
                           } else {
                              this.createWorldObject(21 + this.activeCharacterState.characterAnimationObjectReferenceA.movementDirection, this.activeCharacterState.characterAnimationObjectReferenceA.tileX, this.activeCharacterState.characterAnimationObjectReferenceA.tileY, 0, 0);
                           }

                           this.playerGrenades++;
                           this.drawActorShadow(this.activeCharacterState.characterAnimationObjectReferenceA, 5);
                           if (!this.isCheatModeEnabled) {
                              this.activeCharacterState.characterAnimationByteStateArrayA[this.activeCharacterState.characterAnimationByteStateD]--;
                           }

                           this.gameIntegerStateG = 900;
                        } else {
                           this.gameIntegerStateO = this.offsetTileXAcross(this.activeCharacterState.characterAnimationObjectReferenceA.tileX, this.activeCharacterState.characterAnimationObjectReferenceA.movementDirection, 2);
                           this.gameIntegerStateP = this.offsetTileYAround(this.activeCharacterState.characterAnimationObjectReferenceA.tileY, this.activeCharacterState.characterAnimationObjectReferenceA.movementDirection, 2);
                           this.playerHealth++;
                           this.gameIntegerStateK++;
                           this.spawnAnimatedEffect(
                              4,
                              this.activeCharacterState.characterAnimationObjectReferenceA.tileX,
                              this.activeCharacterState.characterAnimationObjectReferenceA.tileY,
                              this.gameIntegerStateO,
                              this.gameIntegerStateP,
                              this.activeCharacterState.characterAnimationObjectReferenceA.movementDirection
                           );
                           if (!this.isCheatModeEnabled) {
                              this.activeCharacterState.characterAnimationByteStateArrayA[this.activeCharacterState.characterAnimationByteStateD]--;
                           }

                           this.drawActorShadow(this.activeCharacterState.characterAnimationObjectReferenceA, 6);
                           this.gameIntegerStateG = 900;
                        }
                     }

                     return;
                  }

                  switch (this.activeCharacterState.characterAnimationByteStateD) {
                     case 0:
                        this.gameIntegerStateO = this.activeCharacterState.characterAnimationObjectReferenceA.tileX;
                        this.gameIntegerStateP = this.activeCharacterState.characterAnimationObjectReferenceA.tileY;
                        if (this.activeCharacterState.characterAnimationObjectReferenceA.movementDirection == 1) {
                           this.gameIntegerStateO++;
                        } else if (this.activeCharacterState.characterAnimationObjectReferenceA.movementDirection == 7) {
                           this.gameIntegerStateP++;
                        } else if (this.activeCharacterState.characterAnimationObjectReferenceA.movementDirection == 5) {
                           this.gameIntegerStateO--;
                        } else if (this.activeCharacterState.characterAnimationObjectReferenceA.movementDirection == 3) {
                           this.gameIntegerStateP--;
                        }

                        this.gameIntegerStateN = this.findActorAtTile(this.gameIntegerStateO, this.gameIntegerStateP);
                        if (this.gameIntegerStateN > 0) {
                           this.gameIntegerStateG = 646;
                           this.gameLongValueC = this.gameClockTimeMs;
                           this.gameLongValueB = 0L;
                           this.gameIntegerStateQ = 0;
                           this.gameIntegerStateR = 65536;
                        } else {
                           this.drawActorShadow(this.activeCharacterState.characterAnimationObjectReferenceA, 7);
                        }
                        break;
                     default:
                        if (this.activeCharacterState.characterAnimationByteStateArrayA[this.activeCharacterState.characterAnimationByteStateD] > 0) {
                           this.gameIntegerStateO = this.activeCharacterState.characterAnimationObjectReferenceA.tileX;
                           this.gameIntegerStateP = this.activeCharacterState.characterAnimationObjectReferenceA.tileY;
                           if (this.activeCharacterState.characterAnimationObjectReferenceA.movementDirection == 5
                              && this.gameIntegerStateO - 1 >= 0
                              && this.levelTileTypes[this.gameIntegerStateO - 1][this.gameIntegerStateP] == this.currentTileType) {
                              this.gameIntegerStateO--;
                           }

                           if (this.activeCharacterState.characterAnimationObjectReferenceA.movementDirection == 1
                              && this.gameIntegerStateO + 1 < this.gameByteStateAQ
                              && this.levelTileTypes[this.gameIntegerStateO + 1][this.gameIntegerStateP] == this.currentTileType) {
                              this.gameIntegerStateO++;
                           }

                           if (this.activeCharacterState.characterAnimationObjectReferenceA.movementDirection == 3
                              && this.gameIntegerStateP - 1 >= 0
                              && this.levelTileTypes[this.gameIntegerStateO][this.gameIntegerStateP - 1] == this.currentTileType) {
                              this.gameIntegerStateP--;
                           }

                           if (this.activeCharacterState.characterAnimationObjectReferenceA.movementDirection == 7
                              && this.gameIntegerStateP + 1 < this.gameByteStateAR
                              && this.levelTileTypes[this.gameIntegerStateO][this.gameIntegerStateP + 1] == this.currentTileType) {
                              this.gameIntegerStateP++;
                           }

                           if (this.activeCharacterState.characterAnimationObjectReferenceA.movementDirection == 4
                              && this.gameIntegerStateO - 1 >= 0
                              && this.gameIntegerStateP - 1 >= 0
                              && this.levelTileTypes[this.gameIntegerStateO - 1][this.gameIntegerStateP - 1] == this.currentTileType) {
                              this.gameIntegerStateO--;
                              this.gameIntegerStateP--;
                           }

                           if (this.activeCharacterState.characterAnimationObjectReferenceA.movementDirection == 0
                              && this.gameIntegerStateO + 1 < this.gameByteStateAQ
                              && this.gameIntegerStateP + 1 < this.gameByteStateAR
                              && this.levelTileTypes[this.gameIntegerStateO + 1][this.gameIntegerStateP + 1] == this.currentTileType) {
                              this.gameIntegerStateO++;
                              this.gameIntegerStateP++;
                           }

                           if (this.activeCharacterState.characterAnimationObjectReferenceA.movementDirection == 2
                              && this.gameIntegerStateO + 1 < this.gameByteStateAQ
                              && this.gameIntegerStateP - 1 >= 0
                              && this.levelTileTypes[this.gameIntegerStateO + 1][this.gameIntegerStateP - 1] == this.currentTileType) {
                              this.gameIntegerStateO++;
                              this.gameIntegerStateP--;
                           }

                           if (this.activeCharacterState.characterAnimationObjectReferenceA.movementDirection == 6
                              && this.gameIntegerStateO - 1 >= 0
                              && this.gameIntegerStateP + 1 < this.gameByteStateAR
                              && this.levelTileTypes[this.gameIntegerStateO - 1][this.gameIntegerStateP + 1] == this.currentTileType) {
                              this.gameIntegerStateO--;
                              this.gameIntegerStateP++;
                           }

                           this.gameIntegerStateG = 901;
                           this.gameLongValueB = this.gameClockTimeMs;
                        } break;
                  }
               }
               break;
            case 901:
               switch (this.activeCharacterState.characterAnimationByteStateD) {
                  case 1:
                  case 2:
                  case 3:
                     if ((this.gameByteStateAU & 2) != 0) {
                        if (this.gameIntegerStateO - 1 >= 0 && this.levelTileTypes[this.gameIntegerStateO - 1][this.gameIntegerStateP] == this.currentTileType) {
                           this.gameIntegerStateO--;
                        }
                     } else if ((this.gameByteStateAU & 4) != 0) {
                        if (this.gameIntegerStateO + 1 < this.gameByteStateAQ && this.levelTileTypes[this.gameIntegerStateO + 1][this.gameIntegerStateP] == this.currentTileType) {
                           this.gameIntegerStateO++;
                        }
                     } else if ((this.gameByteStateAU & 8) != 0) {
                        if (this.gameIntegerStateP - 1 >= 0 && this.levelTileTypes[this.gameIntegerStateO][this.gameIntegerStateP - 1] == this.currentTileType) {
                           this.gameIntegerStateP--;
                        }
                     } else if ((this.gameByteStateAU & 16) != 0) {
                        if (this.gameIntegerStateP + 1 < this.gameByteStateAR && this.levelTileTypes[this.gameIntegerStateO][this.gameIntegerStateP + 1] == this.currentTileType) {
                           this.gameIntegerStateP++;
                        }
                     } else if ((this.gameIntegerStateA & 32) != 0) {
                        this.playerHealth++;
                        this.gameIntegerStateL++;
                        this.gameIntegerStateN = this.findActorAtTile(this.gameIntegerStateO, this.gameIntegerStateP);
                        if (this.gameIntegerStateN > 0) {
                           this.gameIntegerStateG = 646;
                           this.gameLongValueC = this.gameClockTimeMs;
                           this.gameLongValueB = 0L;
                           this.gameIntegerStateQ = 0;
                           this.gameIntegerStateR = 65536;
                        } else {
                           if (this.activeCharacterState.characterAnimationObjectReferenceA.animationSetIndex == 0) {
                              if (this.activeCharacterState.characterAnimationByteStateD == 3) {
                                 this.createWorldObject(
                                    13 + this.activeCharacterState.characterAnimationObjectReferenceA.movementDirection, this.activeCharacterState.characterAnimationObjectReferenceA.tileX, this.activeCharacterState.characterAnimationObjectReferenceA.tileY, 0, 0
                                 );
                              } else {
                                 this.createWorldObject(5 + this.activeCharacterState.characterAnimationObjectReferenceA.movementDirection, this.activeCharacterState.characterAnimationObjectReferenceA.tileX, this.activeCharacterState.characterAnimationObjectReferenceA.tileY, 0, 0);
                              }
                           } else if (this.activeCharacterState.characterAnimationByteStateD == 3) {
                              this.createWorldObject(29 + this.activeCharacterState.characterAnimationObjectReferenceA.movementDirection, this.activeCharacterState.characterAnimationObjectReferenceA.tileX, this.activeCharacterState.characterAnimationObjectReferenceA.tileY, 0, 0);
                           } else {
                              this.createWorldObject(21 + this.activeCharacterState.characterAnimationObjectReferenceA.movementDirection, this.activeCharacterState.characterAnimationObjectReferenceA.tileX, this.activeCharacterState.characterAnimationObjectReferenceA.tileY, 0, 0);
                           }

                           this.playerGrenades++;
                           this.drawActorShadow(this.activeCharacterState.characterAnimationObjectReferenceA, 5);
                           if (!this.isCheatModeEnabled) {
                              this.activeCharacterState.characterAnimationByteStateArrayA[this.activeCharacterState.characterAnimationByteStateD]--;
                           }

                           this.gameIntegerStateG = 900;
                        }
                     }

                     var1 = this.gameIntegerStateO - this.activeCharacterState.characterAnimationObjectReferenceA.tileX;
                     var2 = this.gameIntegerStateP - this.activeCharacterState.characterAnimationObjectReferenceA.tileY;
                     break;
                  case 4:
                     if ((this.gameByteStateAU & 2) != 0) {
                        if (this.gameIntegerStateO - 1 >= 0 && this.levelTileTypes[this.gameIntegerStateO - 1][this.gameIntegerStateP] == this.currentTileType) {
                           this.gameIntegerStateO--;
                        }
                     } else if ((this.gameByteStateAU & 4) != 0) {
                        if (this.gameIntegerStateO + 1 < this.gameByteStateAQ && this.levelTileTypes[this.gameIntegerStateO + 1][this.gameIntegerStateP] == this.currentTileType) {
                           this.gameIntegerStateO++;
                        }
                     } else if ((this.gameByteStateAU & 8) != 0) {
                        if (this.gameIntegerStateP - 1 >= 0 && this.levelTileTypes[this.gameIntegerStateO][this.gameIntegerStateP - 1] == this.currentTileType) {
                           this.gameIntegerStateP--;
                        }
                     } else if ((this.gameByteStateAU & 16) != 0) {
                        if (this.gameIntegerStateP + 1 < this.gameByteStateAR && this.levelTileTypes[this.gameIntegerStateO][this.gameIntegerStateP + 1] == this.currentTileType) {
                           this.gameIntegerStateP++;
                        }
                     } else if ((this.gameIntegerStateA & 32) != 0) {
                        this.playerHealth++;
                        this.gameIntegerStateL++;
                        this.spawnAnimatedEffect(
                           4,
                           this.activeCharacterState.characterAnimationObjectReferenceA.tileX,
                           this.activeCharacterState.characterAnimationObjectReferenceA.tileY,
                           this.gameIntegerStateO,
                           this.gameIntegerStateP,
                           this.activeCharacterState.characterAnimationObjectReferenceA.movementDirection
                        );
                        if (!this.isCheatModeEnabled) {
                           this.activeCharacterState.characterAnimationByteStateArrayA[this.activeCharacterState.characterAnimationByteStateD]--;
                        }

                        this.drawActorShadow(this.activeCharacterState.characterAnimationObjectReferenceA, 6);
                        this.gameIntegerStateG = 900;
                     }

                     var1 = this.gameIntegerStateO - this.activeCharacterState.characterAnimationObjectReferenceA.tileX;
                     var2 = this.gameIntegerStateP - this.activeCharacterState.characterAnimationObjectReferenceA.tileY; break;
               }

               if (var1 == 0 && var2 == 0) {
                  this.setActorDirection(this.activeCharacterState.characterAnimationObjectReferenceA, 0);
               } else if (JMath.abs(var2) * 2 <= JMath.abs(var1)) {
                  if (var1 <= 0) {
                     this.setActorDirection(this.activeCharacterState.characterAnimationObjectReferenceA, 5);
                  } else {
                     this.setActorDirection(this.activeCharacterState.characterAnimationObjectReferenceA, 1);
                  }
               } else if (JMath.abs(var2) <= JMath.abs(var1) * 2) {
                  if (var1 <= 0 && var2 <= 0) {
                     this.setActorDirection(this.activeCharacterState.characterAnimationObjectReferenceA, 4);
                  } else if (var1 <= 0) {
                     this.setActorDirection(this.activeCharacterState.characterAnimationObjectReferenceA, 6);
                  } else if (var2 <= 0) {
                     this.setActorDirection(this.activeCharacterState.characterAnimationObjectReferenceA, 2);
                  } else {
                     this.setActorDirection(this.activeCharacterState.characterAnimationObjectReferenceA, 0);
                  }
               } else if (var2 <= 0) {
                  this.setActorDirection(this.activeCharacterState.characterAnimationObjectReferenceA, 3);
               } else {
                  this.setActorDirection(this.activeCharacterState.characterAnimationObjectReferenceA, 7);
               } break;
         }
      }
   }

   // $VF: renamed from: b (byte) byte
   public sbyte getInventoryFacingDirection(sbyte var1) {
      sbyte var2 = 0;
      sbyte var3 = 0;
      switch (var1) {
         case 0:
            var3 = this.levelGrid[this.activeCharacterState.characterAnimationByteStateD][0];
            if (var3 == 0) {
               var2 = 0;
            } else if (var3 == 1) {
               var2 = 4;
            } else if (var3 == 2) {
               var2 = 8;
            } else if (var3 == 3) {
               var2 = 12;
            }
            break;
         case 1:
            var3 = this.levelGrid[this.activeCharacterState.characterAnimationByteStateD][1];
            if (var3 == 0) {
               var2 = 1;
            } else if (var3 == 1) {
               var2 = 5;
            } else if (var3 == 2) {
               var2 = 9;
            } else if (var3 == 3) {
               var2 = 13;
            }
            break;
         case 2:
            var3 = this.levelGrid[this.activeCharacterState.characterAnimationByteStateD][2];
            if (var3 == 0) {
               var2 = 2;
            } else if (var3 == 1) {
               var2 = 6;
            } else if (var3 == 2) {
               var2 = 10;
            } else if (var3 == 3) {
               var2 = 14;
            } break;
      }

      return var2;
   }

   // $VF: renamed from: aP () byte
   public sbyte getSelectedItemDirection() {
      sbyte var1 = 0;
      sbyte var2 = 0;
      if (this.gameByteStateArrayB != null) {
         var1 = this.levelGrid[this.gameByteStateArrayB[this.selectedItemIndex]][this.selectedItemPage];
      }

      switch (var1) {
         case 0:
            var2 = 3;
            break;
         case 1:
            var2 = 7;
            break;
         case 2:
            var2 = 11; break;
      }

      return var2;
   }

   // $VF: renamed from: e (u) int
   public int findNearbyActor(ActorRuntimeState var1) {
      int var2 = -1;
      int var5 = var1.tileX;
      int var6 = var1.tileY;
      sbyte var9 = var1.movementDirection;
      int var10 = this.isActorAtTile(0, var5, var6, false);
      if (var10 != -1 && var10 != 2) {
         return var10;
      } else {
         for (int var3 = 1; var3 < 4; var3++) {
            var5 = this.offsetTileXAcross(var5, var9, 1);
            var6 = this.offsetTileYAround(var6, var9, 1);
            var10 = this.isActorAtTile(0, var5, var6, false);
            if (var10 != -1 && var10 != 2) {
               return var10;
            }

            for (int var4 = 0; var4 < var3; var4++) {
               int var7 = this.offsetTileXForward(var5, var9, var4 + 1);
               int var8 = this.offsetTileYForward(var6, var9, var4 + 1);
               var2 = this.isActorAtTile(0, var7, var8, false);
               if (var2 != -1 && var2 != 2) {
                  return var2;
               }

               var7 = this.offsetTileXSideways(var5, var9, var4 + 1);
               var8 = this.offsetTileYSideways(var6, var9, var4 + 1);
               var10 = this.isActorAtTile(0, var7, var8, false);
               if (var10 != -1 && var10 != 2) {
                  return var10;
               }
            }
         }

         if (var10 == 2) {
            var10 = -1;
         }

         return var10;
      }
   }

   // $VF: renamed from: e (u, int, int) void
   public void faceActorTowardTile(ActorRuntimeState var1, int var2, int var3) {
      int var4 = var2 - var1.tileX;
      int var5 = var3 - var1.tileY;
      if (var4 == 0 && var5 == 0) {
         this.setActorDirection(var1, 0);
      } else if (JMath.abs(var5) * 2 <= JMath.abs(var4)) {
         if (var4 <= 0) {
            this.setActorDirection(var1, 5);
         } else {
            this.setActorDirection(var1, 1);
         }
      } else if (JMath.abs(var5) <= JMath.abs(var4) * 2) {
         if (var4 <= 0 && var5 <= 0) {
            this.setActorDirection(var1, 4);
         } else if (var4 <= 0) {
            this.setActorDirection(var1, 6);
         } else if (var5 <= 0) {
            this.setActorDirection(var1, 2);
         } else {
            this.setActorDirection(var1, 0);
         }
      } else if (var5 <= 0) {
         this.setActorDirection(var1, 3);
      } else {
         this.setActorDirection(var1, 7);
      }
   }

   // $VF: renamed from: c (int, int, int) int
   public int offsetTileXForward(int var1, int var2, int var3) {
      int var4 = -1;
      if (var3 == 0) {
         var4 = var1;
      } else if (var2 == 4) {
         var4 = var1;
      } else if (var2 == 3) {
         var4 = var1 - var3;
      } else if (var2 == 2) {
         var4 = var1 - var3;
      } else if (var2 == 1) {
         var4 = var1;
      } else if (var2 == 0) {
         var4 = var1;
      } else if (var2 == 7) {
         var4 = var1 + var3;
      } else if (var2 == 6) {
         var4 = var1 + var3;
      } else if (var2 == 5) {
         var4 = var1;
      }

      return var4;
   }

   // $VF: renamed from: d (int, int, int) int
   public int offsetTileYForward(int var1, int var2, int var3) {
      int var4 = -1;
      if (var3 == 0) {
         var4 = var1;
      } else if (var2 == 4) {
         var4 = var1 + var3;
      } else if (var2 == 3) {
         var4 = var1;
      } else if (var2 == 2) {
         var4 = var1;
      } else if (var2 == 1) {
         var4 = var1 - var3;
      } else if (var2 == 0) {
         var4 = var1 - var3;
      } else if (var2 == 7) {
         var4 = var1;
      } else if (var2 == 6) {
         var4 = var1;
      } else if (var2 == 5) {
         var4 = var1 + var3;
      }

      return var4;
   }

   // $VF: renamed from: e (int, int, int) int
   public int offsetTileXSideways(int var1, int var2, int var3) {
      int var4 = -1;
      if (var3 == 0) {
         var4 = var1;
      } else if (var2 == 4) {
         var4 = var1 + var3;
      } else if (var2 == 3) {
         var4 = var1 + var3;
      } else if (var2 == 2) {
         var4 = var1;
      } else if (var2 == 1) {
         var4 = var1;
      } else if (var2 == 0) {
         var4 = var1 - var3;
      } else if (var2 == 7) {
         var4 = var1 - var3;
      } else if (var2 == 6) {
         var4 = var1;
      } else if (var2 == 5) {
         var4 = var1;
      }

      return var4;
   }

   // $VF: renamed from: f (int, int, int) int
   public int offsetTileYSideways(int var1, int var2, int var3) {
      int var4 = -1;
      if (var3 == 0) {
         var4 = var1;
      } else if (var2 == 4) {
         var4 = var1;
      } else if (var2 == 3) {
         var4 = var1;
      } else if (var2 == 2) {
         var4 = var1 + var3;
      } else if (var2 == 1) {
         var4 = var1 + var3;
      } else if (var2 == 0) {
         var4 = var1;
      } else if (var2 == 7) {
         var4 = var1;
      } else if (var2 == 6) {
         var4 = var1 - var3;
      } else if (var2 == 5) {
         var4 = var1 - var3;
      }

      return var4;
   }

   // $VF: renamed from: g (int, int, int) int
   public int offsetTileXAcross(int var1, int var2, int var3) {
      int var4 = -1;
      if (var3 == 0) {
         var4 = var1;
      } else if (var2 == 4) {
         var4 = var1 - var3;
      } else if (var2 == 3) {
         var4 = var1;
      } else if (var2 == 2) {
         var4 = var1 + var3;
      } else if (var2 == 1) {
         var4 = var1 + var3;
      } else if (var2 == 0) {
         var4 = var1 + var3;
      } else if (var2 == 7) {
         var4 = var1;
      } else if (var2 == 6) {
         var4 = var1 - var3;
      } else if (var2 == 5) {
         var4 = var1 - var3;
      }

      return var4;
   }

   // $VF: renamed from: h (int, int, int) int
   public int offsetTileYAround(int var1, int var2, int var3) {
      int var4 = -1;
      if (var3 == 0) {
         var4 = var1;
      } else if (var2 == 4) {
         var4 = var1 - var3;
      } else if (var2 == 3) {
         var4 = var1 - var3;
      } else if (var2 == 2) {
         var4 = var1 - var3;
      } else if (var2 == 1) {
         var4 = var1;
      } else if (var2 == 0) {
         var4 = var1 + var3;
      } else if (var2 == 7) {
         var4 = var1 + var3;
      } else if (var2 == 6) {
         var4 = var1 + var3;
      } else if (var2 == 5) {
         var4 = var1;
      }

      return var4;
   }

   // $VF: renamed from: l (int, int) int
   public int findActorAtTile(int var1, int var2) {
      for (int var3 = 0; var3 < 24; var3++) {
         if (this.actorStates[var3].isActive
            && this.actorStates[var3].animationFrameIndex != 3
            && this.actorStates[var3].animationFrameIndex != 4
            && gameIntegerStateArrayArrayA[this.actorStates[var3].animationSetIndex][0] != 0
            && this.actorStates[var3].tileX == var1
            && this.actorStates[var3].tileY == var2) {
            return var3;
         }
      }

      return -1;
   }

   // $VF: renamed from: L () boolean
   public bool isCharacterOnWorldObject() {
      bool var5 = false;
      sbyte var1 = this.activeCharacterState.characterAnimationObjectReferenceA.tileX;
      sbyte var2 = this.activeCharacterState.characterAnimationObjectReferenceA.tileY;
      int var3 = var1;
      int var4 = var2;
      if (this.activeCharacterState.characterAnimationObjectReferenceA.movementDirection == 1) {
         var3 = var1 + 1;
      } else if (this.activeCharacterState.characterAnimationObjectReferenceA.movementDirection == 3) {
         var4 = var2 - 1;
      } else if (this.activeCharacterState.characterAnimationObjectReferenceA.movementDirection == 5) {
         var3 = var1 - 1;
      } else if (this.activeCharacterState.characterAnimationObjectReferenceA.movementDirection == 7) {
         var4 = var2 + 1;
      }

      if (this.medicalItemState.actorAnimationByteStateB == var3 && this.medicalItemState.actorAnimationByteStateC == var4 && this.medicalItemState.actorAnimationFlagB) {
         this.applyHealingItem();
         var5 = true;
      } else if (this.ammunitionItemState.actorAnimationByteStateB == var3 && this.ammunitionItemState.actorAnimationByteStateC == var4 && this.ammunitionItemState.actorAnimationFlagB) {
         this.equipAmmunition();
         var5 = true;
      } else if (this.weaponItemState.actorAnimationByteStateB == var3 && this.weaponItemState.actorAnimationByteStateC == var4 && this.weaponItemState.actorAnimationFlagB) {
         this.unequipWeapon();
         var5 = true;
      }

      return var5;
   }

   // $VF: renamed from: q (int) void
   public void performWeaponAction(int var1) {
      if (!this.canUseItemInCombat(var1) && !this.performSecondaryAction(var1) && !this.performRangedAttack(var1)) {
      }
   }

   // $VF: renamed from: r (int) boolean
   public bool canUseItemInCombat(int var1) {
      if (this.gameByteStateAZ != 2) {
         return false;
      } else if (this.gameIntegerStateAF < 5) {
         return false;
      } else if (nextRandomBelow(100) < 3 + this.gameByteStateAX) {
         this.equipWeapon(this.actorStates[var1].tileX, this.actorStates[var1].tileY);
         this.gameByteStateAX = 0;
         return true;
      } else {
         if (this.activeCharacterState.characterAnimationFlagArrayA[3] && this.activeCharacterState.characterAnimationFlagArrayA[2] && this.activeCharacterState.characterAnimationFlagArrayA[4]) {
            if (this.gameIntegerStateAF % 3 == 0) {
               this.gameByteStateAX++;
            }
         } else if (this.gameIntegerStateAF % 2 == 0) {
            this.gameByteStateAX++;
         }

         return false;
      }
   }

   // $VF: renamed from: b (byte, byte) boolean
   public bool equipWeapon(sbyte var1, sbyte var2) {
      if (!this.weaponItemState.actorAnimationFlagB) {
         this.weaponItemState.actorAnimationByteStateB = var1;
         this.weaponItemState.actorAnimationByteStateC = var2;
         this.weaponItemState.actorAnimationFlagB = true;
         return true;
      } else {
         return false;
      }
   }

   // $VF: renamed from: aQ () void
   public void unequipWeapon() {
      this.weaponItemState.actorAnimationFlagB = false;
      if (!this.activeCharacterState.characterAnimationFlagArrayA[0]) {
         this.activeCharacterState.characterAnimationFlagArrayA[0] = true;
         if (this.activeCharacterState.characterAnimationByteStateD == 127) {
            this.setPlayerAction(0);
         }
      } else if (!this.activeCharacterState.characterAnimationFlagArrayA[1]) {
         this.activeCharacterState.characterAnimationFlagArrayA[1] = true;
         this.activeCharacterState.characterAnimationByteStateArrayA[1] = 10;
         if (this.activeCharacterState.characterAnimationByteStateD == 127) {
            this.setPlayerAction(1);
         }
      } else if (!this.activeCharacterState.characterAnimationFlagArrayA[3]) {
         this.activeCharacterState.characterAnimationFlagArrayA[3] = true;
         this.activeCharacterState.characterAnimationByteStateArrayA[3] = 10;
         if (this.activeCharacterState.characterAnimationByteStateD == 127) {
            this.setPlayerAction(3);
         }
      } else if (!this.activeCharacterState.characterAnimationFlagArrayA[2]) {
         this.activeCharacterState.characterAnimationFlagArrayA[2] = true;
         this.activeCharacterState.characterAnimationByteStateArrayA[2] = 5;
         if (this.activeCharacterState.characterAnimationByteStateD == 127) {
            this.setPlayerAction(2);
         }
      } else if (!this.activeCharacterState.characterAnimationFlagArrayA[4]) {
         this.activeCharacterState.characterAnimationFlagArrayA[4] = true;
         this.activeCharacterState.characterAnimationByteStateArrayA[4] = 2;
         if (this.activeCharacterState.characterAnimationByteStateD == 127) {
            this.setPlayerAction(4);
         }
      } else {
         this.activeCharacterState.characterAnimationByteStateArrayA[1] = (sbyte)(this.activeCharacterState.characterAnimationByteStateArrayA[1] + 10);
         this.activeCharacterState.characterAnimationByteStateArrayA[3] = (sbyte)(this.activeCharacterState.characterAnimationByteStateArrayA[3] + 5);
         this.activeCharacterState.characterAnimationByteStateArrayA[2] = (sbyte)(this.activeCharacterState.characterAnimationByteStateArrayA[2] + 2);
         this.activeCharacterState.characterAnimationByteStateArrayA[4]++;
      }

      if (this.activeCharacterState.characterAnimationByteStateArrayA[1] > this.itemPriceByLevel[1]) {
         this.activeCharacterState.characterAnimationByteStateArrayA[1] = this.itemPriceByLevel[1];
      }

      if (this.activeCharacterState.characterAnimationByteStateArrayA[3] > this.itemPriceByLevel[3]) {
         this.activeCharacterState.characterAnimationByteStateArrayA[3] = this.itemPriceByLevel[3];
      }

      if (this.activeCharacterState.characterAnimationByteStateArrayA[2] > this.itemPriceByLevel[2]) {
         this.activeCharacterState.characterAnimationByteStateArrayA[2] = this.itemPriceByLevel[2];
      }

      if (this.activeCharacterState.characterAnimationByteStateArrayA[4] > this.itemPriceByLevel[4]) {
         this.activeCharacterState.characterAnimationByteStateArrayA[4] = this.itemPriceByLevel[4];
      }
   }

   // $VF: renamed from: aR () void
   public void equipAmmunition() {
      this.ammunitionItemState.actorAnimationFlagB = false;
      if (this.activeCharacterState.characterAnimationByteStateArrayA[this.activeCharacterState.characterAnimationByteStateD] < 99) {
         switch (this.activeCharacterState.characterAnimationByteStateD) {
            case 1:
               this.activeCharacterState.characterAnimationByteStateArrayA[this.activeCharacterState.characterAnimationByteStateD] = (sbyte)(this.activeCharacterState.characterAnimationByteStateArrayA[this.activeCharacterState.characterAnimationByteStateD] + 10);
               if (this.activeCharacterState.characterAnimationFlagArrayA[2]) {
                  this.activeCharacterState.characterAnimationByteStateArrayA[2]++;
               }

               if (this.activeCharacterState.characterAnimationFlagArrayA[3]) {
                  this.activeCharacterState.characterAnimationByteStateArrayA[3] = (sbyte)(this.activeCharacterState.characterAnimationByteStateArrayA[3] + 2);
               }

               if (this.activeCharacterState.characterAnimationFlagArrayA[4]) {
                  this.activeCharacterState.characterAnimationByteStateArrayA[4]++;
               }
               break;
            case 2:
               this.activeCharacterState.characterAnimationByteStateArrayA[this.activeCharacterState.characterAnimationByteStateD] = (sbyte)(this.activeCharacterState.characterAnimationByteStateArrayA[this.activeCharacterState.characterAnimationByteStateD] + 2);
               if (this.activeCharacterState.characterAnimationFlagArrayA[1]) {
                  this.activeCharacterState.characterAnimationByteStateArrayA[1] = (sbyte)(this.activeCharacterState.characterAnimationByteStateArrayA[1] + 3);
               }

               if (this.activeCharacterState.characterAnimationFlagArrayA[3]) {
                  this.activeCharacterState.characterAnimationByteStateArrayA[3] = (sbyte)(this.activeCharacterState.characterAnimationByteStateArrayA[3] + 2);
               }

               if (this.activeCharacterState.characterAnimationFlagArrayA[4]) {
                  this.activeCharacterState.characterAnimationByteStateArrayA[4]++;
               }
               break;
            case 3:
               this.activeCharacterState.characterAnimationByteStateArrayA[this.activeCharacterState.characterAnimationByteStateD] = (sbyte)(this.activeCharacterState.characterAnimationByteStateArrayA[this.activeCharacterState.characterAnimationByteStateD] + 5);
               if (this.activeCharacterState.characterAnimationFlagArrayA[1]) {
                  this.activeCharacterState.characterAnimationByteStateArrayA[1] = (sbyte)(this.activeCharacterState.characterAnimationByteStateArrayA[1] + 3);
               }

               if (this.activeCharacterState.characterAnimationFlagArrayA[2]) {
                  this.activeCharacterState.characterAnimationByteStateArrayA[2]++;
               }

               if (this.activeCharacterState.characterAnimationFlagArrayA[4]) {
                  this.activeCharacterState.characterAnimationByteStateArrayA[4]++;
               }
               break;
            case 4:
               this.activeCharacterState.characterAnimationByteStateArrayA[this.activeCharacterState.characterAnimationByteStateD]++;
               if (this.activeCharacterState.characterAnimationFlagArrayA[1]) {
                  this.activeCharacterState.characterAnimationByteStateArrayA[1] = (sbyte)(this.activeCharacterState.characterAnimationByteStateArrayA[1] + 3);
               }

               if (this.activeCharacterState.characterAnimationFlagArrayA[2]) {
                  this.activeCharacterState.characterAnimationByteStateArrayA[2]++;
               }

               if (this.activeCharacterState.characterAnimationFlagArrayA[3]) {
                  this.activeCharacterState.characterAnimationByteStateArrayA[3] = (sbyte)(this.activeCharacterState.characterAnimationByteStateArrayA[3] + 2);
               }
               break;
            default:
               this.activeCharacterState.characterAnimationByteStateArrayA[1] = (sbyte)(this.activeCharacterState.characterAnimationByteStateArrayA[1] + 10);
               if (this.activeCharacterState.characterAnimationFlagArrayA[2]) {
                  this.activeCharacterState.characterAnimationByteStateArrayA[2]++;
               }

               if (this.activeCharacterState.characterAnimationFlagArrayA[3]) {
                  this.activeCharacterState.characterAnimationByteStateArrayA[3] = (sbyte)(this.activeCharacterState.characterAnimationByteStateArrayA[3] + 2);
               }

               if (this.activeCharacterState.characterAnimationFlagArrayA[4]) {
                  this.activeCharacterState.characterAnimationByteStateArrayA[4]++;
               } break;
         }

         if (this.activeCharacterState.characterAnimationByteStateArrayA[1] > this.itemPriceByLevel[1]) {
            this.activeCharacterState.characterAnimationByteStateArrayA[1] = this.itemPriceByLevel[1];
         }

         if (this.activeCharacterState.characterAnimationByteStateArrayA[3] > this.itemPriceByLevel[3]) {
            this.activeCharacterState.characterAnimationByteStateArrayA[3] = this.itemPriceByLevel[3];
         }

         if (this.activeCharacterState.characterAnimationByteStateArrayA[2] > this.itemPriceByLevel[2]) {
            this.activeCharacterState.characterAnimationByteStateArrayA[2] = this.itemPriceByLevel[2];
         }

         if (this.activeCharacterState.characterAnimationByteStateArrayA[4] > this.itemPriceByLevel[4]) {
            this.activeCharacterState.characterAnimationByteStateArrayA[4] = this.itemPriceByLevel[4];
         }
      }
   }

   // $VF: renamed from: s (int) boolean
   public bool performRangedAttack(int var1) {
      if (this.gameByteStateAZ != 0 || !this.isReleasedInputFlagSet(16) && !this.isReleasedInputFlagSet(32)) {
         this.gameByteStateAW = (sbyte)(this.gameByteStateAW + 2);
         if (this.actorStates[var1].animationSetIndex == 6 || this.actorStates[var1].animationSetIndex == 8) {
            this.gameByteStateAW = (sbyte)(this.gameByteStateAW + 2);
         }

         if (this.hasInventoryCapacity() && 22 + this.gameByteStateAW < 50) {
            this.gameByteStateAW = 28;
         }

         if (nextRandomBelow(100) < 22 + this.gameByteStateAW) {
            this.useAmmunition(this.actorStates[var1].tileX, this.actorStates[var1].tileY);
            this.gameByteStateAW = 0;
            return true;
         } else {
            return false;
         }
      } else {
         return false;
      }
   }

   // $VF: renamed from: aS () boolean
   public bool hasInventoryCapacity() {
      return this.activeCharacterState.characterAnimationByteStateArrayA[1] <= 7 && this.activeCharacterState.characterAnimationByteStateArrayA[2] <= 5 && this.activeCharacterState.characterAnimationByteStateArrayA[3] <= 5;
   }

   // $VF: renamed from: c (byte, byte) boolean
   public bool useAmmunition(sbyte var1, sbyte var2) {
      if (!this.ammunitionItemState.actorAnimationFlagB) {
         this.ammunitionItemState.actorAnimationByteStateB = var1;
         this.ammunitionItemState.actorAnimationByteStateC = var2;
         this.ammunitionItemState.actorAnimationFlagB = true;
         return true;
      } else {
         return false;
      }
   }

   // $VF: renamed from: d (byte, byte) boolean
   public bool useMedicalItem(sbyte var1, sbyte var2) {
      if (!this.medicalItemState.actorAnimationFlagB) {
         this.medicalItemState.actorAnimationByteStateB = var1;
         this.medicalItemState.actorAnimationByteStateC = var2;
         this.medicalItemState.actorAnimationFlagB = true;
         return true;
      } else {
         return false;
      }
   }

   // $VF: renamed from: t (int) boolean
   public bool performSecondaryAction(int var1) {
      if (this.gameByteStateAZ != 0 || !this.isReleasedInputFlagSet(8) && !this.isReleasedInputFlagSet(512)) {
         if (this.activeCharacterState.characterAnimationObjectReferenceA.actionCounter < 4) {
            this.gameByteStateAV = 10;
         } else {
            this.gameByteStateAV = 0;
         }

         if (nextRandomBelow(100) < 5 + this.gameByteStateAV) {
            this.useMedicalItem(this.actorStates[var1].tileX, this.actorStates[var1].tileY);
            return true;
         } else {
            return false;
         }
      } else {
         return false;
      }
   }

   // $VF: renamed from: M () void
   public void consumeAmmunition() {
      if (this.activeCharacterState.characterAnimationByteStateArrayA[5] > 0) {
         if (this.activeCharacterState.characterAnimationObjectReferenceA.actionCounter != this.activeCharacterState.characterAnimationObjectReferenceA.actionCounterLimit) {
            this.updateActorAnimation(this.activeCharacterState.characterAnimationObjectReferenceA, this.activeCharacterState.characterAnimationObjectReferenceA.actionCounterLimit);
            this.activeCharacterState.characterAnimationByteStateArrayA[5]--;
         }
      }
   }

   // $VF: renamed from: aT () void
   public void applyHealingItem() {
      this.medicalItemState.actorAnimationFlagB = false;
      if (this.activeCharacterState.characterAnimationByteStateD == 127) {
         this.setPlayerAction(5);
      }

      this.activeCharacterState.characterAnimationFlagArrayA[5] = true;
      if (this.activeCharacterState.characterAnimationByteStateArrayA[5] >= 3) {
         this.updateActorAnimation(this.activeCharacterState.characterAnimationObjectReferenceA, this.activeCharacterState.characterAnimationObjectReferenceA.actionCounterLimit);
      } else {
         this.activeCharacterState.characterAnimationByteStateArrayA[5]++;
      }
   }

   // $VF: renamed from: aU () void
   public void initializeAudioManager() {
      try {
         this.audioCommandSink = new GameAudioManager(1, 2, 1);
         sbyte[] var1 = new sbyte[]{0, 0};
         sbyte[] var2 = new sbyte[]{0, 0};
         sbyte[] var3 = new sbyte[]{0, 1};
         sbyte[] var4 = new sbyte[]{1, 1};
         sbyte[] var5 = new sbyte[]{100, 100};
         this.audioCommandSink.configureCueMetadata(var1, var3, var2, var4);
         this.audioCommandSink.setCueVolumeLevels(var5);
         this.audioCommandSink.setMasterVolume(this.audioFadeLevels[5]);
      } catch (System.Exception var6) {
      }
   }

   // $VF: renamed from: m (int, int) void
   public void playAudioCue(int var1, int var2) {
      if (this.audioCommandSink != null) {
         if (var1 >= 0) {
            if (this.localizedTextVariant > 0) {
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
   }

   // $VF: renamed from: N () void
   public void disposeAudioManager() {
      if (this.audioCommandSink != null) {
         this.audioCommandSink.disposeAllPlayers();
      }
   }

   // $VF: renamed from: c (byte) void
   public void playMusicTrack(sbyte var1) {
      bool var4 = false;
      switch (var1) {
         case 0:
            GameCanvas.writePersistentByte(var1, 0, this.gameByteStateB);
            break;
         case 1:
            GameCanvas.writePersistentByte(var1, 0, this.localizedTextVariant);
            break;
         case 2:
            int var9 = 0;
            GameCanvas.writePersistentInteger(var1, var9, this.playerHealth);
            GameCanvas.writePersistentInteger(var1, ++var9, this.playerAmmo);
            GameCanvas.writePersistentInteger(var1, ++var9, this.playerGrenades);
            GameCanvas.writePersistentInteger(var1, ++var9, this.playerCredits);
            GameCanvas.writePersistentInteger(var1, ++var9, this.gameIntegerStateAG);
            GameCanvas.writePersistentByte(var1, ++var9, this.activeCharacterState.characterAnimationByteStateD);
            GameCanvas.writePersistentByte(var1, ++var9, this.activeCharacterState.characterAnimationObjectReferenceA.actionCounter);
            GameCanvas.writePersistentInteger(var1, ++var9, this.gameIntegerStateAI);
            var9++;

            for (int var5 = 0; var5 < 6; var5++) {
               GameCanvas.writePersistentBoolean(var1, var9, this.activeCharacterState.characterAnimationFlagArrayA[var5]);
               var9++;
            }

            for (int var6 = 0; var6 < 6; var6++) {
               GameCanvas.writePersistentByte(var1, var9, this.activeCharacterState.characterAnimationByteStateArrayA[var6]);
               var9++;
            }

            for (int var7 = 0; var7 < this.levelGrid.Length; var7++) {
               for (int var3 = 0; var3 < this.levelGrid[var7].Length; var3++) {
                  GameCanvas.writePersistentByte(var1, var9, this.levelGrid[var7][var3]);
                  var9++;
               }
            }

            GameCanvas.writePersistentByte(var1, var9, this.gameByteStateBE);
            GameCanvas.writePersistentByte(var1, ++var9, this.gameByteStateBC);
            GameCanvas.writePersistentInteger(var1, ++var9, this.gameIntegerStateAH);
            GameCanvas.writePersistentByte(var1, ++var9, this.gameByteStateAL);
            GameCanvas.writePersistentByte(var1, ++var9, this.gameByteStateBF);
            debugLog("indexOffset waves: " + ++var9);
            break;
         case 3:
            int var8 = 0;

            for (int var2 = 0; var2 < this.unlockedLevelFlags.Length; var2++) {
               GameCanvas.writePersistentBoolean(var1, var8, this.unlockedLevelFlags[var2]);
               var8++;
            } break;
      }

      GameCanvas.writePersistentRecord(var1, recordStoreNames[var1]);
   }

   // $VF: renamed from: d (byte) void
   public void playSoundEffect(sbyte var1) {
      bool var4 = false;
      switch (var1) {
         case 0:
            if (GameCanvas.readPersistentRecord(var1, recordStoreNames[var1])) {
               this.gameByteStateB = GameCanvas.readPersistentByte(var1, 0);
            } else {
               this.gameByteStateB = -1;
            }
            break;
         case 1:
            if (GameCanvas.readPersistentRecord(var1, recordStoreNames[var1])) {
               this.localizedTextVariant = GameCanvas.readPersistentByte(var1, 0);
            } else {
               this.localizedTextVariant = 1;
            }
            break;
         case 2:
            if (GameCanvas.readPersistentRecord(var1, recordStoreNames[var1])) {
               int var9 = 0;
               this.playerHealth = GameCanvas.readPersistentInteger(var1, var9);
               this.playerAmmo = GameCanvas.readPersistentInteger(var1, ++var9);
               this.playerGrenades = GameCanvas.readPersistentInteger(var1, ++var9);
               this.playerCredits = GameCanvas.readPersistentInteger(var1, ++var9);
               this.gameIntegerStateAG = GameCanvas.readPersistentInteger(var1, ++var9);
               this.activeCharacterState.characterAnimationByteStateD = GameCanvas.readPersistentByte(var1, ++var9);
               this.activeCharacterState.characterAnimationObjectReferenceA.actionCounter = GameCanvas.readPersistentByte(var1, ++var9);
               this.gameIntegerStateAI = GameCanvas.readPersistentInteger(var1, ++var9);
               var9++;

               for (int var5 = 0; var5 < 6; var5++) {
                  this.activeCharacterState.characterAnimationFlagArrayA[var5] = GameCanvas.readPersistentBoolean(var1, var9);
                  var9++;
               }

               for (int var6 = 0; var6 < 6; var6++) {
                  this.activeCharacterState.characterAnimationByteStateArrayA[var6] = GameCanvas.readPersistentByte(var1, var9);
                  var9++;
               }

               for (int var7 = 0; var7 < this.levelGrid.Length; var7++) {
                  for (int var3 = 0; var3 < this.levelGrid[var7].Length; var3++) {
                     this.levelGrid[var7][var3] = GameCanvas.readPersistentByte(var1, var9);
                     var9++;
                  }
               }

               this.gameByteStateBE = GameCanvas.readPersistentByte(var1, var9);
               this.gameByteStateBC = GameCanvas.readPersistentByte(var1, ++var9);
               this.gameIntegerStateAH = GameCanvas.readPersistentInteger(var1, ++var9);
               this.gameByteStateAL = GameCanvas.readPersistentByte(var1, ++var9);
               this.gameByteStateBF = GameCanvas.readPersistentByte(var1, ++var9);
               var9++;
            } else {
               this.playerHealth = 0;
               this.playerAmmo = 0;
               this.playerGrenades = 0;
               this.playerCredits = 0;
               this.gameIntegerStateAG = 0;
               this.gameByteStateBF = 0;
            }
            break;
         case 3:
            int var8 = 0;
            if (GameCanvas.readPersistentRecord(var1, recordStoreNames[var1])) {
               for (int var2 = 0; var2 < this.unlockedLevelFlags.Length; var2++) {
                  this.unlockedLevelFlags[var2] = GameCanvas.readPersistentBoolean(var1, var8);
                  var8++;
               }
            } break;
      }
   }

   // $VF: renamed from: b (byte, boolean) void
   public void dispatchAudioEvent(sbyte var1, bool var2) {
      switch (var1) {
         case 2:
            if (GameCanvas.readPersistentRecord(2, recordStoreNames[2])) {
               this.playerHealth = 0;
               this.playerAmmo = 0;
               this.playerGrenades = 0;
               this.playerCredits = 0;
               this.gameIntegerStateAG = 0;
               this.activeCharacterState.characterAnimationByteStateD = 1;
               this.activeCharacterState.characterAnimationObjectReferenceA.actionCounter = 16;
               this.gameIntegerStateAI = 0;

               for (int var3 = 0; var3 < 6; var3++) {
                  this.activeCharacterState.characterAnimationFlagArrayA[var3] = false;
               }

               this.activeCharacterState.characterAnimationFlagArrayA[0] = true;
               this.activeCharacterState.characterAnimationFlagArrayA[5] = true;
               this.activeCharacterState.characterAnimationFlagArrayA[1] = true;
               this.primaryCharacterState.characterAnimationByteStateB = 0;
               this.primaryCharacterState.characterAnimationByteStateD = 1;
               this.primaryCharacterState.characterAnimationByteStateArrayA[0] = 0;
               this.primaryCharacterState.characterAnimationByteStateArrayA[1] = 25;
               this.primaryCharacterState.characterAnimationByteStateArrayA[2] = 0;
               this.primaryCharacterState.characterAnimationByteStateArrayA[3] = 0;
               this.primaryCharacterState.characterAnimationByteStateArrayA[4] = 0;
               this.primaryCharacterState.characterAnimationByteStateArrayA[5] = 1;
               this.clearLevelGrid();
               this.gameByteStateBE = 0;
               this.gameByteStateBC = 0;
               this.gameIntegerStateAH = 0;
               this.gameByteStateAL = 2;
               this.gameByteStateBF = 0;
               this.playMusicTrack((sbyte)2);
            }
            break;
         case 3:
            if (GameCanvas.readPersistentRecord(3, recordStoreNames[3])) {
               this.clearUnlockedLevelFlags();
               this.gameIntegerStateAL = 1;
               this.playMusicTrack((sbyte)3);
            } break;
      }

      JSystem.gc();
   }

   // $VF: renamed from: b (java.lang.String) void
   public static void debugLog(string var0) {
   }

   // $VF: renamed from: a (long) void
   public void sleepForMilliseconds(long var1) {
      try {
         Thread.sleep(var1);
      } catch (System.Exception var4) {
      }
   }

   // $VF: renamed from: l (int) int
   public static int normalizePositiveInteger(int var0) {
      if (var0 <= 0) {
         return 1;
      } else if (var0 == 0) {
         return 0;
      } else {
         int var2 = 0;

         for (int var1 = 15; var1 >= 0; var1--) {
            int var3 = var2 + (1 << var1);
            if (var0 >= var3 << var1) {
               var0 -= var3 << var1;
               var2 |= 2 << var1;
            }
         }

         return var2 >> 1;
      }
   }

   // alias for obfuscated name 'O'
   public void O() { applyCheatPriceModifiers(); }

   // alias for obfuscated name 'a'
   public void a(GameCanvas var1) { attachCanvas(var1); }

   // alias for obfuscated name 'a'
   public void a() { releaseFontResources(); }

   // alias for obfuscated name 'a'
   public void a(sbyte var1, bool var2) { resetGameSession(var1, var2); }

   // alias for obfuscated name 'b'
   public void b() { stopGameScreen(); }

   // alias for obfuscated name 'c'
   public void c() { onCanvasHidden(); }

   // alias for obfuscated name 'd'
   public void d() { onCanvasShown(); }

   // alias for obfuscated name 'a'
   public void a(int var1) { advanceGameplayStateTimer(var1); }

   // alias for obfuscated name 'b'
   public void b(int var1) { shiftAnimationStartTimes(var1); }

   // alias for obfuscated name 'P'
   public void P() { beginScreenInitialization(); }

   // alias for obfuscated name 'Q'
   public void Q() { resetScreenInitialization(); }

   // alias for obfuscated name 'R'
   public void R() { clearGameActionFlags(); }

   // alias for obfuscated name 'c'
   public void c(int var1) { onKeyPressed(var1); }

   // alias for obfuscated name 'd'
   public void d(int var1) { onKeyRepeated(var1); }

   // alias for obfuscated name 'e'
   public void e(int var1) { onKeyReleased(var1); }

   // alias for obfuscated name 'a'
   public void a(int var1, int var2) { onPointerPressed(var1, var2); }

   // alias for obfuscated name 'b'
   public void b(int var1, int var2) { onPointerReleased(var1, var2); }

   // alias for obfuscated name 'c'
   public void c(int var1, int var2) { onCanvasSizeChanged(var1, var2); }

   // alias for obfuscated name 'f'
   public bool f(int var1) { return consumeGameFlag(var1); }

   // alias for obfuscated name 'e'
   public void e() { updateFrameTiming(); }

   // alias for obfuscated name 'S'
   public void S() { initializeCurrentScreen(); }

   // alias for obfuscated name 'f'
   public void f() { configureAboutDialog(); }

   // alias for obfuscated name 'g'
   public void g() { initializeGameplay(); }

   // alias for obfuscated name 'T'
   public void T() { processGameState(); }

   // alias for obfuscated name 'm'
   public bool m(int var1) { return isPressedInputFlagSet(var1); }

   // alias for obfuscated name 'n'
   public bool n(int var1) { return isReleasedInputFlagSet(var1); }

   // alias for obfuscated name 'U'
   public void U() { clearLevelGrid(); }

   // alias for obfuscated name 'V'
   public void V() { initializeMedicalItemState(); }

   // alias for obfuscated name 'd'
   public bool d(int var1, int var2) { return loadObjectImage(var1, var2); }

   // alias for obfuscated name 'g'
   public void g(int var1) { releaseObjectImage(var1); }

   // alias for obfuscated name 'a'
   public void a(int var1, bool var2) { initializeGameObjects(var1, var2); }

   // alias for obfuscated name 'h'
   public void h() { resetWorldObjectStates(); }

   // alias for obfuscated name 'i'
   public void i() { initializeLevelState(); }

   // alias for obfuscated name 'a'
   public void a(ActorRuntimeState var1, bool var2) { setActiveActor(var1, var2); }

   // alias for obfuscated name 'W'
   public bool W() { return canActorMoveForward(); }

   // alias for obfuscated name 'j'
   public bool j() { return clearObjectImageCache(); }

   // alias for obfuscated name 'k'
   public void k() { resetActorStates(); }

   // alias for obfuscated name 'a'
   public ActorRuntimeState a(int var1, int var2, int var3, int var4) { return spawnActor(var1, var2, var3, var4); }

   // alias for obfuscated name 'l'
   public bool l() { return loadLevelData(); }

   // alias for obfuscated name 'a'
   public void a(string var1) { loadLevelObjectCoordinates(var1); }

   // alias for obfuscated name 'a'
   public bool a(short[] var1, string var2, int var3) { return readUnsignedResourceBytes(var1, var2, var3); }

   // alias for obfuscated name 'm'
   public bool m() { return validateLevelData(); }

   // alias for obfuscated name 'n'
   public void n() { initializeActorStates(); }

   // alias for obfuscated name 'a'
   public void a(ActorRuntimeState var1, int var2) { drawActorShadow(var1, var2); }

   // alias for obfuscated name 'b'
   public void b(ActorRuntimeState var1, int var2) { setActorDirection(var1, var2); }

   // alias for obfuscated name 'o'
   public void o() { prepareMainMenuImages(); }

   // alias for obfuscated name 'X'
   public void X() { advanceScreenInitializationMode10(); }

   // alias for obfuscated name 'p'
   public void p() { setLocalizedScreenMessage(); }

   // alias for obfuscated name 'q'
   public void q() { advanceScreenInitializationMode6(); }

   // alias for obfuscated name 'r'
   public void r() { advanceScreenInitializationMode22(); }

   // alias for obfuscated name 's'
   public void s() { advanceScreenInitializationMode16(); }

   // alias for obfuscated name 't'
   public void t() { advanceScreenInitializationMode18(); }

   // alias for obfuscated name 'u'
   public void u() { advanceScreenInitializationMode17(); }

   // alias for obfuscated name 'v'
   public void v() { advanceScreenInitializationMode20(); }

   // alias for obfuscated name 'w'
   public void w() { advanceScreenInitializationMode19(); }

   // alias for obfuscated name 'x'
   public void x() { advanceScreenInitializationMode21(); }

   // alias for obfuscated name 'Y'
   public void Y() { advanceScreenInitializationMode8(); }

   // alias for obfuscated name 'Z'
   public void Z() { releaseResourcesForScreenAction(); }

   // alias for obfuscated name 'a'
   public void a(Graphics var1) { renderScreen(var1); }

   // alias for obfuscated name 'y'
   public void y() { updateScreen(); }

   // alias for obfuscated name 'aa'
   public void aa() { initializeGameMode(); }

   // alias for obfuscated name 'a'
   public void a(Graphics var1, string var2) { drawScrollingMessage(var1, var2); }

   // alias for obfuscated name 'e'
   public void e(Graphics var1) { renderTitleScreen(var1); }

   // alias for obfuscated name 'f'
   public void f(Graphics var1) { renderDialogMenuScreen(var1); }

   // alias for obfuscated name 'g'
   public void g(Graphics var1) { renderConfirmationMenuScreen(var1); }

   // alias for obfuscated name 'h'
   public void h(Graphics var1) { renderStartupScreen(var1); }

   // alias for obfuscated name 'i'
   public void i(Graphics var1) { renderActionScreen(var1); }

   // alias for obfuscated name 'j'
   public void j(Graphics var1) { clearCanvas(var1); }

   // alias for obfuscated name 'z'
   public void z() { resetScreenState(); }

   // alias for obfuscated name 'k'
   public void k(Graphics var1) { renderTitleBackground(var1); }

   // alias for obfuscated name 'l'
   public void l(Graphics var1) { renderGameplayView(var1); }

   // alias for obfuscated name 'm'
   public void m(Graphics var1) { renderInventoryView(var1); }

   // alias for obfuscated name 'ab'
   public sbyte ab() { return countSelectedInventoryItems(); }

   // alias for obfuscated name 'ac'
   public void ac() { rebuildInventoryItemIndices(); }

   // alias for obfuscated name 'n'
   public void n(Graphics var1) { renderCanvasHiddenPrompt(var1); }

   // alias for obfuscated name 'a'
   public void a(Graphics var1, int var2, int var3, int var4, int var5) { drawHudFrame(var1, var2, var3, var4, var5); }

   // alias for obfuscated name 'b'
   public void b(Graphics var1) { renderStatusHud(var1); }

   // alias for obfuscated name 'a'
   public void a(Graphics var1, sbyte var2, int var3, int var4) { drawItemPortrait(var1, var2, var3, var4); }

   // alias for obfuscated name 'ad'
   public bool ad() { return isCharacterActionComplete(); }

   // alias for obfuscated name 'a'
   public void a(Graphics var1, int var2, int var3, int var4) { renderLevelRegion(var1, var2, var3, var4); }

   // alias for obfuscated name 'o'
   public void o(Graphics var1) { renderMedicalItem(var1); }

   // alias for obfuscated name 'c'
   public void c(Graphics var1) { collectVisibleEntities(var1); }

   // alias for obfuscated name 'a'
   public void a(Graphics var1, int var2) { drawAnimatedEntity(var1, var2); }

   // alias for obfuscated name 'b'
   public void b(Graphics var1, int var2) { drawLevelObject(var1, var2); }

   // alias for obfuscated name 'd'
   public void d(Graphics var1) { renderLevelScene(var1); }

   // alias for obfuscated name 'a'
   public void a(Graphics var1, int var2, int var3, int var4, int var5, int var6, int var7) { renderTileLayer(var1, var2, var3, var4, var5, var6, var7); }

   // alias for obfuscated name 'a'
   public void a(Graphics var1, short var2, bool var3, bool var4, int var5, int var6) { drawTileSprite(var1, var2, var3, var4, var5, var6); }

   // alias for obfuscated name 'b'
   public void b(Graphics var1, int var2, int var3, int var4, int var5) { drawLine(var1, var2, var3, var4, var5); }

   // alias for obfuscated name 'c'
   public void c(Graphics var1, int var2, int var3, int var4, int var5) { drawRectangleOutline(var1, var2, var3, var4, var5); }

   // alias for obfuscated name 'd'
   public void d(Graphics var1, int var2, int var3, int var4, int var5) { fillRectangle(var1, var2, var3, var4, var5); }

   // alias for obfuscated name 'b'
   public void b(Graphics var1, int var2, int var3, int var4) { setRgbColor(var1, var2, var3, var4); }

   // alias for obfuscated name 'c'
   public void c(Graphics var1, int var2) { setPackedColor(var1, var2); }

   // alias for obfuscated name 'a'
   public bool a(int var1, int var2, int var3, int var4, int var5, int var6, int var7, int var8) { return rectanglesOverlap(var1, var2, var3, var4, var5, var6, var7, var8); }

   // alias for obfuscated name 'a'
   public bool a(int var1, int var2, int var3, int var4, int var5, int var6) { return containsPoint(var1, var2, var3, var4, var5, var6); }

   // alias for obfuscated name 'a'
   public int a(int var1, int var2, int var3) { return clampInteger(var1, var2, var3); }

   // alias for obfuscated name 'h'
   public int h(int var1) { return squareInteger(var1); }

   // alias for obfuscated name 'A'
   public int A() { return nextRandomByte(); }

   // alias for obfuscated name 'i'
   public static int i(int var0) { return nextRandomBelow(var0); }

   // alias for obfuscated name 'B'
   public int B() { return nextRandomColor(); }

   // alias for obfuscated name 'a'
   public void a(Graphics var1, int var2, int var3, int var4, int var5, int var6, int var7, int var8, int var9) { drawClippedSprite(var1, var2, var3, var4, var5, var6, var7, var8, var9); }

   // alias for obfuscated name 'a'
   public void a(Graphics var1, int var2, int var3, int var4, int var5, int var6, int var7, int var8, int var9, int var10, int var11, bool var12) { drawObjectSprite(var1, var2, var3, var4, var5, var6, var7, var8, var9, var10, var11, var12); }

   // alias for obfuscated name 'a'
   public bool a(ActorRuntimeState var1) { return actorHasShadow(var1); }

   // alias for obfuscated name 'j'
   public void j(int var1) { toggleObjectFlip(var1); }

   // alias for obfuscated name 'C'
   public void C() { resetPlayerEffectState(); }

   // alias for obfuscated name 'a'
   public void a(Graphics var1, ActorRuntimeState var2, int var3, int var4) { drawActor(var1, var2, var3, var4); }

   // alias for obfuscated name 'a'
   public void a(Graphics var1, ActorRuntimeState var2, int var3, int var4, int var5, int var6, bool var7) { drawActorAttachments(var1, var2, var3, var4, var5, var6, var7); }

   // alias for obfuscated name 'b'
   public void b(Graphics var1, ActorRuntimeState var2, int var3, int var4) { drawActorOverrideFrame(var1, var2, var3, var4); }

   // alias for obfuscated name 'f'
   public bool f(ActorRuntimeState var1) { return isActorInTemporaryAnimation(var1); }

   // alias for obfuscated name 'a'
   public bool a(ActorRuntimeState var1, int var2, int var3) { return isDirectionWithinRange(var1, var2, var3); }

   // alias for obfuscated name 'p'
   public void p(Graphics var1) { renderMenuOverlayMode1(var1); }

   // alias for obfuscated name 'q'
   public void q(Graphics var1) { renderMenuOverlayMode18(var1); }

   // alias for obfuscated name 'r'
   public void r(Graphics var1) { renderLevelSelectionDialog(var1); }

   // alias for obfuscated name 's'
   public void s(Graphics var1) { renderDialogAndMenuMode20(var1); }

   // alias for obfuscated name 't'
   public void t(Graphics var1) { renderMenuOverlayMode19(var1); }

   // alias for obfuscated name 'u'
   public void u(Graphics var1) { renderMenuOverlayMode21(var1); }

   // alias for obfuscated name 'v'
   public void v(Graphics var1) { renderDialogAndMenuMode22(var1); }

   // alias for obfuscated name 'w'
   public void w(Graphics var1) { renderMenuWithDescriptionMode16(var1); }

   // alias for obfuscated name 'x'
   public void x(Graphics var1) { renderMenuOverlayMode6(var1); }

   // alias for obfuscated name 'y'
   public void y(Graphics var1) { renderMessageDialogMode10(var1); }

   // alias for obfuscated name 'z'
   public void z(Graphics var1) { renderCharacterPortraitHud(var1); }

   // alias for obfuscated name 'e'
   public int e(int var1, int var2) { return tileToScreenX(var1, var2); }

   // alias for obfuscated name 'f'
   public int f(int var1, int var2) { return tileToScreenY(var1, var2); }

   // alias for obfuscated name 'g'
   public int g(int var1, int var2) { return screenToTileX(var1, var2); }

   // alias for obfuscated name 'h'
   public int h(int var1, int var2) { return screenToTileY(var1, var2); }

   // alias for obfuscated name 'i'
   public void i(int var1, int var2) { setCameraPosition(var1, var2); }

   // alias for obfuscated name 'D'
   public bool D() { return isCharacterAnimating(); }

   // alias for obfuscated name 'j'
   public int j(int var1, int var2) { return scaleByFrameDelta(var1, var2); }

   // alias for obfuscated name 'c'
   public void c(string var1) { setPendingMessage(var1); }

   // alias for obfuscated name 'E'
   public void E() { configureLanguageSelectionMenu(); }

   // alias for obfuscated name 'ae'
   public void ae() { configureMessageAndChoiceMenu(); }

   // alias for obfuscated name 'af'
   public void af() { configureInformationDialog(); }

   // alias for obfuscated name 'ag'
   public void ag() { configureContinueMenu(); }

   // alias for obfuscated name 'ah'
   public void ah() { configureMainMenu(); }

   // alias for obfuscated name 'ai'
   public void ai() { configureOptionsMenu(); }

   // alias for obfuscated name 'aj'
   public void aj() { configureMissionMenu(); }

   // alias for obfuscated name 'ak'
   public void ak() { configureLevelSelectionMenu(); }

   // alias for obfuscated name 'al'
   public void al() { clearUnlockedLevelFlags(); }

   // alias for obfuscated name 'am'
   public void am() { configureConfirmationDialog(); }

   // alias for obfuscated name 'an'
   public void an() { configureNewGameMenu(); }

   // alias for obfuscated name 'ao'
   public void ao() { configureSaveGameMenu(); }

   // alias for obfuscated name 'ap'
   public void ap() { configureExitDialog(); }

   // alias for obfuscated name 'aq'
   public void aq() { configureBriefingMenu(); }

   // alias for obfuscated name 'ar'
   public void ar() { configureHelpMenu(); }

   // alias for obfuscated name 'a'
   public void a(sbyte var1, sbyte var2) { setCharacterPortraitIndices(var1, var2); }

   // alias for obfuscated name 'at'
   public void at() { closeMessageAndMenu(); }

   // alias for obfuscated name 'au'
   public void au() { updateMissionCompletion(); }

   // alias for obfuscated name 'av'
   public void av() { clearMainMenu(); }

   // alias for obfuscated name 'aw'
   public void aw() { processMenuAction(); }

   // alias for obfuscated name 'ax'
   public void ax() { resetMenuState(); }

   // alias for obfuscated name 'ay'
   public void ay() { configureDialogChoiceLayout(); }

   // alias for obfuscated name 'az'
   public void az() { configureSoundOptionsMenu(); }

   // alias for obfuscated name 'aA'
   public void aA() { configureLanguageMenu(); }

   // alias for obfuscated name 'aB'
   public void aB() { configureControlOptionsMenu(); }

   // alias for obfuscated name 'aC'
   public void aC() { configureExitOptionsMenu(); }

   // alias for obfuscated name 'aD'
   public void aD() { configureRestartConfirmation(); }

   // alias for obfuscated name 'aE'
   public void aE() { completeGameTransition(); }

   // alias for obfuscated name 'aF'
   public void aF() { configureGameOverScreen(); }

   // alias for obfuscated name 'aG'
   public void aG() { processScreenAction(); }

   // alias for obfuscated name 'aH'
   public void aH() { configureCreditsScreen(); }

   // alias for obfuscated name 'a'
   public void a(sbyte var1) { cycleLocalizationVariant(var1); }

   // alias for obfuscated name 'aI'
   public void aI() { updateGameModeState(); }

   // alias for obfuscated name 'aJ'
   public void aJ() { processGameInput(); }

   // alias for obfuscated name 'aK'
   public int aK() { return getInventoryActionResult(); }

   // alias for obfuscated name 'aL'
   public void aL() { playItemCue(); }

   // alias for obfuscated name 'a'
   public bool a(short var1) { return hasCollectedItem(var1); }

   // alias for obfuscated name 'aM'
   public void aM() { clearCollectedItemFlags(); }

   // alias for obfuscated name 'aN'
   public void aN() { updateCharacterAnimation(); }

   // alias for obfuscated name 'a'
   public void a(bool var1) { resetActiveActors(var1); }

   // alias for obfuscated name 'F'
   public void F() { loadActorSprites(); }

   // alias for obfuscated name 'G'
   public void G() { initializeLevelTransition(); }

   // alias for obfuscated name 'c'
   public void c(ActorRuntimeState var1, int var2) { updateActorAnimation(var1, var2); }

   // alias for obfuscated name 'H'
   public void H() { updateWorldObjects(); }

   // alias for obfuscated name 'a'
   public int a(int var1, int var2, int var3, int var4, int var5, sbyte var6) { return spawnAnimatedEffect(var1, var2, var3, var4, var5, var6); }

   // alias for obfuscated name 'a'
   public int a(int var1, int var2, int var3, int var4, int var5) { return createWorldObject(var1, var2, var3, var4, var5); }

   // alias for obfuscated name 'b'
   public void b(ActorRuntimeState var1, int var2, int var3) { faceActorTowardPoint(var1, var2, var3); }

   // alias for obfuscated name 'b'
   public void b(ActorRuntimeState var1) { moveActorTowardTarget(var1); }

   // alias for obfuscated name 'c'
   public bool c(ActorRuntimeState var1, int var2, int var3) { return isActorAdjacentAndFacingTarget(var1, var2, var3); }

   // alias for obfuscated name 'd'
   public void d(ActorRuntimeState var1, int var2, int var3) { setActorDestination(var1, var2, var3); }

   // alias for obfuscated name 'I'
   public void I() { updateActorTargeting(); }

   // alias for obfuscated name 'a'
   public ScheduledEventNode a(ScheduledEventNode var1, ScheduledEventNode var2) { return unlinkScheduledEvent(var1, var2); }

   // alias for obfuscated name 'b'
   public ScheduledEventNode b(ScheduledEventNode var1, ScheduledEventNode var2) { return insertScheduledEvent(var1, var2); }

   // alias for obfuscated name 'b'
   public void b(int var1, int var2, int var3, int var4) { scheduleEvent(var1, var2, var3, var4); }

   // alias for obfuscated name 'J'
   public void J() { buildCollisionMap(); }

   // alias for obfuscated name 'a'
   public bool a(int var1, int var2, int var3, bool var4) { return isTilePassable(var1, var2, var3, var4); }

   // alias for obfuscated name 'a'
   public int a(int var1, int var2, int var3, int var4, bool var5) { return resolveCollision(var1, var2, var3, var4, var5); }

   // alias for obfuscated name 'b'
   public int b(int var1, int var2, int var3, bool var4) { return isActorAtTile(var1, var2, var3, var4); }

   // alias for obfuscated name 'd'
   public void d(ActorRuntimeState var1, int var2) { setActorAnimationState(var1, var2); }

   // alias for obfuscated name 'b'
   public int b(int var1, int var2, int var3) { return findWorldObjectAtTile(var1, var2, var3); }

   // alias for obfuscated name 'c'
   public bool c(ActorRuntimeState var1) { return advanceActorMovement(var1); }

   // alias for obfuscated name 'K'
   public void K() { updatePlayerAction(); }

   // alias for obfuscated name 'd'
   public bool d(ActorRuntimeState var1) { return isActorActionAllowed(var1); }

   // alias for obfuscated name 'k'
   public void k(int var1) { setPlayerAction(var1); }

   // alias for obfuscated name 'k'
   public void k(int var1, int var2) { setCharacterAnimation(var1, var2); }

   // alias for obfuscated name 'o'
   public void o(int var1) { findActorInFront(var1); }

   // alias for obfuscated name 'p'
   public bool p(int var1) { return isActorInFront(var1); }

   // alias for obfuscated name 'aO'
   public void aO() { updateCharacterEffects(); }

   // alias for obfuscated name 'b'
   public sbyte b(sbyte var1) { return getInventoryFacingDirection(var1); }

   // alias for obfuscated name 'aP'
   public sbyte aP() { return getSelectedItemDirection(); }

   // alias for obfuscated name 'e'
   public int e(ActorRuntimeState var1) { return findNearbyActor(var1); }

   // alias for obfuscated name 'e'
   public void e(ActorRuntimeState var1, int var2, int var3) { faceActorTowardTile(var1, var2, var3); }

   // alias for obfuscated name 'c'
   public int c(int var1, int var2, int var3) { return offsetTileXForward(var1, var2, var3); }

   // alias for obfuscated name 'd'
   public int d(int var1, int var2, int var3) { return offsetTileYForward(var1, var2, var3); }

   // alias for obfuscated name 'e'
   public int e(int var1, int var2, int var3) { return offsetTileXSideways(var1, var2, var3); }

   // alias for obfuscated name 'f'
   public int f(int var1, int var2, int var3) { return offsetTileYSideways(var1, var2, var3); }

   // alias for obfuscated name 'g'
   public int g(int var1, int var2, int var3) { return offsetTileXAcross(var1, var2, var3); }

   // alias for obfuscated name 'h'
   public int h(int var1, int var2, int var3) { return offsetTileYAround(var1, var2, var3); }

   // alias for obfuscated name 'l'
   public int l(int var1, int var2) { return findActorAtTile(var1, var2); }

   // alias for obfuscated name 'L'
   public bool L() { return isCharacterOnWorldObject(); }

   // alias for obfuscated name 'q'
   public void q(int var1) { performWeaponAction(var1); }

   // alias for obfuscated name 'r'
   public bool r(int var1) { return canUseItemInCombat(var1); }

   // alias for obfuscated name 'b'
   public bool b(sbyte var1, sbyte var2) { return equipWeapon(var1, var2); }

   // alias for obfuscated name 'aQ'
   public void aQ() { unequipWeapon(); }

   // alias for obfuscated name 'aR'
   public void aR() { equipAmmunition(); }

   // alias for obfuscated name 's'
   public bool s(int var1) { return performRangedAttack(var1); }

   // alias for obfuscated name 'aS'
   public bool aS() { return hasInventoryCapacity(); }

   // alias for obfuscated name 'c'
   public bool c(sbyte var1, sbyte var2) { return useAmmunition(var1, var2); }

   // alias for obfuscated name 'd'
   public bool d(sbyte var1, sbyte var2) { return useMedicalItem(var1, var2); }

   // alias for obfuscated name 't'
   public bool t(int var1) { return performSecondaryAction(var1); }

   // alias for obfuscated name 'M'
   public void M() { consumeAmmunition(); }

   // alias for obfuscated name 'aT'
   public void aT() { applyHealingItem(); }

   // alias for obfuscated name 'aU'
   public void aU() { initializeAudioManager(); }

   // alias for obfuscated name 'm'
   public void m(int var1, int var2) { playAudioCue(var1, var2); }

   // alias for obfuscated name 'N'
   public void N() { disposeAudioManager(); }

   // alias for obfuscated name 'c'
   public void c(sbyte var1) { playMusicTrack(var1); }

   // alias for obfuscated name 'd'
   public void d(sbyte var1) { playSoundEffect(var1); }

   // alias for obfuscated name 'b'
   public void b(sbyte var1, bool var2) { dispatchAudioEvent(var1, var2); }

   // alias for obfuscated name 'b'
   public static void b(string var0) { debugLog(var0); }

   // alias for obfuscated name 'a'
   public void a(long var1) { sleepForMilliseconds(var1); }

   // alias for obfuscated name 'l'
   public static int l(int var0) { return normalizePositiveInteger(var0); }
}
}
