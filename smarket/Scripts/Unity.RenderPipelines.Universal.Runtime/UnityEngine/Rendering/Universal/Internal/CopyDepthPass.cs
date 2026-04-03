using System;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal.Internal
{
	public class CopyDepthPass : ScriptableRenderPass
	{
		private static class ShaderConstants
		{
			public static readonly int _CameraDepthAttachment;

			public static readonly int _CameraDepthTexture;

			public static readonly int _ZWriteShaderHandle;
		}

		private class PassData
		{
			internal TextureHandle source;

			internal TextureHandle destination;

			internal UniversalCameraData cameraData;

			internal Material copyDepthMaterial;

			internal int msaaSamples;

			internal bool copyResolvedDepth;

			internal bool copyToDepth;

			internal bool isDstBackbuffer;
		}

		private Material m_CopyDepthMaterial;

		internal bool m_CopyResolvedDepth;

		internal bool m_ShouldClear;

		private PassData m_PassData;

		internal int MsaaSamples { get; set; }

		internal bool CopyToDepth { get; set; }

		internal bool CopyToDepthXR { get; set; }

		internal bool CopyToBackbuffer { get; set; }

		private RTHandle source { get; set; }

		private RTHandle destination { get; set; }

		public CopyDepthPass(RenderPassEvent evt, Shader copyDepthShader, bool shouldClear = false, bool copyToDepth = false, bool copyResolvedDepth = false, string customPassName = null)
		{
		}

		public void Setup(RTHandle source, RTHandle destination)
		{
		}

		public void Dispose()
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

		private static void ExecutePass(RasterCommandBuffer cmd, PassData passData, RTHandle source, bool yflip)
		{
		}

		public override void OnCameraCleanup(CommandBuffer cmd)
		{
		}

		public void Render(RenderGraph renderGraph, ContextContainer frameData, TextureHandle destination, TextureHandle source, bool bindAsCameraDepth = false, string passName = "Copy Depth")
		{
		}

		public void Render(RenderGraph renderGraph, TextureHandle destination, TextureHandle source, UniversalResourceData resourceData, UniversalCameraData cameraData, bool bindAsCameraDepth = false, string passName = "Copy Depth")
		{
		}
	}
}
