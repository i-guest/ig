using System;
using System.Runtime.InteropServices;
using Steamworks.Data;

namespace Steamworks
{
	internal class ISteamMatchmaking : SteamInterface
	{
		public const string Version = "SteamMatchMaking009";

		internal ISteamMatchmaking(bool IsGameServer)
		{
		}

		[PreserveSig]
		internal static extern IntPtr SteamAPI_SteamMatchmaking_v009();

		public override IntPtr GetUserInterfacePointer()
		{
			return (IntPtr)0;
		}

		[PreserveSig]
		private static extern int _GetFavoriteGameCount(IntPtr self);

		internal int GetFavoriteGameCount()
		{
			return 0;
		}

		[PreserveSig]
		private static extern bool _GetFavoriteGame(IntPtr self, int iGame, ref AppId pnAppID, ref uint pnIP, ref ushort pnConnPort, ref ushort pnQueryPort, ref uint punFlags, ref uint pRTime32LastPlayedOnServer);

		internal bool GetFavoriteGame(int iGame, ref AppId pnAppID, ref uint pnIP, ref ushort pnConnPort, ref ushort pnQueryPort, ref uint punFlags, ref uint pRTime32LastPlayedOnServer)
		{
			return false;
		}

		[PreserveSig]
		private static extern int _AddFavoriteGame(IntPtr self, AppId nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags, uint rTime32LastPlayedOnServer);

		internal int AddFavoriteGame(AppId nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags, uint rTime32LastPlayedOnServer)
		{
			return 0;
		}

		[PreserveSig]
		private static extern bool _RemoveFavoriteGame(IntPtr self, AppId nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags);

		internal bool RemoveFavoriteGame(AppId nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags)
		{
			return false;
		}

		[PreserveSig]
		private static extern SteamAPICall_t _RequestLobbyList(IntPtr self);

		internal CallResult<LobbyMatchList_t> RequestLobbyList()
		{
			return default(CallResult<LobbyMatchList_t>);
		}

		[PreserveSig]
		private static extern void _AddRequestLobbyListStringFilter(IntPtr self, string pchKeyToMatch, string pchValueToMatch, LobbyComparison eComparisonType);

		internal void AddRequestLobbyListStringFilter(string pchKeyToMatch, string pchValueToMatch, LobbyComparison eComparisonType)
		{
		}

		[PreserveSig]
		private static extern void _AddRequestLobbyListNumericalFilter(IntPtr self, string pchKeyToMatch, int nValueToMatch, LobbyComparison eComparisonType);

		internal void AddRequestLobbyListNumericalFilter(string pchKeyToMatch, int nValueToMatch, LobbyComparison eComparisonType)
		{
		}

		[PreserveSig]
		private static extern void _AddRequestLobbyListNearValueFilter(IntPtr self, string pchKeyToMatch, int nValueToBeCloseTo);

		internal void AddRequestLobbyListNearValueFilter(string pchKeyToMatch, int nValueToBeCloseTo)
		{
		}

		[PreserveSig]
		private static extern void _AddRequestLobbyListFilterSlotsAvailable(IntPtr self, int nSlotsAvailable);

		internal void AddRequestLobbyListFilterSlotsAvailable(int nSlotsAvailable)
		{
		}

		[PreserveSig]
		private static extern void _AddRequestLobbyListDistanceFilter(IntPtr self, LobbyDistanceFilter eLobbyDistanceFilter);

		internal void AddRequestLobbyListDistanceFilter(LobbyDistanceFilter eLobbyDistanceFilter)
		{
		}

		[PreserveSig]
		private static extern void _AddRequestLobbyListResultCountFilter(IntPtr self, int cMaxResults);

		internal void AddRequestLobbyListResultCountFilter(int cMaxResults)
		{
		}

		[PreserveSig]
		private static extern void _AddRequestLobbyListCompatibleMembersFilter(IntPtr self, SteamId steamIDLobby);

		internal void AddRequestLobbyListCompatibleMembersFilter(SteamId steamIDLobby)
		{
		}

		[PreserveSig]
		private static extern SteamId _GetLobbyByIndex(IntPtr self, int iLobby);

		internal SteamId GetLobbyByIndex(int iLobby)
		{
			return default(SteamId);
		}

		[PreserveSig]
		private static extern SteamAPICall_t _CreateLobby(IntPtr self, LobbyType eLobbyType, int cMaxMembers);

		internal CallResult<LobbyCreated_t> CreateLobby(LobbyType eLobbyType, int cMaxMembers)
		{
			return default(CallResult<LobbyCreated_t>);
		}

		[PreserveSig]
		private static extern SteamAPICall_t _JoinLobby(IntPtr self, SteamId steamIDLobby);

		internal CallResult<LobbyEnter_t> JoinLobby(SteamId steamIDLobby)
		{
			return default(CallResult<LobbyEnter_t>);
		}

		[PreserveSig]
		private static extern void _LeaveLobby(IntPtr self, SteamId steamIDLobby);

		internal void LeaveLobby(SteamId steamIDLobby)
		{
		}

		[PreserveSig]
		private static extern bool _InviteUserToLobby(IntPtr self, SteamId steamIDLobby, SteamId steamIDInvitee);

		internal bool InviteUserToLobby(SteamId steamIDLobby, SteamId steamIDInvitee)
		{
			return false;
		}

		[PreserveSig]
		private static extern int _GetNumLobbyMembers(IntPtr self, SteamId steamIDLobby);

		internal int GetNumLobbyMembers(SteamId steamIDLobby)
		{
			return 0;
		}

		[PreserveSig]
		private static extern SteamId _GetLobbyMemberByIndex(IntPtr self, SteamId steamIDLobby, int iMember);

		internal SteamId GetLobbyMemberByIndex(SteamId steamIDLobby, int iMember)
		{
			return default(SteamId);
		}

		[PreserveSig]
		private static extern Utf8StringPointer _GetLobbyData(IntPtr self, SteamId steamIDLobby, string pchKey);

		internal string GetLobbyData(SteamId steamIDLobby, string pchKey)
		{
			return null;
		}

		[PreserveSig]
		private static extern bool _SetLobbyData(IntPtr self, SteamId steamIDLobby, string pchKey, string pchValue);

		internal bool SetLobbyData(SteamId steamIDLobby, string pchKey, string pchValue)
		{
			return false;
		}

		[PreserveSig]
		private static extern int _GetLobbyDataCount(IntPtr self, SteamId steamIDLobby);

		internal int GetLobbyDataCount(SteamId steamIDLobby)
		{
			return 0;
		}

		[PreserveSig]
		private static extern bool _GetLobbyDataByIndex(IntPtr self, SteamId steamIDLobby, int iLobbyData, IntPtr pchKey, int cchKeyBufferSize, IntPtr pchValue, int cchValueBufferSize);

		internal bool GetLobbyDataByIndex(SteamId steamIDLobby, int iLobbyData, out string pchKey, out string pchValue)
		{
			pchKey = null;
			pchValue = null;
			return false;
		}

		[PreserveSig]
		private static extern bool _DeleteLobbyData(IntPtr self, SteamId steamIDLobby, string pchKey);

		internal bool DeleteLobbyData(SteamId steamIDLobby, string pchKey)
		{
			return false;
		}

		[PreserveSig]
		private static extern Utf8StringPointer _GetLobbyMemberData(IntPtr self, SteamId steamIDLobby, SteamId steamIDUser, string pchKey);

		internal string GetLobbyMemberData(SteamId steamIDLobby, SteamId steamIDUser, string pchKey)
		{
			return null;
		}

		[PreserveSig]
		private static extern void _SetLobbyMemberData(IntPtr self, SteamId steamIDLobby, string pchKey, string pchValue);

		internal void SetLobbyMemberData(SteamId steamIDLobby, string pchKey, string pchValue)
		{
		}

		[PreserveSig]
		private static extern bool _SendLobbyChatMsg(IntPtr self, SteamId steamIDLobby, IntPtr pvMsgBody, int cubMsgBody);

		internal bool SendLobbyChatMsg(SteamId steamIDLobby, IntPtr pvMsgBody, int cubMsgBody)
		{
			return false;
		}

		[PreserveSig]
		private static extern int _GetLobbyChatEntry(IntPtr self, SteamId steamIDLobby, int iChatID, ref SteamId pSteamIDUser, IntPtr pvData, int cubData, ref ChatEntryType peChatEntryType);

		internal int GetLobbyChatEntry(SteamId steamIDLobby, int iChatID, ref SteamId pSteamIDUser, IntPtr pvData, int cubData, ref ChatEntryType peChatEntryType)
		{
			return 0;
		}

		[PreserveSig]
		private static extern bool _RequestLobbyData(IntPtr self, SteamId steamIDLobby);

		internal bool RequestLobbyData(SteamId steamIDLobby)
		{
			return false;
		}

		[PreserveSig]
		private static extern void _SetLobbyGameServer(IntPtr self, SteamId steamIDLobby, uint unGameServerIP, ushort unGameServerPort, SteamId steamIDGameServer);

		internal void SetLobbyGameServer(SteamId steamIDLobby, uint unGameServerIP, ushort unGameServerPort, SteamId steamIDGameServer)
		{
		}

		[PreserveSig]
		private static extern bool _GetLobbyGameServer(IntPtr self, SteamId steamIDLobby, ref uint punGameServerIP, ref ushort punGameServerPort, ref SteamId psteamIDGameServer);

		internal bool GetLobbyGameServer(SteamId steamIDLobby, ref uint punGameServerIP, ref ushort punGameServerPort, ref SteamId psteamIDGameServer)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _SetLobbyMemberLimit(IntPtr self, SteamId steamIDLobby, int cMaxMembers);

		internal bool SetLobbyMemberLimit(SteamId steamIDLobby, int cMaxMembers)
		{
			return false;
		}

		[PreserveSig]
		private static extern int _GetLobbyMemberLimit(IntPtr self, SteamId steamIDLobby);

		internal int GetLobbyMemberLimit(SteamId steamIDLobby)
		{
			return 0;
		}

		[PreserveSig]
		private static extern bool _SetLobbyType(IntPtr self, SteamId steamIDLobby, LobbyType eLobbyType);

		internal bool SetLobbyType(SteamId steamIDLobby, LobbyType eLobbyType)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _SetLobbyJoinable(IntPtr self, SteamId steamIDLobby, bool bLobbyJoinable);

		internal bool SetLobbyJoinable(SteamId steamIDLobby, bool bLobbyJoinable)
		{
			return false;
		}

		[PreserveSig]
		private static extern SteamId _GetLobbyOwner(IntPtr self, SteamId steamIDLobby);

		internal SteamId GetLobbyOwner(SteamId steamIDLobby)
		{
			return default(SteamId);
		}

		[PreserveSig]
		private static extern bool _SetLobbyOwner(IntPtr self, SteamId steamIDLobby, SteamId steamIDNewOwner);

		internal bool SetLobbyOwner(SteamId steamIDLobby, SteamId steamIDNewOwner)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _SetLinkedLobby(IntPtr self, SteamId steamIDLobby, SteamId steamIDLobbyDependent);

		internal bool SetLinkedLobby(SteamId steamIDLobby, SteamId steamIDLobbyDependent)
		{
			return false;
		}
	}
}
