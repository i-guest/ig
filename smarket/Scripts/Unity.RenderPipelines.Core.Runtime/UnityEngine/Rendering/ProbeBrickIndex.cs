using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.Collections;

namespace UnityEngine.Rendering
{
	internal class ProbeBrickIndex
	{
		[Serializable]
		[DebuggerDisplay("Brick [{position}, {subdivisionLevel}]")]
		public struct Brick : IEquatable<Brick>
		{
			public Vector3Int position;

			public int subdivisionLevel;

			internal Brick(Vector3Int position, int subdivisionLevel)
			{
				this.position = default(Vector3Int);
				this.subdivisionLevel = 0;
			}

			public bool Equals(Brick other)
			{
				return false;
			}

			public bool IntersectArea(Bounds boundInBricksToCheck)
			{
				return false;
			}
		}

		public struct IndirectionEntryUpdateInfo
		{
			public int firstChunkIndex;

			public int numberOfChunks;

			public int minSubdivInCell;

			public Vector3Int minValidBrickIndexForCellAtMaxRes;

			public Vector3Int maxValidBrickIndexForCellAtMaxResPlusOne;

			public Vector3Int entryPositionInBricksAtMaxRes;

			public bool hasOnlyBiggerBricks;
		}

		public struct CellIndexUpdateInfo
		{
			public IndirectionEntryUpdateInfo[] entriesInfo;

			public int GetNumberOfChunks()
			{
				return 0;
			}
		}

		internal const int kMaxSubdivisionLevels = 7;

		internal const int kIndexChunkSize = 243;

		internal const int kFailChunkIndex = -1;

		internal const int kEmptyIndex = -2;

		private BitArray m_IndexChunks;

		private BitArray m_IndexChunksCopyForChecks;

		private int m_ChunksCount;

		private int m_AvailableChunkCount;

		private ComputeBuffer m_PhysicalIndexBuffer;

		private NativeArray<int> m_PhysicalIndexBufferData;

		private ComputeBuffer m_DebugFragmentationBuffer;

		private int[] m_DebugFragmentationData;

		private bool m_NeedUpdateIndexComputeBuffer;

		private int m_UpdateMinIndex;

		private int m_UpdateMaxIndex;

		private Vector3Int m_CenterRS;

		internal int estimatedVMemCost { get; private set; }

		internal float fragmentationRate { get; private set; }

		internal ComputeBuffer GetDebugFragmentationBuffer()
		{
			return null;
		}

		private int SizeOfPhysicalIndexFromBudget(ProbeVolumeTextureMemoryBudget memoryBudget)
		{
			return 0;
		}

		internal ProbeBrickIndex(ProbeVolumeTextureMemoryBudget memoryBudget)
		{
		}

		public int GetRemainingChunkCount()
		{
			return 0;
		}

		internal void UploadIndexData()
		{
		}

		private void UpdateDebugData()
		{
		}

		internal void Clear()
		{
		}

		internal void GetRuntimeResources(ref ProbeReferenceVolume.RuntimeResources rr)
		{
		}

		internal void Cleanup()
		{
		}

		internal void ComputeFragmentationRate()
		{
		}

		private int MergeIndex(int index, int size)
		{
			return 0;
		}

		internal int GetNumberOfChunks(int brickCount)
		{
			return 0;
		}

		internal bool FindSlotsForEntries(ref IndirectionEntryUpdateInfo[] entriesInfo)
		{
			return false;
		}

		internal bool ReserveChunks(IndirectionEntryUpdateInfo[] entriesInfo, bool ignoreErrorLog)
		{
			return false;
		}

		internal static bool BrickOverlapEntry(Vector3Int brickMin, Vector3Int brickMax, Vector3Int entryMin, Vector3Int entryMax)
		{
			return false;
		}

		private static int LocationToIndex(int x, int y, int z, Vector3Int sizeOfValid)
		{
			return 0;
		}

		private void MarkBrickInPhysicalBuffer(in IndirectionEntryUpdateInfo entry, Vector3Int brickMin, Vector3Int brickMax, int brickSubdivLevel, int entrySubdivLevel, int idx)
		{
		}

		public void AddBricks(ProbeReferenceVolume.CellIndexInfo cellInfo, NativeArray<Brick> bricks, List<ProbeBrickPool.BrickChunkAlloc> allocations, int allocationSize, int poolWidth, int poolHeight)
		{
		}

		public void RemoveBricks(ProbeReferenceVolume.CellIndexInfo cellInfo)
		{
		}
	}
}
