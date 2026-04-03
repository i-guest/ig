using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering
{
	internal struct OccluderHandles
	{
		public TextureHandle occluderDepthPyramid;

		public BufferHandle occlusionDebugOverlay;

		public bool IsValid()
		{
			return false;
		}

		public void UseForOcclusionTest(IBaseRenderGraphBuilder builder)
		{
		}

		public void UseForOccluderUpdate(IBaseRenderGraphBuilder builder)
		{
		}
	}
}
