using System;
using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace UnityEngine.UIElements.Layout
{
	internal struct LayoutDataStore : IDisposable
	{
		private struct Chunk
		{
			[NativeDisableUnsafePtrRestriction]
			public unsafe byte* Buffer;
		}

		internal struct ComponentDataStore : IDisposable
		{
			public readonly MemoryLabel MemoryLabel;

			public int Size;

			public int ComponentCountPerChunk;

			public int ChunkCount;

			[NativeDisableUnsafePtrRestriction]
			private unsafe Chunk* m_Chunks;

			public unsafe ComponentDataStore(int size, MemoryLabel allocLabel)
			{
				MemoryLabel = default(MemoryLabel);
				Size = 0;
				ComponentCountPerChunk = 0;
				ChunkCount = 0;
				m_Chunks = null;
			}

			public void Dispose()
			{
			}

			public unsafe byte* GetComponentDataPtr(int index)
			{
				return null;
			}

			public void ResizeCapacity(int capacity)
			{
			}
		}

		private struct Data
		{
			public int Capacity;

			public int NextFreeIndex;

			public int ComponentCount;

			[NativeDisableUnsafePtrRestriction]
			public unsafe int* Versions;

			[NativeDisableUnsafePtrRestriction]
			public unsafe ComponentDataStore* Components;
		}

		private const int k_ChunkSize = 32768;

		private readonly MemoryLabel m_MemoryLabel;

		[NativeDisableUnsafePtrRestriction]
		private unsafe Data* m_Data;

		public unsafe LayoutDataStore(ComponentType[] components, ReadOnlySpan<MemoryLabel> labels, int initialCapacity, Allocator allocator)
		{
			m_MemoryLabel = default(MemoryLabel);
			m_Data = null;
		}

		public void Dispose()
		{
		}

		public bool Exists(in LayoutHandle handle)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal unsafe readonly void* GetComponentDataPtr(int index, int componentIndex)
		{
			return null;
		}

		private unsafe LayoutHandle Allocate(byte** data, int count)
		{
			return default(LayoutHandle);
		}

		public void Free(in LayoutHandle handle)
		{
		}

		private unsafe static void SetNextFreeIndex(ComponentDataStore* ptr, int index, int value)
		{
		}

		private unsafe static int GetNextFreeIndex(ComponentDataStore* ptr, int index)
		{
			return 0;
		}

		private void IncreaseCapacity()
		{
		}

		private void ResizeCapacity(int capacity)
		{
		}

		private unsafe static void* ResizeArray(void* fromPtr, long fromCount, long toCount, long size, int align, MemoryLabel label)
		{
			return null;
		}

		public LayoutHandle Allocate<T0>(in T0 component0) where T0 : struct
		{
			return default(LayoutHandle);
		}

		public LayoutHandle Allocate<T0, T1, T2, T3>(in T0 component0, in T1 component1, in T2 component2, in T3 component3) where T0 : struct where T1 : struct where T2 : struct where T3 : struct
		{
			return default(LayoutHandle);
		}
	}
}
