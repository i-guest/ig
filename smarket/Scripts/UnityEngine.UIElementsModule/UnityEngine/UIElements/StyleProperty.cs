using System;
using UnityEngine.Bindings;
using UnityEngine.UIElements.StyleSheets;

namespace UnityEngine.UIElements
{
	[Serializable]
	[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal class StyleProperty
	{
		[SerializeField]
		private StylePropertyId m_Id;

		[SerializeField]
		private string m_CustomName;

		[SerializeField]
		private int m_Line;

		[SerializeField]
		private StyleValueHandle[] m_Values;

		[NonSerialized]
		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal bool requireVariableResolve;

		internal StylePropertyId id => default(StylePropertyId);

		public string name
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

		public StyleValueHandle[] values
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

		internal int handleCount
		{
			[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
			get
			{
				return 0;
			}
		}

		internal bool isCustomProperty
		{
			[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
			get
			{
				return false;
			}
		}

		internal StyleProperty()
		{
		}

		internal void CacheId(string value)
		{
		}

		public bool TryGetMaterialDefinition(StyleSheet styleSheet, out MaterialDefinition value)
		{
			value = default(MaterialDefinition);
			return false;
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal static FilterFunctionType ToFilterFunctionType(StyleValueFunction function)
		{
			return default(FilterFunctionType);
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal static float ConvertDimensionToFilterFloat(Dimension dim)
		{
			return 0f;
		}
	}
}
