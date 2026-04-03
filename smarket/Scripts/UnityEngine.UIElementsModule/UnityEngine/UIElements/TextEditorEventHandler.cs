namespace UnityEngine.UIElements
{
	internal class TextEditorEventHandler
	{
		protected TextElement textElement;

		protected TextEditingUtilities editingUtilities;

		protected TextEditorEventHandler(TextElement textElement, TextEditingUtilities editingUtilities)
		{
		}

		public virtual void RegisterCallbacksOnTarget(VisualElement target)
		{
		}

		public virtual void UnregisterCallbacksFromTarget(VisualElement target)
		{
		}

		public virtual void HandleEventBubbleUp(EventBase evt)
		{
		}
	}
}
