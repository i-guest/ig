using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.Rendering
{
	[RequiredByNativeCode]
	[NativeHeader("Runtime/Camera/ScriptableRuntimeReflectionSystem.h")]
	public static class ScriptableRuntimeReflectionSystemSettings
	{
		private static ScriptableRuntimeReflectionSystemWrapper s_Instance;

		private static IScriptableRuntimeReflectionSystem Internal_ScriptableRuntimeReflectionSystemSettings_system
		{
			[RequiredByNativeCode]
			set
			{
			}
		}

		private static ScriptableRuntimeReflectionSystemWrapper Internal_ScriptableRuntimeReflectionSystemSettings_instance
		{
			[RequiredByNativeCode]
			get
			{
				return null;
			}
		}

		[StaticAccessor("ScriptableRuntimeReflectionSystem", StaticAccessorType.DoubleColon)]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		private static void ScriptingDirtyReflectionSystemInstance()
		{
		}
	}
}
