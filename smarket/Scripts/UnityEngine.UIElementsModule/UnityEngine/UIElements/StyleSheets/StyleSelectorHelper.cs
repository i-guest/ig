using System;
using System.Collections.Generic;

namespace UnityEngine.UIElements.StyleSheets
{
	internal static class StyleSelectorHelper
	{
		private struct SelectorWorkItem
		{
			public StyleSheet.OrderedSelectorType type;

			public string input;

			public SelectorWorkItem(StyleSheet.OrderedSelectorType type, string input)
			{
				this.type = default(StyleSheet.OrderedSelectorType);
				this.input = null;
			}
		}

		public static MatchResultInfo MatchesSelector(VisualElement element, StyleSelector selector)
		{
			return default(MatchResultInfo);
		}

		public static bool MatchRightToLeft(VisualElement element, StyleComplexSelector complexSelector, Action<VisualElement, MatchResultInfo> processResult)
		{
			return false;
		}

		private static void TestSelectorLinkedList(StyleComplexSelector currentComplexSelector, List<SelectorMatchRecord> matchedSelectors, StyleMatchingContext context, ref SelectorMatchRecord record)
		{
		}

		private static void FastLookup(IDictionary<string, StyleComplexSelector> table, List<SelectorMatchRecord> matchedSelectors, StyleMatchingContext context, string input, ref SelectorMatchRecord record)
		{
		}

		public static void FindMatches(StyleMatchingContext context, List<SelectorMatchRecord> matchedSelectors, int parentSheetIndex)
		{
		}
	}
}
