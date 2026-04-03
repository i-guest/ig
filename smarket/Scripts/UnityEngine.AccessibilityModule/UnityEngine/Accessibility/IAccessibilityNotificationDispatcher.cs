namespace UnityEngine.Accessibility
{
	public interface IAccessibilityNotificationDispatcher
	{
		void SendScreenChanged(AccessibilityNode nodeToFocus = null);

		void SendLayoutChanged(AccessibilityNode nodeToFocus = null);
	}
}
