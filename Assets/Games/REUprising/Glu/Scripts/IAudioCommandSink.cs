// Transpiled from Java (IAudioCommandSink.java) by Tools/J2meToCs. Regenerate rather than hand-edit where possible.
#pragma warning disable CS0162, CS0164, CS0168, CS0169, CS0219, CS0414, CS0649, CS1717, CS0108, CS0659, CS0661
using J2ME;

namespace REUprising.Glu
{
// $VF: renamed from: o
public interface IAudioCommandSink {
   // $VF: renamed from: a (byte[], byte[], byte[], byte[]) void
   void configureCueMetadata(sbyte[] var1, sbyte[] var2, sbyte[] var3, sbyte[] var4);

   // $VF: renamed from: a (byte[]) void
   void setCueVolumeLevels(sbyte[] var1);

   // $VF: renamed from: d (byte) void
   void setMasterVolume(sbyte var1);

   // $VF: renamed from: a (byte) void
   void enqueueAudioCommand(sbyte var1);

   // $VF: renamed from: b (byte) void
   void requestCuePlayback(sbyte var1);

   // $VF: renamed from: a () void
   void processNextAudioCommand();

   // $VF: renamed from: c () void
   void disposeAllPlayers();

   // $VF: renamed from: c (byte) void
   void stopCuePlayback(sbyte var1);
}
}
