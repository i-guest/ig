namespace UnityEngine.Rendering.UnifiedRayTracing
{
	internal static class TerrainToMesh
	{
		private static AsyncTerrainToMeshRequest MakeAsyncTerrainToMeshRequest(int width, int height, Vector3 heightmapScale, float[,] heightmap, bool[,] holes)
		{
			return default(AsyncTerrainToMeshRequest);
		}

		public static AsyncTerrainToMeshRequest ConvertAsync(Terrain terrain)
		{
			return default(AsyncTerrainToMeshRequest);
		}

		public static AsyncTerrainToMeshRequest ConvertAsync(int heightmapWidth, int heightmapHeight, short[] heightmapData, Vector3 heightmapScale, int holeWidth, int holeHeight, byte[] holedata)
		{
			return default(AsyncTerrainToMeshRequest);
		}

		public static Mesh Convert(Terrain terrain)
		{
			return null;
		}

		public static Mesh Convert(int heightmapWidth, int heightmapHeight, short[] heightmapData, Vector3 heightmapScale, int holeWidth, int holeHeight, byte[] holedata)
		{
			return null;
		}
	}
}
