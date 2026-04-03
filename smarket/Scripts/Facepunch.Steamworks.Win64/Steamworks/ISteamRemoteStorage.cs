using System;
using System.Runtime.InteropServices;
using Steamworks.Data;

namespace Steamworks
{
	internal class ISteamRemoteStorage : SteamInterface
	{
		public const string Version = "STEAMREMOTESTORAGE_INTERFACE_VERSION016";

		internal ISteamRemoteStorage(bool IsGameServer)
		{
		}

		[PreserveSig]
		internal static extern IntPtr SteamAPI_SteamRemoteStorage_v016();

		public override IntPtr GetUserInterfacePointer()
		{
			return (IntPtr)0;
		}

		[PreserveSig]
		private static extern bool _FileWrite(IntPtr self, string pchFile, IntPtr pvData, int cubData);

		internal bool FileWrite(string pchFile, IntPtr pvData, int cubData)
		{
			return false;
		}

		[PreserveSig]
		private static extern int _FileRead(IntPtr self, string pchFile, IntPtr pvData, int cubDataToRead);

		internal int FileRead(string pchFile, IntPtr pvData, int cubDataToRead)
		{
			return 0;
		}

		[PreserveSig]
		private static extern SteamAPICall_t _FileWriteAsync(IntPtr self, string pchFile, IntPtr pvData, uint cubData);

		internal CallResult<RemoteStorageFileWriteAsyncComplete_t> FileWriteAsync(string pchFile, IntPtr pvData, uint cubData)
		{
			return default(CallResult<RemoteStorageFileWriteAsyncComplete_t>);
		}

		[PreserveSig]
		private static extern SteamAPICall_t _FileReadAsync(IntPtr self, string pchFile, uint nOffset, uint cubToRead);

		internal CallResult<RemoteStorageFileReadAsyncComplete_t> FileReadAsync(string pchFile, uint nOffset, uint cubToRead)
		{
			return default(CallResult<RemoteStorageFileReadAsyncComplete_t>);
		}

		[PreserveSig]
		private static extern bool _FileReadAsyncComplete(IntPtr self, SteamAPICall_t hReadCall, IntPtr pvBuffer, uint cubToRead);

		internal bool FileReadAsyncComplete(SteamAPICall_t hReadCall, IntPtr pvBuffer, uint cubToRead)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _FileForget(IntPtr self, string pchFile);

		internal bool FileForget(string pchFile)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _FileDelete(IntPtr self, string pchFile);

		internal bool FileDelete(string pchFile)
		{
			return false;
		}

		[PreserveSig]
		private static extern SteamAPICall_t _FileShare(IntPtr self, string pchFile);

		internal CallResult<RemoteStorageFileShareResult_t> FileShare(string pchFile)
		{
			return default(CallResult<RemoteStorageFileShareResult_t>);
		}

		[PreserveSig]
		private static extern bool _SetSyncPlatforms(IntPtr self, string pchFile, RemoteStoragePlatform eRemoteStoragePlatform);

		internal bool SetSyncPlatforms(string pchFile, RemoteStoragePlatform eRemoteStoragePlatform)
		{
			return false;
		}

		[PreserveSig]
		private static extern UGCFileWriteStreamHandle_t _FileWriteStreamOpen(IntPtr self, string pchFile);

		internal UGCFileWriteStreamHandle_t FileWriteStreamOpen(string pchFile)
		{
			return default(UGCFileWriteStreamHandle_t);
		}

		[PreserveSig]
		private static extern bool _FileWriteStreamWriteChunk(IntPtr self, UGCFileWriteStreamHandle_t writeHandle, IntPtr pvData, int cubData);

		internal bool FileWriteStreamWriteChunk(UGCFileWriteStreamHandle_t writeHandle, IntPtr pvData, int cubData)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _FileWriteStreamClose(IntPtr self, UGCFileWriteStreamHandle_t writeHandle);

		internal bool FileWriteStreamClose(UGCFileWriteStreamHandle_t writeHandle)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _FileWriteStreamCancel(IntPtr self, UGCFileWriteStreamHandle_t writeHandle);

		internal bool FileWriteStreamCancel(UGCFileWriteStreamHandle_t writeHandle)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _FileExists(IntPtr self, string pchFile);

		internal bool FileExists(string pchFile)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _FilePersisted(IntPtr self, string pchFile);

		internal bool FilePersisted(string pchFile)
		{
			return false;
		}

		[PreserveSig]
		private static extern int _GetFileSize(IntPtr self, string pchFile);

		internal int GetFileSize(string pchFile)
		{
			return 0;
		}

		[PreserveSig]
		private static extern long _GetFileTimestamp(IntPtr self, string pchFile);

		internal long GetFileTimestamp(string pchFile)
		{
			return 0L;
		}

		[PreserveSig]
		private static extern RemoteStoragePlatform _GetSyncPlatforms(IntPtr self, string pchFile);

		internal RemoteStoragePlatform GetSyncPlatforms(string pchFile)
		{
			return default(RemoteStoragePlatform);
		}

		[PreserveSig]
		private static extern int _GetFileCount(IntPtr self);

		internal int GetFileCount()
		{
			return 0;
		}

		[PreserveSig]
		private static extern Utf8StringPointer _GetFileNameAndSize(IntPtr self, int iFile, ref int pnFileSizeInBytes);

		internal string GetFileNameAndSize(int iFile, ref int pnFileSizeInBytes)
		{
			return null;
		}

		[PreserveSig]
		private static extern bool _GetQuota(IntPtr self, ref ulong pnTotalBytes, ref ulong puAvailableBytes);

		internal bool GetQuota(ref ulong pnTotalBytes, ref ulong puAvailableBytes)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _IsCloudEnabledForAccount(IntPtr self);

		internal bool IsCloudEnabledForAccount()
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _IsCloudEnabledForApp(IntPtr self);

		internal bool IsCloudEnabledForApp()
		{
			return false;
		}

		[PreserveSig]
		private static extern void _SetCloudEnabledForApp(IntPtr self, bool bEnabled);

		internal void SetCloudEnabledForApp(bool bEnabled)
		{
		}

		[PreserveSig]
		private static extern SteamAPICall_t _UGCDownload(IntPtr self, UGCHandle_t hContent, uint unPriority);

		internal CallResult<RemoteStorageDownloadUGCResult_t> UGCDownload(UGCHandle_t hContent, uint unPriority)
		{
			return default(CallResult<RemoteStorageDownloadUGCResult_t>);
		}

		[PreserveSig]
		private static extern bool _GetUGCDownloadProgress(IntPtr self, UGCHandle_t hContent, ref int pnBytesDownloaded, ref int pnBytesExpected);

		internal bool GetUGCDownloadProgress(UGCHandle_t hContent, ref int pnBytesDownloaded, ref int pnBytesExpected)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _GetUGCDetails(IntPtr self, UGCHandle_t hContent, ref AppId pnAppID, [In][Out] ref char[] ppchName, ref int pnFileSizeInBytes, ref SteamId pSteamIDOwner);

		internal bool GetUGCDetails(UGCHandle_t hContent, ref AppId pnAppID, [In][Out] ref char[] ppchName, ref int pnFileSizeInBytes, ref SteamId pSteamIDOwner)
		{
			ppchName = null;
			return false;
		}

		[PreserveSig]
		private static extern int _UGCRead(IntPtr self, UGCHandle_t hContent, IntPtr pvData, int cubDataToRead, uint cOffset, UGCReadAction eAction);

		internal int UGCRead(UGCHandle_t hContent, IntPtr pvData, int cubDataToRead, uint cOffset, UGCReadAction eAction)
		{
			return 0;
		}

		[PreserveSig]
		private static extern int _GetCachedUGCCount(IntPtr self);

		internal int GetCachedUGCCount()
		{
			return 0;
		}

		[PreserveSig]
		private static extern UGCHandle_t _GetCachedUGCHandle(IntPtr self, int iCachedContent);

		internal UGCHandle_t GetCachedUGCHandle(int iCachedContent)
		{
			return default(UGCHandle_t);
		}

		[PreserveSig]
		private static extern SteamAPICall_t _UGCDownloadToLocation(IntPtr self, UGCHandle_t hContent, string pchLocation, uint unPriority);

		internal CallResult<RemoteStorageDownloadUGCResult_t> UGCDownloadToLocation(UGCHandle_t hContent, string pchLocation, uint unPriority)
		{
			return default(CallResult<RemoteStorageDownloadUGCResult_t>);
		}

		[PreserveSig]
		private static extern int _GetLocalFileChangeCount(IntPtr self);

		internal int GetLocalFileChangeCount()
		{
			return 0;
		}

		[PreserveSig]
		private static extern Utf8StringPointer _GetLocalFileChange(IntPtr self, int iFile, ref RemoteStorageLocalFileChange pEChangeType, ref RemoteStorageFilePathType pEFilePathType);

		internal string GetLocalFileChange(int iFile, ref RemoteStorageLocalFileChange pEChangeType, ref RemoteStorageFilePathType pEFilePathType)
		{
			return null;
		}

		[PreserveSig]
		private static extern bool _BeginFileWriteBatch(IntPtr self);

		internal bool BeginFileWriteBatch()
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _EndFileWriteBatch(IntPtr self);

		internal bool EndFileWriteBatch()
		{
			return false;
		}
	}
}
