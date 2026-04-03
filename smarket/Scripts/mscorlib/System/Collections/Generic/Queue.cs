using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace System.Collections.Generic
{
	[Serializable]
	[TypeForwardedFrom("System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(QueueDebugView<>))]
	public class Queue<T> : IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T>
	{
		[Serializable]
		public struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator
		{
			private readonly Queue<T> _q;

			private readonly int _version;

			private int _index;

			private T _currentElement;

			public T Current => default(T);

			object IEnumerator.Current => null;

			internal Enumerator(Queue<T> q)
			{
				_q = null;
				_version = 0;
				_index = 0;
				_currentElement = default(T);
			}

			public void Dispose()
			{
			}

			public bool MoveNext()
			{
				return false;
			}

			private void ThrowEnumerationNotStartedOrEnded()
			{
			}

			void IEnumerator.Reset()
			{
			}
		}

		private T[] _array;

		private int _head;

		private int _tail;

		private int _size;

		private int _version;

		[NonSerialized]
		private object _syncRoot;

		public int Count => 0;

		bool ICollection.IsSynchronized => false;

		object ICollection.SyncRoot => null;

		public Queue()
		{
		}

		public Queue(int capacity)
		{
		}

		public Queue(IEnumerable<T> collection)
		{
		}

		public void Clear()
		{
		}

		void ICollection.CopyTo(Array array, int index)
		{
		}

		public void Enqueue(T item)
		{
		}

		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		public T Dequeue()
		{
			return default(T);
		}

		public bool TryDequeue(out T result)
		{
			result = default(T);
			return false;
		}

		public T Peek()
		{
			return default(T);
		}

		public bool TryPeek(out T result)
		{
			result = default(T);
			return false;
		}

		public bool Contains(T item)
		{
			return false;
		}

		public T[] ToArray()
		{
			return null;
		}

		private void SetCapacity(int capacity)
		{
		}

		private void MoveNext(ref int index)
		{
		}

		private void ThrowForEmptyQueue()
		{
		}

		public void TrimExcess()
		{
		}
	}
}
