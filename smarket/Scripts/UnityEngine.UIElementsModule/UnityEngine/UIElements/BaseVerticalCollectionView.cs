using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Profiling;
using Unity.Properties;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements
{
	public abstract class BaseVerticalCollectionView : BindableElement, ISerializationCallbackReceiver
	{
		[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
		public new class UxmlTraits : BindableElement.UxmlTraits
		{
			private readonly UxmlEnumAttributeDescription<CollectionVirtualizationMethod> m_VirtualizationMethod;

			private readonly UxmlIntAttributeDescription m_FixedItemHeight;

			private readonly UxmlBoolAttributeDescription m_ShowBorder;

			private readonly UxmlEnumAttributeDescription<SelectionType> m_SelectionType;

			private readonly UxmlEnumAttributeDescription<AlternatingRowBackground> m_ShowAlternatingRowBackgrounds;

			private readonly UxmlBoolAttributeDescription m_Reorderable;

			private readonly UxmlBoolAttributeDescription m_HorizontalScrollingEnabled;

			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
			}
		}

		private class Selection
		{
			private readonly HashSet<int> m_IndexLookup;

			private readonly HashSet<int> m_IdLookup;

			private int m_MinIndex;

			private int m_MaxIndex;

			public readonly List<int> indices;

			public readonly Dictionary<int, object> items;

			public List<int> selectedIds { get; set; }

			public int indexCount => 0;

			public int idCount => 0;

			public int minIndex => 0;

			public int maxIndex => 0;

			public int capacity
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public int FirstIndex()
			{
				return 0;
			}

			public object FirstObject()
			{
				return null;
			}

			public bool ContainsIndex(int index)
			{
				return false;
			}

			public bool ContainsId(int id)
			{
				return false;
			}

			public void AddId(int id)
			{
			}

			public void AddIndex(int index, object obj)
			{
			}

			public bool TryRemove(int index)
			{
				return false;
			}

			public void RemoveId(int id)
			{
			}

			public void ClearItems()
			{
			}

			public void ClearIds()
			{
			}

			public void ClearIndices()
			{
			}

			public void Clear()
			{
			}
		}

		private enum RangeSelectionDirection
		{
			Up = -1,
			None = 0,
			Down = 1
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.HierarchyModule" })]
		internal enum pointerProcessingStateEnum
		{
			None = 0,
			PointerDown = 1
		}

		[CompilerGenerated]
		private sealed class _003Cget_selectedItems_003Ed__88 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public BaseVerticalCollectionView _003C_003E4__this;

			private List<int>.Enumerator _003C_003Es__1;

			private int _003Cindex_003E5__2;

			private object _003Citem_003E5__3;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003Cget_selectedItems_003Ed__88(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[DebuggerHidden]
			IEnumerator<object> IEnumerable<object>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		internal static readonly BindingId itemsSourceProperty;

		internal static readonly BindingId selectionTypeProperty;

		internal static readonly BindingId selectedItemProperty;

		internal static readonly BindingId selectedItemsProperty;

		internal static readonly BindingId selectedIndexProperty;

		internal static readonly BindingId selectedIndicesProperty;

		internal static readonly BindingId showBorderProperty;

		internal static readonly BindingId reorderableProperty;

		internal static readonly BindingId horizontalScrollingEnabledProperty;

		internal static readonly BindingId showAlternatingRowBackgroundsProperty;

		internal static readonly BindingId virtualizationMethodProperty;

		internal static readonly BindingId fixedItemHeightProperty;

		private static readonly ProfilerMarker k_RefreshMarker;

		private static readonly ProfilerMarker k_RebuildMarker;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Action<IEnumerable<object>> itemsChosen;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action<IEnumerable<object>> selectionChanged;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action<IEnumerable<int>> selectedIndicesChanged;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action<int, int> itemIndexChanged;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action itemsSourceChanged;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Action m_SelectionNotChanged;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Func<CanStartDragArgs, bool> canStartDrag;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Func<SetupDragAndDropArgs, StartDragArgs> setupDragAndDrop;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Func<HandleDragAndDropArgs, DragVisualMode> dragAndDropUpdate;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Func<HandleDragAndDropArgs, DragVisualMode> handleDrop;

		private SelectionType m_SelectionType;

		private static readonly List<ReusableCollectionItem> k_EmptyItems;

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal bool allowSingleClickChoice;

		private bool m_HorizontalScrollingEnabled;

		[DontCreateProperty]
		[SerializeField]
		private AlternatingRowBackground m_ShowAlternatingRowBackgrounds;

		internal static readonly string k_InvalidTemplateError;

		internal float m_FixedItemHeight;

		internal bool m_ItemHeightIsInline;

		private CollectionVirtualizationMethod m_VirtualizationMethod;

		private readonly ScrollView m_ScrollView;

		private CollectionViewController m_ViewController;

		private CollectionVirtualizationController m_VirtualizationController;

		private KeyboardNavigationManipulator m_NavigationManipulator;

		[DontCreateProperty]
		[SerializeField]
		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal SerializedVirtualizationData serializedVirtualizationData;

		[SerializeField]
		[DontCreateProperty]
		private List<int> m_SelectedIds;

		private readonly Selection m_Selection;

		private float m_LastHeight;

		private RangeSelectionDirection m_RangeSelectionDirection;

		private ListViewDragger m_Dragger;

		internal static CustomStyleProperty<int> s_ItemHeightProperty;

		private readonly Action<int, int> m_ItemIndexChangedCallback;

		private readonly Action m_ItemsSourceChangedCallback;

		private IVisualElementScheduledItem m_RebuildScheduled;

		public static readonly string ussClassName;

		public static readonly string borderUssClassName;

		public static readonly string itemUssClassName;

		public static readonly string dragHoverBarUssClassName;

		public static readonly string dragHoverMarkerUssClassName;

		public static readonly string itemDragHoverUssClassName;

		public static readonly string itemSelectedVariantUssClassName;

		public static readonly string itemAlternativeBackgroundUssClassName;

		public static readonly string listScrollViewUssClassName;

		internal static readonly string backgroundFillUssClassName;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private pointerProcessingStateEnum _003CpointerProcessingState_003Ek__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int _003CcurrentPointerButton_003Ek__BackingField;

		internal int m_PreviousRefreshedCount;

		private Vector3 m_TouchDownPosition;

		private long m_LastPointerDownTimeStamp;

		private int m_PointerDownCount;

		[CreateProperty]
		public IList itemsSource
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override VisualElement contentContainer => null;

		[CreateProperty]
		public SelectionType selectionType
		{
			get
			{
				return default(SelectionType);
			}
			set
			{
			}
		}

		[CreateProperty(ReadOnly = true)]
		public object selectedItem => null;

		[CreateProperty(ReadOnly = true)]
		public IEnumerable<object> selectedItems
		{
			[IteratorStateMachine(typeof(_003Cget_selectedItems_003Ed__88))]
			get
			{
				return null;
			}
		}

		[CreateProperty]
		public int selectedIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[CreateProperty(ReadOnly = true)]
		public IEnumerable<int> selectedIndices => null;

		public IEnumerable<int> selectedIds => null;

		internal IEnumerable<ReusableCollectionItem> activeItems => null;

		internal ScrollView scrollView
		{
			[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule", "UnityEngine.HierarchyModule" })]
			get
			{
				return null;
			}
		}

		internal ListViewDragger dragger => null;

		internal CollectionVirtualizationController virtualizationController
		{
			[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule", "UnityEngine.HierarchyModule" })]
			get
			{
				return null;
			}
		}

		public CollectionViewController viewController => null;

		[CreateProperty]
		public bool showBorder
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
		public bool reorderable
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
		public bool horizontalScrollingEnabled
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
		public AlternatingRowBackground showAlternatingRowBackgrounds
		{
			get
			{
				return default(AlternatingRowBackground);
			}
			set
			{
			}
		}

		[CreateProperty]
		public CollectionVirtualizationMethod virtualizationMethod
		{
			get
			{
				return default(CollectionVirtualizationMethod);
			}
			set
			{
			}
		}

		[CreateProperty]
		public float fixedItemHeight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		internal bool isRebuildScheduled => false;

		private pointerProcessingStateEnum pointerProcessingState
		{
			[CompilerGenerated]
			set
			{
				_003CpointerProcessingState_003Ek__BackingField = value;
			}
		}

		private int currentPointerButton
		{
			[CompilerGenerated]
			set
			{
				_003CcurrentPointerButton_003Ek__BackingField = value;
			}
		}

		internal bool HasCanStartDrag()
		{
			return false;
		}

		internal bool RaiseCanStartDrag(ReusableCollectionItem item, IEnumerable<int> ids, EventModifiers modifiers)
		{
			return false;
		}

		internal StartDragArgs RaiseSetupDragAndDrop(ReusableCollectionItem item, IEnumerable<int> ids, StartDragArgs args)
		{
			return default(StartDragArgs);
		}

		internal DragVisualMode RaiseHandleDragAndDrop(Vector2 pointerPosition, DragAndDropArgs dragAndDropArgs)
		{
			return default(DragVisualMode);
		}

		internal DragVisualMode RaiseDrop(Vector2 pointerPosition, DragAndDropArgs dragAndDropArgs)
		{
			return default(DragVisualMode);
		}

		internal float ResolveItemHeight(float height = -1f)
		{
			return 0f;
		}

		private protected virtual void CreateVirtualizationController()
		{
		}

		internal CollectionVirtualizationController GetOrCreateVirtualizationController()
		{
			return null;
		}

		internal void CreateVirtualizationController<T>() where T : ReusableCollectionItem, new()
		{
		}

		internal CollectionViewController GetOrCreateViewController()
		{
			return null;
		}

		protected abstract CollectionViewController CreateViewController();

		public virtual void SetViewController(CollectionViewController controller)
		{
		}

		internal virtual ListViewDragger CreateDragger()
		{
			return null;
		}

		internal void InitializeDragAndDropController(bool enableReordering)
		{
		}

		internal abstract ICollectionDragAndDropController CreateDragAndDropController();

		public BaseVerticalCollectionView()
		{
		}

		public BaseVerticalCollectionView(IList itemsSource, float itemHeight = -1f)
		{
		}

		public VisualElement GetRootElementForId(int id)
		{
			return null;
		}

		internal virtual bool HasValidDataAndBindings()
		{
			return false;
		}

		private void OnItemIndexChanged(int srcIndex, int dstIndex)
		{
		}

		private void OnItemsSourceChanged()
		{
		}

		public void RefreshItems()
		{
		}

		public void Rebuild()
		{
		}

		internal void ScheduleRebuild()
		{
		}

		private void RefreshSelection()
		{
		}

		private protected virtual void PostRefresh()
		{
		}

		public void ScrollToItem(int index)
		{
		}

		public void ScrollToItemById(int id)
		{
		}

		private void OnScroll(Vector2 offset)
		{
		}

		private void Resize(Vector2 size)
		{
		}

		private void OnAttachToPanel(AttachToPanelEvent evt)
		{
		}

		private void OnDetachFromPanel(DetachFromPanelEvent evt)
		{
		}

		private bool Apply(KeyboardNavigationOperation op, bool shiftKey, bool altKey)
		{
			return false;
		}

		private void Apply(KeyboardNavigationOperation op, EventBase sourceEvent)
		{
		}

		private protected virtual bool HandleItemNavigation(bool moveIn, bool altKey)
		{
			return false;
		}

		private void OnPointerMove(PointerMoveEvent evt)
		{
		}

		private void OnPointerDown(PointerDownEvent evt)
		{
		}

		private void OnPointerCancel(PointerCancelEvent evt)
		{
		}

		private void OnPointerUp(PointerUpEvent evt)
		{
		}

		private void ProcessPointerDown(IPointerEvent evt)
		{
		}

		private void ProcessPointerUp(IPointerEvent evt)
		{
		}

		private void DoSelect(Vector2 localPosition, int mouseButton, int clickCount, bool actionKey, bool shiftKey)
		{
		}

		internal void DoRangeSelection(int rangeSelectionFinalIndex)
		{
		}

		private void ProcessSingleClick(int clickedIndex)
		{
		}

		internal void SelectAll()
		{
		}

		public void AddToSelection(int index)
		{
		}

		internal void AddToSelection(ReadOnlySpan<int> indexes)
		{
		}

		private void AddToSelectionWithoutValidation(int index)
		{
		}

		public void RemoveFromSelection(int index)
		{
		}

		private void RemoveFromSelectionWithoutValidation(int index)
		{
		}

		public void SetSelection(int index)
		{
		}

		internal void SetSelection(ReadOnlySpan<int> indices)
		{
		}

		public void SetSelectionWithoutNotify(IEnumerable<int> indices)
		{
		}

		internal void SetSelectionInternal(IEnumerable<int> indices, bool sendNotification)
		{
		}

		internal void SetSelectionInternal(ReadOnlySpan<int> indices, bool sendNotification)
		{
		}

		private bool MatchesExistingSelection(ReadOnlySpan<int> indices)
		{
			return false;
		}

		private void NotifyOfSelectionChange()
		{
		}

		public void ClearSelection()
		{
		}

		private void ClearSelectionWithoutValidation()
		{
		}

		internal override void OnViewDataReady()
		{
		}

		[EventInterest(new Type[]
		{
			typeof(PointerUpEvent),
			typeof(FocusInEvent),
			typeof(FocusOutEvent),
			typeof(NavigationSubmitEvent)
		})]
		protected override void HandleEventBubbleUp(EventBase evt)
		{
		}

		[Obsolete("ExecuteDefaultAction override has been removed because default event handling was migrated to HandleEventBubbleUp. Please use HandleEventBubbleUp.", false)]
		[EventInterest(EventInterestOptions.Inherit)]
		protected override void ExecuteDefaultAction(EventBase evt)
		{
		}

		private void OnSizeChanged(GeometryChangedEvent evt)
		{
		}

		private void OnCustomStyleResolved(CustomStyleResolvedEvent e)
		{
		}

		void ISerializationCallbackReceiver.OnBeforeSerialize()
		{
		}

		void ISerializationCallbackReceiver.OnAfterDeserialize()
		{
		}
	}
}
