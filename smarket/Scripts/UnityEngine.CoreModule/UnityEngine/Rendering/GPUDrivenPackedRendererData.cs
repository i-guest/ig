using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
	[UsedByNativeCode]
	internal struct GPUDrivenPackedRendererData
	{
		private uint data;

		public bool staticShadowCaster => false;

		public byte lodMask => 0;

		public ShadowCastingMode shadowCastingMode => default(ShadowCastingMode);

		public LightProbeUsage lightProbeUsage => default(LightProbeUsage);

		public MotionVectorGenerationMode motionVecGenMode => default(MotionVectorGenerationMode);

		public bool isPartOfStaticBatch => false;

		public bool hasTree => false;

		public bool smallMeshCulling => false;

		public GPUDrivenPackedRendererData()
		{
			data = 0u;
		}
	}
}
