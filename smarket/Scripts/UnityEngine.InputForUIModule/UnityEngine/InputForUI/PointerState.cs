using Unity.IntegerTime;

namespace UnityEngine.InputForUI
{
	internal struct PointerState
	{
		private PointerEvent.ButtonsState _buttonsState;

		private static readonly DiscreteTime kClickDelay;

		public PointerEvent.Button LastPressedButton { get; private set; }

		public PointerEvent.ButtonsState ButtonsState => default(PointerEvent.ButtonsState);

		public DiscreteTime NextPressTime { get; private set; }

		public int ClickCount { get; private set; }

		public Vector2 LastPosition { get; private set; }

		public int LastDisplayIndex { get; private set; }

		public bool LastPositionValid { get; set; }

		public void OnButtonDown(DiscreteTime currentTime, PointerEvent.Button button)
		{
		}

		public void OnButtonUp(DiscreteTime currentTime, PointerEvent.Button button)
		{
		}

		public void OnButtonChange(DiscreteTime currentTime, PointerEvent.Button button, bool previousState, bool newState)
		{
		}

		public void OnMove(DiscreteTime currentTime, Vector2 position, int displayIndex)
		{
		}

		public void Reset()
		{
		}
	}
}
