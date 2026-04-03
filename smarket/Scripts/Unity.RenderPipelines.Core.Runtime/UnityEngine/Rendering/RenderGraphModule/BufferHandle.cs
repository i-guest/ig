using System.Diagnostics;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Rendering.RenderGraphModule
{
	[DebuggerDisplay("Buffer ({handle.index})")]
	[MovedFrom(true, "UnityEngine.Experimental.Rendering.RenderGraphModule", "UnityEngine.Rendering.RenderGraphModule", null)]
	public readonly struct BufferHandle
	{
		private static BufferHandle s_NullHandle;

		internal readonly ResourceHandle handle;

		public static BufferHandle nullHandle => default(BufferHandle);

		internal BufferHandle(in ResourceHandle h)
		{
			handle = default(ResourceHandle);
		}

		internal BufferHandle(int handle, bool shared = false)
		{
			this.handle = default(ResourceHandle);
		}

		public static implicit operator GraphicsBuffer(BufferHandle buffer)
		{
			return null;
		}

		public bool IsValid()
		{
			return false;
		}
	}
}
