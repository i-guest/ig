namespace UnityEngine.UIElements
{
	[EventCategory(EventCategory.PointerMove)]
	public sealed class PointerMoveEvent : PointerEventBase<PointerMoveEvent>
	{
		internal bool isHandledByDraggable { get; set; }

		internal bool isPointerDown => false;

		internal bool isPointerUp => false;

		static PointerMoveEvent()
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
