namespace UnityEngine.AdaptivePerformance
{
	internal class GpuTimeProvider
	{
		private UnityEngine.FrameTiming[] m_FrameTiming;

		public float GpuFrameTime => 0f;

		protected virtual uint GetLatestTimings()
		{
			return 0u;
		}

		public void Measure()
		{
		}
	}
}
