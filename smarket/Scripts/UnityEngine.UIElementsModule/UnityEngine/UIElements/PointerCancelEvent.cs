namespace UnityEngine.UIElements
{
	public sealed class PointerCancelEvent : PointerEventBase<PointerCancelEvent>
	{
		static PointerCancelEvent()
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
