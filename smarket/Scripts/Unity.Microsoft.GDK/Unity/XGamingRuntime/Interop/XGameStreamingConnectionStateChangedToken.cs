using System;
using AOT;

namespace Unity.XGamingRuntime.Interop
{
	internal class XGameStreamingConnectionStateChangedToken : XRegistrationToken<XGameStreamingConnectionStateChangedCallback>
	{
		[AOT.MonoPInvokeCallback(typeof(XGameStreamingConnectionStateChangedCallback))]
		private static void OnConnectionStateChanged(IntPtr context, XGameStreamingClientId client, XGameStreamingConnectionState state)
		{
		}

		public XGameStreamingConnectionStateChangedToken(XGameStreamingConnectionStateChangedCallback callback, IntPtr context)
			: base((XGameStreamingConnectionStateChangedCallback)default(_00210), (IntPtr)0, (XGameStreamingConnectionStateChangedCallback)default(_00210))
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
