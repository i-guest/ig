using System;

namespace UnityEngine.UI.Extensions.Examples.FancyScrollViewExample08
{
	internal class Context : FancyGridViewContext
	{
		public int SelectedIndex = -1;

		public Action<int> OnCellClicked;
	}
}
