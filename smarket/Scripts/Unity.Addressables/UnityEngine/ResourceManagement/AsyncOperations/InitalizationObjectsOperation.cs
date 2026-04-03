using System.Collections.Generic;
using UnityEngine.AddressableAssets;
using UnityEngine.AddressableAssets.Initialization;

namespace UnityEngine.ResourceManagement.AsyncOperations
{
	internal class InitalizationObjectsOperation : AsyncOperationBase<bool>
	{
		private AsyncOperationHandle<ResourceManagerRuntimeData> m_RtdOp;

		private AddressablesImpl m_Addressables;

		private AsyncOperationHandle<IList<AsyncOperationHandle>> m_DepOp;

		protected override string DebugName => null;

		public void Init(AsyncOperationHandle<ResourceManagerRuntimeData> rtdOp, AddressablesImpl addressables)
		{
		}

		internal bool LogRuntimeWarnings(string pathToBuildLogs)
		{
			return false;
		}

		protected override bool InvokeWaitForCompletion()
		{
			return false;
		}

		protected override void Execute()
		{
		}
	}
}
