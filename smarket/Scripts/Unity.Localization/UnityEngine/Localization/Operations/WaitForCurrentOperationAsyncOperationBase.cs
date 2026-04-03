using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.Localization.Operations
{
	internal abstract class WaitForCurrentOperationAsyncOperationBase<TObject> : AsyncOperationBase<TObject>
	{
		private bool m_Waiting;

		protected AsyncOperationHandle CurrentOperation { get; set; }

		public AsyncOperationHandle Dependency { get; set; }

		protected override bool InvokeWaitForCompletion()
		{
			return false;
		}

		protected override void Destroy()
		{
		}
	}
}
