using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 16)]
	internal struct LobbyCreated_t : ICallbackData
	{
		internal Result Result;

		internal ulong SteamIDLobby;

		public static int _datasize;

		public int DataSize => 0;

		public CallbackType CallbackType => default(CallbackType);
	}
}
