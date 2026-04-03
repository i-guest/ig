using System;
using System.Diagnostics;

namespace Unity.Collections.LowLevel.Unsafe
{
	[GenerateTestsForBurstCompatibility]
	public struct UnsafeScratchAllocator
	{
		private unsafe void* m_Pointer;

		private int m_LengthInBytes;

		private readonly int m_CapacityInBytes;

		public unsafe UnsafeScratchAllocator(void* ptr, int capacityInBytes)
		{
			m_Pointer = null;
			m_LengthInBytes = 0;
			m_CapacityInBytes = 0;
		}

		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		private void CheckAllocationDoesNotExceedCapacity(ulong requestedSize)
		{
		}

		public unsafe void* Allocate(int sizeInBytes, int alignmentInBytes)
		{
			return null;
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
		public unsafe void* Allocate<T>(int count = 1) where T : struct
		{
			return null;
		}
	}
}
