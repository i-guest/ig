using System;
using System.Diagnostics;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Rendering.RenderGraphModule
{
	[MovedFrom(true, "UnityEngine.Experimental.Rendering.RenderGraphModule", "UnityEngine.Rendering.RenderGraphModule", null)]
	[Obsolete("RenderGraphBuilder is deprecated, use IComputeRenderGraphBuilder/IRasterRenderGraphBuilder/IUnsafeRenderGraphBuilder instead.")]
	public struct RenderGraphBuilder : IDisposable
	{
		private RenderGraphPass m_RenderPass;

		private RenderGraphResourceRegistry m_Resources;

		private RenderGraph m_RenderGraph;

		private bool m_Disposed;

		public TextureHandle UseColorBuffer(in TextureHandle input, int index)
		{
			return default(TextureHandle);
		}

		public TextureHandle UseDepthBuffer(in TextureHandle input, DepthAccess flags)
		{
			return default(TextureHandle);
		}

		public TextureHandle ReadTexture(in TextureHandle input)
		{
			return default(TextureHandle);
		}

		public TextureHandle WriteTexture(in TextureHandle input)
		{
			return default(TextureHandle);
		}

		public TextureHandle ReadWriteTexture(in TextureHandle input)
		{
			return default(TextureHandle);
		}

		public TextureHandle CreateTransientTexture(in TextureDesc desc)
		{
			return default(TextureHandle);
		}

		public TextureHandle CreateTransientTexture(in TextureHandle texture)
		{
			return default(TextureHandle);
		}

		public RayTracingAccelerationStructureHandle WriteRayTracingAccelerationStructure(in RayTracingAccelerationStructureHandle input)
		{
			return default(RayTracingAccelerationStructureHandle);
		}

		public RayTracingAccelerationStructureHandle ReadRayTracingAccelerationStructure(in RayTracingAccelerationStructureHandle input)
		{
			return default(RayTracingAccelerationStructureHandle);
		}

		public RendererListHandle UseRendererList(in RendererListHandle input)
		{
			return default(RendererListHandle);
		}

		public BufferHandle ReadBuffer(in BufferHandle input)
		{
			return default(BufferHandle);
		}

		public BufferHandle WriteBuffer(in BufferHandle input)
		{
			return default(BufferHandle);
		}

		public BufferHandle CreateTransientBuffer(in BufferDesc desc)
		{
			return default(BufferHandle);
		}

		public BufferHandle CreateTransientBuffer(in BufferHandle graphicsbuffer)
		{
			return default(BufferHandle);
		}

		public void SetRenderFunc<PassData>(BaseRenderFunc<PassData, RenderGraphContext> renderFunc) where PassData : class, new()
		{
		}

		public void EnableAsyncCompute(bool value)
		{
		}

		public void AllowPassCulling(bool value)
		{
		}

		public void EnableFoveatedRasterization(bool value)
		{
		}

		public void Dispose()
		{
		}

		public void AllowRendererListCulling(bool value)
		{
		}

		public RendererListHandle DependsOn(in RendererListHandle input)
		{
			return default(RendererListHandle);
		}

		internal RenderGraphBuilder(RenderGraphPass renderPass, RenderGraphResourceRegistry resources, RenderGraph renderGraph)
		{
			m_RenderPass = null;
			m_Resources = null;
			m_RenderGraph = null;
			m_Disposed = false;
		}

		private void Dispose(bool disposing)
		{
		}

		[Conditional("DEVELOPMENT_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void CheckResource(in ResourceHandle res, bool checkTransientReadWrite = true)
		{
		}

		internal void GenerateDebugData(bool value)
		{
		}
	}
}
