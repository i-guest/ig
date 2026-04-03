using System;
using Unity.XGamingRuntime.Interop;

namespace Unity.XGamingRuntime
{
	public class XNetworkingRegisterConnectivityHintChangedCallbackToken
	{
		internal Unity.XGamingRuntime.Interop.XNetworkingRegisterConnectivityHintChangedCallbackToken interop;

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

		internal XNetworkingRegisterConnectivityHintChangedCallbackToken(Unity.XGamingRuntime.Interop.XNetworkingConnectivityHintChangedCallback callback, IntPtr context)
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
