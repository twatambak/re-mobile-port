// J2meToCs: converts Vineflower-decompiled J2ME Java sources (run with -ren=1 so identifiers are unique)
// into C# that compiles against the J2ME emulation runtime in Assets/J2ME/Runtime.
//
// usage: J2meToCs <srcDir> <outDir> <namespace> [--patches <dir>]
//
// The converter is token based (strings, chars and comments are never rewritten) and applies:
//   * type/keyword mapping (boolean->bool, byte->sbyte, String->string, super->base, instanceof->is, ...)
//   * class headers (extends/implements -> ':'), constant-only interfaces -> static classes + 'using static'
//   * member modifiers -> public (+override/virtual inferred from MIDP base classes and game inheritance)
//   * super(...)/this(...) constructor calls -> constructor initializers
//   * Java multi-dimensional array creation and nested array initializers
//   * '>>>' -> JOps.Ushr, out-of-range hex int literals -> unchecked casts
//   * labeled break/continue -> goto, switch fall-through -> 'goto case' / 'break'
using System.Text;
using System.Text.RegularExpressions;

static class Program
{
    static int Main(string[] args)
    {
        if (args.Length < 3)
        {
            Console.Error.WriteLine("usage: J2meToCs <srcDir> <outDir> <namespace>");
            return 1;
        }
        string src = args[0], outDir = args[1], ns = args[2];
        var files = Directory.GetFiles(src, "*.java", SearchOption.AllDirectories).OrderBy(f => f).ToList();
        var units = files.Select(f => new Unit(f, File.ReadAllText(f))).ToList();
        var model = new Model(units) { EmitAliases = args.Contains("--aliases") };
        Directory.CreateDirectory(outDir);
        foreach (var u in units)
        {
            var cs = new Converter(u, model, ns).Convert();
            File.WriteAllText(Path.Combine(outDir, u.ClassName + ".cs"), cs);
        }
        Console.WriteLine($"Converted {units.Count} files into {outDir}");
        return 0;
    }
}

enum TK { Ident, Number, String, Char, Op, Comment, WS }

sealed class Tok
{
    public TK K;
    public string T;
    public Tok(TK k, string t) { K = k; T = t; }
    public bool Is(string s) => T == s && K != TK.String && K != TK.Char && K != TK.Comment;
    public bool Trivia => K == TK.WS || K == TK.Comment;
    public override string ToString() => T;
}

static class Lexer
{
    static readonly string[] Ops =
    {
        ">>>=", "<<=", ">>=", ">>>", "...", "->", "::", "++", "--", "&&", "||", "==", "!=", "<=", ">=", "+=", "-=", "*=", "/=",
        "%=", "&=", "|=", "^=", "<<", ">>",
    };

    public static List<Tok> Lex(string s)
    {
        var r = new List<Tok>();
        int i = 0;
        while (i < s.Length)
        {
            char c = s[i];
            int st = i;
            if (char.IsWhiteSpace(c))
            {
                while (i < s.Length && char.IsWhiteSpace(s[i])) i++;
                r.Add(new Tok(TK.WS, s[st..i]));
            }
            else if (c == '/' && i + 1 < s.Length && s[i + 1] == '/')
            {
                while (i < s.Length && s[i] != '\n') i++;
                r.Add(new Tok(TK.Comment, s[st..i]));
            }
            else if (c == '/' && i + 1 < s.Length && s[i + 1] == '*')
            {
                i = s.IndexOf("*/", i + 2, StringComparison.Ordinal);
                i = i < 0 ? s.Length : i + 2;
                r.Add(new Tok(TK.Comment, s[st..i]));
            }
            else if (c == '"' || c == '\'')
            {
                i++;
                while (i < s.Length && s[i] != c) { if (s[i] == '\\') i++; i++; }
                i++;
                r.Add(new Tok(c == '"' ? TK.String : TK.Char, s[st..i]));
            }
            else if (char.IsLetter(c) || c == '_' || c == '$')
            {
                while (i < s.Length && (char.IsLetterOrDigit(s[i]) || s[i] == '_' || s[i] == '$')) i++;
                r.Add(new Tok(TK.Ident, s[st..i]));
            }
            else if (char.IsDigit(c) || (c == '.' && i + 1 < s.Length && char.IsDigit(s[i + 1])))
            {
                if (c == '0' && i + 1 < s.Length && (s[i + 1] == 'x' || s[i + 1] == 'X'))
                {
                    i += 2;
                    while (i < s.Length && Uri.IsHexDigit(s[i])) i++;
                }
                else
                {
                    while (i < s.Length && (char.IsDigit(s[i]) || s[i] == '.')) i++;
                    if (i < s.Length && (s[i] == 'e' || s[i] == 'E'))
                    {
                        i++;
                        if (i < s.Length && (s[i] == '+' || s[i] == '-')) i++;
                        while (i < s.Length && char.IsDigit(s[i])) i++;
                    }
                }
                if (i < s.Length && "lLfFdD".IndexOf(s[i]) >= 0) i++;
                r.Add(new Tok(TK.Number, s[st..i]));
            }
            else
            {
                string op = Ops.FirstOrDefault(o => string.CompareOrdinal(s, i, o, 0, o.Length) == 0) ?? c.ToString();
                i += op.Length;
                r.Add(new Tok(TK.Op, op));
            }
        }
        return r;
    }
}

/// <summary>One Java source file (one top-level type).</summary>
sealed class Unit
{
    public readonly string Path, Source;
    public string ClassName = "";
    public bool IsInterface, IsAbstract;
    public string Extends;
    public List<string> Implements = new();
    public bool HasMethods;
    public readonly Dictionary<string, List<(int arity, bool isAbstract)>> Methods = new();

    static readonly Regex Header = new(@"^\s*((?:public|abstract|final|static)\s+)*(class|interface)\s+(\w+)(?:\s+extends\s+([\w.]+(?:\s*,\s*[\w.]+)*))?(?:\s+implements\s+([\w.,\s]+?))?\s*\{", RegexOptions.Multiline);
    static readonly Regex Method = new(@"^   (?:(?:public|private|protected|static|final|abstract|synchronized|native)\s+)*[\w\[\].]+\s+(\w+)\(([^)]*)\)\s*(\{|;)", RegexOptions.Multiline);

    public Unit(string path, string source)
    {
        Path = path;
        Source = source;
        var m = Header.Match(source);
        if (!m.Success) throw new Exception("No type header in " + path);
        ClassName = m.Groups[3].Value;
        IsInterface = m.Groups[2].Value == "interface";
        IsAbstract = m.Groups[1].Captures.Any(c => c.Value.Trim() == "abstract");
        if (m.Groups[4].Success)
        {
            var ext = m.Groups[4].Value.Split(',').Select(x => Short(x.Trim())).ToList();
            if (IsInterface) Implements.AddRange(ext); else Extends = ext[0];
        }
        if (m.Groups[5].Success) Implements.AddRange(m.Groups[5].Value.Split(',').Select(x => Short(x.Trim())));
        foreach (Match mm in Method.Matches(source))
        {
            string name = mm.Groups[1].Value;
            int arity = mm.Groups[2].Value.Trim().Length == 0 ? 0 : mm.Groups[2].Value.Split(',').Length;
            bool isAbstract = mm.Groups[3].Value == ";";
            if (!Methods.TryGetValue(name, out var l)) Methods[name] = l = new();
            l.Add((arity, isAbstract));
            HasMethods = true;
        }
    }

    static string Short(string n) => n.Contains('.') ? n[(n.LastIndexOf('.') + 1)..] : n;
}

sealed class Model
{
    public readonly Dictionary<string, Unit> Units;

    // Virtual members of runtime base classes that game code overrides.
    static readonly Dictionary<string, string[]> RuntimeVirtuals = new()
    {
        ["Canvas"] = new[] { "paint", "keyPressed", "keyReleased", "keyRepeated", "pointerPressed", "pointerReleased", "pointerDragged", "showNotify", "hideNotify", "sizeChanged" },
        ["MIDlet"] = new[] { "startApp", "pauseApp", "destroyApp" },
        ["Thread"] = new[] { "run" },
        ["InputStream"] = new[] { "read", "skip", "available", "close", "mark", "reset", "markSupported" },
    };

    static readonly Regex RenamedField = new(
        @"// \$VF: renamed from: (\w+) [\w.\[\]]+\r?\n\s+(?:(?:public|private|protected|static|final|transient|volatile)\s+)*[\w\[\].]+\s+(field_\d+)\b",
        RegexOptions.Compiled);

    /// <summary>Original (obfuscated) field name -> (declaring class, renamed field).</summary>
    public readonly Dictionary<string, List<(string cls, string renamed)>> FieldsByOrig = new();

    public string ResolveField(string cls, string orig)
    {
        for (string c = cls; c != null && Units.TryGetValue(c, out var u); c = u.Extends)
            foreach (var (fc, renamed) in FieldsByOrig.TryGetValue(orig, out var l) ? l : new())
                if (fc == c) return renamed;
        return null;
    }

    void IndexFields()
    {
        foreach (var u in Units.Values)
            foreach (Match m in RenamedField.Matches(u.Source))
            {
                if (!FieldsByOrig.TryGetValue(m.Groups[1].Value, out var l)) FieldsByOrig[m.Groups[1].Value] = l = new();
                l.Add((u.ClassName, m.Groups[2].Value));
            }
    }

    public bool EmitAliases;

    public Model(List<Unit> units) { Units = units.ToDictionary(u => u.ClassName); IndexFields(); }

    public bool IsConstantInterface(string name) => Units.TryGetValue(name, out var u) && u.IsInterface && !u.HasMethods;

    /// <summary>Returns "override", "virtual", "abstract" or null for a method in a class.</summary>
    public string Dispatch(Unit u, string method, int arity, bool isAbstract)
    {
        if (u.IsInterface) return null;
        for (string b = u.Extends; b != null;)
        {
            if (RuntimeVirtuals.TryGetValue(b, out var names)) return names.Contains(method) ? "override" : null;
            if (!Units.TryGetValue(b, out var bu)) break;
            if (bu.Methods.TryGetValue(method, out var l) && l.Any(x => x.arity == arity)) return "override";
            b = bu.Extends;
        }
        if (isAbstract) return "abstract";
        // Base of an overridden method within the game hierarchy.
        foreach (var other in Units.Values)
        {
            if (other == u) continue;
            for (string b = other.Extends; b != null && Units.TryGetValue(b, out var bu); b = bu.Extends)
                if (b == u.ClassName && other.Methods.TryGetValue(method, out var l) && l.Any(x => x.arity == arity))
                    return "virtual";
        }
        return null;
    }
}

sealed class Converter
{
    readonly Unit unit;
    readonly Model model;
    readonly string ns;
    List<Tok> t;
    readonly List<string> usingStatics = new();

    static readonly Dictionary<string, string> TypeMap = new()
    {
        ["boolean"] = "bool", ["byte"] = "sbyte", ["Object"] = "object",
        ["Throwable"] = "System.Exception", ["Exception"] = "System.Exception", ["RuntimeException"] = "System.Exception",
        ["Error"] = "System.Exception", ["NullPointerException"] = "System.NullReferenceException",
        ["ArrayIndexOutOfBoundsException"] = "System.IndexOutOfRangeException",
        ["IndexOutOfBoundsException"] = "System.SystemException", ["StringIndexOutOfBoundsException"] = "System.SystemException",
        ["ArithmeticException"] = "System.ArithmeticException", ["OutOfMemoryError"] = "System.OutOfMemoryException",
        ["ClassCastException"] = "System.InvalidCastException", ["NumberFormatException"] = "System.FormatException",
        ["IllegalArgumentException"] = "System.ArgumentException", ["IllegalStateException"] = "System.InvalidOperationException",
        ["SecurityException"] = "System.Exception", ["NegativeArraySizeException"] = "System.OverflowException",
    };

    static readonly HashSet<string> CsOnlyKeywords = new()
    {
        "as", "base", "checked", "decimal", "delegate", "event", "explicit", "extern", "fixed", "foreach", "implicit", "in",
        "internal", "is", "lock", "namespace", "object", "operator", "out", "override", "params", "readonly", "ref", "sbyte",
        "sealed", "sizeof", "stackalloc", "string", "struct", "typeof", "uint", "ulong", "unchecked", "unsafe", "ushort",
        "using", "virtual", "bool", "decimal",
    };

    static readonly HashSet<string> JavaKeywords = new() { "do", "if", "for", "int", "new", "try", "byte", "case", "char", "else", "goto", "long", "this", "void", "break", "catch", "class", "const", "final", "float", "short", "super", "throw", "while", "double", "import", "native", "public", "return", "static", "switch", "throws", "boolean", "default", "extends", "finally", "package", "private", "abstract", "continue", "volatile", "interface", "protected", "transient", "implements", "instanceof", "synchronized", "assert", "enum", "true", "false", "null" };
    static readonly HashSet<string> JavaSystemMembers = new() { "out", "err", "currentTimeMillis", "arraycopy", "gc", "exit", "getProperty", "identityHashCode" };
    static readonly HashSet<string> Modifiers = new() { "public", "private", "protected", "static", "final", "abstract", "synchronized", "native", "transient", "volatile", "strictfp" };
    static readonly HashSet<string> Primitive = new() { "int", "long", "short", "byte", "char", "boolean", "float", "double", "sbyte", "bool" };

    public Converter(Unit unit, Model model, string ns)
    {
        this.unit = unit;
        this.model = model;
        this.ns = ns;
    }

    static readonly Regex RenamedMethod = new(
        @"// \$VF: renamed from: (\w+) \([^)]*\) \S+\r?\n\s+((?:(?:public|private|protected|static|final|abstract|synchronized)\s+)*)([\w\[\].]+)\s+(method_\d+)\(([^)]*)\)",
        RegexOptions.Compiled);

    static readonly HashSet<string> CsReserved = new()
    {
        "as", "is", "in", "out", "ref", "do", "if", "for", "new", "int", "try", "base", "lock", "object", "string", "event", "params", "fixed",
    };

    /// <summary>
    /// Vineflower's renamer misses references to inherited members made through a subclass type. Emitting
    /// forwarding methods under the original obfuscated names lets C# overload resolution bind those calls the
    /// same way javac did, while the forwarded call keeps virtual dispatch intact.
    /// </summary>
    string WithObfuscatedAliases(string src)
    {
        var sb = new StringBuilder();
        var seen = new HashSet<string>();
        // Include ancestors: C# only considers base-class overloads when no derived overload applies, whereas
        // javac picks the most specific overload across the whole hierarchy.
        var sources = new List<string> { src };
        for (string b = unit.Extends; b != null && model.Units.TryGetValue(b, out var bu); b = bu.Extends) sources.Add(bu.Source);
        foreach (Match m in sources.SelectMany(s => RenamedMethod.Matches(s)))
        {
            string orig = m.Groups[1].Value, mods = m.Groups[2].Value, ret = m.Groups[3].Value, target = m.Groups[4].Value, pars = m.Groups[5].Value.Trim();
            if (CsReserved.Contains(orig)) continue;
            var parList = pars.Length == 0 ? new string[0] : pars.Split(',').Select(p => p.Trim()).ToArray();
            string sig = orig + "(" + string.Join(",", parList.Select(p => p[..p.LastIndexOf(' ')])) + ")";
            if (!seen.Add(sig)) continue;
            string args = string.Join(", ", parList.Select(p => p[(p.LastIndexOf(' ') + 1)..]));
            bool isStatic = Regex.IsMatch(mods, @"\bstatic\b");
            string call = (ret == "void" ? "" : "return ") + target + "(" + args + ");";
            sb.Append($"\n   // alias for obfuscated name '{orig}'\n   {(isStatic ? "static " : "")}{ret} {orig}({pars}) {{ {call} }}\n");
        }
        if (sb.Length == 0) return src;
        int close = src.LastIndexOf('}');
        return src[..close] + sb + src[close..];
    }
    public string Convert()
    {
        t = Lexer.Lex(model.EmitAliases && !unit.IsInterface ? WithObfuscatedAliases(unit.Source) : unit.Source);
        RemovePackageAndImports();
        if (model.EmitAliases) ResolveInheritedFields();
        if (!unit.IsInterface) MoveInstanceInitializers();
        RemoveSelfAssignThis();
        LabeledStatements();
        SwitchFallthrough();
        ArrayCreation();
        UnsignedShift();
        Literals();
        ConstructorInitializers();
        Members();         // before keyword mapping: relies on Java modifiers
        ClassHeader();
        Keywords();

        var sb = new StringBuilder();
        sb.AppendLine($"// Transpiled from Java ({System.IO.Path.GetFileName(unit.Path)}) by Tools/J2meToCs. Regenerate rather than hand-edit where possible.");
        sb.AppendLine("#pragma warning disable CS0162, CS0164, CS0168, CS0169, CS0219, CS0414, CS0649, CS1717, CS0108, CS0659, CS0661");
        sb.AppendLine("using J2ME;");
        foreach (var s in usingStatics) sb.AppendLine($"using static {ns}.{s};");
        sb.AppendLine();
        sb.AppendLine($"namespace {ns}");
        sb.AppendLine("{");
        sb.Append(string.Concat(t.Select(x => x.T)).Trim());
        sb.AppendLine();
        sb.AppendLine("}");
        return sb.ToString();
    }

    // ---------------------------------------------------------------- token helpers

    int NextSig(int i) { i++; while (i < t.Count && t[i].Trivia) i++; return i; }
    int PrevSig(int i) { i--; while (i >= 0 && t[i].Trivia) i--; return i; }
    bool SigIs(int i, string s) => i >= 0 && i < t.Count && t[i].Is(s);

    int Match(int open)
    {
        string o = t[open].T, c = o == "(" ? ")" : o == "[" ? "]" : "}";
        int depth = 0;
        for (int i = open; i < t.Count; i++)
        {
            if (t[i].Is(o)) depth++;
            else if (t[i].Is(c) && --depth == 0) return i;
        }
        throw new Exception($"{unit.ClassName}: unbalanced {o}");
    }

    int MatchBack(int close)
    {
        string c = t[close].T, o = c == ")" ? "(" : c == "]" ? "[" : "{";
        int depth = 0;
        for (int i = close; i >= 0; i--)
        {
            if (t[i].Is(c)) depth++;
            else if (t[i].Is(o) && --depth == 0) return i;
        }
        throw new Exception($"{unit.ClassName}: unbalanced {c}");
    }

    void Insert(int at, string text) { t.InsertRange(at, Lexer.Lex(text)); }
    void Replace(int at, string text) { t.RemoveAt(at); Insert(at, text); }
    string Text(int from, int toExclusive) => string.Concat(t.Skip(from).Take(toExclusive - from).Select(x => x.T));

    /// <summary>Index of the last token of the statement starting at i.</summary>
    int StatementEnd(int i)
    {
        var k = t[i];
        if (k.Is("{")) return Match(i);
        if (k.Is("if"))
        {
            int end = StatementEnd(NextSig(Match(NextSig(i))));
            int e = NextSig(end);
            return SigIs(e, "else") ? StatementEnd(NextSig(e)) : end;
        }
        if (k.Is("for") || k.Is("while") || k.Is("switch") || k.Is("synchronized") || k.Is("lock"))
        {
            int body = NextSig(Match(NextSig(i)));
            return k.Is("switch") ? Match(body) : StatementEnd(body);
        }
        if (k.Is("do"))
        {
            int bodyEnd = StatementEnd(NextSig(i));
            int w = NextSig(bodyEnd);
            int semi = NextSig(Match(NextSig(w)));
            return semi;
        }
        if (k.Is("try"))
        {
            int end = Match(NextSig(i));
            while (true)
            {
                int n = NextSig(end);
                if (SigIs(n, "catch")) end = Match(NextSig(Match(NextSig(n))));
                else if (SigIs(n, "finally")) end = Match(NextSig(n));
                else return end;
            }
        }
        int depth = 0;
        for (int j = i; j < t.Count; j++)
        {
            if (t[j].Is("(") || t[j].Is("[") || t[j].Is("{")) depth++;
            else if (t[j].Is(")") || t[j].Is("]") || t[j].Is("}")) depth--;
            else if (t[j].Is(";") && depth == 0) return j;
        }
        return t.Count - 1;
    }

    // ---------------------------------------------------------------- passes

    void RemovePackageAndImports()
    {
        for (int i = 0; i < t.Count; i++)
        {
            if ((t[i].Is("import") || t[i].Is("package")) && (i == 0 || t[i - 1].K == TK.WS && t[i - 1].T.Contains('\n') || i == 0))
            {
                int end = i;
                while (!t[end].Is(";")) end++;
                t.RemoveRange(i, end - i + 1);
                i--;
            }
        }
    }

    void RemoveSelfAssignThis()
    {
        for (int i = 0; i + 3 < t.Count; i++)
        {
            if (t[i].Is("this") && SigIs(NextSig(i), "=") && SigIs(NextSig(NextSig(i)), "this") && SigIs(NextSig(NextSig(NextSig(i))), ";"))
            {
                int end = NextSig(NextSig(NextSig(i)));
                t.RemoveRange(i, end - i + 1);
            }
        }
    }

    static readonly Regex LabelName = new(@"^label\d+$");

    void LabeledStatements()
    {
        for (int i = 0; i < t.Count; i++)
        {
            if (t[i].K != TK.Ident || !LabelName.IsMatch(t[i].T) || !SigIs(NextSig(i), ":")) continue;
            int p = PrevSig(i);
            if (p >= 0 && !(t[p].Is(";") || t[p].Is("{") || t[p].Is("}") || t[p].Is(":"))) continue;
            string label = t[i].T;
            int colon = NextSig(i);
            int stmt = NextSig(colon);
            int end = StatementEnd(stmt);
            bool usesBreak = false, usesCont = false;
            for (int j = stmt; j <= end; j++)
            {
                if ((t[j].Is("break") || t[j].Is("continue")) && SigIs(NextSig(j), label))
                {
                    bool cont = t[j].Is("continue");
                    if (cont) usesCont = true; else usesBreak = true;
                    int lab = NextSig(j);
                    t[j] = new Tok(TK.Ident, "goto");
                    t[lab] = new Tok(TK.Ident, label + (cont ? "_cont" : "_brk"));
                }
            }
            if (usesBreak) Insert(end + 1, $" {label}_brk:;");
            if (usesCont)
            {
                int bodyClose;
                if (t[stmt].Is("do")) bodyClose = Match(NextSig(stmt));
                else if (t[stmt].Is("for") || t[stmt].Is("while")) bodyClose = Match(NextSig(Match(NextSig(stmt))));
                else throw new Exception($"{unit.ClassName}: continue {label} on non-loop");
                Insert(bodyClose, $"{label}_cont:; ");
            }
            t.RemoveRange(i, colon - i + 1);
        }
    }

    void SwitchFallthrough()
    {
        var switches = new List<int>();
        for (int i = 0; i < t.Count; i++)
            if (t[i].Is("switch")) switches.Add(i);
        switches.Reverse();
        var terminators = new HashSet<string> { "break", "return", "continue", "throw", "goto" };
        foreach (int sw in switches)
        {
            int open = NextSig(Match(NextSig(sw)));
            int close = Match(open);
            // Collect labels at depth 0 of the body.
            var labels = new List<(int start, int end, string expr)>();
            int depth = 0;
            for (int j = open + 1; j < close; j++)
            {
                if (t[j].Is("(") || t[j].Is("[") || t[j].Is("{")) depth++;
                else if (t[j].Is(")") || t[j].Is("]") || t[j].Is("}")) depth--;
                else if (depth == 0 && (t[j].Is("case") || t[j].Is("default")))
                {
                    int c = j;
                    while (!t[c].Is(":")) c++;
                    string expr = t[j].Is("default") ? null : Text(j + 1, c).Trim();
                    labels.Add((j, c, expr));
                    j = c;
                }
            }
            // Walk sections back to front so insertions do not shift earlier indices.
            for (int li = labels.Count; li >= 1; li--)
            {
                int sectionEndExclusive = li < labels.Count ? labels[li].start : close;
                int last = PrevSig(sectionEndExclusive);
                if (last <= labels[li - 1].end)
                {
                    // Empty section: stacked labels are fine, but C# needs a jump after a trailing empty label.
                    if (li == labels.Count) Insert(labels[li - 1].end + 1, " break;");
                    continue;
                }
                if (IsTerminated(last, labels[li - 1].end, terminators)) continue;
                string jump = li < labels.Count
                    ? (labels[li].expr == null ? "goto default;" : $"goto case {labels[li].expr};")
                    : "break;";
                Insert(last + 1, " " + jump);
            }
        }
    }

    bool IsTerminated(int last, int sectionStart, HashSet<string> terminators)
    {
        if (!t[last].Is(";")) return false;
        int depth = 0, j = last - 1;
        for (; j > sectionStart; j--)
        {
            if (t[j].Is(")") || t[j].Is("]")) depth++;
            else if (t[j].Is("(") || t[j].Is("[")) depth--;
            else if (depth == 0 && (t[j].Is(";") || t[j].Is("{") || t[j].Is("}"))) break;
        }
        int first = NextSig(j);
        return terminators.Contains(t[first].T) && t[first].K == TK.Ident;
    }

    void ArrayCreation()
    {
        for (int i = 0; i < t.Count; i++)
        {
            if (!t[i].Is("new")) continue;
            int ty = NextSig(i);
            if (t[ty].K != TK.Ident) continue;
            int p = NextSig(ty);
            var sizes = new List<string>();
            int emptyDims = 0;
            int end = ty;
            while (SigIs(p, "["))
            {
                int q = Match(p);
                string inner = Text(p + 1, q).Trim();
                if (inner.Length == 0) emptyDims++;
                else if (emptyDims == 0) sizes.Add(inner);
                end = q;
                p = NextSig(q);
            }
            int totalDims = sizes.Count + emptyDims;
            if (totalDims == 0) continue;
            string elem = t[ty].T;
            if (sizes.Count >= 2)
            {
                string elemType = elem + string.Concat(Enumerable.Repeat("[]", emptyDims));
                string call = $"JArr.New{sizes.Count}<{elemType}>({string.Join(", ", sizes)})";
                t.RemoveRange(i, end - i + 1);
                Insert(i, call);
                continue;
            }
            if (sizes.Count == 0 && totalDims >= 2 && SigIs(p, "{"))
                FixNestedInitializer(p, elem, totalDims);
        }
    }

    /// <summary>Java allows {{1},{2}} for jagged arrays; C# needs explicit 'new T[]' on inner initializers.</summary>
    void FixNestedInitializer(int open, string elem, int dims)
    {
        if (dims < 2) return;
        string innerType = "new " + elem + string.Concat(Enumerable.Repeat("[]", dims - 1)) + " ";
        int close = Match(open);
        int depth = 0;
        var innerOpens = new List<int>();
        for (int j = open + 1; j < close; j++)
        {
            if (t[j].Is("{"))
            {
                if (depth == 0 && !SigIs(PrevSig(j), "]")) innerOpens.Add(j);
                depth++;
            }
            else if (t[j].Is("}")) depth--;
            else if (t[j].Is("(")) depth++;
            else if (t[j].Is(")")) depth--;
        }
        for (int k = innerOpens.Count - 1; k >= 0; k--)
        {
            int at = innerOpens[k];
            FixNestedInitializer(at, elem, dims - 1);
            Insert(at, innerType);
        }
    }

    static readonly HashSet<string> ShiftStops = new() { "<", ">", "<=", ">=", "==", "!=", "&", "^", "|", "&&", "||", "<<", ">>", ">>>", "?", ":", ",", ";", "=", "+=", "-=", "*=", "/=", "%=", "&=", "|=", "^=", "<<=", ">>=", ">>>=", "return", "instanceof" };

    void UnsignedShift()
    {
        for (int i = 0; i < t.Count; i++)
        {
            if (t[i].Is(">>>="))
            {
                int l = OperandStart(i);
                string target = Text(l, i).Trim();
                int r = OperandEnd(i);
                string rhs = Text(i + 1, r + 1).Trim();
                t.RemoveRange(l, r - l + 1);
                Insert(l, $"{target} = JOps.Ushr({target}, {rhs})");
                i = l;
                continue;
            }
            if (!t[i].Is(">>>")) continue;
            int ls = OperandStart(i), re = OperandEnd(i);
            string a = Text(ls, i).Trim(), b = Text(i + 1, re + 1).Trim();
            t.RemoveRange(ls, re - ls + 1);
            Insert(ls, $"JOps.Ushr({a}, {b})");
            i = ls;
        }
    }

    int OperandStart(int op)
    {
        int j = op - 1;
        while (j >= 0)
        {
            var k = t[j];
            if (k.Trivia) { j--; continue; }
            if (k.Is(")") || k.Is("]")) { j = MatchBack(j) - 1; continue; }
            if (k.Is("(") || k.Is("[") || k.Is("{") || k.Is("}") || (k.K != TK.String && ShiftStops.Contains(k.T))) break;
            j--;
        }
        return NextSig(j);
    }

    int OperandEnd(int op)
    {
        int j = op + 1, last = op;
        while (j < t.Count)
        {
            var k = t[j];
            if (k.Trivia) { j++; continue; }
            if (k.Is("(") || k.Is("[")) { last = j = Match(j); j++; continue; }
            if (k.Is(")") || k.Is("]") || k.Is("{") || k.Is("}") || (k.K != TK.String && ShiftStops.Contains(k.T))) break;
            last = j++;
        }
        return last;
    }

    void Literals()
    {
        for (int i = 0; i < t.Count; i++)
        {
            if (t[i].K != TK.Number) continue;
            string s = t[i].T;
            if (s.EndsWith("l")) t[i] = new Tok(TK.Number, s[..^1] + "L");
            else if ((s.StartsWith("0x") || s.StartsWith("0X")) && !s.EndsWith("L") && s.Length == 10 && "89abcdefABCDEF".IndexOf(s[2]) >= 0)
                t[i] = new Tok(TK.Number, $"unchecked((int){s})");
        }
    }

    /// <summary>
    /// Rewrites references to inherited fields that Vineflower left under their obfuscated names (see aliases).
    /// 'this.x' / bare 'x' resolve through the current class's ancestors; 'expr.x' resolves when the original
    /// name maps to exactly one renamed field in the program.
    /// </summary>
    void ResolveInheritedFields()
    {
        for (int i = 0; i < t.Count; i++)
        {
            var k = t[i];
            if (k.K != TK.Ident || JavaKeywords.Contains(k.T) || !model.FieldsByOrig.TryGetValue(k.T, out var candidates)) continue;
            int next = NextSig(i);
            if (SigIs(next, "(")) continue;
            int prev = PrevSig(i);
            bool dotted = SigIs(prev, ".");
            // Skip declarations/labels/parameters: an identifier preceded by a type-ish token is not a reference.
            if (!dotted && prev >= 0 && (t[prev].K == TK.Ident && !t[prev].Is("return") && !t[prev].Is("case") && !t[prev].Is("new") || t[prev].Is("]") && !SigIs(next, "["))) continue;
            string resolved = null;
            int recv = dotted ? PrevSig(prev) : -1;
            if (!dotted || t[recv].Is("this"))
                resolved = model.ResolveField(unit.ClassName, k.T);
            else if (t[recv].K == TK.Ident && model.Units.ContainsKey(t[recv].T) && !SigIs(PrevSig(recv), "."))
                resolved = model.ResolveField(t[recv].T, k.T);
            if (resolved == null && dotted)
            {
                var distinct = candidates.Select(c => c.renamed).Distinct().ToList();
                if (distinct.Count == 1) resolved = distinct[0];
                else Console.WriteLine($"  [{unit.ClassName}] ambiguous field '{k.T}' via '{t[recv].T}': {string.Join(", ", candidates.Select(c => c.cls + "." + c.renamed))}");
            }
            if (resolved != null) t[i] = new Tok(TK.Ident, resolved);
        }
    }

    /// <summary>
    /// Java instance field initializers may use 'this' and run after super(); C# forbids that, so such
    /// initializers are moved to the start of every constructor body (after an explicit super(...) call).
    /// </summary>
    void MoveInstanceInitializers()
    {
        int bodyOpen = 0;
        while (!t[bodyOpen].Is("{")) bodyOpen++;
        var assignments = new List<string>();
        int depth = 0, stmtStart = bodyOpen + 1;
        for (int i = bodyOpen + 1; i < t.Count; i++)
        {
            if (t[i].Is("{") || t[i].Is("(") || t[i].Is("[")) { depth++; continue; }
            if (t[i].Is("}") || t[i].Is(")") || t[i].Is("]"))
            {
                if (--depth < 0) break;
                if (depth == 0 && t[i].Is("}")) stmtStart = i + 1;
                continue;
            }
            if (depth != 0 || !t[i].Is(";")) continue;
            int eq = -1;
            bool isStatic = false, usesThis = false;
            for (int j = stmtStart; j < i; j++)
            {
                if (t[j].Is("static")) isStatic = true;
                if (eq < 0 && t[j].Is("=")) eq = j;
                if (eq >= 0 && t[j].Is("this")) usesThis = true;
                if (eq < 0 && t[j].Is("(")) { eq = -2; break; }
            }
            if (eq > 0 && !isStatic && usesThis)
            {
                string name = t[PrevSig(eq)].T;
                assignments.Add($"this.{name} = {Text(eq + 1, i).Trim()};");
                t.RemoveRange(eq, i - eq);
                while (t[eq - 1].K == TK.WS) { t.RemoveAt(eq - 1); eq--; }
                i = eq;
            }
            stmtStart = i + 1;
        }
        if (assignments.Count == 0) return;
        string block = " " + string.Join(" ", assignments) + " ";
        bool any = false;
        for (int i = t.Count - 1; i > bodyOpen; i--)
        {
            if (!t[i].Is(unit.ClassName) || !SigIs(NextSig(i), "(")) continue;
            int p = PrevSig(i);
            if (!(t[p].Is(";") || t[p].Is("{") || t[p].Is("}") || Modifiers.Contains(t[p].T))) continue;
            int body = NextSig(Match(NextSig(i)));
            if (!t[body].Is("{")) continue;
            any = true;
            int first = NextSig(body);
            if (t[first].Is("this") && SigIs(NextSig(first), "(")) continue; // chained ctor initializes via the other one
            int at = body + 1;
            if (t[first].Is("super") && SigIs(NextSig(first), "(")) at = NextSig(Match(NextSig(first))) + 1;
            Insert(at, block);
        }
        if (!any)
        {
            int close = Match(bodyOpen);
            Insert(close, $"\n   {unit.ClassName}() {{{block}}}\n");
        }
    }

    /// <summary>Moves a constructor's leading super(...)/this(...) call into a C# constructor initializer.</summary>
    void ConstructorInitializers()
    {
        for (int i = 0; i < t.Count; i++)
        {
            if (!t[i].Is(unit.ClassName) || !SigIs(NextSig(i), "(")) continue;
            int p = PrevSig(i);
            if (p < 0 || !(t[p].Is(";") || t[p].Is("{") || t[p].Is("}") || Modifiers.Contains(t[p].T))) continue;
            int bodyStart = NextSig(Match(NextSig(i)));
            if (!t[bodyStart].Is("{")) continue;
            int first = NextSig(bodyStart);
            if (!(t[first].Is("super") || t[first].Is("this")) || !SigIs(NextSig(first), "(")) continue;
            int cp = NextSig(first);
            int cpe = Match(cp);
            int semi = NextSig(cpe);
            string init = (t[first].Is("super") ? ": base" : ": this") + Text(cp, cpe + 1) + " ";
            t.RemoveRange(first, semi - first + 1);
            Insert(bodyStart, init);
        }
    }

    /// <summary>Rewrites modifiers of type members.</summary>
    void Members()
    {
        int bodyOpen = -1;
        for (int i = 0; i < t.Count; i++)
            if (t[i].Is("{")) { bodyOpen = i; break; }
        int bodyClose = Match(bodyOpen);
        bool constIface = model.IsConstantInterface(unit.ClassName);

        int pos = NextSig(bodyOpen);
        while (pos < bodyClose)
        {
            int start = pos;
            // Gather modifiers.
            var mods = new List<string>();
            int j = start;
            while (t[j].K == TK.Ident && Modifiers.Contains(t[j].T) && !(t[j].Is("static") && SigIs(NextSig(j), "{")))
            {
                mods.Add(t[j].T);
                j = NextSig(j);
            }
            // Static initializer.
            if (t[j].Is("static") && SigIs(NextSig(j), "{"))
            {
                int blk = NextSig(j);
                int end = Match(blk);
                t.RemoveRange(start, blk - start);
                Insert(start, $"static {unit.ClassName}() ");
                bodyClose = Match(bodyOpen);
                pos = NextSig(Match(NextSig(start + 4)));
                continue;
            }
            // Find the end of the member: '{...}' body or ';' at depth 0, noting a '(' before '=' (method).
            int k = j, depth = 0;
            bool isMethod = false, sawAssign = false;
            int nameIdx = -1;
            for (; k < bodyClose; k++)
            {
                if (t[k].Trivia) continue;
                if (depth == 0 && t[k].Is("=")) sawAssign = true;
                if (depth == 0 && t[k].Is("(") && !sawAssign && !isMethod)
                {
                    isMethod = true;
                    nameIdx = PrevSig(k);
                }
                if (t[k].Is("(") || t[k].Is("[")) depth++;
                else if (t[k].Is(")") || t[k].Is("]")) depth--;
                else if (t[k].Is("{"))
                {
                    if (isMethod && depth == 0) { k = Match(k); break; }
                    depth++;
                }
                else if (t[k].Is("}")) depth--;
                else if (t[k].Is(";") && depth == 0) break;
            }
            int memberEnd = k;
            string prefix;
            if (unit.IsInterface && !constIface)
            {
                prefix = isMethod ? "" : "public static ";
            }
            else if (constIface)
            {
                prefix = "public static ";
            }
            else
            {
                var sb = new StringBuilder();
                if (mods.Contains("synchronized") && isMethod)
                    sb.Append("[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)] ");
                sb.Append("public ");
                if (mods.Contains("static")) sb.Append("static ");
                if (isMethod && nameIdx >= 0 && t[nameIdx].T != unit.ClassName)
                {
                    int paren = NextSig(nameIdx);
                    int pclose = Match(paren);
                    string pars = Text(paren + 1, pclose).Trim();
                    int arity = pars.Length == 0 ? 0 : pars.Split(',').Length;
                    bool isAbstract = mods.Contains("abstract");
                    var d = mods.Contains("static") ? null : model.Dispatch(unit, t[nameIdx].T, arity, isAbstract);
                    if (d != null) sb.Append(d + " ");
                    else if (isAbstract) sb.Append("abstract ");
                }
                prefix = sb.ToString();
            }
            int oldLen = t.Count;
            t.RemoveRange(start, j - start);
            Insert(start, prefix);
            int delta = t.Count - oldLen;
            bodyClose = Match(bodyOpen);
            pos = NextSig(memberEnd + delta);
        }
    }

    void ClassHeader()
    {
        int i = 0;
        while (!(t[i].Is("class") || t[i].Is("interface"))) i++;
        int start = i;
        while (start > 0 && !(t[start - 1].K == TK.WS && t[start - 1].T.Contains('\n')) && start - 1 >= 0 && t[start - 1].K != TK.Comment) start--;
        int open = i;
        while (!t[open].Is("{")) open++;
        string name = unit.ClassName;
        string head;
        if (unit.IsInterface && !unit.HasMethods)
        {
            head = $"public static class {name}";
        }
        else if (unit.IsInterface)
        {
            var bases = unit.Implements.Where(b => !model.IsConstantInterface(b)).ToList();
            foreach (var b in unit.Implements.Where(model.IsConstantInterface)) usingStatics.Add(b);
            head = $"public interface {name}" + (bases.Count > 0 ? " : " + string.Join(", ", bases) : "");
        }
        else
        {
            var bases = new List<string>();
            if (unit.Extends != null) bases.Add(unit.Extends);
            foreach (var b in unit.Implements)
            {
                if (model.IsConstantInterface(b)) usingStatics.Add(b);
                else bases.Add(b);
            }
            head = "public " + (unit.IsAbstract ? "abstract " : "") + "class " + name + (bases.Count > 0 ? " : " + string.Join(", ", bases) : "");
        }
        t.RemoveRange(start, open - start);
        Insert(start, head + " ");

        // Static constructor gives Java-like lazy static initialization order (no beforefieldinit).
        if (!unit.IsInterface || !unit.HasMethods)
        {
            int bodyOpen = start;
            while (!t[bodyOpen].Is("{")) bodyOpen++;
            string all = string.Concat(t.Select(x => x.T));
            if (!all.Contains($"static {name}()"))
                Insert(bodyOpen + 1, $"\n   static {name}() {{ }}\n");
        }
    }

    void Keywords()
    {
        for (int i = 0; i < t.Count; i++)
        {
            var k = t[i];
            if (k.K == TK.Op && k.T == "." && i + 1 < t.Count && t[i + 1].Is("length") && !SigIs(NextSig(i + 1), "("))
            {
                t[i + 1] = new Tok(TK.Ident, "Length");
                continue;
            }
            if (k.K != TK.Ident) continue;
            bool member = SigIs(PrevSig(i), ".");
            int nx = NextSig(i);
            bool dotAfter = SigIs(nx, ".");
            string s = k.T;
            if (member)
            {
                if (CsOnlyKeywords.Contains(s)) t[i] = new Tok(TK.Ident, "@" + s);
                continue;
            }
            switch (s)
            {
                case "String": t[i] = new Tok(TK.Ident, dotAfter ? "JString" : "string"); continue;
                case "Math": if (dotAfter) t[i] = new Tok(TK.Ident, "JMath"); continue;
                case "System": if (dotAfter && JavaSystemMembers.Contains(t[NextSig(nx)].T)) t[i] = new Tok(TK.Ident, "JSystem"); continue;
                case "Boolean": if (dotAfter) t[i] = new Tok(TK.Ident, "JBoolean"); continue;
                case "instanceof": t[i] = new Tok(TK.Ident, "is"); continue;
                case "super": t[i] = new Tok(TK.Ident, "base"); continue;
                case "final":
                case "transient":
                case "volatile":
                case "native":
                case "strictfp":
                    t.RemoveAt(i);
                    if (i < t.Count && t[i].K == TK.WS) t.RemoveAt(i);
                    i--;
                    continue;
                case "synchronized":
                    if (SigIs(nx, "(")) t[i] = new Tok(TK.Ident, "lock");
                    continue;
                case "new":
                    if (SigIs(nx, "String") && SigIs(NextSig(nx), "("))
                    {
                        t[i] = new Tok(TK.Ident, "JString.New");
                        t.RemoveRange(i + 1, nx - i);
                    }
                    continue;
            }
            if (TypeMap.TryGetValue(s, out var mapped)) { t[i] = new Tok(TK.Ident, mapped); continue; }
        }
    }
}
