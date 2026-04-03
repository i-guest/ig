using System;
using System.Collections.Generic;
using UnityEngine.ResourceManagement.ResourceLocations;

namespace UnityEngine.ResourceManagement.Util
{
	internal sealed class DependenciesCacheKey : IOperationCacheKey, IEquatable<IOperationCacheKey>
	{
		private readonly IList<IResourceLocation> m_Dependencies;

		private readonly int m_DependenciesHash;

		public DependenciesCacheKey(IList<IResourceLocation> dependencies, int dependenciesHash)
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

		private bool Equals(DependenciesCacheKey other)
		{
			return false;
		}
	}
}
