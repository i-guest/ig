namespace UnityEngine.AdaptivePerformance.Provider
{
	public struct PerformanceDataRecord
	{
		public Feature ChangeFlags { get; set; }

		public float TemperatureLevel { get; set; }

		public float TemperatureTrend { get; set; }

		public WarningLevel WarningLevel { get; }

		public int CpuPerformanceLevel { get; set; }

		public int GpuPerformanceLevel { get; set; }

		public bool PerformanceLevelControlAvailable { get; set; }

		public float CpuFrameTime { get; }

		public float GpuFrameTime { get; }

		public float OverallFrameTime { get; }

		public bool CpuPerformanceBoost { get; set; }

		public bool GpuPerformanceBoost { get; set; }

		public ClusterInfo ClusterInfo { get; }

		public PerformanceMode PerformanceMode { get; }
	}
}
