using System;
using System.Collections.Generic;

namespace J2ME.Audio
{
    /// <summary>
    /// Small procedural General-MIDI-ish synthesizer for Standard MIDI Files (format 0/1/2,
    /// also RIFF RMID wrapped). Output is interleaved stereo float in [-1, 1].
    /// Aimed at sounding like a pleasant phone ringtone synth, not an accurate GM bank.
    /// Never throws: malformed input yields partial or empty output.
    /// </summary>
    public static class MidiSynth
    {
        const int MaxVoices = 32;
        const double MaxSeconds = 480.0;     // hard cap against pathological files
        const double TailSeconds = 2.0;
        const int MaxEvents = 4000000;
        const float VoiceGain = 0.28f;
        const float MasterGain = 1.0f;

        // Timbre kinds
        const int KPiano = 0, KBell = 1, KOrgan = 2, KPluck = 3, KBass = 4, KStrings = 5,
                  KBrass = 6, KReed = 7, KPipe = 8, KLead = 9, KPad = 10, KDrum = 11;

        // Per GM family (program / 8) -> kind
        static readonly int[] FamilyKind =
        {
            KPiano, KBell, KOrgan, KPluck, KBass, KStrings, KStrings, KBrass,
            KReed, KPipe, KLead, KPad, KPad, KPluck, KBell, KPad
        };

        static readonly float[] KindGain =
        {
            1.0f,  // piano
            0.85f, // bell
            0.55f, // organ
            1.3f,  // pluck
            1.1f,  // bass
            0.65f, // strings
            0.6f,  // brass
            0.55f, // reed
            0.8f,  // pipe
            0.45f, // lead
            0.55f, // pad
            1.0f   // drum
        };

        const int SineSize = 4096;
        static readonly float[] SineTable = BuildSine();

        static float[] BuildSine()
        {
            float[] t = new float[SineSize + 1];
            for (int i = 0; i <= SineSize; i++)
                t[i] = (float)Math.Sin(2.0 * Math.PI * i / SineSize);
            return t;
        }

        struct Ev
        {
            public long Tick;
            public int Order;
            public byte Status;   // channel message status, or 0xFF for tempo
            public byte D1, D2;
            public int Tempo;
            public double Time;
        }

        sealed class EvComparer : IComparer<Ev>
        {
            public static readonly EvComparer Instance = new EvComparer();
            public int Compare(Ev a, Ev b)
            {
                if (a.Tick != b.Tick) return a.Tick < b.Tick ? -1 : 1;
                return a.Order.CompareTo(b.Order);
            }
        }

        // ================================================================== public API

        public static float[] Render(byte[] midi, int sampleRate, out int channels)
        {
            channels = 2;
            try
            {
                if (midi == null || midi.Length < 14)
                    return Array.Empty<float>();
                if (sampleRate < 4000) sampleRate = 4000;
                if (sampleRate > 192000) sampleRate = 192000;
                float[] r = RenderInternal(midi, sampleRate);
                return r ?? Array.Empty<float>();
            }
            catch (Exception)
            {
                return Array.Empty<float>();
            }
        }

        // ================================================================== parsing

        static float[] RenderInternal(byte[] d, int sr)
        {
            List<Ev> evs = new List<Ev>(1024);
            int division;
            if (!Parse(d, evs, out division))
                return null;

            evs.Sort(EvComparer.Instance);

            // Tempo map (global across tracks) -> absolute seconds.
            bool smpte = (division & 0x8000) != 0;
            double secPerTick;
            int ppq = division & 0x7FFF;
            if (smpte)
            {
                int fps = -(sbyte)(division >> 8);
                double rate = fps == 29 ? 29.97 : fps;
                if (rate <= 0) rate = 25;
                int tpf = division & 0xFF;
                if (tpf <= 0) tpf = 40;
                secPerTick = 1.0 / (rate * tpf);
            }
            else
            {
                if (ppq <= 0) ppq = 96;
                secPerTick = 0.5 / ppq;
            }

            double sec = 0;
            long lastTick = 0;
            double lastNoteTime = 0;
            double lastEndOfTrack = 0;
            int count = evs.Count;
            Ev[] arr = evs.ToArray();
            int usable = count;
            for (int i = 0; i < count; i++)
            {
                long dt = arr[i].Tick - lastTick;
                if (dt > 0) sec += dt * secPerTick;
                lastTick = arr[i].Tick;
                arr[i].Time = sec;
                if (sec > MaxSeconds) { usable = i; break; }
                if (arr[i].Status == 0xFF)
                {
                    if (!smpte && arr[i].Tempo > 0)
                        secPerTick = arr[i].Tempo / 1000000.0 / ppq;
                }
                else if (arr[i].Status == 0xFE)
                    lastEndOfTrack = sec;
                else
                    lastNoteTime = sec;
            }

            // Song length honours trailing rests up to the last End-Of-Track (matters for looping).
            double bodySeconds = Math.Max(lastNoteTime, Math.Min(lastEndOfTrack, lastNoteTime + 30.0));
            long bodySamples = (long)Math.Ceiling(bodySeconds * sr);
            long tailSamples = (long)(TailSeconds * sr);
            long totalFrames = bodySamples + tailSamples + 1;
            if (totalFrames * 2 > int.MaxValue - 64)
                return null;

            Synth s = new Synth(sr, (int)totalFrames);
            long pos = 0;
            for (int i = 0; i < usable; i++)
            {
                if (arr[i].Status >= 0xF0)
                    continue;
                long t = (long)(arr[i].Time * sr);
                if (t > bodySamples) t = bodySamples;
                if (t > pos)
                {
                    s.RenderSegment((int)pos, (int)t);
                    pos = t;
                }
                s.Apply(arr[i].Status, arr[i].D1, arr[i].D2);
            }

            // Trailing rest up to End-Of-Track (voices keep ringing through it).
            if (pos < bodySamples)
            {
                s.RenderSegment((int)pos, (int)bodySamples);
                pos = bodySamples;
            }

            // Tail: let releases ring out, capped.
            long end = Math.Min(totalFrames, pos + tailSamples);
            const int block = 256;
            while (pos < end && s.AnyActive())
            {
                long next = Math.Min(end, pos + block);
                s.RenderSegment((int)pos, (int)next);
                pos = next;
            }
            int frames = (int)Math.Max(1, pos);
            if (s.AnyActive())
                s.FadeOut(frames, (int)(0.03 * sr));

            s.Finish(frames);
            if (frames * 2 == s.Mix.Length)
                return s.Mix;
            float[] outBuf = new float[frames * 2];
            Array.Copy(s.Mix, outBuf, frames * 2);
            return outBuf;
        }

        static bool Parse(byte[] d, List<Ev> evs, out int division)
        {
            division = 96;
            int h = FindTag(d, "MThd", 0);
            if (h < 0)
                return false;
            if (h + 14 > d.Length)
                return false;
            long hlen = BE32(d, h + 4);
            int ntrks = BE16(d, h + 10);
            division = BE16(d, h + 12);
            if (division == 0) division = 96;

            long pos = h + 8 + ((hlen >= 6 && hlen < 1024) ? hlen : 6);
            int order = 0;
            int len = d.Length;
            int tracks = 0;
            while (pos + 8 <= len)
            {
                int p = (int)pos;
                // Blobs sliced from packed resource files often run into the next song: stop there.
                if (IsTag(d, p, "MThd"))
                    break;
                if (ntrks > 0 && tracks >= ntrks)
                    break;
                if (IsTag(d, p, "MTrk"))
                {
                    long tlen = BE32(d, p + 4);
                    int start = p + 8;
                    long tend = start + tlen;
                    int end = (tlen == 0 || tend > len) ? len : (int)tend;
                    ParseTrack(d, start, end, evs, ref order);
                    tracks++;
                    if (evs.Count >= MaxEvents) break;
                    if (tend > len || tlen == 0) break;
                    pos = tend;
                }
                else if (LooksLikeTag(d, p))
                {
                    long clen = BE32(d, p + 4);
                    long next = p + 8 + clen;
                    if (next > len) break;
                    pos = next;
                }
                else
                {
                    // Garbage between chunks: resync on next MTrk.
                    int f = FindTag(d, "MTrk", p + 1);
                    if (f < 0) break;
                    int nextHeader = FindTag(d, "MThd", p + 1);
                    if (nextHeader >= 0 && nextHeader < f) break;
                    pos = f;
                }
            }
            return true;
        }

        static void ParseTrack(byte[] d, int p, int end, List<Ev> evs, ref int order)
        {
            long tick = 0;
            int running = 0;
            while (p < end)
            {
                long delta;
                if (!ReadVlq(d, ref p, end, out delta))
                    return;
                tick += delta;
                if (p >= end)
                    return;
                int b = d[p];
                if (b == 0xFF)
                {
                    p++;
                    if (p >= end) return;
                    int type = d[p++];
                    long mlen;
                    if (!ReadVlq(d, ref p, end, out mlen)) return;
                    if (mlen > end - p) return;
                    if (type == 0x2F)
                    {
                        evs.Add(new Ev { Tick = tick, Order = order++, Status = 0xFE });
                        return;
                    }
                    if (type == 0x51 && mlen >= 3)
                    {
                        int tempo = (d[p] << 16) | (d[p + 1] << 8) | d[p + 2];
                        Ev e = new Ev { Tick = tick, Order = order++, Status = 0xFF, Tempo = tempo };
                        evs.Add(e);
                    }
                    p += (int)mlen;
                    continue;
                }
                if (b == 0xF0 || b == 0xF7)
                {
                    p++;
                    long slen;
                    if (!ReadVlq(d, ref p, end, out slen)) return;
                    if (slen > end - p) return;
                    p += (int)slen;
                    continue;
                }

                int status;
                if (b >= 0x80)
                {
                    p++;
                    if (b >= 0xF0)
                    {
                        // System common / realtime inside a file: skip its data bytes.
                        if (b == 0xF1 || b == 0xF3) p += 1;
                        else if (b == 0xF2) p += 2;
                        continue;
                    }
                    status = b;
                    running = b;
                }
                else
                {
                    if (running == 0)
                    {
                        p++; // stray data byte
                        continue;
                    }
                    status = running;
                }

                int hi = status & 0xF0;
                int dataLen = (hi == 0xC0 || hi == 0xD0) ? 1 : 2;
                if (p + dataLen > end)
                    return;
                int d1 = d[p] & 0x7F;
                int d2 = dataLen == 2 ? (d[p + 1] & 0x7F) : 0;
                p += dataLen;

                if (hi == 0xA0 || hi == 0xD0)
                    continue; // aftertouch: ignored
                if (evs.Count >= MaxEvents)
                    return;
                evs.Add(new Ev { Tick = tick, Order = order++, Status = (byte)status, D1 = (byte)d1, D2 = (byte)d2 });
            }
        }

        static bool ReadVlq(byte[] d, ref int p, int end, out long value)
        {
            value = 0;
            for (int i = 0; i < 4; i++)
            {
                if (p >= end) return false;
                int b = d[p++];
                value = (value << 7) | (long)(b & 0x7F);
                if ((b & 0x80) == 0) return true;
            }
            return true; // over-long VLQ: accept what we have
        }

        static bool IsTag(byte[] d, int p, string t)
        {
            if (p < 0 || p + 4 > d.Length) return false;
            return d[p] == t[0] && d[p + 1] == t[1] && d[p + 2] == t[2] && d[p + 3] == t[3];
        }

        static bool LooksLikeTag(byte[] d, int p)
        {
            if (p < 0 || p + 4 > d.Length) return false;
            for (int i = 0; i < 4; i++)
            {
                int c = d[p + i];
                if (!((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || (c >= '0' && c <= '9') || c == ' ' || c == '_'))
                    return false;
            }
            return true;
        }

        static int FindTag(byte[] d, string t, int start)
        {
            for (int i = Math.Max(0, start); i + 4 <= d.Length; i++)
                if (IsTag(d, i, t)) return i;
            return -1;
        }

        static long BE32(byte[] d, int p)
        {
            if (p + 4 > d.Length) return 0;
            return ((long)d[p] << 24) | ((long)d[p + 1] << 16) | ((long)d[p + 2] << 8) | d[p + 3];
        }

        static int BE16(byte[] d, int p)
        {
            if (p + 2 > d.Length) return 0;
            return (d[p] << 8) | d[p + 1];
        }

        // ================================================================== synth engine

        sealed class Channel
        {
            public int Program;
            public int Volume = 100;
            public int Expression = 127;
            public int Pan = 64;
            public bool Sustain;
            public int BendRaw = 8192;
            public float BendRange = 2f;
            public float BendFactor = 1f;
            public int RpnMsb = 127, RpnLsb = 127;

            public void Reset()
            {
                Expression = 127;
                Sustain = false;
                BendRaw = 8192;
                BendFactor = 1f;
                RpnMsb = 127;
                RpnLsb = 127;
            }

            public void UpdateBend()
            {
                float semis = (BendRaw - 8192) / 8192f * BendRange;
                BendFactor = (float)Math.Pow(2.0, semis / 12.0);
            }
        }

        sealed class Voice
        {
            public bool Active;
            public int Chan, Note, Kind;
            public long Age;
            public bool Released, Held;
            public float Vel;
            public float GainL, GainR;

            // oscillator
            public float Phase, Phase2, BaseInc, Inc, Inc2, Ratio2;
            public float P2Amp, P2Decay;

            // envelope
            public int Stage; // 0 attack, 1 decay, 2 sustain, 3 release
            public float Env, AttackInc, DecayCoef, Sustain, ReleaseCoef;

            // filter
            public float Lp1, Lp2, AMin, AMax, FEnv, FEnvCoef;

            // drum
            public float ToneAmp, ToneDecay, ToneInc, ToneEndInc, SweepCoef;
            public float NoiseAmp, NoiseDecay, NoiseHpA, NoiseLpA, NHp, NLp;
            public uint Rng = 0x9E3779B9u;

            // Karplus-Strong
            public float[] Ks;
            public int KsMask, KsW;
            public float KsPeriod, KsL, KsDecay;
        }

        sealed class Synth
        {
            public readonly float[] Mix;
            readonly int sr;
            readonly Voice[] voices = new Voice[MaxVoices];
            readonly Channel[] chans = new Channel[16];
            long ageCounter;
            readonly float gainSmooth;
            readonly int ksSize;
            uint seed = 0x12345678u;

            public Synth(int sampleRate, int frames)
            {
                sr = sampleRate;
                Mix = new float[frames * 2];
                gainSmooth = (float)(1.0 - Math.Exp(-1.0 / (0.004 * sr)));
                int need = sr / 25 + 8;
                ksSize = 64;
                while (ksSize < need) ksSize <<= 1;
                for (int i = 0; i < MaxVoices; i++)
                {
                    voices[i] = new Voice();
                    voices[i].Ks = new float[ksSize];
                    voices[i].KsMask = ksSize - 1;
                }
                for (int i = 0; i < 16; i++)
                    chans[i] = new Channel();
            }

            float Coef(double hz)
            {
                double max = sr * 0.45;
                if (hz > max) hz = max;
                if (hz < 10) hz = 10;
                return (float)(1.0 - Math.Exp(-2.0 * Math.PI * hz / sr));
            }

            float T60(double seconds)
            {
                if (seconds <= 0) return 0f;
                return (float)Math.Exp(-6.907755 / (seconds * sr));
            }

            float AttackStep(double seconds)
            {
                double n = seconds * sr;
                return n < 1 ? 1f : (float)(1.0 / n);
            }

            public bool AnyActive()
            {
                for (int i = 0; i < MaxVoices; i++)
                    if (voices[i].Active) return true;
                return false;
            }

            // ------------------------------------------------------------ events

            public void Apply(byte status, byte d1, byte d2)
            {
                int ch = status & 0x0F;
                Channel c = chans[ch];
                switch (status & 0xF0)
                {
                    case 0x80:
                        NoteOff(ch, d1);
                        break;
                    case 0x90:
                        if (d2 == 0) NoteOff(ch, d1);
                        else NoteOn(ch, d1, d2);
                        break;
                    case 0xB0:
                        Controller(ch, c, d1, d2);
                        break;
                    case 0xC0:
                        c.Program = d1;
                        break;
                    case 0xE0:
                        c.BendRaw = d1 | (d2 << 7);
                        c.UpdateBend();
                        ApplyBend(ch);
                        break;
                }
            }

            void Controller(int ch, Channel c, int cc, int v)
            {
                switch (cc)
                {
                    case 7: c.Volume = v; break;
                    case 10: c.Pan = v; break;
                    case 11: c.Expression = v; break;
                    case 64:
                    {
                        bool on = v >= 64;
                        if (c.Sustain && !on)
                        {
                            for (int i = 0; i < MaxVoices; i++)
                            {
                                Voice vo = voices[i];
                                if (vo.Active && vo.Chan == ch && vo.Held)
                                {
                                    vo.Held = false;
                                    Release(vo);
                                }
                            }
                        }
                        c.Sustain = on;
                        break;
                    }
                    case 101: c.RpnMsb = v; break;
                    case 100: c.RpnLsb = v; break;
                    case 99:
                    case 98:
                        c.RpnMsb = 127; c.RpnLsb = 127; // NRPN: disable RPN data entry
                        break;
                    case 6:
                        if (c.RpnMsb == 0 && c.RpnLsb == 0)
                        {
                            c.BendRange = Math.Min(v, 24);
                            c.UpdateBend();
                            ApplyBend(ch);
                        }
                        break;
                    case 38:
                        if (c.RpnMsb == 0 && c.RpnLsb == 0)
                        {
                            c.BendRange = (float)Math.Floor(c.BendRange) + v / 100f;
                            c.UpdateBend();
                            ApplyBend(ch);
                        }
                        break;
                    case 120: // all sound off
                    {
                        float fast = T60(0.01);
                        for (int i = 0; i < MaxVoices; i++)
                        {
                            Voice vo = voices[i];
                            if (vo.Active && vo.Chan == ch)
                            {
                                vo.Released = true;
                                vo.Held = false;
                                vo.Stage = 3;
                                vo.ReleaseCoef = fast;
                            }
                        }
                        break;
                    }
                    case 121:
                    {
                        bool wasSustain = c.Sustain;
                        c.Reset();
                        if (wasSustain)
                        {
                            for (int i = 0; i < MaxVoices; i++)
                            {
                                Voice vo = voices[i];
                                if (vo.Active && vo.Chan == ch && vo.Held) { vo.Held = false; Release(vo); }
                            }
                        }
                        ApplyBend(ch);
                        break;
                    }
                    case 123:
                    case 124:
                    case 125:
                    case 126:
                    case 127:
                        for (int i = 0; i < MaxVoices; i++)
                        {
                            Voice vo = voices[i];
                            if (vo.Active && vo.Chan == ch && !vo.Released && vo.Kind != KDrum)
                            {
                                vo.Held = false;
                                Release(vo);
                            }
                        }
                        break;
                }
            }

            void ApplyBend(int ch)
            {
                if (ch == 9) return;
                float f = chans[ch].BendFactor;
                for (int i = 0; i < MaxVoices; i++)
                {
                    Voice v = voices[i];
                    if (!v.Active || v.Chan != ch) continue;
                    if (v.Kind == KPluck)
                        v.KsL = ClampKsL(v.KsPeriod / f - 0.5f);
                    else
                    {
                        v.Inc = Math.Min(v.BaseInc * f, 0.45f);
                        v.Inc2 = Math.Min(v.Inc * v.Ratio2, 0.45f);
                    }
                }
            }

            float ClampKsL(float l)
            {
                if (l < 2f) l = 2f;
                if (l > ksSize - 6) l = ksSize - 6;
                return l;
            }

            void Release(Voice v)
            {
                if (v.Kind == KDrum) return;
                v.Released = true;
                v.Stage = 3;
            }

            void NoteOff(int ch, int note)
            {
                if (ch == 9) return; // percussion ignores note-off
                Channel c = chans[ch];
                for (int i = 0; i < MaxVoices; i++)
                {
                    Voice v = voices[i];
                    if (v.Active && v.Chan == ch && v.Note == note && !v.Released && !v.Held)
                    {
                        if (c.Sustain) v.Held = true;
                        else Release(v);
                    }
                }
            }

            Voice Allocate()
            {
                Voice best = null;
                for (int i = 0; i < MaxVoices; i++)
                    if (!voices[i].Active) return voices[i];
                // Steal: prefer released voices (quietest), else oldest.
                float bestLevel = float.MaxValue;
                for (int i = 0; i < MaxVoices; i++)
                {
                    Voice v = voices[i];
                    if (v.Released || v.Held)
                    {
                        float lvl = v.Kind == KDrum ? (v.ToneAmp + v.NoiseAmp) * v.Env : v.Env;
                        if (lvl < bestLevel) { bestLevel = lvl; best = v; }
                    }
                }
                if (best != null) return best;
                long oldest = long.MaxValue;
                for (int i = 0; i < MaxVoices; i++)
                {
                    if (voices[i].Age < oldest) { oldest = voices[i].Age; best = voices[i]; }
                }
                return best;
            }

            uint NextSeed()
            {
                seed ^= seed << 13; seed ^= seed >> 17; seed ^= seed << 5;
                return seed;
            }

            void NoteOn(int ch, int note, int vel)
            {
                Channel c = chans[ch];
                bool drum = ch == 9;

                if (!drum)
                {
                    // retrigger: release previous instance of this note
                    for (int i = 0; i < MaxVoices; i++)
                    {
                        Voice o = voices[i];
                        if (o.Active && o.Chan == ch && o.Note == note && !o.Released)
                        {
                            o.Held = false;
                            Release(o);
                        }
                    }
                }
                else if (note == 42 || note == 44)
                {
                    // closed/pedal hat chokes open hat
                    float fast = T60(0.04);
                    for (int i = 0; i < MaxVoices; i++)
                    {
                        Voice o = voices[i];
                        if (o.Active && o.Chan == 9 && o.Note == 46)
                        {
                            o.Released = true; o.Stage = 3; o.ReleaseCoef = fast;
                        }
                    }
                }

                Voice v = Allocate();
                float vn = vel / 127f;
                v.Active = true;
                v.Chan = ch;
                v.Note = note;
                v.Age = ++ageCounter;
                v.Released = false;
                v.Held = false;
                v.Lp1 = v.Lp2 = 0f;
                v.Phase = 0f;
                v.Phase2 = 0.25f;
                v.Rng = NextSeed() | 1u;

                if (drum)
                {
                    v.Kind = KDrum;
                    v.Vel = vn * (0.55f + 0.45f * vn);
                    SetupDrum(v, note);
                }
                else
                {
                    int kind = FamilyKind[(c.Program >> 3) & 15];
                    int prog = c.Program;
                    if (prog == 45 || prog == 46) kind = KPluck; // pizzicato, harp
                    if (prog == 47) kind = KBass;                // timpani
                    v.Kind = kind;
                    v.Vel = vn * (0.5f + 0.5f * vn);
                    SetupTonal(v, note, vn, c.BendFactor);
                }
                v.Vel *= KindGain[v.Kind];

                // start at the current target gain (no ramp-in)
                float tl, tr;
                TargetGain(c, out tl, out tr);
                v.GainL = tl * v.Vel;
                v.GainR = tr * v.Vel;
            }

            static void TargetGain(Channel c, out float l, out float r)
            {
                float vol = c.Volume / 127f;
                float ex = c.Expression / 127f;
                // softer than the GM square law: phone tunes often use low volume/velocity values
                float g = vol * (0.4f + 0.6f * vol) * ex * (0.4f + 0.6f * ex) * VoiceGain;
                float pan = c.Pan <= 0 ? 0f : (c.Pan >= 127 ? 1f : (c.Pan - 1) / 126f);
                // equal power, normalised so centre = 1 per side
                double a = pan * Math.PI * 0.5;
                l = (float)(Math.Cos(a) * 1.41421356) * g;
                r = (float)(Math.Sin(a) * 1.41421356) * g;
                if (l > 1.41421356f * g) l = 1.41421356f * g;
            }

            void SetupTonal(Voice v, int note, float vn, float bend)
            {
                double freq = 440.0 * Math.Pow(2.0, (note - 69) / 12.0);
                v.BaseInc = (float)(freq / sr);
                v.Inc = Math.Min(v.BaseInc * bend, 0.45f);
                v.Ratio2 = 1f;
                v.P2Amp = 0f;
                v.P2Decay = 1f;
                v.Env = 0f;
                v.Stage = 0;
                v.FEnv = 1f;
                v.FEnvCoef = 1f;

                double attack = 0.005, decay = 0.5, release = 0.1;
                float sustain = 1f;
                double cutHi, cutLo;

                switch (v.Kind)
                {
                    case KPiano:
                        attack = 0.002;
                        sustain = 0f;
                        decay = Math.Max(0.5, Math.Min(3.5, 1.0 + (84 - note) * 0.045));
                        release = 0.25;
                        cutHi = freq * (6 + 8 * vn); cutLo = freq * 2.2;
                        v.FEnvCoef = T60(0.9);
                        break;
                    case KBell:
                        attack = 0.001;
                        sustain = 0f;
                        decay = Math.Max(0.6, Math.Min(2.5, 1.2 + (84 - note) * 0.03));
                        release = 0.35;
                        v.Ratio2 = 4.0f;
                        v.P2Amp = 0.45f;
                        v.P2Decay = T60(0.25);
                        cutHi = cutLo = Math.Min(freq * 10, 8000);
                        break;
                    case KOrgan:
                        attack = 0.006; sustain = 1f; release = 0.06;
                        cutHi = cutLo = Math.Min(freq * 12, 7000);
                        break;
                    case KPluck:
                        SetupKs(v, note, freq, vn, bend);
                        return;
                    case KBass:
                        attack = 0.003; sustain = 0.45f; decay = 1.0; release = 0.08;
                        cutHi = freq * (5 + 6 * vn); cutLo = freq * 2.0;
                        v.FEnvCoef = T60(0.6);
                        break;
                    case KStrings:
                        attack = 0.09; sustain = 1f; release = 0.35;
                        v.Ratio2 = 1.0045f;
                        cutHi = cutLo = Math.Min(freq * 5, 5000);
                        break;
                    case KBrass:
                        attack = 0.03; sustain = 0.8f; decay = 0.6; release = 0.12;
                        cutHi = freq * 8; cutLo = freq * 3;
                        v.FEnvCoef = T60(0.9);
                        break;
                    case KReed:
                        attack = 0.02; sustain = 0.9f; decay = 0.3; release = 0.08;
                        cutHi = cutLo = Math.Min(freq * 4, 5000);
                        break;
                    case KPipe:
                        attack = 0.05; sustain = 1f; release = 0.12;
                        cutHi = cutLo = Math.Min(freq * 6, 6000);
                        break;
                    case KLead:
                        attack = 0.005; sustain = 0.85f; decay = 0.3; release = 0.08;
                        cutHi = cutLo = Math.Min(freq * 8, 7000);
                        break;
                    default: // KPad
                        attack = 0.35; sustain = 1f; release = 0.7;
                        v.Ratio2 = 1.006f;
                        cutHi = cutLo = Math.Min(freq * 3, 3500);
                        break;
                }

                v.Inc2 = Math.Min(v.Inc * v.Ratio2, 0.45f);
                v.AttackInc = AttackStep(attack);
                v.Sustain = sustain;
                v.DecayCoef = T60(decay);
                v.ReleaseCoef = T60(release);
                v.AMax = Coef(cutHi);
                v.AMin = Coef(cutLo);
            }

            void SetupKs(Voice v, int note, double freq, float vn, float bend)
            {
                double minF = (double)sr / (ksSize - 8);
                double f = freq;
                while (f < minF) f *= 2.0;
                v.KsPeriod = (float)(sr / f);
                v.KsL = ClampKsL(v.KsPeriod / bend - 0.5f);
                double t60 = Math.Max(0.6, Math.Min(4.0, 3.0 - (note - 40) * 0.035));
                v.KsDecay = (float)Math.Pow(10.0, -3.0 / (f * t60));

                int fill = (int)Math.Ceiling(v.KsL) + 4;
                if (fill > ksSize) fill = ksSize;
                float[] buf = v.Ks;
                uint r = v.Rng;
                float a = 0.25f + 0.65f * vn; // brightness by velocity
                float lp = 0f, sum = 0f;
                for (int i = 0; i < fill; i++)
                {
                    r ^= r << 13; r ^= r >> 17; r ^= r << 5;
                    float n = (int)r * (1f / 2147483648f);
                    lp += a * (n - lp);
                    buf[i] = lp;
                    sum += lp;
                }
                float mean = sum / fill;
                for (int i = 0; i < fill; i++) buf[i] = (buf[i] - mean) * 1.6f;
                v.Rng = r;
                v.KsW = fill;

                v.Env = 1f;
                v.Stage = 2;
                v.Sustain = 1f;
                v.AttackInc = 1f;
                v.DecayCoef = 1f;
                v.ReleaseCoef = T60(0.12);
                v.AMax = v.AMin = Coef(Math.Min(f * 10, 9000));
                v.FEnv = 1f;
                v.FEnvCoef = 1f;
            }

            void SetupDrum(Voice v, int n)
            {
                // defaults: short hi-passed noise
                double tf0 = 0, tf1 = 0, sweep = 0.03, toneT = 0.1, noiseT = 0.1;
                float toneAmp = 0f, noiseAmp = 0.3f;
                double hp = 4000, lp = 0; // 0 = no lowpass

                switch (n)
                {
                    case 35: case 36: // kick
                        tf0 = 170; tf1 = 48; sweep = 0.035; toneT = 0.4; toneAmp = 1.1f;
                        noiseAmp = 0.18f; noiseT = 0.02; hp = 0; lp = 3000;
                        break;
                    case 37: // side stick
                        tf0 = 820; tf1 = 700; toneT = 0.05; toneAmp = 0.45f;
                        noiseAmp = 0.4f; noiseT = 0.04; hp = 2000;
                        break;
                    case 38: case 40: // snare
                        tf0 = 230; tf1 = 180; sweep = 0.02; toneT = 0.12; toneAmp = 0.5f;
                        noiseAmp = 0.75f; noiseT = n == 38 ? 0.22 : 0.18; hp = 1200; lp = 9000;
                        break;
                    case 39: // clap
                        noiseAmp = 0.8f; noiseT = 0.25; hp = 900; lp = 3500;
                        break;
                    case 41: case 43: case 45: case 47: case 48: case 50: // toms
                    {
                        double f = 80.0 * Math.Pow(2.0, (n - 41) / 9.5);
                        tf0 = f * 1.6; tf1 = f; sweep = 0.05; toneT = 0.45; toneAmp = 0.95f;
                        noiseAmp = 0.12f; noiseT = 0.05; hp = 0; lp = 2500;
                        break;
                    }
                    case 42: noiseAmp = 0.45f; noiseT = 0.06; hp = 7000; break;  // closed hat
                    case 44: noiseAmp = 0.35f; noiseT = 0.08; hp = 7000; break;  // pedal hat
                    case 46: noiseAmp = 0.4f; noiseT = 0.45; hp = 7000; break;   // open hat
                    case 49: case 57: case 52: noiseAmp = 0.45f; noiseT = 1.6; hp = 4000; break; // crash/china
                    case 55: noiseAmp = 0.4f; noiseT = 0.8; hp = 5000; break;    // splash
                    case 51: case 59: // ride
                        noiseAmp = 0.22f; noiseT = 1.0; hp = 6000;
                        tf0 = tf1 = 3200; toneAmp = 0.1f; toneT = 0.8;
                        break;
                    case 53: // ride bell
                        tf0 = tf1 = 2400; toneAmp = 0.35f; toneT = 0.9;
                        noiseAmp = 0.15f; noiseT = 0.6; hp = 5000;
                        break;
                    case 54: noiseAmp = 0.4f; noiseT = 0.18; hp = 6000; break;   // tambourine
                    case 56: tf0 = tf1 = 560; toneAmp = 0.55f; toneT = 0.25; noiseAmp = 0f; break; // cowbell
                    case 58: noiseAmp = 0.3f; noiseT = 0.5; hp = 2000; break;    // vibraslap
                    case 60: case 61: case 62: case 63: case 64: case 65: case 66: case 67: case 68:
                    {
                        double[] fr = { 420, 320, 300, 280, 200, 450, 330, 900, 650 };
                        double f = fr[n - 60];
                        tf0 = f * 1.2; tf1 = f; sweep = 0.02;
                        toneT = n == 62 ? 0.1 : (n >= 67 ? 0.4 : 0.25);
                        toneAmp = 0.7f; noiseAmp = 0.08f; noiseT = 0.03; hp = 2000;
                        break;
                    }
                    case 69: case 70: noiseAmp = 0.35f; noiseT = 0.07; hp = 5000; break; // cabasa/maracas
                    case 71: tf0 = tf1 = 2400; toneAmp = 0.3f; toneT = 0.3; noiseAmp = 0f; break;
                    case 72: tf0 = tf1 = 2000; toneAmp = 0.3f; toneT = 0.6; noiseAmp = 0f; break;
                    case 73: noiseAmp = 0.3f; noiseT = 0.15; hp = 3000; break;
                    case 74: noiseAmp = 0.3f; noiseT = 0.35; hp = 3000; break;
                    case 75: tf0 = tf1 = 2500; toneAmp = 0.6f; toneT = 0.06; noiseAmp = 0f; break; // claves
                    case 76: tf0 = tf1 = 1800; toneAmp = 0.6f; toneT = 0.07; noiseAmp = 0f; break; // woodblock
                    case 77: tf0 = tf1 = 1400; toneAmp = 0.6f; toneT = 0.07; noiseAmp = 0f; break;
                    case 78: tf0 = 500; tf1 = 700; sweep = 0.05; toneAmp = 0.4f; toneT = 0.2; noiseAmp = 0f; break; // cuica
                    case 79: tf0 = 400; tf1 = 300; sweep = 0.05; toneAmp = 0.4f; toneT = 0.2; noiseAmp = 0f; break;
                    case 80: tf0 = tf1 = 4000; toneAmp = 0.25f; toneT = 0.15; noiseAmp = 0f; break; // triangle
                    case 81: tf0 = tf1 = 4000; toneAmp = 0.25f; toneT = 1.0; noiseAmp = 0f; break;
                    default:
                        if (n < 35) { noiseAmp = 0.3f; noiseT = 0.06; hp = 3000; tf0 = tf1 = 1000; toneAmp = 0.15f; toneT = 0.04; }
                        break;
                }

                double nyq = sr * 0.45;
                if (tf0 > nyq) tf0 = nyq;
                if (tf1 > nyq) tf1 = nyq;
                v.ToneInc = (float)(tf0 / sr);
                v.ToneEndInc = (float)(tf1 / sr);
                v.SweepCoef = (float)Math.Exp(-1.0 / (Math.Max(0.001, sweep) * sr));
                v.ToneAmp = toneAmp;
                v.ToneDecay = T60(toneT);
                v.NoiseAmp = noiseAmp;
                v.NoiseDecay = T60(noiseT);
                v.NoiseHpA = hp > 0 ? Coef(hp) : 0f;
                v.NoiseLpA = lp > 0 ? Coef(lp) : 1f;
                v.NHp = 0f;
                v.NLp = 0f;
                v.Env = 1f;
                v.Stage = 2;
                v.ReleaseCoef = T60(0.05);
            }

            // ------------------------------------------------------------ rendering

            public void RenderSegment(int from, int to)
            {
                if (to <= from) return;
                for (int i = 0; i < MaxVoices; i++)
                {
                    Voice v = voices[i];
                    if (!v.Active) continue;
                    Channel c = chans[v.Chan];
                    float tl, tr;
                    TargetGain(c, out tl, out tr);
                    tl *= v.Vel;
                    tr *= v.Vel;
                    if (v.Kind == KDrum) RenderDrum(v, from, to, tl, tr);
                    else if (v.Kind == KPluck) RenderKs(v, from, to, tl, tr);
                    else RenderTonal(v, from, to, tl, tr);
                }
            }

            static float Blep(float t, float dt)
            {
                if (t < dt)
                {
                    t /= dt;
                    return t + t - t * t - 1f;
                }
                if (t > 1f - dt)
                {
                    t = (t - 1f) / dt;
                    return t * t + t + t + 1f;
                }
                return 0f;
            }

            static float Sin(float t)
            {
                float x = t * SineSize;
                int i = (int)x;
                float f = x - i;
                i &= SineSize - 1;
                float a = SineTable[i];
                return a + (SineTable[i + 1] - a) * f;
            }

            static float Saw(float t, float dt)
            {
                return 2f * t - 1f - Blep(t, dt);
            }

            static float Square(float t, float dt)
            {
                float s = t < 0.5f ? 1f : -1f;
                float t2 = t + 0.5f;
                if (t2 >= 1f) t2 -= 1f;
                return s + Blep(t, dt) - Blep(t2, dt);
            }

            void RenderTonal(Voice v, int from, int to, float tl, float tr)
            {
                float[] mix = Mix;
                int kind = v.Kind;
                float phase = v.Phase, phase2 = v.Phase2, inc = v.Inc, inc2 = v.Inc2;
                float env = v.Env, att = v.AttackInc, dec = v.DecayCoef, sus = v.Sustain, rel = v.ReleaseCoef;
                int stage = v.Stage;
                float lp1 = v.Lp1, lp2 = v.Lp2, aMin = v.AMin, aRange = v.AMax - v.AMin, fenv = v.FEnv, fcoef = v.FEnvCoef;
                float p2a = v.P2Amp, p2d = v.P2Decay;
                float gl = v.GainL, gr = v.GainR, k = gainSmooth;
                bool alive = true;

                int idx = from * 2;
                for (int n = from; n < to; n++, idx += 2)
                {
                    float t = phase;
                    float s;
                    switch (kind)
                    {
                        case KPiano:
                        {
                            float tri = 4f * Math.Abs(t - 0.5f) - 1f;
                            s = 0.7f * tri + 0.3f * Square(t, inc);
                            break;
                        }
                        case KBell:
                            s = Sin(t) + p2a * Sin(phase2);
                            p2a *= p2d;
                            break;
                        case KOrgan:
                        {
                            float t2 = t * 2f; t2 -= (int)t2;
                            float t3 = t * 3f; t3 -= (int)t3;
                            float t4 = t * 4f; t4 -= (int)t4;
                            s = (Sin(t) + 0.5f * Sin(t2) + 0.3f * Sin(t3) + 0.2f * Sin(t4)) * 0.55f;
                            break;
                        }
                        case KBass:
                        case KBrass:
                            s = Saw(t, inc);
                            break;
                        case KStrings:
                        case KPad:
                            s = 0.5f * (Saw(t, inc) + Saw(phase2, inc2));
                            break;
                        case KReed:
                            s = 0.8f * Square(t, inc);
                            break;
                        case KPipe:
                            s = Sin(t) + 0.12f * (4f * Math.Abs(t - 0.5f) - 1f);
                            break;
                        default: // lead
                            s = 0.5f * (Square(t, inc) + Saw(t, inc));
                            break;
                    }

                    float a = aMin + aRange * fenv;
                    fenv *= fcoef;
                    lp1 += a * (s - lp1);
                    lp2 += a * (lp1 - lp2);

                    switch (stage)
                    {
                        case 0:
                            env += att;
                            if (env >= 1f) { env = 1f; stage = 1; }
                            break;
                        case 1:
                            env = sus + (env - sus) * dec;
                            if (sus <= 0f)
                            {
                                if (env < 1e-4f) alive = false;
                            }
                            else if (env - sus < 1e-4f) { env = sus; stage = 2; }
                            break;
                        case 3:
                            env *= rel;
                            if (env < 1e-4f) alive = false;
                            break;
                    }

                    gl += (tl - gl) * k;
                    gr += (tr - gr) * k;
                    float o = lp2 * env;
                    mix[idx] += o * gl;
                    mix[idx + 1] += o * gr;

                    phase += inc;
                    if (phase >= 1f) phase -= 1f;
                    phase2 += inc2;
                    if (phase2 >= 1f) phase2 -= 1f;

                    if (!alive) break;
                }

                v.Phase = phase; v.Phase2 = phase2;
                v.Env = env; v.Stage = stage;
                v.Lp1 = lp1; v.Lp2 = lp2; v.FEnv = fenv;
                v.P2Amp = p2a;
                v.GainL = gl; v.GainR = gr;
                if (!alive) v.Active = false;
            }

            void RenderKs(Voice v, int from, int to, float tl, float tr)
            {
                float[] mix = Mix;
                float[] buf = v.Ks;
                int mask = v.KsMask;
                int w = v.KsW;
                float L = v.KsL, dec = v.KsDecay * 0.5f;
                float env = v.Env, rel = v.ReleaseCoef;
                int stage = v.Stage;
                float lp1 = v.Lp1, a = v.AMax;
                float gl = v.GainL, gr = v.GainR, k = gainSmooth;
                bool alive = true;
                int li = (int)L;
                float fr = L - li;
                // read position rp = w - L = (w - li - 1) + (1 - fr)
                float f1 = 1f - fr; // weight toward the newer sample
                int quietRun = 0;

                int idx = from * 2;
                for (int n = from; n < to; n++, idx += 2)
                {
                    int i0 = w - li - 1; // older sample
                    float s0 = buf[i0 & mask];
                    float s1 = buf[(i0 + 1) & mask];
                    float sm = buf[(i0 - 1) & mask];
                    float x = s0 + (s1 - s0) * f1;   // y[w - L]
                    float y1 = sm + (s0 - sm) * f1;  // y[w - L - 1]
                    float y = dec * (x + y1);
                    buf[w & mask] = y;
                    w++;

                    lp1 += a * (y - lp1);

                    if (stage == 3)
                    {
                        env *= rel;
                        if (env < 1e-4f) alive = false;
                    }

                    gl += (tl - gl) * k;
                    gr += (tr - gr) * k;
                    float o = lp1 * env;
                    mix[idx] += o * gl;
                    mix[idx + 1] += o * gr;

                    // natural decay finished?
                    if (y < 1e-4f && y > -1e-4f) { if (++quietRun > 2 * li + 8) alive = false; }
                    else quietRun = 0;

                    if (!alive) break;
                }

                if (w > 0x40000000) w &= mask; // keep counter bounded (mask keeps alignment)
                v.KsW = w;
                v.Env = env; v.Stage = stage;
                v.Lp1 = lp1;
                v.GainL = gl; v.GainR = gr;
                if (!alive) v.Active = false;
            }

            void RenderDrum(Voice v, int from, int to, float tl, float tr)
            {
                float[] mix = Mix;
                float phase = v.Phase, inc = v.ToneInc, endInc = v.ToneEndInc, sw = v.SweepCoef;
                float ta = v.ToneAmp, td = v.ToneDecay;
                float na = v.NoiseAmp, nd = v.NoiseDecay, hpA = v.NoiseHpA, lpA = v.NoiseLpA;
                float nhp = v.NHp, nlp = v.NLp;
                uint r = v.Rng;
                float env = v.Env, rel = v.ReleaseCoef;
                bool releasing = v.Stage == 3;
                float gl = v.GainL, gr = v.GainR, k = gainSmooth;
                bool alive = true;

                int idx = from * 2;
                for (int n = from; n < to; n++, idx += 2)
                {
                    float tone = ta > 0f ? Sin(phase) * ta : 0f;
                    phase += inc;
                    if (phase >= 1f) phase -= 1f;
                    inc = endInc + (inc - endInc) * sw;
                    ta *= td;

                    r ^= r << 13; r ^= r >> 17; r ^= r << 5;
                    float nz = (int)r * (1f / 2147483648f);
                    nhp += hpA * (nz - nhp);
                    float h = nz - nhp;
                    nlp += lpA * (h - nlp);
                    float noise = nlp * na;
                    na *= nd;

                    if (releasing)
                    {
                        env *= rel;
                        if (env < 1e-4f) alive = false;
                    }

                    gl += (tl - gl) * k;
                    gr += (tr - gr) * k;
                    float o = (tone + noise) * env;
                    mix[idx] += o * gl;
                    mix[idx + 1] += o * gr;

                    if (ta + na < 1e-4f) alive = false;
                    if (!alive) break;
                }

                v.Phase = phase; v.ToneInc = inc; v.ToneAmp = ta; v.NoiseAmp = na;
                v.NHp = nhp; v.NLp = nlp; v.Rng = r; v.Env = env;
                v.GainL = gl; v.GainR = gr;
                if (!alive) v.Active = false;
            }

            public void FadeOut(int frames, int fadeLen)
            {
                if (fadeLen <= 0) return;
                if (fadeLen > frames) fadeLen = frames;
                int start = frames - fadeLen;
                for (int i = 0; i < fadeLen; i++)
                {
                    float g = 1f - (float)(i + 1) / fadeLen;
                    int idx = (start + i) * 2;
                    Mix[idx] *= g;
                    Mix[idx + 1] *= g;
                }
            }

            public void Finish(int frames)
            {
                // Master gain + soft knee limiter (linear below the knee, tanh above).
                const float knee = 0.6f;
                const float room = 1f - knee;
                int n = frames * 2;
                float[] m = Mix;
                // Gentle auto-gain for quiet tunes (max +12 dB) so jingles written with tiny
                // velocities stay audible; loud material is handled by the limiter below.
                float peak = 0f;
                for (int i = 0; i < n; i++)
                {
                    float a = m[i] < 0f ? -m[i] : m[i];
                    if (a > peak) peak = a;
                }
                float gain = MasterGain;
                if (peak * gain > 1e-6f && peak * gain < knee)
                    gain = Math.Min(gain * 4f, knee / peak);
                for (int i = 0; i < n; i++)
                {
                    float x = m[i] * gain;
                    float ax = x < 0f ? -x : x;
                    if (ax > knee)
                    {
                        float y = knee + room * (float)Math.Tanh((ax - knee) / room);
                        x = x < 0f ? -y : y;
                    }
                    else if (float.IsNaN(x))
                        x = 0f;
                    m[i] = x;
                }
            }
        }
    }
}
