using UnityEngine.ResourceManagement;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.Localization.Tables
{
	public class AssetTable : DetailedLocalizationTable<AssetTableEntry>, IPreloadRequired
	{
		private AsyncOperationHandle m_PreloadOperationHandle;

		private ResourceManager ResourceManager => null;

		public virtual AsyncOperationHandle PreloadOperation => default(AsyncOperationHandle);

		private AsyncOperationHandle PreloadAssets()
		{
			return default(AsyncOperationHandle);
		}

		public AsyncOperationHandle<TObject> GetAssetAsync<TObject>(TableEntryReference entryReference)
		{
			return default(AsyncOperationHandle<TObject>);
		}

		internal AsyncOperationHandle<TObject> GetAssetAsync<TObject>(AssetTableEntry entry)
		{
			return default(AsyncOperationHandle<TObject>);
		}

		public void ReleaseAssets()
		{
		}

		public void ReleaseAsset(AssetTableEntry entry)
		{
		}

		public void ReleaseAsset(TableEntryReference entry)
		{
		}

		public override AssetTableEntry CreateTableEntry()
		{
			return null;
		}
	}
}
