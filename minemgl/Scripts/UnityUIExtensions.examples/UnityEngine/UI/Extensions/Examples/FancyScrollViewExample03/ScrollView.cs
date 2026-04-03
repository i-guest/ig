using System.Collections.Generic;
using UnityEngine.UI.Extensions.EasingCore;

namespace UnityEngine.UI.Extensions.Examples.FancyScrollViewExample03
{
	internal class ScrollView : FancyScrollView<ItemData, Context>
	{
		[SerializeField]
		private Scroller scroller;

		[SerializeField]
		private GameObject cellPrefab;

		protected override GameObject CellPrefab => cellPrefab;

		protected override void Initialize()
		{
			base.Initialize();
			base.Context.OnCellClicked = SelectCell;
			scroller.OnValueChanged(UpdatePosition);
			scroller.OnSelectionChanged(UpdateSelection);
		}

		private void UpdateSelection(int index)
		{
			if (base.Context.SelectedIndex != index)
			{
				base.Context.SelectedIndex = index;
				Refresh();
			}
		}

		public void UpdateData(IList<ItemData> items)
		{
			UpdateContents(items);
			scroller.SetTotalCount(items.Count);
		}

		public void SelectCell(int index)
		{
			if (index >= 0 && index < base.ItemsSource.Count && index != base.Context.SelectedIndex)
			{
				UpdateSelection(index);
				scroller.ScrollTo(index, 0.35f, Ease.OutCubic);
			}
		}
	}
}
