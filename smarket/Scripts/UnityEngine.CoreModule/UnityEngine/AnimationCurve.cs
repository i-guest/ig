using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[StructLayout((LayoutKind)0)]
	[RequiredByNativeCode]
	[NativeHeader("Runtime/Math/AnimationCurve.bindings.h")]
	public class AnimationCurve : IEquatable<AnimationCurve>
	{
		internal static class BindingsMarshaller
		{
			public static IntPtr ConvertToNative(AnimationCurve animationCurve)
			{
				return (IntPtr)0;
			}
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.ParticleSystemModule" })]
		internal IntPtr m_Ptr;

		private bool m_RequiresNativeCleanup;

		public Keyframe[] keys
		{
			[FreeFunction("AnimationCurveBindings::GetKeysArray", HasExplicitThis = true, IsThreadSafe = true)]
			get
			{
				return null;
			}
			[FreeFunction("AnimationCurveBindings::SetKeysWithSpan", HasExplicitThis = true, IsThreadSafe = true)]
			set
			{
			}
		}

		public Keyframe this[int index] => default(Keyframe);

		public int length
		{
			[NativeMethod("GetKeyCount", IsThreadSafe = true)]
			get
			{
				return 0;
			}
		}

		public WrapMode preWrapMode
		{
			[NativeMethod("GetPreInfinity", IsThreadSafe = true)]
			get
			{
				return default(WrapMode);
			}
			[NativeMethod("SetPreInfinity", IsThreadSafe = true)]
			set
			{
			}
		}

		public WrapMode postWrapMode
		{
			[NativeMethod("GetPostInfinity", IsThreadSafe = true)]
			get
			{
				return default(WrapMode);
			}
			[NativeMethod("SetPostInfinity", IsThreadSafe = true)]
			set
			{
			}
		}

		[FreeFunction("AnimationCurveBindings::Internal_Destroy", IsThreadSafe = true)]
		private static void Internal_Destroy(IntPtr ptr)
		{
		}

		[FreeFunction("AnimationCurveBindings::Internal_Create", IsThreadSafe = true)]
		private static IntPtr Internal_Create(Keyframe[] keys)
		{
			return (IntPtr)0;
		}

		[FreeFunction("AnimationCurveBindings::Internal_Equals", HasExplicitThis = true, IsThreadSafe = true)]
		private bool Internal_Equals(IntPtr other)
		{
			return false;
		}

		[FreeFunction("AnimationCurveBindings::Internal_CopyFrom", HasExplicitThis = true, IsThreadSafe = true)]
		private void Internal_CopyFrom(IntPtr other)
		{
		}

		~AnimationCurve()
		{
		}

		[ThreadSafe]
		public float Evaluate(float time)
		{
			return 0f;
		}

		[FreeFunction("AnimationCurveBindings::AddKeySmoothTangents", HasExplicitThis = true, IsThreadSafe = true)]
		public int AddKey(float time, float value)
		{
			return 0;
		}

		public int AddKey(Keyframe key)
		{
			return 0;
		}

		[NativeMethod("AddKey", IsThreadSafe = true)]
		private int AddKey_Internal(Keyframe key)
		{
			return 0;
		}

		[NativeThrows]
		[FreeFunction("AnimationCurveBindings::MoveKey", HasExplicitThis = true, IsThreadSafe = true)]
		public int MoveKey(int index, Keyframe key)
		{
			return 0;
		}

		[FreeFunction("AnimationCurveBindings::ClearKeys", HasExplicitThis = true, IsThreadSafe = true)]
		public void ClearKeys()
		{
		}

		[FreeFunction("AnimationCurveBindings::RemoveKey", HasExplicitThis = true, IsThreadSafe = true)]
		[NativeThrows]
		public void RemoveKey(int index)
		{
		}

		[NativeThrows]
		[FreeFunction("AnimationCurveBindings::GetKey", HasExplicitThis = true, IsThreadSafe = true)]
		private Keyframe GetKey(int index)
		{
			return default(Keyframe);
		}

		[FreeFunction("AnimationCurveBindings::GetHashCode", HasExplicitThis = true, IsThreadSafe = true)]
		public override int GetHashCode()
		{
			return 0;
		}

		[NativeThrows]
		[FreeFunction("AnimationCurveBindings::SmoothTangents", HasExplicitThis = true, IsThreadSafe = true)]
		public void SmoothTangents(int index, float weight)
		{
		}

		public static AnimationCurve Linear(float timeStart, float valueStart, float timeEnd, float valueEnd)
		{
			return null;
		}

		public static AnimationCurve EaseInOut(float timeStart, float valueStart, float timeEnd, float valueEnd)
		{
			return null;
		}

		public AnimationCurve(params Keyframe[] keys)
		{
		}

		[RequiredByNativeCode]
		public AnimationCurve()
		{
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.ParticleSystemModule" })]
		internal AnimationCurve(IntPtr ptr, bool ownMemory)
		{
		}

		public override bool Equals(object o)
		{
			return false;
		}

		public bool Equals(AnimationCurve other)
		{
			return false;
		}

		public void CopyFrom(AnimationCurve other)
		{
		}

		private static IntPtr Internal_Create_Injected(ref ManagedSpanWrapper keys)
		{
			return (IntPtr)0;
		}

		private static bool Internal_Equals_Injected(IntPtr _unity_self, IntPtr other)
		{
			return false;
		}

		private static void Internal_CopyFrom_Injected(IntPtr _unity_self, IntPtr other)
		{
		}

		private static float Evaluate_Injected(IntPtr _unity_self, float time)
		{
			return 0f;
		}

		private static void get_keys_Injected(IntPtr _unity_self, out BlittableArrayWrapper ret)
		{
			ret = default(BlittableArrayWrapper);
		}

		private static void set_keys_Injected(IntPtr _unity_self, ref ManagedSpanWrapper value)
		{
		}

		private static int AddKey_Injected(IntPtr _unity_self, float time, float value)
		{
			return 0;
		}

		private static int AddKey_Internal_Injected(IntPtr _unity_self, [In] ref Keyframe key)
		{
			return 0;
		}

		private static int MoveKey_Injected(IntPtr _unity_self, int index, [In] ref Keyframe key)
		{
			return 0;
		}

		private static void ClearKeys_Injected(IntPtr _unity_self)
		{
		}

		private static void RemoveKey_Injected(IntPtr _unity_self, int index)
		{
		}

		private static int get_length_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static void GetKey_Injected(IntPtr _unity_self, int index, out Keyframe ret)
		{
			ret = default(Keyframe);
		}

		private static int GetHashCode_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static void SmoothTangents_Injected(IntPtr _unity_self, int index, float weight)
		{
		}

		private static WrapMode get_preWrapMode_Injected(IntPtr _unity_self)
		{
			return default(WrapMode);
		}

		private static void set_preWrapMode_Injected(IntPtr _unity_self, WrapMode value)
		{
		}

		private static WrapMode get_postWrapMode_Injected(IntPtr _unity_self)
		{
			return default(WrapMode);
		}

		private static void set_postWrapMode_Injected(IntPtr _unity_self, WrapMode value)
		{
		}
	}
}
