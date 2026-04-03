using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Unity.Collections.LowLevel.Unsafe
{
	[StructLayout((LayoutKind)2)]
	[GenerateTestsForBurstCompatibility]
	internal struct UnsafeParallelHashMapData
	{
		[FieldOffset(0)]
		internal unsafe byte* values;

		[FieldOffset(8)]
		internal unsafe byte* keys;

		[FieldOffset(16)]
		internal unsafe byte* next;

		[FieldOffset(24)]
		internal unsafe byte* buckets;

		[FieldOffset(32)]
		internal int keyCapacity;

		[FieldOffset(36)]
		internal int bucketCapacityMask;

		[FieldOffset(40)]
		internal int allocatedIndexLength;

		private const int kFirstFreeTLSOffset = 64;

		internal const int IntsPerCacheLine = 16;

		internal unsafe int* firstFreeTLS => null;

		internal static int GetBucketSize(int capacity)
		{
			return 0;
		}

		internal static int GrowCapacity(int capacity)
		{
			return 0;
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
		{
			typeof(int),
			typeof(int)
		})]
		internal unsafe static void AllocateHashMap<TKey, TValue>(int length, int bucketLength, AllocatorManager.AllocatorHandle label, out UnsafeParallelHashMapData* outBuf) where TKey : struct where TValue : struct
		{
			System.Runtime.CompilerServices.Unsafe.As<UnsafeParallelHashMapData*, @null>(ref outBuf) = null;
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
		{
			typeof(int),
			typeof(int)
		})]
		internal unsafe static void ReallocateHashMap<TKey, TValue>(UnsafeParallelHashMapData* data, int newCapacity, int newBucketCapacity, AllocatorManager.AllocatorHandle label) where TKey : struct where TValue : struct
		{
		}

		internal unsafe static void DeallocateHashMap(UnsafeParallelHashMapData* data, AllocatorManager.AllocatorHandle allocator)
		{
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
		{
			typeof(int),
			typeof(int)
		})]
		internal static int CalculateDataSize<TKey, TValue>(int length, int bucketLength, out int keyOffset, out int nextOffset, out int bucketOffset) where TKey : struct where TValue : struct
		{
			keyOffset = default(int);
			nextOffset = default(int);
			bucketOffset = default(int);
			return 0;
		}

		internal unsafe static bool IsEmpty(UnsafeParallelHashMapData* data)
		{
			return false;
		}

		internal unsafe static int GetCount(UnsafeParallelHashMapData* data)
		{
			return 0;
		}

		internal unsafe static bool MoveNextSearch(UnsafeParallelHashMapData* data, ref int bucketIndex, ref int nextIndex, out int index)
		{
			index = default(int);
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal unsafe static bool MoveNext(UnsafeParallelHashMapData* data, ref int bucketIndex, ref int nextIndex, out int index)
		{
			index = default(int);
			return false;
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
		internal unsafe static void GetKeyArray<TKey>(UnsafeParallelHashMapData* data, NativeArray<TKey> result) where TKey : struct
		{
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
		internal unsafe static void GetValueArray<TValue>(UnsafeParallelHashMapData* data, NativeArray<TValue> result) where TValue : struct
		{
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
		{
			typeof(int),
			typeof(int)
		})]
		internal unsafe static void GetKeyValueArrays<TKey, TValue>(UnsafeParallelHashMapData* data, NativeKeyValueArrays<TKey, TValue> result) where TKey : struct where TValue : struct
		{
		}

		internal UnsafeParallelHashMapBucketData GetBucketData()
		{
			return default(UnsafeParallelHashMapBucketData);
		}

		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		private unsafe static void CheckHashMapReallocateDoesNotShrink(UnsafeParallelHashMapData* data, int newCapacity)
		{
		}
	}
}
