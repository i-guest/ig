namespace UnityEngine.AdaptivePerformance
{
	public abstract class AdaptivePerformanceLoader : ScriptableObject
	{
		public abstract bool Initialized { get; }

		public abstract bool Running { get; }

		public virtual bool Initialize()
		{
			return false;
		}

		public virtual bool Start()
		{
			return false;
		}

		public virtual bool Stop()
		{
			return false;
		}

		public virtual bool Deinitialize()
		{
			return false;
		}

		public abstract T GetLoadedSubsystem<T>() where T : class;

		public abstract ISubsystem GetDefaultSubsystem();

		public abstract IAdaptivePerformanceSettings GetSettings();
	}
}
