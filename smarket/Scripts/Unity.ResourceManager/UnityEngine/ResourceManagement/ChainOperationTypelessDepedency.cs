using System;
using System.Collections.Generic;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.ResourceManagement
{
	internal class ChainOperationTypelessDepedency<TObject> : AsyncOperationBase<TObject>
	{
		private AsyncOperationHandle m_DepOp;

		private AsyncOperationHandle<TObject> m_WrappedOp;

		private DownloadStatus m_depStatus;

		private DownloadStatus m_wrapStatus;

		private Func<AsyncOperationHandle, AsyncOperationHandle<TObject>> m_Callback;

		private Action<AsyncOperationHandle<TObject>> m_CachedOnWrappedCompleted;

		private bool m_ReleaseDependenciesOnFailure;

		internal AsyncOperationHandle<TObject> WrappedOp => default(AsyncOperationHandle<TObject>);

		protected override string DebugName => null;

		protected override float Progress => 0f;

		public override void GetDependencies(List<AsyncOperationHandle> deps)
		{
		}

		public void Init(AsyncOperationHandle dependentOp, Func<AsyncOperationHandle, AsyncOperationHandle<TObject>> callback, bool releaseDependenciesOnFailure)
		{
		}

		protected override bool InvokeWaitForCompletion()
		{
			return false;
		}

		protected override void Execute()
		{
		}

		private void OnWrappedCompleted(AsyncOperationHandle<TObject> x)
		{
		}

		protected override void Destroy()
		{
		}

		internal override void ReleaseDependencies()
		{
		}

		internal override DownloadStatus GetDownloadStatus(HashSet<object> visited)
		{
			return default(DownloadStatus);
		}

		private void RefreshDownloadStatus(HashSet<object> visited = null)
		{
		}
	}
}
