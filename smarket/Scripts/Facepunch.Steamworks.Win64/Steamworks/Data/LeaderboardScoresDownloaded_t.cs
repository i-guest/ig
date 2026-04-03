using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 24)]
	internal struct LeaderboardScoresDownloaded_t : ICallbackData
	{
		internal ulong SteamLeaderboard;

		internal ulong SteamLeaderboardEntries;

		internal int CEntryCount;

		public static int _datasize;

		public int DataSize => 0;

		public CallbackType CallbackType => default(CallbackType);
	}
}
