using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Accessibility
{
	[NativeHeader("Modules/Accessibility/Native/AccessibilityNodeManager.h")]
	internal static class AccessibilityNodeManager
	{
		internal static bool CreateNativeNodeWithData(AccessibilityNodeData nodeData)
		{
			return false;
		}

		internal static void DestroyNativeNode(int nodeId)
		{
		}

		internal static void SetFrame(int nodeId, Rect frame)
		{
		}

		[RequiredByNativeCode]
		internal static void Internal_InvokeFocusChanged(int nodeId, bool isNodeFocused)
		{
		}

		[RequiredByNativeCode]
		internal static bool Internal_InvokeNodeInvoked(int nodeId)
		{
			return false;
		}

		[RequiredByNativeCode]
		internal static bool Internal_InvokeIncremented(int nodeId)
		{
			return false;
		}

		[RequiredByNativeCode]
		internal static bool Internal_InvokeDecremented(int nodeId)
		{
			return false;
		}

		[RequiredByNativeCode]
		internal static bool Internal_InvokeScrolled(int nodeId, AccessibilityScrollDirection direction)
		{
			return false;
		}

		[RequiredByNativeCode]
		internal static bool Internal_InvokeDismissed(int nodeId)
		{
			return false;
		}

		private static bool CreateNativeNodeWithData_Injected([In] ref AccessibilityNodeData nodeData)
		{
			return false;
		}

		private static void SetFrame_Injected(int nodeId, [In] ref Rect frame)
		{
		}
	}
}
