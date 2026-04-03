using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 4, Size = 16)]
	internal struct FriendsIsFollowing_t : ICallbackData
	{
		internal Result Result;

		internal ulong SteamID;

		internal bool IsFollowing;

		public static int _datasize;

		public int DataSize => 0;

		public CallbackType CallbackType => default(CallbackType);
	}
}
