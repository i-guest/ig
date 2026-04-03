using System;
using System.Diagnostics;

namespace Unity.Collections
{
	public struct DoubleRewindableAllocators : IDisposable
	{
		private unsafe RewindableAllocator* Pointer;

		private AllocatorHelper<RewindableAllocator> UpdateAllocatorHelper0;

		private AllocatorHelper<RewindableAllocator> UpdateAllocatorHelper1;

		public ref RewindableAllocator Allocator
		{
			get
			{
				throw null;
			}
		}

		public bool IsCreated => false;

		internal bool EnableBlockFree
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public void Update()
		{
		}

		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		private void CheckIsCreated()
		{
		}

		public unsafe DoubleRewindableAllocators(AllocatorManager.AllocatorHandle backingAllocator, int initialSizeInBytes)
		{
			Pointer = null;
			UpdateAllocatorHelper0 = default(AllocatorHelper<RewindableAllocator>);
			UpdateAllocatorHelper1 = default(AllocatorHelper<RewindableAllocator>);
		}

		public void Initialize(AllocatorManager.AllocatorHandle backingAllocator, int initialSizeInBytes)
		{
		}

		public void Dispose()
		{
		}
	}
}
