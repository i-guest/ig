using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.UIElements
{
	public struct FilterPassContext
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private int _003CfilterPassIndex_003Ek__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _003CwritesGamma_003Ek__BackingField;

		public FilterFunction filterFunction { get; internal set; }

		internal int filterPassIndex
		{
			[CompilerGenerated]
			set
			{
				_003CfilterPassIndex_003Ek__BackingField = value;
			}
		}

		public bool readsGamma { get; internal set; }

		internal bool writesGamma
		{
			[CompilerGenerated]
			set
			{
				_003CwritesGamma_003Ek__BackingField = value;
			}
		}
	}
}
