using System;
using System.Collections.Generic;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.ResourceManagement.Util
{
	internal sealed class AsyncOpHandlesCacheKey : IOperationCacheKey, IEquatable<IOperationCacheKey>
	{
		private readonly HashSet<AsyncOperationHandle> m_Handles;

		public AsyncOpHandlesCacheKey(IList<AsyncOperationHandle> handles)
		{
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(IOperationCacheKey other)
		{
			return false;
		}

		private bool Equals(AsyncOpHandlesCacheKey other)
		{
			return false;
		}
	}
}
