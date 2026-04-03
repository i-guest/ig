using System;
using System.Collections.Generic;

namespace UnityEngine.ResourceManagement.Util
{
	public class LRUCacheAllocationStrategy : IAllocationStrategy
	{
		private int m_poolMaxSize;

		private int m_poolInitialCapacity;

		private int m_poolCacheMaxSize;

		private List<List<object>> m_poolCache;

		private Dictionary<int, List<object>> m_cache;

		public LRUCacheAllocationStrategy(int poolMaxSize, int poolCapacity, int poolCacheMaxSize, int initialPoolCacheCapacity)
		{
		}

		private List<object> GetPool()
		{
			return null;
		}

		private void ReleasePool(List<object> pool)
		{
		}

		public object New(Type type, int typeHash)
		{
			return null;
		}

		public void Release(int typeHash, object obj)
		{
		}
	}
}
