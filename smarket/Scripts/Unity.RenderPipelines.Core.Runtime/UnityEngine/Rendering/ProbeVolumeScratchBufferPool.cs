using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace UnityEngine.Rendering
{
	internal class ProbeVolumeScratchBufferPool
	{
		[DebuggerDisplay("ChunkCount = {chunkCount} ElementCount = {pool.Count}")]
		private class ScratchBufferPool : IComparable<ScratchBufferPool>
		{
			public int chunkCount;

			public Stack<ProbeReferenceVolume.CellStreamingScratchBuffer> pool;

			public ScratchBufferPool(int chunkCount)
			{
			}

			private ScratchBufferPool()
			{
			}

			public int CompareTo(ScratchBufferPool other)
			{
				return 0;
			}
		}

		private int m_L0Size;

		private int m_L1Size;

		private int m_ValiditySize;

		private int m_ValidityLayerCount;

		private int m_L2Size;

		private int m_ProbeOcclusionSize;

		private int m_SkyOcclusionSize;

		private int m_SkyShadingDirectionSize;

		private int m_CurrentlyAllocatedChunkCount;

		private List<ScratchBufferPool> m_Pools;

		private Dictionary<int, ProbeReferenceVolume.CellStreamingScratchBufferLayout> m_Layouts;

		private static int s_ChunkCount;

		public int chunkSize { get; private set; }

		public int maxChunkCount { get; private set; }

		public int allocatedMemory => 0;

		public ProbeVolumeScratchBufferPool(ProbeVolumeBakingSet bakingSet, ProbeVolumeSHBands shBands)
		{
		}

		private ProbeReferenceVolume.CellStreamingScratchBufferLayout GetOrCreateScratchBufferLayout(int chunkCount)
		{
			return default(ProbeReferenceVolume.CellStreamingScratchBufferLayout);
		}

		private ProbeReferenceVolume.CellStreamingScratchBuffer CreateScratchBuffer(int chunkCount, bool allocateGraphicsBuffers)
		{
			return null;
		}

		public bool AllocateScratchBuffer(int chunkCount, out ProbeReferenceVolume.CellStreamingScratchBuffer scratchBuffer, out ProbeReferenceVolume.CellStreamingScratchBufferLayout layout, bool allocateGraphicsBuffers)
		{
			scratchBuffer = null;
			layout = default(ProbeReferenceVolume.CellStreamingScratchBufferLayout);
			return false;
		}

		public void ReleaseScratchBuffer(ProbeReferenceVolume.CellStreamingScratchBuffer scratchBuffer)
		{
		}

		public void Cleanup()
		{
		}
	}
}
