using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering
{
	public static class Vrs
	{
		private class ConversionPassData
		{
			public TextureHandle sriTextureHandle;

			public TextureHandle mainTexHandle;

			public TextureDimension mainTexDimension;

			public BufferHandle mainTexLutHandle;

			public BufferHandle validatedShadingRateFragmentSizeHandle;

			public ComputeShader computeShader;

			public int kernelIndex;

			public Vector4 scaleBias;

			public Vector2Int dispatchSize;

			public bool yFlip;
		}

		private class VisualizationPassData
		{
			public Material material;

			public TextureHandle source;

			public BufferHandle lut;

			public TextureHandle dummy;

			public Vector4 visualizationParams;
		}

		internal static readonly int shadingRateFragmentSizeCount;

		private static VrsResources s_VrsResources;

		public static bool IsColorMaskTextureConversionSupported()
		{
			return false;
		}

		public static bool IsInitialized()
		{
			return false;
		}

		public static void InitializeResources()
		{
		}

		public static void DisposeResources()
		{
		}

		public static TextureHandle ColorMaskTextureToShadingRateImage(RenderGraph renderGraph, RTHandle sriRtHandle, RTHandle colorMaskRtHandle, bool yFlip)
		{
			return default(TextureHandle);
		}

		public static TextureHandle ColorMaskTextureToShadingRateImage(RenderGraph renderGraph, TextureHandle sriTextureHandle, TextureHandle colorMaskHandle, TextureDimension colorMaskDimension, bool yFlip)
		{
			return default(TextureHandle);
		}

		public static void ShadingRateImageToColorMaskTexture(RenderGraph renderGraph, in TextureHandle sriTextureHandle, in TextureHandle colorMaskHandle)
		{
		}

		private static void ConversionDispatch(ComputeCommandBuffer cmd, ConversionPassData conversionPassData)
		{
		}

		public static void ColorMaskTextureToShadingRateImageDispatch(CommandBuffer cmd, RTHandle sriDestination, Texture colorMaskSource, bool yFlip = true)
		{
		}

		public static void ShadingRateImageToColorMaskTextureBlit(CommandBuffer cmd, RTHandle sriSource, RTHandle colorMaskDestination)
		{
		}
	}
}
