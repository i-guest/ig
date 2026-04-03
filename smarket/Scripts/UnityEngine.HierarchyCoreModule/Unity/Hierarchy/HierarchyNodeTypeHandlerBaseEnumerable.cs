using System;
using System.Runtime.CompilerServices;

namespace Unity.Hierarchy
{
	public readonly struct HierarchyNodeTypeHandlerBaseEnumerable
	{
		public struct Enumerator : IDisposable
		{
			private readonly IntPtr[] m_Handlers;

			private readonly int m_Count;

			private int m_Index;

			public HierarchyNodeTypeHandlerBase Current
			{
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				get
				{
					return null;
				}
			}

			internal Enumerator(Hierarchy hierarchy)
			{
				m_Handlers = null;
				m_Count = 0;
				m_Index = 0;
			}

			public void Dispose()
			{
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public bool MoveNext()
			{
				return false;
			}
		}

		private readonly Hierarchy m_Hierarchy;

		internal HierarchyNodeTypeHandlerBaseEnumerable(Hierarchy hierarchy)
		{
			m_Hierarchy = null;
		}

		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}
	}
}
