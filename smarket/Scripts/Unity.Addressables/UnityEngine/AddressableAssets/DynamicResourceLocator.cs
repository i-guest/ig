using System;
using System.Collections.Generic;
using UnityEngine.AddressableAssets.ResourceLocators;
using UnityEngine.ResourceManagement.ResourceLocations;

namespace UnityEngine.AddressableAssets
{
	internal class DynamicResourceLocator : IResourceLocator
	{
		private AddressablesImpl m_Addressables;

		private string m_AtlasSpriteProviderId;

		public string LocatorId => null;

		public virtual IEnumerable<object> Keys => null;

		private string AtlasSpriteProviderId => null;

		public IEnumerable<IResourceLocation> AllLocations => null;

		public DynamicResourceLocator(AddressablesImpl addr)
		{
		}

		public bool Locate(object key, Type type, out IList<IResourceLocation> locations)
		{
			locations = null;
			return false;
		}

		internal void CreateDynamicLocations(Type type, IList<IResourceLocation> locations, string locName, string subKey, IResourceLocation mainLoc)
		{
		}
	}
}
