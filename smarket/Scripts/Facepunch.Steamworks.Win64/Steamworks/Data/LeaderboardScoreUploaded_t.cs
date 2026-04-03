using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 32)]
	internal struct LeaderboardScoreUploaded_t : ICallbackData
	{
		internal byte Success;

		internal ulong SteamLeaderboard;

		internal int Score;

		internal byte ScoreChanged;

		internal int GlobalRankNew;

		internal int GlobalRankPrevious;

		public static int _datasize;

		public int DataSize => 0;

		public CallbackType CallbackType => default(CallbackType);
	}
}
