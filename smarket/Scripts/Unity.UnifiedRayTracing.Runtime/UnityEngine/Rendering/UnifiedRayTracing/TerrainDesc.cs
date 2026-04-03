namespace UnityEngine.Rendering.UnifiedRayTracing
{
	internal struct TerrainDesc
	{
		public Terrain terrain;

		public Matrix4x4 localToWorldMatrix;

		public uint mask;

		public uint renderingLayerMask;

		public uint materialID;

		public bool enableTriangleCulling;

		public bool frontTriangleCounterClockwise;

		public TerrainDesc(Terrain terrain)
		{
			this.terrain = null;
			localToWorldMatrix = default(Matrix4x4);
			mask = 0u;
			renderingLayerMask = 0u;
			materialID = 0u;
			enableTriangleCulling = false;
			frontTriangleCounterClockwise = false;
		}
	}
}
