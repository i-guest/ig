using System;
using UnityEngine.ResourceManagement.ResourceLocations;

namespace UnityEngine.ResourceManagement.Util
{
	internal sealed class LocationCacheKey : IOperationCacheKey, IEquatable<IOperationCacheKey>
	{
		private readonly IResourceLocation m_Location;

		private readonly Type m_DesiredType;

		public LocationCacheKey(IResourceLocation location, Type desiredType)
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

		private bool Equals(LocationCacheKey other)
		{
			return false;
		}
	}
}
