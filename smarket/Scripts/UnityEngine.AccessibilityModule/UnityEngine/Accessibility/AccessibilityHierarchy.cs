using System.Collections.Generic;

namespace UnityEngine.Accessibility
{
	public class AccessibilityHierarchy
	{
		private readonly IDictionary<int, AccessibilityNode> m_Nodes;

		private List<AccessibilityNode> m_RootNodes;

		public IReadOnlyList<AccessibilityNode> rootNodes => null;

		public bool TryGetNode(int id, out AccessibilityNode node)
		{
			node = null;
			return false;
		}

		public bool TryGetNodeAt(float horizontalPosition, float verticalPosition, out AccessibilityNode node)
		{
			node = null;
			return false;
		}

		public void RefreshNodeFrames()
		{
		}

		internal void AllocateNative()
		{
		}

		internal void FreeNative()
		{
		}
	}
}
