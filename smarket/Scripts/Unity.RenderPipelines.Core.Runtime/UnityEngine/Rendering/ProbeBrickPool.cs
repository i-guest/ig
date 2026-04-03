using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering
{
	internal class ProbeBrickPool
	{
		[DebuggerDisplay("Chunk ({x}, {y}, {z})")]
		public struct BrickChunkAlloc
		{
			public int x;

			public int y;

			public int z;

			internal int flattenIndex(int sx, int sy)
			{
				return 0;
			}
		}

		public struct DataLocation
		{
			internal Texture TexL0_L1rx;

			internal Texture TexL1_G_ry;

			internal Texture TexL1_B_rz;

			internal Texture TexL2_0;

			internal Texture TexL2_1;

			internal Texture TexL2_2;

			internal Texture TexL2_3;

			internal Texture TexProbeOcclusion;

			internal Texture TexValidity;

			internal Texture TexSkyOcclusion;

			internal Texture TexSkyShadingDirectionIndices;

			internal int width;

			internal int height;

			internal int depth;

			internal void Cleanup()
			{
			}
		}

		internal static readonly int _Out_L0_L1Rx;

		internal static readonly int _Out_L1G_L1Ry;

		internal static readonly int _Out_L1B_L1Rz;

		internal static readonly int _Out_Shared;

		internal static readonly int _Out_ProbeOcclusion;

		internal static readonly int _Out_SkyOcclusionL0L1;

		internal static readonly int _Out_SkyShadingDirectionIndices;

		internal static readonly int _Out_L2_0;

		internal static readonly int _Out_L2_1;

		internal static readonly int _Out_L2_2;

		internal static readonly int _Out_L2_3;

		internal static readonly int _ProbeVolumeScratchBufferLayout;

		internal static readonly int _ProbeVolumeScratchBuffer;

		private const int kChunkSizeInBricks = 128;

		internal const int kBrickCellCount = 3;

		internal const int kBrickProbeCountPerDim = 4;

		internal const int kBrickProbeCountTotal = 64;

		internal const int kChunkProbeCountPerDim = 512;

		private const int kMaxPoolWidth = 2048;

		internal DataLocation m_Pool;

		private BrickChunkAlloc m_NextFreeChunk;

		private Stack<BrickChunkAlloc> m_FreeList;

		private int m_AvailableChunkCount;

		private ProbeVolumeSHBands m_SHBands;

		private bool m_ContainsValidity;

		private bool m_ContainsProbeOcclusion;

		private bool m_ContainsRenderingLayers;

		private bool m_ContainsSkyOcclusion;

		private bool m_ContainsSkyShadingDirection;

		private static ComputeShader s_DataUploadCS;

		private static int s_DataUploadKernel;

		private static ComputeShader s_DataUploadL2CS;

		private static int s_DataUploadL2Kernel;

		private static LocalKeyword s_DataUpload_Shared;

		private static LocalKeyword s_DataUpload_ProbeOcclusion;

		private static LocalKeyword s_DataUpload_SkyOcclusion;

		private static LocalKeyword s_DataUpload_SkyShadingDirection;

		internal int estimatedVMemCost { get; private set; }

		internal static int DivRoundUp(int x, int y)
		{
			return 0;
		}

		internal static void Initialize()
		{
		}

		internal Texture GetValidityTexture()
		{
			return null;
		}

		internal Texture GetSkyOcclusionTexture()
		{
			return null;
		}

		internal Texture GetSkyShadingDirectionIndicesTexture()
		{
			return null;
		}

		internal Texture GetProbeOcclusionTexture()
		{
			return null;
		}

		internal ProbeBrickPool(ProbeVolumeTextureMemoryBudget memoryBudget, ProbeVolumeSHBands shBands, bool allocateValidityData = false, bool allocateRenderingLayerData = false, bool allocateSkyOcclusion = false, bool allocateSkyShadingData = false, bool allocateProbeOcclusionData = false)
		{
		}

		internal void AllocatePool(int width, int height, int depth)
		{
		}

		public int GetRemainingChunkCount()
		{
			return 0;
		}

		internal void EnsureTextureValidity()
		{
		}

		internal bool EnsureTextureValidity(bool renderingLayers, bool skyOcclusion, bool skyDirection, bool probeOcclusion)
		{
			return false;
		}

		internal static int GetChunkSizeInBrickCount()
		{
			return 0;
		}

		internal static int GetChunkSizeInProbeCount()
		{
			return 0;
		}

		internal int GetPoolWidth()
		{
			return 0;
		}

		internal int GetPoolHeight()
		{
			return 0;
		}

		internal Vector3Int GetPoolDimensions()
		{
			return default(Vector3Int);
		}

		internal void GetRuntimeResources(ref ProbeReferenceVolume.RuntimeResources rr)
		{
		}

		internal void Clear()
		{
		}

		internal static int GetChunkCount(int brickCount)
		{
			return 0;
		}

		internal bool Allocate(int numberOfBrickChunks, List<BrickChunkAlloc> outAllocations, bool ignoreErrorLog)
		{
			return false;
		}

		internal void Deallocate(List<BrickChunkAlloc> allocations)
		{
		}

		internal void Update(DataLocation source, List<BrickChunkAlloc> srcLocations, List<BrickChunkAlloc> dstLocations, int destStartIndex, ProbeVolumeSHBands bands)
		{
		}

		internal void Update(CommandBuffer cmd, ProbeReferenceVolume.CellStreamingScratchBuffer dataBuffer, ProbeReferenceVolume.CellStreamingScratchBufferLayout layout, List<BrickChunkAlloc> dstLocations, bool updateSharedData, Texture validityTexture, ProbeVolumeSHBands bands, bool skyOcclusion, Texture skyOcclusionTexture, bool skyShadingDirections, Texture skyShadingDirectionsTexture, bool probeOcclusion)
		{
		}

		internal void UpdateValidity(DataLocation source, List<BrickChunkAlloc> srcLocations, List<BrickChunkAlloc> dstLocations, int destStartIndex)
		{
		}

		internal static Vector3Int ProbeCountToDataLocSize(int numProbes)
		{
			return default(Vector3Int);
		}

		private static int EstimateMemoryCost(int width, int height, int depth, GraphicsFormat format)
		{
			return 0;
		}

		internal static int EstimateMemoryCostForBlending(ProbeVolumeTextureMemoryBudget memoryBudget, bool compressed, ProbeVolumeSHBands bands)
		{
			return 0;
		}

		public static Texture CreateDataTexture(int width, int height, int depth, GraphicsFormat format, string name, bool allocateRendertexture, ref int allocatedBytes)
		{
			return null;
		}

		public static DataLocation CreateDataLocation(int numProbes, bool compressed, ProbeVolumeSHBands bands, string name, bool allocateRendertexture, bool allocateValidityData, bool allocateRenderingLayers, bool allocateSkyOcclusionData, bool allocateSkyShadingDirectionData, bool allocateProbeOcclusionData, out int allocatedBytes)
		{
			allocatedBytes = default(int);
			return default(DataLocation);
		}

		private static void DerivePoolSizeFromBudget(ProbeVolumeTextureMemoryBudget memoryBudget, out int width, out int height, out int depth)
		{
			width = default(int);
			height = default(int);
			depth = default(int);
		}

		internal void Cleanup()
		{
		}
	}
}
