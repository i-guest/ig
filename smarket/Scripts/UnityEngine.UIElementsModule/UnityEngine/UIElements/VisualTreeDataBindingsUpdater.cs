using System.Collections.Generic;
using Unity.Profiling;
using Unity.Properties;

namespace UnityEngine.UIElements
{
	internal class VisualTreeDataBindingsUpdater : BaseVisualTreeUpdater
	{
		private readonly struct VersionInfo
		{
			public readonly object source;

			public readonly long version;

			public VersionInfo(object source, long version)
			{
				this.source = null;
				this.version = 0L;
			}
		}

		private static readonly ProfilerMarker s_UpdateProfilerMarker;

		private static readonly ProfilerMarker s_ProcessBindingRequestsProfilerMarker;

		private static readonly ProfilerMarker s_ProcessDataSourcesProfilerMarker;

		private static readonly ProfilerMarker s_ShouldUpdateBindingProfilerMarker;

		private static readonly ProfilerMarker s_UpdateBindingProfilerMarker;

		private readonly BindingUpdater m_Updater;

		private readonly List<VisualElement> m_BindingRegistrationRequests;

		private readonly HashSet<VisualElement> m_DataSourceChangedRequests;

		private readonly HashSet<VisualElement> m_RemovedElements;

		private readonly List<VisualElement> m_BoundsElement;

		private readonly List<VersionInfo> m_VersionChanges;

		private readonly HashSet<object> m_TrackedObjects;

		private readonly HashSet<Binding> m_RanUpdate;

		private readonly HashSet<object> m_KnownSources;

		private readonly HashSet<Binding> m_DirtyBindings;

		private BaseVisualElementPanel m_AttachedPanel;

		private DataBindingManager bindingManager => null;

		public override ProfilerMarker profilerMarker => default(ProfilerMarker);

		protected void OnHierarchyChange(VisualElement ve, HierarchyChangeType type, IReadOnlyList<VisualElement> additionalContext = null)
		{
		}

		public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType)
		{
		}

		private void CacheAndLogBindingResult(bool appliedOnUiCache, in DataBindingManager.BindingData bindingData, in BindingResult result)
		{
		}

		private void LogResult(in BindingResult result)
		{
		}

		public override void Update()
		{
		}

		private (bool, long) GetDataSourceVersion(object source)
		{
			return default((bool, long));
		}

		private bool IsPrefix(in PropertyPath prefix, in PropertyPath path)
		{
			return false;
		}

		private void ProcessDataSourceChangedRequests()
		{
		}

		private void OnPanelChanged(BaseVisualElementPanel p)
		{
		}

		protected override void Dispose(bool disposing)
		{
		}

		private void ProcessAllBindingRequests()
		{
		}

		private void ProcessBindingRequests(VisualElement element)
		{
		}

		private void ProcessPropertyChangedEvents(HashSet<Binding> ranUpdate)
		{
		}
	}
}
