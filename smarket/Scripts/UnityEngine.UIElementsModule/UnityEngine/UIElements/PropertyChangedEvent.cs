using UnityEngine.Bindings;

namespace UnityEngine.UIElements
{
	[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal class PropertyChangedEvent : EventBase<PropertyChangedEvent>
	{
		public BindingId property { get; set; }

		static PropertyChangedEvent()
		{
		}

		public static PropertyChangedEvent GetPooled(in BindingId property)
		{
			return null;
		}
	}
}
