using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Animations
{
	[NativeHeader("Modules/Animation/Director/AnimationStream.h")]
	[RequiredByNativeCode]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationStream.bindings.h")]
	[MovedFrom("UnityEngine.Experimental.Animations")]
	public struct AnimationStream
	{
		private uint m_AnimatorBindingsVersion;

		private IntPtr constant;

		private IntPtr input;

		private IntPtr output;

		private IntPtr workspace;

		private IntPtr inputStreamAccessor;

		private IntPtr animationHandleBinder;

		internal uint animatorBindingsVersion => 0u;

		public bool isValid => false;

		public float deltaTime => 0f;

		internal void CheckIsValid()
		{
		}

		[NativeMethod(IsThreadSafe = true)]
		private float GetDeltaTime()
		{
			return 0f;
		}
	}
}
