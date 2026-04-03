namespace UnityEngine.Rendering.UnifiedRayTracing
{
	public struct MeshInstanceDesc
	{
		public Mesh mesh;

		public int subMeshIndex;

		public Matrix4x4 localToWorldMatrix;

		public uint mask;

		public uint instanceID;

		public bool enableTriangleCulling;

		public bool frontTriangleCounterClockwise;

		public bool opaqueGeometry;

		public MeshInstanceDesc(Mesh mesh, int subMeshIndex = 0)
		{
			this.mesh = null;
			this.subMeshIndex = 0;
			localToWorldMatrix = default(Matrix4x4);
			mask = 0u;
			instanceID = 0u;
			enableTriangleCulling = false;
			frontTriangleCounterClockwise = false;
			opaqueGeometry = false;
		}
	}
}
