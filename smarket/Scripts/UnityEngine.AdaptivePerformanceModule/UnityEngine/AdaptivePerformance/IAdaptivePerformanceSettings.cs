namespace UnityEngine.AdaptivePerformance
{
	public class IAdaptivePerformanceSettings : ScriptableObject
	{
		[SerializeField]
		[Tooltip("Enable Logging in Devmode")]
		private bool m_Logging;

		[SerializeField]
		[Tooltip("Automatic Performance Mode")]
		private bool m_AutomaticPerformanceModeEnabled;

		[SerializeField]
		[Tooltip("Automatic Game Mode")]
		private bool m_AutomaticGameModeEnabled;

		[SerializeField]
		[Tooltip("Enables the CPU and GPU boost mode before engine startup to decrease startup time.")]
		private bool m_EnableBoostOnStartup;

		[SerializeField]
		[Tooltip("Logging Frequency (Development mode only)")]
		private int m_StatsLoggingFrequencyInFrames;

		[Tooltip("Indexer Settings")]
		[SerializeField]
		private AdaptivePerformanceIndexerSettings m_IndexerSettings;

		[SerializeField]
		[Tooltip("Scaler Settings")]
		private AdaptivePerformanceScalerSettings m_ScalerSettings;

		[SerializeField]
		private AdaptivePerformanceScalerProfile[] m_scalerProfileList;

		[SerializeField]
		internal int m_DefaultScalerProfilerIndex;

		[SerializeField]
		private int k_AssetVersion;

		public bool logging
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool automaticPerformanceMode
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool automaticGameMode
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool enableBoostOnStartup
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int statsLoggingFrequencyInFrames
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public AdaptivePerformanceIndexerSettings indexerSettings
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public AdaptivePerformanceScalerSettings scalerSettings
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int defaultScalerProfilerIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public void LoadScalerProfile(string scalerProfileName)
		{
		}

		private bool ApplyScalerProfileToAllScalers()
		{
			return false;
		}

		public string[] GetAvailableScalerProfiles()
		{
			return null;
		}

		public void OnEnable()
		{
		}
	}
}
