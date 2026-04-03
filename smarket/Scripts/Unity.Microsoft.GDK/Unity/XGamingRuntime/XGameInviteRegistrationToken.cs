using System;
using Unity.XGamingRuntime.Interop;

namespace Unity.XGamingRuntime
{
	public class XGameInviteRegistrationToken
	{
		internal Unity.XGamingRuntime.Interop.XGameInviteRegistrationToken interop { get; private set; }

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

		internal XGameInviteRegistrationToken(Unity.XGamingRuntime.Interop.XGameInviteEventCallback callback, IntPtr context)
		{
		}

		public bool Unregister(bool wait)
		{
			return false;
		}
	}
}
