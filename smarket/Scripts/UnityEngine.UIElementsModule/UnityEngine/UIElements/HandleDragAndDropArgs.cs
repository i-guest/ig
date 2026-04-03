using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.UIElements
{
	public readonly struct HandleDragAndDropArgs
	{
		private readonly DragAndDropArgs m_DragAndDropArgs;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly Vector2 _003Cposition_003Ek__BackingField;

		internal HandleDragAndDropArgs(Vector2 position, DragAndDropArgs dragAndDropArgs)
		{
			m_DragAndDropArgs = default(DragAndDropArgs);
			_003Cposition_003Ek__BackingField = default(Vector2);
		}
	}
}
