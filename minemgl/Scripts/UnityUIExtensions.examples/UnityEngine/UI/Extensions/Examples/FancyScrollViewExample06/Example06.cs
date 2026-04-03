using System.Collections.Generic;
using System.Linq;

namespace UnityEngine.UI.Extensions.Examples.FancyScrollViewExample06
{
	internal class Example06 : MonoBehaviour
	{
		[SerializeField]
		private ScrollView scrollView;

		[SerializeField]
		private Text selectedItemInfo;

		[SerializeField]
		private Window[] windows;

		private Window currentWindow;

		private void Start()
		{
			scrollView.OnSelectionChanged(OnSelectionChanged);
			List<ItemData> items = (from i in Enumerable.Range(0, windows.Length)
				select new ItemData($"Tab {i}")).ToList();
			scrollView.UpdateData(items);
			scrollView.SelectCell(0);
		}

		private void OnSelectionChanged(int index, MovementDirection direction)
		{
			selectedItemInfo.text = $"Selected tab info: index {index}";
			if (currentWindow != null)
			{
				currentWindow.Out(direction);
				currentWindow = null;
			}
			if (index >= 0 && index < windows.Length)
			{
				currentWindow = windows[index];
				currentWindow.In(direction);
			}
		}
	}
}
