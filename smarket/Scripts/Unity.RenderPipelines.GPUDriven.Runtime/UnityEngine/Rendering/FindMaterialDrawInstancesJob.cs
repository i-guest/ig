using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;

namespace UnityEngine.Rendering
{
	[BurstCompile(DisableSafetyChecks = true, OptimizeFor = OptimizeFor.Performance)]
	internal struct FindMaterialDrawInstancesJob : IJobParallelForBatch
	{
		public const int k_BatchSize = 128;

		[ReadOnly]
		public NativeArray<uint> materialsSorted;

		[NativeDisableContainerSafetyRestriction]
		[NoAlias]
		[ReadOnly]
		public NativeList<DrawInstance> drawInstances;

		[WriteOnly]
		public NativeList<int>.ParallelWriter outDrawInstanceIndicesWriter;

		public void Execute(int startIndex, int count)
		{
		}
	}
}
