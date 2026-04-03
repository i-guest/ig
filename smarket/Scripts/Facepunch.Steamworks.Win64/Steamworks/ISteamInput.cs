using System;
using System.Runtime.InteropServices;
using Steamworks.Data;

namespace Steamworks
{
	internal class ISteamInput : SteamInterface
	{
		public const string Version = "SteamInput006";

		internal ISteamInput(bool IsGameServer)
		{
		}

		[PreserveSig]
		internal static extern IntPtr SteamAPI_SteamInput_v006();

		public override IntPtr GetUserInterfacePointer()
		{
			return (IntPtr)0;
		}

		[PreserveSig]
		private static extern bool _Init(IntPtr self, bool bExplicitlyCallRunFrame);

		internal bool Init(bool bExplicitlyCallRunFrame)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _Shutdown(IntPtr self);

		internal bool Shutdown()
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _SetInputActionManifestFilePath(IntPtr self, string pchInputActionManifestAbsolutePath);

		internal bool SetInputActionManifestFilePath(string pchInputActionManifestAbsolutePath)
		{
			return false;
		}

		[PreserveSig]
		private static extern void _RunFrame(IntPtr self, bool bReservedValue);

		internal void RunFrame(bool bReservedValue)
		{
		}

		[PreserveSig]
		private static extern bool _BWaitForData(IntPtr self, bool bWaitForever, uint unTimeout);

		internal bool BWaitForData(bool bWaitForever, uint unTimeout)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _BNewDataAvailable(IntPtr self);

		internal bool BNewDataAvailable()
		{
			return false;
		}

		[PreserveSig]
		private static extern int _GetConnectedControllers(IntPtr self, [In][Out] InputHandle_t[] handlesOut);

		internal int GetConnectedControllers([In][Out] InputHandle_t[] handlesOut)
		{
			return 0;
		}

		[PreserveSig]
		private static extern void _EnableDeviceCallbacks(IntPtr self);

		internal void EnableDeviceCallbacks()
		{
		}

		[PreserveSig]
		private static extern InputActionSetHandle_t _GetActionSetHandle(IntPtr self, string pszActionSetName);

		internal InputActionSetHandle_t GetActionSetHandle(string pszActionSetName)
		{
			return default(InputActionSetHandle_t);
		}

		[PreserveSig]
		private static extern void _ActivateActionSet(IntPtr self, InputHandle_t inputHandle, InputActionSetHandle_t actionSetHandle);

		internal void ActivateActionSet(InputHandle_t inputHandle, InputActionSetHandle_t actionSetHandle)
		{
		}

		[PreserveSig]
		private static extern InputActionSetHandle_t _GetCurrentActionSet(IntPtr self, InputHandle_t inputHandle);

		internal InputActionSetHandle_t GetCurrentActionSet(InputHandle_t inputHandle)
		{
			return default(InputActionSetHandle_t);
		}

		[PreserveSig]
		private static extern void _ActivateActionSetLayer(IntPtr self, InputHandle_t inputHandle, InputActionSetHandle_t actionSetLayerHandle);

		internal void ActivateActionSetLayer(InputHandle_t inputHandle, InputActionSetHandle_t actionSetLayerHandle)
		{
		}

		[PreserveSig]
		private static extern void _DeactivateActionSetLayer(IntPtr self, InputHandle_t inputHandle, InputActionSetHandle_t actionSetLayerHandle);

		internal void DeactivateActionSetLayer(InputHandle_t inputHandle, InputActionSetHandle_t actionSetLayerHandle)
		{
		}

		[PreserveSig]
		private static extern void _DeactivateAllActionSetLayers(IntPtr self, InputHandle_t inputHandle);

		internal void DeactivateAllActionSetLayers(InputHandle_t inputHandle)
		{
		}

		[PreserveSig]
		private static extern int _GetActiveActionSetLayers(IntPtr self, InputHandle_t inputHandle, [In][Out] InputActionSetHandle_t[] handlesOut);

		internal int GetActiveActionSetLayers(InputHandle_t inputHandle, [In][Out] InputActionSetHandle_t[] handlesOut)
		{
			return 0;
		}

		[PreserveSig]
		private static extern InputDigitalActionHandle_t _GetDigitalActionHandle(IntPtr self, string pszActionName);

		internal InputDigitalActionHandle_t GetDigitalActionHandle(string pszActionName)
		{
			return default(InputDigitalActionHandle_t);
		}

		[PreserveSig]
		private static extern DigitalState _GetDigitalActionData(IntPtr self, InputHandle_t inputHandle, InputDigitalActionHandle_t digitalActionHandle);

		internal DigitalState GetDigitalActionData(InputHandle_t inputHandle, InputDigitalActionHandle_t digitalActionHandle)
		{
			return default(DigitalState);
		}

		[PreserveSig]
		private static extern int _GetDigitalActionOrigins(IntPtr self, InputHandle_t inputHandle, InputActionSetHandle_t actionSetHandle, InputDigitalActionHandle_t digitalActionHandle, ref InputActionOrigin originsOut);

		internal int GetDigitalActionOrigins(InputHandle_t inputHandle, InputActionSetHandle_t actionSetHandle, InputDigitalActionHandle_t digitalActionHandle, ref InputActionOrigin originsOut)
		{
			return 0;
		}

		[PreserveSig]
		private static extern Utf8StringPointer _GetStringForDigitalActionName(IntPtr self, InputDigitalActionHandle_t eActionHandle);

		internal string GetStringForDigitalActionName(InputDigitalActionHandle_t eActionHandle)
		{
			return null;
		}

		[PreserveSig]
		private static extern InputAnalogActionHandle_t _GetAnalogActionHandle(IntPtr self, string pszActionName);

		internal InputAnalogActionHandle_t GetAnalogActionHandle(string pszActionName)
		{
			return default(InputAnalogActionHandle_t);
		}

		[PreserveSig]
		private static extern AnalogState _GetAnalogActionData(IntPtr self, InputHandle_t inputHandle, InputAnalogActionHandle_t analogActionHandle);

		internal AnalogState GetAnalogActionData(InputHandle_t inputHandle, InputAnalogActionHandle_t analogActionHandle)
		{
			return default(AnalogState);
		}

		[PreserveSig]
		private static extern int _GetAnalogActionOrigins(IntPtr self, InputHandle_t inputHandle, InputActionSetHandle_t actionSetHandle, InputAnalogActionHandle_t analogActionHandle, ref InputActionOrigin originsOut);

		internal int GetAnalogActionOrigins(InputHandle_t inputHandle, InputActionSetHandle_t actionSetHandle, InputAnalogActionHandle_t analogActionHandle, ref InputActionOrigin originsOut)
		{
			return 0;
		}

		[PreserveSig]
		private static extern Utf8StringPointer _GetGlyphPNGForActionOrigin(IntPtr self, InputActionOrigin eOrigin, GlyphSize eSize, uint unFlags);

		internal string GetGlyphPNGForActionOrigin(InputActionOrigin eOrigin, GlyphSize eSize, uint unFlags)
		{
			return null;
		}

		[PreserveSig]
		private static extern Utf8StringPointer _GetGlyphSVGForActionOrigin(IntPtr self, InputActionOrigin eOrigin, uint unFlags);

		internal string GetGlyphSVGForActionOrigin(InputActionOrigin eOrigin, uint unFlags)
		{
			return null;
		}

		[PreserveSig]
		private static extern Utf8StringPointer _GetGlyphForActionOrigin_Legacy(IntPtr self, InputActionOrigin eOrigin);

		internal string GetGlyphForActionOrigin_Legacy(InputActionOrigin eOrigin)
		{
			return null;
		}

		[PreserveSig]
		private static extern Utf8StringPointer _GetStringForActionOrigin(IntPtr self, InputActionOrigin eOrigin);

		internal string GetStringForActionOrigin(InputActionOrigin eOrigin)
		{
			return null;
		}

		[PreserveSig]
		private static extern Utf8StringPointer _GetStringForAnalogActionName(IntPtr self, InputAnalogActionHandle_t eActionHandle);

		internal string GetStringForAnalogActionName(InputAnalogActionHandle_t eActionHandle)
		{
			return null;
		}

		[PreserveSig]
		private static extern void _StopAnalogActionMomentum(IntPtr self, InputHandle_t inputHandle, InputAnalogActionHandle_t eAction);

		internal void StopAnalogActionMomentum(InputHandle_t inputHandle, InputAnalogActionHandle_t eAction)
		{
		}

		[PreserveSig]
		private static extern MotionState _GetMotionData(IntPtr self, InputHandle_t inputHandle);

		internal MotionState GetMotionData(InputHandle_t inputHandle)
		{
			return default(MotionState);
		}

		[PreserveSig]
		private static extern void _TriggerVibration(IntPtr self, InputHandle_t inputHandle, ushort usLeftSpeed, ushort usRightSpeed);

		internal void TriggerVibration(InputHandle_t inputHandle, ushort usLeftSpeed, ushort usRightSpeed)
		{
		}

		[PreserveSig]
		private static extern void _TriggerVibrationExtended(IntPtr self, InputHandle_t inputHandle, ushort usLeftSpeed, ushort usRightSpeed, ushort usLeftTriggerSpeed, ushort usRightTriggerSpeed);

		internal void TriggerVibrationExtended(InputHandle_t inputHandle, ushort usLeftSpeed, ushort usRightSpeed, ushort usLeftTriggerSpeed, ushort usRightTriggerSpeed)
		{
		}

		[PreserveSig]
		private static extern void _TriggerSimpleHapticEvent(IntPtr self, InputHandle_t inputHandle, ControllerHapticLocation eHapticLocation, byte nIntensity, char nGainDB, byte nOtherIntensity, char nOtherGainDB);

		internal void TriggerSimpleHapticEvent(InputHandle_t inputHandle, ControllerHapticLocation eHapticLocation, byte nIntensity, char nGainDB, byte nOtherIntensity, char nOtherGainDB)
		{
		}

		[PreserveSig]
		private static extern void _SetLEDColor(IntPtr self, InputHandle_t inputHandle, byte nColorR, byte nColorG, byte nColorB, uint nFlags);

		internal void SetLEDColor(InputHandle_t inputHandle, byte nColorR, byte nColorG, byte nColorB, uint nFlags)
		{
		}

		[PreserveSig]
		private static extern void _Legacy_TriggerHapticPulse(IntPtr self, InputHandle_t inputHandle, SteamControllerPad eTargetPad, ushort usDurationMicroSec);

		internal void Legacy_TriggerHapticPulse(InputHandle_t inputHandle, SteamControllerPad eTargetPad, ushort usDurationMicroSec)
		{
		}

		[PreserveSig]
		private static extern void _Legacy_TriggerRepeatedHapticPulse(IntPtr self, InputHandle_t inputHandle, SteamControllerPad eTargetPad, ushort usDurationMicroSec, ushort usOffMicroSec, ushort unRepeat, uint nFlags);

		internal void Legacy_TriggerRepeatedHapticPulse(InputHandle_t inputHandle, SteamControllerPad eTargetPad, ushort usDurationMicroSec, ushort usOffMicroSec, ushort unRepeat, uint nFlags)
		{
		}

		[PreserveSig]
		private static extern bool _ShowBindingPanel(IntPtr self, InputHandle_t inputHandle);

		internal bool ShowBindingPanel(InputHandle_t inputHandle)
		{
			return false;
		}

		[PreserveSig]
		private static extern InputType _GetInputTypeForHandle(IntPtr self, InputHandle_t inputHandle);

		internal InputType GetInputTypeForHandle(InputHandle_t inputHandle)
		{
			return default(InputType);
		}

		[PreserveSig]
		private static extern InputHandle_t _GetControllerForGamepadIndex(IntPtr self, int nIndex);

		internal InputHandle_t GetControllerForGamepadIndex(int nIndex)
		{
			return default(InputHandle_t);
		}

		[PreserveSig]
		private static extern int _GetGamepadIndexForController(IntPtr self, InputHandle_t ulinputHandle);

		internal int GetGamepadIndexForController(InputHandle_t ulinputHandle)
		{
			return 0;
		}

		[PreserveSig]
		private static extern Utf8StringPointer _GetStringForXboxOrigin(IntPtr self, XboxOrigin eOrigin);

		internal string GetStringForXboxOrigin(XboxOrigin eOrigin)
		{
			return null;
		}

		[PreserveSig]
		private static extern Utf8StringPointer _GetGlyphForXboxOrigin(IntPtr self, XboxOrigin eOrigin);

		internal string GetGlyphForXboxOrigin(XboxOrigin eOrigin)
		{
			return null;
		}

		[PreserveSig]
		private static extern InputActionOrigin _GetActionOriginFromXboxOrigin(IntPtr self, InputHandle_t inputHandle, XboxOrigin eOrigin);

		internal InputActionOrigin GetActionOriginFromXboxOrigin(InputHandle_t inputHandle, XboxOrigin eOrigin)
		{
			return default(InputActionOrigin);
		}

		[PreserveSig]
		private static extern InputActionOrigin _TranslateActionOrigin(IntPtr self, InputType eDestinationInputType, InputActionOrigin eSourceOrigin);

		internal InputActionOrigin TranslateActionOrigin(InputType eDestinationInputType, InputActionOrigin eSourceOrigin)
		{
			return default(InputActionOrigin);
		}

		[PreserveSig]
		private static extern bool _GetDeviceBindingRevision(IntPtr self, InputHandle_t inputHandle, ref int pMajor, ref int pMinor);

		internal bool GetDeviceBindingRevision(InputHandle_t inputHandle, ref int pMajor, ref int pMinor)
		{
			return false;
		}

		[PreserveSig]
		private static extern uint _GetRemotePlaySessionID(IntPtr self, InputHandle_t inputHandle);

		internal uint GetRemotePlaySessionID(InputHandle_t inputHandle)
		{
			return 0u;
		}

		[PreserveSig]
		private static extern ushort _GetSessionInputConfigurationSettings(IntPtr self);

		internal ushort GetSessionInputConfigurationSettings()
		{
			return 0;
		}
	}
}
