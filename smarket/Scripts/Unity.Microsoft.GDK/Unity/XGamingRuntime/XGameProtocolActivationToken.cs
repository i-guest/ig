using System;
using Unity.XGamingRuntime.Interop;

namespace Unity.XGamingRuntime
{
	public class XGameProtocolActivationToken
	{
		internal Unity.XGamingRuntime.Interop.XGameProtocolActivationToken interop { get; private set; }

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

		internal XGameProtocolActivationToken(Unity.XGamingRuntime.Interop.XGameProtocolActivationCallback callback, IntPtr context)
		{
		}

		public bool Unregister(bool wait)
		{
			return false;
		}
	}
}
