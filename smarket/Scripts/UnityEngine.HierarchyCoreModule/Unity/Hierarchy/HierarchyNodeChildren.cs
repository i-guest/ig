using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Unity.Hierarchy
{
	[DefaultMember("Item")]
	public readonly struct HierarchyNodeChildren
	{
		public struct Enumerator
		{
			private readonly HierarchyNodeChildren m_Enumerable;

			private int m_Index;

			public ref readonly HierarchyNode Current
			{
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				get
				{
					throw null;
				}
			}

			internal Enumerator(in HierarchyNodeChildren enumerable)
			{
				m_Enumerable = default(HierarchyNodeChildren);
				m_Index = 0;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public bool MoveNext()
			{
				return false;
			}
		}

		private readonly Hierarchy m_Hierarchy;

		private unsafe readonly HierarchyNode* m_Ptr;

		private readonly int m_Version;

		private readonly int m_Count;

		internal unsafe HierarchyNodeChildren(Hierarchy hierarchy, IntPtr nodeChildrenPtr)
		{
			m_Hierarchy = null;
			m_Ptr = null;
			m_Version = 0;
			m_Count = 0;
		}

		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void ThrowIfVersionChanged()
		{
		}
	}
}
