namespace UnityEngine.Rendering.RadeonRays
{
	internal class HlbvhTopLevelBuilder
	{
		private struct ScratchBufferLayout
		{
			public uint Aabb;

			public uint MortonCodes;

			public uint PrimitiveRefs;

			public uint SortedMortonCodes;

			public uint SortedPrimitiveRefs;

			public uint SortMemory;

			public uint InternalNodeRange;

			public uint TotalSize;

			public static ScratchBufferLayout Create(uint instanceCount)
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

		public HlbvhTopLevelBuilder(RadeonRaysShaders shaders)
		{
		}

		public ulong GetScratchDataSizeInDwords(uint instanceCount)
		{
			return 0uL;
		}

		public static uint GetBvhNodeCount(uint leafCount)
		{
			return 0u;
		}

		public void AllocateResultBuffers(uint instanceCount, ref TopLevelAccelStruct accelStruct)
		{
		}

		public void CreateEmpty(ref TopLevelAccelStruct accelStruct)
		{
		}

		public void Execute(CommandBuffer cmd, GraphicsBuffer scratch, ref TopLevelAccelStruct accelStruct)
		{
		}

		private void BindKernelArguments(CommandBuffer cmd, int kernel, GraphicsBuffer scratch, ScratchBufferLayout scratchLayout, TopLevelAccelStruct accelStruct, bool setSortedCodes)
		{
		}
	}
}
