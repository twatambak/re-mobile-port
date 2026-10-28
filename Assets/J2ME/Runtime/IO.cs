// java.io emulation. Java's byte is signed, so all byte buffers are sbyte[].
namespace J2ME
{
    public class IOException : System.Exception
    {
        public IOException() { }
        public IOException(string msg) : base(msg) { }
    }

    public class EOFException : IOException
    {
        public EOFException() { }
        public EOFException(string msg) : base(msg) { }
    }

    public class UTFDataFormatException : IOException { }

    public abstract class InputStream
    {
        public abstract int read();

        public virtual int read(sbyte[] b) { return read(b, 0, b.Length); }

        public virtual int read(sbyte[] b, int off, int len)
        {
            if (len == 0) return 0;
            int c = read();
            if (c < 0) return -1;
            b[off] = (sbyte)c;
            int i = 1;
            for (; i < len; i++)
            {
                c = read();
                if (c < 0) break;
                b[off + i] = (sbyte)c;
            }
            return i;
        }

        public virtual long skip(long n)
        {
            long i = 0;
            while (i < n && read() >= 0) i++;
            return i;
        }

        public virtual int available() { return 0; }
        public virtual void close() { }
        public virtual void mark(int limit) { }
        public virtual void reset() { throw new IOException("mark/reset not supported"); }
        public virtual bool markSupported() { return false; }
    }

    public class ByteArrayInputStream : InputStream
    {
        protected sbyte[] buf;
        protected int pos;
        protected int count;
        protected int markPos;

        public ByteArrayInputStream(sbyte[] buf) : this(buf, 0, buf.Length) { }

        public ByteArrayInputStream(sbyte[] buf, int offset, int length)
        {
            this.buf = buf;
            pos = offset;
            count = System.Math.Min(offset + length, buf.Length);
            markPos = offset;
        }

        /// <summary>Raw view used by the media layer to recover the bytes handed to Manager.createPlayer.</summary>
        internal sbyte[] Buffer => buf;
        internal int Position => pos;
        internal int Count => count;

        public override int read() { return pos < count ? buf[pos++] & 0xFF : -1; }

        public override int read(sbyte[] b, int off, int len)
        {
            if (pos >= count) return -1;
            if (len > count - pos) len = count - pos;
            if (len <= 0) return 0;
            System.Array.Copy(buf, pos, b, off, len);
            pos += len;
            return len;
        }

        public override long skip(long n)
        {
            if (n > count - pos) n = count - pos;
            if (n < 0) return 0;
            pos += (int)n;
            return n;
        }

        public override int available() { return count - pos; }
        public override bool markSupported() { return true; }
        public override void mark(int limit) { markPos = pos; }
        public override void reset() { pos = markPos; }
    }

    public class FilterInputStream : InputStream
    {
        protected InputStream @in;
        protected FilterInputStream(InputStream input) { @in = input; }
        public override int read() { return @in.read(); }
        public override int read(sbyte[] b, int off, int len) { return @in.read(b, off, len); }
        public override long skip(long n) { return @in.skip(n); }
        public override int available() { return @in.available(); }
        public override void close() { @in.close(); }
        public override void mark(int limit) { @in.mark(limit); }
        public override void reset() { @in.reset(); }
        public override bool markSupported() { return @in.markSupported(); }
    }

    public class DataInputStream : FilterInputStream
    {
        public DataInputStream(InputStream input) : base(input) { }

        int ReadOrThrow()
        {
            int c = @in.read();
            if (c < 0) throw new EOFException();
            return c;
        }

        public void readFully(sbyte[] b) { readFully(b, 0, b.Length); }

        public void readFully(sbyte[] b, int off, int len)
        {
            int n = 0;
            while (n < len)
            {
                int r = @in.read(b, off + n, len - n);
                if (r < 0) throw new EOFException();
                n += r;
            }
        }

        public int skipBytes(int n) { return (int)@in.skip(n); }
        public bool readBoolean() { return ReadOrThrow() != 0; }
        public sbyte readByte() { return (sbyte)ReadOrThrow(); }
        public int readUnsignedByte() { return ReadOrThrow(); }
        public short readShort() { int a = ReadOrThrow(), b = ReadOrThrow(); return (short)((a << 8) | b); }
        public int readUnsignedShort() { int a = ReadOrThrow(), b = ReadOrThrow(); return (a << 8) | b; }
        public char readChar() { return (char)readUnsignedShort(); }

        public int readInt()
        {
            int a = ReadOrThrow(), b = ReadOrThrow(), c = ReadOrThrow(), d = ReadOrThrow();
            return (a << 24) | (b << 16) | (c << 8) | d;
        }

        public long readLong() { return ((long)readInt() << 32) | (readInt() & 0xFFFFFFFFL); }

        public string readUTF()
        {
            int len = readUnsignedShort();
            var bytes = new sbyte[len];
            readFully(bytes);
            return ModifiedUtf8.Decode(bytes);
        }
    }

    public abstract class OutputStream
    {
        public abstract void write(int b);
        public virtual void write(sbyte[] b) { write(b, 0, b.Length); }
        public virtual void write(sbyte[] b, int off, int len) { for (int i = 0; i < len; i++) write(b[off + i]); }
        public virtual void flush() { }
        public virtual void close() { }
    }

    public class ByteArrayOutputStream : OutputStream
    {
        sbyte[] buf;
        int count;

        public ByteArrayOutputStream() : this(32) { }
        public ByteArrayOutputStream(int size) { buf = new sbyte[System.Math.Max(size, 1)]; }

        void Ensure(int n)
        {
            if (count + n <= buf.Length) return;
            System.Array.Resize(ref buf, System.Math.Max(buf.Length * 2, count + n));
        }

        public override void write(int b) { Ensure(1); buf[count++] = (sbyte)b; }

        public override void write(sbyte[] b, int off, int len)
        {
            Ensure(len);
            System.Array.Copy(b, off, buf, count, len);
            count += len;
        }

        public sbyte[] toByteArray() { var r = new sbyte[count]; System.Array.Copy(buf, r, count); return r; }
        public int size() { return count; }
        public void reset() { count = 0; }
        public override string ToString() { return JString.New(buf, 0, count); }
    }

    public class FilterOutputStream : OutputStream
    {
        protected OutputStream @out;
        public FilterOutputStream(OutputStream o) { @out = o; }
        public override void write(int b) { @out.write(b); }
        public override void flush() { @out.flush(); }
        public override void close() { @out.close(); }
    }

    public class DataOutputStream : FilterOutputStream
    {
        public DataOutputStream(OutputStream o) : base(o) { }
        public override void write(sbyte[] b, int off, int len) { @out.write(b, off, len); }
        public void writeBoolean(bool v) { @out.write(v ? 1 : 0); }
        public void writeByte(int v) { @out.write(v); }
        public void writeShort(int v) { @out.write(v >> 8); @out.write(v); }
        public void writeChar(int v) { @out.write(v >> 8); @out.write(v); }
        public void writeInt(int v) { @out.write(v >> 24); @out.write(v >> 16); @out.write(v >> 8); @out.write(v); }
        public void writeLong(long v) { writeInt((int)(v >> 32)); writeInt((int)v); }

        public void writeUTF(string s)
        {
            var b = ModifiedUtf8.Encode(s);
            writeShort(b.Length);
            write(b, 0, b.Length);
        }
    }

    static class ModifiedUtf8
    {
        public static string Decode(sbyte[] b)
        {
            var sb = new System.Text.StringBuilder(b.Length);
            int i = 0;
            while (i < b.Length)
            {
                int c = b[i] & 0xFF;
                if (c < 0x80) { sb.Append((char)c); i++; }
                else if ((c & 0xE0) == 0xC0 && i + 1 < b.Length) { sb.Append((char)(((c & 0x1F) << 6) | (b[i + 1] & 0x3F))); i += 2; }
                else if ((c & 0xF0) == 0xE0 && i + 2 < b.Length) { sb.Append((char)(((c & 0x0F) << 12) | ((b[i + 1] & 0x3F) << 6) | (b[i + 2] & 0x3F))); i += 3; }
                else { sb.Append((char)c); i++; }
            }
            return sb.ToString();
        }

        public static sbyte[] Encode(string s)
        {
            var o = new System.Collections.Generic.List<sbyte>(s.Length);
            foreach (char ch in s)
            {
                if (ch >= 1 && ch < 0x80) o.Add((sbyte)ch);
                else if (ch < 0x800) { o.Add((sbyte)(0xC0 | (ch >> 6))); o.Add((sbyte)(0x80 | (ch & 0x3F))); }
                else { o.Add((sbyte)(0xE0 | (ch >> 12))); o.Add((sbyte)(0x80 | ((ch >> 6) & 0x3F))); o.Add((sbyte)(0x80 | (ch & 0x3F))); }
            }
            return o.ToArray();
        }
    }
}
