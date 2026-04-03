using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;

namespace UnityEngine.Rendering
{
	[BurstCompile(DisableSafetyChecks = true, OptimizeFor = OptimizeFor.Performance)]
	internal struct AllocateBinsPerBatch : IJobParallelFor
	{
		[ReadOnly]
		public BinningConfig binningConfig;

		[ReadOnly]
		public NativeList<DrawBatch> drawBatches;

		[ReadOnly]
		public NativeArray<int> drawInstanceIndices;

		[ReadOnly]
		public CPUInstanceData.ReadOnly instanceData;

		[ReadOnly]
		public NativeArray<byte> rendererVisibilityMasks;

		[ReadOnly]
		public NativeArray<byte> rendererMeshLodSettings;

		[NativeDisableContainerSafetyRestriction]
		[NoAlias]
		[WriteOnly]
		public NativeArray<int> batchBinAllocOffsets;

		[NativeDisableContainerSafetyRestriction]
		[NoAlias]
		[WriteOnly]
		public NativeArray<int> batchBinCounts;

		[NativeDisableContainerSafetyRestriction]
		[NoAlias]
		[DeallocateOnJobCompletion]
		public NativeArray<int> binAllocCounter;

		[NativeDisableContainerSafetyRestriction]
		[NoAlias]
		[WriteOnly]
		public NativeArray<short> binConfigIndices;

		[NativeDisableContainerSafetyRestriction]
		[NoAlias]
		[WriteOnly]
		public NativeArray<int> binVisibleInstanceCounts;

		[ReadOnly]
		public int debugCounterIndexBase;

		[NativeDisableContainerSafetyRestriction]
		[NoAlias]
		public NativeArray<int> splitDebugCounters;

		private bool IsInstanceFlipped(int rendererIndex)
		{
			return false;
		}

		private bool IsMeshLodVisible(int batchLodLevel, int rendererIndex, bool supportsCrossFade)
		{
			return false;
		}

		private static int GetPrimitiveCount(int indexCount, MeshTopology topology, bool nativeQuads)
		{
			return 0;
		}

		public void Execute(int batchIndex)
		{
		}
	}
}
