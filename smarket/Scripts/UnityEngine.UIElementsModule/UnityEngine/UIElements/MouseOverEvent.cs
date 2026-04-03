namespace UnityEngine.UIElements
{
	[EventCategory(EventCategory.EnterLeave)]
	public class MouseOverEvent : MouseEventBase<MouseOverEvent>
	{
		static MouseOverEvent()
		{
		}

		internal override void Dispatch(BaseVisualElementPanel panel)
		{
		}

		protected internal override void PreDispatch(IPanel panel)
		{
		}
	}
}
