using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.AdaptivePerformance
{
	public class AdaptivePerformanceGeneralSettings : ScriptableObject
	{
		public static string k_SettingsKey;

		internal static AdaptivePerformanceGeneralSettings s_RuntimeSettingsInstance;

		[SerializeField]
		internal AdaptivePerformanceManagerSettings m_LoaderManagerInstance;

		[SerializeField]
		[Tooltip("Enable this to automatically start up Adaptive Performance at runtime.")]
		internal bool m_InitManagerOnStart;

		[SerializeField]
		[VisibleToOtherModules(new string[] { "UnityEditor.AdaptivePerformanceModule" })]
		internal string m_LastSelectedProvider;

		private AdaptivePerformanceManagerSettings m_AdaptivePerformanceManager;

		private bool m_ProviderIntialized;

		private bool m_ProviderStarted;

		public AdaptivePerformanceManagerSettings Manager
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool IsProviderInitialized => false;

		public bool IsProviderStarted => false;

		public static AdaptivePerformanceGeneralSettings Instance
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public AdaptivePerformanceManagerSettings AssignedSettings
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool InitManagerOnStart
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private void Awake()
		{
		}

		private static void Quit()
		{
		}

		private void OnDestroy()
		{
		}

		[RequiredByNativeCode(true)]
		internal static void AttemptInitializeAdaptivePerformanceGeneralSettingsOnLoad()
		{
		}

		[RequiredByNativeCode(true)]
		internal static void AttemptStartAdaptivePerformanceGeneralSettingsOnBeforeSplashScreen()
		{
		}

		internal void InitAdaptivePerformance()
		{
		}

		internal void StartAdaptivePerformance()
		{
		}

		internal void StopAdaptivePerformance()
		{
		}

		internal void DeInitAdaptivePerformance()
		{
		}
	}
}
