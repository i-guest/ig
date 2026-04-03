using System;
using System.Collections.Generic;
using Unity.Collections;

namespace UnityEngine.UIElements.UIR
{
	internal class NativePagedList<T> : IDisposable where T : struct
	{
		private struct NativeArrayAllocator
		{
			private Allocator m_Allocator;

			private MemoryLabel m_MemoryLabel;

			public NativeArrayAllocator(string profilerName, Allocator allocator)
			{
				m_Allocator = default(Allocator);
				m_MemoryLabel = default(MemoryLabel);
			}

			public NativeArray<T> CreateArray(int length, NativeArrayOptions options = NativeArrayOptions.ClearMemory)
			{
				return default(NativeArray<T>);
			}
		}

		public struct Enumerator
		{
			private NativePagedList<T> m_NativePagedList;

			private NativeArray<T> m_CurrentPage;

			private int m_IndexInCurrentPage;

			private int m_IndexOfCurrentPage;

			private int m_CountInCurrentPage;

			public Enumerator(NativePagedList<T> nativePagedList, int offset)
			{
				m_NativePagedList = null;
				m_CurrentPage = default(NativeArray<T>);
				m_IndexInCurrentPage = 0;
				m_IndexOfCurrentPage = 0;
				m_CountInCurrentPage = 0;
			}

			public bool HasNext()
			{
				return false;
			}

			public T GetNext()
			{
				return default(T);
			}
		}

		private readonly int k_PoolCapacity;

		private List<NativeArray<T>> m_Pages;

		private NativeArray<T> m_LastPage;

		private int m_CountInLastPage;

		private readonly NativeArrayAllocator m_FirstPageAllocator;

		private readonly NativeArrayAllocator m_OtherPagesAllocator;

		private List<NativeSlice<T>> m_Enumerator;

		protected bool disposed { get; private set; }

		public NativePagedList(int poolCapacity, string profilerName, Allocator firstPageAllocator = Allocator.Persistent, Allocator otherPagesAllocator = Allocator.Persistent)
		{
		}

		public void Add(ref T data)
		{
		}

		public void Add(T data)
		{
		}

		public List<NativeSlice<T>> GetPages()
		{
			return null;
		}

		public int GetCount()
		{
			return 0;
		}

		public void Reset()
		{
		}

		public void Dispose()
		{
		}

		protected void Dispose(bool disposing)
		{
		}
	}
}
