using System;
using System.Runtime.InteropServices;

namespace Unity.XGamingRuntime.Interop
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool XSpeechSynthesizerInstalledVoicesCallback([In] ref XSpeechSynthesizerVoiceInformation information, IntPtr context);
}
