using System.Collections.Generic;
using UnityEngine.AddressableAssets.ResourceLocators;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceLocations;
using UnityEngine.ResourceManagement.Util;

namespace UnityEngine.AddressableAssets.Initialization
{
	internal class InitializationOperation : AsyncOperationBase<IResourceLocator>
	{
		private AsyncOperationHandle<ResourceManagerRuntimeData> m_rtdOp;

		private AsyncOperationHandle<IResourceLocator> m_loadCatalogOp;

		private string m_ProviderSuffix;

		private AddressablesImpl m_Addressables;

		private InitalizationObjectsOperation m_InitGroupOps;

		protected override float Progress => 0f;

		protected override string DebugName => null;

		public InitializationOperation(AddressablesImpl aa)
		{
		}

		internal static AsyncOperationHandle<IResourceLocator> CreateInitializationOperation(AddressablesImpl aa, string playerSettingsLocation, string providerSuffix)
		{
			return default(AsyncOperationHandle<IResourceLocator>);
		}

		protected override bool InvokeWaitForCompletion()
		{
			return false;
		}

		protected override void Execute()
		{
		}

		private static void LoadProvider(AddressablesImpl addressables, ObjectInitializationData providerData, string providerSuffix)
		{
		}

		private static AsyncOperationHandle<IResourceLocator> OnCatalogDataLoaded(AddressablesImpl addressables, AsyncOperationHandle<ContentCatalogData> op, string providerSuffix, IResourceLocation remoteHashLocation)
		{
			return default(AsyncOperationHandle<IResourceLocator>);
		}

		public static AsyncOperationHandle<IResourceLocator> LoadContentCatalog(AddressablesImpl addressables, IResourceLocation loc, string providerSuffix, IResourceLocation remoteHashLocation = null)
		{
			return default(AsyncOperationHandle<IResourceLocator>);
		}

		public AsyncOperationHandle<IResourceLocator> LoadContentCatalog(IResourceLocation loc, string providerSuffix, IResourceLocation remoteHashLocation)
		{
			return default(AsyncOperationHandle<IResourceLocator>);
		}

		internal AsyncOperationHandle<IResourceLocator> LoadContentCatalogInternal(IList<IResourceLocation> catalogs, int index, ResourceLocationMap locMap, IResourceLocation remoteHashLocation)
		{
			return default(AsyncOperationHandle<IResourceLocator>);
		}

		private void LoadOpComplete(AsyncOperationHandle<IResourceLocator> op, IList<IResourceLocation> catalogs, ResourceLocationMap locMap, int index, IResourceLocation remoteHashLocation)
		{
		}
	}
}
