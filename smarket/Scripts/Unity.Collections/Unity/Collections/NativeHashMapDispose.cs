using Unity.Collections.LowLevel.Unsafe;

namespace Unity.Collections
{
	[NativeContainer]
	[GenerateTestsForBurstCompatibility]
	internal struct NativeHashMapDispose
	{
		[NativeDisableUnsafePtrRestriction]
		internal unsafe UnsafeHashMap<int, int>* m_HashMapData;

		internal AllocatorManager.AllocatorHandle m_Allocator;

		internal void Dispose()
		{
		}
	}
}
