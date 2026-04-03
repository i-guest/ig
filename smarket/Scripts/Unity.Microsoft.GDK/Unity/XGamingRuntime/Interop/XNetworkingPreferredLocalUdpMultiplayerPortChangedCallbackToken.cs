using System;
using AOT;

namespace Unity.XGamingRuntime.Interop
{
	internal class XNetworkingPreferredLocalUdpMultiplayerPortChangedCallbackToken : XRegistrationToken<XNetworkingPreferredLocalUdpMultiplayerPortChangedCallback>
	{
		[AOT.MonoPInvokeCallback(typeof(XNetworkingPreferredLocalUdpMultiplayerPortChangedCallback))]
		private static void OnPreferredLocalUdpMultiplayerPortChanged(IntPtr context, ushort preferredLocalUdpMultiplayerPort)
		{
		}

		public XNetworkingPreferredLocalUdpMultiplayerPortChangedCallbackToken(XNetworkingPreferredLocalUdpMultiplayerPortChangedCallback callback, IntPtr context)
			: base((XNetworkingPreferredLocalUdpMultiplayerPortChangedCallback)default(_00210), (IntPtr)0, (XNetworkingPreferredLocalUdpMultiplayerPortChangedCallback)default(_00210))
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
