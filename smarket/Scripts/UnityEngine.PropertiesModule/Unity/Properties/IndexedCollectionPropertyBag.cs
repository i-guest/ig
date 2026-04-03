namespace Unity.Properties
{
	public class IndexedCollectionPropertyBag<TList, TElement> : PropertyBag<TList>, IListPropertyBag<TList, TElement>, ICollectionPropertyBag<TList, TElement>, IPropertyBag<TList>, IPropertyBag, ICollectionPropertyBagAccept<TList>, IListPropertyBagAccept<TList>, IListPropertyAccept<TList>, IIndexedProperties<TList>, IConstructorWithCount<TList>, IConstructor, IIndexedCollectionPropertyBagEnumerator<TList>
	{
		private class ListElementProperty : Property<TList, TElement>, IListElementProperty
		{
			internal int m_Index;

			internal bool m_IsReadOnly;

			public int Index => 0;

			public override string Name => null;

			public override bool IsReadOnly => false;

			public override TElement GetValue(ref TList container)
			{
				return default(TElement);
			}

			public override void SetValue(ref TList container, TElement value)
			{
			}
		}

		private readonly ListElementProperty m_Property;

		public override PropertyCollection<TList> GetProperties()
		{
			return default(PropertyCollection<TList>);
		}

		public override PropertyCollection<TList> GetProperties(ref TList container)
		{
			return default(PropertyCollection<TList>);
		}

		public bool TryGetProperty(ref TList container, int index, out IProperty<TList> property)
		{
			property = null;
			return false;
		}

		void ICollectionPropertyBagAccept<TList>.Accept(ICollectionPropertyBagVisitor visitor, ref TList container)
		{
		}

		void IListPropertyBagAccept<TList>.Accept(IListPropertyBagVisitor visitor, ref TList list)
		{
		}

		void IListPropertyAccept<TList>.Accept<TContainer>(IListPropertyVisitor visitor, Property<TContainer, TList> property, ref TContainer container, ref TList list)
		{
		}

		TList IConstructorWithCount<TList>.InstantiateWithCount(int count)
		{
			return default(TList);
		}

		protected virtual TList InstantiateWithCount(int count)
		{
			return default(TList);
		}

		int IIndexedCollectionPropertyBagEnumerator<TList>.GetCount(ref TList container)
		{
			return 0;
		}

		IProperty<TList> IIndexedCollectionPropertyBagEnumerator<TList>.GetSharedProperty()
		{
			return null;
		}

		IndexedCollectionSharedPropertyState IIndexedCollectionPropertyBagEnumerator<TList>.GetSharedPropertyState()
		{
			return default(IndexedCollectionSharedPropertyState);
		}

		void IIndexedCollectionPropertyBagEnumerator<TList>.SetSharedPropertyState(IndexedCollectionSharedPropertyState state)
		{
		}
	}
}
