using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.Collections;
using UnityEngine.Bindings;

namespace UnityEngine.Rendering
{
	[NativeHeader("Runtime/Export/RenderPipeline/ScriptableRenderPipeline.bindings.h")]
	[NativeType("Runtime/Graphics/ScriptableRenderLoop/ScriptableRenderContext.h")]
	[NativeHeader("Modules/UI/Canvas.h")]
	[NativeHeader("Modules/UI/CanvasManager.h")]
	[NativeHeader("Runtime/Graphics/ScriptableRenderLoop/ScriptableDrawRenderersUtility.h")]
	[NativeHeader("Runtime/Export/RenderPipeline/ScriptableRenderContext.bindings.h")]
	public struct ScriptableRenderContext : IEquatable<ScriptableRenderContext>
	{
		private struct CullShadowCastersContext
		{
			public IntPtr cullResults;

			public unsafe ShadowSplitData* splitBuffer;

			public int splitBufferLength;

			public unsafe LightShadowCasterCullingInfo* perLightInfos;

			public int perLightInfoCount;
		}

		private static readonly ShaderTagId kRenderTypeTag;

		private IntPtr m_Ptr;

		[FreeFunction("ScriptableRenderContext::BeginRenderPass")]
		private static void BeginRenderPass_Internal(IntPtr self, int width, int height, int volumeDepth, int samples, IntPtr colors, int colorCount, int depthAttachmentIndex, int shadingRateImageAttachmentIndex)
		{
		}

		[FreeFunction("ScriptableRenderContext::BeginSubPass")]
		private static void BeginSubPass_Internal(IntPtr self, IntPtr colors, int colorCount, IntPtr inputs, int inputCount, bool isDepthReadOnly, bool isStencilReadOnly)
		{
		}

		[FreeFunction("ScriptableRenderContext::EndSubPass")]
		private static void EndSubPass_Internal(IntPtr self)
		{
		}

		[FreeFunction("ScriptableRenderContext::EndRenderPass")]
		private static void EndRenderPass_Internal(IntPtr self)
		{
		}

		[FreeFunction("ScriptableRenderContext::HasInvokeOnRenderObjectCallbacks")]
		private static bool HasInvokeOnRenderObjectCallbacks_Internal()
		{
			return false;
		}

		[FreeFunction("ScriptableRenderPipeline_Bindings::Internal_Cull")]
		private static void Internal_Cull(ref ScriptableCullingParameters parameters, ScriptableRenderContext renderLoop, IntPtr results)
		{
		}

		[FreeFunction("ScriptableRenderPipeline_Bindings::Internal_CullShadowCasters")]
		private static void Internal_CullShadowCasters(ScriptableRenderContext renderLoop, IntPtr context)
		{
		}

		[FreeFunction("InitializeSortSettings")]
		internal static void InitializeSortSettings(Camera camera, out SortingSettings sortingSettings)
		{
			sortingSettings = default(SortingSettings);
		}

		private void Submit_Internal()
		{
		}

		private bool SubmitForRenderPassValidation_Internal()
		{
			return false;
		}

		private void GetCameras_Internal(Type listType, object resultList)
		{
		}

		[FreeFunction("PlayerEmitCanvasGeometryForCamera")]
		public static void EmitGeometryForCamera(Camera camera)
		{
		}

		[NativeThrows]
		private void ExecuteCommandBuffer_Internal(CommandBuffer commandBuffer)
		{
		}

		[NativeThrows]
		private void ExecuteCommandBufferAsync_Internal(CommandBuffer commandBuffer, ComputeQueueType queueType)
		{
		}

		private void SetupCameraProperties_Internal([NotNull] Camera camera, bool stereoSetup, int eye)
		{
		}

		private void DrawWireOverlay_Impl([NotNull] Camera camera)
		{
		}

		internal IntPtr Internal_GetPtr()
		{
			return (IntPtr)0;
		}

		private RendererList CreateRendererList_Internal(IntPtr cullResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ShaderTagId tagName, bool isPassTagName, IntPtr tagValues, IntPtr stateBlocks, int stateCount)
		{
			return default(RendererList);
		}

		private RendererList CreateShadowRendererList_Internal(IntPtr shadowDrawinSettings)
		{
			return default(RendererList);
		}

		private RendererList CreateSkyboxRendererList_Internal([NotNull] Camera camera, int mode, Matrix4x4 proj, Matrix4x4 view, Matrix4x4 projR, Matrix4x4 viewR)
		{
			return default(RendererList);
		}

		private RendererList CreateGizmoRendererList_Internal([NotNull] Camera camera, GizmoSubset gizmoSubset)
		{
			return default(RendererList);
		}

		private RendererList CreateUIOverlayRendererList_Internal([NotNull] Camera camera, UISubset uiSubset)
		{
			return default(RendererList);
		}

		private RendererList CreateWireOverlayRendererList_Internal([NotNull] Camera camera)
		{
			return default(RendererList);
		}

		private void PrepareRendererListsAsync_Internal(object rendererLists)
		{
		}

		private RendererListStatus QueryRendererListStatus_Internal(RendererList handle)
		{
			return default(RendererListStatus);
		}

		internal ScriptableRenderContext(IntPtr ptr)
		{
			m_Ptr = (IntPtr)0;
		}

		public void BeginRenderPass(int width, int height, int samples, NativeArray<AttachmentDescriptor> attachments, int depthAttachmentIndex = -1)
		{
		}

		public void BeginSubPass(NativeArray<int> colors, NativeArray<int> inputs, bool isDepthStencilReadOnly = false)
		{
		}

		public void BeginSubPass(NativeArray<int> colors, bool isDepthStencilReadOnly = false)
		{
		}

		public void EndSubPass()
		{
		}

		public void EndRenderPass()
		{
		}

		public void Submit()
		{
		}

		public bool SubmitForRenderPassValidation()
		{
			return false;
		}

		public bool HasInvokeOnRenderObjectCallbacks()
		{
			return false;
		}

		internal void GetCameras(List<Camera> results)
		{
		}

		public void ExecuteCommandBuffer(CommandBuffer commandBuffer)
		{
		}

		public void ExecuteCommandBufferAsync(CommandBuffer commandBuffer, ComputeQueueType queueType)
		{
		}

		public void SetupCameraProperties(Camera camera, bool stereoSetup = false)
		{
		}

		public void SetupCameraProperties(Camera camera, bool stereoSetup, int eye)
		{
		}

		public void DrawWireOverlay(Camera camera)
		{
		}

		public CullingResults Cull(ref ScriptableCullingParameters parameters)
		{
			return default(CullingResults);
		}

		public void CullShadowCasters(CullingResults cullingResults, ShadowCastersCullingInfos infos)
		{
		}

		public bool Equals(ScriptableRenderContext other)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public RendererList CreateRendererList(ref RendererListParams param)
		{
			return default(RendererList);
		}

		public RendererList CreateShadowRendererList(ref ShadowDrawingSettings settings)
		{
			return default(RendererList);
		}

		public RendererList CreateSkyboxRendererList(Camera camera, Matrix4x4 projectionMatrixL, Matrix4x4 viewMatrixL, Matrix4x4 projectionMatrixR, Matrix4x4 viewMatrixR)
		{
			return default(RendererList);
		}

		public RendererList CreateSkyboxRendererList(Camera camera, Matrix4x4 projectionMatrix, Matrix4x4 viewMatrix)
		{
			return default(RendererList);
		}

		public RendererList CreateSkyboxRendererList(Camera camera)
		{
			return default(RendererList);
		}

		public RendererList CreateGizmoRendererList(Camera camera, GizmoSubset gizmoSubset)
		{
			return default(RendererList);
		}

		public RendererList CreateUIOverlayRendererList(Camera camera)
		{
			return default(RendererList);
		}

		public RendererList CreateUIOverlayRendererList(Camera camera, UISubset uiSubset)
		{
			return default(RendererList);
		}

		public RendererList CreateWireOverlayRendererList(Camera camera)
		{
			return default(RendererList);
		}

		public void PrepareRendererListsAsync(List<RendererList> rendererLists)
		{
		}

		public RendererListStatus QueryRendererListStatus(RendererList rendererList)
		{
			return default(RendererListStatus);
		}

		private static void Internal_Cull_Injected(ref ScriptableCullingParameters parameters, [In] ref ScriptableRenderContext renderLoop, IntPtr results)
		{
		}

		private static void Internal_CullShadowCasters_Injected([In] ref ScriptableRenderContext renderLoop, IntPtr context)
		{
		}

		private static void InitializeSortSettings_Injected(IntPtr camera, out SortingSettings sortingSettings)
		{
			sortingSettings = default(SortingSettings);
		}

		private static void EmitGeometryForCamera_Injected(IntPtr camera)
		{
		}

		private static void ExecuteCommandBuffer_Internal_Injected(ref ScriptableRenderContext _unity_self, IntPtr commandBuffer)
		{
		}

		private static void ExecuteCommandBufferAsync_Internal_Injected(ref ScriptableRenderContext _unity_self, IntPtr commandBuffer, ComputeQueueType queueType)
		{
		}

		private static void SetupCameraProperties_Internal_Injected(ref ScriptableRenderContext _unity_self, IntPtr camera, bool stereoSetup, int eye)
		{
		}

		private static void DrawWireOverlay_Impl_Injected(ref ScriptableRenderContext _unity_self, IntPtr camera)
		{
		}

		private static void CreateRendererList_Internal_Injected(ref ScriptableRenderContext _unity_self, IntPtr cullResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, [In] ref ShaderTagId tagName, bool isPassTagName, IntPtr tagValues, IntPtr stateBlocks, int stateCount, out RendererList ret)
		{
			ret = default(RendererList);
		}

		private static void CreateShadowRendererList_Internal_Injected(ref ScriptableRenderContext _unity_self, IntPtr shadowDrawinSettings, out RendererList ret)
		{
			ret = default(RendererList);
		}

		private static void CreateSkyboxRendererList_Internal_Injected(ref ScriptableRenderContext _unity_self, IntPtr camera, int mode, [In] ref Matrix4x4 proj, [In] ref Matrix4x4 view, [In] ref Matrix4x4 projR, [In] ref Matrix4x4 viewR, out RendererList ret)
		{
			ret = default(RendererList);
		}

		private static void CreateGizmoRendererList_Internal_Injected(ref ScriptableRenderContext _unity_self, IntPtr camera, GizmoSubset gizmoSubset, out RendererList ret)
		{
			ret = default(RendererList);
		}

		private static void CreateUIOverlayRendererList_Internal_Injected(ref ScriptableRenderContext _unity_self, IntPtr camera, UISubset uiSubset, out RendererList ret)
		{
			ret = default(RendererList);
		}

		private static void CreateWireOverlayRendererList_Internal_Injected(ref ScriptableRenderContext _unity_self, IntPtr camera, out RendererList ret)
		{
			ret = default(RendererList);
		}

		private static RendererListStatus QueryRendererListStatus_Internal_Injected(ref ScriptableRenderContext _unity_self, [In] ref RendererList handle)
		{
			return default(RendererListStatus);
		}
	}
}
