using System.Collections.Generic;
using System.Linq;
using UnityEngine.EventSystems;

namespace UnityEngine.UI.Extensions.Examples.FancyScrollViewExample05
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
			Vector2 vector = rectTransform.rect.size * 0.5f;
			int cellInstanceCount = scrollView.CellInstanceCount;
			scrollView.SetCellState(cellInstanceCount, -1, vector.x, (0f - vector.y) * 1.3f, 0f);
			scrollView.SetCellState(cellInstanceCount + 1, -1, 0f - vector.x, vector.y * 1.3f, 0f);
			scrollView.SetCellState(cellInstanceCount + 2, -1, 0f - vector.x, (0f - vector.y) * 1.3f, 0f);
			scrollView.SetCellState(cellInstanceCount + 3, -1, vector.x, vector.y * 1.3f, 0f);
			background.material.SetVector(Uniform.Resolution, rectTransform.rect.size);
			background.material.SetVectorArray(Uniform.CellState, scrollView.GetCellState());
		}

		void IPointerClickHandler.OnPointerClick(PointerEventData eventData)
		{
			if (!eventData.dragging)
			{
				RectTransformUtility.ScreenPointToLocalPointInRectangle(rectTransform, eventData.position, eventData.pressEventCamera, out var clickPosition);
				IEnumerable<(int, int, Vector2)> source = scrollView.GetCellState().Select((Vector4 s, int i) => (index: i, dataIndex: Mathf.RoundToInt(s.z), position: new Vector2(s.x, s.y)));
				(int index, int dataIndex, Vector2 position) target = source.OrderBy<(int, int, Vector2), float>(((int index, int dataIndex, Vector2 position) x) => (x.position - clickPosition).sqrMagnitude).First();
				if (!(source.Where<(int, int, Vector2)>(((int index, int dataIndex, Vector2 position) x) => x.index != target.index).Min<(int, int, Vector2)>(((int index, int dataIndex, Vector2 position) x) => Vector2.Dot(clickPosition - (target.position + x.position) * 0.5f, (target.position - x.position).normalized)) < 9f))
				{
					scrollView.SelectCell(target.dataIndex);
				}
			}
		}
	}
}
