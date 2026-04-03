using System;

namespace Unity.Collections
{
	[GenerateTestsForBurstCompatibility]
	public static class NativeParallelMultiHashMapExtensions
	{
		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
		{
			typeof(int),
			typeof(int),
			typeof(AllocatorManager.AllocatorHandle)
		})]
		internal static void Initialize<TKey, TValue, U>(this ref NativeParallelMultiHashMap<TKey, TValue> container, int capacity, ref U allocator) where TKey : struct where TValue : struct where U : struct
		{
		}
	}
}
