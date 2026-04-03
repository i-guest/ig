using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 32)]
	internal struct LobbyChatUpdate_t : ICallbackData
	{
		internal ulong SteamIDLobby;

		internal ulong SteamIDUserChanged;

		internal ulong SteamIDMakingChange;

		internal uint GfChatMemberStateChange;

		public static int _datasize;

		public int DataSize => 0;

		public CallbackType CallbackType => default(CallbackType);
	}
}
