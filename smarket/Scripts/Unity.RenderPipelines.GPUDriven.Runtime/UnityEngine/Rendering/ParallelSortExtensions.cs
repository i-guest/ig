using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;

namespace UnityEngine.Rendering
{
	internal static class ParallelSortExtensions
	{
		[BurstCompile(DisableSafetyChecks = true, OptimizeFor = OptimizeFor.Performance)]
		internal struct RadixSortBucketCountJob : IJobFor
		{
			[ReadOnly]
			public int radix;

			[ReadOnly]
			public int jobsCount;

			[ReadOnly]
			public int batchSize;

			[ReadOnly]
			[NativeDisableContainerSafetyRestriction]
			[NoAlias]
			public NativeArray<int> array;

			[NativeDisableContainerSafetyRestriction]
			[NoAlias]
			public NativeArray<int> buckets;

			public void Execute(int index)
			{
			}
		}

		[BurstCompile(DisableSafetyChecks = true, OptimizeFor = OptimizeFor.Performance)]
		internal struct RadixSortBatchPrefixSumJob : IJobFor
		{
			[ReadOnly]
			public int radix;

			[ReadOnly]
			public int jobsCount;

			[ReadOnly]
			[NativeDisableContainerSafetyRestriction]
			[NoAlias]
			public NativeArray<int> array;

			[NativeDisableContainerSafetyRestriction]
			[NoAlias]
			public NativeArray<int> counter;

			[NativeDisableContainerSafetyRestriction]
			[NoAlias]
			public NativeArray<int> indicesSum;

			[NativeDisableContainerSafetyRestriction]
			[NoAlias]
			public NativeArray<int> buckets;

			[NativeDisableContainerSafetyRestriction]
			[NoAlias]
			public NativeArray<int> indices;

			private static int AtomicIncrement(NativeArray<int> counter)
			{
				return 0;
			}

			private int JobIndexPrefixSum(int sum, int i)
			{
				return 0;
			}

			public void Execute(int index)
			{
			}
		}

		[BurstCompile(DisableSafetyChecks = true, OptimizeFor = OptimizeFor.Performance)]
		internal struct RadixSortPrefixSumJob : IJobFor
		{
			[ReadOnly]
			public int jobsCount;

			[NativeDisableContainerSafetyRestriction]
			[NoAlias]
			public NativeArray<int> indicesSum;

			[NativeDisableContainerSafetyRestriction]
			[NoAlias]
			public NativeArray<int> indices;

			public void Execute(int index)
			{
			}
		}

		[BurstCompile(DisableSafetyChecks = true, OptimizeFor = OptimizeFor.Performance)]
		internal struct RadixSortBucketSortJob : IJobFor
		{
			[ReadOnly]
			public int radix;

			[ReadOnly]
			public int batchSize;

			[ReadOnly]
			[NativeDisableContainerSafetyRestriction]
			[NoAlias]
			public NativeArray<int> array;

			[NativeDisableContainerSafetyRestriction]
			[NoAlias]
			public NativeArray<int> indices;

			[NativeDisableContainerSafetyRestriction]
			[NoAlias]
			public NativeArray<int> arraySorted;

			public void Execute(int index)
			{
			}
		}

		private const int kMinRadixSortArraySize = 2048;

		private const int kMinRadixSortBatchSize = 256;

		internal static JobHandle ParallelSort(this NativeArray<int> array)
		{
			return default(JobHandle);
		}
	}
}
