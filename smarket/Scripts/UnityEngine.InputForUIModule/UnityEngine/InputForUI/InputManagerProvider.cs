using System.Collections;
using System.Collections.Generic;
using Unity.IntegerTime;

namespace UnityEngine.InputForUI
{
	internal class InputManagerProvider : IEventProviderImpl
	{
		private struct ButtonEventsIterator : IEnumerator
		{
			private uint _mask;

			private int _bit;

			public bool Current => false;

			object IEnumerator.Current => null;

			public bool MoveNext()
			{
				return false;
			}

			public void Reset()
			{
			}

			public static ButtonEventsIterator FromState(bool previous, bool down, bool up, bool current)
			{
				return default(ButtonEventsIterator);
			}
		}

		public struct Configuration
		{
			public string HorizontalAxis;

			public string VerticalAxis;

			public string SubmitButton;

			public string CancelButton;

			public string NavigateNextButton;

			public string NavigatePreviousButton;

			public float InputActionsPerSecond;

			public float RepeatDelay;

			public static Configuration GetDefaultConfiguration()
			{
				return default(Configuration);
			}
		}

		internal interface IInput
		{
			string compositionString { get; }

			bool touchSupported { get; }

			int touchCount { get; }

			bool mousePresent { get; }

			Vector3 mousePosition { get; }

			Vector2 mouseScrollDelta { get; }

			bool GetKey(KeyCode keyCode);

			bool GetButtonDown(string button);

			float GetAxisRaw(string axis);

			PenData GetLastPenContactEvent();

			Touch GetTouch(int index);

			bool GetMouseButton(int button);

			bool GetMouseButtonDown(int button);

			bool GetMouseButtonUp(int button);
		}

		private class Input : IInput
		{
			public string compositionString => null;

			public bool touchSupported => false;

			public int touchCount => 0;

			public bool mousePresent => false;

			public Vector3 mousePosition => default(Vector3);

			public Vector2 mouseScrollDelta => default(Vector2);

			public bool GetKey(KeyCode key)
			{
				return false;
			}

			public bool GetButtonDown(string button)
			{
				return false;
			}

			public float GetAxisRaw(string axis)
			{
				return 0f;
			}

			public PenData GetLastPenContactEvent()
			{
				return default(PenData);
			}

			public Touch GetTouch(int index)
			{
				return default(Touch);
			}

			public bool GetMouseButton(int button)
			{
				return false;
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

		internal interface ITime
		{
			RationalTime timeAsRational { get; }
		}

		private class Time : ITime
		{
			public RationalTime timeAsRational => default(RationalTime);
		}

		private InputEventPartialProvider _inputEventPartialProvider;

		private string _compositionString;

		private Configuration _configuration;

		private IInput _input;

		private ITime _time;

		private NavigationEventRepeatHelper _navigationEventRepeatHelper;

		private PointerState _mouseState;

		private bool _isPenPresent;

		private bool _seenAtLeastOnePenPosition;

		private Vector2 _lastSeenPenPositionForDetection;

		private PointerState _penState;

		private PenData _lastPenData;

		private Dictionary<int, int> _touchFingerIdToFingerIndex;

		private int _touchNextFingerIndex;

		private PointerState _touchState;

		private EventModifiers _eventModifiers => default(EventModifiers);

		public void Initialize()
		{
		}

		public void Shutdown()
		{
		}

		public void Update()
		{
		}

		private bool CheckTouchEvents(DiscreteTime currentTime)
		{
			return false;
		}

		private void DetectPen()
		{
		}

		private static PointerEvent.Button PenStatusToButton(PenStatus status)
		{
			return default(PointerEvent.Button);
		}

		private bool CheckPenEvent(DiscreteTime currentTime, in PenData currentPenData)
		{
			return false;
		}

		private void CheckMouseEvents(DiscreteTime currentTime, bool muted = false)
		{
		}

		private void CheckMouseScroll(DiscreteTime currentTime)
		{
		}

		private void NextPreviousNavigation(DiscreteTime currentTime)
		{
		}

		private void SubmitCancelNavigation(DiscreteTime currentTime)
		{
		}

		private void DirectionNavigation(DiscreteTime currentTime)
		{
		}

		private void CheckIfIMEChanged(DiscreteTime currentTime)
		{
		}

		public void OnFocusChanged(bool focus)
		{
		}

		private EventSource GetEventSourceFromPressedKey()
		{
			return default(EventSource);
		}

		private bool InputManagerJoystickWasPressed()
		{
			return false;
		}

		private bool InputManagerKeyboardWasPressed()
		{
			return false;
		}

		private float InputManagerGetAxisRawOrDefault(string axisName)
		{
			return 0f;
		}

		private bool InputManagerGetButtonDownOrDefault(string axisName)
		{
			return false;
		}

		private (Vector2, bool) ReadCurrentNavigationMoveVector()
		{
			return default((Vector2, bool));
		}

		private IMECompositionEvent ToIMECompositionEvent(DiscreteTime currentTime, string compositionString)
		{
			return default(IMECompositionEvent);
		}

		internal static float TiltToAzimuth(Vector2 tilt)
		{
			return 0f;
		}

		internal static Vector2 AzimuthAndAlitutudeToTilt(float altitude, float azimuth)
		{
			return default(Vector2);
		}

		internal static float TiltToAltitude(Vector2 tilt)
		{
			return 0f;
		}

		private static Vector2 MultiDisplayBottomLeftToPanelPosition(Vector2 position, out int targetDisplay)
		{
			targetDisplay = default(int);
			return default(Vector2);
		}

		private static Vector2 MultiDisplayToLocalScreenPosition(Vector2 position, out int? targetDisplay)
		{
			targetDisplay = null;
			return default(Vector2);
		}

		private static Vector2 ScreenBottomLeftToPanelPosition(Vector2 position, int targetDisplay)
		{
			return default(Vector2);
		}

		private static Vector2 ScreenBottomLeftToPanelDelta(Vector2 delta)
		{
			return default(Vector2);
		}
	}
}
