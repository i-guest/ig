using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;

namespace UnityEngine.Rendering
{
	[BurstCompile(DisableSafetyChecks = true, OptimizeFor = OptimizeFor.Performance)]
	internal struct UpdateLODGroupTransformJob : IJobParallelFor
	{
		public const int k_BatchSize = 256;

		[ReadOnly]
		public NativeParallelHashMap<int, GPUInstanceIndex> lodGroupDataHash;

		[ReadOnly]
		public NativeArray<EntityId> lodGroupIDs;

		[ReadOnly]
		public NativeArray<Vector3> worldSpaceReferencePoints;

		[ReadOnly]
		public NativeArray<float> worldSpaceSizes;

		[ReadOnly]
		public bool requiresGPUUpload;

		[ReadOnly]
		public bool supportDitheringCrossFade;

		[NativeDisableContainerSafetyRestriction]
		[NoAlias]
		[ReadOnly]
		public NativeList<LODGroupData> lodGroupData;

		[NativeDisableContainerSafetyRestriction]
		[NoAlias]
		[WriteOnly]
		public NativeList<LODGroupCullingData> lodGroupCullingData;

		[NativeDisableUnsafePtrRestriction]
		public UnsafeAtomicCounter32 atomicUpdateCount;

		public void Execute(int index)
		{
		}
	}
}
