using System;
using System.Collections;
using System.Collections.Generic;

namespace Unity.Properties
{
	public class KeyValueCollectionPropertyBag<TDictionary, TKey, TValue> : PropertyBag<TDictionary>, IDictionaryPropertyBag<TDictionary, TKey, TValue>, ICollectionPropertyBag<TDictionary, KeyValuePair<TKey, TValue>>, IPropertyBag<TDictionary>, IPropertyBag, ICollectionPropertyBagAccept<TDictionary>, IDictionaryPropertyBagAccept<TDictionary>, IKeyedProperties<TDictionary, object>
	{
		private class KeyValuePairProperty : Property<TDictionary, KeyValuePair<TKey, TValue>>, IDictionaryElementProperty
		{
			public override string Name => null;

			public override bool IsReadOnly => false;

			public TKey Key { get; internal set; }

			public object ObjectKey => null;

			public override KeyValuePair<TKey, TValue> GetValue(ref TDictionary container)
			{
				return default(KeyValuePair<TKey, TValue>);
			}

			public override void SetValue(ref TDictionary container, KeyValuePair<TKey, TValue> value)
			{
			}
		}

		private readonly struct Enumerable : IEnumerable<IProperty<TDictionary>>, IEnumerable
		{
			private class Enumerator : IEnumerator<IProperty<TDictionary>>, IEnumerator, IDisposable
			{
				private readonly TDictionary m_Dictionary;

				private readonly KeyValuePairProperty m_Property;

				private readonly TKey m_Previous;

				private readonly List<TKey> m_Keys;

				private int m_Position;

				public IProperty<TDictionary> Current => null;

				object IEnumerator.Current => null;

				public Enumerator(TDictionary dictionary, KeyValuePairProperty property)
				{
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

			private readonly TDictionary m_Dictionary;

			private readonly KeyValuePairProperty m_Property;

			public Enumerable(TDictionary dictionary, KeyValuePairProperty property)
			{
				m_Dictionary = default(TDictionary);
				m_Property = null;
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			IEnumerator<IProperty<TDictionary>> IEnumerable<IProperty<TDictionary>>.GetEnumerator()
			{
				return null;
			}
		}

		private readonly KeyValuePairProperty m_KeyValuePairProperty;

		public override PropertyCollection<TDictionary> GetProperties()
		{
			return default(PropertyCollection<TDictionary>);
		}

		public override PropertyCollection<TDictionary> GetProperties(ref TDictionary container)
		{
			return default(PropertyCollection<TDictionary>);
		}

		void ICollectionPropertyBagAccept<TDictionary>.Accept(ICollectionPropertyBagVisitor visitor, ref TDictionary container)
		{
		}

		void IDictionaryPropertyBagAccept<TDictionary>.Accept(IDictionaryPropertyBagVisitor visitor, ref TDictionary container)
		{
		}

		bool IKeyedProperties<TDictionary, object>.TryGetProperty(ref TDictionary container, object key, out IProperty<TDictionary> property)
		{
			property = null;
			return false;
		}
	}
}
