using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Properties;

namespace UnityEngine.UIElements
{
	public class MultiColumnTreeView : BaseTreeView
	{
		[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
		public new class UxmlFactory : UxmlFactory<MultiColumnTreeView, UxmlTraits>
		{
		}

		[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
		public new class UxmlTraits : BaseTreeView.UxmlTraits
		{
			private readonly UxmlEnumAttributeDescription<ColumnSortingMode> m_SortingMode;

			private readonly UxmlObjectAttributeDescription<Columns> m_Columns;

			private readonly UxmlObjectAttributeDescription<SortColumnDescriptions> m_SortColumnDescriptions;

			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
			}
		}

		private static readonly BindingId columnsProperty;

		private static readonly BindingId sortColumnDescriptionsProperty;

		private static readonly BindingId sortingModeProperty;

		private Columns m_Columns;

		private ColumnSortingMode m_SortingMode;

		private SortColumnDescriptions m_SortColumnDescriptions;

		private List<SortColumnDescription> m_SortedColumns;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Action columnSortingChanged;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Action<ContextualMenuPopulateEvent, Column> headerContextMenuPopulateEvent;

		public new MultiColumnTreeViewController viewController => null;

		[CreateProperty]
		public Columns columns
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		[CreateProperty]
		public SortColumnDescriptions sortColumnDescriptions
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		[CreateProperty]
		public ColumnSortingMode sortingMode
		{
			get
			{
				return default(ColumnSortingMode);
			}
			set
			{
			}
		}

		public MultiColumnTreeView()
		{
		}

		public MultiColumnTreeView(Columns columns)
		{
		}

		protected override CollectionViewController CreateViewController()
		{
			return null;
		}

		public override void SetViewController(CollectionViewController controller)
		{
		}

		private protected override void CreateVirtualizationController()
		{
		}

		private void RaiseColumnSortingChanged()
		{
		}

		private void ColumnsChanged(object sender, BindablePropertyChangedEventArgs args)
		{
		}

		private void RaiseHeaderContextMenuPopulate(ContextualMenuPopulateEvent evt, Column column)
		{
		}
	}
}
