using System;
using AOT;

namespace Unity.XGamingRuntime.Interop
{
	internal class XTaskQueueMonitorCallbackHandle : XRegistrationToken<XTaskQueueMonitorCallback>
	{
		private XTaskQueueHandle queue;

		[AOT.MonoPInvokeCallback(typeof(XTaskQueueMonitorCallback))]
		private static void OnMonitor(IntPtr context, IntPtr queue, XTaskQueuePort port)
		{
		}

		public XTaskQueueMonitorCallbackHandle(XTaskQueueHandle queue, XTaskQueueMonitorCallback callback, IntPtr context)
			: base((XTaskQueueMonitorCallback)default(_00210), (IntPtr)0, (XTaskQueueMonitorCallback)default(_00210))
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
