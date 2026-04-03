namespace UnityEngine.AdaptivePerformance
{
	internal class AdaptivePerformanceScalerEfficiencyTracker
	{
		private AdaptivePerformanceScaler m_Scaler;

		private float m_LastAverageGpuFrameTime;

		private float m_LastAverageCpuFrameTime;

		private bool m_IsApplied;

		public bool IsRunning => false;

		public void Start(AdaptivePerformanceScaler scaler, bool isApply)
		{
		}

		public void Stop()
		{
		}
	}
}
