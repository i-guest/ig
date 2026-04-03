using System.Collections.Generic;

namespace UnityEngine.ResourceManagement.Util
{
	public class LinkedListNodeCache<T>
	{
		private int m_maxNodesAllowed;

		private int m_NodesCreated;

		private Stack<LinkedListNode<T>> m_NodeCache;

		internal int CreatedNodeCount => 0;

		internal int CachedNodeCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public LinkedListNodeCache()
		{
		}

		public LinkedListNodeCache(int maxNodesAllowed, int initialCapacity, int initialPreallocateCount)
		{
		}

		private void InitCache(int maxNodesAllowed = 2147483647, int initialCapacity = 10, int initialPreallocateCount = 0)
		{
		}

		public LinkedListNode<T> Acquire(T val)
		{
			return null;
		}

		public void Release(LinkedListNode<T> node)
		{
		}
	}
}
