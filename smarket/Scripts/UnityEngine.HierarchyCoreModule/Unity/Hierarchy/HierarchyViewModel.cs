using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace Unity.Hierarchy
{
	[StructLayout((LayoutKind)0)]
	[NativeHeader("Modules/HierarchyCore/Public/HierarchyViewModel.h")]
	[NativeHeader("Modules/HierarchyCore/HierarchyViewModelBindings.h")]
	[RequiredByNativeCode]
	public sealed class HierarchyViewModel : IDisposable
	{
		internal static class BindingsMarshaller
		{
			public static IntPtr ConvertToUnmanaged(HierarchyViewModel viewModel)
			{
				return (IntPtr)0;
			}
		}

		public delegate void FlagsChangedEventHandler(HierarchyNodeFlags flags);

		public struct Enumerator
		{
			private readonly HierarchyViewModel m_ViewModel;

			private readonly ReadOnlyNativeVector<HierarchyNode> m_Nodes;

			private readonly int m_Version;

			private int m_Index;

			public ref readonly HierarchyNode Current
			{
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				get
				{
					throw null;
				}
			}

			internal Enumerator(HierarchyViewModel hierarchyViewModel)
			{
				m_ViewModel = null;
				m_Nodes = default(ReadOnlyNativeVector<HierarchyNode>);
				m_Version = 0;
				m_Index = 0;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public bool MoveNext()
			{
				return false;
			}
		}

		private IntPtr m_Ptr;

		internal readonly Hierarchy m_Hierarchy;

		internal readonly HierarchyFlattened m_HierarchyFlattened;

		private ReadOnlyNativeVector<HierarchyFlattenedNode> m_FlattenedNodes;

		private ReadOnlyNativeVector<HierarchyNode> m_Nodes;

		private int m_Version;

		private readonly bool m_IsOwner;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private FlagsChangedEventHandler FlagsChanged;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private IHierarchySearchQueryParser _003CQueryParser_003Ek__BackingField;

		public bool IsCreated => false;

		public int Count => 0;

		public bool UpdateNeeded
		{
			[NativeMethod("UpdateNeeded", IsThreadSafe = true)]
			get
			{
				return false;
			}
		}

		internal ReadOnlyNativeVector<HierarchyFlattenedNode> FlattenedNodes
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return default(ReadOnlyNativeVector<HierarchyFlattenedNode>);
			}
		}

		internal int Version
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[VisibleToOtherModules(new string[] { "UnityEngine.HierarchyModule" })]
			get
			{
				return 0;
			}
		}

		internal IHierarchySearchQueryParser QueryParser
		{
			[VisibleToOtherModules(new string[] { "UnityEditor.HierarchyModule" })]
			[CompilerGenerated]
			set
			{
				_003CQueryParser_003Ek__BackingField = value;
			}
		}

		internal HierarchySearchQueryDescriptor Query
		{
			[VisibleToOtherModules(new string[] { "UnityEngine.HierarchyModule" })]
			[NativeMethod(IsThreadSafe = true)]
			get
			{
				return null;
			}
		}

		public ref readonly HierarchyNode this[int index]
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				throw null;
			}
		}

		public HierarchyViewModel(HierarchyFlattened hierarchyFlattened, HierarchyNodeFlags defaultFlags = HierarchyNodeFlags.None)
		{
		}

		private HierarchyViewModel(IntPtr nativePtr, HierarchyFlattened hierarchyFlattened, IntPtr flattenedNodesPtr, int flattenedNodesCount, IntPtr nodesPtr, int nodesCount, int version)
		{
		}

		~HierarchyViewModel()
		{
		}

		public void Dispose()
		{
		}

		private void Dispose(bool disposing)
		{
		}

		[NativeMethod(IsThreadSafe = true, ThrowsException = true)]
		public int IndexOf(in HierarchyNode node)
		{
			return 0;
		}

		[NativeMethod(IsThreadSafe = true, ThrowsException = true)]
		public bool Contains(in HierarchyNode node)
		{
			return false;
		}

		[NativeMethod(IsThreadSafe = true, ThrowsException = true)]
		public int GetChildrenCount(in HierarchyNode node)
		{
			return 0;
		}

		public void SetFlags(HierarchyNodeFlags flags)
		{
		}

		public void SetFlags(in HierarchyNode node, HierarchyNodeFlags flags)
		{
		}

		public void SetFlagsRecursive(in HierarchyNode node, HierarchyNodeFlags flags, HierarchyTraversalDirection direction)
		{
		}

		public bool HasAllFlags(in HierarchyNode node, HierarchyNodeFlags flags)
		{
			return false;
		}

		public void ClearFlags(in HierarchyNode node, HierarchyNodeFlags flags)
		{
		}

		public void ClearFlagsRecursive(in HierarchyNode node, HierarchyNodeFlags flags, HierarchyTraversalDirection direction)
		{
		}

		public HierarchyViewModelNodesEnumerable EnumerateNodesWithAllFlags(HierarchyNodeFlags flags)
		{
			return default(HierarchyViewModelNodesEnumerable);
		}

		[NativeMethod(IsThreadSafe = true)]
		public void Update()
		{
		}

		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static HierarchyViewModel FromIntPtr(IntPtr handlePtr)
		{
			return null;
		}

		[FreeFunction("HierarchyViewModelBindings::Create", IsThreadSafe = true)]
		private static IntPtr Create(IntPtr handlePtr, HierarchyFlattened hierarchyFlattened, HierarchyNodeFlags defaultFlags, out IntPtr nodesPtr, out int nodesCount, out IntPtr indicesPtr, out int indicesCount, out int version)
		{
			nodesPtr = default(IntPtr);
			nodesCount = default(int);
			indicesPtr = default(IntPtr);
			indicesCount = default(int);
			version = default(int);
			return (IntPtr)0;
		}

		[FreeFunction("HierarchyViewModelBindings::Destroy", IsThreadSafe = true)]
		private static void Destroy(IntPtr nativePtr)
		{
		}

		[FreeFunction("HierarchyViewModelBindings::SetFlagsAll", HasExplicitThis = true, IsThreadSafe = true, ThrowsException = true)]
		private void SetFlagsAll(HierarchyNodeFlags flags)
		{
		}

		[FreeFunction("HierarchyViewModelBindings::SetFlagsNode", HasExplicitThis = true, IsThreadSafe = true, ThrowsException = true)]
		private void SetFlagsNode(in HierarchyNode node, HierarchyNodeFlags flags)
		{
		}

		[FreeFunction("HierarchyViewModelBindings::SetFlagsRecursiveNode", HasExplicitThis = true, IsThreadSafe = true, ThrowsException = true)]
		private void SetFlagsRecursiveNode(in HierarchyNode node, HierarchyNodeFlags flags, HierarchyTraversalDirection direction)
		{
		}

		[FreeFunction("HierarchyViewModelBindings::HasAllFlagsNode", HasExplicitThis = true, IsThreadSafe = true, ThrowsException = true)]
		private bool HasAllFlagsNode(in HierarchyNode node, HierarchyNodeFlags flags)
		{
			return false;
		}

		[FreeFunction("HierarchyViewModelBindings::ClearFlagsNode", HasExplicitThis = true, IsThreadSafe = true, ThrowsException = true)]
		private void ClearFlagsNode(in HierarchyNode node, HierarchyNodeFlags flags)
		{
		}

		[FreeFunction("HierarchyViewModelBindings::ClearFlagsRecursiveNode", HasExplicitThis = true, IsThreadSafe = true, ThrowsException = true)]
		private void ClearFlagsRecursiveNode(in HierarchyNode node, HierarchyNodeFlags flags, HierarchyTraversalDirection direction)
		{
		}

		[RequiredByNativeCode]
		private static IntPtr CreateHierarchyViewModel(IntPtr nativePtr, IntPtr flattenedPtr, IntPtr flattenedNodesPtr, int flattenedNodesCount, IntPtr nodesPtr, int nodesCount, int version)
		{
			return (IntPtr)0;
		}

		[RequiredByNativeCode]
		private static void UpdateHierarchyViewModel(IntPtr handlePtr, IntPtr flattenedNodesPtr, int flattenedNodesCount, IntPtr nodesPtr, int nodesCount, int version)
		{
		}

		[RequiredByNativeCode]
		private static void InvokeFlagsChanged(IntPtr handlePtr, HierarchyNodeFlags flags)
		{
		}

		[RequiredByNativeCode]
		private static void SearchBegin(IntPtr handlePtr)
		{
		}

		private static bool get_UpdateNeeded_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static HierarchySearchQueryDescriptor get_Query_Injected(IntPtr _unity_self)
		{
			return null;
		}

		private static int IndexOf_Injected(IntPtr _unity_self, in HierarchyNode node)
		{
			return 0;
		}

		private static bool Contains_Injected(IntPtr _unity_self, in HierarchyNode node)
		{
			return false;
		}

		private static int GetChildrenCount_Injected(IntPtr _unity_self, in HierarchyNode node)
		{
			return 0;
		}

		private static void Update_Injected(IntPtr _unity_self)
		{
		}

		private static IntPtr Create_Injected(IntPtr handlePtr, IntPtr hierarchyFlattened, HierarchyNodeFlags defaultFlags, out IntPtr nodesPtr, out int nodesCount, out IntPtr indicesPtr, out int indicesCount, out int version)
		{
			nodesPtr = default(IntPtr);
			nodesCount = default(int);
			indicesPtr = default(IntPtr);
			indicesCount = default(int);
			version = default(int);
			return (IntPtr)0;
		}

		private static void SetFlagsAll_Injected(IntPtr _unity_self, HierarchyNodeFlags flags)
		{
		}

		private static void SetFlagsNode_Injected(IntPtr _unity_self, in HierarchyNode node, HierarchyNodeFlags flags)
		{
		}

		private static void SetFlagsRecursiveNode_Injected(IntPtr _unity_self, in HierarchyNode node, HierarchyNodeFlags flags, HierarchyTraversalDirection direction)
		{
		}

		private static bool HasAllFlagsNode_Injected(IntPtr _unity_self, in HierarchyNode node, HierarchyNodeFlags flags)
		{
			return false;
		}

		private static void ClearFlagsNode_Injected(IntPtr _unity_self, in HierarchyNode node, HierarchyNodeFlags flags)
		{
		}

		private static void ClearFlagsRecursiveNode_Injected(IntPtr _unity_self, in HierarchyNode node, HierarchyNodeFlags flags, HierarchyTraversalDirection direction)
		{
		}
	}
}
