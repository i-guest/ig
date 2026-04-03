using System;
using AOT;

namespace Unity.XGamingRuntime.Interop
{
	internal class GameLicenseChangedCallbackToken : XRegistrationToken<XStoreGameLicenseChangedCallback>
	{
		private XStoreContext storeContext;

		[AOT.MonoPInvokeCallback(typeof(XStoreGameLicenseChangedCallback))]
		private static void OnGameLicenseChanged(IntPtr context)
		{
		}

		public GameLicenseChangedCallbackToken(XStoreContext storeContext, XStoreGameLicenseChangedCallback callback, IntPtr context)
			: base((XStoreGameLicenseChangedCallback)default(_00210), (IntPtr)0, (XStoreGameLicenseChangedCallback)default(_00210))
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
