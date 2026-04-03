using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[NativeHeader("Runtime/Input/InputManager.h")]
	[NativeHeader("Runtime/Camera/RenderLayers/GUITexture.h")]
	[NativeHeader("Runtime/Utilities/CopyPaste.h")]
	[NativeHeader("Modules/IMGUI/GUIManager.h")]
	[NativeHeader("Modules/IMGUI/GUIUtility.h")]
	[NativeHeader("Runtime/Input/InputBindings.h")]
	public class GUIUtility
	{
		internal static int s_ControlCount;

		[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
		internal static int s_SkinMode;

		[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
		internal static int s_OriginalID;

		[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
		internal static Action takeCapture;

		[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
		internal static Action releaseCapture;

		[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
		internal static Func<int, IntPtr, bool> processEvent;

		[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
		internal static Action cleanupRoots;

		[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
		internal static Func<Exception, bool> endContainerGUIFromException;

		[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
		internal static Action guiChanged;

		internal static Action<EventType, KeyCode, EventModifiers> beforeEventProcessed;

		private static Event m_Event;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static bool _003CguiIsExiting_003Ek__BackingField;

		internal static Func<bool> s_HasCurrentWindowKeyFocusFunc;

		[NativeProperty("GetGUIState().m_PixelsPerPoint", true, TargetType.Field)]
		internal static float pixelsPerPoint
		{
			[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule", "UnityEditor.UIToolkitAuthoringModule" })]
			get
			{
				return 0f;
			}
			[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
			set
			{
			}
		}

		[NativeProperty("GetGUIState().m_OnGUIDepth", true, TargetType.Field)]
		internal static int guiDepth
		{
			[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
			get
			{
				return 0;
			}
		}

		[NativeProperty("GetGUIState().m_CanvasGUIState.m_IsMouseUsed", true, TargetType.Field)]
		internal static bool mouseUsed
		{
			set
			{
			}
		}

		[StaticAccessor("GetInputManager()", StaticAccessorType.Dot)]
		internal static bool textFieldInput => false;

		public static string systemCopyBuffer
		{
			[FreeFunction("GetCopyBuffer")]
			get
			{
				return null;
			}
			[FreeFunction("SetCopyBuffer")]
			set
			{
			}
		}

		[StaticAccessor("InputBindings", StaticAccessorType.DoubleColon)]
		internal static string compositionString => null;

		[StaticAccessor("InputBindings", StaticAccessorType.DoubleColon)]
		internal static IMECompositionMode imeCompositionMode
		{
			[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
			set
			{
			}
		}

		[StaticAccessor("InputBindings", StaticAccessorType.DoubleColon)]
		internal static Vector2 compositionCursorPos
		{
			set
			{
			}
		}

		internal static bool guiIsExiting
		{
			[CompilerGenerated]
			set
			{
				_003CguiIsExiting_003Ek__BackingField = value;
			}
		}

		public static int hotControl
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static int keyboardControl
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
		internal static bool isUITK { get; set; }

		[FreeFunction("GetGUIState().GetControlID")]
		private static int Internal_GetControlID(int hint, FocusType focusType, Rect rect)
		{
			return 0;
		}

		public static int GetControlID(int hint, FocusType focusType, Rect rect)
		{
			return 0;
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
		internal static void BeginContainerFromOwner(ScriptableObject owner)
		{
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
		internal static void BeginContainer(ObjectGUIState objectGUIState)
		{
		}

		[NativeMethod("EndContainer")]
		internal static void Internal_EndContainer()
		{
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
		internal static int CheckForTabEvent(Event evt)
		{
			return 0;
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
		internal static void SetKeyboardControlToFirstControlId()
		{
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
		internal static void SetKeyboardControlToLastControlId()
		{
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
		internal static bool HasFocusableControls()
		{
			return false;
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
		internal static bool OwnsId(int id)
		{
			return false;
		}

		public static Rect AlignRectToDevice(Rect rect, out int widthInPixels, out int heightInPixels)
		{
			widthInPixels = default(int);
			heightInPixels = default(int);
			return default(Rect);
		}

		private static int Internal_GetHotControl()
		{
			return 0;
		}

		private static int Internal_GetKeyboardControl()
		{
			return 0;
		}

		private static void Internal_SetHotControl(int value)
		{
		}

		private static void Internal_SetKeyboardControl(int value)
		{
		}

		private static object Internal_GetDefaultSkin(int skinMode)
		{
			return null;
		}

		private static void Internal_ExitGUI()
		{
		}

		[RequiredByNativeCode]
		private static void MarkGUIChanged()
		{
		}

		public static int GetControlID(int hint, FocusType focus)
		{
			return 0;
		}

		public static object GetStateObject(Type t, int controlID)
		{
			return null;
		}

		[RequiredByNativeCode]
		internal static void TakeCapture()
		{
		}

		[RequiredByNativeCode]
		internal static void RemoveCapture()
		{
		}

		internal static bool HasKeyFocus(int controlID)
		{
			return false;
		}

		public static void ExitGUI()
		{
		}

		internal static GUISkin GetDefaultSkin()
		{
			return null;
		}

		[RequiredByNativeCode]
		internal static void ProcessEvent(int instanceID, IntPtr nativeEventPtr, out bool result)
		{
			result = default(bool);
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
		internal static void EndContainer()
		{
		}

		[RequiredByNativeCode]
		internal static void BeginGUI(int skinMode, int instanceID, int useGUILayout)
		{
		}

		[RequiredByNativeCode]
		internal static void DestroyGUI(int instanceID)
		{
		}

		[RequiredByNativeCode]
		internal static void EndGUI(int layoutType)
		{
		}

		[RequiredByNativeCode]
		internal static bool EndGUIFromException(Exception exception)
		{
			return false;
		}

		[RequiredByNativeCode]
		internal static bool EndContainerGUIFromException(Exception exception)
		{
			return false;
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
		internal static void ResetGlobalState()
		{
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
		internal static bool IsExitGUIException(Exception exception)
		{
			return false;
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
		internal static bool ShouldRethrowException(Exception exception)
		{
			return false;
		}

		internal static void CheckOnGUI()
		{
		}

		internal static void WarnOnGUI()
		{
		}

		public static Rect AlignRectToDevice(Rect rect)
		{
			return default(Rect);
		}

		internal static bool HitTest(Rect rect, Vector2 point, int offset)
		{
			return false;
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
		internal static bool HitTest(Rect rect, Vector2 point, bool isDirectManipulationDevice)
		{
			return false;
		}

		internal static bool HitTest(Rect rect, Event evt)
		{
			return false;
		}

		private static void get_systemCopyBuffer_Injected(out ManagedSpanWrapper ret)
		{
			ret = default(ManagedSpanWrapper);
		}

		private static void set_systemCopyBuffer_Injected(ref ManagedSpanWrapper value)
		{
		}

		private static int Internal_GetControlID_Injected(int hint, FocusType focusType, [In] ref Rect rect)
		{
			return 0;
		}

		private static void BeginContainerFromOwner_Injected(IntPtr owner)
		{
		}

		private static void BeginContainer_Injected(IntPtr objectGUIState)
		{
		}

		private static int CheckForTabEvent_Injected(IntPtr evt)
		{
			return 0;
		}

		private static void AlignRectToDevice_Injected([In] ref Rect rect, out int widthInPixels, out int heightInPixels, out Rect ret)
		{
			widthInPixels = default(int);
			heightInPixels = default(int);
			ret = default(Rect);
		}

		private static void get_compositionString_Injected(out ManagedSpanWrapper ret)
		{
			ret = default(ManagedSpanWrapper);
		}

		private static void set_compositionCursorPos_Injected([In] ref Vector2 value)
		{
		}
	}
}
