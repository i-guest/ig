using System;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering
{
	internal struct InstanceCuller : IDisposable
	{
		private struct AnimatedFadeData
		{
			public int cameraID;

			public JobHandle jobHandle;
		}

		private static class ShaderIDs
		{
			public static readonly int InstanceOcclusionCullerShaderVariables;

			public static readonly int _DrawInfo;

			public static readonly int _InstanceInfo;

			public static readonly int _DispatchArgs;

			public static readonly int _DrawArgs;

			public static readonly int _InstanceIndices;

			public static readonly int _InstanceDataBuffer;

			public static readonly int _OccluderDepthPyramid;

			public static readonly int _OcclusionDebugCounters;
		}

		private class InstanceOcclusionTestPassData
		{
			public OcclusionCullingSettings settings;

			public InstanceOcclusionTestSubviewSettings subviewSettings;

			public OccluderHandles occluderHandles;

			public IndirectBufferContextHandles bufferHandles;
		}

		private NativeParallelHashMap<int, AnimatedFadeData> m_LODParamsToCameraID;

		private ParallelBitArray m_CompactedVisibilityMasks;

		private JobHandle m_CompactedVisibilityMasksJobsHandle;

		private IndirectBufferContextStorage m_IndirectStorage;

		private OcclusionTestComputeShader m_OcclusionTestShader;

		private int m_ResetDrawArgsKernel;

		private int m_CopyInstancesKernel;

		private int m_CullInstancesKernel;

		private DebugRendererBatcherStats m_DebugStats;

		private InstanceCullerSplitDebugArray m_SplitDebugArray;

		private InstanceOcclusionEventDebugArray m_OcclusionEventDebugArray;

		private ProfilingSampler m_ProfilingSampleInstanceOcclusionTest;

		private NativeArray<InstanceOcclusionCullerShaderVariables> m_ShaderVariables;

		private ComputeBuffer m_ConstantBuffer;

		private CommandBuffer m_CommandBuffer;

		internal void Init(GPUResidentDrawerResources resources, DebugRendererBatcherStats debugStats = null)
		{
		}

		private JobHandle AnimateCrossFades(CPUPerCameraInstanceData perCameraInstanceData, BatchCullingContext cc, out CPUPerCameraInstanceData.PerCameraInstanceDataArrays cameraInstanceData, out bool hasAnimatedCrossfade)
		{
			cameraInstanceData = default(CPUPerCameraInstanceData.PerCameraInstanceDataArrays);
			hasAnimatedCrossfade = default(bool);
			return default(JobHandle);
		}

		private JobHandle CreateFrustumCullingJob(in BatchCullingContext cc, in CPUInstanceData.ReadOnly instanceData, in CPUSharedInstanceData.ReadOnly sharedInstanceData, in CPUPerCameraInstanceData perCameraInstanceData, NativeList<LODGroupCullingData> lodGroupCullingData, in BinningConfig binningConfig, float smallMeshScreenPercentage, OcclusionCullingCommon occlusionCullingCommon, NativeArray<byte> rendererVisibilityMasks, NativeArray<byte> rendererMeshLodSettings, NativeArray<byte> rendererCrossFadeValues)
		{
			return default(JobHandle);
		}

		private int ComputeWorstCaseDrawCommandCount(in BatchCullingContext cc, BinningConfig binningConfig, CPUDrawInstanceData drawInstanceData)
		{
			return 0;
		}

		public JobHandle CreateCullJobTree(in BatchCullingContext cc, BatchCullingOutput cullingOutput, in CPUInstanceData.ReadOnly instanceData, in CPUSharedInstanceData.ReadOnly sharedInstanceData, in CPUPerCameraInstanceData perCameraInstanceData, in GPUInstanceDataBuffer.ReadOnly instanceDataBuffer, NativeList<LODGroupCullingData> lodGroupCullingData, CPUDrawInstanceData drawInstanceData, NativeParallelHashMap<uint, BatchID> batchIDs, float smallMeshScreenPercentage, OcclusionCullingCommon occlusionCullingCommon)
		{
			return default(JobHandle);
		}

		private JobHandle CreateCompactedVisibilityMaskJob(in CPUInstanceData.ReadOnly instanceData, NativeArray<byte> rendererVisibilityMasks, JobHandle cullingJobHandle)
		{
			return default(JobHandle);
		}

		public void InstanceOccludersUpdated(int viewInstanceID, int subviewMask, RenderersBatchersContext batchersContext)
		{
		}

		private void DisposeCompactVisibilityMasks()
		{
		}

		private void DisposeSceneViewHiddenBits()
		{
		}

		public ParallelBitArray GetCompactedVisibilityMasks(bool syncCullingJobs)
		{
			return default(ParallelBitArray);
		}

		public void InstanceOcclusionTest(RenderGraph renderGraph, in OcclusionCullingSettings settings, ReadOnlySpan<SubviewOcclusionTest> subviewOcclusionTests, RenderersBatchersContext batchersContext)
		{
		}

		internal void EnsureValidOcclusionTestResults(int viewInstanceID)
		{
		}

		private void AddOcclusionCullingDispatch(ComputeCommandBuffer cmd, in OcclusionCullingSettings settings, in InstanceOcclusionTestSubviewSettings subviewSettings, in IndirectBufferContextHandles bufferHandles, in OccluderHandles occluderHandles, RenderersBatchersContext batchersContext)
		{
		}

		private void FlushDebugCounters()
		{
		}

		private void OnBeginSceneViewCameraRendering()
		{
		}

		private void OnEndSceneViewCameraRendering()
		{
		}

		public void UpdateFrame(int cameraCount)
		{
		}

		public void OnBeginCameraRendering(Camera camera)
		{
		}

		public void OnEndCameraRendering(Camera camera)
		{
		}

		public void Dispose()
		{
		}
	}
}
