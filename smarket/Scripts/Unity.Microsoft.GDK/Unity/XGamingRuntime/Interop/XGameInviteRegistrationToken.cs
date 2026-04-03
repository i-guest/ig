using System;
using AOT;

namespace Unity.XGamingRuntime.Interop
{
	internal class XGameInviteRegistrationToken : XRegistrationToken<XGameInviteEventCallback>
	{
		[AOT.MonoPInvokeCallback(typeof(XGameInviteEventCallback))]
		private static void OnInvite(IntPtr context, string inviteUri)
		{
		}

		internal XGameInviteRegistrationToken(XGameInviteEventCallback callback, IntPtr context)
			: base((XGameInviteEventCallback)default(_00210), (IntPtr)0, (XGameInviteEventCallback)default(_00210))
		{
		}

		public bool Unregister(bool wait)
		{
			return false;
		}

		protected override void DisposeInternal(bool disposing)
		{
		}
	}
}
