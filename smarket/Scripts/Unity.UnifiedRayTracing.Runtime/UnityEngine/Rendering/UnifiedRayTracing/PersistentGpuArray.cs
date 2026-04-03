using System;
using System.Collections;
using Unity.Collections;

namespace UnityEngine.Rendering.UnifiedRayTracing
{
	internal sealed class PersistentGpuArray<Tstruct> : IDisposable where Tstruct : struct
	{
		private BlockAllocator m_SlotAllocator;

		private ComputeBuffer m_GpuBuffer;

		private NativeArray<Tstruct> m_CpuList;

		private BitArray m_Updates;

		private bool m_gpuBufferDirty;

		private int m_ElementCount;

		public int elementCount => 0;

		public PersistentGpuArray(int initialSize)
		{
		}

		public void Dispose()
		{
		}

		public BlockAllocator.Allocation Add(Tstruct element)
		{
			return default(BlockAllocator.Allocation);
		}

		public BlockAllocator.Allocation[] Add(int elementCount)
		{
			return null;
		}

		public void Remove(BlockAllocator.Allocation allocation)
		{
		}

		public void Clear()
		{
		}

		public void Set(BlockAllocator.Allocation allocation, Tstruct element)
		{
		}

		public Tstruct Get(BlockAllocator.Allocation allocation)
		{
			return default(Tstruct);
		}

		public void ModifyForEach(Func<Tstruct, Tstruct> lambda)
		{
		}

		public ComputeBuffer GetGpuBuffer(CommandBuffer cmd)
		{
			return null;
		}

		private void Grow()
		{
		}
	}
}
