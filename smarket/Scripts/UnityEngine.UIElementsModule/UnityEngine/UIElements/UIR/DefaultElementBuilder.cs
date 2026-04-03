namespace UnityEngine.UIElements.UIR
{
	internal class DefaultElementBuilder : BaseElementBuilder
	{
		private RenderTreeManager m_RenderTreeManager;

		public DefaultElementBuilder(RenderTreeManager renderTreeManager)
		{
		}

		public override bool RequiresStencilMask(VisualElement ve)
		{
			return false;
		}

		protected override void DrawVisualElementBackground(MeshGenerationContext mgc)
		{
		}

		protected override void DrawVisualElementBorder(MeshGenerationContext mgc)
		{
		}

		protected override void DrawVisualElementStencilMask(MeshGenerationContext mgc)
		{
		}

		private static void GenerateStencilClipEntryForRoundedRectBackground(MeshGenerationContext mgc)
		{
		}

		public override void ScheduleMeshGenerationJobs(MeshGenerationContext mgc)
		{
		}
	}
}
