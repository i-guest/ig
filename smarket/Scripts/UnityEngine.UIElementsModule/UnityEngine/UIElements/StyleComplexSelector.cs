using System;
using System.Collections.Generic;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements
{
	[Serializable]
	[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal class StyleComplexSelector
	{
		private struct PseudoStateData
		{
			public readonly PseudoStates state;

			public readonly bool negate;

			public PseudoStateData(PseudoStates state, bool negate)
			{
				this.state = default(PseudoStates);
				this.negate = false;
			}
		}

		[NonSerialized]
		public Hashes ancestorHashes;

		[SerializeField]
		private int m_Specificity;

		[SerializeField]
		private StyleSelector[] m_Selectors;

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		[SerializeField]
		internal int ruleIndex;

		[NonSerialized]
		internal StyleComplexSelector nextInTable;

		[NonSerialized]
		internal int orderInStyleSheet;

		private static Dictionary<string, PseudoStateData> s_PseudoStates;

		private static readonly List<StyleSelectorPart> s_HashList;

		public int specificity
		{
			get
			{
				return 0;
			}
			internal set
			{
			}
		}

		[field: NonSerialized]
		public StyleRule rule
		{
			get; [VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
			internal set;
		}

		public bool isSimple => false;

		public StyleSelector[] selectors
		{
			get
			{
				return null;
			}
			[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
			internal set
			{
			}
		}

		internal StyleComplexSelector()
		{
		}

		internal void CachePseudoStateMasks(StyleSheet styleSheet)
		{
		}

		public override string ToString()
		{
			return null;
		}

		private static int StyleSelectorPartCompare(StyleSelectorPart x, StyleSelectorPart y)
		{
			return 0;
		}

		internal void CalculateHashes()
		{
		}
	}
}
