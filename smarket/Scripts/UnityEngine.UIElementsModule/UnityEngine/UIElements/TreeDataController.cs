using System;
using System.Collections.Generic;
using Unity.Hierarchy;

namespace UnityEngine.UIElements
{
	internal sealed class TreeDataController<T>
	{
		private Dictionary<HierarchyNode, TreeViewItemData<T>> m_NodeToItemDataDictionary;

		private Stack<IEnumerator<TreeViewItemData<T>>> m_ItemStack;

		private Stack<HierarchyNode> m_NodeStack;

		public T GetDataForNode(HierarchyNode node)
		{
			return default(T);
		}

		internal void ConvertTreeViewItemDataToHierarchy(IEnumerable<TreeViewItemData<T>> list, Func<HierarchyNode, HierarchyNode> createNode, Action<int, HierarchyNode> updateDictionary)
		{
		}

		internal void UpdateNodeToDataDictionary(HierarchyNode node, TreeViewItemData<T> item)
		{
		}

		internal void ClearNodeToDataDictionary()
		{
		}
	}
}
