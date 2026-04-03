using System;

namespace UnityEngine.Rendering.RadeonRays
{
	internal sealed class RestructureBvh : IDisposable
	{
		private struct ScratchBufferLayout
		{
			public uint LeafParents;

			public uint TreeletCount;

			public uint TreeletRoots;

			public uint PrimitiveCounts;

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

		private readonly ComputeShader shader;

		private readonly int kernelInitPrimitiveCounts;

		private readonly int kernelFindTreeletRoots;

		private readonly int kernelRestructure;

		private readonly int kernelPrepareTreeletsDispatchSize;

		private const int numIterations = 3;

		private readonly GraphicsBuffer treeletDispatchIndirectBuffer;

		private const uint kGroupSize = 256u;

		private const uint kTrianglesPerThread = 8u;

		private const uint kTrianglesPerGroup = 2048u;

		private const uint kMinPrimitivesPerTreelet = 64u;

		private const int kMaxThreadGroupsPerDispatch = 65535;

		public RestructureBvh(RadeonRaysShaders shaders)
		{
		}

		public void Dispose()
		{
		}

		public ulong GetScratchDataSizeInDwords(uint triangleCount)
		{
			return 0uL;
		}

		public static uint GetBvhNodeCount(uint leafCount)
		{
			return 0u;
		}

		public void Execute(CommandBuffer cmd, GraphicsBuffer vertices, int verticesOffset, uint vertexStride, uint triangleCount, GraphicsBuffer scratch, in BottomLevelLevelAccelStruct result)
		{
		}

		private void BindKernelArguments(CommandBuffer cmd, int kernel, GraphicsBuffer vertices, GraphicsBuffer scratch, BottomLevelLevelAccelStruct result)
		{
		}
	}
}
