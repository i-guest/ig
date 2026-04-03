namespace UnityEngine.Rendering
{
	public static class Blitter
	{
		private static class BlitShaderIDs
		{
			public static readonly int _BlitTexture;

			public static readonly int _BlitCubeTexture;

			public static readonly int _BlitScaleBias;

			public static readonly int _BlitScaleBiasRt;

			public static readonly int _SourceResolution;

			public static readonly int _BlitMipLevel;

			public static readonly int _BlitTexArraySlice;

			public static readonly int _BlitTextureSize;

			public static readonly int _BlitPaddingSize;

			public static readonly int _BlitDecodeInstructions;

			public static readonly int _InputDepth;

			public static readonly int _InputDepthXR;

			public static readonly int _InputDepthXRMS;
		}

		private enum BlitShaderPassNames
		{
			Nearest = 0,
			Bilinear = 1,
			NearestQuad = 2,
			BilinearQuad = 3,
			NearestQuadPadding = 4,
			BilinearQuadPadding = 5,
			NearestQuadPaddingRepeat = 6,
			BilinearQuadPaddingRepeat = 7,
			BilinearQuadPaddingOctahedral = 8,
			NearestQuadPaddingAlphaBlend = 9,
			BilinearQuadPaddingAlphaBlend = 10,
			NearestQuadPaddingAlphaBlendRepeat = 11,
			BilinearQuadPaddingAlphaBlendRepeat = 12,
			BilinearQuadPaddingAlphaBlendOctahedral = 13,
			CubeToOctahedral = 14,
			CubeToOctahedralLuminance = 15,
			CubeToOctahedralAlpha = 16,
			CubeToOctahedralRed = 17,
			BilinearQuadLuminance = 18,
			BilinearQuadAlpha = 19,
			BilinearQuadRed = 20,
			NearestCubeToOctahedralPadding = 21,
			BilinearCubeToOctahedralPadding = 22
		}

		private enum BlitColorAndDepthPassNames
		{
			ColorOnly = 0,
			ColorAndDepth = 1,
			DepthOnly = 2
		}

		private static Material s_Copy;

		private static Material s_Blit;

		private static Material s_BlitTexArray;

		private static Material s_BlitTexArraySingleSlice;

		private static Material s_BlitColorAndDepth;

		private static MaterialPropertyBlock s_PropertyBlock;

		private static Mesh s_TriangleMesh;

		private static Mesh s_QuadMesh;

		private static LocalKeyword s_DecodeHdrKeyword;

		private static LocalKeyword s_ResolveDepthMSAA2X;

		private static LocalKeyword s_ResolveDepthMSAA4X;

		private static LocalKeyword s_ResolveDepthMSAA8X;

		private static int[] s_BlitShaderPassIndicesMap;

		private static int[] s_BlitColorAndDepthShaderPassIndicesMap;

		public static void Initialize(Shader blitPS, Shader blitColorAndDepthPS)
		{
		}

		public static void Cleanup()
		{
		}

		public static Material GetBlitMaterial(TextureDimension dimension, bool singleSlice = false)
		{
			return null;
		}

		internal static void DrawTriangle(RasterCommandBuffer cmd, Material material, int shaderPass)
		{
		}

		internal static void DrawTriangle(CommandBuffer cmd, Material material, int shaderPass)
		{
		}

		internal static void DrawTriangle(CommandBuffer cmd, Material material, int shaderPass, MaterialPropertyBlock propertyBlock)
		{
		}

		internal static void DrawQuadMesh(CommandBuffer cmd, Material material, int shaderPass, MaterialPropertyBlock propertyBlock)
		{
		}

		internal static void DrawQuad(RasterCommandBuffer cmd, Material material, int shaderPass, MaterialPropertyBlock propertyBlock)
		{
		}

		internal static void DrawQuad(CommandBuffer cmd, Material material, int shaderPass)
		{
		}

		internal static void DrawQuad(CommandBuffer cmd, Material material, int shaderPass, MaterialPropertyBlock propertyBlock)
		{
		}

		internal static bool CanCopyMSAA()
		{
			return false;
		}

		internal static bool CanCopyMSAA(bool srcBindTextureMS)
		{
			return false;
		}

		internal static void CopyTexture(RasterCommandBuffer cmd, bool isMSAA, bool force2DForXR = false)
		{
		}

		internal static void BlitTexture(CommandBuffer cmd, RTHandle source, Vector4 scaleBias, float sourceMipLevel, int sourceDepthSlice, bool bilinear)
		{
		}

		internal static void BlitTexture(CommandBuffer cmd, RTHandle source, Vector4 scaleBias, Material material, int pass, float sourceMipLevel, int sourceDepthSlice)
		{
		}

		public static void BlitTexture(RasterCommandBuffer cmd, RTHandle source, Vector4 scaleBias, float mipLevel, bool bilinear)
		{
		}

		public static void BlitTexture(CommandBuffer cmd, RTHandle source, Vector4 scaleBias, float mipLevel, bool bilinear)
		{
		}

		public static void BlitTexture2D(RasterCommandBuffer cmd, RTHandle source, Vector4 scaleBias, float mipLevel, bool bilinear)
		{
		}

		public static void BlitTexture2D(CommandBuffer cmd, RTHandle source, Vector4 scaleBias, float mipLevel, bool bilinear)
		{
		}

		public static void BlitColorAndDepth(RasterCommandBuffer cmd, Texture sourceColor, RenderTexture sourceDepth, Vector4 scaleBias, float mipLevel, bool blitDepth)
		{
		}

		public static void BlitColorAndDepth(CommandBuffer cmd, Texture sourceColor, RenderTexture sourceDepth, Vector4 scaleBias, float mipLevel, bool blitDepth)
		{
		}

		public static void BlitDepth(CommandBuffer cmd, RenderTexture sourceDepth, Vector4 scaleBias, float mipLevel)
		{
		}

		public static void BlitTexture(RasterCommandBuffer cmd, RTHandle source, Vector4 scaleBias, Material material, int pass)
		{
		}

		public static void BlitTexture(UnsafeCommandBuffer cmd, RTHandle source, Vector4 scaleBias, Material material, int pass)
		{
		}

		public static void BlitTexture(CommandBuffer cmd, RTHandle source, Vector4 scaleBias, Material material, int pass)
		{
		}

		public static void BlitTexture(RasterCommandBuffer cmd, RenderTargetIdentifier source, Vector4 scaleBias, Material material, int pass)
		{
		}

		public static void BlitTexture(CommandBuffer cmd, RenderTargetIdentifier source, Vector4 scaleBias, Material material, int pass)
		{
		}

		public static void BlitTexture(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material material, int pass)
		{
		}

		public static void BlitTexture(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, Material material, int pass)
		{
		}

		public static void BlitTexture(CommandBuffer cmd, Vector4 scaleBias, Material material, int pass)
		{
		}

		public static void BlitTexture(RasterCommandBuffer cmd, Vector4 scaleBias, Material material, int pass)
		{
		}

		public static void BlitCameraTexture(CommandBuffer cmd, RTHandle source, RTHandle destination, float mipLevel = 0f, bool bilinear = false)
		{
		}

		public static void BlitCameraTexture2D(CommandBuffer cmd, RTHandle source, RTHandle destination, float mipLevel = 0f, bool bilinear = false)
		{
		}

		public static void BlitCameraTexture(CommandBuffer cmd, RTHandle source, RTHandle destination, Material material, int pass)
		{
		}

		public static void BlitCameraTexture(CommandBuffer cmd, RTHandle source, RTHandle destination, Vector4 scaleBias, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, Material material, int pass)
		{
		}

		public static void BlitCameraTexture(CommandBuffer cmd, RTHandle source, RTHandle destination, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, Material material, int pass)
		{
		}

		public static void BlitCameraTexture(CommandBuffer cmd, RTHandle source, RTHandle destination, Vector4 scaleBias, float mipLevel = 0f, bool bilinear = false)
		{
		}

		public static void BlitCameraTexture(CommandBuffer cmd, RTHandle source, RTHandle destination, Rect destViewport, float mipLevel = 0f, bool bilinear = false)
		{
		}

		public static void BlitQuad(CommandBuffer cmd, Texture source, Vector4 scaleBiasTex, Vector4 scaleBiasRT, int mipLevelTex, bool bilinear)
		{
		}

		public static void BlitQuadWithPadding(CommandBuffer cmd, Texture source, Vector2 textureSize, Vector4 scaleBiasTex, Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels)
		{
		}

		public static void BlitQuadWithPaddingMultiply(CommandBuffer cmd, Texture source, Vector2 textureSize, Vector4 scaleBiasTex, Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels)
		{
		}

		public static void BlitOctahedralWithPadding(CommandBuffer cmd, Texture source, Vector2 textureSize, Vector4 scaleBiasTex, Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels)
		{
		}

		public static void BlitOctahedralWithPaddingMultiply(CommandBuffer cmd, Texture source, Vector2 textureSize, Vector4 scaleBiasTex, Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels)
		{
		}

		public static void BlitCubeToOctahedral2DQuad(CommandBuffer cmd, Texture source, Vector4 scaleBiasRT, int mipLevelTex)
		{
		}

		public static void BlitCubeToOctahedral2DQuadWithPadding(CommandBuffer cmd, Texture source, Vector2 textureSize, Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels, Vector4? decodeInstructions = null)
		{
		}

		public static void BlitCubeToOctahedral2DQuadSingleChannel(CommandBuffer cmd, Texture source, Vector4 scaleBiasRT, int mipLevelTex)
		{
		}

		public static void BlitQuadSingleChannel(CommandBuffer cmd, Texture source, Vector4 scaleBiasTex, Vector4 scaleBiasRT, int mipLevelTex)
		{
		}
	}
}
