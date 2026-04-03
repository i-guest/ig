using System;
using AOT;

namespace Unity.XGamingRuntime.Interop
{
	internal class XTaskQueueCallbackHandle : XRegistrationToken<XTaskQueueCallback>
	{
		[AOT.MonoPInvokeCallback(typeof(XTaskQueueCallback))]
		private static void OnCallback(IntPtr context, bool canceled)
		{
		}

		public XTaskQueueCallbackHandle(XTaskQueueCallback callback, IntPtr context)
			: base((XTaskQueueCallback)default(_00210), (IntPtr)0, (XTaskQueueCallback)default(_00210))
		{
		}

		protected override void DisposeInternal(bool disposing)
		{
		}
	}
}
