using System;
using System.Collections.Generic;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine.Rendering.RenderGraphModule;
using UnityEngine.SceneManagement;

namespace UnityEngine.Rendering
{
	public class GPUResidentDrawer
	{
		[BurstCompile(DisableSafetyChecks = true, OptimizeFor = OptimizeFor.Performance)]
		private struct FindRenderersFromMaterialOrMeshJob : IJobParallelForBatch
		{
			public const int k_BatchSize = 128;

			[ReadOnly]
			public NativeHashSet<EntityId>.ReadOnly materialIDs;

			[ReadOnly]
			public NativeArray<SmallEntityIdArray>.ReadOnly materialIDArrays;

			[ReadOnly]
			public NativeArray<EntityId>.ReadOnly meshIDs;

			[ReadOnly]
			public NativeArray<EntityId>.ReadOnly meshIDArray;

			[ReadOnly]
			public NativeArray<EntityId>.ReadOnly rendererGroupIDs;

			[ReadOnly]
			public NativeArray<EntityId>.ReadOnly sortedExcludeRendererIDs;

			[WriteOnly]
			public NativeList<EntityId>.ParallelWriter selectedRenderGroupsForMaterials;

			[WriteOnly]
			public NativeList<EntityId>.ParallelWriter selectedRenderGroupsForMeshes;

			public void Execute(int startIndex, int count)
			{
			}
		}

		private static class Strings
		{
			public static readonly string drawerModeDisabled;

			public static readonly string allowInEditModeDisabled;

			public static readonly string notGPUResidentRenderPipeline;

			public static readonly string rawBufferNotSupportedByPlatform;

			public static readonly string kernelNotPresent;

			public static readonly string batchRendererGroupShaderStrippingModeInvalid;

			public static readonly string visionOSNotSupported;
		}

		private static GPUResidentDrawer s_Instance;

		private IntPtr m_ContextIntPtr;

		private GPUResidentDrawerSettings m_Settings;

		private GPUDrivenProcessor m_GPUDrivenProcessor;

		private RenderersBatchersContext m_BatchersContext;

		private GPUResidentBatcher m_Batcher;

		private ObjectDispatcher m_Dispatcher;

		internal static GPUResidentDrawer instance => null;

		internal static bool MaintainContext { get; set; }

		internal static bool ForceOcclusion { get; set; }

		internal GPUResidentBatcher batcher => null;

		internal GPUResidentDrawerSettings settings => default(GPUResidentDrawerSettings);

		public static bool IsInstanceOcclusionCullingEnabled()
		{
			return false;
		}

		public static void PostCullBeginCameraRendering(RenderRequestBatcherContext context)
		{
		}

		public static void OnSetupAmbientProbe()
		{
		}

		public static void InstanceOcclusionTest(RenderGraph renderGraph, in OcclusionCullingSettings settings, ReadOnlySpan<SubviewOcclusionTest> subviewOcclusionTests)
		{
		}

		public static void UpdateInstanceOccluders(RenderGraph renderGraph, in OccluderParameters occluderParameters, ReadOnlySpan<OccluderSubviewUpdate> occluderSubviewUpdates)
		{
		}

		public static void ReinitializeIfNeeded()
		{
		}

		public static void RenderDebugOcclusionTestOverlay(RenderGraph renderGraph, DebugDisplayGPUResidentDrawer debugSettings, int viewInstanceID, TextureHandle colorBuffer)
		{
		}

		public static void RenderDebugOccluderOverlay(RenderGraph renderGraph, DebugDisplayGPUResidentDrawer debugSettings, Vector2 screenPos, float maxHeight, TextureHandle colorBuffer)
		{
		}

		internal static DebugRendererBatcherStats GetDebugStats()
		{
			return null;
		}

		private void InsertIntoPlayerLoop()
		{
		}

		private void RemoveFromPlayerLoop()
		{
		}

		internal static bool IsEnabled()
		{
			return false;
		}

		internal static GPUResidentDrawerSettings GetGlobalSettingsFromRPAsset()
		{
			return default(GPUResidentDrawerSettings);
		}

		internal static bool IsForcedOnViaCommandLine()
		{
			return false;
		}

		internal static bool IsOcclusionForcedOnViaCommandLine()
		{
			return false;
		}

		internal static void Reinitialize()
		{
		}

		private static void CleanUp()
		{
		}

		private static void Recreate(GPUResidentDrawerSettings settings)
		{
		}

		private GPUResidentDrawer(GPUResidentDrawerSettings settings, int maxInstanceCount, int maxTreeInstanceCount)
		{
		}

		private void Dispose()
		{
		}

		private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		private static void PostPostLateUpdateStatic()
		{
		}

		private void OnBeginContextRendering(ScriptableRenderContext context, List<Camera> cameras)
		{
		}

		private void OnEndContextRendering(ScriptableRenderContext context, List<Camera> cameras)
		{
		}

		private void OnBeginCameraRendering(ScriptableRenderContext context, Camera camera)
		{
		}

		private void OnEndCameraRendering(ScriptableRenderContext context, Camera camera)
		{
		}

		private void PostPostLateUpdate()
		{
		}

		private void ProcessMaterials(NativeArray<EntityId> destroyedID, NativeArray<EntityId> unsupportedMaterials)
		{
		}

		private void ProcessCameras(NativeArray<EntityId> changedIDs, NativeArray<EntityId> destroyedIDs)
		{
		}

		private void ProcessMeshes(NativeArray<EntityId> destroyedID)
		{
		}

		private void ProcessLODGroups(NativeArray<EntityId> changedID, NativeArray<EntityId> destroyed, NativeArray<EntityId> transformedID)
		{
		}

		private void ProcessRendererMaterialAndMeshChanges(NativeArray<EntityId> excludedRenderers, NativeArray<EntityId> changedMaterials, NativeArray<GPUDrivenPackedMaterialData> changedPackedMaterialDatas, NativeArray<EntityId> changedMeshes)
		{
		}

		private void ProcessRenderers(TypeDispatchData rendererChanges, NativeArray<EntityId> unsupportedRenderers)
		{
		}

		private void TransformInstances(NativeArray<InstanceHandle> instances, NativeArray<Matrix4x4> localToWorldMatrices)
		{
		}

		private void FreeInstances(NativeArray<InstanceHandle> instances)
		{
		}

		private void FreeRendererGroupInstances(NativeArray<EntityId> rendererGroupIDs, NativeArray<EntityId> unsupportedRendererGroupIDs)
		{
		}

		private InstanceHandle AppendNewInstance(int rendererGroupID, in Matrix4x4 instanceTransform)
		{
			return default(InstanceHandle);
		}

		private JobHandle ScheduleQueryRendererGroupInstancesJob(NativeArray<EntityId> rendererGroupIDs, NativeArray<InstanceHandle> instances)
		{
			return default(JobHandle);
		}

		private JobHandle ScheduleQueryRendererGroupInstancesJob(NativeArray<EntityId> rendererGroupIDs, NativeList<InstanceHandle> instances)
		{
			return default(JobHandle);
		}

		private JobHandle ScheduleQueryRendererGroupInstancesJob(NativeArray<EntityId> rendererGroupIDs, NativeArray<int> instancesOffset, NativeArray<int> instancesCount, NativeList<InstanceHandle> instances)
		{
			return default(JobHandle);
		}

		private JobHandle ScheduleQueryMeshInstancesJob(NativeArray<EntityId> sortedMeshIDs, NativeList<InstanceHandle> instances)
		{
			return default(JobHandle);
		}

		private void ClassifyMaterials(NativeArray<EntityId> materials, out NativeList<EntityId> unsupportedMaterials, out NativeList<EntityId> supportedMaterials, out NativeList<GPUDrivenPackedMaterialData> supportedPackedMaterialDatas, Allocator allocator)
		{
			unsupportedMaterials = default(NativeList<EntityId>);
			supportedMaterials = default(NativeList<EntityId>);
			supportedPackedMaterialDatas = default(NativeList<GPUDrivenPackedMaterialData>);
		}

		private NativeList<EntityId> FindUnsupportedRenderers(NativeArray<EntityId> unsupportedMaterials)
		{
			return default(NativeList<EntityId>);
		}

		private NativeHashSet<EntityId> GetMaterialsWithChangedPackedMaterial(NativeArray<EntityId> materials, NativeArray<GPUDrivenPackedMaterialData> packedMaterialDatas, Allocator allocator)
		{
			return default(NativeHashSet<EntityId>);
		}

		private (NativeList<EntityId>, NativeList<EntityId>) FindRenderersFromMaterialsOrMeshes(NativeArray<EntityId> sortedExcludeRenderers, NativeHashSet<EntityId> materials, NativeArray<EntityId> meshes, Allocator rendererListAllocator)
		{
			return default((NativeList<EntityId>, NativeList<EntityId>));
		}

		internal static bool IsProjectSupported()
		{
			return false;
		}

		internal static bool IsProjectSupported(out string message, out LogType severity)
		{
			message = null;
			severity = default(LogType);
			return false;
		}

		internal static bool IsGPUResidentDrawerSupportedBySRP(GPUResidentDrawerSettings settings, out string message, out LogType severity)
		{
			message = null;
			severity = default(LogType);
			return false;
		}

		internal static void LogMessage(string message, LogType severity)
		{
		}
	}
}
