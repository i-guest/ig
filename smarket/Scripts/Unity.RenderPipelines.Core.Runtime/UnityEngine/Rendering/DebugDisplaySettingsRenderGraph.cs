namespace UnityEngine.Rendering
{
	internal class DebugDisplaySettingsRenderGraph : IDebugDisplaySettingsData, IDebugDisplaySettingsQuery
	{
		[DisplayInfo(name = "Rendering", order = 10)]
		private class SettingsPanel : DebugDisplaySettingsPanel
		{
			public SettingsPanel(DebugDisplaySettingsRenderGraph _)
			{
			}
		}

		public bool AreAnySettingsActive => false;

		IDebugDisplaySettingsPanelDisposable IDebugDisplaySettingsData.CreatePanel()
		{
			return null;
		}
	}
}
