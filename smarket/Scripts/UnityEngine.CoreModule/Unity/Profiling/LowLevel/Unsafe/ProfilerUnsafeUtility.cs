using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace Unity.Profiling.LowLevel.Unsafe
{
	[NativeHeader("Runtime/Profiler/ScriptBindings/ProfilerUnsafeUtility.bindings.h")]
	[UsedByNativeCode]
	[IgnoredByDeepProfiler]
	public static class ProfilerUnsafeUtility
	{
		[ThreadSafe]
		internal unsafe static ushort CreateCategory__Unmanaged(byte* name, int nameLen, ProfilerCategoryColor colorIndex)
		{
			return 0;
		}

		[ThreadSafe]
		public static ProfilerCategoryDescription GetCategoryDescription(ushort categoryId)
		{
			return default(ProfilerCategoryDescription);
		}

		[ThreadSafe]
		public static IntPtr CreateMarker(string name, ushort categoryId, MarkerFlags flags, int metadataCount)
		{
			return (IntPtr)0;
		}

		[ThreadSafe]
		internal unsafe static IntPtr CreateMarker__Unmanaged(byte* name, int nameLen, ushort categoryId, MarkerFlags flags, int metadataCount)
		{
			return (IntPtr)0;
		}

		[ThreadSafe]
		internal unsafe static void SetMarkerMetadata__Unmanaged(IntPtr markerPtr, int index, byte* name, int nameLen, byte type, byte unit)
		{
		}

		[ThreadSafe]
		public static void BeginSample(IntPtr markerPtr)
		{
		}

		[ThreadSafe]
		public static void EndSample(IntPtr markerPtr)
		{
		}

		[ThreadSafe]
		internal unsafe static void* CreateCounterValue__Unmanaged(out IntPtr counterPtr, byte* name, int nameLen, ushort categoryId, MarkerFlags flags, byte dataType, byte dataUnit, int dataSize, ProfilerCounterOptions counterOptions)
		{
			counterPtr = default(IntPtr);
			return null;
		}

		internal unsafe static string Utf8ToString(byte* chars, int charsLen)
		{
			return null;
		}

		[ThreadSafe(ThrowsException = false)]
		[NativeConditional("ENABLE_MEM_PROFILER")]
		internal static IntPtr GetOrCreateMemLabel(string areaName, string objectName)
		{
			return (IntPtr)0;
		}

		[NativeConditional("ENABLE_MEM_PROFILER")]
		[ThreadSafe(ThrowsException = false)]
		internal unsafe static IntPtr GetOrCreateMemLabel__Unmanaged(byte* areaName, int areaNameLen, byte* objectName, int objectNameLen)
		{
			return (IntPtr)0;
		}

		private static void GetCategoryDescription_Injected(ushort categoryId, out ProfilerCategoryDescription ret)
		{
			ret = default(ProfilerCategoryDescription);
		}

		private static IntPtr CreateMarker_Injected(ref ManagedSpanWrapper name, ushort categoryId, MarkerFlags flags, int metadataCount)
		{
			return (IntPtr)0;
		}

		private static IntPtr GetOrCreateMemLabel_Injected(ref ManagedSpanWrapper areaName, ref ManagedSpanWrapper objectName)
		{
			return (IntPtr)0;
		}
	}
}
