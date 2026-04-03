using System;
using Unity.XGamingRuntime.Interop;

namespace Unity.XGamingRuntime
{
	public class XGameStreamingConnectionStateChangedToken
	{
		internal Unity.XGamingRuntime.Interop.XGameStreamingConnectionStateChangedToken interop { get; private set; }

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

		internal XGameStreamingConnectionStateChangedToken(Unity.XGamingRuntime.Interop.XGameStreamingConnectionStateChangedCallback callback, IntPtr context)
		{
		}

		public bool Unregister(bool wait)
		{
			return false;
		}
	}
}
