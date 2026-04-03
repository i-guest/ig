using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using AOT;
using Unity.XGamingRuntime.Interop;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.XGamingRuntime
{
	[MovedFrom("Unity.GameCore")]
	public class SDK
	{
		public class XBL
		{
			public delegate void XblAchievementsResultGetNextResult(int hresult, XblAchievementsResultHandle result);

			public delegate void XblAchievementsGetAchievementsForTitleIdResult(int hresult, XblAchievementsResultHandle result);

			public delegate void XblAchievementsUpdateAchievementResult(int hresult);

			public delegate void XblAchievementsUpdateAchievementForTitleIdResult(int hresult);

			public delegate void XblAchievementsGetAchievementResult(int hresult, XblAchievementsResultHandle result);

			public delegate void XblAchievementsProgressChangeHandlerResult(int hresult, XblAchievementProgressChangeEventArgs eventArgs, IntPtr context);

			public delegate void XblMatchmakingCreateMatchTicketHandleResult(int hresult, XblCreateMatchTicketResponse handle);

			public delegate void XblMatchmakingDeleteMatchTicketHandleResult(int hresult);

			public delegate void XblMatchmakingGetMatchTicketDetailsHandleResult(int hresult, XblMatchTicketDetailsResponse result);

			public delegate void XblMatchmakingGetHopperStatisticsHandleResult(int hresult, XblHopperStatisticsResponse result);

			public delegate void XblMultiplayerWriteSessionHandleResult(int hresult, XblMultiplayerSessionHandle handle);

			public delegate void XblMultiplayerGetSessionHandleResult(int hresult, XblMultiplayerSessionHandle handle);

			public delegate void XblMultiplayerSessionQueryHandleResult(int hresult, XblMultiplayerSessionQueryResult[] sessions);

			public delegate void XblMultiplayerSetActivityHandleResult(int hresult);

			public delegate void XblMultiplayerCreateSearchHandleResult(int hresult, XblMultiplayerSearchHandle handle);

			public delegate void XblMultiplayerSetTransferHandleResult(int hresult, XblMultiplayerSessionHandleId handle);

			public delegate void XblMultiplayerDeleteSearchHandleResult(int hresult);

			public delegate void XblMultiplayerClearActivityHandleResult(int hresult);

			public delegate void XblMultiplayerGetSearchHandlesResult(int hresult, XblMultiplayerSearchHandle[] searchHandles);

			public delegate void XblMultiplayerSessionChangedHandler(XblMultiplayerSessionChangeEventArgs args);

			public delegate void XblMultiplayerSessionSubscriptionLostHandler();

			public delegate void XblMultiplayerConnectionIdChangedHandler();

			public delegate void XblMultiplayerSendInvitesResult(int hresult, XblMultiplayerInviteHandle[] handles);

			public delegate void XblMultiplayerGetActivitiesResult(int hresult, XblMultiplayerActivityDetails[] activities);

			public delegate void XblMultiplayerActivityAsyncOperationCompleted(int hresult);

			public delegate void XblMultiplayerGetActivityAsyncOperationCompleted(int hresult, XblMultiplayerActivityInfo[] results);

			private class ConnectionStateChangeCallbackManager : InteropCallbackManager<XblConnectionStateChangeCallback>
			{
				[MonoPInvokeCallback]
				internal static void InteropPInvokeCallback(IntPtr context, Unity.XGamingRuntime.Interop.XblRealTimeActivityConnectionState newConnectionState)
				{
				}

				private void IssueEventCallback(int functionId, XblRealTimeActivityConnectionState newConnectionState)
				{
				}
			}

			private class ConnectionResyncCallbackManager : InteropCallbackManager<XblConnectionResyncCallback>
			{
				[MonoPInvokeCallback]
				internal static void InteropPInvokeCallback(IntPtr context)
				{
				}

				private void IssueEventCallback(int functionId)
				{
				}
			}

			private class SocialRelationshipChangeCallbackManager : InteropCallbackManager<XblSocialRelationshipChangedCallback>
			{
				[MonoPInvokeCallback]
				internal unsafe static void InteropPInvokeCallback(Unity.XGamingRuntime.Interop.XblSocialRelationshipChangeEventArgs* eventArgs, IntPtr context)
				{
				}

				private unsafe void IssueEventCallback(int functionId, Unity.XGamingRuntime.Interop.XblSocialRelationshipChangeEventArgs* eventArgs)
				{
				}
			}

			public delegate void XblUserStatisticsStatisticChangedHandler(XblStatisticChangeEventArgs args);

			private class UserStatisticsChangeCallbackManager : InteropCallbackManager<XblStatisticChangedCallback>
			{
				[MonoPInvokeCallback]
				internal unsafe static void InteropPInvokeCallback(Unity.XGamingRuntime.Interop.XblStatisticChangeEventArgs eventArgs, void* context)
				{
				}

				private void IssueEventCallback(int functionId, Unity.XGamingRuntime.Interop.XblStatisticChangeEventArgs eventArgs)
				{
				}
			}

			public delegate void XblCleanupResult(int hresult);

			private static ConnectionStateChangeCallbackManager _connectionStateChangeCallbackManager;

			private static ConnectionResyncCallbackManager _connectionResyncCallbackManager;

			private static SocialRelationshipChangeCallbackManager _socialRelationshipChangeCallbackManager;

			private static UserStatisticsChangeCallbackManager _userStatisticsChangeCallbackManager;

			public const int StandardScidLength = 36;

			internal static bool IsXblInitialized;

			public static int XblAchievementsResultGetAchievements(XblAchievementsResultHandle resultHandle, out XblAchievement[] achievements)
			{
				achievements = null;
				return 0;
			}

			public static int XblAchievementsResultHasNext(XblAchievementsResultHandle resultHandle, out bool hasNext)
			{
				hasNext = default(bool);
				return 0;
			}

			public static void XblAchievementsResultGetNextAsync(XblAchievementsResultHandle resultHandle, uint maxItems, XblAchievementsResultGetNextResult completionRoutine)
			{
			}

			public static void XblAchievementsGetAchievementsForTitleIdAsync(XblContextHandle xboxLiveContext, ulong xboxUserId, uint titleId, XblAchievementType type, bool unlockedOnly, XblAchievementOrderBy orderBy, uint skipItems, uint maxItems, XblAchievementsGetAchievementsForTitleIdResult completionRoutine)
			{
			}

			public static void XblAchievementsUpdateAchievementAsync(XblContextHandle xboxLiveContext, ulong xboxUserId, string achievementId, uint percentComplete, XblAchievementsUpdateAchievementResult completionRoutine)
			{
			}

			public static void XblAchievementsUpdateAchievementAsync(XblContextHandle xboxLiveContext, ulong xboxUserId, uint titleId, string serviceConfigurationId, string achievementId, uint percentComplete, XblAchievementsUpdateAchievementForTitleIdResult completionRoutine)
			{
			}

			public static void XblAchievementsUpdateAchievementForTitleIdAsync(XblContextHandle xboxLiveContext, ulong xboxUserId, uint titleId, string serviceConfigurationId, string achievementId, uint percentComplete, XblAchievementsUpdateAchievementForTitleIdResult completionRoutine)
			{
			}

			public static void XblAchievementsGetAchievementAsync(XblContextHandle xboxLiveContext, ulong xboxUserId, string serviceConfigurationId, string achievementId, XblAchievementsGetAchievementResult completionRoutine)
			{
			}

			public static XblFunctionContext XblAchievementsAddAchievementProgressChangeHandler(XblContextHandle xboxLiveContext, XblAchievementsProgressChangeHandlerResult handler, IntPtr handlerContext)
			{
				return default(XblFunctionContext);
			}

			public static XblFunctionContext XblAchievementsAddAchievementProgressChangeHandler(XblContextHandle xboxLiveContext, XblAchievementsProgressChangeHandlerResult handler)
			{
				return default(XblFunctionContext);
			}

			public static void XblAchievementsRemoveAchievementProgressChangeHandler(XblContextHandle xblContextHandle, XblFunctionContext functionContext)
			{
			}

			public static int XblAchievementsResultDuplicateHandle(XblAchievementsResultHandle handle, out XblAchievementsResultHandle duplicatedHandle)
			{
				duplicatedHandle = null;
				return 0;
			}

			public static void XblAchievementsResultCloseHandle(XblAchievementsResultHandle handle)
			{
			}

			public static int XblAchievementsManagerResultGetAchievements(XblAchievementsManagerResultHandle handle, out XblAchievement[] achievements)
			{
				achievements = null;
				return 0;
			}

			public static int XblAchievementsManagerResultDuplicateHandle(XblAchievementsManagerResultHandle handle, out XblAchievementsManagerResultHandle duplicatedHandle)
			{
				duplicatedHandle = null;
				return 0;
			}

			public static void XblAchievementsManagerResultCloseHandle(XblAchievementsManagerResultHandle handle)
			{
			}

			public static int XblAchievementsManagerAddLocalUser(XUserHandle user)
			{
				return 0;
			}

			public static int XblAchievementsManagerRemoveLocalUser(XUserHandle user)
			{
				return 0;
			}

			public static int XblAchievementsManagerIsUserInitialized(ulong xboxUserId)
			{
				return 0;
			}

			public static int XblAchievementsManagerDoWork(out XblAchievementsManagerEvent[] events)
			{
				events = null;
				return 0;
			}

			public static int XblAchievementsManagerGetAchievement(ulong xboxUserId, string achievementId, out XblAchievementsManagerResultHandle handle)
			{
				handle = null;
				return 0;
			}

			public static int XblAchievementsManagerGetAchievements(ulong xboxUserId, XblAchievementOrderBy sortField, XblAchievementsManagerSortOrder sortOrder, out XblAchievementsManagerResultHandle handle)
			{
				handle = null;
				return 0;
			}

			public static int XblAchievementsManagerGetAchievementsByState(ulong xboxUserId, XblAchievementOrderBy sortField, XblAchievementsManagerSortOrder sortOrder, XblAchievementProgressState achievementState, out XblAchievementsManagerResultHandle handle)
			{
				handle = null;
				return 0;
			}

			public static int XblAchievementsManagerUpdateAchievement(ulong xboxUserId, string achievementId, byte currentProgress)
			{
				return 0;
			}

			public static XblErrorCondition XblGetErrorCondition(int hr)
			{
				return default(XblErrorCondition);
			}

			public static XblHresult XblGetHRESULT(int hr)
			{
				return default(XblHresult);
			}

			public static int XblEventsWriteInGameEvent(XblContextHandle xboxLiveContext, string eventName, string dimensionsJson, string measurementsJson)
			{
				return 0;
			}

			public static int HCSettingsSetTraceLevel(HCTraceLevel traceLevel)
			{
				return 0;
			}

			public static int HCSettingsGetTraceLevel(out HCTraceLevel traceLevel)
			{
				traceLevel = default(HCTraceLevel);
				return 0;
			}

			public static void HCTraceSetTraceToDebugger(bool traceToDebugger)
			{
			}

			public static int XblHttpCallRequestSetRequestBodyBytes(XblHttpCallHandle call, byte[] requestBodyBytes)
			{
				return 0;
			}

			public static int XblHttpCallGetNetworkErrorCode(XblHttpCallHandle call, out int networkErrorCode, out uint platformNetworkErrorCode)
			{
				networkErrorCode = default(int);
				platformNetworkErrorCode = default(uint);
				return 0;
			}

			public static int XblHttpCallRequestSetLongHttpCall(XblHttpCallHandle call, bool longHttpCall)
			{
				return 0;
			}

			public static void XblHttpCallPerformAsync(XblHttpCallHandle call, XblHttpCallResponseBodyType type, XblHttpCallPerformCompleted completionRoutine)
			{
			}

			public static int XblHttpCallSetTracing(XblHttpCallHandle call, bool traceCall)
			{
				return 0;
			}

			public static int XblHttpCallCreate(XblContextHandle xblContext, string method, string url, out XblHttpCallHandle call)
			{
				call = null;
				return 0;
			}

			public static void XblHttpCallCloseHandle(XblHttpCallHandle call)
			{
			}

			public static int XblHttpCallRequestSetRequestBodyString(XblHttpCallHandle call, string requestBodyString)
			{
				return 0;
			}

			public static int XblHttpCallGetResponseString(XblHttpCallHandle call, out string responseString)
			{
				responseString = null;
				return 0;
			}

			public static int XblHttpCallGetHeaderAtIndex(XblHttpCallHandle call, uint headerIndex, out string headerName, out string headerValue)
			{
				headerName = null;
				headerValue = null;
				return 0;
			}

			public static int XblHttpCallGetPlatformNetworkErrorMessage(XblHttpCallHandle call, out string platformNetworkErrorMessage)
			{
				platformNetworkErrorMessage = null;
				return 0;
			}

			public static int XblHttpCallGetResponseBodyBytes(XblHttpCallHandle call, out byte[] buffer)
			{
				buffer = null;
				return 0;
			}

			public static int XblHttpCallRequestSetRetryAllowed(XblHttpCallHandle call, bool retryAllowed)
			{
				return 0;
			}

			public static int XblHttpCallRequestSetHeader(XblHttpCallHandle call, string headerName, string headerValue, bool allowTracing)
			{
				return 0;
			}

			public static int XblHttpCallDuplicateHandle(XblHttpCallHandle call, out XblHttpCallHandle duplicateHandle)
			{
				duplicateHandle = null;
				return 0;
			}

			public static int XblHttpCallGetNumHeaders(XblHttpCallHandle call, out uint numHeaders)
			{
				numHeaders = default(uint);
				return 0;
			}

			public static int XblHttpCallGetStatusCode(XblHttpCallHandle call, out uint statusCode)
			{
				statusCode = default(uint);
				return 0;
			}

			public static int XblHttpCallGetHeader(XblHttpCallHandle call, string headerName, out string headerValue)
			{
				headerValue = null;
				return 0;
			}

			public static int XblHttpCallGetRequestUrl(XblHttpCallHandle call, out string url)
			{
				url = null;
				return 0;
			}

			public static int XblHttpCallRequestSetRetryCacheId(XblHttpCallHandle call, uint retryAfterCacheId)
			{
				return 0;
			}

			public static void XblLeaderboardGetLeaderboardAsync(XblContextHandle xboxLiveContext, XblLeaderboardQuery leaderboardQuery, XblLeaderboardGetLeaderboardCompleted completionRoutine)
			{
			}

			public static void XblLeaderboardResultGetNextAsync(XblContextHandle xboxLiveContext, XblLeaderboardResult leaderboardResult, uint maxItems, XblLeaderboardGetNextCompleted completionRoutine)
			{
			}

			public static void XblMatchmakingCreateMatchTicketAsync(XblContextHandle xboxLiveContext, XblMultiplayerSessionReference ticketSessionReference, string matchmakingServiceConfigurationId, string hopperName, ulong ticketTimeout, XblPreserveSessionMode preserveSession, string ticketAttributesJson, XblMatchmakingCreateMatchTicketHandleResult completionRoutine)
			{
			}

			public static void XblMatchmakingDeleteMatchTicketAsync(XblContextHandle xboxLiveContext, string serviceConfigurationId, string hopperName, string ticketId, XblMatchmakingDeleteMatchTicketHandleResult completionRoutine)
			{
			}

			public static void XblMatchmakingGetMatchTicketDetailsAsync(XblContextHandle xboxLiveContext, string serviceConfigurationId, string hopperName, string ticketId, XblMatchmakingGetMatchTicketDetailsHandleResult completionRoutine)
			{
			}

			public static void XblMatchmakingGetHopperStatisticsAsync(XblContextHandle xboxLiveContext, string serviceConfigurationId, string hopperName, XblMatchmakingGetHopperStatisticsHandleResult completionRoutine)
			{
			}

			public static XblMultiplayerSessionHandle XblMultiplayerSessionCreateHandle(ulong xboxUserId, XblMultiplayerSessionReference sessionRef, XblMultiplayerSessionInitArgs initArgs)
			{
				return null;
			}

			public static void XblMultiplayerSessionCloseHandle(XblMultiplayerSessionHandle handle)
			{
			}

			public static DateTime XblMultiplayerSessionTimeOfSession(XblMultiplayerSessionHandle handle)
			{
				return default(DateTime);
			}

			public static XblMultiplayerSessionInitializationInfo XblMultiplayerSessionGetInitializationInfo(XblMultiplayerSessionHandle handle)
			{
				return null;
			}

			public static XblMultiplayerSessionChangeTypes XblMultiplayerSessionSubscribedChangeTypes(XblMultiplayerSessionHandle handle)
			{
				return default(XblMultiplayerSessionChangeTypes);
			}

			public static int XblMultiplayerSessionHostCandidates(XblMultiplayerSessionHandle handle, out XblDeviceToken[] deviceTokens)
			{
				deviceTokens = null;
				return 0;
			}

			public static XblMultiplayerSessionReference XblMultiplayerSessionSessionReference(XblMultiplayerSessionHandle handle)
			{
				return null;
			}

			public static XblMultiplayerSessionConstants XblMultiplayerSessionSessionConstants(XblMultiplayerSessionHandle handle)
			{
				return null;
			}

			public static void XblMultiplayerSessionConstantsSetMaxMembersInSession(XblMultiplayerSessionHandle handle, uint maxMembersInSession)
			{
			}

			public static void XblMultiplayerSessionConstantsSetVisibility(XblMultiplayerSessionHandle handle, XblMultiplayerSessionVisibility visibility)
			{
			}

			public static int XblMultiplayerSessionConstantsSetTimeouts(XblMultiplayerSessionHandle handle, ulong memberReservedTimeout, ulong memberInactiveTimeout, ulong memberReadyTimeout, ulong sessionEmptyTimeout)
			{
				return 0;
			}

			public static int XblMultiplayerSessionConstantsSetQosConnectivityMetrics(XblMultiplayerSessionHandle handle, bool enableLatencyMetric, bool enableBandwidthDownMetric, bool enableBandwidthUpMetric, bool enableCustomMetric)
			{
				return 0;
			}

			public static int XblMultiplayerSessionConstantsSetMemberInitialization(XblMultiplayerSessionHandle handle, XblMultiplayerMemberInitialization memberInitialization)
			{
				return 0;
			}

			public static int XblMultiplayerSessionConstantsSetPeerToPeerRequirements(XblMultiplayerSessionHandle handle, XblMultiplayerPeerToPeerRequirements requirements)
			{
				return 0;
			}

			public static int XblMultiplayerSessionConstantsSetMeasurementServerAddressesJson(XblMultiplayerSessionHandle handle, string measurementServerAddressesJson)
			{
				return 0;
			}

			public static int XblMultiplayerSessionConstantsSetCapabilities(XblMultiplayerSessionHandle handle, XblMultiplayerSessionCapabilities capabilities)
			{
				return 0;
			}

			public static XblMultiplayerSessionProperties XblMultiplayerSessionSessionProperties(XblMultiplayerSessionHandle handle)
			{
				return null;
			}

			public static int XblMultiplayerSessionPropertiesSetKeywords(XblMultiplayerSessionHandle handle, string[] keywords)
			{
				return 0;
			}

			public static void XblMultiplayerSessionPropertiesSetJoinRestriction(XblMultiplayerSessionHandle handle, XblMultiplayerSessionRestriction joinRestriction)
			{
			}

			public static void XblMultiplayerSessionPropertiesSetReadRestriction(XblMultiplayerSessionHandle handle, XblMultiplayerSessionRestriction readRestriction)
			{
			}

			public static int XblMultiplayerSessionPropertiesSetTurnCollection(XblMultiplayerSessionHandle handle, uint[] turnCollectionMemberIds)
			{
				return 0;
			}

			public static int XblMultiplayerSessionMembers(XblMultiplayerSessionHandle handle, out XblMultiplayerSessionMember[] members)
			{
				members = null;
				return 0;
			}

			public static XblMultiplayerMatchmakingServer XblMultiplayerSessionMatchmakingServer(XblMultiplayerSessionHandle handle)
			{
				return null;
			}

			public static XblMultiplayerSessionMember XblMultiplayerSessionCurrentUser(XblMultiplayerSessionHandle handle)
			{
				return null;
			}

			public static int XblMultiplayerSessionCurrentUserSetRoles(XblMultiplayerSessionHandle handle, XblMultiplayerSessionMemberRole[] roles)
			{
				return 0;
			}

			public static int XblMultiplayerSessionCurrentUserSetEncounters(XblMultiplayerSessionHandle handle, string[] encounters)
			{
				return 0;
			}

			public static int XblMultiplayerSessionCurrentUserSetMembersInGroup(XblMultiplayerSessionHandle handle, uint[] memberIds)
			{
				return 0;
			}

			public static int XblMultiplayerSessionCurrentUserSetGroups(XblMultiplayerSessionHandle handle, string[] groups)
			{
				return 0;
			}

			public static int XblMultiplayerSessionCurrentUserSetCustomPropertyJson(XblMultiplayerSessionHandle handle, string name, string valueJson)
			{
				return 0;
			}

			public static int XblMultiplayerSessionCurrentUserDeleteCustomPropertyJson(XblMultiplayerSessionHandle handle, string name)
			{
				return 0;
			}

			public static XblWriteSessionStatus XblMultiplayerSessionWriteStatus(XblMultiplayerSessionHandle handle)
			{
				return default(XblWriteSessionStatus);
			}

			public static int XblMultiplayerSessionJoin(XblMultiplayerSessionHandle handle, string memberCustomConstantsJson, bool initializeRequested, bool joinWithActiveStatus)
			{
				return 0;
			}

			public static void XblMultiplayerSessionSetHostDeviceToken(XblMultiplayerSessionHandle handle, XblDeviceToken hostDeviceToken)
			{
			}

			public static void XblMultiplayerSessionSetClosed(XblMultiplayerSessionHandle handle, bool closed)
			{
			}

			public static int XblMultiplayerSessionSetSessionChangeSubscription(XblMultiplayerSessionHandle handle, XblMultiplayerSessionChangeTypes changeTypes)
			{
				return 0;
			}

			public static int XblMultiplayerSessionLeave(XblMultiplayerSessionHandle handle)
			{
				return 0;
			}

			public static int XblMultiplayerSessionCurrentUserSetStatus(XblMultiplayerSessionHandle handle, XblMultiplayerSessionMemberStatus status)
			{
				return 0;
			}

			public static int XblMultiplayerSessionCurrentUserSetSecureDeviceAddressBase64(XblMultiplayerSessionHandle handle, string value)
			{
				return 0;
			}

			public static int XblFormatSecureDeviceAddress(string deviceId, out string address)
			{
				address = null;
				return 0;
			}

			public static void XblMultiplayerSearchHandleCloseHandle(XblMultiplayerSearchHandle handle)
			{
			}

			public static int XblMultiplayerSearchHandleGetSessionReference(XblMultiplayerSearchHandle handle, out XblMultiplayerSessionReference sessionRef)
			{
				sessionRef = null;
				return 0;
			}

			public static int XblMultiplayerSearchHandleGetId(XblMultiplayerSearchHandle handle, out string id)
			{
				id = null;
				return 0;
			}

			public static int XblMultiplayerSearchHandleGetSessionOwnerXuids(XblMultiplayerSearchHandle handle, out ulong[] xuids)
			{
				xuids = null;
				return 0;
			}

			public static int XblMultiplayerSearchHandleGetTags(XblMultiplayerSearchHandle handle, out XblMultiplayerSessionTag[] tags)
			{
				tags = null;
				return 0;
			}

			public static int XblMultiplayerSearchHandleGetStringAttributes(XblMultiplayerSearchHandle handle, out XblMultiplayerSessionStringAttribute[] attributes)
			{
				attributes = null;
				return 0;
			}

			public static int XblMultiplayerSearchHandleGetNumberAttributes(XblMultiplayerSearchHandle handle, out XblMultiplayerSessionNumberAttribute[] attributes)
			{
				attributes = null;
				return 0;
			}

			public static int XblMultiplayerSearchHandleGetVisibility(XblMultiplayerSearchHandle handle, out XblMultiplayerSessionVisibility visibility)
			{
				visibility = default(XblMultiplayerSessionVisibility);
				return 0;
			}

			public static int XblMultiplayerSearchHandleGetJoinRestriction(XblMultiplayerSearchHandle handle, out XblMultiplayerSessionRestriction joinRestriction)
			{
				joinRestriction = default(XblMultiplayerSessionRestriction);
				return 0;
			}

			public static int XblMultiplayerSearchHandleGetSessionClosed(XblMultiplayerSearchHandle handle, out bool closed)
			{
				closed = default(bool);
				return 0;
			}

			public static int XblMultiplayerSearchHandleGetMemberCounts(XblMultiplayerSearchHandle handle, out uint maxMembers, out uint currentMembers)
			{
				maxMembers = default(uint);
				currentMembers = default(uint);
				return 0;
			}

			public static int XblMultiplayerSearchHandleGetCreationTime(XblMultiplayerSearchHandle handle, out DateTime creationTime)
			{
				creationTime = default(DateTime);
				return 0;
			}

			public static int XblMultiplayerSearchHandleGetCustomSessionPropertiesJson(XblMultiplayerSearchHandle handle, out string customPropertiesJson)
			{
				customPropertiesJson = null;
				return 0;
			}

			public static void XblMultiplayerWriteSessionAsync(XblContextHandle xblContext, XblMultiplayerSessionHandle handle, XblMultiplayerSessionWriteMode writeMode, XblMultiplayerWriteSessionHandleResult completionRoutine)
			{
			}

			public static void XblMultiplayerWriteSessionByHandleAsync(XblContextHandle xblContext, XblMultiplayerSessionHandle handle, XblMultiplayerSessionWriteMode writeMode, string handleId, XblMultiplayerWriteSessionHandleResult completionRoutine)
			{
			}

			public static void XblMultiplayerGetSessionAsync(XblContextHandle xblContext, XblMultiplayerSessionReference sessionRef, XblMultiplayerGetSessionHandleResult completionRoutine)
			{
			}

			public static void XblMultiplayerGetSessionByHandleAsync(XblContextHandle xblContext, string handleId, XblMultiplayerGetSessionHandleResult completionRoutine)
			{
			}

			public static void XblMultiplayerQuerySessionsAsync(XblContextHandle xblContext, XblMultiplayerSessionQuery sessionQuery, XblMultiplayerSessionQueryHandleResult completionRoutine)
			{
			}

			public static void XblMultiplayerSetActivityAsync(XblContextHandle xblContext, XblMultiplayerSessionReference sessionReference, XblMultiplayerSetActivityHandleResult completionRoutine)
			{
			}

			public static void XblMultiplayerClearActivityAsync(XblContextHandle xblContext, string scid, XblMultiplayerClearActivityHandleResult completionRoutine)
			{
			}

			public static void XblMultiplayerSetTransferHandleAsync(XblContextHandle xblContext, XblMultiplayerSessionReference targetSessionReference, XblMultiplayerSessionReference originSessionReference, XblMultiplayerSetTransferHandleResult completionRoutine)
			{
			}

			public static void XblMultiplayerCreateSearchHandleAsync(XblContextHandle xblContext, XblMultiplayerSessionReference sessionRef, XblMultiplayerSessionTag[] tags, XblMultiplayerSessionNumberAttribute[] numberAttributes, XblMultiplayerSessionStringAttribute[] stringAttributes, XblMultiplayerCreateSearchHandleResult completionRoutine)
			{
			}

			public static void XblMultiplayerDeleteSearchHandleAsync(XblContextHandle xblContext, string handleId, XblMultiplayerDeleteSearchHandleResult completionRoutine)
			{
			}

			public static void XblMultiplayerGetSearchHandlesAsync(XblContextHandle xboxLiveContext, string scid, string sessionTemplateName, string orderByAttribute, bool orderAscending, string searchFilter, string socialGroup, XblMultiplayerGetSearchHandlesResult completionRoutine)
			{
			}

			public static void XblMultiplayerSendInvitesAsync(XblContextHandle xboxLiveContext, XblMultiplayerSessionReference sessionRef, ulong[] xboxUserIdList, uint titleId, string contextStringId, string customActivationContext, XblMultiplayerSendInvitesResult completionRoutine)
			{
			}

			public static void XblMultiplayerGetActivitiesForSocialGroupAsync(XblContextHandle xboxLiveContext, string scid, ulong socialGroupOwnerXuid, string socialGroup, XblMultiplayerGetActivitiesResult completionRoutine)
			{
			}

			public static void XblMultiplayerGetActivitiesWithPropertiesForSocialGroupAsync(XblContextHandle xboxLiveContext, string scid, ulong socialGroupOwnerXuid, string socialGroup, XblMultiplayerGetActivitiesResult completionRoutine)
			{
			}

			public static void XblMultiplayerGetActivitiesForUsersAsync(XblContextHandle xboxLiveContext, string scid, ulong[] xuids, XblMultiplayerGetActivitiesResult completionRoutine)
			{
			}

			public static void XblMultiplayerGetActivitiesWithPropertiesForUsersAsync(XblContextHandle xboxLiveContext, string scid, ulong[] xuids, XblMultiplayerGetActivitiesResult completionRoutine)
			{
			}

			public static int XblMultiplayerSetSubscriptionsEnabled(XblContextHandle xblContext, bool subscriptionsEnabled)
			{
				return 0;
			}

			public static bool XblMultiplayerSubscriptionsEnabled(XblContextHandle xblHandle)
			{
				return false;
			}

			public static int XblMultiplayerSessionSetCustomPropertyJson(XblMultiplayerSessionHandle handle, string name, string valueJson)
			{
				return 0;
			}

			public static int XblMultiplayerSessionDeleteCustomPropertyJson(XblMultiplayerSessionHandle handle, string name)
			{
				return 0;
			}

			public static XblMultiplayerSessionChangeTypes XblMultiplayerSessionCompare(XblMultiplayerSessionHandle currentSessionHandle, XblMultiplayerSessionHandle oldSessionHandle)
			{
				return default(XblMultiplayerSessionChangeTypes);
			}

			public static int XblMultiplayerActivityUpdateRecentPlayers(XblContextHandle xboxLiveContext, XblMultiplayerActivityRecentPlayerUpdate[] updates)
			{
				return 0;
			}

			public static void XblMultiplayerActivityFlushRecentPlayersAsync(XblContextHandle xboxLiveContext, XblMultiplayerActivityAsyncOperationCompleted completionRoutine)
			{
			}

			public static void XblMultiplayerActivitySetActivityAsync(XblContextHandle xboxLiveContext, XblMultiplayerActivityInfo activityInfo, bool allowCrossPlatformJoin, XblMultiplayerActivityAsyncOperationCompleted completionRoutine)
			{
			}

			public static void XblMultiplayerActivityGetActivityAsync(XblContextHandle xboxLiveContext, ulong[] xboxUserIdList, XblMultiplayerGetActivityAsyncOperationCompleted completionRoutine)
			{
			}

			public static void XblMultiplayerActivityDeleteActivityAsync(XblContextHandle xboxLiveContext, XblMultiplayerActivityAsyncOperationCompleted completionRoutine)
			{
			}

			public static void XblMultiplayerActivitySendInvitesAsync(XblContextHandle xboxLiveContext, ulong[] xboxUserIdList, bool allowCrossPlatformJoin, string connectionString, XblMultiplayerActivityAsyncOperationCompleted completionRoutine)
			{
			}

			public static int XblMultiplayerManagerInitialize(string lobbySessionTemplateName)
			{
				return 0;
			}

			public static int XblMultiplayerManagerDoWork(out XblMultiplayerEvent[] events)
			{
				events = null;
				return 0;
			}

			public static XblMultiplayerSessionReference XblMultiplayerSessionReferenceCreate(string scid, string sessionTemplateName, string sessionName)
			{
				return null;
			}

			public static int XblMultiplayerManagerJoinLobby(string handleId, XUserHandle user)
			{
				return 0;
			}

			public static int XblMultiplayerManagerSetQosMeasurements(string measurementsJson)
			{
				return 0;
			}

			public static int XblMultiplayerManagerSetJoinability(XblMultiplayerJoinability joinability, object context)
			{
				return 0;
			}

			public static int XblMultiplayerManagerJoinGameFromLobby(string sessionTemplateName)
			{
				return 0;
			}

			public static void XblMultiplayerManagerSetAutoFillMembersDuringMatchmaking(bool autoFillMembers)
			{
			}

			public static XblMultiplayerJoinability XblMultiplayerManagerJoinability()
			{
				return default(XblMultiplayerJoinability);
			}

			public static void XblMultiplayerManagerCancelMatch()
			{
			}

			public static uint XblMultiplayerManagerEstimatedMatchWaitTime()
			{
				return 0u;
			}

			public static bool XblMultiplayerManagerMemberAreMembersOnSameDevice(XblMultiplayerManagerMember first, XblMultiplayerManagerMember second)
			{
				return false;
			}

			public static int XblMultiplayerSessionReferenceParseFromUriPath(string path, out XblMultiplayerSessionReference sessionReference)
			{
				sessionReference = null;
				return 0;
			}

			public static int XblMultiplayerSessionReferenceToUriPath(XblMultiplayerSessionReference sessionReference, out XblMultiplayerSessionReferenceUri sessionReferenceUri)
			{
				sessionReferenceUri = null;
				return 0;
			}

			public static int XblMultiplayerManagerLeaveGame()
			{
				return 0;
			}

			public static XblMultiplayerMatchStatus XblMultiplayerManagerMatchStatus()
			{
				return default(XblMultiplayerMatchStatus);
			}

			public static bool XblMultiplayerManagerAutoFillMembersDuringMatchmaking()
			{
				return false;
			}

			public static int XblMultiplayerManagerFindMatch(string hopperName, string attributesJson, uint timeoutInSeconds)
			{
				return 0;
			}

			public static bool XblMultiplayerSessionReferenceIsValid(XblMultiplayerSessionReference sessionReference)
			{
				return false;
			}

			public static int XblMultiplayerManagerJoinGame(string sessionName, string sessionTemplateName, ulong[] xuids)
			{
				return 0;
			}

			public static int XblMultiplayerEventArgsTournamentRegistrationStateChanged(XblMultiplayerEventArgsHandle argsHandle, out XblTournamentRegistrationState registrationState, out XblTournamentRegistrationReason registrationReason)
			{
				registrationState = default(XblTournamentRegistrationState);
				registrationReason = default(XblTournamentRegistrationReason);
				return 0;
			}

			public static int XblMultiplayerEventArgsFindMatchCompleted(XblMultiplayerEventArgsHandle argsHandle, out XblMultiplayerMatchStatus matchStatus, out XblMultiplayerMeasurementFailure initializationFailureCause)
			{
				matchStatus = default(XblMultiplayerMatchStatus);
				initializationFailureCause = default(XblMultiplayerMeasurementFailure);
				return 0;
			}

			public static int XblMultiplayerEventArgsPropertiesJson(XblMultiplayerEventArgsHandle argsHandle, out string properties)
			{
				properties = null;
				return 0;
			}

			public static int XblMultiplayerEventArgsXuid(XblMultiplayerEventArgsHandle argsHandle, out ulong xuid)
			{
				xuid = default(ulong);
				return 0;
			}

			public static int XblMultiplayerEventArgsTournamentGameSessionReady(XblMultiplayerEventArgsHandle argsHandle, out DateTime startTime)
			{
				startTime = default(DateTime);
				return 0;
			}

			public static int XblMultiplayerEventArgsMember(XblMultiplayerEventArgsHandle argsHandle, out XblMultiplayerManagerMember member)
			{
				member = null;
				return 0;
			}

			public static int XblMultiplayerEventArgsMembers(XblMultiplayerEventArgsHandle argsHandle, out XblMultiplayerManagerMember[] members)
			{
				members = null;
				return 0;
			}

			public static int XblMultiplayerEventArgsPerformQoSMeasurements(XblMultiplayerEventArgsHandle argsHandle, out XblMultiplayerPerformQoSMeasurementsArgs performQoSMeasurementsArgs)
			{
				performQoSMeasurementsArgs = null;
				return 0;
			}

			private static int SessionSetInternalWithMarshalledContext(Func<IntPtr, int> setterFunction, object context)
			{
				return 0;
			}

			public static bool XblMultiplayerManagerGameSessionIsHost(ulong xuid)
			{
				return false;
			}

			public static int XblMultiplayerManagerGameSessionHost(out XblMultiplayerManagerMember hostMember)
			{
				hostMember = null;
				return 0;
			}

			public static int XblMultiplayerManagerLobbySessionSessionReference(out XblMultiplayerSessionReference sessionReference)
			{
				sessionReference = null;
				return 0;
			}

			public static XblMultiplayerSessionReference XblMultiplayerManagerGameSessionSessionReference()
			{
				return null;
			}

			public static bool XblMultiplayerManagerGameSessionActive()
			{
				return false;
			}

			public static int XblMultiplayerManagerGameSessionSetProperties(string name, string valueJson, object context)
			{
				return 0;
			}

			public static int XblMultiplayerManagerGameSessionSetSynchronizedHost(string deviceToken, object context)
			{
				return 0;
			}

			public static int XblMultiplayerManagerGameSessionSetSynchronizedProperties(string name, string valueJson, object context)
			{
				return 0;
			}

			public static string XblMultiplayerManagerGameSessionCorrelationId()
			{
				return null;
			}

			public static XblMultiplayerSessionConstants XblMultiplayerManagerGameSessionConstants()
			{
				return null;
			}

			public static int XblMultiplayerManagerGameSessionMembers(out XblMultiplayerManagerMember[] members)
			{
				members = null;
				return 0;
			}

			public static string XblMultiplayerManagerGameSessionPropertiesJson()
			{
				return null;
			}

			public static int XblMultiplayerManagerLobbySessionHost(out XblMultiplayerManagerMember hostMember)
			{
				hostMember = null;
				return 0;
			}

			public static int XblMultiplayerManagerLobbySessionInviteUsers(XUserHandle user, ulong[] xuids, string contextStringId, string customActivationContext)
			{
				return 0;
			}

			public static int XblMultiplayerManagerLobbySessionInviteFriends(XUserHandle requestingUser, string contextStringId, string customActivationContext)
			{
				return 0;
			}

			public static int XblMultiplayerManagerLobbySessionAddLocalUser(XUserHandle user)
			{
				return 0;
			}

			public static int XblMultiplayerManagerLobbySessionMembers(out XblMultiplayerManagerMember[] members)
			{
				members = null;
				return 0;
			}

			public static string XblMultiplayerManagerLobbySessionPropertiesJson()
			{
				return null;
			}

			public static XblMultiplayerSessionConstants XblMultiplayerManagerLobbySessionConstants()
			{
				return null;
			}

			public static int XblMultiplayerManagerLobbySessionLocalMembers(out XblMultiplayerManagerMember[] localMembers)
			{
				localMembers = null;
				return 0;
			}

			public static int XblMultiplayerManagerLobbySessionRemoveLocalUser(XUserHandle user)
			{
				return 0;
			}

			public static XblTournamentTeamResult XblMultiplayerManagerLobbySessionLastTournamentTeamResult()
			{
				return null;
			}

			public static bool XblMultiplayerManagerLobbySessionIsHost(ulong xuid)
			{
				return false;
			}

			public static int XblMultiplayerManagerLobbySessionCorrelationId(out XblGuid correlationId)
			{
				correlationId = null;
				return 0;
			}

			public static int XblMultiplayerManagerLobbySessionSetSynchronizedHost(string deviceToken, object context)
			{
				return 0;
			}

			public static int XblMultiplayerManagerLobbySessionSetProperties(string name, string valueJson, object context)
			{
				return 0;
			}

			public static int XblMultiplayerManagerLobbySessionSetLocalMemberProperties(XUserHandle user, string name, string valueJson, object context)
			{
				return 0;
			}

			public static int XblMultiplayerManagerLobbySessionSetSynchronizedProperties(string name, string valueJson, object context)
			{
				return 0;
			}

			public static int XblMultiplayerManagerLobbySessionSetLocalMemberConnectionAddress(XUserHandle user, string connectionAddress, object context)
			{
				return 0;
			}

			public static int XblMultiplayerManagerLobbySessionDeleteLocalMemberProperties(XUserHandle user, string name, object context)
			{
				return 0;
			}

			public static int XblPresenceRecordGetXuid(XblPresenceRecordHandle handle, out ulong xuid)
			{
				xuid = default(ulong);
				return 0;
			}

			public static int XblPresenceRecordGetUserState(XblPresenceRecordHandle handle, out XblPresenceUserState userState)
			{
				userState = default(XblPresenceUserState);
				return 0;
			}

			public static int XblPresenceRecordGetDeviceRecords(XblPresenceRecordHandle handle, out XblPresenceDeviceRecord[] deviceRecords)
			{
				deviceRecords = null;
				return 0;
			}

			public static int XblPresenceRecordDuplicateHandle(XblPresenceRecordHandle handle, out XblPresenceRecordHandle duplicatedHandle)
			{
				duplicatedHandle = null;
				return 0;
			}

			public static void XblPresenceRecordCloseHandle(XblPresenceRecordHandle handle)
			{
			}

			public static void XblPresenceSetPresenceAsync(XblContextHandle xblContextHandle, bool isUserActiveInTitle, XblPresenceRichPresenceIds richPresenceIds, XblPresenceSetPresenceCompleted completionRoutine)
			{
			}

			public static void XblPresenceGetPresenceAsync(XblContextHandle xblContextHandle, ulong xuid, XblPresenceGetPresenceCompleted completionRoutine)
			{
			}

			public static void XblPresenceGetPresenceForMultipleUsersAsync(XblContextHandle xblContextHandle, ulong[] xuids, XblPresenceQueryFilters filters, XblPresenceGetPresenceForMultipleUsersCompleted completionRoutine)
			{
			}

			public static void XblPresenceGetPresenceForSocialGroupAsync(XblContextHandle xblContextHandle, string socialGroupName, ulong? socialGroupOwnerXuid, XblPresenceQueryFilters filters, XblPresenceGetPresenceForSocialGroupCompleted completionRoutine)
			{
			}

			public static void XblPrivacyGetAvoidListAsync(XblContextHandle xblContextHandle, XblPrivacyGetAvoidListCompleted completionRoutine)
			{
			}

			public static void XblPrivacyGetMuteListAsync(XblContextHandle xblContextHandle, XblPrivacyGetMuteListCompleted completionRoutine)
			{
			}

			public static void XblPrivacyCheckPermissionAsync(XblContextHandle xblContextHandle, XblPermission permissionToCheck, ulong targetXuid, XblPrivacyCheckPermissionCompleted completionRoutine)
			{
			}

			public static void XblPrivacyCheckPermissionForAnonymousUserAsync(XblContextHandle xblContextHandle, XblPermission permissionToCheck, XblAnonymousUserType userType, XblPrivacyCheckPermissionCompleted completionRoutine)
			{
			}

			public static void XblPrivacyBatchCheckPermissionAsync(XblContextHandle xblContextHandle, XblPermission[] permissionsToCheck, ulong[] targetXuids, XblAnonymousUserType[] targetAnonymousUserTypes, XblPrivacyBatchCheckPermissionCompleted completionRoutine)
			{
			}

			public static void XblProfileGetUserProfileAsync(XblContextHandle xblContextHandle, ulong xboxUserId, XblProfileGetUserProfileCompleted completionRoutine)
			{
			}

			public static void XblProfileGetUserProfilesAsync(XblContextHandle xblContextHandle, ulong[] xboxUserIds, XblProfileGetUserProfilesCompleted completionRoutine)
			{
			}

			public static void XblProfileGetUserProfilesForSocialGroupAsync(XblContextHandle xblContextHandle, string socialGroup, XblProfileGetUserProfilesForSocialGroupCompleted completionRoutine)
			{
			}

			public static XblRealTimeActivityCallbackToken XblRealTimeActivityAddConnectionStateChangeHandler(XblContextHandle xboxLiveContext, XblConnectionStateChangeCallback callback)
			{
				return default(XblRealTimeActivityCallbackToken);
			}

			public static int XblRealTimeActivityRemoveConnectionStateChangeHandler(XblContextHandle xboxLiveContext, ref XblRealTimeActivityCallbackToken connectionStateChangeCallbackToken)
			{
				return 0;
			}

			public static XblRealTimeActivityCallbackToken XblRealTimeActivityAddResyncHandler(XblContextHandle xboxLiveContext, XblConnectionResyncCallback callback)
			{
				return default(XblRealTimeActivityCallbackToken);
			}

			public static int XblRealTimeActivityRemoveResyncHandler(XblContextHandle xboxLiveContext, ref XblRealTimeActivityCallbackToken connectionResyncCallbackToken)
			{
				return 0;
			}

			public static void XblSocialGetSocialRelationshipsAsync(XblContextHandle xboxLiveContext, ulong xboxUserId, XblSocialRelationshipFilter socialRelationshipFilter, uint startIndex, uint maxItems, XblSocialGetSocialRelationshipsResult completionRoutine)
			{
			}

			public static int XblSocialRelationshipResultGetRelationships(XblSocialRelationshipResult resultHandle, out XblSocialRelationship[] relationships)
			{
				relationships = null;
				return 0;
			}

			public static int XblSocialRelationshipResultHasNext(XblSocialRelationshipResult result, out bool hasNext)
			{
				hasNext = default(bool);
				return 0;
			}

			public static int XblSocialRelationshipResultGetTotalCount(XblSocialRelationshipResult result, out uint totalCount)
			{
				totalCount = default(uint);
				return 0;
			}

			public static void XblSocialRelationshipResultGetNextAsync(XblContextHandle xboxLiveContext, XblSocialRelationshipResult result, uint maxItems, XblSocialRelationshipResultGetNextResult completionRoutine)
			{
			}

			public static int XblSocialRelationshipResultDuplicateHandle(XblSocialRelationshipResult handle, out XblSocialRelationshipResult duplicatedHandle)
			{
				duplicatedHandle = null;
				return 0;
			}

			public static void XblSocialRelationshipResultCloseHandle(XblSocialRelationshipResult handle)
			{
			}

			public static int XblSocialAddSocialRelationshipChangedHandler(XblContextHandle xboxLiveContext, XblSocialRelationshipChangedCallback eventCallback)
			{
				return 0;
			}

			public static int XblSocialRemoveSocialRelationshipChangedHandler(XblContextHandle xboxLiveContext, int callbackFunctionId)
			{
				return 0;
			}

			public static bool XblSocialManagerPresenceRecordIsUserPlayingTitle(XblSocialManagerPresenceRecord presenceRecord, uint titleId)
			{
				return false;
			}

			public static int XblSocialManagerUserGroupGetUsers(XblSocialManagerUserGroupHandle group, out XblSocialManagerUser[] xboxSocialUsers)
			{
				xboxSocialUsers = null;
				return 0;
			}

			public static int XblSocialManagerUserGroupGetUsersTrackedByGroup(XblSocialManagerUserGroupHandle group, out ulong[] trackedUsers)
			{
				trackedUsers = null;
				return 0;
			}

			public static int XblSocialManagerAddLocalUser(XUserHandle user, XblSocialManagerExtraDetailLevel extraLevelDetail)
			{
				return 0;
			}

			public static int XblSocialManagerRemoveLocalUser(XUserHandle user, XblSocialManagerExtraDetailLevel extraLevelDetail)
			{
				return 0;
			}

			public static int XblSocialManagerDoWork(out XblSocialManagerEvent[] socialEvents)
			{
				socialEvents = null;
				return 0;
			}

			public static int XblSocialManagerCreateSocialUserGroupFromFilters(XUserHandle user, XblPresenceFilter presenceDetailLevel, XblRelationshipFilter filter, out XblSocialManagerUserGroupHandle group)
			{
				group = null;
				return 0;
			}

			public static int XblSocialManagerCreateSocialUserGroupFromList(XUserHandle user, ulong[] xboxUserIdList, out XblSocialManagerUserGroupHandle group)
			{
				group = null;
				return 0;
			}

			public static int XblSocialManagerDestroySocialUserGroup(XblSocialManagerUserGroupHandle group)
			{
				return 0;
			}

			public static int XblSocialManagerGetLocalUsers(out XUserHandle[] users)
			{
				users = null;
				return 0;
			}

			public static int XblSocialManagerUpdateSocialUserGroup(XblSocialManagerUserGroupHandle group, ulong[] users)
			{
				return 0;
			}

			public static int XblSocialManagerSetRichPresencePollingStatus(XUserHandle user, bool shouldEnablePolling)
			{
				return 0;
			}

			public static int XblSocialManagerUserGroupGetType(XblSocialManagerUserGroupHandle group, out XblSocialUserGroupType type)
			{
				type = default(XblSocialUserGroupType);
				return 0;
			}

			public static int XblSocialManagerUserGroupGetLocalUser(XblSocialManagerUserGroupHandle group, out XUserHandle localUser)
			{
				localUser = null;
				return 0;
			}

			public static int XblSocialManagerUserGroupGetFilters(XblSocialManagerUserGroupHandle group, out XblPresenceFilter presenceFilter, out XblRelationshipFilter relationshipFilter)
			{
				presenceFilter = default(XblPresenceFilter);
				relationshipFilter = default(XblRelationshipFilter);
				return 0;
			}

			public static void XblStringVerifyStringAsync(XblContextHandle xblContextHandle, string stringToVerify, XblStringVerifyStringCompleted completionRoutine)
			{
			}

			public static void XblStringVerifyStringsAsync(XblContextHandle xblContextHandle, string[] stringsToVerify, XblStringVerifyStringsCompleted completionRoutine)
			{
			}

			public static void XblTitleManagedStatsWriteAsync(XblContextHandle xblContextHandle, ulong xboxUserId, XblTitleManagedStatistic[] statistics, XblTitleManagedStatsOperationCompleted completionRoutine)
			{
			}

			public static void XblTitleManagedStatsUpdateStatsAsync(XblContextHandle xblContextHandle, XblTitleManagedStatistic[] statistics, XblTitleManagedStatsOperationCompleted completionRoutine)
			{
			}

			public static void XblTitleManagedStatsDeleteStatsAsync(XblContextHandle xblContextHandle, string[] statisticNames, XblTitleManagedStatsOperationCompleted completionRoutine)
			{
			}

			public static int XblTitleStorageBlobMetadataResultGetItems(XblTitleStorageBlobMetadataResultHandle resultHandle, out XblTitleStorageBlobMetadata[] items)
			{
				items = null;
				return 0;
			}

			public static int XblTitleStorageBlobMetadataResultHasNext(XblTitleStorageBlobMetadataResultHandle result, out bool hasNext)
			{
				hasNext = default(bool);
				return 0;
			}

			public static void XblTitleStorageBlobMetadataResultGetNextAsync(XblTitleStorageBlobMetadataResultHandle result, uint maxItems, XblTitleStorageBlobMetadataResultGetNextCompleted completionRoutine)
			{
			}

			public static int XblTitleStorageBlobMetadataResultDuplicateHandle(XblTitleStorageBlobMetadataResultHandle handle, out XblTitleStorageBlobMetadataResultHandle duplicatedHandle)
			{
				duplicatedHandle = null;
				return 0;
			}

			public static void XblTitleStorageBlobMetadataResultCloseHandle(XblTitleStorageBlobMetadataResultHandle handle)
			{
			}

			public static void XblTitleStorageGetQuotaAsync(XblContextHandle xboxLiveContext, string serviceConfigurationId, XblTitleStorageType storageType, XblTitleStorageGetQuotaCompleted completionRoutine)
			{
			}

			public static void XblTitleStorageGetBlobMetadataAsync(XblContextHandle xboxLiveContext, string serviceConfigurationId, XblTitleStorageType storageType, string blobPath, ulong xboxUserId, uint skipItems, uint maxItems, XblTitleStorageGetBlobMetadataCompleted completionRoutine)
			{
			}

			public static void XblTitleStorageDeleteBlobAsync(XblContextHandle xboxLiveContext, XblTitleStorageBlobMetadata blobMetadata, bool deleteOnlyIfEtagMatches, XblTitleStorageDeleteBlobCompleted completionRoutine)
			{
			}

			public static void XblTitleStorageDownloadBlobAsync(XblContextHandle xboxLiveContext, XblTitleStorageBlobMetadata blobMetadata, XblTitleStorageETagMatchCondition etagMatchCondition, string selectQuery, ulong preferredDownloadBlockSize, XblTitleStorageDownloadBlobCompleted completionRoutine)
			{
			}

			public static void XblTitleStorageUploadBlobAsync(XblContextHandle xboxLiveContext, XblTitleStorageBlobMetadata blobMetadata, byte[] blobBuffer, XblTitleStorageETagMatchCondition etagMatchCondition, ulong preferredDownloadBlockSize, XblTitleStorageUploadBlobCompleted completionRoutine)
			{
			}

			public static void XblUserStatisticsGetSingleUserStatisticAsync(XblContextHandle xblContextHandle, ulong xboxUserId, string serviceConfigurationId, string statisticName, XblUserStatisticsGetSingleUserStatisticCompleted completionRoutine)
			{
			}

			public static void XblUserStatisticsGetSingleUserStatisticsAsync(XblContextHandle xblContextHandle, ulong xboxUserId, string serviceConfigurationId, string[] statisticNames, XblUserStatisticsGetSingleUserStatisticsCompleted completionRoutine)
			{
			}

			public static void XblUserStatisticsGetMultipleUserStatisticsAsync(XblContextHandle xblContextHandle, ulong[] xboxUserIds, string serviceConfigurationId, string[] statisticNames, XblUserStatisticsGetMultipleUserStatisticsCompleted completionRoutine)
			{
			}

			public static void XblUserStatisticsGetMultipleUserStatisticsForMultipleServiceConfigurationsAsync(XblContextHandle xblContextHandle, ulong[] xboxUserIds, XblRequestedStatistics[] requestedServiceConfigurationStatisticsCollection, XblUserStatisticsGetMultipleUserStatisticsForMultipleServiceConfigurationsCompleted completionRoutine)
			{
			}

			public static int XblUserStatisticsAddStatisticChangedHandler(XblContextHandle xblContextHandle, XblStatisticChangedCallback eventCallback)
			{
				return 0;
			}

			public static void XblUserStatisticsRemoveStatisticChangedHandler(XblContextHandle xblContextHandle, int callbackFunctionId)
			{
			}

			public static void XblUserStatisticsTrackStatistics(XblContextHandle xblContextHandle, ulong[] xuids, string serviceConfigurationId, string[] statisticNames)
			{
			}

			public static void XblUserStatisticsStopTrackingStatistics(XblContextHandle xblContextHandle, ulong[] xuids, string serviceConfigurationId, string[] statisticNames)
			{
			}

			public static void XblUserStatisticsStopTrackingUsers(XblContextHandle xblContextHandle, ulong[] xuids)
			{
			}

			public static int XblInitialize(string scid)
			{
				return 0;
			}

			public static void XblCleanup(XblCleanupResult completionRoutine)
			{
			}

			public static int XblContextCreateHandle(XUserHandle user, out XblContextHandle context)
			{
				context = null;
				return 0;
			}

			public static void XblContextCloseHandle(XblContextHandle xboxLiveContextHandle)
			{
			}

			public static int XblContextDuplicateHandle(XblContextHandle srcXboxLiveContextHandle, out XblContextHandle dstXboxLiveContextHandle)
			{
				dstXboxLiveContextHandle = null;
				return 0;
			}

			public static int XblContextGetUser(XblContextHandle xboxLiveContextHandle, out XUserHandle dstUserHandle)
			{
				dstUserHandle = null;
				return 0;
			}

			public static int XblContextGetXboxUserId(XblContextHandle xboxLiveContextHandle, ref ulong dstXboxUserId)
			{
				return 0;
			}

			public static int XblGetScid(ref string resultScid)
			{
				return 0;
			}
		}

		private static HCWebSocketRoutedHandler routedCallback;

		private static int hcRoutedHandlerId;

		private const string k_ResourcesFolderName = "GDKEditionAutoGen";

		private static int? s_CachedEditionNumber;

		private static Dictionary<IntPtr, CallbackWrapper<XAsyncWorkInterop>> asyncWorkCallbackDictionary;

		private static XTaskQueueHandle defaultQueue;

		private static bool canBreak;

		private static Thread m_DispatchJob;

		private static bool isInitialized;

		private static bool m_StopExecution;

		private const string obsoleteXPackageMountMsg = "XPackageMount(string, out XPackageMountHandle) has been removed. Please use XPackageMountWithUiAsync(string packageIdentifier, XPackageMountWithUiAsyncCompleted) instead.";

		private static CallbackWrapper<Unity.XGamingRuntime.Interop.XErrorCallback> errorCallbackWrapper;

		private const int XUserGamertagComponentClassicMaxBytes = 16;

		private const int XUserGamertagComponentModernMaxBytes = 97;

		private const int XUserGamertagComponentModernSuffixMaxBytes = 15;

		private const int XUserGamertagComponentUniqueModernMaxBytes = 101;

		private XGameStreamingClientId XGameStreamingNullClientId;

		private XGameStreamingClientId XGameStreamingAllClients;

		private const ulong ClientIPAddressMaxBytes = 65uL;

		private const ulong SessionIdMaxBytes = 256uL;

		public static readonly int XPACKAGE_IDENTIFIER_MAX_LENGTH;

		public static readonly int LOCALE_NAME_MAX_LENGTH;

		public static readonly ulong XSystemAppSpecificDeviceIdBytes;

		public static readonly ulong XSystemConsoleIdBytes;

		public static readonly ulong XSystemXboxLiveSandboxIdMaxBytes;

		public static readonly ulong XUserAudioEndpointMaxUtf16Count;

		public static event HCWebSocketRoutedHandler HCWebSocketRouted
		{
			add
			{
			}
			remove
			{
			}
		}

		[MonoPInvokeCallback]
		private static void HCWebSocketMessageCallback(IntPtr websocket, IntPtr incomingBodyString, IntPtr functionContext)
		{
		}

		[MonoPInvokeCallback]
		private static void HCWebSocketBinaryMessageCallback(IntPtr websocket, IntPtr payloadBytes, uint countOfBlobs, IntPtr functionContext)
		{
		}

		[MonoPInvokeCallback]
		private static void HCWebSocketCloseCallback(IntPtr websocket, HCWebSocketCloseStatus closeStatus, IntPtr functionContext)
		{
		}

		[MonoPInvokeCallback]
		private static void HCWebSocketRoutedCallback(IntPtr websocket, NativeBool receiving, IntPtr message, IntPtr payloadBytes, SizeT payloadSize, IntPtr conext)
		{
		}

		public static int HCInitialize()
		{
			return 0;
		}

		public static int HCCleanupAsync(HCCleanupHandler completionRoutine)
		{
			return 0;
		}

		public static int HCWebSocketCreate(out HCWebsocketHandle websocket, HCWebSocketMessageFunction messageFunc, HCWebSocketBinaryMessageFunction binaryMessageFunc, HCWebSocketCloseEventFunction closeFunc)
		{
			websocket = null;
			return 0;
		}

		public static int HCWebSocketSetProxyUri(HCWebsocketHandle websocket, byte[] proxyUri)
		{
			return 0;
		}

		public static int HCWebSocketSetHeader(HCWebsocketHandle websocket, string headerName, string headerValue)
		{
			return 0;
		}

		public static int HCWebSocketConnectAsync(string uri, string subProtocol, HCWebsocketHandle websocket, HCSocketCompletionResultFunction completionRoutine)
		{
			return 0;
		}

		public static int HCWebSocketSendMessageAsync(HCWebsocketHandle websocket, string message, HCSocketCompletionResultFunction completionRoutine)
		{
			return 0;
		}

		public static int HCWebSocketSendBinaryMessageAsync(HCWebsocketHandle websocket, byte[] data, uint payloadSize, HCSocketCompletionResultFunction completionRoutine)
		{
			return 0;
		}

		public static int HCWebSocketDisconnect(HCWebsocketHandle websocket)
		{
			return 0;
		}

		public static int HCWebSocketCloseHandle(HCWebsocketHandle websocket)
		{
			return 0;
		}

		[Obsolete("This method is deprecated and will be removed. Use the HCWebSocketRouted event instead.", false)]
		public static int HCAddWebSocketRoutedHandler(HCWebSocketRoutedHandler handler)
		{
			return 0;
		}

		[Obsolete("This method is deprecated and will be removed. Use the HCWebSocketRouted event instead.", false)]
		public static void HCRemoveWebSocketRoutedHandler(int handlerId)
		{
		}

		private static void IsHttpClientApiSupported()
		{
		}

		public static int GetGdkEdition()
		{
			return 0;
		}

		public static int XClosedCaptionGetProperties(out XClosedCaptionProperties properties)
		{
			properties = null;
			return 0;
		}

		public static int XClosedCaptionSetEnabled(bool enabled)
		{
			return 0;
		}

		public static int XHighContrastGetMode(out XHighContrastMode mode)
		{
			mode = default(XHighContrastMode);
			return 0;
		}

		public static int XSpeechToTextSetPositionHint(XSpeechToTextPositionHint position)
		{
			return 0;
		}

		public static int XSpeechToTextSendString(string speakerName, string content, XSpeechToTextType type)
		{
			return 0;
		}

		public static int XSpeechToTextBeginHypothesisString(string speakerName, string content, XSpeechToTextType type, out uint hypothesisId)
		{
			hypothesisId = default(uint);
			return 0;
		}

		public static int XSpeechToTextUpdateHypothesisString(uint hypothesisId, string content)
		{
			return 0;
		}

		public static int XSpeechToTextFinalizeHypothesisString(uint hypothesisId, string content)
		{
			return 0;
		}

		public static int XSpeechToTextCancelHypothesisString(uint hypothesisId)
		{
			return 0;
		}

		public static int XAppBroadcastGetStatus(XUserHandle requestingUser, out XAppBroadcastStatus appBroadcastStatus)
		{
			appBroadcastStatus = null;
			return 0;
		}

		public static bool XAppBroadcastIsAppBroadcasting()
		{
			return false;
		}

		public static int XAppBroadcastShowUI(XUserHandle requestingUser)
		{
			return 0;
		}

		public static int XAppBroadcastRegisterIsAppBroadcastingChanged(XTaskQueueHandle queue, IntPtr context, XAppBroadcastMonitorCallback appBroadcastMonitorCallback, out XIsAppBroadcastingChangedRegistrationToken token)
		{
			token = null;
			return 0;
		}

		public static int XAppBroadcastRegisterIsAppBroadcastingChanged(XTaskQueueHandle queue, XAppBroadcastMonitorCallback appBroadcastMonitorCallback, out XIsAppBroadcastingChangedRegistrationToken token)
		{
			token = null;
			return 0;
		}

		public static int XAppCaptureCloseLocalStream(XAppCaptureLocalStreamHandle handle)
		{
			return 0;
		}

		[Obsolete("Please use XAppCaptureCloseScreenshotStream(XAppCaptureScreenshotStreamHandle) instead.", false)]
		public static int XAppCaptureCloseScreenshotStream(IntPtr handle)
		{
			return 0;
		}

		public static int XAppCaptureCloseScreenshotStream(XAppCaptureScreenshotStreamHandle handle)
		{
			return 0;
		}

		public static int XAppCaptureEnableRecord()
		{
			return 0;
		}

		public static int XAppCaptureDisableRecord()
		{
			return 0;
		}

		public static bool XAppBroadcastUnregisterIsAppBroadcastingChanged(XIsAppBroadcastingChangedRegistrationToken token, bool wait)
		{
			return false;
		}

		public static int XAppCaptureMetadataAddStringEvent(string name, string value, XAppCaptureMetadataPriority priority)
		{
			return 0;
		}

		public static int XAppCaptureMetadataAddInt32Event(string name, int value, XAppCaptureMetadataPriority priority)
		{
			return 0;
		}

		public static int XAppCaptureMetadataAddDoubleEvent(string name, double value, XAppCaptureMetadataPriority priority)
		{
			return 0;
		}

		public static int XAppCaptureMetadataStartStringState(string name, string value, XAppCaptureMetadataPriority priority)
		{
			return 0;
		}

		public static int XAppCaptureMetadataStartInt32State(string name, int value, XAppCaptureMetadataPriority priority)
		{
			return 0;
		}

		public static int XAppCaptureMetadataStartDoubleState(string name, double value, XAppCaptureMetadataPriority priority)
		{
			return 0;
		}

		public static int XAppCaptureMetadataStopState(string name)
		{
			return 0;
		}

		public static int XAppCaptureMetadataStopAllStates()
		{
			return 0;
		}

		public static int XAppCaptureMetadataRemainingStorageBytesAvailable(out ulong value)
		{
			value = default(ulong);
			return 0;
		}

		[Obsolete("Use XAppCaptureOpenScreenshotStream(string localId, XAppCaptureScreenshotFormatFlag, out XAppCaptureScreenshotStreamHandle, out UInt64)", false)]
		public static int XAppCaptureOpenScreenshotStream(XAppScreenshotLocalId id, XAppCaptureScreenshotFormatFlag screenshotFormat, out IntPtr handle, out ulong totalBytes)
		{
			handle = default(IntPtr);
			totalBytes = default(ulong);
			return 0;
		}

		public static int XAppCaptureOpenScreenshotStream(string localId, XAppCaptureScreenshotFormatFlag screenshotFormat, out XAppCaptureScreenshotStreamHandle handle, out ulong totalBytes)
		{
			handle = null;
			totalBytes = default(ulong);
			return 0;
		}

		[Obsolete("Use XAppCaptureReadScreenshotStream(XAppCaptureScreenshotStreamHandle, UInt64, UInt32, byte[], out UInt32)", false)]
		public static int XAppCaptureReadScreenshotStream(IntPtr handle, ulong startPosition, uint totalBytes, byte[] data, out int bytesWritten)
		{
			bytesWritten = default(int);
			return 0;
		}

		public static int XAppCaptureReadScreenshotStream(XAppCaptureScreenshotStreamHandle handle, ulong startPosition, uint bytesToRead, byte[] buffer, out uint bytesWritten)
		{
			bytesWritten = default(uint);
			return 0;
		}

		public static int XAppCaptureRecordDiagnosticClip(long startTime, uint durationInMs, string filenamePrefix, out XAppCaptureRecordClipResult result)
		{
			result = null;
			return 0;
		}

		public static int XAppCaptureTakeDiagnosticScreenshot(bool gamescreenOnly, XAppCaptureScreenshotFormatFlag captureFlags, string filenamePrefix, out XAppCaptureDiagnosticScreenshotResult result)
		{
			result = null;
			return 0;
		}

		public static int XAppCaptureTakeScreenshot(XUserHandle requestingUser, out XAppCaptureTakeScreenshotResult result)
		{
			result = null;
			return 0;
		}

		public static int XAppCaptureRegisterMetadataPurged(XTaskQueueHandle queue, IntPtr context, XAppCaptureMetadataPurgedCallback callback, out XMetadataPurgedToken token)
		{
			token = null;
			return 0;
		}

		public static int XAppCaptureRegisterMetadataPurged(XTaskQueueHandle queue, XAppCaptureMetadataPurgedCallback callback, out XMetadataPurgedToken token)
		{
			token = null;
			return 0;
		}

		public static bool XAppCaptureUnRegisterMetadataPurged(XMetadataPurgedToken token, bool wait)
		{
			return false;
		}

		public static int XAppCaptureReadLocalStream(XAppCaptureLocalStreamHandle handle, long startPosition, uint bytesToRead, ref byte[] buffer, out uint bytesWritten)
		{
			bytesWritten = default(uint);
			return 0;
		}

		public static int XAppCaptureRecordTimespan(SYSTEMTIME startTimestamp, ulong durationInMilliseconds, out XAppCaptureLocalResult result)
		{
			result = null;
			return 0;
		}

		public static int XAppCaptureRecordTimespan(ulong durationInMilliseconds, out XAppCaptureLocalResult result)
		{
			result = null;
			return 0;
		}

		public static int XAppCaptureGetVideoCaptureSettings(out XAppCaptureVideoCaptureSettings userCaptureSettings)
		{
			userCaptureSettings = null;
			return 0;
		}

		[AOT.MonoPInvokeCallback(typeof(XAsyncWorkInterop))]
		private static int OnAsyncWorkCallback(IntPtr asyncBlock)
		{
			return 0;
		}

		public static int XAsyncGetStatus(XAsyncBlock asyncBlock, bool wait)
		{
			return 0;
		}

		public static int XAsyncGetResultSize(XAsyncBlock asyncBlock, out ulong bufferSize)
		{
			bufferSize = default(ulong);
			return 0;
		}

		public static void XAsyncCancel(XAsyncBlock asyncBlock)
		{
		}

		public static int XAsyncRun(XAsyncBlock asyncBlock, XAsyncWork work)
		{
			return 0;
		}

		private static void DispatchGXDKTaskQueue()
		{
		}

		private static void DispatchGXDKTaskDone()
		{
		}

		public static int CreateDefaultTaskQueue()
		{
			return 0;
		}

		public static void CloseDefaultXTaskQueue()
		{
		}

		public static bool XTaskQueueDispatch(uint timeoutInMs)
		{
			return false;
		}

		public static int XUserRegisterForChangeEvent(XUserChangeEventCallback callback, out XUserChangeRegistrationToken token)
		{
			token = null;
			return 0;
		}

		[Obsolete("Please use XGameSaveCloseUpdate(XGameSaveUpdateHandle context) instead. (UnityUpgradable) -> XGameSaveCloseUpdate(*)", true)]
		public static void XGameSaveCloseUpdateHandle(XGameSaveUpdateHandle updateHandle)
		{
		}

		public static int XGameSaveDeleteContainerAsync(XGameSaveProviderHandle gameSaveProviderHandle, string containerName, XGameSaveDeleteContainerCompleted onCompleted)
		{
			return 0;
		}

		public static int XGameSaveGetRemainingQuotaAsync(XGameSaveProviderHandle provider, XGameSaveGetRemainingQuotaCompleted onCompleted)
		{
			return 0;
		}

		public static int XGameSaveInitializeProviderAsync(XUserHandle requestingUser, string configurationId, bool syncOnDemand, XGameSaveInitializeProviderCompleted onCompleted)
		{
			return 0;
		}

		public static int XGameSaveReadBlobDataAsync(XGameSaveContainerHandle container, string[] blobNames, XGameSaveReadBlobDataCompleted onCompleted)
		{
			return 0;
		}

		public static int XGameSaveSubmitUpdateAsync(XGameSaveUpdateHandle updateContext, XGameSaveSubmitUpdateCompleted onCompleted)
		{
			return 0;
		}

		public static int XGameSaveFilesGetFolderWithUiAsync(XUserHandle requestingUser, string configurationId, XGameSaveFilesGetFolderWithUiCompleted onCompleted)
		{
			return 0;
		}

		public static int XGameUiShowAchievementsAsync(XUserHandle requestingUser, uint titleId, XGameUiShowAchievementsCompleted onCompleted)
		{
			return 0;
		}

		public static int XGameUiShowErrorDialogAsync(int errorCode, string context, XGameUiShowErrorDialogCompleted onCompleted)
		{
			return 0;
		}

		public static int XGameUiShowMessageDialogAsync(string titleText, string contextText, string firstButtonText, string secondButtonText, string thirdButtonText, XGameUiMessageDialogButton defaultButton, XGameUiMessageDialogButton cancelButton, XGameUiShowMessageDialogCompleted onCompleted)
		{
			return 0;
		}

		public static int XGameUiShowMultiplayerActivityGameInviteAsync(XUserHandle requestingUser, XGameUiShowMultiplayerActivityGameInviteCompleted onCompleted)
		{
			return 0;
		}

		public static int XGameUiShowPlayerPickerAsync(XUserHandle requestingUser, string promptText, ulong[] selectFromPlayers, ulong[] preSelectedPlayers, uint minSelectionCount, uint maxSelectionCount, XGameUiShowPlayerPickerCompleted onCompleted)
		{
			return 0;
		}

		public static int XGameUiShowPlayerProfileCardAsync(XUserHandle requestingUser, ulong targetPlayer, XGameUiShowPlayerProfileCardCompleted onCompleted)
		{
			return 0;
		}

		public static int XGameUiShowSendGameInviteAsync(XUserHandle requestingUser, string sessionConfigurationId, string sessionTemplateName, string sessionId, string invitationText, string customActivationContext, XGameUiShowSendGameInviteCompleted onCompleted)
		{
			return 0;
		}

		public static int XGameUiShowTextEntryAsync(string titleText, string descriptionText, string defaultText, XGameUiTextEntryInputScope inputScope, uint maxTextLength, XGameUiShowTextEntryCompleted onCompleted)
		{
			return 0;
		}

		public static int XGameUiShowWebAuthenticationAsync(XUserHandle requestingUser, string requestUri, string completeUri, XGameUiShowWebAuthenticationAsyncCompleted onCompleted)
		{
			return 0;
		}

		public static int XGameUiShowWebAuthenticationWithOptionsAsync(XUserHandle requestingUser, string requestUri, string completeUri, XGameUiWebAuthenticationOptions options, Action<int, XGameUiWebAuthenticationResultData> onCompleted)
		{
			return 0;
		}

		public static int XNetworkingQueryPreferredLocalUdpMultiplayerPortAsync(XNetworkingQueryPreferredLocalUdpMultiplayerPortResultFunction onCompleted)
		{
			return 0;
		}

		public static int XNetworkingQuerySecurityInformationForUrlAsync(string url, XNetworkingQuerySecurityInformationForUrlResultCallback onCompleted)
		{
			return 0;
		}

		public static int XNetworkingQuerySecurityInformationForUrlUtf16Async(string url, XNetworkingQuerySecurityInformationForUrlResultCallback onCompleted)
		{
			return 0;
		}

		public static int XNetworkingRegisterConnectivityHintChanged(XNetworkingConnectivityHintChangedCallback callback, out XNetworkingRegisterConnectivityHintChangedCallbackToken token)
		{
			token = null;
			return 0;
		}

		public static int XNetworkingRegisterPreferredLocalUdpMultiplayerPortChanged(XNetworkingPreferredLocalUdpMultiplayerPortChangedCallback callback, out XNetworkingPreferredLocalUdpMultiplayerPortChangedCallbackToken token)
		{
			token = null;
			return 0;
		}

		public static bool XNetworkingUnregisterPreferredLocalUdpMultiplayerPortChanged(XNetworkingPreferredLocalUdpMultiplayerPortChangedCallbackToken token)
		{
			return false;
		}

		public static int XPackageCreateInstallationMonitor(string packageIdentifier, XPackageChunkSelector[] selectors, uint minimumUpdateIntervalMs, out XPackageInstallationMonitorHandle installationMonitor)
		{
			installationMonitor = null;
			return 0;
		}

		public static int XPackageCreateInstallationMonitor(string packageIdentifier, uint minimumUpdateIntervalMs, out XPackageInstallationMonitorHandle installationMonitor)
		{
			installationMonitor = null;
			return 0;
		}

		public static int XPackageInstallChunksAsync(string packageIdentifier, XPackageChunkSelector[] selectors, uint minimumUpdateIntervalMs, bool suppressUserConfirmation, XPackageInstallChunksCompleted onCompleted)
		{
			return 0;
		}

		[Obsolete("XPackageMount(string, out XPackageMountHandle) has been removed. Please use XPackageMountWithUiAsync(string packageIdentifier, XPackageMountWithUiAsyncCompleted) instead.", true)]
		public static int XPackageMount(string packageIdentifier, out XPackageMountHandle mountHandle)
		{
			mountHandle = null;
			return 0;
		}

		public static int XPackageMountWithUiAsync(string packageIdentifier, XPackageMountWithUiAsyncCompleted onCompleted)
		{
			return 0;
		}

		public static int XPackageRegisterPackageInstalled(XPackageInstalledCallback callback, out XPackageRegisterPackageInstalledToken token)
		{
			token = null;
			return 0;
		}

		public static int XPackageRegisterInstallationProgressChanged(XPackageInstallationMonitorHandle installationMonitor, XPackageInstallationProgressCallback callback, out XPackageRegisterInstallationProgressChangedToken token)
		{
			token = null;
			return 0;
		}

		public static int XPersistentLocalStoragePromptUserForSpaceAsync(ulong requestedBytes, XPersistentLocalStoragePromptUserForSpaceAsyncCallback onCompleted)
		{
			return 0;
		}

		public static int XStoreAcquireLicenseForDurablesAsync(XStoreContext context, string storeId, XStoreAcquireLicenseForDurablesCompleted onCompleted)
		{
			return 0;
		}

		public static int XStoreAcquireLicenseForPackageAsync(XStoreContext context, string packageIdentifier, XStoreAcquireLicenseForPackageCompleted onCompleted)
		{
			return 0;
		}

		public static int XStoreCanAcquireLicenseForPackageAsync(XStoreContext storeContextHandle, string packageIdentifier, XStoreCanAcquireLicenseForPackageCompleted onCompleted)
		{
			return 0;
		}

		public static int XStoreCanAcquireLicenseForStoreIdAsync(XStoreContext storeContextHandle, string storeProductId, XStoreCanAcquireLicenseForStoreIdCompleted onCompleted)
		{
			return 0;
		}

		public static int XStoreDownloadAndInstallPackagesAsync(XStoreContext storeContextHandle, string[] storeIds, XStoreDownloadAndInstallPackagesCompleted onCompleted)
		{
			return 0;
		}

		public static int XStoreDownloadAndInstallPackageUpdatesAsync(XStoreContext storeContextHandle, string[] packageIdentifiers, XStoreDownloadAndInstallPackageUpdatesCompleted onCompleted)
		{
			return 0;
		}

		public static int XStoreDownloadPackageUpdatesAsync(XStoreContext storeContextHandle, string[] packageIdentifiers, XStoreDownloadPackageUpdatesCompleted onCompleted)
		{
			return 0;
		}

		public static int XStoreGetUserCollectionsIdAsync(XStoreContext storeContextHandle, string serviceTicket, string publisherUserId, XStoreGetUserCollectionsIdCompleted onCompleted)
		{
			return 0;
		}

		public static int XStoreGetUserPurchaseIdAsync(XStoreContext storeContextHandle, string serviceTicket, string publisherUserId, XStoreGetUserPurchaseIdCompleted onCompleted)
		{
			return 0;
		}

		public static int XStoreProductsQueryNextPageAsync(XStoreProductQuery productQueryHandle, XStoreQueryComplete onCompleted)
		{
			return 0;
		}

		public static int XStoreProductsQueryNextPageAsync(XStoreQueryResult currentPage, XStoreQueryComplete completionRoutine)
		{
			return 0;
		}

		public static int XStoreQueryAssociatedProductsAsync(XStoreContext storeContextHandle, XStoreProductKind productKinds, uint maxItemsToRetrievePerPage, Action<int, XStoreProductQuery> onCompleted)
		{
			return 0;
		}

		public static int XStoreQueryAssociatedProductsAsync(XStoreContext storeContextHandle, XStoreProductKind productKinds, uint maxItemsToRetrievePerPage, XStoreQueryComplete onCompleted)
		{
			return 0;
		}

		public static void XStoreCloseProductsQueryHandle(XStoreQueryResult result)
		{
		}

		public static int XStoreQueryAddOnLicensesAsync(XStoreContext storeContextHandle, XStoreQueryAddOnLicensesCompleted onCompleted)
		{
			return 0;
		}

		public static int XStoreQueryConsumableBalanceRemainingAsync(XStoreContext storeContextHandle, string storeProductId, XStoreQueryConsumableBalanceRemainingCompleted onCompleted)
		{
			return 0;
		}

		public static int XStoreQueryEntitledProductsAsync(XStoreContext storeContextHandle, XStoreProductKind productKinds, uint maxItemsToRetrievePerPage, XStoreQueryComplete onCompleted)
		{
			return 0;
		}

		public static int XStoreQueryGameAndDlcPackageUpdatesAsync(XStoreContext storeContextHandle, XStoreQueryGameAndDlcPackageUpdatesCompleted onCompleted)
		{
			return 0;
		}

		public static int XStoreQueryGameLicenseAsync(XStoreContext storeContextHandle, XStoreQueryGameLicenseCompleted onCompleted)
		{
			return 0;
		}

		public static int XStoreQueryLicenseTokenAsync(XStoreContext storeContextHandle, string[] productIds, string customDeveloperString, XStoreQueryLicenseTokenCompleted onCompleted)
		{
			return 0;
		}

		[Obsolete("Please use XStoreQueryLicenseTokenAsync(XStoreContext, string[], string, XStoreQueryLicenseTokenCompleted) instead.", false)]
		public static void XStoreQueryLicenseTokenAsync(XStoreContext context, string[] productIds, uint productIdsCount, string customDeveloperString, XStoreQueryLicenseTokenCompleted completionRoutine)
		{
		}

		public static int XStoreQueryProductForCurrentGameAsync(XStoreContext storeContextHandle, XStoreQueryComplete onCompleted)
		{
			return 0;
		}

		public static int XStoreQueryProductForPackageAsync(XStoreContext storeContextHandle, XStoreProductKind productKinds, string packageIdentifier, XStoreQueryComplete onCompleted)
		{
			return 0;
		}

		public static int XStoreQueryProductsAsync(XStoreContext storeContextHandle, XStoreProductKind productKinds, string[] storeIds, string[] actionFilters, XStoreQueryComplete onCompleted)
		{
			return 0;
		}

		public static int XStoreRegisterGameLicenseChanged(XStoreContext context, XStoreGameLicenseChangedCallback callback, out GameLicenseChangedCallbackToken token)
		{
			token = null;
			return 0;
		}

		public static void XStoreUnregisterGameLicenseChanged(XStoreContext context, GameLicenseChangedCallbackToken token)
		{
		}

		public static int XStoreRegisterPackageLicenseLost(XStoreLicense license, XStorePackageLicenseLostCallback callback, out PackageLicenseLostCallbackToken token)
		{
			token = null;
			return 0;
		}

		public static void XStoreUnregisterPackageLicenseLost(XStoreLicense license, PackageLicenseLostCallbackToken token)
		{
		}

		public static int XStoreReportConsumableFulfillmentAsync(XStoreContext storeContextHandle, string storeProductId, uint quantity, Guid trackingId, XStoreReportConsumableFulfillmentCompleted onCompleted)
		{
			return 0;
		}

		public static int XStoreShowAssociatedProductsUIAsync(XStoreContext storeContextHandle, string storeId, XStoreProductKind productKinds, XStoreShowAssociatedProductsUICompleted onCompleted)
		{
			return 0;
		}

		public static int XStoreShowProductPageUIAsync(XStoreContext storeContextHandle, string storeId, XStoreShowProductPageUICompleted onCompleted)
		{
			return 0;
		}

		public static int XStoreShowPurchaseUIAsync(XStoreContext storeContextHandle, string storeId, string name, string extendedJsonData, XStoreShowPurchaseUICompleted onCompleted)
		{
			return 0;
		}

		public static int XStoreShowRateAndReviewUIAsync(XStoreContext storeContextHandle, XStoreShowRateAndReviewUICompleted onCompleted)
		{
			return 0;
		}

		public static int XStoreShowRedeemTokenUIAsync(XStoreContext storeContextHandle, string token, string[] allowedStoreIds, bool disallowCsvRedemption, XStoreShowRedeemTokenUICompleted onCompleted)
		{
			return 0;
		}

		public static int XUserAddByIdWithUiAsync(ulong userId, XUserAddCompleted onCompleted)
		{
			return 0;
		}

		public static int XUserFindControllerForUserWithUiAsync(XUserHandle user, XUserFindControllerForUserWithUiResult onCompleted)
		{
			return 0;
		}

		public static int XUserGetTokenAndSignatureUtf16Async(XUserHandle user, XUserGetTokenAndSignatureOptions options, string method, string url, XUserGetTokenAndSignatureUtf16HttpHeader[] headers, byte[] bodyBuffer, XUserGetTokenAndSignatureUtf16Result onCompleted)
		{
			return 0;
		}

		public static int XUserResolveIssueWithUiUtf16Async(XUserHandle user, string url, XUserResolveIssueWithUiUtf16Result onCompleted)
		{
			return 0;
		}

		public static int XUserResolvePrivilegeWithUiAsync(XUserHandle user, XUserPrivilegeOptions options, XUserPrivilege privilege, XUserResolvePrivilegeWithUiCompleted onCompleted)
		{
			return 0;
		}

		public static int XUserGetGamerPictureAsync(XUserHandle user, XUserGamerPictureSize pictureSize, XUserGetGamerPictureCompleted onCompleted)
		{
			return 0;
		}

		public static int XUserAddAsync(XUserAddOptions options, XUserAddCompleted onCompleted)
		{
			return 0;
		}

		public static int XAppBroadcastRegisterIsAppBroadcastingChanged(XAppBroadcastMonitorCallback callback, out XIsAppBroadcastingChangedRegistrationToken token)
		{
			token = null;
			return 0;
		}

		public static bool XAppBroadcastUnregisterIsAppBroadcastingChanged(XIsAppBroadcastingChangedRegistrationToken token)
		{
			return false;
		}

		public static int XAppCaptureRegisterMetadataPurged(XAppCaptureMetadataPurgedCallback callback, out XMetadataPurgedToken token)
		{
			token = null;
			return 0;
		}

		public static bool XAppCaptureUnRegisterMetadataPurged(XMetadataPurgedToken token)
		{
			return false;
		}

		public static int XGameInviteRegisterForEvent(XGameInviteEventCallback callback, out XGameInviteRegistrationToken token)
		{
			token = null;
			return 0;
		}

		[AOT.MonoPInvokeCallback(typeof(XAsyncProviderInterop))]
		private static int OnAsyncProvider(XAsyncOp op, Unity.XGamingRuntime.Interop.XAsyncProviderData data)
		{
			return 0;
		}

		public static int XAsyncBegin(XAsyncBlock asyncBlock, IntPtr context, IntPtr identity, string identityName, XAsyncProvider provider)
		{
			return 0;
		}

		public static int XAsyncSchedule(XAsyncBlock asyncBlock, uint delayInMs)
		{
			return 0;
		}

		public static void XAsyncComplete(XAsyncBlock asyncBlock, uint result, ulong requiredBufferSize)
		{
		}

		public static int XAsyncGetResult(XAsyncBlock asyncBlock, IntPtr identity, byte[] buffer, out ulong bufferUsed)
		{
			bufferUsed = default(ulong);
			return 0;
		}

		public static XDisplayHdrModeResult XDisplayTryEnableHdrMode(XDisplayHdrModePreference displayModePreference, out XDisplayHdrModeInfo displayHdrModeInfo)
		{
			displayHdrModeInfo = null;
			return default(XDisplayHdrModeResult);
		}

		public static int XDisplayAcquireTimeoutDeferral(out XDisplayTimeoutDeferralHandle handle)
		{
			handle = null;
			return 0;
		}

		public static void XDisplayCloseTimeoutDeferralHandle(XDisplayTimeoutDeferralHandle handle)
		{
		}

		[AOT.MonoPInvokeCallback(typeof(Unity.XGamingRuntime.Interop.XErrorCallback))]
		private static bool OnErrorCallback(int hr, string msg, IntPtr context)
		{
			return false;
		}

		public static void XErrorSetCallback(XErrorCallback callback, IntPtr context)
		{
		}

		public static void XErrorSetOptions(XErrorOptions optionsDebuggerPresent, XErrorOptions optionsDebuggerNotPresent)
		{
		}

		public static int XGameSaveEnumerateBlobInfo(XGameSaveContainerHandle container, out XGameSaveBlobInfo[] blobInfos)
		{
			blobInfos = null;
			return 0;
		}

		public static int XGameSaveGetContainerInfo(XGameSaveProviderHandle provider, string containerName, out XGameSaveContainerInfo containerInfo)
		{
			containerInfo = null;
			return 0;
		}

		public static int XGameSaveEnumerateContainerInfo(XGameSaveProviderHandle provider, out XGameSaveContainerInfo[] localInfos)
		{
			localInfos = null;
			return 0;
		}

		public static int XGameSaveEnumerateContainerInfoByName(XGameSaveProviderHandle provider, string containerNamePrefix, out XGameSaveContainerInfo[] localInfos)
		{
			localInfos = null;
			return 0;
		}

		public static int XGameSaveEnumerateBlobInfoByName(XGameSaveContainerHandle provider, string blobNamePrefix, out XGameSaveBlobInfo[] blobInfos)
		{
			blobInfos = null;
			return 0;
		}

		public static int XGameSaveReadBlobData(XGameSaveContainerHandle container, List<XGameSaveBlobInfo> blobInfos, out List<XGameSaveBlob> blobs)
		{
			blobs = null;
			return 0;
		}

		public static int XSpeechSynthesizerEnumerateInstalledVoices(out XSpeechSynthesizerVoiceInformation[] voiceInformation)
		{
			voiceInformation = null;
			return 0;
		}

		public static int XSpeechSynthesizerGetStreamData(XSpeechSynthesizerStreamHandle speechSynthesisStream, out byte[] buffer)
		{
			buffer = null;
			return 0;
		}

		public static int XStoreEnumerateProductsQuery(XStoreProductQuery productQueryHandle, out XStoreProduct[] products)
		{
			products = null;
			return 0;
		}

		public static int XUserGetGamertag(XUserHandle user, XUserGamertagComponent gamertagComponent, out string gamertag)
		{
			gamertag = null;
			return 0;
		}

		public static int XAppCaptureRecordDiagnosticClip(DateTime startTime, uint durationInMS, string fileNamePrefix, out XAppCaptureRecordClipResult result)
		{
			result = null;
			return 0;
		}

		public static int XPackageGetMountPath(XPackageMountHandle mountHandle, out string path)
		{
			path = null;
			return 0;
		}

		public static int XPackageEstimateDownloadSize(string packageIdentifier, out ulong downloadSize, out bool shouldPresentUserConfirmation)
		{
			downloadSize = default(ulong);
			shouldPresentUserConfirmation = default(bool);
			return 0;
		}

		public static int XPackageEnumerateChunkAvailability(string packageIdentifier, XPackageChunkSelectorType type, XPackageChunkAvailabilityCallback callback)
		{
			return 0;
		}

		public static int XPackageEnumeratePackages(XPackageKind kind, XPackageEnumerationScope scope, out XPackageDetails[] details)
		{
			details = null;
			return 0;
		}

		public static int XPackageEnumerateFeatures(string packageIdentifier, out XPackageFeature[] features)
		{
			features = null;
			return 0;
		}

		public static int XSpeechSynthesizerSetCustomVoice(XSpeechSynthesizerHandle speechSynthesizer, XSpeechSynthesizerVoiceInformation voiceInformation)
		{
			return 0;
		}

		public static int XGameGetXboxTitleId(out uint titleId)
		{
			titleId = default(uint);
			return 0;
		}

		public static void XLaunchNewGame(string exePath, string args, XUserHandle defaultUser)
		{
		}

		public static int XLaunchRestartOnCrash(string args, uint reserved)
		{
			return 0;
		}

		public static int XGameEventWrite(XUserHandle user, string serviceConfigId, string playSessionId, string eventName, string dimensionsJson, string measurementsJson)
		{
			return 0;
		}

		public static int XGameInviteRegisterForEvent(XTaskQueueHandle handle, XGameInviteEventCallback callback, IntPtr context, out XGameInviteRegistrationToken token)
		{
			token = null;
			return 0;
		}

		public static int XGameInviteRegisterForEvent(XTaskQueueHandle handle, XGameInviteEventCallback callback, out XGameInviteRegistrationToken token)
		{
			token = null;
			return 0;
		}

		public static bool XGameInviteUnregisterForEvent(XGameInviteRegistrationToken token, bool wait)
		{
			return false;
		}

		public static bool XGameInviteUnregisterForEvent(XGameInviteRegistrationToken token)
		{
			return false;
		}

		public static int XGameProtocolRegisterForActivation(XTaskQueueHandle queue, IntPtr context, XGameProtocolActivationCallback callback, out XGameProtocolActivationToken token)
		{
			token = null;
			return 0;
		}

		public static bool XGameProtocolUnregisterForActivation(XGameProtocolActivationToken token, bool wait)
		{
			return false;
		}

		public static bool XGameRuntimeIsFeatureAvailable(XGameRuntimeFeature feature)
		{
			return false;
		}

		public static int XGameRuntimeInitialize()
		{
			return 0;
		}

		private static int XGameRuntimeInitializeWithOptions(XGameRuntimeOptions options)
		{
			return 0;
		}

		public static void XGameRuntimeUninitialize()
		{
		}

		private static bool XVersionLessThan(XVersion version1, XVersion version2)
		{
			return false;
		}

		public static void XGameSaveCloseContainer(XGameSaveContainerHandle context)
		{
		}

		public static void XGameSaveCloseProvider(XGameSaveProviderHandle provider)
		{
		}

		public static void XGameSaveCloseUpdate(XGameSaveUpdateHandle context)
		{
		}

		public static int XGameSaveInitializeProvider(XUserHandle requestingUser, string configurationId, bool syncOnDemand, out XGameSaveProviderHandle provider)
		{
			provider = null;
			return 0;
		}

		public static int XGameSaveInitializeProviderAsync(XUserHandle requestingUser, string configurationId, bool syncOnDemand, XAsyncBlock asyncBlock)
		{
			return 0;
		}

		public static int XGameSaveInitializeProviderResult(XAsyncBlock asyncBlock, out XGameSaveProviderHandle provider)
		{
			provider = null;
			return 0;
		}

		public static int XGameSaveGetRemainingQuota(XGameSaveProviderHandle provider, out long remainingQuota)
		{
			remainingQuota = default(long);
			return 0;
		}

		public static int XGameSaveGetRemainingQuotaAsync(XGameSaveProviderHandle provider, XAsyncBlock asyncBlock)
		{
			return 0;
		}

		public static int XGameSaveGetRemainingQuotaResult(XAsyncBlock async, out long remainingQuota)
		{
			remainingQuota = default(long);
			return 0;
		}

		public static int XGameSaveDeleteContainer(XGameSaveProviderHandle provider, string containerName)
		{
			return 0;
		}

		public static int XGameSaveDeleteContainerAsync(XGameSaveProviderHandle provider, string containerName, XAsyncBlock async)
		{
			return 0;
		}

		public static int XGameSaveDeleteContainerResult(XAsyncBlock async)
		{
			return 0;
		}

		[AOT.MonoPInvokeCallback(typeof(Unity.XGamingRuntime.Interop.XGameSaveContainerInfoCallback))]
		private static bool OnContainerInfo(Unity.XGamingRuntime.Interop.XGameSaveContainerInfo info, IntPtr context)
		{
			return false;
		}

		public static int XGameSaveGetContainerInfo(XGameSaveProviderHandle provider, string containerName, IntPtr context, XGameSaveContainerInfoCallback callback)
		{
			return 0;
		}

		public static int XGameSaveEnumerateContainerInfo(XGameSaveProviderHandle provider, IntPtr context, XGameSaveContainerInfoCallback callback)
		{
			return 0;
		}

		public static int XGameSaveEnumerateContainerInfoByName(XGameSaveProviderHandle provider, string containerNamePrefix, IntPtr context, XGameSaveContainerInfoCallback callback)
		{
			return 0;
		}

		public static int XGameSaveReadBlobData(XGameSaveContainerHandle container, XGameSaveBlobInfo[] blobInfos, out XGameSaveBlob[] blobData)
		{
			blobData = null;
			return 0;
		}

		public static int XGameSaveCreateContainer(XGameSaveProviderHandle provider, string containerName, out XGameSaveContainerHandle containerContext)
		{
			containerContext = null;
			return 0;
		}

		public static int XGameSaveReadBlobDataResult(XAsyncBlock async, ulong blobsSize, out XGameSaveBlob[] blobData)
		{
			blobData = null;
			return 0;
		}

		[AOT.MonoPInvokeCallback(typeof(Unity.XGamingRuntime.Interop.XGameSaveBlobInfoCallback))]
		private static bool OnBlobInfo(Unity.XGamingRuntime.Interop.XGameSaveBlobInfo info, IntPtr context)
		{
			return false;
		}

		public static int XGameSaveEnumerateBlobInfo(XGameSaveContainerHandle container, IntPtr context, XGameSaveBlobInfoCallback callback)
		{
			return 0;
		}

		public static int XGameSaveEnumerateBlobInfoByName(XGameSaveContainerHandle container, string blobNamePrefix, IntPtr context, XGameSaveBlobInfoCallback callback)
		{
			return 0;
		}

		public static int XGameSaveReadBlobDataAsync(XGameSaveContainerHandle container, string[] blobNames, XAsyncBlock async)
		{
			return 0;
		}

		public static int XGameSaveCreateUpdate(XGameSaveContainerHandle container, string containerDisplayName, out XGameSaveUpdateHandle updateContext)
		{
			updateContext = null;
			return 0;
		}

		public static int XGameSaveSubmitBlobWrite(XGameSaveUpdateHandle updateContext, string blobName, byte[] data)
		{
			return 0;
		}

		public static int XGameSaveSubmitBlobWrite(XGameSaveUpdateHandle updateContext, string blobName, byte[] data, uint length)
		{
			return 0;
		}

		public static int XGameSaveSubmitBlobDelete(XGameSaveUpdateHandle updateContext, string blobName)
		{
			return 0;
		}

		public static int XGameSaveSubmitUpdate(XGameSaveUpdateHandle updateContext)
		{
			return 0;
		}

		public static int XGameSaveSubmitUpdateAsync(XGameSaveUpdateHandle updateContext, XAsyncBlock async)
		{
			return 0;
		}

		public static int XGameSaveSubmitUpdateResult(XAsyncBlock async)
		{
			return 0;
		}

		public static int XGameSaveFilesGetFolderWithUiAsync(XUserHandle requestingUser, string configurationId, XAsyncBlock async)
		{
			return 0;
		}

		public static int XGameSaveFilesGetFolderWithUiResult(XAsyncBlock async, ulong folderSize, out string folderResult)
		{
			folderResult = null;
			return 0;
		}

		[Obsolete("Please use XGameSaveFilesGetRemainingQuota(XUserHandle, string, out UInt64) instead", false)]
		public static int XGameSaveFilesGetRemainingQuota(XUserHandle userContext, string configurationId, out long remainingQuota)
		{
			remainingQuota = default(long);
			return 0;
		}

		public static int XGameSaveFilesGetRemainingQuota(XUserHandle userContext, string configurationId, out ulong remainingQuota)
		{
			remainingQuota = default(ulong);
			return 0;
		}

		private static int ProcessTouchControlOperation(ref XGameStreamingTouchControlsStateOperation[] operations, out Unity.XGamingRuntime.Interop.XGameStreamingTouchControlsStateOperation[] nativeOperations, out List<IntPtr> stringsToFree)
		{
			nativeOperations = null;
			stringsToFree = null;
			return 0;
		}

		public static int XGameStreamingInitialize()
		{
			return 0;
		}

		public static void XGameStreamingUninitialize()
		{
		}

		public static bool XGameStreamingIsStreaming()
		{
			return false;
		}

		public static uint XGameStreamingGetClientCount()
		{
			return 0u;
		}

		public static int XGameStreamingGetClients(ref XGameStreamingClientId[] clients, out uint clientUsed)
		{
			clientUsed = default(uint);
			return 0;
		}

		public static XGameStreamingConnectionState XGameStreamingGetConnectionState(XGameStreamingClientId client)
		{
			return default(XGameStreamingConnectionState);
		}

		public static int XGameStreamingRegisterConnectionStateChanged(XTaskQueueHandle queue, IntPtr context, XGameStreamingConnectionStateChangedCallback callback, out XGameStreamingConnectionStateChangedToken token)
		{
			token = null;
			return 0;
		}

		public static bool XGameStreamingUnregisterConnectionStateChanged(XGameStreamingConnectionStateChangedToken token, bool wait)
		{
			return false;
		}

		public static void XGameStreamingHideTouchControls()
		{
		}

		public static void XGameStreamingHideTouchControlsOnClient(XGameStreamingClientId client)
		{
		}

		public static void XGameStreamingShowTouchControlLayout(string layout)
		{
		}

		public static void XGameStreamingShowTouchControlLayoutOnClient(XGameStreamingClientId client, string layout)
		{
		}

		public static int XGameStreamingRegisterClientPropertiesChanged(XGameStreamingClientId client, XTaskQueueHandle queue, IntPtr context, XGameStreamingClientPropertiesChangedCallback callback, out XGameStreamingRegisterClientPropertiesChangedToken token)
		{
			token = null;
			return 0;
		}

		public static bool XGameStreamingUnregisterClientPropertiesChanged(XGameStreamingClientId client, XGameStreamingRegisterClientPropertiesChangedToken token, bool wait)
		{
			return false;
		}

		public static int XGameStreamingGetStreamPhysicalDimensions(XGameStreamingClientId client, out uint horizontalMm, out uint verticalMm)
		{
			horizontalMm = default(uint);
			verticalMm = default(uint);
			return 0;
		}

		public static int XGameStreamingGetStreamAddedLatency(XGameStreamingClientId client, out uint averageInputLatencyUs, out uint averageOutputLatencyUs, out uint standardDeviationUs)
		{
			averageInputLatencyUs = default(uint);
			averageOutputLatencyUs = default(uint);
			standardDeviationUs = default(uint);
			return 0;
		}

		public static ulong XGameStreamingGetServerLocationNameSize()
		{
			return 0uL;
		}

		public static int XGameStreamingGetServerLocationName(ulong serverLocalNameSize, out string serverLocationName)
		{
			serverLocationName = null;
			return 0;
		}

		public static int XGameStreamingIsTouchInputEnabled(XGameStreamingClientId client, out bool touchInputEnabled)
		{
			touchInputEnabled = default(bool);
			return 0;
		}

		public static int XGameStreamingGetLastFrameDisplayed(XGameStreamingClientId client, out D3D12XBOX_FRAME_PIPELINE_TOKEN framePipelineToken)
		{
			framePipelineToken = null;
			return 0;
		}

		public static int XGameStreamingUpdateTouchControlsState(XGameStreamingTouchControlsStateOperation[] operations)
		{
			return 0;
		}

		public static int XGameStreamingUpdateTouchControlsStateOnClient(XGameStreamingClientId client, XGameStreamingTouchControlsStateOperation[] operations)
		{
			return 0;
		}

		public static int XGameStreamingShowTouchControlsWithStateUpdate(string layout, XGameStreamingTouchControlsStateOperation[] operations)
		{
			return 0;
		}

		public static int XGameStreamingShowTouchControlsWithStateUpdateOnClient(XGameStreamingClientId client, string layout, XGameStreamingTouchControlsStateOperation[] operations)
		{
			return 0;
		}

		public static ulong XGameStreamingGetTouchBundleVersionNameSize(XGameStreamingClientId client)
		{
			return 0uL;
		}

		public static int XGameStreamingGetTouchBundleVersion(XGameStreamingClientId client, out XVersion version, ulong versionNameSize, out string versionName)
		{
			version = null;
			versionName = null;
			return 0;
		}

		public static int XGameStreamingGetClientIPAddress(XGameStreamingClientId client, out string ipAddress)
		{
			ipAddress = null;
			return 0;
		}

		public static int XGameStreamingGetSessionId(XGameStreamingClientId client, out string sessionId)
		{
			sessionId = null;
			return 0;
		}

		public static int XGameStreamingGetDisplayDetails(XGameStreamingClientId clientId, uint maxSupportedPixels, float widestSupportedAspectRatio, float tallestSupportedAspectRatio, out XGameStreamingDisplayDetails displayDetails)
		{
			displayDetails = null;
			return 0;
		}

		public static int XGameStreamingSetResolution(uint width, uint height)
		{
			return 0;
		}

		public static int XGameUiShowMessageDialogAsync(XAsyncBlock async, string titleText, string contextText, string firstButtonText, string secondButtonText, string thirdButtonText, XGameUiMessageDialogButton defaultButton, XGameUiMessageDialogButton cancelButton)
		{
			return 0;
		}

		public static int XGameUiShowMessageDialogResult(XAsyncBlock async, out XGameUiMessageDialogButton resultButton)
		{
			resultButton = default(XGameUiMessageDialogButton);
			return 0;
		}

		public static int XGameUiShowSendGameInviteAsync(XAsyncBlock async, XUserHandle requestingUser, string sessionConfigurationId, string sessionTemplateName, string sessionId, string invitationText, string customActivationContext)
		{
			return 0;
		}

		public static int XGameUiShowSendGameInviteResult(XAsyncBlock async)
		{
			return 0;
		}

		public static int XGameUiShowMultiplayerActivityGameInviteAsync(XAsyncBlock async, XUserHandle requestingUser)
		{
			return 0;
		}

		public static int XGameUiShowMultiplayerActivityGameInviteResult(XAsyncBlock async)
		{
			return 0;
		}

		public static int XGameUiShowPlayerProfileCardAsync(XAsyncBlock async, XUserHandle requestingUser, ulong targetPlayer)
		{
			return 0;
		}

		public static int XGameUiShowPlayerProfileCardResult(XAsyncBlock async)
		{
			return 0;
		}

		public static int XGameUiShowAchievementsAsync(XAsyncBlock async, XUserHandle requestingUser, uint titleId)
		{
			return 0;
		}

		public static int XGameUiShowAchievementsResult(XAsyncBlock async)
		{
			return 0;
		}

		public static int XGameUiShowPlayerPickerAsync(XAsyncBlock async, XUserHandle requestingUser, string promptText, ulong[] selectFromPlayers, ulong[] preSelectedPlayers, uint minSelectionCount, uint maxSelectionCount)
		{
			return 0;
		}

		public static int XGameUiShowWebAuthenticationResult(XAsyncBlock async, byte[] buffer, out XGameUiWebAuthenticationResultData result)
		{
			result = null;
			return 0;
		}

		public static int XGameUiShowPlayerPickerResultCount(XAsyncBlock async, out uint resultPlayersCount)
		{
			resultPlayersCount = default(uint);
			return 0;
		}

		public static int XGameUiShowPlayerPickerResult(XAsyncBlock async, ulong[] resultPlayers, out uint resultPlayerUsed)
		{
			resultPlayerUsed = default(uint);
			return 0;
		}

		public static int XGameUiShowErrorDialogAsync(XAsyncBlock async, int errorCode, string context)
		{
			return 0;
		}

		public static int XGameUiShowErrorDialogResult(XAsyncBlock async)
		{
			return 0;
		}

		public static int XGameUiSetNotificationPositionHint(XGameUiNotificationPositionHint position)
		{
			return 0;
		}

		public static int XGameUiShowTextEntryAsync(XAsyncBlock async, string titleText, string descriptionText, string defaultText, XGameUiTextEntryInputScope inputScope, uint maxTextLength)
		{
			return 0;
		}

		public static int XGameUiShowTextEntryResultSize(XAsyncBlock async, out uint resultTextBufferSize)
		{
			resultTextBufferSize = default(uint);
			return 0;
		}

		public static int XGameUiShowTextEntryResult(XAsyncBlock async, uint resultTextBufferSize, out string resultTextBuffer)
		{
			resultTextBuffer = null;
			return 0;
		}

		public static int XGameUiShowWebAuthenticationAsync(XAsyncBlock async, XUserHandle requestingUser, string requestUri, string completeUri)
		{
			return 0;
		}

		public static int XGameUiShowWebAuthenticationWithOptionsAsync(XAsyncBlock async, XUserHandle requestingUser, string requestUri, string completionUri, XGameUiWebAuthenticationOptions options)
		{
			return 0;
		}

		public static int XGameUiShowWebAuthenticationResultSize(XAsyncBlock async, out ulong bufferSize)
		{
			bufferSize = default(ulong);
			return 0;
		}

		public static void XGameUiTextEntryClose(XGameUiTextEntryHandle handle)
		{
		}

		public static int XGameUiTextEntryGetExtents(XGameUiTextEntryHandle handle, out XGameUiTextEntryExtents extents)
		{
			extents = null;
			return 0;
		}

		public static int XGameUiTextEntryOpen(XGameUiTextEntryOptions options, uint maxLength, string initialText, uint cursorIndex, out XGameUiTextEntryHandle handle)
		{
			handle = null;
			return 0;
		}

		public static int XGameUiTextEntryGetState(XGameUiTextEntryHandle handle, out XGameUiTextEntryChangeTypeFlags changeType, out uint cursorIndex, out uint imeClauseStartIndex, out uint imeClauseEndIndex, uint bufferSize, out string buffer)
		{
			changeType = default(XGameUiTextEntryChangeTypeFlags);
			cursorIndex = default(uint);
			imeClauseStartIndex = default(uint);
			imeClauseEndIndex = default(uint);
			buffer = null;
			return 0;
		}

		public static int XGameUiTextEntryUpdatePositionHint(XGameUiTextEntryHandle handle, XGameUiTextEntryPositionHint positionHint)
		{
			return 0;
		}

		public static int XGameUiTextEntryUpdateVisibility(XGameUiTextEntryHandle handle, XGameUiTextEntryVisibilityFlags visibilityFlags)
		{
			return 0;
		}

		public static int XLaunchUri(XUserHandle requestingUser, string uri)
		{
			return 0;
		}

		public static int XNetworkingGetConnectivityHint(out XNetworkingConnectivityHint getConnectivityHint)
		{
			getConnectivityHint = null;
			return 0;
		}

		public static int XNetworkingQueryConfigurationSetting(XNetworkingConfigurationSetting getConfigurationSetting, out ulong value)
		{
			value = default(ulong);
			return 0;
		}

		public static int XNetworkingQueryPreferredLocalUdpMultiplayerPort(out ushort value)
		{
			value = default(ushort);
			return 0;
		}

		public static int XNetworkingQueryPreferredLocalUdpMultiplayerPortAsync(XAsyncBlock async)
		{
			return 0;
		}

		public static int XNetworkingQueryPreferredLocalUdpMultiplayerPortAsyncResult(XAsyncBlock async, out ushort preferredLocalUdpMultiplayerPort)
		{
			preferredLocalUdpMultiplayerPort = default(ushort);
			return 0;
		}

		public static int XNetworkingQuerySecurityInformationForUrlAsync(string url, XAsyncBlock async)
		{
			return 0;
		}

		public static int XNetworkingQuerySecurityInformationForUrlAsyncResultSize(XAsyncBlock async, out ulong securityInformationBufferByteCount)
		{
			securityInformationBufferByteCount = default(ulong);
			return 0;
		}

		public static int XNetworkingQuerySecurityInformationForUrlAsyncResult(XAsyncBlock async, byte[] securityInformationBuffer, out ulong securityInformationBufferByteCountUsed, out XNetworkingSecurityInformation securityInformation)
		{
			securityInformationBufferByteCountUsed = default(ulong);
			securityInformation = null;
			return 0;
		}

		public static int XNetworkingQuerySecurityInformationForUrlUtf16Async(string url, XAsyncBlock async)
		{
			return 0;
		}

		public static int XNetworkingQuerySecurityInformationForUrlUtf16AsyncResultSize(XAsyncBlock async, out ulong securityInformationBufferByteCount)
		{
			securityInformationBufferByteCount = default(ulong);
			return 0;
		}

		public static int XNetworkingQuerySecurityInformationForUrlUtf16AsyncResult(XAsyncBlock async, byte[] securityInformationBuffer, out ulong securityInformationBufferByteCountUsed, out XNetworkingSecurityInformation securityInformation)
		{
			securityInformationBufferByteCountUsed = default(ulong);
			securityInformation = null;
			return 0;
		}

		public static int XNetworkingQueryStatistics(XNetworkingStatisticsType statisticsType, out XNetworkingStatisticsBuffer statisticsBuffer)
		{
			statisticsBuffer = null;
			return 0;
		}

		public static int XNetworkingRegisterConnectivityHintChanged(XTaskQueueHandle queue, IntPtr context, XNetworkingConnectivityHintChangedCallback callback, out XNetworkingRegisterConnectivityHintChangedCallbackToken token)
		{
			token = null;
			return 0;
		}

		public static bool XNetworkingUnregisterConnectivityHintChanged(XNetworkingRegisterConnectivityHintChangedCallbackToken token, bool wait)
		{
			return false;
		}

		public static int XNetworkingRegisterPreferredLocalUdpMultiplayerPortChanged(XTaskQueueHandle queue, IntPtr context, XNetworkingPreferredLocalUdpMultiplayerPortChangedCallback callback, out XNetworkingPreferredLocalUdpMultiplayerPortChangedCallbackToken token)
		{
			token = null;
			return 0;
		}

		public static bool XNetworkingUnregisterPreferredLocalUdpMultiplayerPortChanged(XNetworkingPreferredLocalUdpMultiplayerPortChangedCallbackToken token, bool wait)
		{
			return false;
		}

		public static int XNetworkingVerifyServerCertificate(IntPtr requestHandle, XNetworkingSecurityInformation securityInformation)
		{
			return 0;
		}

		public static void MarshalXNetworkingSecurityInformationInteropToManaged(IntPtr securityInformationInteropPtr, ref XNetworkingSecurityInformation securityInformation)
		{
		}

		public static void MarshalXNetworkingSecurityInformationManagedToInterop(XNetworkingSecurityInformation securityInformation, out IntPtr securityInformationInteropPtr)
		{
			securityInformationInteropPtr = default(IntPtr);
		}

		private static int ProcessChunkSelector(XPackageChunkSelector[] selectors, ref XPackageChunkSelectorInterop[] nativeSelectors, out List<IntPtr> stringsToFree)
		{
			stringsToFree = null;
			return 0;
		}

		public static int XPackageCreateInstallationMonitor(string packageIdentifier, XPackageChunkSelector[] selectors, uint minimumUpdateIntervalMs, XTaskQueueHandle queue, out XPackageInstallationMonitorHandle installationMonitor)
		{
			installationMonitor = null;
			return 0;
		}

		public static void XPackageCloseInstallationMonitorHandle(XPackageInstallationMonitorHandle installationMonitor)
		{
		}

		public static int XPackageGetCurrentProcessPackageIdentifier(out string buffer)
		{
			buffer = null;
			return 0;
		}

		public static bool XPackageIsPackagedProcess()
		{
			return false;
		}

		public static void XPackageGetInstallationProgress(XPackageInstallationMonitorHandle installationMonitor, out XPackageInstallationProgress progress)
		{
			progress = null;
		}

		public static void XPackageUpdateInstallationMonitor(XPackageInstallationMonitorHandle installationMonitor)
		{
		}

		public static int XPackageGetUserLocale(out string locale)
		{
			locale = null;
			return 0;
		}

		public static int XPackageFindChunkAvailability(string packageIdentifier, XPackageChunkSelector[] selectors, out XPackageChunkAvailability availability)
		{
			availability = default(XPackageChunkAvailability);
			return 0;
		}

		public static int XPackageChangeChunkInstallOrder(string packageIdentifier, XPackageChunkSelector[] selectors)
		{
			return 0;
		}

		public static int XPackageInstallChunks(string packageIdentifier, XPackageChunkSelector[] selectors, uint minimumUpdateIntervalMs, bool suppressUserConfirmation, XTaskQueueHandle queue, out XPackageInstallationMonitorHandle installationMonitor)
		{
			installationMonitor = null;
			return 0;
		}

		public static int XPackageInstallChunksAsync(string packageIdentifier, XPackageChunkSelector[] selectors, uint minimumUpdateIntervalMs, bool suppressUserConfirmation, XAsyncBlock async)
		{
			return 0;
		}

		public static int XPackageInstallChunksResult(XAsyncBlock asyncBlock, out XPackageInstallationMonitorHandle installationMonitor)
		{
			installationMonitor = null;
			return 0;
		}

		public static int XPackageEstimateDownloadSize(string packageIdentifier, XPackageChunkSelector[] selectors, out ulong downloadSize, out bool shouldPresentUserConfirmation)
		{
			downloadSize = default(ulong);
			shouldPresentUserConfirmation = default(bool);
			return 0;
		}

		public static int XPackageUninstallChunks(string packageIdentifier, XPackageChunkSelector[] selectors)
		{
			return 0;
		}

		public static void XPackageCloseMountHandle(XPackageMountHandle mount)
		{
		}

		[AOT.MonoPInvokeCallback(typeof(Unity.XGamingRuntime.Interop.XPackageChunkAvailabilityCallback))]
		private static bool OnPackageChunkAvailability(IntPtr context, XPackageChunkSelectorInterop selector, XPackageChunkAvailability availability)
		{
			return false;
		}

		public static int XPackageEnumerateChunkAvailability(string packageIdentifier, XPackageChunkSelectorType type, IntPtr context, XPackageChunkAvailabilityCallback callback)
		{
			return 0;
		}

		[AOT.MonoPInvokeCallback(typeof(XPackageFeatureEnumerationCallbackInterop))]
		private static bool OnXPackageFeature(IntPtr context, Unity.XGamingRuntime.Interop.XPackageFeature feature)
		{
			return false;
		}

		public static int XPackageEnumerateFeatures(string packageIdentifier, IntPtr context, XPackageFeatureEnumerationCallback callback)
		{
			return 0;
		}

		[AOT.MonoPInvokeCallback(typeof(Unity.XGamingRuntime.Interop.XPackageEnumerationCallback))]
		private static bool OnPackageEnumeration(IntPtr context, Unity.XGamingRuntime.Interop.XPackageDetails details)
		{
			return false;
		}

		public static int XPackageEnumeratePackages(XPackageKind kind, XPackageEnumerationScope scope, IntPtr context, XPackageEnumerationCallback callback)
		{
			return 0;
		}

		public static int XPackageGetMountPathSize(XPackageMountHandle mount, out ulong pathSize)
		{
			pathSize = default(ulong);
			return 0;
		}

		public static int XPackageGetMountPath(XPackageMountHandle mount, ulong pathSize, out string path)
		{
			path = null;
			return 0;
		}

		public static int XPackageGetWriteStats(out XPackageWriteStats writeStats)
		{
			writeStats = null;
			return 0;
		}

		public static int XPackageMountWithUiAsync(string packageIdentifier, XAsyncBlock asyncBlock)
		{
			return 0;
		}

		public static int XPackageMountWithUiResult(XAsyncBlock async, out XPackageMountHandle mount)
		{
			mount = null;
			return 0;
		}

		public static int XPackageRegisterInstallationProgressChanged(XPackageInstallationMonitorHandle installationMonitorHandle, IntPtr context, XPackageInstallationProgressCallback callback, out XPackageRegisterInstallationProgressChangedToken token)
		{
			token = null;
			return 0;
		}

		public static int XPackageRegisterPackageInstalled(XTaskQueueHandle queue, IntPtr context, XPackageInstalledCallback callback, out XPackageRegisterPackageInstalledToken token)
		{
			token = null;
			return 0;
		}

		public static int XPackageUninstallUWPInstance(string packageName)
		{
			return 0;
		}

		public static bool XPackageUninstallPackage(string packageIdentifier)
		{
			return false;
		}

		public static bool XPackageUnregisterInstallationProgressChanged(XPackageInstallationMonitorHandle installationMonitor, XPackageRegisterInstallationProgressChangedToken token, bool wait)
		{
			return false;
		}

		public static bool XPackageUnregisterInstallationProgressChanged(XPackageInstallationMonitorHandle installationMonitor, XPackageRegisterInstallationProgressChangedToken token)
		{
			return false;
		}

		public static bool XPackageUnregisterPackageInstalled(XPackageRegisterPackageInstalledToken token)
		{
			return false;
		}

		public static bool XPackageUnregisterPackageInstalled(XPackageRegisterPackageInstalledToken token, bool wait)
		{
			return false;
		}

		public static int XPersistentLocalStorageGetPathSize(out ulong pathSize)
		{
			pathSize = default(ulong);
			return 0;
		}

		public static int XPersistentLocalStorageGetPath(ulong pathSize, out string path)
		{
			path = null;
			return 0;
		}

		public static int XPersistentLocalStorageGetSpaceInfo(out XPersistentLocalStorageSpaceInfo spaceInfo)
		{
			spaceInfo = null;
			return 0;
		}

		public static int XPersistentLocalStoragePromptUserForSpaceAsync(ulong requestedBytes, XAsyncBlock asyncBlock)
		{
			return 0;
		}

		public static int XPersistentLocalStoragePromptUserForSpaceResult(XAsyncBlock asyncBlock)
		{
			return 0;
		}

		[AOT.MonoPInvokeCallback(typeof(Unity.XGamingRuntime.Interop.XSpeechSynthesizerInstalledVoicesCallback))]
		private static bool OnSpeechSynthesizerInstalledVoicesCallback(ref Unity.XGamingRuntime.Interop.XSpeechSynthesizerVoiceInformation information, IntPtr context)
		{
			return false;
		}

		public static int XSpeechSynthesizerEnumerateInstalledVoices(IntPtr context, XSpeechSynthesizerInstalledVoicesCallback callback)
		{
			return 0;
		}

		public static int XSpeechSynthesizerCreate(out XSpeechSynthesizerHandle speechSynthesizer)
		{
			speechSynthesizer = null;
			return 0;
		}

		public static int XSpeechSynthesizerCloseHandle(XSpeechSynthesizerHandle speechSynthesizer)
		{
			return 0;
		}

		public static int XSpeechSynthesizerSetDefaultVoice(XSpeechSynthesizerHandle speechSynthesizer)
		{
			return 0;
		}

		public static int XSpeechSynthesizerSetCustomVoice(XSpeechSynthesizerHandle speechSynthesizer, string voiceId)
		{
			return 0;
		}

		public static int XSpeechSynthesizerCreateStreamFromText(XSpeechSynthesizerHandle speechSynthesizer, string text, out XSpeechSynthesizerStreamHandle speechSynthesisStream)
		{
			speechSynthesisStream = null;
			return 0;
		}

		public static int XSpeechSynthesizerCreateStreamFromSsml(XSpeechSynthesizerHandle speechSynthesizer, string ssml, out XSpeechSynthesizerStreamHandle speechSynthesisStream)
		{
			speechSynthesisStream = null;
			return 0;
		}

		public static int XSpeechSynthesizerCloseStreamHandle(XSpeechSynthesizerStreamHandle speechSynthesisStream)
		{
			return 0;
		}

		public static int XSpeechSynthesizerGetStreamDataSize(XSpeechSynthesizerStreamHandle speechSynthesisStream, out ulong bufferSize)
		{
			bufferSize = default(ulong);
			return 0;
		}

		public static int XSpeechSynthesizerGetStreamData(XSpeechSynthesizerStreamHandle speechSynthesisStream, byte[] buffer, out ulong bufferUsed)
		{
			bufferUsed = default(ulong);
			return 0;
		}

		public static int XStoreCreateContext(XUserHandle user, out XStoreContext storeContext)
		{
			storeContext = null;
			return 0;
		}

		public static int XStoreCreateContext(out XStoreContext storeContext)
		{
			storeContext = null;
			return 0;
		}

		public static void XStoreCloseContextHandle(XStoreContext storeContext)
		{
		}

		public static void XStoreCloseLicenseHandle(XStoreLicense storeLicense)
		{
		}

		public static int XStoreAcquireLicenseForDurablesAsync(XStoreContext context, string storeId, XAsyncBlock async)
		{
			return 0;
		}

		public static int XStoreAcquireLicenseForDurablesResult(XAsyncBlock async, out XStoreLicense storeLicense)
		{
			storeLicense = null;
			return 0;
		}

		public static int XStoreAcquireLicenseForPackageAsync(XStoreContext context, string packageIdentifier, XAsyncBlock async)
		{
			return 0;
		}

		public static int XStoreAcquireLicenseForPackageResult(XAsyncBlock async, out XStoreLicense storeLicenseHandle)
		{
			storeLicenseHandle = null;
			return 0;
		}

		public static int XStoreCanAcquireLicenseForStoreIdAsync(XStoreContext storeContext, string storeProductId, XAsyncBlock async)
		{
			return 0;
		}

		public static int XStoreCanAcquireLicenseForStoreIdResult(XAsyncBlock async, out XStoreCanAcquireLicenseResult storeCanAcquireLicenseResult)
		{
			storeCanAcquireLicenseResult = null;
			return 0;
		}

		public static int XStoreCanAcquireLicenseForPackageAsync(XStoreContext storeContext, string packageIdentifier, XAsyncBlock async)
		{
			return 0;
		}

		public static int XStoreCanAcquireLicenseForPackageResult(XAsyncBlock async, out XStoreCanAcquireLicenseResult storeCanAcquireLicenseResult)
		{
			storeCanAcquireLicenseResult = null;
			return 0;
		}

		public static int XStoreQueryProductForCurrentGameAsync(XStoreContext storeContext, XAsyncBlock async)
		{
			return 0;
		}

		public static int XStoreQueryProductForCurrentGameResult(XAsyncBlock async, out XStoreProductQuery productQueryHandle)
		{
			productQueryHandle = null;
			return 0;
		}

		[AOT.MonoPInvokeCallback(typeof(XStoreProductQueryCallbackInterop))]
		private static bool OnProductQueryCallback([In] ref XStoreProductInterop product, IntPtr context)
		{
			return false;
		}

		public static int XStoreEnumerateProductsQuery(XStoreProductQuery productQueryHandle, IntPtr context, XStoreProductQueryCallback callback)
		{
			return 0;
		}

		public static void XStoreCloseProductsQueryHandle(XStoreProductQuery productQueryHandle)
		{
		}

		public static int XStoreDownloadPackageUpdatesAsync(XStoreContext storeContext, string[] packageIdentifiers, XAsyncBlock async)
		{
			return 0;
		}

		public static int XStoreDownloadPackageUpdatesResult(XAsyncBlock async)
		{
			return 0;
		}

		public static int XStoreDownloadAndInstallPackageUpdatesAsync(XStoreContext storeContext, string[] packageIdentifiers, XAsyncBlock async)
		{
			return 0;
		}

		public static int XStoreDownloadAndInstallPackageUpdatesResult(XAsyncBlock async)
		{
			return 0;
		}

		public static int XStoreDownloadAndInstallPackagesAsync(XStoreContext storeContext, string[] storeIds, XAsyncBlock async)
		{
			return 0;
		}

		public static int XStoreDownloadAndInstallPackagesResultCount(XAsyncBlock async, out uint count)
		{
			count = default(uint);
			return 0;
		}

		public static int XStoreDownloadAndInstallPackagesResult(XAsyncBlock async, uint count, out string[] packageIdentifiers)
		{
			packageIdentifiers = null;
			return 0;
		}

		public static int XStoreGetUserCollectionsIdAsync(XStoreContext storeContext, string serviceTicket, string publisherUserId, XAsyncBlock async)
		{
			return 0;
		}

		public static int XStoreGetUserCollectionsIdResultSize(XAsyncBlock async, out ulong size)
		{
			size = default(ulong);
			return 0;
		}

		public static int XStoreGetUserCollectionsIdResult(XAsyncBlock async, ulong size, out string result)
		{
			result = null;
			return 0;
		}

		public static int XStoreGetUserPurchaseIdAsync(XStoreContext storeContext, string serviceTicket, string publisherUserId, XAsyncBlock async)
		{
			return 0;
		}

		public static int XStoreGetUserPurchaseIdResultSize(XAsyncBlock async, out ulong size)
		{
			size = default(ulong);
			return 0;
		}

		public static int XStoreGetUserPurchaseIdResult(XAsyncBlock async, ulong size, out string result)
		{
			result = null;
			return 0;
		}

		public static bool XStoreIsAvailabilityPurchasable(XStoreAvailability availability)
		{
			return false;
		}

		public static bool XStoreIsLicenseValid(XStoreLicense license)
		{
			return false;
		}

		public static bool XStoreProductsQueryHasMorePages(XStoreProductQuery productQueryHandle)
		{
			return false;
		}

		public static int XStoreProductsQueryNextPageAsync(XStoreProductQuery productQueryHandle, XAsyncBlock async)
		{
			return 0;
		}

		public static int XStoreProductsQueryNextPageResult(XAsyncBlock async, out XStoreProductQuery productQueryHandle)
		{
			productQueryHandle = null;
			return 0;
		}

		public static int XStoreQueryAddOnLicensesAsync(XStoreContext storeContext, XAsyncBlock async)
		{
			return 0;
		}

		public static int XStoreQueryAddOnLicensesResultCount(XAsyncBlock async, out uint count)
		{
			count = default(uint);
			return 0;
		}

		public static int XStoreQueryAddOnLicensesResult(XAsyncBlock async, XStoreAddonLicense[] addOnLicenses)
		{
			return 0;
		}

		public static int XStoreQueryAssociatedProductsAsync(XStoreContext storeContext, XStoreProductKind productKinds, uint maxItemsToRetrievePerPage, XAsyncBlock async)
		{
			return 0;
		}

		public static int XStoreQueryAssociatedProductsResult(XAsyncBlock async, out XStoreProductQuery productQueryHandle)
		{
			productQueryHandle = null;
			return 0;
		}

		public static int XStoreQueryConsumableBalanceRemainingAsync(XStoreContext storeContext, string storeProductId, XAsyncBlock async)
		{
			return 0;
		}

		public static int XStoreQueryConsumableBalanceRemainingResult(XAsyncBlock async, out XStoreConsumableResult consumableResult)
		{
			consumableResult = null;
			return 0;
		}

		public static int XStoreQueryEntitledProductsAsync(XStoreContext storeContext, XStoreProductKind productKinds, uint maxItemsToRetrievePerPage, XAsyncBlock async)
		{
			return 0;
		}

		public static int XStoreQueryEntitledProductsResult(XAsyncBlock async, out XStoreProductQuery productQueryHandle)
		{
			productQueryHandle = null;
			return 0;
		}

		public static int XStoreQueryGameAndDlcPackageUpdatesAsync(XStoreContext storeContext, XAsyncBlock async)
		{
			return 0;
		}

		public static int XStoreQueryGameAndDlcPackageUpdatesResultCount(XAsyncBlock async, out uint count)
		{
			count = default(uint);
			return 0;
		}

		public static int XStoreQueryGameAndDlcPackageUpdatesResult(XAsyncBlock async, XStorePackageUpdate[] packageUpdates)
		{
			return 0;
		}

		public static int XStoreQueryGameLicenseAsync(XStoreContext storeContext, XAsyncBlock async)
		{
			return 0;
		}

		public static int XStoreQueryGameLicenseResult(XAsyncBlock async, out XStoreGameLicense license)
		{
			license = null;
			return 0;
		}

		public static int XStoreQueryLicenseTokenAsync(XStoreContext storeContext, string[] productIds, string customDeveloperString, XAsyncBlock async)
		{
			return 0;
		}

		public static int XStoreQueryLicenseTokenResultSize(XAsyncBlock async, out ulong size)
		{
			size = default(ulong);
			return 0;
		}

		public static int XStoreQueryLicenseTokenResult(XAsyncBlock async, ulong size, out string result)
		{
			result = null;
			return 0;
		}

		public static int XStoreQueryPackageIdentifier(string storeId, ulong size, out string packageIdentifier)
		{
			packageIdentifier = null;
			return 0;
		}

		public static int XStoreQueryPackageIdentifier(string storeId, out string packageIdentifier)
		{
			packageIdentifier = null;
			return 0;
		}

		public static int XStoreQueryProductForPackageAsync(XStoreContext storeContext, XStoreProductKind productKinds, string packageIdentifier, XAsyncBlock async)
		{
			return 0;
		}

		public static int XStoreQueryProductForPackageResult(XAsyncBlock async, out XStoreProductQuery productQueryHandle)
		{
			productQueryHandle = null;
			return 0;
		}

		public static int XStoreQueryProductsAsync(XStoreContext storeContext, XStoreProductKind productKinds, string[] storeIds, string[] actionFilters, XAsyncBlock async)
		{
			return 0;
		}

		public static int XStoreQueryProductsResult(XAsyncBlock async, out XStoreProductQuery productQueryHandle)
		{
			productQueryHandle = null;
			return 0;
		}

		public static int XStoreRegisterGameLicenseChanged(XStoreContext storeContext, XTaskQueueHandle queue, IntPtr context, XStoreGameLicenseChangedCallback callback, out GameLicenseChangedCallbackToken token)
		{
			token = null;
			return 0;
		}

		public static bool XStoreUnregisterGameLicenseChanged(GameLicenseChangedCallbackToken token, bool wait)
		{
			return false;
		}

		public static int XStoreRegisterPackageLicenseLost(XStoreLicense licenseHandle, XTaskQueueHandle queue, IntPtr context, XStorePackageLicenseLostCallback callback, out PackageLicenseLostCallbackToken token)
		{
			token = null;
			return 0;
		}

		public static bool XStoreUnregisterPackageLicenseLost(PackageLicenseLostCallbackToken token, bool wait)
		{
			return false;
		}

		public static bool XStoreUnregisterPackageLicenseLost(PackageLicenseLostCallbackToken token)
		{
			return false;
		}

		public static int XStoreReportConsumableFulfillmentAsync(XStoreContext storeContext, string storeProductId, uint quantity, Guid trackingId, XAsyncBlock async)
		{
			return 0;
		}

		public static int XStoreReportConsumableFulfillmentResult(XAsyncBlock async, out XStoreConsumableResult consumableResult)
		{
			consumableResult = null;
			return 0;
		}

		public static int XStoreShowAssociatedProductsUIAsync(XStoreContext storeContext, string storeId, XStoreProductKind productKinds, XAsyncBlock async)
		{
			return 0;
		}

		public static int XStoreShowAssociatedProductsUIResult(XAsyncBlock async)
		{
			return 0;
		}

		public static int XStoreShowProductPageUIAsync(XStoreContext storeContext, string storeId, XAsyncBlock async)
		{
			return 0;
		}

		public static int XStoreShowProductPageUIResult(XAsyncBlock async)
		{
			return 0;
		}

		public static int XStoreShowPurchaseUIAsync(XStoreContext storeContext, string storeId, string name, string extendedJsonData, XAsyncBlock async)
		{
			return 0;
		}

		public static int XStoreShowPurchaseUIResult(XAsyncBlock async)
		{
			return 0;
		}

		public static int XStoreShowRateAndReviewUIAsync(XStoreContext storeContext, XAsyncBlock async)
		{
			return 0;
		}

		public static int XStoreShowRateAndReviewUIResult(XAsyncBlock async, out XStoreRateAndReviewResult result)
		{
			result = null;
			return 0;
		}

		public static int XStoreShowRedeemTokenUIAsync(XStoreContext storeContext, string token, string[] allowedStoreIds, bool disallowCsvRedemption, XAsyncBlock async)
		{
			return 0;
		}

		public static int XStoreShowRedeemTokenUIResult(XAsyncBlock async)
		{
			return 0;
		}

		public static XSystemAnalyticsInfo XSystemGetAnalyticsInfo()
		{
			return null;
		}

		public static int XSystemGetAppSpecificDeviceId(out string appSpecificDeviceId)
		{
			appSpecificDeviceId = null;
			return 0;
		}

		public static int XSystemGetConsoleId(out string consoleId)
		{
			consoleId = null;
			return 0;
		}

		public static XSystemDeviceType XSystemGetDeviceType()
		{
			return default(XSystemDeviceType);
		}

		public static int XSystemGetXboxLiveSandboxId(out string sandboxId)
		{
			sandboxId = null;
			return 0;
		}

		public static XSystemRuntimeInfo XSystemGetRuntimeInfo()
		{
			return null;
		}

		public static bool XSystemIsHandleValid(IntPtr handle)
		{
			return false;
		}

		public static int XSystemHandleTrack(XSystemHandleCallback callback, IntPtr context, out XSystemHandleCallbackHandle handle)
		{
			handle = null;
			return 0;
		}

		public static void XTaskQueueCloseHandle(XTaskQueueHandle queue)
		{
		}

		public static int XTaskQueueCreate(XTaskQueueDispatchMode workDispatchMode, XTaskQueueDispatchMode completionDispatchMode, out XTaskQueueHandle handle)
		{
			handle = null;
			return 0;
		}

		public static int XTaskQueueCreateComposite(XTaskQueuePortHandle workPort, XTaskQueuePortHandle completionPort, out XTaskQueueHandle queue)
		{
			queue = null;
			return 0;
		}

		public static bool XTaskQueueDispatch(XTaskQueueHandle queue, XTaskQueuePort port, uint timeoutInMs)
		{
			return false;
		}

		public static int XTaskQueueDuplicateHandle(XTaskQueueHandle queue, out XTaskQueueHandle duplicatedHandle)
		{
			duplicatedHandle = null;
			return 0;
		}

		public static bool XTaskQueueGetCurrentProcessTaskQueue(out XTaskQueueHandle queue)
		{
			queue = null;
			return false;
		}

		public static int XTaskQueueGetPort(XTaskQueueHandle queue, XTaskQueuePort port, out XTaskQueuePortHandle portHandle)
		{
			portHandle = null;
			return 0;
		}

		public static int XTaskQueueRegisterMonitor(XTaskQueueHandle queue, IntPtr callbackContext, XTaskQueueMonitorCallback callback, out XTaskQueueMonitorCallbackHandle tokenHandle)
		{
			tokenHandle = null;
			return 0;
		}

		public static int XTaskQueueRegisterWaiter(XTaskQueueHandle queue, XTaskQueuePort port, WaitHandle waitHandle, IntPtr callbackContext, XTaskQueueCallback callback, out XTaskQueueWaiterCallbackHandle tokenHandle)
		{
			tokenHandle = null;
			return 0;
		}

		public static void XTaskQueueSetCurrentProcessTaskQueue(XTaskQueueHandle queue)
		{
		}

		public static int XTaskQueueSubmitCallback(XTaskQueueHandle queue, XTaskQueuePort port, IntPtr callbackContext, XTaskQueueCallback callback, out XTaskQueueCallbackHandle callbackHandle)
		{
			callbackHandle = null;
			return 0;
		}

		public static int XTaskQueueSubmitDelayedCallback(XTaskQueueHandle queue, XTaskQueuePort port, uint delayMs, IntPtr callbackContext, XTaskQueueCallback callback, out XTaskQueueCallbackHandle callbackHandle)
		{
			callbackHandle = null;
			return 0;
		}

		public static int XTaskQueueTerminate(XTaskQueueHandle queue, bool wait, IntPtr callbackContext, XTaskQueueTerminatedCallback callback, out XTaskQueueTerminateCallbackHandle callbackHandle)
		{
			callbackHandle = null;
			return 0;
		}

		public static int XTaskQueueTerminate(XTaskQueueHandle queue, bool wait, IntPtr callbackContext)
		{
			return 0;
		}

		public static void XTaskQueueUnregisterMonitor(XTaskQueueHandle queue, XTaskQueueMonitorCallbackHandle token)
		{
		}

		public static void XTaskQueueUnregisterWaiter(XTaskQueueHandle queue, XTaskQueueWaiterCallbackHandle token)
		{
		}

		public static void XThreadAssertNotTimeSensitive()
		{
		}

		public static bool XThreadIsTimeSensitive()
		{
			return false;
		}

		public static int XThreadSetTimeSensitive(bool isTimeSensitiveThread)
		{
			return 0;
		}

		public static int XUserAddAsync(XUserAddOptions options, XAsyncBlock async)
		{
			return 0;
		}

		public static int XUserAddResult(XAsyncBlock async, out XUserHandle newUser)
		{
			newUser = null;
			return 0;
		}

		public static int XUserAddByIdWithUiAsync(ulong userId, XAsyncBlock async)
		{
			return 0;
		}

		public static int XUserAddByIdWithUiResult(XAsyncBlock async, out XUserHandle newUser)
		{
			newUser = null;
			return 0;
		}

		public static int XUserCheckPrivilege(XUserHandle user, XUserPrivilegeOptions options, XUserPrivilege privilege, out bool hasPrivilege, out XUserPrivilegeDenyReason reason)
		{
			hasPrivilege = default(bool);
			reason = default(XUserPrivilegeDenyReason);
			return 0;
		}

		public static void XUserCloseHandle(XUserHandle user)
		{
		}

		public static int XUserCloseSignOutDeferralHandle(XUserSignOutDeferralHandle deferral)
		{
			return 0;
		}

		public static int XUserCompare(XUserHandle user1, XUserHandle user2)
		{
			return 0;
		}

		public static int XUserCompare(XUserHandle user1, XUserHandle user2, out int comparisonResult)
		{
			comparisonResult = default(int);
			return 0;
		}

		public static int XUserDuplicateHandle(XUserHandle handle, out XUserHandle duplicatedHandle)
		{
			duplicatedHandle = null;
			return 0;
		}

		public static int XUserFindControllerForUserWithUiAsync(XUserHandle user, XAsyncBlock async)
		{
			return 0;
		}

		public static int XUserFindControllerForUserWithUiResult(XAsyncBlock async, out APP_LOCAL_DEVICE_ID deviceId)
		{
			deviceId = null;
			return 0;
		}

		public static int XUserFindForDevice(APP_LOCAL_DEVICE_ID deviceId, out XUserHandle handle)
		{
			handle = null;
			return 0;
		}

		public static int XUserFindUserById(ulong userId, out XUserHandle handle)
		{
			handle = null;
			return 0;
		}

		public static int XUserFindUserByLocalId(XUserLocalId userLocalId, out XUserHandle handle)
		{
			handle = null;
			return 0;
		}

		public static int XUserGetAgeGroup(XUserHandle user, out XUserAgeGroup ageGroup)
		{
			ageGroup = default(XUserAgeGroup);
			return 0;
		}

		public static int XUserGetDefaultAudioEndpointUtf16(XUserLocalId user, XUserDefaultAudioEndpointKind defaultAudioEndpointKind, ulong endpointIdUtf16Count, char[] endpointIdUtf16, out ulong endpointIdUtf16Used)
		{
			endpointIdUtf16Used = default(ulong);
			return 0;
		}

		public static int XUserGetGamerPictureAsync(XUserHandle user, XUserGamerPictureSize pictureSize, XAsyncBlock async)
		{
			return 0;
		}

		public static int XUserGetGamerPictureResultSize(XAsyncBlock async, out ulong bufferSize)
		{
			bufferSize = default(ulong);
			return 0;
		}

		public static int XUserGetGamerPictureResult(XAsyncBlock async, byte[] buffer, out ulong bufferUsed)
		{
			bufferUsed = default(ulong);
			return 0;
		}

		public static int XUserGetGamertag(XUserHandle user, XUserGamertagComponent gamertagComponent, StringBuilder gamertag, out ulong gamertagUsed)
		{
			gamertagUsed = default(ulong);
			return 0;
		}

		public static int XUserGetId(XUserHandle user, out ulong userId)
		{
			userId = default(ulong);
			return 0;
		}

		public static int XUserGetIsGuest(XUserHandle user, out bool isGuest)
		{
			isGuest = default(bool);
			return 0;
		}

		public static int XUserGetLocalId(XUserHandle user, out XUserLocalId userLocalId)
		{
			userLocalId = null;
			return 0;
		}

		public static int XUserGetMaxUsers(out uint maxUsers)
		{
			maxUsers = default(uint);
			return 0;
		}

		public static int XUserGetSignOutDeferral(out XUserSignOutDeferralHandle deferral)
		{
			deferral = null;
			return 0;
		}

		public static int XUserGetState(XUserHandle user, out XUserState state)
		{
			state = default(XUserState);
			return 0;
		}

		public static int XUserGetTokenAndSignatureAsync(XUserHandle user, XUserGetTokenAndSignatureOptions options, string method, string url, XUserGetTokenAndSignatureHttpHeader[] headers, byte[] bodyBuffer, XAsyncBlock async)
		{
			return 0;
		}

		public static int XUserGetTokenAndSignatureResultSize(XAsyncBlock async, out ulong bufferSize)
		{
			bufferSize = default(ulong);
			return 0;
		}

		public static int XUserGetTokenAndSignatureResult(XAsyncBlock async, byte[] buffer, out XUserGetTokenAndSignatureData result)
		{
			result = null;
			return 0;
		}

		public static int XUserGetTokenAndSignatureUtf16Async(XUserHandle user, XUserGetTokenAndSignatureOptions options, string method, string url, XUserGetTokenAndSignatureUtf16HttpHeader[] headers, byte[] bodyBuffer, XAsyncBlock async)
		{
			return 0;
		}

		public static int XUserGetTokenAndSignatureUtf16ResultSize(XAsyncBlock async, out ulong bufferSize)
		{
			bufferSize = default(ulong);
			return 0;
		}

		public static int XUserGetTokenAndSignatureUtf16Result(XAsyncBlock async, byte[] buffer, out XUserGetTokenAndSignatureUtf16Data result)
		{
			result = null;
			return 0;
		}

		public static bool XUserIsStoreUser(XUserHandle user)
		{
			return false;
		}

		public static int XUserRegisterForChangeEvent(XTaskQueueHandle queue, IntPtr context, XUserChangeEventCallback callback, out XUserChangeRegistrationToken token)
		{
			token = null;
			return 0;
		}

		public static int XUserRegisterForDefaultAudioEndpointUtf16Changed(XTaskQueueHandle queue, IntPtr context, XUserDefaultAudioEndpointUtf16ChangedCallback callback, out XUserDefaultAudioEndpointUtf16RegistrationToken token)
		{
			token = null;
			return 0;
		}

		public static int XUserRegisterForDeviceAssociationChanged(XTaskQueueHandle queue, IntPtr context, XUserDeviceAssociationChangedCallback callback, out XUserDeviceAssociationChangedRegistrationToken token)
		{
			token = null;
			return 0;
		}

		public static int XUserResolveIssueWithUiAsync(XUserHandle user, string url, XAsyncBlock async)
		{
			return 0;
		}

		public static int XUserResolveIssueWithUiResult(XAsyncBlock async)
		{
			return 0;
		}

		public static int XUserResolveIssueWithUiUtf16Async(XUserHandle user, string url, XAsyncBlock async)
		{
			return 0;
		}

		public static int XUserResolveIssueWithUiUtf16Result(XAsyncBlock async)
		{
			return 0;
		}

		public static int XUserResolvePrivilegeWithUiAsync(XUserHandle user, XUserPrivilegeOptions options, XUserPrivilege privilege, XAsyncBlock async)
		{
			return 0;
		}

		public static int XUserResolvePrivilegeWithUiResult(XAsyncBlock async)
		{
			return 0;
		}

		public static bool XUserUnregisterForChangeEvent(XUserChangeRegistrationToken token, bool wait)
		{
			return false;
		}

		public static bool XUserUnregisterForChangeEvent(XUserChangeRegistrationToken token)
		{
			return false;
		}

		public static bool XUserUnregisterForDefaultAudioEndpointUtf16Changed(XUserDefaultAudioEndpointUtf16RegistrationToken token, bool wait)
		{
			return false;
		}

		public static bool XUserUnregisterForDeviceAssociationChanged(XUserDeviceAssociationChangedRegistrationToken token, bool wait)
		{
			return false;
		}
	}
}
