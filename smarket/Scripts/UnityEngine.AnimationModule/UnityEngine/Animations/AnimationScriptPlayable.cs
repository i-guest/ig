using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Animations
{
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationScriptPlayable.bindings.h")]
	[RequiredByNativeCode]
	[MovedFrom("UnityEngine.Experimental.Animations")]
	[StaticAccessor("AnimationScriptPlayableBindings", StaticAccessorType.DoubleColon)]
	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[NativeHeader("Runtime/Director/Core/HPlayableGraph.h")]
	public struct AnimationScriptPlayable : IPlayable, IEquatable<AnimationScriptPlayable>
	{
		private PlayableHandle m_Handle;

		private static readonly AnimationScriptPlayable m_NullPlayable;

		public static AnimationScriptPlayable Create<T>(PlayableGraph graph, T jobData, int inputCount = 0) where T : struct
		{
			return default(AnimationScriptPlayable);
		}

		private static PlayableHandle CreateHandle<T>(PlayableGraph graph, int inputCount) where T : struct
		{
			return default(PlayableHandle);
		}

		internal AnimationScriptPlayable(PlayableHandle handle)
		{
			m_Handle = default(PlayableHandle);
		}

		public PlayableHandle GetHandle()
		{
			return default(PlayableHandle);
		}

		private void CheckJobTypeValidity<T>()
		{
		}

		public void SetJobData<T>(T jobData) where T : struct
		{
		}

		public static implicit operator Playable(AnimationScriptPlayable playable)
		{
			return default(Playable);
		}

		public bool Equals(AnimationScriptPlayable other)
		{
			return false;
		}

		[NativeThrows]
		private static bool CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle, IntPtr jobReflectionData)
		{
			return false;
		}

		private static bool CreateHandleInternal_Injected([In] ref PlayableGraph graph, ref PlayableHandle handle, IntPtr jobReflectionData)
		{
			return false;
		}
	}
}
