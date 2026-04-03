namespace UnityEngine.Rendering
{
	internal class ProbeGlobalIndirection
	{
		internal struct IndexMetaData
		{
			private static uint[] s_PackedValues;

			internal Vector3Int minLocalIdx;

			internal Vector3Int maxLocalIdxPlusOne;

			internal int firstChunkIndex;

			internal int minSubdiv;

			internal void Pack(out uint[] vals)
			{
				vals = null;
			}
		}

		private const int kUintPerEntry = 3;

		internal const int kEntryMaxSubdivLevel = 3;

		private ComputeBuffer m_IndexOfIndicesBuffer;

		private uint[] m_IndexOfIndicesData;

		private int m_CellSizeInMinBricks;

		private Vector3Int m_EntriesCount;

		private Vector3Int m_EntryMin;

		private Vector3Int m_EntryMax;

		private bool m_NeedUpdateComputeBuffer;

		internal int estimatedVMemCost { get; private set; }

		private int entrySizeInBricks => 0;

		internal int entriesPerCellDimension => 0;

		internal void GetMinMaxEntry(out Vector3Int minEntry, out Vector3Int maxEntry)
		{
			minEntry = default(Vector3Int);
			maxEntry = default(Vector3Int);
		}

		internal Vector3Int GetGlobalIndirectionDimension()
		{
			return default(Vector3Int);
		}

		internal Vector3Int GetGlobalIndirectionMinEntry()
		{
			return default(Vector3Int);
		}

		private int GetFlatIndex(Vector3Int normalizedPos)
		{
			return 0;
		}

		internal ProbeGlobalIndirection(Vector3Int cellMin, Vector3Int cellMax, int cellSizeInMinBricks)
		{
		}

		internal int GetFlatIdxForEntry(Vector3Int entryPosition)
		{
			return 0;
		}

		internal int[] GetFlatIndicesForCell(Vector3Int cellPosition)
		{
			return null;
		}

		internal void UpdateCell(ProbeReferenceVolume.CellIndexInfo cellInfo)
		{
		}

		internal void MarkEntriesAsUnloaded(int[] entriesFlatIndices)
		{
		}

		internal void PushComputeData()
		{
		}

		internal void GetRuntimeResources(ref ProbeReferenceVolume.RuntimeResources rr)
		{
		}

		internal void Cleanup()
		{
		}
	}
}
