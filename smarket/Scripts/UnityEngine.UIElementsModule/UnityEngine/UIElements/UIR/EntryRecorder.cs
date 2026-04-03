using System;
using System.Runtime.CompilerServices;
using Unity.Collections;

namespace UnityEngine.UIElements.UIR
{
	internal class EntryRecorder
	{
		private EntryPool m_EntryPool;

		public EntryRecorder(EntryPool entryPool)
		{
		}

		public void DrawMesh(Entry parentEntry, NativeSlice<Vertex> vertices, NativeSlice<ushort> indices, Texture texture, TextureOptions textureOptions = TextureOptions.None)
		{
		}

		public void DrawMesh(Entry parentEntry, NativeSlice<Vertex> vertices, NativeSlice<ushort> indices, TextureId textureId, bool isPremultiplied = false)
		{
		}

		public void DrawRasterText(Entry parentEntry, NativeSlice<Vertex> vertices, NativeSlice<ushort> indices, Texture texture, bool multiChannel)
		{
		}

		public void DrawSdfText(Entry parentEntry, NativeSlice<Vertex> vertices, NativeSlice<ushort> indices, Texture texture, float scale, float sharpness)
		{
		}

		public void DrawGradients(Entry parentEntry, NativeSlice<Vertex> vertices, NativeSlice<ushort> indices, VectorImage gradientsOwner)
		{
		}

		public void DrawImmediate(Entry parentEntry, Action callback, bool cullingEnabled)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void DrawChildren(Entry parentEntry)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void BeginStencilMask(Entry parentEntry)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void EndStencilMask(Entry parentEntry)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void PopStencilMask(Entry parentEntry)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void PushClippingRect(Entry parentEntry)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void PopClippingRect(Entry parentEntry)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void PushScissors(Entry parentEntry)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void PopScissors(Entry parentEntry)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void PushGroupMatrix(Entry parentEntry)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void PopGroupMatrix(Entry parentEntry)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void PushDefaultMaterial(Entry parentEntry, MaterialDefinition matDef)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void PopDefaultMaterial(Entry parentEntry)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void CutRenderChain(Entry parentEntry)
		{
		}

		public Entry InsertPlaceholder(Entry parentEntry)
		{
			return null;
		}

		private static void AppendMeshEntry(Entry parentEntry, Entry entry)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void Append(Entry parentEntry, Entry entry)
		{
		}
	}
}
