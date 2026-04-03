using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Accessibility
{
	[RequiredByNativeCode]
	[NativeType(CodegenOptions.Custom, "MonoAccessibilityNodeData")]
	[NativeHeader("Modules/Accessibility/Bindings/AccessibilityNodeData.bindings.h")]
	[NativeHeader("Modules/Accessibility/Native/AccessibilityNodeData.h")]
	internal struct AccessibilityNodeData
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private int[] _003CchildIds_003Ek__BackingField;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private string _003Clabel_003Ek__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string _003Cvalue_003Ek__BackingField;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private string _003Chint_003Ek__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Rect _003Cframe_003Ek__BackingField;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private int _003CparentId_003Ek__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private AccessibilityRole _003Crole_003Ek__BackingField;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private AccessibilityState _003Cstate_003Ek__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _003CisActive_003Ek__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _003CallowsDirectInteraction_003Ek__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _003CimplementsInvoked_003Ek__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _003CimplementsScrolled_003Ek__BackingField;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private bool _003CimplementsDismissed_003Ek__BackingField;

		public int[] childIds
		{
			[CompilerGenerated]
			set
			{
				_003CchildIds_003Ek__BackingField = value;
			}
		}

		public string label
		{
			[CompilerGenerated]
			set
			{
				_003Clabel_003Ek__BackingField = value;
			}
		}

		public string value
		{
			[CompilerGenerated]
			set
			{
				_003Cvalue_003Ek__BackingField = value;
			}
		}

		public string hint
		{
			[CompilerGenerated]
			set
			{
				_003Chint_003Ek__BackingField = value;
			}
		}

		public Rect frame
		{
			[CompilerGenerated]
			set
			{
				_003Cframe_003Ek__BackingField = value;
			}
		}

		public int nodeId { get; set; }

		public int parentId
		{
			[CompilerGenerated]
			set
			{
				_003CparentId_003Ek__BackingField = value;
			}
		}

		public AccessibilityRole role
		{
			[CompilerGenerated]
			set
			{
				_003Crole_003Ek__BackingField = value;
			}
		}

		public AccessibilityState state
		{
			[CompilerGenerated]
			set
			{
				_003Cstate_003Ek__BackingField = value;
			}
		}

		public bool isActive
		{
			[CompilerGenerated]
			set
			{
				_003CisActive_003Ek__BackingField = value;
			}
		}

		public bool allowsDirectInteraction
		{
			[CompilerGenerated]
			set
			{
				_003CallowsDirectInteraction_003Ek__BackingField = value;
			}
		}

		public bool implementsInvoked
		{
			[CompilerGenerated]
			set
			{
				_003CimplementsInvoked_003Ek__BackingField = value;
			}
		}

		public bool implementsScrolled
		{
			[CompilerGenerated]
			set
			{
				_003CimplementsScrolled_003Ek__BackingField = value;
			}
		}

		public bool implementsDismissed
		{
			[CompilerGenerated]
			set
			{
				_003CimplementsDismissed_003Ek__BackingField = value;
			}
		}

		public AccessibilityNodeData()
		{
			_003CchildIds_003Ek__BackingField = null;
			_003Clabel_003Ek__BackingField = null;
			_003Cvalue_003Ek__BackingField = null;
			_003Chint_003Ek__BackingField = null;
			_003Cframe_003Ek__BackingField = default(Rect);
			nodeId = 0;
			_003CparentId_003Ek__BackingField = 0;
			_003Crole_003Ek__BackingField = default(AccessibilityRole);
			_003Cstate_003Ek__BackingField = default(AccessibilityState);
			_003CisActive_003Ek__BackingField = false;
			_003CallowsDirectInteraction_003Ek__BackingField = false;
			_003CimplementsInvoked_003Ek__BackingField = false;
			_003CimplementsScrolled_003Ek__BackingField = false;
			_003CimplementsDismissed_003Ek__BackingField = false;
		}
	}
}
