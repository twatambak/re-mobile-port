// Transpiled from Java (class_27.java) by Tools/J2meToCs. Regenerate rather than hand-edit where possible.
#pragma warning disable CS0162, CS0164, CS0168, CS0169, CS0219, CS0414, CS0649, CS1717, CS0108, CS0659, CS0661
using J2ME;
using static REUprising.Gameloft.AnimationTables;

namespace REUprising.Gameloft
{
// $VF: renamed from: f
public class GameCanvas : Canvas, Runnable {
   static GameCanvas() { }

   // $VF: renamed from: s int
   public int gameIntegerValue01;
   // $VF: renamed from: t int
   public int gameIntegerValue02;
   // $VF: renamed from: u int
   public int gameIntegerValue03;
   // $VF: renamed from: v int
   public int gameIntegerValue04;
   // $VF: renamed from: w int
   public int gameIntegerValue05;
   // $VF: renamed from: A boolean
   public bool gameBooleanFlag01;
   // $VF: renamed from: B boolean
   public bool gameBooleanFlag02;
   // $VF: renamed from: a boolean
   public bool gameBooleanFlag03;
   // $VF: renamed from: a java.lang.String
   public string gameTextValue01;
   // $VF: renamed from: C boolean
   public static bool gameBooleanFlag04 = false;
   // $VF: renamed from: D boolean
   public static bool gameBooleanFlag05 = false;
   // $VF: renamed from: E boolean
   public static bool gameBooleanFlag06 = true;
   // $VF: renamed from: F boolean
   public static bool gameBooleanFlag07 = true;
   // $VF: renamed from: d int[]
   public static int[] gameIntegerArray01;
   // $VF: renamed from: x int
   public static int gameIntegerValue06;
   // $VF: renamed from: y int
   public static int gameIntegerValue07;
   // $VF: renamed from: z int
   public static int gameIntegerValue08;
   // $VF: renamed from: A int
   public static int gameIntegerValue09;
   // $VF: renamed from: B int
   public static int gameIntegerValue10;
   // $VF: renamed from: C int
   public static int gameIntegerValue11;
   // $VF: renamed from: D int
   public static int gameIntegerValue12;
   // $VF: renamed from: E int
   public static int gameIntegerValue13;
   // $VF: renamed from: F int
   public static int gameIntegerValue14;
   // $VF: renamed from: G int
   public static int gameIntegerValue15;
   // $VF: renamed from: H int
   public static int gameIntegerValue16;
   // $VF: renamed from: I int
   public static int gameIntegerValue17 = 0;
   // $VF: renamed from: J int
   public static int gameIntegerValue18 = -1;
   // $VF: renamed from: K int
   public static int gameIntegerValue19 = -1;
   // $VF: renamed from: L int
   public static int gameIntegerValue20 = 1;
   // $VF: renamed from: G boolean
   public static bool gameBooleanFlag08 = false;
   // $VF: renamed from: H boolean
   public static bool gameBooleanFlag09 = false;
   // $VF: renamed from: M int
   public static int gameIntegerValue21 = 0;
   // $VF: renamed from: N int
   public static int gameIntegerValue22 = 0;
   // $VF: renamed from: O int
   public static int gameIntegerValue23 = -1;
   // $VF: renamed from: P int
   public static int gameIntegerValue24 = 0;
   // $VF: renamed from: Q int
   public static int gameIntegerValue25 = -1;
   // $VF: renamed from: R int
   public static int gameIntegerValue26 = -1;
   // $VF: renamed from: a javax.microedition.media.Player[]
   public static Player[] gamePlayerReferenceArray01;
   // $VF: renamed from: a java.io.ByteArrayInputStream[]
   public static ByteArrayInputStream[] gameByteStreamReferenceArray01;
   // $VF: renamed from: c java.lang.String[]
   public static string[] gameTextArray01;
   // $VF: renamed from: a javax.microedition.media.Player
   public static Player gamePlayerReference01;
   // $VF: renamed from: c long
   public static long gameLongValue01;
   // $VF: renamed from: S int
   public static int gameIntegerValue27 = 0;
   // $VF: renamed from: b java.lang.String
   public static string gameTextValue02;
   // $VF: renamed from: a short[]
   public static short[] gameShortArray01;
   // $VF: renamed from: I boolean
   public static bool gameBooleanFlag10 = false;
   // $VF: renamed from: J boolean
   public static bool gameBooleanFlag11 = false;
   // $VF: renamed from: d long
   public static long gameLongValue02 = 0L;
   // $VF: renamed from: K boolean
   public static bool gameBooleanFlag12 = false;
   // $VF: renamed from: L boolean
   public static bool gameBooleanFlag13 = false;
   // $VF: renamed from: M boolean
   public static bool gameBooleanFlag14 = false;
   // $VF: renamed from: N boolean
   public static bool gameBooleanFlag15 = false;
   // $VF: renamed from: O boolean
   public static bool gameBooleanFlag16 = false;
   // $VF: renamed from: P boolean
   public static bool gameBooleanFlag17 = false;
   // $VF: renamed from: T int
   public static int gameIntegerValue28 = -1;
   // $VF: renamed from: e long
   public static long gameLongValue03 = -1L;
   // $VF: renamed from: Q boolean
   public static bool gameBooleanFlag18 = false;
   // $VF: renamed from: R boolean
   public static bool gameBooleanFlag19 = false;
   // $VF: renamed from: U int
   public static int gameIntegerValue29 = 0;
   // $VF: renamed from: V int
   public static int gameIntegerValue30 = 0;
   // $VF: renamed from: a java.util.Vector
   public static Vector gameCollectionReference01 = new Vector(10);
   // $VF: renamed from: b java.util.Vector
   public static Vector gameCollectionReference02 = new Vector(2);
   // $VF: renamed from: a y
   public static RectangleBounds gameRectangleBoundsReference01 = null;
   // $VF: renamed from: b y
   public static RectangleBounds gameRectangleBoundsReference02 = null;
   // $VF: renamed from: W int
   public static int gameIntegerValue31;
   // $VF: renamed from: X int
   public static int gameIntegerValue32;
   // $VF: renamed from: S boolean
   public static bool gameBooleanFlag20;
   // $VF: renamed from: f long
   public static long gameLongValue04 = 0L;
   // $VF: renamed from: T boolean
   public static bool gameBooleanFlag21 = false;
   // $VF: renamed from: Y int
   public int gameIntegerValue33;
   // $VF: renamed from: b boolean
   public static bool gameBooleanFlag22;
   // $VF: renamed from: Z int
   public static int gameIntegerValue34;
   // $VF: renamed from: aa int
   public static int gameIntegerValue35;
   // $VF: renamed from: ab int
   public static int gameIntegerValue36;
   // $VF: renamed from: ac int
   public static int gameIntegerValue37 = gameIntegerValue36 = 40 * GameCanvas.screenWidth / 240;
   // $VF: renamed from: ad int
   public static int gameIntegerValue38 = 40 * GameCanvas.screenWidth / 240;
   // $VF: renamed from: a byte[][][]
   public static sbyte[][][] gameByteCube01 = null;
   // $VF: renamed from: e int[][]
   public static int[][] gameIntegerMatrix01 = null;
   // $VF: renamed from: c int[]
   public static int[] gameIntegerArray02 = new int[]{1, 2, 3, 4, 5, 6};
   // $VF: renamed from: a g[]
   public static SpriteResourceDecoder[] gameSpriteDecoderReferenceArray01 = new SpriteResourceDecoder[3];
   // $VF: renamed from: b g[]
   public static SpriteResourceDecoder[] gameSpriteDecoderReferenceArray02 = new SpriteResourceDecoder[12];
   // $VF: renamed from: c g[]
   public static SpriteResourceDecoder[] gameSpriteDecoderReferenceArray03 = new SpriteResourceDecoder[2];
   // $VF: renamed from: d g[]
   public static SpriteResourceDecoder[] gameSpriteDecoderReferenceArray04 = new SpriteResourceDecoder[11];
   // $VF: renamed from: e g[]
   public static SpriteResourceDecoder[] gameSpriteDecoderReferenceArray05 = new SpriteResourceDecoder[5];
   // $VF: renamed from: f g[]
   public static SpriteResourceDecoder[] gameSpriteDecoderReferenceArray06 = new SpriteResourceDecoder[5];
   // $VF: renamed from: g g[]
   public static SpriteResourceDecoder[] gameSpriteDecoderReferenceArray07 = new SpriteResourceDecoder[4];
   // $VF: renamed from: h g[]
   public static SpriteResourceDecoder[] gameSpriteDecoderReferenceArray08 = new SpriteResourceDecoder[2];
   // $VF: renamed from: a g
   public static SpriteResourceDecoder gameSpriteDecoderReference01;
   // $VF: renamed from: a v
   public static SpriteAnimation gameClass11Reference01 = null;
   // $VF: renamed from: c boolean
   public static bool gameBooleanFlag23 = false;
   // $VF: renamed from: b v
   public static SpriteAnimation gameClass11Reference02 = null;
   // $VF: renamed from: i g[]
   public static SpriteResourceDecoder[] gameSpriteDecoderReferenceArray09 = new SpriteResourceDecoder[2];
   // $VF: renamed from: c v
   public static SpriteAnimation gameClass11Reference03 = null;
   // $VF: renamed from: d boolean
   public static bool gameBooleanFlag24 = false;
   // $VF: renamed from: U boolean
   public static bool gameBooleanFlag25 = false;
   // $VF: renamed from: a javax.microedition.lcdui.Image
   public static Image gameImageReference01 = null;
   // $VF: renamed from: ae int
   public static int gameIntegerValue39 = 0;
   // $VF: renamed from: g long
   public static long gameLongValue05 = 0L;
   // $VF: renamed from: V boolean
   public static bool gameBooleanFlag26 = false;
   // $VF: renamed from: af int
   public static int gameIntegerValue40 = 0;
   // $VF: renamed from: W boolean
   public static bool gameBooleanFlag27 = false;
   // $VF: renamed from: a GloftRESE
   public static GloftRESE gameGloftRESEReference01;
   // $VF: renamed from: b javax.microedition.lcdui.Graphics
   public Graphics gameGraphicsReference01;
   // $VF: renamed from: ag int
   public static int gameIntegerValue41;
   // $VF: renamed from: ah int
   public static int gameIntegerValue42;
   // $VF: renamed from: c int
   public static int gameIntegerValue43;
   // $VF: renamed from: d int
   public static int gameIntegerValue44;
   // $VF: renamed from: ai int
   public static int gameIntegerValue45;
   // $VF: renamed from: X boolean
   public bool gameBooleanFlag28;
   // $VF: renamed from: a long
   public long gameLongValue06;
   // $VF: renamed from: aj int
   public int gameIntegerValue46;
   // $VF: renamed from: ak int
   public int gameIntegerValue47;
   // $VF: renamed from: a java.util.Random
   public Random gameRandomReference01;
   // $VF: renamed from: p byte
   public sbyte gameByteValue01;
   // $VF: renamed from: q byte
   public sbyte gameByteValue02;
   // $VF: renamed from: Y boolean
   public static bool gameBooleanFlag29;
   // $VF: renamed from: Z boolean
   public bool gameBooleanFlag30;
   // $VF: renamed from: aa boolean
   public bool gameBooleanFlag31;
   // $VF: renamed from: ab boolean
   public bool gameBooleanFlag32;
   // $VF: renamed from: ac boolean
   public bool gameBooleanFlag33;
   // $VF: renamed from: e boolean
   public bool gameBooleanFlag34;
   // $VF: renamed from: f boolean
   public bool gameBooleanFlag35;
   // $VF: renamed from: a aa
   public ActorGroup gameActorGroupReference01;
   // $VF: renamed from: b aa
   public ActorGroup gameActorGroupReference02;
   // $VF: renamed from: c aa
   public ActorGroup gameActorGroupReference03;
   // $VF: renamed from: d aa
   public ActorGroup gameActorGroupReference04;
   // $VF: renamed from: a byte
   public sbyte gameByteValue03;
   // $VF: renamed from: al int
   public static int gameIntegerValue48;
   // $VF: renamed from: am int
   public int gameIntegerValue49;
   // $VF: renamed from: e int
   public static int gameIntegerValue50;
   // $VF: renamed from: an int
   public int gameIntegerValue51;
   // $VF: renamed from: ao int
   public int gameIntegerValue52;
   // $VF: renamed from: ap int
   public int gameIntegerValue53;
   // $VF: renamed from: aq int
   public int gameIntegerValue54;
   // $VF: renamed from: ar int
   public int gameIntegerValue55;
   // $VF: renamed from: as int
   public int gameIntegerValue56;
   // $VF: renamed from: at int
   public int gameIntegerValue57;
   // $VF: renamed from: au int
   public int gameIntegerValue58;
   // $VF: renamed from: av int
   public int gameIntegerValue59;
   // $VF: renamed from: aw int
   public int gameIntegerValue60;
   // $VF: renamed from: ax int
   public int gameIntegerValue61;
   // $VF: renamed from: ay int
   public int gameIntegerValue62;
   // $VF: renamed from: b byte
   public sbyte gameByteValue04;
   // $VF: renamed from: a boolean[]
   public bool[] gameBooleanArray01;
   // $VF: renamed from: c byte
   public sbyte gameByteValue05;
   // $VF: renamed from: r byte
   public sbyte gameByteValue06;
   // $VF: renamed from: a h[]
   public ActorTypeData[] gameClass20ReferenceArray01;
   // $VF: renamed from: az int
   public int gameIntegerValue63;
   // $VF: renamed from: f int
   public int gameIntegerValue64;
   // $VF: renamed from: g int
   public int gameIntegerValue65;
   // $VF: renamed from: h long
   public long gameLongValue07;
   // $VF: renamed from: h int
   public int gameIntegerValue66;
   // $VF: renamed from: a short
   public static short gameShortValue01;
   // $VF: renamed from: d byte
   public static sbyte gameByteValue07;
   // $VF: renamed from: b long
   public long gameLongValue08;
   // $VF: renamed from: a p[]
   public ActorState[] gameActorStateReferenceArray01;
   // $VF: renamed from: a p
   public ActorState gameActorStateReference01;
   // $VF: renamed from: b p
   public ActorState gameActorStateReference02;
   // $VF: renamed from: c p
   public ActorState gameActorStateReference03;
   // $VF: renamed from: d p
   public ActorState gameActorStateReference04;
   // $VF: renamed from: e p
   public ActorState gameActorStateReference05;
   // $VF: renamed from: f p
   public ActorState gameActorStateReference06;
   // $VF: renamed from: g p
   public ActorState gameActorStateReference07;
   // $VF: renamed from: a ab[]
   public EntityFrameData[] gameEntityFrameDataReferenceArray01;
   // $VF: renamed from: a e[]
   public TimedEntityEffect[] gameClass22ReferenceArray01;
   // $VF: renamed from: b short[]
   public short[] gameShortArray02;
   // $VF: renamed from: e byte[]
   public sbyte[] gameByteArray01;
   // $VF: renamed from: b short
   public short gameShortValue02;
   // $VF: renamed from: aA int
   public static int gameIntegerValue67;
   // $VF: renamed from: s byte
   public sbyte gameByteValue08;
   // $VF: renamed from: c java.lang.String
   public string gameTextValue03;
   // $VF: renamed from: c short
   public short gameShortValue03;
   // $VF: renamed from: aB int
   public int gameIntegerValue68;
   // $VF: renamed from: aC int
   public int gameIntegerValue69;
   // $VF: renamed from: d short
   public short gameShortValue04;
   // $VF: renamed from: e short
   public short gameShortValue05;
   // $VF: renamed from: a x[]
   public ActorRuntimeState[] gameClass9ReferenceArray01;
   // $VF: renamed from: aD int
   public static int gameIntegerValue70;
   // $VF: renamed from: aE int
   public static int gameIntegerValue71;
   // $VF: renamed from: aF int
   public static int gameIntegerValue72;
   // $VF: renamed from: aG int
   public static int gameIntegerValue73;
   // $VF: renamed from: aH int
   public static int gameIntegerValue74;
   // $VF: renamed from: aI int
   public static int gameIntegerValue75;
   // $VF: renamed from: aJ int
   public static int gameIntegerValue76;
   // $VF: renamed from: aK int
   public static int gameIntegerValue77;
   // $VF: renamed from: aL int
   public static int gameIntegerValue78;
   // $VF: renamed from: aM int
   public static int gameIntegerValue79;
   // $VF: renamed from: aN int
   public static int gameIntegerValue80;
   // $VF: renamed from: e int[]
   public int[] gameIntegerArray03;
   // $VF: renamed from: f short
   public short gameShortValue06;
   // $VF: renamed from: g short
   public short gameShortValue07;
   // $VF: renamed from: h short
   public short gameShortValue08;
   // $VF: renamed from: a i[]
   public ActorStatus[] gameClass19ReferenceArray01;
   // $VF: renamed from: t byte
   public sbyte gameByteValue09;
   // $VF: renamed from: e byte
   public static sbyte gameByteValue10;
   // $VF: renamed from: u byte
   public static sbyte gameByteValue11;
   // $VF: renamed from: b i[]
   public ActorStatus[] gameClass19ReferenceArray02;
   // $VF: renamed from: a i
   public ActorStatus gameClass19Reference01;
   // $VF: renamed from: i short
   public short gameShortValue09;
   // $VF: renamed from: f byte[]
   public sbyte[] gameByteArray02;
   // $VF: renamed from: i long
   public long gameLongValue09;
   // $VF: renamed from: j long
   public long gameLongValue10;
   // $VF: renamed from: k long
   public long gameLongValue11;
   // $VF: renamed from: v byte
   public sbyte gameByteValue12;
   // $VF: renamed from: w byte
   public sbyte gameByteValue13;
   // $VF: renamed from: b byte[][]
   public sbyte[][] gameByteMatrix01;
   // $VF: renamed from: b short[][]
   public short[][] gameShortMatrix01;
   // $VF: renamed from: a short[][]
   public short[][] gameShortMatrix02;
   // $VF: renamed from: a byte[][]
   public sbyte[][] gameByteMatrix02;
   // $VF: renamed from: b boolean[]
   public bool[] gameBooleanArray02;
   // $VF: renamed from: g boolean
   public bool gameBooleanFlag36;
   // $VF: renamed from: j short
   public short gameShortValue10;
   // $VF: renamed from: k short
   public short gameShortValue11;
   // $VF: renamed from: l short
   public short gameShortValue12;
   // $VF: renamed from: m short
   public short gameShortValue13;
   // $VF: renamed from: f byte
   public sbyte gameByteValue14;
   // $VF: renamed from: c byte[][]
   public sbyte[][] gameByteMatrix03;
   // $VF: renamed from: d byte[][]
   public sbyte[][] gameByteMatrix04;
   // $VF: renamed from: a r[]
   public LinkedEntityNode[] gameClass14ReferenceArray01;
   // $VF: renamed from: a r
   public LinkedEntityNode gameClass14Reference01;
   // $VF: renamed from: aO int
   public int gameIntegerValue81;
   // $VF: renamed from: aP int
   public int gameIntegerValue82;
   // $VF: renamed from: g byte[]
   public sbyte[] gameByteArray03;
   // $VF: renamed from: a java.lang.StringBuffer
   public StringBuffer gameStringBufferReference01;
   // $VF: renamed from: h byte[]
   public sbyte[] gameByteArray04;
   // $VF: renamed from: c short[][]
   public short[][] gameShortMatrix03;
   // $VF: renamed from: h boolean
   public bool gameBooleanFlag37;
   // $VF: renamed from: x byte
   public sbyte gameByteValue15;
   // $VF: renamed from: i int
   public int gameIntegerValue83;
   // $VF: renamed from: n short
   public short gameShortValue14;
   // $VF: renamed from: aQ int
   public int gameIntegerValue84;
   // $VF: renamed from: aR int
   public int gameIntegerValue85;
   // $VF: renamed from: aS int
   public int gameIntegerValue86;
   // $VF: renamed from: aT int
   public int gameIntegerValue87;
   // $VF: renamed from: aU int
   public int gameIntegerValue88;
   // $VF: renamed from: aV int
   public int gameIntegerValue89;
   // $VF: renamed from: i boolean
   public bool gameBooleanFlag38;
   // $VF: renamed from: ad boolean
   public bool gameBooleanFlag39;
   // $VF: renamed from: j boolean
   public bool gameBooleanFlag40;
   // $VF: renamed from: k boolean
   public bool gameBooleanFlag41;
   // $VF: renamed from: ae boolean
   public bool gameBooleanFlag42;
   // $VF: renamed from: j int
   public int gameIntegerValue90;
   // $VF: renamed from: aW int
   public int gameIntegerValue91;
   // $VF: renamed from: aX int
   public int gameIntegerValue92;
   // $VF: renamed from: d byte[]
   public sbyte[] gameByteArray05;
   // $VF: renamed from: l boolean
   public bool gameBooleanFlag43;
   // $VF: renamed from: m boolean
   public bool gameBooleanFlag44;
   // $VF: renamed from: af boolean
   public bool gameBooleanFlag45;
   // $VF: renamed from: n boolean
   public bool gameBooleanFlag46;
   // $VF: renamed from: o boolean
   public bool gameBooleanFlag47;
   // $VF: renamed from: p boolean
   public bool gameBooleanFlag48;
   // $VF: renamed from: g byte
   public sbyte gameByteValue16;
   // $VF: renamed from: h byte
   public sbyte gameByteValue17;
   // $VF: renamed from: i byte
   public sbyte gameByteValue18;
   // $VF: renamed from: j byte
   public sbyte gameByteValue19;
   // $VF: renamed from: k byte
   public sbyte gameByteValue20;
   // $VF: renamed from: y byte
   public sbyte gameByteValue21;
   // $VF: renamed from: l byte
   public sbyte gameByteValue22;
   // $VF: renamed from: m byte
   public sbyte gameByteValue23;
   // $VF: renamed from: n byte
   public sbyte gameByteValue24;
   // $VF: renamed from: o byte
   public sbyte gameByteValue25;
   // $VF: renamed from: k int
   public int gameIntegerValue93;
   // $VF: renamed from: l int
   public int gameIntegerValue94;
   // $VF: renamed from: m int
   public int gameIntegerValue95;
   // $VF: renamed from: z byte
   public sbyte gameByteValue26;
   // $VF: renamed from: A byte
   public sbyte gameByteValue27;
   // $VF: renamed from: B byte
   public sbyte gameByteValue28;
   // $VF: renamed from: q boolean
   public bool gameBooleanFlag49;
   // $VF: renamed from: o short
   public short gameShortValue15;
   // $VF: renamed from: p short
   public short gameShortValue16;
   // $VF: renamed from: aY int
   public int gameIntegerValue96;
   // $VF: renamed from: aZ int
   public int gameIntegerValue97;
   // $VF: renamed from: ba int
   public int gameIntegerValue98;
   // $VF: renamed from: bb int
   public int gameIntegerValue99;
   // $VF: renamed from: bc int
   public int gameIntegerValue100;
   // $VF: renamed from: bd int
   public int gameIntegerValue101;
   // $VF: renamed from: be int
   public int gameIntegerValue102;
   // $VF: renamed from: l long
   public long gameLongValue12;
   // $VF: renamed from: a l
   public static GameModeController gameClass18Reference01;
   // $VF: renamed from: a t
   public static GameplaySequenceController gameClass12Reference01;
   // $VF: renamed from: a w
   public static HudRenderer gameClass10Reference01;
   // $VF: renamed from: r boolean
   public static bool gameBooleanFlag50 = false;
   // $VF: renamed from: s boolean
   public static bool gameBooleanFlag51 = false;
   // $VF: renamed from: ag boolean
   public static bool gameBooleanFlag52 = false;
   // $VF: renamed from: t boolean
   public static bool gameBooleanFlag53 = false;
   // $VF: renamed from: ah boolean
   public bool gameBooleanFlag54;
   // $VF: renamed from: bf int
   public static int gameIntegerValue103 = -1;
   // $VF: renamed from: ai boolean
   public static bool gameBooleanFlag55 = false;
   // $VF: renamed from: bg int
   public int gameIntegerValue104;
   // $VF: renamed from: bh int
   public int gameIntegerValue105;
   // $VF: renamed from: bi int
   public int gameIntegerValue106;
   // $VF: renamed from: bj int
   public int gameIntegerValue107;
   // $VF: renamed from: bk int
   public int gameIntegerValue108;
   // $VF: renamed from: bl int
   public int gameIntegerValue109;
   // $VF: renamed from: bm int
   public int gameIntegerValue110;
   // $VF: renamed from: bn int
   public int gameIntegerValue111;
   // $VF: renamed from: bo int
   public int gameIntegerValue112;
   // $VF: renamed from: bp int
   public int gameIntegerValue113;
   // $VF: renamed from: f int[]
   public int[] gameIntegerArray04;
   // $VF: renamed from: aj boolean
   public bool gameBooleanFlag56;
   // $VF: renamed from: bq int
   public int gameIntegerValue114;
   // $VF: renamed from: br int
   public int gameIntegerValue115;
   // $VF: renamed from: bs int
   public int gameIntegerValue116;
   // $VF: renamed from: ak boolean
   public bool gameBooleanFlag57;
   // $VF: renamed from: b g
   public static SpriteResourceDecoder gameSpriteDecoderReference02 = null;
   // $VF: renamed from: bt int
   public static int gameIntegerValue117;
   // $VF: renamed from: bu int
   public static int gameIntegerValue118 = -1;
   // $VF: renamed from: bv int
   public static int gameIntegerValue119 = -1;
   // $VF: renamed from: bw int
   public static int gameIntegerValue120 = 0;
   // $VF: renamed from: bx int
   public static int gameIntegerValue121 = 0;
   // $VF: renamed from: g int[]
   public static int[] gameIntegerArray05 = new int[5];
   // $VF: renamed from: by int
   public int gameIntegerValue122;
   // $VF: renamed from: d v
   public static SpriteAnimation gameClass11Reference04;
   // $VF: renamed from: al boolean
   public static bool gameBooleanFlag58 = false;
   // $VF: renamed from: bz int
   public static int gameIntegerValue123;
   // $VF: renamed from: u boolean
   public static bool gameBooleanFlag59 = false;
   // $VF: renamed from: v boolean
   public static bool gameBooleanFlag60 = false;
   // $VF: renamed from: w boolean
   public static bool gameBooleanFlag61 = false;
   // $VF: renamed from: x boolean
   public static bool gameBooleanFlag62 = false;
   // $VF: renamed from: am boolean
   public static bool gameBooleanFlag63 = false;
   // $VF: renamed from: n int
   public static int gameIntegerValue124 = -1;
   // $VF: renamed from: bA int
   public static int gameIntegerValue125 = 0;
   // $VF: renamed from: an boolean
   public static bool gameBooleanFlag64 = false;
   // $VF: renamed from: a javax.microedition.lcdui.Graphics
   public static Graphics gameGraphicsReference02 = null;
   // $VF: renamed from: c javax.microedition.lcdui.Graphics
   public static Graphics gameGraphicsReference03 = null;
   // $VF: renamed from: y boolean
   public static bool gameBooleanFlag65;
   // $VF: renamed from: o int
   public static int gameIntegerValue126;
   // $VF: renamed from: m long
   public static long gameLongValue13;
   // $VF: renamed from: p int
   public static int screenWidth = 360;
   // $VF: renamed from: q int
   public static int screenHeight = 640;
   // $VF: renamed from: a javax.microedition.lcdui.Display
   public static Display gameDisplayReference01;
   // $VF: renamed from: ao boolean
   public static bool gameBooleanFlag66;
   // $VF: renamed from: a javax.microedition.midlet.MIDlet
   public static MIDlet gameMidletReference01;
   // $VF: renamed from: bB int
   public static int gameIntegerValue127 = 28;
   // $VF: renamed from: n long
   public long gameLongValue14;
   // $VF: renamed from: bC int
   public static int gameIntegerValue128 = -1;
   // $VF: renamed from: b javax.microedition.lcdui.Image
   public static Image gameImageReference02 = null;
   // $VF: renamed from: d javax.microedition.lcdui.Graphics
   public static Graphics gameGraphicsReference04 = null;
   // $VF: renamed from: ap boolean
   public static bool gameBooleanFlag67 = true;
   // $VF: renamed from: bD int
   public static int gameIntegerValue129;
   // $VF: renamed from: o long
   public static long gameLongValue15;
   // $VF: renamed from: bE int
   public static int gameIntegerValue130;
   // $VF: renamed from: bF int
   public static int gameIntegerValue131;
   // $VF: renamed from: a f
   public static GameCanvas gameGameCanvasReference01;
   // $VF: renamed from: i byte[]
   public static sbyte[] gameByteArray06;
   // $VF: renamed from: j byte[]
   public static sbyte[] gameByteArray07;
   // $VF: renamed from: bG int
   public static int gameIntegerValue132 = -9999;
   // $VF: renamed from: bH int
   public static int gameIntegerValue133;
   // $VF: renamed from: a java.util.Hashtable
   public static Hashtable gameHashtableReference01;
   // $VF: renamed from: b java.util.Hashtable
   public static Hashtable gameHashtableReference02;
   // $VF: renamed from: bI int
   public static int gameIntegerValue134 = 24;
   // $VF: renamed from: bJ int
   public static int gameIntegerValue135 = 256;
   // $VF: renamed from: b java.util.Random
   public static Random gameRandomReference02;
   // $VF: renamed from: bK int
   public static int gameIntegerValue136 = 256;
   // $VF: renamed from: bL int
   public static int gameIntegerValue137 = 804;
   // $VF: renamed from: d java.lang.String
   public static string gameTextValue04;
   // $VF: renamed from: a java.io.InputStream
   public static InputStream gameInputStreamReference01;
   // $VF: renamed from: bM int
   public static int gameIntegerValue138;
   // $VF: renamed from: k byte[]
   public static sbyte[] gameByteArray08;
   // $VF: renamed from: bN int
   public static int gameIntegerValue139;
   // $VF: renamed from: bO int
   public static int gameIntegerValue140;
   // $VF: renamed from: q short
   public static short gameShortValue17;
   // $VF: renamed from: h int[]
   public static int[] gameIntegerArray06;
   // $VF: renamed from: r short
   public static short gameShortValue18;
   // $VF: renamed from: c short[]
   public static short[] gameShortArray03;
   // $VF: renamed from: bP int
   public static int gameIntegerValue141;
   // $VF: renamed from: bQ int
   public static int gameIntegerValue142;
   // $VF: renamed from: aq boolean
   public static bool gameBooleanFlag68;
   // $VF: renamed from: l byte[]
   public static sbyte[] gameByteArray09;
   // $VF: renamed from: e byte[][]
   public static sbyte[][] gameByteMatrix05;
   // $VF: renamed from: m byte[]
   public static sbyte[] gameByteArray10;
   // $VF: renamed from: bR int
   public static int gameIntegerValue143;
   // $VF: renamed from: p long
   public static long gameLongValue16;
   // $VF: renamed from: q long
   public static long gameLongValue17;
   // $VF: renamed from: n byte[]
   public static sbyte[] gameByteArray11;
   // $VF: renamed from: bS int
   public static int gameIntegerValue144;
   // $VF: renamed from: d short[]
   public static short[] gameShortArray04;
   // $VF: renamed from: bT int
   public static int gameIntegerValue145 = 0;
   // $VF: renamed from: bU int
   public static int gameIntegerValue146;
   // $VF: renamed from: e java.lang.String
   public static string gameTextValue05 = "UTF-8";
   // $VF: renamed from: o byte[]
   public static sbyte[] gameByteArray12;
   // $VF: renamed from: i int[]
   public static int[] gameIntegerArray07;
   // $VF: renamed from: d java.lang.String[]
   public static string[] gameTextArray02;
   // $VF: renamed from: a javax.microedition.rms.RecordStore
   public static RecordStore gameRecordStoreReference01;
   // $VF: renamed from: bV int
   public static int gameIntegerValue147;
   // $VF: renamed from: j int[]
   public static int[] gameIntegerArray08;
   // $VF: renamed from: ar boolean
   public static bool gameBooleanFlag69 = false;
   // $VF: renamed from: z boolean
   public static bool gameBooleanFlag70 = false;
   // $VF: renamed from: as boolean
   public static bool gameBooleanFlag71 = false;
   // $VF: renamed from: r int
   public static int gameIntegerValue148 = 0;
   // $VF: renamed from: d int[][]
   public static int[][] gameIntegerMatrix02 = null;
   // $VF: renamed from: c javax.microedition.lcdui.Image
   public static Image gameImageReference03 = null;
   // $VF: renamed from: e javax.microedition.lcdui.Graphics
   public static Graphics gameGraphicsReference05 = null;
   // $VF: renamed from: bW int
   public static int gameIntegerValue149 = 0;
   // $VF: renamed from: bX int
   public static int gameIntegerValue150 = 0;

   // $VF: renamed from: q () void
   public void updateCanvasState() {
      if (this.gameIntegerValue49 != 127) {
         switch (this.gameIntegerValue49) {
            case 1:
               openAssetStream("/3");
               gameSpriteDecoderReferenceArray01[2] = createSpriteResource(2, true, true);
               gameSpriteDecoderReferenceArray01[0] = createSpriteResource(0, true, true);
               closeAssetStream();
               if (!readResourceFile("options.dat", this.gameByteArray03)) {
                  this.writeSavedGameData();
               } else {
                  gameBooleanFlag04 = this.gameByteArray03[1] == 1;
                  bool var15 = true;
               }

               this.setGameScreen(0);
               break;
            case 2:
               gameBooleanFlag23 = false;
               gameSpriteDecoderReferenceArray01[2] = null;
               gameSpriteDecoderReferenceArray01[0] = null;
               this.gameActorStateReferenceArray01 = new ActorState[25];
               this.gameActorStateReferenceArray01[0] = this.gameActorGroupReference03.actorStateReference01;
               this.gameActorStateReferenceArray01[1] = this.gameActorGroupReference04.actorStateReference01;

               for (int var1 = 2; var1 < 25; var1++) {
                  this.gameActorStateReferenceArray01[var1] = new ActorState(this);
                  this.gameActorStateReferenceArray01[var1].booleanFlag01 = false;
               }

               this.gameShortArray02 = new short[150];
               this.gameByteArray01 = new sbyte[150];
               this.gameBooleanFlag34 = false;
               this.gameActorGroupReference01.booleanFlag01 = false;
               this.gameActorGroupReference01.booleanFlag02 = false;
               this.gameActorGroupReference01.booleanFlag03 = false;
               GameCanvas var7 = this;
               sbyte[] var9 = loadGameDataFile("/7", 1);
               ByteArrayReader var4;
               sbyte var5 = (var4 = new ByteArrayReader(var9)).readSignedByte();
               this.gameActorGroupReference03.byteValue01 = var5;
               this.gameActorGroupReference03.entitySnapshotReferenceArray01 = new EntitySnapshot[var5];
               this.gameActorGroupReference04.byteValue01 = var5;
               this.gameActorGroupReference04.entitySnapshotReferenceArray01 = new EntitySnapshot[var5];

               for (int var10 = 0; var10 < var5; var10++) {
                  EntitySnapshot var6 = new EntitySnapshot(var7);
                  short var3 = var4.readUnsignedByte();
                  var4.readString(var3);
                  var6.integerValue01 = 367 + var10 * 3;
                  var3 = var4.readUnsignedByte();
                  var4.readString(var3);
                  var6.byteValue01 = var4.readSignedByte();
                  var6.byteValue02 = var4.readSignedByte();
                  var6.shortValue01 = var4.readUnsignedShortBigEndian();
                  var6.shortValue02 = 0;
                  var6.tileCoordinateReferenceArray01 = null;
                  var7.gameActorGroupReference03.entitySnapshotReferenceArray01[var10] = var6;
                  var7.gameActorGroupReference04.entitySnapshotReferenceArray01[var10] = new EntitySnapshot(var7, var6);
               }

               bool var10000 = true;
               this.createActorState(0, 29, 47, 3);
               this.createActorState(1, 30, 47, 3);
               this.gameClass14ReferenceArray01 = new LinkedEntityNode[150];

               for (int var8 = 0; var8 < 150; var8++) {
                  this.gameClass14ReferenceArray01[var8] = new LinkedEntityNode(this);
               }

               this.gameIntegerValue83 = 0;
               this.gameIntegerValue90 = 0;
               this.gameIntegerValue66 = 0;
               this.gameBooleanFlag34 = false;
               this.gameActorGroupReference03.booleanFlag04 = false;
               this.gameActorGroupReference04.booleanFlag04 = false;
               bool var11 = false;
               sbyte var12 = this.gameByteValue04;
               this.resetActorActions();
               this.gameByteValue04 = (sbyte)var12;
               this.initializeLevelResources();
               if (!this.gameBooleanArray01[this.gameByteValue04]) {
                  this.updateCurrentLevel();
               }

               bool var13;
               if (var13 = false & this.gameBooleanArray01[this.gameByteValue04]) {
                  this.loadGameData(true);
               }

               this.gameBooleanArray01[this.gameByteValue04] = true;
               if (this.gameByteValue04 == 0 && this.gameBooleanFlag35) {
                  this.gameShortMatrix02[this.gameClass9ReferenceArray01[545].byteValue02][this.gameClass9ReferenceArray01[545].byteValue03] = -1;
               }

               this.gameActorGroupReference01.byteValue05 = this.gameByteValue04;
               if (this.gameActorGroupReference02.byteValue05 != this.gameByteValue04) {
                  this.gameActorGroupReference02.actorStateReference01.booleanFlag01 = false;
               } else {
                  this.gameActorGroupReference02.actorStateReference01.booleanFlag01 = true;
               }

               this.clearActorStatusEffects();
               if (this.gameBooleanFlag54) {
                  this.updateAllActors(true);
                  this.gameBooleanFlag54 = false;
               }

               this.updateLevelEntities();
               this.updateActorDisplayState(this.gameActorGroupReference01.actorStateReference01, true);
               break;
            case 3:
               this.gameLongValue07 = 0L; goto case 4;
            case 4:
            case 5:
            case 6:
            case 7:
            default:
               break;
            case 8:
               this.startGame(40);
               break;
            case 9:
               this.startGame(5);
               break;
            case 10:
               this.startGame(8);
               break;
            case 11:
               gameIntegerValue21 = 0;
               break;
            case 12:
               short var2 = 290;
               GameUiController.openMobileLibraryLink(getStringResource(290), 0); break;
         }

         gameIntegerValue48 = this.gameIntegerValue49;
         this.gameIntegerValue49 = 127;
         clearInteractionBounds();
         clearCollisionBounds();
      }
   }

   // $VF: renamed from: j (int) void
   public void startGame(int var1) {
      this.gameIntegerValue01 = 0;
      this.gameIntegerValue03 = -1;
      this.gameIntegerValue02 = var1;
      stopAllAudio();
   }

   // $VF: renamed from: k (int) void
   public void setGameSubstate(int var1) {
      this.gameIntegerValue03 = var1;
      if (this.gameIntegerValue03 == 261) {
         readResourceFile("residentevil.dat", this.gameByteArray03);
         this.gameIntegerValue04 = this.gameByteArray03[0];
      } else {
         this.gameIntegerValue04 = 0;
      }
   }

   // $VF: renamed from: r () void
   public void updateLoadingState() {
      switch (this.gameIntegerValue01) {
         case 0:
            gameByteCube01 = null;
            gameIntegerMatrix01 = null;
            break;
         case 1:
            for (int var6 = 0; var6 < 12; var6++) {
               gameSpriteDecoderReferenceArray02[var6] = null;
            }
            break;
         case 2:
            for (int var5 = 0; var5 < 11; var5++) {
               gameSpriteDecoderReferenceArray04[var5] = null;
            }
            break;
         case 3:
            for (int var4 = 0; var4 < 2; var4++) {
               gameSpriteDecoderReferenceArray03[var4] = null;
            }
            break;
         case 4:
            gameClass11Reference04 = null;

            for (int var3 = 0; var3 < 5; var3++) {
               gameSpriteDecoderReferenceArray06[var3] = null;
            }
            break;
         case 5:
            for (int var2 = 0; var2 < 5; var2++) {
               gameSpriteDecoderReferenceArray05[var2] = null;
            }
            break;
         case 6:
            for (int var1 = 0; var1 < 4; var1++) {
               gameSpriteDecoderReferenceArray07[var1] = null;
            }
            break;
         case 7:
            gameSpriteDecoderReference01 = null; break;
      }

      this.gameIntegerValue01++;
   }

   // $VF: renamed from: s () void
   public void loadGameCanvasAssets() {
      if (this.gameByteValue04 == 0) {
         openAssetStream("/17");
         gameSpriteDecoderReferenceArray07[0] = this.loadSpriteResource("/17", 0, true);
         gameSpriteDecoderReferenceArray07[2] = this.loadSpriteResource("/17", 2, true);
         closeAssetStream();
      } else if (this.gameByteValue04 == 1) {
         openAssetStream("/13");
         gameSpriteDecoderReferenceArray02[7] = this.loadSpriteResource("/13", 7, true);
         gameSpriteDecoderReferenceArray02[8] = this.loadSpriteResource("/13", 8, true);
         gameSpriteDecoderReferenceArray02[10] = this.loadSpriteResource("/13", 10, true);
         closeAssetStream();
         openAssetStream("/17");
         gameSpriteDecoderReferenceArray07[1] = this.loadSpriteResource("/17", 1, true);
         gameSpriteDecoderReferenceArray07[3] = this.loadSpriteResource("/17", 3, true);
         closeAssetStream();
      } else {
         if (this.gameByteValue04 == 2) {
            openAssetStream("/13");
            gameSpriteDecoderReferenceArray02[7] = this.loadSpriteResource("/13", 7, true);
            gameSpriteDecoderReferenceArray02[9] = this.loadSpriteResource("/13", 9, true);
            gameSpriteDecoderReferenceArray02[6] = this.loadSpriteResource("/13", 6, true);
            closeAssetStream();
            openAssetStream("/15");
            gameSpriteDecoderReferenceArray04[10] = this.loadSpriteResource("/15", 10, true);
            closeAssetStream();
            openAssetStream("/16");
            gameSpriteDecoderReferenceArray05[4] = this.loadSpriteResource("/16", 4, true);
            closeAssetStream();
         }
      }
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics) void
   public void drawLoadingProgress(Graphics var1) {
      int var2;
      if ((var2 = 180 * (this.gameIntegerValue01 + 1) / this.gameIntegerValue02) > 180) {
         var2 = 180;
      }

      gameGraphicsReference02.setColor(0);
      int var4 = gameIntegerValue42;
      int var3 = gameIntegerValue41;
      fillGraphicsRectangle(gameGraphicsReference02, 0, 0, var3, var4);
      var3 = 16777215;
      gameGraphicsReference02.setColor(var3);
      drawGraphicsRectangle(UiLayoutPresetF.integerValue01, UiLayoutPresetF.integerValue02, 180, 12);
      var3 = 9437184;
      gameGraphicsReference02.setColor(var3);
      int var10000 = UiLayoutPresetF.integerValue01 + 1;
      int var10001 = UiLayoutPresetF.integerValue02 + 1;
      var4 = var2 - 1;
      var3 = var10001;
      var2 = var10000;
      fillGraphicsRectangle(gameGraphicsReference02, var2, var3, var4, 11);
      if (this.gameIntegerValue01 == this.gameIntegerValue02) {
         gameIntegerValue133 = 1000;
         if (this.gameIntegerValue02 == 40) {
            this.gameIntegerValue115 = 2;
            if (this.gameIntegerValue03 == 260) {
               this.initializeActorGroup();
            } else if (this.gameIntegerValue03 == 261 && this.readSavedGameData()) {
               this.updateLevelEvents();
            }
         } else if (this.gameIntegerValue02 == 5) {
            gameIntegerValue48 = 2;
            this.resumeBackgroundMusic();
            if (this.findActorById() >= 0) {
               this.processActorAction(25);
            }

            if (this.gameBooleanFlag02 || this.gameByteValue04 == 3) {
               this.gameBooleanFlag02 = false;
               this.updateAllActors(true);
               this.updateActorDisplayState(this.gameActorGroupReference01.actorStateReference01, true);
            } else if (!this.gameBooleanFlag03) {
               gameBooleanFlag04 = true;
               this.writeSavedGameData();
               this.hasSavedGameData();
            } else {
               this.gameBooleanFlag03 = false;
            }
         } else if (this.gameIntegerValue02 == 8) {
            if (gameBooleanFlag51) {
               this.buildGameConfiguration();
               sbyte var7 = -1;
               gameIntegerValue27 = -1;
               this.changeActorAction(14, 0);
               this.updateCanvasState();
               gameBooleanFlag51 = false;
            } else {
               this.changeActorAction(1, 129);
               this.transitionGameState(0);
            }
         }
      }

      gameSpriteDecoderReferenceArray08[0].setGraphicsTransform(0);
      int var8 = 290;
      drawTextWithFont(var1, getStringResource(290), gameIntegerValue43, UiLayoutPresetF.integerValue02 - this.gameByteValue02 - 10, 36);
      if (this.gameIntegerValue01 == this.gameIntegerValue02) {
         gameGraphicsReference02.setColor(0);
         var8 = gameIntegerValue42;
         int var5 = gameIntegerValue41;
         fillGraphicsRectangle(gameGraphicsReference02, 0, 0, var5, var8);
         this.gameIntegerValue01 = 0;
      }
   }

   // $VF: renamed from: c (int) boolean
   public bool isCanvasAssetReady(int var1) {
      if (this.gameTextValue01 == "/13") {
         if (this.gameIntegerValue04 != 1 && this.gameIntegerValue04 != 2 && var1 == 7
            || this.gameIntegerValue04 != 1 && var1 == 8
            || this.gameIntegerValue04 != 1 && var1 == 10
            || this.gameIntegerValue04 != 2 && var1 == 9
            || this.gameIntegerValue04 != 2 && var1 == 6) {
            return false;
         }
      } else if (this.gameTextValue01 == "/15") {
         if (this.gameIntegerValue04 != 2 && var1 == 10) {
            return false;
         }
      } else if (this.gameTextValue01 != "/14" && this.gameTextValue01 != "/12") {
         if (this.gameTextValue01 == "/16") {
            if (this.gameIntegerValue04 != 2 && var1 == 4) {
               return false;
            }
         } else if (this.gameTextValue01 == "/17"
            && (this.gameIntegerValue04 != 0 && var1 == 0 || this.gameIntegerValue04 != 0 && var1 == 2 || this.gameIntegerValue04 != 1 && var1 == 1 || this.gameIntegerValue04 != 1 && var1 == 3)) {
            return false;
         }
      }

      return true;
   }

   // $VF: renamed from: a (int[], int, int, int) void
   public static void configureScrollRange(int[] var0, int var1, int var2, int var3) {
      gameIntegerArray01 = var0;
      gameIntegerValue08 = var0.Length;
      gameIntegerValue07 = 0;
      gameIntegerValue09 = 0;
      gameIntegerValue10 = 180;
      if (gameIntegerValue12 > gameIntegerValue13) {
         gameIntegerValue11 = 220;
      } else {
         gameIntegerValue11 = 180;
      }

      gameIntegerValue16 = var2;
      initializeInputState();
   }

   // $VF: renamed from: l (int) void
   public void setGameScreen(int var1) {
      gameIntegerValue06 = var1;
      switch (var1) {
         case 0:
            SpriteResourceDecoder var10000 = gameSpriteDecoderReferenceArray08[1];
            short var2 = 265;
            gameIntegerValue12 = measureTextWidth(var10000, getStringResource(265).toUpperCase());
            gameIntegerValue13 = (gameIntegerValue13 = gameSpriteDecoderReferenceArray09[0].getSpriteWidth(1)) - 40;
            gameIntegerValue14 = 180 + (gameIntegerValue13 + gameIntegerValue12 >> 1);
            gameIntegerValue15 = 180 - (gameIntegerValue13 + gameIntegerValue12 >> 1);
            configureScrollRange(new int[]{260, 261, 265, 266, 268, 263, 264, 267}, 180, UiLayoutPresetG.integerValue01, 36);
            if (!gameBooleanFlag04) {
               resetGameObjects(261);
            }

            if (!gameBooleanFlag24) {
               resetGameObjects(265);
            }

            if (!gameBooleanFlag25) {
               resetGameObjects(266);
            }

            gameIntegerValue103 = -1;
            return;
         case 1:
            configureScrollRange(new int[]{268}, 180, UiLayoutPresetG.integerValue01, 36);
            return;
         case 2:
            gameBooleanFlag52 = true;
            configureScrollRange(new int[]{9, 11, 14, 20, 21, 263, 22, 23}, 180, 242, 36);
            if (!gameBooleanFlag04) {
               resetGameObjects(21);
            } break;
      }
   }

   // $VF: renamed from: m (int) void
   public static void resetGameObjects(int var0) {
      for (int var1 = 0; var1 < gameIntegerValue08; var1++) {
         if (gameIntegerArray01[var1] == var0) {
            for (int var2 = var1; var2 < gameIntegerValue08 - 1; var2++) {
               gameIntegerArray01[var2] = gameIntegerArray01[var2 + 1];
            }

            gameIntegerValue08--;
            return;
         }
      }
   }

   // $VF: renamed from: t () void
   public void updateGameClock() {
      if (gameIntegerValue12 > gameIntegerValue13) {
         if (gameIntegerValue11 > gameIntegerValue15) {
            gameIntegerValue11--;
         } else {
            gameIntegerValue11 = gameIntegerValue14;
         }
      }

      if (gameRectangleBoundsReference01 != null && gameRectangleBoundsReference01.boundsId >= 50 && gameRectangleBoundsReference01.boundsId < 100) {
         if (!gameBooleanFlag13 && gameIntegerValue09 != gameRectangleBoundsReference01.boundsId - 50) {
            gameIntegerValue09 = gameRectangleBoundsReference01.boundsId - 50;
            this.processActorAction(22);
         }

         if (gameBooleanFlag22) {
            if (gameIntegerArray01[gameIntegerValue09] != 14) {
               gameBooleanFlag22 = false;
               gameRectangleBoundsReference01 = null;
               gameBooleanFlag13 = true;
            } else if (gameIntegerValue50 == 384 && !isGameplayRunning() && this.isActorMoving()) {
               gameBooleanFlag22 = false;
               gameRectangleBoundsReference01 = null;
               gameBooleanFlag13 = true;
            }
         }
      }

      if (!this.isGameModeActive(2049) && (gameRectangleBoundsReference01 == null || gameRectangleBoundsReference01.boundsId != 1 || !gameBooleanFlag22)) {
         if (this.isGameModeActive(3586) || gameRectangleBoundsReference01 != null && gameRectangleBoundsReference01.boundsId == 2 && gameBooleanFlag22) {
            if (gameIntegerValue09 < gameIntegerValue08 - 1) {
               if (++gameIntegerValue09 > 10 + gameIntegerValue07 - 1) {
                  gameIntegerValue07++;
               }
            } else {
               gameIntegerValue07 = 0;
               gameIntegerValue09 = 0;
            }

            clearInteractionBounds();
            clearCollisionBounds();
         }
      } else {
         if (gameIntegerValue09 > 0) {
            if (--gameIntegerValue09 < gameIntegerValue07 && gameIntegerValue07 > 0) {
               gameIntegerValue07--;
            }
         } else {
            gameIntegerValue07 = gameIntegerValue08 > 10 ? gameIntegerValue08 - 10 : 0;
            gameIntegerValue09 = gameIntegerValue08 - 1;
         }

         clearInteractionBounds();
         clearCollisionBounds();
      }

      if (!this.isGameModeActive(2821) && !this.isGameModeActive(18) && !gameBooleanFlag12) {
         if (this.isGameModeActive(19) || gameRectangleBoundsReference02 != null && gameRectangleBoundsReference02.boundsId == 1002 && gameBooleanFlag22) {
            clearInteractionBounds();
            clearCollisionBounds();
            if (gameIntegerValue06 == 2) {
               this.resetLevelEvents();
               this.processActorAction(21);
            }

            if (gameIntegerValue06 == 1) {
               this.setGameScreen(0);
               short var3 = 262;
               gameIntegerValue09 = 0;

               for (int var4 = 0; var4 < gameIntegerValue08; var4++) {
                  if (gameIntegerArray01[var4] == 262) {
                     gameIntegerValue09 = var4;
                     break;
                  }
               }

               this.processActorAction(21);
               stopSoundEffect(0);
            }
         }
      } else {
         clearInteractionBounds();
         clearCollisionBounds();
         gameBooleanFlag12 = false;
         if (gameIntegerArray01[gameIntegerValue09] != 268 && gameIntegerArray01[gameIntegerValue09] != 11) {
            this.processActorAction(8);
         }

         switch (gameIntegerArray01[gameIntegerValue09]) {
            case 9:
               this.resetLevelEvents();
               break;
            case 11:
            case 268:
               gameBooleanFlag05 = !gameBooleanFlag05;
               if (gameBooleanFlag05) {
                  if (gameIntegerValue48 == 1) {
                     this.transitionGameState(0);
                  }

                  if (gameIntegerValue48 == 2) {
                     this.processActorAction(8);
                     return;
                  }
               } else {
                  this.restoreAudioState();
               }
               break;
            case 14:
               if (this.isActorMoving()) {
                  this.gameLongValue12 = this.gameLongValue06;
                  this.setActorState(this.gameByteValue03 == 1 ? 2 : 1);
               }

               return;
            case 17:
            case 273:
               if (!(gameBooleanFlag07 = !gameBooleanFlag07) || gameIntegerValue50 != 901) {
                  return;
               }

               gameIntegerValue50 = 900;
               break;
            case 20:
               if (gameIntegerValue48 != 2
                  || gameIntegerValue50 != 384
                  || this.gameByteValue09 != 2 && gameByteValue07 != 2
                  || this.gameByteValue04 == 3
                  || this.gameActorGroupReference01.actorStateReference01.byteValue05 != 0) {
                  this.setViewport(0, 291, 293);
               } else if (gameBooleanFlag04) {
                  this.setViewport(1, 297, 292);
               } else {
                  this.initializeGameplay();
                  this.setGameScreen(2);
               }
               break;
            case 21:
               gameBooleanFlag59 = true; goto case 22;
            case 22:
            case 23:
               this.setViewport(1, 291, 294);
               break;
            case 260:
               if (gameBooleanFlag04) {
                  this.setViewport(2, -1, 5);
               } else {
                  this.changeActorAction(8, 0);
                  this.updateCanvasState();
                  this.setGameSubstate(260);
                  gameBooleanFlag60 = false;
               }

               gameBooleanFlag59 = false;
               break;
            case 261:
               this.changeActorAction(8, 0);
               this.updateCanvasState();
               this.setGameSubstate(261);
               gameBooleanFlag59 = true;
               gameBooleanFlag60 = true;
               break;
            case 262:
               this.setGameScreen(1);
               break;
            case 263:
               int var2 = gameIntegerValue06;
               gameIntegerValue22 = gameIntegerValue06;
               this.changeActorAction(11, 0);
               this.updateCanvasState();
               break;
            case 264:
               this.buildGameConfiguration();
               int var1 = gameIntegerValue06;
               gameIntegerValue27 = gameIntegerValue06;
               this.changeActorAction(14, 0);
               this.updateCanvasState();
               break;
            case 265:
               this.changeActorAction(12, 0);
               this.updateCanvasState();
               break;
            case 266:
               stopAllAudio();
               GameUiController.initializeMenuState();
               GameUiController.shouldShowMobileLibrary(0);
               GameUiController.renderUiOverlay(gameGraphicsReference02);
               break;
            case 267:
               this.setViewport(2, -1, 4);
               break;
            default:
               return;
         }
      }
   }

   // $VF: renamed from: u () void
   public void updateGameTimer() {
      int var1 = gameIntegerValue16;
      int var2 = gameIntegerValue07;
      int var3 = gameIntegerValue08 < 10 ? gameIntegerValue08 : gameIntegerValue07 + 10;
      gameIntegerValue34 = gameSpriteDecoderReferenceArray09[0].getSpriteWidth(1);
      gameIntegerValue35 = gameIntegerValue35 = gameSpriteDecoderReferenceArray09[0].getSpriteHeight(1);

      for (int var9 = var2; var9 < var3; var9++) {
         if (var9 == gameIntegerValue09) {
            gameSpriteDecoderReferenceArray08[1].setGraphicsTransform(1);
            if (gameIntegerArray01[var9] == 265 || gameIntegerArray01[var9] == 266) {
               gameSpriteDecoderReferenceArray08[1].setGraphicsTransform(4);
            }
         } else {
            gameSpriteDecoderReferenceArray08[1].setGraphicsTransform(0);
            if (gameIntegerArray01[var9] == 265 || gameIntegerArray01[var9] == 266) {
               gameSpriteDecoderReferenceArray08[1].setGraphicsTransform(3);
            }
         }

         if ((JSystem.currentTimeMillis() & 64L) != 0L && gameBooleanFlag13) {
            gameSpriteDecoderReferenceArray08[0].setGraphicsTransform(0);
            if (gameIntegerArray01[var9] == 265 || gameIntegerArray01[var9] == 266) {
               gameSpriteDecoderReferenceArray08[1].setGraphicsTransform(3);
            }
         }

         if (var9 == gameIntegerValue09) {
            if (!gameBooleanFlag29) {
               SpriteResourceDecoder var10000 = gameSpriteDecoderReferenceArray09[0];
               Graphics var10001 = gameGraphicsReference02;
               int var6 = (JSystem.currentTimeMillis() & 64L) != 0L && gameBooleanFlag13 ? 1 + var9 * 2 : 1 + var9 * 2 + 1;
               Graphics var5 = var10001;
               var10000.drawSpriteFrameTransformed(var5, var6, 180, var1, 0, 0, 0);
            } else {
               SpriteResourceDecoder var46 = gameSpriteDecoderReferenceArray09[0];
               Graphics var57 = gameGraphicsReference02;
               int var28 = (JSystem.currentTimeMillis() & 64L) != 0L && gameBooleanFlag13 ? 1 + var9 * 2 : 1 + var9 * 2 + 1;
               Graphics var16 = var57;
               var46.drawSpriteFrameTransformed(var16, var28, 180, var1, 0, 0, 0);
            }
         } else if (!gameBooleanFlag29) {
            SpriteResourceDecoder var47 = gameSpriteDecoderReferenceArray09[0];
            int var29 = 1 + var9 * 2;
            Graphics var17 = gameGraphicsReference02;
            var47.drawSpriteFrameTransformed(var17, var29, 180, var1, 0, 0, 0);
         } else {
            SpriteResourceDecoder var48 = gameSpriteDecoderReferenceArray09[0];
            int var30 = 1 + var9 * 2;
            Graphics var18 = gameGraphicsReference02;
            var48.drawSpriteFrameTransformed(var18, var30, 180, var1, 0, 0, 0);
         }

         addCollisionBounds(180 - (gameIntegerValue34 >> 1), var1 - (gameIntegerValue35 >> 1), gameIntegerValue34, gameIntegerValue35, var9 + 50);
         if (gameIntegerArray01[var9] != 268 && gameIntegerArray01[var9] != 273 && gameIntegerArray01[var9] != 11 && gameIntegerArray01[var9] != 14 && gameIntegerArray01[var9] != 17) {
            if (gameIntegerArray01[var9] == 265) {
               int var53 = 180 - (gameIntegerValue13 >> 1);
               int var63 = var1 - 20;
               int var36 = gameIntegerValue13;
               int var24 = var63;
               int var12 = var53;
               setGraphicsClip(gameGraphicsReference02, var12, var24, var36, 42);
               if (gameIntegerValue12 < gameIntegerValue13) {
                  SpriteResourceDecoder var54 = gameSpriteDecoderReferenceArray08[1];
                  Graphics var64 = gameGraphicsReference02;
                  string var70 = getStringResource(var12 = gameIntegerArray01[var9]).toUpperCase();
                  int var42 = gameIntegerValue10;
                  string var37 = var70;
                  Graphics var25 = var64;
                  var54.drawBitmapTextLine(var25, var37, var42, var1, 3, true);
               } else {
                  SpriteResourceDecoder var55 = gameSpriteDecoderReferenceArray08[1];
                  Graphics var65 = gameGraphicsReference02;
                  string var71 = getStringResource(var12 = gameIntegerArray01[var9]).toUpperCase();
                  int var43 = gameIntegerValue11;
                  string var38 = var71;
                  Graphics var26 = var65;
                  var55.drawBitmapTextLine(var26, var38, var43, var1, 3, true);
               }

               setGraphicsClip(gameGraphicsReference02, 0, 0, 360, 640);
            } else {
               SpriteResourceDecoder var56 = gameSpriteDecoderReferenceArray08[1];
               Graphics var66 = gameGraphicsReference02;
               int var15;
               string var72 = getStringResource(var15 = gameIntegerArray01[var9]).toUpperCase();
               int var44 = gameIntegerValue10;
               string var39 = var72;
               Graphics var27 = var66;
               var56.drawBitmapTextLine(var27, var39, var44, var1, 3, true);
            }
         } else {
            if (gameIntegerArray01[var9] == 268) {
               SpriteResourceDecoder var49 = gameSpriteDecoderReferenceArray08[1];
               Graphics var58 = gameGraphicsReference02;
               int var4;
               string var10002 = getStringResource(var4 = gameBooleanFlag05 ? 280 : 281);
               int var7 = gameIntegerValue10 + 75;
               string var31 = var10002;
               Graphics var19 = var58;
               var49.drawBitmapTextLine(var19, var31, var7, var1, 3, true);
            }

            if (gameIntegerArray01[var9] != 14 && gameIntegerArray01[var9] != 11) {
               SpriteResourceDecoder var51 = gameSpriteDecoderReferenceArray08[1];
               Graphics var60 = gameGraphicsReference02;
               int var11;
               string var68 = getStringResource(var11 = gameIntegerArray01[var9]).toUpperCase();
               int var41 = gameIntegerValue10 - 75;
               string var33 = var68;
               Graphics var21 = var60;
               var51.drawBitmapTextLine(var21, var33, var41, var1, 3, true);
            } else {
               SpriteResourceDecoder var50 = gameSpriteDecoderReferenceArray08[1];
               Graphics var59 = gameGraphicsReference02;
               int var10;
               string var67 = getStringResource(var10 = gameIntegerArray01[var9]).toUpperCase();
               int var40 = gameIntegerValue10 + -75;
               string var32 = var67;
               Graphics var20 = var59;
               var50.drawBitmapTextLine(var20, var32, var40, var1, 3, true);
            }

            int var61 = gameIntegerArray01[var9];
            int var34 = gameIntegerValue10 + 75;
            int var22 = var61;
            int var8 = 0;
            if (gameIntegerValue06 == 1 || gameIntegerValue06 == 2) {
               switch (var22) {
                  case 11:
                  case 268:
                     var8 = gameBooleanFlag05 ? 280 : 281;
                     break;
                  case 14:
                     var8 = this.gameByteValue03 == 1 ? 15 : 16;
                     break;
                  case 17:
                  case 273:
                     var8 = gameBooleanFlag07 ? 284 : 285; break;
               }

               SpriteResourceDecoder var52 = gameSpriteDecoderReferenceArray08[1];
               Graphics var62 = gameGraphicsReference02;
               string var35 = getStringResource(var8);
               Graphics var23 = var62;
               var52.drawBitmapTextLine(var23, var35, var34, var1, 3, true);
            }
         }

         if (gameIntegerArray01[var9] == 265) {
            GameUiController.drawUiImageTransition(gameGraphicsReference02, gameImageReference01, gameIntegerValue39 + 54, var1 + 1 + -8, 20);
         }

         var1 += 43;
      }

      gameBooleanFlag10 = true;
      gameSpriteDecoderReferenceArray08[1].setGraphicsTransform(0);
      gameSpriteDecoderReferenceArray08[0].setGraphicsTransform(0);
   }

   // $VF: renamed from: a (int, int, int) void
   public void setViewport(int var1, int var2, int var3) {
      gameIntegerValue17 = var1;
      gameIntegerValue18 = var2;
      gameIntegerValue19 = var3;
      gameIntegerValue20 = 1;
      gameBooleanFlag08 = true;
      clearInteractionBounds();
      clearCollisionBounds();
      if (gameIntegerValue19 == 24) {
         gameIntegerValue20 = 0;
      }
   }

   // $VF: renamed from: v () void
   public void processPointerState() {
      if (gameRectangleBoundsReference01 != null && !gameBooleanFlag13) {
         gameIntegerValue20 = gameRectangleBoundsReference01.boundsId - 10;
      }

      if (gameRectangleBoundsReference01 != null && gameBooleanFlag22) {
         gameBooleanFlag22 = false;
         gameRectangleBoundsReference01 = null;
         gameBooleanFlag13 = true;
      }

      if (this.isGameModeActive(2563)) {
         gameIntegerValue20 = 0;
      } else if (this.isGameModeActive(3076)) {
         gameIntegerValue20 = 1;
      } else {
         if (this.isGameModeActive(2821) || this.isGameModeActive(18) || gameBooleanFlag12) {
            clearInteractionBounds();
            clearCollisionBounds();
            gameBooleanFlag12 = false;
            gameBooleanFlag08 = false;
            this.processActorAction(8);
            int var1 = gameIntegerArray01[gameIntegerValue09];
            if (gameIntegerValue20 == 0) {
               if (gameIntegerValue19 == 3) {
                  gameBooleanFlag05 = true;
                  gameBooleanFlag26 = true;
                  this.transitionGameState(0);
               } else if (gameIntegerValue19 == 5) {
                  this.gameByteValue04 = 0;
                  this.gameBooleanFlag41 = false;
                  this.gameBooleanFlag40 = false;
                  gameBooleanFlag04 = false;
                  this.writeSavedGameData();
                  this.changeActorAction(8, 0);
                  this.updateCanvasState();
                  this.setGameSubstate(260);
                  gameBooleanFlag60 = false;
               } else if (gameIntegerValue19 == 24) {
                  if (gameBooleanFlag04) {
                     if (gameIntegerValue103 != 3) {
                        gameBooleanFlag09 = true;
                     }

                     if (!this.readSavedGameData()) {
                        this.resetLevelEvents();
                     }

                     this.loadGameCanvasAssets();
                  } else {
                     this.resetLevelEvents();
                     this.initializeActorGroup();
                  }

                  gameByteValue07 = 2;
                  gameShortValue01 = 0;
                  this.restoreAudioState();
               } else if (gameIntegerValue19 == 292) {
                  this.initializeGameplay();
               } else if (var1 == 21) {
                  if (gameIntegerValue103 != 3) {
                     gameBooleanFlag09 = true;
                  }

                  if (!this.readSavedGameData()) {
                     this.resetLevelEvents();
                  }

                  this.loadGameCanvasAssets();
                  this.setViewport(0, 300, 301);
                  this.restoreAudioState();
               } else if (var1 == 22) {
                  gameIntegerValue103 = -1;
                  this.changeActorAction(10, 0);
                  this.resetLevelEvents();
               } else if (var1 == 23 || gameIntegerValue19 == 4) {
                  bool var2 = true;
                  this.writeSavedGameData();
                  stopAllAudio();
                  GloftRESE.gameCanvasReference01 = null;
                  gameIntegerValue126 = -1;
               }
            } else {
               if (gameIntegerValue19 == 24) {
                  this.changeActorAction(10, 0);
                  this.resetLevelEvents();
                  gameByteValue07 = 2;
                  gameShortValue01 = 0;
               }

               if (gameIntegerValue19 == 3) {
                  gameBooleanFlag26 = true;
               }
            }

            initializeInputState();
            if (gameIntegerValue19 == 4) {
               stopSoundEffect(0);
               return;
            }
         } else if (this.isGameModeActive(19) && gameIntegerValue19 != 3 && gameIntegerValue19 != 24) {
            clearInteractionBounds();
            clearCollisionBounds();
            gameBooleanFlag12 = false;
            gameBooleanFlag08 = false;
            this.processActorAction(21);
         }
      }
   }

   // $VF: renamed from: w () void
   public void loadTileDimensions() {
      gameIntegerValue34 = gameSpriteDecoderReferenceArray09[0].getSpriteWidth(37);
      gameIntegerValue35 = gameSpriteDecoderReferenceArray09[0].getSpriteHeight(37);
      if (gameIntegerValue17 == 2) {
         gameGraphicsReference02.setColor(0);
         fillRectangle(gameGraphicsReference02, 0, 0, 360, 640);
         int var6 = gameIntegerValue19;
         drawCenteredText(gameGraphicsReference02, getStringResource(gameIntegerValue19), 0, 180, 200, 0, 0, 360, 640, 36);
         if (gameIntegerValue20 != 0) {
            gameSpriteDecoderReferenceArray08[1].setGraphicsTransform(0);
            SpriteResourceDecoder var42 = gameSpriteDecoderReferenceArray09[0];
            Graphics var14 = gameGraphicsReference02;
            var42.drawSpriteFrameTransformed(var14, 37, 90, 290, 0, 0, 0);
         } else {
            if ((JSystem.currentTimeMillis() & 64L) != 0L && gameBooleanFlag13) {
               gameSpriteDecoderReferenceArray08[1].setGraphicsTransform(0);
            } else {
               gameSpriteDecoderReferenceArray08[1].setGraphicsTransform(1);
            }

            SpriteResourceDecoder var10000 = gameSpriteDecoderReferenceArray09[0];
            Graphics var10001 = gameGraphicsReference02;
            int var2 = (JSystem.currentTimeMillis() & 64L) != 0L && gameBooleanFlag13 ? 37 : 38;
            Graphics var1 = var10001;
            var10000.drawSpriteFrameTransformed(var1, var2, 90, 290, 0, 0, 0);
         }

         SpriteResourceDecoder var43 = gameSpriteDecoderReferenceArray08[1];
         Graphics var55 = gameGraphicsReference02;
         bool var7 = true;
         string var23 = getStringResource(1).toUpperCase();
         Graphics var15 = var55;
         var43.drawBitmapTextLine(var15, var23, 90, 290, 3, true);
         addCollisionBounds(90 - (gameIntegerValue34 >> 1), 290 - (gameIntegerValue35 >> 1), gameIntegerValue34, gameIntegerValue35, 10);
         if (gameIntegerValue20 != 1) {
            gameSpriteDecoderReferenceArray08[1].setGraphicsTransform(0);
            var43 = gameSpriteDecoderReferenceArray09[0];
            var15 = gameGraphicsReference02;
            var43.drawSpriteFrameTransformed(var15, 37, 270, 290, 0, 0, 0);
         } else {
            if ((JSystem.currentTimeMillis() & 64L) != 0L && gameBooleanFlag13) {
               gameSpriteDecoderReferenceArray08[1].setGraphicsTransform(0);
            } else {
               gameSpriteDecoderReferenceArray08[1].setGraphicsTransform(1);
            }

            var43 = gameSpriteDecoderReferenceArray09[0];
            var55 = gameGraphicsReference02;
            int var24 = (JSystem.currentTimeMillis() & 64L) != 0L && gameBooleanFlag13 ? 37 : 38;
            var15 = var55;
            var43.drawSpriteFrameTransformed(var15, var24, 270, 290, 0, 0, 0);
         }

         var43 = gameSpriteDecoderReferenceArray08[1];
         var55 = gameGraphicsReference02;
         sbyte var8 = 2;
         var23 = getStringResource(2).toUpperCase();
         var15 = var55;
         var43.drawBitmapTextLine(var15, var23, 270, 290, 3, true);
         addCollisionBounds(270 - (gameIntegerValue34 >> 1), 290 - (gameIntegerValue35 >> 1), gameIntegerValue34, gameIntegerValue35, 11);
      } else {
         this.drawTileLayer(gameGraphicsReference02, 40, UiLayoutPresetD.integerValue02, 280, UiLayoutPresetD.integerValue01, 6);
         int var9 = 543826;
         gameGraphicsReference02.setColor(var9);
         drawLine(gameGraphicsReference02, 41, UiLayoutPresetD.integerValue04, 318, UiLayoutPresetD.integerValue05);
         gameSpriteDecoderReferenceArray08[0].setGraphicsTransform(4);
         int var10 = gameIntegerValue18;
         drawTextWithFont(gameGraphicsReference02, getStringResource(gameIntegerValue18), 180, UiLayoutPresetD.integerValue03, 36);
         gameSpriteDecoderReferenceArray08[0].setGraphicsTransform(3);
         int var11 = gameIntegerValue19;
         drawCenteredText(gameGraphicsReference02, getStringResource(gameIntegerValue19), 0, 42, UiLayoutPresetD.integerValue06, 42, UiLayoutPresetD.integerValue06, 320, UiLayoutPresetD.integerValue06 + UiLayoutPresetD.integerValue07, 20);
         if (gameIntegerValue17 == 0) {
            gameSpriteDecoderReferenceArray08[0].setGraphicsTransform(0);
            addCollisionBounds(180 - (gameIntegerValue34 >> 1), UiLayoutPresetD.integerValue08 - (gameIntegerValue35 >> 1), gameIntegerValue34, gameIntegerValue35, 11);
            if ((JSystem.currentTimeMillis() & 64L) != 0L && gameBooleanFlag13) {
               gameSpriteDecoderReferenceArray08[0].setGraphicsTransform(3);
            }

            SpriteResourceDecoder var47 = gameSpriteDecoderReferenceArray09[0];
            Graphics var58 = gameGraphicsReference02;
            int var10002 = (JSystem.currentTimeMillis() & 64L) != 0L && gameBooleanFlag13 ? 37 : 38;
            int var3 = UiLayoutPresetD.integerValue08;
            int var26 = var10002;
            Graphics var19 = var58;
            var47.drawSpriteFrameTransformed(var19, var26, 180, var3, 0, 0, 0);
            var47 = gameSpriteDecoderReferenceArray08[1];
            var58 = gameGraphicsReference02;
            short var12 = 295;
            string var64 = getStringResource(295).toUpperCase();
            var3 = UiLayoutPresetD.integerValue08;
            string var27 = var64;
            var19 = var58;
            var47.drawBitmapTextLine(var19, var27, 180, var3, 3, true);
         } else {
            short var13 = 295;
            short var21 = 296;
            if (gameIntegerValue19 == 24) {
               var13 = 1;
               var21 = 2;
            }

            if (gameIntegerValue20 != 0) {
               gameSpriteDecoderReferenceArray08[1].setGraphicsTransform(0);
               SpriteResourceDecoder var50 = gameSpriteDecoderReferenceArray09[0];
               int var39 = UiLayoutPresetD.integerValue08;
               Graphics var34 = gameGraphicsReference02;
               var50.drawSpriteFrameTransformed(var34, 37, 110, var39, 0, 0, 0);
            } else {
               if ((JSystem.currentTimeMillis() & 64L) != 0L && gameBooleanFlag13) {
                  gameSpriteDecoderReferenceArray08[1].setGraphicsTransform(0);
               } else {
                  gameSpriteDecoderReferenceArray08[1].setGraphicsTransform(1);
               }

               SpriteResourceDecoder var49 = gameSpriteDecoderReferenceArray09[0];
               Graphics var60 = gameGraphicsReference02;
               int var65 = (JSystem.currentTimeMillis() & 64L) != 0L && gameBooleanFlag13 ? 37 : 38;
               int var5 = UiLayoutPresetD.integerValue08;
               int var4 = var65;
               Graphics var33 = var60;
               var49.drawSpriteFrameTransformed(var33, var4, 110, var5, 0, 0, 0);
            }

            SpriteResourceDecoder var51 = gameSpriteDecoderReferenceArray08[1];
            Graphics var61 = gameGraphicsReference02;
            string var66 = getStringResource(var13).toUpperCase();
            int var40 = UiLayoutPresetD.integerValue08;
            string var35 = var66;
            Graphics var28 = var61;
            var51.drawBitmapTextLine(var28, var35, 110, var40, 3, true);
            addCollisionBounds(110 - (gameIntegerValue34 >> 1), UiLayoutPresetD.integerValue08 - (gameIntegerValue35 >> 1), gameIntegerValue34, gameIntegerValue35, 10);
            if (gameIntegerValue20 != 1) {
               gameSpriteDecoderReferenceArray08[1].setGraphicsTransform(0);
               var51 = gameSpriteDecoderReferenceArray09[0];
               int var37 = UiLayoutPresetD.integerValue08;
               var28 = gameGraphicsReference02;
               var51.drawSpriteFrameTransformed(var28, 37, 248, var37, 0, 0, 0);
            } else {
               if ((JSystem.currentTimeMillis() & 64L) != 0L && gameBooleanFlag13) {
                  gameSpriteDecoderReferenceArray08[1].setGraphicsTransform(0);
               } else {
                  gameSpriteDecoderReferenceArray08[1].setGraphicsTransform(1);
               }

               var51 = gameSpriteDecoderReferenceArray09[0];
               var61 = gameGraphicsReference02;
               int var67 = (JSystem.currentTimeMillis() & 64L) != 0L && gameBooleanFlag13 ? 37 : 38;
               var40 = UiLayoutPresetD.integerValue08;
               int var36 = var67;
               var28 = var61;
               var51.drawSpriteFrameTransformed(var28, var36, 248, var40, 0, 0, 0);
            }

            var51 = gameSpriteDecoderReferenceArray08[1];
            var61 = gameGraphicsReference02;
            var66 = getStringResource(var21).toUpperCase();
            int var38 = UiLayoutPresetD.integerValue08;
            string var31 = var66;
            Graphics var22 = var61;
            var51.drawBitmapTextLine(var22, var31, 248, var38, 3, true);
            addCollisionBounds(248 - (gameIntegerValue34 >> 1), UiLayoutPresetD.integerValue08 - (gameIntegerValue35 >> 1), gameIntegerValue34, gameIntegerValue35, 11);
         }
      }

      gameSpriteDecoderReferenceArray08[0].setGraphicsTransform(0);
      gameBooleanFlag10 = true;
   }

   // $VF: renamed from: x () void
   public void initializeGameplay() {
      gameBooleanFlag04 = true;
      this.writeSavedGameData();
      this.hasSavedGameData();
      this.setViewport(0, 298, 299);
   }

   // $VF: renamed from: a (int) void
   public void processActorAction(int var1) {
      bool var2 = false;
      if (var1 == 14 || var1 == 23 || var1 == 15) {
         var2 = true;
      }

      if (var1 == 27
         || var1 == 31
         || var1 == 7
         || var1 == 33
         || var1 == 14
         || var1 == 41
         || var1 == 40
         || var1 == 4
         || var1 == 43
         || var1 == 47
         || var1 == 51
         || var1 == 42
         || var1 == 46
         || var1 == 50) {
         var2 = true;
      }

      if (!isAudioEnabled() || var2) {
         if (!gameBooleanFlag62) {
            gameIntegerValue24 = 1;
            if (var2) {
               stopAudioPlayer();
            }

            playSoundEffect(1, var1);
            gameIntegerValue24 = 0;
         }
      }
   }

   // $VF: renamed from: b (int) void
   public void transitionGameState(int var1) {
      if (this.gameIntegerValue01 == this.gameIntegerValue02 || var1 != 2) {
         gameIntegerValue23 = var1;
      }

      bool var2 = false;
      if (var1 == 1 || var1 == 1) {
         var2 = true;
      }

      if (gameBooleanFlag05) {
         if (gameIntegerValue48 != 9) {
            if (!isAudioEnabled() || var2) {
               gameIntegerValue23 = -1;
               if (gameBooleanFlag62) {
                  gameIntegerValue124 = var1;
               } else {
                  playSoundEffect(gameIntegerValue24, var1);
               }
            }
         }
      }
   }

   // $VF: renamed from: y () void
   public static void stopAllAudio() {
      stopAudioPlayer();
      stopAudioPlayer();
      gameIntegerValue23 = -1;
   }

   // $VF: renamed from: z () void
   public void restoreAudioState() {
      int var1 = gameIntegerValue23;
      stopAllAudio();
      gameIntegerValue23 = var1;
   }

   // $VF: renamed from: A () void
   public void resumeBackgroundMusic() {
      if (gameIntegerValue23 != -1) {
         this.transitionGameState(gameIntegerValue23);
      }
   }

   // $VF: renamed from: a () boolean
   public static bool isAudioEnabled() {
      try {
         return gameIntegerValue26 != 27
               && gameIntegerValue26 != 7
               && gameIntegerValue26 != 31
               && gameIntegerValue26 != 33
               && gameIntegerValue26 != 14
               && gameIntegerValue26 != 41
               && gameIntegerValue26 != 40
               && gameIntegerValue26 != 22
            ? gamePlayerReference01 != null && gamePlayerReference01.getState() == 400
            : gamePlayerReferenceArray01[gameIntegerValue26] != null && gamePlayerReferenceArray01[gameIntegerValue26].getState() == 400;
      } catch (System.Exception var0) {
         return false;
      }
   }

   // $VF: renamed from: g (int, int) void
   public static void playSoundEffect(int var0, int var1) {
      if (gameBooleanFlag05 && var1 < 52) {
         try {
            if (gameByteStreamReferenceArray01[var1] != null) {
               stopAudioPlayer();
               if (var1 != 27 && var1 != 31 && var1 != 7 && var1 != 33 && var1 != 14 && var1 != 41 && var1 != 40 && var1 != 22) {
                  gameLongValue01 = JSystem.currentTimeMillis();
                  gameByteStreamReferenceArray01[var1].reset();
                  (gamePlayerReference01 = Manager.createPlayer(gameByteStreamReferenceArray01[var1], gameTextArray01[var1])).realize();
               }

               if (var1 != 27 && var1 != 7 && var1 != 31 && var1 != 33 && var1 != 14 && var1 != 41 && var1 != 40) {
                  JSystem.@out.println("!!!!!!!!!!!!!!!!!!!  s_soundType[i] = ");
                  gamePlayerReference01.setLoopCount(1);
                  gamePlayerReference01.prefetch();
                  gamePlayerReference01.setMediaTime(-1L);
                  gamePlayerReference01.start();
               } else {
                  JSystem.@out.println("@@@@@@@@@@@@@@ s_soundType[i] = cacheeeeeeeee ");
                  if (gamePlayerReferenceArray01[var1] != null) {
                     gamePlayerReferenceArray01[var1].start();
                     gameIntegerValue26 = var1;
                  }
               }

               gameLongValue01 = JSystem.currentTimeMillis();
            }

            gameIntegerValue25 = var1;
            return;
         } catch (System.Exception var2) {
            var2.printStackTrace();
         }
      }
   }

   // $VF: renamed from: n (int) void
   public static void stopSoundEffect(int var0) {
      if (gameIntegerValue25 == var0) {
         stopAudioPlayer();
      }
   }

   // $VF: renamed from: a () void
   public static void stopBackgroundMusic() {
      stopAudioPlayer();
   }

   // $VF: renamed from: b () void
   public static void stopAudioPlayer() {
      try {
         if (gamePlayerReference01 != null) {
            if (gamePlayerReference01.getState() == 400) {
               gamePlayerReference01.stop();
            }

            if (gamePlayerReference01.getState() == 300) {
               gamePlayerReference01.deallocate();
            }

            gamePlayerReference01.close();
            gamePlayerReference01 = null;
         }

         if (gameIntegerValue26 == 27
            || gameIntegerValue26 == 7
            || gameIntegerValue26 == 31
            || gameIntegerValue26 == 33
            || gameIntegerValue26 == 14
            || gameIntegerValue26 == 41
            || gameIntegerValue26 == 40
            || gameIntegerValue26 == 22) {
            gamePlayerReferenceArray01[gameIntegerValue26].stop();
            gamePlayerReferenceArray01[gameIntegerValue26].deallocate();
            gameIntegerValue26 = -1;
         }

         gameIntegerValue25 = -1;
      } catch (System.Exception var0) {
         gameIntegerValue25 = -1;
      }
   }

   // $VF: renamed from: B () void
   public void buildGameConfiguration() {
      StringBuffer var10000 = new StringBuffer();
      short var1 = 365;
      var10000 = var10000.append(getStringResource(365));
      var1 = 902;
      var10000 = var10000.append(getStringResource(902));
      var1 = 903;
      var10000 = var10000.append(getStringResource(903));
      var1 = 904;
      string var11 = gameTextValue02 = var10000.append(getStringResource(904)).toString();
      string var2 = gameMidletReference01.getAppProperty("MIDlet-Version");
      gameTextValue02 = formatLocalizedString(var11, new string[]{var2});
      SpriteResourceDecoder var12 = gameSpriteDecoderReferenceArray08[0];
      int var3 = screenWidth - 20;
      var2 = gameTextValue02;
      gameShortArray01 = var12.loadBitmapFont(var2, var3, false);
      this.gameIntegerValue01 = UiLayoutPresetB.integerValue06 + UiLayoutPresetB.integerValue07;
      SpriteAnimation.loadAnimationTables();
      this.transitionGameState(6);
   }

   public override void pointerPressed(int var1, int var2) {
      GameUiController.drawMenuEntry(var1, var2);
      gameLongValue04 = JSystem.currentTimeMillis();
      gameBooleanFlag22 = false;
      gameBooleanFlag20 = true;
      gameBooleanFlag21 = false;
      gameIntegerValue29 = var2;
      this.setPointerBounds(var1, var2);
      if (gameBooleanFlag17 && gameRectangleBoundsReference01 == null && gameRectangleBoundsReference02 == null && gameBooleanFlag20 && !gameBooleanFlag14) {
         gameClass11Reference03.playAnimation(2, 1);
         gameBooleanFlag14 = true;
      }
   }

   // $VF: renamed from: h (int, int) void
   public void setPointerBounds(int var1, int var2) {
      gameIntegerValue31 = var1;
      gameIntegerValue32 = var2;
      gameRectangleBoundsReference01 = null;
      gameRectangleBoundsReference02 = null;
      if (gameIntegerValue50 == 139 && this.gameIntegerValue33 == -1 && !gameBooleanFlag29 && gameBooleanFlag22) {
         this.gameIntegerValue33 = -1;
         int var3 = var1 - 180;
         int var4 = var2 - AnimationTables.integerValue02;
         int var5 = var3 < 0 ? -var3 : var3;
         int var6 = var4 < 0 ? -var4 : var4;
         int var7 = var3 * var3;
         int var8 = var4 * var4;
         if ((var5 > UiLayoutPresetC.integerValue10 || var6 > UiLayoutPresetC.integerValue10) && var7 + var8 <= UiLayoutPresetC.integerValue11 * UiLayoutPresetC.integerValue11) {
            if (var5 == 0) {
               var5 = 491520;
            } else {
               var5 = (var6 << 16) / var5;
            }

            if (var5 <= 17039) {
               if (var3 < 0) {
                  this.gameIntegerValue33 = 9;
               } else {
                  this.gameIntegerValue33 = 3;
               }
            } else if (var5 >= 245760) {
               if (var4 < 0) {
                  this.gameIntegerValue33 = 0;
               } else {
                  this.gameIntegerValue33 = 6;
               }
            } else if (var5 > 17039 && var5 <= 65536) {
               if (var3 < 0 && var4 < 0) {
                  this.gameIntegerValue33 = 10;
               } else if (var3 < 0 && var4 > 0) {
                  this.gameIntegerValue33 = 8;
               } else if (var3 > 0 && var4 > 0) {
                  this.gameIntegerValue33 = 4;
               } else if (var3 > 0 && var4 < 0) {
                  this.gameIntegerValue33 = 2;
               }
            } else if (var5 > 65536 && var5 < 245760) {
               if (var3 < 0 && var4 < 0) {
                  this.gameIntegerValue33 = 11;
               } else if (var3 < 0 && var4 > 0) {
                  this.gameIntegerValue33 = 7;
               }

               if (var3 > 0 && var4 < 0) {
                  this.gameIntegerValue33 = 1;
               }

               if (var3 > 0 && var4 > 0) {
                  this.gameIntegerValue33 = 5;
               }
            }

            JSystem.@out.println("aaaaaaaaaaaaaaaa " + this.gameIntegerValue33);
         }

         if (this.gameIntegerValue33 != -1) {
            gameLongValue03 = JSystem.currentTimeMillis();
            if (this.gameIntegerValue33 > this.gameByteValue25 && this.gameIntegerValue33 - this.gameByteValue25 > -6) {
               gameBooleanFlag18 = true;
            } else {
               gameBooleanFlag18 = false;
            }

            this.gameIntegerValue33 = this.gameIntegerValue33 - this.gameByteValue25 < 0 ? -(this.gameIntegerValue33 - this.gameByteValue25) : this.gameIntegerValue33 - this.gameByteValue25;
         }
      }

      for (int var11 = gameCollectionReference01.size() - 1; var11 >= 0; var11--) {
         RectangleBounds var9;
         if ((var9 = (RectangleBounds)gameCollectionReference01.elementAt(var11)).containsPointStrictly(var1, var2)) {
            gameRectangleBoundsReference01 = var9;
            break;
         }
      }

      if (gameRectangleBoundsReference01 != null) {
         gameBooleanFlag19 = false;
      }

      for (int var12 = gameCollectionReference02.size() - 1; var12 >= 0; var12--) {
         RectangleBounds var10;
         if ((var10 = (RectangleBounds)gameCollectionReference02.elementAt(var12)).containsPointStrictly(var1, var2)) {
            gameRectangleBoundsReference02 = var10;
            return;
         }
      }
   }

   public override void pointerDragged(int var1, int var2) {
      GameUiController.initializeMenuTransition(var1, var2);
      gameBooleanFlag21 = true;
      gameBooleanFlag20 = false;
      gameBooleanFlag22 = false;
      this.setPointerBounds(var1, var2);
   }

   public override void pointerReleased(int var1, int var2) {
      if (gameRectangleBoundsReference01 != null && gameRectangleBoundsReference01.boundsId == 14) {
         gameIntegerValue45 = 0;
      }

      gameBooleanFlag14 = false;
      GameUiController.drawMenuSelection(var1, var2);
      gameBooleanFlag21 = false;
      gameBooleanFlag20 = false;
      gameBooleanFlag22 = true;
      this.setPointerBounds(var1, var2);
      gameBooleanFlag06 = true;
      gameBooleanFlag16 = false;
   }

   // $VF: renamed from: c () void
   public static void clearCollisionBounds() {
      gameCollectionReference01.removeAllElements();
      gameRectangleBoundsReference01 = null;
      gameBooleanFlag10 = false;
      gameBooleanFlag21 = false;
      gameBooleanFlag20 = false;
      gameBooleanFlag22 = false;
      gameLongValue04 = 0L;
      initializeInputState();
      gameBooleanFlag13 = false;
      gameLongValue02 = 0L;
      gameBooleanFlag12 = false;
      gameIntegerValue45 = 0;
      initializeInputState();
      gameBooleanFlag06 = true;
   }

   // $VF: renamed from: d () void
   public static void clearInteractionBounds() {
      gameCollectionReference02.removeAllElements();
      gameRectangleBoundsReference02 = null;
      gameBooleanFlag11 = false;
      gameBooleanFlag21 = false;
      gameBooleanFlag20 = false;
      gameBooleanFlag22 = false;
      gameLongValue04 = 0L;
      gameBooleanFlag13 = false;
      gameLongValue02 = 0L;
      gameBooleanFlag12 = false;
      gameBooleanFlag17 = false;
      gameBooleanFlag19 = false;
      gameBooleanFlag15 = false;
      initializeInputState();
   }

   // $VF: renamed from: a (int, int, int, int, int) void
   public static void addCollisionBounds(int var0, int var1, int var2, int var3, int var4) {
      if (!gameBooleanFlag10) {
         RectangleBounds var5 = new RectangleBounds(var0, var1, var2, var3, var4);
         gameCollectionReference01.addElement(var5);
         gameRectangleBoundsReference01 = null;
      }
   }

   // $VF: renamed from: b (int, int, int, int, int) void
   public static void addInteractionBounds(int var0, int var1, int var2, int var3, int var4) {
      if (!gameBooleanFlag11) {
         RectangleBounds var5 = new RectangleBounds(var0, var1, var2, var3, var4);
         gameCollectionReference02.addElement(var5);
         gameRectangleBoundsReference02 = null;
      }
   }

   // $VF: renamed from: b (javax.microedition.lcdui.Graphics) void
   public void renderGameWorld(Graphics var1) {
      gameBooleanFlag17 = false;
      if (!gameBooleanFlag29) {
         if (gameByteValue07 != 0 && gameByteValue07 != 1 && gameIntegerValue50 != 131 && !isGameplayRunning()) {
            if (!gameBooleanFlag53) {
               gameBooleanFlag17 = true;
               gameIntegerValue34 = gameSpriteDecoderReferenceArray09[1].getSpriteWidth(1) + 2;
               gameIntegerValue35 = gameSpriteDecoderReferenceArray09[1].getSpriteHeight(1) + 2;
               SpriteResourceDecoder var10000 = gameSpriteDecoderReferenceArray09[1];
               int var10002 = gameRectangleBoundsReference01 != null && gameRectangleBoundsReference01.boundsId == 10 ? 8 : 7;
               int var6 = UiLayoutPresetC.integerValue04;
               int var5 = UiLayoutPresetC.integerValue03;
               int var4 = var10002;
               Graphics var3 = gameGraphicsReference02;
               var10000.drawSpriteFrameTransformed(var3, var4, var5, var6, 0, 0, 0);
               addCollisionBounds(UiLayoutPresetC.integerValue03 - gameIntegerValue34, UiLayoutPresetC.integerValue04 - gameIntegerValue35 - 15, gameIntegerValue34, gameIntegerValue35 + 15, 10);
               var10000 = gameSpriteDecoderReferenceArray09[1];
               var10002 = gameRectangleBoundsReference01 != null && gameRectangleBoundsReference01.boundsId == 11 ? 2 : 1;
               var6 = UiLayoutPresetC.integerValue04;
               var5 = UiLayoutPresetC.integerValue03;
               var4 = var10002;
               var3 = gameGraphicsReference02;
               var10000.drawSpriteFrameTransformed(var3, var4, var5, var6, 0, 0, 0);
               addCollisionBounds(UiLayoutPresetC.integerValue03, UiLayoutPresetC.integerValue04 - gameIntegerValue35 - 15, gameIntegerValue34 + 15, gameIntegerValue35 + 15, 11);
               var10000 = gameSpriteDecoderReferenceArray09[1];
               var10002 = gameRectangleBoundsReference01 != null && gameRectangleBoundsReference01.boundsId == 12 ? 4 : 3;
               var6 = UiLayoutPresetC.integerValue04;
               var5 = UiLayoutPresetC.integerValue03;
               var4 = var10002;
               var3 = gameGraphicsReference02;
               var10000.drawSpriteFrameTransformed(var3, var4, var5, var6, 0, 0, 0);
               addCollisionBounds(UiLayoutPresetC.integerValue03, UiLayoutPresetC.integerValue04, gameIntegerValue34 + 15, gameIntegerValue35, 12);
               var10000 = gameSpriteDecoderReferenceArray09[1];
               var10002 = gameRectangleBoundsReference01 != null && gameRectangleBoundsReference01.boundsId == 13 ? 6 : 5;
               var6 = UiLayoutPresetC.integerValue04;
               var5 = UiLayoutPresetC.integerValue03;
               var4 = var10002;
               var3 = gameGraphicsReference02;
               var10000.drawSpriteFrameTransformed(var3, var4, var5, var6, 0, 0, 0);
               addCollisionBounds(UiLayoutPresetC.integerValue03 - gameIntegerValue34, UiLayoutPresetC.integerValue04, gameIntegerValue34, gameIntegerValue35, 13);
               gameIntegerValue34 = gameSpriteDecoderReferenceArray09[1].getSpriteWidth(9) + 2;
               gameIntegerValue35 = gameSpriteDecoderReferenceArray09[1].getSpriteHeight(9) + 2;
               int var2 = gameRectangleBoundsReference01 != null && gameRectangleBoundsReference01.boundsId == 14 ? 10 : 9;
               if (gameIntegerValue50 != 900 && gameIntegerValue50 != 901 && gameIntegerValue50 != 647 && gameIntegerValue50 != 646) {
                  var2 += 2;
               }

               var10000 = gameSpriteDecoderReferenceArray09[1];
               var6 = screenHeight - (gameIntegerValue35 >> 1) - 8;
               var5 = UiLayoutPresetC.integerValue05;
               var3 = gameGraphicsReference02;
               var10000.drawSpriteFrameTransformed(var3, var2, var5, var6, 0, 0, 0);
               addCollisionBounds(UiLayoutPresetC.integerValue05 - (gameIntegerValue34 >> 1), screenHeight - gameIntegerValue35 - 8, gameIntegerValue34, gameIntegerValue35, 14);
               if (this.gameActorGroupReference01.byteValue02 == gameIntegerArray02[this.gameActorGroupReference01.byteValue04] && this.gameActorGroupReference01.byteValue04 != 0 && this.gameActorGroupReference01.byteValue02 != 0) {
                  drawTextWithFont(
                     var1,
                     "" + this.gameActorGroupReference01.byteArray01[this.gameActorGroupReference01.byteValue04],
                     UiLayoutPresetC.integerValue07 - 3,
                     screenHeight - gameIntegerValue35 - 2 + 42 - AnimationTables.byteArray03[0],
                     68
                  );
               }

               gameIntegerValue34 = gameSpriteDecoderReferenceArray09[1].getSpriteWidth(13) + 2;
               gameIntegerValue35 = gameSpriteDecoderReferenceArray09[1].getSpriteHeight(13) + 2;
               var10000 = gameSpriteDecoderReferenceArray09[1];
               var10002 = gameRectangleBoundsReference01 != null && gameRectangleBoundsReference01.boundsId == 15 ? 14 : 13;
               int var10003 = UiLayoutPresetC.integerValue07 + (gameIntegerValue34 >> 1);
               var6 = screenHeight - (gameIntegerValue35 >> 1) - 2;
               var5 = var10003;
               var4 = var10002;
               var3 = gameGraphicsReference02;
               var10000.drawSpriteFrameTransformed(var3, var4, var5, var6, 0, 0, 0);
               var2 = gameSpriteDecoderReferenceArray06[1].getSpriteHeight(1);
               int var18 = gameSpriteDecoderReferenceArray06[1].getSpriteWidth(1);
               var10000 = gameSpriteDecoderReferenceArray06[1];
               var10002 = 1 + this.gameActorGroupReference01.entitySnapshotReferenceArray01[this.gameActorGroupReference01.byteValue02].byteValue02;
               var10003 = UiLayoutPresetC.integerValue07 + (gameIntegerValue34 - var18 >> 1);
               var4 = screenHeight - gameIntegerValue35 + (gameIntegerValue35 - var2 >> 1) - 2;
               int var19 = var10003;
               var2 = var10002;
               var10000.drawSpriteFrameTransformed(var1, var2, var19, var4, 0, 0, 0);
               addCollisionBounds(UiLayoutPresetC.integerValue07, screenHeight - gameIntegerValue35 - 2, gameIntegerValue34, gameIntegerValue35, 15);
               gameBooleanFlag10 = true;
               if (!gameClass11Reference03.isAnimationFinished()) {
                  SpriteAnimation var7 = gameClass11Reference03;
                  if (gameClass11Reference03.animationId == 2 && gameIntegerValue50 != 646 && gameIntegerValue50 != 647) {
                     var2 = gameIntegerValue32;
                     int var9 = gameIntegerValue31;
                     SpriteAnimation var8 = gameClass11Reference03;
                     gameClass11Reference03.drawX = var9;
                     var8.drawY = var2;
                     gameClass11Reference03.advanceAnimation(gameIntegerValue129);
                  }
               }
            }
         }
      }
   }

   // $VF: renamed from: C () void
   public void clearActiveBounds() {
      if (gameRectangleBoundsReference01 != null || gameRectangleBoundsReference02 != null || !gameBooleanFlag20 && !gameBooleanFlag21) {
         if (gameRectangleBoundsReference01 != null && !gameBooleanFlag20 && !gameBooleanFlag21 || gameBooleanFlag22) {
            gameIntegerValue45 = 0;
            return;
         }

         if (gameRectangleBoundsReference01 != null && (gameRectangleBoundsReference01.boundsId == 14 || gameRectangleBoundsReference01.boundsId == 15 || gameRectangleBoundsReference01.boundsId == 1001 || gameRectangleBoundsReference01.boundsId == 999)) {
            gameIntegerValue45 = 0;
         }
      } else {
         if (gameBooleanFlag17 && JSystem.currentTimeMillis() - gameLongValue04 < 100L) {
            gameBooleanFlag06 = false;
            gameBooleanFlag19 = true;
         } else {
            gameBooleanFlag06 = true;
            gameBooleanFlag19 = false;
         }

         int var1 = this.getTilePixelX(this.gameActorGroupReference01.actorStateReference01.byteValue01, this.gameActorGroupReference01.actorStateReference01.byteValue02) - this.gameIntegerValue53 + 108;
         sbyte var3 = this.gameActorGroupReference01.actorStateReference01.byteValue02;
         sbyte var2 = this.gameActorGroupReference01.actorStateReference01.byteValue01;
         int var4 = (var3 + var2) * 27 - this.gameIntegerValue54 + 54;
         if (absoluteValue(gameIntegerValue31 - (var1 - 54)) > 27 || absoluteValue(gameIntegerValue32 - (var4 - 27)) > 13) {
            if (gameIntegerValue31 < var1 - 54) {
               if (gameIntegerValue32 < var4 - 27) {
                  gameIntegerValue45 = 2563;
                  return;
               }

               gameIntegerValue45 = 3586;
               return;
            }

            if (gameIntegerValue31 >= var1 - 54) {
               if (gameIntegerValue32 < var4 - 27) {
                  gameIntegerValue45 = 2049;
                  return;
               }

               gameIntegerValue45 = 3076;
               return;
            }
         }
      }
   }

   public GameCanvas(object var1, object var2) {
      gameGameCanvasReference01 = this;
      gameIntegerValue126 = -1;
      gameBooleanFlag66 = true;
      gameMidletReference01 = (MIDlet)var1;
      gameDisplayReference01 = null;
      this.showGameCanvas();
      gameHashtableReference02 = new Hashtable();
      (gameHashtableReference01 = new Hashtable()).put(new Integer(48), new Integer(6));
      gameHashtableReference01.put(new Integer(49), new Integer(7));
      gameHashtableReference01.put(new Integer(50), new Integer(1));
      gameHashtableReference01.put(new Integer(51), new Integer(9));
      gameHashtableReference01.put(new Integer(52), new Integer(3));
      gameHashtableReference01.put(new Integer(53), new Integer(5));
      gameHashtableReference01.put(new Integer(54), new Integer(4));
      gameHashtableReference01.put(new Integer(55), new Integer(13));
      gameHashtableReference01.put(new Integer(56), new Integer(2));
      gameHashtableReference01.put(new Integer(57), new Integer(15));
      gameHashtableReference01.put(new Integer(35), new Integer(17));
      gameHashtableReference01.put(new Integer(42), new Integer(16));
      gameHashtableReference01.put(new Integer(-6), new Integer(18));
      gameHashtableReference01.put(new Integer(-7), new Integer(19));
      gameHashtableReference02.put(new Integer(-5), new Integer(5));
      gameHashtableReference02.put(new Integer(-1), new Integer(1));
      gameHashtableReference02.put(new Integer(-2), new Integer(2));
      gameHashtableReference02.put(new Integer(-3), new Integer(3));
      gameHashtableReference02.put(new Integer(-4), new Integer(4));
      gameLongValue15 = JSystem.currentTimeMillis();
      this.gameLongValue14 = gameLongValue15;
      this.gameIntegerValue33 = -1;
      this.gameBooleanFlag28 = false;
      Runtime.getRuntime();
      this.gameRandomReference01 = new Random();
      this.gameActorGroupReference03 = new ActorGroup(this);
      this.gameActorGroupReference04 = new ActorGroup(this);
      this.gameBooleanArray01 = new bool[4];
      this.gameEntityFrameDataReferenceArray01 = new EntityFrameData[5];
      this.gameClass22ReferenceArray01 = new TimedEntityEffect[10];
      this.gameShortArray02 = new short[150];
      this.gameByteArray01 = new sbyte[150];
      this.gameClass19ReferenceArray02 = new ActorStatus[20];
      this.gameClass19Reference01 = new ActorStatus(this);
      this.gameBooleanArray02 = new bool[189];
      this.gameByteMatrix03 = JArr.New2<sbyte>(72, 50);
      this.gameByteMatrix04 = JArr.New2<sbyte>(72, 50);
      this.gameStringBufferReference01 = new StringBuffer(256);
      this.gameByteArray05 = new sbyte[3];
      this.gameBooleanFlag54 = false;
      this.gameIntegerValue104 = 0;
      this.gameIntegerValue105 = 0;
      this.gameIntegerValue106 = 0;
      this.gameIntegerValue107 = 0;
      this.gameIntegerValue108 = 0;
      this.gameIntegerValue109 = 0;
      this.gameIntegerValue110 = 0;
      this.gameIntegerValue111 = 0;
      this.gameIntegerValue112 = 0;
      this.gameIntegerValue113 = 0;
      this.gameIntegerArray04 = null;
      this.gameBooleanFlag56 = false;
      this.gameIntegerValue115 = 0;
      this.gameIntegerValue116 = 0;
      this.gameBooleanFlag57 = true;
      this.gameIntegerValue122 = -1;
      storeGameSetting(false, 50, 8);
      storeGameSetting(false, 52, 10);
      storeGameSetting(false, 54, 12);
      storeGameSetting(false, 56, 14);
      storeGameSetting(false, 53, 11);
      gameGloftRESEReference01 = (GloftRESE)var1;
      gameClass18Reference01 = new GameModeController(this);
      gameClass12Reference01 = new GameplaySequenceController(this);
      gameClass10Reference01 = new HudRenderer(this);
      bool var4 = false;
      string var5 = "/EN";
      sbyte var9 = 0;
      string var6 = "/EN";
      initializeStringResources();
      openAssetStream(var6);
      getAssetSize(var9);
      if (gameBooleanFlag68) {
         sbyte[] var7 = loadAssetBytes(var9);
         loadResourceArchive(new ByteArrayInputStream(var7));
      } else {
         loadResourceArchive(gameInputStreamReference01);
      }

      closeAssetStream();
      loadStringResources();
      gameIntegerValue48 = 0;
      openAssetStream("/3");
      gameSpriteDecoderReferenceArray01[1] = createSpriteResource(1, true, true);
      closeAssetStream();
      openAssetStream("/1");
      gameSpriteDecoderReferenceArray08[0] = createSpriteResource(0, true, true);
      short[] var8 = (short[])readAssetObject(2);
      gameSpriteDecoderReferenceArray08[0].setSpritePaletteData(var8);
      gameSpriteDecoderReferenceArray08[0].setGraphicsTransform(0);
      closeAssetStream();
   }

   // $VF: renamed from: c () boolean
   public bool canProcessPointerInput() {
      if (isGameplayRunning() && gameBooleanFlag63) {
         return false;
      } else if (gameIntegerValue48 == 2 && this.gameIntegerValue49 == 10) {
         return false;
      } else if (this.gameActorGroupReference01 != null && this.gameActorGroupReference01.actorStateReference01 != null && this.gameActorGroupReference01.actorStateReference01.byteValue10 <= 0) {
         return false;
      } else {
         return this.gameActorStateReference03 != null && this.gameActorStateReference03.booleanFlag01 && this.gameActorStateReference03.byteValue10 <= 0
            ? false
            : gameIntegerValue48 == 2
                  && gameIntegerValue50 != 138
                  && gameIntegerValue50 != 130
                  && gameIntegerValue50 != 137
                  && gameIntegerValue50 != 139
                  && (gameIntegerValue50 != 131 || gameIntegerValue67 != 3)
                  && gameShortValue01 != 731
                  && gameBooleanFlag60
               || gameRectangleBoundsReference02 != null
                  && gameBooleanFlag22
                  && gameRectangleBoundsReference02.boundsId == 1001
                  && gameIntegerValue48 == 2
                  && gameIntegerValue50 != 138
                  && gameIntegerValue50 != 137
                  && gameIntegerValue50 != 139
                  && gameIntegerValue50 != 130
                  && (gameIntegerValue50 != 131 || gameIntegerValue67 != 3);
      }
   }

   // $VF: renamed from: a (int) boolean
   public bool isGameModeActive(int var1) {
      if (gameIntegerValue45 != 0) {
         return gameIntegerValue45 == var1;
      } else {
         int var2 = var1 & 0xFF;
         if ((var1 = var1 >> 8) > 0) {
            return this.gameBooleanFlag28 ? isInputEnabled(var2) || isInputEnabled(var1) : isInputPressed(var2) || isInputPressed(var1);
         } else {
            return this.gameBooleanFlag28 ? isInputEnabled(var2) : isInputPressed(var2);
         }
      }
   }

   // $VF: renamed from: a () int
   public int nextRandomByte() {
      return this.gameRandomReference01.nextInt() & 0xFF;
   }

   // $VF: renamed from: c () int
   public int nextRandomInteger() {
      return absoluteValue(this.nextRandomByte() << 24 | this.nextRandomByte() << 16 | this.nextRandomByte() << 8 | this.nextRandomByte());
   }

   // $VF: renamed from: e (javax.microedition.lcdui.Graphics, int, int, int, int) void
   public static void drawLine(Graphics var0, int var1, int var2, int var3, int var4) {
      var0.drawLine(var1, var2, var3, var4);
   }

   // $VF: renamed from: f (javax.microedition.lcdui.Graphics, int, int, int, int) void
   public static void drawRectangleOutline(Graphics var0, int var1, int var2, int var3, int var4) {
      var0.drawRect(var1, var2, var3 - 1, var4 - 1);
   }

   // $VF: renamed from: g (javax.microedition.lcdui.Graphics, int, int, int, int) void
   public static void fillRectangle(Graphics var0, int var1, int var2, int var3, int var4) {
      var0.fillRect(var1, var2, var3, var4);
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, int) void
   public void setRgbColor(Graphics var1, int var2) {
      int var10001 = var2 >> 16 & 0xFF;
      int var10002 = var2 >> 8 & 0xFF;
      int var3 = var2 & 0xFF;
      var2 = var10002;
      int var4 = var10001;
      var1.setColor(var4, var2, var3);
   }

   // $VF: renamed from: a (int) int
   public static int absoluteValue(int var0) {
      return (var0 ^ var0 >> 31) - (var0 >> 31);
   }

   // $VF: renamed from: b (int) int
   public static int integerSquareRoot(int var0) {
      if (var0 < 0) {
         return -1;
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

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, int, int, int, int, int, int, int, int) void
   public void drawClippedGameRegion(Graphics var1, int var2, int var3, int var4, int var5, int var6, int var7, int var8, int var9) {
      if (rectanglesOverlap(var3, var4, var5, var6, 0, 0, gameIntegerValue41, gameIntegerValue42)) {
         int var13 = (var9 & 1) != 0 ? 1 : 0;
         var9 = var1.getClipX();
         int var10 = var1.getClipY();
         int var11 = var1.getClipWidth();
         int var12 = var1.getClipHeight();
         var1.clipRect(var3, var4, var5, var6);
         if (var2 >= 9 && var2 < 89) {
            if (var13 == 0) {
               int var59 = var2 - 9;
               int var66 = var3 - var7;
               var13 = var4 - var8;
               var8 = var66;
               var7 = var59;
               SpriteResourceDecoder var16 = gameSpriteDecoderReference01;
               gameSpriteDecoderReference01.drawSpriteFrameTransformed(var1, var7, var8, var13, 0, 0, 0);
            } else if (this.gameByteValue04 != 1 && this.gameByteValue04 != 2) {
               SpriteResourceDecoder var51 = gameSpriteDecoderReference01;
               int var58 = var2 - 9;
               int var64 = var3 - var7;
               int var10004 = gameSpriteDecoderReference01.getSpriteWidth(var2 - 9) % 2;
               bool var10005 = true;
               var64 += gameSpriteDecoderReference01.getSpriteWidth(var2 - 9);
               var13 = var4 - var8;
               var8 = var64;
               var7 = var58;
               var51.drawSpriteFrameTransformed(var1, var7, var8, var13, 1, 0, 0);
            } else {
               SpriteResourceDecoder var50 = gameSpriteDecoderReference01;
               int var57 = var2 - 9;
               int var63 = var3 - var7 + (gameSpriteDecoderReference01.getSpriteWidth(var2 - 9) % 2 == 1 ? gameSpriteDecoderReference01.getSpriteWidth(var2 - 9) + 1 : gameSpriteDecoderReference01.getSpriteWidth(var2 - 9));
               var13 = var4 - var8;
               var8 = var63;
               var7 = var57;
               var50.drawSpriteFrameTransformed(var1, var7, var8, var13, 1, 0, 0);
            }

            if (gameBooleanFlag58) {
               int var10001 = var3 + (var5 >> 1);
               var3 = var4 + (var6 >> 1);
               var2 = var10001;
               SpriteAnimation var17 = gameClass11Reference04;
               gameClass11Reference04.drawX = var2;
               var17.drawY = var3;
               gameClass11Reference04.drawCurrentFrame();
               gameBooleanFlag58 = false;
            }
         } else if (var2 >= 89 && var2 < 109) {
            if (var13 == 0) {
               int var55 = var2 - 89 + this.gameShortValue06;
               int var61 = var3 - var7;
               var5 = var4 - var8;
               var4 = var61;
               var3 = var55;
               SpriteResourceDecoder var15 = gameSpriteDecoderReference01;
               gameSpriteDecoderReference01.drawSpriteFrameTransformed(var1, var3, var4, var5, 0, 0, 0);
            } else {
               SpriteResourceDecoder var49 = gameSpriteDecoderReference01;
               int var56 = var2 - 89 + this.gameShortValue06;
               int var62 = var3 - var7 + gameSpriteDecoderReference01.getSpriteWidth(var2 - 9 + this.gameShortValue06);
               var5 = var4 - var8;
               var4 = var62;
               var3 = var56;
               var49.drawSpriteFrameTransformed(var1, var3, var4, var5, 1, 0, 0);
            }
         } else if (var2 >= 109 && var2 < 139) {
            if (var13 == 0) {
               int var53 = var2 - 109 + this.gameShortValue06 + this.gameShortValue07;
               int var10003 = var3 - var7;
               var5 = var4 - var8;
               var4 = var10003;
               var3 = var53;
               SpriteResourceDecoder var14 = gameSpriteDecoderReference01;
               gameSpriteDecoderReference01.drawSpriteFrameTransformed(var1, var3, var4, var5, 0, 0, 0);
            } else {
               SpriteResourceDecoder var48 = gameSpriteDecoderReference01;
               int var54 = var2 - 109 + this.gameShortValue06 + this.gameShortValue07;
               int var60 = var3 - var7 + gameSpriteDecoderReference01.getSpriteWidth(var2 - 109 + this.gameShortValue06 + this.gameShortValue07);
               var5 = var4 - var8;
               var4 = var60;
               var3 = var54;
               var48.drawSpriteFrameTransformed(var1, var3, var4, var5, 1, 0, 0);
            }
         } else if (var2 >= 159 && var2 <= 178) {
            int var18 = var2 - 159;
            if (var13 == 0) {
               SpriteResourceDecoder var10000 = gameSpriteDecoderReferenceArray07[1];
               int var10002 = var3 - var7;
               var5 = var4 - var8;
               var4 = var10002;
               var10000.drawSpriteFrameTransformed(var1, var18, var4, var5, 0, 0, 0);
            } else {
               SpriteResourceDecoder var47 = gameSpriteDecoderReferenceArray07[1];
               int var52 = var3 - var7 + gameSpriteDecoderReferenceArray07[1].getSpriteWidth(var18);
               var5 = var4 - var8;
               var4 = var52;
               var47.drawSpriteFrameTransformed(var1, var18, var4, var5, 1, 0, 0);
            }
         }

         setGraphicsClip(var1, var9, var10, var11, var12);
      }
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, java.lang.String, int, int, int) int
   public static int drawTextWithFont(Graphics var0, string var1, int var2, int var3, int var4) {
      sbyte var5 = 0;
      gameSpriteDecoderReferenceArray08[0].configureBitmapFont(var1, null);
      if ((var4 & 32) != 0) {
         var5 = 1;
      }

      if ((var4 & 64) != 0) {
         var5 |= 8;
      }

      if ((var4 & 16) != 0) {
         var5 |= 4;
      }

      gameSpriteDecoderReferenceArray08[0].drawBitmapTextLine(var0, var1, var2, var3, var5, true);
      return var2 + SpriteResourceDecoder.spriteIntegerValue07;
   }

   // $VF: renamed from: a (g, java.lang.String) int
   public static int measureTextWidth(SpriteResourceDecoder var0, string var1) {
      int var2 = 0;

      for (int var3 = 0; var3 < var1.length(); var3++) {
         var2 += var0.getCharacterWidth(var1.charAt(var3));
      }

      return var2;
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, java.lang.String, int, int, int, int, int, int, int, int) int
   public static int drawCenteredText(Graphics var0, string var1, int var2, int var3, int var4, int var5, int var6, int var7, int var8, int var9) {
      var2 = var0.getClipX();
      int var10 = var0.getClipY();
      int var11 = var0.getClipWidth();
      int var12 = var0.getClipHeight();
      setGraphicsClip(var0, var5, var6, var7 - var5, var8 - var6);
      sbyte var16 = 0;
      if ((var9 & 32) != 0) {
         var16 = 1;
      }

      if ((var9 & 64) != 0) {
         var16 |= 8;
      }

      if ((var9 & 16) != 0) {
         var16 |= 4;
      }

      if ((var9 & 1) != 0) {
         var16 |= 2;
      }

      SpriteResourceDecoder var10000 = gameSpriteDecoderReferenceArray08[0];
      var8 = var7 - var5;
      short[] var15 = var10000.loadBitmapFont(var1, var8, false);
      gameSpriteDecoderReferenceArray08[0].drawBitmapText(var0, var1, var15, var3, var4, 0, -1, var16, -1);
      int var13 = var4 + (gameSpriteDecoderReferenceArray08[0].getSpriteImageHeight() + 1) * var15[0];
      setGraphicsClip(var0, var2, var10, var11, var12);
      return var13 - var4;
   }

   // $VF: renamed from: a (java.lang.String) boolean
   public static bool doesResourceExist(string var0) {
      try {
         return readRecordStoreData(var0) != null;
      } catch (System.Exception var1) {
         return false;
      }
   }

   // $VF: renamed from: a (java.lang.String, byte[]) boolean
   public static bool writeResourceFile(string var0, sbyte[] var1) {
      try {
         writeRecordStoreData(var0, var1, 0, var1.Length);
         return true;
      } catch (System.Exception var2) {
         return false;
      }
   }

   // $VF: renamed from: b (java.lang.String, byte[]) boolean
   public static bool readResourceFile(string var0, sbyte[] var1) {
      try {
         sbyte[] var10000 = readRecordStoreData(var0);
         int var2 = var1.Length;
         bool var4 = false;
         bool var5 = false;
         JSystem.arraycopy(var10000, 0, var1, 0, var2);
         return true;
      } catch (System.Exception var3) {
         return false;
      }
   }

   // $VF: renamed from: a (java.lang.String, java.lang.String, int) boolean
   public bool loadResourceData(string var1, string var2, int var3) {
      if (!doesResourceExist(var1)) {
         return false;
      } else {
         return !readResourceFile(var1, this.gameByteArray03) ? false : writeResourceFile(var2, this.gameByteArray03);
      }
   }

   // $VF: renamed from: a (boolean) boolean
   public bool saveGameData(bool var1) {
      string var5;
      if (var1) {
         var5 = AnimationTables.autoSaveFileNames[this.gameByteValue04];
      } else {
         var5 = AnimationTables.levelDataFileNames[this.gameByteValue04];
      }

      int var2 = 0;

      for (int var3 = 2; var3 < 25; var3++) {
         sbyte[] var10000;
         int var10001;
         sbyte var10002;
          {
            if (this.gameActorStateReferenceArray01[var3].byteValue10 <= 0 && this.gameActorStateReferenceArray01[var3].booleanFlag01 && this.gameActorStateReferenceArray01[var3].integerValue02 < 2500) {
               var10000 = this.gameByteArray03;
               var10001 = var2++;
            } else {
               var10000 = this.gameByteArray03;
               var10001 = var2++;
               if (this.gameActorStateReferenceArray01[var3].booleanFlag01) {
                  var10002 = 1;
                  goto label80_brk;
               }
            }

            var10002 = 0;
         } label80_brk:;

         var10000[var10001] = var10002;
         this.gameByteArray03[var2++] = this.gameActorStateReferenceArray01[var3].byteValue08;
         this.gameByteArray03[var2++] = this.gameActorStateReferenceArray01[var3].byteValue01;
         this.gameByteArray03[var2++] = this.gameActorStateReferenceArray01[var3].byteValue02;
         this.gameByteArray03[var2++] = this.gameActorStateReferenceArray01[var3].byteValue07;
         this.gameByteArray03[var2++] = this.gameActorStateReferenceArray01[var3].byteValue05;
         this.gameByteArray03[var2++] = this.gameActorStateReferenceArray01[var3].byteValue06;
         this.gameByteArray03[var2++] = this.gameActorStateReferenceArray01[var3].byteValue10;
      }

      for (int var13 = 0; var13 < this.gameShortValue05; var13++) {
         this.gameByteArray03[var2++] = (sbyte)(this.gameClass9ReferenceArray01[var13].booleanFlag02 ? 1 : 0);

         for (int var4 = 0; var4 < this.gameClass9ReferenceArray01[var13].byteValue04; var4++) {
            this.gameByteArray03[var2++] = (sbyte)(this.gameClass9ReferenceArray01[var13].actorFlagsReferenceArray01[var4].booleanFlag01 ? 1 : 0);
         }
      }

      for (int var14 = 0; var14 < this.gameShortValue08; var14++) {
         this.gameByteArray03[var2++] = (sbyte)(this.gameClass19ReferenceArray01[var14].booleanFlag02 ? 1 : 0);
      }

      return writeResourceFile(var5, this.gameByteArray03);
   }

   // $VF: renamed from: b (boolean) boolean
   public bool loadGameData(bool var1) {
      string var2;
      if (var1) {
         var2 = AnimationTables.autoSaveFileNames[this.gameByteValue04];
      } else {
         var2 = AnimationTables.levelDataFileNames[this.gameByteValue04];
      }

      if (!readResourceFile(var2, this.gameByteArray03)) {
         return this.saveGameData(var1);
      } else {
         int var9 = 0;

         for (int var3 = 2; var3 < 25; var3++) {
            if (this.gameByteArray03[var9] != 0) {
               ActorState var7 = this.createActorState(this.gameByteArray03[var9 + 1], this.gameByteArray03[var9 + 2], this.gameByteArray03[var9 + 3], this.gameByteArray03[var9 + 4]);
               this.faceActorTowardPosition(var7, this.gameByteArray03[var9 + 5]);
               var7.byteValue06 = this.gameByteArray03[var9 + 6];
               int var6 = this.gameByteArray03[var9 + 7] - var7.byteValue11;
               this.applyActorStatus(var7, var6, true);
               if (var7.byteValue08 == 3) {
                  this.gameActorStateReference01 = var7;
               } else if (var7.byteValue08 == 5) {
                  this.gameActorStateReference03 = var7;
               } else if (var7.byteValue08 == 7) {
                  this.gameActorStateReference02 = var7;
               } else if (var7.byteValue08 == 10) {
                  this.gameActorStateReference04 = var7;
               }
            }

            var9 += 8;
         }

         for (int var10 = 0; var10 < this.gameShortValue05; var10++) {
            this.gameClass9ReferenceArray01[var10].booleanFlag02 = this.gameByteArray03[var9++] != 0;

            for (int var8 = 0; var8 < this.gameClass9ReferenceArray01[var10].byteValue04; var8++) {
               this.gameClass9ReferenceArray01[var10].actorFlagsReferenceArray01[var8].booleanFlag01 = this.gameByteArray03[var9++] != 0;
            }
         }

         for (int var11 = 0; var11 < this.gameShortValue08; var11++) {
            this.gameClass19ReferenceArray01[var11].booleanFlag02 = this.gameByteArray03[var9++] != 0;
         }

         return true;
      }
   }

   // $VF: renamed from: b () boolean
   public bool hasSavedGameData() {
      try {
         int var1 = 0;
         var1++;
         this.gameByteArray03[0] = this.gameByteValue04;
         var1++;
         this.gameByteArray03[1] = (sbyte)(this.gameBooleanFlag35 ? 1 : 0);

         for (int var2 = 0; var2 < 4; var2++) {
            this.gameByteArray03[var1++] = (sbyte)(this.gameBooleanArray01[var2] ? 1 : 0);
         }

         this.gameByteArray03[var1++] = (sbyte)(this.gameBooleanFlag40 ? 1 : 0);
         this.gameByteArray03[var1++] = (sbyte)(this.gameBooleanFlag41 ? 1 : 0);
         this.gameByteArray03[var1++] = this.gameByteArray05[0];
         this.gameByteArray03[var1++] = this.gameByteArray05[1];
         this.gameByteArray03[var1++] = this.gameByteArray05[2];
         this.gameByteArray03[var1++] = (sbyte)(this.gameBooleanFlag43 ? 1 : 0);
         this.gameByteArray03[var1++] = (sbyte)(this.gameBooleanFlag44 ? 1 : 0);
         this.gameByteArray03[var1++] = (sbyte)(this.gameBooleanFlag45 ? 1 : 0);
         this.gameByteArray03[var1++] = (sbyte)(this.gameBooleanFlag46 ? 1 : 0);
         this.gameByteArray03[var1++] = (sbyte)(this.gameBooleanFlag47 ? 1 : 0);
         this.gameByteArray03[var1++] = (sbyte)(this.gameBooleanFlag48 ? 1 : 0);
         this.gameByteArray03[var1++] = this.gameByteValue16;
         this.gameByteArray03[var1++] = this.gameByteValue17;
         this.gameByteArray03[var1++] = this.gameByteValue18;
         this.gameByteArray03[var1++] = this.gameByteValue19;
         this.gameByteArray03[var1++] = this.gameByteValue20;
         this.gameByteArray03[var1++] = this.gameByteValue22;
         this.gameByteArray03[var1++] = this.gameByteValue23;
         this.gameByteArray03[var1++] = this.gameByteValue24;
         this.gameByteArray03[var1++] = this.gameByteValue25;
         this.gameByteArray03[var1++] = this.gameByteValue03;
         this.gameByteArray03[var1++] = this.gameActorGroupReference03.actorStateReference01.byteValue08;
         this.gameByteArray03[var1++] = this.gameActorGroupReference03.actorStateReference01.byteValue01;
         this.gameByteArray03[var1++] = this.gameActorGroupReference03.actorStateReference01.byteValue02;
         this.gameByteArray03[var1++] = this.gameActorGroupReference03.actorStateReference01.byteValue07;
         this.gameByteArray03[var1++] = this.gameActorGroupReference03.actorStateReference01.byteValue05;
         this.gameByteArray03[var1++] = this.gameActorGroupReference03.actorStateReference01.byteValue06;
         this.gameByteArray03[var1++] = this.gameActorGroupReference03.actorStateReference01.byteValue10;
         this.gameByteArray03[var1++] = this.gameActorGroupReference03.byteValue02;
         this.gameByteArray03[var1++] = this.gameActorGroupReference03.byteValue03;
         this.gameByteArray03[var1++] = this.gameActorGroupReference03.byteValue04;
         this.gameByteArray03[var1++] = this.gameActorGroupReference03.byteValue05;

         for (int var61 = 0; var61 < this.gameActorGroupReference03.byteValue01; var61++) {
            this.gameByteArray03[var1++] = (sbyte)(this.gameActorGroupReference03.entitySnapshotReferenceArray01[var61].booleanFlag01 ? 1 : 0);
         }

         for (int var62 = 0; var62 < 6; var62++) {
            this.gameByteArray03[var1++] = this.gameActorGroupReference03.byteArray01[var62];
         }

         this.gameByteArray03[var1++] = this.gameActorGroupReference04.actorStateReference01.byteValue08;
         this.gameByteArray03[var1++] = this.gameActorGroupReference04.actorStateReference01.byteValue01;
         this.gameByteArray03[var1++] = this.gameActorGroupReference04.actorStateReference01.byteValue02;
         this.gameByteArray03[var1++] = this.gameActorGroupReference04.actorStateReference01.byteValue07;
         this.gameByteArray03[var1++] = this.gameActorGroupReference04.actorStateReference01.byteValue05;
         this.gameByteArray03[var1++] = this.gameActorGroupReference04.actorStateReference01.byteValue06;
         this.gameByteArray03[var1++] = this.gameActorGroupReference04.actorStateReference01.byteValue10;
         this.gameByteArray03[var1++] = this.gameActorGroupReference04.byteValue02;
         this.gameByteArray03[var1++] = this.gameActorGroupReference04.byteValue03;
         this.gameByteArray03[var1++] = this.gameActorGroupReference04.byteValue04;
         this.gameByteArray03[var1++] = this.gameActorGroupReference04.byteValue05;

         for (int var63 = 0; var63 < this.gameActorGroupReference04.byteValue01; var63++) {
            this.gameByteArray03[var1++] = (sbyte)(this.gameActorGroupReference04.entitySnapshotReferenceArray01[var63].booleanFlag01 ? 1 : 0);
         }

         for (int var64 = 0; var64 < 6; var64++) {
            this.gameByteArray03[var1++] = this.gameActorGroupReference04.byteArray01[var64];
         }

         this.gameByteArray03[var1++] = this.gameByteValue21;
         this.gameByteArray03[var1++] = (sbyte)this.gameShortValue15;
         this.gameByteArray03[var1++] = (sbyte)this.gameShortValue16;
         this.gameByteArray03[var1++] = (sbyte)(this.gameIntegerValue96 / 1000);
         int var117 = ++var1;
         var1++;
         this.gameByteArray03[var117] = (sbyte)(JOps.Ushr(this.gameIntegerValue97, 8));
         this.gameByteArray03[var1++] = (sbyte)this.gameIntegerValue97;
         this.gameByteArray03[var1++] = (sbyte)(JOps.Ushr(this.gameIntegerValue98, 8));
         this.gameByteArray03[var1++] = (sbyte)this.gameIntegerValue98;
         this.gameByteArray03[var1++] = (sbyte)(JOps.Ushr(this.gameIntegerValue99, 8));
         this.gameByteArray03[var1++] = (sbyte)this.gameIntegerValue99;
         this.gameByteArray03[var1++] = (sbyte)(JOps.Ushr(this.gameIntegerValue100, 8));
         this.gameByteArray03[var1] = (sbyte)this.gameIntegerValue100;
         if (!writeResourceFile("residentevil.dat", this.gameByteArray03)) {
            return false;
         }

         for (int var65 = 0; var65 < 4; var65++) {
            if (var65 != this.gameByteValue04) {
               this.loadResourceData(AnimationTables.autoSaveFileNames[var65], AnimationTables.levelDataFileNames[var65], 2048);
            }
         }
      } catch (System.Exception var3) {
         JSystem.@out.println("Error trying to save data");
         JSystem.@out.println(var3.getMessage());
      }

      return this.saveGameData(false);
   }

   // $VF: renamed from: d () boolean
   public bool readSavedGameData() {
      if (!readResourceFile("residentevil.dat", this.gameByteArray03)) {
         this.initializeActorGroup();
         return false;
      } else {
         gameIntegerValue50 = 384;
         int var1 = 0;
         var1++;
         this.gameByteValue04 = this.gameByteArray03[0];
         var1++;
         this.gameBooleanFlag35 = this.gameByteArray03[1] != 0;

         for (int var2 = 0; var2 < 4; var2++) {
            this.gameBooleanArray01[var2] = this.gameByteArray03[var1++] != 0;
         }

         if (this.gameByteArray03[var1++] == 1) {
            this.gameBooleanFlag40 = true;
         } else {
            this.gameBooleanFlag40 = false;
         }

         if (this.gameByteArray03[var1++] == 1) {
            this.gameBooleanFlag41 = true;
         } else {
            this.gameBooleanFlag41 = false;
         }

         this.gameByteArray05[0] = this.gameByteArray03[var1++];
         this.gameByteArray05[1] = this.gameByteArray03[var1++];
         this.gameByteArray05[2] = this.gameByteArray03[var1++];
         if (this.gameByteArray03[var1++] == 1) {
            this.gameBooleanFlag43 = true;
         } else {
            this.gameBooleanFlag43 = false;
         }

         if (this.gameByteArray03[var1++] == 1) {
            this.gameBooleanFlag44 = true;
         } else {
            this.gameBooleanFlag44 = false;
         }

         if (this.gameByteArray03[var1++] == 1) {
            this.gameBooleanFlag45 = true;
         } else {
            this.gameBooleanFlag45 = false;
         }

         if (this.gameByteArray03[var1++] == 1) {
            this.gameBooleanFlag46 = true;
         } else {
            this.gameBooleanFlag46 = false;
         }

         if (this.gameByteArray03[var1++] == 1) {
            this.gameBooleanFlag47 = true;
         } else {
            this.gameBooleanFlag47 = false;
         }

         if (this.gameByteArray03[var1++] == 1) {
            this.gameBooleanFlag48 = true;
         } else {
            this.gameBooleanFlag48 = false;
         }

         this.gameByteValue16 = this.gameByteArray03[var1++];
         this.gameByteValue17 = this.gameByteArray03[var1++];
         this.gameByteValue18 = this.gameByteArray03[var1++];
         this.gameByteValue19 = this.gameByteArray03[var1++];
         this.gameByteValue20 = this.gameByteArray03[var1++];
         this.gameByteValue22 = this.gameByteArray03[var1++];
         this.gameByteValue23 = this.gameByteArray03[var1++];
         this.gameByteValue24 = this.gameByteArray03[var1++];
         this.gameByteValue25 = this.gameByteArray03[var1++];
         this.changeActorAction(2, 384);
         this.updateCanvasState();
         this.gameByteValue03 = this.gameByteArray03[var1++];
         this.createActorState(this.gameByteArray03[var1], this.gameByteArray03[var1 + 1], this.gameByteArray03[var1 + 2], this.gameByteArray03[var1 + 3]);
         this.faceActorTowardPosition(this.gameActorGroupReference03.actorStateReference01, this.gameByteArray03[var1 + 4]);
         this.gameActorGroupReference03.actorStateReference01.byteValue06 = this.gameByteArray03[var1 + 5];
         this.applyActorStatus(this.gameActorGroupReference03.actorStateReference01, this.gameByteArray03[var1 + 6] - this.gameActorGroupReference03.actorStateReference01.byteValue11, false);
         int var26 = var1 + 7;
         this.gameActorGroupReference03.byteValue02 = this.gameByteArray03[var26++];
         this.gameActorGroupReference03.byteValue03 = this.gameByteArray03[var26++];
         this.gameActorGroupReference03.byteValue04 = this.gameByteArray03[var26++];
         this.gameActorGroupReference03.byteValue05 = this.gameByteArray03[var26++];

         for (int var48 = 0; var48 < this.gameActorGroupReference03.byteValue01; var48++) {
            this.gameActorGroupReference03.entitySnapshotReferenceArray01[var48].booleanFlag01 = this.gameByteArray03[var26++] != 0;
         }

         for (int var49 = 0; var49 < 6; var49++) {
            this.gameActorGroupReference03.byteArray01[var49] = this.gameByteArray03[var26++];
         }

         this.createActorState(this.gameByteArray03[var26], this.gameByteArray03[var26 + 1], this.gameByteArray03[var26 + 2], this.gameByteArray03[var26 + 3]);
         this.faceActorTowardPosition(this.gameActorGroupReference04.actorStateReference01, this.gameByteArray03[var26 + 4]);
         this.faceActorTowardPosition(this.gameActorGroupReference04.actorStateReference01, 0);
         this.gameActorGroupReference04.actorStateReference01.byteValue06 = this.gameByteArray03[var26 + 5];
         this.applyActorStatus(this.gameActorGroupReference04.actorStateReference01, this.gameByteArray03[var26 + 6] - this.gameActorGroupReference04.actorStateReference01.byteValue11, false);
         int var31 = var26 + 7;
         this.gameActorGroupReference04.byteValue02 = this.gameByteArray03[var31++];
         this.gameActorGroupReference04.byteValue03 = this.gameByteArray03[var31++];
         this.gameActorGroupReference04.byteValue04 = this.gameByteArray03[var31++];
         this.gameActorGroupReference04.byteValue05 = this.gameByteArray03[var31++];

         for (int var50 = 0; var50 < this.gameActorGroupReference04.byteValue01; var50++) {
            this.gameActorGroupReference04.entitySnapshotReferenceArray01[var50].booleanFlag01 = this.gameByteArray03[var31++] != 0;
         }

         for (int var51 = 0; var51 < 6; var51++) {
            this.gameActorGroupReference04.byteArray01[var51] = this.gameByteArray03[var31++];
         }

         this.gameByteValue21 = this.gameByteArray03[var31++];
         this.gameShortValue15 = (short)this.gameByteArray03[var31++];
         this.gameShortValue16 = (short)this.gameByteArray03[var31++];
         this.gameIntegerValue96 = (this.gameByteArray03[var31++] & 255) * 1000;
         int var87 = ++var31;
         var31++;
         this.gameIntegerValue97 = this.gameByteArray03[var87];
         this.gameIntegerValue97 = this.gameIntegerValue97 << 8 | this.gameByteArray03[var31++];
         this.gameIntegerValue98 = this.gameByteArray03[var31++];
         this.gameIntegerValue98 = this.gameIntegerValue98 << 8 | this.gameByteArray03[var31++];
         this.gameIntegerValue99 = this.gameByteArray03[var31++];
         this.gameIntegerValue99 = this.gameIntegerValue99 << 8 | this.gameByteArray03[var31++];
         this.gameIntegerValue100 = this.gameByteArray03[var31++];
         this.gameIntegerValue100 = this.gameIntegerValue100 << 8 | this.gameByteArray03[var31];
         if (this.gameByteValue03 == 1) {
            this.gameActorGroupReference01 = this.gameActorGroupReference03;
            this.gameActorGroupReference02 = this.gameActorGroupReference04;
         } else {
            this.gameActorGroupReference01 = this.gameActorGroupReference04;
            this.gameActorGroupReference02 = this.gameActorGroupReference03;
         }

         if (this.gameActorGroupReference01.byteValue05 != this.gameActorGroupReference02.byteValue05) {
            this.gameActorGroupReference02.actorStateReference01.booleanFlag01 = false;
         }

         for (int var52 = 0; var52 < 4; var52++) {
            this.loadResourceData(AnimationTables.levelDataFileNames[var52], AnimationTables.autoSaveFileNames[var52], 2048);
         }

         if (!this.loadGameData(false)) {
            this.initializeActorGroup();
            return false;
         } else {
            this.clearActorStatusEffects();
            this.updateAllActors(false);
            this.updateActorDisplayState(this.gameActorGroupReference01.actorStateReference01, true);
            return true;
         }
      }
   }

   // $VF: renamed from: e () boolean
   public bool writeSavedGameData() {
      this.gameByteArray03[1] = (sbyte)(gameBooleanFlag04 ? 1 : 0);
      this.gameByteArray03[3] = (sbyte)(this.gameBooleanFlag33 ? 1 : 0);
      this.gameByteArray03[0] = (sbyte)(gameBooleanFlag07 ? 1 : 0);
      this.gameByteArray03[2] = (sbyte)(gameBooleanFlag06 ? 1 : 0);
      return writeResourceFile("options.dat", this.gameByteArray03);
   }

   // $VF: renamed from: a (int) java.lang.String
   public static string getLocalizedText(int var0) {
      return getStringResource(var0);
   }

   // $VF: renamed from: a (p) byte
   public sbyte getActorStateValue(ActorState var1) {
      return this.gameByteMatrix02[var1.byteValue01][var1.byteValue02];
   }

   // $VF: renamed from: a (boolean) void
   public void initializeActorStates(bool var1) {
      int var2;
      int var3;
      int var4;
      int var5;
      int var6;
      short var7;
      if (this.gameByteValue16 == 0) {
         var2 = 66;
         var3 = 16;
         var4 = 44;
         var5 = 3;
         var6 = 1;
         var7 = 3;
      } else {
         var2 = 44;
         var3 = 3;
         var4 = 66;
         var5 = 16;
         var6 = 0;
         var7 = 545;
      }

      int var1i;
      if (!var1) {
         if (this.gameByteValue16 == 0) {
            if (this.gameActorGroupReference02.actorStateReference01.byteValue01 >= 66
               && this.gameActorGroupReference02.actorStateReference01.byteValue01 <= 68
               && this.gameActorGroupReference02.actorStateReference01.byteValue02 >= 15
               && this.gameActorGroupReference02.actorStateReference01.byteValue02 <= 17) {
               var1i = this.gameActorGroupReference02.actorStateReference01.byteValue01 - var2;
               var2 = this.gameActorGroupReference02.actorStateReference01.byteValue02 - var3;
               this.gameActorGroupReference02.actorStateReference01.byteValue01 = (sbyte)(var4 + var1i);
               this.gameActorGroupReference02.actorStateReference01.byteValue02 = (sbyte)(var5 + var2);
               this.gameActorGroupReference02.actorStateReference01.booleanFlag01 = true;
               this.gameActorGroupReference02.byteValue05 = (sbyte)var6;
            }
         } else if (this.gameActorGroupReference02.actorStateReference01.byteValue01 >= 44
            && this.gameActorGroupReference02.actorStateReference01.byteValue01 <= 46
            && this.gameActorGroupReference02.actorStateReference01.byteValue02 >= 2
            && this.gameActorGroupReference02.actorStateReference01.byteValue02 <= 4) {
            var1i = this.gameActorGroupReference02.actorStateReference01.byteValue01 - var2;
            var2 = this.gameActorGroupReference02.actorStateReference01.byteValue02 - var3;
            this.gameActorGroupReference02.actorStateReference01.byteValue01 = (sbyte)(var4 + var1i);
            this.gameActorGroupReference02.actorStateReference01.byteValue02 = (sbyte)(var5 + var2);
            this.gameActorGroupReference02.actorStateReference01.booleanFlag01 = true;
            this.gameActorGroupReference02.byteValue05 = (sbyte)var6;
         }

         this.gameByteValue16 = (sbyte)var6;
      } else {
         if (this.gameActorStateReference01 != null) {
            this.gameActorStateReference01.booleanFlag01 = false;
         }

         if (this.gameActorStateReference03 != null) {
            this.gameActorStateReference03.booleanFlag01 = false;
         }

         if (this.gameActorStateReference02 != null) {
            this.gameActorStateReference02.booleanFlag01 = false;
         }

         if (this.gameActorGroupReference01.byteValue05 == this.gameActorGroupReference02.byteValue05
            && this.gameByteMatrix02[this.gameActorGroupReference01.actorStateReference01.byteValue01][this.gameActorGroupReference01.actorStateReference01.byteValue02]
               == this.gameByteMatrix02[this.gameActorGroupReference02.actorStateReference01.byteValue01][this.gameActorGroupReference02.actorStateReference01.byteValue02]) {
            var1i = this.gameActorGroupReference02.actorStateReference01.byteValue01 - var2;
            var2 = this.gameActorGroupReference02.actorStateReference01.byteValue02 - var3;
            this.gameActorGroupReference02.actorStateReference01.byteValue01 = (sbyte)(var4 + var1i);
            this.gameActorGroupReference02.actorStateReference01.byteValue02 = (sbyte)(var5 + var2);
            this.gameActorGroupReference02.byteValue05 = (sbyte)var6;
         }

         this.activateActorRuntimeState(var7);
         this.gameActorGroupReference01.actorStateReference01.byteValue01 = (sbyte)var4;
         this.gameActorGroupReference01.actorStateReference01.byteValue02 = (sbyte)var5;
         this.setCameraPosition(this.getTilePixelX(var4, var5) - gameIntegerValue43 / 2, (var5 + var4) * 27 - gameIntegerValue44 / 2);
         setActorFacingDirection(this.gameActorGroupReference01.actorStateReference01, 5);
         this.processLevelEntity(var6, true);
         this.gameByteValue16 = (sbyte)var6;
      }
   }

   // $VF: renamed from: d (p, int) void
   public void updateActorState(ActorState var1, int var2) {
      sbyte var3;
      sbyte var4;
      bool var5;
      short[][] var6;
      if (var2 == 1) {
         var3 = (sbyte)(var1.byteValue01 + 1);
         var4 = var1.byteValue02;
         var5 = false;
         var6 = this.gameShortMatrix01;
      } else if (var2 == 7) {
         var3 = var1.byteValue01;
         var4 = (sbyte)(var1.byteValue02 + 1);
         var5 = true;
         var6 = this.gameShortMatrix02;
      } else if (var2 == 5) {
         var3 = (sbyte)(var1.byteValue01 - 1);
         var4 = var1.byteValue02;
         var5 = false;
         var6 = this.gameShortMatrix01;
      } else {
         if (var2 != 3) {
            return;
         }

         var3 = var1.byteValue01;
         var4 = (sbyte)(var1.byteValue02 - 1);
         var5 = true;
         var6 = this.gameShortMatrix02;
      }

      if (this.gameByteMatrix02[var1.byteValue01][var1.byteValue02] != this.gameByteMatrix02[var3][var4]) {
         if (var1.byteValue08 == 11) {
            return;
         }

         if (!this.gameBooleanFlag36 && var6[var1.byteValue01 > var3 ? var1.byteValue01 : var3][var1.byteValue02 > var4 ? var1.byteValue02 : var4] != -1) {
            return;
         }

         if ((var2 = this.countActiveEntities(var3, var4, var2)) != -1) {
            if (this.gameByteValue04 == 3 && (var2 == 20 || var2 == 21 || var2 == 22)) {
               if (var1 == this.gameActorGroupReference03.actorStateReference01) {
                  this.configureActorStatusEffect(true, 780, 0);
                  var1.byteValue03 = 0;
                  var1.byteValue05 = 8;
                  return;
               }

               if (var1 == this.gameActorStateReference03) {
                  this.configureActorStatusEffect(true, 730, 0);
                  var1.byteValue01 = var3;
                  var1.byteValue02 = var4;
                  return;
               }
            }

            ActorRuntimeState var7;
            if ((var7 = this.gameClass9ReferenceArray01[var2]).booleanFlag01) {
               if (var7.booleanFlag04 == var5 && var7.booleanFlag02) {
                  return;
               }
            } else if (var7.booleanFlag02) {
               return;
            }
         }
      }

      var1.byteValue01 = var3;
      var1.byteValue02 = var4;
   }

   // $VF: renamed from: a (boolean, int, int) boolean
   public bool intersectsBounds(bool var1, int var2, int var3) {
      if (var2 <= 0 || var3 <= 0) {
         return false;
      } else if (var1) {
         return this.gameShortMatrix01[var2][var3] == -1 ? false : this.gameByteMatrix02[var2][var3] == this.gameByteMatrix02[var2 - 1][var3];
      } else {
         return this.gameShortMatrix02[var2][var3] == -1 ? false : this.gameByteMatrix02[var2][var3] == this.gameByteMatrix02[var2][var3 - 1];
      }
   }

   // $VF: renamed from: b (int, int, int) void
   public void setActorAttribute(int var1, int var2, int var3) {
      this.gameClass9ReferenceArray01[var1].byteValue02 = (sbyte)var2;
      this.gameClass9ReferenceArray01[var1].byteValue03 = (sbyte)var3;
      this.gameClass9ReferenceArray01[var1].shortValue01 = (short)this.getTilePixelX(this.gameClass9ReferenceArray01[var1].byteValue02, this.gameClass9ReferenceArray01[var1].byteValue03);
      ActorRuntimeState var10000 = this.gameClass9ReferenceArray01[var1];
      sbyte var5 = this.gameClass9ReferenceArray01[var1].byteValue03;
      sbyte var4 = this.gameClass9ReferenceArray01[var1].byteValue02;
      var10000.shortValue02 = (short)((var5 + var4) * 27);
   }

   // $VF: renamed from: e () void
   public void updateActorBehavior() {
      if ((~this.gameByteValue23 & 7) == 0) {
         this.activateActorRuntimeState(174);
         this.deactivateActorRuntimeState(21);
         this.activateActorRuntimeState(291);
         this.deactivateActorRuntimeState(7);
         sbyte var2 = 107;
         this.showGameMessage(0, 2, getStringResource(107), 0);
      } else {
         sbyte var1 = 98;
         this.showGameMessage(0, 2, getStringResource(98), 0);
      }
   }

   // $VF: renamed from: D () void
   public void updateActorPositions() {
      sbyte var3 = this.gameByteMatrix02[35][27];

      for (int var1 = 0; var1 < this.gameByteValue12; var1++) {
         for (int var2 = 0; var2 < this.gameByteValue13; var2++) {
            if (this.gameByteMatrix02[var1][var2] == var3) {
               if (this.gameByteMatrix01[var1][var2] != 5 && this.gameByteMatrix01[var1][var2] != 6 && this.gameByteMatrix01[var1][var2] != 16) {
                  this.gameByteMatrix01[var1][var2] = 10;
               }

               if (this.intersectsBounds(true, var1, var2)) {
                  this.gameShortMatrix01[var1][var2] = 2827;
               }

               if (this.intersectsBounds(false, var1, var2)) {
                  this.gameShortMatrix02[var1][var2] = 2827;
               }
            }
         }
      }
   }

   // $VF: renamed from: f () void
   public void loadActorResources() {
      sbyte[] var4 = null;
      if (this.gameByteValue04 == 0) {
         var4 = loadGameDataFile("/8", 0);
      }

      if (this.gameByteValue04 == 1) {
         var4 = loadGameDataFile("/9", 0);
      }

      if (this.gameByteValue04 == 2) {
         var4 = loadGameDataFile("/10", 0);
      }

      if (this.gameByteValue04 == 3) {
         var4 = loadGameDataFile("/11", 0);
      }

      if (var4 != null) {
         sbyte var3 = 0;
         int var11 = var3 + 2;

         for (int var1 = 0; var1 < this.gameByteValue12; var1++) {
            for (int var2 = 0; var2 < this.gameByteValue13; var2++) {
               this.gameByteMatrix01[var1][var2] = var4[var11++];
            }
         }

         for (int var5 = 0; var5 < this.gameByteValue12; var5++) {
            for (int var8 = 0; var8 < this.gameByteValue13; var8++) {
               this.gameShortMatrix02[var5][var8] = (short)((var4[var11++] & 255) << 8);
               this.gameShortMatrix02[var5][var8] = (short)(this.gameShortMatrix02[var5][var8] | (short)(var4[var11++] & 255));
            }
         }

         for (int var6 = 0; var6 < this.gameByteValue12; var6++) {
            for (int var9 = 0; var9 < this.gameByteValue13; var9++) {
               this.gameShortMatrix01[var6][var9] = (short)((var4[var11++] & 255) << 8);
               this.gameShortMatrix01[var6][var9] = (short)(this.gameShortMatrix01[var6][var9] | (short)(var4[var11++] & 255));
            }
         }

         for (int var7 = 0; var7 < this.gameByteValue12; var7++) {
            for (int var10 = 0; var10 < this.gameByteValue13; var10++) {
               this.gameByteMatrix02[var7][var10] = var4[var11++];
            }
         }
      }
   }

   // $VF: renamed from: E () void
   public void initializeActorGroup() {
      this.gameBooleanFlag54 = true;
      this.gameByteValue04 = 0;
      this.gameBooleanFlag35 = false;

      for (int var1 = 0; var1 < 4; var1++) {
         this.gameBooleanArray01[var1] = false;
      }

      this.changeActorAction(2, 384);
      this.resetGameplayState();
      this.updateCanvasState();
      this.gameActorGroupReference03.byteValue03 = 0;
      this.setActorGroupPosition((sbyte)0, (sbyte)1);
      this.setActorGroupPosition((sbyte)gameIntegerArray02[0], (sbyte)1);
      this.gameActorGroupReference03.byteValue02 = 0;
      this.gameActorGroupReference03.byteValue04 = 0;
      this.gameActorGroupReference03.byteArray01[0] = 0;
      this.gameActorGroupReference03.byteArray01[1] = 20;
      this.gameActorGroupReference03.byteArray01[2] = 6;
      this.gameActorGroupReference03.byteArray01[3] = 10;
      this.gameActorGroupReference03.byteArray01[4] = 4;
      this.gameActorGroupReference03.byteArray01[5] = 0;
      this.gameActorGroupReference01 = this.gameActorGroupReference03;
      this.gameActorGroupReference02 = this.gameActorGroupReference04;
      this.gameByteValue03 = 1;
      this.gameActorGroupReference01.byteValue05 = 0;
      this.gameActorGroupReference02.byteValue05 = 0;
      this.gameActorGroupReference04.byteValue03 = 0;
      this.setActorGroupPosition((sbyte)0, (sbyte)2);
      this.setActorGroupPosition((sbyte)gameIntegerArray02[0], (sbyte)2);
      this.setActorGroupPosition((sbyte)gameIntegerArray02[1], (sbyte)2);
      this.gameActorGroupReference04.byteValue02 = 0;
      this.gameActorGroupReference04.byteValue04 = 1;
      this.gameActorGroupReference04.byteArray01[0] = 0;
      this.gameActorGroupReference04.byteArray01[1] = 20;
      this.gameActorGroupReference04.byteArray01[2] = 6;
      this.gameActorGroupReference04.byteArray01[3] = 10;
      this.gameActorGroupReference04.byteArray01[4] = 4;
      this.gameActorGroupReference04.byteArray01[5] = 0;
      this.gameShortValue15 = 0;
      this.gameShortValue16 = 0;
      this.gameIntegerValue96 = 0;
      this.gameIntegerValue97 = 0;
      this.gameIntegerValue98 = 0;
      this.gameIntegerValue99 = 0;
      this.gameIntegerValue100 = 0;
      this.gameIntegerValue101 = 0;
      this.gameIntegerValue102 = 0;
      gameBooleanFlag53 = true;
      this.gameActorGroupReference04.actorStateReference01.byteValue01 = 10;
      this.gameActorGroupReference04.actorStateReference01.byteValue02 = 10;
      gameBooleanFlag23 = false;
      gameBooleanFlag59 = false;
   }

   // $VF: renamed from: f () boolean
   public bool beginGameplayState() {
      this.gameBooleanFlag30 = false;
      gameBooleanFlag29 = false;
      this.gameLongValue06 = JSystem.currentTimeMillis();
      this.setFullScreenMode(true);
      gameIntegerValue41 = 360;
      gameIntegerValue42 = 640;
      gameIntegerValue43 = gameIntegerValue41 / 2;
      gameIntegerValue44 = gameIntegerValue42 / 2;
      this.gameByteValue06 = 0;
      this.gameByteValue04 = 0;
      initializeInputState();
      this.gameIntegerValue46 = 20;
      this.gameBooleanFlag31 = false;
      this.gameBooleanFlag32 = false;
      this.gameBooleanFlag33 = true;
      gameBooleanFlag29 = false;
      this.gameShortValue10 = 0;
      this.gameShortValue11 = 0;
      this.gameShortValue12 = (short)gameIntegerValue41;
      this.gameShortValue13 = (short)gameIntegerValue42;
      this.gameByteValue01 = 0;
      this.gameByteValue02 = AnimationTables.byteArray03[0];
      this.gameIntegerValue51 = 0;
      this.gameGraphicsReference01 = gameGraphicsReference02;

      for (int var1 = 0; var1 < 5; var1++) {
         this.gameEntityFrameDataReferenceArray01[var1] = new EntityFrameData(this);
      }

      for (int var6 = 0; var6 < 10; var6++) {
         this.gameClass22ReferenceArray01[var6] = new TimedEntityEffect(this);
      }

      this.gameByteArray03 = new sbyte[2048];

      try {
         gameByteStreamReferenceArray01 = new ByteArrayInputStream[52];
         gameTextArray01 = new string[52];
         gamePlayerReferenceArray01 = new Player[52];

         try {
            openAssetStream("/2");

            for (int var7 = 0; var7 < 52; var7++) {
               sbyte[] var2 = loadAssetBytes(var7);
               gameByteStreamReferenceArray01[var7] = new ByteArrayInputStream(var2);
               gameTextArray01[var7] = var2.Length == 0
                  ? "dummy"
                  : (
                     var2[0] == 82 && var2[1] == 73 && var2[2] == 70 && var2[3] == 70
                        ? "audio/x-wav"
                        : (
                           var2[0] == 35 && var2[1] == 33 && var2[2] == 65 && var2[3] == 77 && var2[4] == 82
                              ? "audio/amr"
                              : (
                                 var2[0] == 99 && var2[1] == 109 && var2[2] == 105 && var2[3] == 100
                                    ? "audio/pmd"
                                    : (
                                       var2[0] == 73 && var2[1] == 68 && var2[2] == 51
                                          ? "audio/aac"
                                          : (
                                             var2[0] == 46 && var2[1] == 115 && var2[2] == 110 && var2[3] == 100
                                                ? "audio/basic"
                                                : (var2[0] == 77 && var2[1] == 84 && var2[2] == 104 && var2[3] == 100 ? "audio/midi" : "audio/mp3")
                                          )
                                    )
                              )
                        )
                  );
               JSystem.@out.println("s_soundType[i] = " + gameTextArray01[var7]);
               if ((var7 == 27 || var7 == 7 || var7 == 31 || var7 == 33 || var7 == 14 || var7 == 41 || var7 == 40 || var7 == 22) && gameTextArray01[var7] != "dummy") {
                  JSystem.@out.println("!!!!!!!!!!!!!!!!!!!  s_soundType[i] = " + gameTextArray01[var7]);
                  gamePlayerReferenceArray01[var7] = Manager.createPlayer(gameByteStreamReferenceArray01[var7], gameTextArray01[var7]);
                  gamePlayerReferenceArray01[var7].realize();
                  gamePlayerReferenceArray01[var7].prefetch();
               }
            }

            closeAssetStream();
         } catch (System.Exception var3) {
            JSystem.@out.println(var3);
         }
      } catch (System.Exception var4) {
      }

      closeAssetStream();
      openAssetStream("/1");
      short[] var8 = (short[])readAssetObject(2);
      gameSpriteDecoderReferenceArray08[1] = createSpriteResource(1, true, true);
      gameSpriteDecoderReferenceArray08[1].setSpritePaletteData(var8);
      gameSpriteDecoderReferenceArray08[1].setGraphicsTransform(0);
      closeAssetStream();
      openAssetStream("/4");
      gameSpriteDecoderReferenceArray09[0] = createSpriteResource(0, true, true);
      gameSpriteDecoderReferenceArray09[1] = createSpriteResource(1, true, true);
      closeAssetStream();
      gameClass11Reference03 = new SpriteAnimation(gameSpriteDecoderReferenceArray09[1], 0, 0);
      openAssetStream("/7");
      gameSpriteDecoderReference02 = createSpriteResource(4, true, true);
      SpriteAnimation.initializeAnimationFrames(gameIntegerValue41, gameIntegerValue42, 54, 27);
      createSpriteResource(5, true, true);
      (gameClass11Reference01 = new SpriteAnimation(gameSpriteDecoderReferenceArray09[1], 0, 0)).playAnimation(1, -1);
      closeAssetStream();
      this.gameActorGroupReference01 = this.gameActorGroupReference03;
      this.gameActorGroupReference02 = this.gameActorGroupReference04;
      this.gameBooleanFlag33 = true;
      bool var10000;
      if (!readResourceFile("options.dat", this.gameByteArray03)) {
         var10000 = this.writeSavedGameData();
      } else {
         gameBooleanFlag04 = this.gameByteArray03[1] == 1;
         gameBooleanFlag07 = this.gameByteArray03[0] == 1;
         gameBooleanFlag06 = this.gameByteArray03[2] == 1;
         this.gameBooleanFlag33 = this.gameByteArray03[3] != 0;
         var10000 = true;
      }

      if (!var10000) {
         return true;
      } else if (!this.writeSavedGameData()) {
         return true;
      } else {
         this.resetGameplayState();
         this.changeActorAction(3, 129);
         openAssetStream("/5");
         short var10 = 1;
         sbyte[] var5;
         gameImageReference01 = Image.createImage(var5 = loadAssetBytes(1), 0, var5.Length);
         closeAssetStream();
         SpriteResourceDecoder var12 = gameSpriteDecoderReferenceArray08[0];
         var10 = 265;
         string var9 = getStringResource(265);
         var12.configureBitmapFont(var9, null);
         gameIntegerValue39 = 180 + SpriteResourceDecoder.spriteIntegerValue07 / 2 + 5;
         GameUiController.configureUiDisplay(GloftRESE.GloftRESEReference01, gameGameCanvasReference01, screenWidth, screenHeight);
         gameBooleanFlag24 = GameUiController.isUiScreenActive();
         gameBooleanFlag25 = GameUiController.isMainMenuVisible();
         return true;
      }
   }

   // $VF: renamed from: F () void
   public void resetGameplayState() {
      this.gameByteValue14 = 0;
      this.gameBooleanFlag37 = false;
      this.gameBooleanFlag36 = false;
      this.gameByteValue25 = 0;
      this.gameByteArray05[0] = -1;
      this.gameByteArray05[1] = -1;
      this.gameByteArray05[2] = -1;
      this.gameBooleanFlag43 = false;
      this.gameBooleanFlag44 = false;
      this.gameByteValue22 = 0;
      this.gameByteValue23 = 0;
      this.gameByteValue24 = 0;
      this.gameBooleanFlag45 = false;
      this.gameBooleanFlag46 = false;
      this.gameBooleanFlag47 = false;
      this.gameBooleanFlag48 = true;
      this.gameByteValue16 = -1;
      this.gameByteValue17 = 0;
      this.gameByteValue18 = 0;
      this.gameByteValue19 = 0;
      this.gameByteValue20 = 0;
      this.gameByteValue21 = 0;
      this.gameIntegerValue93 = -1;
      this.gameIntegerValue94 = 0;
      this.gameIntegerValue95 = 0;
      this.gameByteValue26 = 0;
      this.gameByteValue28 = 4;
      this.gameByteValue27 = this.gameByteValue28;
   }

   // $VF: renamed from: a (int, int, int, int) p
   public ActorState createActorState(int var1, int var2, int var3, int var4) {
      int var5 = 5;

      while (var5 < 25 && this.gameActorStateReferenceArray01[var5].booleanFlag01 && this.gameActorStateReferenceArray01[var5].byteValue10 > 0) {
         var5++;
      }

      if (var5 >= 25) {
         return null;
      } else {
         ActorState var9;
         switch (var1) {
            case 0:
               var9 = this.gameActorStateReferenceArray01[0];
               break;
            case 1:
               var9 = this.gameActorStateReferenceArray01[1];
               break;
            case 2:
            case 4:
            case 6:
            case 7:
            case 8:
            case 9:
            default:
               var9 = this.gameActorStateReferenceArray01[var5];
               break;
            case 3:
               var9 = this.gameActorStateReferenceArray01[2];
               this.gameActorStateReference01 = var9;
               break;
            case 5:
               var9 = this.gameActorStateReferenceArray01[3];
               this.gameActorStateReference03 = var9;
               break;
            case 10:
               var9 = this.gameActorStateReferenceArray01[4];
               this.gameActorStateReference04 = var9; break;
         }

         var9.booleanFlag01 = true;
         var9.byteValue08 = (sbyte)var1;
         var9.byteValue01 = (sbyte)var2;
         var9.byteValue02 = (sbyte)var3;
         var9.byteValue03 = 0;
         var9.byteValue04 = 0;
         var9.byteValue05 = 0;
         var9.byteValue06 = -1;
         var9.integerValue01 = 0;
         var9.byteValue12 = -1;
         var9.byteValue13 = -1;
         var9.booleanFlag02 = false;
         var9.booleanFlag03 = false;
         var9.booleanFlag04 = false;
         var9.longValue01 = 0L;
         var9.longValue02 = 0L;
         var9.byteValue09 = 127;
         var9.booleanFlag05 = false;
         sbyte var6;
         sbyte var7;
         sbyte var8;
         switch (var9.byteValue08) {
            case 0:
            case 1:
               var6 = 16;
               var7 = 16;
               var8 = 0;
               break;
            case 2:
            case 4:
               var6 = 10;
               var7 = 10;
               var8 = 0;
               break;
            case 3:
            case 7:
               var6 = 127;
               var7 = 127;
               var8 = 0;
               break;
            case 5:
               var6 = 125;
               var7 = 125;
               var8 = 0;
               break;
            case 6:
               var6 = 60;
               var7 = 60;
               var8 = 0;
               break;
            case 8:
               var6 = 30;
               var7 = 30;
               var8 = 0;
               break;
            case 9:
               var6 = 125;
               var7 = 125;
               var9.byteValue09 = 10;
               var8 = 0;
               break;
            case 10:
               var6 = 127;
               var7 = 127;
               var8 = 0;
               break;
            case 11:
               var6 = 6;
               var7 = 6;
               var8 = 1;
               break;
            default:
               var6 = 10;
               var7 = 10;
               var8 = 0; break;
         }

         var9.byteValue10 = var6;
         var9.byteValue11 = var7;
         var9.integerValue02 = 2500;
         this.faceActorTowardPosition(var9, var8);
         setActorFacingDirection(var9, var4);
         return var9;
      }
   }

   // $VF: renamed from: o (int) void
   public void setActorAnimation(int var1) {
      this.updateActorGroup(var1, this.gameByteValue03);
   }

   // $VF: renamed from: a (int, int) void
   public void updateActorGroup(int var1, int var2) {
      ActorGroup var3 = var2 == 1 ? this.gameActorGroupReference03 : this.gameActorGroupReference04;
      if (var1 == 127) {
         var3.actorStateReference01.byteValue09 = 127;
      } else {
         var3.byteValue04 = (sbyte)((var1 + 6) % 6);
         if (this.gameActorGroupReference01.actorStateReference01.byteValue08 == 0) {
            this.gameActorGroupReference01.actorStateReference01.byteValue09 = (sbyte)(0 + this.gameActorGroupReference01.byteValue04);
         } else if (this.gameActorGroupReference01.actorStateReference01.byteValue08 == 1) {
            this.gameActorGroupReference01.actorStateReference01.byteValue09 = (sbyte)(5 + this.gameActorGroupReference01.byteValue04);
         }

         if (var1 == 5) {
            var3.actorStateReference01.byteValue09 = 127;
         }

         if (this.isPlayerActorActive()) {
            this.faceActorTowardPosition(var3.actorStateReference01, 8);
         }
      }
   }

   // $VF: renamed from: c (int) void
   public void setActorState(int var1) {
      sbyte var2 = this.gameByteMatrix02[this.gameActorGroupReference01.actorStateReference01.byteValue01][this.gameActorGroupReference01.actorStateReference01.byteValue02];
      sbyte var3 = this.gameByteValue04;
      if (var1 == 1) {
         this.gameActorGroupReference01 = this.gameActorGroupReference03;
         this.gameActorGroupReference02 = this.gameActorGroupReference04;
         this.gameByteValue03 = 1;
         if (this.gameActorGroupReference04.byteValue05 != this.gameActorGroupReference03.byteValue05) {
            this.gameActorGroupReference04.actorStateReference01.booleanFlag01 = false;
         }
      } else {
         this.gameActorGroupReference01 = this.gameActorGroupReference04;
         this.gameActorGroupReference02 = this.gameActorGroupReference03;
         this.gameByteValue03 = 2;
         if (this.gameActorGroupReference04.byteValue05 != this.gameActorGroupReference03.byteValue05) {
            this.gameActorGroupReference03.actorStateReference01.booleanFlag01 = false;
         }
      }

      this.gameActorGroupReference01.actorStateReference01.booleanFlag01 = true;
      if (var3 != this.gameActorGroupReference01.byteValue05) {
         this.gameIntegerValue116 = 2;
         this.gameBooleanFlag02 = true;
         this.processLevelEntity(this.gameActorGroupReference01.byteValue05, true);
      } else if (var2 != this.gameByteMatrix02[this.gameActorGroupReference01.actorStateReference01.byteValue01][this.gameActorGroupReference01.actorStateReference01.byteValue02]) {
         this.updateAllActors(true);
      }

      if (var3 == this.gameActorGroupReference01.byteValue05) {
         this.updateActorDisplayState(this.gameActorGroupReference01.actorStateReference01, true);
      }
   }

   // $VF: renamed from: g () boolean
   public bool isActorMoving() {
      if (gameByteValue07 == 0
         || gameByteValue07 == 1
         || gameShortValue01 == 120 && gameByteValue07 == 3
         || gameShortValue01 == 70 && gameByteValue07 == 3
         || this.gameByteValue04 == 3
         || this.gameActorGroupReference01.actorStateReference01.byteValue05 != 0) {
         return false;
      } else {
         return gameIntegerValue50 != 384 ? false : this.gameLongValue06 - this.gameLongValue12 >= 1000L;
      }
   }

   // $VF: renamed from: c (p) boolean
   public static bool isActorAlive(ActorState var0) {
      return var0.byteValue08 == 0 || var0.byteValue08 == 1 || var0.byteValue08 == 3 || var0.byteValue08 == 5 || var0.byteValue08 == 7 || var0.byteValue08 == 10;
   }

   // $VF: renamed from: a (p) boolean
   public static bool isActorDefeated(ActorState var0) {
      return gameByteCube01[var0.byteValue08][var0.byteValue05][2] != 0;
   }

   // $VF: renamed from: b (p) boolean
   public bool hasActorStateChanged(ActorState var1) {
      if (var1.longValue01 == this.gameLongValue06) {
         return false;
      } else {
         return var1.byteValue12 < 0 || var1.byteValue13 < 0 ? true : var1.byteValue01 == var1.byteValue12 && var1.byteValue02 == var1.byteValue13;
      }
   }

   // $VF: renamed from: a (p, int, int) boolean
   public bool isActorNearPosition(ActorState var1, int var2, int var3) {
      int var4;
      return (var4 = absoluteValue(var1.byteValue07 - var2)) <= 1 || var4 >= 7;
   }

   // $VF: renamed from: a (int, int, int, int, int) int
   public int findEntityFrameData(int var1, int var2, int var3, int var4, int var5) {
      int var6 = 0;

      while (var6 < 5 && this.gameEntityFrameDataReferenceArray01[var6].booleanFlag01) {
         var6++;
      }

      if (var6 >= 5) {
         return var6;
      } else {
         copyEntityFrameData(
            this.gameEntityFrameDataReferenceArray01[var6], true, (short)(this.getTilePixelX(var2, var3) + var4), (short)((var3 + var2) * 27 + var5), (sbyte)var1, (sbyte)var2, (sbyte)var3
         );
         return var6;
      }
   }

   // $VF: renamed from: a (ab, boolean, short, short, byte, byte, byte) void
   public static void copyEntityFrameData(EntityFrameData var0, bool var1, short var2, short var3, sbyte var4, sbyte var5, sbyte var6) {
      var0.booleanFlag01 = var1;
      var0.booleanFlag02 = true;
      var0.shortValue01 = var2;
      var0.shortValue02 = var3;
      var0.shortValue03 = 0;
      var0.byteValue01 = var4;
      var0.byteValue04 = 0;
      var0.integerValue01 = 0;
      var0.byteValue02 = var5;
      var0.byteValue03 = var6;
   }

   // $VF: renamed from: a (int, int, int, int, int, byte) int
   public int findActorRuntimeState(int var1, int var2, int var3, int var4, int var5, sbyte var6) {
      int var7 = 0;

      while (var7 < 10 && this.gameClass22ReferenceArray01[var7].booleanFlag01) {
         var7++;
      }

      if (var7 >= 0 && var7 < 10) {
         TimedEntityEffect var8;
         EntityFrameData var9 = (var8 = this.gameClass22ReferenceArray01[var7]).entityFrameDataReference01;
         var8.booleanFlag01 = true;
         var8.byteValue01 = (sbyte)var1;
         var8.longValue01 = this.gameLongValue06;
         var8.byteValue02 = var6;
         copyEntityFrameData(var9, false, (short)0, (short)0, var9.byteValue01, var9.byteValue02, var9.byteValue03);
         var8.integerValue01 = var4;
         var8.integerValue02 = var5;
         switch (var1) {
            case 4:
               var9.byteValue02 = (sbyte)var2;
               var9.byteValue03 = (sbyte)var3;
               var8.shortValue01 = (short)(this.getTilePixelX(var2, var3) + 54);
               var8.shortValue02 = (short)((var3 + var2) * 27 + 27);
               if (this.gameActorGroupReference01.actorStateReference01.byteValue07 == 0) {
                  var8.shortValue02 = (short)(var8.shortValue02 + 12);
               } else if (this.gameActorGroupReference01.actorStateReference01.byteValue07 == 4) {
                  var8.shortValue02 = (short)(var8.shortValue02 - 24);
               } else if (this.gameActorGroupReference01.actorStateReference01.byteValue07 == 2) {
                  var8.shortValue01 = (short)(var8.shortValue01 + 40);
                  var8.shortValue02 = (short)(var8.shortValue02 - 20);
               } else if (this.gameActorGroupReference01.actorStateReference01.byteValue07 == 6) {
                  var8.shortValue01 = (short)(var8.shortValue01 - 40);
                  var8.shortValue02 = (short)(var8.shortValue02 - 20);
               } else if (this.gameActorGroupReference01.actorStateReference01.byteValue07 == 1) {
                  var8.shortValue01 = (short)(var8.shortValue01 + 24);
                  var8.shortValue02 = (short)(var8.shortValue02 + 4);
               } else if (this.gameActorGroupReference01.actorStateReference01.byteValue07 == 7) {
                  var8.shortValue01 = (short)(var8.shortValue01 - 48);
                  var8.shortValue02 = (short)(var8.shortValue02 + 4);
               } else if (this.gameActorGroupReference01.actorStateReference01.byteValue07 == 3) {
                  var8.shortValue01 = (short)(var8.shortValue01 + 32);
                  var8.shortValue02 = (short)(var8.shortValue02 - 32);
               } else if (this.gameActorGroupReference01.actorStateReference01.byteValue07 == 5) {
                  var8.shortValue01 = (short)(var8.shortValue01 - 32);
                  var8.shortValue02 = (short)(var8.shortValue02 - 32);
               } goto case 5;
            case 5:
            case 6:
            default:
               break;
            case 7:
               var9.byteValue02 = (sbyte)var2;
               var9.byteValue03 = (sbyte)var3;
               var8.shortValue01 = (short)(this.getTilePixelX(var2, var3) + 54);
               var8.shortValue02 = (short)((var3 + var2) * 27 + 27);
               break;
            case 8:
               var9.byteValue02 = (sbyte)var2;
               var9.byteValue03 = (sbyte)var3;
               var8.shortValue01 = (short)(this.getTilePixelX(var2, var3) + 54);
               var8.shortValue02 = (short)((var3 + var2) * 27 + 27);
               if (this.gameActorGroupReference01.actorStateReference01.byteValue07 == 0) {
                  var8.shortValue02 = (short)(var8.shortValue02 + 12);
               } else if (this.gameActorGroupReference01.actorStateReference01.byteValue07 == 4) {
                  var8.shortValue02 = (short)(var8.shortValue02 - 24);
               } else if (this.gameActorGroupReference01.actorStateReference01.byteValue07 == 2) {
                  var8.shortValue01 = (short)(var8.shortValue01 + 32);
                  var8.shortValue02 = (short)(var8.shortValue02 - 32);
               } else if (this.gameActorGroupReference01.actorStateReference01.byteValue07 == 6) {
                  var8.shortValue01 = (short)(var8.shortValue01 - 32);
                  var8.shortValue02 = (short)(var8.shortValue02 - 32);
               } else if (this.gameActorGroupReference01.actorStateReference01.byteValue07 == 1) {
                  var8.shortValue01 = (short)(var8.shortValue01 + 24);
                  var8.shortValue02 = (short)(var8.shortValue02 + 4);
               } else if (this.gameActorGroupReference01.actorStateReference01.byteValue07 == 7) {
                  var8.shortValue01 = (short)(var8.shortValue01 - 48);
                  var8.shortValue02 = (short)(var8.shortValue02 + 4);
               } else if (this.gameActorGroupReference01.actorStateReference01.byteValue07 == 3) {
                  var8.shortValue01 = (short)(var8.shortValue01 + 32);
                  var8.shortValue02 = (short)(var8.shortValue02 - 32);
               } else if (this.gameActorGroupReference01.actorStateReference01.byteValue07 == 5) {
                  var8.shortValue01 = (short)(var8.shortValue01 - 32);
                  var8.shortValue02 = (short)(var8.shortValue02 - 32);
               } break;
         }

         switch (var1) {
            case 4:
            case 8:
               var8.shortValue03 = (short)(this.getTilePixelX(var4, var5) + 54);
               var8.shortValue04 = (short)((var5 + var4) * 27 + 27);
               int var13;
               var8.shortValue05 = (short)integerSquareRoot((var2 = var8.shortValue03 - var8.shortValue01) * var2 + (var13 = var8.shortValue04 - var8.shortValue02) * var13);
               var9.booleanFlag01 = true;
               var9.byteValue01 = 2;
               break;
            case 5:
            case 6:
            default:
               var8.shortValue03 = var8.shortValue01;
               var8.shortValue04 = var8.shortValue02;
               break;
            case 7:
               var8.shortValue03 = (short)(this.getTilePixelX(var4, var5) + 54);
               var8.shortValue04 = (short)((var5 + var4) * 27 + 27);
               int var11;
               var8.shortValue05 = (short)integerSquareRoot((var2 = var8.shortValue03 - var8.shortValue01) * var2 + (var11 = var8.shortValue04 - var8.shortValue02) * var11);
               var9.booleanFlag01 = true;
               var9.byteValue01 = 40; break;
         }

         return var7;
      } else {
         return var7;
      }
   }

   // $VF: renamed from: h () boolean
   public bool isPlayerActorActive() {
      return (
            this.gameActorGroupReference01.actorStateReference01.byteValue05 == 0
               || this.gameActorGroupReference01.actorStateReference01.byteValue05 == 8
               || this.gameActorGroupReference01.actorStateReference01.byteValue05 == 9
               || this.gameActorGroupReference01.actorStateReference01.byteValue05 == 10
               || this.gameActorGroupReference01.actorStateReference01.byteValue05 == 11
         )
         | (
            gameByteCube01[this.gameActorGroupReference01.actorStateReference01.byteValue08][this.gameActorGroupReference01.actorStateReference01.byteValue05][2] != 0
               && gameByteCube01[this.gameActorGroupReference01.actorStateReference01.byteValue08][this.gameActorGroupReference01.actorStateReference01.byteValue05][2] < this.gameActorGroupReference01.actorStateReference01.byteValue03
               && this.gameActorGroupReference01.actorStateReference01.integerValue01
                     + this.scaleFixedPointValue(
                        gameByteCube01[this.gameActorGroupReference01.actorStateReference01.byteValue08][this.gameActorGroupReference01.actorStateReference01.byteValue05][1] << 8,
                        gameByteCube01[this.gameActorGroupReference01.actorStateReference01.byteValue08][this.gameActorGroupReference01.actorStateReference01.byteValue05][0]
                     )
                  >= 65534
         );
   }

   // $VF: renamed from: g () void
   public void updatePlayerActor() {
      this.updateActorGroupState(false);
   }

   // $VF: renamed from: b (boolean) void
   public void updateActorGroupState(bool var1) {
      gameBooleanFlag55 = true;
      if (this.gameActorGroupReference01.actorStateReference01.byteValue05 != 3 && this.gameActorGroupReference01.actorStateReference01.byteValue05 != 4) {
         if (gameIntegerValue50 == 131 || gameIntegerValue50 == 130) {
            this.updateLevelTimer((int)(this.gameLongValue06 - this.gameLongValue10));
         }

         if (this.findActorById() >= 0) {
            if (gameIntegerValue50 == 900 || gameIntegerValue50 == 901) {
               return;
            }

            if (gameIntegerValue50 == 384 && (this.gameActorGroupReference01.byteValue04 == 0 || this.gameActorGroupReference01.byteValue04 == 5 || this.gameActorGroupReference01.byteArray01[this.gameActorGroupReference01.byteValue04] <= 0)
               )
             {
               if (this.gameActorGroupReference01.byteArray01[1] <= 0) {
                  this.setActorAnimation(0);
               } else {
                  this.setActorAnimation(1);
               }
            }

            gameIntegerValue50 = 900;
            if (gameByteCube01[this.gameActorGroupReference01.actorStateReference01.byteValue08][this.gameActorGroupReference01.actorStateReference01.byteValue05][2] == 0) {
               this.faceActorTowardPosition(this.gameActorGroupReference01.actorStateReference01, 0);
            }

            this.setActorAnimation(this.gameActorGroupReference01.byteValue04);
            this.gameActorGroupReference01.byteValue02 = (sbyte)gameIntegerArray02[this.gameActorGroupReference01.byteValue04];
            if (gameIntegerValue23 != 4 && gameShortValue01 != 50 && gameShortValue01 != 70) {
               stopAudioPlayer();
            }

            if (var1 && gameShortValue01 != 50 && gameShortValue01 != 70) {
               this.processActorAction(25);
            }

            if (this.gameActorGroupReference01.byteValue04 != 0 && gameShortValue01 != 50 && gameShortValue01 != 70 || gameShortValue01 == 50 && gameByteValue07 == 0 || gameShortValue01 == 70 && gameByteValue07 == 0) {
               this.transitionGameState(4);
               return;
            }
         } else {
            if (gameIntegerValue50 == 131) {
               gameIntegerValue50 = 384;
               return;
            }

            if (gameIntegerValue50 == 384) {
               return;
            }

            if ((gameIntegerValue50 & 512) != 0) {
               this.gameActorGroupReference01.byteValue02 = 0;
            }

            gameIntegerValue50 = 384;
            if (gameByteCube01[this.gameActorGroupReference01.actorStateReference01.byteValue08][this.gameActorGroupReference01.actorStateReference01.byteValue05][2] == 0) {
               this.faceActorTowardPosition(this.gameActorGroupReference01.actorStateReference01, 0);
               if (this.gameActorGroupReference01.actorStateReference01.byteValue07 % 2 == 0) {
                  setActorFacingDirection(this.gameActorGroupReference01.actorStateReference01, this.gameActorGroupReference01.actorStateReference01.byteValue07 + 1);
               }
            }

            this.setActorAnimation(127);
         }
      }
   }

   // $VF: renamed from: d () int
   public int findActorById() {
      for (int var1 = 0; var1 < 25; var1++) {
         ActorState var2;
         if ((var2 = this.gameActorStateReferenceArray01[var1]).booleanFlag01 && var2.byteValue10 > 0 && var2.byteValue05 != 4) {
            if (var2.byteValue08 == 5 && this.gameByteValue05 == this.gameByteMatrix02[var2.byteValue01][var2.byteValue02] && !var2.booleanFlag05) {
               return this.gameActorStateReferenceArray01[var1].byteValue08;
            }

            if (!isActorAlive(var2) && this.gameByteValue05 == this.gameByteMatrix02[var2.byteValue01][var2.byteValue02] && !var2.booleanFlag05) {
               return this.gameActorStateReferenceArray01[var1].byteValue08;
            }
         }
      }

      return -1;
   }

   // $VF: renamed from: h () void
   public void updateActorGroups() {
      this.updateAllActors(true);
   }

   // $VF: renamed from: d (boolean) void
   public void updateAllActors(bool var1) {
      GameCanvas var2 = this;

      for (int var3 = 0; var3 < 5; var3++) {
         var2.gameEntityFrameDataReferenceArray01[var3].booleanFlag01 = false;
      }

      for (int var24 = 0; var24 < 10; var24++) {
         var2.gameClass22ReferenceArray01[var24].booleanFlag01 = false;
      }

      this.gameByteValue05 = this.gameByteMatrix02[this.gameActorGroupReference01.actorStateReference01.byteValue01][this.gameActorGroupReference01.actorStateReference01.byteValue02];
      this.gameIntegerValue55 = 65536;
      this.gameIntegerValue56 = 65536;
      this.gameIntegerValue57 = 0;
      this.gameIntegerValue58 = 0;
      this.gameIntegerValue59 = this.gameByteValue12;
      this.gameIntegerValue60 = this.gameByteValue13;
      this.gameIntegerValue61 = 0;
      this.gameIntegerValue62 = 0;

      for (int var18 = 0; var18 < this.gameByteValue12; var18++) {
         for (int var25 = 0; var25 < this.gameByteValue13; var25++) {
            if (this.gameByteValue05 == this.gameByteMatrix02[var18][var25]) {
               int var4 = this.getTilePixelX(var18, var25);
               int var5 = (var25 + var18) * 27;
               this.gameIntegerValue55 = JMath.min(this.gameIntegerValue55, var4 - 54);
               this.gameIntegerValue57 = JMath.max(this.gameIntegerValue57, var4 + 54 + 108 - this.gameIntegerValue55);
               this.gameIntegerValue56 = JMath.min(this.gameIntegerValue56, var5 - 120);
               this.gameIntegerValue58 = JMath.max(this.gameIntegerValue58, var5 + 27 + 54 - this.gameIntegerValue56);
               this.gameIntegerValue59 = JMath.min(this.gameIntegerValue59, var18);
               this.gameIntegerValue60 = JMath.min(this.gameIntegerValue60, var25);
               this.gameIntegerValue61 = JMath.max(this.gameIntegerValue61, var18);
               this.gameIntegerValue62 = JMath.max(this.gameIntegerValue62, var25);
            }
         }
      }

      var2 = this;
      if (gameByteValue07 != 3) {
         for (int var26 = 0; var26 < var2.gameClass20ReferenceArray01[var2.gameByteValue05].byteValue01; var26++) {
            if (!var2.gameClass19ReferenceArray01[var2.gameClass20ReferenceArray01[var2.gameByteValue05].tileCoordinateReferenceArray01[var26].byteValue02].booleanFlag02
               && (
                  var2.gameClass20ReferenceArray01[var2.gameByteValue05].tileCoordinateReferenceArray01[var26].byteValue01 < 0
                     || var2.gameClass19ReferenceArray01[var2.gameClass20ReferenceArray01[var2.gameByteValue05].tileCoordinateReferenceArray01[var26].byteValue01].booleanFlag02
               )) {
               var2.addActorStatusEffect(var2.gameClass19ReferenceArray01[var2.gameClass20ReferenceArray01[var2.gameByteValue05].tileCoordinateReferenceArray01[var26].byteValue02]);
               if (!var2.gameClass19ReferenceArray01[var2.gameClass20ReferenceArray01[var2.gameByteValue05].tileCoordinateReferenceArray01[var26].byteValue02].booleanFlag01) {
                  var2.gameClass19ReferenceArray01[var2.gameClass20ReferenceArray01[var2.gameByteValue05].tileCoordinateReferenceArray01[var26].byteValue02].booleanFlag02 = true;
               }
            }
         }
      }

      this.updateActorGroupState(var1);
      if (this.gameActorGroupReference01.byteValue05 == 0
         && this.gameActorGroupReference01.actorStateReference01.byteValue01 > 57
         && this.gameActorGroupReference01.actorStateReference01.byteValue01 < 69
         && this.gameActorGroupReference01.actorStateReference01.byteValue02 > 17
         && this.gameActorGroupReference01.actorStateReference01.byteValue02 < 31) {
         this.gameBooleanFlag39 = true;
      } else {
         this.gameBooleanFlag39 = false;
      }

      var2 = this;
      if (this.gameByteValue05 != 0) {
         int var27 = this.gameIntegerValue61 - this.gameIntegerValue59 + 1;
         int var1i = this.gameIntegerValue62 - this.gameIntegerValue60 + 1;
         int var28;
         sbyte[] var31 = new sbyte[(var28 = var27 + var1i) * var28];
         int var11 = 0;

         for (int var6 = 0; var6 < var28; var6++) {
            for (int var34 = 0; var34 < var28; var34++) {
               int var9 = ((var34 - var1i < 0 ? -(var34 - var1i) : var34 - var1i) & 1) + ((var6 & 1) << 1);
               int var7;
               if (var34 > var1i) {
                  var7 = (var34 - var1i + 1) / 2;
               } else {
                  var7 = (var34 - var1i) / 2;
               }

               int var8 = var6 / 2 - var7;
               int var48 = var7 + var6 / 2;
               int var10 = var2.scaleScreenCoordinate(var48, var8);
               if (var9 == 0) {
                  var7 = var2.scaleScreenCoordinate(var48, var8 - 1);
               } else if (var9 == 1) {
                  var7 = var2.scaleScreenCoordinate(var48 - 1, var8);
               } else if (var9 == 2) {
                  var7 = var2.scaleScreenCoordinate(var48 + 1, var8);
               } else {
                  var7 = var2.scaleScreenCoordinate(var48, var8 + 1);
               }

               if (var10 == 127 && var7 == 127) {
                  var31[var11] = 8;
               } else if (var10 == 127 && var7 != 127) {
                  if (var9 == 0) {
                     var31[var11] = 3;
                  }

                  if (var9 == 1) {
                     var31[var11] = 2;
                  }

                  if (var9 == 2) {
                     var31[var11] = 1;
                  }

                  if (var9 == 3) {
                     var31[var11] = 0;
                  }
               } else if (var10 != 127 && var7 == 127) {
                  var31[var11] = (sbyte)var9;
               } else {
                  var31[var11] = (sbyte)(var9 + 4);
               }

               var11++;
            }
         }

         sbyte var14 = 127;

         for (int var35 = var2.gameIntegerValue59 + 1; var35 <= var2.gameIntegerValue61; var35++) {
            int var43 = var2.gameIntegerValue60 + 1;

            while (var43 <= var2.gameIntegerValue62 && (var2.gameByteValue05 != var2.gameByteMatrix02[var35][var43] || (var14 = var2.gameByteMatrix01[var35][var43]) == 127)) {
               var43++;
            }

            if (var14 != 127) {
               break;
            }
         }

         gameIntegerValue117 = var14;
         int var15 = var14 + var2.gameShortValue06;
         Image[] var21 = new Image[9];
         int[] var52 = new int[]{
            -54, 0, -1, -1, 0, 0, -1, -1, -54, -27, -1, -1, 0, -27, -1, -1, -54, 0, 0, -27, 0, 0, -54, -27, -54, -27, 0, 0, 0, -27, -54, 0, -1, -1, -1, -1
         };

         for (int var55 = 0; var55 < 9; var55++) {
            var21[var55] = Image.createImage(54, 27);
            Image var36;
            Graphics var50;
            (var50 = (var36 = var21[var55]).getGraphics()).setColor(0);
            var50.fillRect(0, 0, 54, 27);
            int var37 = var52[var55 << 2];
            int var44 = var52[(var55 << 2) + 1];
            if (var37 != -1 && var44 != -1) {
               SpriteResourceDecoder var38 = gameSpriteDecoderReference01;
               gameSpriteDecoderReference01.drawSpriteFrameTransformed(var50, var15, var37, var44, 0, 0, 0);
            }

            int var39 = var52[(var55 << 2) + 2];
            var44 = var52[(var55 << 2) + 3];
            if (var39 != -1 && var44 != -1) {
               SpriteResourceDecoder var40 = gameSpriteDecoderReference01;
               gameSpriteDecoderReference01.drawSpriteFrameTransformed(var50, var15, var39, var44, 0, 0, 0);
            }

            gameSpriteDecoderReference02.cacheSpriteImage(var21[var55], var55, 0);
         }

         sbyte[] var56;
         writeShortBigEndian(var56 = new sbyte[4], 0, (short)var28);
         writeShortBigEndian(var56, 2, (short)var28);
         SpriteAnimation.decodeAnimationSprite(0, var56, var31, null, gameSpriteDecoderReference02, true, 16, 2, 2);
      }

      int var32 = 0;
      int var41 = 0;
      int var16 = 0;
      int var29 = 0;
      int var46 = 0;
      this.gameIntegerArray03 = new int[this.gameShortValue05];

      for (int var22 = 0; var22 < this.gameShortValue05; var22++) {
         ActorRuntimeState var53 = this.gameClass9ReferenceArray01[var22];
         if (this.gameByteValue05 == this.gameByteMatrix02[var53.byteValue02][var53.byteValue03]) {
            if (this.gameShortMatrix03[var53.byteValue01][6] == 0) {
               if (this.gameShortMatrix03[var53.byteValue01][8] == 1) {
                  var16++;
               } else {
                  var29++;
               }
            } else if (var53.booleanFlag01) {
               var32++;
            } else {
               var41++;
            }
         } else if (var53.booleanFlag01) {
            var46++;
         }
      }

      gameIntegerValue70 = 0;
      gameIntegerValue75 = gameIntegerValue80 = (
            gameIntegerValue74 = gameIntegerValue79 = (gameIntegerValue73 = gameIntegerValue78 = (gameIntegerValue72 = gameIntegerValue77 = (gameIntegerValue71 = gameIntegerValue76 = var32 + 0) + var41) + var16) + var29
         )
         + var46;
      int var33 = 0;
      int var42 = 0;
      int var17 = 0;
      int var30 = 0;
      int var47 = 0;
      int var51 = 0;

      for (int var23 = 0; var23 < this.gameShortValue05; var23++) {
         ActorRuntimeState var54 = this.gameClass9ReferenceArray01[var23];
         if (this.gameByteValue05 == this.gameByteMatrix02[var54.byteValue02][var54.byteValue03]) {
            if (this.gameShortMatrix03[var54.byteValue01][6] == 0) {
               if (this.gameShortMatrix03[var54.byteValue01][8] == 1) {
                  this.gameIntegerArray03[gameIntegerValue72 + var17++] = var23;
               } else {
                  this.gameIntegerArray03[gameIntegerValue73 + var30++] = var23;
               }
            } else if (var54.booleanFlag01) {
               this.gameIntegerArray03[0 + var33++] = var23;
            } else {
               this.gameIntegerArray03[gameIntegerValue71 + var42++] = var23;
            }
         } else if (var54.booleanFlag01) {
            this.gameIntegerArray03[gameIntegerValue74 + var47++] = var23;
         } else {
            this.gameIntegerArray03[gameIntegerValue75 + var51++] = var23;
         }
      }
   }

   // $VF: renamed from: b (int, int) void
   public void changeActorAction(int var1, int var2) {
      if (var1 != 11 && var1 != 14) {
         this.restoreAudioState();
      }

      this.gameIntegerValue49 = (sbyte)var1;
      this.gameBooleanFlag31 = true;
   }

   // $VF: renamed from: G () void
   public void resetActorActions() {
      for (int var1 = 2; var1 < 25; var1++) {
         this.gameActorStateReferenceArray01[var1].booleanFlag01 = false;
      }

      if (this.gameActorGroupReference03.entitySnapshotReferenceArray01 != null) {
         for (int var2 = 0; var2 < this.gameActorGroupReference03.byteValue01; var2++) {
            this.gameActorGroupReference03.entitySnapshotReferenceArray01[var2].tileCoordinateReferenceArray01 = null;
            this.gameActorGroupReference03.entitySnapshotReferenceArray01[var2].shortValue02 = 0;
         }
      }

      if (this.gameActorGroupReference04.entitySnapshotReferenceArray01 != null) {
         for (int var3 = 0; var3 < this.gameActorGroupReference04.byteValue01; var3++) {
            this.gameActorGroupReference04.entitySnapshotReferenceArray01[var3].tileCoordinateReferenceArray01 = null;
            this.gameActorGroupReference04.entitySnapshotReferenceArray01[var3].shortValue02 = 0;
         }
      }

      this.gameByteMatrix01 = null;
      this.gameShortMatrix01 = null;
      this.gameShortMatrix02 = null;
      this.gameByteMatrix02 = null;
      this.gameClass9ReferenceArray01 = null;
      this.gameIntegerArray03 = null;
      this.gameClass20ReferenceArray01 = null;
      this.gameClass19ReferenceArray01 = null;
      this.gameByteArray02 = null;
   }

   // $VF: renamed from: a (java.lang.String, int) byte[]
   public static sbyte[] loadGameDataFile(string var0, int var1) {
      if (var0 != null) {
         openAssetStream(var0);
      }

      sbyte[] var2 = loadAssetBytes(var1);
      if (var0 != null) {
         closeAssetStream();
      }

      return var2;
   }

   // $VF: renamed from: p (int) void
   public void loadLevelData(int var1) {
      bool var7 = true;
      sbyte[] var8 = loadAssetBytes(1);
      int var2 = 0;
      int var3 = ((var8[0] & 255) << 8 | var8[1] & 255) / 13;
      int var13 = var2 + 2;
      this.gameShortMatrix03 = new short[var3][];

      for (int var4 = 0; var4 < var3; var4++) {
         this.gameShortMatrix03[var4] = new short[9];
         short[] var10000 = this.gameShortMatrix03[var4];
         int var6 = var13 + 1;
         var10000[0] = (short)(((var8[var13] & 255) << 8 | var8[var6] & 255) * 3 / 2);
         var2 = var13 + 2;
         var10000 = this.gameShortMatrix03[var4];
         var6 = var2 + 1;
         var10000[1] = (short)(((var8[var2] & 255) << 8 | var8[var6] & 255) * 3 / 2);
         var2 += 2;
         var10000 = this.gameShortMatrix03[var4];
         var6 = var2 + 1;
         var10000[2] = (short)((var8[var2] & 255) << 8 | var8[var6] & 255);
         var2 += 2;
         var10000 = this.gameShortMatrix03[var4];
         var6 = var2 + 1;
         var10000[3] = (short)((var8[var2] & 255) << 8 | var8[var6] & 255);
         var13 = var2 + 2;
         this.gameShortMatrix03[var4][4] = (short)var8[var13++];
         this.gameShortMatrix03[var4][5] = (short)var8[var13++];
         this.gameShortMatrix03[var4][6] = (short)var8[var13++];
         this.gameShortMatrix03[var4][7] = (short)var8[var13++];
         this.gameShortMatrix03[var4][8] = (short)var8[var13++];
      }
   }

   // $VF: renamed from: i () boolean
   public bool initializeLevelResources() {
      this.gameByteArray04 = null;
      if (gameIntegerValue103 == this.gameByteValue04) {
         gameBooleanFlag09 = true;
      } else {
         gameBooleanFlag09 = false;
         gameIntegerValue103 = this.gameByteValue04;
      }

      if (!gameBooleanFlag09) {
         this.gameShortMatrix03 = null;
      }

      sbyte var2 = 3;
      GameCanvas var1 = this;
      openAssetStream("/7");
      var2 = 3;
      sbyte[] var4 = loadAssetBytes(3);
      int var5 = 0;
      closeAssetStream();
      int var6 = ((var4[0] & 255) << 8 | var4[1] & 255) / 2;
      int var32 = var5 + 2;
      this.gameByteArray04 = new sbyte[var6 << 1];

      for (int var7 = 0; var7 < var6; var7++) {
         var1.gameByteArray04[var7 << 1] = var4[var32++];
         var1.gameByteArray04[(var7 << 1) + 1] = var4[var32++];
      }

      if (this.gameByteValue04 == 0) {
         if (!gameBooleanFlag09) {
            openAssetStream("/8");
            this.loadLevelData(1);
            gameSpriteDecoderReference01 = createSpriteResource(2, true, true);
            this.gameShortValue06 = 72;
            this.gameShortValue07 = 13;
         }
      } else if (this.gameByteValue04 == 1) {
         if (!gameBooleanFlag09) {
            openAssetStream("/9");
            this.loadLevelData(1);
            gameSpriteDecoderReference01 = createSpriteResource(2, true, true);
            this.gameShortValue06 = 57;
            this.gameShortValue07 = 19;
         }
      } else if (this.gameByteValue04 == 2) {
         if (!gameBooleanFlag09) {
            openAssetStream("/10");
            this.loadLevelData(1);
            gameSpriteDecoderReference01 = createSpriteResource(2, true, true);
            this.gameShortValue06 = 34;
            this.gameShortValue07 = 20;
         }
      } else if (this.gameByteValue04 == 3 && !gameBooleanFlag09) {
         openAssetStream("/11");
         this.loadLevelData(1);
         gameSpriteDecoderReference01 = createSpriteResource(2, true, true);
         this.gameShortValue06 = 14;
         this.gameShortValue07 = 3;
      }

      if (!gameBooleanFlag09) {
         closeAssetStream();
      } else {
         gameBooleanFlag09 = false;
      }

      this.gameIntegerValue93 = -1;
      this.gameIntegerValue94 = 0;
      this.gameIntegerValue95 = 0;
      sbyte[] var9 = null;
      if (this.gameByteValue04 == 0) {
         var9 = loadGameDataFile("/8", 0);
      }

      if (this.gameByteValue04 == 1) {
         var9 = loadGameDataFile("/9", 0);
      }

      if (this.gameByteValue04 == 2) {
         var9 = loadGameDataFile("/10", 0);
      }

      if (this.gameByteValue04 == 3) {
         var9 = loadGameDataFile("/11", 0);
      }

      ByteArrayReader var3 = new ByteArrayReader(var9);
      this.gameByteValue12 = var3.readSignedByte();
      this.gameByteValue13 = var3.readSignedByte();
      this.gameIntegerValue52 = this.gameByteValue12 * 108 / 2;
      this.gameByteMatrix01 = JArr.New2<sbyte>(this.gameByteValue12, this.gameByteValue13);
      this.gameShortMatrix01 = JArr.New2<short>(this.gameByteValue12, this.gameByteValue13);
      this.gameShortMatrix02 = JArr.New2<short>(this.gameByteValue12, this.gameByteValue13);
      this.gameByteMatrix02 = JArr.New2<sbyte>(this.gameByteValue12, this.gameByteValue13);

      for (int var10 = 0; var10 < this.gameByteValue12; var10++) {
         for (int var20 = 0; var20 < this.gameByteValue13; var20++) {
            this.gameByteMatrix01[var10][var20] = var3.readSignedByte();
         }
      }

      for (int var11 = 0; var11 < this.gameByteValue12; var11++) {
         for (int var21 = 0; var21 < this.gameByteValue13; var21++) {
            this.gameShortMatrix02[var11][var21] = var3.readUnsignedShortBigEndian();
         }
      }

      for (int var12 = 0; var12 < this.gameByteValue12; var12++) {
         for (int var22 = 0; var22 < this.gameByteValue13; var22++) {
            this.gameShortMatrix01[var12][var22] = (short)(this.gameShortMatrix01[var12][var22] | var3.readUnsignedShortBigEndian());
         }
      }

      for (int var13 = 0; var13 < this.gameByteValue12; var13++) {
         for (int var23 = 0; var23 < this.gameByteValue13; var23++) {
            this.gameByteMatrix02[var13][var23] = var3.readSignedByte();
         }
      }

      this.gameShortValue05 = var3.readUnsignedShortBigEndian();
      this.gameClass9ReferenceArray01 = new ActorRuntimeState[this.gameShortValue05];

      for (int var14 = 0; var14 < this.gameShortValue05; var14++) {
         ActorRuntimeState var28;
         (var28 = new ActorRuntimeState(this)).byteValue01 = var3.readSignedByte();
         var28.byteValue02 = var3.readSignedByte();
         var28.byteValue03 = var3.readSignedByte();
         var28.shortValue01 = (short)this.getTilePixelX(var28.byteValue02, var28.byteValue03);
         var5 = var28.byteValue03;
         var2 = var28.byteValue02;
         var28.shortValue02 = (short)((var5 + var2) * 27);
         var28.booleanFlag01 = var3.readBoolean();
         var28.booleanFlag02 = var3.readBoolean();
         var28.booleanFlag03 = var3.readBoolean();
         var28.booleanFlag04 = var3.readBoolean();
         var28.byteValue04 = var3.readSignedByte();
         var28.actorFlagsReferenceArray01 = new ActorFlags[var28.byteValue04];

         for (int var25 = 0; var25 < var28.byteValue04; var25++) {
            var28.actorFlagsReferenceArray01[var25] = new ActorFlags(this);
            var28.actorFlagsReferenceArray01[var25].byteValue01 = var3.readSignedByte();
            var28.actorFlagsReferenceArray01[var25].byteValue02 = var3.readSignedByte();
            var28.actorFlagsReferenceArray01[var25].byteValue03 = var3.readSignedByte();
            var28.actorFlagsReferenceArray01[var25].booleanFlag01 = var3.readBoolean();
            var28.actorFlagsReferenceArray01[var25].booleanFlag02 = var3.readBoolean();
         }

         this.gameClass9ReferenceArray01[var14] = var28;
      }

      ByteArrayReader var26 = var3;
      var1 = this;
      sbyte var36 = var3.readSignedByte();

      for (int var37 = 0; var37 < var36; var37++) {
         sbyte var29 = var26.readSignedByte();
         var5 = var26.position;
         var1.readEntitySnapshot(var1.gameActorGroupReference03.entitySnapshotReferenceArray01[var29], var26);
         var26.position = var5;
         var1.readEntitySnapshot(var1.gameActorGroupReference04.entitySnapshotReferenceArray01[var29], var26);
      }

      this.gameByteValue06 = var3.readSignedByte();
      this.gameClass20ReferenceArray01 = new ActorTypeData[this.gameByteValue06];

      for (int var16 = 0; var16 < this.gameByteValue06; var16++) {
         this.gameClass20ReferenceArray01[var16] = new ActorTypeData(this);
         this.gameClass20ReferenceArray01[var16].byteValue01 = var3.readSignedByte();
         this.gameClass20ReferenceArray01[var16].tileCoordinateReferenceArray01 = new TileCoordinate[this.gameClass20ReferenceArray01[var16].byteValue01];

         for (int var27 = 0; var27 < this.gameClass20ReferenceArray01[var16].byteValue01; var27++) {
            TileCoordinate var30;
            (var30 = new TileCoordinate(this)).byteValue01 = var3.readUnsignedShortBigEndian();
            var30.byteValue02 = var3.readUnsignedShortBigEndian();
            this.gameClass20ReferenceArray01[var16].tileCoordinateReferenceArray01[var27] = var30;
         }
      }

      this.gameShortValue08 = var3.readUnsignedShortBigEndian();
      this.gameClass19ReferenceArray01 = new ActorStatus[this.gameShortValue08];

      for (int var17 = 0; var17 < this.gameShortValue08; var17++) {
         ActorStatus var31;
         (var31 = new ActorStatus(this)).byteValue01 = var3.readSignedByte();
         var31.byteValue02 = var3.readSignedByte();
         var31.booleanFlag01 = var3.readBoolean();
         var31.shortValue01 = var3.readUnsignedShortBigEndian();
         var31.shortValue02 = var3.readUnsignedShortBigEndian();
         var31.booleanFlag02 = false;
         this.gameClass19ReferenceArray01[var17] = var31;
      }

      this.gameShortValue09 = var3.readUnsignedShortBigEndian();
      this.gameByteArray02 = new sbyte[this.gameShortValue09];

      for (int var18 = 0; var18 < this.gameShortValue09; var18++) {
         this.gameByteArray02[var18] = var3.readSignedByte();
      }

      this.gameBooleanFlag38 = true;
      if (this.gameByteValue04 == 0 && this.gameBooleanFlag45) {
         this.deactivateActorRuntimeState(538);
      }

      return true;
   }

   // $VF: renamed from: a (s, c) void
   public void readEntitySnapshot(EntitySnapshot var1, ByteArrayReader var2) {
      short var5 = var2.readUnsignedShortBigEndian();
      var1.shortValue02 = var5;
      var1.tileCoordinateReferenceArray01 = new TileCoordinate[var5];

      for (int var6 = 0; var6 < var5; var6++) {
         short var3 = var2.readUnsignedShortBigEndian();
         short var4 = var2.readUnsignedShortBigEndian();
         var1.tileCoordinateReferenceArray01[var6] = new TileCoordinate(this);
         var1.tileCoordinateReferenceArray01[var6].byteValue01 = var3;
         var1.tileCoordinateReferenceArray01[var6].byteValue02 = var4;
      }
   }

   // $VF: renamed from: H () void
   public void updateCurrentLevel() {
      if (this.gameByteValue04 == 0) {
         this.createActorState(2, 16, 30, 1);
         this.createActorState(4, 24, 26, 5);
         this.createActorState(2, 18, 25, 3);
         this.createActorState(2, 27, 12, 3);
         this.createActorState(2, 3, 30, 5);
         this.createActorState(4, 6, 22, 7);
         this.createActorState(2, 11, 28, 1);
         this.createActorState(4, 8, 24, 3);
         this.createActorState(2, 8, 18, 5);
         this.createActorState(2, 46, 18, 3);
         this.createActorState(4, 57, 22, 1);
         this.createActorState(2, 52, 17, 7);
      } else if (this.gameByteValue04 == 1) {
         this.createActorState(4, 9, 6, 3);
         this.createActorState(2, 15, 8, 5);
         this.createActorState(4, 14, 9, 7);
         this.createActorState(2, 14, 17, 1);
         this.createActorState(4, 2, 10, 3);
         this.createActorState(2, 26, 42, 1);
         this.createActorState(4, 25, 45, 5);
      } else {
         if (this.gameByteValue04 == 2) {
            this.createActorState(9, this.gameClass9ReferenceArray01[172].byteValue02 - 1, this.gameClass9ReferenceArray01[172].byteValue03, 7);
            this.createActorState(6, 18, 29, 1);
            this.createActorState(2, 25, 43, 1);
            this.createActorState(4, 25, 31, 5);
            this.createActorState(2, 11, 19, 7);
            this.createActorState(4, 9, 13, 7);
            this.createActorState(2, 5, 8, 3);
            this.createActorState(11, 15, 7, 3);
            this.createActorState(4, 19, 11, 5);
         }
      }
   }

   // $VF: renamed from: a (int, boolean) void
   public void processLevelEntity(int var1, bool var2) {
      this.gameIntegerValue115 = 1;
      bool var3 = true;
      this.gameIntegerValue05 = var1;
      this.gameBooleanFlag01 = var3;
      this.changeActorAction(9, 0);
      this.updateCanvasState();
   }

   // $VF: renamed from: i () void
   public void updateLevelEntities() {
      if (this.gameByteValue04 == 0) {
         if (this.gameByteArray05[0] == -2 || this.gameByteArray05[0] == 23) {
            ActorRuntimeState var1;
            (var1 = this.gameClass9ReferenceArray01[508]).byteValue02 = 2;
            var1.byteValue03 = 23;
            var1.shortValue01 = (short)this.getTilePixelX(var1.byteValue02, var1.byteValue03);
            sbyte var2 = var1.byteValue03;
            sbyte var3 = var1.byteValue02;
            var1.shortValue02 = (short)((var2 + var3) * 27);
         }

         if (this.gameByteArray05[1] == -2 || this.gameByteArray05[1] == 24) {
            ActorRuntimeState var4;
            (var4 = this.gameClass9ReferenceArray01[507]).byteValue02 = 2;
            var4.byteValue03 = 20;
            var4.shortValue01 = (short)this.getTilePixelX(var4.byteValue02, var4.byteValue03);
            sbyte var10 = var4.byteValue03;
            sbyte var5 = var4.byteValue02;
            var4.shortValue02 = (short)((var10 + var5) * 27);
         }

         if (this.gameByteValue16 == 1) {
            this.activateActorRuntimeState(545);
            return;
         }
      } else if (this.gameByteValue04 == 1) {
         if (this.gameByteValue16 == 0) {
            this.activateActorRuntimeState(3);
         }

         if (this.gameByteValue20 == 0) {
            this.updateActorPositions();
            this.deactivateActorRuntimeState(20);

            for (int var9 = 0; var9 < 45; var9++) {
               this.activateActorRuntimeState(var9 + 226);
            }

            this.activateActorRuntimeState(274);
            this.activateActorRuntimeState(275);
            this.activateActorRuntimeState(276);
            this.activateActorRuntimeState(271);
            this.activateActorRuntimeState(272);
            this.activateActorRuntimeState(273);
            this.activateActorRuntimeState(278);
            this.activateActorRuntimeState(277);
            this.activateActorRuntimeState(280);
            this.gameByteValue28 = 6;
            return;
         }

         if (this.gameByteValue20 == 1) {
            this.updateActorPositions();
            this.deactivateActorRuntimeState(20);

            for (int var8 = 0; var8 < 45; var8++) {
               this.activateActorRuntimeState(var8 + 226);
            }

            this.activateActorRuntimeState(278);
            this.activateActorRuntimeState(277);
            this.activateActorRuntimeState(280);
            this.deactivateActorRuntimeState(274);
            this.deactivateActorRuntimeState(275);
            this.deactivateActorRuntimeState(276);
            this.deactivateActorRuntimeState(271);
            this.deactivateActorRuntimeState(272);
            this.deactivateActorRuntimeState(273);
            this.gameByteValue28 = 10;
            return;
         }

         if (this.gameByteValue20 == 2) {
            this.updateActorPositions();
            this.deactivateActorRuntimeState(20);

            for (int var7 = 0; var7 < 45; var7++) {
               this.activateActorRuntimeState(var7 + 226);
            }

            this.activateActorRuntimeState(278);
            this.activateActorRuntimeState(277);
            this.activateActorRuntimeState(280);
            this.activateActorRuntimeState(271);
            this.activateActorRuntimeState(272);
            this.activateActorRuntimeState(273);
            this.activateActorRuntimeState(278);
            this.activateActorRuntimeState(277);
            this.activateActorRuntimeState(280);
            this.activateActorRuntimeState(282);
            this.activateActorRuntimeState(283);
            this.activateActorRuntimeState(284);
            this.activateActorRuntimeState(287);
            this.activateActorRuntimeState(286);
            this.activateActorRuntimeState(285);
            this.activateActorRuntimeState(288);
            this.activateActorRuntimeState(289);
            this.activateActorRuntimeState(290);
            this.gameByteValue28 = 3;
            return;
         }

         this.activateActorRuntimeState(20);

         for (int var6 = 0; var6 < 45; var6++) {
            this.deactivateActorRuntimeState(var6 + 226);
         }

         this.deactivateActorRuntimeState(274);
         this.deactivateActorRuntimeState(275);
         this.deactivateActorRuntimeState(276);
         this.deactivateActorRuntimeState(271);
         this.deactivateActorRuntimeState(272);
         this.deactivateActorRuntimeState(273);
         this.deactivateActorRuntimeState(278);
         this.deactivateActorRuntimeState(277);
         this.deactivateActorRuntimeState(280);
         this.deactivateActorRuntimeState(282);
         this.deactivateActorRuntimeState(283);
         this.deactivateActorRuntimeState(284);
         this.deactivateActorRuntimeState(287);
         this.deactivateActorRuntimeState(286);
         this.deactivateActorRuntimeState(285);
         this.deactivateActorRuntimeState(288);
         this.deactivateActorRuntimeState(289);
         this.deactivateActorRuntimeState(290);
      }
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, int, int, int, int, int) void
   public void drawTileLayer(Graphics var1, int var2, int var3, int var4, int var5, int var6) {
      sbyte var8 = 0;
      sbyte var7 = 0;
      sbyte var13 = 0;
      var1.setColor(var13, var7, var8);
      fillRectangle(var1, var2, var3, var4, var5);
      var8 = 72;
      var7 = 81;
      var13 = 77;
      var1.setColor(var13, var7, var8);
      drawRectangleOutline(var1, var2, var3, var4, var5);
      var2--;
      var3--;
      var4 += 2;
      var5 += 2;
      var8 = 86;
      var7 = 78;
      var13 = 8;
      var1.setColor(var13, var7, var8);
      drawLine(var1, var2 + 1, var3, var2 + var4 - 2, var3);
      drawLine(var1, var2 + 1, var3 + var5 - 1, var2 + var4 - 2, var3 + var5 - 1);
      drawLine(var1, var2, var3 + 1, var2, var3 + var5 - 2);
      drawLine(var1, var2 + var4 - 1, var3 + 1, var2 + var4 - 1, var3 + var5 - 2);
   }

   // $VF: renamed from: b (javax.microedition.lcdui.Graphics, int, int, int, int, int) void
   public void drawActorSprite(Graphics var1, int var2, int var3, int var4, int var5, int var6) {
      if (var6 == 3 || var6 == 5) {
         this.setRgbColor(var1, 16777215);
         if ((JSystem.currentTimeMillis() & 64L) != 0L && gameBooleanFlag13) {
            this.setRgbColor(var1, 0);
         }

         fillRectangle(var1, var2 - 2, var3 - 2, var4 + 4, 56);
         this.setRgbColor(var1, 9475467);
         fillRectangle(var1, var2 - 1, var3 - 1, var4 + 2, 54);
      }

      switch (var6) {
         case 2:
            this.setRgbColor(var1, 3816503);
            break;
         case 3:
         case 4:
         case 5:
            this.setRgbColor(var1, 9475467); break;
      }

      fillRectangle(var1, var2, var3, var4, 52);
      switch (var6) {
         case 2:
            this.setRgbColor(var1, 4144954);
            break;
         case 3:
         case 4:
         case 5:
            this.setRgbColor(var1, 9803919); break;
      }

      fillRectangle(var1, var2 + 1, var3 + 52 - 5, var4 - 2, 4);
      fillRectangle(var1, var2 + 1, var3 + 52 - 7, var4 - 2, 1);
      this.setRgbColor(var1, 6655278);
      fillRectangle(var1, var2 + 1, var3, var4 - 2, 1);
      this.setRgbColor(var1, 3558425);
      fillRectangle(var1, var2 + 1, var3 + 52 - 1, var4 - 2, 1);
      this.setRgbColor(var1, 12297634);
      fillRectangle(var1, var2, var3 + 1, 1, 50);
      fillRectangle(var1, var2 + var4 - 1, var3 + 1, 1, 50);
   }

   // $VF: renamed from: a (int, int, int, int, int, int, int, int) boolean
   public static bool rectanglesOverlap(int var0, int var1, int var2, int var3, int var4, int var5, int var6, int var7) {
      return (var4 >= var0 && var4 < var0 + var2 || var4 < var0 && var4 + var6 > var0)
         && (var5 >= var1 && var5 < var1 + var3 || var5 < var1 && var5 + var7 > var1);
   }

   // $VF: renamed from: a (int, int, int, int, int, int) boolean
   public static bool containsPointInBounds(int var0, int var1, int var2, int var3, int var4, int var5) {
      return var0 >= var2 && var0 < var2 + var4 && var1 >= var3 && var1 < var3 + var5;
   }

   // $VF: renamed from: a (int, int) int
   public int getTilePixelX(int var1, int var2) {
      return this.gameIntegerValue52 + (var1 - 1 - var2) * 54;
   }

   // $VF: renamed from: b (int, int) int
   public static int getTilePixelY(int var0, int var1) {
      return (var1 + var0) * 27;
   }

   // $VF: renamed from: c (int, int) int
   public int getTileColumnFromPixel(int var1, int var2) {
      return (var2 - (var1 - this.gameIntegerValue52) / 2) / 54;
   }

   // $VF: renamed from: d (int, int) int
   public int getTileRowFromPixel(int var1, int var2) {
      return (var2 + (var1 - this.gameIntegerValue52) / 2) / 54;
   }

   // $VF: renamed from: c (int, int) void
   public void setCameraPosition(int var1, int var2) {
      this.gameIntegerValue53 = var1;
      this.gameIntegerValue54 = var2;
   }

   // $VF: renamed from: a (p, boolean) void
   public void updateActorDisplayState(ActorState var1, bool var2) {
      if (!gameBooleanFlag29 || var2 || gameIntegerValue50 == 131) {
         this.gameActorStateReference07 = var1;
         int var5 = this.getTilePixelX(var1.byteValue01, var1.byteValue02);
         sbyte var4 = var1.byteValue02;
         sbyte var3 = var1.byteValue01;
         int var6 = (var4 + var3) * 27;
         int var10 = var5 + (54 - gameIntegerValue43);
         int var12 = var6 + (27 - gameIntegerValue44);
         bool var8 = this.isActorNearPosition(var1, 2, 1);
         bool var9 = this.isActorNearPosition(var1, 0, 1);
         if (var1.byteValue05 == 2) {
            var8 = !var8;
            var9 = !var9;
         }

         if (gameByteCube01[var1.byteValue08][var1.byteValue05][2] != 0) {
            if (var8) {
               var10 += var1.integerValue01 * 54 / 65536;
               if (var1.byteValue03 >= gameByteCube01[var1.byteValue08][var1.byteValue05][2]) {
                  var10 -= 54;
               }
            } else {
               var10 -= var1.integerValue01 * 54 / 65536;
               if (var1.byteValue03 >= gameByteCube01[var1.byteValue08][var1.byteValue05][2]) {
                  var10 += 54;
               }
            }

            if (var9) {
               var12 += var1.integerValue01 * 27 / 65536;
               if (var1.byteValue03 >= gameByteCube01[var1.byteValue08][var1.byteValue05][2]) {
                  var12 -= 27;
               }
            } else {
               var12 -= var1.integerValue01 * 27 / 65536;
               if (var1.byteValue03 >= gameByteCube01[var1.byteValue08][var1.byteValue05][2]) {
                  var12 += 27;
               }
            }
         }

         sbyte var7;
         if ((gameIntegerValue50 & 512) == 0 && !this.gameActorGroupReference01.booleanFlag04 && (this.gameBooleanFlag38 || !this.gameBooleanFlag39)) {
            var7 = 10;
         } else {
            var7 = 30;
         }

         if (gameIntegerValue41 < this.gameIntegerValue57) {
            var5 = JMath.max(JMath.min(var10, this.gameIntegerValue55 + this.gameIntegerValue57 - gameIntegerValue41), this.gameIntegerValue55);
         } else {
            var5 = this.gameIntegerValue55 + this.gameIntegerValue57 / 2 - gameIntegerValue43;
         }

         if (gameIntegerValue42 < this.gameIntegerValue58) {
            var6 = JMath.max(JMath.min(var12, this.gameIntegerValue56 + this.gameIntegerValue58 - gameIntegerValue42), this.gameIntegerValue56);
         } else {
            var6 = this.gameIntegerValue56 + this.gameIntegerValue58 / 2 - gameIntegerValue44;
         }

         if (!var2) {
            if (this.gameIntegerValue53 < var5) {
               var5 = this.gameIntegerValue53 + JMath.min(var5 - this.gameIntegerValue53, var7);
            }

            if (this.gameIntegerValue53 > var5) {
               var5 = this.gameIntegerValue53 - JMath.min(this.gameIntegerValue53 - var5, var7);
            }

            if (this.gameIntegerValue54 < var6) {
               var6 = this.gameIntegerValue54 + JMath.min(var6 - this.gameIntegerValue54, var7);
            }

            if (this.gameIntegerValue54 > var6) {
               var6 = this.gameIntegerValue54 - JMath.min(this.gameIntegerValue54 - var6, var7);
            }
         }

         this.setCameraPosition(var5, var6);
      }
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, short, boolean, boolean, int, int) void
   public void drawActorFrame(Graphics var1, short var2, bool var3, bool var4, int var5, int var6) {
      if (var2 != -1) {
         int var4i;
         if (var3) {
            var4i = 0;
         } else {
            var5 += 54;
            var4i = 54;
         }

         int var3i;
         if ((var3i = var2 & 255) != 255) {
            this.drawClippedGameRegion(var1, var3i + 109, var5, var6 - 60, 54, 87, var4i, 0, 0);
         }

         if ((var3i = var2 >> 8 & 0xFF) != 255) {
            this.drawClippedGameRegion(var1, var3i + 109, var5, var6 - 120, 54, 87, var4i, 0, 0);
         }
      }
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, p, int, int) void
   public void drawActorState(Graphics var1, ActorState var2, int var3, int var4) {
      bool var10000;
      
      if ((!gameBooleanFlag52 || gameIntegerValue19 == 24) && (this.gameByteValue04 != 3 || var2.byteValue08 != 1) && gameIntegerValue50 != 131) {
         if (var2.byteValue10 <= 0) {
            if (var2.byteValue08 == 5) {
               var2.integerValue02 = var2.integerValue02 - gameIntegerValue129;
            } else {
               var2.integerValue02 = var2.integerValue02 - gameIntegerValue129;
            }

            if (var2.integerValue02 < 1000 && var2.integerValue02 % 500 > 250) {
               var10000 = true;
               goto label152_brk;
            }

            if (var2.integerValue02 < 0) {
               var2.booleanFlag01 = false;
            }
         }

         var10000 = false;
      } else {
         var10000 = false;
      } label152_brk:;

      if (!var10000) {
         int var5 = gameByteCube01[var2.byteValue08][var2.byteValue05][4];
         bool var6 = var2.byteValue07 > 4;
         if (gameByteCube01[var2.byteValue08][var2.byteValue05][3] == 4) {
            var5 = AnimationTables.integerTensor01[var2.byteValue08][var5][this.isActorNearPosition(var2, 0, 1) ? 0 : 1][var2.byteValue03];
         } else {
            var5 = AnimationTables.integerCube02[var5][var6 ? 8 - var2.byteValue07 : var2.byteValue07][var2.byteValue03];
         }

         sbyte var7 = var2.byteValue08;
         if (var2.byteValue08 == 2) {
            var7 = 2;
            gameSpriteDecoderReferenceArray02[2].setGraphicsTransform(0);
         } else if (var2.byteValue08 == 4) {
            var7 = 2;
            gameSpriteDecoderReferenceArray02[2].setGraphicsTransform(1);
         }

         if (!var6) {
            gameSpriteDecoderReferenceArray02[var7].drawSpriteFrameTransformed(var1, var5, var3, var4, 0, 0, 0);
         } else {
            SpriteResourceDecoder var22 = gameSpriteDecoderReferenceArray02[var7];
            int var10 = var3 + 108;
            var22.drawSpriteFrameTransformed(var1, var5, var10, var4, 1, 0, 0);
         }

         if (var2.byteValue08 == 0 || var2.byteValue08 == 1) {
            ActorGroup var12;
            if (var2.byteValue08 == 0) {
               var12 = this.gameActorGroupReference03;
            } else {
               var12 = this.gameActorGroupReference04;
            }

            if (var5 > 9 && var5 < 22) {
               int var8;
               if (var12.actorStateReference01.byteValue09 == 127 || var12.byteValue04 == 0) {
                  var8 = var5 + 14;
               } else if (var12.byteValue04 == 1 || var12.byteValue04 == 2) {
                  var8 = var5 - 10;
               } else if (var12.byteValue04 != 3 && var12.byteValue04 != 4) {
                  var8 = -1;
               } else {
                  var8 = var5 + 2;
               }

               if (var8 >= 0) {
                  if (!var6) {
                     gameSpriteDecoderReferenceArray03[var2.byteValue08].drawSpriteFrameTransformed(var1, var8, var3, var4, 0, 0, 0);
                  } else {
                     SpriteResourceDecoder var23 = gameSpriteDecoderReferenceArray03[var2.byteValue08];
                     int var17 = var3 + 108;
                     var23.drawSpriteFrameTransformed(var1, var8, var17, var4, 1, 0, 0);
                  }
               }
            }
         }

         if (var2.byteValue09 != 127) {
            int var19 = gameByteCube01[var2.byteValue08][var2.byteValue05][5];
            sbyte var13 = var2.byteValue07;
            if (var19 != 127) {
               bool var21 = var13 > 4;
               if (gameByteCube01[var2.byteValue08][var2.byteValue05][3] == 4) {
                  var19 = AnimationTables.integerCube01[var19][this.isActorNearPosition(var2, 0, 1) ? 0 : 1][var2.byteValue03];
               } else {
                  var19 = AnimationTables.integerCube02[var19][var21 ? 8 - var13 : var13][var2.byteValue03];
               }

               if (var19 != 127) {
                  if (!var21) {
                     gameSpriteDecoderReferenceArray04[var2.byteValue09].drawSpriteFrameTransformed(var1, var19, var3, var4, 0, 0, 0);
                  } else {
                     SpriteResourceDecoder var24 = gameSpriteDecoderReferenceArray04[var2.byteValue09];
                     int var18 = var3 + 108;
                     var24.drawSpriteFrameTransformed(var1, var19, var18, var4, 1, 0, 0);
                  }
               }
            }
         }

         if (!gameClass11Reference02.isAnimationFinished()) {
            gameClass11Reference02.advanceAnimation(gameIntegerValue129);
            gameClass11Reference02.drawCurrentFrame();
         }
      }
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, int, int, int) void
   public void drawLinkedEntities(Graphics var1, int var2, int var3, int var4) {
      int var7 = 0;
      ActorRuntimeState var8;
      int var5 = (var8 = this.gameClass9ReferenceArray01[var2]).byteValue01;
      int var6 = var5 + 9;
      if (this.gameIntegerValue93 == var2) {
         var7 = this.gameIntegerValue95;
      }

      if (this.gameByteValue04 == 1 && this.gameByteValue20 >= 0) {
         if (var5 == 47) {
            var6 = 163 + this.gameByteValue26;
         } else if (var5 == 45) {
            var6 = 175 + this.gameByteValue26;
         } else if (var5 == 48) {
            var6 = 171 + this.gameByteValue26;
         } else if (var5 == 46) {
            var6 = 167 + this.gameByteValue26;
         }
      }

      bool var9 = false;
      if (absoluteValue(var8.byteValue02 - this.gameActorGroupReference01.actorStateReference01.byteValue01) <= 1
         && absoluteValue(var8.byteValue03 - this.gameActorGroupReference01.actorStateReference01.byteValue02) <= 1
         && (var9 = this.restoreEntitySnapshot(this.gameActorGroupReference01.byteValue02, var2, false))
         && var8.byteValue04 <= 0
         && (gameIntegerValue123 == 1 || gameIntegerValue123 == 2)) {
         gameBooleanFlag58 = true;
      }

      int var10005 = this.gameShortMatrix03[var5][2] * 3 / 2;
      int var10006 = (this.gameShortMatrix03[var5][3] + var7) * 3 / 2;
      short var10007 = this.gameShortMatrix03[var5][0];
      short var10008 = this.gameShortMatrix03[var5][1];
      bool var15 = var8.booleanFlag04;
      sbyte var14 = 0;
      bool var18 = false;
      bool var19 = false;
      short var13 = var10008;
      short var12 = var10007;
      int var11 = var10006;
      int var10 = var10005;
      if (this.gameBooleanArray02[var6] != var15) {
         this.gameBooleanArray02[var6] = !this.gameBooleanArray02[var6];
      }

      int var6x;
      if (!var15) {
         var6x = var3 + var10;
         var7 = var4 + var11;
      } else {
         var6x = var3 + 108 - var10 - var12 + 1;
         var7 = var4 + var11;
      }

      if (var15) {
         var14 = 1;
      }

      this.drawClippedGameRegion(var1, var6, var6x, var7, var12 + 1, var13, 0, 0, var14);

      for (int var21 = 0; var21 < var8.byteValue04; var21++) {
         if (var8.actorFlagsReferenceArray01[var21].booleanFlag01) {
            var2 = var3 + var8.actorFlagsReferenceArray01[var21].byteValue02 * 3 / 2;
            var5 = var4 + var8.actorFlagsReferenceArray01[var21].byteValue03 * 3 / 2;
            if (!var8.actorFlagsReferenceArray01[var21].booleanFlag02) {
               SpriteResourceDecoder var35 = gameSpriteDecoderReferenceArray06[2];
               sbyte var32 = var8.actorFlagsReferenceArray01[var21].byteValue01;
               var35.drawSpriteFrameTransformed(var1, var32, var2, var5, 0, 0, 0);
            } else {
               var6 = gameSpriteDecoderReferenceArray06[2].getSpriteWidth(var8.actorFlagsReferenceArray01[var21].byteValue01);
               SpriteResourceDecoder var36 = gameSpriteDecoderReferenceArray06[2];
               var11 = var2 + var6;
               sbyte var33 = var8.actorFlagsReferenceArray01[var21].byteValue01;
               var36.drawSpriteFrameTransformed(var1, var33, var11, var5, 1, 0, 0);
            }

            if (var9) {
               var6 = gameSpriteDecoderReferenceArray06[2].getSpriteWidth(var8.actorFlagsReferenceArray01[var21].byteValue01);
               int var26 = var2 + (var6 >> 1);
               SpriteAnimation var23 = gameClass11Reference04;
               gameClass11Reference04.drawX = var26;
               var23.drawY = var5;
               gameClass11Reference04.drawCurrentFrame();
            }
         }
      }
   }

   // $VF: renamed from: c (int, int, int, int) void
   public void processActorCollisions(int var1, int var2, int var3, int var4) {
      int var5 = -1;

      for (int var6 = 0; var6 < this.gameShortValue02; var6++) {
         if (this.gameByteArray01[var6] == 0) {
            if (containsPointInBounds(this.gameClass9ReferenceArray01[this.gameShortArray02[var6]].byteValue02, this.gameClass9ReferenceArray01[this.gameShortArray02[var6]].byteValue03, 0, 0, var3, var4)) {
               var5 = -1;
            } else if (var5 == -1) {
               var5 = var6;
            }
         } else if (this.gameByteArray01[var6] == 1) {
            if (containsPointInBounds(this.gameActorStateReferenceArray01[this.gameShortArray02[var6]].byteValue01, this.gameActorStateReferenceArray01[this.gameShortArray02[var6]].byteValue02, 0, 0, var3, var4)) {
               var5 = -1;
            } else if (var5 == -1) {
               var5 = var6;
            }
         } else if (this.gameByteArray01[var6] == 2) {
            if ((var1 != 2 || this.gameClass22ReferenceArray01[var2].entityFrameDataReference01.shortValue02 < this.gameClass22ReferenceArray01[this.gameShortArray02[var6]].entityFrameDataReference01.shortValue02)
               && !containsPointInBounds(
                  this.gameClass22ReferenceArray01[this.gameShortArray02[var6]].entityFrameDataReference01.byteValue02, this.gameClass22ReferenceArray01[this.gameShortArray02[var6]].entityFrameDataReference01.byteValue02, 0, 0, var3, var4
               )) {
               if (var5 == -1) {
                  var5 = var6;
               }
            } else {
               var5 = -1;
            }
         } else if (this.gameByteArray01[var6] == 3) {
            if ((var1 != 3 || this.gameEntityFrameDataReferenceArray01[var2].shortValue02 < this.gameEntityFrameDataReferenceArray01[this.gameShortArray02[var6]].shortValue02)
               && !containsPointInBounds(this.gameEntityFrameDataReferenceArray01[this.gameShortArray02[var6]].byteValue02, this.gameEntityFrameDataReferenceArray01[this.gameShortArray02[var6]].byteValue03, 0, 0, var3, var4)) {
               if (var5 == -1) {
                  var5 = var6;
               }
            } else {
               var5 = -1;
            }
         } else if (this.gameByteArray01[var6] == 4) {
            if (this.gameActorStateReferenceArray01[this.gameShortArray02[var6]].byteValue07 == 7) {
               if (containsPointInBounds(
                  this.gameActorStateReferenceArray01[this.gameShortArray02[var6]].byteValue01,
                  this.gameActorStateReferenceArray01[this.gameShortArray02[var6]].byteValue02 - AnimationTables.integerMatrix01[this.gameActorStateReferenceArray01[this.gameShortArray02[var6]].byteValue08][1] + 1,
                  0,
                  0,
                  var3,
                  var4
               )) {
                  var5 = -1;
               } else if (var5 == -1) {
                  var5 = var6;
               }
            } else if (this.gameActorStateReferenceArray01[this.gameShortArray02[var6]].byteValue07 == 1) {
               if (containsPointInBounds(
                  this.gameActorStateReferenceArray01[this.gameShortArray02[var6]].byteValue01 - AnimationTables.integerMatrix01[this.gameActorStateReferenceArray01[this.gameShortArray02[var6]].byteValue08][1] + 1,
                  this.gameActorStateReferenceArray01[this.gameShortArray02[var6]].byteValue02,
                  0,
                  0,
                  var3,
                  var4
               )) {
                  var5 = -1;
               } else if (var5 == -1) {
                  var5 = var6;
               }
            } else if (containsPointInBounds(this.gameActorStateReferenceArray01[this.gameShortArray02[var6]].byteValue01, this.gameActorStateReferenceArray01[this.gameShortArray02[var6]].byteValue02, 0, 0, var3, var4)) {
               var5 = -1;
            } else if (var5 == -1) {
               var5 = var6;
            }
         }
      }

      if (var5 == -1) {
         this.gameShortArray02[this.gameShortValue02] = (short)var2;
         this.gameByteArray01[this.gameShortValue02] = (sbyte)var1;
      } else {
         for (int var7 = this.gameShortValue02; var7 > var5; var7--) {
            this.gameShortArray02[var7] = this.gameShortArray02[var7 - 1];
            this.gameByteArray01[var7] = this.gameByteArray01[var7 - 1];
         }

         this.gameShortArray02[var5] = (short)var2;
         this.gameByteArray01[var5] = (sbyte)var1;
      }

      this.gameShortValue02++;
   }

   // $VF: renamed from: c (javax.microedition.lcdui.Graphics) void
   public void drawActors(Graphics var1) {
      int var2 = 0;
      int var4 = 0;
      int var3 = 0;
      if (this.gameIntegerValue90 != 0) {
         if (this.gameIntegerValue90 > 0 && this.gameIntegerValue90 < 20) {
            var2 = this.gameActorGroupReference01.actorStateReference01.byteValue07 > 4 ? 1 : 0;
            var3 = this.getTilePixelX(this.gameActorGroupReference01.actorStateReference01.byteValue01, this.gameActorGroupReference01.actorStateReference01.byteValue02) - this.gameIntegerValue53;
            sbyte var51 = this.gameActorGroupReference01.actorStateReference01.byteValue02;
            sbyte var21 = this.gameActorGroupReference01.actorStateReference01.byteValue01;
            var4 = (var51 + var21) * 27 - this.gameIntegerValue54;
         } else if (this.gameIntegerValue90 > 19 && this.gameIntegerValue90 < 26) {
            var3 = this.getTilePixelX(50, 23) - this.gameIntegerValue53;
            sbyte var50 = 23;
            sbyte var20 = 50;
            var4 = (var50 + var20) * 27 - this.gameIntegerValue54 + this.gameByteValue15;
         } else if (this.gameIntegerValue90 > 29 && this.gameIntegerValue90 < 34) {
            var2 = 0;
            var3 = this.getTilePixelX(53, 30) - this.gameIntegerValue53;
            sbyte var49 = 30;
            sbyte var19 = 53;
            var4 = (var49 + var19) * 27 - this.gameIntegerValue54 + this.gameByteValue15;
         } else if (this.gameIntegerValue90 >= 35 && this.gameIntegerValue90 <= 38) {
            var2 = 0;
            var3 = this.getTilePixelX(36, 17) - this.gameIntegerValue53;
            sbyte var48 = 17;
            sbyte var18 = 36;
            var4 = (var48 + var18) * 27 - this.gameIntegerValue54 + this.gameByteValue15;
         } else if (this.gameIntegerValue90 >= 39 && this.gameIntegerValue90 <= 42) {
            var2 = 0;
            var3 = this.getTilePixelX(36, 17) - this.gameIntegerValue53;
            sbyte var5 = 17;
            sbyte var17 = 36;
            var4 = (var5 + var17) * 27 - this.gameIntegerValue54 + this.gameByteValue15;
         }

         switch (this.gameIntegerValue90) {
            case 1:
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
               if (var2 == 0) {
                  SpriteResourceDecoder var60 = gameSpriteDecoderReferenceArray02[this.gameActorGroupReference01.actorStateReference01.byteValue08];
                  int var64 = 51 + (this.gameIntegerValue90 - 1);
                  int var56 = var4 + this.gameByteValue15;
                  var4 = var64;
                  var60.drawSpriteFrameTransformed(var1, var4, var3, var56, 0, 0, 0);
               } else {
                  SpriteResourceDecoder var61 = gameSpriteDecoderReferenceArray02[this.gameActorGroupReference01.actorStateReference01.byteValue08];
                  int var65 = 51 + (this.gameIntegerValue90 - 1);
                  int var66 = var3 + 108;
                  int var57 = var4 + this.gameByteValue15;
                  int var54 = var66;
                  var4 = var65;
                  var61.drawSpriteFrameTransformed(var1, var4, var54, var57, 1, 0, 0);
               }

               try {
                  if (this.gameActorGroupReference02.byteValue05 == this.gameActorGroupReference01.byteValue05) {
                     ActorState var13 = this.gameActorGroupReference02.actorStateReference01;
                     ActorState var46 = this.gameActorGroupReference01.actorStateReference01;
                     if (this.gameByteMatrix02[var13.byteValue01][var13.byteValue02] == this.gameByteMatrix02[var46.byteValue01][var46.byteValue02]
                        && var13.byteValue01 > var46.byteValue01) {
                        int var67 = this.getTilePixelX(var13.byteValue01, var13.byteValue02) - this.gameIntegerValue53;
                        sbyte var55 = var13.byteValue02;
                        sbyte var47 = var13.byteValue01;
                        this.drawActorState(var1, var13, var67, (var55 + var47) * 27 - this.gameIntegerValue54);
                     }
                  }

                  return;
               } catch (System.Exception var7) {
                  return;
               } goto case 13;
            case 13:
            case 14:
            case 15:
            case 16:
            case 17:
            case 18:
            case 19:
               if (var2 == 0) {
                  SpriteResourceDecoder var59 = gameSpriteDecoderReferenceArray02[this.gameActorGroupReference01.actorStateReference01.byteValue08];
                  int var63 = 63 + (this.gameIntegerValue90 - 13);
                  var4 += this.gameByteValue15;
                  var2 = var63;
                  var59.drawSpriteFrameTransformed(var1, var2, var3, var4, 0, 0, 0);
                  return;
               }

               SpriteResourceDecoder var58 = gameSpriteDecoderReferenceArray02[this.gameActorGroupReference01.actorStateReference01.byteValue08];
               int var62 = 63 + (this.gameIntegerValue90 - 13);
               int var10003 = var3 + 108;
               var4 += this.gameByteValue15;
               var3 = var10003;
               var2 = var62;
               var58.drawSpriteFrameTransformed(var1, var2, var3, var4, 1, 0, 0);
               return;
            case 20:
            case 21:
            case 22:
            case 23:
            case 24:
            case 25:
               SpriteResourceDecoder var10000 = gameSpriteDecoderReferenceArray07[0];
               int var39 = 0 + (this.gameIntegerValue90 - 20);
               var10000.drawSpriteFrameTransformed(var1, var39, var3, var4, 0, 0, 0);
               var3 = this.getTilePixelX(this.gameClass9ReferenceArray01[162].byteValue02, this.gameClass9ReferenceArray01[162].byteValue03) - this.gameIntegerValue53;
               sbyte var53 = this.gameClass9ReferenceArray01[162].byteValue03;
               int var40 = this.gameClass9ReferenceArray01[162].byteValue02;
               var40 = (var53 + var40) * 27 - this.gameIntegerValue54;
               this.drawLinkedEntities(var1, 162, var3, var40 + this.gameByteValue15);
               return;
            case 26:
            case 27:
            case 28:
            case 29:
            case 43:
            case 44:
            case 46:
            case 47:
            case 48:
            case 49:
            default:
               break;
            case 30:
            case 39:
               gameBooleanFlag27 = false; goto case 31;
            case 31:
            case 32:
            case 33:
            case 34:
            case 40:
            case 41:
            case 42:
               if (!gameBooleanFlag27) {
                  if (gameIntegerValue40 < 320) {
                     gameIntegerValue40 += 80;
                  } else {
                     gameIntegerValue40 = 320;
                     gameBooleanFlag27 = true;
                  }

                  gameSpriteDecoderReferenceArray02[3].drawSpriteFrameTransformed(var1, 18, var3, var4, 0, 0, 0);
                  return;
               }

               if (gameIntegerValue40 > 0) {
                  gameIntegerValue40 -= 80;
                  return;
               }

               gameIntegerValue40 = 0;
               return;
            case 35:
               gameBooleanFlag27 = false; goto case 36;
            case 36:
            case 37:
            case 38:
               if (!gameBooleanFlag27) {
                  if (gameIntegerValue40 < 320) {
                     gameIntegerValue40 += 80;
                     return;
                  }

                  gameIntegerValue40 = 320;
                  gameBooleanFlag27 = true;
                  return;
               }

               if (gameIntegerValue40 > 0) {
                  gameIntegerValue40 -= 80;
               } else {
                  gameIntegerValue40 = 0;
               }

               gameSpriteDecoderReferenceArray02[3].drawSpriteFrameTransformed(var1, 18, var3, var4, 0, 0, 0);
               return;
            case 45:
               int var10001 = this.getTilePixelX(this.gameActorGroupReference01.actorStateReference01.byteValue01, this.gameActorGroupReference01.actorStateReference01.byteValue02) - gameIntegerValue43 / 2;
               sbyte var52 = this.gameActorGroupReference01.actorStateReference01.byteValue02;
               sbyte var38 = this.gameActorGroupReference01.actorStateReference01.byteValue01;
               this.setCameraPosition(var10001, (var52 + var38) * 27 - gameIntegerValue44 / 2);
               return;
            case 50:
            case 51:
            case 52:
            case 53:
               this.setRgbColor(var1, 0);
               setGraphicsClip(var1, 0, 0, gameIntegerValue41, gameIntegerValue42);
               fillRectangle(var1, 0, 0, gameIntegerValue41, gameIntegerValue42);
               this.setRgbColor(var1, 16777215);
               short var23 = 304;
               drawCenteredText(var1, getStringResource(304), 0, 180, UiLayoutPresetE.integerValue01, 0, 0, gameIntegerValue41, gameIntegerValue42, 36);
               var23 = 314;
               drawCenteredText(var1, getStringResource(314), 0, UiLayoutPresetE.integerValue02, UiLayoutPresetE.integerValue03, 0, 0, gameIntegerValue41, gameIntegerValue42, 20);
               StringBuffer var8;
               (var8 = new StringBuffer(128)).append("");
               var8.append(this.gameShortValue15 > 0 ? this.gameShortValue15 : 0);
               var8.append(":");
               if (this.gameShortValue16 < 10) {
                  var8.append("0");
               }

               var8.append(this.gameShortValue16 > 0 ? this.gameShortValue16 : 0);
               var8.append(":");
               if (this.gameIntegerValue96 / 1000 < 10) {
                  var8.append("0");
               }

               var8.append(this.gameIntegerValue96 > 0 ? this.gameIntegerValue96 / 1000 : 0);
               drawCenteredText(var1, var8.toString(), 0, UiLayoutPresetE.integerValue04, UiLayoutPresetE.integerValue05, 0, 0, gameIntegerValue41, gameIntegerValue42, 68);
               if (this.gameIntegerValue90 > 50) {
                  string var26;
                  if ((var3 = this.gameShortValue15 * 60 * 60 + this.gameShortValue16 * 60 + this.gameIntegerValue96 / 1000) < 3600) {
                     var23 = 308;
                     var26 = getStringResource(308);
                  } else if (var3 < 7800) {
                     var23 = 305;
                     var26 = getStringResource(305);
                  } else if (var3 < 10300) {
                     var23 = 306;
                     var26 = getStringResource(306);
                  } else {
                     var23 = 307;
                     var26 = getStringResource(307);
                  }

                  drawCenteredText(var1, var26, 0, UiLayoutPresetE.integerValue06, UiLayoutPresetE.integerValue07, 0, 0, gameIntegerValue41, gameIntegerValue42, 68);
               }

               if (this.gameIntegerValue90 > 51) {
                  if (this.gameIntegerValue97 != 0) {
                     var3 = this.gameIntegerValue98 * 100 / this.gameIntegerValue97;
                  } else {
                     var3 = 100;
                  }

                  var23 = 309;
                  drawCenteredText(var1, getStringResource(309), 0, UiLayoutPresetE.integerValue08, UiLayoutPresetE.integerValue09, 0, 0, gameIntegerValue41, gameIntegerValue42, 20);
                  StringBuffer var9;
                  (var9 = new StringBuffer(128)).append("");
                  var9.append(var3);
                  var23 = 310;
                  var9.append(getStringResource(310));
                  drawCenteredText(var1, var9.toString(), 0, UiLayoutPresetE.integerValue10, UiLayoutPresetE.integerValue11, 0, 0, gameIntegerValue41, gameIntegerValue42, 68);
               }

               if (this.gameIntegerValue90 > 52) {
                  StringBuffer var10 = new StringBuffer(128);
                  if (var3 > 97) {
                     var23 = 308;
                     var10.append(getStringResource(308));
                  } else if (var3 > 95) {
                     var23 = 305;
                     var10.append(getStringResource(305));
                  } else if (var3 > 85) {
                     var23 = 306;
                     var10.append(getStringResource(306));
                  } else {
                     var23 = 307;
                     var10.append(getStringResource(307));
                  }

                  if (this.gameIntegerValue97 < 90) {
                     var23 = 311;
                     var10.append(getStringResource(311));
                  }

                  if (this.gameIntegerValue98 != 0) {
                     var3 = this.gameIntegerValue100 * 100 / this.gameIntegerValue98;
                  } else {
                     var3 = 0;
                  }

                  if (var3 > 90) {
                     var23 = 312;
                     var10.append(getStringResource(312));
                  }

                  drawCenteredText(var1, var10.toString(), 0, UiLayoutPresetE.integerValue12, UiLayoutPresetE.integerValue13, 0, 0, gameIntegerValue41, gameIntegerValue42, 68);
                  this.drawBlinkingIndicator(gameGraphicsReference02, 560);
                  return;
               }
               break;
            case 54:
               this.setRgbColor(var1, 0);
               fillRectangle(var1, 0, 0, gameIntegerValue41, gameIntegerValue42);
               this.setRgbColor(var1, 16777215);
               short var22 = 313;
               drawCenteredText(var1, getStringResource(313), 0, gameIntegerValue43, gameIntegerValue44 - AnimationTables.byteArray02[0] / 2, 0, 0, gameIntegerValue41, gameIntegerValue42, 36); break;
         }
      }
   }

   // $VF: renamed from: e (int, int) int
   public int scaleFixedPointValue(int var1, int var2) {
      int var10000 = var1 * this.gameIntegerValue46 >> 6;
      var1 = 65536 / var2 + 1;
      bool var3 = true;
      int var4 = var10000;
      return 1 > var4 ? 1 : (var4 > var1 ? var1 : var4);
   }

   // $VF: renamed from: I () void
   public void updateWorldActors() {
      if (!gameBooleanFlag29) {
         for (int var2 = 0; var2 < 25; var2++) {
            ActorState var1;
            if ((var1 = this.gameActorStateReferenceArray01[var2]).booleanFlag01
               && !var1.booleanFlag03
               && (this.gameByteValue05 == this.gameByteMatrix02[var1.byteValue01][var1.byteValue02] || isActorAlive(var1))) {
               var1.booleanFlag02 = false;
               sbyte[] var4;
               if ((var4 = gameByteCube01[var1.byteValue08][var1.byteValue05])[1] != 0) {
                  if (var1.byteValue08 == 5) {
                     if (var1.byteValue05 == 1) {
                        if (var1.byteValue03 == 2 || var1.byteValue03 == 5) {
                           this.gameIntegerValue83 = 100;
                        }
                     } else if (var1.byteValue05 == 2) {
                        if (var1.byteValue03 == 0 || var1.byteValue03 == 3) {
                           this.gameIntegerValue83 = 100;
                        }
                     } else if (var1.byteValue05 == 6
                        && var1.byteValue03 > 3
                        && var1.byteValue03 < 8
                        && var1.byteValue04 != var1.byteValue03
                        && this.isTileBlocked(var1.byteValue01, var1.byteValue02, var1.byteValue07, true)) {
                        this.updateActorState(var1, var1.byteValue07);
                     }
                  }

                  if (var1 == this.gameActorGroupReference01.actorStateReference01 && isGameInputPressed(2) && var1.byteValue05 == 1) {
                     var1.integerValue01 = var1.integerValue01 + this.scaleFixedPointValue(25344, var4[0]);
                  } else {
                     var1.integerValue01 = var1.integerValue01 + this.scaleFixedPointValue(var4[1] << 8, var4[0]);
                  }

                  
                  if (var1.integerValue01 >= 65534) {
                     var1.integerValue01 = 0;
                     var1.booleanFlag02 = true;
                     if (var4[2] == var4[0]) {
                        if (this.findActorGroupAtTile(var2, var1.byteValue01, var1.byteValue02, var1.byteValue07, false) != -1) {
                           if (var1.byteValue08 != 11 && var1.byteValue08 != 8) {
                              this.faceActorTowardPosition(var1, 0);
                           } else {
                              this.updateActorState(var1, var1.byteValue07);
                           }
                        } else if (var1.byteValue08 != 2
                           && var1.byteValue08 != 4
                           && var1.byteValue08 != 6
                           && var1.byteValue08 != 0
                           && var1.byteValue08 != 1
                           && var1.byteValue08 != 3) {
                           this.updateActorState(var1, var1.byteValue07);
                        } else if (this.findActorGroupAtTile(var2, var1.byteValue01, var1.byteValue02, var1.byteValue07, true) != -1) {
                           this.faceActorTowardPosition(var1, 0);
                        } else {
                           this.updateActorState(var1, var1.byteValue07);
                        }
                     }

                     if (this.hasActorStateChanged(var1)) {
                        var1.byteValue12 = -1;
                        var1.byteValue13 = -1;
                     }

                     
                     switch (var1.byteValue08) {
                        case 0:
                        case 1:
                           switch (var1.byteValue05) {
                              case 1:
                              case 12:
                              case 13:
                                 if (this.gameActorGroupReference01.booleanFlag01) {
                                    setActorFacingDirection(this.gameActorGroupReference01.actorStateReference01, this.gameActorGroupReference01.actorStateReference01.byteValue07 + 2);
                                    this.faceActorTowardPosition(this.gameActorGroupReference01.actorStateReference01, 0);
                                    this.gameActorGroupReference01.booleanFlag01 = false;
                                    goto label218_brk;
                                 }

                                 if (this.gameActorGroupReference01.booleanFlag02) {
                                    setActorFacingDirection(this.gameActorGroupReference01.actorStateReference01, this.gameActorGroupReference01.actorStateReference01.byteValue07 - 2);
                                    this.faceActorTowardPosition(this.gameActorGroupReference01.actorStateReference01, 0);
                                    this.gameActorGroupReference01.booleanFlag02 = false;
                                    goto label218_brk;
                                 }

                                 if (this.gameActorGroupReference01.booleanFlag03) {
                                    setActorFacingDirection(this.gameActorGroupReference01.actorStateReference01, this.gameActorGroupReference01.actorStateReference01.byteValue07 + 4);
                                    this.faceActorTowardPosition(this.gameActorGroupReference01.actorStateReference01, 0);
                                    this.gameActorGroupReference01.booleanFlag03 = false;
                                    goto label218_brk;
                                 }

                                 if (!this.hasActorStateChanged(var1)) {
                                    this.faceActorTowardPosition(var1, 1);
                                    goto label218_brk;
                                 }
                                 goto label225_brk;
                              case 2:
                              case 8:
                              case 9:
                              case 10:
                              case 11:
                              default:
                                 if (var1.longValue01 == this.gameLongValue06) {
                                    goto label218_brk;
                                 }
                                 goto label225_brk;
                              case 3:
                                 if ((gameIntegerValue50 & 512) != 0) {
                                    gameIntegerValue50 = 900;
                                 }

                                 this.faceActorTowardPosition(var1, 4);
                                 goto label218_brk;
                              case 4:
                                 return;
                              case 5:
                              case 6:
                              case 7:
                                 this.faceActorTowardPosition(var1, 0);
                                 this.updateActorGroupState(false);
                                 goto label218_brk;
                           } goto case 2;
                        case 2:
                        case 4:
                           switch (var1.byteValue05) {
                              case 0:
                                 goto label218_brk;
                              case 1:
                                 if (this.gameByteValue09 != 2 && this.hasActorStateChanged(var1)) {
                                    this.faceActorTowardPosition(var1, 0);
                                    goto label218_brk;
                                 }

                                 this.faceActorTowardPosition(var1, 1);
                                 goto label218_brk;
                              case 2:
                              default:
                                 this.faceActorTowardPosition(var1, 1);
                                 goto label218_brk;
                              case 3:
                              case 4:
                                 this.faceActorTowardPosition(var1, 4);
                                 this.updateActorGroupState(false);
                                 goto label218_brk;
                              case 5:
                                 this.faceActorTowardPosition(var1, 0);
                                 this.updateActorGroupState(false);
                                 goto label218_brk;
                           } goto case 3;
                        case 3:
                        case 7:
                           switch (var1.byteValue05) {
                              case 1:
                                 if (!this.hasActorStateChanged(var1)) {
                                    this.faceActorTowardPosition(var1, 1);
                                    goto label218_brk;
                                 } goto case 5;
                              case 5:
                                 this.faceActorTowardPosition(var1, 0); goto case 2;
                              case 2:
                              default:
                                 goto label218_brk;
                              case 3:
                              case 4:
                                 this.faceActorTowardPosition(var1, 4);
                                 goto label218_brk;
                           } goto case 5;
                        case 5:
                        case 6:
                        case 8:
                           switch (var1.byteValue05) {
                              case 0:
                                 goto label218_brk;
                              case 1:
                                 if (this.gameByteValue09 != 2 && this.hasActorStateChanged(var1)) {
                                    this.faceActorTowardPosition(var1, 0);
                                    goto label218_brk;
                                 }

                                 this.faceActorTowardPosition(var1, 1);
                                 goto label218_brk;
                              case 2:
                              case 5:
                              case 6:
                              case 14:
                                 this.faceActorTowardPosition(var1, 0);
                                 this.updateActorGroupState(false);
                                 goto label218_brk;
                              case 3:
                              case 4:
                                 this.faceActorTowardPosition(var1, 4);
                                 this.updateActorGroupState(false);
                                 goto label218_brk;
                              case 7:
                              case 8:
                              case 9:
                              case 10:
                              case 11:
                              case 12:
                              case 13:
                              default:
                                 this.faceActorTowardPosition(var1, 1);
                                 goto label218_brk;
                           } goto case 9;
                        case 9:
                        case 10:
                           switch (var1.byteValue05) {
                              case 0:
                                 goto label218_brk;
                              case 1:
                              case 2:
                              default:
                                 goto label225_brk;
                              case 3:
                              case 4:
                                 this.faceActorTowardPosition(var1, 4);
                                 this.updateActorGroupState(false);
                                 goto label218_brk;
                              case 5:
                                 this.faceActorTowardPosition(var1, 0);
                                 this.updateActorGroupState(false);
                                 goto label218_brk;
                           } goto case 11;
                        case 11:
                           switch (var1.byteValue05) {
                              case 0:
                                 this.faceActorTowardPosition(var1, 1);
                                 this.updateActorGroupState(false);
                                 goto label218_brk;
                              case 1:
                                 if (this.gameByteValue09 != 2 && this.hasActorStateChanged(var1)) {
                                    this.faceActorTowardPosition(var1, 0);
                                    goto label218_brk;
                                 }

                                 this.faceActorTowardPosition(var1, 1);
                                 goto label218_brk;
                              case 2:
                              default:
                                 this.faceActorTowardPosition(var1, 1);
                                 goto label218_brk;
                              case 3:
                                 for (int var3 = 0; var3 < 25; var3++) {
                                    ActorState var5;
                                    if ((var5 = this.gameActorStateReferenceArray01[var3]).byteValue08 == var1.byteValue08
                                       && var5.byteValue01 == var1.byteValue01
                                       && var5.byteValue02 == var1.byteValue02
                                       && var5.byteValue07 == var1.byteValue07
                                       && var5.byteValue05 == 4
                                       && var5 != var1) {
                                       var1.byteValue07 = (sbyte)(var1.byteValue07 + 2);
                                       if (var1.byteValue07 > 7) {
                                          var1.byteValue07 = 1;
                                       }
                                    }
                                 } goto case 4;
                              case 4:
                                 this.faceActorTowardPosition(var1, 4);
                                 this.updateActorGroupState(false);
                                 goto label218_brk;
                              case 5:
                                 this.faceActorTowardPosition(var1, 1);
                                 this.updateActorGroupState(false); break;
                           } goto default;
                        default:
                           goto label218_brk;
                     } label225_brk:;

                     this.faceActorTowardPosition(var1, 0);
                  } label218_brk:;

                  if (var4[2] != 0) {
                     var1.longValue01 = this.gameLongValue06;
                  }

                  var1.byteValue04 = var1.byteValue03;
                  var1.byteValue03 = (sbyte)(var1.integerValue01 * var4[0] >> 16);
               }
            }
         }

         for (int var6 = 0; var6 < 5; var6++) {
            EntityFrameData var8;
            if ((var8 = this.gameEntityFrameDataReferenceArray01[var6]).booleanFlag01 && !var8.booleanFlag02) {
               var8.integerValue01 = var8.integerValue01 + this.scaleFixedPointValue(gameIntegerMatrix01[var8.byteValue01][1] << 8, gameIntegerMatrix01[var8.byteValue01][0]);
               var8.byteValue04 = (sbyte)(var8.integerValue01 * gameIntegerMatrix01[var8.byteValue01][0] >> 16);
               if (var8.integerValue01 >= 65534) {
                  var8.booleanFlag01 = false;
               }
            }
         }

         if (gameIntegerValue50 != 646 && gameIntegerValue50 != 647) {
            for (int var7 = 0; var7 < 10; var7++) {
               TimedEntityEffect var9;
               if ((var9 = this.gameClass22ReferenceArray01[var7]).booleanFlag01 && !var9.entityFrameDataReference01.booleanFlag02) {
                  var9.entityFrameDataReference01.integerValue01 = var9.entityFrameDataReference01.integerValue01
                     + this.scaleFixedPointValue(gameIntegerMatrix01[var9.entityFrameDataReference01.byteValue01][1] << 8, gameIntegerMatrix01[var9.entityFrameDataReference01.byteValue01][0]);
                  var9.entityFrameDataReference01.byteValue04 = (sbyte)(var9.entityFrameDataReference01.integerValue01 * gameIntegerMatrix01[var9.entityFrameDataReference01.byteValue01][0] >> 16);
                  if (var9.entityFrameDataReference01.integerValue01 >= 65534) {
                     var9.entityFrameDataReference01.integerValue01 = 0;
                     var9.entityFrameDataReference01.byteValue04 = 0;
                  }
               }
            }
         }

         if (this.gameByteValue27 == 0) {
            this.gameByteValue26 = (sbyte)(this.gameByteValue26 + 1 & 3);
            this.gameByteValue27 = this.gameByteValue28;
         }

         this.gameByteValue27--;
         gameClass11Reference04.advanceAnimation(gameIntegerValue129);
      }
   }

   // $VF: renamed from: J () void
   public void updateWorldEntities() {
      if (!gameBooleanFlag29) {
         for (int var1 = 0; var1 < 25; var1++) {
            if (this.gameActorStateReferenceArray01[var1].booleanFlag01) {
               this.gameActorStateReferenceArray01[var1].booleanFlag03 = false;
            }
         }

         for (int var2 = 0; var2 < 5; var2++) {
            if (this.gameEntityFrameDataReferenceArray01[var2].booleanFlag01) {
               this.gameEntityFrameDataReferenceArray01[var2].booleanFlag02 = false;
            }
         }

         for (int var3 = 0; var3 < 10; var3++) {
            if (this.gameClass22ReferenceArray01[var3].booleanFlag01) {
               this.gameClass22ReferenceArray01[var3].entityFrameDataReference01.booleanFlag02 = false;
            }
         }
      }
   }

   // $VF: renamed from: a (p, int) void
   public void faceActorTowardPosition(ActorState var1, int var2) {
      if (this.gameActorGroupReference01.actorStateReference01.byteValue10 > 0 || var2 != 5) {
         if (gameByteCube01[var1.byteValue08][var2][0] == 0) {
            var2 = 1;
         }

         if ((gameIntegerValue50 & 512) != 0 || var1.byteValue08 == 0 && this.gameActorGroupReference03.booleanFlag04 || var1.byteValue08 == 1 && this.gameActorGroupReference04.booleanFlag04) {
            if (var2 == 0 && gameByteCube01[var1.byteValue08].Length >= 8 && gameByteCube01[var1.byteValue08][8][0] != 0) {
               var2 = 8;
            }

            if (var2 == 1 && gameByteCube01[var1.byteValue08].Length >= 12 && gameByteCube01[var1.byteValue08][12][0] != 0) {
               var2 = 12;
            }

            if (var2 == 12 && var1.byteValue05 == 12) {
               var2 = 13;
            }

            if ((var1.byteValue08 == 0 || var1.byteValue08 == 1) && var1.byteValue09 != 127) {
               if (var2 == 8 && (this.gameActorGroupReference01.byteValue04 == 1 || this.gameActorGroupReference01.byteValue04 == 2)) {
                  var2 = 9;
               }

               if (var2 == 8 && (this.gameActorGroupReference01.byteValue04 == 3 || this.gameActorGroupReference01.byteValue04 == 4)) {
                  var2 = 10;
               }

               if (var2 == 8 && this.gameActorGroupReference01.byteValue04 == 0) {
                  var2 = 11;
               }

               if (var2 == 5 && (this.gameActorGroupReference01.byteValue04 == 3 || this.gameActorGroupReference01.byteValue04 == 4)) {
                  var2 = 6;
               }
            }

            if ((var1.byteValue08 == 0 || var1.byteValue08 == 1) && var1.byteValue09 == 127 && var2 == 8 && this.gameActorGroupReference01.byteValue04 == 0) {
               var2 = 11;
            }
         }

         var1.byteValue05 = (sbyte)var2;
         var1.integerValue01 = 0;
         var1.byteValue03 = 0;
         var1.booleanFlag02 = true;
         var1.booleanFlag03 = true;
         var1.longValue01 = this.gameLongValue06;
         if (var2 == 5 || var2 == 6 || var2 == 7 || var2 == 14) {
            var1.longValue02 = this.gameLongValue06;
         }

         if (gameByteCube01[var1.byteValue08][var1.byteValue05][2] != 0 && var1.byteValue07 % 2 == 0) {
            setActorFacingDirection(var1, var1.byteValue07 + 1);
         }

         if (isActorActionType(var1.byteValue08)) {
            if (var2 >= 5 && var2 <= 7) {
               this.processActorAction(26);
            }

            if (var2 == 3 && gameShortValue01 != 10) {
               if (this.gameActorGroupReference01.byteValue04 == 1 || this.gameActorGroupReference01.byteValue04 == 2) {
                  this.processActorAction(40);
               }

               if (this.gameActorGroupReference01.byteValue04 == 3) {
                  this.processActorAction(41);
               }

               if (this.gameActorGroupReference01.byteValue04 == 0) {
                  this.processActorAction(27);
                  return;
               }
            }
         } else if (var1.byteValue08 == 11) {
            if (var2 == 3) {
               this.setPlayerFacingDirection(var1.byteValue08);
               return;
            }
         } else if (var1.byteValue08 == 9) {
            if (var2 >= 5 && var2 <= 7) {
               this.processActorAction(32);
            }

            if (var2 == 3) {
               this.setPlayerFacingDirection(var1.byteValue08);
            }
         }
      }
   }

   // $VF: renamed from: d (int) boolean
   public static bool isActorActionType(int var0) {
      return var0 == 2 || var0 == 4 || var0 == 5 || var0 == 6;
   }

   // $VF: renamed from: j () void
   public void updateTimedEntities() {
      for (int var1 = 0; var1 < this.gameByteValue12; var1++) {
         for (int var2 = 0; var2 < this.gameByteValue13; var2++) {
            this.gameByteMatrix03[var1][var2] = 0;
            if (this.gameShortMatrix01[var1][var2] != -1) {
               this.gameByteMatrix03[var1][var2] = (sbyte)(this.gameByteMatrix03[var1][var2] | 2);
            }

            if (this.gameShortMatrix02[var1][var2] != -1) {
               this.gameByteMatrix03[var1][var2] = (sbyte)(this.gameByteMatrix03[var1][var2] | 1);
            }
         }
      }

      sbyte[][] var8 = this.gameByteMatrix03;
      

      for (int var4 = 0; var4 < gameIntegerValue80; var4++) {
         ActorRuntimeState var5;
         if ((var5 = this.gameClass9ReferenceArray01[this.gameIntegerArray03[var4]]).booleanFlag02) {
            sbyte var9 = var5.byteValue01;
            short[] var6;
            if ((var6 = this.gameShortMatrix03[var9])[7] != 0) {
               if (var6[6] != 0) {
                  if (!var5.booleanFlag04) {
                     if (var5.byteValue02 != 0) {
                        for (int var13 = 0; var13 < var6[5]; var13++) {
                           var8[var5.byteValue02][var5.byteValue03 + var13] = (sbyte)(var8[var5.byteValue02][var5.byteValue03 + var13] | 2);
                        }
                     }
                  } else if (var5.byteValue03 != 0) {
                     for (int var12 = 0; var12 < var6[5]; var12++) {
                        var8[var5.byteValue02 + var12][var5.byteValue03] = (sbyte)(var8[var5.byteValue02 + var12][var5.byteValue03] | 1);
                     }
                  }
               } else if (!var5.booleanFlag04) {
                  for (int var11 = 0; var11 < var6[4]; var11++) {
                     for (int var14 = 0; var14 < var6[5]; var14++) {
                        var8[var5.byteValue02 + var11][var5.byteValue03 + var14] = (sbyte)(var8[var5.byteValue02 + var11][var5.byteValue03 + var14] | 240);
                     }
                  }
               } else {
                  for (int var10 = 0; var10 < var6[5]; var10++) {
                     for (int var3 = 0; var3 < var6[4]; var3++) {
                        var8[var5.byteValue02 + var10][var5.byteValue03 + var3] = (sbyte)(var8[var5.byteValue02 + var10][var5.byteValue03 + var3] | 240);
                     }
                  }
               }
            }
         }
      }
   }

   // $VF: renamed from: k () void
   public void advanceGameplaySimulation() {
      if (gameBooleanFlag55) {
         this.updateTimedEntities();
         gameBooleanFlag55 = false;
      }

      int var2 = this.gameByteMatrix03[0].Length;

      for (int var1 = 0; var1 < this.gameByteValue12; var1++) {
         JSystem.arraycopy(this.gameByteMatrix03[var1], 0, this.gameByteMatrix04[var1], 0, var2);
      }

      for (int var3 = 0; var3 < 25; var3++) {
         ActorState var4;
         if ((var4 = this.gameActorStateReferenceArray01[var3]) != this.gameActorGroupReference01.actorStateReference01 && var4.booleanFlag01) {
            if (var4.byteValue05 == 3 || var4.byteValue05 == 4) {
               if (var4.byteValue08 == 5) {
                  continue;
               }

               if (var4.byteValue08 == 7) {
                  this.gameByteMatrix04[var4.byteValue01][var4.byteValue02] = (sbyte)(this.gameByteMatrix04[var4.byteValue01][var4.byteValue02] | 240);
                  this.gameByteMatrix04[var4.byteValue01][var4.byteValue02 - 1] = (sbyte)(this.gameByteMatrix04[var4.byteValue01][var4.byteValue02 - 1] | 240);
                  continue;
               }

               if (var4.byteValue08 == 3 || var4.byteValue08 == 9) {
                  this.gameByteMatrix04[var4.byteValue01][var4.byteValue02] = (sbyte)(this.gameByteMatrix04[var4.byteValue01][var4.byteValue02] | 240);
                  continue;
               }

               if (var4.byteValue08 != 10) {
                  continue;
               }

               this.gameByteMatrix04[var4.byteValue01][var4.byteValue02] = (sbyte)(this.gameByteMatrix04[var4.byteValue01][var4.byteValue02] | 240);
               this.gameByteMatrix04[var4.byteValue01][var4.byteValue02 - 1] = (sbyte)(this.gameByteMatrix04[var4.byteValue01][var4.byteValue02 - 1] | 240);
               this.gameByteMatrix04[var4.byteValue01 - 1][var4.byteValue02 - 1] = (sbyte)(this.gameByteMatrix04[var4.byteValue01 - 1][var4.byteValue02 - 1] | 240);
               this.gameByteMatrix04[var4.byteValue01 + 1][var4.byteValue02 - 1] = (sbyte)(this.gameByteMatrix04[var4.byteValue01 + 1][var4.byteValue02 - 1] | 240);
               this.gameByteMatrix04[var4.byteValue01][var4.byteValue02 - 2] = (sbyte)(this.gameByteMatrix04[var4.byteValue01][var4.byteValue02 - 2] | 240);
               this.gameByteMatrix04[var4.byteValue01 - 1][var4.byteValue02 - 2] = (sbyte)(this.gameByteMatrix04[var4.byteValue01 - 1][var4.byteValue02 - 2] | 240);
               this.gameByteMatrix04[var4.byteValue01][var4.byteValue02 - 3] = (sbyte)(this.gameByteMatrix04[var4.byteValue01][var4.byteValue02 - 3] | 240);
               this.gameByteMatrix04[var4.byteValue01 - 1][var4.byteValue02 - 3] = (sbyte)(this.gameByteMatrix04[var4.byteValue01 - 1][var4.byteValue02 - 3] | 240);
               this.gameByteMatrix04[var4.byteValue01][var4.byteValue02 - 4] = (sbyte)(this.gameByteMatrix04[var4.byteValue01][var4.byteValue02 - 4] | 240);
               this.gameByteMatrix04[var4.byteValue01 - 1][var4.byteValue02 - 4] = (sbyte)(this.gameByteMatrix04[var4.byteValue01 - 1][var4.byteValue02 - 4] | 240);
            }

            if (var4.byteValue08 != 0 && var4.byteValue08 != 1 && var4.byteValue08 != 3) {
               this.gameByteMatrix04[var4.byteValue01][var4.byteValue02] = (sbyte)(this.gameByteMatrix04[var4.byteValue01][var4.byteValue02] | 240);
            } else {
               this.gameByteMatrix04[var4.byteValue01][var4.byteValue02] = (sbyte)(this.gameByteMatrix04[var4.byteValue01][var4.byteValue02] | 240);
            }
         }
      }

      if (this.gameByteValue04 == 0) {
         if (gameByteValue07 == 3) {
            this.gameByteMatrix04[57][24] = (sbyte)(this.gameByteMatrix04[57][24] | 240);
            this.gameByteMatrix04[57][25] = (sbyte)(this.gameByteMatrix04[57][25] | 240);
         }

         if (gameShortValue01 == 50) {
            this.gameByteMatrix04[29][29] = (sbyte)(this.gameByteMatrix04[29][29] | 240);
            this.gameByteMatrix04[30][29] = (sbyte)(this.gameByteMatrix04[30][29] | 240);
         }
      }

      if (gameIntegerValue50 == 384) {
         this.gameByteMatrix04[this.gameActorGroupReference01.actorStateReference01.byteValue01][this.gameActorGroupReference01.actorStateReference01.byteValue02] = (sbyte)(
            this.gameByteMatrix04[this.gameActorGroupReference01.actorStateReference01.byteValue01][this.gameActorGroupReference01.actorStateReference01.byteValue02] | 240
         );
      } else {
         this.gameByteMatrix04[this.gameActorGroupReference01.actorStateReference01.byteValue01][this.gameActorGroupReference01.actorStateReference01.byteValue02] = (sbyte)this.gameByteMatrix04[this.gameActorGroupReference01.actorStateReference01.byteValue01][this.gameActorGroupReference01
            .actorStateReference01
            .byteValue02];
      }
   }

   // $VF: renamed from: a (int, int, int, boolean) boolean
   public bool isTileBlocked(int var1, int var2, int var3, bool var4) {
      switch (var3) {
         case 1:
            if (var1 == this.gameByteValue12 - 1) {
               return false;
            }

            if ((this.gameByteMatrix04[var1 + 1][var2] & 240) != 0) {
               return false;
            }

            if ((this.gameByteMatrix04[var1][var2] & 8) != 0) {
               return false;
            }

            if ((this.gameByteMatrix04[var1 + 1][var2] & 2) != 0) {
               return false;
            }

            if (var4 && this.gameByteValue05 != this.gameByteMatrix02[var1 + 1][var2]) {
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

            if ((this.gameByteMatrix04[var1][var2 - 1] & 240) != 0) {
               return false;
            }

            if ((this.gameByteMatrix04[var1][var2] & 1) != 0) {
               return false;
            }

            if ((this.gameByteMatrix04[var1][var2 - 1] & 4) != 0) {
               return false;
            }

            if (var4 && this.gameByteValue05 != this.gameByteMatrix02[var1][var2 - 1]) {
               return false;
            }
            break;
         case 5:
            if (var1 == 0) {
               return false;
            }

            if ((this.gameByteMatrix04[var1 - 1][var2] & 240) != 0) {
               return false;
            }

            if ((this.gameByteMatrix04[var1][var2] & 2) != 0) {
               return false;
            }

            if ((this.gameByteMatrix04[var1 - 1][var2] & 8) != 0) {
               return false;
            }

            if (var4 && this.gameByteValue05 != this.gameByteMatrix02[var1 - 1][var2]) {
               return false;
            }
            break;
         case 7:
            if (var2 == this.gameByteValue13 - 1) {
               return false;
            }

            if ((this.gameByteMatrix04[var1][var2 + 1] & 240) != 0) {
               return false;
            }

            if ((this.gameByteMatrix04[var1][var2] & 4) != 0) {
               return false;
            }

            if ((this.gameByteMatrix04[var1][var2 + 1] & 1) != 0) {
               return false;
            }

            if (var4 && this.gameByteValue05 != this.gameByteMatrix02[var1][var2 + 1]) {
               return false;
            } break;
      }

      return true;
   }

   // $VF: renamed from: a (int, int, int, int) void
   public void findPathToTile(int var1, int var2, int var3, int var4) {
      bool[] var10 = new bool[4];
      LinkedEntityNode var6 = null;
      int var13 = 0;
      var13++;
      LinkedEntityNode var7;
      (var7 = this.gameClass14ReferenceArray01[0]).byteValue01 = (sbyte)var1;
      var7.byteValue02 = (sbyte)var2;
      var7.byteValue03 = 0;
      var7.byteValue04 = (sbyte)(absoluteValue(var7.byteValue01 - var3) + absoluteValue(var7.byteValue02 - var4));
      var7.class14Reference01 = null;
      var7.class14Reference02 = null;
      LinkedEntityNode var9 = var7;
      if (var1 == var3 && var2 == var4) {
         this.gameClass14Reference01 = var7;
      } else {
         sbyte var11 = this.gameByteMatrix04[var1][var2];
         sbyte var12 = this.gameByteMatrix04[var3][var4];
         if (this.gameByteMatrix04[var3][var4] == 240) {
            this.gameClass14Reference01 = null;
         } else {
            this.gameByteMatrix04[var1][var2] = (sbyte)(this.gameByteMatrix04[var1][var2] & 15);
            this.gameByteMatrix04[var3][var4] = (sbyte)(this.gameByteMatrix04[var3][var4] & 15);
            object var17 = null;
            var7.class14Reference01 = (LinkedEntityNode)var17;
            LinkedEntityNode var5 = var7;

            do {
               var7 = var5;
               LinkedEntityNode var8 = var5;
               if (var5 == null) {
                  break;
               }

               while (var7.class14Reference01 != null) {
                  if ((var7 = var7.class14Reference01).byteValue03 + var7.byteValue04 < var8.byteValue03 + var8.byteValue04) {
                     var8 = var7;
                  }
               }

               if (var8.byteValue04 < var9.byteValue04) {
                  var9 = var8;
               }

               if (var9.byteValue04 == 0) {
                  break;
               }

               var10[0] = this.isTileBlocked(var8.byteValue01, var8.byteValue02, 3, false);
               var10[1] = this.isTileBlocked(var8.byteValue01, var8.byteValue02, 5, false);
               var10[2] = this.isTileBlocked(var8.byteValue01, var8.byteValue02, 7, false);
               var10[3] = this.isTileBlocked(var8.byteValue01, var8.byteValue02, 1, false);

               for (LinkedEntityNode var19 = var5; var19 != null; var19 = var19.class14Reference01) {
                  for (int var15 = 0; var15 < 4; var15++) {
                     if (var19.byteValue01 == var8.byteValue01 + AnimationTables.integerMatrix03[var15][0] && var19.byteValue02 == var8.byteValue02 + AnimationTables.integerMatrix03[var15][1]) {
                        var10[var15] = false;
                     }
                  }
               }

               for (LinkedEntityNode var20 = var6; var20 != null; var20 = var20.class14Reference01) {
                  for (int var27 = 0; var27 < 4; var27++) {
                     if (var20.byteValue01 == var8.byteValue01 + AnimationTables.integerMatrix03[var27][0] && var20.byteValue02 == var8.byteValue02 + AnimationTables.integerMatrix03[var27][1]) {
                        var10[var27] = false;
                     }
                  }
               }

               int var14 = this.nextRandomByte() & 3;

               for (int var28 = 0; var28 < 4; var28++) {
                  if (var10[var14]) {
                     if (var13 == 150) {
                        break;
                     }

                     (var7 = this.gameClass14ReferenceArray01[var13++]).byteValue01 = (sbyte)(var8.byteValue01 + AnimationTables.integerMatrix03[var14][0]);
                     var7.byteValue02 = (sbyte)(var8.byteValue02 + AnimationTables.integerMatrix03[var14][1]);
                     var7.byteValue03 = (sbyte)(var8.byteValue03 + 1);
                     var7.byteValue04 = (sbyte)(absoluteValue(var7.byteValue01 - var3) + absoluteValue(var7.byteValue02 - var4));
                     var7.class14Reference01 = null;
                     var7.class14Reference02 = var8;
                     var7.class14Reference01 = var5;
                     var5 = var7;
                  }

                  var14 = (var14 + 1) % 4;
               }

               var7 = var8;
               LinkedEntityNode var10000;
               if (var5 == var8) {
                  LinkedEntityNode var25 = var8.class14Reference01;
                  var8.class14Reference01 = null;
                  var10000 = var25;
               } else {
                  for (LinkedEntityNode var26 = var5; var26.class14Reference01 != null; var26 = var26.class14Reference01) {
                     if (var26.class14Reference01 == var7) {
                        if (var7.class14Reference01 == null) {
                           var26.class14Reference01 = null;
                        } else {
                           var26.class14Reference01 = var7.class14Reference01;
                           var7.class14Reference01 = null;
                        }
                        break;
                     }
                  }

                  var10000 = var5;
               }

               var5 = var10000;
               var8.class14Reference01 = var6;
               var6 = var8;
            } while (var13 != 150);

            for (var7 = null; var9 != null; var9 = var9.class14Reference02) {
               var9.class14Reference01 = var7;
               var7 = var9;
            }

            this.gameByteMatrix04[var1][var2] = var11;
            this.gameByteMatrix04[var3][var4] = var12;
            this.gameClass14Reference01 = var7.class14Reference01;
         }
      }
   }

   // $VF: renamed from: c (p, int, int) void
   public void moveActorTowardTileX(ActorState var1, int var2, int var3) {
      int var4 = var1.byteValue01 - var2;
      if (absoluteValue(var2 = var1.byteValue02 - var3) <= absoluteValue(var4)) {
         if (var4 <= 0) {
            setActorFacingDirection(var1, 1);
         } else {
            setActorFacingDirection(var1, 5);
         }
      } else if (var2 <= 0) {
         setActorFacingDirection(var1, 7);
      } else {
         setActorFacingDirection(var1, 3);
      }
   }

   // $VF: renamed from: a (p, int, int) void
   public void moveActorTowardTileY(ActorState var1, int var2, int var3) {
      int var4 = var2 - var1.byteValue01;
      var2 = var3 - var1.byteValue02;
      if (var4 == 0 && var2 == 0) {
         setActorFacingDirection(var1, 0);
      } else if (absoluteValue(var2) << 1 <= absoluteValue(var4)) {
         if (var4 <= 0) {
            setActorFacingDirection(var1, 5);
         } else {
            setActorFacingDirection(var1, 1);
         }
      } else if (absoluteValue(var2) <= absoluteValue(var4) << 1) {
         if (var4 <= 0 && var2 <= 0) {
            setActorFacingDirection(var1, 4);
         } else if (var4 <= 0) {
            setActorFacingDirection(var1, 6);
         } else if (var2 <= 0) {
            setActorFacingDirection(var1, 2);
         } else {
            setActorFacingDirection(var1, 0);
         }
      } else if (var2 <= 0) {
         setActorFacingDirection(var1, 3);
      } else {
         setActorFacingDirection(var1, 7);
      }
   }

   // $VF: renamed from: b (p, int, int) boolean
   public bool canActorReachTile(ActorState var1, int var2, int var3) {
      int var4 = var1.byteValue01 - var2;
      var2 = var1.byteValue02 - var3;
      if (absoluteValue(var4) == 0 && absoluteValue(var2) == 1 || absoluteValue(var4) == 1 && absoluteValue(var2) == 0) {
         if (absoluteValue(var2) <= absoluteValue(var4)) {
            if (var4 <= 0) {
               if (var1.byteValue07 == 1) {
                  return true;
               }
            } else if (var1.byteValue07 == 5) {
               return true;
            }
         } else if (var2 <= 0) {
            if (var1.byteValue07 == 7) {
               return true;
            }
         } else if (var1.byteValue07 == 3) {
            return true;
         }

         return false;
      } else {
         return false;
      }
   }

   // $VF: renamed from: b (p, int, int) void
   public void moveActorToTile(ActorState var1, int var2, int var3) {
      if (var1.byteValue01 != var2 || var1.byteValue02 != var3) {
         var1.byteValue12 = (sbyte)var2;
         var1.byteValue13 = (sbyte)var3;
         this.findPathToTile(var1.byteValue01, var1.byteValue02, var1.byteValue12, var1.byteValue13);
         if (this.gameClass14Reference01 != null) {
            this.moveActorTowardTileX(var1, this.gameClass14Reference01.byteValue01, this.gameClass14Reference01.byteValue02);
            this.faceActorTowardPosition(var1, 1);
         }
      }
   }

   // $VF: renamed from: K () void
   public void updateGameWorld() {
      if (!gameBooleanFlag29) {
         this.advanceGameplaySimulation();

         for (int var2 = 0; var2 < 25; var2++) {
            ActorState var1;
            if ((var1 = this.gameActorStateReferenceArray01[var2]).booleanFlag01
               && var1.byteValue01 < this.gameByteValue12
               && var1.byteValue02 < this.gameByteValue13
               && (this.gameByteValue05 == this.gameByteMatrix02[var1.byteValue01][var1.byteValue02] || isActorAlive(var1))
               && var1.byteValue05 != 3
               && var1.byteValue05 != 4) {
               if (var1.byteValue12 != -1 && var1.byteValue13 != -1 && !isActorDefeated(var1) && (var1.byteValue01 != var1.byteValue12 || var1.byteValue02 != var1.byteValue13)) {
                  this.moveActorToTile(var1, var1.byteValue12, var1.byteValue13);
               }

               switch (var1.byteValue08) {
                  case 2:
                  case 4:
                     if (gameByteValue07 != 0 && gameByteValue07 != 1 && var1.byteValue05 != 5) {
                        if (var1.booleanFlag05) {
                           if (var1.byteValue05 != 0 && var1.byteValue01 == var1.byteValue12 && var1.byteValue02 == var1.byteValue13) {
                              var1.byteValue12 = -1;
                              var1.byteValue13 = -1;
                              this.faceActorTowardPosition(var1, 0);
                           }
                        } else {
                           if ((absoluteValue(var1.byteValue01 - this.gameActorGroupReference01.actorStateReference01.byteValue01) > 1 || var1.byteValue02 != this.gameActorGroupReference01.actorStateReference01.byteValue02)
                              && (absoluteValue(var1.byteValue02 - this.gameActorGroupReference01.actorStateReference01.byteValue02) > 1 || var1.byteValue01 != this.gameActorGroupReference01.actorStateReference01.byteValue01)) {
                              if (var1.byteValue05 != 1 || var1.byteValue12 >= 0 && var1.byteValue13 >= 0) {
                                 if (var1.byteValue05 == 1
                                    && (var1.byteValue12 != this.gameActorGroupReference01.actorStateReference01.byteValue01 || var1.byteValue13 != this.gameActorGroupReference01.actorStateReference01.byteValue02)) {
                                    var1.byteValue12 = this.gameActorGroupReference01.actorStateReference01.byteValue01;
                                    var1.byteValue13 = this.gameActorGroupReference01.actorStateReference01.byteValue02;
                                 }
                              } else {
                                 this.faceActorTowardPosition(var1, 0);
                                 var1.longValue02 = this.gameLongValue06;
                              }
                           } else {
                              this.faceActorTowardPosition(var1, 0);
                           }

                           if (var1.byteValue05 == 0) {
                              this.moveActorTowardTileX(var1, this.gameActorGroupReference01.actorStateReference01.byteValue01, this.gameActorGroupReference01.actorStateReference01.byteValue02);
                              if (absoluteValue(var1.byteValue01 - this.gameActorGroupReference01.actorStateReference01.byteValue01) <= 1 && var1.byteValue02 == this.gameActorGroupReference01.actorStateReference01.byteValue02
                                 || absoluteValue(var1.byteValue02 - this.gameActorGroupReference01.actorStateReference01.byteValue02) <= 1
                                    && var1.byteValue01 == this.gameActorGroupReference01.actorStateReference01.byteValue01) {
                                 var1.byteValue12 = -1;
                                 var1.byteValue13 = -1;
                                 if (this.gameLongValue06 - var1.longValue02 > 1400L) {
                                    this.faceActorTowardPosition(var1, 5);
                                    var1.longValue02 = this.gameLongValue06;
                                 }
                              } else if (this.gameLongValue06 - var1.longValue02 > 500L) {
                                 int var9;
                                 if ((var9 = this.findActorAtTile(var2, var1.byteValue01, var1.byteValue02, false)) != -1
                                    && this.gameActorStateReferenceArray01[var9].byteValue07 == var1.byteValue07) {
                                    var1.byteValue07 = (sbyte)(var1.byteValue07 + (this.nextRandomByte() % 3 + 1 << 1));
                                 }

                                 var1.byteValue12 = this.gameActorGroupReference01.actorStateReference01.byteValue01;
                                 var1.byteValue13 = this.gameActorGroupReference01.actorStateReference01.byteValue02;
                                 this.faceActorTowardPosition(var1, 1);
                              }
                           }
                        }
                     } goto case 3;
                  case 3:
                  case 7:
                  default:
                     break;
                  case 5:
                     if (gameByteValue07 == 0 || gameByteValue07 == 1 || var1.byteValue05 == 5 || var1.byteValue05 == 6 || var1.byteValue05 == 14 || var1.booleanFlag05) {
                        break;
                     }

                     if ((absoluteValue(var1.byteValue01 - this.gameActorGroupReference01.actorStateReference01.byteValue01) > 1 || var1.byteValue02 != this.gameActorGroupReference01.actorStateReference01.byteValue02)
                        && (absoluteValue(var1.byteValue02 - this.gameActorGroupReference01.actorStateReference01.byteValue02) > 1 || var1.byteValue01 != this.gameActorGroupReference01.actorStateReference01.byteValue01)) {
                        if (!this.gameBooleanFlag42
                           || (absoluteValue(var1.byteValue01 - this.gameActorGroupReference01.actorStateReference01.byteValue01) != 2 || var1.byteValue02 != this.gameActorGroupReference01.actorStateReference01.byteValue02)
                              && (absoluteValue(var1.byteValue02 - this.gameActorGroupReference01.actorStateReference01.byteValue02) != 2 || var1.byteValue01 != this.gameActorGroupReference01.actorStateReference01.byteValue01)
                           )
                         {
                           if (var1.byteValue05 != 1 || var1.byteValue12 >= 0 && var1.byteValue13 >= 0) {
                              if (var1.byteValue05 == 1
                                 && (var1.byteValue12 != this.gameActorGroupReference01.actorStateReference01.byteValue01 || var1.byteValue13 != this.gameActorGroupReference01.actorStateReference01.byteValue02)) {
                                 var1.byteValue12 = this.gameActorGroupReference01.actorStateReference01.byteValue01;
                                 var1.byteValue13 = this.gameActorGroupReference01.actorStateReference01.byteValue02;
                              }
                           } else {
                              this.faceActorTowardPosition(var1, 0);
                              var1.longValue02 = this.gameLongValue06;
                           }
                        } else {
                           this.faceActorTowardPosition(var1, 0);
                        }
                     } else {
                        this.gameBooleanFlag42 = false;
                        this.faceActorTowardPosition(var1, 0);
                     }

                     if (var1.byteValue05 != 0) {
                        break;
                     }

                     this.moveActorTowardTileX(var1, this.gameActorGroupReference01.actorStateReference01.byteValue01, this.gameActorGroupReference01.actorStateReference01.byteValue02);
                     if ((absoluteValue(var1.byteValue01 - this.gameActorGroupReference01.actorStateReference01.byteValue01) > 1 || var1.byteValue02 != this.gameActorGroupReference01.actorStateReference01.byteValue02)
                        && (absoluteValue(var1.byteValue02 - this.gameActorGroupReference01.actorStateReference01.byteValue02) > 1 || var1.byteValue01 != this.gameActorGroupReference01.actorStateReference01.byteValue01)) {
                        if (this.gameBooleanFlag42
                           && (
                              absoluteValue(var1.byteValue01 - this.gameActorGroupReference01.actorStateReference01.byteValue01) == 2 && var1.byteValue02 == this.gameActorGroupReference01.actorStateReference01.byteValue02
                                 || absoluteValue(var1.byteValue02 - this.gameActorGroupReference01.actorStateReference01.byteValue02) == 2
                                    && var1.byteValue01 == this.gameActorGroupReference01.actorStateReference01.byteValue01
                           )) {
                           var1.byteValue12 = -1;
                           var1.byteValue13 = -1;
                           if (this.gameLongValue06 - var1.longValue02 > 1400L) {
                              this.faceActorTowardPosition(var1, 6);
                              this.gameBooleanFlag42 = false;
                           }
                        } else if (this.gameLongValue06 - var1.longValue02 > 2000L) {
                           var1.byteValue12 = this.gameActorGroupReference01.actorStateReference01.byteValue01;
                           var1.byteValue13 = this.gameActorGroupReference01.actorStateReference01.byteValue02;
                           this.faceActorTowardPosition(var1, 1);
                           if (this.nextRandomInteger() % 100 < 15) {
                              this.gameBooleanFlag42 = true;
                           }
                        }
                     } else {
                        var1.byteValue12 = -1;
                        var1.byteValue13 = -1;
                        if (this.gameLongValue06 - var1.longValue02 > 1400L) {
                           this.faceActorTowardPosition(var1, 5);
                        }
                     }
                     break;
                  case 6:
                     if (gameByteValue07 == 0 || gameByteValue07 == 1 || var1.byteValue05 == 5 || var1.booleanFlag05) {
                        break;
                     }

                     if ((absoluteValue(var1.byteValue01 - this.gameActorGroupReference01.actorStateReference01.byteValue01) > 1 || var1.byteValue02 != this.gameActorGroupReference01.actorStateReference01.byteValue02)
                        && (absoluteValue(var1.byteValue02 - this.gameActorGroupReference01.actorStateReference01.byteValue02) > 1 || var1.byteValue01 != this.gameActorGroupReference01.actorStateReference01.byteValue01)) {
                        if (var1.byteValue05 != 1 || var1.byteValue12 >= 0 && var1.byteValue13 >= 0) {
                           if (var1.byteValue05 == 1
                              && (var1.byteValue12 != this.gameActorGroupReference01.actorStateReference01.byteValue01 || var1.byteValue13 != this.gameActorGroupReference01.actorStateReference01.byteValue02)) {
                              var1.byteValue12 = this.gameActorGroupReference01.actorStateReference01.byteValue01;
                              var1.byteValue13 = this.gameActorGroupReference01.actorStateReference01.byteValue02;
                           }
                        } else {
                           this.faceActorTowardPosition(var1, 0);
                           var1.longValue02 = this.gameLongValue06;
                        }
                     } else {
                        this.faceActorTowardPosition(var1, 0);
                     }

                     if (var1.byteValue05 != 0) {
                        break;
                     }

                     this.moveActorTowardTileX(var1, this.gameActorGroupReference01.actorStateReference01.byteValue01, this.gameActorGroupReference01.actorStateReference01.byteValue02);
                     if (absoluteValue(var1.byteValue01 - this.gameActorGroupReference01.actorStateReference01.byteValue01) <= 1 && var1.byteValue02 == this.gameActorGroupReference01.actorStateReference01.byteValue02
                        || absoluteValue(var1.byteValue02 - this.gameActorGroupReference01.actorStateReference01.byteValue02) <= 1 && var1.byteValue01 == this.gameActorGroupReference01.actorStateReference01.byteValue01) {
                        var1.byteValue12 = -1;
                        var1.byteValue13 = -1;
                        if (this.gameLongValue06 - var1.longValue02 > 1400L) {
                           this.faceActorTowardPosition(var1, 5);
                           var1.longValue02 = this.gameLongValue06;
                        }
                     } else if (this.gameLongValue06 - var1.longValue02 > 500L) {
                        int var8;
                        if ((var8 = this.findActorAtTile(var2, var1.byteValue01, var1.byteValue02, false)) != -1 && this.gameActorStateReferenceArray01[var8].byteValue07 == var1.byteValue07) {
                           var1.byteValue07 = (sbyte)(var1.byteValue07 + (this.nextRandomByte() % 3 + 1 << 1));
                        }

                        var1.byteValue12 = this.gameActorGroupReference01.actorStateReference01.byteValue01;
                        var1.byteValue13 = this.gameActorGroupReference01.actorStateReference01.byteValue02;
                        this.faceActorTowardPosition(var1, 1);
                     }
                     break;
                  case 8:
                     if (gameByteValue07 == 0 || gameByteValue07 == 1 || var1.byteValue05 == 5 || var1.byteValue05 == 6 || var1.byteValue05 == 14 || var1.booleanFlag05) {
                        break;
                     }

                     if ((absoluteValue(var1.byteValue01 - this.gameActorGroupReference01.actorStateReference01.byteValue01) > 1 || var1.byteValue02 != this.gameActorGroupReference01.actorStateReference01.byteValue02)
                        && (absoluteValue(var1.byteValue02 - this.gameActorGroupReference01.actorStateReference01.byteValue02) > 1 || var1.byteValue01 != this.gameActorGroupReference01.actorStateReference01.byteValue01)) {
                        if (!this.gameBooleanFlag42
                           || (absoluteValue(var1.byteValue01 - this.gameActorGroupReference01.actorStateReference01.byteValue01) != 2 || var1.byteValue02 != this.gameActorGroupReference01.actorStateReference01.byteValue02)
                              && (absoluteValue(var1.byteValue02 - this.gameActorGroupReference01.actorStateReference01.byteValue02) != 2 || var1.byteValue01 != this.gameActorGroupReference01.actorStateReference01.byteValue01)
                           )
                         {
                           if (var1.byteValue05 != 1 || var1.byteValue12 >= 0 && var1.byteValue13 >= 0) {
                              if (var1.byteValue05 == 1
                                 && (var1.byteValue12 != this.gameActorGroupReference01.actorStateReference01.byteValue01 || var1.byteValue13 != this.gameActorGroupReference01.actorStateReference01.byteValue02)) {
                                 var1.byteValue12 = this.gameActorGroupReference01.actorStateReference01.byteValue01;
                                 var1.byteValue13 = this.gameActorGroupReference01.actorStateReference01.byteValue02;
                              }
                           } else {
                              this.faceActorTowardPosition(var1, 0);
                              var1.longValue02 = this.gameLongValue06;
                           }
                        } else {
                           this.faceActorTowardPosition(var1, 0);
                        }
                     } else {
                        this.gameBooleanFlag42 = false;
                        this.faceActorTowardPosition(var1, 0);
                     }

                     if (var1.byteValue05 != 0) {
                        break;
                     }

                     this.moveActorTowardTileX(var1, this.gameActorGroupReference01.actorStateReference01.byteValue01, this.gameActorGroupReference01.actorStateReference01.byteValue02);
                     if ((absoluteValue(var1.byteValue01 - this.gameActorGroupReference01.actorStateReference01.byteValue01) > 1 || var1.byteValue02 != this.gameActorGroupReference01.actorStateReference01.byteValue02)
                        && (absoluteValue(var1.byteValue02 - this.gameActorGroupReference01.actorStateReference01.byteValue02) > 1 || var1.byteValue01 != this.gameActorGroupReference01.actorStateReference01.byteValue01)) {
                        if (this.gameBooleanFlag42
                           && (
                              absoluteValue(var1.byteValue01 - this.gameActorGroupReference01.actorStateReference01.byteValue01) == 2 && var1.byteValue02 == this.gameActorGroupReference01.actorStateReference01.byteValue02
                                 || absoluteValue(var1.byteValue02 - this.gameActorGroupReference01.actorStateReference01.byteValue02) == 2
                                    && var1.byteValue01 == this.gameActorGroupReference01.actorStateReference01.byteValue01
                           )) {
                           var1.byteValue12 = -1;
                           var1.byteValue13 = -1;
                           if (this.gameLongValue06 - var1.longValue02 > 1000L) {
                              this.faceActorTowardPosition(var1, 6);
                              this.gameBooleanFlag42 = false;
                           }
                        } else if (this.gameLongValue06 - var1.longValue02 > 1400L) {
                           int var7;
                           if ((var7 = this.findActorAtTile(var2, var1.byteValue01, var1.byteValue02, false)) != -1 && this.gameActorStateReferenceArray01[var7].byteValue07 == var1.byteValue07) {
                              var1.byteValue07 = (sbyte)(var1.byteValue07 + (this.nextRandomByte() % 3 + 1 << 1));
                           }

                           var1.byteValue12 = this.gameActorGroupReference01.actorStateReference01.byteValue01;
                           var1.byteValue13 = this.gameActorGroupReference01.actorStateReference01.byteValue02;
                           this.faceActorTowardPosition(var1, 1);
                           if (this.nextRandomInteger() % 100 < 25) {
                              this.gameBooleanFlag42 = true;
                           }
                        }
                     } else {
                        var1.byteValue12 = -1;
                        var1.byteValue13 = -1;
                        if (this.gameLongValue06 - var1.longValue02 > 1000L) {
                           if (this.nextRandomInteger() % 100 < 40) {
                              this.faceActorTowardPosition(var1, 6);
                           } else {
                              this.faceActorTowardPosition(var1, 5);
                           }
                        }
                     }
                     break;
                  case 9:
                     if (gameByteValue07 != 0
                        && gameByteValue07 != 1
                        && var1.byteValue05 != 5
                        && !var1.booleanFlag05
                        && var1.byteValue05 == 0
                        && this.gameLongValue06 - var1.longValue02 > 2000L) {
                        this.faceActorTowardPosition(var1, 5);
                     }
                     break;
                  case 10:
                     if (var1.byteValue05 != 5
                        && !var1.booleanFlag05
                        && (
                           absoluteValue(var1.byteValue01 - this.gameActorGroupReference01.actorStateReference01.byteValue01) <= 1 && var1.byteValue02 == this.gameActorGroupReference01.actorStateReference01.byteValue02
                              || absoluteValue(var1.byteValue02 - this.gameActorGroupReference01.actorStateReference01.byteValue02) <= 1 && var1.byteValue01 == this.gameActorGroupReference01.actorStateReference01.byteValue01
                        )
                        && this.gameLongValue06 - var1.longValue02 > 1400L) {
                        this.findEntityFrameData(0, this.gameActorGroupReference01.actorStateReference01.byteValue01, this.gameActorGroupReference01.actorStateReference01.byteValue02, 54, 2);
                        this.faceActorTowardPosition(var1, 5);
                     }
                     break;
                  case 11:
                     if (gameByteValue07 != 0 && gameByteValue07 != 1) {
                        if (var1.byteValue05 == 0 || var1.byteValue05 == 8) {
                           this.moveActorTowardTileX(var1, this.gameActorGroupReference01.actorStateReference01.byteValue01, this.gameActorGroupReference01.actorStateReference01.byteValue02);
                           this.faceActorTowardPosition(var1, 1);
                        }

                        int var3;
                        if (var1.byteValue05 == 1
                           && (var3 = this.findActorAtTile(var2, var1.byteValue01, var1.byteValue02, false)) != -1
                           && this.gameActorStateReferenceArray01[var3].byteValue07 == var1.byteValue07) {
                           var1.byteValue07 = (sbyte)(var1.byteValue07 + 2);
                           if (var1.byteValue07 > 7) {
                              var1.byteValue07 = 1;
                           }
                        }
                     } break;
               }

               if (var1.booleanFlag02) {
                  switch (var1.byteValue08) {
                     case 0:
                     case 1:
                        if (var1.byteValue12 >= 0 && var1.byteValue13 >= 0) {
                           break;
                        }

                        if ((gameIntegerValue50 & 512) == 0
                           && this.gameByteValue04 == 0
                           && this.gameActorGroupReference01.actorStateReference01 == var1
                           && this.gameActorGroupReference01.actorStateReference01.byteValue07 != 7
                           && gameByteValue07 == 2
                           && var1.byteValue01 == 36
                           && var1.byteValue02 == 17) {
                           this.configureActorStatusEffect(false, 140, 0);
                           continue;
                        }

                        if ((gameIntegerValue50 & 512) == 0
                           && this.gameByteValue04 == 1
                           && this.gameActorGroupReference01.actorStateReference01 == var1
                           && this.gameActorGroupReference01.actorStateReference01.byteValue07 != 7
                           && gameByteValue07 == 2
                           && var1.byteValue01 == 14
                           && var1.byteValue02 == 4) {
                           this.configureActorStatusEffect(false, 390, 0);
                        }
                        continue;
                     case 11:
                        if (var1.byteValue01 == this.gameActorGroupReference01.actorStateReference01.byteValue01 && var1.byteValue02 == this.gameActorGroupReference01.actorStateReference01.byteValue02) {
                           if (this.gameLongValue06 - var1.longValue02 > 700L) {
                              this.findEntityFrameData(0, this.gameActorGroupReference01.actorStateReference01.byteValue01, this.gameActorGroupReference01.actorStateReference01.byteValue02, 54, 2);
                              var1.longValue02 = this.gameLongValue06;
                              sbyte var13 = -1;
                              ActorState var12 = this.gameActorGroupReference01.actorStateReference01;
                              this.applyActorStatus(var12, var13, true);
                              this.processActorAction(30);
                           }
                           continue;
                        }

                        int var10 = this.countActorsAtTile(this.gameActorGroupReference01.actorStateReference01.byteValue01 - 1, this.gameActorGroupReference01.actorStateReference01.byteValue02);
                        int var4 = this.countActorsAtTile(this.gameActorGroupReference01.actorStateReference01.byteValue01, this.gameActorGroupReference01.actorStateReference01.byteValue02 - 1);
                        int var5 = this.countActorsAtTile(this.gameActorGroupReference01.actorStateReference01.byteValue01 + 1, this.gameActorGroupReference01.actorStateReference01.byteValue02);
                        int var6 = this.countActorsAtTile(this.gameActorGroupReference01.actorStateReference01.byteValue01, this.gameActorGroupReference01.actorStateReference01.byteValue02 + 1);
                        bool var11;
                        if ((var10 == -1 || this.gameActorStateReferenceArray01[var10].byteValue08 == 11)
                           && (var4 == -1 || this.gameActorStateReferenceArray01[var4].byteValue08 == 11)
                           && (var5 == -1 || this.gameActorStateReferenceArray01[var5].byteValue08 == 11)
                           && (var6 == -1 || this.gameActorStateReferenceArray01[var6].byteValue08 == 11)) {
                           var11 = true;
                        } else {
                           var11 = false;
                        }

                        if (!var11) {
                           var1.byteValue12 = var1.byteValue01;
                           var1.byteValue13 = var1.byteValue02;
                        } else {
                           var1.byteValue12 = this.gameActorGroupReference01.actorStateReference01.byteValue01;
                           var1.byteValue13 = this.gameActorGroupReference01.actorStateReference01.byteValue02;
                        } break;
                  }

                  if ((var1.byteValue01 != var1.byteValue12 || var1.byteValue02 != var1.byteValue13) && var1.byteValue12 >= 0 && var1.byteValue13 >= 0) {
                     this.findPathToTile(var1.byteValue01, var1.byteValue02, var1.byteValue12, var1.byteValue13);
                     if (this.gameClass14Reference01 != null) {
                        this.moveActorTowardTileX(var1, this.gameClass14Reference01.byteValue01, this.gameClass14Reference01.byteValue02);
                     }
                  }
               }
            }
         }
      }
   }

   // $VF: renamed from: f (int, int) int
   public int countActorsAtTile(int var1, int var2) {
      for (int var3 = 0; var3 < 25; var3++) {
         ActorState var4;
         if ((var4 = this.gameActorStateReferenceArray01[var3]).byteValue01 == var1
            && var4.byteValue02 == var2
            && var4.booleanFlag01
            && var4.byteValue05 != 3
            && var4.byteValue05 != 4
            && AnimationTables.integerMatrix02[var4.byteValue08][0] != 0) {
            return var3;
         }
      }

      return -1;
   }

   // $VF: renamed from: a (int, int, int, boolean) int
   public int findActorAtTile(int var1, int var2, int var3, bool var4) {
      if (var4) {
         if (this.gameActorGroupReference03.actorStateReference01.byteValue01 == var2 && this.gameActorGroupReference03.actorStateReference01.byteValue02 == var3 && this.gameActorGroupReference03.actorStateReference01.booleanFlag01) {
            return 1;
         } else {
            return this.gameActorGroupReference04.actorStateReference01.byteValue01 == var2 && this.gameActorGroupReference04.actorStateReference01.byteValue02 == var3 && this.gameActorGroupReference04.actorStateReference01.booleanFlag01 ? 2 : -1;
         }
      } else {
         for (int var6 = 2; var6 < 25; var6++) {
            ActorState var5;
            if ((var5 = this.gameActorStateReferenceArray01[var6]).byteValue01 == var2
               && var5.byteValue02 == var3
               && var6 != var1
               && var5.booleanFlag01
               && var5.byteValue05 != 3
               && var5.byteValue05 != 4) {
               return var6;
            }
         }

         return -1;
      }
   }

   // $VF: renamed from: a (int, int, int, int, boolean) int
   public int findActorGroupAtTile(int var1, int var2, int var3, int var4, bool var5) {
      if (var4 == 1) {
         var2++;
         var3 = var3;
      } else if (var4 == 7) {
         var2 = var2;
         var3++;
      } else if (var4 == 5) {
         var2--;
         var3 = var3;
      } else {
         if (var4 != 3) {
            return -1;
         }

         var2 = var2;
         var3--;
      }

      return this.findActorAtTile(var1, var2, var3, var5);
   }

   // $VF: renamed from: a (p) int
   public int getActorTileIndex(ActorState var1) {
      int var4 = var1.byteValue01;
      int var5 = var1.byteValue02;
      sbyte var7 = var1.byteValue07;
      int var11;
      if ((var11 = this.findActorAtTile(0, var4, var5, false)) != -1 && var11 != 2) {
         return var11;
      } else {
         for (int var2 = 1; var2 < 4; var2++) {
            var4 = wrapTileColumn(var4, var7, 1);
            var5 = wrapTileRow(var5, var7, 1);
            if ((var11 = this.findActorAtTile(0, var4, var5, false)) != -1 && var11 != 2) {
               return var11;
            }

            for (int var3 = 0; var3 < var2; var3++) {
               int var9 = var3 + 1;
               int var10 = var4;
               if (var7 == 3) {
                  var10 = var4 - var9;
               } else if (var7 == 7) {
                  var10 = var4 + var9;
               } else if (var7 == 2) {
                  var10 = var4 - var9;
               } else if (var7 == 6) {
                  var10 = var4 + var9;
               }

               var9 = var3 + 1;
               int var18 = var5;
               if (var7 == 1) {
                  var18 = var5 - var9;
               } else if (var7 == 5) {
                  var18 = var5 + var9;
               } else if (var7 == 4) {
                  var18 = var5 + var9;
               } else if (var7 == 0) {
                  var18 = var5 - var9;
               }

               int var13;
               if ((var13 = this.findActorAtTile(0, var10, var18, false)) != -1 && var13 != 2) {
                  return var13;
               }

               var9 = var3 + 1;
               int var19 = var4;
               if (var7 == 3) {
                  var19 = var4 + var9;
               } else if (var7 == 7) {
                  var19 = var4 - var9;
               } else if (var7 == 4) {
                  var19 = var4 + var9;
               } else if (var7 == 0) {
                  var19 = var4 - var9;
               }

               var9 = var3 + 1;
               int var20 = var5;
               if (var7 == 1) {
                  var20 = var5 + var9;
               } else if (var7 == 5) {
                  var20 = var5 - var9;
               } else if (var7 == 2) {
                  var20 = var5 + var9;
               } else if (var7 == 6) {
                  var20 = var5 - var9;
               }

               if ((var11 = this.findActorAtTile(0, var19, var20, false)) != -1 && var11 != 2) {
                  return var11;
               }
            }
         }

         if (var11 == 2) {
            var11 = -1;
         }

         return var11;
      }
   }

   // $VF: renamed from: a (int, int, int) int
   public static int wrapTileColumn(int var0, int var1, int var2) {
      int var3 = var0;
      if (var1 == 1) {
         var3 = var0 + var2;
      } else if (var1 == 5) {
         var3 = var0 - var2;
      } else if (var1 == 0) {
         var3 = var0 + var2;
      } else if (var1 == 6) {
         var3 = var0 - var2;
      } else if (var1 == 4) {
         var3 = var0 - var2;
      } else if (var1 == 2) {
         var3 = var0 + var2;
      }

      return var3;
   }

   // $VF: renamed from: b (int, int, int) int
   public static int wrapTileRow(int var0, int var1, int var2) {
      int var3 = var0;
      if (var1 == 3) {
         var3 = var0 - var2;
      } else if (var1 == 7) {
         var3 = var0 + var2;
      } else if (var1 == 2) {
         var3 = var0 - var2;
      } else if (var1 == 0) {
         var3 = var0 + var2;
      } else if (var1 == 4) {
         var3 = var0 - var2;
      } else if (var1 == 6) {
         var3 = var0 + var2;
      }

      return var3;
   }

   // $VF: renamed from: c (int, int, int) int
   public int countActiveEntities(int var1, int var2, int var3) {
      for (int var4 = 0; var4 < this.gameShortValue05; var4++) {
         ActorRuntimeState var6;
         if ((var6 = this.gameClass9ReferenceArray01[var4]).booleanFlag02 && var6.booleanFlag03) {
            sbyte var5 = this.gameClass9ReferenceArray01[var4].byteValue01;
            if (this.gameShortMatrix03[var5][6] == 0) {
               if (var6.booleanFlag04) {
                  if (containsPointInBounds(var1, var2, var6.byteValue02, var6.byteValue03, this.gameShortMatrix03[var5][5], this.gameShortMatrix03[var5][4])) {
                     return var4;
                  }
               } else if (containsPointInBounds(var1, var2, var6.byteValue02, var6.byteValue03, this.gameShortMatrix03[var5][4], this.gameShortMatrix03[var5][5])) {
                  return var4;
               }
            } else if (var3 == 1) {
               if (!var6.booleanFlag04 && containsPointInBounds(var1, var2, var6.byteValue02, var6.byteValue03, this.gameShortMatrix03[var5][4], this.gameShortMatrix03[var5][5])) {
                  return var4;
               }
            } else if (var3 == 7) {
               if (var6.booleanFlag04 && containsPointInBounds(var1, var2, var6.byteValue02, var6.byteValue03, this.gameShortMatrix03[var5][5], this.gameShortMatrix03[var5][4])) {
                  return var4;
               }
            } else if (var3 == 3) {
               if (var6.booleanFlag04 && containsPointInBounds(var1, var2 + 1, var6.byteValue02, var6.byteValue03, this.gameShortMatrix03[var5][5], this.gameShortMatrix03[var5][4])) {
                  return var4;
               }
            } else if (var3 == 5
               && !var6.booleanFlag04
               && containsPointInBounds(var1 + 1, var2, var6.byteValue02, var6.byteValue03, this.gameShortMatrix03[var5][4], this.gameShortMatrix03[var5][5])) {
               return var4;
            }
         }
      }

      return -1;
   }

   // $VF: renamed from: b (p, int) void
   public void setActorStatus(ActorState var1, int var2) {
      this.applyActorStatus(var1, var2, true);
   }

   // $VF: renamed from: a (p, int, boolean) void
   public void applyActorStatus(ActorState var1, int var2, bool var3) {
      if (var1.byteValue08 != 5 || this.gameActorGroupReference01.actorStateReference01.byteValue10 > 0) {
         if (var1 != this.gameActorGroupReference01.actorStateReference01 || this.gameActorStateReference03 == null || !this.gameActorStateReference03.booleanFlag01 || this.gameActorStateReference03.byteValue10 > 0) {
            if (var1.byteValue05 != 3 && var1.byteValue05 != 4) {
               if (var1.byteValue08 != 3) {
                  if (this.gameActorGroupReference01.byteValue04 != 4 || this.gameActorGroupReference02.actorStateReference01.byteValue08 != var1.byteValue08) {
                     if (var2 >= 128) {
                        var2 -= 256;
                     }

                     if (var1 == this.gameActorGroupReference01.actorStateReference01 && isGameInputPressed(1) && var2 < 0) {
                        var2 = 0;
                     }

                     if (var3 && var2 < 0 && (var1.byteValue08 == 0 || var1.byteValue08 == 1)) {
                        gameIntegerValue125 = 1000;
                        this.processActorAction(var1.byteValue08 == 0 ? 9 : 18);
                     }

                     if ((var2 = var1.byteValue10 + var2) > 128) {
                        var2 = 125;
                     }

                     if (var2 < -127) {
                        var2 = 0;
                     }

                     var1.byteValue10 = (sbyte)var2;
                     if (var1.byteValue10 < 0) {
                        var1.byteValue10 = 0;
                     } else if (var1.byteValue10 > var1.byteValue11) {
                        var1.byteValue10 = var1.byteValue11;
                     }

                     if (gameBooleanFlag61
                        && this.gameActorGroupReference01 != null
                        && this.gameActorGroupReference01.byteValue05 == 3
                        && this.gameActorStateReference03 != null
                        && this.gameActorStateReference03.booleanFlag01
                        && var1 == this.gameActorGroupReference01.actorStateReference01
                        && var1.byteValue10 <= 0) {
                        var1.byteValue10 = 1;
                     }

                     if (var1.byteValue10 <= 0) {
                        this.faceActorTowardPosition(var1, 3);
                     }
                  }
               }
            }
         }
      }
   }

   // $VF: renamed from: d (int) void
   public void activateActorRuntimeState(int var1) {
      gameBooleanFlag55 = true;
      if (var1 >= 0 && var1 < this.gameShortValue05) {
         this.gameClass9ReferenceArray01[var1].booleanFlag02 = true;
      }
   }

   // $VF: renamed from: e (int) void
   public void deactivateActorRuntimeState(int var1) {
      gameBooleanFlag55 = true;
      if (var1 >= 0 && var1 < this.gameShortValue05) {
         this.gameClass9ReferenceArray01[var1].booleanFlag02 = false;
      }
   }

   // $VF: renamed from: d (int, int) void
   public void enableActorActionFlag(int var1, int var2) {
      gameBooleanFlag55 = true;
      if (var1 >= 0 && var1 < this.gameShortValue05) {
         if (var2 >= 0 && var2 < this.gameClass9ReferenceArray01[var1].byteValue04) {
            this.gameClass9ReferenceArray01[var1].actorFlagsReferenceArray01[var2].booleanFlag01 = true;
         }
      }
   }

   // $VF: renamed from: e (int, int) void
   public void disableActorActionFlag(int var1, int var2) {
      gameBooleanFlag55 = true;
      if (var1 >= 0 && var1 < this.gameShortValue05) {
         if (var2 >= 0 && var2 < this.gameClass9ReferenceArray01[var1].byteValue04) {
            this.gameClass9ReferenceArray01[var1].actorFlagsReferenceArray01[var2].booleanFlag01 = false;
            if (var1 == 224) {
               this.gameClass9ReferenceArray01[var1].booleanFlag02 = false;
            }
         }
      }
   }

   // $VF: renamed from: L () void
   public void clearActorStatusEffects() {
      gameByteValue10 = 0;
      gameByteValue11 = 0;
      this.gameByteValue09 = 2;
      gameByteValue07 = 2;
      gameShortValue01 = 0;
   }

   // $VF: renamed from: a (boolean, int, int) void
   public void configureActorStatusEffect(bool var1, int var2, int var3) {
      this.gameClass19Reference01.byteValue01 = 8;
      this.gameClass19Reference01.booleanFlag01 = var1;
      this.gameClass19Reference01.booleanFlag02 = false;
      this.gameClass19Reference01.shortValue01 = (short)var2;
      this.gameClass19Reference01.shortValue02 = 0;
      this.addActorStatusEffect(this.gameClass19Reference01);
   }

   // $VF: renamed from: a (i) void
   public void addActorStatusEffect(ActorStatus var1) {
      this.gameClass19ReferenceArray02[gameByteValue11] = var1;
      gameByteValue11 = (sbyte)((gameByteValue11 + 1) % 20);
      if (this.gameByteValue09 == 2) {
         this.gameByteValue09 = 0;
      }
   }

   // $VF: renamed from: M () void
   public void advanceActorStatusEffects() {
      if ((gameByteValue10 = (sbyte)((gameByteValue10 + 1) % 20)) == gameByteValue11) {
         this.gameByteValue09 = 2;
      } else {
         this.gameByteValue09 = 0;
      }
   }

   // $VF: renamed from: N () void
   public void updateActorStatusEffects() {
      if (!isGameInputPressed(3)) {
         if (this.gameByteValue09 == 1) {
            ActorStatus var1;
            sbyte var2 = (var1 = this.gameClass19ReferenceArray02[gameByteValue10]).byteValue02;
            switch (var1.byteValue01) {
               case 0:
               case 1:
               case 2:
               case 3:
               case 4:
               case 5:
               case 6:
               case 7:
                  if (gameIntegerValue50 == 131) {
                     return;
                  }
                  break;
               case 8:
                  if (gameByteValue07 != 2) {
                     return;
                  }
                  break;
               case 9:
                  ActorState var3;
                  switch (var2) {
                     case 0:
                        var3 = this.gameActorGroupReference03.actorStateReference01;
                        break;
                     case 1:
                        var3 = this.gameActorGroupReference04.actorStateReference01;
                        break;
                     case 2:
                        var3 = this.gameActorGroupReference01.actorStateReference01;
                        break;
                     case 3:
                        var3 = this.gameActorStateReference01;
                        break;
                     case 4:
                        var3 = this.gameActorStateReference02;
                        break;
                     case 5:
                     case 6:
                     default:
                        this.advanceActorStatusEffects();
                        return;
                     case 7:
                        var3 = this.gameActorStateReference05; break;
                  }

                  if (var3.byteValue12 != -1 || var3.byteValue13 != -1) {
                     return;
                  } goto case 10;
               case 10: break;
            }

            this.advanceActorStatusEffects();
         }
      }
   }

   // $VF: renamed from: O () void
   public void updateGameEffects() {
      if (!gameBooleanFlag29) {
         if (this.gameByteValue09 != 2) {
            this.updateActorStatusEffects();

            while (this.gameByteValue09 == 0) {
               this.gameByteValue09 = 1;
               ActorStatus var1;
               sbyte var2;
               if ((var2 = (var1 = this.gameClass19ReferenceArray02[gameByteValue10]).byteValue02) == 2) {
                  var2 = this.gameActorGroupReference01.actorStateReference01.byteValue08;
               }

               
               switch (var1.byteValue01) {
                  case 0:
                     short var12 = var1.shortValue02;
                     if (var1.shortValue01 != -1) {
                        if (this.gameActorGroupReference01.actorStateReference01.byteValue08 == 0) {
                           var12 = var1.shortValue01;
                        } else if (this.gameActorGroupReference01.actorStateReference01.byteValue08 == 1) {
                           var12 = var1.shortValue02;
                        }
                     }

                     short var5 = -1;
                     switch (this.gameByteValue04) {
                        case 0:
                           var5 = 316;
                           break;
                        case 1:
                           var5 = 348;
                           break;
                        case 2:
                           var5 = 355;
                           break;
                        case 3:
                           var5 = 362; break;
                     }

                     int var13;
                     string var6 = getStringResource(var13 = var5 + var12 / 5);
                     this.showGameMessage(0, var2, var6, 0);
                     break;
                  case 1:
                     switch ((sbyte)var1.shortValue01) {
                        case 2:
                        case 3:
                        case 4:
                        case 5:
                           if (this.gameActorGroupReference01.entitySnapshotReferenceArray01[(sbyte)var1.shortValue01].booleanFlag01) {
                              int var3 = (sbyte)var1.shortValue01;
                              switch (var3) {
                                 case 2:
                                    this.gameActorGroupReference01.byteArray01[1] = (sbyte)(this.gameActorGroupReference01.byteArray01[1] + 25);
                                    if (this.gameActorGroupReference01.byteArray01[1] > 100) {
                                       this.gameActorGroupReference01.byteArray01[1] = 100;
                                    }
                                    break;
                                 case 3:
                                    this.gameActorGroupReference01.byteArray01[2] = (sbyte)(this.gameActorGroupReference01.byteArray01[2] + 20);
                                    if (this.gameActorGroupReference01.byteArray01[2] > 100) {
                                       this.gameActorGroupReference01.byteArray01[2] = 100;
                                    }
                                    break;
                                 case 4:
                                    this.gameActorGroupReference01.byteArray01[3] = (sbyte)(this.gameActorGroupReference01.byteArray01[3] + 20);
                                    if (this.gameActorGroupReference01.byteArray01[3] > 100) {
                                       this.gameActorGroupReference01.byteArray01[3] = 100;
                                    }
                                    break;
                                 case 5:
                                    this.gameActorGroupReference01.byteArray01[4] = (sbyte)(this.gameActorGroupReference01.byteArray01[4] + 10);
                                    if (this.gameActorGroupReference01.byteArray01[4] > 100) {
                                       this.gameActorGroupReference01.byteArray01[4] = 100;
                                    } break;
                              }

                              this.gameStringBufferReference01.setLength(0);
                              var3 = (sbyte)27;
                              this.gameStringBufferReference01.append(JString.New(getStringResource(27)));
                              this.gameStringBufferReference01.append(' ');
                              var3 = this.gameActorGroupReference01.entitySnapshotReferenceArray01[var1.shortValue01].integerValue01;
                              this.gameStringBufferReference01.append(getStringResource(this.gameActorGroupReference01.entitySnapshotReferenceArray01[var1.shortValue01].integerValue01));
                              this.gameStringBufferReference01.append('.');
                              this.showGameMessage(2, (sbyte)var1.shortValue01, this.gameStringBufferReference01.toString(), 0);
                              goto label115_brk;
                           } goto default;
                        default:
                           this.setActiveActorGroup(var1.shortValue01);
                           goto label115_brk;
                     } goto case 2;
                  case 2:
                     this.setActiveActorGroupDirection((sbyte)var1.shortValue01);
                     if (var1.shortValue02 >= 0) {
                     }
                     break;
                  case 3:
                     short var4 = var1.shortValue01;
                     ActorState var9 = this.gameActorGroupReference01.actorStateReference01;
                     this.applyActorStatus(var9, var4, true);
                     if (var1.shortValue02 >= 0) {
                     }
                     break;
                  case 4:
                     this.deactivateActorRuntimeState(var1.shortValue01);
                     if (var1.shortValue02 >= 0) {
                     }
                     break;
                  case 5:
                     this.activateActorRuntimeState(var1.shortValue01);
                     if (var1.shortValue02 >= 0) {
                     }
                     break;
                  case 6:
                     this.disableActorActionFlag(var1.shortValue01, var1.shortValue02);
                     break;
                  case 7:
                     this.enableActorActionFlag(var1.shortValue01, var1.shortValue02);
                     break;
                  case 8:
                     gameByteValue07 = 0;
                     gameShortValue01 = var1.shortValue01;
                     break;
                  case 9:
                     ActorState var8;
                     switch (var2) {
                        case 0:
                           var8 = this.gameActorGroupReference03.actorStateReference01;
                           break;
                        case 1:
                           var8 = this.gameActorGroupReference04.actorStateReference01;
                           break;
                        case 2:
                           var8 = this.gameActorGroupReference01.actorStateReference01;
                           break;
                        case 3:
                           var8 = this.gameActorStateReference01;
                           break;
                        case 4:
                           var8 = this.gameActorStateReference02;
                           break;
                        case 5:
                        case 6:
                        default:
                           continue;
                        case 7:
                           var8 = this.gameActorStateReference05; break;
                     }

                     this.moveActorToTile(var8, var1.shortValue01, var1.shortValue02);
                     break;
                  case 10:
                     this.setActorAnimationPair(var1.shortValue01, var1.shortValue02); break;
               } label115_brk:;

               this.updateActorStatusEffects();
            }

            int var7 = 0;

            while (gameByteValue07 != 2 && var7 != 1) {
               if ((var7 = gameClass18Reference01.updateGameMode()) == 0) {
                  var7 = gameClass12Reference01.getElapsedGameTime();
               }

               if (var7 == 0) {
                  var7 = gameClass10Reference01.getElapsedGameTime();
               }

               if (var7 == 0) {
                  setGamePaused(true);
                  break;
               }
            }
         }
      }
   }

   // $VF: renamed from: f (int, int) void
   public void setActorAnimationPair(int var1, int var2) {
      this.activateActorRuntimeState(var1);
      this.deactivateActorRuntimeState(var2);
   }

   // $VF: renamed from: c (boolean) void
   public static void setGamePaused(bool var0) {
      if (gameByteValue07 != 2) {
         if (var0) {
            gameByteValue07 = 2;
            gameShortValue01 = 0;
         } else if (gameByteValue07 != 0 && gameByteValue07 != 3) {
            gameByteValue07 = 0;
            gameShortValue01++;
         } else {
            gameByteValue07 = 1;
         }
      }
   }

   // $VF: renamed from: f (int) void
   public void saveEntitySnapshot(int var1) {
      EntitySnapshot var2 = this.gameActorGroupReference01.entitySnapshotReferenceArray01[0];

      for (int var3 = 0; var3 < var2.shortValue02; var3++) {
         if (!this.gameClass19ReferenceArray01[var2.tileCoordinateReferenceArray01[var3].byteValue02].booleanFlag02
            && this.gameClass19ReferenceArray01[var2.tileCoordinateReferenceArray01[var3].byteValue02].byteValue01 != 8
            && var2.tileCoordinateReferenceArray01[var3].byteValue01 == var1
            && this.gameClass19ReferenceArray01[var2.tileCoordinateReferenceArray01[var3].byteValue02].booleanFlag01) {
            this.gameClass19ReferenceArray01[var2.tileCoordinateReferenceArray01[var3].byteValue02].booleanFlag02 = true;
         }
      }
   }

   // $VF: renamed from: a (int, int, boolean) boolean
   public bool restoreEntitySnapshot(int var1, int var2, bool var3) {
      EntitySnapshot var4 = this.gameActorGroupReference01.entitySnapshotReferenceArray01[var1];
      bool var6 = false;
      bool var7 = false;

      for (int var8 = 0; var8 < var4.shortValue02; var8++) {
         ActorStatus var5;
         if (!(var5 = this.gameClass19ReferenceArray01[var4.tileCoordinateReferenceArray01[var8].byteValue02]).booleanFlag02 && var4.tileCoordinateReferenceArray01[var8].byteValue01 == var2) {
            var6 = true;
            if (!var3) {
               if (var5.byteValue01 == 8 && var5.shortValue01 == 190) {
                  gameIntegerValue123 = 1;
               } else if (var2 == 499) {
                  gameIntegerValue123 = 1;
               } else if (var2 == 175) {
                  gameIntegerValue123 = 1;
               } else {
                  gameIntegerValue123 = var5.byteValue01;
               }
               break;
            }

            this.addActorStatusEffect(var5);
            if (!var5.booleanFlag01) {
               var5.booleanFlag02 = true;
            }

            if (this.gameClass9ReferenceArray01[var2].booleanFlag01) {
               if (var5.byteValue01 == 0) {
                  this.processActorAction(11);
               }

               if (var5.byteValue01 == 4) {
                  this.processActorAction(12);
               }
            }

            if (this.gameByteValue04 == 0 && var1 == 0 && (var2 == 147 || var2 == 497) && (var5.byteValue01 == 4 || var5.byteValue01 == 5)) {
               this.processActorAction(19);
            }

            if (var2 == 522 && var1 == 0) {
               this.processActorAction(11);
            }

            if (var5.byteValue01 == 2) {
               var7 = true;
            } else if (var5.byteValue01 == 10) {
               this.processActorAction(19);
            }
         }
      }

      if (!var3) {
         return var6;
      } else {
         if (this.gameActorGroupReference01 == this.gameActorGroupReference03) {
            var3 = false;
         } else {
            var3 = true;
         }

         if (!var6) {
            if (var1 == 0) {
               short var11 = 0;
               short var13 = 0;
               if (this.gameByteValue04 == 0) {
                  var11 = 547;
                  var13 = 619;
               } else if (this.gameByteValue04 == 1) {
                  var11 = 691;
                  var13 = 748;
               } else if (this.gameByteValue04 == 2) {
                  var11 = 805;
                  var13 = 839;
               } else if (this.gameByteValue04 == 3) {
                  var11 = 873;
                  var13 = 887;
               }

               short var10000 = !var3 ? var11 : var13;
               short var10 = !var3 ? var11 : var13;
               if (getStringResource(var10000 + this.gameClass9ReferenceArray01[var2].byteValue01) != null) {
                  int var12;
                  this.showGameMessage(0, 2, getStringResource(var12 = var10 + this.gameClass9ReferenceArray01[var2].byteValue01), 0);
               }
            }
         } else if (var1 == 13) {
            this.gameActorGroupReference01.byteValue02 = 0;
         }

         if (var7 && var1 != 0) {
            this.saveEntitySnapshot(var2);
         }

         return var6;
      }
   }

   // $VF: renamed from: P () void
   public void updatePlayerState() {
      if (this.gameActorGroupReference01.byteArray01[5] > 0) {
         if (this.gameActorGroupReference01.actorStateReference01.byteValue10 == this.gameActorGroupReference01.actorStateReference01.byteValue11) {
            sbyte var5 = 28;
            this.showGameMessage(0, 2, getStringResource(28), 0);
         } else {
            sbyte var3 = this.gameActorGroupReference01.actorStateReference01.byteValue11;
            ActorState var2 = this.gameActorGroupReference01.actorStateReference01;
            this.applyActorStatus(var2, var3, true);
            this.gameActorGroupReference01.byteArray01[5]--;
            this.processActorAction(17);
            if (this.gameActorGroupReference01.actorStateReference01.byteValue08 == 0) {
               sbyte var4 = 34;
               this.showGameMessage(0, 2, getStringResource(34), 0);
            } else {
               sbyte var1 = 35;
               this.showGameMessage(0, 2, getStringResource(35), 0);
            }
         }
      }
   }

   // $VF: renamed from: e (int) boolean
   public bool isActorGroupActive(int var1) {
      ActorGroup var4;
      if (this.gameByteValue03 == 1) {
         var4 = this.gameActorGroupReference04;
      } else {
         var4 = this.gameActorGroupReference03;
      }

      if (this.gameActorGroupReference01.byteValue02 == 6) {
         this.updatePlayerState();
         return false;
      } else {
         int var2 = this.gameActorGroupReference01.actorStateReference01.byteValue01;
         int var3 = this.gameActorGroupReference01.actorStateReference01.byteValue02;
         int var9 = var2;
         int var11 = var3;
         if (var1 == 1) {
            var2++;
         } else if (var1 == 3) {
            var3--;
         } else if (var1 == 5) {
            var2--;
         } else if (var1 == 7) {
            var3++;
         }

         if (var4.actorStateReference01.byteValue01 == var9 && var4.actorStateReference01.byteValue02 == var11 && var4.byteValue05 == this.gameActorGroupReference01.byteValue05) {
            if (this.gameByteMatrix02[this.gameActorGroupReference01.actorStateReference01.byteValue01][this.gameActorGroupReference01.actorStateReference01.byteValue02]
               != this.gameByteMatrix02[var4.actorStateReference01.byteValue01][var4.actorStateReference01.byteValue02]) {
               return false;
            } else {
               int var5 = var4.actorStateReference01.byteValue02;
               sbyte var13 = var4.actorStateReference01.byteValue01;
               sbyte var12 = this.gameActorGroupReference01.actorStateReference01.byteValue02;
               sbyte var10 = this.gameActorGroupReference01.actorStateReference01.byteValue01;
               if (var13 > var10 || var5 > var12) {
                  sbyte var6 = var10;
                  var10 = var13;
                  var13 = var6;
                  var6 = var12;
                  var12 = (sbyte)var5;
                  var5 = var6;
               }

               int var14 = var10 - var13;
               var5 = var12 - var5;
               if (var14 <= 1 && var5 <= 1 && (var14 <= 0 || var5 <= 0)
                  ? (var14 > 0 && this.gameShortMatrix01[var10][var12] != -1 ? true : var5 > 0 && this.gameShortMatrix02[var10][var12] != -1)
                  : false) {
                  return false;
               } else {
                  gameIntegerValue50 = 138;
                  this.gameShortValue14 = 0;
                  if (this.gameByteArray04[2 * this.gameActorGroupReference03.byteValue02 + 1] != 0) {
                     this.gameIntegerValue84 = this.gameByteArray04[2 * this.gameActorGroupReference03.byteValue02 + 1];
                     this.gameIntegerValue86 = this.getActorGroupCount(this.gameActorGroupReference03.byteValue02);
                  } else {
                     this.gameIntegerValue84 = 1;
                     this.gameIntegerValue86 = 1;
                  }

                  if (this.gameByteArray04[2 * this.gameActorGroupReference04.byteValue02 + 1] != 0) {
                     this.gameIntegerValue85 = this.gameByteArray04[2 * this.gameActorGroupReference04.byteValue02 + 1];
                     this.gameIntegerValue87 = this.getActorGroupCount(this.gameActorGroupReference04.byteValue02);
                  } else {
                     this.gameIntegerValue85 = 1;
                     this.gameIntegerValue87 = 1;
                  }

                  this.gameIntegerValue88 = 0;
                  this.gameIntegerValue89 = 0;
                  this.gameLongValue10 = this.gameLongValue06;
                  clearInteractionBounds();
                  clearCollisionBounds();
                  return true;
               }
            }
         } else if (this.gameActorGroupReference01.byteValue02 == 13 && this.gameActorGroupReference01 == this.gameActorGroupReference04) {
            short var8 = 140;
            this.showGameMessage(0, 1, getStringResource(140), 0);
            return true;
         } else {
            this.gameShortValue04 = (short)this.countActiveEntities(var9, var11, var1);
            if (this.gameShortValue04 < 0) {
               return false;
            } else if (!this.gameClass9ReferenceArray01[this.gameShortValue04].booleanFlag01
               && this.gameByteValue05 != this.gameByteMatrix02[this.gameClass9ReferenceArray01[this.gameShortValue04].byteValue02][this.gameClass9ReferenceArray01[this.gameShortValue04].byteValue03]) {
               return false;
            } else {
               bool var7 = this.restoreEntitySnapshot(this.gameActorGroupReference01.byteValue02, this.gameShortValue04, true);
               return gameIntegerValue50 == 131 ? true : var7;
            }
         }
      }
   }

   // $VF: renamed from: Q () void
   public void updateActorGroupsInWorld() {
      if (!gameBooleanFlag29) {
         for (int var2 = 0; var2 < 25; var2++) {
            if (this.gameActorStateReferenceArray01[var2].booleanFlag01 && this.gameActorStateReferenceArray01[var2].byteValue01 < this.gameByteValue12 && this.gameActorStateReferenceArray01[var2].byteValue02 < this.gameByteValue13) {
               ActorState var1 = this.gameActorStateReferenceArray01[var2];
               if (this.gameByteValue05 == this.gameByteMatrix02[var1.byteValue01][var1.byteValue02] || isActorAlive(var1)) {
                  sbyte var3 = var1.byteValue07;
                  if (gameByteCube01[var1.byteValue08][var1.byteValue05][2] != 0) {
                     if (var1.byteValue05 == 2 || var1.byteValue05 == 14) {
                        if (var3 == 1) {
                           var3 = 5;
                        } else if (var3 == 7) {
                           var3 = 3;
                        } else if (var3 == 5) {
                           var3 = 1;
                        } else if (var3 == 3) {
                           var3 = 7;
                        }
                     }

                     if (var1.booleanFlag02) {
                        if (!this.isTileBlocked(var1.byteValue01, var1.byteValue02, var3, (gameIntegerValue50 & 512) > 0)) {
                           if ((var1.byteValue08 != 3 || var1.byteValue05 != 5 || this.gameByteValue04 != 0)
                              && (
                                 var1.byteValue08 != 5
                                    || this.gameByteValue04 != 3
                                    || var1.byteValue02 != 3
                                    || var1.byteValue01 < 2 && var1.byteValue02 > 4
                                    || !this.gameClass9ReferenceArray01[21].booleanFlag02
                              )) {
                              var1.byteValue06 = var1.byteValue05;
                              this.faceActorTowardPosition(var1, 0);
                           }
                           continue;
                        }

                        var1.byteValue06 = -1;
                     }

                     if (var1.byteValue03 == gameByteCube01[var1.byteValue08][var1.byteValue05][2] && var1.byteValue03 != var1.byteValue04) {
                        if (this.findActorGroupAtTile(var2, var1.byteValue01, var1.byteValue02, var1.byteValue07, false) != -1) {
                           if (var1.byteValue08 != 11 && var1.byteValue08 != 8) {
                              this.faceActorTowardPosition(var1, 0);
                           } else {
                              this.updateActorState(var1, var3);
                           }
                        } else if (var1.byteValue08 != 2
                           && var1.byteValue08 != 4
                           && var1.byteValue08 != 6
                           && var1.byteValue08 != 0
                           && var1.byteValue08 != 1
                           && var1.byteValue08 != 3) {
                           this.updateActorState(var1, var3);
                        } else if (this.findActorGroupAtTile(var2, var1.byteValue01, var1.byteValue02, var1.byteValue07, true) != -1) {
                           this.faceActorTowardPosition(var1, 0);
                        } else {
                           this.updateActorState(var1, var3);
                        }

                        if ((var1.byteValue08 == 0 || var1.byteValue08 == 1)
                           && this.gameByteValue05 != this.gameByteMatrix02[this.gameActorGroupReference01.actorStateReference01.byteValue01][this.gameActorGroupReference01.actorStateReference01.byteValue02]) {
                           this.updateAllActors(true);
                        }
                     }
                  } else if ((var1.byteValue12 != -1 || var1.byteValue13 != -1) && var1.byteValue05 != 3 && var1.byteValue05 != 4 && var1.byteValue06 != -1) {
                     if (this.isTileBlocked(var1.byteValue01, var1.byteValue02, var3, false)) {
                        this.faceActorTowardPosition(var1, var1.byteValue06);
                        var1.byteValue06 = -1;
                     }
                  } else if ((var1.byteValue12 != -1 || var1.byteValue13 != -1) && var1.byteValue05 == 0) {
                     this.faceActorTowardPosition(var1, 1);
                  }

                  if (var1.byteValue03 != var1.byteValue04) {
                     switch (var1.byteValue08) {
                        case 0:
                        case 1:
                           if (var1.byteValue05 == 7 && var1.byteValue03 == 1) {
                              this.gameIntegerValue97++;
                              this.gameIntegerValue102++;
                              this.updatePlayerActorState();
                              int var4 = this.gameIntegerValue107;
                              if (this.gameIntegerValue63 < 0) {
                                 return;
                              }

                              if (var4 == 2) {
                                 this.gameIntegerValue100++;
                                 this.gameIntegerValue98++;
                                 ActorState var10001 = this.gameActorStateReferenceArray01[this.gameIntegerValue63];
                                 sbyte var41 = -10;
                                 ActorState var32 = var10001;
                                 this.applyActorStatus(var32, var41, true);
                                 this.initializeLevelTransition();
                              } else if (var4 == 0) {
                                 this.gameIntegerValue99++;
                                 int var8 = this.isActorNearPosition(this.gameActorGroupReference01.actorStateReference01, 0, 1) ? -27 : 0;
                                 this.findEntityFrameData(1, this.gameIntegerValue64, this.gameIntegerValue65, 54, var8);
                                 this.updatePlayerActorState();
                              } else {
                                 this.updatePlayerActorState();
                                 this.gameIntegerValue98++;
                                 ActorState var46 = this.gameActorStateReferenceArray01[this.gameIntegerValue63];
                                 sbyte var42 = -3;
                                 ActorState var33 = var46;
                                 this.applyActorStatus(var33, var42, true);
                                 this.initializeLevelTransition();
                              }

                              if (var4 != 0 && this.gameActorStateReferenceArray01[this.gameIntegerValue63].byteValue10 > 0 && isActorActionType(this.gameActorStateReferenceArray01[this.gameIntegerValue63].byteValue08)) {
                                 this.processActorAction(28 + (this.nextRandomInteger() & 1));
                              }
                           }
                           break;
                        case 2:
                        case 4:
                           if (var1.byteValue05 == 5
                              && (var1.byteValue03 == 4 || var1.byteValue03 == 3)
                              && (
                                 this.canActorReachTile(var1, this.gameActorGroupReference01.actorStateReference01.byteValue01, this.gameActorGroupReference01.actorStateReference01.byteValue02)
                                    || var1.byteValue01 == this.gameActorGroupReference01.actorStateReference01.byteValue01 && var1.byteValue02 == this.gameActorGroupReference01.actorStateReference01.byteValue02
                              )) {
                              this.findEntityFrameData(0, this.gameActorGroupReference01.actorStateReference01.byteValue01, this.gameActorGroupReference01.actorStateReference01.byteValue02, 54, 2);
                              sbyte var40 = -2;
                              ActorState var31 = this.gameActorGroupReference01.actorStateReference01;
                              this.applyActorStatus(var31, var40, true);
                           } goto case 3;
                        case 3:
                        case 7:
                        case 10:
                        case 11:
                        default:
                           break;
                        case 5:
                           if (var1.byteValue05 == 3 && var1.byteValue03 == 2) {
                              this.configureActorStatusEffect(true, 730, 0);
                           }

                           if (var1.byteValue05 == 5 && (var1.byteValue03 == 5 || var1.byteValue03 == 6)) {
                              if (this.canActorReachTile(var1, this.gameActorGroupReference01.actorStateReference01.byteValue01, this.gameActorGroupReference01.actorStateReference01.byteValue02)
                                 || var1.byteValue01 == this.gameActorGroupReference01.actorStateReference01.byteValue01 && var1.byteValue02 == this.gameActorGroupReference01.actorStateReference01.byteValue02) {
                                 this.findEntityFrameData(0, this.gameActorGroupReference01.actorStateReference01.byteValue01, this.gameActorGroupReference01.actorStateReference01.byteValue02, 54, 2);
                                 sbyte var39 = -2;
                                 ActorState var30 = this.gameActorGroupReference01.actorStateReference01;
                                 this.applyActorStatus(var30, var39, true);
                              }
                           } else if (var1.byteValue05 == 6
                              && var1.byteValue03 > 3
                              && var1.byteValue03 < 8
                              && var1.byteValue01 == this.gameActorGroupReference01.actorStateReference01.byteValue01
                              && var1.byteValue02 == this.gameActorGroupReference01.actorStateReference01.byteValue02) {
                              this.findEntityFrameData(0, this.gameActorGroupReference01.actorStateReference01.byteValue01, this.gameActorGroupReference01.actorStateReference01.byteValue02, 54, 2);
                              sbyte var38 = -2;
                              ActorState var29 = this.gameActorGroupReference01.actorStateReference01;
                              this.applyActorStatus(var29, var38, true);
                           }
                           break;
                        case 6:
                           if (var1.byteValue05 == 5
                              && (var1.byteValue03 == 2 || var1.byteValue03 == 3)
                              && (
                                 this.canActorReachTile(var1, this.gameActorGroupReference01.actorStateReference01.byteValue01, this.gameActorGroupReference01.actorStateReference01.byteValue02)
                                    || var1.byteValue01 == this.gameActorGroupReference01.actorStateReference01.byteValue01 && var1.byteValue02 == this.gameActorGroupReference01.actorStateReference01.byteValue02
                              )) {
                              this.findEntityFrameData(0, this.gameActorGroupReference01.actorStateReference01.byteValue01, this.gameActorGroupReference01.actorStateReference01.byteValue02, 54, 2);
                              sbyte var37 = -4;
                              ActorState var28 = this.gameActorGroupReference01.actorStateReference01;
                              this.applyActorStatus(var28, var37, true);
                           }
                           break;
                        case 8:
                           if ((var1.byteValue05 == 5 && var1.byteValue03 == 1 || var1.byteValue05 == 6 && var1.byteValue03 == 2)
                              && (
                                 this.canActorReachTile(var1, this.gameActorGroupReference01.actorStateReference01.byteValue01, this.gameActorGroupReference01.actorStateReference01.byteValue02)
                                    || var1.byteValue01 == this.gameActorGroupReference01.actorStateReference01.byteValue01 && var1.byteValue02 == this.gameActorGroupReference01.actorStateReference01.byteValue02
                              )) {
                              this.findEntityFrameData(0, this.gameActorGroupReference01.actorStateReference01.byteValue01, this.gameActorGroupReference01.actorStateReference01.byteValue02, 54, 2);
                              sbyte var6 = -2;
                              ActorState var5 = this.gameActorGroupReference01.actorStateReference01;
                              this.applyActorStatus(var5, var6, true);
                           }
                           break;
                        case 9:
                           if (var1.byteValue05 == 5 && var1.byteValue03 == 2) {
                              this.findActorRuntimeState(
                                 7, var1.byteValue01, var1.byteValue02, this.gameActorGroupReference01.actorStateReference01.byteValue01, this.gameActorGroupReference01.actorStateReference01.byteValue02, var1.byteValue07
                              );
                           } break;
                     }
                  }
               }
            }
         }

         if (gameIntegerValue50 != 646 && gameIntegerValue50 != 647) {
            for (int var14 = 0; var14 < 10; var14++) {
               if (this.gameClass22ReferenceArray01[var14].booleanFlag01) {
                  switch (this.gameClass22ReferenceArray01[var14].byteValue01) {
                     case 4:
                        int var21 = (int)(this.gameLongValue06 - this.gameClass22ReferenceArray01[var14].longValue01);
                        int var27 = this.gameClass22ReferenceArray01[var14].shortValue01
                           + var21 * (this.gameClass22ReferenceArray01[var14].shortValue03 - this.gameClass22ReferenceArray01[var14].shortValue01) / (this.gameClass22ReferenceArray01[var14].shortValue05 * 5);
                        int var12 = this.gameClass22ReferenceArray01[var14].shortValue02
                           + var21 * (this.gameClass22ReferenceArray01[var14].shortValue04 - this.gameClass22ReferenceArray01[var14].shortValue02) / (this.gameClass22ReferenceArray01[var14].shortValue05 * 5);
                        int var22;
                        var21 = 20 - var21 * var21 * 20 / ((var22 = this.gameClass22ReferenceArray01[var14].shortValue05 * 5) * var22);
                        this.gameClass22ReferenceArray01[var14].entityFrameDataReference01.shortValue01 = (short)var27;
                        this.gameClass22ReferenceArray01[var14].entityFrameDataReference01.shortValue02 = (short)var12;
                        this.gameClass22ReferenceArray01[var14].entityFrameDataReference01.shortValue03 = (short)var21;
                        if (this.gameClass22ReferenceArray01[var14].entityFrameDataReference01.shortValue03 <= 0) {
                           this.findEntityFrameData(37 + this.gameByteValue21, this.gameClass22ReferenceArray01[var14].integerValue01, this.gameClass22ReferenceArray01[var14].integerValue02, 0, 0);
                           this.gameClass22ReferenceArray01[var14].booleanFlag01 = false;

                           for (int var13 = 1; var13 < 25; var13++) {
                              if (this.gameActorStateReferenceArray01[var13].booleanFlag01
                                 && this.gameActorStateReferenceArray01[var13].byteValue05 != 3
                                 && this.gameActorStateReferenceArray01[var13].byteValue05 != 4
                                 && absoluteValue(this.gameIntegerValue64 - this.gameActorStateReferenceArray01[var13].byteValue01) <= 1
                                 && absoluteValue(this.gameIntegerValue65 - this.gameActorStateReferenceArray01[var13].byteValue02) <= 1) {
                                 this.gameIntegerValue98++;
                                 if (this.gameActorStateReferenceArray01[var13].byteValue08 != 1 && this.gameActorStateReferenceArray01[var13].byteValue08 != 0) {
                                    ActorState var47 = this.gameActorStateReferenceArray01[var13];
                                    sbyte var44 = -20;
                                    ActorState var35 = var47;
                                    this.applyActorStatus(var35, var44, true);
                                    if (this.gameActorStateReferenceArray01[var13].byteValue08 == 5) {
                                       try {
                                          if (this.gameActorStateReferenceArray01[var13].byteValue10 > 0
                                             && this.gameByteMatrix02[this.gameActorStateReferenceArray01[var13].byteValue01][this.gameActorStateReferenceArray01[var13].byteValue02 - 1] == this.gameByteValue05
                                             && this.gameByteMatrix02[this.gameActorStateReferenceArray01[var13].byteValue01][this.gameActorStateReferenceArray01[var13].byteValue02 + 1] == this.gameByteValue05
                                             && this.gameByteMatrix02[this.gameActorStateReferenceArray01[var13].byteValue01 - 1][this.gameActorStateReferenceArray01[var13].byteValue02] == this.gameByteValue05
                                             && this.gameByteMatrix02[this.gameActorStateReferenceArray01[var13].byteValue01 + 1][this.gameActorStateReferenceArray01[var13].byteValue02] == this.gameByteValue05) {
                                             this.faceActorTowardPosition(this.gameActorStateReferenceArray01[var13], 14);
                                          }
                                       } catch (System.Exception var7) {
                                       }
                                    }

                                    if (this.gameActorStateReferenceArray01[var13].byteValue08 == 9 && this.gameByteValue21 == 1) {
                                       var47 = this.gameActorStateReferenceArray01[var13];
                                       var44 = -30;
                                       var35 = var47;
                                       this.applyActorStatus(var35, var44, true);
                                    }

                                    this.findEntityFrameData(0, this.gameActorStateReferenceArray01[var13].byteValue01, this.gameActorStateReferenceArray01[var13].byteValue02, 54, 2);
                                 }
                              }
                           }

                           if (gameBooleanFlag64) {
                              gameBooleanFlag64 = false;
                           } else {
                              this.processActorAction(13);
                           }
                        } goto case 5;
                     case 5:
                     case 6:
                     default:
                        break;
                     case 7:
                        int var18 = (int)(this.gameLongValue06 - this.gameClass22ReferenceArray01[var14].longValue01);
                        int var25 = this.gameClass22ReferenceArray01[var14].shortValue01
                           + var18 * (this.gameClass22ReferenceArray01[var14].shortValue03 - this.gameClass22ReferenceArray01[var14].shortValue01) / (this.gameClass22ReferenceArray01[var14].shortValue05 * 10);
                        int var10 = this.gameClass22ReferenceArray01[var14].shortValue02
                           + var18 * (this.gameClass22ReferenceArray01[var14].shortValue04 - this.gameClass22ReferenceArray01[var14].shortValue02) / (this.gameClass22ReferenceArray01[var14].shortValue05 * 10);
                        int var19;
                        var18 = 40 - var18 * var18 * 40 / ((var19 = this.gameClass22ReferenceArray01[var14].shortValue05 * 10) * var19);
                        this.gameClass22ReferenceArray01[var14].entityFrameDataReference01.shortValue01 = (short)var25;
                        this.gameClass22ReferenceArray01[var14].entityFrameDataReference01.shortValue02 = (short)var10;
                        this.gameClass22ReferenceArray01[var14].entityFrameDataReference01.shortValue03 = (short)var18;
                        var25 = this.getTileRowFromPixel(this.gameClass22ReferenceArray01[var14].entityFrameDataReference01.shortValue01, this.gameClass22ReferenceArray01[var14].entityFrameDataReference01.shortValue02);
                        var10 = this.getTileColumnFromPixel(this.gameClass22ReferenceArray01[var14].entityFrameDataReference01.shortValue01, this.gameClass22ReferenceArray01[var14].entityFrameDataReference01.shortValue02);
                        if (this.gameActorGroupReference01.actorStateReference01.byteValue01 == var25 && this.gameActorGroupReference01.actorStateReference01.byteValue02 == var10) {
                           this.gameClass22ReferenceArray01[var14].booleanFlag01 = false;
                           sbyte var43 = -2;
                           ActorState var34 = this.gameActorGroupReference01.actorStateReference01;
                           this.applyActorStatus(var34, var43, true);
                        }

                        if (this.gameClass22ReferenceArray01[var14].entityFrameDataReference01.shortValue03 <= 0) {
                           this.gameClass22ReferenceArray01[var14].booleanFlag01 = false;
                        }
                        break;
                     case 8:
                        int var15 = (int)(this.gameLongValue06 - this.gameClass22ReferenceArray01[var14].longValue01);
                        int var24 = this.gameClass22ReferenceArray01[var14].shortValue01
                           + var15 * (this.gameClass22ReferenceArray01[var14].shortValue03 - this.gameClass22ReferenceArray01[var14].shortValue01) / (this.gameClass22ReferenceArray01[var14].shortValue05 * 5);
                        int var9 = this.gameClass22ReferenceArray01[var14].shortValue02
                           + var15 * (this.gameClass22ReferenceArray01[var14].shortValue04 - this.gameClass22ReferenceArray01[var14].shortValue02) / (this.gameClass22ReferenceArray01[var14].shortValue05 * 5);
                        int var16;
                        var15 = 20 - var15 * var15 * 20 / ((var16 = this.gameClass22ReferenceArray01[var14].shortValue05 * 5) * var16);
                        this.gameClass22ReferenceArray01[var14].entityFrameDataReference01.shortValue01 = (short)var24;
                        this.gameClass22ReferenceArray01[var14].entityFrameDataReference01.shortValue02 = (short)var9;
                        this.gameClass22ReferenceArray01[var14].entityFrameDataReference01.shortValue03 = (short)var15;
                        if (this.gameClass22ReferenceArray01[var14].entityFrameDataReference01.shortValue03 <= 0) {
                           this.findEntityFrameData(39, this.gameClass22ReferenceArray01[var14].integerValue01, this.gameClass22ReferenceArray01[var14].integerValue02, 0, 0);
                           this.gameClass22ReferenceArray01[var14].booleanFlag01 = false;
                        } break;
                  }

                  this.gameClass22ReferenceArray01[var14].entityFrameDataReference01.byteValue02 = (sbyte)this.getTileRowFromPixel(
                     this.gameClass22ReferenceArray01[var14].entityFrameDataReference01.shortValue01, this.gameClass22ReferenceArray01[var14].entityFrameDataReference01.shortValue02
                  );
                  this.gameClass22ReferenceArray01[var14].entityFrameDataReference01.byteValue03 = (sbyte)this.getTileColumnFromPixel(
                     this.gameClass22ReferenceArray01[var14].entityFrameDataReference01.shortValue01, this.gameClass22ReferenceArray01[var14].entityFrameDataReference01.shortValue02
                  );
               }
            }
         }
      }
   }

   // $VF: renamed from: c (p, int) void
   public static void setActorFacingDirection(ActorState var0, int var1) {
      var1 = var1 + 8 & 7;
      var0.byteValue07 = (sbyte)var1;
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, byte, int, int) void
   public void drawSpriteEffect(Graphics var1, int var2, int var3, int var4) {
      SpriteResourceDecoder var10000 = gameSpriteDecoderReferenceArray06[1];
      int var10002 = var3 + 2;
      int var6 = var4 + 1;
      int var5 = var10002;
      var10000.drawSpriteFrameTransformed(var1, 0, var5, var6, 0, 0, 0);
      var10000 = gameSpriteDecoderReferenceArray06[1];
      var2 = 1 + this.gameActorGroupReference01.entitySnapshotReferenceArray01[var2].byteValue02;
      var10000.drawSpriteFrameTransformed(var1, var2, var5, var6, 0, 0, 0);
   }

   // $VF: renamed from: R () void
   public void resetLevelTransition() {
      this.gameIntegerValue106 = 0;
      this.gameIntegerValue107 = 0;
      this.gameIntegerValue108 = 3;
   }

   // $VF: renamed from: S () void
   public void initializeLevelTransition() {
      gameClass11Reference02.playAnimation(0, 1);
      if (this.gameActorStateReferenceArray01[this.gameIntegerValue63].byteValue08 != 11 && this.gameActorStateReferenceArray01[this.gameIntegerValue63].byteValue08 != 8) {
         int var6 = this.gameIntegerValue105 - (this.gameIntegerValue106 >> 8);
         int var5 = this.gameIntegerValue104;
         SpriteAnimation var4 = gameClass11Reference02;
         gameClass11Reference02.drawX = var5;
         var4.drawY = var6;
      } else {
         int var2 = this.gameIntegerValue105;
         int var1 = this.gameIntegerValue104;
         SpriteAnimation var3 = gameClass11Reference02;
         gameClass11Reference02.drawX = var1;
         var3.drawY = var2;
      }
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, int, int) void
   public void drawLevelTransition(Graphics var1, int var2, int var3) {
      int var4 = this.gameIntegerValue106 >> 8;
      if (this.gameIntegerValue106 < this.gameIntegerValue109) {
         this.gameIntegerValue107 = 0;
         this.gameIntegerValue108 = 3;
      } else if (this.gameIntegerValue106 < this.gameIntegerValue110) {
         this.gameIntegerValue107 = 1;
         this.gameIntegerValue108 = 1;
      } else if (this.gameIntegerValue106 < this.gameIntegerValue111) {
         this.gameIntegerValue107 = 2;
         this.gameIntegerValue108 = 2;
      } else if (this.gameIntegerValue106 < this.gameIntegerValue113) {
         this.gameIntegerValue107 = 1;
         this.gameIntegerValue108 = 1;
      } else if (this.gameIntegerValue106 < this.gameIntegerValue112) {
         this.gameIntegerValue107 = 0;
         this.gameIntegerValue108 = 3;
      } else {
         this.gameIntegerValue107 = 0;
         this.gameIntegerValue108 = 0;
      }

      if (this.gameActorStateReferenceArray01[this.gameIntegerValue63].byteValue08 == 11 && this.gameIntegerValue107 == 1) {
         this.gameIntegerValue107 = 2;
         this.gameIntegerValue108 = 2;
      }

      if (var2 == 0) {
         SpriteResourceDecoder var29 = gameSpriteDecoderReferenceArray06[0];
         var4 = this.gameIntegerValue105 - var4;
         var2 = this.gameIntegerValue104;
         var29.drawSpriteFrameTransformed(var1, var3, var2, var4, 0, 0, 0);
      } else {
         if (this.gameActorStateReferenceArray01[this.gameIntegerValue63].byteValue07 > 4) {
            SpriteResourceDecoder var10000 = gameSpriteDecoderReferenceArray06[0];
            int var10003 = this.gameIntegerArray04[2] + var4;
            int var8 = this.gameIntegerArray04[3];
            int var7 = var10003;
            var10000.drawSpriteFrameTransformed(var1, var3, var7, var8, 0, 0, 0);
            var10000 = gameSpriteDecoderReferenceArray06[0];
            int var10002 = var3 + 1;
            var10003 = this.gameIntegerArray04[0] - var4;
            var8 = this.gameIntegerArray04[1];
            var7 = var10003;
            int var6 = var10002;
            var10000.drawSpriteFrameTransformed(var1, var6, var7, var8, 0, 0, 0);
         } else {
            SpriteResourceDecoder var25 = gameSpriteDecoderReferenceArray06[0];
            int var34 = this.gameIntegerArray04[0] + var4;
            int var21 = this.gameIntegerArray04[1];
            int var17 = var34;
            var25.drawSpriteFrameTransformed(var1, var3, var17, var21, 0, 0, 0);
            var25 = gameSpriteDecoderReferenceArray06[0];
            int var30 = var3 + 1;
            var34 = this.gameIntegerArray04[2] - var4;
            var21 = this.gameIntegerArray04[3];
            var17 = var34;
            int var14 = var30;
            var25.drawSpriteFrameTransformed(var1, var14, var17, var21, 0, 0, 0);
         }

         SpriteResourceDecoder var27 = gameSpriteDecoderReferenceArray06[0];
         int var31 = var3 + 2;
         int var36 = this.gameIntegerArray04[4];
         int var23 = this.gameIntegerArray04[5] + var4;
         int var19 = var36;
         int var15 = var31;
         var27.drawSpriteFrameTransformed(var1, var15, var19, var23, 0, 0, 0);
         var27 = gameSpriteDecoderReferenceArray06[0];
         var31 = var3 + 3;
         var36 = this.gameIntegerArray04[6];
         var4 = this.gameIntegerArray04[7] - var4;
         var3 = var36;
         var2 = var31;
         var27.drawSpriteFrameTransformed(var1, var2, var3, var4, 0, 0, 0);
      }
   }

   // $VF: renamed from: d (javax.microedition.lcdui.Graphics) void
   public void drawSceneBackground(Graphics var1) {
      switch (gameIntegerValue50) {
         case 646:
            GameCanvas var10;
            if ((var10 = this).gameIntegerValue106 == 0) {
               ActorState var3;
               sbyte var4 = (var3 = var10.gameActorStateReferenceArray01[var10.gameIntegerValue63]).byteValue08;
               bool var5 = var3.byteValue07 > 4;
               int var6 = gameByteCube01[var3.byteValue08][var3.byteValue05][4];
               if (gameByteCube01[var3.byteValue08][var3.byteValue05][3] == 4) {
                  if (var4 != 9) {
                     var6 = AnimationTables.integerTensor01[var3.byteValue08][var6][var10.isActorNearPosition(var3, 0, 1) ? 0 : 1][var3.byteValue03];
                  } else {
                     sbyte var13 = gameByteCube01[var3.byteValue08][var3.byteValue05][5];
                     var6 = AnimationTables.integerCube01[var13][var10.isActorNearPosition(var3, 0, 1) ? 0 : 1][var3.byteValue03];
                  }
               } else {
                  var6 = AnimationTables.integerCube02[var6][var5 ? 8 - var3.byteValue07 : var3.byteValue07][var3.byteValue03];
               }

               if (var4 != 11 && var4 != 8) {
                  if (var3.byteValue08 == 4) {
                     var4 = 2;
                  }

                  int[] var16 = new int[8];
                  if (var4 != 9) {
                     var16 = gameSpriteDecoderReferenceArray02[var4].copySpritePalette(var6, var16, 0, 0);
                  } else {
                     var16 = gameSpriteDecoderReferenceArray04[var3.byteValue09].copySpritePalette(var6, var16, 0, 0);
                  }

                  if (var16 != null) {
                     var10.gameIntegerValue104 = var10.getTilePixelX(var3.byteValue01, var3.byteValue02) - var10.gameIntegerValue53 + (var5 ? -var16[0] + 108 : var16[0]);
                     sbyte var21 = var3.byteValue02;
                     sbyte var19 = var3.byteValue01;
                     var10.gameIntegerValue105 = (var21 + var19) * 27 - var10.gameIntegerValue54 + var16[1];
                     var10.gameIntegerValue109 = 4608;
                     var10.gameIntegerValue110 = var16[1] - var16[3] << 8;
                     var10.gameIntegerValue111 = var16[1] - var16[5] << 8;
                     if (var4 != 5 && var4 != 6) {
                        var10.gameIntegerValue113 = var10.gameIntegerValue111;
                        var10.gameIntegerValue112 = var10.gameIntegerValue111;
                     } else {
                        if (var4 != 6) {
                           var10.gameIntegerValue113 = var16[1] - var16[7] - 18 << 8;
                        } else {
                           var10.gameIntegerValue113 = var16[1] - var16[7] << 8;
                        }

                        var10.gameIntegerValue112 = var16[1] - var16[7] << 8;
                     }

                     var10.gameBooleanFlag56 = true;
                  } else {
                     var10.gameBooleanFlag56 = false;
                     gameIntegerValue50 = 900;
                  }
               } else {
                  int[] var7 = new int[2];
                  if ((var7 = gameSpriteDecoderReferenceArray02[var4].copySpritePalette(var6, var7, 0, 0)) != null) {
                     var10.gameIntegerValue104 = var10.getTilePixelX(var3.byteValue01, var3.byteValue02) - var10.gameIntegerValue53 + (var5 ? -var7[0] + 108 : var7[0]);
                     sbyte var9 = var3.byteValue02;
                     sbyte var8 = var3.byteValue01;
                     var10.gameIntegerValue105 = (var9 + var8) * 27 - var10.gameIntegerValue54 + var7[1];
                     var10.gameIntegerArray04 = new int[8];

                     for (int var14 = 0; var14 < 8; var14++) {
                        if (var14 % 2 == 0) {
                           var10.gameIntegerArray04[var14] = var10.getTilePixelX(var3.byteValue01, var3.byteValue02) - var10.gameIntegerValue53 + (var5 ? -var7[0] + 108 : var7[0]);
                        } else {
                           var9 = var3.byteValue02;
                           var8 = var3.byteValue01;
                           var10.gameIntegerArray04[var14] = (var9 + var8) * 27 - var10.gameIntegerValue54 + var7[1];
                        }
                     }

                     if (var4 == 8) {
                        var10.gameIntegerArray04[0] = var10.gameIntegerArray04[0] - (var5 ? -35 : 35);
                        var10.gameIntegerArray04[2] = var10.gameIntegerArray04[2] + (var5 ? -35 : 35);
                        var10.gameIntegerArray04[5] = var10.gameIntegerArray04[5] - 35;
                        var10.gameIntegerArray04[7] = var10.gameIntegerArray04[7] + 35;
                        var10.gameIntegerValue109 = 3840;
                        var10.gameIntegerValue110 = 7680;
                        var10.gameIntegerValue111 = 8960;
                     } else {
                        var10.gameIntegerArray04[0] = var10.gameIntegerArray04[0] - (var5 ? -24 : 24);
                        var10.gameIntegerArray04[2] = var10.gameIntegerArray04[2] + (var5 ? -24 : 24);
                        var10.gameIntegerArray04[5] = var10.gameIntegerArray04[5] - 24;
                        var10.gameIntegerArray04[7] = var10.gameIntegerArray04[7] + 24;
                        var10.gameIntegerValue109 = 3072;
                        var10.gameIntegerValue110 = 4608;
                        var10.gameIntegerValue111 = 6144;
                     }

                     var10.gameIntegerValue113 = var10.gameIntegerValue111;
                     var10.gameIntegerValue112 = var10.gameIntegerValue111;
                     var10.gameBooleanFlag56 = true;
                  } else {
                     var10.gameBooleanFlag56 = false;
                     gameIntegerValue50 = 900;
                  }
               }
            }

            if (!this.gameBooleanFlag56) {
               return;
            }

            sbyte var11 = this.gameActorStateReferenceArray01[this.gameIntegerValue63].byteValue08;
            if (this.gameActorStateReferenceArray01[this.gameIntegerValue63].byteValue08 != 11 && var11 != 8) {
               if (!gameBooleanFlag29) {
                  this.gameIntegerValue106 += 512;
               }

               this.drawLevelTransition(var1, 0, 9 + this.gameIntegerValue108);
               return;
            }

            if (!gameBooleanFlag29) {
               this.gameIntegerValue106 += 196;
            }

            this.drawLevelTransition(var1, 1, 14 + (this.gameIntegerValue108 << 2));
            break;
         case 647:
            if (this.gameIntegerValue108 == 0) {
               sbyte var2 = this.gameActorStateReferenceArray01[this.gameIntegerValue63].byteValue08;
               if (this.gameActorStateReferenceArray01[this.gameIntegerValue63].byteValue08 != 11 && var2 != 8) {
                  this.drawLevelTransition(var1, 0, 9 + this.gameIntegerValue108);
                  if ((this.gameLongValue06 - this.gameLongValue07) % 200L > 100L && !gameBooleanFlag29) {
                     this.drawLevelTransition(var1, 0, 13 + this.gameIntegerValue108);
                  }
               } else {
                  this.drawLevelTransition(var1, 1, 14 + (this.gameIntegerValue108 << 2));
                  if ((this.gameLongValue06 - this.gameLongValue07) % 200L > 100L) {
                     this.drawLevelTransition(var1, 1, 30 + (this.gameIntegerValue108 << 2));
                     return;
                  }
               }
            } break;
      }
   }

   // $VF: renamed from: e (javax.microedition.lcdui.Graphics) void
   public void drawSceneForeground(Graphics var1) {
      if (gameIntegerValue50 == 131 || gameIntegerValue50 == 137 || gameIntegerValue50 == 139) {
         int var2;
         if (gameIntegerValue67 != 1 && gameIntegerValue67 != 3) {
            var2 = 1;
            if (gameShortValue01 >= 180 && gameShortValue01 <= 182) {
               var2 = 0;
            }
         } else {
            var2 = 0;
         }

         if (gameIntegerValue50 == 139 || gameIntegerValue67 != 1 && (gameShortValue01 == 550 || gameShortValue01 == 670)) {
            var2 = 1;
         }

         int var4 = 0;
         int var5 = gameIntegerValue67 == 0 ? 128 : 85;
         int var3 = gameSpriteDecoderReferenceArray09[1].getSpriteHeight(21);
         if (gameIntegerValue67 != 1) {
            var2 = var2 != 0 ? gameIntegerValue42 - 6 - var5 : var3 + 26;
         } else {
            var2 = var2 != 0 ? gameIntegerValue42 - 6 - var5 : 26;
         }

         this.drawTileLayer(var1, 6, var2, gameIntegerValue41 - 12, var5, 6);
         if (gameIntegerValue67 != 1) {
            gameClass11Reference03.playAnimation(0, -1);
            int var10001 = gameIntegerValue41 - 6;
            int var7 = var2 + -40;
            int var6 = var10001;
            SpriteAnimation var101 = gameClass11Reference03;
            gameClass11Reference03.drawX = var6;
            var101.drawY = var7;
            if (gameIntegerValue50 != 137 && !gameBooleanFlag29) {
               if (gameIntegerValue50 == 139) {
                  SpriteAnimation var102 = gameClass11Reference03;
                  gameClass11Reference03.drawX = 190;
                  var102.drawY = 50;
               }

               gameClass11Reference03.drawCurrentFrame();
            }
         }

         if (!gameBooleanFlag29 && gameIntegerValue67 != 1 && gameIntegerValue50 != 137) {
            sbyte var168 = 3;
            addCollisionBounds(0, 0, 360, 640, 1003);
            if (!gameBooleanFlag29) {
               gameBooleanFlag10 = true;
            }
         }

         int var103 = this.gameByteValue08;
         if (this.gameByteValue08 == 2) {
            var103 = this.gameActorGroupReference01.actorStateReference01.byteValue08;
         } else if (var103 > 2) {
            var103--;
         }

         if (gameIntegerValue67 == 0) {
            if (var103 < 5) {
               var4 = 85;
               SpriteResourceDecoder var10000 = gameSpriteDecoderReferenceArray06[3];
               int var10003 = gameIntegerValue41 - 6 - 85;
               int var9 = var2 + var5;
               int var8 = var10003;
               var10000.drawSpriteFrameTransformed(var1, var103, var8, var9, 0, 0, 0);
            }
         } else if (gameIntegerValue67 == 2) {
            var4 = 47;
            this.drawSpriteEffect(var1, this.gameByteValue08, gameIntegerValue41 - 6 - 47 - 1, var2 + var5 - 42 - 4);
         } else if (gameIntegerValue67 == 1) {
            SpriteResourceDecoder var151 = gameSpriteDecoderReferenceArray06[3];
            int var176 = gameIntegerValue41 - 6 - 85;
            int var128 = var2 + var5;
            int var126 = var176;
            var151.drawSpriteFrameTransformed(var1, var103, var126, var128, 0, 0, 0);
            short var96 = 255;
            short var95 = 255;
            short var94 = 255;
            var1.setColor(var94, var95, var96);
            if (gameBooleanFlag63) {
               var2 += gameSpriteDecoderReferenceArray09[1].getSpriteHeight(15) / 4;
            }

            gameIntegerValue34 = gameSpriteDecoderReferenceArray09[1].getSpriteWidth(15) + 2;
            int var93;
            string var10002 = getStringResource(var93 = this.gameActorGroupReference01.entitySnapshotReferenceArray01[this.gameIntegerValue122 >= 0 ? this.gameIntegerValue122 : this.gameByteArray04[2 * this.gameIntegerValue51]].integerValue01);
            int var10004 = 8 + gameIntegerValue34;
            int var10005 = var2 + 2 + var5 / 3 - this.gameByteValue02 / 2;
            int var10006 = 8 + gameIntegerValue34;
            int var69 = var2 + this.gameIntegerValue68;
            int var67 = var10006;
            int var66 = var10005;
            int var65 = var10004;
            bool var64 = false;
            string var119 = var10002;
            int var79 = measureTextWidth(gameSpriteDecoderReferenceArray08[0], var119);
            int var75 = var1.getClipX();
            int var76 = var1.getClipY();
            int var77 = var1.getClipWidth();
            int var78 = var1.getClipHeight();
            if (var79 > 180) {
               this.gameIntegerValue114--;
               if (this.gameIntegerValue114 < -(var79 + 60)) {
                  this.gameIntegerValue114 = 0;
               }

               setGraphicsClip(var1, var67, var2, 180, var69 - var2);
               var151 = gameSpriteDecoderReferenceArray08[0];
               int var83 = var65 + this.gameIntegerValue114;
               var151.drawBitmapTextLine(var1, var119, var83, var66, 4, true);
               var151 = gameSpriteDecoderReferenceArray08[0];
               int var88 = var65 + this.gameIntegerValue114 + var79 + 60;
               var151.drawBitmapTextLine(var1, var119, var88, var66, 4, true);
            } else {
               var151 = gameSpriteDecoderReferenceArray08[0];
               int var92 = var65 + 90;
               var151.drawBitmapTextLine(var1, var119, var92, var66, 1, true);
            }

            setGraphicsClip(var1, var75, var76, var77, var78);
            bool var155 = true;
            var2 += var5 + 6 + 2;
            var5 = gameIntegerValue42 - 26 - var2;
            var4 = 0;
            this.drawTileLayer(var1, 6, var2, gameIntegerValue41 - 12, var5, 6);
         } else if (gameIntegerValue67 == 3) {
            sbyte var149 = 0;
            sbyte var147 = 0;
            sbyte var145 = 0;
            var1.setColor(var145, var147, var149);
            fillRectangle(var1, 0, 0, gameIntegerValue41, gameIntegerValue42);
            var2 = 10;
            var5 = gameIntegerValue42 - 20;
            var4 = 0;
            if (gameShortValue01 == 0 && gameByteValue07 == 1) {
               if (this.gameIntegerValue66 == 0 || this.gameIntegerValue66 == 1) {
                  var2 = 180;
                  var5 = gameIntegerValue42 - 60;
                  var4 = 0;
               } else if (this.gameIntegerValue66 == 1) {
                  var2 = 80;
                  var5 = gameIntegerValue42 - 80;
                  var4 = 0;
               }

               this.drawBlinkingIndicator(gameGraphicsReference02, 520);
            }
         }

         int var98 = var2 + 6;
         this.gameIntegerValue68 = var5 - 12;
         if (gameIntegerValue67 == 1) {
            var98 += gameIntegerValue37;
            this.gameIntegerValue68 = this.gameIntegerValue68 - 2 * gameIntegerValue37;
         }

         this.gameIntegerValue82 = drawCenteredText(
            var1, this.gameTextValue03, this.gameShortValue03, 12, var98 - this.gameIntegerValue81, 12, var98, gameIntegerValue41 - 12 - var4 - 10, var98 + this.gameIntegerValue68, 20
         );
         gameIntegerValue34 = gameSpriteDecoderReferenceArray09[0].getSpriteWidth(39) + 2;
         gameIntegerValue35 = gameSpriteDecoderReferenceArray09[0].getSpriteHeight(39) + 2;
         if (this.gameIntegerValue81 != 0) {
            int var120 = (int)((long)(var98 - 5 - 1) - this.gameLongValue06 % 600L / 200L);
            if (!gameBooleanFlag29 && gameIntegerValue67 == 1) {
               SpriteResourceDecoder var156 = gameSpriteDecoderReferenceArray09[0];
               int var169 = gameRectangleBoundsReference01 != null && gameRectangleBoundsReference01.boundsId == 1 ? 40 : 39;
               var120 -= gameIntegerValue35 >> 1;
               var5 = var169;
               Graphics var107 = gameGraphicsReference02;
               var156.drawSpriteFrameTransformed(var107, var5, 180, var120, 0, 0, 0);
            }
         }

         if (!gameBooleanFlag29 && gameIntegerValue67 == 1) {
            int var122 = (int)((long)(var98 - 5 - 1) - this.gameLongValue06 % 600L / 200L);
            addCollisionBounds(180 - (gameIntegerValue34 >> 1), var122 - gameIntegerValue35, gameIntegerValue34, gameIntegerValue35, 1);
            var122 = (int)((long)(var98 + this.gameIntegerValue68 + 1) + this.gameLongValue06 % 600L / 200L);
            addCollisionBounds(180 - (gameIntegerValue34 >> 1), var122, gameIntegerValue34, gameIntegerValue35, 2);
         }

         if (this.gameIntegerValue81 != JMath.max(this.gameIntegerValue82 - this.gameIntegerValue68, 0)) {
            int var124 = (int)((long)(var98 + this.gameIntegerValue68 + 1) + this.gameLongValue06 % 600L / 200L);
            if (!gameBooleanFlag29 && gameIntegerValue67 == 1) {
               SpriteResourceDecoder var157 = gameSpriteDecoderReferenceArray09[0];
               int var170 = gameRectangleBoundsReference01 != null && gameRectangleBoundsReference01.boundsId == 2 ? 42 : 41;
               var5 = var124 + (gameIntegerValue35 >> 1);
               var4 = var170;
               Graphics var104 = gameGraphicsReference02;
               var157.drawSpriteFrameTransformed(var104, var4, 180, var5, 0, 0, 0);
            }
         }

         if (gameIntegerValue50 != 137 && !gameBooleanFlag29) {
            gameBooleanFlag10 = true;
         }

         if (gameIntegerValue50 == 139) {
            SpriteResourceDecoder var165 = gameSpriteDecoderReferenceArray07[2];
            int var140 = AnimationTables.integerValue02;
            int var139 = gameIntegerValue43;
            var165.drawSpriteFrameTransformed(var1, 0, var139, var140, 0, 0, 0);
            var165 = gameSpriteDecoderReferenceArray07[2];
            int var72 = AnimationTables.integerValue02;
            int var71 = gameIntegerValue43;
            var165.drawSpriteFrameTransformed(var1, 1, var71, var72, 0, 0, 0);
            var165 = gameSpriteDecoderReferenceArray07[2];
            int var175 = 2 + this.gameByteValue25;
            int var143 = AnimationTables.integerValue02;
            int var142 = gameIntegerValue43;
            int var141 = var175;
            var165.drawSpriteFrameTransformed(var1, var141, var142, var143, 0, 0, 0);
         } else {
            if (gameIntegerValue50 == 137 && !gameBooleanFlag29) {
               int var125 = 16 * screenWidth / 240;
               int var127;
               var5 = (var127 = 15 * screenWidth / 240) << 1;
               var2 = 320 - (var5 << 2);
               var4 = var125 * this.gameIntegerValue69 + 12;
               var3 = 180 - (var4 >> 1);
               this.drawTileLayer(var1, var3, var2, var4, var5, 6);
               gameIntegerValue34 = gameSpriteDecoderReferenceArray09[0].getSpriteWidth(39) + 2;
               gameIntegerValue35 = gameSpriteDecoderReferenceArray09[0].getSpriteHeight(39) + 2;
               SpriteResourceDecoder var158 = gameSpriteDecoderReferenceArray09[0];
               int var171 = gameRectangleBoundsReference01 != null && gameRectangleBoundsReference01.boundsId == 1 ? 40 : 39;
               int var10 = 320 - var5 * 3 / 2;
               int var133 = var171;
               Graphics var129 = gameGraphicsReference02;
               var158.drawSpriteFrameTransformed(var129, var133, 180, var10, 0, 0, 0);
               addCollisionBounds(180 - (gameIntegerValue34 >> 1), 320 - var5 * 3 / 2 - gameIntegerValue35 / 2, gameIntegerValue34, gameIntegerValue35, 1);
               var158 = gameSpriteDecoderReferenceArray09[0];
               var171 = gameRectangleBoundsReference01 != null && gameRectangleBoundsReference01.boundsId == 2 ? 42 : 41;
               var10 = 320 + var5 * 3 / 2;
               var133 = var171;
               var129 = gameGraphicsReference02;
               var158.drawSpriteFrameTransformed(var129, var133, 180, var10, 0, 0, 0);
               addCollisionBounds(180 - (gameIntegerValue34 >> 1), 320 + var5 * 3 / 2 - gameIntegerValue35 / 2, gameIntegerValue34, gameIntegerValue35, 2);
               gameIntegerValue34 = gameSpriteDecoderReferenceArray09[0].getSpriteWidth(43) + 2;
               gameIntegerValue35 = gameSpriteDecoderReferenceArray09[0].getSpriteHeight(43) + 2;
               var158 = gameSpriteDecoderReferenceArray09[0];
               var171 = gameRectangleBoundsReference01 != null && gameRectangleBoundsReference01.boundsId == 3 ? 44 : 43;
               var133 = 180 - var4;
               int var131 = var171;
               Graphics var115 = gameGraphicsReference02;
               var158.drawSpriteFrameTransformed(var115, var131, var133, 320, 0, 0, 0);
               addCollisionBounds(180 - var4 - (gameIntegerValue34 >> 1), 320 - gameIntegerValue35 / 2, gameIntegerValue34, gameIntegerValue35, 3);
               var158 = gameSpriteDecoderReferenceArray09[0];
               var171 = gameRectangleBoundsReference01 != null && gameRectangleBoundsReference01.boundsId == 4 ? 46 : 45;
               var133 = var4 + 180;
               int var132 = var171;
               Graphics var116 = gameGraphicsReference02;
               var158.drawSpriteFrameTransformed(var116, var132, var133, 320, 0, 0, 0);
               addCollisionBounds(var4 + 180 - (gameIntegerValue34 >> 1), 320 - gameIntegerValue35 / 2, gameIntegerValue34, gameIntegerValue35, 4);
               gameIntegerValue34 = gameSpriteDecoderReferenceArray09[0].getSpriteWidth(47) + 2;
               gameIntegerValue35 = gameSpriteDecoderReferenceArray09[0].getSpriteHeight(47) + 2;
               var158 = gameSpriteDecoderReferenceArray09[0];
               var5 = gameRectangleBoundsReference01 != null && gameRectangleBoundsReference01.boundsId == 14 ? 48 : 47;
               Graphics var110 = gameGraphicsReference02;
               var158.drawSpriteFrameTransformed(var110, var5, 180, 320, 0, 0, 0);
               var158 = gameSpriteDecoderReferenceArray08[1];
               short var144 = 295;
               string var118 = getStringResource(295);
               var158.drawBitmapTextLine(var1, var118, 180, 320, 3, true);
               addCollisionBounds(180 - (gameIntegerValue34 >> 1), 320 - gameIntegerValue35 / 2, gameIntegerValue34, gameIntegerValue35, 14);
               if (!gameBooleanFlag29) {
                  gameBooleanFlag10 = true;
               }

               int var100 = var2 + var127;
               int var106 = 180 - (var125 * (this.gameIntegerValue69 - 1) >> 1);

               for (int var111 = 0; var111 < this.gameIntegerValue69; var111++) {
                  if (var111 == this.gameIntegerValue51) {
                     gameSpriteDecoderReferenceArray08[1].setGraphicsTransform(1);
                     sbyte var150 = 0;
                     short var148 = 255;
                     short var146 = 255;
                     var1.setColor(var146, var148, var150);
                     if ((JSystem.currentTimeMillis() & 64L) != 0L) {
                        fillRectangle(var1, var106 - var125 / 2, var100 + var127 / 2, var125, 2);
                     }
                  } else {
                     gameSpriteDecoderReferenceArray08[1].setGraphicsTransform(0);
                  }

                  var158 = gameSpriteDecoderReferenceArray08[1];
                  string var137 = "" + this.gameStringBufferReference01.charAt(var111);
                  var158.drawBitmapTextLine(var1, var137, var106, var100, 3, true);
                  var106 += var125 + 1;
               }

               gameSpriteDecoderReferenceArray08[1].setGraphicsTransform(0);
            }
         }
      }
   }

   // $VF: renamed from: a (int, int, java.lang.String, int) void
   public void showGameMessage(int var1, int var2, string var3, int var4) {
      bool var5 = gameBooleanFlag62;
      if (gameBooleanFlag62) {
         if (var1 != 2) {
            return;
         }

         gameBooleanFlag62 = false;
      }

      if (gameIntegerValue50 != 130) {
         this.gameLongValue10 = this.gameLongValue06;
      }

      clearCollisionBounds();
      clearInteractionBounds();
      gameIntegerValue50 = 131;
      this.gameIntegerValue114 = 45;
      gameIntegerValue67 = (sbyte)var1;
      this.gameByteValue08 = (sbyte)var2;
      this.gameTextValue03 = var3;
      this.gameShortValue03 = (short)var4;
      this.gameIntegerValue81 = 0;
      this.gameIntegerValue68 = 0;
      if (var1 == 2 && !var5) {
         this.processActorAction(15);
      }
   }

   // $VF: renamed from: b (int, int, java.lang.String, int) void
   public void showGameMessageWithStyle(int var1, int var2, string var3, int var4) {
      this.showGameMessage(0, var2, var3, 0);
   }

   // $VF: renamed from: a (java.lang.String, short, byte) void
   public void setActorAnimationState(string var1, short var2, sbyte var3) {
      sbyte var4 = this.gameActorGroupReference01.actorStateReference01.byteValue08;
      gameIntegerValue50 = 137;
      gameIntegerValue67 = 0;
      this.gameByteValue08 = var4;
      this.gameTextValue03 = var1;
      this.gameShortValue03 = 0;
      this.gameIntegerValue69 = var3;
      this.gameIntegerValue81 = 0;
      this.gameIntegerValue68 = 0;
      this.gameStringBufferReference01.setLength(0);
      this.gameStringBufferReference01.append("AAAAAAAAAA".substring(0, var3));
      this.gameIntegerValue51 = 0;
      clearInteractionBounds();
      clearCollisionBounds();
   }

   // $VF: renamed from: a (java.lang.String, short) void
   public void setActorDirection(string var1, short var2) {
      sbyte var3 = this.gameActorGroupReference01.actorStateReference01.byteValue08;
      gameIntegerValue50 = 139;
      gameIntegerValue67 = 0;
      this.gameByteValue08 = var3;
      this.gameTextValue03 = var1;
      this.gameShortValue03 = 0;
      this.gameIntegerValue81 = 0;
      this.gameIntegerValue68 = 0;
   }

   // $VF: renamed from: a (int, byte) void
   public void setActiveActorGroups(int var1, int var2) {
      this.setActorGroupPosition((sbyte)var1, (sbyte)var2);
      this.gameStringBufferReference01.setLength(0);
      if (this.gameActorGroupReference01.entitySnapshotReferenceArray01[var1].byteValue01 == 4) {
         var2 = (sbyte)26;
         this.gameStringBufferReference01.append(JString.New(getStringResource(26)));
      } else {
         var2 = (sbyte)25;
         this.gameStringBufferReference01.append(JString.New(getStringResource(25)));
      }

      this.gameStringBufferReference01.append(' ');
      var2 = this.gameActorGroupReference01.entitySnapshotReferenceArray01[var1].integerValue01;
      this.gameStringBufferReference01.append(getStringResource(this.gameActorGroupReference01.entitySnapshotReferenceArray01[var1].integerValue01));
      this.gameStringBufferReference01.append('.');
      this.showGameMessage(2, var1, this.gameStringBufferReference01.toString(), 0);
   }

   // $VF: renamed from: g (int) void
   public void setActiveActorGroup(int var1) {
      this.setActiveActorGroups(var1, this.gameByteValue03);
   }

   // $VF: renamed from: a (byte) void
   public void setActiveActorGroupDirection(sbyte var1) {
      this.setActorGroupTargetPosition(var1, this.gameByteValue03);
   }

   // $VF: renamed from: b (byte, byte) void
   public void setActorGroupPosition(sbyte var1, sbyte var2) {
      ActorGroup var3;
      if (var2 == 1) {
         var3 = this.gameActorGroupReference03;
      } else {
         var3 = this.gameActorGroupReference04;
      }

      if (var1 == 6) {
         var3.byteArray01[5]++;
      }

      if (!var3.entitySnapshotReferenceArray01[var1].booleanFlag01) {
         var3.entitySnapshotReferenceArray01[var1].booleanFlag01 = true;
         var3.byteValue03++;
      }
   }

   // $VF: renamed from: a (byte, byte) void
   public void setActorGroupTargetPosition(sbyte var1, sbyte var2) {
      ActorGroup var3;
      if (var2 == 1) {
         var3 = this.gameActorGroupReference03;
      } else {
         var3 = this.gameActorGroupReference04;
      }

      if (var3.entitySnapshotReferenceArray01[var1].booleanFlag01) {
         var3.entitySnapshotReferenceArray01[var1].booleanFlag01 = false;
         var3.byteValue03--;
         if (var3.byteValue02 == var1) {
            var3.byteValue02 = 0;
         }

         if (var1 == 34) {
            this.processActorAction(24);
         } else {
            this.processActorAction(17);
         }
      }
   }

   // $VF: renamed from: c (int) int
   public int getActorGroupCount(int var1) {
      return this.countActorsByType(var1, this.gameByteValue03);
   }

   // $VF: renamed from: a (int, byte) int
   public int countActorsByType(int var1, sbyte var2) {
      int var3 = 0;
      ActorGroup var4;
      if (var2 == 1) {
         var4 = this.gameActorGroupReference03;
      } else {
         var4 = this.gameActorGroupReference04;
      }

      for (int var5 = 0; var5 < var4.byteValue01; var5++) {
         if (var4.entitySnapshotReferenceArray01[var5].booleanFlag01 && this.gameByteArray04[var5 * 2 + 1] < this.gameByteArray04[var1 * 2 + 1]) {
            var3++;
         }
      }

      return var3;
   }

   // $VF: renamed from: b (int, byte) int
   public int countActiveActorsByType(int var1, sbyte var2) {
      int var3 = 0;
      ActorGroup var5;
      if (var2 == 1) {
         var5 = this.gameActorGroupReference03;
      } else {
         var5 = this.gameActorGroupReference04;
      }

      for (int var4 = 0; var4 < var5.byteValue01; var4++) {
         if (this.countActorsByType(var4, var2) < var1) {
            var3++;
         }
      }

      return var3;
   }

   // $VF: renamed from: q (int) void
   public void updateLevelTimer(int var1) {
      if (gameIntegerValue48 == 2) {
         this.gameLongValue08 += (long)var1;

         for (int var2 = 0; var2 < 25; var2++) {
            this.gameActorStateReferenceArray01[var2].longValue01 += (long)var1;
            this.gameActorStateReferenceArray01[var2].longValue02 += (long)var1;
            if (this.gameActorStateReferenceArray01[var2].longValue01 > this.gameLongValue06) {
               this.gameActorStateReferenceArray01[var2].longValue01 = this.gameLongValue06;
            }

            if (this.gameActorStateReferenceArray01[var2].longValue02 > this.gameLongValue06) {
               this.gameActorStateReferenceArray01[var2].longValue02 = this.gameLongValue06;
            }
         }

         this.advanceLevelEvents(var1);
      }
   }

   // $VF: renamed from: r (int) void
   public void advanceLevelEvents(int var1) {
      for (int var2 = 0; var2 < 10; var2++) {
         this.gameClass22ReferenceArray01[var2].longValue01 += (long)var1;
      }
   }

   // $VF: renamed from: l () void
   public void updateLevelEvents() {
      if (gameIntegerValue48 == 2) {
         this.setGameScreen(2);
         this.restoreAudioState();
         gameBooleanFlag29 = true;
         this.gameLongValue09 = this.gameLongValue06;
      }
   }

   // $VF: renamed from: T () void
   public void resetLevelEvents() {
      gameBooleanFlag29 = false;
      this.updateLevelTimer((int)(this.gameLongValue06 - this.gameLongValue09));
      gameBooleanFlag52 = false;
      this.resumeBackgroundMusic();
   }

   // $VF: renamed from: a (int, int) boolean
   public bool isActorUnavailable(int var1, int var2) {
      if ((gameIntegerValue50 & 512) != 0) {
         return false;
      } else {
         for (int var3 = 0; var3 < gameIntegerValue80; var3++) {
            if (var3 == gameIntegerValue76) {
               var3 = gameIntegerValue74;
            }

            ActorRuntimeState var4;
            if (!(var4 = this.gameClass9ReferenceArray01[this.gameIntegerArray03[var3]]).booleanFlag02) {
               if (var4.booleanFlag04) {
                  if (var4.byteValue02 == var1 && (var4.byteValue03 == var2 || var4.byteValue03 == var2 + 1)) {
                     return true;
                  }
               } else if (var4.byteValue03 == var2 && (var4.byteValue02 == var1 || var4.byteValue02 == var1 + 1)) {
                  return true;
               }
            }
         }

         return false;
      }
   }

   // $VF: renamed from: j () boolean
   public bool isGameOver() {
      int var3 = this.gameBooleanFlag28 ? 1 : 0;
      this.gameBooleanFlag28 = true;
      int var1 = (this.isGameModeActive(2821) || this.isGameModeActive(18)) ? 1 : 0;
      int var2 = this.isGameModeActive(19) ? 1 : 0;
      this.gameBooleanFlag28 = var3 != 0;
      if ((
            !(
                  gameBooleanFlag63 = gameByteValue07 == 1
                     && gameIntegerValue48 == 2
                     && !gameBooleanFlag29
                     && !gameBooleanFlag62
                     && gameShortValue01 != 730
                     && gameShortValue01 != 731
                     && gameShortValue01 != 732
                     && gameShortValue01 != 0
                     && gameShortValue01 != 570
                     && (gameShortValue01 != 540 || this.gameIntegerValue66 < 32)
                     && gameIntegerValue50 != 137
                     && gameIntegerValue50 != 139
               )
               || !this.isGameModeActive(18)
         )
         && (!gameBooleanFlag63 || gameRectangleBoundsReference02 == null || gameRectangleBoundsReference02.boundsId != 1001 || !gameBooleanFlag22)) {
         if (!gameBooleanFlag62) {
            if (gameBooleanFlag29) {
               return false;
            }

            if (this.isGameModeActive(18) && this.canProcessPointerInput() || gameRectangleBoundsReference02 != null && gameRectangleBoundsReference02.boundsId == 1001 && gameBooleanFlag22 && this.canProcessPointerInput() && !gameBooleanFlag53) {
               clearInteractionBounds();
               clearCollisionBounds();
               this.updateLevelEvents();
               return false;
            }
         }
      } else {
         gameBooleanFlag62 = true;
         if (true) {
            gameIntegerValue45 = 0;
         }

         gameIntegerValue124 = -1;
      }

      int var14 = 0;
      int var4 = 0;
      switch (gameIntegerValue48) {
         case 2:
            if (this.gameActorGroupReference01.actorStateReference01.byteValue05 == 3 || this.gameActorGroupReference01.actorStateReference01.byteValue05 == 4) {
               if (this.gameActorGroupReference01.actorStateReference01.byteValue05 == 4) {
                  if (gameShortValue01 == 732) {
                     if (var1 != 0 || gameRectangleBoundsReference01 != null && gameRectangleBoundsReference01.boundsId == 1003 && gameBooleanFlag22) {
                        clearInteractionBounds();
                        clearCollisionBounds();
                        gameIntegerValue50 = 384;
                     }

                     return false;
                  }

                  setGamePaused(true);
                  this.configureActorStatusEffect(false, 732, 0);
               }

               return false;
            }

            switch (gameIntegerValue50) {
               case 130:
                  if (var1 != 0 || gameRectangleBoundsReference01 != null && gameRectangleBoundsReference01.boundsId >= 100 && gameRectangleBoundsReference01.boundsId < 300) {
                     if (gameRectangleBoundsReference01 != null && this.gameIntegerValue51 != gameRectangleBoundsReference01.boundsId - 100) {
                        this.gameIntegerValue51 = gameRectangleBoundsReference01.boundsId - 100;
                        var3 = this.getActorGroupCount(this.gameByteArray04[2 * this.gameIntegerValue51]);
                        this.gameIntegerValue81 = JMath.min(this.gameIntegerValue81, var3);
                        this.gameIntegerValue81 = JMath.max(this.gameIntegerValue81, var3 - this.gameIntegerValue82 + 1);
                        clearCollisionBounds();
                        clearInteractionBounds();
                     } else if (gameRectangleBoundsReference01 != null && gameBooleanFlag22 && !gameBooleanFlag15 && this.gameIntegerValue51 != this.gameActorGroupReference01.byteValue02) {
                        gameBooleanFlag15 = true;
                        clearCollisionBounds();
                     } else {
                        if (gameBooleanFlag12) {
                           gameBooleanFlag15 = false;
                           gameBooleanFlag12 = false;
                           if (this.gameActorGroupReference01.entitySnapshotReferenceArray01[this.gameByteArray04[2 * this.gameIntegerValue51]].byteValue01 == 4) {
                              this.showGameMessage(1, 2, getLocalizedText(this.gameActorGroupReference01.entitySnapshotReferenceArray01[this.gameByteArray04[2 * this.gameIntegerValue51]].integerValue01 + 2), 0);
                           } else {
                              this.gameActorGroupReference01.byteValue02 = this.gameByteArray04[2 * this.gameIntegerValue51];

                              for (int var25 = 0; var25 < 6; var25++) {
                                 if (this.gameActorGroupReference01.byteValue02 == gameIntegerArray02[var25]) {
                                    this.setActorAnimation(var25);
                                 }
                              }

                              this.updatePlayerActor();
                           }

                           this.processActorAction(16);
                           clearCollisionBounds();
                           clearInteractionBounds();
                        }

                        if (gameRectangleBoundsReference01 != null && gameBooleanFlag22) {
                           gameBooleanFlag13 = true;
                        }
                     }
                  }

                  if (this.isGameModeActive(13)) {
                     this.gameIntegerValue91 = JMath.max(this.gameIntegerValue91 - 4, 0);
                  } else if (this.isGameModeActive(15)) {
                     this.gameIntegerValue91 = JMath.min(this.gameIntegerValue91 + 4, JMath.max(this.gameIntegerValue92 - 3 * (AnimationTables.byteArray02[0] + 1), 0));
                  }

                  if (var2 != 0 || this.isGameModeActive(19) || gameRectangleBoundsReference02 != null && gameRectangleBoundsReference02.boundsId == 1002 && gameBooleanFlag22) {
                     clearInteractionBounds();
                     clearCollisionBounds();
                     this.updatePlayerActor();
                     this.processActorAction(21);
                  }

                  if (this.isGameModeActive(2049) || gameRectangleBoundsReference01 != null && gameBooleanFlag22 && gameRectangleBoundsReference01.boundsId == 1) {
                     gameBooleanFlag15 = true;
                     clearCollisionBounds();
                     this.gameIntegerValue91 = 0;

                     do {
                        this.gameIntegerValue51--;
                        if (this.gameIntegerValue51 < 0) {
                           this.gameIntegerValue51 = this.gameActorGroupReference01.byteValue01 - 1;
                        }
                     } while (!this.gameActorGroupReference01.entitySnapshotReferenceArray01[this.gameByteArray04[2 * this.gameIntegerValue51]].booleanFlag01);

                     var3 = this.getActorGroupCount(this.gameByteArray04[2 * this.gameIntegerValue51]);
                     this.gameIntegerValue81 = JMath.min(this.gameIntegerValue81, var3);
                     this.gameIntegerValue81 = JMath.max(this.gameIntegerValue81, var3 - this.gameIntegerValue82 + 1);
                  }

                  if (this.isGameModeActive(3586) || gameRectangleBoundsReference01 != null && gameBooleanFlag22 && gameRectangleBoundsReference01.boundsId == 2) {
                     gameBooleanFlag15 = true;
                     clearCollisionBounds();
                     this.gameIntegerValue91 = 0;

                     do {
                        this.gameIntegerValue51++;
                        if (this.gameIntegerValue51 >= this.gameActorGroupReference01.byteValue01) {
                           this.gameIntegerValue51 = 0;
                        }
                     } while (!this.gameActorGroupReference01.entitySnapshotReferenceArray01[this.gameByteArray04[2 * this.gameIntegerValue51]].booleanFlag01);

                     var3 = this.getActorGroupCount(this.gameByteArray04[2 * this.gameIntegerValue51]);
                     this.gameIntegerValue81 = JMath.min(this.gameIntegerValue81, var3);
                     this.gameIntegerValue81 = JMath.max(this.gameIntegerValue81, var3 - this.gameIntegerValue82 + 1);
                  }

                  return false;
               case 131:
                  if (!this.isGameModeActive(2049) && (gameRectangleBoundsReference01 == null || gameRectangleBoundsReference01.boundsId != 1)) {
                     if (!this.isGameModeActive(3586) && (gameRectangleBoundsReference01 == null || gameRectangleBoundsReference01.boundsId != 2)) {
                        if ((!this.isGameModeActive(18) || gameIntegerValue67 == 3)
                           && !this.isGameModeActive(2821)
                           && (gameRectangleBoundsReference01 == null || gameRectangleBoundsReference01.boundsId != 1003 || !gameBooleanFlag22)
                           && (gameRectangleBoundsReference02 == null || gameRectangleBoundsReference02.boundsId != 1001 || !gameBooleanFlag22 || !isGameplayRunning() || !gameBooleanFlag62)) {
                           if (var2 != 0 || gameRectangleBoundsReference02 != null && gameBooleanFlag22 && gameRectangleBoundsReference02.boundsId == 1002) {
                              clearCollisionBounds();
                              clearInteractionBounds();
                              if (gameIntegerValue67 == 1) {
                                 if (this.gameIntegerValue122 >= 0) {
                                    this.gameIntegerValue122 = -1;
                                    this.updatePlayerActor();
                                 } else {
                                    gameIntegerValue50 = 130;
                                    this.gameIntegerValue81 = this.getActorGroupCount(this.gameByteArray04[2 * this.gameIntegerValue51]);
                                    this.gameIntegerValue82 = 0;
                                 }

                                 this.processActorAction(21);
                              }

                              return false;
                           }
                        } else {
                           if (gameShortValue01 == 10 && gameByteValue07 == 1 && this.gameIntegerValue66 == 12) {
                              this.processActorAction(27);
                           }

                            {
                              if (this.gameIntegerValue81 < JMath.max(this.gameIntegerValue82 - this.gameIntegerValue68, 0)) {
                                 this.gameIntegerValue81 = JMath.max(this.gameIntegerValue82 - this.gameIntegerValue68, 0);
                                 if (gameBooleanFlag62) {
                                    goto label962_brk;
                                 }
                              } else {
                                  {
                                    if (gameIntegerValue67 == 1) {
                                       if (this.gameIntegerValue122 < 0) {
                                          gameIntegerValue50 = 130;
                                          this.gameIntegerValue81 = this.getActorGroupCount(this.gameByteArray04[2 * this.gameIntegerValue51]);
                                          this.gameIntegerValue82 = 0;
                                          goto label960_brk;
                                       }

                                       this.gameIntegerValue122 = -1;
                                    }

                                    this.updatePlayerActor();
                                 } label960_brk:;
                              }

                              clearInteractionBounds();
                              clearCollisionBounds();
                           } label962_brk:;

                           if (gameIntegerValue67 == 2 && this.gameActorGroupReference01.entitySnapshotReferenceArray01[this.gameByteValue08].byteValue01 == 4) {
                              this.gameIntegerValue122 = this.gameByteValue08;
                              this.showGameMessage(1, 2, getLocalizedText(this.gameActorGroupReference01.entitySnapshotReferenceArray01[this.gameByteValue08].integerValue01 + 2), 0);
                           }

                           if (gameIntegerValue67 == 3) {
                              gameIntegerValue133 = 1000;
                              return false;
                           }
                        }

                        return false;
                     } else {
                        if (gameBooleanFlag22) {
                           clearInteractionBounds();
                           clearCollisionBounds();
                        }

                        this.gameIntegerValue81 = JMath.min(this.gameIntegerValue81 + 4, JMath.max(this.gameIntegerValue82 - this.gameIntegerValue68, 0));
                        return false;
                     }
                  } else {
                     if (gameBooleanFlag22) {
                        clearInteractionBounds();
                        clearCollisionBounds();
                     }

                     this.gameIntegerValue81 = JMath.max(this.gameIntegerValue81 - 4, 0);
                     return false;
                  } goto case 137;
               case 137:
                  if (!this.isGameModeActive(2049) && (gameRectangleBoundsReference01 == null || gameRectangleBoundsReference01.boundsId != 1 || !gameBooleanFlag22)) {
                     if (!this.isGameModeActive(3586) && (gameRectangleBoundsReference01 == null || gameRectangleBoundsReference01.boundsId != 2 || !gameBooleanFlag22)) {
                        if (!this.isGameModeActive(2563) && (gameRectangleBoundsReference01 == null || gameRectangleBoundsReference01.boundsId != 3 || !gameBooleanFlag22)) {
                           if (!this.isGameModeActive(3076) && (gameRectangleBoundsReference01 == null || gameRectangleBoundsReference01.boundsId != 4 || !gameBooleanFlag22)) {
                              if (var1 != 0 || gameRectangleBoundsReference01 != null && gameRectangleBoundsReference01.boundsId == 14 && gameBooleanFlag22) {
                                 clearInteractionBounds();
                                 clearCollisionBounds();
                                 gameIntegerValue50 = 384;
                              }
                           } else {
                              clearInteractionBounds();
                              clearCollisionBounds();
                              this.gameIntegerValue51++;
                              if (this.gameIntegerValue51 >= this.gameIntegerValue69) {
                                 this.gameIntegerValue51 = 0;
                                 return false;
                              }
                           }

                           return false;
                        } else {
                           clearInteractionBounds();
                           clearCollisionBounds();
                           this.gameIntegerValue51--;
                           if (this.gameIntegerValue51 < 0) {
                              this.gameIntegerValue51 = this.gameIntegerValue69 - 1;
                              return false;
                           }

                           return false;
                        }
                     } else {
                        clearInteractionBounds();
                        clearCollisionBounds();
                        if (this.gameStringBufferReference01.charAt(this.gameIntegerValue51) == 'Z') {
                           this.gameStringBufferReference01.setCharAt(this.gameIntegerValue51, '0');
                           return false;
                        } else {
                           if (this.gameStringBufferReference01.charAt(this.gameIntegerValue51) == '9') {
                              this.gameStringBufferReference01.setCharAt(this.gameIntegerValue51, 'A');
                           } else {
                              this.gameStringBufferReference01.setCharAt(this.gameIntegerValue51, (char)(this.gameStringBufferReference01.charAt(this.gameIntegerValue51) + 1));
                           }

                           return false;
                        }
                     }
                  } else {
                     clearInteractionBounds();
                     clearCollisionBounds();
                     if (this.gameStringBufferReference01.charAt(this.gameIntegerValue51) == 'A') {
                        this.gameStringBufferReference01.setCharAt(this.gameIntegerValue51, '9');
                        return false;
                     } else {
                        if (this.gameStringBufferReference01.charAt(this.gameIntegerValue51) == '0') {
                           this.gameStringBufferReference01.setCharAt(this.gameIntegerValue51, 'Z');
                        } else {
                           this.gameStringBufferReference01.setCharAt(this.gameIntegerValue51, (char)(this.gameStringBufferReference01.charAt(this.gameIntegerValue51) - 1));
                        }

                        return false;
                     }
                  } goto case 138;
               case 138:
                  if ((var1 != 0 || gameRectangleBoundsReference01 != null && gameRectangleBoundsReference01.boundsId > 100 && gameRectangleBoundsReference01.boundsId < 300) && gameRectangleBoundsReference01 != null) {
                     if (gameRectangleBoundsReference01.boundsId < 200) {
                        if (gameRectangleBoundsReference01.boundsId - 100 != this.gameIntegerValue84 || this.gameShortValue14 == 1) {
                           this.gameShortValue14 = 0;
                           this.gameIntegerValue84 = gameRectangleBoundsReference01.boundsId - 100;
                           var3 = this.countActorsByType(this.gameByteArray04[2 * this.gameIntegerValue84], (sbyte)1);
                           this.gameIntegerValue86 = JMath.min(this.gameIntegerValue86, var3);
                           this.gameIntegerValue86 = JMath.max(this.gameIntegerValue86, var3 - this.gameIntegerValue88 + 1);
                           gameBooleanFlag15 = false;
                           return false;
                        }

                        if (gameBooleanFlag22 && !gameBooleanFlag15) {
                           gameBooleanFlag15 = true;
                           clearCollisionBounds();
                        } else if (gameBooleanFlag22 && gameBooleanFlag15) {
                           if (!this.isLevelComplete()) {
                              clearInteractionBounds();
                              clearCollisionBounds();
                              gameBooleanFlag15 = true;
                              return false;
                           }

                           clearInteractionBounds();
                           clearCollisionBounds();
                           gameBooleanFlag15 = true;
                        }
                     } else {
                        if (gameRectangleBoundsReference01.boundsId - 200 != this.gameIntegerValue85 || this.gameShortValue14 == 0) {
                           this.gameShortValue14 = 1;
                           this.gameIntegerValue85 = gameRectangleBoundsReference01.boundsId - 200;
                           var3 = this.countActorsByType(this.gameByteArray04[2 * this.gameIntegerValue85], (sbyte)2);
                           this.gameIntegerValue87 = JMath.min(this.gameIntegerValue87, var3);
                           this.gameIntegerValue87 = JMath.max(this.gameIntegerValue87, var3 - this.gameIntegerValue89 + 1);
                           gameBooleanFlag15 = false;
                           return false;
                        }

                        if (gameBooleanFlag22 && !gameBooleanFlag15) {
                           gameBooleanFlag15 = true;
                           clearCollisionBounds();
                        } else if (gameBooleanFlag22 && gameBooleanFlag15) {
                           if (!this.isLevelComplete()) {
                              clearInteractionBounds();
                              clearCollisionBounds();
                              gameBooleanFlag15 = true;
                              return false;
                           }

                           clearInteractionBounds();
                           clearCollisionBounds();
                           gameBooleanFlag15 = true;
                           var3 = this.countActorsByType(this.gameByteArray04[2 * this.gameIntegerValue85], (sbyte)2);
                           this.gameIntegerValue87 = JMath.min(this.gameIntegerValue87, var3);
                           this.gameIntegerValue87 = JMath.max(this.gameIntegerValue87, var3 - this.gameIntegerValue89 + 1);
                        }
                     }
                  }

                  if (this.isGameModeActive(13)) {
                     this.gameIntegerValue91 = JMath.max(this.gameIntegerValue91 - 4, 0);
                  } else if (this.isGameModeActive(15)) {
                     this.gameIntegerValue91 = JMath.min(this.gameIntegerValue91 + 4, JMath.max(this.gameIntegerValue92 - 3 * (AnimationTables.byteArray02[0] + 1), 0));
                  }

                  if (var2 != 0 || this.isGameModeActive(19) || gameRectangleBoundsReference02 != null && gameRectangleBoundsReference02.boundsId == 1002 && gameBooleanFlag22) {
                     clearInteractionBounds();
                     clearCollisionBounds();
                     this.gameActorGroupReference03.byteValue02 = 0;
                     this.gameActorGroupReference04.byteValue02 = 0;
                     if (this.gameActorGroupReference03.entitySnapshotReferenceArray01[19].booleanFlag01 && this.gameActorGroupReference03.entitySnapshotReferenceArray01[20].booleanFlag01
                        || this.gameActorGroupReference04.entitySnapshotReferenceArray01[19].booleanFlag01 && this.gameActorGroupReference04.entitySnapshotReferenceArray01[20].booleanFlag01) {
                        this.configureActorStatusEffect(false, 370, 0);
                     }

                     this.updatePlayerActor();
                     this.processActorAction(21);
                  }

                  if (this.isGameModeActive(2563)) {
                     this.gameShortValue14 = 0;
                     this.gameIntegerValue84 = 1;
                     this.gameIntegerValue86 = 1;
                  }

                  if (this.isGameModeActive(3076)) {
                     this.gameShortValue14 = 1;
                     this.gameIntegerValue85 = 1;
                     this.gameIntegerValue87 = 1;
                  }

                  if (this.isGameModeActive(2049) || gameRectangleBoundsReference01 != null && gameBooleanFlag22 && (gameRectangleBoundsReference01.boundsId == 1 || gameRectangleBoundsReference01.boundsId == 3)) {
                     this.gameIntegerValue91 = 0;
                     if (this.gameShortValue14 == 0 && gameRectangleBoundsReference01.boundsId == 1) {
                        while (true) {
                           this.gameIntegerValue84--;
                           if (this.gameIntegerValue84 < 1) {
                              this.gameIntegerValue84 = this.gameActorGroupReference03.byteValue01 - 1;
                           }

                           if (this.gameActorGroupReference03.entitySnapshotReferenceArray01[this.gameByteArray04[2 * this.gameIntegerValue84]].booleanFlag01) {
                              var3 = this.countActorsByType(this.gameByteArray04[2 * this.gameIntegerValue84], (sbyte)1);
                              this.gameIntegerValue86 = JMath.min(this.gameIntegerValue86, var3);
                              this.gameIntegerValue86 = JMath.max(this.gameIntegerValue86, var3 - this.gameIntegerValue88 + 1);
                              break;
                           }
                        }
                     } else if (this.gameShortValue14 == 1 && gameRectangleBoundsReference01.boundsId == 3) {
                        do {
                           this.gameIntegerValue85--;
                           if (this.gameIntegerValue85 < 1) {
                              this.gameIntegerValue85 = this.gameActorGroupReference04.byteValue01 - 1;
                           }
                        } while (!this.gameActorGroupReference04.entitySnapshotReferenceArray01[this.gameByteArray04[2 * this.gameIntegerValue85]].booleanFlag01);

                        var3 = this.countActorsByType(this.gameByteArray04[2 * this.gameIntegerValue85], (sbyte)2);
                        this.gameIntegerValue87 = JMath.min(this.gameIntegerValue87, var3);
                        this.gameIntegerValue87 = JMath.max(this.gameIntegerValue87, var3 - this.gameIntegerValue89 + 1);
                     }

                     clearInteractionBounds();
                     clearCollisionBounds();
                     gameBooleanFlag15 = true;
                  }

                  if (this.isGameModeActive(3586) || gameRectangleBoundsReference01 != null && gameBooleanFlag22 && (gameRectangleBoundsReference01.boundsId == 2 || gameRectangleBoundsReference01.boundsId == 4)) {
                     this.gameIntegerValue91 = 0;
                     if (this.gameShortValue14 == 0 && gameRectangleBoundsReference01 != null && gameRectangleBoundsReference01.boundsId == 2) {
                        while (true) {
                           this.gameIntegerValue84++;
                           if (this.gameIntegerValue84 >= this.gameActorGroupReference03.byteValue01) {
                              this.gameIntegerValue84 = 1;
                           }

                           if (this.gameActorGroupReference03.entitySnapshotReferenceArray01[this.gameByteArray04[2 * this.gameIntegerValue84]].booleanFlag01) {
                              var3 = this.countActorsByType(this.gameByteArray04[2 * this.gameIntegerValue84], (sbyte)1);
                              this.gameIntegerValue86 = JMath.min(this.gameIntegerValue86, var3);
                              this.gameIntegerValue86 = JMath.max(this.gameIntegerValue86, var3 - this.gameIntegerValue88 + 1);
                              break;
                           }
                        }
                     } else if (this.gameShortValue14 == 1 && gameRectangleBoundsReference01 != null && gameRectangleBoundsReference01.boundsId == 4) {
                        do {
                           this.gameIntegerValue85++;
                           if (this.gameIntegerValue85 >= this.gameActorGroupReference04.byteValue01) {
                              this.gameIntegerValue85 = 1;
                           }
                        } while (!this.gameActorGroupReference04.entitySnapshotReferenceArray01[this.gameByteArray04[2 * this.gameIntegerValue85]].booleanFlag01);

                        var3 = this.countActorsByType(this.gameByteArray04[2 * this.gameIntegerValue85], (sbyte)2);
                        this.gameIntegerValue87 = JMath.min(this.gameIntegerValue87, var3);
                        this.gameIntegerValue87 = JMath.max(this.gameIntegerValue87, var3 - this.gameIntegerValue89 + 1);
                     }

                     clearInteractionBounds();
                     clearCollisionBounds();
                     gameBooleanFlag15 = true;
                  }

                  return false;
               case 139:
                  if (this.gameIntegerValue33 != -1) {
                     if (JSystem.currentTimeMillis() - gameLongValue03 > 300L) {
                        if (gameBooleanFlag18) {
                           this.gameByteValue25++;
                        } else {
                           this.gameByteValue25--;
                        }

                        if (this.gameByteValue25 > 11) {
                           this.gameByteValue25 = 0;
                        }

                        if (this.gameByteValue25 < 0) {
                           this.gameByteValue25 = 11;
                        }

                        this.gameIntegerValue33--;
                        gameLongValue03 = JSystem.currentTimeMillis();
                     }

                     if (this.gameIntegerValue33 == -1) {
                        if (gameBooleanFlag18) {
                           this.gameByteValue25--;
                        } else {
                           this.gameByteValue25++;
                        }

                        if (this.gameByteValue25 > 11) {
                           this.gameByteValue25 = 0;
                        }

                        if (this.gameByteValue25 < 0) {
                           this.gameByteValue25 = 11;
                        }

                        gameIntegerValue50 = 384;
                        return false;
                     }
                  }

                  return false;
               case 384:
                  if (this.gameByteValue04 != 3 && !isGameplayRunning() && (gameLongValue05 = gameLongValue05 + (long)gameIntegerValue129) > 40000L) {
                     if (!isAudioEnabled()) {
                        this.transitionGameState(2);
                     }

                     gameLongValue05 = 0L;
                  }

                  if (gameByteValue07 == 0 || gameByteValue07 == 1) {
                     return false;
                  }

                  this.clearActiveBounds();
                  if (gameBooleanFlag06) {
                     if (this.isGameModeActive(2563)) {
                        if (this.isPlayerActorActive()) {
                           setActorFacingDirection(this.gameActorGroupReference01.actorStateReference01, 4);
                           this.faceActorTowardPosition(this.gameActorGroupReference01.actorStateReference01, 1);
                        } else {
                           this.gameActorGroupReference01.actorStateReference01.longValue01 = this.gameLongValue06;
                        }
                     } else if (this.isGameModeActive(3076)) {
                        if (this.isPlayerActorActive()) {
                           setActorFacingDirection(this.gameActorGroupReference01.actorStateReference01, 0);
                           this.faceActorTowardPosition(this.gameActorGroupReference01.actorStateReference01, 1);
                        } else {
                           this.gameActorGroupReference01.actorStateReference01.longValue01 = this.gameLongValue06;
                        }
                     } else if (this.isGameModeActive(2049)) {
                        if (this.isPlayerActorActive()) {
                           setActorFacingDirection(this.gameActorGroupReference01.actorStateReference01, 2);
                           this.faceActorTowardPosition(this.gameActorGroupReference01.actorStateReference01, 1);
                        } else {
                           this.gameActorGroupReference01.actorStateReference01.longValue01 = this.gameLongValue06;
                        }
                     } else if (this.isGameModeActive(3586)) {
                        if (this.isPlayerActorActive()) {
                           setActorFacingDirection(this.gameActorGroupReference01.actorStateReference01, 6);
                           this.faceActorTowardPosition(this.gameActorGroupReference01.actorStateReference01, 1);
                        } else {
                           this.gameActorGroupReference01.actorStateReference01.longValue01 = this.gameLongValue06;
                        }
                     }
                  } else if (this.isGameModeActive(2563)) {
                     if (this.isPlayerActorActive()) {
                        setActorFacingDirection(this.gameActorGroupReference01.actorStateReference01, 5);
                        this.faceActorTowardPosition(this.gameActorGroupReference01.actorStateReference01, 0);
                        this.gameActorGroupReference01.booleanFlag01 = false;
                        this.gameActorGroupReference01.booleanFlag02 = false;
                        this.gameActorGroupReference01.booleanFlag03 = false;
                     } else {
                        this.gameActorGroupReference01.booleanFlag01 = true;
                     }
                  } else if (this.isGameModeActive(3076)) {
                     if (this.isPlayerActorActive()) {
                        setActorFacingDirection(this.gameActorGroupReference01.actorStateReference01, 1);
                        this.faceActorTowardPosition(this.gameActorGroupReference01.actorStateReference01, 0);
                        this.gameActorGroupReference01.booleanFlag01 = false;
                        this.gameActorGroupReference01.booleanFlag02 = false;
                        this.gameActorGroupReference01.booleanFlag03 = false;
                     } else {
                        this.gameActorGroupReference01.booleanFlag02 = true;
                     }
                  } else if (this.isGameModeActive(2049)) {
                     if (this.isPlayerActorActive()) {
                        setActorFacingDirection(this.gameActorGroupReference01.actorStateReference01, 3);
                        this.faceActorTowardPosition(this.gameActorGroupReference01.actorStateReference01, 0);
                        this.gameActorGroupReference01.booleanFlag01 = false;
                        this.gameActorGroupReference01.booleanFlag02 = false;
                        this.gameActorGroupReference01.booleanFlag03 = false;
                     } else {
                        this.gameActorGroupReference01.booleanFlag02 = true;
                     }
                  } else if (this.isGameModeActive(3586)) {
                     if (this.isPlayerActorActive()) {
                        setActorFacingDirection(this.gameActorGroupReference01.actorStateReference01, -1);
                        this.faceActorTowardPosition(this.gameActorGroupReference01.actorStateReference01, 0);
                        this.gameActorGroupReference01.booleanFlag01 = false;
                        this.gameActorGroupReference01.booleanFlag02 = false;
                        this.gameActorGroupReference01.booleanFlag03 = false;
                     } else {
                        this.gameActorGroupReference01.booleanFlag03 = true;
                     }
                  }

                  if (this.isGameModeActive(2821) || gameBooleanFlag19 && gameBooleanFlag22) {
                     if (!gameBooleanFlag19) {
                        if (this.isPlayerActorActive()) {
                           if (!this.isActorGroupActive(this.gameActorGroupReference01.actorStateReference01.byteValue07)
                              && this.gameActorGroupReference01.byteValue02 != 6
                              && (this.gameActorGroupReference01.actorStateReference01.byteValue07 == 1 || !this.isActorGroupActive(1))
                              && (this.gameActorGroupReference01.actorStateReference01.byteValue07 == 3 || !this.isActorGroupActive(3))
                              && (this.gameActorGroupReference01.actorStateReference01.byteValue07 == 5 || !this.isActorGroupActive(5))
                              && this.gameActorGroupReference01.actorStateReference01.byteValue07 != 7) {
                              this.isActorGroupActive(7);
                           }

                           this.faceActorTowardPosition(this.gameActorGroupReference01.actorStateReference01, 0);
                           initializeInputState();
                           return false;
                        }
                     } else {
                        var1 = this.gameActorGroupReference01.actorStateReference01.byteValue01;
                        var2 = this.gameActorGroupReference01.actorStateReference01.byteValue02;

                        for (sbyte var5 = 1; var5 <= 7; var5 += 2) {
                           int var29 = var2;
                           int var16 = var1;
                           if (var5 == 1) {
                              var16 = var1 + 1;
                           } else if (var5 == 3) {
                              var29 = var2 - 1;
                           } else if (var5 == 5) {
                              var16 = var1 - 1;
                           } else if (var5 == 7) {
                              var29 = var2 + 1;
                           }

                           if (this.countActiveEntities(var16, var29, var5) != -1) {
                              ActorRuntimeState var17;
                              sbyte var30 = (var17 = this.gameClass9ReferenceArray01[this.countActiveEntities(var16, var29, var5)]).byteValue01;
                              int var6 = var30 + 9;
                              int var7 = var17.shortValue01 - this.gameIntegerValue53;
                              int var8 = var17.shortValue02 - this.gameIntegerValue54;
                              int var9 = gameSpriteDecoderReference01.getSpriteWidth(var6 - 9);
                              int var31 = gameSpriteDecoderReference01.getSpriteHeight(var6 - 9);
                              if (!var17.booleanFlag04) {
                                 var7 += this.gameShortMatrix03[var30][2] * 3 / 2;
                                 var8 += this.gameShortMatrix03[var30][3] * 3 / 2;
                              } else {
                                 var7 = var7 + 108 - this.gameShortMatrix03[var30][2] * 3 / 2 - this.gameShortMatrix03[var30][0] + 1;
                                 var8 += this.gameShortMatrix03[var30][3] * 3 / 2;
                              }

                              switch (var17.byteValue01) {
                                 case 40:
                                    var8 -= 45;
                                    break;
                                 case 60:
                                    var8 -= 75; break;
                              }

                              if (var9 < 30) {
                                 var9 = 40;
                                 var7 -= 20;
                              }

                              if (var31 < 30) {
                                 var31 = 40;
                                 var8 -= this.gameShortMatrix03[var30][3] * 3 / 2;
                              }

                              if (containsPointInBounds(gameIntegerValue31, gameIntegerValue32, var7, var8, var9, var31)) {
                                 if (this.isPlayerActorActive()) {
                                    if (!this.isActorGroupActive(var5)
                                       && this.gameActorGroupReference01.byteValue02 != 6
                                       && (var5 == 1 || !this.isActorGroupActive(1))
                                       && (var5 == 3 || !this.isActorGroupActive(3))
                                       && (var5 == 5 || !this.isActorGroupActive(5))
                                       && var5 != 7) {
                                       this.isActorGroupActive(7);
                                    }

                                    this.faceActorTowardPosition(this.gameActorGroupReference01.actorStateReference01, 0);
                                    initializeInputState();
                                 }

                                 clearInteractionBounds();
                                 clearCollisionBounds();
                                 return false;
                              }
                           } else {
                              gameBooleanFlag19 = false;
                           }
                        }

                        return false;
                     }
                  } else if (this.isGameModeActive(19) && gameBooleanFlag60 && gameIntegerValue119 == 4 || gameRectangleBoundsReference01 != null && gameRectangleBoundsReference01.boundsId == 15 && gameBooleanFlag22 && gameBooleanFlag60) {
                     clearInteractionBounds();
                     clearCollisionBounds();
                     this.processActorAction(8);
                     gameIntegerValue50 = 130;
                     this.gameIntegerValue51 = this.gameByteArray04[2 * this.gameActorGroupReference01.byteValue02 + 1];
                     this.gameIntegerValue81 = this.getActorGroupCount(this.gameActorGroupReference01.byteValue02);
                     this.gameIntegerValue82 = 0;
                     this.gameLongValue10 = this.gameLongValue06;
                     return false;
                  }

                  return false;
               case 646:
                  if (this.isGameModeActive(2821)) {
                     switch (this.gameActorGroupReference01.byteValue04) {
                        case 0:
                        case 1:
                        case 2:
                        case 3:
                           if (this.gameIntegerValue108 == 0) {
                              this.gameLongValue07 = this.gameLongValue06;
                           }

                           gameIntegerValue50 = 647; break;
                     }
                  }

                  if (this.gameIntegerValue106 > this.gameIntegerValue112) {
                     if (this.gameIntegerValue108 == 0) {
                        this.gameLongValue07 = this.gameLongValue06;
                     }

                     gameIntegerValue50 = 647;
                  }

                  return false;
               case 647:
                  if (this.gameLongValue06 - this.gameLongValue07 > 600L) {
                     switch (this.gameActorGroupReference01.byteValue04) {
                        case 0:
                           this.faceActorTowardPosition(this.gameActorGroupReference01.actorStateReference01, 7);
                           gameIntegerValue50 = 904;
                           return false;
                        default:
                           var3 = this.gameIntegerValue107;
                           if (this.gameIntegerValue107 == 2) {
                              this.gameIntegerValue100++;
                              this.gameIntegerValue98++;
                              if (this.gameActorGroupReference01.byteValue04 == 1) {
                                 this.setActorStatus(this.gameActorStateReferenceArray01[this.gameIntegerValue63], -10);
                                 if (this.gameActorStateReferenceArray01[this.gameIntegerValue63].byteValue08 == 5 && this.gameActorStateReferenceArray01[this.gameIntegerValue63].byteValue10 > 0) {
                                    this.faceActorTowardPosition(this.gameActorStateReferenceArray01[this.gameIntegerValue63], 14);
                                 }
                              } else if (this.gameActorGroupReference01.byteValue04 == 2) {
                                 this.setActorStatus(this.gameActorStateReferenceArray01[this.gameIntegerValue63], -30);
                                 if (this.gameActorStateReferenceArray01[this.gameIntegerValue63].byteValue08 == 5 && this.gameActorStateReferenceArray01[this.gameIntegerValue63].byteValue10 > 0) {
                                    this.faceActorTowardPosition(this.gameActorStateReferenceArray01[this.gameIntegerValue63], 14);
                                 }
                              } else if (this.gameActorGroupReference01.byteValue04 == 3) {
                                 this.setActorStatus(this.gameActorStateReferenceArray01[this.gameIntegerValue63], -20);
                                 if (this.gameActorStateReferenceArray01[this.gameIntegerValue63].byteValue08 == 5 && this.gameActorStateReferenceArray01[this.gameIntegerValue63].byteValue10 > 0) {
                                    this.faceActorTowardPosition(this.gameActorStateReferenceArray01[this.gameIntegerValue63], 14);
                                 }
                              }

                              this.initializeLevelTransition();
                           } else if (var3 == 0) {
                              this.gameIntegerValue99++;
                              this.findEntityFrameData(1, this.gameIntegerValue64, this.gameIntegerValue65, 54, 27);
                           } else {
                              this.gameIntegerValue98++;
                              if (this.gameActorGroupReference01.byteValue04 == 1) {
                                 this.setActorStatus(this.gameActorStateReferenceArray01[this.gameIntegerValue63], -3);
                              } else if (this.gameActorGroupReference01.byteValue04 == 2) {
                                 this.setActorStatus(this.gameActorStateReferenceArray01[this.gameIntegerValue63], -9);
                              } else if (this.gameActorGroupReference01.byteValue04 == 3) {
                                 this.setActorStatus(this.gameActorStateReferenceArray01[this.gameIntegerValue63], -6);
                              }

                              this.setActorStatus(this.gameActorStateReferenceArray01[this.gameIntegerValue63], -1);
                              this.initializeLevelTransition();
                           }

                           if (var3 != 0 && this.gameActorStateReferenceArray01[this.gameIntegerValue63].byteValue10 > 0 && isActorActionType(this.gameActorStateReferenceArray01[this.gameIntegerValue63].byteValue08)) {
                              this.processActorAction(28 + (this.nextRandomInteger() & 1));
                           }

                           if (this.gameActorGroupReference01.actorStateReference01.byteValue08 == 0) {
                              if (this.gameActorGroupReference01.byteValue04 == 3) {
                                 this.findEntityFrameData(
                                    13 + this.gameActorGroupReference01.actorStateReference01.byteValue07, this.gameActorGroupReference01.actorStateReference01.byteValue01, this.gameActorGroupReference01.actorStateReference01.byteValue02, 0, 0
                                 );
                              } else {
                                 this.findEntityFrameData(
                                    5 + this.gameActorGroupReference01.actorStateReference01.byteValue07, this.gameActorGroupReference01.actorStateReference01.byteValue01, this.gameActorGroupReference01.actorStateReference01.byteValue02, 0, 0
                                 );
                              }
                           } else if (this.gameActorGroupReference01.byteValue04 == 3) {
                              this.findEntityFrameData(
                                 29 + this.gameActorGroupReference01.actorStateReference01.byteValue07, this.gameActorGroupReference01.actorStateReference01.byteValue01, this.gameActorGroupReference01.actorStateReference01.byteValue02, 0, 0
                              );
                           } else {
                              this.findEntityFrameData(
                                 21 + this.gameActorGroupReference01.actorStateReference01.byteValue07, this.gameActorGroupReference01.actorStateReference01.byteValue01, this.gameActorGroupReference01.actorStateReference01.byteValue02, 0, 0
                              );
                           }

                           this.gameIntegerValue83 = 100;
                           this.advanceLevelEvents((int)(this.gameLongValue06 - this.gameLongValue11));
                           if (this.gameActorStateReferenceArray01[this.gameIntegerValue63].byteValue10 > 0) {
                              this.updatePlayerActorState();
                           }

                           this.faceActorTowardPosition(this.gameActorGroupReference01.actorStateReference01, 5);
                           this.gameActorGroupReference01.byteArray01[this.gameActorGroupReference01.byteValue04]--;
                           gameIntegerValue50 = 900;
                           this.gameIntegerValue107 = 0; break;
                     }
                  }

                  return false;
               case 900:
                  if (gameByteValue07 == 0 || gameByteValue07 == 1) {
                     return false;
                  }

                  this.clearActiveBounds();
                  if (gameBooleanFlag06) {
                     if (this.isGameModeActive(2563)) {
                        if (this.isPlayerActorActive()) {
                           setActorFacingDirection(this.gameActorGroupReference01.actorStateReference01, 4);
                           this.faceActorTowardPosition(this.gameActorGroupReference01.actorStateReference01, 1);
                        } else {
                           this.gameActorGroupReference01.actorStateReference01.longValue01 = this.gameLongValue06;
                        }
                     } else if (this.isGameModeActive(3076)) {
                        if (this.isPlayerActorActive()) {
                           setActorFacingDirection(this.gameActorGroupReference01.actorStateReference01, 0);
                           this.faceActorTowardPosition(this.gameActorGroupReference01.actorStateReference01, 1);
                        } else {
                           this.gameActorGroupReference01.actorStateReference01.longValue01 = this.gameLongValue06;
                        }
                     } else if (this.isGameModeActive(2049)) {
                        if (this.isPlayerActorActive()) {
                           setActorFacingDirection(this.gameActorGroupReference01.actorStateReference01, 2);
                           this.faceActorTowardPosition(this.gameActorGroupReference01.actorStateReference01, 1);
                        } else {
                           this.gameActorGroupReference01.actorStateReference01.longValue01 = this.gameLongValue06;
                        }
                     } else if (this.isGameModeActive(3586)) {
                        if (this.isPlayerActorActive()) {
                           setActorFacingDirection(this.gameActorGroupReference01.actorStateReference01, 6);
                           this.faceActorTowardPosition(this.gameActorGroupReference01.actorStateReference01, 1);
                        } else {
                           this.gameActorGroupReference01.actorStateReference01.longValue01 = this.gameLongValue06;
                        }
                     }
                  } else if (this.isGameModeActive(2563)) {
                     if (this.isPlayerActorActive()) {
                        setActorFacingDirection(this.gameActorGroupReference01.actorStateReference01, 5);
                        this.faceActorTowardPosition(this.gameActorGroupReference01.actorStateReference01, 0);
                     } else {
                        this.gameActorGroupReference01.booleanFlag01 = true;
                     }
                  } else if (this.isGameModeActive(3076)) {
                     if (this.isPlayerActorActive()) {
                        setActorFacingDirection(this.gameActorGroupReference01.actorStateReference01, 1);
                        this.faceActorTowardPosition(this.gameActorGroupReference01.actorStateReference01, 0);
                     } else {
                        this.gameActorGroupReference01.booleanFlag02 = true;
                     }
                  } else if (this.isGameModeActive(2049)) {
                     if (this.isPlayerActorActive()) {
                        setActorFacingDirection(this.gameActorGroupReference01.actorStateReference01, 3);
                        this.faceActorTowardPosition(this.gameActorGroupReference01.actorStateReference01, 0);
                        this.gameActorGroupReference01.booleanFlag01 = false;
                        this.gameActorGroupReference01.booleanFlag02 = false;
                        this.gameActorGroupReference01.booleanFlag03 = false;
                     } else {
                        this.gameActorGroupReference01.booleanFlag02 = true;
                     }
                  } else if (this.isGameModeActive(3586)) {
                     if (this.isPlayerActorActive()) {
                        setActorFacingDirection(this.gameActorGroupReference01.actorStateReference01, -1);
                        this.faceActorTowardPosition(this.gameActorGroupReference01.actorStateReference01, 0);
                     } else {
                        this.gameActorGroupReference01.booleanFlag03 = true;
                     }
                  }

                  if (var1 != 0 && this.gameActorGroupReference01.actorStateReference01.byteValue12 == -1 && this.gameActorGroupReference01.actorStateReference01.byteValue13 == -1) {
                     if (this.gameActorGroupReference01.byteValue02 == 6) {
                        this.updatePlayerState();
                        return false;
                     }

                     if (this.gameByteValue04 == 3
                        && this.gameByteValue03 == 1
                        && this.gameActorGroupReference01.actorStateReference01.byteValue07 == 5
                        && this.gameActorGroupReference01.actorStateReference01.byteValue01 == 2
                        && this.gameActorGroupReference01.actorStateReference01.byteValue02 == 11) {
                        if (this.gameClass9ReferenceArray01[0].booleanFlag02) {
                           this.deactivateActorRuntimeState(0);
                           this.activateActorRuntimeState(24);
                        } else if (this.gameClass9ReferenceArray01[24].booleanFlag02
                           && this.gameActorGroupReference01.byteArray01[this.gameActorGroupReference01.byteValue04] < 100
                           && this.gameActorGroupReference01.byteValue04 != 0
                           && this.gameActorGroupReference01.actorStateReference01.byteValue10 > 0) {
                           gameBooleanFlag61 = true;
                           this.configureActorStatusEffect(true, 770, 0);
                        }

                        return false;
                     }

                     if (gameBooleanFlag07 && this.gameActorGroupReference01.byteValue04 != 0) {
                        if (this.gameActorGroupReference01.byteArray01[this.gameActorGroupReference01.byteValue04] <= 0) {
                           return false;
                        }

                        if ((var1 = this.getActorTileIndex(this.gameActorGroupReference01.actorStateReference01)) != -1
                           && this.gameByteMatrix02[this.gameActorStateReferenceArray01[var1].byteValue01][this.gameActorStateReferenceArray01[var1].byteValue02] != this.gameByteValue05) {
                           var1 = -1;
                        }

                        if (var1 != -1 && this.gameActorGroupReference01.byteValue04 != 4) {
                           this.moveActorTowardTileY(this.gameActorGroupReference01.actorStateReference01, this.gameActorStateReferenceArray01[var1].byteValue01, this.gameActorStateReferenceArray01[var1].byteValue02);
                           this.gameIntegerValue64 = this.gameActorStateReferenceArray01[var1].byteValue01;
                           this.gameIntegerValue65 = this.gameActorStateReferenceArray01[var1].byteValue02;
                           this.gameLongValue07 = this.gameLongValue06;
                           if (this.gameActorGroupReference01.byteValue04 == 1 || this.gameActorGroupReference01.byteValue04 == 2) {
                              this.faceActorTowardPosition(this.gameActorGroupReference01.actorStateReference01, 5);
                           } else if (this.gameActorGroupReference01.byteValue04 == 3 || this.gameActorGroupReference01.byteValue04 == 4) {
                              this.faceActorTowardPosition(this.gameActorGroupReference01.actorStateReference01, 6);
                           }

                           this.gameIntegerValue97++;
                           this.gameIntegerValue101++;
                           this.gameIntegerValue63 = var1;
                           gameIntegerValue50 = 646;
                           this.resetLevelTransition();
                           this.gameLongValue11 = this.gameLongValue06;
                           this.gameLongValue07 = 0L;
                           this.gameIntegerValue81 = 0;
                           this.gameIntegerValue82 = 65536;
                        } else {
                           this.gameIntegerValue97++;
                           this.gameIntegerValue101++;
                           this.updatePlayerActorState();
                           if (this.gameActorGroupReference01.byteValue04 != 4) {
                              if (this.gameActorGroupReference01.actorStateReference01.byteValue08 == 0) {
                                 if (this.gameActorGroupReference01.byteValue04 == 3) {
                                    this.findEntityFrameData(
                                       13 + this.gameActorGroupReference01.actorStateReference01.byteValue07, this.gameActorGroupReference01.actorStateReference01.byteValue01, this.gameActorGroupReference01.actorStateReference01.byteValue02, 0, 0
                                    );
                                 } else {
                                    this.findEntityFrameData(
                                       5 + this.gameActorGroupReference01.actorStateReference01.byteValue07, this.gameActorGroupReference01.actorStateReference01.byteValue01, this.gameActorGroupReference01.actorStateReference01.byteValue02, 0, 0
                                    );
                                 }
                              } else if (this.gameActorGroupReference01.byteValue04 == 3) {
                                 this.findEntityFrameData(
                                    29 + this.gameActorGroupReference01.actorStateReference01.byteValue07, this.gameActorGroupReference01.actorStateReference01.byteValue01, this.gameActorGroupReference01.actorStateReference01.byteValue02, 0, 0
                                 );
                              } else {
                                 this.findEntityFrameData(
                                    21 + this.gameActorGroupReference01.actorStateReference01.byteValue07, this.gameActorGroupReference01.actorStateReference01.byteValue01, this.gameActorGroupReference01.actorStateReference01.byteValue02, 0, 0
                                 );
                              }

                              this.gameIntegerValue83 = 100;
                              this.gameIntegerValue99++;
                              this.faceActorTowardPosition(this.gameActorGroupReference01.actorStateReference01, 5);
                              this.gameActorGroupReference01.byteArray01[this.gameActorGroupReference01.byteValue04]--;
                              gameIntegerValue50 = 900;
                           } else {
                              this.gameIntegerValue64 = wrapTileColumn(this.gameActorGroupReference01.actorStateReference01.byteValue01, this.gameActorGroupReference01.actorStateReference01.byteValue07, 2);
                              this.gameIntegerValue65 = wrapTileRow(this.gameActorGroupReference01.actorStateReference01.byteValue02, this.gameActorGroupReference01.actorStateReference01.byteValue07, 2);
                              this.gameIntegerValue97++;
                              this.gameIntegerValue101++;
                              this.findActorRuntimeState(
                                 4,
                                 this.gameActorGroupReference01.actorStateReference01.byteValue01,
                                 this.gameActorGroupReference01.actorStateReference01.byteValue02,
                                 this.gameIntegerValue64,
                                 this.gameIntegerValue65,
                                 this.gameActorGroupReference01.actorStateReference01.byteValue07
                              );
                              this.gameActorGroupReference01.byteArray01[this.gameActorGroupReference01.byteValue04]--;
                              this.gameIntegerValue83 = 100;
                              this.faceActorTowardPosition(this.gameActorGroupReference01.actorStateReference01, 6);
                              gameIntegerValue50 = 900;
                           }
                        }

                        return false;
                     }

                     switch (this.gameActorGroupReference01.byteValue04) {
                        case 0:
                           this.gameIntegerValue64 = this.gameActorGroupReference01.actorStateReference01.byteValue01;
                           this.gameIntegerValue65 = this.gameActorGroupReference01.actorStateReference01.byteValue02;
                           if (this.gameActorGroupReference01.actorStateReference01.byteValue07 == 1) {
                              this.gameIntegerValue64++;
                           } else if (this.gameActorGroupReference01.actorStateReference01.byteValue07 == 7) {
                              this.gameIntegerValue65++;
                           } else if (this.gameActorGroupReference01.actorStateReference01.byteValue07 == 5) {
                              this.gameIntegerValue64--;
                           } else if (this.gameActorGroupReference01.actorStateReference01.byteValue07 == 3) {
                              this.gameIntegerValue65--;
                           }

                           this.gameIntegerValue63 = this.countActorsAtTile(this.gameIntegerValue64, this.gameIntegerValue65);
                           if (this.gameIntegerValue63 > 0) {
                              gameIntegerValue50 = 646;
                              this.resetLevelTransition();
                              this.gameLongValue11 = this.gameLongValue06;
                              this.gameLongValue07 = 0L;
                              this.gameIntegerValue81 = 0;
                              this.gameIntegerValue82 = 65536;
                           } else {
                              this.faceActorTowardPosition(this.gameActorGroupReference01.actorStateReference01, 7);
                           }
                           break;
                        default:
                           if (this.gameActorGroupReference01.byteArray01[this.gameActorGroupReference01.byteValue04] > 0) {
                              this.gameIntegerValue64 = this.gameActorGroupReference01.actorStateReference01.byteValue01;
                              this.gameIntegerValue65 = this.gameActorGroupReference01.actorStateReference01.byteValue02;
                              if (this.gameActorGroupReference01.actorStateReference01.byteValue07 == 5
                                 && this.gameIntegerValue64 - 1 >= 0
                                 && this.gameByteMatrix02[this.gameIntegerValue64 - 1][this.gameIntegerValue65] == this.gameByteValue05) {
                                 this.gameIntegerValue64--;
                              }

                              if (this.gameActorGroupReference01.actorStateReference01.byteValue07 == 1
                                 && this.gameIntegerValue64 + 1 < this.gameByteValue12
                                 && this.gameByteMatrix02[this.gameIntegerValue64 + 1][this.gameIntegerValue65] == this.gameByteValue05) {
                                 this.gameIntegerValue64++;
                              }

                              if (this.gameActorGroupReference01.actorStateReference01.byteValue07 == 3
                                 && this.gameIntegerValue65 - 1 >= 0
                                 && this.gameByteMatrix02[this.gameIntegerValue64][this.gameIntegerValue65 - 1] == this.gameByteValue05) {
                                 this.gameIntegerValue65--;
                              }

                              if (this.gameActorGroupReference01.actorStateReference01.byteValue07 == 7
                                 && this.gameIntegerValue65 + 1 < this.gameByteValue13
                                 && this.gameByteMatrix02[this.gameIntegerValue64][this.gameIntegerValue65 + 1] == this.gameByteValue05) {
                                 this.gameIntegerValue65++;
                              }

                              if (this.gameActorGroupReference01.actorStateReference01.byteValue07 == 4
                                 && this.gameIntegerValue64 - 1 >= 0
                                 && this.gameIntegerValue65 - 1 >= 0
                                 && this.gameByteMatrix02[this.gameIntegerValue64 - 1][this.gameIntegerValue65 - 1] == this.gameByteValue05) {
                                 this.gameIntegerValue64--;
                                 this.gameIntegerValue65--;
                              }

                              if (this.gameActorGroupReference01.actorStateReference01.byteValue07 == 0
                                 && this.gameIntegerValue64 + 1 < this.gameByteValue12
                                 && this.gameIntegerValue65 + 1 < this.gameByteValue13
                                 && this.gameByteMatrix02[this.gameIntegerValue64 + 1][this.gameIntegerValue65 + 1] == this.gameByteValue05) {
                                 this.gameIntegerValue64++;
                                 this.gameIntegerValue65++;
                              }

                              if (this.gameActorGroupReference01.actorStateReference01.byteValue07 == 2
                                 && this.gameIntegerValue64 + 1 < this.gameByteValue12
                                 && this.gameIntegerValue65 - 1 >= 0
                                 && this.gameByteMatrix02[this.gameIntegerValue64 + 1][this.gameIntegerValue65 - 1] == this.gameByteValue05) {
                                 this.gameIntegerValue64++;
                                 this.gameIntegerValue65--;
                              }

                              if (this.gameActorGroupReference01.actorStateReference01.byteValue07 == 6
                                 && this.gameIntegerValue64 - 1 >= 0
                                 && this.gameIntegerValue65 + 1 < this.gameByteValue13
                                 && this.gameByteMatrix02[this.gameIntegerValue64 - 1][this.gameIntegerValue65 + 1] == this.gameByteValue05) {
                                 this.gameIntegerValue64--;
                                 this.gameIntegerValue65++;
                              }

                              this.resetLevelTransition();
                              gameIntegerValue50 = 901;
                              this.gameLongValue07 = this.gameLongValue06;
                           } break;
                     }

                     clearInteractionBounds();
                     clearCollisionBounds();
                  } else if (this.isGameModeActive(19) || gameRectangleBoundsReference01 != null && gameRectangleBoundsReference01.boundsId == 15 && gameBooleanFlag22) {
                     clearCollisionBounds();
                     clearInteractionBounds();
                     gameIntegerValue50 = 130;
                     this.gameIntegerValue51 = this.gameByteArray04[2 * this.gameActorGroupReference01.byteValue02 + 1];
                     this.gameIntegerValue81 = this.getActorGroupCount(this.gameActorGroupReference01.byteValue02);
                     this.gameIntegerValue82 = 0;
                     this.gameLongValue10 = this.gameLongValue06;
                     return false;
                  }

                  return false;
               case 901:
                  switch (this.gameActorGroupReference01.byteValue04) {
                     case 1:
                     case 2:
                     case 3:
                        if (this.isGameModeActive(2563)) {
                           if (this.gameIntegerValue64 - 1 >= 0 && this.gameByteMatrix02[this.gameIntegerValue64 - 1][this.gameIntegerValue65] == this.gameByteValue05) {
                              this.gameIntegerValue64--;
                           }
                        } else if (this.isGameModeActive(3076)) {
                           if (this.gameIntegerValue64 + 1 < this.gameByteValue12 && this.gameByteMatrix02[this.gameIntegerValue64 + 1][this.gameIntegerValue65] == this.gameByteValue05) {
                              this.gameIntegerValue64++;
                           }
                        } else if (this.isGameModeActive(2049)) {
                           if (this.gameIntegerValue65 - 1 >= 0 && this.gameByteMatrix02[this.gameIntegerValue64][this.gameIntegerValue65 - 1] == this.gameByteValue05) {
                              this.gameIntegerValue65--;
                           }
                        } else if (this.isGameModeActive(3586)) {
                           if (this.gameIntegerValue65 + 1 < this.gameByteValue13 && this.gameByteMatrix02[this.gameIntegerValue64][this.gameIntegerValue65 + 1] == this.gameByteValue05) {
                              this.gameIntegerValue65++;
                           }
                        } else if (this.isGameModeActive(2821)) {
                           this.gameIntegerValue97++;
                           this.gameIntegerValue102++;
                           this.gameIntegerValue63 = this.countActorsAtTile(this.gameIntegerValue64, this.gameIntegerValue65);
                           if (this.gameIntegerValue63 > 0) {
                              gameIntegerValue50 = 646;
                              this.resetLevelTransition();
                              this.gameLongValue11 = this.gameLongValue06;
                              this.gameLongValue07 = 0L;
                              this.gameIntegerValue81 = 0;
                              this.gameIntegerValue82 = 65536;
                           } else {
                              if (this.gameActorGroupReference01.actorStateReference01.byteValue08 == 0) {
                                 if (this.gameActorGroupReference01.byteValue04 == 3) {
                                    this.findEntityFrameData(
                                       13 + this.gameActorGroupReference01.actorStateReference01.byteValue07, this.gameActorGroupReference01.actorStateReference01.byteValue01, this.gameActorGroupReference01.actorStateReference01.byteValue02, 0, 0
                                    );
                                 } else {
                                    this.findEntityFrameData(
                                       5 + this.gameActorGroupReference01.actorStateReference01.byteValue07, this.gameActorGroupReference01.actorStateReference01.byteValue01, this.gameActorGroupReference01.actorStateReference01.byteValue02, 0, 0
                                    );
                                 }
                              } else if (this.gameActorGroupReference01.byteValue04 == 3) {
                                 this.findEntityFrameData(
                                    29 + this.gameActorGroupReference01.actorStateReference01.byteValue07, this.gameActorGroupReference01.actorStateReference01.byteValue01, this.gameActorGroupReference01.actorStateReference01.byteValue02, 0, 0
                                 );
                              } else {
                                 this.findEntityFrameData(
                                    21 + this.gameActorGroupReference01.actorStateReference01.byteValue07, this.gameActorGroupReference01.actorStateReference01.byteValue01, this.gameActorGroupReference01.actorStateReference01.byteValue02, 0, 0
                                 );
                              }

                              this.gameIntegerValue83 = 100;
                              this.gameIntegerValue99++;
                              this.faceActorTowardPosition(this.gameActorGroupReference01.actorStateReference01, 5);
                              this.gameActorGroupReference01.byteArray01[this.gameActorGroupReference01.byteValue04]--;
                              gameIntegerValue50 = 900;
                              this.updatePlayerActorState();
                           }
                        }

                        var14 = this.gameIntegerValue64 - this.gameActorGroupReference01.actorStateReference01.byteValue01;
                        var4 = this.gameIntegerValue65 - this.gameActorGroupReference01.actorStateReference01.byteValue02;
                        gameIntegerValue45 = 0;
                        break;
                     case 4:
                        if (this.isGameModeActive(2563)) {
                           if (this.gameIntegerValue64 - 1 >= 0 && this.gameByteMatrix02[this.gameIntegerValue64 - 1][this.gameIntegerValue65] == this.gameByteValue05) {
                              this.gameIntegerValue64--;
                           }
                        } else if (this.isGameModeActive(3076)) {
                           if (this.gameIntegerValue64 + 1 < this.gameByteValue12 && this.gameByteMatrix02[this.gameIntegerValue64 + 1][this.gameIntegerValue65] == this.gameByteValue05) {
                              this.gameIntegerValue64++;
                           }
                        } else if (this.isGameModeActive(2049)) {
                           if (this.gameIntegerValue65 - 1 >= 0 && this.gameByteMatrix02[this.gameIntegerValue64][this.gameIntegerValue65 - 1] == this.gameByteValue05) {
                              this.gameIntegerValue65--;
                           }
                        } else if (this.isGameModeActive(3586)) {
                           if (this.gameIntegerValue65 + 1 < this.gameByteValue13 && this.gameByteMatrix02[this.gameIntegerValue64][this.gameIntegerValue65 + 1] == this.gameByteValue05) {
                              this.gameIntegerValue65++;
                           }
                        } else if (this.isGameModeActive(2821)) {
                           this.gameIntegerValue97++;
                           this.gameIntegerValue102++;
                           this.findActorRuntimeState(
                              4,
                              this.gameActorGroupReference01.actorStateReference01.byteValue01,
                              this.gameActorGroupReference01.actorStateReference01.byteValue02,
                              this.gameIntegerValue64,
                              this.gameIntegerValue65,
                              this.gameActorGroupReference01.actorStateReference01.byteValue07
                           );
                           this.gameActorGroupReference01.byteArray01[this.gameActorGroupReference01.byteValue04]--;
                           this.gameIntegerValue83 = 100;
                           this.faceActorTowardPosition(this.gameActorGroupReference01.actorStateReference01, 6);
                           gameIntegerValue50 = 900;
                        }

                        var14 = this.gameIntegerValue64 - this.gameActorGroupReference01.actorStateReference01.byteValue01;
                        var4 = this.gameIntegerValue65 - this.gameActorGroupReference01.actorStateReference01.byteValue02; break;
                  }

                  if (var14 == 0 && var4 == 0) {
                     setActorFacingDirection(this.gameActorGroupReference01.actorStateReference01, 0);
                     return false;
                  } else if (absoluteValue(var4) << 1 <= absoluteValue(var14)) {
                     if (var14 <= 0) {
                        setActorFacingDirection(this.gameActorGroupReference01.actorStateReference01, 5);
                     } else {
                        setActorFacingDirection(this.gameActorGroupReference01.actorStateReference01, 1);
                     }

                     return false;
                  } else if (absoluteValue(var4) <= absoluteValue(var14) << 1) {
                     if (var14 <= 0 && var4 <= 0) {
                        setActorFacingDirection(this.gameActorGroupReference01.actorStateReference01, 4);
                        return false;
                     } else if (var14 <= 0) {
                        setActorFacingDirection(this.gameActorGroupReference01.actorStateReference01, 6);
                        return false;
                     } else {
                        if (var4 <= 0) {
                           setActorFacingDirection(this.gameActorGroupReference01.actorStateReference01, 2);
                        } else {
                           setActorFacingDirection(this.gameActorGroupReference01.actorStateReference01, 0);
                        }

                        return false;
                     }
                  } else {
                     if (var4 <= 0) {
                        setActorFacingDirection(this.gameActorGroupReference01.actorStateReference01, 3);
                     } else {
                        setActorFacingDirection(this.gameActorGroupReference01.actorStateReference01, 7);
                     }

                     return false;
                  } goto case 904;
               case 904:
               default:
                  return false;
            } goto case 3;
         case 3:
            try {
               this.gameLongValue07 = this.gameLongValue07 + (long)gameIntegerValue129;
               if (this.gameLongValue07 > -1L) {
                  this.changeActorAction(1, 129);
                  this.setViewport(2, -1, 3);
                  gameSpriteDecoderReferenceArray01[1] = null;
                  return true;
               }
            } catch (System.Exception var10) {
               JSystem.@out.println("sometime occur null pointer exception !!!");
            } break;
      }

      return false;
   }

   // $VF: renamed from: k () boolean
   public bool isLevelComplete() {
      if (this.gameShortValue14 == 0) {
         if (this.gameByteArray04[2 * this.gameIntegerValue84] < 6) {
            if (this.gameByteArray04[2 * this.gameIntegerValue84 + 1] > 1
               && this.gameByteArray04[2 * this.gameIntegerValue84 + 1] < 6
               && this.gameActorGroupReference04.entitySnapshotReferenceArray01[this.gameByteArray04[2 * this.gameIntegerValue84]].booleanFlag01
               && this.gameActorGroupReference03.byteArray01[this.gameByteArray04[2 * this.gameIntegerValue84 + 1] - 1] > 0) {
               this.gameActorGroupReference03.byteArray01[this.gameByteArray04[2 * this.gameIntegerValue84 + 1] - 1]--;
               this.gameActorGroupReference04.byteArray01[this.gameByteArray04[2 * this.gameIntegerValue84 + 1] - 1]++;
               this.processActorAction(8);
            }

            return false;
         }

         if (this.gameByteArray04[2 * this.gameIntegerValue84] == 6) {
            if (this.gameActorGroupReference03.byteArray01[this.gameByteArray04[2 * this.gameIntegerValue84 + 1] - 1] < 1) {
               return false;
            }

            this.gameActorGroupReference03.byteArray01[this.gameByteArray04[2 * this.gameIntegerValue84 + 1] - 1]--;
            this.gameActorGroupReference04.byteArray01[this.gameByteArray04[2 * this.gameIntegerValue84 + 1] - 1]++;
            if (!this.gameActorGroupReference04.entitySnapshotReferenceArray01[this.gameByteArray04[2 * this.gameIntegerValue84]].booleanFlag01) {
               this.gameActorGroupReference04.entitySnapshotReferenceArray01[this.gameByteArray04[2 * this.gameIntegerValue84]].booleanFlag01 = true;
               this.gameActorGroupReference04.byteValue03++;
            }

            if (this.gameActorGroupReference03.byteArray01[this.gameByteArray04[2 * this.gameIntegerValue84 + 1] - 1] < 1) {
               this.gameActorGroupReference03.byteArray01[this.gameByteArray04[2 * this.gameIntegerValue84 + 1] - 1] = 0;
               this.gameActorGroupReference03.entitySnapshotReferenceArray01[this.gameByteArray04[2 * this.gameIntegerValue84]].booleanFlag01 = false;
               this.gameActorGroupReference03.byteValue03--;

               do {
                  this.gameIntegerValue84--;
                  if (this.gameIntegerValue84 < 1) {
                     this.gameIntegerValue84 = this.gameActorGroupReference03.byteValue01 - 1;
                  }
               } while (!this.gameActorGroupReference03.entitySnapshotReferenceArray01[this.gameByteArray04[2 * this.gameIntegerValue84]].booleanFlag01);

               int var2 = this.countActorsByType(this.gameByteArray04[2 * this.gameIntegerValue84], (sbyte)1);
               this.gameIntegerValue86 = JMath.min(this.gameIntegerValue86, var2);
               this.gameIntegerValue86 = JMath.max(this.gameIntegerValue86, var2 - this.gameIntegerValue88 + 1);
            }

            this.processActorAction(8);
            return false;
         }

         this.gameActorGroupReference04.entitySnapshotReferenceArray01[this.gameByteArray04[2 * this.gameIntegerValue84]].booleanFlag01 = true;
         this.gameActorGroupReference04.byteValue03++;
         this.gameActorGroupReference03.entitySnapshotReferenceArray01[this.gameByteArray04[2 * this.gameIntegerValue84]].booleanFlag01 = false;
         this.gameActorGroupReference03.byteValue03--;

         do {
            this.gameIntegerValue84--;
            if (this.gameIntegerValue84 < 1) {
               this.gameIntegerValue84 = this.gameActorGroupReference03.byteValue01 - 1;
            }
         } while (!this.gameActorGroupReference03.entitySnapshotReferenceArray01[this.gameByteArray04[2 * this.gameIntegerValue84]].booleanFlag01);

         int var1 = this.countActorsByType(this.gameByteArray04[2 * this.gameIntegerValue84], (sbyte)1);
         this.gameIntegerValue86 = JMath.min(this.gameIntegerValue86, var1);
         this.gameIntegerValue86 = JMath.max(this.gameIntegerValue86, var1 - this.gameIntegerValue88 + 1);
         this.processActorAction(8);
      } else {
         if (this.gameByteArray04[2 * this.gameIntegerValue85] < 6) {
            if (this.gameByteArray04[2 * this.gameIntegerValue85 + 1] > 1
               && this.gameByteArray04[2 * this.gameIntegerValue85 + 1] < 6
               && this.gameActorGroupReference03.entitySnapshotReferenceArray01[this.gameByteArray04[2 * this.gameIntegerValue85]].booleanFlag01
               && this.gameActorGroupReference04.byteArray01[this.gameByteArray04[2 * this.gameIntegerValue85 + 1] - 1] > 0) {
               this.gameActorGroupReference04.byteArray01[this.gameByteArray04[2 * this.gameIntegerValue85 + 1] - 1]--;
               this.gameActorGroupReference03.byteArray01[this.gameByteArray04[2 * this.gameIntegerValue85 + 1] - 1]++;
               this.processActorAction(8);
            }

            return false;
         }

         if (this.gameByteArray04[2 * this.gameIntegerValue85] == 6) {
            if (this.gameActorGroupReference04.byteArray01[this.gameByteArray04[2 * this.gameIntegerValue85 + 1] - 1] < 1) {
               return false;
            }

            this.gameActorGroupReference04.byteArray01[this.gameByteArray04[2 * this.gameIntegerValue85 + 1] - 1]--;
            this.gameActorGroupReference03.byteArray01[this.gameByteArray04[2 * this.gameIntegerValue85 + 1] - 1]++;
            if (!this.gameActorGroupReference03.entitySnapshotReferenceArray01[this.gameByteArray04[2 * this.gameIntegerValue85]].booleanFlag01) {
               this.gameActorGroupReference03.entitySnapshotReferenceArray01[this.gameByteArray04[2 * this.gameIntegerValue85]].booleanFlag01 = true;
               this.gameActorGroupReference03.byteValue03++;
            }

            if (this.gameActorGroupReference04.byteArray01[this.gameByteArray04[2 * this.gameIntegerValue85 + 1] - 1] < 1) {
               this.gameActorGroupReference04.byteArray01[this.gameByteArray04[2 * this.gameIntegerValue85 + 1] - 1] = 0;
               this.gameActorGroupReference04.entitySnapshotReferenceArray01[this.gameByteArray04[2 * this.gameIntegerValue85]].booleanFlag01 = false;
               this.gameActorGroupReference04.byteValue03--;

               do {
                  this.gameIntegerValue85--;
                  if (this.gameIntegerValue85 < 1) {
                     this.gameIntegerValue85 = this.gameActorGroupReference04.byteValue01 - 1;
                  }
               } while (!this.gameActorGroupReference04.entitySnapshotReferenceArray01[this.gameByteArray04[2 * this.gameIntegerValue85]].booleanFlag01);

               int var4 = this.countActorsByType(this.gameByteArray04[2 * this.gameIntegerValue84], (sbyte)2);
               this.gameIntegerValue87 = JMath.min(this.gameIntegerValue87, var4);
               this.gameIntegerValue87 = JMath.max(this.gameIntegerValue87, var4 - this.gameIntegerValue88 + 1);
            }

            this.processActorAction(8);
            return false;
         }

         this.gameActorGroupReference03.entitySnapshotReferenceArray01[this.gameByteArray04[2 * this.gameIntegerValue85]].booleanFlag01 = true;
         this.gameActorGroupReference03.byteValue03++;
         this.gameActorGroupReference04.entitySnapshotReferenceArray01[this.gameByteArray04[2 * this.gameIntegerValue85]].booleanFlag01 = false;
         this.gameActorGroupReference04.byteValue03--;

         do {
            this.gameIntegerValue85--;
            if (this.gameIntegerValue85 < 1) {
               this.gameIntegerValue85 = this.gameActorGroupReference04.byteValue01 - 1;
            }
         } while (!this.gameActorGroupReference04.entitySnapshotReferenceArray01[this.gameByteArray04[2 * this.gameIntegerValue85]].booleanFlag01);

         int var3 = this.countActorsByType(this.gameByteArray04[2 * this.gameIntegerValue85], (sbyte)2);
         this.gameIntegerValue87 = JMath.min(this.gameIntegerValue87, var3);
         this.gameIntegerValue87 = JMath.max(this.gameIntegerValue87, var3 - this.gameIntegerValue89 + 1);
         this.processActorAction(8);
      }

      return true;
   }

   // $VF: renamed from: f (javax.microedition.lcdui.Graphics) void
   public void drawGameBackground(Graphics var1) {
      var1.setColor(3816503);
      fillRectangle(var1, 0, 0, gameIntegerValue41, gameIntegerValue42);
      gameIntegerValue35 = gameSpriteDecoderReferenceArray09[0].getSpriteHeight(39) + 2;
      int var3 = 365 + gameIntegerValue35 + 4;
      int var2 = gameIntegerValue42 - (var3 + 44);
      int var4 = gameIntegerValue42 - var2;
      int var5 = 32;
      drawTextWithFont(var1, getStringResource(32), 8, 7, 20);
      var1.setColor(0);
      fillRectangle(var1, 7, 41, gameIntegerValue41 - 30, var3 + gameIntegerValue35);
      if (this.gameIntegerValue82 == 0) {
         this.gameIntegerValue82 = var3 / 60;
         this.gameIntegerValue82 = (var3 - gameIntegerValue35) / 60;
         this.gameIntegerValue81 = JMath.max(0, JMath.min(this.gameIntegerValue81, this.gameActorGroupReference01.byteValue03 - this.gameIntegerValue82));
      }

      gameIntegerValue34 = gameSpriteDecoderReferenceArray09[0].getSpriteWidth(39) + 2;
      gameIntegerValue35 = gameSpriteDecoderReferenceArray09[0].getSpriteHeight(39) + 2;
      SpriteResourceDecoder var10000 = gameSpriteDecoderReferenceArray09[0];
      int var10002 = gameRectangleBoundsReference01 != null && gameRectangleBoundsReference01.boundsId == 1 ? 40 : 39;
      int var7 = 44 + (gameIntegerValue35 >> 1);
      int var6 = var10002;
      Graphics var22 = gameGraphicsReference02;
      var10000.drawSpriteFrameTransformed(var22, var6, 180, var7, 0, 0, 0);
      if (!gameBooleanFlag29) {
         addCollisionBounds(180 - (gameIntegerValue34 >> 1), 44, gameIntegerValue34, gameIntegerValue35, 1);
      }

      int var8 = 44 + gameIntegerValue35 + 2;
      var6 = this.gameIntegerValue81;

      for (int var30 = this.countActiveActorsByType(var6, this.gameByteValue03); var30 < this.gameActorGroupReference01.byteValue01; var30++) {
         sbyte var33 = this.gameByteArray04[var30 * 2];
         if (var8 + 60 > var3 + 44) {
            break;
         }

         if (this.gameActorGroupReference01.entitySnapshotReferenceArray01[var33].booleanFlag01) {
            var2 = var8 + 2;
            if (var30 == this.gameIntegerValue51 && var33 == this.gameActorGroupReference01.byteValue02) {
               var5 = (sbyte)5;
            } else if (var30 == this.gameIntegerValue51) {
               var5 = (sbyte)3;
            } else if (var33 == this.gameActorGroupReference01.byteValue02) {
               var5 = (sbyte)4;
            } else {
               var5 = (sbyte)2;
            }

            this.drawActorSprite(var1, 11, var2, gameIntegerValue41 - 26 - 11, 52, var5);
            if (!gameBooleanFlag29) {
               addCollisionBounds(11, var2, gameIntegerValue41 - 26 - 11, 52, var30 + 100);
            }

            this.drawSpriteEffect(var1, (sbyte)var33, 18, var2 + 5);
            var5 = this.gameActorGroupReference01.entitySnapshotReferenceArray01[var33].integerValue01;
            drawCenteredText(var1, getStringResource(this.gameActorGroupReference01.entitySnapshotReferenceArray01[var33].integerValue01), 0, 80, var2 + 27, 80, var2, gameIntegerValue41 - 22 - 7, var2 + 52, 21);
            var8 = var2 + 58;
         }
      }

      var10000 = gameSpriteDecoderReferenceArray09[0];
      var10002 = gameRectangleBoundsReference01 != null && gameRectangleBoundsReference01.boundsId == 2 ? 42 : 41;
      var7 = var8 + (gameIntegerValue35 >> 1);
      var6 = var10002;
      Graphics var25 = gameGraphicsReference02;
      var10000.drawSpriteFrameTransformed(var25, var6, 180, var7, 0, 0, 0);
      if (!gameBooleanFlag29) {
         addCollisionBounds(180 - (gameIntegerValue34 >> 1), var8, gameIntegerValue34, gameIntegerValue35, 2);
      }

      if (!gameBooleanFlag29) {
         gameBooleanFlag10 = true;
      }

      bool var26 = true;
      var3 = var8 - 44 - 4;
      var2 = 44 + gameIntegerValue35 + 2;
      if ((var3 = var3 - (gameIntegerValue35 + 2)) < 30 || gameIntegerValue42 < 128) {
         var3 = 30;
         var26 = false;
      }

      if (this.gameActorGroupReference01.byteValue03 > 1) {
         this.setRgbColor(var1, 3558425);
         drawRectangleOutline(var1, gameIntegerValue41 - 18, var2, 15, var3);
         this.setRgbColor(var1, 3158573);
         fillRectangle(var1, gameIntegerValue41 - 17, var2 + 1, 13, var3 - 2);
         this.setRgbColor(var1, 4151325);
         fillRectangle(var1, gameIntegerValue41 - 19, var2 + 1, 1, var3 - 2);
         fillRectangle(var1, gameIntegerValue41 - 3, var2 + 1, 1, var3 - 2);
         if (var26) {
            this.setRgbColor(var1, 8484209);
            var2 = var2 + 2 + this.getActorGroupCount(this.gameByteArray04[2 * this.gameIntegerValue51]) * (var3 - 4 - 16) / (this.gameActorGroupReference01.byteValue03 - 1);
            drawRectangleOutline(var1, gameIntegerValue41 - 16, var2, 11, 16);
            this.setRgbColor(var1, 4211516);
            fillRectangle(var1, gameIntegerValue41 - 15, var2 + 1, 9, 14);
         }
      }

      int var19;
      var2 = var19 = var4 + gameIntegerValue35;
      this.setRgbColor(var1, 0);
      fillRectangle(var1, 7, var2, gameIntegerValue41 - 28, gameIntegerValue42 - var2 - 5);
      short var32 = 255;
      int var20 = 255;
      int var17 = 255;
      var1.setColor(var17, var20, var32);
      this.gameStringBufferReference01.setLength(0);
      this.gameStringBufferReference01.append(getStringResource(var5 = this.gameActorGroupReference01.entitySnapshotReferenceArray01[this.gameByteArray04[2 * this.gameIntegerValue51]].integerValue01 + 1));
      this.gameIntegerValue92 = drawCenteredText(
         var1, this.gameStringBufferReference01.toString(), 0, 9, var19 + 2 - this.gameIntegerValue91, 9, var19 + 2, gameIntegerValue41 - 22 - 9, var19 + 2 + 7 * (AnimationTables.byteArray02[0] + 1), 20
      );
      if (this.gameIntegerValue91 != 0) {
         var10000 = gameSpriteDecoderReferenceArray06[0];
         var5 = var19 - 5;
         var20 = gameIntegerValue43;
         var10000.drawSpriteFrameTransformed(var1, 2, var20, var5, 0, 0, 0);
      }

      if (this.gameIntegerValue91 != JMath.max(this.gameIntegerValue92 - 7 * (AnimationTables.byteArray02[0] + 1), 0)) {
         var10000 = gameSpriteDecoderReferenceArray06[0];
         var17 = gameIntegerValue42 - 5;
         var2 = gameIntegerValue43;
         var10000.drawSpriteFrameTransformed(var1, 3, var2, var17, 0, 0, 0);
      }
   }

   // $VF: renamed from: g (javax.microedition.lcdui.Graphics) void
   public void drawGameBackgroundOverlay(Graphics var1) {
      this.setRgbColor(var1, 3816503);
      fillRectangle(var1, 0, 0, gameIntegerValue41, gameIntegerValue42);
      short var7 = 255;
      short var6 = 255;
      int var4 = 255;
      var1.setColor(var4, var6, var7);
      int var3 = 33;
      drawTextWithFont(var1, getStringResource(33), gameIntegerValue43, 7, 36);
      gameSpriteDecoderReferenceArray06[3].drawSpriteFrameTransformed(var1, 0, 2, 74, 0, 0, 0);
      SpriteResourceDecoder var10000 = gameSpriteDecoderReferenceArray06[3];
      var4 = gameIntegerValue41 - 84;
      var10000.drawSpriteFrameTransformed(var1, 1, var4, 74, 0, 0, 0);
      int var2 = this.gameByteValue02 + 4 << 3;
      int var5 = gameIntegerValue42 - var2;
      int var44 = 0;
      int var34 = 0;
      int var30 = 0;
      var1.setColor(var30, var34, var44);
      fillRectangle(var1, 2, 42, gameIntegerValue41 - 4, gameIntegerValue42 - var2 - 4 - 42);
      fillRectangle(var1, 2, var5, gameIntegerValue41 - 4, gameIntegerValue42 - var5 - 1);
      var30 = var5 - 46 - 4;
      this.gameIntegerValue88 = var30 / 60;
      if (this.gameIntegerValue88 > 6) {
         this.gameIntegerValue88 = 6;
      }

      this.gameIntegerValue86 = JMath.max(0, JMath.min(this.gameIntegerValue86, this.gameActorGroupReference03.byteValue03 - this.gameIntegerValue88));
      gameIntegerValue34 = gameSpriteDecoderReferenceArray09[0].getSpriteWidth(39) + 2;
      gameIntegerValue35 = gameSpriteDecoderReferenceArray09[0].getSpriteHeight(39) + 2;
      if (this.gameShortValue14 == 0) {
         var10000 = gameSpriteDecoderReferenceArray09[0];
         int var10002 = gameRectangleBoundsReference01 != null && gameRectangleBoundsReference01.boundsId == 1 ? 40 : 39;
         var44 = 46 + (gameIntegerValue35 >> 1);
         var34 = var10002;
         Graphics var17 = gameGraphicsReference02;
         var10000.drawSpriteFrameTransformed(var17, var34, 90, var44, 0, 0, 0);
      }

      addCollisionBounds(90 - (gameIntegerValue34 >> 1), 46, gameIntegerValue35, gameIntegerValue35, 1);
      int var8 = 1;
      int var9 = 46 + gameIntegerValue35 + 2;

      for (int var36 = this.countActiveActorsByType(this.gameIntegerValue86, (sbyte)1); var36 < this.gameActorGroupReference03.byteValue01; var36++) {
         sbyte var46 = this.gameByteArray04[var36 * 2];
         if (var9 + 60 > var30 + 46) {
            break;
         }

         if (this.gameActorGroupReference03.entitySnapshotReferenceArray01[var46].booleanFlag01 && this.gameByteArray04[var36 * 2 + 1] >= 1) {
            if (var8 > 6) {
               break;
            }

            var2 = var9 + 2;
            if (var36 == this.gameIntegerValue84 && this.gameShortValue14 == 0) {
               var3 = (sbyte)3;
            } else {
               var3 = (sbyte)2;
            }

            this.drawActorSprite(var1, 7, var2, gameIntegerValue43 - 30, 52, var3);
            addCollisionBounds(7, var2, gameIntegerValue43 - 30, 52, var36 + 100);
            this.drawSpriteEffect(var1, (sbyte)var46, 14, var2 + 5);
            if (this.gameByteArray04[var46 * 2 + 1] > 1 && this.gameByteArray04[var46 * 2 + 1] < 7) {
               string var19 = JString.valueOf(this.gameActorGroupReference03.byteArray01[this.gameByteArray04[var46 * 2 + 1] - 1]);
               drawTextWithFont(var1, var19, 56 + (gameIntegerValue43 - 44 - 42) / 2, var2 + 5 + 21 - this.gameByteValue02 / 2, 36);
            }

            if (this.gameByteArray04[var46 * 2 + 1] == 36) {
               drawTextWithFont(var1, "'1'", 56 + (gameIntegerValue43 - 44 - 42) / 2, var2 + 5 + 21 - this.gameByteValue02 / 2, 36);
            } else if (this.gameByteArray04[var46 * 2 + 1] == 37) {
               drawTextWithFont(var1, "'2'", 56 + (gameIntegerValue43 - 44 - 42) / 2, var2 + 5 + 21 - this.gameByteValue02 / 2, 36);
            }

            var9 = var2 + 58;
            var8++;
         }
      }

      if (this.gameShortValue14 == 0) {
         var10000 = gameSpriteDecoderReferenceArray09[0];
         int var58 = gameRectangleBoundsReference01 != null && gameRectangleBoundsReference01.boundsId == 2 ? 42 : 41;
         var8 = var9 + (gameIntegerValue35 >> 1);
         var44 = var58;
         Graphics var37 = gameGraphicsReference02;
         var10000.drawSpriteFrameTransformed(var37, var44, 90, var8, 0, 0, 0);
      }

      addCollisionBounds(90 - (gameIntegerValue34 >> 1), var9, gameIntegerValue34, gameIntegerValue35, 2);
      bool var38 = true;
      var3 = var9 - 46 - 4;
      var2 = 46 + gameIntegerValue35 + 2;
      if ((var3 = var3 - (gameIntegerValue35 + 2)) < 30 || gameIntegerValue42 < 128) {
         var38 = false;
         var3 = 30;
      }

      if (this.gameActorGroupReference03.byteValue03 > 1) {
         this.setRgbColor(var1, 3558425);
         drawRectangleOutline(var1, gameIntegerValue43 - 18, var2, 15, var3);
         this.setRgbColor(var1, 3158573);
         fillRectangle(var1, gameIntegerValue43 - 17, var2 + 1, 13, var3 - 2);
         this.setRgbColor(var1, 4151325);
         fillRectangle(var1, gameIntegerValue43 - 19, var2 + 1, 1, var3 - 2);
         fillRectangle(var1, gameIntegerValue43 - 3, var2 + 1, 1, var3 - 2);
         if (var38) {
            this.setRgbColor(var1, 8484209);
            var2 = var2 + 2 + (this.countActorsByType(this.gameByteArray04[2 * this.gameIntegerValue84], (sbyte)1) - 1) * (var3 - 4 - 16) / (this.gameActorGroupReference03.byteValue03 - 2);
            drawRectangleOutline(var1, gameIntegerValue43 - 16, var2, 11, 16);
            this.setRgbColor(var1, 4211516);
            fillRectangle(var1, gameIntegerValue43 - 15, var2 + 1, 9, 14);
         }
      }

      this.gameIntegerValue89 = var30 / 60;
      if (this.gameIntegerValue89 > 6) {
         this.gameIntegerValue89 = 6;
      }

      this.gameIntegerValue87 = JMath.max(0, JMath.min(this.gameIntegerValue87, this.gameActorGroupReference04.byteValue03 - this.gameIntegerValue89));
      if (this.gameShortValue14 == 1) {
         var10000 = gameSpriteDecoderReferenceArray09[0];
         int var59 = gameRectangleBoundsReference01 != null && gameRectangleBoundsReference01.boundsId == 3 ? 40 : 39;
         var44 = 46 + (gameIntegerValue35 >> 1);
         var34 = var59;
         Graphics var22 = gameGraphicsReference02;
         var10000.drawSpriteFrameTransformed(var22, var34, 270, var44, 0, 0, 0);
      }

      addCollisionBounds(270 - (gameIntegerValue35 >> 1), 46, gameIntegerValue35, gameIntegerValue35, 3);
      int var53 = 1;
      int var13 = 46 + gameIntegerValue35 + 2;

      for (int var40 = this.countActiveActorsByType(this.gameIntegerValue87, (sbyte)2); var40 < this.gameActorGroupReference04.byteValue01; var40++) {
         sbyte var49 = this.gameByteArray04[var40 * 2];
         if (var53 > 6 || var13 + 60 > var30 + 46) {
            break;
         }

         if (this.gameActorGroupReference04.entitySnapshotReferenceArray01[var49].booleanFlag01 && this.gameByteArray04[var40 * 2 + 1] >= 1) {
            var53++;
            var2 = var13 + 2;
            sbyte var23;
            if (var40 == this.gameIntegerValue85 && this.gameShortValue14 == 1) {
               var23 = 3;
            } else {
               var23 = 2;
            }

            this.drawActorSprite(var1, gameIntegerValue43 + 5, var2, gameIntegerValue43 - 37, 52, var23);
            addCollisionBounds(gameIntegerValue43 + 5, var2, gameIntegerValue43 - 37, 52, var40 + 200);
            this.drawSpriteEffect(var1, (sbyte)var49, gameIntegerValue43 + 12, var2 + 5);
            if (this.gameByteArray04[var49 * 2 + 1] > 1 && this.gameByteArray04[var49 * 2 + 1] < 7) {
               string var24 = JString.valueOf(this.gameActorGroupReference04.byteArray01[this.gameByteArray04[var49 * 2 + 1] - 1]);
               drawTextWithFont(var1, var24, gameIntegerValue43 + 12 + 42 + (gameIntegerValue43 - 44 - 42) / 2, var2 + 5 + 21 - this.gameByteValue02 / 2, 36);
            }

            if (this.gameByteArray04[var49 * 2 + 1] == 36) {
               drawTextWithFont(var1, "'1'", gameIntegerValue43 + 12 + 7 + 42 + (gameIntegerValue43 - 44 - 42) / 2, var2 + 5 + 21 - this.gameByteValue02 / 2, 36);
            } else if (this.gameByteArray04[var49 * 2 + 1] == 37) {
               drawTextWithFont(var1, "'2'", gameIntegerValue43 + 12 + 7 + 42 + (gameIntegerValue43 - 44 - 42) / 2, var2 + 5 + 21 - this.gameByteValue02 / 2, 36);
            }

            var13 = var2 + 58;
         }
      }

      if (this.gameShortValue14 == 1) {
         var10000 = gameSpriteDecoderReferenceArray09[0];
         int var60 = gameRectangleBoundsReference01 != null && gameRectangleBoundsReference01.boundsId == 4 ? 42 : 41;
         var44 = var13 + (gameIntegerValue35 >> 1);
         var34 = var60;
         Graphics var32 = gameGraphicsReference02;
         var10000.drawSpriteFrameTransformed(var32, var34, 270, var44, 0, 0, 0);
      }

      addCollisionBounds(270 - (gameIntegerValue35 >> 1), var13, gameIntegerValue35, gameIntegerValue35, 4);
      bool var42 = true;
      if ((var3 = var13 - 46 - 4) < 30 || gameIntegerValue42 < 128) {
         var42 = false;
         var3 = 30;
      }

      var2 = 46 + gameIntegerValue35 + 2;
      int var26 = var3 - (gameIntegerValue35 + 2);
      if (this.gameActorGroupReference04.byteValue03 > 1) {
         this.setRgbColor(var1, 3558425);
         drawRectangleOutline(var1, gameIntegerValue41 - 20, var2, 15, var26);
         this.setRgbColor(var1, 3158573);
         fillRectangle(var1, gameIntegerValue41 - 19, var2 + 1, 13, var26 - 2);
         this.setRgbColor(var1, 4151325);
         fillRectangle(var1, gameIntegerValue41 - 21, var2 + 1, 1, var26 - 2);
         fillRectangle(var1, gameIntegerValue41 - 5, var2 + 1, 1, var26 - 2);
         if (var42) {
            this.setRgbColor(var1, 8484209);
            var2 = var2 + 2 + (this.countActorsByType(this.gameByteArray04[2 * this.gameIntegerValue85], (sbyte)2) - 1) * (var26 - 4 - 16) / (this.gameActorGroupReference04.byteValue03 - 2);
            drawRectangleOutline(var1, gameIntegerValue41 - 18, var2, 11, 16);
            this.setRgbColor(var1, 4211516);
            fillRectangle(var1, gameIntegerValue41 - 17, var2 + 1, 9, 14);
         }
      }

      short var51 = 255;
      short var43 = 255;
      short var33 = 255;
      var1.setColor(var33, var43, var51);
      this.gameStringBufferReference01.setLength(0);
      if (this.gameShortValue14 == 0) {
         this.gameStringBufferReference01.append(getStringResource(var3 = this.gameActorGroupReference03.entitySnapshotReferenceArray01[this.gameByteArray04[2 * this.gameIntegerValue84]].integerValue01 + 1));
      } else {
         this.gameStringBufferReference01.append(getStringResource(var3 = this.gameActorGroupReference04.entitySnapshotReferenceArray01[this.gameByteArray04[2 * this.gameIntegerValue85]].integerValue01 + 1));
      }

      this.gameIntegerValue92 = drawCenteredText(
         var1, this.gameStringBufferReference01.toString(), 0, 9, var5 + 2 - this.gameIntegerValue91, 9, var5 + 2, gameIntegerValue41 - 22 - 9, var5 + 2 + 8 * (AnimationTables.byteArray02[0] + 1), 20
      );
      gameBooleanFlag10 = true;
   }

   // $VF: renamed from: U () void
   public void updateScreenEffects() {
      if (gameBooleanFlag29) {
         this.gameByteValue15 = 0;
      } else if (this.gameIntegerValue83 > 0) {
         this.gameIntegerValue83 = this.gameIntegerValue83 - this.gameIntegerValue46;
         if (this.gameIntegerValue83 % 100 > 50) {
            this.gameByteValue15 = 3;
         } else {
            this.gameByteValue15 = -3;
         }
      } else {
         this.gameByteValue15 = 0;
      }
   }

   // $VF: renamed from: h (javax.microedition.lcdui.Graphics) void
   public void drawScreenEffects(Graphics var1) {
      if (gameBooleanFlag62) {
         if (this.gameIntegerValue66 == 24 && this.gameByteValue04 == 0) {
            gameBooleanFlag62 = false;
         }

         if ((gameByteValue07 == 1 || gameShortValue01 == 181 || gameShortValue01 == 182 || gameShortValue01 == 171 || gameShortValue01 == 172)
            && (gameByteValue07 != 1 || gameShortValue01 != 540 || this.gameIntegerValue66 != 31)) {
            this.updateScreenEffects();
            return;
         }

         gameRectangleBoundsReference02 = null;
         gameBooleanFlag22 = false;
         gameBooleanFlag62 = false;

         for (int var2 = 0; var2 < 25; var2++) {
            this.gameActorStateReferenceArray01[var2].longValue01 = 0L;
            this.gameActorStateReferenceArray01[var2].longValue02 = 0L;
         }

         if (gameIntegerValue124 >= 0) {
            this.transitionGameState(gameIntegerValue124);
         }
      }

      if (this.gameIntegerValue115 > 0) {
         this.gameIntegerValue115--;
      } else if (gameShortValue01 == 731 && gameByteValue07 == 1) {
         this.drawActors(var1);
      } else {
         this.updateActorDisplayState(this.gameActorStateReference07, false);
         this.updateScreenEffects();
         int var4 = this.gameIntegerValue53 - this.getTilePixelX(this.gameIntegerValue59, this.gameIntegerValue62);
         int var20 = this.gameIntegerValue60;
         int var19 = this.gameIntegerValue59;
         int var5 = this.gameIntegerValue54 - (var20 + var19) * 27 - this.gameByteValue15;
         int var6 = SpriteAnimation.integerMatrix01[0][5];
         int var7 = SpriteAnimation.integerMatrix01[0][6];
         SpriteAnimation.setAnimationFrameRegion(0, var4, var5);
         SpriteAnimation.drawAnimationSprite(var1, 0, 0, 0);
         if (var4 < 0) {
            var1.setColor(0);
            var1.fillRect(0, 0, -var4, gameIntegerValue42);
         }

         if (var6 - var4 < gameIntegerValue41) {
            var1.setColor(0);
            var1.fillRect(var6 - var4, 0, gameIntegerValue41 - var6 + var4, gameIntegerValue42);
         }

         if (var5 < 0) {
            var1.setColor(0);
            var1.fillRect(0, 0, gameIntegerValue41, -var5);
         }

         if (var7 - var5 < gameIntegerValue42) {
            var1.setColor(0);
            var1.fillRect(0, var7 - var5, gameIntegerValue41, gameIntegerValue42 - var7 + var5);
         }

         int var12 = 0 + this.gameByteValue15;
         sbyte var11 = 0;
         int var10 = gameIntegerValue42;
         int var9 = gameIntegerValue41;
         var6 = this.gameIntegerValue54;
         int var8 = this.gameIntegerValue53;
         Graphics var46 = var1;
         GameCanvas var78 = this;
         if (var9 != 0 && var10 != 0) {
            for (int var14 = 0; var14 < gameIntegerValue80; var14++) {
               if (var14 == gameIntegerValue76) {
                  var14 = gameIntegerValue74;
               }

               ActorRuntimeState var18;
               if (!(var18 = var78.gameClass9ReferenceArray01[var78.gameIntegerArray03[var14]]).booleanFlag02
                  && (
                     var78.gameByteValue05 == var78.gameByteMatrix02[var18.byteValue02][var18.byteValue03]
                        || (
                           var18.booleanFlag04
                              ? var78.gameByteValue05 == var78.gameByteMatrix02[var18.byteValue02][var18.byteValue03 - 1]
                              : var78.gameByteValue05 == var78.gameByteMatrix02[var18.byteValue02 - 1][var18.byteValue03]
                        )
                  )) {
                  for (int var15 = 0; var15 < var78.gameShortMatrix03[var18.byteValue01][5]; var15++) {
                     sbyte var13;
                     int var16;
                     int var17;
                     if (var78.gameByteValue05 == var78.gameByteMatrix02[var18.byteValue02][var18.byteValue03]) {
                        if (!var18.booleanFlag04) {
                           if (var18.byteValue02 == 0) {
                              continue;
                           }

                           var13 = var78.gameByteMatrix01[var18.byteValue02 - 1][var18.byteValue03 + var15];
                           var16 = var78.getTilePixelX(var18.byteValue02 - 1, var18.byteValue03 + var15) - var8;
                           int var10000 = var18.byteValue02 - 1;
                           var20 = var18.byteValue03 + var15;
                           var19 = var10000;
                           var17 = (var20 + var19) * 27 - var6;
                        } else {
                           if (var18.byteValue03 == 0) {
                              continue;
                           }

                           var13 = var78.gameByteMatrix01[var18.byteValue02 + var15][var18.byteValue03 - 1];
                           var16 = var78.getTilePixelX(var18.byteValue02 + var15, var18.byteValue03 - 1) - var8;
                           int var172 = var18.byteValue02 + var15;
                           var20 = var18.byteValue03 - 1;
                           var19 = var172;
                           var17 = (var20 + var19) * 27 - var6;
                        }
                     } else if (!var18.booleanFlag04) {
                        if (var18.byteValue02 == 0 || var78.gameByteValue05 != var78.gameByteMatrix02[var18.byteValue02 - 1][var18.byteValue03]) {
                           continue;
                        }

                        var13 = var78.gameByteMatrix01[var18.byteValue02][var18.byteValue03 + var15];
                        var16 = var78.getTilePixelX(var18.byteValue02, var18.byteValue03 + var15) - var8;
                        var20 = var18.byteValue03 + var15;
                        sbyte var144 = var18.byteValue02;
                        var17 = (var20 + var144) * 27 - var6;
                     } else {
                        if (var18.byteValue03 == 0 || var78.gameByteValue05 != var78.gameByteMatrix02[var18.byteValue02][var18.byteValue03 - 1]) {
                           continue;
                        }

                        var13 = var78.gameByteMatrix01[var18.byteValue02 + var15][var18.byteValue03];
                        var16 = var78.getTilePixelX(var18.byteValue02 + var15, var18.byteValue03) - var8;
                        int var173 = var18.byteValue02 + var15;
                        sbyte var158 = var18.byteValue03;
                        var19 = var173;
                        var17 = (var158 + var19) * 27 - var6;
                     }

                     if (var13 != 127) {
                        var78.drawClippedGameRegion(var46, var13 + 89, var16 + var11, var17 + var12, 108, 54, 0, 0, 0);
                     }
                  }
               }
            }

            for (int var112 = var78.gameIntegerValue59; var112 <= var78.gameIntegerValue61; var112++) {
               for (int var117 = var78.gameIntegerValue60; var117 <= var78.gameIntegerValue62; var117++) {
                  if (var78.gameByteMatrix02[var112][var117] == var78.gameByteValue05) {
                     int var121 = var78.getTilePixelX(var112, var117) - var8;
                     int var130 = (var117 + var112) * 27 - var6;
                     sbyte var105;
                     if ((var105 = var78.gameByteMatrix01[var112][var117]) != 127
                        && var105 != gameIntegerValue117
                        && rectanglesOverlap(var8, var6, var9, var10, var121 + var8 + var11, var130 + var6 + var12, 108, 54)) {
                        if (var78.gameByteValue04 == 1 && var105 == 10) {
                           SpriteResourceDecoder var174 = gameSpriteDecoderReferenceArray07[1];
                           int var10002 = 0 + var78.gameByteValue26;
                           int var10003 = var121 + var11;
                           int var21 = var130 + var12;
                           var20 = var10003;
                           int var136 = var10002;
                           var174.drawSpriteFrameTransformed(var46, var136, var20, var21, 0, 0, 0);
                        } else {
                           var78.drawClippedGameRegion(var46, var105 + 89, var121 + var11, var130 + var12, 108, 54, 0, 0, 0);
                        }
                     }

                     if (((var78.gameShortMatrix01[var112][var117] & 255) != 255 || (var78.gameShortMatrix02[var112][var117] & 255) != 255)
                        && rectanglesOverlap(var8, var6, var9, var10, var121 + var8 + var11, var130 + var6 + var12 - 120 + 2, 108, 147)) {
                        bool var3 = false;
                        if (var78.gameActorStateReferenceArray01 != null) {
                           for (int var106 = 0; var106 < 25; var106++) {
                              ActorState var168;
                              if ((var168 = var78.gameActorStateReferenceArray01[var106]).booleanFlag01) {
                                 sbyte var22 = var168.byteValue01;
                                 sbyte var146 = var168.byteValue02;
                                 if (var22 < var78.gameByteValue12 && var146 < var78.gameByteValue13 && var78.gameByteValue05 == var78.gameByteMatrix02[var22][var146]) {
                                    if (isActorDefeated(var168)) {
                                       int var137 = var168.byteValue01;
                                       int var160 = var168.byteValue01;
                                       int var147 = var168.byteValue02;
                                       int var23 = var168.byteValue02;
                                       if (var168.byteValue03 >= gameByteCube01[var168.byteValue08][var168.byteValue05][2]) {
                                          if (var168.byteValue07 == 3) {
                                             var23 = var168.byteValue02 + 1;
                                          } else if (var168.byteValue07 == 5) {
                                             var160 = var168.byteValue01 + 1;
                                          } else if (var168.byteValue07 == 1) {
                                             var160 = var168.byteValue01 - 1;
                                          } else if (var168.byteValue07 == 7) {
                                             var23 = var168.byteValue02 - 1;
                                          }
                                       } else if (var168.byteValue07 == 3) {
                                          var147 = var168.byteValue02 - 1;
                                       } else if (var168.byteValue07 == 5) {
                                          var137 = var168.byteValue01 - 1;
                                       } else if (var168.byteValue07 == 1) {
                                          var137 = var168.byteValue01 + 1;
                                       } else if (var168.byteValue07 == 7) {
                                          var147 = var168.byteValue02 + 1;
                                       }

                                       if (var160 < var78.gameByteValue12
                                          && var23 < var78.gameByteValue13
                                          && var78.gameByteValue05 == var78.gameByteMatrix02[var160][var23]
                                          && var137 < var78.gameByteValue12
                                          && var147 < var78.gameByteValue13
                                          && var78.gameByteValue05 == var78.gameByteMatrix02[var137][var147]
                                          && !var78.gameBooleanFlag37) {
                                          if (var160 < var112 && var160 > var112 - 3 && var160 > 0 && var23 < var117 && var23 > var117 - 3 && var23 > 0) {
                                             var3 = true;
                                          }

                                          if (var137 < var112 && var137 > var112 - 3 && var137 > 0 && var147 < var117 && var147 > var117 - 3 && var147 > 0) {
                                             var3 = true;
                                          }
                                       }
                                    } else if (var22 < var112 && var22 > var112 - 3 && var22 > 0 && var146 < var117 && var146 > var117 - 3 && var146 > 0) {
                                       var3 = true;
                                    }
                                 }
                              }
                           }
                        }

                        if (!var3) {
                           var78.drawActorFrame(var46, var78.gameShortMatrix01[var112][var117], true, true, var121 + var11, var130 + var12);
                        }

                        if (!var3) {
                           var78.drawActorFrame(var46, var78.gameShortMatrix02[var112][var117], false, true, var121 + var11, var130 + var12);
                        }
                     }
                  }
               }
            }

            if (gameBooleanFlag17 && gameBooleanFlag14) {
               int var107 = -1;
               int var24 = -1;
               int var122 = gameIntegerValue31 + var78.gameIntegerValue53;
               int var131 = gameIntegerValue32 + var78.gameIntegerValue54;
               int var113 = var78.getTileRowFromPixel(var122, var131);
               int var138 = var78.getTileColumnFromPixel(var122, var131);
               if (var113 < var78.gameByteValue12
                  && var138 < var78.gameByteValue13
                  && var113 >= 0
                  && var138 >= 0
                  && (var78.gameByteMatrix04[var113][var138] & 240) == 0
                  && (var78.gameByteMatrix02[var113][var138] == var78.gameByteValue05 || var78.isActorUnavailable(var113, var138))) {
                  var107 = var113;
                  var24 = var138;
               }

               if (var107 >= 0 && var24 >= 0 && (var78.gameByteMatrix02[var107][var24] == var78.gameByteValue05 || var78.isActorUnavailable(var107, var24))) {
                  var122 = var78.getTilePixelX(var107, var24) - var8;
                  var131 = (var24 + var107) * 27 - var6;
                  sbyte var31 = 106;
                  int var25 = 232;
                  sbyte var161 = 37;
                  var46.setColor(var161, var25, var31);
                  gameClass11Reference03.playAnimation(2, -1);
                  int var10001 = var122 + var11 + 54;
                  var107 = var131 + var12 + 27;
                  var25 = var10001;
                  SpriteAnimation var124 = gameClass11Reference03;
                  gameClass11Reference03.drawX = var25;
                  var124.drawY = var107;
                  gameClass11Reference03.advanceAnimation(gameIntegerValue129);
                  gameClass11Reference03.drawCurrentFrame();
               }
            }

            for (int var114 = 0; var114 < gameIntegerValue77; var114++) {
               ActorRuntimeState var139;
               if ((var139 = var78.gameClass9ReferenceArray01[var78.gameIntegerArray03[var114]]).booleanFlag02) {
                  int var125 = var139.shortValue01 - var8;
                  int var133 = var139.shortValue02 - var6;
                  if (var139.booleanFlag04
                     ? rectanglesOverlap(
                        var8,
                        var6,
                        var9,
                        var10,
                        var139.shortValue01 - var78.gameShortMatrix03[var139.byteValue01][0] - var78.gameShortMatrix03[var139.byteValue01][2] + 108 + var11,
                        var139.shortValue02 + var78.gameShortMatrix03[var139.byteValue01][3] + var12,
                        var78.gameShortMatrix03[var139.byteValue01][0],
                        var78.gameShortMatrix03[var139.byteValue01][1]
                     )
                     : rectanglesOverlap(
                        var8,
                        var6,
                        var9,
                        var10,
                        var139.shortValue01 + var78.gameShortMatrix03[var139.byteValue01][2] + var11,
                        var139.shortValue02 + var78.gameShortMatrix03[var139.byteValue01][3] + var12,
                        var78.gameShortMatrix03[var139.byteValue01][0],
                        var78.gameShortMatrix03[var139.byteValue01][1]
                     )) {
                     var78.drawLinkedEntities(var46, var78.gameIntegerArray03[var114], var125 + var11, var133 + var12);
                  }
               }
            }
         }

         if (gameBooleanFlag23 && gameClass11Reference01 != null) {
            ActorState var29 = this.gameActorGroupReference01.actorStateReference01;
            int[] var95 = new int[2];
            bool var71b = this.isActorNearPosition(var29, 2, 1);
            int var71;
            bool var98 = this.isActorNearPosition(var29, 0, 1);
            int var100 = this.getTilePixelX(var29.byteValue01, var29.byteValue02) - this.gameIntegerValue53;
            sbyte var162 = var29.byteValue02;
            sbyte var148 = var29.byteValue01;
            int var102 = (var162 + var148) * 27 - this.gameIntegerValue54;
            if (gameByteCube01[var29.byteValue08][var29.byteValue05][2] != 0) {
               if (var71b) {
                  var100 += var29.integerValue01 * 54 >> 16;
                  if (var29.byteValue03 >= gameByteCube01[var29.byteValue08][var29.byteValue05][2]) {
                     var100 -= 54;
                  }
               } else {
                  var100 -= var29.integerValue01 * 54 >> 16;
                  if (var29.byteValue03 >= gameByteCube01[var29.byteValue08][var29.byteValue05][2]) {
                     var100 += 54;
                  }
               }

               if (var98) {
                  var102 += var29.integerValue01 * 27 >> 16;
                  if (var29.byteValue03 >= gameByteCube01[var29.byteValue08][var29.byteValue05][2]) {
                     var102 -= 27;
                  }
               } else {
                  var102 -= var29.integerValue01 * 27 >> 16;
                  if (var29.byteValue03 >= gameByteCube01[var29.byteValue08][var29.byteValue05][2]) {
                     var102 += 27;
                  }
               }
            }

            var95[0] = var100;
            var95[1] = var102;
            var5 = var95[0];
            var71 = var95[1];
            int var185 = var5 + 54;
            var71 += 27;
            var5 = var185;
            SpriteAnimation var79 = gameClass11Reference01;
            gameClass11Reference01.drawX = var5;
            var79.drawY = var71;
            gameClass11Reference01.advanceAnimation(gameIntegerValue129);
            if (!gameBooleanFlag29) {
               gameClass11Reference01.drawCurrentFrame();
            }

            if ((25 - var29.byteValue01 < 0 ? -(25 - var29.byteValue01) : 25 - var29.byteValue01) > 2
               || (40 - var29.byteValue02 < 0 ? -(40 - var29.byteValue02) : 40 - var29.byteValue02) > 2) {
               gameBooleanFlag23 = false;
            }
         }

         Graphics var30 = var1;
         GameCanvas var27 = this;
         this.gameShortValue02 = 0;

         for (int var32 = gameIntegerValue72; var32 < gameIntegerValue78; var32++) {
            ActorRuntimeState var49;
            if ((var49 = var27.gameClass9ReferenceArray01[var27.gameIntegerArray03[var32]]).booleanFlag02
               && (
                  var49.booleanFlag04
                     ? rectanglesOverlap(
                        var27.gameIntegerValue53,
                        var27.gameIntegerValue54,
                        gameIntegerValue41,
                        gameIntegerValue42,
                        var49.shortValue01 - var27.gameShortMatrix03[var49.byteValue01][0] - var27.gameShortMatrix03[var49.byteValue01][2] + 108,
                        var49.shortValue02 + var27.gameShortMatrix03[var49.byteValue01][3] + var27.gameByteValue15,
                        var27.gameShortMatrix03[var49.byteValue01][0],
                        var27.gameShortMatrix03[var49.byteValue01][1]
                     )
                     : rectanglesOverlap(
                        var27.gameIntegerValue53,
                        var27.gameIntegerValue54,
                        gameIntegerValue41,
                        gameIntegerValue42,
                        var49.shortValue01 + var27.gameShortMatrix03[var49.byteValue01][2],
                        var49.shortValue02 + var27.gameShortMatrix03[var49.byteValue01][3] + var27.gameByteValue15,
                        var27.gameShortMatrix03[var49.byteValue01][0],
                        var27.gameShortMatrix03[var49.byteValue01][1]
                     )
               )) {
               var7 = var49.shortValue01 - var27.gameIntegerValue53;
               var5 = var49.shortValue02 - var27.gameIntegerValue54;
               var27.drawLinkedEntities(var30, var27.gameIntegerArray03[var32], var7, var5 + var27.gameByteValue15);
            }
         }

         for (int var33 = gameIntegerValue73; var33 < gameIntegerValue79; var33++) {
            ActorRuntimeState var51;
            if ((var51 = var27.gameClass9ReferenceArray01[var27.gameIntegerArray03[var33]]).booleanFlag02
               && (
                  var51.booleanFlag04
                     ? rectanglesOverlap(
                        var27.gameIntegerValue53,
                        var27.gameIntegerValue54,
                        gameIntegerValue41,
                        gameIntegerValue42,
                        var51.shortValue01 - var27.gameShortMatrix03[var51.byteValue01][0] - var27.gameShortMatrix03[var51.byteValue01][2] + 108,
                        var51.shortValue02 + var27.gameShortMatrix03[var51.byteValue01][3] + var27.gameByteValue15,
                        var27.gameShortMatrix03[var51.byteValue01][0],
                        var27.gameShortMatrix03[var51.byteValue01][1]
                     )
                     : rectanglesOverlap(
                        var27.gameIntegerValue53,
                        var27.gameIntegerValue54,
                        gameIntegerValue41,
                        gameIntegerValue42,
                        var51.shortValue01 + var27.gameShortMatrix03[var51.byteValue01][2],
                        var51.shortValue02 + var27.gameShortMatrix03[var51.byteValue01][3] + var27.gameByteValue15,
                        var27.gameShortMatrix03[var51.byteValue01][0],
                        var27.gameShortMatrix03[var51.byteValue01][1]
                     )
               )) {
               if (var51.booleanFlag04) {
                  var7 = var51.byteValue02 + var27.gameShortMatrix03[var51.byteValue01][5];
                  var5 = var51.byteValue03 + var27.gameShortMatrix03[var51.byteValue01][4];
               } else {
                  var7 = var51.byteValue02 + var27.gameShortMatrix03[var51.byteValue01][4];
                  var5 = var51.byteValue03 + var27.gameShortMatrix03[var51.byteValue01][5];
               }

               var27.processActorCollisions(0, var27.gameIntegerArray03[var33], var7, var5);
            }
         }

         for (int var34 = 0; var34 < 25; var34++) {
            ActorState var96;
            if ((var96 = var27.gameActorStateReferenceArray01[var34]).booleanFlag01
               && var96.byteValue01 < var27.gameByteValue12
               && var96.byteValue02 < var27.gameByteValue13
               && var27.gameByteValue05 == var27.gameByteMatrix02[var96.byteValue01][var96.byteValue02]
               && var96.byteValue08 != 3
               && var96.byteValue05 == 4) {
               sbyte var82 = var96.byteValue01;
               sbyte var53 = var96.byteValue02;
               var27.processActorCollisions(4, var34, var82, var53);
            }
         }

         for (int var35 = 0; var35 < 25; var35++) {
            ActorState var97;
            if ((var97 = var27.gameActorStateReferenceArray01[var35]).booleanFlag01
               && var97.byteValue01 < var27.gameByteValue12
               && var97.byteValue02 < var27.gameByteValue13
               && var27.gameByteValue05 == var27.gameByteMatrix02[var97.byteValue01][var97.byteValue02]
               && (var97.byteValue05 != 4 || var97.byteValue08 == 3)) {
               var7 = var97.byteValue01 + 1;
               var5 = var97.byteValue02 + 1;
               var27.processActorCollisions(1, var35, var7, var5);
            }
         }

         for (int var36 = 0; var36 < 10; var36++) {
            if (var27.gameClass22ReferenceArray01[var36].booleanFlag01) {
               sbyte var84 = var27.gameClass22ReferenceArray01[var36].entityFrameDataReference01.byteValue02;
               sbyte var55 = var27.gameClass22ReferenceArray01[var36].entityFrameDataReference01.byteValue03;
               var27.processActorCollisions(2, var36, var84, var55);
            }
         }

         for (int var37 = 0; var37 < 5; var37++) {
            if (var27.gameEntityFrameDataReferenceArray01[var37].booleanFlag01) {
               sbyte var85 = var27.gameEntityFrameDataReferenceArray01[var37].byteValue02;
               sbyte var56 = var27.gameEntityFrameDataReferenceArray01[var37].byteValue03;
               var27.processActorCollisions(3, var37, var85, var56);
            }
         }

         for (int var38 = 0; var38 < var27.gameShortValue02; var38++) {
            if (var27.gameByteArray01[var38] == 0) {
               var7 = var27.gameClass9ReferenceArray01[var27.gameShortArray02[var38]].shortValue01 - var27.gameIntegerValue53;
               var5 = var27.gameClass9ReferenceArray01[var27.gameShortArray02[var38]].shortValue02 - var27.gameIntegerValue54;
               var27.drawLinkedEntities(var30, var27.gameShortArray02[var38], var7, var5 + var27.gameByteValue15);
            } else if (var27.gameByteArray01[var38] == 1) {
               if (var27.gameShortArray02[var38] == var27.gameByteValue03 - 1 && var27.gameIntegerValue90 > 0 && var27.gameIntegerValue90 < 20) {
                  var27.drawActors(var30);
               } else {
                  int var89 = var27.getTilePixelX(var27.gameActorStateReferenceArray01[var27.gameShortArray02[var38]].byteValue01, var27.gameActorStateReferenceArray01[var27.gameShortArray02[var38]].byteValue02)
                     - var27.gameIntegerValue53;
                  sbyte var166 = var27.gameActorStateReferenceArray01[var27.gameShortArray02[var38]].byteValue02;
                  sbyte var154 = var27.gameActorStateReferenceArray01[var27.gameShortArray02[var38]].byteValue01;
                  int var60 = (var166 + var154) * 27 - var27.gameIntegerValue54;
                  ActorState var76;
                  if ((var76 = var27.gameActorStateReferenceArray01[var27.gameShortArray02[var38]]) == var27.gameActorGroupReference01.actorStateReference01
                     && var76 == var27.gameActorStateReference07
                     && (var76.byteValue05 == 1 || var76.byteValue05 == 12 || var76.byteValue05 == 13)) {
                     bool var99 = var27.isActorNearPosition(var76, 2, 1);
                     bool var101 = var27.isActorNearPosition(var76, 0, 1);
                     int var103 = 0;
                     if (var76.byteValue05 == 12) {
                        var103 = 2;
                     }

                     if (var76.byteValue05 == 13) {
                        var103 = 4;
                     }

                     if (!var101) {
                        var103++;
                     }

                     if (gameByteCube01[var76.byteValue08][var76.byteValue05][2] != 0) {
                        if (var99) {
                           var89 = (var7 = var89 + (var76.integerValue01 * 54 >> 16))
                              + gameSpriteDecoderReferenceArray02[var27.gameActorGroupReference01.actorStateReference01.byteValue08].getSpriteFrameXOffset(var103, var76.byteValue03);
                           if (var76.byteValue03 >= gameByteCube01[var76.byteValue08][var76.byteValue05][2]) {
                              var89 -= 54;
                           }
                        } else {
                           var89 = (var7 = var89 - (var76.integerValue01 * 54 >> 16))
                              - gameSpriteDecoderReferenceArray02[var27.gameActorGroupReference01.actorStateReference01.byteValue08].getSpriteFrameXOffset(var103, var76.byteValue03);
                           if (var76.byteValue03 >= gameByteCube01[var76.byteValue08][var76.byteValue05][2]) {
                              var89 += 54;
                           }
                        }

                        if (var101) {
                           var5 = var60 + (var76.integerValue01 * 27 >> 16);
                           if (var76.byteValue03 >= gameByteCube01[var76.byteValue08][var76.byteValue05][2]) {
                              var5 -= 27;
                           }
                        } else {
                           var5 = var60 - (var76.integerValue01 * 27 >> 16);
                           if (var76.byteValue03 >= gameByteCube01[var76.byteValue08][var76.byteValue05][2]) {
                              var5 += 27;
                           }
                        }

                        var60 = var5 + gameSpriteDecoderReferenceArray02[var27.gameActorGroupReference01.actorStateReference01.byteValue08].getSpriteFrameYOffset(var103, var76.byteValue03);
                     }
                  }

                  var27.drawActorState(var30, var27.gameActorStateReferenceArray01[var27.gameShortArray02[var38]], var89, var60 + var27.gameByteValue15);
               }
            } else if (var27.gameByteArray01[var38] == 2) {
               short var116 = var27.gameShortArray02[var38];
               int var119 = gameIntegerMatrix01[var27.gameClass22ReferenceArray01[var116].entityFrameDataReference01.byteValue01][2] + var27.gameClass22ReferenceArray01[var116].entityFrameDataReference01.byteValue04;
               switch (var27.gameClass22ReferenceArray01[var116].byteValue01) {
                  case 4:
                     SpriteResourceDecoder var184 = gameSpriteDecoderReferenceArray05[0];
                     int var193 = var27.gameClass22ReferenceArray01[var116].entityFrameDataReference01.shortValue01 - var27.gameIntegerValue53;
                     var20 = var27.gameClass22ReferenceArray01[var116].entityFrameDataReference01.shortValue02 - var27.gameClass22ReferenceArray01[var116].entityFrameDataReference01.shortValue03 - var27.gameIntegerValue54;
                     var19 = var193;
                     var184.drawSpriteFrameTransformed(var30, var119, var19, var20, 0, 0, 0);
                     break;
                  case 5:
                  case 6:
                  default:
                     SpriteResourceDecoder var183 = gameSpriteDecoderReferenceArray05[AnimationTables.integerArray02[var27.gameClass22ReferenceArray01[var116].entityFrameDataReference01.byteValue01]];
                     int var192 = var27.gameClass22ReferenceArray01[var116].entityFrameDataReference01.shortValue01 - var27.gameIntegerValue53;
                     var7 = var27.gameClass22ReferenceArray01[var116].entityFrameDataReference01.shortValue02 - var27.gameClass22ReferenceArray01[var116].entityFrameDataReference01.shortValue03 - var27.gameIntegerValue54;
                     var6 = var192;
                     var183.drawSpriteFrameTransformed(var30, var119, var6, var7, 0, 0, 0);
                     break;
                  case 7:
                     var119 = var27.gameClass22ReferenceArray01[var116].entityFrameDataReference01.shortValue03 > 38
                        ? 0
                        : (
                           var27.gameClass22ReferenceArray01[var116].entityFrameDataReference01.shortValue03 > 20
                              ? 1
                              : (var27.gameClass22ReferenceArray01[var116].entityFrameDataReference01.shortValue03 > 15 ? 2 : (var27.gameClass22ReferenceArray01[var116].entityFrameDataReference01.shortValue03 > 10 ? 3 : 4))
                        );
                     bool var135;
                     if (!(var135 = var27.gameClass22ReferenceArray01[var116].byteValue02 > 4)) {
                        SpriteResourceDecoder var181 = gameSpriteDecoderReferenceArray05[AnimationTables.integerArray02[var27.gameClass22ReferenceArray01[var116].entityFrameDataReference01.byteValue01]];
                        int var195 = var27.gameClass22ReferenceArray01[var116].entityFrameDataReference01.shortValue01 - var27.gameIntegerValue53;
                        var19 = var27.gameClass22ReferenceArray01[var116].entityFrameDataReference01.shortValue02 - var27.gameClass22ReferenceArray01[var116].entityFrameDataReference01.shortValue03 - var27.gameIntegerValue54;
                        int var141 = var195;
                        var181.drawSpriteFrameTransformed(var30, var119, var141, var19, 0, 0, 0);
                     } else {
                        SpriteResourceDecoder var182 = gameSpriteDecoderReferenceArray05[AnimationTables.integerArray02[var27.gameClass22ReferenceArray01[var116].entityFrameDataReference01.byteValue01]];
                        int var196 = var27.gameClass22ReferenceArray01[var116].entityFrameDataReference01.shortValue01 - var27.gameIntegerValue53;
                        int var129 = var27.gameClass22ReferenceArray01[var116].entityFrameDataReference01.shortValue02 - var27.gameClass22ReferenceArray01[var116].entityFrameDataReference01.shortValue03 - var27.gameIntegerValue54;
                        var5 = var196;
                        var182.drawSpriteFrameTransformed(var30, var119, var5, var129, 1, 0, 0);
                     }
                     break;
                  case 8:
                     int var127;
                     var127 = (var127 = (int)(var27.gameLongValue06 % 400L)) / 100;
                     SpriteResourceDecoder var180 = gameSpriteDecoderReferenceArray07[3];
                     int var191 = var27.gameClass22ReferenceArray01[var116].entityFrameDataReference01.shortValue01 - var27.gameIntegerValue53;
                     int var111 = var27.gameClass22ReferenceArray01[var116].entityFrameDataReference01.shortValue02 - var27.gameClass22ReferenceArray01[var116].entityFrameDataReference01.shortValue03 - var27.gameIntegerValue54;
                     int var171 = var191;
                     var180.drawSpriteFrameTransformed(var30, var127, var171, var111, 0, 0, 0); break;
               }
            } else if (var27.gameByteArray01[var38] != 3) {
               if (var27.gameByteArray01[var38] == 4) {
                  var7 = var27.getTilePixelX(var27.gameActorStateReferenceArray01[var27.gameShortArray02[var38]].byteValue01, var27.gameActorStateReferenceArray01[var27.gameShortArray02[var38]].byteValue02)
                     - var27.gameIntegerValue53;
                  sbyte var164 = var27.gameActorStateReferenceArray01[var27.gameShortArray02[var38]].byteValue02;
                  sbyte var151 = var27.gameActorStateReferenceArray01[var27.gameShortArray02[var38]].byteValue01;
                  var5 = (var164 + var151) * 27 - var27.gameIntegerValue54;
                  var27.drawActorState(var30, var27.gameActorStateReferenceArray01[var27.gameShortArray02[var38]], var7, var5 + var27.gameByteValue15);
               }
            } else {
               short var115 = var27.gameShortArray02[var38];
               Graphics var109 = var30;
               GameCanvas var104 = var27;
               int var118 = gameIntegerMatrix01[var27.gameEntityFrameDataReferenceArray01[var115].byteValue01][2] + var27.gameEntityFrameDataReferenceArray01[var115].byteValue04;
               if (var27.gameEntityFrameDataReferenceArray01[var115].byteValue01 >= 5 && var27.gameEntityFrameDataReferenceArray01[var115].byteValue01 <= 36) {
                  if ((var27.gameEntityFrameDataReferenceArray01[var115].byteValue01 <= 9 || var27.gameEntityFrameDataReferenceArray01[var115].byteValue01 >= 13)
                     && (var27.gameEntityFrameDataReferenceArray01[var115].byteValue01 <= 17 || var27.gameEntityFrameDataReferenceArray01[var115].byteValue01 > 20)
                     && (var27.gameEntityFrameDataReferenceArray01[var115].byteValue01 <= 25 || var27.gameEntityFrameDataReferenceArray01[var115].byteValue01 >= 29)
                     && (var27.gameEntityFrameDataReferenceArray01[var115].byteValue01 <= 33 || var27.gameEntityFrameDataReferenceArray01[var115].byteValue01 > 36)) {
                     SpriteResourceDecoder var178 = gameSpriteDecoderReferenceArray05[AnimationTables.integerArray02[var27.gameEntityFrameDataReferenceArray01[var115].byteValue01]];
                     int var189 = var27.gameEntityFrameDataReferenceArray01[var115].shortValue01 - var27.gameIntegerValue53;
                     var20 = var27.gameEntityFrameDataReferenceArray01[var115].shortValue02 - var27.gameEntityFrameDataReferenceArray01[var115].shortValue03 - var27.gameIntegerValue54;
                     var19 = var189;
                     var178.drawSpriteFrameTransformed(var30, var118, var19, var20, 0, 0, 0);
                  } else {
                     SpriteResourceDecoder var179 = gameSpriteDecoderReferenceArray05[AnimationTables.integerArray02[var27.gameEntityFrameDataReferenceArray01[var115].byteValue01]];
                     int var190 = var27.gameEntityFrameDataReferenceArray01[var115].shortValue01 - var27.gameIntegerValue53 + 108;
                     int var110 = var27.gameEntityFrameDataReferenceArray01[var115].shortValue02 - var27.gameEntityFrameDataReferenceArray01[var115].shortValue03 - var27.gameIntegerValue54;
                     int var170 = var190;
                     var179.drawSpriteFrameTransformed(var30, var118, var170, var110, 1, 0, 0);
                  }
               } else if (var27.gameEntityFrameDataReferenceArray01[var115].byteValue01 == 39) {
                  SpriteResourceDecoder var176 = gameSpriteDecoderReferenceArray05[AnimationTables.integerArray02[var27.gameEntityFrameDataReferenceArray01[var115].byteValue01]];
                  int var187 = var27.gameEntityFrameDataReferenceArray01[var115].shortValue01 - var27.gameIntegerValue53;
                  var19 = var27.gameEntityFrameDataReferenceArray01[var115].shortValue02 - var27.gameEntityFrameDataReferenceArray01[var115].shortValue03 - var27.gameIntegerValue54;
                  int var140 = var187;
                  var176.drawSpriteFrameTransformed(var30, var118, var140, var19, 0, 0, 0);
                  if (var118 > 61 && var118 < 67) {
                     for (int var134 = 0; var134 < 4; var134++) {
                        var176 = gameSpriteDecoderReferenceArray05[AnimationTables.integerArray02[var104.gameEntityFrameDataReferenceArray01[var115].byteValue01]];
                        var187 = var118 + (var134 + 1) * 5;
                        int var194 = var104.gameEntityFrameDataReferenceArray01[var115].shortValue01 - var104.gameIntegerValue53;
                        int var126 = var104.gameEntityFrameDataReferenceArray01[var115].shortValue02 - var104.gameEntityFrameDataReferenceArray01[var115].shortValue03 - var104.gameIntegerValue54;
                        var5 = var194;
                        int var169 = var187;
                        var176.drawSpriteFrameTransformed(var109, var169, var5, var126, 0, 0, 0);
                     }
                  }
               } else {
                  SpriteResourceDecoder var175 = gameSpriteDecoderReferenceArray05[AnimationTables.integerArray02[var27.gameEntityFrameDataReferenceArray01[var115].byteValue01]];
                  int var186 = var27.gameEntityFrameDataReferenceArray01[var115].shortValue01 - var27.gameIntegerValue53;
                  var7 = var27.gameEntityFrameDataReferenceArray01[var115].shortValue02 - var27.gameEntityFrameDataReferenceArray01[var115].shortValue03 - var27.gameIntegerValue54;
                  var6 = var186;
                  var175.drawSpriteFrameTransformed(var30, var118, var6, var7, 0, 0, 0);
               }
            }
         }

         for (int var39 = gameIntegerValue74; var39 < gameIntegerValue80; var39++) {
            ActorRuntimeState var63;
            if ((var63 = var27.gameClass9ReferenceArray01[var27.gameIntegerArray03[var39]]).booleanFlag02
               && (
                  !var63.booleanFlag04
                     ? var63.byteValue02 != 0
                        && var27.gameByteValue05 == var27.gameByteMatrix02[var63.byteValue02 - 1][var63.byteValue03]
                        && rectanglesOverlap(
                           var27.gameIntegerValue53,
                           var27.gameIntegerValue54,
                           gameIntegerValue41,
                           gameIntegerValue42,
                           var63.shortValue01 + var27.gameShortMatrix03[var63.byteValue01][2],
                           var63.shortValue02 + var27.gameShortMatrix03[var63.byteValue01][3] + var27.gameByteValue15,
                           var27.gameShortMatrix03[var63.byteValue01][0],
                           var27.gameShortMatrix03[var63.byteValue01][1]
                        )
                     : var63.byteValue03 != 0
                        && var27.gameByteValue05 == var27.gameByteMatrix02[var63.byteValue02][var63.byteValue03 - 1]
                        && rectanglesOverlap(
                           var27.gameIntegerValue53,
                           var27.gameIntegerValue54,
                           gameIntegerValue41,
                           gameIntegerValue42,
                           var63.shortValue01 - var27.gameShortMatrix03[var63.byteValue01][0] - var27.gameShortMatrix03[var63.byteValue01][2] + 108,
                           var63.shortValue02 + var27.gameShortMatrix03[var63.byteValue01][3] + var27.gameByteValue15,
                           var27.gameShortMatrix03[var63.byteValue01][0],
                           var27.gameShortMatrix03[var63.byteValue01][1]
                        )
               )) {
               short var93 = var63.shortValue01;
               short var64 = var63.shortValue02;
               var27.drawLinkedEntities(var30, var27.gameIntegerArray03[var39], var93 - var27.gameIntegerValue53, var64 - var27.gameIntegerValue54 + var27.gameByteValue15);
            }
         }

         if (this.gameIntegerValue90 > 0) {
            this.drawActors(var1);
         }

         this.drawSceneBackground(var1);
         if (this.gameBooleanFlag39 && !this.gameBooleanFlag38) {
            gameBooleanFlag59 = false;
            var7 = gameIntegerValue42;
            var6 = gameIntegerValue41;
            int var65 = 0;
            int var40 = 0;
            var40 = (sbyte)0;
            sbyte var28 = 0;
            sbyte var167 = 0;
            var1.setColor(var167, var28, var40);
            fillRectangle(var1, 0, 0, var6, var7);
            if (this.gameClass9ReferenceArray01[215].booleanFlag02) {
               var40 = this.gameClass9ReferenceArray01[215].shortValue01 - this.gameIntegerValue53;
               var65 = this.gameClass9ReferenceArray01[215].shortValue02 - this.gameIntegerValue54 + 80;
               this.drawLinkedEntities(var1, 215, var40, var65 + this.gameByteValue15);
               var40 = this.gameClass9ReferenceArray01[542].shortValue01 - this.gameIntegerValue53;
               var65 = this.gameClass9ReferenceArray01[542].shortValue02 - this.gameIntegerValue54 + 80;
               this.drawLinkedEntities(var1, 542, var40, var65 + this.gameByteValue15);
               var40 = this.gameClass9ReferenceArray01[541].shortValue01 - this.gameIntegerValue53;
               var65 = this.gameClass9ReferenceArray01[541].shortValue02 - this.gameIntegerValue54 + 80;
               this.drawLinkedEntities(var1, 541, var40, var65 + this.gameByteValue15);
            }
         }

         if (isGameplayRunning()) {
            var1.setColor(0);
            var1.fillRect(0, 0, gameIntegerValue41, AnimationTables.integerValue01);
            var1.fillRect(0, gameIntegerValue42 - AnimationTables.integerValue01, gameIntegerValue41, AnimationTables.integerValue01);
         } else if (gameBooleanFlag59) {
            var4 = UiLayoutPresetC.integerValue09;
            var5 = 26 * this.gameActorGroupReference01.actorStateReference01.byteValue10 / this.gameActorGroupReference01.actorStateReference01.byteValue11;
            gameSpriteDecoderReferenceArray06[0].drawSpriteFrameTransformed(var1, 1, var4, 24, 0, 0, 0);
            if (this.gameActorGroupReference01.actorStateReference01.byteValue10 < 0 && this.gameActorGroupReference01.actorStateReference01.byteValue10 > 0) {
               setGraphicsClip(var1, var4, 50, 26, 26);
            } else {
               setGraphicsClip(var1, var4, 50 - var5, 26, 26);
            }

            gameSpriteDecoderReferenceArray06[0].drawSpriteFrameTransformed(var1, 0, var4, 24, 0, 0, 0);
            setGraphicsClip(var1, 0, 0, gameIntegerValue41, gameIntegerValue42);
         }

         this.renderGameWorld(var1);
         this.drawSceneForeground(var1);
         gameClass11Reference03.advanceAnimation(gameIntegerValue129);
      }
   }

   // $VF: renamed from: l () boolean
   public static bool isGameplayRunning() {
      return gameByteValue07 != 2 && (gameByteValue07 == 1 || gameShortValue01 >= 180 && gameShortValue01 <= 182);
   }

   // $VF: renamed from: m () void
   public void initializeGameCanvas() {
      clearInteractionBounds();
      clearCollisionBounds();
      if (!this.gameBooleanFlag30) {
         this.gameBooleanFlag30 = true;
         if (this.canProcessPointerInput() && !gameBooleanFlag52) {
            this.updateLevelEvents();
         } else {
            this.restoreAudioState();
         }

         if (this.gameByteArray03 != null) {
            this.writeSavedGameData();
         }

         this.gameLongValue06 = JSystem.currentTimeMillis();
      }

      if (!gameBooleanFlag65) {
         gameBooleanFlag65 = true;
         SpriteAnimation.loadAnimationResources();
      }
   }

   // $VF: renamed from: n () void
   public void loadGameCanvasState() {
      if (this.gameBooleanFlag30) {
         this.gameLongValue06 = JSystem.currentTimeMillis();
         initializeInputState();
         this.gameBooleanFlag30 = false;
         gameIntegerValue20 = gameIntegerValue19 == 24 ? 0 : 1;
         if (!this.canProcessPointerInput() && gameIntegerValue48 != 8 && !gameBooleanFlag52 && gameIntegerValue48 != 12) {
            this.resumeBackgroundMusic();
         }
      }

      if (gameBooleanFlag65) {
         long var2;
         gameLongValue13 = var2 = JSystem.currentTimeMillis();
         gameLongValue15 = var2;
         this.gameLongValue14 = var2;
         gameBooleanFlag65 = false;
         this.showGameCanvas();
         if (!gameBooleanFlag66) {
            this.repaint();
         }

         initializeInputState();
      }
   }

   // $VF: renamed from: a (java.lang.String, int, boolean) g
   public SpriteResourceDecoder loadSpriteResource(string var1, int var2, bool var3) {
      this.gameTextValue01 = var1;
      return createSpriteResource(var2, true, true);
   }

   // $VF: renamed from: a (int, boolean, boolean) g
   public static SpriteResourceDecoder createSpriteResource(int var0, bool var1, bool var2) {
      sbyte[] var4;
      if ((var4 = loadAssetBytes(var0)).Length == 0) {
         return null;
      } else {
         SpriteResourceDecoder var3;
         (var3 = new SpriteResourceDecoder()).loadSpriteData(var4, 0);

         for (int var5 = 0; var5 < var3.spriteIntegerValue23; var5++) {
            if (var1) {
               var3.configureSpriteImage(var5, 0, -1, -1);
            }
         }

         if (var1 && var2) {
            var3.clearSpriteData(true);
         }

         return var3;
      }
   }

   // $VF: renamed from: g (int, int) int
   public int scaleScreenCoordinate(int var1, int var2) {
      var1 += this.gameIntegerValue59;
      var2 += this.gameIntegerValue60;
      return var1 >= this.gameIntegerValue59
            && var1 <= this.gameIntegerValue61
            && var2 >= this.gameIntegerValue60
            && var2 <= this.gameIntegerValue62
            && this.gameByteMatrix02[var1][var2] == this.gameByteValue05
         ? this.gameByteMatrix01[var1][var2]
         : 127;
   }

   // $VF: renamed from: i (int, int) void
   public static void handleGameInput(int var0, int var1) {
      if (var0 != -2) {
         gameIntegerValue118 = var0;
      }

      if (var1 != -2) {
         gameIntegerValue119 = var1;
      }
   }

   // $VF: renamed from: V () void
   public void processGameInput() {
      int var1 = getCurrentInputCode();
      if (gameRectangleBoundsReference01 != null && gameBooleanFlag22 && gameRectangleBoundsReference01.boundsId >= 500) {
         if (gameRectangleBoundsReference01.boundsId == 500) {
            var1 = 7;
         } else if (gameRectangleBoundsReference01.boundsId == 501) {
            var1 = 9;
         } else if (gameRectangleBoundsReference01.boundsId == 502) {
            var1 = 13;
         } else if (gameRectangleBoundsReference01.boundsId == 503) {
            var1 = 15;
         } else if (gameRectangleBoundsReference01.boundsId == 504) {
            var1 = 6;
         }

         gameRectangleBoundsReference01 = null;
         gameBooleanFlag22 = false;
      }

      if (var1 != -1) {
         if (var1 == 6) {
            gameIntegerValue120 = 0;
         }

         if (gameIntegerValue120 < gameIntegerArray05.Length) {
            gameIntegerArray05[gameIntegerValue120++] = var1;
         }

         if (gameIntegerValue120 == gameIntegerArray05.Length) {
            if (gameIntegerArray05[0] == 6 && gameIntegerArray05[1] == 7 && gameIntegerArray05[2] == 9 && gameIntegerArray05[3] == 7 && gameIntegerArray05[4] == 9) {
               clearGameInput(1);
            }

            if (gameIntegerArray05[0] == 6 && gameIntegerArray05[1] == 13 && gameIntegerArray05[2] == 15 && gameIntegerArray05[3] == 13 && gameIntegerArray05[4] == 15) {
               clearGameInput(2);
            }

            if (gameIntegerArray05[0] == 6 && gameIntegerArray05[1] == 7 && gameIntegerArray05[2] == 15 && gameIntegerArray05[3] == 13 && gameIntegerArray05[4] == 9) {
               for (int var2 = 0; var2 < this.gameActorGroupReference01.byteValue01; var2++) {
                  this.setActorGroupPosition((sbyte)var2, (sbyte)1);
                  this.setActorGroupPosition((sbyte)var2, (sbyte)2);
               }
            }

            if (gameIntegerArray05[0] == 6 && gameIntegerArray05[1] == 7 && gameIntegerArray05[2] == 9 && gameIntegerArray05[3] == 13 && gameIntegerArray05[4] == 15) {
               this.gameActorGroupReference03.byteArray01[0] = 0;
               this.gameActorGroupReference03.byteArray01[1] = 99;
               this.gameActorGroupReference03.byteArray01[2] = 99;
               this.gameActorGroupReference03.byteArray01[3] = 99;
               this.gameActorGroupReference03.byteArray01[4] = 99;
               this.gameActorGroupReference03.byteArray01[5] = 5;
               this.gameActorGroupReference04.byteArray01[0] = 0;
               this.gameActorGroupReference04.byteArray01[1] = 99;
               this.gameActorGroupReference04.byteArray01[2] = 99;
               this.gameActorGroupReference04.byteArray01[3] = 99;
               this.gameActorGroupReference04.byteArray01[4] = 99;
               this.gameActorGroupReference04.byteArray01[5] = 5;
            }

            if (gameIntegerArray05[0] == 6 && gameIntegerArray05[1] == 7 && gameIntegerArray05[2] == 15 && gameIntegerArray05[3] == 7 && gameIntegerArray05[4] == 15) {
               clearInteractionBounds();
               clearCollisionBounds();
               clearGameInput(3);
               this.resetLevelEvents();
               gameShortValue01 = 731;
               gameByteValue07 = 1;
               this.gameIntegerValue90 = 50;
               this.gameIntegerValue66 = 0;
               this.gameLongValue08 = this.gameLongValue06;
               this.gameByteValue09 = 1;
            }

            gameIntegerValue120++;
         }
      }
   }

   // $VF: renamed from: b (int) boolean
   public static bool isGameInputPressed(int var0) {
      return (gameIntegerValue121 & 1 << var0) != 0;
   }

   // $VF: renamed from: h (int) void
   public static void clearGameInput(int var0) {
      if (isGameInputPressed(var0)) {
         gameIntegerValue121 &= ~(1 << var0);
      } else {
         gameIntegerValue121 |= 1 << var0;
      }
   }

   // $VF: renamed from: W () void
   public void updatePlayerActorState() {
      if (this.gameActorGroupReference01.byteValue04 == 0) {
         this.processActorAction(7);
      }

      if (this.gameActorGroupReference01.byteValue04 == 1 || this.gameActorGroupReference01.byteValue04 == 2) {
         this.processActorAction(14);
      }

      if (this.gameActorGroupReference01.byteValue04 == 3) {
         this.processActorAction(23);
      }

      if (this.gameActorGroupReference01.byteValue04 == 4) {
         this.processActorAction(20);
      }
   }

   // $VF: renamed from: o () void
   public void updateEnemyActorState() {
      try {
         if (this.gameActorGroupReference02.byteValue05 == this.gameByteValue04) {
            sbyte var1 = this.gameActorGroupReference02.actorStateReference01.byteValue01;
            sbyte var2 = this.gameActorGroupReference02.actorStateReference01.byteValue02;
            if (this.gameByteMatrix02[var1][var2] == this.gameByteValue05) {
               if (var2 >= 20 && var2 <= 23 && var1 == 2) {
                  this.gameActorGroupReference02.actorStateReference01.byteValue01++;
               }
            }
         }
      } catch (System.Exception var3) {
      }
   }

   // $VF: renamed from: b (javax.microedition.lcdui.Graphics, int) void
   public void drawBlinkingIndicator(Graphics var1, int var2) {
      if (JSystem.currentTimeMillis() % 1000L > 500L) {
         gameSpriteDecoderReferenceArray08[0].setGraphicsTransform(3);
         bool var3 = false;
         string var4 = getStringResource(0).toUpperCase();
         drawTextWithFont(var1, var4, 180, var2, 36);
         addCollisionBounds(0, 0, 360, 640, 1003);
         gameBooleanFlag10 = true;
         gameSpriteDecoderReferenceArray08[0].setGraphicsTransform(0);
      }
   }

   // $VF: renamed from: s (int) void
   public void setPlayerFacingDirection(int var1) {
      switch (this.gameActorGroupReference01.byteValue04) {
         case 0:
            switch (var1) {
               case 2:
               case 4:
               case 5:
               case 6:
                  this.processActorAction(42);
                  return;
               case 9:
                  this.processActorAction(50);
                  return;
               case 11:
                  this.processActorAction(46); goto case 3;
               case 3:
               case 7:
               case 8:
               case 10:
               default:
                  return;
            } goto case 1;
         case 1:
         case 2:
            switch (var1) {
               case 2:
               case 4:
               case 5:
               case 6:
                  this.processActorAction(40);
                  return;
               case 9:
                  this.processActorAction(48);
                  return;
               case 11:
                  this.processActorAction(44); goto case 3;
               case 3:
               case 7:
               case 8:
               case 10:
               default:
                  return;
            } goto case 3;
         case 3:
            switch (var1) {
               case 2:
               case 4:
               case 5:
               case 6:
                  this.processActorAction(41);
                  return;
               case 9:
                  this.processActorAction(49);
                  return;
               case 11:
                  this.processActorAction(45); goto case 3;
               case 3:
               case 7:
               case 8:
               case 10:
               default:
                  return;
            } goto case 4;
         case 4:
            switch (var1) {
               case 2:
               case 4:
               case 5:
               case 6:
                  this.processActorAction(43); goto case 3;
               case 3:
               case 7:
               case 8:
               case 10:
               default:
                  break;
               case 9:
                  this.processActorAction(51);
                  break;
               case 11:
                  this.processActorAction(47); break;
            }

            gameBooleanFlag64 = true; break;
      }
   }

   // $VF: renamed from: p () void
   public void initializeCanvasDisplay() {
      if (gameIntegerValue126 < 0) {
         screenWidth = 360;
         screenHeight = 640;
         gameByteArray06 = new sbyte[gameIntegerValue134];
         gameByteArray07 = new sbyte[gameIntegerValue134];
         long var2 = JSystem.currentTimeMillis();
         if (gameRandomReference02 == null) {
            gameRandomReference02 = new Random(var2);
         } else {
            gameRandomReference02.setSeed(var2);
         }

         gameIntegerValue126 = 0;
         if (gameDisplayReference01 != null) {
            gameDisplayReference01.callSerially(this);
         }
      }
   }

   public override void hideNotify() {
      this.initializeGameCanvas();
   }

   public override void showNotify() {
      this.loadGameCanvasState();
   }

   public override void sizeChanged(int var1, int var2) {
      screenWidth = var1;
      screenHeight = var2;
   }

   // $VF: renamed from: X () void
   public void showGameCanvas() {
      if (gameDisplayReference01 != null && gameDisplayReference01.getCurrent() != this) {
         gameDisplayReference01.setCurrent(this);
      }

      this.setFullScreenMode(true);
   }

   // $VF: renamed from: run () void
   public void run() {
      try {
         gameBooleanFlag66 = false;
         if (gameIntegerValue126 >= 0) {
            if (gameBooleanFlag65) {
               this.gameLongValue14 = JMath.min(this.gameLongValue14, JSystem.currentTimeMillis());
               Thread.sleep(1L);
            } else {
               this.repaint();
               this.serviceRepaints();
               if (gameRectangleBoundsReference01 != null && (gameBooleanFlag20 || gameBooleanFlag21 || gameBooleanFlag22)) {
                  if (gameIntegerValue28 == 53 && gameIntegerValue50 != 900 && gameIntegerValue50 != 646) {
                     this.keyReleased(gameIntegerValue28);
                     gameBooleanFlag22 = false;
                     gameIntegerValue28 = -1;
                  }

                  if (gameBooleanFlag17 && gameRectangleBoundsReference01 != null) {
                     if (gameIntegerValue50 != 901) {
                        if (gameBooleanFlag17 && JSystem.currentTimeMillis() - gameLongValue04 < 100L) {
                           gameBooleanFlag06 = false;
                        } else {
                           gameBooleanFlag06 = true;
                        }
                     }

                     sbyte var2 = -1;
                     if (gameRectangleBoundsReference01 == null || !gameBooleanFlag20 && !gameBooleanFlag21) {
                        if (gameRectangleBoundsReference01 == null || gameRectangleBoundsReference01.boundsId != 14 || !gameBooleanFlag22 && !gameBooleanFlag20) {
                           if (gameRectangleBoundsReference01 != null && gameRectangleBoundsReference01.boundsId == 15 && (gameBooleanFlag22 || gameBooleanFlag20)) {
                              gameIntegerValue45 = 19;
                           }
                        } else if (gameIntegerValue50 != 900 && gameIntegerValue50 != 646) {
                           var2 = 53;
                        }
                     } else if (gameRectangleBoundsReference01.boundsId == 10) {
                        gameIntegerValue45 = 2563;
                     } else if (gameRectangleBoundsReference01.boundsId == 11) {
                        gameIntegerValue45 = 2049;
                     } else if (gameRectangleBoundsReference01.boundsId == 12) {
                        gameIntegerValue45 = 3076;
                     } else if (gameRectangleBoundsReference01.boundsId == 13) {
                        gameIntegerValue45 = 3586;
                     } else if (gameRectangleBoundsReference01.boundsId == 14 && (gameIntegerValue50 == 900 || gameIntegerValue50 == 646) && !gameBooleanFlag16) {
                        var2 = 53;
                        gameBooleanFlag16 = true;
                     }

                     if (var2 != -1 && var2 != gameIntegerValue28) {
                        if (gameIntegerValue28 != -1) {
                           this.keyReleased(gameIntegerValue28);
                        }

                        gameIntegerValue28 = var2;
                        this.keyPressed(var2);
                     } else if (var2 == -1 && gameBooleanFlag22 && gameIntegerValue28 != -1) {
                        this.keyReleased(gameIntegerValue28);
                        gameIntegerValue28 = -1;
                     }

                     if (var2 == -1 && gameBooleanFlag22 && gameIntegerValue28 == -1 && gameIntegerValue45 == 0) {
                        gameRectangleBoundsReference01 = null;
                        gameBooleanFlag22 = false;
                     }

                     if (gameRectangleBoundsReference01 != null && gameRectangleBoundsReference01.boundsId == 14 && gameBooleanFlag22) {
                        gameRectangleBoundsReference01 = null;
                        gameBooleanFlag22 = false;
                     }
                  } else if (gameIntegerValue28 != -1) {
                     this.keyReleased(gameIntegerValue28);
                     gameIntegerValue28 = -1;
                  }
               }

               long var1 = JSystem.currentTimeMillis();
               this.gameLongValue14 = JMath.min(this.gameLongValue14, var1);
               Thread.sleep(JMath.max(1L, (long)gameIntegerValue127 - (var1 - this.gameLongValue14)));
               this.gameLongValue14 = JSystem.currentTimeMillis();
            }

            gameDisplayReference01.callSerially(this);
            return;
         }
      } catch (System.Exception var3) {
         gameIntegerValue126 = -1;
      }

      gameByteArray06 = null;
      gameByteArray07 = null;
      gameByteMatrix05 = null;
      JSystem.gc();
      gameMidletReference01.notifyDestroyed();
   }

   public override void paint(Graphics var1) {
      Graphics var13 = var1;
      GameCanvas var12 = this;
      if (!gameBooleanFlag65 && !gameBooleanFlag66) {
         gameBooleanFlag66 = true;

         for (int var2 = 0; var2 < gameIntegerValue134; var2++) {
            gameByteArray06[var2] = gameByteArray07[var2];
            if (gameByteArray07[var2] != 0) {
               if (gameByteArray07[var2] < 0) {
                  gameByteArray07[var2] = 0;
               } else if (gameByteArray07[var2] < 126) {
                  gameByteArray07[var2]++;
                  if (var2 >= 18) {
                     gameByteArray07[var2] = (sbyte)(-gameByteArray07[var2]);
                  }
               }
            }
         }

         if (gameIntegerValue133 > 0) {
            if (gameIntegerValue133 != Integer.MAX_VALUE) {
               gameIntegerValue133 = gameIntegerValue133 - gameIntegerValue129;
            }

            initializeInputState();
         }

         if ((gameIntegerValue129 = (int)((gameLongValue13 = JSystem.currentTimeMillis()) - gameLongValue15)) < 0) {
            gameIntegerValue129 = 0;
         }

         if (gameIntegerValue129 > 1000) {
            gameIntegerValue129 = 1000;
         }

         gameLongValue15 = gameLongValue13;
         gameIntegerValue130 = gameIntegerValue130 + gameIntegerValue129;
         gameIntegerValue131++;

         try {
            gameGraphicsReference03 = var13;
            gameGraphicsReference02 = var13;
            GameCanvas var17 = var12;
            if (var12.getWidth() > var12.getHeight()) {
               var12.gameBooleanFlag57 = true;
               SpriteAnimation.loadAnimationTables();
               var1 = gameGraphicsReference02;
               var1.setColor(0);
               int var3 = var12.getWidth();
               int var8 = var12.getHeight();
               setGraphicsClip(var1, 0, 0, var3, var8);
               var1.fillRect(0, 0, var3, var8);
               var1.setColor(16777215);
               int var9 = var3 >> 1;
               int var4 = var8 >> 1;
               string var5 = "The game is not supported";
               string var6 = "in landscape mode.";
               string var7 = "Please switch your phone";
               string var10 = "to portrait mode.";
               var1.setFont(Font.getFont(64, 1, 8));
               var1.drawString(var5, var9, var4 - 40, 17);
               var1.drawString(var6, var9, var4 - 20, 17);
               var1.drawString(var7, var9, var4, 17);
               var1.drawString(var10, var9, var4 + 20, 17);
            } else {
               if (var12.gameBooleanFlag57) {
                  var12.gameBooleanFlag57 = false;
                  var12.initializeGameCanvas();
                  var12.loadGameCanvasState();
               }

               var12.gameGraphicsReference01 = gameGraphicsReference02;

               do {
                  if (!var17.gameBooleanFlag30) {
                     if (gameBooleanFlag62) {
                        var17.gameIntegerValue47 = 9999;
                     } else {
                        var17.gameIntegerValue47 = (int)(JSystem.currentTimeMillis() - var17.gameLongValue06);
                     }

                     var17.gameLongValue06 = var17.gameLongValue06 + (long)var17.gameIntegerValue47;
                     if (var17.gameIntegerValue47 < 0) {
                        var17.gameIntegerValue47 = 0;
                     }

                     var17.gameIntegerValue46 = var17.gameIntegerValue47;
                     if (var17.gameShortValue15 < 24 && gameByteValue07 != 1) {
                        var17.gameIntegerValue96 = var17.gameIntegerValue96 + var17.gameIntegerValue47;
                        if (var17.gameIntegerValue96 < 0) {
                           var17.gameIntegerValue96 = 0;
                        }

                        if (var17.gameIntegerValue96 > 60000) {
                           var17.gameIntegerValue96 = 0;
                           var17.gameShortValue16++;
                           if (var17.gameShortValue16 >= 60) {
                              var17.gameShortValue15++;
                              var17.gameShortValue16 = 0;
                              if (var17.gameShortValue15 >= 24) {
                                 var17.gameShortValue15 = 24;
                                 var17.gameShortValue16 = 0;
                                 var17.gameIntegerValue96 = 0;
                              }
                           }
                        }
                     }

                     if (var17.gameBooleanFlag31) {
                        var17.gameIntegerValue46 = 0;
                        var17.gameBooleanFlag31 = false;
                     } else {
                        var17.gameIntegerValue46 = var17.gameIntegerValue47;
                     }

                     bool var10001;
                      {
                        
                        if (!gameBooleanFlag29) {
                           if (gameIntegerValue48 == 2) {
                              if (gameIntegerValue50 == 384 || gameIntegerValue50 == 900) {
                                 if (gameIntegerValue50 == 900 && var17.isGameModeActive(2821)) {
                                    goto label732_brk;
                                 }

                                 if (gameBooleanFlag06) {
                                    if (var17.isGameModeActive(2049) || var17.isGameModeActive(2563) || var17.isGameModeActive(3076) || var17.isGameModeActive(3586)) {
                                       var10001 = false;
                                       goto label816_brk;
                                    }
                                 } else if (var17.isGameModeActive(2049)) {
                                    var10001 = false;
                                    goto label816_brk;
                                 }
                              }

                              if (gameIntegerValue50 == 131 && (var17.isGameModeActive(3586) || var17.isGameModeActive(2049))) {
                                 var10001 = false;
                                 goto label816_brk;
                              }
                           }

                           if (gameIntegerValue48 == 14 && (var17.isGameModeActive(3586) || var17.isGameModeActive(2049))) {
                              var10001 = false;
                              goto label816_brk;
                           }
                        } label732_brk:;

                        var10001 = true;
                     } label816_brk:;

                     var17.gameBooleanFlag28 = var10001;
                     var17.updateCanvasState();
                     if (!var17.isGameOver()) {
                        switch (gameIntegerValue48) {
                           case 0:
                              Graphics var85 = var17.gameGraphicsReference01;
                              gameIntegerValue48 = 0;
                              if (var85 != null) {
                                 sbyte var94 = 0;
                                 sbyte var68 = 0;
                                 sbyte var59 = 0;
                                 var85.setColor(var59, var68, var94);
                                 fillRectangle(var85, 0, 0, 360, 640);
                                 gameSpriteDecoderReferenceArray01[1].drawSpriteFrameTransformed(var85, 0, 180, 320, 0, 0, 0);
                                 drawTextWithFont(var85, "v" + gameMidletReference01.getAppProperty("MIDlet-Version"), 180, 554, 36);
                                 short var47 = 302;
                                 drawTextWithFont(var85, getStringResource(302), 180, 577, 36);
                                 var47 = 303;
                                 drawTextWithFont(var85, getStringResource(303), 180, 600, 36);
                              }

                              gameIntegerValue48 = 9999;
                              break;
                           case 1:
                              Graphics var84 = var17.gameGraphicsReference01;
                              if (gameBooleanFlag08) {
                                 var17.loadTileDimensions();
                                 var17.processPointerState();
                              } else {
                                 int var92 = 0;
                                 sbyte var67 = 0;
                                 sbyte var58 = 0;
                                 var84.setColor(var58, var67, var92);
                                 fillRectangle(var84, 0, 0, var17.gameShortValue12, var17.gameShortValue13);
                                 gameSpriteDecoderReferenceArray01[0].drawSpriteFrameTransformed(var84, 0, 0, 0, 0, 0, 0);
                                 SpriteResourceDecoder var105 = gameSpriteDecoderReferenceArray01[2];
                                 var92 = gameIntegerValue44 - 90;
                                 int var34 = gameIntegerValue43;
                                 var105.drawSpriteFrameTransformed(var84, 0, var34, var92, 0, 0, 0);
                                 if (gameBooleanFlag26) {
                                    var17.drawBlinkingIndicator(gameGraphicsReference02, 560);
                                    if (var17.isGameModeActive(2821) || gameRectangleBoundsReference01 != null && gameBooleanFlag22) {
                                       clearInteractionBounds();
                                       clearCollisionBounds();
                                       gameBooleanFlag26 = false;
                                    }
                                 } else {
                                    var17.updateGameTimer();
                                    var17.updateGameClock();
                                 }
                              }
                              break;
                           case 2:
                              if (gameIntegerValue50 == 130) {
                                 var17.drawGameBackground(var17.gameGraphicsReference01);
                              } else if (gameIntegerValue50 == 138) {
                                 var17.drawGameBackgroundOverlay(var17.gameGraphicsReference01);
                              } else {
                                 if ((gameIntegerValue50 & 256) != 0) {
                                    var17.updateWorldActors();
                                    var17.updateGameWorld();
                                    var17.updateActorGroupsInWorld();
                                    var17.updateGameEffects();
                                    var17.updateWorldEntities();
                                 }

                                 var17.drawScreenEffects(var17.gameGraphicsReference01);
                                 if (gameBooleanFlag29) {
                                    var17.processGameInput();
                                 }

                                 if (gameIntegerValue23 != -1 && JSystem.currentTimeMillis() - gameLongValue01 >= 1000L) {
                                    playSoundEffect(0, gameIntegerValue23);
                                    gameIntegerValue23 = -1;
                                 }
                              }

                              if (gameIntegerValue125 > 0 && (gameIntegerValue125 = gameIntegerValue125 - gameIntegerValue129) <= 0) {
                                 gameIntegerValue125 = 0;
                              }

                              Graphics var23 = var17.gameGraphicsReference01;
                              if (gameIntegerValue125 > 0 && JSystem.currentTimeMillis() % 600L > 300L) {
                                 var23.setColor(16711680);
                                 var23.drawRect(0, 0, 359, 639);
                                 var23.setColor(13369344);
                                 var23.drawRect(1, 1, 357, 637);
                                 var23.setColor(10027008);
                                 var23.drawRect(2, 2, 355, 635);
                                 var23.setColor(6684672);
                                 var23.drawRect(3, 3, 353, 633);
                              }

                              if (gameIntegerValue40 > 0) {
                                 fillGraphicsRectangle(var17.gameGraphicsReference01, 0, 0, 360, gameIntegerValue40);
                                 fillGraphicsRectangle(var17.gameGraphicsReference01, 0, 640 - gameIntegerValue40, 360, gameIntegerValue40);
                              }
                              break;
                           case 3:
                              Graphics var83 = var17.gameGraphicsReference01;
                              sbyte var91 = 0;
                              int var65 = 0;
                              int var56 = 0;
                              var83.setColor(var56, var65, var91);
                              fillRectangle(var83, 0, 0, gameIntegerValue41, gameIntegerValue42);
                              SpriteResourceDecoder var104 = gameSpriteDecoderReferenceArray01[1];
                              var65 = gameIntegerValue44;
                              var56 = gameIntegerValue43;
                              var104.drawSpriteFrameTransformed(var83, 0, var56, var65, 0, 0, 0);
                              drawTextWithFont(var83, "v" + gameMidletReference01.getAppProperty("MIDlet-Version"), gameIntegerValue43, gameIntegerValue42 - 86, 36);
                              short var45 = 302;
                              drawTextWithFont(var83, getStringResource(302), gameIntegerValue43, gameIntegerValue42 - 63, 36);
                              var45 = 303;
                              drawTextWithFont(var83, getStringResource(303), gameIntegerValue43, gameIntegerValue42 - 40, 36);
                              break;
                           case 8:
                              switch (var17.gameIntegerValue01) {
                                 case 0:
                                    closeAssetStream();
                                    var17.gameTextValue01 = "/6";
                                    openAssetStream(var17.gameTextValue01);
                                    break;
                                 case 1:
                                    closeAssetStream();
                                    var17.gameTextValue01 = "/13";
                                    openAssetStream(var17.gameTextValue01);
                                    break;
                                 case 13:
                                    closeAssetStream();
                                    var17.gameTextValue01 = "/15";
                                    openAssetStream(var17.gameTextValue01);
                                    break;
                                 case 24:
                                    closeAssetStream();
                                    var17.gameTextValue01 = "/14";
                                    openAssetStream(var17.gameTextValue01);
                                    break;
                                 case 26:
                                    closeAssetStream();
                                    var17.gameTextValue01 = "/12";
                                    openAssetStream(var17.gameTextValue01);
                                    break;
                                 case 31:
                                    closeAssetStream();
                                    var17.gameTextValue01 = "/16";
                                    openAssetStream(var17.gameTextValue01);
                                    break;
                                 case 36:
                                    closeAssetStream();
                                    var17.gameTextValue01 = "/17";
                                    openAssetStream(var17.gameTextValue01); break;
                              }

                              if (var17.gameIntegerValue01 < var17.gameIntegerValue02) {
                                 if (var17.gameIntegerValue01 < 1) {
                                    gameByteCube01 = (sbyte[][][])readAssetObject(0);
                                    gameIntegerMatrix01 = (int[][])readAssetObject(1);
                                 } else if (var17.gameIntegerValue01 < 13) {
                                    int var77 = var17.gameIntegerValue01 - 1;
                                    if (var17.isCanvasAssetReady(var77)) {
                                       gameSpriteDecoderReferenceArray02[var77] = createSpriteResource(var77, true, true);
                                    }
                                 } else if (var17.gameIntegerValue01 < 24) {
                                    int var78 = var17.gameIntegerValue01 - 13;
                                    if (var17.isCanvasAssetReady(var78)) {
                                       gameSpriteDecoderReferenceArray04[var78] = createSpriteResource(var78, true, true);
                                    }
                                 } else if (var17.gameIntegerValue01 < 26) {
                                    int var79 = var17.gameIntegerValue01 - 24;
                                    if (var17.isCanvasAssetReady(var79)) {
                                       gameSpriteDecoderReferenceArray03[var79] = createSpriteResource(var79, true, true);
                                    }
                                 } else if (var17.gameIntegerValue01 < 31) {
                                    int var80 = var17.gameIntegerValue01 - 26;
                                    if (var17.isCanvasAssetReady(var80)) {
                                       gameSpriteDecoderReferenceArray06[var80] = createSpriteResource(var80, true, true);
                                       if (var80 == 4) {
                                          (gameClass11Reference04 = new SpriteAnimation(gameSpriteDecoderReferenceArray06[var80], 0, 0)).playAnimation(0, -1);
                                       }
                                    }
                                 } else if (var17.gameIntegerValue01 < 36) {
                                    int var81 = var17.gameIntegerValue01 - 31;
                                    if (var17.isCanvasAssetReady(var81)) {
                                       gameSpriteDecoderReferenceArray05[var81] = createSpriteResource(var81, true, true);
                                       if (var81 == 0) {
                                          gameClass11Reference02 = new SpriteAnimation(gameSpriteDecoderReferenceArray05[var81], 0, 0);
                                       }
                                    }
                                 } else {
                                    int var82 = var17.gameIntegerValue01 - 36;
                                    if (var17.isCanvasAssetReady(var82)) {
                                       gameSpriteDecoderReferenceArray07[var82] = createSpriteResource(var82, true, true);
                                       if (var82 == 1) {
                                          gameSpriteDecoderReferenceArray07[1].configureSpriteImage(0, 0, 1, -1);
                                       }
                                    }
                                 }
                              }

                              var17.gameIntegerValue01++;
                              var17.drawLoadingProgress(var17.gameGraphicsReference01);
                              break;
                           case 9:
                              switch (var17.gameIntegerValue01) {
                                 case 0:
                                    if (var17.gameBooleanFlag01) {
                                       var17.saveGameData(true);
                                    }

                                    var17.resetActorActions();
                                    gameSpriteDecoderReferenceArray07[0] = null;
                                    gameSpriteDecoderReferenceArray07[2] = null;
                                    gameSpriteDecoderReferenceArray07[1] = null;
                                    gameSpriteDecoderReferenceArray07[3] = null;
                                    gameSpriteDecoderReferenceArray02[7] = null;
                                    gameSpriteDecoderReferenceArray02[8] = null;
                                    gameSpriteDecoderReferenceArray02[10] = null;
                                    gameSpriteDecoderReferenceArray02[9] = null;
                                    gameSpriteDecoderReferenceArray02[6] = null;
                                    gameSpriteDecoderReferenceArray04[10] = null;
                                    gameSpriteDecoderReferenceArray05[4] = null;
                                    JSystem.gc();
                                    var17.gameByteValue04 = (sbyte)var17.gameIntegerValue05;
                                    break;
                                 case 1:
                                    var17.initializeLevelResources();
                                    break;
                                 case 2:
                                    var17.loadGameCanvasAssets();
                                    break;
                                 case 3:
                                    if (!var17.gameBooleanArray01[var17.gameByteValue04]) {
                                       var17.updateCurrentLevel();
                                    }
                                    break;
                                 case 4:
                                    var17.gameBooleanFlag01 = var17.gameBooleanFlag01 & var17.gameBooleanArray01[var17.gameByteValue04];
                                    if (var17.gameBooleanFlag01) {
                                       var17.loadGameData(true);
                                    }

                                    var17.gameBooleanArray01[var17.gameByteValue04] = true;
                                    if (var17.gameByteValue04 == 0 && var17.gameBooleanFlag35) {
                                       var17.gameShortMatrix02[var17.gameClass9ReferenceArray01[545].byteValue02][var17.gameClass9ReferenceArray01[545].byteValue03] = -1;
                                    }

                                    var17.gameActorGroupReference01.byteValue05 = var17.gameByteValue04;
                                    if (var17.gameActorGroupReference02.byteValue05 != var17.gameByteValue04) {
                                       var17.gameActorGroupReference02.actorStateReference01.booleanFlag01 = false;
                                    } else {
                                       var17.gameActorGroupReference02.actorStateReference01.booleanFlag01 = true;
                                    }

                                    var17.clearActorStatusEffects();
                                    var17.updateAllActors(true);
                                    var17.updateLevelEntities();
                                    var17.updateTimedEntities();
                                    var17.updateActorDisplayState(var17.gameActorGroupReference01.actorStateReference01, true); break;
                              }

                              var17.gameIntegerValue01++;
                              var17.drawLoadingProgress(var17.gameGraphicsReference01);
                              break;
                           case 10:
                              var17.updateLoadingState();
                              var17.drawLoadingProgress(var17.gameGraphicsReference01);
                              break;
                           case 11:
                              Graphics var76 = var17.gameGraphicsReference01;
                              int var19 = 3816503;
                              gameGraphicsReference02.setColor(var19);
                              fillGraphicsRectangle(var76, 0, 0, 360, 640);
                              gameGraphicsReference02.setColor(0);
                              fillGraphicsRectangle(var76, UiLayoutPresetA.integerValue03, UiLayoutPresetA.integerValue04, UiLayoutPresetA.integerValue01, UiLayoutPresetA.integerValue02);
                              gameSpriteDecoderReferenceArray08[1].setGraphicsTransform(2);
                              SpriteResourceDecoder var100 = gameSpriteDecoderReferenceArray08[1];
                              int var42 = 263;
                              string var113 = getStringResource(263).toUpperCase();
                              int var64 = UiLayoutPresetA.integerValue05;
                              string var55 = var113;
                              var100.drawBitmapTextLine(var76, var55, 180, var64, 3, true);
                              gameSpriteDecoderReferenceArray08[0].setGraphicsTransform(3);
                              string var89 = getStringResource(var42 = 255 + (gameIntegerValue21 >= 3 ? gameIntegerValue21 + 1 : gameIntegerValue21));
                              var100 = gameSpriteDecoderReferenceArray08[0];
                              var19 = UiLayoutPresetA.integerValue07;
                              short[] var31 = var100.loadBitmapFont(var89, var19, false);
                              gameSpriteDecoderReferenceArray08[0].drawBitmapText(var76, var89, var31, UiLayoutPresetA.integerValue08, UiLayoutPresetA.integerValue09, 0, -1, 20, -1);
                              string var44 = gameIntegerValue21 + 1 + "/" + 3;
                              gameIntegerValue34 = gameSpriteDecoderReferenceArray09[0].getSpriteWidth(43);
                              gameIntegerValue35 = gameSpriteDecoderReferenceArray09[0].getSpriteHeight(43);
                              var100 = gameSpriteDecoderReferenceArray09[0];
                              int var114 = gameRectangleBoundsReference01 != null && gameRectangleBoundsReference01.boundsId == 3 ? 44 : 43;
                              int var119 = 180 - gameIntegerValue34;
                              var19 = UiLayoutPresetA.integerValue11;
                              int var32 = var119;
                              int var97 = var114;
                              var100.drawSpriteFrameTransformed(var76, var97, var32, var19, 0, 0, 0);
                              addCollisionBounds(180 - gameIntegerValue34 * 3 / 2, UiLayoutPresetA.integerValue11 - gameIntegerValue35 / 2, gameIntegerValue34, gameIntegerValue35, 3);
                              var100 = gameSpriteDecoderReferenceArray09[0];
                              int var115 = gameRectangleBoundsReference01 != null && gameRectangleBoundsReference01.boundsId == 4 ? 46 : 45;
                              var119 = 180 + gameIntegerValue34;
                              var19 = UiLayoutPresetA.integerValue11;
                              int var90 = var119;
                              int var33 = var115;
                              var100.drawSpriteFrameTransformed(var76, var33, var90, var19, 0, 0, 0);
                              addCollisionBounds(180 + (gameIntegerValue34 >> 1), UiLayoutPresetA.integerValue11 - gameIntegerValue35 / 2, gameIntegerValue34, gameIntegerValue35, 4);
                              gameBooleanFlag10 = true;
                              drawTextWithFont(var76, var44, 180, UiLayoutPresetA.integerValue11 - gameIntegerValue35 / 4, 36);
                              if (!var17.isGameModeActive(2563) && (gameRectangleBoundsReference01 == null || gameRectangleBoundsReference01.boundsId != 3 || !gameBooleanFlag22)) {
                                 if (!var17.isGameModeActive(3076) && (gameRectangleBoundsReference01 == null || gameRectangleBoundsReference01.boundsId != 4 || !gameBooleanFlag22)) {
                                    if (var17.isGameModeActive(19) || gameRectangleBoundsReference02 != null && gameRectangleBoundsReference02.boundsId == 1002 && gameBooleanFlag22) {
                                       clearInteractionBounds();
                                       clearCollisionBounds();
                                       if (gameIntegerValue22 == 0) {
                                          gameIntegerValue48 = 1;
                                          stopSoundEffect(0);
                                       } else {
                                          gameIntegerValue48 = 2;
                                       }

                                       var17.processActorAction(21);
                                    }
                                 } else {
                                    clearInteractionBounds();
                                    clearCollisionBounds();
                                    if (gameIntegerValue21 < 2) {
                                       gameIntegerValue21++;
                                    } else {
                                       gameIntegerValue21 = 0;
                                    }
                                 }
                              } else {
                                 clearInteractionBounds();
                                 clearCollisionBounds();
                                 if (gameIntegerValue21 > 0) {
                                    gameIntegerValue21--;
                                 } else {
                                    gameIntegerValue21 = 2;
                                 }
                              }

                              initializeInputState();
                              break;
                           case 12:
                              int var75 = getPreviousInputCode();
                              sbyte var88 = 0;
                              switch (var75) {
                                 case 1:
                                 case 8:
                                    var88 = 21;
                                    break;
                                 case 2:
                                 case 14:
                                    var88 = 32;
                                    break;
                                 case 3:
                                 case 10:
                                    var88 = 23;
                                    break;
                                 case 4:
                                 case 12:
                                    var88 = 24;
                                    break;
                                 case 5:
                                 case 11:
                                 case 18:
                                    var17.processActorAction(8);
                                    var88 = 25; goto case 6;
                                 case 6:
                                 case 7:
                                 case 9:
                                 case 13:
                                 case 15:
                                 case 16:
                                 case 17:
                                 default:
                                    break;
                                 case 19:
                                    var17.processActorAction(21);
                                    var88 = 26; break;
                              }

                              bool var30 = GameUiController.shouldShowMobileLibrary(var88);
                              GameUiController.renderUiOverlay(gameGraphicsReference02);
                              if (var30) {
                                 var17.changeActorAction(1, 129);
                                 var17.transitionGameState(0);
                              }
                              break;
                           case 14:
                              Graphics var73 = var17.gameGraphicsReference01;
                              int var28 = 3816503;
                              gameGraphicsReference02.setColor(var28);
                              fillGraphicsRectangle(var73, 0, 0, 360, 640);
                              gameGraphicsReference02.setColor(0);
                              fillGraphicsRectangle(var73, UiLayoutPresetB.integerValue03, UiLayoutPresetB.integerValue04, UiLayoutPresetB.integerValue01, UiLayoutPresetB.integerValue02);
                              setGraphicsClip(var73, UiLayoutPresetB.integerValue05, UiLayoutPresetB.integerValue06, 360, UiLayoutPresetB.integerValue07);
                              gameSpriteDecoderReferenceArray08[0].setGraphicsTransform(3);
                              if (gameShortArray01 != null) {
                                 SpriteResourceDecoder var98 = gameSpriteDecoderReferenceArray08[0];
                                 int var96 = var17.gameIntegerValue01;
                                 short[] var54 = gameShortArray01;
                                 string var40 = gameTextValue02;
                                 var98.drawBitmapText(var73, var40, var54, 180, var96, 0, -1, 17, -1);
                              }

                              setGraphicsClip(gameGraphicsReference02, 0, 0, 360, 640);
                              gameSpriteDecoderReferenceArray08[1].setGraphicsTransform(2);
                              SpriteResourceDecoder var99 = gameSpriteDecoderReferenceArray08[1];
                              short var41 = 264;
                              string var112 = getStringResource(264).toUpperCase();
                              int var18 = UiLayoutPresetB.integerValue08;
                              string var29 = var112;
                              var99.drawBitmapTextLine(var73, var29, 180, var18, 3, true);
                              int var74 = 2;
                              if (var17.isGameModeActive(3586)) {
                                 var74 = 4;
                              } else if (var17.isGameModeActive(2049)) {
                                 var74 = -4;
                              } else if (var17.isGameModeActive(19) || gameRectangleBoundsReference02 != null && gameRectangleBoundsReference02.boundsId == 1002 && gameBooleanFlag22 && !gameBooleanFlag50) {
                                 clearInteractionBounds();
                                 clearCollisionBounds();
                                 if (gameIntegerValue27 == 0) {
                                    gameIntegerValue48 = 1;
                                 } else {
                                    var17.changeActorAction(1, 129);
                                 }

                                 stopSoundEffect(6);
                                 var17.processActorAction(21);
                                 gameTextValue02 = null;
                                 gameShortArray01 = null;
                                 initializeInputState();
                                 gameShortValue01 = 0;
                              }

                              if (gameBooleanFlag20) {
                                 var74 = 0;
                              } else if (gameBooleanFlag21) {
                                 var74 = gameIntegerValue30 = (gameIntegerValue29 - gameIntegerValue32) / 10;
                              } else if (gameBooleanFlag22) {
                                 if (gameIntegerValue30 > 0) {
                                    gameIntegerValue30--;
                                 } else if (gameIntegerValue30 < 0) {
                                    gameIntegerValue30++;
                                 }

                                 if (gameIntegerValue30 != 0) {
                                    var74 = gameIntegerValue30;
                                 }
                              }

                              if (gameShortArray01 != null) {
                                 if (var74 > 0) {
                                    if (var17.gameIntegerValue01 > UiLayoutPresetB.integerValue06 - gameShortArray01[0] * (gameSpriteDecoderReferenceArray08[0].getSpriteCanvasWidth() + gameSpriteDecoderReferenceArray08[0].getSpriteImageWidth())) {
                                       var17.gameIntegerValue01 -= var74;
                                    } else {
                                       var17.gameIntegerValue01 = 640;
                                    }
                                 } else if (var74 < 0) {
                                    if (var17.gameIntegerValue01 < 640) {
                                       var17.gameIntegerValue01 -= var74;
                                    } else {
                                       var17.gameIntegerValue01 = UiLayoutPresetB.integerValue06 - gameShortArray01[0] * (gameSpriteDecoderReferenceArray08[0].getSpriteCanvasWidth() + gameSpriteDecoderReferenceArray08[0].getSpriteImageWidth());
                                    }
                                 }
                              }

                              if (gameBooleanFlag50 && var17.gameIntegerValue01 == 640) {
                                 gameShortValue01 = 0;
                                 if (gameBooleanFlag24) {
                                    var17.changeActorAction(15, 0);
                                    var17.updateCanvasState();
                                 }

                                 gameBooleanFlag50 = false;
                              }
                              break;
                           case 15:
                              gameGraphicsReference02.setColor(0);
                              setGraphicsClip(gameGraphicsReference02, 0, 0, 360, 640);
                              int var38 = screenHeight;
                              int var25 = screenWidth;
                              fillGraphicsRectangle(gameGraphicsReference02, 0, 0, var25, var38);
                              gameSpriteDecoderReferenceArray08[0].setGraphicsTransform(0);
                              short var39 = 315;
                              string var87 = getStringResource(315);
                              short[] var26 = gameSpriteDecoderReferenceArray08[0].loadBitmapFont(var87, 360, false);
                              gameSpriteDecoderReferenceArray08[0].drawBitmapText(gameGraphicsReference02, var87, var26, 180, UiLayoutPresetE.integerValue14, 0, -1, 3, -1);
                              bool var72 = var17.isGameModeActive(2821) || var17.isGameModeActive(18);
                              gameIntegerValue34 = gameSpriteDecoderReferenceArray09[1].getSpriteWidth(15) + 2;
                              gameIntegerValue35 = gameSpriteDecoderReferenceArray09[1].getSpriteHeight(15) + 2;
                              SpriteResourceDecoder var10000 = gameSpriteDecoderReferenceArray09[1];
                              int var10002 = gameRectangleBoundsReference01 != null && gameRectangleBoundsReference01.boundsId == 0 ? 19 : 20;
                              int var10003 = (gameIntegerValue34 >> 1) + 2;
                              var25 = (gameIntegerValue35 >> 1) + 2;
                              int var95 = var10003;
                              int var63 = var10002;
                              Graphics var53 = gameGraphicsReference02;
                              var10000.drawSpriteFrameTransformed(var53, var63, var95, var25, 0, 0, 0);
                              addCollisionBounds(0, 0, UiLayoutPresetC.integerValue08, UiLayoutPresetC.integerValue08, 0);
                              gameBooleanFlag10 = true;
                              if (var72 || gameRectangleBoundsReference01 != null && gameRectangleBoundsReference01.boundsId == 0 && gameBooleanFlag22) {
                                 clearCollisionBounds();
                                 clearInteractionBounds();
                                 var17.changeActorAction(12, 0);
                                 var17.updateCanvasState();
                              }
                              break;
                           case 9999:
                              var17.beginGameplayState(); break;
                        }

                        if (var17.gameIntegerValue115 == 0 && var17.gameIntegerValue116 == 0 && !gameBooleanFlag26) {
                           setGraphicsClip(var17.gameGraphicsReference01, 0, 0, 360, 640);
                           if (!gameBooleanFlag62) {
                              Graphics var86 = var17.gameGraphicsReference01;
                              handleGameInput(-1, -1);
                              if (gameIntegerValue48 == 2) {
                                 int var35 = gameBooleanFlag63 ? 2 : 0;
                                 if (gameBooleanFlag29) {
                                    if (gameBooleanFlag08 && gameIntegerValue19 == 24) {
                                       handleGameInput(3, -1);
                                    } else {
                                       handleGameInput(-1, -1);
                                    }
                                 } else if ((gameIntegerValue50 & 256) == 0 && (gameIntegerValue50 & 512) == 0) {
                                    if (gameIntegerValue50 != 130 && gameIntegerValue50 != 138) {
                                       if (gameIntegerValue50 == 137) {
                                          handleGameInput(3, -1);
                                       } else if (gameIntegerValue50 == 139) {
                                          handleGameInput(3, -1);
                                       } else if (gameIntegerValue50 == 131) {
                                          if (gameIntegerValue67 == 3) {
                                             handleGameInput(-1, -1);
                                          } else if (gameIntegerValue67 == 1) {
                                             handleGameInput(var35, 1);
                                          } else {
                                             handleGameInput(var35, -1);
                                          }
                                       } else {
                                          handleGameInput(3, -1);
                                       }
                                    } else {
                                        {
                                          if (gameIntegerValue50 == 138) {
                                             bool var15 = false;
                                             sbyte var69 = 0;
                                             sbyte var60;
                                             if ((var60 = var17.gameShortValue14 == 0 ? var17.gameByteArray04[2 * var17.gameIntegerValue84] : var17.gameByteArray04[2 * var17.gameIntegerValue85])
                                                <= 6) {
                                                var15 = var17.gameShortValue14 == 0
                                                   ? var17.gameActorGroupReference04.entitySnapshotReferenceArray01[var60].booleanFlag01
                                                   : var17.gameActorGroupReference03.entitySnapshotReferenceArray01[var60].booleanFlag01;
                                                var69 = var17.gameShortValue14 == 0 ? var17.gameActorGroupReference03.byteArray01[var60 - 1] : var17.gameActorGroupReference04.byteArray01[var60 - 1];
                                             }

                                             bool var106;
                                              {
                                                if (var60 < 6) {
                                                   if (var60 <= 1 || var60 >= 6 || !var15) {
                                                      var106 = false;
                                                      goto label605_brk;
                                                   }

                                                   if (var69 <= 0) {
                                                      var106 = false;
                                                      goto label605_brk;
                                                   }
                                                } else if (var60 == 6 && var69 < 1) {
                                                   var106 = false;
                                                   goto label605_brk;
                                                }

                                                var106 = true;
                                             } label605_brk:;

                                             if (!var106) {
                                                handleGameInput(-1, 1);
                                                goto label832_brk;
                                             }
                                          }

                                          handleGameInput(3, 1);
                                       } label832_brk:;
                                    }
                                 } else if (gameShortValue01 == 731) {
                                    handleGameInput(-1, -1);
                                 } else if (!isGameplayRunning() && gameBooleanFlag59 && gameIntegerValue50 != 901 && gameIntegerValue50 != 646 && gameIntegerValue50 != 647) {
                                    handleGameInput(var35, -1);
                                 } else {
                                    handleGameInput(var35, -1);
                                 }
                              } else if (gameIntegerValue48 == 1) {
                                 if (gameIntegerValue06 == 1) {
                                    handleGameInput(3, 1);
                                 } else if (gameBooleanFlag08) {
                                    if (gameIntegerValue19 == 3) {
                                       handleGameInput(3, -1);
                                    } else {
                                       handleGameInput(3, -1);
                                    }
                                 } else {
                                    handleGameInput(3, -1);
                                 }
                              } else if (gameIntegerValue48 == 11) {
                                 handleGameInput(-1, 1);
                              } else if (gameIntegerValue48 == 14) {
                                 if (gameBooleanFlag50) {
                                    handleGameInput(-1, -1);
                                 } else {
                                    handleGameInput(-1, 1);
                                 }
                              } else if (gameIntegerValue48 == 15) {
                                 handleGameInput(3, -1);
                              }

                              if (gameIntegerValue118 == 3) {
                                 gameIntegerValue118 = -1;
                              }

                              if (gameIntegerValue118 != -1) {
                                 gameIntegerValue34 = gameSpriteDecoderReferenceArray09[1].getSpriteWidth(21) + 2;
                                 gameIntegerValue35 = gameSpriteDecoderReferenceArray09[1].getSpriteHeight(21) + 2;
                                 if (gameIntegerValue118 == 2 && gameIntegerValue48 == 2 && gameBooleanFlag63) {
                                    addInteractionBounds(0, 0, gameIntegerValue34, gameIntegerValue35, 1001);
                                    SpriteResourceDecoder var108 = gameSpriteDecoderReferenceArray09[1];
                                    int var117 = gameRectangleBoundsReference02 != null && gameRectangleBoundsReference02.boundsId == 1001 ? 21 : 22;
                                    int var122 = (gameIntegerValue34 >> 1) + 2;
                                    int var71 = (gameIntegerValue35 >> 1) + 2;
                                    int var62 = var122;
                                    int var50 = var117;
                                    var108.drawSpriteFrameTransformed(var86, var50, var62, var71, 0, 0, 0);
                                    gameSpriteDecoderReferenceArray08[0].setGraphicsTransform(gameRectangleBoundsReference02 != null && gameRectangleBoundsReference02.boundsId == 1001 ? 3 : 0);
                                    var108 = gameSpriteDecoderReferenceArray08[0];
                                    short var51 = 905;
                                    var108.drawBitmapTextLine(var86, getStringResource(905), gameIntegerValue34 >> 1, gameIntegerValue35 >> 1, 3, false);
                                    gameSpriteDecoderReferenceArray08[0].setGraphicsTransform(0);
                                 } else {
                                    if (!gameBooleanFlag53 && var17.canProcessPointerInput() && gameIntegerValue118 << 1 == 0) {
                                       SpriteResourceDecoder var107 = gameSpriteDecoderReferenceArray09[1];
                                       int var116 = gameRectangleBoundsReference02 != null && gameRectangleBoundsReference02.boundsId == 1001 ? 16 : 15;
                                       int var121 = (gameIntegerValue34 >> 1) + 2 - gameIntegerValue34 / 4;
                                       int var70 = (gameIntegerValue35 >> 1) + 2;
                                       int var61 = var121;
                                       int var49 = var116;
                                       var107.drawSpriteFrameTransformed(var86, var49, var61, var70, 0, 0, 0);
                                    }

                                    addInteractionBounds(0, 0, gameIntegerValue34, gameIntegerValue35, 1001);
                                 }
                              }

                              if (gameIntegerValue119 != -1) {
                                 gameIntegerValue34 = gameSpriteDecoderReferenceArray09[1].getSpriteWidth(17) + 2;
                                 gameIntegerValue35 = gameSpriteDecoderReferenceArray09[1].getSpriteHeight(17) + 2;
                                 SpriteResourceDecoder var110 = gameSpriteDecoderReferenceArray09[1];
                                 int var118 = gameRectangleBoundsReference02 != null && gameRectangleBoundsReference02.boundsId == 1002 ? 18 : 17;
                                 int var123 = gameIntegerValue41 - ((gameIntegerValue34 >> 1) + 2);
                                 int var52 = 640 - (gameIntegerValue35 >> 1) + -2;
                                 int var36 = var123;
                                 int var16 = var118;
                                 var110.drawSpriteFrameTransformed(var86, var16, var36, var52, 0, 0, 0);
                                 addInteractionBounds(gameIntegerValue41 - UiLayoutPresetC.integerValue08, 640 - gameIntegerValue35 + -2 + 2, UiLayoutPresetC.integerValue08, UiLayoutPresetC.integerValue08, 1002);
                                 if (gameIntegerValue119 < 0) {
                                    gameIntegerValue119 = -gameIntegerValue119;
                                 }
                              }

                              if (gameIntegerValue118 != -1 || gameIntegerValue119 != -1) {
                                 gameBooleanFlag11 = true;
                              }
                           }
                        }

                        if (gameIntegerValue48 == 2) {
                           gameClass11Reference03.advanceAnimation(gameIntegerValue129);
                        }

                        if (gameBooleanFlag29) {
                           if (gameBooleanFlag08) {
                              var17.loadTileDimensions();
                              var17.processPointerState();
                           } else if (gameIntegerValue48 != 11 && gameIntegerValue48 != 9) {
                              if (var17.gameIntegerValue116 > 0) {
                                 var17.gameIntegerValue116--;
                              } else {
                                 int var24 = ((gameIntegerValue08 < 10 ? gameIntegerValue08 : 10) + 1) * 43;
                                 gameIntegerValue16 = (640 - var24 >> 1) + 10;
                                 SpriteResourceDecoder var111 = gameSpriteDecoderReferenceArray09[0];
                                 Graphics var37 = gameGraphicsReference02;
                                 var111.drawSpriteFrameTransformed(var37, 0, 180, 320, 0, 0, 0);
                                 addCollisionBounds(0, 0, gameIntegerValue38, gameIntegerValue38, 500);
                                 addCollisionBounds(360 - gameIntegerValue38, 0, gameIntegerValue38, gameIntegerValue38, 501);
                                 addCollisionBounds(0, 640 - gameIntegerValue38, gameIntegerValue38, gameIntegerValue38, 502);
                                 addCollisionBounds(360 - gameIntegerValue38, 640 - gameIntegerValue38, gameIntegerValue38, gameIntegerValue38, 503);
                                 addCollisionBounds(180 - gameIntegerValue38 / 2, 0, gameIntegerValue38, gameIntegerValue38, 504);
                                 var17.updateGameTimer();
                                 var17.updateGameClock();
                              }
                           }
                        }
                     }
                  }
               } while (gameBooleanFlag62);

               SpriteAnimation.noOpAnimationSetup();
               if (gameBooleanFlag13) {
                  if (gameLongValue02 == 0L) {
                     gameLongValue02 = JSystem.currentTimeMillis();
                  }

                  if (JSystem.currentTimeMillis() - gameLongValue02 > 300L) {
                     gameBooleanFlag12 = true;
                     gameBooleanFlag13 = false;
                     gameLongValue02 = 0L;
                  }
               }
            }
         } catch (System.Exception var11) {
            gameIntegerValue126 = -1;
         }

         gameBooleanFlag66 = false;
      }
   }

   public override void keyPressed(int var1) {
      sbyte var2 = readGameSetting(var1);
      if (gameByteArray07 != null) {
         if (gameByteArray07[var2] <= 0) {
            if (gameByteArray07[var2] < 0) {
               gameByteArray07[var2] = 0;
            }

            if (gameByteArray07[var2] < 126) {
               gameByteArray07[var2]++;
            }
         }
      }
   }

   public override void keyReleased(int var1) {
      sbyte var2 = readGameSetting(var1);
      if (gameByteArray07 != null) {
         if (gameByteArray07[var2] > 0) {
            gameByteArray07[var2] = (sbyte)(-gameByteArray07[var2]);
         }
      }
   }

   // $VF: renamed from: b (boolean, int, int) void
   public static void storeGameSetting(bool var0, int var1, int var2) {
      Integer var5 = new Integer(var1);
      Hashtable var4 = gameHashtableReference01;
      if ((Integer)gameHashtableReference01.get(var5) != null) {
         var4.remove(var5);
      }

      var4.put(var5, new Integer(var2));
   }

   // $VF: renamed from: a (int) byte
   public static sbyte readGameSetting(int var0) {
      Integer var2 = new Integer(var0);
      if (gameHashtableReference01 == null) {
         return 0;
      } else {
         Integer var1;
         if ((var1 = (Integer)gameHashtableReference01.get(var2)) != null) {
            return var1.byteValue();
         } else {
            return (var1 = (Integer)gameHashtableReference02.get(var2)) != null ? var1.byteValue() : (sbyte)0;
         }
      }
   }

   // $VF: renamed from: Y () void
   public static void initializeInputState() {
      if (gameByteArray06 != null && gameByteArray07 != null) {
         for (int var0 = 0; var0 < gameIntegerValue134; var0++) {
            gameByteArray06[var0] = 0;
            gameByteArray07[var0] = 0;
         }
      }
   }

   // $VF: renamed from: f (int) boolean
   public static bool isInputPressed(int var0) {
      return gameByteArray06[var0] > 0;
   }

   // $VF: renamed from: b () int
   public static int getCurrentInputCode() {
      int var0 = gameIntegerValue134;

      while (--var0 >= 0) {
         if (gameByteArray06[var0] == 1) {
            return var0;
         }
      }

      return -1;
   }

   // $VF: renamed from: e () int
   public static int getPreviousInputCode() {
      int var0 = gameIntegerValue134;

      while (--var0 >= 0) {
         if (gameByteArray06[var0] < 0) {
            return var0;
         }
      }

      return -1;
   }

   // $VF: renamed from: g (int) boolean
   public static bool isInputEnabled(int var0) {
      return gameByteArray06[var0] == 1;
   }

   // $VF: renamed from: a (int) byte[]
   public static sbyte[] loadAssetBytes(int var0) {
      int var40 = getAssetSize(var0);
      sbyte[] var1 = null;
      if (gameBooleanFlag68) {
         try {
            InputStream var2 = gameInputStreamReference01;
            sbyte[] var4 = new sbyte[var40 + 1];
            readStreamFully(var2, var4, 0, var40);
            int var41 = 0;

            for (int var3 = 0; var3 < 4; var3++) {
               var41 += (var4[var3 + 5] & 255) << (var3 << 3);
            }

            int var47;
            int var6 = (var47 = var4[0] & 255) / 45;
            int var48;
            int var5 = (var48 = var47 % 45) / 9;
            var47 = var48 % 9;
            int var7 = 1846 + (768 << var47 + var5);
            gameByteArray11 = new sbyte[var41];
            gameShortArray04 = new short[var7];
            int var10000 = var7 << 1;
            var7 = var41;
            int var50 = var47;
            int var42 = var10000;
            int var8 = 1846 + (768 << var47 + var5);
            short[] var9 = gameShortArray04;
            int var10 = 0;
            bool var11 = false;
            int var12 = 0;
            int var69 = 1;
            int var14 = 1;
            int var15 = 1;
            int var16 = 1;
            int var17 = 0;
            int var54 = (1 << var6) - 1;
            int var52 = (1 << var5) - 1;
            if (var42 >= var8 << 1) {
               for (int var43 = 0; var43 < var8; var43++) {
                  var9[var43] = 1024;
               }

               int var35 = var4.Length;
               gameByteArray10 = var4;
               gameIntegerValue143 = var35;
               gameIntegerValue144 = 13;
               gameLongValue17 = 0L;
               gameLongValue16 = 4294967295L;
               var4[gameIntegerValue143 - 1] = -1;

               for (int var36 = 0; var36 < 5; var36++) {
                  gameLongValue17 = gameLongValue17 << 8 | (long)(gameByteArray10[gameIntegerValue144++] & 255);
               }

               while (var17 < var7) {
                  int var44 = var17 & var54;
                  if (nextRandomValue(0 + (var10 << 4) + var44) == 0) {
                     var6 = 1846 + 768 * (((var17 & var52) << var50) + ((var12 & 0xFF) >> 8 - var50));
                     if (var10 < 4) {
                        var10 = 0;
                     } else if (var10 < 10) {
                        var10 -= 3;
                     } else {
                        var10 -= 6;
                     }

                     if (var11) {
                        sbyte var66 = gameByteArray11[var17 - var69];
                        sbyte var72 = var66;
                        int var62 = var6;
                        int var73 = 1;

                        do {
                           int var38 = var72 >> 7 & 1;
                           var72 = (sbyte)(var72 << 1);
                           int var74 = nextRandomValue(var62 + (var38 + 1 << 8) + var73);
                           var73 = var73 << 1 | var74;
                           if (var38 != var74) {
                              while (var73 < 256) {
                                 var73 = var73 << 1 | nextRandomValue(var62 + var73);
                              }
                              break;
                           }
                        } while (var73 < 256);

                        var12 = var73 & 0xFF;
                        var11 = false;
                     } else {
                        int var71 = 1;

                        while ((var71 = var71 << 1 | nextRandomValue(var6 + var71)) < 256) {
                        }

                        var12 = var71 & 0xFF;
                     }

                     gameByteArray11[var17++] = (sbyte)var12;
                  } else {
                     var11 = true;
                     int var45;
                     if (nextRandomValue(var10 + 192) == 1) {
                        if (nextRandomValue(var10 + 204) == 0) {
                           if (nextRandomValue(240 + (var10 << 4) + var44) == 0) {
                              var10 = var10 < 7 ? 9 : 11;
                              var12 = gameByteArray11[var17 - var69] & 255;
                              gameByteArray11[var17++] = (sbyte)var12;
                              continue;
                           }
                        } else {
                           if (nextRandomValue(var10 + 216) == 0) {
                              var6 = var14;
                           } else {
                              if (nextRandomValue(var10 + 228) == 0) {
                                 var6 = var15;
                              } else {
                                 var6 = var16;
                                 var16 = var15;
                              }

                              var15 = var14;
                           }

                           var14 = var69;
                           var69 = var6;
                        }

                        var45 = randomInRange(1332, var44);
                        var10 = var10 < 7 ? 8 : 11;
                     } else {
                        var16 = var15;
                        var15 = var14;
                        var14 = var69;
                        var10 = var10 < 7 ? 7 : 10;
                        var45 = randomInRange(818, var44);
                        if ((var6 = generateRandomPowerOfTwo(432 + ((var45 < 4 ? var45 : 3) << 6), 6)) < 4) {
                           var69 = var6;
                        } else {
                           var8 = (var6 >> 1) - 1;
                           var69 = (2 | var6 & 1) << var8;
                           if (var6 < 14) {
                              var69 += generateRandomMask(var69 + 688 - var6 - 1, var8);
                           } else {
                              var6 = var8 - 4;
                              long var70 = gameLongValue16;
                              long var37 = gameLongValue17;
                              sbyte var65 = 0;

                              for (int var59 = var6; var59 > 0; var59--) {
                                 var70 >>= 1;
                                 var65 <<= 1;
                                 if (var37 >= var70) {
                                    var37 -= var70;
                                    var65 |= 1;
                                 }

                                 if (var70 < 16777216L) {
                                    var70 <<= 8;
                                    var37 = var37 << 8 | (long)(gameByteArray10[gameIntegerValue144++] & 255);
                                 }
                              }

                              gameLongValue16 = var70;
                              gameLongValue17 = var37;
                              int var68;
                              var69 = (var68 = var69 + (var65 << 4)) + generateRandomMask(802, 4);
                           }
                        }

                        var69++;
                     }

                     int var46 = var45 + 2;

                     while (true) {
                        var12 = gameByteArray11[var17 - var69] & 255;
                        gameByteArray11[var17++] = (sbyte)var12;
                        if (--var46 <= 0 || var17 >= var7) {
                           break;
                        }
                     }
                  }
               }
            }

            gameShortArray04 = null;
            gameByteArray10 = null;
            JSystem.gc();
            gameIntegerValue140 += var40;
            var1 = gameByteArray11;
            gameByteArray11 = null;
         } catch (System.Exception var39) {
         }
      } else {
         readAssetBytes(var1 = new sbyte[var40], 0, var1.Length);
      }

      return var1;
   }

   // $VF: renamed from: Z () void
   public static void updateAssetLoadingState() {
      int var0;
      if (gameIntegerValue141 == gameShortValue18 - 1) {
         var0 = gameShortValue17 - gameShortArray03[gameIntegerValue141];
      } else {
         var0 = gameShortArray03[gameIntegerValue141 + 1] - gameShortArray03[gameIntegerValue141];
      }

      gameIntegerArray06 = new int[var0 + 1];

      for (int var1 = 0; var1 < var0 + 1; var1++) {
         gameIntegerArray06[var1] = readAssetByte() & 0xFF | (readAssetByte() & 0xFF) << 8 | (readAssetByte() & 0xFF) << 16 | (readAssetByte() & 0xFF) << 24;
      }
   }

   // $VF: renamed from: a (java.lang.String) void
   public static void openAssetStream(string var0) {
      gameIntegerValue138 = 1;
      bool var1 = false;
      object var2 = null;
      if (gameTextValue04 == null || var0 == null || var0.compareTo(gameTextValue04) != 0) {
         closeAssetStream();
         gameTextValue04 = var0;
         gameByteArray08 = null;
         gameIntegerValue139 = 0;
         gameInputStreamReference01 = getAssetStream(gameTextValue04);
         gameShortValue17 = (short)readAssetUnsignedShort();
         gameShortArray03 = new short[gameShortValue18 = (short)readAssetUnsignedShort()];

         for (int var4 = 0; var4 < gameShortValue18; var4++) {
            gameShortArray03[var4] = (short)readAssetUnsignedShort();
         }

         gameIntegerValue141 = 0;
         updateAssetLoadingState();
      }
   }

   // $VF: renamed from: a (java.lang.String) java.io.InputStream
   public static InputStream getAssetStream(string var0) {
      object var1 = null;
      if (gameIntegerValue138 == 3) {
         var1 = new ByteArrayInputStream(gameByteArray08, gameIntegerValue139, gameByteArray08.Length - gameIntegerValue139);
      } else if (gameIntegerValue138 != 2 && gameIntegerValue138 == 1) {
         var1 = "".getClass().getResourceAsStream(var0);
      }

      return (InputStream)var1;
   }

   // $VF: renamed from: aa () void
   public static void closeAssetStream() {
      closeCurrentAssetStream();
      if (gameIntegerValue138 == 3) {
         gameByteArray08 = null;
      }

      JSystem.gc();
   }

   // $VF: renamed from: ab () void
   public static void closeCurrentAssetStream() {
      if (gameInputStreamReference01 != null) {
         try {
            gameInputStreamReference01.close();
         } catch (System.Exception var0) {
         }

         gameInputStreamReference01 = null;
      }

      gameIntegerValue140 = 0;
   }

   // $VF: renamed from: d (int) int
   public static int getAssetSize(int var0) {
      int var1 = gameShortValue18 - 1;

      while (var1 >= 0 && gameShortArray03[var1] > var0) {
         var1--;
      }

      if (gameIntegerValue141 != var1) {
         gameIntegerValue141 = var1;
         closeAssetStream();
         if (gameIntegerValue141 == 0) {
            string var4 = gameTextValue04;
            gameTextValue04 = null;
            openAssetStream(var4);
         } else {
            gameInputStreamReference01 = getAssetStream(gameTextValue04 + "." + gameIntegerValue141);
            updateAssetLoadingState();
         }
      } else if (gameInputStreamReference01 == null) {
         if (gameIntegerValue141 == 0) {
            string var5 = gameTextValue04;
            gameTextValue04 = null;
            openAssetStream(var5);
         } else {
            gameInputStreamReference01 = getAssetStream(gameTextValue04 + "." + gameIntegerValue141);
         }
      }

      var0 -= gameShortArray03[gameIntegerValue141];
      var1 = gameIntegerArray06[var0];
      int var3 = gameIntegerArray06[var0 + 1] - gameIntegerArray06[var0];
      int var7 = var1;
      if (gameIntegerValue140 != var1) {
         if (gameIntegerValue140 > var1) {
            closeCurrentAssetStream();
            if (gameIntegerValue141 == 0) {
               gameInputStreamReference01 = getAssetStream(gameTextValue04);
            } else {
               gameInputStreamReference01 = getAssetStream(gameTextValue04 + "." + gameIntegerValue141);
            }
         } else {
            var7 = var1 - gameIntegerValue140;
         }

         selectAssetBank(var7);
      }

      gameBooleanFlag68 = false;
      if (var3 > 0) {
         if ((gameIntegerValue142 = readAssetByte() & 0xFF) >= 127) {
            gameIntegerValue142 -= 127;
            gameBooleanFlag68 = true;
         }

         var3--;
      }

      return var3;
   }

   // $VF: renamed from: t (int) void
   public static void selectAssetBank(int var0) {
      if (var0 != 0) {
         if (gameIntegerValue138 == 3) {
            gameIntegerValue140 += var0;

            try {
               while (var0 > 0) {
                  var0 = (int)((long)var0 - gameInputStreamReference01.skip((long)var0));
               }
            } catch (System.Exception var1) {
            }
         } else {
            if (gameByteArray09 == null) {
               gameByteArray09 = new sbyte[256];
            }

            while (var0 > 256) {
               readAssetBytes(gameByteArray09, 0, 256);
               var0 -= 256;
            }

            if (var0 > 0) {
               readAssetBytes(gameByteArray09, 0, var0);
            }
         }
      }
   }

   // $VF: renamed from: f () int
   public static int readAssetByte() {
      int var0 = 0;

      try {
         var0 = gameInputStreamReference01.read();
      } catch (System.Exception var1) {
      }

      gameIntegerValue140++;
      return var0;
   }

   // $VF: renamed from: g () int
   public static int readAssetUnsignedShort() {
      return readAssetByte() & 0xFF | (readAssetByte() & 0xFF) << 8;
   }

   // $VF: renamed from: a (byte[], int, int) int
   public static int readAssetBytes(sbyte[] var0, int var1, int var2) {
      int var6 = 0;
      int var3 = var2;

      try {
         while (var3 > 0) {
            int var4 = gameInputStreamReference01.read(var0, var6, var3);
            var3 -= var4;
            var6 += var4;
         }
      } catch (System.Exception var5) {
      }

      gameIntegerValue140 += var2;
      return var2;
   }

   // $VF: renamed from: a (int) java.lang.Object
   public static object readAssetObject(int var0) {
      getAssetSize(var0);
      gameIntegerValue145 = 0;
      object var2;
      if (gameBooleanFlag68) {
         sbyte[] var1 = loadAssetBytes(var0);
         var2 = readSerializedObject(new ByteArrayInputStream(var1));
      } else {
         var2 = readSerializedObject(gameInputStreamReference01);
         gameIntegerValue140 = gameIntegerValue140 + gameIntegerValue145;
      }

      return var2;
   }

   // $VF: renamed from: e (int) int
   public static int nextRandomValue(int var0) {
      long var1 = (gameLongValue16 >> 11) * (long)gameShortArray04[var0];
      if (gameLongValue17 < var1) {
         gameLongValue16 = var1;
         gameShortArray04[var0] = (short)(gameShortArray04[var0] + (2048 - gameShortArray04[var0] >> 5));
         if (gameLongValue16 < 16777216L) {
            gameLongValue17 = gameLongValue17 << 8 | (long)(gameByteArray10[gameIntegerValue144++] & 255);
            gameLongValue16 <<= 8;
         }

         return 0;
      } else {
         gameLongValue16 -= var1;
         gameLongValue17 -= var1;
         gameShortArray04[var0] = (short)(gameShortArray04[var0] - (gameShortArray04[var0] >> 5));
         if (gameLongValue16 < 16777216L) {
            gameLongValue17 = gameLongValue17 << 8 | (long)(gameByteArray10[gameIntegerValue144++] & 255);
            gameLongValue16 <<= 8;
         }

         return 1;
      }
   }

   // $VF: renamed from: h (int, int) int
   public static int generateRandomPowerOfTwo(int var0, int var1) {
      int var2 = 1;

      for (int var3 = var1; var3 > 0; var3--) {
         var2 = (var2 << 1) + nextRandomValue(var0 + var2);
      }

      return var2 - (1 << var1);
   }

   // $VF: renamed from: i (int, int) int
   public static int randomInRange(int var0, int var1) {
      if (nextRandomValue(var0) == 0) {
         return generateRandomPowerOfTwo(var0 + 2 + (var1 << 3), 3);
      } else {
         return nextRandomValue(var0 + 1) == 0 ? 8 + generateRandomPowerOfTwo(var0 + 130 + (var1 << 3), 3) : 16 + generateRandomPowerOfTwo(var0 + 258, 8);
      }
   }

   // $VF: renamed from: j (int, int) int
   public static int generateRandomMask(int var0, int var1) {
      int var2 = 1;
      int var3 = 0;

      for (int var5 = 0; var5 < var1; var5++) {
         int var4 = nextRandomValue(var0 + var2);
         var2 = (var2 << 1) + var4;
         var3 |= var4 << var5;
      }

      return var3;
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, int, int, int, int) void
   public static void clipGraphics(Graphics var0, int var1, int var2, int var3, int var4) {
      var0.clipRect(var1, var2, var3, var4);
   }

   // $VF: renamed from: b (javax.microedition.lcdui.Graphics, int, int, int, int) void
   public static void setGraphicsClip(Graphics var0, int var1, int var2, int var3, int var4) {
      var0.setClip(var1, var2, var3, var4);
   }

   // $VF: renamed from: c (javax.microedition.lcdui.Graphics, int, int, int, int) void
   public static void fillGraphicsRectangle(Graphics var0, int var1, int var2, int var3, int var4) {
      var0.fillRect(var1, var2, var3, var4);
   }

   // $VF: renamed from: b (int, int, int, int) void
   public static void drawGraphicsRectangle(int var0, int var1, int var2, int var3) {
      gameGraphicsReference02.drawRect(var0, var1, var2, var3);
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, int[], int, int, int, int, int, int, boolean, boolean, int) void
   public static void drawTransformedImage(Graphics var0, int[] var1, int var2, int var3, int var4, int var5, int var6, int var7, bool var8, bool var9, int var10) {
      if (var10 != 0) {
         if ((var10 & 4) != 0) {
            var3 = var6;
            var6 = var7;
            var7 = var3;
            var3 = var6;
         }

         var1 = SpriteResourceDecoder.transformColorArray(var1, var6, var7, var10);
      }

      int var9i = var0.getTranslateX();
      var10 = var0.getTranslateY();
      var0.translate(-var9i, -var10);
      var0.drawRGB(var1, var2, var3, var4 + var9i, var5 + var10, var6, var7, var8);
      var0.translate(var9i, var10);
   }

   // $VF: renamed from: a (byte[], int, short) int
   public static int writeShortBigEndian(sbyte[] var0, int var1, short var2) {
      var0[var1++] = (sbyte)var2;
      var0[var1++] = (sbyte)(JOps.Ushr(var2, 8));
      return var1;
   }

   // $VF: renamed from: a (byte[], int) short
   public static short readShortBigEndian(sbyte[] var0, int var1) {
      return (short)(var0[var1++] & 255 | (var0[var1] & 255) << 8);
   }

   // $VF: renamed from: a (java.io.InputStream) java.lang.Object
   public static object readSerializedObject(InputStream var0) {
      object var1 = null;

      try {
         int var2;
         int var3 = (var2 = readStreamByte(var0)) >> 4;
         int var4 = var2 & 7;
         if ((var2 & 8) != 0) {
            var2 = readStreamUnsignedShort(var0);
         } else {
            var2 = readStreamByte(var0);
         }

         switch (var4) {
            case 0:
               sbyte[] var18 = new sbyte[var2];

               for (int var13 = 0; var13 < var2; var13++) {
                  var18[var13] = (sbyte)readStreamByte(var0);
               }

               var1 = var18;
               break;
            case 1:
               short[] var17 = new short[var2];
               if (var3 == 0) {
                  for (int var12 = 0; var12 < var2; var12++) {
                     var17[var12] = (sbyte)readStreamByte(var0);
                  }
               } else {
                  for (int var11 = 0; var11 < var2; var11++) {
                     var17[var11] = (short)readStreamUnsignedShort(var0);
                  }
               }

               var1 = var17;
               break;
            case 2:
               int[] var16 = new int[var2];
               if (var3 == 0) {
                  for (int var10 = 0; var10 < var2; var10++) {
                     var16[var10] = (sbyte)readStreamByte(var0);
                  }
               } else if (var3 == 1) {
                  for (int var9 = 0; var9 < var2; var9++) {
                     var16[var9] = (short)readStreamUnsignedShort(var0);
                  }
               } else {
                  for (int var8 = 0; var8 < var2; var8++) {
                     var16[var8] = readStreamInteger(var0);
                  }
               }

               var1 = var16;
               break;
            default:
               object[] var15;
               switch (var4 = var4 & 3) {
                  case 0:
                     if (var3 == 2) {
                        var15 = (object[])(new sbyte[var2][]);
                     } else {
                        var15 = (object[])(new sbyte[var2][][]);
                     }
                     break;
                  case 1:
                     if (var3 == 2) {
                        var15 = (object[])(new short[var2][]);
                     } else {
                        var15 = (object[])(new short[var2][][]);
                     }
                     break;
                  default:
                     if (var3 == 2) {
                        var15 = (object[])(new int[var2][]);
                     } else {
                        var15 = (object[])(new int[var2][][]);
                     } break;
               }

               for (int var7 = 0; var7 < var2; var7++) {
                  var15[var7] = readSerializedObject(var0);
               }

               var1 = var15; break;
         }
      } catch (System.Exception var5) {
      }

      return var1;
   }

   // $VF: renamed from: a (java.io.InputStream) int
   public static int readStreamByte(InputStream var0) {
      int var1;
      if ((var1 = var0.read()) >= 0) {
         gameIntegerValue145++;
      }

      return var1;
   }

   // $VF: renamed from: b (java.io.InputStream) int
   public static int readStreamUnsignedShort(InputStream var0) {
      return readStreamByte(var0) & 0xFF | (readStreamByte(var0) & 0xFF) << 8;
   }

   // $VF: renamed from: c (java.io.InputStream) int
   public static int readStreamInteger(InputStream var0) {
      return readStreamByte(var0) & 0xFF | (readStreamByte(var0) & 0xFF) << 8 | (readStreamByte(var0) & 0xFF) << 16 | (readStreamByte(var0) & 0xFF) << 24;
   }

   // $VF: renamed from: a (java.io.InputStream, byte[], int, int) int
   public static int readStreamFully(InputStream var0, sbyte[] var1, int var2, int var3) {
      int var7 = 0;
      int var4 = var3;

      try {
         while (var4 > 0) {
            int var5 = var0.read(var1, var7, var4);
            var4 -= var5;
            var7 += var5;
         }
      } catch (System.Exception var6) {
      }

      gameIntegerValue145 += var3;
      return var3;
   }

   // $VF: renamed from: d (java.io.InputStream) int
   public static int loadResourceArchive(InputStream var0) {
      try {
         gameIntegerArray07 = new int[(gameIntegerValue146 = readStreamInteger(var0)) + 1];

         for (int var1 = 1; var1 < gameIntegerValue146 + 1; var1++) {
            gameIntegerArray07[var1] = readStreamInteger(var0);
         }

         gameByteArray12 = new sbyte[gameIntegerArray07[gameIntegerValue146]];
         readStreamFully(var0, gameByteArray12, 0, gameByteArray12.Length);
      } catch (System.Exception var2) {
      }

      return gameByteArray12.Length + (gameIntegerValue146 + 1 << 2);
   }

   // $VF: renamed from: b (int) java.lang.String
   public static string getStringResource(int var0) {
      if (gameTextArray02 != null) {
         return gameTextArray02[var0];
      } else {
         try {
            int var1;
            return (var1 = gameIntegerArray07[var0 + 1] - gameIntegerArray07[var0]) == 0 ? null : JString.New(gameByteArray12, gameIntegerArray07[var0], var1, gameTextValue05);
         } catch (System.Exception var2) {
            return null;
         }
      }
   }

   // $VF: renamed from: ac () void
   public static void loadStringResources() {
      string[] var0 = new string[gameIntegerValue146];

      for (int var1 = 0; var1 < gameIntegerValue146; var1++) {
         var0[var1] = getStringResource(var1);
      }

      gameTextArray02 = var0;
      gameIntegerArray07 = null;
      gameByteArray12 = null;
      JSystem.gc();
   }

   // $VF: renamed from: ad () void
   public static void initializeStringResources() {
      if (gameTextArray02 != null) {
         for (int var0 = 0; var0 < gameIntegerValue146; var0++) {
            gameTextArray02[var0] = null;
         }

         gameTextArray02 = null;
      }

      gameIntegerArray07 = null;
      gameByteArray12 = null;
      gameIntegerValue146 = 0;
   }

   // $VF: renamed from: a (java.lang.String, java.lang.String[]) java.lang.String
   public static string formatLocalizedString(string var0, string[] var1) {
      string var5 = "";
      if (var0.indexOf(37) < 0) {
         return var0;
      } else {
         int var3 = 0;
         int var6 = 0;

         do {
            if ((var6 = var0.indexOf(37, var6)) < 0 || var6 == var0.length() - 1) {
               var5 = var5 + var0.substring(var3);
               var6 = -1;
            } else if (var0.charAt(var6 + 1) == 's') {
               int var4 = -1;
               if (var6 + 2 < var0.length()) {
                  var4 = var0.charAt(var6 + 2) - '0';
               }

               if (var4 >= 0 && var4 <= 9) {
                  var5 = var5 + var0.substring(var3, var6);
                  var5 = var5 + var1[var4];
                  var6 = var3 = var6 + 3;
               } else {
                  var6++;
               }
            } else {
               var6++;
            }
         } while (var6 >= 0);

         return var5;
      }
   }

   // $VF: renamed from: ae () void
   public static void closeRecordStore() {
      if (gameRecordStoreReference01 != null) {
         try {
            gameRecordStoreReference01.closeRecordStore();
         } catch (RecordStoreException var0) {
         }

         gameRecordStoreReference01 = null;
      }
   }

   // $VF: renamed from: b (java.lang.String) void
   public static void openRecordStore(string var0) {
      gameRecordStoreReference01 = RecordStore.openRecordStore(var0, true);
   }

   // $VF: renamed from: a (java.lang.String) byte[]
   public static sbyte[] readRecordStoreData(string var0) {
      sbyte[] var1 = null;

      try {
         openRecordStore(var0);
         if (gameRecordStoreReference01.getNumRecords() > 0) {
            var1 = gameRecordStoreReference01.getRecord(1);
         }
      } catch (RecordStoreException var2) {
         new StringBuffer().append("ERROR! Failed reading from RMS: ").append(var2);
         var1 = null;
      }

      closeRecordStore();
      return var1;
   }

   // $VF: renamed from: a (java.lang.String, byte[], int, int) void
   public static void writeRecordStoreData(string var0, sbyte[] var1, int var2, int var3) {
      try {
         openRecordStore(var0);
         if (gameRecordStoreReference01.getNumRecords() > 0) {
            gameRecordStoreReference01.setRecord(1, var1, 0, var3);
         } else {
            gameRecordStoreReference01.addRecord(var1, 0, var3);
         }
      } catch (RecordStoreException var4) {
      }

      closeRecordStore();
   }

   // $VF: renamed from: i (int) void
   public static void setScreenSize(int var0) {
      if (var0 != gameIntegerValue147 || gameIntegerArray08 == null) {
         gameIntegerValue147 = var0;
         if (gameIntegerArray08 == null) {
            gameIntegerArray08 = new int[256];
         }

         for (int var1 = 256; var1 > 0; gameIntegerArray08[var1] = var0) {
            var1--;
         }
      }
   }

   // $VF: renamed from: d (javax.microedition.lcdui.Graphics, int, int, int, int) void
   public static void copyGraphicsRegion(Graphics var0, int var1, int var2, int var3, int var4) {
      int var5 = var0.getClipX();
      int var6 = var0.getClipY();
      int var7 = var0.getClipWidth();
      int var8 = var0.getClipHeight();
      int var9 = var1 > var5 ? var1 : var5;
      int var10 = var2 > var6 ? var2 : var6;
      int var17 = (var1 + var3 < var5 + var7 ? var1 + var3 : var5 + var7) - var9;
      int var19 = (var2 + var4 < var6 + var8 ? var2 + var4 : var6 + var8) - var10;
      if (var17 > 0 && var19 > 0) {
         setGraphicsClip(var0, var9, var10, var17, var19);
         if (var17 * var19 < 256) {
            int[] var15 = gameIntegerArray08;
            drawTransformedImage(var0, var15, 0, var17, var9, var10, var17, var19, true, true, 0);
         } else {
            var3 = var17 + var9;
            var4 = var19 + var10;

            for (int var14 = var9; var14 < var3; var14 += 16) {
               for (int var16 = var10; var16 < var4; var16 += 16) {
                  int[] var11 = gameIntegerArray08;
                  drawTransformedImage(var0, var11, 0, 16, var14, var16, 16, 16, true, true, 0);
               }
            }
         }

         setGraphicsClip(var0, var5, var6, var7, var8);
      }
   }
}
}
