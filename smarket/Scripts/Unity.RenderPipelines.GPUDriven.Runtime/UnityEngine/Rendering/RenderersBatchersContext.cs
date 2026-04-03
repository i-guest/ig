using System;
using Unity.Collections;
using Unity.Jobs;

namespace UnityEngine.Rendering
{
	internal class RenderersBatchersContext : IDisposable
	{
		private InstanceDataSystem m_InstanceDataSystem;

		private GPUResidentDrawerResources m_Resources;

		private GPUDrivenProcessor m_GPUDrivenProcessor;

		private LODGroupDataPool m_LODGroupDataPool;

		internal GPUInstanceDataBuffer m_InstanceDataBuffer;

		private RenderersParameters m_RenderersParameters;

		private GPUInstanceDataBufferUploader.GPUResources m_UploadResources;

		private GPUInstanceDataBufferGrower.GPUResources m_GrowerResources;

		internal CommandBuffer m_CmdBuffer;

		private SphericalHarmonicsL2 m_CachedAmbientProbe;

		private float m_SmallMeshScreenPercentage;

		private GPUDrivenLODGroupDataCallback m_UpdateLODGroupCallback;

		private GPUDrivenLODGroupDataCallback m_TransformLODGroupCallback;

		private OcclusionCullingCommon m_OcclusionCullingCommon;

		private DebugRendererBatcherStats m_DebugStats;

		public RenderersParameters renderersParameters => default(RenderersParameters);

		public GraphicsBuffer gpuInstanceDataBuffer => null;

		public int activeLodGroupCount => 0;

		public NativeArray<GPUInstanceComponentDesc>.ReadOnly defaultDescriptions => default(NativeArray<GPUInstanceComponentDesc>.ReadOnly);

		public NativeArray<MetadataValue> defaultMetadata => default(NativeArray<MetadataValue>);

		public NativeList<LODGroupCullingData> lodGroupCullingData => default(NativeList<LODGroupCullingData>);

		public int instanceDataBufferVersion => 0;

		public int instanceDataBufferLayoutVersion => 0;

		public SphericalHarmonicsL2 cachedAmbientProbe => default(SphericalHarmonicsL2);

		public bool hasBoundingSpheres => false;

		public int cameraCount => 0;

		public CPUInstanceData.ReadOnly instanceData => default(CPUInstanceData.ReadOnly);

		public CPUSharedInstanceData.ReadOnly sharedInstanceData => default(CPUSharedInstanceData.ReadOnly);

		public CPUPerCameraInstanceData perCameraInstanceData => default(CPUPerCameraInstanceData);

		public GPUInstanceDataBuffer.ReadOnly instanceDataBuffer => default(GPUInstanceDataBuffer.ReadOnly);

		public NativeArray<InstanceHandle> aliveInstances => default(NativeArray<InstanceHandle>);

		public float smallMeshScreenPercentage => 0f;

		public GPUResidentDrawerResources resources => null;

		internal OcclusionCullingCommon occlusionCullingCommon => null;

		internal DebugRendererBatcherStats debugStats => null;

		public RenderersBatchersContext(in RenderersBatchersContextDesc desc, GPUDrivenProcessor gpuDrivenProcessor, GPUResidentDrawerResources resources)
		{
		}

		public void Dispose()
		{
		}

		public int GetMaxInstancesOfType(InstanceType instanceType)
		{
			return 0;
		}

		public int GetAliveInstancesOfType(InstanceType instanceType)
		{
			return 0;
		}

		public void GrowInstanceBuffer(in InstanceNumInfo instanceNumInfo)
		{
		}

		private void EnsureInstanceBufferCapacity()
		{
		}

		private void UpdateLODGroupData(in GPUDrivenLODGroupData lodGroupData)
		{
		}

		private void TransformLODGroupData(in GPUDrivenLODGroupData lodGroupData)
		{
		}

		public void DestroyLODGroups(NativeArray<EntityId> destroyed)
		{
		}

		public void UpdateLODGroups(NativeArray<EntityId> changedID)
		{
		}

		public void ReallocateAndGetInstances(in GPUDrivenRendererGroupData rendererData, NativeArray<InstanceHandle> instances)
		{
		}

		public JobHandle ScheduleUpdateInstanceDataJob(NativeArray<InstanceHandle> instances, in GPUDrivenRendererGroupData rendererData)
		{
			return default(JobHandle);
		}

		public void FreeRendererGroupInstances(NativeArray<EntityId> rendererGroupsID)
		{
		}

		public void FreeInstances(NativeArray<InstanceHandle> instances)
		{
		}

		public JobHandle ScheduleQueryRendererGroupInstancesJob(NativeArray<EntityId> rendererGroupIDs, NativeArray<InstanceHandle> instances)
		{
			return default(JobHandle);
		}

		public JobHandle ScheduleQueryRendererGroupInstancesJob(NativeArray<EntityId> rendererGroupIDs, NativeList<InstanceHandle> instances)
		{
			return default(JobHandle);
		}

		public JobHandle ScheduleQueryRendererGroupInstancesJob(NativeArray<EntityId> rendererGroupIDs, NativeArray<int> instancesOffset, NativeArray<int> instancesCount, NativeList<InstanceHandle> instances)
		{
			return default(JobHandle);
		}

		public JobHandle ScheduleQueryMeshInstancesJob(NativeArray<EntityId> sortedMeshIDs, NativeList<InstanceHandle> instances)
		{
			return default(JobHandle);
		}

		public void ChangeInstanceBufferVersion()
		{
		}

		public GPUInstanceDataBufferUploader CreateDataBufferUploader(int capacity, InstanceType instanceType)
		{
			return default(GPUInstanceDataBufferUploader);
		}

		public void SubmitToGpu(NativeArray<InstanceHandle> instances, ref GPUInstanceDataBufferUploader uploader, bool submitOnlyWrittenParams)
		{
		}

		public void SubmitToGpu(NativeArray<GPUInstanceIndex> gpuInstanceIndices, ref GPUInstanceDataBufferUploader uploader, bool submitOnlyWrittenParams)
		{
		}

		public void InitializeInstanceTransforms(NativeArray<InstanceHandle> instances, NativeArray<Matrix4x4> localToWorldMatrices, NativeArray<Matrix4x4> prevLocalToWorldMatrices)
		{
		}

		public void UpdateInstanceTransforms(NativeArray<InstanceHandle> instances, NativeArray<Matrix4x4> localToWorldMatrices)
		{
		}

		public void UpdateAmbientProbeAndGpuBuffer(bool forceUpdate)
		{
		}

		public void UpdateInstanceWindDataHistory(NativeArray<GPUInstanceIndex> gpuInstanceIndices)
		{
		}

		public void UpdateInstanceMotions()
		{
		}

		public void TransformLODGroups(NativeArray<EntityId> lodGroupsID)
		{
		}

		public void UpdatePerFrameInstanceVisibility(in ParallelBitArray compactedVisibilityMasks)
		{
		}

		public JobHandle ScheduleCollectInstancesLODGroupAndMasksJob(NativeArray<InstanceHandle> instances, NativeArray<uint> lodGroupAndMasks)
		{
			return default(JobHandle);
		}

		public InstanceHandle GetRendererInstanceHandle(EntityId rendererID)
		{
			return default(InstanceHandle);
		}

		public void GetVisibleTreeInstances(in ParallelBitArray compactedVisibilityMasks, in ParallelBitArray processedBits, NativeList<int> visibeTreeRendererIDs, NativeList<InstanceHandle> visibeTreeInstances, bool becomeVisibleOnly, out int becomeVisibeTreeInstancesCount)
		{
			becomeVisibeTreeInstancesCount = default(int);
		}

		public GPUInstanceDataBuffer GetInstanceDataBuffer()
		{
			return null;
		}

		public void UpdateFrame()
		{
		}

		public void FreePerCameraInstanceData(NativeArray<EntityId> cameraIDs)
		{
		}

		public void UpdateCameras(NativeArray<EntityId> cameraIDs)
		{
		}
	}
}
