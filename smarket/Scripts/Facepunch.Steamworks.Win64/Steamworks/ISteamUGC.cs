using System;
using System.Runtime.InteropServices;
using Steamworks.Data;

namespace Steamworks
{
	internal class ISteamUGC : SteamInterface
	{
		public const string Version = "STEAMUGC_INTERFACE_VERSION020";

		internal ISteamUGC(bool IsGameServer)
		{
		}

		[PreserveSig]
		internal static extern IntPtr SteamAPI_SteamUGC_v020();

		public override IntPtr GetUserInterfacePointer()
		{
			return (IntPtr)0;
		}

		[PreserveSig]
		internal static extern IntPtr SteamAPI_SteamGameServerUGC_v020();

		public override IntPtr GetServerInterfacePointer()
		{
			return (IntPtr)0;
		}

		[PreserveSig]
		private static extern UGCQueryHandle_t _CreateQueryUserUGCRequest(IntPtr self, AccountID_t unAccountID, UserUGCList eListType, UgcType eMatchingUGCType, UserUGCListSortOrder eSortOrder, AppId nCreatorAppID, AppId nConsumerAppID, uint unPage);

		internal UGCQueryHandle_t CreateQueryUserUGCRequest(AccountID_t unAccountID, UserUGCList eListType, UgcType eMatchingUGCType, UserUGCListSortOrder eSortOrder, AppId nCreatorAppID, AppId nConsumerAppID, uint unPage)
		{
			return default(UGCQueryHandle_t);
		}

		[PreserveSig]
		private static extern UGCQueryHandle_t _CreateQueryAllUGCRequest(IntPtr self, UGCQuery eQueryType, UgcType eMatchingeMatchingUGCTypeFileType, AppId nCreatorAppID, AppId nConsumerAppID, uint unPage);

		internal UGCQueryHandle_t CreateQueryAllUGCRequest(UGCQuery eQueryType, UgcType eMatchingeMatchingUGCTypeFileType, AppId nCreatorAppID, AppId nConsumerAppID, uint unPage)
		{
			return default(UGCQueryHandle_t);
		}

		[PreserveSig]
		private static extern UGCQueryHandle_t _CreateQueryAllUGCRequest(IntPtr self, UGCQuery eQueryType, UgcType eMatchingeMatchingUGCTypeFileType, AppId nCreatorAppID, AppId nConsumerAppID, string pchCursor);

		internal UGCQueryHandle_t CreateQueryAllUGCRequest(UGCQuery eQueryType, UgcType eMatchingeMatchingUGCTypeFileType, AppId nCreatorAppID, AppId nConsumerAppID, string pchCursor)
		{
			return default(UGCQueryHandle_t);
		}

		[PreserveSig]
		private static extern UGCQueryHandle_t _CreateQueryUGCDetailsRequest(IntPtr self, [In][Out] PublishedFileId[] pvecPublishedFileID, uint unNumPublishedFileIDs);

		internal UGCQueryHandle_t CreateQueryUGCDetailsRequest([In][Out] PublishedFileId[] pvecPublishedFileID, uint unNumPublishedFileIDs)
		{
			return default(UGCQueryHandle_t);
		}

		[PreserveSig]
		private static extern SteamAPICall_t _SendQueryUGCRequest(IntPtr self, UGCQueryHandle_t handle);

		internal CallResult<SteamUGCQueryCompleted_t> SendQueryUGCRequest(UGCQueryHandle_t handle)
		{
			return default(CallResult<SteamUGCQueryCompleted_t>);
		}

		[PreserveSig]
		private static extern bool _GetQueryUGCResult(IntPtr self, UGCQueryHandle_t handle, uint index, ref SteamUGCDetails_t pDetails);

		internal bool GetQueryUGCResult(UGCQueryHandle_t handle, uint index, ref SteamUGCDetails_t pDetails)
		{
			return false;
		}

		[PreserveSig]
		private static extern uint _GetQueryUGCNumTags(IntPtr self, UGCQueryHandle_t handle, uint index);

		internal uint GetQueryUGCNumTags(UGCQueryHandle_t handle, uint index)
		{
			return 0u;
		}

		[PreserveSig]
		private static extern bool _GetQueryUGCTag(IntPtr self, UGCQueryHandle_t handle, uint index, uint indexTag, IntPtr pchValue, uint cchValueSize);

		internal bool GetQueryUGCTag(UGCQueryHandle_t handle, uint index, uint indexTag, out string pchValue)
		{
			pchValue = null;
			return false;
		}

		[PreserveSig]
		private static extern bool _GetQueryUGCTagDisplayName(IntPtr self, UGCQueryHandle_t handle, uint index, uint indexTag, IntPtr pchValue, uint cchValueSize);

		internal bool GetQueryUGCTagDisplayName(UGCQueryHandle_t handle, uint index, uint indexTag, out string pchValue)
		{
			pchValue = null;
			return false;
		}

		[PreserveSig]
		private static extern bool _GetQueryUGCPreviewURL(IntPtr self, UGCQueryHandle_t handle, uint index, IntPtr pchURL, uint cchURLSize);

		internal bool GetQueryUGCPreviewURL(UGCQueryHandle_t handle, uint index, out string pchURL)
		{
			pchURL = null;
			return false;
		}

		[PreserveSig]
		private static extern bool _GetQueryUGCMetadata(IntPtr self, UGCQueryHandle_t handle, uint index, IntPtr pchMetadata, uint cchMetadatasize);

		internal bool GetQueryUGCMetadata(UGCQueryHandle_t handle, uint index, out string pchMetadata)
		{
			pchMetadata = null;
			return false;
		}

		[PreserveSig]
		private static extern bool _GetQueryUGCChildren(IntPtr self, UGCQueryHandle_t handle, uint index, [In][Out] PublishedFileId[] pvecPublishedFileID, uint cMaxEntries);

		internal bool GetQueryUGCChildren(UGCQueryHandle_t handle, uint index, [In][Out] PublishedFileId[] pvecPublishedFileID, uint cMaxEntries)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _GetQueryUGCStatistic(IntPtr self, UGCQueryHandle_t handle, uint index, ItemStatistic eStatType, ref ulong pStatValue);

		internal bool GetQueryUGCStatistic(UGCQueryHandle_t handle, uint index, ItemStatistic eStatType, ref ulong pStatValue)
		{
			return false;
		}

		[PreserveSig]
		private static extern uint _GetQueryUGCNumAdditionalPreviews(IntPtr self, UGCQueryHandle_t handle, uint index);

		internal uint GetQueryUGCNumAdditionalPreviews(UGCQueryHandle_t handle, uint index)
		{
			return 0u;
		}

		[PreserveSig]
		private static extern bool _GetQueryUGCAdditionalPreview(IntPtr self, UGCQueryHandle_t handle, uint index, uint previewIndex, IntPtr pchURLOrVideoID, uint cchURLSize, IntPtr pchOriginalFileName, uint cchOriginalFileNameSize, ref ItemPreviewType pPreviewType);

		internal bool GetQueryUGCAdditionalPreview(UGCQueryHandle_t handle, uint index, uint previewIndex, out string pchURLOrVideoID, out string pchOriginalFileName, ref ItemPreviewType pPreviewType)
		{
			pchURLOrVideoID = null;
			pchOriginalFileName = null;
			return false;
		}

		[PreserveSig]
		private static extern uint _GetQueryUGCNumKeyValueTags(IntPtr self, UGCQueryHandle_t handle, uint index);

		internal uint GetQueryUGCNumKeyValueTags(UGCQueryHandle_t handle, uint index)
		{
			return 0u;
		}

		[PreserveSig]
		private static extern bool _GetQueryUGCKeyValueTag(IntPtr self, UGCQueryHandle_t handle, uint index, uint keyValueTagIndex, IntPtr pchKey, uint cchKeySize, IntPtr pchValue, uint cchValueSize);

		internal bool GetQueryUGCKeyValueTag(UGCQueryHandle_t handle, uint index, uint keyValueTagIndex, out string pchKey, out string pchValue)
		{
			pchKey = null;
			pchValue = null;
			return false;
		}

		[PreserveSig]
		private static extern bool _GetQueryUGCKeyValueTag(IntPtr self, UGCQueryHandle_t handle, uint index, string pchKey, IntPtr pchValue, uint cchValueSize);

		internal bool GetQueryUGCKeyValueTag(UGCQueryHandle_t handle, uint index, string pchKey, out string pchValue)
		{
			pchValue = null;
			return false;
		}

		[PreserveSig]
		private static extern uint _GetNumSupportedGameVersions(IntPtr self, UGCQueryHandle_t handle, uint index);

		internal uint GetNumSupportedGameVersions(UGCQueryHandle_t handle, uint index)
		{
			return 0u;
		}

		[PreserveSig]
		private static extern bool _GetSupportedGameVersionData(IntPtr self, UGCQueryHandle_t handle, uint index, uint versionIndex, IntPtr pchGameBranchMin, IntPtr pchGameBranchMax, uint cchGameBranchSize);

		internal bool GetSupportedGameVersionData(UGCQueryHandle_t handle, uint index, uint versionIndex, out string pchGameBranchMin, out string pchGameBranchMax)
		{
			pchGameBranchMin = null;
			pchGameBranchMax = null;
			return false;
		}

		[PreserveSig]
		private static extern uint _GetQueryUGCContentDescriptors(IntPtr self, UGCQueryHandle_t handle, uint index, [In][Out] UGCContentDescriptorID[] pvecDescriptors, uint cMaxEntries);

		internal uint GetQueryUGCContentDescriptors(UGCQueryHandle_t handle, uint index, [In][Out] UGCContentDescriptorID[] pvecDescriptors, uint cMaxEntries)
		{
			return 0u;
		}

		[PreserveSig]
		private static extern bool _ReleaseQueryUGCRequest(IntPtr self, UGCQueryHandle_t handle);

		internal bool ReleaseQueryUGCRequest(UGCQueryHandle_t handle)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _AddRequiredTag(IntPtr self, UGCQueryHandle_t handle, string pTagName);

		internal bool AddRequiredTag(UGCQueryHandle_t handle, string pTagName)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _AddRequiredTagGroup(IntPtr self, UGCQueryHandle_t handle, ref SteamParamStringArray_t pTagGroups);

		internal bool AddRequiredTagGroup(UGCQueryHandle_t handle, ref SteamParamStringArray_t pTagGroups)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _AddExcludedTag(IntPtr self, UGCQueryHandle_t handle, string pTagName);

		internal bool AddExcludedTag(UGCQueryHandle_t handle, string pTagName)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _SetReturnOnlyIDs(IntPtr self, UGCQueryHandle_t handle, bool bReturnOnlyIDs);

		internal bool SetReturnOnlyIDs(UGCQueryHandle_t handle, bool bReturnOnlyIDs)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _SetReturnKeyValueTags(IntPtr self, UGCQueryHandle_t handle, bool bReturnKeyValueTags);

		internal bool SetReturnKeyValueTags(UGCQueryHandle_t handle, bool bReturnKeyValueTags)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _SetReturnLongDescription(IntPtr self, UGCQueryHandle_t handle, bool bReturnLongDescription);

		internal bool SetReturnLongDescription(UGCQueryHandle_t handle, bool bReturnLongDescription)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _SetReturnMetadata(IntPtr self, UGCQueryHandle_t handle, bool bReturnMetadata);

		internal bool SetReturnMetadata(UGCQueryHandle_t handle, bool bReturnMetadata)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _SetReturnChildren(IntPtr self, UGCQueryHandle_t handle, bool bReturnChildren);

		internal bool SetReturnChildren(UGCQueryHandle_t handle, bool bReturnChildren)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _SetReturnAdditionalPreviews(IntPtr self, UGCQueryHandle_t handle, bool bReturnAdditionalPreviews);

		internal bool SetReturnAdditionalPreviews(UGCQueryHandle_t handle, bool bReturnAdditionalPreviews)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _SetReturnTotalOnly(IntPtr self, UGCQueryHandle_t handle, bool bReturnTotalOnly);

		internal bool SetReturnTotalOnly(UGCQueryHandle_t handle, bool bReturnTotalOnly)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _SetReturnPlaytimeStats(IntPtr self, UGCQueryHandle_t handle, uint unDays);

		internal bool SetReturnPlaytimeStats(UGCQueryHandle_t handle, uint unDays)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _SetLanguage(IntPtr self, UGCQueryHandle_t handle, string pchLanguage);

		internal bool SetLanguage(UGCQueryHandle_t handle, string pchLanguage)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _SetAllowCachedResponse(IntPtr self, UGCQueryHandle_t handle, uint unMaxAgeSeconds);

		internal bool SetAllowCachedResponse(UGCQueryHandle_t handle, uint unMaxAgeSeconds)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _SetAdminQuery(IntPtr self, UGCUpdateHandle_t handle, bool bAdminQuery);

		internal bool SetAdminQuery(UGCUpdateHandle_t handle, bool bAdminQuery)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _SetCloudFileNameFilter(IntPtr self, UGCQueryHandle_t handle, string pMatchCloudFileName);

		internal bool SetCloudFileNameFilter(UGCQueryHandle_t handle, string pMatchCloudFileName)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _SetMatchAnyTag(IntPtr self, UGCQueryHandle_t handle, bool bMatchAnyTag);

		internal bool SetMatchAnyTag(UGCQueryHandle_t handle, bool bMatchAnyTag)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _SetSearchText(IntPtr self, UGCQueryHandle_t handle, string pSearchText);

		internal bool SetSearchText(UGCQueryHandle_t handle, string pSearchText)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _SetRankedByTrendDays(IntPtr self, UGCQueryHandle_t handle, uint unDays);

		internal bool SetRankedByTrendDays(UGCQueryHandle_t handle, uint unDays)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _SetTimeCreatedDateRange(IntPtr self, UGCQueryHandle_t handle, RTime32 rtStart, RTime32 rtEnd);

		internal bool SetTimeCreatedDateRange(UGCQueryHandle_t handle, RTime32 rtStart, RTime32 rtEnd)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _SetTimeUpdatedDateRange(IntPtr self, UGCQueryHandle_t handle, RTime32 rtStart, RTime32 rtEnd);

		internal bool SetTimeUpdatedDateRange(UGCQueryHandle_t handle, RTime32 rtStart, RTime32 rtEnd)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _AddRequiredKeyValueTag(IntPtr self, UGCQueryHandle_t handle, string pKey, string pValue);

		internal bool AddRequiredKeyValueTag(UGCQueryHandle_t handle, string pKey, string pValue)
		{
			return false;
		}

		[PreserveSig]
		private static extern SteamAPICall_t _CreateItem(IntPtr self, AppId nConsumerAppId, WorkshopFileType eFileType);

		internal CallResult<CreateItemResult_t> CreateItem(AppId nConsumerAppId, WorkshopFileType eFileType)
		{
			return default(CallResult<CreateItemResult_t>);
		}

		[PreserveSig]
		private static extern UGCUpdateHandle_t _StartItemUpdate(IntPtr self, AppId nConsumerAppId, PublishedFileId nPublishedFileID);

		internal UGCUpdateHandle_t StartItemUpdate(AppId nConsumerAppId, PublishedFileId nPublishedFileID)
		{
			return default(UGCUpdateHandle_t);
		}

		[PreserveSig]
		private static extern bool _SetItemTitle(IntPtr self, UGCUpdateHandle_t handle, string pchTitle);

		internal bool SetItemTitle(UGCUpdateHandle_t handle, string pchTitle)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _SetItemDescription(IntPtr self, UGCUpdateHandle_t handle, string pchDescription);

		internal bool SetItemDescription(UGCUpdateHandle_t handle, string pchDescription)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _SetItemUpdateLanguage(IntPtr self, UGCUpdateHandle_t handle, string pchLanguage);

		internal bool SetItemUpdateLanguage(UGCUpdateHandle_t handle, string pchLanguage)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _SetItemMetadata(IntPtr self, UGCUpdateHandle_t handle, string pchMetaData);

		internal bool SetItemMetadata(UGCUpdateHandle_t handle, string pchMetaData)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _SetItemVisibility(IntPtr self, UGCUpdateHandle_t handle, RemoteStoragePublishedFileVisibility eVisibility);

		internal bool SetItemVisibility(UGCUpdateHandle_t handle, RemoteStoragePublishedFileVisibility eVisibility)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _SetItemTags(IntPtr self, UGCUpdateHandle_t updateHandle, ref SteamParamStringArray_t pTags, bool bAllowAdminTags);

		internal bool SetItemTags(UGCUpdateHandle_t updateHandle, ref SteamParamStringArray_t pTags, bool bAllowAdminTags)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _SetItemContent(IntPtr self, UGCUpdateHandle_t handle, string pszContentFolder);

		internal bool SetItemContent(UGCUpdateHandle_t handle, string pszContentFolder)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _SetItemPreview(IntPtr self, UGCUpdateHandle_t handle, string pszPreviewFile);

		internal bool SetItemPreview(UGCUpdateHandle_t handle, string pszPreviewFile)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _SetAllowLegacyUpload(IntPtr self, UGCUpdateHandle_t handle, bool bAllowLegacyUpload);

		internal bool SetAllowLegacyUpload(UGCUpdateHandle_t handle, bool bAllowLegacyUpload)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _RemoveAllItemKeyValueTags(IntPtr self, UGCUpdateHandle_t handle);

		internal bool RemoveAllItemKeyValueTags(UGCUpdateHandle_t handle)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _RemoveItemKeyValueTags(IntPtr self, UGCUpdateHandle_t handle, string pchKey);

		internal bool RemoveItemKeyValueTags(UGCUpdateHandle_t handle, string pchKey)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _AddItemKeyValueTag(IntPtr self, UGCUpdateHandle_t handle, string pchKey, string pchValue);

		internal bool AddItemKeyValueTag(UGCUpdateHandle_t handle, string pchKey, string pchValue)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _AddItemPreviewFile(IntPtr self, UGCUpdateHandle_t handle, string pszPreviewFile, ItemPreviewType type);

		internal bool AddItemPreviewFile(UGCUpdateHandle_t handle, string pszPreviewFile, ItemPreviewType type)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _AddItemPreviewVideo(IntPtr self, UGCUpdateHandle_t handle, string pszVideoID);

		internal bool AddItemPreviewVideo(UGCUpdateHandle_t handle, string pszVideoID)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _UpdateItemPreviewFile(IntPtr self, UGCUpdateHandle_t handle, uint index, string pszPreviewFile);

		internal bool UpdateItemPreviewFile(UGCUpdateHandle_t handle, uint index, string pszPreviewFile)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _UpdateItemPreviewVideo(IntPtr self, UGCUpdateHandle_t handle, uint index, string pszVideoID);

		internal bool UpdateItemPreviewVideo(UGCUpdateHandle_t handle, uint index, string pszVideoID)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _RemoveItemPreview(IntPtr self, UGCUpdateHandle_t handle, uint index);

		internal bool RemoveItemPreview(UGCUpdateHandle_t handle, uint index)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _AddContentDescriptor(IntPtr self, UGCUpdateHandle_t handle, UGCContentDescriptorID descid);

		internal bool AddContentDescriptor(UGCUpdateHandle_t handle, UGCContentDescriptorID descid)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _RemoveContentDescriptor(IntPtr self, UGCUpdateHandle_t handle, UGCContentDescriptorID descid);

		internal bool RemoveContentDescriptor(UGCUpdateHandle_t handle, UGCContentDescriptorID descid)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _SetRequiredGameVersions(IntPtr self, UGCUpdateHandle_t handle, string pszGameBranchMin, string pszGameBranchMax);

		internal bool SetRequiredGameVersions(UGCUpdateHandle_t handle, string pszGameBranchMin, string pszGameBranchMax)
		{
			return false;
		}

		[PreserveSig]
		private static extern SteamAPICall_t _SubmitItemUpdate(IntPtr self, UGCUpdateHandle_t handle, string pchChangeNote);

		internal CallResult<SubmitItemUpdateResult_t> SubmitItemUpdate(UGCUpdateHandle_t handle, string pchChangeNote)
		{
			return default(CallResult<SubmitItemUpdateResult_t>);
		}

		[PreserveSig]
		private static extern ItemUpdateStatus _GetItemUpdateProgress(IntPtr self, UGCUpdateHandle_t handle, ref ulong punBytesProcessed, ref ulong punBytesTotal);

		internal ItemUpdateStatus GetItemUpdateProgress(UGCUpdateHandle_t handle, ref ulong punBytesProcessed, ref ulong punBytesTotal)
		{
			return default(ItemUpdateStatus);
		}

		[PreserveSig]
		private static extern SteamAPICall_t _SetUserItemVote(IntPtr self, PublishedFileId nPublishedFileID, bool bVoteUp);

		internal CallResult<SetUserItemVoteResult_t> SetUserItemVote(PublishedFileId nPublishedFileID, bool bVoteUp)
		{
			return default(CallResult<SetUserItemVoteResult_t>);
		}

		[PreserveSig]
		private static extern SteamAPICall_t _GetUserItemVote(IntPtr self, PublishedFileId nPublishedFileID);

		internal CallResult<GetUserItemVoteResult_t> GetUserItemVote(PublishedFileId nPublishedFileID)
		{
			return default(CallResult<GetUserItemVoteResult_t>);
		}

		[PreserveSig]
		private static extern SteamAPICall_t _AddItemToFavorites(IntPtr self, AppId nAppId, PublishedFileId nPublishedFileID);

		internal CallResult<UserFavoriteItemsListChanged_t> AddItemToFavorites(AppId nAppId, PublishedFileId nPublishedFileID)
		{
			return default(CallResult<UserFavoriteItemsListChanged_t>);
		}

		[PreserveSig]
		private static extern SteamAPICall_t _RemoveItemFromFavorites(IntPtr self, AppId nAppId, PublishedFileId nPublishedFileID);

		internal CallResult<UserFavoriteItemsListChanged_t> RemoveItemFromFavorites(AppId nAppId, PublishedFileId nPublishedFileID)
		{
			return default(CallResult<UserFavoriteItemsListChanged_t>);
		}

		[PreserveSig]
		private static extern SteamAPICall_t _SubscribeItem(IntPtr self, PublishedFileId nPublishedFileID);

		internal CallResult<RemoteStorageSubscribePublishedFileResult_t> SubscribeItem(PublishedFileId nPublishedFileID)
		{
			return default(CallResult<RemoteStorageSubscribePublishedFileResult_t>);
		}

		[PreserveSig]
		private static extern SteamAPICall_t _UnsubscribeItem(IntPtr self, PublishedFileId nPublishedFileID);

		internal CallResult<RemoteStorageUnsubscribePublishedFileResult_t> UnsubscribeItem(PublishedFileId nPublishedFileID)
		{
			return default(CallResult<RemoteStorageUnsubscribePublishedFileResult_t>);
		}

		[PreserveSig]
		private static extern uint _GetNumSubscribedItems(IntPtr self);

		internal uint GetNumSubscribedItems()
		{
			return 0u;
		}

		[PreserveSig]
		private static extern uint _GetSubscribedItems(IntPtr self, [In][Out] PublishedFileId[] pvecPublishedFileID, uint cMaxEntries);

		internal uint GetSubscribedItems([In][Out] PublishedFileId[] pvecPublishedFileID, uint cMaxEntries)
		{
			return 0u;
		}

		[PreserveSig]
		private static extern uint _GetItemState(IntPtr self, PublishedFileId nPublishedFileID);

		internal uint GetItemState(PublishedFileId nPublishedFileID)
		{
			return 0u;
		}

		[PreserveSig]
		private static extern bool _GetItemInstallInfo(IntPtr self, PublishedFileId nPublishedFileID, ref ulong punSizeOnDisk, IntPtr pchFolder, uint cchFolderSize, ref uint punTimeStamp);

		internal bool GetItemInstallInfo(PublishedFileId nPublishedFileID, ref ulong punSizeOnDisk, out string pchFolder, ref uint punTimeStamp)
		{
			pchFolder = null;
			return false;
		}

		[PreserveSig]
		private static extern bool _GetItemDownloadInfo(IntPtr self, PublishedFileId nPublishedFileID, ref ulong punBytesDownloaded, ref ulong punBytesTotal);

		internal bool GetItemDownloadInfo(PublishedFileId nPublishedFileID, ref ulong punBytesDownloaded, ref ulong punBytesTotal)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _DownloadItem(IntPtr self, PublishedFileId nPublishedFileID, bool bHighPriority);

		internal bool DownloadItem(PublishedFileId nPublishedFileID, bool bHighPriority)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _BInitWorkshopForGameServer(IntPtr self, DepotId_t unWorkshopDepotID, string pszFolder);

		internal bool BInitWorkshopForGameServer(DepotId_t unWorkshopDepotID, string pszFolder)
		{
			return false;
		}

		[PreserveSig]
		private static extern void _SuspendDownloads(IntPtr self, bool bSuspend);

		internal void SuspendDownloads(bool bSuspend)
		{
		}

		[PreserveSig]
		private static extern SteamAPICall_t _StartPlaytimeTracking(IntPtr self, [In][Out] PublishedFileId[] pvecPublishedFileID, uint unNumPublishedFileIDs);

		internal CallResult<StartPlaytimeTrackingResult_t> StartPlaytimeTracking([In][Out] PublishedFileId[] pvecPublishedFileID, uint unNumPublishedFileIDs)
		{
			return default(CallResult<StartPlaytimeTrackingResult_t>);
		}

		[PreserveSig]
		private static extern SteamAPICall_t _StopPlaytimeTracking(IntPtr self, [In][Out] PublishedFileId[] pvecPublishedFileID, uint unNumPublishedFileIDs);

		internal CallResult<StopPlaytimeTrackingResult_t> StopPlaytimeTracking([In][Out] PublishedFileId[] pvecPublishedFileID, uint unNumPublishedFileIDs)
		{
			return default(CallResult<StopPlaytimeTrackingResult_t>);
		}

		[PreserveSig]
		private static extern SteamAPICall_t _StopPlaytimeTrackingForAllItems(IntPtr self);

		internal CallResult<StopPlaytimeTrackingResult_t> StopPlaytimeTrackingForAllItems()
		{
			return default(CallResult<StopPlaytimeTrackingResult_t>);
		}

		[PreserveSig]
		private static extern SteamAPICall_t _AddDependency(IntPtr self, PublishedFileId nParentPublishedFileID, PublishedFileId nChildPublishedFileID);

		internal CallResult<AddUGCDependencyResult_t> AddDependency(PublishedFileId nParentPublishedFileID, PublishedFileId nChildPublishedFileID)
		{
			return default(CallResult<AddUGCDependencyResult_t>);
		}

		[PreserveSig]
		private static extern SteamAPICall_t _RemoveDependency(IntPtr self, PublishedFileId nParentPublishedFileID, PublishedFileId nChildPublishedFileID);

		internal CallResult<RemoveUGCDependencyResult_t> RemoveDependency(PublishedFileId nParentPublishedFileID, PublishedFileId nChildPublishedFileID)
		{
			return default(CallResult<RemoveUGCDependencyResult_t>);
		}

		[PreserveSig]
		private static extern SteamAPICall_t _AddAppDependency(IntPtr self, PublishedFileId nPublishedFileID, AppId nAppID);

		internal CallResult<AddAppDependencyResult_t> AddAppDependency(PublishedFileId nPublishedFileID, AppId nAppID)
		{
			return default(CallResult<AddAppDependencyResult_t>);
		}

		[PreserveSig]
		private static extern SteamAPICall_t _RemoveAppDependency(IntPtr self, PublishedFileId nPublishedFileID, AppId nAppID);

		internal CallResult<RemoveAppDependencyResult_t> RemoveAppDependency(PublishedFileId nPublishedFileID, AppId nAppID)
		{
			return default(CallResult<RemoveAppDependencyResult_t>);
		}

		[PreserveSig]
		private static extern SteamAPICall_t _GetAppDependencies(IntPtr self, PublishedFileId nPublishedFileID);

		internal CallResult<GetAppDependenciesResult_t> GetAppDependencies(PublishedFileId nPublishedFileID)
		{
			return default(CallResult<GetAppDependenciesResult_t>);
		}

		[PreserveSig]
		private static extern SteamAPICall_t _DeleteItem(IntPtr self, PublishedFileId nPublishedFileID);

		internal CallResult<DeleteItemResult_t> DeleteItem(PublishedFileId nPublishedFileID)
		{
			return default(CallResult<DeleteItemResult_t>);
		}

		[PreserveSig]
		private static extern bool _ShowWorkshopEULA(IntPtr self);

		internal bool ShowWorkshopEULA()
		{
			return false;
		}

		[PreserveSig]
		private static extern SteamAPICall_t _GetWorkshopEULAStatus(IntPtr self);

		internal CallResult<WorkshopEULAStatus_t> GetWorkshopEULAStatus()
		{
			return default(CallResult<WorkshopEULAStatus_t>);
		}

		[PreserveSig]
		private static extern uint _GetUserContentDescriptorPreferences(IntPtr self, [In][Out] UGCContentDescriptorID[] pvecDescriptors, uint cMaxEntries);

		internal uint GetUserContentDescriptorPreferences([In][Out] UGCContentDescriptorID[] pvecDescriptors, uint cMaxEntries)
		{
			return 0u;
		}
	}
}
