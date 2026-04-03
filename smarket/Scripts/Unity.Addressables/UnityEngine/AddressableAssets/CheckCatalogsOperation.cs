using System.Collections.Generic;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.AddressableAssets
{
	internal class CheckCatalogsOperation : AsyncOperationBase<List<string>>
	{
		private AddressablesImpl m_Addressables;

		private List<string> m_LocalHashes;

		private List<ResourceLocatorInfo> m_LocatorInfos;

		private AsyncOperationHandle<IList<AsyncOperationHandle>> m_DepOp;

		public CheckCatalogsOperation(AddressablesImpl aa)
		{
		}

		public AsyncOperationHandle<List<string>> Start(List<ResourceLocatorInfo> locatorInfos)
		{
			return default(AsyncOperationHandle<List<string>>);
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

		internal static List<string> ProcessDependentOpResults(IList<AsyncOperationHandle> results, List<ResourceLocatorInfo> locatorInfos, List<string> localHashes, out string errorString, out bool success)
		{
			errorString = null;
			success = default(bool);
			return null;
		}

		protected override void Execute()
		{
		}
	}
}
