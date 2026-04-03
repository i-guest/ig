using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Rendering
{
	[NativeHeader("Runtime/Graphics/RayTracing/RayTracingAccelerationStructure.h")]
	[Flags]
	[UsedByNativeCode]
	[MovedFrom("UnityEngine.Experimental.Rendering")]
	[NativeHeader("Runtime/Export/Graphics/RayTracingAccelerationStructure.bindings.h")]
	public enum RayTracingSubMeshFlags
	{
		Disabled = 0,
		Enabled = 1,
		ClosestHitOnly = 2,
		UniqueAnyHitCalls = 4
	}
}
