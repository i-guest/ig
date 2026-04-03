using System;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal
{
	internal class ProbeVolumeDebugPass : ScriptableRenderPass
	{
		private class WriteApvData
		{
			public ComputeShader computeShader;

			public BufferHandle resultBuffer;

			public Vector2 clickCoordinates;

			public TextureHandle depthBuffer;

			public TextureHandle normalBuffer;
		}

		private ComputeShader m_ComputeShader;

		private RTHandle m_DepthTexture;

		private RTHandle m_NormalTexture;

		public ProbeVolumeDebugPass(RenderPassEvent evt, ComputeShader computeShader)
		{
		}

		public void Setup(RTHandle depthBuffer, RTHandle normalBuffer)
		{
		}

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		internal void Render(RenderGraph renderGraph, ContextContainer frameData, TextureHandle depthPyramidBuffer, TextureHandle normalBuffer)
		{
		}
	}
}
