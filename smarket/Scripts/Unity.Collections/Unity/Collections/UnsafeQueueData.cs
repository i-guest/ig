using System;
using System.Runtime.CompilerServices;

namespace Unity.Collections
{
	[GenerateTestsForBurstCompatibility]
	internal struct UnsafeQueueData
	{
		internal const int m_BlockSize = 16384;

		public IntPtr m_FirstBlock;

		public IntPtr m_LastBlock;

		public int m_MaxItems;

		public int m_CurrentRead;

		public unsafe byte* m_CurrentWriteBlockTLS;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal unsafe UnsafeQueueBlockHeader* GetCurrentWriteBlockTLS(int threadIndex)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal unsafe void SetCurrentWriteBlockTLS(int threadIndex, UnsafeQueueBlockHeader* currentWriteBlock)
		{
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
		public unsafe static UnsafeQueueBlockHeader* AllocateWriteBlockMT<T>(UnsafeQueueData* data, AllocatorManager.AllocatorHandle allocator, int threadIndex) where T : struct
		{
			return null;
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
		public unsafe static void AllocateQueue<T>(AllocatorManager.AllocatorHandle allocator, out UnsafeQueueData* outBuf) where T : struct
		{
			System.Runtime.CompilerServices.Unsafe.As<UnsafeQueueData*, @null>(ref outBuf) = null;
		}

		public unsafe static void DeallocateQueue(UnsafeQueueData* data, AllocatorManager.AllocatorHandle allocator)
		{
		}
	}
}
