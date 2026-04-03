using System;
using AOT;

namespace Unity.XGamingRuntime.Interop
{
	internal class XPackageRegisterPackageInstalledToken : XRegistrationToken<XPackageInstalledCallback>
	{
		[AOT.MonoPInvokeCallback(typeof(XPackageInstalledCallback))]
		private static void OnPackageInstalled(IntPtr context, XPackageDetails details)
		{
		}

		public XPackageRegisterPackageInstalledToken(XPackageInstalledCallback callback, IntPtr context)
			: base((XPackageInstalledCallback)default(_00210), (IntPtr)0, (XPackageInstalledCallback)default(_00210))
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
