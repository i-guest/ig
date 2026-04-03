using System;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal.Internal
{
	public class CopyColorPass : ScriptableRenderPass
	{
		private class PassData
		{
			internal TextureHandle source;

			internal TextureHandle destination;

			internal bool useProceduralBlit;

			internal Material samplingMaterial;

			internal Material copyColorMaterial;

			internal Downsampling downsamplingMethod;

			internal int sampleOffsetShaderHandle;
		}

		private int m_SampleOffsetShaderHandle;

		private Material m_SamplingMaterial;

		private Downsampling m_DownsamplingMethod;

		private Material m_CopyColorMaterial;

		private PassData m_PassData;

		private static readonly string k_CopyColorPassName;

		private static readonly string k_DownsampleAndCopyPassName;

		private RTHandle source { get; set; }

		private RTHandle destination { get; set; }

		public CopyColorPass(RenderPassEvent evt, Material samplingMaterial, Material copyColorMaterial = null, string customPassName = null)
		{
		}

		public static void ConfigureDescriptor(Downsampling downsamplingMethod, ref RenderTextureDescriptor descriptor, out FilterMode filterMode)
		{
			filterMode = default(FilterMode);
		}

		[Obsolete("Use RTHandles for source and destination #from(2022.1) #breakingFrom(2023.1).", true)]
		public void Setup(RenderTargetIdentifier source, RenderTargetHandle destination, Downsampling downsampling)
		{
		}

		public void Setup(RTHandle source, RTHandle destination, Downsampling downsampling)
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

		private static void ExecutePass(RasterCommandBuffer cmd, PassData passData, RTHandle source, bool useDrawProceduralBlit)
		{
		}

		internal TextureHandle Render(RenderGraph renderGraph, ContextContainer frameData, out TextureHandle destination, in TextureHandle source, Downsampling downsampling)
		{
			destination = default(TextureHandle);
			return default(TextureHandle);
		}

		internal void RenderToExistingTexture(RenderGraph renderGraph, ContextContainer frameData, in TextureHandle destination, in TextureHandle source, Downsampling downsampling = Downsampling.None)
		{
		}

		private void RenderInternal(RenderGraph renderGraph, in TextureHandle destination, in TextureHandle source, bool useProceduralBlit)
		{
		}

		private void AddDownsampleAndCopyColorRenderPass(RenderGraph renderGraph, in TextureHandle destination, in TextureHandle source, bool useProceduralBlit, string passName)
		{
		}
	}
}
