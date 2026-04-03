using System;
using System.Runtime.InteropServices;
using Steamworks.Data;

namespace Steamworks
{
	internal class ISteamGameServer : SteamInterface
	{
		public const string Version = "SteamGameServer015";

		internal ISteamGameServer(bool IsGameServer)
		{
		}

		[PreserveSig]
		internal static extern IntPtr SteamAPI_SteamGameServer_v015();

		public override IntPtr GetServerInterfacePointer()
		{
			return (IntPtr)0;
		}

		[PreserveSig]
		private static extern void _SetProduct(IntPtr self, string pszProduct);

		internal void SetProduct(string pszProduct)
		{
		}

		[PreserveSig]
		private static extern void _SetGameDescription(IntPtr self, string pszGameDescription);

		internal void SetGameDescription(string pszGameDescription)
		{
		}

		[PreserveSig]
		private static extern void _SetModDir(IntPtr self, string pszModDir);

		internal void SetModDir(string pszModDir)
		{
		}

		[PreserveSig]
		private static extern void _SetDedicatedServer(IntPtr self, bool bDedicated);

		internal void SetDedicatedServer(bool bDedicated)
		{
		}

		[PreserveSig]
		private static extern void _LogOn(IntPtr self, string pszToken);

		internal void LogOn(string pszToken)
		{
		}

		[PreserveSig]
		private static extern void _LogOnAnonymous(IntPtr self);

		internal void LogOnAnonymous()
		{
		}

		[PreserveSig]
		private static extern void _LogOff(IntPtr self);

		internal void LogOff()
		{
		}

		[PreserveSig]
		private static extern bool _BLoggedOn(IntPtr self);

		internal bool BLoggedOn()
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _BSecure(IntPtr self);

		internal bool BSecure()
		{
			return false;
		}

		[PreserveSig]
		private static extern SteamId _GetSteamID(IntPtr self);

		internal SteamId GetSteamID()
		{
			return default(SteamId);
		}

		[PreserveSig]
		private static extern bool _WasRestartRequested(IntPtr self);

		internal bool WasRestartRequested()
		{
			return false;
		}

		[PreserveSig]
		private static extern void _SetMaxPlayerCount(IntPtr self, int cPlayersMax);

		internal void SetMaxPlayerCount(int cPlayersMax)
		{
		}

		[PreserveSig]
		private static extern void _SetBotPlayerCount(IntPtr self, int cBotplayers);

		internal void SetBotPlayerCount(int cBotplayers)
		{
		}

		[PreserveSig]
		private static extern void _SetServerName(IntPtr self, string pszServerName);

		internal void SetServerName(string pszServerName)
		{
		}

		[PreserveSig]
		private static extern void _SetMapName(IntPtr self, string pszMapName);

		internal void SetMapName(string pszMapName)
		{
		}

		[PreserveSig]
		private static extern void _SetPasswordProtected(IntPtr self, bool bPasswordProtected);

		internal void SetPasswordProtected(bool bPasswordProtected)
		{
		}

		[PreserveSig]
		private static extern void _SetSpectatorPort(IntPtr self, ushort unSpectatorPort);

		internal void SetSpectatorPort(ushort unSpectatorPort)
		{
		}

		[PreserveSig]
		private static extern void _SetSpectatorServerName(IntPtr self, string pszSpectatorServerName);

		internal void SetSpectatorServerName(string pszSpectatorServerName)
		{
		}

		[PreserveSig]
		private static extern void _ClearAllKeyValues(IntPtr self);

		internal void ClearAllKeyValues()
		{
		}

		[PreserveSig]
		private static extern void _SetKeyValue(IntPtr self, string pKey, string pValue);

		internal void SetKeyValue(string pKey, string pValue)
		{
		}

		[PreserveSig]
		private static extern void _SetGameTags(IntPtr self, string pchGameTags);

		internal void SetGameTags(string pchGameTags)
		{
		}

		[PreserveSig]
		private static extern void _SetGameData(IntPtr self, string pchGameData);

		internal void SetGameData(string pchGameData)
		{
		}

		[PreserveSig]
		private static extern void _SetRegion(IntPtr self, string pszRegion);

		internal void SetRegion(string pszRegion)
		{
		}

		[PreserveSig]
		private static extern void _SetAdvertiseServerActive(IntPtr self, bool bActive);

		internal void SetAdvertiseServerActive(bool bActive)
		{
		}

		[PreserveSig]
		private static extern HAuthTicket _GetAuthSessionTicket(IntPtr self, IntPtr pTicket, int cbMaxTicket, ref uint pcbTicket, ref NetIdentity pSnid);

		internal HAuthTicket GetAuthSessionTicket(IntPtr pTicket, int cbMaxTicket, ref uint pcbTicket, ref NetIdentity pSnid)
		{
			return default(HAuthTicket);
		}

		[PreserveSig]
		private static extern BeginAuthResult _BeginAuthSession(IntPtr self, IntPtr pAuthTicket, int cbAuthTicket, SteamId steamID);

		internal BeginAuthResult BeginAuthSession(IntPtr pAuthTicket, int cbAuthTicket, SteamId steamID)
		{
			return default(BeginAuthResult);
		}

		[PreserveSig]
		private static extern void _EndAuthSession(IntPtr self, SteamId steamID);

		internal void EndAuthSession(SteamId steamID)
		{
		}

		[PreserveSig]
		private static extern void _CancelAuthTicket(IntPtr self, HAuthTicket hAuthTicket);

		internal void CancelAuthTicket(HAuthTicket hAuthTicket)
		{
		}

		[PreserveSig]
		private static extern UserHasLicenseForAppResult _UserHasLicenseForApp(IntPtr self, SteamId steamID, AppId appID);

		internal UserHasLicenseForAppResult UserHasLicenseForApp(SteamId steamID, AppId appID)
		{
			return default(UserHasLicenseForAppResult);
		}

		[PreserveSig]
		private static extern bool _RequestUserGroupStatus(IntPtr self, SteamId steamIDUser, SteamId steamIDGroup);

		internal bool RequestUserGroupStatus(SteamId steamIDUser, SteamId steamIDGroup)
		{
			return false;
		}

		[PreserveSig]
		private static extern void _GetGameplayStats(IntPtr self);

		internal void GetGameplayStats()
		{
		}

		[PreserveSig]
		private static extern SteamAPICall_t _GetServerReputation(IntPtr self);

		internal CallResult<GSReputation_t> GetServerReputation()
		{
			return default(CallResult<GSReputation_t>);
		}

		[PreserveSig]
		private static extern SteamIPAddress _GetPublicIP(IntPtr self);

		internal SteamIPAddress GetPublicIP()
		{
			return default(SteamIPAddress);
		}

		[PreserveSig]
		private static extern bool _HandleIncomingPacket(IntPtr self, IntPtr pData, int cbData, uint srcIP, ushort srcPort);

		internal bool HandleIncomingPacket(IntPtr pData, int cbData, uint srcIP, ushort srcPort)
		{
			return false;
		}

		[PreserveSig]
		private static extern int _GetNextOutgoingPacket(IntPtr self, IntPtr pOut, int cbMaxOut, ref uint pNetAdr, ref ushort pPort);

		internal int GetNextOutgoingPacket(IntPtr pOut, int cbMaxOut, ref uint pNetAdr, ref ushort pPort)
		{
			return 0;
		}

		[PreserveSig]
		private static extern SteamAPICall_t _AssociateWithClan(IntPtr self, SteamId steamIDClan);

		internal CallResult<AssociateWithClanResult_t> AssociateWithClan(SteamId steamIDClan)
		{
			return default(CallResult<AssociateWithClanResult_t>);
		}

		[PreserveSig]
		private static extern SteamAPICall_t _ComputeNewPlayerCompatibility(IntPtr self, SteamId steamIDNewPlayer);

		internal CallResult<ComputeNewPlayerCompatibilityResult_t> ComputeNewPlayerCompatibility(SteamId steamIDNewPlayer)
		{
			return default(CallResult<ComputeNewPlayerCompatibilityResult_t>);
		}

		[PreserveSig]
		private static extern bool _SendUserConnectAndAuthenticate_DEPRECATED(IntPtr self, uint unIPClient, IntPtr pvAuthBlob, uint cubAuthBlobSize, ref SteamId pSteamIDUser);

		internal bool SendUserConnectAndAuthenticate_DEPRECATED(uint unIPClient, IntPtr pvAuthBlob, uint cubAuthBlobSize, ref SteamId pSteamIDUser)
		{
			return false;
		}

		[PreserveSig]
		private static extern SteamId _CreateUnauthenticatedUserConnection(IntPtr self);

		internal SteamId CreateUnauthenticatedUserConnection()
		{
			return default(SteamId);
		}

		[PreserveSig]
		private static extern void _SendUserDisconnect_DEPRECATED(IntPtr self, SteamId steamIDUser);

		internal void SendUserDisconnect_DEPRECATED(SteamId steamIDUser)
		{
		}

		[PreserveSig]
		private static extern bool _BUpdateUserData(IntPtr self, SteamId steamIDUser, string pchPlayerName, uint uScore);

		internal bool BUpdateUserData(SteamId steamIDUser, string pchPlayerName, uint uScore)
		{
			return false;
		}
	}
}
