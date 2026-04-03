namespace UnityEngine.UIElements
{
	internal class TextEditingManipulator
	{
		private readonly TextElement m_TextElement;

		private TextEditorEventHandler m_EditingEventHandler;

		internal TextEditingUtilities editingUtilities;

		private bool m_TouchScreenTextFieldInitialized;

		private IVisualElementScheduledItem m_HardwareKeyboardPoller;

		internal TextEditorEventHandler editingEventHandler
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private bool touchScreenTextFieldChanged => false;

		public TextEditingManipulator(TextElement textElement)
		{
		}

		public void Reset()
		{
		}

		private void InitTextEditorEventHandler()
		{
		}

		internal void HandleEventBubbleUp(EventBase evt)
		{
		}

		private void OnFocusInEvent()
		{
		}

		private void OnFocusOutEvent()
		{
		}
	}
}
