using Unity.Audio;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Audio
{
	[RequiredByNativeCode]
	[NativeHeader("Modules/Audio/Public/ScriptableProcessors/ScriptBindings/ScriptableProcessor.bindings.h")]
	public struct ControlContext
	{
		private unsafe ControlHeader* m_Header;

		internal Handle m_Handle;

		internal unsafe ControlContext(void* headerThatShouldBeOfResourceType)
		{
			m_Header = null;
			m_Handle = default(Handle);
		}

		public bool Exists(ProcessorInstance processorInstance)
		{
			return false;
		}

		public GeneratorInstance.Configuration GetConfiguration(GeneratorInstance generatorInstance)
		{
			return default(GeneratorInstance.Configuration);
		}

		[RequiredByNativeCode(GenerateProxy = true)]
		internal static void CleanupHeader(ref ControlHeader header)
		{
		}
	}
}
