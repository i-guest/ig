using UnityEngine.Bindings;
using UnityEngine.Playables;

namespace UnityEngine.Audio
{
	[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioPlayableGraphExtensions.bindings.h")]
	[StaticAccessor("AudioPlayableGraphExtensionsBindings", StaticAccessorType.DoubleColon)]
	[NativeHeader("Runtime/Director/Core/HPlayableOutput.h")]
	internal static class AudioPlayableGraphExtensions
	{
		[NativeThrows]
		internal static bool InternalCreateAudioOutput(ref PlayableGraph graph, string name, out PlayableOutputHandle handle)
		{
			handle = default(PlayableOutputHandle);
			return false;
		}

		private static bool InternalCreateAudioOutput_Injected(ref PlayableGraph graph, ref ManagedSpanWrapper name, out PlayableOutputHandle handle)
		{
			handle = default(PlayableOutputHandle);
			return false;
		}
	}
}
