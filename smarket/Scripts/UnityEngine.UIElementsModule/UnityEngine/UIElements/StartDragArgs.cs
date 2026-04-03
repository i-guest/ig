using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.UIElements
{
	public struct StartDragArgs
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private EventModifiers _003Cmodifiers_003Ek__BackingField;

		public string title { get; }

		public DragVisualMode visualMode { get; }

		internal EventModifiers modifiers
		{
			[CompilerGenerated]
			set
			{
				_003Cmodifiers_003Ek__BackingField = value;
			}
		}

		internal Hashtable genericData { get; private set; }

		internal IReadOnlyList<EntityId> entityIds { get; private set; }

		internal string[] assetPaths { get; private set; }

		public StartDragArgs(string title, DragVisualMode visualMode)
		{
			this.title = null;
			this.visualMode = default(DragVisualMode);
			_003Cmodifiers_003Ek__BackingField = default(EventModifiers);
			genericData = null;
			entityIds = null;
			assetPaths = null;
		}

		internal StartDragArgs(string title, DragVisualMode visualMode, EventModifiers modifiers)
		{
			this.title = null;
			this.visualMode = default(DragVisualMode);
			this._003Cmodifiers_003Ek__BackingField = default(EventModifiers);
			genericData = null;
			entityIds = null;
			assetPaths = null;
		}

		public void SetGenericData(string key, object data)
		{
		}
	}
}
