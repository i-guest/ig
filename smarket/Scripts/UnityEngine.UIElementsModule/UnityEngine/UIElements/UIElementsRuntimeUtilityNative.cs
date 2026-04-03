using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.UIElements
{
	[VisibleToOtherModules(new string[] { "Unity.UIElements" })]
	[NativeHeader("Modules/UIElements/Core/Native/UIElementsRuntimeUtilityNative.h")]
	internal static class UIElementsRuntimeUtilityNative
	{
		private static Action UpdatePanelsCallback;

		private static Action<bool> RepaintPanelsCallback;

		private static Action RenderOffscreenPanelsCallback;

		[RequiredByNativeCode]
		public static void UpdatePanels()
		{
		}

		[RequiredByNativeCode]
		public static void RepaintPanels(bool onlyOffscreen)
		{
		}

		[RequiredByNativeCode]
		public static void RenderOffscreenPanels()
		{
		}

		public static void SetUpdateCallback(Action callback)
		{
		}

		public static void SetRenderingCallbacks(Action<bool> repaintPanels, Action renderOffscreenPanels)
		{
		}

		public static void UnsetRenderingCallbacks()
		{
		}

		private static void RegisterRenderingCallbacks()
		{
		}

		private static void UnregisterRenderingCallbacks()
		{
		}

		public static void VisualElementCreation()
		{
		}
	}
}
