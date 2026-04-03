using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.UIElements
{
	public abstract class DragAndDropData
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string[] _003Cpaths_003Ek__BackingField;

		public abstract object source { get; }

		public virtual string[] paths
		{
			[CompilerGenerated]
			set
			{
				_003Cpaths_003Ek__BackingField = value;
			}
		}

		public abstract object GetGenericData(string key);
	}
}
