using System;
using AOT;

namespace Unity.XGamingRuntime.Interop
{
	internal class XMetadataPurgedToken : XRegistrationToken<XAppCaptureMetadataPurgedCallback>
	{
		[AOT.MonoPInvokeCallback(typeof(XAppCaptureMetadataPurgedCallback))]
		private static void OnXMetadataPurged(IntPtr context)
		{
		}

		public XMetadataPurgedToken(XAppCaptureMetadataPurgedCallback callback, IntPtr context)
			: base((XAppCaptureMetadataPurgedCallback)default(_00210), (IntPtr)0, (XAppCaptureMetadataPurgedCallback)default(_00210))
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
