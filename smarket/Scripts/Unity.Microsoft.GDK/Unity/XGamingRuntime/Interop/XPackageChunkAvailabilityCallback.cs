using System;
using System.Runtime.InteropServices;

namespace Unity.XGamingRuntime.Interop
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool XPackageChunkAvailabilityCallback(IntPtr context, XPackageChunkSelectorInterop selector, XPackageChunkAvailability availability);
}
