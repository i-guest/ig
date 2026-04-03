using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 24)]
	internal struct LobbyDataUpdate_t : ICallbackData
	{
		internal ulong SteamIDLobby;

		internal ulong SteamIDMember;

		internal byte Success;

		public static int _datasize;

		public int DataSize => 0;

		public CallbackType CallbackType => default(CallbackType);
	}
}
