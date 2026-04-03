using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;

namespace UnityEngine.Rendering
{
	[BurstCompile(DisableSafetyChecks = true, OptimizeFor = OptimizeFor.Performance)]
	internal struct BuildDrawListsJob : IJobParallelFor
	{
		public const int k_BatchSize = 128;

		public const int k_IntsPerCacheLine = 16;

		[ReadOnly]
		public NativeParallelHashMap<DrawKey, int> batchHash;

		[NativeDisableContainerSafetyRestriction]
		[NoAlias]
		[ReadOnly]
		public NativeList<DrawInstance> drawInstances;

		[NativeDisableContainerSafetyRestriction]
		[NoAlias]
		[ReadOnly]
		public NativeList<DrawBatch> drawBatches;

		[NativeDisableContainerSafetyRestriction]
		[NoAlias]
		[WriteOnly]
		public NativeArray<int> internalDrawIndex;

		[NativeDisableContainerSafetyRestriction]
		[NoAlias]
		[WriteOnly]
		public NativeArray<int> drawInstanceIndices;

		private unsafe static int IncrementCounter(int* counter)
		{
			return 0;
		}

		public void Execute(int index)
		{
		}
	}
}
