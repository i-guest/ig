using System.Collections.Generic;

namespace UnityEngine.UI.Extensions.Examples.FancyScrollViewExample01
{
	internal class ScrollView : FancyScrollView<ItemData>
	{
		[SerializeField]
		private Scroller scroller;

		[SerializeField]
		private GameObject cellPrefab;

		protected override GameObject CellPrefab => cellPrefab;

		protected override void Initialize()
		{
			base.Initialize();
			scroller.OnValueChanged(UpdatePosition);
		}

		public void UpdateData(IList<ItemData> items)
		{
			UpdateContents(items);
			scroller.SetTotalCount(items.Count);
		}
	}
}
