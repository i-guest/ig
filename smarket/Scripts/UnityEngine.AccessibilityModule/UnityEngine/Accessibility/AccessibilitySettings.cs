using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Accessibility
{
	[NativeHeader("Modules/Accessibility/Native/AccessibilitySettings.h")]
	public static class AccessibilitySettings
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action<float> fontScaleChanged;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action<bool> boldTextStatusChanged;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action<bool> closedCaptioningStatusChanged;

		[RequiredByNativeCode]
		internal static void Internal_OnFontScaleChanged(float newFontScale)
		{
		}

		[RequiredByNativeCode]
		internal static void Internal_OnBoldTextStatusChanged(bool enabled)
		{
		}

		[RequiredByNativeCode]
		internal static void Internal_OnClosedCaptioningStatusChanged(bool enabled)
		{
		}

		internal static void InvokeFontScaleChanged(float newFontScale)
		{
		}

		internal static void InvokeBoldTextStatusChanged(bool enabled)
		{
		}

		internal static void InvokeClosedCaptionStatusChanged(bool enabled)
		{
		}
	}
}
