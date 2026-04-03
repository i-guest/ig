using System.Collections.Generic;

namespace UnityEngine.ResourceManagement.ResourceLocations
{
	public class ResourceLocationComparer : IEqualityComparer<IResourceLocation>
	{
		public bool Equals(IResourceLocation x, IResourceLocation y)
		{
			return false;
		}

		public int GetHashCode(IResourceLocation obj)
		{
			return 0;
		}
	}
}
