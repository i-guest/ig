using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements
{
	[VisibleToOtherModules(new string[] { "UnityEditor.UIToolkitAuthoringModule" })]
	internal static class UIElementsRuntimeUtility
	{
		public delegate BaseRuntimePanel CreateRuntimePanelDelegate(ScriptableObject ownerObject);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action<BaseRuntimePanel> onWillDestroyPanel;

		private static bool s_RegisteredPlayerloopCallback;

		private static readonly List<BaseRuntimePanel> s_SortedScreenOverlayPanels;

		private static readonly List<BaseRuntimePanel> s_CachedWorldSpacePanels;

		private static readonly List<BaseRuntimePanel> s_SortedPlayerPanels;

		private static bool s_PanelOrderingOrDrawInCameraDirty;

		internal static int s_ResolvedSortingIndexMax;

		private static int currentOverlayIndex;

		private static DefaultEventSystem s_DefaultEventSystem;

		private static List<PanelSettings> s_PotentiallyEmptyPanelSettings;

		internal static Object activeEventSystem { get; private set; }

		internal static bool useDefaultEventSystem => false;

		internal static bool? overrideUseDefaultEventSystem { get; set; }

		internal static bool autoUpdateEventSystem { get; }

		internal static DefaultEventSystem defaultEventSystem => null;

		public static event Action<BaseRuntimePanel> onCreatePanel
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

		static UIElementsRuntimeUtility()
		{
		}

		public static EventBase CreateEvent(Event systemEvent)
		{
			return null;
		}

		public static BaseRuntimePanel FindOrCreateRuntimePanel(ScriptableObject ownerObject, CreateRuntimePanelDelegate createDelegate)
		{
			return null;
		}

		public static void DisposeRuntimePanel(ScriptableObject ownerObject)
		{
		}

		private static void GetPlayerPanelsByRenderMode(List<BaseRuntimePanel> outScreenSpaceOverlayPanels, List<BaseRuntimePanel> outWorldSpacePanels)
		{
		}

		private static void RegisterCachedPanelInternal(int instanceID, IPanel panel)
		{
		}

		private static void RemoveCachedPanelInternal(int instanceID)
		{
		}

		public static void RenderOffscreenPanels()
		{
		}

		public static void RepaintPanel(BaseRuntimePanel panel)
		{
		}

		public static void RenderPanel(BaseRuntimePanel panel, bool restoreState = true)
		{
		}

		internal static void BeginRenderOverlays(int displayIndex)
		{
		}

		internal static void RenderOverlaysBeforePriority(int displayIndex, float maxPriority)
		{
		}

		internal static void EndRenderOverlays(int displayIndex)
		{
		}

		public static void RepaintPanels(bool onlyOffscreen)
		{
		}

		public static void RegisterEventSystem(Object eventSystem)
		{
		}

		public static void UnregisterEventSystem(Object eventSystem)
		{
		}

		public static void UpdatePanels()
		{
		}

		internal static void UpdateEventSystem()
		{
		}

		internal static void MarkPotentiallyEmpty(PanelSettings settings)
		{
		}

		internal static void RemoveUnusedPanels()
		{
		}

		public static void EnableRenderingAndInputCallbacks()
		{
		}

		public static void DisableRenderingAndInputCallbacks()
		{
		}

		internal static void SetPanelOrderingDirty()
		{
		}

		internal static void SetPanelsDrawInCameraDirty()
		{
		}

		internal static List<BaseRuntimePanel> GetWorldSpacePlayerPanels()
		{
			return null;
		}

		public static List<BaseRuntimePanel> GetSortedScreenOverlayPlayerPanels()
		{
			return null;
		}

		public static List<BaseRuntimePanel> GetSortedPlayerPanels()
		{
			return null;
		}

		private static void SortPanels()
		{
		}

		internal static Vector2 MultiDisplayBottomLeftToPanelPosition(Vector2 position, out int? targetDisplay)
		{
			targetDisplay = null;
			return default(Vector2);
		}

		internal static Vector2 MultiDisplayToLocalScreenPosition(Vector2 position, out int? targetDisplay)
		{
			targetDisplay = null;
			return default(Vector2);
		}

		internal static Vector2 ScreenBottomLeftToPanelPosition(Vector2 position, int targetDisplay)
		{
			return default(Vector2);
		}

		internal static Vector2 ScreenBottomLeftToPanelDelta(Vector2 delta)
		{
			return default(Vector2);
		}

		internal static Vector2 PanelToScreenBottomLeftPosition(Vector2 panelPosition, int targetDisplay)
		{
			return default(Vector2);
		}

		internal static Vector2 FlipY(Vector2 p, float displayHeight)
		{
			return default(Vector2);
		}

		private static Vector2 FlipDeltaY(Vector2 delta)
		{
			return default(Vector2);
		}

		private static float GetRuntimeDisplayHeight(int targetDisplay)
		{
			return 0f;
		}
	}
}
