using System.Collections.Generic;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements
{
	[VisibleToOtherModules(new string[] { "UnityEditor.UIToolkitAuthoringModule" })]
	internal class AuthoringChanges
	{
		public HashSet<VisualElement> addedOrMovedElements { get; }

		public HashSet<VisualElement> removedFromPanel { get; }

		public HashSet<VisualElement> styleChanged { get; }

		public HashSet<VisualElement> stylingContextChanged { get; }

		public HashSet<VisualElement> bindingContextChanged { get; }

		public bool ContainsChanges()
		{
			return false;
		}

		public void Clear()
		{
		}
	}
}
