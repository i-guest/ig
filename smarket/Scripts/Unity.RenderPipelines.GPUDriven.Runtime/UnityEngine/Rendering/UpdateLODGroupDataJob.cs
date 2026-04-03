using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;

namespace UnityEngine.Rendering
{
	[BurstCompile(DisableSafetyChecks = true, OptimizeFor = OptimizeFor.Performance)]
	internal struct UpdateLODGroupDataJob : IJobParallelFor
	{
		public const int k_BatchSize = 256;

		[ReadOnly]
		public NativeArray<GPUInstanceIndex> lodGroupInstances;

		[ReadOnly]
		public GPUDrivenLODGroupData inputData;

		[ReadOnly]
		public bool supportDitheringCrossFade;

		public NativeArray<LODGroupData> lodGroupsData;

		public NativeArray<LODGroupCullingData> lodGroupsCullingData;

		[NativeDisableUnsafePtrRestriction]
		public UnsafeAtomicCounter32 rendererCount;

		public void Execute(int index)
		{
		}
	}
}
