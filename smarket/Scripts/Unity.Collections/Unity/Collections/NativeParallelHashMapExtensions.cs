using System;
using Unity.Collections.LowLevel.Unsafe;

namespace Unity.Collections
{
	[GenerateTestsForBurstCompatibility]
	public static class NativeParallelHashMapExtensions
	{
		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
		public static int Unique<T>(this NativeArray<T> array) where T : struct
		{
			return 0;
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
		{
			typeof(int),
			typeof(int)
		})]
		public static (NativeArray<TKey>, int) GetUniqueKeyArray<TKey, TValue>(this UnsafeParallelMultiHashMap<TKey, TValue> container, AllocatorManager.AllocatorHandle allocator) where TKey : struct where TValue : struct
		{
			return default((NativeArray<TKey>, int));
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
		{
			typeof(int),
			typeof(int)
		})]
		public static (NativeArray<TKey>, int) GetUniqueKeyArray<TKey, TValue>(this NativeParallelMultiHashMap<TKey, TValue> container, AllocatorManager.AllocatorHandle allocator) where TKey : struct where TValue : struct
		{
			return default((NativeArray<TKey>, int));
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
		{
			typeof(int),
			typeof(int)
		})]
		public static UnsafeParallelHashMapBucketData GetUnsafeBucketData<TKey, TValue>(this NativeParallelHashMap<TKey, TValue> container) where TKey : struct where TValue : struct
		{
			return default(UnsafeParallelHashMapBucketData);
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
		{
			typeof(int),
			typeof(int)
		})]
		public static UnsafeParallelHashMapBucketData GetUnsafeBucketData<TKey, TValue>(this NativeParallelMultiHashMap<TKey, TValue> container) where TKey : struct where TValue : struct
		{
			return default(UnsafeParallelHashMapBucketData);
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
		{
			typeof(int),
			typeof(int)
		})]
		public static void Remove<TKey, TValue>(this NativeParallelMultiHashMap<TKey, TValue> container, TKey key, TValue value) where TKey : struct where TValue : struct
		{
		}
	}
}
