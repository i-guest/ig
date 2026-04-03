using System;
using System.Diagnostics;
using Unity.Jobs;

namespace Unity.Collections.LowLevel.Unsafe
{
	[DebuggerDisplay("Length = {Length}, IsCreated = {IsCreated}")]
	[DebuggerTypeProxy(typeof(UnsafeBitArrayDebugView))]
	[GenerateTestsForBurstCompatibility]
	public struct UnsafeBitArray : INativeDisposable, IDisposable
	{
		public struct ReadOnly
		{
			[NativeDisableUnsafePtrRestriction]
			public unsafe readonly ulong* Ptr;

			public readonly int Length;

			public readonly bool IsCreated => false;

			public readonly bool IsEmpty => false;

			internal unsafe ReadOnly(ulong* ptr, int length)
			{
				Ptr = null;
				Length = 0;
			}

			public readonly ulong GetBits(int pos, int numBits = 1)
			{
				return 0uL;
			}

			public readonly bool IsSet(int pos)
			{
				return false;
			}

			public readonly int Find(int pos, int numBits)
			{
				return 0;
			}

			public readonly int Find(int pos, int count, int numBits)
			{
				return 0;
			}

			public readonly bool TestNone(int pos, int numBits = 1)
			{
				return false;
			}

			public readonly bool TestAny(int pos, int numBits = 1)
			{
				return false;
			}

			public readonly bool TestAll(int pos, int numBits = 1)
			{
				return false;
			}

			public readonly int CountBits(int pos, int numBits = 1)
			{
				return 0;
			}

			[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
			[Conditional("UNITY_DOTS_DEBUG")]
			private readonly void CheckArgs(int pos, int numBits)
			{
			}

			[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
			[Conditional("UNITY_DOTS_DEBUG")]
			private readonly void CheckArgsPosCount(int begin, int count, int numBits)
			{
			}

			[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
			[Conditional("UNITY_DOTS_DEBUG")]
			private readonly void CheckArgsUlong(int pos, int numBits)
			{
			}
		}

		[NativeDisableUnsafePtrRestriction]
		public unsafe ulong* Ptr;

		public int Length;

		public int Capacity;

		public AllocatorManager.AllocatorHandle Allocator;

		public readonly bool IsCreated => false;

		public readonly bool IsEmpty => false;

		public unsafe UnsafeBitArray(void* ptr, int sizeInBytes, AllocatorManager.AllocatorHandle allocator = default(AllocatorManager.AllocatorHandle))
		{
			Ptr = null;
			Length = 0;
			Capacity = 0;
			Allocator = default(AllocatorManager.AllocatorHandle);
		}

		public unsafe UnsafeBitArray(int numBits, AllocatorManager.AllocatorHandle allocator, NativeArrayOptions options = NativeArrayOptions.ClearMemory)
		{
			Ptr = null;
			Length = 0;
			Capacity = 0;
			Allocator = default(AllocatorManager.AllocatorHandle);
		}

		internal unsafe static UnsafeBitArray* Alloc(AllocatorManager.AllocatorHandle allocator)
		{
			return null;
		}

		internal unsafe static void Free(UnsafeBitArray* data, AllocatorManager.AllocatorHandle allocator)
		{
		}

		private void Realloc(int capacityInBits)
		{
		}

		public void Resize(int numBits, NativeArrayOptions options = NativeArrayOptions.UninitializedMemory)
		{
		}

		public void SetCapacity(int capacityInBits)
		{
		}

		public void TrimExcess()
		{
		}

		public void Dispose()
		{
		}

		public JobHandle Dispose(JobHandle inputDeps)
		{
			return default(JobHandle);
		}

		public void Clear()
		{
		}

		public unsafe static void Set(ulong* ptr, int pos, bool value)
		{
		}

		public void Set(int pos, bool value)
		{
		}

		public void SetBits(int pos, bool value, int numBits)
		{
		}

		public void SetBits(int pos, ulong value, int numBits = 1)
		{
		}

		public ulong GetBits(int pos, int numBits = 1)
		{
			return 0uL;
		}

		public bool IsSet(int pos)
		{
			return false;
		}

		internal void CopyUlong(int dstPos, ref UnsafeBitArray srcBitArray, int srcPos, int numBits)
		{
		}

		public void Copy(int dstPos, int srcPos, int numBits)
		{
		}

		public void Copy(int dstPos, ref UnsafeBitArray srcBitArray, int srcPos, int numBits)
		{
		}

		public int Find(int pos, int numBits)
		{
			return 0;
		}

		public int Find(int pos, int count, int numBits)
		{
			return 0;
		}

		public bool TestNone(int pos, int numBits = 1)
		{
			return false;
		}

		public bool TestAny(int pos, int numBits = 1)
		{
			return false;
		}

		public bool TestAll(int pos, int numBits = 1)
		{
			return false;
		}

		public int CountBits(int pos, int numBits = 1)
		{
			return 0;
		}

		public ReadOnly AsReadOnly()
		{
			return default(ReadOnly);
		}

		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		private static void CheckSizeMultipleOf8(int sizeInBytes)
		{
		}

		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		private void CheckArgs(int pos, int numBits)
		{
		}

		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		private void CheckArgsPosCount(int begin, int count, int numBits)
		{
		}

		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		private void CheckArgsUlong(int pos, int numBits)
		{
		}

		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		private static void CheckArgsCopy(ref UnsafeBitArray dstBitArray, int dstPos, ref UnsafeBitArray srcBitArray, int srcPos, int numBits)
		{
		}
	}
}
