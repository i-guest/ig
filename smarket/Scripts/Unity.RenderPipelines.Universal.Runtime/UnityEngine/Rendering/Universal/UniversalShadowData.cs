using System.Collections.Generic;
using Unity.Collections;

namespace UnityEngine.Rendering.Universal
{
	public class UniversalShadowData : ContextItem
	{
		public bool supportsMainLightShadows;

		internal bool mainLightShadowsEnabled;

		public int mainLightShadowmapWidth;

		public int mainLightShadowmapHeight;

		public int mainLightShadowCascadesCount;

		public Vector3 mainLightShadowCascadesSplit;

		public float mainLightShadowCascadeBorder;

		public bool supportsAdditionalLightShadows;

		internal bool additionalLightShadowsEnabled;

		public int additionalLightsShadowmapWidth;

		public int additionalLightsShadowmapHeight;

		public bool supportsSoftShadows;

		public int shadowmapDepthBufferBits;

		public List<Vector4> bias;

		public List<int> resolution;

		internal bool isKeywordAdditionalLightShadowsEnabled;

		internal bool isKeywordSoftShadowsEnabled;

		internal int mainLightShadowResolution;

		internal int mainLightRenderTargetWidth;

		internal int mainLightRenderTargetHeight;

		internal NativeArray<URPLightShadowCullingInfos> visibleLightsShadowCullingInfos;

		internal AdditionalLightsShadowAtlasLayout shadowAtlasLayout;

		public override void Reset()
		{
		}
	}
}
