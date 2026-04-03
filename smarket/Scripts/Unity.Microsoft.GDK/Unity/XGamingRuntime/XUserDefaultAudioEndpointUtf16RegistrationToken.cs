using System;
using Unity.XGamingRuntime.Interop;

namespace Unity.XGamingRuntime
{
	public class XUserDefaultAudioEndpointUtf16RegistrationToken
	{
		internal Unity.XGamingRuntime.Interop.XUserDefaultAudioEndpointUtf16RegistrationToken interop;

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

		internal XUserDefaultAudioEndpointUtf16RegistrationToken(Unity.XGamingRuntime.Interop.XUserDefaultAudioEndpointUtf16ChangedCallback callback, IntPtr context)
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
