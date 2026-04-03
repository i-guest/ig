namespace Steamworks.Data
{
	public struct LeaderboardUpdate
	{
		public int Score;

		public bool Changed;

		public int NewGlobalRank;

		public int OldGlobalRank;

		public int RankChange => 0;

		internal static LeaderboardUpdate From(LeaderboardScoreUploaded_t e)
		{
			return default(LeaderboardUpdate);
		}
	}
}
