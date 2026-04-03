using System;
using System.Collections.Generic;
using UnityEngine.UI.Extensions.EasingCore;

namespace UnityEngine.UI.Extensions.Examples.FancyScrollViewExample07
{
	internal class ScrollView : FancyScrollRect<ItemData, Context>
	{
		[SerializeField]
		private float cellSize = 100f;

		[SerializeField]
		private GameObject cellPrefab;

		protected override float CellSize => cellSize;

		protected override GameObject CellPrefab => cellPrefab;

		public int DataCount => base.ItemsSource.Count;

		public float PaddingTop
		{
			get
			{
				return paddingHead;
			}
			set
			{
				paddingHead = value;
				Relayout();
			}
		}

		public float PaddingBottom
		{
			get
			{
				return paddingTail;
			}
			set
			{
				paddingTail = value;
				Relayout();
			}
		}

		public float Spacing
		{
			get
			{
				return spacing;
			}
			set
			{
				spacing = value;
				Relayout();
			}
		}

		public void OnCellClicked(Action<int> callback)
		{
			base.Context.OnCellClicked = callback;
		}

		public void UpdateData(IList<ItemData> items)
		{
			UpdateContents(items);
		}

		public void ScrollTo(int index, float duration, Ease easing, Alignment alignment = Alignment.Middle)
		{
			UpdateSelection(index);
			ScrollTo(index, duration, easing, GetAlignment(alignment));
		}

		public void JumpTo(int index, Alignment alignment = Alignment.Middle)
		{
			UpdateSelection(index);
			JumpTo(index, GetAlignment(alignment));
		}

		private float GetAlignment(Alignment alignment)
		{
			return alignment switch
			{
				Alignment.Upper => 0f, 
				Alignment.Middle => 0.5f, 
				Alignment.Lower => 1f, 
				_ => GetAlignment(Alignment.Middle), 
			};
		}

		private void UpdateSelection(int index)
		{
			if (base.Context.SelectedIndex != index)
			{
				base.Context.SelectedIndex = index;
				Refresh();
			}
		}
	}
}
