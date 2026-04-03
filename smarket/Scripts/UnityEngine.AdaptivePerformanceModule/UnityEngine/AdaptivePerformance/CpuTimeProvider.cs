namespace UnityEngine.AdaptivePerformance
{
	internal class CpuTimeProvider
	{
		private UnityEngine.FrameTiming[] m_FrameTimings;

		public float CpuFrameTime => 0f;

		protected virtual uint GetLatestTimings()
		{
			return 0u;
		}

		public void Measure()
		{
		}
	}
}
