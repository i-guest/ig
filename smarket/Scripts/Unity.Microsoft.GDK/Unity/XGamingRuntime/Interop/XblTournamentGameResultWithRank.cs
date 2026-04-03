namespace Unity.XGamingRuntime.Interop
{
	internal struct XblTournamentGameResultWithRank
	{
		internal readonly XblTournamentGameResult Result;

		internal readonly ulong Ranking;

		internal XblTournamentGameResultWithRank(Unity.XGamingRuntime.XblTournamentGameResultWithRank publicObject)
		{
			Result = default(XblTournamentGameResult);
			Ranking = 0uL;
		}
	}
}
