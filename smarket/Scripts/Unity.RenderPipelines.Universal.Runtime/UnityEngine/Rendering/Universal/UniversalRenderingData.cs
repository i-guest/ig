namespace UnityEngine.Rendering.Universal
{
	public class UniversalRenderingData : ContextItem
	{
		internal CommandBuffer m_CommandBuffer;

		public CullingResults cullResults;

		public bool supportsDynamicBatching;

		public PerObjectData perObjectData;

		internal CommandBuffer commandBuffer => null;

		public RenderingMode renderingMode { get; internal set; }

		public LayerMask prepassLayerMask { get; internal set; }

		public LayerMask opaqueLayerMask { get; internal set; }

		public LayerMask transparentLayerMask { get; internal set; }

		public bool stencilLodCrossFadeEnabled { get; internal set; }

		public override void Reset()
		{
		}
	}
}
