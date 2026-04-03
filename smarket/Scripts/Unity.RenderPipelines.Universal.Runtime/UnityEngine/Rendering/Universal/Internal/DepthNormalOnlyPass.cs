using System;
using System.Collections.Generic;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal.Internal
{
	public class DepthNormalOnlyPass : ScriptableRenderPass
	{
		private class PassData
		{
			internal bool enableRenderingLayers;

			internal RenderingLayerUtils.MaskSize maskSize;

			internal RendererListHandle rendererList;
		}

		private FilteringSettings m_FilteringSettings;

		private static readonly List<ShaderTagId> k_DepthNormals;

		private static readonly List<ShaderTagId> k_DepthNormalsOnly;

		internal static readonly string k_CameraNormalsTextureName;

		private static readonly int s_CameraDepthTextureID;

		private static readonly int s_CameraNormalsTextureID;

		private static readonly int s_CameraRenderingLayersTextureID;

		private PassData m_PassData;

		private static readonly RTHandle[] k_ColorAttachment1;

		private static readonly RTHandle[] k_ColorAttachment2;

		internal List<ShaderTagId> shaderTagIds { get; set; }

		internal bool enableRenderingLayers { get; set; }

		internal RenderingLayerUtils.MaskSize renderingLayersMaskSize { get; set; }

		private RTHandle depthHandle { get; set; }

		private RTHandle normalHandle { get; set; }

		private RTHandle renderingLayersHandle { get; set; }

		public DepthNormalOnlyPass(RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask)
		{
		}

		public static GraphicsFormat GetGraphicsFormat()
		{
			return default(GraphicsFormat);
		}

		public void Setup(RTHandle depthHandle, RTHandle normalHandle)
		{
		}

		public void Setup(RTHandle depthHandle, RTHandle normalHandle, RTHandle decalLayerHandle)
		{
		}

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
		{
		}

		private static void ExecutePass(RasterCommandBuffer cmd, PassData passData, RendererList rendererList)
		{
		}

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		public override void OnCameraCleanup(CommandBuffer cmd)
		{
		}

		private RendererListParams InitRendererListParams(UniversalRenderingData renderingData, UniversalCameraData cameraData, UniversalLightData lightData)
		{
			return default(RendererListParams);
		}

		internal void Render(RenderGraph renderGraph, ContextContainer frameData, in TextureHandle cameraNormalsTexture, in TextureHandle depthTexture, in TextureHandle renderingLayersTexture, uint batchLayerMask, bool setGlobalDepth, bool setGlobalNormalAndRenderingLayers, bool allowPartialPass)
		{
		}
	}
}
