using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[Serializable]
	[RequiredByNativeCode]
	internal struct AnimationEventBlittable : IDisposable
	{
		internal float m_Time;

		internal IntPtr m_FunctionName;

		internal IntPtr m_StringParameter;

		internal IntPtr m_ObjectReferenceParameter;

		internal float m_FloatParameter;

		internal int m_IntParameter;

		internal int m_MessageOptions;

		internal AnimationEventSource m_Source;

		internal IntPtr m_StateSender;

		internal AnimatorStateInfo m_AnimatorStateInfo;

		internal AnimatorClipInfo m_AnimatorClipInfo;

		[ThreadStatic]
		private static GCHandlePool s_handlePool;

		[RequiredByNativeCode]
		internal static AnimationEvent PointerToAnimationEvent(IntPtr animationEventBlittable)
		{
			return null;
		}

		internal static AnimationEvent ToAnimationEvent(AnimationEventBlittable animationEventBlittable)
		{
			return null;
		}

		public void Dispose()
		{
		}
	}
}
