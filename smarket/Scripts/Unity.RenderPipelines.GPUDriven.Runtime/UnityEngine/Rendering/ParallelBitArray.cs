using Unity.Collections;
using Unity.Jobs;

namespace UnityEngine.Rendering
{
	internal struct ParallelBitArray
	{
		private Allocator m_Allocator;

		private NativeArray<long> m_Bits;

		private int m_Length;

		public int Length => 0;

		public bool IsCreated => false;

		public ParallelBitArray(int length, Allocator allocator, NativeArrayOptions options = NativeArrayOptions.ClearMemory)
		{
			m_Allocator = default(Allocator);
			m_Bits = default(NativeArray<long>);
			m_Length = 0;
		}

		public void Dispose()
		{
		}

		public void Dispose(JobHandle inputDeps)
		{
		}

		public void Resize(int newLength)
		{
		}

		public void Set(int index, bool value)
		{
		}

		public bool Get(int index)
		{
			return false;
		}

		public ulong GetChunk(int chunk_index)
		{
			return 0uL;
		}

		public void SetChunk(int chunk_index, ulong chunk_bits)
		{
		}

		public ulong InterlockedReadChunk(int chunk_index)
		{
			return 0uL;
		}

		public void InterlockedOrChunk(int chunk_index, ulong chunk_bits)
		{
		}

		public int ChunkCount()
		{
			return 0;
		}

		public ParallelBitArray GetSubArray(int length)
		{
			return default(ParallelBitArray);
		}

		public NativeArray<long> GetBitsArray()
		{
			return default(NativeArray<long>);
		}

		public void FillZeroes(int length)
		{
		}
	}
}
