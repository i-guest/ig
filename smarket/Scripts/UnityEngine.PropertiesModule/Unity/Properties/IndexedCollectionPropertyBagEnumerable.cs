namespace Unity.Properties
{
	internal readonly struct IndexedCollectionPropertyBagEnumerable<TContainer>
	{
		private readonly IIndexedCollectionPropertyBagEnumerator<TContainer> m_Impl;

		private readonly TContainer m_Container;

		public IndexedCollectionPropertyBagEnumerable(IIndexedCollectionPropertyBagEnumerator<TContainer> impl, TContainer container)
		{
			m_Impl = null;
			m_Container = default(TContainer);
		}

		public IndexedCollectionPropertyBagEnumerator<TContainer> GetEnumerator()
		{
			return default(IndexedCollectionPropertyBagEnumerator<TContainer>);
		}
	}
}
