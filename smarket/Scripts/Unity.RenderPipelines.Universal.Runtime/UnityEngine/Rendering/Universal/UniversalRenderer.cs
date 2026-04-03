using System;
using System.Collections.Generic;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering.RenderGraphModule;
using UnityEngine.Rendering.Universal.CompatibilityMode;
using UnityEngine.Rendering.Universal.Internal;

namespace UnityEngine.Rendering.Universal
{
	public sealed class UniversalRenderer : ScriptableRenderer
	{
		private static class ProfilingCompatibilityMode
		{
			private const string k_Name = "UniversalRenderer";

			public static readonly ProfilingSampler createCameraRenderTarget;
		}

		private struct RenderPassInputSummary
		{
			internal bool requiresDepthTexture;

			internal bool requiresDepthPrepass;

			internal bool requiresNormalsTexture;

			internal bool requiresColorTexture;

			internal bool requiresMotionVectors;

			internal RenderPassEvent requiresDepthNormalAtEvent;

			internal RenderPassEvent requiresDepthTextureEarliestEvent;
		}

		private class CopyToDebugTexturePassData
		{
			internal TextureHandle src;

			internal TextureHandle dest;
		}

		private readonly struct ClearCameraParams
		{
			internal readonly bool mustClearColor;

			internal readonly bool mustClearDepth;

			internal readonly Color clearValue;

			internal ClearCameraParams(bool clearColor, bool clearDepth, Color clearVal)
			{
				mustClearColor = false;
				mustClearDepth = false;
				clearValue = default(Color);
			}
		}

		private enum OccluderPass
		{
			None = 0,
			DepthPrepass = 1,
			ForwardOpaque = 2,
			GBuffer = 3
		}

		private enum DepthCopySchedule
		{
			DuringPrepass = 0,
			AfterPrepass = 1,
			AfterGBuffer = 2,
			AfterOpaques = 3,
			AfterSkybox = 4,
			AfterTransparents = 5,
			None = 6
		}

		private enum ColorCopySchedule
		{
			AfterSkybox = 0,
			None = 1
		}

		private struct TextureCopySchedules
		{
			internal DepthCopySchedule depth;

			internal ColorCopySchedule color;
		}

		private const int k_FinalBlitPassQueueOffset = 1;

		private const int k_AfterFinalBlitPassQueueOffset = 2;

		private static readonly List<ShaderTagId> k_DepthNormalsOnly;

		private DepthOnlyPass m_DepthPrepass;

		private DepthNormalOnlyPass m_DepthNormalPrepass;

		private MotionVectorRenderPass m_MotionVectorPass;

		private MainLightShadowCasterPass m_MainLightShadowCasterPass;

		private AdditionalLightsShadowCasterPass m_AdditionalLightsShadowCasterPass;

		private GBufferPass m_GBufferPass;

		private DeferredPass m_DeferredPass;

		private DrawObjectsPass m_RenderOpaqueForwardOnlyPass;

		private DrawObjectsPass m_RenderOpaqueForwardPass;

		private DrawObjectsWithRenderingLayersPass m_RenderOpaqueForwardWithRenderingLayersPass;

		private DrawSkyboxPass m_DrawSkyboxPass;

		private CopyDepthPass m_CopyDepthPass;

		private CopyColorPass m_CopyColorPass;

		private TransparentSettingsPass m_TransparentSettingsPass;

		private DrawObjectsPass m_RenderTransparentForwardPass;

		private InvokeOnRenderObjectCallbackPass m_OnRenderObjectCallbackPass;

		private FinalBlitPass m_FinalBlitPass;

		private FinalBlitPass m_OffscreenUICoverPrepass;

		private CapturePass m_CapturePass;

		private XROcclusionMeshPass m_XROcclusionMeshPass;

		private CopyDepthPass m_XRCopyDepthPass;

		private XRDepthMotionPass m_XRDepthMotionPass;

		private DrawScreenSpaceUIPass m_DrawOffscreenUIPass;

		private DrawScreenSpaceUIPass m_DrawOverlayUIPass;

		private CopyColorPass m_HistoryRawColorCopyPass;

		private CopyDepthPass m_HistoryRawDepthCopyPass;

		private StencilCrossFadeRenderPass m_StencilCrossFadeRenderPass;

		private RTHandle m_TargetColorHandle;

		private RTHandle m_TargetDepthHandle;

		private ForwardLights m_ForwardLights;

		private DeferredLights m_DeferredLights;

		private RenderingMode m_RenderingMode;

		private DepthPrimingMode m_DepthPrimingMode;

		private CopyDepthMode m_CopyDepthMode;

		private DepthFormat m_CameraDepthAttachmentFormat;

		private DepthFormat m_CameraDepthTextureFormat;

		private StencilState m_DefaultStencilState;

		private LightCookieManager m_LightCookieManager;

		private IntermediateTextureMode m_IntermediateTextureMode;

		private Material m_BlitMaterial;

		private Material m_BlitHDRMaterial;

		private Material m_SamplingMaterial;

		private Material m_BlitOffscreenUICoverMaterial;

		private Material m_StencilDeferredMaterial;

		private Material m_ClusterDeferredMaterial;

		private Material m_CameraMotionVecMaterial;

		private CopyDepthPass m_PrimedDepthCopyPass;

		private CopyDepthPass m_GBufferCopyDepthPass;

		internal RenderTargetBufferSystem m_ColorBufferSystem;

		internal RTHandle m_ActiveCameraColorAttachment;

		internal RTHandle m_ActiveCameraDepthAttachment;

		internal RTHandle m_CameraDepthAttachment;

		internal RTHandle m_CameraDepthAttachment_D3d_11;

		internal RTHandle m_DepthTexture;

		private RTHandle m_NormalsTexture;

		private RTHandle m_DecalLayersTexture;

		private RTHandle m_OpaqueColor;

		private RTHandle m_MotionVectorColor;

		private RTHandle m_MotionVectorDepth;

		private bool m_DepthPrimingRecommended;

		private bool m_VulkanEnablePreTransform;

		private PostProcessPasses m_PostProcessPasses;

		private Material m_DebugBlitMaterial;

		private static RTHandle[] m_RenderGraphCameraColorHandles;

		private static RTHandle m_RenderGraphCameraDepthHandle;

		private static int m_CurrentColorHandle;

		private static RTHandle m_RenderGraphDebugTextureHandle;

		private static RTHandle m_OffscreenUIColorHandle;

		private bool m_RequiresRenderingLayer;

		private RenderingLayerUtils.Event m_RenderingLayersEvent;

		private RenderingLayerUtils.MaskSize m_RenderingLayersMaskSize;

		private bool m_RenderingLayerProvidesRenderObjectPass;

		private bool m_RenderingLayerProvidesByDepthNormalPass;

		private string m_RenderingLayersTextureName;

		private ColorGradingLutPass m_ColorGradingLutPassRenderGraph;

		private PostProcessPassRenderGraph m_PostProcessPassRenderGraph;

		private const string _CameraTargetAttachmentAName = "_CameraTargetAttachmentA";

		private const string _CameraTargetAttachmentBName = "_CameraTargetAttachmentB";

		private const string _SingleCameraTargetAttachmentName = "_CameraTargetAttachment";

		private const string _CameraDepthAttachmentName = "_CameraDepthAttachment";

		private const string _CameraColorUpscaled = "_CameraColorUpscaled";

		private const string _CameraColorAfterPostProcessingName = "_CameraColorAfterPostProcessing";

		private bool m_IssuedGPUOcclusionUnsupportedMsg;

		private static bool m_RequiresIntermediateAttachments;

		internal RenderingMode renderingModeRequested => default(RenderingMode);

		private bool deferredModeUnsupported => false;

		internal RenderingMode renderingModeActual => default(RenderingMode);

		internal bool usesDeferredLighting => false;

		internal bool usesClusterLightLoop => false;

		internal bool accurateGbufferNormals => false;

		internal bool needTransparencyPass => false;

		public DepthPrimingMode depthPrimingMode
		{
			get
			{
				return default(DepthPrimingMode);
			}
			set
			{
			}
		}

		internal ColorGradingLutPass colorGradingLutPass => null;

		internal PostProcessPass postProcessPass => null;

		internal PostProcessPass finalPostProcessPass => null;

		internal RTHandle colorGradingLut => null;

		internal bool isPostProcessPassRenderGraphActive => false;

		internal DeferredLights deferredLights => null;

		internal LayerMask prepassLayerMask { get; set; }

		internal LayerMask opaqueLayerMask { get; set; }

		internal LayerMask transparentLayerMask { get; set; }

		internal bool shadowTransparentReceive { get; set; }

		internal GraphicsFormat cameraDepthTextureFormat => default(GraphicsFormat);

		internal GraphicsFormat cameraDepthAttachmentFormat => default(GraphicsFormat);

		internal override bool supportsNativeRenderPassRendergraphCompiler => false;

		private RTHandle currentRenderGraphCameraColorHandle => null;

		private RTHandle nextRenderGraphCameraColorHandle => null;

		public override bool supportsGPUOcclusion => false;

		public override int SupportedCameraStackingTypes()
		{
			return 0;
		}

		protected internal override bool SupportsMotionVectors()
		{
			return false;
		}

		protected internal override bool SupportsCameraOpaque()
		{
			return false;
		}

		protected internal override bool SupportsCameraNormals()
		{
			return false;
		}

		public UniversalRenderer(UniversalRendererData data)
			: base(null)
		{
		}

		protected override void Dispose(bool disposing)
		{
		}

		internal override void ReleaseRenderTargets()
		{
		}

		private void SetupFinalPassDebug(UniversalCameraData cameraData)
		{
		}

		public static bool IsOffscreenDepthTexture(ref CameraData cameraData)
		{
			return false;
		}

		public static bool IsOffscreenDepthTexture(UniversalCameraData cameraData)
		{
			return false;
		}

		private bool IsDepthPrimingEnabled(UniversalCameraData cameraData)
		{
			return false;
		}

		private static bool IsWebGL()
		{
			return false;
		}

		private static bool IsGLESDevice()
		{
			return false;
		}

		private static bool IsGLDevice()
		{
			return false;
		}

		private static bool HasActiveRenderFeatures(List<ScriptableRendererFeature> rendererFeatures)
		{
			return false;
		}

		private static bool HasPassesRequiringIntermediateTexture(List<ScriptableRenderPass> activeRenderPassQueue)
		{
			return false;
		}

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		public override void Setup(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		private static void SetupVFXCameraBuffer(UniversalCameraData cameraData)
		{
		}

		private void SetupRawColorDepthHistory(UniversalCameraData cameraData, ref RenderTextureDescriptor cameraTargetDescriptor)
		{
		}

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		public override void SetupLights(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		public override void SetupCullingParameters(ref ScriptableCullingParameters cullingParameters, ref CameraData cameraData)
		{
		}

		public override void FinishRendering(CommandBuffer cmd)
		{
		}

		private void EnqueueDeferred(RenderTextureDescriptor cameraTargetDescriptor, bool hasDepthPrepass, bool hasNormalPrepass, bool hasRenderingLayerPrepass, bool applyMainShadow, bool applyAdditionalShadow)
		{
		}

		private static RenderPassInputSummary GetRenderPassInputs(bool isTemporalAAEnabled, bool postProcessingEnabled, bool isSceneViewCamera, bool renderingLayerProvidesByDepthNormalPass, List<ScriptableRenderPass> activeRenderPassQueue, MotionVectorRenderPass motionVectorPass)
		{
			return default(RenderPassInputSummary);
		}

		private void CreateCameraRenderTarget(ScriptableRenderContext context, ref RenderTextureDescriptor descriptor, CommandBuffer cmd, UniversalCameraData cameraData)
		{
		}

		internal static bool PlatformRequiresExplicitMsaaResolve()
		{
			return false;
		}

		private static bool RequiresIntermediateColorTexture(UniversalCameraData cameraData, in RenderPassInputSummary renderPassInputs, bool usesDeferredLighting, bool applyPostProcessing)
		{
			return false;
		}

		private static bool IsScalableBufferManagerUsed(UniversalCameraData cameraData)
		{
			return false;
		}

		private static bool CanCopyDepth(UniversalCameraData cameraData)
		{
			return false;
		}

		internal override void SwapColorBuffer(CommandBuffer cmd)
		{
		}

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		internal override RTHandle GetCameraColorFrontBuffer(CommandBuffer cmd)
		{
			return null;
		}

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		internal override RTHandle GetCameraColorBackBuffer(CommandBuffer cmd)
		{
			return null;
		}

		internal override void EnableSwapBufferMSAA(bool enable)
		{
		}

		private bool DebugHandlerRequireDepthPass(UniversalCameraData cameraData)
		{
			return false;
		}

		private void CreateDebugTexture(RenderTextureDescriptor descriptor)
		{
		}

		private Rect CalculateUVRect(UniversalCameraData cameraData, float width, float height)
		{
			return default(Rect);
		}

		private Rect CalculateUVRect(UniversalCameraData cameraData, int textureHeightPercent)
		{
			return default(Rect);
		}

		private void CorrectForTextureAspectRatio(ref float width, ref float height, float sourceWidth, float sourceHeight)
		{
		}

		private void SetupRenderGraphFinalPassDebug(RenderGraph renderGraph, ContextContainer frameData)
		{
		}

		private void SetupAfterPostRenderGraphFinalPassDebug(RenderGraph renderGraph, ContextContainer frameData)
		{
		}

		private void BlitToDebugTexture(RenderGraph renderGraph, TextureHandle source, TextureHandle destination, bool isSourceTextureColor = false)
		{
		}

		private void BlitEmptyTexture(RenderGraph renderGraph, TextureHandle destination, string passName = "Copy To Debug Texture")
		{
		}

		private void CleanupRenderGraphResources()
		{
		}

		public static TextureHandle CreateRenderGraphTexture(RenderGraph renderGraph, RenderTextureDescriptor desc, string name, bool clear, FilterMode filterMode = FilterMode.Point, TextureWrapMode wrapMode = TextureWrapMode.Clamp)
		{
			return default(TextureHandle);
		}

		internal static TextureHandle CreateRenderGraphTexture(RenderGraph renderGraph, in RenderTextureDescriptor desc, string name, bool clear, Color color, FilterMode filterMode = FilterMode.Point, TextureWrapMode wrapMode = TextureWrapMode.Clamp, bool discardOnLastUse = false)
		{
			return default(TextureHandle);
		}

		internal static void GetTextureDesc(in RenderTextureDescriptor desc, out TextureDesc rgDesc)
		{
			rgDesc = default(TextureDesc);
		}

		internal static TextureHandle CreateRenderGraphTexture(RenderGraph renderGraph, in TextureDesc desc, string name, bool clear, Color clearColor, FilterMode filterMode = FilterMode.Point, TextureWrapMode wrapMode = TextureWrapMode.Clamp, bool discardOnLastUse = false)
		{
			return default(TextureHandle);
		}

		private bool RequiresIntermediateAttachments(UniversalCameraData cameraData, in RenderPassInputSummary renderPassInputs, bool requireCopyFromDepth, bool applyPostProcessing)
		{
			return false;
		}

		private void UpdateCameraHistory(UniversalCameraData cameraData)
		{
		}

		private void CreateRenderGraphCameraRenderTargets(RenderGraph renderGraph, bool isCameraTargetOffscreenDepth, bool requireIntermediateAttachments, bool depthTextureIsDepthFormat)
		{
		}

		private ClearCameraParams GetClearCameraParams(UniversalCameraData cameraData)
		{
			return default(ClearCameraParams);
		}

		private void SetupTargetHandles(UniversalCameraData cameraData)
		{
		}

		private void SetupRenderingLayers(int msaaSamples)
		{
		}

		internal void SetupRenderGraphLights(RenderGraph renderGraph, UniversalRenderingData renderingData, UniversalCameraData cameraData, UniversalLightData lightData)
		{
		}

		private void RenderRawColorDepthHistory(RenderGraph renderGraph, UniversalCameraData cameraData, UniversalResourceData resourceData)
		{
		}

		public override void OnBeginRenderGraphFrame()
		{
		}

		internal override void OnRecordRenderGraph(RenderGraph renderGraph, ScriptableRenderContext context)
		{
		}

		public override void OnEndRenderGraphFrame()
		{
		}

		internal override void OnFinishRenderGraphRendering(CommandBuffer cmd)
		{
		}

		private void OnOffscreenDepthTextureRendering(RenderGraph renderGraph, ScriptableRenderContext context, UniversalResourceData resourceData, UniversalCameraData cameraData)
		{
		}

		private void OnBeforeRendering(RenderGraph renderGraph)
		{
		}

		private void UpdateInstanceOccluders(RenderGraph renderGraph, UniversalCameraData cameraData, TextureHandle depthTexture)
		{
		}

		private void InstanceOcclusionTest(RenderGraph renderGraph, UniversalCameraData cameraData, OcclusionTest occlusionTest)
		{
		}

		private void RecordCustomPassesWithDepthCopyAndMotion(RenderGraph renderGraph, UniversalResourceData resourceData, RenderPassEvent earliestDepthReadEvent, RenderPassEvent currentEvent, bool renderMotionVectors)
		{
		}

		private static bool AllowPartialDepthNormalsPrepass(bool isDeferred, RenderPassEvent requiresDepthNormalEvent, bool useDepthPriming)
		{
			return false;
		}

		private DepthCopySchedule CalculateDepthCopySchedule(RenderPassEvent earliestDepthReadEvent, bool hasFullPrepass)
		{
			return default(DepthCopySchedule);
		}

		private TextureCopySchedules CalculateTextureCopySchedules(UniversalCameraData cameraData, in RenderPassInputSummary renderPassInputs, bool isDeferred, bool requiresDepthPrepass, bool hasFullPrepass, bool requireDepthTexture)
		{
			return default(TextureCopySchedules);
		}

		private void CopyDepthToDepthTexture(RenderGraph renderGraph, UniversalResourceData resourceData)
		{
		}

		private void RenderMotionVectors(RenderGraph renderGraph, UniversalResourceData resourceData)
		{
		}

		private void ExecuteScheduledDepthCopyWithMotion(RenderGraph renderGraph, UniversalResourceData resourceData, bool renderMotionVectors)
		{
		}

		private void OnMainRendering(RenderGraph renderGraph, ScriptableRenderContext context, in RenderPassInputSummary renderPassInputs, bool requiresPrepass, bool requireDepthTexture)
		{
		}

		private void OnAfterRendering(RenderGraph renderGraph, bool applyPostProcessing)
		{
		}

		private bool RequirePrepassForTextures(UniversalCameraData cameraData, in RenderPassInputSummary renderPassInputs, bool requireDepthTexture)
		{
			return false;
		}

		private static bool RequireDepthTexture(UniversalCameraData cameraData, in RenderPassInputSummary renderPassInputs, bool applyPostProcessing)
		{
			return false;
		}

		private static bool IsDepthPrimingEnabledRenderGraph(UniversalCameraData cameraData, in RenderPassInputSummary renderPassInputs, DepthPrimingMode depthPrimingMode, bool requireDepthTexture, bool requirePrepassForTextures, bool usesDeferredLighting)
		{
			return false;
		}

		internal void SetRenderingLayersGlobalTextures(RenderGraph renderGraph)
		{
		}

		private void ImportBackBuffers(RenderGraph renderGraph, UniversalCameraData cameraData, Color clearBackgroundColor, bool isCameraTargetOffscreenDepth)
		{
		}

		private void CreateIntermediateCameraColorAttachment(RenderGraph renderGraph, UniversalCameraData cameraData, in TextureDesc cameraDescriptor, bool clearColor, Color clearBackgroundColor)
		{
		}

		private void CreateIntermediateCameraDepthAttachment(RenderGraph renderGraph, UniversalCameraData cameraData, in TextureDesc cameraDescriptor, bool clearDepth, Color clearBackgroundDepth, bool depthTextureIsDepthFormat)
		{
		}

		private void CreateCameraDepthCopyTexture(RenderGraph renderGraph, TextureDesc descriptor, bool isDepthTexture, Color clearColor)
		{
		}

		private void CreateMotionVectorTextures(RenderGraph renderGraph, TextureDesc descriptor)
		{
		}

		private void CreateCameraNormalsTexture(RenderGraph renderGraph, TextureDesc descriptor)
		{
		}

		private void CreateRenderingLayersTexture(RenderGraph renderGraph, TextureDesc descriptor)
		{
		}

		private void CreateAfterPostProcessTexture(RenderGraph renderGraph, RenderTextureDescriptor descriptor)
		{
		}

		private void CreateOffscreenUITexture(RenderGraph renderGraph, TextureDesc descriptor)
		{
		}

		private void DepthNormalPrepassRender(RenderGraph renderGraph, RenderPassInputSummary renderPassInputs, in TextureHandle depthTarget, uint batchLayerMask, bool setGlobalDepth, bool setGlobalTextures, bool partialPass)
		{
		}
	}
}
