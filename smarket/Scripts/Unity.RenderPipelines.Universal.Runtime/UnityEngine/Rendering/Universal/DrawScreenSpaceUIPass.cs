using System;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal
{
	internal class DrawScreenSpaceUIPass : ScriptableRenderPass
	{
		private class PassData
		{
			internal RendererListHandle rendererList;
		}

		private class UnsafePassData
		{
			internal RendererListHandle rendererList;

			internal TextureHandle colorTarget;
		}

		private RTHandle m_ColorTarget;

		private RTHandle m_DepthTarget;

		private bool m_RenderOffscreen;

		private PassData m_PassData;

		public DrawScreenSpaceUIPass(RenderPassEvent evt, bool renderOffscreen)
		{
		}

		private static void ConfigureColorDescriptor(ref RenderTextureDescriptor descriptor, int cameraWidth, int cameraHeight)
		{
		}

		internal static void ConfigureOffscreenUITextureDesc(ref TextureDesc textureDesc)
		{
		}

		private static void ConfigureDepthDescriptor(ref RenderTextureDescriptor descriptor, GraphicsFormat depthStencilFormat, int targetWidth, int targetHeight)
		{
		}

		private static void ExecutePass(RasterCommandBuffer commandBuffer, PassData passData, RendererList rendererList)
		{
		}

		private static void ExecutePass(UnsafeCommandBuffer commandBuffer, UnsafePassData passData, RendererList rendererList)
		{
		}

		public void Dispose()
		{
		}

		public void Setup(UniversalCameraData cameraData, GraphicsFormat depthStencilFormat)
		{
		}

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
		{
		}

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		internal void RenderOffscreen(RenderGraph renderGraph, ContextContainer frameData, GraphicsFormat depthStencilFormat, TextureHandle overlayUITexture)
		{
		}

		internal void RenderOverlay(RenderGraph renderGraph, ContextContainer frameData, in TextureHandle colorBuffer, in TextureHandle depthBuffer)
		{
		}
	}
}
