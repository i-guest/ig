using Unity.Jobs;

namespace UnityEngine.Rendering
{
	internal struct IndirectBufferContext
	{
		public enum BufferState
		{
			Pending = 0,
			Zeroed = 1,
			NoOcclusionTest = 2,
			AllInstancesOcclusionTested = 3,
			OccludedInstancesReTested = 4
		}

		public JobHandle cullingJobHandle;

		public BufferState bufferState;

		public int occluderVersion;

		public int subviewMask;

		public IndirectBufferContext(JobHandle cullingJobHandle)
		{
			this.cullingJobHandle = default(JobHandle);
			bufferState = default(BufferState);
			occluderVersion = 0;
			subviewMask = 0;
		}

		public bool Matches(BufferState bufferState, int occluderVersion, int subviewMask)
		{
			return false;
		}
	}
}
