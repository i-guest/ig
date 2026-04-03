using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 264)]
	internal struct GameRichPresenceJoinRequested_t : ICallbackData
	{
		internal ulong SteamIDFriend;

		internal byte[] Connect;

		public static int _datasize;

		public int DataSize => 0;

		public CallbackType CallbackType => default(CallbackType);

		internal string ConnectUTF8()
		{
			return null;
		}
	}
}
