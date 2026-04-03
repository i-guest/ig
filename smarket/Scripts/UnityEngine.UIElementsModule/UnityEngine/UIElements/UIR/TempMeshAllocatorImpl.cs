using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.Collections;

namespace UnityEngine.UIElements.UIR
{
	internal class TempMeshAllocatorImpl : IDisposable
	{
		private struct ThreadData
		{
			public List<IntPtr> allocations;
		}

		private GCHandle m_GCHandle;

		private ThreadData[] m_ThreadData;

		private TempAllocator<Vertex> m_VertexPool;

		private TempAllocator<ushort> m_IndexPool;

		protected bool disposed { get; private set; }

		public void CreateNativeHandle(out TempMeshAllocator allocator)
		{
			allocator = default(TempMeshAllocator);
		}

		private NativeSlice<T> Allocate<T>(int count, int alignment) where T : struct
		{
			return default(NativeSlice<T>);
		}

		public void AllocateTempMesh(int vertexCount, int indexCount, out NativeSlice<Vertex> vertices, out NativeSlice<ushort> indices)
		{
			vertices = default(NativeSlice<Vertex>);
			indices = default(NativeSlice<ushort>);
		}

		public void Clear()
		{
		}

		public void Dispose()
		{
		}

		protected void Dispose(bool disposing)
		{
		}
	}
}
