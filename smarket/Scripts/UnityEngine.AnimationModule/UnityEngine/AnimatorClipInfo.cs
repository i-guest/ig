using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[NativeHeader("Modules/Animation/AnimatorInfo.h")]
	[UsedByNativeCode]
	[NativeHeader("Modules/Animation/ScriptBindings/Animation.bindings.h")]
	public struct AnimatorClipInfo
	{
		private int m_ClipInstanceID;

		private float m_Weight;

		public AnimationClip clip => null;

		public float weight => 0f;

		[FreeFunction("AnimationBindings::InstanceIDToAnimationClipPPtr")]
		private static AnimationClip InstanceIDToAnimationClipPPtr(EntityId entityId)
		{
			return null;
		}

		private static IntPtr InstanceIDToAnimationClipPPtr_Injected([In] ref EntityId entityId)
		{
			return (IntPtr)0;
		}
	}
}
