using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.AdaptivePerformance
{
	public class AdaptivePerformanceIndexer
	{
		private List<AdaptivePerformanceScaler> m_UnappliedScalers;

		private List<AdaptivePerformanceScaler> m_AppliedScalers;

		private List<AdaptivePerformanceScaler> m_DisabledScalers;

		private ThermalStateTracker m_ThermalStateTracker;

		private PerformanceStateTracker m_PerformanceStateTracker;

		private AdaptivePerformanceScalerEfficiencyTracker m_ScalerEfficiencyTracker;

		private IAdaptivePerformanceSettings m_Settings;

		private const string m_FeatureName = "Indexer";

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private StateAction _003CThermalAction_003Ek__BackingField;

		public float TimeUntilNextAction { get; private set; }

		private StateAction ThermalAction
		{
			[CompilerGenerated]
			set
			{
				_003CThermalAction_003Ek__BackingField = value;
			}
		}

		public StateAction PerformanceAction { get; private set; }

		public void GetAppliedScalers(ref List<AdaptivePerformanceScaler> scalers)
		{
		}

		public void GetUnappliedScalers(ref List<AdaptivePerformanceScaler> scalers)
		{
		}

		public void GetDisabledScalers(ref List<AdaptivePerformanceScaler> scalers)
		{
		}

		public void UnapplyAllScalers()
		{
		}

		internal void UpdateOverrideLevel(AdaptivePerformanceScaler scaler)
		{
		}

		internal void AddScaler(AdaptivePerformanceScaler scaler)
		{
		}

		internal void RemoveScaler(AdaptivePerformanceScaler scaler)
		{
		}

		internal AdaptivePerformanceIndexer(ref IAdaptivePerformanceSettings settings, PerformanceStateTracker tracker)
		{
		}

		internal void Update()
		{
		}

		protected virtual float DeltaTime()
		{
			return 0f;
		}

		private void CollectProfilerStats()
		{
		}

		private void DeactivateDisabledScalers()
		{
		}

		private void ActivateEnabledScalers()
		{
		}

		private bool ApplyLowestCostScaler()
		{
			return false;
		}

		private void ApplyScaler(AdaptivePerformanceScaler scaler)
		{
		}

		private bool UnapplyHighestCostScaler()
		{
			return false;
		}

		private void UnapplyScaler(AdaptivePerformanceScaler scaler)
		{
		}
	}
}
