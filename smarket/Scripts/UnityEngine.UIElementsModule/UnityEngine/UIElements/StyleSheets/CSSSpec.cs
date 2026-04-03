using System.Text.RegularExpressions;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements.StyleSheets
{
	[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal static class CSSSpec
	{
		private static readonly Regex rgx;

		public static int GetSelectorSpecificity(string selector)
		{
			return 0;
		}

		public static int GetSelectorSpecificity(StyleSelectorPart[] parts)
		{
			return 0;
		}

		public static bool ParseSelector(string selector, out StyleSelectorPart[] parts)
		{
			parts = null;
			return false;
		}
	}
}
