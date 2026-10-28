// javax.microedition.rms.RecordStore persisted as one small binary file per store.
using System.Collections.Generic;
using System.IO;

namespace J2ME
{
    public class RecordStoreException : System.Exception
    {
        public RecordStoreException() { }
        public RecordStoreException(string msg) : base(msg) { }
    }

    public class RecordStoreNotFoundException : RecordStoreException
    {
        public RecordStoreNotFoundException(string msg) : base(msg) { }
    }

    public class RecordStoreNotOpenException : RecordStoreException { }
    public class InvalidRecordIDException : RecordStoreException { }
    public class RecordStoreFullException : RecordStoreException { }

    public interface RecordFilter { bool matches(sbyte[] candidate); }
    public interface RecordComparator { int compare(sbyte[] a, sbyte[] b); }

    public interface RecordEnumeration
    {
        int numRecords();
        sbyte[] nextRecord();
        int nextRecordId();
        sbyte[] previousRecord();
        int previousRecordId();
        bool hasNextElement();
        bool hasPreviousElement();
        void reset();
        void rebuild();
        void keepUpdated(bool keep);
        bool isKeptUpdated();
        void destroy();
    }

    public class RecordStore
    {
        static readonly Dictionary<string, RecordStore> open = new Dictionary<string, RecordStore>();
        static readonly Dictionary<string, RecordStore> memoryOnly = new Dictionary<string, RecordStore>();
        static readonly object sync = new object();

        readonly string name;
        readonly SortedDictionary<int, sbyte[]> records = new SortedDictionary<int, sbyte[]>();
        int nextId = 1;
        int openCount;
        int version;

        RecordStore(string name) { this.name = name; }

        static string PathFor(string name)
        {
            if (Midp.StorageDirectory == null) return null;
            var safe = new System.Text.StringBuilder();
            foreach (char c in name) safe.Append(char.IsLetterOrDigit(c) || c == '_' || c == '-' ? c : '_');
            return Path.Combine(Midp.StorageDirectory, safe + ".rms");
        }

        public static RecordStore openRecordStore(string name, bool createIfNecessary)
        {
            lock (sync)
            {
                if (open.TryGetValue(name, out var rs)) { rs.openCount++; return rs; }
                rs = Load(name);
                if (rs == null)
                {
                    if (!createIfNecessary) throw new RecordStoreNotFoundException(name);
                    rs = new RecordStore(name);
                    rs.Save();
                }
                rs.openCount = 1;
                open[name] = rs;
                return rs;
            }
        }

        public static RecordStore openRecordStore(string name, bool createIfNecessary, int authmode, bool writable)
        {
            return openRecordStore(name, createIfNecessary);
        }

        public static void deleteRecordStore(string name)
        {
            lock (sync)
            {
                if (open.ContainsKey(name)) throw new RecordStoreException("Record store is open: " + name);
                var path = PathFor(name);
                bool existed = memoryOnly.Remove(name);
                if (path != null && File.Exists(path)) { File.Delete(path); existed = true; }
                if (!existed) throw new RecordStoreNotFoundException(name);
            }
        }

        public static string[] listRecordStores()
        {
            lock (sync)
            {
                var names = new List<string>(memoryOnly.Keys);
                if (Midp.StorageDirectory != null && Directory.Exists(Midp.StorageDirectory))
                    foreach (var f in Directory.GetFiles(Midp.StorageDirectory, "*.rms"))
                    {
                        var stored = ReadName(f);
                        if (stored != null && !names.Contains(stored)) names.Add(stored);
                    }
                return names.Count == 0 ? null : names.ToArray();
            }
        }

        static string ReadName(string file)
        {
            try
            {
                using (var r = new BinaryReader(File.OpenRead(file))) return r.ReadString();
            }
            catch (System.Exception) { return null; }
        }

        static RecordStore Load(string name)
        {
            if (memoryOnly.TryGetValue(name, out var mem)) return mem;
            var path = PathFor(name);
            if (path == null || !File.Exists(path)) return null;
            try
            {
                using (var r = new BinaryReader(File.OpenRead(path)))
                {
                    var rs = new RecordStore(r.ReadString());
                    rs.nextId = r.ReadInt32();
                    int count = r.ReadInt32();
                    for (int i = 0; i < count; i++)
                    {
                        int id = r.ReadInt32();
                        int len = r.ReadInt32();
                        rs.records[id] = ByteConv.ToSigned(r.ReadBytes(len));
                    }
                    return rs;
                }
            }
            catch (System.Exception e)
            {
                Midp.Log("RecordStore load failed (" + name + "): " + e.Message);
                return null;
            }
        }

        void Save()
        {
            version++;
            var path = PathFor(name);
            if (path == null) { memoryOnly[name] = this; return; }
            Directory.CreateDirectory(Path.GetDirectoryName(path));
            var tmp = path + ".tmp";
            using (var w = new BinaryWriter(File.Create(tmp)))
            {
                w.Write(name);
                w.Write(nextId);
                w.Write(records.Count);
                foreach (var kv in records)
                {
                    w.Write(kv.Key);
                    w.Write(kv.Value.Length);
                    w.Write(ByteConv.ToUnsigned(kv.Value));
                }
            }
            if (File.Exists(path)) File.Delete(path);
            File.Move(tmp, path);
        }

        void CheckOpen()
        {
            if (openCount <= 0) throw new RecordStoreNotOpenException();
        }

        public void closeRecordStore()
        {
            lock (sync)
            {
                CheckOpen();
                if (--openCount == 0) open.Remove(name);
            }
        }

        public string getName() { return name; }
        public int getVersion() { return version; }
        public long getLastModified() { return 0; }
        public int getNumRecords() { lock (sync) { CheckOpen(); return records.Count; } }
        public int getNextRecordID() { lock (sync) { CheckOpen(); return nextId; } }
        public int getSizeAvailable() { return 1024 * 1024; }

        public int getSize()
        {
            lock (sync)
            {
                int s = 0;
                foreach (var r in records.Values) s += r.Length;
                return s;
            }
        }

        public int addRecord(sbyte[] data, int offset, int numBytes)
        {
            lock (sync)
            {
                CheckOpen();
                var copy = new sbyte[numBytes];
                if (numBytes > 0) System.Array.Copy(data, offset, copy, 0, numBytes);
                int id = nextId++;
                records[id] = copy;
                Save();
                return id;
            }
        }

        public void setRecord(int recordId, sbyte[] data, int offset, int numBytes)
        {
            lock (sync)
            {
                CheckOpen();
                if (!records.ContainsKey(recordId)) throw new InvalidRecordIDException();
                var copy = new sbyte[numBytes];
                if (numBytes > 0) System.Array.Copy(data, offset, copy, 0, numBytes);
                records[recordId] = copy;
                Save();
            }
        }

        public void deleteRecord(int recordId)
        {
            lock (sync)
            {
                CheckOpen();
                if (!records.Remove(recordId)) throw new InvalidRecordIDException();
                Save();
            }
        }

        public sbyte[] getRecord(int recordId)
        {
            lock (sync)
            {
                CheckOpen();
                if (!records.TryGetValue(recordId, out var r)) throw new InvalidRecordIDException();
                return r.Length == 0 ? null : (sbyte[])r.Clone();
            }
        }

        public int getRecord(int recordId, sbyte[] buffer, int offset)
        {
            lock (sync)
            {
                CheckOpen();
                if (!records.TryGetValue(recordId, out var r)) throw new InvalidRecordIDException();
                System.Array.Copy(r, 0, buffer, offset, r.Length);
                return r.Length;
            }
        }

        public int getRecordSize(int recordId)
        {
            lock (sync)
            {
                CheckOpen();
                if (!records.TryGetValue(recordId, out var r)) throw new InvalidRecordIDException();
                return r.Length;
            }
        }

        public RecordEnumeration enumerateRecords(RecordFilter filter, RecordComparator comparator, bool keepUpdated)
        {
            lock (sync)
            {
                CheckOpen();
                var ids = new List<int>();
                foreach (var kv in records)
                    if (filter == null || filter.matches(kv.Value)) ids.Add(kv.Key);
                if (comparator != null) ids.Sort((a, b) => comparator.compare(records[a], records[b]));
                return new Enumerator(this, ids);
            }
        }

        sealed class Enumerator : RecordEnumeration
        {
            readonly RecordStore store;
            readonly List<int> ids;
            int index;

            public Enumerator(RecordStore store, List<int> ids) { this.store = store; this.ids = ids; }
            public int numRecords() { return ids.Count; }
            public sbyte[] nextRecord() { return store.getRecord(nextRecordId()); }
            public int nextRecordId() { if (index >= ids.Count) throw new InvalidRecordIDException(); return ids[index++]; }
            public sbyte[] previousRecord() { return store.getRecord(previousRecordId()); }
            public int previousRecordId() { if (index <= 0) throw new InvalidRecordIDException(); return ids[--index]; }
            public bool hasNextElement() { return index < ids.Count; }
            public bool hasPreviousElement() { return index > 0; }
            public void reset() { index = 0; }
            public void rebuild() { }
            public void keepUpdated(bool keep) { }
            public bool isKeptUpdated() { return false; }
            public void destroy() { }
        }
    }
}
