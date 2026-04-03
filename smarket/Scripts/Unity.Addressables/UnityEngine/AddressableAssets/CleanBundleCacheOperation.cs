using System.Collections.Generic;
using System.Threading;
using UnityEngine.ResourceManagement;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.AddressableAssets
{
	internal class CleanBundleCacheOperation : AsyncOperationBase<bool>, IUpdateReceiver
	{
		private AddressablesImpl m_Addressables;

		private AsyncOperationHandle<IList<AsyncOperationHandle>> m_DepOp;

		private List<string> m_CacheDirsForRemoval;

		private Thread m_EnumerationThread;

		private string m_BaseCachePath;

		private bool m_UseMultiThreading;

		public CleanBundleCacheOperation(AddressablesImpl aa, bool forceSingleThreading)
		{
		}

		public AsyncOperationHandle<bool> Start(AsyncOperationHandle<IList<AsyncOperationHandle>> depOp)
		{
			return default(AsyncOperationHandle<bool>);
		}

		public void CompleteInternal(bool result, bool success, string errorMsg)
		{
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

		void IUpdateReceiver.Update(float unscaledDeltaTime)
		{
		}

		private void RemoveCacheEntries()
		{
		}

		private void DetermineCacheDirsNotInUse(object data)
		{
		}

		private void DetermineCacheDirsNotInUse(HashSet<string> cacheDirsInUse)
		{
		}

		private HashSet<string> GetCacheDirsInUse(IList<AsyncOperationHandle> catalogOps)
		{
			return null;
		}
	}
}
