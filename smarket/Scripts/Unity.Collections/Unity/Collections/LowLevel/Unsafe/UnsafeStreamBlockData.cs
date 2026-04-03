namespace Unity.Collections.LowLevel.Unsafe
{
	[GenerateTestsForBurstCompatibility]
	internal struct UnsafeStreamBlockData
	{
		internal const int AllocationSize = 4096;

		internal AllocatorManager.AllocatorHandle Allocator;

		internal unsafe UnsafeStreamBlock** Blocks;

		internal int BlockCount;

		internal AllocatorManager.Block Ranges;

		internal int RangeCount;

		internal unsafe UnsafeStreamBlock* Allocate(UnsafeStreamBlock* oldBlock, int threadIndex)
		{
			return null;
		}

		internal unsafe void Free(UnsafeStreamBlock* oldBlock)
		{
		}
	}
}
