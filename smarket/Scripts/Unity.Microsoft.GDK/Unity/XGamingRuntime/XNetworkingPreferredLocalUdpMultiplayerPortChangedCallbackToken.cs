using System;
using Unity.XGamingRuntime.Interop;

namespace Unity.XGamingRuntime
{
	public class XNetworkingPreferredLocalUdpMultiplayerPortChangedCallbackToken
	{
		internal Unity.XGamingRuntime.Interop.XNetworkingPreferredLocalUdpMultiplayerPortChangedCallbackToken interop;

		public bool IsValid => false;

		public ulong Token
		{
			get
			{
				return 0uL;
			}
			set
			{
			}
		}

		internal XNetworkingPreferredLocalUdpMultiplayerPortChangedCallbackToken(Unity.XGamingRuntime.Interop.XNetworkingPreferredLocalUdpMultiplayerPortChangedCallback callback, IntPtr context)
		{
		}

		public bool Unregister(bool wait)
		{
			return false;
		}

		public void Dispose()
		{
		}
	}
}
