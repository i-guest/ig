using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

namespace UnityEngine.Rendering
{
	internal struct FrustumPlaneCuller
	{
		internal struct PlanePacket4
		{
			public float4 nx;

			public float4 ny;

			public float4 nz;

			public float4 d;

			public float4 nxAbs;

			public float4 nyAbs;

			public float4 nzAbs;

			public PlanePacket4(NativeArray<Plane> planes, int offset, int limit)
			{
				nx = default(float4);
				ny = default(float4);
				nz = default(float4);
				d = default(float4);
				nxAbs = default(float4);
				nyAbs = default(float4);
				nzAbs = default(float4);
			}
		}

		internal struct SplitInfo
		{
			public int packetCount;
		}

		public NativeList<PlanePacket4> planePackets;

		public NativeList<SplitInfo> splitInfos;

		internal void Dispose(JobHandle job)
		{
		}

		internal static FrustumPlaneCuller Create(in BatchCullingContext cc, NativeArray<Plane> receiverPlanes, in ReceiverSphereCuller receiverSphereCuller, Allocator allocator)
		{
			return default(FrustumPlaneCuller);
		}

		internal static uint ComputeSplitVisibilityMask(NativeArray<PlanePacket4> planePackets, NativeArray<SplitInfo> splitInfos, in AABB bounds)
		{
			return 0u;
		}
	}
}
