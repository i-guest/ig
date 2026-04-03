using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

namespace UnityEngine.Rendering
{
	internal struct ReceiverSphereCuller
	{
		internal struct SplitInfo
		{
			public float4 receiverSphereLightSpace;

			public float cascadeBlendCullingFactor;
		}

		public NativeList<SplitInfo> splitInfos;

		public float3x3 worldToLightSpaceRotation;

		internal static ReceiverSphereCuller CreateEmptyForTesting(Allocator allocator)
		{
			return default(ReceiverSphereCuller);
		}

		internal void Dispose(JobHandle job)
		{
		}

		internal bool UseReceiverPlanes()
		{
			return false;
		}

		internal static ReceiverSphereCuller Create(in BatchCullingContext cc, Allocator allocator)
		{
			return default(ReceiverSphereCuller);
		}

		internal static float DistanceUntilCylinderFullyCrossesPlane(float3 cylinderCenter, float3 cylinderDirection, float cylinderRadius, Plane plane)
		{
			return 0f;
		}

		internal static uint ComputeSplitVisibilityMask(NativeArray<Plane> lightFacingFrustumPlanes, NativeArray<SplitInfo> splitInfos, float3x3 worldToLightSpaceRotation, in AABB bounds)
		{
			return 0u;
		}
	}
}
