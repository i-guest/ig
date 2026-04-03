using Unity.Collections;

namespace UnityEngine.Rendering.Universal
{
	public class UniversalLightData : ContextItem
	{
		public int mainLightIndex;

		public int additionalLightsCount;

		public int maxPerObjectAdditionalLightsCount;

		public NativeArray<VisibleLight> visibleLights;

		public bool shadeAdditionalLightsPerVertex;

		public bool supportsMixedLighting;

		public bool reflectionProbeBoxProjection;

		public bool reflectionProbeBlending;

		public bool reflectionProbeAtlas;

		public bool supportsLightLayers;

		public bool supportsAdditionalLights;

		public override void Reset()
		{
		}
	}
}
