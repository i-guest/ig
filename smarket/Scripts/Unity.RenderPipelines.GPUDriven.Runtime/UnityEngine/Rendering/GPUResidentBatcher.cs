using System;
using System.Collections.Generic;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering
{
	internal class GPUResidentBatcher : IDisposable
	{
		private RenderersBatchersContext m_BatchersContext;

		private GPUDrivenProcessor m_GPUDrivenProcessor;

		private GPUDrivenRendererDataCallback m_UpdateRendererInstancesAndBatchesCallback;

		private GPUDrivenRendererDataCallback m_UpdateRendererBatchesCallback;

		private InstanceCullingBatcher m_InstanceCullingBatcher;

		private ParallelBitArray m_ProcessedThisFrameTreeBits;

		internal RenderersBatchersContext batchersContext => null;

		internal OcclusionCullingCommon occlusionCullingCommon => null;

		internal InstanceCullingBatcher instanceCullingBatcher => null;

		public GPUResidentBatcher(RenderersBatchersContext batcherContext, InstanceCullingBatcherDesc instanceCullerBatcherDesc, GPUDrivenProcessor gpuDrivenProcessor)
		{
		}

		public void Dispose()
		{
		}

		public void OnBeginContextRendering()
		{
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

		public void UpdateFrame()
		{
		}

		public void DestroyMaterials(NativeArray<EntityId> destroyedMaterials)
		{
		}

		public void DestroyDrawInstances(NativeArray<InstanceHandle> instances)
		{
		}

		public void DestroyMeshes(NativeArray<EntityId> destroyedMeshes)
		{
		}

		internal void FreeRendererGroupInstances(NativeArray<EntityId> rendererGroupIDs)
		{
		}

		public void InstanceOcclusionTest(RenderGraph renderGraph, in OcclusionCullingSettings settings, ReadOnlySpan<SubviewOcclusionTest> subviewOcclusionTests)
		{
		}

		public void UpdateInstanceOccluders(RenderGraph renderGraph, in OccluderParameters occluderParams, ReadOnlySpan<OccluderSubviewUpdate> occluderSubviewUpdates)
		{
		}

		public void UpdateRenderers(NativeArray<EntityId> renderersID, bool materialUpdateOnly = false)
		{
		}

		public JobHandle SchedulePackedMaterialCacheUpdate(NativeArray<EntityId> materialIDs, NativeArray<GPUDrivenPackedMaterialData> packedMaterialDatas)
		{
			return default(JobHandle);
		}

		public void PostCullBeginCameraRendering(RenderRequestBatcherContext context)
		{
		}

		public void OnSetupAmbientProbe()
		{
		}

		private void UpdateRendererInstancesAndBatches(in GPUDrivenRendererGroupData rendererData, IList<Mesh> meshes, IList<Material> materials)
		{
		}

		private void UpdateRendererBatches(in GPUDrivenRendererGroupData rendererData, IList<Mesh> meshes, IList<Material> materials)
		{
		}

		private void OnFinishedCulling(IntPtr customCullingResult)
		{
		}

		private void ProcessTrees()
		{
		}

		private void UpdateSpeedTreeWindAndUploadWindParamsToGPU(NativeArray<int> treeRendererIDs, NativeArray<InstanceHandle> treeInstances, bool history)
		{
		}
	}
}
