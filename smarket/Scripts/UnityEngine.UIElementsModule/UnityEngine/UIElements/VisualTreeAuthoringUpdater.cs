using System.Collections.Generic;
using Unity.Profiling;

namespace UnityEngine.UIElements
{
	internal sealed class VisualTreeAuthoringUpdater : BaseVisualTreeUpdater
	{
		private static readonly ProfilerMarker s_UpdateProfilerMarker;

		private static readonly ProfilerMarker s_UpdateChangeProfilerMarker;

		private readonly List<IVisualElementChangeProcessor> m_RegisteredProcessors;

		private readonly List<IVisualElementChangeProcessor> m_ProcessorRegistrationList;

		private readonly List<IVisualElementChangeProcessor> m_ProcessorUnregistrationList;

		private BaseVisualElementPanel m_AttachedPanel;

		private readonly AuthoringChanges m_Changes1;

		private readonly AuthoringChanges m_Changes2;

		private AuthoringChanges m_Accumulator;

		private AuthoringChanges m_Notifier;

		private bool m_AccumulatingChanges;

		public override ProfilerMarker profilerMarker => default(ProfilerMarker);

		private bool shouldUpdate => false;

		public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType)
		{
		}

		public override void Update()
		{
		}

		private void OnPanelChanged(BaseVisualElementPanel p)
		{
		}

		protected override void Dispose(bool disposing)
		{
		}

		private void OnHierarchyChange(VisualElement ve, HierarchyChangeType type, IReadOnlyList<VisualElement> additionalContext = null)
		{
		}

		private void SwapBuffers()
		{
		}
	}
}
