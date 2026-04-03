using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;

namespace UnityEngine.Rendering
{
	[BurstCompile(DisableSafetyChecks = true, OptimizeFor = OptimizeFor.Performance)]
	internal struct CompactVisibilityMasksJob : IJobParallelForBatch
	{
		public const int k_BatchSize = 64;

		[ReadOnly]
		public NativeArray<byte> rendererVisibilityMasks;

		[NativeDisableContainerSafetyRestriction]
		[NoAlias]
		public ParallelBitArray compactedVisibilityMasks;

		public void Execute(int startIndex, int count)
		{
		}
	}
}
