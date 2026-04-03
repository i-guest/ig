using System.Runtime.CompilerServices;

namespace Unity.Hierarchy
{
	public readonly struct HierarchyViewModelNodesEnumerable
	{
		internal delegate bool Predicate(in HierarchyNode node, HierarchyNodeFlags flags);

		public struct Enumerator
		{
			private readonly HierarchyViewModel m_HierarchyViewModel;

			private readonly Predicate m_Predicate;

			private readonly HierarchyNodeFlags m_Flags;

			private readonly ReadOnlyNativeVector<HierarchyFlattenedNode> m_FlattenedNodes;

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

			internal Enumerator(HierarchyViewModelNodesEnumerable enumerable)
			{
				m_HierarchyViewModel = null;
				m_Predicate = null;
				m_Flags = default(HierarchyNodeFlags);
				m_FlattenedNodes = default(ReadOnlyNativeVector<HierarchyFlattenedNode>);
				m_Version = 0;
				m_Index = 0;
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

		private readonly HierarchyViewModel m_HierarchyViewModel;

		private readonly Predicate m_Predicate;

		private readonly HierarchyNodeFlags m_Flags;

		internal HierarchyViewModelNodesEnumerable(HierarchyViewModel viewModel, HierarchyNodeFlags flags, Predicate predicate)
		{
			m_HierarchyViewModel = null;
			m_Predicate = null;
			m_Flags = default(HierarchyNodeFlags);
		}

		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}
	}
}
