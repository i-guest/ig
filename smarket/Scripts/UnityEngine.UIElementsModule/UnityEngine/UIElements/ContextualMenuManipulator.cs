using System;

namespace UnityEngine.UIElements
{
	public class ContextualMenuManipulator : PointerManipulator
	{
		private Action<ContextualMenuPopulateEvent> m_MenuBuilder;

		public ContextualMenuManipulator(Action<ContextualMenuPopulateEvent> menuBuilder)
		{
		}

		protected override void RegisterCallbacksOnTarget()
		{
		}

		protected override void UnregisterCallbacksFromTarget()
		{
		}

		protected bool IsOSXContextualMenuPlatform()
		{
			return false;
		}

		private void OnPointerUpEvent(IPointerEvent evt)
		{
		}

		private void OnPointerDownEventOSX(IPointerEvent evt)
		{
		}

		private void OnPointerUpEventOSX(IPointerEvent evt)
		{
		}

		private void OnPointerMoveEvent(PointerMoveEvent evt)
		{
		}

		private void OnPointerMoveEventOSX(PointerMoveEvent evt)
		{
		}

		private void ProcessPointerEvent(IPointerEvent evt)
		{
		}

		private void OnKeyUpEvent(KeyUpEvent evt)
		{
		}

		private void DoDisplayMenu(EventBase evt)
		{
		}

		private void OnContextualMenuEvent(ContextualMenuPopulateEvent evt)
		{
		}
	}
}
