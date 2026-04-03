using System;
using System.Collections.Generic;

namespace UnityEngine.Rendering
{
	public abstract class DebugDisplaySettings<T> : IDebugDisplaySettings where T : IDebugDisplaySettings, new()
	{
		private class IDebugDisplaySettingsDataComparer : IEqualityComparer<IDebugDisplaySettingsData>
		{
			public bool Equals(IDebugDisplaySettingsData x, IDebugDisplaySettingsData y)
			{
				return false;
			}

			public int GetHashCode(IDebugDisplaySettingsData obj)
			{
				return 0;
			}
		}

		protected readonly HashSet<IDebugDisplaySettingsData> m_Settings;

		private static readonly Lazy<T> s_Instance;

		public static T Instance => default(T);

		public virtual bool AreAnySettingsActive => false;

		public virtual bool IsPostProcessingAllowed => false;

		public virtual bool IsLightingActive => false;

		protected TData Add<TData>(TData newData) where TData : IDebugDisplaySettingsData
		{
			return default(TData);
		}

		IDebugDisplaySettingsData IDebugDisplaySettings.Add(IDebugDisplaySettingsData newData)
		{
			return null;
		}

		public void ForEach(Action<IDebugDisplaySettingsData> onExecute)
		{
		}

		public virtual void Reset()
		{
		}

		public virtual bool TryGetScreenClearColor(ref Color color)
		{
			return false;
		}
	}
}
