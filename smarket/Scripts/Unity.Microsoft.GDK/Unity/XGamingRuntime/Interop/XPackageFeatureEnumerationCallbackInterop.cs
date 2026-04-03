using System;
using System.Runtime.InteropServices;

namespace Unity.XGamingRuntime.Interop
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool XPackageFeatureEnumerationCallbackInterop(IntPtr context, XPackageFeature feature);
}
