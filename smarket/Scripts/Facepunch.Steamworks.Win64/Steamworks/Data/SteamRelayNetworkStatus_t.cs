using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 272)]
	internal struct SteamRelayNetworkStatus_t : ICallbackData
	{
		internal SteamNetworkingAvailability Avail;

		internal int PingMeasurementInProgress;

		internal SteamNetworkingAvailability AvailNetworkConfig;

		internal SteamNetworkingAvailability AvailAnyRelay;

		internal byte[] DebugMsg;

		public static int _datasize;

		public int DataSize => 0;

		public CallbackType CallbackType => default(CallbackType);

		internal string DebugMsgUTF8()
		{
			return null;
		}
	}
}
