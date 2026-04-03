using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Collections;
using UnityEngine.UIElements.UIR;

namespace UnityEngine.UIElements
{
	internal class MeshGenerationNodeImpl : IDisposable
	{
		private GCHandle m_SelfHandle;

		private Entry m_ParentEntry;

		private EntryRecorder m_EntryRecorder;

		protected bool disposed { get; private set; }

		public void Init(Entry parentEntry, EntryRecorder entryRecorder, bool safe)
		{
		}

		public void Reset()
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void GetNode(out MeshGenerationNode node)
		{
			node = default(MeshGenerationNode);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void GetUnsafeNode(out UnsafeMeshGenerationNode node)
		{
			node = default(UnsafeMeshGenerationNode);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Entry GetParentEntry()
		{
			return null;
		}

		public void DrawMesh(NativeSlice<Vertex> vertices, NativeSlice<ushort> indices, Texture texture = null, TextureOptions textureOptions = TextureOptions.None)
		{
		}

		public void DrawGradients(NativeSlice<Vertex> vertices, NativeSlice<ushort> indices, VectorImage gradientsOwner)
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
