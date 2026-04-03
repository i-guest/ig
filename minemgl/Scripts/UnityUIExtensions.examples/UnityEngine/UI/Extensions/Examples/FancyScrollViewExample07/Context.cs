using System;

namespace UnityEngine.UI.Extensions.Examples.FancyScrollViewExample07
{
	internal class Context : FancyScrollRectContext
	{
		public int SelectedIndex = -1;

		public Action<int> OnCellClicked;
	}
}
