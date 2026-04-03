using System;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal.Internal
{
	internal class DeferredPass : ScriptableRenderPass
	{
		private class PassData
		{
			internal UniversalCameraData cameraData;

			internal UniversalLightData lightData;

			internal UniversalShadowData shadowData;

			internal TextureHandle[] gbuffer;

			internal DeferredLights deferredLights;
		}

		private DeferredLights m_DeferredLights;

		public DeferredPass(RenderPassEvent evt, DeferredLights deferredLights)
		{
		}

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescripor)
		{
		}

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		internal void Render(RenderGraph renderGraph, ContextContainer frameData, TextureHandle color, TextureHandle depth, TextureHandle[] gbuffer)
		{
		}

		public override void OnCameraCleanup(CommandBuffer cmd)
		{
		}
	}
}
