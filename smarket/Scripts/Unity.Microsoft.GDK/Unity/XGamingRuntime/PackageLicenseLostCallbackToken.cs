using System;
using Unity.XGamingRuntime.Interop;

namespace Unity.XGamingRuntime
{
	public class PackageLicenseLostCallbackToken
	{
		internal Unity.XGamingRuntime.Interop.PackageLicenseLostCallbackToken interop { get; private set; }

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

		internal PackageLicenseLostCallbackToken(XStoreLicense licenseHandle, Unity.XGamingRuntime.Interop.XStorePackageLicenseLostCallback callback, IntPtr context)
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
