using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Accessibility
{
	[VisibleToOtherModules(new string[] { "UnityEditor.AccessibilityModule" })]
	[NativeHeader("Modules/Accessibility/Native/AccessibilityManager.h")]
	internal class AccessibilityManager
	{
		public enum Notification : byte
		{
			None = 0,
			ScreenReaderStatusChanged = 1,
			ElementFocused = 2,
			ElementUnfocused = 3,
			FontScaleChanged = 4,
			BoldTextStatusChanged = 5,
			ClosedCaptioningStatusChanged = 6
		}

		public struct NotificationContext
		{
			public AccessibilityNode focusedNode { get; set; }

			public float fontScale { get; set; }

			public bool isBoldTextEnabled { get; set; }

			public bool isClosedCaptioningEnabled { get; set; }

			public bool isScreenReaderEnabled { get; set; }

			public Notification notification { get; set; }
		}

		private class Nested
		{
			internal static readonly AccessibilityManager s_Instance;

			static Nested()
			{
			}
		}

		private sealed class ExclusiveLock : IDisposable
		{
			private bool m_Disposed;

			~ExclusiveLock()
			{
			}

			private void InternalDispose()
			{
			}

			public void Dispose()
			{
			}
		}

		internal static Queue<NotificationContext> asyncNotificationContexts;

		private bool m_RefreshNodeFramesRequested;

		public static AccessibilityManager instance => null;

		public static bool isSupportedPlatform => false;

		public static event Action<bool> screenReaderStatusChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<AccessibilityNode> nodeFocusChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private AccessibilityManager()
		{
		}

		internal static bool IsScreenReaderEnabled()
		{
			return false;
		}

		internal static void SendScreenChangedNotification(int nodeId = -1)
		{
		}

		internal static void SendLayoutChangedNotification(int nodeId = -1)
		{
		}

		[ExcludeFromCodeCoverage]
		[VisibleToOtherModules(new string[] { "UnityEditor.AccessibilityModule" })]
		[RequiredByNativeCode]
		internal static void Internal_Initialize()
		{
		}

		[RequiredByNativeCode]
		internal static void Internal_Update()
		{
		}

		private void Internal_Update_Impl()
		{
		}

		[RequiredByNativeCode]
		internal static void Internal_LateUpdate()
		{
		}

		[RequiredByNativeCode]
		internal static int[] Internal_GetRootNodeIds()
		{
			return null;
		}

		[RequiredByNativeCode]
		internal static bool Internal_GetNode(int nodeId, ref AccessibilityNodeData nodeData)
		{
			return false;
		}

		[RequiredByNativeCode]
		internal static int Internal_GetNodeIdAt(float x, float y)
		{
			return 0;
		}

		[RequiredByNativeCode]
		internal static bool Internal_GetFirstOrLastRootNodeId(bool first, out int managedRootId)
		{
			managedRootId = default(int);
			return false;
		}

		[RequiredByNativeCode]
		internal static bool Internal_GetFirstOrLastChildId(int nodeId, bool first, out int childId)
		{
			childId = default(int);
			return false;
		}

		[RequiredByNativeCode]
		internal static bool Internal_GetNextOrPreviousSiblingId(int nodeId, bool next, out int siblingId)
		{
			siblingId = default(int);
			return false;
		}

		[RequiredByNativeCode]
		internal static void Internal_OnScreenReaderStatusChanged(bool enabled)
		{
		}

		[RequiredByNativeCode]
		internal static void Internal_OnWindowGeometryChanged()
		{
		}

		internal static void QueueNotification(NotificationContext notification)
		{
		}

		internal void QueueNotification_Impl(NotificationContext notification)
		{
		}

		internal static IDisposable GetExclusiveLock()
		{
			return null;
		}

		[ThreadSafe]
		private static void Lock()
		{
		}

		[ThreadSafe]
		private static void Unlock()
		{
		}
	}
}
