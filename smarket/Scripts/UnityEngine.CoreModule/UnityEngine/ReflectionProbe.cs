using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[NativeHeader("Runtime/Camera/ReflectionProbes.h")]
	public sealed class ReflectionProbe : Behaviour
	{
		public enum ReflectionProbeEvent
		{
			ReflectionProbeAdded = 0,
			ReflectionProbeRemoved = 1
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action<ReflectionProbe, ReflectionProbeEvent> reflectionProbeChanged;

		private static Dictionary<int, Action<Texture>> registeredDefaultReflectionSetActions;

		private static List<Action<Texture>> registeredDefaultReflectionTextureActions;

		[NativeName("GlobalAABB")]
		public Bounds bounds => default(Bounds);

		public ReflectionProbeMode mode => default(ReflectionProbeMode);

		public ReflectionProbeRefreshMode refreshMode => default(ReflectionProbeRefreshMode);

		public ReflectionProbeTimeSlicingMode timeSlicingMode => default(ReflectionProbeTimeSlicingMode);

		public Texture customBakedTexture
		{
			set
			{
			}
		}

		public RenderTexture realtimeTexture => null;

		[StaticAccessor("GetReflectionProbes()")]
		public static Vector4 defaultTextureHDRDecodeValues => default(Vector4);

		[StaticAccessor("GetReflectionProbes()")]
		public static Texture defaultTexture => null;

		public int RenderProbe()
		{
			return 0;
		}

		public int RenderProbe([DefaultValue("null")] RenderTexture targetTexture)
		{
			return 0;
		}

		private int ScheduleRender(ReflectionProbeTimeSlicingMode timeSlicingMode, RenderTexture targetTexture)
		{
			return 0;
		}

		[RequiredByNativeCode]
		private static void CallReflectionProbeEvent(ReflectionProbe probe, ReflectionProbeEvent probeEvent)
		{
		}

		[RequiredByNativeCode]
		private static void CallSetDefaultReflection(Texture defaultReflectionCubemap)
		{
		}

		private static void get_bounds_Injected(IntPtr _unity_self, out Bounds ret)
		{
			ret = default(Bounds);
		}

		private static ReflectionProbeMode get_mode_Injected(IntPtr _unity_self)
		{
			return default(ReflectionProbeMode);
		}

		private static ReflectionProbeRefreshMode get_refreshMode_Injected(IntPtr _unity_self)
		{
			return default(ReflectionProbeRefreshMode);
		}

		private static ReflectionProbeTimeSlicingMode get_timeSlicingMode_Injected(IntPtr _unity_self)
		{
			return default(ReflectionProbeTimeSlicingMode);
		}

		private static void set_customBakedTexture_Injected(IntPtr _unity_self, IntPtr value)
		{
		}

		private static IntPtr get_realtimeTexture_Injected(IntPtr _unity_self)
		{
			return (IntPtr)0;
		}

		private static int ScheduleRender_Injected(IntPtr _unity_self, ReflectionProbeTimeSlicingMode timeSlicingMode, IntPtr targetTexture)
		{
			return 0;
		}

		private static void get_defaultTextureHDRDecodeValues_Injected(out Vector4 ret)
		{
			ret = default(Vector4);
		}

		private static IntPtr get_defaultTexture_Injected()
		{
			return (IntPtr)0;
		}
	}
}
