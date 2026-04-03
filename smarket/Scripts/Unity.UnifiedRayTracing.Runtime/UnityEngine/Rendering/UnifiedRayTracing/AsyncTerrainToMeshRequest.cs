using System.Collections.Generic;
using Unity.Jobs;

namespace UnityEngine.Rendering.UnifiedRayTracing
{
	internal struct AsyncTerrainToMeshRequest
	{
		private JobHandle m_JobHandle;

		private ComputeTerrainMeshJob m_Job;

		public bool done => false;

		internal AsyncTerrainToMeshRequest(ComputeTerrainMeshJob job, JobHandle jobHandle)
		{
			m_JobHandle = default(JobHandle);
			m_Job = default(ComputeTerrainMeshJob);
		}

		public Mesh GetMesh()
		{
			return null;
		}

		public void WaitForCompletion()
		{
		}

		private List<int> TriangleIndicesWithoutHoles()
		{
			return null;
		}
	}
}
