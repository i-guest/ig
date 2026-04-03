using Unity.Collections;

namespace UnityEngine.Rendering.Universal
{
	internal static class ShadowCulling
	{
		private static readonly ProfilingSampler computeShadowCasterCullingInfosMarker;

		public static NativeArray<URPLightShadowCullingInfos> CullShadowCasters(ref ScriptableRenderContext context, UniversalShadowData shadowData, ref AdditionalLightsShadowAtlasLayout shadowAtlasLayout, ref CullingResults cullResults)
		{
			return default(NativeArray<URPLightShadowCullingInfos>);
		}

		private static void ComputeShadowCasterCullingInfos(UniversalShadowData shadowData, ref AdditionalLightsShadowAtlasLayout shadowAtlasLayout, ref CullingResults cullingResults, out ShadowCastersCullingInfos shadowCullingInfos, out NativeArray<URPLightShadowCullingInfos> urpVisibleLightsShadowCullingInfos)
		{
			shadowCullingInfos = default(ShadowCastersCullingInfos);
			urpVisibleLightsShadowCullingInfos = default(NativeArray<URPLightShadowCullingInfos>);
		}

		private static BatchCullingProjectionType GetCullingProjectionType(LightType type)
		{
			return default(BatchCullingProjectionType);
		}
	}
}
