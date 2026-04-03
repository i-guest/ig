using System;
using System.Collections.Generic;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements
{
	[Serializable]
	[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule", "UnityEditor.UIToolkitAuthoringModule" })]
	internal class VisualElementAsset : UxmlAsset
	{
		internal const string k_LostInlineStyles = "VisualElementAsset previously had inline styles that were lost.";

		[SerializeField]
		private int m_RuleIndex;

		[SerializeField]
		private string[] m_Classes;

		[SerializeField]
		private List<string> m_StylesheetPaths;

		[SerializeField]
		private List<StyleSheet> m_Stylesheets;

		[SerializeReference]
		private UxmlSerializedData m_SerializedData;

		[SerializeField]
		private bool m_SkipClone;

		public int ruleIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public string[] classes => null;

		public List<string> stylesheetPaths => null;

		public bool hasStylesheetPaths => false;

		public List<StyleSheet> stylesheets => null;

		public bool hasStylesheets => false;

		public UxmlSerializedData serializedData => null;

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal bool skipClone => false;

		public VisualElementAsset(string fullTypeName, UxmlNamespaceDefinition xmlNamespace = default(UxmlNamespaceDefinition))
			: base(null)
		{
		}

		private static bool IdsPathMatchesAttributeOverrideIdsPath(List<int> idsPath, List<int> attributeOverrideIdsPath, int templateId)
		{
			return false;
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal virtual VisualElement Instantiate(CreationContext cc)
		{
			return null;
		}

		internal override bool Accepts(UxmlAsset asset, out string errorMessage)
		{
			errorMessage = null;
			return false;
		}

		public override string ToString()
		{
			return null;
		}

		private protected override void OnVisualTreeAssetChanged(VisualTreeAsset previousVta, VisualTreeAsset newVta)
		{
		}
	}
}
