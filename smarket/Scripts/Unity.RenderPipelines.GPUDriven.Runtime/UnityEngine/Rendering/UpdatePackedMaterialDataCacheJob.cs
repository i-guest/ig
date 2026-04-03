using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;

namespace UnityEngine.Rendering
{
	[BurstCompile(DisableSafetyChecks = true, OptimizeFor = OptimizeFor.Performance)]
	internal struct UpdatePackedMaterialDataCacheJob : IJob
	{
		[ReadOnly]
		public NativeArray<EntityId>.ReadOnly materialIDs;

		[ReadOnly]
		public NativeArray<GPUDrivenPackedMaterialData>.ReadOnly packedMaterialDatas;

		public NativeParallelHashMap<EntityId, GPUDrivenPackedMaterialData> packedMaterialHash;

		private void ProcessMaterial(int i)
		{
		}

		public void Execute()
		{
		}
	}
}
