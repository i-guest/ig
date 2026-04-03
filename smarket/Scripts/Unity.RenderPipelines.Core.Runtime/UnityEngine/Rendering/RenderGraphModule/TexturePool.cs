namespace UnityEngine.Rendering.RenderGraphModule
{
	internal class TexturePool : RenderGraphResourcePool<RTHandle>
	{
		protected override void ReleaseInternalResource(RTHandle res)
		{
		}

		protected override string GetResourceName(in RTHandle res)
		{
			return null;
		}

		protected override long GetResourceSize(in RTHandle res)
		{
			return 0L;
		}

		protected override string GetResourceTypeName()
		{
			return null;
		}

		protected override int GetSortIndex(RTHandle res)
		{
			return 0;
		}
	}
}
