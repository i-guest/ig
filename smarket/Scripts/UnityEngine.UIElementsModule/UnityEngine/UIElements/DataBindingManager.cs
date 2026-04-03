using System;
using System.Collections.Generic;
using Unity.Properties;
using UnityEngine.UIElements.StyleSheets;

namespace UnityEngine.UIElements
{
	internal sealed class DataBindingManager : IDisposable
	{
		private readonly struct BindingRequest
		{
			public readonly BindingId bindingId;

			public readonly Binding binding;

			public readonly bool shouldProcess;

			public BindingRequest(in BindingId bindingId, Binding binding, bool shouldProcess = true)
			{
				this.bindingId = default(BindingId);
				this.binding = null;
				this.shouldProcess = false;
			}

			public BindingRequest CancelRequest()
			{
				return default(BindingRequest);
			}
		}

		private struct BindingDataCollection : IDisposable
		{
			private Dictionary<BindingId, BindingData> m_BindingPerId;

			private List<BindingData> m_Bindings;

			public static BindingDataCollection Create()
			{
				return default(BindingDataCollection);
			}

			public void AddBindingData(BindingData bindingData)
			{
			}

			public bool TryGetBindingData(in BindingId bindingId, out BindingData data)
			{
				data = null;
				return false;
			}

			public bool RemoveBindingData(BindingData bindingData)
			{
				return false;
			}

			public List<BindingData> GetBindings()
			{
				return null;
			}

			public int GetBindingCount()
			{
				return 0;
			}

			public void Dispose()
			{
			}
		}

		internal class BindingData
		{
			public long version;

			public BindingTarget target;

			public Binding binding;

			private DataSourceContext m_LastContext;

			public BindingResult? m_SourceToUILastUpdate;

			public BindingResult? m_UIToSourceLastUpdate;

			public object localDataSource { get; set; }

			public DataSourceContext context
			{
				set
				{
				}
			}

			public void Reset()
			{
			}
		}

		internal readonly struct ChangesFromUI
		{
			public readonly long version;

			public readonly Binding binding;

			public readonly BindingData bindingData;

			public bool IsValid => false;

			public ChangesFromUI(BindingData bindingData)
			{
				version = 0L;
				binding = null;
				this.bindingData = null;
			}
		}

		private class HierarchyBindingTracker : IDisposable
		{
			private class HierarchicalBindingsSorter : HierarchyTraversal
			{
				public HashSet<VisualElement> boundElements { get; set; }

				public List<VisualElement> results { get; set; }

				public override void TraverseRecursive(VisualElement element, int depth)
				{
				}
			}

			private readonly BaseVisualElementPanel m_Panel;

			private readonly HierarchicalBindingsSorter m_BindingSorter;

			private readonly Dictionary<VisualElement, BindingDataCollection> m_BindingDataPerElement;

			private readonly HashSet<VisualElement> m_BoundElements;

			private readonly List<VisualElement> m_OrderedBindings;

			private bool m_IsDirty;

			private EventCallback<PropertyChangedEvent, Dictionary<VisualElement, BindingDataCollection>> m_OnPropertyChanged;

			public int GetTrackedElementsCount()
			{
				return 0;
			}

			public List<VisualElement> GetBoundElements()
			{
				return null;
			}

			public HierarchyBindingTracker(BaseVisualElementPanel panel)
			{
			}

			public void SetDirty()
			{
			}

			public bool TryGetBindingCollection(VisualElement element, out BindingDataCollection collection)
			{
				collection = default(BindingDataCollection);
				return false;
			}

			public bool IsTrackingElement(VisualElement element)
			{
				return false;
			}

			public void StartTrackingBinding(VisualElement element, BindingData binding)
			{
			}

			private void OnPropertyChanged(PropertyChangedEvent evt, Dictionary<VisualElement, BindingDataCollection> bindingCollection)
			{
			}

			public void StopTrackingBinding(VisualElement element, BindingData binding)
			{
			}

			public void StopTrackingElement(VisualElement element)
			{
			}

			public void Dispose()
			{
			}

			private void OrderBindings(VisualElement root)
			{
			}
		}

		private class HierarchyDataSourceTracker : IDisposable
		{
			private class SourceInfo
			{
				private HashSet<PropertyPath> m_DetectedChanges;

				public long lastVersion { get; set; }

				public int refCount { get; set; }

				public HashSet<PropertyPath> detectedChanges => null;

				public HashSet<PropertyPath> detectedChangesNoAlloc => null;
			}

			private class InvalidateDataSourcesTraversal : HierarchyTraversal
			{
				private readonly HierarchyDataSourceTracker m_DataSourceTracker;

				private readonly HashSet<VisualElement> m_VisitedElements;

				public InvalidateDataSourcesTraversal(HierarchyDataSourceTracker dataSourceTracker)
				{
				}

				public void Invalidate(List<VisualElement> addedOrMovedElements, HashSet<VisualElement> removedElements)
				{
				}

				public override void TraverseRecursive(VisualElement element, int depth)
				{
				}
			}

			private class ObjectComparer : IEqualityComparer<object>
			{
				bool IEqualityComparer<object>.Equals(object x, object y)
				{
					return false;
				}

				int IEqualityComparer<object>.GetHashCode(object obj)
				{
					return 0;
				}
			}

			private readonly List<SourceInfo> m_SourceInfosPool;

			private readonly DataBindingManager m_DataBindingManager;

			private readonly Dictionary<VisualElement, DataSourceContext> m_ResolvedHierarchicalDataSourceContext;

			private readonly Dictionary<Binding, int> m_BindingRefCount;

			private readonly Dictionary<object, SourceInfo> m_SourceInfos;

			private readonly HashSet<object> m_SourcesToRemove;

			private readonly InvalidateDataSourcesTraversal m_InvalidateResolvedDataSources;

			private readonly EventHandler<BindablePropertyChangedEventArgs> m_Handler;

			private readonly EventCallback<PropertyChangedEvent, VisualElement> m_VisualElementHandler;

			private SourceInfo GetPooledSourceInfo()
			{
				return null;
			}

			private void ReleasePooledSourceInfo(SourceInfo info)
			{
			}

			public HierarchyDataSourceTracker(DataBindingManager manager)
			{
			}

			internal void IncreaseBindingRefCount(ref BindingData bindingData)
			{
			}

			internal void DecreaseBindingRefCount(ref BindingData bindingData)
			{
			}

			internal void IncreaseRefCount(object dataSource)
			{
			}

			private void OnVisualElementPropertyChanged(PropertyChangedEvent evt, VisualElement element)
			{
			}

			internal void DecreaseRefCount(object dataSource)
			{
			}

			public int GetTrackedDataSourcesCount()
			{
				return 0;
			}

			public HashSet<PropertyPath> GetChangesFromSource(object dataSource)
			{
				return null;
			}

			public void ClearChangesFromSource(object dataSource)
			{
			}

			public void InvalidateCachedDataSource(HashSet<VisualElement> elements, HashSet<VisualElement> removedElements)
			{
			}

			public DataSourceContext GetResolvedDataSourceContext(VisualElement element, BindingData bindingData)
			{
				return default(DataSourceContext);
			}

			private void TrackPropertyChanges(object sender, BindablePropertyChangedEventArgs args)
			{
			}

			private void TrackPropertyChanges(object sender, PropertyPath propertyPath)
			{
			}

			public bool TryGetLastVersion(object source, out long version)
			{
				version = default(long);
				return false;
			}

			public void UpdateVersion(object source, long version)
			{
			}

			internal DataSourceContext GetHierarchicalDataSourceContext(VisualElement element)
			{
				return default(DataSourceContext);
			}

			internal void RemoveHierarchyDataSourceContextFromElement(VisualElement element)
			{
			}

			public void Dispose()
			{
			}

			public void ClearSourceCache()
			{
			}
		}

		private struct IgnoreUIChangesData
		{
			public VisualElement element;

			public Binding binding;

			public BindingId bindingId;

			public bool ShouldIgnoreChange(VisualElement ve, Binding b, BindingId id)
			{
				return false;
			}
		}

		public struct IgnoreUIChangesScope : IDisposable
		{
			private IgnoreUIChangesData m_ScopeData;

			private DataBindingManager manager;

			internal IgnoreUIChangesScope(DataBindingManager manager, VisualElement target, BindingId bindingId, Binding binding)
			{
				m_ScopeData = default(IgnoreUIChangesData);
				this.manager = null;
			}

			public void Dispose()
			{
			}
		}

		private readonly List<BindingData> m_BindingDataLocalPool;

		private static readonly PropertyName k_RequestBindingPropertyName;

		private static readonly BindingId k_ClearBindingsToken;

		internal static BindingLogLevel globalLogLevel;

		private BindingLogLevel? m_LogLevel;

		private static readonly List<BindingData> s_Empty;

		private readonly BaseVisualElementPanel m_Panel;

		private readonly HierarchyDataSourceTracker m_DataSourceTracker;

		private readonly HierarchyBindingTracker m_BindingsTracker;

		private readonly List<ChangesFromUI> m_DetectedChangesFromUI;

		private IgnoreUIChangesData m_IgnoreUIChangesData;

		internal BindingLogLevel logLevel
		{
			get
			{
				return default(BindingLogLevel);
			}
			set
			{
			}
		}

		internal void ResetLogLevel()
		{
		}

		internal DataBindingManager(BaseVisualElementPanel panel)
		{
		}

		internal int GetTrackedDataSourcesCount()
		{
			return 0;
		}

		internal bool TryGetLastVersion(object source, out long version)
		{
			version = default(long);
			return false;
		}

		internal void UpdateVersion(object source, long version)
		{
		}

		internal void CacheUIBindingResult(BindingData bindingData, BindingResult result)
		{
		}

		internal bool TryGetLastUIBindingResult(BindingData bindingData, out BindingResult result)
		{
			result = default(BindingResult);
			return false;
		}

		internal void CacheSourceBindingResult(BindingData bindingData, BindingResult result)
		{
		}

		internal bool TryGetLastSourceBindingResult(BindingData bindingData, out BindingResult result)
		{
			result = default(BindingResult);
			return false;
		}

		internal DataSourceContext GetResolvedDataSourceContext(VisualElement element, BindingData bindingData)
		{
			return default(DataSourceContext);
		}

		internal int GetBoundElementsCount()
		{
			return 0;
		}

		internal IEnumerable<VisualElement> GetBoundElements()
		{
			return null;
		}

		public IgnoreUIChangesScope IgnoreChangesScope(VisualElement target, BindingId bindingId, Binding binding)
		{
			return default(IgnoreUIChangesScope);
		}

		internal List<ChangesFromUI> GetChangedDetectedFromUI()
		{
			return null;
		}

		internal HashSet<PropertyPath> GetChangedDetectedFromSource(object dataSource)
		{
			return null;
		}

		internal void ClearChangesFromSource(object dataSource)
		{
		}

		internal List<BindingData> GetBindingData(VisualElement element)
		{
			return null;
		}

		internal bool TryGetBindingData(VisualElement element, in BindingId bindingId, out BindingData bindingData)
		{
			bindingData = null;
			return false;
		}

		internal void RegisterBinding(VisualElement element, in BindingId bindingId, Binding binding)
		{
		}

		internal void UnregisterBinding(VisualElement element, in BindingId bindingId)
		{
		}

		internal void TransferBindingRequests(VisualElement element)
		{
		}

		public void InvalidateCachedDataSource(HashSet<VisualElement> addedOrMovedElements, HashSet<VisualElement> removedElements)
		{
		}

		public void Dispose()
		{
		}

		private static void CreateBindingRequest(VisualElement target, in BindingId bindingId, Binding binding, bool isTransferring)
		{
		}

		public void ProcessBindingRequests(VisualElement element)
		{
		}

		private void ClearAllBindings(VisualElement element)
		{
		}

		internal static bool AnyPendingBindingRequests(VisualElement element)
		{
			return false;
		}

		internal static bool TryGetBindingRequest(VisualElement element, in BindingId bindingId, out Binding binding)
		{
			binding = null;
			return false;
		}

		public void DirtyBindingOrder()
		{
		}

		public void TrackDataSource(object previous, object current)
		{
		}

		public void ClearSourceCache()
		{
		}

		public BindingData GetPooledBindingData(BindingTarget target, Binding binding)
		{
			return null;
		}

		public void ReleasePoolBindingData(BindingData data)
		{
		}
	}
}
