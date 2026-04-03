using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace UnityEngine.UIElements
{
	[NativeContainerIsReadOnly]
	[NativeContainer]
	public struct TempMeshAllocator
	{
		private GCHandle m_Handle;

		internal static void Create(GCHandle handle, out TempMeshAllocator allocator)
		{
			allocator = default(TempMeshAllocator);
		}

		public void AllocateTempMesh(int vertexCount, int indexCount, out NativeSlice<Vertex> vertices, out NativeSlice<ushort> indices)
		{
			vertices = default(NativeSlice<Vertex>);
			indices = default(NativeSlice<ushort>);
		}
	}
}
