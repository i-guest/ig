using System;
using Unity.XGamingRuntime.Interop;

namespace Unity.XGamingRuntime
{
	public class XGameStreamingRegisterClientPropertiesChangedToken
	{
		internal Unity.XGamingRuntime.Interop.XGameStreamingRegisterClientPropertiesChangedToken interop { get; private set; }

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

		internal XGameStreamingRegisterClientPropertiesChangedToken(XGameStreamingClientId clientId, Unity.XGamingRuntime.Interop.XGameStreamingClientPropertiesChangedCallback callback, IntPtr context)
		{
		}

		public bool Unregister(XGameStreamingClientId clientId, bool wait)
		{
			return false;
		}
	}
}
