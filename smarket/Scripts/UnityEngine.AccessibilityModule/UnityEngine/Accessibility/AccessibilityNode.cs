using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.Accessibility
{
	public class AccessibilityNode
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Action<AccessibilityNode, bool> focusChanged;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Func<bool> invoked;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Action incremented;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Action decremented;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Func<AccessibilityScrollDirection, bool> scrolled;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Func<bool> dismissed;

		private AccessibilityHierarchy m_Hierarchy;

		internal List<AccessibilityNode> childList;

		private string m_Label;

		private string m_Value;

		private string m_Hint;

		private Rect m_Frame;

		private Func<Rect> m_FrameGetter;

		private AccessibilityRole m_Role;

		private AccessibilityState m_State;

		private bool m_IsActive;

		private bool m_AllowsDirectInteraction;

		public IReadOnlyList<AccessibilityNode> children => null;

		public AccessibilityNode parent { get; }

		public string label => null;

		public string value => null;

		public string hint => null;

		public Rect frame
		{
			get
			{
				return default(Rect);
			}
			set
			{
			}
		}

		public Func<Rect> frameGetter => null;

		public int id { get; private set; }

		public AccessibilityRole role => default(AccessibilityRole);

		public AccessibilityState state => default(AccessibilityState);

		public bool isActive => false;

		public bool allowsDirectInteraction => false;

		private void CreateNativeNodeWithData(ref AccessibilityNodeData nodeData)
		{
		}

		internal void GetNodeData(ref AccessibilityNodeData nodeData)
		{
		}

		internal void AllocateNative()
		{
		}

		internal void FreeNative(bool freeChildren)
		{
		}

		private bool IsInActiveHierarchy()
		{
			return false;
		}

		internal void NotifyFocusChanged(bool isNodeFocused)
		{
		}

		internal void InvokeFocusChanged(bool isNodeFocused)
		{
		}

		internal bool InvokeNodeInvoked()
		{
			return false;
		}

		internal bool InvokeIncremented()
		{
			return false;
		}

		internal bool InvokeDecremented()
		{
			return false;
		}

		internal bool InvokeScrolled(AccessibilityScrollDirection direction)
		{
			return false;
		}

		internal bool InvokeDismissed()
		{
			return false;
		}
	}
}
