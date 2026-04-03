using System;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements
{
	[Serializable]
	[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal class StyleRule
	{
		[SerializeField]
		private StyleComplexSelector[] m_ComplexSelectors;

		[SerializeField]
		private StyleProperty[] m_Properties;

		[SerializeField]
		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal int line;

		[NonSerialized]
		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal int customPropertiesCount;

		[field: NonSerialized]
		internal StyleSheet styleSheet { get; set; }

		public StyleComplexSelector[] complexSelectors => null;

		public StyleProperty[] properties => null;

		internal StyleRule(StyleSheet styleSheet)
		{
		}

		public bool TryAddSelector(string selectorStr, out StyleComplexSelector selector, out string error)
		{
			selector = null;
			error = null;
			return false;
		}

		public StyleComplexSelector AddSelector(string selectorStr)
		{
			return null;
		}

		public StyleProperty AddProperty(string propertyName)
		{
			return null;
		}
	}
}
