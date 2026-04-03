namespace UnityEngine.AdaptivePerformance
{
	internal class AutoPerformanceLevelController
	{
		private IDevicePerformanceControl m_PerfControl;

		private IPerformanceStatus m_PerfStats;

		private IThermalStatus m_ThermalStats;

		private float m_LastChangeTimeStamp;

		private float m_LastGpuLevelRaiseTimeStamp;

		private float m_LastCpuLevelRaiseTimeStamp;

		private float m_TargetFrameRateHitTimestamp;

		private float m_BottleneckUnknownTimestamp;

		private bool m_TriedToResolveUnknownBottleneck;

		private bool m_Enabled;

		private string m_FeatureName;

		public float TargetFrameTime { get; set; }

		public float AllowedCpuActiveTimeRatio { get; set; }

		public float AllowedGpuActiveTimeRatio { get; set; }

		public float GpuLevelBounceAvoidanceThreshold { get; set; }

		public float CpuLevelBounceAvoidanceThreshold { get; set; }

		public float UpdateInterval { get; set; }

		public float MinTargetFrameRateHitTime { get; set; }

		public float MaxTemperatureLevel { get; set; }

		public bool Enabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public AutoPerformanceLevelController(IDevicePerformanceControl perfControl, IPerformanceStatus perfStat, IThermalStatus thermalStat)
		{
		}

		public void Update()
		{
		}

		public void Override(int requestedCpuLevel, int requestedGpuLevel)
		{
		}

		private void UpdateImpl(float timestamp)
		{
		}

		private void OnBottleneckChange(PerformanceBottleneckChangeEventArgs ev)
		{
		}

		private void RaiseGpuLevel(float timestamp)
		{
		}

		private void RaiseCpuLevel(float timestamp)
		{
		}

		private void LowerCpuLevel(float timestamp)
		{
		}

		private void LowerGpuLevel(float timestamp)
		{
		}

		private bool AllowLowerCpuLevel(float timestamp)
		{
			return false;
		}

		private bool AllowLowerGpuLevel(float timestamp)
		{
			return false;
		}

		private bool AllowRaiseLevels()
		{
			return false;
		}

		private bool AllowRaiseCpuLevel()
		{
			return false;
		}

		private bool AllowRaiseGpuLevel()
		{
			return false;
		}
	}
}
