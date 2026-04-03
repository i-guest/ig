namespace UnityEngine.UIElements.UIR
{
	internal abstract class BaseElementBuilder
	{
		public abstract bool RequiresStencilMask(VisualElement ve);

		public void Build(MeshGenerationContext mgc)
		{
		}

		private void BuildRenderTreeQuadElement(MeshGenerationContext mgc)
		{
		}

		private void BuildStandardElement(MeshGenerationContext mgc)
		{
		}

		protected abstract void DrawVisualElementBackground(MeshGenerationContext mgc);

		protected abstract void DrawVisualElementBorder(MeshGenerationContext mgc);

		protected abstract void DrawVisualElementStencilMask(MeshGenerationContext mgc);

		public abstract void ScheduleMeshGenerationJobs(MeshGenerationContext mgc);

		private void PushVisualElementClipping(MeshGenerationContext mgc)
		{
		}

		private static void PopVisualElementClipping(MeshGenerationContext mgc)
		{
		}

		private static void InvokeGenerateVisualContent(MeshGenerationContext mgc)
		{
		}
	}
}
