using System;
using Unity.XGamingRuntime.Interop;

namespace Unity.XGamingRuntime
{
	public class XUserDeviceAssociationChangedRegistrationToken
	{
		internal Unity.XGamingRuntime.Interop.XUserDeviceAssociationChangedRegistrationToken interop;

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

		internal XUserDeviceAssociationChangedRegistrationToken(Unity.XGamingRuntime.Interop.XUserDeviceAssociationChangedCallback callback, IntPtr context)
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
