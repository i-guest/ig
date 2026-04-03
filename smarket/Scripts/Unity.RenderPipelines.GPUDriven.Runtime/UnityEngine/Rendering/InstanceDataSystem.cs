using System;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Mathematics;

namespace UnityEngine.Rendering
{
	internal class InstanceDataSystem : IDisposable
	{
		private static class InstanceTransformUpdateIDs
		{
			public static readonly int _TransformUpdateQueueCount;

			public static readonly int _TransformUpdateOutputL2WVec4Offset;

			public static readonly int _TransformUpdateOutputW2LVec4Offset;

			public static readonly int _TransformUpdateOutputPrevL2WVec4Offset;

			public static readonly int _TransformUpdateOutputPrevW2LVec4Offset;

			public static readonly int _BoundingSphereOutputVec4Offset;

			public static readonly int _TransformUpdateDataQueue;

			public static readonly int _TransformUpdateIndexQueue;

			public static readonly int _BoundingSphereDataQueue;

			public static readonly int _OutputTransformBuffer;

			public static readonly int _ProbeUpdateQueueCount;

			public static readonly int _SHUpdateVec4Offset;

			public static readonly int _ProbeUpdateDataQueue;

			public static readonly int _ProbeOcclusionUpdateDataQueue;

			public static readonly int _ProbeUpdateIndexQueue;

			public static readonly int _OutputProbeBuffer;
		}

		private static class InstanceWindDataUpdateIDs
		{
			public static readonly int _WindDataQueueCount;

			public static readonly int _WindDataUpdateIndexQueue;

			public static readonly int _WindDataBuffer;

			public static readonly int _WindParamAddressArray;

			public static readonly int _WindHistoryParamAddressArray;
		}

		[BurstCompile(DisableSafetyChecks = true, OptimizeFor = OptimizeFor.Performance)]
		private struct QueryRendererGroupInstancesCountJob : IJobParallelForBatch
		{
			public const int k_BatchSize = 128;

			[ReadOnly]
			public CPUInstanceData instanceData;

			[ReadOnly]
			public CPUSharedInstanceData sharedInstanceData;

			[ReadOnly]
			public NativeParallelMultiHashMap<int, InstanceHandle> rendererGroupInstanceMultiHash;

			[NativeDisableContainerSafetyRestriction]
			[NoAlias]
			[ReadOnly]
			public NativeArray<EntityId> rendererGroupIDs;

			[NativeDisableContainerSafetyRestriction]
			[NoAlias]
			[WriteOnly]
			public NativeArray<int> instancesCount;

			public void Execute(int startIndex, int count)
			{
			}
		}

		[BurstCompile(DisableSafetyChecks = true, OptimizeFor = OptimizeFor.Performance)]
		private struct ComputeInstancesOffsetAndResizeInstancesArrayJob : IJob
		{
			[ReadOnly]
			public NativeArray<int> instancesCount;

			[WriteOnly]
			public NativeArray<int> instancesOffset;

			public NativeList<InstanceHandle> instances;

			public void Execute()
			{
			}
		}

		[BurstCompile(DisableSafetyChecks = true, OptimizeFor = OptimizeFor.Performance)]
		private struct QueryRendererGroupInstancesJob : IJobParallelForBatch
		{
			public const int k_BatchSize = 128;

			[ReadOnly]
			public NativeParallelMultiHashMap<int, InstanceHandle> rendererGroupInstanceMultiHash;

			[NativeDisableContainerSafetyRestriction]
			[NoAlias]
			[ReadOnly]
			public NativeArray<EntityId> rendererGroupIDs;

			[NativeDisableContainerSafetyRestriction]
			[NoAlias]
			[WriteOnly]
			public NativeArray<InstanceHandle> instances;

			[NativeDisableUnsafePtrRestriction]
			public UnsafeAtomicCounter32 atomicNonFoundInstancesCount;

			public void Execute(int startIndex, int count)
			{
			}
		}

		[BurstCompile(DisableSafetyChecks = true, OptimizeFor = OptimizeFor.Performance)]
		private struct QueryRendererGroupInstancesMultiJob : IJobParallelForBatch
		{
			public const int k_BatchSize = 128;

			[ReadOnly]
			public NativeParallelMultiHashMap<int, InstanceHandle> rendererGroupInstanceMultiHash;

			[NativeDisableContainerSafetyRestriction]
			[NoAlias]
			[ReadOnly]
			public NativeArray<EntityId> rendererGroupIDs;

			[NativeDisableContainerSafetyRestriction]
			[NoAlias]
			[ReadOnly]
			public NativeArray<int> instancesOffsets;

			[NativeDisableContainerSafetyRestriction]
			[NoAlias]
			[ReadOnly]
			public NativeArray<int> instancesCounts;

			[NativeDisableContainerSafetyRestriction]
			[NoAlias]
			[WriteOnly]
			public NativeArray<InstanceHandle> instances;

			[NativeDisableUnsafePtrRestriction]
			public UnsafeAtomicCounter32 atomicNonFoundSharedInstancesCount;

			[NativeDisableUnsafePtrRestriction]
			public UnsafeAtomicCounter32 atomicNonFoundInstancesCount;

			public void Execute(int startIndex, int count)
			{
			}
		}

		[BurstCompile(DisableSafetyChecks = true, OptimizeFor = OptimizeFor.Performance)]
		private struct QuerySortedMeshInstancesJob : IJobParallelForBatch
		{
			public const int k_BatchSize = 64;

			[ReadOnly]
			public CPUInstanceData instanceData;

			[ReadOnly]
			public CPUSharedInstanceData sharedInstanceData;

			[ReadOnly]
			public NativeArray<EntityId> sortedMeshID;

			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeList<InstanceHandle> instances;

			public void Execute(int startIndex, int count)
			{
			}
		}

		[BurstCompile(DisableSafetyChecks = true, OptimizeFor = OptimizeFor.Performance)]
		private struct CalculateInterpolatedLightAndOcclusionProbesBatchJob : IJobParallelFor
		{
			public const int k_BatchSize = 1;

			public const int k_CalculatedProbesPerBatch = 8;

			[ReadOnly]
			public int probesCount;

			[ReadOnly]
			public LightProbesQuery lightProbesQuery;

			[NativeDisableParallelForRestriction]
			[ReadOnly]
			public NativeArray<Vector3> queryPostitions;

			[NativeDisableParallelForRestriction]
			public NativeArray<int> compactTetrahedronCache;

			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<SphericalHarmonicsL2> probesSphericalHarmonics;

			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<Vector4> probesOcclusion;

			public void Execute(int index)
			{
			}
		}

		[BurstCompile(DisableSafetyChecks = true, OptimizeFor = OptimizeFor.Performance)]
		private struct ScatterTetrahedronCacheIndicesJob : IJobParallelFor
		{
			public const int k_BatchSize = 128;

			[ReadOnly]
			public NativeArray<InstanceHandle> probeInstances;

			[ReadOnly]
			public NativeArray<int> compactTetrahedronCache;

			[NativeDisableContainerSafetyRestriction]
			[NoAlias]
			[NativeDisableParallelForRestriction]
			public CPUInstanceData instanceData;

			public void Execute(int index)
			{
			}
		}

		[BurstCompile(DisableSafetyChecks = true, OptimizeFor = OptimizeFor.Performance)]
		private struct TransformUpdateJob : IJobParallelForBatch
		{
			public const int k_BatchSize = 64;

			[ReadOnly]
			public bool initialize;

			[ReadOnly]
			public bool enableBoundingSpheres;

			[ReadOnly]
			public NativeArray<InstanceHandle> instances;

			[ReadOnly]
			public NativeArray<Matrix4x4> localToWorldMatrices;

			[ReadOnly]
			public NativeArray<Matrix4x4> prevLocalToWorldMatrices;

			[NativeDisableUnsafePtrRestriction]
			public UnsafeAtomicCounter32 atomicTransformQueueCount;

			[NativeDisableParallelForRestriction]
			public CPUSharedInstanceData sharedInstanceData;

			[NativeDisableParallelForRestriction]
			public CPUInstanceData instanceData;

			[NativeDisableParallelForRestriction]
			public NativeArray<InstanceHandle> transformUpdateInstanceQueue;

			[NativeDisableParallelForRestriction]
			public NativeArray<TransformUpdatePacket> transformUpdateDataQueue;

			[NativeDisableParallelForRestriction]
			public NativeArray<float4> boundingSpheresDataQueue;

			public void Execute(int startIndex, int count)
			{
			}
		}

		[BurstCompile(DisableSafetyChecks = true, OptimizeFor = OptimizeFor.Performance)]
		private struct ProbesUpdateJob : IJobParallelForBatch
		{
			public const int k_BatchSize = 64;

			[NativeDisableContainerSafetyRestriction]
			[NoAlias]
			[ReadOnly]
			public NativeArray<InstanceHandle> instances;

			[NativeDisableParallelForRestriction]
			[NativeDisableContainerSafetyRestriction]
			[NoAlias]
			public CPUInstanceData instanceData;

			[ReadOnly]
			public CPUSharedInstanceData sharedInstanceData;

			[NativeDisableUnsafePtrRestriction]
			public UnsafeAtomicCounter32 atomicProbesQueueCount;

			[NativeDisableParallelForRestriction]
			public NativeArray<InstanceHandle> probeInstanceQueue;

			[NativeDisableParallelForRestriction]
			public NativeArray<int> compactTetrahedronCache;

			[NativeDisableParallelForRestriction]
			public NativeArray<Vector3> probeQueryPosition;

			public void Execute(int startIndex, int count)
			{
			}
		}

		[BurstCompile(DisableSafetyChecks = true, OptimizeFor = OptimizeFor.Performance)]
		private struct MotionUpdateJob : IJobParallelFor
		{
			public const int k_BatchSize = 16;

			[ReadOnly]
			public int queueWriteBase;

			[NativeDisableParallelForRestriction]
			public CPUInstanceData instanceData;

			[NativeDisableUnsafePtrRestriction]
			public UnsafeAtomicCounter32 atomicUpdateQueueCount;

			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<InstanceHandle> transformUpdateInstanceQueue;

			public void Execute(int chunk_index)
			{
			}
		}

		[BurstCompile(DisableSafetyChecks = true, OptimizeFor = OptimizeFor.Performance)]
		private struct UpdateRendererInstancesJob : IJobParallelFor
		{
			public const int k_BatchSize = 128;

			[ReadOnly]
			public bool implicitInstanceIndices;

			[ReadOnly]
			public GPUDrivenRendererGroupData rendererData;

			[ReadOnly]
			public NativeArray<InstanceHandle> instances;

			[ReadOnly]
			public NativeParallelHashMap<int, GPUInstanceIndex> lodGroupDataMap;

			[NativeDisableParallelForRestriction]
			[NativeDisableContainerSafetyRestriction]
			[NoAlias]
			public CPUInstanceData instanceData;

			[NativeDisableParallelForRestriction]
			[NativeDisableContainerSafetyRestriction]
			[NoAlias]
			public CPUSharedInstanceData sharedInstanceData;

			[NativeDisableParallelForRestriction]
			[NativeDisableContainerSafetyRestriction]
			[NoAlias]
			public CPUPerCameraInstanceData perCameraInstanceData;

			public void Execute(int index)
			{
			}
		}

		[BurstCompile(DisableSafetyChecks = true, OptimizeFor = OptimizeFor.Performance)]
		private struct CollectInstancesLODGroupsAndMasksJob : IJobParallelFor
		{
			public const int k_BatchSize = 128;

			[ReadOnly]
			public NativeArray<InstanceHandle> instances;

			[ReadOnly]
			public CPUInstanceData.ReadOnly instanceData;

			[ReadOnly]
			public CPUSharedInstanceData.ReadOnly sharedInstanceData;

			[WriteOnly]
			public NativeArray<uint> lodGroupAndMasks;

			public void Execute(int index)
			{
			}
		}

		[BurstCompile(DisableSafetyChecks = true, OptimizeFor = OptimizeFor.Performance)]
		private struct GetVisibleNonProcessedTreeInstancesJob : IJobParallelForBatch
		{
			public const int k_BatchSize = 64;

			[ReadOnly]
			public CPUInstanceData instanceData;

			[ReadOnly]
			public CPUSharedInstanceData sharedInstanceData;

			[ReadOnly]
			[NativeDisableContainerSafetyRestriction]
			[NoAlias]
			public ParallelBitArray compactedVisibilityMasks;

			[ReadOnly]
			public bool becomeVisible;

			[NativeDisableParallelForRestriction]
			public ParallelBitArray processedBits;

			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<int> rendererIDs;

			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<InstanceHandle> instances;

			[NativeDisableUnsafePtrRestriction]
			public UnsafeAtomicCounter32 atomicTreeInstancesCount;

			public void Execute(int startIndex, int count)
			{
			}
		}

		[BurstCompile(DisableSafetyChecks = true, OptimizeFor = OptimizeFor.Performance)]
		private struct UpdateCompactedInstanceVisibilityJob : IJobParallelForBatch
		{
			public const int k_BatchSize = 64;

			[ReadOnly]
			public ParallelBitArray compactedVisibilityMasks;

			[NativeDisableContainerSafetyRestriction]
			[NoAlias]
			[NativeDisableParallelForRestriction]
			public CPUInstanceData instanceData;

			public void Execute(int startIndex, int count)
			{
			}
		}

		private InstanceAllocators m_InstanceAllocators;

		private CPUSharedInstanceData m_SharedInstanceData;

		private CPUInstanceData m_InstanceData;

		private CPUPerCameraInstanceData m_PerCameraInstanceData;

		private NativeParallelMultiHashMap<int, InstanceHandle> m_RendererGroupInstanceMultiHash;

		private ComputeShader m_TransformUpdateCS;

		private ComputeShader m_WindDataUpdateCS;

		private int m_TransformInitKernel;

		private int m_TransformUpdateKernel;

		private int m_MotionUpdateKernel;

		private int m_ProbeUpdateKernel;

		private int m_LODUpdateKernel;

		private int m_WindDataCopyHistoryKernel;

		private ComputeBuffer m_UpdateIndexQueueBuffer;

		private ComputeBuffer m_ProbeUpdateDataQueueBuffer;

		private ComputeBuffer m_ProbeOcclusionUpdateDataQueueBuffer;

		private ComputeBuffer m_TransformUpdateDataQueueBuffer;

		private ComputeBuffer m_BoundingSpheresUpdateDataQueueBuffer;

		private bool m_EnableBoundingSpheres;

		private readonly int[] m_ScratchWindParamAddressArray;

		public bool hasBoundingSpheres => false;

		public CPUInstanceData.ReadOnly instanceData => default(CPUInstanceData.ReadOnly);

		public CPUPerCameraInstanceData perCameraInstanceData => default(CPUPerCameraInstanceData);

		public int cameraCount => 0;

		public CPUSharedInstanceData.ReadOnly sharedInstanceData => default(CPUSharedInstanceData.ReadOnly);

		public NativeArray<InstanceHandle> aliveInstances => default(NativeArray<InstanceHandle>);

		public InstanceDataSystem(int maxInstances, bool enableBoundingSpheres, GPUResidentDrawerResources resources)
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

		private void EnsureIndexQueueBufferCapacity(int capacity)
		{
		}

		private void EnsureProbeBuffersCapacity(int capacity)
		{
		}

		private void EnsureTransformBuffersCapacity(int capacity)
		{
		}

		private JobHandle ScheduleInterpolateProbesAndUpdateTetrahedronCache(int queueCount, NativeArray<InstanceHandle> probeUpdateInstanceQueue, NativeArray<int> compactTetrahedronCache, NativeArray<Vector3> probeQueryPosition, NativeArray<SphericalHarmonicsL2> probeUpdateDataQueue, NativeArray<Vector4> probeOcclusionUpdateDataQueue)
		{
			return default(JobHandle);
		}

		private void DispatchProbeUpdateCommand(int queueCount, NativeArray<InstanceHandle> probeInstanceQueue, NativeArray<SphericalHarmonicsL2> probeUpdateDataQueue, NativeArray<Vector4> probeOcclusionUpdateDataQueue, RenderersParameters renderersParameters, GPUInstanceDataBuffer outputBuffer)
		{
		}

		private void DispatchMotionUpdateCommand(int motionQueueCount, NativeArray<InstanceHandle> transformInstanceQueue, RenderersParameters renderersParameters, GPUInstanceDataBuffer outputBuffer)
		{
		}

		private void DispatchTransformUpdateCommand(bool initialize, int transformQueueCount, NativeArray<InstanceHandle> transformInstanceQueue, NativeArray<TransformUpdatePacket> updateDataQueue, NativeArray<float4> boundingSphereUpdateDataQueue, RenderersParameters renderersParameters, GPUInstanceDataBuffer outputBuffer)
		{
		}

		private void DispatchWindDataCopyHistoryCommand(NativeArray<GPUInstanceIndex> gpuInstanceIndices, RenderersParameters renderersParameters, GPUInstanceDataBuffer outputBuffer)
		{
		}

		private void UpdateInstanceMotionsData(in RenderersParameters renderersParameters, GPUInstanceDataBuffer outputBuffer)
		{
		}

		private void UpdateInstanceTransformsData(bool initialize, NativeArray<InstanceHandle> instances, NativeArray<Matrix4x4> localToWorldMatrices, NativeArray<Matrix4x4> prevLocalToWorldMatrices, in RenderersParameters renderersParameters, GPUInstanceDataBuffer outputBuffer)
		{
		}

		private void UpdateInstanceProbesData(NativeArray<InstanceHandle> instances, in RenderersParameters renderersParameters, GPUInstanceDataBuffer outputBuffer)
		{
		}

		public void UpdateInstanceWindDataHistory(NativeArray<GPUInstanceIndex> gpuInstanceIndices, RenderersParameters renderersParameters, GPUInstanceDataBuffer outputBuffer)
		{
		}

		public void ReallocateAndGetInstances(in GPUDrivenRendererGroupData rendererData, NativeArray<InstanceHandle> instances)
		{
		}

		public void FreeRendererGroupInstances(NativeArray<EntityId> rendererGroupsID)
		{
		}

		public void FreeInstances(NativeArray<InstanceHandle> instances)
		{
		}

		public JobHandle ScheduleUpdateInstanceDataJob(NativeArray<InstanceHandle> instances, in GPUDrivenRendererGroupData rendererData, NativeParallelHashMap<int, GPUInstanceIndex> lodGroupDataMap)
		{
			return default(JobHandle);
		}

		public void UpdateAllInstanceProbes(in RenderersParameters renderersParameters, GPUInstanceDataBuffer outputBuffer)
		{
		}

		public void InitializeInstanceTransforms(NativeArray<InstanceHandle> instances, NativeArray<Matrix4x4> localToWorldMatrices, NativeArray<Matrix4x4> prevLocalToWorldMatrices, in RenderersParameters renderersParameters, GPUInstanceDataBuffer outputBuffer)
		{
		}

		public void UpdateInstanceTransforms(NativeArray<InstanceHandle> instances, NativeArray<Matrix4x4> localToWorldMatrices, in RenderersParameters renderersParameters, GPUInstanceDataBuffer outputBuffer)
		{
		}

		public void UpdateInstanceMotions(in RenderersParameters renderersParameters, GPUInstanceDataBuffer outputBuffer)
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

		public JobHandle ScheduleQuerySortedMeshInstancesJob(NativeArray<EntityId> sortedMeshIDs, NativeList<InstanceHandle> instances)
		{
			return default(JobHandle);
		}

		public JobHandle ScheduleCollectInstancesLODGroupAndMasksJob(NativeArray<InstanceHandle> instances, NativeArray<uint> lodGroupAndMasks)
		{
			return default(JobHandle);
		}

		public bool InternalSanityCheckStates()
		{
			return false;
		}

		public void GetVisibleTreeInstances(in ParallelBitArray compactedVisibilityMasks, in ParallelBitArray processedBits, NativeList<int> visibeTreeRendererIDs, NativeList<InstanceHandle> visibeTreeInstances, bool becomeVisibleOnly, out int becomeVisibeTreeInstancesCount)
		{
			becomeVisibeTreeInstancesCount = default(int);
		}

		public void UpdatePerFrameInstanceVisibility(in ParallelBitArray compactedVisibilityMasks)
		{
		}

		public void DeallocatePerCameraInstanceData(NativeArray<EntityId> cameraIDs)
		{
		}

		public void AllocatePerCameraInstanceData(NativeArray<EntityId> cameraIDs)
		{
		}

		private static int AtomicAddLengthNoResize<T>(in NativeList<T> list, int count) where T : struct
		{
			return 0;
		}
	}
}
