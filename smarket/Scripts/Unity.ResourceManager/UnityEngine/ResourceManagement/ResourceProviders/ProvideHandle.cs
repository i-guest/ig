using System;
using System.Collections.Generic;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceLocations;

namespace UnityEngine.ResourceManagement.ResourceProviders
{
	public struct ProvideHandle
	{
		private int m_Version;

		private IGenericProviderOperation m_InternalOp;

		private ResourceManager m_ResourceManager;

		internal bool IsValid => false;

		internal IGenericProviderOperation InternalOp => null;

		public ResourceManager ResourceManager => null;

		public Type Type => null;

		public IResourceLocation Location => null;

		public int DependencyCount => 0;

		internal ProvideHandle(ResourceManager rm, IGenericProviderOperation op)
		{
			m_Version = 0;
			m_InternalOp = null;
			m_ResourceManager = null;
		}

		public TDepObject GetDependency<TDepObject>(int index)
		{
			return default(TDepObject);
		}

		public void GetDependencies(IList<object> list)
		{
		}

		public void SetProgressCallback(Func<float> callback)
		{
		}

		public void SetDownloadProgressCallbacks(Func<DownloadStatus> callback)
		{
		}

		public void SetWaitForCompletionCallback(Func<bool> callback)
		{
		}

		public void Complete<T>(T result, bool status, Exception exception)
		{
		}
	}
}
