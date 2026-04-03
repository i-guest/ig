using System;
using AOT;

namespace Unity.XGamingRuntime.Interop
{
	internal class XUserDefaultAudioEndpointUtf16RegistrationToken : XRegistrationToken<XUserDefaultAudioEndpointUtf16ChangedCallback>
	{
		[AOT.MonoPInvokeCallback(typeof(XUserDefaultAudioEndpointUtf16ChangedCallback))]
		private static void OnDefaultAudioEndpointUtf16Changed(IntPtr context, XUserLocalId user, XUserDefaultAudioEndpointKind defaultAudioEndpointKind, string endpointIdUtf16)
		{
		}

		public XUserDefaultAudioEndpointUtf16RegistrationToken(XUserDefaultAudioEndpointUtf16ChangedCallback callback, IntPtr context)
			: base((XUserDefaultAudioEndpointUtf16ChangedCallback)default(_00210), (IntPtr)0, (XUserDefaultAudioEndpointUtf16ChangedCallback)default(_00210))
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
