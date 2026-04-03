using System.Collections.Generic;
using Unity.Collections;

namespace UnityEngine.Rendering.Universal
{
	public struct ShadowData
	{
		private ContextContainer frameData;

		internal UniversalShadowData universalShadowData => null;

		public ref bool supportsMainLightShadows
		{
			get
			{
				throw null;
			}
		}

		internal ref bool mainLightShadowsEnabled
		{
			get
			{
				throw null;
			}
		}

		public ref int mainLightShadowmapWidth
		{
			get
			{
				throw null;
			}
		}

		public ref int mainLightShadowmapHeight
		{
			get
			{
				throw null;
			}
		}

		public ref int mainLightShadowCascadesCount
		{
			get
			{
				throw null;
			}
		}

		public ref Vector3 mainLightShadowCascadesSplit
		{
			get
			{
				throw null;
			}
		}

		public ref float mainLightShadowCascadeBorder
		{
			get
			{
				throw null;
			}
		}

		public ref bool supportsAdditionalLightShadows
		{
			get
			{
				throw null;
			}
		}

		internal ref bool additionalLightShadowsEnabled
		{
			get
			{
				throw null;
			}
		}

		public ref int additionalLightsShadowmapWidth
		{
			get
			{
				throw null;
			}
		}

		public ref int additionalLightsShadowmapHeight
		{
			get
			{
				throw null;
			}
		}

		public ref bool supportsSoftShadows
		{
			get
			{
				throw null;
			}
		}

		public ref int shadowmapDepthBufferBits
		{
			get
			{
				throw null;
			}
		}

		public ref List<Vector4> bias
		{
			get
			{
				throw null;
			}
		}

		public ref List<int> resolution
		{
			get
			{
				throw null;
			}
		}

		internal ref bool isKeywordAdditionalLightShadowsEnabled
		{
			get
			{
				throw null;
			}
		}

		internal ref bool isKeywordSoftShadowsEnabled
		{
			get
			{
				throw null;
			}
		}

		internal ref int mainLightShadowResolution
		{
			get
			{
				throw null;
			}
		}

		internal ref int mainLightRenderTargetWidth
		{
			get
			{
				throw null;
			}
		}

		internal ref int mainLightRenderTargetHeight
		{
			get
			{
				throw null;
			}
		}

		internal ref NativeArray<URPLightShadowCullingInfos> visibleLightsShadowCullingInfos
		{
			get
			{
				throw null;
			}
		}

		internal ref AdditionalLightsShadowAtlasLayout shadowAtlasLayout
		{
			get
			{
				throw null;
			}
		}

		internal ShadowData(ContextContainer frameData)
		{
			this.frameData = null;
		}
	}
}
