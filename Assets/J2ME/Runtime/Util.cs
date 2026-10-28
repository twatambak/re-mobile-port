// java.util emulation. Random reproduces Java's exact LCG so seeded sequences match the original.
using System.Collections.Generic;

namespace J2ME
{
    public class Random
    {
        const long Multiplier = 0x5DEECE66DL;
        const long Addend = 0xBL;
        const long Mask = (1L << 48) - 1;
        long seed;

        public Random() : this(JSystem.currentTimeMillis()) { }
        public Random(long seed) { setSeed(seed); }

        public void setSeed(long s) { seed = (s ^ Multiplier) & Mask; }

        protected int next(int bits)
        {
            seed = (seed * Multiplier + Addend) & Mask;
            return (int)((ulong)seed >> (48 - bits));
        }

        public int nextInt() { return next(32); }

        public int nextInt(int n)
        {
            if (n <= 0) throw new System.ArgumentException("n must be positive");
            if ((n & -n) == n) return (int)((n * (long)next(31)) >> 31);
            int bits, val;
            do
            {
                bits = next(31);
                val = bits % n;
            } while (bits - val + (n - 1) < 0);
            return val;
        }

        public long nextLong() { return ((long)next(32) << 32) + next(32); }
        public bool nextBoolean() { return next(1) != 0; }
        public float nextFloat() { return next(24) / (float)(1 << 24); }
        public double nextDouble() { return (((long)next(26) << 27) + next(27)) / (double)(1L << 53); }
    }

    public interface Enumeration
    {
        bool hasMoreElements();
        object nextElement();
    }

    sealed class ListEnumeration : Enumeration
    {
        readonly List<object> items;
        int index;
        public ListEnumeration(List<object> items) { this.items = items; }
        public bool hasMoreElements() { return index < items.Count; }
        public object nextElement() { return items[index++]; }
    }

    public class Vector
    {
        protected readonly List<object> items;

        public Vector() { items = new List<object>(); }
        public Vector(int capacity) { items = new List<object>(System.Math.Max(capacity, 0)); }
        public Vector(int capacity, int increment) : this(capacity) { }

        public void addElement(object o) { items.Add(o); }
        public void insertElementAt(object o, int i) { items.Insert(i, o); }
        public void setElementAt(object o, int i) { items[i] = o; }
        public object elementAt(int i) { return items[i]; }
        public object firstElement() { return items[0]; }
        public object lastElement() { return items[items.Count - 1]; }
        public void removeElementAt(int i) { items.RemoveAt(i); }
        public bool removeElement(object o) { int i = indexOf(o); if (i < 0) return false; items.RemoveAt(i); return true; }
        public void removeAllElements() { items.Clear(); }
        public int size() { return items.Count; }
        public bool isEmpty() { return items.Count == 0; }
        public bool contains(object o) { return indexOf(o) >= 0; }
        public int capacity() { return items.Capacity; }
        public void setSize(int n) { while (items.Count > n) items.RemoveAt(items.Count - 1); while (items.Count < n) items.Add(null); }
        public void trimToSize() { items.TrimExcess(); }
        public void ensureCapacity(int n) { if (items.Capacity < n) items.Capacity = n; }

        public int indexOf(object o)
        {
            for (int i = 0; i < items.Count; i++)
                if (o == null ? items[i] == null : o.Equals(items[i])) return i;
            return -1;
        }

        public void copyInto(object[] arr) { items.CopyTo(arr); }
        public Enumeration elements() { return new ListEnumeration(new List<object>(items)); }
    }

    public class Stack : Vector
    {
        public object push(object o) { items.Add(o); return o; }
        public object pop() { var o = items[items.Count - 1]; items.RemoveAt(items.Count - 1); return o; }
        public object peek() { return items[items.Count - 1]; }
        public bool empty() { return items.Count == 0; }
    }

    public class Hashtable
    {
        readonly Dictionary<object, object> map;

        public Hashtable() { map = new Dictionary<object, object>(); }
        public Hashtable(int capacity) { map = new Dictionary<object, object>(System.Math.Max(capacity, 0)); }

        public object put(object key, object value)
        {
            map.TryGetValue(key, out var old);
            map[key] = value;
            return old;
        }

        public object get(object key) { return map.TryGetValue(key, out var v) ? v : null; }

        public object remove(object key)
        {
            if (!map.TryGetValue(key, out var v)) return null;
            map.Remove(key);
            return v;
        }

        public bool containsKey(object key) { return map.ContainsKey(key); }
        public bool contains(object value) { return map.ContainsValue(value); }
        public int size() { return map.Count; }
        public bool isEmpty() { return map.Count == 0; }
        public void clear() { map.Clear(); }
        public Enumeration keys() { return new ListEnumeration(new List<object>(map.Keys)); }
        public Enumeration elements() { return new ListEnumeration(new List<object>(map.Values)); }
    }
}
