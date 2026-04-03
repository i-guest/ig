using System;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal
{
	public class XROcclusionMeshPass : ScriptableRenderPass
	{
		private class PassData
		{
			internal XRPass xr;

			internal bool isActiveTargetBackBuffer;

			internal bool shouldYFlip;

			internal TextureHandle cameraColorAttachment;
		}

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(6000.3)")]
		public bool m_IsActiveTargetBackBuffer;

		private PassData m_PassData;

		public XROcclusionMeshPass(RenderPassEvent evt)
		{
		}

		private static void ExecutePass(RasterCommandBuffer cmd, PassData data)
		{
		}

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		internal void Render(RenderGraph renderGraph, ContextContainer frameData, in TextureHandle cameraColorAttachment, in TextureHandle cameraDepthAttachment)
		{
		}
	}
}
