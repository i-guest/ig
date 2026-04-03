using System;
using System.Runtime.InteropServices;

namespace Unity.XGamingRuntime.Interop
{
	internal static class XblInterop
	{
		internal delegate void XblAchievementsProgressChangeHandler(XblAchievementProgressChangeEventArgs eventArgs, IntPtr context);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void XblMultiplayerSessionChangedHandler(IntPtr context, XblMultiplayerSessionChangeEventArgs args);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void XblMultiplayerSessionSubscriptionLostHandler(IntPtr context);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void XblMultiplayerConnectionIdChangedHandler(IntPtr context);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void XblStatisticChangedHandler(XblStatisticChangeEventArgs statisticChangeEventArgs, IntPtr context);

		public const string XblThunkDllName = "Microsoft.Xbox.Services.GDK.C.Thunks";

		public const string HttpClientGdkDll = "libHttpClient.GDK";

		internal const int XBL_COLOR_CHAR_SIZE = 21;

		internal const int XBL_DISPLAY_NAME_CHAR_SIZE = 90;

		internal const int XBL_DISPLAY_PIC_URL_RAW_CHAR_SIZE = 675;

		internal const int XBL_GAMERSCORE_CHAR_SIZE = 48;

		internal const int XBL_GAMERTAG_CHAR_SIZE = 48;

		internal const int XBL_MODERN_GAMERTAG_CHAR_SIZE = 97;

		internal const int XBL_MODERN_GAMERTAG_SUFFIX_CHAR_SIZE = 15;

		internal const int XBL_UNIQUE_MODERN_GAMERTAG_CHAR_SIZE = 101;

		internal const int XBL_NUM_PRESENCE_RECORDS = 6;

		internal const int XBL_REAL_NAME_CHAR_SIZE = 765;

		internal const int XBL_RICH_PRESENCE_CHAR_SIZE = 300;

		internal const int XBL_TITLE_NAME_CHAR_SIZE = 300;

		internal const int XBL_XBOX_USER_ID_CHAR_SIZE = 63;

		internal const int XBL_GUID_LENGTH = 40;

		internal const int XBL_SCID_LENGTH = 40;

		internal const int XBL_SOCIAL_MANAGER_MAX_AFFECTED_USERS_PER_EVENT = 10;

		internal const int XBL_MULTIPLAYER_SESSION_TEMPLATE_NAME_MAX_LENGTH = 100;

		internal const int XBL_MULTIPLAYER_SESSION_NAME_MAX_LENGTH = 100;

		internal const int XBL_MULTIPLAYER_SESSION_REFERENCE_URI_MAX_LENGTH = 284;

		internal const int XBL_MULTIPLAYER_SEARCH_HANDLE_MAX_FIELD_LENGTH = 100;

		internal const int XBL_TITLE_STORAGE_MIN_UPLOAD_BLOCK_SIZE = 1024;

		internal const int XBL_TITLE_STORAGE_MAX_UPLOAD_BLOCK_SIZE = 4194304;

		internal const int XBL_TITLE_STORAGE_DEFAULT_UPLOAD_BLOCK_SIZE = 262144;

		internal const int XBL_TITLE_STORAGE_MIN_DOWNLOAD_BLOCK_SIZE = 1024;

		internal const int XBL_TITLE_STORAGE_DEFAULT_DOWNLOAD_BLOCK_SIZE = 1048576;

		internal const int XBL_TITLE_STORAGE_BLOB_PATH_MAX_LENGTH = 771;

		internal const int XBL_TITLE_STORAGE_BLOB_DISPLAY_NAME_MAX_LENGTH = 387;

		internal const int XBL_TITLE_STORAGE_BLOB_ETAG_MAX_LENGTH = 54;

		[PreserveSig]
		internal static extern int XblAchievementsResultGetAchievements(IntPtr resultHandle, out IntPtr achievements, out SizeT achievementsCount);

		[PreserveSig]
		internal static extern int XblAchievementsResultHasNext(IntPtr resultHandle, out bool hasNext);

		[PreserveSig]
		internal static extern int XblAchievementsResultGetNextAsync(IntPtr resultHandle, uint maxItems, XAsyncBlockPtr asyncBlock);

		[PreserveSig]
		internal static extern int XblAchievementsResultGetNextResult(XAsyncBlockPtr asyncBlock, out XblAchievementsResultHandle resultHandle);

		[PreserveSig]
		internal static extern int XblAchievementsGetAchievementsForTitleIdAsync(IntPtr xboxLiveContext, ulong xboxUserId, uint titleId, XblAchievementType type, bool unlockedOnly, XblAchievementOrderBy orderBy, uint skipItems, uint maxItems, XAsyncBlockPtr asyncBlock);

		[PreserveSig]
		internal static extern int XblAchievementsGetAchievementsForTitleIdResult(XAsyncBlockPtr asyncBlock, out XblAchievementsResultHandle result);

		[PreserveSig]
		internal static extern int XblAchievementsUpdateAchievementAsync(IntPtr xboxLiveContext, ulong xboxUserId, byte[] achievementId, uint percentComplete, XAsyncBlockPtr asyncBlock);

		[PreserveSig]
		internal static extern int XblAchievementsUpdateAchievementForTitleIdAsync(IntPtr xboxLiveContext, ulong xboxUserId, uint titleId, byte[] serviceConfigurationId, byte[] achievementId, uint percentComplete, XAsyncBlockPtr asyncBlock);

		[PreserveSig]
		internal static extern int XblAchievementsGetAchievementAsync(IntPtr xboxLiveContext, ulong xboxUserId, byte[] serviceConfigurationId, byte[] achievementId, XAsyncBlockPtr asyncBlock);

		[PreserveSig]
		internal static extern int XblAchievementsGetAchievementResult(XAsyncBlockPtr asyncBlock, out XblAchievementsResultHandle result);

		[PreserveSig]
		internal static extern XblFunctionContext XblAchievementsAddAchievementProgressChangeHandler(IntPtr xblContext, XblAchievementsProgressChangeHandler handler, IntPtr handlerContext);

		[PreserveSig]
		internal static extern void XblAchievementsRemoveAchievementProgressChangeHandler(IntPtr xblContextHandle, XblFunctionContext functionContext);

		[PreserveSig]
		internal static extern int XblAchievementsResultDuplicateHandle(IntPtr handle, out XblAchievementsResultHandle duplicatedHandle);

		[PreserveSig]
		internal static extern void XblAchievementsResultCloseHandle(IntPtr handle);

		[PreserveSig]
		internal static extern int XblAchievementsManagerResultGetAchievements(IntPtr resultHandle, out IntPtr achievements, out ulong achievementsCount);

		[PreserveSig]
		internal static extern int XblAchievementsManagerResultDuplicateHandle(IntPtr handle, out XblAchievementsManagerResultHandle duplicatedHandle);

		[PreserveSig]
		internal static extern void XblAchievementsManagerResultCloseHandle(IntPtr handle);

		[PreserveSig]
		internal static extern int XblAchievementsManagerAddLocalUser(IntPtr user, XTaskQueueHandle queue);

		[PreserveSig]
		internal static extern int XblAchievementsManagerRemoveLocalUser(IntPtr user);

		[PreserveSig]
		internal static extern int XblAchievementsManagerIsUserInitialized(ulong xboxUserId);

		[PreserveSig]
		internal static extern int XblAchievementsManagerDoWork(out IntPtr achievementsEvents, out SizeT achievementsEventsCount);

		[PreserveSig]
		internal static extern int XblAchievementsManagerGetAchievement(ulong xboxUserId, byte[] achievementId, out XblAchievementsManagerResultHandle achievementResult);

		[PreserveSig]
		internal static extern int XblAchievementsManagerGetAchievements(ulong xboxUserId, XblAchievementOrderBy sortField, XblAchievementsManagerSortOrder sortOrder, out XblAchievementsManagerResultHandle achievementsResult);

		[PreserveSig]
		internal static extern int XblAchievementsManagerGetAchievementsByState(ulong xboxUserId, XblAchievementOrderBy sortField, XblAchievementsManagerSortOrder sortOrder, XblAchievementProgressState achievementState, out XblAchievementsManagerResultHandle achievementResult);

		[PreserveSig]
		internal static extern int XblAchievementsManagerUpdateAchievement(ulong xboxUserId, byte[] achievementId, byte currentProgress);

		[PreserveSig]
		internal static extern int HCSettingsSetTraceLevel(HCTraceLevel traceLevel);

		[PreserveSig]
		internal static extern int HCSettingsGetTraceLevel(out HCTraceLevel traceLevel);

		[PreserveSig]
		internal static extern void HCTraceSetClientCallback(HCTraceCallback callback);

		[PreserveSig]
		internal static extern void HCTraceSetTraceToDebugger(bool traceToDebugger);

		[PreserveSig]
		internal static extern int XblHttpCallRequestSetRequestBodyBytes(IntPtr call, byte[] requestBodyBytes, uint requestBodySize);

		[PreserveSig]
		internal static extern int XblHttpCallGetNetworkErrorCode(IntPtr call, out int networkErrorCode, out uint platformNetworkErrorCode);

		[PreserveSig]
		internal static extern int XblHttpCallRequestSetLongHttpCall(IntPtr call, NativeBool longHttpCall);

		[PreserveSig]
		internal static extern int XblHttpCallPerformAsync(IntPtr call, XblHttpCallResponseBodyType type, XAsyncBlockPtr asyncBlock);

		[PreserveSig]
		internal static extern int XblHttpCallSetTracing(IntPtr call, NativeBool traceCall);

		[PreserveSig]
		internal static extern int XblHttpCallCreate(IntPtr xblContext, byte[] method, byte[] url, out XblHttpCallHandle call);

		[PreserveSig]
		internal static extern void XblHttpCallCloseHandle(IntPtr call);

		[PreserveSig]
		internal static extern int XblHttpCallRequestSetRequestBodyString(IntPtr call, byte[] requestBodyString);

		[PreserveSig]
		internal static extern int XblHttpCallGetResponseString(IntPtr call, out UTF8StringPtr responseString);

		[PreserveSig]
		internal static extern int XblHttpCallGetHeaderAtIndex(IntPtr call, uint headerIndex, out UTF8StringPtr headerName, out UTF8StringPtr headerValue);

		[PreserveSig]
		internal static extern int XblHttpCallGetResponseBodyBytesSize(IntPtr call, out SizeT bufferSize);

		[PreserveSig]
		internal static extern int XblHttpCallGetPlatformNetworkErrorMessage(IntPtr call, out UTF8StringPtr platformNetworkErrorMessage);

		[PreserveSig]
		internal static extern int XblHttpCallGetResponseBodyBytes(IntPtr call, SizeT bufferSize, [Out] byte[] buffer, out SizeT bufferUsed);

		[PreserveSig]
		internal static extern int XblHttpCallRequestSetRetryAllowed(IntPtr call, NativeBool retryAllowed);

		[PreserveSig]
		internal static extern int XblHttpCallRequestSetHeader(IntPtr call, byte[] headerName, byte[] headerValue, NativeBool allowTracing);

		[PreserveSig]
		internal static extern int XblHttpCallDuplicateHandle(IntPtr call, out XblHttpCallHandle duplicateHandle);

		[PreserveSig]
		internal static extern int XblHttpCallGetNumHeaders(IntPtr call, out uint numHeaders);

		[PreserveSig]
		internal static extern int XblHttpCallGetStatusCode(IntPtr call, out uint statusCode);

		[PreserveSig]
		internal static extern int XblHttpCallGetHeader(IntPtr call, byte[] headerName, out UTF8StringPtr headerValue);

		[PreserveSig]
		internal static extern int XblHttpCallGetRequestUrl(IntPtr call, out UTF8StringPtr url);

		[PreserveSig]
		internal static extern int XblHttpCallRequestSetRetryCacheId(IntPtr call, uint retryAfterCacheId);

		[PreserveSig]
		internal static extern int XblLeaderboardGetLeaderboardAsync(IntPtr xboxLiveContext, XblLeaderboardQuery leaderboardQuery, XAsyncBlockPtr asyncBlock);

		[PreserveSig]
		internal static extern int XblLeaderboardGetLeaderboardResultSize(XAsyncBlockPtr asyncBlockPtr, out SizeT resultSizeInBytes);

		[PreserveSig]
		internal static extern int XblLeaderboardGetLeaderboardResult(XAsyncBlockPtr asyncBlock, SizeT bufferSize, IntPtr buffer, out IntPtr ptrToBuffer, out SizeT bufferUsed);

		[PreserveSig]
		internal static extern int XblLeaderboardResultGetNextAsync(IntPtr xboxLiveContext, [In] ref XblLeaderboardResult leaderboardResult, uint maxItems, XAsyncBlockPtr asyncBlock);

		[PreserveSig]
		internal static extern int XblLeaderboardResultGetNextResultSize(XAsyncBlockPtr asyncBlock, out SizeT resultSizeInBytes);

		[PreserveSig]
		internal static extern int XblLeaderboardResultGetNextResult(XAsyncBlockPtr asyncBlock, SizeT bufferSize, IntPtr buffer, out IntPtr ptrToBuffer, out SizeT bufferUsed);

		[PreserveSig]
		internal static extern int XblMatchmakingCreateMatchTicketAsync(IntPtr xboxLiveContext, XblMultiplayerSessionReference ticketSessionReference, byte[] matchmakingServiceConfigurationId, byte[] hopperName, ulong ticketTimeout, XblPreserveSessionMode preserveSession, byte[] ticketAttributesJson, XAsyncBlockPtr asyncBlock);

		[PreserveSig]
		internal static extern int XblMatchmakingCreateMatchTicketResult(XAsyncBlockPtr async, out XblCreateMatchTicketResponse resultPtr);

		[PreserveSig]
		internal static extern int XblMatchmakingDeleteMatchTicketAsync(IntPtr xboxLiveContext, byte[] serviceConfigurationId, byte[] hopperName, byte[] ticketId, XAsyncBlockPtr asyncBlock);

		[PreserveSig]
		internal static extern int XblMatchmakingGetMatchTicketDetailsAsync(IntPtr xboxLiveContext, byte[] serviceConfigurationId, byte[] hopperName, byte[] ticketId, XAsyncBlockPtr asyncBlock);

		[PreserveSig]
		internal static extern int XblMatchmakingGetMatchTicketDetailsResultSize(XAsyncBlockPtr asyncBlock, out SizeT resultSizeInBytes);

		[PreserveSig]
		internal static extern int XblMatchmakingGetMatchTicketDetailsResult(XAsyncBlockPtr asyncBlock, SizeT bufferSize, IntPtr buffer, out IntPtr ptrToBuffer, out SizeT bufferUsed);

		[PreserveSig]
		internal static extern int XblMatchmakingGetHopperStatisticsAsync(IntPtr xboxLiveContext, byte[] serviceConfigurationId, byte[] hopperName, XAsyncBlockPtr asyncBlock);

		[PreserveSig]
		internal static extern int XblMatchmakingGetHopperStatisticsResultSize(XAsyncBlockPtr asyncBlock, out SizeT resultSizeInBytes);

		[PreserveSig]
		internal static extern int XblMatchmakingGetHopperStatisticsResult(XAsyncBlockPtr asyncBlock, SizeT bufferSize, IntPtr buffer, out IntPtr ptrToBuffer, out SizeT bufferUsed);

		[PreserveSig]
		public static extern XblMultiplayerSessionHandle XblMultiplayerSessionCreateHandle(ulong xboxUserId, [In] ref XblMultiplayerSessionReference sessionRef, [In] ref XblMultiplayerSessionInitArgs initArgs);

		[PreserveSig]
		public static extern void XblMultiplayerSessionCloseHandle(IntPtr handle);

		[PreserveSig]
		public static extern TimeT XblMultiplayerSessionTimeOfSession(IntPtr handle);

		[PreserveSig]
		internal unsafe static extern XblMultiplayerSessionInitializationInfo* XblMultiplayerSessionGetInitializationInfo(IntPtr handle);

		[PreserveSig]
		public static extern XblMultiplayerSessionChangeTypes XblMultiplayerSessionSubscribedChangeTypes(IntPtr handle);

		[PreserveSig]
		public static extern int XblMultiplayerSessionHostCandidates(IntPtr handle, out IntPtr deviceTokens, out SizeT deviceTokensCount);

		[PreserveSig]
		internal unsafe static extern XblMultiplayerSessionReference* XblMultiplayerSessionSessionReference(IntPtr handle);

		[PreserveSig]
		internal unsafe static extern XblMultiplayerSessionConstants* XblMultiplayerSessionSessionConstants(IntPtr handle);

		[PreserveSig]
		public static extern void XblMultiplayerSessionConstantsSetMaxMembersInSession(IntPtr handle, uint maxMembersInSession);

		[PreserveSig]
		public static extern void XblMultiplayerSessionConstantsSetVisibility(IntPtr handle, XblMultiplayerSessionVisibility visibility);

		[PreserveSig]
		public static extern int XblMultiplayerSessionConstantsSetTimeouts(IntPtr handle, ulong memberReservedTimeout, ulong memberInactiveTimeout, ulong memberReadyTimeout, ulong sessionEmptyTimeout);

		[PreserveSig]
		public static extern int XblMultiplayerSessionConstantsSetQosConnectivityMetrics(IntPtr handle, NativeBool enableLatencyMetric, NativeBool enableBandwidthDownMetric, NativeBool enableBandwidthUpMetric, NativeBool enableCustomMetric);

		[PreserveSig]
		public static extern int XblMultiplayerSessionConstantsSetMemberInitialization(IntPtr handle, XblMultiplayerMemberInitialization memberInitialization);

		[PreserveSig]
		public static extern int XblMultiplayerSessionConstantsSetPeerToPeerRequirements(IntPtr handle, XblMultiplayerPeerToPeerRequirements requirements);

		[PreserveSig]
		public static extern int XblMultiplayerSessionConstantsSetMeasurementServerAddressesJson(IntPtr handle, byte[] measurementServerAddressesJson);

		[PreserveSig]
		internal static extern int XblMultiplayerSessionConstantsSetCapabilities(IntPtr handle, XblMultiplayerSessionCapabilities capabilities);

		[PreserveSig]
		internal unsafe static extern XblMultiplayerSessionProperties* XblMultiplayerSessionSessionProperties(IntPtr handle);

		[PreserveSig]
		internal static extern int XblMultiplayerSessionPropertiesSetKeywords(IntPtr handle, IntPtr keywords, SizeT keywordsCount);

		[PreserveSig]
		public static extern void XblMultiplayerSessionPropertiesSetJoinRestriction(IntPtr handle, XblMultiplayerSessionRestriction joinRestriction);

		[PreserveSig]
		public static extern void XblMultiplayerSessionPropertiesSetReadRestriction(IntPtr handle, XblMultiplayerSessionRestriction readRestriction);

		[PreserveSig]
		internal static extern int XblMultiplayerSessionPropertiesSetTurnCollection(IntPtr handle, [In] uint[] turnCollectionMemberIds, SizeT turnCollectionMemberIdsCount);

		[PreserveSig]
		internal static extern int XblMultiplayerSessionMembers(IntPtr handle, out IntPtr members, out SizeT membersCount);

		[PreserveSig]
		internal unsafe static extern XblMultiplayerMatchmakingServer* XblMultiplayerSessionMatchmakingServer(IntPtr handle);

		[PreserveSig]
		internal unsafe static extern XblMultiplayerSessionMember* XblMultiplayerSessionCurrentUser(IntPtr handle);

		[PreserveSig]
		public static extern XblWriteSessionStatus XblMultiplayerSessionWriteStatus(IntPtr handle);

		[PreserveSig]
		public static extern int XblMultiplayerSessionJoin(IntPtr handle, byte[] memberCustomConstantsJson, bool initializeRequested, bool joinWithActiveStatus);

		[PreserveSig]
		public static extern void XblMultiplayerSessionSetHostDeviceToken(IntPtr handle, XblDeviceToken hostDeviceToken);

		[PreserveSig]
		public static extern void XblMultiplayerSessionSetClosed(IntPtr handle, bool closed);

		[PreserveSig]
		public static extern int XblMultiplayerSessionSetSessionChangeSubscription(IntPtr handle, XblMultiplayerSessionChangeTypes changeTypes);

		[PreserveSig]
		public static extern int XblMultiplayerSessionLeave(IntPtr handle);

		[PreserveSig]
		public static extern int XblMultiplayerSessionCurrentUserSetRoles(IntPtr handle, IntPtr roles, SizeT rolesCount);

		[PreserveSig]
		public static extern int XblMultiplayerSessionCurrentUserSetEncounters(IntPtr handle, IntPtr encounters, SizeT encountersCount);

		[PreserveSig]
		public static extern int XblMultiplayerSessionCurrentUserSetMembersInGroup(IntPtr handle, uint[] memberIds, SizeT memberIdsCount);

		[PreserveSig]
		public static extern int XblMultiplayerSessionCurrentUserSetGroups(IntPtr handle, IntPtr groups, SizeT groupsCount);

		[PreserveSig]
		public static extern int XblMultiplayerSessionCurrentUserSetCustomPropertyJson(IntPtr handle, byte[] name, byte[] valueJson);

		[PreserveSig]
		public static extern int XblMultiplayerSessionCurrentUserDeleteCustomPropertyJson(IntPtr handle, byte[] name);

		[PreserveSig]
		public static extern int XblMultiplayerSessionCurrentUserSetStatus(IntPtr handle, XblMultiplayerSessionMemberStatus status);

		[PreserveSig]
		public static extern int XblMultiplayerSessionCurrentUserSetSecureDeviceAddressBase64(IntPtr handle, byte[] value);

		[PreserveSig]
		public static extern int XblFormatSecureDeviceAddress(byte[] deviceId, out XblFormattedSecureDeviceAddress address);

		[PreserveSig]
		public static extern int XblMultiplayerSearchHandleDuplicateHandle([In] XblMultiplayerSearchHandle handle, out XblMultiplayerSearchHandle duplicatedHandle);

		[PreserveSig]
		public static extern void XblMultiplayerSearchHandleCloseHandle(IntPtr handle);

		[PreserveSig]
		public static extern int XblMultiplayerSearchHandleGetSessionReference([In] IntPtr handle, out XblMultiplayerSessionReference sessionRef);

		[PreserveSig]
		public static extern int XblMultiplayerSearchHandleGetId([In] IntPtr handle, out UTF8StringPtr id);

		[PreserveSig]
		public static extern int XblMultiplayerSearchHandleGetSessionOwnerXuids([In] IntPtr handle, out IntPtr xuids, out SizeT xuidsCount);

		[PreserveSig]
		public static extern int XblMultiplayerSearchHandleGetTags([In] IntPtr handle, out IntPtr tags, out SizeT tagsCount);

		[PreserveSig]
		public static extern int XblMultiplayerSearchHandleGetStringAttributes([In] IntPtr handle, out IntPtr attributes, out SizeT attributesCount);

		[PreserveSig]
		public static extern int XblMultiplayerSearchHandleGetNumberAttributes([In] IntPtr handle, out IntPtr attributes, out SizeT attributesCount);

		[PreserveSig]
		public static extern int XblMultiplayerSearchHandleGetVisibility([In] IntPtr handle, out XblMultiplayerSessionVisibility visibility);

		[PreserveSig]
		public static extern int XblMultiplayerSearchHandleGetJoinRestriction([In] IntPtr handle, out XblMultiplayerSessionRestriction joinRestriction);

		[PreserveSig]
		public static extern int XblMultiplayerSearchHandleGetSessionClosed([In] IntPtr handle, out bool closed);

		[PreserveSig]
		public static extern int XblMultiplayerSearchHandleGetMemberCounts([In] IntPtr handle, out SizeT maxMembers, out SizeT currentMembers);

		[PreserveSig]
		public static extern int XblMultiplayerSearchHandleGetCreationTime([In] IntPtr handle, out TimeT creationTime);

		[PreserveSig]
		public static extern int XblMultiplayerSearchHandleGetCustomSessionPropertiesJson([In] IntPtr handle, out UTF8StringPtr customPropertiesJson);

		[PreserveSig]
		internal static extern int XblMultiplayerWriteSessionAsync(IntPtr xblContext, IntPtr multiplayerSession, XblMultiplayerSessionWriteMode writeMode, XAsyncBlockPtr async);

		[PreserveSig]
		internal static extern int XblMultiplayerWriteSessionResult(XAsyncBlockPtr async, out XblMultiplayerSessionHandle handle);

		[PreserveSig]
		internal static extern int XblMultiplayerWriteSessionByHandleAsync(IntPtr xblContext, IntPtr multiplayerSession, XblMultiplayerSessionWriteMode writeMode, byte[] handleId, XAsyncBlockPtr async);

		[PreserveSig]
		internal static extern int XblMultiplayerWriteSessionByHandleResult(XAsyncBlockPtr async, out XblMultiplayerSessionHandle handle);

		[PreserveSig]
		internal static extern int XblMultiplayerGetSessionAsync(IntPtr xblContext, [In] ref XblMultiplayerSessionReference sessionRef, XAsyncBlockPtr async);

		[PreserveSig]
		internal static extern int XblMultiplayerGetSessionResult(XAsyncBlockPtr async, out XblMultiplayerSessionHandle handle);

		[PreserveSig]
		internal static extern int XblMultiplayerGetSessionByHandleAsync(IntPtr xblContext, byte[] handleId, XAsyncBlockPtr async);

		[PreserveSig]
		internal static extern int XblMultiplayerGetSessionByHandleResult(XAsyncBlockPtr async, out XblMultiplayerSessionHandle handle);

		[PreserveSig]
		internal static extern int XblMultiplayerQuerySessionsAsync(IntPtr xblContext, [In] ref XblMultiplayerSessionQuery sessionQuery, XAsyncBlockPtr async);

		[PreserveSig]
		internal static extern int XblMultiplayerQuerySessionsResultCount(XAsyncBlockPtr async, out SizeT sessionCount);

		[PreserveSig]
		internal static extern int XblMultiplayerQuerySessionsResult(XAsyncBlockPtr async, SizeT sessionCount, [Out] XblMultiplayerSessionQueryResult[] sessions);

		[PreserveSig]
		internal static extern int XblMultiplayerSetActivityAsync(IntPtr xblContext, [In] ref XblMultiplayerSessionReference sessionReference, XAsyncBlockPtr async);

		[PreserveSig]
		internal static extern int XblMultiplayerClearActivityAsync(IntPtr xblContext, byte[] scid, XAsyncBlockPtr async);

		[PreserveSig]
		internal static extern int XblMultiplayerSetTransferHandleAsync(IntPtr xblContext, [In] ref XblMultiplayerSessionReference targetSessionReference, [In] ref XblMultiplayerSessionReference originSessionReference, XAsyncBlockPtr async);

		[PreserveSig]
		public static extern int XblMultiplayerSetTransferHandleResult(XAsyncBlockPtr async, out XblMultiplayerSessionHandleId handle);

		[PreserveSig]
		internal static extern int XblMultiplayerCreateSearchHandleAsync(IntPtr xblContext, [In] ref XblMultiplayerSessionReference sessionRef, [Optional] XblMultiplayerSessionTag[] tags, SizeT tagsCount, [Optional] XblMultiplayerSessionNumberAttribute[] numberAttributes, SizeT numberAttributesCount, [Optional] XblMultiplayerSessionStringAttribute[] stringAttributes, SizeT stringAttributesCount, XAsyncBlockPtr async);

		[PreserveSig]
		public static extern int XblMultiplayerCreateSearchHandleResult(XAsyncBlockPtr async, out XblMultiplayerSearchHandle handle);

		[PreserveSig]
		public static extern int XblMultiplayerDeleteSearchHandleAsync(IntPtr xblContext, byte[] handleId, XAsyncBlockPtr async);

		[PreserveSig]
		public static extern int XblMultiplayerGetSearchHandlesAsync(IntPtr xblContext, byte[] scid, byte[] sessionTemplateName, [Optional] byte[] orderByAttribute, bool orderAscending, [Optional] byte[] searchFilter, [Optional] byte[] socialGroup, XAsyncBlockPtr async);

		[PreserveSig]
		public static extern int XblMultiplayerGetSearchHandlesResultCount(XAsyncBlockPtr async, out SizeT searchHandleCount);

		[PreserveSig]
		public static extern int XblMultiplayerGetSearchHandlesResult(XAsyncBlockPtr async, [Out] XblMultiplayerSearchHandle[] searchHandles, SizeT searchHandleCount);

		[PreserveSig]
		public static extern int XblMultiplayerSendInvitesAsync(IntPtr xblContext, [In] ref XblMultiplayerSessionReference sessionRef, [In] ulong[] xuids, SizeT xuidsCount, uint titleId, [Optional] byte[] contextStringId, [Optional] byte[] customActivationContext, XAsyncBlockPtr async);

		[PreserveSig]
		public static extern int XblMultiplayerSendInvitesResult(XAsyncBlockPtr async, SizeT handlesCount, [Out] XblMultiplayerInviteHandle[] handles);

		[PreserveSig]
		public static extern int XblMultiplayerGetActivitiesForSocialGroupAsync(IntPtr xboxLiveContext, byte[] scid, ulong socialGroupOwnerXuid, byte[] socialGroup, XAsyncBlockPtr async);

		[PreserveSig]
		public static extern int XblMultiplayerGetActivitiesWithPropertiesForSocialGroupAsync(IntPtr xboxLiveContext, byte[] scid, ulong socialGroupOwnerXuid, byte[] socialGroup, XAsyncBlockPtr async);

		[PreserveSig]
		public static extern int XblMultiplayerGetActivitiesForSocialGroupResultCount(XAsyncBlockPtr async, out SizeT activityCount);

		[PreserveSig]
		public static extern int XblMultiplayerGetActivitiesForSocialGroupResult(XAsyncBlockPtr async, SizeT activityCount, [Out] XblMultiplayerActivityDetails[] activities);

		[PreserveSig]
		public static extern int XblMultiplayerGetActivitiesWithPropertiesForSocialGroupResultSize(XAsyncBlockPtr async, out SizeT resultSizeInBytes);

		[PreserveSig]
		public static extern int XblMultiplayerGetActivitiesWithPropertiesForSocialGroupResult(XAsyncBlockPtr async, SizeT bufferSize, IntPtr buffer, out IntPtr ptrToBuffer, out SizeT ptrToBufferCount, out SizeT bufferUsed);

		[PreserveSig]
		public static extern int XblMultiplayerGetActivitiesForUsersAsync(IntPtr xboxLiveContext, byte[] scid, [In] ulong[] xuids, SizeT xuidsCount, XAsyncBlockPtr async);

		[PreserveSig]
		public static extern int XblMultiplayerGetActivitiesWithPropertiesForUsersAsync(IntPtr xboxLiveContext, byte[] scid, [In] ulong[] xuids, SizeT xuidsCount, XAsyncBlockPtr async);

		[PreserveSig]
		public static extern int XblMultiplayerGetActivitiesForUsersResultCount(XAsyncBlockPtr async, out SizeT activityCount);

		[PreserveSig]
		public static extern int XblMultiplayerGetActivitiesForUsersResult(XAsyncBlockPtr async, SizeT activityCount, [Out] XblMultiplayerActivityDetails[] activities);

		[PreserveSig]
		public static extern int XblMultiplayerGetActivitiesWithPropertiesForUsersResultSize(XAsyncBlockPtr async, out SizeT resultSizeInBytes);

		[PreserveSig]
		public static extern int XblMultiplayerGetActivitiesWithPropertiesForUsersResult(XAsyncBlockPtr async, SizeT bufferSize, IntPtr buffer, out IntPtr ptrToBuffer, out SizeT ptrToBufferCount, out SizeT bufferUsed);

		[PreserveSig]
		public static extern int XblMultiplayerSetSubscriptionsEnabled(IntPtr xblContext, bool subscriptionsEnabled);

		[PreserveSig]
		public static extern bool XblMultiplayerSubscriptionsEnabled(IntPtr xblHandle);

		[PreserveSig]
		internal static extern XblFunctionContext XblMultiplayerAddSessionChangedHandler(IntPtr xblContext, XblMultiplayerSessionChangedHandler handler, IntPtr context);

		[PreserveSig]
		internal static extern int XblMultiplayerRemoveSessionChangedHandler(IntPtr xblContext, XblFunctionContext token);

		[PreserveSig]
		internal static extern XblFunctionContext XblMultiplayerAddSubscriptionLostHandler(IntPtr xblContext, XblMultiplayerSessionSubscriptionLostHandler handler, IntPtr context);

		[PreserveSig]
		internal static extern int XblMultiplayerRemoveSubscriptionLostHandler(IntPtr xblContext, XblFunctionContext token);

		[PreserveSig]
		internal static extern int XblMultiplayerSessionSetCustomPropertyJson(IntPtr handle, byte[] name, byte[] valueJson);

		[PreserveSig]
		internal static extern int XblMultiplayerSessionDeleteCustomPropertyJson(IntPtr handle, byte[] name);

		[PreserveSig]
		internal static extern XblMultiplayerSessionChangeTypes XblMultiplayerSessionCompare(IntPtr currentSessionHandle, IntPtr oldSessionHandle);

		[PreserveSig]
		internal static extern XblFunctionContext XblMultiplayerAddConnectionIdChangedHandler(IntPtr xblContext, XblMultiplayerConnectionIdChangedHandler handler, IntPtr context);

		[PreserveSig]
		internal static extern int XblMultiplayerRemoveConnectionIdChangedHandler(IntPtr xblContext, XblFunctionContext token);

		[PreserveSig]
		internal static extern int XblMultiplayerActivityUpdateRecentPlayers(IntPtr xboxLiveContext, [Optional] XblMultiplayerActivityRecentPlayerUpdate[] updates, SizeT updatesCount);

		[PreserveSig]
		internal static extern int XblMultiplayerActivityFlushRecentPlayersAsync(IntPtr xboxLiveContext, XAsyncBlockPtr async);

		[PreserveSig]
		internal static extern int XblMultiplayerActivitySetActivityAsync(IntPtr xboxLiveContext, [In] ref XblMultiplayerActivityInfo activityInfo, bool allowCrossPlatformJoin, XAsyncBlockPtr async);

		[PreserveSig]
		internal static extern int XblMultiplayerActivityGetActivityAsync(IntPtr xboxLiveContext, [In] ulong[] xboxUserIdList, SizeT xboxUserIdListCount, XAsyncBlockPtr async);

		[PreserveSig]
		internal static extern int XblMultiplayerActivityGetActivityResultSize(XAsyncBlockPtr async, out SizeT resultSizeInBytes);

		[PreserveSig]
		internal static extern int XblMultiplayerActivityGetActivityResult(XAsyncBlockPtr async, SizeT bufferSize, IntPtr buffer, out IntPtr ptrToBufferResults, out SizeT resultCount, out SizeT bufferUsed);

		[PreserveSig]
		internal static extern int XblMultiplayerActivityDeleteActivityAsync(IntPtr xboxLiveContext, XAsyncBlockPtr async);

		[PreserveSig]
		internal static extern int XblMultiplayerActivitySendInvitesAsync(IntPtr xblContext, [In] ulong[] xboxUserIdList, SizeT xboxUserIdListCount, bool allowCrossPlatformJoin, byte[] connectionString, XAsyncBlockPtr async);

		[PreserveSig]
		internal static extern int XblMultiplayerManagerLobbySessionHost(out XblMultiplayerManagerMember hostMember);

		[PreserveSig]
		internal static extern int XblMultiplayerEventArgsTournamentRegistrationStateChanged(IntPtr argsHandle, out XblTournamentRegistrationState registrationState, out XblTournamentRegistrationReason registrationReason);

		[PreserveSig]
		internal static extern XblMultiplayerSessionReference XblMultiplayerSessionReferenceCreate(byte[] scid, byte[] sessionTemplateName, byte[] sessionName);

		[PreserveSig]
		internal static extern int XblMultiplayerEventArgsFindMatchCompleted(IntPtr argsHandle, out XblMultiplayerMatchStatus matchStatus, out XblMultiplayerMeasurementFailure initializationFailureCause);

		[PreserveSig]
		internal static extern int XblMultiplayerManagerLobbySessionInviteUsers(IntPtr user, [In] ulong[] xuids, SizeT xuidsCount, byte[] contextStringId, byte[] customActivationContext);

		[PreserveSig]
		internal static extern int XblMultiplayerManagerJoinLobby(byte[] handleId, IntPtr user);

		[PreserveSig]
		internal static extern int XblMultiplayerManagerLobbySessionInviteFriends(IntPtr requestingUser, byte[] contextStringId, byte[] customActivationContext);

		[PreserveSig]
		internal static extern int XblMultiplayerManagerSetQosMeasurements(byte[] measurementsJson);

		[PreserveSig]
		internal static extern int XblMultiplayerManagerSetJoinability(XblMultiplayerJoinability joinability, IntPtr context);

		[PreserveSig]
		internal static extern int XblMultiplayerManagerLobbySessionAddLocalUser(IntPtr user);

		[PreserveSig]
		internal static extern int XblMultiplayerEventArgsMembersCount(IntPtr argsHandle, out SizeT memberCount);

		[PreserveSig]
		internal static extern int XblMultiplayerManagerJoinGameFromLobby(byte[] sessionTemplateName);

		[PreserveSig]
		internal static extern NativeBool XblMultiplayerManagerGameSessionIsHost(ulong xuid);

		[PreserveSig]
		internal static extern int XblMultiplayerEventArgsPropertiesJson(IntPtr argsHandle, out UTF8StringPtr properties);

		[PreserveSig]
		internal static extern int XblMultiplayerManagerGameSessionHost(out XblMultiplayerManagerMember hostMember);

		[PreserveSig]
		internal static extern int XblMultiplayerManagerLobbySessionSessionReference(out XblMultiplayerSessionReference sessionReference);

		[PreserveSig]
		internal static extern int XblMultiplayerManagerLobbySessionSetProperties(byte[] name, byte[] valueJson, IntPtr context);

		[PreserveSig]
		internal static extern void XblMultiplayerManagerSetAutoFillMembersDuringMatchmaking(NativeBool autoFillMembers);

		[PreserveSig]
		internal static extern int XblMultiplayerManagerLobbySessionSetLocalMemberProperties(IntPtr user, byte[] name, byte[] valueJson, IntPtr context);

		[PreserveSig]
		internal static extern int XblMultiplayerManagerLobbySessionSetSynchronizedProperties(byte[] name, byte[] valueJson, IntPtr context);

		[PreserveSig]
		internal unsafe static extern XblMultiplayerSessionReference* XblMultiplayerManagerGameSessionSessionReference();

		[PreserveSig]
		internal static extern int XblMultiplayerEventArgsXuid(IntPtr argsHandle, out ulong xuid);

		[PreserveSig]
		internal static extern int XblMultiplayerManagerGameSessionSetProperties(byte[] name, byte[] valueJson, IntPtr context);

		[PreserveSig]
		internal static extern int XblMultiplayerManagerLobbySessionMembers(SizeT membersCount, [Out] XblMultiplayerManagerMember[] members);

		[PreserveSig]
		internal static extern XblMultiplayerJoinability XblMultiplayerManagerJoinability();

		[PreserveSig]
		internal static extern UTF8StringPtr XblMultiplayerManagerLobbySessionPropertiesJson();

		[PreserveSig]
		internal static extern void XblMultiplayerManagerCancelMatch();

		[PreserveSig]
		internal static extern uint XblMultiplayerManagerEstimatedMatchWaitTime();

		[PreserveSig]
		internal unsafe static extern XblMultiplayerSessionConstants* XblMultiplayerManagerLobbySessionConstants();

		[PreserveSig]
		internal static extern int XblMultiplayerEventArgsTournamentGameSessionReady(IntPtr argsHandle, out TimeT startTime);

		[PreserveSig]
		internal static extern SizeT XblMultiplayerManagerLobbySessionLocalMembersCount();

		[PreserveSig]
		internal static extern NativeBool XblMultiplayerManagerGameSessionActive();

		[PreserveSig]
		internal static extern int XblMultiplayerManagerInitialize(byte[] lobbySessionTemplateName, XTaskQueueHandle asyncQueue);

		[PreserveSig]
		internal static extern int XblMultiplayerManagerLobbySessionRemoveLocalUser(IntPtr user);

		[PreserveSig]
		internal static extern int XblMultiplayerManagerLobbySessionDeleteLocalMemberProperties(IntPtr user, byte[] name, IntPtr context);

		[PreserveSig]
		internal static extern int XblMultiplayerEventArgsMember(IntPtr argsHandle, out XblMultiplayerManagerMember member);

		[PreserveSig]
		internal static extern NativeBool XblMultiplayerManagerMemberAreMembersOnSameDevice([In] ref XblMultiplayerManagerMember first, [In] ref XblMultiplayerManagerMember second);

		[PreserveSig]
		internal static extern int XblMultiplayerManagerGameSessionSetSynchronizedHost(byte[] deviceToken, IntPtr context);

		[PreserveSig]
		internal unsafe static extern XblTournamentTeamResult* XblMultiplayerManagerLobbySessionLastTournamentTeamResult();

		[PreserveSig]
		internal static extern int XblMultiplayerSessionReferenceParseFromUriPath(byte[] path, out XblMultiplayerSessionReference sessionReference);

		[PreserveSig]
		internal static extern int XblMultiplayerSessionReferenceToUriPath(XblMultiplayerSessionReference sessionReference, out XblMultiplayerSessionReferenceUri sessionReferenceUri);

		[PreserveSig]
		internal static extern int XblMultiplayerManagerLeaveGame();

		[PreserveSig]
		internal static extern int XblMultiplayerEventArgsMembers(IntPtr argsHandle, SizeT membersCount, [Out] XblMultiplayerManagerMember[] members);

		[PreserveSig]
		internal static extern NativeBool XblMultiplayerManagerLobbySessionIsHost(ulong xuid);

		[PreserveSig]
		internal static extern int XblMultiplayerManagerGameSessionSetSynchronizedProperties(byte[] name, byte[] valueJson, IntPtr context);

		[PreserveSig]
		internal static extern UTF8StringPtr XblMultiplayerManagerGameSessionCorrelationId();

		[PreserveSig]
		internal unsafe static extern XblMultiplayerSessionConstants* XblMultiplayerManagerGameSessionConstants();

		[PreserveSig]
		internal static extern int XblMultiplayerManagerLobbySessionLocalMembers(SizeT localMembersCount, [Out] XblMultiplayerManagerMember[] localMembers);

		[PreserveSig]
		internal static extern XblMultiplayerMatchStatus XblMultiplayerManagerMatchStatus();

		[PreserveSig]
		internal static extern int XblMultiplayerManagerLobbySessionSetSynchronizedHost(byte[] deviceToken, IntPtr context);

		[PreserveSig]
		internal static extern NativeBool XblMultiplayerManagerAutoFillMembersDuringMatchmaking();

		[PreserveSig]
		internal static extern int XblMultiplayerManagerLobbySessionCorrelationId(out XblGuid correlationId);

		[PreserveSig]
		internal static extern SizeT XblMultiplayerManagerLobbySessionMembersCount();

		[PreserveSig]
		internal static extern int XblMultiplayerManagerFindMatch(byte[] hopperName, byte[] attributesJson, uint timeoutInSeconds);

		[PreserveSig]
		internal static extern int XblMultiplayerManagerDoWork(out IntPtr multiplayerEvents, out SizeT multiplayerEventsCount);

		[PreserveSig]
		internal static extern NativeBool XblMultiplayerSessionReferenceIsValid([In] ref XblMultiplayerSessionReference sessionReference);

		[PreserveSig]
		internal static extern int XblMultiplayerManagerGameSessionMembers(SizeT membersCount, [Out] XblMultiplayerManagerMember[] members);

		[PreserveSig]
		internal static extern int XblMultiplayerManagerLobbySessionSetLocalMemberConnectionAddress(IntPtr user, byte[] connectionAddress, IntPtr context);

		[PreserveSig]
		internal static extern int XblMultiplayerManagerJoinGame(byte[] sessionName, byte[] sessionTemplateName, [In] ulong[] xuids, SizeT xuidsCount);

		[PreserveSig]
		internal static extern SizeT XblMultiplayerManagerGameSessionMembersCount();

		[PreserveSig]
		internal static extern UTF8StringPtr XblMultiplayerManagerGameSessionPropertiesJson();

		[PreserveSig]
		internal static extern int XblMultiplayerEventArgsPerformQoSMeasurements(IntPtr argsHandle, out XblMultiplayerPerformQoSMeasurementsArgs performQoSMeasurementsArgs);

		[PreserveSig]
		internal static extern int XblPresenceRecordGetXuid(IntPtr handle, out ulong xuid);

		[PreserveSig]
		internal static extern int XblPresenceRecordGetUserState(IntPtr handle, out XblPresenceUserState userState);

		[PreserveSig]
		internal static extern int XblPresenceRecordGetDeviceRecords(IntPtr handle, out IntPtr deviceRecords, out SizeT deviceRecordsCount);

		[PreserveSig]
		internal static extern int XblPresenceRecordDuplicateHandle(IntPtr handle, out XblPresenceRecordHandle duplicatedHandle);

		[PreserveSig]
		internal static extern void XblPresenceRecordCloseHandle(IntPtr handle);

		[PreserveSig]
		internal static extern int XblPresenceSetPresenceAsync(IntPtr xblContextHandle, bool isUserActiveInTitle, [Optional] XblPresenceRichPresenceIdsRef richPresenceIds, XAsyncBlockPtr asyncBlockPtr);

		[PreserveSig]
		internal static extern int XblPresenceGetPresenceAsync(IntPtr xblContextHandle, ulong xuid, XAsyncBlockPtr asyncBlock);

		[PreserveSig]
		internal static extern int XblPresenceGetPresenceResult(XAsyncBlockPtr asyncBlock, out XblPresenceRecordHandle presenceRecordHandle);

		[PreserveSig]
		internal static extern int XblPresenceGetPresenceForMultipleUsersAsync(IntPtr xblContextHandle, ulong[] xuids, SizeT xuidsCount, [Optional] XblPresenceQueryFiltersRef filters, XAsyncBlockPtr asyncBlock);

		[PreserveSig]
		internal static extern int XblPresenceGetPresenceForMultipleUsersResultCount(XAsyncBlockPtr asyncBlock, out SizeT resultCount);

		[PreserveSig]
		internal static extern int XblPresenceGetPresenceForMultipleUsersResult(XAsyncBlockPtr asyncBlock, [Out] XblPresenceRecordHandle[] presenceRecordHandles, SizeT presenceRecordHandlesCount);

		[PreserveSig]
		internal static extern int XblPresenceGetPresenceForSocialGroupAsync(IntPtr xblContextHandle, byte[] socialGroupName, [Optional] UInt64Ref socialGroupOwnerXuid, [Optional] XblPresenceQueryFiltersRef filters, XAsyncBlockPtr asyncBlock);

		[PreserveSig]
		internal static extern int XblPresenceGetPresenceForSocialGroupResultCount(XAsyncBlockPtr asyncBlock, out SizeT resultCount);

		[PreserveSig]
		internal static extern int XblPresenceGetPresenceForSocialGroupResult(XAsyncBlockPtr asyncBlock, [Out] XblPresenceRecordHandle[] presenceRecordHandles, SizeT presenceRecordHandlesCount);

		[PreserveSig]
		internal static extern int XblPresenceSubscribeToDevicePresenceChange(XblContextHandle xblContextHandle, ulong xuid, out XblRealTimeActivitySubscriptionHandle subscriptionHandle);

		[PreserveSig]
		internal static extern int XblPresenceUnsubscribeFromDevicePresenceChange(XblContextHandle xblContextHandle, XblRealTimeActivitySubscriptionHandle subscriptionHandle);

		[PreserveSig]
		internal static extern int XblPresenceSubscribeToTitlePresenceChange(XblContextHandle xblContextHandle, ulong xuid, uint titleId, out XblRealTimeActivitySubscriptionHandle subscriptionHandle);

		[PreserveSig]
		internal static extern int XblPresenceUnsubscribeFromTitlePresenceChange(XblContextHandle xblContext, XblRealTimeActivitySubscriptionHandle subscriptionHandle);

		[PreserveSig]
		internal static extern XblFunctionContext XblPresenceAddDevicePresenceChangedHandler(XblContextHandle xblContextHandle, XblPresenceDevicePresenceChangedHandler handler, IntPtr context);

		[PreserveSig]
		internal static extern int XblPresenceRemoveDevicePresenceChangedHandler(XblContextHandle xblContextHandle, XblFunctionContext token);

		[PreserveSig]
		internal static extern XblFunctionContext XblPresenceAddTitlePresenceChangedHandler(XblContextHandle xblContextHandle, XblPresenceTitlePresenceChangedHandler handler, IntPtr context);

		[PreserveSig]
		internal static extern int XblPresenceRemoveTitlePresenceChangedHandler(XblContextHandle xblContextHandle, XblFunctionContext token);

		[PreserveSig]
		internal static extern int XblPrivacyGetAvoidListAsync(IntPtr xblContextHandle, XAsyncBlockPtr async);

		[PreserveSig]
		internal static extern int XblPrivacyGetAvoidListResultCount(XAsyncBlockPtr async, out SizeT xuidCount);

		[PreserveSig]
		internal static extern int XblPrivacyGetAvoidListResult(XAsyncBlockPtr async, SizeT xuidCount, [Out] ulong[] xuids);

		[PreserveSig]
		internal static extern int XblPrivacyGetMuteListAsync(IntPtr xblContextHandle, XAsyncBlockPtr async);

		[PreserveSig]
		internal static extern int XblPrivacyGetMuteListResultCount(XAsyncBlockPtr async, out SizeT xuidCount);

		[PreserveSig]
		internal static extern int XblPrivacyGetMuteListResult(XAsyncBlockPtr async, SizeT xuidCount, [Out] ulong[] xuids);

		[PreserveSig]
		internal static extern int XblPrivacyCheckPermissionAsync(IntPtr xblContextHandle, XblPermission permissionToCheck, ulong targetXuid, XAsyncBlockPtr async);

		[PreserveSig]
		internal static extern int XblPrivacyCheckPermissionResultSize(XAsyncBlockPtr async, out SizeT resultSizeInBytes);

		[PreserveSig]
		internal static extern int XblPrivacyCheckPermissionResult(XAsyncBlockPtr async, SizeT bufferSize, IntPtr buffer, out IntPtr result, out SizeT bufferUsed);

		[PreserveSig]
		internal static extern int XblPrivacyCheckPermissionForAnonymousUserAsync(IntPtr xblContextHandle, XblPermission permissionToCheck, XblAnonymousUserType userType, XAsyncBlockPtr async);

		[PreserveSig]
		internal static extern int XblPrivacyCheckPermissionForAnonymousUserResultSize(XAsyncBlockPtr async, out SizeT resultSizeInBytes);

		[PreserveSig]
		internal static extern int XblPrivacyCheckPermissionForAnonymousUserResult(XAsyncBlockPtr async, SizeT bufferSize, IntPtr buffer, out IntPtr ptrToBuffer, out SizeT bufferUsed);

		[PreserveSig]
		internal static extern int XblPrivacyBatchCheckPermissionAsync(IntPtr xblContextHandle, [In] XblPermission[] permissionsToCheck, SizeT permissionsCount, [In] ulong[] targetXuids, SizeT xuidsCount, [In] XblAnonymousUserType[] targetAnonymousUserTypes, SizeT targetAnonymousUserTypesCount, XAsyncBlockPtr async);

		[PreserveSig]
		internal static extern int XblPrivacyBatchCheckPermissionResultSize(XAsyncBlockPtr async, out SizeT resultSizeInBytes);

		[PreserveSig]
		internal static extern int XblPrivacyBatchCheckPermissionResult(XAsyncBlockPtr async, SizeT bufferSize, IntPtr buffer, out IntPtr results, out SizeT resultsCount, out SizeT bufferUsed);

		[PreserveSig]
		internal static extern int XblProfileGetUserProfileAsync(IntPtr xblContextHandle, ulong xboxUserId, XAsyncBlockPtr async);

		[PreserveSig]
		internal static extern int XblProfileGetUserProfileResult(XAsyncBlockPtr async, out XblUserProfile profile);

		[PreserveSig]
		internal static extern int XblProfileGetUserProfilesAsync(IntPtr xblContextHandle, ulong[] xboxUserIds, SizeT xboxUserIdsCount, XAsyncBlockPtr async);

		[PreserveSig]
		internal static extern int XblProfileGetUserProfilesResultCount(XAsyncBlockPtr async, out SizeT profileCount);

		[PreserveSig]
		internal static extern int XblProfileGetUserProfilesResult(XAsyncBlockPtr async, SizeT profilesCount, [Out] XblUserProfile[] profiles);

		[PreserveSig]
		internal static extern int XblProfileGetUserProfilesForSocialGroupAsync(IntPtr xblContextHandle, byte[] socialGroup, XAsyncBlockPtr async);

		[PreserveSig]
		internal static extern int XblProfileGetUserProfilesForSocialGroupResultCount(XAsyncBlockPtr async, out SizeT profileCount);

		[PreserveSig]
		internal static extern int XblProfileGetUserProfilesForSocialGroupResult(XAsyncBlockPtr async, SizeT profilesCount, [Out] XblUserProfile[] profiles);

		[PreserveSig]
		internal static extern int XblSocialGetSocialRelationshipsAsync(IntPtr xboxLiveContext, ulong xboxUserId, XblSocialRelationshipFilter socialRelationshipFilter, SizeT startIndex, SizeT maxItems, XAsyncBlockPtr async);

		[PreserveSig]
		internal static extern int XblSocialGetSocialRelationshipsResult(XAsyncBlockPtr async, out XblSocialRelationshipResultHandle handle);

		[PreserveSig]
		internal static extern int XblSocialRelationshipResultGetRelationships(XblSocialRelationshipResultHandle resultHandle, out IntPtr relationships, out SizeT relationshipsCount);

		[PreserveSig]
		internal static extern int XblSocialRelationshipResultHasNext(XblSocialRelationshipResultHandle resultHandle, out bool hasNext);

		[PreserveSig]
		internal static extern int XblSocialRelationshipResultGetTotalCount(XblSocialRelationshipResultHandle resultHandle, out SizeT totalCount);

		[PreserveSig]
		internal static extern int XblSocialRelationshipResultGetNextAsync(IntPtr xboxLiveContext, XblSocialRelationshipResultHandle resultHandle, SizeT maxItems, XAsyncBlockPtr async);

		[PreserveSig]
		internal static extern int XblSocialRelationshipResultGetNextResult(XAsyncBlockPtr async, out XblSocialRelationshipResultHandle handle);

		[PreserveSig]
		internal static extern int XblSocialRelationshipResultDuplicateHandle(XblSocialRelationshipResultHandle handle, out XblSocialRelationshipResultHandle duplicatedHandle);

		[PreserveSig]
		internal static extern void XblSocialRelationshipResultCloseHandle(XblSocialRelationshipResultHandle handle);

		[PreserveSig]
		internal static extern int XblSocialAddSocialRelationshipChangedHandler(IntPtr xboxLiveContext, XblSocialRelationshipChangedHandler handler, IntPtr handlerContext);

		[PreserveSig]
		internal static extern int XblSocialRemoveSocialRelationshipChangedHandler(IntPtr xboxLiveContext, int handlerFunctionContext);

		[PreserveSig]
		internal static extern bool XblSocialManagerPresenceRecordIsUserPlayingTitle([In] ref XblSocialManagerPresenceRecord presenceRecord, uint titleId);

		[PreserveSig]
		internal static extern int XblSocialManagerUserGroupGetUsers(IntPtr group, out IntPtr xboxSocialUsers, out SizeT usersCount);

		[PreserveSig]
		internal static extern int XblSocialManagerUserGroupGetUsersTrackedByGroup(IntPtr group, out IntPtr trackedUsers, out SizeT trackedUsersCount);

		[PreserveSig]
		internal static extern int XblSocialManagerAddLocalUser(IntPtr user, XblSocialManagerExtraDetailLevel extraLevelDetail, XTaskQueueHandle queue);

		[PreserveSig]
		internal static extern int XblSocialManagerRemoveLocalUser(IntPtr user);

		[PreserveSig]
		internal static extern int XblSocialManagerDoWork(out IntPtr socialEvents, out SizeT socialEventsCount);

		[PreserveSig]
		internal static extern int XblSocialManagerCreateSocialUserGroupFromFilters(IntPtr user, XblPresenceFilter presenceDetailLevel, XblRelationshipFilter filter, out XblSocialManagerUserGroupHandle group);

		[PreserveSig]
		internal static extern int XblSocialManagerCreateSocialUserGroupFromList(IntPtr user, ulong[] xboxUserIdList, SizeT xboxUserIdListCount, out XblSocialManagerUserGroupHandle group);

		[PreserveSig]
		internal static extern int XblSocialManagerDestroySocialUserGroup(IntPtr group);

		[PreserveSig]
		internal static extern SizeT XblSocialManagerGetLocalUserCount();

		[PreserveSig]
		internal static extern int XblSocialManagerGetLocalUsers(SizeT usersCount, [Out] IntPtr[] users);

		[PreserveSig]
		internal static extern int XblSocialManagerUpdateSocialUserGroup(IntPtr group, ulong[] users, SizeT usersCount);

		[PreserveSig]
		internal static extern int XblSocialManagerSetRichPresencePollingStatus(IntPtr user, bool shouldEnablePolling);

		[PreserveSig]
		internal static extern int XblSocialManagerUserGroupGetType(IntPtr group, out XblSocialUserGroupType type);

		[PreserveSig]
		internal static extern int XblSocialManagerUserGroupGetLocalUser(IntPtr group, out IntPtr localUser);

		[PreserveSig]
		internal static extern int XblSocialManagerUserGroupGetFilters(IntPtr group, out XblPresenceFilter presenceFilter, out XblRelationshipFilter relationshipFilter);

		[PreserveSig]
		internal static extern int XblStringVerifyStringAsync(IntPtr xblContextHandle, byte[] stringToVerify, XAsyncBlockPtr async);

		[PreserveSig]
		internal static extern int XblStringVerifyStringResultSize(XAsyncBlockPtr async, out SizeT resultSizeInBytes);

		[PreserveSig]
		internal static extern int XblStringVerifyStringResult(XAsyncBlockPtr async, SizeT bufferSize, IntPtr buffer, out IntPtr ptrToBuffer, out SizeT bufferUsed);

		[PreserveSig]
		internal static extern int XblStringVerifyStringsAsync(IntPtr xblContextHandle, IntPtr stringsToVerify, ulong stringsCount, XAsyncBlockPtr async);

		[PreserveSig]
		internal static extern int XblStringVerifyStringsResultSize(XAsyncBlockPtr async, out SizeT resultSizeInBytes);

		[PreserveSig]
		internal static extern int XblStringVerifyStringsResult(XAsyncBlockPtr async, SizeT bufferSize, IntPtr buffer, out IntPtr ptrToBufferStrings, out SizeT stringsCount, out SizeT bufferUsed);

		[PreserveSig]
		internal static extern int XblTitleManagedStatsWriteAsync(IntPtr xblContextHandle, ulong xboxUserId, [In] XblTitleManagedStatistic[] statistics, SizeT statisticsCount, XAsyncBlockPtr async);

		[PreserveSig]
		internal static extern int XblTitleManagedStatsUpdateStatsAsync(IntPtr xblContextHandle, [In] XblTitleManagedStatistic[] statistics, SizeT statisticsCount, XAsyncBlockPtr async);

		[PreserveSig]
		internal static extern int XblTitleManagedStatsDeleteStatsAsync(IntPtr xblContextHandle, IntPtr statisticNames, SizeT statisticNamesCount, XAsyncBlockPtr async);

		[PreserveSig]
		internal static extern int XblTitleStorageBlobMetadataResultGetItems([In] IntPtr resultHandle, out IntPtr items, out SizeT itemsCount);

		[PreserveSig]
		internal static extern int XblTitleStorageBlobMetadataResultHasNext([In] IntPtr resultHandle, out bool hasNext);

		[PreserveSig]
		public static extern int XblTitleStorageBlobMetadataResultGetNextAsync([In] IntPtr resultHandle, uint maxItems, XAsyncBlockPtr async);

		[PreserveSig]
		public static extern int XblTitleStorageBlobMetadataResultGetNextResult(XAsyncBlockPtr async, out XblTitleStorageBlobMetadataResultHandle result);

		[PreserveSig]
		public static extern int XblTitleStorageBlobMetadataResultDuplicateHandle([In] IntPtr handle, out XblTitleStorageBlobMetadataResultHandle duplicatedHandle);

		[PreserveSig]
		public static extern int XblTitleStorageBlobMetadataResultCloseHandle([In] IntPtr handle);

		[PreserveSig]
		public static extern int XblTitleStorageGetQuotaAsync(IntPtr xboxLiveContext, byte[] serviceConfigurationId, XblTitleStorageType storageType, XAsyncBlockPtr async);

		[PreserveSig]
		public static extern int XblTitleStorageGetQuotaResult(XAsyncBlockPtr async, out SizeT usedBytes, out SizeT quotaBytes);

		[PreserveSig]
		public static extern int XblTitleStorageGetBlobMetadataAsync(IntPtr xboxLiveContext, byte[] serviceConfigurationId, XblTitleStorageType storageType, byte[] blobPath, ulong xboxUserId, uint skipItems, uint maxItems, XAsyncBlockPtr async);

		[PreserveSig]
		public static extern int XblTitleStorageGetBlobMetadataResult(XAsyncBlockPtr async, out XblTitleStorageBlobMetadataResultHandle result);

		[PreserveSig]
		public static extern int XblTitleStorageDeleteBlobAsync(IntPtr xboxLiveContext, XblTitleStorageBlobMetadata blobMetadata, bool deleteOnlyIfEtagMatches, XAsyncBlockPtr async);

		[PreserveSig]
		public static extern int XblTitleStorageDownloadBlobAsync(IntPtr xboxLiveContext, XblTitleStorageBlobMetadata blobMetadata, IntPtr blobBuffer, SizeT blobBufferCount, XblTitleStorageETagMatchCondition etagMatchCondition, byte[] selectQuery, SizeT preferredDownloadBlockSize, XAsyncBlockPtr async);

		[PreserveSig]
		public static extern int XblTitleStorageDownloadBlobResult(XAsyncBlockPtr async, out XblTitleStorageBlobMetadata blobMetadata);

		[PreserveSig]
		public static extern int XblTitleStorageUploadBlobAsync(IntPtr xboxLiveContext, XblTitleStorageBlobMetadata blobMetadata, IntPtr blobBuffer, SizeT blobBufferCount, XblTitleStorageETagMatchCondition etagMatchCondition, SizeT preferredUploadBlockSize, XAsyncBlockPtr async);

		[PreserveSig]
		public static extern int XblTitleStorageUploadBlobResult(XAsyncBlockPtr async, out XblTitleStorageBlobMetadata blobMetadata);

		[PreserveSig]
		internal static extern int XblUserStatisticsGetSingleUserStatisticAsync(IntPtr xblContextHandle, ulong xboxUserId, byte[] serviceConfigurationId, byte[] statisticName, XAsyncBlockPtr asyncBlock);

		[PreserveSig]
		internal static extern int XblUserStatisticsGetSingleUserStatisticResultSize(XAsyncBlockPtr asyncBlock, out SizeT resultSizeInBytes);

		[PreserveSig]
		internal static extern int XblUserStatisticsGetSingleUserStatisticResult(XAsyncBlockPtr asyncBlock, SizeT bufferSize, IntPtr buffer, out IntPtr ptrToBuffer, out SizeT bufferUsed);

		[PreserveSig]
		internal static extern int XblUserStatisticsGetSingleUserStatisticsAsync(IntPtr xblContextHandle, ulong xboxUserId, byte[] serviceConfigurationId, IntPtr statisticNames, SizeT statisticNamesCount, XAsyncBlockPtr asyncBlock);

		[PreserveSig]
		internal static extern int XblUserStatisticsGetSingleUserStatisticsResultSize(XAsyncBlockPtr asyncBlock, out SizeT resultSizeInBytes);

		[PreserveSig]
		internal static extern int XblUserStatisticsGetSingleUserStatisticsResult(XAsyncBlockPtr asyncBlock, SizeT bufferSize, IntPtr buffer, out IntPtr ptrToBuffer, out SizeT bufferUsed);

		[PreserveSig]
		internal static extern int XblUserStatisticsGetMultipleUserStatisticsAsync(IntPtr xblContextHandle, ulong[] xboxUserIds, SizeT xboxUserIdsCount, byte[] serviceConfigurationId, IntPtr statisticNames, SizeT statisticNamesCount, XAsyncBlockPtr asyncBlock);

		[PreserveSig]
		internal static extern int XblUserStatisticsGetMultipleUserStatisticsResultSize(XAsyncBlockPtr asyncBlock, out SizeT resultSizeInBytes);

		[PreserveSig]
		internal static extern int XblUserStatisticsGetMultipleUserStatisticsResult(XAsyncBlockPtr asyncBlock, SizeT bufferSize, IntPtr buffer, out IntPtr ptrToBuffer, out SizeT resultsCount, out SizeT bufferUsed);

		[PreserveSig]
		internal static extern int XblUserStatisticsGetMultipleUserStatisticsForMultipleServiceConfigurationsAsync(IntPtr xblContextHandle, ulong[] xboxUserIds, uint xboxUserIdsCount, IntPtr requestedServiceConfigurationStatisticsCollection, uint requestedServiceConfigurationStatisticsCollectionCount, XAsyncBlockPtr asyncBlock);

		[PreserveSig]
		internal static extern int XblUserStatisticsGetMultipleUserStatisticsForMultipleServiceConfigurationsResultSize(XAsyncBlockPtr asyncBlock, out SizeT resultSizeInBytes);

		[PreserveSig]
		internal static extern int XblUserStatisticsGetMultipleUserStatisticsForMultipleServiceConfigurationsResult(XAsyncBlockPtr asyncBlock, SizeT bufferSize, IntPtr buffer, out IntPtr results, out SizeT resultsCount, out SizeT bufferUsed);

		[PreserveSig]
		internal static extern XblFunctionContext XblUserStatisticsAddStatisticChangedHandler(IntPtr xblContextHandle, XblStatisticChangedHandler handler, IntPtr handlerContext);

		[PreserveSig]
		internal static extern void XblUserStatisticsRemoveStatisticChangedHandler(IntPtr xblContextHandle, IntPtr context);

		[PreserveSig]
		internal static extern int XblUserStatisticsTrackStatistics(XblContextHandle xblContextHandle, ulong[] xboxUserIds, SizeT xboxUserIdsCount, byte[] serviceConfigurationId, IntPtr statisticNames, SizeT statisticNamesCount);

		[PreserveSig]
		internal static extern int XblUserStatisticsStopTrackingStatistics(XblContextHandle xblContextHandle, ulong[] xboxUserIds, SizeT xboxUserIdsCount, byte[] serviceConfigurationId, IntPtr statisticNames, SizeT statisticNamesCount);

		[PreserveSig]
		internal static extern int XblContextCreateHandle(IntPtr user, out XblContextHandle context);

		[PreserveSig]
		internal static extern void XblContextCloseHandle(IntPtr xboxLiveContextHandle);

		[PreserveSig]
		internal static extern XblErrorCondition XblGetErrorCondition(int hr);

		[PreserveSig]
		internal static extern int XblEventsWriteInGameEvent(IntPtr xboxLiveContext, byte[] eventName, [Optional] byte[] dimensionsJson, [Optional] byte[] measurementsJson);

		[PreserveSig]
		internal static extern int XblWrapper_XblInitialize(byte[] scid, XTaskQueueHandle internalWorkQueue);

		[PreserveSig]
		internal static extern int XblWrapper_XblCleanupAsync(XAsyncBlockPtr asyncBlock);

		[PreserveSig]
		internal static extern int XblCleanupAsync(XAsyncBlockPtr asyncBlock);
	}
}
