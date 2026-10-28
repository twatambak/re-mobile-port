import com.capcomeuro.midp.CapcomMIDlet;
import java.io.DataInputStream;
import java.io.IOException;
import java.io.InputStream;
import java.util.Random;
import javax.microedition.lcdui.Graphics;
import javax.microedition.lcdui.Image;

// $VF: renamed from: c
public class class_17 implements class_0 {
   // $VF: renamed from: a boolean
   boolean field_134 = false;
   // $VF: renamed from: b boolean
   boolean field_135 = false;
   // $VF: renamed from: c byte
   public byte field_136 = 0;
   // $VF: renamed from: bl com.capcomeuro.midp.CapcomMIDlet
   private CapcomMIDlet field_137;
   // $VF: renamed from: bm w
   private class_25 field_138;
   // $VF: renamed from: bn p
   private class_7 field_139;
   // $VF: renamed from: bo o
   private class_1 field_140;
   // $VF: renamed from: bp javax.microedition.lcdui.Image
   private Image field_141 = null;
   // $VF: renamed from: bq javax.microedition.lcdui.Image[]
   private Image[] field_142 = null;
   // $VF: renamed from: br java.lang.String[]
   private String[] field_143;
   // $VF: renamed from: bs java.lang.String[][]
   private String[][] field_144;
   // $VF: renamed from: bt byte
   private byte field_145 = 1;
   // $VF: renamed from: bu byte[]
   private byte[] field_146 = new byte[]{0, 20, 40, 60, 80, 100};
   // $VF: renamed from: bv byte[]
   private byte[] field_147 = new byte[2];
   // $VF: renamed from: bw java.lang.String
   private String field_148 = null;
   // $VF: renamed from: bx int
   private int field_149 = 0;
   // $VF: renamed from: by int
   private int field_150 = 0;
   // $VF: renamed from: d int
   protected static int field_151;
   // $VF: renamed from: e int
   protected static int field_152;
   // $VF: renamed from: f int
   protected static int field_153;
   // $VF: renamed from: g int
   protected static int field_154;
   // $VF: renamed from: h boolean
   boolean field_155 = false;
   // $VF: renamed from: i boolean
   boolean field_156 = false;
   // $VF: renamed from: bz boolean
   private boolean field_157 = true;
   // $VF: renamed from: bA byte
   private byte field_158 = 0;
   // $VF: renamed from: bB byte
   private byte field_159 = 0;
   // $VF: renamed from: bC byte
   private byte field_160 = 0;
   // $VF: renamed from: bD java.util.Random
   private static Random field_161 = new Random();
   // $VF: renamed from: bE boolean
   private boolean field_162;
   // $VF: renamed from: bF boolean
   private boolean field_163 = false;
   // $VF: renamed from: bG byte
   private byte field_164 = -1;
   // $VF: renamed from: bH byte
   private byte field_165 = 0;
   // $VF: renamed from: bI byte
   private byte field_166 = 1;
   // $VF: renamed from: bJ int
   private int field_167;
   // $VF: renamed from: bK int
   private int field_168;
   // $VF: renamed from: bL int
   private int field_169;
   // $VF: renamed from: j byte
   public static byte field_170 = 0;
   // $VF: renamed from: k byte
   public static byte field_171 = -1;
   // $VF: renamed from: l byte
   public static byte field_172 = -1;
   // $VF: renamed from: m byte
   public static byte field_173 = 0;
   // $VF: renamed from: n k
   public class_22 field_174;
   // $VF: renamed from: bM byte
   private static byte field_175 = -1;
   // $VF: renamed from: bN byte
   private static byte field_176 = -1;
   // $VF: renamed from: bO byte
   private static byte field_177 = -1;
   // $VF: renamed from: bP byte
   private static byte field_178 = -1;
   // $VF: renamed from: bQ byte
   private static byte field_179 = -1;
   // $VF: renamed from: bR byte
   private static byte field_180 = -1;
   // $VF: renamed from: bS byte
   private static byte field_181 = -1;
   // $VF: renamed from: bT byte
   private static byte field_182 = -1;
   // $VF: renamed from: bU byte
   private static byte field_183 = -1;
   // $VF: renamed from: bV byte
   private static byte field_184 = -1;
   // $VF: renamed from: bW byte
   private static byte field_185 = -1;
   // $VF: renamed from: bX byte
   private static byte field_186 = -1;
   // $VF: renamed from: bY byte
   private static byte field_187 = -1;
   // $VF: renamed from: bZ byte
   private static byte field_188 = -1;
   // $VF: renamed from: ca byte
   private static byte field_189 = -1;
   // $VF: renamed from: cb byte
   private static byte field_190 = -1;
   // $VF: renamed from: cc byte
   private static byte field_191 = -1;
   // $VF: renamed from: cd byte
   private static byte field_192 = -1;
   // $VF: renamed from: ce byte
   private static byte field_193 = -1;
   // $VF: renamed from: cf byte
   private static byte field_194 = -1;
   // $VF: renamed from: cg byte
   private static byte field_195 = -1;
   // $VF: renamed from: ch byte
   private static byte field_196 = -1;
   // $VF: renamed from: ci java.lang.String[]
   private static String[] field_197 = null;
   // $VF: renamed from: cj t
   private class_20 field_198 = null;
   // $VF: renamed from: o int
   int field_199 = 0;
   // $VF: renamed from: ck int
   private int field_200 = 0;
   // $VF: renamed from: cl boolean
   private boolean field_201 = true;
   // $VF: renamed from: cm long
   private long field_202 = 0L;
   // $VF: renamed from: cn byte
   private byte field_203 = 0;
   // $VF: renamed from: co byte
   private byte field_204 = 0;
   // $VF: renamed from: cp boolean
   private boolean field_205 = false;
   // $VF: renamed from: cq java.util.Random
   private Random field_206 = new Random(System.currentTimeMillis());
   // $VF: renamed from: cr java.lang.String[]
   private static final String[] field_207 = new String[]{"reulang", "reusettings", "reuwaves", "reumissions"};
   // $VF: renamed from: cs boolean
   private boolean field_208 = false;
   // $VF: renamed from: ct byte
   private byte field_209 = -1;
   // $VF: renamed from: cu java.lang.String
   private String field_210 = null;
   // $VF: renamed from: cv java.lang.String
   private String field_211 = null;
   // $VF: renamed from: cw byte
   private byte field_212 = -1;
   // $VF: renamed from: cx boolean
   private boolean field_213 = false;
   // $VF: renamed from: cy int
   private int field_214 = 0;
   // $VF: renamed from: cz int
   private int field_215 = 0;
   // $VF: renamed from: p java.lang.String
   public static String field_216 = null;
   // $VF: renamed from: cA boolean
   private boolean field_217 = false;
   // $VF: renamed from: cB java.lang.String[]
   private String[] field_218 = null;
   // $VF: renamed from: cC byte
   private byte field_219 = 0;
   // $VF: renamed from: cD boolean
   private static boolean field_220 = false;
   // $VF: renamed from: cE boolean
   private boolean field_221 = true;
   // $VF: renamed from: q long
   long field_222;
   // $VF: renamed from: r int
   int field_223;
   // $VF: renamed from: s int
   int field_224;
   // $VF: renamed from: t int
   int field_225;
   // $VF: renamed from: u int
   public int field_226;
   // $VF: renamed from: cF byte
   private byte field_227 = 0;
   // $VF: renamed from: v int[]
   public static final int[] field_228 = new int[]{0, 1, 2, 3, 4, 5};
   // $VF: renamed from: cG byte
   private byte field_229 = 6;
   // $VF: renamed from: cH javax.microedition.lcdui.Image[]
   private Image[] field_230 = new Image[this.field_229];
   // $VF: renamed from: cI short[][]
   private short[][] field_231 = new short[][]{
      {500, 500, 2000, 1200, 10000},
      {0, 0, 10, 5, 70},
      {0, 3, 9, 6, 0},
      {50, 100, 200, 150, 0},
      {400, 400, 1500, 1000, 10000},
      {5, 5, 15, 10, 70},
      {0, 3, 10, 7, 0},
      {75, 200, 400, 300, 0},
      {300, 300, 1200, 800, 10000},
      {10, 10, 20, 15, 70},
      {0, 5, 11, 8, 0},
      {100, 500, 600, 550, 0},
      {300, 300, 800, 600, 10000},
      {15, 15, 25, 20, 70},
      {0, 6, 12, 9, 0}
   };
   // $VF: renamed from: cJ byte[][]
   private byte[][] field_232 = new byte[6][3];
   // $VF: renamed from: cK byte[]
   private byte[] field_233 = new byte[]{0, 99, 30, 60, 8, 3};
   // $VF: renamed from: cL int
   private int field_234 = 0;
   // $VF: renamed from: cM int
   private int field_235 = 0;
   // $VF: renamed from: cN long[]
   private long[] field_236 = new long[5];
   // $VF: renamed from: w byte
   byte field_237 = 10;
   // $VF: renamed from: x byte
   byte field_238;
   // $VF: renamed from: y int[]
   public static final int[] field_239 = new int[]{0, 6, 141, 0, 0, 0, 145, 0, 147, 0, 0, 0};
   // $VF: renamed from: z int[]
   public static final int[] field_240 = new int[]{140, 140, 140, 140, 140, 150, 150, 150, 150, 150, 0};
   // $VF: renamed from: A int[][]
   public static final int[][] field_241 = new int[][]{{0, 0}, {0, 0}, {1, 4}, {0, 0}, {1, 4}, {1, 8}, {1, 8}, {0, 0}, {1, 5}, {1, 4}, {0, 0}, {1, 2}};
   // $VF: renamed from: B int
   int field_242;
   // $VF: renamed from: C int
   int field_243;
   // $VF: renamed from: D g
   class_13 field_244;
   // $VF: renamed from: E g
   class_13 field_245 = new class_13(this);
   // $VF: renamed from: F byte
   byte field_246;
   // $VF: renamed from: G u[]
   class_4[] field_247;
   // $VF: renamed from: H u
   class_4 field_248;
   // $VF: renamed from: I f[]
   class_14[] field_249 = new class_14[5];
   // $VF: renamed from: J d[]
   class_16[] field_250 = new class_16[10];
   // $VF: renamed from: K short[]
   short[] field_251 = new short[150];
   // $VF: renamed from: L byte[]
   byte[] field_252 = new byte[150];
   // $VF: renamed from: M short
   short field_253;
   // $VF: renamed from: N byte[][]
   byte[][] field_254 = new byte[72][50];
   // $VF: renamed from: O j[]
   class_10[] field_255;
   // $VF: renamed from: P j
   class_10 field_256;
   // $VF: renamed from: Q byte
   byte field_257;
   // $VF: renamed from: R byte
   byte field_258;
   // $VF: renamed from: S int
   int field_259;
   // $VF: renamed from: T byte
   byte field_260;
   // $VF: renamed from: U boolean[]
   boolean[] field_261 = new boolean[4];
   // $VF: renamed from: V byte
   byte field_262;
   // $VF: renamed from: W byte
   byte field_263;
   // $VF: renamed from: X byte[][]
   byte[][] field_264;
   // $VF: renamed from: Y short[][]
   short[][] field_265;
   // $VF: renamed from: Z short[][]
   short[][] field_266;
   // $VF: renamed from: aa byte[][]
   byte[][] field_267;
   // $VF: renamed from: ab short
   short field_268;
   // $VF: renamed from: ac short
   short field_269;
   // $VF: renamed from: cO javax.microedition.lcdui.Image
   private Image field_270;
   // $VF: renamed from: ad q
   class_6 field_271 = new class_6();
   // $VF: renamed from: ae int
   int field_272;
   // $VF: renamed from: af int
   int field_273;
   // $VF: renamed from: ag int
   int field_274;
   // $VF: renamed from: ah int
   int field_275;
   // $VF: renamed from: ai int
   int field_276;
   // $VF: renamed from: aj int
   int field_277;
   // $VF: renamed from: ak int
   int field_278;
   // $VF: renamed from: al byte
   byte field_279;
   // $VF: renamed from: am short
   short field_280;
   // $VF: renamed from: an r[]
   class_5[] field_281;
   // $VF: renamed from: ao java.lang.String[]
   public static final String[] field_282 = new String[]{"/data/reu01_large.bin", "/data/reu02_large.bin", "/data/reu03_large.bin", "/data/reu04_large.bin"};
   // $VF: renamed from: ap int[]
   public static final int[] field_283 = new int[]{2698, 3113, 17891, 2940};
   // $VF: renamed from: aq short[][]
   short[][] field_284;
   // $VF: renamed from: ar boolean
   boolean field_285;
   // $VF: renamed from: as int
   int field_286 = 0;
   // $VF: renamed from: at int[][]
   public static final int[][] field_287 = new int[][]{{1, 2}, {1, 2}, {1, 2}, {1, 1}, {1, 2}, {1, 1}, {1, 2}, {1, 2}, {1, 1}, {1, 1}, {3, 5}, {1, 1}};
   // $VF: renamed from: au boolean[]
   boolean[] field_288 = new boolean[183];
   // $VF: renamed from: av javax.microedition.lcdui.Image[]
   Image[] field_289 = new Image[183];
   // $VF: renamed from: aw boolean
   boolean field_290 = false;
   // $VF: renamed from: ax java.util.Random
   Random field_291 = new Random();
   // $VF: renamed from: ay boolean
   boolean field_292;
   // $VF: renamed from: az short
   short field_293;
   // $VF: renamed from: aA short
   short field_294;
   // $VF: renamed from: aB int
   int field_295;
   // $VF: renamed from: aC int
   int field_296;
   // $VF: renamed from: aD int
   int field_297;
   // $VF: renamed from: aE int
   int field_298;
   // $VF: renamed from: aF int
   int field_299;
   // $VF: renamed from: aG int
   int field_300;
   // $VF: renamed from: aH int
   int field_301;
   // $VF: renamed from: aI int
   int field_302;
   // $VF: renamed from: aJ byte
   byte field_303;
   // $VF: renamed from: aK long
   long field_304;
   // $VF: renamed from: aL boolean
   boolean field_305;
   // $VF: renamed from: aM int
   int field_306;
   // $VF: renamed from: aN int
   int field_307;
   // $VF: renamed from: aO int
   int field_308;
   // $VF: renamed from: aP long
   long field_309;
   // $VF: renamed from: aQ int[]
   public static final int[] field_310 = new int[]{
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
   public static final int[][] field_311 = new int[][]{{0, -1}, {-1, 0}, {0, 1}, {1, 0}};
   // $VF: renamed from: aS int
   int field_312;
   // $VF: renamed from: aT int
   int field_313;
   // $VF: renamed from: aU byte
   byte field_314;
   // $VF: renamed from: aV boolean
   boolean field_315;
   // $VF: renamed from: aW boolean
   boolean field_316;
   // $VF: renamed from: aX boolean
   boolean field_317;
   // $VF: renamed from: cP boolean
   private boolean field_318 = true;
   // $VF: renamed from: aY long
   long field_319;
   // $VF: renamed from: cQ byte
   private byte field_320;
   // $VF: renamed from: aZ int
   int field_321;
   // $VF: renamed from: ba int
   int field_322;
   // $VF: renamed from: bb int
   int field_323;
   // $VF: renamed from: cR javax.microedition.lcdui.Image
   private Image field_324;
   // $VF: renamed from: cS javax.microedition.lcdui.Image
   private Image field_325;
   // $VF: renamed from: bc r
   class_5 field_326;
   // $VF: renamed from: cT javax.microedition.lcdui.Image
   private Image field_327;
   // $VF: renamed from: cU byte
   private byte field_328 = 0;
   // $VF: renamed from: cV int
   private final int field_329 = 10;
   // $VF: renamed from: cW int
   private final int field_330 = 0;
   // $VF: renamed from: bd r
   class_5 field_331;
   // $VF: renamed from: cX javax.microedition.lcdui.Image
   private Image field_332;
   // $VF: renamed from: cY byte
   private byte field_333 = 0;
   // $VF: renamed from: cZ int
   private final int field_334 = 10;
   // $VF: renamed from: da int
   private final int field_335 = 0;
   // $VF: renamed from: be r
   class_5 field_336;
   // $VF: renamed from: db javax.microedition.lcdui.Image
   private Image field_337;
   // $VF: renamed from: dc byte
   private byte field_338 = 0;
   // $VF: renamed from: dd int
   private final int field_339 = 3;
   // $VF: renamed from: de int
   private final int field_340 = 0;
   // $VF: renamed from: df long
   private long field_341;
   // $VF: renamed from: dg int[][]
   private static int[][] field_342;
   // $VF: renamed from: dh int
   private int field_343 = 10000;
   // $VF: renamed from: di int
   private final int field_344 = 3000;
   // $VF: renamed from: dj int
   private final int field_345 = 1000;
   // $VF: renamed from: dk byte
   private final byte field_346 = 3;
   // $VF: renamed from: dl byte
   private byte field_347 = -1;
   // $VF: renamed from: dm short[]
   private short[] field_348 = new short[5];
   // $VF: renamed from: dn int
   private int field_349 = 0;
   // $VF: renamed from: do int
   private int field_350 = 0;
   // $VF: renamed from: dp byte
   private byte field_351 = 1;
   // $VF: renamed from: dq byte
   private byte field_352 = 1;
   // $VF: renamed from: dr short
   private short field_353 = 0;
   // $VF: renamed from: ds int
   private int field_354 = 0;
   // $VF: renamed from: dt int
   private int field_355 = 0;
   // $VF: renamed from: du byte
   private byte field_356 = 0;
   // $VF: renamed from: dv short[][]
   private final short[][] field_357 = new short[][]{
      {10, 1, 1, 0, 1, 0, 46},
      {12, 2, 1, 0, 3, 0, 54},
      {3, 1, 1, 0, 1, 1, 272},
      {15, 3, 1, 0, 2, 0, 68},
      {18, 3, 2, 1, 2, 0, 82},
      {1, 1, 1, 0, 1, 2, 300},
      {20, 2, 2, 2, 3, 0, 90},
      {12, 1, 1, 0, 1, 1, 340},
      {21, 3, 2, 2, 3, 0, 94},
      {2, 1, 1, 0, 1, 2, 350},
      {24, 3, 2, 2, 3, 0, 108},
      {32, 4, 3, 3, 4, 0, 96},
      {36, 4, 3, 3, 4, 0, 108},
      {16, 2, 1, 0, 1, 1, 370},
      {4, 2, 1, 0, 1, 2, 350},
      {40, 4, 3, 3, 4, 0, 120},
      {20, 2, 1, 0, 1, 1, 400},
      {44, 4, 3, 3, 4, 0, 132},
      {22, 2, 1, 0, 1, 1, 400},
      {6, 2, 1, 0, 1, 2, 350}
   };
   // $VF: renamed from: dw byte
   private final byte field_358 = (byte)(this.field_357.length - 1);
   // $VF: renamed from: dx byte
   private byte field_359 = 0;
   // $VF: renamed from: dy byte
   private byte field_360 = 0;
   // $VF: renamed from: dz boolean
   private boolean field_361 = true;
   // $VF: renamed from: dA boolean
   private boolean field_362 = false;
   // $VF: renamed from: dB javax.microedition.lcdui.Image
   private Image field_363;
   // $VF: renamed from: dC int
   private int field_364 = 0;
   // $VF: renamed from: dD short[]
   private short[] field_365 = new short[]{2, 8, 4, 50, 25, 400, 200, 1000};
   // $VF: renamed from: dE byte
   private byte field_366;
   // $VF: renamed from: dF boolean
   private boolean field_367 = false;
   // $VF: renamed from: dG byte
   private byte field_368 = 8;
   // $VF: renamed from: dH byte[]
   private byte[] field_369 = new byte[this.field_368];
   // $VF: renamed from: dI byte
   private byte field_370 = 0;
   // $VF: renamed from: dJ boolean
   private boolean field_371 = false;
   // $VF: renamed from: dK boolean
   private boolean field_372 = false;
   // $VF: renamed from: dL boolean
   private boolean field_373 = false;
   // $VF: renamed from: dM int
   private int field_374;
   // $VF: renamed from: dN int
   private int field_375;
   // $VF: renamed from: dO int
   private int field_376 = 1;
   // $VF: renamed from: dP int[][]
   private int[][] field_377 = new int[][]{
      new int[0],
      {0, 0, 16, 2, 3, 1, 16, 120000, 257},
      {1, 0, 3, 1, 33, 1, 16, 0, 288},
      {0, 0, 21, 3, 0, 3, 16, 90000, 3},
      {1, 0, 15, 3, 11, 1, 16, 0, 264},
      {0, 0, 21, 3, 48, 2, 16, 0, 16},
      {0, 0, 21, 3, 37, 3, 16, 110000, 257},
      {1, 0, 3, 1, 1, 1, 16, 0, 800},
      {0, 0, 16, 2, 11, 3, 16, 0, 772},
      {0, 0, 12, 3, 48, 2, 16, 9, 416},
      {1, 2, 3, 1, 43, 1, 16, 0, 256},
      {0, 0, 30, 3, 63, 2, 16, 180000, 323},
      {1, 0, 99, 3, 63, 3, 16, 50, 384}
   };
   // $VF: renamed from: dQ byte
   private final byte field_378 = (byte)(this.field_377.length - 1);
   // $VF: renamed from: dR byte[][]
   private byte[][] field_379 = new byte[][]{
      new byte[0],
      {0, 30, 0, 0, 0, 0},
      {0, 0, 0, 0, 0, 1},
      {0, 0, 0, 0, 0, 0},
      {0, 25, 0, 10, 0, 0},
      {0, 0, 0, 0, 2, 1},
      {0, 0, 20, 0, 0, 2},
      {0, 0, 0, 0, 0, 0},
      {0, 25, 0, 10, 0, 0},
      {0, 0, 0, 0, 3, 1},
      {0, 30, 0, 15, 0, 1},
      {0, 30, 8, 12, 5, 2},
      {0, 40, 4, 12, 2, 1}
   };
   // $VF: renamed from: dS boolean[]
   private boolean[] field_380 = new boolean[this.field_377.length];
   // $VF: renamed from: dT long
   private long field_381;
   // $VF: renamed from: dU long
   private long field_382;
   // $VF: renamed from: dV long
   private long field_383;
   // $VF: renamed from: dW int
   private int field_384 = 0;
   // $VF: renamed from: dX boolean
   private boolean field_385 = false;
   // $VF: renamed from: dY boolean
   private boolean field_386 = true;
   // $VF: renamed from: dZ boolean
   private boolean field_387 = false;
   // $VF: renamed from: ea long
   private long field_388;
   // $VF: renamed from: eb long
   private long field_389;
   // $VF: renamed from: ec byte
   private byte field_390 = 0;
   // $VF: renamed from: ed boolean
   private boolean field_391 = false;
   // $VF: renamed from: ee boolean
   private boolean field_392 = false;
   // $VF: renamed from: ef byte[]
   private byte[] field_393 = new byte[]{12, 24, 42, 56};
   // $VF: renamed from: eg javax.microedition.lcdui.Image
   private Image field_394;
   // $VF: renamed from: eh javax.microedition.lcdui.Image
   private Image field_395;
   // $VF: renamed from: ei javax.microedition.lcdui.Image
   private Image field_396;
   // $VF: renamed from: bf long
   public long field_397;
   // $VF: renamed from: ej boolean
   private static boolean field_398 = false;
   // $VF: renamed from: ek byte[]
   private byte[] field_399;
   // $VF: renamed from: bg int
   int field_400;
   // $VF: renamed from: el boolean
   private boolean field_401 = false;
   // $VF: renamed from: em int
   private int field_402 = 0;
   // $VF: renamed from: en boolean
   private boolean field_403 = false;
   // $VF: renamed from: eo boolean
   private boolean field_404 = false;
   // $VF: renamed from: ep boolean
   private boolean field_405 = false;
   // $VF: renamed from: bh long
   long field_406;
   // $VF: renamed from: bi int
   int field_407;
   // $VF: renamed from: bj int
   int field_408;
   // $VF: renamed from: bk int
   int field_409 = 0;
   // $VF: renamed from: eq int
   private int field_410 = 0;

   // $VF: renamed from: O () void
   private void method_58() {
      if (this.field_134) {
         this.field_365[0] = 1;
         this.field_365[1] = 1;
         this.field_365[2] = 1;
         this.field_365[3] = 1;
         this.field_365[4] = 1;
         this.field_365[5] = 1;
         this.field_365[6] = 1;
         this.field_365[7] = 1;
      } else {
         this.field_365[0] = 2;
         this.field_365[1] = 8;
         this.field_365[2] = 4;
         this.field_365[3] = 50;
         this.field_365[4] = 25;
         this.field_365[5] = 400;
         this.field_365[6] = 200;
         this.field_365[7] = 1000;
      }
   }

   public class_17(CapcomMIDlet var1) {
      this.field_137 = var1;
      this.method_190((byte)-1, (byte)-1);
   }

   // $VF: renamed from: a (w) void
   public void method_2(class_25 var1) {
      this.field_138 = var1;
      this.field_222 = System.currentTimeMillis();
      if (var1.getHeight() >= var1.getWidth()) {
         field_152 = 360;
         field_151 = 384;
         if (CapcomMIDlet.field_521 != 0) {
            field_152 = CapcomMIDlet.field_521;
         }

         if (CapcomMIDlet.field_520 != 0) {
            field_151 = CapcomMIDlet.field_520;
         }

         field_153 = field_152 / 2;
         field_154 = field_151 / 2;
         this.field_164 = this.field_165;
      } else {
         field_152 = var1.getHeight();
         field_151 = var1.getWidth();
         field_153 = field_152 / 2;
         field_154 = field_151 / 2;
         this.field_164 = this.field_166;
      }

      this.field_138.method_348(12);
      this.field_141 = class_25.method_318("/img/capcom_logo.png");
      var1.method_317(2000);
      class_25.method_326();
      class_25.method_324(4);
      class_25.method_325(0, 1);
      class_25.method_325(1, 1);
      class_25.method_325(2, 43);
      class_25.method_325(3, 13);
      this.method_272((byte)0);
      this.method_272((byte)1);
      this.method_59();
      if (this.field_198 == null) {
         this.field_198 = new class_20(var1, this.field_139, (byte)1);
      }

      switch (0) {
         case 0:
            this.field_174 = new class_23(this.field_139, field_152, field_151, var1, false);
            break;
         case 1:
            this.field_174 = new class_24(this.field_139, field_152, field_151, var1);
            this.field_174.f();
            this.field_174.c(1);
      }

      this.field_144 = new String[3][6];
      String var2 = "";

      for (int var3 = 0; var3 < 3; var3++) {
         if (var3 == 0) {
            var2 = "booten";
         } else if (var3 == 1) {
            var2 = "bootes";
         } else if (var3 == 2) {
            var2 = "bootptbr";
         }

         var1.method_337(this.field_144[var3], var2, 3, var3, 6, true, -1);
      }

      this.field_142 = new Image[6];

      for (int var4 = 0; var4 < this.field_142.length; var4++) {
         this.field_142[var4] = class_25.method_318("/img/softkeys/icon_" + var4 + ".png");
      }

      field_170 = 0;
      field_216 = CapcomMIDlet.field_523;
      this.field_217 = class_25.method_323();
      this.method_175();
      this.field_244 = this.field_245;
      this.field_260 = 0;

      for (int var5 = 0; var5 < 5; var5++) {
         this.field_249[var5] = new class_14(this);
      }

      for (int var6 = 0; var6 < 10; var6++) {
         this.field_250[var6] = new class_16(this);
      }

      this.field_400 = 0;
      this.method_150();
      this.method_84();
   }

   // $VF: renamed from: a () void
   public void method_59() {
      this.field_139 = null;
      System.gc();
      this.field_139 = new class_7(2);
      this.field_139.method_27(0, "data/fontlib_title", (byte)2, (byte)11, (byte)13, (short)0, (byte)1);
      this.field_139.method_27(1, "data/fontlib_main", (byte)1, (byte)7, (byte)11, (short)0, (byte)1);
   }

   // $VF: renamed from: a (byte, boolean) void
   public void method_60(byte var1, boolean var2) {
      this.method_66();
      this.field_203 = 0;
      this.field_204 = 0;
      field_170 = var1;
      this.field_205 = var2;
   }

   // $VF: renamed from: b () void
   public void method_61() {
      this.field_157 = false;
      this.field_162 = true;
      this.field_140 = null;
      this.field_139 = null;
      System.gc();
      this.field_137.method_314();
   }

   // $VF: renamed from: c () void
   public void method_8() {
      this.field_162 = true;
      this.method_270();
      this.field_259 = 0;
      if (field_170 == 5 && this.field_226 != 138) {
         this.method_64();
      }
   }

   // $VF: renamed from: d () void
   public void method_9() {
      this.field_162 = false;
      this.method_270();
      this.field_259 = 0;
      if (field_170 == 5 && this.field_226 != 138) {
         this.method_65();
      }
   }

   // $VF: renamed from: a (int) void
   void method_62(int var1) {
      if (field_170 == 5 && this.field_226 != 138) {
         for (int var2 = 0; var2 < 24; var2++) {
            this.field_247[var2].field_27 += (long)var1;
            this.field_247[var2].field_28 += (long)var1;
            if (this.field_247[var2].field_30 != 0L) {
               this.field_247[var2].field_30 += (long)var1;
            }
         }

         this.method_63(var1);
      }
   }

   // $VF: renamed from: b (int) void
   void method_63(int var1) {
      for (int var2 = 0; var2 < 10; var2++) {
         this.field_250[var2].field_123 += (long)var1;
      }
   }

   // $VF: renamed from: P () void
   private void method_64() {
      if (!this.field_156) {
         field_173 = 5;
         field_172 = 18;
         this.method_60((byte)3, false);
         this.field_156 = true;
         this.field_155 = true;
         this.field_167 = 0;
         this.field_320 = 0;
         this.field_222 = System.currentTimeMillis();
         this.field_397 = this.field_222;
      }
   }

   // $VF: renamed from: Q () void
   private void method_65() {
      if (this.field_156) {
         this.field_155 = false;
         this.field_156 = false;
         this.method_269(0, 1);
         this.field_222 = System.currentTimeMillis();
         this.method_62((int)(this.field_222 - this.field_397));
         this.field_341 = this.field_341 + (this.field_222 - this.field_397);
         this.field_383 = this.field_222 - this.field_397;

         for (int var1 = 0; var1 < this.field_236.length; var1++) {
            this.field_236[var1] = this.field_236[var1] + (this.field_222 - this.field_397);
         }

         this.method_190((byte)5, (byte)3);
      }
   }

   // $VF: renamed from: R () void
   private void method_66() {
      this.field_167 = 0;
      this.field_168 = 0;
      this.field_213 = false;
      this.field_214 = 0;
      this.field_215 = 0;
   }

   // $VF: renamed from: c (int) void
   public void method_3(int var1) {
      if (!this.field_163) {
         this.field_168 = var1;
         if (var1 == -3) {
            this.field_167 |= 2;
            this.field_320 = (byte)(this.field_320 | 2);
         } else if (var1 == -4) {
            this.field_167 |= 4;
            this.field_320 = (byte)(this.field_320 | 4);
         } else if (var1 == -1) {
            this.field_167 |= 8;
            this.field_320 = (byte)(this.field_320 | 8);
         } else if (var1 == -2) {
            this.field_167 |= 16;
            this.field_320 = (byte)(this.field_320 | 16);
         } else if (var1 == -5) {
            this.field_167 |= 32;
         } else if (var1 == -6 || var1 == 6) {
            this.field_167 |= 256;
         } else if (var1 == -7 || var1 == 7) {
            this.field_167 |= 512;
         } else if (var1 == 42) {
            this.field_167 |= 64;
         } else if (var1 == 48) {
            this.field_167 |= 524288;
         } else if (var1 == 49) {
            this.field_167 |= 262144;
         } else if (var1 == 50) {
            this.field_167 |= 131072;
            this.field_320 = (byte)(this.field_320 | 8);
         } else if (var1 == 51) {
            this.field_167 |= 65536;
         } else if (var1 == 52) {
            this.field_167 |= 32768;
            this.field_320 = (byte)(this.field_320 | 2);
         } else if (var1 == 53) {
            this.field_167 |= 16384;
         } else if (var1 == 54) {
            this.field_167 |= 8192;
            this.field_320 = (byte)(this.field_320 | 4);
         } else if (var1 == 55) {
            this.field_167 |= 4096;
         } else if (var1 == 56) {
            this.field_167 |= 2048;
            this.field_320 = (byte)(this.field_320 | 16);
         } else if (var1 == 57) {
            this.field_167 |= 1024;
         } else if (var1 == 42) {
            this.field_167 |= 64;
         } else if (var1 == 35) {
            this.field_167 |= 128;
         }
      }
   }

   // $VF: renamed from: d (int) void
   public void method_4(int var1) {
   }

   // $VF: renamed from: e (int) void
   public void method_5(int var1) {
      if (var1 == -3) {
         this.field_320 &= -3;
      } else if (var1 == -4) {
         this.field_320 &= -5;
      } else if (var1 == -1) {
         this.field_320 &= -9;
      } else if (var1 == -2) {
         this.field_320 &= -17;
      } else if (var1 == 50) {
         this.field_320 = (byte)(this.field_320 & -131073);
         this.field_320 &= -9;
      } else if (var1 == 52) {
         this.field_320 = (byte)(this.field_320 & -32769);
         this.field_320 &= -3;
      } else if (var1 == 54) {
         this.field_320 = (byte)(this.field_320 & -8193);
         this.field_320 &= -5;
      } else if (var1 == 56) {
         this.field_320 = (byte)(this.field_320 & -2049);
         this.field_320 &= -17;
      }

      this.method_66();
   }

   // $VF: renamed from: a (int, int) void
   public void method_6(int var1, int var2) {
   }

   // $VF: renamed from: b (int, int) void
   public void method_7(int var1, int var2) {
   }

   // $VF: renamed from: c (int, int) void
   public void method_10(int var1, int var2) {
   }

   // $VF: renamed from: f (int) boolean
   public boolean method_67(int var1) {
      boolean var2;
      try {
         var2 = (this.field_167 & var1) != 0;
      } finally {
         this.field_167 &= ~var1;
      }

      return var2;
   }

   // $VF: renamed from: e () void
   void method_68() {
      this.field_224 = (int)(System.currentTimeMillis() - this.field_222);
      this.field_222 = this.field_222 + (long)this.field_224;
      this.field_223 = this.field_224;
      this.field_225 = 20;
      if (this.field_315) {
         this.field_223 = 0;
         this.field_315 = false;
      } else {
         this.field_223 = this.field_224;
      }
   }

   // $VF: renamed from: S () void
   private void method_69() {
      while (this.field_203 <= 16) {
         switch (this.field_203) {
            case 1:
            default:
               this.field_203++;
         }
      }
   }

   // $VF: renamed from: f () void
   void method_70() {
      while (this.field_203 < 16) {
         switch (this.field_203) {
            case 1:
               this.method_174(this.field_143[11]);
               String var1 = "";
               var1 = var1 + this.field_137.getAppProperty("MIDlet-Name").toUpperCase() + "\n";
               var1 = var1 + this.field_143[56] + " " + this.field_137.getAppProperty("MIDlet-Version");
               var1 = var1 + "\n";
               var1 = var1 + this.field_143[62];
               var1 = var1 + "\n";
               var1 = var1 + this.field_143[57] + "";
               var1 = var1 + "\n";
               var1 = var1 + "\n" + this.field_143[58];
               var1 = var1 + "\n" + this.field_143[59];
               var1 = var1 + "\n" + this.field_143[60];
               var1 = var1 + "\n";
               var1 = var1 + "\n";
               String var17 = var1 + "$Name:";

               try {
                  var17 = var17 + "\n" + CapcomMIDlet.field_525.substring(0, 18);
                  var17 = var17 + "\n" + CapcomMIDlet.field_525.substring(18, 24);
               } catch (Exception var4) {
                  var17 = var17 + "\nBUILD NOT TAGGED";
               }

               int var2 = field_151 - this.field_142[0].getHeight() - 10 + -23;
               int var3 = field_151 - this.field_142[0].getHeight() - 10 - var2 / 2 + 6;
               this.field_198.method_282(var17, field_152 / 2, var3, field_152 * 90 / 100, var2, 1, 2, true);
            default:
               this.field_203++;
         }
      }
   }

   // $VF: renamed from: g () void
   void method_71() {
      try {
         while (true) {
            if (this.field_203 <= 16) {
               switch (this.field_203) {
                  case 1:
                     if (!this.method_77(6, 38)) {
                        return;
                     }

                     if (!this.method_77(150, 45)) {
                        return;
                     }

                     if (!this.method_77(8, 41)) {
                        return;
                     }

                     if (!this.method_77(2, 2)) {
                        return;
                     }

                     if (this.field_327 == null) {
                        this.field_327 = class_25.method_318("/img/medkit.png");
                     }

                     if (this.field_332 == null) {
                        this.field_332 = class_25.method_318("/img/ammo.png");
                     }

                     if (this.field_337 == null) {
                        this.field_337 = class_25.method_318("/img/weapon.png");
                     }

                     if (this.field_363 == null) {
                        this.field_363 = class_25.method_318("/img/no_wep.png");
                     }

                     for (int var1 = 0; var1 < this.field_229; var1++) {
                        if (this.field_230[var1] == null) {
                           this.field_230[var1] = class_25.method_318("/img/item_" + var1 + ".png");
                        }
                     }

                     if (this.field_324 == null) {
                        this.field_324 = class_25.method_318("/img/zombie_head.png");
                     }

                     if (this.field_325 == null) {
                        this.field_325 = class_25.method_318("/img/leon_head.png");
                     }

                     this.field_247 = new class_4[24];
                     this.field_247[0] = this.field_245.field_78;
                     this.field_247[0].field_31 = false;

                     for (int var4 = 1; var4 < 24; var4++) {
                        this.field_247[var4] = new class_4(this);
                        this.field_247[var4].field_9 = false;
                        this.field_247[var4].field_31 = true;
                     }

                     this.field_251 = new short[150];
                     this.field_252 = new byte[150];
                     this.field_317 = true;
                     this.field_244.field_85 = false;
                     this.field_244.field_86 = false;
                     this.field_244.field_87 = false;
                     if (this.field_347 != 1) {
                        for (int var5 = 0; var5 < 6; var5++) {
                           this.field_244.field_90[var5] = false;
                        }

                        this.field_244.field_90[0] = true;
                        this.field_244.field_90[5] = true;
                        this.field_244.field_90[1] = true;
                     }

                     this.method_86(1, 8, 11, 3);
                     this.field_255 = new class_10[150];

                     for (int var6 = 0; var6 < 150; var6++) {
                        this.field_255[var6] = new class_10(this);
                     }

                     this.field_259 = 0;
                     this.field_286 = 0;
                     this.field_317 = true;
                     this.field_245.field_89 = true;

                     for (int var7 = 0; var7 < this.field_236.length; var7++) {
                        this.field_236[var7] = 0L;
                     }

                     this.method_76();
                     this.method_72();
                     this.method_79(this.field_260, false);
                     this.field_341 = this.field_222;
                     field_342 = new int[this.field_262 * this.field_263][2];
                     this.field_328 = 0;
                     this.field_338 = 0;
                     this.field_333 = 0;
                     this.field_167 = 0;
                     this.field_320 = 0;
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
                     this.field_203++;
               }
            } else {
               this.method_269(0, 4);
               break;
            }
         }
      } catch (Exception var3) {
      }
   }

   // $VF: renamed from: T () void
   private void method_72() {
      switch (this.field_347) {
         case 0:
            this.field_260 = (byte)this.field_377[this.field_376][0];

            for (int var1 = 0; var1 < 6; var1++) {
               this.field_244.field_90[var1] = false;
            }

            this.field_245.field_84 = 127;
            this.field_374 = this.field_377[this.field_376][4];
            this.field_375 = this.field_377[this.field_376][8];
            if (this.method_74(1)) {
               this.field_381 = (long)this.field_377[this.field_376][7];
            } else {
               this.field_381 = 0L;
            }

            this.field_388 = this.field_381;
            if (this.method_73(32)) {
               this.field_244.field_90[5] = true;
               this.field_245.field_84 = 5;
               this.field_245.field_83[5] = this.field_379[this.field_376][5];
               this.method_239(5);
            }

            if (this.method_73(1)) {
               this.field_244.field_90[0] = true;
               this.field_245.field_84 = 0;
               this.method_239(0);
            }

            if (this.method_73(16)) {
               this.field_244.field_90[4] = true;
               this.field_245.field_84 = 4;
               this.field_245.field_83[4] = this.field_379[this.field_376][4];
               this.method_239(4);
            }

            if (this.method_73(4)) {
               this.field_244.field_90[2] = true;
               this.field_245.field_84 = 2;
               this.field_245.field_83[2] = this.field_379[this.field_376][2];
               this.method_239(2);
            }

            if (this.method_73(8)) {
               this.field_244.field_90[3] = true;
               this.field_245.field_84 = 3;
               this.field_245.field_83[3] = this.field_379[this.field_376][3];
               this.method_239(3);
            }

            if (this.method_73(2)) {
               this.field_244.field_90[1] = true;
               this.field_245.field_84 = 1;
               this.field_245.field_83[1] = this.field_379[this.field_376][1];
               this.method_239(1);
            }

            this.field_382 = this.field_222;
            this.field_383 = 0L;
            if (this.field_377[this.field_376][1] == 0) {
               this.method_78(145);
               this.method_78(147);
               System.gc();
               this.method_275(1L);
               if (!this.method_77(141, 47)) {
                  return;
               }
            } else if (this.field_377[this.field_376][1] == 2) {
               this.method_78(141);
               this.method_78(147);
               System.gc();
               this.method_275(1L);
               if (!this.method_77(145, 36)) {
                  return;
               }
            } else if (this.field_377[this.field_376][1] == 1) {
               this.method_78(141);
               this.method_78(145);
               System.gc();
               this.method_275(1L);
               if (!this.method_77(147, 12)) {
                  return;
               }
            }
            break;
         case 1:
            this.field_260 = 0;
            if (this.field_357[this.field_359][5] == 0) {
               this.method_78(145);
               this.method_78(147);
               System.gc();
               this.method_275(1L);
               if (!this.method_77(141, 47)) {
                  return;
               }
            } else if (this.field_357[this.field_359][5] == 2) {
               this.method_78(141);
               this.method_78(147);
               System.gc();
               this.method_275(1L);
               if (!this.method_77(145, 36)) {
                  return;
               }
            } else if (this.field_357[this.field_359][5] == 1) {
               this.method_78(141);
               this.method_78(145);
               System.gc();
               this.method_275(1L);
               if (!this.method_77(147, 12)) {
                  return;
               }
            }

            this.method_215(false);
            break;
         case 2:
            this.field_260 = 1;
            if (!this.method_77(141, 47)) {
               return;
            }
      }

      this.field_349 = 0;
      this.field_350 = 0;
      this.field_351 = 1;
      this.field_352 = 1;
      this.field_353 = 0;
      this.field_384 = 0;
      this.field_390 = 0;
      this.field_391 = false;
      this.field_392 = false;
      this.field_370 = 0;
      this.field_371 = false;
      this.field_372 = false;
      this.field_373 = false;
      this.field_386 = true;
      this.field_387 = false;
      this.method_213();
   }

   // $VF: renamed from: m (int) boolean
   private boolean method_73(int var1) {
      return (this.field_374 & var1) != 0;
   }

   // $VF: renamed from: n (int) boolean
   private boolean method_74(int var1) {
      return (this.field_375 & var1) != 0;
   }

   // $VF: renamed from: U () void
   private void method_75() {
      for (int var1 = 0; var1 < this.field_232.length; var1++) {
         for (int var2 = 0; var2 < this.field_232[var1].length; var2++) {
            this.field_232[var1][var2] = 0;
         }
      }

      this.field_232[4][2] = 3;
      this.field_232[4][1] = 3;
      this.field_232[4][0] = 3;
      this.field_232[0][0] = 3;
      this.field_232[0][2] = 3;
   }

   // $VF: renamed from: V () void
   private void method_76() {
      if (this.field_326 == null) {
         this.field_326 = new class_5(this);
      }

      this.field_326.field_34 = 0;
      this.field_326.field_35 = 0;
      this.field_326.field_36 = 0;
      this.field_326.field_37 = false;
      this.field_326.field_38 = false;
      this.field_326.field_39 = true;
      this.field_326.field_40 = false;
      if (this.field_331 == null) {
         this.field_331 = new class_5(this);
      }

      this.field_331.field_34 = 0;
      this.field_331.field_35 = 0;
      this.field_331.field_36 = 0;
      this.field_331.field_37 = false;
      this.field_331.field_38 = false;
      this.field_331.field_39 = true;
      this.field_331.field_40 = false;
      if (this.field_336 == null) {
         this.field_336 = new class_5(this);
      }

      this.field_336.field_34 = 0;
      this.field_336.field_35 = 0;
      this.field_336.field_36 = 0;
      this.field_336.field_37 = false;
      this.field_336.field_38 = false;
      this.field_336.field_39 = true;
      this.field_336.field_40 = false;
   }

   // $VF: renamed from: d (int, int) boolean
   boolean method_77(int var1, int var2) {
      String var3 = "";
      if (var1 >= 9 && var1 < 89) {
         var3 = var3 + "o" + var2;
      } else if (var1 >= 89 && var1 < 109) {
         var3 = var3 + "t" + var2;
      } else if (var1 >= 109 && var1 < 139) {
         var3 = var3 + "w" + var2;
      } else {
         var3 = class_12.field_75[var2];
      }

      method_274(var3);
      System.gc();

      try {
         if (this.field_289[var1] == null) {
         }

         this.field_289[var1] = Image.createImage("/img/" + var3 + ".png");
      } catch (Exception var5) {
         return false;
      }

      return this.field_289[var1] != null;
   }

   // $VF: renamed from: g (int) void
   void method_78(int var1) {
      if (this.field_289[var1] != null) {
         this.field_289[var1] = null;
      }
   }

   // $VF: renamed from: a (int, boolean) void
   void method_79(int var1, boolean var2) {
      this.method_85();
      this.field_260 = (byte)var1;
      if (this.method_87()) {
         var2 &= this.field_261[this.field_260];
         this.field_261[this.field_260] = true;
         this.field_244.field_88 = this.field_260;
         this.method_81();
         this.method_82(this.field_244.field_78, true);
      }
   }

   // $VF: renamed from: h () void
   void method_80() {
      for (int var1 = 0; var1 < 5; var1++) {
         this.field_249[var1].field_92 = false;
      }

      for (int var2 = 0; var2 < 10; var2++) {
         this.field_250[var2].field_121 = false;
      }
   }

   // $VF: renamed from: i () void
   void method_81() {
      this.method_80();
      this.field_279 = this.field_267[this.field_244.field_78.field_10][this.field_244.field_78.field_11];
      this.field_275 = 65536;
      this.field_276 = 65536;
      this.field_277 = 0;
      this.field_278 = 0;

      for (int var1 = 0; var1 < this.field_262; var1++) {
         for (int var2 = 0; var2 < this.field_263; var2++) {
            if (this.field_279 == this.field_267[var1][var2]) {
               this.field_275 = Math.min(this.field_275, this.method_167(var1, var2) - 18);
               this.field_277 = Math.max(this.field_277, this.method_167(var1, var2) + 18 + 36 - this.field_275);
               this.field_276 = Math.min(this.field_276, this.method_168(var1, var2) - 42);
               this.field_278 = Math.max(this.field_278, this.method_168(var1, var2) + 9 + 18 - this.field_276);
            }
         }
      }

      this.method_237();
   }

   // $VF: renamed from: a (u, boolean) void
   void method_82(class_4 var1, boolean var2) {
      if (!this.field_155 || var2) {
         this.field_248 = var1;
         int var6 = this.method_167(var1.field_10, var1.field_11);
         int var8 = this.method_168(var1.field_10, var1.field_11);
         int var9 = var6 + (18 - field_153);
         int var12 = var8 + (9 - field_154);
         boolean var3 = this.method_155(var1, 2, 1);
         boolean var4 = this.method_155(var1, 0, 1);
         if (var1.field_14 == 2) {
            var3 = !var3;
            var4 = !var4;
         }

         if (class_2.field_1[var1.field_18][var1.field_14][2] != 0) {
            if (var3) {
               var9 += var1.field_16 * 18 / 65536;
               if (var1.field_12 >= class_2.field_1[var1.field_18][var1.field_14][2]) {
                  var9 -= 18;
               }
            } else {
               var9 -= var1.field_16 * 18 / 65536;
               if (var1.field_12 >= class_2.field_1[var1.field_18][var1.field_14][2]) {
                  var9 += 18;
               }
            }

            if (var4) {
               var12 += var1.field_16 * 9 / 65536;
               if (var1.field_12 >= class_2.field_1[var1.field_18][var1.field_14][2]) {
                  var12 -= 9;
               }
            } else {
               var12 -= var1.field_16 * 9 / 65536;
               if (var1.field_12 >= class_2.field_1[var1.field_18][var1.field_14][2]) {
                  var12 += 9;
               }
            }
         }

         byte var5;
         if ((this.field_226 & 512) == 0 && !this.field_317 && !this.field_244.field_89) {
            var5 = 4;
         } else {
            var5 = 8;
         }

         if (this.method_83()) {
            var5 = 12;
         }

         if (field_152 < this.field_277) {
            var6 = Math.min(var9, this.field_275 + this.field_277 - field_152);
            var6 = Math.max(var6, this.field_275);
         } else {
            var6 = this.field_275 + this.field_277 / 2 - field_153;
         }

         if (field_151 < this.field_278) {
            var8 = Math.min(var12, this.field_276 + this.field_278 - field_151);
            var8 = Math.max(var8, this.field_276);
         } else {
            var8 = this.field_276 + this.field_278 / 2 - field_154;
         }

         if (!var2) {
            if (this.field_273 < var6) {
               var6 = this.field_273 + Math.min(var6 - this.field_273, var5);
            }

            if (this.field_273 > var6) {
               var6 = this.field_273 - Math.min(this.field_273 - var6, var5);
            }

            if (this.field_274 < var8) {
               var8 = this.field_274 + Math.min(var8 - this.field_274, var5);
            }

            if (this.field_274 > var8) {
               var8 = this.field_274 - Math.min(this.field_274 - var8, var5);
            }
         }

         if (var6 == this.field_273 && var8 == this.field_274) {
            this.field_292 = false;
         } else {
            this.field_292 = true;
         }

         this.method_171(var6, var8);
      }
   }

   // $VF: renamed from: W () boolean
   private boolean method_83() {
      if (this.field_244.field_78.field_17 == 3) {
         byte var3 = (byte)(this.field_244.field_78.field_11 - 2);
         if (var3 < 0) {
            var3 = 0;
         }

         int var1 = this.method_167(this.field_244.field_78.field_10, var3) - this.field_273;
         int var2 = this.method_168(this.field_244.field_78.field_10, var3) - this.field_274;
         if (!this.method_139(var1, var2, 36, 18, 0, 0, field_152, field_151)) {
            return true;
         }
      } else if (this.field_244.field_78.field_17 == 5) {
         byte var10 = (byte)(this.field_244.field_78.field_10 - 2);
         if (var10 < 0) {
            var10 = 0;
         }

         int var4 = this.method_167(var10, this.field_244.field_78.field_11) - this.field_273;
         int var7 = this.method_168(var10, this.field_244.field_78.field_11) - this.field_274;
         if (!this.method_139(var4, var7, 36, 18, 0, 0, field_152, field_151)) {
            return true;
         }
      } else if (this.field_244.field_78.field_17 == 1) {
         byte var11 = (byte)(this.field_244.field_78.field_10 + 2);
         if (var11 < 0) {
            var11 = 0;
         }

         int var5 = this.method_167(var11, this.field_244.field_78.field_11) - this.field_273;
         int var8 = this.method_168(var11, this.field_244.field_78.field_11) - this.field_274;
         if (!this.method_139(var5, var8, 36, 18, 0, 0, field_152, field_151)) {
            return true;
         }
      } else if (this.field_244.field_78.field_17 == 7) {
         byte var12 = (byte)(this.field_244.field_78.field_11 + 2);
         if (var12 < 0) {
            var12 = 0;
         }

         int var6 = this.method_167(this.field_244.field_78.field_10, var12) - this.field_273;
         int var9 = this.method_168(this.field_244.field_78.field_10, var12) - this.field_274;
         if (!this.method_139(var6, var9, 36, 18, 0, 0, field_152, field_151)) {
            return true;
         }
      }

      return false;
   }

   // $VF: renamed from: j () boolean
   boolean method_84() {
      for (int var1 = 0; var1 < 183; var1++) {
         this.field_289[var1] = null;
      }

      return true;
   }

   // $VF: renamed from: k () void
   void method_85() {
      for (int var1 = 2; var1 < 24; var1++) {
         this.field_247[var1].field_9 = false;
      }

      if (this.field_245.field_80 != null) {
         for (int var2 = 0; var2 < this.field_245.field_79; var2++) {
            this.field_245.field_80[var2].field_8 = null;
            this.field_245.field_80[var2].field_7 = 0;
         }
      }

      this.field_264 = (byte[][])null;
      this.field_265 = (short[][])null;
      this.field_266 = (short[][])null;
      this.field_267 = (byte[][])null;
   }

   // $VF: renamed from: a (int, int, int, int) u
   class_4 method_86(int var1, int var2, int var3, int var4) {
      class_4 var5 = null;
      int var6 = 3;

      while (var6 < 24 && !this.field_247[var6].field_31) {
         var6++;
      }

      if (var6 >= 24) {
         return var5;
      } else {
         switch (var1) {
            case 0:
               var5 = this.field_247[1];
               break;
            case 1:
               var5 = this.field_247[0];
            case 5:
               break;
            default:
               var5 = this.field_247[var6];
         }

         var5.field_9 = true;
         var5.field_18 = (byte)var1;
         var5.field_10 = (byte)var2;
         var5.field_11 = (byte)var3;
         var5.field_12 = 0;
         var5.field_13 = 0;
         var5.field_14 = 0;
         var5.field_15 = -1;
         var5.field_16 = 0;
         var5.field_22 = -1;
         var5.field_23 = -1;
         var5.field_24 = false;
         var5.field_25 = false;
         var5.field_26 = false;
         var5.field_27 = 0L;
         var5.field_28 = 0L;
         var5.field_19 = 127;
         var5.field_29 = false;
         var5.field_30 = 0L;
         var5.field_31 = false;
         var5.field_32 = 1;
         switch (var5.field_18) {
            case 0:
            case 1:
               var5.field_20 = 16;
               var5.field_21 = 16;
               if (this.field_347 == 0) {
                  var5.field_20 = (byte)this.field_377[this.field_376][6];
               }

               this.method_92(var5, 0);
               break;
            case 2:
            case 4:
               byte var9;
               if (this.field_347 == 0) {
                  var9 = 20;
               } else if (this.field_347 == 2) {
                  if (this.field_350 > this.field_393[this.field_393.length - 1]) {
                     if (this.field_350 - this.field_393[this.field_393.length - 1] > 10 && this.field_350 - this.field_393[this.field_393.length - 1] < 20) {
                        var9 = 10;
                     } else if (this.field_350 - this.field_393[this.field_393.length - 1] >= 20
                        && this.field_350 - this.field_393[this.field_393.length - 1] < 30) {
                        var9 = 20;
                     } else if (this.field_350 - this.field_393[this.field_393.length - 1] >= 30) {
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

               if (this.field_351 != 1) {
                  if (method_144(100) < 40 + var9) {
                     var5.field_32 = this.field_351;
                  }
               } else {
                  var5.field_32 = 1;
               }

               var5.field_20 = 10;
               var5.field_21 = 10;
               this.method_92(var5, 0);
               break;
            case 3:
            case 5:
            case 7:
            default:
               var5.field_20 = 10;
               var5.field_21 = 10;
               this.method_92(var5, 0);
               break;
            case 6:
               byte var8;
               if (this.field_347 == 0) {
                  var8 = 60;
               } else if (this.field_347 == 2) {
                  if (this.field_350 > this.field_393[this.field_393.length - 1]) {
                     if (this.field_350 - this.field_393[this.field_393.length - 1] > 10 && this.field_350 - this.field_393[this.field_393.length - 1] < 20) {
                        var8 = 10;
                     } else if (this.field_350 - this.field_393[this.field_393.length - 1] >= 20
                        && this.field_350 - this.field_393[this.field_393.length - 1] < 30) {
                        var8 = 20;
                     } else if (this.field_350 - this.field_393[this.field_393.length - 1] >= 30) {
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

               if (this.field_351 != 1) {
                  if (method_144(100) < 40 + var8) {
                     var5.field_32 = this.field_351;
                  }
               } else {
                  var5.field_32 = 1;
               }

               var5.field_20 = 60;
               var5.field_21 = 60;
               this.method_92(var5, 0);
               break;
            case 8:
               byte var7;
               if (this.field_347 == 0) {
                  var7 = 20;
               } else if (this.field_347 == 2) {
                  if (this.field_350 > this.field_393[this.field_393.length - 1]) {
                     if (this.field_350 - this.field_393[this.field_393.length - 1] > 10 && this.field_350 - this.field_393[this.field_393.length - 1] < 20) {
                        var7 = 10;
                     } else if (this.field_350 - this.field_393[this.field_393.length - 1] >= 20
                        && this.field_350 - this.field_393[this.field_393.length - 1] < 30) {
                        var7 = 20;
                     } else if (this.field_350 - this.field_393[this.field_393.length - 1] >= 30) {
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

               if (this.field_351 != 1) {
                  if (method_144(100) < 40 + var7) {
                     var5.field_32 = this.field_351;
                  }
               } else {
                  var5.field_32 = 1;
               }

               var5.field_20 = 20;
               var5.field_21 = 20;
               this.method_92(var5, 0);
         }

         this.method_93(var5, var4);
         return var5;
      }
   }

   // $VF: renamed from: l () boolean
   boolean method_87() {
      this.field_271.method_24();
      System.gc();
      if (this.field_260 == 0) {
         this.method_88("/data/reu01_large_object_coords.bin");
         this.field_268 = 9;
         this.field_269 = 2;
         this.field_270 = class_25.method_318("/img/level_art_01.png");
         this.field_271.method_23(this.field_270, class_8.field_61);
      } else if (this.field_260 == 1) {
         this.method_88("/data/reu02_large_object_coords.bin");
         this.field_268 = 9;
         this.field_269 = 2;
         this.field_270 = class_25.method_318("/img/level_art_01.png");
         this.field_271.method_23(this.field_270, class_8.field_61);
      }

      short[] var3 = new short[field_283[this.field_260]];
      if (!this.method_89(var3, field_282[this.field_260], field_283[this.field_260])) {
         return false;
      } else {
         int var6 = 0;
         this.field_262 = (byte)var3[var6++];
         this.field_263 = (byte)var3[var6++];
         this.field_272 = this.field_262 * 36 / 2;
         this.field_264 = new byte[this.field_262][this.field_263];
         this.field_265 = new short[this.field_262][this.field_263];
         this.field_266 = new short[this.field_262][this.field_263];
         this.field_267 = new byte[this.field_262][this.field_263];

         for (int var4 = 0; var4 < this.field_262; var4++) {
            for (int var5 = 0; var5 < this.field_263; var5++) {
               this.field_264[var4][var5] = (byte)var3[var6++];
            }
         }

         for (int var8 = 0; var8 < this.field_262; var8++) {
            for (int var12 = 0; var12 < this.field_263; var12++) {
               this.field_266[var8][var12] = var3[var6++];
               this.field_266[var8][var12] = (short)(this.field_266[var8][var12] << 8);
               this.field_266[var8][var12] = (short)(this.field_266[var8][var12] | var3[var6++]);
            }
         }

         for (int var9 = 0; var9 < this.field_262; var9++) {
            for (int var13 = 0; var13 < this.field_263; var13++) {
               this.field_265[var9][var13] = var3[var6++];
               this.field_265[var9][var13] = (short)(this.field_265[var9][var13] << 8);
               this.field_265[var9][var13] = (short)(this.field_265[var9][var13] | var3[var6++]);
            }
         }

         for (int var10 = 0; var10 < this.field_262; var10++) {
            for (int var14 = 0; var14 < this.field_263; var14++) {
               this.field_267[var10][var14] = (byte)var3[var6++];
            }
         }

         this.field_280 = (short)(var3[var6++] << 8);
         this.field_280 = (short)(this.field_280 + var3[var6++]);
         this.field_281 = new class_5[this.field_280];

         for (int var11 = 0; var11 < this.field_280; var11++) {
            this.field_281[var11] = new class_5(this);
            this.field_281[var11].field_34 = (byte)var3[var6++];
            this.field_281[var11].field_35 = (byte)var3[var6++];
            this.field_281[var11].field_36 = (byte)var3[var6++];
            this.field_281[var11].field_37 = var3[var6++] != 0;
            this.field_281[var11].field_38 = var3[var6++] != 0;
            this.field_281[var11].field_39 = var3[var6++] != 0;
            this.field_281[var11].field_40 = var3[var6++] != 0;
            this.field_281[var11].field_42 = (byte)var3[var6++];
            this.field_281[var11].field_41 = new class_11[this.field_281[var11].field_42];

            for (int var15 = 0; var15 < this.field_281[var11].field_42; var15++) {
               this.field_281[var11].field_41[var15] = new class_11(this);
               this.field_281[var11].field_41[var15].field_69 = (byte)var3[var6++];
               this.field_281[var11].field_41[var15].field_70 = (byte)var3[var6++];
               this.field_281[var11].field_41[var15].field_71 = (byte)var3[var6++];
               this.field_281[var11].field_41[var15].field_72 = var3[var6++] != 0;
               this.field_281[var11].field_41[var15].field_73 = var3[var6++] != 0;
            }
         }

         var3 = null;
         System.gc();
         this.method_90();
         return true;
      }
   }

   // $VF: renamed from: a (java.lang.String) void
   void method_88(String var1) {
      InputStream var2 = null;
      DataInputStream var3 = null;

      try {
         var2 = this.getClass().getResourceAsStream(var1);
         var3 = new DataInputStream(var2);
         int var5 = var3.readShort() / 13;
         this.field_284 = new short[var5][];

         for (int var4 = 0; var4 < var5; var4++) {
            this.field_284[var4] = new short[9];
            this.field_284[var4][0] = var3.readShort();
            this.field_284[var4][1] = var3.readShort();
            this.field_284[var4][2] = var3.readShort();
            this.field_284[var4][3] = var3.readShort();
            this.field_284[var4][4] = (short)var3.readByte();
            this.field_284[var4][5] = (short)var3.readByte();
            this.field_284[var4][6] = (short)var3.readByte();
            this.field_284[var4][7] = (short)var3.readByte();
            this.field_284[var4][8] = (short)var3.readByte();
         }
      } catch (Exception var14) {
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
   boolean method_89(short[] var1, String var2, int var3) {
      InputStream var4 = null;
      DataInputStream var5 = null;

      boolean var8;
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
      } catch (Exception var18) {
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
   boolean method_90() {
      int var5 = 0;

      while (var5 < this.field_280) {
         var5++;
      }

      for (int var7 = 0; var7 < this.field_262; var7++) {
         for (int var6 = 0; var6 < this.field_263; var6++) {
            if (this.field_264[var7][var6] == 127) {
            }
         }
      }

      for (int var8 = 0; var8 < this.field_262; var8++) {
         for (int var9 = 0; var9 < this.field_263; var9++) {
            int var1 = this.field_265[var8][var9] >> 8 & 0xFF;
            int var2 = this.field_265[var8][var9] & 255;
            int var3 = this.field_266[var8][var9] >> 8 & 0xFF;
            int var4 = this.field_266[var8][var9] & 255;
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
   void method_91() {
      if (!this.field_155) {
         for (int var1 = 0; var1 < 24; var1++) {
            if (this.field_247[var1].field_9) {
               this.field_247[var1].field_25 = false;
            }
         }

         for (int var2 = 0; var2 < 5; var2++) {
            if (this.field_249[var2].field_92) {
               this.field_249[var2].field_93 = false;
            }
         }

         for (int var3 = 0; var3 < 10; var3++) {
            if (this.field_250[var3].field_121) {
               this.field_250[var3].field_122.field_93 = false;
            }
         }
      }
   }

   // $VF: renamed from: a (u, int) void
   void method_92(class_4 var1, int var2) {
      if (this.field_244.field_78.field_20 > 0 || var2 != 5) {
         if (class_2.field_1[var1.field_18][var2][0] == 0) {
            var2 = 1;
         }

         if ((this.field_226 & 512) != 0 || this.field_317 || var1.field_18 == 1 && this.field_245.field_89) {
            if (var2 == 0 && class_2.field_1[var1.field_18].length >= 8 && class_2.field_1[var1.field_18][8][0] != 0) {
               var2 = 8;
            }

            if (var2 == 1 && class_2.field_1[var1.field_18].length >= 12 && class_2.field_1[var1.field_18][12][0] != 0) {
               var2 = 12;
            }

            if (var2 == 12 && var1.field_14 == 12) {
               var2 = 13;
            }

            if ((var1.field_18 == 0 || var1.field_18 == 1) && var1.field_19 != 127) {
               if (var2 == 8 && (this.field_244.field_84 == 1 || this.field_244.field_84 == 2)) {
                  var2 = 9;
               }

               if (var2 == 8 && (this.field_244.field_84 == 3 || this.field_244.field_84 == 4)) {
                  var2 = 10;
               }

               if (var2 == 8 && this.field_244.field_84 == 0) {
                  var2 = 11;
               }

               if (var2 == 5 && (this.field_244.field_84 == 3 || this.field_244.field_84 == 4)) {
                  var2 = 6;
               }
            }

            if ((var1.field_18 == 0 || var1.field_18 == 1) && var1.field_19 == 127 && var2 == 8 && this.field_244.field_84 == 0) {
               var2 = 11;
            }
         }

         var1.field_14 = (byte)var2;
         var1.field_16 = 0;
         var1.field_12 = 0;
         var1.field_24 = true;
         var1.field_25 = true;
         var1.field_27 = this.field_222;
         if (var2 == 5 || var2 == 6 || var2 == 7 || var2 == 14) {
            var1.field_28 = this.field_222;
         }

         if (class_2.field_1[var1.field_18][var1.field_14][2] != 0 && var1.field_17 % 2 == 0) {
            this.method_93(var1, var1.field_17 + 1);
         }
      }
   }

   // $VF: renamed from: b (u, int) void
   void method_93(class_4 var1, int var2) {
      var2 = (var2 + 8) % 8;
      var1.field_17 = (byte)var2;
   }

   // $VF: renamed from: o () void
   void method_94() {
      while (this.field_203 <= 16) {
         switch (this.field_203) {
            case 1:
               if (this.field_394 == null) {
                  this.field_394 = class_25.method_318("/img/logo.png");
               }

               if (this.field_395 == null) {
               }

               if (this.field_396 == null) {
                  this.field_396 = class_25.method_318("/img/capcom_2009.png");
               }

               this.field_404 = false;
            case 2:
            case 3:
            case 4:
            case 5:
            default:
               break;
            case 6:
               field_171 = 0;
         }

         this.field_203++;
      }
   }

   // $VF: renamed from: X () void
   private void method_95() {
      while (this.field_203 <= 16) {
         switch (this.field_203) {
            case 1:
            default:
               this.field_203++;
         }
      }
   }

   // $VF: renamed from: p () void
   void method_96() {
      while (this.field_203 <= 16) {
         switch (this.field_203) {
            case 1:
               this.method_174(this.field_143[9]);
            default:
               this.field_203++;
         }
      }
   }

   // $VF: renamed from: q () void
   void method_97() {
      while (this.field_203 <= 16) {
         switch (this.field_203) {
            case 1:
            default:
               this.field_203++;
         }
      }
   }

   // $VF: renamed from: r () void
   void method_98() {
      while (this.field_203 <= 16) {
         switch (this.field_203) {
            case 1:
            default:
               this.field_203++;
         }
      }
   }

   // $VF: renamed from: s () void
   void method_99() {
      while (this.field_203 <= 16) {
         switch (this.field_203) {
            case 1:
            default:
               this.field_203++;
         }
      }
   }

   // $VF: renamed from: t () void
   void method_100() {
      while (this.field_203 <= 16) {
         switch (this.field_203) {
            case 1:
            default:
               this.field_203++;
         }
      }
   }

   // $VF: renamed from: u () void
   void method_101() {
      while (this.field_203 <= 16) {
         switch (this.field_203) {
            case 1:
            default:
               this.field_203++;
         }
      }
   }

   // $VF: renamed from: v () void
   void method_102() {
      while (this.field_203 <= 16) {
         switch (this.field_203) {
            case 1:
            default:
               this.field_203++;
         }
      }
   }

   // $VF: renamed from: w () void
   void method_103() {
      while (this.field_203 <= 16) {
         switch (this.field_203) {
            case 1:
            default:
               this.field_203++;
         }
      }
   }

   // $VF: renamed from: x () void
   void method_104() {
      while (this.field_203 <= 16) {
         switch (this.field_203) {
            case 1:
            default:
               this.field_203++;
         }
      }
   }

   // $VF: renamed from: Y () void
   private void method_105() {
      while (this.field_203 <= 16) {
         switch (this.field_203) {
            case 1:
            default:
               this.field_203++;
         }
      }
   }

   // $VF: renamed from: Z () void
   private void method_106() {
      switch (field_173) {
         case 4:
            this.field_394 = null;
            this.field_396 = null;
            break;
         case 5:
         case 19:
         case 20:
         case 21:
         case 22:
            method_274("unloading game resources");
            this.method_78(0);
            this.method_78(6);
            this.method_78(141);
            this.method_78(140);
            this.method_78(150);
            this.method_78(8);
            this.method_78(2);
            this.method_78(145);

            for (int var1 = 0; var1 < this.field_229; var1++) {
               this.field_230[var1] = null;
            }

            this.field_327 = null;
            this.field_270 = null;
            this.field_324 = null;
            this.field_325 = null;
            this.field_332 = null;
            this.field_337 = null;
            this.field_363 = null;
            this.field_271.method_24();
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
         case 18:
      }

      System.gc();

      try {
         Thread.sleep(10L);
      } catch (Exception var3) {
      }
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics) void
   public void method_1(Graphics var1) {
      this.field_138.method_345(var1, 0, 0, field_152, field_151);
      if (class_25.field_533) {
         this.method_121(var1);
      } else {
         boolean var2 = true;
         switch (field_170) {
            case 0:
               this.method_112(var1);
               break;
            case 1:
               this.method_156(var1);
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
               this.method_109(var1);
               break;
            case 5:
               this.method_114(var1);
               break;
            case 6:
               this.method_164(var1);
               break;
            case 7:
               this.method_110(var1);
               break;
            case 8:
               this.method_113(var1);
               break;
            case 10:
               this.method_165(var1);
               break;
            case 12:
               this.method_111(var1);
               break;
            case 16:
               this.method_163(var1);
               break;
            case 17:
               this.method_158(var1);
               break;
            case 18:
               this.method_157(var1);
               break;
            case 19:
               this.method_160(var1);
               break;
            case 20:
               this.method_159(var1);
               break;
            case 21:
               this.method_161(var1);
               break;
            case 22:
               this.method_162(var1);
         }

         if (var2) {
            this.method_166(var1);
         }

         if (this.field_134) {
            this.field_138.method_347(var1, 255, 0, 0);
            this.field_138.method_344(var1, 0, 0, 2, 2);
         }
      }
   }

   // $VF: renamed from: y () void
   public void method_0() {
      this.field_134 = CapcomMIDlet.field_524;
      if (class_25.field_533) {
         this.field_138.method_316();
         if ((this.field_167 & 32) != 0) {
            class_25.field_533 = false;
         }

         this.method_66();
      } else if (field_398) {
         field_398 = false;
      } else {
         field_398 = true;
         if (this.field_157) {
            try {
               if (!this.field_156) {
                  this.method_68();
               }

               switch (field_170) {
                  case 0:
                     this.method_193();
                     break;
                  case 1:
                     this.method_206();
                  case 2:
                  case 9:
                  case 11:
                  case 13:
                  case 14:
                  case 15:
                  default:
                     break;
                  case 3:
                     this.method_107();
                     break;
                  case 4:
                     this.method_195();
                     break;
                  case 5:
                     this.method_208();
                     break;
                  case 6:
                     this.method_204();
                     break;
                  case 7:
                     this.method_191();
                     break;
                  case 8:
                     this.method_205();
                     break;
                  case 10:
                     this.method_194();
                     break;
                  case 12:
                     this.method_192();
                     break;
                  case 16:
                     this.method_196();
                     break;
                  case 17:
                     this.method_197();
                     break;
                  case 18:
                     this.method_202();
                     break;
                  case 19:
                     this.method_199();
                     break;
                  case 20:
                     this.method_198();
                     break;
                  case 21:
                     this.method_200();
                     break;
                  case 22:
                     this.method_201();
               }

               this.field_149++;
               this.field_150++;
               if (!this.field_162 && this.field_140 != null) {
                  this.field_140.method_16();
               }

               if (this.field_174 != null) {
                  this.field_174.c();
               }

               this.method_66();
               this.field_138.method_316();
               Thread.sleep(1L);
            } catch (Exception var2) {
            }
         }
      }
   }

   // $VF: renamed from: aa () void
   private void method_107() {
      this.field_204 = 0;
      if (this.field_203 == 0) {
         boolean var1 = true;
         switch (field_172) {
            case 7:
            case 8:
            case 12:
               var1 = false;
            default:
               if (var1 && field_172 != 5 && field_172 != 18) {
                  this.method_106();
               }
         }
      }

      this.field_203++;
      switch (field_172) {
         case 1:
            this.field_205 = true;
            this.method_175();
            this.method_69();
            switch (field_173) {
               case 0:
                  this.method_190((byte)0, (byte)4);
                  break;
               default:
                  this.method_190((byte)0, (byte)2);
            }
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
            this.method_94();
            this.method_179();
            this.method_190((byte)0, (byte)4);
            break;
         case 5:
            this.field_205 = true;
            this.method_71();
            this.method_190((byte)5, (byte)3);
            break;
         case 6:
            this.method_97();
            this.method_189();
            this.method_190((byte)0, (byte)2);
            break;
         case 7:
            this.method_70();
            this.method_190((byte)-1, (byte)2);
            break;
         case 8:
            this.method_105();
            this.method_178();
            this.method_190((byte)0, (byte)2);
            break;
         case 10:
            this.method_95();
            this.method_176();
            if (field_173 != 0 && field_173 != 1) {
               this.method_190((byte)0, (byte)2);
            } else {
               this.method_190((byte)0, (byte)-1);
            }
            break;
         case 12:
            this.method_96();
            this.method_177();
            this.method_190((byte)-1, (byte)2);
            break;
         case 16:
            this.method_99();
            this.method_181();
            this.method_190((byte)0, (byte)2);
            break;
         case 17:
            this.method_101();
            this.method_182();
            this.method_190((byte)0, (byte)2);
            break;
         case 18:
            this.method_100();
            this.method_180();
            this.method_190((byte)0, (byte)2);
            break;
         case 19:
            this.method_103();
            this.method_185();
            this.method_190((byte)0, (byte)-1);
            break;
         case 20:
            this.method_102();
            this.method_184();
            this.method_190((byte)0, (byte)-1);
            break;
         case 21:
            this.method_104();
            this.method_186();
            this.method_190((byte)0, (byte)-1);
            break;
         case 22:
            this.method_98();
            this.method_187();
            this.method_190((byte)0, (byte)-1);
      }

      if (this.field_203 > 16) {
         field_170 = field_172;
         this.field_149 = 0;
         this.field_205 = false;
      }
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, java.lang.String) void
   private void method_108(Graphics var1, String var2) {
      this.field_138.method_347(var1, 0, 0, 0);
      this.field_138.method_344(var1, 0, 0, field_152, field_151);
      if (this.field_395 != null) {
      }

      byte var3 = 2;
      byte var4 = 4;
      byte var5 = 2;
      if (this.field_139 != null) {
         this.field_138.method_346(var1, 8355711);
         this.field_139.method_31(var1, var2, var3 + var5, var4 + 1, field_152 - var3 * 2, 1, 0, this.field_149 * 2, field_152 / 2, field_152 / 2);
         this.field_138.method_346(var1, 16777215);
         this.field_139.method_31(var1, var2, var3, var4, field_152 - var3 * 2, 1, 0, this.field_149 * 2, field_152 / 2, field_152 / 2);
      }
   }

   // $VF: renamed from: e (javax.microedition.lcdui.Graphics) void
   private void method_109(Graphics var1) {
      this.method_108(var1, this.field_148);
      if (this.field_394 != null) {
         this.field_138.method_342(var1, this.field_394, field_153, 2, 17);
      }

      if (this.field_174 != null) {
         this.field_174.a(var1);
      }

      if (this.field_396 != null) {
         this.field_138.method_342(var1, this.field_396, field_153, field_151 - 4, 33);
      }
   }

   // $VF: renamed from: f (javax.microedition.lcdui.Graphics) void
   private void method_110(Graphics var1) {
      this.method_108(var1, this.field_148);
      if (this.field_198 != null) {
         this.field_198.method_279(var1);
      }
   }

   // $VF: renamed from: g (javax.microedition.lcdui.Graphics) void
   private void method_111(Graphics var1) {
      this.method_108(var1, this.field_148);
      if (this.field_198 != null) {
         this.field_198.method_279(var1);
      }
   }

   // $VF: renamed from: h (javax.microedition.lcdui.Graphics) void
   private void method_112(Graphics var1) {
      int var2 = field_152;
      int var3 = field_151;
      this.field_138.method_347(var1, 0, 0, 0);
      this.field_138.method_344(var1, 0, 0, field_152, field_151);
      if (this.field_163) {
         this.field_138.method_345(var1, 0, 0, this.field_138.getWidth(), this.field_138.getHeight());
         this.field_138.method_344(var1, 0, 0, this.field_138.getWidth(), this.field_138.getHeight());
         var2 = this.field_138.getWidth();
         var3 = this.field_138.getHeight();
         this.field_138.method_345(var1, 0, 0, field_152, field_151);
      }

      this.field_138.method_342(var1, this.field_141, (var2 - this.field_141.getWidth()) / 2, (var3 - this.field_141.getHeight()) / 2, 20);
   }

   // $VF: renamed from: i (javax.microedition.lcdui.Graphics) void
   private void method_113(Graphics var1) {
      this.method_108(var1, this.field_148);
      switch (field_171) {
         case 0:
            if (this.field_198 != null) {
               this.field_198.method_279(var1);
            }

            if (this.field_174 != null) {
               this.field_174.a(var1);
            }
            break;
         case 1:
            this.field_198.method_279(var1);
      }
   }

   // $VF: renamed from: j (javax.microedition.lcdui.Graphics) void
   private void method_114(Graphics var1) {
      this.field_138.method_346(var1, 0);
      this.field_138.method_344(var1, 0, 0, field_152, field_151);
      if (this.field_226 == 138) {
         switch (this.field_227) {
            case 0:
               this.method_116(var1);
               break;
            case 1:
               this.method_118(var1);
               break;
            case 2:
               this.method_117(var1);
         }
      } else {
         this.method_115();
         this.method_131(var1);
         this.method_128(var1);
         if (this.field_347 == 0 && !this.field_386) {
            this.field_138.method_346(var1, 0);
            this.field_138.method_344(var1, 0, 0, field_152, field_151);
         }

         this.method_123(var1);
         if (this.field_134 && this.field_347 == 1) {
            int var2;
            if (this.field_359 == this.field_358) {
               var2 = this.field_357[this.field_359][0] + this.field_360;
            } else {
               var2 = this.field_357[this.field_359][0];
            }

            this.field_139.method_29(var1, "" + this.field_353 + " / " + this.field_384 + " / " + var2, 2, field_154, field_152, 4, 1);
         } else if (this.field_134 && this.field_347 == 0) {
            this.field_139
               .method_29(var1, "" + this.field_353 + " / " + this.field_384 + " / " + this.field_377[this.field_376][2], 2, field_154, field_152, 4, 1);
         }
      }
   }

   // $VF: renamed from: z () void
   void method_115() {
      if (this.field_155) {
         this.field_258 = 0;
      } else {
         if (this.field_259 > 0) {
            this.field_259 = this.field_259 - this.field_223;
            if (this.field_259 % 100 > 50) {
               this.field_258 = 3;
            } else {
               this.field_258 = -3;
            }
         } else {
            this.field_258 = 0;
         }
      }
   }

   // $VF: renamed from: k (javax.microedition.lcdui.Graphics) void
   private void method_116(Graphics var1) {
      this.field_138.method_346(var1, 14540253);
      this.method_108(var1, this.field_148);
      if (this.field_174 != null) {
         this.field_174.a(var1);
      }
   }

   // $VF: renamed from: l (javax.microedition.lcdui.Graphics) void
   private void method_117(Graphics var1) {
      int var5 = 0;
      int var7 = 0;
      int var10 = 0;
      String var14 = "";
      byte var15 = 0;
      byte var2 = 24;
      var15 = 2;
      int var4 = var2 + 4 + 4;
      this.field_138.method_346(var1, 0);
      this.field_138.method_344(var1, 0, 0, field_152, field_151);
      this.field_138.method_346(var1, 14540253);
      this.method_108(var1, this.field_148);
      int var18 = this.field_139.method_39(0) + 4 + var15;
      int var8 = field_151 / 5 * 3;
      int var9 = (var8 - var18) / (var4 - 2);
      if (this.field_234 > var9 - 1) {
         var10 = this.field_234 - (var9 - 1);
      }

      this.field_138.method_345(var1, 0, var18 - 2, field_152, var8 - var18);

      for (int var6 = 0; var6 < this.field_369.length && var6 <= var9 - 1; var6++) {
         this.method_122(var1, 8, var18, field_152 - 20, var2);
         if (var6 + var10 < 5) {
            this.method_124(var1, (byte)(var6 + 1 + var10), 14, var18 + 5);
            if (var6 + 1 + var10 != 5) {
               class_25.method_320(var1, this.field_332, 22, var18 + 5 + 3, 0, 20);
            }

            if (!this.field_244.field_90[var6 + 1 + var10]) {
               class_25.method_320(var1, this.field_363, 14, var18 + 5, 0, 20);
            }

            this.field_138.method_346(var1, 14540253);
            this.field_139
               .method_29(
                  var1,
                  this.field_244.field_83[var6 + 1 + var10] + " / " + this.field_233[var6 + 1 + var10],
                  22 + this.field_332.getWidth() + 3,
                  var18 + 5,
                  field_152,
                  4,
                  1
               );
         } else {
            this.method_124(var1, (byte)(var6 + var10 - 3), 14, var18 + 5);
            if (this.field_244.field_90[var6 + var10 - 3]) {
               class_25.method_320(var1, this.field_363, 14, var18 + 5, 0, 20);
            }
         }

         var18 += var4 - 2;
      }

      var5 = this.field_139.method_39(0) + 4 + var15;
      if (this.field_234 > var9 - 1) {
         var7 = (var4 - 2) * (var9 - 1);
      } else {
         var7 = (var4 - 2) * this.field_234;
      }

      this.field_138.method_346(var1, 16711680);
      this.field_138.method_343(var1, 8, var5 + var7, field_152 - 20, var2);
      if (this.field_234 < this.field_369.length - 1) {
         class_25.method_321(var1, field_152 - 8, var8 - 8, 1, 4, 16777215);
      }

      if (this.field_234 > 0) {
         class_25.method_321(var1, field_152 - 8, var5, 0, 4, 16777215);
      }

      if (this.field_371) {
         int var11 = field_153 - field_152 / 100 * 30 / 2;
         int var12 = var8 / 2 - var2 / 2;
         int var13 = field_152 / 100 * 30;
         this.field_138.method_346(var1, 0);
         this.field_138.method_344(var1, var11, var12, var13, var2);
         this.method_122(var1, var11, var12, var13, var2);
         if (this.field_149 % 10 != 0) {
            class_25.method_321(var1, field_153 - 2, var12 - 4, 0, 4, 16777215);
            class_25.method_321(var1, field_153 - 2, var12 + var2, 1, 4, 16777215);
            class_25.method_321(var1, var11 - 4, var12 + var2 / 2, 2, 4, 16777215);
            class_25.method_321(var1, var11 + var13, var12 + var2 / 2, 3, 4, 16777215);
         }

         this.field_138.method_346(var1, 14540253);
         String var16 = "";
         if (this.field_370 < 10) {
            var16 = var16 + "0" + this.field_370;
         } else {
            var16 = var16 + this.field_370;
         }

         int var17 = this.field_139.method_36(var16, 1);
         this.field_139.method_29(var1, var16, var11 + var13 / 2 - var17 / 2, var12 + var2 / 2 - this.field_139.method_39(1) / 2, field_152, 4, 1);
      } else if (this.field_372) {
         int var21 = field_153 - field_152 / 100 * 90 / 2;
         int var22 = var8 / 2 - var2 / 2 * 3;
         int var23 = field_152 / 100 * 90;
         this.field_138.method_346(var1, 0);
         this.field_138.method_344(var1, var21, var22, var23, var2 * 2);
         this.method_122(var1, var21, var22, var23, var2 * 2);
         this.field_138.method_346(var1, 14540253);
         String var31 = this.field_143[90] + "?";
         this.field_139
            .method_31(var1, var31, var21, var22 + var2 / 2 - this.field_139.method_39(1) / 2, var23, 1, 1, this.field_149 * 2, field_153, field_153);
         if (!this.field_373) {
            if (this.field_149 % 10 == 0) {
               this.field_138.method_346(var1, 16711680);
            } else {
               this.field_138.method_346(var1, 16777215);
            }
         } else {
            this.field_138.method_346(var1, 16777215);
         }

         this.field_139.method_29(var1, this.field_143[33], var21 + var23 / 2 - 4, var22 + var2 / 2 + this.field_139.method_39(1), field_152, 8, 1);
         if (this.field_373) {
            if (this.field_149 % 10 == 0) {
               this.field_138.method_346(var1, 16711680);
            } else {
               this.field_138.method_346(var1, 16777215);
            }
         } else {
            this.field_138.method_346(var1, 16777215);
         }

         this.field_139.method_29(var1, this.field_143[32], var21 + var23 / 2 + 4, var22 + var2 / 2 + this.field_139.method_39(1), field_152, 4, 1);
      }

      this.field_138.method_345(var1, 0, 0, field_152, field_151);
      int var3 = field_151 - var8 - (this.field_142[this.field_147[1]].getHeight() + 2) - 2 - 2;
      this.field_138.method_346(var1, 0);
      this.field_138.method_344(var1, 4, var8 + 2, field_152 - 8, var3);
      this.method_122(var1, 4, var8 + 2, field_152 - 8, var3);
      this.field_138.method_346(var1, 14540253);
      this.field_138.method_345(var1, 0, var8 + 2, field_152, var3 - 2);
      if (this.field_234 < 5) {
         if (this.field_234 != 4) {
            var14 = this.field_143[89];
         } else {
            var14 = this.field_143[23];
         }

         var14 = var14 + " ";
         var14 = var14 + this.field_143[79 + this.field_234];
         if (this.field_367) {
            var14 = this.field_143[93];
         }
      } else {
         if (this.field_244.field_90[this.field_234 - 3]) {
            var14 = this.field_143[92];
         } else {
            var14 = this.field_143[90];
            var14 = var14 + ": ";
            var14 = var14 + this.field_143[80 + (this.field_234 - 5)];
         }

         if (this.field_367) {
            var14 = this.field_143[93];
         }
      }

      int var32 = this.field_139.method_40(var14, field_152 - 16, 1);
      if (var3 > this.field_139.method_39(1) * var32) {
         this.field_139.method_32(var1, var14, 8, var8 + 2 + 2, field_152 - 16, 4, 1, this.field_139.method_39(1), false);
      } else {
         this.field_139
            .method_31(var1, var14, 8, var8 + 2 + var3 / 2 - this.field_139.method_39(1) / 2, field_152 - 16, 4, 1, this.field_149 * 2, field_153, field_153);
      }

      this.field_138.method_345(var1, 0, 0, field_152, field_151);
      this.field_138.method_346(var1, 14540253);
      if (!this.field_371) {
         this.method_58();
         this.field_139
            .method_31(
               var1,
               "$" + this.field_364 + " / $" + this.field_365[this.field_234],
               4 + this.field_142[this.field_147[1]].getWidth(),
               field_151 - this.field_139.method_39(1) - 2,
               field_152 - 4 - this.field_142[this.field_147[1]].getWidth() * 2,
               1,
               1,
               this.field_149 * 2,
               field_153,
               field_153
            );
      } else {
         this.field_139
            .method_31(
               var1,
               "$" + this.field_364 + " / $" + this.field_370 * this.field_365[this.field_234],
               4 + this.field_142[this.field_147[1]].getWidth(),
               field_151 - this.field_139.method_39(1) - 2,
               field_152 - 4 - this.field_142[this.field_147[1]].getWidth() * 2,
               1,
               1,
               this.field_149 * 2,
               field_153,
               field_153
            );
      }
   }

   // $VF: renamed from: m (javax.microedition.lcdui.Graphics) void
   private void method_118(Graphics var1) {
      int var5 = 0;
      int var7 = 0;
      String var9 = null;
      int var11 = 0;
      int var12 = 0;
      String var13 = "";
      byte var18 = 0;
      byte var2 = 24;
      var18 = 2;
      int var4 = var2 + 4 + 4;
      this.field_138.method_346(var1, 0);
      this.field_138.method_344(var1, 0, 0, field_152, field_151);
      this.field_138.method_346(var1, 14540253);
      this.method_108(var1, this.field_148);
      int var23 = this.field_139.method_39(0) + 4 + var18;
      int var8 = field_151 / 5 * 3;
      this.field_138.method_345(var1, 0, var23 - 2, field_152, var8 - var23);
      if (this.field_361) {
         this.field_138.method_346(var1, 1118481);
         this.field_138.method_344(var1, 0, 0, field_152 / 2, var8);
         this.field_138.method_346(var1, 0);
         this.field_138.method_344(var1, field_152 / 2, 0, field_152 / 2, var8);
      } else {
         this.field_138.method_346(var1, 0);
         this.field_138.method_344(var1, 0, 0, field_152 / 2, var8);
         this.field_138.method_346(var1, 1118481);
         this.field_138.method_344(var1, field_152 / 2, 0, field_152 / 2, var8);
      }

      int var10 = (var8 - var23) / (var4 - 2);
      if (this.field_234 > var10 - 1) {
         var12 = this.field_234 - (var10 - 1);
      }

      for (int var6 = 0; var6 < this.field_366 && var6 <= var10 - 1; var6++) {
         this.method_122(var1, 8, var23, field_153 - 20, var2);
         this.method_124(var1, this.field_399[var6 + var12], 14, var23 + 5);
         if (var6 == this.field_234) {
            if (this.field_361) {
               this.field_138.method_346(var1, 16711680);
            } else {
               this.field_138.method_346(var1, 255);
            }

            this.field_138.method_343(var1, 8, var23, field_153 - 20, var2);
         }

         var23 += var4 - 2;
      }

      if (this.field_234 > var10 - 1) {
         if (this.field_361) {
            this.field_138.method_346(var1, 16711680);
         } else {
            this.field_138.method_346(var1, 255);
         }

         this.field_138.method_343(var1, 8, var23 - (var4 - 2), field_153 - 20, var2);
      }

      int var24 = this.field_139.method_39(0) + 4 + var18;
      if (this.field_361 && this.field_366 > var10) {
         if (this.field_234 < this.field_366 - 1) {
            class_25.method_321(var1, field_153 - 8, var8 - 8, 1, 4, 16777215);
         }

         if (this.field_234 > 0) {
            class_25.method_321(var1, field_153 - 8, var24, 0, 4, 16777215);
         }
      }

      if (this.field_235 > var10 - 1) {
         var12 = this.field_235 - (var10 - 1);
      } else {
         var12 = 0;
      }

      var7 = this.field_139.method_36(": ", 1);
      if (this.field_399 != null) {
         for (int var26 = 0; var26 < 3 && var26 <= var10 - 1; var26++) {
            this.method_122(var1, field_153 + 5, var24, field_153 - 20, var2);
            byte var14 = (byte)(this.field_232[this.field_399[this.field_234]][var26 + var12] + 1);
            if (var14 > 3) {
               var14 = 3;
            }

            switch (var26 + var12) {
               case 0:
                  var13 = this.field_143[67];
                  break;
               case 1:
                  var13 = this.field_143[68];
                  break;
               case 2:
                  var13 = this.field_143[69];
            }

            this.field_138.method_346(var1, 14540253);
            this.field_139
               .method_31(
                  var1, var13, field_153 + 12, var24 + 5 + 7 - this.field_139.method_39(1) / 2, (field_153 - 20 - 12) / 3 * 2, 4, 1, this.field_149, 10, 0
               );
            if (this.field_232[this.field_399[this.field_234]][var26 + var12] == 3) {
               this.field_139
                  .method_29(var1, ": ", field_153 + 12 + (field_153 - 20 - 12) / 3 * 2 + 1, var24 + 5 + 7 - this.field_139.method_39(1) / 2, field_152, 4, 1);
               this.field_139
                  .method_31(
                     var1,
                     this.field_143[87],
                     field_153 + 12 + (field_153 - 20 - 12) / 3 * 2 + 1 + var7,
                     var24 + 5 + 7 - this.field_139.method_39(1) / 2,
                     (field_153 - 20 - 12) / 3 - var7,
                     4,
                     1,
                     this.field_149,
                     10,
                     0
                  );
            } else {
               this.field_139
                  .method_29(
                     var1, ": " + var14, field_153 + 12 + (field_153 - 20 - 12) / 3 * 2 + 1, var24 + 5 + 7 - this.field_139.method_39(1) / 2, field_152, 4, 1
                  );
            }

            var24 += var4 - 2;
         }
      }

      var5 = this.field_139.method_39(1) + 4 + 6;
      if (!this.field_361 && 3 > var10) {
         if (this.field_235 < 2) {
            class_25.method_321(var1, field_152 - 8, var8 - 8, 1, 4, 16777215);
         }

         if (this.field_235 > 0) {
            class_25.method_321(var1, field_152 - 8, var5, 0, 4, 16777215);
         }
      }

      if (this.field_235 > var10 - 1) {
         var11 = (var4 - 2) * (var10 - 1);
      } else {
         var11 = (var4 - 2) * this.field_235;
      }

      if (!this.field_361) {
         this.field_138.method_346(var1, 16711680);
         this.field_138.method_343(var1, field_153 + 5, var5 + var11 - 2, field_153 - 20, var2);
      }

      if (this.field_371) {
         int var15 = field_153 - field_152 / 100 * 90 / 2;
         int var16 = var8 / 2 - var2 / 2 * 3;
         int var17 = field_152 / 100 * 90;
         this.field_138.method_346(var1, 0);
         this.field_138.method_344(var1, var15, var16, var17, var2 * 2);
         this.method_122(var1, var15, var16, var17, var2 * 2);
         this.field_138.method_346(var1, 14540253);
         String var19 = this.field_143[88];
         this.field_139
            .method_31(var1, var19, var15, var16 + var2 / 2 - this.field_139.method_39(1) / 2, var17, 1, 1, this.field_149 * 2, field_153, field_153);
         if (!this.field_362) {
            if (this.field_149 % 10 == 0) {
               this.field_138.method_346(var1, 16711680);
            } else {
               this.field_138.method_346(var1, 16777215);
            }
         } else {
            this.field_138.method_346(var1, 16777215);
         }

         this.field_139.method_29(var1, this.field_143[33], var15 + var17 / 2 - 4, var16 + var2 / 2 + this.field_139.method_39(1), field_152, 8, 1);
         if (this.field_362) {
            if (this.field_149 % 10 == 0) {
               this.field_138.method_346(var1, 16711680);
            } else {
               this.field_138.method_346(var1, 16777215);
            }
         } else {
            this.field_138.method_346(var1, 16777215);
         }

         this.field_139.method_29(var1, this.field_143[32], var15 + var17 / 2 + 4, var16 + var2 / 2 + this.field_139.method_39(1), field_152, 4, 1);
      }

      this.field_138.method_345(var1, 0, 0, field_152, field_151);
      int var3 = field_151 - var8 - (this.field_142[this.field_147[1]].getHeight() + 2) - 2 - 2;
      this.field_138.method_346(var1, 0);
      this.field_138.method_344(var1, 4, var8 + 2, field_152 - 8, var3);
      this.method_122(var1, 4, var8 + 2, field_152 - 8, var3);
      this.field_138.method_346(var1, 14540253);
      this.field_138.method_345(var1, 0, var8 + 2, field_152, var3 - 2);
      if (this.field_399 != null) {
         if (this.field_361) {
            var9 = this.field_143[72 + this.field_399[this.field_234]];
         } else if (this.field_367) {
            var9 = this.field_143[93];
         } else {
            var9 = this.field_143[84 + this.field_235];
         }
      }

      int var31 = 0;
      if (var9 != null) {
         var31 = this.field_139.method_40(var9, field_152 - 16, 1);
      } else {
         var9 = " ";
      }

      if (var3 > this.field_139.method_39(1) * var31) {
         if (var9 != null) {
            this.field_139.method_32(var1, var9, 8, var8 + 2 + 2, field_152 - 16, 4, 1, this.field_139.method_39(1), false);
         }
      } else if (var9 != null) {
         this.field_139
            .method_31(var1, var9, 8, var8 + 2 + var3 / 2 - this.field_139.method_39(1) / 2, field_152 - 16, 4, 1, this.field_149 * 2, field_153, field_153);
      }

      this.field_138.method_345(var1, 0, 0, field_152, field_151);
      this.field_138.method_346(var1, 14540253);
      byte var20 = 0;
      if (this.field_399 != null) {
         var20 = this.field_232[this.field_399[this.field_234]][this.field_235];
      }

      String var21 = "";
      if (this.field_361) {
         var21 = "$" + this.field_364 + " / $--";
      } else {
         var21 = "$" + this.field_364 + " / $";
         if (var20 == 3) {
            var21 = var21 + "--";
         } else {
            byte var22 = this.method_245();
            if (this.field_399 != null) {
               var21 = var21 + this.field_231[var22][this.field_399[this.field_234]];
            }
         }
      }

      this.field_139
         .method_31(
            var1,
            var21,
            4 + this.field_142[this.field_147[1]].getWidth(),
            field_151 - this.field_139.method_39(1) - 2,
            field_152 - 4 - this.field_142[this.field_147[1]].getWidth() * 2,
            1,
            1,
            this.field_149 * 2,
            field_153,
            field_153
         );
   }

   // $VF: renamed from: ab () byte
   private byte method_119() {
      byte var1 = 0;

      for (int var2 = 0; var2 < this.field_244.field_90.length; var2++) {
         if (this.field_244.field_90[var2]) {
            var1++;
         }
      }

      return var1;
   }

   // $VF: renamed from: ac () void
   private void method_120() {
      this.field_399 = new byte[this.field_366];
      int var2 = 0;

      for (int var1 = 0; var1 < this.field_244.field_90.length - 1; var1++) {
         if (this.field_244.field_90[var1]) {
            this.field_399[var2] = (byte)var1;
            var2++;
         }
      }
   }

   // $VF: renamed from: n (javax.microedition.lcdui.Graphics) void
   private final void method_121(Graphics var1) {
      if (class_25.field_533) {
         this.method_138(var1, 0);
         this.method_136(var1, 0, 0, field_152, field_151);
         this.method_138(var1, 16777215);
         if (this.field_158 == 0) {
            this.field_139.method_29(var1, "Press Ok", field_153 - this.field_139.method_36("Press 0", 0) / 2, field_154, field_152, 0, 0);
         } else if (this.field_158 == 1) {
            this.field_139.method_29(var1, "Pulsa Ok", field_153 - this.field_139.method_36("Pulsa 0", 0) / 2, field_154, field_152, 0, 0);
         } else {
            this.field_139.method_29(var1, "Pressione Ok", field_153 - this.field_139.method_36("Pressione 0", 0) / 2, field_154, field_152, 0, 0);
         }
      }
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, int, int, int, int) void
   void method_122(Graphics var1, int var2, int var3, int var4, int var5) {
      this.method_137(var1, 8, 78, 86);
      this.method_135(var1, var2, var3, var4, var5);
      var2--;
      var3--;
      var4 += 2;
      var5 += 2;
      this.method_137(var1, 81, 84, 76);
      this.method_134(var1, var2 + 1, var3, var2 + var4 - 2, var3);
      this.method_134(var1, var2 + 1, var3 + var5 - 1, var2 + var4 - 2, var3 + var5 - 1);
      this.method_134(var1, var2, var3 + 1, var2, var3 + var5 - 2);
      this.method_134(var1, var2 + var4 - 1, var3 + 1, var2 + var4 - 1, var3 + var5 - 2);
      var2--;
      var3--;
      var4 += 2;
      var5 += 2;
      this.method_137(var1, 63, 88, 29);
      this.method_134(var1, var2 + 2, var3, var2 + var4 - 3, var3);
      this.method_134(var1, var2 + 2, var3 + var5 - 1, var2 + var4 - 3, var3 + var5 - 1);
      this.method_134(var1, var2, var3 + 2, var2, var3 + var5 - 3);
      this.method_134(var1, var2 + var4 - 1, var3 + 2, var2 + var4 - 1, var3 + var5 - 3);
      this.method_136(var1, var2 + 1, var3 + 1, 1, 1);
      this.method_136(var1, var2 + 1, var3 + var5 - 2, 1, 1);
      this.method_136(var1, var2 + var4 - 2, var3 + 1, 1, 1);
      this.method_136(var1, var2 + var4 - 2, var3 + var5 - 2, 1, 1);
   }

   // $VF: renamed from: b (javax.microedition.lcdui.Graphics) void
   void method_123(Graphics var1) {
      boolean var6 = true;
      int var2 = field_152 - 4 - 14 - 7 - 16;
      byte var4 = 14;
      byte var5 = 14;
      byte var3 = 2;
      this.method_137(var1, 6, 78, 83);
      this.method_135(var1, var2, var3, var4 + 2, var5 + 2);
      this.method_137(var1, 130, 135, 121);
      this.method_136(var1, var2 + 1, var3 + 1, var4, var5);
      if (this.method_125()) {
         this.method_137(var1, 0, 255, 0);
      } else {
         this.method_137(var1, 255, 0, 0);
      }

      this.method_134(var1, var2 + 1, var3 - 1, var2 + var4, var3 - 1);
      this.method_134(var1, var2 + 1, var3 + var5 + 2, var2 + var4, var3 + var5 + 2);
      this.method_134(var1, var2 + var4 + 2, var3 + 1, var2 + var4 + 2, var3 + var5);
      this.method_134(var1, var2 - 1, var3 + 1, var2 - 1, var3 + var5);
      this.method_135(var1, var2, var3, 1, 1);
      this.method_135(var1, var2 + var4 + 1, var3, 1, 1);
      this.method_135(var1, var2 + var4 + 1, var3 + var5 + 1, 1, 1);
      this.method_135(var1, var2, var3 + var5 + 1, 1, 1);
      this.method_137(var1, 255, 255, 255);
      if (this.field_244.field_84 != 127) {
         if (this.field_244.field_81 == field_228[this.field_244.field_84] && this.field_244.field_84 != 0 && this.field_244.field_81 != 0) {
            if (this.field_244.field_83[this.field_244.field_84] <= 0 && (this.field_226 & 512) != 0 && this.field_222 % 600L < 300L) {
               this.method_137(var1, 255, 0, 0);
            } else {
               this.method_137(var1, 255, 255, 255);
            }
         }

         if (this.field_244.field_90[this.field_244.field_84] && this.field_244.field_84 != 0) {
            this.field_138.method_346(var1, 0);
            this.field_139
               .method_29(
                  var1, "" + this.field_244.field_83[this.field_244.field_84], var2 - 3 + 1, var3 + 14 - this.field_139.method_39(1) + 1, field_152, 8, 1
               );
            this.field_138.method_346(var1, 16777215);
            this.field_139
               .method_29(var1, "" + this.field_244.field_83[this.field_244.field_84], var2 - 3, var3 + 14 - this.field_139.method_39(1), field_152, 8, 1);
         }

         this.method_124(var1, this.field_244.field_84, var2 + 1, var3 + 1);
         if (!this.field_244.field_90[this.field_244.field_84]) {
            class_25.method_320(var1, this.field_363, var2, var3, 0, 20);
         }
      } else {
         class_25.method_320(var1, this.field_363, var2, var3, 0, 20);
      }

      int var10 = var2 + 21;
      if (this.field_244.field_78.field_20 < 5 && this.field_149 % 5 == 0) {
         var6 = false;
      }

      if (var6) {
         this.method_146(var1, 2, var10, var3, 16, 16, 16, 0, 0);
         this.method_146(
            var1,
            2,
            var10,
            var3 + 16 - 16 * this.field_244.field_78.field_20 / this.field_244.field_78.field_21,
            16,
            16 * this.field_244.field_78.field_20 / this.field_244.field_78.field_21,
            0,
            16 - 16 * this.field_244.field_78.field_20 / this.field_244.field_78.field_21,
            0
         );
      }

      if (this.field_347 == 2) {
         class_25.method_320(var1, this.field_324, 2, 2, 0, 20);
         this.field_138.method_346(var1, 0);
         this.field_139.method_29(var1, "" + this.field_350, 4 + this.field_324.getWidth() + 1, 3, field_152, 4, 1);
         this.field_138.method_346(var1, 16777215);
         this.field_139.method_29(var1, "" + this.field_350, 4 + this.field_324.getWidth(), 2, field_152, 4, 1);
      } else if (this.field_347 == 1) {
         class_25.method_320(var1, this.field_325, 2, 2, 0, 20);
         this.field_138.method_346(var1, 0);
         this.field_139.method_29(var1, "" + this.field_238, 4 + this.field_325.getWidth() + 1, 3, field_152, 4, 1);
         this.field_138.method_346(var1, 16777215);
         this.field_139.method_29(var1, "" + this.field_238, 4 + this.field_325.getWidth(), 2, field_152, 4, 1);
      } else if (this.field_347 == 0 && this.method_74(1)) {
         int var7 = (int)(this.field_381 / 1000L / 60L);
         int var8 = (int)(this.field_381 / 1000L - (long)(var7 * 60));
         String var9 = "";
         if (var8 >= 10) {
            var9 = var9 + var8;
         } else {
            var9 = var9 + "0" + var8;
         }

         this.field_138.method_346(var1, 0);
         this.field_139.method_29(var1, var7 + ":" + var9, 3, 3, field_152, 4, 0);
         this.field_138.method_346(var1, 16777215);
         this.field_139.method_29(var1, var7 + ":" + var9, 2, 2, field_152, 4, 0);
      }

      if (this.field_347 == 0 && this.method_74(256)) {
         class_25.method_320(var1, this.field_324, field_153 - 2, field_151 - this.field_324.getHeight() - 2, 0, 24);
         int var11;
         if (this.method_74(128)) {
            var11 = this.field_377[this.field_376][7];
         } else {
            var11 = this.field_377[this.field_376][2];
         }

         this.field_138.method_346(var1, 0);
         this.field_139.method_29(var1, "" + this.field_350 + " / " + var11, field_153 + 2, field_151 - this.field_139.method_39(1) - 2, field_152, 4, 1);
         this.field_138.method_346(var1, 16777215);
         this.field_139.method_29(var1, "" + this.field_350 + " / " + var11, field_153 + 2, field_151 - this.field_139.method_39(1) - 1, field_152, 4, 1);
      }
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, byte, int, int) void
   void method_124(Graphics var1, byte var2, int var3, int var4) {
      class_25.method_320(var1, this.field_230[var2], var3, var4, 0, 20);
   }

   // $VF: renamed from: ad () boolean
   private boolean method_125() {
      boolean var1 = false;
      if (this.field_244.field_84 == 127) {
         return false;
      } else if (this.field_244.field_84 == 5) {
         return true;
      } else {
         if (this.field_236[this.field_244.field_84] > this.field_222) {
            var1 = false;
         } else {
            var1 = true;
         }

         return var1;
      }
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, int, int, int) void
   void method_126(Graphics var1, int var2, int var3, int var4) {
      int var8 = 0;
      int var9 = 0;
      byte var6 = this.field_281[var2].field_34;
      int var7 = 9 + var6;
      if (this.field_321 == var2) {
         var8 = this.field_322;
         var9 = this.field_323;
      }

      this.method_147(
         var1,
         var7,
         var3,
         var4,
         this.field_284[var6][2] + var8,
         this.field_284[var6][3] + var9,
         this.field_284[var6][0],
         this.field_284[var6][1],
         0,
         0,
         0,
         this.field_281[var2].field_40
      );

      for (int var5 = 0; var5 < this.field_281[var2].field_42; var5++) {
         if (!this.field_281[var2].field_41[var5].field_72) {
         }
      }
   }

   // $VF: renamed from: o (javax.microedition.lcdui.Graphics) void
   private void method_127(Graphics var1) {
      if (this.field_326.field_38) {
         int var2 = this.method_167(this.field_326.field_35, this.field_326.field_36) - this.field_273;
         int var3 = this.method_168(this.field_326.field_35, this.field_326.field_36) - this.field_274;
         var2 += 10;
         var3 += 0;
         class_25.method_320(var1, this.field_327, var2, var3, 0, 20);
      }

      if (this.field_331.field_38) {
         int var5 = this.method_167(this.field_331.field_35, this.field_331.field_36) - this.field_273;
         int var10 = this.method_168(this.field_331.field_35, this.field_331.field_36) - this.field_274;
         var5 += 10;
         var10 += 0;
         class_25.method_320(var1, this.field_332, var5, var10, 0, 20);
      }

      if (this.field_336.field_38) {
         int var7 = this.method_167(this.field_336.field_35, this.field_336.field_36) - this.field_273;
         int var12 = this.method_168(this.field_336.field_35, this.field_336.field_36) - this.field_274;
         var7 += 3;
         var12 += 0;
         class_25.method_320(var1, this.field_337, var7, var12, 0, 20);
      }
   }

   // $VF: renamed from: c (javax.microedition.lcdui.Graphics) void
   void method_128(Graphics var1) {
      this.field_253 = 0;

      for (int var2 = 0; var2 < this.field_280; var2++) {
         if (this.field_281[var2].field_38
            && this.field_279 == this.field_267[this.field_281[var2].field_35][this.field_281[var2].field_36]
            && this.field_284[this.field_281[var2].field_34][6] != 1
            && this.field_284[this.field_281[var2].field_34][8] == 1) {
            int var5 = this.method_167(this.field_281[var2].field_35, this.field_281[var2].field_36) - this.field_273;
            int var6 = this.method_168(this.field_281[var2].field_35, this.field_281[var2].field_36) - this.field_274;
            this.method_126(var1, var2, var5 + this.field_257, var6 + this.field_258);
         }
      }

      for (int var9 = 0; var9 < this.field_280; var9++) {
         if (this.field_281[var9].field_38
            && this.field_279 == this.field_267[this.field_281[var9].field_35][this.field_281[var9].field_36]
            && this.field_284[this.field_281[var9].field_34][6] != 1
            && this.field_284[this.field_281[var9].field_34][8] != 1) {
            int var24;
            int var33;
            if (this.field_281[var9].field_40) {
               var24 = this.field_281[var9].field_35 + this.field_284[this.field_281[var9].field_34][5];
               var33 = this.field_281[var9].field_36 + this.field_284[this.field_281[var9].field_34][4];
            } else {
               var24 = this.field_281[var9].field_35 + this.field_284[this.field_281[var9].field_34][4];
               var33 = this.field_281[var9].field_36 + this.field_284[this.field_281[var9].field_34][5];
            }

            int var8 = -1;

            for (int var3 = 0; var3 < this.field_253; var3++) {
               if (this.method_140(this.field_281[this.field_251[var3]].field_35, this.field_281[this.field_251[var3]].field_36, 0, 0, var24, var33)) {
                  var8 = -1;
               } else if (var8 == -1) {
                  var8 = var3;
               }
            }

            if (var8 == -1) {
               this.field_251[this.field_253] = (short)var9;
               this.field_252[this.field_253] = 0;
            } else {
               for (int var4 = this.field_253; var4 > var8; var4--) {
                  this.field_251[var4] = this.field_251[var4 - 1];
                  this.field_252[var4] = this.field_252[var4 - 1];
               }

               this.field_251[var8] = (short)var9;
               this.field_252[var8] = 0;
            }

            this.field_253++;
         }
      }

      for (int var10 = 0; var10 < 24; var10++) {
         if (this.field_247[var10].field_9
            && this.field_247[var10].field_10 < this.field_262
            && this.field_247[var10].field_11 < this.field_263
            && this.field_247[var10].field_18 != 3
            && this.field_279 == this.field_267[this.field_247[var10].field_10][this.field_247[var10].field_11]
            && this.field_247[var10].field_14 == 4) {
            byte var25 = this.field_247[var10].field_10;
            byte var34 = this.field_247[var10].field_11;
            int var42 = -1;

            for (int var16 = 0; var16 < this.field_253; var16++) {
               if (this.field_252[var16] == 0) {
                  if (this.method_140(this.field_281[this.field_251[var16]].field_35, this.field_281[this.field_251[var16]].field_36, 0, 0, var25, var34)) {
                     var42 = -1;
                  } else if (var42 == -1) {
                     var42 = var16;
                  }
               } else if (this.field_252[var16] == 4) {
                  if (this.method_140(this.field_247[this.field_251[var16]].field_10, this.field_247[this.field_251[var16]].field_11, 0, 0, var25, var34)) {
                     var42 = -1;
                  } else if (var42 == -1) {
                     var42 = var16;
                  }
               }
            }

            if (var42 == -1) {
               this.field_251[this.field_253] = (short)var10;
               this.field_252[this.field_253] = 4;
            } else {
               for (int var20 = this.field_253; var20 > var42; var20--) {
                  this.field_251[var20] = this.field_251[var20 - 1];
                  this.field_252[var20] = this.field_252[var20 - 1];
               }

               this.field_251[var42] = (short)var10;
               this.field_252[var42] = 4;
            }

            this.field_253++;
         }
      }

      for (int var11 = 0; var11 < 24; var11++) {
         if (this.field_247[var11].field_9
            && this.field_247[var11].field_10 < this.field_262
            && this.field_247[var11].field_11 < this.field_263
            && this.field_279 == this.field_267[this.field_247[var11].field_10][this.field_247[var11].field_11]
            && (this.field_247[var11].field_14 != 4 || this.field_247[var11].field_26 || this.field_247[var11].field_18 == 3)) {
            int var26 = this.field_247[var11].field_10 + 1;
            int var35 = this.field_247[var11].field_11 + 1;
            int var43 = -1;

            for (int var17 = 0; var17 < this.field_253; var17++) {
               if (this.field_252[var17] == 0) {
                  if (this.method_140(this.field_281[this.field_251[var17]].field_35, this.field_281[this.field_251[var17]].field_36, 0, 0, var26, var35)) {
                     var43 = -1;
                  } else if (var43 == -1) {
                     var43 = var17;
                  }
               } else if (this.field_252[var17] == 1) {
                  if (this.method_140(this.field_247[this.field_251[var17]].field_10, this.field_247[this.field_251[var17]].field_11, 0, 0, var26, var35)) {
                     var43 = -1;
                  } else if (var43 == -1) {
                     var43 = var17;
                  }
               } else if (this.field_252[var17] == 4) {
                  if (this.field_247[this.field_251[var17]].field_17 == 7) {
                     if (this.method_140(
                        this.field_247[this.field_251[var17]].field_10,
                        this.field_247[this.field_251[var17]].field_11 - field_287[this.field_247[this.field_251[var17]].field_18][1] + 1,
                        0,
                        0,
                        var26,
                        var35
                     )) {
                        var43 = -1;
                     } else if (var43 == -1) {
                        var43 = var17;
                     }
                  } else if (this.field_247[this.field_251[var17]].field_17 == 1) {
                     if (this.method_140(
                        this.field_247[this.field_251[var17]].field_10 - field_287[this.field_247[this.field_251[var17]].field_18][1] + 1,
                        this.field_247[this.field_251[var17]].field_11,
                        0,
                        0,
                        var26,
                        var35
                     )) {
                        var43 = -1;
                     } else if (var43 == -1) {
                        var43 = var17;
                     }
                  } else if (this.method_140(this.field_247[this.field_251[var17]].field_10, this.field_247[this.field_251[var17]].field_11, 0, 0, var26, var35)
                     )
                   {
                     var43 = -1;
                  } else if (var43 == -1) {
                     var43 = var17;
                  }
               }
            }

            if (var43 == -1) {
               this.field_251[this.field_253] = (short)var11;
               this.field_252[this.field_253] = 1;
            } else {
               for (int var21 = this.field_253; var21 > var43; var21--) {
                  this.field_251[var21] = this.field_251[var21 - 1];
                  this.field_252[var21] = this.field_252[var21 - 1];
               }

               this.field_251[var43] = (short)var11;
               this.field_252[var43] = 1;
            }

            this.field_253++;
         }
      }

      for (int var12 = 0; var12 < 10; var12++) {
         if (this.field_250[var12].field_121) {
            byte var27 = this.field_250[var12].field_122.field_95;
            byte var36 = this.field_250[var12].field_122.field_96;
            int var44 = -1;

            for (int var18 = 0; var18 < this.field_253; var18++) {
               if (this.field_252[var18] == 0) {
                  if (var27 >= this.field_281[this.field_251[var18]].field_35 && var36 >= this.field_281[this.field_251[var18]].field_36) {
                     var44 = -1;
                  } else if (var44 == -1) {
                     var44 = var18;
                  }
               } else if (this.field_252[var18] != 1 && this.field_252[var18] != 4) {
                  if (this.field_252[var18] == 2) {
                     if (this.field_250[var12].field_122.field_98 >= this.field_250[this.field_251[var18]].field_122.field_98) {
                        var44 = -1;
                     } else if (var44 == -1) {
                        var44 = var18;
                     }
                  }
               } else if (var27 >= this.field_247[this.field_251[var18]].field_10 && var36 >= this.field_247[this.field_251[var18]].field_11) {
                  var44 = -1;
               } else if (var44 == -1) {
                  var44 = var18;
               }
            }

            if (var44 == -1) {
               this.field_251[this.field_253] = (short)var12;
               this.field_252[this.field_253] = 2;
            } else {
               for (int var22 = this.field_253; var22 > var44; var22--) {
                  this.field_251[var22] = this.field_251[var22 - 1];
                  this.field_252[var22] = this.field_252[var22 - 1];
               }

               this.field_251[var44] = (short)var12;
               this.field_252[var44] = 2;
            }

            this.field_253++;
         }
      }

      for (int var13 = 0; var13 < 5; var13++) {
         if (this.field_249[var13].field_92) {
            byte var28 = this.field_249[var13].field_95;
            byte var37 = this.field_249[var13].field_96;
            int var45 = -1;

            for (int var19 = 0; var19 < this.field_253; var19++) {
               if (this.field_252[var19] == 0) {
                  if (var28 >= this.field_281[this.field_251[var19]].field_35 && var37 >= this.field_281[this.field_251[var19]].field_36) {
                     var45 = -1;
                  } else if (var45 == -1) {
                     var45 = var19;
                  }
               } else if (this.field_252[var19] != 1 && this.field_252[var19] != 4) {
                  if (this.field_252[var19] == 2) {
                     if (this.field_250[var13].field_122.field_98 >= this.field_250[this.field_251[var19]].field_122.field_98) {
                        var45 = -1;
                     } else if (var45 == -1) {
                        var45 = var19;
                     }
                  } else if (this.field_252[var19] == 3) {
                     if (this.field_249[var13].field_98 >= this.field_249[this.field_251[var19]].field_98) {
                        var45 = -1;
                     } else if (var45 == -1) {
                        var45 = var19;
                     }
                  }
               } else if (var28 >= this.field_247[this.field_251[var19]].field_10 && var37 >= this.field_247[this.field_251[var19]].field_11) {
                  var45 = -1;
               } else if (var45 == -1) {
                  var45 = var19;
               }
            }

            if (var45 == -1) {
               this.field_251[this.field_253] = (short)var13;
               this.field_252[this.field_253] = 3;
            } else {
               for (int var23 = this.field_253; var23 > var45; var23--) {
                  this.field_251[var23] = this.field_251[var23 - 1];
                  this.field_252[var23] = this.field_252[var23 - 1];
               }

               this.field_251[var45] = (short)var13;
               this.field_252[var45] = 3;
            }

            this.field_253++;
         }
      }

      this.method_127(var1);

      for (int var14 = 0; var14 < this.field_253; var14++) {
         if (this.field_252[var14] == 0) {
            int var29 = this.method_167(this.field_281[this.field_251[var14]].field_35, this.field_281[this.field_251[var14]].field_36) - this.field_273;
            int var38 = this.method_168(this.field_281[this.field_251[var14]].field_35, this.field_281[this.field_251[var14]].field_36) - this.field_274;
            this.method_126(var1, this.field_251[var14], var29 + this.field_257, var38 + this.field_258);
         } else if (this.field_252[var14] == 1) {
            if (this.field_251[var14] != this.field_246 - 1 || this.field_286 <= 0 || this.field_286 >= 20) {
               int var30 = this.method_167(this.field_247[this.field_251[var14]].field_10, this.field_247[this.field_251[var14]].field_11) - this.field_273;
               int var39 = this.method_168(this.field_247[this.field_251[var14]].field_10, this.field_247[this.field_251[var14]].field_11) - this.field_274;
               this.method_151(var1, this.field_247[this.field_251[var14]], var30 + this.field_257, var39 + this.field_258);
            }
         } else if (this.field_252[var14] == 2) {
            this.method_129(var1, this.field_251[var14]);
         } else if (this.field_252[var14] == 3) {
            this.method_130(var1, this.field_251[var14]);
         } else if (this.field_252[var14] == 4) {
            int var31 = this.method_167(this.field_247[this.field_251[var14]].field_10, this.field_247[this.field_251[var14]].field_11) - this.field_273;
            int var40 = this.method_168(this.field_247[this.field_251[var14]].field_10, this.field_247[this.field_251[var14]].field_11) - this.field_274;
            this.method_151(var1, this.field_247[this.field_251[var14]], var31 + this.field_257, var40 + this.field_258);
         }
      }

      boolean var7 = false;

      for (int var15 = 0; var15 < this.field_280; var15++) {
         if (this.field_281[var15].field_37
            && this.field_281[var15].field_38
            && this.field_279 != this.field_267[this.field_281[var15].field_35][this.field_281[var15].field_36]
            && (
               !this.field_281[var15].field_40
                  ? this.field_281[var15].field_35 != 0 && this.field_279 == this.field_267[this.field_281[var15].field_35 - 1][this.field_281[var15].field_36]
                  : this.field_281[var15].field_36 != 0 && this.field_279 == this.field_267[this.field_281[var15].field_35][this.field_281[var15].field_36 - 1]
            )) {
            int var32 = this.method_167(this.field_281[var15].field_35, this.field_281[var15].field_36);
            int var41 = this.method_168(this.field_281[var15].field_35, this.field_281[var15].field_36);
            this.method_126(var1, var15, var32 - this.field_273 + this.field_257, var41 - this.field_274 + this.field_258);
         }
      }
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, int) void
   void method_129(Graphics var1, int var2) {
      int var3 = class_2.field_6[this.field_250[var2].field_122.field_94][2] + this.field_250[var2].field_122.field_100;
      switch (this.field_250[var2].field_124) {
         case 4:
            this.method_146(
               var1,
               8,
               this.field_250[var2].field_122.field_97 - this.field_273 + class_2.field_5[var3][4],
               this.field_250[var2].field_122.field_98 - this.field_250[var2].field_122.field_99 - this.field_274 + class_2.field_5[var3][5],
               class_2.field_5[var3][2],
               class_2.field_5[var3][3],
               class_2.field_5[var3][0],
               class_2.field_5[var3][1],
               0
            );
            this.method_137(var1, 16, 16, 16);
            this.method_136(
               var1,
               this.field_250[var2].field_122.field_97 - this.field_273 + class_2.field_5[var3][4],
               this.field_250[var2].field_122.field_98 - this.field_274 + class_2.field_5[var3][5],
               class_2.field_5[var3][2],
               class_2.field_5[var3][3]
            );
            break;
         default:
            this.method_146(
               var1,
               field_310[this.field_250[var2].field_122.field_94],
               this.field_250[var2].field_122.field_97 - this.field_273 + class_2.field_5[var3][4],
               this.field_250[var2].field_122.field_98 - this.field_250[var2].field_122.field_99 - this.field_274 + class_2.field_5[var3][5],
               class_2.field_5[var3][2],
               class_2.field_5[var3][3],
               class_2.field_5[var3][0],
               class_2.field_5[var3][1],
               0
            );
      }
   }

   // $VF: renamed from: b (javax.microedition.lcdui.Graphics, int) void
   void method_130(Graphics var1, int var2) {
      int var3 = class_2.field_6[this.field_249[var2].field_94][2] + this.field_249[var2].field_100;
      if (this.field_249[var2].field_94 >= 5 && this.field_249[var2].field_94 <= 36) {
         boolean var4 = this.field_249[var2].field_94 > 9 && this.field_249[var2].field_94 < 13
            || this.field_249[var2].field_94 > 17 && this.field_249[var2].field_94 <= 20
            || this.field_249[var2].field_94 > 25 && this.field_249[var2].field_94 < 29
            || this.field_249[var2].field_94 > 33 && this.field_249[var2].field_94 <= 36;
         this.method_147(
            var1,
            field_310[this.field_249[var2].field_94],
            this.field_249[var2].field_97 - this.field_273,
            this.field_249[var2].field_98 - this.field_249[var2].field_99 - this.field_274,
            class_2.field_5[var3][4],
            class_2.field_5[var3][5],
            class_2.field_5[var3][2],
            class_2.field_5[var3][3],
            class_2.field_5[var3][0],
            class_2.field_5[var3][1],
            0,
            var4
         );
      } else if (this.field_249[var2].field_94 == 39) {
         this.method_146(
            var1,
            field_310[this.field_249[var2].field_94],
            this.field_249[var2].field_97 - this.field_273 + class_2.field_5[var3][4],
            this.field_249[var2].field_98 - this.field_249[var2].field_99 - this.field_274 + class_2.field_5[var3][5],
            class_2.field_5[var3][2],
            class_2.field_5[var3][3],
            class_2.field_5[var3][0],
            class_2.field_5[var3][1],
            0
         );
         if (var3 > 61 && var3 < 67) {
            var3 += 5;
            this.method_146(
               var1,
               field_310[this.field_249[var2].field_94],
               this.field_249[var2].field_97 - this.field_273 + class_2.field_5[var3][4],
               this.field_249[var2].field_98 - this.field_249[var2].field_99 - this.field_274 + class_2.field_5[var3][5],
               class_2.field_5[var3][2],
               class_2.field_5[var3][3],
               class_2.field_5[var3][0],
               class_2.field_5[var3][1],
               0
            );
            var3 += 5;
            this.method_146(
               var1,
               field_310[this.field_249[var2].field_94],
               this.field_249[var2].field_97 - this.field_273 + class_2.field_5[var3][4],
               this.field_249[var2].field_98 - this.field_249[var2].field_99 - this.field_274 + class_2.field_5[var3][5],
               class_2.field_5[var3][2],
               class_2.field_5[var3][3],
               class_2.field_5[var3][0],
               class_2.field_5[var3][1],
               0
            );
            var3 += 5;
            this.method_146(
               var1,
               field_310[this.field_249[var2].field_94],
               this.field_249[var2].field_97 - this.field_273 + class_2.field_5[var3][4],
               this.field_249[var2].field_98 - this.field_249[var2].field_99 - this.field_274 + class_2.field_5[var3][5],
               class_2.field_5[var3][2],
               class_2.field_5[var3][3],
               class_2.field_5[var3][0],
               class_2.field_5[var3][1],
               0
            );
            var3 += 5;
            this.method_146(
               var1,
               field_310[this.field_249[var2].field_94],
               this.field_249[var2].field_97 - this.field_273 + class_2.field_5[var3][4],
               this.field_249[var2].field_98 - this.field_249[var2].field_99 - this.field_274 + class_2.field_5[var3][5],
               class_2.field_5[var3][2],
               class_2.field_5[var3][3],
               class_2.field_5[var3][0],
               class_2.field_5[var3][1],
               0
            );
         }
      } else {
         this.method_146(
            var1,
            field_310[this.field_249[var2].field_94],
            this.field_249[var2].field_97 - this.field_273 + class_2.field_5[var3][4],
            this.field_249[var2].field_98 - this.field_249[var2].field_99 - this.field_274 + class_2.field_5[var3][5],
            class_2.field_5[var3][2],
            class_2.field_5[var3][3],
            class_2.field_5[var3][0],
            class_2.field_5[var3][1],
            0
         );
      }
   }

   // $VF: renamed from: d (javax.microedition.lcdui.Graphics) void
   void method_131(Graphics var1) {
      this.method_132(var1, this.field_273, this.field_274, field_152, field_151, 0 + this.field_257, 0 + this.field_258);
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, int, int, int, int, int, int) void
   void method_132(Graphics var1, int var2, int var3, int var4, int var5, int var6, int var7) {
      if (var4 != 0) {
         if (var5 != 0) {
            this.field_138.method_345(var1, var6, var7, var4, var5);
            this.field_138.method_347(var1, 0, 0, 0);
            this.field_138.method_344(var1, var6, var7, var4, var5);

            for (int var9 = 0; var9 < this.field_280; var9++) {
               if (this.field_281[var9].field_37 && !this.field_281[var9].field_38) {
                  for (int var10 = 0; var10 < this.field_284[this.field_281[var9].field_34][5]; var10++) {
                     byte var8;
                     int var11;
                     int var12;
                     if (this.field_279 == this.field_267[this.field_281[var9].field_35][this.field_281[var9].field_36]) {
                        if (!this.field_281[var9].field_40) {
                           if (this.field_281[var9].field_35 == 0) {
                              continue;
                           }

                           var8 = this.field_264[this.field_281[var9].field_35 - 1][this.field_281[var9].field_36 + var10];
                           var11 = this.method_167(this.field_281[var9].field_35 - 1, this.field_281[var9].field_36 + var10) - var2;
                           var12 = this.method_168(this.field_281[var9].field_35 - 1, this.field_281[var9].field_36 + var10) - var3;
                        } else {
                           if (this.field_281[var9].field_36 == 0) {
                              continue;
                           }

                           var8 = this.field_264[this.field_281[var9].field_35 + var10][this.field_281[var9].field_36 - 1];
                           var11 = this.method_167(this.field_281[var9].field_35 + var10, this.field_281[var9].field_36 - 1) - var2;
                           var12 = this.method_168(this.field_281[var9].field_35 + var10, this.field_281[var9].field_36 - 1) - var3;
                        }
                     } else if (!this.field_281[var9].field_40) {
                        if (this.field_281[var9].field_35 == 0
                           || this.field_279 != this.field_267[this.field_281[var9].field_35 - 1][this.field_281[var9].field_36]) {
                           continue;
                        }

                        var8 = this.field_264[this.field_281[var9].field_35][this.field_281[var9].field_36 + var10];
                        var11 = this.method_167(this.field_281[var9].field_35, this.field_281[var9].field_36 + var10) - var2;
                        var12 = this.method_168(this.field_281[var9].field_35, this.field_281[var9].field_36 + var10) - var3;
                     } else {
                        if (this.field_281[var9].field_36 == 0
                           || this.field_279 != this.field_267[this.field_281[var9].field_35][this.field_281[var9].field_36 - 1]) {
                           continue;
                        }

                        var8 = this.field_264[this.field_281[var9].field_35 + var10][this.field_281[var9].field_36];
                        var11 = this.method_167(this.field_281[var9].field_35 + var10, this.field_281[var9].field_36) - var2;
                        var12 = this.method_168(this.field_281[var9].field_35 + var10, this.field_281[var9].field_36) - var3;
                     }

                     if (var8 != 127) {
                        this.method_146(var1, 89 + var8, var11 + var6, var12 + var7, 36, 18, 0, 0, 0);
                     }
                  }
               }
            }

            for (int var14 = 0; var14 < this.field_262; var14++) {
               for (int var17 = 0; var17 < this.field_263; var17++) {
                  if (this.field_267[var14][var17] == this.field_279) {
                     int var19 = this.method_167(var14, var17) - var2;
                     int var22 = this.method_168(var14, var17) - var3;
                     byte var13 = this.field_264[var14][var17];
                     if (var13 != 127) {
                        this.method_146(var1, 89 + var13, var19 + var6, var22 + var7, 36, 18, 0, 0, 0);
                     }
                  }
               }
            }

            for (int var15 = 0; var15 < this.field_262; var15++) {
               for (int var18 = 0; var18 < this.field_263; var18++) {
                  if (this.field_267[var15][var18] == this.field_279) {
                     int var20 = this.method_167(var15, var18) - var2;
                     int var23 = this.method_168(var15, var18) - var3;
                     this.method_133(var1, this.field_265[var15][var18], true, true, var20 + var6, var23 + var7);
                     this.method_133(var1, this.field_266[var15][var18], false, true, var20 + var6, var23 + var7);
                  }
               }
            }

            for (int var16 = 0; var16 < this.field_280; var16++) {
               if (this.field_281[var16].field_38
                  && this.field_279 == this.field_267[this.field_281[var16].field_35][this.field_281[var16].field_36]
                  && this.field_284[this.field_281[var16].field_34][6] == 1) {
                  int var21 = this.method_167(this.field_281[var16].field_35, this.field_281[var16].field_36) - var2;
                  int var24 = this.method_168(this.field_281[var16].field_35, this.field_281[var16].field_36) - var3;
               }
            }
         }
      }
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, short, boolean, boolean, int, int) void
   void method_133(Graphics var1, short var2, boolean var3, boolean var4, int var5, int var6) {
      if (var2 != -1) {
         byte var8;
         if (var3) {
            var8 = 0;
         } else {
            var5 += 18;
            var8 = 18;
         }

         int var7 = var2 & 255;
         if (var7 != 255) {
            this.method_146(var1, 109 + var7, var5, var6 - 21, 18, 29, var8, 0, 0);
            this.method_146(var1, 109 + var7, var5, var6 - 21 + 1, 18, 29, var8, 0, 0);
         }

         if (var4) {
            var7 = var2 >> 8 & 0xFF;
            if (var7 != 255) {
               this.method_146(var1, 109 + var7, var5, var6 - 42 + 1, 18, 29, var8, 0, 0);
            }
         }
      }
   }

   // $VF: renamed from: b (javax.microedition.lcdui.Graphics, int, int, int, int) void
   void method_134(Graphics var1, int var2, int var3, int var4, int var5) {
      var1.drawLine(var2, var3, var4, var5);
   }

   // $VF: renamed from: c (javax.microedition.lcdui.Graphics, int, int, int, int) void
   void method_135(Graphics var1, int var2, int var3, int var4, int var5) {
      var1.drawRect(var2, var3, var4 - 1, var5 - 1);
   }

   // $VF: renamed from: d (javax.microedition.lcdui.Graphics, int, int, int, int) void
   void method_136(Graphics var1, int var2, int var3, int var4, int var5) {
      var1.fillRect(var2, var3, var4, var5);
   }

   // $VF: renamed from: b (javax.microedition.lcdui.Graphics, int, int, int) void
   void method_137(Graphics var1, int var2, int var3, int var4) {
      var1.setColor(var2, var3, var4);
   }

   // $VF: renamed from: c (javax.microedition.lcdui.Graphics, int) void
   void method_138(Graphics var1, int var2) {
      this.method_137(var1, var2 >> 16 & 0xFF, var2 >> 8 & 0xFF, var2 & 0xFF);
   }

   // $VF: renamed from: a (int, int, int, int, int, int, int, int) boolean
   boolean method_139(int var1, int var2, int var3, int var4, int var5, int var6, int var7, int var8) {
      return (var5 >= var1 && var5 < var1 + var3 || var5 < var1 && var5 + var7 > var1)
         && (var6 >= var2 && var6 < var2 + var4 || var6 < var2 && var6 + var8 > var2);
   }

   // $VF: renamed from: a (int, int, int, int, int, int) boolean
   boolean method_140(int var1, int var2, int var3, int var4, int var5, int var6) {
      return var1 >= var3 && var1 < var3 + var5 && var2 >= var4 && var2 < var4 + var6;
   }

   // $VF: renamed from: a (int, int, int) int
   int method_141(int var1, int var2, int var3) {
      return var2 > var1 ? var2 : (var1 > var3 ? var3 : var1);
   }

   // $VF: renamed from: h (int) int
   int method_142(int var1) {
      return var1 * var1;
   }

   // $VF: renamed from: A () int
   public int method_143() {
      return this.field_291.nextInt() & 0xFF;
   }

   // $VF: renamed from: i (int) int
   public static int method_144(int var0) {
      return Math.abs(field_161.nextInt() % var0);
   }

   // $VF: renamed from: B () int
   int method_145() {
      return Math.abs(this.method_143() << 24 | this.method_143() << 16 | this.method_143() << 8 | this.method_143());
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, int, int, int, int, int, int, int, int) void
   void method_146(Graphics var1, int var2, int var3, int var4, int var5, int var6, int var7, int var8, int var9) {
      if (this.method_139(var3, var4, var5, var6, 0, 0, field_152, field_151)) {
         int var10 = var1.getClipX();
         int var11 = var1.getClipY();
         int var12 = var1.getClipWidth();
         int var13 = var1.getClipHeight();
         if ((var9 & 1) != 0) {
            for (int var14 = 0; var14 < var5; var14++) {
               var1.clipRect(var3 + var14, var4, 1, var6);
               if (var2 >= 9 && var2 < 89) {
                  this.field_271.method_25(var1, var3 + var14 - (var7 + var5 - var14 - 1), var4 - var8, var2 - 9);
               } else if (var2 >= 89 && var2 < 109) {
                  this.field_271.method_25(var1, var3 + var14 - (var7 + var5 - var14 - 1), var4 - var8, var2 - 89 + this.field_268);
               } else if (var2 >= 109 && var2 < 139) {
                  this.field_271.method_25(var1, var3 + var14 - (var7 + var5 - var14 - 1), var4 - var8, var2 - 109 + this.field_268 + this.field_269);
               } else {
                  var1.drawImage(this.field_289[var2], var3 + var14 - (var7 + var5 - var14 - 1), var4 - var8, 20);
               }

               var1.setClip(var10, var11, var12, var13);
            }
         } else {
            var1.clipRect(var3, var4, var5, var6);
            if (var2 >= 9 && var2 < 89) {
               this.field_271.method_25(var1, var3 - var7, var4 - var8, var2 - 9);
            } else if (var2 >= 89 && var2 < 109) {
               this.field_271.method_25(var1, var3 - var7, var4 - var8, var2 - 89 + this.field_268);
            } else if (var2 >= 109 && var2 < 139) {
               this.field_271.method_25(var1, var3 - var7, var4 - var8, var2 - 109 + this.field_268 + this.field_269);
            } else {
               var1.drawImage(this.field_289[var2], var3 - var7, var4 - var8, 20);
            }
         }

         var1.setClip(var10, var11, var12, var13);
      }
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, int, int, int, int, int, int, int, int, int, int, boolean) void
   void method_147(Graphics var1, int var2, int var3, int var4, int var5, int var6, int var7, int var8, int var9, int var10, int var11, boolean var12) {
      if (this.field_288[var2] != var12) {
         this.method_149(var2);
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

      this.method_146(var1, var2, var3, var4, var7, var8, var9, var10, var11);
   }

   // $VF: renamed from: a (u) boolean
   boolean method_148(class_4 var1) {
      return class_2.field_1[var1.field_18][var1.field_14][2] != 0;
   }

   // $VF: renamed from: j (int) void
   void method_149(int var1) {
      this.field_288[var1] = !this.field_288[var1];
   }

   // $VF: renamed from: C () void
   void method_150() {
      this.field_303 = 0;
      this.field_285 = false;
      this.field_290 = false;
      this.field_314 = 0;
      this.field_321 = -1;
      this.field_322 = 0;
      this.field_323 = 0;
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, u, int, int) void
   void method_151(Graphics var1, class_4 var2, int var3, int var4) {
      if (var2.field_18 == 0) {
      }

      if (!this.method_154(var2)) {
         int var6 = field_239[var2.field_18];
         int var5 = class_2.field_1[var2.field_18][var2.field_14][4];
         boolean var7 = var2.field_17 > 4;
         if (class_2.field_1[var2.field_18][var2.field_14][3] == 4) {
            var5 = class_2.field_2[var2.field_18][var5][this.method_155(var2, 0, 1) ? 0 : 1][var2.field_12];
         } else {
            var5 = class_2.field_4[var5][var7 ? 8 - var2.field_17 : var2.field_17][var2.field_12];
         }

         this.method_147(
            var1,
            var6,
            var3,
            var4,
            class_12.field_76[var2.field_18][var5][4],
            class_12.field_76[var2.field_18][var5][5],
            class_12.field_76[var2.field_18][var5][2],
            class_12.field_76[var2.field_18][var5][3],
            class_12.field_76[var2.field_18][var5][0],
            class_12.field_76[var2.field_18][var5][1],
            0,
            var7
         );
         if (var2 == this.field_244.field_78) {
            if (!var7) {
               this.field_242 = var3 + class_12.field_76[var2.field_18][var5][4] + class_12.field_76[var2.field_18][var5][2] / 2;
               this.field_243 = var4 + class_12.field_76[var2.field_18][var5][5] + class_12.field_76[var2.field_18][var5][3] / 2;
            } else {
               this.field_242 = var3 + 36 - class_12.field_76[var2.field_18][var5][4] - class_12.field_76[var2.field_18][var5][2] / 2;
               this.field_243 = var4 + class_12.field_76[var2.field_18][var5][5] + class_12.field_76[var2.field_18][var5][3] / 2;
            }
         }

         this.method_152(var1, var2, var6, var5, var3, var4, var7);
         this.method_153(var1, var2, var3, var4);
      }
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, u, int, int, int, int, boolean) void
   void method_152(Graphics var1, class_4 var2, int var3, int var4, int var5, int var6, boolean var7) {
      if (var2.field_18 == 0 || var2.field_18 == 1) {
         class_13 var8 = this.field_245;
         if (var4 > 9 && var4 < 22) {
            if (var8.field_78.field_19 == 127 || var8.field_84 == 0) {
               var4 += 14;
               this.method_147(
                  var1,
                  var3,
                  var5,
                  var6,
                  class_12.field_77[var2.field_18][var4][4],
                  class_12.field_77[var2.field_18][var4][5],
                  class_12.field_77[var2.field_18][var4][2],
                  class_12.field_77[var2.field_18][var4][3],
                  class_12.field_77[var2.field_18][var4][0],
                  class_12.field_77[var2.field_18][var4][1],
                  0,
                  var7
               );
            } else if (var8.field_84 == 1 || var8.field_84 == 2) {
               var4 -= 10;
               this.method_147(
                  var1,
                  var3,
                  var5,
                  var6,
                  class_12.field_77[var2.field_18][var4][4],
                  class_12.field_77[var2.field_18][var4][5],
                  class_12.field_77[var2.field_18][var4][2],
                  class_12.field_77[var2.field_18][var4][3],
                  class_12.field_77[var2.field_18][var4][0],
                  class_12.field_77[var2.field_18][var4][1],
                  0,
                  var7
               );
            } else if (var8.field_84 == 3 || var8.field_84 == 4) {
               var4 += 2;
               this.method_147(
                  var1,
                  var3,
                  var5,
                  var6,
                  class_12.field_77[var2.field_18][var4][4],
                  class_12.field_77[var2.field_18][var4][5],
                  class_12.field_77[var2.field_18][var4][2],
                  class_12.field_77[var2.field_18][var4][3],
                  class_12.field_77[var2.field_18][var4][0],
                  class_12.field_77[var2.field_18][var4][1],
                  0,
                  var7
               );
            }
         }
      }
   }

   // $VF: renamed from: b (javax.microedition.lcdui.Graphics, u, int, int) void
   void method_153(Graphics var1, class_4 var2, int var3, int var4) {
      if (var2.field_19 != 127) {
         byte var7 = var2.field_19;
         int var6 = field_240[var2.field_19];
         int var5 = class_2.field_1[var2.field_18][var2.field_14][5];
         byte var8 = var2.field_17;
         if (var5 != 127) {
            boolean var9 = var8 > 4;
            if (class_2.field_1[var2.field_18][var2.field_14][3] == 4) {
               var5 = class_2.field_3[var5][this.method_155(var2, 0, 1) ? 0 : 1][var2.field_12];
            } else {
               var5 = class_2.field_4[var5][var9 ? 8 - var8 : var8][var2.field_12];
            }

            if (var5 != 127) {
               this.method_147(
                  var1,
                  var6,
                  var3,
                  var4,
                  class_2.field_0[var7][var5][4],
                  class_2.field_0[var7][var5][5],
                  class_2.field_0[var7][var5][2],
                  class_2.field_0[var7][var5][3],
                  class_2.field_0[var7][var5][0],
                  class_2.field_0[var7][var5][1],
                  0,
                  var9
               );
            }
         }
      }
   }

   // $VF: renamed from: f (u) boolean
   private boolean method_154(class_4 var1) {
      if (var1.field_14 == 4 && var1.field_18 != 0 && var1.field_18 != 1) {
         if (var1.field_30 + 3000L > this.field_222) {
            return var1.field_30 + 3000L - this.field_222 >= 1000L ? false : this.field_149 % 3 != 0;
         } else {
            if (!var1.field_31) {
               this.field_350++;
               this.field_354++;
               this.field_384--;
               if (this.field_350 >= this.field_357[this.field_359][0] && this.field_347 == 1) {
                  if (this.field_134) {
                     this.field_364 = 9999;
                  } else {
                     this.field_364 = this.field_364 + this.field_357[this.field_359][6];
                  }

                  if (this.field_364 > 9999) {
                     this.field_364 = 9999;
                  }

                  this.method_270();
                  this.method_174(this.field_143[19]);
                  this.field_356++;
                  this.field_355++;
                  this.field_226 = 138;
                  this.field_227 = 0;
                  this.method_188();
                  this.field_370 = 0;
                  this.field_371 = false;
                  this.field_372 = false;
                  this.field_373 = false;
                  this.method_190((byte)0, (byte)1);
               } else if (this.field_350 >= this.field_377[this.field_376][2] && this.field_347 == 0) {
                  this.method_270();
                  field_172 = 19;
                  field_173 = 5;
                  this.method_60((byte)3, false);
               }
            }

            var1.field_31 = true;
            return true;
         }
      } else {
         return false;
      }
   }

   // $VF: renamed from: a (u, int, int) boolean
   boolean method_155(class_4 var1, int var2, int var3) {
      return Math.abs(var1.field_17 - var2) <= var3 ? true : Math.abs(var1.field_17 - var2) >= 8 - var3;
   }

   // $VF: renamed from: p (javax.microedition.lcdui.Graphics) void
   private void method_156(Graphics var1) {
      this.method_108(var1, this.field_148);
      if (this.field_174 != null) {
         this.field_174.a(var1);
      }
   }

   // $VF: renamed from: q (javax.microedition.lcdui.Graphics) void
   private void method_157(Graphics var1) {
      this.method_108(var1, this.field_148);
      if (this.field_174 != null) {
         this.field_174.a(var1);
      }
   }

   // $VF: renamed from: r (javax.microedition.lcdui.Graphics) void
   private void method_158(Graphics var1) {
      this.method_108(var1, this.field_148);
      if (this.field_198 != null) {
         this.field_198.method_279(var1);
      }

      int var3 = field_151 / 5 * 2;
      int var2 = var3 + this.field_139.method_39(1) * 4;
      this.field_138.method_346(var1, 16777215);
      this.field_139.method_29(var1, this.field_143[31] + " " + this.field_376, 0, var2, field_152, 1, 1);
      if (this.field_376 != 1) {
         class_25.method_321(var1, field_152 / 6 * 1, var2 + this.field_139.method_39(1) / 2, 2, 4, 16777215);
      }

      if (this.field_376 < this.field_378 && this.field_380[this.field_376 + 1]) {
         class_25.method_321(var1, field_152 / 6 * 5, var2 + this.field_139.method_39(1) / 2, 3, 4, 16777215);
      }
   }

   // $VF: renamed from: s (javax.microedition.lcdui.Graphics) void
   private void method_159(Graphics var1) {
      this.method_108(var1, this.field_148);
      if (this.field_198 != null) {
         this.field_198.method_279(var1);
      }

      if (this.field_174 != null) {
         this.field_174.a(var1);
      }
   }

   // $VF: renamed from: t (javax.microedition.lcdui.Graphics) void
   private void method_160(Graphics var1) {
      this.method_108(var1, this.field_148);
      if (this.field_174 != null) {
         this.field_174.a(var1);
      }
   }

   // $VF: renamed from: u (javax.microedition.lcdui.Graphics) void
   private void method_161(Graphics var1) {
      this.method_108(var1, this.field_148);
      if (this.field_174 != null) {
         this.field_174.a(var1);
      }
   }

   // $VF: renamed from: v (javax.microedition.lcdui.Graphics) void
   private void method_162(Graphics var1) {
      this.method_108(var1, this.field_148);
      if (this.field_198 != null) {
         this.field_198.method_279(var1);
      }

      if (this.field_174 != null) {
         this.field_174.a(var1);
      }
   }

   // $VF: renamed from: w (javax.microedition.lcdui.Graphics) void
   private void method_163(Graphics var1) {
      this.method_108(var1, this.field_148);
      if (this.field_174 != null) {
         this.field_174.a(var1);
      }

      this.field_138.method_346(var1, 16777215);
      if (this.field_401) {
         this.field_139.method_32(var1, this.field_143[64 + this.field_174.a()], 2, this.field_402, field_152 - 4, 1, 1, this.field_139.method_39(1), false);
      }
   }

   // $VF: renamed from: x (javax.microedition.lcdui.Graphics) void
   private void method_164(Graphics var1) {
      this.method_108(var1, this.field_148);
      if (this.field_174 != null) {
         this.field_174.a(var1);
      }
   }

   // $VF: renamed from: y (javax.microedition.lcdui.Graphics) void
   private void method_165(Graphics var1) {
      this.method_108(var1, this.field_148);
      if (this.field_198 != null) {
         this.field_198.method_279(var1);
      }

      if (this.field_174 != null) {
         this.field_174.a(var1);
      }
   }

   // $VF: renamed from: z (javax.microedition.lcdui.Graphics) void
   private void method_166(Graphics var1) {
      if (field_170 != 3) {
         if (this.field_147[0] >= 0) {
            this.field_138.method_342(var1, this.field_142[this.field_147[0]], 2, field_151 - 2, 36);
         }

         if (this.field_147[1] >= 0) {
            this.field_138.method_342(var1, this.field_142[this.field_147[1]], field_152 - 2, field_151 - 2, 40);
         }
      }
   }

   // $VF: renamed from: e (int, int) int
   int method_167(int var1, int var2) {
      return this.field_272 + (var1 - 1) * 18 - var2 * 18;
   }

   // $VF: renamed from: f (int, int) int
   int method_168(int var1, int var2) {
      return var2 * 9 + var1 * 9;
   }

   // $VF: renamed from: g (int, int) int
   int method_169(int var1, int var2) {
      return (var2 - (var1 - this.field_272) / 2) / 18;
   }

   // $VF: renamed from: h (int, int) int
   int method_170(int var1, int var2) {
      return (var2 + (var1 - this.field_272) / 2) / 18;
   }

   // $VF: renamed from: i (int, int) void
   void method_171(int var1, int var2) {
      this.field_273 = var1;
      this.field_274 = var2;
   }

   // $VF: renamed from: D () boolean
   boolean method_172() {
      boolean var1 = this.field_244.field_78.field_14 == 0
         || this.field_244.field_78.field_14 == 8
         || this.field_244.field_78.field_14 == 9
         || this.field_244.field_78.field_14 == 10
         || this.field_244.field_78.field_14 == 11;
      return var1
         | (
            class_2.field_1[this.field_244.field_78.field_18][this.field_244.field_78.field_14][2] != 0
               && class_2.field_1[this.field_244.field_78.field_18][this.field_244.field_78.field_14][2] < this.field_244.field_78.field_12
         );
   }

   // $VF: renamed from: j (int, int) int
   int method_173(int var1, int var2) {
      int var3 = var1 * this.field_223 >> 6;
      return this.method_141(var3, 1, 65536 / var2 + 1);
   }

   // $VF: renamed from: c (java.lang.String) void
   private void method_174(String var1) {
      this.field_148 = var1;
   }

   // $VF: renamed from: E () void
   public void method_175() {
      if (this.field_158 == -1) {
         this.field_158 = 0;
      }

      this.method_174(this.field_144[this.field_158 == -1 ? 0 : this.field_158][1]);
      field_197 = null;
      field_197 = this.field_138.method_338();
      byte var1 = 3;
      int var2 = field_151;
      int var3 = field_151 - var2 / 2 - 10;

      while (true) {
         this.field_174.method_291(field_197, field_152 / 2, var3 + 0, var1, 0, 0, 2, this.field_400, (byte)2, true, false);
         if (var1 == 1 || this.field_174.method_294() <= var2) {
            this.field_174.a(this.field_158);
            this.field_160 = this.field_158;
            this.field_159 = this.field_158;
            return;
         }

         var1 = (byte)(var1 - 2);
      }
   }

   // $VF: renamed from: ae () void
   private void method_176() {
      this.method_174(this.field_211);
      String[] var1 = new String[]{this.field_144[this.field_158][4], this.field_144[this.field_158][5]};
      this.field_174.method_291(var1, field_152 / 2, field_151 / 2 + 0, 2, 0, 0, 2, this.field_400, (byte)2, true, false);
      this.field_174.method_293(field_151 - this.field_142[0].getHeight() - this.field_174.method_294() / 2 + 0);
      if (this.field_198 == null) {
         this.field_198 = new class_20(this.field_138, this.field_139, (byte)1);
      }

      int var2 = 0;
      int var3 = 0;
      var2 = field_151 - this.field_142[0].getHeight() - 10 - this.field_174.method_294() + -23;
      var3 = field_151 - this.field_142[0].getHeight() - 10 - this.field_174.method_294() - var2 / 2;
      this.field_198.method_282(this.field_210, field_152 / 2, var3, field_152 * 88 / 100, var2, 1, 2, true);
      if (this.field_198.method_283() < 4) {
         var2 = this.field_198.field_438.getHeight() + this.field_198.field_439.getHeight() + 4 * (this.field_139.method_39(1) + 2);
         var3 = field_151 - this.field_142[0].getHeight() - 10 - this.field_174.method_294() - var2 / 2 + 2;
         this.field_198.method_282(this.field_210, field_152 / 2, var3, field_152 * 88 / 100, var2, 1, 2, true);
      }

      if (this.field_212 == -1) {
         this.field_174.a((byte)0);
      } else {
         this.field_174.a(this.field_212);
      }

      this.field_212 = -1;
   }

   // $VF: renamed from: af () void
   private void method_177() {
      String var3 = "";
      String var4 = "   ";
      String var5 = " / ";
      String var6 = "\n\n";
      this.method_174(this.field_143[9]);
      int var2 = field_151 / 5 * 3;
      int var1 = var2 / 2 + this.field_139.method_39(1) * 3;
      var3 = var3 + this.field_143[112];
      var3 = var3 + var6;
      var3 = var3 + this.field_143[113];
      var3 = var3 + var6;
      var3 = var3 + this.field_143[121];
      var3 = var3 + var6;
      var3 = var3 + this.field_143[114];
      var3 = var3 + var6;
      var3 = var3 + this.field_143[124];
      var3 = var3 + var6;
      var3 = var3 + this.field_143[115];
      var3 = var3 + var6;
      var3 = var3 + this.field_143[122];
      var3 = var3 + var6;
      var3 = var3 + this.field_143[116];
      var3 = var3 + var6;
      var3 = var3 + this.field_143[117];
      var3 = var3 + var6;
      var3 = var3 + this.field_143[118];
      var3 = var3 + var6;
      var3 = var3 + this.field_143[119];
      this.field_198.method_282(var3, field_152 / 2, var1, field_152 * 90 / 100, var2, 1, 2, false);
   }

   // $VF: renamed from: ag () void
   private void method_178() {
      this.method_174(this.field_143[14]);
      field_171 = 0;
      String[] var1 = new String[]{this.field_144[this.field_158][5], this.field_144[this.field_158][4]};
      short var2 = 360;
      short var3 = 384;
      this.field_174.method_291(var1, 180, 192, 2, 0, 0, 2, this.field_400, (byte)2, true, false);
      this.field_174.method_293(384 - this.field_142[0].getHeight() - this.field_174.method_294() / 2 + 0);
      int var4 = 384 - this.field_142[0].getHeight() - 10 - this.field_174.method_294();
      int var5 = 384 - this.field_142[0].getHeight() - 10 - this.field_174.method_294() - var4 / 2;
      this.field_198.method_282(this.field_143[14], 180, var5, 316, var4, 1, 2, true);
      if (this.field_198.method_283() < 3) {
         var4 = this.field_198.field_438.getHeight() + this.field_198.field_439.getHeight() + 3 * (this.field_139.method_39(1) + 2);
         var5 = 384 - this.field_142[0].getHeight() - 10 - this.field_174.method_294() - var4 / 2;
         this.field_198.method_282(this.field_143[14], 180, var5, 316, var4, 1, 2, true);
      }
   }

   // $VF: renamed from: ah () void
   private void method_179() {
      this.method_174("");
      field_197 = null;
      boolean var1 = false;
      int var7 = 4;
      if (field_216 != null) {
         var7++;
      }

      field_197 = new String[var7];
      byte var2 = 0;
      if (field_216 != null) {
         field_197[var2] = this.field_143[49];
         field_179 = var2++;
      }

      field_197[var2] = this.field_143[46];
      field_175 = var2++;
      if (field_220) {
         field_197[var2] = this.field_143[47];
         field_176 = var2++;
      }

      field_197[var2] = this.field_143[44];
      field_177 = var2++;
      field_197[var2] = this.field_143[45];
      field_178 = var2++;
      field_197[var2] = this.field_143[48];
      field_180 = var2++;
      int var3 = 0;
      if (this.field_394 != null) {
         var3 = this.field_394.getHeight();
      }

      byte var4 = 5;
      int var5 = field_151 - this.field_142[0].getHeight() - -23 - var3;
      int var6 = field_151 - this.field_142[0].getHeight() - var5 / 2;

      while (true) {
         this.field_174.method_291(field_197, field_152 / 2, var6 + 0, var4, 0, 0, 2, this.field_400, (byte)2, true, false);
         if (var4 == 3 || this.field_174.method_294() <= var5) {
            return;
         }

         var4 = (byte)(var4 - 2);
      }
   }

   // $VF: renamed from: ai () void
   private void method_180() {
      this.method_174(this.field_143[12]);
      field_197 = null;
      byte var1 = 0;
      var1 = 4;
      field_197 = new String[var1];
      byte var2 = 0;
      field_197[var2] = this.field_143[43];
      field_193 = var2++;
      field_197[var2] = this.field_143[36] + " " + (this.field_145 > 0 ? this.field_143[34] : this.field_143[35]);
      field_194 = var2++;
      field_197[var2] = this.field_143[54];
      field_195 = var2++;
      field_197[var2] = this.field_143[55];
      field_196 = var2++;
      byte var3 = 3;
      int var4 = field_151 - this.field_142[0].getHeight() - -23;
      int var5 = field_151 - this.field_142[0].getHeight() - var4 / 2;

      while (true) {
         this.field_174.method_291(field_197, field_152 / 2, var5 + 0, var3, 0, 0, 2, this.field_400, (byte)2, true, false);
         if (var3 == 3 || this.field_174.method_294() <= var4) {
            return;
         }

         var3 = (byte)(var3 - 2);
      }
   }

   // $VF: renamed from: aj () void
   private void method_181() {
      this.method_174(this.field_143[20]);
      field_197 = null;
      byte var1 = 0;
      var1 = 3;
      field_197 = new String[var1];
      byte var2 = 0;
      field_197[var2] = this.field_143[52];
      field_183 = var2++;
      field_197[var2] = this.field_143[53];
      field_184 = var2++;
      field_197[var2] = this.field_143[51];
      field_182 = var2++;
      byte var3 = 3;
      byte var4 = 2;
      int var5 = 4;
      int var6 = field_151 - this.field_142[0].getHeight() - this.field_139.method_39(0) - var5;
      var5 = field_151 - this.field_142[0].getHeight() - var6 / 2;

      while (true) {
         this.field_174.method_291(field_197, field_152 / 2, var5 + 0, var3, 0, 0, 2, this.field_400, (byte)2, true, false);
         if (var3 == 3 || this.field_174.method_294() <= var6) {
            int var8 = var5 + this.field_174.method_294() / 2 + 5;
            int var7 = field_151 - this.field_142[0].getHeight() - var8;
            if (this.field_139.method_40(this.field_143[64], field_152 - 4, 1) * this.field_139.method_39(1) < var7
               && this.field_139.method_40(this.field_143[66], field_152 - 4, 1) * this.field_139.method_39(1) < var7
               && this.field_139.method_40(this.field_143[65], field_152 - 4, 1) * this.field_139.method_39(1) < var7) {
               this.field_401 = true;
               this.field_402 = var8;
            } else {
               this.field_401 = false;
            }

            return;
         }

         var3 = (byte)(var3 - 2);
      }
   }

   // $VF: renamed from: ak () void
   private void method_182() {
      this.method_174(this.field_143[26]);
      int var2 = field_151 / 5 * 2;
      int var1 = var2 / 2 + this.field_139.method_39(1) * 3;
      int var3 = this.field_376 - 1;
      this.field_198.method_282(this.field_143[100 + var3], field_152 / 2, var1, field_152 * 90 / 100, var2, 1, 2, false);
   }

   // $VF: renamed from: al () void
   private void method_183() {
      for (int var1 = 0; var1 < this.field_380.length; var1++) {
         this.field_380[var1] = false;
      }

      this.field_380[1] = true;
   }

   // $VF: renamed from: am () void
   private void method_184() {
      this.method_174(this.field_143[28]);
      String[] var3 = new String[]{this.field_144[this.field_158][4], this.field_144[this.field_158][5]};
      this.field_174.method_291(var3, field_152 / 2, field_151 / 2 + 0, 2, 0, 0, 2, this.field_400, (byte)2, true, false);
      this.field_174.method_293(field_151 - this.field_142[0].getHeight() - this.field_174.method_294() / 2 + 0);
      int var2 = field_151 / 5 * 2;
      int var1 = var2 / 2 + this.field_139.method_39(1) * 3;
      int var4 = this.field_376 - 1;
      String var5 = this.field_143[100 + var4] + "\n\n" + this.field_143[70];
      this.field_198.method_282(var5, field_152 / 2, var1, field_152 * 90 / 100, var2, 1, 2, true);
   }

   // $VF: renamed from: an () void
   private void method_185() {
      this.method_174(this.field_143[27]);
      String[] var1 = new String[]{this.field_143[24]};
      this.field_174.method_291(var1, field_152 / 2, field_151 / 2 + 0, 1, 0, 0, 2, this.field_400, (byte)2, true, false);
      this.field_174.method_293((field_151 - this.field_142[0].getHeight() - this.field_174.method_294() / 2 + 0) / 2);
   }

   // $VF: renamed from: ao () void
   private void method_186() {
      this.method_174(this.field_143[29]);
      String[] var1 = new String[]{this.field_143[24]};
      this.field_174.method_291(var1, field_152 / 2, field_151 / 2 + 0, 1, 0, 0, 2, this.field_400, (byte)2, true, false);
      this.field_174.method_293((field_151 - this.field_142[0].getHeight() - this.field_174.method_294() / 2 + 0) / 2);
   }

   // $VF: renamed from: ap () void
   private void method_187() {
      this.method_174(this.field_143[30]);
      String var1 = "";
      int var2 = field_151 / 5 * 2;
      int var3 = var2 / 2 + this.field_139.method_39(1) * 3;
      switch (this.field_347) {
         case 1:
            var1 = var1 + this.field_143[94] + ": " + this.field_296;
            var1 = var1 + "\n";
            var1 = var1 + this.field_143[96] + ": " + this.field_297;
            var1 = var1 + "\n";
            var1 = var1 + this.field_143[95] + ": " + this.field_298;
            var1 = var1 + "\n";
            var1 = var1 + this.field_143[97] + ": " + this.field_299;
            var1 = var1 + "\n";
            var1 = var1 + this.field_143[98] + ": " + this.field_354;
            var1 = var1 + "\n";
            var1 = var1 + this.field_143[99] + ": " + this.field_355;
            break;
         case 2:
            var1 = var1 + this.field_143[94] + ": " + this.field_296;
            var1 = var1 + "\n";
            var1 = var1 + this.field_143[96] + ": " + this.field_297;
            var1 = var1 + "\n";
            var1 = var1 + this.field_143[95] + ": " + this.field_298;
            var1 = var1 + "\n";
            var1 = var1 + this.field_143[97] + ": " + this.field_299;
            var1 = var1 + "\n";
            var1 = var1 + this.field_143[98] + ": " + this.field_350;
      }

      this.field_198.method_282(var1, field_152 / 2, var3, field_152 * 90 / 100, var2, 1, 2, true);
      String[] var4 = new String[]{this.field_143[24]};
      this.field_174.method_291(var4, field_152 / 2, field_151 / 2 + 0, 1, 0, 0, 2, this.field_400, (byte)2, true, false);
      this.field_174.method_293(field_151 - this.field_142[0].getHeight() - this.field_174.method_294() / 2 + 0);
   }

   // $VF: renamed from: aq () void
   private void method_188() {
      this.method_174(this.field_143[21]);
      field_197 = null;
      byte var1 = 0;
      var1 = 3;
      field_197 = new String[var1];
      byte var2 = 0;
      field_197[var2] = this.field_143[22];
      field_185 = var2++;
      field_197[var2] = this.field_143[23];
      field_186 = var2++;
      field_197[var2] = this.field_143[25];
      field_187 = var2++;
      byte var3 = 3;
      int var4 = field_151 - this.field_142[0].getHeight() - -23;
      int var5 = field_151 - this.field_142[0].getHeight() - var4 / 2;

      while (true) {
         this.field_174.method_291(field_197, field_152 / 2, var5 + 0, var3, 0, 0, 2, this.field_400, (byte)2, true, false);
         if (var3 == 3 || this.field_174.method_294() <= var4) {
            return;
         }

         var3 = (byte)(var3 - 2);
      }
   }

   // $VF: renamed from: ar () void
   private void method_189() {
      this.method_174(this.field_143[44]);
      int var1 = 4;
      field_197 = new String[++var1];
      byte var2 = 0;
      field_197[var2] = this.field_143[36] + " " + (this.field_145 > 0 ? this.field_143[34] : this.field_143[35]);
      field_188 = var2++;
      field_197[var2] = this.field_143[38];
      field_189 = var2++;
      field_197[var2] = this.field_143[40];
      field_190 = var2++;
      field_197[var2] = this.field_143[41];
      field_191 = var2++;
      field_197[var2] = this.field_143[37];
      field_192 = var2;
      byte var3 = 5;
      int var4 = field_151 - this.field_142[0].getHeight() + -23;
      int var5 = field_151 - this.field_142[0].getHeight() - var4 / 2;

      while (true) {
         this.field_174.method_291(field_197, field_152 / 2, var5 + 0, var3, 0, 0, 2, this.field_400, (byte)2, true, true);
         if (var3 == 3 || this.field_174.method_294() <= var4) {
            this.field_208 = false;
            return;
         }

         var3 = (byte)(var3 - 2);
      }
   }

   // $VF: renamed from: a (byte, byte) void
   private void method_190(byte var1, byte var2) {
      this.field_147[0] = var1;
      this.field_147[1] = var2;
   }

   // $VF: renamed from: as () void
   private void method_191() {
      if (this.field_198 != null) {
         this.field_198.method_277();
         this.field_198.method_280(this.field_168);
      }

      if (this.method_67(512)) {
         field_172 = 4;
         field_173 = 7;
         this.method_60((byte)3, false);
      }
   }

   // $VF: renamed from: at () void
   private void method_192() {
      if (this.field_198 != null) {
         this.field_198.method_277();
         this.field_198.method_280(this.field_168);
      }

      if (this.method_67(512)) {
         field_172 = 4;
         field_173 = 12;
         this.method_60((byte)3, false);
      }
   }

   // $VF: renamed from: au () void
   private void method_193() {
      boolean var1 = false;
      if (this.field_403) {
         this.field_199++;
         if (this.field_199 >= 50) {
            this.field_199 = 0;
            var1 = true;
         }
      } else {
         this.field_199++;
         if (this.field_199 >= 50) {
            this.field_199 = 0;
            this.field_403 = true;
         }
      }

      if (this.field_403) {
         this.field_141 = class_25.method_318("/gl");
      }

      if (var1) {
         this.field_141 = null;
         this.field_403 = false;
         System.gc();
         this.method_268();
         field_172 = 1;
         field_173 = 0;
         this.method_60((byte)3, false);
      }
   }

   // $VF: renamed from: av () void
   private void method_194() {
      if (this.field_174 != null) {
         this.field_174.e();
         this.field_174.b(this.field_168);
      }

      if (this.field_174.b()) {
         label42:
         switch (this.field_174.a()) {
            case 0:
               switch (field_173) {
                  case 0:
                  case 1:
                     field_172 = 4;
                     field_173 = 1;
                     this.method_60((byte)3, true);
                     if (this.field_145 == 0) {
                        this.field_145 = 1;
                     }

                     this.method_271((byte)1);
                     this.field_140.method_13(this.field_146[5]);
                     break label42;
                  case 4:
                     this.method_61();
                     break label42;
                  case 6:
                     switch (this.field_209) {
                        case 2:
                           this.method_273((byte)2, true);
                           break;
                        case 3:
                           this.method_273((byte)3, true);
                     }

                     this.field_209 = -1;
                     field_172 = field_173;
                     field_173 = field_170;
                     this.method_60((byte)3, false);
                     break label42;
                  case 18:
                     if (!this.field_405) {
                        field_172 = 4;
                        field_173 = 18;
                        this.field_156 = false;
                        this.field_155 = false;
                        this.method_60((byte)3, true);
                     } else {
                        this.method_61();
                     }
                  default:
                     break label42;
               }
            case 1:
               switch (field_173) {
                  case 0:
                  case 1:
                     field_172 = 4;
                     field_173 = 1;
                     this.method_60((byte)3, true);
                     this.field_145 = 0;
                     this.method_271((byte)1);
                     break;
                  default:
                     field_172 = field_173;
                     field_173 = field_170;
                     this.field_209 = -1;
                     this.method_60((byte)3, false);
               }
         }
      }

      if (this.method_67(512)) {
         switch (field_173) {
            case 0:
            case 1:
               break;
            default:
               field_172 = field_173;
               field_173 = field_170;
               this.field_209 = -1;
               this.method_60((byte)3, false);
         }
      }
   }

   // $VF: renamed from: aw () void
   private void method_195() {
      switch (field_171) {
         case 0:
            if (this.field_221) {
               if (this.field_174 != null) {
                  this.field_174.e();
                  this.field_174.b(this.field_168);
               }

               if (this.field_174.b()) {
                  this.method_270();
                  if (this.field_174.a() == field_180) {
                     field_172 = 7;
                     field_173 = 4;
                     this.method_60((byte)3, false);
                  } else if (this.field_174.a() == field_179) {
                     field_172 = 8;
                     field_173 = 4;
                     this.method_60((byte)3, false);
                  } else if (this.field_174.a() == field_178) {
                     field_172 = 12;
                     field_173 = 4;
                     this.method_60((byte)3, false);
                  } else if (this.field_174.a() == field_177) {
                     field_172 = 6;
                     field_173 = 4;
                     this.method_60((byte)3, false);
                  } else if (this.field_174.a() == field_176) {
                     field_172 = 13;
                     field_173 = 4;
                     this.method_60((byte)3, false);
                  } else if (this.field_174.a() == field_175) {
                     field_172 = 16;
                     field_173 = 4;
                     this.method_60((byte)3, false);
                  }
               }
            } else {
               if (this.method_67(8)) {
                  this.field_219--;
                  if (this.field_219 == field_176 && !field_220) {
                     this.field_219--;
                  } else if (this.field_219 == field_179 && field_216 == null) {
                     this.field_219--;
                  }

                  if (this.field_219 < 0) {
                     this.field_219 = (byte)(this.field_218.length - 1);
                  }
               }

               if (this.method_67(16)) {
                  this.field_219++;
                  if (this.field_219 == field_176 && !field_220) {
                     this.field_219++;
                  } else if (this.field_219 == field_179 && field_216 == null) {
                     this.field_219++;
                  }

                  if (this.field_219 >= this.field_218.length) {
                     this.field_219 = 0;
                  }
               }

               if (this.field_213) {
                  this.field_213 = false;
               }

               if (this.method_67(256) || this.method_67(32)) {
                  this.method_270();
                  if (this.field_219 == field_175) {
                     field_172 = 5;
                     field_173 = 4;
                     this.method_60((byte)3, false);
                  } else if (this.field_219 == field_176) {
                     field_172 = 13;
                     field_173 = 4;
                     this.method_60((byte)3, false);
                  } else if (this.field_219 == field_177) {
                     field_172 = 6;
                     field_173 = 4;
                     this.method_60((byte)3, false);
                  } else if (this.field_219 == field_178) {
                     field_172 = 12;
                     field_173 = 4;
                     this.method_60((byte)3, false);
                  } else if (this.field_219 == field_179) {
                     field_172 = 8;
                     field_173 = 4;
                     this.method_60((byte)3, false);
                  } else if (this.field_219 == field_180) {
                     field_172 = 7;
                     field_173 = 4;
                     this.method_60((byte)3, false);
                  }
               }
            }

            if (this.method_67(512)) {
               this.method_270();
               this.field_210 = this.field_143[0];
               this.field_211 = this.field_143[4];
               field_172 = 10;
               field_173 = 4;
               this.method_60((byte)3, false);
            }
            break;
         case 1:
            this.field_198.method_277();
            this.field_198.method_280(this.field_168);
            if (this.method_67(256) || this.method_67(32)) {
               field_171 = 0;
               this.method_190((byte)0, (byte)4);
            }
      }
   }

   // $VF: renamed from: ax () void
   private void method_196() {
      if (this.field_174 != null) {
         this.field_174.e();
         this.field_174.b(this.field_168);
      }

      if (this.field_174.b()) {
         this.field_394 = null;
         if (this.field_174.a() == field_182) {
            field_172 = 17;
            field_173 = 16;
            this.field_347 = 0;
            this.method_183();
            this.method_272((byte)3);
            this.method_60((byte)3, false);
         } else if (this.field_174.a() == field_183) {
            field_172 = 5;
            field_173 = 16;
            this.field_347 = 1;
            this.method_217();
            this.method_272((byte)2);
            this.method_60((byte)3, false);
         } else if (this.field_174.a() == field_184) {
            field_172 = 5;
            field_173 = 16;
            this.field_347 = 2;
            this.method_217();
            this.method_60((byte)3, false);
         }
      }

      if (this.method_67(512)) {
         field_172 = 4;
         field_173 = 16;
         this.method_60((byte)3, false);
      }
   }

   // $VF: renamed from: ay () void
   private void method_197() {
      int var2 = field_151 / 5 * 2;
      int var1 = var2 / 2 + this.field_139.method_39(1) * 3;
      this.field_198.method_277();
      this.field_198.method_280(this.field_168);
      if (this.method_67(2) || this.method_67(32768)) {
         this.field_376--;
         if (this.field_376 < 1) {
            this.field_376 = 1;
         }

         int var4 = this.field_376 - 1;
         this.field_198.method_282(this.field_143[100 + var4], field_152 / 2, var1, field_152 * 90 / 100, var2, 1, 2, false);
      } else if (this.method_67(4) || this.method_67(8192)) {
         this.field_376++;
         if (this.field_376 <= this.field_378 && !this.field_380[this.field_376]) {
            this.field_376--;
         }

         if (this.field_376 > this.field_378) {
            this.field_376 = this.field_378;
         }

         int var3 = this.field_376 - 1;
         this.field_198.method_282(this.field_143[100 + var3], field_152 / 2, var1, field_152 * 90 / 100, var2, 1, 2, false);
      } else if (this.method_67(256) || this.method_67(32) || this.method_67(16384)) {
         this.method_217();
         field_172 = 5;
         field_173 = 17;
         this.field_347 = 0;
         this.method_60((byte)3, false);
      } else if (this.method_67(512)) {
         field_172 = 16;
         field_173 = 17;
         this.method_60((byte)3, false);
      }
   }

   // $VF: renamed from: az () void
   private void method_198() {
      if (this.field_174 != null) {
         this.field_174.e();
         this.field_174.b(this.field_168);
      }

      if (this.field_198 != null) {
         this.field_198.method_277();
         this.field_198.method_280(this.field_168);
      }

      if (this.field_174.b()) {
         switch (this.field_174.a()) {
            case 0:
               field_172 = 5;
               field_173 = 20;
               this.field_226 = 384;
               this.method_60((byte)3, false);
               break;
            case 1:
               field_172 = 4;
               field_173 = 20;
               this.method_106();
               this.method_60((byte)3, false);
         }
      }
   }

   // $VF: renamed from: aA () void
   private void method_199() {
      if (this.field_174 != null) {
         this.field_174.e();
         this.field_174.b(this.field_168);
      }

      if (this.field_174.b()) {
         switch (this.field_174.a()) {
            case 0:
               field_172 = 17;
               field_173 = 19;
               this.method_203();
               this.method_271((byte)3);
               this.method_60((byte)3, false);
         }
      }
   }

   // $VF: renamed from: aB () void
   private void method_200() {
      if (this.field_174 != null) {
         this.field_174.e();
         this.field_174.b(this.field_168);
      }

      if (this.field_198 != null) {
         this.field_198.method_277();
         this.field_198.method_280(this.field_168);
      }

      if (this.field_174.b()) {
         switch (this.field_174.a()) {
            case 0:
               field_172 = 4;
               field_173 = 21;
               this.method_106();
               this.method_60((byte)3, false);
         }
      }
   }

   // $VF: renamed from: aC () void
   private void method_201() {
      if (this.field_174 != null) {
         this.field_174.e();
         this.field_174.b(this.field_168);
      }

      if (this.field_198 != null) {
         this.field_198.method_277();
         this.field_198.method_280(this.field_168);
      }

      if (this.field_174.b()) {
         switch (this.field_174.a()) {
            case 0:
               field_172 = 4;
               field_173 = 22;
               this.method_106();
               this.field_354 = 0;
               if (this.field_404) {
                  this.method_273((byte)2, true);
                  this.field_404 = false;
               }

               this.method_60((byte)3, false);
         }
      }
   }

   // $VF: renamed from: aD () void
   private void method_202() {
      if (this.field_174 != null) {
         this.field_174.e();
         this.field_174.b(this.field_168);
      }

      if (this.field_174.b()) {
         if (this.field_174.a() == field_193) {
            if (this.field_208) {
               this.method_271((byte)1);
               this.field_208 = false;
            }

            field_170 = 5;
            field_173 = 18;
            this.method_65();
         } else if (this.field_174.a() == field_194) {
            this.field_145++;
            this.method_207(field_194);
         } else if (this.field_174.a() == field_195) {
            this.field_210 = this.field_143[3];
            this.field_211 = this.field_143[4];
            field_172 = 10;
            field_173 = 18;
            this.field_212 = 1;
            this.field_405 = false;
            this.method_60((byte)3, false);
         } else if (this.field_174.a() == field_196) {
            this.field_210 = this.field_143[0];
            this.field_211 = this.field_143[4];
            field_172 = 10;
            field_173 = 18;
            this.field_212 = 1;
            this.field_405 = true;
            this.method_60((byte)3, false);
         }
      }

      if (this.method_67(2) || this.method_67(32768)) {
         if (this.field_174.a() == field_194) {
            this.field_145--;
            this.method_207(field_194);
         }
      } else if ((this.method_67(4) || this.method_67(8192)) && this.field_174.a() == field_194) {
         this.field_145++;
         this.method_207(field_194);
      }

      if (this.method_67(512)) {
         if (this.field_208) {
            this.method_271((byte)1);
            this.field_208 = false;
         }

         field_170 = 5;
         field_173 = 18;
         this.method_65();
      }
   }

   // $VF: renamed from: aE () void
   private void method_203() {
      if (this.field_376 == this.field_378) {
         field_172 = 21;
         field_173 = 19;
         this.method_60((byte)3, false);
      } else {
         this.field_376++;
         if (this.field_376 > this.field_378) {
            this.field_376 = this.field_378;
         }

         if (this.field_376 <= this.field_378) {
            this.field_380[this.field_376] = true;
         }
      }
   }

   // $VF: renamed from: aF () void
   private void method_204() {
      if (this.field_174 != null) {
         this.field_174.e();
         this.field_174.b(this.field_168);
      }

      if (this.field_174.b()) {
         if (this.field_174.a() == field_188) {
            this.field_145++;
            this.method_207(field_188);
         } else if (this.field_174.a() == field_190) {
            this.field_210 = this.field_143[1];
            this.field_211 = this.field_143[7];
            field_172 = 10;
            field_173 = 6;
            this.field_212 = 1;
            this.field_209 = 2;
            this.method_60((byte)3, false);
         } else if (this.field_174.a() == field_191) {
            this.field_210 = this.field_143[1];
            this.field_211 = this.field_143[8];
            field_172 = 10;
            field_173 = 6;
            this.field_212 = 1;
            this.field_209 = 3;
            this.method_60((byte)3, false);
         } else if (this.field_174.a() == field_192) {
            if (this.field_208) {
               this.method_271((byte)1);
               this.field_208 = false;
            }

            field_172 = 4;
            field_173 = 6;
            this.method_60((byte)3, false);
         } else if (this.field_174.a() == field_189) {
            field_172 = 1;
            field_173 = field_170;
            this.method_60((byte)3, false);
         }
      }

      if (this.method_67(2) || this.method_67(32768)) {
         if (this.field_174.a() == field_188) {
            this.field_145--;
            this.method_207(field_188);
         }
      } else if ((this.method_67(4) || this.method_67(8192)) && this.field_174.a() == field_188) {
         this.field_145++;
         this.method_207(field_188);
      }

      if (this.method_67(512)) {
         if (this.field_208) {
            this.method_271((byte)1);
            this.field_208 = false;
         }

         field_172 = 4;
         field_173 = 6;
         this.method_60((byte)3, false);
      }
   }

   // $VF: renamed from: aG () void
   private void method_205() {
      switch (field_171) {
         case 0:
            if (this.field_174 != null) {
               this.field_174.e();
               this.field_174.b(this.field_168);
            }

            if (this.field_174.b()) {
               switch (this.field_174.a()) {
                  case 0:
                     field_172 = 4;
                     field_173 = 8;
                     this.method_60((byte)3, false);
                     break;
                  case 1:
                     boolean var1 = class_25.method_322(field_216);
                     short var2 = 360;
                     short var3 = 384;
                     if (var1) {
                        this.method_61();
                     } else {
                        this.field_198.method_282(this.field_143[63], 180, 192, 324, 119, 1, 2, false);
                     }

                     this.method_190((byte)-1, (byte)2);
                     field_171 = 1;
               }
            }
         default:
            if (this.method_67(512)) {
               field_172 = 4;
               field_173 = 8;
               this.method_60((byte)3, false);
               this.field_167 = 0;
               this.field_168 = 0;
            }
      }
   }

   // $VF: renamed from: aH () void
   private void method_206() {
      if (this.field_174 != null) {
         this.field_174.e();
         this.field_174.b(this.field_168);
         if (this.field_174.a() != this.field_160) {
            this.field_149 = 0;
            this.method_174(this.field_144[this.field_174.a()][1]);
            this.field_158 = this.field_174.a();
         }

         this.field_160 = this.field_174.a();
      }

      if (this.field_174.b()) {
         this.field_158 = this.field_174.a();
         this.method_271((byte)0);
         this.field_143 = new String[129];
         String var1 = "";
         if (this.field_158 == 0) {
            var1 = "texten";
         } else if (this.field_158 == 1) {
            var1 = "textes";
         } else if (this.field_158 == 2) {
            var1 = "textptbr";
         }

         this.field_138.method_337(this.field_143, var1, 5, this.field_158, 129, true, -1);
         switch (field_173) {
            case 0:
               this.field_211 = this.field_143[15];
               this.field_210 = this.field_143[2];
               field_172 = 10;
               field_173 = 1;
               this.method_60((byte)3, false);
               break;
            default:
               field_172 = field_173;
               field_173 = field_170;
               this.method_60((byte)3, false);
         }
      }

      if (this.method_67(512)) {
         this.field_158 = this.field_159;
         switch (field_173) {
            case 0:
               this.method_61();
               break;
            default:
               field_172 = field_173;
               field_173 = field_170;
               this.method_60((byte)3, false);
         }
      }
   }

   // $VF: renamed from: a (byte) void
   private void method_207(byte var1) {
      if (this.field_145 > 1) {
         this.field_145 = 0;
      }

      if (this.field_145 < 0) {
         this.field_145 = 1;
      }

      this.field_140.method_13(this.field_146[5]);
      this.field_174.method_292(this.field_143[36] + " " + (this.field_145 > 0 ? this.field_143[34] : this.field_143[35]), var1);
      this.field_208 = true;
      if (this.field_145 > 0) {
         this.method_269(1, 1);
      }
   }

   // $VF: renamed from: aI () void
   private void method_208() {
      if (this.field_226 == 138) {
         switch (this.field_227) {
            case 0:
               if (this.field_174 != null) {
                  this.field_174.e();
               }
               break;
            case 1:
               this.field_366 = (byte)(this.method_119() - 1);
               this.method_120();
         }
      }

      this.method_243();
      if ((this.field_226 & 256) != 0) {
         this.method_211();
         this.method_230();
         this.method_219();
         this.method_216();
         this.method_91();
         if (this.field_347 == 0) {
            this.method_209();
            int var1 = this.method_210();
            if (var1 == 1) {
               this.method_270();
               this.method_275(500L);
               field_172 = 19;
               field_173 = 5;
               this.method_60((byte)3, false);
            } else if (var1 == 0) {
               this.method_270();
               this.method_275(500L);
               field_172 = 20;
               field_173 = 5;
               this.method_60((byte)3, false);
            }
         }
      }

      this.field_292 = false;
      this.method_82(this.field_248, false);
   }

   // $VF: renamed from: aJ () void
   private void method_209() {
      if (this.field_347 == 0) {
         if (this.method_74(1)) {
            if (this.field_353 > 0) {
               this.field_406 = System.currentTimeMillis();
               this.field_407 = (int)(this.field_406 / 1000L / 60L);
               this.field_408 = (int)(this.field_406 / 1000L - (long)(this.field_407 * 60));
               this.field_409 = this.field_408 - this.field_409;
               if (this.field_409 == 1) {
                  this.field_381 -= 1000L;
               } else {
                  this.field_409 = this.field_408;
               }
            } else {
               this.field_381 = (long)this.field_377[this.field_376][7];
               this.field_382 = this.field_222;
               this.field_383 = 0L;
            }
         } else if (this.field_353 > 0) {
            this.field_381 = this.field_222 - this.field_382 - this.field_383;
         } else {
            this.field_381 = 0L;
            this.field_382 = this.field_222;
            this.field_383 = 0L;
         }

         if (this.method_74(8)) {
            if (this.field_381 < this.field_388 + (long)(this.field_343 / 2)) {
               this.field_385 = true;
            } else {
               this.field_385 = false;
            }

            if (!this.field_385) {
               this.method_218(this.field_244.field_78, -1);
               this.field_385 = true;
               this.field_388 = this.field_381;
            }
         }

         if (this.method_74(64)) {
            if (this.field_353 > 0) {
               if (this.field_386 && !this.field_387) {
                  if (this.field_149 % 12 == 0 && method_144(100) < 20) {
                     this.field_386 = false;
                     this.field_389 = this.field_381;
                  }
               } else if (this.field_381 < this.field_389 - 2000L) {
                  this.field_387 = true;
                  if (this.field_149 % 3 == 0) {
                     this.field_386 = true;
                  } else {
                     this.field_386 = false;
                  }

                  if (this.field_381 < this.field_389 - 2500L) {
                     this.field_387 = false;
                  }
               }
            } else {
               this.field_389 = this.field_381;
            }
         }

         if (this.field_381 < 0L) {
            this.field_381 = 0L;
         }
      }
   }

   // $VF: renamed from: aK () int
   private int method_210() {
      if (this.method_74(1) && this.field_381 <= 0L) {
         return this.method_74(2) ? 1 : 0;
      } else {
         if (this.method_74(4) && this.field_244.field_78.field_20 < this.field_244.field_78.field_21) {
            this.field_410++;
            if (this.field_410 >= 8) {
               this.field_410 = 0;
               return 0;
            }
         }

         if (this.method_74(16)) {
            if (this.field_390 >= 3) {
               this.field_391 = true;
               this.field_392 = true;
            }

            if (this.field_391 && this.field_350 >= 3) {
               this.field_391 = false;
               this.field_392 = false;
               return 1;
            }

            if (this.field_244.field_83[4] == 0 && !this.field_391) {
               this.field_410++;
               if (this.field_410 >= 8 && this.method_125()) {
                  this.field_410 = 0;
                  return 0;
               }
            }

            this.field_390 = 0;
         }

         if (this.method_74(128) && this.field_350 >= this.field_377[this.field_376][7]) {
            return 1;
         } else {
            if (this.method_74(32) && this.field_244.field_83[4] == 0 && !this.method_73(1)) {
               this.field_410++;
               if (this.field_410 >= 8 && this.method_125()) {
                  this.field_410 = 0;
                  return 0;
               }
            }

            return -1;
         }
      }
   }

   // $VF: renamed from: aL () void
   private void method_211() {
      this.method_214();
      byte var1 = 0;
      if (this.field_347 == 1 && this.field_359 == this.field_358) {
         var1 = this.field_360;
      }

      if (this.field_353 < this.field_357[this.field_359][0] + var1 || this.field_347 != 1) {
         if (this.field_353 < this.field_377[this.field_376][2] || this.field_347 != 0) {
            if (this.field_341 + (long)this.field_343 - (long)this.field_349 < this.field_222) {
               int var4 = 0;
               byte var5 = 0;

               for (int var2 = 0; var2 < this.field_262; var2++) {
                  for (int var3 = 0; var3 < this.field_263; var3++) {
                     int var6 = this.method_167(var2, var3) - this.field_273;
                     int var7 = this.method_168(var2, var3) - this.field_274;
                     if (!this.method_139(var6, var7, 36, 18, 0, 0, field_152, field_151) && (this.field_254[var2][var3] & 240) == 0) {
                        field_342[var4][0] = var2;
                        field_342[var4][1] = var3;
                        var4++;
                     }
                  }
               }

               for (int var10 = 0;
                  var10 < this.field_352
                     && this.field_384 < 12
                     && (this.field_353 < this.field_357[this.field_359][0] + var1 || this.field_347 != 1)
                     && (this.field_353 < this.field_377[this.field_376][2] || this.field_347 != 0);
                  var10++
               ) {
                  short var8;
                  do {
                     var8 = (short)method_144(var4);
                     if (!this.method_212(var8)) {
                        this.field_348[var10] = var8;
                        break;
                     }
                  } while (++var5 < this.field_237);

                  if (var5 >= this.field_237) {
                     break;
                  }

                  byte var9;
                  if ((this.field_357[this.field_359][5] != 0 || this.field_347 != 1) && (this.field_377[this.field_376][1] != 0 || this.field_347 != 0)) {
                     if ((this.field_357[this.field_359][5] != 2 || this.field_347 != 1) && (this.field_377[this.field_376][1] != 2 || this.field_347 != 0)) {
                        if ((this.field_357[this.field_359][5] != 1 || this.field_347 != 1) && (this.field_377[this.field_376][1] != 1 || this.field_347 != 0)) {
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

                  this.method_86(var9, field_342[var8][0], field_342[var8][1], 7);
                  this.field_353++;
                  this.field_384++;
               }

               this.method_237();
               this.method_213();
               this.field_341 = this.field_222;
            }
         }
      }
   }

   // $VF: renamed from: a (short) boolean
   private boolean method_212(short var1) {
      for (int var2 = 0; var2 < this.field_348.length; var2++) {
         if (var1 == this.field_348[var2]) {
            return true;
         }
      }

      return false;
   }

   // $VF: renamed from: aM () void
   private void method_213() {
      for (int var1 = 0; var1 < this.field_348.length; var1++) {
         this.field_348[var1] = -1;
      }
   }

   // $VF: renamed from: aN () void
   private void method_214() {
      if (this.field_347 == 2) {
         if (this.field_350 < this.field_393[0]) {
            this.field_349 = 0;
            this.field_351 = 1;
            this.field_352 = 1;
         } else if (this.field_350 < this.field_393[1]) {
            this.field_349 = 1;
            this.field_351 = 1;
            this.field_352 = 1;
         } else if (this.field_350 < this.field_393[2]) {
            this.field_349 = 1;
            this.field_351 = 2;
            this.field_352 = 2;
         } else if (this.field_350 < this.field_393[3]) {
            this.field_349 = 2;
            this.field_351 = 2;
            this.field_352 = 2;
         } else {
            this.field_349 = 1;
            this.field_351 = 3;
            this.field_352 = 3;
         }
      } else if (this.field_347 == 1) {
         this.field_349 = this.field_357[this.field_359][3];
         this.field_351 = (byte)this.field_357[this.field_359][2];
         this.field_352 = (byte)this.field_357[this.field_359][1];
      } else if (this.field_347 == 0) {
         this.field_349 = 0;
         this.field_351 = (byte)this.field_377[this.field_376][5];
         this.field_352 = (byte)this.field_377[this.field_376][3];
      }
   }

   // $VF: renamed from: a (boolean) void
   private void method_215(boolean var1) {
      for (int var2 = 3; var2 < 24; var2++) {
         this.field_247[var2].field_9 = false;
         this.field_247[var2].field_31 = true;
      }

      this.field_384 = 0;
      this.field_353 = 0;
      this.field_350 = 0;
      this.field_341 = this.field_222;
      if (var1) {
         this.method_86(1, 8, 11, 3);
      }

      this.method_239(this.field_244.field_84);
   }

   // $VF: renamed from: F () void
   void method_216() {
      if (!this.field_155) {
         for (int var2 = 0; var2 < 24; var2++) {
            if (this.field_247[var2].field_9
               && this.field_247[var2].field_10 < this.field_262
               && this.field_247[var2].field_11 < this.field_263
               && (this.field_279 == this.field_267[this.field_247[var2].field_10][this.field_247[var2].field_11] || this.method_238(this.field_247[var2]))) {
               class_4 var1 = this.field_247[var2];
               byte var4 = var1.field_17;
               if (class_2.field_1[var1.field_18][var1.field_14][2] != 0) {
                  if (var1.field_14 == 2 || var1.field_14 == 14) {
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

                  if (var1.field_24) {
                     if (!this.method_231(var1.field_10, var1.field_11, var4, (this.field_226 & 512) > 0)) {
                        var1.field_15 = var1.field_14;
                        this.method_92(var1, 0);
                        continue;
                     }

                     var1.field_15 = -1;
                  }

                  if (var1.field_12 == class_2.field_1[var1.field_18][var1.field_14][2] && var1.field_12 != var1.field_13) {
                     int var5 = this.method_232(var2, var1.field_10, var1.field_11, var1.field_17, false);
                     if (var5 != -1) {
                        if (var1.field_18 != 11 && var1.field_18 != 8) {
                           this.method_92(var1, 0);
                        } else {
                           this.method_234(var1, var4);
                        }
                     } else if (var1.field_18 != 2
                        && var1.field_18 != 4
                        && var1.field_18 != 6
                        && var1.field_18 != 0
                        && var1.field_18 != 1
                        && var1.field_18 != 3) {
                        this.method_234(var1, var4);
                     } else {
                        var5 = this.method_232(var2, var1.field_10, var1.field_11, var1.field_17, true);
                        if (var5 != -1) {
                           this.method_92(var1, 0);
                        } else {
                           this.method_234(var1, var4);
                        }
                     }

                     if ((var1.field_18 == 0 || var1.field_18 == 1)
                        && this.field_279 != this.field_267[this.field_244.field_78.field_10][this.field_244.field_78.field_11]) {
                        this.method_81();
                     }
                  }
               } else if ((var1.field_22 != -1 || var1.field_23 != -1) && var1.field_14 != 3 && var1.field_15 != -1) {
                  if (this.method_231(var1.field_10, var1.field_11, var4, false)) {
                     this.method_92(var1, var1.field_15);
                     var1.field_15 = -1;
                  }
               } else if ((var1.field_22 != -1 || var1.field_23 != -1) && var1.field_14 == 0) {
                  this.method_92(var1, 1);
               }

               if (var1.field_12 != var1.field_13) {
                  switch (var1.field_18) {
                     case 0:
                     case 1:
                        if (var1.field_14 == 7 && var1.field_12 == 1) {
                        }
                        break;
                     case 2:
                     case 4:
                        if (var1.field_14 == 5
                           && (var1.field_12 == 4 || var1.field_12 == 3)
                           && (
                              this.method_224(var1, this.field_244.field_78.field_10, this.field_244.field_78.field_11)
                                 || var1.field_10 == this.field_244.field_78.field_10 && var1.field_11 == this.field_244.field_78.field_11
                           )) {
                           this.method_221(0, this.field_244.field_78.field_10, this.field_244.field_78.field_11, 18, -16);
                           if (!this.field_392) {
                              this.method_218(this.field_244.field_78, -2);
                           }
                        }
                     case 3:
                     case 5:
                     case 7:
                     default:
                        break;
                     case 6:
                        if (var1.field_14 == 5
                           && (var1.field_12 == 2 || var1.field_12 == 3)
                           && (
                              this.method_224(var1, this.field_244.field_78.field_10, this.field_244.field_78.field_11)
                                 || var1.field_10 == this.field_244.field_78.field_10 && var1.field_11 == this.field_244.field_78.field_11
                           )) {
                           this.method_221(0, this.field_244.field_78.field_10, this.field_244.field_78.field_11, 18, -16);
                           if (!this.field_392) {
                              this.method_218(this.field_244.field_78, -4);
                           }
                        }
                        break;
                     case 8:
                        if ((var1.field_14 == 5 && var1.field_12 == 1 || var1.field_14 == 6 && var1.field_12 == 2)
                           && (
                              this.method_224(var1, this.field_244.field_78.field_10, this.field_244.field_78.field_11)
                                 || var1.field_10 == this.field_244.field_78.field_10 && var1.field_11 == this.field_244.field_78.field_11
                           )) {
                           this.method_221(0, this.field_244.field_78.field_10, this.field_244.field_78.field_11, 18, -16);
                           if (!this.field_392) {
                              this.method_218(this.field_244.field_78, -2);
                           }
                        }
                  }
               }
            }
         }

         if (this.field_226 != 646 && this.field_226 != 647) {
            for (int var8 = 0; var8 < 10; var8++) {
               if (this.field_250[var8].field_121) {
                  switch (this.field_250[var8].field_124) {
                     case 4:
                        int var7 = (int)(this.field_222 - this.field_250[var8].field_123);
                        int var10 = this.field_250[var8].field_125
                           + var7 * (this.field_250[var8].field_127 - this.field_250[var8].field_125) / (this.field_250[var8].field_129 * 5);
                        int var6 = this.field_250[var8].field_126
                           + var7 * (this.field_250[var8].field_128 - this.field_250[var8].field_126) / (this.field_250[var8].field_129 * 5);
                        var7 = 20 - this.method_142(var7) * 20 / this.method_142(this.field_250[var8].field_129 * 5);
                        this.field_250[var8].field_122.field_97 = (short)var10;
                        this.field_250[var8].field_122.field_98 = (short)var6;
                        this.field_250[var8].field_122.field_99 = (short)var7;
                        if (this.field_250[var8].field_122.field_99 <= 0) {
                           this.field_250[var8].field_121 = false;

                           for (int var3 = 1; var3 < 24; var3++) {
                              if (this.field_247[var3].field_9
                                 && !this.field_247[var3].field_31
                                 && this.field_247[var3].field_14 != 3
                                 && this.field_247[var3].field_14 != 4
                                 && Math.abs(this.field_307 - this.field_247[var3].field_10) <= 1
                                 && Math.abs(this.field_308 - this.field_247[var3].field_11) <= 1) {
                                 this.field_297++;
                                 this.method_218(this.field_247[var3], -20);
                                 if (this.field_247[var3].field_18 == 5 && this.field_247[var3].field_20 > 0) {
                                    this.method_92(this.field_247[var3], 14);
                                 }

                                 if (this.field_247[var3].field_18 == 2 || this.field_247[var3].field_18 == 8) {
                                    if (this.field_247[var3].field_20 > 0) {
                                       this.method_92(this.field_247[var3], 14);
                                    } else if (this.field_247[var3].field_20 <= 0) {
                                       this.field_247[var3].field_30 = this.field_222;
                                       this.field_390++;
                                       method_274("unithit: " + var3);
                                    }
                                 }

                                 if (this.field_247[var3].field_18 == 6 && this.field_247[var3].field_20 <= 0) {
                                    this.field_247[var3].field_30 = this.field_222;
                                    this.method_263(this.field_247[var3].field_10, this.field_247[var3].field_11);
                                    this.field_390++;
                                 }

                                 this.method_221(0, this.field_247[var3].field_10, this.field_247[var3].field_11, 18, -16);
                              }
                           }

                           this.field_259 = 100;
                        }
                     default:
                        this.field_250[var8].field_122.field_95 = (byte)this.method_170(
                           this.field_250[var8].field_122.field_97, this.field_250[var8].field_122.field_98
                        );
                        this.field_250[var8].field_122.field_96 = (byte)this.method_169(
                           this.field_250[var8].field_122.field_97, this.field_250[var8].field_122.field_98
                        );
                  }
               }
            }
         }
      }
   }

   // $VF: renamed from: G () void
   void method_217() {
      try {
         this.field_260 = 0;
         this.field_238 = 2;

         for (int var1 = 0; var1 < 4; var1++) {
            this.field_261[var1] = false;
         }

         this.field_226 = 384;
         this.method_150();

         for (int var4 = 0; var4 < 6; var4++) {
            this.field_244.field_90[var4] = false;
         }

         this.field_244.field_90[0] = true;
         this.field_244.field_90[5] = true;
         this.field_244.field_90[1] = true;
         this.field_245.field_82 = 0;
         this.field_245.field_81 = 0;
         this.field_245.field_84 = 1;
         this.field_245.field_83[0] = 0;
         this.field_245.field_83[1] = 25;
         this.field_245.field_83[2] = 0;
         this.field_245.field_83[3] = 0;
         this.field_245.field_83[4] = 0;
         this.field_245.field_83[5] = 1;
         this.field_244 = this.field_245;
         this.field_246 = 1;
         this.field_244.field_88 = 0;
         this.field_293 = 0;
         this.field_294 = 0;
         this.field_295 = 0;
         this.field_296 = 0;
         this.field_297 = 0;
         this.field_298 = 0;
         this.field_299 = 0;
         this.field_300 = 0;
         this.field_301 = 0;
         this.field_302 = 0;
         this.field_360 = 0;
         this.method_75();
      } catch (Exception var3) {
      }
   }

   // $VF: renamed from: c (u, int) void
   void method_218(class_4 var1, int var2) {
      if (var1.field_14 != 3 && var1.field_14 != 4) {
         if (var2 >= 128) {
            var2 -= 256;
         }

         int var3 = var1.field_20 + var2;
         if (var3 > 128) {
            var3 = 125;
         }

         if (var3 < -127) {
            var3 = 0;
         }

         var1.field_20 = (byte)var3;
         if (var1.field_20 < 0) {
            var1.field_20 = 0;
         } else if (var1.field_20 > var1.field_21) {
            var1.field_20 = var1.field_21;
         }

         if (var1.field_20 <= 0) {
            this.method_92(var1, 3);
         }
      }
   }

   // $VF: renamed from: H () void
   void method_219() {
      if (!this.field_155) {
         this.method_226();

         for (int var2 = 0; var2 < 24; var2++) {
            if (this.field_247[var2].field_9
               && this.field_247[var2].field_14 != 3
               && this.field_247[var2].field_14 != 4
               && this.field_247[var2].field_10 < this.field_262
               && this.field_247[var2].field_11 < this.field_263
               && (this.field_279 == this.field_267[this.field_247[var2].field_10][this.field_247[var2].field_11] || this.method_238(this.field_247[var2]))) {
               class_4 var1 = this.field_247[var2];
               if (var1.field_14 != 14) {
                  this.method_223(var1);
               }

               switch (var1.field_18) {
                  case 2:
                  case 4:
                     if (var1.field_14 != 5 && var1.field_14 != 14) {
                        if (var1.field_29) {
                           if (var1.field_14 != 0 && var1.field_10 == var1.field_22 && var1.field_11 == var1.field_23) {
                              var1.field_22 = -1;
                              var1.field_23 = -1;
                              this.method_92(var1, 0);
                           }
                        } else {
                           if ((Math.abs(var1.field_10 - this.field_244.field_78.field_10) > 1 || var1.field_11 != this.field_244.field_78.field_11)
                              && (Math.abs(var1.field_11 - this.field_244.field_78.field_11) > 1 || var1.field_10 != this.field_244.field_78.field_10)) {
                              if (var1.field_14 != 1 || var1.field_22 >= 0 && var1.field_23 >= 0) {
                                 if (var1.field_14 == 1
                                    && (var1.field_22 != this.field_244.field_78.field_10 || var1.field_23 != this.field_244.field_78.field_11)) {
                                    var1.field_22 = this.field_244.field_78.field_10;
                                    var1.field_23 = this.field_244.field_78.field_11;
                                 }
                              } else {
                                 this.method_92(var1, 0);
                                 var1.field_28 = this.field_222;
                              }
                           } else {
                              this.method_92(var1, 0);
                           }

                           if (var1.field_14 == 0) {
                              this.method_222(var1, this.field_244.field_78.field_10, this.field_244.field_78.field_11);
                              if (Math.abs(var1.field_10 - this.field_244.field_78.field_10) <= 1 && var1.field_11 == this.field_244.field_78.field_11
                                 || Math.abs(var1.field_11 - this.field_244.field_78.field_11) <= 1 && var1.field_10 == this.field_244.field_78.field_10) {
                                 var1.field_22 = -1;
                                 var1.field_23 = -1;
                                 if (this.field_222 - var1.field_28 > 1400L) {
                                    this.method_92(var1, 5);
                                    var1.field_28 = this.field_222;
                                 }
                              } else if (this.field_222 - var1.field_28 > 500L) {
                                 int var6 = this.method_233(var2, var1.field_10, var1.field_11, false);
                                 if (var6 != -1 && this.field_247[var6].field_17 == var1.field_17) {
                                    var1.field_17 = (byte)(var1.field_17 + (this.method_143() % 3 + 1) * 2);
                                 }

                                 var1.field_22 = this.field_244.field_78.field_10;
                                 var1.field_23 = this.field_244.field_78.field_11;
                                 this.method_92(var1, 1);
                              }
                           }
                        }
                     }
                  case 3:
                  case 5:
                  case 7:
                  default:
                     break;
                  case 6:
                     if (var1.field_14 == 5 || var1.field_29) {
                        break;
                     }

                     if ((Math.abs(var1.field_10 - this.field_244.field_78.field_10) > 1 || var1.field_11 != this.field_244.field_78.field_11)
                        && (Math.abs(var1.field_11 - this.field_244.field_78.field_11) > 1 || var1.field_10 != this.field_244.field_78.field_10)) {
                        if (var1.field_14 != 1 || var1.field_22 >= 0 && var1.field_23 >= 0) {
                           if (var1.field_14 == 1 && (var1.field_22 != this.field_244.field_78.field_10 || var1.field_23 != this.field_244.field_78.field_11)) {
                              var1.field_22 = this.field_244.field_78.field_10;
                              var1.field_23 = this.field_244.field_78.field_11;
                           }
                        } else {
                           this.method_92(var1, 0);
                           var1.field_28 = this.field_222;
                        }
                     } else {
                        this.method_92(var1, 0);
                     }

                     if (var1.field_14 != 0) {
                        break;
                     }

                     this.method_222(var1, this.field_244.field_78.field_10, this.field_244.field_78.field_11);
                     if (Math.abs(var1.field_10 - this.field_244.field_78.field_10) <= 1 && var1.field_11 == this.field_244.field_78.field_11
                        || Math.abs(var1.field_11 - this.field_244.field_78.field_11) <= 1 && var1.field_10 == this.field_244.field_78.field_10) {
                        var1.field_22 = -1;
                        var1.field_23 = -1;
                        if (this.field_222 - var1.field_28 > 1400L) {
                           this.method_92(var1, 5);
                           var1.field_28 = this.field_222;
                        }
                     } else if (this.field_222 - var1.field_28 > 500L) {
                        int var5 = this.method_233(var2, var1.field_10, var1.field_11, false);
                        if (var5 != -1 && this.field_247[var5].field_17 == var1.field_17) {
                           var1.field_17 = (byte)(var1.field_17 + (this.method_143() % 3 + 1) * 2);
                        }

                        var1.field_22 = this.field_244.field_78.field_10;
                        var1.field_23 = this.field_244.field_78.field_11;
                        this.method_92(var1, 1);
                     }
                     break;
                  case 8:
                     if (var1.field_14 != 5 && var1.field_14 != 6 && var1.field_14 != 14 && !var1.field_29) {
                        if ((Math.abs(var1.field_10 - this.field_244.field_78.field_10) > 1 || var1.field_11 != this.field_244.field_78.field_11)
                           && (Math.abs(var1.field_11 - this.field_244.field_78.field_11) > 1 || var1.field_10 != this.field_244.field_78.field_10)) {
                           if (!this.field_305
                              || (Math.abs(var1.field_10 - this.field_244.field_78.field_10) != 2 || var1.field_11 != this.field_244.field_78.field_11)
                                 && (Math.abs(var1.field_11 - this.field_244.field_78.field_11) != 2 || var1.field_10 != this.field_244.field_78.field_10)) {
                              if (var1.field_14 != 1 || var1.field_22 >= 0 && var1.field_23 >= 0) {
                                 if (var1.field_14 == 1
                                    && (var1.field_22 != this.field_244.field_78.field_10 || var1.field_23 != this.field_244.field_78.field_11)) {
                                    var1.field_22 = this.field_244.field_78.field_10;
                                    var1.field_23 = this.field_244.field_78.field_11;
                                 }
                              } else {
                                 this.method_92(var1, 0);
                                 var1.field_28 = this.field_222;
                              }
                           } else {
                              this.method_92(var1, 0);
                           }
                        } else {
                           this.field_305 = false;
                           this.method_92(var1, 0);
                        }

                        if (var1.field_14 == 0) {
                           this.method_222(var1, this.field_244.field_78.field_10, this.field_244.field_78.field_11);
                           if ((Math.abs(var1.field_10 - this.field_244.field_78.field_10) > 1 || var1.field_11 != this.field_244.field_78.field_11)
                              && (Math.abs(var1.field_11 - this.field_244.field_78.field_11) > 1 || var1.field_10 != this.field_244.field_78.field_10)) {
                              if (this.field_305
                                 && (
                                    Math.abs(var1.field_10 - this.field_244.field_78.field_10) == 2 && var1.field_11 == this.field_244.field_78.field_11
                                       || Math.abs(var1.field_11 - this.field_244.field_78.field_11) == 2 && var1.field_10 == this.field_244.field_78.field_10
                                 )) {
                                 var1.field_22 = -1;
                                 var1.field_23 = -1;
                                 if (this.field_222 - var1.field_28 > 1000L) {
                                    this.method_92(var1, 6);
                                    this.field_305 = false;
                                 }
                              } else if (this.field_222 - var1.field_28 > 1400L) {
                                 int var3 = this.method_233(var2, var1.field_10, var1.field_11, false);
                                 if (var3 != -1 && this.field_247[var3].field_17 == var1.field_17) {
                                    var1.field_17 = (byte)(var1.field_17 + (this.method_143() % 3 + 1) * 2);
                                 }

                                 var1.field_22 = this.field_244.field_78.field_10;
                                 var1.field_23 = this.field_244.field_78.field_11;
                                 this.method_92(var1, 1);
                                 if (this.method_145() % 100 < 25) {
                                    this.field_305 = true;
                                 }
                              }
                           } else {
                              var1.field_22 = -1;
                              var1.field_23 = -1;
                              if (this.field_222 - var1.field_28 > 1000L) {
                                 if (this.method_145() % 100 < 40) {
                                    this.method_92(var1, 6);
                                 } else {
                                    this.method_92(var1, 5);
                                 }
                              }
                           }
                        }

                        if (var1.field_14 == 1 && this.field_226 == 901 && this.field_307 == var1.field_10 && this.field_308 == var1.field_11) {
                           int var4 = this.method_145() % 100;
                           if (var4 >= 40 && var4 > 40 && var4 < 80 && this.field_222 - this.field_304 > 2000L) {
                              this.method_92(var1, 2);
                              this.field_304 = this.field_222;
                           }
                        }
                     }
               }

               if (var1.field_24) {
                  switch (var1.field_18) {
                     case 0:
                     case 1:
                        if (var1.field_22 < 0 || var1.field_23 < 0) {
                           break;
                        }
                     default:
                        if ((var1.field_10 != var1.field_22 || var1.field_11 != var1.field_23) && var1.field_22 >= 0 && var1.field_23 >= 0) {
                           this.method_229(var1.field_10, var1.field_11, var1.field_22, var1.field_23);
                           if (this.field_256 != null) {
                              this.method_222(var1, this.field_256.field_64, this.field_256.field_65);
                           }
                        }
                  }
               }
            }
         }
      }
   }

   // $VF: renamed from: a (int, int, int, int, int, byte) int
   int method_220(int var1, int var2, int var3, int var4, int var5, byte var6) {
      int var7 = 0;

      while (var7 < 10 && this.field_250[var7].field_121) {
         var7++;
      }

      if (var7 >= 0 && var7 < 10) {
         this.field_250[var7].field_121 = true;
         this.field_250[var7].field_124 = (byte)var1;
         this.field_250[var7].field_122.field_92 = false;
         this.field_250[var7].field_122.field_93 = true;
         this.field_250[var7].field_122.field_97 = 0;
         this.field_250[var7].field_122.field_98 = 0;
         this.field_250[var7].field_122.field_99 = 0;
         this.field_250[var7].field_122.field_100 = 0;
         this.field_250[var7].field_122.field_101 = 0;
         this.field_250[var7].field_123 = this.field_222;
         this.field_250[var7].field_130 = var6;
         this.field_250[var7].field_131 = var4;
         this.field_250[var7].field_132 = var5;
         switch (var1) {
            case 4:
               this.field_250[var7].field_122.field_95 = (byte)var2;
               this.field_250[var7].field_122.field_96 = (byte)var3;
               this.field_250[var7].field_125 = (short)(this.method_167(var2, var3) + 18);
               this.field_250[var7].field_126 = (short)(this.method_168(var2, var3) + 9);
               if (this.field_244.field_78.field_17 == 0) {
                  this.field_250[var7].field_126 = (short)(this.field_250[var7].field_126 + 12);
               } else if (this.field_244.field_78.field_17 == 4) {
                  this.field_250[var7].field_126 = (short)(this.field_250[var7].field_126 - 24);
               } else if (this.field_244.field_78.field_17 == 2) {
                  this.field_250[var7].field_125 = (short)(this.field_250[var7].field_125 + 40);
                  this.field_250[var7].field_126 = (short)(this.field_250[var7].field_126 - 20);
               } else if (this.field_244.field_78.field_17 == 6) {
                  this.field_250[var7].field_125 = (short)(this.field_250[var7].field_125 - 40);
                  this.field_250[var7].field_126 = (short)(this.field_250[var7].field_126 - 20);
               } else if (this.field_244.field_78.field_17 == 1) {
                  this.field_250[var7].field_125 = (short)(this.field_250[var7].field_125 + 24);
                  this.field_250[var7].field_126 = (short)(this.field_250[var7].field_126 + 4);
               } else if (this.field_244.field_78.field_17 == 7) {
                  this.field_250[var7].field_125 = (short)(this.field_250[var7].field_125 - 48);
                  this.field_250[var7].field_126 = (short)(this.field_250[var7].field_126 + 4);
               } else if (this.field_244.field_78.field_17 == 3) {
                  this.field_250[var7].field_125 = (short)(this.field_250[var7].field_125 + 32);
                  this.field_250[var7].field_126 = (short)(this.field_250[var7].field_126 - 32);
               } else if (this.field_244.field_78.field_17 == 5) {
                  this.field_250[var7].field_125 = (short)(this.field_250[var7].field_125 - 32);
                  this.field_250[var7].field_126 = (short)(this.field_250[var7].field_126 - 32);
               }
            default:
               switch (var1) {
                  case 4:
                     this.field_250[var7].field_127 = (short)(this.method_167(var4, var5) + 18);
                     this.field_250[var7].field_128 = (short)(this.method_168(var4, var5) + 9);
                     this.field_250[var7].field_129 = (short)method_276(
                        this.method_142(this.field_250[var7].field_127 - this.field_250[var7].field_125)
                           + this.method_142(this.field_250[var7].field_128 - this.field_250[var7].field_126)
                     );
                     this.field_250[var7].field_122.field_92 = true;
                     this.field_250[var7].field_122.field_94 = 2;
                     break;
                  default:
                     this.field_250[var7].field_127 = this.field_250[var7].field_125;
                     this.field_250[var7].field_128 = this.field_250[var7].field_126;
               }

               return var7;
         }
      } else {
         return var7;
      }
   }

   // $VF: renamed from: a (int, int, int, int, int) int
   int method_221(int var1, int var2, int var3, int var4, int var5) {
      int var6 = 0;

      while (var6 < 5 && this.field_249[var6].field_92) {
         var6++;
      }

      if (var6 >= 5) {
         return var6;
      } else {
         this.field_249[var6].field_92 = true;
         this.field_249[var6].field_93 = true;
         this.field_249[var6].field_97 = (short)(this.method_167(var2, var3) + var4);
         this.field_249[var6].field_98 = (short)(this.method_168(var2, var3) + var5);
         this.field_249[var6].field_99 = 0;
         this.field_249[var6].field_94 = (byte)var1;
         this.field_249[var6].field_100 = 0;
         this.field_249[var6].field_101 = 0;
         this.field_249[var6].field_95 = (byte)var2;
         this.field_249[var6].field_96 = (byte)var3;
         return var6;
      }
   }

   // $VF: renamed from: b (u, int, int) void
   void method_222(class_4 var1, int var2, int var3) {
      int var4 = var1.field_10 - var2;
      int var5 = var1.field_11 - var3;
      if (Math.abs(var5) <= Math.abs(var4)) {
         if (var4 <= 0) {
            this.method_93(var1, 1);
         } else {
            this.method_93(var1, 5);
         }
      } else if (var5 <= 0) {
         this.method_93(var1, 7);
      } else {
         this.method_93(var1, 3);
      }
   }

   // $VF: renamed from: b (u) void
   void method_223(class_4 var1) {
      if (var1.field_22 != -1 && var1.field_23 != -1) {
         if (!this.method_148(var1) && (var1.field_10 != var1.field_22 || var1.field_11 != var1.field_23)) {
            this.method_226();
            this.method_225(var1, var1.field_22, var1.field_23);
         }
      }
   }

   // $VF: renamed from: c (u, int, int) boolean
   boolean method_224(class_4 var1, int var2, int var3) {
      int var4 = var1.field_10 - var2;
      int var5 = var1.field_11 - var3;
      if (Math.abs(var4) == 0 && Math.abs(var5) == 1 || Math.abs(var4) == 1 && Math.abs(var5) == 0) {
         if (Math.abs(var5) <= Math.abs(var4)) {
            if (var4 <= 0) {
               if (var1.field_17 == 1) {
                  return true;
               }
            } else if (var1.field_17 == 5) {
               return true;
            }
         } else if (var5 <= 0) {
            if (var1.field_17 == 7) {
               return true;
            }
         } else if (var1.field_17 == 3) {
            return true;
         }

         return false;
      } else {
         return false;
      }
   }

   // $VF: renamed from: d (u, int, int) void
   void method_225(class_4 var1, int var2, int var3) {
      if (var1.field_10 != var2 || var1.field_11 != var3) {
         var1.field_22 = (byte)var2;
         var1.field_23 = (byte)var3;
         this.method_229(var1.field_10, var1.field_11, var1.field_22, var1.field_23);
         if (this.field_256 != null) {
            this.method_222(var1, this.field_256.field_64, this.field_256.field_65);
            this.method_92(var1, 1);
         }
      }
   }

   // $VF: renamed from: I () void
   void method_226() {
      for (int var2 = 0; var2 < this.field_262; var2++) {
         for (int var3 = 0; var3 < this.field_263; var3++) {
            this.field_254[var2][var3] = 0;
            if (this.field_265[var2][var3] != -1) {
               this.field_254[var2][var3] = (byte)(this.field_254[var2][var3] | 2);
            }

            if (this.field_266[var2][var3] != -1) {
               this.field_254[var2][var3] = (byte)(this.field_254[var2][var3] | 1);
            }

            if (this.field_264[var2][var3] == 127) {
               this.field_254[var2][var3] = (byte)(this.field_254[var2][var3] | 240);
            }
         }
      }

      for (int var5 = 0; var5 < 24; var5++) {
         if (this.field_247[var5] != this.field_244.field_78 && this.field_247[var5].field_9) {
            if (this.field_247[var5].field_14 == 3 || this.field_247[var5].field_14 == 4) {
               if (this.field_247[var5].field_18 == 5) {
                  continue;
               }

               if (this.field_247[var5].field_18 == 7) {
                  this.field_254[this.field_247[var5].field_10][this.field_247[var5].field_11] = (byte)(
                     this.field_254[this.field_247[var5].field_10][this.field_247[var5].field_11] | 240
                  );
                  this.field_254[this.field_247[var5].field_10][this.field_247[var5].field_11 - 1] = (byte)(
                     this.field_254[this.field_247[var5].field_10][this.field_247[var5].field_11 - 1] | 240
                  );
                  continue;
               }

               if (this.field_247[var5].field_18 == 3 || this.field_247[var5].field_18 == 9) {
                  this.field_254[this.field_247[var5].field_10][this.field_247[var5].field_11] = (byte)(
                     this.field_254[this.field_247[var5].field_10][this.field_247[var5].field_11] | 240
                  );
                  continue;
               }

               if (this.field_247[var5].field_18 != 10) {
                  continue;
               }

               this.field_254[this.field_247[var5].field_10][this.field_247[var5].field_11] = (byte)(
                  this.field_254[this.field_247[var5].field_10][this.field_247[var5].field_11] | 240
               );
               this.field_254[this.field_247[var5].field_10][this.field_247[var5].field_11 - 1] = (byte)(
                  this.field_254[this.field_247[var5].field_10][this.field_247[var5].field_11 - 1] | 240
               );
               this.field_254[this.field_247[var5].field_10 - 1][this.field_247[var5].field_11 - 1] = (byte)(
                  this.field_254[this.field_247[var5].field_10 - 1][this.field_247[var5].field_11 - 1] | 240
               );
               this.field_254[this.field_247[var5].field_10 + 1][this.field_247[var5].field_11 - 1] = (byte)(
                  this.field_254[this.field_247[var5].field_10 + 1][this.field_247[var5].field_11 - 1] | 240
               );
               this.field_254[this.field_247[var5].field_10][this.field_247[var5].field_11 - 2] = (byte)(
                  this.field_254[this.field_247[var5].field_10][this.field_247[var5].field_11 - 2] | 240
               );
               this.field_254[this.field_247[var5].field_10 - 1][this.field_247[var5].field_11 - 2] = (byte)(
                  this.field_254[this.field_247[var5].field_10 - 1][this.field_247[var5].field_11 - 2] | 240
               );
               this.field_254[this.field_247[var5].field_10][this.field_247[var5].field_11 - 3] = (byte)(
                  this.field_254[this.field_247[var5].field_10][this.field_247[var5].field_11 - 3] | 240
               );
               this.field_254[this.field_247[var5].field_10 - 1][this.field_247[var5].field_11 - 3] = (byte)(
                  this.field_254[this.field_247[var5].field_10 - 1][this.field_247[var5].field_11 - 3] | 240
               );
               this.field_254[this.field_247[var5].field_10][this.field_247[var5].field_11 - 4] = (byte)(
                  this.field_254[this.field_247[var5].field_10][this.field_247[var5].field_11 - 4] | 240
               );
               this.field_254[this.field_247[var5].field_10 - 1][this.field_247[var5].field_11 - 4] = (byte)(
                  this.field_254[this.field_247[var5].field_10 - 1][this.field_247[var5].field_11 - 4] | 240
               );
            }

            if (this.field_247[var5].field_18 != 0 && this.field_247[var5].field_18 != 1 && this.field_247[var5].field_18 != 3) {
               this.field_254[this.field_247[var5].field_10][this.field_247[var5].field_11] = (byte)(
                  this.field_254[this.field_247[var5].field_10][this.field_247[var5].field_11] | 240
               );
            } else {
               this.field_254[this.field_247[var5].field_10][this.field_247[var5].field_11] = (byte)(
                  this.field_254[this.field_247[var5].field_10][this.field_247[var5].field_11] | 240
               );
            }
         }
      }

      for (int var4 = 0; var4 < this.field_280; var4++) {
         if (this.field_281[var4].field_38) {
            byte var1 = this.field_281[var4].field_34;
            if (this.field_284[var1][7] != 0) {
               if (this.field_284[var1][6] != 0) {
                  if (!this.field_281[var4].field_40) {
                     if (this.field_281[var4].field_35 != 0) {
                        for (int var9 = 0; var9 < this.field_284[var1][5]; var9++) {
                           this.field_254[this.field_281[var4].field_35][this.field_281[var4].field_36 + var9] = (byte)(
                              this.field_254[this.field_281[var4].field_35][this.field_281[var4].field_36 + var9] | 2
                           );
                        }
                     }
                  } else if (this.field_281[var4].field_36 != 0) {
                     for (int var8 = 0; var8 < this.field_284[var1][5]; var8++) {
                        this.field_254[this.field_281[var4].field_35 + var8][this.field_281[var4].field_36] = (byte)(
                           this.field_254[this.field_281[var4].field_35 + var8][this.field_281[var4].field_36] | 1
                        );
                     }
                  }
               } else if (!this.field_281[var4].field_40) {
                  for (int var7 = 0; var7 < this.field_284[var1][4]; var7++) {
                     for (int var11 = 0; var11 < this.field_284[var1][5]; var11++) {
                        this.field_254[this.field_281[var4].field_35 + var7][this.field_281[var4].field_36 + var11] = (byte)(
                           this.field_254[this.field_281[var4].field_35 + var7][this.field_281[var4].field_36 + var11] | 240
                        );
                     }
                  }
               } else {
                  for (int var6 = 0; var6 < this.field_284[var1][5]; var6++) {
                     for (int var10 = 0; var10 < this.field_284[var1][4]; var10++) {
                        this.field_254[this.field_281[var4].field_35 + var6][this.field_281[var4].field_36 + var10] = (byte)(
                           this.field_254[this.field_281[var4].field_35 + var6][this.field_281[var4].field_36 + var10] | 240
                        );
                     }
                  }
               }
            }
         }
      }

      if (this.field_326.field_38) {
         this.field_254[this.field_326.field_35][this.field_326.field_36] = (byte)(this.field_254[this.field_326.field_35][this.field_326.field_36] | 240);
      }

      if (this.field_331.field_38) {
         this.field_254[this.field_331.field_35][this.field_331.field_36] = (byte)(this.field_254[this.field_331.field_35][this.field_331.field_36] | 240);
      }

      if (this.field_336.field_38) {
         this.field_254[this.field_336.field_35][this.field_336.field_36] = (byte)(this.field_254[this.field_336.field_35][this.field_336.field_36] | 240);
      }

      if (this.field_226 == 384) {
         this.field_254[this.field_244.field_78.field_10][this.field_244.field_78.field_11] = (byte)(
            this.field_254[this.field_244.field_78.field_10][this.field_244.field_78.field_11] | 240
         );
      } else {
         this.field_254[this.field_244.field_78.field_10][this.field_244.field_78.field_11] = (byte)(
            this.field_254[this.field_244.field_78.field_10][this.field_244.field_78.field_11] | 0
         );
      }
   }

   // $VF: renamed from: a (j, j) j
   class_10 method_227(class_10 var1, class_10 var2) {
      if (var1 == var2) {
         class_10 var4 = var2.field_62;
         var2.field_62 = null;
         return var4;
      } else {
         for (class_10 var3 = var1; var3.field_62 != null; var3 = var3.field_62) {
            if (var3.field_62 == var2) {
               if (var2.field_62 == null) {
                  var3.field_62 = null;
               } else {
                  var3.field_62 = var2.field_62;
                  var2.field_62 = null;
               }
               break;
            }
         }

         return var1;
      }
   }

   // $VF: renamed from: b (j, j) j
   class_10 method_228(class_10 var1, class_10 var2) {
      var2.field_62 = var1;
      return var2;
   }

   // $VF: renamed from: b (int, int, int, int) void
   void method_229(int var1, int var2, int var3, int var4) {
      boolean[] var11 = new boolean[4];
      Object var5 = null;
      class_10 var6 = null;
      int var14 = 0;
      class_10 var7 = this.field_255[var14++];
      var7.field_64 = (byte)var1;
      var7.field_65 = (byte)var2;
      var7.field_66 = 0;
      var7.field_67 = (byte)(Math.abs(var7.field_64 - var3) + Math.abs(var7.field_65 - var4));
      var7.field_62 = null;
      var7.field_63 = null;
      class_10 var10 = var7;
      if (var1 == var3 && var2 == var4) {
         this.field_256 = var7;
      } else {
         byte var12 = this.field_254[var1][var2];
         byte var13 = this.field_254[var3][var4];
         if (this.field_254[var3][var4] == 240) {
            this.field_256 = null;
         } else {
            this.field_254[var1][var2] = (byte)(this.field_254[var1][var2] & 15);
            this.field_254[var3][var4] = (byte)(this.field_254[var3][var4] & 15);
            class_10 var17 = this.method_228((class_10)var5, var7);

            label111:
            while (true) {
               class_10 var8 = var17;
               class_10 var9 = var17;
               if (var17 == null) {
                  break;
               }

               while (var8.field_62 != null) {
                  var8 = var8.field_62;
                  if (var8.field_66 + var8.field_67 < var9.field_66 + var9.field_67) {
                     var9 = var8;
                  }
               }

               if (var9.field_67 < var10.field_67) {
                  var10 = var9;
               }

               if (var10.field_67 == 0) {
                  break;
               }

               var11[0] = this.method_231(var9.field_64, var9.field_65, 3, false);
               var11[1] = this.method_231(var9.field_64, var9.field_65, 5, false);
               var11[2] = this.method_231(var9.field_64, var9.field_65, 7, false);
               var11[3] = this.method_231(var9.field_64, var9.field_65, 1, false);

               for (class_10 var19 = var17; var19 != null; var19 = var19.field_62) {
                  for (int var16 = 0; var16 < 4; var16++) {
                     if (var19.field_64 == var9.field_64 + field_311[var16][0] && var19.field_65 == var9.field_65 + field_311[var16][1]) {
                        var11[var16] = false;
                     }
                  }
               }

               class_10 var20 = var6;

               while (true) {
                  if (var20 == null) {
                     int var15 = this.method_143() % 4;

                     for (int var24 = 0; var24 < 4; var6 = this.method_228(var6, var9)) {
                        if (var11[var15]) {
                           if (var14 == 150) {
                              var17 = this.method_227(var17, var9);
                              if (var14 == 150) {
                                 break label111;
                              }
                              break;
                           }

                           var7 = this.field_255[var14++];
                           var7.field_64 = (byte)(var9.field_64 + field_311[var15][0]);
                           var7.field_65 = (byte)(var9.field_65 + field_311[var15][1]);
                           var7.field_66 = (byte)(var9.field_66 + 1);
                           var7.field_67 = (byte)(Math.abs(var7.field_64 - var3) + Math.abs(var7.field_65 - var4));
                           var7.field_62 = null;
                           var7.field_63 = var9;
                           var5 = this.method_228(var17, var7);
                        }

                        var15 = (var15 + 1) % 4;
                        var24++;
                     }
                  }

                  for (int var23 = 0; var23 < 4; var23++) {
                     if (var20.field_64 == var9.field_64 + field_311[var23][0] && var20.field_65 == var9.field_65 + field_311[var23][1]) {
                        var11[var23] = false;
                     }
                  }

                  var20 = var20.field_62;
               }
            }

            class_10 var21;
            for (var21 = null; var10 != null; var10 = var10.field_63) {
               var10.field_62 = var21;
               var21 = var10;
            }

            this.field_254[var1][var2] = var12;
            this.field_254[var3][var4] = var13;
            this.field_256 = var21.field_62;
         }
      }
   }

   // $VF: renamed from: J () void
   void method_230() {
      if (!this.field_155) {
         for (int var2 = 0; var2 < 24; var2++) {
            if (this.field_247[var2].field_9
               && !this.field_247[var2].field_25
               && (this.field_279 == this.field_267[this.field_247[var2].field_10][this.field_247[var2].field_11] || this.method_238(this.field_247[var2]))) {
               class_4 var1 = this.field_247[var2];
               var1.field_24 = false;
               if (class_2.field_1[var1.field_18][var1.field_14][1] != 0) {
                  if (var1.field_18 == 5) {
                     if (var1.field_14 == 1) {
                        if (var1.field_12 == 2 || var1.field_12 == 5) {
                           this.field_259 = 100;
                        }
                     } else if (var1.field_14 == 2) {
                        if (var1.field_12 == 0 || var1.field_12 == 3) {
                           this.field_259 = 100;
                        }
                     } else if (var1.field_14 == 6
                        && var1.field_12 > 3
                        && var1.field_12 < 8
                        && var1.field_13 != var1.field_12
                        && this.method_231(var1.field_10, var1.field_11, var1.field_17, true)) {
                        this.method_234(var1, var1.field_17);
                     }
                  }

                  var1.field_16 = var1.field_16
                     + this.method_173(class_2.field_1[var1.field_18][var1.field_14][1] * var1.field_32 * 256, class_2.field_1[var1.field_18][var1.field_14][0]);
                  if (var1.field_16 >= 65534) {
                     var1.field_16 = 0;
                     var1.field_24 = true;
                     if (class_2.field_1[var1.field_18][var1.field_14][2] == class_2.field_1[var1.field_18][var1.field_14][0]) {
                        int var3 = this.method_232(var2, var1.field_10, var1.field_11, var1.field_17, false);
                        if (var3 != -1) {
                           if (var1.field_18 != 11 && var1.field_18 != 8) {
                              this.method_92(var1, 0);
                           } else {
                              this.method_234(var1, var1.field_17);
                           }
                        } else if (var1.field_18 != 2
                           && var1.field_18 != 4
                           && var1.field_18 != 6
                           && var1.field_18 != 0
                           && var1.field_18 != 1
                           && var1.field_18 != 3) {
                           this.method_234(var1, var1.field_17);
                        } else {
                           var3 = this.method_232(var2, var1.field_10, var1.field_11, var1.field_17, true);
                           if (var3 != -1) {
                              this.method_92(var1, 0);
                           } else {
                              this.method_234(var1, var1.field_17);
                           }
                        }
                     }

                     if (this.method_236(var1)) {
                        var1.field_22 = -1;
                        var1.field_23 = -1;
                     }

                     label144:
                     switch (var1.field_18) {
                        case 0:
                        case 1:
                           switch (var1.field_14) {
                              case 1:
                              case 12:
                              case 13:
                                 if (this.field_244.field_85) {
                                    this.method_93(this.field_244.field_78, this.field_244.field_78.field_17 + 2);
                                    this.method_92(this.field_244.field_78, 0);
                                    this.field_244.field_85 = false;
                                 } else if (this.field_244.field_86) {
                                    this.method_93(this.field_244.field_78, this.field_244.field_78.field_17 - 2);
                                    this.method_92(this.field_244.field_78, 0);
                                    this.field_244.field_86 = false;
                                 } else if (this.field_244.field_87) {
                                    this.method_93(this.field_244.field_78, this.field_244.field_78.field_17 + 4);
                                    this.method_92(this.field_244.field_78, 0);
                                    this.field_244.field_87 = false;
                                 } else if (this.method_236(var1)) {
                                    this.method_92(var1, 0);
                                 } else {
                                    this.method_92(var1, 1);
                                 }
                                 break label144;
                              case 2:
                              case 8:
                              case 9:
                              case 10:
                              case 11:
                              default:
                                 if (var1.field_27 != this.field_222) {
                                    this.method_92(var1, 0);
                                 }
                                 break label144;
                              case 3:
                                 if ((this.field_226 & 512) != 0) {
                                    this.field_226 = 900;
                                 }

                                 this.method_92(var1, 4);
                                 break label144;
                              case 4:
                                 switch (this.field_347) {
                                    case 0:
                                       field_172 = 20;
                                       field_173 = 5;
                                       this.method_270();
                                       this.method_60((byte)3, false);
                                       break;
                                    case 1:
                                       this.field_238--;
                                       if (this.field_238 < 0) {
                                          field_172 = 22;
                                          field_173 = 5;
                                          this.method_270();
                                          this.field_404 = true;
                                          this.method_60((byte)3, false);
                                       } else {
                                          this.method_215(true);
                                       }
                                       break;
                                    case 2:
                                       field_172 = 22;
                                       field_173 = 5;
                                       this.method_270();
                                       this.method_60((byte)3, false);
                                 }

                                 return;
                              case 5:
                              case 6:
                              case 7:
                                 this.method_92(var1, 0);
                                 this.method_237();
                                 break label144;
                           }
                        case 2:
                        case 4:
                           switch (var1.field_14) {
                              case 0:
                                 break;
                              case 1:
                                 if (!this.method_236(var1)) {
                                    this.method_92(var1, 1);
                                 } else {
                                    this.method_92(var1, 0);
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
                                 this.method_92(var1, 1);
                                 break;
                              case 3:
                              case 4:
                                 this.method_92(var1, 4);
                                 this.method_237();
                                 break;
                              case 5:
                              case 14:
                                 this.method_92(var1, 0);
                                 this.method_237();
                           }
                        case 3:
                        case 7:
                        default:
                           break;
                        case 5:
                        case 6:
                        case 8:
                           switch (var1.field_14) {
                              case 0:
                                 break;
                              case 1:
                                 if (!this.method_236(var1)) {
                                    this.method_92(var1, 1);
                                 } else {
                                    this.method_92(var1, 0);
                                 }
                                 break;
                              case 2:
                              case 5:
                              case 6:
                              case 14:
                                 this.method_92(var1, 0);
                                 this.method_237();
                                 break;
                              case 3:
                              case 4:
                                 this.method_92(var1, 4);
                                 this.method_237();
                                 break;
                              case 7:
                              case 8:
                              case 9:
                              case 10:
                              case 11:
                              case 12:
                              case 13:
                              default:
                                 this.method_92(var1, 1);
                           }
                     }
                  }

                  if (class_2.field_1[var1.field_18][var1.field_14][2] != 0) {
                     var1.field_27 = this.field_222;
                  }

                  var1.field_13 = var1.field_12;
                  var1.field_12 = (byte)(var1.field_16 * class_2.field_1[var1.field_18][var1.field_14][0] >> 16);
               }
            }
         }

         for (int var4 = 0; var4 < 5; var4++) {
            if (this.field_249[var4].field_92 && !this.field_249[var4].field_93) {
               this.field_249[var4].field_101 = this.field_249[var4].field_101
                  + this.method_173(class_2.field_6[this.field_249[var4].field_94][1] * 256, class_2.field_6[this.field_249[var4].field_94][0]);
               this.field_249[var4].field_100 = (byte)(this.field_249[var4].field_101 * class_2.field_6[this.field_249[var4].field_94][0] >> 16);
               if (this.field_249[var4].field_101 >= 65534) {
                  this.field_249[var4].field_92 = false;
               }
            }
         }

         if (this.field_226 != 646 && this.field_226 != 647) {
            for (int var5 = 0; var5 < 10; var5++) {
               if (this.field_250[var5].field_121 && !this.field_250[var5].field_122.field_93) {
                  this.field_250[var5].field_122.field_101 = this.field_250[var5].field_122.field_101
                     + this.method_173(
                        class_2.field_6[this.field_250[var5].field_122.field_94][1] * 256, class_2.field_6[this.field_250[var5].field_122.field_94][0]
                     );
                  this.field_250[var5].field_122.field_100 = (byte)(
                     this.field_250[var5].field_122.field_101 * class_2.field_6[this.field_250[var5].field_122.field_94][0] >> 16
                  );
                  if (this.field_250[var5].field_122.field_101 >= 65534) {
                     this.field_250[var5].field_122.field_101 = 0;
                     this.field_250[var5].field_122.field_100 = 0;
                  }
               }
            }
         }
      }
   }

   // $VF: renamed from: a (int, int, int, boolean) boolean
   boolean method_231(int var1, int var2, int var3, boolean var4) {
      switch (var3) {
         case 1:
            if (var1 == this.field_262 - 1) {
               return false;
            }

            if ((this.field_254[var1 + 1][var2] & 240) != 0) {
               return false;
            }

            if ((this.field_254[var1][var2] & 8) != 0) {
               return false;
            }

            if ((this.field_254[var1 + 1][var2] & 2) != 0) {
               return false;
            }

            if (var4 && this.field_279 != this.field_267[var1 + 1][var2]) {
               return false;
            }
         case 2:
         case 4:
         case 6:
         default:
            break;
         case 3:
            if (var2 == 0) {
               return false;
            }

            if ((this.field_254[var1][var2 - 1] & 240) != 0) {
               return false;
            }

            if ((this.field_254[var1][var2] & 1) != 0) {
               return false;
            }

            if ((this.field_254[var1][var2 - 1] & 4) != 0) {
               return false;
            }

            if (var4 && this.field_279 != this.field_267[var1][var2 - 1]) {
               return false;
            }
            break;
         case 5:
            if (var1 == 0) {
               return false;
            }

            if ((this.field_254[var1 - 1][var2] & 240) != 0) {
               return false;
            }

            if ((this.field_254[var1][var2] & 2) != 0) {
               return false;
            }

            if ((this.field_254[var1 - 1][var2] & 8) != 0) {
               return false;
            }

            if (var4 && this.field_279 != this.field_267[var1 - 1][var2]) {
               return false;
            }
            break;
         case 7:
            if (var2 == this.field_263 - 1) {
               return false;
            }

            if ((this.field_254[var1][var2 + 1] & 240) != 0) {
               return false;
            }

            if ((this.field_254[var1][var2] & 4) != 0) {
               return false;
            }

            if ((this.field_254[var1][var2 + 1] & 1) != 0) {
               return false;
            }

            if (var4 && this.field_279 != this.field_267[var1][var2 + 1]) {
               return false;
            }
      }

      return true;
   }

   // $VF: renamed from: a (int, int, int, int, boolean) int
   int method_232(int var1, int var2, int var3, int var4, boolean var5) {
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

      return this.method_233(var1, var6, var7, var5);
   }

   // $VF: renamed from: b (int, int, int, boolean) int
   int method_233(int var1, int var2, int var3, boolean var4) {
      if (var4) {
         return this.field_245.field_78.field_10 == var2 && this.field_245.field_78.field_11 == var3 && this.field_245.field_78.field_9 ? 1 : -1;
      } else {
         for (int var5 = 2; var5 < 24; var5++) {
            if (var5 != var1
               && this.field_247[var5].field_9
               && this.field_247[var5].field_14 != 3
               && this.field_247[var5].field_14 != 4
               && this.field_247[var5].field_10 == var2
               && this.field_247[var5].field_11 == var3) {
               return var5;
            }
         }

         return -1;
      }
   }

   // $VF: renamed from: d (u, int) void
   void method_234(class_4 var1, int var2) {
      byte var3;
      byte var4;
      boolean var6;
      short[][] var8;
      if (var2 == 1) {
         var3 = (byte)(var1.field_10 + 1);
         var4 = var1.field_11;
         var6 = false;
         var8 = this.field_265;
      } else if (var2 == 7) {
         var3 = var1.field_10;
         var4 = (byte)(var1.field_11 + 1);
         var6 = true;
         var8 = this.field_266;
      } else if (var2 == 5) {
         var3 = (byte)(var1.field_10 - 1);
         var4 = var1.field_11;
         var6 = false;
         var8 = this.field_265;
      } else {
         if (var2 != 3) {
            return;
         }

         var3 = var1.field_10;
         var4 = (byte)(var1.field_11 - 1);
         var6 = true;
         var8 = this.field_266;
      }

      if (this.field_267[var1.field_10][var1.field_11] != this.field_267[var3][var4]) {
         if (!this.field_290 && var8[Math.max(var1.field_10, var3)][Math.max(var1.field_11, var4)] != -1) {
            return;
         }

         int var7 = this.method_235(var3, var4, var2);
         if (var7 != -1) {
            class_5 var5 = this.field_281[var7];
            if (var5.field_37) {
               if (var5.field_40 == var6 && var5.field_38) {
                  return;
               }
            } else if (var5.field_38) {
               return;
            }
         }
      }

      var1.field_10 = var3;
      var1.field_11 = var4;
   }

   // $VF: renamed from: b (int, int, int) int
   int method_235(int var1, int var2, int var3) {
      for (int var4 = 0; var4 < this.field_280; var4++) {
         if (this.field_281[var4].field_38 && this.field_281[var4].field_39) {
            byte var5 = this.field_281[var4].field_34;
            if (this.field_284[var5][6] == 0) {
               if (this.field_281[var4].field_40) {
                  if (this.method_140(
                     var1, var2, this.field_281[var4].field_35, this.field_281[var4].field_36, this.field_284[var5][5], this.field_284[var5][4]
                  )) {
                     return var4;
                  }
               } else if (this.method_140(
                  var1, var2, this.field_281[var4].field_35, this.field_281[var4].field_36, this.field_284[var5][4], this.field_284[var5][5]
               )) {
                  return var4;
               }
            } else if (var3 == 1) {
               if (!this.field_281[var4].field_40
                  && this.method_140(var1, var2, this.field_281[var4].field_35, this.field_281[var4].field_36, this.field_284[var5][4], this.field_284[var5][5])
                  )
                {
                  return var4;
               }
            } else if (var3 == 7) {
               if (this.field_281[var4].field_40
                  && this.method_140(var1, var2, this.field_281[var4].field_35, this.field_281[var4].field_36, this.field_284[var5][5], this.field_284[var5][4])
                  )
                {
                  return var4;
               }
            } else if (var3 == 3) {
               if (this.field_281[var4].field_40
                  && this.method_140(
                     var1, var2 + 1, this.field_281[var4].field_35, this.field_281[var4].field_36, this.field_284[var5][5], this.field_284[var5][4]
                  )) {
                  return var4;
               }
            } else if (var3 == 5
               && !this.field_281[var4].field_40
               && this.method_140(
                  var1 + 1, var2, this.field_281[var4].field_35, this.field_281[var4].field_36, this.field_284[var5][4], this.field_284[var5][5]
               )) {
               return var4;
            }
         }
      }

      return -1;
   }

   // $VF: renamed from: c (u) boolean
   boolean method_236(class_4 var1) {
      if (var1.field_27 == this.field_222) {
         return false;
      } else {
         return var1.field_22 < 0 || var1.field_23 < 0 ? true : var1.field_10 == var1.field_22 && var1.field_11 == var1.field_23;
      }
   }

   // $VF: renamed from: K () void
   void method_237() {
      if (this.field_244.field_78.field_14 != 3 && this.field_244.field_78.field_14 != 4) {
         boolean var1 = false;

         for (int var2 = 0; var2 < 24; var2++) {
            if (this.field_247[var2].field_9 && this.field_247[var2].field_14 != 4) {
               if (this.field_247[var2].field_18 == 5) {
                  if (this.field_279 == this.field_267[this.field_247[var2].field_10][this.field_247[var2].field_11] && !this.field_247[var2].field_29) {
                     var1 = true;
                  }
                  break;
               }

               if (!this.method_238(this.field_247[var2])
                  && this.field_279 == this.field_267[this.field_247[var2].field_10][this.field_247[var2].field_11]
                  && !this.field_247[var2].field_29) {
                  var1 = true;
                  break;
               }
            }
         }

         if (this.field_226 != 900 && this.field_226 != 901) {
            if (this.field_226 == 384) {
            }

            this.field_226 = 900;
            if (class_2.field_1[this.field_244.field_78.field_18][this.field_244.field_78.field_14][2] == 0) {
               this.method_92(this.field_244.field_78, 0);
            }

            if (this.field_244.field_84 != 127) {
               this.method_239(this.field_244.field_84);
               this.field_244.field_81 = (byte)field_228[this.field_244.field_84];
            } else {
               this.method_239(127);
            }
         }
      }
   }

   // $VF: renamed from: d (u) boolean
   boolean method_238(class_4 var1) {
      return var1.field_18 == 0 || var1.field_18 == 1 || var1.field_18 == 3 || var1.field_18 == 7 || var1.field_18 == 5 || var1.field_18 == 10;
   }

   // $VF: renamed from: k (int) void
   void method_239(int var1) {
      this.method_240(var1, this.field_246);
   }

   // $VF: renamed from: k (int, int) void
   void method_240(int var1, int var2) {
      class_13 var3 = this.field_245;
      if (var1 == 127) {
         var3.field_78.field_19 = 127;
      } else {
         var3.field_84 = (byte)((var1 + 6) % 6);
         if (this.field_244.field_78.field_18 == 0) {
            this.field_244.field_78.field_19 = (byte)(0 + this.field_244.field_84);
         } else if (this.field_244.field_78.field_18 == 1) {
            this.field_244.field_78.field_19 = (byte)(5 + this.field_244.field_84);
         }

         if (var1 == 5) {
            var3.field_78.field_19 = 127;
         }

         if (this.method_172()) {
            this.method_92(var3.field_78, 8);
         }
      }
   }

   // $VF: renamed from: o (int) void
   private void method_241(int var1) {
      for (int var2 = 1; var2 < 24; var2++) {
         if (!this.field_247[var2].field_31 && var2 != var1 && this.method_242(var2)) {
            this.method_218(this.field_247[var2], -2);
            if (this.field_247[var2].field_18 != 2 && this.field_247[var2].field_18 != 8) {
               if (this.field_247[var2].field_18 == 6 && this.field_247[var2].field_20 <= 0) {
                  this.field_247[var2].field_30 = this.field_222;
                  this.method_263(this.field_247[var2].field_10, this.field_247[var2].field_11);
               }
            } else if (this.field_247[var2].field_20 > 0) {
               if (this.field_244.field_84 != 0) {
                  this.method_92(this.field_247[var2], 14);
               }
            } else if (this.field_247[var2].field_20 <= 0) {
               this.field_247[var2].field_30 = this.field_222;
               this.method_256(var2);
            }

            this.method_221(0, this.field_247[var2].field_10, this.field_247[var2].field_11, 18, -16);
         }
      }
   }

   // $VF: renamed from: p (int) boolean
   private boolean method_242(int var1) {
      if (this.field_244.field_78.field_17 == 0) {
         if (this.field_247[var1].field_10 == this.field_244.field_78.field_10 + 2 && this.field_247[var1].field_11 == this.field_244.field_78.field_11 - 1
            || this.field_247[var1].field_10 == this.field_244.field_78.field_10 + 1 && this.field_247[var1].field_11 == this.field_244.field_78.field_11 - 2
            || this.field_247[var1].field_10 == this.field_244.field_78.field_10 + 1 && this.field_247[var1].field_11 == this.field_244.field_78.field_11
            || this.field_247[var1].field_10 == this.field_244.field_78.field_10 && this.field_247[var1].field_11 == this.field_244.field_78.field_11 + 1) {
            return true;
         }
      } else if (this.field_244.field_78.field_17 == 4) {
         if (this.field_247[var1].field_10 == this.field_244.field_78.field_10 - 2 && this.field_247[var1].field_11 == this.field_244.field_78.field_11 + 1
            || this.field_247[var1].field_10 == this.field_244.field_78.field_10 - 1 && this.field_247[var1].field_11 == this.field_244.field_78.field_11 + 2
            || this.field_247[var1].field_10 == this.field_244.field_78.field_10 && this.field_247[var1].field_11 == this.field_244.field_78.field_11 - 1
            || this.field_247[var1].field_10 == this.field_244.field_78.field_10 - 1 && this.field_247[var1].field_11 == this.field_244.field_78.field_11) {
            return true;
         }
      } else if (this.field_244.field_78.field_17 == 2) {
         if (this.field_247[var1].field_10 == this.field_244.field_78.field_10 + 2 && this.field_247[var1].field_11 == this.field_244.field_78.field_11 + 1
            || this.field_247[var1].field_10 == this.field_244.field_78.field_10 + 1 && this.field_247[var1].field_11 == this.field_244.field_78.field_11 + 2
            || this.field_247[var1].field_10 == this.field_244.field_78.field_10 && this.field_247[var1].field_11 == this.field_244.field_78.field_11 - 1
            || this.field_247[var1].field_10 == this.field_244.field_78.field_10 + 1 && this.field_247[var1].field_11 == this.field_244.field_78.field_11) {
            return true;
         }
      } else if (this.field_244.field_78.field_17 == 6) {
         if (this.field_247[var1].field_10 == this.field_244.field_78.field_10 - 1 && this.field_247[var1].field_11 == this.field_244.field_78.field_11 - 2
            || this.field_247[var1].field_10 == this.field_244.field_78.field_10 - 2 && this.field_247[var1].field_11 == this.field_244.field_78.field_11 - 1
            || this.field_247[var1].field_10 == this.field_244.field_78.field_10 - 1 && this.field_247[var1].field_11 == this.field_244.field_78.field_11
            || this.field_247[var1].field_10 == this.field_244.field_78.field_10 && this.field_247[var1].field_11 == this.field_244.field_78.field_11 + 1) {
            return true;
         }
      } else if (this.field_244.field_78.field_17 == 1) {
         if (this.field_247[var1].field_10 == this.field_244.field_78.field_10 + 1 && this.field_247[var1].field_11 == this.field_244.field_78.field_11 + 1
            || this.field_247[var1].field_10 == this.field_244.field_78.field_10 + 1 && this.field_247[var1].field_11 == this.field_244.field_78.field_11
            || this.field_247[var1].field_10 == this.field_244.field_78.field_10 + 1 && this.field_247[var1].field_11 == this.field_244.field_78.field_11 - 1
            || this.field_247[var1].field_10 == this.field_244.field_78.field_10 + 2 && this.field_247[var1].field_11 == this.field_244.field_78.field_11 + 1
            || this.field_247[var1].field_10 == this.field_244.field_78.field_10 + 2 && this.field_247[var1].field_11 == this.field_244.field_78.field_11
            || this.field_247[var1].field_10 == this.field_244.field_78.field_10 + 2 && this.field_247[var1].field_11 == this.field_244.field_78.field_11 - 1) {
            return true;
         }
      } else if (this.field_244.field_78.field_17 == 7) {
         if (this.field_247[var1].field_10 == this.field_244.field_78.field_10 - 1 && this.field_247[var1].field_11 == this.field_244.field_78.field_11 + 1
            || this.field_247[var1].field_10 == this.field_244.field_78.field_10 && this.field_247[var1].field_11 == this.field_244.field_78.field_11 + 1
            || this.field_247[var1].field_10 == this.field_244.field_78.field_10 + 1 && this.field_247[var1].field_11 == this.field_244.field_78.field_11 + 1
            || this.field_247[var1].field_10 == this.field_244.field_78.field_10 - 1 && this.field_247[var1].field_11 == this.field_244.field_78.field_11 + 2
            || this.field_247[var1].field_10 == this.field_244.field_78.field_10 && this.field_247[var1].field_11 == this.field_244.field_78.field_11 + 2
            || this.field_247[var1].field_10 == this.field_244.field_78.field_10 + 1 && this.field_247[var1].field_11 == this.field_244.field_78.field_11 + 2) {
            return true;
         }
      } else if (this.field_244.field_78.field_17 == 3) {
         if (this.field_247[var1].field_10 == this.field_244.field_78.field_10 - 1 && this.field_247[var1].field_11 == this.field_244.field_78.field_11 - 1
            || this.field_247[var1].field_10 == this.field_244.field_78.field_10 && this.field_247[var1].field_11 == this.field_244.field_78.field_11 - 1
            || this.field_247[var1].field_10 == this.field_244.field_78.field_10 + 1 && this.field_247[var1].field_11 == this.field_244.field_78.field_11 - 1
            || this.field_247[var1].field_10 == this.field_244.field_78.field_10 - 1 && this.field_247[var1].field_11 == this.field_244.field_78.field_11 - 2
            || this.field_247[var1].field_10 == this.field_244.field_78.field_10 && this.field_247[var1].field_11 == this.field_244.field_78.field_11 - 2
            || this.field_247[var1].field_10 == this.field_244.field_78.field_10 + 1 && this.field_247[var1].field_11 == this.field_244.field_78.field_11 - 2) {
            return true;
         }
      } else if (this.field_244.field_78.field_17 == 5
         && (
            this.field_247[var1].field_10 == this.field_244.field_78.field_10 - 1 && this.field_247[var1].field_11 == this.field_244.field_78.field_11 + 1
               || this.field_247[var1].field_10 == this.field_244.field_78.field_10 - 1 && this.field_247[var1].field_11 == this.field_244.field_78.field_11
               || this.field_247[var1].field_10 == this.field_244.field_78.field_10 - 1
                  && this.field_247[var1].field_11 == this.field_244.field_78.field_11 - 1
               || this.field_247[var1].field_10 == this.field_244.field_78.field_10 - 2
                  && this.field_247[var1].field_11 == this.field_244.field_78.field_11 + 1
               || this.field_247[var1].field_10 == this.field_244.field_78.field_10 - 2 && this.field_247[var1].field_11 == this.field_244.field_78.field_11
               || this.field_247[var1].field_10 == this.field_244.field_78.field_10 - 2
                  && this.field_247[var1].field_11 == this.field_244.field_78.field_11 - 1
         )) {
         return true;
      }

      return false;
   }

   // $VF: renamed from: aO () void
   private void method_243() {
      int var1 = 0;
      int var2 = 0;
      if (this.field_244.field_78.field_14 != 3 && this.field_244.field_78.field_14 != 4) {
         if ((this.field_167 & 128) != 0 && this.field_134) {
            if (this.field_347 == 1) {
               this.method_270();
               this.method_174(this.field_143[22]);
               this.field_356++;
               this.field_226 = 138;
               this.field_227 = 0;
               this.method_188();
               this.method_190((byte)0, (byte)1);
            } else if (this.field_347 == 0) {
               this.method_270();
               field_172 = 19;
               field_173 = 5;
               this.method_60((byte)3, false);
            }
         }

         if ((this.field_167 & 512) != 0 && this.field_226 != 138) {
            this.method_270();
            this.method_64();
            this.method_190((byte)0, (byte)2);
         }

         if (this.field_226 != 138) {
            if ((this.field_167 & 32) != 0 || (this.field_167 & 16384) != 0) {
               if (this.method_255()) {
                  return;
               }

               if (this.field_244.field_81 == 5 && this.field_244.field_78.field_22 == -1 && this.field_244.field_78.field_23 == -1) {
                  this.method_266();
                  return;
               }

               if (this.field_244.field_84 == 127) {
                  return;
               }
            }

            if ((this.field_320 & 4) == 0 && (this.field_320 & 8192) == 0) {
               if ((this.field_320 & 2) == 0 && (this.field_320 & '耀') == 0) {
                  if ((this.field_320 & 16) == 0 && (this.field_320 & 2048) == 0) {
                     if ((this.field_320 & 8) != 0 || (this.field_320 & 131072) != 0) {
                        if (this.method_172()) {
                           this.method_93(this.field_244.field_78, 2);
                           this.method_92(this.field_244.field_78, 1);
                        } else {
                           this.field_244.field_78.field_27 = this.field_222;
                        }
                     }
                  } else if (this.method_172()) {
                     this.method_93(this.field_244.field_78, 6);
                     this.method_92(this.field_244.field_78, 1);
                  } else {
                     this.field_244.field_78.field_27 = this.field_222;
                  }
               } else if (this.method_172()) {
                  this.method_93(this.field_244.field_78, 4);
                  this.method_92(this.field_244.field_78, 1);
               } else {
                  this.field_244.field_78.field_27 = this.field_222;
               }
            } else if (this.method_172()) {
               this.method_93(this.field_244.field_78, 0);
               this.method_92(this.field_244.field_78, 1);
            } else {
               this.field_244.field_78.field_27 = this.field_222;
            }

            if ((this.field_167 & 262144) != 0) {
               if (this.field_244.field_84 == 127) {
                  return;
               }

               do {
                  this.field_244.field_84--;
               } while (this.field_244.field_84 >= 0 && !this.field_244.field_90[this.field_244.field_84]);

               if (this.field_244.field_84 < 0) {
                  this.field_244.field_84 = 5;

                  while (!this.field_244.field_90[this.field_244.field_84]) {
                     this.field_244.field_84--;
                  }
               }

               this.field_244.field_81 = this.field_244.field_84;
               if ((this.field_226 & 512) != 0) {
                  this.method_239(this.field_244.field_84);
               }
            } else if ((this.field_167 & 65536) != 0 || (this.field_167 & 256) != 0) {
               if (this.field_244.field_84 == 127) {
                  return;
               }

               do {
                  this.field_244.field_84++;
               } while (this.field_244.field_84 <= 5 && !this.field_244.field_90[this.field_244.field_84]);

               if (this.field_244.field_84 > 5) {
                  this.field_244.field_84 = 0;

                  while (!this.field_244.field_90[this.field_244.field_84]) {
                     this.field_244.field_84++;
                  }
               }

               this.field_244.field_81 = this.field_244.field_84;
               if ((this.field_226 & 512) != 0) {
                  this.method_239(this.field_244.field_84);
               }
            }
         }

         switch (this.field_226) {
            case 138:
               switch (this.field_227) {
                  case 0:
                     this.field_174.b(this.field_168);
                     if (this.field_174.b()) {
                        if (this.field_174.a() == field_185) {
                           this.method_174(this.field_143[22]);
                           this.field_227 = 1;
                           this.method_190((byte)0, (byte)2);
                           this.field_149 = 0;
                           this.field_372 = false;
                           this.field_373 = false;
                        } else if (this.field_174.a() == field_186) {
                           this.method_174(this.field_143[23]);
                           this.field_227 = 2;
                           this.method_190((byte)0, (byte)2);
                           this.field_149 = 0;
                           this.field_372 = false;
                           this.field_373 = false;
                        } else if (this.field_174.a() == field_187) {
                           if (this.field_356 >= this.field_357[this.field_359][4]) {
                              this.field_356 = 0;
                              this.field_359++;
                              if (this.field_359 > this.field_358) {
                                 this.field_359 = (byte)(this.field_358 - 2);
                                 this.field_360++;
                                 if (this.field_360 > 99) {
                                    this.field_360 = 99;
                                 }
                              }
                           }

                           this.method_72();
                           this.field_341 = this.field_222;
                           this.field_328 = 0;
                           this.field_338 = 0;
                           this.field_333 = 0;
                           this.field_226 = 384;
                           this.method_190((byte)5, (byte)3);
                           this.field_167 = 0;
                           this.field_168 = 0;
                           this.field_169 = 0;
                           this.field_149 = 0;
                           this.field_244.field_78.field_22 = -1;
                           this.field_244.field_78.field_23 = -1;
                           this.method_92(this.field_244.field_78, 0);
                           this.method_269(0, 1);
                           this.method_271((byte)2);
                           this.method_237();
                        }
                     }

                     if ((this.field_167 & 512) != 0) {
                        if (this.field_356 >= this.field_357[this.field_359][4]) {
                           this.field_356 = 0;
                           this.field_359++;
                           if (this.field_359 > this.field_358) {
                              this.field_359 = (byte)(this.field_358 - 2);
                              this.field_360++;
                           }
                        }

                        this.method_72();
                        this.field_341 = this.field_222;
                        this.field_328 = 0;
                        this.field_338 = 0;
                        this.field_333 = 0;
                        this.field_372 = false;
                        this.field_373 = false;
                        this.field_226 = 384;
                        this.method_190((byte)5, (byte)3);
                        this.field_167 = 0;
                        this.field_168 = 0;
                        this.field_169 = 0;
                        this.field_149 = 0;
                        this.field_244.field_78.field_22 = -1;
                        this.field_244.field_78.field_23 = -1;
                        this.method_92(this.field_244.field_78, 0);
                        this.method_269(0, 1);
                        this.method_271((byte)2);
                        this.method_237();
                     }

                     return;
                  case 1:
                     if ((this.field_167 & 32) == 0 && (this.field_167 & 256) == 0 && (this.field_167 & 16384) == 0) {
                        if ((this.field_167 & 2) == 0 && (this.field_167 & 32768) == 0) {
                           if ((this.field_167 & 4) != 0 || (this.field_167 & 8192) != 0) {
                              if (!this.field_371) {
                                 this.field_361 = false;
                              } else {
                                 this.field_362 = !this.field_362;
                              }

                              this.field_367 = false;
                           }
                        } else {
                           if (!this.field_371) {
                              this.field_361 = true;
                              this.field_235 = 0;
                           } else {
                              this.field_362 = !this.field_362;
                           }

                           this.field_367 = false;
                        }

                        if ((this.field_167 & 8) == 0 && (this.field_167 & 131072) == 0) {
                           if ((this.field_167 & 16) != 0 || (this.field_167 & 2048) != 0) {
                              if (!this.field_371) {
                                 if (this.field_361) {
                                    this.field_234++;
                                    if (this.field_234 > this.field_366 - 1) {
                                       this.field_234 = this.field_366 - 1;
                                    }
                                 } else {
                                    this.field_235++;
                                    if (this.field_235 >= 2) {
                                       this.field_235 = 2;
                                    }
                                 }
                              }

                              this.field_367 = false;
                           }
                        } else {
                           if (!this.field_371) {
                              if (this.field_361) {
                                 this.field_234--;
                                 if (this.field_234 < 0) {
                                    this.field_234 = 0;
                                 }
                              } else {
                                 this.field_235--;
                                 if (this.field_235 <= 0) {
                                    this.field_235 = 0;
                                 }
                              }
                           }

                           this.field_367 = false;
                        }

                        if ((this.field_167 & 512) != 0) {
                           if (!this.field_371) {
                              this.method_174(this.field_143[21]);
                              this.field_227 = 0;
                              this.field_234 = 0;
                              this.field_235 = 0;
                              this.field_361 = true;
                              this.field_362 = false;
                              this.method_190((byte)0, (byte)1);
                           } else {
                              this.field_371 = false;
                              this.field_362 = false;
                           }

                           this.field_367 = false;
                        }

                        return;
                     }

                     if (!this.field_361) {
                        if (this.field_371) {
                           if (this.field_362) {
                              if (this.field_232[this.field_399[this.field_234]][this.field_235] < 3) {
                                 byte var6 = this.method_245();
                                 this.field_364 = this.field_364 - this.field_231[var6][this.field_399[this.field_234]];
                                 this.field_232[this.field_399[this.field_234]][this.field_235]++;
                              }

                              this.field_362 = false;
                           }

                           this.field_371 = false;
                        } else {
                           byte var7 = this.method_245();
                           if (this.field_364 >= this.field_231[var7][this.field_399[this.field_234]]) {
                              if (this.field_232[this.field_399[this.field_234]][this.field_235] < 3) {
                                 this.field_371 = true;
                              }
                           } else if (this.field_232[this.field_399[this.field_234]][this.field_235] < 3) {
                              this.field_367 = true;
                           }
                        }
                     } else {
                        this.field_361 = false;
                        this.field_235 = 0;
                     }

                     return;
                  case 2:
                     this.field_361 = false;
                     if ((this.field_167 & 32) != 0 || (this.field_167 & 256) != 0 || (this.field_167 & 16384) != 0) {
                        if (!this.field_371) {
                           if (this.field_234 < 5) {
                              if (this.field_364 >= this.field_365[this.field_234]) {
                                 if (this.field_244.field_90[this.field_234 + 1]) {
                                    this.field_371 = true;
                                 }
                              } else if (this.field_244.field_90[this.field_234 + 1]) {
                                 this.field_367 = true;
                              }
                           } else if (!this.field_372) {
                              if (this.field_364 >= this.field_365[this.field_234]) {
                                 if (!this.field_244.field_90[this.field_234 - 3]) {
                                    this.field_372 = true;
                                    this.field_373 = false;
                                 }
                              } else if (!this.field_244.field_90[this.field_234 - 3]) {
                                 this.field_367 = true;
                              }
                           } else {
                              if (this.field_373 && !this.field_244.field_90[this.field_234 - 3]) {
                                 this.field_244.field_90[this.field_234 - 3] = true;
                                 switch (this.field_234 - 3) {
                                    case 2:
                                       this.field_244.field_83[2] = (byte)(this.field_244.field_83[2] + 5);
                                       break;
                                    case 3:
                                       this.field_244.field_83[3] = (byte)(this.field_244.field_83[3] + 10);
                                       break;
                                    case 4:
                                       this.field_244.field_83[4] = (byte)(this.field_244.field_83[4] + 5);
                                 }

                                 this.field_364 = this.field_364 - this.field_365[this.field_234];
                              }

                              this.field_372 = false;
                           }
                        } else {
                           this.field_244.field_83[this.field_234 + 1] = (byte)(this.field_244.field_83[this.field_234 + 1] + this.field_370);
                           this.field_364 = this.field_364 - this.field_370 * this.field_365[this.field_234];
                           this.field_371 = false;
                           this.field_370 = 0;
                        }

                        return;
                     }

                     if ((this.field_167 & 8) == 0 && (this.field_167 & 131072) == 0) {
                        if ((this.field_167 & 16) == 0 && (this.field_167 & 2048) == 0) {
                           if ((this.field_167 & 4) == 0 && (this.field_167 & 8192) == 0) {
                              if ((this.field_167 & 2) != 0 || (this.field_167 & 32768) != 0) {
                                 if (this.field_371) {
                                    this.field_370 = (byte)(this.field_370 - 10);
                                    if (this.field_370 < 0) {
                                       this.field_370 = 0;
                                    }
                                 } else if (this.field_372) {
                                    this.field_373 = !this.field_373;
                                 }

                                 this.field_367 = false;
                              }
                           } else {
                              if (this.field_371) {
                                 this.field_370 = (byte)(this.field_370 + 10);
                                 if (this.field_370 * this.field_365[this.field_234] > this.field_364) {
                                    this.field_370 = (byte)(this.field_364 / this.field_365[this.field_234]);
                                 }

                                 if (this.field_370 > this.field_233[this.field_234 + 1] - this.field_244.field_83[this.field_234 + 1]) {
                                    this.field_370 = (byte)(this.field_233[this.field_234 + 1] - this.field_244.field_83[this.field_234 + 1]);
                                 }
                              } else if (this.field_372) {
                                 this.field_373 = !this.field_373;
                              }

                              this.field_367 = false;
                           }
                        } else {
                           if (this.field_372) {
                              return;
                           }

                           if (!this.field_371) {
                              this.field_234++;
                              if (this.field_234 > this.field_368 - 1) {
                                 this.field_234 = this.field_368 - 1;
                              }

                              this.field_149 = 0;
                           } else {
                              this.field_370--;
                              if (this.field_370 < 0) {
                                 this.field_370 = 0;
                              }
                           }

                           this.field_367 = false;
                        }
                     } else {
                        if (this.field_372) {
                           return;
                        }

                        if (!this.field_371) {
                           this.field_234--;
                           if (this.field_234 < 0) {
                              this.field_234 = 0;
                           }

                           this.field_149 = 0;
                        } else {
                           this.field_370++;
                           if (this.field_370 > this.field_233[this.field_234 + 1] - this.field_244.field_83[this.field_234 + 1]) {
                              this.field_370 = (byte)(this.field_233[this.field_234 + 1] - this.field_244.field_83[this.field_234 + 1]);
                           }

                           if (this.field_370 * this.field_365[this.field_234] > this.field_364) {
                              this.field_370--;
                           }
                        }

                        this.field_367 = false;
                     }

                     if ((this.field_167 & 512) != 0) {
                        if (!this.field_371 && !this.field_372) {
                           this.method_174(this.field_143[21]);
                           this.field_227 = 0;
                           this.field_234 = 0;
                           this.field_235 = 0;
                           this.field_361 = true;
                           this.method_190((byte)0, (byte)1);
                        } else {
                           this.field_371 = false;
                           this.field_372 = false;
                           this.field_373 = false;
                           this.field_370 = 0;
                        }

                        this.field_367 = false;
                     }

                     return;
                  default:
                     return;
               }
            case 384:
               if ((this.field_167 & 64) != 0 && this.field_134) {
                  this.method_86(2, 6, 6, 7);
                  this.method_237();
               }
               break;
            case 646:
               if (this.field_247[this.field_306].field_18 != 5) {
                  switch (this.field_244.field_84) {
                     default:
                        int var4 = method_144(100);
                        byte var5;
                        if (var4 < 3) {
                           var5 = 0;
                        } else if (var4 < 90 - this.field_231[this.method_244((byte)1)][this.field_244.field_84]) {
                           var5 = 1;
                        } else {
                           var5 = 2;
                        }

                        if (var5 == 2) {
                           this.field_299++;
                           if (this.field_244.field_84 != 0) {
                              this.field_297++;
                           }

                           if (this.field_244.field_84 == 0) {
                              this.method_218(this.field_247[this.field_306], -10);
                              if ((this.field_247[this.field_306].field_18 == 5 || this.field_247[this.field_306].field_18 == 2)
                                 && this.field_247[this.field_306].field_20 > 0) {
                                 this.method_92(this.field_247[this.field_306], 14);
                              }
                           } else if (this.field_244.field_84 == 1) {
                              this.method_218(this.field_247[this.field_306], -10);
                              if ((this.field_247[this.field_306].field_18 == 5 || this.field_247[this.field_306].field_18 == 2)
                                 && this.field_247[this.field_306].field_20 > 0) {
                                 this.method_92(this.field_247[this.field_306], 14);
                              }
                           } else if (this.field_244.field_84 == 2) {
                              this.method_218(this.field_247[this.field_306], -30);
                              if (this.field_247[this.field_306].field_18 == 5 && this.field_247[this.field_306].field_20 > 0) {
                                 this.method_92(this.field_247[this.field_306], 14);
                              }
                           } else if (this.field_244.field_84 == 3) {
                              this.method_218(this.field_247[this.field_306], -20);
                              if (this.field_247[this.field_306].field_18 == 5 && this.field_247[this.field_306].field_20 > 0) {
                                 this.method_92(this.field_247[this.field_306], 14);
                              }
                           }

                           if (this.field_247[this.field_306].field_18 != 2 && this.field_247[this.field_306].field_18 != 8) {
                              if (this.field_247[this.field_306].field_18 == 6 && this.field_247[this.field_306].field_20 <= 0) {
                                 this.field_247[this.field_306].field_30 = this.field_222;
                                 this.method_263(this.field_247[this.field_306].field_10, this.field_247[this.field_306].field_11);
                              }
                           } else if (this.field_247[this.field_306].field_20 > 0) {
                              this.method_92(this.field_247[this.field_306], 14);
                           } else if (this.field_247[this.field_306].field_20 <= 0) {
                              this.field_247[this.field_306].field_30 = this.field_222;
                              this.method_256(this.field_306);
                           }

                           this.field_259 = 100;
                           this.method_221(0, this.field_247[this.field_306].field_10, this.field_247[this.field_306].field_11, 18, -16);
                        } else if (var5 == 0) {
                           this.field_296++;
                           this.field_298++;
                           this.method_221(1, this.field_307, this.field_308, 18, 9);
                        } else {
                           if (this.field_244.field_84 != 0) {
                              this.field_297++;
                           }

                           if (this.field_244.field_84 == 1) {
                              this.method_218(this.field_247[this.field_306], -this.field_231[this.method_244((byte)2)][1]);
                           } else if (this.field_244.field_84 == 2) {
                              this.method_218(this.field_247[this.field_306], -this.field_231[this.method_244((byte)2)][2]);
                           } else if (this.field_244.field_84 == 3) {
                              this.method_218(this.field_247[this.field_306], -this.field_231[this.method_244((byte)2)][3]);
                              this.method_241(this.field_306);
                           }

                           this.method_218(this.field_247[this.field_306], -1);
                           if (this.field_247[this.field_306].field_18 != 2 && this.field_247[this.field_306].field_18 != 8) {
                              if (this.field_247[this.field_306].field_18 == 6 && this.field_247[this.field_306].field_20 <= 0) {
                                 this.field_247[this.field_306].field_30 = this.field_222;
                                 this.method_263(this.field_247[this.field_306].field_10, this.field_247[this.field_306].field_11);
                              }
                           } else if (this.field_247[this.field_306].field_20 > 0) {
                              if (this.field_244.field_84 != 0) {
                                 this.method_92(this.field_247[this.field_306], 14);
                              }
                           } else if (this.field_247[this.field_306].field_20 <= 0) {
                              this.field_247[this.field_306].field_30 = this.field_222;
                              this.method_256(this.field_306);
                           }

                           this.method_221(0, this.field_247[this.field_306].field_10, this.field_247[this.field_306].field_11, 18, -16);
                        }

                        if (this.field_244.field_84 != 0) {
                           if (this.field_244.field_78.field_18 == 0) {
                              if (this.field_244.field_84 == 3) {
                                 this.method_221(
                                    13 + this.field_244.field_78.field_17, this.field_244.field_78.field_10, this.field_244.field_78.field_11, 0, 0
                                 );
                              } else {
                                 this.method_221(5 + this.field_244.field_78.field_17, this.field_244.field_78.field_10, this.field_244.field_78.field_11, 0, 0);
                              }
                           } else if (this.field_244.field_84 == 3) {
                              this.method_221(29 + this.field_244.field_78.field_17, this.field_244.field_78.field_10, this.field_244.field_78.field_11, 0, 0);
                           } else {
                              this.method_221(21 + this.field_244.field_78.field_17, this.field_244.field_78.field_10, this.field_244.field_78.field_11, 0, 0);
                           }
                        }

                        this.method_63((int)(this.field_222 - this.field_319));
                        if (this.field_244.field_84 != 0) {
                           this.method_92(this.field_244.field_78, 5);
                           if (!this.field_134) {
                              this.field_244.field_83[this.field_244.field_84]--;
                           }

                           this.field_226 = 900;
                        } else {
                           this.method_92(this.field_244.field_78, 7);
                           this.field_226 = 900;
                        }

                        if (this.field_244.field_84 != 5) {
                           this.field_236[this.field_244.field_84] = System.currentTimeMillis()
                              + (long)this.field_231[this.method_244((byte)0)][this.field_244.field_84];
                        }
                  }
               }
            case 647:
            case 904:
            default:
               break;
            case 900:
               if (((this.field_167 & 32) != 0 || (this.field_167 & 16384) != 0)
                  && this.field_244.field_78.field_22 == -1
                  && this.field_244.field_78.field_23 == -1) {
                  if (!this.field_244.field_90[this.field_244.field_84]) {
                     return;
                  }

                  if (!this.method_125()) {
                     return;
                  }

                  this.field_236[this.field_244.field_84] = this.field_222 + (long)this.field_231[this.method_244((byte)0)][this.field_244.field_84];
                  if (this.field_318 && this.field_244.field_84 != 0) {
                     if (this.field_244.field_83[this.field_244.field_84] <= 0) {
                        return;
                     }

                     int var3 = this.method_246(this.field_244.field_78);
                     if (var3 != -1 && this.field_244.field_84 != 4) {
                        this.method_247(this.field_244.field_78, this.field_247[var3].field_10, this.field_247[var3].field_11);
                        this.field_316 = true;
                        this.field_307 = this.field_247[var3].field_10;
                        this.field_308 = this.field_247[var3].field_11;
                        this.field_309 = this.field_222;
                        if (this.field_244.field_84 == 1 || this.field_244.field_84 == 2) {
                           this.method_92(this.field_244.field_78, 5);
                        } else if (this.field_244.field_84 == 3 || this.field_244.field_84 == 4) {
                           this.method_92(this.field_244.field_78, 6);
                        }

                        this.field_296++;
                        this.field_300++;
                        this.field_306 = var3;
                        this.field_226 = 646;
                        this.field_319 = this.field_222;
                        this.field_309 = 0L;
                        this.field_312 = 0;
                        this.field_313 = 65536;
                     } else {
                        this.field_296++;
                        this.field_300++;
                        if (this.field_244.field_84 != 4) {
                           if (this.field_244.field_78.field_18 == 0) {
                              if (this.field_244.field_84 == 3) {
                                 this.method_221(
                                    13 + this.field_244.field_78.field_17, this.field_244.field_78.field_10, this.field_244.field_78.field_11, 0, 0
                                 );
                              } else {
                                 this.method_221(5 + this.field_244.field_78.field_17, this.field_244.field_78.field_10, this.field_244.field_78.field_11, 0, 0);
                              }
                           } else if (this.field_244.field_84 == 3) {
                              this.method_221(29 + this.field_244.field_78.field_17, this.field_244.field_78.field_10, this.field_244.field_78.field_11, 0, 0);
                           } else {
                              this.method_221(21 + this.field_244.field_78.field_17, this.field_244.field_78.field_10, this.field_244.field_78.field_11, 0, 0);
                           }

                           this.field_298++;
                           this.method_92(this.field_244.field_78, 5);
                           if (!this.field_134) {
                              this.field_244.field_83[this.field_244.field_84]--;
                           }

                           this.field_226 = 900;
                        } else {
                           this.field_307 = this.method_252(this.field_244.field_78.field_10, this.field_244.field_78.field_17, 2);
                           this.field_308 = this.method_253(this.field_244.field_78.field_11, this.field_244.field_78.field_17, 2);
                           this.field_296++;
                           this.field_300++;
                           this.method_220(
                              4,
                              this.field_244.field_78.field_10,
                              this.field_244.field_78.field_11,
                              this.field_307,
                              this.field_308,
                              this.field_244.field_78.field_17
                           );
                           if (!this.field_134) {
                              this.field_244.field_83[this.field_244.field_84]--;
                           }

                           this.method_92(this.field_244.field_78, 6);
                           this.field_226 = 900;
                        }
                     }

                     return;
                  }

                  switch (this.field_244.field_84) {
                     case 0:
                        this.field_307 = this.field_244.field_78.field_10;
                        this.field_308 = this.field_244.field_78.field_11;
                        if (this.field_244.field_78.field_17 == 1) {
                           this.field_307++;
                        } else if (this.field_244.field_78.field_17 == 7) {
                           this.field_308++;
                        } else if (this.field_244.field_78.field_17 == 5) {
                           this.field_307--;
                        } else if (this.field_244.field_78.field_17 == 3) {
                           this.field_308--;
                        }

                        this.field_306 = this.method_254(this.field_307, this.field_308);
                        if (this.field_306 > 0) {
                           this.field_226 = 646;
                           this.field_319 = this.field_222;
                           this.field_309 = 0L;
                           this.field_312 = 0;
                           this.field_313 = 65536;
                        } else {
                           this.method_92(this.field_244.field_78, 7);
                        }
                        break;
                     default:
                        if (this.field_244.field_83[this.field_244.field_84] > 0) {
                           this.field_307 = this.field_244.field_78.field_10;
                           this.field_308 = this.field_244.field_78.field_11;
                           if (this.field_244.field_78.field_17 == 5
                              && this.field_307 - 1 >= 0
                              && this.field_267[this.field_307 - 1][this.field_308] == this.field_279) {
                              this.field_307--;
                           }

                           if (this.field_244.field_78.field_17 == 1
                              && this.field_307 + 1 < this.field_262
                              && this.field_267[this.field_307 + 1][this.field_308] == this.field_279) {
                              this.field_307++;
                           }

                           if (this.field_244.field_78.field_17 == 3
                              && this.field_308 - 1 >= 0
                              && this.field_267[this.field_307][this.field_308 - 1] == this.field_279) {
                              this.field_308--;
                           }

                           if (this.field_244.field_78.field_17 == 7
                              && this.field_308 + 1 < this.field_263
                              && this.field_267[this.field_307][this.field_308 + 1] == this.field_279) {
                              this.field_308++;
                           }

                           if (this.field_244.field_78.field_17 == 4
                              && this.field_307 - 1 >= 0
                              && this.field_308 - 1 >= 0
                              && this.field_267[this.field_307 - 1][this.field_308 - 1] == this.field_279) {
                              this.field_307--;
                              this.field_308--;
                           }

                           if (this.field_244.field_78.field_17 == 0
                              && this.field_307 + 1 < this.field_262
                              && this.field_308 + 1 < this.field_263
                              && this.field_267[this.field_307 + 1][this.field_308 + 1] == this.field_279) {
                              this.field_307++;
                              this.field_308++;
                           }

                           if (this.field_244.field_78.field_17 == 2
                              && this.field_307 + 1 < this.field_262
                              && this.field_308 - 1 >= 0
                              && this.field_267[this.field_307 + 1][this.field_308 - 1] == this.field_279) {
                              this.field_307++;
                              this.field_308--;
                           }

                           if (this.field_244.field_78.field_17 == 6
                              && this.field_307 - 1 >= 0
                              && this.field_308 + 1 < this.field_263
                              && this.field_267[this.field_307 - 1][this.field_308 + 1] == this.field_279) {
                              this.field_307--;
                              this.field_308++;
                           }

                           this.field_226 = 901;
                           this.field_309 = this.field_222;
                        }
                  }
               }
               break;
            case 901:
               switch (this.field_244.field_84) {
                  case 1:
                  case 2:
                  case 3:
                     if ((this.field_320 & 2) != 0) {
                        if (this.field_307 - 1 >= 0 && this.field_267[this.field_307 - 1][this.field_308] == this.field_279) {
                           this.field_307--;
                        }
                     } else if ((this.field_320 & 4) != 0) {
                        if (this.field_307 + 1 < this.field_262 && this.field_267[this.field_307 + 1][this.field_308] == this.field_279) {
                           this.field_307++;
                        }
                     } else if ((this.field_320 & 8) != 0) {
                        if (this.field_308 - 1 >= 0 && this.field_267[this.field_307][this.field_308 - 1] == this.field_279) {
                           this.field_308--;
                        }
                     } else if ((this.field_320 & 16) != 0) {
                        if (this.field_308 + 1 < this.field_263 && this.field_267[this.field_307][this.field_308 + 1] == this.field_279) {
                           this.field_308++;
                        }
                     } else if ((this.field_167 & 32) != 0) {
                        this.field_296++;
                        this.field_301++;
                        this.field_306 = this.method_254(this.field_307, this.field_308);
                        if (this.field_306 > 0) {
                           this.field_226 = 646;
                           this.field_319 = this.field_222;
                           this.field_309 = 0L;
                           this.field_312 = 0;
                           this.field_313 = 65536;
                        } else {
                           if (this.field_244.field_78.field_18 == 0) {
                              if (this.field_244.field_84 == 3) {
                                 this.method_221(
                                    13 + this.field_244.field_78.field_17, this.field_244.field_78.field_10, this.field_244.field_78.field_11, 0, 0
                                 );
                              } else {
                                 this.method_221(5 + this.field_244.field_78.field_17, this.field_244.field_78.field_10, this.field_244.field_78.field_11, 0, 0);
                              }
                           } else if (this.field_244.field_84 == 3) {
                              this.method_221(29 + this.field_244.field_78.field_17, this.field_244.field_78.field_10, this.field_244.field_78.field_11, 0, 0);
                           } else {
                              this.method_221(21 + this.field_244.field_78.field_17, this.field_244.field_78.field_10, this.field_244.field_78.field_11, 0, 0);
                           }

                           this.field_298++;
                           this.method_92(this.field_244.field_78, 5);
                           if (!this.field_134) {
                              this.field_244.field_83[this.field_244.field_84]--;
                           }

                           this.field_226 = 900;
                        }
                     }

                     var1 = this.field_307 - this.field_244.field_78.field_10;
                     var2 = this.field_308 - this.field_244.field_78.field_11;
                     break;
                  case 4:
                     if ((this.field_320 & 2) != 0) {
                        if (this.field_307 - 1 >= 0 && this.field_267[this.field_307 - 1][this.field_308] == this.field_279) {
                           this.field_307--;
                        }
                     } else if ((this.field_320 & 4) != 0) {
                        if (this.field_307 + 1 < this.field_262 && this.field_267[this.field_307 + 1][this.field_308] == this.field_279) {
                           this.field_307++;
                        }
                     } else if ((this.field_320 & 8) != 0) {
                        if (this.field_308 - 1 >= 0 && this.field_267[this.field_307][this.field_308 - 1] == this.field_279) {
                           this.field_308--;
                        }
                     } else if ((this.field_320 & 16) != 0) {
                        if (this.field_308 + 1 < this.field_263 && this.field_267[this.field_307][this.field_308 + 1] == this.field_279) {
                           this.field_308++;
                        }
                     } else if ((this.field_167 & 32) != 0) {
                        this.field_296++;
                        this.field_301++;
                        this.method_220(
                           4,
                           this.field_244.field_78.field_10,
                           this.field_244.field_78.field_11,
                           this.field_307,
                           this.field_308,
                           this.field_244.field_78.field_17
                        );
                        if (!this.field_134) {
                           this.field_244.field_83[this.field_244.field_84]--;
                        }

                        this.method_92(this.field_244.field_78, 6);
                        this.field_226 = 900;
                     }

                     var1 = this.field_307 - this.field_244.field_78.field_10;
                     var2 = this.field_308 - this.field_244.field_78.field_11;
               }

               if (var1 == 0 && var2 == 0) {
                  this.method_93(this.field_244.field_78, 0);
               } else if (Math.abs(var2) * 2 <= Math.abs(var1)) {
                  if (var1 <= 0) {
                     this.method_93(this.field_244.field_78, 5);
                  } else {
                     this.method_93(this.field_244.field_78, 1);
                  }
               } else if (Math.abs(var2) <= Math.abs(var1) * 2) {
                  if (var1 <= 0 && var2 <= 0) {
                     this.method_93(this.field_244.field_78, 4);
                  } else if (var1 <= 0) {
                     this.method_93(this.field_244.field_78, 6);
                  } else if (var2 <= 0) {
                     this.method_93(this.field_244.field_78, 2);
                  } else {
                     this.method_93(this.field_244.field_78, 0);
                  }
               } else if (var2 <= 0) {
                  this.method_93(this.field_244.field_78, 3);
               } else {
                  this.method_93(this.field_244.field_78, 7);
               }
         }
      }
   }

   // $VF: renamed from: b (byte) byte
   private byte method_244(byte var1) {
      byte var2 = 0;
      byte var3 = 0;
      switch (var1) {
         case 0:
            var3 = this.field_232[this.field_244.field_84][0];
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
            var3 = this.field_232[this.field_244.field_84][1];
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
            var3 = this.field_232[this.field_244.field_84][2];
            if (var3 == 0) {
               var2 = 2;
            } else if (var3 == 1) {
               var2 = 6;
            } else if (var3 == 2) {
               var2 = 10;
            } else if (var3 == 3) {
               var2 = 14;
            }
      }

      return var2;
   }

   // $VF: renamed from: aP () byte
   private byte method_245() {
      byte var1 = 0;
      byte var2 = 0;
      if (this.field_399 != null) {
         var1 = this.field_232[this.field_399[this.field_234]][this.field_235];
      }

      switch (var1) {
         case 0:
            var2 = 3;
            break;
         case 1:
            var2 = 7;
            break;
         case 2:
            var2 = 11;
      }

      return var2;
   }

   // $VF: renamed from: e (u) int
   int method_246(class_4 var1) {
      int var2 = -1;
      int var5 = var1.field_10;
      int var6 = var1.field_11;
      byte var9 = var1.field_17;
      int var10 = this.method_233(0, var5, var6, false);
      if (var10 != -1 && var10 != 2) {
         return var10;
      } else {
         for (int var3 = 1; var3 < 4; var3++) {
            var5 = this.method_252(var5, var9, 1);
            var6 = this.method_253(var6, var9, 1);
            var10 = this.method_233(0, var5, var6, false);
            if (var10 != -1 && var10 != 2) {
               return var10;
            }

            for (int var4 = 0; var4 < var3; var4++) {
               int var7 = this.method_248(var5, var9, var4 + 1);
               int var8 = this.method_249(var6, var9, var4 + 1);
               var2 = this.method_233(0, var7, var8, false);
               if (var2 != -1 && var2 != 2) {
                  return var2;
               }

               var7 = this.method_250(var5, var9, var4 + 1);
               var8 = this.method_251(var6, var9, var4 + 1);
               var10 = this.method_233(0, var7, var8, false);
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
   void method_247(class_4 var1, int var2, int var3) {
      int var4 = var2 - var1.field_10;
      int var5 = var3 - var1.field_11;
      if (var4 == 0 && var5 == 0) {
         this.method_93(var1, 0);
      } else if (Math.abs(var5) * 2 <= Math.abs(var4)) {
         if (var4 <= 0) {
            this.method_93(var1, 5);
         } else {
            this.method_93(var1, 1);
         }
      } else if (Math.abs(var5) <= Math.abs(var4) * 2) {
         if (var4 <= 0 && var5 <= 0) {
            this.method_93(var1, 4);
         } else if (var4 <= 0) {
            this.method_93(var1, 6);
         } else if (var5 <= 0) {
            this.method_93(var1, 2);
         } else {
            this.method_93(var1, 0);
         }
      } else if (var5 <= 0) {
         this.method_93(var1, 3);
      } else {
         this.method_93(var1, 7);
      }
   }

   // $VF: renamed from: c (int, int, int) int
   int method_248(int var1, int var2, int var3) {
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
   int method_249(int var1, int var2, int var3) {
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
   int method_250(int var1, int var2, int var3) {
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
   int method_251(int var1, int var2, int var3) {
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
   int method_252(int var1, int var2, int var3) {
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
   int method_253(int var1, int var2, int var3) {
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
   int method_254(int var1, int var2) {
      for (int var3 = 0; var3 < 24; var3++) {
         if (this.field_247[var3].field_9
            && this.field_247[var3].field_14 != 3
            && this.field_247[var3].field_14 != 4
            && field_241[this.field_247[var3].field_18][0] != 0
            && this.field_247[var3].field_10 == var1
            && this.field_247[var3].field_11 == var2) {
            return var3;
         }
      }

      return -1;
   }

   // $VF: renamed from: L () boolean
   boolean method_255() {
      boolean var5 = false;
      byte var1 = this.field_244.field_78.field_10;
      byte var2 = this.field_244.field_78.field_11;
      int var3 = var1;
      int var4 = var2;
      if (this.field_244.field_78.field_17 == 1) {
         var3 = var1 + 1;
      } else if (this.field_244.field_78.field_17 == 3) {
         var4 = var2 - 1;
      } else if (this.field_244.field_78.field_17 == 5) {
         var3 = var1 - 1;
      } else if (this.field_244.field_78.field_17 == 7) {
         var4 = var2 + 1;
      }

      if (this.field_326.field_35 == var3 && this.field_326.field_36 == var4 && this.field_326.field_38) {
         this.method_267();
         var5 = true;
      } else if (this.field_331.field_35 == var3 && this.field_331.field_36 == var4 && this.field_331.field_38) {
         this.method_260();
         var5 = true;
      } else if (this.field_336.field_35 == var3 && this.field_336.field_36 == var4 && this.field_336.field_38) {
         this.method_259();
         var5 = true;
      }

      return var5;
   }

   // $VF: renamed from: q (int) void
   private void method_256(int var1) {
      if (!this.method_257(var1) && !this.method_265(var1) && !this.method_261(var1)) {
      }
   }

   // $VF: renamed from: r (int) boolean
   private boolean method_257(int var1) {
      if (this.field_347 != 2) {
         return false;
      } else if (this.field_350 < 5) {
         return false;
      } else if (method_144(100) < 3 + this.field_338) {
         this.method_258(this.field_247[var1].field_10, this.field_247[var1].field_11);
         this.field_338 = 0;
         return true;
      } else {
         if (this.field_244.field_90[3] && this.field_244.field_90[2] && this.field_244.field_90[4]) {
            if (this.field_350 % 3 == 0) {
               this.field_338++;
            }
         } else if (this.field_350 % 2 == 0) {
            this.field_338++;
         }

         return false;
      }
   }

   // $VF: renamed from: b (byte, byte) boolean
   private boolean method_258(byte var1, byte var2) {
      if (!this.field_336.field_38) {
         this.field_336.field_35 = var1;
         this.field_336.field_36 = var2;
         this.field_336.field_38 = true;
         return true;
      } else {
         return false;
      }
   }

   // $VF: renamed from: aQ () void
   private void method_259() {
      this.field_336.field_38 = false;
      if (!this.field_244.field_90[0]) {
         this.field_244.field_90[0] = true;
         if (this.field_244.field_84 == 127) {
            this.method_239(0);
         }
      } else if (!this.field_244.field_90[1]) {
         this.field_244.field_90[1] = true;
         this.field_244.field_83[1] = 10;
         if (this.field_244.field_84 == 127) {
            this.method_239(1);
         }
      } else if (!this.field_244.field_90[3]) {
         this.field_244.field_90[3] = true;
         this.field_244.field_83[3] = 10;
         if (this.field_244.field_84 == 127) {
            this.method_239(3);
         }
      } else if (!this.field_244.field_90[2]) {
         this.field_244.field_90[2] = true;
         this.field_244.field_83[2] = 5;
         if (this.field_244.field_84 == 127) {
            this.method_239(2);
         }
      } else if (!this.field_244.field_90[4]) {
         this.field_244.field_90[4] = true;
         this.field_244.field_83[4] = 2;
         if (this.field_244.field_84 == 127) {
            this.method_239(4);
         }
      } else {
         this.field_244.field_83[1] = (byte)(this.field_244.field_83[1] + 10);
         this.field_244.field_83[3] = (byte)(this.field_244.field_83[3] + 5);
         this.field_244.field_83[2] = (byte)(this.field_244.field_83[2] + 2);
         this.field_244.field_83[4]++;
      }

      if (this.field_244.field_83[1] > this.field_233[1]) {
         this.field_244.field_83[1] = this.field_233[1];
      }

      if (this.field_244.field_83[3] > this.field_233[3]) {
         this.field_244.field_83[3] = this.field_233[3];
      }

      if (this.field_244.field_83[2] > this.field_233[2]) {
         this.field_244.field_83[2] = this.field_233[2];
      }

      if (this.field_244.field_83[4] > this.field_233[4]) {
         this.field_244.field_83[4] = this.field_233[4];
      }
   }

   // $VF: renamed from: aR () void
   private void method_260() {
      this.field_331.field_38 = false;
      if (this.field_244.field_83[this.field_244.field_84] < 99) {
         switch (this.field_244.field_84) {
            case 1:
               this.field_244.field_83[this.field_244.field_84] = (byte)(this.field_244.field_83[this.field_244.field_84] + 10);
               if (this.field_244.field_90[2]) {
                  this.field_244.field_83[2]++;
               }

               if (this.field_244.field_90[3]) {
                  this.field_244.field_83[3] = (byte)(this.field_244.field_83[3] + 2);
               }

               if (this.field_244.field_90[4]) {
                  this.field_244.field_83[4]++;
               }
               break;
            case 2:
               this.field_244.field_83[this.field_244.field_84] = (byte)(this.field_244.field_83[this.field_244.field_84] + 2);
               if (this.field_244.field_90[1]) {
                  this.field_244.field_83[1] = (byte)(this.field_244.field_83[1] + 3);
               }

               if (this.field_244.field_90[3]) {
                  this.field_244.field_83[3] = (byte)(this.field_244.field_83[3] + 2);
               }

               if (this.field_244.field_90[4]) {
                  this.field_244.field_83[4]++;
               }
               break;
            case 3:
               this.field_244.field_83[this.field_244.field_84] = (byte)(this.field_244.field_83[this.field_244.field_84] + 5);
               if (this.field_244.field_90[1]) {
                  this.field_244.field_83[1] = (byte)(this.field_244.field_83[1] + 3);
               }

               if (this.field_244.field_90[2]) {
                  this.field_244.field_83[2]++;
               }

               if (this.field_244.field_90[4]) {
                  this.field_244.field_83[4]++;
               }
               break;
            case 4:
               this.field_244.field_83[this.field_244.field_84]++;
               if (this.field_244.field_90[1]) {
                  this.field_244.field_83[1] = (byte)(this.field_244.field_83[1] + 3);
               }

               if (this.field_244.field_90[2]) {
                  this.field_244.field_83[2]++;
               }

               if (this.field_244.field_90[3]) {
                  this.field_244.field_83[3] = (byte)(this.field_244.field_83[3] + 2);
               }
               break;
            default:
               this.field_244.field_83[1] = (byte)(this.field_244.field_83[1] + 10);
               if (this.field_244.field_90[2]) {
                  this.field_244.field_83[2]++;
               }

               if (this.field_244.field_90[3]) {
                  this.field_244.field_83[3] = (byte)(this.field_244.field_83[3] + 2);
               }

               if (this.field_244.field_90[4]) {
                  this.field_244.field_83[4]++;
               }
         }

         if (this.field_244.field_83[1] > this.field_233[1]) {
            this.field_244.field_83[1] = this.field_233[1];
         }

         if (this.field_244.field_83[3] > this.field_233[3]) {
            this.field_244.field_83[3] = this.field_233[3];
         }

         if (this.field_244.field_83[2] > this.field_233[2]) {
            this.field_244.field_83[2] = this.field_233[2];
         }

         if (this.field_244.field_83[4] > this.field_233[4]) {
            this.field_244.field_83[4] = this.field_233[4];
         }
      }
   }

   // $VF: renamed from: s (int) boolean
   private boolean method_261(int var1) {
      if (this.field_347 != 0 || !this.method_74(16) && !this.method_74(32)) {
         this.field_333 = (byte)(this.field_333 + 2);
         if (this.field_247[var1].field_18 == 6 || this.field_247[var1].field_18 == 8) {
            this.field_333 = (byte)(this.field_333 + 2);
         }

         if (this.method_262() && 22 + this.field_333 < 50) {
            this.field_333 = 28;
         }

         if (method_144(100) < 22 + this.field_333) {
            this.method_263(this.field_247[var1].field_10, this.field_247[var1].field_11);
            this.field_333 = 0;
            return true;
         } else {
            return false;
         }
      } else {
         return false;
      }
   }

   // $VF: renamed from: aS () boolean
   private boolean method_262() {
      return this.field_244.field_83[1] <= 7 && this.field_244.field_83[2] <= 5 && this.field_244.field_83[3] <= 5;
   }

   // $VF: renamed from: c (byte, byte) boolean
   private boolean method_263(byte var1, byte var2) {
      if (!this.field_331.field_38) {
         this.field_331.field_35 = var1;
         this.field_331.field_36 = var2;
         this.field_331.field_38 = true;
         return true;
      } else {
         return false;
      }
   }

   // $VF: renamed from: d (byte, byte) boolean
   private boolean method_264(byte var1, byte var2) {
      if (!this.field_326.field_38) {
         this.field_326.field_35 = var1;
         this.field_326.field_36 = var2;
         this.field_326.field_38 = true;
         return true;
      } else {
         return false;
      }
   }

   // $VF: renamed from: t (int) boolean
   private boolean method_265(int var1) {
      if (this.field_347 != 0 || !this.method_74(8) && !this.method_74(512)) {
         if (this.field_244.field_78.field_20 < 4) {
            this.field_328 = 10;
         } else {
            this.field_328 = 0;
         }

         if (method_144(100) < 5 + this.field_328) {
            this.method_264(this.field_247[var1].field_10, this.field_247[var1].field_11);
            return true;
         } else {
            return false;
         }
      } else {
         return false;
      }
   }

   // $VF: renamed from: M () void
   void method_266() {
      if (this.field_244.field_83[5] > 0) {
         if (this.field_244.field_78.field_20 != this.field_244.field_78.field_21) {
            this.method_218(this.field_244.field_78, this.field_244.field_78.field_21);
            this.field_244.field_83[5]--;
         }
      }
   }

   // $VF: renamed from: aT () void
   private void method_267() {
      this.field_326.field_38 = false;
      if (this.field_244.field_84 == 127) {
         this.method_239(5);
      }

      this.field_244.field_90[5] = true;
      if (this.field_244.field_83[5] >= 3) {
         this.method_218(this.field_244.field_78, this.field_244.field_78.field_21);
      } else {
         this.field_244.field_83[5]++;
      }
   }

   // $VF: renamed from: aU () void
   private void method_268() {
      try {
         this.field_140 = new class_15(1, 2, 1);
         byte[] var1 = new byte[]{0, 0};
         byte[] var2 = new byte[]{0, 0};
         byte[] var3 = new byte[]{0, 1};
         byte[] var4 = new byte[]{1, 1};
         byte[] var5 = new byte[]{100, 100};
         this.field_140.method_11(var1, var3, var2, var4);
         this.field_140.method_12(var5);
         this.field_140.method_13(this.field_146[5]);
      } catch (Exception var6) {
      }
   }

   // $VF: renamed from: m (int, int) void
   private void method_269(int var1, int var2) {
      if (this.field_140 != null) {
         if (var1 >= 0) {
            if (this.field_145 > 0) {
               if ((var2 & 1) != 0) {
                  this.field_140.method_18((byte)var1);
               }

               if ((var2 & 4) != 0) {
                  this.field_140.method_15((byte)var1);
               } else {
                  this.field_140.method_14((byte)var1);
               }
            }
         }
      }
   }

   // $VF: renamed from: N () void
   public void method_270() {
      if (this.field_140 != null) {
         this.field_140.method_17();
      }
   }

   // $VF: renamed from: c (byte) void
   private void method_271(byte var1) {
      boolean var4 = false;
      switch (var1) {
         case 0:
            class_25.method_328(var1, 0, this.field_158);
            break;
         case 1:
            class_25.method_328(var1, 0, this.field_145);
            break;
         case 2:
            int var9 = 0;
            class_25.method_329(var1, var9, this.field_296);
            class_25.method_329(var1, ++var9, this.field_297);
            class_25.method_329(var1, ++var9, this.field_298);
            class_25.method_329(var1, ++var9, this.field_299);
            class_25.method_329(var1, ++var9, this.field_354);
            class_25.method_328(var1, ++var9, this.field_244.field_84);
            class_25.method_328(var1, ++var9, this.field_244.field_78.field_20);
            class_25.method_329(var1, ++var9, this.field_364);
            var9++;

            for (int var5 = 0; var5 < 6; var5++) {
               class_25.method_327(var1, var9, this.field_244.field_90[var5]);
               var9++;
            }

            for (int var6 = 0; var6 < 6; var6++) {
               class_25.method_328(var1, var9, this.field_244.field_83[var6]);
               var9++;
            }

            for (int var7 = 0; var7 < this.field_232.length; var7++) {
               for (int var3 = 0; var3 < this.field_232[var7].length; var3++) {
                  class_25.method_328(var1, var9, this.field_232[var7][var3]);
                  var9++;
               }
            }

            class_25.method_328(var1, var9, this.field_359);
            class_25.method_328(var1, ++var9, this.field_356);
            class_25.method_329(var1, ++var9, this.field_355);
            class_25.method_328(var1, ++var9, this.field_238);
            class_25.method_328(var1, ++var9, this.field_360);
            method_274("indexOffset waves: " + ++var9);
            break;
         case 3:
            int var8 = 0;

            for (int var2 = 0; var2 < this.field_380.length; var2++) {
               class_25.method_327(var1, var8, this.field_380[var2]);
               var8++;
            }
      }

      class_25.method_334(var1, field_207[var1]);
   }

   // $VF: renamed from: d (byte) void
   private void method_272(byte var1) {
      boolean var4 = false;
      switch (var1) {
         case 0:
            if (class_25.method_333(var1, field_207[var1])) {
               this.field_158 = class_25.method_331(var1, 0);
            } else {
               this.field_158 = -1;
            }
            break;
         case 1:
            if (class_25.method_333(var1, field_207[var1])) {
               this.field_145 = class_25.method_331(var1, 0);
            } else {
               this.field_145 = 1;
            }
            break;
         case 2:
            if (class_25.method_333(var1, field_207[var1])) {
               int var9 = 0;
               this.field_296 = class_25.method_332(var1, var9);
               this.field_297 = class_25.method_332(var1, ++var9);
               this.field_298 = class_25.method_332(var1, ++var9);
               this.field_299 = class_25.method_332(var1, ++var9);
               this.field_354 = class_25.method_332(var1, ++var9);
               this.field_244.field_84 = class_25.method_331(var1, ++var9);
               this.field_244.field_78.field_20 = class_25.method_331(var1, ++var9);
               this.field_364 = class_25.method_332(var1, ++var9);
               var9++;

               for (int var5 = 0; var5 < 6; var5++) {
                  this.field_244.field_90[var5] = class_25.method_330(var1, var9);
                  var9++;
               }

               for (int var6 = 0; var6 < 6; var6++) {
                  this.field_244.field_83[var6] = class_25.method_331(var1, var9);
                  var9++;
               }

               for (int var7 = 0; var7 < this.field_232.length; var7++) {
                  for (int var3 = 0; var3 < this.field_232[var7].length; var3++) {
                     this.field_232[var7][var3] = class_25.method_331(var1, var9);
                     var9++;
                  }
               }

               this.field_359 = class_25.method_331(var1, var9);
               this.field_356 = class_25.method_331(var1, ++var9);
               this.field_355 = class_25.method_332(var1, ++var9);
               this.field_238 = class_25.method_331(var1, ++var9);
               this.field_360 = class_25.method_331(var1, ++var9);
               var9++;
            } else {
               this.field_296 = 0;
               this.field_297 = 0;
               this.field_298 = 0;
               this.field_299 = 0;
               this.field_354 = 0;
               this.field_360 = 0;
            }
            break;
         case 3:
            int var8 = 0;
            if (class_25.method_333(var1, field_207[var1])) {
               for (int var2 = 0; var2 < this.field_380.length; var2++) {
                  this.field_380[var2] = class_25.method_330(var1, var8);
                  var8++;
               }
            }
      }
   }

   // $VF: renamed from: b (byte, boolean) void
   private void method_273(byte var1, boolean var2) {
      switch (var1) {
         case 2:
            if (class_25.method_333(2, field_207[2])) {
               this.field_296 = 0;
               this.field_297 = 0;
               this.field_298 = 0;
               this.field_299 = 0;
               this.field_354 = 0;
               this.field_244.field_84 = 1;
               this.field_244.field_78.field_20 = 16;
               this.field_364 = 0;

               for (int var3 = 0; var3 < 6; var3++) {
                  this.field_244.field_90[var3] = false;
               }

               this.field_244.field_90[0] = true;
               this.field_244.field_90[5] = true;
               this.field_244.field_90[1] = true;
               this.field_245.field_81 = 0;
               this.field_245.field_84 = 1;
               this.field_245.field_83[0] = 0;
               this.field_245.field_83[1] = 25;
               this.field_245.field_83[2] = 0;
               this.field_245.field_83[3] = 0;
               this.field_245.field_83[4] = 0;
               this.field_245.field_83[5] = 1;
               this.method_75();
               this.field_359 = 0;
               this.field_356 = 0;
               this.field_355 = 0;
               this.field_238 = 2;
               this.field_360 = 0;
               this.method_271((byte)2);
            }
            break;
         case 3:
            if (class_25.method_333(3, field_207[3])) {
               this.method_183();
               this.field_376 = 1;
               this.method_271((byte)3);
            }
      }

      System.gc();
   }

   // $VF: renamed from: b (java.lang.String) void
   public static void method_274(String var0) {
   }

   // $VF: renamed from: a (long) void
   public void method_275(long var1) {
      try {
         Thread.sleep(var1);
      } catch (Exception var4) {
      }
   }

   // $VF: renamed from: l (int) int
   static int method_276(int var0) {
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
}
