using System;
using AOT;

namespace Unity.XGamingRuntime.Interop
{
	internal class XGameStreamingRegisterClientPropertiesChangedToken : XRegistrationToken<XGameStreamingClientPropertiesChangedCallback>
	{
		private XGameStreamingClientId clientId;

		[AOT.MonoPInvokeCallback(typeof(XGameStreamingClientPropertiesChangedCallback))]
		private static void OnClientPropertiesChanged(IntPtr context, XGameStreamingClientId client, uint updatedPropertiesCount, XGameStreamingClientProperty[] updatedProperties)
		{
		}

		public XGameStreamingRegisterClientPropertiesChangedToken(XGameStreamingClientId clientId, XGameStreamingClientPropertiesChangedCallback callback, IntPtr context)
			: base((XGameStreamingClientPropertiesChangedCallback)default(_00210), (IntPtr)0, (XGameStreamingClientPropertiesChangedCallback)default(_00210))
		{
		}

		public bool Unregister(XGameStreamingClientId clientId, bool wait)
		{
			return false;
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
