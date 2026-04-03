using System.Collections.Generic;

namespace UnityEngine.UI.Extensions
{
	[AddComponentMenu("UI/Extensions/Primitives/UILineRendererFIFO")]
	[RequireComponent(typeof(RectTransform))]
	public class UILineRendererFIFO : UIPrimitiveBase
	{
		private static readonly Vector2[] middleUvs = new Vector2[4]
		{
			new Vector2(0.5f, 0f),
			new Vector2(0.5f, 1f),
			new Vector2(0.5f, 1f),
			new Vector2(0.5f, 0f)
		};

		private List<Vector2> addedPoints = new List<Vector2>();

		private bool needsResize;

		[SerializeField]
		[Tooltip("Thickness of the line")]
		private float lineThickness = 1f;

		[SerializeField]
		[Tooltip("Points to draw lines between\n Can be improved using the Resolution Option")]
		private List<Vector2> points = new List<Vector2>();

		[SerializeField]
		[Tooltip("Segments to be drawn\n This is a list of arrays of points")]
		private List<UIVertex[]> segments = new List<UIVertex[]>();

		public float LineThickness
		{
			get
			{
				return lineThickness;
			}
			set
			{
				lineThickness = value;
				SetAllDirty();
			}
		}

		public List<Vector2> Points
		{
			get
			{
				return points;
			}
			set
			{
				if (points != value)
				{
					points = value;
					SetAllDirty();
				}
			}
		}

		public void AddPoint(Vector2 point)
		{
			points.Add(point);
			addedPoints.Add(point);
		}

		public void RemovePoint()
		{
			points.RemoveAt(0);
			needsResize = true;
		}

		public void ClearPoints()
		{
			segments.Clear();
			points.Clear();
			addedPoints.Clear();
			needsResize = false;
		}

		public void Resize()
		{
			needsResize = true;
		}

		protected override void OnPopulateMesh(VertexHelper vertexHelper)
		{
			vertexHelper.Clear();
			if (needsResize)
			{
				needsResize = false;
				segments.Clear();
				addedPoints = new List<Vector2>(points);
			}
			int count = addedPoints.Count;
			if (count > 1)
			{
				PopulateMesh(addedPoints, vertexHelper);
				if (count % 2 == 0)
				{
					addedPoints.Clear();
					return;
				}
				Vector2 item = addedPoints[count - 1];
				addedPoints.Clear();
				addedPoints.Add(item);
			}
		}

		private void PopulateMesh(List<Vector2> pointsToDraw, VertexHelper vertexHelper)
		{
			if (base.ImproveResolution != ResolutionMode.None)
			{
				pointsToDraw = IncreaseResolution(pointsToDraw);
			}
			float width = base.rectTransform.rect.width;
			float height = base.rectTransform.rect.height;
			float num = (0f - base.rectTransform.pivot.x) * width;
			float num2 = (0f - base.rectTransform.pivot.y) * height;
			for (int i = 1; i < pointsToDraw.Count; i += 2)
			{
				Vector2 vector = pointsToDraw[i - 1];
				Vector2 vector2 = pointsToDraw[i];
				vector = new Vector2(vector.x * width + num, vector.y * height + num2);
				vector2 = new Vector2(vector2.x * width + num, vector2.y * height + num2);
				UIVertex[] item = CreateLineSegment(vector, vector2, (segments.Count > 1) ? segments[segments.Count - 2] : null);
				segments.Add(item);
			}
			for (int j = 0; j < segments.Count; j++)
			{
				vertexHelper.AddUIVertexQuad(segments[j]);
			}
			if (vertexHelper.currentVertCount > 64000)
			{
				Debug.LogError("Max Verticies size is 64000, current mesh vertcies count is [" + vertexHelper.currentVertCount + "] - Cannot Draw");
				vertexHelper.Clear();
			}
		}

		private UIVertex[] CreateLineSegment(Vector2 start, Vector2 end, UIVertex[] previousVert = null)
		{
			Vector2 vector = new Vector2(start.y - end.y, end.x - start.x).normalized * lineThickness * 0.5f;
			Vector2 vector2;
			Vector2 vector3;
			if (previousVert != null)
			{
				vector2 = new Vector2(previousVert[3].position.x, previousVert[3].position.y);
				vector3 = new Vector2(previousVert[2].position.x, previousVert[2].position.y);
			}
			else
			{
				vector2 = start - vector;
				vector3 = start + vector;
			}
			return SetVbo(new Vector2[4]
			{
				vector2,
				vector3,
				end + vector,
				end - vector
			}, middleUvs);
		}
	}
}
