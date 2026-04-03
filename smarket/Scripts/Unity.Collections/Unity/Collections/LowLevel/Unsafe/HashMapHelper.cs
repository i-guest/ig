using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Unity.Collections.LowLevel.Unsafe
{
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
	internal struct HashMapHelper<TKey> where TKey : struct
	{
		internal struct Enumerator
		{
			[NativeDisableUnsafePtrRestriction]
			internal unsafe HashMapHelper<TKey>* m_Data;

			internal int m_Index;

			internal int m_BucketIndex;

			internal int m_NextIndex;

			internal unsafe Enumerator(HashMapHelper<TKey>* data)
			{
				m_Data = null;
				m_Index = 0;
				m_BucketIndex = 0;
				m_NextIndex = 0;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			internal bool MoveNext()
			{
				return false;
			}

			internal void Reset()
			{
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			internal KVPair<TKey, TValue> GetCurrent<TValue>() where TValue : struct
			{
				return default(KVPair<TKey, TValue>);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			internal TKey GetCurrentKey()
			{
				return default(TKey);
			}
		}

		[NativeDisableUnsafePtrRestriction]
		internal unsafe byte* Ptr;

		[NativeDisableUnsafePtrRestriction]
		internal unsafe TKey* Keys;

		[NativeDisableUnsafePtrRestriction]
		internal unsafe int* Next;

		[NativeDisableUnsafePtrRestriction]
		internal unsafe int* Buckets;

		internal int Count;

		internal int Capacity;

		internal int Log2MinGrowth;

		internal int BucketCapacity;

		internal int AllocatedIndex;

		internal int FirstFreeIdx;

		internal int SizeOfTValue;

		internal AllocatorManager.AllocatorHandle Allocator;

		internal const int kMinimumCapacity = 256;

		internal readonly bool IsCreated
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return false;
			}
		}

		internal readonly bool IsEmpty
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return false;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal int CalcCapacityCeilPow2(int capacity)
		{
			return 0;
		}

		internal static int GetBucketSize(int capacity)
		{
			return 0;
		}

		internal void Clear()
		{
		}

		internal void Init(int capacity, int sizeOfValueT, int minGrowth, AllocatorManager.AllocatorHandle allocator)
		{
		}

		internal void Dispose()
		{
		}

		internal unsafe static HashMapHelper<TKey>* Alloc(int capacity, int sizeOfValueT, int minGrowth, AllocatorManager.AllocatorHandle allocator)
		{
			return null;
		}

		internal unsafe static void Free(HashMapHelper<TKey>* data)
		{
		}

		internal void Resize(int newCapacity)
		{
		}

		internal void ResizeExact(int newCapacity, int newBucketCapacity)
		{
		}

		internal void TrimExcess()
		{
		}

		internal static int CalculateDataSize(int capacity, int bucketCapacity, int sizeOfTValue, out int outKeyOffset, out int outNextOffset, out int outBucketOffset)
		{
			outKeyOffset = default(int);
			outNextOffset = default(int);
			outBucketOffset = default(int);
			return 0;
		}

		internal readonly int GetCount()
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private int GetBucket(in TKey key)
		{
			return 0;
		}

		internal int TryAdd(in TKey key)
		{
			return 0;
		}

		internal int Find(TKey key)
		{
			return 0;
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
		internal bool TryGetValue<TValue>(TKey key, out TValue item) where TValue : struct
		{
			item = default(TValue);
			return false;
		}

		internal int TryRemove(TKey key)
		{
			return 0;
		}

		internal bool MoveNextSearch(ref int bucketIndex, ref int nextIndex, out int index)
		{
			index = default(int);
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal bool MoveNext(ref int bucketIndex, ref int nextIndex, out int index)
		{
			index = default(int);
			return false;
		}

		internal NativeArray<TKey> GetKeyArray(AllocatorManager.AllocatorHandle allocator)
		{
			return default(NativeArray<TKey>);
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
		internal NativeArray<TValue> GetValueArray<TValue>(AllocatorManager.AllocatorHandle allocator) where TValue : struct
		{
			return default(NativeArray<TValue>);
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
		internal NativeKeyValueArrays<TKey, TValue> GetKeyValueArrays<TValue>(AllocatorManager.AllocatorHandle allocator) where TValue : struct
		{
			return default(NativeKeyValueArrays<TKey, TValue>);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		private void CheckIndexOutOfBounds(int idx)
		{
		}
	}
}
