using UnityEngine.Bindings;

namespace UnityEngine
{
	[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
	internal struct EventInterests
	{
		public bool wantsMouseMove { get; set; }

		public bool wantsMouseEnterLeaveWindow { get; set; }

		public bool wantsLessLayoutEvents { get; }

		public bool WantsEvent(EventType type)
		{
			return false;
		}

		public bool WantsLayoutPass(EventType type)
		{
			return false;
		}
	}
}
