namespace UnityEngine.UIElements
{
	internal class ScreenOverlayPanelPicker
	{
		public bool TryPick(BaseRuntimePanel panel, int pointerId, Vector2 screenPosition, Vector2 delta, int? targetDisplay, out bool captured)
		{
			captured = default(bool);
			return false;
		}

		private bool GetCapturingPanel(int pointerId, out BaseVisualElementPanel capturingPanel)
		{
			capturingPanel = null;
			return false;
		}
	}
}
