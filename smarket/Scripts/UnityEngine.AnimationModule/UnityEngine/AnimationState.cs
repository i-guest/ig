using System;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[NativeHeader("Modules/Animation/AnimationState.h")]
	[UsedByNativeCode]
	public sealed class AnimationState : TrackedReference
	{
		internal static class BindingsMarshaller
		{
			public static IntPtr ConvertToNative(AnimationState animationState)
			{
				return (IntPtr)0;
			}
		}

		public bool enabled
		{
			set
			{
			}
		}

		public float weight
		{
			set
			{
			}
		}

		public WrapMode wrapMode
		{
			set
			{
			}
		}

		public float time
		{
			set
			{
			}
		}

		public float normalizedTime
		{
			set
			{
			}
		}

		public float speed
		{
			set
			{
			}
		}

		public float length => 0f;

		public int layer
		{
			set
			{
			}
		}

		public AnimationClip clip => null;

		public AnimationBlendMode blendMode
		{
			set
			{
			}
		}

		public void AddMixingTransform([NotNull] Transform mix, [DefaultValue("true")] bool recursive)
		{
		}

		private static void set_enabled_Injected(IntPtr _unity_self, bool value)
		{
		}

		private static void set_weight_Injected(IntPtr _unity_self, float value)
		{
		}

		private static void set_wrapMode_Injected(IntPtr _unity_self, WrapMode value)
		{
		}

		private static void set_time_Injected(IntPtr _unity_self, float value)
		{
		}

		private static void set_normalizedTime_Injected(IntPtr _unity_self, float value)
		{
		}

		private static void set_speed_Injected(IntPtr _unity_self, float value)
		{
		}

		private static float get_length_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static void set_layer_Injected(IntPtr _unity_self, int value)
		{
		}

		private static IntPtr get_clip_Injected(IntPtr _unity_self)
		{
			return (IntPtr)0;
		}

		private static void set_blendMode_Injected(IntPtr _unity_self, AnimationBlendMode value)
		{
		}

		private static void AddMixingTransform_Injected(IntPtr _unity_self, IntPtr mix, [DefaultValue("true")] bool recursive)
		{
		}
	}
}
