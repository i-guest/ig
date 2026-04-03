using System.Runtime.CompilerServices;

namespace Unity.Hierarchy
{
	public readonly struct HierarchyFlattenedChildrenEnumerable
	{
		public struct Enumerator
		{
			private readonly HierarchyFlattenedChildrenEnumerable m_Enumerable;

			private readonly int m_End;

			private readonly int m_Depth;

			private readonly int m_Version;

			private int m_Current;

			public ref readonly HierarchyFlattenedNode Current
			{
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				get
				{
					throw null;
				}
			}

			internal Enumerator(HierarchyFlattenedChildrenEnumerable enumerable)
			{
				m_Enumerable = default(HierarchyFlattenedChildrenEnumerable);
				m_End = 0;
				m_Depth = 0;
				m_Version = 0;
				m_Current = 0;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public bool MoveNext()
			{
				return false;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			private void ThrowIfVersionChanged()
			{
			}
		}

		private readonly HierarchyFlattened m_HierarchyFlattened;

		private readonly HierarchyFlattenedNode m_ParentNode;

		private readonly int m_ParentIndex;

		internal HierarchyFlattenedChildrenEnumerable(HierarchyFlattened hierarchyFlattened, in HierarchyNode node)
		{
			m_HierarchyFlattened = null;
			m_ParentNode = default(HierarchyFlattenedNode);
			m_ParentIndex = 0;
		}

		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}
	}
}
