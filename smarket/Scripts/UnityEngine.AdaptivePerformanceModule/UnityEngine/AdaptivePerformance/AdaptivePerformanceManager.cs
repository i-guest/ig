using System.Runtime.CompilerServices;
using UnityEngine.AdaptivePerformance.Provider;

namespace UnityEngine.AdaptivePerformance
{
	internal class AdaptivePerformanceManager : MonoBehaviour, IAdaptivePerformance, IThermalStatus, IPerformanceStatus, IDevicePerformanceControl, IDevelopmentSettings, IPerformanceModeStatus
	{
		private bool m_JustResumed;

		private int m_RequestedCpuLevel;

		private int m_RequestedGpuLevel;

		private bool m_NewUserPerformanceLevelRequest;

		private bool m_RequestedCpuBoost;

		private bool m_RequestedGpuBoost;

		private bool m_NewUserCpuPerformanceBoostRequest;

		private bool m_NewUserGpuPerformanceBoostRequest;

		private ThermalMetrics m_ThermalMetrics;

		private PerformanceMetrics m_PerformanceMetrics;

		private FrameTiming m_FrameTiming;

		private PerformanceMode m_PerformanceMode;

		private bool m_AutomaticPerformanceControl;

		private bool m_AutomaticPerformanceControlChanged;

		private IAdaptivePerformanceSettings m_Settings;

		private AdaptivePerformanceSubsystem m_Subsystem;

		private DevicePerformanceControlImpl m_DevicePerfControl;

		private AutoPerformanceLevelController m_AutoPerformanceLevelController;

		private AutoPerformanceModeController m_AutoPerformanceModeController;

		private CpuTimeProvider m_CpuFrameTimeProvider;

		private GpuTimeProvider m_GpuFrameTimeProvider;

		private IApplicationLifecycle m_AppLifecycle;

		private TemperatureTrend m_TemperatureTrend;

		private bool m_UseProviderOverallFrameTime;

		private WaitForEndOfFrame m_WaitForEndOfFrame;

		private int m_FrameCount;

		private RunningAverage m_OverallFrameTime;

		private float m_OverallFrameTimeAccu;

		private RunningAverage m_GpuFrameTime;

		private RunningAverage m_CpuFrameTime;

		public ThermalMetrics ThermalMetrics => default(ThermalMetrics);

		public PerformanceMetrics PerformanceMetrics => default(PerformanceMetrics);

		public FrameTiming FrameTiming => default(FrameTiming);

		public PerformanceMode PerformanceMode => default(PerformanceMode);

		public bool Logging
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int LoggingFrequencyInFrames { get; set; }

		public bool Initialized => false;

		public bool Active => false;

		public int MaxCpuPerformanceLevel => 0;

		public int MaxGpuPerformanceLevel => 0;

		public bool AutomaticPerformanceControl
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public PerformanceControlMode PerformanceControlMode => default(PerformanceControlMode);

		public int CpuLevel
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int GpuLevel
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool CpuPerformanceBoost
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool GpuPerformanceBoost
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public IDevelopmentSettings DevelopmentSettings => null;

		public IThermalStatus ThermalStatus => null;

		public IPerformanceStatus PerformanceStatus => null;

		public IDevicePerformanceControl DevicePerformanceControl => null;

		public IPerformanceModeStatus PerformanceModeStatus => null;

		public AdaptivePerformanceIndexer Indexer { get; private set; }

		public IAdaptivePerformanceSettings Settings
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public AdaptivePerformanceSubsystem Subsystem => null;

		public event ThermalEventHandler ThermalEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event PerformanceBottleneckChangeHandler PerformanceBottleneckChangeEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event PerformanceLevelChangeHandler PerformanceLevelChangeEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event PerformanceBoostChangeHandler PerformanceBoostChangeEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event PerformanceModeEventHandler PerformanceModeEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public bool SupportedFeature(Feature feature)
		{
			return false;
		}

		public void Awake()
		{
		}

		private void LogThermalEvent(ThermalMetrics ev)
		{
		}

		private void LogBottleneckEvent(PerformanceBottleneckChangeEventArgs ev)
		{
		}

		private void LogBoostEvent(PerformanceBoostChangeEventArgs ev)
		{
		}

		private void LogPerformanceModeEvent(PerformanceMode performanceMode)
		{
		}

		private static string ToStringWithSign(int x)
		{
			return null;
		}

		private void LogPerformanceLevelEvent(PerformanceLevelChangeEventArgs ev)
		{
		}

		private void AddNonNegativeValue(RunningAverage runningAverage, float value)
		{
		}

		public void LateUpdate()
		{
		}

		public void Update()
		{
		}

		private void CollectProfilerStats()
		{
		}

		private void AccumulateTimingValue(ref float accu, float newValue)
		{
		}

		private void UpdateSubsystem()
		{
		}

		private static bool WillCurrentFrameRender()
		{
			return false;
		}

		public static float EffectiveTargetFrameRate()
		{
			return 0f;
		}

		public void OnDestroy()
		{
		}

		public void InitializeAdaptivePerformance()
		{
		}

		public void StartAdaptivePerformance()
		{
		}

		public void StopAdaptivePerformance()
		{
		}

		public void DeinitializeAdaptivePerformance()
		{
		}

		public void OnApplicationPause(bool pause)
		{
		}
	}
}
