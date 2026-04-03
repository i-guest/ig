using System;
using UnityEngine.UI.Extensions.EasingCore;

namespace UnityEngine.UI.Extensions.Examples.FancyScrollViewExample08
{
	internal class GridView : FancyGridView<ItemData, Context>
	{
		private class CellGroup : DefaultCellGroup
		{
		}

		[SerializeField]
		private Cell cellPrefab;

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

		public float SpacingY
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

		public float SpacingX
		{
			get
			{
				return startAxisSpacing;
			}
			set
			{
				startAxisSpacing = value;
				Relayout();
			}
		}

		protected override void SetupCellTemplate()
		{
			Setup<CellGroup>(cellPrefab);
		}

		public void UpdateSelection(int index)
		{
			if (base.Context.SelectedIndex != index)
			{
				base.Context.SelectedIndex = index;
				Refresh();
			}
		}

		public void OnCellClicked(Action<int> callback)
		{
			base.Context.OnCellClicked = callback;
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
	}
}
