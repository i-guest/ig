using System;
using Unity.XGamingRuntime.Interop;

namespace Unity.XGamingRuntime
{
	public class GameLicenseChangedCallbackToken
	{
		internal Unity.XGamingRuntime.Interop.GameLicenseChangedCallbackToken interop { get; private set; }

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

		internal GameLicenseChangedCallbackToken(XStoreContext storeContext, Unity.XGamingRuntime.Interop.XStoreGameLicenseChangedCallback callback, IntPtr context)
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
