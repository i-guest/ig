using System;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Animations
{
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationPlayableOutput.bindings.h")]
	[NativeHeader("Modules/Animation/Animator.h")]
	[NativeHeader("Runtime/Director/Core/HPlayableGraph.h")]
	[RequiredByNativeCode]
	[NativeHeader("Runtime/Director/Core/HPlayableOutput.h")]
	[NativeHeader("Modules/Animation/Director/AnimationPlayableOutput.h")]
	[StaticAccessor("AnimationPlayableOutputBindings", StaticAccessorType.DoubleColon)]
	public struct AnimationPlayableOutput : IPlayableOutput
	{
		private PlayableOutputHandle m_Handle;

		public static AnimationPlayableOutput Null => default(AnimationPlayableOutput);

		public static AnimationPlayableOutput Create(PlayableGraph graph, string name, Animator target)
		{
			return default(AnimationPlayableOutput);
		}

		internal AnimationPlayableOutput(PlayableOutputHandle handle)
		{
			m_Handle = default(PlayableOutputHandle);
		}

		public PlayableOutputHandle GetHandle()
		{
			return default(PlayableOutputHandle);
		}

		public static implicit operator PlayableOutput(AnimationPlayableOutput output)
		{
			return default(PlayableOutput);
		}

		public static explicit operator AnimationPlayableOutput(PlayableOutput output)
		{
			return default(AnimationPlayableOutput);
		}

		public Animator GetTarget()
		{
			return null;
		}

		public void SetTarget(Animator value)
		{
		}

		[NativeThrows]
		private static Animator InternalGetTarget(ref PlayableOutputHandle handle)
		{
			return null;
		}

		[NativeThrows]
		private static void InternalSetTarget(ref PlayableOutputHandle handle, Animator target)
		{
		}

		private static IntPtr InternalGetTarget_Injected(ref PlayableOutputHandle handle)
		{
			return (IntPtr)0;
		}

		private static void InternalSetTarget_Injected(ref PlayableOutputHandle handle, IntPtr target)
		{
		}
	}
}
