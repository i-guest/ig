using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering.RendererUtils;

namespace UnityEngine.Rendering.RenderGraphModule
{
	internal class RenderGraphResourceRegistry
	{
		private delegate bool ResourceCreateCallback(InternalRenderGraphContext rgContext, IRenderGraphResource res);

		private delegate void ResourceCallback(InternalRenderGraphContext rgContext, IRenderGraphResource res);

		private class RenderGraphResourcesData
		{
			public DynamicArray<IRenderGraphResource> resourceArray;

			public int sharedResourcesCount;

			public IRenderGraphResourcePool pool;

			public ResourceCreateCallback createResourceCallback;

			public ResourceCallback releaseResourceCallback;

			public void Clear(bool onException, int frameIndex)
			{
			}

			public void Cleanup()
			{
			}

			public void PurgeUnusedGraphicsResources(int frameIndex)
			{
			}

			public int AddNewRenderGraphResource<ResType>(out ResType outRes, bool pooledResource = true) where ResType : IRenderGraphResource, new()
			{
				outRes = null;
				return 0;
			}
		}

		private const int kSharedResourceLifetime = 30;

		private static RenderGraphResourceRegistry m_CurrentRegistry;

		private RenderGraphResourcesData[] m_RenderGraphResources;

		private DynamicArray<RendererListResource> m_RendererListResources;

		private DynamicArray<RendererListLegacyResource> m_RendererListLegacyResources;

		private RenderGraphDebugParams m_RenderGraphDebug;

		private RenderGraphLogger m_ResourceLogger;

		private RenderGraphLogger m_FrameInformationLogger;

		private int m_CurrentFrameIndex;

		private int m_ExecutionCount;

		private RTHandle m_CurrentBackbuffer;

		private const int kInitialRendererListCount = 256;

		private List<RendererList> m_ActiveRendererLists;

		private static RenderTargetIdentifier emptyId;

		private static RenderTargetIdentifier builtinCameraRenderTarget;

		internal bool forceManualClearOfResource;

		internal static RenderGraphResourceRegistry current
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[Conditional("DEVELOPMENT_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void CheckTextureResource(TextureResource texResource)
		{
		}

		internal RTHandle GetTexture(in TextureHandle handle)
		{
			return null;
		}

		internal RTHandle GetTexture(int index)
		{
			return null;
		}

		internal bool TextureNeedsFallback(in TextureHandle handle)
		{
			return false;
		}

		internal RendererList GetRendererList(in RendererListHandle handle)
		{
			return default(RendererList);
		}

		[Conditional("DEVELOPMENT_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void CheckBufferResource(BufferResource bufferResource)
		{
		}

		internal GraphicsBuffer GetBuffer(in BufferHandle handle)
		{
			return null;
		}

		internal GraphicsBuffer GetBuffer(int index)
		{
			return null;
		}

		internal RayTracingAccelerationStructure GetRayTracingAccelerationStructure(in RayTracingAccelerationStructureHandle handle)
		{
			return null;
		}

		internal int GetSharedResourceCount(RenderGraphResourceType type)
		{
			return 0;
		}

		private RenderGraphResourceRegistry()
		{
		}

		internal RenderGraphResourceRegistry(RenderGraphDebugParams renderGraphDebug, RenderGraphLogger frameInformationLogger)
		{
		}

		internal void BeginRenderGraph(int executionCount)
		{
		}

		internal void BeginExecute(int currentFrameIndex)
		{
		}

		internal void EndExecute()
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Conditional("DEVELOPMENT_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void CheckHandleValidity(in ResourceHandle res)
		{
		}

		[Conditional("DEVELOPMENT_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void CheckHandleValidity(RenderGraphResourceType type, int index)
		{
		}

		internal ResourceHandle IncrementWriteCount(in ResourceHandle res)
		{
			return default(ResourceHandle);
		}

		internal void IncrementReadCount(in ResourceHandle res)
		{
		}

		internal ResourceHandle GetLatestVersionHandle(in ResourceHandle res)
		{
			return default(ResourceHandle);
		}

		internal ResourceHandle GetZeroVersionHandle(in ResourceHandle res)
		{
			return default(ResourceHandle);
		}

		internal IRenderGraphResource GetResourceLowLevel(in ResourceHandle res)
		{
			return null;
		}

		internal string GetRenderGraphResourceName(in ResourceHandle res)
		{
			return null;
		}

		internal string GetRenderGraphResourceName(RenderGraphResourceType type, int index)
		{
			return null;
		}

		internal bool IsRenderGraphResourceImported(in ResourceHandle res)
		{
			return false;
		}

		internal bool IsRenderGraphResourceShared(RenderGraphResourceType type, int index)
		{
			return false;
		}

		internal bool IsRenderGraphResourceShared(in ResourceHandle res)
		{
			return false;
		}

		internal bool IsGraphicsResourceCreated(in ResourceHandle res)
		{
			return false;
		}

		internal bool IsRendererListCreated(in RendererListHandle res)
		{
			return false;
		}

		internal bool IsRenderGraphResourceImported(RenderGraphResourceType type, int index)
		{
			return false;
		}

		internal int GetRenderGraphResourceTransientIndex(in ResourceHandle res)
		{
			return 0;
		}

		internal TextureHandle ImportTexture(in RTHandle rt, bool isBuiltin = false)
		{
			return default(TextureHandle);
		}

		internal TextureHandle ImportTexture(in RTHandle rt, in ImportResourceParams importParams, bool isBuiltin = false)
		{
			return default(TextureHandle);
		}

		internal TextureHandle ImportTexture(in RTHandle rt, RenderTargetInfo info, in ImportResourceParams importParams)
		{
			return default(TextureHandle);
		}

		internal TextureHandle CreateSharedTexture(in TextureDesc desc, bool explicitRelease)
		{
			return default(TextureHandle);
		}

		internal void RefreshSharedTextureDesc(in TextureHandle texture, in TextureDesc desc)
		{
		}

		internal void ReleaseSharedTexture(in TextureHandle texture)
		{
		}

		internal TextureHandle ImportBackbuffer(RenderTargetIdentifier rt, in RenderTargetInfo info, in ImportResourceParams importParams)
		{
			return default(TextureHandle);
		}

		[Conditional("DEVELOPMENT_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void ValidateRenderTarget(in ResourceHandle res)
		{
		}

		internal void GetRenderTargetInfo(in ResourceHandle res, out RenderTargetInfo outInfo)
		{
			outInfo = default(RenderTargetInfo);
		}

		internal GraphicsFormat GetFormat(GraphicsFormat color, GraphicsFormat depthStencil)
		{
			return default(GraphicsFormat);
		}

		[Conditional("DEVELOPMENT_BUILD")]
		[Conditional("UNITY_EDITOR")]
		internal void ValidateFormat(GraphicsFormat color, GraphicsFormat depthStencil)
		{
		}

		internal TextureHandle CreateTexture(in TextureDesc desc, int transientPassIndex = -1)
		{
			return default(TextureHandle);
		}

		internal void SetTextureAsMemoryLess(in ResourceHandle handle)
		{
		}

		internal int GetResourceCount(RenderGraphResourceType type)
		{
			return 0;
		}

		internal int GetTextureResourceCount()
		{
			return 0;
		}

		internal TextureResource GetTextureResource(in ResourceHandle handle)
		{
			return null;
		}

		internal TextureResource GetTextureResource(int index)
		{
			return null;
		}

		internal ref TextureDesc GetTextureResourceDesc(in ResourceHandle handle, bool noThrowOnInvalidDesc = false)
		{
			throw null;
		}

		internal RendererListHandle CreateRendererList(in RendererListDesc desc)
		{
			return default(RendererListHandle);
		}

		internal RendererListHandle CreateRendererList(in RendererListParams desc)
		{
			return default(RendererListHandle);
		}

		internal RendererListHandle CreateShadowRendererList(ScriptableRenderContext context, ref ShadowDrawingSettings shadowDrawinSettings)
		{
			return default(RendererListHandle);
		}

		internal RendererListHandle CreateGizmoRendererList(ScriptableRenderContext context, in Camera camera, in GizmoSubset gizmoSubset)
		{
			return default(RendererListHandle);
		}

		internal RendererListHandle CreateUIOverlayRendererList(ScriptableRenderContext context, in Camera camera, in UISubset uiSubset)
		{
			return default(RendererListHandle);
		}

		internal RendererListHandle CreateWireOverlayRendererList(ScriptableRenderContext context, in Camera camera)
		{
			return default(RendererListHandle);
		}

		internal RendererListHandle CreateSkyboxRendererList(ScriptableRenderContext context, in Camera camera)
		{
			return default(RendererListHandle);
		}

		internal RendererListHandle CreateSkyboxRendererList(ScriptableRenderContext context, in Camera camera, Matrix4x4 projectionMatrix, Matrix4x4 viewMatrix)
		{
			return default(RendererListHandle);
		}

		internal RendererListHandle CreateSkyboxRendererList(ScriptableRenderContext context, in Camera camera, Matrix4x4 projectionMatrixL, Matrix4x4 viewMatrixL, Matrix4x4 projectionMatrixR, Matrix4x4 viewMatrixR)
		{
			return default(RendererListHandle);
		}

		internal BufferHandle ImportBuffer(GraphicsBuffer graphicsBuffer)
		{
			return default(BufferHandle);
		}

		internal BufferHandle CreateBuffer(in BufferDesc desc, int transientPassIndex = -1)
		{
			return default(BufferHandle);
		}

		internal ref BufferDesc GetBufferResourceDesc(in ResourceHandle handle, bool noThrowOnInvalidDesc = false)
		{
			throw null;
		}

		internal int GetBufferResourceCount()
		{
			return 0;
		}

		private BufferResource GetBufferResource(in ResourceHandle handle)
		{
			return null;
		}

		private BufferResource GetBufferResource(int index)
		{
			return null;
		}

		private RayTracingAccelerationStructureResource GetRayTracingAccelerationStructureResource(in ResourceHandle handle)
		{
			return null;
		}

		internal int GetRayTracingAccelerationStructureResourceCount()
		{
			return 0;
		}

		internal RayTracingAccelerationStructureHandle ImportRayTracingAccelerationStructure(in RayTracingAccelerationStructure accelStruct, string name)
		{
			return default(RayTracingAccelerationStructureHandle);
		}

		internal void UpdateSharedResourceLastFrameIndex(int type, int index)
		{
		}

		internal void UpdateSharedResourceLastFrameIndex(in ResourceHandle handle)
		{
		}

		private void ManageSharedRenderGraphResources()
		{
		}

		internal bool CreatePooledResource(InternalRenderGraphContext rgContext, int type, int index)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal bool CreatePooledResource(InternalRenderGraphContext rgContext, in ResourceHandle handle)
		{
			return false;
		}

		private bool CreateTextureCallback(InternalRenderGraphContext rgContext, IRenderGraphResource res)
		{
			return false;
		}

		internal bool ClearResource(InternalRenderGraphContext rgContext, int type, int index)
		{
			return false;
		}

		private void ClearTexture(InternalRenderGraphContext rgContext, TextureResource resource)
		{
		}

		internal void ReleasePooledResource(InternalRenderGraphContext rgContext, int type, int index)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void ReleasePooledResource(InternalRenderGraphContext rgContext, in ResourceHandle handle)
		{
		}

		private void ReleaseTextureCallback(InternalRenderGraphContext rgContext, IRenderGraphResource res)
		{
		}

		[Conditional("DEVELOPMENT_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void ValidateTextureDesc(in TextureDesc desc)
		{
		}

		[Conditional("DEVELOPMENT_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void ValidateRendererListDesc(in RendererListDesc desc)
		{
		}

		[Conditional("DEVELOPMENT_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void ValidateBufferDesc(in BufferDesc desc)
		{
		}

		internal void CreateRendererLists(List<RendererListHandle> rendererLists, ScriptableRenderContext context, bool manualDispatch = false)
		{
		}

		internal void Clear(bool onException)
		{
		}

		internal void PurgeUnusedGraphicsResources()
		{
		}

		internal void Cleanup()
		{
		}

		private void LogResources()
		{
		}

		internal void FlushLogs()
		{
		}
	}
}
