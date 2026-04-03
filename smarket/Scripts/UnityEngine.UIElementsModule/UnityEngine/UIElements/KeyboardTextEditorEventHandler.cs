namespace UnityEngine.UIElements
{
	internal class KeyboardTextEditorEventHandler : TextEditorEventHandler
	{
		internal bool m_Changed;

		internal bool m_ShouldInvokeUpdateValue;

		public KeyboardTextEditorEventHandler(TextElement textElement, TextEditingUtilities editingUtilities)
			: base(null, null)
		{
		}

		public override void HandleEventBubbleUp(EventBase evt)
		{
		}

		private void OnFocus(FocusEvent _)
		{
		}

		private void OnBlur(BlurEvent _)
		{
		}

		private void OnIMEInput(IMEEvent _)
		{
		}

		private void OnKeyDown(KeyDownEvent evt)
		{
		}

		private void ApplyTextIfNeeded()
		{
		}

		private void UpdateLabel(bool generatePreview)
		{
		}

		private void OnValidateCommandEvent(ValidateCommandEvent evt)
		{
		}

		private void OnExecuteCommandEvent(ExecuteCommandEvent evt)
		{
		}

		private void OnNavigationEvent<TEvent>(NavigationEventBase<TEvent> evt) where TEvent : NavigationEventBase<TEvent>, new()
		{
		}
	}
}
