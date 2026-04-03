using System;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal.Internal
{
	public class FinalBlitPass : ScriptableRenderPass
	{
		private static class BlitPassNames
		{
			public const string NearestSampler = "NearestDebugDraw";

			public const string BilinearSampler = "BilinearDebugDraw";
		}

		private enum BlitType
		{
			Core = 0,
			HDR = 1,
			Count = 2
		}

		private struct BlitMaterialData
		{
			public Material material;

			public int nearestSamplerPass;

			public int bilinearSamplerPass;
		}

		private class PassData
		{
			internal TextureHandle source;

			internal TextureHandle destination;

			internal int sourceID;

			internal Vector4 hdrOutputLuminanceParams;

			internal bool requireSrgbConversion;

			internal bool enableAlphaOutput;

			internal BlitMaterialData blitMaterialData;

			internal UniversalCameraData cameraData;

			internal bool useFullScreenViewport;
		}

		private static readonly int s_CameraDepthTextureID;

		private RTHandle m_Source;

		private PassData m_PassData;

		private BlitMaterialData[] m_BlitMaterialData;

		public FinalBlitPass(RenderPassEvent evt, Material blitMaterial, Material blitHDRMaterial)
		{
		}

		public void Dispose()
		{
		}

		[Obsolete("Use RTHandles for colorHandle. #from(2022.1) #breakingFrom(2023.1)", true)]
		public void Setup(RenderTextureDescriptor baseDescriptor, RenderTargetHandle colorHandle)
		{
		}

		public void Setup(RenderTextureDescriptor baseDescriptor, RTHandle colorHandle)
		{
		}

		private static void SetupHDROutput(ColorGamut hdrDisplayColorGamut, Material material, HDROutputUtils.Operation hdrOperation, Vector4 hdrOutputParameters, bool rendersOverlayUI)
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

		private static void ExecutePass(RasterCommandBuffer cmd, PassData data, RTHandle source, RTHandle destination, UniversalCameraData cameraData, Vector4 scaleBias)
		{
		}

		private void InitPassData(UniversalCameraData cameraData, ref PassData passData, BlitType blitType, bool enableAlphaOutput, bool useFullScreenViewport)
		{
		}

		internal void Render(RenderGraph renderGraph, ContextContainer frameData, UniversalCameraData cameraData, in TextureHandle src, in TextureHandle dest, TextureHandle overlayUITexture, bool useFullScreenViewport = false)
		{
		}
	}
}
