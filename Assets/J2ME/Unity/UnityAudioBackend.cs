using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

namespace J2ME.Unity
{
    /// <summary>
    /// IMidpAudio implementation. MIDP players run on game threads, but Unity audio APIs are main-thread only,
    /// so every call is queued and executed by Pump() from MidletPlayer.Update.
    /// </summary>
    sealed class UnityAudioBackend : IMidpAudio, IDisposable
    {
        readonly GameObject host;
        readonly ConcurrentQueue<Action> pending = new ConcurrentQueue<Action>();
        readonly Dictionary<int, AudioClip> clips = new Dictionary<int, AudioClip>();
        readonly Dictionary<int, AudioSource> sources = new Dictionary<int, AudioSource>();
        readonly Dictionary<int, float> stopAt = new Dictionary<int, float>();
        int nextId;

        public UnityAudioBackend(GameObject host) { this.host = host; }

        public int CreateClip(float[] samples, int channels, int sampleRate)
        {
            int id = Interlocked.Increment(ref nextId);
            pending.Enqueue(() =>
            {
                var clip = AudioClip.Create("midp_" + id, samples.Length / channels, channels, sampleRate, false);
                clip.SetData(samples, 0);
                clips[id] = clip;
            });
            return id;
        }

        public void Play(int clip, int loopCount, float volume)
        {
            pending.Enqueue(() =>
            {
                if (!clips.TryGetValue(clip, out var c)) return;
                var src = Source(clip);
                src.clip = c;
                src.loop = loopCount < 0 || loopCount > 1;
                src.volume = volume;
                src.Play();
                if (loopCount > 1) stopAt[clip] = Time.unscaledTime + c.length * loopCount;
                else stopAt.Remove(clip);
            });
        }

        public void Stop(int clip)
        {
            pending.Enqueue(() =>
            {
                if (sources.TryGetValue(clip, out var s)) s.Stop();
                stopAt.Remove(clip);
            });
        }

        public void SetVolume(int clip, float volume)
        {
            pending.Enqueue(() => { if (sources.TryGetValue(clip, out var s)) s.volume = volume; });
        }

        public void Release(int clip)
        {
            pending.Enqueue(() =>
            {
                if (sources.TryGetValue(clip, out var s)) { UnityEngine.Object.Destroy(s); sources.Remove(clip); }
                if (clips.TryGetValue(clip, out var c)) { UnityEngine.Object.Destroy(c); clips.Remove(clip); }
            });
        }

        AudioSource Source(int clip)
        {
            if (!sources.TryGetValue(clip, out var s))
            {
                s = host.AddComponent<AudioSource>();
                s.playOnAwake = false;
                s.spatialBlend = 0f;
                sources[clip] = s;
            }
            return s;
        }

        public void Pump()
        {
            while (pending.TryDequeue(out var a)) a();
            if (stopAt.Count == 0) return;
            var done = new List<int>();
            foreach (var kv in stopAt)
                if (Time.unscaledTime >= kv.Value) done.Add(kv.Key);
            foreach (var id in done)
            {
                if (sources.TryGetValue(id, out var s)) s.Stop();
                stopAt.Remove(id);
            }
        }

        public void Dispose()
        {
            foreach (var c in clips.Values) if (c != null) UnityEngine.Object.Destroy(c);
            clips.Clear();
            sources.Clear();
        }
    }
}
