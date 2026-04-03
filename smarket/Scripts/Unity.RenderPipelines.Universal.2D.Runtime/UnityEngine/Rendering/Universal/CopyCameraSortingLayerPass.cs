using System;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal
{
	internal class CopyCameraSortingLayerPass : ScriptableRenderPass
	{
		private class PassData
		{
			internal TextureHandle source;
		}

		private static readonly string k_CopyCameraSortingLayerPass;

		private static readonly ProfilingSampler m_ProfilingSampler;

		private static readonly ProfilingSampler m_ExecuteProfilingSampler;

		internal static readonly string k_CameraSortingLayerTexture;

		internal static readonly int k_CameraSortingLayerTextureId;

		private static Material m_BlitMaterial;

		public CopyCameraSortingLayerPass(Material blitMaterial)
		{
		}

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		public static void ConfigureDescriptor(Downsampling downsamplingMethod, ref RenderTextureDescriptor descriptor, out FilterMode filterMode)
		{
			filterMode = default(FilterMode);
		}

		private static void Execute(RasterCommandBuffer cmd, RTHandle source)
		{
		}

		public void Render(RenderGraph graph, ContextContainer frameData)
		{
		}
	}
}
