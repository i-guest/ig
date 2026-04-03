using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Profiling
{
	[MovedFrom("UnityEngine")]
	[NativeHeader("NativeKernel/Allocator/MemoryManager.h")]
	[NativeHeader("Runtime/Profiler/MemoryProfiler.h")]
	[NativeHeader("Runtime/Profiler/Profiler.h")]
	[NativeHeader("NativeKernel/Utilities/MemoryUtilities.h")]
	[NativeHeader("Runtime/ScriptingBackend/ScriptingApi.h")]
	[UsedByNativeCode]
	[NativeHeader("Runtime/Profiler/ScriptBindings/Profiler.bindings.h")]
	public sealed class Profiler
	{
		public static bool enabled
		{
			[NativeConditional("ENABLE_PROFILER")]
			[NativeMethod(Name = "profiler_is_enabled", IsFreeFunction = true, IsThreadSafe = true)]
			get
			{
				return false;
			}
		}

		[NativeConditional("ENABLE_PROFILER")]
		public static void EndThreadProfiling()
		{
		}

		[NativeMethod(Name = "ProfilerBindings::GetRuntimeMemorySizeLong", IsFreeFunction = true)]
		public static long GetRuntimeMemorySizeLong([NotNull] Object o)
		{
			return 0L;
		}

		private static long GetRuntimeMemorySizeLong_Injected(IntPtr o)
		{
			return 0L;
		}
	}
}
