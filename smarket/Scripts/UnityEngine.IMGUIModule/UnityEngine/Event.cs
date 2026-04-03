using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[StructLayout((LayoutKind)0)]
	[NativeHeader("Modules/IMGUI/Event.bindings.h")]
	[StaticAccessor("GUIEvent", StaticAccessorType.DoubleColon)]
	public sealed class Event
	{
		internal static class BindingsMarshaller
		{
			public static IntPtr ConvertToNative(Event e)
			{
				return (IntPtr)0;
			}
		}

		[NonSerialized]
		internal IntPtr m_Ptr;

		internal const float scrollWheelDeltaPerTick = 3f;

		internal static bool s_AllowOutsideOnGUI;

		private static Event s_Current;

		private static Event s_MasterEvent;

		[NativeProperty("type", false, TargetType.Field)]
		public EventType rawType => default(EventType);

		[NativeProperty("mousePosition", false, TargetType.Field)]
		public Vector2 mousePosition
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		[NativeProperty("delta", false, TargetType.Field)]
		public Vector2 delta
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		[NativeProperty("pointerType", false, TargetType.Field)]
		public PointerType pointerType => default(PointerType);

		[NativeProperty("button", false, TargetType.Field)]
		public int button => 0;

		[NativeProperty("modifiers", false, TargetType.Field)]
		public EventModifiers modifiers => default(EventModifiers);

		[NativeProperty("pressure", false, TargetType.Field)]
		public float pressure => 0f;

		[NativeProperty("twist", false, TargetType.Field)]
		public float twist => 0f;

		[NativeProperty("tilt", false, TargetType.Field)]
		public Vector2 tilt => default(Vector2);

		[NativeProperty("penStatus", false, TargetType.Field)]
		public PenStatus penStatus => default(PenStatus);

		[NativeProperty("clickCount", false, TargetType.Field)]
		public int clickCount => 0;

		[NativeProperty("character", false, TargetType.Field)]
		public char character => '\0';

		[NativeProperty("keycode", false, TargetType.Field)]
		private KeyCode Internal_keyCode => default(KeyCode);

		public KeyCode keyCode => default(KeyCode);

		[NativeProperty("displayIndex", false, TargetType.Field)]
		public int displayIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public EventType type
		{
			[FreeFunction("GUIEvent::GetType", HasExplicitThis = true)]
			get
			{
				return default(EventType);
			}
			[FreeFunction("GUIEvent::SetType", HasExplicitThis = true)]
			set
			{
			}
		}

		public string commandName
		{
			[FreeFunction("GUIEvent::GetCommandName", HasExplicitThis = true)]
			get
			{
				return null;
			}
			[FreeFunction("GUIEvent::SetCommandName", HasExplicitThis = true)]
			set
			{
			}
		}

		public bool shift => false;

		public bool control => false;

		public bool alt => false;

		public bool command => false;

		public bool capsLock => false;

		public bool numeric => false;

		public bool functionKey => false;

		public static Event current
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool isKey => false;

		public bool isMouse => false;

		public bool isScrollWheel => false;

		internal bool isDirectManipulationDevice
		{
			[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
			get
			{
				return false;
			}
		}

		[NativeMethod("Use")]
		private void Internal_Use()
		{
		}

		[FreeFunction("GUIEvent::Internal_Create", IsThreadSafe = true)]
		private static IntPtr Internal_Create(int displayIndex)
		{
			return (IntPtr)0;
		}

		[FreeFunction("GUIEvent::Internal_Destroy", IsThreadSafe = true)]
		private static void Internal_Destroy(IntPtr ptr)
		{
		}

		[FreeFunction("GUIEvent::GetTypeForControl", HasExplicitThis = true)]
		public EventType GetTypeForControl(int controlID)
		{
			return default(EventType);
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
		[FreeFunction("GUIEvent::CopyFromPtr", IsThreadSafe = true, HasExplicitThis = true)]
		internal void CopyFromPtr(IntPtr ptr)
		{
		}

		public static bool PopEvent([NotNull] Event outEvent)
		{
			return false;
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.InputForUIModule" })]
		internal static void GetEventAtIndex(int index, [NotNull] Event outEvent)
		{
		}

		public static int GetEventCount()
		{
			return 0;
		}

		private static void Internal_SetNativeEvent(IntPtr ptr)
		{
		}

		[RequiredByNativeCode]
		internal static void Internal_MakeMasterEventCurrent(int displayIndex)
		{
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule", "UnityEngine.InputForUIModule" })]
		internal static int GetDoubleClickTime()
		{
			return 0;
		}

		public Event()
		{
		}

		public Event(int displayIndex)
		{
		}

		~Event()
		{
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
		internal void CopyFrom(Event e)
		{
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}

		public void Use()
		{
		}

		private static EventType get_rawType_Injected(IntPtr _unity_self)
		{
			return default(EventType);
		}

		private static void get_mousePosition_Injected(IntPtr _unity_self, out Vector2 ret)
		{
			ret = default(Vector2);
		}

		private static void set_mousePosition_Injected(IntPtr _unity_self, [In] ref Vector2 value)
		{
		}

		private static void get_delta_Injected(IntPtr _unity_self, out Vector2 ret)
		{
			ret = default(Vector2);
		}

		private static void set_delta_Injected(IntPtr _unity_self, [In] ref Vector2 value)
		{
		}

		private static PointerType get_pointerType_Injected(IntPtr _unity_self)
		{
			return default(PointerType);
		}

		private static int get_button_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static EventModifiers get_modifiers_Injected(IntPtr _unity_self)
		{
			return default(EventModifiers);
		}

		private static float get_pressure_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static float get_twist_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static void get_tilt_Injected(IntPtr _unity_self, out Vector2 ret)
		{
			ret = default(Vector2);
		}

		private static PenStatus get_penStatus_Injected(IntPtr _unity_self)
		{
			return default(PenStatus);
		}

		private static int get_clickCount_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static char get_character_Injected(IntPtr _unity_self)
		{
			return '\0';
		}

		private static KeyCode get_Internal_keyCode_Injected(IntPtr _unity_self)
		{
			return default(KeyCode);
		}

		private static int get_displayIndex_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static void set_displayIndex_Injected(IntPtr _unity_self, int value)
		{
		}

		private static EventType get_type_Injected(IntPtr _unity_self)
		{
			return default(EventType);
		}

		private static void set_type_Injected(IntPtr _unity_self, EventType value)
		{
		}

		private static void get_commandName_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret)
		{
			ret = default(ManagedSpanWrapper);
		}

		private static void set_commandName_Injected(IntPtr _unity_self, ref ManagedSpanWrapper value)
		{
		}

		private static void Internal_Use_Injected(IntPtr _unity_self)
		{
		}

		private static EventType GetTypeForControl_Injected(IntPtr _unity_self, int controlID)
		{
			return default(EventType);
		}

		private static void CopyFromPtr_Injected(IntPtr _unity_self, IntPtr ptr)
		{
		}

		private static bool PopEvent_Injected(IntPtr outEvent)
		{
			return false;
		}

		private static void GetEventAtIndex_Injected(int index, IntPtr outEvent)
		{
		}
	}
}
