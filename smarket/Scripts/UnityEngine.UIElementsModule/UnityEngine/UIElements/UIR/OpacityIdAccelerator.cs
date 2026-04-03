using System;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;

namespace UnityEngine.UIElements.UIR
{
	internal class OpacityIdAccelerator : IDisposable
	{
		private struct OpacityIdUpdateJob : IJobParallelFor
		{
			[NativeDisableContainerSafetyRestriction]
			public NativeSlice<Vertex> oldVerts;

			[NativeDisableContainerSafetyRestriction]
			public NativeSlice<Vertex> newVerts;

			public Color32 opacityData;

			public void Execute(int i)
			{
			}
		}

		private const int k_VerticesPerBatch = 128;

		private const int k_JobLimit = 256;

		private static readonly MemoryLabel k_MemoryLabel;

		private NativeArray<JobHandle> m_Jobs;

		private int m_NextJobIndex;

		protected bool disposed { get; private set; }

		public void CreateJob(NativeSlice<Vertex> oldVerts, NativeSlice<Vertex> newVerts, Color32 opacityData, int vertexCount)
		{
		}

		public void CompleteJobs()
		{
		}

		public void Dispose()
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}
	}
}
