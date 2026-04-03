using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

namespace UnityEngine.Rendering.UnifiedRayTracing
{
	[BurstCompile]
	internal struct ComputeTerrainMeshJob : IJobParallelFor
	{
		[ReadOnly]
		public NativeArray<float> heightmap;

		[ReadOnly]
		public NativeArray<bool> holes;

		public int width;

		public int height;

		public float3 heightmapScale;

		public NativeArray<float3> positions;

		public NativeArray<float2> uvs;

		public NativeArray<float3> normals;

		[NativeDisableParallelForRestriction]
		public NativeArray<int> indices;

		public void DisposeArrays()
		{
		}

		public void Execute(int index)
		{
		}

		private static float3 CalculateTerrainNormal(NativeArray<float> heightmap, int x, int y, int width, int height, float3 scale)
		{
			return default(float3);
		}

		private static float SampleHeight(int x, int y, int width, int height, NativeArray<float> heightmap, float scale)
		{
			return 0f;
		}
	}
}
