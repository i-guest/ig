using System;
using UnityEngine.Localization.Tables;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.Localization.Settings
{
	[Serializable]
	public class LocalizedAssetDatabase : LocalizedDatabase<AssetTable, AssetTableEntry>
	{
		public AsyncOperationHandle<TObject> GetLocalizedAssetAsync<TObject>(TableEntryReference tableEntryReference, Locale locale = null, FallbackBehavior fallbackBehavior = FallbackBehavior.UseProjectSettings)
		{
			return default(AsyncOperationHandle<TObject>);
		}

		public TObject GetLocalizedAsset<TObject>(TableEntryReference tableEntryReference, Locale locale = null)
		{
			return default(TObject);
		}

		public virtual AsyncOperationHandle<TObject> GetLocalizedAssetAsync<TObject>(TableReference tableReference, TableEntryReference tableEntryReference, Locale locale = null, FallbackBehavior fallbackBehavior = FallbackBehavior.UseProjectSettings)
		{
			return default(AsyncOperationHandle<TObject>);
		}

		public virtual TObject GetLocalizedAsset<TObject>(TableReference tableReference, TableEntryReference tableEntryReference, Locale locale = null)
		{
			return default(TObject);
		}

		protected virtual AsyncOperationHandle<TObject> GetLocalizedAssetAsyncInternal<TObject>(TableReference tableReference, TableEntryReference tableEntryReference, Locale locale, FallbackBehavior fallbackBehavior = FallbackBehavior.UseProjectSettings)
		{
			return default(AsyncOperationHandle<TObject>);
		}

		internal override void ReleaseTableContents(AssetTable table)
		{
		}
	}
}
