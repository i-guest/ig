using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnityEngine.Pool
{
	public class ObjectPool<T> : IDisposable, IPool, IObjectPool<T> where T : class
	{
		internal readonly List<T> m_List;

		private readonly Func<T> m_CreateFunc;

		private readonly Action<T> m_ActionOnGet;

		private readonly Action<T> m_ActionOnRelease;

		private readonly Action<T> m_ActionOnDestroy;

		private readonly int m_MaxSize;

		internal bool m_CollectionCheck;

		private T m_FreshlyReleased;

		public int CountAll { get; private set; }

		public int CountInactive => 0;

		public ObjectPool(Func<T> createFunc, Action<T> actionOnGet = null, Action<T> actionOnRelease = null, Action<T> actionOnDestroy = null, bool collectionCheck = true, int defaultCapacity = 10, int maxSize = 10000)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public T Get()
		{
			return null;
		}

		public PooledObject<T> Get(out T v)
		{
			v = null;
			return default(PooledObject<T>);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Release(T element)
		{
		}

		public void Clear()
		{
		}

		public void Dispose()
		{
		}
	}
}
