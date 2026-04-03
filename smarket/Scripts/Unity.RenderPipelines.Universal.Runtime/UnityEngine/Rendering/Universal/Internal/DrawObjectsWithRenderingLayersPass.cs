using System;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal.Internal
{
	internal class DrawObjectsWithRenderingLayersPass : DrawObjectsPass
	{
		private class RenderingLayersPassData
		{
			internal PassData basePassData;

			internal RenderingLayerUtils.MaskSize maskSize;
		}

		private RTHandle[] m_ColorTargetIndentifiers;

		private RTHandle m_DepthTargetIndentifiers;

		public DrawObjectsWithRenderingLayersPass(URPProfileId profilerTag, bool opaque, RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask, StencilState stencilState, int stencilReference)
			: base(null, null, opaque: false, default(RenderPassEvent), default(RenderQueueRange), default(LayerMask), default(StencilState), 0)
		{
		}

		public void Setup(RTHandle colorAttachment, RTHandle renderingLayersTexture, RTHandle depthAttachment)
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

		internal void Render(RenderGraph renderGraph, ContextContainer frameData, TextureHandle colorTarget, TextureHandle renderingLayersTexture, TextureHandle depthTarget, TextureHandle mainShadowsTexture, TextureHandle additionalShadowsTexture, RenderingLayerUtils.MaskSize maskSize, uint batchLayerMask = 4294967295u)
		{
		}
	}
}
