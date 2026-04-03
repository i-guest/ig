using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Hierarchy;
using Unity.Profiling;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements
{
	public abstract class BaseTreeViewController : CollectionViewController
	{
		[CompilerGenerated]
		private sealed class _003CGetAllItemIds_003Ed__23 : IEnumerable<int>, IEnumerable, IEnumerator<int>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private int _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private IEnumerable<int> rootIds;

			public IEnumerable<int> _003C_003E3__rootIds;

			public BaseTreeViewController _003C_003E4__this;

			private HierarchyFlattened.Enumerator _003C_003Es__1;

			private HierarchyFlattenedNode _003CflattenedNode_003E5__2;

			private HierarchyNode _003Cnode_003E5__3;

			private IEnumerator<int> _003C_003Es__4;

			private int _003Cid_003E5__5;

			private HierarchyNode _003CparentNode_003E5__6;

			private HierarchyFlattenedChildrenEnumerable _003CflattenedNodeChildren_003E5__7;

			private HierarchyFlattenedChildrenEnumerable.Enumerator _003C_003Es__8;

			private HierarchyFlattenedNode _003CflattenedNode_003E5__9;

			int IEnumerator<int>.Current
			{
				[DebuggerHidden]
				get
				{
					return 0;
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
			public _003CGetAllItemIds_003Ed__23(int _003C_003E1__state)
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
			IEnumerator<int> IEnumerable<int>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003CGetChildrenIds_003Ed__25 : IEnumerable<int>, IEnumerable, IEnumerator<int>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private int _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private int id;

			public int _003C_003E3__id;

			public BaseTreeViewController _003C_003E4__this;

			private HierarchyNode _003CnodeById_003E5__1;

			private HierarchyNodeChildren _003Cnodes_003E5__2;

			private HierarchyNodeChildren.Enumerator _003C_003Es__3;

			private HierarchyNode _003Cnode_003E5__4;

			int IEnumerator<int>.Current
			{
				[DebuggerHidden]
				get
				{
					return 0;
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
			public _003CGetChildrenIds_003Ed__25(int _003C_003E1__state)
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

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[DebuggerHidden]
			IEnumerator<int> IEnumerable<int>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003CGetChildrenIdsByIndex_003Ed__41 : IEnumerable<int>, IEnumerable, IEnumerator<int>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private int _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private int index;

			public int _003C_003E3__index;

			public BaseTreeViewController _003C_003E4__this;

			private HierarchyNodeChildren _003Cnodes_003E5__1;

			private HierarchyNodeChildren.Enumerator _003C_003Es__2;

			private HierarchyNode _003Cnode_003E5__3;

			int IEnumerator<int>.Current
			{
				[DebuggerHidden]
				get
				{
					return 0;
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
			public _003CGetChildrenIdsByIndex_003Ed__41(int _003C_003E1__state)
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

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[DebuggerHidden]
			IEnumerator<int> IEnumerable<int>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		private protected Hierarchy m_Hierarchy;

		private protected HierarchyFlattened m_HierarchyFlattened;

		private protected HierarchyViewModel m_HierarchyViewModel;

		private protected Dictionary<int, HierarchyNode> m_IdToNodeDictionary;

		private IHierarchyProperty<int> m_TreeViewDataProperty;

		private bool m_HierarchyHasPendingChanged;

		private static readonly ProfilerMarker K_ExpandItemByIndex;

		protected BaseTreeView baseTreeView => null;

		private protected Hierarchy hierarchy
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override IList itemsSource
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal event Action<TreeViewExpansionChangedArgs> itemExpandedChanged
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

		~BaseTreeViewController()
		{
		}

		internal void DisposeHierarchy()
		{
		}

		[IteratorStateMachine(typeof(_003CGetAllItemIds_003Ed__23))]
		public virtual IEnumerable<int> GetAllItemIds(IEnumerable<int> rootIds = null)
		{
			return null;
		}

		public virtual int GetParentId(int id)
		{
			return 0;
		}

		[IteratorStateMachine(typeof(_003CGetChildrenIds_003Ed__25))]
		public virtual IEnumerable<int> GetChildrenIds(int id)
		{
			return null;
		}

		public virtual void Move(int id, int newParentId, int childIndex = -1, bool rebuildTree = true)
		{
		}

		internal override void InvokeMakeItem(ReusableCollectionItem reusableItem)
		{
		}

		internal override void InvokeBindItem(ReusableCollectionItem reusableItem, int index)
		{
		}

		internal override void InvokeDestroyItem(ReusableCollectionItem reusableItem)
		{
		}

		internal void PostInitRegistration(ReusableTreeViewItem treeItem)
		{
		}

		private void OnItemPointerUp(PointerUpEvent evt)
		{
		}

		private void RaiseItemExpandedChanged(int id, bool isExpanded, bool isAppliedToAllChildren)
		{
		}

		private void OnToggleValueChanged(ChangeEvent<bool> evt)
		{
		}

		public override int GetIndexForId(int id)
		{
			return 0;
		}

		public override int GetIdForIndex(int index)
		{
			return 0;
		}

		public virtual bool HasChildren(int id)
		{
			return false;
		}

		public bool Exists(int id)
		{
			return false;
		}

		public bool HasChildrenByIndex(int index)
		{
			return false;
		}

		[IteratorStateMachine(typeof(_003CGetChildrenIdsByIndex_003Ed__41))]
		public IEnumerable<int> GetChildrenIdsByIndex(int index)
		{
			return null;
		}

		public int GetChildIndexForId(int id)
		{
			return 0;
		}

		public int GetIndentationDepth(int id)
		{
			return 0;
		}

		public int GetIndentationDepthByIndex(int index)
		{
			return 0;
		}

		public virtual bool CanChangeExpandedState(int id)
		{
			return false;
		}

		public bool IsExpanded(int id)
		{
			return false;
		}

		public bool IsExpandedByIndex(int index)
		{
			return false;
		}

		public void ExpandItemByIndex(int index, bool expandAllChildren, bool refresh = true)
		{
		}

		public void ExpandItem(int id, bool expandAllChildren, bool refresh = true)
		{
		}

		public void CollapseItemByIndex(int index, bool collapseAllChildren, bool refresh = true)
		{
		}

		public void CollapseItem(int id, bool collapseAllChildren, bool refresh = true)
		{
		}

		private void ExpandItemByNode(in HierarchyNode node, bool expandAllChildren, bool refresh)
		{
		}

		private void CollapseItemByNode(in HierarchyNode node, bool collapseAllChildren, bool refresh)
		{
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal void GetExpandedItemIds(List<int> list)
		{
		}

		internal bool IsViewDataKeyEnabled()
		{
			return false;
		}

		internal override void PreRefresh()
		{
		}

		private bool IsIndexValid(int index)
		{
			return false;
		}

		private bool IsChildOf(int childId, int id)
		{
			return false;
		}

		internal void RaiseItemParentChanged(int id, int newParentId)
		{
		}

		internal HierarchyNode CreateNode(in HierarchyNode parent)
		{
			return default(HierarchyNode);
		}

		internal void UpdateIdToNodeDictionary(int id, in HierarchyNode node, bool isAdd = true)
		{
		}

		internal void ClearIdToNodeDictionary()
		{
		}

		internal void UpdateSortOrder(in HierarchyNode newParent, in HierarchyNode insertedNode, int insertedIndex)
		{
		}

		internal void OnViewDataReadyUpdateNodes()
		{
		}

		internal void UpdateHierarchy()
		{
		}

		internal HierarchyNode GetHierarchyNodeById(int id)
		{
			return default(HierarchyNode);
		}

		internal HierarchyNode GetHierarchyNodeByIndex(int index)
		{
			return default(HierarchyNode);
		}
	}
}
