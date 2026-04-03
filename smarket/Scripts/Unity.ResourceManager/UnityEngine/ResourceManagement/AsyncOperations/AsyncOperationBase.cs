using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace UnityEngine.ResourceManagement.AsyncOperations
{
	public abstract class AsyncOperationBase<TObject> : IAsyncOperation
	{
		private int m_referenceCount;

		internal AsyncOperationStatus m_Status;

		internal Exception m_Error;

		internal ResourceManager m_RM;

		internal int m_Version;

		private DelegateList<AsyncOperationHandle> m_DestroyedAction;

		private DelegateList<AsyncOperationHandle<TObject>> m_CompletedActionT;

		private Action<IAsyncOperation> m_OnDestroyAction;

		private Action<AsyncOperationHandle> m_dependencyCompleteAction;

		protected internal bool HasExecuted;

		private TaskCompletionSource<TObject> m_taskCompletionSource;

		private TaskCompletionSource<object> m_taskCompletionSourceTypeless;

		private bool m_InDeferredCallbackQueue;

		private DelegateList<float> m_UpdateCallbacks;

		private Action<float> m_UpdateCallback;

		protected virtual float Progress => 0f;

		protected virtual string DebugName => null;

		public TObject Result { get; set; }

		internal int Version => 0;

		internal bool CompletedEventHasListeners => false;

		internal bool DestroyedEventHasListeners => false;

		internal Action<IAsyncOperation> OnDestroy
		{
			set
			{
			}
		}

		protected internal int ReferenceCount => 0;

		public bool IsRunning { get; internal set; }

		internal Task<TObject> Task => null;

		Task<object> IAsyncOperation.Task => null;

		internal AsyncOperationStatus Status => default(AsyncOperationStatus);

		internal Exception OperationException
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		internal object Current => null;

		internal bool IsDone => false;

		internal float PercentComplete => 0f;

		internal AsyncOperationHandle<TObject> Handle => default(AsyncOperationHandle<TObject>);

		int IAsyncOperation.Version => 0;

		int IAsyncOperation.ReferenceCount => 0;

		float IAsyncOperation.PercentComplete => 0f;

		AsyncOperationStatus IAsyncOperation.Status => default(AsyncOperationStatus);

		Exception IAsyncOperation.OperationException => null;

		bool IAsyncOperation.IsDone => false;

		AsyncOperationHandle IAsyncOperation.Handle => default(AsyncOperationHandle);

		Action<IAsyncOperation> IAsyncOperation.OnDestroy
		{
			set
			{
			}
		}

		string IAsyncOperation.DebugName => null;

		Type IAsyncOperation.ResultType => null;

		internal event Action Executed
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		internal event Action<AsyncOperationHandle<TObject>> Completed
		{
			add
			{
			}
			remove
			{
			}
		}

		internal event Action<AsyncOperationHandle> Destroyed
		{
			add
			{
			}
			remove
			{
			}
		}

		internal event Action<AsyncOperationHandle> CompletedTypeless
		{
			add
			{
			}
			remove
			{
			}
		}

		event Action<AsyncOperationHandle> IAsyncOperation.CompletedTypeless
		{
			add
			{
			}
			remove
			{
			}
		}

		event Action<AsyncOperationHandle> IAsyncOperation.Destroyed
		{
			add
			{
			}
			remove
			{
			}
		}

		protected abstract void Execute();

		protected virtual void Destroy()
		{
		}

		public virtual void GetDependencies(List<AsyncOperationHandle> dependencies)
		{
		}

		internal static string ShortenPath(string p, bool keepExtension)
		{
			return null;
		}

		public void WaitForCompletion()
		{
		}

		protected virtual bool InvokeWaitForCompletion()
		{
			return false;
		}

		protected internal void IncrementReferenceCount()
		{
		}

		protected internal void DecrementReferenceCount()
		{
		}

		public override string ToString()
		{
			return null;
		}

		private void RegisterForDeferredCallbackEvent(bool incrementReferenceCount = true)
		{
		}

		internal bool MoveNext()
		{
			return false;
		}

		internal void Reset()
		{
		}

		internal void InvokeCompletionEvent()
		{
		}

		private void UpdateCallback(float unscaledDeltaTime)
		{
		}

		public void Complete(TObject result, bool success, string errorMsg)
		{
		}

		public void Complete(TObject result, bool success, string errorMsg, bool releaseDependenciesOnFailure)
		{
		}

		public void Complete(TObject result, bool success, Exception exception, bool releaseDependenciesOnFailure = true)
		{
		}

		internal void Start(ResourceManager rm, AsyncOperationHandle dependency, DelegateList<float> updateCallbacks)
		{
		}

		internal void InvokeExecute()
		{
		}

		object IAsyncOperation.GetResultAsObject()
		{
			return null;
		}

		void IAsyncOperation.GetDependencies(List<AsyncOperationHandle> deps)
		{
		}

		void IAsyncOperation.DecrementReferenceCount()
		{
		}

		void IAsyncOperation.IncrementReferenceCount()
		{
		}

		void IAsyncOperation.InvokeCompletionEvent()
		{
		}

		void IAsyncOperation.Start(ResourceManager rm, AsyncOperationHandle dependency, DelegateList<float> updateCallbacks)
		{
		}

		internal virtual void ReleaseDependencies()
		{
		}

		DownloadStatus IAsyncOperation.GetDownloadStatus(HashSet<object> visited)
		{
			return default(DownloadStatus);
		}

		internal virtual DownloadStatus GetDownloadStatus(HashSet<object> visited)
		{
			return default(DownloadStatus);
		}
	}
}
