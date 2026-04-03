using System;
using System.Collections.Generic;

namespace UnityEngine.ResourceManagement.Util
{
	internal struct LRUCache<TKey, TValue>
	{
		public struct Key : IEquatable<Key>
		{
			private static Type typeType;

			public TKey key;

			public Type type;

			public Key(TKey k, Type t)
			{
				key = default(TKey);
				type = null;
			}

			bool IEquatable<Key>.Equals(Key other)
			{
				return false;
			}

			public override int GetHashCode()
			{
				return 0;
			}
		}

		public struct Entry : IEquatable<Entry>
		{
			public LinkedListNode<Key> lruNode;

			public TValue Value;

			public bool Equals(Entry other)
			{
				return false;
			}

			public override int GetHashCode()
			{
				return 0;
			}
		}

		public int requestHits;

		public int requestCount;

		private int entryLimit;

		private Dictionary<Key, Entry> cache;

		private LinkedList<Key> lru;

		public LRUCache(int limit)
		{
			requestHits = 0;
			requestCount = 0;
			entryLimit = 0;
			cache = null;
			lru = null;
		}

		public bool TryAdd(TKey id, TValue obj)
		{
			return false;
		}

		public bool TryGet(Type type, TKey id, out TValue val)
		{
			val = default(TValue);
			return false;
		}
	}
}
