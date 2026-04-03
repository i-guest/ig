using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.UIElements
{
	public class DropdownMenu
	{
		private List<DropdownMenuItem> m_MenuItems;

		private DropdownMenuEventInfo m_DropdownMenuEventInfo;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _003CrepaintPanelBeforeDisplay_003Ek__BackingField;

		internal int Count => 0;

		internal bool repaintPanelBeforeDisplay
		{
			[CompilerGenerated]
			set
			{
				_003CrepaintPanelBeforeDisplay_003Ek__BackingField = value;
			}
		}

		public List<DropdownMenuItem> MenuItems()
		{
			return null;
		}

		public void AppendAction(string actionName, Action<DropdownMenuAction> action, Func<DropdownMenuAction, DropdownMenuAction.Status> actionStatusCallback, object userData = null)
		{
		}

		public void AppendAction(string actionName, Action<DropdownMenuAction> action, DropdownMenuAction.Status status = DropdownMenuAction.Status.Normal)
		{
		}

		public void AppendSeparator(string subMenuPath = null)
		{
		}

		public void InsertSeparator(string subMenuPath, int atIndex)
		{
		}

		public void PrepareForDisplay(EventBase e)
		{
		}
	}
}
