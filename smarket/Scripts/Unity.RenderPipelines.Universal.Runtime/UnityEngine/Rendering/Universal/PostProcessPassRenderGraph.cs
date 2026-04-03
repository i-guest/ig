using System.Runtime.CompilerServices;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal
{
	internal class PostProcessPassRenderGraph
	{
		internal static class ShaderConstants
		{
			public static readonly int _CameraDepthTextureID;

			public static readonly int _StencilRef;

			public static readonly int _StencilMask;

			public static readonly int _ColorTexture;

			public static readonly int _Params;

			public static readonly int _Params2;

			public static readonly int _ViewProjM;

			public static readonly int _PrevViewProjM;

			public static readonly int _ViewProjMStereo;

			public static readonly int _PrevViewProjMStereo;

			public static readonly int _FullscreenProjMat;

			public static readonly int _FullCoCTexture;

			public static readonly int _HalfCoCTexture;

			public static readonly int _DofTexture;

			public static readonly int _CoCParams;

			public static readonly int _BokehKernel;

			public static readonly int _BokehConstants;

			public static readonly int _DownSampleScaleFactor;

			public static readonly int _Metrics;

			public static readonly int _AreaTexture;

			public static readonly int _SearchTexture;

			public static readonly int _BlendTexture;

			public static readonly int _SourceTexLowMip;

			public static readonly int _Bloom_Params;

			public static readonly int _Bloom_Texture;

			public static readonly int _LensDirt_Texture;

			public static readonly int _LensDirt_Params;

			public static readonly int _LensDirt_Intensity;

			public static readonly int _Distortion_Params1;

			public static readonly int _Distortion_Params2;

			public static readonly int _Chroma_Params;

			public static readonly int _Vignette_Params1;

			public static readonly int _Vignette_Params2;

			public static readonly int _Vignette_ParamsXR;

			public static readonly int _InternalLut;

			public static readonly int _Lut_Params;

			public static readonly int _UserLut;

			public static readonly int _UserLut_Params;
		}

		internal static class Constants
		{
			public const int k_MaxPyramidSize = 16;

			public const int k_GaussianDoFPassComputeCoc = 0;

			public const int k_GaussianDoFPassDownscalePrefilter = 1;

			public const int k_GaussianDoFPassBlurH = 2;

			public const int k_GaussianDoFPassBlurV = 3;

			public const int k_GaussianDoFPassComposite = 4;

			public const int k_BokehDoFPassComputeCoc = 0;

			public const int k_BokehDoFPassDownscalePrefilter = 1;

			public const int k_BokehDoFPassBlur = 2;

			public const int k_BokehDoFPassPostFilter = 3;

			public const int k_BokehDoFPassComposite = 4;
		}

		private class UpdateCameraResolutionPassData
		{
			internal Vector2Int newCameraTargetSize;
		}

		private class StopNaNsPassData
		{
			internal TextureHandle sourceTexture;

			internal Material stopNaN;
		}

		private class SMAASetupPassData
		{
			internal Vector4 metrics;

			internal Texture2D areaTexture;

			internal Texture2D searchTexture;

			internal float stencilRef;

			internal float stencilMask;

			internal AntialiasingQuality antialiasingQuality;

			internal Material material;
		}

		private class SMAAPassData
		{
			internal TextureHandle sourceTexture;

			internal TextureHandle blendTexture;

			internal Material material;
		}

		private class UberSetupBloomPassData
		{
			internal Vector4 bloomParams;

			internal Vector4 dirtScaleOffset;

			internal float dirtIntensity;

			internal Texture dirtTexture;

			internal bool highQualityFilteringValue;

			internal TextureHandle bloomTexture;

			internal Material uberMaterial;
		}

		private class BloomPassData
		{
			internal int mipCount;

			internal Material material;

			internal Material[] upsampleMaterials;

			internal TextureHandle sourceTexture;

			internal TextureHandle[] bloomMipUp;

			internal TextureHandle[] bloomMipDown;
		}

		internal struct BloomMaterialParams
		{
			internal Vector4 parameters;

			internal Vector4 parameters2;

			internal BloomFilterMode bloomFilter;

			internal bool highQualityFiltering;

			internal bool enableAlphaOutput;

			internal bool Equals(ref BloomMaterialParams other)
			{
				return false;
			}
		}

		private class DoFGaussianPassData
		{
			internal int downsample;

			internal RenderingData renderingData;

			internal Vector3 cocParams;

			internal bool highQualitySamplingValue;

			internal TextureHandle sourceTexture;

			internal TextureHandle depthTexture;

			internal Material material;

			internal Material materialCoC;

			internal TextureHandle halfCoCTexture;

			internal TextureHandle fullCoCTexture;

			internal TextureHandle pingTexture;

			internal TextureHandle pongTexture;

			internal RenderTargetIdentifier[] multipleRenderTargets;

			internal TextureHandle destination;
		}

		private class DoFBokehPassData
		{
			internal Vector4[] bokehKernel;

			internal int downSample;

			internal float uvMargin;

			internal Vector4 cocParams;

			internal bool useFastSRGBLinearConversion;

			internal TextureHandle sourceTexture;

			internal TextureHandle depthTexture;

			internal Material material;

			internal Material materialCoC;

			internal TextureHandle halfCoCTexture;

			internal TextureHandle fullCoCTexture;

			internal TextureHandle pingTexture;

			internal TextureHandle pongTexture;

			internal TextureHandle destination;
		}

		private class PaniniProjectionPassData
		{
			internal TextureHandle destinationTexture;

			internal TextureHandle sourceTexture;

			internal Material material;

			internal Vector4 paniniParams;

			internal bool isPaniniGeneric;
		}

		private class MotionBlurPassData
		{
			internal TextureHandle sourceTexture;

			internal TextureHandle motionVectors;

			internal Material material;

			internal int passIndex;

			internal Camera camera;

			internal XRPass xr;

			internal float intensity;

			internal float clamp;

			internal bool enableAlphaOutput;
		}

		private class LensFlarePassData
		{
			internal TextureHandle destinationTexture;

			internal UniversalCameraData cameraData;

			internal Material material;

			internal Rect viewport;

			internal float paniniDistance;

			internal float paniniCropToFit;

			internal float width;

			internal float height;

			internal bool usePanini;
		}

		private class LensFlareScreenSpacePassData
		{
			internal TextureHandle streakTmpTexture;

			internal TextureHandle streakTmpTexture2;

			internal TextureHandle originalBloomTexture;

			internal TextureHandle screenSpaceLensFlareBloomMipTexture;

			internal TextureHandle result;

			internal int actualWidth;

			internal int actualHeight;

			internal Camera camera;

			internal Material material;

			internal ScreenSpaceLensFlare lensFlareScreenSpace;

			internal int downsample;
		}

		private class PostProcessingFinalSetupPassData
		{
			internal TextureHandle destinationTexture;

			internal TextureHandle sourceTexture;

			internal Material material;

			internal UniversalCameraData cameraData;
		}

		private class PostProcessingFinalFSRScalePassData
		{
			internal TextureHandle sourceTexture;

			internal Material material;

			internal bool enableAlphaOutput;

			internal Vector2 fsrInputSize;

			internal Vector2 fsrOutputSize;
		}

		private class PostProcessingFinalBlitPassData
		{
			internal TextureHandle destinationTexture;

			internal TextureHandle sourceTexture;

			internal Material material;

			internal UniversalCameraData cameraData;

			internal FinalBlitSettings settings;
		}

		public struct FinalBlitSettings
		{
			public bool isFxaaEnabled;

			public bool isFsrEnabled;

			public bool isTaaSharpeningEnabled;

			public bool requireHDROutput;

			public bool isAlphaOutputEnabled;

			public HDROutputUtils.Operation hdrOperations;

			public static FinalBlitSettings Create()
			{
				return default(FinalBlitSettings);
			}
		}

		private class UberPostPassData
		{
			internal TextureHandle destinationTexture;

			internal TextureHandle sourceTexture;

			internal TextureHandle lutTexture;

			internal TextureHandle bloomTexture;

			internal Vector4 lutParams;

			internal TextureHandle userLutTexture;

			internal Vector4 userLutParams;

			internal Material material;

			internal UniversalCameraData cameraData;

			internal TonemappingMode toneMappingMode;

			internal bool isHdrGrading;

			internal bool isBackbuffer;

			internal bool enableAlphaOutput;

			internal bool hasFinalPass;
		}

		private class PostFXSetupPassData
		{
		}

		private PostProcessMaterialLibrary m_Materials;

		private DepthOfField m_DepthOfField;

		private MotionBlur m_MotionBlur;

		private PaniniProjection m_PaniniProjection;

		private Bloom m_Bloom;

		private ScreenSpaceLensFlare m_LensFlareScreenSpace;

		private LensDistortion m_LensDistortion;

		private ChromaticAberration m_ChromaticAberration;

		private Vignette m_Vignette;

		private ColorLookup m_ColorLookup;

		private ColorAdjustments m_ColorAdjustments;

		private Tonemapping m_Tonemapping;

		private FilmGrain m_FilmGrain;

		private string[] m_BloomMipDownName;

		private string[] m_BloomMipUpName;

		private TextureHandle[] _BloomMipUp;

		private TextureHandle[] _BloomMipDown;

		private RTHandle m_UserLut;

		private RTHandle m_InternalLut;

		private readonly GraphicsFormat m_SMAAEdgeFormat;

		private readonly GraphicsFormat m_BloomColorFormat;

		private BloomMaterialParams m_BloomParamsPrev;

		private readonly GraphicsFormat m_GaussianCoCFormat;

		private readonly GraphicsFormat m_GaussianDoFColorFormat;

		private Vector4[] m_BokehKernel;

		private int m_BokehHash;

		private float m_BokehMaxRadius;

		private float m_BokehRCPAspect;

		private readonly GraphicsFormat m_LensFlareScreenSpaceColorFormat;

		private int m_DitheringTextureIndex;

		private bool m_HasFinalPass;

		private bool m_EnableColorEncodingIfNeeded;

		private bool m_UseFastSRGBLinearConversion;

		private bool m_SupportScreenSpaceLensFlare;

		private bool m_SupportDataDrivenLensFlare;

		private const string _TemporalAATargetName = "_TemporalAATarget";

		private const string _UpscaledColorTargetName = "_CameraColorUpscaledSTP";

		public PostProcessPassRenderGraph(PostProcessData data, GraphicsFormat requestPostProColorFormat)
		{
		}

		public void Cleanup()
		{
		}

		public void Dispose()
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool IsHDRFormat(GraphicsFormat format)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool IsAlphaFormat(GraphicsFormat format)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private bool RequireSRGBConversionBlitToBackBuffer(bool requireSrgbConversion)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool RequireHDROutput(UniversalCameraData cameraData)
		{
			return false;
		}

		private void UpdateCameraResolution(RenderGraph renderGraph, UniversalCameraData cameraData, Vector2Int newCameraTargetSize)
		{
		}

		internal static TextureHandle CreateCompatibleTexture(RenderGraph renderGraph, in TextureHandle source, string name, bool clear, FilterMode filterMode)
		{
			return default(TextureHandle);
		}

		internal static TextureHandle CreateCompatibleTexture(RenderGraph renderGraph, in TextureDesc desc, string name, bool clear, FilterMode filterMode)
		{
			return default(TextureHandle);
		}

		internal static TextureDesc GetCompatibleDescriptor(TextureDesc desc, int width, int height, GraphicsFormat format)
		{
			return default(TextureDesc);
		}

		internal static TextureDesc GetCompatibleDescriptor(TextureDesc desc)
		{
			return default(TextureDesc);
		}

		internal static void MakeCompatible(ref TextureDesc desc)
		{
		}

		internal static RenderTextureDescriptor GetCompatibleDescriptor(RenderTextureDescriptor desc, int width, int height, GraphicsFormat format, GraphicsFormat depthStencilFormat = GraphicsFormat.None)
		{
			return default(RenderTextureDescriptor);
		}

		public void RenderStopNaN(RenderGraph renderGraph, in TextureHandle activeCameraColor, out TextureHandle stopNaNTarget)
		{
			stopNaNTarget = default(TextureHandle);
		}

		public void RenderSMAA(RenderGraph renderGraph, UniversalResourceData resourceData, AntialiasingQuality antialiasingQuality, in TextureHandle source, out TextureHandle SMAATarget)
		{
			SMAATarget = default(TextureHandle);
		}

		public void UberPostSetupBloomPass(RenderGraph rendergraph, Material uberMaterial, in TextureDesc srcDesc)
		{
		}

		public Vector2Int CalcBloomResolution(Bloom bloom, in TextureDesc bloomSourceDesc)
		{
			return default(Vector2Int);
		}

		public int CalcBloomMipCount(Bloom bloom, Vector2Int bloomResolution)
		{
			return 0;
		}

		public void RenderBloomTexture(RenderGraph renderGraph, in TextureHandle source, out TextureHandle destination, bool enableAlphaOutput)
		{
			destination = default(TextureHandle);
		}

		private TextureHandle BloomGaussian(RenderGraph renderGraph, TextureHandle source, int mipCount)
		{
			return default(TextureHandle);
		}

		private TextureHandle BloomKawase(RenderGraph renderGraph, TextureHandle source, int mipCount)
		{
			return default(TextureHandle);
		}

		private TextureHandle BloomDual(RenderGraph renderGraph, TextureHandle source, int mipCount)
		{
			return default(TextureHandle);
		}

		public void RenderDoF(RenderGraph renderGraph, UniversalResourceData resourceData, UniversalCameraData cameraData, in TextureHandle source, out TextureHandle destination)
		{
			destination = default(TextureHandle);
		}

		public void RenderDoFGaussian(RenderGraph renderGraph, UniversalResourceData resourceData, UniversalCameraData cameraData, in TextureHandle source, TextureHandle destination, ref Material dofMaterial)
		{
		}

		private void PrepareBokehKernel(float maxRadius, float rcpAspect)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float GetMaxBokehRadiusInPixels(float viewportHeight)
		{
			return 0f;
		}

		public void RenderDoFBokeh(RenderGraph renderGraph, UniversalResourceData resourceData, UniversalCameraData cameraData, in TextureHandle source, in TextureHandle destination, ref Material dofMaterial)
		{
		}

		public void RenderPaniniProjection(RenderGraph renderGraph, Camera camera, in TextureHandle source, out TextureHandle destination)
		{
			destination = default(TextureHandle);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static Vector2 CalcViewExtents(Camera camera, int width, int height)
		{
			return default(Vector2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static Vector2 CalcCropExtents(Camera camera, float d, int width, int height)
		{
			return default(Vector2);
		}

		private void RenderTemporalAA(RenderGraph renderGraph, UniversalResourceData resourceData, UniversalCameraData cameraData, ref TextureHandle source, out TextureHandle destination)
		{
			destination = default(TextureHandle);
		}

		private void RenderSTP(RenderGraph renderGraph, UniversalResourceData resourceData, UniversalCameraData cameraData, ref TextureHandle source, out TextureHandle destination)
		{
			destination = default(TextureHandle);
		}

		public void RenderMotionBlur(RenderGraph renderGraph, UniversalResourceData resourceData, UniversalCameraData cameraData, in TextureHandle source, out TextureHandle destination)
		{
			destination = default(TextureHandle);
		}

		internal static void UpdateMotionBlurMatrices(ref Material material, Camera camera, XRPass xr)
		{
		}

		private void LensFlareDataDrivenComputeOcclusion(RenderGraph renderGraph, UniversalResourceData resourceData, UniversalCameraData cameraData, in TextureDesc srcDesc)
		{
		}

		public void RenderLensFlareDataDriven(RenderGraph renderGraph, UniversalResourceData resourceData, UniversalCameraData cameraData, in TextureHandle destination, in TextureDesc srcDesc)
		{
		}

		private static float GetLensFlareLightAttenuation(Light light, Camera cam, Vector3 wo)
		{
			return 0f;
		}

		public TextureHandle RenderLensFlareScreenSpace(RenderGraph renderGraph, Camera camera, in TextureDesc srcDesc, TextureHandle originalBloomTexture, TextureHandle screenSpaceLensFlareBloomMipTexture, bool sameBloomInputOutputTex)
		{
			return default(TextureHandle);
		}

		private static void ScaleViewport(RasterCommandBuffer cmd, RTHandle sourceTextureHdl, RTHandle dest, UniversalCameraData cameraData, bool hasFinalPass)
		{
		}

		private static void ScaleViewportAndBlit(in RasterGraphContext context, in TextureHandle source, in TextureHandle destination, UniversalCameraData cameraData, Material material, bool hasFinalPass)
		{
		}

		private static void ScaleViewportAndDrawVisibilityMesh(in RasterGraphContext context, in TextureHandle source, in TextureHandle destination, UniversalCameraData cameraData, Material material, bool hasFinalPass)
		{
		}

		public void RenderFinalSetup(RenderGraph renderGraph, UniversalCameraData cameraData, in TextureHandle source, in TextureHandle destination, ref FinalBlitSettings settings)
		{
		}

		public void RenderFinalFSRScale(RenderGraph renderGraph, in TextureHandle source, in TextureDesc srcDesc, in TextureHandle destination, in TextureDesc dstDesc, bool enableAlphaOutput)
		{
		}

		public void RenderFinalBlit(RenderGraph renderGraph, UniversalCameraData cameraData, in TextureHandle source, in TextureHandle overlayUITexture, in TextureHandle postProcessingTarget, ref FinalBlitSettings settings)
		{
		}

		public void RenderFinalPassRenderGraph(RenderGraph renderGraph, ContextContainer frameData, in TextureHandle source, in TextureHandle overlayUITexture, in TextureHandle postProcessingTarget, bool enableColorEncodingIfNeeded)
		{
		}

		private TextureHandle TryGetCachedUserLutTextureHandle(RenderGraph renderGraph)
		{
			return default(TextureHandle);
		}

		public void RenderUberPost(RenderGraph renderGraph, ContextContainer frameData, UniversalCameraData cameraData, UniversalPostProcessingData postProcessingData, in TextureHandle sourceTexture, in TextureHandle destTexture, in TextureHandle lutTexture, in TextureHandle bloomTexture, in TextureHandle overlayUITexture, bool requireHDROutput, bool enableAlphaOutput, bool hasFinalPass)
		{
		}

		public void RenderPostProcessingRenderGraph(RenderGraph renderGraph, ContextContainer frameData, in TextureHandle activeCameraColorTexture, in TextureHandle lutTexture, in TextureHandle overlayUITexture, in TextureHandle postProcessingTarget, bool hasFinalPass, bool resolveToDebugScreen, bool enableColorEndingIfNeeded)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetupLensDistortion(Material material, bool isSceneView)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetupChromaticAberration(Material material)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetupVignette(Material material, XRPass xrPass, int width, int height)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetupGrain(UniversalCameraData cameraData, Material material)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetupDithering(UniversalCameraData cameraData, Material material)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetupHDROutput(HDROutputUtils.HDRDisplayInformation hdrDisplayInformation, ColorGamut hdrDisplayColorGamut, Material material, HDROutputUtils.Operation hdrOperations, bool rendersOverlayUI)
		{
		}
	}
}
