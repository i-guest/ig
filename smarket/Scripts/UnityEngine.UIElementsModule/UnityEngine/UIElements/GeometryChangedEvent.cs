using UnityEngine.Bindings;

namespace UnityEngine.UIElements
{
	[EventCategory(EventCategory.Geometry)]
	public class GeometryChangedEvent : EventBase<GeometryChangedEvent>
	{
		public Rect oldRect { get; private set; }

		public Rect newRect { get; private set; }

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal int layoutPass { get; set; }

		static GeometryChangedEvent()
		{
		}

		public static GeometryChangedEvent GetPooled(Rect oldRect, Rect newRect)
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
