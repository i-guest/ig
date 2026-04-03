using System;
using System.Runtime.InteropServices;
using Steamworks.Data;

namespace Steamworks
{
	internal class ISteamUserStats : SteamInterface
	{
		public const string Version = "STEAMUSERSTATS_INTERFACE_VERSION013";

		internal ISteamUserStats(bool IsGameServer)
		{
		}

		[PreserveSig]
		internal static extern IntPtr SteamAPI_SteamUserStats_v013();

		public override IntPtr GetUserInterfacePointer()
		{
			return (IntPtr)0;
		}

		[PreserveSig]
		private static extern bool _GetStat(IntPtr self, string pchName, ref int pData);

		internal bool GetStat(string pchName, ref int pData)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _GetStat(IntPtr self, string pchName, ref float pData);

		internal bool GetStat(string pchName, ref float pData)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _SetStat(IntPtr self, string pchName, int nData);

		internal bool SetStat(string pchName, int nData)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _SetStat(IntPtr self, string pchName, float fData);

		internal bool SetStat(string pchName, float fData)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _UpdateAvgRateStat(IntPtr self, string pchName, float flCountThisSession, double dSessionLength);

		internal bool UpdateAvgRateStat(string pchName, float flCountThisSession, double dSessionLength)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _GetAchievement(IntPtr self, string pchName, ref bool pbAchieved);

		internal bool GetAchievement(string pchName, ref bool pbAchieved)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _SetAchievement(IntPtr self, string pchName);

		internal bool SetAchievement(string pchName)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _ClearAchievement(IntPtr self, string pchName);

		internal bool ClearAchievement(string pchName)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _GetAchievementAndUnlockTime(IntPtr self, string pchName, ref bool pbAchieved, ref uint punUnlockTime);

		internal bool GetAchievementAndUnlockTime(string pchName, ref bool pbAchieved, ref uint punUnlockTime)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _StoreStats(IntPtr self);

		internal bool StoreStats()
		{
			return false;
		}

		[PreserveSig]
		private static extern int _GetAchievementIcon(IntPtr self, string pchName);

		internal int GetAchievementIcon(string pchName)
		{
			return 0;
		}

		[PreserveSig]
		private static extern Utf8StringPointer _GetAchievementDisplayAttribute(IntPtr self, string pchName, string pchKey);

		internal string GetAchievementDisplayAttribute(string pchName, string pchKey)
		{
			return null;
		}

		[PreserveSig]
		private static extern bool _IndicateAchievementProgress(IntPtr self, string pchName, uint nCurProgress, uint nMaxProgress);

		internal bool IndicateAchievementProgress(string pchName, uint nCurProgress, uint nMaxProgress)
		{
			return false;
		}

		[PreserveSig]
		private static extern uint _GetNumAchievements(IntPtr self);

		internal uint GetNumAchievements()
		{
			return 0u;
		}

		[PreserveSig]
		private static extern Utf8StringPointer _GetAchievementName(IntPtr self, uint iAchievement);

		internal string GetAchievementName(uint iAchievement)
		{
			return null;
		}

		[PreserveSig]
		private static extern SteamAPICall_t _RequestUserStats(IntPtr self, SteamId steamIDUser);

		internal CallResult<UserStatsReceived_t> RequestUserStats(SteamId steamIDUser)
		{
			return default(CallResult<UserStatsReceived_t>);
		}

		[PreserveSig]
		private static extern bool _GetUserStat(IntPtr self, SteamId steamIDUser, string pchName, ref int pData);

		internal bool GetUserStat(SteamId steamIDUser, string pchName, ref int pData)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _GetUserStat(IntPtr self, SteamId steamIDUser, string pchName, ref float pData);

		internal bool GetUserStat(SteamId steamIDUser, string pchName, ref float pData)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _GetUserAchievement(IntPtr self, SteamId steamIDUser, string pchName, ref bool pbAchieved);

		internal bool GetUserAchievement(SteamId steamIDUser, string pchName, ref bool pbAchieved)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _GetUserAchievementAndUnlockTime(IntPtr self, SteamId steamIDUser, string pchName, ref bool pbAchieved, ref uint punUnlockTime);

		internal bool GetUserAchievementAndUnlockTime(SteamId steamIDUser, string pchName, ref bool pbAchieved, ref uint punUnlockTime)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _ResetAllStats(IntPtr self, bool bAchievementsToo);

		internal bool ResetAllStats(bool bAchievementsToo)
		{
			return false;
		}

		[PreserveSig]
		private static extern SteamAPICall_t _FindOrCreateLeaderboard(IntPtr self, string pchLeaderboardName, LeaderboardSort eLeaderboardSortMethod, LeaderboardDisplay eLeaderboardDisplayType);

		internal CallResult<LeaderboardFindResult_t> FindOrCreateLeaderboard(string pchLeaderboardName, LeaderboardSort eLeaderboardSortMethod, LeaderboardDisplay eLeaderboardDisplayType)
		{
			return default(CallResult<LeaderboardFindResult_t>);
		}

		[PreserveSig]
		private static extern SteamAPICall_t _FindLeaderboard(IntPtr self, string pchLeaderboardName);

		internal CallResult<LeaderboardFindResult_t> FindLeaderboard(string pchLeaderboardName)
		{
			return default(CallResult<LeaderboardFindResult_t>);
		}

		[PreserveSig]
		private static extern Utf8StringPointer _GetLeaderboardName(IntPtr self, SteamLeaderboard_t hSteamLeaderboard);

		internal string GetLeaderboardName(SteamLeaderboard_t hSteamLeaderboard)
		{
			return null;
		}

		[PreserveSig]
		private static extern int _GetLeaderboardEntryCount(IntPtr self, SteamLeaderboard_t hSteamLeaderboard);

		internal int GetLeaderboardEntryCount(SteamLeaderboard_t hSteamLeaderboard)
		{
			return 0;
		}

		[PreserveSig]
		private static extern LeaderboardSort _GetLeaderboardSortMethod(IntPtr self, SteamLeaderboard_t hSteamLeaderboard);

		internal LeaderboardSort GetLeaderboardSortMethod(SteamLeaderboard_t hSteamLeaderboard)
		{
			return default(LeaderboardSort);
		}

		[PreserveSig]
		private static extern LeaderboardDisplay _GetLeaderboardDisplayType(IntPtr self, SteamLeaderboard_t hSteamLeaderboard);

		internal LeaderboardDisplay GetLeaderboardDisplayType(SteamLeaderboard_t hSteamLeaderboard)
		{
			return default(LeaderboardDisplay);
		}

		[PreserveSig]
		private static extern SteamAPICall_t _DownloadLeaderboardEntries(IntPtr self, SteamLeaderboard_t hSteamLeaderboard, LeaderboardDataRequest eLeaderboardDataRequest, int nRangeStart, int nRangeEnd);

		internal CallResult<LeaderboardScoresDownloaded_t> DownloadLeaderboardEntries(SteamLeaderboard_t hSteamLeaderboard, LeaderboardDataRequest eLeaderboardDataRequest, int nRangeStart, int nRangeEnd)
		{
			return default(CallResult<LeaderboardScoresDownloaded_t>);
		}

		[PreserveSig]
		private static extern SteamAPICall_t _DownloadLeaderboardEntriesForUsers(IntPtr self, SteamLeaderboard_t hSteamLeaderboard, [In][Out] SteamId[] prgUsers, int cUsers);

		internal CallResult<LeaderboardScoresDownloaded_t> DownloadLeaderboardEntriesForUsers(SteamLeaderboard_t hSteamLeaderboard, [In][Out] SteamId[] prgUsers, int cUsers)
		{
			return default(CallResult<LeaderboardScoresDownloaded_t>);
		}

		[PreserveSig]
		private static extern bool _GetDownloadedLeaderboardEntry(IntPtr self, SteamLeaderboardEntries_t hSteamLeaderboardEntries, int index, ref LeaderboardEntry_t pLeaderboardEntry, [In][Out] int[] pDetails, int cDetailsMax);

		internal bool GetDownloadedLeaderboardEntry(SteamLeaderboardEntries_t hSteamLeaderboardEntries, int index, ref LeaderboardEntry_t pLeaderboardEntry, [In][Out] int[] pDetails, int cDetailsMax)
		{
			return false;
		}

		[PreserveSig]
		private static extern SteamAPICall_t _UploadLeaderboardScore(IntPtr self, SteamLeaderboard_t hSteamLeaderboard, LeaderboardUploadScoreMethod eLeaderboardUploadScoreMethod, int nScore, [In][Out] int[] pScoreDetails, int cScoreDetailsCount);

		internal CallResult<LeaderboardScoreUploaded_t> UploadLeaderboardScore(SteamLeaderboard_t hSteamLeaderboard, LeaderboardUploadScoreMethod eLeaderboardUploadScoreMethod, int nScore, [In][Out] int[] pScoreDetails, int cScoreDetailsCount)
		{
			return default(CallResult<LeaderboardScoreUploaded_t>);
		}

		[PreserveSig]
		private static extern SteamAPICall_t _AttachLeaderboardUGC(IntPtr self, SteamLeaderboard_t hSteamLeaderboard, UGCHandle_t hUGC);

		internal CallResult<LeaderboardUGCSet_t> AttachLeaderboardUGC(SteamLeaderboard_t hSteamLeaderboard, UGCHandle_t hUGC)
		{
			return default(CallResult<LeaderboardUGCSet_t>);
		}

		[PreserveSig]
		private static extern SteamAPICall_t _GetNumberOfCurrentPlayers(IntPtr self);

		internal CallResult<NumberOfCurrentPlayers_t> GetNumberOfCurrentPlayers()
		{
			return default(CallResult<NumberOfCurrentPlayers_t>);
		}

		[PreserveSig]
		private static extern SteamAPICall_t _RequestGlobalAchievementPercentages(IntPtr self);

		internal CallResult<GlobalAchievementPercentagesReady_t> RequestGlobalAchievementPercentages()
		{
			return default(CallResult<GlobalAchievementPercentagesReady_t>);
		}

		[PreserveSig]
		private static extern int _GetMostAchievedAchievementInfo(IntPtr self, IntPtr pchName, uint unNameBufLen, ref float pflPercent, ref bool pbAchieved);

		internal int GetMostAchievedAchievementInfo(out string pchName, ref float pflPercent, ref bool pbAchieved)
		{
			pchName = null;
			return 0;
		}

		[PreserveSig]
		private static extern int _GetNextMostAchievedAchievementInfo(IntPtr self, int iIteratorPrevious, IntPtr pchName, uint unNameBufLen, ref float pflPercent, ref bool pbAchieved);

		internal int GetNextMostAchievedAchievementInfo(int iIteratorPrevious, out string pchName, ref float pflPercent, ref bool pbAchieved)
		{
			pchName = null;
			return 0;
		}

		[PreserveSig]
		private static extern bool _GetAchievementAchievedPercent(IntPtr self, string pchName, ref float pflPercent);

		internal bool GetAchievementAchievedPercent(string pchName, ref float pflPercent)
		{
			return false;
		}

		[PreserveSig]
		private static extern SteamAPICall_t _RequestGlobalStats(IntPtr self, int nHistoryDays);

		internal CallResult<GlobalStatsReceived_t> RequestGlobalStats(int nHistoryDays)
		{
			return default(CallResult<GlobalStatsReceived_t>);
		}

		[PreserveSig]
		private static extern bool _GetGlobalStat(IntPtr self, string pchStatName, ref long pData);

		internal bool GetGlobalStat(string pchStatName, ref long pData)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _GetGlobalStat(IntPtr self, string pchStatName, ref double pData);

		internal bool GetGlobalStat(string pchStatName, ref double pData)
		{
			return false;
		}

		[PreserveSig]
		private static extern int _GetGlobalStatHistory(IntPtr self, string pchStatName, [In][Out] long[] pData, uint cubData);

		internal int GetGlobalStatHistory(string pchStatName, [In][Out] long[] pData, uint cubData)
		{
			return 0;
		}

		[PreserveSig]
		private static extern int _GetGlobalStatHistory(IntPtr self, string pchStatName, [In][Out] double[] pData, uint cubData);

		internal int GetGlobalStatHistory(string pchStatName, [In][Out] double[] pData, uint cubData)
		{
			return 0;
		}

		[PreserveSig]
		private static extern bool _GetAchievementProgressLimits(IntPtr self, string pchName, ref int pnMinProgress, ref int pnMaxProgress);

		internal bool GetAchievementProgressLimits(string pchName, ref int pnMinProgress, ref int pnMaxProgress)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _GetAchievementProgressLimits(IntPtr self, string pchName, ref float pfMinProgress, ref float pfMaxProgress);

		internal bool GetAchievementProgressLimits(string pchName, ref float pfMinProgress, ref float pfMaxProgress)
		{
			return false;
		}
	}
}
