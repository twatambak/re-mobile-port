# Resident Evil: Uprising — J2ME → Unity port

The original MIDlets are not rewritten by hand. Their bytecode is decompiled, transpiled to C#, and run on a
small MIDP 2.0 emulation layer that draws into a software framebuffer which Unity displays. Game logic,
timing, RNG, and asset decoding are therefore the original game's code.

Two distinct games are covered by the JARs in `Assets/Resident Evil Uprising/`:

| Build | JARs (identical code) | Canvas | Scene |
|---|---|---|---|
| Gameloft, v1.0.8, touch | `resident_evil_upris_261905.jar` (360x640) | 360x640 | `Assets/Scenes/REUprising_Gameloft.unity` |
| Glu/Capcom "LE", MIDP 1.0 | `resevil5no_7jru8s6d.jar`, `resident_evil_upris_360x640_138613.jar` | 360x384 (Nokia 5800 with on-screen keypad) | `Assets/Scenes/REUprising_GluLE.unity` |

`residentevil_uprisin_153621.jar` is the 240x400 Gameloft build: the same code as the 360x640 one
apart from layout constants. It is not wired up; the 360x640 build is the one ported.

## Layout

```
Assets/J2ME/Runtime/        MIDP/CLDC emulation, engine-free (asmdef: noEngineReferences)
  Lang.cs Util.cs IO.cs       java.lang / java.util / java.io
  Graphics.cs Image.cs        software rasterizer (clip, translate, anchors, drawRegion transforms, alpha)
  PngDecoder.cs Font.cs       lenient PNG decoder; bitmap system font (FontData.cs is generated)
  Lcdui.cs Midp.cs            Display/Canvas/MIDlet, MIDP event thread, presented framebuffer
  Rms.cs Media.cs             RecordStore (files under persistentDataPath), MMAPI Player
  Audio/                      WAV decoder + General MIDI software synth
Assets/J2ME/Unity/          MidletPlayer (display + input), UnityAudioBackend
Assets/Games/REUprising/    transpiled games (asmdef REUprising.Games) + JARs as .bytes TextAssets
Tools/J2meToCs/             Java → C# converter
Tools/Decompiled/           Vineflower output used as converter input (with hand fixes, below)
Tools/Harness/              headless runner (boots a JAR, scripts keys/taps, dumps PNG frames)
```

## Controls (MidletPlayer)

Arrows = D-pad, Enter/Space = fire, Q/F1 = left soft key, E/F2/Esc = right soft key, digit keys and numpad = keypad,
Z = `*`, X = `#`, WASD = 2/4/6/8. Mouse and touch become pointer events when `pointerEvents` is enabled.

## Regenerating the C# sources

1. Decompile with Vineflower 1.10.1 (`-dgs=1 -ren=1 -vvm=1`) into `Tools/Decompiled/<game>`.
2. Re-apply the hand fixes listed below.
3. Run the converter:
   `dotnet run --project Tools/J2meToCs -c Release -- Tools/Decompiled/Gameloft360 Assets/Games/REUprising/Gameloft/Scripts REUprising.Gameloft`
   `dotnet run --project Tools/J2meToCs -c Release -- Tools/Decompiled/GluLE Assets/Games/REUprising/Glu/Scripts REUprising.Glu --aliases`
   (`--aliases` works around Vineflower not renaming references to inherited members, which only the Glu class
   hierarchy needs.)
4. `dotnet build Tools/Harness/Core` (netstandard2.1 / C# 9, the same constraints as Unity) must report 0 errors.
5. Smoke test, for example:
   `dotnet run --project Tools/Harness/Runner -- gameloft <jar> <outDir> "wait:3000;key:-3;key:-5;wait:5000;shot:title"`
   Set `J2ME_FCE=1` to print every exception, including ones the game swallows.
   Also run it under Unity's Mono (`Editor/Data/MonoBleedingEdge/bin/mono.exe Tools/Harness/Runner/bin/Debug/net48/Runner.exe ...`):
   Mono differs from CoreCLR, e.g. it rejects reinterpreting `byte[]` as `sbyte[]`, so use `ByteConv` for conversions.

## Hand fixes in Tools/Decompiled (decompiler errors)

The obfuscator reuses JVM local slots across types, and Vineflower sometimes merges variables. Each fix
was checked against CFR 0.152's output of the same method.

Gameloft360:
- `class_11.method_15`, `class_17.method_65`, `class_21.method_114`, `class_27.method_187/214/234/352`: a boolean
  parameter slot reused as an int, split into a new `int` local (`varNi`).
- `class_17.method_50`, `class_27.method_172/238/285/303`, `class_27.method_308 (var71)`: boolean/int confusion,
  re-expressed with 0/1 ints (`!= 0`, `? 1 : 0`).
- `class_17.method_54`: `(Object[])` cast should be `(byte[])`. `class_21.method_117`: `(Object[])null` should be `(char[])null`.
- `class_21.method_84` (sprite loader): one read cursor had been split into `var4`/`var69`, now merged; the
  start offset of `var4` is fixed; `var122` widened from `short` to `int` (it holds file offsets).
- `class_21.method_114/116/117/118`: `char` locals that hold glyph indices widened to `int`.
- `class_27.method_236`: the sprite id and the x position had been merged into `var6` (`var6x` split out). This
  caused an out-of-bounds crash on entering gameplay.
- `class_27.method_187`, `method_280`, `method_290`: byte locals/params widened to int, with explicit `(byte)` stores.
- `class_27.method_261`: dead `var3 = 1000` store removed. `class_17.method_40`: `append(null)` became `append((String)null)`.

GluLE: no hand fixes; converter features only (`--aliases`, moving instance initializers that use `this`).

## Known limitations

- 8 Gameloft sound effects are AMR-NB, which has no decoder here, so they are silent. All WAV and MIDI audio plays.
- The MIDI synth is procedural, so music sounds like a generic phone synth rather than a specific handset.
- The Glu build has no pointer support (MIDP 1.0), so it needs a keyboard or a future on-screen keypad on touch devices.
- Game statics live in the C# types. Keep Unity's "Reload Domain" enabled on entering Play Mode, or the
  second Play session starts with stale state.
- The original `.jar` files under `Assets/Resident Evil Uprising/` are imported by Unity as Android plugin libraries.
  Exclude them from Android builds (or move them out of `Assets/`); the game loads its own `.bytes` copies.
