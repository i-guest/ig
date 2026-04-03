using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal
{
	internal sealed class StencilCrossFadeRenderPass
	{
		private class PassData
		{
			public TextureHandle depthTarget;

			public Material[] stencilDitherMaskSeedMaterials;
		}

		private Material[] m_StencilDitherMaskSeedMaterials;

		private readonly int _StencilDitherPattern;

		private readonly int _StencilRefDitherMask;

		private readonly int _StencilWriteDitherMask;

		private readonly ProfilingSampler m_ProfilingSampler;

		internal StencilCrossFadeRenderPass(Shader shader)
		{
		}

		public void Dispose()
		{
		}

		public void Render(RenderGraph renderGraph, ScriptableRenderContext context, TextureHandle depthTarget)
		{
		}

		private static void ExecutePass(RasterCommandBuffer cmd, RTHandle depthTarget, Material[] stencilDitherMaskSeedMaterials)
		{
		}
	}
}
