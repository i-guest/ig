using System.Collections.Generic;

namespace UnityEngine.Accessibility
{
	internal static class AccessibilityHierarchyService
	{
		private static AccessibilityHierarchy s_ActiveHierarchy;

		internal static AccessibilityHierarchy activeHierarchy
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal static IReadOnlyList<AccessibilityNode> GetRootNodes()
		{
			return null;
		}

		internal static bool TryGetNode(int id, out AccessibilityNode node)
		{
			node = null;
			return false;
		}

		internal static bool TryGetNodeAt(float x, float y, out AccessibilityNode node)
		{
			node = null;
			return false;
		}
	}
}
