using System;
using System.Collections.Generic;

namespace UnityEngine.ResourceManagement.ResourceLocations
{
	internal class LocationWrapper : IResourceLocation
	{
		private IResourceLocation m_InternalLocation;

		public string InternalId => null;

		public string ProviderId => null;

		public IList<IResourceLocation> Dependencies => null;

		public int DependencyHashCode => 0;

		public bool HasDependencies => false;

		public object Data => null;

		public string PrimaryKey => null;

		public Type ResourceType => null;

		public LocationWrapper(IResourceLocation location)
		{
		}

		public int Hash(Type resultType)
		{
			return 0;
		}
	}
}
