using System.Diagnostics;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Rendering.RenderGraphModule
{
	[DebuggerDisplay("RayTracingAccelerationStructure ({handle.index})")]
	[MovedFrom(true, "UnityEngine.Experimental.Rendering.RenderGraphModule", "UnityEngine.Rendering.RenderGraphModule", null)]
	public readonly struct RayTracingAccelerationStructureHandle
	{
		private static RayTracingAccelerationStructureHandle s_NullHandle;

		internal readonly ResourceHandle handle;

		public static RayTracingAccelerationStructureHandle nullHandle => default(RayTracingAccelerationStructureHandle);

		internal RayTracingAccelerationStructureHandle(int handle)
		{
			this.handle = default(ResourceHandle);
		}

		public static implicit operator RayTracingAccelerationStructure(RayTracingAccelerationStructureHandle handle)
		{
			return null;
		}

		public bool IsValid()
		{
			return false;
		}
	}
}
