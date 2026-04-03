using System;
using Unity.Collections;

namespace UnityEngine.Rendering.UnifiedRayTracing
{
	internal struct BlockAllocator : IDisposable
	{
		public struct Block
		{
			public int offset;

			public int count;

			public static readonly Block Invalid;
		}

		public struct Allocation
		{
			public int handle;

			public Block block;

			public static readonly Allocation Invalid;

			public readonly bool valid => false;
		}

		private int m_FreeElementCount;

		private int m_MaxElementCount;

		private NativeList<Block> m_freeBlocks;

		private NativeList<Block> m_usedBlocks;

		private NativeList<int> m_freeSlots;

		public int freeElementsCount => 0;

		public int freeBlocks => 0;

		public int capacity => 0;

		public int allocatedSize => 0;

		public void Initialize(int maxElementCounts)
		{
		}

		private int CalculateGeometricGrowthCapacity(int desiredNewCapacity, int maxAllowedNewCapacity)
		{
			return 0;
		}

		public int Grow(int newDesiredCapacity, int maxAllowedCapacity = 2147483647)
		{
			return 0;
		}

		public bool GetExpectedGrowthToFitAllocation(int elementCounts, int maxAllowedCapacity, out int newCapacity)
		{
			newCapacity = default(int);
			return false;
		}

		public Allocation GrowAndAllocate(int elementCounts, out int oldCapacity, out int newCapacity)
		{
			oldCapacity = default(int);
			newCapacity = default(int);
			return default(Allocation);
		}

		public Allocation GrowAndAllocate(int elementCounts, int maxAllowedCapacity, out int oldCapacity, out int newCapacity)
		{
			oldCapacity = default(int);
			newCapacity = default(int);
			return default(Allocation);
		}

		public void Dispose()
		{
		}

		public Allocation Allocate(int elementCounts)
		{
			return default(Allocation);
		}

		private int MergeBlockFrontBack(int freeBlockId)
		{
			return 0;
		}

		public void FreeAllocation(in Allocation allocation)
		{
		}

		public Allocation[] SplitAllocation(in Allocation allocation, int count)
		{
			return null;
		}
	}
}
