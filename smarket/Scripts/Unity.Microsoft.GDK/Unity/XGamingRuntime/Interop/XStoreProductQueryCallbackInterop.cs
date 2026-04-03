using System;
using System.Runtime.InteropServices;

namespace Unity.XGamingRuntime.Interop
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool XStoreProductQueryCallbackInterop([In] ref XStoreProductInterop product, IntPtr context);
}
