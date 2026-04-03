using System;
using System.Collections;
using Unity.Hierarchy;

namespace UnityEngine.UIElements
{
	internal class ReadOnlyHierarchyViewModelList : IList, ICollection, IEnumerable
	{
		private struct Enumerator : IEnumerator
		{
			private readonly HierarchyViewModel m_HierarchyViewModel;

			private HierarchyViewModel.Enumerator m_Enumerator;

			public object Current => null;

			public Enumerator(HierarchyViewModel hierarchyViewModel)
			{
				m_HierarchyViewModel = null;
				m_Enumerator = default(HierarchyViewModel.Enumerator);
			}

			public bool MoveNext()
			{
				return false;
			}

			public void Reset()
			{
			}
		}

		private readonly HierarchyViewModel m_HierarchyViewModel;

		public bool IsFixedSize => false;

		public bool IsReadOnly => false;

		public int Count => 0;

		public object this[int index]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool IsSynchronized => false;

		public object SyncRoot => null;

		public bool Contains(object value)
		{
			return false;
		}

		public int IndexOf(object value)
		{
			return 0;
		}

		public ReadOnlyHierarchyViewModelList(HierarchyViewModel viewModel)
		{
		}

		public void CopyTo(Array array, int index)
		{
		}

		public IEnumerator GetEnumerator()
		{
			return null;
		}

		public int Add(object value)
		{
			return 0;
		}

		public void Clear()
		{
		}

		public void Insert(int index, object value)
		{
		}

		public void Remove(object value)
		{
		}

		public void RemoveAt(int index)
		{
		}
	}
}
