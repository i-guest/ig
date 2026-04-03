using System.Linq;
using UnityEngine.EventSystems;

namespace UnityEngine.UI.Extensions.Examples.FancyScrollViewExample04
{
	internal class Background : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
	{
		private static class Uniform
		{
			public static readonly int Resolution = Shader.PropertyToID("_Resolution");

			public static readonly int CellState = Shader.PropertyToID("_CellState");
		}

		[SerializeField]
		private Image background;

		[SerializeField]
		private ScrollView scrollView;

		private RectTransform rectTransform;

		private void Start()
		{
			rectTransform = base.transform as RectTransform;
		}

		private void LateUpdate()
		{
			int cellInstanceCount = scrollView.CellInstanceCount;
			scrollView.SetCellState(cellInstanceCount, -1, 500f, -330f + Mathf.Sin(Time.time) * 60f, 2.5f);
			scrollView.SetCellState(cellInstanceCount + 1, -1, -500f, -330f + Mathf.Sin(Time.time) * 60f, 2.5f);
			background.material.SetVector(Uniform.Resolution, rectTransform.rect.size);
			background.material.SetVectorArray(Uniform.CellState, scrollView.GetCellState());
		}

		private bool MetaballContains(Vector2 p, Vector4[] cellState)
		{
			return cellState.Sum((Vector4 x) => f(p - new Vector2(x.x, x.y)) * x.w) * 4600f > 0.46f;
			static float f(Vector2 v)
			{
				return 1f / (v.x * v.x + v.y * v.y + 0.0001f);
			}
		}

		void IPointerClickHandler.OnPointerClick(PointerEventData eventData)
		{
			if (eventData.dragging)
			{
				return;
			}
			RectTransformUtility.ScreenPointToLocalPointInRectangle(rectTransform, eventData.position, eventData.pressEventCamera, out var clickPosition);
			Vector4[] cellState = scrollView.GetCellState();
			if (MetaballContains(clickPosition, cellState))
			{
				int item = (from s in cellState.Take(scrollView.CellInstanceCount)
					select (index: Mathf.RoundToInt(s.z), distance: (new Vector2(s.x, s.y) - clickPosition).sqrMagnitude)).Aggregate(((int index, float distance) min, (int index, float distance) x) => (!(x.distance < min.distance)) ? min : x).index;
				scrollView.SelectCell(item);
			}
		}
	}
}
