using System;
using UnityEngine.Bindings;

namespace UnityEngine
{
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationClip.bindings.h")]
	[NativeType("Modules/Animation/AnimationClip.h")]
	public sealed class AnimationClip : Motion
	{
		[NativeProperty("Length", false, TargetType.Function)]
		public float length => 0f;

		[NativeProperty("SampleRate", false, TargetType.Function)]
		public float frameRate
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[NativeProperty("WrapMode", false, TargetType.Function)]
		public WrapMode wrapMode => default(WrapMode);

		public bool legacy
		{
			[NativeMethod("IsLegacy")]
			get
			{
				return false;
			}
			[NativeMethod("SetLegacy")]
			set
			{
			}
		}

		public bool empty
		{
			[NativeMethod("IsEmpty")]
			get
			{
				return false;
			}
		}

		public bool hasGenericRootTransform
		{
			[NativeMethod("HasGenericRootTransform")]
			get
			{
				return false;
			}
		}

		public bool hasMotionCurves
		{
			[NativeMethod("HasMotionCurves")]
			get
			{
				return false;
			}
		}

		public bool hasRootCurves
		{
			[NativeMethod("HasRootCurves")]
			get
			{
				return false;
			}
		}

		internal bool hasRootMotion
		{
			[FreeFunction(Name = "AnimationClipBindings::Internal_GetHasRootMotion", HasExplicitThis = true)]
			get
			{
				return false;
			}
		}

		[FreeFunction("AnimationClipBindings::Internal_CreateAnimationClip")]
		private static void Internal_CreateAnimationClip([Writable] AnimationClip self)
		{
		}

		public void SampleAnimation(GameObject go, float time)
		{
		}

		[FreeFunction]
		[NativeHeader("Modules/Animation/AnimationUtility.h")]
		internal static void SampleAnimation([NotNull] GameObject go, [NotNull] AnimationClip clip, float inTime, WrapMode wrapMode)
		{
		}

		private static void SampleAnimation_Injected(IntPtr go, IntPtr clip, float inTime, WrapMode wrapMode)
		{
		}

		private static float get_length_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static float get_frameRate_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static void set_frameRate_Injected(IntPtr _unity_self, float value)
		{
		}

		private static WrapMode get_wrapMode_Injected(IntPtr _unity_self)
		{
			return default(WrapMode);
		}

		private static bool get_legacy_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static void set_legacy_Injected(IntPtr _unity_self, bool value)
		{
		}

		private static bool get_empty_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static bool get_hasGenericRootTransform_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static bool get_hasMotionCurves_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static bool get_hasRootCurves_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static bool get_hasRootMotion_Injected(IntPtr _unity_self)
		{
			return false;
		}
	}
}
