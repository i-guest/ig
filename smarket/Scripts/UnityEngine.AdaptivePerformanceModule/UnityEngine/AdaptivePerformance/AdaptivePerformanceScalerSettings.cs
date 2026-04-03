using System;

namespace UnityEngine.AdaptivePerformance
{
	[Serializable]
	public class AdaptivePerformanceScalerSettings
	{
		[SerializeField]
		[Tooltip("Settings for a scaler used by the Indexer to adjust the application update rate using Application.TargetFramerate")]
		private AdaptivePerformanceScalerSettingsBase m_AdaptiveFramerate;

		[SerializeField]
		[Tooltip("Settings for a scaler used by the Indexer to adjust the resolution of all render targets that allow dynamic resolution.")]
		private AdaptivePerformanceScalerSettingsBase m_AdaptiveResolution;

		[Tooltip("Settings for a scaler used by the Indexer to control if dynamic batching is enabled.")]
		[SerializeField]
		private AdaptivePerformanceScalerSettingsBase m_AdaptiveBatching;

		[Tooltip("Settings for a scaler used by the Indexer for adjusting at what distance LODs are switched.")]
		[SerializeField]
		private AdaptivePerformanceScalerSettingsBase m_AdaptiveLOD;

		[Tooltip("Settings for a scaler used by the Indexer to adjust the size of the palette used for color grading in URP.")]
		[SerializeField]
		private AdaptivePerformanceScalerSettingsBase m_AdaptiveLut;

		[SerializeField]
		[Tooltip("Settings for a scaler used by the Indexer to adjust the level of antialiasing.")]
		private AdaptivePerformanceScalerSettingsBase m_AdaptiveMSAA;

		[SerializeField]
		[Tooltip("Settings for a scaler used by the Indexer to adjust the number of shadow cascades to be used.")]
		private AdaptivePerformanceScalerSettingsBase m_AdaptiveShadowCascade;

		private const string obsoleteMsg = "AdaptiveShadowCascades has been renamed. Please use AdaptiveShadowCascade. (UnityUpgradable) -> AdaptiveShadowCascade";

		[SerializeField]
		[Tooltip("Settings for a scaler used by the Indexer to change the distance at which shadows are rendered.")]
		private AdaptivePerformanceScalerSettingsBase m_AdaptiveShadowDistance;

		[Tooltip("Settings for a scaler used by the Indexer to adjust the resolution of shadow maps.")]
		[SerializeField]
		private AdaptivePerformanceScalerSettingsBase m_AdaptiveShadowmapResolution;

		[SerializeField]
		[Tooltip("Settings for a scaler used by the Indexer to adjust the quality of shadows.")]
		private AdaptivePerformanceScalerSettingsBase m_AdaptiveShadowQuality;

		[Tooltip("Settings for a scaler used by the Indexer to change if objects in the scene are sorted by depth before rendering to reduce overdraw.")]
		[SerializeField]
		private AdaptivePerformanceScalerSettingsBase m_AdaptiveSorting;

		[SerializeField]
		[Tooltip("Settings for a scaler used by the Indexer to disable transparent objects rendering")]
		private AdaptivePerformanceScalerSettingsBase m_AdaptiveTransparency;

		[SerializeField]
		[Tooltip("Settings for a scaler used by the Indexer to change the view distance")]
		private AdaptivePerformanceScalerSettingsBase m_AdaptiveViewDistance;

		[SerializeField]
		[Tooltip("Settings for a scaler used by the Indexer to change physics properties")]
		private AdaptivePerformanceScalerSettingsBase m_AdaptivePhysics;

		[SerializeField]
		[Tooltip("Settings for a scaler used by the Indexer to change decal properties")]
		private AdaptivePerformanceScalerSettingsBase m_AdaptiveDecals;

		[Tooltip("Settings for a scaler used by the Indexer to change the layer culling distance")]
		[SerializeField]
		private AdaptivePerformanceScalerSettingsBase m_AdaptiveLayerCulling;

		public AdaptivePerformanceScalerSettingsBase AdaptiveFramerate
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public AdaptivePerformanceScalerSettingsBase AdaptiveResolution
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public AdaptivePerformanceScalerSettingsBase AdaptiveBatching
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public AdaptivePerformanceScalerSettingsBase AdaptiveLOD
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public AdaptivePerformanceScalerSettingsBase AdaptiveLut
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public AdaptivePerformanceScalerSettingsBase AdaptiveMSAA
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[Obsolete("AdaptiveShadowCascades has been renamed. Please use AdaptiveShadowCascade. (UnityUpgradable) -> AdaptiveShadowCascade", false)]
		public AdaptivePerformanceScalerSettingsBase AdaptiveShadowCascades => null;

		public AdaptivePerformanceScalerSettingsBase AdaptiveShadowCascade
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public AdaptivePerformanceScalerSettingsBase AdaptiveShadowDistance
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public AdaptivePerformanceScalerSettingsBase AdaptiveShadowmapResolution
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public AdaptivePerformanceScalerSettingsBase AdaptiveShadowQuality
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public AdaptivePerformanceScalerSettingsBase AdaptiveSorting
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public AdaptivePerformanceScalerSettingsBase AdaptiveTransparency
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public AdaptivePerformanceScalerSettingsBase AdaptiveViewDistance
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public AdaptivePerformanceScalerSettingsBase AdaptivePhysics
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public AdaptivePerformanceScalerSettingsBase AdaptiveDecals
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public AdaptivePerformanceScalerSettingsBase AdaptiveLayerCulling
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void ApplySettings(AdaptivePerformanceScalerSettings settings)
		{
		}

		private void ApplySettingsBase(AdaptivePerformanceScalerSettingsBase destination, AdaptivePerformanceScalerSettingsBase sources)
		{
		}
	}
}
