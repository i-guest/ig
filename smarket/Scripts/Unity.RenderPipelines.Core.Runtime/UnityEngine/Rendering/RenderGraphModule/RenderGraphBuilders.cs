using System;
using System.Diagnostics;

namespace UnityEngine.Rendering.RenderGraphModule
{
	internal class RenderGraphBuilders : IBaseRenderGraphBuilder, IDisposable, IComputeRenderGraphBuilder, IRasterRenderGraphBuilder, IRenderAttachmentRenderGraphBuilder, IUnsafeRenderGraphBuilder
	{
		private RenderGraphPass m_RenderPass;

		private RenderGraphResourceRegistry m_Resources;

		private RenderGraph m_RenderGraph;

		private bool m_Disposed;

		public void Setup(RenderGraphPass renderPass, RenderGraphResourceRegistry resources, RenderGraph renderGraph)
		{
		}

		public void EnableAsyncCompute(bool value)
		{
		}

		public void AllowPassCulling(bool value)
		{
		}

		public void AllowGlobalStateModification(bool value)
		{
		}

		public void EnableFoveatedRasterization(bool value)
		{
		}

		public BufferHandle CreateTransientBuffer(in BufferDesc desc)
		{
			return default(BufferHandle);
		}

		public BufferHandle CreateTransientBuffer(in BufferHandle computebuffer)
		{
			return default(BufferHandle);
		}

		public TextureHandle CreateTransientTexture(in TextureDesc desc)
		{
			return default(TextureHandle);
		}

		public TextureHandle CreateTransientTexture(in TextureHandle texture)
		{
			return default(TextureHandle);
		}

		public void GenerateDebugData(bool value)
		{
		}

		public void Dispose()
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}

		[Conditional("DEVELOPMENT_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void CheckWriteTo(in ResourceHandle handle)
		{
		}

		private ResourceHandle UseTransientResource(in ResourceHandle inputHandle)
		{
			return default(ResourceHandle);
		}

		private ResourceHandle UseResource(in ResourceHandle inputHandle, AccessFlags flags)
		{
			return default(ResourceHandle);
		}

		public BufferHandle UseBuffer(in BufferHandle input, AccessFlags flags)
		{
			return default(BufferHandle);
		}

		[Conditional("DEVELOPMENT_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void CheckNotUseFragment(in TextureHandle tex)
		{
		}

		[Conditional("DEVELOPMENT_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void CheckTextureUVOriginIsValid(in ResourceHandle handle, TextureResource texRes)
		{
		}

		public void UseTexture(in TextureHandle input, AccessFlags flags)
		{
		}

		public void UseGlobalTexture(int propertyId, AccessFlags flags)
		{
		}

		public void UseAllGlobalTextures(bool enable)
		{
		}

		public void SetGlobalTextureAfterPass(in TextureHandle input, int propertyId)
		{
		}

		[Conditional("DEVELOPMENT_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void CheckUseFragment(in TextureHandle tex, bool isDepth)
		{
		}

		public void SetRenderAttachment(TextureHandle tex, int index, AccessFlags flags, int mipLevel, int depthSlice)
		{
		}

		public void SetInputAttachment(TextureHandle tex, int index, AccessFlags flags, int mipLevel, int depthSlice)
		{
		}

		public void SetRenderAttachmentDepth(TextureHandle tex, AccessFlags flags, int mipLevel, int depthSlice)
		{
		}

		public TextureHandle SetRandomAccessAttachment(TextureHandle input, int index, AccessFlags flags = AccessFlags.Read)
		{
			return default(TextureHandle);
		}

		public void SetShadingRateImageAttachment(in TextureHandle tex)
		{
		}

		public BufferHandle UseBufferRandomAccess(BufferHandle input, int index, AccessFlags flags = AccessFlags.Read)
		{
			return default(BufferHandle);
		}

		public BufferHandle UseBufferRandomAccess(BufferHandle input, int index, bool preserveCounterValue, AccessFlags flags = AccessFlags.Read)
		{
			return default(BufferHandle);
		}

		public void SetRenderFunc<PassData>(BaseRenderFunc<PassData, ComputeGraphContext> renderFunc) where PassData : class, new()
		{
		}

		public void SetRenderFunc<PassData>(BaseRenderFunc<PassData, RasterGraphContext> renderFunc) where PassData : class, new()
		{
		}

		public void SetRenderFunc<PassData>(BaseRenderFunc<PassData, UnsafeGraphContext> renderFunc) where PassData : class, new()
		{
		}

		public void UseRendererList(in RendererListHandle input)
		{
		}

		[Conditional("DEVELOPMENT_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void CheckResource(in ResourceHandle res, bool checkTransientReadWrite = false)
		{
		}

		[Conditional("DEVELOPMENT_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void CheckFrameBufferFetchEmulationIsSupported(in TextureHandle tex)
		{
		}

		public void SetShadingRateFragmentSize(ShadingRateFragmentSize shadingRateFragmentSize)
		{
		}

		public void SetShadingRateCombiner(ShadingRateCombinerStage stage, ShadingRateCombiner combiner)
		{
		}

		public void SetExtendedFeatureFlags(ExtendedFeatureFlags extendedFeatureFlags)
		{
		}

		void IRasterRenderGraphBuilder.SetShadingRateImageAttachment(in TextureHandle tex)
		{
		}

		void IBaseRenderGraphBuilder.UseTexture(in TextureHandle input, AccessFlags flags)
		{
		}

		void IBaseRenderGraphBuilder.SetGlobalTextureAfterPass(in TextureHandle input, int propertyId)
		{
		}

		BufferHandle IBaseRenderGraphBuilder.UseBuffer(in BufferHandle input, AccessFlags flags)
		{
			return default(BufferHandle);
		}

		TextureHandle IBaseRenderGraphBuilder.CreateTransientTexture(in TextureDesc desc)
		{
			return default(TextureHandle);
		}

		TextureHandle IBaseRenderGraphBuilder.CreateTransientTexture(in TextureHandle texture)
		{
			return default(TextureHandle);
		}

		BufferHandle IBaseRenderGraphBuilder.CreateTransientBuffer(in BufferDesc desc)
		{
			return default(BufferHandle);
		}

		BufferHandle IBaseRenderGraphBuilder.CreateTransientBuffer(in BufferHandle computebuffer)
		{
			return default(BufferHandle);
		}

		void IBaseRenderGraphBuilder.UseRendererList(in RendererListHandle input)
		{
		}
	}
}
