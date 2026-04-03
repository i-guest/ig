using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;

namespace UnityEngine.Rendering
{
	[BurstCompile(DisableSafetyChecks = true, OptimizeFor = OptimizeFor.Performance)]
	internal struct PrefixSumDrawInstancesJob : IJob
	{
		[ReadOnly]
		public NativeParallelHashMap<RangeKey, int> rangeHash;

		public NativeList<DrawRange> drawRanges;

		public NativeList<DrawBatch> drawBatches;

		public NativeArray<int> drawBatchIndices;

		public void Execute()
		{
		}
	}
}
