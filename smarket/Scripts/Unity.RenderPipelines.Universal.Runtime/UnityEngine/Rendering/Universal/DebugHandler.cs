using System.Diagnostics;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal
{
	internal class DebugHandler : IDebugDisplaySettingsQuery
	{
		private class DebugFinalValidationPassData
		{
			public bool isFinalPass;

			public bool resolveFinalTarget;

			public bool isActiveForCamera;

			public bool hasDebugRenderTarget;

			public TextureHandle debugRenderTargetHandle;

			public int debugTexturePropertyId;

			public Vector4 debugRenderTargetPixelRect;

			public int debugRenderTargetSupportsStereo;

			public Vector4 debugRenderTargetRangeRemap;

			public TextureHandle debugFontTextureHandle;

			public DebugDisplaySettingsRendering renderingSettings;
		}

		private class DebugSetupPassData
		{
			public bool isActiveForCamera;

			public DebugDisplaySettingsMaterial materialSettings;

			public DebugDisplaySettingsRendering renderingSettings;

			public DebugDisplaySettingsLighting lightingSettings;
		}

		private static readonly int k_DebugColorInvalidModePropertyId;

		private static readonly int k_DebugCurrentRealTimeId;

		private static readonly int k_DebugColorPropertyId;

		private static readonly int k_DebugTexturePropertyId;

		private static readonly int k_DebugFontId;

		private static readonly int k_DebugTextureNoStereoPropertyId;

		private static readonly int k_DebugTextureDisplayRect;

		private static readonly int k_DebugRenderTargetSupportsStereo;

		private static readonly int k_DebugRenderTargetRangeRemap;

		private static readonly int k_DebugMaterialModeId;

		private static readonly int k_DebugVertexAttributeModeId;

		private static readonly int k_DebugMaterialValidationModeId;

		private static readonly int k_DebugMipInfoModeId;

		private static readonly int k_DebugMipMapStatusModeId;

		private static readonly int k_DebugMipMapShowStatusCodeId;

		private static readonly int k_DebugMipMapOpacityId;

		private static readonly int k_DebugMipMapRecentlyUpdatedCooldownId;

		private static readonly int k_DebugMipMapTerrainTextureModeId;

		private static readonly int k_DebugSceneOverrideModeId;

		private static readonly int k_DebugFullScreenModeId;

		private static readonly int k_DebugValidationModeId;

		private static readonly int k_DebugValidateBelowMinThresholdColorPropertyId;

		private static readonly int k_DebugValidateAboveMaxThresholdColorPropertyId;

		private static readonly int k_DebugMaxPixelCost;

		private static readonly int k_DebugLightingModeId;

		private static readonly int k_DebugLightingFeatureFlagsId;

		private static readonly int k_DebugValidateAlbedoMinLuminanceId;

		private static readonly int k_DebugValidateAlbedoMaxLuminanceId;

		private static readonly int k_DebugValidateAlbedoSaturationToleranceId;

		private static readonly int k_DebugValidateAlbedoHueToleranceId;

		private static readonly int k_DebugValidateAlbedoCompareColorId;

		private static readonly int k_DebugValidateMetallicMinValueId;

		private static readonly int k_DebugValidateMetallicMaxValueId;

		private static readonly int k_ValidationChannelsId;

		private static readonly int k_RangeMinimumId;

		private static readonly int k_RangeMaximumId;

		private static readonly ProfilingSampler s_DebugSetupSampler;

		private static readonly ProfilingSampler s_DebugFinalValidationSampler;

		private DebugSetupPassData s_DebugSetupPassData;

		private DebugFinalValidationPassData s_DebugFinalValidationPassData;

		private readonly Material m_ReplacementMaterial;

		private readonly Material m_HDRDebugViewMaterial;

		private HDRDebugViewPass m_HDRDebugViewPass;

		private RTHandle m_DebugScreenColorHandle;

		private RTHandle m_DebugScreenDepthHandle;

		private readonly UniversalRenderPipelineRuntimeTextures m_RuntimeTextures;

		private bool m_HasDebugRenderTarget;

		private bool m_DebugRenderTargetSupportsStereo;

		private Vector4 m_DebugRenderTargetPixelRect;

		private Vector4 m_DebugRenderTargetRangeRemap;

		private RTHandle m_DebugRenderTarget;

		private RTHandle m_DebugFontTexture;

		private GraphicsBuffer m_debugDisplayConstant;

		private readonly UniversalRenderPipelineDebugDisplaySettings m_DebugDisplaySettings;

		private DebugDisplaySettingsLighting LightingSettings => null;

		private DebugDisplaySettingsMaterial MaterialSettings => null;

		private DebugDisplaySettingsRendering RenderingSettings => null;

		public bool AreAnySettingsActive => false;

		public bool IsPostProcessingAllowed => false;

		public bool IsLightingActive => false;

		internal bool IsActiveModeUnsupportedForDeferred => false;

		internal Material ReplacementMaterial => null;

		internal UniversalRenderPipelineDebugDisplaySettings DebugDisplaySettings => null;

		internal ref RTHandle DebugScreenColorHandle
		{
			get
			{
				throw null;
			}
		}

		internal ref RTHandle DebugScreenDepthHandle
		{
			get
			{
				throw null;
			}
		}

		internal HDRDebugViewPass hdrDebugViewPass => null;

		internal bool IsScreenClearNeeded => false;

		internal bool IsRenderPassSupported => false;

		internal bool IsDepthPrimingCompatible => false;

		internal int stpDebugViewIndex => 0;

		public bool TryGetScreenClearColor(ref Color color)
		{
			return false;
		}

		internal bool HDRDebugViewIsActive(bool resolveFinalTarget)
		{
			return false;
		}

		internal bool WriteToDebugScreenTexture(bool resolveFinalTarget)
		{
			return false;
		}

		internal DebugHandler()
		{
		}

		public void Dispose()
		{
		}

		internal bool IsActiveForCamera(bool isPreviewCamera)
		{
			return false;
		}

		internal bool TryGetFullscreenDebugMode(out DebugFullScreenMode debugFullScreenMode)
		{
			debugFullScreenMode = default(DebugFullScreenMode);
			return false;
		}

		internal bool TryGetFullscreenDebugMode(out DebugFullScreenMode debugFullScreenMode, out int textureHeightPercent)
		{
			debugFullScreenMode = default(DebugFullScreenMode);
			textureHeightPercent = default(int);
			return false;
		}

		internal static void ConfigureColorDescriptorForDebugScreen(ref RenderTextureDescriptor descriptor, int cameraWidth, int cameraHeight)
		{
		}

		internal static void ConfigureDepthDescriptorForDebugScreen(ref RenderTextureDescriptor descriptor, GraphicsFormat depthStencilFormat, int cameraWidth, int cameraHeight)
		{
		}

		[Conditional("DEVELOPMENT_BUILD")]
		[Conditional("UNITY_EDITOR")]
		internal void SetupShaderProperties(RasterCommandBuffer cmd, int passIndex = 0)
		{
		}

		internal void SetDebugRenderTarget(RTHandle renderTarget, Rect displayRect, bool supportsStereo, Vector4 dataRangeRemap)
		{
		}

		internal void ResetDebugRenderTarget()
		{
		}

		private DebugFinalValidationPassData InitDebugFinalValidationPassData(DebugFinalValidationPassData passData, UniversalCameraData cameraData, bool isFinalPass)
		{
			return null;
		}

		private static void UpdateShaderGlobalPropertiesForFinalValidationPass(RasterCommandBuffer cmd, DebugFinalValidationPassData data)
		{
		}

		[Conditional("DEVELOPMENT_BUILD")]
		[Conditional("UNITY_EDITOR")]
		internal void UpdateShaderGlobalPropertiesForFinalValidationPass(CommandBuffer cmd, UniversalCameraData cameraData, bool isFinalPass)
		{
		}

		[Conditional("DEVELOPMENT_BUILD")]
		[Conditional("UNITY_EDITOR")]
		internal void UpdateShaderGlobalPropertiesForFinalValidationPass(RenderGraph renderGraph, UniversalCameraData cameraData, bool isFinalPass)
		{
		}

		private DebugSetupPassData InitDebugSetupPassData(DebugSetupPassData passData, bool isPreviewCamera)
		{
			return null;
		}

		[Conditional("DEVELOPMENT_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private static void Setup(RasterCommandBuffer cmd, DebugSetupPassData passData)
		{
		}

		[Conditional("DEVELOPMENT_BUILD")]
		[Conditional("UNITY_EDITOR")]
		internal void Setup(CommandBuffer cmd, bool isPreviewCamera)
		{
		}

		[Conditional("DEVELOPMENT_BUILD")]
		[Conditional("UNITY_EDITOR")]
		internal void Setup(RenderGraph renderGraph, bool isPreviewCamera)
		{
		}

		[Conditional("DEVELOPMENT_BUILD")]
		[Conditional("UNITY_EDITOR")]
		internal void Render(RenderGraph renderGraph, UniversalCameraData cameraData, TextureHandle srcColor, TextureHandle overlayTexture, TextureHandle dstColor)
		{
		}

		internal DebugRendererLists CreateRendererListsWithDebugRenderState(ScriptableRenderContext context, ref CullingResults cullResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ref RenderStateBlock renderStateBlock)
		{
			return null;
		}

		internal DebugRendererLists CreateRendererListsWithDebugRenderState(RenderGraph renderGraph, ref CullingResults cullResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ref RenderStateBlock renderStateBlock)
		{
			return null;
		}
	}
}
