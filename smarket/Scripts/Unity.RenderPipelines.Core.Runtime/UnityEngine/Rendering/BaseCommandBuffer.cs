using System.Diagnostics;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering
{
	public class BaseCommandBuffer
	{
		protected internal CommandBuffer m_WrappedCommandBuffer;

		internal RenderGraphPass m_ExecutingPass;

		public string name => null;

		public int sizeInBytes => 0;

		internal BaseCommandBuffer(CommandBuffer wrapped, RenderGraphPass executingPass, bool isAsync)
		{
		}

		[Conditional("DEVELOPMENT_BUILD")]
		[Conditional("UNITY_EDITOR")]
		protected internal void ThrowIfGlobalStateNotAllowed()
		{
		}

		[Conditional("DEVELOPMENT_BUILD")]
		[Conditional("UNITY_EDITOR")]
		protected internal void ThrowIfRasterNotAllowed()
		{
		}

		[Conditional("DEVELOPMENT_BUILD")]
		[Conditional("UNITY_EDITOR")]
		protected internal void ValidateTextureHandle(in TextureHandle h)
		{
		}

		[Conditional("DEVELOPMENT_BUILD")]
		[Conditional("UNITY_EDITOR")]
		protected internal void ValidateTextureHandleRead(in TextureHandle h)
		{
		}

		[Conditional("DEVELOPMENT_BUILD")]
		[Conditional("UNITY_EDITOR")]
		protected internal void ValidateTextureHandleWrite(in TextureHandle h)
		{
		}
	}
}
