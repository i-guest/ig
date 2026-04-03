using System;
using AOT;

namespace Unity.XGamingRuntime.Interop
{
	internal class PackageLicenseLostCallbackToken : XRegistrationToken<XStorePackageLicenseLostCallback>
	{
		private XStoreLicense licenseHandle;

		[AOT.MonoPInvokeCallback(typeof(XStorePackageLicenseLostCallback))]
		private static void OnPackageLicenseLostCallback(IntPtr context)
		{
		}

		public PackageLicenseLostCallbackToken(XStoreLicense licenseHandle, XStorePackageLicenseLostCallback callback, IntPtr context)
			: base((XStorePackageLicenseLostCallback)default(_00210), (IntPtr)0, (XStorePackageLicenseLostCallback)default(_00210))
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
