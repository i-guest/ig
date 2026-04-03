using System;
using AOT;

namespace Unity.XGamingRuntime.Interop
{
	internal class XTaskQueueWaiterCallbackHandle : XRegistrationToken<XTaskQueueCallback>
	{
		private XTaskQueueHandle queue;

		[AOT.MonoPInvokeCallback(typeof(XTaskQueueCallback))]
		private static void OnWaiter(IntPtr context, bool canceled)
		{
		}

		public XTaskQueueWaiterCallbackHandle(XTaskQueueHandle queue, XTaskQueueCallback callback, IntPtr context)
			: base((XTaskQueueCallback)default(_00210), (IntPtr)0, (XTaskQueueCallback)default(_00210))
		{
		}

		public void Unregister(XTaskQueueHandle queue)
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
