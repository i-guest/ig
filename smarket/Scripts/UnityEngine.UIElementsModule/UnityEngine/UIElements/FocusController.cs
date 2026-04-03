using System.Collections.Generic;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements
{
	public class FocusController
	{
		private struct FocusedElement
		{
			public VisualElement m_SubTreeRoot;

			public VisualElement m_FocusedElement;
		}

		private TextElement m_SelectedTextElement;

		private List<FocusedElement> m_FocusedElements;

		private Focusable m_LastFocusedElement;

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal Focusable m_LastPendingFocusedElement;

		private int m_PendingFocusCount;

		private IFocusRing focusRing { get; }

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal TextElement selectedTextElement
		{
			set
			{
			}
		}

		public Focusable focusedElement => null;

		internal int imguiKeyboardControl { get; set; }

		public FocusController(IFocusRing focusRing)
		{
		}

		public void IgnoreEvent(EventBase evt)
		{
		}

		internal bool IsFocused(Focusable f)
		{
			return false;
		}

		internal Focusable GetRetargetedFocusedElement(VisualElement retargetAgainst)
		{
			return null;
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal Focusable GetLeafFocusedElement()
		{
			return null;
		}

		private bool IsLocalElement(Focusable f)
		{
			return false;
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal bool IsPendingFocus(Focusable f)
		{
			return false;
		}

		internal void SetFocusToLastFocusedElement()
		{
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal void BlurLastFocusedElement()
		{
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal void DoFocusChange(Focusable f)
		{
		}

		internal void ProcessPendingFocusChange(Focusable f)
		{
		}

		private static void GetFocusTargets(Focusable f, List<FocusedElement> outTargets)
		{
		}

		internal Focusable FocusNextInDirection(Focusable currentFocusable, FocusChangeDirection direction)
		{
			return null;
		}

		private void AboutToReleaseFocus(Focusable focusable, Focusable willGiveFocusTo, FocusChangeDirection direction, DispatchMode dispatchMode)
		{
		}

		private void ReleaseFocus(Focusable focusable, Focusable willGiveFocusTo, FocusChangeDirection direction, DispatchMode dispatchMode)
		{
		}

		private void AboutToGrabFocus(Focusable focusable, Focusable willTakeFocusFrom, FocusChangeDirection direction, DispatchMode dispatchMode)
		{
		}

		private void GrabFocus(Focusable focusable, Focusable willTakeFocusFrom, FocusChangeDirection direction, bool bIsFocusDelegated, DispatchMode dispatchMode)
		{
		}

		internal void Blur(Focusable focusable, bool bIsFocusDelegated = false, DispatchMode dispatchMode = DispatchMode.Default)
		{
		}

		internal void SwitchFocus(Focusable newFocusedElement, bool bIsFocusDelegated = false, DispatchMode dispatchMode = DispatchMode.Default)
		{
		}

		internal void SwitchFocus(Focusable newFocusedElement, FocusChangeDirection direction, bool bIsFocusDelegated = false, DispatchMode dispatchMode = DispatchMode.Default)
		{
		}

		internal void SwitchFocusOnEvent(Focusable currentFocusable, EventBase e)
		{
		}

		internal void ReevaluateFocus()
		{
		}

		internal bool GetFocusableParentForPointerEvent(Focusable target, out Focusable effectiveTarget)
		{
			effectiveTarget = null;
			return false;
		}

		internal void SyncIMGUIFocus(int imguiKeyboardControlID, Focusable imguiContainerHavingKeyboardControl, bool forceSwitch)
		{
		}
	}
}
