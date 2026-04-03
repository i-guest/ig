using System;
using System.Collections.Generic;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements
{
	[Serializable]
	[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal abstract class UxmlAsset : IUxmlAttributes
	{
		public const string NullNodeType = "null";

		[SerializeField]
		private string m_FullTypeName;

		[SerializeField]
		private UxmlNamespaceDefinition m_XmlNamespace;

		[SerializeField]
		private int m_Id;

		[SerializeReference]
		[HideInInspector]
		private UxmlAsset m_Parent;

		[SerializeReference]
		private List<UxmlAsset> m_Children;

		[SerializeField]
		private VisualTreeAsset m_VisualTreeAsset;

		[SerializeField]
		private List<UxmlNamespaceDefinition> m_NamespaceDefinitions;

		[SerializeField]
		protected List<UxmlProperty> m_Properties;

		public string fullTypeName => null;

		public int id
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool isRoot => false;

		public UxmlAsset parentAsset => null;

		internal VisualTreeAsset visualTreeAsset => null;

		public int childCount => 0;

		public UxmlAsset this[int index] => null;

		public List<UxmlNamespaceDefinition> namespaceDefinitions => null;

		public UxmlAsset(string fullTypeName, UxmlNamespaceDefinition xmlNamespace = default(UxmlNamespaceDefinition))
		{
		}

		public void GetChildrenUxmlObjectAssets(List<UxmlObjectAsset> children)
		{
		}

		public UxmlObjectAsset GetField(string fieldName)
		{
			return null;
		}

		internal void SetVisualTreeAssetWithOutNotify(VisualTreeAsset vta)
		{
		}

		internal void SetVisualTreeAsset(VisualTreeAsset vta)
		{
		}

		public void Add(UxmlAsset asset)
		{
		}

		public void Insert(int index, UxmlAsset asset)
		{
		}

		private void InsertInChildren(int index, UxmlAsset asset)
		{
		}

		private void RemoveFromChildren(UxmlAsset child)
		{
		}

		private void RemoveFromChildren(int index)
		{
		}

		private void SetParent(UxmlAsset parent)
		{
		}

		private protected virtual void OnVisualTreeAssetChanged(VisualTreeAsset previousVta, VisualTreeAsset newVta)
		{
		}

		public int IndexOf(UxmlAsset asset)
		{
			return 0;
		}

		public bool IsAncestorOf(UxmlAsset other)
		{
			return false;
		}

		public virtual bool HasParent()
		{
			return false;
		}

		public bool TryGetAttributeValue(string propertyName, out string value)
		{
			value = null;
			return false;
		}

		public void SetAttribute(string name, string value)
		{
		}

		public void RemoveAttribute(string attributeName)
		{
		}

		private void SetOrAddProperty(string propertyName, string propertyValue)
		{
		}

		internal abstract bool Accepts(UxmlAsset asset, out string errorMessage);

		public override string ToString()
		{
			return null;
		}
	}
}
