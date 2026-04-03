using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Profiling
{
	[NativeHeader("Runtime/Profiler/ScriptBindings/Sampler.bindings.h")]
	[NativeHeader("Runtime/Profiler/Marker.h")]
	[UsedByNativeCode]
	public sealed class CustomSampler : Sampler
	{
		internal static class BindingsMarshaller
		{
			public static IntPtr ConvertToNative(CustomSampler customSampler)
			{
				return (IntPtr)0;
			}
		}

		internal static CustomSampler s_InvalidCustomSampler;

		internal CustomSampler()
		{
		}

		private CustomSampler(IntPtr ptr)
		{
		}

		public static CustomSampler Create(string name, bool collectGpuData = false)
		{
			return null;
		}
	}
}
