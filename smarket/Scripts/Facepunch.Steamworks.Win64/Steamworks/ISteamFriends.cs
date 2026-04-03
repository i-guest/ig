using System;
using System.Runtime.InteropServices;
using Steamworks.Data;

namespace Steamworks
{
	internal class ISteamFriends : SteamInterface
	{
		public const string Version = "SteamFriends017";

		internal ISteamFriends(bool IsGameServer)
		{
		}

		[PreserveSig]
		internal static extern IntPtr SteamAPI_SteamFriends_v017();

		public override IntPtr GetUserInterfacePointer()
		{
			return (IntPtr)0;
		}

		[PreserveSig]
		private static extern Utf8StringPointer _GetPersonaName(IntPtr self);

		internal string GetPersonaName()
		{
			return null;
		}

		[PreserveSig]
		private static extern SteamAPICall_t _SetPersonaName(IntPtr self, string pchPersonaName);

		internal CallResult<SetPersonaNameResponse_t> SetPersonaName(string pchPersonaName)
		{
			return default(CallResult<SetPersonaNameResponse_t>);
		}

		[PreserveSig]
		private static extern FriendState _GetPersonaState(IntPtr self);

		internal FriendState GetPersonaState()
		{
			return default(FriendState);
		}

		[PreserveSig]
		private static extern int _GetFriendCount(IntPtr self, int iFriendFlags);

		internal int GetFriendCount(int iFriendFlags)
		{
			return 0;
		}

		[PreserveSig]
		private static extern SteamId _GetFriendByIndex(IntPtr self, int iFriend, int iFriendFlags);

		internal SteamId GetFriendByIndex(int iFriend, int iFriendFlags)
		{
			return default(SteamId);
		}

		[PreserveSig]
		private static extern Relationship _GetFriendRelationship(IntPtr self, SteamId steamIDFriend);

		internal Relationship GetFriendRelationship(SteamId steamIDFriend)
		{
			return default(Relationship);
		}

		[PreserveSig]
		private static extern FriendState _GetFriendPersonaState(IntPtr self, SteamId steamIDFriend);

		internal FriendState GetFriendPersonaState(SteamId steamIDFriend)
		{
			return default(FriendState);
		}

		[PreserveSig]
		private static extern Utf8StringPointer _GetFriendPersonaName(IntPtr self, SteamId steamIDFriend);

		internal string GetFriendPersonaName(SteamId steamIDFriend)
		{
			return null;
		}

		[PreserveSig]
		private static extern bool _GetFriendGamePlayed(IntPtr self, SteamId steamIDFriend, ref FriendGameInfo_t pFriendGameInfo);

		internal bool GetFriendGamePlayed(SteamId steamIDFriend, ref FriendGameInfo_t pFriendGameInfo)
		{
			return false;
		}

		[PreserveSig]
		private static extern Utf8StringPointer _GetFriendPersonaNameHistory(IntPtr self, SteamId steamIDFriend, int iPersonaName);

		internal string GetFriendPersonaNameHistory(SteamId steamIDFriend, int iPersonaName)
		{
			return null;
		}

		[PreserveSig]
		private static extern int _GetFriendSteamLevel(IntPtr self, SteamId steamIDFriend);

		internal int GetFriendSteamLevel(SteamId steamIDFriend)
		{
			return 0;
		}

		[PreserveSig]
		private static extern Utf8StringPointer _GetPlayerNickname(IntPtr self, SteamId steamIDPlayer);

		internal string GetPlayerNickname(SteamId steamIDPlayer)
		{
			return null;
		}

		[PreserveSig]
		private static extern int _GetFriendsGroupCount(IntPtr self);

		internal int GetFriendsGroupCount()
		{
			return 0;
		}

		[PreserveSig]
		private static extern FriendsGroupID_t _GetFriendsGroupIDByIndex(IntPtr self, int iFG);

		internal FriendsGroupID_t GetFriendsGroupIDByIndex(int iFG)
		{
			return default(FriendsGroupID_t);
		}

		[PreserveSig]
		private static extern Utf8StringPointer _GetFriendsGroupName(IntPtr self, FriendsGroupID_t friendsGroupID);

		internal string GetFriendsGroupName(FriendsGroupID_t friendsGroupID)
		{
			return null;
		}

		[PreserveSig]
		private static extern int _GetFriendsGroupMembersCount(IntPtr self, FriendsGroupID_t friendsGroupID);

		internal int GetFriendsGroupMembersCount(FriendsGroupID_t friendsGroupID)
		{
			return 0;
		}

		[PreserveSig]
		private static extern void _GetFriendsGroupMembersList(IntPtr self, FriendsGroupID_t friendsGroupID, [In][Out] SteamId[] pOutSteamIDMembers, int nMembersCount);

		internal void GetFriendsGroupMembersList(FriendsGroupID_t friendsGroupID, [In][Out] SteamId[] pOutSteamIDMembers, int nMembersCount)
		{
		}

		[PreserveSig]
		private static extern bool _HasFriend(IntPtr self, SteamId steamIDFriend, int iFriendFlags);

		internal bool HasFriend(SteamId steamIDFriend, int iFriendFlags)
		{
			return false;
		}

		[PreserveSig]
		private static extern int _GetClanCount(IntPtr self);

		internal int GetClanCount()
		{
			return 0;
		}

		[PreserveSig]
		private static extern SteamId _GetClanByIndex(IntPtr self, int iClan);

		internal SteamId GetClanByIndex(int iClan)
		{
			return default(SteamId);
		}

		[PreserveSig]
		private static extern Utf8StringPointer _GetClanName(IntPtr self, SteamId steamIDClan);

		internal string GetClanName(SteamId steamIDClan)
		{
			return null;
		}

		[PreserveSig]
		private static extern Utf8StringPointer _GetClanTag(IntPtr self, SteamId steamIDClan);

		internal string GetClanTag(SteamId steamIDClan)
		{
			return null;
		}

		[PreserveSig]
		private static extern bool _GetClanActivityCounts(IntPtr self, SteamId steamIDClan, ref int pnOnline, ref int pnInGame, ref int pnChatting);

		internal bool GetClanActivityCounts(SteamId steamIDClan, ref int pnOnline, ref int pnInGame, ref int pnChatting)
		{
			return false;
		}

		[PreserveSig]
		private static extern SteamAPICall_t _DownloadClanActivityCounts(IntPtr self, [In][Out] SteamId[] psteamIDClans, int cClansToRequest);

		internal CallResult<DownloadClanActivityCountsResult_t> DownloadClanActivityCounts([In][Out] SteamId[] psteamIDClans, int cClansToRequest)
		{
			return default(CallResult<DownloadClanActivityCountsResult_t>);
		}

		[PreserveSig]
		private static extern int _GetFriendCountFromSource(IntPtr self, SteamId steamIDSource);

		internal int GetFriendCountFromSource(SteamId steamIDSource)
		{
			return 0;
		}

		[PreserveSig]
		private static extern SteamId _GetFriendFromSourceByIndex(IntPtr self, SteamId steamIDSource, int iFriend);

		internal SteamId GetFriendFromSourceByIndex(SteamId steamIDSource, int iFriend)
		{
			return default(SteamId);
		}

		[PreserveSig]
		private static extern bool _IsUserInSource(IntPtr self, SteamId steamIDUser, SteamId steamIDSource);

		internal bool IsUserInSource(SteamId steamIDUser, SteamId steamIDSource)
		{
			return false;
		}

		[PreserveSig]
		private static extern void _SetInGameVoiceSpeaking(IntPtr self, SteamId steamIDUser, bool bSpeaking);

		internal void SetInGameVoiceSpeaking(SteamId steamIDUser, bool bSpeaking)
		{
		}

		[PreserveSig]
		private static extern void _ActivateGameOverlay(IntPtr self, string pchDialog);

		internal void ActivateGameOverlay(string pchDialog)
		{
		}

		[PreserveSig]
		private static extern void _ActivateGameOverlayToUser(IntPtr self, string pchDialog, SteamId steamID);

		internal void ActivateGameOverlayToUser(string pchDialog, SteamId steamID)
		{
		}

		[PreserveSig]
		private static extern void _ActivateGameOverlayToWebPage(IntPtr self, string pchURL, ActivateGameOverlayToWebPageMode eMode);

		internal void ActivateGameOverlayToWebPage(string pchURL, ActivateGameOverlayToWebPageMode eMode)
		{
		}

		[PreserveSig]
		private static extern void _ActivateGameOverlayToStore(IntPtr self, AppId nAppID, OverlayToStoreFlag eFlag);

		internal void ActivateGameOverlayToStore(AppId nAppID, OverlayToStoreFlag eFlag)
		{
		}

		[PreserveSig]
		private static extern void _SetPlayedWith(IntPtr self, SteamId steamIDUserPlayedWith);

		internal void SetPlayedWith(SteamId steamIDUserPlayedWith)
		{
		}

		[PreserveSig]
		private static extern void _ActivateGameOverlayInviteDialog(IntPtr self, SteamId steamIDLobby);

		internal void ActivateGameOverlayInviteDialog(SteamId steamIDLobby)
		{
		}

		[PreserveSig]
		private static extern int _GetSmallFriendAvatar(IntPtr self, SteamId steamIDFriend);

		internal int GetSmallFriendAvatar(SteamId steamIDFriend)
		{
			return 0;
		}

		[PreserveSig]
		private static extern int _GetMediumFriendAvatar(IntPtr self, SteamId steamIDFriend);

		internal int GetMediumFriendAvatar(SteamId steamIDFriend)
		{
			return 0;
		}

		[PreserveSig]
		private static extern int _GetLargeFriendAvatar(IntPtr self, SteamId steamIDFriend);

		internal int GetLargeFriendAvatar(SteamId steamIDFriend)
		{
			return 0;
		}

		[PreserveSig]
		private static extern bool _RequestUserInformation(IntPtr self, SteamId steamIDUser, bool bRequireNameOnly);

		internal bool RequestUserInformation(SteamId steamIDUser, bool bRequireNameOnly)
		{
			return false;
		}

		[PreserveSig]
		private static extern SteamAPICall_t _RequestClanOfficerList(IntPtr self, SteamId steamIDClan);

		internal CallResult<ClanOfficerListResponse_t> RequestClanOfficerList(SteamId steamIDClan)
		{
			return default(CallResult<ClanOfficerListResponse_t>);
		}

		[PreserveSig]
		private static extern SteamId _GetClanOwner(IntPtr self, SteamId steamIDClan);

		internal SteamId GetClanOwner(SteamId steamIDClan)
		{
			return default(SteamId);
		}

		[PreserveSig]
		private static extern int _GetClanOfficerCount(IntPtr self, SteamId steamIDClan);

		internal int GetClanOfficerCount(SteamId steamIDClan)
		{
			return 0;
		}

		[PreserveSig]
		private static extern SteamId _GetClanOfficerByIndex(IntPtr self, SteamId steamIDClan, int iOfficer);

		internal SteamId GetClanOfficerByIndex(SteamId steamIDClan, int iOfficer)
		{
			return default(SteamId);
		}

		[PreserveSig]
		private static extern uint _GetUserRestrictions(IntPtr self);

		internal uint GetUserRestrictions()
		{
			return 0u;
		}

		[PreserveSig]
		private static extern bool _SetRichPresence(IntPtr self, string pchKey, string pchValue);

		internal bool SetRichPresence(string pchKey, string pchValue)
		{
			return false;
		}

		[PreserveSig]
		private static extern void _ClearRichPresence(IntPtr self);

		internal void ClearRichPresence()
		{
		}

		[PreserveSig]
		private static extern Utf8StringPointer _GetFriendRichPresence(IntPtr self, SteamId steamIDFriend, string pchKey);

		internal string GetFriendRichPresence(SteamId steamIDFriend, string pchKey)
		{
			return null;
		}

		[PreserveSig]
		private static extern int _GetFriendRichPresenceKeyCount(IntPtr self, SteamId steamIDFriend);

		internal int GetFriendRichPresenceKeyCount(SteamId steamIDFriend)
		{
			return 0;
		}

		[PreserveSig]
		private static extern Utf8StringPointer _GetFriendRichPresenceKeyByIndex(IntPtr self, SteamId steamIDFriend, int iKey);

		internal string GetFriendRichPresenceKeyByIndex(SteamId steamIDFriend, int iKey)
		{
			return null;
		}

		[PreserveSig]
		private static extern void _RequestFriendRichPresence(IntPtr self, SteamId steamIDFriend);

		internal void RequestFriendRichPresence(SteamId steamIDFriend)
		{
		}

		[PreserveSig]
		private static extern bool _InviteUserToGame(IntPtr self, SteamId steamIDFriend, string pchConnectString);

		internal bool InviteUserToGame(SteamId steamIDFriend, string pchConnectString)
		{
			return false;
		}

		[PreserveSig]
		private static extern int _GetCoplayFriendCount(IntPtr self);

		internal int GetCoplayFriendCount()
		{
			return 0;
		}

		[PreserveSig]
		private static extern SteamId _GetCoplayFriend(IntPtr self, int iCoplayFriend);

		internal SteamId GetCoplayFriend(int iCoplayFriend)
		{
			return default(SteamId);
		}

		[PreserveSig]
		private static extern int _GetFriendCoplayTime(IntPtr self, SteamId steamIDFriend);

		internal int GetFriendCoplayTime(SteamId steamIDFriend)
		{
			return 0;
		}

		[PreserveSig]
		private static extern AppId _GetFriendCoplayGame(IntPtr self, SteamId steamIDFriend);

		internal AppId GetFriendCoplayGame(SteamId steamIDFriend)
		{
			return default(AppId);
		}

		[PreserveSig]
		private static extern SteamAPICall_t _JoinClanChatRoom(IntPtr self, SteamId steamIDClan);

		internal CallResult<JoinClanChatRoomCompletionResult_t> JoinClanChatRoom(SteamId steamIDClan)
		{
			return default(CallResult<JoinClanChatRoomCompletionResult_t>);
		}

		[PreserveSig]
		private static extern bool _LeaveClanChatRoom(IntPtr self, SteamId steamIDClan);

		internal bool LeaveClanChatRoom(SteamId steamIDClan)
		{
			return false;
		}

		[PreserveSig]
		private static extern int _GetClanChatMemberCount(IntPtr self, SteamId steamIDClan);

		internal int GetClanChatMemberCount(SteamId steamIDClan)
		{
			return 0;
		}

		[PreserveSig]
		private static extern SteamId _GetChatMemberByIndex(IntPtr self, SteamId steamIDClan, int iUser);

		internal SteamId GetChatMemberByIndex(SteamId steamIDClan, int iUser)
		{
			return default(SteamId);
		}

		[PreserveSig]
		private static extern bool _SendClanChatMessage(IntPtr self, SteamId steamIDClanChat, string pchText);

		internal bool SendClanChatMessage(SteamId steamIDClanChat, string pchText)
		{
			return false;
		}

		[PreserveSig]
		private static extern int _GetClanChatMessage(IntPtr self, SteamId steamIDClanChat, int iMessage, IntPtr prgchText, int cchTextMax, ref ChatEntryType peChatEntryType, ref SteamId psteamidChatter);

		internal int GetClanChatMessage(SteamId steamIDClanChat, int iMessage, IntPtr prgchText, int cchTextMax, ref ChatEntryType peChatEntryType, ref SteamId psteamidChatter)
		{
			return 0;
		}

		[PreserveSig]
		private static extern bool _IsClanChatAdmin(IntPtr self, SteamId steamIDClanChat, SteamId steamIDUser);

		internal bool IsClanChatAdmin(SteamId steamIDClanChat, SteamId steamIDUser)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _IsClanChatWindowOpenInSteam(IntPtr self, SteamId steamIDClanChat);

		internal bool IsClanChatWindowOpenInSteam(SteamId steamIDClanChat)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _OpenClanChatWindowInSteam(IntPtr self, SteamId steamIDClanChat);

		internal bool OpenClanChatWindowInSteam(SteamId steamIDClanChat)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _CloseClanChatWindowInSteam(IntPtr self, SteamId steamIDClanChat);

		internal bool CloseClanChatWindowInSteam(SteamId steamIDClanChat)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _SetListenForFriendsMessages(IntPtr self, bool bInterceptEnabled);

		internal bool SetListenForFriendsMessages(bool bInterceptEnabled)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _ReplyToFriendMessage(IntPtr self, SteamId steamIDFriend, string pchMsgToSend);

		internal bool ReplyToFriendMessage(SteamId steamIDFriend, string pchMsgToSend)
		{
			return false;
		}

		[PreserveSig]
		private static extern int _GetFriendMessage(IntPtr self, SteamId steamIDFriend, int iMessageID, IntPtr pvData, int cubData, ref ChatEntryType peChatEntryType);

		internal int GetFriendMessage(SteamId steamIDFriend, int iMessageID, IntPtr pvData, int cubData, ref ChatEntryType peChatEntryType)
		{
			return 0;
		}

		[PreserveSig]
		private static extern SteamAPICall_t _GetFollowerCount(IntPtr self, SteamId steamID);

		internal CallResult<FriendsGetFollowerCount_t> GetFollowerCount(SteamId steamID)
		{
			return default(CallResult<FriendsGetFollowerCount_t>);
		}

		[PreserveSig]
		private static extern SteamAPICall_t _IsFollowing(IntPtr self, SteamId steamID);

		internal CallResult<FriendsIsFollowing_t> IsFollowing(SteamId steamID)
		{
			return default(CallResult<FriendsIsFollowing_t>);
		}

		[PreserveSig]
		private static extern SteamAPICall_t _EnumerateFollowingList(IntPtr self, uint unStartIndex);

		internal CallResult<FriendsEnumerateFollowingList_t> EnumerateFollowingList(uint unStartIndex)
		{
			return default(CallResult<FriendsEnumerateFollowingList_t>);
		}

		[PreserveSig]
		private static extern bool _IsClanPublic(IntPtr self, SteamId steamIDClan);

		internal bool IsClanPublic(SteamId steamIDClan)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _IsClanOfficialGameGroup(IntPtr self, SteamId steamIDClan);

		internal bool IsClanOfficialGameGroup(SteamId steamIDClan)
		{
			return false;
		}

		[PreserveSig]
		private static extern int _GetNumChatsWithUnreadPriorityMessages(IntPtr self);

		internal int GetNumChatsWithUnreadPriorityMessages()
		{
			return 0;
		}

		[PreserveSig]
		private static extern void _ActivateGameOverlayRemotePlayTogetherInviteDialog(IntPtr self, SteamId steamIDLobby);

		internal void ActivateGameOverlayRemotePlayTogetherInviteDialog(SteamId steamIDLobby)
		{
		}

		[PreserveSig]
		private static extern bool _RegisterProtocolInOverlayBrowser(IntPtr self, string pchProtocol);

		internal bool RegisterProtocolInOverlayBrowser(string pchProtocol)
		{
			return false;
		}

		[PreserveSig]
		private static extern void _ActivateGameOverlayInviteDialogConnectString(IntPtr self, string pchConnectString);

		internal void ActivateGameOverlayInviteDialogConnectString(string pchConnectString)
		{
		}

		[PreserveSig]
		private static extern SteamAPICall_t _RequestEquippedProfileItems(IntPtr self, SteamId steamID);

		internal CallResult<EquippedProfileItems_t> RequestEquippedProfileItems(SteamId steamID)
		{
			return default(CallResult<EquippedProfileItems_t>);
		}

		[PreserveSig]
		private static extern bool _BHasEquippedProfileItem(IntPtr self, SteamId steamID, CommunityProfileItemType itemType);

		internal bool BHasEquippedProfileItem(SteamId steamID, CommunityProfileItemType itemType)
		{
			return false;
		}

		[PreserveSig]
		private static extern Utf8StringPointer _GetProfileItemPropertyString(IntPtr self, SteamId steamID, CommunityProfileItemType itemType, CommunityProfileItemProperty prop);

		internal string GetProfileItemPropertyString(SteamId steamID, CommunityProfileItemType itemType, CommunityProfileItemProperty prop)
		{
			return null;
		}

		[PreserveSig]
		private static extern uint _GetProfileItemPropertyUint(IntPtr self, SteamId steamID, CommunityProfileItemType itemType, CommunityProfileItemProperty prop);

		internal uint GetProfileItemPropertyUint(SteamId steamID, CommunityProfileItemType itemType, CommunityProfileItemProperty prop)
		{
			return 0u;
		}
	}
}
