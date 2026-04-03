using UnityEngine.Bindings;

namespace UnityEngine.UIElements
{
	[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal static class SelectorUtility
	{
		public static bool ExtractSelectorsAndSpecificityFromString(string complexSelectorStr, out StyleSelector[] selectors, out int specificity, out string error)
		{
			selectors = null;
			specificity = default(int);
			error = null;
			return false;
		}
	}
}
