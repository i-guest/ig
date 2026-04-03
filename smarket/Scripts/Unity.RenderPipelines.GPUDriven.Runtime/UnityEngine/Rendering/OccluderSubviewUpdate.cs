namespace UnityEngine.Rendering
{
	public struct OccluderSubviewUpdate
	{
		public int subviewIndex;

		public int depthSliceIndex;

		public Vector2Int depthOffset;

		public Matrix4x4 viewMatrix;

		public Matrix4x4 invViewMatrix;

		public Matrix4x4 gpuProjMatrix;

		public Vector3 viewOffsetWorldSpace;

		public OccluderSubviewUpdate(int subviewIndex)
		{
			this.subviewIndex = 0;
			depthSliceIndex = 0;
			depthOffset = default(Vector2Int);
			viewMatrix = default(Matrix4x4);
			invViewMatrix = default(Matrix4x4);
			gpuProjMatrix = default(Matrix4x4);
			viewOffsetWorldSpace = default(Vector3);
		}
	}
}
