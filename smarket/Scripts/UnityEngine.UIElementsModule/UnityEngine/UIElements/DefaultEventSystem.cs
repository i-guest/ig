using System;
using System.Collections.Generic;
using Unity.IntegerTime;
using UnityEngine.InputForUI;

namespace UnityEngine.UIElements
{
	internal class DefaultEventSystem
	{
		public enum UpdateMode
		{
			Always = 0,
			IgnoreIfAppNotFocused = 1
		}

		internal struct FocusBasedEventSequenceContext : IDisposable
		{
			private DefaultEventSystem es;

			public FocusBasedEventSequenceContext(DefaultEventSystem es)
			{
				this.es = null;
			}

			public void Dispose()
			{
			}
		}

		private class InputForUIProcessor
		{
			private readonly DefaultEventSystem m_EventSystem;

			private DiscreteTime m_LastPointerTimestamp;

			private DiscreteTime m_NextPointerTimestamp;

			private readonly Queue<UnityEngine.InputForUI.Event> m_EventList;

			public InputForUIProcessor(DefaultEventSystem eventSystem)
			{
			}

			public void Reset()
			{
			}

			public bool OnEvent(in UnityEngine.InputForUI.Event ev)
			{
				return false;
			}

			public void ProcessInputForUIEvents()
			{
			}

			private EventModifiers GetModifiers(UnityEngine.InputForUI.EventModifiers eventModifiers)
			{
				return default(EventModifiers);
			}

			private void ProcessPointerEvent(PointerEvent pointerEvent)
			{
			}

			private void ProcessNavigationEvent(NavigationEvent navigationEvent)
			{
			}

			private void ProcessKeyEvent(KeyEvent keyEvent)
			{
			}

			private void ProcessTextInputEvent(TextInputEvent textInputEvent)
			{
			}

			private void ProcessCommandEvent(CommandEvent commandEvent)
			{
			}

			private void ProcessIMECompositionEvent(IMECompositionEvent compositionEvent)
			{
			}
		}

		internal class LegacyInputProcessor
		{
			internal interface IInput
			{
				int touchCount { get; }

				bool mousePresent { get; }

				Vector3 mousePosition { get; }

				int mouseButtonCount { get; }

				bool anyKey { get; }

				float unscaledTime { get; }

				float doubleClickTime { get; }

				bool GetButtonDown(string button);

				float GetAxisRaw(string axis);

				void ClearLastPenContactEvent();

				PenData GetLastPenContactEvent();

				Touch GetTouch(int index);

				bool GetMouseButtonDown(int button);

				bool GetMouseButtonUp(int button);
			}

			private class Input : IInput
			{
				public int touchCount => 0;

				public bool mousePresent => false;

				public Vector3 mousePosition => default(Vector3);

				public int mouseButtonCount => 0;

				public bool anyKey => false;

				public float unscaledTime => 0f;

				public float doubleClickTime => 0f;

				public bool GetButtonDown(string button)
				{
					return false;
				}

				public float GetAxisRaw(string axis)
				{
					return 0f;
				}

				public void ClearLastPenContactEvent()
				{
				}

				public PenData GetLastPenContactEvent()
				{
					return default(PenData);
				}

				public Touch GetTouch(int index)
				{
					return default(Touch);
				}

				public bool GetMouseButtonDown(int button)
				{
					return false;
				}

				public bool GetMouseButtonUp(int button)
				{
					return false;
				}
			}

			private class NoInput : IInput
			{
				public int touchCount => 0;

				public bool mousePresent => false;

				public Vector3 mousePosition => default(Vector3);

				public int mouseButtonCount => 0;

				public bool anyKey => false;

				public float unscaledTime => 0f;

				public float doubleClickTime => 0f;

				public bool GetButtonDown(string button)
				{
					return false;
				}

				public float GetAxisRaw(string axis)
				{
					return 0f;
				}

				public Touch GetTouch(int index)
				{
					return default(Touch);
				}

				public void ClearLastPenContactEvent()
				{
				}

				public PenData GetLastPenContactEvent()
				{
					return default(PenData);
				}

				public bool GetMouseButtonDown(int button)
				{
					return false;
				}

				public bool GetMouseButtonUp(int button)
				{
					return false;
				}
			}

			private bool m_SendingTouchEvents;

			private bool m_SendingPenEvent;

			private EventModifiers m_CurrentModifiers;

			private int m_LastMousePressButton;

			private float m_NextMousePressTime;

			private int m_LastMouseClickCount;

			private Vector2 m_LastMousePosition;

			private bool m_MouseProcessedAtLeastOnce;

			private Dictionary<int, int> m_TouchFingerIdToFingerIndex;

			private int m_TouchNextFingerIndex;

			private IInput m_Input;

			private readonly Event m_Event;

			private readonly DefaultEventSystem m_EventSystem;

			private int m_ConsecutiveMoveCount;

			private Vector2 m_LastMoveVector;

			private float m_PrevActionTime;

			private bool m_IsMoveFromKeyboard;

			private EventModifiers m_CurrentPointerModifiers => default(EventModifiers);

			public IInput input => null;

			public LegacyInputProcessor(DefaultEventSystem eventSystem)
			{
			}

			public IInput GetDefaultInput()
			{
				return null;
			}

			public void ProcessLegacyInputEvents()
			{
			}

			private void SendIMGUIEvents()
			{
			}

			private void ProcessMouseEvents()
			{
			}

			private void SendInputEvents()
			{
			}

			private bool ProcessTouchEvents()
			{
				return false;
			}

			private bool ProcessPenEvents()
			{
				return false;
			}

			private Vector2 GetRawMoveVector()
			{
				return default(Vector2);
			}

			private bool ShouldSendMoveFromInput()
			{
				return false;
			}

			private void ProcessTabEvent(Event e, EventModifiers modifiers)
			{
			}

			private static EventBase MakeTouchEvent(Touch touch, int pointerId, EventModifiers modifiers, int targetDisplay)
			{
				return null;
			}

			private static EventBase MakePenEvent(PenData pen, EventModifiers modifiers, int targetDisplay)
			{
				return null;
			}
		}

		internal static Func<bool> IsEditorRemoteConnected;

		private RuntimePanel m_FocusedPanel;

		private RuntimePanel m_PreviousFocusedPanel;

		private Focusable m_PreviousFocusedElement;

		private int m_UpdateFrameCount;

		private LegacyInputProcessor m_LegacyInputProcessor;

		private InputForUIProcessor m_InputForUIProcessor;

		private bool m_IsInputReady;

		private bool m_UseInputForUI;

		private bool m_IsInputForUIActive;

		private IScreenRaycaster m_Raycaster;

		private readonly PhysicsDocumentPicker m_WorldSpacePicker;

		private readonly ScreenOverlayPanelPicker m_ScreenOverlayPicker;

		public float worldSpaceMaxDistance;

		public int worldSpaceLayers;

		private static readonly Vector3 s_InvalidPanelCoordinates;

		internal bool verbose;

		internal bool logToGameScreen;

		private Label m_LogLabel;

		private List<string> m_LogLines;

		private bool isAppFocused => false;

		public RuntimePanel focusedPanel
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal LegacyInputProcessor legacyInputProcessor => null;

		private InputForUIProcessor inputForUIProcessor => null;

		internal bool isInputReady
		{
			set
			{
			}
		}

		public IScreenRaycaster raycaster
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private bool ShouldIgnoreEventsOnAppNotFocused()
		{
			return false;
		}

		public void Update(UpdateMode updateMode = UpdateMode.Always)
		{
		}

		internal FocusBasedEventSequenceContext FocusBasedEventSequence()
		{
			return default(FocusBasedEventSequenceContext);
		}

		private void RemoveInputProcessor()
		{
		}

		private void InitInputProcessor()
		{
		}

		internal void OnFocusEvent(RuntimePanel panel, FocusEvent evt)
		{
		}

		internal void SendFocusBasedEvent<TArg>(Func<TArg, EventBase> evtFactory, TArg arg)
		{
		}

		internal void SendPositionBasedEvent<TArg>(Vector3 mousePosition, Vector3 delta, int pointerId, int? targetDisplay, Func<Vector3, Vector3, TArg, EventBase> evtFactory, TArg arg, bool deselectIfNoTarget = false)
		{
		}

		internal void SendPositionBasedEvent<TArg>(Vector3 mousePosition, Vector3 delta, int pointerId, int? targetDisplay, Func<Vector3, TArg, EventBase> evtFactory, TArg arg, bool deselectIfNoTarget = false)
		{
		}

		internal void SendRayBasedEvent<TArg>(Ray worldRay, float maxDistance, int pointerId, Func<Vector3, TArg, EventBase> evtFactory, TArg arg, bool deselectIfNoTarget = false)
		{
		}

		internal void FindTargetAtPosition(Vector2 mousePosition, Vector2 delta, int pointerId, int? targetDisplay, out VisualElement target, out RuntimePanel targetPanel, out Vector3 targetPanelPosition, out VisualElement elementUnderPointer, out Camera camera)
		{
			target = null;
			targetPanel = null;
			targetPanelPosition = default(Vector3);
			elementUnderPointer = null;
			camera = null;
		}

		internal void FindTargetAtRay(Ray worldRay, float maxDistance, int pointerId, out VisualElement target, out RuntimePanel targetPanel, out Vector3 targetPanelPosition, out VisualElement elementUnderPointer)
		{
			target = null;
			targetPanel = null;
			targetPanelPosition = default(Vector3);
			elementUnderPointer = null;
		}

		private Vector3 GetPanelPosition(VisualElement pickedElement, UIDocument document, Ray worldRay)
		{
			return default(Vector3);
		}

		private void UpdateFocusedPanel(RuntimePanel runtimePanel)
		{
		}

		private void UpdateWorldSpacePointers()
		{
		}

		private void Log(object o)
		{
		}

		private void LogWarning(object o)
		{
		}

		private void LogToGameScreen(string s)
		{
		}
	}
}
