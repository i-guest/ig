using System;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal
{
	internal class DrawLight2DPass : ScriptableRenderPass
	{
		internal class PassData
		{
			internal LayerBatch layerBatch;

			internal Renderer2DData rendererData;

			internal bool isVolumetric;

			internal TextureHandle normalMap;

			internal TextureHandle[] shadowTextures;

			internal int lightTextureIndex;
		}

		private static readonly string k_LightPass;

		private static readonly string k_LightSRTPass;

		private static readonly string k_LightVolumetricPass;

		private static readonly ProfilingSampler m_ProfilingSampler;

		private static readonly ProfilingSampler m_ProfilingSampleSRT;

		private static readonly ProfilingSampler m_ProfilingSamplerVolume;

		internal static readonly int k_InverseHDREmulationScaleID;

		internal static readonly string k_NormalMapID;

		internal static readonly string k_ShadowMapID;

		private TextureHandle[] intermediateTexture;

		internal static MaterialPropertyBlock s_PropertyBlock;

		internal void Setup(RenderGraph renderGraph, ref Renderer2DData rendererData)
		{
		}

		private static bool TryGetShadowIndex(ref LayerBatch layerBatch, int lightIndex, out int shadowIndex)
		{
			shadowIndex = default(int);
			return false;
		}

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		private static void Execute(RasterCommandBuffer cmd, PassData passData, ref LayerBatch layerBatch, int lightTextureIndex)
		{
		}

		private void InitializeRenderPass(IRasterRenderGraphBuilder builder, ContextContainer frameData, PassData passData, Renderer2DData rendererData, ref LayerBatch layerBatch, int batchIndex, bool isVolumetric = false)
		{
		}

		internal void Render(RenderGraph graph, ContextContainer frameData, Renderer2DData rendererData, ref LayerBatch layerBatch, int batchIndex, bool isVolumetric = false)
		{
		}
	}
}
