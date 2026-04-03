using System;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal
{
	public sealed class UniversalRenderPipeline : RenderPipeline
	{
		internal static class CameraMetadataCache
		{
			public class CameraMetadataCacheEntry
			{
				public ProfilingSampler sampler;
			}

			private static Dictionary<int, CameraMetadataCacheEntry> s_MetadataCache;

			private static readonly CameraMetadataCacheEntry k_NoAllocEntry;

			public static CameraMetadataCacheEntry GetCached(Camera camera)
			{
				return null;
			}
		}

		internal static class Profiling
		{
			public static class Pipeline
			{
				public static class Renderer
				{
					private const string k_Name = "ScriptableRenderer";

					public static readonly ProfilingSampler setupCullingParameters;

					public static readonly ProfilingSampler setup;
				}

				public static class Context
				{
					private const string k_Name = "ScriptableRenderContext";

					public static readonly ProfilingSampler submit;
				}

				private const string k_Name = "UniversalRenderPipeline";

				public static readonly ProfilingSampler initializeCameraData;

				public static readonly ProfilingSampler initializeStackedCameraData;

				public static readonly ProfilingSampler initializeAdditionalCameraData;

				public static readonly ProfilingSampler initializeRenderingData;

				public static readonly ProfilingSampler initializeShadowData;

				public static readonly ProfilingSampler initializeLightData;

				public static readonly ProfilingSampler buildAdditionalLightsShadowAtlasLayout;

				public static readonly ProfilingSampler getPerObjectLightFlags;

				public static readonly ProfilingSampler getMainLightIndex;

				public static readonly ProfilingSampler setupPerFrameShaderConstants;

				public static readonly ProfilingSampler setupPerCameraShaderConstants;
			}
		}

		private readonly struct CameraRenderingScope : IDisposable
		{
			private static readonly ProfilingSampler beginCameraRenderingSampler;

			private static readonly ProfilingSampler endCameraRenderingSampler;

			private readonly ScriptableRenderContext m_Context;

			private readonly Camera m_Camera;

			public CameraRenderingScope(ScriptableRenderContext context, Camera camera)
			{
				m_Context = default(ScriptableRenderContext);
				m_Camera = null;
			}

			public void Dispose()
			{
			}
		}

		private readonly struct ContextRenderingScope : IDisposable
		{
			private static readonly ProfilingSampler beginContextRenderingSampler;

			private static readonly ProfilingSampler endContextRenderingSampler;

			private readonly ScriptableRenderContext m_Context;

			private readonly List<Camera> m_Cameras;

			public ContextRenderingScope(ScriptableRenderContext context, List<Camera> cameras)
			{
				m_Context = default(ScriptableRenderContext);
				m_Cameras = null;
			}

			public void Dispose()
			{
			}
		}

		public class SingleCameraRequest
		{
			public RenderTexture destination;

			public int mipLevel;

			public CubemapFace face;

			public int slice;
		}

		public const string k_ShaderTagName = "UniversalPipeline";

		internal const int k_DefaultRenderingLayerMask = 1;

		private readonly DebugDisplaySettingsUI m_DebugDisplaySettingsUI;

		private UniversalRenderPipelineGlobalSettings m_GlobalSettings;

		internal static bool stackedOverlayCamerasRequireDepthForPostProcessing;

		internal static RenderGraph s_RenderGraph;

		internal static RTHandleResourcePool s_RTHandlePool;

		internal static bool useRenderGraph;

		internal bool apvIsEnabled;

		internal static bool requireOffscreenUICoverPrepass;

		internal static bool offscreenUIRenderedInCurrentFrame;

		private readonly UniversalRenderPipelineAsset pipelineAsset;

		internal bool enableHDROutputOnce;

		internal bool warnedRuntimeSwitchHDROutputToSDROutput;

		private static Vector4 k_DefaultLightPosition;

		private static Vector4 k_DefaultLightColor;

		private static Vector4 k_DefaultLightAttenuation;

		private static Vector4 k_DefaultLightSpotDirection;

		private static Vector4 k_DefaultLightsProbeChannel;

		private static List<Vector4> m_ShadowBiasData;

		private static List<int> m_ShadowResolutionData;

		private Comparison<Camera> cameraComparison;

		private static Lightmapping.RequestLightsDelegate lightsDelegate;

		public static float maxShadowBias => 0f;

		public static float minRenderScale => 0f;

		public static float maxRenderScale => 0f;

		public static int maxNumIterationsEnclosingSphere => 0;

		public static int maxPerObjectLights => 0;

		public static int maxVisibleAdditionalLights => 0;

		internal static int lightsPerTile => 0;

		internal static int maxZBinWords => 0;

		internal static int maxTileWords => 0;

		internal static int maxVisibleReflectionProbes => 0;

		internal UniversalRenderPipelineRuntimeTextures runtimeTextures { get; private set; }

		internal static RenderTextureUVOriginStrategy renderTextureUVOriginStrategy { private get; set; }

		public override RenderPipelineGlobalSettings defaultSettings => null;

		internal static bool canOptimizeScreenMSAASamples { get; private set; }

		internal static int startFrameScreenMSAASamples { get; private set; }

		public static UniversalRenderPipelineAsset asset => null;

		public override string ToString()
		{
			return null;
		}

		public UniversalRenderPipeline(UniversalRenderPipelineAsset asset)
		{
		}

		protected override void Dispose(bool disposing)
		{
		}

		private void DisposeAdditionalCameraData()
		{
		}

		protected override void Render(ScriptableRenderContext renderContext, List<Camera> cameras)
		{
		}

		protected override bool IsRenderRequestSupported<RequestData>(Camera camera, RequestData data)
		{
			return false;
		}

		protected override void ProcessRenderRequests<RequestData>(ScriptableRenderContext context, Camera camera, RequestData renderRequest)
		{
		}

		[Obsolete("RenderSingleCamera is obsolete, please use RenderPipeline.SubmitRenderRequest with UniversalRenderer.SingleCameraRequest as RequestData type. #from(2023.1)")]
		public static void RenderSingleCamera(ScriptableRenderContext context, Camera camera)
		{
		}

		internal static void RenderSingleCameraInternal(ScriptableRenderContext context, Camera camera, bool isLastBaseCamera = true)
		{
		}

		internal static void RenderSingleCameraInternal(ScriptableRenderContext context, Camera camera, ref UniversalAdditionalCameraData additionalCameraData, bool isLastBaseCamera = true)
		{
		}

		private static bool TryGetCullingParameters(UniversalCameraData cameraData, out ScriptableCullingParameters cullingParams)
		{
			cullingParams = default(ScriptableCullingParameters);
			return false;
		}

		private static void RenderSingleCamera(ScriptableRenderContext context, UniversalCameraData cameraData)
		{
		}

		private static void CreateShadowAtlasAndCullShadowCasters(UniversalLightData lightData, UniversalShadowData shadowData, UniversalCameraData cameraData, ref CullingResults cullResults, ref ScriptableRenderContext context)
		{
		}

		private static void RenderCameraStack(ScriptableRenderContext context, Camera baseCamera, bool isLastBaseCamera)
		{
		}

		private static void UpdateCameraData(UniversalCameraData baseCameraData, in XRPass xr)
		{
		}

		private static void UpdateVolumeFramework(Camera camera, UniversalAdditionalCameraData additionalCameraData)
		{
		}

		private static bool CheckPostProcessForDepth(UniversalCameraData cameraData)
		{
			return false;
		}

		private static bool CheckPostProcessForDepth()
		{
			return false;
		}

		private static void SetSupportedRenderingFeatures(UniversalRenderPipelineAsset pipelineAsset)
		{
		}

		private static ScriptableRenderer GetRenderer(Camera camera, UniversalAdditionalCameraData additionalCameraData)
		{
			return null;
		}

		internal static void InitializeScaledDimensions(Camera camera, UniversalCameraData cameraData)
		{
		}

		private static UniversalCameraData CreateCameraData(ContextContainer frameData, Camera camera, UniversalAdditionalCameraData additionalCameraData)
		{
			return null;
		}

		private static void InitializeStackedCameraData(Camera baseCamera, UniversalAdditionalCameraData baseAdditionalCameraData, UniversalCameraData cameraData)
		{
		}

		private static void InitializeAdditionalCameraData(Camera camera, UniversalAdditionalCameraData additionalCameraData, bool resolveFinalTarget, bool isLastBaseCamera, UniversalCameraData cameraData)
		{
		}

		private static UniversalRenderingData CreateRenderingData(ContextContainer frameData, UniversalRenderPipelineAsset settings, CommandBuffer cmd, RenderingMode? renderingMode, ScriptableRenderer renderer)
		{
			return null;
		}

		private static UniversalShadowData CreateShadowData(ContextContainer frameData, UniversalRenderPipelineAsset urpAsset, RenderingMode? renderingMode)
		{
			return null;
		}

		private static CullContextData CreateCullContextData(ContextContainer frameData, ScriptableRenderContext context)
		{
			return null;
		}

		private static Vector3 GetMainLightCascadeSplit(int mainLightShadowCascadesCount, UniversalRenderPipelineAsset urpAsset)
		{
			return default(Vector3);
		}

		private static void InitializeMainLightShadowResolution(UniversalShadowData shadowData)
		{
		}

		private static UniversalPostProcessingData CreatePostProcessingData(ContextContainer frameData, UniversalRenderPipelineAsset settings)
		{
			return null;
		}

		private static UniversalResourceData CreateUniversalResourceData(ContextContainer frameData)
		{
			return null;
		}

		private static UniversalLightData CreateLightData(ContextContainer frameData, UniversalRenderPipelineAsset settings, NativeArray<VisibleLight> visibleLights, RenderingMode? renderingMode)
		{
			return null;
		}

		private static void ApplyTaaRenderingDebugOverrides(ref TemporalAA.Settings taaSettings)
		{
		}

		private static void UpdateTemporalAAData(UniversalCameraData cameraData, UniversalAdditionalCameraData additionalCameraData)
		{
		}

		private static void UpdateTemporalAATargets(UniversalCameraData cameraData)
		{
		}

		private static void UpdateCameraStereoMatrices(Camera camera, XRPass xr)
		{
		}

		private static PerObjectData GetPerObjectLightFlags(UniversalLightData universalLightData, UniversalRenderPipelineAsset settings, RenderingMode? renderingMode)
		{
			return default(PerObjectData);
		}

		private static int GetBrightestDirectionalLightIndex(UniversalRenderPipelineAsset settings, NativeArray<VisibleLight> visibleLights)
		{
			return 0;
		}

		private static int GetMainLightIndex(UniversalRenderPipelineAsset settings, NativeArray<VisibleLight> visibleLights)
		{
			return 0;
		}

		private void SetupPerFrameShaderConstants()
		{
		}

		private static void SetupPerCameraShaderConstants(CommandBuffer cmd)
		{
		}

		private static void CheckAndApplyDebugSettings(ref RenderingData renderingData)
		{
		}

		private static ImageUpscalingFilter ResolveUpscalingFilterSelection(Vector2 imageSize, float renderScale, UpscalingFilterSelection selection, bool enableRenderGraph)
		{
			return default(ImageUpscalingFilter);
		}

		internal static bool HDROutputForMainDisplayIsActive()
		{
			return false;
		}

		internal static bool HDROutputForAnyDisplayIsActive()
		{
			return false;
		}

		private void SetHDRState(List<Camera> cameras)
		{
		}

		internal static void GetHDROutputLuminanceParameters(HDROutputUtils.HDRDisplayInformation hdrDisplayInformation, ColorGamut hdrDisplayColorGamut, Tonemapping tonemapping, out Vector4 hdrOutputParameters)
		{
			hdrOutputParameters = default(Vector4);
		}

		internal static void GetHDROutputGradingParameters(Tonemapping tonemapping, out Vector4 hdrOutputParameters)
		{
			hdrOutputParameters = default(Vector4);
		}

		private static void ApplyAdaptivePerformance(UniversalCameraData cameraData)
		{
		}

		private static void ApplyAdaptivePerformance(ContextContainer frameData)
		{
		}

		private static AdditionalLightsShadowAtlasLayout BuildAdditionalLightsShadowAtlasLayout(UniversalLightData lightData, UniversalShadowData shadowData, UniversalCameraData cameraData)
		{
			return default(AdditionalLightsShadowAtlasLayout);
		}

		private static void AdjustUIOverlayOwnership(int cameraCount)
		{
		}

		private static void SetupScreenMSAASamplesState(int cameraCount)
		{
		}

		public static bool IsGameCamera(Camera camera)
		{
			return false;
		}

		private void SortCameras(List<Camera> cameras)
		{
		}

		private int GetLastBaseCameraIndex(List<Camera> cameras)
		{
			return 0;
		}

		internal static GraphicsFormat MakeRenderTextureGraphicsFormat(bool isHdrEnabled, HDRColorBufferPrecision requestHDRColorBufferPrecision, bool needsAlpha)
		{
			return default(GraphicsFormat);
		}

		internal static GraphicsFormat MakeUnormRenderTextureGraphicsFormat()
		{
			return default(GraphicsFormat);
		}

		internal static RenderTextureDescriptor CreateRenderTextureDescriptor(Camera camera, UniversalCameraData cameraData, bool isHdrEnabled, HDRColorBufferPrecision requestHDRColorBufferPrecision, int msaaSamples, bool needsAlpha, bool requiresOpaqueTexture)
		{
			return default(RenderTextureDescriptor);
		}

		public static void GetLightAttenuationAndSpotDirection(LightType lightType, float lightRange, Matrix4x4 lightLocalToWorldMatrix, float spotAngle, float? innerSpotAngle, out Vector4 lightAttenuation, out Vector4 lightSpotDir)
		{
			lightAttenuation = default(Vector4);
			lightSpotDir = default(Vector4);
		}

		internal static void GetPunctualLightDistanceAttenuation(float lightRange, ref Vector4 lightAttenuation)
		{
		}

		internal static void GetSpotAngleAttenuation(float spotAngle, float? innerSpotAngle, ref Vector4 lightAttenuation)
		{
		}

		internal static void GetSpotDirection(ref Matrix4x4 lightLocalToWorldMatrix, out Vector4 lightSpotDir)
		{
			lightSpotDir = default(Vector4);
		}

		public static void InitializeLightConstants_Common(NativeArray<VisibleLight> lights, int lightIndex, out Vector4 lightPos, out Vector4 lightColor, out Vector4 lightAttenuation, out Vector4 lightSpotDir, out Vector4 lightOcclusionProbeChannel)
		{
			lightPos = default(Vector4);
			lightColor = default(Vector4);
			lightAttenuation = default(Vector4);
			lightSpotDir = default(Vector4);
			lightOcclusionProbeChannel = default(Vector4);
		}

		private static void RecordAndExecuteRenderGraph(RenderGraph renderGraph, ScriptableRenderContext context, ScriptableRenderer renderer, CommandBuffer cmd, Camera camera, RenderTextureUVOriginStrategy uvOriginStrategy)
		{
		}
	}
}
