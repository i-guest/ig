using UnityEngine.Bindings;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Rendering
{
	[NativeHeader("Runtime/Shaders/RayTracing/RayTracingShader.h")]
	[NativeHeader("Runtime/Graphics/RayTracing/RayTracingAccelerationStructure.h")]
	[MovedFrom("UnityEngine.Experimental.Rendering")]
	[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
	internal class RayTracingShaderHelpURLAttribute : HelpURLAttribute
	{
		public override string URL => null;

		public RayTracingShaderHelpURLAttribute()
			: base(null)
		{
		}
	}
}
