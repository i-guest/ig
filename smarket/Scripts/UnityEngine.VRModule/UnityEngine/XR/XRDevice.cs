using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.XR
{
	[Obsolete("UnityEngine.VRModule is deprecated and will be removed in a future version. Please use the APIs in the UnityEngine.XRModule instead")]
	[NativeConditional("ENABLE_VR")]
	public static class XRDevice
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action<string> deviceLoaded;

		[RequiredByNativeCode]
		private static void InvokeDeviceLoaded(string loadedDeviceName)
		{
		}
	}
}
