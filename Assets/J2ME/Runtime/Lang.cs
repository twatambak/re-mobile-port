// java.lang emulation for transpiled J2ME code.
// Type and member names intentionally mirror the Java API so converted code reads like the original.
using System.Text;

namespace J2ME
{
    public interface Runnable
    {
        void run();
    }

    public static class JSystem
    {
        static readonly long Epoch = System.DateTime.UtcNow.Ticks / System.TimeSpan.TicksPerMillisecond
                                     - System.Diagnostics.Stopwatch.GetTimestamp() * 1000 / System.Diagnostics.Stopwatch.Frequency;

        public static readonly PrintStream @out = new PrintStream(false);
        public static readonly PrintStream err = new PrintStream(true);

        public static long currentTimeMillis()
        {
            // Monotonic wall clock: Java games compute frame deltas from this, so it must never jump backwards.
            return Epoch + System.Diagnostics.Stopwatch.GetTimestamp() * 1000 / System.Diagnostics.Stopwatch.Frequency;
        }

        public static void arraycopy(object src, int srcPos, object dest, int destPos, int length)
        {
            System.Array.Copy((System.Array)src, srcPos, (System.Array)dest, destPos, length);
        }

        public static void gc() { }

        public static void exit(int code) { Midp.RequestExit(); }

        public static string getProperty(string key)
        {
            switch (key)
            {
                case "microedition.platform": return "J2ME-Unity";
                case "microedition.configuration": return "CLDC-1.1";
                case "microedition.profiles": return "MIDP-2.0";
                case "microedition.locale": return Midp.Locale;
                case "microedition.encoding": return "ISO-8859-1";
                default: return null;
            }
        }

        public static int identityHashCode(object o) { return System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(o); }
    }

    public sealed class PrintStream
    {
        readonly bool isErr;
        public PrintStream(bool isErr) { this.isErr = isErr; }
        public void println() { Midp.Log(""); }
        public void println(object o) { if (Midp.Verbose || isErr) Midp.Log(JString.valueOf(o)); }
        public void print(object o) { if (Midp.Verbose || isErr) Midp.Log(JString.valueOf(o)); }
    }

    public static class JMath
    {
        public static int abs(int a) { return a < 0 ? -a : a; }
        public static long abs(long a) { return a < 0 ? -a : a; }
        public static float abs(float a) { return a < 0 ? -a : a; }
        public static double abs(double a) { return a < 0 ? -a : a; }
        public static int max(int a, int b) { return a >= b ? a : b; }
        public static long max(long a, long b) { return a >= b ? a : b; }
        public static float max(float a, float b) { return System.Math.Max(a, b); }
        public static double max(double a, double b) { return System.Math.Max(a, b); }
        public static int min(int a, int b) { return a <= b ? a : b; }
        public static long min(long a, long b) { return a <= b ? a : b; }
        public static float min(float a, float b) { return System.Math.Min(a, b); }
        public static double min(double a, double b) { return System.Math.Min(a, b); }
        public static double sqrt(double a) { return System.Math.Sqrt(a); }
        public static double sin(double a) { return System.Math.Sin(a); }
        public static double cos(double a) { return System.Math.Cos(a); }
        public static double tan(double a) { return System.Math.Tan(a); }
        public static double floor(double a) { return System.Math.Floor(a); }
        public static double ceil(double a) { return System.Math.Ceiling(a); }
        public static double toRadians(double a) { return a * System.Math.PI / 180.0; }
        public static double toDegrees(double a) { return a * 180.0 / System.Math.PI; }
        public const double PI = System.Math.PI;
        public const double E = System.Math.E;
    }

    public sealed class Integer
    {
        public const int MAX_VALUE = int.MaxValue;
        public const int MIN_VALUE = int.MinValue;
        readonly int value;

        public Integer(int value) { this.value = value; }

        public int intValue() { return value; }
        public sbyte byteValue() { return (sbyte)value; }
        public short shortValue() { return (short)value; }
        public long longValue() { return value; }
        public int hashCode() { return value; }

        public override bool Equals(object obj) { return obj is Integer i && i.value == value; }
        public override int GetHashCode() { return value; }
        public override string ToString() { return value.ToString(System.Globalization.CultureInfo.InvariantCulture); }

        public static Integer valueOf(int i) { return new Integer(i); }
        public static Integer valueOf(string s) { return new Integer(parseInt(s)); }
        public static Integer valueOf(string s, int radix) { return new Integer(parseInt(s, radix)); }

        public static int parseInt(string s) { return parseInt(s, 10); }

        public static int parseInt(string s, int radix)
        {
            if (s == null || s.Length == 0) throw new System.FormatException("null");
            long result = 0;
            int i = 0;
            bool neg = false;
            if (s[0] == '-') { neg = true; i = 1; }
            else if (s[0] == '+') { i = 1; }
            if (i >= s.Length) throw new System.FormatException(s);
            for (; i < s.Length; i++)
            {
                int d = Character.digit(s[i], radix);
                if (d < 0) throw new System.FormatException(s);
                result = result * radix + d;
                if (result > 2147483648L) throw new System.FormatException(s);
            }
            if (neg) result = -result;
            if (result > int.MaxValue || result < int.MinValue) throw new System.FormatException(s);
            return (int)result;
        }

        public static string toString(int i) { return i.ToString(System.Globalization.CultureInfo.InvariantCulture); }

        public static string toString(int i, int radix)
        {
            if (radix == 10) return toString(i);
            if (i == 0) return "0";
            bool neg = i < 0;
            long v = System.Math.Abs((long)i);
            var sb = new StringBuilder();
            while (v > 0) { sb.Insert(0, Character.forDigit((int)(v % radix), radix)); v /= radix; }
            if (neg) sb.Insert(0, '-');
            return sb.ToString();
        }

        public static string toHexString(int i) { return System.Convert.ToString(i, 16); }
        public static string toBinaryString(int i) { return System.Convert.ToString(i, 2); }
        public static string toOctalString(int i) { return System.Convert.ToString(i, 8); }
    }

    public static class Long
    {
        public const long MAX_VALUE = long.MaxValue;
        public const long MIN_VALUE = long.MinValue;
        public static long parseLong(string s) { return long.Parse(s.Trim(), System.Globalization.CultureInfo.InvariantCulture); }
        public static string toString(long l) { return l.ToString(System.Globalization.CultureInfo.InvariantCulture); }
    }

    public static class Short
    {
        public const short MAX_VALUE = short.MaxValue;
        public const short MIN_VALUE = short.MinValue;
        public static short parseShort(string s) { return (short)Integer.parseInt(s); }
    }

    public static class Byte
    {
        public const sbyte MAX_VALUE = sbyte.MaxValue;
        public const sbyte MIN_VALUE = sbyte.MinValue;
        public static sbyte parseByte(string s) { return (sbyte)Integer.parseInt(s); }
    }

    public static class Character
    {
        public const char MAX_VALUE = char.MaxValue;
        public const char MIN_VALUE = char.MinValue;
        public static bool isDigit(char c) { return c >= '0' && c <= '9'; }
        public static bool isLetter(char c) { return char.IsLetter(c); }
        public static bool isUpperCase(char c) { return char.IsUpper(c); }
        public static bool isLowerCase(char c) { return char.IsLower(c); }
        public static bool isSpace(char c) { return c == ' ' || c == '\t' || c == '\n' || c == '\r' || c == '\f'; }
        public static char toUpperCase(char c) { return char.ToUpperInvariant(c); }
        public static char toLowerCase(char c) { return char.ToLowerInvariant(c); }

        public static int digit(char c, int radix)
        {
            int d;
            if (c >= '0' && c <= '9') d = c - '0';
            else if (c >= 'a' && c <= 'z') d = c - 'a' + 10;
            else if (c >= 'A' && c <= 'Z') d = c - 'A' + 10;
            else return -1;
            return d < radix ? d : -1;
        }

        public static char forDigit(int digit, int radix)
        {
            if (digit < 0 || digit >= radix) return '\0';
            return digit < 10 ? (char)('0' + digit) : (char)('a' + digit - 10);
        }
    }

    public static class JBoolean
    {
        public static string toString(bool b) { return b ? "true" : "false"; }
    }

    public sealed class StringBuffer
    {
        readonly StringBuilder sb;

        public StringBuffer() { sb = new StringBuilder(16); }
        public StringBuffer(int capacity) { sb = new StringBuilder(System.Math.Max(capacity, 1)); }
        public StringBuffer(string s) { sb = new StringBuilder(s ?? "null"); }

        public StringBuffer append(string s) { sb.Append(s ?? "null"); return this; }
        public StringBuffer append(object o) { sb.Append(JString.valueOf(o)); return this; }
        public StringBuffer append(char c) { sb.Append(c); return this; }
        public StringBuffer append(char[] c) { sb.Append(c); return this; }
        public StringBuffer append(char[] c, int off, int len) { sb.Append(c, off, len); return this; }
        public StringBuffer append(int i) { sb.Append(Integer.toString(i)); return this; }
        public StringBuffer append(long l) { sb.Append(Long.toString(l)); return this; }
        public StringBuffer append(bool b) { sb.Append(b ? "true" : "false"); return this; }
        public StringBuffer append(float f) { sb.Append(JString.valueOf(f)); return this; }
        public StringBuffer append(double d) { sb.Append(JString.valueOf(d)); return this; }

        public StringBuffer insert(int offset, string s) { sb.Insert(offset, s ?? "null"); return this; }
        public StringBuffer insert(int offset, char c) { sb.Insert(offset, c); return this; }
        public StringBuffer insert(int offset, int i) { sb.Insert(offset, Integer.toString(i)); return this; }
        public StringBuffer insert(int offset, object o) { sb.Insert(offset, JString.valueOf(o)); return this; }

        public StringBuffer delete(int start, int end)
        {
            if (end > sb.Length) end = sb.Length;
            sb.Remove(start, end - start);
            return this;
        }

        public StringBuffer deleteCharAt(int index) { sb.Remove(index, 1); return this; }
        public StringBuffer reverse() { var a = sb.ToString().ToCharArray(); System.Array.Reverse(a); sb.Clear().Append(a); return this; }
        public int length() { return sb.Length; }
        public int capacity() { return sb.Capacity; }
        public void ensureCapacity(int c) { sb.EnsureCapacity(c); }
        public char charAt(int i) { return sb[i]; }
        public void setCharAt(int i, char c) { sb[i] = c; }

        public void setLength(int len)
        {
            if (len < sb.Length) sb.Length = len;
            else sb.Append('\0', len - sb.Length);
        }

        public void getChars(int srcBegin, int srcEnd, char[] dst, int dstBegin) { sb.CopyTo(srcBegin, dst, dstBegin, srcEnd - srcBegin); }
        public string toString() { return sb.ToString(); }
        public override string ToString() { return sb.ToString(); }
    }

    /// <summary>Static members of java.lang.String plus constructors (new String(...) becomes JString.New(...)).</summary>
    public static class JString
    {
        public static string valueOf(object o)
        {
            if (o == null) return "null";
            if (o is bool b) return b ? "true" : "false";
            if (o is float f) return valueOf(f);
            if (o is double d) return valueOf(d);
            if (o is System.IFormattable fm) return fm.ToString(null, System.Globalization.CultureInfo.InvariantCulture);
            return o.ToString();
        }

        public static string valueOf(int i) { return Integer.toString(i); }
        public static string valueOf(long l) { return Long.toString(l); }
        public static string valueOf(char c) { return c.ToString(); }
        public static string valueOf(bool b) { return b ? "true" : "false"; }
        public static string valueOf(char[] c) { return new string(c); }
        public static string valueOf(char[] c, int off, int len) { return new string(c, off, len); }

        public static string valueOf(float f)
        {
            string s = f.ToString("R", System.Globalization.CultureInfo.InvariantCulture);
            return s.Contains(".") || s.Contains("E") ? s : s + ".0";
        }

        public static string valueOf(double d)
        {
            string s = d.ToString("R", System.Globalization.CultureInfo.InvariantCulture);
            return s.Contains(".") || s.Contains("E") ? s : s + ".0";
        }

        public static string New() { return ""; }
        public static string New(string s) { return s; }
        public static string New(char[] c) { return new string(c); }
        public static string New(char[] c, int off, int len) { return new string(c, off, len); }
        public static string New(StringBuffer sb) { return sb.toString(); }
        public static string New(sbyte[] b) { return New(b, 0, b.Length); }

        public static string New(sbyte[] b, int off, int len)
        {
            // Phone default encoding is effectively ISO-8859-1 for these games' data.
            var c = new char[len];
            for (int i = 0; i < len; i++) c[i] = (char)(b[off + i] & 0xFF);
            return new string(c);
        }

        public static string New(sbyte[] b, string enc) { return New(b, 0, b.Length, enc); }

        public static string New(sbyte[] b, int off, int len, string enc)
        {
            if (enc != null && enc.Replace("-", "").ToUpperInvariant() == "UTF8")
                return Encoding.UTF8.GetString(ByteConv.ToUnsigned(b, off, len));
            return New(b, off, len);
        }
    }

    /// <summary>java.lang.String instance methods as extension methods.</summary>
    public static class StringExt
    {
        public static int length(this string s) { return s.Length; }
        public static char charAt(this string s, int i) { return s[i]; }
        public static string substring(this string s, int begin) { return s.Substring(begin); }
        public static string substring(this string s, int begin, int end) { return s.Substring(begin, end - begin); }
        public static int indexOf(this string s, int ch) { return s.IndexOf((char)ch); }
        public static int indexOf(this string s, int ch, int from) { return from >= s.Length ? -1 : s.IndexOf((char)ch, System.Math.Max(0, from)); }
        public static int indexOf(this string s, string str) { return s.IndexOf(str, System.StringComparison.Ordinal); }
        public static int indexOf(this string s, string str, int from) { return from > s.Length ? -1 : s.IndexOf(str, System.Math.Max(0, from), System.StringComparison.Ordinal); }
        public static int lastIndexOf(this string s, int ch) { return s.LastIndexOf((char)ch); }
        public static int lastIndexOf(this string s, string str) { return s.LastIndexOf(str, System.StringComparison.Ordinal); }
        public static bool equalsIgnoreCase(this string s, string o) { return o != null && string.Equals(s, o, System.StringComparison.OrdinalIgnoreCase); }
        public static string toUpperCase(this string s) { return s.ToUpperInvariant(); }
        public static string toLowerCase(this string s) { return s.ToLowerInvariant(); }
        public static bool startsWith(this string s, string p) { return s.StartsWith(p, System.StringComparison.Ordinal); }
        public static bool startsWith(this string s, string p, int off) { return off >= 0 && off <= s.Length && s.Substring(off).StartsWith(p, System.StringComparison.Ordinal); }
        public static bool endsWith(this string s, string p) { return s.EndsWith(p, System.StringComparison.Ordinal); }
        public static string replace(this string s, char a, char b) { return s.Replace(a, b); }
        public static string concat(this string s, string o) { return s + o; }
        public static string intern(this string s) { return string.Intern(s); }
        public static char[] toCharArray(this string s) { return s.ToCharArray(); }
        public static void getChars(this string s, int srcBegin, int srcEnd, char[] dst, int dstBegin) { s.CopyTo(srcBegin, dst, dstBegin, srcEnd - srcBegin); }

        public static int compareTo(this string s, string o)
        {
            int n = System.Math.Min(s.Length, o.Length);
            for (int i = 0; i < n; i++)
                if (s[i] != o[i]) return s[i] - o[i];
            return s.Length - o.Length;
        }

        public static string trim(this string s)
        {
            int st = 0, len = s.Length;
            while (st < len && s[st] <= ' ') st++;
            while (st < len && s[len - 1] <= ' ') len--;
            return st > 0 || len < s.Length ? s.Substring(st, len - st) : s;
        }

        public static sbyte[] getBytes(this string s)
        {
            var b = new sbyte[s.Length];
            for (int i = 0; i < s.Length; i++) b[i] = (sbyte)s[i];
            return b;
        }

        public static sbyte[] getBytes(this string s, string enc)
        {
            if (enc != null && enc.Replace("-", "").ToUpperInvariant() == "UTF8")
                return ByteConv.ToSigned(Encoding.UTF8.GetBytes(s));
            return getBytes(s);
        }

        public static int hashCode(this string s)
        {
            int h = 0;
            for (int i = 0; i < s.Length; i++) h = 31 * h + s[i];
            return h;
        }
    }

    /// <summary>java.lang.Object methods available on every reference.</summary>
    public static class ObjectExt
    {
        public static bool equals(this object a, object b) { return a.Equals(b); }
        public static string toString(this object a) { return JString.valueOf(a); }
        public static int hashCode(this object a) { return a is string s ? s.hashCode() : a.GetHashCode(); }
        public static JClass getClass(this object a) { return new JClass(a.GetType()); }
        public static void notify(this object a) { System.Threading.Monitor.Pulse(a); }
        public static void notifyAll(this object a) { System.Threading.Monitor.PulseAll(a); }
        public static void wait(this object a) { System.Threading.Monitor.Wait(a); }
        public static void wait(this object a, long ms) { System.Threading.Monitor.Wait(a, (int)System.Math.Min(int.MaxValue, System.Math.Max(0, ms))); }
    }

    public static class ExceptionExt
    {
        public static void printStackTrace(this System.Exception e) { Midp.Log(e.ToString()); }
        public static string getMessage(this System.Exception e) { return e.Message; }
    }

    public sealed class JClass
    {
        readonly System.Type type;
        public JClass(System.Type type) { this.type = type; }
        public string getName() { return type.Name; }
        public InputStream getResourceAsStream(string name) { return Midp.OpenResource(name); }
    }

    public class Thread : Runnable
    {
        [System.ThreadStatic] static Thread current;
        readonly Runnable target;
        System.Threading.Thread thread;
        public const int MIN_PRIORITY = 1, NORM_PRIORITY = 5, MAX_PRIORITY = 10;

        public Thread() { }
        public Thread(Runnable target) { this.target = target; }

        public virtual void run() { target?.run(); }

        public void start()
        {
            thread = new System.Threading.Thread(() =>
            {
                current = this;
                try { run(); }
                catch (MidpTerminated) { }
                catch (System.Exception e) { Midp.Log("Uncaught exception in thread: " + e); }
            });
            thread.IsBackground = true;
            thread.Name = "J2ME Thread";
            thread.Start();
        }

        public bool isAlive() { return thread != null && thread.IsAlive; }
        public void join() { thread?.Join(); }
        public void setPriority(int p) { }
        public int getPriority() { return NORM_PRIORITY; }
        public void interrupt() { }

        public static Thread currentThread() { return current ??= new Thread(); }

        public static void sleep(long ms)
        {
            Midp.CheckAlive();
            if (ms > 0) Midp.Sleep(ms);
            Midp.CheckAlive();
        }

        public static void yield()
        {
            Midp.CheckAlive();
            System.Threading.Thread.Sleep(0);
        }

        public static int activeCount() { return 1; }
    }

    public sealed class Runtime
    {
        static readonly Runtime instance = new Runtime();
        public static Runtime getRuntime() { return instance; }
        public long freeMemory() { return 16L * 1024 * 1024; }
        public long totalMemory() { return 32L * 1024 * 1024; }
        public void gc() { }
        public void exit(int code) { Midp.RequestExit(); }
    }

    /// <summary>Thrown inside game threads when the host shuts the MIDlet down.</summary>
    public sealed class MidpTerminated : System.Exception
    {
        public MidpTerminated() : base("MIDlet terminated") { }
    }

    public class InterruptedException : System.Exception { }
    public class IllegalMonitorStateException : System.Exception { }

    /// <summary>Allocation helpers for Java multi-dimensional array creation (new int[a][b] etc).</summary>
    public static class JArr
    {
        public static T[][] New2<T>(int a, int b)
        {
            var r = new T[a][];
            for (int i = 0; i < a; i++) r[i] = new T[b];
            return r;
        }

        public static T[][][] New3<T>(int a, int b, int c)
        {
            var r = new T[a][][];
            for (int i = 0; i < a; i++) r[i] = New2<T>(b, c);
            return r;
        }

        public static T[][][][] New4<T>(int a, int b, int c, int d)
        {
            var r = new T[a][][][];
            for (int i = 0; i < a; i++) r[i] = New3<T>(b, c, d);
            return r;
        }
    }
}

namespace J2ME
{
    /// <summary>Java operators without a direct C# equivalent.</summary>
    public static class JOps
    {
        /// <summary>Java '&gt;&gt;&gt;' on int.</summary>
        public static int Ushr(int a, int n) { return (int)((uint)a >> n); }

        /// <summary>Java '&gt;&gt;&gt;' on long.</summary>
        public static long Ushr(long a, int n) { return (long)((ulong)a >> n); }
    }
}

namespace J2ME
{
    /// <summary>
    /// Copies between Java's signed bytes and .NET byte buffers. Reinterpreting one array type as the other
    /// ((sbyte[])(object)bytes) works on CoreCLR but not on Unity's Mono, so a real copy is always made.
    /// </summary>
    public static class ByteConv
    {
        public static sbyte[] ToSigned(byte[] b)
        {
            if (b == null) return null;
            var r = new sbyte[b.Length];
            System.Buffer.BlockCopy(b, 0, r, 0, b.Length);
            return r;
        }

        public static byte[] ToUnsigned(sbyte[] b) { return b == null ? null : ToUnsigned(b, 0, b.Length); }

        public static byte[] ToUnsigned(sbyte[] b, int offset, int length)
        {
            var r = new byte[length];
            System.Buffer.BlockCopy(b, offset, r, 0, length);
            return r;
        }
    }
}
