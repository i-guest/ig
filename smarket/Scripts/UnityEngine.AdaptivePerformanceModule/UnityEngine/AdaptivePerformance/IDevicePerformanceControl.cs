namespace UnityEngine.AdaptivePerformance
{
	public interface IDevicePerformanceControl
	{
		int MaxCpuPerformanceLevel { get; }

		int MaxGpuPerformanceLevel { get; }

		int CpuLevel { get; set; }

		int GpuLevel { get; set; }
	}
}
