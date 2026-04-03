using System.Runtime.InteropServices;
using Unity.Audio;
using UnityEngine.Bindings;

namespace UnityEngine.Audio
{
	[NativeHeader("Modules/Audio/Public/ScriptableProcessors/ScriptBindings/ScriptableProcessor.bindings.h")]
	internal static class ScriptableProcessorBindings
	{
		public unsafe static bool CheckProcessorExists(Handle handle, ControlHeader* control)
		{
			return false;
		}

		[NativeMethod(Name = "audio::CheckProcessorExists", IsFreeFunction = true)]
		private unsafe static bool CheckProcessorExistsInternal(Handle handle, void* control)
		{
			return false;
		}

		private unsafe static bool CheckProcessorExistsInternal_Injected([In] ref Handle handle, void* control)
		{
			return false;
		}
	}
}
