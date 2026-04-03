using UnityEngine.AdaptivePerformance.Provider;

namespace UnityEngine.AdaptivePerformance
{
	public interface IAdaptivePerformance
	{
		IThermalStatus ThermalStatus { get; }

		IPerformanceStatus PerformanceStatus { get; }

		AdaptivePerformanceIndexer Indexer { get; }

		IAdaptivePerformanceSettings Settings { get; }

		bool SupportedFeature(Feature feature);
	}
}
