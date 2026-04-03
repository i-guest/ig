using System;
using Unity.Collections;

namespace UnityEngine.UIElements.Layout
{
	internal struct LayoutList<T> : IDisposable where T : struct
	{
		private struct Data
		{
			public int Capacity;

			public int Count;

			public unsafe T* Values;
		}

		private static readonly MemoryLabel s_Label;

		private unsafe Data* m_Data;

		public int Count => 0;

		public bool IsCreated => false;

		public ref T this[int index]
		{
			get
			{
				throw null;
			}
		}

		public unsafe LayoutList()
		{
			m_Data = null;
		}

		public unsafe LayoutList(int initialCapacity)
		{
			m_Data = null;
		}

		public void Dispose()
		{
		}

		public void Insert(int index, T value)
		{
		}

		public void RemoveAt(int index)
		{
		}

		private void IncreaseCapacity()
		{
		}

		private void EnsureCapacity(int capacity)
		{
		}

		private void ResizeCapacity(int capacity)
		{
		}

		private unsafe static void* ResizeArray(void* fromPtr, long fromCount, long toCount, long size, int align)
		{
			return null;
		}
	}
}
