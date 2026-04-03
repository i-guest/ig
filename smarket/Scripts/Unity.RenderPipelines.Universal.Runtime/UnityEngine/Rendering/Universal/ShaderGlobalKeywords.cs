namespace UnityEngine.Rendering.Universal
{
	internal static class ShaderGlobalKeywords
	{
		public static GlobalKeyword MainLightShadows;

		public static GlobalKeyword MainLightShadowCascades;

		public static GlobalKeyword MainLightShadowScreen;

		public static GlobalKeyword CastingPunctualLightShadow;

		public static GlobalKeyword AdditionalLightsVertex;

		public static GlobalKeyword AdditionalLightsPixel;

		public static GlobalKeyword ClusterLightLoop;

		public static GlobalKeyword AdditionalLightShadows;

		public static GlobalKeyword ReflectionProbeBoxProjection;

		public static GlobalKeyword ReflectionProbeBlending;

		public static GlobalKeyword ReflectionProbeAtlas;

		public static GlobalKeyword ReflectionProbeRotation;

		public static GlobalKeyword SoftShadows;

		public static GlobalKeyword SoftShadowsLow;

		public static GlobalKeyword SoftShadowsMedium;

		public static GlobalKeyword SoftShadowsHigh;

		public static GlobalKeyword MixedLightingSubtractive;

		public static GlobalKeyword LightmapShadowMixing;

		public static GlobalKeyword ShadowsShadowMask;

		public static GlobalKeyword LightLayers;

		public static GlobalKeyword RenderPassEnabled;

		public static GlobalKeyword BillboardFaceCameraPos;

		public static GlobalKeyword LightCookies;

		public static GlobalKeyword DepthNoMsaa;

		public static GlobalKeyword DepthMsaa2;

		public static GlobalKeyword DepthMsaa4;

		public static GlobalKeyword DepthMsaa8;

		public static GlobalKeyword DBufferMRT1;

		public static GlobalKeyword DBufferMRT2;

		public static GlobalKeyword DBufferMRT3;

		public static GlobalKeyword DecalNormalBlendLow;

		public static GlobalKeyword DecalNormalBlendMedium;

		public static GlobalKeyword DecalNormalBlendHigh;

		public static GlobalKeyword DecalLayers;

		public static GlobalKeyword WriteRenderingLayers;

		public static GlobalKeyword ScreenSpaceOcclusion;

		public static GlobalKeyword ScreenSpaceIrradiance;

		public static GlobalKeyword _SPOT;

		public static GlobalKeyword _DIRECTIONAL;

		public static GlobalKeyword _POINT;

		public static GlobalKeyword _DEFERRED_STENCIL;

		public static GlobalKeyword _DEFERRED_FIRST_LIGHT;

		public static GlobalKeyword _DEFERRED_MAIN_LIGHT;

		public static GlobalKeyword _GBUFFER_NORMALS_OCT;

		public static GlobalKeyword _DEFERRED_MIXED_LIGHTING;

		public static GlobalKeyword LIGHTMAP_ON;

		public static GlobalKeyword DYNAMICLIGHTMAP_ON;

		public static GlobalKeyword _ALPHATEST_ON;

		public static GlobalKeyword DIRLIGHTMAP_COMBINED;

		public static GlobalKeyword _DETAIL_MULX2;

		public static GlobalKeyword _DETAIL_SCALED;

		public static GlobalKeyword _CLEARCOAT;

		public static GlobalKeyword _CLEARCOATMAP;

		public static GlobalKeyword DEBUG_DISPLAY;

		public static GlobalKeyword LOD_FADE_CROSSFADE;

		public static GlobalKeyword USE_UNITY_CROSSFADE;

		public static GlobalKeyword _EMISSION;

		public static GlobalKeyword _RECEIVE_SHADOWS_OFF;

		public static GlobalKeyword _SURFACE_TYPE_TRANSPARENT;

		public static GlobalKeyword _ALPHAPREMULTIPLY_ON;

		public static GlobalKeyword _ALPHAMODULATE_ON;

		public static GlobalKeyword _NORMALMAP;

		public static GlobalKeyword _ADD_PRECOMPUTED_VELOCITY;

		public static GlobalKeyword EDITOR_VISUALIZATION;

		public static GlobalKeyword FoveatedRenderingNonUniformRaster;

		public static GlobalKeyword DisableTexture2DXArray;

		public static GlobalKeyword BlitSingleSlice;

		public static GlobalKeyword XROcclusionMeshCombined;

		public static GlobalKeyword SCREEN_COORD_OVERRIDE;

		public static GlobalKeyword DOWNSAMPLING_SIZE_2;

		public static GlobalKeyword DOWNSAMPLING_SIZE_4;

		public static GlobalKeyword DOWNSAMPLING_SIZE_8;

		public static GlobalKeyword DOWNSAMPLING_SIZE_16;

		public static GlobalKeyword EVALUATE_SH_MIXED;

		public static GlobalKeyword EVALUATE_SH_VERTEX;

		public static GlobalKeyword ProbeVolumeL1;

		public static GlobalKeyword ProbeVolumeL2;

		public static GlobalKeyword LIGHTMAP_BICUBIC_SAMPLING;

		public static GlobalKeyword _OUTPUT_DEPTH;

		public static GlobalKeyword LinearToSRGBConversion;

		public static GlobalKeyword _ENABLE_ALPHA_OUTPUT;

		public static GlobalKeyword ForwardPlus;

		public static void InitializeShaderGlobalKeywords()
		{
		}
	}
}
