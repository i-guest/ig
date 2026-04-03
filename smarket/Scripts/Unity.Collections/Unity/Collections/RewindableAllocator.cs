using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AOT;
using Unity.Burst;

namespace Unity.Collections
{
	[BurstCompile]
	public struct RewindableAllocator : AllocatorManager.IAllocator, IDisposable
	{
		internal struct Union
		{
			internal long m_long;

			private const int currentBits = 40;

			private const int currentOffset = 0;

			private const long currentMask = 1099511627775L;

			private const int allocCountBits = 24;

			private const int allocCountOffset = 40;

			private const long allocCountMask = 16777215L;

			internal long m_current
			{
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				get
				{
					return 0L;
				}
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				set
				{
				}
			}

			internal long m_allocCount
			{
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				get
				{
					return 0L;
				}
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				set
				{
				}
			}
		}

		[GenerateTestsForBurstCompatibility]
		internal struct MemoryBlock : IDisposable
		{
			public const int kMaximumAlignment = 16384;

			public unsafe byte* m_pointer;

			public long m_bytes;

			public Union m_union;

			public unsafe MemoryBlock(long bytes)
			{
				m_pointer = null;
				m_bytes = 0L;
				m_union = default(Union);
			}

			public void Rewind()
			{
			}

			public void Dispose()
			{
			}

			public bool Contains(IntPtr ptr)
			{
				return false;
			}
		}

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate int Try_000009E0_0024PostfixBurstDelegate(IntPtr state, ref AllocatorManager.Block block);

		internal static class Try_000009E0_0024BurstDirectCall
		{
			private static IntPtr Pointer;

			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr P_0)
			{
			}

			private static IntPtr GetFunctionPointer()
			{
				return (IntPtr)0;
			}

			public static int Invoke(IntPtr state, ref AllocatorManager.Block block)
			{
				return 0;
			}
		}

		private const int kLog2MaxMemoryBlockSize = 26;

		private const long kMaxMemoryBlockSize = 67108864L;

		private const long kMinMemoryBlockSize = 131072L;

		private const int kMaxNumBlocks = 64;

		private const int kBlockBusyRewindMask = -2147483648;

		private const int kBlockBusyAllocateMask = 2147483647;

		private Spinner m_spinner;

		private AllocatorManager.AllocatorHandle m_handle;

		private UnmanagedArray<MemoryBlock> m_block;

		private int m_last;

		private int m_used;

		private byte m_enableBlockFree;

		private byte m_reachMaxBlockSize;

		public bool EnableBlockFree
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int BlocksAllocated => 0;

		public int InitialSizeInBytes => 0;

		internal long MaxMemoryBlockSize => 0L;

		internal long BytesAllocated => 0L;

		[ExcludeFromBurstCompatTesting("Uses managed delegate")]
		public AllocatorManager.TryFunction Function => null;

		public AllocatorManager.AllocatorHandle Handle
		{
			get
			{
				return default(AllocatorManager.AllocatorHandle);
			}
			set
			{
			}
		}

		public Allocator ToAllocator => default(Allocator);

		public bool IsCustomAllocator => false;

		public bool IsAutoDispose => false;

		public void Initialize(int initialSizeInBytes, bool enableBlockFree = false)
		{
		}

		public void Rewind()
		{
		}

		public void Dispose()
		{
		}

		private int TryAllocate(ref AllocatorManager.Block block, int startIndex, int lastIndex, long alignedSize, long alignmentMask)
		{
			return 0;
		}

		public int Try(ref AllocatorManager.Block block)
		{
			return 0;
		}

		[BurstCompile]
		[MonoPInvokeCallback(typeof(AllocatorManager.TryFunction))]
		internal static int Try(IntPtr state, ref AllocatorManager.Block block)
		{
			return 0;
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
		public NativeArray<T> AllocateNativeArray<T>(int length) where T : struct
		{
			return default(NativeArray<T>);
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
		public NativeList<T> AllocateNativeList<T>(int capacity) where T : struct
		{
			return default(NativeList<T>);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(AllocatorManager.TryFunction))]
		internal static int Try_0024BurstManaged(IntPtr state, ref AllocatorManager.Block block)
		{
			return 0;
		}
	}
}
