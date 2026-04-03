using Unity.Collections;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal.Internal
{
	internal class DeferredLights
	{
		internal static class ShaderConstants
		{
			public static readonly int _LitStencilRef;

			public static readonly int _LitStencilReadMask;

			public static readonly int _LitStencilWriteMask;

			public static readonly int _SimpleLitStencilRef;

			public static readonly int _SimpleLitStencilReadMask;

			public static readonly int _SimpleLitStencilWriteMask;

			public static readonly int _StencilRef;

			public static readonly int _StencilReadMask;

			public static readonly int _StencilWriteMask;

			public static readonly int _LitPunctualStencilRef;

			public static readonly int _LitPunctualStencilReadMask;

			public static readonly int _LitPunctualStencilWriteMask;

			public static readonly int _SimpleLitPunctualStencilRef;

			public static readonly int _SimpleLitPunctualStencilReadMask;

			public static readonly int _SimpleLitPunctualStencilWriteMask;

			public static readonly int _LitDirStencilRef;

			public static readonly int _LitDirStencilReadMask;

			public static readonly int _LitDirStencilWriteMask;

			public static readonly int _SimpleLitDirStencilRef;

			public static readonly int _SimpleLitDirStencilReadMask;

			public static readonly int _SimpleLitDirStencilWriteMask;

			public static readonly int _ScreenToWorld;

			public static int _MainLightPosition;

			public static int _MainLightColor;

			public static int _MainLightLayerMask;

			public static int _SpotLightScale;

			public static int _SpotLightBias;

			public static int _SpotLightGuard;

			public static int _LightPosWS;

			public static int _LightColor;

			public static int _LightAttenuation;

			public static int _LightOcclusionProbInfo;

			public static int _LightDirection;

			public static int _LightFlags;

			public static int _ShadowLightIndex;

			public static int _LightLayerMask;

			public static int _CookieLightIndex;
		}

		internal enum StencilDeferredPasses
		{
			StencilVolume = 0,
			PunctualLit = 1,
			PunctualSimpleLit = 2,
			DirectionalLit = 3,
			DirectionalSimpleLit = 4,
			Fog = 5,
			SSAOOnly = 6
		}

		internal enum ClusterDeferredPasses
		{
			ClusteredLightsLit = 0,
			ClusteredLightsSimpleLit = 1,
			Fog = 2
		}

		internal struct InitParams
		{
			public Material stencilDeferredMaterial;

			public Material clusterDeferredMaterial;

			public LightCookieManager lightCookieManager;

			public bool deferredPlus;
		}

		private class SetupLightPassData
		{
			internal UniversalCameraData cameraData;

			internal UniversalLightData lightData;

			internal DeferredLights deferredLights;

			internal Vector2Int cameraTargetSizeCopy;
		}

		internal static readonly string[] k_GBufferNames;

		internal static readonly int[] k_GBufferShaderPropertyIDs;

		private static readonly string[] k_StencilDeferredPassNames;

		private static readonly string[] k_ClusterDeferredPassNames;

		private static readonly ushort k_InvalidLightOffset;

		private static readonly string k_SetupLights;

		private static readonly string k_DeferredPass;

		private static readonly string k_DeferredShadingPass;

		private static readonly string k_DeferredStencilPass;

		private static readonly string k_DeferredFogPass;

		private static readonly string k_SetupLightConstants;

		private static readonly float kStencilShapeGuard;

		private static readonly ProfilingSampler m_ProfilingSetupLights;

		private static readonly ProfilingSampler m_ProfilingDeferredPass;

		private static readonly ProfilingSampler m_ProfilingSetupLightConstants;

		private RTHandle[] GbufferRTHandles;

		private NativeArray<ushort> m_stencilVisLights;

		private NativeArray<ushort> m_stencilVisLightOffsets;

		private AdditionalLightsShadowCasterPass m_AdditionalLightsShadowCasterPass;

		private Mesh m_SphereMesh;

		private Mesh m_HemisphereMesh;

		private Mesh m_FullscreenMesh;

		private Material m_StencilDeferredMaterial;

		private Material m_ClusterDeferredMaterial;

		private int[] m_StencilDeferredPasses;

		private int[] m_ClusterDeferredPasses;

		private Matrix4x4[] m_ScreenToWorld;

		private ProfilingSampler m_ProfilingSamplerDeferredShadingPass;

		private ProfilingSampler m_ProfilingSamplerDeferredStencilPass;

		private ProfilingSampler m_ProfilingSamplerDeferredFogPass;

		private LightCookieManager m_LightCookieManager;

		private bool m_UseDeferredPlus;

		private static ProfilingSampler s_SetupDeferredLights;

		internal int GBufferAlbedoIndex => 0;

		internal int GBufferSpecularMetallicIndex => 0;

		internal int GBufferNormalSmoothnessIndex => 0;

		internal int GBufferLightingIndex => 0;

		internal int GbufferDepthIndex => 0;

		internal int GBufferRenderingLayers => 0;

		internal int GBufferShadowMask => 0;

		internal int GBufferSliceCount => 0;

		internal int GBufferInputAttachmentCount => 0;

		internal bool UseShadowMask => false;

		internal bool UseRenderingLayers => false;

		internal RenderingLayerUtils.MaskSize RenderingLayerMaskSize { get; set; }

		internal bool UseDecalLayers { get; set; }

		internal bool UseLightLayers => false;

		internal bool UseFramebufferFetch { get; set; }

		internal bool HasDepthPrepass { get; set; }

		internal bool HasNormalPrepass { get; set; }

		internal bool HasRenderingLayerPrepass { get; set; }

		internal bool AccurateGbufferNormals { get; set; }

		internal MixedLightingSetup MixedLightingSetup { get; set; }

		internal bool UseJobSystem { get; set; }

		internal int RenderWidth { get; set; }

		internal int RenderHeight { get; set; }

		internal RTHandle[] GbufferAttachments { get; set; }

		internal TextureHandle[] GbufferTextureHandles { get; set; }

		internal RTHandle[] DeferredInputAttachments { get; set; }

		internal bool[] DeferredInputIsTransient { get; set; }

		internal RTHandle DepthAttachment { get; set; }

		internal RTHandle DepthCopyTexture { get; set; }

		internal GraphicsFormat[] GbufferFormats { get; set; }

		internal RTHandle DepthAttachmentHandle { get; set; }

		internal GraphicsFormat GetGBufferFormat(int index)
		{
			return default(GraphicsFormat);
		}

		internal DeferredLights(InitParams initParams, bool useNativeRenderPass = false)
		{
		}

		internal void SetupRenderGraphLights(RenderGraph renderGraph, UniversalCameraData cameraData, UniversalLightData lightData)
		{
		}

		internal void SetupLights(CommandBuffer cmd, UniversalCameraData cameraData, Vector2Int cameraTargetSizeCopy, UniversalLightData lightData, bool isRenderGraph = false)
		{
		}

		internal void ResolveMixedLightingMode(UniversalLightData lightData)
		{
		}

		internal void DisableFramebufferFetchInput()
		{
		}

		internal void ReleaseGbufferResources()
		{
		}

		internal void ReAllocateGBufferIfNeeded(RenderTextureDescriptor gbufferSlice, int gbufferIndex)
		{
		}

		internal void CreateGbufferResources()
		{
		}

		internal void CreateGbufferResourcesRenderGraph(RenderGraph renderGraph, UniversalResourceData resourceData)
		{
		}

		internal void UpdateDeferredInputAttachments()
		{
		}

		internal bool IsRuntimeSupportedThisFrame()
		{
			return false;
		}

		public void Setup(AdditionalLightsShadowCasterPass additionalLightsShadowCasterPass, bool hasDepthPrepass, bool hasNormalPrepass, bool hasRenderingLayerPrepass, RTHandle depthCopyTexture, RTHandle depthAttachment, RTHandle colorAttachment)
		{
		}

		internal void Setup(AdditionalLightsShadowCasterPass additionalLightsShadowCasterPass)
		{
		}

		public void OnCameraCleanup(CommandBuffer cmd)
		{
		}

		internal static StencilState OverwriteStencil(StencilState s, int stencilWriteMask)
		{
			return default(StencilState);
		}

		internal static RenderStateBlock OverwriteStencil(RenderStateBlock block, int stencilWriteMask, int stencilRef)
		{
			return default(RenderStateBlock);
		}

		internal void ExecuteDeferredPass(RasterCommandBuffer cmd, UniversalCameraData cameraData, UniversalLightData lightData, UniversalShadowData shadowData)
		{
		}

		private void SetupShaderLightConstants(CommandBuffer cmd, UniversalLightData lightData)
		{
		}

		private void SetupMainLightConstants(CommandBuffer cmd, UniversalLightData lightData)
		{
		}

		internal Matrix4x4[] GetScreenToWorldMatrix(UniversalCameraData cameraData)
		{
			return null;
		}

		private void SetupMatrixConstants(RasterCommandBuffer cmd, UniversalCameraData cameraData)
		{
		}

		private void PrecomputeLights(out NativeArray<ushort> stencilVisLights, out NativeArray<ushort> stencilVisLightOffsets, ref NativeArray<VisibleLight> visibleLights, bool hasAdditionalLights)
		{
			stencilVisLights = default(NativeArray<ushort>);
			stencilVisLightOffsets = default(NativeArray<ushort>);
		}

		private bool HasStencilLightsOfType(LightType type)
		{
			return false;
		}

		private void RenderClusterLights(RasterCommandBuffer cmd, UniversalShadowData shadowData)
		{
		}

		private void RenderStencilLights(RasterCommandBuffer cmd, UniversalLightData lightData, UniversalShadowData shadowData, bool stripShadowsOffVariants)
		{
		}

		private void RenderStencilDirectionalLights(RasterCommandBuffer cmd, bool stripShadowsOffVariants, UniversalLightData lightData, UniversalShadowData shadowData, NativeArray<VisibleLight> visibleLights, bool hasAdditionalLightPass, bool hasLightCookieManager, int mainLightIndex)
		{
		}

		private void RenderStencilPointLights(RasterCommandBuffer cmd, bool stripShadowsOffVariants, UniversalLightData lightData, UniversalShadowData shadowData, NativeArray<VisibleLight> visibleLights, bool hasAdditionalLightPass, bool hasLightCookieManager)
		{
		}

		private void RenderStencilSpotLights(RasterCommandBuffer cmd, bool stripShadowsOffVariants, UniversalLightData lightData, UniversalShadowData shadowData, NativeArray<VisibleLight> visibleLights, bool hasAdditionalLightPass, bool hasLightCookieManager)
		{
		}

		private void RenderSSAOBeforeShading(RasterCommandBuffer cmd)
		{
		}

		private void RenderFog(RasterCommandBuffer cmd, bool isOrthographic)
		{
		}

		private void InitStencilDeferredMaterial()
		{
		}

		private void InitClusterDeferredMaterial()
		{
		}

		private static Mesh CreateSphereMesh()
		{
			return null;
		}

		private static Mesh CreateHemisphereMesh()
		{
			return null;
		}

		private static Mesh CreateFullscreenMesh()
		{
			return null;
		}

		private void SetRenderingLayersMask(RasterCommandBuffer cmd, Light light, int shaderPropertyID)
		{
		}

		private void SetAdditionalLightsShadowsKeyword(ref RasterCommandBuffer cmd, bool stripShadowsOffVariants, bool additionalLightShadowsEnabled, bool hasDeferredShadows, bool shouldOverride, ref bool lastShadowsKeyword)
		{
		}

		private void SetSoftShadowsKeyword(RasterCommandBuffer cmd, UniversalShadowData shadowData, Light light, bool hasDeferredShadows, bool shouldOverride, ref bool lastHasSoftShadow)
		{
		}

		private void SetLightCookiesKeyword(RasterCommandBuffer cmd, int visLightIndex, bool hasLightCookieManager, bool shouldOverride, ref bool lastLightCookieState, ref int lastCookieLightIndex)
		{
		}
	}
}
