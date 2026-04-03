using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[NativeHeader("Modules/ParticleSystem/ParticleSystemRenderer.h")]
	[NativeHeader("ParticleSystemScriptingClasses.h")]
	[RequireComponent(typeof(Transform))]
	[NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemRendererScriptBindings.h")]
	public sealed class ParticleSystemRenderer : Renderer
	{
		[FreeFunction(Name = "ParticleSystemRendererScriptBindings::GetMeshes", HasExplicitThis = true)]
		[RequiredByNativeCode]
		public int GetMeshes([Out][NotNull] Mesh[] meshes)
		{
			return 0;
		}

		private static int GetMeshes_Injected(IntPtr _unity_self, [Out] Mesh[] meshes)
		{
			return 0;
		}
	}
}
