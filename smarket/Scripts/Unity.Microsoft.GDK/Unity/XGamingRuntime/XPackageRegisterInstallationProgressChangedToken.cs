using System;
using Unity.XGamingRuntime.Interop;

namespace Unity.XGamingRuntime
{
	public class XPackageRegisterInstallationProgressChangedToken
	{
		internal Unity.XGamingRuntime.Interop.XPackageRegisterInstallationProgressChangedToken interop { get; private set; }

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

		public bool IsValid => false;

		internal XPackageRegisterInstallationProgressChangedToken(XPackageInstallationMonitorHandle handle, Unity.XGamingRuntime.Interop.XPackageInstallationProgressCallback callback, IntPtr context)
		{
		}

		public bool Unregister(XPackageInstallationMonitorHandle installationMonitor, bool wait)
		{
			return false;
		}

		public void Dispose()
		{
		}
	}
}
