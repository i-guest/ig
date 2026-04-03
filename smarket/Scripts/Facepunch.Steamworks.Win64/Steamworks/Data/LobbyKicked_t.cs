using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 24)]
	internal struct LobbyKicked_t : ICallbackData
	{
		internal ulong SteamIDLobby;

		internal ulong SteamIDAdmin;

		internal byte KickedDueToDisconnect;

		public static int _datasize;

		public int DataSize => 0;

		public CallbackType CallbackType => default(CallbackType);
	}
}
