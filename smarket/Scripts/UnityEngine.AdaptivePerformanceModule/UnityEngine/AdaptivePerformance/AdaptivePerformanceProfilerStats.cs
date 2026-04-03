using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.Profiling;

namespace UnityEngine.AdaptivePerformance
{
	public static class AdaptivePerformanceProfilerStats
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		public readonly struct CustomProfilerMarker<T> where T : struct
		{
			public CustomProfilerMarker(string name, ProfilerMarkerDataUnit dataUnit)
			{
			}

			public void Sample(T value)
			{
			}
		}

		public struct ScalerInfo
		{
			public unsafe fixed byte scalerName[320];

			public uint enabled;

			public int overrideLevel;

			public int currentLevel;

			public int maxLevel;

			public float scale;

			public uint applied;
		}

		public static readonly ProfilerCategory AdaptivePerformanceProfilerCategory;

		public static CustomProfilerMarker<float> CurrentCPUMarker;

		public static CustomProfilerMarker<float> AvgCPUMarker;

		public static CustomProfilerMarker<float> CurrentGPUMarker;

		public static CustomProfilerMarker<float> AvgGPUMarker;

		public static CustomProfilerMarker<int> CurrentCPULevelMarker;

		public static CustomProfilerMarker<int> CurrentGPULevelMarker;

		public static CustomProfilerMarker<float> CurrentFrametimeMarker;

		public static CustomProfilerMarker<float> AvgFrametimeMarker;

		public static CustomProfilerMarker<int> WarningLevelMarker;

		public static CustomProfilerMarker<float> TemperatureLevelMarker;

		public static CustomProfilerMarker<float> TemperatureTrendMarker;

		public static CustomProfilerMarker<int> BottleneckMarker;

		public static CustomProfilerMarker<int> PerformanceModeMarker;

		public static readonly Guid kAdaptivePerformanceProfilerModuleGuid;

		public static readonly int kScalerDataTag;

		private static Dictionary<string, ScalerInfo> scalerInfos;

		public static void FlushScalerDataToProfilerStream()
		{
		}
	}
}
