using System;
using System.Runtime.InteropServices;
using Steamworks.Data;

namespace Steamworks
{
	internal class ISteamUser : SteamInterface
	{
		public const string Version = "SteamUser023";

		internal ISteamUser(bool IsGameServer)
		{
		}

		[PreserveSig]
		internal static extern IntPtr SteamAPI_SteamUser_v023();

		public override IntPtr GetUserInterfacePointer()
		{
			return (IntPtr)0;
		}

		[PreserveSig]
		private static extern HSteamUser _GetHSteamUser(IntPtr self);

		internal HSteamUser GetHSteamUser()
		{
			return default(HSteamUser);
		}

		[PreserveSig]
		private static extern bool _BLoggedOn(IntPtr self);

		internal bool BLoggedOn()
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
		private static extern int _InitiateGameConnection_DEPRECATED(IntPtr self, IntPtr pAuthBlob, int cbMaxAuthBlob, SteamId steamIDGameServer, uint unIPServer, ushort usPortServer, bool bSecure);

		internal int InitiateGameConnection_DEPRECATED(IntPtr pAuthBlob, int cbMaxAuthBlob, SteamId steamIDGameServer, uint unIPServer, ushort usPortServer, bool bSecure)
		{
			return 0;
		}

		[PreserveSig]
		private static extern void _TerminateGameConnection_DEPRECATED(IntPtr self, uint unIPServer, ushort usPortServer);

		internal void TerminateGameConnection_DEPRECATED(uint unIPServer, ushort usPortServer)
		{
		}

		[PreserveSig]
		private static extern void _TrackAppUsageEvent(IntPtr self, GameId gameID, int eAppUsageEvent, string pchExtraInfo);

		internal void TrackAppUsageEvent(GameId gameID, int eAppUsageEvent, string pchExtraInfo)
		{
		}

		[PreserveSig]
		private static extern bool _GetUserDataFolder(IntPtr self, IntPtr pchBuffer, int cubBuffer);

		internal bool GetUserDataFolder(out string pchBuffer)
		{
			pchBuffer = null;
			return false;
		}

		[PreserveSig]
		private static extern void _StartVoiceRecording(IntPtr self);

		internal void StartVoiceRecording()
		{
		}

		[PreserveSig]
		private static extern void _StopVoiceRecording(IntPtr self);

		internal void StopVoiceRecording()
		{
		}

		[PreserveSig]
		private static extern VoiceResult _GetAvailableVoice(IntPtr self, ref uint pcbCompressed, ref uint pcbUncompressed_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated);

		internal VoiceResult GetAvailableVoice(ref uint pcbCompressed, ref uint pcbUncompressed_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated)
		{
			return default(VoiceResult);
		}

		[PreserveSig]
		private static extern VoiceResult _GetVoice(IntPtr self, bool bWantCompressed, IntPtr pDestBuffer, uint cbDestBufferSize, ref uint nBytesWritten, bool bWantUncompressed_Deprecated, IntPtr pUncompressedDestBuffer_Deprecated, uint cbUncompressedDestBufferSize_Deprecated, ref uint nUncompressBytesWritten_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated);

		internal VoiceResult GetVoice(bool bWantCompressed, IntPtr pDestBuffer, uint cbDestBufferSize, ref uint nBytesWritten, bool bWantUncompressed_Deprecated, IntPtr pUncompressedDestBuffer_Deprecated, uint cbUncompressedDestBufferSize_Deprecated, ref uint nUncompressBytesWritten_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated)
		{
			return default(VoiceResult);
		}

		[PreserveSig]
		private static extern VoiceResult _DecompressVoice(IntPtr self, IntPtr pCompressed, uint cbCompressed, IntPtr pDestBuffer, uint cbDestBufferSize, ref uint nBytesWritten, uint nDesiredSampleRate);

		internal VoiceResult DecompressVoice(IntPtr pCompressed, uint cbCompressed, IntPtr pDestBuffer, uint cbDestBufferSize, ref uint nBytesWritten, uint nDesiredSampleRate)
		{
			return default(VoiceResult);
		}

		[PreserveSig]
		private static extern uint _GetVoiceOptimalSampleRate(IntPtr self);

		internal uint GetVoiceOptimalSampleRate()
		{
			return 0u;
		}

		[PreserveSig]
		private static extern HAuthTicket _GetAuthSessionTicket(IntPtr self, IntPtr pTicket, int cbMaxTicket, ref uint pcbTicket, ref NetIdentity pSteamNetworkingIdentity);

		internal HAuthTicket GetAuthSessionTicket(IntPtr pTicket, int cbMaxTicket, ref uint pcbTicket, ref NetIdentity pSteamNetworkingIdentity)
		{
			return default(HAuthTicket);
		}

		[PreserveSig]
		private static extern HAuthTicket _GetAuthTicketForWebApi(IntPtr self, string pchIdentity);

		internal HAuthTicket GetAuthTicketForWebApi(string pchIdentity)
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
		private static extern bool _BIsBehindNAT(IntPtr self);

		internal bool BIsBehindNAT()
		{
			return false;
		}

		[PreserveSig]
		private static extern void _AdvertiseGame(IntPtr self, SteamId steamIDGameServer, uint unIPServer, ushort usPortServer);

		internal void AdvertiseGame(SteamId steamIDGameServer, uint unIPServer, ushort usPortServer)
		{
		}

		[PreserveSig]
		private static extern SteamAPICall_t _RequestEncryptedAppTicket(IntPtr self, IntPtr pDataToInclude, int cbDataToInclude);

		internal CallResult<EncryptedAppTicketResponse_t> RequestEncryptedAppTicket(IntPtr pDataToInclude, int cbDataToInclude)
		{
			return default(CallResult<EncryptedAppTicketResponse_t>);
		}

		[PreserveSig]
		private static extern bool _GetEncryptedAppTicket(IntPtr self, IntPtr pTicket, int cbMaxTicket, ref uint pcbTicket);

		internal bool GetEncryptedAppTicket(IntPtr pTicket, int cbMaxTicket, ref uint pcbTicket)
		{
			return false;
		}

		[PreserveSig]
		private static extern int _GetGameBadgeLevel(IntPtr self, int nSeries, bool bFoil);

		internal int GetGameBadgeLevel(int nSeries, bool bFoil)
		{
			return 0;
		}

		[PreserveSig]
		private static extern int _GetPlayerSteamLevel(IntPtr self);

		internal int GetPlayerSteamLevel()
		{
			return 0;
		}

		[PreserveSig]
		private static extern SteamAPICall_t _RequestStoreAuthURL(IntPtr self, string pchRedirectURL);

		internal CallResult<StoreAuthURLResponse_t> RequestStoreAuthURL(string pchRedirectURL)
		{
			return default(CallResult<StoreAuthURLResponse_t>);
		}

		[PreserveSig]
		private static extern bool _BIsPhoneVerified(IntPtr self);

		internal bool BIsPhoneVerified()
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _BIsTwoFactorEnabled(IntPtr self);

		internal bool BIsTwoFactorEnabled()
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _BIsPhoneIdentifying(IntPtr self);

		internal bool BIsPhoneIdentifying()
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _BIsPhoneRequiringVerification(IntPtr self);

		internal bool BIsPhoneRequiringVerification()
		{
			return false;
		}

		[PreserveSig]
		private static extern SteamAPICall_t _GetMarketEligibility(IntPtr self);

		internal CallResult<MarketEligibilityResponse_t> GetMarketEligibility()
		{
			return default(CallResult<MarketEligibilityResponse_t>);
		}

		[PreserveSig]
		private static extern SteamAPICall_t _GetDurationControl(IntPtr self);

		internal CallResult<DurationControl_t> GetDurationControl()
		{
			return default(CallResult<DurationControl_t>);
		}

		[PreserveSig]
		private static extern bool _BSetDurationControlOnlineState(IntPtr self, DurationControlOnlineState eNewState);

		internal bool BSetDurationControlOnlineState(DurationControlOnlineState eNewState)
		{
			return false;
		}
	}
}
