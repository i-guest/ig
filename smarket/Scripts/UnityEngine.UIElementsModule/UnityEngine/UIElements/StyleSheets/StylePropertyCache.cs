using System.Collections.Generic;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements.StyleSheets
{
	[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal static class StylePropertyCache
	{
		internal static readonly Dictionary<string, string> s_PropertySyntaxCache;

		internal static readonly Dictionary<string, string> s_NonTerminalValues;

		public static bool TryGetSyntax(string name, out string syntax)
		{
			syntax = null;
			return false;
		}

		public static bool TryGetNonTerminalValue(string name, out string syntax)
		{
			syntax = null;
			return false;
		}
	}
}
