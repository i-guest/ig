using System;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.Win32.SafeHandles;

namespace Unity.XGamingRuntime.Interop
{
	internal class NativeMethods
	{
		internal const int MAX_PATH = 260;

		internal const int APPCAPTURE_MAX_CAPTURE_FILES = 10;

		internal const int APPCAPTURE_MAX_LOCALID_LENGTH = 250;

		[PreserveSig]
		internal static extern int XClosedCaptionGetProperties(out XClosedCaptionProperties properties);

		[PreserveSig]
		internal static extern int XClosedCaptionSetEnabled(bool enabled);

		[PreserveSig]
		internal static extern int XHighContrastGetMode(out XHighContrastMode mode);

		[PreserveSig]
		internal static extern int XSpeechToTextSetPositionHint(XSpeechToTextPositionHint position);

		[PreserveSig]
		internal static extern int XSpeechToTextSendString(string speakerName, string content, XSpeechToTextType type);

		[PreserveSig]
		internal static extern int XSpeechToTextBeginHypothesisString(string speakerName, string content, XSpeechToTextType type, out uint hypothesisId);

		[PreserveSig]
		internal static extern int XSpeechToTextUpdateHypothesisString(uint hypothesisId, string content);

		[PreserveSig]
		internal static extern int XSpeechToTextFinalizeHypothesisString(uint hypothesisId, string content);

		[PreserveSig]
		internal static extern int XSpeechToTextCancelHypothesisString(uint hypothesisId);

		[PreserveSig]
		internal static extern int XAppBroadcastGetStatus(IntPtr requestingUser, out XAppBroadcastStatus appBroadcastStatus);

		[PreserveSig]
		internal static extern bool XAppBroadcastIsAppBroadcasting();

		[PreserveSig]
		internal static extern int XAppBroadcastShowUI(IntPtr requestingUser);

		[PreserveSig]
		internal static extern int XAppBroadcastRegisterIsAppBroadcastingChanged(IntPtr queue, IntPtr context, XAppBroadcastMonitorCallback appBroadcastMonitorCallback, out ulong token);

		[PreserveSig]
		internal static extern int XAppCaptureCloseScreenshotStream(IntPtr handle);

		[PreserveSig]
		internal static extern int XAppCaptureEnableRecord();

		[PreserveSig]
		internal static extern int XAppCaptureDisableRecord();

		[PreserveSig]
		internal static extern bool XAppBroadcastUnregisterIsAppBroadcastingChanged(ulong token, bool wait);

		[PreserveSig]
		internal static extern int XAppCaptureMetadataAddStringEvent(string name, string value, XAppCaptureMetadataPriority priority);

		[PreserveSig]
		internal static extern int XAppCaptureMetadataAddInt32Event(string name, int value, XAppCaptureMetadataPriority priority);

		[PreserveSig]
		internal static extern int XAppCaptureMetadataAddDoubleEvent(string name, double value, XAppCaptureMetadataPriority priority);

		[PreserveSig]
		internal static extern int XAppCaptureMetadataStartStringState(string name, string value, XAppCaptureMetadataPriority priority);

		[PreserveSig]
		internal static extern int XAppCaptureMetadataStartInt32State(string name, int value, XAppCaptureMetadataPriority priority);

		[PreserveSig]
		internal static extern int XAppCaptureMetadataStartDoubleState(string name, double value, XAppCaptureMetadataPriority priority);

		[PreserveSig]
		internal static extern int XAppCaptureMetadataStopState(string name);

		[PreserveSig]
		internal static extern int XAppCaptureMetadataStopAllStates();

		[PreserveSig]
		internal static extern int XAppCaptureMetadataRemainingStorageBytesAvailable(out ulong value);

		[PreserveSig]
		internal static extern int XAppCaptureOpenScreenshotStream(string localId, XAppCaptureScreenshotFormatFlag screenshotFormat, out IntPtr handle, out ulong totalBytes);

		[PreserveSig]
		internal static extern int XAppCaptureReadScreenshotStream(IntPtr handle, ulong startPosition, uint bytesToRead, [In][Out] byte[] buffer, out uint bytesWritten);

		[PreserveSig]
		internal static extern int XAppCaptureRecordDiagnosticClip(long startTime, uint durationInMs, string filenamePrefix, out XAppCaptureRecordClipResult result);

		[PreserveSig]
		internal static extern int XAppCaptureTakeDiagnosticScreenshot(bool gamescreenOnly, XAppCaptureScreenshotFormatFlag captureFlags, string filenamePrefix, out XAppCaptureDiagnosticScreenshotResult result);

		[PreserveSig]
		internal static extern int XAppCaptureTakeScreenshot(IntPtr requestingUser, out XAppCaptureTakeScreenshotResult result);

		[PreserveSig]
		internal static extern int XAppCaptureRegisterMetadataPurged(IntPtr queue, IntPtr context, XAppCaptureMetadataPurgedCallback callback, out ulong token);

		[PreserveSig]
		internal static extern bool XAppCaptureUnRegisterMetadataPurged(ulong token, bool wait);

		[PreserveSig]
		internal static extern int XAppCaptureReadLocalStream(IntPtr handle, long startPosition, uint bytesToRead, [In][Out] byte[] buffer, out uint bytesWritten);

		[PreserveSig]
		internal static extern int XAppCaptureCloseLocalStream(IntPtr handle);

		[PreserveSig]
		internal static extern int XAppCaptureRecordTimespan(IntPtr startTimestamp, ulong durationInMilliseconds, out XAppCaptureLocalResult result);

		[PreserveSig]
		internal static extern int XAppCaptureGetVideoCaptureSettings(out XAppCaptureVideoCaptureSettings userCaptureSettings);

		[PreserveSig]
		internal static extern int XAsyncGetStatus(IntPtr asyncBlock, bool wait);

		[PreserveSig]
		internal static extern int XAsyncGetResultSize(IntPtr asyncBlock, out ulong bufferSize);

		[PreserveSig]
		internal static extern void XAsyncCancel(IntPtr asyncBlock);

		[PreserveSig]
		internal static extern int XAsyncRun(IntPtr asyncBlock, XAsyncWorkInterop work);

		[PreserveSig]
		internal static extern int XAsyncBegin(IntPtr asyncInterop, IntPtr context, IntPtr identity, string identityName, XAsyncProviderInterop provider);

		[PreserveSig]
		internal static extern int XAsyncSchedule(IntPtr asyncInterop, uint delayInMs);

		[PreserveSig]
		internal static extern void XAsyncComplete(IntPtr asyncInterop, uint result, ulong requiredBufferSize);

		[PreserveSig]
		internal static extern int XAsyncGetResult(IntPtr asyncInterop, IntPtr identity, ulong bufferSize, [In][Out] byte[] buffer, out ulong bufferUsed);

		[PreserveSig]
		internal static extern XDisplayHdrModeResult XDisplayTryEnableHdrMode(XDisplayHdrModePreference displayModePreference, out XDisplayHdrModeInfo displayHdrModeInfo);

		[PreserveSig]
		internal static extern int XDisplayAcquireTimeoutDeferral(out IntPtr handle);

		[PreserveSig]
		internal static extern int XDisplayCloseTimeoutDeferralHandle(IntPtr handle);

		[PreserveSig]
		internal static extern void XErrorSetCallback(XErrorCallback callback, IntPtr context);

		[PreserveSig]
		internal static extern void XErrorSetOptions(XErrorOptions optionsDebuggerPresent, XErrorOptions optionsDebuggerNotPresent);

		[PreserveSig]
		internal static extern int XGameEventWrite(IntPtr user, string serviceConfigId, string playSessionId, string eventName, string dimensionsJson, string measurementsJson);

		[PreserveSig]
		internal static extern int XGameGetXboxTitleId(out uint titleId);

		[PreserveSig]
		internal static extern void XLaunchNewGame(string exePath, string args, IntPtr defaultUser);

		[PreserveSig]
		internal static extern int XLaunchRestartOnCrash(string args, uint reserved);

		[PreserveSig]
		internal static extern int XGameInviteRegisterForEvent(IntPtr queue, IntPtr context, XGameInviteEventCallback callback, out ulong token);

		[PreserveSig]
		internal static extern bool XGameInviteUnregisterForEvent(ulong token, bool wait);

		[PreserveSig]
		internal static extern int XGameProtocolRegisterForActivation(IntPtr queue, IntPtr context, XGameProtocolActivationCallback callback, out ulong token);

		[PreserveSig]
		internal static extern bool XGameProtocolUnregisterForActivation(ulong token, bool wait);

		[PreserveSig]
		internal static extern bool XGameRuntimeIsFeatureAvailable(XGameRuntimeFeature feature);

		[PreserveSig]
		internal static extern int XGameRuntimeInitialize();

		[PreserveSig]
		internal static extern int XGameRuntimeInitializeWithOptions(XGameRuntimeOptions options);

		[PreserveSig]
		internal static extern void XGameRuntimeUninitialize();

		[PreserveSig]
		internal static extern int XGameSaveFilesGetFolderWithUiAsync(IntPtr requestingUser, string configurationId, IntPtr async);

		[PreserveSig]
		internal static extern int XGameSaveFilesGetFolderWithUiResult(IntPtr async, ulong folderSize, StringBuilder folderResult);

		[PreserveSig]
		internal static extern int XGameSaveFilesGetRemainingQuota(IntPtr userContext, string configurationId, out ulong remainingQuota);

		[PreserveSig]
		internal static extern int XGameSaveInitializeProvider(IntPtr requestingUser, string configurationId, bool syncOnDemand, out IntPtr provider);

		[PreserveSig]
		internal static extern int XGameSaveInitializeProviderAsync(IntPtr requestingUser, string configurationId, bool syncOnDemand, IntPtr async);

		[PreserveSig]
		internal static extern int XGameSaveInitializeProviderResult(IntPtr async, out IntPtr provider);

		[PreserveSig]
		internal static extern void XGameSaveCloseProvider(IntPtr provider);

		[PreserveSig]
		internal static extern int XGameSaveGetRemainingQuota(IntPtr provider, out long remainingQuota);

		[PreserveSig]
		internal static extern int XGameSaveGetRemainingQuotaAsync(IntPtr provider, IntPtr xAsyncBlockInterop);

		[PreserveSig]
		internal static extern int XGameSaveGetRemainingQuotaResult(IntPtr async, out long remainingQuota);

		[PreserveSig]
		internal static extern int XGameSaveDeleteContainer(IntPtr provider, string containerName);

		[PreserveSig]
		internal static extern int XGameSaveDeleteContainerAsync(IntPtr provider, string containerName, IntPtr async);

		[PreserveSig]
		internal static extern int XGameSaveDeleteContainerResult(IntPtr async);

		[PreserveSig]
		internal static extern int XGameSaveGetContainerInfo(IntPtr provider, string containerName, IntPtr context, XGameSaveContainerInfoCallback callback);

		[PreserveSig]
		internal static extern int XGameSaveEnumerateContainerInfo(IntPtr provider, IntPtr context, XGameSaveContainerInfoCallback callback);

		[PreserveSig]
		internal static extern int XGameSaveEnumerateContainerInfoByName(IntPtr provider, string containerNamePrefix, IntPtr context, XGameSaveContainerInfoCallback callback);

		[PreserveSig]
		internal static extern int XGameSaveCreateContainer(IntPtr provider, string containerName, out IntPtr containerContext);

		[PreserveSig]
		internal static extern void XGameSaveCloseContainer(IntPtr context);

		[PreserveSig]
		internal static extern int XGameSaveEnumerateBlobInfo(IntPtr container, IntPtr context, XGameSaveBlobInfoCallback callback);

		[PreserveSig]
		internal static extern int XGameSaveEnumerateBlobInfoByName(IntPtr container, string blobNamePrefix, IntPtr context, XGameSaveBlobInfoCallback callback);

		[PreserveSig]
		internal static extern int XGameSaveReadBlobData(IntPtr container, string[] blobNames, ref uint countOfBlobs, ulong blobsSize, IntPtr blobData);

		[PreserveSig]
		internal static extern int XGameSaveReadBlobDataAsync(IntPtr container, string[] blobNames, uint countOfBlobs, IntPtr async);

		[PreserveSig]
		internal static extern int XGameSaveReadBlobDataResult(IntPtr async, ulong blobsSize, IntPtr blobData, out uint countOfBlobs);

		[PreserveSig]
		internal static extern int XGameSaveCreateUpdate(IntPtr container, string containerDisplayName, out IntPtr updateContext);

		[PreserveSig]
		internal static extern int XGameSaveCloseUpdate(IntPtr context);

		[PreserveSig]
		internal static extern int XGameSaveSubmitBlobWrite(IntPtr updateContext, string blobName, [In][Out] byte[] data, ulong byteCount);

		[PreserveSig]
		internal static extern int XGameSaveSubmitBlobDelete(IntPtr updateContext, string blobName);

		[PreserveSig]
		internal static extern int XGameSaveSubmitUpdate(IntPtr updateContext);

		[PreserveSig]
		internal static extern int XGameSaveSubmitUpdateAsync(IntPtr updateContext, IntPtr async);

		[PreserveSig]
		internal static extern int XGameSaveSubmitUpdateResult(IntPtr async);

		[PreserveSig]
		internal static extern int XGameStreamingInitialize();

		[PreserveSig]
		internal static extern void XGameStreamingUninitialize();

		[PreserveSig]
		internal static extern bool XGameStreamingIsStreaming();

		[PreserveSig]
		internal static extern uint XGameStreamingGetClientCount();

		[PreserveSig]
		internal static extern int XGameStreamingGetClients(uint clientCount, [In][Out] XGameStreamingClientId[] clients, out uint clientUsed);

		[PreserveSig]
		internal static extern XGameStreamingConnectionState XGameStreamingGetConnectionState(XGameStreamingClientId client);

		[PreserveSig]
		internal static extern int XGameStreamingRegisterConnectionStateChanged(IntPtr queue, IntPtr context, XGameStreamingConnectionStateChangedCallback callback, out ulong token);

		[PreserveSig]
		internal static extern bool XGameStreamingUnregisterConnectionStateChanged(ulong token, bool wait);

		[PreserveSig]
		internal static extern void XGameStreamingHideTouchControls();

		[PreserveSig]
		internal static extern void XGameStreamingHideTouchControlsOnClient(XGameStreamingClientId client);

		[PreserveSig]
		internal static extern void XGameStreamingShowTouchControlLayout(string layout);

		[PreserveSig]
		internal static extern void XGameStreamingShowTouchControlLayoutOnClient(XGameStreamingClientId client, string layout);

		[PreserveSig]
		internal static extern int XGameStreamingRegisterClientPropertiesChanged(XGameStreamingClientId client, IntPtr queue, IntPtr context, XGameStreamingClientPropertiesChangedCallback callback, out ulong token);

		[PreserveSig]
		internal static extern bool XGameStreamingUnregisterClientPropertiesChanged(XGameStreamingClientId client, ulong token, bool wait);

		[PreserveSig]
		internal static extern int XGameStreamingGetStreamPhysicalDimensions(XGameStreamingClientId client, out uint horizontalMm, out uint verticalMm);

		[PreserveSig]
		internal static extern int XGameStreamingGetStreamAddedLatency(XGameStreamingClientId client, out uint averageInputLatencyUs, out uint averageOutputLatencyUs, out uint standardDeviationUs);

		[PreserveSig]
		internal static extern ulong XGameStreamingGetServerLocationNameSize();

		[PreserveSig]
		internal static extern int XGameStreamingGetServerLocationName(ulong serverLocationNameSize, StringBuilder serverLocationName);

		[PreserveSig]
		internal static extern int XGameStreamingIsTouchInputEnabled(XGameStreamingClientId client, out bool touchInputEnabled);

		[PreserveSig]
		internal static extern int XGameStreamingGetLastFrameDisplayed(XGameStreamingClientId client, out ulong framePipelineToken);

		[PreserveSig]
		internal static extern int XGameStreamingGetAssociatedFrame(IntPtr gamepadReading, out ulong framePipelineToken);

		[PreserveSig]
		internal static extern int XGameStreamingGetGamepadPhysicality(IntPtr gamepadReading, out XGameStreamingGamepadPhysicality gamepadPhysicality);

		[PreserveSig]
		internal static extern int XGameStreamingUpdateTouchControlsState(ulong operationCount, XGameStreamingTouchControlsStateOperation[] operations);

		[PreserveSig]
		internal static extern int XGameStreamingUpdateTouchControlsStateOnClient(XGameStreamingClientId client, ulong operationCount, XGameStreamingTouchControlsStateOperation[] operations);

		[PreserveSig]
		internal static extern int XGameStreamingShowTouchControlsWithStateUpdate(string layout, ulong operatoinCount, XGameStreamingTouchControlsStateOperation[] operations);

		[PreserveSig]
		internal static extern int XGameStreamingShowTouchControlsWithStateUpdateOnClient(XGameStreamingClientId client, string layout, ulong operationCount, XGameStreamingTouchControlsStateOperation[] operations);

		[PreserveSig]
		internal static extern ulong XGameStreamingGetTouchBundleVersionNameSize(XGameStreamingClientId client);

		[PreserveSig]
		internal static extern int XGameStreamingGetTouchBundleVersion(XGameStreamingClientId client, out XVersion version, ulong versionNameSize, StringBuilder versionName);

		[PreserveSig]
		internal static extern int XGameStreamingGetClientIPAddress(XGameStreamingClientId client, ulong ipAddressSize, StringBuilder ipAddress);

		[PreserveSig]
		internal static extern int XGameStreamingGetSessionId(XGameStreamingClientId client, ulong sessionIdSize, StringBuilder sessionId, out ulong sessionIdUsed);

		[PreserveSig]
		internal static extern int XGameStreamingGetDisplayDetails(XGameStreamingClientId clientId, uint maxSupportedPixels, float widestSupportedAspectRatio, float tallestSupportedAspectRatio, out XGameStreamingDisplayDetails displayDetails);

		[PreserveSig]
		internal static extern int XGameStreamingSetResolution(uint width, uint height);

		[PreserveSig]
		internal static extern int XGameUiShowMessageDialogAsync(IntPtr async, string titleText, string contextText, string firstButtonText, string secondButtonText, string thirdButtonText, XGameUiMessageDialogButton defaultButton, XGameUiMessageDialogButton cancelButton);

		[PreserveSig]
		internal static extern int XGameUiShowMessageDialogResult(IntPtr async, out XGameUiMessageDialogButton resultButton);

		[PreserveSig]
		internal static extern int XGameUiShowSendGameInviteAsync(IntPtr async, IntPtr requestingUser, string sessionConfigurationId, string sessionTemplateName, string sessionId, string invitationText, string customActivationContext);

		[PreserveSig]
		internal static extern int XGameUiShowSendGameInviteResult(IntPtr async);

		[PreserveSig]
		internal static extern int XGameUiShowMultiplayerActivityGameInviteAsync(IntPtr async, IntPtr requestingUser);

		[PreserveSig]
		internal static extern int XGameUiShowMultiplayerActivityGameInviteResult(IntPtr async);

		[PreserveSig]
		internal static extern int XGameUiShowPlayerProfileCardAsync(IntPtr async, IntPtr requestingUser, ulong targetPlayer);

		[PreserveSig]
		internal static extern int XGameUiShowPlayerProfileCardResult(IntPtr async);

		[PreserveSig]
		internal static extern int XGameUiShowAchievementsAsync(IntPtr async, IntPtr requestingUser, uint titleId);

		[PreserveSig]
		internal static extern int XGameUiShowAchievementsResult(IntPtr async);

		[PreserveSig]
		internal static extern int XGameUiShowPlayerPickerAsync(IntPtr async, IntPtr requestingUser, string promptText, uint selectFromPlayersCount, ulong[] selectFromPlayers, uint preSelectedPlayersCount, ulong[] preSelectedPlayers, uint minSelectionCount, uint maxSelectionCount);

		[PreserveSig]
		internal static extern int XGameUiShowPlayerPickerResultCount(IntPtr async, out uint resultPlayersCount);

		[PreserveSig]
		internal static extern int XGameUiShowPlayerPickerResult(IntPtr async, uint resultPlayersCount, ulong[] resultPlayers, out uint resultPlayerUsed);

		[PreserveSig]
		internal static extern int XGameUiShowErrorDialogAsync(IntPtr async, int errorCode, string context);

		[PreserveSig]
		internal static extern int XGameUiShowErrorDialogResult(IntPtr async);

		[PreserveSig]
		internal static extern int XGameUiSetNotificationPositionHint(XGameUiNotificationPositionHint position);

		[PreserveSig]
		internal static extern int XGameUiShowTextEntryAsync(IntPtr async, string titleText, string descriptionText, string defaultText, XGameUiTextEntryInputScope inputScope, uint maxTextLength);

		[PreserveSig]
		internal static extern int XGameUiShowTextEntryResultSize(IntPtr async, out uint resultTextBufferSize);

		[PreserveSig]
		internal static extern int XGameUiShowTextEntryResult(IntPtr async, uint resultTextBufferSize, StringBuilder resultTextBuffer, out uint resultTextBufferUsed);

		[PreserveSig]
		internal static extern int XGameUiShowWebAuthenticationAsync(IntPtr async, IntPtr requestingUser, string requestUri, string completionUri);

		[PreserveSig]
		internal static extern int XGameUiShowWebAuthenticationWithOptionsAsync(IntPtr async, IntPtr requestingUser, string requestUri, string completionUri, XGameUiWebAuthenticationOptions options);

		[PreserveSig]
		internal static extern int XGameUiShowWebAuthenticationResult(IntPtr asyncblock, ulong bufferSize, [In][Out] byte[] buffer, out IntPtr ptrToBuffer, out ulong bufferUsed);

		[PreserveSig]
		internal static extern int XGameUiShowWebAuthenticationResultSize(IntPtr async, out ulong bufferSize);

		[PreserveSig]
		internal static extern int XGameUiTextEntryOpen(XGameUiTextEntryOptions options, uint maxLength, string initialText, uint cursorIndex, out IntPtr handle);

		[PreserveSig]
		internal static extern void XGameUiTextEntryClose(IntPtr handle);

		[PreserveSig]
		internal static extern int XGameUiTextEntryGetExtents(IntPtr handle, out XGameUiTextEntryExtents extents);

		[PreserveSig]
		internal static extern int XGameUiTextEntryGetState(IntPtr handle, out XGameUiTextEntryChangeTypeFlags changeType, out uint cursorIndex, out uint imeClauseStartIndex, out uint imeClauseEndIndex, uint bufferSize, StringBuilder buffer);

		[PreserveSig]
		internal static extern int XGameUiTextEntryUpdatePositionHint(IntPtr handle, XGameUiTextEntryPositionHint positionHint);

		[PreserveSig]
		internal static extern int XGameUiTextEntryUpdateVisibility(IntPtr handle, XGameUiTextEntryVisibilityFlags visibilityFlags);

		[PreserveSig]
		internal static extern int XLaunchUri(IntPtr requestingUser, string uri);

		[PreserveSig]
		internal static extern int XNetworkingGetConnectivityHint(out XNetworkingConnectivityHint connectivityHint);

		[PreserveSig]
		internal static extern int XNetworkingQueryConfigurationSetting(XNetworkingConfigurationSetting configurationSetting, out ulong value);

		[PreserveSig]
		internal static extern int XNetworkingQueryPreferredLocalUdpMultiplayerPort(out ushort value);

		[PreserveSig]
		internal static extern int XNetworkingQueryPreferredLocalUdpMultiplayerPortAsync(IntPtr async);

		[PreserveSig]
		internal static extern int XNetworkingQueryPreferredLocalUdpMultiplayerPortAsyncResult(IntPtr async, out ushort preferredLocalUdpMultiplayerPort);

		[PreserveSig]
		internal static extern int XNetworkingQuerySecurityInformationForUrlAsync(string url, IntPtr async);

		[PreserveSig]
		internal static extern int XNetworkingQuerySecurityInformationForUrlAsyncResultSize(IntPtr async, out ulong securityInformationBufferByteCount);

		[PreserveSig]
		internal static extern int XNetworkingQuerySecurityInformationForUrlAsyncResult(IntPtr async, ulong securityInformationBufferByteCount, out ulong securityInformationBufferByteCountUsed, [In][Out] byte[] securityInformationBuffer, out IntPtr securityInformation);

		[PreserveSig]
		internal static extern int XNetworkingQuerySecurityInformationForUrlUtf16Async(string url, IntPtr async);

		[PreserveSig]
		internal static extern int XNetworkingQuerySecurityInformationForUrlUtf16AsyncResultSize(IntPtr async, out ulong securityInformationBufferByteCount);

		[PreserveSig]
		internal static extern int XNetworkingQuerySecurityInformationForUrlUtf16AsyncResult(IntPtr async, ulong securityInformationBufferByteCount, out ulong securityInformationBufferByteCountUsed, [In][Out] byte[] securityInformationBuffer, out IntPtr securityInformation);

		[PreserveSig]
		internal static extern int XNetworkingQueryStatistics(XNetworkingStatisticsType statisticsType, out XNetworkingStatisticsBuffer statisticsBuffer);

		[PreserveSig]
		internal static extern int XNetworkingRegisterConnectivityHintChanged(IntPtr taskQueueHandle, IntPtr context, XNetworkingConnectivityHintChangedCallback callback, out ulong registrationToken);

		[PreserveSig]
		internal static extern bool XNetworkingUnregisterConnectivityHintChanged(ulong token, bool wait);

		[PreserveSig]
		internal static extern int XNetworkingRegisterPreferredLocalUdpMultiplayerPortChanged(IntPtr taskQueueHandle, IntPtr context, XNetworkingPreferredLocalUdpMultiplayerPortChangedCallback callback, out ulong registrationToken);

		[PreserveSig]
		internal static extern bool XNetworkingUnregisterPreferredLocalUdpMultiplayerPortChanged(ulong token, bool wait);

		[PreserveSig]
		internal static extern int XNetworkingVerifyServerCertificate(IntPtr requestHandle, IntPtr securityInformation);

		[PreserveSig]
		internal static extern int XPackageCreateInstallationMonitor(string packageIdentifier, uint selectorCount, XPackageChunkSelectorInterop[] selectors, uint minimumUpdateIntervalMs, IntPtr queue, out IntPtr installationMonitor);

		[PreserveSig]
		internal static extern void XPackageCloseInstallationMonitorHandle(IntPtr installationMonitor);

		[PreserveSig]
		internal static extern int XPackageGetCurrentProcessPackageIdentifier(ulong bufferSize, StringBuilder buffer);

		[PreserveSig]
		internal static extern bool XPackageIsPackagedProcess();

		[PreserveSig]
		internal static extern void XPackageGetInstallationProgress(IntPtr installationMonitor, out XPackageInstallationProgress progress);

		[PreserveSig]
		internal static extern bool XPackageUpdateInstallationMonitor(IntPtr installationMonitor);

		[PreserveSig]
		internal static extern int XPackageGetUserLocale(ulong localeSize, StringBuilder locale);

		[PreserveSig]
		internal static extern int XPackageFindChunkAvailability(string packageIdentifier, uint selectorCount, XPackageChunkSelectorInterop[] selectors, out XPackageChunkAvailability availability);

		[PreserveSig]
		internal static extern int XPackageChangeChunkInstallOrder(string packageIdentifier, uint selectorCount, XPackageChunkSelectorInterop[] selectors);

		[PreserveSig]
		internal static extern int XPackageInstallChunks(string packageIdentifier, uint selectorCount, XPackageChunkSelectorInterop[] selectors, uint minimumUpdateIntervalMs, bool suppressUserConfirmation, IntPtr queue, out IntPtr installationMonitor);

		[PreserveSig]
		internal static extern int XPackageInstallChunksAsync(string packageIdentifier, uint selectorCount, XPackageChunkSelectorInterop[] selectors, uint minimumUpdateIntervalMs, bool suppressUserConfirmation, IntPtr async);

		[PreserveSig]
		internal static extern int XPackageInstallChunksResult(IntPtr asyncBlock, out IntPtr installationMonitor);

		[PreserveSig]
		internal static extern int XPackageEstimateDownloadSize(string packageIdentifier, uint selectorCount, XPackageChunkSelectorInterop[] selectors, out ulong downloadSize, out bool shouldPresentUserConfirmation);

		[PreserveSig]
		internal static extern int XPackageUninstallChunks(string packageIdentifier, uint selectorCount, XPackageChunkSelectorInterop[] selectors);

		[PreserveSig]
		internal static extern void XPackageCloseMountHandle(IntPtr mount);

		[PreserveSig]
		internal static extern int XPackageEnumerateChunkAvailability(string packageIdentifier, XPackageChunkSelectorType type, IntPtr context, XPackageChunkAvailabilityCallback callback);

		[PreserveSig]
		internal static extern int XPackageEnumerateFeatures(string packageIdentifier, IntPtr context, XPackageFeatureEnumerationCallbackInterop callback);

		[PreserveSig]
		internal static extern int XPackageEnumeratePackages(XPackageKind kind, XPackageEnumerationScope scope, IntPtr context, XPackageEnumerationCallback callback);

		[PreserveSig]
		internal static extern int XPackageGetMountPathSize(IntPtr mount, out ulong pathSize);

		[PreserveSig]
		internal static extern int XPackageGetMountPath(IntPtr mount, ulong pathSize, StringBuilder path);

		[PreserveSig]
		internal static extern int XPackageGetWriteStats(out XPackageWriteStats writeStats);

		[PreserveSig]
		internal static extern int XPackageMountWithUiAsync(string packageIdentifier, IntPtr async);

		[PreserveSig]
		internal static extern int XPackageMountWithUiResult(IntPtr async, out IntPtr mount);

		[PreserveSig]
		internal static extern int XPackageRegisterInstallationProgressChanged(IntPtr installationMonitor, IntPtr context, XPackageInstallationProgressCallback callback, out ulong token);

		[PreserveSig]
		internal static extern int XPackageRegisterPackageInstalled(IntPtr queue, IntPtr context, XPackageInstalledCallback callback, out ulong token);

		[PreserveSig]
		internal static extern int XPackageUninstallUWPInstance(string packageName);

		[PreserveSig]
		internal static extern bool XPackageUninstallPackage(string packageIdentifier);

		[PreserveSig]
		internal static extern bool XPackageUnregisterInstallationProgressChanged(IntPtr installationMonitor, ulong token, bool wait);

		[PreserveSig]
		internal static extern bool XPackageUnregisterPackageInstalled(ulong token, bool wait);

		[PreserveSig]
		internal static extern int XPersistentLocalStorageGetPathSize(out ulong pathSize);

		[PreserveSig]
		internal static extern int XPersistentLocalStorageGetPath(ulong pathSize, [In][Out] byte[] path, out ulong pathUsed);

		[PreserveSig]
		internal static extern int XPersistentLocalStorageGetSpaceInfo(out XPersistentLocalStorageSpaceInfo spaceInfo);

		[PreserveSig]
		internal static extern int XPersistentLocalStoragePromptUserForSpaceAsync(ulong requestedBytes, IntPtr asyncBlock);

		[PreserveSig]
		internal static extern int XPersistentLocalStoragePromptUserForSpaceResult(IntPtr asyncBlock);

		[PreserveSig]
		internal static extern int XSpeechSynthesizerEnumerateInstalledVoices(IntPtr context, XSpeechSynthesizerInstalledVoicesCallback callback);

		[PreserveSig]
		internal static extern int XSpeechSynthesizerCreate(out IntPtr speechSynthesizer);

		[PreserveSig]
		internal static extern int XSpeechSynthesizerCloseHandle(IntPtr speechSynthesizer);

		[PreserveSig]
		internal static extern int XSpeechSynthesizerSetDefaultVoice(IntPtr speechSynthesizer);

		[PreserveSig]
		internal static extern int XSpeechSynthesizerSetCustomVoice(IntPtr speechSynthesizer, string voiceId);

		[PreserveSig]
		internal static extern int XSpeechSynthesizerCreateStreamFromText(IntPtr speechSynthesizer, string text, out IntPtr speechSynthesisStream);

		[PreserveSig]
		internal static extern int XSpeechSynthesizerCreateStreamFromSsml(IntPtr speechSynthesizer, string ssml, out IntPtr speechSynthesisStream);

		[PreserveSig]
		internal static extern int XSpeechSynthesizerCloseStreamHandle(IntPtr speechSynthesisStream);

		[PreserveSig]
		internal static extern int XSpeechSynthesizerGetStreamDataSize(IntPtr speechSynthesisStream, out ulong bufferSize);

		[PreserveSig]
		internal static extern int XSpeechSynthesizerGetStreamData(IntPtr speechSynthesisStream, ulong bufferSize, [In][Out] byte[] buffer, out ulong bufferUsed);

		[PreserveSig]
		internal static extern int XStoreCreateContext(IntPtr user, out IntPtr storeContextHandle);

		[PreserveSig]
		internal static extern void XStoreCloseContextHandle(IntPtr storeContextHandle);

		[PreserveSig]
		internal static extern void XStoreCloseLicenseHandle(IntPtr storeLicenseHandle);

		[PreserveSig]
		internal static extern int XStoreAcquireLicenseForDurablesAsync(IntPtr storeContextHandle, string storeId, IntPtr async);

		[PreserveSig]
		internal static extern int XStoreAcquireLicenseForDurablesResult(IntPtr async, out IntPtr storeLicenseHandle);

		[PreserveSig]
		internal static extern int XStoreAcquireLicenseForPackageAsync(IntPtr storeContextHandle, string packageIdentifier, IntPtr async);

		[PreserveSig]
		internal static extern int XStoreAcquireLicenseForPackageResult(IntPtr async, out IntPtr storeLicenseHandle);

		[PreserveSig]
		internal static extern int XStoreCanAcquireLicenseForStoreIdAsync(IntPtr storeContextHandle, string storeProductId, IntPtr async);

		[PreserveSig]
		internal static extern int XStoreCanAcquireLicenseForStoreIdResult(IntPtr async, out XStoreCanAcquireLicenseResult storeCanAcquireLicenseResult);

		[PreserveSig]
		internal static extern int XStoreCanAcquireLicenseForPackageAsync(IntPtr storeContextHandle, string packageIdentifier, IntPtr async);

		[PreserveSig]
		internal static extern int XStoreCanAcquireLicenseForPackageResult(IntPtr async, out XStoreCanAcquireLicenseResult storeCanAcquireLicenseResult);

		[PreserveSig]
		internal static extern int XStoreQueryProductForCurrentGameAsync(IntPtr storeContextHandle, IntPtr async);

		[PreserveSig]
		internal static extern int XStoreQueryProductForCurrentGameResult(IntPtr async, out IntPtr productQueryHandle);

		[PreserveSig]
		internal static extern int XStoreEnumerateProductsQuery(IntPtr productQueryHandle, IntPtr context, XStoreProductQueryCallbackInterop callback);

		[PreserveSig]
		internal static extern void XStoreCloseProductsQueryHandle(IntPtr productQueryHandle);

		[PreserveSig]
		internal static extern int XStoreDownloadPackageUpdatesAsync(IntPtr storeContextHandle, string[] packageIdentifiers, ulong packageIdentifiersCount, IntPtr async);

		[PreserveSig]
		internal static extern int XStoreDownloadPackageUpdatesResult(IntPtr async);

		[PreserveSig]
		internal static extern int XStoreDownloadAndInstallPackageUpdatesAsync(IntPtr storeContextHandle, string[] packageIdentifiers, ulong packageIdentifiersCount, IntPtr async);

		[PreserveSig]
		internal static extern int XStoreDownloadAndInstallPackageUpdatesResult(IntPtr async);

		[PreserveSig]
		internal static extern int XStoreDownloadAndInstallPackagesAsync(IntPtr storeContextHandle, string[] storeIds, ulong storeIdsCount, IntPtr async);

		[PreserveSig]
		internal static extern int XStoreDownloadAndInstallPackagesResultCount(IntPtr async, out uint count);

		[PreserveSig]
		internal static extern int XStoreDownloadAndInstallPackagesResult(IntPtr async, uint count, [In][Out] XStorePackageIdentifierInterop[] identifiers);

		[PreserveSig]
		internal static extern int XStoreGetUserCollectionsIdAsync(IntPtr storeContextHandle, string serviceTicket, string publisherUserId, IntPtr async);

		[PreserveSig]
		internal static extern int XStoreGetUserCollectionsIdResultSize(IntPtr async, out ulong size);

		[PreserveSig]
		internal static extern int XStoreGetUserCollectionsIdResult(IntPtr async, ulong size, StringBuilder result);

		[PreserveSig]
		internal static extern int XStoreGetUserPurchaseIdAsync(IntPtr storeContextHandle, string serviceTicket, string publisherUserId, IntPtr async);

		[PreserveSig]
		internal static extern int XStoreGetUserPurchaseIdResultSize(IntPtr async, out ulong size);

		[PreserveSig]
		internal static extern int XStoreGetUserPurchaseIdResult(IntPtr async, ulong size, StringBuilder result);

		[PreserveSig]
		internal static extern bool XStoreIsAvailabilityPurchasable(XStoreAvailability availability);

		[PreserveSig]
		internal static extern bool XStoreIsLicenseValid(IntPtr storeLicenseHandle);

		[PreserveSig]
		internal static extern bool XStoreProductsQueryHasMorePages(IntPtr productQueryHandle);

		[PreserveSig]
		internal static extern int XStoreProductsQueryNextPageAsync(IntPtr productQueryHandle, IntPtr async);

		[PreserveSig]
		internal static extern int XStoreProductsQueryNextPageResult(IntPtr async, out IntPtr productQueryHandle);

		[PreserveSig]
		internal static extern int XStoreQueryAddOnLicensesAsync(IntPtr storeContextHandle, IntPtr async);

		[PreserveSig]
		internal static extern int XStoreQueryAddOnLicensesResultCount(IntPtr async, out uint count);

		[PreserveSig]
		internal static extern int XStoreQueryAddOnLicensesResult(IntPtr async, uint count, [In][Out] XStoreAddonLicense[] addOnLicenses);

		[PreserveSig]
		internal static extern int XStoreQueryAssociatedProductsAsync(IntPtr storeContextHandle, XStoreProductKind productKinds, uint maxItemsToRetrievePerPage, IntPtr async);

		[PreserveSig]
		internal static extern int XStoreQueryAssociatedProductsResult(IntPtr async, out IntPtr productQueryHandle);

		[PreserveSig]
		internal static extern int XStoreQueryConsumableBalanceRemainingAsync(IntPtr storeContextHandle, string storeProductId, IntPtr async);

		[PreserveSig]
		internal static extern int XStoreQueryConsumableBalanceRemainingResult(IntPtr async, out XStoreConsumableResult consumableResult);

		[PreserveSig]
		internal static extern int XStoreQueryEntitledProductsAsync(IntPtr storeContextHandle, XStoreProductKind productKinds, uint maxItemsToRetrievePerPage, IntPtr async);

		[PreserveSig]
		internal static extern int XStoreQueryEntitledProductsResult(IntPtr async, out IntPtr productQueryHandle);

		[PreserveSig]
		internal static extern int XStoreQueryGameAndDlcPackageUpdatesAsync(IntPtr storeContextHandle, IntPtr async);

		[PreserveSig]
		internal static extern int XStoreQueryGameAndDlcPackageUpdatesResultCount(IntPtr async, out uint count);

		[PreserveSig]
		internal static extern int XStoreQueryGameAndDlcPackageUpdatesResult(IntPtr async, uint count, [In][Out] XStorePackageUpdate[] packageUpdates);

		[PreserveSig]
		internal static extern int XStoreQueryGameLicenseAsync(IntPtr storeContextHandle, IntPtr async);

		[PreserveSig]
		internal static extern int XStoreQueryGameLicenseResult(IntPtr async, out XStoreGameLicense license);

		[PreserveSig]
		internal static extern int XStoreQueryLicenseTokenAsync(IntPtr storeContextHandle, string[] productIds, ulong productIdsCount, string customDeveloperString, IntPtr async);

		[PreserveSig]
		internal static extern int XStoreQueryLicenseTokenResultSize(IntPtr async, out ulong size);

		[PreserveSig]
		internal static extern int XStoreQueryLicenseTokenResult(IntPtr async, ulong size, StringBuilder result);

		[PreserveSig]
		internal static extern int XStoreQueryPackageIdentifier(string storeId, ulong size, StringBuilder packageIdentifier);

		[PreserveSig]
		internal static extern int XStoreQueryProductForPackageAsync(IntPtr storeContextHandle, XStoreProductKind productKinds, string packageIdentifier, IntPtr async);

		[PreserveSig]
		internal static extern int XStoreQueryProductForPackageResult(IntPtr async, out IntPtr productQueryHandle);

		[PreserveSig]
		internal static extern int XStoreQueryProductsAsync(IntPtr storeContextHandle, XStoreProductKind productKinds, string[] storeIds, ulong storeIdsCount, string[] actionFilters, ulong actionFiltersCount, IntPtr async);

		[PreserveSig]
		internal static extern int XStoreQueryProductsResult(IntPtr async, out IntPtr productQueryHandle);

		[PreserveSig]
		internal static extern int XStoreRegisterGameLicenseChanged(IntPtr storeContextHandle, IntPtr queue, IntPtr context, XStoreGameLicenseChangedCallback callback, out ulong token);

		[PreserveSig]
		internal static extern bool XStoreUnregisterGameLicenseChanged(IntPtr storeContextHandle, ulong token, bool wait);

		[PreserveSig]
		internal static extern int XStoreRegisterPackageLicenseLost(IntPtr licenseHandle, IntPtr queue, IntPtr context, XStorePackageLicenseLostCallback callback, out ulong token);

		[PreserveSig]
		internal static extern bool XStoreUnregisterPackageLicenseLost(IntPtr licenseHandle, ulong token, bool wait);

		[PreserveSig]
		internal static extern int XStoreReportConsumableFulfillmentAsync(IntPtr storeContextHandle, string storeProductId, uint quantity, Guid trackingId, IntPtr async);

		[PreserveSig]
		internal static extern int XStoreReportConsumableFulfillmentResult(IntPtr async, out XStoreConsumableResult consumableResult);

		[PreserveSig]
		internal static extern int XStoreShowAssociatedProductsUIAsync(IntPtr storeContextHandle, string storeId, XStoreProductKind productKinds, IntPtr async);

		[PreserveSig]
		internal static extern int XStoreShowAssociatedProductsUIResult(IntPtr async);

		[PreserveSig]
		internal static extern int XStoreShowProductPageUIAsync(IntPtr storeContextHandle, string storeId, IntPtr async);

		[PreserveSig]
		internal static extern int XStoreShowProductPageUIResult(IntPtr async);

		[PreserveSig]
		internal static extern int XStoreShowPurchaseUIAsync(IntPtr storeContextHandle, string storeId, string name, string extendedJsonData, IntPtr async);

		[PreserveSig]
		internal static extern int XStoreShowPurchaseUIResult(IntPtr async);

		[PreserveSig]
		internal static extern int XStoreShowRateAndReviewUIAsync(IntPtr storeContextHandle, IntPtr async);

		[PreserveSig]
		internal static extern int XStoreShowRateAndReviewUIResult(IntPtr async, out XStoreRateAndReviewResult result);

		[PreserveSig]
		internal static extern int XStoreShowRedeemTokenUIAsync(IntPtr storeContextHandle, string token, string[] allowedStoreIds, ulong allowedStoreIdsCount, bool disallowCsvRedemption, IntPtr async);

		[PreserveSig]
		internal static extern int XStoreShowRedeemTokenUIResult(IntPtr async);

		[PreserveSig]
		internal static extern void XSystemGetAnalyticsInfo(out XSystemAnalyticsInfo info);

		[PreserveSig]
		internal static extern int XSystemGetAppSpecificDeviceId(ulong appSpecificDeviceIdSize, StringBuilder appSpecificDeviceId, out ulong appSpecificDeviceIdUsed);

		[PreserveSig]
		internal static extern int XSystemGetConsoleId(ulong consoleIdSize, StringBuilder consoleId, out ulong consoleIdUsed);

		[PreserveSig]
		internal static extern XSystemDeviceType XSystemGetDeviceType();

		[PreserveSig]
		internal static extern int XSystemGetXboxLiveSandboxId(ulong sandboxIdSize, StringBuilder sandboxId, out ulong sandboxIdUsed);

		[PreserveSig]
		internal static extern XSystemRuntimeInfo XSystemGetRuntimeInfo();

		[PreserveSig]
		internal static extern bool XSystemIsHandleValid(IntPtr handle);

		[PreserveSig]
		internal static extern int XSystemHandleTrack(XSystemHandleCallback callback, IntPtr context);

		[PreserveSig]
		internal static extern void XTaskQueueCloseHandle(IntPtr queue);

		[PreserveSig]
		internal static extern int XTaskQueueCreate(XTaskQueueDispatchMode workDispatchMode, XTaskQueueDispatchMode completionDispatchMode, out IntPtr queue);

		[PreserveSig]
		internal static extern int XTaskQueueCreateComposite(IntPtr workPort, IntPtr completionPort, out IntPtr queue);

		[PreserveSig]
		internal static extern bool XTaskQueueDispatch(IntPtr queue, XTaskQueuePort port, uint timeoutInMs);

		[PreserveSig]
		internal static extern int XTaskQueueDuplicateHandle(IntPtr queueHandle, out IntPtr duplicatedHandle);

		[PreserveSig]
		internal static extern bool XTaskQueueGetCurrentProcessTaskQueue(out IntPtr queue);

		[PreserveSig]
		internal static extern int XTaskQueueGetPort(IntPtr queue, XTaskQueuePort port, out IntPtr portHandle);

		[PreserveSig]
		internal static extern int XTaskQueueRegisterMonitor(IntPtr queue, IntPtr callbackContext, XTaskQueueMonitorCallback callback, out ulong token);

		[PreserveSig]
		internal static extern int XTaskQueueRegisterWaiter(IntPtr queue, XTaskQueuePort port, SafeWaitHandle waitHandle, IntPtr callbackContext, XTaskQueueCallback callback, out ulong token);

		[PreserveSig]
		internal static extern void XTaskQueueSetCurrentProcessTaskQueue(IntPtr queue);

		[PreserveSig]
		internal static extern int XTaskQueueSubmitCallback(IntPtr queue, XTaskQueuePort port, IntPtr callbackContext, XTaskQueueCallback callback);

		[PreserveSig]
		internal static extern int XTaskQueueSubmitDelayedCallback(IntPtr queue, XTaskQueuePort port, uint delayMs, IntPtr callbackContext, XTaskQueueCallback callback);

		[PreserveSig]
		internal static extern int XTaskQueueTerminate(IntPtr queue, bool wait, IntPtr callbackContext, XTaskQueueTerminatedCallback callback);

		[PreserveSig]
		internal static extern int XTaskQueueUnregisterMonitor(IntPtr queue, ulong token);

		[PreserveSig]
		internal static extern int XTaskQueueUnregisterWaiter(IntPtr queue, ulong token);

		[PreserveSig]
		internal static extern void XThreadAssertNotTimeSensitive();

		[PreserveSig]
		internal static extern bool XThreadIsTimeSensitive();

		[PreserveSig]
		internal static extern int XThreadSetTimeSensitive(bool isTimeSensitiveThread);

		[PreserveSig]
		internal static extern int XUserAddAsync(XUserAddOptions options, IntPtr async);

		[PreserveSig]
		internal static extern int XUserAddResult(IntPtr async, out IntPtr newUser);

		[PreserveSig]
		internal static extern int XUserAddByIdWithUiAsync(ulong userId, IntPtr async);

		[PreserveSig]
		internal static extern int XUserAddByIdWithUiResult(IntPtr async, out IntPtr newUser);

		[PreserveSig]
		internal static extern int XUserCheckPrivilege(IntPtr user, XUserPrivilegeOptions options, XUserPrivilege privilege, out bool hasPrivilege, out XUserPrivilegeDenyReason reason);

		[PreserveSig]
		internal static extern void XUserCloseHandle(IntPtr user);

		[PreserveSig]
		internal static extern void XUserCloseSignOutDeferralHandle(IntPtr deferral);

		[PreserveSig]
		internal static extern int XUserCompare(IntPtr user1, IntPtr user2);

		[PreserveSig]
		internal static extern int XUserDuplicateHandle(IntPtr handle, out IntPtr duplicatedHandle);

		[PreserveSig]
		internal static extern int XUserFindControllerForUserWithUiAsync(IntPtr user, IntPtr async);

		[PreserveSig]
		internal static extern int XUserFindControllerForUserWithUiResult(IntPtr async, out APP_LOCAL_DEVICE_ID deviceId);

		[PreserveSig]
		internal static extern int XUserFindForDevice(ref APP_LOCAL_DEVICE_ID deviceId, out IntPtr handle);

		[PreserveSig]
		internal static extern int XUserFindUserById(ulong userId, out IntPtr handle);

		[PreserveSig]
		internal static extern int XUserFindUserByLocalId(XUserLocalId userLocalId, out IntPtr handle);

		[PreserveSig]
		internal static extern int XUserGetAgeGroup(IntPtr user, out XUserAgeGroup ageGroup);

		[PreserveSig]
		internal static extern int XUserGetDefaultAudioEndpointUtf16(XUserLocalId user, XUserDefaultAudioEndpointKind defaultAudioEndpointKind, ulong endpointIdUtf16Count, [In][Out] char[] endpointIdUtf16, out ulong endpointIdUtf16Used);

		[PreserveSig]
		internal static extern int XUserGetGamerPictureAsync(IntPtr user, XUserGamerPictureSize pictureSize, IntPtr async);

		[PreserveSig]
		internal static extern int XUserGetGamerPictureResultSize(IntPtr async, out ulong bufferSize);

		[PreserveSig]
		internal static extern int XUserGetGamerPictureResult(IntPtr async, ulong bufferSize, [In][Out] byte[] buffer, out ulong bufferUsed);

		[PreserveSig]
		internal static extern int XUserGetGamertag(IntPtr user, XUserGamertagComponent gamertagComponent, ulong gamertagSize, StringBuilder gamertag, out ulong gamertagUsed);

		[PreserveSig]
		internal static extern int XUserGetId(IntPtr user, out ulong userId);

		[PreserveSig]
		internal static extern int XUserGetIsGuest(IntPtr user, out bool isGuest);

		[PreserveSig]
		internal static extern int XUserGetLocalId(IntPtr user, out XUserLocalId userLocalId);

		[PreserveSig]
		internal static extern int XUserGetMaxUsers(out uint maxUsers);

		[PreserveSig]
		internal static extern int XUserGetSignOutDeferral(out IntPtr deferral);

		[PreserveSig]
		internal static extern int XUserGetState(IntPtr user, out XUserState state);

		[PreserveSig]
		internal static extern int XUserGetTokenAndSignatureAsync(IntPtr user, XUserGetTokenAndSignatureOptions options, string method, string url, ulong headerCount, XUserGetTokenAndSignatureHttpHeader[] headers, ulong bodySize, byte[] bodyBuffer, IntPtr async);

		[PreserveSig]
		internal static extern int XUserGetTokenAndSignatureResultSize(IntPtr async, out ulong bufferSize);

		[PreserveSig]
		internal static extern int XUserGetTokenAndSignatureResult(IntPtr async, ulong bufferSize, [In][Out] byte[] buffer, out IntPtr ptrToBuffer, out ulong bufferUsed);

		[PreserveSig]
		internal static extern int XUserGetTokenAndSignatureUtf16Async(IntPtr user, XUserGetTokenAndSignatureOptions options, string method, string url, ulong headerCount, XUserGetTokenAndSignatureUtf16HttpHeader[] headers, ulong bodySize, byte[] bodyBuffer, IntPtr async);

		[PreserveSig]
		internal static extern int XUserGetTokenAndSignatureUtf16ResultSize(IntPtr async, out ulong bufferSize);

		[PreserveSig]
		internal static extern int XUserGetTokenAndSignatureUtf16Result(IntPtr async, ulong bufferSize, [In][Out] byte[] buffer, out IntPtr ptrToBuffer, out ulong bufferUsed);

		[PreserveSig]
		internal static extern bool XUserIsStoreUser(IntPtr user);

		[PreserveSig]
		internal static extern int XUserRegisterForChangeEvent(IntPtr queue, IntPtr context, XUserChangeEventCallback callback, out ulong token);

		[PreserveSig]
		internal static extern int XUserRegisterForDefaultAudioEndpointUtf16Changed(IntPtr queue, IntPtr context, XUserDefaultAudioEndpointUtf16ChangedCallback callback, out ulong token);

		[PreserveSig]
		internal static extern int XUserRegisterForDeviceAssociationChanged(IntPtr queue, IntPtr context, XUserDeviceAssociationChangedCallback callback, out ulong token);

		[PreserveSig]
		internal static extern int XUserResolveIssueWithUiAsync(IntPtr user, string url, IntPtr async);

		[PreserveSig]
		internal static extern int XUserResolveIssueWithUiResult(IntPtr async);

		[PreserveSig]
		internal static extern int XUserResolveIssueWithUiUtf16Async(IntPtr user, string url, IntPtr async);

		[PreserveSig]
		internal static extern int XUserResolveIssueWithUiUtf16Result(IntPtr async);

		[PreserveSig]
		internal static extern int XUserResolvePrivilegeWithUiAsync(IntPtr user, XUserPrivilegeOptions options, XUserPrivilege privilege, IntPtr async);

		[PreserveSig]
		internal static extern int XUserResolvePrivilegeWithUiResult(IntPtr async);

		[PreserveSig]
		internal static extern bool XUserUnregisterForChangeEvent(ulong token, bool wait);

		[PreserveSig]
		internal static extern bool XUserUnregisterForDefaultAudioEndpointUtf16Changed(ulong token, bool wait);

		[PreserveSig]
		internal static extern bool XUserUnregisterForDeviceAssociationChanged(ulong token, bool wait);
	}
}
