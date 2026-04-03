namespace UnityEngine.UIElements
{
	internal class ElementUnderPointer
	{
		private VisualElement[] m_PendingTopElementUnderPointer;

		private VisualElement[] m_TopElementUnderPointer;

		private IPointerOrMouseEvent[] m_TriggerEvent;

		private Vector2[] m_PickingPointerPositions;

		private readonly bool[] m_IsPrimaryPointer;

		private bool[] m_IsPickingPointerTemporaries;

		internal VisualElement GetTopElementUnderPointer(int pointerId, out Vector2 pickPosition, out bool isTemporary)
		{
			pickPosition = default(Vector2);
			isTemporary = default(bool);
			return null;
		}

		internal VisualElement GetTopElementUnderPointer(int pointerId)
		{
			return null;
		}

		internal void RemoveElementUnderPointer(VisualElement elementToRemove)
		{
		}

		internal void SetElementUnderPointer(VisualElement newElementUnderPointer, int pointerId, Vector2 pointerPos)
		{
		}

		private Vector2 GetEventPointerPosition(EventBase triggerEvent)
		{
			return default(Vector2);
		}

		internal void SetTemporaryElementUnderPointer(VisualElement newElementUnderPointer, int pointerId, EventBase triggerEvent)
		{
		}

		internal void SetElementUnderPointer(VisualElement newElementUnderPointer, int pointerId, EventBase triggerEvent)
		{
		}

		private void SetElementUnderPointer(VisualElement newElementUnderPointer, int pointerId, EventBase triggerEvent, bool temporary)
		{
		}

		internal bool CommitElementUnderPointers(EventDispatcher dispatcher, ContextType contextType)
		{
			return false;
		}
	}
}
