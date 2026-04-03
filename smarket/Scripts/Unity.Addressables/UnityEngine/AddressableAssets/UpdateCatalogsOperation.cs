using System.Collections.Generic;
using UnityEngine.AddressableAssets.ResourceLocators;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.AddressableAssets
{
	internal class UpdateCatalogsOperation : AsyncOperationBase<List<IResourceLocator>>
	{
		private AddressablesImpl m_Addressables;

		private List<ResourceLocatorInfo> m_LocatorInfos;

		internal AsyncOperationHandle<IList<AsyncOperationHandle>> m_DepOp;

		private AsyncOperationHandle<bool> m_CleanCacheOp;

		private bool m_AutoCleanBundleCache;

		public UpdateCatalogsOperation(AddressablesImpl aa)
		{
		}

		public AsyncOperationHandle<List<IResourceLocator>> Start(IEnumerable<string> catalogIds, bool autoCleanBundleCache)
		{
			return default(AsyncOperationHandle<List<IResourceLocator>>);
		}

		protected override bool InvokeWaitForCompletion()
		{
			return false;
		}

		protected override void Destroy()
		{
		}

		public override void GetDependencies(List<AsyncOperationHandle> dependencies)
		{
		}

		protected override void Execute()
		{
		}

		private void OnCleanCacheCompleted(AsyncOperationHandle<bool> handle, List<IResourceLocator> catalogs)
		{
		}
	}
}
