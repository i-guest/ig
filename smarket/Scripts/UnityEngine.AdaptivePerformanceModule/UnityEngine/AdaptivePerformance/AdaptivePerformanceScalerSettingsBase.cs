using System;

namespace UnityEngine.AdaptivePerformance
{
	[Serializable]
	public class AdaptivePerformanceScalerSettingsBase
	{
		[Tooltip("Name of the scaler.")]
		[SerializeField]
		private string m_Name;

		[SerializeField]
		[Tooltip("Active")]
		private bool m_Enabled;

		[SerializeField]
		[Tooltip("Scale to control the quality impact for the scaler. No quality change when 1, improved quality when >1, and lowered quality when <1.")]
		private float m_Scale;

		[SerializeField]
		[Tooltip("Visual impact the scaler has on the application. The higher the value, the more impact the scaler has on the visuals.")]
		private ScalerVisualImpact m_VisualImpact;

		[SerializeField]
		[Tooltip("Application bottleneck that the scaler targets. The target selected has the most impact on the quality control of this scaler.")]
		private ScalerTarget m_Target;

		[SerializeField]
		[Tooltip("Maximum level for the scaler. This is tied to the implementation of the scaler to divide the levels into concrete steps.")]
		private int m_MaxLevel;

		[SerializeField]
		[Tooltip("Minimum value for the scale boundary.")]
		private float m_MinBound;

		[SerializeField]
		[Tooltip("Maximum value for the scale boundary.")]
		private float m_MaxBound;

		public string name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool enabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float scale
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public ScalerVisualImpact visualImpact
		{
			get
			{
				return default(ScalerVisualImpact);
			}
			set
			{
			}
		}

		public ScalerTarget target
		{
			get
			{
				return default(ScalerTarget);
			}
			set
			{
			}
		}

		public int maxLevel
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public float minBound
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float maxBound
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}
	}
}
