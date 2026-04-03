using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.Localization.Settings
{
	public interface ITableProvider
	{
		AsyncOperationHandle<TTable> ProvideTableAsync<TTable>(string tableCollectionName, Locale locale);
	}
}
