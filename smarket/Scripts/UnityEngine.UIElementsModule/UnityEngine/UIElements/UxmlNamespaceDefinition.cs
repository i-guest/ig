using System;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements
{
	[Serializable]
	[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal struct UxmlNamespaceDefinition : IEquatable<UxmlNamespaceDefinition>
	{
		public string prefix;

		public string resolvedNamespace;

		public static UxmlNamespaceDefinition Empty { get; }

		public static bool operator ==(UxmlNamespaceDefinition lhs, UxmlNamespaceDefinition rhs)
		{
			return false;
		}

		public bool Equals(UxmlNamespaceDefinition other)
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
