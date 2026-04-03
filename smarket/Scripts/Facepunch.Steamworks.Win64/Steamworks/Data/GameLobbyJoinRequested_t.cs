using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 4, Size = 16)]
	internal struct GameLobbyJoinRequested_t : ICallbackData
	{
		internal ulong SteamIDLobby;

		internal ulong SteamIDFriend;

		public static int _datasize;

		public int DataSize => 0;

		public CallbackType CallbackType => default(CallbackType);
	}
}
