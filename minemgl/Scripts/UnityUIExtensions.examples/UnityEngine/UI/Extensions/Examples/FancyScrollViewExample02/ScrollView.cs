using System;
using System.Collections.Generic;
using UnityEngine.UI.Extensions.EasingCore;

namespace UnityEngine.UI.Extensions.Examples.FancyScrollViewExample02
{
	internal class ScrollView : FancyScrollView<ItemData, Context>
	{
		[SerializeField]
		private Scroller scroller;

		[SerializeField]
		private GameObject cellPrefab;

		private Action<int> onSelectionChanged;

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
				onSelectionChanged?.Invoke(index);
			}
		}

		public void UpdateData(IList<ItemData> items)
		{
			UpdateContents(items);
			scroller.SetTotalCount(items.Count);
		}

		public void OnSelectionChanged(Action<int> callback)
		{
			onSelectionChanged = callback;
		}

		public void SelectNextCell()
		{
			SelectCell(base.Context.SelectedIndex + 1);
		}

		public void SelectPrevCell()
		{
			SelectCell(base.Context.SelectedIndex - 1);
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
