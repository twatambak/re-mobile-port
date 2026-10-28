// javax.microedition.media (MMAPI subset). Decoding happens here; playback is delegated to Midp.Audio.
using System.Collections.Generic;

namespace J2ME
{
    public class MediaException : System.Exception
    {
        public MediaException() { }
        public MediaException(string msg) : base(msg) { }
    }

    public interface Control { }

    public interface VolumeControl : Control
    {
        int setLevel(int level);
        int getLevel();
        void setMute(bool mute);
        bool isMuted();
    }

    public interface PlayerListener
    {
        void playerUpdate(Player player, string evt, object eventData);
    }

    public abstract class Player
    {
        public const int UNREALIZED = 100, REALIZED = 200, PREFETCHED = 300, STARTED = 400, CLOSED = 0;
        public const long TIME_UNKNOWN = -1;

        public abstract void realize();
        public abstract void prefetch();
        public abstract void start();
        public abstract void stop();
        public abstract void deallocate();
        public abstract void close();
        public abstract int getState();
        public abstract void setLoopCount(int count);
        public abstract long setMediaTime(long now);
        public abstract long getMediaTime();
        public abstract long getDuration();
        public abstract string getContentType();
        public abstract Control getControl(string type);
        public abstract Control[] getControls();
        public abstract void addPlayerListener(PlayerListener l);
        public abstract void removePlayerListener(PlayerListener l);
    }

    public static class Manager
    {
        public const string TONE_DEVICE_LOCATOR = "device://tone";
        public const string MIDI_DEVICE_LOCATOR = "device://midi";

        public static Player createPlayer(InputStream stream, string type)
        {
            if (stream == null) throw new System.ArgumentException("stream is null");
            return new MidpPlayer(ReadAll(stream), type);
        }

        public static Player createPlayer(string locator)
        {
            return new MidpPlayer(null, locator);
        }

        public static string[] getSupportedContentTypes(string protocol) { return new[] { "audio/x-wav", "audio/midi" }; }
        public static string[] getSupportedProtocols(string contentType) { return new[] { "device" }; }
        public static void playTone(int note, int duration, int volume) { }

        static sbyte[] ReadAll(InputStream s)
        {
            if (s is ByteArrayInputStream bais)
            {
                // Games often re-create players from the same (already consumed) stream; real handsets coped,
                // so take the backing buffer without consuming it.
                int start = bais.Position < bais.Count ? bais.Position : 0;
                var copy = new sbyte[bais.Count - start];
                System.Array.Copy(bais.Buffer, start, copy, 0, copy.Length);
                return copy;
            }
            var o = new ByteArrayOutputStream(4096);
            var buf = new sbyte[4096];
            int n;
            while ((n = s.read(buf, 0, buf.Length)) > 0) o.write(buf, 0, n);
            return o.toByteArray();
        }
    }

    static class MediaManagerState
    {
        static readonly List<MidpPlayer> active = new List<MidpPlayer>();
        static readonly Dictionary<string, (int clip, long durationMs)> decoded = new Dictionary<string, (int, long)>();

        public static void Register(MidpPlayer p) { lock (active) if (!active.Contains(p)) active.Add(p); }
        public static void Unregister(MidpPlayer p) { lock (active) active.Remove(p); }

        /// <summary>Decodes once per distinct sound; returns the backend clip and duration.</summary>
        public static (int clip, long durationMs) GetClip(sbyte[] data, string type)
        {
            string key = Fingerprint(data);
            lock (decoded)
            {
                if (decoded.TryGetValue(key, out var hit)) return hit;
                (int, long) result = (-1, 1000);
                var bytes = ByteConv.ToUnsigned(data);
                if (Audio.AudioDecoder.TryDecode(bytes, type, 22050, out var samples, out int channels, out int rate) && samples.Length > 0)
                {
                    long ms = samples.Length / channels * 1000L / rate;
                    int clip = Midp.Audio != null ? Midp.Audio.CreateClip(samples, channels, rate) : -1;
                    result = (clip, System.Math.Max(ms, 1));
                }
                else
                {
                    Midp.Log("Unsupported audio (" + type + ", " + data.Length + " bytes)");
                }
                decoded[key] = result;
                return result;
            }
        }

        static string Fingerprint(sbyte[] d)
        {
            unchecked
            {
                long h = 1469598103934665603L;
                foreach (var b in d) h = (h ^ (byte)b) * 1099511628211L;
                return d.Length + ":" + h;
            }
        }

        public static void Pump()
        {
            MidpPlayer[] snapshot;
            lock (active) snapshot = active.ToArray();
            foreach (var p in snapshot) p.Poll();
        }

        public static void StopAll()
        {
            MidpPlayer[] snapshot;
            lock (active) snapshot = active.ToArray();
            foreach (var p in snapshot) p.StopSilently();
        }
    }

    sealed class MidpPlayer : Player, VolumeControl
    {
        readonly sbyte[] data;
        readonly string type;
        readonly List<PlayerListener> listeners = new List<PlayerListener>();
        int state = UNREALIZED;
        int loopCount = 1;
        int clip = -1;
        long durationMs = 1000;
        long startedAt;
        int level = 100;
        bool muted;

        public MidpPlayer(sbyte[] data, string type)
        {
            this.data = data;
            this.type = type;
        }

        float Volume => muted ? 0f : level / 100f;

        public override void realize()
        {
            if (state == CLOSED) throw new System.InvalidOperationException("Player closed");
            if (state >= REALIZED) return;
            if (data != null && data.Length > 0)
            {
                var r = MediaManagerState.GetClip(data, type);
                clip = r.clip;
                durationMs = r.durationMs;
            }
            state = REALIZED;
        }

        public override void prefetch()
        {
            if (state < REALIZED) realize();
            if (state < PREFETCHED) state = PREFETCHED;
        }

        public override void start()
        {
            if (state < PREFETCHED) prefetch();
            if (state == STARTED) return;
            state = STARTED;
            startedAt = JSystem.currentTimeMillis();
            MediaManagerState.Register(this);
            if (clip >= 0) Midp.Audio?.Play(clip, loopCount, Volume);
            Fire("started", 0L);
        }

        public override void stop()
        {
            if (state != STARTED) return;
            if (clip >= 0) Midp.Audio?.Stop(clip);
            state = PREFETCHED;
            Fire("stopped", 0L);
        }

        internal void StopSilently()
        {
            if (clip >= 0) Midp.Audio?.Stop(clip);
            if (state == STARTED) state = PREFETCHED;
        }

        public override void deallocate()
        {
            if (state == STARTED) stop();
            if (state > REALIZED) state = REALIZED;
        }

        public override void close()
        {
            if (state == CLOSED) return;
            if (state == STARTED && clip >= 0) Midp.Audio?.Stop(clip);
            state = CLOSED;
            MediaManagerState.Unregister(this);
            Fire("closed", null);
        }

        /// <summary>Called from the event loop: ends finite playback and notifies listeners.</summary>
        internal void Poll()
        {
            if (state != STARTED || loopCount < 0) return;
            if (JSystem.currentTimeMillis() - startedAt < durationMs * loopCount) return;
            state = PREFETCHED;
            MediaManagerState.Unregister(this);
            Fire("endOfMedia", durationMs * 1000L);
        }

        public override int getState()
        {
            if (state == STARTED && loopCount > 0 && JSystem.currentTimeMillis() - startedAt >= durationMs * loopCount)
                Poll();
            return state;
        }

        public override void setLoopCount(int count)
        {
            if (count == 0) throw new System.ArgumentException("loop count 0");
            loopCount = count;
        }

        public override long setMediaTime(long now) { return 0; }

        public override long getMediaTime()
        {
            if (state != STARTED) return 0;
            return (JSystem.currentTimeMillis() - startedAt) % System.Math.Max(1, durationMs) * 1000L;
        }

        public override long getDuration() { return durationMs * 1000L; }
        public override string getContentType() { return type; }

        public override Control getControl(string controlType)
        {
            return controlType != null && controlType.EndsWith("VolumeControl") ? this : null;
        }

        public override Control[] getControls() { return new Control[] { this }; }
        public override void addPlayerListener(PlayerListener l) { if (l != null && !listeners.Contains(l)) listeners.Add(l); }
        public override void removePlayerListener(PlayerListener l) { listeners.Remove(l); }

        void Fire(string evt, object evtData)
        {
            foreach (var l in listeners.ToArray()) l.playerUpdate(this, evt, evtData);
        }

        public int setLevel(int l)
        {
            level = System.Math.Max(0, System.Math.Min(100, l));
            if (clip >= 0) Midp.Audio?.SetVolume(clip, Volume);
            return level;
        }

        public int getLevel() { return level; }

        public void setMute(bool m)
        {
            muted = m;
            if (clip >= 0) Midp.Audio?.SetVolume(clip, Volume);
        }

        public bool isMuted() { return muted; }
    }
}
