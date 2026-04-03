using System;
using System.Collections;
using System.Collections.Generic;

namespace UnityEngine.Animations.Rigging
{
	[Serializable]
	public struct WeightedTransformArray : IList<WeightedTransform>, ICollection<WeightedTransform>, IEnumerable<WeightedTransform>, IEnumerable, IList, ICollection
	{
		[Serializable]
		private struct Enumerator : IEnumerator<WeightedTransform>, IEnumerator, IDisposable
		{
			private WeightedTransformArray m_Array;

			private int m_Index;

			public WeightedTransform Current => default(WeightedTransform);

			object IEnumerator.Current => null;

			public Enumerator(ref WeightedTransformArray array)
			{
				m_Array = default(WeightedTransformArray);
				m_Index = 0;
			}

			public bool MoveNext()
			{
				return false;
			}

			public void Reset()
			{
			}

			void IDisposable.Dispose()
			{
			}
		}

		public static readonly int k_MaxLength;

		[SerializeField]
		[NotKeyable]
		private int m_Length;

		[SerializeField]
		private WeightedTransform m_Item0;

		[SerializeField]
		private WeightedTransform m_Item1;

		[SerializeField]
		private WeightedTransform m_Item2;

		[SerializeField]
		private WeightedTransform m_Item3;

		[SerializeField]
		private WeightedTransform m_Item4;

		[SerializeField]
		private WeightedTransform m_Item5;

		[SerializeField]
		private WeightedTransform m_Item6;

		[SerializeField]
		private WeightedTransform m_Item7;

		object IList.this[int index]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public WeightedTransform this[int index]
		{
			get
			{
				return default(WeightedTransform);
			}
			set
			{
			}
		}

		public int Count => 0;

		public bool IsReadOnly => false;

		public bool IsFixedSize => false;

		bool ICollection.IsSynchronized => false;

		object ICollection.SyncRoot => null;

		public WeightedTransformArray(int size)
		{
			m_Length = 0;
			m_Item0 = default(WeightedTransform);
			m_Item1 = default(WeightedTransform);
			m_Item2 = default(WeightedTransform);
			m_Item3 = default(WeightedTransform);
			m_Item4 = default(WeightedTransform);
			m_Item5 = default(WeightedTransform);
			m_Item6 = default(WeightedTransform);
			m_Item7 = default(WeightedTransform);
		}

		public IEnumerator<WeightedTransform> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		int IList.Add(object value)
		{
			return 0;
		}

		public void Add(WeightedTransform value)
		{
		}

		public void Clear()
		{
		}

		int IList.IndexOf(object value)
		{
			return 0;
		}

		public int IndexOf(WeightedTransform value)
		{
			return 0;
		}

		bool IList.Contains(object value)
		{
			return false;
		}

		public bool Contains(WeightedTransform value)
		{
			return false;
		}

		void ICollection.CopyTo(Array array, int arrayIndex)
		{
		}

		public void CopyTo(WeightedTransform[] array, int arrayIndex)
		{
		}

		void IList.Remove(object value)
		{
		}

		public bool Remove(WeightedTransform value)
		{
			return false;
		}

		public void RemoveAt(int index)
		{
		}

		void IList.Insert(int index, object value)
		{
		}

		public void Insert(int index, WeightedTransform value)
		{
		}

		private static int ClampSize(int size)
		{
			return 0;
		}

		private void CheckOutOfRangeIndex(int index)
		{
		}

		private WeightedTransform Get(int index)
		{
			return default(WeightedTransform);
		}

		private void Set(int index, WeightedTransform value)
		{
		}

		public void SetWeight(int index, float weight)
		{
		}

		public float GetWeight(int index)
		{
			return 0f;
		}

		public void SetTransform(int index, Transform transform)
		{
		}

		public Transform GetTransform(int index)
		{
			return null;
		}

		public static void OnValidate(ref WeightedTransformArray array, float min = 0f, float max = 1f)
		{
		}
	}
}
