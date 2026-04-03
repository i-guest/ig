using System;
using System.Collections.Generic;
using UnityEngine.UI.Extensions.EasingCore;

namespace UnityEngine.UI.Extensions.Examples.FancyScrollViewExample04
{
	internal class ScrollView : FancyScrollView<ItemData, Context>
	{
		[SerializeField]
		private Scroller scroller;

		[SerializeField]
		private GameObject cellPrefab;

		private Action<int> onSelectionChanged;

		protected override GameObject CellPrefab => cellPrefab;

		public int CellInstanceCount => Mathf.CeilToInt(1f / Mathf.Max(cellInterval, 0.001f));

		protected override void Initialize()
		{
			base.Initialize();
			base.Context.OnCellClicked = SelectCell;
			scroller.OnValueChanged(UpdatePosition);
			scroller.OnSelectionChanged(UpdateSelection);
		}

		public void UpdateSelection(int index)
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
				ScrollTo(index, 0.35f, Ease.OutCubic);
			}
		}

		public void ScrollTo(float position, float duration, Ease easing, Action onComplete = null)
		{
			scroller.ScrollTo(position, duration, easing, onComplete);
		}

		public void JumpTo(int index)
		{
			scroller.JumpTo(index);
		}

		public Vector4[] GetCellState()
		{
			base.Context.UpdateCellState?.Invoke();
			return base.Context.CellState;
		}

		public void SetCellState(int cellIndex, int dataIndex, float x, float y, float scale)
		{
			base.Context.SetCellState(cellIndex, dataIndex, x, y, scale);
		}
	}
}
