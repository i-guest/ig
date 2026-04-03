using System;
using System.Collections.Generic;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal
{
	internal class DrawRenderer2DPass : ScriptableRenderPass
	{
		private class SetGlobalPassData
		{
			internal TextureHandle[] lightTextures;
		}

		private class PassData
		{
			internal Light2DBlendStyle[] lightBlendStyles;

			internal int[] blendStyleIndices;

			internal float hdrEmulationScale;

			internal bool isSceneLit;

			internal bool layerUseLights;

			internal TextureHandle[] lightTextures;

			internal RendererListHandle rendererList;

			internal DebugRendererLists debugRendererLists;

			internal bool activeDebugHandler;
		}

		private static readonly string k_RenderPass;

		private static readonly string k_SetLightBlendTexture;

		private static readonly ProfilingSampler m_ProfilingSampler;

		private static readonly ProfilingSampler m_SetLightBlendTextureProfilingSampler;

		private static readonly ShaderTagId k_CombinedRenderingPassName;

		private static readonly ShaderTagId k_LegacyPassName;

		private static readonly List<ShaderTagId> k_ShaderTags;

		private static readonly int k_HDREmulationScaleID;

		private static readonly int k_RendererColorID;

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		private static void Execute(RasterGraphContext context, PassData passData)
		{
		}

		public void Render(RenderGraph graph, ContextContainer frameData, Renderer2DData rendererData, ref LayerBatch[] layerBatches, int batchIndex, ref FilteringSettings filterSettings)
		{
		}

		private void SetGlobalLightTextures(RenderGraph graph, IRasterRenderGraphBuilder builder, TextureHandle[] lightTextures, ref LayerBatch layerBatch, Renderer2DData rendererData, bool isLitView)
		{
		}
	}
}
