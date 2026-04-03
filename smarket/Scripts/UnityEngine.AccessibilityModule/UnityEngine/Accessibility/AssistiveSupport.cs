using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace UnityEngine.Accessibility
{
	public static class AssistiveSupport
	{
		internal class NotificationDispatcher : IAccessibilityNotificationDispatcher
		{
			public void SendScreenChanged(AccessibilityNode nodeToFocus = null)
			{
			}

			public void SendLayoutChanged(AccessibilityNode nodeToFocus = null)
			{
			}
		}

		public enum ScreenReaderStatusOverride : byte
		{
			OSDriven = 0,
			ForceEnabled = 1,
			ForceDisabled = 2
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action<bool> screenReaderStatusChanged;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action<AccessibilityNode> nodeFocusChanged;

		private static ScreenReaderStatusOverride s_ScreenReaderStatusOverride;

		public static IAccessibilityNotificationDispatcher notificationDispatcher { get; }

		public static AccessibilityHierarchy activeHierarchy => null;

		public static bool isScreenReaderEnabled => false;

		public static ScreenReaderStatusOverride screenReaderStatusOverride => default(ScreenReaderStatusOverride);

		[ExcludeFromCodeCoverage]
		internal static void Initialize()
		{
		}

		internal static void ScreenReaderStatusChanged(bool enabled)
		{
		}

		private static void NodeFocusChanged(AccessibilityNode currentNode)
		{
		}
	}
}
