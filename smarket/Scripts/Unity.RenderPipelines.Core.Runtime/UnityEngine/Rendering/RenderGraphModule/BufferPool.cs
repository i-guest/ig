namespace UnityEngine.Rendering.RenderGraphModule
{
	internal class BufferPool : RenderGraphResourcePool<GraphicsBuffer>
	{
		protected override void ReleaseInternalResource(GraphicsBuffer res)
		{
		}

		protected override string GetResourceName(in GraphicsBuffer res)
		{
			return null;
		}

		protected override long GetResourceSize(in GraphicsBuffer res)
		{
			return 0L;
		}

		protected override string GetResourceTypeName()
		{
			return null;
		}

		protected override int GetSortIndex(GraphicsBuffer res)
		{
			return 0;
		}
	}
}
