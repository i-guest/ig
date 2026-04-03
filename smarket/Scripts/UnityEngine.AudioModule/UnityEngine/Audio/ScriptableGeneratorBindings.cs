using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Audio
{
	[NativeHeader("Modules/Audio/Public/ScriptableProcessors/ScriptBindings/ScriptableProcessor.bindings.h")]
	internal static class ScriptableGeneratorBindings
	{
		[RequiredByNativeCode(GenerateProxy = true)]
		internal static void InstantiateGeneratorFromObject(Object generatorObjectDefinition, ref ControlHeader control, out GeneratorInstance runtimeHandle)
		{
			runtimeHandle = default(GeneratorInstance);
		}
	}
}
