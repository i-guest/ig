using System;

namespace UnityEngine.AddressableAssets
{
	[Serializable]
	public class AssetReferenceAtlasedSprite : AssetReferenceT<Sprite>
	{
		public AssetReferenceAtlasedSprite(string guid)
			: base((string)null)
		{
		}

		public override bool ValidateAsset(Object obj)
		{
			return false;
		}

		public override bool ValidateAsset(string path)
		{
			return false;
		}
	}
}
