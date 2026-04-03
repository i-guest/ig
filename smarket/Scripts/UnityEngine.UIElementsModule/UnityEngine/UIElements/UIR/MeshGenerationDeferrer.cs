using System;
using System.Collections.Generic;
using Unity.Jobs;

namespace UnityEngine.UIElements.UIR
{
	internal class MeshGenerationDeferrer : IDisposable
	{
		private struct CallbackInfo
		{
			public MeshGenerationCallback callback;

			public object userData;
		}

		private Queue<CallbackInfo> m_Fork;

		private Queue<CallbackInfo> m_WorkThenFork;

		private Queue<CallbackInfo> m_Work;

		private Queue<CallbackInfo> m_JobDependentFork;

		private Queue<CallbackInfo> m_JobDependentWorkThenFork;

		private Queue<CallbackInfo> m_JobDependentWork;

		private Queue<JobHandle> m_Dependencies;

		private JobMerger m_DependencyMerger;

		protected bool disposed { get; private set; }

		public void AddMeshGenerationJob(JobHandle jobHandle)
		{
		}

		public void AddMeshGenerationCallback(MeshGenerationCallback callback, object userData, MeshGenerationCallbackType callbackType, bool isJobDependent)
		{
		}

		public void ProcessDeferredWork(MeshGenerationContext meshGenerationContext)
		{
		}

		private static void Invoke(CallbackInfo ci, MeshGenerationContext mgc)
		{
		}

		public void Dispose()
		{
		}

		protected void Dispose(bool disposing)
		{
		}
	}
}
