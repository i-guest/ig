using System;
using Unity.XGamingRuntime.Interop;

namespace Unity.XGamingRuntime
{
	public class XIsAppBroadcastingChangedRegistrationToken
	{
		internal Unity.XGamingRuntime.Interop.XIsAppBroadcastingChangedRegistrationToken interop { get; private set; }

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

		internal XIsAppBroadcastingChangedRegistrationToken(Unity.XGamingRuntime.Interop.XAppBroadcastMonitorCallback callback, IntPtr context)
		{
		}

		public bool Unregister(bool wait)
		{
			return false;
		}
	}
}
