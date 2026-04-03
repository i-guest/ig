using System;
using AOT;

namespace Unity.XGamingRuntime.Interop
{
	internal class XUserChangeRegistrationToken : XRegistrationToken<XUserChangeEventCallback>
	{
		[AOT.MonoPInvokeCallback(typeof(XUserChangeEventCallback))]
		private static void OnChangeEvent(IntPtr context, XUserLocalId userLocalId, XUserChangeEvent changeEvent)
		{
		}

		public XUserChangeRegistrationToken(XUserChangeEventCallback callback, IntPtr context)
			: base((XUserChangeEventCallback)default(_00210), (IntPtr)0, (XUserChangeEventCallback)default(_00210))
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
