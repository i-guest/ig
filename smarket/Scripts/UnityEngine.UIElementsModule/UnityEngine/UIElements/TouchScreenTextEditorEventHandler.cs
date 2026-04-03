using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.UIElements
{
	internal class TouchScreenTextEditorEventHandler : TextEditorEventHandler
	{
		private IVisualElementScheduledItem m_TouchKeyboardPoller;

		private bool m_TouchKeyboardAllowsInPlaceEditing;

		private bool m_IsClicking;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static TouchScreenKeyboard _003CactiveTouchScreenKeyboard_003Ek__BackingField;

		internal static long Frame { get; private set; }

		private static TouchScreenKeyboard activeTouchScreenKeyboard
		{
			[CompilerGenerated]
			set
			{
				_003CactiveTouchScreenKeyboard_003Ek__BackingField = value;
			}
		}

		public TouchScreenTextEditorEventHandler(TextElement textElement, TextEditingUtilities editingUtilities)
			: base(null, null)
		{
		}

		private void PollTouchScreenKeyboard()
		{
		}

		private void DoPollTouchScreenKeyboard()
		{
		}

		private void UpdateStringPositionFromKeyboard()
		{
		}

		private void CloseTouchScreenKeyboard()
		{
		}

		private void OpenTouchScreenKeyboard()
		{
		}

		public override void HandleEventBubbleUp(EventBase evt)
		{
		}

		private void OnPointerDownEvent()
		{
		}

		private void OnPointerUpEvent(PointerUpEvent evt)
		{
		}

		private void OnFocusInEvent()
		{
		}

		private void OnFocusOutEvent(FocusOutEvent evt)
		{
		}
	}
}
