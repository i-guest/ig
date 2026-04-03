using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.ResourceManagement.ResourceLocations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.ResourceManagement.Util;
using UnityEngine.Scripting;

namespace UnityEngine.ResourceManagement.AsyncOperations
{
	[Preserve]
	internal class ProviderOperation<TObject> : AsyncOperationBase<TObject>, IGenericProviderOperation, ICachable
	{
		private bool m_ReleaseDependenciesOnFailure;

		private Func<float> m_GetProgressCallback;

		private Func<DownloadStatus> m_GetDownloadProgressCallback;

		private Func<bool> m_WaitForCompletionCallback;

		private bool m_ProviderCompletedCalled;

		private DownloadStatus m_DownloadStatus;

		private IResourceProvider m_Provider;

		internal AsyncOperationHandle<IList<AsyncOperationHandle>> m_DepOp;

		private IResourceLocation m_Location;

		private int m_ProvideHandleVersion;

		private bool m_NeedsRelease;

		private ResourceManager m_ResourceManager;

		private const float k_OperationWaitingToCompletePercentComplete = 0.99f;

		internal const string kInvalidHandleMsg = "The ProvideHandle is invalid. After the handle has been completed, it can no longer be used";

		IOperationCacheKey ICachable.Key
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int ProvideHandleVersion => 0;

		public IResourceLocation Location => null;

		protected override string DebugName => null;

		public Type RequestedType => null;

		public int DependencyCount => 0;

		protected override float Progress => 0f;

		public void SetDownloadProgressCallback(Func<DownloadStatus> callback)
		{
		}

		public void SetWaitForCompletionCallback(Func<bool> callback)
		{
		}

		protected override bool InvokeWaitForCompletion()
		{
			return false;
		}

		internal override DownloadStatus GetDownloadStatus(HashSet<object> visited)
		{
			return default(DownloadStatus);
		}

		public override void GetDependencies(List<AsyncOperationHandle> deps)
		{
		}

		internal override void ReleaseDependencies()
		{
		}

		public void GetDependencies(IList<object> dstList)
		{
		}

		public TDepObject GetDependency<TDepObject>(int index)
		{
			return default(TDepObject);
		}

		public void SetProgressCallback(Func<float> callback)
		{
		}

		public void ProviderCompleted<T>(T result, bool status, Exception e)
		{
		}

		protected override void Execute()
		{
		}

		public void Init(ResourceManager rm, IResourceProvider provider, IResourceLocation location, AsyncOperationHandle<IList<AsyncOperationHandle>> depOp)
		{
		}

		public void Init(ResourceManager rm, IResourceProvider provider, IResourceLocation location, AsyncOperationHandle<IList<AsyncOperationHandle>> depOp, bool releaseDependenciesOnFailure)
		{
		}

		private bool WaitForCompletionHandler()
		{
			return false;
		}

		protected override void Destroy()
		{
		}
	}
}
