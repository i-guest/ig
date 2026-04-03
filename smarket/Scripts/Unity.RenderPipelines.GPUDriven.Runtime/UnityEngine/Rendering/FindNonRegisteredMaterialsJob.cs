using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;

namespace UnityEngine.Rendering
{
	[BurstCompile(DisableSafetyChecks = true, OptimizeFor = OptimizeFor.Performance)]
	internal struct FindNonRegisteredMaterialsJob : IJobParallelForBatch
	{
		public const int k_BatchSize = 128;

		[ReadOnly]
		public NativeArray<EntityId> instanceIDs;

		[ReadOnly]
		public NativeArray<GPUDrivenPackedMaterialData> packedMaterialDatas;

		[ReadOnly]
		public NativeParallelHashMap<EntityId, BatchMaterialID> hashMap;

		[WriteOnly]
		public NativeList<EntityId>.ParallelWriter outInstancesWriter;

		[WriteOnly]
		public NativeList<GPUDrivenPackedMaterialData>.ParallelWriter outPackedMaterialDatasWriter;

		public void Execute(int startIndex, int count)
		{
		}
	}
}
