using System;
using System.Runtime.InteropServices;

namespace Steamworks
{
	internal class ISteamGameSearch : SteamInterface
	{
		public const string Version = "SteamMatchGameSearch001";

		internal ISteamGameSearch(bool IsGameServer)
		{
		}

		[PreserveSig]
		internal static extern IntPtr SteamAPI_SteamGameSearch_v001();

		public override IntPtr GetUserInterfacePointer()
		{
			return (IntPtr)0;
		}

		[PreserveSig]
		private static extern GameSearchErrorCode_t _AddGameSearchParams(IntPtr self, string pchKeyToFind, string pchValuesToFind);

		internal GameSearchErrorCode_t AddGameSearchParams(string pchKeyToFind, string pchValuesToFind)
		{
			return default(GameSearchErrorCode_t);
		}

		[PreserveSig]
		private static extern GameSearchErrorCode_t _SearchForGameWithLobby(IntPtr self, SteamId steamIDLobby, int nPlayerMin, int nPlayerMax);

		internal GameSearchErrorCode_t SearchForGameWithLobby(SteamId steamIDLobby, int nPlayerMin, int nPlayerMax)
		{
			return default(GameSearchErrorCode_t);
		}

		[PreserveSig]
		private static extern GameSearchErrorCode_t _SearchForGameSolo(IntPtr self, int nPlayerMin, int nPlayerMax);

		internal GameSearchErrorCode_t SearchForGameSolo(int nPlayerMin, int nPlayerMax)
		{
			return default(GameSearchErrorCode_t);
		}

		[PreserveSig]
		private static extern GameSearchErrorCode_t _AcceptGame(IntPtr self);

		internal GameSearchErrorCode_t AcceptGame()
		{
			return default(GameSearchErrorCode_t);
		}

		[PreserveSig]
		private static extern GameSearchErrorCode_t _DeclineGame(IntPtr self);

		internal GameSearchErrorCode_t DeclineGame()
		{
			return default(GameSearchErrorCode_t);
		}

		[PreserveSig]
		private static extern GameSearchErrorCode_t _RetrieveConnectionDetails(IntPtr self, SteamId steamIDHost, IntPtr pchConnectionDetails, int cubConnectionDetails);

		internal GameSearchErrorCode_t RetrieveConnectionDetails(SteamId steamIDHost, out string pchConnectionDetails)
		{
			pchConnectionDetails = null;
			return default(GameSearchErrorCode_t);
		}

		[PreserveSig]
		private static extern GameSearchErrorCode_t _EndGameSearch(IntPtr self);

		internal GameSearchErrorCode_t EndGameSearch()
		{
			return default(GameSearchErrorCode_t);
		}

		[PreserveSig]
		private static extern GameSearchErrorCode_t _SetGameHostParams(IntPtr self, string pchKey, string pchValue);

		internal GameSearchErrorCode_t SetGameHostParams(string pchKey, string pchValue)
		{
			return default(GameSearchErrorCode_t);
		}

		[PreserveSig]
		private static extern GameSearchErrorCode_t _SetConnectionDetails(IntPtr self, string pchConnectionDetails, int cubConnectionDetails);

		internal GameSearchErrorCode_t SetConnectionDetails(string pchConnectionDetails, int cubConnectionDetails)
		{
			return default(GameSearchErrorCode_t);
		}

		[PreserveSig]
		private static extern GameSearchErrorCode_t _RequestPlayersForGame(IntPtr self, int nPlayerMin, int nPlayerMax, int nMaxTeamSize);

		internal GameSearchErrorCode_t RequestPlayersForGame(int nPlayerMin, int nPlayerMax, int nMaxTeamSize)
		{
			return default(GameSearchErrorCode_t);
		}

		[PreserveSig]
		private static extern GameSearchErrorCode_t _HostConfirmGameStart(IntPtr self, ulong ullUniqueGameID);

		internal GameSearchErrorCode_t HostConfirmGameStart(ulong ullUniqueGameID)
		{
			return default(GameSearchErrorCode_t);
		}

		[PreserveSig]
		private static extern GameSearchErrorCode_t _CancelRequestPlayersForGame(IntPtr self);

		internal GameSearchErrorCode_t CancelRequestPlayersForGame()
		{
			return default(GameSearchErrorCode_t);
		}

		[PreserveSig]
		private static extern GameSearchErrorCode_t _SubmitPlayerResult(IntPtr self, ulong ullUniqueGameID, SteamId steamIDPlayer, PlayerResult_t EPlayerResult);

		internal GameSearchErrorCode_t SubmitPlayerResult(ulong ullUniqueGameID, SteamId steamIDPlayer, PlayerResult_t EPlayerResult)
		{
			return default(GameSearchErrorCode_t);
		}

		[PreserveSig]
		private static extern GameSearchErrorCode_t _EndGame(IntPtr self, ulong ullUniqueGameID);

		internal GameSearchErrorCode_t EndGame(ulong ullUniqueGameID)
		{
			return default(GameSearchErrorCode_t);
		}
	}
}
