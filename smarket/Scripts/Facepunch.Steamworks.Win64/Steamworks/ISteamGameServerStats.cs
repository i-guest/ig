using System;
using System.Runtime.InteropServices;
using Steamworks.Data;

namespace Steamworks
{
	internal class ISteamGameServerStats : SteamInterface
	{
		public const string Version = "SteamGameServerStats001";

		internal ISteamGameServerStats(bool IsGameServer)
		{
		}

		[PreserveSig]
		internal static extern IntPtr SteamAPI_SteamGameServerStats_v001();

		public override IntPtr GetServerInterfacePointer()
		{
			return (IntPtr)0;
		}

		[PreserveSig]
		private static extern SteamAPICall_t _RequestUserStats(IntPtr self, SteamId steamIDUser);

		internal CallResult<GSStatsReceived_t> RequestUserStats(SteamId steamIDUser)
		{
			return default(CallResult<GSStatsReceived_t>);
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
		private static extern bool _SetUserStat(IntPtr self, SteamId steamIDUser, string pchName, int nData);

		internal bool SetUserStat(SteamId steamIDUser, string pchName, int nData)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _SetUserStat(IntPtr self, SteamId steamIDUser, string pchName, float fData);

		internal bool SetUserStat(SteamId steamIDUser, string pchName, float fData)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _UpdateUserAvgRateStat(IntPtr self, SteamId steamIDUser, string pchName, float flCountThisSession, double dSessionLength);

		internal bool UpdateUserAvgRateStat(SteamId steamIDUser, string pchName, float flCountThisSession, double dSessionLength)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _SetUserAchievement(IntPtr self, SteamId steamIDUser, string pchName);

		internal bool SetUserAchievement(SteamId steamIDUser, string pchName)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _ClearUserAchievement(IntPtr self, SteamId steamIDUser, string pchName);

		internal bool ClearUserAchievement(SteamId steamIDUser, string pchName)
		{
			return false;
		}

		[PreserveSig]
		private static extern SteamAPICall_t _StoreUserStats(IntPtr self, SteamId steamIDUser);

		internal CallResult<GSStatsStored_t> StoreUserStats(SteamId steamIDUser)
		{
			return default(CallResult<GSStatsStored_t>);
		}
	}
}
