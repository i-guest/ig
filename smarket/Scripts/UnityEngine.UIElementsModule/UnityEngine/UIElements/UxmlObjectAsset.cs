using System;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements
{
	[Serializable]
	[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal class UxmlObjectAsset : UxmlAsset
	{
		[SerializeField]
		private int m_ParentId;

		[SerializeField]
		private bool m_IsField;

		public int parentId
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool isField => false;

		public override bool HasParent()
		{
			return false;
		}

		public UxmlObjectAsset(string fullTypeNameOrFieldName, bool isField, UxmlNamespaceDefinition xmlNamespace = default(UxmlNamespaceDefinition))
			: base(null)
		{
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
	}
}
