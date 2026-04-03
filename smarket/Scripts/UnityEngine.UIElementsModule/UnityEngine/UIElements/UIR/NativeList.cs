using System;
using Unity.Collections;

namespace UnityEngine.UIElements.UIR
{
	internal class NativeList<T> : IDisposable where T : struct
	{
		private readonly MemoryLabel m_MemoryLabel;

		private NativeArray<T> m_NativeArray;

		private int m_Count;

		public int Count => 0;

		protected bool disposed { get; private set; }

		public NativeList(int initialCapacity, MemoryLabel allocLabel)
		{
		}

		private void Expand(int newLength)
		{
		}

		public void Add(NativeSlice<T> src)
		{
		}

		public void Clear()
		{
		}

		public NativeSlice<T> GetSlice(int start, int length)
		{
			return default(NativeSlice<T>);
		}

		public void Dispose()
		{
		}

		protected void Dispose(bool disposing)
		{
		}
	}
}
