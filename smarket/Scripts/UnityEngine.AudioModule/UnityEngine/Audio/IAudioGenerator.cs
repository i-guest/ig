using UnityEngine.Scripting;

namespace UnityEngine.Audio
{
	[UsedByNativeCode]
	public interface IAudioGenerator : GeneratorInstance.ICapabilities
	{
		GeneratorInstance CreateInstance(ControlContext context, AudioFormat? nestedFormat, ProcessorInstance.CreationParameters creationParameters);
	}
}
