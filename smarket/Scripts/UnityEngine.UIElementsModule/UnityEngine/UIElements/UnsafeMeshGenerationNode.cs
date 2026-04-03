using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Collections;
using UnityEngine.UIElements.UIR;

namespace UnityEngine.UIElements
{
	internal struct UnsafeMeshGenerationNode
	{
		private GCHandle m_Handle;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private MeshGenerationNodeImpl GetManaged()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void Create(GCHandle handle, out UnsafeMeshGenerationNode node)
		{
			node = default(UnsafeMeshGenerationNode);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void DrawMesh(NativeSlice<Vertex> vertices, NativeSlice<ushort> indices, Texture texture = null)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void DrawMeshInternal(NativeSlice<Vertex> vertices, NativeSlice<ushort> indices, Texture texture = null, TextureOptions textureOptions = TextureOptions.None)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void DrawGradientsInternal(NativeSlice<Vertex> vertices, NativeSlice<ushort> indices, VectorImage gradientsOwner)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal Entry GetParentEntry()
		{
			return null;
		}
	}
}
