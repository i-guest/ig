namespace UnityEngine.UI.Extensions
{
	[AddComponentMenu("Layout/Extensions/NonDrawingGraphic")]
	[RequireComponent(typeof(CanvasRenderer))]
	public class NonDrawingGraphic : MaskableGraphic
	{
		public override void SetMaterialDirty()
		{
		}

		public override void SetVerticesDirty()
		{
		}

		protected override void OnPopulateMesh(VertexHelper vh)
		{
			vh.Clear();
		}
	}
}
