using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering
{
	internal struct IndirectBufferContextHandles
	{
		public BufferHandle instanceBuffer;

		public BufferHandle instanceInfoBuffer;

		public BufferHandle dispatchArgsBuffer;

		public BufferHandle drawArgsBuffer;

		public BufferHandle drawInfoBuffer;

		public void UseForOcclusionTest(IBaseRenderGraphBuilder builder)
		{
		}
	}
}
