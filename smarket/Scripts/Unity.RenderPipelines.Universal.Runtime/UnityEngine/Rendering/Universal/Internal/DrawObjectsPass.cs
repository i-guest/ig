using System;
using System.Collections.Generic;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal.Internal
{
	public class DrawObjectsPass : ScriptableRenderPass
	{
		internal class PassData
		{
			internal TextureHandle albedoHdl;

			internal TextureHandle depthHdl;

			internal TextureHandle screenSpaceIrradianceHdl;

			internal UniversalCameraData cameraData;

			internal bool isOpaque;

			internal bool shouldTransparentsReceiveShadows;

			internal uint batchLayerMask;

			internal bool isActiveTargetBackBuffer;

			internal RendererListHandle rendererListHdl;

			internal RendererListHandle objectsWithErrorRendererListHdl;

			internal DebugRendererLists debugRendererLists;

			internal RendererList rendererList;

			internal RendererList objectsWithErrorRendererList;
		}

		private FilteringSettings m_FilteringSettings;

		private RenderStateBlock m_RenderStateBlock;

		private List<ShaderTagId> m_ShaderTagIdList;

		private bool m_IsOpaque;

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(6000.3)")]
		public bool m_IsActiveTargetBackBuffer;

		public bool m_ShouldTransparentsReceiveShadows;

		private static readonly int s_DrawObjectPassDataPropID;

		private PassData m_PassData;

		public DrawObjectsPass(string profilerTag, ShaderTagId[] shaderTagIds, bool opaque, RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask, StencilState stencilState, int stencilReference)
		{
		}

		public DrawObjectsPass(string profilerTag, bool opaque, RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask, StencilState stencilState, int stencilReference)
		{
		}

		internal DrawObjectsPass(URPProfileId profileId, bool opaque, RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask, StencilState stencilState, int stencilReference)
		{
		}

		internal void Init(bool opaque, RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask, StencilState stencilState, int stencilReference, ShaderTagId[] shaderTagIds = null)
		{
		}

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		internal static void ExecutePass(RasterCommandBuffer cmd, PassData data, RendererList rendererList, RendererList objectsWithErrorRendererList, bool yFlip)
		{
		}

		internal void InitPassData(UniversalCameraData cameraData, ref PassData passData, uint batchLayerMask, bool isActiveTargetBackBuffer = false)
		{
		}

		internal void InitRendererLists(UniversalRenderingData renderingData, UniversalCameraData cameraData, UniversalLightData lightData, ref PassData passData, ScriptableRenderContext context, RenderGraph renderGraph, bool useRenderGraph, bool zWriteOff)
		{
		}

		internal static bool CanDisableZWrite(UniversalCameraData cameraData, bool isOpaque)
		{
			return false;
		}

		internal void Render(RenderGraph renderGraph, ContextContainer frameData, TextureHandle colorTarget, TextureHandle depthTarget, TextureHandle mainShadowsTexture, TextureHandle additionalShadowsTexture, uint batchLayerMask = 4294967295u, bool isMainOpaquePass = false)
		{
		}
	}
}
