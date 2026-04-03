using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;

namespace UnityEngine.Rendering
{
	[BurstCompile(DisableSafetyChecks = true, OptimizeFor = OptimizeFor.Performance)]
	internal struct FindNonRegisteredMeshesJob : IJobParallelForBatch
	{
		public const int k_BatchSize = 128;

		[ReadOnly]
		public NativeArray<EntityId> instanceIDs;

		[ReadOnly]
		public NativeParallelHashMap<EntityId, BatchMeshID> hashMap;

		[WriteOnly]
		public NativeList<EntityId>.ParallelWriter outInstancesWriter;

		public void Execute(int startIndex, int count)
		{
		}
	}
}
