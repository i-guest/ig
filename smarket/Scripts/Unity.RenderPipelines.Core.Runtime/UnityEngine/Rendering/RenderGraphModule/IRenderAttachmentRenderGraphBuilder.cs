using System;

namespace UnityEngine.Rendering.RenderGraphModule
{
	public interface IRenderAttachmentRenderGraphBuilder : IBaseRenderGraphBuilder, IDisposable
	{
		void SetRenderAttachment(TextureHandle tex, int index, AccessFlags flags = AccessFlags.Write)
		{
		}

		void SetRenderAttachment(TextureHandle tex, int index, AccessFlags flags, int mipLevel, int depthSlice);

		void SetRenderAttachmentDepth(TextureHandle tex, AccessFlags flags = AccessFlags.Write)
		{
		}

		void SetRenderAttachmentDepth(TextureHandle tex, AccessFlags flags, int mipLevel, int depthSlice);

		TextureHandle SetRandomAccessAttachment(TextureHandle tex, int index, AccessFlags flags = AccessFlags.ReadWrite);

		BufferHandle UseBufferRandomAccess(BufferHandle tex, int index, AccessFlags flags = AccessFlags.Read);

		BufferHandle UseBufferRandomAccess(BufferHandle tex, int index, bool preserveCounterValue, AccessFlags flags = AccessFlags.Read);
	}
}
