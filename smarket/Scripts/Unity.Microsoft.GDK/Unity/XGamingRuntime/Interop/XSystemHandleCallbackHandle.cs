using System;
using AOT;

namespace Unity.XGamingRuntime.Interop
{
	internal class XSystemHandleCallbackHandle : XRegistrationToken<XSystemHandleCallback>
	{
		[AOT.MonoPInvokeCallback(typeof(XSystemHandleCallback))]
		private static void OnHandle(IntPtr handle, XSystemHandleType type, XSystemHandleCallbackReason reason, IntPtr context)
		{
		}

		public XSystemHandleCallbackHandle(XSystemHandleCallback callback, IntPtr context)
			: base((XSystemHandleCallback)default(_00210), (IntPtr)0, (XSystemHandleCallback)default(_00210))
		{
		}

		public void Unregister()
		{
		}

		protected override void DisposeInternal(bool disposing)
		{
		}
	}
}
