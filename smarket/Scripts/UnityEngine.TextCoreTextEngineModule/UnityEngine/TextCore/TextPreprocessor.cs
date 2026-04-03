using System;
using UnityEngine.Bindings;
using UnityEngine.TextCore.Text;

namespace UnityEngine.TextCore
{
	[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
	internal static class TextPreprocessor
	{
		[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
		internal static void PreProcessString(ref string text, PreProcessFlags flags, TextSettings? textSettings)
		{
		}

		private static int GetStyleHashCode(ReadOnlySpan<char> text)
		{
			return 0;
		}

		private static TextStyle GetStyle(TextSettings textSettings, int hashCode)
		{
			return null;
		}

		internal static string ReplaceStyleTags(string text, TextSettings textSettings)
		{
			return null;
		}
	}
}
