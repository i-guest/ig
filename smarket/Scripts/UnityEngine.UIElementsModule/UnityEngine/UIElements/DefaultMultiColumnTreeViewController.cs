using System.Collections;
using System.Collections.Generic;

namespace UnityEngine.UIElements
{
	public class DefaultMultiColumnTreeViewController<T> : MultiColumnTreeViewController
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

		public DefaultMultiColumnTreeViewController(Columns columns, SortColumnDescriptions sortDescriptions, List<SortColumnDescription> sortedColumns)
			: base(null, null, null)
		{
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
