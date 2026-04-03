using System;
using System.Collections.Generic;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements
{
	[Serializable]
	[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule", "UnityEditor.UIToolkitAuthoringModule" })]
	internal class TemplateAsset : VisualElementAsset
	{
		[Serializable]
		public struct AttributeOverride
		{
			public string m_ElementName;

			public string[] m_NamesPath;

			public string m_AttributeName;

			public string m_Value;

			public bool NamesPathMatchesElementNamesPath(IList<string> elementNamesPath)
			{
				return false;
			}
		}

		[Serializable]
		public struct UxmlSerializedDataOverride
		{
			public int m_ElementId;

			public List<int> m_ElementIdsPath;

			[SerializeReference]
			public UxmlSerializedData m_SerializedData;
		}

		public static readonly string UxmlInstanceTypeName;

		[SerializeField]
		private string m_TemplateAlias;

		[SerializeField]
		private List<AttributeOverride> m_AttributeOverrides;

		[SerializeField]
		private List<VisualTreeAsset.SlotUsageEntry> m_SlotUsages;

		public string templateAlias => null;

		public List<AttributeOverride> attributeOverrides => null;

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal List<VisualTreeAsset.SlotUsageEntry> slotUsages
		{
			[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
			get
			{
				return null;
			}
		}
	}
}
