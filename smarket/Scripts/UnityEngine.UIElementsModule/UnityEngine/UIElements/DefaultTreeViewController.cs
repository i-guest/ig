using System.Collections;
using System.Collections.Generic;

namespace UnityEngine.UIElements
{
	public class DefaultTreeViewController<T> : TreeViewController
	{
		private TreeDataController<T> m_TreeDataController;

		private TreeDataController<T> treeDataController => null;

		public override IList itemsSource
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void SetRootItems(IList<TreeViewItemData<T>> items)
		{
		}

		public override object GetItemForIndex(int index)
		{
			return null;
		}
	}
}
