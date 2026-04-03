using System.Collections.Generic;

namespace UnityEngine.UIElements
{
	public class MultiColumnListViewController : BaseListViewController
	{
		private MultiColumnController m_ColumnController;

		public MultiColumnController columnController => null;

		public MultiColumnListViewController(Columns columns, SortColumnDescriptions sortDescriptions, List<SortColumnDescription> sortedColumns)
		{
		}

		internal override void PreRefresh()
		{
		}

		private void SortIfNeeded()
		{
		}

		internal override void InvokeMakeItem(ReusableCollectionItem reusableItem)
		{
		}

		internal override void InvokeBindItem(ReusableCollectionItem reusableItem, int index)
		{
		}

		public override object GetItemForIndex(int index)
		{
			return null;
		}

		public override int GetIndexForId(int id)
		{
			return 0;
		}

		public override int GetIdForIndex(int index)
		{
			return 0;
		}

		protected override VisualElement MakeItem()
		{
			return null;
		}

		protected override void BindItem(VisualElement element, int index)
		{
		}

		protected override void UnbindItem(VisualElement element, int index)
		{
		}

		protected override void DestroyItem(VisualElement element)
		{
		}

		protected override void PrepareView()
		{
		}

		public override void Dispose()
		{
		}

		private void UpdateReorderClassList()
		{
		}
	}
}
