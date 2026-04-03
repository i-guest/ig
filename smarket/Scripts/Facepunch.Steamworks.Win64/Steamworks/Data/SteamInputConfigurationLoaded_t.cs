using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 4, Size = 32)]
	internal struct SteamInputConfigurationLoaded_t : ICallbackData
	{
		internal AppId AppID;

		internal ulong DeviceHandle;

		internal ulong MappingCreator;

		internal uint MajorRevision;

		internal uint MinorRevision;

		internal bool UsesSteamInputAPI;

		internal bool UsesGamepadAPI;

		public static int _datasize;

		public int DataSize => 0;

		public CallbackType CallbackType => default(CallbackType);
	}
}
