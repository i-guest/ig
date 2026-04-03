using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.UIElements
{
	[EventCategory(EventCategory.Tooltip)]
	public class TooltipEvent : EventBase<TooltipEvent>
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private string _003Ctooltip_003Ek__BackingField;

		public string tooltip
		{
			[CompilerGenerated]
			set
			{
				_003Ctooltip_003Ek__BackingField = value;
			}
		}

		public Rect rect { get; set; }

		static TooltipEvent()
		{
		}

		protected override void Init()
		{
		}

		private void LocalInit()
		{
		}
	}
}
