using System;
using AOT;

namespace Unity.XGamingRuntime.Interop
{
	internal class XNetworkingRegisterConnectivityHintChangedCallbackToken : XRegistrationToken<XNetworkingConnectivityHintChangedCallback>
	{
		[AOT.MonoPInvokeCallback(typeof(XNetworkingConnectivityHintChangedCallback))]
		private static void OnConnectivityHintChanged(IntPtr context, XNetworkingConnectivityHint connectivityHint)
		{
		}

		public XNetworkingRegisterConnectivityHintChangedCallbackToken(XNetworkingConnectivityHintChangedCallback callback, IntPtr context)
			: base((XNetworkingConnectivityHintChangedCallback)default(_00210), (IntPtr)0, (XNetworkingConnectivityHintChangedCallback)default(_00210))
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
