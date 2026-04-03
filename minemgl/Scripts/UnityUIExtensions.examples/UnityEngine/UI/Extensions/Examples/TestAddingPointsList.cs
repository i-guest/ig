namespace UnityEngine.UI.Extensions.Examples
{
	public class TestAddingPointsList : MonoBehaviour
	{
		public UILineRendererList LineRenderer;

		public Text XValue;

		public Text YValue;

		public void AddNewPoint()
		{
			Vector2 pointToAdd = new Vector2
			{
				x = float.Parse(XValue.text),
				y = float.Parse(YValue.text)
			};
			LineRenderer.AddPoint(pointToAdd);
		}

		public void ClearPoints()
		{
			if (LineRenderer != null && LineRenderer.Points != null)
			{
				LineRenderer.ClearPoints();
			}
		}
	}
}
