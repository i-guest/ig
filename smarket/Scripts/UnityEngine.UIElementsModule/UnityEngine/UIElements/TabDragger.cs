namespace UnityEngine.UIElements
{
	internal class TabDragger : PointerManipulator
	{
		private float m_StartPos;

		private float m_LastPos;

		private bool m_Moving;

		private bool m_Cancelled;

		private VisualElement m_Header;

		private TabView m_TabView;

		private VisualElement m_PreviewElement;

		private TabDragLocationPreview m_LocationPreviewElement;

		private VisualElement m_TabToMove;

		private float m_TabToMovePos;

		private VisualElement m_DestinationTab;

		private bool m_MoveBeforeDestination;

		private int m_DraggingPointerId;

		private TabLayout tabLayout { get; set; }

		internal bool active { get; set; }

		internal bool isVertical { get; set; }

		internal bool moving
		{
			get
			{
				return false;
			}
			private set
			{
			}
		}

		protected override void RegisterCallbacksOnTarget()
		{
		}

		protected override void UnregisterCallbacksFromTarget()
		{
		}

		private void OnPointerDown(PointerDownEvent evt)
		{
		}

		private void OnPointerMove(PointerMoveEvent evt)
		{
		}

		private void OnPointerUp(PointerUpEvent evt)
		{
		}

		private void OnPointerCancel(PointerCancelEvent evt)
		{
		}

		private void OnPointerCaptureOut(PointerCaptureOutEvent evt)
		{
		}

		private void ProcessCancelEvent(EventBase evt, int pointerId)
		{
		}

		private void OnKeyDown(KeyDownEvent e)
		{
		}

		private void ProcessDownEvent(EventBase evt, Vector2 localPosition, int pointerId)
		{
		}

		private void ProcessMoveEvent(EventBase e, Vector2 localPosition)
		{
		}

		private void ProcessUpEvent(EventBase evt, Vector2 localPosition, int pointerId)
		{
		}

		private void BeginDragMove(float pos)
		{
		}

		private void DragMove(float pos)
		{
		}

		private void UpdatePreviewPosition()
		{
		}

		private void UpdateMoveLocation()
		{
		}

		private void EndDragMove(bool cancelled)
		{
		}
	}
}
