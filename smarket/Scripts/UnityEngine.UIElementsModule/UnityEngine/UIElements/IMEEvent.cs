using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.UIElements
{
	[EventCategory(EventCategory.Keyboard)]
	internal class IMEEvent : EventBase<IMEEvent>
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private string _003CcompositionString_003Ek__BackingField;

		protected string compositionString
		{
			[CompilerGenerated]
			set
			{
				_003CcompositionString_003Ek__BackingField = value;
			}
		}

		static IMEEvent()
		{
		}

		public static IMEEvent GetPooled(string compositionString)
		{
			return null;
		}

		protected override void Init()
		{
		}

		private void LocalInit()
		{
		}
	}
}
