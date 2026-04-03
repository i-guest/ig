using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Properties;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements
{
	public abstract class BaseTreeView : BaseVerticalCollectionView
	{
		[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
		public new class UxmlTraits : BaseVerticalCollectionView.UxmlTraits
		{
			private readonly UxmlBoolAttributeDescription m_AutoExpand;

			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
			}
		}

		internal static readonly BindingId autoExpandProperty;

		internal static CustomStyleProperty<float> s_TreeViewIndentProperty;

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal static readonly int invalidId;

		public new static readonly string ussClassName;

		public new static readonly string itemUssClassName;

		public static readonly string itemToggleUssClassName;

		[Obsolete("Individual item indents are no longer used, see itemIndentUssClassName instead", false)]
		public static readonly string itemIndentsContainerUssClassName;

		public static readonly string itemIndentUssClassName;

		public static readonly string itemContentContainerUssClassName;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Action<TreeViewExpansionChangedArgs> itemExpandedChanged;

		private bool m_AutoExpand;

		[SerializeField]
		[DontCreateProperty]
		private List<int> m_ExpandedItemIds;

		[CreateProperty(ReadOnly = true)]
		public new IList itemsSource
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public new BaseTreeViewController viewController => null;

		[CreateProperty]
		public bool autoExpand
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal List<int> expandedItemIds
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal float? customIdent { get; private set; }

		private protected override void CreateVirtualizationController()
		{
		}

		public override void SetViewController(CollectionViewController controller)
		{
		}

		private void OnItemIndexChanged(int srcIndex, int dstIndex)
		{
		}

		private void OnItemExpandedChanged(TreeViewExpansionChangedArgs arg)
		{
		}

		internal override ICollectionDragAndDropController CreateDragAndDropController()
		{
			return null;
		}

		public BaseTreeView()
		{
		}

		public BaseTreeView(int itemHeight)
		{
		}

		private void OnCustomStyleResolved(CustomStyleResolvedEvent evt)
		{
		}

		internal override void OnViewDataReady()
		{
		}

		private protected override bool HandleItemNavigation(bool moveIn, bool altPressed)
		{
			return false;
		}

		public void SetSelectionById(int id)
		{
		}

		public void SetSelectionById(IEnumerable<int> ids)
		{
		}

		internal void SetSelectionInternalById(IEnumerable<int> ids, bool sendNotification)
		{
		}

		private int GetItemIndex(int id, bool expand = false)
		{
			return 0;
		}

		public bool IsExpanded(int id)
		{
			return false;
		}

		public void CollapseItem(int id, bool collapseAllChildren = false, bool refresh = true)
		{
		}

		public void ExpandItem(int id, bool expandAllChildren = false, bool refresh = true)
		{
		}

		private bool IsExpandedByIndex(int index)
		{
			return false;
		}

		private void CollapseItemByIndex(int index, bool collapseAll)
		{
		}

		private void ExpandItemByIndex(int index, bool expandAll)
		{
		}
	}
}
