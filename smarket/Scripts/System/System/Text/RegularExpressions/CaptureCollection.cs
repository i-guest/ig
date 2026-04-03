using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace System.Text.RegularExpressions
{
	/// <summary>Represents the set of captures made by a single capturing group. </summary>
	[DebuggerTypeProxy(typeof(CollectionDebuggerProxy<Capture>))]
	[DebuggerDisplay("Count = {Count}")]
	public class CaptureCollection : IList<Capture>, ICollection<Capture>, IEnumerable<Capture>, IEnumerable, IReadOnlyList<Capture>, IReadOnlyCollection<Capture>, IList, ICollection
	{
		[Serializable]
		private sealed class Enumerator : IEnumerator<Capture>, IDisposable, IEnumerator
		{
			private readonly CaptureCollection _collection;

			private int _index;

			public Capture Current => null;

			object IEnumerator.Current => null;

			internal Enumerator(CaptureCollection collection)
			{
			}

			public bool MoveNext()
			{
				return false;
			}

			void IEnumerator.Reset()
			{
			}

			void IDisposable.Dispose()
			{
			}
		}

		private readonly Group _group;

		private readonly int _capcount;

		private Capture[] _captures;

		/// <summary>Gets a value that indicates whether the collection is read only.</summary>
		/// <returns>
		///     <see langword="true" /> in all cases.</returns>
		public bool IsReadOnly => false;

		/// <summary>Gets the number of substrings captured by the group.</summary>
		/// <returns>The number of items in the <see cref="T:System.Text.RegularExpressions.CaptureCollection" />.</returns>
		public int Count => 0;

		/// <summary>Gets an individual member of the collection.</summary>
		/// <param name="i">Index into the capture collection. </param>
		/// <returns>The captured substring at position <paramref name="i" /> in the collection.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="i" /> is less than 0 or greater than <see cref="P:System.Text.RegularExpressions.CaptureCollection.Count" />. </exception>
		public Capture this[int i] => null;

		/// <summary>Gets a value that indicates whether access to the collection is synchronized (thread-safe).</summary>
		/// <returns>
		///     <see langword="false" /> in all cases.</returns>
		public bool IsSynchronized => false;

		/// <summary>Gets an object that can be used to synchronize access to the collection.</summary>
		/// <returns>An object that can be used to synchronize access to the collection.</returns>
		public object SyncRoot => null;

		Capture IList<Capture>.this[int index]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		bool IList.IsFixedSize => false;

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

		internal CaptureCollection(Group group)
		{
		}

		/// <summary>Provides an enumerator that iterates through the collection.</summary>
		/// <returns>An object that contains all <see cref="T:System.Text.RegularExpressions.Capture" /> objects within the <see cref="T:System.Text.RegularExpressions.CaptureCollection" />.</returns>
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		IEnumerator<Capture> IEnumerable<Capture>.GetEnumerator()
		{
			return null;
		}

		private Capture GetCapture(int i)
		{
			return null;
		}

		internal void ForceInitialized()
		{
		}

		/// <summary>Copies all the elements of the collection to the given array beginning at the given index.</summary>
		/// <param name="array">The array the collection is to be copied into. </param>
		/// <param name="arrayIndex">The position in the destination array where copying is to begin. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="array " />is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="arrayIndex" /> is outside the bounds of <paramref name="array" />. -or-
		///         <paramref name="arrayIndex" /> plus <see cref="P:System.Text.RegularExpressions.CaptureCollection.Count" /> is outside the bounds of <paramref name="array" />. </exception>
		public void CopyTo(Array array, int arrayIndex)
		{
		}

		public void CopyTo(Capture[] array, int arrayIndex)
		{
		}

		int IList<Capture>.IndexOf(Capture item)
		{
			return 0;
		}

		void IList<Capture>.Insert(int index, Capture item)
		{
		}

		void IList<Capture>.RemoveAt(int index)
		{
		}

		void ICollection<Capture>.Add(Capture item)
		{
		}

		void ICollection<Capture>.Clear()
		{
		}

		bool ICollection<Capture>.Contains(Capture item)
		{
			return false;
		}

		bool ICollection<Capture>.Remove(Capture item)
		{
			return false;
		}

		int IList.Add(object value)
		{
			return 0;
		}

		void IList.Clear()
		{
		}

		bool IList.Contains(object value)
		{
			return false;
		}

		int IList.IndexOf(object value)
		{
			return 0;
		}

		void IList.Insert(int index, object value)
		{
		}

		void IList.Remove(object value)
		{
		}

		void IList.RemoveAt(int index)
		{
		}

		internal CaptureCollection()
		{
		}
	}
}
