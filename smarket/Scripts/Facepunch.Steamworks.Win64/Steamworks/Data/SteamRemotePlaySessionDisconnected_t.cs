using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 4)]
	internal struct SteamRemotePlaySessionDisconnected_t : ICallbackData
	{
		internal uint SessionID;

		public static int _datasize;

		public int DataSize => 0;

		public CallbackType CallbackType => default(CallbackType);
	}
}
