using System;
using AOT;

namespace Unity.XGamingRuntime.Interop
{
	internal class XGameProtocolActivationToken : XRegistrationToken<XGameProtocolActivationCallback>
	{
		[AOT.MonoPInvokeCallback(typeof(XGameProtocolActivationCallback))]
		private static void OnProtocolActivation(IntPtr context, string protocolUri)
		{
		}

		public XGameProtocolActivationToken(XGameProtocolActivationCallback callback, IntPtr context)
			: base((XGameProtocolActivationCallback)default(_00210), (IntPtr)0, (XGameProtocolActivationCallback)default(_00210))
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
