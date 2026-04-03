using System.Runtime.InteropServices;
using UnityEngine.Animations;
using UnityEngine.Bindings;
using UnityEngine.Playables;

namespace UnityEngine.Experimental.Animations
{
	[StaticAccessor("AnimationPlayableOutputExtensionsBindings", StaticAccessorType.DoubleColon)]
	[NativeHeader("Modules/Animation/AnimatorDefines.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationPlayableOutputExtensions.bindings.h")]
	public static class AnimationPlayableOutputExtensions
	{
		public static void SetAnimationStreamSource(this AnimationPlayableOutput output, AnimationStreamSource streamSource)
		{
		}

		public static void SetSortingOrder(this AnimationPlayableOutput output, ushort sortingOrder)
		{
		}

		[NativeThrows]
		private static void InternalSetAnimationStreamSource(PlayableOutputHandle output, AnimationStreamSource streamSource)
		{
		}

		[NativeThrows]
		private static void InternalSetSortingOrder(PlayableOutputHandle output, int sortingOrder)
		{
		}

		private static void InternalSetAnimationStreamSource_Injected([In] ref PlayableOutputHandle output, AnimationStreamSource streamSource)
		{
		}

		private static void InternalSetSortingOrder_Injected([In] ref PlayableOutputHandle output, int sortingOrder)
		{
		}
	}
}
