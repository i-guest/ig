using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.UIElements.Layout
{
	[NativeHeader("Modules/UIElements/Core/Layout/Native/LayoutNative.h")]
	internal static class LayoutNative
	{
		internal enum LayoutLogEventType
		{
			None = 0,
			Error = 1,
			Measure = 2,
			Layout = 3,
			CacheUsage = 4,
			BeginLayout = 5,
			EndLayout = 6
		}

		internal class LayoutLogData
		{
			public LayoutNode node;

			public LayoutLogEventType eventType;

			public string message;
		}

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<LayoutLogData> onLayoutLog;

		[NativeMethod(IsThreadSafe = false)]
		internal static void CalculateLayout(IntPtr node, float parentWidth, float parentHeight, int parentDirection, IntPtr state, IntPtr exceptionGCHandle)
		{
		}

		[RequiredByNativeCode]
		private static void LayoutLog_Internal(IntPtr nodePtr, LayoutLogEventType type, string message)
		{
		}
	}
}
