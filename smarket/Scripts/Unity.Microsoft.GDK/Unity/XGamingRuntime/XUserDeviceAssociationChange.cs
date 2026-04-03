using Unity.XGamingRuntime.Interop;

namespace Unity.XGamingRuntime
{
	public class XUserDeviceAssociationChange
	{
		internal APP_LOCAL_DEVICE_ID _deviceId;

		internal XUserLocalId _oldUser;

		internal XUserLocalId _newUser;

		public APP_LOCAL_DEVICE_ID DeviceId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public XUserLocalId OldUser
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public XUserLocalId NewUser
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal XUserDeviceAssociationChange(Unity.XGamingRuntime.Interop.XUserDeviceAssociationChange interop)
		{
		}

		public XUserDeviceAssociationChange()
		{
		}
	}
}
