using System;
using System.Runtime.InteropServices;
using Steamworks.Data;

namespace Steamworks
{
	internal class ISteamUtils : SteamInterface
	{
		public const string Version = "SteamUtils010";

		internal ISteamUtils(bool IsGameServer)
		{
		}

		[PreserveSig]
		internal static extern IntPtr SteamAPI_SteamUtils_v010();

		public override IntPtr GetUserInterfacePointer()
		{
			return (IntPtr)0;
		}

		[PreserveSig]
		internal static extern IntPtr SteamAPI_SteamGameServerUtils_v010();

		public override IntPtr GetServerInterfacePointer()
		{
			return (IntPtr)0;
		}

		[PreserveSig]
		private static extern uint _GetSecondsSinceAppActive(IntPtr self);

		internal uint GetSecondsSinceAppActive()
		{
			return 0u;
		}

		[PreserveSig]
		private static extern uint _GetSecondsSinceComputerActive(IntPtr self);

		internal uint GetSecondsSinceComputerActive()
		{
			return 0u;
		}

		[PreserveSig]
		private static extern Universe _GetConnectedUniverse(IntPtr self);

		internal Universe GetConnectedUniverse()
		{
			return default(Universe);
		}

		[PreserveSig]
		private static extern uint _GetServerRealTime(IntPtr self);

		internal uint GetServerRealTime()
		{
			return 0u;
		}

		[PreserveSig]
		private static extern Utf8StringPointer _GetIPCountry(IntPtr self);

		internal string GetIPCountry()
		{
			return null;
		}

		[PreserveSig]
		private static extern bool _GetImageSize(IntPtr self, int iImage, ref uint pnWidth, ref uint pnHeight);

		internal bool GetImageSize(int iImage, ref uint pnWidth, ref uint pnHeight)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _GetImageRGBA(IntPtr self, int iImage, [In][Out] byte[] pubDest, int nDestBufferSize);

		internal bool GetImageRGBA(int iImage, [In][Out] byte[] pubDest, int nDestBufferSize)
		{
			return false;
		}

		[PreserveSig]
		private static extern byte _GetCurrentBatteryPower(IntPtr self);

		internal byte GetCurrentBatteryPower()
		{
			return 0;
		}

		[PreserveSig]
		private static extern uint _GetAppID(IntPtr self);

		internal uint GetAppID()
		{
			return 0u;
		}

		[PreserveSig]
		private static extern void _SetOverlayNotificationPosition(IntPtr self, NotificationPosition eNotificationPosition);

		internal void SetOverlayNotificationPosition(NotificationPosition eNotificationPosition)
		{
		}

		[PreserveSig]
		private static extern bool _IsAPICallCompleted(IntPtr self, SteamAPICall_t hSteamAPICall, ref bool pbFailed);

		internal bool IsAPICallCompleted(SteamAPICall_t hSteamAPICall, ref bool pbFailed)
		{
			return false;
		}

		[PreserveSig]
		private static extern SteamAPICallFailure _GetAPICallFailureReason(IntPtr self, SteamAPICall_t hSteamAPICall);

		internal SteamAPICallFailure GetAPICallFailureReason(SteamAPICall_t hSteamAPICall)
		{
			return default(SteamAPICallFailure);
		}

		[PreserveSig]
		private static extern bool _GetAPICallResult(IntPtr self, SteamAPICall_t hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, ref bool pbFailed);

		internal bool GetAPICallResult(SteamAPICall_t hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, ref bool pbFailed)
		{
			return false;
		}

		[PreserveSig]
		private static extern uint _GetIPCCallCount(IntPtr self);

		internal uint GetIPCCallCount()
		{
			return 0u;
		}

		[PreserveSig]
		private static extern void _SetWarningMessageHook(IntPtr self, IntPtr pFunction);

		internal void SetWarningMessageHook(IntPtr pFunction)
		{
		}

		[PreserveSig]
		private static extern bool _IsOverlayEnabled(IntPtr self);

		internal bool IsOverlayEnabled()
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _BOverlayNeedsPresent(IntPtr self);

		internal bool BOverlayNeedsPresent()
		{
			return false;
		}

		[PreserveSig]
		private static extern SteamAPICall_t _CheckFileSignature(IntPtr self, string szFileName);

		internal CallResult<CheckFileSignature_t> CheckFileSignature(string szFileName)
		{
			return default(CallResult<CheckFileSignature_t>);
		}

		[PreserveSig]
		private static extern bool _ShowGamepadTextInput(IntPtr self, GamepadTextInputMode eInputMode, GamepadTextInputLineMode eLineInputMode, string pchDescription, uint unCharMax, string pchExistingText);

		internal bool ShowGamepadTextInput(GamepadTextInputMode eInputMode, GamepadTextInputLineMode eLineInputMode, string pchDescription, uint unCharMax, string pchExistingText)
		{
			return false;
		}

		[PreserveSig]
		private static extern uint _GetEnteredGamepadTextLength(IntPtr self);

		internal uint GetEnteredGamepadTextLength()
		{
			return 0u;
		}

		[PreserveSig]
		private static extern bool _GetEnteredGamepadTextInput(IntPtr self, IntPtr pchText, uint cchText);

		internal bool GetEnteredGamepadTextInput(out string pchText)
		{
			pchText = null;
			return false;
		}

		[PreserveSig]
		private static extern Utf8StringPointer _GetSteamUILanguage(IntPtr self);

		internal string GetSteamUILanguage()
		{
			return null;
		}

		[PreserveSig]
		private static extern bool _IsSteamRunningInVR(IntPtr self);

		internal bool IsSteamRunningInVR()
		{
			return false;
		}

		[PreserveSig]
		private static extern void _SetOverlayNotificationInset(IntPtr self, int nHorizontalInset, int nVerticalInset);

		internal void SetOverlayNotificationInset(int nHorizontalInset, int nVerticalInset)
		{
		}

		[PreserveSig]
		private static extern bool _IsSteamInBigPictureMode(IntPtr self);

		internal bool IsSteamInBigPictureMode()
		{
			return false;
		}

		[PreserveSig]
		private static extern void _StartVRDashboard(IntPtr self);

		internal void StartVRDashboard()
		{
		}

		[PreserveSig]
		private static extern bool _IsVRHeadsetStreamingEnabled(IntPtr self);

		internal bool IsVRHeadsetStreamingEnabled()
		{
			return false;
		}

		[PreserveSig]
		private static extern void _SetVRHeadsetStreamingEnabled(IntPtr self, bool bEnabled);

		internal void SetVRHeadsetStreamingEnabled(bool bEnabled)
		{
		}

		[PreserveSig]
		private static extern bool _IsSteamChinaLauncher(IntPtr self);

		internal bool IsSteamChinaLauncher()
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _InitFilterText(IntPtr self, uint unFilterOptions);

		internal bool InitFilterText(uint unFilterOptions)
		{
			return false;
		}

		[PreserveSig]
		private static extern int _FilterText(IntPtr self, TextFilteringContext eContext, SteamId sourceSteamID, string pchInputMessage, IntPtr pchOutFilteredText, uint nByteSizeOutFilteredText);

		internal int FilterText(TextFilteringContext eContext, SteamId sourceSteamID, string pchInputMessage, out string pchOutFilteredText)
		{
			pchOutFilteredText = null;
			return 0;
		}

		[PreserveSig]
		private static extern SteamIPv6ConnectivityState _GetIPv6ConnectivityState(IntPtr self, SteamIPv6ConnectivityProtocol eProtocol);

		internal SteamIPv6ConnectivityState GetIPv6ConnectivityState(SteamIPv6ConnectivityProtocol eProtocol)
		{
			return default(SteamIPv6ConnectivityState);
		}

		[PreserveSig]
		private static extern bool _IsSteamRunningOnSteamDeck(IntPtr self);

		internal bool IsSteamRunningOnSteamDeck()
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _ShowFloatingGamepadTextInput(IntPtr self, TextInputMode eKeyboardMode, int nTextFieldXPosition, int nTextFieldYPosition, int nTextFieldWidth, int nTextFieldHeight);

		internal bool ShowFloatingGamepadTextInput(TextInputMode eKeyboardMode, int nTextFieldXPosition, int nTextFieldYPosition, int nTextFieldWidth, int nTextFieldHeight)
		{
			return false;
		}

		[PreserveSig]
		private static extern void _SetGameLauncherMode(IntPtr self, bool bLauncherMode);

		internal void SetGameLauncherMode(bool bLauncherMode)
		{
		}

		[PreserveSig]
		private static extern bool _DismissFloatingGamepadTextInput(IntPtr self);

		internal bool DismissFloatingGamepadTextInput()
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _DismissGamepadTextInput(IntPtr self);

		internal bool DismissGamepadTextInput()
		{
			return false;
		}
	}
}
