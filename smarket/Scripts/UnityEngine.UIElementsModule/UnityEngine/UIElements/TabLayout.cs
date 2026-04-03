using System.Collections.Generic;

namespace UnityEngine.UIElements
{
	internal class TabLayout
	{
		private TabView m_TabView;

		private List<VisualElement> m_TabHeaders;

		private bool m_IsVertical;

		public TabLayout(TabView tabView, bool isVertical)
		{
		}

		public static float GetHeight(VisualElement t)
		{
			return 0f;
		}

		public static float GetWidth(VisualElement t)
		{
			return 0f;
		}

		public float GetTabOffset(VisualElement tab)
		{
			return 0f;
		}

		private void InitOrderTabs()
		{
		}

		public void ReorderDisplay(int from, int to)
		{
		}
	}
}
