namespace UnityEngine.UIElements
{
	public class KeyDownEvent : KeyboardEventBase<KeyDownEvent>
	{
		static KeyDownEvent()
		{
		}

		protected internal override void PostDispatch(IPanel panel)
		{
		}

		private void SendEquivalentNavigationEventIfAny(IPanel panel)
		{
		}
	}
}
