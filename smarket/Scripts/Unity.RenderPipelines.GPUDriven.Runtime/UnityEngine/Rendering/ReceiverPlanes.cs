using Unity.Collections;
using Unity.Jobs;

namespace UnityEngine.Rendering
{
	internal struct ReceiverPlanes
	{
		public NativeList<Plane> planes;

		public int lightFacingPlaneCount;

		private static bool IsSignBitSet(float x)
		{
			return false;
		}

		internal NativeArray<Plane> LightFacingFrustumPlaneSubArray()
		{
			return default(NativeArray<Plane>);
		}

		internal NativeArray<Plane> SilhouettePlaneSubArray()
		{
			return default(NativeArray<Plane>);
		}

		internal static ReceiverPlanes CreateEmptyForTesting(Allocator allocator)
		{
			return default(ReceiverPlanes);
		}

		internal void Dispose(JobHandle job)
		{
		}

		internal static ReceiverPlanes Create(in BatchCullingContext cc, Allocator allocator)
		{
			return default(ReceiverPlanes);
		}
	}
}
