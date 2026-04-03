using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Properties;

namespace UnityEngine.UIElements
{
	public abstract class BaseListView : BaseVerticalCollectionView
	{
		[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
		public new class UxmlTraits : BaseVerticalCollectionView.UxmlTraits
		{
			private readonly UxmlBoolAttributeDescription m_ShowFoldoutHeader;

			private readonly UxmlStringAttributeDescription m_HeaderTitle;

			private readonly UxmlBoolAttributeDescription m_ShowAddRemoveFooter;

			private readonly UxmlBoolAttributeDescription m_AllowAdd;

			private readonly UxmlBoolAttributeDescription m_AllowRemove;

			private readonly UxmlEnumAttributeDescription<ListViewReorderMode> m_ReorderMode;

			private readonly UxmlBoolAttributeDescription m_ShowBoundCollectionSize;

			private readonly UxmlEnumAttributeDescription<BindingSourceSelectionMode> m_BindingSourceSelectionMode;

			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
			}

			protected UxmlTraits()
			{
			}
		}

		private static readonly string k_SizeFieldLabel;

		internal static readonly BindingId showBoundCollectionSizeProperty;

		internal static readonly BindingId showFoldoutHeaderProperty;

		internal static readonly BindingId headerTitleProperty;

		internal static readonly BindingId makeHeaderProperty;

		internal static readonly BindingId makeFooterProperty;

		internal static readonly BindingId showAddRemoveFooterProperty;

		internal static readonly BindingId bindingSourceSelectionModeProperty;

		internal static readonly BindingId reorderModeProperty;

		internal static readonly BindingId makeNoneElementProperty;

		internal static readonly BindingId allowAddProperty;

		internal static readonly BindingId overridingAddButtonBehaviorProperty;

		internal static readonly BindingId onAddProperty;

		internal static readonly BindingId allowRemoveProperty;

		internal static readonly BindingId onRemoveProperty;

		private bool m_ShowBoundCollectionSize;

		private bool m_ShowFoldoutHeader;

		private string m_HeaderTitle;

		private VisualElement drawnHeader;

		private Func<VisualElement> m_MakeHeader;

		private VisualElement drawnFooter;

		private Func<VisualElement> m_MakeFooter;

		private bool m_ShowAddRemoveFooter;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Action<IEnumerable<int>> itemsAdded;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action<IEnumerable<int>> itemsRemoved;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action itemsSourceSizeChanged;

		private IVisualElementScheduledItem m_TrackedItem;

		private Action m_TrackCount;

		private Func<bool> m_WhileAutoAssign;

		private BindingSourceSelectionMode m_BindingSourceSelectionMode;

		private Label m_ListViewLabel;

		private Foldout m_Foldout;

		private TextField m_ArraySizeField;

		private bool m_IsOverMultiEditLimit;

		private VisualElement m_Footer;

		private Button m_AddButton;

		private Button m_RemoveButton;

		private Action<IEnumerable<int>> m_ItemAddedCallback;

		private Action<IEnumerable<int>> m_ItemRemovedCallback;

		private Action m_ItemsSourceSizeChangedCallback;

		private ListViewReorderMode m_ReorderMode;

		private VisualElement m_NoneElement;

		private Func<VisualElement> m_MakeNoneElement;

		private bool m_AllowAdd;

		private Action<BaseListView, Button> m_OverridingAddButtonBehavior;

		private Action<BaseListView> m_OnAdd;

		private bool m_AllowRemove;

		private Action<BaseListView> m_OnRemove;

		public new static readonly string ussClassName;

		public new static readonly string itemUssClassName;

		public static readonly string emptyLabelUssClassName;

		public static readonly string overMaxMultiEditLimitClassName;

		public static readonly string reorderableUssClassName;

		public static readonly string reorderableItemUssClassName;

		public static readonly string reorderableItemContainerUssClassName;

		public static readonly string reorderableItemHandleUssClassName;

		public static readonly string reorderableItemHandleBarUssClassName;

		public static readonly string footerUssClassName;

		public static readonly string foldoutHeaderUssClassName;

		public static readonly string arraySizeFieldUssClassName;

		public static readonly string arraySizeFieldWithHeaderUssClassName;

		public static readonly string arraySizeFieldWithFooterUssClassName;

		public static readonly string listViewWithHeaderUssClassName;

		public static readonly string listViewWithFooterUssClassName;

		public static readonly string scrollViewWithFooterUssClassName;

		public static readonly string footerAddButtonName;

		public static readonly string footerRemoveButtonName;

		private string m_MaxMultiEditStr;

		private static readonly string k_EmptyListStr;

		[CreateProperty]
		public bool showBoundCollectionSize
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[CreateProperty]
		public bool showFoldoutHeader
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[CreateProperty]
		public string headerTitle
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[CreateProperty]
		public Func<VisualElement> makeHeader
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[CreateProperty]
		public Func<VisualElement> makeFooter
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[CreateProperty]
		public bool showAddRemoveFooter
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private IVisualElementScheduledItem trackItemCount => null;

		private Action trackCount => null;

		private Func<bool> untilManualBindingSourceSelectionMode => null;

		[CreateProperty]
		public BindingSourceSelectionMode bindingSourceSelectionMode
		{
			get
			{
				return default(BindingSourceSelectionMode);
			}
			set
			{
			}
		}

		internal bool autoAssignSource => false;

		internal VisualElement footer => null;

		public new BaseListViewController viewController => null;

		[CreateProperty]
		public ListViewReorderMode reorderMode
		{
			get
			{
				return default(ListViewReorderMode);
			}
			set
			{
			}
		}

		[CreateProperty]
		public Func<VisualElement> makeNoneElement
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[CreateProperty]
		public bool allowAdd
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[CreateProperty]
		public Action<BaseListView, Button> overridingAddButtonBehavior
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[CreateProperty]
		public Action<BaseListView> onAdd
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[CreateProperty]
		public bool allowRemove
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[CreateProperty]
		public Action<BaseListView> onRemove
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal event Action reorderModeChanged
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

		private void AddFoldout()
		{
		}

		private void RemoveFoldout()
		{
		}

		internal void SetupArraySizeField()
		{
		}

		private void EnableFooter(bool enabled)
		{
		}

		private void AddItems(int itemCount)
		{
		}

		private void OnArraySizeFieldChanged(ChangeEvent<string> evt)
		{
		}

		private void UpdateRemoveButton()
		{
		}

		internal void UpdateArraySizeField()
		{
		}

		internal void UpdateListViewLabel()
		{
		}

		private void OnAddClicked()
		{
		}

		private void OnAfterAddClicked(int itemsCountPreCallback)
		{
		}

		private void OnRemoveClicked()
		{
		}

		private protected override void CreateVirtualizationController()
		{
		}

		public override void SetViewController(CollectionViewController controller)
		{
		}

		private void OnItemAdded(IEnumerable<int> indices)
		{
		}

		private void OnItemsRemoved(IEnumerable<int> indices)
		{
		}

		private void OnItemsSourceSizeChanged()
		{
		}

		internal override ListViewDragger CreateDragger()
		{
			return null;
		}

		internal override ICollectionDragAndDropController CreateDragAndDropController()
		{
			return null;
		}

		public BaseListView()
		{
		}

		public BaseListView(IList itemsSource, float itemHeight = -1f)
		{
		}

		private protected override void PostRefresh()
		{
		}

		private protected override bool HandleItemNavigation(bool moveIn, bool altPressed)
		{
			return false;
		}
	}
}
