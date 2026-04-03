using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.UIElements
{
	internal class RepaintData
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Vector2 _003CmousePosition_003Ek__BackingField;

		public Matrix4x4 currentOffset { get; }

		public Rect currentWorldClip { get; }

		public Event repaintEvent { get; set; }
	}
}
