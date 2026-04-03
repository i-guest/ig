using System;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal.Internal
{
	public class DepthOnlyPass : ScriptableRenderPass
	{
		private class PassData
		{
			internal RendererListHandle rendererList;
		}

		private FilteringSettings m_FilteringSettings;

		private GraphicsFormat depthStencilFormat;

		private PassData m_PassData;

		private static readonly ShaderTagId k_ShaderTagId;

		private static readonly int s_CameraDepthTextureID;

		internal ShaderTagId shaderTagId { get; set; }

		private RTHandle destination { get; set; }

		public DepthOnlyPass(RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask)
		{
		}

		public void Setup(RenderTextureDescriptor baseDescriptor, RTHandle depthAttachmentHandle)
		{
		}

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
		{
		}

		private static void ExecutePass(RasterCommandBuffer cmd, RendererList rendererList)
		{
		}

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		private RendererListParams InitRendererListParams(UniversalRenderingData renderingData, UniversalCameraData cameraData, UniversalLightData lightData)
		{
			return default(RendererListParams);
		}

		internal void Render(RenderGraph renderGraph, ContextContainer frameData, in TextureHandle depthTexture, uint batchLayerMask, bool setGlobalDepth)
		{
		}
	}
}
