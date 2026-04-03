using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace UnityEngine.UIElements
{
	internal static class EventDispatchUtilities
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void PropagateEvent(EventBase evt, [NotNull] BaseVisualElementPanel panel, [NotNull] VisualElement target, bool isCapturingTarget)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SendEventDirectlyToTarget(EventBase evt, BaseVisualElementPanel panel, [NotNull] VisualElement target)
		{
		}

		public static void HandleEventAtTargetAndDefaultPhase(EventBase evt, BaseVisualElementPanel panel, VisualElement target)
		{
		}

		private static void HandleEventAcrossPropagationPath(EventBase evt, [NotNull] BaseVisualElementPanel panel, [NotNull] VisualElement target, bool isCapturingTarget)
		{
		}

		private static void HandleEventAcrossPropagationPathWithCompatibilityEvent(EventBase evt, [NotNull] EventBase compatibilityEvt, [NotNull] BaseVisualElementPanel panel, [NotNull] VisualElement target, bool isCapturingTarget)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void HandleEvent_DefaultActionAtTarget(EventBase evt, [NotNull] BaseVisualElementPanel panel, [NotNull] VisualElement element, bool disabled)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void HandleEvent_DefaultAction(EventBase evt, [NotNull] BaseVisualElementPanel panel, [NotNull] VisualElement element, bool disabled)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void HandleEvent_TrickleDownCallbacks(EventBase evt, [NotNull] BaseVisualElementPanel panel, [NotNull] VisualElement element)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void HandleEvent_BubbleUpCallbacks(EventBase evt, [NotNull] BaseVisualElementPanel panel, [NotNull] VisualElement element)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void HandleEvent_TrickleDownHandleEvent(EventBase evt, [NotNull] BaseVisualElementPanel panel, [NotNull] VisualElement element, bool disabled)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void HandleEvent_BubbleUpHandleEvent(EventBase evt, [NotNull] BaseVisualElementPanel panel, [NotNull] VisualElement element, bool disabled)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void HandleEvent_BubbleUpAllDefaultActions(EventBase evt, [NotNull] BaseVisualElementPanel panel, [NotNull] VisualElement element, bool disabled, bool isCapturingTarget)
		{
		}

		private static bool Disabled([NotNull] EventBase evt, [NotNull] VisualElement target)
		{
			return false;
		}

		public static void DispatchToFocusedElementOrPanelRoot(EventBase evt, [NotNull] BaseVisualElementPanel panel)
		{
		}

		public static void DispatchToElementUnderPointerOrPanelRoot(EventBase evt, [NotNull] BaseVisualElementPanel panel, int pointerId, Vector2 position)
		{
		}

		public static void DispatchToAssignedTarget(EventBase evt, [NotNull] BaseVisualElementPanel panel)
		{
		}

		public static void DefaultDispatch(EventBase evt, [NotNull] BaseVisualElementPanel panel)
		{
		}

		public static void DispatchToCapturingElementOrElementUnderPointer(EventBase evt, [NotNull] BaseVisualElementPanel panel, int pointerId, Vector2 position)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool DispatchToCapturingElement(EventBase evt, [NotNull] BaseVisualElementPanel panel, int pointerId)
		{
			return false;
		}

		internal static void DispatchToPanelRoot(EventBase evt, [NotNull] BaseVisualElementPanel panel)
		{
		}

		internal static void PropagateToRemainingIMGUIContainers(EventBase evt, [NotNull] VisualElement root)
		{
		}

		private static void PropagateToRemainingIMGUIContainerRecursive(EventBase evt, [NotNull] VisualElement root)
		{
		}
	}
}
