using System;
using Unity.Collections;
using Unity.Jobs;

namespace UnityEngine.Rendering
{
	internal class InstanceCullingBatcher : IDisposable
	{
		private RenderersBatchersContext m_BatchersContext;

		private CPUDrawInstanceData m_DrawInstanceData;

		private BatchRendererGroup m_BRG;

		private NativeParallelHashMap<uint, BatchID> m_GlobalBatchIDs;

		private InstanceCuller m_Culler;

		private NativeParallelHashMap<EntityId, BatchMaterialID> m_BatchMaterialHash;

		private NativeParallelHashMap<EntityId, GPUDrivenPackedMaterialData> m_PackedMaterialHash;

		private NativeParallelHashMap<EntityId, BatchMeshID> m_BatchMeshHash;

		private int m_CachedInstanceDataBufferLayoutVersion;

		private OnCullingCompleteCallback m_OnCompleteCallback;

		public NativeParallelHashMap<EntityId, BatchMaterialID> batchMaterialHash => default(NativeParallelHashMap<EntityId, BatchMaterialID>);

		public NativeParallelHashMap<EntityId, GPUDrivenPackedMaterialData> packedMaterialHash => default(NativeParallelHashMap<EntityId, GPUDrivenPackedMaterialData>);

		internal ref InstanceCuller culler
		{
			get
			{
				throw null;
			}
		}

		public InstanceCullingBatcher(RenderersBatchersContext batcherContext, InstanceCullingBatcherDesc desc, BatchRendererGroup.OnFinishedCulling onFinishedCulling)
		{
		}

		public void Dispose()
		{
		}

		private BatchID GetBatchID(InstanceComponentGroup componentsOverriden)
		{
			return default(BatchID);
		}

		private void UpdateInstanceDataBufferLayoutVersion()
		{
		}

		public CPUDrawInstanceData GetDrawInstanceData()
		{
			return null;
		}

		public JobHandle OnPerformCulling(BatchRendererGroup rendererGroup, BatchCullingContext cc, BatchCullingOutput cullingOutput, IntPtr userContext)
		{
			return default(JobHandle);
		}

		public void OnFinishedCulling(IntPtr customCullingResult)
		{
		}

		public void DestroyDrawInstances(NativeArray<InstanceHandle> instances)
		{
		}

		public void DestroyMaterials(NativeArray<EntityId> destroyedMaterials)
		{
		}

		public void DestroyMeshes(NativeArray<EntityId> destroyedMeshes)
		{
		}

		public void PostCullBeginCameraRendering(RenderRequestBatcherContext context)
		{
		}

		private void RegisterBatchMeshes(NativeArray<EntityId> meshIDs)
		{
		}

		private void RegisterBatchMaterials(in NativeArray<EntityId> usedMaterialIDs, in NativeArray<GPUDrivenPackedMaterialData> usedPackedMaterialDatas)
		{
		}

		public JobHandle SchedulePackedMaterialCacheUpdate(NativeArray<EntityId> materialIDs, NativeArray<GPUDrivenPackedMaterialData> packedMaterialDatas)
		{
			return default(JobHandle);
		}

		public void BuildBatch(NativeArray<InstanceHandle> instances, in GPUDrivenRendererGroupData rendererData, bool registerMaterialsAndMeshes)
		{
		}

		public void InstanceOccludersUpdated(int viewInstanceID, int subviewMask)
		{
		}

		public void UpdateFrame()
		{
		}

		public ParallelBitArray GetCompactedVisibilityMasks(bool syncCullingJobs)
		{
			return default(ParallelBitArray);
		}

		public void OnEndContextRendering()
		{
		}

		public void OnBeginCameraRendering(Camera camera)
		{
		}

		public void OnEndCameraRendering(Camera camera)
		{
		}
	}
}
