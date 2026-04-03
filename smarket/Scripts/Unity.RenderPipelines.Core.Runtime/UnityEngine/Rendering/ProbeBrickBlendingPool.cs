using System.Collections.Generic;

namespace UnityEngine.Rendering
{
	internal class ProbeBrickBlendingPool
	{
		private static ComputeShader stateBlendShader;

		private static int scenarioBlendingKernel;

		private static readonly int _PoolDim_LerpFactor;

		private static readonly int _ChunkList;

		private static readonly int _State0_L0_L1Rx;

		private static readonly int _State0_L1G_L1Ry;

		private static readonly int _State0_L1B_L1Rz;

		private static readonly int _State0_L2_0;

		private static readonly int _State0_L2_1;

		private static readonly int _State0_L2_2;

		private static readonly int _State0_L2_3;

		private static readonly int _State0_ProbeOcclusion;

		private static readonly int _State1_L0_L1Rx;

		private static readonly int _State1_L1G_L1Ry;

		private static readonly int _State1_L1B_L1Rz;

		private static readonly int _State1_L2_0;

		private static readonly int _State1_L2_1;

		private static readonly int _State1_L2_2;

		private static readonly int _State1_L2_3;

		private static readonly int _State1_ProbeOcclusion;

		private Vector4[] m_ChunkList;

		private int m_MappedChunks;

		private ProbeBrickPool m_State0;

		private ProbeBrickPool m_State1;

		private ProbeVolumeTextureMemoryBudget m_MemoryBudget;

		private ProbeVolumeSHBands m_ShBands;

		private bool m_ProbeOcclusion;

		internal bool isAllocated => false;

		internal int estimatedVMemCost => 0;

		internal static void Initialize()
		{
		}

		internal int GetPoolWidth()
		{
			return 0;
		}

		internal int GetPoolHeight()
		{
			return 0;
		}

		internal int GetPoolDepth()
		{
			return 0;
		}

		internal ProbeBrickBlendingPool(ProbeVolumeBlendingTextureMemoryBudget memoryBudget, ProbeVolumeSHBands shBands, bool probeOcclusion)
		{
		}

		internal void AllocateResourcesIfNeeded()
		{
		}

		internal void Update(ProbeBrickPool.DataLocation source, List<ProbeBrickPool.BrickChunkAlloc> srcLocations, List<ProbeBrickPool.BrickChunkAlloc> dstLocations, int destStartIndex, ProbeVolumeSHBands bands, int state)
		{
		}

		internal void Update(CommandBuffer cmd, ProbeReferenceVolume.CellStreamingScratchBuffer dataBuffer, ProbeReferenceVolume.CellStreamingScratchBufferLayout layout, List<ProbeBrickPool.BrickChunkAlloc> dstLocations, ProbeVolumeSHBands bands, int state, Texture validityTexture, bool skyOcclusion, Texture skyOcclusionTexture, bool skyShadingDirections, Texture skyShadingDirectionsTexture, bool probeOcclusion)
		{
		}

		internal void PerformBlending(CommandBuffer cmd, float factor, ProbeBrickPool dstPool)
		{
		}

		internal void BlendChunks(ProbeReferenceVolume.Cell cell, ProbeBrickPool dstPool)
		{
		}

		internal void Clear()
		{
		}

		internal bool Allocate(int numberOfBrickChunks, List<ProbeBrickPool.BrickChunkAlloc> outAllocations)
		{
			return false;
		}

		internal void Deallocate(List<ProbeBrickPool.BrickChunkAlloc> allocations)
		{
		}

		internal void EnsureTextureValidity()
		{
		}

		internal void Cleanup()
		{
		}
	}
}
