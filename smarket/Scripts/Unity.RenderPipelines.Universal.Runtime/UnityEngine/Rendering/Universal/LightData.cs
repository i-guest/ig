using Unity.Collections;

namespace UnityEngine.Rendering.Universal
{
	public struct LightData
	{
		private ContextContainer frameData;

		internal UniversalLightData universalLightData => null;

		public ref int mainLightIndex
		{
			get
			{
				throw null;
			}
		}

		public ref int additionalLightsCount
		{
			get
			{
				throw null;
			}
		}

		public ref int maxPerObjectAdditionalLightsCount
		{
			get
			{
				throw null;
			}
		}

		public ref NativeArray<VisibleLight> visibleLights
		{
			get
			{
				throw null;
			}
		}

		public ref bool shadeAdditionalLightsPerVertex
		{
			get
			{
				throw null;
			}
		}

		public ref bool supportsMixedLighting
		{
			get
			{
				throw null;
			}
		}

		public ref bool reflectionProbeBoxProjection
		{
			get
			{
				throw null;
			}
		}

		public ref bool reflectionProbeBlending
		{
			get
			{
				throw null;
			}
		}

		public ref bool reflectionProbeAtlas
		{
			get
			{
				throw null;
			}
		}

		public ref bool supportsLightLayers
		{
			get
			{
				throw null;
			}
		}

		public ref bool supportsAdditionalLights
		{
			get
			{
				throw null;
			}
		}

		internal LightData(ContextContainer frameData)
		{
			this.frameData = null;
		}
	}
}
