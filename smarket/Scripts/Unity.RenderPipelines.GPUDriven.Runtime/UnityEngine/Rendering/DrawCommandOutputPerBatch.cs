using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;

namespace UnityEngine.Rendering
{
	[BurstCompile(DisableSafetyChecks = true, OptimizeFor = OptimizeFor.Performance)]
	internal struct DrawCommandOutputPerBatch : IJobParallelFor
	{
		[ReadOnly]
		public BinningConfig binningConfig;

		[ReadOnly]
		public NativeParallelHashMap<uint, BatchID> batchIDs;

		[ReadOnly]
		public GPUInstanceDataBuffer.ReadOnly instanceDataBuffer;

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

		[ReadOnly]
		public NativeArray<byte> rendererCrossFadeValues;

		[ReadOnly]
		[DeallocateOnJobCompletion]
		public NativeArray<int> batchBinAllocOffsets;

		[ReadOnly]
		[DeallocateOnJobCompletion]
		public NativeArray<int> batchBinCounts;

		[ReadOnly]
		[DeallocateOnJobCompletion]
		public NativeArray<int> batchDrawCommandOffsets;

		[ReadOnly]
		[DeallocateOnJobCompletion]
		public NativeArray<short> binConfigIndices;

		[ReadOnly]
		[DeallocateOnJobCompletion]
		public NativeArray<int> binVisibleInstanceOffsets;

		[ReadOnly]
		[DeallocateOnJobCompletion]
		public NativeArray<int> binVisibleInstanceCounts;

		[ReadOnly]
		public NativeArray<BatchCullingOutputDrawCommands> cullingOutput;

		[ReadOnly]
		public IndirectBufferLimits indirectBufferLimits;

		[ReadOnly]
		public GraphicsBufferHandle visibleInstancesBufferHandle;

		[ReadOnly]
		public GraphicsBufferHandle indirectArgsBufferHandle;

		[NativeDisableContainerSafetyRestriction]
		[NoAlias]
		public NativeArray<IndirectBufferAllocInfo> indirectBufferAllocInfo;

		[NativeDisableContainerSafetyRestriction]
		[NoAlias]
		public NativeArray<IndirectDrawInfo> indirectDrawInfoGlobalArray;

		[NativeDisableContainerSafetyRestriction]
		[NoAlias]
		public NativeArray<IndirectInstanceInfo> indirectInstanceInfoGlobalArray;

		private int EncodeGPUInstanceIndexAndCrossFade(int rendererIndex, bool negateCrossFade)
		{
			return 0;
		}

		private bool IsInstanceFlipped(int rendererIndex)
		{
			return false;
		}

		private bool IsMeshLodVisible(int batchLodLevel, int rendererIndex, bool supportsCrossFade, ref bool negateCrossfade)
		{
			return false;
		}

		public void Execute(int batchIndex)
		{
		}
	}
}
