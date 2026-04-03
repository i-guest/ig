using System;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal.Internal
{
	internal class GBufferPass : ScriptableRenderPass
	{
		private class PassData
		{
			internal DeferredLights deferredLights;

			internal RendererListHandle rendererListHdl;

			internal RendererListHandle objectsWithErrorRendererListHdl;

			internal TextureHandle screenSpaceIrradianceHdl;

			internal TextureHandle[] gbuffer;

			internal TextureHandle depth;

			internal RendererList rendererList;

			internal RendererList objectsWithErrorRendererList;
		}

		private static readonly int s_CameraNormalsTextureID;

		private static readonly int s_CameraRenderingLayersTextureID;

		private static readonly ShaderTagId s_ShaderTagLit;

		private static readonly ShaderTagId s_ShaderTagSimpleLit;

		private static readonly ShaderTagId s_ShaderTagUnlit;

		private static readonly ShaderTagId s_ShaderTagComplexLit;

		private static readonly ShaderTagId s_ShaderTagUniversalGBuffer;

		private static readonly ShaderTagId s_ShaderTagUniversalMaterialType;

		private DeferredLights m_DeferredLights;

		private static ShaderTagId[] s_ShaderTagValues;

		private static RenderStateBlock[] s_RenderStateBlocks;

		private FilteringSettings m_FilteringSettings;

		private RenderStateBlock m_RenderStateBlock;

		private PassData m_PassData;

		public GBufferPass(RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask, StencilState stencilState, int stencilReference, DeferredLights deferredLights)
		{
		}

		public void Dispose()
		{
		}

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
		{
		}

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		private static void ExecutePass(RasterCommandBuffer cmd, PassData data, RendererList rendererList, RendererList errorRendererList)
		{
		}

		private void InitRendererLists(ref PassData passData, ScriptableRenderContext context, RenderGraph renderGraph, UniversalRenderingData renderingData, UniversalCameraData cameraData, UniversalLightData lightData, bool useRenderGraph, uint batchLayerMask = 4294967295u)
		{
		}

		internal void Render(RenderGraph renderGraph, ContextContainer frameData, TextureHandle cameraColor, TextureHandle cameraDepth, bool setGlobalTextures, uint batchLayerMask = 4294967295u)
		{
		}
	}
}
