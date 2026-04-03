using System;
using System.Collections.Generic;

namespace UnityEngine.Rendering.Universal
{
	public static class ShadowUtils
	{
		internal static readonly bool m_ForceShadowPointSampling;

		internal const int kMinimumPunctualLightHardShadowResolution = 8;

		internal const int kMinimumPunctualLightSoftShadowResolution = 16;

		static ShadowUtils()
		{
		}

		public static bool ExtractDirectionalLightMatrix(ref CullingResults cullResults, ref ShadowData shadowData, int shadowLightIndex, int cascadeIndex, int shadowmapWidth, int shadowmapHeight, int shadowResolution, float shadowNearPlane, out Vector4 cascadeSplitDistance, out ShadowSliceData shadowSliceData, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix)
		{
			cascadeSplitDistance = default(Vector4);
			shadowSliceData = default(ShadowSliceData);
			viewMatrix = default(Matrix4x4);
			projMatrix = default(Matrix4x4);
			return false;
		}

		public static bool ExtractDirectionalLightMatrix(ref CullingResults cullResults, ref ShadowData shadowData, int shadowLightIndex, int cascadeIndex, int shadowmapWidth, int shadowmapHeight, int shadowResolution, float shadowNearPlane, out Vector4 cascadeSplitDistance, out ShadowSliceData shadowSliceData)
		{
			cascadeSplitDistance = default(Vector4);
			shadowSliceData = default(ShadowSliceData);
			return false;
		}

		public static bool ExtractDirectionalLightMatrix(ref CullingResults cullResults, UniversalShadowData shadowData, int shadowLightIndex, int cascadeIndex, int shadowmapWidth, int shadowmapHeight, int shadowResolution, float shadowNearPlane, out Vector4 cascadeSplitDistance, out ShadowSliceData shadowSliceData)
		{
			cascadeSplitDistance = default(Vector4);
			shadowSliceData = default(ShadowSliceData);
			return false;
		}

		public static bool ExtractSpotLightMatrix(ref CullingResults cullResults, ref ShadowData shadowData, int shadowLightIndex, out Matrix4x4 shadowMatrix, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData splitData)
		{
			shadowMatrix = default(Matrix4x4);
			viewMatrix = default(Matrix4x4);
			projMatrix = default(Matrix4x4);
			splitData = default(ShadowSplitData);
			return false;
		}

		public static bool ExtractSpotLightMatrix(ref CullingResults cullResults, UniversalShadowData shadowData, int shadowLightIndex, out Matrix4x4 shadowMatrix, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData splitData)
		{
			shadowMatrix = default(Matrix4x4);
			viewMatrix = default(Matrix4x4);
			projMatrix = default(Matrix4x4);
			splitData = default(ShadowSplitData);
			return false;
		}

		public static bool ExtractPointLightMatrix(ref CullingResults cullResults, ref ShadowData shadowData, int shadowLightIndex, CubemapFace cubemapFace, float fovBias, out Matrix4x4 shadowMatrix, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData splitData)
		{
			shadowMatrix = default(Matrix4x4);
			viewMatrix = default(Matrix4x4);
			projMatrix = default(Matrix4x4);
			splitData = default(ShadowSplitData);
			return false;
		}

		public static bool ExtractPointLightMatrix(ref CullingResults cullResults, UniversalShadowData shadowData, int shadowLightIndex, CubemapFace cubemapFace, float fovBias, out Matrix4x4 shadowMatrix, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData splitData)
		{
			shadowMatrix = default(Matrix4x4);
			viewMatrix = default(Matrix4x4);
			projMatrix = default(Matrix4x4);
			splitData = default(ShadowSplitData);
			return false;
		}

		public static void RenderShadowSlice(CommandBuffer cmd, ref ScriptableRenderContext context, ref ShadowSliceData shadowSliceData, ref ShadowDrawingSettings settings, Matrix4x4 proj, Matrix4x4 view)
		{
		}

		internal static void RenderShadowSlice(RasterCommandBuffer cmd, ref ShadowSliceData shadowSliceData, ref RendererList shadowRendererList, Matrix4x4 proj, Matrix4x4 view)
		{
		}

		public static void RenderShadowSlice(CommandBuffer cmd, ref ScriptableRenderContext context, ref ShadowSliceData shadowSliceData, ref ShadowDrawingSettings settings)
		{
		}

		public static int GetMaxTileResolutionInAtlas(int atlasWidth, int atlasHeight, int tileCount)
		{
			return 0;
		}

		public static void ApplySliceTransform(ref ShadowSliceData shadowSliceData, int atlasWidth, int atlasHeight)
		{
		}

		public static Vector4 GetShadowBias(ref VisibleLight shadowLight, int shadowLightIndex, ref ShadowData shadowData, Matrix4x4 lightProjectionMatrix, float shadowResolution)
		{
			return default(Vector4);
		}

		public static Vector4 GetShadowBias(ref VisibleLight shadowLight, int shadowLightIndex, UniversalShadowData shadowData, Matrix4x4 lightProjectionMatrix, float shadowResolution)
		{
			return default(Vector4);
		}

		private static Vector4 GetShadowBias(ref VisibleLight shadowLight, int shadowLightIndex, List<Vector4> bias, bool supportsSoftShadows, Matrix4x4 lightProjectionMatrix, float shadowResolution)
		{
			return default(Vector4);
		}

		internal static void GetScaleAndBiasForLinearDistanceFade(float fadeDistance, float border, out float scale, out float bias)
		{
			scale = default(float);
			bias = default(float);
		}

		public static void SetupShadowCasterConstantBuffer(CommandBuffer cmd, ref VisibleLight shadowLight, Vector4 shadowBias)
		{
		}

		internal static void SetupShadowCasterConstantBuffer(RasterCommandBuffer cmd, ref VisibleLight shadowLight, Vector4 shadowBias)
		{
		}

		internal static void SetShadowBias(RasterCommandBuffer cmd, Vector4 shadowBias)
		{
		}

		internal static void SetLightDirection(RasterCommandBuffer cmd, Vector3 lightDirection)
		{
		}

		internal static void SetLightPosition(RasterCommandBuffer cmd, Vector3 lightPosition)
		{
		}

		internal static void SetCameraPosition(RasterCommandBuffer cmd, Vector3 worldSpaceCameraPos)
		{
		}

		internal static void SetWorldToCameraAndCameraToWorldMatrices(RasterCommandBuffer cmd, Matrix4x4 viewMatrix)
		{
		}

		private static RenderTextureDescriptor GetTemporaryShadowTextureDescriptor(int width, int height, int bits)
		{
			return default(RenderTextureDescriptor);
		}

		[Obsolete("Use AllocShadowRT or ShadowRTReAllocateIfNeeded. #from(2022.1) #breakingFrom(2023.1)", true)]
		public static RenderTexture GetTemporaryShadowTexture(int width, int height, int bits)
		{
			return null;
		}

		public static bool ShadowRTNeedsReAlloc(RTHandle handle, int width, int height, int bits, int anisoLevel, float mipMapBias, string name)
		{
			return false;
		}

		public static RTHandle AllocShadowRT(int width, int height, int bits, int anisoLevel, float mipMapBias, string name)
		{
			return null;
		}

		public static bool ShadowRTReAllocateIfNeeded(ref RTHandle handle, int width, int height, int bits, int anisoLevel = 1, float mipMapBias = 0f, string name = "")
		{
			return false;
		}

		private static Matrix4x4 GetShadowTransform(Matrix4x4 proj, Matrix4x4 view)
		{
			return default(Matrix4x4);
		}

		internal static float SoftShadowQualityToShaderProperty(Light light, bool softShadowsEnabled)
		{
			return 0f;
		}

		internal static bool SupportsPerLightSoftShadowQuality()
		{
			return false;
		}

		internal static void SetPerLightSoftShadowKeyword(RasterCommandBuffer cmd, bool hasSoftShadows)
		{
		}

		internal static void SetSoftShadowQualityShaderKeywords(RasterCommandBuffer cmd, UniversalShadowData shadowData)
		{
		}

		internal static bool IsValidShadowCastingLight(UniversalLightData lightData, int i)
		{
			return false;
		}

		internal static bool IsValidShadowCastingLight(UniversalLightData lightData, int i, LightType lightType, LightShadows lightShadows, float shadowStrength)
		{
			return false;
		}

		internal static int GetPunctualLightShadowSlicesCount(in LightType lightType)
		{
			return 0;
		}

		internal static bool FastApproximately(float a, float b)
		{
			return false;
		}

		internal static bool FastApproximately(Vector4 a, Vector4 b)
		{
			return false;
		}

		internal static int MinimalPunctualLightShadowResolution(bool softShadow)
		{
			return 0;
		}
	}
}
