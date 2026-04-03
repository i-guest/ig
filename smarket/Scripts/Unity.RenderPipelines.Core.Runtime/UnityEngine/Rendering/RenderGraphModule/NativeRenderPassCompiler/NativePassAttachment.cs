using System.Diagnostics;

namespace UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler
{
	[DebuggerDisplay("Res({handle.index}) : {loadAction} : {storeAction} : {memoryless}")]
	internal readonly struct NativePassAttachment
	{
		public readonly ResourceHandle handle;

		public readonly RenderBufferLoadAction loadAction;

		public readonly RenderBufferStoreAction storeAction;

		public readonly bool memoryless;

		public readonly int mipLevel;

		public readonly int depthSlice;

		public NativePassAttachment(in ResourceHandle handle, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, bool memoryless, int mipLevel, int depthSlice)
		{
			this.handle = default(ResourceHandle);
			this.loadAction = default(RenderBufferLoadAction);
			this.storeAction = default(RenderBufferStoreAction);
			this.memoryless = false;
			this.mipLevel = 0;
			this.depthSlice = 0;
		}
	}
}
