using System;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements.StyleSheets
{
	[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal struct SelectorMatchRecord : IEquatable<SelectorMatchRecord>
	{
		public StyleSheet sheet;

		public int styleSheetIndexInStack;

		public StyleComplexSelector complexSelector;

		public SelectorMatchRecord(StyleSheet sheet, int styleSheetIndexInStack)
		{
			this.sheet = null;
			this.styleSheetIndexInStack = 0;
			complexSelector = null;
		}

		public static int Compare(SelectorMatchRecord a, SelectorMatchRecord b)
		{
			return 0;
		}

		public bool Equals(SelectorMatchRecord other)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
