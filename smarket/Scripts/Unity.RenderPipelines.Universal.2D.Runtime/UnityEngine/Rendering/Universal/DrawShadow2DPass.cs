using System;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal
{
	internal class DrawShadow2DPass : ScriptableRenderPass
	{
		internal class PassData
		{
			internal LayerBatch layerBatch;

			internal Renderer2DData rendererData;

			internal TextureHandle[] shadowTextures;

			internal TextureHandle shadowDepth;
		}

		private static readonly string k_ShadowPass;

		private static readonly string k_ShadowVolumetricPass;

		private static readonly ProfilingSampler m_ProfilingSampler;

		private static readonly ProfilingSampler m_ProfilingSamplerVolume;

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		private static void ExecuteShadowPass(UnsafeCommandBuffer cmd, PassData passData, Light2D light, int batchIndex)
		{
		}

		public void Render(RenderGraph graph, ContextContainer frameData, Renderer2DData rendererData, ref LayerBatch layerBatch, int batchIndex, bool isVolumetric = false)
		{
		}
	}
}
