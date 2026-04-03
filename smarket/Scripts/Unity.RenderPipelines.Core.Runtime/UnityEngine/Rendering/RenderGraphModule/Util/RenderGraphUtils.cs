using System.Runtime.CompilerServices;

namespace UnityEngine.Rendering.RenderGraphModule.Util
{
	public static class RenderGraphUtils
	{
		private class CopyPassData
		{
			public bool isMSAA;

			public bool force2DForXR;
		}

		public enum BlitFilterMode
		{
			ClampNearest = 0,
			ClampBilinear = 1
		}

		private class BlitPassData
		{
			public TextureHandle source;

			public TextureHandle destination;

			public Vector2 scale;

			public Vector2 offset;

			public int sourceSlice;

			public int destinationSlice;

			public int numSlices;

			public int sourceMip;

			public int destinationMip;

			public int numMips;

			public BlitFilterMode filterMode;

			public bool isXR;

			public bool isDepth;
		}

		public enum FullScreenGeometryType
		{
			Mesh = 0,
			ProceduralTriangle = 1,
			ProceduralQuad = 2
		}

		public struct BlitMaterialParameters
		{
			private static readonly int blitTextureProperty;

			private static readonly int blitSliceProperty;

			private static readonly int blitMipProperty;

			private static readonly int blitScaleBias;

			public TextureHandle source;

			public TextureHandle destination;

			public Vector2 scale;

			public Vector2 offset;

			public int sourceSlice;

			public int destinationSlice;

			public int numSlices;

			public int sourceMip;

			public int destinationMip;

			public int numMips;

			public Material material;

			public int shaderPass;

			public MaterialPropertyBlock propertyBlock;

			public int sourceTexturePropertyID;

			public int sourceSlicePropertyID;

			public int sourceMipPropertyID;

			public int scaleBiasPropertyID;

			public FullScreenGeometryType geometry;

			public BlitMaterialParameters(TextureHandle source, TextureHandle destination, Material material, int shaderPass)
			{
				this.source = default(TextureHandle);
				this.destination = default(TextureHandle);
				scale = default(Vector2);
				offset = default(Vector2);
				sourceSlice = 0;
				destinationSlice = 0;
				numSlices = 0;
				sourceMip = 0;
				destinationMip = 0;
				numMips = 0;
				this.material = null;
				this.shaderPass = 0;
				propertyBlock = null;
				sourceTexturePropertyID = 0;
				sourceSlicePropertyID = 0;
				sourceMipPropertyID = 0;
				scaleBiasPropertyID = 0;
				geometry = default(FullScreenGeometryType);
			}

			public BlitMaterialParameters(TextureHandle source, TextureHandle destination, Vector2 scale, Vector2 offset, Material material, int shaderPass)
			{
				this.source = default(TextureHandle);
				this.destination = default(TextureHandle);
				this.scale = default(Vector2);
				this.offset = default(Vector2);
				sourceSlice = 0;
				destinationSlice = 0;
				numSlices = 0;
				sourceMip = 0;
				destinationMip = 0;
				numMips = 0;
				this.material = null;
				this.shaderPass = 0;
				propertyBlock = null;
				sourceTexturePropertyID = 0;
				sourceSlicePropertyID = 0;
				sourceMipPropertyID = 0;
				scaleBiasPropertyID = 0;
				geometry = default(FullScreenGeometryType);
			}

			public BlitMaterialParameters(TextureHandle source, TextureHandle destination, Material material, int shaderPass, MaterialPropertyBlock mpb, int destinationSlice, int destinationMip, int numSlices = -1, int numMips = 1, int sourceSlice = -1, int sourceMip = -1, FullScreenGeometryType geometry = FullScreenGeometryType.Mesh, int sourceTexturePropertyID = -1, int sourceSlicePropertyID = -1, int sourceMipPropertyID = -1)
			{
				this.source = default(TextureHandle);
				this.destination = default(TextureHandle);
				scale = default(Vector2);
				offset = default(Vector2);
				this.sourceSlice = 0;
				this.destinationSlice = 0;
				this.numSlices = 0;
				this.sourceMip = 0;
				this.destinationMip = 0;
				this.numMips = 0;
				this.material = null;
				this.shaderPass = 0;
				propertyBlock = null;
				this.sourceTexturePropertyID = 0;
				this.sourceSlicePropertyID = 0;
				this.sourceMipPropertyID = 0;
				scaleBiasPropertyID = 0;
				this.geometry = default(FullScreenGeometryType);
			}

			public BlitMaterialParameters(TextureHandle source, TextureHandle destination, Vector2 scale, Vector2 offset, Material material, int shaderPass, MaterialPropertyBlock mpb, int destinationSlice, int destinationMip, int numSlices = -1, int numMips = 1, int sourceSlice = -1, int sourceMip = -1, FullScreenGeometryType geometry = FullScreenGeometryType.Mesh, int sourceTexturePropertyID = -1, int sourceSlicePropertyID = -1, int sourceMipPropertyID = -1, int scaleBiasPropertyID = -1)
			{
				this.source = default(TextureHandle);
				this.destination = default(TextureHandle);
				this.scale = default(Vector2);
				this.offset = default(Vector2);
				this.sourceSlice = 0;
				this.destinationSlice = 0;
				this.numSlices = 0;
				this.sourceMip = 0;
				this.destinationMip = 0;
				this.numMips = 0;
				this.material = null;
				this.shaderPass = 0;
				propertyBlock = null;
				this.sourceTexturePropertyID = 0;
				this.sourceSlicePropertyID = 0;
				this.sourceMipPropertyID = 0;
				this.scaleBiasPropertyID = 0;
				this.geometry = default(FullScreenGeometryType);
			}

			public BlitMaterialParameters(TextureHandle source, TextureHandle destination, Material material, int shaderPass, MaterialPropertyBlock mpb, FullScreenGeometryType geometry = FullScreenGeometryType.Mesh, int sourceTexturePropertyID = -1, int sourceSlicePropertyID = -1, int sourceMipPropertyID = -1)
			{
				this.source = default(TextureHandle);
				this.destination = default(TextureHandle);
				scale = default(Vector2);
				offset = default(Vector2);
				sourceSlice = 0;
				destinationSlice = 0;
				numSlices = 0;
				sourceMip = 0;
				destinationMip = 0;
				numMips = 0;
				this.material = null;
				this.shaderPass = 0;
				propertyBlock = null;
				this.sourceTexturePropertyID = 0;
				this.sourceSlicePropertyID = 0;
				this.sourceMipPropertyID = 0;
				scaleBiasPropertyID = 0;
				this.geometry = default(FullScreenGeometryType);
			}

			public BlitMaterialParameters(TextureHandle source, TextureHandle destination, Vector2 scale, Vector2 offset, Material material, int shaderPass, MaterialPropertyBlock mpb, FullScreenGeometryType geometry = FullScreenGeometryType.Mesh, int sourceTexturePropertyID = -1, int sourceSlicePropertyID = -1, int sourceMipPropertyID = -1, int scaleBiasPropertyID = -1)
			{
				this.source = default(TextureHandle);
				this.destination = default(TextureHandle);
				this.scale = default(Vector2);
				this.offset = default(Vector2);
				sourceSlice = 0;
				destinationSlice = 0;
				numSlices = 0;
				sourceMip = 0;
				destinationMip = 0;
				numMips = 0;
				this.material = null;
				this.shaderPass = 0;
				propertyBlock = null;
				this.sourceTexturePropertyID = 0;
				this.sourceSlicePropertyID = 0;
				this.sourceMipPropertyID = 0;
				this.scaleBiasPropertyID = 0;
				this.geometry = default(FullScreenGeometryType);
			}
		}

		private class BlitMaterialPassData
		{
			public int sourceTexturePropertyID;

			public TextureHandle source;

			public TextureHandle destination;

			public Vector2 scale;

			public Vector2 offset;

			public Material material;

			public int shaderPass;

			public MaterialPropertyBlock propertyBlock;

			public int sourceSlice;

			public int destinationSlice;

			public int numSlices;

			public int sourceMip;

			public int destinationMip;

			public int numMips;

			public FullScreenGeometryType geometry;

			public int sourceSlicePropertyID;

			public int sourceMipPropertyID;

			public int scaleBiasPropertyID;

			public bool isXR;
		}

		private static MaterialPropertyBlock s_PropertyBlock;

		private static Vector4 s_BlitScaleBias;

		public static bool CanAddCopyPassMSAA()
		{
			return false;
		}

		public static bool CanAddCopyPassMSAA(in TextureDesc sourceDesc)
		{
			return false;
		}

		public static bool CanAddCopyPassMSAA(bool bindTextureMS)
		{
			return false;
		}

		internal static bool IsFramebufferFetchEmulationSupportedOnCurrentPlatform()
		{
			return false;
		}

		internal static bool IsFramebufferFetchEmulationMSAASupportedOnCurrentPlatform()
		{
			return false;
		}

		public static bool IsFramebufferFetchSupportedOnCurrentPlatform(this RenderGraph graph, in TextureHandle tex)
		{
			return false;
		}

		public static bool CanAddCopyPass(this RenderGraph graph, TextureHandle source, TextureHandle destination)
		{
			return false;
		}

		public static IBaseRenderGraphBuilder AddCopyPass(this RenderGraph graph, TextureHandle source, TextureHandle destination, string passName = "Copy Pass Utility", bool returnBuilder = false, [CallerFilePath] string file = "", [CallerLineNumber] int line = 0)
		{
			return null;
		}

		public static void AddCopyPass(this RenderGraph graph, TextureHandle source, TextureHandle destination, int sourceSlice, int destinationSlice = 0, int sourceMip = 0, int destinationMip = 0, string passName = "Copy Pass Utility", [CallerFilePath] string file = "", [CallerLineNumber] int line = 0)
		{
		}

		private static void CopyRenderFunc(CopyPassData data, RasterGraphContext rgContext)
		{
		}

		internal static bool IsTextureXR(ref RenderTargetInfo destDesc, int sourceSlice, int destinationSlice, int numSlices, int numMips)
		{
			return false;
		}

		public static IBaseRenderGraphBuilder AddBlitPass(this RenderGraph graph, TextureHandle source, TextureHandle destination, Vector2 scale, Vector2 offset, int sourceSlice = 0, int destinationSlice = 0, int numSlices = -1, int sourceMip = 0, int destinationMip = 0, int numMips = 1, BlitFilterMode filterMode = BlitFilterMode.ClampBilinear, string passName = "Blit Pass Utility", bool returnBuilder = false, [CallerFilePath] string file = "", [CallerLineNumber] int line = 0)
		{
			return null;
		}

		private static void BlitRenderFunc(BlitPassData data, UnsafeGraphContext context)
		{
		}

		public static IBaseRenderGraphBuilder AddBlitPass(this RenderGraph graph, BlitMaterialParameters blitParameters, string passName = "Blit Pass Utility w. Material", bool returnBuilder = false, [CallerFilePath] string file = "", [CallerLineNumber] int line = 0)
		{
			return null;
		}

		private static void BlitMaterialRenderFunc(BlitMaterialPassData data, UnsafeGraphContext context)
		{
		}
	}
}
