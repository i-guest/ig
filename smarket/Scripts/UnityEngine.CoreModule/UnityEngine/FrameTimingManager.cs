using UnityEngine.Bindings;

namespace UnityEngine
{
	[StaticAccessor("GetUncheckedRealGfxDevice().GetFrameTimingManager()", StaticAccessorType.Dot)]
	public static class FrameTimingManager
	{
		public static void CaptureFrameTimings()
		{
		}

		public static uint GetLatestTimings(uint numFrames, FrameTiming[] timings)
		{
			return 0u;
		}

		private static uint GetLatestTimings_Injected(uint numFrames, ref ManagedSpanWrapper timings)
		{
			return 0u;
		}
	}
}
