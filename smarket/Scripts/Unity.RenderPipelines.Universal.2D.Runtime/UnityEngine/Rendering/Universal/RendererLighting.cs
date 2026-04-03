using System.Collections.Generic;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering.Universal
{
	internal static class RendererLighting
	{
		private static readonly ProfilingSampler m_ProfilingSampler;

		private static readonly ShaderTagId k_NormalsRenderingPassName;

		public static readonly Color k_NormalClearColor;

		private static readonly string k_UsePointLightCookiesKeyword;

		private static readonly string k_LightQualityFastKeyword;

		private static readonly string k_UseNormalMap;

		private static readonly string k_UseShadowMap;

		private static readonly string k_UseAdditiveBlendingKeyword;

		private static readonly string k_UseVolumetric;

		private static readonly string[] k_UseBlendStyleKeywords;

		private static readonly int[] k_BlendFactorsPropIDs;

		private static readonly int[] k_MaskFilterPropIDs;

		private static readonly int[] k_InvertedFilterPropIDs;

		public static readonly string[] k_ShapeLightTextureIDs;

		private static GraphicsFormat s_RenderTextureFormatToUse;

		private static bool s_HasSetupRenderTextureFormatToUse;

		private static readonly int k_SrcBlendID;

		private static readonly int k_DstBlendID;

		private static readonly int k_CookieTexID;

		private static readonly int k_PointLightCookieTexID;

		private static readonly int k_L2DInvMatrix;

		private static readonly int k_L2DColor;

		private static readonly int k_L2DPosition;

		private static readonly int k_L2DFalloffIntensity;

		private static readonly int k_L2DFalloffDistance;

		private static readonly int k_L2DOuterAngle;

		private static readonly int k_L2DInnerAngle;

		private static readonly int k_L2DInnerRadiusMult;

		private static readonly int k_L2DVolumeOpacity;

		private static readonly int k_L2DShadowIntensity;

		private static readonly int k_L2DLightType;

		internal static LightBatch lightBatch;

		internal static GraphicsFormat GetRenderTextureFormat()
		{
			return default(GraphicsFormat);
		}

		public static void CreateNormalMapRenderTexture(this IRenderPass2D pass, RenderingData renderingData, CommandBuffer cmd, float renderScale)
		{
		}

		public static RenderTextureDescriptor GetBlendStyleRenderTextureDesc(this IRenderPass2D pass, RenderingData renderingData)
		{
			return default(RenderTextureDescriptor);
		}

		public static void CreateCameraSortingLayerRenderTexture(this IRenderPass2D pass, RenderingData renderingData, CommandBuffer cmd, Downsampling downsamplingMethod)
		{
		}

		internal static void EnableBlendStyle(IRasterCommandBuffer cmd, int blendStyleIndex, bool enabled)
		{
		}

		internal static void DisableAllKeywords(IRasterCommandBuffer cmd)
		{
		}

		internal static void GetTransparencySortingMode(Renderer2DData rendererData, Camera camera, ref SortingSettings sortingSettings)
		{
		}

		private static bool CanRenderLight(IRenderPass2D pass, Light2D light, int blendStyleIndex, int layerToRender, bool isVolume, bool hasShadows, ref Mesh lightMesh, ref Material lightMaterial)
		{
			return false;
		}

		internal static bool CanCastShadows(Light2D light, int layerToRender)
		{
			return false;
		}

		private static bool CanCastVolumetricShadows(Light2D light, int endLayerValue)
		{
			return false;
		}

		internal static void RenderLight(IRenderPass2D pass, CommandBuffer cmd, Light2D light, bool isVolume, int blendStyleIndex, int layerToRender, bool hasShadows, bool batchingSupported, ref int shadowLightCount)
		{
		}

		private static void RenderLightSet(IRenderPass2D pass, RenderingData renderingData, int blendStyleIndex, CommandBuffer cmd, ref LayerBatch layer, RenderTargetIdentifier renderTexture, List<Light2D> lights)
		{
		}

		public static void RenderLightVolumes(this IRenderPass2D pass, RenderingData renderingData, CommandBuffer cmd, ref LayerBatch layer, RenderTargetIdentifier renderTexture, RenderTargetIdentifier depthTexture, RenderBufferStoreAction intermediateStoreAction, RenderBufferStoreAction finalStoreAction, bool requiresRTInit, List<Light2D> lights)
		{
		}

		internal static void SetLightShaderGlobals(Renderer2DData rendererData, RasterCommandBuffer cmd)
		{
		}

		internal static void SetLightShaderGlobals(IRasterCommandBuffer cmd, Light2DBlendStyle[] lightBlendStyles, int[] blendStyleIndices)
		{
		}

		private static float GetNormalizedInnerRadius(Light2D light)
		{
			return 0f;
		}

		private static float GetNormalizedAngle(float angle)
		{
			return 0f;
		}

		private static void GetScaledLightInvMatrix(Light2D light, out Matrix4x4 retMatrix)
		{
			retMatrix = default(Matrix4x4);
		}

		internal static void SetPerLightShaderGlobals(IRasterCommandBuffer cmd, Light2D light, int slot, bool isVolumetric, bool hasShadows, bool batchingSupported)
		{
		}

		internal static void SetPerPointLightShaderGlobals(IRasterCommandBuffer cmd, Light2D light, int slot, bool batchingSupported)
		{
		}

		internal static bool SetCookieShaderGlobals(CommandBuffer cmd, Light2D light)
		{
			return false;
		}

		internal static void SetCookieShaderProperties(Light2D light, MaterialPropertyBlock properties)
		{
		}

		public static void ClearDirtyLighting(this IRenderPass2D pass, CommandBuffer cmd, uint blendStylesUsed)
		{
		}

		internal static void RenderNormals(this IRenderPass2D pass, ScriptableRenderContext context, RenderingData renderingData, DrawingSettings drawSettings, FilteringSettings filterSettings, RTHandle depthTarget, bool bFirstClear)
		{
		}

		public static void RenderLights(this IRenderPass2D pass, RenderingData renderingData, CommandBuffer cmd, ref LayerBatch layerBatch, ref RenderTextureDescriptor rtDesc)
		{
		}

		private static void SetBlendModes(Material material, BlendMode src, BlendMode dst)
		{
		}

		private static uint GetLightMaterialIndex(Light2D light, bool isVolume, bool useShadows)
		{
			return 0u;
		}

		private static Material CreateLightMaterial(Renderer2DData rendererData, Light2D light, bool isVolume, bool useShadows)
		{
			return null;
		}

		internal static Material GetLightMaterial(this Renderer2DData rendererData, Light2D light, bool isVolume, bool useShadows)
		{
			return null;
		}

		internal static short GetCameraSortingLayerBoundsIndex(this Renderer2DData rendererData)
		{
			return 0;
		}
	}
}
