using System;

namespace Unity.Collections
{
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(AllocatorManager.AllocatorHandle) })]
	public struct AllocatorHelper<T> : IDisposable where T : struct, AllocatorManager.IAllocator
	{
		private unsafe readonly T* m_allocator;

		private AllocatorManager.AllocatorHandle m_backingAllocator;

		public ref T Allocator
		{
			get
			{
				throw null;
			}
		}

		[ExcludeFromBurstCompatTesting("CreateAllocator is unburstable")]
		public unsafe AllocatorHelper(AllocatorManager.AllocatorHandle backingAllocator, bool isGlobal = false, int globalIndex = 0)
		{
			m_allocator = null;
			m_backingAllocator = default(AllocatorManager.AllocatorHandle);
		}

		[ExcludeFromBurstCompatTesting("DestroyAllocator is unburstable")]
		public void Dispose()
		{
		}
	}
}
