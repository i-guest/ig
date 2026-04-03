namespace UnityEngine.AdaptivePerformance
{
	public abstract class AdaptivePerformanceScaler : ScriptableObject
	{
		private AdaptivePerformanceIndexer m_Indexer;

		private int m_OverrideLevel;

		private AdaptivePerformanceScalerSettingsBase m_defaultSetting;

		protected IAdaptivePerformanceSettings m_Settings;

		public virtual string Name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual bool Enabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public virtual float Scale
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public virtual ScalerVisualImpact VisualImpact
		{
			get
			{
				return default(ScalerVisualImpact);
			}
			set
			{
			}
		}

		public virtual ScalerTarget Target
		{
			get
			{
				return default(ScalerTarget);
			}
			set
			{
			}
		}

		public virtual int MaxLevel
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public virtual float MinBound
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public virtual float MaxBound
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public int CurrentLevel { get; private set; }

		public bool IsMaxLevel => false;

		public bool NotLeveled => false;

		public int GpuImpact { get; internal set; }

		public int CpuImpact { get; internal set; }

		public int OverrideLevel
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int CalculateCost()
		{
			return 0;
		}

		protected virtual void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		internal void IncreaseLevel()
		{
		}

		internal void DecreaseLevel()
		{
		}

		internal void Activate()
		{
		}

		internal void Deactivate()
		{
		}

		public void ApplyDefaultSetting(AdaptivePerformanceScalerSettingsBase defaultSetting)
		{
		}

		protected bool ScaleChanged()
		{
			return false;
		}

		protected virtual void OnLevelIncrease()
		{
		}

		protected virtual void OnLevelDecrease()
		{
		}

		protected virtual void OnLevel()
		{
		}

		protected virtual void OnEnabled()
		{
		}

		protected virtual void OnDisabled()
		{
		}
	}
}
