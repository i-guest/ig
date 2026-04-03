using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Profiling;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements
{
	[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule", "UnityEditor.UIToolkitAuthoringModule" })]
	internal class Panel : BaseVisualElementPanel
	{
		internal const int k_DefaultPixelsPerUnit = 100;

		private VisualElement m_RootContainer;

		private VisualTreeUpdater m_VisualTreeUpdater;

		private IStylePropertyAnimationSystem m_StylePropertyAnimationSystem;

		private string m_PanelName;

		private uint m_Version;

		private uint m_RepaintVersion;

		private uint m_HierarchyVersion;

		private uint m_LastTickedHierarchyVersion;

		private ProfilerMarker m_MarkerPrepareRepaint;

		private ProfilerMarker m_MarkerRender;

		private ProfilerMarker m_MarkerValidateLayout;

		private ProfilerMarker m_MarkerTickScheduledActions;

		protected ProfilerMarker m_MarkerTickScheduledActionsPreLayout;

		protected ProfilerMarker m_MarkerTickScheduledActionsPostLayout;

		private ProfilerMarker m_MarkerPanelChangeReceiver;

		private static ProfilerMarker s_MarkerPickAll;

		private bool m_JustReceivedFocus;

		private IDebugPanelChangeReceiver m_PanelChangeReceiver;

		private AtlasBase m_Atlas;

		private bool m_ValidatingLayout;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<Panel> beforeAnyRepaint;

		public sealed override VisualElement visualTree => null;

		public sealed override EventDispatcher dispatcher { get; set; }

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal override IStylePropertyAnimationSystem styleAnimationSystem
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override ScriptableObject ownerObject { get; protected set; }

		public override ContextType contextType { get; }

		public override SavePersistentViewData saveViewData { get; }

		public override GetViewDataDictionary getViewDataDictionary { get; }

		public sealed override FocusController focusController { get; set; }

		public override EventInterests IMGUIEventInterests { get; set; }

		private static LoadResourceFunction loadResourceFunc { get; }

		internal string name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public IDebugPanelChangeReceiver panelChangeReceiver
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[Obsolete("Use the non-static TimeSinceStartupFunc instead")]
		internal static TimeMsFunction TimeSinceStartup { get; }

		public override int IMGUIContainersCount { get; set; }

		public override IMGUIContainer rootIMGUIContainer { get; }

		internal override uint version => 0u;

		internal override uint repaintVersion => 0u;

		internal override uint hierarchyVersion => 0u;

		public override AtlasBase atlas
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal static Object LoadResource(string pathName, Type type, float dpiScaling)
		{
			return null;
		}

		internal void Focus()
		{
		}

		internal void Blur()
		{
		}

		public void ValidateFocus()
		{
		}

		private void CreateMarkers()
		{
		}

		public Panel(ScriptableObject ownerObject, ContextType contextType, EventDispatcher dispatcher)
		{
		}

		protected override void Dispose(bool disposing)
		{
		}

		internal static VisualElement PickAll(VisualElement root, Vector2 point, List<VisualElement> picked = null, bool includeIgnoredElement = false)
		{
			return null;
		}

		private static VisualElement PerformPick(VisualElement root, Vector2 point, List<VisualElement> picked = null, bool includeIgnoredElement = false)
		{
			return null;
		}

		public override VisualElement PickAll(Vector2 point, List<VisualElement> picked)
		{
			return null;
		}

		public override VisualElement Pick(Vector2 point, int pointerId)
		{
			return null;
		}

		public override void ValidateLayout()
		{
		}

		public override void UpdateAnimations()
		{
		}

		public override void UpdateBindings()
		{
		}

		public override void UpdateDataBinding()
		{
		}

		public override void TickSchedulingUpdaters()
		{
		}

		public override void ApplyStyles()
		{
		}

		public override void UpdateForRepaint()
		{
		}

		public override void Repaint(Event e)
		{
		}

		public override void Render()
		{
		}

		internal override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType)
		{
		}

		internal override void SetUpdater(IVisualTreeUpdater updater, VisualTreeUpdatePhase phase)
		{
		}

		internal override IVisualTreeUpdater GetUpdater(VisualTreeUpdatePhase phase)
		{
			return null;
		}
	}
}
