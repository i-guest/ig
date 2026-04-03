using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.UIElements
{
	public class TreeViewExpansionChangedArgs
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int _003Cid_003Ek__BackingField;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private bool _003CisExpanded_003Ek__BackingField;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private bool _003CisAppliedToAllChildren_003Ek__BackingField;

		public int id
		{
			[CompilerGenerated]
			set
			{
				_003Cid_003Ek__BackingField = value;
			}
		}

		public bool isExpanded
		{
			[CompilerGenerated]
			set
			{
				_003CisExpanded_003Ek__BackingField = value;
			}
		}

		public bool isAppliedToAllChildren
		{
			[CompilerGenerated]
			set
			{
				_003CisAppliedToAllChildren_003Ek__BackingField = value;
			}
		}
	}
}
