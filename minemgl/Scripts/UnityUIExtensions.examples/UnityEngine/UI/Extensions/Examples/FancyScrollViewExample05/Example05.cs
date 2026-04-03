using System.Collections.Generic;
using System.Linq;

namespace UnityEngine.UI.Extensions.Examples.FancyScrollViewExample05
{
	internal class Example05 : MonoBehaviour
	{
		[SerializeField]
		private ScrollView scrollView;

		[SerializeField]
		private Button prevCellButton;

		[SerializeField]
		private Button nextCellButton;

		[SerializeField]
		private Text selectedItemInfo;

		private void Start()
		{
			prevCellButton.onClick.AddListener(scrollView.SelectPrevCell);
			nextCellButton.onClick.AddListener(scrollView.SelectNextCell);
			scrollView.OnSelectionChanged(OnSelectionChanged);
			List<ItemData> items = (from i in Enumerable.Range(0, 20)
				select new ItemData($"Cell {i}")).ToList();
			scrollView.UpdateData(items);
			scrollView.UpdateSelection(10);
			scrollView.JumpTo(10);
		}

		private void OnSelectionChanged(int index)
		{
			selectedItemInfo.text = $"Selected item info: index {index}";
		}
	}
}
