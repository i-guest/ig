using System;

namespace UnityEngine.Rendering
{
	public class DebugDisplaySettingsStats<TProfileId> : IDebugDisplaySettingsData, IDebugDisplaySettingsQuery where TProfileId : Enum
	{
		[DisplayInfo(name = "Display Stats", order = -2147483648)]
		private class StatsPanel : DebugDisplaySettingsPanel
		{
			private readonly DebugDisplaySettingsStats<TProfileId> m_Data;

			public override DebugUI.Flags Flags => default(DebugUI.Flags);

			public StatsPanel(DebugDisplaySettingsStats<TProfileId> displaySettingsStats)
			{
			}

			public override void Dispose()
			{
			}
		}

		public DebugDisplayStats<TProfileId> debugDisplayStats { get; }

		public bool AreAnySettingsActive => false;

		public DebugDisplaySettingsStats(DebugDisplayStats<TProfileId> debugDisplayStats)
		{
		}

		public IDebugDisplaySettingsPanelDisposable CreatePanel()
		{
			return null;
		}
	}
}
