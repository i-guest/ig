using System;

namespace UnityEngine.Rendering.UnifiedRayTracing
{
	internal sealed class BLASPositionsPool : IDisposable
	{
		public const int VertexSizeInDwords = 3;

		private const int intialVertexCount = 1000;

		private GraphicsBuffer m_VerticesBuffer;

		private BlockAllocator m_VerticesAllocator;

		private readonly ComputeShader m_CopyPositionsShader;

		private readonly int m_CopyVerticesKernel;

		private readonly ComputeShader m_CopyShader;

		private const uint kItemsPerWorkgroup = 6144u;

		public GraphicsBuffer VertexBuffer => null;

		public BLASPositionsPool(ComputeShader copyPositionsShader, ComputeShader copyShader)
		{
		}

		public void Dispose()
		{
		}

		public void Clear()
		{
		}

		public void Add(VertexBufferChunk info, out BlockAllocator.Allocation verticesAllocation)
		{
			verticesAllocation = default(BlockAllocator.Allocation);
		}

		public void Remove(ref BlockAllocator.Allocation verticesAllocation)
		{
		}
	}
}
