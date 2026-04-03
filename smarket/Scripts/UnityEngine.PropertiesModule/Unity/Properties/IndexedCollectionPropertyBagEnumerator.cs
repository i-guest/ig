using System;
using System.Collections;
using System.Collections.Generic;

namespace Unity.Properties
{
	internal struct IndexedCollectionPropertyBagEnumerator<TContainer> : IEnumerator<IProperty<TContainer>>, IEnumerator, IDisposable
	{
		private readonly IIndexedCollectionPropertyBagEnumerator<TContainer> m_Impl;

		private readonly IndexedCollectionSharedPropertyState m_Previous;

		private TContainer m_Container;

		private int m_Position;

		public IProperty<TContainer> Current => null;

		object IEnumerator.Current => null;

		internal IndexedCollectionPropertyBagEnumerator(IIndexedCollectionPropertyBagEnumerator<TContainer> impl, TContainer container)
		{
			m_Impl = null;
			m_Previous = default(IndexedCollectionSharedPropertyState);
			m_Container = default(TContainer);
			m_Position = 0;
		}

		public bool MoveNext()
		{
			return false;
		}

		public void Reset()
		{
		}

		public void Dispose()
		{
		}
	}
}
