namespace UnityEngine.Rendering.Universal
{
	internal class DebugDisplaySettingsCommon : IDebugDisplaySettingsData, IDebugDisplaySettingsQuery
	{
		[DisplayInfo(name = "Frequently Used", order = -1)]
		private class SettingsPanel : DebugDisplaySettingsPanel
		{
			private const string k_GoToSectionString = "Go to Section...";

			public override DebugUI.Flags Flags => default(DebugUI.Flags);
		}

		public bool AreAnySettingsActive => false;

		public IDebugDisplaySettingsPanelDisposable CreatePanel()
		{
			return null;
		}
	}
}
