namespace UnityEngine.UIElements
{
	public abstract class ContextualMenuManager
	{
		internal bool displayMenuHandledOSX { get; set; }

		internal virtual bool CheckIfEventMatches(EventBase evt)
		{
			return false;
		}

		public void DisplayMenu(EventBase triggerEvent, IEventHandler target)
		{
		}

		internal void DisplayMenu(EventBase triggerEvent, IEventHandler target, DropdownMenu menu)
		{
		}

		protected internal abstract void DoDisplayMenu(DropdownMenu menu, EventBase triggerEvent);

		internal static void ResetPointerDown(int pointerId)
		{
		}

		internal void BeforePointerDown()
		{
		}

		internal void AfterPointerUp()
		{
		}
	}
}
