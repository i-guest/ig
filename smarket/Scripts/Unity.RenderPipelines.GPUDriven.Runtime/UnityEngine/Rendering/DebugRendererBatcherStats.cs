using System;
using Unity.Collections;

namespace UnityEngine.Rendering
{
	internal class DebugRendererBatcherStats : IDisposable
	{
		public bool enabled;

		public NativeList<InstanceCullerViewStats> instanceCullerStats;

		public NativeList<InstanceOcclusionEventStats> instanceOcclusionEventStats;

		public NativeList<DebugOccluderStats> occluderStats;

		public bool occlusionOverlayEnabled;

		public bool occlusionOverlayCountVisible;

		public bool overrideOcclusionTestToAlwaysPass;

		public void FinalizeInstanceCullerViewStats()
		{
		}

		private InstanceOcclusionEventStats GetLastInstanceOcclusionEventStatsForView(int viewIndex)
		{
			return default(InstanceOcclusionEventStats);
		}

		public void Dispose()
		{
		}
	}
}
