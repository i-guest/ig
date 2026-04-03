using System;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.AddressableAssets
{
	[Serializable]
	public class AssetReferenceT<TObject> : AssetReference
	{
		public AssetReferenceT(string guid)
		{
		}

		public virtual AsyncOperationHandle<TObject> LoadAssetAsync()
		{
			return default(AsyncOperationHandle<TObject>);
		}

		public override bool ValidateAsset(Object obj)
		{
			return false;
		}

		public override bool ValidateAsset(string mainAssetPath)
		{
			return false;
		}
	}
}
