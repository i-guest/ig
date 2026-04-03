using System;
using AOT;

namespace Unity.XGamingRuntime.Interop
{
	internal class XUserDeviceAssociationChangedRegistrationToken : XRegistrationToken<XUserDeviceAssociationChangedCallback>
	{
		[AOT.MonoPInvokeCallback(typeof(XUserDeviceAssociationChangedCallback))]
		private static void DeviceAssociationChanged(IntPtr context, ref XUserDeviceAssociationChange change)
		{
		}

		public XUserDeviceAssociationChangedRegistrationToken(XUserDeviceAssociationChangedCallback callback, IntPtr context)
			: base((XUserDeviceAssociationChangedCallback)default(_00210), (IntPtr)0, (XUserDeviceAssociationChangedCallback)default(_00210))
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
