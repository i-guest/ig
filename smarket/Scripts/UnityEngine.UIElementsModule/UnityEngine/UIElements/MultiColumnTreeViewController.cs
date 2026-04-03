using System.Collections.Generic;

namespace UnityEngine.UIElements
{
	public abstract class MultiColumnTreeViewController : BaseTreeViewController
	{
		private MultiColumnController m_ColumnController;

		public MultiColumnController columnController => null;

		protected MultiColumnTreeViewController(Columns columns, SortColumnDescriptions sortDescriptions, List<SortColumnDescription> sortedColumns)
		{
		}

		internal override void PreRefresh()
		{
		}

		internal override void InvokeMakeItem(ReusableCollectionItem reusableItem)
		{
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
	}
}
