// Host-facing core of the MIDP emulator: resources, lifecycle, the MIDP event thread and the presented framebuffer.
// Engine-agnostic: the Unity front-end (or a headless test runner) drives it through the public static API.
using System.Collections.Generic;
using System.Threading;

namespace J2ME
{
    /// <summary>Audio backend implemented by the host (Unity). Calls arrive on game threads.</summary>
    public interface IMidpAudio
    {
        /// <summary>Registers decoded PCM and returns a handle. Called once per Player.</summary>
        int CreateClip(float[] samples, int channels, int sampleRate);
        void Play(int clip, int loopCount, float volume);
        void Stop(int clip);
        void SetVolume(int clip, float volume);
        void Release(int clip);
    }

    public static class Midp
    {
        public static int ScreenWidth = 240;
        public static int ScreenHeight = 320;
        public static bool HasPointer = true;
        public static bool Verbose;
        public static string Locale = "en";
        /// <summary>Directory where RecordStores are persisted. Null keeps them in memory only.</summary>
        public static string StorageDirectory;
        public static System.Action<string> Logger = s => System.Console.WriteLine(s);
        public static IMidpAudio Audio;
        /// <summary>Raised (on a game thread) when the MIDlet calls notifyDestroyed.</summary>
        public static event System.Action Exited;

        public static JarArchive Jar { get; private set; }
        static readonly Dictionary<string, string> appProperties = new Dictionary<string, string>();

        static volatile bool terminated;
        static ManualResetEvent shutdownSignal = new ManualResetEvent(false);
        static System.Threading.Thread eventSysThread;
        static readonly object queueLock = new object();
        static readonly Queue<System.Action> inputQueue = new Queue<System.Action>();
        static readonly Queue<Runnable> serialQueue = new Queue<Runnable>();
        static volatile bool repaintPending;
        internal static readonly object PaintLock = new object();

        static int[] backBuffer;
        static int[] frontBuffer;
        static Graphics screenGraphics;
        static long frameCounter;
        static readonly object frontLock = new object();

        public static bool IsRunning => eventSysThread != null && !terminated;
        public static long FrameCount => Interlocked.Read(ref frameCounter);

        public static void Log(string s) { Logger?.Invoke(s); }

        // ---------------------------------------------------------------- lifecycle

        public static void LoadJar(byte[] jarBytes, IDictionary<string, string> extraProperties = null)
        {
            Jar = new JarArchive(jarBytes);
            appProperties.Clear();
            var manifest = Jar.GetBytes("META-INF/MANIFEST.MF");
            if (manifest != null) ParseManifest(System.Text.Encoding.UTF8.GetString(manifest));
            if (extraProperties != null)
                foreach (var kv in extraProperties) appProperties[kv.Key] = kv.Value;
        }

        static void ParseManifest(string text)
        {
            string lastKey = null;
            foreach (var raw in text.Replace("\r\n", "\n").Replace('\r', '\n').Split('\n'))
            {
                if (raw.Length == 0) continue;
                if (raw[0] == ' ' && lastKey != null) { appProperties[lastKey] += raw.Substring(1); continue; }
                int colon = raw.IndexOf(':');
                if (colon <= 0) continue;
                lastKey = raw.Substring(0, colon).Trim();
                // First occurrence wins, like most handset AMS implementations.
                if (!appProperties.ContainsKey(lastKey)) appProperties[lastKey] = raw.Substring(colon + 1).Trim();
            }
        }

        public static string GetAppProperty(string key)
        {
            return key != null && appProperties.TryGetValue(key, out var v) ? v : null;
        }

        /// <summary>Starts the MIDP event thread, constructs the MIDlet on it and calls startApp.</summary>
        public static void Launch(System.Func<MIDlet> createMidlet)
        {
            terminated = false;
            shutdownSignal = new ManualResetEvent(false);
            repaintPending = false;
            lock (queueLock) { inputQueue.Clear(); serialQueue.Clear(); }
            backBuffer = new int[ScreenWidth * ScreenHeight];
            frontBuffer = new int[ScreenWidth * ScreenHeight];
            for (int i = 0; i < backBuffer.Length; i++) backBuffer[i] = unchecked((int)0xFF000000);
            screenGraphics = new Graphics(backBuffer, ScreenWidth, ScreenHeight, true);
            Display.ResetForLaunch();

            eventSysThread = new System.Threading.Thread(() =>
            {
                try
                {
                    var midlet = createMidlet();
                    MIDlet.Current = midlet;
                    midlet.startApp();
                    EventLoop();
                }
                catch (MidpTerminated) { }
                catch (System.Exception e) { Log("MIDlet crashed: " + e); }
            });
            eventSysThread.IsBackground = true;
            eventSysThread.Name = "MIDP Event Thread";
            eventSysThread.Start();
        }

        /// <summary>Stops all MIDlet activity. Game threads park forever at their next sleep/yield.</summary>
        public static void Shutdown()
        {
            terminated = true;
            shutdownSignal.Set();
            lock (queueLock) Monitor.PulseAll(queueLock);
            MediaManagerState.StopAll();
            eventSysThread = null;
        }

        internal static void RequestExit()
        {
            Shutdown();
            Exited?.Invoke();
        }

        public static void CheckAlive()
        {
            if (terminated) Park();
        }

        internal static void Sleep(long ms)
        {
            if (shutdownSignal.WaitOne((int)System.Math.Min(ms, int.MaxValue))) Park();
        }

        static void Park()
        {
            if (System.Threading.Thread.CurrentThread == eventSysThread) throw new MidpTerminated();
            // Never returns: a terminated MIDlet's threads must not keep running game logic.
            new ManualResetEvent(false).WaitOne();
        }

        // ---------------------------------------------------------------- resources

        public static InputStream OpenResource(string name)
        {
            var data = GetResourceBytes(name);
            return data == null ? null : new ByteArrayInputStream(data);
        }

        public static sbyte[] GetResourceBytes(string name)
        {
            if (Jar == null || name == null) return null;
            var b = Jar.GetBytes(name.StartsWith("/") ? name.Substring(1) : name);
            return ByteConv.ToSigned(b);
        }

        // ---------------------------------------------------------------- event thread

        public static void PostKeyPressed(int keyCode) { PostInput(() => (Display.CurrentDisplayable as Canvas)?.keyPressed(keyCode)); }
        public static void PostKeyReleased(int keyCode) { PostInput(() => (Display.CurrentDisplayable as Canvas)?.keyReleased(keyCode)); }
        public static void PostKeyRepeated(int keyCode) { PostInput(() => (Display.CurrentDisplayable as Canvas)?.keyRepeated(keyCode)); }
        public static void PostPointerPressed(int x, int y) { PostInput(() => (Display.CurrentDisplayable as Canvas)?.pointerPressed(x, y)); }
        public static void PostPointerDragged(int x, int y) { PostInput(() => (Display.CurrentDisplayable as Canvas)?.pointerDragged(x, y)); }
        public static void PostPointerReleased(int x, int y) { PostInput(() => (Display.CurrentDisplayable as Canvas)?.pointerReleased(x, y)); }

        /// <summary>Host lost focus (e.g. app backgrounded).</summary>
        public static void PostPause()
        {
            PostInput(() =>
            {
                (Display.CurrentDisplayable as Canvas)?.hideNotify();
                MIDlet.Current?.pauseApp();
            });
        }

        public static void PostResume()
        {
            PostInput(() =>
            {
                MIDlet.Current?.startApp();
                (Display.CurrentDisplayable as Canvas)?.showNotify();
            });
        }

        internal static void PostInput(System.Action a)
        {
            lock (queueLock)
            {
                inputQueue.Enqueue(a);
                Monitor.PulseAll(queueLock);
            }
        }

        internal static void CallSerially(Runnable r)
        {
            lock (queueLock)
            {
                serialQueue.Enqueue(r);
                Monitor.PulseAll(queueLock);
            }
        }

        internal static void RequestRepaint()
        {
            repaintPending = true;
            lock (queueLock) Monitor.PulseAll(queueLock);
        }

        internal static bool OnEventThread => System.Threading.Thread.CurrentThread == eventSysThread;

        internal static void ServiceRepaints()
        {
            if (repaintPending) PaintNow();
        }

        static void EventLoop()
        {
            var inputs = new List<System.Action>();
            while (!terminated)
            {
                Runnable serial = null;
                lock (queueLock)
                {
                    while (!terminated && inputQueue.Count == 0 && serialQueue.Count == 0 && !repaintPending)
                        Monitor.Wait(queueLock, 20);
                    while (inputQueue.Count > 0) inputs.Add(inputQueue.Dequeue());
                    if (serialQueue.Count > 0) serial = serialQueue.Dequeue();
                }
                if (terminated) break;

                foreach (var a in inputs) a();
                inputs.Clear();
                if (repaintPending) PaintNow();
                serial?.run();
                MediaManagerState.Pump();
            }
        }

        static void PaintNow()
        {
            lock (PaintLock)
            {
                repaintPending = false;
                var canvas = Display.CurrentDisplayable as Canvas;
                if (canvas == null) return;
                screenGraphics.ResetForPaint();
                canvas.paint(screenGraphics);
                lock (frontLock)
                {
                    System.Array.Copy(backBuffer, frontBuffer, backBuffer.Length);
                    frameCounter++;
                }
            }
        }

        /// <summary>Copies the last presented frame (ARGB, top-down rows) into dest. Returns the frame number.</summary>
        public static long CopyFrame(int[] dest)
        {
            lock (frontLock)
            {
                if (frontBuffer != null) System.Array.Copy(frontBuffer, dest, System.Math.Min(dest.Length, frontBuffer.Length));
                return frameCounter;
            }
        }
    }
}
