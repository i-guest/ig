using System;
using System.Runtime.InteropServices;

namespace Unity.XGamingRuntime.Interop
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool XGameSaveContainerInfoCallback(XGameSaveContainerInfo info, IntPtr context);
}
