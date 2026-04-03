using System.Diagnostics;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Rendering.RenderGraphModule
{
	[DebuggerDisplay("RendererList ({handle})")]
	[MovedFrom(true, "UnityEngine.Experimental.Rendering.RenderGraphModule", "UnityEngine.Rendering.RenderGraphModule", null)]
	public struct RendererListHandle
	{
		internal RendererListHandleType type;

		private bool m_IsValid;

		internal int handle { get; private set; }

		internal RendererListHandle(int handle, RendererListHandleType type = RendererListHandleType.Renderers)
		{
			this.type = default(RendererListHandleType);
			m_IsValid = false;
			this.handle = 0;
		}

		public static implicit operator int(RendererListHandle handle)
		{
			return 0;
		}

		public static implicit operator RendererList(RendererListHandle rendererList)
		{
			return default(RendererList);
		}

		public bool IsValid()
		{
			return false;
		}
	}
}
