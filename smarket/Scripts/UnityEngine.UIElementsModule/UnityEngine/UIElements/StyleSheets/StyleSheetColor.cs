using System.Collections.Generic;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements.StyleSheets
{
	[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal static class StyleSheetColor
	{
		private static Dictionary<string, Color32> s_NameToColor;

		public static bool TryGetColor(string name, out Color color)
		{
			color = default(Color);
			return false;
		}

		private static Color32 HexToColor32(uint color)
		{
			return default(Color32);
		}
	}
}
