using System;
using System.Collections.Generic;
using Unity.IntegerTime;
using UnityEngine.InputForUI;

namespace UnityEngine.InputSystem.Plugins.InputForUI
{
	internal class InputSystemProvider : IEventProviderImpl
	{
		public static class Actions
		{
			public static readonly string PointAction;

			public static readonly string MoveAction;

			public static readonly string SubmitAction;

			public static readonly string CancelAction;

			public static readonly string LeftClickAction;

			public static readonly string MiddleClickAction;

			public static readonly string RightClickAction;

			public static readonly string ScrollWheelAction;
		}

		private InputEventPartialProvider m_InputEventPartialProvider;

		private DefaultInputActions m_DefaultInputActions;

		private InputActionAsset m_InputActionAsset;

		private InputAction m_PointAction;

		private InputAction m_MoveAction;

		private InputAction m_SubmitAction;

		private InputAction m_CancelAction;

		private InputAction m_LeftClickAction;

		private InputAction m_MiddleClickAction;

		private InputAction m_RightClickAction;

		private InputAction m_ScrollWheelAction;

		private InputAction m_NextPreviousAction;

		private List<Event> m_Events;

		private PointerState m_MouseState;

		private PointerState m_PenState;

		private bool m_SeenPenEvents;

		private PointerState m_TouchState;

		private bool m_SeenTouchEvents;

		private const float k_SmallestReportedMovementSqrDist = 0.01f;

		private NavigationEventRepeatHelper m_RepeatHelper;

		private bool m_ResetSeenEventsOnUpdate;

		private const float kScrollUGUIScaleFactor = 3f;

		private static Action<InputActionAsset> s_OnRegisterActions;

		private const uint k_DefaultPlayerId = 0u;

		private EventModifiers m_EventModifiers => default(EventModifiers);

		private DiscreteTime m_CurrentTime => default(DiscreteTime);

		public uint playerCount => 0u;

		static InputSystemProvider()
		{
		}

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void Bootstrap()
		{
		}

		public void Initialize()
		{
		}

		public void Shutdown()
		{
		}

		public void OnActionsChange()
		{
		}

		public void Update()
		{
		}

		private void ResetSeenEvents()
		{
		}

		public bool ActionAssetIsNotNull()
		{
			return false;
		}

		private void DirectionNavigation(DiscreteTime currentTime)
		{
		}

		private InputDevice GetActiveDeviceFromDirection(NavigationEvent.Direction direction)
		{
			return null;
		}

		private (Vector2, bool) ReadCurrentNavigationMoveVector()
		{
			return default((Vector2, bool));
		}

		private NavigationEvent.Direction ReadNextPreviousDirection()
		{
			return default(NavigationEvent.Direction);
		}

		private static int SortEvents(Event a, Event b)
		{
			return 0;
		}

		public void OnFocusChanged(bool focus)
		{
		}

		public bool RequestCurrentState(Event.Type type)
		{
			return false;
		}

		internal static Vector2 ScreenBottomLeftToPanelPosition(Vector2 position, int targetDisplay)
		{
			return default(Vector2);
		}

		private PointerEvent ToPointerStateEvent(DiscreteTime currentTime, in PointerState state, EventSource eventSource)
		{
			return default(PointerEvent);
		}

		private EventSource GetEventSource(InputAction.CallbackContext ctx)
		{
			return default(EventSource);
		}

		private EventSource GetEventSource(InputDevice device)
		{
			return default(EventSource);
		}

		private ref PointerState GetPointerStateForSource(EventSource eventSource)
		{
			throw null;
		}

		private void DispatchFromCallback(in Event ev)
		{
		}

		private static int FindTouchFingerIndex(Touchscreen touchscreen, InputAction.CallbackContext ctx)
		{
			return 0;
		}

		private void OnPointerPerformed(InputAction.CallbackContext ctx)
		{
		}

		private void OnSubmitPerformed(InputAction.CallbackContext ctx)
		{
		}

		private void OnCancelPerformed(InputAction.CallbackContext ctx)
		{
		}

		private void OnClickPerformed(InputAction.CallbackContext ctx, EventSource eventSource, PointerEvent.Button button)
		{
		}

		private void OnLeftClickPerformed(InputAction.CallbackContext ctx)
		{
		}

		private void OnMiddleClickPerformed(InputAction.CallbackContext ctx)
		{
		}

		private void OnRightClickPerformed(InputAction.CallbackContext ctx)
		{
		}

		private void OnScrollWheelPerformed(InputAction.CallbackContext ctx)
		{
		}

		private void RegisterFixedActions()
		{
		}

		private void UnregisterFixedActions()
		{
		}

		private InputAction FindActionAndRegisterCallback(string actionNameOrId, Action<InputAction.CallbackContext> callback = null)
		{
			return null;
		}

		private void RegisterActions()
		{
		}

		private void UnregisterAction(ref InputAction action, Action<InputAction.CallbackContext> callback = null)
		{
		}

		private void UnregisterActions()
		{
		}

		private void SelectInputActionAsset()
		{
		}

		internal static void SetOnRegisterActions(Action<InputActionAsset> callback)
		{
		}
	}
}
