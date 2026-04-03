using System;
using System.Collections.Generic;
using UnityEngine.UI.Extensions.EasingCore;

namespace UnityEngine.UI.Extensions.Examples.FancyScrollViewExample06
{
	internal class ScrollView : FancyScrollView<ItemData, Context>
	{
		[SerializeField]
		private Scroller scroller;

		[SerializeField]
		private GameObject cellPrefab;

		private Action<int, MovementDirection> onSelectionChanged;

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
				MovementDirection movementDirection = scroller.GetMovementDirection(base.Context.SelectedIndex, index);
				base.Context.SelectedIndex = index;
				Refresh();
				onSelectionChanged?.Invoke(index, movementDirection);
			}
		}

		public void UpdateData(IList<ItemData> items)
		{
			UpdateContents(items);
			scroller.SetTotalCount(items.Count);
		}

		public void OnSelectionChanged(Action<int, MovementDirection> callback)
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
				scroller.ScrollTo(index, 0.35f, Ease.OutCubic);
			}
		}
	}
}
