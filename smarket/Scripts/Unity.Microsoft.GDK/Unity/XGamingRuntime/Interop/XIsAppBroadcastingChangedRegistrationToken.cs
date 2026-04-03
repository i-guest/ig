using System;
using AOT;

namespace Unity.XGamingRuntime.Interop
{
	internal class XIsAppBroadcastingChangedRegistrationToken : XRegistrationToken<XAppBroadcastMonitorCallback>
	{
		[AOT.MonoPInvokeCallback(typeof(XAppBroadcastMonitorCallback))]
		private static void OnIsAppBroadcastingChanged(IntPtr context)
		{
		}

		public XIsAppBroadcastingChangedRegistrationToken(XAppBroadcastMonitorCallback callback, IntPtr context)
			: base((XAppBroadcastMonitorCallback)default(_00210), (IntPtr)0, (XAppBroadcastMonitorCallback)default(_00210))
		{
		}

		public bool Unregister(bool wait)
		{
			return false;
		}

		protected override void DisposeInternal(bool disposing)
		{
		}
	}
}
