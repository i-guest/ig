using System;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements
{
	[Serializable]
	[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal class StyleSelector
	{
		[SerializeField]
		private StyleSelectorPart[] m_Parts;

		[SerializeField]
		private StyleSelectorRelationship m_PreviousRelationship;

		public const int InvalidPseudoStateMask = -1;

		internal int pseudoStateMask;

		internal int negatedPseudoStateMask;

		public StyleSelectorPart[] parts
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

		public StyleSelectorRelationship previousRelationship
		{
			get
			{
				return default(StyleSelectorRelationship);
			}
			[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
			internal set
			{
			}
		}

		public override string ToString()
		{
			return null;
		}
	}
}
