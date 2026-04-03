using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;

namespace UnityEngine.Rendering
{
	[BurstCompile(DisableSafetyChecks = true, OptimizeFor = OptimizeFor.Performance)]
	internal struct PrefixSumDrawsAndInstances : IJob
	{
		[ReadOnly]
		public NativeList<DrawRange> drawRanges;

		[ReadOnly]
		public NativeArray<int> drawBatchIndices;

		[ReadOnly]
		public NativeArray<int> batchBinAllocOffsets;

		[ReadOnly]
		public NativeArray<int> batchBinCounts;

		[ReadOnly]
		public NativeArray<int> binVisibleInstanceCounts;

		[NativeDisableContainerSafetyRestriction]
		[NoAlias]
		[WriteOnly]
		public NativeArray<int> batchDrawCommandOffsets;

		[NativeDisableContainerSafetyRestriction]
		[NoAlias]
		[WriteOnly]
		public NativeArray<int> binVisibleInstanceOffsets;

		[NativeDisableUnsafePtrRestriction]
		public NativeArray<BatchCullingOutputDrawCommands> cullingOutput;

		[ReadOnly]
		public IndirectBufferLimits indirectBufferLimits;

		[NativeDisableContainerSafetyRestriction]
		[NoAlias]
		public NativeArray<IndirectBufferAllocInfo> indirectBufferAllocInfo;

		[NativeDisableContainerSafetyRestriction]
		[NoAlias]
		public NativeArray<int> indirectAllocationCounters;

		public void Execute()
		{
		}
	}
}
