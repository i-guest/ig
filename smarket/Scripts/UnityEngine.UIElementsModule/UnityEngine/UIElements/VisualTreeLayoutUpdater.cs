using System.Collections.Generic;
using Unity.Profiling;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements
{
	[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal class VisualTreeLayoutUpdater : BaseVisualTreeUpdater
	{
		private static readonly string s_Description;

		private static readonly ProfilerMarker s_ProfilerMarker;

		private static readonly ProfilerMarker k_ComputeLayoutMarker;

		private static readonly ProfilerMarker k_UpdateSubTreeMarker;

		private static readonly ProfilerMarker k_DispatchChangeEventsMarker;

		private List<(Rect, Rect, VisualElement)> changeEventsList;

		private List<VisualElement> missedHierarchyChangeEventsList;

		private TextJobSystem m_TextJobSystem;

		public override ProfilerMarker profilerMarker => default(ProfilerMarker);

		public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType)
		{
		}

		public override void Update()
		{
		}

		private static bool UpdateHierarchyDisplayed(VisualElement ve, List<(Rect, Rect, VisualElement)> changeEvents, bool inheritedDisplayed = true)
		{
			return false;
		}

		private void UpdateSubTree(VisualElement ve, List<(Rect, Rect, VisualElement)> changeEvents)
		{
		}

		private void DispatchChangeEvents(List<(Rect, Rect, VisualElement)> changeEvents, int currentLayoutPass)
		{
		}

		private void DispatchMissedHierarchyChangeEvents(List<VisualElement> missedHierarchyChangeEvents, int currentLayoutPass)
		{
		}
	}
}
