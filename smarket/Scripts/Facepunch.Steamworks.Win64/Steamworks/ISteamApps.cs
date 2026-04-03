using System;
using System.Runtime.InteropServices;
using Steamworks.Data;

namespace Steamworks
{
	internal class ISteamApps : SteamInterface
	{
		public const string Version = "STEAMAPPS_INTERFACE_VERSION008";

		internal ISteamApps(bool IsGameServer)
		{
		}

		[PreserveSig]
		internal static extern IntPtr SteamAPI_SteamApps_v008();

		public override IntPtr GetUserInterfacePointer()
		{
			return (IntPtr)0;
		}

		[PreserveSig]
		private static extern bool _BIsSubscribed(IntPtr self);

		internal bool BIsSubscribed()
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _BIsLowViolence(IntPtr self);

		internal bool BIsLowViolence()
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _BIsCybercafe(IntPtr self);

		internal bool BIsCybercafe()
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _BIsVACBanned(IntPtr self);

		internal bool BIsVACBanned()
		{
			return false;
		}

		[PreserveSig]
		private static extern Utf8StringPointer _GetCurrentGameLanguage(IntPtr self);

		internal string GetCurrentGameLanguage()
		{
			return null;
		}

		[PreserveSig]
		private static extern Utf8StringPointer _GetAvailableGameLanguages(IntPtr self);

		internal string GetAvailableGameLanguages()
		{
			return null;
		}

		[PreserveSig]
		private static extern bool _BIsSubscribedApp(IntPtr self, AppId appID);

		internal bool BIsSubscribedApp(AppId appID)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _BIsDlcInstalled(IntPtr self, AppId appID);

		internal bool BIsDlcInstalled(AppId appID)
		{
			return false;
		}

		[PreserveSig]
		private static extern uint _GetEarliestPurchaseUnixTime(IntPtr self, AppId nAppID);

		internal uint GetEarliestPurchaseUnixTime(AppId nAppID)
		{
			return 0u;
		}

		[PreserveSig]
		private static extern bool _BIsSubscribedFromFreeWeekend(IntPtr self);

		internal bool BIsSubscribedFromFreeWeekend()
		{
			return false;
		}

		[PreserveSig]
		private static extern int _GetDLCCount(IntPtr self);

		internal int GetDLCCount()
		{
			return 0;
		}

		[PreserveSig]
		private static extern bool _BGetDLCDataByIndex(IntPtr self, int iDLC, ref AppId pAppID, ref bool pbAvailable, IntPtr pchName, int cchNameBufferSize);

		internal bool BGetDLCDataByIndex(int iDLC, ref AppId pAppID, ref bool pbAvailable, out string pchName)
		{
			pchName = null;
			return false;
		}

		[PreserveSig]
		private static extern void _InstallDLC(IntPtr self, AppId nAppID);

		internal void InstallDLC(AppId nAppID)
		{
		}

		[PreserveSig]
		private static extern void _UninstallDLC(IntPtr self, AppId nAppID);

		internal void UninstallDLC(AppId nAppID)
		{
		}

		[PreserveSig]
		private static extern void _RequestAppProofOfPurchaseKey(IntPtr self, AppId nAppID);

		internal void RequestAppProofOfPurchaseKey(AppId nAppID)
		{
		}

		[PreserveSig]
		private static extern bool _GetCurrentBetaName(IntPtr self, IntPtr pchName, int cchNameBufferSize);

		internal bool GetCurrentBetaName(out string pchName)
		{
			pchName = null;
			return false;
		}

		[PreserveSig]
		private static extern bool _MarkContentCorrupt(IntPtr self, bool bMissingFilesOnly);

		internal bool MarkContentCorrupt(bool bMissingFilesOnly)
		{
			return false;
		}

		[PreserveSig]
		private static extern uint _GetInstalledDepots(IntPtr self, AppId appID, [In][Out] DepotId_t[] pvecDepots, uint cMaxDepots);

		internal uint GetInstalledDepots(AppId appID, [In][Out] DepotId_t[] pvecDepots, uint cMaxDepots)
		{
			return 0u;
		}

		[PreserveSig]
		private static extern uint _GetAppInstallDir(IntPtr self, AppId appID, IntPtr pchFolder, uint cchFolderBufferSize);

		internal uint GetAppInstallDir(AppId appID, out string pchFolder)
		{
			pchFolder = null;
			return 0u;
		}

		[PreserveSig]
		private static extern bool _BIsAppInstalled(IntPtr self, AppId appID);

		internal bool BIsAppInstalled(AppId appID)
		{
			return false;
		}

		[PreserveSig]
		private static extern SteamId _GetAppOwner(IntPtr self);

		internal SteamId GetAppOwner()
		{
			return default(SteamId);
		}

		[PreserveSig]
		private static extern Utf8StringPointer _GetLaunchQueryParam(IntPtr self, string pchKey);

		internal string GetLaunchQueryParam(string pchKey)
		{
			return null;
		}

		[PreserveSig]
		private static extern bool _GetDlcDownloadProgress(IntPtr self, AppId nAppID, ref ulong punBytesDownloaded, ref ulong punBytesTotal);

		internal bool GetDlcDownloadProgress(AppId nAppID, ref ulong punBytesDownloaded, ref ulong punBytesTotal)
		{
			return false;
		}

		[PreserveSig]
		private static extern int _GetAppBuildId(IntPtr self);

		internal int GetAppBuildId()
		{
			return 0;
		}

		[PreserveSig]
		private static extern void _RequestAllProofOfPurchaseKeys(IntPtr self);

		internal void RequestAllProofOfPurchaseKeys()
		{
		}

		[PreserveSig]
		private static extern SteamAPICall_t _GetFileDetails(IntPtr self, string pszFileName);

		internal CallResult<FileDetailsResult_t> GetFileDetails(string pszFileName)
		{
			return default(CallResult<FileDetailsResult_t>);
		}

		[PreserveSig]
		private static extern int _GetLaunchCommandLine(IntPtr self, IntPtr pszCommandLine, int cubCommandLine);

		internal int GetLaunchCommandLine(out string pszCommandLine)
		{
			pszCommandLine = null;
			return 0;
		}

		[PreserveSig]
		private static extern bool _BIsSubscribedFromFamilySharing(IntPtr self);

		internal bool BIsSubscribedFromFamilySharing()
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _BIsTimedTrial(IntPtr self, ref uint punSecondsAllowed, ref uint punSecondsPlayed);

		internal bool BIsTimedTrial(ref uint punSecondsAllowed, ref uint punSecondsPlayed)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _SetDlcContext(IntPtr self, AppId nAppID);

		internal bool SetDlcContext(AppId nAppID)
		{
			return false;
		}

		[PreserveSig]
		private static extern int _GetNumBetas(IntPtr self, ref int pnAvailable, ref int pnPrivate);

		internal int GetNumBetas(ref int pnAvailable, ref int pnPrivate)
		{
			return 0;
		}

		[PreserveSig]
		private static extern bool _GetBetaInfo(IntPtr self, int iBetaIndex, ref uint punFlags, ref uint punBuildID, IntPtr pchBetaName, int cchBetaName, IntPtr pchDescription, int cchDescription);

		internal bool GetBetaInfo(int iBetaIndex, ref uint punFlags, ref uint punBuildID, out string pchBetaName, out string pchDescription)
		{
			pchBetaName = null;
			pchDescription = null;
			return false;
		}

		[PreserveSig]
		private static extern bool _SetActiveBeta(IntPtr self, string pchBetaName);

		internal bool SetActiveBeta(string pchBetaName)
		{
			return false;
		}
	}
}
