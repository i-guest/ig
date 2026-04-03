using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 4, Size = 24)]
	internal struct FriendGameInfo_t
	{
		internal GameId GameID;

		internal uint GameIP;

		internal ushort GamePort;

		internal ushort QueryPort;

		internal ulong SteamIDLobby;
	}
}
