namespace UnityEngine.UIElements
{
	[EventCategory(EventCategory.PointerDown)]
	public sealed class PointerDownEvent : PointerEventBase<PointerDownEvent>
	{
		static PointerDownEvent()
		{
		}

		protected override void Init()
		{
		}

		private void LocalInit()
		{
		}

		internal override IMouseEvent GetPooledCompatibilityMouseEvent()
		{
			return null;
		}

		protected internal override void PreDispatch(IPanel panel)
		{
		}

		protected internal override void PostDispatch(IPanel panel)
		{
		}

		internal override void Dispatch(BaseVisualElementPanel panel)
		{
		}
	}
}
