using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 4, Size = 412)]
	internal struct FriendsEnumerateFollowingList_t : ICallbackData
	{
		internal Result Result;

		internal ulong[] GSteamID;

		internal int ResultsReturned;

		internal int TotalResultCount;

		public static int _datasize;

		public int DataSize => 0;

		public CallbackType CallbackType => default(CallbackType);
	}
}
