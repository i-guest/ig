using System;
using System.Runtime.InteropServices;
using Steamworks.Data;

namespace Steamworks
{
	internal class ISteamController : SteamInterface
	{
		public const string Version = "SteamController008";

		internal ISteamController(bool IsGameServer)
		{
		}

		[PreserveSig]
		internal static extern IntPtr SteamAPI_SteamController_v008();

		public override IntPtr GetUserInterfacePointer()
		{
			return (IntPtr)0;
		}

		[PreserveSig]
		private static extern bool _Init(IntPtr self);

		internal bool Init()
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
		private static extern void _RunFrame(IntPtr self);

		internal void RunFrame()
		{
		}

		[PreserveSig]
		private static extern int _GetConnectedControllers(IntPtr self, [In][Out] ControllerHandle_t[] handlesOut);

		internal int GetConnectedControllers([In][Out] ControllerHandle_t[] handlesOut)
		{
			return 0;
		}

		[PreserveSig]
		private static extern ControllerActionSetHandle_t _GetActionSetHandle(IntPtr self, string pszActionSetName);

		internal ControllerActionSetHandle_t GetActionSetHandle(string pszActionSetName)
		{
			return default(ControllerActionSetHandle_t);
		}

		[PreserveSig]
		private static extern void _ActivateActionSet(IntPtr self, ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetHandle);

		internal void ActivateActionSet(ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetHandle)
		{
		}

		[PreserveSig]
		private static extern ControllerActionSetHandle_t _GetCurrentActionSet(IntPtr self, ControllerHandle_t controllerHandle);

		internal ControllerActionSetHandle_t GetCurrentActionSet(ControllerHandle_t controllerHandle)
		{
			return default(ControllerActionSetHandle_t);
		}

		[PreserveSig]
		private static extern void _ActivateActionSetLayer(IntPtr self, ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetLayerHandle);

		internal void ActivateActionSetLayer(ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetLayerHandle)
		{
		}

		[PreserveSig]
		private static extern void _DeactivateActionSetLayer(IntPtr self, ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetLayerHandle);

		internal void DeactivateActionSetLayer(ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetLayerHandle)
		{
		}

		[PreserveSig]
		private static extern void _DeactivateAllActionSetLayers(IntPtr self, ControllerHandle_t controllerHandle);

		internal void DeactivateAllActionSetLayers(ControllerHandle_t controllerHandle)
		{
		}

		[PreserveSig]
		private static extern int _GetActiveActionSetLayers(IntPtr self, ControllerHandle_t controllerHandle, [In][Out] ControllerActionSetHandle_t[] handlesOut);

		internal int GetActiveActionSetLayers(ControllerHandle_t controllerHandle, [In][Out] ControllerActionSetHandle_t[] handlesOut)
		{
			return 0;
		}

		[PreserveSig]
		private static extern ControllerDigitalActionHandle_t _GetDigitalActionHandle(IntPtr self, string pszActionName);

		internal ControllerDigitalActionHandle_t GetDigitalActionHandle(string pszActionName)
		{
			return default(ControllerDigitalActionHandle_t);
		}

		[PreserveSig]
		private static extern DigitalState _GetDigitalActionData(IntPtr self, ControllerHandle_t controllerHandle, ControllerDigitalActionHandle_t digitalActionHandle);

		internal DigitalState GetDigitalActionData(ControllerHandle_t controllerHandle, ControllerDigitalActionHandle_t digitalActionHandle)
		{
			return default(DigitalState);
		}

		[PreserveSig]
		private static extern int _GetDigitalActionOrigins(IntPtr self, ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetHandle, ControllerDigitalActionHandle_t digitalActionHandle, ref ControllerActionOrigin originsOut);

		internal int GetDigitalActionOrigins(ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetHandle, ControllerDigitalActionHandle_t digitalActionHandle, ref ControllerActionOrigin originsOut)
		{
			return 0;
		}

		[PreserveSig]
		private static extern ControllerAnalogActionHandle_t _GetAnalogActionHandle(IntPtr self, string pszActionName);

		internal ControllerAnalogActionHandle_t GetAnalogActionHandle(string pszActionName)
		{
			return default(ControllerAnalogActionHandle_t);
		}

		[PreserveSig]
		private static extern AnalogState _GetAnalogActionData(IntPtr self, ControllerHandle_t controllerHandle, ControllerAnalogActionHandle_t analogActionHandle);

		internal AnalogState GetAnalogActionData(ControllerHandle_t controllerHandle, ControllerAnalogActionHandle_t analogActionHandle)
		{
			return default(AnalogState);
		}

		[PreserveSig]
		private static extern int _GetAnalogActionOrigins(IntPtr self, ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetHandle, ControllerAnalogActionHandle_t analogActionHandle, ref ControllerActionOrigin originsOut);

		internal int GetAnalogActionOrigins(ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetHandle, ControllerAnalogActionHandle_t analogActionHandle, ref ControllerActionOrigin originsOut)
		{
			return 0;
		}

		[PreserveSig]
		private static extern Utf8StringPointer _GetGlyphForActionOrigin(IntPtr self, ControllerActionOrigin eOrigin);

		internal string GetGlyphForActionOrigin(ControllerActionOrigin eOrigin)
		{
			return null;
		}

		[PreserveSig]
		private static extern Utf8StringPointer _GetStringForActionOrigin(IntPtr self, ControllerActionOrigin eOrigin);

		internal string GetStringForActionOrigin(ControllerActionOrigin eOrigin)
		{
			return null;
		}

		[PreserveSig]
		private static extern void _StopAnalogActionMomentum(IntPtr self, ControllerHandle_t controllerHandle, ControllerAnalogActionHandle_t eAction);

		internal void StopAnalogActionMomentum(ControllerHandle_t controllerHandle, ControllerAnalogActionHandle_t eAction)
		{
		}

		[PreserveSig]
		private static extern MotionState _GetMotionData(IntPtr self, ControllerHandle_t controllerHandle);

		internal MotionState GetMotionData(ControllerHandle_t controllerHandle)
		{
			return default(MotionState);
		}

		[PreserveSig]
		private static extern void _TriggerHapticPulse(IntPtr self, ControllerHandle_t controllerHandle, SteamControllerPad eTargetPad, ushort usDurationMicroSec);

		internal void TriggerHapticPulse(ControllerHandle_t controllerHandle, SteamControllerPad eTargetPad, ushort usDurationMicroSec)
		{
		}

		[PreserveSig]
		private static extern void _TriggerRepeatedHapticPulse(IntPtr self, ControllerHandle_t controllerHandle, SteamControllerPad eTargetPad, ushort usDurationMicroSec, ushort usOffMicroSec, ushort unRepeat, uint nFlags);

		internal void TriggerRepeatedHapticPulse(ControllerHandle_t controllerHandle, SteamControllerPad eTargetPad, ushort usDurationMicroSec, ushort usOffMicroSec, ushort unRepeat, uint nFlags)
		{
		}

		[PreserveSig]
		private static extern void _TriggerVibration(IntPtr self, ControllerHandle_t controllerHandle, ushort usLeftSpeed, ushort usRightSpeed);

		internal void TriggerVibration(ControllerHandle_t controllerHandle, ushort usLeftSpeed, ushort usRightSpeed)
		{
		}

		[PreserveSig]
		private static extern void _SetLEDColor(IntPtr self, ControllerHandle_t controllerHandle, byte nColorR, byte nColorG, byte nColorB, uint nFlags);

		internal void SetLEDColor(ControllerHandle_t controllerHandle, byte nColorR, byte nColorG, byte nColorB, uint nFlags)
		{
		}

		[PreserveSig]
		private static extern bool _ShowBindingPanel(IntPtr self, ControllerHandle_t controllerHandle);

		internal bool ShowBindingPanel(ControllerHandle_t controllerHandle)
		{
			return false;
		}

		[PreserveSig]
		private static extern InputType _GetInputTypeForHandle(IntPtr self, ControllerHandle_t controllerHandle);

		internal InputType GetInputTypeForHandle(ControllerHandle_t controllerHandle)
		{
			return default(InputType);
		}

		[PreserveSig]
		private static extern ControllerHandle_t _GetControllerForGamepadIndex(IntPtr self, int nIndex);

		internal ControllerHandle_t GetControllerForGamepadIndex(int nIndex)
		{
			return default(ControllerHandle_t);
		}

		[PreserveSig]
		private static extern int _GetGamepadIndexForController(IntPtr self, ControllerHandle_t ulControllerHandle);

		internal int GetGamepadIndexForController(ControllerHandle_t ulControllerHandle)
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
		private static extern ControllerActionOrigin _GetActionOriginFromXboxOrigin(IntPtr self, ControllerHandle_t controllerHandle, XboxOrigin eOrigin);

		internal ControllerActionOrigin GetActionOriginFromXboxOrigin(ControllerHandle_t controllerHandle, XboxOrigin eOrigin)
		{
			return default(ControllerActionOrigin);
		}

		[PreserveSig]
		private static extern ControllerActionOrigin _TranslateActionOrigin(IntPtr self, InputType eDestinationInputType, ControllerActionOrigin eSourceOrigin);

		internal ControllerActionOrigin TranslateActionOrigin(InputType eDestinationInputType, ControllerActionOrigin eSourceOrigin)
		{
			return default(ControllerActionOrigin);
		}

		[PreserveSig]
		private static extern bool _GetControllerBindingRevision(IntPtr self, ControllerHandle_t controllerHandle, ref int pMajor, ref int pMinor);

		internal bool GetControllerBindingRevision(ControllerHandle_t controllerHandle, ref int pMajor, ref int pMinor)
		{
			return false;
		}
	}
}
