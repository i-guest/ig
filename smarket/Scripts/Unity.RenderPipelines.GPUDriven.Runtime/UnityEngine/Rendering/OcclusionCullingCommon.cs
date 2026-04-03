using System;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering
{
	internal class OcclusionCullingCommon : IDisposable
	{
		private struct OccluderContextSlot
		{
			public bool valid;

			public int lastUsedFrameIndex;

			public int viewInstanceID;
		}

		private static class ShaderIDs
		{
			public static readonly int OcclusionCullingCommonShaderVariables;

			public static readonly int _OccluderDepthPyramid;

			public static readonly int _OcclusionDebugOverlay;

			public static readonly int OcclusionCullingDebugShaderVariables;
		}

		private class OcclusionTestOverlaySetupPassData
		{
			public OcclusionCullingDebugShaderVariables cb;
		}

		private class OcclusionTestOverlayPassData
		{
			public BufferHandle debugPyramid;
		}

		private struct DebugOccluderViewData
		{
			public int passIndex;

			public Rect viewport;

			public bool valid;
		}

		private class OccluderOverlayPassData
		{
			public Material debugMaterial;

			public RTHandle occluderTexture;

			public Rect viewport;

			public int passIndex;

			public Vector2 validRange;
		}

		private class UpdateOccludersPassData
		{
			public OccluderParameters occluderParams;

			public List<OccluderSubviewUpdate> occluderSubviewUpdates;

			public OccluderHandles occluderHandles;
		}

		private static readonly int s_MaxContextGCFrame;

		private Material m_DebugOcclusionTestMaterial;

		private Material m_OccluderDebugViewMaterial;

		private ComputeShader m_OcclusionDebugCS;

		private int m_ClearOcclusionDebugKernel;

		private ComputeShader m_OccluderDepthPyramidCS;

		private int m_OccluderDepthDownscaleKernel;

		private int m_FrameIndex;

		private SilhouettePlaneCache m_SilhouettePlaneCache;

		private NativeParallelHashMap<int, int> m_ViewIDToIndexMap;

		private List<OccluderContext> m_OccluderContextData;

		private NativeList<OccluderContextSlot> m_OccluderContextSlots;

		private NativeList<int> m_FreeOccluderContexts;

		private NativeArray<OcclusionCullingCommonShaderVariables> m_CommonShaderVariables;

		private ComputeBuffer m_CommonConstantBuffer;

		private NativeArray<OcclusionCullingDebugShaderVariables> m_DebugShaderVariables;

		private ComputeBuffer m_DebugConstantBuffer;

		private ProfilingSampler m_ProfilingSamplerUpdateOccluders;

		private ProfilingSampler m_ProfilingSamplerOcclusionTestOverlay;

		private ProfilingSampler m_ProfilingSamplerOccluderOverlay;

		internal void Init(GPUResidentDrawerResources resources)
		{
		}

		internal static bool UseOcclusionDebug(in OccluderContext occluderCtx)
		{
			return false;
		}

		internal void PrepareCulling(ComputeCommandBuffer cmd, in OccluderContext occluderCtx, in OcclusionCullingSettings settings, in InstanceOcclusionTestSubviewSettings subviewSettings, in OcclusionTestComputeShader shader, bool useOcclusionDebug)
		{
		}

		internal static void SetDepthPyramid(ComputeCommandBuffer cmd, in OcclusionTestComputeShader shader, int kernel, in OccluderHandles occluderHandles)
		{
		}

		internal static void SetDebugPyramid(ComputeCommandBuffer cmd, in OcclusionTestComputeShader shader, int kernel, in OccluderHandles occluderHandles)
		{
		}

		public void RenderDebugOcclusionTestOverlay(RenderGraph renderGraph, DebugDisplayGPUResidentDrawer debugSettings, int viewInstanceID, in TextureHandle colorBuffer)
		{
		}

		public void RenderDebugOccluderOverlay(RenderGraph renderGraph, DebugDisplayGPUResidentDrawer debugSettings, Vector2 screenPos, float maxHeight, in TextureHandle colorBuffer)
		{
		}

		private void DispatchDebugClear(ComputeCommandBuffer cmd, int viewInstanceID)
		{
		}

		private OccluderHandles PrepareOccluders(RenderGraph renderGraph, in OccluderParameters occluderParams)
		{
			return default(OccluderHandles);
		}

		private void CreateFarDepthPyramid(ComputeCommandBuffer cmd, in OccluderParameters occluderParams, ReadOnlySpan<OccluderSubviewUpdate> occluderSubviewUpdates, in OccluderHandles occluderHandles)
		{
		}

		public bool UpdateInstanceOccluders(RenderGraph renderGraph, in OccluderParameters occluderParams, ReadOnlySpan<OccluderSubviewUpdate> occluderSubviewUpdates)
		{
			return false;
		}

		internal void UpdateSilhouettePlanes(int viewInstanceID, NativeArray<Plane> planes)
		{
		}

		internal OcclusionCullingDebugOutput GetOcclusionTestDebugOutput(int viewInstanceID)
		{
			return default(OcclusionCullingDebugOutput);
		}

		public void UpdateOccluderStats(DebugRendererBatcherStats debugStats)
		{
		}

		internal bool HasOccluderContext(int viewInstanceID)
		{
			return false;
		}

		internal bool GetOccluderContext(int viewInstanceID, out OccluderContext occluderContext)
		{
			occluderContext = default(OccluderContext);
			return false;
		}

		internal void UpdateFrame()
		{
		}

		private int NewContext(int viewInstanceID)
		{
			return 0;
		}

		private void DeleteContext(int viewInstanceID)
		{
		}

		public void Dispose()
		{
		}
	}
}
