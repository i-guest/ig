using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 4, Size = 12)]
	internal struct PSNGameBootInviteResult_t : ICallbackData
	{
		internal bool GameBootInviteExists;

		internal ulong SteamIDLobby;

		public static int _datasize;

		public int DataSize => 0;

		public CallbackType CallbackType => default(CallbackType);
	}
}
