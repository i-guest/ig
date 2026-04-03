using System.Linq;

namespace UnityEngine.UI.Extensions.Examples.FancyScrollViewExample03
{
	internal class Example03 : MonoBehaviour
	{
		[SerializeField]
		private ScrollView scrollView;

		private void Start()
		{
			ItemData[] items = (from i in Enumerable.Range(0, 20)
				select new ItemData($"Cell {i}")).ToArray();
			scrollView.UpdateData(items);
			scrollView.SelectCell(0);
		}
	}
}
