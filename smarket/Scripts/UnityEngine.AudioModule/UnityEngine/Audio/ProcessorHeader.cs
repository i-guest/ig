using System;
using Unity.Audio;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Audio
{
	[NativeHeader("Modules/Audio/Public/ScriptableProcessors/ScriptableProcessor.h")]
	[RequiredByNativeCode]
	internal struct ProcessorHeader
	{
		private unsafe void* m_Control;

		internal Handle DualThreadHandle;

		internal IntPtr NativeProcessorFunction;

		internal IntPtr NativeControlFunction;

		internal IntPtr ProcessorReflectionData;

		internal IntPtr ControlReflectionData;
	}
}
