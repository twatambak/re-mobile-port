using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.InputSystem;

namespace J2ME.Unity
{
    /// <summary>
    /// Boots a MIDlet from its JAR and presents it: the MIDP framebuffer is blitted to a texture drawn with
    /// aspect-correct scaling; keyboard, mouse and touch are translated into MIDP key/pointer events.
    /// Only one instance can run at a time because the MIDP runtime (like the original phone) is global.
    /// </summary>
    public class MidletPlayer : MonoBehaviour
    {
        [Tooltip("The original MIDlet JAR, renamed to .bytes so Unity imports it as a TextAsset.")]
        [SerializeField] TextAsset jar;

        [Tooltip("Namespace the MIDlet was transpiled into. The class name comes from the JAR's MIDlet-1 entry.")]
        [SerializeField] string midletNamespace = "REUprising.Gameloft";

        [Tooltip("Optional full type name overriding the MIDlet-1 lookup.")]
        [SerializeField] string midletClassOverride = "";

        [SerializeField] Vector2Int screenSize = new Vector2Int(360, 640);
        [SerializeField] bool pointerEvents = true;
        [SerializeField] bool pixelPerfectScaling = false;
        [SerializeField] FilterMode filterMode = FilterMode.Point;
        [SerializeField] Color letterboxColor = Color.black;
        [SerializeField] bool verboseLog = false;

        static MidletPlayer running;

        Texture2D texture;
        int[] frame;
        long shownFrame = -1;
        Rect screenRect;
        UnityAudioBackend audioBackend;
        bool pointerDown;
        Vector2Int lastPointer;

        // Default mapping follows Nokia/Sony Ericsson keycodes, which the games expect.
        static readonly (Key key, int code)[] KeyMap =
        {
            (Key.UpArrow, -1), (Key.DownArrow, -2), (Key.LeftArrow, -3), (Key.RightArrow, -4),
            (Key.Enter, -5), (Key.Space, -5), (Key.NumpadEnter, -5),
            (Key.F1, -6), (Key.Q, -6), (Key.F2, -7), (Key.E, -7), (Key.Escape, -7), (Key.Backspace, -8),
            (Key.Digit0, 48), (Key.Digit1, 49), (Key.Digit2, 50), (Key.Digit3, 51), (Key.Digit4, 52),
            (Key.Digit5, 53), (Key.Digit6, 54), (Key.Digit7, 55), (Key.Digit8, 56), (Key.Digit9, 57),
            (Key.Numpad0, 48), (Key.Numpad1, 49), (Key.Numpad2, 50), (Key.Numpad3, 51), (Key.Numpad4, 52),
            (Key.Numpad5, 53), (Key.Numpad6, 54), (Key.Numpad7, 55), (Key.Numpad8, 56), (Key.Numpad9, 57),
            (Key.NumpadMultiply, 42), (Key.NumpadPeriod, 35), (Key.Z, 42), (Key.X, 35),
            (Key.W, 50), (Key.A, 52), (Key.S, 56), (Key.D, 54),
        };

        void Start()
        {
            if (running != null)
            {
                Debug.LogError("Only one MidletPlayer can run at a time.", this);
                enabled = false;
                return;
            }
            if (jar == null)
            {
                Debug.LogError("MidletPlayer has no JAR assigned.", this);
                enabled = false;
                return;
            }
            running = this;

            Midp.Logger = s =>
            {
                // A crashed MIDlet otherwise just leaves a black screen, so make it impossible to miss.
                if (s.StartsWith("MIDlet crashed")) Debug.LogError("[J2ME] " + s);
                else Debug.Log("[J2ME] " + s);
            };
            Midp.Verbose = verboseLog;
            Midp.ScreenWidth = screenSize.x;
            Midp.ScreenHeight = screenSize.y;
            Midp.HasPointer = pointerEvents;
            Midp.StorageDirectory = Path.Combine(Application.persistentDataPath, "J2ME", jar.name);
            Midp.Exited += OnMidletExited;
            audioBackend = new UnityAudioBackend(gameObject);
            Midp.Audio = audioBackend;
            Midp.LoadJar(jar.bytes);

            var type = ResolveMidletType();
            if (type == null)
            {
                Debug.LogError("MIDlet class not found. Check midletNamespace / midletClassOverride.", this);
                enabled = false;
                return;
            }

            texture = new Texture2D(screenSize.x, screenSize.y, TextureFormat.BGRA32, false) { filterMode = filterMode, wrapMode = TextureWrapMode.Clamp };
            frame = new int[screenSize.x * screenSize.y];
            Midp.Launch(() => (MIDlet)Activator.CreateInstance(type));
        }

        Type ResolveMidletType()
        {
            string name = midletClassOverride;
            if (string.IsNullOrEmpty(name))
            {
                // "MIDlet-1: <label>, <icon>, <class>"
                var entry = Midp.GetAppProperty("MIDlet-1");
                if (entry == null) return null;
                var parts = entry.Split(',');
                name = midletNamespace + "." + parts[parts.Length - 1].Trim();
            }
            foreach (var asm in AppDomain.CurrentDomain.GetAssemblies())
            {
                var t = asm.GetType(name, false);
                if (t != null && typeof(MIDlet).IsAssignableFrom(t)) return t;
            }
            return null;
        }

        void OnMidletExited()
        {
            Debug.Log("[J2ME] MIDlet called notifyDestroyed.");
        }

        void Update()
        {
            if (texture == null) return;
            audioBackend.Pump();

            long n = Midp.CopyFrame(frame);
            if (n != shownFrame)
            {
                shownFrame = n;
                texture.SetPixelData(frame, 0);
                texture.Apply(false);
            }

            screenRect = ComputeScreenRect();
            PollKeyboard();
            if (pointerEvents) PollPointer();
        }

        Rect ComputeScreenRect()
        {
            float sw = Screen.width, sh = Screen.height;
            float scale = Mathf.Min(sw / screenSize.x, sh / screenSize.y);
            if (pixelPerfectScaling && scale >= 1f) scale = Mathf.Floor(scale);
            float w = screenSize.x * scale, h = screenSize.y * scale;
            return new Rect((sw - w) * 0.5f, (sh - h) * 0.5f, w, h);
        }

        void PollKeyboard()
        {
            var kb = Keyboard.current;
            if (kb == null) return;
            foreach (var (key, code) in KeyMap)
            {
                var k = kb[key];
                if (k.wasPressedThisFrame) Midp.PostKeyPressed(code);
                else if (k.wasReleasedThisFrame) Midp.PostKeyReleased(code);
            }
        }

        void PollPointer()
        {
            var pointer = Pointer.current;
            if (pointer == null) return;
            bool pressed = pointer.press.isPressed;
            Vector2 pos = pointer.position.ReadValue();
            // Input System positions are bottom-left based; GUI rects are top-left based.
            float gx = pos.x, gy = Screen.height - pos.y;
            var p = new Vector2Int(
                Mathf.FloorToInt((gx - screenRect.x) / screenRect.width * screenSize.x),
                Mathf.FloorToInt((gy - screenRect.y) / screenRect.height * screenSize.y));
            bool inside = p.x >= 0 && p.y >= 0 && p.x < screenSize.x && p.y < screenSize.y;

            if (pressed && !pointerDown && inside)
            {
                pointerDown = true;
                lastPointer = p;
                Midp.PostPointerPressed(p.x, p.y);
            }
            else if (pressed && pointerDown && p != lastPointer)
            {
                lastPointer = p;
                Midp.PostPointerDragged(Mathf.Clamp(p.x, 0, screenSize.x - 1), Mathf.Clamp(p.y, 0, screenSize.y - 1));
            }
            else if (!pressed && pointerDown)
            {
                pointerDown = false;
                Midp.PostPointerReleased(lastPointer.x, lastPointer.y);
            }
        }

        void OnGUI()
        {
            if (texture == null || Event.current.type != EventType.Repaint) return;
            var prev = GUI.color;
            GUI.color = letterboxColor;
            GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), Texture2D.whiteTexture);
            GUI.color = prev;
            // MIDP rows are top-down while texture rows are bottom-up: flip with the texture coordinates.
            GUI.DrawTextureWithTexCoords(screenRect, texture, new Rect(0, 1, 1, -1));
        }

        void OnApplicationPause(bool paused)
        {
            if (running != this) return;
            if (paused) Midp.PostPause();
            else Midp.PostResume();
        }

        void OnDestroy()
        {
            if (running != this) return;
            Midp.Exited -= OnMidletExited;
            Midp.Shutdown();
            Midp.Audio = null;
            audioBackend?.Dispose();
            running = null;
            if (texture != null) Destroy(texture);
        }
    }
}
