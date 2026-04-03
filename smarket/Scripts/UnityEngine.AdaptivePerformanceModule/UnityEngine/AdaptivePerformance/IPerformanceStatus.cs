namespace UnityEngine.AdaptivePerformance
{
	public interface IPerformanceStatus
	{
		PerformanceMetrics PerformanceMetrics { get; }

		FrameTiming FrameTiming { get; }

		event PerformanceBottleneckChangeHandler PerformanceBottleneckChangeEvent;
	}
}
