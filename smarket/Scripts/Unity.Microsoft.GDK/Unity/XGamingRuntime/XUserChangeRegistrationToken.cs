using System;
using Unity.XGamingRuntime.Interop;

namespace Unity.XGamingRuntime
{
	public class XUserChangeRegistrationToken
	{
		internal Unity.XGamingRuntime.Interop.XUserChangeRegistrationToken interop;

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

		internal XUserChangeRegistrationToken(Unity.XGamingRuntime.Interop.XUserChangeEventCallback callback, IntPtr context)
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
