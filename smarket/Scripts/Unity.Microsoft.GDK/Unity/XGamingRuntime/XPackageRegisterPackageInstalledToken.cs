using System;
using Unity.XGamingRuntime.Interop;

namespace Unity.XGamingRuntime
{
	public class XPackageRegisterPackageInstalledToken
	{
		internal Unity.XGamingRuntime.Interop.XPackageRegisterPackageInstalledToken interop { get; private set; }

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

		internal XPackageRegisterPackageInstalledToken(Unity.XGamingRuntime.Interop.XPackageInstalledCallback callback, IntPtr context)
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
