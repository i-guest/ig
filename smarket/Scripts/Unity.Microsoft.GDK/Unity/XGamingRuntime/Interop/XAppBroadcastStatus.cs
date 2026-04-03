namespace Unity.XGamingRuntime.Interop
{
	internal struct XAppBroadcastStatus
	{
		internal bool canStartBroadcast;

		internal bool isAnyAppBroadcasting;

		internal bool isCaptureResourceUnavailable;

		internal bool isGameStreamInProgress;

		internal bool isGpuConstrained;

		internal bool isAppInactive;

		internal bool isBlockedForApp;

		internal bool isDisabledByUser;

		internal bool isDisabledBySystem;
	}
}
