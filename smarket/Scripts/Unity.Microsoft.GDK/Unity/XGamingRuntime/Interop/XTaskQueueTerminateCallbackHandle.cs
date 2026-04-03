using System;
using AOT;

namespace Unity.XGamingRuntime.Interop
{
	internal class XTaskQueueTerminateCallbackHandle : XRegistrationToken<XTaskQueueTerminatedCallback>
	{
		[AOT.MonoPInvokeCallback(typeof(XTaskQueueTerminatedCallback))]
		private static void OnTerminate(IntPtr context)
		{
		}

		public XTaskQueueTerminateCallbackHandle(XTaskQueueTerminatedCallback callback, IntPtr context)
			: base((XTaskQueueTerminatedCallback)default(_00210), (IntPtr)0, (XTaskQueueTerminatedCallback)default(_00210))
		{
		}

		protected override void DisposeInternal(bool disposing)
		{
		}
	}
}
