using System;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal
{
	public class DrawSkyboxPass : ScriptableRenderPass
	{
		private class PassData
		{
			internal XRPass xr;

			internal RendererListHandle skyRendererListHandle;

			internal Material material;
		}

		public DrawSkyboxPass(RenderPassEvent evt)
		{
		}

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		private RendererList CreateSkyboxRendererList(ScriptableRenderContext context, UniversalCameraData cameraData)
		{
			return default(RendererList);
		}

		private RendererListHandle CreateSkyBoxRendererList(RenderGraph renderGraph, UniversalCameraData cameraData)
		{
			return default(RendererListHandle);
		}

		private static void ExecutePass(RasterCommandBuffer cmd, XRPass xr, RendererList rendererList)
		{
		}

		private void InitPassData(ref PassData passData, in XRPass xr, in RendererListHandle handle)
		{
		}

		internal void Render(RenderGraph renderGraph, ContextContainer frameData, ScriptableRenderContext context, TextureHandle colorTarget, TextureHandle depthTarget, Material skyboxMaterial)
		{
		}
	}
}
