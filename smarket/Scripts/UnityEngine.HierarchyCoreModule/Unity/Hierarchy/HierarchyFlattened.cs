using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace Unity.Hierarchy
{
	[StructLayout((LayoutKind)0)]
	[NativeHeader("Modules/HierarchyCore/HierarchyFlattenedBindings.h")]
	[NativeHeader("Modules/HierarchyCore/Public/HierarchyFlattened.h")]
	[RequiredByNativeCode]
	public sealed class HierarchyFlattened : IDisposable
	{
		internal static class BindingsMarshaller
		{
			public static IntPtr ConvertToUnmanaged(HierarchyFlattened hierarchyFlattened)
			{
				return (IntPtr)0;
			}
		}

		public struct Enumerator
		{
			private readonly HierarchyFlattened m_HierarchyFlattened;

			private readonly ReadOnlyNativeVector<HierarchyFlattenedNode> m_FlattenedNodes;

			private readonly int m_Version;

			private int m_Index;

			public ref readonly HierarchyFlattenedNode Current
			{
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				get
				{
					throw null;
				}
			}

			internal Enumerator(HierarchyFlattened hierarchyFlattened)
			{
				m_HierarchyFlattened = null;
				m_FlattenedNodes = default(ReadOnlyNativeVector<HierarchyFlattenedNode>);
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

		private ReadOnlyNativeVector<HierarchyFlattenedNode> m_FlattenedNodes;

		private int m_Version;

		private readonly bool m_IsOwner;

		public bool IsCreated => false;

		public bool UpdateNeeded
		{
			[NativeMethod("UpdateNeeded", IsThreadSafe = true)]
			get
			{
				return false;
			}
		}

		internal int Version
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return 0;
			}
		}

		public ref readonly HierarchyFlattenedNode this[int index]
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				throw null;
			}
		}

		public HierarchyFlattened(Hierarchy hierarchy)
		{
		}

		private HierarchyFlattened(IntPtr nativePtr, Hierarchy hierarchy, IntPtr flattenedNodesPtr, int flattenedNodesCount, int version)
		{
		}

		~HierarchyFlattened()
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

		public HierarchyFlattenedChildrenEnumerable EnumerateChildren(in HierarchyNode node)
		{
			return default(HierarchyFlattenedChildrenEnumerable);
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
		internal static HierarchyFlattened FromIntPtr(IntPtr handlePtr)
		{
			return null;
		}

		[FreeFunction("HierarchyFlattenedBindings::Create", IsThreadSafe = true)]
		private static IntPtr Create(IntPtr handlePtr, Hierarchy hierarchy, out IntPtr nodesPtr, out int nodesCount, out int version)
		{
			nodesPtr = default(IntPtr);
			nodesCount = default(int);
			version = default(int);
			return (IntPtr)0;
		}

		[FreeFunction("HierarchyFlattenedBindings::Destroy", IsThreadSafe = true)]
		private static void Destroy(IntPtr nativePtr)
		{
		}

		[RequiredByNativeCode]
		private static IntPtr CreateHierarchyFlattened(IntPtr nativePtr, IntPtr hierarchyPtr, IntPtr flattenedNodesPtr, int flattenedNodesCount, int version)
		{
			return (IntPtr)0;
		}

		[RequiredByNativeCode]
		private static void UpdateHierarchyFlattened(IntPtr handlePtr, IntPtr flattenedNodesPtr, int flattenedNodesCount, int version)
		{
		}

		private static bool get_UpdateNeeded_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static int IndexOf_Injected(IntPtr _unity_self, in HierarchyNode node)
		{
			return 0;
		}

		private static bool Contains_Injected(IntPtr _unity_self, in HierarchyNode node)
		{
			return false;
		}

		private static void Update_Injected(IntPtr _unity_self)
		{
		}

		private static IntPtr Create_Injected(IntPtr handlePtr, IntPtr hierarchy, out IntPtr nodesPtr, out int nodesCount, out int version)
		{
			nodesPtr = default(IntPtr);
			nodesCount = default(int);
			version = default(int);
			return (IntPtr)0;
		}
	}
}
