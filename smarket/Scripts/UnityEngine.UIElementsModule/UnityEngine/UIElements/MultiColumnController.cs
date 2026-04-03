using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.UIElements.Internal;

namespace UnityEngine.UIElements
{
	public class MultiColumnController : IDisposable
	{
		private static readonly PropertyName k_BoundColumnVePropertyName;

		internal static readonly PropertyName bindableElementPropertyName;

		internal static readonly string baseUssClassName;

		private static readonly string k_HeaderContainerViewDataKey;

		public static readonly string headerContainerUssClassName;

		public static readonly string rowContainerUssClassName;

		public static readonly string cellUssClassName;

		public static readonly string cellLabelUssClassName;

		private static readonly string k_HeaderViewDataKey;

		private List<int> m_SortedToSourceIndex;

		private List<int> m_SourceToSortedIndex;

		private ColumnSortingMode m_SortingMode;

		private BaseVerticalCollectionView m_View;

		private VisualElement m_HeaderContainer;

		private MultiColumnCollectionHeader m_MultiColumnHeader;

		internal MultiColumnCollectionHeader header => null;

		internal ColumnSortingMode sortingMode
		{
			get
			{
				return default(ColumnSortingMode);
			}
			set
			{
			}
		}

		public event Action columnSortingChanged
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

		public event Action<ContextualMenuPopulateEvent, Column> headerContextMenuPopulateEvent
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

		public MultiColumnController(Columns columns, SortColumnDescriptions sortDescriptions, List<SortColumnDescription> sortedColumns)
		{
		}

		private static void BindCellItem<T>(VisualElement ve, int rowIndex, Column column, T item)
		{
		}

		private static void UnbindCellItem(VisualElement ve, int rowIndex, Column column)
		{
		}

		private static VisualElement DefaultMakeCellItem()
		{
			return null;
		}

		private static void DefaultBindCellItem<T>(VisualElement ve, T item)
		{
		}

		public VisualElement MakeItem()
		{
			return null;
		}

		public void BindItem<T>(VisualElement element, int index, T item)
		{
		}

		public void UnbindItem(VisualElement element, int index)
		{
		}

		public void DestroyItem(VisualElement element)
		{
		}

		public void PrepareView(BaseVerticalCollectionView collectionView)
		{
		}

		public void Dispose()
		{
		}

		private void OnHorizontalScrollerValueChanged(float v)
		{
		}

		private void OnViewportGeometryChanged(GeometryChangedEvent evt)
		{
		}

		private void OnColumnContainerGeometryChanged(GeometryChangedEvent evt)
		{
		}

		private void UpdateContentContainer(BaseVerticalCollectionView collectionView)
		{
		}

		private void OnColumnSortingChanged()
		{
		}

		internal void UpdateDragger()
		{
		}

		internal void SortIfNeeded()
		{
		}

		private int CombinedComparison(int a, int b)
		{
			return 0;
		}

		internal int GetSourceIndex(int sortedIndex)
		{
			return 0;
		}

		internal int GetSortedIndex(int sourceIndex)
		{
			return 0;
		}

		private static int GetIndexFromList(int index, List<int> indices)
		{
			return 0;
		}

		private void OnContextMenuPopulateEvent(ContextualMenuPopulateEvent evt, Column column)
		{
		}

		private void OnColumnResized(int index, float width)
		{
		}

		private void OnColumnAdded(Column column, int index)
		{
		}

		private void OnColumnRemoved(Column column)
		{
		}

		private void OnColumnReordered(Column column, int from, int to)
		{
		}

		private void OnColumnsChanged(Column column, ColumnDataType type)
		{
		}

		private void OnColumnChanged(ColumnsDataType type)
		{
		}

		private void OnViewDataRestored()
		{
		}
	}
}
