using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Accessibility
{
	[VisibleToOtherModules(new string[] { "UnityEditor.AccessibilityModule" })]
	[NativeHeader("Modules/Accessibility/Native/AccessibilityNodeDataTests.h")]
	internal class AccessibilityNodeDataTests
	{
		internal static AccessibilityNodeData nodeDataFromNative;

		[RequiredByNativeCode]
		internal static void Internal_GetNodeDataFromManaged(ref AccessibilityNodeData nodeData)
		{
		}

		[RequiredByNativeCode]
		internal static void Internal_GetNodeDataToManaged(in AccessibilityNodeData nodeData)
		{
		}
	}
}
