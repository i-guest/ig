using System;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Mathematics;

namespace UnityEngine.Rendering
{
	[BurstCompile]
	internal struct CullingJob : IJobParallelFor
	{
		private enum CrossFadeType
		{
			kDisabled = 0,
			kCrossFadeOut = 1,
			kCrossFadeIn = 2,
			kVisible = 3
		}

		public const int k_BatchSize = 32;

		public const uint k_MeshLodCrossfadeActive = 64u;

		public const uint k_MeshLodCrossfadeSignBit = 128u;

		public const uint k_MeshLodCrossfadeBits = 192u;

		public const uint k_LODFadeOff = 255u;

		public const uint k_LODFadeZeroPacked = 127u;

		public const uint k_LODFadeIsSpeedTree = 256u;

		private const uint k_InvalidCrossFadeAndLevel = 4294967295u;

		private const uint k_VisibilityMaskNotVisible = 0u;

		private const float k_SmallMeshTransitionWidth = 0.1f;

		[ReadOnly]
		public BinningConfig binningConfig;

		[ReadOnly]
		public BatchCullingViewType viewType;

		[ReadOnly]
		public float3 cameraPosition;

		[ReadOnly]
		public float sqrMeshLodSelectionConstant;

		[ReadOnly]
		public float sqrScreenRelativeMetric;

		[ReadOnly]
		public float minScreenRelativeHeight;

		[ReadOnly]
		public bool isOrtho;

		[ReadOnly]
		public bool cullLightmappedShadowCasters;

		[ReadOnly]
		public int maxLOD;

		[ReadOnly]
		public uint cullingLayerMask;

		[ReadOnly]
		public ulong sceneCullingMask;

		[ReadOnly]
		public bool animateCrossFades;

		[ReadOnly]
		public NativeArray<FrustumPlaneCuller.PlanePacket4> frustumPlanePackets;

		[ReadOnly]
		public NativeArray<FrustumPlaneCuller.SplitInfo> frustumSplitInfos;

		[ReadOnly]
		public NativeArray<Plane> lightFacingFrustumPlanes;

		[ReadOnly]
		public NativeArray<ReceiverSphereCuller.SplitInfo> receiverSplitInfos;

		public float3x3 worldToLightSpaceRotation;

		[ReadOnly]
		public CPUInstanceData.ReadOnly instanceData;

		[ReadOnly]
		public CPUSharedInstanceData.ReadOnly sharedInstanceData;

		[NativeDisableContainerSafetyRestriction]
		[NoAlias]
		[ReadOnly]
		public NativeList<LODGroupCullingData> lodGroupCullingData;

		[NativeDisableUnsafePtrRestriction]
		[ReadOnly]
		public IntPtr occlusionBuffer;

		[NativeDisableContainerSafetyRestriction]
		public CPUPerCameraInstanceData.PerCameraInstanceDataArrays cameraInstanceData;

		[NativeDisableParallelForRestriction]
		[WriteOnly]
		public NativeArray<byte> rendererVisibilityMasks;

		[NativeDisableParallelForRestriction]
		[WriteOnly]
		public NativeArray<byte> rendererMeshLodSettings;

		[NativeDisableParallelForRestriction]
		[WriteOnly]
		public NativeArray<byte> rendererCrossFadeValues;

		private static uint PackFloatToUint8(float percent)
		{
			return 0u;
		}

		private uint CalculateLODVisibility(int instanceIndex, int sharedInstanceIndex, InstanceFlags instanceFlags)
		{
			return 0u;
		}

		private uint CalculateVisibilityMask(int instanceIndex, int sharedInstanceIndex, InstanceFlags instanceFlags)
		{
			return 0u;
		}

		private uint ComputeMeshLODLevel(int instanceIndex, int sharedInstanceIndex)
		{
			return 0u;
		}

		private uint ComputeMeshLODCrossfade(int instanceIndex, ref uint meshLodLevel)
		{
			return 0u;
		}

		private void EnforcePreviousFrameMeshLOD(int instanceIndex, ref uint meshLodLevel)
		{
		}

		public void Execute(int instanceIndex)
		{
		}
	}
}
