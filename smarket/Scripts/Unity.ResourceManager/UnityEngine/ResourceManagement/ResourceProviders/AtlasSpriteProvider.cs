using System.ComponentModel;
using UnityEngine.ResourceManagement.ResourceLocations;

namespace UnityEngine.ResourceManagement.ResourceProviders
{
	[DisplayName("Sprites from Atlases Provider")]
	public class AtlasSpriteProvider : ResourceProviderBase
	{
		public override void Provide(ProvideHandle providerInterface)
		{
		}

		public override void Release(IResourceLocation location, object obj)
		{
		}
	}
}
