using System.Collections.Generic;

namespace UnityEngine.UIElements
{
	public readonly struct CanStartDragArgs
	{
		public readonly VisualElement draggedElement;

		public readonly int id;

		public readonly IEnumerable<int> selectedIds;

		internal readonly EventModifiers modifiers;

		internal CanStartDragArgs(VisualElement draggedElement, int id, IEnumerable<int> selectedIds, EventModifiers modifiers)
		{
			this.draggedElement = null;
			this.id = 0;
			this.selectedIds = null;
			this.modifiers = default(EventModifiers);
		}
	}
}
