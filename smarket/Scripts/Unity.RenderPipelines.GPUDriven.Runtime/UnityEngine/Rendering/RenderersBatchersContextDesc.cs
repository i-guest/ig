namespace UnityEngine.Rendering
{
	internal struct RenderersBatchersContextDesc
	{
		public InstanceNumInfo instanceNumInfo;

		public bool supportDitheringCrossFade;

		public bool enableBoundingSpheresInstanceData;

		public float smallMeshScreenPercentage;

		public bool enableCullerDebugStats;

		public static RenderersBatchersContextDesc NewDefault()
		{
			return default(RenderersBatchersContextDesc);
		}
	}
}
