using UnityEngine.TextCore.Text;

namespace UnityEngine.UIElements
{
	[HelpURL("UIE-text-setting-asset")]
	public class PanelTextSettings : TextSettings
	{
		private static PanelTextSettings s_DefaultPanelTextSettings;

		internal static PanelTextSettings defaultPanelTextSettings => null;

		internal static void InitializeDefaultPanelTextSettingsIfNull()
		{
		}
	}
}
