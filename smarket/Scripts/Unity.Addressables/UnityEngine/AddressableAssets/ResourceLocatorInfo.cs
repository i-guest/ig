using UnityEngine.AddressableAssets.ResourceLocators;
using UnityEngine.ResourceManagement.ResourceLocations;

namespace UnityEngine.AddressableAssets
{
	public class ResourceLocatorInfo
	{
		public IResourceLocator Locator { get; private set; }

		public string LocalHash { get; private set; }

		public IResourceLocation CatalogLocation { get; private set; }

		internal bool ContentUpdateAvailable { get; set; }

		public IResourceLocation HashLocation => null;

		public bool CanUpdateContent => false;

		public ResourceLocatorInfo(IResourceLocator loc, string localHash, IResourceLocation remoteCatalogLocation)
		{
		}

		internal void UpdateContent(IResourceLocator locator, string hash, IResourceLocation loc)
		{
		}
	}
}
