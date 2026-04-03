using System.Collections.Generic;
using Unity.IntegerTime;

namespace UnityEngine.InputForUI
{
	internal class InputEventPartialProvider : IEventProviderImpl
	{
		private UnityEngine.Event _ev;

		private OperatingSystemFamily _operatingSystemFamily;

		private KeyEvent.ButtonsState _keyboardButtonsState;

		internal EventModifiers _eventModifiers;

		internal bool _sendNavigationEventOnTabKey;

		private IDictionary<string, CommandEvent.Command> _IMGUICommandToInputForUICommandType;

		public void Initialize()
		{
		}

		public void Shutdown()
		{
		}

		public void Update()
		{
		}

		public void OnFocusChanged(bool focus)
		{
		}

		public bool RequestCurrentState(Event.Type type)
		{
			return false;
		}

		private DiscreteTime GetTimestamp(in UnityEngine.Event ev)
		{
			return default(DiscreteTime);
		}

		private void UpdateEventModifiers(in UnityEngine.Event ev)
		{
		}

		private KeyEvent ToKeyEvent(in UnityEngine.Event ev)
		{
			return default(KeyEvent);
		}

		private TextInputEvent ToTextInputEvent(in UnityEngine.Event ev)
		{
			return default(TextInputEvent);
		}

		private void SendNextOrPreviousNavigationEventOnTabKeyDownEvent(in UnityEngine.Event ev)
		{
		}

		private CommandEvent ToCommandEvent(in UnityEngine.Event ev)
		{
			return default(CommandEvent);
		}
	}
}
