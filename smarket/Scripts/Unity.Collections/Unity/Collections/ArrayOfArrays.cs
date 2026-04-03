using System;
using System.Diagnostics;

namespace Unity.Collections
{
	internal struct ArrayOfArrays<T> : IDisposable where T : struct
	{
		private AllocatorManager.AllocatorHandle m_backingAllocatorHandle;

		private int m_lengthInElements;

		private int m_capacityInElements;

		private int m_log2BlockSizeInElements;

		private int m_blocks;

		private unsafe IntPtr* m_block;

		private int BlockSizeInElements => 0;

		private int BlockSizeInBytes => 0;

		private int BlockMask => 0;

		public int Length => 0;

		public int Capacity => 0;

		public ref T this[int elementIndex]
		{
			get
			{
				throw null;
			}
		}

		public unsafe ArrayOfArrays(int capacityInElements, AllocatorManager.AllocatorHandle backingAllocatorHandle, int log2BlockSizeInElements = 12)
		{
			m_backingAllocatorHandle = default(AllocatorManager.AllocatorHandle);
			m_lengthInElements = 0;
			m_capacityInElements = 0;
			m_log2BlockSizeInElements = 0;
			m_blocks = 0;
			m_block = null;
		}

		public void LockfreeAdd(T t)
		{
		}

		public void Rewind()
		{
		}

		public void Clear()
		{
		}

		public void Dispose()
		{
		}

		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		private void CheckElementIndex(int elementIndex)
		{
		}

		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		private void CheckBlockIndex(int blockIndex)
		{
		}

		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		private void CheckBlockIsNotNull(int blockIndex)
		{
		}

		public void RemoveAtSwapBack(int elementIndex)
		{
		}

		private int BlockIndexOfElement(int elementIndex)
		{
			return 0;
		}

		public void TrimExcess()
		{
		}
	}
}
