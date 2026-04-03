using UnityEngine.Bindings;
using UnityEngine.Playables;

namespace UnityEngine.Animations
{
	[NativeHeader("Modules/Animation/Animator.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationPlayableGraphExtensions.bindings.h")]
	[NativeHeader("Runtime/Director/Core/HPlayableOutput.h")]
	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[StaticAccessor("AnimationPlayableGraphExtensionsBindings", StaticAccessorType.DoubleColon)]
	internal static class AnimationPlayableGraphExtensions
	{
		[NativeThrows]
		internal static bool InternalCreateAnimationOutput(ref PlayableGraph graph, string name, out PlayableOutputHandle handle)
		{
			handle = default(PlayableOutputHandle);
			return false;
		}

		private static bool InternalCreateAnimationOutput_Injected(ref PlayableGraph graph, ref ManagedSpanWrapper name, out PlayableOutputHandle handle)
		{
			handle = default(PlayableOutputHandle);
			return false;
		}
	}
}
