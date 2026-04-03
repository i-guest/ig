using System;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Animations
{
	[StaticAccessor("AnimatorControllerPlayableBindings", StaticAccessorType.DoubleColon)]
	[NativeHeader("Modules/Animation/AnimatorInfo.h")]
	[NativeHeader("Modules/Animation/RuntimeAnimatorController.h")]
	[NativeHeader("Modules/Animation/Director/AnimatorControllerPlayable.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/Animator.bindings.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimatorControllerPlayable.bindings.h")]
	[RequiredByNativeCode]
	public struct AnimatorControllerPlayable : IPlayable, IEquatable<AnimatorControllerPlayable>
	{
		private PlayableHandle m_Handle;

		private static readonly AnimatorControllerPlayable m_NullPlayable;

		internal AnimatorControllerPlayable(PlayableHandle handle)
		{
			m_Handle = default(PlayableHandle);
		}

		public PlayableHandle GetHandle()
		{
			return default(PlayableHandle);
		}

		public void SetHandle(PlayableHandle handle)
		{
		}

		public bool Equals(AnimatorControllerPlayable other)
		{
			return false;
		}
	}
}
