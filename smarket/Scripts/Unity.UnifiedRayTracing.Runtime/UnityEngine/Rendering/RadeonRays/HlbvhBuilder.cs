namespace UnityEngine.Rendering.RadeonRays
{
	internal class HlbvhBuilder
	{
		private struct ScratchBufferLayout
		{
			public uint PrimitiveRefs;

			public uint MortonCodes;

			public uint SortedPrimitiveRefs;

			public uint SortedMortonCodes;

			public uint SortMemory;

			public uint Aabb;

			public uint LeafParents;

			public uint InternalNodeRange;

			public uint TotalSize;

			public static ScratchBufferLayout Create(uint triangleCount)
			{
				return default(ScratchBufferLayout);
			}

			private uint Reserve(uint size)
			{
				return 0u;
			}
		}

		private readonly ComputeShader shaderBuildHlbvh;

		private readonly int kernelInit;

		private readonly int kernelCalculateAabb;

		private readonly int kernelCalculateMortonCodes;

		private readonly int kernelBuildTreeBottomUp;

		private readonly RadixSort radixSort;

		private const uint kTrianglesPerThread = 8u;

		private const uint kGroupSize = 256u;

		private const uint kTrianglesPerGroup = 2048u;

		public HlbvhBuilder(RadeonRaysShaders shaders)
		{
		}

		public uint GetScratchDataSizeInDwords(uint triangleCount)
		{
			return 0u;
		}

		public static uint GetBvhNodeCount(uint leafCount)
		{
			return 0u;
		}

		public uint GetResultDataSizeInDwords(uint triangleCount)
		{
			return 0u;
		}

		public void Execute(CommandBuffer cmd, GraphicsBuffer vertices, int verticesOffset, uint vertexStride, GraphicsBuffer indices, int indicesOffset, int baseIndex, IndexFormat indexFormat, uint triangleCount, GraphicsBuffer scratch, in BottomLevelLevelAccelStruct result)
		{
		}

		private void BindKernelArguments(CommandBuffer cmd, int kernel, GraphicsBuffer vertices, GraphicsBuffer indices, GraphicsBuffer scratch, ScratchBufferLayout scratchLayout, BottomLevelLevelAccelStruct result, bool setSortedCodes)
		{
		}
	}
}
