using System.Linq;

namespace UnityEngine.UI.Extensions.Examples.FancyScrollViewExample02
{
	internal class Example02 : MonoBehaviour
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
			ItemData[] items = (from i in Enumerable.Range(0, 20)
				select new ItemData($"Cell {i}")).ToArray();
			scrollView.UpdateData(items);
			scrollView.SelectCell(0);
		}

		private void OnSelectionChanged(int index)
		{
			selectedItemInfo.text = $"Selected item info: index {index}";
		}
	}
}
