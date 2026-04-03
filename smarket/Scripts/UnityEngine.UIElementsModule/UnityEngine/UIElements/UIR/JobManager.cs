using System;

namespace UnityEngine.UIElements.UIR
{
	internal class JobManager : IDisposable
	{
		private const string k_JobManagerName = "Renderer.JobManager";

		private NativePagedList<NudgeJobData> m_NudgeJobs;

		private NativePagedList<ConvertMeshJobData> m_ConvertMeshJobs;

		private NativePagedList<CopyMeshJobData> m_CopyMeshJobs;

		private JobMerger m_JobMerger;

		protected bool disposed { get; private set; }

		public void Add(ref NudgeJobData job)
		{
		}

		public void Add(ref ConvertMeshJobData job)
		{
		}

		public void Add(ref CopyMeshJobData job)
		{
		}

		public void CompleteNudgeJobs()
		{
		}

		public void CompleteConvertMeshJobs()
		{
		}

		public void CompleteCopyMeshJobs()
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
