using UnityEngine.AdaptivePerformance.Provider;

namespace UnityEngine.AdaptivePerformance
{
	internal class DevicePerformanceControlImpl : IDevicePerformanceControl
	{
		private IDevicePerformanceLevelControl m_PerformanceLevelControl;

		public PerformanceControlMode PerformanceControlMode { get; set; }

		public int MaxCpuPerformanceLevel => 0;

		public int MaxGpuPerformanceLevel => 0;

		public int CpuLevel { get; set; }

		public int GpuLevel { get; set; }

		public int CurrentCpuLevel { get; set; }

		public int CurrentGpuLevel { get; set; }

		public bool CpuPerformanceBoost { get; set; }

		public bool GpuPerformanceBoost { get; set; }

		public DevicePerformanceControlImpl(IDevicePerformanceLevelControl performanceLevelControl)
		{
		}

		public bool Update(out PerformanceLevelChangeEventArgs changeArgs)
		{
			changeArgs = default(PerformanceLevelChangeEventArgs);
			return false;
		}

		private int ComputeDelta(int oldLevel, int newLevel)
		{
			return 0;
		}
	}
}
