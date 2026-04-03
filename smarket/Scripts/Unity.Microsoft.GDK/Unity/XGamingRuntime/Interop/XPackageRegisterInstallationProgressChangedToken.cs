using System;
using AOT;

namespace Unity.XGamingRuntime.Interop
{
	internal class XPackageRegisterInstallationProgressChangedToken : XRegistrationToken<XPackageInstallationProgressCallback>
	{
		private XPackageInstallationMonitorHandle installationProgressChanged;

		[AOT.MonoPInvokeCallback(typeof(XPackageInstallationProgressCallback))]
		private static void OnInstallationProgress(IntPtr context, IntPtr monitor)
		{
		}

		public XPackageRegisterInstallationProgressChangedToken(XPackageInstallationMonitorHandle installationProgressChanged, XPackageInstallationProgressCallback callback, IntPtr context)
			: base((XPackageInstallationProgressCallback)default(_00210), (IntPtr)0, (XPackageInstallationProgressCallback)default(_00210))
		{
		}

		public bool Unregister(XPackageInstallationMonitorHandle installationProgressChanged, bool wait)
		{
			return false;
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
