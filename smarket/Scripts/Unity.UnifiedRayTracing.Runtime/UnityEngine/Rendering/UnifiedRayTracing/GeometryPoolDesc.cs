namespace UnityEngine.Rendering.UnifiedRayTracing
{
	internal struct GeometryPoolDesc
	{
		public int vertexPoolByteSize;

		public int indexPoolByteSize;

		public int meshChunkTablesByteSize;

		public static GeometryPoolDesc NewDefault()
		{
			return default(GeometryPoolDesc);
		}
	}
}
