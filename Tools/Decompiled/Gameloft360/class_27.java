import java.io.ByteArrayInputStream;
import java.io.InputStream;
import java.util.Hashtable;
import java.util.Random;
import java.util.Vector;
import javax.microedition.lcdui.Canvas;
import javax.microedition.lcdui.Display;
import javax.microedition.lcdui.Font;
import javax.microedition.lcdui.Graphics;
import javax.microedition.lcdui.Image;
import javax.microedition.media.Manager;
import javax.microedition.media.Player;
import javax.microedition.midlet.MIDlet;
import javax.microedition.rms.RecordStore;
import javax.microedition.rms.RecordStoreException;

// $VF: renamed from: f
public final class class_27 extends Canvas implements class_0, Runnable {
   // $VF: renamed from: s int
   private int field_465;
   // $VF: renamed from: t int
   private int field_466;
   // $VF: renamed from: u int
   private int field_467;
   // $VF: renamed from: v int
   private int field_468;
   // $VF: renamed from: w int
   private int field_469;
   // $VF: renamed from: A boolean
   private boolean field_470;
   // $VF: renamed from: B boolean
   private boolean field_471;
   // $VF: renamed from: a boolean
   boolean field_472;
   // $VF: renamed from: a java.lang.String
   private String field_473;
   // $VF: renamed from: C boolean
   private static boolean field_474 = false;
   // $VF: renamed from: D boolean
   private static boolean field_475 = false;
   // $VF: renamed from: E boolean
   private static boolean field_476 = true;
   // $VF: renamed from: F boolean
   private static boolean field_477 = true;
   // $VF: renamed from: d int[]
   private static int[] field_478;
   // $VF: renamed from: x int
   private static int field_479;
   // $VF: renamed from: y int
   private static int field_480;
   // $VF: renamed from: z int
   private static int field_481;
   // $VF: renamed from: A int
   private static int field_482;
   // $VF: renamed from: B int
   private static int field_483;
   // $VF: renamed from: C int
   private static int field_484;
   // $VF: renamed from: D int
   private static int field_485;
   // $VF: renamed from: E int
   private static int field_486;
   // $VF: renamed from: F int
   private static int field_487;
   // $VF: renamed from: G int
   private static int field_488;
   // $VF: renamed from: H int
   private static int field_489;
   // $VF: renamed from: I int
   private static int field_490 = 0;
   // $VF: renamed from: J int
   private static int field_491 = -1;
   // $VF: renamed from: K int
   private static int field_492 = -1;
   // $VF: renamed from: L int
   private static int field_493 = 1;
   // $VF: renamed from: G boolean
   private static boolean field_494 = false;
   // $VF: renamed from: H boolean
   private static boolean field_495 = false;
   // $VF: renamed from: M int
   private static int field_496 = 0;
   // $VF: renamed from: N int
   private static int field_497 = 0;
   // $VF: renamed from: O int
   private static int field_498 = -1;
   // $VF: renamed from: P int
   private static int field_499 = 0;
   // $VF: renamed from: Q int
   private static int field_500 = -1;
   // $VF: renamed from: R int
   private static int field_501 = -1;
   // $VF: renamed from: a javax.microedition.media.Player[]
   private static Player[] field_502;
   // $VF: renamed from: a java.io.ByteArrayInputStream[]
   private static ByteArrayInputStream[] field_503;
   // $VF: renamed from: c java.lang.String[]
   private static String[] field_504;
   // $VF: renamed from: a javax.microedition.media.Player
   private static Player field_505;
   // $VF: renamed from: c long
   private static long field_506;
   // $VF: renamed from: S int
   private static int field_507 = 0;
   // $VF: renamed from: b java.lang.String
   private static String field_508;
   // $VF: renamed from: a short[]
   private static short[] field_509;
   // $VF: renamed from: I boolean
   private static boolean field_510 = false;
   // $VF: renamed from: J boolean
   private static boolean field_511 = false;
   // $VF: renamed from: d long
   private static long field_512 = 0L;
   // $VF: renamed from: K boolean
   private static boolean field_513 = false;
   // $VF: renamed from: L boolean
   private static boolean field_514 = false;
   // $VF: renamed from: M boolean
   private static boolean field_515 = false;
   // $VF: renamed from: N boolean
   private static boolean field_516 = false;
   // $VF: renamed from: O boolean
   private static boolean field_517 = false;
   // $VF: renamed from: P boolean
   private static boolean field_518 = false;
   // $VF: renamed from: T int
   private static int field_519 = -1;
   // $VF: renamed from: e long
   private static long field_520 = -1L;
   // $VF: renamed from: Q boolean
   private static boolean field_521 = false;
   // $VF: renamed from: R boolean
   private static boolean field_522 = false;
   // $VF: renamed from: U int
   private static int field_523 = 0;
   // $VF: renamed from: V int
   private static int field_524 = 0;
   // $VF: renamed from: a java.util.Vector
   private static Vector field_525 = new Vector(10);
   // $VF: renamed from: b java.util.Vector
   private static Vector field_526 = new Vector(2);
   // $VF: renamed from: a y
   static class_8 field_527 = null;
   // $VF: renamed from: b y
   private static class_8 field_528 = null;
   // $VF: renamed from: W int
   private static int field_529;
   // $VF: renamed from: X int
   private static int field_530;
   // $VF: renamed from: S boolean
   private static boolean field_531;
   // $VF: renamed from: f long
   private static long field_532 = 0L;
   // $VF: renamed from: T boolean
   private static boolean field_533 = false;
   // $VF: renamed from: Y int
   private int field_534;
   // $VF: renamed from: b boolean
   static boolean field_535;
   // $VF: renamed from: Z int
   private static int field_536;
   // $VF: renamed from: aa int
   private static int field_537;
   // $VF: renamed from: ab int
   private static int field_538;
   // $VF: renamed from: ac int
   private static int field_539 = field_538 = 40 * class_27.field_793 / 240;
   // $VF: renamed from: ad int
   private static int field_540 = 40 * class_27.field_793 / 240;
   // $VF: renamed from: a byte[][][]
   private static byte[][][] field_541 = null;
   // $VF: renamed from: e int[][]
   private static int[][] field_542 = null;
   // $VF: renamed from: c int[]
   public static final int[] field_543 = new int[]{1, 2, 3, 4, 5, 6};
   // $VF: renamed from: a g[]
   private static class_21[] field_544 = new class_21[3];
   // $VF: renamed from: b g[]
   private static class_21[] field_545 = new class_21[12];
   // $VF: renamed from: c g[]
   private static class_21[] field_546 = new class_21[2];
   // $VF: renamed from: d g[]
   private static class_21[] field_547 = new class_21[11];
   // $VF: renamed from: e g[]
   private static class_21[] field_548 = new class_21[5];
   // $VF: renamed from: f g[]
   private static class_21[] field_549 = new class_21[5];
   // $VF: renamed from: g g[]
   private static class_21[] field_550 = new class_21[4];
   // $VF: renamed from: h g[]
   private static class_21[] field_551 = new class_21[2];
   // $VF: renamed from: a g
   private static class_21 field_552;
   // $VF: renamed from: a v
   private static class_11 field_553 = null;
   // $VF: renamed from: c boolean
   public static boolean field_554 = false;
   // $VF: renamed from: b v
   private static class_11 field_555 = null;
   // $VF: renamed from: i g[]
   private static class_21[] field_556 = new class_21[2];
   // $VF: renamed from: c v
   private static class_11 field_557 = null;
   // $VF: renamed from: d boolean
   public static boolean field_558 = false;
   // $VF: renamed from: U boolean
   private static boolean field_559 = false;
   // $VF: renamed from: a javax.microedition.lcdui.Image
   private static Image field_560 = null;
   // $VF: renamed from: ae int
   private static int field_561 = 0;
   // $VF: renamed from: g long
   private static long field_562 = 0L;
   // $VF: renamed from: V boolean
   private static boolean field_563 = false;
   // $VF: renamed from: af int
   private static int field_564 = 0;
   // $VF: renamed from: W boolean
   private static boolean field_565 = false;
   // $VF: renamed from: a GloftRESE
   private static GloftRESE field_566;
   // $VF: renamed from: b javax.microedition.lcdui.Graphics
   private Graphics field_567;
   // $VF: renamed from: ag int
   private static int field_568;
   // $VF: renamed from: ah int
   private static int field_569;
   // $VF: renamed from: c int
   static int field_570;
   // $VF: renamed from: d int
   static int field_571;
   // $VF: renamed from: ai int
   private static int field_572;
   // $VF: renamed from: X boolean
   private boolean field_573;
   // $VF: renamed from: a long
   long field_574;
   // $VF: renamed from: aj int
   private int field_575;
   // $VF: renamed from: ak int
   private int field_576;
   // $VF: renamed from: a java.util.Random
   private Random field_577;
   // $VF: renamed from: p byte
   private byte field_578;
   // $VF: renamed from: q byte
   private byte field_579;
   // $VF: renamed from: Y boolean
   private static boolean field_580;
   // $VF: renamed from: Z boolean
   private boolean field_581;
   // $VF: renamed from: aa boolean
   private boolean field_582;
   // $VF: renamed from: ab boolean
   private boolean field_583;
   // $VF: renamed from: ac boolean
   private boolean field_584;
   // $VF: renamed from: e boolean
   boolean field_585;
   // $VF: renamed from: f boolean
   boolean field_586;
   // $VF: renamed from: a aa
   class_26 field_587;
   // $VF: renamed from: b aa
   class_26 field_588;
   // $VF: renamed from: c aa
   class_26 field_589;
   // $VF: renamed from: d aa
   class_26 field_590;
   // $VF: renamed from: a byte
   byte field_591;
   // $VF: renamed from: al int
   private static int field_592;
   // $VF: renamed from: am int
   private int field_593;
   // $VF: renamed from: e int
   public static int field_594;
   // $VF: renamed from: an int
   private int field_595;
   // $VF: renamed from: ao int
   private int field_596;
   // $VF: renamed from: ap int
   private int field_597;
   // $VF: renamed from: aq int
   private int field_598;
   // $VF: renamed from: ar int
   private int field_599;
   // $VF: renamed from: as int
   private int field_600;
   // $VF: renamed from: at int
   private int field_601;
   // $VF: renamed from: au int
   private int field_602;
   // $VF: renamed from: av int
   private int field_603;
   // $VF: renamed from: aw int
   private int field_604;
   // $VF: renamed from: ax int
   private int field_605;
   // $VF: renamed from: ay int
   private int field_606;
   // $VF: renamed from: b byte
   byte field_607;
   // $VF: renamed from: a boolean[]
   private boolean[] field_608;
   // $VF: renamed from: c byte
   byte field_609;
   // $VF: renamed from: r byte
   private byte field_610;
   // $VF: renamed from: a h[]
   class_20[] field_611;
   // $VF: renamed from: az int
   private int field_612;
   // $VF: renamed from: f int
   int field_613;
   // $VF: renamed from: g int
   int field_614;
   // $VF: renamed from: h long
   private long field_615;
   // $VF: renamed from: h int
   public int field_616;
   // $VF: renamed from: a short
   public static short field_617;
   // $VF: renamed from: d byte
   public static byte field_618;
   // $VF: renamed from: b long
   public long field_619;
   // $VF: renamed from: a p[]
   class_15[] field_620;
   // $VF: renamed from: a p
   class_15 field_621;
   // $VF: renamed from: b p
   class_15 field_622;
   // $VF: renamed from: c p
   class_15 field_623;
   // $VF: renamed from: d p
   class_15 field_624;
   // $VF: renamed from: e p
   class_15 field_625;
   // $VF: renamed from: f p
   class_15 field_626;
   // $VF: renamed from: g p
   private class_15 field_627;
   // $VF: renamed from: a ab[]
   class_25[] field_628;
   // $VF: renamed from: a e[]
   class_22[] field_629;
   // $VF: renamed from: b short[]
   private short[] field_630;
   // $VF: renamed from: e byte[]
   private byte[] field_631;
   // $VF: renamed from: b short
   private short field_632;
   // $VF: renamed from: aA int
   private static int field_633;
   // $VF: renamed from: s byte
   private byte field_634;
   // $VF: renamed from: c java.lang.String
   private String field_635;
   // $VF: renamed from: c short
   private short field_636;
   // $VF: renamed from: aB int
   private int field_637;
   // $VF: renamed from: aC int
   private int field_638;
   // $VF: renamed from: d short
   private short field_639;
   // $VF: renamed from: e short
   private short field_640;
   // $VF: renamed from: a x[]
   class_9[] field_641;
   // $VF: renamed from: aD int
   private static int field_642;
   // $VF: renamed from: aE int
   private static int field_643;
   // $VF: renamed from: aF int
   private static int field_644;
   // $VF: renamed from: aG int
   private static int field_645;
   // $VF: renamed from: aH int
   private static int field_646;
   // $VF: renamed from: aI int
   private static int field_647;
   // $VF: renamed from: aJ int
   private static int field_648;
   // $VF: renamed from: aK int
   private static int field_649;
   // $VF: renamed from: aL int
   private static int field_650;
   // $VF: renamed from: aM int
   private static int field_651;
   // $VF: renamed from: aN int
   private static int field_652;
   // $VF: renamed from: e int[]
   private int[] field_653;
   // $VF: renamed from: f short
   private short field_654;
   // $VF: renamed from: g short
   private short field_655;
   // $VF: renamed from: h short
   private short field_656;
   // $VF: renamed from: a i[]
   class_19[] field_657;
   // $VF: renamed from: t byte
   private byte field_658;
   // $VF: renamed from: e byte
   static byte field_659;
   // $VF: renamed from: u byte
   private static byte field_660;
   // $VF: renamed from: b i[]
   class_19[] field_661;
   // $VF: renamed from: a i
   private class_19 field_662;
   // $VF: renamed from: i short
   private short field_663;
   // $VF: renamed from: f byte[]
   private byte[] field_664;
   // $VF: renamed from: i long
   private long field_665;
   // $VF: renamed from: j long
   private long field_666;
   // $VF: renamed from: k long
   private long field_667;
   // $VF: renamed from: v byte
   private byte field_668;
   // $VF: renamed from: w byte
   private byte field_669;
   // $VF: renamed from: b byte[][]
   private byte[][] field_670;
   // $VF: renamed from: b short[][]
   private short[][] field_671;
   // $VF: renamed from: a short[][]
   short[][] field_672;
   // $VF: renamed from: a byte[][]
   byte[][] field_673;
   // $VF: renamed from: b boolean[]
   private boolean[] field_674;
   // $VF: renamed from: g boolean
   boolean field_675;
   // $VF: renamed from: j short
   private short field_676;
   // $VF: renamed from: k short
   private short field_677;
   // $VF: renamed from: l short
   private short field_678;
   // $VF: renamed from: m short
   private short field_679;
   // $VF: renamed from: f byte
   byte field_680;
   // $VF: renamed from: c byte[][]
   private byte[][] field_681;
   // $VF: renamed from: d byte[][]
   private byte[][] field_682;
   // $VF: renamed from: a r[]
   private class_14[] field_683;
   // $VF: renamed from: a r
   class_14 field_684;
   // $VF: renamed from: aO int
   private int field_685;
   // $VF: renamed from: aP int
   private int field_686;
   // $VF: renamed from: g byte[]
   private byte[] field_687;
   // $VF: renamed from: a java.lang.StringBuffer
   StringBuffer field_688;
   // $VF: renamed from: h byte[]
   private byte[] field_689;
   // $VF: renamed from: c short[][]
   private short[][] field_690;
   // $VF: renamed from: h boolean
   boolean field_691;
   // $VF: renamed from: x byte
   private byte field_692;
   // $VF: renamed from: i int
   int field_693;
   // $VF: renamed from: n short
   private short field_694;
   // $VF: renamed from: aQ int
   private int field_695;
   // $VF: renamed from: aR int
   private int field_696;
   // $VF: renamed from: aS int
   private int field_697;
   // $VF: renamed from: aT int
   private int field_698;
   // $VF: renamed from: aU int
   private int field_699;
   // $VF: renamed from: aV int
   private int field_700;
   // $VF: renamed from: i boolean
   boolean field_701;
   // $VF: renamed from: ad boolean
   private boolean field_702;
   // $VF: renamed from: j boolean
   boolean field_703;
   // $VF: renamed from: k boolean
   boolean field_704;
   // $VF: renamed from: ae boolean
   private boolean field_705;
   // $VF: renamed from: j int
   int field_706;
   // $VF: renamed from: aW int
   private int field_707;
   // $VF: renamed from: aX int
   private int field_708;
   // $VF: renamed from: d byte[]
   byte[] field_709;
   // $VF: renamed from: l boolean
   boolean field_710;
   // $VF: renamed from: m boolean
   boolean field_711;
   // $VF: renamed from: af boolean
   private boolean field_712;
   // $VF: renamed from: n boolean
   boolean field_713;
   // $VF: renamed from: o boolean
   boolean field_714;
   // $VF: renamed from: p boolean
   boolean field_715;
   // $VF: renamed from: g byte
   byte field_716;
   // $VF: renamed from: h byte
   byte field_717;
   // $VF: renamed from: i byte
   byte field_718;
   // $VF: renamed from: j byte
   byte field_719;
   // $VF: renamed from: k byte
   byte field_720;
   // $VF: renamed from: y byte
   private byte field_721;
   // $VF: renamed from: l byte
   byte field_722;
   // $VF: renamed from: m byte
   byte field_723;
   // $VF: renamed from: n byte
   byte field_724;
   // $VF: renamed from: o byte
   byte field_725;
   // $VF: renamed from: k int
   int field_726;
   // $VF: renamed from: l int
   int field_727;
   // $VF: renamed from: m int
   int field_728;
   // $VF: renamed from: z byte
   private byte field_729;
   // $VF: renamed from: A byte
   private byte field_730;
   // $VF: renamed from: B byte
   private byte field_731;
   // $VF: renamed from: q boolean
   boolean field_732;
   // $VF: renamed from: o short
   private short field_733;
   // $VF: renamed from: p short
   private short field_734;
   // $VF: renamed from: aY int
   private int field_735;
   // $VF: renamed from: aZ int
   private int field_736;
   // $VF: renamed from: ba int
   private int field_737;
   // $VF: renamed from: bb int
   private int field_738;
   // $VF: renamed from: bc int
   private int field_739;
   // $VF: renamed from: bd int
   private int field_740;
   // $VF: renamed from: be int
   private int field_741;
   // $VF: renamed from: l long
   private long field_742;
   // $VF: renamed from: a l
   private static class_18 field_743;
   // $VF: renamed from: a t
   private static class_12 field_744;
   // $VF: renamed from: a w
   private static class_10 field_745;
   // $VF: renamed from: r boolean
   static boolean field_746 = false;
   // $VF: renamed from: s boolean
   static boolean field_747 = false;
   // $VF: renamed from: ag boolean
   private static boolean field_748 = false;
   // $VF: renamed from: t boolean
   static boolean field_749 = false;
   // $VF: renamed from: ah boolean
   private boolean field_750;
   // $VF: renamed from: bf int
   private static int field_751 = -1;
   // $VF: renamed from: ai boolean
   private static boolean field_752 = false;
   // $VF: renamed from: bg int
   private int field_753;
   // $VF: renamed from: bh int
   private int field_754;
   // $VF: renamed from: bi int
   private int field_755;
   // $VF: renamed from: bj int
   private int field_756;
   // $VF: renamed from: bk int
   private int field_757;
   // $VF: renamed from: bl int
   private int field_758;
   // $VF: renamed from: bm int
   private int field_759;
   // $VF: renamed from: bn int
   private int field_760;
   // $VF: renamed from: bo int
   private int field_761;
   // $VF: renamed from: bp int
   private int field_762;
   // $VF: renamed from: f int[]
   private int[] field_763;
   // $VF: renamed from: aj boolean
   private boolean field_764;
   // $VF: renamed from: bq int
   private int field_765;
   // $VF: renamed from: br int
   private int field_766;
   // $VF: renamed from: bs int
   private int field_767;
   // $VF: renamed from: ak boolean
   private boolean field_768;
   // $VF: renamed from: b g
   private static class_21 field_769 = null;
   // $VF: renamed from: bt int
   private static int field_770;
   // $VF: renamed from: bu int
   private static int field_771 = -1;
   // $VF: renamed from: bv int
   private static int field_772 = -1;
   // $VF: renamed from: bw int
   private static int field_773 = 0;
   // $VF: renamed from: bx int
   private static int field_774 = 0;
   // $VF: renamed from: g int[]
   private static int[] field_775 = new int[5];
   // $VF: renamed from: by int
   private int field_776;
   // $VF: renamed from: d v
   private static class_11 field_777;
   // $VF: renamed from: al boolean
   private static boolean field_778 = false;
   // $VF: renamed from: bz int
   private static int field_779;
   // $VF: renamed from: u boolean
   static boolean field_780 = false;
   // $VF: renamed from: v boolean
   static boolean field_781 = false;
   // $VF: renamed from: w boolean
   static boolean field_782 = false;
   // $VF: renamed from: x boolean
   static boolean field_783 = false;
   // $VF: renamed from: am boolean
   private static boolean field_784 = false;
   // $VF: renamed from: n int
   static int field_785 = -1;
   // $VF: renamed from: bA int
   private static int field_786 = 0;
   // $VF: renamed from: an boolean
   private static boolean field_787 = false;
   // $VF: renamed from: a javax.microedition.lcdui.Graphics
   public static Graphics field_788 = null;
   // $VF: renamed from: c javax.microedition.lcdui.Graphics
   private static Graphics field_789 = null;
   // $VF: renamed from: y boolean
   static boolean field_790;
   // $VF: renamed from: o int
   static int field_791;
   // $VF: renamed from: m long
   private static long field_792;
   // $VF: renamed from: p int
   static int field_793 = 360;
   // $VF: renamed from: q int
   static int field_794 = 640;
   // $VF: renamed from: a javax.microedition.lcdui.Display
   static Display field_795;
   // $VF: renamed from: ao boolean
   private static boolean field_796;
   // $VF: renamed from: a javax.microedition.midlet.MIDlet
   private static MIDlet field_797;
   // $VF: renamed from: bB int
   private static int field_798 = 28;
   // $VF: renamed from: n long
   private long field_799;
   // $VF: renamed from: bC int
   private static int field_800 = -1;
   // $VF: renamed from: b javax.microedition.lcdui.Image
   private static Image field_801 = null;
   // $VF: renamed from: d javax.microedition.lcdui.Graphics
   private static Graphics field_802 = null;
   // $VF: renamed from: ap boolean
   private static boolean field_803 = true;
   // $VF: renamed from: bD int
   private static int field_804;
   // $VF: renamed from: o long
   private static long field_805;
   // $VF: renamed from: bE int
   private static int field_806;
   // $VF: renamed from: bF int
   private static int field_807;
   // $VF: renamed from: a f
   static class_27 field_808;
   // $VF: renamed from: i byte[]
   private static byte[] field_809;
   // $VF: renamed from: j byte[]
   private static byte[] field_810;
   // $VF: renamed from: bG int
   private static int field_811 = -9999;
   // $VF: renamed from: bH int
   private static int field_812;
   // $VF: renamed from: a java.util.Hashtable
   private static Hashtable field_813;
   // $VF: renamed from: b java.util.Hashtable
   private static Hashtable field_814;
   // $VF: renamed from: bI int
   private static int field_815 = 24;
   // $VF: renamed from: bJ int
   private static int field_816 = 256;
   // $VF: renamed from: b java.util.Random
   private static Random field_817;
   // $VF: renamed from: bK int
   private static int field_818 = 256;
   // $VF: renamed from: bL int
   private static int field_819 = 804;
   // $VF: renamed from: d java.lang.String
   private static String field_820;
   // $VF: renamed from: a java.io.InputStream
   private static InputStream field_821;
   // $VF: renamed from: bM int
   private static int field_822;
   // $VF: renamed from: k byte[]
   private static byte[] field_823;
   // $VF: renamed from: bN int
   private static int field_824;
   // $VF: renamed from: bO int
   private static int field_825;
   // $VF: renamed from: q short
   private static short field_826;
   // $VF: renamed from: h int[]
   private static int[] field_827;
   // $VF: renamed from: r short
   private static short field_828;
   // $VF: renamed from: c short[]
   private static short[] field_829;
   // $VF: renamed from: bP int
   private static int field_830;
   // $VF: renamed from: bQ int
   private static int field_831;
   // $VF: renamed from: aq boolean
   private static boolean field_832;
   // $VF: renamed from: l byte[]
   private static byte[] field_833;
   // $VF: renamed from: e byte[][]
   private static byte[][] field_834;
   // $VF: renamed from: m byte[]
   private static byte[] field_835;
   // $VF: renamed from: bR int
   private static int field_836;
   // $VF: renamed from: p long
   private static long field_837;
   // $VF: renamed from: q long
   private static long field_838;
   // $VF: renamed from: n byte[]
   private static byte[] field_839;
   // $VF: renamed from: bS int
   private static int field_840;
   // $VF: renamed from: d short[]
   private static short[] field_841;
   // $VF: renamed from: bT int
   private static int field_842 = 0;
   // $VF: renamed from: bU int
   private static int field_843;
   // $VF: renamed from: e java.lang.String
   private static String field_844 = "UTF-8";
   // $VF: renamed from: o byte[]
   private static byte[] field_845;
   // $VF: renamed from: i int[]
   private static int[] field_846;
   // $VF: renamed from: d java.lang.String[]
   private static String[] field_847;
   // $VF: renamed from: a javax.microedition.rms.RecordStore
   private static RecordStore field_848;
   // $VF: renamed from: bV int
   private static int field_849;
   // $VF: renamed from: j int[]
   private static int[] field_850;
   // $VF: renamed from: ar boolean
   private static boolean field_851 = false;
   // $VF: renamed from: z boolean
   static final boolean field_852 = false;
   // $VF: renamed from: as boolean
   private static boolean field_853 = false;
   // $VF: renamed from: r int
   static int field_854 = 0;
   // $VF: renamed from: d int[][]
   static int[][] field_855 = null;
   // $VF: renamed from: c javax.microedition.lcdui.Image
   private static Image field_856 = null;
   // $VF: renamed from: e javax.microedition.lcdui.Graphics
   private static Graphics field_857 = null;
   // $VF: renamed from: bW int
   private static int field_858 = 0;
   // $VF: renamed from: bX int
   private static int field_859 = 0;

   // $VF: renamed from: q () void
   private void method_128() {
      if (this.field_593 != 127) {
         switch (this.field_593) {
            case 1:
               method_334("/3");
               field_544[2] = method_313(2, true, true);
               field_544[0] = method_313(0, true, true);
               method_336();
               if (!method_178("options.dat", this.field_687)) {
                  this.method_184();
               } else {
                  field_474 = this.field_687[1] == 1;
                  boolean var15 = true;
               }

               this.method_136(0);
               break;
            case 2:
               field_554 = false;
               field_544[2] = null;
               field_544[0] = null;
               this.field_620 = new class_15[25];
               this.field_620[0] = this.field_589.field_452;
               this.field_620[1] = this.field_590.field_452;

               for (int var1 = 2; var1 < 25; var1++) {
                  this.field_620[var1] = new class_15(this);
                  this.field_620[var1].field_130 = false;
               }

               this.field_630 = new short[150];
               this.field_631 = new byte[150];
               this.field_585 = false;
               this.field_587.field_459 = false;
               this.field_587.field_460 = false;
               this.field_587.field_461 = false;
               class_27 var7 = this;
               byte[] var9 = method_217("/7", 1);
               class_23 var4;
               byte var5 = (var4 = new class_23(var9)).method_124();
               this.field_589.field_453 = var5;
               this.field_589.field_454 = new class_13[var5];
               this.field_590.field_453 = var5;
               this.field_590.field_454 = new class_13[var5];

               for (int var10 = 0; var10 < var5; var10++) {
                  class_13 var6 = new class_13(var7);
                  short var3 = var4.method_125();
                  var4.method_127(var3);
                  var6.field_119 = 367 + var10 * 3;
                  var3 = var4.method_125();
                  var4.method_127(var3);
                  var6.field_118 = var4.method_124();
                  var6.field_120 = var4.method_124();
                  var6.field_121 = var4.method_126();
                  var6.field_122 = 0;
                  var6.field_123 = null;
                  var7.field_589.field_454[var10] = var6;
                  var7.field_590.field_454[var10] = new class_13(var7, var6);
               }

               boolean var10000 = true;
               this.method_197(0, 29, 47, 3);
               this.method_197(1, 30, 47, 3);
               this.field_683 = new class_14[150];

               for (int var8 = 0; var8 < 150; var8++) {
                  this.field_683[var8] = new class_14(this);
               }

               this.field_693 = 0;
               this.field_706 = 0;
               this.field_616 = 0;
               this.field_585 = false;
               this.field_589.field_463 = false;
               this.field_590.field_463 = false;
               boolean var11 = false;
               byte var12 = this.field_607;
               this.method_216();
               this.field_607 = (byte)var12;
               this.method_219();
               if (!this.field_608[this.field_607]) {
                  this.method_221();
               }

               boolean var13;
               if (var13 = false & this.field_608[this.field_607]) {
                  this.method_181(true);
               }

               this.field_608[this.field_607] = true;
               if (this.field_607 == 0 && this.field_586) {
                  this.field_672[this.field_641[545].field_76][this.field_641[545].field_77] = -1;
               }

               this.field_587.field_462 = this.field_607;
               if (this.field_588.field_462 != this.field_607) {
                  this.field_588.field_452.field_130 = false;
               } else {
                  this.field_588.field_452.field_130 = true;
               }

               this.method_266();
               if (this.field_750) {
                  this.method_214(true);
                  this.field_750 = false;
               }

               this.method_223();
               this.method_233(this.field_587.field_452, true);
               break;
            case 3:
               this.field_615 = 0L;
            case 4:
            case 5:
            case 6:
            case 7:
            default:
               break;
            case 8:
               this.method_129(40);
               break;
            case 9:
               this.method_129(5);
               break;
            case 10:
               this.method_129(8);
               break;
            case 11:
               field_496 = 0;
               break;
            case 12:
               short var2 = 290;
               class_17.method_48(method_361(290), 0);
         }

         field_592 = this.field_593;
         this.field_593 = 127;
         method_157();
         method_156();
      }
   }

   // $VF: renamed from: j (int) void
   private void method_129(int var1) {
      this.field_465 = 0;
      this.field_467 = -1;
      this.field_466 = var1;
      method_146();
   }

   // $VF: renamed from: k (int) void
   private void method_130(int var1) {
      this.field_467 = var1;
      if (this.field_467 == 261) {
         method_178("residentevil.dat", this.field_687);
         this.field_468 = this.field_687[0];
      } else {
         this.field_468 = 0;
      }
   }

   // $VF: renamed from: r () void
   private void method_131() {
      switch (this.field_465) {
         case 0:
            field_541 = null;
            field_542 = null;
            break;
         case 1:
            for (int var6 = 0; var6 < 12; var6++) {
               field_545[var6] = null;
            }
            break;
         case 2:
            for (int var5 = 0; var5 < 11; var5++) {
               field_547[var5] = null;
            }
            break;
         case 3:
            for (int var4 = 0; var4 < 2; var4++) {
               field_546[var4] = null;
            }
            break;
         case 4:
            field_777 = null;

            for (int var3 = 0; var3 < 5; var3++) {
               field_549[var3] = null;
            }
            break;
         case 5:
            for (int var2 = 0; var2 < 5; var2++) {
               field_548[var2] = null;
            }
            break;
         case 6:
            for (int var1 = 0; var1 < 4; var1++) {
               field_550[var1] = null;
            }
            break;
         case 7:
            field_552 = null;
      }

      this.field_465++;
   }

   // $VF: renamed from: s () void
   private void method_132() {
      if (this.field_607 == 0) {
         method_334("/17");
         field_550[0] = this.method_312("/17", 0, true);
         field_550[2] = this.method_312("/17", 2, true);
         method_336();
      } else if (this.field_607 == 1) {
         method_334("/13");
         field_545[7] = this.method_312("/13", 7, true);
         field_545[8] = this.method_312("/13", 8, true);
         field_545[10] = this.method_312("/13", 10, true);
         method_336();
         method_334("/17");
         field_550[1] = this.method_312("/17", 1, true);
         field_550[3] = this.method_312("/17", 3, true);
         method_336();
      } else {
         if (this.field_607 == 2) {
            method_334("/13");
            field_545[7] = this.method_312("/13", 7, true);
            field_545[9] = this.method_312("/13", 9, true);
            field_545[6] = this.method_312("/13", 6, true);
            method_336();
            method_334("/15");
            field_547[10] = this.method_312("/15", 10, true);
            method_336();
            method_334("/16");
            field_548[4] = this.method_312("/16", 4, true);
            method_336();
         }
      }
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics) void
   private void method_133(Graphics var1) {
      int var2;
      if ((var2 = 180 * (this.field_465 + 1) / this.field_466) > 180) {
         var2 = 180;
      }

      field_788.setColor(0);
      int var4 = field_569;
      int var3 = field_568;
      method_350(field_788, 0, 0, var3, var4);
      var3 = 16777215;
      field_788.setColor(var3);
      method_351(class_6.field_67, class_6.field_68, 180, 12);
      var3 = 9437184;
      field_788.setColor(var3);
      int var10000 = class_6.field_67 + 1;
      int var10001 = class_6.field_68 + 1;
      var4 = var2 - 1;
      var3 = var10001;
      var2 = var10000;
      method_350(field_788, var2, var3, var4, 11);
      if (this.field_465 == this.field_466) {
         field_812 = 1000;
         if (this.field_466 == 40) {
            this.field_766 = 2;
            if (this.field_467 == 260) {
               this.method_194();
            } else if (this.field_467 == 261 && this.method_183()) {
               this.method_300();
            }
         } else if (this.field_466 == 5) {
            field_592 = 2;
            this.method_148();
            if (this.method_212() >= 0) {
               this.method_144(25);
            }

            if (this.field_471 || this.field_607 == 3) {
               this.field_471 = false;
               this.method_214(true);
               this.method_233(this.field_587.field_452, true);
            } else if (!this.field_472) {
               field_474 = true;
               this.method_184();
               this.method_182();
            } else {
               this.field_472 = false;
            }
         } else if (this.field_466 == 8) {
            if (field_747) {
               this.method_154();
               byte var7 = -1;
               field_507 = -1;
               this.method_215(14, 0);
               this.method_128();
               field_747 = false;
            } else {
               this.method_215(1, 129);
               this.method_145(0);
            }
         }
      }

      field_551[0].method_119(0);
      int var8 = 290;
      method_173(var1, method_361(290), field_570, class_6.field_68 - this.field_579 - 10, 36);
      if (this.field_465 == this.field_466) {
         field_788.setColor(0);
         var8 = field_569;
         int var5 = field_568;
         method_350(field_788, 0, 0, var5, var8);
         this.field_465 = 0;
      }
   }

   // $VF: renamed from: c (int) boolean
   private boolean method_134(int var1) {
      if (this.field_473 == "/13") {
         if (this.field_468 != 1 && this.field_468 != 2 && var1 == 7
            || this.field_468 != 1 && var1 == 8
            || this.field_468 != 1 && var1 == 10
            || this.field_468 != 2 && var1 == 9
            || this.field_468 != 2 && var1 == 6) {
            return false;
         }
      } else if (this.field_473 == "/15") {
         if (this.field_468 != 2 && var1 == 10) {
            return false;
         }
      } else if (this.field_473 != "/14" && this.field_473 != "/12") {
         if (this.field_473 == "/16") {
            if (this.field_468 != 2 && var1 == 4) {
               return false;
            }
         } else if (this.field_473 == "/17"
            && (this.field_468 != 0 && var1 == 0 || this.field_468 != 0 && var1 == 2 || this.field_468 != 1 && var1 == 1 || this.field_468 != 1 && var1 == 3)) {
            return false;
         }
      }

      return true;
   }

   // $VF: renamed from: a (int[], int, int, int) void
   private static void method_135(int[] var0, int var1, int var2, int var3) {
      field_478 = var0;
      field_481 = var0.length;
      field_480 = 0;
      field_482 = 0;
      field_483 = 180;
      if (field_485 > field_486) {
         field_484 = 220;
      } else {
         field_484 = 180;
      }

      field_489 = var2;
      method_327();
   }

   // $VF: renamed from: l (int) void
   private void method_136(int var1) {
      field_479 = var1;
      switch (var1) {
         case 0:
            class_21 var10000 = field_551[1];
            short var2 = 265;
            field_485 = method_174(var10000, method_361(265).toUpperCase());
            field_486 = (field_486 = field_556[0].method_91(1)) - 40;
            field_487 = 180 + (field_486 + field_485 >> 1);
            field_488 = 180 - (field_486 + field_485 >> 1);
            method_135(new int[]{260, 261, 265, 266, 268, 263, 264, 267}, 180, class_7.field_69, 36);
            if (!field_474) {
               method_137(261);
            }

            if (!field_558) {
               method_137(265);
            }

            if (!field_559) {
               method_137(266);
            }

            field_751 = -1;
            return;
         case 1:
            method_135(new int[]{268}, 180, class_7.field_69, 36);
            return;
         case 2:
            field_748 = true;
            method_135(new int[]{9, 11, 14, 20, 21, 263, 22, 23}, 180, 242, 36);
            if (!field_474) {
               method_137(21);
            }
      }
   }

   // $VF: renamed from: m (int) void
   private static void method_137(int var0) {
      for (int var1 = 0; var1 < field_481; var1++) {
         if (field_478[var1] == var0) {
            for (int var2 = var1; var2 < field_481 - 1; var2++) {
               field_478[var2] = field_478[var2 + 1];
            }

            field_481--;
            return;
         }
      }
   }

   // $VF: renamed from: t () void
   private void method_138() {
      if (field_485 > field_486) {
         if (field_484 > field_488) {
            field_484--;
         } else {
            field_484 = field_487;
         }
      }

      if (field_527 != null && field_527.field_74 >= 50 && field_527.field_74 < 100) {
         if (!field_514 && field_482 != field_527.field_74 - 50) {
            field_482 = field_527.field_74 - 50;
            this.method_144(22);
         }

         if (field_535) {
            if (field_478[field_482] != 14) {
               field_535 = false;
               field_527 = null;
               field_514 = true;
            } else if (field_594 == 384 && !method_309() && this.method_201()) {
               field_535 = false;
               field_527 = null;
               field_514 = true;
            }
         }
      }

      if (!this.method_163(2049) && (field_527 == null || field_527.field_74 != 1 || !field_535)) {
         if (this.method_163(3586) || field_527 != null && field_527.field_74 == 2 && field_535) {
            if (field_482 < field_481 - 1) {
               if (++field_482 > 10 + field_480 - 1) {
                  field_480++;
               }
            } else {
               field_480 = 0;
               field_482 = 0;
            }

            method_157();
            method_156();
         }
      } else {
         if (field_482 > 0) {
            if (--field_482 < field_480 && field_480 > 0) {
               field_480--;
            }
         } else {
            field_480 = field_481 > 10 ? field_481 - 10 : 0;
            field_482 = field_481 - 1;
         }

         method_157();
         method_156();
      }

      if (!this.method_163(2821) && !this.method_163(18) && !field_513) {
         if (this.method_163(19) || field_528 != null && field_528.field_74 == 1002 && field_535) {
            method_157();
            method_156();
            if (field_479 == 2) {
               this.method_301();
               this.method_144(21);
            }

            if (field_479 == 1) {
               this.method_136(0);
               short var3 = 262;
               field_482 = 0;

               for (int var4 = 0; var4 < field_481; var4++) {
                  if (field_478[var4] == 262) {
                     field_482 = var4;
                     break;
                  }
               }

               this.method_144(21);
               method_151(0);
            }
         }
      } else {
         method_157();
         method_156();
         field_513 = false;
         if (field_478[field_482] != 268 && field_478[field_482] != 11) {
            this.method_144(8);
         }

         switch (field_478[field_482]) {
            case 9:
               this.method_301();
               break;
            case 11:
            case 268:
               field_475 = !field_475;
               if (field_475) {
                  if (field_592 == 1) {
                     this.method_145(0);
                  }

                  if (field_592 == 2) {
                     this.method_144(8);
                     return;
                  }
               } else {
                  this.method_147();
               }
               break;
            case 14:
               if (this.method_201()) {
                  this.field_742 = this.field_574;
                  this.method_200(this.field_591 == 1 ? 2 : 1);
               }

               return;
            case 17:
            case 273:
               if (!(field_477 = !field_477) || field_594 != 901) {
                  return;
               }

               field_594 = 900;
               break;
            case 20:
               if (field_592 != 2
                  || field_594 != 384
                  || this.field_658 != 2 && field_618 != 2
                  || this.field_607 == 3
                  || this.field_587.field_452.field_135 != 0) {
                  this.method_140(0, 291, 293);
               } else if (field_474) {
                  this.method_140(1, 297, 292);
               } else {
                  this.method_143();
                  this.method_136(2);
               }
               break;
            case 21:
               field_780 = true;
            case 22:
            case 23:
               this.method_140(1, 291, 294);
               break;
            case 260:
               if (field_474) {
                  this.method_140(2, -1, 5);
               } else {
                  this.method_215(8, 0);
                  this.method_128();
                  this.method_130(260);
                  field_781 = false;
               }

               field_780 = false;
               break;
            case 261:
               this.method_215(8, 0);
               this.method_128();
               this.method_130(261);
               field_780 = true;
               field_781 = true;
               break;
            case 262:
               this.method_136(1);
               break;
            case 263:
               int var2 = field_479;
               field_497 = field_479;
               this.method_215(11, 0);
               this.method_128();
               break;
            case 264:
               this.method_154();
               int var1 = field_479;
               field_507 = field_479;
               this.method_215(14, 0);
               this.method_128();
               break;
            case 265:
               this.method_215(12, 0);
               this.method_128();
               break;
            case 266:
               method_146();
               class_17.method_49();
               class_17.method_56(0);
               class_17.method_62(field_788);
               break;
            case 267:
               this.method_140(2, -1, 4);
               break;
            default:
               return;
         }
      }
   }

   // $VF: renamed from: u () void
   private void method_139() {
      int var1 = field_489;
      int var2 = field_480;
      int var3 = field_481 < 10 ? field_481 : field_480 + 10;
      field_536 = field_556[0].method_91(1);
      field_537 = field_537 = field_556[0].method_92(1);

      for (int var9 = var2; var9 < var3; var9++) {
         if (var9 == field_482) {
            field_551[1].method_119(1);
            if (field_478[var9] == 265 || field_478[var9] == 266) {
               field_551[1].method_119(4);
            }
         } else {
            field_551[1].method_119(0);
            if (field_478[var9] == 265 || field_478[var9] == 266) {
               field_551[1].method_119(3);
            }
         }

         if ((System.currentTimeMillis() & 64L) != 0L && field_514) {
            field_551[0].method_119(0);
            if (field_478[var9] == 265 || field_478[var9] == 266) {
               field_551[1].method_119(3);
            }
         }

         if (var9 == field_482) {
            if (!field_580) {
               class_21 var10000 = field_556[0];
               Graphics var10001 = field_788;
               int var6 = (System.currentTimeMillis() & 64L) != 0L && field_514 ? 1 + var9 * 2 : 1 + var9 * 2 + 1;
               Graphics var5 = var10001;
               var10000.method_101(var5, var6, 180, var1, 0, 0, 0);
            } else {
               class_21 var46 = field_556[0];
               Graphics var57 = field_788;
               int var28 = (System.currentTimeMillis() & 64L) != 0L && field_514 ? 1 + var9 * 2 : 1 + var9 * 2 + 1;
               Graphics var16 = var57;
               var46.method_101(var16, var28, 180, var1, 0, 0, 0);
            }
         } else if (!field_580) {
            class_21 var47 = field_556[0];
            int var29 = 1 + var9 * 2;
            Graphics var17 = field_788;
            var47.method_101(var17, var29, 180, var1, 0, 0, 0);
         } else {
            class_21 var48 = field_556[0];
            int var30 = 1 + var9 * 2;
            Graphics var18 = field_788;
            var48.method_101(var18, var30, 180, var1, 0, 0, 0);
         }

         method_158(180 - (field_536 >> 1), var1 - (field_537 >> 1), field_536, field_537, var9 + 50);
         if (field_478[var9] != 268 && field_478[var9] != 273 && field_478[var9] != 11 && field_478[var9] != 14 && field_478[var9] != 17) {
            if (field_478[var9] == 265) {
               int var53 = 180 - (field_486 >> 1);
               int var63 = var1 - 20;
               int var36 = field_486;
               int var24 = var63;
               int var12 = var53;
               method_349(field_788, var12, var24, var36, 42);
               if (field_485 < field_486) {
                  class_21 var54 = field_551[1];
                  Graphics var64 = field_788;
                  String var70 = method_361(var12 = field_478[var9]).toUpperCase();
                  int var42 = field_483;
                  String var37 = var70;
                  Graphics var25 = var64;
                  var54.method_117(var25, var37, var42, var1, 3, true);
               } else {
                  class_21 var55 = field_551[1];
                  Graphics var65 = field_788;
                  String var71 = method_361(var12 = field_478[var9]).toUpperCase();
                  int var43 = field_484;
                  String var38 = var71;
                  Graphics var26 = var65;
                  var55.method_117(var26, var38, var43, var1, 3, true);
               }

               method_349(field_788, 0, 0, 360, 640);
            } else {
               class_21 var56 = field_551[1];
               Graphics var66 = field_788;
               int var15;
               String var72 = method_361(var15 = field_478[var9]).toUpperCase();
               int var44 = field_483;
               String var39 = var72;
               Graphics var27 = var66;
               var56.method_117(var27, var39, var44, var1, 3, true);
            }
         } else {
            if (field_478[var9] == 268) {
               class_21 var49 = field_551[1];
               Graphics var58 = field_788;
               int var4;
               String var10002 = method_361(var4 = field_475 ? 280 : 281);
               int var7 = field_483 + 75;
               String var31 = var10002;
               Graphics var19 = var58;
               var49.method_117(var19, var31, var7, var1, 3, true);
            }

            if (field_478[var9] != 14 && field_478[var9] != 11) {
               class_21 var51 = field_551[1];
               Graphics var60 = field_788;
               int var11;
               String var68 = method_361(var11 = field_478[var9]).toUpperCase();
               int var41 = field_483 - 75;
               String var33 = var68;
               Graphics var21 = var60;
               var51.method_117(var21, var33, var41, var1, 3, true);
            } else {
               class_21 var50 = field_551[1];
               Graphics var59 = field_788;
               int var10;
               String var67 = method_361(var10 = field_478[var9]).toUpperCase();
               int var40 = field_483 + -75;
               String var32 = var67;
               Graphics var20 = var59;
               var50.method_117(var20, var32, var40, var1, 3, true);
            }

            int var61 = field_478[var9];
            int var34 = field_483 + 75;
            int var22 = var61;
            int var8 = 0;
            if (field_479 == 1 || field_479 == 2) {
               switch (var22) {
                  case 11:
                  case 268:
                     var8 = field_475 ? 280 : 281;
                     break;
                  case 14:
                     var8 = this.field_591 == 1 ? 15 : 16;
                     break;
                  case 17:
                  case 273:
                     var8 = field_477 ? 284 : 285;
               }

               class_21 var52 = field_551[1];
               Graphics var62 = field_788;
               String var35 = method_361(var8);
               Graphics var23 = var62;
               var52.method_117(var23, var35, var34, var1, 3, true);
            }
         }

         if (field_478[var9] == 265) {
            class_17.method_72(field_788, field_560, field_561 + 54, var1 + 1 + -8, 20);
         }

         var1 += 43;
      }

      field_510 = true;
      field_551[1].method_119(0);
      field_551[0].method_119(0);
   }

   // $VF: renamed from: a (int, int, int) void
   final void method_140(int var1, int var2, int var3) {
      field_490 = var1;
      field_491 = var2;
      field_492 = var3;
      field_493 = 1;
      field_494 = true;
      method_157();
      method_156();
      if (field_492 == 24) {
         field_493 = 0;
      }
   }

   // $VF: renamed from: v () void
   private void method_141() {
      if (field_527 != null && !field_514) {
         field_493 = field_527.field_74 - 10;
      }

      if (field_527 != null && field_535) {
         field_535 = false;
         field_527 = null;
         field_514 = true;
      }

      if (this.method_163(2563)) {
         field_493 = 0;
      } else if (this.method_163(3076)) {
         field_493 = 1;
      } else {
         if (this.method_163(2821) || this.method_163(18) || field_513) {
            method_157();
            method_156();
            field_513 = false;
            field_494 = false;
            this.method_144(8);
            int var1 = field_478[field_482];
            if (field_493 == 0) {
               if (field_492 == 3) {
                  field_475 = true;
                  field_563 = true;
                  this.method_145(0);
               } else if (field_492 == 5) {
                  this.field_607 = 0;
                  this.field_704 = false;
                  this.field_703 = false;
                  field_474 = false;
                  this.method_184();
                  this.method_215(8, 0);
                  this.method_128();
                  this.method_130(260);
                  field_781 = false;
               } else if (field_492 == 24) {
                  if (field_474) {
                     if (field_751 != 3) {
                        field_495 = true;
                     }

                     if (!this.method_183()) {
                        this.method_301();
                     }

                     this.method_132();
                  } else {
                     this.method_301();
                     this.method_194();
                  }

                  field_618 = 2;
                  field_617 = 0;
                  this.method_147();
               } else if (field_492 == 292) {
                  this.method_143();
               } else if (var1 == 21) {
                  if (field_751 != 3) {
                     field_495 = true;
                  }

                  if (!this.method_183()) {
                     this.method_301();
                  }

                  this.method_132();
                  this.method_140(0, 300, 301);
                  this.method_147();
               } else if (var1 == 22) {
                  field_751 = -1;
                  this.method_215(10, 0);
                  this.method_301();
               } else if (var1 == 23 || field_492 == 4) {
                  boolean var2 = true;
                  this.method_184();
                  method_146();
                  GloftRESE.field_860 = null;
                  field_791 = -1;
               }
            } else {
               if (field_492 == 24) {
                  this.method_215(10, 0);
                  this.method_301();
                  field_618 = 2;
                  field_617 = 0;
               }

               if (field_492 == 3) {
                  field_563 = true;
               }
            }

            method_327();
            if (field_492 == 4) {
               method_151(0);
               return;
            }
         } else if (this.method_163(19) && field_492 != 3 && field_492 != 24) {
            method_157();
            method_156();
            field_513 = false;
            field_494 = false;
            this.method_144(21);
         }
      }
   }

   // $VF: renamed from: w () void
   private void method_142() {
      field_536 = field_556[0].method_91(37);
      field_537 = field_556[0].method_92(37);
      if (field_490 == 2) {
         field_788.setColor(0);
         method_168(field_788, 0, 0, 360, 640);
         int var6 = field_492;
         method_175(field_788, method_361(field_492), 0, 180, 200, 0, 0, 360, 640, 36);
         if (field_493 != 0) {
            field_551[1].method_119(0);
            class_21 var42 = field_556[0];
            Graphics var14 = field_788;
            var42.method_101(var14, 37, 90, 290, 0, 0, 0);
         } else {
            if ((System.currentTimeMillis() & 64L) != 0L && field_514) {
               field_551[1].method_119(0);
            } else {
               field_551[1].method_119(1);
            }

            class_21 var10000 = field_556[0];
            Graphics var10001 = field_788;
            int var2 = (System.currentTimeMillis() & 64L) != 0L && field_514 ? 37 : 38;
            Graphics var1 = var10001;
            var10000.method_101(var1, var2, 90, 290, 0, 0, 0);
         }

         class_21 var43 = field_551[1];
         Graphics var55 = field_788;
         boolean var7 = true;
         String var23 = method_361(1).toUpperCase();
         Graphics var15 = var55;
         var43.method_117(var15, var23, 90, 290, 3, true);
         method_158(90 - (field_536 >> 1), 290 - (field_537 >> 1), field_536, field_537, 10);
         if (field_493 != 1) {
            field_551[1].method_119(0);
            var43 = field_556[0];
            var15 = field_788;
            var43.method_101(var15, 37, 270, 290, 0, 0, 0);
         } else {
            if ((System.currentTimeMillis() & 64L) != 0L && field_514) {
               field_551[1].method_119(0);
            } else {
               field_551[1].method_119(1);
            }

            var43 = field_556[0];
            var55 = field_788;
            int var24 = (System.currentTimeMillis() & 64L) != 0L && field_514 ? 37 : 38;
            var15 = var55;
            var43.method_101(var15, var24, 270, 290, 0, 0, 0);
         }

         var43 = field_551[1];
         var55 = field_788;
         byte var8 = 2;
         var23 = method_361(2).toUpperCase();
         var15 = var55;
         var43.method_117(var15, var23, 270, 290, 3, true);
         method_158(270 - (field_536 >> 1), 290 - (field_537 >> 1), field_536, field_537, 11);
      } else {
         this.method_224(field_788, 40, class_4.field_46, 280, class_4.field_45, 6);
         int var9 = 543826;
         field_788.setColor(var9);
         method_166(field_788, 41, class_4.field_48, 318, class_4.field_49);
         field_551[0].method_119(4);
         int var10 = field_491;
         method_173(field_788, method_361(field_491), 180, class_4.field_47, 36);
         field_551[0].method_119(3);
         int var11 = field_492;
         method_175(field_788, method_361(field_492), 0, 42, class_4.field_50, 42, class_4.field_50, 320, class_4.field_50 + class_4.field_51, 20);
         if (field_490 == 0) {
            field_551[0].method_119(0);
            method_158(180 - (field_536 >> 1), class_4.field_52 - (field_537 >> 1), field_536, field_537, 11);
            if ((System.currentTimeMillis() & 64L) != 0L && field_514) {
               field_551[0].method_119(3);
            }

            class_21 var47 = field_556[0];
            Graphics var58 = field_788;
            int var10002 = (System.currentTimeMillis() & 64L) != 0L && field_514 ? 37 : 38;
            int var3 = class_4.field_52;
            int var26 = var10002;
            Graphics var19 = var58;
            var47.method_101(var19, var26, 180, var3, 0, 0, 0);
            var47 = field_551[1];
            var58 = field_788;
            short var12 = 295;
            String var64 = method_361(295).toUpperCase();
            var3 = class_4.field_52;
            String var27 = var64;
            var19 = var58;
            var47.method_117(var19, var27, 180, var3, 3, true);
         } else {
            short var13 = 295;
            short var21 = 296;
            if (field_492 == 24) {
               var13 = 1;
               var21 = 2;
            }

            if (field_493 != 0) {
               field_551[1].method_119(0);
               class_21 var50 = field_556[0];
               int var39 = class_4.field_52;
               Graphics var34 = field_788;
               var50.method_101(var34, 37, 110, var39, 0, 0, 0);
            } else {
               if ((System.currentTimeMillis() & 64L) != 0L && field_514) {
                  field_551[1].method_119(0);
               } else {
                  field_551[1].method_119(1);
               }

               class_21 var49 = field_556[0];
               Graphics var60 = field_788;
               int var65 = (System.currentTimeMillis() & 64L) != 0L && field_514 ? 37 : 38;
               int var5 = class_4.field_52;
               int var4 = var65;
               Graphics var33 = var60;
               var49.method_101(var33, var4, 110, var5, 0, 0, 0);
            }

            class_21 var51 = field_551[1];
            Graphics var61 = field_788;
            String var66 = method_361(var13).toUpperCase();
            int var40 = class_4.field_52;
            String var35 = var66;
            Graphics var28 = var61;
            var51.method_117(var28, var35, 110, var40, 3, true);
            method_158(110 - (field_536 >> 1), class_4.field_52 - (field_537 >> 1), field_536, field_537, 10);
            if (field_493 != 1) {
               field_551[1].method_119(0);
               var51 = field_556[0];
               int var37 = class_4.field_52;
               var28 = field_788;
               var51.method_101(var28, 37, 248, var37, 0, 0, 0);
            } else {
               if ((System.currentTimeMillis() & 64L) != 0L && field_514) {
                  field_551[1].method_119(0);
               } else {
                  field_551[1].method_119(1);
               }

               var51 = field_556[0];
               var61 = field_788;
               int var67 = (System.currentTimeMillis() & 64L) != 0L && field_514 ? 37 : 38;
               var40 = class_4.field_52;
               int var36 = var67;
               var28 = var61;
               var51.method_101(var28, var36, 248, var40, 0, 0, 0);
            }

            var51 = field_551[1];
            var61 = field_788;
            var66 = method_361(var21).toUpperCase();
            int var38 = class_4.field_52;
            String var31 = var66;
            Graphics var22 = var61;
            var51.method_117(var22, var31, 248, var38, 3, true);
            method_158(248 - (field_536 >> 1), class_4.field_52 - (field_537 >> 1), field_536, field_537, 11);
         }
      }

      field_551[0].method_119(0);
      field_510 = true;
   }

   // $VF: renamed from: x () void
   private void method_143() {
      field_474 = true;
      this.method_184();
      this.method_182();
      this.method_140(0, 298, 299);
   }

   // $VF: renamed from: a (int) void
   final void method_144(int var1) {
      boolean var2 = false;
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

      if (!method_149() || var2) {
         if (!field_783) {
            field_499 = 1;
            if (var2) {
               method_153();
            }

            method_150(1, var1);
            field_499 = 0;
         }
      }
   }

   // $VF: renamed from: b (int) void
   final void method_145(int var1) {
      if (this.field_465 == this.field_466 || var1 != 2) {
         field_498 = var1;
      }

      boolean var2 = false;
      if (var1 == 1 || var1 == 1) {
         var2 = true;
      }

      if (field_475) {
         if (field_592 != 9) {
            if (!method_149() || var2) {
               field_498 = -1;
               if (field_783) {
                  field_785 = var1;
               } else {
                  method_150(field_499, var1);
               }
            }
         }
      }
   }

   // $VF: renamed from: y () void
   private static void method_146() {
      method_153();
      method_153();
      field_498 = -1;
   }

   // $VF: renamed from: z () void
   private void method_147() {
      int var1 = field_498;
      method_146();
      field_498 = var1;
   }

   // $VF: renamed from: A () void
   private void method_148() {
      if (field_498 != -1) {
         this.method_145(field_498);
      }
   }

   // $VF: renamed from: a () boolean
   static boolean method_149() {
      try {
         return field_501 != 27
               && field_501 != 7
               && field_501 != 31
               && field_501 != 33
               && field_501 != 14
               && field_501 != 41
               && field_501 != 40
               && field_501 != 22
            ? field_505 != null && field_505.getState() == 400
            : field_502[field_501] != null && field_502[field_501].getState() == 400;
      } catch (Exception var0) {
         return false;
      }
   }

   // $VF: renamed from: g (int, int) void
   private static void method_150(int var0, int var1) {
      if (field_475 && var1 < 52) {
         try {
            if (field_503[var1] != null) {
               method_153();
               if (var1 != 27 && var1 != 31 && var1 != 7 && var1 != 33 && var1 != 14 && var1 != 41 && var1 != 40 && var1 != 22) {
                  field_506 = System.currentTimeMillis();
                  field_503[var1].reset();
                  (field_505 = Manager.createPlayer(field_503[var1], field_504[var1])).realize();
               }

               if (var1 != 27 && var1 != 7 && var1 != 31 && var1 != 33 && var1 != 14 && var1 != 41 && var1 != 40) {
                  System.out.println("!!!!!!!!!!!!!!!!!!!  s_soundType[i] = ");
                  field_505.setLoopCount(1);
                  field_505.prefetch();
                  field_505.setMediaTime(-1L);
                  field_505.start();
               } else {
                  System.out.println("@@@@@@@@@@@@@@ s_soundType[i] = cacheeeeeeeee ");
                  if (field_502[var1] != null) {
                     field_502[var1].start();
                     field_501 = var1;
                  }
               }

               field_506 = System.currentTimeMillis();
            }

            field_500 = var1;
            return;
         } catch (Exception var2) {
            var2.printStackTrace();
         }
      }
   }

   // $VF: renamed from: n (int) void
   private static void method_151(int var0) {
      if (field_500 == var0) {
         method_153();
      }
   }

   // $VF: renamed from: a () void
   static void method_152() {
      method_153();
   }

   // $VF: renamed from: b () void
   static void method_153() {
      try {
         if (field_505 != null) {
            if (field_505.getState() == 400) {
               field_505.stop();
            }

            if (field_505.getState() == 300) {
               field_505.deallocate();
            }

            field_505.close();
            field_505 = null;
         }

         if (field_501 == 27
            || field_501 == 7
            || field_501 == 31
            || field_501 == 33
            || field_501 == 14
            || field_501 == 41
            || field_501 == 40
            || field_501 == 22) {
            field_502[field_501].stop();
            field_502[field_501].deallocate();
            field_501 = -1;
         }

         field_500 = -1;
      } catch (Exception var0) {
         field_500 = -1;
      }
   }

   // $VF: renamed from: B () void
   private void method_154() {
      StringBuffer var10000 = new StringBuffer();
      short var1 = 365;
      var10000 = var10000.append(method_361(365));
      var1 = 902;
      var10000 = var10000.append(method_361(902));
      var1 = 903;
      var10000 = var10000.append(method_361(903));
      var1 = 904;
      String var11 = field_508 = var10000.append(method_361(904)).toString();
      String var2 = field_797.getAppProperty("MIDlet-Version");
      field_508 = method_364(var11, new String[]{var2});
      class_21 var12 = field_551[0];
      int var3 = field_793 - 20;
      var2 = field_508;
      field_509 = var12.method_114(var2, var3, false);
      this.field_465 = class_2.field_31 + class_2.field_32;
      class_11.method_11();
      this.method_145(6);
   }

   protected final void pointerPressed(int var1, int var2) {
      class_17.method_58(var1, var2);
      field_532 = System.currentTimeMillis();
      field_535 = false;
      field_531 = true;
      field_533 = false;
      field_523 = var2;
      this.method_155(var1, var2);
      if (field_518 && field_527 == null && field_528 == null && field_531 && !field_515) {
         field_557.method_5(2, 1);
         field_515 = true;
      }
   }

   // $VF: renamed from: h (int, int) void
   private void method_155(int var1, int var2) {
      field_529 = var1;
      field_530 = var2;
      field_527 = null;
      field_528 = null;
      if (field_594 == 139 && this.field_534 == -1 && !field_580 && field_535) {
         this.field_534 = -1;
         int var3 = var1 - 180;
         int var4 = var2 - class_0.field_14;
         int var5 = var3 < 0 ? -var3 : var3;
         int var6 = var4 < 0 ? -var4 : var4;
         int var7 = var3 * var3;
         int var8 = var4 * var4;
         if ((var5 > class_3.field_43 || var6 > class_3.field_43) && var7 + var8 <= class_3.field_44 * class_3.field_44) {
            if (var5 == 0) {
               var5 = 491520;
            } else {
               var5 = (var6 << 16) / var5;
            }

            if (var5 <= 17039) {
               if (var3 < 0) {
                  this.field_534 = 9;
               } else {
                  this.field_534 = 3;
               }
            } else if (var5 >= 245760) {
               if (var4 < 0) {
                  this.field_534 = 0;
               } else {
                  this.field_534 = 6;
               }
            } else if (var5 > 17039 && var5 <= 65536) {
               if (var3 < 0 && var4 < 0) {
                  this.field_534 = 10;
               } else if (var3 < 0 && var4 > 0) {
                  this.field_534 = 8;
               } else if (var3 > 0 && var4 > 0) {
                  this.field_534 = 4;
               } else if (var3 > 0 && var4 < 0) {
                  this.field_534 = 2;
               }
            } else if (var5 > 65536 && var5 < 245760) {
               if (var3 < 0 && var4 < 0) {
                  this.field_534 = 11;
               } else if (var3 < 0 && var4 > 0) {
                  this.field_534 = 7;
               }

               if (var3 > 0 && var4 < 0) {
                  this.field_534 = 1;
               }

               if (var3 > 0 && var4 > 0) {
                  this.field_534 = 5;
               }
            }

            System.out.println("aaaaaaaaaaaaaaaa " + this.field_534);
         }

         if (this.field_534 != -1) {
            field_520 = System.currentTimeMillis();
            if (this.field_534 > this.field_725 && this.field_534 - this.field_725 > -6) {
               field_521 = true;
            } else {
               field_521 = false;
            }

            this.field_534 = this.field_534 - this.field_725 < 0 ? -(this.field_534 - this.field_725) : this.field_534 - this.field_725;
         }
      }

      for (int var11 = field_525.size() - 1; var11 >= 0; var11--) {
         class_8 var9;
         if ((var9 = (class_8)field_525.elementAt(var11)).method_0(var1, var2)) {
            field_527 = var9;
            break;
         }
      }

      if (field_527 != null) {
         field_522 = false;
      }

      for (int var12 = field_526.size() - 1; var12 >= 0; var12--) {
         class_8 var10;
         if ((var10 = (class_8)field_526.elementAt(var12)).method_0(var1, var2)) {
            field_528 = var10;
            return;
         }
      }
   }

   protected final void pointerDragged(int var1, int var2) {
      class_17.method_59(var1, var2);
      field_533 = true;
      field_531 = false;
      field_535 = false;
      this.method_155(var1, var2);
   }

   protected final void pointerReleased(int var1, int var2) {
      if (field_527 != null && field_527.field_74 == 14) {
         field_572 = 0;
      }

      field_515 = false;
      class_17.method_57(var1, var2);
      field_533 = false;
      field_531 = false;
      field_535 = true;
      this.method_155(var1, var2);
      field_476 = true;
      field_517 = false;
   }

   // $VF: renamed from: c () void
   public static void method_156() {
      field_525.removeAllElements();
      field_527 = null;
      field_510 = false;
      field_533 = false;
      field_531 = false;
      field_535 = false;
      field_532 = 0L;
      method_327();
      field_514 = false;
      field_512 = 0L;
      field_513 = false;
      field_572 = 0;
      method_327();
      field_476 = true;
   }

   // $VF: renamed from: d () void
   public static void method_157() {
      field_526.removeAllElements();
      field_528 = null;
      field_511 = false;
      field_533 = false;
      field_531 = false;
      field_535 = false;
      field_532 = 0L;
      field_514 = false;
      field_512 = 0L;
      field_513 = false;
      field_518 = false;
      field_522 = false;
      field_516 = false;
      method_327();
   }

   // $VF: renamed from: a (int, int, int, int, int) void
   private static void method_158(int var0, int var1, int var2, int var3, int var4) {
      if (!field_510) {
         class_8 var5 = new class_8(var0, var1, var2, var3, var4);
         field_525.addElement(var5);
         field_527 = null;
      }
   }

   // $VF: renamed from: b (int, int, int, int, int) void
   private static void method_159(int var0, int var1, int var2, int var3, int var4) {
      if (!field_511) {
         class_8 var5 = new class_8(var0, var1, var2, var3, var4);
         field_526.addElement(var5);
         field_528 = null;
      }
   }

   // $VF: renamed from: b (javax.microedition.lcdui.Graphics) void
   private void method_160(Graphics var1) {
      field_518 = false;
      if (!field_580) {
         if (field_618 != 0 && field_618 != 1 && field_594 != 131 && !method_309()) {
            if (!field_749) {
               field_518 = true;
               field_536 = field_556[1].method_91(1) + 2;
               field_537 = field_556[1].method_92(1) + 2;
               class_21 var10000 = field_556[1];
               int var10002 = field_527 != null && field_527.field_74 == 10 ? 8 : 7;
               int var6 = class_3.field_37;
               int var5 = class_3.field_36;
               int var4 = var10002;
               Graphics var3 = field_788;
               var10000.method_101(var3, var4, var5, var6, 0, 0, 0);
               method_158(class_3.field_36 - field_536, class_3.field_37 - field_537 - 15, field_536, field_537 + 15, 10);
               var10000 = field_556[1];
               var10002 = field_527 != null && field_527.field_74 == 11 ? 2 : 1;
               var6 = class_3.field_37;
               var5 = class_3.field_36;
               var4 = var10002;
               var3 = field_788;
               var10000.method_101(var3, var4, var5, var6, 0, 0, 0);
               method_158(class_3.field_36, class_3.field_37 - field_537 - 15, field_536 + 15, field_537 + 15, 11);
               var10000 = field_556[1];
               var10002 = field_527 != null && field_527.field_74 == 12 ? 4 : 3;
               var6 = class_3.field_37;
               var5 = class_3.field_36;
               var4 = var10002;
               var3 = field_788;
               var10000.method_101(var3, var4, var5, var6, 0, 0, 0);
               method_158(class_3.field_36, class_3.field_37, field_536 + 15, field_537, 12);
               var10000 = field_556[1];
               var10002 = field_527 != null && field_527.field_74 == 13 ? 6 : 5;
               var6 = class_3.field_37;
               var5 = class_3.field_36;
               var4 = var10002;
               var3 = field_788;
               var10000.method_101(var3, var4, var5, var6, 0, 0, 0);
               method_158(class_3.field_36 - field_536, class_3.field_37, field_536, field_537, 13);
               field_536 = field_556[1].method_91(9) + 2;
               field_537 = field_556[1].method_92(9) + 2;
               int var2 = field_527 != null && field_527.field_74 == 14 ? 10 : 9;
               if (field_594 != 900 && field_594 != 901 && field_594 != 647 && field_594 != 646) {
                  var2 += 2;
               }

               var10000 = field_556[1];
               var6 = field_794 - (field_537 >> 1) - 8;
               var5 = class_3.field_38;
               var3 = field_788;
               var10000.method_101(var3, var2, var5, var6, 0, 0, 0);
               method_158(class_3.field_38 - (field_536 >> 1), field_794 - field_537 - 8, field_536, field_537, 14);
               if (this.field_587.field_455 == field_543[this.field_587.field_458] && this.field_587.field_458 != 0 && this.field_587.field_455 != 0) {
                  method_173(
                     var1,
                     "" + this.field_587.field_457[this.field_587.field_458],
                     class_3.field_40 - 3,
                     field_794 - field_537 - 2 + 42 - class_0.field_3[0],
                     68
                  );
               }

               field_536 = field_556[1].method_91(13) + 2;
               field_537 = field_556[1].method_92(13) + 2;
               var10000 = field_556[1];
               var10002 = field_527 != null && field_527.field_74 == 15 ? 14 : 13;
               int var10003 = class_3.field_40 + (field_536 >> 1);
               var6 = field_794 - (field_537 >> 1) - 2;
               var5 = var10003;
               var4 = var10002;
               var3 = field_788;
               var10000.method_101(var3, var4, var5, var6, 0, 0, 0);
               var2 = field_549[1].method_92(1);
               int var18 = field_549[1].method_91(1);
               var10000 = field_549[1];
               var10002 = 1 + this.field_587.field_454[this.field_587.field_455].field_120;
               var10003 = class_3.field_40 + (field_536 - var18 >> 1);
               var4 = field_794 - field_537 + (field_537 - var2 >> 1) - 2;
               int var19 = var10003;
               var2 = var10002;
               var10000.method_101(var1, var2, var19, var4, 0, 0, 0);
               method_158(class_3.field_40, field_794 - field_537 - 2, field_536, field_537, 15);
               field_510 = true;
               if (!field_557.method_6()) {
                  class_11 var7 = field_557;
                  if (field_557.field_91 == 2 && field_594 != 646 && field_594 != 647) {
                     var2 = field_530;
                     int var9 = field_529;
                     class_11 var8 = field_557;
                     field_557.field_87 = var9;
                     var8.field_88 = var2;
                     field_557.method_8(field_804);
                  }
               }
            }
         }
      }
   }

   // $VF: renamed from: C () void
   private void method_161() {
      if (field_527 != null || field_528 != null || !field_531 && !field_533) {
         if (field_527 != null && !field_531 && !field_533 || field_535) {
            field_572 = 0;
            return;
         }

         if (field_527 != null && (field_527.field_74 == 14 || field_527.field_74 == 15 || field_527.field_74 == 1001 || field_527.field_74 == 999)) {
            field_572 = 0;
         }
      } else {
         if (field_518 && System.currentTimeMillis() - field_532 < 100L) {
            field_476 = false;
            field_522 = true;
         } else {
            field_476 = true;
            field_522 = false;
         }

         int var1 = this.method_228(this.field_587.field_452.field_131, this.field_587.field_452.field_132) - this.field_597 + 108;
         byte var3 = this.field_587.field_452.field_132;
         byte var2 = this.field_587.field_452.field_131;
         int var4 = (var3 + var2) * 27 - this.field_598 + 54;
         if (method_170(field_529 - (var1 - 54)) > 27 || method_170(field_530 - (var4 - 27)) > 13) {
            if (field_529 < var1 - 54) {
               if (field_530 < var4 - 27) {
                  field_572 = 2563;
                  return;
               }

               field_572 = 3586;
               return;
            }

            if (field_529 >= var1 - 54) {
               if (field_530 < var4 - 27) {
                  field_572 = 2049;
                  return;
               }

               field_572 = 3076;
               return;
            }
         }
      }
   }

   public class_27(Object var1, Object var2) {
      field_808 = this;
      field_791 = -1;
      field_796 = true;
      field_797 = (MIDlet)var1;
      field_795 = null;
      this.method_324();
      field_814 = new Hashtable();
      (field_813 = new Hashtable()).put(new Integer(48), new Integer(6));
      field_813.put(new Integer(49), new Integer(7));
      field_813.put(new Integer(50), new Integer(1));
      field_813.put(new Integer(51), new Integer(9));
      field_813.put(new Integer(52), new Integer(3));
      field_813.put(new Integer(53), new Integer(5));
      field_813.put(new Integer(54), new Integer(4));
      field_813.put(new Integer(55), new Integer(13));
      field_813.put(new Integer(56), new Integer(2));
      field_813.put(new Integer(57), new Integer(15));
      field_813.put(new Integer(35), new Integer(17));
      field_813.put(new Integer(42), new Integer(16));
      field_813.put(new Integer(-6), new Integer(18));
      field_813.put(new Integer(-7), new Integer(19));
      field_814.put(new Integer(-5), new Integer(5));
      field_814.put(new Integer(-1), new Integer(1));
      field_814.put(new Integer(-2), new Integer(2));
      field_814.put(new Integer(-3), new Integer(3));
      field_814.put(new Integer(-4), new Integer(4));
      field_805 = System.currentTimeMillis();
      this.field_799 = field_805;
      this.field_534 = -1;
      this.field_573 = false;
      Runtime.getRuntime();
      this.field_577 = new Random();
      this.field_589 = new class_26(this);
      this.field_590 = new class_26(this);
      this.field_608 = new boolean[4];
      this.field_628 = new class_25[5];
      this.field_629 = new class_22[10];
      this.field_630 = new short[150];
      this.field_631 = new byte[150];
      this.field_661 = new class_19[20];
      this.field_662 = new class_19(this);
      this.field_674 = new boolean[189];
      this.field_681 = new byte[72][50];
      this.field_682 = new byte[72][50];
      this.field_688 = new StringBuffer(256);
      this.field_709 = new byte[3];
      this.field_750 = false;
      this.field_753 = 0;
      this.field_754 = 0;
      this.field_755 = 0;
      this.field_756 = 0;
      this.field_757 = 0;
      this.field_758 = 0;
      this.field_759 = 0;
      this.field_760 = 0;
      this.field_761 = 0;
      this.field_762 = 0;
      this.field_763 = null;
      this.field_764 = false;
      this.field_766 = 0;
      this.field_767 = 0;
      this.field_768 = true;
      this.field_776 = -1;
      method_325(false, 50, 8);
      method_325(false, 52, 10);
      method_325(false, 54, 12);
      method_325(false, 56, 14);
      method_325(false, 53, 11);
      field_566 = (GloftRESE)var1;
      field_743 = new class_18(this);
      field_744 = new class_12(this);
      field_745 = new class_10(this);
      boolean var4 = false;
      String var5 = "/EN";
      byte var9 = 0;
      String var6 = "/EN";
      method_363();
      method_334(var6);
      method_338(var9);
      if (field_832) {
         byte[] var7 = method_332(var9);
         method_360(new ByteArrayInputStream(var7));
      } else {
         method_360(field_821);
      }

      method_336();
      method_362();
      field_592 = 0;
      method_334("/3");
      field_544[1] = method_313(1, true, true);
      method_336();
      method_334("/1");
      field_551[0] = method_313(0, true, true);
      short[] var8 = (short[])method_343(2);
      field_551[0].method_109(var8);
      field_551[0].method_119(0);
      method_336();
   }

   // $VF: renamed from: c () boolean
   private boolean method_162() {
      if (method_309() && field_784) {
         return false;
      } else if (field_592 == 2 && this.field_593 == 10) {
         return false;
      } else if (this.field_587 != null && this.field_587.field_452 != null && this.field_587.field_452.field_141 <= 0) {
         return false;
      } else {
         return this.field_623 != null && this.field_623.field_130 && this.field_623.field_141 <= 0
            ? false
            : field_592 == 2
                  && field_594 != 138
                  && field_594 != 130
                  && field_594 != 137
                  && field_594 != 139
                  && (field_594 != 131 || field_633 != 3)
                  && field_617 != 731
                  && field_781
               || field_528 != null
                  && field_535
                  && field_528.field_74 == 1001
                  && field_592 == 2
                  && field_594 != 138
                  && field_594 != 137
                  && field_594 != 139
                  && field_594 != 130
                  && (field_594 != 131 || field_633 != 3);
      }
   }

   // $VF: renamed from: a (int) boolean
   final boolean method_163(int var1) {
      if (field_572 != 0) {
         return field_572 == var1;
      } else {
         int var2 = var1 & 0xFF;
         if ((var1 = var1 >> 8) > 0) {
            return this.field_573 ? method_331(var2) || method_331(var1) : method_328(var2) || method_328(var1);
         } else {
            return this.field_573 ? method_331(var2) : method_328(var2);
         }
      }
   }

   // $VF: renamed from: a () int
   public final int method_164() {
      return this.field_577.nextInt() & 0xFF;
   }

   // $VF: renamed from: c () int
   private int method_165() {
      return method_170(this.method_164() << 24 | this.method_164() << 16 | this.method_164() << 8 | this.method_164());
   }

   // $VF: renamed from: e (javax.microedition.lcdui.Graphics, int, int, int, int) void
   private static void method_166(Graphics var0, int var1, int var2, int var3, int var4) {
      var0.drawLine(var1, var2, var3, var4);
   }

   // $VF: renamed from: f (javax.microedition.lcdui.Graphics, int, int, int, int) void
   private static void method_167(Graphics var0, int var1, int var2, int var3, int var4) {
      var0.drawRect(var1, var2, var3 - 1, var4 - 1);
   }

   // $VF: renamed from: g (javax.microedition.lcdui.Graphics, int, int, int, int) void
   private static void method_168(Graphics var0, int var1, int var2, int var3, int var4) {
      var0.fillRect(var1, var2, var3, var4);
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, int) void
   private void method_169(Graphics var1, int var2) {
      int var10001 = var2 >> 16 & 0xFF;
      int var10002 = var2 >> 8 & 0xFF;
      int var3 = var2 & 0xFF;
      var2 = var10002;
      int var4 = var10001;
      var1.setColor(var4, var2, var3);
   }

   // $VF: renamed from: a (int) int
   private static int method_170(int var0) {
      return (var0 ^ var0 >> 31) - (var0 >> 31);
   }

   // $VF: renamed from: b (int) int
   private static int method_171(int var0) {
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
   private void method_172(Graphics var1, int var2, int var3, int var4, int var5, int var6, int var7, int var8, int var9) {
      if (method_226(var3, var4, var5, var6, 0, 0, field_568, field_569)) {
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
               class_21 var16 = field_552;
               field_552.method_101(var1, var7, var8, var13, 0, 0, 0);
            } else if (this.field_607 != 1 && this.field_607 != 2) {
               class_21 var51 = field_552;
               int var58 = var2 - 9;
               int var64 = var3 - var7;
               int var10004 = field_552.method_91(var2 - 9) % 2;
               boolean var10005 = true;
               var64 += field_552.method_91(var2 - 9);
               var13 = var4 - var8;
               var8 = var64;
               var7 = var58;
               var51.method_101(var1, var7, var8, var13, 1, 0, 0);
            } else {
               class_21 var50 = field_552;
               int var57 = var2 - 9;
               int var63 = var3 - var7 + (field_552.method_91(var2 - 9) % 2 == 1 ? field_552.method_91(var2 - 9) + 1 : field_552.method_91(var2 - 9));
               var13 = var4 - var8;
               var8 = var63;
               var7 = var57;
               var50.method_101(var1, var7, var8, var13, 1, 0, 0);
            }

            if (field_778) {
               int var10001 = var3 + (var5 >> 1);
               var3 = var4 + (var6 >> 1);
               var2 = var10001;
               class_11 var17 = field_777;
               field_777.field_87 = var2;
               var17.field_88 = var3;
               field_777.method_7();
               field_778 = false;
            }
         } else if (var2 >= 89 && var2 < 109) {
            if (var13 == 0) {
               int var55 = var2 - 89 + this.field_654;
               int var61 = var3 - var7;
               var5 = var4 - var8;
               var4 = var61;
               var3 = var55;
               class_21 var15 = field_552;
               field_552.method_101(var1, var3, var4, var5, 0, 0, 0);
            } else {
               class_21 var49 = field_552;
               int var56 = var2 - 89 + this.field_654;
               int var62 = var3 - var7 + field_552.method_91(var2 - 9 + this.field_654);
               var5 = var4 - var8;
               var4 = var62;
               var3 = var56;
               var49.method_101(var1, var3, var4, var5, 1, 0, 0);
            }
         } else if (var2 >= 109 && var2 < 139) {
            if (var13 == 0) {
               int var53 = var2 - 109 + this.field_654 + this.field_655;
               int var10003 = var3 - var7;
               var5 = var4 - var8;
               var4 = var10003;
               var3 = var53;
               class_21 var14 = field_552;
               field_552.method_101(var1, var3, var4, var5, 0, 0, 0);
            } else {
               class_21 var48 = field_552;
               int var54 = var2 - 109 + this.field_654 + this.field_655;
               int var60 = var3 - var7 + field_552.method_91(var2 - 109 + this.field_654 + this.field_655);
               var5 = var4 - var8;
               var4 = var60;
               var3 = var54;
               var48.method_101(var1, var3, var4, var5, 1, 0, 0);
            }
         } else if (var2 >= 159 && var2 <= 178) {
            int var18 = var2 - 159;
            if (var13 == 0) {
               class_21 var10000 = field_550[1];
               int var10002 = var3 - var7;
               var5 = var4 - var8;
               var4 = var10002;
               var10000.method_101(var1, var18, var4, var5, 0, 0, 0);
            } else {
               class_21 var47 = field_550[1];
               int var52 = var3 - var7 + field_550[1].method_91(var18);
               var5 = var4 - var8;
               var4 = var52;
               var47.method_101(var1, var18, var4, var5, 1, 0, 0);
            }
         }

         method_349(var1, var9, var10, var11, var12);
      }
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, java.lang.String, int, int, int) int
   private static int method_173(Graphics var0, String var1, int var2, int var3, int var4) {
      byte var5 = 0;
      field_551[0].method_116(var1, null);
      if ((var4 & 32) != 0) {
         var5 = 1;
      }

      if ((var4 & 64) != 0) {
         var5 |= 8;
      }

      if ((var4 & 16) != 0) {
         var5 |= 4;
      }

      field_551[0].method_117(var0, var1, var2, var3, var5, true);
      return var2 + class_21.field_348;
   }

   // $VF: renamed from: a (g, java.lang.String) int
   private static int method_174(class_21 var0, String var1) {
      int var2 = 0;

      for (int var3 = 0; var3 < var1.length(); var3++) {
         var2 += var0.method_118(var1.charAt(var3));
      }

      return var2;
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, java.lang.String, int, int, int, int, int, int, int, int) int
   private static int method_175(Graphics var0, String var1, int var2, int var3, int var4, int var5, int var6, int var7, int var8, int var9) {
      var2 = var0.getClipX();
      int var10 = var0.getClipY();
      int var11 = var0.getClipWidth();
      int var12 = var0.getClipHeight();
      method_349(var0, var5, var6, var7 - var5, var8 - var6);
      byte var16 = 0;
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

      class_21 var10000 = field_551[0];
      var8 = var7 - var5;
      short[] var15 = var10000.method_114(var1, var8, false);
      field_551[0].method_115(var0, var1, var15, var3, var4, 0, -1, var16, -1);
      int var13 = var4 + (field_551[0].method_112() + 1) * var15[0];
      method_349(var0, var2, var10, var11, var12);
      return var13 - var4;
   }

   // $VF: renamed from: a (java.lang.String) boolean
   private static boolean method_176(String var0) {
      try {
         return method_367(var0) != null;
      } catch (Exception var1) {
         return false;
      }
   }

   // $VF: renamed from: a (java.lang.String, byte[]) boolean
   private static boolean method_177(String var0, byte[] var1) {
      try {
         method_368(var0, var1, 0, var1.length);
         return true;
      } catch (Exception var2) {
         return false;
      }
   }

   // $VF: renamed from: b (java.lang.String, byte[]) boolean
   private static boolean method_178(String var0, byte[] var1) {
      try {
         byte[] var10000 = method_367(var0);
         int var2 = var1.length;
         boolean var4 = false;
         boolean var5 = false;
         System.arraycopy(var10000, 0, var1, 0, var2);
         return true;
      } catch (Exception var3) {
         return false;
      }
   }

   // $VF: renamed from: a (java.lang.String, java.lang.String, int) boolean
   private boolean method_179(String var1, String var2, int var3) {
      if (!method_176(var1)) {
         return false;
      } else {
         return !method_178(var1, this.field_687) ? false : method_177(var2, this.field_687);
      }
   }

   // $VF: renamed from: a (boolean) boolean
   private boolean method_180(boolean var1) {
      String var5;
      if (var1) {
         var5 = class_0.field_10[this.field_607];
      } else {
         var5 = class_0.field_9[this.field_607];
      }

      int var2 = 0;

      for (int var3 = 2; var3 < 25; var3++) {
         byte[] var10000;
         int var10001;
         byte var10002;
         label80: {
            if (this.field_620[var3].field_141 <= 0 && this.field_620[var3].field_130 && this.field_620[var3].field_151 < 2500) {
               var10000 = this.field_687;
               var10001 = var2++;
            } else {
               var10000 = this.field_687;
               var10001 = var2++;
               if (this.field_620[var3].field_130) {
                  var10002 = 1;
                  break label80;
               }
            }

            var10002 = 0;
         }

         var10000[var10001] = var10002;
         this.field_687[var2++] = this.field_620[var3].field_139;
         this.field_687[var2++] = this.field_620[var3].field_131;
         this.field_687[var2++] = this.field_620[var3].field_132;
         this.field_687[var2++] = this.field_620[var3].field_138;
         this.field_687[var2++] = this.field_620[var3].field_135;
         this.field_687[var2++] = this.field_620[var3].field_136;
         this.field_687[var2++] = this.field_620[var3].field_141;
      }

      for (int var13 = 0; var13 < this.field_640; var13++) {
         this.field_687[var2++] = (byte)(this.field_641[var13].field_79 ? 1 : 0);

         for (int var4 = 0; var4 < this.field_641[var13].field_83; var4++) {
            this.field_687[var2++] = (byte)(this.field_641[var13].field_82[var4].field_155 ? 1 : 0);
         }
      }

      for (int var14 = 0; var14 < this.field_656; var14++) {
         this.field_687[var2++] = (byte)(this.field_657[var14].field_323 ? 1 : 0);
      }

      return method_177(var5, this.field_687);
   }

   // $VF: renamed from: b (boolean) boolean
   private boolean method_181(boolean var1) {
      String var2;
      if (var1) {
         var2 = class_0.field_10[this.field_607];
      } else {
         var2 = class_0.field_9[this.field_607];
      }

      if (!method_178(var2, this.field_687)) {
         return this.method_180(var1);
      } else {
         int var9 = 0;

         for (int var3 = 2; var3 < 25; var3++) {
            if (this.field_687[var9] != 0) {
               class_15 var7 = this.method_197(this.field_687[var9 + 1], this.field_687[var9 + 2], this.field_687[var9 + 3], this.field_687[var9 + 4]);
               this.method_242(var7, this.field_687[var9 + 5]);
               var7.field_136 = this.field_687[var9 + 6];
               int var6 = this.field_687[var9 + 7] - var7.field_142;
               this.method_261(var7, var6, true);
               if (var7.field_139 == 3) {
                  this.field_621 = var7;
               } else if (var7.field_139 == 5) {
                  this.field_623 = var7;
               } else if (var7.field_139 == 7) {
                  this.field_622 = var7;
               } else if (var7.field_139 == 10) {
                  this.field_624 = var7;
               }
            }

            var9 += 8;
         }

         for (int var10 = 0; var10 < this.field_640; var10++) {
            this.field_641[var10].field_79 = this.field_687[var9++] != 0;

            for (int var8 = 0; var8 < this.field_641[var10].field_83; var8++) {
               this.field_641[var10].field_82[var8].field_155 = this.field_687[var9++] != 0;
            }
         }

         for (int var11 = 0; var11 < this.field_656; var11++) {
            this.field_657[var11].field_323 = this.field_687[var9++] != 0;
         }

         return true;
      }
   }

   // $VF: renamed from: b () boolean
   final boolean method_182() {
      try {
         int var1 = 0;
         var1++;
         this.field_687[0] = this.field_607;
         var1++;
         this.field_687[1] = (byte)(this.field_586 ? 1 : 0);

         for (int var2 = 0; var2 < 4; var2++) {
            this.field_687[var1++] = (byte)(this.field_608[var2] ? 1 : 0);
         }

         this.field_687[var1++] = (byte)(this.field_703 ? 1 : 0);
         this.field_687[var1++] = (byte)(this.field_704 ? 1 : 0);
         this.field_687[var1++] = this.field_709[0];
         this.field_687[var1++] = this.field_709[1];
         this.field_687[var1++] = this.field_709[2];
         this.field_687[var1++] = (byte)(this.field_710 ? 1 : 0);
         this.field_687[var1++] = (byte)(this.field_711 ? 1 : 0);
         this.field_687[var1++] = (byte)(this.field_712 ? 1 : 0);
         this.field_687[var1++] = (byte)(this.field_713 ? 1 : 0);
         this.field_687[var1++] = (byte)(this.field_714 ? 1 : 0);
         this.field_687[var1++] = (byte)(this.field_715 ? 1 : 0);
         this.field_687[var1++] = this.field_716;
         this.field_687[var1++] = this.field_717;
         this.field_687[var1++] = this.field_718;
         this.field_687[var1++] = this.field_719;
         this.field_687[var1++] = this.field_720;
         this.field_687[var1++] = this.field_722;
         this.field_687[var1++] = this.field_723;
         this.field_687[var1++] = this.field_724;
         this.field_687[var1++] = this.field_725;
         this.field_687[var1++] = this.field_591;
         this.field_687[var1++] = this.field_589.field_452.field_139;
         this.field_687[var1++] = this.field_589.field_452.field_131;
         this.field_687[var1++] = this.field_589.field_452.field_132;
         this.field_687[var1++] = this.field_589.field_452.field_138;
         this.field_687[var1++] = this.field_589.field_452.field_135;
         this.field_687[var1++] = this.field_589.field_452.field_136;
         this.field_687[var1++] = this.field_589.field_452.field_141;
         this.field_687[var1++] = this.field_589.field_455;
         this.field_687[var1++] = this.field_589.field_456;
         this.field_687[var1++] = this.field_589.field_458;
         this.field_687[var1++] = this.field_589.field_462;

         for (int var61 = 0; var61 < this.field_589.field_453; var61++) {
            this.field_687[var1++] = (byte)(this.field_589.field_454[var61].field_117 ? 1 : 0);
         }

         for (int var62 = 0; var62 < 6; var62++) {
            this.field_687[var1++] = this.field_589.field_457[var62];
         }

         this.field_687[var1++] = this.field_590.field_452.field_139;
         this.field_687[var1++] = this.field_590.field_452.field_131;
         this.field_687[var1++] = this.field_590.field_452.field_132;
         this.field_687[var1++] = this.field_590.field_452.field_138;
         this.field_687[var1++] = this.field_590.field_452.field_135;
         this.field_687[var1++] = this.field_590.field_452.field_136;
         this.field_687[var1++] = this.field_590.field_452.field_141;
         this.field_687[var1++] = this.field_590.field_455;
         this.field_687[var1++] = this.field_590.field_456;
         this.field_687[var1++] = this.field_590.field_458;
         this.field_687[var1++] = this.field_590.field_462;

         for (int var63 = 0; var63 < this.field_590.field_453; var63++) {
            this.field_687[var1++] = (byte)(this.field_590.field_454[var63].field_117 ? 1 : 0);
         }

         for (int var64 = 0; var64 < 6; var64++) {
            this.field_687[var1++] = this.field_590.field_457[var64];
         }

         this.field_687[var1++] = this.field_721;
         this.field_687[var1++] = (byte)this.field_733;
         this.field_687[var1++] = (byte)this.field_734;
         this.field_687[var1++] = (byte)(this.field_735 / 1000);
         int var117 = ++var1;
         var1++;
         this.field_687[var117] = (byte)(this.field_736 >>> 8);
         this.field_687[var1++] = (byte)this.field_736;
         this.field_687[var1++] = (byte)(this.field_737 >>> 8);
         this.field_687[var1++] = (byte)this.field_737;
         this.field_687[var1++] = (byte)(this.field_738 >>> 8);
         this.field_687[var1++] = (byte)this.field_738;
         this.field_687[var1++] = (byte)(this.field_739 >>> 8);
         this.field_687[var1] = (byte)this.field_739;
         if (!method_177("residentevil.dat", this.field_687)) {
            return false;
         }

         for (int var65 = 0; var65 < 4; var65++) {
            if (var65 != this.field_607) {
               this.method_179(class_0.field_10[var65], class_0.field_9[var65], 2048);
            }
         }
      } catch (Exception var3) {
         System.out.println("Error trying to save data");
         System.out.println(var3.getMessage());
      }

      return this.method_180(false);
   }

   // $VF: renamed from: d () boolean
   private boolean method_183() {
      if (!method_178("residentevil.dat", this.field_687)) {
         this.method_194();
         return false;
      } else {
         field_594 = 384;
         int var1 = 0;
         var1++;
         this.field_607 = this.field_687[0];
         var1++;
         this.field_586 = this.field_687[1] != 0;

         for (int var2 = 0; var2 < 4; var2++) {
            this.field_608[var2] = this.field_687[var1++] != 0;
         }

         if (this.field_687[var1++] == 1) {
            this.field_703 = true;
         } else {
            this.field_703 = false;
         }

         if (this.field_687[var1++] == 1) {
            this.field_704 = true;
         } else {
            this.field_704 = false;
         }

         this.field_709[0] = this.field_687[var1++];
         this.field_709[1] = this.field_687[var1++];
         this.field_709[2] = this.field_687[var1++];
         if (this.field_687[var1++] == 1) {
            this.field_710 = true;
         } else {
            this.field_710 = false;
         }

         if (this.field_687[var1++] == 1) {
            this.field_711 = true;
         } else {
            this.field_711 = false;
         }

         if (this.field_687[var1++] == 1) {
            this.field_712 = true;
         } else {
            this.field_712 = false;
         }

         if (this.field_687[var1++] == 1) {
            this.field_713 = true;
         } else {
            this.field_713 = false;
         }

         if (this.field_687[var1++] == 1) {
            this.field_714 = true;
         } else {
            this.field_714 = false;
         }

         if (this.field_687[var1++] == 1) {
            this.field_715 = true;
         } else {
            this.field_715 = false;
         }

         this.field_716 = this.field_687[var1++];
         this.field_717 = this.field_687[var1++];
         this.field_718 = this.field_687[var1++];
         this.field_719 = this.field_687[var1++];
         this.field_720 = this.field_687[var1++];
         this.field_722 = this.field_687[var1++];
         this.field_723 = this.field_687[var1++];
         this.field_724 = this.field_687[var1++];
         this.field_725 = this.field_687[var1++];
         this.method_215(2, 384);
         this.method_128();
         this.field_591 = this.field_687[var1++];
         this.method_197(this.field_687[var1], this.field_687[var1 + 1], this.field_687[var1 + 2], this.field_687[var1 + 3]);
         this.method_242(this.field_589.field_452, this.field_687[var1 + 4]);
         this.field_589.field_452.field_136 = this.field_687[var1 + 5];
         this.method_261(this.field_589.field_452, this.field_687[var1 + 6] - this.field_589.field_452.field_142, false);
         int var26 = var1 + 7;
         this.field_589.field_455 = this.field_687[var26++];
         this.field_589.field_456 = this.field_687[var26++];
         this.field_589.field_458 = this.field_687[var26++];
         this.field_589.field_462 = this.field_687[var26++];

         for (int var48 = 0; var48 < this.field_589.field_453; var48++) {
            this.field_589.field_454[var48].field_117 = this.field_687[var26++] != 0;
         }

         for (int var49 = 0; var49 < 6; var49++) {
            this.field_589.field_457[var49] = this.field_687[var26++];
         }

         this.method_197(this.field_687[var26], this.field_687[var26 + 1], this.field_687[var26 + 2], this.field_687[var26 + 3]);
         this.method_242(this.field_590.field_452, this.field_687[var26 + 4]);
         this.method_242(this.field_590.field_452, 0);
         this.field_590.field_452.field_136 = this.field_687[var26 + 5];
         this.method_261(this.field_590.field_452, this.field_687[var26 + 6] - this.field_590.field_452.field_142, false);
         int var31 = var26 + 7;
         this.field_590.field_455 = this.field_687[var31++];
         this.field_590.field_456 = this.field_687[var31++];
         this.field_590.field_458 = this.field_687[var31++];
         this.field_590.field_462 = this.field_687[var31++];

         for (int var50 = 0; var50 < this.field_590.field_453; var50++) {
            this.field_590.field_454[var50].field_117 = this.field_687[var31++] != 0;
         }

         for (int var51 = 0; var51 < 6; var51++) {
            this.field_590.field_457[var51] = this.field_687[var31++];
         }

         this.field_721 = this.field_687[var31++];
         this.field_733 = (short)this.field_687[var31++];
         this.field_734 = (short)this.field_687[var31++];
         this.field_735 = (this.field_687[var31++] & 255) * 1000;
         int var87 = ++var31;
         var31++;
         this.field_736 = this.field_687[var87];
         this.field_736 = this.field_736 << 8 | this.field_687[var31++];
         this.field_737 = this.field_687[var31++];
         this.field_737 = this.field_737 << 8 | this.field_687[var31++];
         this.field_738 = this.field_687[var31++];
         this.field_738 = this.field_738 << 8 | this.field_687[var31++];
         this.field_739 = this.field_687[var31++];
         this.field_739 = this.field_739 << 8 | this.field_687[var31];
         if (this.field_591 == 1) {
            this.field_587 = this.field_589;
            this.field_588 = this.field_590;
         } else {
            this.field_587 = this.field_590;
            this.field_588 = this.field_589;
         }

         if (this.field_587.field_462 != this.field_588.field_462) {
            this.field_588.field_452.field_130 = false;
         }

         for (int var52 = 0; var52 < 4; var52++) {
            this.method_179(class_0.field_9[var52], class_0.field_10[var52], 2048);
         }

         if (!this.method_181(false)) {
            this.method_194();
            return false;
         } else {
            this.method_266();
            this.method_214(false);
            this.method_233(this.field_587.field_452, true);
            return true;
         }
      }
   }

   // $VF: renamed from: e () boolean
   private boolean method_184() {
      this.field_687[1] = (byte)(field_474 ? 1 : 0);
      this.field_687[3] = (byte)(this.field_584 ? 1 : 0);
      this.field_687[0] = (byte)(field_477 ? 1 : 0);
      this.field_687[2] = (byte)(field_476 ? 1 : 0);
      return method_177("options.dat", this.field_687);
   }

   // $VF: renamed from: a (int) java.lang.String
   static String method_185(int var0) {
      return method_361(var0);
   }

   // $VF: renamed from: a (p) byte
   final byte method_186(class_15 var1) {
      return this.field_673[var1.field_131][var1.field_132];
   }

   // $VF: renamed from: a (boolean) void
   final void method_187(boolean var1) {
      int var2;
      int var3;
      int var4;
      int var5;
      int var6;
      short var7;
      if (this.field_716 == 0) {
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
         if (this.field_716 == 0) {
            if (this.field_588.field_452.field_131 >= 66
               && this.field_588.field_452.field_131 <= 68
               && this.field_588.field_452.field_132 >= 15
               && this.field_588.field_452.field_132 <= 17) {
               var1i = this.field_588.field_452.field_131 - var2;
               var2 = this.field_588.field_452.field_132 - var3;
               this.field_588.field_452.field_131 = (byte)(var4 + var1i);
               this.field_588.field_452.field_132 = (byte)(var5 + var2);
               this.field_588.field_452.field_130 = true;
               this.field_588.field_462 = (byte)var6;
            }
         } else if (this.field_588.field_452.field_131 >= 44
            && this.field_588.field_452.field_131 <= 46
            && this.field_588.field_452.field_132 >= 2
            && this.field_588.field_452.field_132 <= 4) {
            var1i = this.field_588.field_452.field_131 - var2;
            var2 = this.field_588.field_452.field_132 - var3;
            this.field_588.field_452.field_131 = (byte)(var4 + var1i);
            this.field_588.field_452.field_132 = (byte)(var5 + var2);
            this.field_588.field_452.field_130 = true;
            this.field_588.field_462 = (byte)var6;
         }

         this.field_716 = (byte)var6;
      } else {
         if (this.field_621 != null) {
            this.field_621.field_130 = false;
         }

         if (this.field_623 != null) {
            this.field_623.field_130 = false;
         }

         if (this.field_622 != null) {
            this.field_622.field_130 = false;
         }

         if (this.field_587.field_462 == this.field_588.field_462
            && this.field_673[this.field_587.field_452.field_131][this.field_587.field_452.field_132]
               == this.field_673[this.field_588.field_452.field_131][this.field_588.field_452.field_132]) {
            var1i = this.field_588.field_452.field_131 - var2;
            var2 = this.field_588.field_452.field_132 - var3;
            this.field_588.field_452.field_131 = (byte)(var4 + var1i);
            this.field_588.field_452.field_132 = (byte)(var5 + var2);
            this.field_588.field_462 = (byte)var6;
         }

         this.method_262(var7);
         this.field_587.field_452.field_131 = (byte)var4;
         this.field_587.field_452.field_132 = (byte)var5;
         this.method_232(this.method_228(var4, var5) - field_570 / 2, (var5 + var4) * 27 - field_571 / 2);
         method_279(this.field_587.field_452, 5);
         this.method_222(var6, true);
         this.field_716 = (byte)var6;
      }
   }

   // $VF: renamed from: d (p, int) void
   private void method_188(class_15 var1, int var2) {
      byte var3;
      byte var4;
      boolean var5;
      short[][] var6;
      if (var2 == 1) {
         var3 = (byte)(var1.field_131 + 1);
         var4 = var1.field_132;
         var5 = false;
         var6 = this.field_671;
      } else if (var2 == 7) {
         var3 = var1.field_131;
         var4 = (byte)(var1.field_132 + 1);
         var5 = true;
         var6 = this.field_672;
      } else if (var2 == 5) {
         var3 = (byte)(var1.field_131 - 1);
         var4 = var1.field_132;
         var5 = false;
         var6 = this.field_671;
      } else {
         if (var2 != 3) {
            return;
         }

         var3 = var1.field_131;
         var4 = (byte)(var1.field_132 - 1);
         var5 = true;
         var6 = this.field_672;
      }

      if (this.field_673[var1.field_131][var1.field_132] != this.field_673[var3][var4]) {
         if (var1.field_139 == 11) {
            return;
         }

         if (!this.field_675 && var6[var1.field_131 > var3 ? var1.field_131 : var3][var1.field_132 > var4 ? var1.field_132 : var4] != -1) {
            return;
         }

         if ((var2 = this.method_259(var3, var4, var2)) != -1) {
            if (this.field_607 == 3 && (var2 == 20 || var2 == 21 || var2 == 22)) {
               if (var1 == this.field_589.field_452) {
                  this.method_267(true, 780, 0);
                  var1.field_133 = 0;
                  var1.field_135 = 8;
                  return;
               }

               if (var1 == this.field_623) {
                  this.method_267(true, 730, 0);
                  var1.field_131 = var3;
                  var1.field_132 = var4;
                  return;
               }
            }

            class_9 var7;
            if ((var7 = this.field_641[var2]).field_78) {
               if (var7.field_81 == var5 && var7.field_79) {
                  return;
               }
            } else if (var7.field_79) {
               return;
            }
         }
      }

      var1.field_131 = var3;
      var1.field_132 = var4;
   }

   // $VF: renamed from: a (boolean, int, int) boolean
   private boolean method_189(boolean var1, int var2, int var3) {
      if (var2 <= 0 || var3 <= 0) {
         return false;
      } else if (var1) {
         return this.field_671[var2][var3] == -1 ? false : this.field_673[var2][var3] == this.field_673[var2 - 1][var3];
      } else {
         return this.field_672[var2][var3] == -1 ? false : this.field_673[var2][var3] == this.field_673[var2][var3 - 1];
      }
   }

   // $VF: renamed from: b (int, int, int) void
   final void method_190(int var1, int var2, int var3) {
      this.field_641[var1].field_76 = (byte)var2;
      this.field_641[var1].field_77 = (byte)var3;
      this.field_641[var1].field_84 = (short)this.method_228(this.field_641[var1].field_76, this.field_641[var1].field_77);
      class_9 var10000 = this.field_641[var1];
      byte var5 = this.field_641[var1].field_77;
      byte var4 = this.field_641[var1].field_76;
      var10000.field_85 = (short)((var5 + var4) * 27);
   }

   // $VF: renamed from: e () void
   final void method_191() {
      if ((~this.field_723 & 7) == 0) {
         this.method_262(174);
         this.method_263(21);
         this.method_262(291);
         this.method_263(7);
         byte var2 = 107;
         this.method_286(0, 2, method_361(107), 0);
      } else {
         byte var1 = 98;
         this.method_286(0, 2, method_361(98), 0);
      }
   }

   // $VF: renamed from: D () void
   private void method_192() {
      byte var3 = this.field_673[35][27];

      for (int var1 = 0; var1 < this.field_668; var1++) {
         for (int var2 = 0; var2 < this.field_669; var2++) {
            if (this.field_673[var1][var2] == var3) {
               if (this.field_670[var1][var2] != 5 && this.field_670[var1][var2] != 6 && this.field_670[var1][var2] != 16) {
                  this.field_670[var1][var2] = 10;
               }

               if (this.method_189(true, var1, var2)) {
                  this.field_671[var1][var2] = 2827;
               }

               if (this.method_189(false, var1, var2)) {
                  this.field_672[var1][var2] = 2827;
               }
            }
         }
      }
   }

   // $VF: renamed from: f () void
   final void method_193() {
      byte[] var4 = null;
      if (this.field_607 == 0) {
         var4 = method_217("/8", 0);
      }

      if (this.field_607 == 1) {
         var4 = method_217("/9", 0);
      }

      if (this.field_607 == 2) {
         var4 = method_217("/10", 0);
      }

      if (this.field_607 == 3) {
         var4 = method_217("/11", 0);
      }

      if (var4 != null) {
         byte var3 = 0;
         int var11 = var3 + 2;

         for (int var1 = 0; var1 < this.field_668; var1++) {
            for (int var2 = 0; var2 < this.field_669; var2++) {
               this.field_670[var1][var2] = var4[var11++];
            }
         }

         for (int var5 = 0; var5 < this.field_668; var5++) {
            for (int var8 = 0; var8 < this.field_669; var8++) {
               this.field_672[var5][var8] = (short)((var4[var11++] & 255) << 8);
               this.field_672[var5][var8] = (short)(this.field_672[var5][var8] | (short)(var4[var11++] & 255));
            }
         }

         for (int var6 = 0; var6 < this.field_668; var6++) {
            for (int var9 = 0; var9 < this.field_669; var9++) {
               this.field_671[var6][var9] = (short)((var4[var11++] & 255) << 8);
               this.field_671[var6][var9] = (short)(this.field_671[var6][var9] | (short)(var4[var11++] & 255));
            }
         }

         for (int var7 = 0; var7 < this.field_668; var7++) {
            for (int var10 = 0; var10 < this.field_669; var10++) {
               this.field_673[var7][var10] = var4[var11++];
            }
         }
      }
   }

   // $VF: renamed from: E () void
   private void method_194() {
      this.field_750 = true;
      this.field_607 = 0;
      this.field_586 = false;

      for (int var1 = 0; var1 < 4; var1++) {
         this.field_608[var1] = false;
      }

      this.method_215(2, 384);
      this.method_196();
      this.method_128();
      this.field_589.field_456 = 0;
      this.method_293((byte)0, (byte)1);
      this.method_293((byte)field_543[0], (byte)1);
      this.field_589.field_455 = 0;
      this.field_589.field_458 = 0;
      this.field_589.field_457[0] = 0;
      this.field_589.field_457[1] = 20;
      this.field_589.field_457[2] = 6;
      this.field_589.field_457[3] = 10;
      this.field_589.field_457[4] = 4;
      this.field_589.field_457[5] = 0;
      this.field_587 = this.field_589;
      this.field_588 = this.field_590;
      this.field_591 = 1;
      this.field_587.field_462 = 0;
      this.field_588.field_462 = 0;
      this.field_590.field_456 = 0;
      this.method_293((byte)0, (byte)2);
      this.method_293((byte)field_543[0], (byte)2);
      this.method_293((byte)field_543[1], (byte)2);
      this.field_590.field_455 = 0;
      this.field_590.field_458 = 1;
      this.field_590.field_457[0] = 0;
      this.field_590.field_457[1] = 20;
      this.field_590.field_457[2] = 6;
      this.field_590.field_457[3] = 10;
      this.field_590.field_457[4] = 4;
      this.field_590.field_457[5] = 0;
      this.field_733 = 0;
      this.field_734 = 0;
      this.field_735 = 0;
      this.field_736 = 0;
      this.field_737 = 0;
      this.field_738 = 0;
      this.field_739 = 0;
      this.field_740 = 0;
      this.field_741 = 0;
      field_749 = true;
      this.field_590.field_452.field_131 = 10;
      this.field_590.field_452.field_132 = 10;
      field_554 = false;
      field_780 = false;
   }

   // $VF: renamed from: f () boolean
   private boolean method_195() {
      this.field_581 = false;
      field_580 = false;
      this.field_574 = System.currentTimeMillis();
      this.setFullScreenMode(true);
      field_568 = 360;
      field_569 = 640;
      field_570 = field_568 / 2;
      field_571 = field_569 / 2;
      this.field_610 = 0;
      this.field_607 = 0;
      method_327();
      this.field_575 = 20;
      this.field_582 = false;
      this.field_583 = false;
      this.field_584 = true;
      field_580 = false;
      this.field_676 = 0;
      this.field_677 = 0;
      this.field_678 = (short)field_568;
      this.field_679 = (short)field_569;
      this.field_578 = 0;
      this.field_579 = class_0.field_3[0];
      this.field_595 = 0;
      this.field_567 = field_788;

      for (int var1 = 0; var1 < 5; var1++) {
         this.field_628[var1] = new class_25(this);
      }

      for (int var6 = 0; var6 < 10; var6++) {
         this.field_629[var6] = new class_22(this);
      }

      this.field_687 = new byte[2048];

      try {
         field_503 = new ByteArrayInputStream[52];
         field_504 = new String[52];
         field_502 = new Player[52];

         try {
            method_334("/2");

            for (int var7 = 0; var7 < 52; var7++) {
               byte[] var2 = method_332(var7);
               field_503[var7] = new ByteArrayInputStream(var2);
               field_504[var7] = var2.length == 0
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
               System.out.println("s_soundType[i] = " + field_504[var7]);
               if ((var7 == 27 || var7 == 7 || var7 == 31 || var7 == 33 || var7 == 14 || var7 == 41 || var7 == 40 || var7 == 22) && field_504[var7] != "dummy") {
                  System.out.println("!!!!!!!!!!!!!!!!!!!  s_soundType[i] = " + field_504[var7]);
                  field_502[var7] = Manager.createPlayer(field_503[var7], field_504[var7]);
                  field_502[var7].realize();
                  field_502[var7].prefetch();
               }
            }

            method_336();
         } catch (Exception var3) {
            System.out.println(var3);
         }
      } catch (Exception var4) {
      }

      method_336();
      method_334("/1");
      short[] var8 = (short[])method_343(2);
      field_551[1] = method_313(1, true, true);
      field_551[1].method_109(var8);
      field_551[1].method_119(0);
      method_336();
      method_334("/4");
      field_556[0] = method_313(0, true, true);
      field_556[1] = method_313(1, true, true);
      method_336();
      field_557 = new class_11(field_556[1], 0, 0);
      method_334("/7");
      field_769 = method_313(4, true, true);
      class_11.method_13(field_568, field_569, 54, 27);
      method_313(5, true, true);
      (field_553 = new class_11(field_556[1], 0, 0)).method_5(1, -1);
      method_336();
      this.field_587 = this.field_589;
      this.field_588 = this.field_590;
      this.field_584 = true;
      boolean var10000;
      if (!method_178("options.dat", this.field_687)) {
         var10000 = this.method_184();
      } else {
         field_474 = this.field_687[1] == 1;
         field_477 = this.field_687[0] == 1;
         field_476 = this.field_687[2] == 1;
         this.field_584 = this.field_687[3] != 0;
         var10000 = true;
      }

      if (!var10000) {
         return true;
      } else if (!this.method_184()) {
         return true;
      } else {
         this.method_196();
         this.method_215(3, 129);
         method_334("/5");
         short var10 = 1;
         byte[] var5;
         field_560 = Image.createImage(var5 = method_332(1), 0, var5.length);
         method_336();
         class_21 var12 = field_551[0];
         var10 = 265;
         String var9 = method_361(265);
         var12.method_116(var9, null);
         field_561 = 180 + class_21.field_348 / 2 + 5;
         class_17.method_40(GloftRESE.field_861, field_808, field_793, field_794);
         field_558 = class_17.method_47();
         field_559 = class_17.method_50();
         return true;
      }
   }

   // $VF: renamed from: F () void
   private void method_196() {
      this.field_680 = 0;
      this.field_691 = false;
      this.field_675 = false;
      this.field_725 = 0;
      this.field_709[0] = -1;
      this.field_709[1] = -1;
      this.field_709[2] = -1;
      this.field_710 = false;
      this.field_711 = false;
      this.field_722 = 0;
      this.field_723 = 0;
      this.field_724 = 0;
      this.field_712 = false;
      this.field_713 = false;
      this.field_714 = false;
      this.field_715 = true;
      this.field_716 = -1;
      this.field_717 = 0;
      this.field_718 = 0;
      this.field_719 = 0;
      this.field_720 = 0;
      this.field_721 = 0;
      this.field_726 = -1;
      this.field_727 = 0;
      this.field_728 = 0;
      this.field_729 = 0;
      this.field_731 = 4;
      this.field_730 = this.field_731;
   }

   // $VF: renamed from: a (int, int, int, int) p
   final class_15 method_197(int var1, int var2, int var3, int var4) {
      int var5 = 5;

      while (var5 < 25 && this.field_620[var5].field_130 && this.field_620[var5].field_141 > 0) {
         var5++;
      }

      if (var5 >= 25) {
         return null;
      } else {
         class_15 var9;
         switch (var1) {
            case 0:
               var9 = this.field_620[0];
               break;
            case 1:
               var9 = this.field_620[1];
               break;
            case 2:
            case 4:
            case 6:
            case 7:
            case 8:
            case 9:
            default:
               var9 = this.field_620[var5];
               break;
            case 3:
               var9 = this.field_620[2];
               this.field_621 = var9;
               break;
            case 5:
               var9 = this.field_620[3];
               this.field_623 = var9;
               break;
            case 10:
               var9 = this.field_620[4];
               this.field_624 = var9;
         }

         var9.field_130 = true;
         var9.field_139 = (byte)var1;
         var9.field_131 = (byte)var2;
         var9.field_132 = (byte)var3;
         var9.field_133 = 0;
         var9.field_134 = 0;
         var9.field_135 = 0;
         var9.field_136 = -1;
         var9.field_137 = 0;
         var9.field_143 = -1;
         var9.field_144 = -1;
         var9.field_145 = false;
         var9.field_146 = false;
         var9.field_147 = false;
         var9.field_148 = 0L;
         var9.field_149 = 0L;
         var9.field_140 = 127;
         var9.field_150 = false;
         byte var6;
         byte var7;
         byte var8;
         switch (var9.field_139) {
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
               var9.field_140 = 10;
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
               var8 = 0;
         }

         var9.field_141 = var6;
         var9.field_142 = var7;
         var9.field_151 = 2500;
         this.method_242(var9, var8);
         method_279(var9, var4);
         return var9;
      }
   }

   // $VF: renamed from: o (int) void
   private void method_198(int var1) {
      this.method_199(var1, this.field_591);
   }

   // $VF: renamed from: a (int, int) void
   final void method_199(int var1, int var2) {
      class_26 var3 = var2 == 1 ? this.field_589 : this.field_590;
      if (var1 == 127) {
         var3.field_452.field_140 = 127;
      } else {
         var3.field_458 = (byte)((var1 + 6) % 6);
         if (this.field_587.field_452.field_139 == 0) {
            this.field_587.field_452.field_140 = (byte)(0 + this.field_587.field_458);
         } else if (this.field_587.field_452.field_139 == 1) {
            this.field_587.field_452.field_140 = (byte)(5 + this.field_587.field_458);
         }

         if (var1 == 5) {
            var3.field_452.field_140 = 127;
         }

         if (this.method_209()) {
            this.method_242(var3.field_452, 8);
         }
      }
   }

   // $VF: renamed from: c (int) void
   final void method_200(int var1) {
      byte var2 = this.field_673[this.field_587.field_452.field_131][this.field_587.field_452.field_132];
      byte var3 = this.field_607;
      if (var1 == 1) {
         this.field_587 = this.field_589;
         this.field_588 = this.field_590;
         this.field_591 = 1;
         if (this.field_590.field_462 != this.field_589.field_462) {
            this.field_590.field_452.field_130 = false;
         }
      } else {
         this.field_587 = this.field_590;
         this.field_588 = this.field_589;
         this.field_591 = 2;
         if (this.field_590.field_462 != this.field_589.field_462) {
            this.field_589.field_452.field_130 = false;
         }
      }

      this.field_587.field_452.field_130 = true;
      if (var3 != this.field_587.field_462) {
         this.field_767 = 2;
         this.field_471 = true;
         this.method_222(this.field_587.field_462, true);
      } else if (var2 != this.field_673[this.field_587.field_452.field_131][this.field_587.field_452.field_132]) {
         this.method_214(true);
      }

      if (var3 == this.field_587.field_462) {
         this.method_233(this.field_587.field_452, true);
      }
   }

   // $VF: renamed from: g () boolean
   private boolean method_201() {
      if (field_618 == 0
         || field_618 == 1
         || field_617 == 120 && field_618 == 3
         || field_617 == 70 && field_618 == 3
         || this.field_607 == 3
         || this.field_587.field_452.field_135 != 0) {
         return false;
      } else {
         return field_594 != 384 ? false : this.field_574 - this.field_742 >= 1000L;
      }
   }

   // $VF: renamed from: c (p) boolean
   private static boolean method_202(class_15 var0) {
      return var0.field_139 == 0 || var0.field_139 == 1 || var0.field_139 == 3 || var0.field_139 == 5 || var0.field_139 == 7 || var0.field_139 == 10;
   }

   // $VF: renamed from: a (p) boolean
   static boolean method_203(class_15 var0) {
      return field_541[var0.field_139][var0.field_135][2] != 0;
   }

   // $VF: renamed from: b (p) boolean
   final boolean method_204(class_15 var1) {
      if (var1.field_148 == this.field_574) {
         return false;
      } else {
         return var1.field_143 < 0 || var1.field_144 < 0 ? true : var1.field_131 == var1.field_143 && var1.field_132 == var1.field_144;
      }
   }

   // $VF: renamed from: a (p, int, int) boolean
   private boolean method_205(class_15 var1, int var2, int var3) {
      int var4;
      return (var4 = method_170(var1.field_138 - var2)) <= 1 || var4 >= 7;
   }

   // $VF: renamed from: a (int, int, int, int, int) int
   final int method_206(int var1, int var2, int var3, int var4, int var5) {
      int var6 = 0;

      while (var6 < 5 && this.field_628[var6].field_442) {
         var6++;
      }

      if (var6 >= 5) {
         return var6;
      } else {
         method_207(
            this.field_628[var6], true, (short)(this.method_228(var2, var3) + var4), (short)((var3 + var2) * 27 + var5), (byte)var1, (byte)var2, (byte)var3
         );
         return var6;
      }
   }

   // $VF: renamed from: a (ab, boolean, short, short, byte, byte, byte) void
   private static void method_207(class_25 var0, boolean var1, short var2, short var3, byte var4, byte var5, byte var6) {
      var0.field_442 = var1;
      var0.field_443 = true;
      var0.field_447 = var2;
      var0.field_448 = var3;
      var0.field_449 = 0;
      var0.field_444 = var4;
      var0.field_450 = 0;
      var0.field_451 = 0;
      var0.field_445 = var5;
      var0.field_446 = var6;
   }

   // $VF: renamed from: a (int, int, int, int, int, byte) int
   final int method_208(int var1, int var2, int var3, int var4, int var5, byte var6) {
      int var7 = 0;

      while (var7 < 10 && this.field_629[var7].field_425) {
         var7++;
      }

      if (var7 >= 0 && var7 < 10) {
         class_22 var8;
         class_25 var9 = (var8 = this.field_629[var7]).field_426;
         var8.field_425 = true;
         var8.field_428 = (byte)var1;
         var8.field_427 = this.field_574;
         var8.field_434 = var6;
         method_207(var9, false, (short)0, (short)0, var9.field_444, var9.field_445, var9.field_446);
         var8.field_435 = var4;
         var8.field_436 = var5;
         switch (var1) {
            case 4:
               var9.field_445 = (byte)var2;
               var9.field_446 = (byte)var3;
               var8.field_429 = (short)(this.method_228(var2, var3) + 54);
               var8.field_430 = (short)((var3 + var2) * 27 + 27);
               if (this.field_587.field_452.field_138 == 0) {
                  var8.field_430 = (short)(var8.field_430 + 12);
               } else if (this.field_587.field_452.field_138 == 4) {
                  var8.field_430 = (short)(var8.field_430 - 24);
               } else if (this.field_587.field_452.field_138 == 2) {
                  var8.field_429 = (short)(var8.field_429 + 40);
                  var8.field_430 = (short)(var8.field_430 - 20);
               } else if (this.field_587.field_452.field_138 == 6) {
                  var8.field_429 = (short)(var8.field_429 - 40);
                  var8.field_430 = (short)(var8.field_430 - 20);
               } else if (this.field_587.field_452.field_138 == 1) {
                  var8.field_429 = (short)(var8.field_429 + 24);
                  var8.field_430 = (short)(var8.field_430 + 4);
               } else if (this.field_587.field_452.field_138 == 7) {
                  var8.field_429 = (short)(var8.field_429 - 48);
                  var8.field_430 = (short)(var8.field_430 + 4);
               } else if (this.field_587.field_452.field_138 == 3) {
                  var8.field_429 = (short)(var8.field_429 + 32);
                  var8.field_430 = (short)(var8.field_430 - 32);
               } else if (this.field_587.field_452.field_138 == 5) {
                  var8.field_429 = (short)(var8.field_429 - 32);
                  var8.field_430 = (short)(var8.field_430 - 32);
               }
            case 5:
            case 6:
            default:
               break;
            case 7:
               var9.field_445 = (byte)var2;
               var9.field_446 = (byte)var3;
               var8.field_429 = (short)(this.method_228(var2, var3) + 54);
               var8.field_430 = (short)((var3 + var2) * 27 + 27);
               break;
            case 8:
               var9.field_445 = (byte)var2;
               var9.field_446 = (byte)var3;
               var8.field_429 = (short)(this.method_228(var2, var3) + 54);
               var8.field_430 = (short)((var3 + var2) * 27 + 27);
               if (this.field_587.field_452.field_138 == 0) {
                  var8.field_430 = (short)(var8.field_430 + 12);
               } else if (this.field_587.field_452.field_138 == 4) {
                  var8.field_430 = (short)(var8.field_430 - 24);
               } else if (this.field_587.field_452.field_138 == 2) {
                  var8.field_429 = (short)(var8.field_429 + 32);
                  var8.field_430 = (short)(var8.field_430 - 32);
               } else if (this.field_587.field_452.field_138 == 6) {
                  var8.field_429 = (short)(var8.field_429 - 32);
                  var8.field_430 = (short)(var8.field_430 - 32);
               } else if (this.field_587.field_452.field_138 == 1) {
                  var8.field_429 = (short)(var8.field_429 + 24);
                  var8.field_430 = (short)(var8.field_430 + 4);
               } else if (this.field_587.field_452.field_138 == 7) {
                  var8.field_429 = (short)(var8.field_429 - 48);
                  var8.field_430 = (short)(var8.field_430 + 4);
               } else if (this.field_587.field_452.field_138 == 3) {
                  var8.field_429 = (short)(var8.field_429 + 32);
                  var8.field_430 = (short)(var8.field_430 - 32);
               } else if (this.field_587.field_452.field_138 == 5) {
                  var8.field_429 = (short)(var8.field_429 - 32);
                  var8.field_430 = (short)(var8.field_430 - 32);
               }
         }

         switch (var1) {
            case 4:
            case 8:
               var8.field_431 = (short)(this.method_228(var4, var5) + 54);
               var8.field_432 = (short)((var5 + var4) * 27 + 27);
               int var13;
               var8.field_433 = (short)method_171((var2 = var8.field_431 - var8.field_429) * var2 + (var13 = var8.field_432 - var8.field_430) * var13);
               var9.field_442 = true;
               var9.field_444 = 2;
               break;
            case 5:
            case 6:
            default:
               var8.field_431 = var8.field_429;
               var8.field_432 = var8.field_430;
               break;
            case 7:
               var8.field_431 = (short)(this.method_228(var4, var5) + 54);
               var8.field_432 = (short)((var5 + var4) * 27 + 27);
               int var11;
               var8.field_433 = (short)method_171((var2 = var8.field_431 - var8.field_429) * var2 + (var11 = var8.field_432 - var8.field_430) * var11);
               var9.field_442 = true;
               var9.field_444 = 40;
         }

         return var7;
      } else {
         return var7;
      }
   }

   // $VF: renamed from: h () boolean
   private boolean method_209() {
      return (
            this.field_587.field_452.field_135 == 0
               || this.field_587.field_452.field_135 == 8
               || this.field_587.field_452.field_135 == 9
               || this.field_587.field_452.field_135 == 10
               || this.field_587.field_452.field_135 == 11
         )
         | (
            field_541[this.field_587.field_452.field_139][this.field_587.field_452.field_135][2] != 0
               && field_541[this.field_587.field_452.field_139][this.field_587.field_452.field_135][2] < this.field_587.field_452.field_133
               && this.field_587.field_452.field_137
                     + this.method_239(
                        field_541[this.field_587.field_452.field_139][this.field_587.field_452.field_135][1] << 8,
                        field_541[this.field_587.field_452.field_139][this.field_587.field_452.field_135][0]
                     )
                  >= 65534
         );
   }

   // $VF: renamed from: g () void
   final void method_210() {
      this.method_211(false);
   }

   // $VF: renamed from: b (boolean) void
   final void method_211(boolean var1) {
      field_752 = true;
      if (this.field_587.field_452.field_135 != 3 && this.field_587.field_452.field_135 != 4) {
         if (field_594 == 131 || field_594 == 130) {
            this.method_298((int)(this.field_574 - this.field_666));
         }

         if (this.method_212() >= 0) {
            if (field_594 == 900 || field_594 == 901) {
               return;
            }

            if (field_594 == 384 && (this.field_587.field_458 == 0 || this.field_587.field_458 == 5 || this.field_587.field_457[this.field_587.field_458] <= 0)
               )
             {
               if (this.field_587.field_457[1] <= 0) {
                  this.method_198(0);
               } else {
                  this.method_198(1);
               }
            }

            field_594 = 900;
            if (field_541[this.field_587.field_452.field_139][this.field_587.field_452.field_135][2] == 0) {
               this.method_242(this.field_587.field_452, 0);
            }

            this.method_198(this.field_587.field_458);
            this.field_587.field_455 = (byte)field_543[this.field_587.field_458];
            if (field_498 != 4 && field_617 != 50 && field_617 != 70) {
               method_153();
            }

            if (var1 && field_617 != 50 && field_617 != 70) {
               this.method_144(25);
            }

            if (this.field_587.field_458 != 0 && field_617 != 50 && field_617 != 70 || field_617 == 50 && field_618 == 0 || field_617 == 70 && field_618 == 0) {
               this.method_145(4);
               return;
            }
         } else {
            if (field_594 == 131) {
               field_594 = 384;
               return;
            }

            if (field_594 == 384) {
               return;
            }

            if ((field_594 & 512) != 0) {
               this.field_587.field_455 = 0;
            }

            field_594 = 384;
            if (field_541[this.field_587.field_452.field_139][this.field_587.field_452.field_135][2] == 0) {
               this.method_242(this.field_587.field_452, 0);
               if (this.field_587.field_452.field_138 % 2 == 0) {
                  method_279(this.field_587.field_452, this.field_587.field_452.field_138 + 1);
               }
            }

            this.method_198(127);
         }
      }
   }

   // $VF: renamed from: d () int
   private int method_212() {
      for (int var1 = 0; var1 < 25; var1++) {
         class_15 var2;
         if ((var2 = this.field_620[var1]).field_130 && var2.field_141 > 0 && var2.field_135 != 4) {
            if (var2.field_139 == 5 && this.field_609 == this.field_673[var2.field_131][var2.field_132] && !var2.field_150) {
               return this.field_620[var1].field_139;
            }

            if (!method_202(var2) && this.field_609 == this.field_673[var2.field_131][var2.field_132] && !var2.field_150) {
               return this.field_620[var1].field_139;
            }
         }
      }

      return -1;
   }

   // $VF: renamed from: h () void
   final void method_213() {
      this.method_214(true);
   }

   // $VF: renamed from: d (boolean) void
   private void method_214(boolean var1) {
      class_27 var2 = this;

      for (int var3 = 0; var3 < 5; var3++) {
         var2.field_628[var3].field_442 = false;
      }

      for (int var24 = 0; var24 < 10; var24++) {
         var2.field_629[var24].field_425 = false;
      }

      this.field_609 = this.field_673[this.field_587.field_452.field_131][this.field_587.field_452.field_132];
      this.field_599 = 65536;
      this.field_600 = 65536;
      this.field_601 = 0;
      this.field_602 = 0;
      this.field_603 = this.field_668;
      this.field_604 = this.field_669;
      this.field_605 = 0;
      this.field_606 = 0;

      for (int var18 = 0; var18 < this.field_668; var18++) {
         for (int var25 = 0; var25 < this.field_669; var25++) {
            if (this.field_609 == this.field_673[var18][var25]) {
               int var4 = this.method_228(var18, var25);
               int var5 = (var25 + var18) * 27;
               this.field_599 = Math.min(this.field_599, var4 - 54);
               this.field_601 = Math.max(this.field_601, var4 + 54 + 108 - this.field_599);
               this.field_600 = Math.min(this.field_600, var5 - 120);
               this.field_602 = Math.max(this.field_602, var5 + 27 + 54 - this.field_600);
               this.field_603 = Math.min(this.field_603, var18);
               this.field_604 = Math.min(this.field_604, var25);
               this.field_605 = Math.max(this.field_605, var18);
               this.field_606 = Math.max(this.field_606, var25);
            }
         }
      }

      var2 = this;
      if (field_618 != 3) {
         for (int var26 = 0; var26 < var2.field_611[var2.field_609].field_326; var26++) {
            if (!var2.field_657[var2.field_611[var2.field_609].field_327[var26].field_441].field_323
               && (
                  var2.field_611[var2.field_609].field_327[var26].field_440 < 0
                     || var2.field_657[var2.field_611[var2.field_609].field_327[var26].field_440].field_323
               )) {
               var2.method_268(var2.field_657[var2.field_611[var2.field_609].field_327[var26].field_441]);
               if (!var2.field_657[var2.field_611[var2.field_609].field_327[var26].field_441].field_322) {
                  var2.field_657[var2.field_611[var2.field_609].field_327[var26].field_441].field_323 = true;
               }
            }
         }
      }

      this.method_211(var1);
      if (this.field_587.field_462 == 0
         && this.field_587.field_452.field_131 > 57
         && this.field_587.field_452.field_131 < 69
         && this.field_587.field_452.field_132 > 17
         && this.field_587.field_452.field_132 < 31) {
         this.field_702 = true;
      } else {
         this.field_702 = false;
      }

      var2 = this;
      if (this.field_609 != 0) {
         int var27 = this.field_605 - this.field_603 + 1;
         int var1i = this.field_606 - this.field_604 + 1;
         int var28;
         byte[] var31 = new byte[(var28 = var27 + var1i) * var28];
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
               int var10 = var2.method_314(var48, var8);
               if (var9 == 0) {
                  var7 = var2.method_314(var48, var8 - 1);
               } else if (var9 == 1) {
                  var7 = var2.method_314(var48 - 1, var8);
               } else if (var9 == 2) {
                  var7 = var2.method_314(var48 + 1, var8);
               } else {
                  var7 = var2.method_314(var48, var8 + 1);
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
                  var31[var11] = (byte)var9;
               } else {
                  var31[var11] = (byte)(var9 + 4);
               }

               var11++;
            }
         }

         byte var14 = 127;

         for (int var35 = var2.field_603 + 1; var35 <= var2.field_605; var35++) {
            int var43 = var2.field_604 + 1;

            while (var43 <= var2.field_606 && (var2.field_609 != var2.field_673[var35][var43] || (var14 = var2.field_670[var35][var43]) == 127)) {
               var43++;
            }

            if (var14 != 127) {
               break;
            }
         }

         field_770 = var14;
         int var15 = var14 + var2.field_654;
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
               class_21 var38 = field_552;
               field_552.method_101(var50, var15, var37, var44, 0, 0, 0);
            }

            int var39 = var52[(var55 << 2) + 2];
            var44 = var52[(var55 << 2) + 3];
            if (var39 != -1 && var44 != -1) {
               class_21 var40 = field_552;
               field_552.method_101(var50, var15, var39, var44, 0, 0, 0);
            }

            field_769.method_103(var21[var55], var55, 0);
         }

         byte[] var56;
         method_353(var56 = new byte[4], 0, (short)var28);
         method_353(var56, 2, (short)var28);
         class_11.method_15(0, var56, var31, null, field_769, true, 16, 2, 2);
      }

      int var32 = 0;
      int var41 = 0;
      int var16 = 0;
      int var29 = 0;
      int var46 = 0;
      this.field_653 = new int[this.field_640];

      for (int var22 = 0; var22 < this.field_640; var22++) {
         class_9 var53 = this.field_641[var22];
         if (this.field_609 == this.field_673[var53.field_76][var53.field_77]) {
            if (this.field_690[var53.field_75][6] == 0) {
               if (this.field_690[var53.field_75][8] == 1) {
                  var16++;
               } else {
                  var29++;
               }
            } else if (var53.field_78) {
               var32++;
            } else {
               var41++;
            }
         } else if (var53.field_78) {
            var46++;
         }
      }

      field_642 = 0;
      field_647 = field_652 = (
            field_646 = field_651 = (field_645 = field_650 = (field_644 = field_649 = (field_643 = field_648 = var32 + 0) + var41) + var16) + var29
         )
         + var46;
      int var33 = 0;
      int var42 = 0;
      int var17 = 0;
      int var30 = 0;
      int var47 = 0;
      int var51 = 0;

      for (int var23 = 0; var23 < this.field_640; var23++) {
         class_9 var54 = this.field_641[var23];
         if (this.field_609 == this.field_673[var54.field_76][var54.field_77]) {
            if (this.field_690[var54.field_75][6] == 0) {
               if (this.field_690[var54.field_75][8] == 1) {
                  this.field_653[field_644 + var17++] = var23;
               } else {
                  this.field_653[field_645 + var30++] = var23;
               }
            } else if (var54.field_78) {
               this.field_653[0 + var33++] = var23;
            } else {
               this.field_653[field_643 + var42++] = var23;
            }
         } else if (var54.field_78) {
            this.field_653[field_646 + var47++] = var23;
         } else {
            this.field_653[field_647 + var51++] = var23;
         }
      }
   }

   // $VF: renamed from: b (int, int) void
   final void method_215(int var1, int var2) {
      if (var1 != 11 && var1 != 14) {
         this.method_147();
      }

      this.field_593 = (byte)var1;
      this.field_582 = true;
   }

   // $VF: renamed from: G () void
   private void method_216() {
      for (int var1 = 2; var1 < 25; var1++) {
         this.field_620[var1].field_130 = false;
      }

      if (this.field_589.field_454 != null) {
         for (int var2 = 0; var2 < this.field_589.field_453; var2++) {
            this.field_589.field_454[var2].field_123 = null;
            this.field_589.field_454[var2].field_122 = 0;
         }
      }

      if (this.field_590.field_454 != null) {
         for (int var3 = 0; var3 < this.field_590.field_453; var3++) {
            this.field_590.field_454[var3].field_123 = null;
            this.field_590.field_454[var3].field_122 = 0;
         }
      }

      this.field_670 = null;
      this.field_671 = null;
      this.field_672 = null;
      this.field_673 = null;
      this.field_641 = null;
      this.field_653 = null;
      this.field_611 = null;
      this.field_657 = null;
      this.field_664 = null;
   }

   // $VF: renamed from: a (java.lang.String, int) byte[]
   private static byte[] method_217(String var0, int var1) {
      if (var0 != null) {
         method_334(var0);
      }

      byte[] var2 = method_332(var1);
      if (var0 != null) {
         method_336();
      }

      return var2;
   }

   // $VF: renamed from: p (int) void
   private void method_218(int var1) {
      boolean var7 = true;
      byte[] var8 = method_332(1);
      int var2 = 0;
      int var3 = ((var8[0] & 255) << 8 | var8[1] & 255) / 13;
      int var13 = var2 + 2;
      this.field_690 = new short[var3][];

      for (int var4 = 0; var4 < var3; var4++) {
         this.field_690[var4] = new short[9];
         short[] var10000 = this.field_690[var4];
         int var6 = var13 + 1;
         var10000[0] = (short)(((var8[var13] & 255) << 8 | var8[var6] & 255) * 3 / 2);
         var2 = var13 + 2;
         var10000 = this.field_690[var4];
         var6 = var2 + 1;
         var10000[1] = (short)(((var8[var2] & 255) << 8 | var8[var6] & 255) * 3 / 2);
         var2 += 2;
         var10000 = this.field_690[var4];
         var6 = var2 + 1;
         var10000[2] = (short)((var8[var2] & 255) << 8 | var8[var6] & 255);
         var2 += 2;
         var10000 = this.field_690[var4];
         var6 = var2 + 1;
         var10000[3] = (short)((var8[var2] & 255) << 8 | var8[var6] & 255);
         var13 = var2 + 2;
         this.field_690[var4][4] = (short)var8[var13++];
         this.field_690[var4][5] = (short)var8[var13++];
         this.field_690[var4][6] = (short)var8[var13++];
         this.field_690[var4][7] = (short)var8[var13++];
         this.field_690[var4][8] = (short)var8[var13++];
      }
   }

   // $VF: renamed from: i () boolean
   private boolean method_219() {
      this.field_689 = null;
      if (field_751 == this.field_607) {
         field_495 = true;
      } else {
         field_495 = false;
         field_751 = this.field_607;
      }

      if (!field_495) {
         this.field_690 = null;
      }

      byte var2 = 3;
      class_27 var1 = this;
      method_334("/7");
      var2 = 3;
      byte[] var4 = method_332(3);
      int var5 = 0;
      method_336();
      int var6 = ((var4[0] & 255) << 8 | var4[1] & 255) / 2;
      int var32 = var5 + 2;
      this.field_689 = new byte[var6 << 1];

      for (int var7 = 0; var7 < var6; var7++) {
         var1.field_689[var7 << 1] = var4[var32++];
         var1.field_689[(var7 << 1) + 1] = var4[var32++];
      }

      if (this.field_607 == 0) {
         if (!field_495) {
            method_334("/8");
            this.method_218(1);
            field_552 = method_313(2, true, true);
            this.field_654 = 72;
            this.field_655 = 13;
         }
      } else if (this.field_607 == 1) {
         if (!field_495) {
            method_334("/9");
            this.method_218(1);
            field_552 = method_313(2, true, true);
            this.field_654 = 57;
            this.field_655 = 19;
         }
      } else if (this.field_607 == 2) {
         if (!field_495) {
            method_334("/10");
            this.method_218(1);
            field_552 = method_313(2, true, true);
            this.field_654 = 34;
            this.field_655 = 20;
         }
      } else if (this.field_607 == 3 && !field_495) {
         method_334("/11");
         this.method_218(1);
         field_552 = method_313(2, true, true);
         this.field_654 = 14;
         this.field_655 = 3;
      }

      if (!field_495) {
         method_336();
      } else {
         field_495 = false;
      }

      this.field_726 = -1;
      this.field_727 = 0;
      this.field_728 = 0;
      byte[] var9 = null;
      if (this.field_607 == 0) {
         var9 = method_217("/8", 0);
      }

      if (this.field_607 == 1) {
         var9 = method_217("/9", 0);
      }

      if (this.field_607 == 2) {
         var9 = method_217("/10", 0);
      }

      if (this.field_607 == 3) {
         var9 = method_217("/11", 0);
      }

      class_23 var3 = new class_23(var9);
      this.field_668 = var3.method_124();
      this.field_669 = var3.method_124();
      this.field_596 = this.field_668 * 108 / 2;
      this.field_670 = new byte[this.field_668][this.field_669];
      this.field_671 = new short[this.field_668][this.field_669];
      this.field_672 = new short[this.field_668][this.field_669];
      this.field_673 = new byte[this.field_668][this.field_669];

      for (int var10 = 0; var10 < this.field_668; var10++) {
         for (int var20 = 0; var20 < this.field_669; var20++) {
            this.field_670[var10][var20] = var3.method_124();
         }
      }

      for (int var11 = 0; var11 < this.field_668; var11++) {
         for (int var21 = 0; var21 < this.field_669; var21++) {
            this.field_672[var11][var21] = var3.method_126();
         }
      }

      for (int var12 = 0; var12 < this.field_668; var12++) {
         for (int var22 = 0; var22 < this.field_669; var22++) {
            this.field_671[var12][var22] = (short)(this.field_671[var12][var22] | var3.method_126());
         }
      }

      for (int var13 = 0; var13 < this.field_668; var13++) {
         for (int var23 = 0; var23 < this.field_669; var23++) {
            this.field_673[var13][var23] = var3.method_124();
         }
      }

      this.field_640 = var3.method_126();
      this.field_641 = new class_9[this.field_640];

      for (int var14 = 0; var14 < this.field_640; var14++) {
         class_9 var28;
         (var28 = new class_9(this)).field_75 = var3.method_124();
         var28.field_76 = var3.method_124();
         var28.field_77 = var3.method_124();
         var28.field_84 = (short)this.method_228(var28.field_76, var28.field_77);
         var5 = var28.field_77;
         var2 = var28.field_76;
         var28.field_85 = (short)((var5 + var2) * 27);
         var28.field_78 = var3.method_123();
         var28.field_79 = var3.method_123();
         var28.field_80 = var3.method_123();
         var28.field_81 = var3.method_123();
         var28.field_83 = var3.method_124();
         var28.field_82 = new class_16[var28.field_83];

         for (int var25 = 0; var25 < var28.field_83; var25++) {
            var28.field_82[var25] = new class_16(this);
            var28.field_82[var25].field_152 = var3.method_124();
            var28.field_82[var25].field_153 = var3.method_124();
            var28.field_82[var25].field_154 = var3.method_124();
            var28.field_82[var25].field_155 = var3.method_123();
            var28.field_82[var25].field_156 = var3.method_123();
         }

         this.field_641[var14] = var28;
      }

      class_23 var26 = var3;
      var1 = this;
      byte var36 = var3.method_124();

      for (int var37 = 0; var37 < var36; var37++) {
         byte var29 = var26.method_124();
         var5 = var26.field_439;
         var1.method_220(var1.field_589.field_454[var29], var26);
         var26.field_439 = var5;
         var1.method_220(var1.field_590.field_454[var29], var26);
      }

      this.field_610 = var3.method_124();
      this.field_611 = new class_20[this.field_610];

      for (int var16 = 0; var16 < this.field_610; var16++) {
         this.field_611[var16] = new class_20(this);
         this.field_611[var16].field_326 = var3.method_124();
         this.field_611[var16].field_327 = new class_24[this.field_611[var16].field_326];

         for (int var27 = 0; var27 < this.field_611[var16].field_326; var27++) {
            class_24 var30;
            (var30 = new class_24(this)).field_440 = var3.method_126();
            var30.field_441 = var3.method_126();
            this.field_611[var16].field_327[var27] = var30;
         }
      }

      this.field_656 = var3.method_126();
      this.field_657 = new class_19[this.field_656];

      for (int var17 = 0; var17 < this.field_656; var17++) {
         class_19 var31;
         (var31 = new class_19(this)).field_320 = var3.method_124();
         var31.field_321 = var3.method_124();
         var31.field_322 = var3.method_123();
         var31.field_324 = var3.method_126();
         var31.field_325 = var3.method_126();
         var31.field_323 = false;
         this.field_657[var17] = var31;
      }

      this.field_663 = var3.method_126();
      this.field_664 = new byte[this.field_663];

      for (int var18 = 0; var18 < this.field_663; var18++) {
         this.field_664[var18] = var3.method_124();
      }

      this.field_701 = true;
      if (this.field_607 == 0 && this.field_712) {
         this.method_263(538);
      }

      return true;
   }

   // $VF: renamed from: a (s, c) void
   private void method_220(class_13 var1, class_23 var2) {
      short var5 = var2.method_126();
      var1.field_122 = var5;
      var1.field_123 = new class_24[var5];

      for (int var6 = 0; var6 < var5; var6++) {
         short var3 = var2.method_126();
         short var4 = var2.method_126();
         var1.field_123[var6] = new class_24(this);
         var1.field_123[var6].field_440 = var3;
         var1.field_123[var6].field_441 = var4;
      }
   }

   // $VF: renamed from: H () void
   private void method_221() {
      if (this.field_607 == 0) {
         this.method_197(2, 16, 30, 1);
         this.method_197(4, 24, 26, 5);
         this.method_197(2, 18, 25, 3);
         this.method_197(2, 27, 12, 3);
         this.method_197(2, 3, 30, 5);
         this.method_197(4, 6, 22, 7);
         this.method_197(2, 11, 28, 1);
         this.method_197(4, 8, 24, 3);
         this.method_197(2, 8, 18, 5);
         this.method_197(2, 46, 18, 3);
         this.method_197(4, 57, 22, 1);
         this.method_197(2, 52, 17, 7);
      } else if (this.field_607 == 1) {
         this.method_197(4, 9, 6, 3);
         this.method_197(2, 15, 8, 5);
         this.method_197(4, 14, 9, 7);
         this.method_197(2, 14, 17, 1);
         this.method_197(4, 2, 10, 3);
         this.method_197(2, 26, 42, 1);
         this.method_197(4, 25, 45, 5);
      } else {
         if (this.field_607 == 2) {
            this.method_197(9, this.field_641[172].field_76 - 1, this.field_641[172].field_77, 7);
            this.method_197(6, 18, 29, 1);
            this.method_197(2, 25, 43, 1);
            this.method_197(4, 25, 31, 5);
            this.method_197(2, 11, 19, 7);
            this.method_197(4, 9, 13, 7);
            this.method_197(2, 5, 8, 3);
            this.method_197(11, 15, 7, 3);
            this.method_197(4, 19, 11, 5);
         }
      }
   }

   // $VF: renamed from: a (int, boolean) void
   final void method_222(int var1, boolean var2) {
      this.field_766 = 1;
      boolean var3 = true;
      this.field_469 = var1;
      this.field_470 = var3;
      this.method_215(9, 0);
      this.method_128();
   }

   // $VF: renamed from: i () void
   final void method_223() {
      if (this.field_607 == 0) {
         if (this.field_709[0] == -2 || this.field_709[0] == 23) {
            class_9 var1;
            (var1 = this.field_641[508]).field_76 = 2;
            var1.field_77 = 23;
            var1.field_84 = (short)this.method_228(var1.field_76, var1.field_77);
            byte var2 = var1.field_77;
            byte var3 = var1.field_76;
            var1.field_85 = (short)((var2 + var3) * 27);
         }

         if (this.field_709[1] == -2 || this.field_709[1] == 24) {
            class_9 var4;
            (var4 = this.field_641[507]).field_76 = 2;
            var4.field_77 = 20;
            var4.field_84 = (short)this.method_228(var4.field_76, var4.field_77);
            byte var10 = var4.field_77;
            byte var5 = var4.field_76;
            var4.field_85 = (short)((var10 + var5) * 27);
         }

         if (this.field_716 == 1) {
            this.method_262(545);
            return;
         }
      } else if (this.field_607 == 1) {
         if (this.field_716 == 0) {
            this.method_262(3);
         }

         if (this.field_720 == 0) {
            this.method_192();
            this.method_263(20);

            for (int var9 = 0; var9 < 45; var9++) {
               this.method_262(var9 + 226);
            }

            this.method_262(274);
            this.method_262(275);
            this.method_262(276);
            this.method_262(271);
            this.method_262(272);
            this.method_262(273);
            this.method_262(278);
            this.method_262(277);
            this.method_262(280);
            this.field_731 = 6;
            return;
         }

         if (this.field_720 == 1) {
            this.method_192();
            this.method_263(20);

            for (int var8 = 0; var8 < 45; var8++) {
               this.method_262(var8 + 226);
            }

            this.method_262(278);
            this.method_262(277);
            this.method_262(280);
            this.method_263(274);
            this.method_263(275);
            this.method_263(276);
            this.method_263(271);
            this.method_263(272);
            this.method_263(273);
            this.field_731 = 10;
            return;
         }

         if (this.field_720 == 2) {
            this.method_192();
            this.method_263(20);

            for (int var7 = 0; var7 < 45; var7++) {
               this.method_262(var7 + 226);
            }

            this.method_262(278);
            this.method_262(277);
            this.method_262(280);
            this.method_262(271);
            this.method_262(272);
            this.method_262(273);
            this.method_262(278);
            this.method_262(277);
            this.method_262(280);
            this.method_262(282);
            this.method_262(283);
            this.method_262(284);
            this.method_262(287);
            this.method_262(286);
            this.method_262(285);
            this.method_262(288);
            this.method_262(289);
            this.method_262(290);
            this.field_731 = 3;
            return;
         }

         this.method_262(20);

         for (int var6 = 0; var6 < 45; var6++) {
            this.method_263(var6 + 226);
         }

         this.method_263(274);
         this.method_263(275);
         this.method_263(276);
         this.method_263(271);
         this.method_263(272);
         this.method_263(273);
         this.method_263(278);
         this.method_263(277);
         this.method_263(280);
         this.method_263(282);
         this.method_263(283);
         this.method_263(284);
         this.method_263(287);
         this.method_263(286);
         this.method_263(285);
         this.method_263(288);
         this.method_263(289);
         this.method_263(290);
      }
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, int, int, int, int, int) void
   private void method_224(Graphics var1, int var2, int var3, int var4, int var5, int var6) {
      byte var8 = 0;
      byte var7 = 0;
      byte var13 = 0;
      var1.setColor(var13, var7, var8);
      method_168(var1, var2, var3, var4, var5);
      var8 = 72;
      var7 = 81;
      var13 = 77;
      var1.setColor(var13, var7, var8);
      method_167(var1, var2, var3, var4, var5);
      var2--;
      var3--;
      var4 += 2;
      var5 += 2;
      var8 = 86;
      var7 = 78;
      var13 = 8;
      var1.setColor(var13, var7, var8);
      method_166(var1, var2 + 1, var3, var2 + var4 - 2, var3);
      method_166(var1, var2 + 1, var3 + var5 - 1, var2 + var4 - 2, var3 + var5 - 1);
      method_166(var1, var2, var3 + 1, var2, var3 + var5 - 2);
      method_166(var1, var2 + var4 - 1, var3 + 1, var2 + var4 - 1, var3 + var5 - 2);
   }

   // $VF: renamed from: b (javax.microedition.lcdui.Graphics, int, int, int, int, int) void
   private void method_225(Graphics var1, int var2, int var3, int var4, int var5, int var6) {
      if (var6 == 3 || var6 == 5) {
         this.method_169(var1, 16777215);
         if ((System.currentTimeMillis() & 64L) != 0L && field_514) {
            this.method_169(var1, 0);
         }

         method_168(var1, var2 - 2, var3 - 2, var4 + 4, 56);
         this.method_169(var1, 9475467);
         method_168(var1, var2 - 1, var3 - 1, var4 + 2, 54);
      }

      switch (var6) {
         case 2:
            this.method_169(var1, 3816503);
            break;
         case 3:
         case 4:
         case 5:
            this.method_169(var1, 9475467);
      }

      method_168(var1, var2, var3, var4, 52);
      switch (var6) {
         case 2:
            this.method_169(var1, 4144954);
            break;
         case 3:
         case 4:
         case 5:
            this.method_169(var1, 9803919);
      }

      method_168(var1, var2 + 1, var3 + 52 - 5, var4 - 2, 4);
      method_168(var1, var2 + 1, var3 + 52 - 7, var4 - 2, 1);
      this.method_169(var1, 6655278);
      method_168(var1, var2 + 1, var3, var4 - 2, 1);
      this.method_169(var1, 3558425);
      method_168(var1, var2 + 1, var3 + 52 - 1, var4 - 2, 1);
      this.method_169(var1, 12297634);
      method_168(var1, var2, var3 + 1, 1, 50);
      method_168(var1, var2 + var4 - 1, var3 + 1, 1, 50);
   }

   // $VF: renamed from: a (int, int, int, int, int, int, int, int) boolean
   private static boolean method_226(int var0, int var1, int var2, int var3, int var4, int var5, int var6, int var7) {
      return (var4 >= var0 && var4 < var0 + var2 || var4 < var0 && var4 + var6 > var0)
         && (var5 >= var1 && var5 < var1 + var3 || var5 < var1 && var5 + var7 > var1);
   }

   // $VF: renamed from: a (int, int, int, int, int, int) boolean
   private static boolean method_227(int var0, int var1, int var2, int var3, int var4, int var5) {
      return var0 >= var2 && var0 < var2 + var4 && var1 >= var3 && var1 < var3 + var5;
   }

   // $VF: renamed from: a (int, int) int
   final int method_228(int var1, int var2) {
      return this.field_596 + (var1 - 1 - var2) * 54;
   }

   // $VF: renamed from: b (int, int) int
   static int method_229(int var0, int var1) {
      return (var1 + var0) * 27;
   }

   // $VF: renamed from: c (int, int) int
   private int method_230(int var1, int var2) {
      return (var2 - (var1 - this.field_596) / 2) / 54;
   }

   // $VF: renamed from: d (int, int) int
   private int method_231(int var1, int var2) {
      return (var2 + (var1 - this.field_596) / 2) / 54;
   }

   // $VF: renamed from: c (int, int) void
   final void method_232(int var1, int var2) {
      this.field_597 = var1;
      this.field_598 = var2;
   }

   // $VF: renamed from: a (p, boolean) void
   final void method_233(class_15 var1, boolean var2) {
      if (!field_580 || var2 || field_594 == 131) {
         this.field_627 = var1;
         int var5 = this.method_228(var1.field_131, var1.field_132);
         byte var4 = var1.field_132;
         byte var3 = var1.field_131;
         int var6 = (var4 + var3) * 27;
         int var10 = var5 + (54 - field_570);
         int var12 = var6 + (27 - field_571);
         boolean var8 = this.method_205(var1, 2, 1);
         boolean var9 = this.method_205(var1, 0, 1);
         if (var1.field_135 == 2) {
            var8 = !var8;
            var9 = !var9;
         }

         if (field_541[var1.field_139][var1.field_135][2] != 0) {
            if (var8) {
               var10 += var1.field_137 * 54 / 65536;
               if (var1.field_133 >= field_541[var1.field_139][var1.field_135][2]) {
                  var10 -= 54;
               }
            } else {
               var10 -= var1.field_137 * 54 / 65536;
               if (var1.field_133 >= field_541[var1.field_139][var1.field_135][2]) {
                  var10 += 54;
               }
            }

            if (var9) {
               var12 += var1.field_137 * 27 / 65536;
               if (var1.field_133 >= field_541[var1.field_139][var1.field_135][2]) {
                  var12 -= 27;
               }
            } else {
               var12 -= var1.field_137 * 27 / 65536;
               if (var1.field_133 >= field_541[var1.field_139][var1.field_135][2]) {
                  var12 += 27;
               }
            }
         }

         byte var7;
         if ((field_594 & 512) == 0 && !this.field_587.field_463 && (this.field_701 || !this.field_702)) {
            var7 = 10;
         } else {
            var7 = 30;
         }

         if (field_568 < this.field_601) {
            var5 = Math.max(Math.min(var10, this.field_599 + this.field_601 - field_568), this.field_599);
         } else {
            var5 = this.field_599 + this.field_601 / 2 - field_570;
         }

         if (field_569 < this.field_602) {
            var6 = Math.max(Math.min(var12, this.field_600 + this.field_602 - field_569), this.field_600);
         } else {
            var6 = this.field_600 + this.field_602 / 2 - field_571;
         }

         if (!var2) {
            if (this.field_597 < var5) {
               var5 = this.field_597 + Math.min(var5 - this.field_597, var7);
            }

            if (this.field_597 > var5) {
               var5 = this.field_597 - Math.min(this.field_597 - var5, var7);
            }

            if (this.field_598 < var6) {
               var6 = this.field_598 + Math.min(var6 - this.field_598, var7);
            }

            if (this.field_598 > var6) {
               var6 = this.field_598 - Math.min(this.field_598 - var6, var7);
            }
         }

         this.method_232(var5, var6);
      }
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, short, boolean, boolean, int, int) void
   private void method_234(Graphics var1, short var2, boolean var3, boolean var4, int var5, int var6) {
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
            this.method_172(var1, var3i + 109, var5, var6 - 60, 54, 87, var4i, 0, 0);
         }

         if ((var3i = var2 >> 8 & 0xFF) != 255) {
            this.method_172(var1, var3i + 109, var5, var6 - 120, 54, 87, var4i, 0, 0);
         }
      }
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, p, int, int) void
   private void method_235(Graphics var1, class_15 var2, int var3, int var4) {
      boolean var10000;
      label152:
      if ((!field_748 || field_492 == 24) && (this.field_607 != 3 || var2.field_139 != 1) && field_594 != 131) {
         if (var2.field_141 <= 0) {
            if (var2.field_139 == 5) {
               var2.field_151 = var2.field_151 - field_804;
            } else {
               var2.field_151 = var2.field_151 - field_804;
            }

            if (var2.field_151 < 1000 && var2.field_151 % 500 > 250) {
               var10000 = true;
               break label152;
            }

            if (var2.field_151 < 0) {
               var2.field_130 = false;
            }
         }

         var10000 = false;
      } else {
         var10000 = false;
      }

      if (!var10000) {
         int var5 = field_541[var2.field_139][var2.field_135][4];
         boolean var6 = var2.field_138 > 4;
         if (field_541[var2.field_139][var2.field_135][3] == 4) {
            var5 = class_0.field_11[var2.field_139][var5][this.method_205(var2, 0, 1) ? 0 : 1][var2.field_133];
         } else {
            var5 = class_0.field_13[var5][var6 ? 8 - var2.field_138 : var2.field_138][var2.field_133];
         }

         byte var7 = var2.field_139;
         if (var2.field_139 == 2) {
            var7 = 2;
            field_545[2].method_119(0);
         } else if (var2.field_139 == 4) {
            var7 = 2;
            field_545[2].method_119(1);
         }

         if (!var6) {
            field_545[var7].method_101(var1, var5, var3, var4, 0, 0, 0);
         } else {
            class_21 var22 = field_545[var7];
            int var10 = var3 + 108;
            var22.method_101(var1, var5, var10, var4, 1, 0, 0);
         }

         if (var2.field_139 == 0 || var2.field_139 == 1) {
            class_26 var12;
            if (var2.field_139 == 0) {
               var12 = this.field_589;
            } else {
               var12 = this.field_590;
            }

            if (var5 > 9 && var5 < 22) {
               int var8;
               if (var12.field_452.field_140 == 127 || var12.field_458 == 0) {
                  var8 = var5 + 14;
               } else if (var12.field_458 == 1 || var12.field_458 == 2) {
                  var8 = var5 - 10;
               } else if (var12.field_458 != 3 && var12.field_458 != 4) {
                  var8 = -1;
               } else {
                  var8 = var5 + 2;
               }

               if (var8 >= 0) {
                  if (!var6) {
                     field_546[var2.field_139].method_101(var1, var8, var3, var4, 0, 0, 0);
                  } else {
                     class_21 var23 = field_546[var2.field_139];
                     int var17 = var3 + 108;
                     var23.method_101(var1, var8, var17, var4, 1, 0, 0);
                  }
               }
            }
         }

         if (var2.field_140 != 127) {
            int var19 = field_541[var2.field_139][var2.field_135][5];
            byte var13 = var2.field_138;
            if (var19 != 127) {
               boolean var21 = var13 > 4;
               if (field_541[var2.field_139][var2.field_135][3] == 4) {
                  var19 = class_0.field_12[var19][this.method_205(var2, 0, 1) ? 0 : 1][var2.field_133];
               } else {
                  var19 = class_0.field_13[var19][var21 ? 8 - var13 : var13][var2.field_133];
               }

               if (var19 != 127) {
                  if (!var21) {
                     field_547[var2.field_140].method_101(var1, var19, var3, var4, 0, 0, 0);
                  } else {
                     class_21 var24 = field_547[var2.field_140];
                     int var18 = var3 + 108;
                     var24.method_101(var1, var19, var18, var4, 1, 0, 0);
                  }
               }
            }
         }

         if (!field_555.method_6()) {
            field_555.method_8(field_804);
            field_555.method_7();
         }
      }
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, int, int, int) void
   private void method_236(Graphics var1, int var2, int var3, int var4) {
      int var7 = 0;
      class_9 var8;
      int var5 = (var8 = this.field_641[var2]).field_75;
      int var6 = var5 + 9;
      if (this.field_726 == var2) {
         var7 = this.field_728;
      }

      if (this.field_607 == 1 && this.field_720 >= 0) {
         if (var5 == 47) {
            var6 = 163 + this.field_729;
         } else if (var5 == 45) {
            var6 = 175 + this.field_729;
         } else if (var5 == 48) {
            var6 = 171 + this.field_729;
         } else if (var5 == 46) {
            var6 = 167 + this.field_729;
         }
      }

      boolean var9 = false;
      if (method_170(var8.field_76 - this.field_587.field_452.field_131) <= 1
         && method_170(var8.field_77 - this.field_587.field_452.field_132) <= 1
         && (var9 = this.method_275(this.field_587.field_455, var2, false))
         && var8.field_83 <= 0
         && (field_779 == 1 || field_779 == 2)) {
         field_778 = true;
      }

      int var10005 = this.field_690[var5][2] * 3 / 2;
      int var10006 = (this.field_690[var5][3] + var7) * 3 / 2;
      short var10007 = this.field_690[var5][0];
      short var10008 = this.field_690[var5][1];
      boolean var15 = var8.field_81;
      byte var14 = 0;
      boolean var18 = false;
      boolean var19 = false;
      short var13 = var10008;
      short var12 = var10007;
      int var11 = var10006;
      int var10 = var10005;
      if (this.field_674[var6] != var15) {
         this.field_674[var6] = !this.field_674[var6];
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

      this.method_172(var1, var6, var6x, var7, var12 + 1, var13, 0, 0, var14);

      for (int var21 = 0; var21 < var8.field_83; var21++) {
         if (var8.field_82[var21].field_155) {
            var2 = var3 + var8.field_82[var21].field_153 * 3 / 2;
            var5 = var4 + var8.field_82[var21].field_154 * 3 / 2;
            if (!var8.field_82[var21].field_156) {
               class_21 var35 = field_549[2];
               byte var32 = var8.field_82[var21].field_152;
               var35.method_101(var1, var32, var2, var5, 0, 0, 0);
            } else {
               var6 = field_549[2].method_91(var8.field_82[var21].field_152);
               class_21 var36 = field_549[2];
               var11 = var2 + var6;
               byte var33 = var8.field_82[var21].field_152;
               var36.method_101(var1, var33, var11, var5, 1, 0, 0);
            }

            if (var9) {
               var6 = field_549[2].method_91(var8.field_82[var21].field_152);
               int var26 = var2 + (var6 >> 1);
               class_11 var23 = field_777;
               field_777.field_87 = var26;
               var23.field_88 = var5;
               field_777.method_7();
            }
         }
      }
   }

   // $VF: renamed from: c (int, int, int, int) void
   private void method_237(int var1, int var2, int var3, int var4) {
      int var5 = -1;

      for (int var6 = 0; var6 < this.field_632; var6++) {
         if (this.field_631[var6] == 0) {
            if (method_227(this.field_641[this.field_630[var6]].field_76, this.field_641[this.field_630[var6]].field_77, 0, 0, var3, var4)) {
               var5 = -1;
            } else if (var5 == -1) {
               var5 = var6;
            }
         } else if (this.field_631[var6] == 1) {
            if (method_227(this.field_620[this.field_630[var6]].field_131, this.field_620[this.field_630[var6]].field_132, 0, 0, var3, var4)) {
               var5 = -1;
            } else if (var5 == -1) {
               var5 = var6;
            }
         } else if (this.field_631[var6] == 2) {
            if ((var1 != 2 || this.field_629[var2].field_426.field_448 < this.field_629[this.field_630[var6]].field_426.field_448)
               && !method_227(
                  this.field_629[this.field_630[var6]].field_426.field_445, this.field_629[this.field_630[var6]].field_426.field_445, 0, 0, var3, var4
               )) {
               if (var5 == -1) {
                  var5 = var6;
               }
            } else {
               var5 = -1;
            }
         } else if (this.field_631[var6] == 3) {
            if ((var1 != 3 || this.field_628[var2].field_448 < this.field_628[this.field_630[var6]].field_448)
               && !method_227(this.field_628[this.field_630[var6]].field_445, this.field_628[this.field_630[var6]].field_446, 0, 0, var3, var4)) {
               if (var5 == -1) {
                  var5 = var6;
               }
            } else {
               var5 = -1;
            }
         } else if (this.field_631[var6] == 4) {
            if (this.field_620[this.field_630[var6]].field_138 == 7) {
               if (method_227(
                  this.field_620[this.field_630[var6]].field_131,
                  this.field_620[this.field_630[var6]].field_132 - class_0.field_5[this.field_620[this.field_630[var6]].field_139][1] + 1,
                  0,
                  0,
                  var3,
                  var4
               )) {
                  var5 = -1;
               } else if (var5 == -1) {
                  var5 = var6;
               }
            } else if (this.field_620[this.field_630[var6]].field_138 == 1) {
               if (method_227(
                  this.field_620[this.field_630[var6]].field_131 - class_0.field_5[this.field_620[this.field_630[var6]].field_139][1] + 1,
                  this.field_620[this.field_630[var6]].field_132,
                  0,
                  0,
                  var3,
                  var4
               )) {
                  var5 = -1;
               } else if (var5 == -1) {
                  var5 = var6;
               }
            } else if (method_227(this.field_620[this.field_630[var6]].field_131, this.field_620[this.field_630[var6]].field_132, 0, 0, var3, var4)) {
               var5 = -1;
            } else if (var5 == -1) {
               var5 = var6;
            }
         }
      }

      if (var5 == -1) {
         this.field_630[this.field_632] = (short)var2;
         this.field_631[this.field_632] = (byte)var1;
      } else {
         for (int var7 = this.field_632; var7 > var5; var7--) {
            this.field_630[var7] = this.field_630[var7 - 1];
            this.field_631[var7] = this.field_631[var7 - 1];
         }

         this.field_630[var5] = (short)var2;
         this.field_631[var5] = (byte)var1;
      }

      this.field_632++;
   }

   // $VF: renamed from: c (javax.microedition.lcdui.Graphics) void
   private void method_238(Graphics var1) {
      int var2 = 0;
      int var4 = 0;
      int var3 = 0;
      if (this.field_706 != 0) {
         if (this.field_706 > 0 && this.field_706 < 20) {
            var2 = this.field_587.field_452.field_138 > 4 ? 1 : 0;
            var3 = this.method_228(this.field_587.field_452.field_131, this.field_587.field_452.field_132) - this.field_597;
            byte var51 = this.field_587.field_452.field_132;
            byte var21 = this.field_587.field_452.field_131;
            var4 = (var51 + var21) * 27 - this.field_598;
         } else if (this.field_706 > 19 && this.field_706 < 26) {
            var3 = this.method_228(50, 23) - this.field_597;
            byte var50 = 23;
            byte var20 = 50;
            var4 = (var50 + var20) * 27 - this.field_598 + this.field_692;
         } else if (this.field_706 > 29 && this.field_706 < 34) {
            var2 = 0;
            var3 = this.method_228(53, 30) - this.field_597;
            byte var49 = 30;
            byte var19 = 53;
            var4 = (var49 + var19) * 27 - this.field_598 + this.field_692;
         } else if (this.field_706 >= 35 && this.field_706 <= 38) {
            var2 = 0;
            var3 = this.method_228(36, 17) - this.field_597;
            byte var48 = 17;
            byte var18 = 36;
            var4 = (var48 + var18) * 27 - this.field_598 + this.field_692;
         } else if (this.field_706 >= 39 && this.field_706 <= 42) {
            var2 = 0;
            var3 = this.method_228(36, 17) - this.field_597;
            byte var5 = 17;
            byte var17 = 36;
            var4 = (var5 + var17) * 27 - this.field_598 + this.field_692;
         }

         switch (this.field_706) {
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
                  class_21 var60 = field_545[this.field_587.field_452.field_139];
                  int var64 = 51 + (this.field_706 - 1);
                  int var56 = var4 + this.field_692;
                  var4 = var64;
                  var60.method_101(var1, var4, var3, var56, 0, 0, 0);
               } else {
                  class_21 var61 = field_545[this.field_587.field_452.field_139];
                  int var65 = 51 + (this.field_706 - 1);
                  int var66 = var3 + 108;
                  int var57 = var4 + this.field_692;
                  int var54 = var66;
                  var4 = var65;
                  var61.method_101(var1, var4, var54, var57, 1, 0, 0);
               }

               try {
                  if (this.field_588.field_462 == this.field_587.field_462) {
                     class_15 var13 = this.field_588.field_452;
                     class_15 var46 = this.field_587.field_452;
                     if (this.field_673[var13.field_131][var13.field_132] == this.field_673[var46.field_131][var46.field_132]
                        && var13.field_131 > var46.field_131) {
                        int var67 = this.method_228(var13.field_131, var13.field_132) - this.field_597;
                        byte var55 = var13.field_132;
                        byte var47 = var13.field_131;
                        this.method_235(var1, var13, var67, (var55 + var47) * 27 - this.field_598);
                     }
                  }

                  return;
               } catch (Exception var7) {
                  return;
               }
            case 13:
            case 14:
            case 15:
            case 16:
            case 17:
            case 18:
            case 19:
               if (var2 == 0) {
                  class_21 var59 = field_545[this.field_587.field_452.field_139];
                  int var63 = 63 + (this.field_706 - 13);
                  var4 += this.field_692;
                  var2 = var63;
                  var59.method_101(var1, var2, var3, var4, 0, 0, 0);
                  return;
               }

               class_21 var58 = field_545[this.field_587.field_452.field_139];
               int var62 = 63 + (this.field_706 - 13);
               int var10003 = var3 + 108;
               var4 += this.field_692;
               var3 = var10003;
               var2 = var62;
               var58.method_101(var1, var2, var3, var4, 1, 0, 0);
               return;
            case 20:
            case 21:
            case 22:
            case 23:
            case 24:
            case 25:
               class_21 var10000 = field_550[0];
               int var39 = 0 + (this.field_706 - 20);
               var10000.method_101(var1, var39, var3, var4, 0, 0, 0);
               var3 = this.method_228(this.field_641[162].field_76, this.field_641[162].field_77) - this.field_597;
               byte var53 = this.field_641[162].field_77;
               int var40 = this.field_641[162].field_76;
               var40 = (var53 + var40) * 27 - this.field_598;
               this.method_236(var1, 162, var3, var40 + this.field_692);
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
               field_565 = false;
            case 31:
            case 32:
            case 33:
            case 34:
            case 40:
            case 41:
            case 42:
               if (!field_565) {
                  if (field_564 < 320) {
                     field_564 += 80;
                  } else {
                     field_564 = 320;
                     field_565 = true;
                  }

                  field_545[3].method_101(var1, 18, var3, var4, 0, 0, 0);
                  return;
               }

               if (field_564 > 0) {
                  field_564 -= 80;
                  return;
               }

               field_564 = 0;
               return;
            case 35:
               field_565 = false;
            case 36:
            case 37:
            case 38:
               if (!field_565) {
                  if (field_564 < 320) {
                     field_564 += 80;
                     return;
                  }

                  field_564 = 320;
                  field_565 = true;
                  return;
               }

               if (field_564 > 0) {
                  field_564 -= 80;
               } else {
                  field_564 = 0;
               }

               field_545[3].method_101(var1, 18, var3, var4, 0, 0, 0);
               return;
            case 45:
               int var10001 = this.method_228(this.field_587.field_452.field_131, this.field_587.field_452.field_132) - field_570 / 2;
               byte var52 = this.field_587.field_452.field_132;
               byte var38 = this.field_587.field_452.field_131;
               this.method_232(var10001, (var52 + var38) * 27 - field_571 / 2);
               return;
            case 50:
            case 51:
            case 52:
            case 53:
               this.method_169(var1, 0);
               method_349(var1, 0, 0, field_568, field_569);
               method_168(var1, 0, 0, field_568, field_569);
               this.method_169(var1, 16777215);
               short var23 = 304;
               method_175(var1, method_361(304), 0, 180, class_5.field_53, 0, 0, field_568, field_569, 36);
               var23 = 314;
               method_175(var1, method_361(314), 0, class_5.field_54, class_5.field_55, 0, 0, field_568, field_569, 20);
               StringBuffer var8;
               (var8 = new StringBuffer(128)).append("");
               var8.append(this.field_733 > 0 ? this.field_733 : 0);
               var8.append(":");
               if (this.field_734 < 10) {
                  var8.append("0");
               }

               var8.append(this.field_734 > 0 ? this.field_734 : 0);
               var8.append(":");
               if (this.field_735 / 1000 < 10) {
                  var8.append("0");
               }

               var8.append(this.field_735 > 0 ? this.field_735 / 1000 : 0);
               method_175(var1, var8.toString(), 0, class_5.field_56, class_5.field_57, 0, 0, field_568, field_569, 68);
               if (this.field_706 > 50) {
                  String var26;
                  if ((var3 = this.field_733 * 60 * 60 + this.field_734 * 60 + this.field_735 / 1000) < 3600) {
                     var23 = 308;
                     var26 = method_361(308);
                  } else if (var3 < 7800) {
                     var23 = 305;
                     var26 = method_361(305);
                  } else if (var3 < 10300) {
                     var23 = 306;
                     var26 = method_361(306);
                  } else {
                     var23 = 307;
                     var26 = method_361(307);
                  }

                  method_175(var1, var26, 0, class_5.field_58, class_5.field_59, 0, 0, field_568, field_569, 68);
               }

               if (this.field_706 > 51) {
                  if (this.field_736 != 0) {
                     var3 = this.field_737 * 100 / this.field_736;
                  } else {
                     var3 = 100;
                  }

                  var23 = 309;
                  method_175(var1, method_361(309), 0, class_5.field_60, class_5.field_61, 0, 0, field_568, field_569, 20);
                  StringBuffer var9;
                  (var9 = new StringBuffer(128)).append("");
                  var9.append(var3);
                  var23 = 310;
                  var9.append(method_361(310));
                  method_175(var1, var9.toString(), 0, class_5.field_62, class_5.field_63, 0, 0, field_568, field_569, 68);
               }

               if (this.field_706 > 52) {
                  StringBuffer var10 = new StringBuffer(128);
                  if (var3 > 97) {
                     var23 = 308;
                     var10.append(method_361(308));
                  } else if (var3 > 95) {
                     var23 = 305;
                     var10.append(method_361(305));
                  } else if (var3 > 85) {
                     var23 = 306;
                     var10.append(method_361(306));
                  } else {
                     var23 = 307;
                     var10.append(method_361(307));
                  }

                  if (this.field_736 < 90) {
                     var23 = 311;
                     var10.append(method_361(311));
                  }

                  if (this.field_737 != 0) {
                     var3 = this.field_739 * 100 / this.field_737;
                  } else {
                     var3 = 0;
                  }

                  if (var3 > 90) {
                     var23 = 312;
                     var10.append(method_361(312));
                  }

                  method_175(var1, var10.toString(), 0, class_5.field_64, class_5.field_65, 0, 0, field_568, field_569, 68);
                  this.method_321(field_788, 560);
                  return;
               }
               break;
            case 54:
               this.method_169(var1, 0);
               method_168(var1, 0, 0, field_568, field_569);
               this.method_169(var1, 16777215);
               short var22 = 313;
               method_175(var1, method_361(313), 0, field_570, field_571 - class_0.field_2[0] / 2, 0, 0, field_568, field_569, 36);
         }
      }
   }

   // $VF: renamed from: e (int, int) int
   private int method_239(int var1, int var2) {
      int var10000 = var1 * this.field_575 >> 6;
      var1 = 65536 / var2 + 1;
      boolean var3 = true;
      int var4 = var10000;
      return 1 > var4 ? 1 : (var4 > var1 ? var1 : var4);
   }

   // $VF: renamed from: I () void
   private void method_240() {
      if (!field_580) {
         for (int var2 = 0; var2 < 25; var2++) {
            class_15 var1;
            if ((var1 = this.field_620[var2]).field_130
               && !var1.field_146
               && (this.field_609 == this.field_673[var1.field_131][var1.field_132] || method_202(var1))) {
               var1.field_145 = false;
               byte[] var4;
               if ((var4 = field_541[var1.field_139][var1.field_135])[1] != 0) {
                  if (var1.field_139 == 5) {
                     if (var1.field_135 == 1) {
                        if (var1.field_133 == 2 || var1.field_133 == 5) {
                           this.field_693 = 100;
                        }
                     } else if (var1.field_135 == 2) {
                        if (var1.field_133 == 0 || var1.field_133 == 3) {
                           this.field_693 = 100;
                        }
                     } else if (var1.field_135 == 6
                        && var1.field_133 > 3
                        && var1.field_133 < 8
                        && var1.field_134 != var1.field_133
                        && this.method_246(var1.field_131, var1.field_132, var1.field_138, true)) {
                        this.method_188(var1, var1.field_138);
                     }
                  }

                  if (var1 == this.field_587.field_452 && method_317(2) && var1.field_135 == 1) {
                     var1.field_137 = var1.field_137 + this.method_239(25344, var4[0]);
                  } else {
                     var1.field_137 = var1.field_137 + this.method_239(var4[1] << 8, var4[0]);
                  }

                  label218:
                  if (var1.field_137 >= 65534) {
                     var1.field_137 = 0;
                     var1.field_145 = true;
                     if (var4[2] == var4[0]) {
                        if (this.method_255(var2, var1.field_131, var1.field_132, var1.field_138, false) != -1) {
                           if (var1.field_139 != 11 && var1.field_139 != 8) {
                              this.method_242(var1, 0);
                           } else {
                              this.method_188(var1, var1.field_138);
                           }
                        } else if (var1.field_139 != 2
                           && var1.field_139 != 4
                           && var1.field_139 != 6
                           && var1.field_139 != 0
                           && var1.field_139 != 1
                           && var1.field_139 != 3) {
                           this.method_188(var1, var1.field_138);
                        } else if (this.method_255(var2, var1.field_131, var1.field_132, var1.field_138, true) != -1) {
                           this.method_242(var1, 0);
                        } else {
                           this.method_188(var1, var1.field_138);
                        }
                     }

                     if (this.method_204(var1)) {
                        var1.field_143 = -1;
                        var1.field_144 = -1;
                     }

                     label225:
                     switch (var1.field_139) {
                        case 0:
                        case 1:
                           switch (var1.field_135) {
                              case 1:
                              case 12:
                              case 13:
                                 if (this.field_587.field_459) {
                                    method_279(this.field_587.field_452, this.field_587.field_452.field_138 + 2);
                                    this.method_242(this.field_587.field_452, 0);
                                    this.field_587.field_459 = false;
                                    break label218;
                                 }

                                 if (this.field_587.field_460) {
                                    method_279(this.field_587.field_452, this.field_587.field_452.field_138 - 2);
                                    this.method_242(this.field_587.field_452, 0);
                                    this.field_587.field_460 = false;
                                    break label218;
                                 }

                                 if (this.field_587.field_461) {
                                    method_279(this.field_587.field_452, this.field_587.field_452.field_138 + 4);
                                    this.method_242(this.field_587.field_452, 0);
                                    this.field_587.field_461 = false;
                                    break label218;
                                 }

                                 if (!this.method_204(var1)) {
                                    this.method_242(var1, 1);
                                    break label218;
                                 }
                                 break label225;
                              case 2:
                              case 8:
                              case 9:
                              case 10:
                              case 11:
                              default:
                                 if (var1.field_148 == this.field_574) {
                                    break label218;
                                 }
                                 break label225;
                              case 3:
                                 if ((field_594 & 512) != 0) {
                                    field_594 = 900;
                                 }

                                 this.method_242(var1, 4);
                                 break label218;
                              case 4:
                                 return;
                              case 5:
                              case 6:
                              case 7:
                                 this.method_242(var1, 0);
                                 this.method_211(false);
                                 break label218;
                           }
                        case 2:
                        case 4:
                           switch (var1.field_135) {
                              case 0:
                                 break label218;
                              case 1:
                                 if (this.field_658 != 2 && this.method_204(var1)) {
                                    this.method_242(var1, 0);
                                    break label218;
                                 }

                                 this.method_242(var1, 1);
                                 break label218;
                              case 2:
                              default:
                                 this.method_242(var1, 1);
                                 break label218;
                              case 3:
                              case 4:
                                 this.method_242(var1, 4);
                                 this.method_211(false);
                                 break label218;
                              case 5:
                                 this.method_242(var1, 0);
                                 this.method_211(false);
                                 break label218;
                           }
                        case 3:
                        case 7:
                           switch (var1.field_135) {
                              case 1:
                                 if (!this.method_204(var1)) {
                                    this.method_242(var1, 1);
                                    break label218;
                                 }
                              case 5:
                                 this.method_242(var1, 0);
                              case 2:
                              default:
                                 break label218;
                              case 3:
                              case 4:
                                 this.method_242(var1, 4);
                                 break label218;
                           }
                        case 5:
                        case 6:
                        case 8:
                           switch (var1.field_135) {
                              case 0:
                                 break label218;
                              case 1:
                                 if (this.field_658 != 2 && this.method_204(var1)) {
                                    this.method_242(var1, 0);
                                    break label218;
                                 }

                                 this.method_242(var1, 1);
                                 break label218;
                              case 2:
                              case 5:
                              case 6:
                              case 14:
                                 this.method_242(var1, 0);
                                 this.method_211(false);
                                 break label218;
                              case 3:
                              case 4:
                                 this.method_242(var1, 4);
                                 this.method_211(false);
                                 break label218;
                              case 7:
                              case 8:
                              case 9:
                              case 10:
                              case 11:
                              case 12:
                              case 13:
                              default:
                                 this.method_242(var1, 1);
                                 break label218;
                           }
                        case 9:
                        case 10:
                           switch (var1.field_135) {
                              case 0:
                                 break label218;
                              case 1:
                              case 2:
                              default:
                                 break label225;
                              case 3:
                              case 4:
                                 this.method_242(var1, 4);
                                 this.method_211(false);
                                 break label218;
                              case 5:
                                 this.method_242(var1, 0);
                                 this.method_211(false);
                                 break label218;
                           }
                        case 11:
                           switch (var1.field_135) {
                              case 0:
                                 this.method_242(var1, 1);
                                 this.method_211(false);
                                 break label218;
                              case 1:
                                 if (this.field_658 != 2 && this.method_204(var1)) {
                                    this.method_242(var1, 0);
                                    break label218;
                                 }

                                 this.method_242(var1, 1);
                                 break label218;
                              case 2:
                              default:
                                 this.method_242(var1, 1);
                                 break label218;
                              case 3:
                                 for (int var3 = 0; var3 < 25; var3++) {
                                    class_15 var5;
                                    if ((var5 = this.field_620[var3]).field_139 == var1.field_139
                                       && var5.field_131 == var1.field_131
                                       && var5.field_132 == var1.field_132
                                       && var5.field_138 == var1.field_138
                                       && var5.field_135 == 4
                                       && var5 != var1) {
                                       var1.field_138 = (byte)(var1.field_138 + 2);
                                       if (var1.field_138 > 7) {
                                          var1.field_138 = 1;
                                       }
                                    }
                                 }
                              case 4:
                                 this.method_242(var1, 4);
                                 this.method_211(false);
                                 break label218;
                              case 5:
                                 this.method_242(var1, 1);
                                 this.method_211(false);
                           }
                        default:
                           break label218;
                     }

                     this.method_242(var1, 0);
                  }

                  if (var4[2] != 0) {
                     var1.field_148 = this.field_574;
                  }

                  var1.field_134 = var1.field_133;
                  var1.field_133 = (byte)(var1.field_137 * var4[0] >> 16);
               }
            }
         }

         for (int var6 = 0; var6 < 5; var6++) {
            class_25 var8;
            if ((var8 = this.field_628[var6]).field_442 && !var8.field_443) {
               var8.field_451 = var8.field_451 + this.method_239(field_542[var8.field_444][1] << 8, field_542[var8.field_444][0]);
               var8.field_450 = (byte)(var8.field_451 * field_542[var8.field_444][0] >> 16);
               if (var8.field_451 >= 65534) {
                  var8.field_442 = false;
               }
            }
         }

         if (field_594 != 646 && field_594 != 647) {
            for (int var7 = 0; var7 < 10; var7++) {
               class_22 var9;
               if ((var9 = this.field_629[var7]).field_425 && !var9.field_426.field_443) {
                  var9.field_426.field_451 = var9.field_426.field_451
                     + this.method_239(field_542[var9.field_426.field_444][1] << 8, field_542[var9.field_426.field_444][0]);
                  var9.field_426.field_450 = (byte)(var9.field_426.field_451 * field_542[var9.field_426.field_444][0] >> 16);
                  if (var9.field_426.field_451 >= 65534) {
                     var9.field_426.field_451 = 0;
                     var9.field_426.field_450 = 0;
                  }
               }
            }
         }

         if (this.field_730 == 0) {
            this.field_729 = (byte)(this.field_729 + 1 & 3);
            this.field_730 = this.field_731;
         }

         this.field_730--;
         field_777.method_8(field_804);
      }
   }

   // $VF: renamed from: J () void
   private void method_241() {
      if (!field_580) {
         for (int var1 = 0; var1 < 25; var1++) {
            if (this.field_620[var1].field_130) {
               this.field_620[var1].field_146 = false;
            }
         }

         for (int var2 = 0; var2 < 5; var2++) {
            if (this.field_628[var2].field_442) {
               this.field_628[var2].field_443 = false;
            }
         }

         for (int var3 = 0; var3 < 10; var3++) {
            if (this.field_629[var3].field_425) {
               this.field_629[var3].field_426.field_443 = false;
            }
         }
      }
   }

   // $VF: renamed from: a (p, int) void
   final void method_242(class_15 var1, int var2) {
      if (this.field_587.field_452.field_141 > 0 || var2 != 5) {
         if (field_541[var1.field_139][var2][0] == 0) {
            var2 = 1;
         }

         if ((field_594 & 512) != 0 || var1.field_139 == 0 && this.field_589.field_463 || var1.field_139 == 1 && this.field_590.field_463) {
            if (var2 == 0 && field_541[var1.field_139].length >= 8 && field_541[var1.field_139][8][0] != 0) {
               var2 = 8;
            }

            if (var2 == 1 && field_541[var1.field_139].length >= 12 && field_541[var1.field_139][12][0] != 0) {
               var2 = 12;
            }

            if (var2 == 12 && var1.field_135 == 12) {
               var2 = 13;
            }

            if ((var1.field_139 == 0 || var1.field_139 == 1) && var1.field_140 != 127) {
               if (var2 == 8 && (this.field_587.field_458 == 1 || this.field_587.field_458 == 2)) {
                  var2 = 9;
               }

               if (var2 == 8 && (this.field_587.field_458 == 3 || this.field_587.field_458 == 4)) {
                  var2 = 10;
               }

               if (var2 == 8 && this.field_587.field_458 == 0) {
                  var2 = 11;
               }

               if (var2 == 5 && (this.field_587.field_458 == 3 || this.field_587.field_458 == 4)) {
                  var2 = 6;
               }
            }

            if ((var1.field_139 == 0 || var1.field_139 == 1) && var1.field_140 == 127 && var2 == 8 && this.field_587.field_458 == 0) {
               var2 = 11;
            }
         }

         var1.field_135 = (byte)var2;
         var1.field_137 = 0;
         var1.field_133 = 0;
         var1.field_145 = true;
         var1.field_146 = true;
         var1.field_148 = this.field_574;
         if (var2 == 5 || var2 == 6 || var2 == 7 || var2 == 14) {
            var1.field_149 = this.field_574;
         }

         if (field_541[var1.field_139][var1.field_135][2] != 0 && var1.field_138 % 2 == 0) {
            method_279(var1, var1.field_138 + 1);
         }

         if (method_243(var1.field_139)) {
            if (var2 >= 5 && var2 <= 7) {
               this.method_144(26);
            }

            if (var2 == 3 && field_617 != 10) {
               if (this.field_587.field_458 == 1 || this.field_587.field_458 == 2) {
                  this.method_144(40);
               }

               if (this.field_587.field_458 == 3) {
                  this.method_144(41);
               }

               if (this.field_587.field_458 == 0) {
                  this.method_144(27);
                  return;
               }
            }
         } else if (var1.field_139 == 11) {
            if (var2 == 3) {
               this.method_322(var1.field_139);
               return;
            }
         } else if (var1.field_139 == 9) {
            if (var2 >= 5 && var2 <= 7) {
               this.method_144(32);
            }

            if (var2 == 3) {
               this.method_322(var1.field_139);
            }
         }
      }
   }

   // $VF: renamed from: d (int) boolean
   private static boolean method_243(int var0) {
      return var0 == 2 || var0 == 4 || var0 == 5 || var0 == 6;
   }

   // $VF: renamed from: j () void
   final void method_244() {
      for (int var1 = 0; var1 < this.field_668; var1++) {
         for (int var2 = 0; var2 < this.field_669; var2++) {
            this.field_681[var1][var2] = 0;
            if (this.field_671[var1][var2] != -1) {
               this.field_681[var1][var2] = (byte)(this.field_681[var1][var2] | 2);
            }

            if (this.field_672[var1][var2] != -1) {
               this.field_681[var1][var2] = (byte)(this.field_681[var1][var2] | 1);
            }
         }
      }

      byte[][] var8 = this.field_681;
      this = this;

      for (int var4 = 0; var4 < field_652; var4++) {
         class_9 var5;
         if ((var5 = this.field_641[this.field_653[var4]]).field_79) {
            byte var9 = var5.field_75;
            short[] var6;
            if ((var6 = this.field_690[var9])[7] != 0) {
               if (var6[6] != 0) {
                  if (!var5.field_81) {
                     if (var5.field_76 != 0) {
                        for (int var13 = 0; var13 < var6[5]; var13++) {
                           var8[var5.field_76][var5.field_77 + var13] = (byte)(var8[var5.field_76][var5.field_77 + var13] | 2);
                        }
                     }
                  } else if (var5.field_77 != 0) {
                     for (int var12 = 0; var12 < var6[5]; var12++) {
                        var8[var5.field_76 + var12][var5.field_77] = (byte)(var8[var5.field_76 + var12][var5.field_77] | 1);
                     }
                  }
               } else if (!var5.field_81) {
                  for (int var11 = 0; var11 < var6[4]; var11++) {
                     for (int var14 = 0; var14 < var6[5]; var14++) {
                        var8[var5.field_76 + var11][var5.field_77 + var14] = (byte)(var8[var5.field_76 + var11][var5.field_77 + var14] | 240);
                     }
                  }
               } else {
                  for (int var10 = 0; var10 < var6[5]; var10++) {
                     for (int var3 = 0; var3 < var6[4]; var3++) {
                        var8[var5.field_76 + var10][var5.field_77 + var3] = (byte)(var8[var5.field_76 + var10][var5.field_77 + var3] | 240);
                     }
                  }
               }
            }
         }
      }
   }

   // $VF: renamed from: k () void
   final void method_245() {
      if (field_752) {
         this.method_244();
         field_752 = false;
      }

      int var2 = this.field_681[0].length;

      for (int var1 = 0; var1 < this.field_668; var1++) {
         System.arraycopy(this.field_681[var1], 0, this.field_682[var1], 0, var2);
      }

      for (int var3 = 0; var3 < 25; var3++) {
         class_15 var4;
         if ((var4 = this.field_620[var3]) != this.field_587.field_452 && var4.field_130) {
            if (var4.field_135 == 3 || var4.field_135 == 4) {
               if (var4.field_139 == 5) {
                  continue;
               }

               if (var4.field_139 == 7) {
                  this.field_682[var4.field_131][var4.field_132] = (byte)(this.field_682[var4.field_131][var4.field_132] | 240);
                  this.field_682[var4.field_131][var4.field_132 - 1] = (byte)(this.field_682[var4.field_131][var4.field_132 - 1] | 240);
                  continue;
               }

               if (var4.field_139 == 3 || var4.field_139 == 9) {
                  this.field_682[var4.field_131][var4.field_132] = (byte)(this.field_682[var4.field_131][var4.field_132] | 240);
                  continue;
               }

               if (var4.field_139 != 10) {
                  continue;
               }

               this.field_682[var4.field_131][var4.field_132] = (byte)(this.field_682[var4.field_131][var4.field_132] | 240);
               this.field_682[var4.field_131][var4.field_132 - 1] = (byte)(this.field_682[var4.field_131][var4.field_132 - 1] | 240);
               this.field_682[var4.field_131 - 1][var4.field_132 - 1] = (byte)(this.field_682[var4.field_131 - 1][var4.field_132 - 1] | 240);
               this.field_682[var4.field_131 + 1][var4.field_132 - 1] = (byte)(this.field_682[var4.field_131 + 1][var4.field_132 - 1] | 240);
               this.field_682[var4.field_131][var4.field_132 - 2] = (byte)(this.field_682[var4.field_131][var4.field_132 - 2] | 240);
               this.field_682[var4.field_131 - 1][var4.field_132 - 2] = (byte)(this.field_682[var4.field_131 - 1][var4.field_132 - 2] | 240);
               this.field_682[var4.field_131][var4.field_132 - 3] = (byte)(this.field_682[var4.field_131][var4.field_132 - 3] | 240);
               this.field_682[var4.field_131 - 1][var4.field_132 - 3] = (byte)(this.field_682[var4.field_131 - 1][var4.field_132 - 3] | 240);
               this.field_682[var4.field_131][var4.field_132 - 4] = (byte)(this.field_682[var4.field_131][var4.field_132 - 4] | 240);
               this.field_682[var4.field_131 - 1][var4.field_132 - 4] = (byte)(this.field_682[var4.field_131 - 1][var4.field_132 - 4] | 240);
            }

            if (var4.field_139 != 0 && var4.field_139 != 1 && var4.field_139 != 3) {
               this.field_682[var4.field_131][var4.field_132] = (byte)(this.field_682[var4.field_131][var4.field_132] | 240);
            } else {
               this.field_682[var4.field_131][var4.field_132] = (byte)(this.field_682[var4.field_131][var4.field_132] | 240);
            }
         }
      }

      if (this.field_607 == 0) {
         if (field_618 == 3) {
            this.field_682[57][24] = (byte)(this.field_682[57][24] | 240);
            this.field_682[57][25] = (byte)(this.field_682[57][25] | 240);
         }

         if (field_617 == 50) {
            this.field_682[29][29] = (byte)(this.field_682[29][29] | 240);
            this.field_682[30][29] = (byte)(this.field_682[30][29] | 240);
         }
      }

      if (field_594 == 384) {
         this.field_682[this.field_587.field_452.field_131][this.field_587.field_452.field_132] = (byte)(
            this.field_682[this.field_587.field_452.field_131][this.field_587.field_452.field_132] | 240
         );
      } else {
         this.field_682[this.field_587.field_452.field_131][this.field_587.field_452.field_132] = (byte)this.field_682[this.field_587.field_452.field_131][this.field_587
            .field_452
            .field_132];
      }
   }

   // $VF: renamed from: a (int, int, int, boolean) boolean
   private boolean method_246(int var1, int var2, int var3, boolean var4) {
      switch (var3) {
         case 1:
            if (var1 == this.field_668 - 1) {
               return false;
            }

            if ((this.field_682[var1 + 1][var2] & 240) != 0) {
               return false;
            }

            if ((this.field_682[var1][var2] & 8) != 0) {
               return false;
            }

            if ((this.field_682[var1 + 1][var2] & 2) != 0) {
               return false;
            }

            if (var4 && this.field_609 != this.field_673[var1 + 1][var2]) {
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

            if ((this.field_682[var1][var2 - 1] & 240) != 0) {
               return false;
            }

            if ((this.field_682[var1][var2] & 1) != 0) {
               return false;
            }

            if ((this.field_682[var1][var2 - 1] & 4) != 0) {
               return false;
            }

            if (var4 && this.field_609 != this.field_673[var1][var2 - 1]) {
               return false;
            }
            break;
         case 5:
            if (var1 == 0) {
               return false;
            }

            if ((this.field_682[var1 - 1][var2] & 240) != 0) {
               return false;
            }

            if ((this.field_682[var1][var2] & 2) != 0) {
               return false;
            }

            if ((this.field_682[var1 - 1][var2] & 8) != 0) {
               return false;
            }

            if (var4 && this.field_609 != this.field_673[var1 - 1][var2]) {
               return false;
            }
            break;
         case 7:
            if (var2 == this.field_669 - 1) {
               return false;
            }

            if ((this.field_682[var1][var2 + 1] & 240) != 0) {
               return false;
            }

            if ((this.field_682[var1][var2] & 4) != 0) {
               return false;
            }

            if ((this.field_682[var1][var2 + 1] & 1) != 0) {
               return false;
            }

            if (var4 && this.field_609 != this.field_673[var1][var2 + 1]) {
               return false;
            }
      }

      return true;
   }

   // $VF: renamed from: a (int, int, int, int) void
   final void method_247(int var1, int var2, int var3, int var4) {
      boolean[] var10 = new boolean[4];
      class_14 var6 = null;
      int var13 = 0;
      var13++;
      class_14 var7;
      (var7 = this.field_683[0]).field_126 = (byte)var1;
      var7.field_127 = (byte)var2;
      var7.field_128 = 0;
      var7.field_129 = (byte)(method_170(var7.field_126 - var3) + method_170(var7.field_127 - var4));
      var7.field_124 = null;
      var7.field_125 = null;
      class_14 var9 = var7;
      if (var1 == var3 && var2 == var4) {
         this.field_684 = var7;
      } else {
         byte var11 = this.field_682[var1][var2];
         byte var12 = this.field_682[var3][var4];
         if (this.field_682[var3][var4] == 240) {
            this.field_684 = null;
         } else {
            this.field_682[var1][var2] = (byte)(this.field_682[var1][var2] & 15);
            this.field_682[var3][var4] = (byte)(this.field_682[var3][var4] & 15);
            Object var17 = null;
            var7.field_124 = (class_14)var17;
            class_14 var5 = var7;

            do {
               var7 = var5;
               class_14 var8 = var5;
               if (var5 == null) {
                  break;
               }

               while (var7.field_124 != null) {
                  if ((var7 = var7.field_124).field_128 + var7.field_129 < var8.field_128 + var8.field_129) {
                     var8 = var7;
                  }
               }

               if (var8.field_129 < var9.field_129) {
                  var9 = var8;
               }

               if (var9.field_129 == 0) {
                  break;
               }

               var10[0] = this.method_246(var8.field_126, var8.field_127, 3, false);
               var10[1] = this.method_246(var8.field_126, var8.field_127, 5, false);
               var10[2] = this.method_246(var8.field_126, var8.field_127, 7, false);
               var10[3] = this.method_246(var8.field_126, var8.field_127, 1, false);

               for (class_14 var19 = var5; var19 != null; var19 = var19.field_124) {
                  for (int var15 = 0; var15 < 4; var15++) {
                     if (var19.field_126 == var8.field_126 + class_0.field_8[var15][0] && var19.field_127 == var8.field_127 + class_0.field_8[var15][1]) {
                        var10[var15] = false;
                     }
                  }
               }

               for (class_14 var20 = var6; var20 != null; var20 = var20.field_124) {
                  for (int var27 = 0; var27 < 4; var27++) {
                     if (var20.field_126 == var8.field_126 + class_0.field_8[var27][0] && var20.field_127 == var8.field_127 + class_0.field_8[var27][1]) {
                        var10[var27] = false;
                     }
                  }
               }

               int var14 = this.method_164() & 3;

               for (int var28 = 0; var28 < 4; var28++) {
                  if (var10[var14]) {
                     if (var13 == 150) {
                        break;
                     }

                     (var7 = this.field_683[var13++]).field_126 = (byte)(var8.field_126 + class_0.field_8[var14][0]);
                     var7.field_127 = (byte)(var8.field_127 + class_0.field_8[var14][1]);
                     var7.field_128 = (byte)(var8.field_128 + 1);
                     var7.field_129 = (byte)(method_170(var7.field_126 - var3) + method_170(var7.field_127 - var4));
                     var7.field_124 = null;
                     var7.field_125 = var8;
                     var7.field_124 = var5;
                     var5 = var7;
                  }

                  var14 = (var14 + 1) % 4;
               }

               var7 = var8;
               class_14 var10000;
               if (var5 == var8) {
                  class_14 var25 = var8.field_124;
                  var8.field_124 = null;
                  var10000 = var25;
               } else {
                  for (class_14 var26 = var5; var26.field_124 != null; var26 = var26.field_124) {
                     if (var26.field_124 == var7) {
                        if (var7.field_124 == null) {
                           var26.field_124 = null;
                        } else {
                           var26.field_124 = var7.field_124;
                           var7.field_124 = null;
                        }
                        break;
                     }
                  }

                  var10000 = var5;
               }

               var5 = var10000;
               var8.field_124 = var6;
               var6 = var8;
            } while (var13 != 150);

            for (var7 = null; var9 != null; var9 = var9.field_125) {
               var9.field_124 = var7;
               var7 = var9;
            }

            this.field_682[var1][var2] = var11;
            this.field_682[var3][var4] = var12;
            this.field_684 = var7.field_124;
         }
      }
   }

   // $VF: renamed from: c (p, int, int) void
   private void method_248(class_15 var1, int var2, int var3) {
      int var4 = var1.field_131 - var2;
      if (method_170(var2 = var1.field_132 - var3) <= method_170(var4)) {
         if (var4 <= 0) {
            method_279(var1, 1);
         } else {
            method_279(var1, 5);
         }
      } else if (var2 <= 0) {
         method_279(var1, 7);
      } else {
         method_279(var1, 3);
      }
   }

   // $VF: renamed from: a (p, int, int) void
   final void method_249(class_15 var1, int var2, int var3) {
      int var4 = var2 - var1.field_131;
      var2 = var3 - var1.field_132;
      if (var4 == 0 && var2 == 0) {
         method_279(var1, 0);
      } else if (method_170(var2) << 1 <= method_170(var4)) {
         if (var4 <= 0) {
            method_279(var1, 5);
         } else {
            method_279(var1, 1);
         }
      } else if (method_170(var2) <= method_170(var4) << 1) {
         if (var4 <= 0 && var2 <= 0) {
            method_279(var1, 4);
         } else if (var4 <= 0) {
            method_279(var1, 6);
         } else if (var2 <= 0) {
            method_279(var1, 2);
         } else {
            method_279(var1, 0);
         }
      } else if (var2 <= 0) {
         method_279(var1, 3);
      } else {
         method_279(var1, 7);
      }
   }

   // $VF: renamed from: b (p, int, int) boolean
   private boolean method_250(class_15 var1, int var2, int var3) {
      int var4 = var1.field_131 - var2;
      var2 = var1.field_132 - var3;
      if (method_170(var4) == 0 && method_170(var2) == 1 || method_170(var4) == 1 && method_170(var2) == 0) {
         if (method_170(var2) <= method_170(var4)) {
            if (var4 <= 0) {
               if (var1.field_138 == 1) {
                  return true;
               }
            } else if (var1.field_138 == 5) {
               return true;
            }
         } else if (var2 <= 0) {
            if (var1.field_138 == 7) {
               return true;
            }
         } else if (var1.field_138 == 3) {
            return true;
         }

         return false;
      } else {
         return false;
      }
   }

   // $VF: renamed from: b (p, int, int) void
   final void method_251(class_15 var1, int var2, int var3) {
      if (var1.field_131 != var2 || var1.field_132 != var3) {
         var1.field_143 = (byte)var2;
         var1.field_144 = (byte)var3;
         this.method_247(var1.field_131, var1.field_132, var1.field_143, var1.field_144);
         if (this.field_684 != null) {
            this.method_248(var1, this.field_684.field_126, this.field_684.field_127);
            this.method_242(var1, 1);
         }
      }
   }

   // $VF: renamed from: K () void
   private void method_252() {
      if (!field_580) {
         this.method_245();

         for (int var2 = 0; var2 < 25; var2++) {
            class_15 var1;
            if ((var1 = this.field_620[var2]).field_130
               && var1.field_131 < this.field_668
               && var1.field_132 < this.field_669
               && (this.field_609 == this.field_673[var1.field_131][var1.field_132] || method_202(var1))
               && var1.field_135 != 3
               && var1.field_135 != 4) {
               if (var1.field_143 != -1 && var1.field_144 != -1 && !method_203(var1) && (var1.field_131 != var1.field_143 || var1.field_132 != var1.field_144)) {
                  this.method_251(var1, var1.field_143, var1.field_144);
               }

               switch (var1.field_139) {
                  case 2:
                  case 4:
                     if (field_618 != 0 && field_618 != 1 && var1.field_135 != 5) {
                        if (var1.field_150) {
                           if (var1.field_135 != 0 && var1.field_131 == var1.field_143 && var1.field_132 == var1.field_144) {
                              var1.field_143 = -1;
                              var1.field_144 = -1;
                              this.method_242(var1, 0);
                           }
                        } else {
                           if ((method_170(var1.field_131 - this.field_587.field_452.field_131) > 1 || var1.field_132 != this.field_587.field_452.field_132)
                              && (method_170(var1.field_132 - this.field_587.field_452.field_132) > 1 || var1.field_131 != this.field_587.field_452.field_131)) {
                              if (var1.field_135 != 1 || var1.field_143 >= 0 && var1.field_144 >= 0) {
                                 if (var1.field_135 == 1
                                    && (var1.field_143 != this.field_587.field_452.field_131 || var1.field_144 != this.field_587.field_452.field_132)) {
                                    var1.field_143 = this.field_587.field_452.field_131;
                                    var1.field_144 = this.field_587.field_452.field_132;
                                 }
                              } else {
                                 this.method_242(var1, 0);
                                 var1.field_149 = this.field_574;
                              }
                           } else {
                              this.method_242(var1, 0);
                           }

                           if (var1.field_135 == 0) {
                              this.method_248(var1, this.field_587.field_452.field_131, this.field_587.field_452.field_132);
                              if (method_170(var1.field_131 - this.field_587.field_452.field_131) <= 1 && var1.field_132 == this.field_587.field_452.field_132
                                 || method_170(var1.field_132 - this.field_587.field_452.field_132) <= 1
                                    && var1.field_131 == this.field_587.field_452.field_131) {
                                 var1.field_143 = -1;
                                 var1.field_144 = -1;
                                 if (this.field_574 - var1.field_149 > 1400L) {
                                    this.method_242(var1, 5);
                                    var1.field_149 = this.field_574;
                                 }
                              } else if (this.field_574 - var1.field_149 > 500L) {
                                 int var9;
                                 if ((var9 = this.method_254(var2, var1.field_131, var1.field_132, false)) != -1
                                    && this.field_620[var9].field_138 == var1.field_138) {
                                    var1.field_138 = (byte)(var1.field_138 + (this.method_164() % 3 + 1 << 1));
                                 }

                                 var1.field_143 = this.field_587.field_452.field_131;
                                 var1.field_144 = this.field_587.field_452.field_132;
                                 this.method_242(var1, 1);
                              }
                           }
                        }
                     }
                  case 3:
                  case 7:
                  default:
                     break;
                  case 5:
                     if (field_618 == 0 || field_618 == 1 || var1.field_135 == 5 || var1.field_135 == 6 || var1.field_135 == 14 || var1.field_150) {
                        break;
                     }

                     if ((method_170(var1.field_131 - this.field_587.field_452.field_131) > 1 || var1.field_132 != this.field_587.field_452.field_132)
                        && (method_170(var1.field_132 - this.field_587.field_452.field_132) > 1 || var1.field_131 != this.field_587.field_452.field_131)) {
                        if (!this.field_705
                           || (method_170(var1.field_131 - this.field_587.field_452.field_131) != 2 || var1.field_132 != this.field_587.field_452.field_132)
                              && (method_170(var1.field_132 - this.field_587.field_452.field_132) != 2 || var1.field_131 != this.field_587.field_452.field_131)
                           )
                         {
                           if (var1.field_135 != 1 || var1.field_143 >= 0 && var1.field_144 >= 0) {
                              if (var1.field_135 == 1
                                 && (var1.field_143 != this.field_587.field_452.field_131 || var1.field_144 != this.field_587.field_452.field_132)) {
                                 var1.field_143 = this.field_587.field_452.field_131;
                                 var1.field_144 = this.field_587.field_452.field_132;
                              }
                           } else {
                              this.method_242(var1, 0);
                              var1.field_149 = this.field_574;
                           }
                        } else {
                           this.method_242(var1, 0);
                        }
                     } else {
                        this.field_705 = false;
                        this.method_242(var1, 0);
                     }

                     if (var1.field_135 != 0) {
                        break;
                     }

                     this.method_248(var1, this.field_587.field_452.field_131, this.field_587.field_452.field_132);
                     if ((method_170(var1.field_131 - this.field_587.field_452.field_131) > 1 || var1.field_132 != this.field_587.field_452.field_132)
                        && (method_170(var1.field_132 - this.field_587.field_452.field_132) > 1 || var1.field_131 != this.field_587.field_452.field_131)) {
                        if (this.field_705
                           && (
                              method_170(var1.field_131 - this.field_587.field_452.field_131) == 2 && var1.field_132 == this.field_587.field_452.field_132
                                 || method_170(var1.field_132 - this.field_587.field_452.field_132) == 2
                                    && var1.field_131 == this.field_587.field_452.field_131
                           )) {
                           var1.field_143 = -1;
                           var1.field_144 = -1;
                           if (this.field_574 - var1.field_149 > 1400L) {
                              this.method_242(var1, 6);
                              this.field_705 = false;
                           }
                        } else if (this.field_574 - var1.field_149 > 2000L) {
                           var1.field_143 = this.field_587.field_452.field_131;
                           var1.field_144 = this.field_587.field_452.field_132;
                           this.method_242(var1, 1);
                           if (this.method_165() % 100 < 15) {
                              this.field_705 = true;
                           }
                        }
                     } else {
                        var1.field_143 = -1;
                        var1.field_144 = -1;
                        if (this.field_574 - var1.field_149 > 1400L) {
                           this.method_242(var1, 5);
                        }
                     }
                     break;
                  case 6:
                     if (field_618 == 0 || field_618 == 1 || var1.field_135 == 5 || var1.field_150) {
                        break;
                     }

                     if ((method_170(var1.field_131 - this.field_587.field_452.field_131) > 1 || var1.field_132 != this.field_587.field_452.field_132)
                        && (method_170(var1.field_132 - this.field_587.field_452.field_132) > 1 || var1.field_131 != this.field_587.field_452.field_131)) {
                        if (var1.field_135 != 1 || var1.field_143 >= 0 && var1.field_144 >= 0) {
                           if (var1.field_135 == 1
                              && (var1.field_143 != this.field_587.field_452.field_131 || var1.field_144 != this.field_587.field_452.field_132)) {
                              var1.field_143 = this.field_587.field_452.field_131;
                              var1.field_144 = this.field_587.field_452.field_132;
                           }
                        } else {
                           this.method_242(var1, 0);
                           var1.field_149 = this.field_574;
                        }
                     } else {
                        this.method_242(var1, 0);
                     }

                     if (var1.field_135 != 0) {
                        break;
                     }

                     this.method_248(var1, this.field_587.field_452.field_131, this.field_587.field_452.field_132);
                     if (method_170(var1.field_131 - this.field_587.field_452.field_131) <= 1 && var1.field_132 == this.field_587.field_452.field_132
                        || method_170(var1.field_132 - this.field_587.field_452.field_132) <= 1 && var1.field_131 == this.field_587.field_452.field_131) {
                        var1.field_143 = -1;
                        var1.field_144 = -1;
                        if (this.field_574 - var1.field_149 > 1400L) {
                           this.method_242(var1, 5);
                           var1.field_149 = this.field_574;
                        }
                     } else if (this.field_574 - var1.field_149 > 500L) {
                        int var8;
                        if ((var8 = this.method_254(var2, var1.field_131, var1.field_132, false)) != -1 && this.field_620[var8].field_138 == var1.field_138) {
                           var1.field_138 = (byte)(var1.field_138 + (this.method_164() % 3 + 1 << 1));
                        }

                        var1.field_143 = this.field_587.field_452.field_131;
                        var1.field_144 = this.field_587.field_452.field_132;
                        this.method_242(var1, 1);
                     }
                     break;
                  case 8:
                     if (field_618 == 0 || field_618 == 1 || var1.field_135 == 5 || var1.field_135 == 6 || var1.field_135 == 14 || var1.field_150) {
                        break;
                     }

                     if ((method_170(var1.field_131 - this.field_587.field_452.field_131) > 1 || var1.field_132 != this.field_587.field_452.field_132)
                        && (method_170(var1.field_132 - this.field_587.field_452.field_132) > 1 || var1.field_131 != this.field_587.field_452.field_131)) {
                        if (!this.field_705
                           || (method_170(var1.field_131 - this.field_587.field_452.field_131) != 2 || var1.field_132 != this.field_587.field_452.field_132)
                              && (method_170(var1.field_132 - this.field_587.field_452.field_132) != 2 || var1.field_131 != this.field_587.field_452.field_131)
                           )
                         {
                           if (var1.field_135 != 1 || var1.field_143 >= 0 && var1.field_144 >= 0) {
                              if (var1.field_135 == 1
                                 && (var1.field_143 != this.field_587.field_452.field_131 || var1.field_144 != this.field_587.field_452.field_132)) {
                                 var1.field_143 = this.field_587.field_452.field_131;
                                 var1.field_144 = this.field_587.field_452.field_132;
                              }
                           } else {
                              this.method_242(var1, 0);
                              var1.field_149 = this.field_574;
                           }
                        } else {
                           this.method_242(var1, 0);
                        }
                     } else {
                        this.field_705 = false;
                        this.method_242(var1, 0);
                     }

                     if (var1.field_135 != 0) {
                        break;
                     }

                     this.method_248(var1, this.field_587.field_452.field_131, this.field_587.field_452.field_132);
                     if ((method_170(var1.field_131 - this.field_587.field_452.field_131) > 1 || var1.field_132 != this.field_587.field_452.field_132)
                        && (method_170(var1.field_132 - this.field_587.field_452.field_132) > 1 || var1.field_131 != this.field_587.field_452.field_131)) {
                        if (this.field_705
                           && (
                              method_170(var1.field_131 - this.field_587.field_452.field_131) == 2 && var1.field_132 == this.field_587.field_452.field_132
                                 || method_170(var1.field_132 - this.field_587.field_452.field_132) == 2
                                    && var1.field_131 == this.field_587.field_452.field_131
                           )) {
                           var1.field_143 = -1;
                           var1.field_144 = -1;
                           if (this.field_574 - var1.field_149 > 1000L) {
                              this.method_242(var1, 6);
                              this.field_705 = false;
                           }
                        } else if (this.field_574 - var1.field_149 > 1400L) {
                           int var7;
                           if ((var7 = this.method_254(var2, var1.field_131, var1.field_132, false)) != -1 && this.field_620[var7].field_138 == var1.field_138) {
                              var1.field_138 = (byte)(var1.field_138 + (this.method_164() % 3 + 1 << 1));
                           }

                           var1.field_143 = this.field_587.field_452.field_131;
                           var1.field_144 = this.field_587.field_452.field_132;
                           this.method_242(var1, 1);
                           if (this.method_165() % 100 < 25) {
                              this.field_705 = true;
                           }
                        }
                     } else {
                        var1.field_143 = -1;
                        var1.field_144 = -1;
                        if (this.field_574 - var1.field_149 > 1000L) {
                           if (this.method_165() % 100 < 40) {
                              this.method_242(var1, 6);
                           } else {
                              this.method_242(var1, 5);
                           }
                        }
                     }
                     break;
                  case 9:
                     if (field_618 != 0
                        && field_618 != 1
                        && var1.field_135 != 5
                        && !var1.field_150
                        && var1.field_135 == 0
                        && this.field_574 - var1.field_149 > 2000L) {
                        this.method_242(var1, 5);
                     }
                     break;
                  case 10:
                     if (var1.field_135 != 5
                        && !var1.field_150
                        && (
                           method_170(var1.field_131 - this.field_587.field_452.field_131) <= 1 && var1.field_132 == this.field_587.field_452.field_132
                              || method_170(var1.field_132 - this.field_587.field_452.field_132) <= 1 && var1.field_131 == this.field_587.field_452.field_131
                        )
                        && this.field_574 - var1.field_149 > 1400L) {
                        this.method_206(0, this.field_587.field_452.field_131, this.field_587.field_452.field_132, 54, 2);
                        this.method_242(var1, 5);
                     }
                     break;
                  case 11:
                     if (field_618 != 0 && field_618 != 1) {
                        if (var1.field_135 == 0 || var1.field_135 == 8) {
                           this.method_248(var1, this.field_587.field_452.field_131, this.field_587.field_452.field_132);
                           this.method_242(var1, 1);
                        }

                        int var3;
                        if (var1.field_135 == 1
                           && (var3 = this.method_254(var2, var1.field_131, var1.field_132, false)) != -1
                           && this.field_620[var3].field_138 == var1.field_138) {
                           var1.field_138 = (byte)(var1.field_138 + 2);
                           if (var1.field_138 > 7) {
                              var1.field_138 = 1;
                           }
                        }
                     }
               }

               if (var1.field_145) {
                  switch (var1.field_139) {
                     case 0:
                     case 1:
                        if (var1.field_143 >= 0 && var1.field_144 >= 0) {
                           break;
                        }

                        if ((field_594 & 512) == 0
                           && this.field_607 == 0
                           && this.field_587.field_452 == var1
                           && this.field_587.field_452.field_138 != 7
                           && field_618 == 2
                           && var1.field_131 == 36
                           && var1.field_132 == 17) {
                           this.method_267(false, 140, 0);
                           continue;
                        }

                        if ((field_594 & 512) == 0
                           && this.field_607 == 1
                           && this.field_587.field_452 == var1
                           && this.field_587.field_452.field_138 != 7
                           && field_618 == 2
                           && var1.field_131 == 14
                           && var1.field_132 == 4) {
                           this.method_267(false, 390, 0);
                        }
                        continue;
                     case 11:
                        if (var1.field_131 == this.field_587.field_452.field_131 && var1.field_132 == this.field_587.field_452.field_132) {
                           if (this.field_574 - var1.field_149 > 700L) {
                              this.method_206(0, this.field_587.field_452.field_131, this.field_587.field_452.field_132, 54, 2);
                              var1.field_149 = this.field_574;
                              byte var13 = -1;
                              class_15 var12 = this.field_587.field_452;
                              this.method_261(var12, var13, true);
                              this.method_144(30);
                           }
                           continue;
                        }

                        int var10 = this.method_253(this.field_587.field_452.field_131 - 1, this.field_587.field_452.field_132);
                        int var4 = this.method_253(this.field_587.field_452.field_131, this.field_587.field_452.field_132 - 1);
                        int var5 = this.method_253(this.field_587.field_452.field_131 + 1, this.field_587.field_452.field_132);
                        int var6 = this.method_253(this.field_587.field_452.field_131, this.field_587.field_452.field_132 + 1);
                        boolean var11;
                        if ((var10 == -1 || this.field_620[var10].field_139 == 11)
                           && (var4 == -1 || this.field_620[var4].field_139 == 11)
                           && (var5 == -1 || this.field_620[var5].field_139 == 11)
                           && (var6 == -1 || this.field_620[var6].field_139 == 11)) {
                           var11 = true;
                        } else {
                           var11 = false;
                        }

                        if (!var11) {
                           var1.field_143 = var1.field_131;
                           var1.field_144 = var1.field_132;
                        } else {
                           var1.field_143 = this.field_587.field_452.field_131;
                           var1.field_144 = this.field_587.field_452.field_132;
                        }
                  }

                  if ((var1.field_131 != var1.field_143 || var1.field_132 != var1.field_144) && var1.field_143 >= 0 && var1.field_144 >= 0) {
                     this.method_247(var1.field_131, var1.field_132, var1.field_143, var1.field_144);
                     if (this.field_684 != null) {
                        this.method_248(var1, this.field_684.field_126, this.field_684.field_127);
                     }
                  }
               }
            }
         }
      }
   }

   // $VF: renamed from: f (int, int) int
   private int method_253(int var1, int var2) {
      for (int var3 = 0; var3 < 25; var3++) {
         class_15 var4;
         if ((var4 = this.field_620[var3]).field_131 == var1
            && var4.field_132 == var2
            && var4.field_130
            && var4.field_135 != 3
            && var4.field_135 != 4
            && class_0.field_6[var4.field_139][0] != 0) {
            return var3;
         }
      }

      return -1;
   }

   // $VF: renamed from: a (int, int, int, boolean) int
   private int method_254(int var1, int var2, int var3, boolean var4) {
      if (var4) {
         if (this.field_589.field_452.field_131 == var2 && this.field_589.field_452.field_132 == var3 && this.field_589.field_452.field_130) {
            return 1;
         } else {
            return this.field_590.field_452.field_131 == var2 && this.field_590.field_452.field_132 == var3 && this.field_590.field_452.field_130 ? 2 : -1;
         }
      } else {
         for (int var6 = 2; var6 < 25; var6++) {
            class_15 var5;
            if ((var5 = this.field_620[var6]).field_131 == var2
               && var5.field_132 == var3
               && var6 != var1
               && var5.field_130
               && var5.field_135 != 3
               && var5.field_135 != 4) {
               return var6;
            }
         }

         return -1;
      }
   }

   // $VF: renamed from: a (int, int, int, int, boolean) int
   private int method_255(int var1, int var2, int var3, int var4, boolean var5) {
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

      return this.method_254(var1, var2, var3, var5);
   }

   // $VF: renamed from: a (p) int
   private int method_256(class_15 var1) {
      int var4 = var1.field_131;
      int var5 = var1.field_132;
      byte var7 = var1.field_138;
      int var11;
      if ((var11 = this.method_254(0, var4, var5, false)) != -1 && var11 != 2) {
         return var11;
      } else {
         for (int var2 = 1; var2 < 4; var2++) {
            var4 = method_257(var4, var7, 1);
            var5 = method_258(var5, var7, 1);
            if ((var11 = this.method_254(0, var4, var5, false)) != -1 && var11 != 2) {
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
               if ((var13 = this.method_254(0, var10, var18, false)) != -1 && var13 != 2) {
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

               if ((var11 = this.method_254(0, var19, var20, false)) != -1 && var11 != 2) {
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
   private static int method_257(int var0, int var1, int var2) {
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
   private static int method_258(int var0, int var1, int var2) {
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
   private int method_259(int var1, int var2, int var3) {
      for (int var4 = 0; var4 < this.field_640; var4++) {
         class_9 var6;
         if ((var6 = this.field_641[var4]).field_79 && var6.field_80) {
            byte var5 = this.field_641[var4].field_75;
            if (this.field_690[var5][6] == 0) {
               if (var6.field_81) {
                  if (method_227(var1, var2, var6.field_76, var6.field_77, this.field_690[var5][5], this.field_690[var5][4])) {
                     return var4;
                  }
               } else if (method_227(var1, var2, var6.field_76, var6.field_77, this.field_690[var5][4], this.field_690[var5][5])) {
                  return var4;
               }
            } else if (var3 == 1) {
               if (!var6.field_81 && method_227(var1, var2, var6.field_76, var6.field_77, this.field_690[var5][4], this.field_690[var5][5])) {
                  return var4;
               }
            } else if (var3 == 7) {
               if (var6.field_81 && method_227(var1, var2, var6.field_76, var6.field_77, this.field_690[var5][5], this.field_690[var5][4])) {
                  return var4;
               }
            } else if (var3 == 3) {
               if (var6.field_81 && method_227(var1, var2 + 1, var6.field_76, var6.field_77, this.field_690[var5][5], this.field_690[var5][4])) {
                  return var4;
               }
            } else if (var3 == 5
               && !var6.field_81
               && method_227(var1 + 1, var2, var6.field_76, var6.field_77, this.field_690[var5][4], this.field_690[var5][5])) {
               return var4;
            }
         }
      }

      return -1;
   }

   // $VF: renamed from: b (p, int) void
   final void method_260(class_15 var1, int var2) {
      this.method_261(var1, var2, true);
   }

   // $VF: renamed from: a (p, int, boolean) void
   private void method_261(class_15 var1, int var2, boolean var3) {
      if (var1.field_139 != 5 || this.field_587.field_452.field_141 > 0) {
         if (var1 != this.field_587.field_452 || this.field_623 == null || !this.field_623.field_130 || this.field_623.field_141 > 0) {
            if (var1.field_135 != 3 && var1.field_135 != 4) {
               if (var1.field_139 != 3) {
                  if (this.field_587.field_458 != 4 || this.field_588.field_452.field_139 != var1.field_139) {
                     if (var2 >= 128) {
                        var2 -= 256;
                     }

                     if (var1 == this.field_587.field_452 && method_317(1) && var2 < 0) {
                        var2 = 0;
                     }

                     if (var3 && var2 < 0 && (var1.field_139 == 0 || var1.field_139 == 1)) {
                        field_786 = 1000;
                        this.method_144(var1.field_139 == 0 ? 9 : 18);
                     }

                     if ((var2 = var1.field_141 + var2) > 128) {
                        var2 = 125;
                     }

                     if (var2 < -127) {
                        var2 = 0;
                     }

                     var1.field_141 = (byte)var2;
                     if (var1.field_141 < 0) {
                        var1.field_141 = 0;
                     } else if (var1.field_141 > var1.field_142) {
                        var1.field_141 = var1.field_142;
                     }

                     if (field_782
                        && this.field_587 != null
                        && this.field_587.field_462 == 3
                        && this.field_623 != null
                        && this.field_623.field_130
                        && var1 == this.field_587.field_452
                        && var1.field_141 <= 0) {
                        var1.field_141 = 1;
                     }

                     if (var1.field_141 <= 0) {
                        this.method_242(var1, 3);
                     }
                  }
               }
            }
         }
      }
   }

   // $VF: renamed from: d (int) void
   final void method_262(int var1) {
      field_752 = true;
      if (var1 >= 0 && var1 < this.field_640) {
         this.field_641[var1].field_79 = true;
      }
   }

   // $VF: renamed from: e (int) void
   final void method_263(int var1) {
      field_752 = true;
      if (var1 >= 0 && var1 < this.field_640) {
         this.field_641[var1].field_79 = false;
      }
   }

   // $VF: renamed from: d (int, int) void
   final void method_264(int var1, int var2) {
      field_752 = true;
      if (var1 >= 0 && var1 < this.field_640) {
         if (var2 >= 0 && var2 < this.field_641[var1].field_83) {
            this.field_641[var1].field_82[var2].field_155 = true;
         }
      }
   }

   // $VF: renamed from: e (int, int) void
   final void method_265(int var1, int var2) {
      field_752 = true;
      if (var1 >= 0 && var1 < this.field_640) {
         if (var2 >= 0 && var2 < this.field_641[var1].field_83) {
            this.field_641[var1].field_82[var2].field_155 = false;
            if (var1 == 224) {
               this.field_641[var1].field_79 = false;
            }
         }
      }
   }

   // $VF: renamed from: L () void
   private void method_266() {
      field_659 = 0;
      field_660 = 0;
      this.field_658 = 2;
      field_618 = 2;
      field_617 = 0;
   }

   // $VF: renamed from: a (boolean, int, int) void
   private void method_267(boolean var1, int var2, int var3) {
      this.field_662.field_320 = 8;
      this.field_662.field_322 = var1;
      this.field_662.field_323 = false;
      this.field_662.field_324 = (short)var2;
      this.field_662.field_325 = 0;
      this.method_268(this.field_662);
   }

   // $VF: renamed from: a (i) void
   private void method_268(class_19 var1) {
      this.field_661[field_660] = var1;
      field_660 = (byte)((field_660 + 1) % 20);
      if (this.field_658 == 2) {
         this.field_658 = 0;
      }
   }

   // $VF: renamed from: M () void
   private void method_269() {
      if ((field_659 = (byte)((field_659 + 1) % 20)) == field_660) {
         this.field_658 = 2;
      } else {
         this.field_658 = 0;
      }
   }

   // $VF: renamed from: N () void
   private void method_270() {
      if (!method_317(3)) {
         if (this.field_658 == 1) {
            class_19 var1;
            byte var2 = (var1 = this.field_661[field_659]).field_321;
            switch (var1.field_320) {
               case 0:
               case 1:
               case 2:
               case 3:
               case 4:
               case 5:
               case 6:
               case 7:
                  if (field_594 == 131) {
                     return;
                  }
                  break;
               case 8:
                  if (field_618 != 2) {
                     return;
                  }
                  break;
               case 9:
                  class_15 var3;
                  switch (var2) {
                     case 0:
                        var3 = this.field_589.field_452;
                        break;
                     case 1:
                        var3 = this.field_590.field_452;
                        break;
                     case 2:
                        var3 = this.field_587.field_452;
                        break;
                     case 3:
                        var3 = this.field_621;
                        break;
                     case 4:
                        var3 = this.field_622;
                        break;
                     case 5:
                     case 6:
                     default:
                        this.method_269();
                        return;
                     case 7:
                        var3 = this.field_625;
                  }

                  if (var3.field_143 != -1 || var3.field_144 != -1) {
                     return;
                  }
               case 10:
            }

            this.method_269();
         }
      }
   }

   // $VF: renamed from: O () void
   private void method_271() {
      if (!field_580) {
         if (this.field_658 != 2) {
            this.method_270();

            while (this.field_658 == 0) {
               this.field_658 = 1;
               class_19 var1;
               byte var2;
               if ((var2 = (var1 = this.field_661[field_659]).field_321) == 2) {
                  var2 = this.field_587.field_452.field_139;
               }

               label115:
               switch (var1.field_320) {
                  case 0:
                     short var12 = var1.field_325;
                     if (var1.field_324 != -1) {
                        if (this.field_587.field_452.field_139 == 0) {
                           var12 = var1.field_324;
                        } else if (this.field_587.field_452.field_139 == 1) {
                           var12 = var1.field_325;
                        }
                     }

                     short var5 = -1;
                     switch (this.field_607) {
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
                           var5 = 362;
                     }

                     int var13;
                     String var6 = method_361(var13 = var5 + var12 / 5);
                     this.method_286(0, var2, var6, 0);
                     break;
                  case 1:
                     switch ((byte)var1.field_324) {
                        case 2:
                        case 3:
                        case 4:
                        case 5:
                           if (this.field_587.field_454[(byte)var1.field_324].field_117) {
                              int var3 = (byte)var1.field_324;
                              switch (var3) {
                                 case 2:
                                    this.field_587.field_457[1] = (byte)(this.field_587.field_457[1] + 25);
                                    if (this.field_587.field_457[1] > 100) {
                                       this.field_587.field_457[1] = 100;
                                    }
                                    break;
                                 case 3:
                                    this.field_587.field_457[2] = (byte)(this.field_587.field_457[2] + 20);
                                    if (this.field_587.field_457[2] > 100) {
                                       this.field_587.field_457[2] = 100;
                                    }
                                    break;
                                 case 4:
                                    this.field_587.field_457[3] = (byte)(this.field_587.field_457[3] + 20);
                                    if (this.field_587.field_457[3] > 100) {
                                       this.field_587.field_457[3] = 100;
                                    }
                                    break;
                                 case 5:
                                    this.field_587.field_457[4] = (byte)(this.field_587.field_457[4] + 10);
                                    if (this.field_587.field_457[4] > 100) {
                                       this.field_587.field_457[4] = 100;
                                    }
                              }

                              this.field_688.setLength(0);
                              var3 = (byte)27;
                              this.field_688.append(new String(method_361(27)));
                              this.field_688.append(' ');
                              var3 = this.field_587.field_454[var1.field_324].field_119;
                              this.field_688.append(method_361(this.field_587.field_454[var1.field_324].field_119));
                              this.field_688.append('.');
                              this.method_286(2, (byte)var1.field_324, this.field_688.toString(), 0);
                              break label115;
                           }
                        default:
                           this.method_291(var1.field_324);
                           break label115;
                     }
                  case 2:
                     this.method_292((byte)var1.field_324);
                     if (var1.field_325 >= 0) {
                     }
                     break;
                  case 3:
                     short var4 = var1.field_324;
                     class_15 var9 = this.field_587.field_452;
                     this.method_261(var9, var4, true);
                     if (var1.field_325 >= 0) {
                     }
                     break;
                  case 4:
                     this.method_263(var1.field_324);
                     if (var1.field_325 >= 0) {
                     }
                     break;
                  case 5:
                     this.method_262(var1.field_324);
                     if (var1.field_325 >= 0) {
                     }
                     break;
                  case 6:
                     this.method_265(var1.field_324, var1.field_325);
                     break;
                  case 7:
                     this.method_264(var1.field_324, var1.field_325);
                     break;
                  case 8:
                     field_618 = 0;
                     field_617 = var1.field_324;
                     break;
                  case 9:
                     class_15 var8;
                     switch (var2) {
                        case 0:
                           var8 = this.field_589.field_452;
                           break;
                        case 1:
                           var8 = this.field_590.field_452;
                           break;
                        case 2:
                           var8 = this.field_587.field_452;
                           break;
                        case 3:
                           var8 = this.field_621;
                           break;
                        case 4:
                           var8 = this.field_622;
                           break;
                        case 5:
                        case 6:
                        default:
                           continue;
                        case 7:
                           var8 = this.field_625;
                     }

                     this.method_251(var8, var1.field_324, var1.field_325);
                     break;
                  case 10:
                     this.method_272(var1.field_324, var1.field_325);
               }

               this.method_270();
            }

            int var7 = 0;

            while (field_618 != 2 && var7 != 1) {
               if ((var7 = field_743.method_83()) == 0) {
                  var7 = field_744.method_28();
               }

               if (var7 == 0) {
                  var7 = field_745.method_3();
               }

               if (var7 == 0) {
                  method_273(true);
                  break;
               }
            }
         }
      }
   }

   // $VF: renamed from: f (int, int) void
   public final void method_272(int var1, int var2) {
      this.method_262(var1);
      this.method_263(var2);
   }

   // $VF: renamed from: c (boolean) void
   static void method_273(boolean var0) {
      if (field_618 != 2) {
         if (var0) {
            field_618 = 2;
            field_617 = 0;
         } else if (field_618 != 0 && field_618 != 3) {
            field_618 = 0;
            field_617++;
         } else {
            field_618 = 1;
         }
      }
   }

   // $VF: renamed from: f (int) void
   final void method_274(int var1) {
      class_13 var2 = this.field_587.field_454[0];

      for (int var3 = 0; var3 < var2.field_122; var3++) {
         if (!this.field_657[var2.field_123[var3].field_441].field_323
            && this.field_657[var2.field_123[var3].field_441].field_320 != 8
            && var2.field_123[var3].field_440 == var1
            && this.field_657[var2.field_123[var3].field_441].field_322) {
            this.field_657[var2.field_123[var3].field_441].field_323 = true;
         }
      }
   }

   // $VF: renamed from: a (int, int, boolean) boolean
   private boolean method_275(int var1, int var2, boolean var3) {
      class_13 var4 = this.field_587.field_454[var1];
      boolean var6 = false;
      boolean var7 = false;

      for (int var8 = 0; var8 < var4.field_122; var8++) {
         class_19 var5;
         if (!(var5 = this.field_657[var4.field_123[var8].field_441]).field_323 && var4.field_123[var8].field_440 == var2) {
            var6 = true;
            if (!var3) {
               if (var5.field_320 == 8 && var5.field_324 == 190) {
                  field_779 = 1;
               } else if (var2 == 499) {
                  field_779 = 1;
               } else if (var2 == 175) {
                  field_779 = 1;
               } else {
                  field_779 = var5.field_320;
               }
               break;
            }

            this.method_268(var5);
            if (!var5.field_322) {
               var5.field_323 = true;
            }

            if (this.field_641[var2].field_78) {
               if (var5.field_320 == 0) {
                  this.method_144(11);
               }

               if (var5.field_320 == 4) {
                  this.method_144(12);
               }
            }

            if (this.field_607 == 0 && var1 == 0 && (var2 == 147 || var2 == 497) && (var5.field_320 == 4 || var5.field_320 == 5)) {
               this.method_144(19);
            }

            if (var2 == 522 && var1 == 0) {
               this.method_144(11);
            }

            if (var5.field_320 == 2) {
               var7 = true;
            } else if (var5.field_320 == 10) {
               this.method_144(19);
            }
         }
      }

      if (!var3) {
         return var6;
      } else {
         if (this.field_587 == this.field_589) {
            var3 = false;
         } else {
            var3 = true;
         }

         if (!var6) {
            if (var1 == 0) {
               short var11 = 0;
               short var13 = 0;
               if (this.field_607 == 0) {
                  var11 = 547;
                  var13 = 619;
               } else if (this.field_607 == 1) {
                  var11 = 691;
                  var13 = 748;
               } else if (this.field_607 == 2) {
                  var11 = 805;
                  var13 = 839;
               } else if (this.field_607 == 3) {
                  var11 = 873;
                  var13 = 887;
               }

               short var10000 = !var3 ? var11 : var13;
               short var10 = !var3 ? var11 : var13;
               if (method_361(var10000 + this.field_641[var2].field_75) != null) {
                  int var12;
                  this.method_286(0, 2, method_361(var12 = var10 + this.field_641[var2].field_75), 0);
               }
            }
         } else if (var1 == 13) {
            this.field_587.field_455 = 0;
         }

         if (var7 && var1 != 0) {
            this.method_274(var2);
         }

         return var6;
      }
   }

   // $VF: renamed from: P () void
   private void method_276() {
      if (this.field_587.field_457[5] > 0) {
         if (this.field_587.field_452.field_141 == this.field_587.field_452.field_142) {
            byte var5 = 28;
            this.method_286(0, 2, method_361(28), 0);
         } else {
            byte var3 = this.field_587.field_452.field_142;
            class_15 var2 = this.field_587.field_452;
            this.method_261(var2, var3, true);
            this.field_587.field_457[5]--;
            this.method_144(17);
            if (this.field_587.field_452.field_139 == 0) {
               byte var4 = 34;
               this.method_286(0, 2, method_361(34), 0);
            } else {
               byte var1 = 35;
               this.method_286(0, 2, method_361(35), 0);
            }
         }
      }
   }

   // $VF: renamed from: e (int) boolean
   private boolean method_277(int var1) {
      class_26 var4;
      if (this.field_591 == 1) {
         var4 = this.field_590;
      } else {
         var4 = this.field_589;
      }

      if (this.field_587.field_455 == 6) {
         this.method_276();
         return false;
      } else {
         int var2 = this.field_587.field_452.field_131;
         int var3 = this.field_587.field_452.field_132;
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

         if (var4.field_452.field_131 == var9 && var4.field_452.field_132 == var11 && var4.field_462 == this.field_587.field_462) {
            if (this.field_673[this.field_587.field_452.field_131][this.field_587.field_452.field_132]
               != this.field_673[var4.field_452.field_131][var4.field_452.field_132]) {
               return false;
            } else {
               int var5 = var4.field_452.field_132;
               byte var13 = var4.field_452.field_131;
               byte var12 = this.field_587.field_452.field_132;
               byte var10 = this.field_587.field_452.field_131;
               if (var13 > var10 || var5 > var12) {
                  byte var6 = var10;
                  var10 = var13;
                  var13 = var6;
                  var6 = var12;
                  var12 = (byte)var5;
                  var5 = var6;
               }

               int var14 = var10 - var13;
               var5 = var12 - var5;
               if (var14 <= 1 && var5 <= 1 && (var14 <= 0 || var5 <= 0)
                  ? (var14 > 0 && this.field_671[var10][var12] != -1 ? true : var5 > 0 && this.field_672[var10][var12] != -1)
                  : false) {
                  return false;
               } else {
                  field_594 = 138;
                  this.field_694 = 0;
                  if (this.field_689[2 * this.field_589.field_455 + 1] != 0) {
                     this.field_695 = this.field_689[2 * this.field_589.field_455 + 1];
                     this.field_697 = this.method_295(this.field_589.field_455);
                  } else {
                     this.field_695 = 1;
                     this.field_697 = 1;
                  }

                  if (this.field_689[2 * this.field_590.field_455 + 1] != 0) {
                     this.field_696 = this.field_689[2 * this.field_590.field_455 + 1];
                     this.field_698 = this.method_295(this.field_590.field_455);
                  } else {
                     this.field_696 = 1;
                     this.field_698 = 1;
                  }

                  this.field_699 = 0;
                  this.field_700 = 0;
                  this.field_666 = this.field_574;
                  method_157();
                  method_156();
                  return true;
               }
            }
         } else if (this.field_587.field_455 == 13 && this.field_587 == this.field_590) {
            short var8 = 140;
            this.method_286(0, 1, method_361(140), 0);
            return true;
         } else {
            this.field_639 = (short)this.method_259(var9, var11, var1);
            if (this.field_639 < 0) {
               return false;
            } else if (!this.field_641[this.field_639].field_78
               && this.field_609 != this.field_673[this.field_641[this.field_639].field_76][this.field_641[this.field_639].field_77]) {
               return false;
            } else {
               boolean var7 = this.method_275(this.field_587.field_455, this.field_639, true);
               return field_594 == 131 ? true : var7;
            }
         }
      }
   }

   // $VF: renamed from: Q () void
   private void method_278() {
      if (!field_580) {
         for (int var2 = 0; var2 < 25; var2++) {
            if (this.field_620[var2].field_130 && this.field_620[var2].field_131 < this.field_668 && this.field_620[var2].field_132 < this.field_669) {
               class_15 var1 = this.field_620[var2];
               if (this.field_609 == this.field_673[var1.field_131][var1.field_132] || method_202(var1)) {
                  byte var3 = var1.field_138;
                  if (field_541[var1.field_139][var1.field_135][2] != 0) {
                     if (var1.field_135 == 2 || var1.field_135 == 14) {
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

                     if (var1.field_145) {
                        if (!this.method_246(var1.field_131, var1.field_132, var3, (field_594 & 512) > 0)) {
                           if ((var1.field_139 != 3 || var1.field_135 != 5 || this.field_607 != 0)
                              && (
                                 var1.field_139 != 5
                                    || this.field_607 != 3
                                    || var1.field_132 != 3
                                    || var1.field_131 < 2 && var1.field_132 > 4
                                    || !this.field_641[21].field_79
                              )) {
                              var1.field_136 = var1.field_135;
                              this.method_242(var1, 0);
                           }
                           continue;
                        }

                        var1.field_136 = -1;
                     }

                     if (var1.field_133 == field_541[var1.field_139][var1.field_135][2] && var1.field_133 != var1.field_134) {
                        if (this.method_255(var2, var1.field_131, var1.field_132, var1.field_138, false) != -1) {
                           if (var1.field_139 != 11 && var1.field_139 != 8) {
                              this.method_242(var1, 0);
                           } else {
                              this.method_188(var1, var3);
                           }
                        } else if (var1.field_139 != 2
                           && var1.field_139 != 4
                           && var1.field_139 != 6
                           && var1.field_139 != 0
                           && var1.field_139 != 1
                           && var1.field_139 != 3) {
                           this.method_188(var1, var3);
                        } else if (this.method_255(var2, var1.field_131, var1.field_132, var1.field_138, true) != -1) {
                           this.method_242(var1, 0);
                        } else {
                           this.method_188(var1, var3);
                        }

                        if ((var1.field_139 == 0 || var1.field_139 == 1)
                           && this.field_609 != this.field_673[this.field_587.field_452.field_131][this.field_587.field_452.field_132]) {
                           this.method_214(true);
                        }
                     }
                  } else if ((var1.field_143 != -1 || var1.field_144 != -1) && var1.field_135 != 3 && var1.field_135 != 4 && var1.field_136 != -1) {
                     if (this.method_246(var1.field_131, var1.field_132, var3, false)) {
                        this.method_242(var1, var1.field_136);
                        var1.field_136 = -1;
                     }
                  } else if ((var1.field_143 != -1 || var1.field_144 != -1) && var1.field_135 == 0) {
                     this.method_242(var1, 1);
                  }

                  if (var1.field_133 != var1.field_134) {
                     switch (var1.field_139) {
                        case 0:
                        case 1:
                           if (var1.field_135 == 7 && var1.field_133 == 1) {
                              this.field_736++;
                              this.field_741++;
                              this.method_319();
                              int var4 = this.field_756;
                              if (this.field_612 < 0) {
                                 return;
                              }

                              if (var4 == 2) {
                                 this.field_739++;
                                 this.field_737++;
                                 class_15 var10001 = this.field_620[this.field_612];
                                 byte var41 = -10;
                                 class_15 var32 = var10001;
                                 this.method_261(var32, var41, true);
                                 this.method_282();
                              } else if (var4 == 0) {
                                 this.field_738++;
                                 int var8 = this.method_205(this.field_587.field_452, 0, 1) ? -27 : 0;
                                 this.method_206(1, this.field_613, this.field_614, 54, var8);
                                 this.method_319();
                              } else {
                                 this.method_319();
                                 this.field_737++;
                                 class_15 var46 = this.field_620[this.field_612];
                                 byte var42 = -3;
                                 class_15 var33 = var46;
                                 this.method_261(var33, var42, true);
                                 this.method_282();
                              }

                              if (var4 != 0 && this.field_620[this.field_612].field_141 > 0 && method_243(this.field_620[this.field_612].field_139)) {
                                 this.method_144(28 + (this.method_165() & 1));
                              }
                           }
                           break;
                        case 2:
                        case 4:
                           if (var1.field_135 == 5
                              && (var1.field_133 == 4 || var1.field_133 == 3)
                              && (
                                 this.method_250(var1, this.field_587.field_452.field_131, this.field_587.field_452.field_132)
                                    || var1.field_131 == this.field_587.field_452.field_131 && var1.field_132 == this.field_587.field_452.field_132
                              )) {
                              this.method_206(0, this.field_587.field_452.field_131, this.field_587.field_452.field_132, 54, 2);
                              byte var40 = -2;
                              class_15 var31 = this.field_587.field_452;
                              this.method_261(var31, var40, true);
                           }
                        case 3:
                        case 7:
                        case 10:
                        case 11:
                        default:
                           break;
                        case 5:
                           if (var1.field_135 == 3 && var1.field_133 == 2) {
                              this.method_267(true, 730, 0);
                           }

                           if (var1.field_135 == 5 && (var1.field_133 == 5 || var1.field_133 == 6)) {
                              if (this.method_250(var1, this.field_587.field_452.field_131, this.field_587.field_452.field_132)
                                 || var1.field_131 == this.field_587.field_452.field_131 && var1.field_132 == this.field_587.field_452.field_132) {
                                 this.method_206(0, this.field_587.field_452.field_131, this.field_587.field_452.field_132, 54, 2);
                                 byte var39 = -2;
                                 class_15 var30 = this.field_587.field_452;
                                 this.method_261(var30, var39, true);
                              }
                           } else if (var1.field_135 == 6
                              && var1.field_133 > 3
                              && var1.field_133 < 8
                              && var1.field_131 == this.field_587.field_452.field_131
                              && var1.field_132 == this.field_587.field_452.field_132) {
                              this.method_206(0, this.field_587.field_452.field_131, this.field_587.field_452.field_132, 54, 2);
                              byte var38 = -2;
                              class_15 var29 = this.field_587.field_452;
                              this.method_261(var29, var38, true);
                           }
                           break;
                        case 6:
                           if (var1.field_135 == 5
                              && (var1.field_133 == 2 || var1.field_133 == 3)
                              && (
                                 this.method_250(var1, this.field_587.field_452.field_131, this.field_587.field_452.field_132)
                                    || var1.field_131 == this.field_587.field_452.field_131 && var1.field_132 == this.field_587.field_452.field_132
                              )) {
                              this.method_206(0, this.field_587.field_452.field_131, this.field_587.field_452.field_132, 54, 2);
                              byte var37 = -4;
                              class_15 var28 = this.field_587.field_452;
                              this.method_261(var28, var37, true);
                           }
                           break;
                        case 8:
                           if ((var1.field_135 == 5 && var1.field_133 == 1 || var1.field_135 == 6 && var1.field_133 == 2)
                              && (
                                 this.method_250(var1, this.field_587.field_452.field_131, this.field_587.field_452.field_132)
                                    || var1.field_131 == this.field_587.field_452.field_131 && var1.field_132 == this.field_587.field_452.field_132
                              )) {
                              this.method_206(0, this.field_587.field_452.field_131, this.field_587.field_452.field_132, 54, 2);
                              byte var6 = -2;
                              class_15 var5 = this.field_587.field_452;
                              this.method_261(var5, var6, true);
                           }
                           break;
                        case 9:
                           if (var1.field_135 == 5 && var1.field_133 == 2) {
                              this.method_208(
                                 7, var1.field_131, var1.field_132, this.field_587.field_452.field_131, this.field_587.field_452.field_132, var1.field_138
                              );
                           }
                     }
                  }
               }
            }
         }

         if (field_594 != 646 && field_594 != 647) {
            for (int var14 = 0; var14 < 10; var14++) {
               if (this.field_629[var14].field_425) {
                  switch (this.field_629[var14].field_428) {
                     case 4:
                        int var21 = (int)(this.field_574 - this.field_629[var14].field_427);
                        int var27 = this.field_629[var14].field_429
                           + var21 * (this.field_629[var14].field_431 - this.field_629[var14].field_429) / (this.field_629[var14].field_433 * 5);
                        int var12 = this.field_629[var14].field_430
                           + var21 * (this.field_629[var14].field_432 - this.field_629[var14].field_430) / (this.field_629[var14].field_433 * 5);
                        int var22;
                        var21 = 20 - var21 * var21 * 20 / ((var22 = this.field_629[var14].field_433 * 5) * var22);
                        this.field_629[var14].field_426.field_447 = (short)var27;
                        this.field_629[var14].field_426.field_448 = (short)var12;
                        this.field_629[var14].field_426.field_449 = (short)var21;
                        if (this.field_629[var14].field_426.field_449 <= 0) {
                           this.method_206(37 + this.field_721, this.field_629[var14].field_435, this.field_629[var14].field_436, 0, 0);
                           this.field_629[var14].field_425 = false;

                           for (int var13 = 1; var13 < 25; var13++) {
                              if (this.field_620[var13].field_130
                                 && this.field_620[var13].field_135 != 3
                                 && this.field_620[var13].field_135 != 4
                                 && method_170(this.field_613 - this.field_620[var13].field_131) <= 1
                                 && method_170(this.field_614 - this.field_620[var13].field_132) <= 1) {
                                 this.field_737++;
                                 if (this.field_620[var13].field_139 != 1 && this.field_620[var13].field_139 != 0) {
                                    class_15 var47 = this.field_620[var13];
                                    byte var44 = -20;
                                    class_15 var35 = var47;
                                    this.method_261(var35, var44, true);
                                    if (this.field_620[var13].field_139 == 5) {
                                       try {
                                          if (this.field_620[var13].field_141 > 0
                                             && this.field_673[this.field_620[var13].field_131][this.field_620[var13].field_132 - 1] == this.field_609
                                             && this.field_673[this.field_620[var13].field_131][this.field_620[var13].field_132 + 1] == this.field_609
                                             && this.field_673[this.field_620[var13].field_131 - 1][this.field_620[var13].field_132] == this.field_609
                                             && this.field_673[this.field_620[var13].field_131 + 1][this.field_620[var13].field_132] == this.field_609) {
                                             this.method_242(this.field_620[var13], 14);
                                          }
                                       } catch (Exception var7) {
                                       }
                                    }

                                    if (this.field_620[var13].field_139 == 9 && this.field_721 == 1) {
                                       var47 = this.field_620[var13];
                                       var44 = -30;
                                       var35 = var47;
                                       this.method_261(var35, var44, true);
                                    }

                                    this.method_206(0, this.field_620[var13].field_131, this.field_620[var13].field_132, 54, 2);
                                 }
                              }
                           }

                           if (field_787) {
                              field_787 = false;
                           } else {
                              this.method_144(13);
                           }
                        }
                     case 5:
                     case 6:
                     default:
                        break;
                     case 7:
                        int var18 = (int)(this.field_574 - this.field_629[var14].field_427);
                        int var25 = this.field_629[var14].field_429
                           + var18 * (this.field_629[var14].field_431 - this.field_629[var14].field_429) / (this.field_629[var14].field_433 * 10);
                        int var10 = this.field_629[var14].field_430
                           + var18 * (this.field_629[var14].field_432 - this.field_629[var14].field_430) / (this.field_629[var14].field_433 * 10);
                        int var19;
                        var18 = 40 - var18 * var18 * 40 / ((var19 = this.field_629[var14].field_433 * 10) * var19);
                        this.field_629[var14].field_426.field_447 = (short)var25;
                        this.field_629[var14].field_426.field_448 = (short)var10;
                        this.field_629[var14].field_426.field_449 = (short)var18;
                        var25 = this.method_231(this.field_629[var14].field_426.field_447, this.field_629[var14].field_426.field_448);
                        var10 = this.method_230(this.field_629[var14].field_426.field_447, this.field_629[var14].field_426.field_448);
                        if (this.field_587.field_452.field_131 == var25 && this.field_587.field_452.field_132 == var10) {
                           this.field_629[var14].field_425 = false;
                           byte var43 = -2;
                           class_15 var34 = this.field_587.field_452;
                           this.method_261(var34, var43, true);
                        }

                        if (this.field_629[var14].field_426.field_449 <= 0) {
                           this.field_629[var14].field_425 = false;
                        }
                        break;
                     case 8:
                        int var15 = (int)(this.field_574 - this.field_629[var14].field_427);
                        int var24 = this.field_629[var14].field_429
                           + var15 * (this.field_629[var14].field_431 - this.field_629[var14].field_429) / (this.field_629[var14].field_433 * 5);
                        int var9 = this.field_629[var14].field_430
                           + var15 * (this.field_629[var14].field_432 - this.field_629[var14].field_430) / (this.field_629[var14].field_433 * 5);
                        int var16;
                        var15 = 20 - var15 * var15 * 20 / ((var16 = this.field_629[var14].field_433 * 5) * var16);
                        this.field_629[var14].field_426.field_447 = (short)var24;
                        this.field_629[var14].field_426.field_448 = (short)var9;
                        this.field_629[var14].field_426.field_449 = (short)var15;
                        if (this.field_629[var14].field_426.field_449 <= 0) {
                           this.method_206(39, this.field_629[var14].field_435, this.field_629[var14].field_436, 0, 0);
                           this.field_629[var14].field_425 = false;
                        }
                  }

                  this.field_629[var14].field_426.field_445 = (byte)this.method_231(
                     this.field_629[var14].field_426.field_447, this.field_629[var14].field_426.field_448
                  );
                  this.field_629[var14].field_426.field_446 = (byte)this.method_230(
                     this.field_629[var14].field_426.field_447, this.field_629[var14].field_426.field_448
                  );
               }
            }
         }
      }
   }

   // $VF: renamed from: c (p, int) void
   static void method_279(class_15 var0, int var1) {
      var1 = var1 + 8 & 7;
      var0.field_138 = (byte)var1;
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, byte, int, int) void
   private void method_280(Graphics var1, int var2, int var3, int var4) {
      class_21 var10000 = field_549[1];
      int var10002 = var3 + 2;
      int var6 = var4 + 1;
      int var5 = var10002;
      var10000.method_101(var1, 0, var5, var6, 0, 0, 0);
      var10000 = field_549[1];
      var2 = 1 + this.field_587.field_454[var2].field_120;
      var10000.method_101(var1, var2, var5, var6, 0, 0, 0);
   }

   // $VF: renamed from: R () void
   private void method_281() {
      this.field_755 = 0;
      this.field_756 = 0;
      this.field_757 = 3;
   }

   // $VF: renamed from: S () void
   private void method_282() {
      field_555.method_5(0, 1);
      if (this.field_620[this.field_612].field_139 != 11 && this.field_620[this.field_612].field_139 != 8) {
         int var6 = this.field_754 - (this.field_755 >> 8);
         int var5 = this.field_753;
         class_11 var4 = field_555;
         field_555.field_87 = var5;
         var4.field_88 = var6;
      } else {
         int var2 = this.field_754;
         int var1 = this.field_753;
         class_11 var3 = field_555;
         field_555.field_87 = var1;
         var3.field_88 = var2;
      }
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, int, int) void
   private void method_283(Graphics var1, int var2, int var3) {
      int var4 = this.field_755 >> 8;
      if (this.field_755 < this.field_758) {
         this.field_756 = 0;
         this.field_757 = 3;
      } else if (this.field_755 < this.field_759) {
         this.field_756 = 1;
         this.field_757 = 1;
      } else if (this.field_755 < this.field_760) {
         this.field_756 = 2;
         this.field_757 = 2;
      } else if (this.field_755 < this.field_762) {
         this.field_756 = 1;
         this.field_757 = 1;
      } else if (this.field_755 < this.field_761) {
         this.field_756 = 0;
         this.field_757 = 3;
      } else {
         this.field_756 = 0;
         this.field_757 = 0;
      }

      if (this.field_620[this.field_612].field_139 == 11 && this.field_756 == 1) {
         this.field_756 = 2;
         this.field_757 = 2;
      }

      if (var2 == 0) {
         class_21 var29 = field_549[0];
         var4 = this.field_754 - var4;
         var2 = this.field_753;
         var29.method_101(var1, var3, var2, var4, 0, 0, 0);
      } else {
         if (this.field_620[this.field_612].field_138 > 4) {
            class_21 var10000 = field_549[0];
            int var10003 = this.field_763[2] + var4;
            int var8 = this.field_763[3];
            int var7 = var10003;
            var10000.method_101(var1, var3, var7, var8, 0, 0, 0);
            var10000 = field_549[0];
            int var10002 = var3 + 1;
            var10003 = this.field_763[0] - var4;
            var8 = this.field_763[1];
            var7 = var10003;
            int var6 = var10002;
            var10000.method_101(var1, var6, var7, var8, 0, 0, 0);
         } else {
            class_21 var25 = field_549[0];
            int var34 = this.field_763[0] + var4;
            int var21 = this.field_763[1];
            int var17 = var34;
            var25.method_101(var1, var3, var17, var21, 0, 0, 0);
            var25 = field_549[0];
            int var30 = var3 + 1;
            var34 = this.field_763[2] - var4;
            var21 = this.field_763[3];
            var17 = var34;
            int var14 = var30;
            var25.method_101(var1, var14, var17, var21, 0, 0, 0);
         }

         class_21 var27 = field_549[0];
         int var31 = var3 + 2;
         int var36 = this.field_763[4];
         int var23 = this.field_763[5] + var4;
         int var19 = var36;
         int var15 = var31;
         var27.method_101(var1, var15, var19, var23, 0, 0, 0);
         var27 = field_549[0];
         var31 = var3 + 3;
         var36 = this.field_763[6];
         var4 = this.field_763[7] - var4;
         var3 = var36;
         var2 = var31;
         var27.method_101(var1, var2, var3, var4, 0, 0, 0);
      }
   }

   // $VF: renamed from: d (javax.microedition.lcdui.Graphics) void
   private void method_284(Graphics var1) {
      switch (field_594) {
         case 646:
            class_27 var10;
            if ((var10 = this).field_755 == 0) {
               class_15 var3;
               byte var4 = (var3 = var10.field_620[var10.field_612]).field_139;
               boolean var5 = var3.field_138 > 4;
               int var6 = field_541[var3.field_139][var3.field_135][4];
               if (field_541[var3.field_139][var3.field_135][3] == 4) {
                  if (var4 != 9) {
                     var6 = class_0.field_11[var3.field_139][var6][var10.method_205(var3, 0, 1) ? 0 : 1][var3.field_133];
                  } else {
                     byte var13 = field_541[var3.field_139][var3.field_135][5];
                     var6 = class_0.field_12[var13][var10.method_205(var3, 0, 1) ? 0 : 1][var3.field_133];
                  }
               } else {
                  var6 = class_0.field_13[var6][var5 ? 8 - var3.field_138 : var3.field_138][var3.field_133];
               }

               if (var4 != 11 && var4 != 8) {
                  if (var3.field_139 == 4) {
                     var4 = 2;
                  }

                  int[] var16 = new int[8];
                  if (var4 != 9) {
                     var16 = field_545[var4].method_98(var6, var16, 0, 0);
                  } else {
                     var16 = field_547[var3.field_140].method_98(var6, var16, 0, 0);
                  }

                  if (var16 != null) {
                     var10.field_753 = var10.method_228(var3.field_131, var3.field_132) - var10.field_597 + (var5 ? -var16[0] + 108 : var16[0]);
                     byte var21 = var3.field_132;
                     byte var19 = var3.field_131;
                     var10.field_754 = (var21 + var19) * 27 - var10.field_598 + var16[1];
                     var10.field_758 = 4608;
                     var10.field_759 = var16[1] - var16[3] << 8;
                     var10.field_760 = var16[1] - var16[5] << 8;
                     if (var4 != 5 && var4 != 6) {
                        var10.field_762 = var10.field_760;
                        var10.field_761 = var10.field_760;
                     } else {
                        if (var4 != 6) {
                           var10.field_762 = var16[1] - var16[7] - 18 << 8;
                        } else {
                           var10.field_762 = var16[1] - var16[7] << 8;
                        }

                        var10.field_761 = var16[1] - var16[7] << 8;
                     }

                     var10.field_764 = true;
                  } else {
                     var10.field_764 = false;
                     field_594 = 900;
                  }
               } else {
                  int[] var7 = new int[2];
                  if ((var7 = field_545[var4].method_98(var6, var7, 0, 0)) != null) {
                     var10.field_753 = var10.method_228(var3.field_131, var3.field_132) - var10.field_597 + (var5 ? -var7[0] + 108 : var7[0]);
                     byte var9 = var3.field_132;
                     byte var8 = var3.field_131;
                     var10.field_754 = (var9 + var8) * 27 - var10.field_598 + var7[1];
                     var10.field_763 = new int[8];

                     for (int var14 = 0; var14 < 8; var14++) {
                        if (var14 % 2 == 0) {
                           var10.field_763[var14] = var10.method_228(var3.field_131, var3.field_132) - var10.field_597 + (var5 ? -var7[0] + 108 : var7[0]);
                        } else {
                           var9 = var3.field_132;
                           var8 = var3.field_131;
                           var10.field_763[var14] = (var9 + var8) * 27 - var10.field_598 + var7[1];
                        }
                     }

                     if (var4 == 8) {
                        var10.field_763[0] = var10.field_763[0] - (var5 ? -35 : 35);
                        var10.field_763[2] = var10.field_763[2] + (var5 ? -35 : 35);
                        var10.field_763[5] = var10.field_763[5] - 35;
                        var10.field_763[7] = var10.field_763[7] + 35;
                        var10.field_758 = 3840;
                        var10.field_759 = 7680;
                        var10.field_760 = 8960;
                     } else {
                        var10.field_763[0] = var10.field_763[0] - (var5 ? -24 : 24);
                        var10.field_763[2] = var10.field_763[2] + (var5 ? -24 : 24);
                        var10.field_763[5] = var10.field_763[5] - 24;
                        var10.field_763[7] = var10.field_763[7] + 24;
                        var10.field_758 = 3072;
                        var10.field_759 = 4608;
                        var10.field_760 = 6144;
                     }

                     var10.field_762 = var10.field_760;
                     var10.field_761 = var10.field_760;
                     var10.field_764 = true;
                  } else {
                     var10.field_764 = false;
                     field_594 = 900;
                  }
               }
            }

            if (!this.field_764) {
               return;
            }

            byte var11 = this.field_620[this.field_612].field_139;
            if (this.field_620[this.field_612].field_139 != 11 && var11 != 8) {
               if (!field_580) {
                  this.field_755 += 512;
               }

               this.method_283(var1, 0, 9 + this.field_757);
               return;
            }

            if (!field_580) {
               this.field_755 += 196;
            }

            this.method_283(var1, 1, 14 + (this.field_757 << 2));
            break;
         case 647:
            if (this.field_757 == 0) {
               byte var2 = this.field_620[this.field_612].field_139;
               if (this.field_620[this.field_612].field_139 != 11 && var2 != 8) {
                  this.method_283(var1, 0, 9 + this.field_757);
                  if ((this.field_574 - this.field_615) % 200L > 100L && !field_580) {
                     this.method_283(var1, 0, 13 + this.field_757);
                  }
               } else {
                  this.method_283(var1, 1, 14 + (this.field_757 << 2));
                  if ((this.field_574 - this.field_615) % 200L > 100L) {
                     this.method_283(var1, 1, 30 + (this.field_757 << 2));
                     return;
                  }
               }
            }
      }
   }

   // $VF: renamed from: e (javax.microedition.lcdui.Graphics) void
   private void method_285(Graphics var1) {
      if (field_594 == 131 || field_594 == 137 || field_594 == 139) {
         int var2;
         if (field_633 != 1 && field_633 != 3) {
            var2 = 1;
            if (field_617 >= 180 && field_617 <= 182) {
               var2 = 0;
            }
         } else {
            var2 = 0;
         }

         if (field_594 == 139 || field_633 != 1 && (field_617 == 550 || field_617 == 670)) {
            var2 = 1;
         }

         int var4 = 0;
         int var5 = field_633 == 0 ? 128 : 85;
         int var3 = field_556[1].method_92(21);
         if (field_633 != 1) {
            var2 = var2 != 0 ? field_569 - 6 - var5 : var3 + 26;
         } else {
            var2 = var2 != 0 ? field_569 - 6 - var5 : 26;
         }

         this.method_224(var1, 6, var2, field_568 - 12, var5, 6);
         if (field_633 != 1) {
            field_557.method_5(0, -1);
            int var10001 = field_568 - 6;
            int var7 = var2 + -40;
            int var6 = var10001;
            class_11 var101 = field_557;
            field_557.field_87 = var6;
            var101.field_88 = var7;
            if (field_594 != 137 && !field_580) {
               if (field_594 == 139) {
                  class_11 var102 = field_557;
                  field_557.field_87 = 190;
                  var102.field_88 = 50;
               }

               field_557.method_7();
            }
         }

         if (!field_580 && field_633 != 1 && field_594 != 137) {
            byte var168 = 3;
            method_158(0, 0, 360, 640, 1003);
            if (!field_580) {
               field_510 = true;
            }
         }

         int var103 = this.field_634;
         if (this.field_634 == 2) {
            var103 = this.field_587.field_452.field_139;
         } else if (var103 > 2) {
            var103--;
         }

         if (field_633 == 0) {
            if (var103 < 5) {
               var4 = 85;
               class_21 var10000 = field_549[3];
               int var10003 = field_568 - 6 - 85;
               int var9 = var2 + var5;
               int var8 = var10003;
               var10000.method_101(var1, var103, var8, var9, 0, 0, 0);
            }
         } else if (field_633 == 2) {
            var4 = 47;
            this.method_280(var1, this.field_634, field_568 - 6 - 47 - 1, var2 + var5 - 42 - 4);
         } else if (field_633 == 1) {
            class_21 var151 = field_549[3];
            int var176 = field_568 - 6 - 85;
            int var128 = var2 + var5;
            int var126 = var176;
            var151.method_101(var1, var103, var126, var128, 0, 0, 0);
            short var96 = 255;
            short var95 = 255;
            short var94 = 255;
            var1.setColor(var94, var95, var96);
            if (field_784) {
               var2 += field_556[1].method_92(15) / 4;
            }

            field_536 = field_556[1].method_91(15) + 2;
            int var93;
            String var10002 = method_361(var93 = this.field_587.field_454[this.field_776 >= 0 ? this.field_776 : this.field_689[2 * this.field_595]].field_119);
            int var10004 = 8 + field_536;
            int var10005 = var2 + 2 + var5 / 3 - this.field_579 / 2;
            int var10006 = 8 + field_536;
            int var69 = var2 + this.field_637;
            int var67 = var10006;
            int var66 = var10005;
            int var65 = var10004;
            boolean var64 = false;
            String var119 = var10002;
            int var79 = method_174(field_551[0], var119);
            int var75 = var1.getClipX();
            int var76 = var1.getClipY();
            int var77 = var1.getClipWidth();
            int var78 = var1.getClipHeight();
            if (var79 > 180) {
               this.field_765--;
               if (this.field_765 < -(var79 + 60)) {
                  this.field_765 = 0;
               }

               method_349(var1, var67, var2, 180, var69 - var2);
               var151 = field_551[0];
               int var83 = var65 + this.field_765;
               var151.method_117(var1, var119, var83, var66, 4, true);
               var151 = field_551[0];
               int var88 = var65 + this.field_765 + var79 + 60;
               var151.method_117(var1, var119, var88, var66, 4, true);
            } else {
               var151 = field_551[0];
               int var92 = var65 + 90;
               var151.method_117(var1, var119, var92, var66, 1, true);
            }

            method_349(var1, var75, var76, var77, var78);
            boolean var155 = true;
            var2 += var5 + 6 + 2;
            var5 = field_569 - 26 - var2;
            var4 = 0;
            this.method_224(var1, 6, var2, field_568 - 12, var5, 6);
         } else if (field_633 == 3) {
            byte var149 = 0;
            byte var147 = 0;
            byte var145 = 0;
            var1.setColor(var145, var147, var149);
            method_168(var1, 0, 0, field_568, field_569);
            var2 = 10;
            var5 = field_569 - 20;
            var4 = 0;
            if (field_617 == 0 && field_618 == 1) {
               if (this.field_616 == 0 || this.field_616 == 1) {
                  var2 = 180;
                  var5 = field_569 - 60;
                  var4 = 0;
               } else if (this.field_616 == 1) {
                  var2 = 80;
                  var5 = field_569 - 80;
                  var4 = 0;
               }

               this.method_321(field_788, 520);
            }
         }

         int var98 = var2 + 6;
         this.field_637 = var5 - 12;
         if (field_633 == 1) {
            var98 += field_539;
            this.field_637 = this.field_637 - 2 * field_539;
         }

         this.field_686 = method_175(
            var1, this.field_635, this.field_636, 12, var98 - this.field_685, 12, var98, field_568 - 12 - var4 - 10, var98 + this.field_637, 20
         );
         field_536 = field_556[0].method_91(39) + 2;
         field_537 = field_556[0].method_92(39) + 2;
         if (this.field_685 != 0) {
            int var120 = (int)((long)(var98 - 5 - 1) - this.field_574 % 600L / 200L);
            if (!field_580 && field_633 == 1) {
               class_21 var156 = field_556[0];
               int var169 = field_527 != null && field_527.field_74 == 1 ? 40 : 39;
               var120 -= field_537 >> 1;
               var5 = var169;
               Graphics var107 = field_788;
               var156.method_101(var107, var5, 180, var120, 0, 0, 0);
            }
         }

         if (!field_580 && field_633 == 1) {
            int var122 = (int)((long)(var98 - 5 - 1) - this.field_574 % 600L / 200L);
            method_158(180 - (field_536 >> 1), var122 - field_537, field_536, field_537, 1);
            var122 = (int)((long)(var98 + this.field_637 + 1) + this.field_574 % 600L / 200L);
            method_158(180 - (field_536 >> 1), var122, field_536, field_537, 2);
         }

         if (this.field_685 != Math.max(this.field_686 - this.field_637, 0)) {
            int var124 = (int)((long)(var98 + this.field_637 + 1) + this.field_574 % 600L / 200L);
            if (!field_580 && field_633 == 1) {
               class_21 var157 = field_556[0];
               int var170 = field_527 != null && field_527.field_74 == 2 ? 42 : 41;
               var5 = var124 + (field_537 >> 1);
               var4 = var170;
               Graphics var104 = field_788;
               var157.method_101(var104, var4, 180, var5, 0, 0, 0);
            }
         }

         if (field_594 != 137 && !field_580) {
            field_510 = true;
         }

         if (field_594 == 139) {
            class_21 var165 = field_550[2];
            int var140 = class_0.field_14;
            int var139 = field_570;
            var165.method_101(var1, 0, var139, var140, 0, 0, 0);
            var165 = field_550[2];
            int var72 = class_0.field_14;
            int var71 = field_570;
            var165.method_101(var1, 1, var71, var72, 0, 0, 0);
            var165 = field_550[2];
            int var175 = 2 + this.field_725;
            int var143 = class_0.field_14;
            int var142 = field_570;
            int var141 = var175;
            var165.method_101(var1, var141, var142, var143, 0, 0, 0);
         } else {
            if (field_594 == 137 && !field_580) {
               int var125 = 16 * field_793 / 240;
               int var127;
               var5 = (var127 = 15 * field_793 / 240) << 1;
               var2 = 320 - (var5 << 2);
               var4 = var125 * this.field_638 + 12;
               var3 = 180 - (var4 >> 1);
               this.method_224(var1, var3, var2, var4, var5, 6);
               field_536 = field_556[0].method_91(39) + 2;
               field_537 = field_556[0].method_92(39) + 2;
               class_21 var158 = field_556[0];
               int var171 = field_527 != null && field_527.field_74 == 1 ? 40 : 39;
               int var10 = 320 - var5 * 3 / 2;
               int var133 = var171;
               Graphics var129 = field_788;
               var158.method_101(var129, var133, 180, var10, 0, 0, 0);
               method_158(180 - (field_536 >> 1), 320 - var5 * 3 / 2 - field_537 / 2, field_536, field_537, 1);
               var158 = field_556[0];
               var171 = field_527 != null && field_527.field_74 == 2 ? 42 : 41;
               var10 = 320 + var5 * 3 / 2;
               var133 = var171;
               var129 = field_788;
               var158.method_101(var129, var133, 180, var10, 0, 0, 0);
               method_158(180 - (field_536 >> 1), 320 + var5 * 3 / 2 - field_537 / 2, field_536, field_537, 2);
               field_536 = field_556[0].method_91(43) + 2;
               field_537 = field_556[0].method_92(43) + 2;
               var158 = field_556[0];
               var171 = field_527 != null && field_527.field_74 == 3 ? 44 : 43;
               var133 = 180 - var4;
               int var131 = var171;
               Graphics var115 = field_788;
               var158.method_101(var115, var131, var133, 320, 0, 0, 0);
               method_158(180 - var4 - (field_536 >> 1), 320 - field_537 / 2, field_536, field_537, 3);
               var158 = field_556[0];
               var171 = field_527 != null && field_527.field_74 == 4 ? 46 : 45;
               var133 = var4 + 180;
               int var132 = var171;
               Graphics var116 = field_788;
               var158.method_101(var116, var132, var133, 320, 0, 0, 0);
               method_158(var4 + 180 - (field_536 >> 1), 320 - field_537 / 2, field_536, field_537, 4);
               field_536 = field_556[0].method_91(47) + 2;
               field_537 = field_556[0].method_92(47) + 2;
               var158 = field_556[0];
               var5 = field_527 != null && field_527.field_74 == 14 ? 48 : 47;
               Graphics var110 = field_788;
               var158.method_101(var110, var5, 180, 320, 0, 0, 0);
               var158 = field_551[1];
               short var144 = 295;
               String var118 = method_361(295);
               var158.method_117(var1, var118, 180, 320, 3, true);
               method_158(180 - (field_536 >> 1), 320 - field_537 / 2, field_536, field_537, 14);
               if (!field_580) {
                  field_510 = true;
               }

               int var100 = var2 + var127;
               int var106 = 180 - (var125 * (this.field_638 - 1) >> 1);

               for (int var111 = 0; var111 < this.field_638; var111++) {
                  if (var111 == this.field_595) {
                     field_551[1].method_119(1);
                     byte var150 = 0;
                     short var148 = 255;
                     short var146 = 255;
                     var1.setColor(var146, var148, var150);
                     if ((System.currentTimeMillis() & 64L) != 0L) {
                        method_168(var1, var106 - var125 / 2, var100 + var127 / 2, var125, 2);
                     }
                  } else {
                     field_551[1].method_119(0);
                  }

                  var158 = field_551[1];
                  String var137 = "" + this.field_688.charAt(var111);
                  var158.method_117(var1, var137, var106, var100, 3, true);
                  var106 += var125 + 1;
               }

               field_551[1].method_119(0);
            }
         }
      }
   }

   // $VF: renamed from: a (int, int, java.lang.String, int) void
   final void method_286(int var1, int var2, String var3, int var4) {
      boolean var5 = field_783;
      if (field_783) {
         if (var1 != 2) {
            return;
         }

         field_783 = false;
      }

      if (field_594 != 130) {
         this.field_666 = this.field_574;
      }

      method_156();
      method_157();
      field_594 = 131;
      this.field_765 = 45;
      field_633 = (byte)var1;
      this.field_634 = (byte)var2;
      this.field_635 = var3;
      this.field_636 = (short)var4;
      this.field_685 = 0;
      this.field_637 = 0;
      if (var1 == 2 && !var5) {
         this.method_144(15);
      }
   }

   // $VF: renamed from: b (int, int, java.lang.String, int) void
   final void method_287(int var1, int var2, String var3, int var4) {
      this.method_286(0, var2, var3, 0);
   }

   // $VF: renamed from: a (java.lang.String, short, byte) void
   final void method_288(String var1, short var2, byte var3) {
      byte var4 = this.field_587.field_452.field_139;
      field_594 = 137;
      field_633 = 0;
      this.field_634 = var4;
      this.field_635 = var1;
      this.field_636 = 0;
      this.field_638 = var3;
      this.field_685 = 0;
      this.field_637 = 0;
      this.field_688.setLength(0);
      this.field_688.append("AAAAAAAAAA".substring(0, var3));
      this.field_595 = 0;
      method_157();
      method_156();
   }

   // $VF: renamed from: a (java.lang.String, short) void
   final void method_289(String var1, short var2) {
      byte var3 = this.field_587.field_452.field_139;
      field_594 = 139;
      field_633 = 0;
      this.field_634 = var3;
      this.field_635 = var1;
      this.field_636 = 0;
      this.field_685 = 0;
      this.field_637 = 0;
   }

   // $VF: renamed from: a (int, byte) void
   final void method_290(int var1, int var2) {
      this.method_293((byte)var1, (byte)var2);
      this.field_688.setLength(0);
      if (this.field_587.field_454[var1].field_118 == 4) {
         var2 = (byte)26;
         this.field_688.append(new String(method_361(26)));
      } else {
         var2 = (byte)25;
         this.field_688.append(new String(method_361(25)));
      }

      this.field_688.append(' ');
      var2 = this.field_587.field_454[var1].field_119;
      this.field_688.append(method_361(this.field_587.field_454[var1].field_119));
      this.field_688.append('.');
      this.method_286(2, var1, this.field_688.toString(), 0);
   }

   // $VF: renamed from: g (int) void
   final void method_291(int var1) {
      this.method_290(var1, this.field_591);
   }

   // $VF: renamed from: a (byte) void
   final void method_292(byte var1) {
      this.method_294(var1, this.field_591);
   }

   // $VF: renamed from: b (byte, byte) void
   private void method_293(byte var1, byte var2) {
      class_26 var3;
      if (var2 == 1) {
         var3 = this.field_589;
      } else {
         var3 = this.field_590;
      }

      if (var1 == 6) {
         var3.field_457[5]++;
      }

      if (!var3.field_454[var1].field_117) {
         var3.field_454[var1].field_117 = true;
         var3.field_456++;
      }
   }

   // $VF: renamed from: a (byte, byte) void
   final void method_294(byte var1, byte var2) {
      class_26 var3;
      if (var2 == 1) {
         var3 = this.field_589;
      } else {
         var3 = this.field_590;
      }

      if (var3.field_454[var1].field_117) {
         var3.field_454[var1].field_117 = false;
         var3.field_456--;
         if (var3.field_455 == var1) {
            var3.field_455 = 0;
         }

         if (var1 == 34) {
            this.method_144(24);
         } else {
            this.method_144(17);
         }
      }
   }

   // $VF: renamed from: c (int) int
   private int method_295(int var1) {
      return this.method_296(var1, this.field_591);
   }

   // $VF: renamed from: a (int, byte) int
   private int method_296(int var1, byte var2) {
      int var3 = 0;
      class_26 var4;
      if (var2 == 1) {
         var4 = this.field_589;
      } else {
         var4 = this.field_590;
      }

      for (int var5 = 0; var5 < var4.field_453; var5++) {
         if (var4.field_454[var5].field_117 && this.field_689[var5 * 2 + 1] < this.field_689[var1 * 2 + 1]) {
            var3++;
         }
      }

      return var3;
   }

   // $VF: renamed from: b (int, byte) int
   private int method_297(int var1, byte var2) {
      int var3 = 0;
      class_26 var5;
      if (var2 == 1) {
         var5 = this.field_589;
      } else {
         var5 = this.field_590;
      }

      for (int var4 = 0; var4 < var5.field_453; var4++) {
         if (this.method_296(var4, var2) < var1) {
            var3++;
         }
      }

      return var3;
   }

   // $VF: renamed from: q (int) void
   private void method_298(int var1) {
      if (field_592 == 2) {
         this.field_619 += (long)var1;

         for (int var2 = 0; var2 < 25; var2++) {
            this.field_620[var2].field_148 += (long)var1;
            this.field_620[var2].field_149 += (long)var1;
            if (this.field_620[var2].field_148 > this.field_574) {
               this.field_620[var2].field_148 = this.field_574;
            }

            if (this.field_620[var2].field_149 > this.field_574) {
               this.field_620[var2].field_149 = this.field_574;
            }
         }

         this.method_299(var1);
      }
   }

   // $VF: renamed from: r (int) void
   private void method_299(int var1) {
      for (int var2 = 0; var2 < 10; var2++) {
         this.field_629[var2].field_427 += (long)var1;
      }
   }

   // $VF: renamed from: l () void
   final void method_300() {
      if (field_592 == 2) {
         this.method_136(2);
         this.method_147();
         field_580 = true;
         this.field_665 = this.field_574;
      }
   }

   // $VF: renamed from: T () void
   private void method_301() {
      field_580 = false;
      this.method_298((int)(this.field_574 - this.field_665));
      field_748 = false;
      this.method_148();
   }

   // $VF: renamed from: a (int, int) boolean
   private boolean method_302(int var1, int var2) {
      if ((field_594 & 512) != 0) {
         return false;
      } else {
         for (int var3 = 0; var3 < field_652; var3++) {
            if (var3 == field_648) {
               var3 = field_646;
            }

            class_9 var4;
            if (!(var4 = this.field_641[this.field_653[var3]]).field_79) {
               if (var4.field_81) {
                  if (var4.field_76 == var1 && (var4.field_77 == var2 || var4.field_77 == var2 + 1)) {
                     return true;
                  }
               } else if (var4.field_77 == var2 && (var4.field_76 == var1 || var4.field_76 == var1 + 1)) {
                  return true;
               }
            }
         }

         return false;
      }
   }

   // $VF: renamed from: j () boolean
   private boolean method_303() {
      int var3 = this.field_573 ? 1 : 0;
      this.field_573 = true;
      int var1 = (this.method_163(2821) || this.method_163(18)) ? 1 : 0;
      int var2 = this.method_163(19) ? 1 : 0;
      this.field_573 = var3 != 0;
      if ((
            !(
                  field_784 = field_618 == 1
                     && field_592 == 2
                     && !field_580
                     && !field_783
                     && field_617 != 730
                     && field_617 != 731
                     && field_617 != 732
                     && field_617 != 0
                     && field_617 != 570
                     && (field_617 != 540 || this.field_616 < 32)
                     && field_594 != 137
                     && field_594 != 139
               )
               || !this.method_163(18)
         )
         && (!field_784 || field_528 == null || field_528.field_74 != 1001 || !field_535)) {
         if (!field_783) {
            if (field_580) {
               return false;
            }

            if (this.method_163(18) && this.method_162() || field_528 != null && field_528.field_74 == 1001 && field_535 && this.method_162() && !field_749) {
               method_157();
               method_156();
               this.method_300();
               return false;
            }
         }
      } else {
         field_783 = true;
         if (true) {
            field_572 = 0;
         }

         field_785 = -1;
      }

      int var14 = 0;
      int var4 = 0;
      switch (field_592) {
         case 2:
            if (this.field_587.field_452.field_135 == 3 || this.field_587.field_452.field_135 == 4) {
               if (this.field_587.field_452.field_135 == 4) {
                  if (field_617 == 732) {
                     if (var1 != 0 || field_527 != null && field_527.field_74 == 1003 && field_535) {
                        method_157();
                        method_156();
                        field_594 = 384;
                     }

                     return false;
                  }

                  method_273(true);
                  this.method_267(false, 732, 0);
               }

               return false;
            }

            switch (field_594) {
               case 130:
                  if (var1 != 0 || field_527 != null && field_527.field_74 >= 100 && field_527.field_74 < 300) {
                     if (field_527 != null && this.field_595 != field_527.field_74 - 100) {
                        this.field_595 = field_527.field_74 - 100;
                        var3 = this.method_295(this.field_689[2 * this.field_595]);
                        this.field_685 = Math.min(this.field_685, var3);
                        this.field_685 = Math.max(this.field_685, var3 - this.field_686 + 1);
                        method_156();
                        method_157();
                     } else if (field_527 != null && field_535 && !field_516 && this.field_595 != this.field_587.field_455) {
                        field_516 = true;
                        method_156();
                     } else {
                        if (field_513) {
                           field_516 = false;
                           field_513 = false;
                           if (this.field_587.field_454[this.field_689[2 * this.field_595]].field_118 == 4) {
                              this.method_286(1, 2, method_185(this.field_587.field_454[this.field_689[2 * this.field_595]].field_119 + 2), 0);
                           } else {
                              this.field_587.field_455 = this.field_689[2 * this.field_595];

                              for (int var25 = 0; var25 < 6; var25++) {
                                 if (this.field_587.field_455 == field_543[var25]) {
                                    this.method_198(var25);
                                 }
                              }

                              this.method_210();
                           }

                           this.method_144(16);
                           method_156();
                           method_157();
                        }

                        if (field_527 != null && field_535) {
                           field_514 = true;
                        }
                     }
                  }

                  if (this.method_163(13)) {
                     this.field_707 = Math.max(this.field_707 - 4, 0);
                  } else if (this.method_163(15)) {
                     this.field_707 = Math.min(this.field_707 + 4, Math.max(this.field_708 - 3 * (class_0.field_2[0] + 1), 0));
                  }

                  if (var2 != 0 || this.method_163(19) || field_528 != null && field_528.field_74 == 1002 && field_535) {
                     method_157();
                     method_156();
                     this.method_210();
                     this.method_144(21);
                  }

                  if (this.method_163(2049) || field_527 != null && field_535 && field_527.field_74 == 1) {
                     field_516 = true;
                     method_156();
                     this.field_707 = 0;

                     do {
                        this.field_595--;
                        if (this.field_595 < 0) {
                           this.field_595 = this.field_587.field_453 - 1;
                        }
                     } while (!this.field_587.field_454[this.field_689[2 * this.field_595]].field_117);

                     var3 = this.method_295(this.field_689[2 * this.field_595]);
                     this.field_685 = Math.min(this.field_685, var3);
                     this.field_685 = Math.max(this.field_685, var3 - this.field_686 + 1);
                  }

                  if (this.method_163(3586) || field_527 != null && field_535 && field_527.field_74 == 2) {
                     field_516 = true;
                     method_156();
                     this.field_707 = 0;

                     do {
                        this.field_595++;
                        if (this.field_595 >= this.field_587.field_453) {
                           this.field_595 = 0;
                        }
                     } while (!this.field_587.field_454[this.field_689[2 * this.field_595]].field_117);

                     var3 = this.method_295(this.field_689[2 * this.field_595]);
                     this.field_685 = Math.min(this.field_685, var3);
                     this.field_685 = Math.max(this.field_685, var3 - this.field_686 + 1);
                  }

                  return false;
               case 131:
                  if (!this.method_163(2049) && (field_527 == null || field_527.field_74 != 1)) {
                     if (!this.method_163(3586) && (field_527 == null || field_527.field_74 != 2)) {
                        if ((!this.method_163(18) || field_633 == 3)
                           && !this.method_163(2821)
                           && (field_527 == null || field_527.field_74 != 1003 || !field_535)
                           && (field_528 == null || field_528.field_74 != 1001 || !field_535 || !method_309() || !field_783)) {
                           if (var2 != 0 || field_528 != null && field_535 && field_528.field_74 == 1002) {
                              method_156();
                              method_157();
                              if (field_633 == 1) {
                                 if (this.field_776 >= 0) {
                                    this.field_776 = -1;
                                    this.method_210();
                                 } else {
                                    field_594 = 130;
                                    this.field_685 = this.method_295(this.field_689[2 * this.field_595]);
                                    this.field_686 = 0;
                                 }

                                 this.method_144(21);
                              }

                              return false;
                           }
                        } else {
                           if (field_617 == 10 && field_618 == 1 && this.field_616 == 12) {
                              this.method_144(27);
                           }

                           label962: {
                              if (this.field_685 < Math.max(this.field_686 - this.field_637, 0)) {
                                 this.field_685 = Math.max(this.field_686 - this.field_637, 0);
                                 if (field_783) {
                                    break label962;
                                 }
                              } else {
                                 label960: {
                                    if (field_633 == 1) {
                                       if (this.field_776 < 0) {
                                          field_594 = 130;
                                          this.field_685 = this.method_295(this.field_689[2 * this.field_595]);
                                          this.field_686 = 0;
                                          break label960;
                                       }

                                       this.field_776 = -1;
                                    }

                                    this.method_210();
                                 }
                              }

                              method_157();
                              method_156();
                           }

                           if (field_633 == 2 && this.field_587.field_454[this.field_634].field_118 == 4) {
                              this.field_776 = this.field_634;
                              this.method_286(1, 2, method_185(this.field_587.field_454[this.field_634].field_119 + 2), 0);
                           }

                           if (field_633 == 3) {
                              field_812 = 1000;
                              return false;
                           }
                        }

                        return false;
                     } else {
                        if (field_535) {
                           method_157();
                           method_156();
                        }

                        this.field_685 = Math.min(this.field_685 + 4, Math.max(this.field_686 - this.field_637, 0));
                        return false;
                     }
                  } else {
                     if (field_535) {
                        method_157();
                        method_156();
                     }

                     this.field_685 = Math.max(this.field_685 - 4, 0);
                     return false;
                  }
               case 137:
                  if (!this.method_163(2049) && (field_527 == null || field_527.field_74 != 1 || !field_535)) {
                     if (!this.method_163(3586) && (field_527 == null || field_527.field_74 != 2 || !field_535)) {
                        if (!this.method_163(2563) && (field_527 == null || field_527.field_74 != 3 || !field_535)) {
                           if (!this.method_163(3076) && (field_527 == null || field_527.field_74 != 4 || !field_535)) {
                              if (var1 != 0 || field_527 != null && field_527.field_74 == 14 && field_535) {
                                 method_157();
                                 method_156();
                                 field_594 = 384;
                              }
                           } else {
                              method_157();
                              method_156();
                              this.field_595++;
                              if (this.field_595 >= this.field_638) {
                                 this.field_595 = 0;
                                 return false;
                              }
                           }

                           return false;
                        } else {
                           method_157();
                           method_156();
                           this.field_595--;
                           if (this.field_595 < 0) {
                              this.field_595 = this.field_638 - 1;
                              return false;
                           }

                           return false;
                        }
                     } else {
                        method_157();
                        method_156();
                        if (this.field_688.charAt(this.field_595) == 'Z') {
                           this.field_688.setCharAt(this.field_595, '0');
                           return false;
                        } else {
                           if (this.field_688.charAt(this.field_595) == '9') {
                              this.field_688.setCharAt(this.field_595, 'A');
                           } else {
                              this.field_688.setCharAt(this.field_595, (char)(this.field_688.charAt(this.field_595) + 1));
                           }

                           return false;
                        }
                     }
                  } else {
                     method_157();
                     method_156();
                     if (this.field_688.charAt(this.field_595) == 'A') {
                        this.field_688.setCharAt(this.field_595, '9');
                        return false;
                     } else {
                        if (this.field_688.charAt(this.field_595) == '0') {
                           this.field_688.setCharAt(this.field_595, 'Z');
                        } else {
                           this.field_688.setCharAt(this.field_595, (char)(this.field_688.charAt(this.field_595) - 1));
                        }

                        return false;
                     }
                  }
               case 138:
                  if ((var1 != 0 || field_527 != null && field_527.field_74 > 100 && field_527.field_74 < 300) && field_527 != null) {
                     if (field_527.field_74 < 200) {
                        if (field_527.field_74 - 100 != this.field_695 || this.field_694 == 1) {
                           this.field_694 = 0;
                           this.field_695 = field_527.field_74 - 100;
                           var3 = this.method_296(this.field_689[2 * this.field_695], (byte)1);
                           this.field_697 = Math.min(this.field_697, var3);
                           this.field_697 = Math.max(this.field_697, var3 - this.field_699 + 1);
                           field_516 = false;
                           return false;
                        }

                        if (field_535 && !field_516) {
                           field_516 = true;
                           method_156();
                        } else if (field_535 && field_516) {
                           if (!this.method_304()) {
                              method_157();
                              method_156();
                              field_516 = true;
                              return false;
                           }

                           method_157();
                           method_156();
                           field_516 = true;
                        }
                     } else {
                        if (field_527.field_74 - 200 != this.field_696 || this.field_694 == 0) {
                           this.field_694 = 1;
                           this.field_696 = field_527.field_74 - 200;
                           var3 = this.method_296(this.field_689[2 * this.field_696], (byte)2);
                           this.field_698 = Math.min(this.field_698, var3);
                           this.field_698 = Math.max(this.field_698, var3 - this.field_700 + 1);
                           field_516 = false;
                           return false;
                        }

                        if (field_535 && !field_516) {
                           field_516 = true;
                           method_156();
                        } else if (field_535 && field_516) {
                           if (!this.method_304()) {
                              method_157();
                              method_156();
                              field_516 = true;
                              return false;
                           }

                           method_157();
                           method_156();
                           field_516 = true;
                           var3 = this.method_296(this.field_689[2 * this.field_696], (byte)2);
                           this.field_698 = Math.min(this.field_698, var3);
                           this.field_698 = Math.max(this.field_698, var3 - this.field_700 + 1);
                        }
                     }
                  }

                  if (this.method_163(13)) {
                     this.field_707 = Math.max(this.field_707 - 4, 0);
                  } else if (this.method_163(15)) {
                     this.field_707 = Math.min(this.field_707 + 4, Math.max(this.field_708 - 3 * (class_0.field_2[0] + 1), 0));
                  }

                  if (var2 != 0 || this.method_163(19) || field_528 != null && field_528.field_74 == 1002 && field_535) {
                     method_157();
                     method_156();
                     this.field_589.field_455 = 0;
                     this.field_590.field_455 = 0;
                     if (this.field_589.field_454[19].field_117 && this.field_589.field_454[20].field_117
                        || this.field_590.field_454[19].field_117 && this.field_590.field_454[20].field_117) {
                        this.method_267(false, 370, 0);
                     }

                     this.method_210();
                     this.method_144(21);
                  }

                  if (this.method_163(2563)) {
                     this.field_694 = 0;
                     this.field_695 = 1;
                     this.field_697 = 1;
                  }

                  if (this.method_163(3076)) {
                     this.field_694 = 1;
                     this.field_696 = 1;
                     this.field_698 = 1;
                  }

                  if (this.method_163(2049) || field_527 != null && field_535 && (field_527.field_74 == 1 || field_527.field_74 == 3)) {
                     this.field_707 = 0;
                     if (this.field_694 == 0 && field_527.field_74 == 1) {
                        while (true) {
                           this.field_695--;
                           if (this.field_695 < 1) {
                              this.field_695 = this.field_589.field_453 - 1;
                           }

                           if (this.field_589.field_454[this.field_689[2 * this.field_695]].field_117) {
                              var3 = this.method_296(this.field_689[2 * this.field_695], (byte)1);
                              this.field_697 = Math.min(this.field_697, var3);
                              this.field_697 = Math.max(this.field_697, var3 - this.field_699 + 1);
                              break;
                           }
                        }
                     } else if (this.field_694 == 1 && field_527.field_74 == 3) {
                        do {
                           this.field_696--;
                           if (this.field_696 < 1) {
                              this.field_696 = this.field_590.field_453 - 1;
                           }
                        } while (!this.field_590.field_454[this.field_689[2 * this.field_696]].field_117);

                        var3 = this.method_296(this.field_689[2 * this.field_696], (byte)2);
                        this.field_698 = Math.min(this.field_698, var3);
                        this.field_698 = Math.max(this.field_698, var3 - this.field_700 + 1);
                     }

                     method_157();
                     method_156();
                     field_516 = true;
                  }

                  if (this.method_163(3586) || field_527 != null && field_535 && (field_527.field_74 == 2 || field_527.field_74 == 4)) {
                     this.field_707 = 0;
                     if (this.field_694 == 0 && field_527 != null && field_527.field_74 == 2) {
                        while (true) {
                           this.field_695++;
                           if (this.field_695 >= this.field_589.field_453) {
                              this.field_695 = 1;
                           }

                           if (this.field_589.field_454[this.field_689[2 * this.field_695]].field_117) {
                              var3 = this.method_296(this.field_689[2 * this.field_695], (byte)1);
                              this.field_697 = Math.min(this.field_697, var3);
                              this.field_697 = Math.max(this.field_697, var3 - this.field_699 + 1);
                              break;
                           }
                        }
                     } else if (this.field_694 == 1 && field_527 != null && field_527.field_74 == 4) {
                        do {
                           this.field_696++;
                           if (this.field_696 >= this.field_590.field_453) {
                              this.field_696 = 1;
                           }
                        } while (!this.field_590.field_454[this.field_689[2 * this.field_696]].field_117);

                        var3 = this.method_296(this.field_689[2 * this.field_696], (byte)2);
                        this.field_698 = Math.min(this.field_698, var3);
                        this.field_698 = Math.max(this.field_698, var3 - this.field_700 + 1);
                     }

                     method_157();
                     method_156();
                     field_516 = true;
                  }

                  return false;
               case 139:
                  if (this.field_534 != -1) {
                     if (System.currentTimeMillis() - field_520 > 300L) {
                        if (field_521) {
                           this.field_725++;
                        } else {
                           this.field_725--;
                        }

                        if (this.field_725 > 11) {
                           this.field_725 = 0;
                        }

                        if (this.field_725 < 0) {
                           this.field_725 = 11;
                        }

                        this.field_534--;
                        field_520 = System.currentTimeMillis();
                     }

                     if (this.field_534 == -1) {
                        if (field_521) {
                           this.field_725--;
                        } else {
                           this.field_725++;
                        }

                        if (this.field_725 > 11) {
                           this.field_725 = 0;
                        }

                        if (this.field_725 < 0) {
                           this.field_725 = 11;
                        }

                        field_594 = 384;
                        return false;
                     }
                  }

                  return false;
               case 384:
                  if (this.field_607 != 3 && !method_309() && (field_562 = field_562 + (long)field_804) > 40000L) {
                     if (!method_149()) {
                        this.method_145(2);
                     }

                     field_562 = 0L;
                  }

                  if (field_618 == 0 || field_618 == 1) {
                     return false;
                  }

                  this.method_161();
                  if (field_476) {
                     if (this.method_163(2563)) {
                        if (this.method_209()) {
                           method_279(this.field_587.field_452, 4);
                           this.method_242(this.field_587.field_452, 1);
                        } else {
                           this.field_587.field_452.field_148 = this.field_574;
                        }
                     } else if (this.method_163(3076)) {
                        if (this.method_209()) {
                           method_279(this.field_587.field_452, 0);
                           this.method_242(this.field_587.field_452, 1);
                        } else {
                           this.field_587.field_452.field_148 = this.field_574;
                        }
                     } else if (this.method_163(2049)) {
                        if (this.method_209()) {
                           method_279(this.field_587.field_452, 2);
                           this.method_242(this.field_587.field_452, 1);
                        } else {
                           this.field_587.field_452.field_148 = this.field_574;
                        }
                     } else if (this.method_163(3586)) {
                        if (this.method_209()) {
                           method_279(this.field_587.field_452, 6);
                           this.method_242(this.field_587.field_452, 1);
                        } else {
                           this.field_587.field_452.field_148 = this.field_574;
                        }
                     }
                  } else if (this.method_163(2563)) {
                     if (this.method_209()) {
                        method_279(this.field_587.field_452, 5);
                        this.method_242(this.field_587.field_452, 0);
                        this.field_587.field_459 = false;
                        this.field_587.field_460 = false;
                        this.field_587.field_461 = false;
                     } else {
                        this.field_587.field_459 = true;
                     }
                  } else if (this.method_163(3076)) {
                     if (this.method_209()) {
                        method_279(this.field_587.field_452, 1);
                        this.method_242(this.field_587.field_452, 0);
                        this.field_587.field_459 = false;
                        this.field_587.field_460 = false;
                        this.field_587.field_461 = false;
                     } else {
                        this.field_587.field_460 = true;
                     }
                  } else if (this.method_163(2049)) {
                     if (this.method_209()) {
                        method_279(this.field_587.field_452, 3);
                        this.method_242(this.field_587.field_452, 0);
                        this.field_587.field_459 = false;
                        this.field_587.field_460 = false;
                        this.field_587.field_461 = false;
                     } else {
                        this.field_587.field_460 = true;
                     }
                  } else if (this.method_163(3586)) {
                     if (this.method_209()) {
                        method_279(this.field_587.field_452, -1);
                        this.method_242(this.field_587.field_452, 0);
                        this.field_587.field_459 = false;
                        this.field_587.field_460 = false;
                        this.field_587.field_461 = false;
                     } else {
                        this.field_587.field_461 = true;
                     }
                  }

                  if (this.method_163(2821) || field_522 && field_535) {
                     if (!field_522) {
                        if (this.method_209()) {
                           if (!this.method_277(this.field_587.field_452.field_138)
                              && this.field_587.field_455 != 6
                              && (this.field_587.field_452.field_138 == 1 || !this.method_277(1))
                              && (this.field_587.field_452.field_138 == 3 || !this.method_277(3))
                              && (this.field_587.field_452.field_138 == 5 || !this.method_277(5))
                              && this.field_587.field_452.field_138 != 7) {
                              this.method_277(7);
                           }

                           this.method_242(this.field_587.field_452, 0);
                           method_327();
                           return false;
                        }
                     } else {
                        var1 = this.field_587.field_452.field_131;
                        var2 = this.field_587.field_452.field_132;

                        for (byte var5 = 1; var5 <= 7; var5 += 2) {
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

                           if (this.method_259(var16, var29, var5) != -1) {
                              class_9 var17;
                              byte var30 = (var17 = this.field_641[this.method_259(var16, var29, var5)]).field_75;
                              int var6 = var30 + 9;
                              int var7 = var17.field_84 - this.field_597;
                              int var8 = var17.field_85 - this.field_598;
                              int var9 = field_552.method_91(var6 - 9);
                              int var31 = field_552.method_92(var6 - 9);
                              if (!var17.field_81) {
                                 var7 += this.field_690[var30][2] * 3 / 2;
                                 var8 += this.field_690[var30][3] * 3 / 2;
                              } else {
                                 var7 = var7 + 108 - this.field_690[var30][2] * 3 / 2 - this.field_690[var30][0] + 1;
                                 var8 += this.field_690[var30][3] * 3 / 2;
                              }

                              switch (var17.field_75) {
                                 case 40:
                                    var8 -= 45;
                                    break;
                                 case 60:
                                    var8 -= 75;
                              }

                              if (var9 < 30) {
                                 var9 = 40;
                                 var7 -= 20;
                              }

                              if (var31 < 30) {
                                 var31 = 40;
                                 var8 -= this.field_690[var30][3] * 3 / 2;
                              }

                              if (method_227(field_529, field_530, var7, var8, var9, var31)) {
                                 if (this.method_209()) {
                                    if (!this.method_277(var5)
                                       && this.field_587.field_455 != 6
                                       && (var5 == 1 || !this.method_277(1))
                                       && (var5 == 3 || !this.method_277(3))
                                       && (var5 == 5 || !this.method_277(5))
                                       && var5 != 7) {
                                       this.method_277(7);
                                    }

                                    this.method_242(this.field_587.field_452, 0);
                                    method_327();
                                 }

                                 method_157();
                                 method_156();
                                 return false;
                              }
                           } else {
                              field_522 = false;
                           }
                        }

                        return false;
                     }
                  } else if (this.method_163(19) && field_781 && field_772 == 4 || field_527 != null && field_527.field_74 == 15 && field_535 && field_781) {
                     method_157();
                     method_156();
                     this.method_144(8);
                     field_594 = 130;
                     this.field_595 = this.field_689[2 * this.field_587.field_455 + 1];
                     this.field_685 = this.method_295(this.field_587.field_455);
                     this.field_686 = 0;
                     this.field_666 = this.field_574;
                     return false;
                  }

                  return false;
               case 646:
                  if (this.method_163(2821)) {
                     switch (this.field_587.field_458) {
                        case 0:
                        case 1:
                        case 2:
                        case 3:
                           if (this.field_757 == 0) {
                              this.field_615 = this.field_574;
                           }

                           field_594 = 647;
                     }
                  }

                  if (this.field_755 > this.field_761) {
                     if (this.field_757 == 0) {
                        this.field_615 = this.field_574;
                     }

                     field_594 = 647;
                  }

                  return false;
               case 647:
                  if (this.field_574 - this.field_615 > 600L) {
                     switch (this.field_587.field_458) {
                        case 0:
                           this.method_242(this.field_587.field_452, 7);
                           field_594 = 904;
                           return false;
                        default:
                           var3 = this.field_756;
                           if (this.field_756 == 2) {
                              this.field_739++;
                              this.field_737++;
                              if (this.field_587.field_458 == 1) {
                                 this.method_260(this.field_620[this.field_612], -10);
                                 if (this.field_620[this.field_612].field_139 == 5 && this.field_620[this.field_612].field_141 > 0) {
                                    this.method_242(this.field_620[this.field_612], 14);
                                 }
                              } else if (this.field_587.field_458 == 2) {
                                 this.method_260(this.field_620[this.field_612], -30);
                                 if (this.field_620[this.field_612].field_139 == 5 && this.field_620[this.field_612].field_141 > 0) {
                                    this.method_242(this.field_620[this.field_612], 14);
                                 }
                              } else if (this.field_587.field_458 == 3) {
                                 this.method_260(this.field_620[this.field_612], -20);
                                 if (this.field_620[this.field_612].field_139 == 5 && this.field_620[this.field_612].field_141 > 0) {
                                    this.method_242(this.field_620[this.field_612], 14);
                                 }
                              }

                              this.method_282();
                           } else if (var3 == 0) {
                              this.field_738++;
                              this.method_206(1, this.field_613, this.field_614, 54, 27);
                           } else {
                              this.field_737++;
                              if (this.field_587.field_458 == 1) {
                                 this.method_260(this.field_620[this.field_612], -3);
                              } else if (this.field_587.field_458 == 2) {
                                 this.method_260(this.field_620[this.field_612], -9);
                              } else if (this.field_587.field_458 == 3) {
                                 this.method_260(this.field_620[this.field_612], -6);
                              }

                              this.method_260(this.field_620[this.field_612], -1);
                              this.method_282();
                           }

                           if (var3 != 0 && this.field_620[this.field_612].field_141 > 0 && method_243(this.field_620[this.field_612].field_139)) {
                              this.method_144(28 + (this.method_165() & 1));
                           }

                           if (this.field_587.field_452.field_139 == 0) {
                              if (this.field_587.field_458 == 3) {
                                 this.method_206(
                                    13 + this.field_587.field_452.field_138, this.field_587.field_452.field_131, this.field_587.field_452.field_132, 0, 0
                                 );
                              } else {
                                 this.method_206(
                                    5 + this.field_587.field_452.field_138, this.field_587.field_452.field_131, this.field_587.field_452.field_132, 0, 0
                                 );
                              }
                           } else if (this.field_587.field_458 == 3) {
                              this.method_206(
                                 29 + this.field_587.field_452.field_138, this.field_587.field_452.field_131, this.field_587.field_452.field_132, 0, 0
                              );
                           } else {
                              this.method_206(
                                 21 + this.field_587.field_452.field_138, this.field_587.field_452.field_131, this.field_587.field_452.field_132, 0, 0
                              );
                           }

                           this.field_693 = 100;
                           this.method_299((int)(this.field_574 - this.field_667));
                           if (this.field_620[this.field_612].field_141 > 0) {
                              this.method_319();
                           }

                           this.method_242(this.field_587.field_452, 5);
                           this.field_587.field_457[this.field_587.field_458]--;
                           field_594 = 900;
                           this.field_756 = 0;
                     }
                  }

                  return false;
               case 900:
                  if (field_618 == 0 || field_618 == 1) {
                     return false;
                  }

                  this.method_161();
                  if (field_476) {
                     if (this.method_163(2563)) {
                        if (this.method_209()) {
                           method_279(this.field_587.field_452, 4);
                           this.method_242(this.field_587.field_452, 1);
                        } else {
                           this.field_587.field_452.field_148 = this.field_574;
                        }
                     } else if (this.method_163(3076)) {
                        if (this.method_209()) {
                           method_279(this.field_587.field_452, 0);
                           this.method_242(this.field_587.field_452, 1);
                        } else {
                           this.field_587.field_452.field_148 = this.field_574;
                        }
                     } else if (this.method_163(2049)) {
                        if (this.method_209()) {
                           method_279(this.field_587.field_452, 2);
                           this.method_242(this.field_587.field_452, 1);
                        } else {
                           this.field_587.field_452.field_148 = this.field_574;
                        }
                     } else if (this.method_163(3586)) {
                        if (this.method_209()) {
                           method_279(this.field_587.field_452, 6);
                           this.method_242(this.field_587.field_452, 1);
                        } else {
                           this.field_587.field_452.field_148 = this.field_574;
                        }
                     }
                  } else if (this.method_163(2563)) {
                     if (this.method_209()) {
                        method_279(this.field_587.field_452, 5);
                        this.method_242(this.field_587.field_452, 0);
                     } else {
                        this.field_587.field_459 = true;
                     }
                  } else if (this.method_163(3076)) {
                     if (this.method_209()) {
                        method_279(this.field_587.field_452, 1);
                        this.method_242(this.field_587.field_452, 0);
                     } else {
                        this.field_587.field_460 = true;
                     }
                  } else if (this.method_163(2049)) {
                     if (this.method_209()) {
                        method_279(this.field_587.field_452, 3);
                        this.method_242(this.field_587.field_452, 0);
                        this.field_587.field_459 = false;
                        this.field_587.field_460 = false;
                        this.field_587.field_461 = false;
                     } else {
                        this.field_587.field_460 = true;
                     }
                  } else if (this.method_163(3586)) {
                     if (this.method_209()) {
                        method_279(this.field_587.field_452, -1);
                        this.method_242(this.field_587.field_452, 0);
                     } else {
                        this.field_587.field_461 = true;
                     }
                  }

                  if (var1 != 0 && this.field_587.field_452.field_143 == -1 && this.field_587.field_452.field_144 == -1) {
                     if (this.field_587.field_455 == 6) {
                        this.method_276();
                        return false;
                     }

                     if (this.field_607 == 3
                        && this.field_591 == 1
                        && this.field_587.field_452.field_138 == 5
                        && this.field_587.field_452.field_131 == 2
                        && this.field_587.field_452.field_132 == 11) {
                        if (this.field_641[0].field_79) {
                           this.method_263(0);
                           this.method_262(24);
                        } else if (this.field_641[24].field_79
                           && this.field_587.field_457[this.field_587.field_458] < 100
                           && this.field_587.field_458 != 0
                           && this.field_587.field_452.field_141 > 0) {
                           field_782 = true;
                           this.method_267(true, 770, 0);
                        }

                        return false;
                     }

                     if (field_477 && this.field_587.field_458 != 0) {
                        if (this.field_587.field_457[this.field_587.field_458] <= 0) {
                           return false;
                        }

                        if ((var1 = this.method_256(this.field_587.field_452)) != -1
                           && this.field_673[this.field_620[var1].field_131][this.field_620[var1].field_132] != this.field_609) {
                           var1 = -1;
                        }

                        if (var1 != -1 && this.field_587.field_458 != 4) {
                           this.method_249(this.field_587.field_452, this.field_620[var1].field_131, this.field_620[var1].field_132);
                           this.field_613 = this.field_620[var1].field_131;
                           this.field_614 = this.field_620[var1].field_132;
                           this.field_615 = this.field_574;
                           if (this.field_587.field_458 == 1 || this.field_587.field_458 == 2) {
                              this.method_242(this.field_587.field_452, 5);
                           } else if (this.field_587.field_458 == 3 || this.field_587.field_458 == 4) {
                              this.method_242(this.field_587.field_452, 6);
                           }

                           this.field_736++;
                           this.field_740++;
                           this.field_612 = var1;
                           field_594 = 646;
                           this.method_281();
                           this.field_667 = this.field_574;
                           this.field_615 = 0L;
                           this.field_685 = 0;
                           this.field_686 = 65536;
                        } else {
                           this.field_736++;
                           this.field_740++;
                           this.method_319();
                           if (this.field_587.field_458 != 4) {
                              if (this.field_587.field_452.field_139 == 0) {
                                 if (this.field_587.field_458 == 3) {
                                    this.method_206(
                                       13 + this.field_587.field_452.field_138, this.field_587.field_452.field_131, this.field_587.field_452.field_132, 0, 0
                                    );
                                 } else {
                                    this.method_206(
                                       5 + this.field_587.field_452.field_138, this.field_587.field_452.field_131, this.field_587.field_452.field_132, 0, 0
                                    );
                                 }
                              } else if (this.field_587.field_458 == 3) {
                                 this.method_206(
                                    29 + this.field_587.field_452.field_138, this.field_587.field_452.field_131, this.field_587.field_452.field_132, 0, 0
                                 );
                              } else {
                                 this.method_206(
                                    21 + this.field_587.field_452.field_138, this.field_587.field_452.field_131, this.field_587.field_452.field_132, 0, 0
                                 );
                              }

                              this.field_693 = 100;
                              this.field_738++;
                              this.method_242(this.field_587.field_452, 5);
                              this.field_587.field_457[this.field_587.field_458]--;
                              field_594 = 900;
                           } else {
                              this.field_613 = method_257(this.field_587.field_452.field_131, this.field_587.field_452.field_138, 2);
                              this.field_614 = method_258(this.field_587.field_452.field_132, this.field_587.field_452.field_138, 2);
                              this.field_736++;
                              this.field_740++;
                              this.method_208(
                                 4,
                                 this.field_587.field_452.field_131,
                                 this.field_587.field_452.field_132,
                                 this.field_613,
                                 this.field_614,
                                 this.field_587.field_452.field_138
                              );
                              this.field_587.field_457[this.field_587.field_458]--;
                              this.field_693 = 100;
                              this.method_242(this.field_587.field_452, 6);
                              field_594 = 900;
                           }
                        }

                        return false;
                     }

                     switch (this.field_587.field_458) {
                        case 0:
                           this.field_613 = this.field_587.field_452.field_131;
                           this.field_614 = this.field_587.field_452.field_132;
                           if (this.field_587.field_452.field_138 == 1) {
                              this.field_613++;
                           } else if (this.field_587.field_452.field_138 == 7) {
                              this.field_614++;
                           } else if (this.field_587.field_452.field_138 == 5) {
                              this.field_613--;
                           } else if (this.field_587.field_452.field_138 == 3) {
                              this.field_614--;
                           }

                           this.field_612 = this.method_253(this.field_613, this.field_614);
                           if (this.field_612 > 0) {
                              field_594 = 646;
                              this.method_281();
                              this.field_667 = this.field_574;
                              this.field_615 = 0L;
                              this.field_685 = 0;
                              this.field_686 = 65536;
                           } else {
                              this.method_242(this.field_587.field_452, 7);
                           }
                           break;
                        default:
                           if (this.field_587.field_457[this.field_587.field_458] > 0) {
                              this.field_613 = this.field_587.field_452.field_131;
                              this.field_614 = this.field_587.field_452.field_132;
                              if (this.field_587.field_452.field_138 == 5
                                 && this.field_613 - 1 >= 0
                                 && this.field_673[this.field_613 - 1][this.field_614] == this.field_609) {
                                 this.field_613--;
                              }

                              if (this.field_587.field_452.field_138 == 1
                                 && this.field_613 + 1 < this.field_668
                                 && this.field_673[this.field_613 + 1][this.field_614] == this.field_609) {
                                 this.field_613++;
                              }

                              if (this.field_587.field_452.field_138 == 3
                                 && this.field_614 - 1 >= 0
                                 && this.field_673[this.field_613][this.field_614 - 1] == this.field_609) {
                                 this.field_614--;
                              }

                              if (this.field_587.field_452.field_138 == 7
                                 && this.field_614 + 1 < this.field_669
                                 && this.field_673[this.field_613][this.field_614 + 1] == this.field_609) {
                                 this.field_614++;
                              }

                              if (this.field_587.field_452.field_138 == 4
                                 && this.field_613 - 1 >= 0
                                 && this.field_614 - 1 >= 0
                                 && this.field_673[this.field_613 - 1][this.field_614 - 1] == this.field_609) {
                                 this.field_613--;
                                 this.field_614--;
                              }

                              if (this.field_587.field_452.field_138 == 0
                                 && this.field_613 + 1 < this.field_668
                                 && this.field_614 + 1 < this.field_669
                                 && this.field_673[this.field_613 + 1][this.field_614 + 1] == this.field_609) {
                                 this.field_613++;
                                 this.field_614++;
                              }

                              if (this.field_587.field_452.field_138 == 2
                                 && this.field_613 + 1 < this.field_668
                                 && this.field_614 - 1 >= 0
                                 && this.field_673[this.field_613 + 1][this.field_614 - 1] == this.field_609) {
                                 this.field_613++;
                                 this.field_614--;
                              }

                              if (this.field_587.field_452.field_138 == 6
                                 && this.field_613 - 1 >= 0
                                 && this.field_614 + 1 < this.field_669
                                 && this.field_673[this.field_613 - 1][this.field_614 + 1] == this.field_609) {
                                 this.field_613--;
                                 this.field_614++;
                              }

                              this.method_281();
                              field_594 = 901;
                              this.field_615 = this.field_574;
                           }
                     }

                     method_157();
                     method_156();
                  } else if (this.method_163(19) || field_527 != null && field_527.field_74 == 15 && field_535) {
                     method_156();
                     method_157();
                     field_594 = 130;
                     this.field_595 = this.field_689[2 * this.field_587.field_455 + 1];
                     this.field_685 = this.method_295(this.field_587.field_455);
                     this.field_686 = 0;
                     this.field_666 = this.field_574;
                     return false;
                  }

                  return false;
               case 901:
                  switch (this.field_587.field_458) {
                     case 1:
                     case 2:
                     case 3:
                        if (this.method_163(2563)) {
                           if (this.field_613 - 1 >= 0 && this.field_673[this.field_613 - 1][this.field_614] == this.field_609) {
                              this.field_613--;
                           }
                        } else if (this.method_163(3076)) {
                           if (this.field_613 + 1 < this.field_668 && this.field_673[this.field_613 + 1][this.field_614] == this.field_609) {
                              this.field_613++;
                           }
                        } else if (this.method_163(2049)) {
                           if (this.field_614 - 1 >= 0 && this.field_673[this.field_613][this.field_614 - 1] == this.field_609) {
                              this.field_614--;
                           }
                        } else if (this.method_163(3586)) {
                           if (this.field_614 + 1 < this.field_669 && this.field_673[this.field_613][this.field_614 + 1] == this.field_609) {
                              this.field_614++;
                           }
                        } else if (this.method_163(2821)) {
                           this.field_736++;
                           this.field_741++;
                           this.field_612 = this.method_253(this.field_613, this.field_614);
                           if (this.field_612 > 0) {
                              field_594 = 646;
                              this.method_281();
                              this.field_667 = this.field_574;
                              this.field_615 = 0L;
                              this.field_685 = 0;
                              this.field_686 = 65536;
                           } else {
                              if (this.field_587.field_452.field_139 == 0) {
                                 if (this.field_587.field_458 == 3) {
                                    this.method_206(
                                       13 + this.field_587.field_452.field_138, this.field_587.field_452.field_131, this.field_587.field_452.field_132, 0, 0
                                    );
                                 } else {
                                    this.method_206(
                                       5 + this.field_587.field_452.field_138, this.field_587.field_452.field_131, this.field_587.field_452.field_132, 0, 0
                                    );
                                 }
                              } else if (this.field_587.field_458 == 3) {
                                 this.method_206(
                                    29 + this.field_587.field_452.field_138, this.field_587.field_452.field_131, this.field_587.field_452.field_132, 0, 0
                                 );
                              } else {
                                 this.method_206(
                                    21 + this.field_587.field_452.field_138, this.field_587.field_452.field_131, this.field_587.field_452.field_132, 0, 0
                                 );
                              }

                              this.field_693 = 100;
                              this.field_738++;
                              this.method_242(this.field_587.field_452, 5);
                              this.field_587.field_457[this.field_587.field_458]--;
                              field_594 = 900;
                              this.method_319();
                           }
                        }

                        var14 = this.field_613 - this.field_587.field_452.field_131;
                        var4 = this.field_614 - this.field_587.field_452.field_132;
                        field_572 = 0;
                        break;
                     case 4:
                        if (this.method_163(2563)) {
                           if (this.field_613 - 1 >= 0 && this.field_673[this.field_613 - 1][this.field_614] == this.field_609) {
                              this.field_613--;
                           }
                        } else if (this.method_163(3076)) {
                           if (this.field_613 + 1 < this.field_668 && this.field_673[this.field_613 + 1][this.field_614] == this.field_609) {
                              this.field_613++;
                           }
                        } else if (this.method_163(2049)) {
                           if (this.field_614 - 1 >= 0 && this.field_673[this.field_613][this.field_614 - 1] == this.field_609) {
                              this.field_614--;
                           }
                        } else if (this.method_163(3586)) {
                           if (this.field_614 + 1 < this.field_669 && this.field_673[this.field_613][this.field_614 + 1] == this.field_609) {
                              this.field_614++;
                           }
                        } else if (this.method_163(2821)) {
                           this.field_736++;
                           this.field_741++;
                           this.method_208(
                              4,
                              this.field_587.field_452.field_131,
                              this.field_587.field_452.field_132,
                              this.field_613,
                              this.field_614,
                              this.field_587.field_452.field_138
                           );
                           this.field_587.field_457[this.field_587.field_458]--;
                           this.field_693 = 100;
                           this.method_242(this.field_587.field_452, 6);
                           field_594 = 900;
                        }

                        var14 = this.field_613 - this.field_587.field_452.field_131;
                        var4 = this.field_614 - this.field_587.field_452.field_132;
                  }

                  if (var14 == 0 && var4 == 0) {
                     method_279(this.field_587.field_452, 0);
                     return false;
                  } else if (method_170(var4) << 1 <= method_170(var14)) {
                     if (var14 <= 0) {
                        method_279(this.field_587.field_452, 5);
                     } else {
                        method_279(this.field_587.field_452, 1);
                     }

                     return false;
                  } else if (method_170(var4) <= method_170(var14) << 1) {
                     if (var14 <= 0 && var4 <= 0) {
                        method_279(this.field_587.field_452, 4);
                        return false;
                     } else if (var14 <= 0) {
                        method_279(this.field_587.field_452, 6);
                        return false;
                     } else {
                        if (var4 <= 0) {
                           method_279(this.field_587.field_452, 2);
                        } else {
                           method_279(this.field_587.field_452, 0);
                        }

                        return false;
                     }
                  } else {
                     if (var4 <= 0) {
                        method_279(this.field_587.field_452, 3);
                     } else {
                        method_279(this.field_587.field_452, 7);
                     }

                     return false;
                  }
               case 904:
               default:
                  return false;
            }
         case 3:
            try {
               this.field_615 = this.field_615 + (long)field_804;
               if (this.field_615 > -1L) {
                  this.method_215(1, 129);
                  this.method_140(2, -1, 3);
                  field_544[1] = null;
                  return true;
               }
            } catch (Exception var10) {
               System.out.println("sometime occur null pointer exception !!!");
            }
      }

      return false;
   }

   // $VF: renamed from: k () boolean
   private boolean method_304() {
      if (this.field_694 == 0) {
         if (this.field_689[2 * this.field_695] < 6) {
            if (this.field_689[2 * this.field_695 + 1] > 1
               && this.field_689[2 * this.field_695 + 1] < 6
               && this.field_590.field_454[this.field_689[2 * this.field_695]].field_117
               && this.field_589.field_457[this.field_689[2 * this.field_695 + 1] - 1] > 0) {
               this.field_589.field_457[this.field_689[2 * this.field_695 + 1] - 1]--;
               this.field_590.field_457[this.field_689[2 * this.field_695 + 1] - 1]++;
               this.method_144(8);
            }

            return false;
         }

         if (this.field_689[2 * this.field_695] == 6) {
            if (this.field_589.field_457[this.field_689[2 * this.field_695 + 1] - 1] < 1) {
               return false;
            }

            this.field_589.field_457[this.field_689[2 * this.field_695 + 1] - 1]--;
            this.field_590.field_457[this.field_689[2 * this.field_695 + 1] - 1]++;
            if (!this.field_590.field_454[this.field_689[2 * this.field_695]].field_117) {
               this.field_590.field_454[this.field_689[2 * this.field_695]].field_117 = true;
               this.field_590.field_456++;
            }

            if (this.field_589.field_457[this.field_689[2 * this.field_695 + 1] - 1] < 1) {
               this.field_589.field_457[this.field_689[2 * this.field_695 + 1] - 1] = 0;
               this.field_589.field_454[this.field_689[2 * this.field_695]].field_117 = false;
               this.field_589.field_456--;

               do {
                  this.field_695--;
                  if (this.field_695 < 1) {
                     this.field_695 = this.field_589.field_453 - 1;
                  }
               } while (!this.field_589.field_454[this.field_689[2 * this.field_695]].field_117);

               int var2 = this.method_296(this.field_689[2 * this.field_695], (byte)1);
               this.field_697 = Math.min(this.field_697, var2);
               this.field_697 = Math.max(this.field_697, var2 - this.field_699 + 1);
            }

            this.method_144(8);
            return false;
         }

         this.field_590.field_454[this.field_689[2 * this.field_695]].field_117 = true;
         this.field_590.field_456++;
         this.field_589.field_454[this.field_689[2 * this.field_695]].field_117 = false;
         this.field_589.field_456--;

         do {
            this.field_695--;
            if (this.field_695 < 1) {
               this.field_695 = this.field_589.field_453 - 1;
            }
         } while (!this.field_589.field_454[this.field_689[2 * this.field_695]].field_117);

         int var1 = this.method_296(this.field_689[2 * this.field_695], (byte)1);
         this.field_697 = Math.min(this.field_697, var1);
         this.field_697 = Math.max(this.field_697, var1 - this.field_699 + 1);
         this.method_144(8);
      } else {
         if (this.field_689[2 * this.field_696] < 6) {
            if (this.field_689[2 * this.field_696 + 1] > 1
               && this.field_689[2 * this.field_696 + 1] < 6
               && this.field_589.field_454[this.field_689[2 * this.field_696]].field_117
               && this.field_590.field_457[this.field_689[2 * this.field_696 + 1] - 1] > 0) {
               this.field_590.field_457[this.field_689[2 * this.field_696 + 1] - 1]--;
               this.field_589.field_457[this.field_689[2 * this.field_696 + 1] - 1]++;
               this.method_144(8);
            }

            return false;
         }

         if (this.field_689[2 * this.field_696] == 6) {
            if (this.field_590.field_457[this.field_689[2 * this.field_696 + 1] - 1] < 1) {
               return false;
            }

            this.field_590.field_457[this.field_689[2 * this.field_696 + 1] - 1]--;
            this.field_589.field_457[this.field_689[2 * this.field_696 + 1] - 1]++;
            if (!this.field_589.field_454[this.field_689[2 * this.field_696]].field_117) {
               this.field_589.field_454[this.field_689[2 * this.field_696]].field_117 = true;
               this.field_589.field_456++;
            }

            if (this.field_590.field_457[this.field_689[2 * this.field_696 + 1] - 1] < 1) {
               this.field_590.field_457[this.field_689[2 * this.field_696 + 1] - 1] = 0;
               this.field_590.field_454[this.field_689[2 * this.field_696]].field_117 = false;
               this.field_590.field_456--;

               do {
                  this.field_696--;
                  if (this.field_696 < 1) {
                     this.field_696 = this.field_590.field_453 - 1;
                  }
               } while (!this.field_590.field_454[this.field_689[2 * this.field_696]].field_117);

               int var4 = this.method_296(this.field_689[2 * this.field_695], (byte)2);
               this.field_698 = Math.min(this.field_698, var4);
               this.field_698 = Math.max(this.field_698, var4 - this.field_699 + 1);
            }

            this.method_144(8);
            return false;
         }

         this.field_589.field_454[this.field_689[2 * this.field_696]].field_117 = true;
         this.field_589.field_456++;
         this.field_590.field_454[this.field_689[2 * this.field_696]].field_117 = false;
         this.field_590.field_456--;

         do {
            this.field_696--;
            if (this.field_696 < 1) {
               this.field_696 = this.field_590.field_453 - 1;
            }
         } while (!this.field_590.field_454[this.field_689[2 * this.field_696]].field_117);

         int var3 = this.method_296(this.field_689[2 * this.field_696], (byte)2);
         this.field_698 = Math.min(this.field_698, var3);
         this.field_698 = Math.max(this.field_698, var3 - this.field_700 + 1);
         this.method_144(8);
      }

      return true;
   }

   // $VF: renamed from: f (javax.microedition.lcdui.Graphics) void
   private void method_305(Graphics var1) {
      var1.setColor(3816503);
      method_168(var1, 0, 0, field_568, field_569);
      field_537 = field_556[0].method_92(39) + 2;
      int var3 = 365 + field_537 + 4;
      int var2 = field_569 - (var3 + 44);
      int var4 = field_569 - var2;
      int var5 = 32;
      method_173(var1, method_361(32), 8, 7, 20);
      var1.setColor(0);
      method_168(var1, 7, 41, field_568 - 30, var3 + field_537);
      if (this.field_686 == 0) {
         this.field_686 = var3 / 60;
         this.field_686 = (var3 - field_537) / 60;
         this.field_685 = Math.max(0, Math.min(this.field_685, this.field_587.field_456 - this.field_686));
      }

      field_536 = field_556[0].method_91(39) + 2;
      field_537 = field_556[0].method_92(39) + 2;
      class_21 var10000 = field_556[0];
      int var10002 = field_527 != null && field_527.field_74 == 1 ? 40 : 39;
      int var7 = 44 + (field_537 >> 1);
      int var6 = var10002;
      Graphics var22 = field_788;
      var10000.method_101(var22, var6, 180, var7, 0, 0, 0);
      if (!field_580) {
         method_158(180 - (field_536 >> 1), 44, field_536, field_537, 1);
      }

      int var8 = 44 + field_537 + 2;
      var6 = this.field_685;

      for (int var30 = this.method_297(var6, this.field_591); var30 < this.field_587.field_453; var30++) {
         byte var33 = this.field_689[var30 * 2];
         if (var8 + 60 > var3 + 44) {
            break;
         }

         if (this.field_587.field_454[var33].field_117) {
            var2 = var8 + 2;
            if (var30 == this.field_595 && var33 == this.field_587.field_455) {
               var5 = (byte)5;
            } else if (var30 == this.field_595) {
               var5 = (byte)3;
            } else if (var33 == this.field_587.field_455) {
               var5 = (byte)4;
            } else {
               var5 = (byte)2;
            }

            this.method_225(var1, 11, var2, field_568 - 26 - 11, 52, var5);
            if (!field_580) {
               method_158(11, var2, field_568 - 26 - 11, 52, var30 + 100);
            }

            this.method_280(var1, (byte)var33, 18, var2 + 5);
            var5 = this.field_587.field_454[var33].field_119;
            method_175(var1, method_361(this.field_587.field_454[var33].field_119), 0, 80, var2 + 27, 80, var2, field_568 - 22 - 7, var2 + 52, 21);
            var8 = var2 + 58;
         }
      }

      var10000 = field_556[0];
      var10002 = field_527 != null && field_527.field_74 == 2 ? 42 : 41;
      var7 = var8 + (field_537 >> 1);
      var6 = var10002;
      Graphics var25 = field_788;
      var10000.method_101(var25, var6, 180, var7, 0, 0, 0);
      if (!field_580) {
         method_158(180 - (field_536 >> 1), var8, field_536, field_537, 2);
      }

      if (!field_580) {
         field_510 = true;
      }

      boolean var26 = true;
      var3 = var8 - 44 - 4;
      var2 = 44 + field_537 + 2;
      if ((var3 = var3 - (field_537 + 2)) < 30 || field_569 < 128) {
         var3 = 30;
         var26 = false;
      }

      if (this.field_587.field_456 > 1) {
         this.method_169(var1, 3558425);
         method_167(var1, field_568 - 18, var2, 15, var3);
         this.method_169(var1, 3158573);
         method_168(var1, field_568 - 17, var2 + 1, 13, var3 - 2);
         this.method_169(var1, 4151325);
         method_168(var1, field_568 - 19, var2 + 1, 1, var3 - 2);
         method_168(var1, field_568 - 3, var2 + 1, 1, var3 - 2);
         if (var26) {
            this.method_169(var1, 8484209);
            var2 = var2 + 2 + this.method_295(this.field_689[2 * this.field_595]) * (var3 - 4 - 16) / (this.field_587.field_456 - 1);
            method_167(var1, field_568 - 16, var2, 11, 16);
            this.method_169(var1, 4211516);
            method_168(var1, field_568 - 15, var2 + 1, 9, 14);
         }
      }

      int var19;
      var2 = var19 = var4 + field_537;
      this.method_169(var1, 0);
      method_168(var1, 7, var2, field_568 - 28, field_569 - var2 - 5);
      short var32 = 255;
      int var20 = 255;
      int var17 = 255;
      var1.setColor(var17, var20, var32);
      this.field_688.setLength(0);
      this.field_688.append(method_361(var5 = this.field_587.field_454[this.field_689[2 * this.field_595]].field_119 + 1));
      this.field_708 = method_175(
         var1, this.field_688.toString(), 0, 9, var19 + 2 - this.field_707, 9, var19 + 2, field_568 - 22 - 9, var19 + 2 + 7 * (class_0.field_2[0] + 1), 20
      );
      if (this.field_707 != 0) {
         var10000 = field_549[0];
         var5 = var19 - 5;
         var20 = field_570;
         var10000.method_101(var1, 2, var20, var5, 0, 0, 0);
      }

      if (this.field_707 != Math.max(this.field_708 - 7 * (class_0.field_2[0] + 1), 0)) {
         var10000 = field_549[0];
         var17 = field_569 - 5;
         var2 = field_570;
         var10000.method_101(var1, 3, var2, var17, 0, 0, 0);
      }
   }

   // $VF: renamed from: g (javax.microedition.lcdui.Graphics) void
   private void method_306(Graphics var1) {
      this.method_169(var1, 3816503);
      method_168(var1, 0, 0, field_568, field_569);
      short var7 = 255;
      short var6 = 255;
      int var4 = 255;
      var1.setColor(var4, var6, var7);
      int var3 = 33;
      method_173(var1, method_361(33), field_570, 7, 36);
      field_549[3].method_101(var1, 0, 2, 74, 0, 0, 0);
      class_21 var10000 = field_549[3];
      var4 = field_568 - 84;
      var10000.method_101(var1, 1, var4, 74, 0, 0, 0);
      int var2 = this.field_579 + 4 << 3;
      int var5 = field_569 - var2;
      int var44 = 0;
      int var34 = 0;
      int var30 = 0;
      var1.setColor(var30, var34, var44);
      method_168(var1, 2, 42, field_568 - 4, field_569 - var2 - 4 - 42);
      method_168(var1, 2, var5, field_568 - 4, field_569 - var5 - 1);
      var30 = var5 - 46 - 4;
      this.field_699 = var30 / 60;
      if (this.field_699 > 6) {
         this.field_699 = 6;
      }

      this.field_697 = Math.max(0, Math.min(this.field_697, this.field_589.field_456 - this.field_699));
      field_536 = field_556[0].method_91(39) + 2;
      field_537 = field_556[0].method_92(39) + 2;
      if (this.field_694 == 0) {
         var10000 = field_556[0];
         int var10002 = field_527 != null && field_527.field_74 == 1 ? 40 : 39;
         var44 = 46 + (field_537 >> 1);
         var34 = var10002;
         Graphics var17 = field_788;
         var10000.method_101(var17, var34, 90, var44, 0, 0, 0);
      }

      method_158(90 - (field_536 >> 1), 46, field_537, field_537, 1);
      int var8 = 1;
      int var9 = 46 + field_537 + 2;

      for (int var36 = this.method_297(this.field_697, (byte)1); var36 < this.field_589.field_453; var36++) {
         byte var46 = this.field_689[var36 * 2];
         if (var9 + 60 > var30 + 46) {
            break;
         }

         if (this.field_589.field_454[var46].field_117 && this.field_689[var36 * 2 + 1] >= 1) {
            if (var8 > 6) {
               break;
            }

            var2 = var9 + 2;
            if (var36 == this.field_695 && this.field_694 == 0) {
               var3 = (byte)3;
            } else {
               var3 = (byte)2;
            }

            this.method_225(var1, 7, var2, field_570 - 30, 52, var3);
            method_158(7, var2, field_570 - 30, 52, var36 + 100);
            this.method_280(var1, (byte)var46, 14, var2 + 5);
            if (this.field_689[var46 * 2 + 1] > 1 && this.field_689[var46 * 2 + 1] < 7) {
               String var19 = String.valueOf(this.field_589.field_457[this.field_689[var46 * 2 + 1] - 1]);
               method_173(var1, var19, 56 + (field_570 - 44 - 42) / 2, var2 + 5 + 21 - this.field_579 / 2, 36);
            }

            if (this.field_689[var46 * 2 + 1] == 36) {
               method_173(var1, "'1'", 56 + (field_570 - 44 - 42) / 2, var2 + 5 + 21 - this.field_579 / 2, 36);
            } else if (this.field_689[var46 * 2 + 1] == 37) {
               method_173(var1, "'2'", 56 + (field_570 - 44 - 42) / 2, var2 + 5 + 21 - this.field_579 / 2, 36);
            }

            var9 = var2 + 58;
            var8++;
         }
      }

      if (this.field_694 == 0) {
         var10000 = field_556[0];
         int var58 = field_527 != null && field_527.field_74 == 2 ? 42 : 41;
         var8 = var9 + (field_537 >> 1);
         var44 = var58;
         Graphics var37 = field_788;
         var10000.method_101(var37, var44, 90, var8, 0, 0, 0);
      }

      method_158(90 - (field_536 >> 1), var9, field_536, field_537, 2);
      boolean var38 = true;
      var3 = var9 - 46 - 4;
      var2 = 46 + field_537 + 2;
      if ((var3 = var3 - (field_537 + 2)) < 30 || field_569 < 128) {
         var38 = false;
         var3 = 30;
      }

      if (this.field_589.field_456 > 1) {
         this.method_169(var1, 3558425);
         method_167(var1, field_570 - 18, var2, 15, var3);
         this.method_169(var1, 3158573);
         method_168(var1, field_570 - 17, var2 + 1, 13, var3 - 2);
         this.method_169(var1, 4151325);
         method_168(var1, field_570 - 19, var2 + 1, 1, var3 - 2);
         method_168(var1, field_570 - 3, var2 + 1, 1, var3 - 2);
         if (var38) {
            this.method_169(var1, 8484209);
            var2 = var2 + 2 + (this.method_296(this.field_689[2 * this.field_695], (byte)1) - 1) * (var3 - 4 - 16) / (this.field_589.field_456 - 2);
            method_167(var1, field_570 - 16, var2, 11, 16);
            this.method_169(var1, 4211516);
            method_168(var1, field_570 - 15, var2 + 1, 9, 14);
         }
      }

      this.field_700 = var30 / 60;
      if (this.field_700 > 6) {
         this.field_700 = 6;
      }

      this.field_698 = Math.max(0, Math.min(this.field_698, this.field_590.field_456 - this.field_700));
      if (this.field_694 == 1) {
         var10000 = field_556[0];
         int var59 = field_527 != null && field_527.field_74 == 3 ? 40 : 39;
         var44 = 46 + (field_537 >> 1);
         var34 = var59;
         Graphics var22 = field_788;
         var10000.method_101(var22, var34, 270, var44, 0, 0, 0);
      }

      method_158(270 - (field_537 >> 1), 46, field_537, field_537, 3);
      int var53 = 1;
      int var13 = 46 + field_537 + 2;

      for (int var40 = this.method_297(this.field_698, (byte)2); var40 < this.field_590.field_453; var40++) {
         byte var49 = this.field_689[var40 * 2];
         if (var53 > 6 || var13 + 60 > var30 + 46) {
            break;
         }

         if (this.field_590.field_454[var49].field_117 && this.field_689[var40 * 2 + 1] >= 1) {
            var53++;
            var2 = var13 + 2;
            byte var23;
            if (var40 == this.field_696 && this.field_694 == 1) {
               var23 = 3;
            } else {
               var23 = 2;
            }

            this.method_225(var1, field_570 + 5, var2, field_570 - 37, 52, var23);
            method_158(field_570 + 5, var2, field_570 - 37, 52, var40 + 200);
            this.method_280(var1, (byte)var49, field_570 + 12, var2 + 5);
            if (this.field_689[var49 * 2 + 1] > 1 && this.field_689[var49 * 2 + 1] < 7) {
               String var24 = String.valueOf(this.field_590.field_457[this.field_689[var49 * 2 + 1] - 1]);
               method_173(var1, var24, field_570 + 12 + 42 + (field_570 - 44 - 42) / 2, var2 + 5 + 21 - this.field_579 / 2, 36);
            }

            if (this.field_689[var49 * 2 + 1] == 36) {
               method_173(var1, "'1'", field_570 + 12 + 7 + 42 + (field_570 - 44 - 42) / 2, var2 + 5 + 21 - this.field_579 / 2, 36);
            } else if (this.field_689[var49 * 2 + 1] == 37) {
               method_173(var1, "'2'", field_570 + 12 + 7 + 42 + (field_570 - 44 - 42) / 2, var2 + 5 + 21 - this.field_579 / 2, 36);
            }

            var13 = var2 + 58;
         }
      }

      if (this.field_694 == 1) {
         var10000 = field_556[0];
         int var60 = field_527 != null && field_527.field_74 == 4 ? 42 : 41;
         var44 = var13 + (field_537 >> 1);
         var34 = var60;
         Graphics var32 = field_788;
         var10000.method_101(var32, var34, 270, var44, 0, 0, 0);
      }

      method_158(270 - (field_537 >> 1), var13, field_537, field_537, 4);
      boolean var42 = true;
      if ((var3 = var13 - 46 - 4) < 30 || field_569 < 128) {
         var42 = false;
         var3 = 30;
      }

      var2 = 46 + field_537 + 2;
      int var26 = var3 - (field_537 + 2);
      if (this.field_590.field_456 > 1) {
         this.method_169(var1, 3558425);
         method_167(var1, field_568 - 20, var2, 15, var26);
         this.method_169(var1, 3158573);
         method_168(var1, field_568 - 19, var2 + 1, 13, var26 - 2);
         this.method_169(var1, 4151325);
         method_168(var1, field_568 - 21, var2 + 1, 1, var26 - 2);
         method_168(var1, field_568 - 5, var2 + 1, 1, var26 - 2);
         if (var42) {
            this.method_169(var1, 8484209);
            var2 = var2 + 2 + (this.method_296(this.field_689[2 * this.field_696], (byte)2) - 1) * (var26 - 4 - 16) / (this.field_590.field_456 - 2);
            method_167(var1, field_568 - 18, var2, 11, 16);
            this.method_169(var1, 4211516);
            method_168(var1, field_568 - 17, var2 + 1, 9, 14);
         }
      }

      short var51 = 255;
      short var43 = 255;
      short var33 = 255;
      var1.setColor(var33, var43, var51);
      this.field_688.setLength(0);
      if (this.field_694 == 0) {
         this.field_688.append(method_361(var3 = this.field_589.field_454[this.field_689[2 * this.field_695]].field_119 + 1));
      } else {
         this.field_688.append(method_361(var3 = this.field_590.field_454[this.field_689[2 * this.field_696]].field_119 + 1));
      }

      this.field_708 = method_175(
         var1, this.field_688.toString(), 0, 9, var5 + 2 - this.field_707, 9, var5 + 2, field_568 - 22 - 9, var5 + 2 + 8 * (class_0.field_2[0] + 1), 20
      );
      field_510 = true;
   }

   // $VF: renamed from: U () void
   private void method_307() {
      if (field_580) {
         this.field_692 = 0;
      } else if (this.field_693 > 0) {
         this.field_693 = this.field_693 - this.field_575;
         if (this.field_693 % 100 > 50) {
            this.field_692 = 3;
         } else {
            this.field_692 = -3;
         }
      } else {
         this.field_692 = 0;
      }
   }

   // $VF: renamed from: h (javax.microedition.lcdui.Graphics) void
   private void method_308(Graphics var1) {
      if (field_783) {
         if (this.field_616 == 24 && this.field_607 == 0) {
            field_783 = false;
         }

         if ((field_618 == 1 || field_617 == 181 || field_617 == 182 || field_617 == 171 || field_617 == 172)
            && (field_618 != 1 || field_617 != 540 || this.field_616 != 31)) {
            this.method_307();
            return;
         }

         field_528 = null;
         field_535 = false;
         field_783 = false;

         for (int var2 = 0; var2 < 25; var2++) {
            this.field_620[var2].field_148 = 0L;
            this.field_620[var2].field_149 = 0L;
         }

         if (field_785 >= 0) {
            this.method_145(field_785);
         }
      }

      if (this.field_766 > 0) {
         this.field_766--;
      } else if (field_617 == 731 && field_618 == 1) {
         this.method_238(var1);
      } else {
         this.method_233(this.field_627, false);
         this.method_307();
         int var4 = this.field_597 - this.method_228(this.field_603, this.field_606);
         int var20 = this.field_604;
         int var19 = this.field_603;
         int var5 = this.field_598 - (var20 + var19) * 27 - this.field_692;
         int var6 = class_11.field_107[0][5];
         int var7 = class_11.field_107[0][6];
         class_11.method_19(0, var4, var5);
         class_11.method_16(var1, 0, 0, 0);
         if (var4 < 0) {
            var1.setColor(0);
            var1.fillRect(0, 0, -var4, field_569);
         }

         if (var6 - var4 < field_568) {
            var1.setColor(0);
            var1.fillRect(var6 - var4, 0, field_568 - var6 + var4, field_569);
         }

         if (var5 < 0) {
            var1.setColor(0);
            var1.fillRect(0, 0, field_568, -var5);
         }

         if (var7 - var5 < field_569) {
            var1.setColor(0);
            var1.fillRect(0, var7 - var5, field_568, field_569 - var7 + var5);
         }

         int var12 = 0 + this.field_692;
         byte var11 = 0;
         int var10 = field_569;
         int var9 = field_568;
         var6 = this.field_598;
         int var8 = this.field_597;
         Graphics var46 = var1;
         class_27 var78 = this;
         if (var9 != 0 && var10 != 0) {
            for (int var14 = 0; var14 < field_652; var14++) {
               if (var14 == field_648) {
                  var14 = field_646;
               }

               class_9 var18;
               if (!(var18 = var78.field_641[var78.field_653[var14]]).field_79
                  && (
                     var78.field_609 == var78.field_673[var18.field_76][var18.field_77]
                        || (
                           var18.field_81
                              ? var78.field_609 == var78.field_673[var18.field_76][var18.field_77 - 1]
                              : var78.field_609 == var78.field_673[var18.field_76 - 1][var18.field_77]
                        )
                  )) {
                  for (int var15 = 0; var15 < var78.field_690[var18.field_75][5]; var15++) {
                     byte var13;
                     int var16;
                     int var17;
                     if (var78.field_609 == var78.field_673[var18.field_76][var18.field_77]) {
                        if (!var18.field_81) {
                           if (var18.field_76 == 0) {
                              continue;
                           }

                           var13 = var78.field_670[var18.field_76 - 1][var18.field_77 + var15];
                           var16 = var78.method_228(var18.field_76 - 1, var18.field_77 + var15) - var8;
                           int var10000 = var18.field_76 - 1;
                           var20 = var18.field_77 + var15;
                           var19 = var10000;
                           var17 = (var20 + var19) * 27 - var6;
                        } else {
                           if (var18.field_77 == 0) {
                              continue;
                           }

                           var13 = var78.field_670[var18.field_76 + var15][var18.field_77 - 1];
                           var16 = var78.method_228(var18.field_76 + var15, var18.field_77 - 1) - var8;
                           int var172 = var18.field_76 + var15;
                           var20 = var18.field_77 - 1;
                           var19 = var172;
                           var17 = (var20 + var19) * 27 - var6;
                        }
                     } else if (!var18.field_81) {
                        if (var18.field_76 == 0 || var78.field_609 != var78.field_673[var18.field_76 - 1][var18.field_77]) {
                           continue;
                        }

                        var13 = var78.field_670[var18.field_76][var18.field_77 + var15];
                        var16 = var78.method_228(var18.field_76, var18.field_77 + var15) - var8;
                        var20 = var18.field_77 + var15;
                        byte var144 = var18.field_76;
                        var17 = (var20 + var144) * 27 - var6;
                     } else {
                        if (var18.field_77 == 0 || var78.field_609 != var78.field_673[var18.field_76][var18.field_77 - 1]) {
                           continue;
                        }

                        var13 = var78.field_670[var18.field_76 + var15][var18.field_77];
                        var16 = var78.method_228(var18.field_76 + var15, var18.field_77) - var8;
                        int var173 = var18.field_76 + var15;
                        byte var158 = var18.field_77;
                        var19 = var173;
                        var17 = (var158 + var19) * 27 - var6;
                     }

                     if (var13 != 127) {
                        var78.method_172(var46, var13 + 89, var16 + var11, var17 + var12, 108, 54, 0, 0, 0);
                     }
                  }
               }
            }

            for (int var112 = var78.field_603; var112 <= var78.field_605; var112++) {
               for (int var117 = var78.field_604; var117 <= var78.field_606; var117++) {
                  if (var78.field_673[var112][var117] == var78.field_609) {
                     int var121 = var78.method_228(var112, var117) - var8;
                     int var130 = (var117 + var112) * 27 - var6;
                     byte var105;
                     if ((var105 = var78.field_670[var112][var117]) != 127
                        && var105 != field_770
                        && method_226(var8, var6, var9, var10, var121 + var8 + var11, var130 + var6 + var12, 108, 54)) {
                        if (var78.field_607 == 1 && var105 == 10) {
                           class_21 var174 = field_550[1];
                           int var10002 = 0 + var78.field_729;
                           int var10003 = var121 + var11;
                           int var21 = var130 + var12;
                           var20 = var10003;
                           int var136 = var10002;
                           var174.method_101(var46, var136, var20, var21, 0, 0, 0);
                        } else {
                           var78.method_172(var46, var105 + 89, var121 + var11, var130 + var12, 108, 54, 0, 0, 0);
                        }
                     }

                     if (((var78.field_671[var112][var117] & 255) != 255 || (var78.field_672[var112][var117] & 255) != 255)
                        && method_226(var8, var6, var9, var10, var121 + var8 + var11, var130 + var6 + var12 - 120 + 2, 108, 147)) {
                        boolean var3 = false;
                        if (var78.field_620 != null) {
                           for (int var106 = 0; var106 < 25; var106++) {
                              class_15 var168;
                              if ((var168 = var78.field_620[var106]).field_130) {
                                 byte var22 = var168.field_131;
                                 byte var146 = var168.field_132;
                                 if (var22 < var78.field_668 && var146 < var78.field_669 && var78.field_609 == var78.field_673[var22][var146]) {
                                    if (method_203(var168)) {
                                       int var137 = var168.field_131;
                                       int var160 = var168.field_131;
                                       int var147 = var168.field_132;
                                       int var23 = var168.field_132;
                                       if (var168.field_133 >= field_541[var168.field_139][var168.field_135][2]) {
                                          if (var168.field_138 == 3) {
                                             var23 = var168.field_132 + 1;
                                          } else if (var168.field_138 == 5) {
                                             var160 = var168.field_131 + 1;
                                          } else if (var168.field_138 == 1) {
                                             var160 = var168.field_131 - 1;
                                          } else if (var168.field_138 == 7) {
                                             var23 = var168.field_132 - 1;
                                          }
                                       } else if (var168.field_138 == 3) {
                                          var147 = var168.field_132 - 1;
                                       } else if (var168.field_138 == 5) {
                                          var137 = var168.field_131 - 1;
                                       } else if (var168.field_138 == 1) {
                                          var137 = var168.field_131 + 1;
                                       } else if (var168.field_138 == 7) {
                                          var147 = var168.field_132 + 1;
                                       }

                                       if (var160 < var78.field_668
                                          && var23 < var78.field_669
                                          && var78.field_609 == var78.field_673[var160][var23]
                                          && var137 < var78.field_668
                                          && var147 < var78.field_669
                                          && var78.field_609 == var78.field_673[var137][var147]
                                          && !var78.field_691) {
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
                           var78.method_234(var46, var78.field_671[var112][var117], true, true, var121 + var11, var130 + var12);
                        }

                        if (!var3) {
                           var78.method_234(var46, var78.field_672[var112][var117], false, true, var121 + var11, var130 + var12);
                        }
                     }
                  }
               }
            }

            if (field_518 && field_515) {
               int var107 = -1;
               int var24 = -1;
               int var122 = field_529 + var78.field_597;
               int var131 = field_530 + var78.field_598;
               int var113 = var78.method_231(var122, var131);
               int var138 = var78.method_230(var122, var131);
               if (var113 < var78.field_668
                  && var138 < var78.field_669
                  && var113 >= 0
                  && var138 >= 0
                  && (var78.field_682[var113][var138] & 240) == 0
                  && (var78.field_673[var113][var138] == var78.field_609 || var78.method_302(var113, var138))) {
                  var107 = var113;
                  var24 = var138;
               }

               if (var107 >= 0 && var24 >= 0 && (var78.field_673[var107][var24] == var78.field_609 || var78.method_302(var107, var24))) {
                  var122 = var78.method_228(var107, var24) - var8;
                  var131 = (var24 + var107) * 27 - var6;
                  byte var31 = 106;
                  int var25 = 232;
                  byte var161 = 37;
                  var46.setColor(var161, var25, var31);
                  field_557.method_5(2, -1);
                  int var10001 = var122 + var11 + 54;
                  var107 = var131 + var12 + 27;
                  var25 = var10001;
                  class_11 var124 = field_557;
                  field_557.field_87 = var25;
                  var124.field_88 = var107;
                  field_557.method_8(field_804);
                  field_557.method_7();
               }
            }

            for (int var114 = 0; var114 < field_649; var114++) {
               class_9 var139;
               if ((var139 = var78.field_641[var78.field_653[var114]]).field_79) {
                  int var125 = var139.field_84 - var8;
                  int var133 = var139.field_85 - var6;
                  if (var139.field_81
                     ? method_226(
                        var8,
                        var6,
                        var9,
                        var10,
                        var139.field_84 - var78.field_690[var139.field_75][0] - var78.field_690[var139.field_75][2] + 108 + var11,
                        var139.field_85 + var78.field_690[var139.field_75][3] + var12,
                        var78.field_690[var139.field_75][0],
                        var78.field_690[var139.field_75][1]
                     )
                     : method_226(
                        var8,
                        var6,
                        var9,
                        var10,
                        var139.field_84 + var78.field_690[var139.field_75][2] + var11,
                        var139.field_85 + var78.field_690[var139.field_75][3] + var12,
                        var78.field_690[var139.field_75][0],
                        var78.field_690[var139.field_75][1]
                     )) {
                     var78.method_236(var46, var78.field_653[var114], var125 + var11, var133 + var12);
                  }
               }
            }
         }

         if (field_554 && field_553 != null) {
            class_15 var29 = this.field_587.field_452;
            int[] var95 = new int[2];
            boolean var71b = this.method_205(var29, 2, 1);
            int var71;
            boolean var98 = this.method_205(var29, 0, 1);
            int var100 = this.method_228(var29.field_131, var29.field_132) - this.field_597;
            byte var162 = var29.field_132;
            byte var148 = var29.field_131;
            int var102 = (var162 + var148) * 27 - this.field_598;
            if (field_541[var29.field_139][var29.field_135][2] != 0) {
               if (var71b) {
                  var100 += var29.field_137 * 54 >> 16;
                  if (var29.field_133 >= field_541[var29.field_139][var29.field_135][2]) {
                     var100 -= 54;
                  }
               } else {
                  var100 -= var29.field_137 * 54 >> 16;
                  if (var29.field_133 >= field_541[var29.field_139][var29.field_135][2]) {
                     var100 += 54;
                  }
               }

               if (var98) {
                  var102 += var29.field_137 * 27 >> 16;
                  if (var29.field_133 >= field_541[var29.field_139][var29.field_135][2]) {
                     var102 -= 27;
                  }
               } else {
                  var102 -= var29.field_137 * 27 >> 16;
                  if (var29.field_133 >= field_541[var29.field_139][var29.field_135][2]) {
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
            class_11 var79 = field_553;
            field_553.field_87 = var5;
            var79.field_88 = var71;
            field_553.method_8(field_804);
            if (!field_580) {
               field_553.method_7();
            }

            if ((25 - var29.field_131 < 0 ? -(25 - var29.field_131) : 25 - var29.field_131) > 2
               || (40 - var29.field_132 < 0 ? -(40 - var29.field_132) : 40 - var29.field_132) > 2) {
               field_554 = false;
            }
         }

         Graphics var30 = var1;
         class_27 var27 = this;
         this.field_632 = 0;

         for (int var32 = field_644; var32 < field_650; var32++) {
            class_9 var49;
            if ((var49 = var27.field_641[var27.field_653[var32]]).field_79
               && (
                  var49.field_81
                     ? method_226(
                        var27.field_597,
                        var27.field_598,
                        field_568,
                        field_569,
                        var49.field_84 - var27.field_690[var49.field_75][0] - var27.field_690[var49.field_75][2] + 108,
                        var49.field_85 + var27.field_690[var49.field_75][3] + var27.field_692,
                        var27.field_690[var49.field_75][0],
                        var27.field_690[var49.field_75][1]
                     )
                     : method_226(
                        var27.field_597,
                        var27.field_598,
                        field_568,
                        field_569,
                        var49.field_84 + var27.field_690[var49.field_75][2],
                        var49.field_85 + var27.field_690[var49.field_75][3] + var27.field_692,
                        var27.field_690[var49.field_75][0],
                        var27.field_690[var49.field_75][1]
                     )
               )) {
               var7 = var49.field_84 - var27.field_597;
               var5 = var49.field_85 - var27.field_598;
               var27.method_236(var30, var27.field_653[var32], var7, var5 + var27.field_692);
            }
         }

         for (int var33 = field_645; var33 < field_651; var33++) {
            class_9 var51;
            if ((var51 = var27.field_641[var27.field_653[var33]]).field_79
               && (
                  var51.field_81
                     ? method_226(
                        var27.field_597,
                        var27.field_598,
                        field_568,
                        field_569,
                        var51.field_84 - var27.field_690[var51.field_75][0] - var27.field_690[var51.field_75][2] + 108,
                        var51.field_85 + var27.field_690[var51.field_75][3] + var27.field_692,
                        var27.field_690[var51.field_75][0],
                        var27.field_690[var51.field_75][1]
                     )
                     : method_226(
                        var27.field_597,
                        var27.field_598,
                        field_568,
                        field_569,
                        var51.field_84 + var27.field_690[var51.field_75][2],
                        var51.field_85 + var27.field_690[var51.field_75][3] + var27.field_692,
                        var27.field_690[var51.field_75][0],
                        var27.field_690[var51.field_75][1]
                     )
               )) {
               if (var51.field_81) {
                  var7 = var51.field_76 + var27.field_690[var51.field_75][5];
                  var5 = var51.field_77 + var27.field_690[var51.field_75][4];
               } else {
                  var7 = var51.field_76 + var27.field_690[var51.field_75][4];
                  var5 = var51.field_77 + var27.field_690[var51.field_75][5];
               }

               var27.method_237(0, var27.field_653[var33], var7, var5);
            }
         }

         for (int var34 = 0; var34 < 25; var34++) {
            class_15 var96;
            if ((var96 = var27.field_620[var34]).field_130
               && var96.field_131 < var27.field_668
               && var96.field_132 < var27.field_669
               && var27.field_609 == var27.field_673[var96.field_131][var96.field_132]
               && var96.field_139 != 3
               && var96.field_135 == 4) {
               byte var82 = var96.field_131;
               byte var53 = var96.field_132;
               var27.method_237(4, var34, var82, var53);
            }
         }

         for (int var35 = 0; var35 < 25; var35++) {
            class_15 var97;
            if ((var97 = var27.field_620[var35]).field_130
               && var97.field_131 < var27.field_668
               && var97.field_132 < var27.field_669
               && var27.field_609 == var27.field_673[var97.field_131][var97.field_132]
               && (var97.field_135 != 4 || var97.field_139 == 3)) {
               var7 = var97.field_131 + 1;
               var5 = var97.field_132 + 1;
               var27.method_237(1, var35, var7, var5);
            }
         }

         for (int var36 = 0; var36 < 10; var36++) {
            if (var27.field_629[var36].field_425) {
               byte var84 = var27.field_629[var36].field_426.field_445;
               byte var55 = var27.field_629[var36].field_426.field_446;
               var27.method_237(2, var36, var84, var55);
            }
         }

         for (int var37 = 0; var37 < 5; var37++) {
            if (var27.field_628[var37].field_442) {
               byte var85 = var27.field_628[var37].field_445;
               byte var56 = var27.field_628[var37].field_446;
               var27.method_237(3, var37, var85, var56);
            }
         }

         for (int var38 = 0; var38 < var27.field_632; var38++) {
            if (var27.field_631[var38] == 0) {
               var7 = var27.field_641[var27.field_630[var38]].field_84 - var27.field_597;
               var5 = var27.field_641[var27.field_630[var38]].field_85 - var27.field_598;
               var27.method_236(var30, var27.field_630[var38], var7, var5 + var27.field_692);
            } else if (var27.field_631[var38] == 1) {
               if (var27.field_630[var38] == var27.field_591 - 1 && var27.field_706 > 0 && var27.field_706 < 20) {
                  var27.method_238(var30);
               } else {
                  int var89 = var27.method_228(var27.field_620[var27.field_630[var38]].field_131, var27.field_620[var27.field_630[var38]].field_132)
                     - var27.field_597;
                  byte var166 = var27.field_620[var27.field_630[var38]].field_132;
                  byte var154 = var27.field_620[var27.field_630[var38]].field_131;
                  int var60 = (var166 + var154) * 27 - var27.field_598;
                  class_15 var76;
                  if ((var76 = var27.field_620[var27.field_630[var38]]) == var27.field_587.field_452
                     && var76 == var27.field_627
                     && (var76.field_135 == 1 || var76.field_135 == 12 || var76.field_135 == 13)) {
                     boolean var99 = var27.method_205(var76, 2, 1);
                     boolean var101 = var27.method_205(var76, 0, 1);
                     int var103 = 0;
                     if (var76.field_135 == 12) {
                        var103 = 2;
                     }

                     if (var76.field_135 == 13) {
                        var103 = 4;
                     }

                     if (!var101) {
                        var103++;
                     }

                     if (field_541[var76.field_139][var76.field_135][2] != 0) {
                        if (var99) {
                           var89 = (var7 = var89 + (var76.field_137 * 54 >> 16))
                              + field_545[var27.field_587.field_452.field_139].method_89(var103, var76.field_133);
                           if (var76.field_133 >= field_541[var76.field_139][var76.field_135][2]) {
                              var89 -= 54;
                           }
                        } else {
                           var89 = (var7 = var89 - (var76.field_137 * 54 >> 16))
                              - field_545[var27.field_587.field_452.field_139].method_89(var103, var76.field_133);
                           if (var76.field_133 >= field_541[var76.field_139][var76.field_135][2]) {
                              var89 += 54;
                           }
                        }

                        if (var101) {
                           var5 = var60 + (var76.field_137 * 27 >> 16);
                           if (var76.field_133 >= field_541[var76.field_139][var76.field_135][2]) {
                              var5 -= 27;
                           }
                        } else {
                           var5 = var60 - (var76.field_137 * 27 >> 16);
                           if (var76.field_133 >= field_541[var76.field_139][var76.field_135][2]) {
                              var5 += 27;
                           }
                        }

                        var60 = var5 + field_545[var27.field_587.field_452.field_139].method_90(var103, var76.field_133);
                     }
                  }

                  var27.method_235(var30, var27.field_620[var27.field_630[var38]], var89, var60 + var27.field_692);
               }
            } else if (var27.field_631[var38] == 2) {
               short var116 = var27.field_630[var38];
               int var119 = field_542[var27.field_629[var116].field_426.field_444][2] + var27.field_629[var116].field_426.field_450;
               switch (var27.field_629[var116].field_428) {
                  case 4:
                     class_21 var184 = field_548[0];
                     int var193 = var27.field_629[var116].field_426.field_447 - var27.field_597;
                     var20 = var27.field_629[var116].field_426.field_448 - var27.field_629[var116].field_426.field_449 - var27.field_598;
                     var19 = var193;
                     var184.method_101(var30, var119, var19, var20, 0, 0, 0);
                     break;
                  case 5:
                  case 6:
                  default:
                     class_21 var183 = field_548[class_0.field_7[var27.field_629[var116].field_426.field_444]];
                     int var192 = var27.field_629[var116].field_426.field_447 - var27.field_597;
                     var7 = var27.field_629[var116].field_426.field_448 - var27.field_629[var116].field_426.field_449 - var27.field_598;
                     var6 = var192;
                     var183.method_101(var30, var119, var6, var7, 0, 0, 0);
                     break;
                  case 7:
                     var119 = var27.field_629[var116].field_426.field_449 > 38
                        ? 0
                        : (
                           var27.field_629[var116].field_426.field_449 > 20
                              ? 1
                              : (var27.field_629[var116].field_426.field_449 > 15 ? 2 : (var27.field_629[var116].field_426.field_449 > 10 ? 3 : 4))
                        );
                     boolean var135;
                     if (!(var135 = var27.field_629[var116].field_434 > 4)) {
                        class_21 var181 = field_548[class_0.field_7[var27.field_629[var116].field_426.field_444]];
                        int var195 = var27.field_629[var116].field_426.field_447 - var27.field_597;
                        var19 = var27.field_629[var116].field_426.field_448 - var27.field_629[var116].field_426.field_449 - var27.field_598;
                        int var141 = var195;
                        var181.method_101(var30, var119, var141, var19, 0, 0, 0);
                     } else {
                        class_21 var182 = field_548[class_0.field_7[var27.field_629[var116].field_426.field_444]];
                        int var196 = var27.field_629[var116].field_426.field_447 - var27.field_597;
                        int var129 = var27.field_629[var116].field_426.field_448 - var27.field_629[var116].field_426.field_449 - var27.field_598;
                        var5 = var196;
                        var182.method_101(var30, var119, var5, var129, 1, 0, 0);
                     }
                     break;
                  case 8:
                     int var127;
                     var127 = (var127 = (int)(var27.field_574 % 400L)) / 100;
                     class_21 var180 = field_550[3];
                     int var191 = var27.field_629[var116].field_426.field_447 - var27.field_597;
                     int var111 = var27.field_629[var116].field_426.field_448 - var27.field_629[var116].field_426.field_449 - var27.field_598;
                     int var171 = var191;
                     var180.method_101(var30, var127, var171, var111, 0, 0, 0);
               }
            } else if (var27.field_631[var38] != 3) {
               if (var27.field_631[var38] == 4) {
                  var7 = var27.method_228(var27.field_620[var27.field_630[var38]].field_131, var27.field_620[var27.field_630[var38]].field_132)
                     - var27.field_597;
                  byte var164 = var27.field_620[var27.field_630[var38]].field_132;
                  byte var151 = var27.field_620[var27.field_630[var38]].field_131;
                  var5 = (var164 + var151) * 27 - var27.field_598;
                  var27.method_235(var30, var27.field_620[var27.field_630[var38]], var7, var5 + var27.field_692);
               }
            } else {
               short var115 = var27.field_630[var38];
               Graphics var109 = var30;
               class_27 var104 = var27;
               int var118 = field_542[var27.field_628[var115].field_444][2] + var27.field_628[var115].field_450;
               if (var27.field_628[var115].field_444 >= 5 && var27.field_628[var115].field_444 <= 36) {
                  if ((var27.field_628[var115].field_444 <= 9 || var27.field_628[var115].field_444 >= 13)
                     && (var27.field_628[var115].field_444 <= 17 || var27.field_628[var115].field_444 > 20)
                     && (var27.field_628[var115].field_444 <= 25 || var27.field_628[var115].field_444 >= 29)
                     && (var27.field_628[var115].field_444 <= 33 || var27.field_628[var115].field_444 > 36)) {
                     class_21 var178 = field_548[class_0.field_7[var27.field_628[var115].field_444]];
                     int var189 = var27.field_628[var115].field_447 - var27.field_597;
                     var20 = var27.field_628[var115].field_448 - var27.field_628[var115].field_449 - var27.field_598;
                     var19 = var189;
                     var178.method_101(var30, var118, var19, var20, 0, 0, 0);
                  } else {
                     class_21 var179 = field_548[class_0.field_7[var27.field_628[var115].field_444]];
                     int var190 = var27.field_628[var115].field_447 - var27.field_597 + 108;
                     int var110 = var27.field_628[var115].field_448 - var27.field_628[var115].field_449 - var27.field_598;
                     int var170 = var190;
                     var179.method_101(var30, var118, var170, var110, 1, 0, 0);
                  }
               } else if (var27.field_628[var115].field_444 == 39) {
                  class_21 var176 = field_548[class_0.field_7[var27.field_628[var115].field_444]];
                  int var187 = var27.field_628[var115].field_447 - var27.field_597;
                  var19 = var27.field_628[var115].field_448 - var27.field_628[var115].field_449 - var27.field_598;
                  int var140 = var187;
                  var176.method_101(var30, var118, var140, var19, 0, 0, 0);
                  if (var118 > 61 && var118 < 67) {
                     for (int var134 = 0; var134 < 4; var134++) {
                        var176 = field_548[class_0.field_7[var104.field_628[var115].field_444]];
                        var187 = var118 + (var134 + 1) * 5;
                        int var194 = var104.field_628[var115].field_447 - var104.field_597;
                        int var126 = var104.field_628[var115].field_448 - var104.field_628[var115].field_449 - var104.field_598;
                        var5 = var194;
                        int var169 = var187;
                        var176.method_101(var109, var169, var5, var126, 0, 0, 0);
                     }
                  }
               } else {
                  class_21 var175 = field_548[class_0.field_7[var27.field_628[var115].field_444]];
                  int var186 = var27.field_628[var115].field_447 - var27.field_597;
                  var7 = var27.field_628[var115].field_448 - var27.field_628[var115].field_449 - var27.field_598;
                  var6 = var186;
                  var175.method_101(var30, var118, var6, var7, 0, 0, 0);
               }
            }
         }

         for (int var39 = field_646; var39 < field_652; var39++) {
            class_9 var63;
            if ((var63 = var27.field_641[var27.field_653[var39]]).field_79
               && (
                  !var63.field_81
                     ? var63.field_76 != 0
                        && var27.field_609 == var27.field_673[var63.field_76 - 1][var63.field_77]
                        && method_226(
                           var27.field_597,
                           var27.field_598,
                           field_568,
                           field_569,
                           var63.field_84 + var27.field_690[var63.field_75][2],
                           var63.field_85 + var27.field_690[var63.field_75][3] + var27.field_692,
                           var27.field_690[var63.field_75][0],
                           var27.field_690[var63.field_75][1]
                        )
                     : var63.field_77 != 0
                        && var27.field_609 == var27.field_673[var63.field_76][var63.field_77 - 1]
                        && method_226(
                           var27.field_597,
                           var27.field_598,
                           field_568,
                           field_569,
                           var63.field_84 - var27.field_690[var63.field_75][0] - var27.field_690[var63.field_75][2] + 108,
                           var63.field_85 + var27.field_690[var63.field_75][3] + var27.field_692,
                           var27.field_690[var63.field_75][0],
                           var27.field_690[var63.field_75][1]
                        )
               )) {
               short var93 = var63.field_84;
               short var64 = var63.field_85;
               var27.method_236(var30, var27.field_653[var39], var93 - var27.field_597, var64 - var27.field_598 + var27.field_692);
            }
         }

         if (this.field_706 > 0) {
            this.method_238(var1);
         }

         this.method_284(var1);
         if (this.field_702 && !this.field_701) {
            field_780 = false;
            var7 = field_569;
            var6 = field_568;
            int var65 = 0;
            int var40 = 0;
            var40 = (byte)0;
            byte var28 = 0;
            byte var167 = 0;
            var1.setColor(var167, var28, var40);
            method_168(var1, 0, 0, var6, var7);
            if (this.field_641[215].field_79) {
               var40 = this.field_641[215].field_84 - this.field_597;
               var65 = this.field_641[215].field_85 - this.field_598 + 80;
               this.method_236(var1, 215, var40, var65 + this.field_692);
               var40 = this.field_641[542].field_84 - this.field_597;
               var65 = this.field_641[542].field_85 - this.field_598 + 80;
               this.method_236(var1, 542, var40, var65 + this.field_692);
               var40 = this.field_641[541].field_84 - this.field_597;
               var65 = this.field_641[541].field_85 - this.field_598 + 80;
               this.method_236(var1, 541, var40, var65 + this.field_692);
            }
         }

         if (method_309()) {
            var1.setColor(0);
            var1.fillRect(0, 0, field_568, class_0.field_0);
            var1.fillRect(0, field_569 - class_0.field_0, field_568, class_0.field_0);
         } else if (field_780) {
            var4 = class_3.field_42;
            var5 = 26 * this.field_587.field_452.field_141 / this.field_587.field_452.field_142;
            field_549[0].method_101(var1, 1, var4, 24, 0, 0, 0);
            if (this.field_587.field_452.field_141 < 0 && this.field_587.field_452.field_141 > 0) {
               method_349(var1, var4, 50, 26, 26);
            } else {
               method_349(var1, var4, 50 - var5, 26, 26);
            }

            field_549[0].method_101(var1, 0, var4, 24, 0, 0, 0);
            method_349(var1, 0, 0, field_568, field_569);
         }

         this.method_160(var1);
         this.method_285(var1);
         field_557.method_8(field_804);
      }
   }

   // $VF: renamed from: l () boolean
   private static boolean method_309() {
      return field_618 != 2 && (field_618 == 1 || field_617 >= 180 && field_617 <= 182);
   }

   // $VF: renamed from: m () void
   public final void method_310() {
      method_157();
      method_156();
      if (!this.field_581) {
         this.field_581 = true;
         if (this.method_162() && !field_748) {
            this.method_300();
         } else {
            this.method_147();
         }

         if (this.field_687 != null) {
            this.method_184();
         }

         this.field_574 = System.currentTimeMillis();
      }

      if (!field_790) {
         field_790 = true;
         class_11.method_12();
      }
   }

   // $VF: renamed from: n () void
   public final void method_311() {
      if (this.field_581) {
         this.field_574 = System.currentTimeMillis();
         method_327();
         this.field_581 = false;
         field_493 = field_492 == 24 ? 0 : 1;
         if (!this.method_162() && field_592 != 8 && !field_748 && field_592 != 12) {
            this.method_148();
         }
      }

      if (field_790) {
         long var2;
         field_792 = var2 = System.currentTimeMillis();
         field_805 = var2;
         this.field_799 = var2;
         field_790 = false;
         this.method_324();
         if (!field_796) {
            this.repaint();
         }

         method_327();
      }
   }

   // $VF: renamed from: a (java.lang.String, int, boolean) g
   private class_21 method_312(String var1, int var2, boolean var3) {
      this.field_473 = var1;
      return method_313(var2, true, true);
   }

   // $VF: renamed from: a (int, boolean, boolean) g
   private static class_21 method_313(int var0, boolean var1, boolean var2) {
      byte[] var4;
      if ((var4 = method_332(var0)).length == 0) {
         return null;
      } else {
         class_21 var3;
         (var3 = new class_21()).method_84(var4, 0);

         for (int var5 = 0; var5 < var3.field_402; var5++) {
            if (var1) {
               var3.method_102(var5, 0, -1, -1);
            }
         }

         if (var1 && var2) {
            var3.method_85(true);
         }

         return var3;
      }
   }

   // $VF: renamed from: g (int, int) int
   private int method_314(int var1, int var2) {
      var1 += this.field_603;
      var2 += this.field_604;
      return var1 >= this.field_603
            && var1 <= this.field_605
            && var2 >= this.field_604
            && var2 <= this.field_606
            && this.field_673[var1][var2] == this.field_609
         ? this.field_670[var1][var2]
         : 127;
   }

   // $VF: renamed from: i (int, int) void
   private static void method_315(int var0, int var1) {
      if (var0 != -2) {
         field_771 = var0;
      }

      if (var1 != -2) {
         field_772 = var1;
      }
   }

   // $VF: renamed from: V () void
   private void method_316() {
      int var1 = method_329();
      if (field_527 != null && field_535 && field_527.field_74 >= 500) {
         if (field_527.field_74 == 500) {
            var1 = 7;
         } else if (field_527.field_74 == 501) {
            var1 = 9;
         } else if (field_527.field_74 == 502) {
            var1 = 13;
         } else if (field_527.field_74 == 503) {
            var1 = 15;
         } else if (field_527.field_74 == 504) {
            var1 = 6;
         }

         field_527 = null;
         field_535 = false;
      }

      if (var1 != -1) {
         if (var1 == 6) {
            field_773 = 0;
         }

         if (field_773 < field_775.length) {
            field_775[field_773++] = var1;
         }

         if (field_773 == field_775.length) {
            if (field_775[0] == 6 && field_775[1] == 7 && field_775[2] == 9 && field_775[3] == 7 && field_775[4] == 9) {
               method_318(1);
            }

            if (field_775[0] == 6 && field_775[1] == 13 && field_775[2] == 15 && field_775[3] == 13 && field_775[4] == 15) {
               method_318(2);
            }

            if (field_775[0] == 6 && field_775[1] == 7 && field_775[2] == 15 && field_775[3] == 13 && field_775[4] == 9) {
               for (int var2 = 0; var2 < this.field_587.field_453; var2++) {
                  this.method_293((byte)var2, (byte)1);
                  this.method_293((byte)var2, (byte)2);
               }
            }

            if (field_775[0] == 6 && field_775[1] == 7 && field_775[2] == 9 && field_775[3] == 13 && field_775[4] == 15) {
               this.field_589.field_457[0] = 0;
               this.field_589.field_457[1] = 99;
               this.field_589.field_457[2] = 99;
               this.field_589.field_457[3] = 99;
               this.field_589.field_457[4] = 99;
               this.field_589.field_457[5] = 5;
               this.field_590.field_457[0] = 0;
               this.field_590.field_457[1] = 99;
               this.field_590.field_457[2] = 99;
               this.field_590.field_457[3] = 99;
               this.field_590.field_457[4] = 99;
               this.field_590.field_457[5] = 5;
            }

            if (field_775[0] == 6 && field_775[1] == 7 && field_775[2] == 15 && field_775[3] == 7 && field_775[4] == 15) {
               method_157();
               method_156();
               method_318(3);
               this.method_301();
               field_617 = 731;
               field_618 = 1;
               this.field_706 = 50;
               this.field_616 = 0;
               this.field_619 = this.field_574;
               this.field_658 = 1;
            }

            field_773++;
         }
      }
   }

   // $VF: renamed from: b (int) boolean
   static boolean method_317(int var0) {
      return (field_774 & 1 << var0) != 0;
   }

   // $VF: renamed from: h (int) void
   static void method_318(int var0) {
      if (method_317(var0)) {
         field_774 &= ~(1 << var0);
      } else {
         field_774 |= 1 << var0;
      }
   }

   // $VF: renamed from: W () void
   private void method_319() {
      if (this.field_587.field_458 == 0) {
         this.method_144(7);
      }

      if (this.field_587.field_458 == 1 || this.field_587.field_458 == 2) {
         this.method_144(14);
      }

      if (this.field_587.field_458 == 3) {
         this.method_144(23);
      }

      if (this.field_587.field_458 == 4) {
         this.method_144(20);
      }
   }

   // $VF: renamed from: o () void
   final void method_320() {
      try {
         if (this.field_588.field_462 == this.field_607) {
            byte var1 = this.field_588.field_452.field_131;
            byte var2 = this.field_588.field_452.field_132;
            if (this.field_673[var1][var2] == this.field_609) {
               if (var2 >= 20 && var2 <= 23 && var1 == 2) {
                  this.field_588.field_452.field_131++;
               }
            }
         }
      } catch (Exception var3) {
      }
   }

   // $VF: renamed from: b (javax.microedition.lcdui.Graphics, int) void
   private void method_321(Graphics var1, int var2) {
      if (System.currentTimeMillis() % 1000L > 500L) {
         field_551[0].method_119(3);
         boolean var3 = false;
         String var4 = method_361(0).toUpperCase();
         method_173(var1, var4, 180, var2, 36);
         method_158(0, 0, 360, 640, 1003);
         field_510 = true;
         field_551[0].method_119(0);
      }
   }

   // $VF: renamed from: s (int) void
   private void method_322(int var1) {
      switch (this.field_587.field_458) {
         case 0:
            switch (var1) {
               case 2:
               case 4:
               case 5:
               case 6:
                  this.method_144(42);
                  return;
               case 9:
                  this.method_144(50);
                  return;
               case 11:
                  this.method_144(46);
               case 3:
               case 7:
               case 8:
               case 10:
               default:
                  return;
            }
         case 1:
         case 2:
            switch (var1) {
               case 2:
               case 4:
               case 5:
               case 6:
                  this.method_144(40);
                  return;
               case 9:
                  this.method_144(48);
                  return;
               case 11:
                  this.method_144(44);
               case 3:
               case 7:
               case 8:
               case 10:
               default:
                  return;
            }
         case 3:
            switch (var1) {
               case 2:
               case 4:
               case 5:
               case 6:
                  this.method_144(41);
                  return;
               case 9:
                  this.method_144(49);
                  return;
               case 11:
                  this.method_144(45);
               case 3:
               case 7:
               case 8:
               case 10:
               default:
                  return;
            }
         case 4:
            switch (var1) {
               case 2:
               case 4:
               case 5:
               case 6:
                  this.method_144(43);
               case 3:
               case 7:
               case 8:
               case 10:
               default:
                  break;
               case 9:
                  this.method_144(51);
                  break;
               case 11:
                  this.method_144(47);
            }

            field_787 = true;
      }
   }

   // $VF: renamed from: p () void
   protected final void method_323() {
      if (field_791 < 0) {
         field_793 = 360;
         field_794 = 640;
         field_809 = new byte[field_815];
         field_810 = new byte[field_815];
         long var2 = System.currentTimeMillis();
         if (field_817 == null) {
            field_817 = new Random(var2);
         } else {
            field_817.setSeed(var2);
         }

         field_791 = 0;
         if (field_795 != null) {
            field_795.callSerially(this);
         }
      }
   }

   public final void hideNotify() {
      this.method_310();
   }

   public final void showNotify() {
      this.method_311();
   }

   public final void sizeChanged(int var1, int var2) {
      field_793 = var1;
      field_794 = var2;
   }

   // $VF: renamed from: X () void
   private void method_324() {
      if (field_795 != null && field_795.getCurrent() != this) {
         field_795.setCurrent(this);
      }

      this.setFullScreenMode(true);
   }

   // $VF: renamed from: run () void
   public final void run() {
      try {
         field_796 = false;
         if (field_791 >= 0) {
            if (field_790) {
               this.field_799 = Math.min(this.field_799, System.currentTimeMillis());
               Thread.sleep(1L);
            } else {
               this.repaint();
               this.serviceRepaints();
               if (field_527 != null && (field_531 || field_533 || field_535)) {
                  if (field_519 == 53 && field_594 != 900 && field_594 != 646) {
                     this.keyReleased(field_519);
                     field_535 = false;
                     field_519 = -1;
                  }

                  if (field_518 && field_527 != null) {
                     if (field_594 != 901) {
                        if (field_518 && System.currentTimeMillis() - field_532 < 100L) {
                           field_476 = false;
                        } else {
                           field_476 = true;
                        }
                     }

                     byte var2 = -1;
                     if (field_527 == null || !field_531 && !field_533) {
                        if (field_527 == null || field_527.field_74 != 14 || !field_535 && !field_531) {
                           if (field_527 != null && field_527.field_74 == 15 && (field_535 || field_531)) {
                              field_572 = 19;
                           }
                        } else if (field_594 != 900 && field_594 != 646) {
                           var2 = 53;
                        }
                     } else if (field_527.field_74 == 10) {
                        field_572 = 2563;
                     } else if (field_527.field_74 == 11) {
                        field_572 = 2049;
                     } else if (field_527.field_74 == 12) {
                        field_572 = 3076;
                     } else if (field_527.field_74 == 13) {
                        field_572 = 3586;
                     } else if (field_527.field_74 == 14 && (field_594 == 900 || field_594 == 646) && !field_517) {
                        var2 = 53;
                        field_517 = true;
                     }

                     if (var2 != -1 && var2 != field_519) {
                        if (field_519 != -1) {
                           this.keyReleased(field_519);
                        }

                        field_519 = var2;
                        this.keyPressed(var2);
                     } else if (var2 == -1 && field_535 && field_519 != -1) {
                        this.keyReleased(field_519);
                        field_519 = -1;
                     }

                     if (var2 == -1 && field_535 && field_519 == -1 && field_572 == 0) {
                        field_527 = null;
                        field_535 = false;
                     }

                     if (field_527 != null && field_527.field_74 == 14 && field_535) {
                        field_527 = null;
                        field_535 = false;
                     }
                  } else if (field_519 != -1) {
                     this.keyReleased(field_519);
                     field_519 = -1;
                  }
               }

               long var1 = System.currentTimeMillis();
               this.field_799 = Math.min(this.field_799, var1);
               Thread.sleep(Math.max(1L, (long)field_798 - (var1 - this.field_799)));
               this.field_799 = System.currentTimeMillis();
            }

            field_795.callSerially(this);
            return;
         }
      } catch (Exception var3) {
         field_791 = -1;
      }

      field_809 = null;
      field_810 = null;
      field_834 = null;
      System.gc();
      field_797.notifyDestroyed();
   }

   public final void paint(Graphics var1) {
      Graphics var13 = var1;
      class_27 var12 = this;
      if (!field_790 && !field_796) {
         field_796 = true;

         for (int var2 = 0; var2 < field_815; var2++) {
            field_809[var2] = field_810[var2];
            if (field_810[var2] != 0) {
               if (field_810[var2] < 0) {
                  field_810[var2] = 0;
               } else if (field_810[var2] < 126) {
                  field_810[var2]++;
                  if (var2 >= 18) {
                     field_810[var2] = (byte)(-field_810[var2]);
                  }
               }
            }
         }

         if (field_812 > 0) {
            if (field_812 != Integer.MAX_VALUE) {
               field_812 = field_812 - field_804;
            }

            method_327();
         }

         if ((field_804 = (int)((field_792 = System.currentTimeMillis()) - field_805)) < 0) {
            field_804 = 0;
         }

         if (field_804 > 1000) {
            field_804 = 1000;
         }

         field_805 = field_792;
         field_806 = field_806 + field_804;
         field_807++;

         try {
            field_789 = var13;
            field_788 = var13;
            class_27 var17 = var12;
            if (var12.getWidth() > var12.getHeight()) {
               var12.field_768 = true;
               class_11.method_11();
               var1 = field_788;
               var1.setColor(0);
               int var3 = var12.getWidth();
               int var8 = var12.getHeight();
               method_349(var1, 0, 0, var3, var8);
               var1.fillRect(0, 0, var3, var8);
               var1.setColor(16777215);
               int var9 = var3 >> 1;
               int var4 = var8 >> 1;
               String var5 = "The game is not supported";
               String var6 = "in landscape mode.";
               String var7 = "Please switch your phone";
               String var10 = "to portrait mode.";
               var1.setFont(Font.getFont(64, 1, 8));
               var1.drawString(var5, var9, var4 - 40, 17);
               var1.drawString(var6, var9, var4 - 20, 17);
               var1.drawString(var7, var9, var4, 17);
               var1.drawString(var10, var9, var4 + 20, 17);
            } else {
               if (var12.field_768) {
                  var12.field_768 = false;
                  var12.method_310();
                  var12.method_311();
               }

               var12.field_567 = field_788;

               do {
                  if (!var17.field_581) {
                     if (field_783) {
                        var17.field_576 = 9999;
                     } else {
                        var17.field_576 = (int)(System.currentTimeMillis() - var17.field_574);
                     }

                     var17.field_574 = var17.field_574 + (long)var17.field_576;
                     if (var17.field_576 < 0) {
                        var17.field_576 = 0;
                     }

                     var17.field_575 = var17.field_576;
                     if (var17.field_733 < 24 && field_618 != 1) {
                        var17.field_735 = var17.field_735 + var17.field_576;
                        if (var17.field_735 < 0) {
                           var17.field_735 = 0;
                        }

                        if (var17.field_735 > 60000) {
                           var17.field_735 = 0;
                           var17.field_734++;
                           if (var17.field_734 >= 60) {
                              var17.field_733++;
                              var17.field_734 = 0;
                              if (var17.field_733 >= 24) {
                                 var17.field_733 = 24;
                                 var17.field_734 = 0;
                                 var17.field_735 = 0;
                              }
                           }
                        }
                     }

                     if (var17.field_582) {
                        var17.field_575 = 0;
                        var17.field_582 = false;
                     } else {
                        var17.field_575 = var17.field_576;
                     }

                     boolean var10001;
                     label816: {
                        label732:
                        if (!field_580) {
                           if (field_592 == 2) {
                              if (field_594 == 384 || field_594 == 900) {
                                 if (field_594 == 900 && var17.method_163(2821)) {
                                    break label732;
                                 }

                                 if (field_476) {
                                    if (var17.method_163(2049) || var17.method_163(2563) || var17.method_163(3076) || var17.method_163(3586)) {
                                       var10001 = false;
                                       break label816;
                                    }
                                 } else if (var17.method_163(2049)) {
                                    var10001 = false;
                                    break label816;
                                 }
                              }

                              if (field_594 == 131 && (var17.method_163(3586) || var17.method_163(2049))) {
                                 var10001 = false;
                                 break label816;
                              }
                           }

                           if (field_592 == 14 && (var17.method_163(3586) || var17.method_163(2049))) {
                              var10001 = false;
                              break label816;
                           }
                        }

                        var10001 = true;
                     }

                     var17.field_573 = var10001;
                     var17.method_128();
                     if (!var17.method_303()) {
                        switch (field_592) {
                           case 0:
                              Graphics var85 = var17.field_567;
                              field_592 = 0;
                              if (var85 != null) {
                                 byte var94 = 0;
                                 byte var68 = 0;
                                 byte var59 = 0;
                                 var85.setColor(var59, var68, var94);
                                 method_168(var85, 0, 0, 360, 640);
                                 field_544[1].method_101(var85, 0, 180, 320, 0, 0, 0);
                                 method_173(var85, "v" + field_797.getAppProperty("MIDlet-Version"), 180, 554, 36);
                                 short var47 = 302;
                                 method_173(var85, method_361(302), 180, 577, 36);
                                 var47 = 303;
                                 method_173(var85, method_361(303), 180, 600, 36);
                              }

                              field_592 = 9999;
                              break;
                           case 1:
                              Graphics var84 = var17.field_567;
                              if (field_494) {
                                 var17.method_142();
                                 var17.method_141();
                              } else {
                                 int var92 = 0;
                                 byte var67 = 0;
                                 byte var58 = 0;
                                 var84.setColor(var58, var67, var92);
                                 method_168(var84, 0, 0, var17.field_678, var17.field_679);
                                 field_544[0].method_101(var84, 0, 0, 0, 0, 0, 0);
                                 class_21 var105 = field_544[2];
                                 var92 = field_571 - 90;
                                 int var34 = field_570;
                                 var105.method_101(var84, 0, var34, var92, 0, 0, 0);
                                 if (field_563) {
                                    var17.method_321(field_788, 560);
                                    if (var17.method_163(2821) || field_527 != null && field_535) {
                                       method_157();
                                       method_156();
                                       field_563 = false;
                                    }
                                 } else {
                                    var17.method_139();
                                    var17.method_138();
                                 }
                              }
                              break;
                           case 2:
                              if (field_594 == 130) {
                                 var17.method_305(var17.field_567);
                              } else if (field_594 == 138) {
                                 var17.method_306(var17.field_567);
                              } else {
                                 if ((field_594 & 256) != 0) {
                                    var17.method_240();
                                    var17.method_252();
                                    var17.method_278();
                                    var17.method_271();
                                    var17.method_241();
                                 }

                                 var17.method_308(var17.field_567);
                                 if (field_580) {
                                    var17.method_316();
                                 }

                                 if (field_498 != -1 && System.currentTimeMillis() - field_506 >= 1000L) {
                                    method_150(0, field_498);
                                    field_498 = -1;
                                 }
                              }

                              if (field_786 > 0 && (field_786 = field_786 - field_804) <= 0) {
                                 field_786 = 0;
                              }

                              Graphics var23 = var17.field_567;
                              if (field_786 > 0 && System.currentTimeMillis() % 600L > 300L) {
                                 var23.setColor(16711680);
                                 var23.drawRect(0, 0, 359, 639);
                                 var23.setColor(13369344);
                                 var23.drawRect(1, 1, 357, 637);
                                 var23.setColor(10027008);
                                 var23.drawRect(2, 2, 355, 635);
                                 var23.setColor(6684672);
                                 var23.drawRect(3, 3, 353, 633);
                              }

                              if (field_564 > 0) {
                                 method_350(var17.field_567, 0, 0, 360, field_564);
                                 method_350(var17.field_567, 0, 640 - field_564, 360, field_564);
                              }
                              break;
                           case 3:
                              Graphics var83 = var17.field_567;
                              byte var91 = 0;
                              int var65 = 0;
                              int var56 = 0;
                              var83.setColor(var56, var65, var91);
                              method_168(var83, 0, 0, field_568, field_569);
                              class_21 var104 = field_544[1];
                              var65 = field_571;
                              var56 = field_570;
                              var104.method_101(var83, 0, var56, var65, 0, 0, 0);
                              method_173(var83, "v" + field_797.getAppProperty("MIDlet-Version"), field_570, field_569 - 86, 36);
                              short var45 = 302;
                              method_173(var83, method_361(302), field_570, field_569 - 63, 36);
                              var45 = 303;
                              method_173(var83, method_361(303), field_570, field_569 - 40, 36);
                              break;
                           case 8:
                              switch (var17.field_465) {
                                 case 0:
                                    method_336();
                                    var17.field_473 = "/6";
                                    method_334(var17.field_473);
                                    break;
                                 case 1:
                                    method_336();
                                    var17.field_473 = "/13";
                                    method_334(var17.field_473);
                                    break;
                                 case 13:
                                    method_336();
                                    var17.field_473 = "/15";
                                    method_334(var17.field_473);
                                    break;
                                 case 24:
                                    method_336();
                                    var17.field_473 = "/14";
                                    method_334(var17.field_473);
                                    break;
                                 case 26:
                                    method_336();
                                    var17.field_473 = "/12";
                                    method_334(var17.field_473);
                                    break;
                                 case 31:
                                    method_336();
                                    var17.field_473 = "/16";
                                    method_334(var17.field_473);
                                    break;
                                 case 36:
                                    method_336();
                                    var17.field_473 = "/17";
                                    method_334(var17.field_473);
                              }

                              if (var17.field_465 < var17.field_466) {
                                 if (var17.field_465 < 1) {
                                    field_541 = (byte[][][])method_343(0);
                                    field_542 = (int[][])method_343(1);
                                 } else if (var17.field_465 < 13) {
                                    int var77 = var17.field_465 - 1;
                                    if (var17.method_134(var77)) {
                                       field_545[var77] = method_313(var77, true, true);
                                    }
                                 } else if (var17.field_465 < 24) {
                                    int var78 = var17.field_465 - 13;
                                    if (var17.method_134(var78)) {
                                       field_547[var78] = method_313(var78, true, true);
                                    }
                                 } else if (var17.field_465 < 26) {
                                    int var79 = var17.field_465 - 24;
                                    if (var17.method_134(var79)) {
                                       field_546[var79] = method_313(var79, true, true);
                                    }
                                 } else if (var17.field_465 < 31) {
                                    int var80 = var17.field_465 - 26;
                                    if (var17.method_134(var80)) {
                                       field_549[var80] = method_313(var80, true, true);
                                       if (var80 == 4) {
                                          (field_777 = new class_11(field_549[var80], 0, 0)).method_5(0, -1);
                                       }
                                    }
                                 } else if (var17.field_465 < 36) {
                                    int var81 = var17.field_465 - 31;
                                    if (var17.method_134(var81)) {
                                       field_548[var81] = method_313(var81, true, true);
                                       if (var81 == 0) {
                                          field_555 = new class_11(field_548[var81], 0, 0);
                                       }
                                    }
                                 } else {
                                    int var82 = var17.field_465 - 36;
                                    if (var17.method_134(var82)) {
                                       field_550[var82] = method_313(var82, true, true);
                                       if (var82 == 1) {
                                          field_550[1].method_102(0, 0, 1, -1);
                                       }
                                    }
                                 }
                              }

                              var17.field_465++;
                              var17.method_133(var17.field_567);
                              break;
                           case 9:
                              switch (var17.field_465) {
                                 case 0:
                                    if (var17.field_470) {
                                       var17.method_180(true);
                                    }

                                    var17.method_216();
                                    field_550[0] = null;
                                    field_550[2] = null;
                                    field_550[1] = null;
                                    field_550[3] = null;
                                    field_545[7] = null;
                                    field_545[8] = null;
                                    field_545[10] = null;
                                    field_545[9] = null;
                                    field_545[6] = null;
                                    field_547[10] = null;
                                    field_548[4] = null;
                                    System.gc();
                                    var17.field_607 = (byte)var17.field_469;
                                    break;
                                 case 1:
                                    var17.method_219();
                                    break;
                                 case 2:
                                    var17.method_132();
                                    break;
                                 case 3:
                                    if (!var17.field_608[var17.field_607]) {
                                       var17.method_221();
                                    }
                                    break;
                                 case 4:
                                    var17.field_470 = var17.field_470 & var17.field_608[var17.field_607];
                                    if (var17.field_470) {
                                       var17.method_181(true);
                                    }

                                    var17.field_608[var17.field_607] = true;
                                    if (var17.field_607 == 0 && var17.field_586) {
                                       var17.field_672[var17.field_641[545].field_76][var17.field_641[545].field_77] = -1;
                                    }

                                    var17.field_587.field_462 = var17.field_607;
                                    if (var17.field_588.field_462 != var17.field_607) {
                                       var17.field_588.field_452.field_130 = false;
                                    } else {
                                       var17.field_588.field_452.field_130 = true;
                                    }

                                    var17.method_266();
                                    var17.method_214(true);
                                    var17.method_223();
                                    var17.method_244();
                                    var17.method_233(var17.field_587.field_452, true);
                              }

                              var17.field_465++;
                              var17.method_133(var17.field_567);
                              break;
                           case 10:
                              var17.method_131();
                              var17.method_133(var17.field_567);
                              break;
                           case 11:
                              Graphics var76 = var17.field_567;
                              int var19 = 3816503;
                              field_788.setColor(var19);
                              method_350(var76, 0, 0, 360, 640);
                              field_788.setColor(0);
                              method_350(var76, class_1.field_17, class_1.field_18, class_1.field_15, class_1.field_16);
                              field_551[1].method_119(2);
                              class_21 var100 = field_551[1];
                              int var42 = 263;
                              String var113 = method_361(263).toUpperCase();
                              int var64 = class_1.field_19;
                              String var55 = var113;
                              var100.method_117(var76, var55, 180, var64, 3, true);
                              field_551[0].method_119(3);
                              String var89 = method_361(var42 = 255 + (field_496 >= 3 ? field_496 + 1 : field_496));
                              var100 = field_551[0];
                              var19 = class_1.field_21;
                              short[] var31 = var100.method_114(var89, var19, false);
                              field_551[0].method_115(var76, var89, var31, class_1.field_22, class_1.field_23, 0, -1, 20, -1);
                              String var44 = field_496 + 1 + "/" + 3;
                              field_536 = field_556[0].method_91(43);
                              field_537 = field_556[0].method_92(43);
                              var100 = field_556[0];
                              int var114 = field_527 != null && field_527.field_74 == 3 ? 44 : 43;
                              int var119 = 180 - field_536;
                              var19 = class_1.field_25;
                              int var32 = var119;
                              int var97 = var114;
                              var100.method_101(var76, var97, var32, var19, 0, 0, 0);
                              method_158(180 - field_536 * 3 / 2, class_1.field_25 - field_537 / 2, field_536, field_537, 3);
                              var100 = field_556[0];
                              int var115 = field_527 != null && field_527.field_74 == 4 ? 46 : 45;
                              var119 = 180 + field_536;
                              var19 = class_1.field_25;
                              int var90 = var119;
                              int var33 = var115;
                              var100.method_101(var76, var33, var90, var19, 0, 0, 0);
                              method_158(180 + (field_536 >> 1), class_1.field_25 - field_537 / 2, field_536, field_537, 4);
                              field_510 = true;
                              method_173(var76, var44, 180, class_1.field_25 - field_537 / 4, 36);
                              if (!var17.method_163(2563) && (field_527 == null || field_527.field_74 != 3 || !field_535)) {
                                 if (!var17.method_163(3076) && (field_527 == null || field_527.field_74 != 4 || !field_535)) {
                                    if (var17.method_163(19) || field_528 != null && field_528.field_74 == 1002 && field_535) {
                                       method_157();
                                       method_156();
                                       if (field_497 == 0) {
                                          field_592 = 1;
                                          method_151(0);
                                       } else {
                                          field_592 = 2;
                                       }

                                       var17.method_144(21);
                                    }
                                 } else {
                                    method_157();
                                    method_156();
                                    if (field_496 < 2) {
                                       field_496++;
                                    } else {
                                       field_496 = 0;
                                    }
                                 }
                              } else {
                                 method_157();
                                 method_156();
                                 if (field_496 > 0) {
                                    field_496--;
                                 } else {
                                    field_496 = 2;
                                 }
                              }

                              method_327();
                              break;
                           case 12:
                              int var75 = method_330();
                              byte var88 = 0;
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
                                    var17.method_144(8);
                                    var88 = 25;
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
                                    var17.method_144(21);
                                    var88 = 26;
                              }

                              boolean var30 = class_17.method_56(var88);
                              class_17.method_62(field_788);
                              if (var30) {
                                 var17.method_215(1, 129);
                                 var17.method_145(0);
                              }
                              break;
                           case 14:
                              Graphics var73 = var17.field_567;
                              int var28 = 3816503;
                              field_788.setColor(var28);
                              method_350(var73, 0, 0, 360, 640);
                              field_788.setColor(0);
                              method_350(var73, class_2.field_28, class_2.field_29, class_2.field_26, class_2.field_27);
                              method_349(var73, class_2.field_30, class_2.field_31, 360, class_2.field_32);
                              field_551[0].method_119(3);
                              if (field_509 != null) {
                                 class_21 var98 = field_551[0];
                                 int var96 = var17.field_465;
                                 short[] var54 = field_509;
                                 String var40 = field_508;
                                 var98.method_115(var73, var40, var54, 180, var96, 0, -1, 17, -1);
                              }

                              method_349(field_788, 0, 0, 360, 640);
                              field_551[1].method_119(2);
                              class_21 var99 = field_551[1];
                              short var41 = 264;
                              String var112 = method_361(264).toUpperCase();
                              int var18 = class_2.field_33;
                              String var29 = var112;
                              var99.method_117(var73, var29, 180, var18, 3, true);
                              int var74 = 2;
                              if (var17.method_163(3586)) {
                                 var74 = 4;
                              } else if (var17.method_163(2049)) {
                                 var74 = -4;
                              } else if (var17.method_163(19) || field_528 != null && field_528.field_74 == 1002 && field_535 && !field_746) {
                                 method_157();
                                 method_156();
                                 if (field_507 == 0) {
                                    field_592 = 1;
                                 } else {
                                    var17.method_215(1, 129);
                                 }

                                 method_151(6);
                                 var17.method_144(21);
                                 field_508 = null;
                                 field_509 = null;
                                 method_327();
                                 field_617 = 0;
                              }

                              if (field_531) {
                                 var74 = 0;
                              } else if (field_533) {
                                 var74 = field_524 = (field_523 - field_530) / 10;
                              } else if (field_535) {
                                 if (field_524 > 0) {
                                    field_524--;
                                 } else if (field_524 < 0) {
                                    field_524++;
                                 }

                                 if (field_524 != 0) {
                                    var74 = field_524;
                                 }
                              }

                              if (field_509 != null) {
                                 if (var74 > 0) {
                                    if (var17.field_465 > class_2.field_31 - field_509[0] * (field_551[0].method_113() + field_551[0].method_111())) {
                                       var17.field_465 -= var74;
                                    } else {
                                       var17.field_465 = 640;
                                    }
                                 } else if (var74 < 0) {
                                    if (var17.field_465 < 640) {
                                       var17.field_465 -= var74;
                                    } else {
                                       var17.field_465 = class_2.field_31 - field_509[0] * (field_551[0].method_113() + field_551[0].method_111());
                                    }
                                 }
                              }

                              if (field_746 && var17.field_465 == 640) {
                                 field_617 = 0;
                                 if (field_558) {
                                    var17.method_215(15, 0);
                                    var17.method_128();
                                 }

                                 field_746 = false;
                              }
                              break;
                           case 15:
                              field_788.setColor(0);
                              method_349(field_788, 0, 0, 360, 640);
                              int var38 = field_794;
                              int var25 = field_793;
                              method_350(field_788, 0, 0, var25, var38);
                              field_551[0].method_119(0);
                              short var39 = 315;
                              String var87 = method_361(315);
                              short[] var26 = field_551[0].method_114(var87, 360, false);
                              field_551[0].method_115(field_788, var87, var26, 180, class_5.field_66, 0, -1, 3, -1);
                              boolean var72 = var17.method_163(2821) || var17.method_163(18);
                              field_536 = field_556[1].method_91(15) + 2;
                              field_537 = field_556[1].method_92(15) + 2;
                              class_21 var10000 = field_556[1];
                              int var10002 = field_527 != null && field_527.field_74 == 0 ? 19 : 20;
                              int var10003 = (field_536 >> 1) + 2;
                              var25 = (field_537 >> 1) + 2;
                              int var95 = var10003;
                              int var63 = var10002;
                              Graphics var53 = field_788;
                              var10000.method_101(var53, var63, var95, var25, 0, 0, 0);
                              method_158(0, 0, class_3.field_41, class_3.field_41, 0);
                              field_510 = true;
                              if (var72 || field_527 != null && field_527.field_74 == 0 && field_535) {
                                 method_156();
                                 method_157();
                                 var17.method_215(12, 0);
                                 var17.method_128();
                              }
                              break;
                           case 9999:
                              var17.method_195();
                        }

                        if (var17.field_766 == 0 && var17.field_767 == 0 && !field_563) {
                           method_349(var17.field_567, 0, 0, 360, 640);
                           if (!field_783) {
                              Graphics var86 = var17.field_567;
                              method_315(-1, -1);
                              if (field_592 == 2) {
                                 int var35 = field_784 ? 2 : 0;
                                 if (field_580) {
                                    if (field_494 && field_492 == 24) {
                                       method_315(3, -1);
                                    } else {
                                       method_315(-1, -1);
                                    }
                                 } else if ((field_594 & 256) == 0 && (field_594 & 512) == 0) {
                                    if (field_594 != 130 && field_594 != 138) {
                                       if (field_594 == 137) {
                                          method_315(3, -1);
                                       } else if (field_594 == 139) {
                                          method_315(3, -1);
                                       } else if (field_594 == 131) {
                                          if (field_633 == 3) {
                                             method_315(-1, -1);
                                          } else if (field_633 == 1) {
                                             method_315(var35, 1);
                                          } else {
                                             method_315(var35, -1);
                                          }
                                       } else {
                                          method_315(3, -1);
                                       }
                                    } else {
                                       label832: {
                                          if (field_594 == 138) {
                                             boolean var15 = false;
                                             byte var69 = 0;
                                             byte var60;
                                             if ((var60 = var17.field_694 == 0 ? var17.field_689[2 * var17.field_695] : var17.field_689[2 * var17.field_696])
                                                <= 6) {
                                                var15 = var17.field_694 == 0
                                                   ? var17.field_590.field_454[var60].field_117
                                                   : var17.field_589.field_454[var60].field_117;
                                                var69 = var17.field_694 == 0 ? var17.field_589.field_457[var60 - 1] : var17.field_590.field_457[var60 - 1];
                                             }

                                             boolean var106;
                                             label605: {
                                                if (var60 < 6) {
                                                   if (var60 <= 1 || var60 >= 6 || !var15) {
                                                      var106 = false;
                                                      break label605;
                                                   }

                                                   if (var69 <= 0) {
                                                      var106 = false;
                                                      break label605;
                                                   }
                                                } else if (var60 == 6 && var69 < 1) {
                                                   var106 = false;
                                                   break label605;
                                                }

                                                var106 = true;
                                             }

                                             if (!var106) {
                                                method_315(-1, 1);
                                                break label832;
                                             }
                                          }

                                          method_315(3, 1);
                                       }
                                    }
                                 } else if (field_617 == 731) {
                                    method_315(-1, -1);
                                 } else if (!method_309() && field_780 && field_594 != 901 && field_594 != 646 && field_594 != 647) {
                                    method_315(var35, -1);
                                 } else {
                                    method_315(var35, -1);
                                 }
                              } else if (field_592 == 1) {
                                 if (field_479 == 1) {
                                    method_315(3, 1);
                                 } else if (field_494) {
                                    if (field_492 == 3) {
                                       method_315(3, -1);
                                    } else {
                                       method_315(3, -1);
                                    }
                                 } else {
                                    method_315(3, -1);
                                 }
                              } else if (field_592 == 11) {
                                 method_315(-1, 1);
                              } else if (field_592 == 14) {
                                 if (field_746) {
                                    method_315(-1, -1);
                                 } else {
                                    method_315(-1, 1);
                                 }
                              } else if (field_592 == 15) {
                                 method_315(3, -1);
                              }

                              if (field_771 == 3) {
                                 field_771 = -1;
                              }

                              if (field_771 != -1) {
                                 field_536 = field_556[1].method_91(21) + 2;
                                 field_537 = field_556[1].method_92(21) + 2;
                                 if (field_771 == 2 && field_592 == 2 && field_784) {
                                    method_159(0, 0, field_536, field_537, 1001);
                                    class_21 var108 = field_556[1];
                                    int var117 = field_528 != null && field_528.field_74 == 1001 ? 21 : 22;
                                    int var122 = (field_536 >> 1) + 2;
                                    int var71 = (field_537 >> 1) + 2;
                                    int var62 = var122;
                                    int var50 = var117;
                                    var108.method_101(var86, var50, var62, var71, 0, 0, 0);
                                    field_551[0].method_119(field_528 != null && field_528.field_74 == 1001 ? 3 : 0);
                                    var108 = field_551[0];
                                    short var51 = 905;
                                    var108.method_117(var86, method_361(905), field_536 >> 1, field_537 >> 1, 3, false);
                                    field_551[0].method_119(0);
                                 } else {
                                    if (!field_749 && var17.method_162() && field_771 << 1 == 0) {
                                       class_21 var107 = field_556[1];
                                       int var116 = field_528 != null && field_528.field_74 == 1001 ? 16 : 15;
                                       int var121 = (field_536 >> 1) + 2 - field_536 / 4;
                                       int var70 = (field_537 >> 1) + 2;
                                       int var61 = var121;
                                       int var49 = var116;
                                       var107.method_101(var86, var49, var61, var70, 0, 0, 0);
                                    }

                                    method_159(0, 0, field_536, field_537, 1001);
                                 }
                              }

                              if (field_772 != -1) {
                                 field_536 = field_556[1].method_91(17) + 2;
                                 field_537 = field_556[1].method_92(17) + 2;
                                 class_21 var110 = field_556[1];
                                 int var118 = field_528 != null && field_528.field_74 == 1002 ? 18 : 17;
                                 int var123 = field_568 - ((field_536 >> 1) + 2);
                                 int var52 = 640 - (field_537 >> 1) + -2;
                                 int var36 = var123;
                                 int var16 = var118;
                                 var110.method_101(var86, var16, var36, var52, 0, 0, 0);
                                 method_159(field_568 - class_3.field_41, 640 - field_537 + -2 + 2, class_3.field_41, class_3.field_41, 1002);
                                 if (field_772 < 0) {
                                    field_772 = -field_772;
                                 }
                              }

                              if (field_771 != -1 || field_772 != -1) {
                                 field_511 = true;
                              }
                           }
                        }

                        if (field_592 == 2) {
                           field_557.method_8(field_804);
                        }

                        if (field_580) {
                           if (field_494) {
                              var17.method_142();
                              var17.method_141();
                           } else if (field_592 != 11 && field_592 != 9) {
                              if (var17.field_767 > 0) {
                                 var17.field_767--;
                              } else {
                                 int var24 = ((field_481 < 10 ? field_481 : 10) + 1) * 43;
                                 field_489 = (640 - var24 >> 1) + 10;
                                 class_21 var111 = field_556[0];
                                 Graphics var37 = field_788;
                                 var111.method_101(var37, 0, 180, 320, 0, 0, 0);
                                 method_158(0, 0, field_540, field_540, 500);
                                 method_158(360 - field_540, 0, field_540, field_540, 501);
                                 method_158(0, 640 - field_540, field_540, field_540, 502);
                                 method_158(360 - field_540, 640 - field_540, field_540, field_540, 503);
                                 method_158(180 - field_540 / 2, 0, field_540, field_540, 504);
                                 var17.method_139();
                                 var17.method_138();
                              }
                           }
                        }
                     }
                  }
               } while (field_783);

               class_11.method_10();
               if (field_514) {
                  if (field_512 == 0L) {
                     field_512 = System.currentTimeMillis();
                  }

                  if (System.currentTimeMillis() - field_512 > 300L) {
                     field_513 = true;
                     field_514 = false;
                     field_512 = 0L;
                  }
               }
            }
         } catch (Exception var11) {
            field_791 = -1;
         }

         field_796 = false;
      }
   }

   protected final void keyPressed(int var1) {
      byte var2 = method_326(var1);
      if (field_810 != null) {
         if (field_810[var2] <= 0) {
            if (field_810[var2] < 0) {
               field_810[var2] = 0;
            }

            if (field_810[var2] < 126) {
               field_810[var2]++;
            }
         }
      }
   }

   protected final void keyReleased(int var1) {
      byte var2 = method_326(var1);
      if (field_810 != null) {
         if (field_810[var2] > 0) {
            field_810[var2] = (byte)(-field_810[var2]);
         }
      }
   }

   // $VF: renamed from: b (boolean, int, int) void
   private static void method_325(boolean var0, int var1, int var2) {
      Integer var5 = new Integer(var1);
      Hashtable var4 = field_813;
      if ((Integer)field_813.get(var5) != null) {
         var4.remove(var5);
      }

      var4.put(var5, new Integer(var2));
   }

   // $VF: renamed from: a (int) byte
   private static byte method_326(int var0) {
      Integer var2 = new Integer(var0);
      if (field_813 == null) {
         return 0;
      } else {
         Integer var1;
         if ((var1 = (Integer)field_813.get(var2)) != null) {
            return var1.byteValue();
         } else {
            return (var1 = (Integer)field_814.get(var2)) != null ? var1.byteValue() : (byte)0;
         }
      }
   }

   // $VF: renamed from: Y () void
   private static void method_327() {
      if (field_809 != null && field_810 != null) {
         for (int var0 = 0; var0 < field_815; var0++) {
            field_809[var0] = 0;
            field_810[var0] = 0;
         }
      }
   }

   // $VF: renamed from: f (int) boolean
   private static boolean method_328(int var0) {
      return field_809[var0] > 0;
   }

   // $VF: renamed from: b () int
   public static int method_329() {
      int var0 = field_815;

      while (--var0 >= 0) {
         if (field_809[var0] == 1) {
            return var0;
         }
      }

      return -1;
   }

   // $VF: renamed from: e () int
   private static int method_330() {
      int var0 = field_815;

      while (--var0 >= 0) {
         if (field_809[var0] < 0) {
            return var0;
         }
      }

      return -1;
   }

   // $VF: renamed from: g (int) boolean
   private static boolean method_331(int var0) {
      return field_809[var0] == 1;
   }

   // $VF: renamed from: a (int) byte[]
   private static byte[] method_332(int var0) {
      int var40 = method_338(var0);
      byte[] var1 = null;
      if (field_832) {
         try {
            InputStream var2 = field_821;
            byte[] var4 = new byte[var40 + 1];
            method_359(var2, var4, 0, var40);
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
            field_839 = new byte[var41];
            field_841 = new short[var7];
            int var10000 = var7 << 1;
            var7 = var41;
            int var50 = var47;
            int var42 = var10000;
            int var8 = 1846 + (768 << var47 + var5);
            short[] var9 = field_841;
            int var10 = 0;
            boolean var11 = false;
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

               int var35 = var4.length;
               field_835 = var4;
               field_836 = var35;
               field_840 = 13;
               field_838 = 0L;
               field_837 = 4294967295L;
               var4[field_836 - 1] = -1;

               for (int var36 = 0; var36 < 5; var36++) {
                  field_838 = field_838 << 8 | (long)(field_835[field_840++] & 255);
               }

               while (var17 < var7) {
                  int var44 = var17 & var54;
                  if (method_344(0 + (var10 << 4) + var44) == 0) {
                     var6 = 1846 + 768 * (((var17 & var52) << var50) + ((var12 & 0xFF) >> 8 - var50));
                     if (var10 < 4) {
                        var10 = 0;
                     } else if (var10 < 10) {
                        var10 -= 3;
                     } else {
                        var10 -= 6;
                     }

                     if (var11) {
                        byte var66 = field_839[var17 - var69];
                        byte var72 = var66;
                        int var62 = var6;
                        int var73 = 1;

                        do {
                           int var38 = var72 >> 7 & 1;
                           var72 = (byte)(var72 << 1);
                           int var74 = method_344(var62 + (var38 + 1 << 8) + var73);
                           var73 = var73 << 1 | var74;
                           if (var38 != var74) {
                              while (var73 < 256) {
                                 var73 = var73 << 1 | method_344(var62 + var73);
                              }
                              break;
                           }
                        } while (var73 < 256);

                        var12 = var73 & 0xFF;
                        var11 = false;
                     } else {
                        int var71 = 1;

                        while ((var71 = var71 << 1 | method_344(var6 + var71)) < 256) {
                        }

                        var12 = var71 & 0xFF;
                     }

                     field_839[var17++] = (byte)var12;
                  } else {
                     var11 = true;
                     int var45;
                     if (method_344(var10 + 192) == 1) {
                        if (method_344(var10 + 204) == 0) {
                           if (method_344(240 + (var10 << 4) + var44) == 0) {
                              var10 = var10 < 7 ? 9 : 11;
                              var12 = field_839[var17 - var69] & 255;
                              field_839[var17++] = (byte)var12;
                              continue;
                           }
                        } else {
                           if (method_344(var10 + 216) == 0) {
                              var6 = var14;
                           } else {
                              if (method_344(var10 + 228) == 0) {
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

                        var45 = method_346(1332, var44);
                        var10 = var10 < 7 ? 8 : 11;
                     } else {
                        var16 = var15;
                        var15 = var14;
                        var14 = var69;
                        var10 = var10 < 7 ? 7 : 10;
                        var45 = method_346(818, var44);
                        if ((var6 = method_345(432 + ((var45 < 4 ? var45 : 3) << 6), 6)) < 4) {
                           var69 = var6;
                        } else {
                           var8 = (var6 >> 1) - 1;
                           var69 = (2 | var6 & 1) << var8;
                           if (var6 < 14) {
                              var69 += method_347(var69 + 688 - var6 - 1, var8);
                           } else {
                              var6 = var8 - 4;
                              long var70 = field_837;
                              long var37 = field_838;
                              byte var65 = 0;

                              for (int var59 = var6; var59 > 0; var59--) {
                                 var70 >>= 1;
                                 var65 <<= 1;
                                 if (var37 >= var70) {
                                    var37 -= var70;
                                    var65 |= 1;
                                 }

                                 if (var70 < 16777216L) {
                                    var70 <<= 8;
                                    var37 = var37 << 8 | (long)(field_835[field_840++] & 255);
                                 }
                              }

                              field_837 = var70;
                              field_838 = var37;
                              int var68;
                              var69 = (var68 = var69 + (var65 << 4)) + method_347(802, 4);
                           }
                        }

                        var69++;
                     }

                     int var46 = var45 + 2;

                     while (true) {
                        var12 = field_839[var17 - var69] & 255;
                        field_839[var17++] = (byte)var12;
                        if (--var46 <= 0 || var17 >= var7) {
                           break;
                        }
                     }
                  }
               }
            }

            field_841 = null;
            field_835 = null;
            System.gc();
            field_825 += var40;
            var1 = field_839;
            field_839 = null;
         } catch (Exception var39) {
         }
      } else {
         method_342(var1 = new byte[var40], 0, var1.length);
      }

      return var1;
   }

   // $VF: renamed from: Z () void
   private static void method_333() {
      int var0;
      if (field_830 == field_828 - 1) {
         var0 = field_826 - field_829[field_830];
      } else {
         var0 = field_829[field_830 + 1] - field_829[field_830];
      }

      field_827 = new int[var0 + 1];

      for (int var1 = 0; var1 < var0 + 1; var1++) {
         field_827[var1] = method_340() & 0xFF | (method_340() & 0xFF) << 8 | (method_340() & 0xFF) << 16 | (method_340() & 0xFF) << 24;
      }
   }

   // $VF: renamed from: a (java.lang.String) void
   private static void method_334(String var0) {
      field_822 = 1;
      boolean var1 = false;
      Object var2 = null;
      if (field_820 == null || var0 == null || var0.compareTo(field_820) != 0) {
         method_336();
         field_820 = var0;
         field_823 = null;
         field_824 = 0;
         field_821 = method_335(field_820);
         field_826 = (short)method_341();
         field_829 = new short[field_828 = (short)method_341()];

         for (int var4 = 0; var4 < field_828; var4++) {
            field_829[var4] = (short)method_341();
         }

         field_830 = 0;
         method_333();
      }
   }

   // $VF: renamed from: a (java.lang.String) java.io.InputStream
   private static InputStream method_335(String var0) {
      Object var1 = null;
      if (field_822 == 3) {
         var1 = new ByteArrayInputStream(field_823, field_824, field_823.length - field_824);
      } else if (field_822 != 2 && field_822 == 1) {
         var1 = "".getClass().getResourceAsStream(var0);
      }

      return (InputStream)var1;
   }

   // $VF: renamed from: aa () void
   private static void method_336() {
      method_337();
      if (field_822 == 3) {
         field_823 = null;
      }

      System.gc();
   }

   // $VF: renamed from: ab () void
   private static final void method_337() {
      if (field_821 != null) {
         try {
            field_821.close();
         } catch (Exception var0) {
         }

         field_821 = null;
      }

      field_825 = 0;
   }

   // $VF: renamed from: d (int) int
   private static int method_338(int var0) {
      int var1 = field_828 - 1;

      while (var1 >= 0 && field_829[var1] > var0) {
         var1--;
      }

      if (field_830 != var1) {
         field_830 = var1;
         method_336();
         if (field_830 == 0) {
            String var4 = field_820;
            field_820 = null;
            method_334(var4);
         } else {
            field_821 = method_335(field_820 + "." + field_830);
            method_333();
         }
      } else if (field_821 == null) {
         if (field_830 == 0) {
            String var5 = field_820;
            field_820 = null;
            method_334(var5);
         } else {
            field_821 = method_335(field_820 + "." + field_830);
         }
      }

      var0 -= field_829[field_830];
      var1 = field_827[var0];
      int var3 = field_827[var0 + 1] - field_827[var0];
      int var7 = var1;
      if (field_825 != var1) {
         if (field_825 > var1) {
            method_337();
            if (field_830 == 0) {
               field_821 = method_335(field_820);
            } else {
               field_821 = method_335(field_820 + "." + field_830);
            }
         } else {
            var7 = var1 - field_825;
         }

         method_339(var7);
      }

      field_832 = false;
      if (var3 > 0) {
         if ((field_831 = method_340() & 0xFF) >= 127) {
            field_831 -= 127;
            field_832 = true;
         }

         var3--;
      }

      return var3;
   }

   // $VF: renamed from: t (int) void
   private static void method_339(int var0) {
      if (var0 != 0) {
         if (field_822 == 3) {
            field_825 += var0;

            try {
               while (var0 > 0) {
                  var0 = (int)((long)var0 - field_821.skip((long)var0));
               }
            } catch (Exception var1) {
            }
         } else {
            if (field_833 == null) {
               field_833 = new byte[256];
            }

            while (var0 > 256) {
               method_342(field_833, 0, 256);
               var0 -= 256;
            }

            if (var0 > 0) {
               method_342(field_833, 0, var0);
            }
         }
      }
   }

   // $VF: renamed from: f () int
   private static int method_340() {
      int var0 = 0;

      try {
         var0 = field_821.read();
      } catch (Exception var1) {
      }

      field_825++;
      return var0;
   }

   // $VF: renamed from: g () int
   private static int method_341() {
      return method_340() & 0xFF | (method_340() & 0xFF) << 8;
   }

   // $VF: renamed from: a (byte[], int, int) int
   private static int method_342(byte[] var0, int var1, int var2) {
      int var6 = 0;
      int var3 = var2;

      try {
         while (var3 > 0) {
            int var4 = field_821.read(var0, var6, var3);
            var3 -= var4;
            var6 += var4;
         }
      } catch (Exception var5) {
      }

      field_825 += var2;
      return var2;
   }

   // $VF: renamed from: a (int) java.lang.Object
   private static Object method_343(int var0) {
      method_338(var0);
      field_842 = 0;
      Object var2;
      if (field_832) {
         byte[] var1 = method_332(var0);
         var2 = method_355(new ByteArrayInputStream(var1));
      } else {
         var2 = method_355(field_821);
         field_825 = field_825 + field_842;
      }

      return var2;
   }

   // $VF: renamed from: e (int) int
   private static int method_344(int var0) {
      long var1 = (field_837 >> 11) * (long)field_841[var0];
      if (field_838 < var1) {
         field_837 = var1;
         field_841[var0] = (short)(field_841[var0] + (2048 - field_841[var0] >> 5));
         if (field_837 < 16777216L) {
            field_838 = field_838 << 8 | (long)(field_835[field_840++] & 255);
            field_837 <<= 8;
         }

         return 0;
      } else {
         field_837 -= var1;
         field_838 -= var1;
         field_841[var0] = (short)(field_841[var0] - (field_841[var0] >> 5));
         if (field_837 < 16777216L) {
            field_838 = field_838 << 8 | (long)(field_835[field_840++] & 255);
            field_837 <<= 8;
         }

         return 1;
      }
   }

   // $VF: renamed from: h (int, int) int
   private static int method_345(int var0, int var1) {
      int var2 = 1;

      for (int var3 = var1; var3 > 0; var3--) {
         var2 = (var2 << 1) + method_344(var0 + var2);
      }

      return var2 - (1 << var1);
   }

   // $VF: renamed from: i (int, int) int
   private static int method_346(int var0, int var1) {
      if (method_344(var0) == 0) {
         return method_345(var0 + 2 + (var1 << 3), 3);
      } else {
         return method_344(var0 + 1) == 0 ? 8 + method_345(var0 + 130 + (var1 << 3), 3) : 16 + method_345(var0 + 258, 8);
      }
   }

   // $VF: renamed from: j (int, int) int
   private static int method_347(int var0, int var1) {
      int var2 = 1;
      int var3 = 0;

      for (int var5 = 0; var5 < var1; var5++) {
         int var4 = method_344(var0 + var2);
         var2 = (var2 << 1) + var4;
         var3 |= var4 << var5;
      }

      return var3;
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, int, int, int, int) void
   static final void method_348(Graphics var0, int var1, int var2, int var3, int var4) {
      var0.clipRect(var1, var2, var3, var4);
   }

   // $VF: renamed from: b (javax.microedition.lcdui.Graphics, int, int, int, int) void
   static final void method_349(Graphics var0, int var1, int var2, int var3, int var4) {
      var0.setClip(var1, var2, var3, var4);
   }

   // $VF: renamed from: c (javax.microedition.lcdui.Graphics, int, int, int, int) void
   static final void method_350(Graphics var0, int var1, int var2, int var3, int var4) {
      var0.fillRect(var1, var2, var3, var4);
   }

   // $VF: renamed from: b (int, int, int, int) void
   static final void method_351(int var0, int var1, int var2, int var3) {
      field_788.drawRect(var0, var1, var2, var3);
   }

   // $VF: renamed from: a (javax.microedition.lcdui.Graphics, int[], int, int, int, int, int, int, boolean, boolean, int) void
   static final void method_352(Graphics var0, int[] var1, int var2, int var3, int var4, int var5, int var6, int var7, boolean var8, boolean var9, int var10) {
      if (var10 != 0) {
         if ((var10 & 4) != 0) {
            var3 = var6;
            var6 = var7;
            var7 = var3;
            var3 = var6;
         }

         var1 = class_21.method_122(var1, var6, var7, var10);
      }

      int var9i = var0.getTranslateX();
      var10 = var0.getTranslateY();
      var0.translate(-var9i, -var10);
      var0.drawRGB(var1, var2, var3, var4 + var9i, var5 + var10, var6, var7, var8);
      var0.translate(var9i, var10);
   }

   // $VF: renamed from: a (byte[], int, short) int
   private static int method_353(byte[] var0, int var1, short var2) {
      var0[var1++] = (byte)var2;
      var0[var1++] = (byte)(var2 >>> 8);
      return var1;
   }

   // $VF: renamed from: a (byte[], int) short
   static short method_354(byte[] var0, int var1) {
      return (short)(var0[var1++] & 255 | (var0[var1] & 255) << 8);
   }

   // $VF: renamed from: a (java.io.InputStream) java.lang.Object
   private static Object method_355(InputStream var0) {
      Object var1 = null;

      try {
         int var2;
         int var3 = (var2 = method_356(var0)) >> 4;
         int var4 = var2 & 7;
         if ((var2 & 8) != 0) {
            var2 = method_357(var0);
         } else {
            var2 = method_356(var0);
         }

         switch (var4) {
            case 0:
               byte[] var18 = new byte[var2];

               for (int var13 = 0; var13 < var2; var13++) {
                  var18[var13] = (byte)method_356(var0);
               }

               var1 = var18;
               break;
            case 1:
               short[] var17 = new short[var2];
               if (var3 == 0) {
                  for (int var12 = 0; var12 < var2; var12++) {
                     var17[var12] = (byte)method_356(var0);
                  }
               } else {
                  for (int var11 = 0; var11 < var2; var11++) {
                     var17[var11] = (short)method_357(var0);
                  }
               }

               var1 = var17;
               break;
            case 2:
               int[] var16 = new int[var2];
               if (var3 == 0) {
                  for (int var10 = 0; var10 < var2; var10++) {
                     var16[var10] = (byte)method_356(var0);
                  }
               } else if (var3 == 1) {
                  for (int var9 = 0; var9 < var2; var9++) {
                     var16[var9] = (short)method_357(var0);
                  }
               } else {
                  for (int var8 = 0; var8 < var2; var8++) {
                     var16[var8] = method_358(var0);
                  }
               }

               var1 = var16;
               break;
            default:
               Object[] var15;
               switch (var4 = var4 & 3) {
                  case 0:
                     if (var3 == 2) {
                        var15 = (Object[])(new byte[var2][]);
                     } else {
                        var15 = (Object[])(new byte[var2][][]);
                     }
                     break;
                  case 1:
                     if (var3 == 2) {
                        var15 = (Object[])(new short[var2][]);
                     } else {
                        var15 = (Object[])(new short[var2][][]);
                     }
                     break;
                  default:
                     if (var3 == 2) {
                        var15 = (Object[])(new int[var2][]);
                     } else {
                        var15 = (Object[])(new int[var2][][]);
                     }
               }

               for (int var7 = 0; var7 < var2; var7++) {
                  var15[var7] = method_355(var0);
               }

               var1 = var15;
         }
      } catch (Exception var5) {
      }

      return var1;
   }

   // $VF: renamed from: a (java.io.InputStream) int
   private static int method_356(InputStream var0) {
      int var1;
      if ((var1 = var0.read()) >= 0) {
         field_842++;
      }

      return var1;
   }

   // $VF: renamed from: b (java.io.InputStream) int
   private static int method_357(InputStream var0) {
      return method_356(var0) & 0xFF | (method_356(var0) & 0xFF) << 8;
   }

   // $VF: renamed from: c (java.io.InputStream) int
   private static int method_358(InputStream var0) {
      return method_356(var0) & 0xFF | (method_356(var0) & 0xFF) << 8 | (method_356(var0) & 0xFF) << 16 | (method_356(var0) & 0xFF) << 24;
   }

   // $VF: renamed from: a (java.io.InputStream, byte[], int, int) int
   private static int method_359(InputStream var0, byte[] var1, int var2, int var3) {
      int var7 = 0;
      int var4 = var3;

      try {
         while (var4 > 0) {
            int var5 = var0.read(var1, var7, var4);
            var4 -= var5;
            var7 += var5;
         }
      } catch (Exception var6) {
      }

      field_842 += var3;
      return var3;
   }

   // $VF: renamed from: d (java.io.InputStream) int
   private static int method_360(InputStream var0) {
      try {
         field_846 = new int[(field_843 = method_358(var0)) + 1];

         for (int var1 = 1; var1 < field_843 + 1; var1++) {
            field_846[var1] = method_358(var0);
         }

         field_845 = new byte[field_846[field_843]];
         method_359(var0, field_845, 0, field_845.length);
      } catch (Exception var2) {
      }

      return field_845.length + (field_843 + 1 << 2);
   }

   // $VF: renamed from: b (int) java.lang.String
   private static String method_361(int var0) {
      if (field_847 != null) {
         return field_847[var0];
      } else {
         try {
            int var1;
            return (var1 = field_846[var0 + 1] - field_846[var0]) == 0 ? null : new String(field_845, field_846[var0], var1, field_844);
         } catch (Exception var2) {
            return null;
         }
      }
   }

   // $VF: renamed from: ac () void
   private static void method_362() {
      String[] var0 = new String[field_843];

      for (int var1 = 0; var1 < field_843; var1++) {
         var0[var1] = method_361(var1);
      }

      field_847 = var0;
      field_846 = null;
      field_845 = null;
      System.gc();
   }

   // $VF: renamed from: ad () void
   private static void method_363() {
      if (field_847 != null) {
         for (int var0 = 0; var0 < field_843; var0++) {
            field_847[var0] = null;
         }

         field_847 = null;
      }

      field_846 = null;
      field_845 = null;
      field_843 = 0;
   }

   // $VF: renamed from: a (java.lang.String, java.lang.String[]) java.lang.String
   private static String method_364(String var0, String[] var1) {
      String var5 = "";
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
   private static void method_365() {
      if (field_848 != null) {
         try {
            field_848.closeRecordStore();
         } catch (RecordStoreException var0) {
         }

         field_848 = null;
      }
   }

   // $VF: renamed from: b (java.lang.String) void
   private static void method_366(String var0) {
      field_848 = RecordStore.openRecordStore(var0, true);
   }

   // $VF: renamed from: a (java.lang.String) byte[]
   private static byte[] method_367(String var0) {
      byte[] var1 = null;

      try {
         method_366(var0);
         if (field_848.getNumRecords() > 0) {
            var1 = field_848.getRecord(1);
         }
      } catch (RecordStoreException var2) {
         new StringBuffer().append("ERROR! Failed reading from RMS: ").append(var2);
         var1 = null;
      }

      method_365();
      return var1;
   }

   // $VF: renamed from: a (java.lang.String, byte[], int, int) void
   private static void method_368(String var0, byte[] var1, int var2, int var3) {
      try {
         method_366(var0);
         if (field_848.getNumRecords() > 0) {
            field_848.setRecord(1, var1, 0, var3);
         } else {
            field_848.addRecord(var1, 0, var3);
         }
      } catch (RecordStoreException var4) {
      }

      method_365();
   }

   // $VF: renamed from: i (int) void
   public static void method_369(int var0) {
      if (var0 != field_849 || field_850 == null) {
         field_849 = var0;
         if (field_850 == null) {
            field_850 = new int[256];
         }

         for (int var1 = 256; var1 > 0; field_850[var1] = var0) {
            var1--;
         }
      }
   }

   // $VF: renamed from: d (javax.microedition.lcdui.Graphics, int, int, int, int) void
   public static void method_370(Graphics var0, int var1, int var2, int var3, int var4) {
      int var5 = var0.getClipX();
      int var6 = var0.getClipY();
      int var7 = var0.getClipWidth();
      int var8 = var0.getClipHeight();
      int var9 = var1 > var5 ? var1 : var5;
      int var10 = var2 > var6 ? var2 : var6;
      int var17 = (var1 + var3 < var5 + var7 ? var1 + var3 : var5 + var7) - var9;
      int var19 = (var2 + var4 < var6 + var8 ? var2 + var4 : var6 + var8) - var10;
      if (var17 > 0 && var19 > 0) {
         method_349(var0, var9, var10, var17, var19);
         if (var17 * var19 < 256) {
            int[] var15 = field_850;
            method_352(var0, var15, 0, var17, var9, var10, var17, var19, true, true, 0);
         } else {
            var3 = var17 + var9;
            var4 = var19 + var10;

            for (int var14 = var9; var14 < var3; var14 += 16) {
               for (int var16 = var10; var16 < var4; var16 += 16) {
                  int[] var11 = field_850;
                  method_352(var0, var11, 0, 16, var14, var16, 16, 16, true, true, 0);
               }
            }
         }

         method_349(var0, var5, var6, var7, var8);
      }
   }
}
