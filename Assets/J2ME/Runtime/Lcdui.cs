// javax.microedition.lcdui (minus Graphics/Image/Font) and javax.microedition.midlet.
using System.Collections.Generic;

namespace J2ME
{
    public abstract class MIDlet
    {
        internal static MIDlet Current;

        protected MIDlet() { Current = this; }

        public abstract void startApp();
        public abstract void pauseApp();
        public abstract void destroyApp(bool unconditional);

        public string getAppProperty(string key) { return Midp.GetAppProperty(key); }
        public void notifyDestroyed() { Midp.RequestExit(); }
        public void notifyPaused() { }
        public void resumeRequest() { }
        public bool platformRequest(string url) { Midp.Log("platformRequest ignored: " + url); return false; }
        public int checkPermission(string permission) { return 1; }
    }

    public class MIDletStateChangeException : System.Exception
    {
        public MIDletStateChangeException() { }
        public MIDletStateChangeException(string msg) : base(msg) { }
    }

    public interface CommandListener
    {
        void commandAction(Command c, Displayable d);
    }

    public class Command
    {
        public const int SCREEN = 1, BACK = 2, CANCEL = 3, OK = 4, HELP = 5, STOP = 6, EXIT = 7, ITEM = 8;
        readonly string label;
        readonly int type, priority;

        public Command(string label, int type, int priority) { this.label = label; this.type = type; this.priority = priority; }
        public Command(string shortLabel, string longLabel, int type, int priority) : this(shortLabel, type, priority) { }
        public string getLabel() { return label; }
        public int getCommandType() { return type; }
        public int getPriority() { return priority; }
    }

    public abstract class Displayable
    {
        internal CommandListener listener;
        internal readonly List<Command> commands = new List<Command>();
        string title;

        public virtual int getWidth() { return Midp.ScreenWidth; }
        public virtual int getHeight() { return Midp.ScreenHeight; }
        public bool isShown() { return Display.CurrentDisplayable == this; }
        public void addCommand(Command c) { if (!commands.Contains(c)) commands.Add(c); }
        public void removeCommand(Command c) { commands.Remove(c); }
        public void setCommandListener(CommandListener l) { listener = l; }
        public void setTitle(string t) { title = t; }
        public string getTitle() { return title; }
        public virtual void sizeChanged(int w, int h) { }
    }

    public abstract class Canvas : Displayable
    {
        public const int UP = 1, DOWN = 6, LEFT = 2, RIGHT = 5, FIRE = 8;
        public const int GAME_A = 9, GAME_B = 10, GAME_C = 11, GAME_D = 12;
        public const int KEY_NUM0 = 48, KEY_NUM1 = 49, KEY_NUM2 = 50, KEY_NUM3 = 51, KEY_NUM4 = 52;
        public const int KEY_NUM5 = 53, KEY_NUM6 = 54, KEY_NUM7 = 55, KEY_NUM8 = 56, KEY_NUM9 = 57;
        public const int KEY_STAR = 42, KEY_POUND = 35;

        public abstract void paint(Graphics g);

        public virtual void keyPressed(int keyCode) { }
        public virtual void keyReleased(int keyCode) { }
        public virtual void keyRepeated(int keyCode) { }
        public virtual void pointerPressed(int x, int y) { }
        public virtual void pointerReleased(int x, int y) { }
        public virtual void pointerDragged(int x, int y) { }
        public virtual void showNotify() { }
        public virtual void hideNotify() { }

        public void repaint() { Midp.RequestRepaint(); }
        public void repaint(int x, int y, int w, int h) { Midp.RequestRepaint(); }

        public void serviceRepaints()
        {
            if (Midp.OnEventThread) { Midp.ServiceRepaints(); return; }
            lock (Midp.PaintLock) Midp.ServiceRepaints();
        }

        public void setFullScreenMode(bool mode) { }
        public bool isDoubleBuffered() { return true; }
        public bool hasPointerEvents() { return Midp.HasPointer; }
        public bool hasPointerMotionEvents() { return Midp.HasPointer; }
        public bool hasRepeatEvents() { return false; }

        public int getGameAction(int keyCode)
        {
            switch (keyCode)
            {
                case -1: case KEY_NUM2: return UP;
                case -2: case KEY_NUM8: return DOWN;
                case -3: case KEY_NUM4: return LEFT;
                case -4: case KEY_NUM6: return RIGHT;
                case -5: case KEY_NUM5: return FIRE;
                case KEY_NUM7: return GAME_A;
                case KEY_NUM9: return GAME_B;
                case KEY_STAR: return GAME_C;
                case KEY_POUND: return GAME_D;
                default: return 0;
            }
        }

        public int getKeyCode(int gameAction)
        {
            switch (gameAction)
            {
                case UP: return -1;
                case DOWN: return -2;
                case LEFT: return -3;
                case RIGHT: return -4;
                case FIRE: return -5;
                case GAME_A: return KEY_NUM7;
                case GAME_B: return KEY_NUM9;
                case GAME_C: return KEY_STAR;
                case GAME_D: return KEY_POUND;
                default: return 0;
            }
        }

        public string getKeyName(int keyCode)
        {
            if (keyCode >= KEY_NUM0 && keyCode <= KEY_NUM9) return ((char)keyCode).ToString();
            switch (keyCode)
            {
                case KEY_STAR: return "*";
                case KEY_POUND: return "#";
                case -1: return "Up";
                case -2: return "Down";
                case -3: return "Left";
                case -4: return "Right";
                case -5: return "Select";
                case -6: return "Soft1";
                case -7: return "Soft2";
                default: return "Key" + keyCode;
            }
        }
    }

    public class AlertType
    {
        public static readonly AlertType INFO = new AlertType(), WARNING = new AlertType(), ERROR = new AlertType();
        public static readonly AlertType ALARM = new AlertType(), CONFIRMATION = new AlertType();
        public bool playSound(Display d) { return false; }
    }

    public class Alert : Displayable
    {
        public const int FOREVER = -2;
        string text;

        public Alert(string title) { setTitle(title); }
        public Alert(string title, string text, Image image, AlertType type) { setTitle(title); this.text = text; }
        public void setString(string s) { text = s; }
        public string getString() { return text; }
        public void setTimeout(int t) { }
        public int getTimeout() { return FOREVER; }
        public void setType(AlertType t) { }
        public void setImage(Image i) { }
    }

    public class Display
    {
        static Display instance;
        static volatile Displayable current;

        internal static Displayable CurrentDisplayable => current;

        internal static void ResetForLaunch()
        {
            instance = null;
            current = null;
        }

        public static Display getDisplay(MIDlet m) { return instance ??= new Display(); }

        public Displayable getCurrent() { return current; }

        public void setCurrent(Displayable d)
        {
            if (d is Alert a)
            {
                // Alerts are not rendered; surface them in the log so failures are not silent.
                Midp.Log("[Alert] " + a.getTitle() + ": " + a.getString());
                return;
            }
            if (d == current || d == null) return;
            var old = current as Canvas;
            current = d;
            if (old != null) Midp.PostInput(old.hideNotify);
            if (d is Canvas c) Midp.PostInput(c.showNotify);
            Midp.RequestRepaint();
        }

        public void setCurrent(Alert alert, Displayable next)
        {
            setCurrent(alert);
            setCurrent(next);
        }

        public void callSerially(Runnable r) { Midp.CallSerially(r); }
        public bool isColor() { return true; }
        public int numColors() { return 1 << 24; }
        public int numAlphaLevels() { return 256; }
        public bool vibrate(int ms) { return true; }
        public bool flashBacklight(int ms) { return true; }
    }
}
