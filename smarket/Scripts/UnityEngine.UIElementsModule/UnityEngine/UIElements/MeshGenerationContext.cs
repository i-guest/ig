using System;
using Unity.Collections;
using Unity.Jobs;
using Unity.Profiling;
using UnityEngine.UIElements.UIR;

namespace UnityEngine.UIElements
{
	public class MeshGenerationContext
	{
		[Flags]
		internal enum MeshFlags
		{
			None = 0,
			SkipDynamicAtlas = 2,
			IsUsingVectorImageGradients = 4,
			SliceTiled = 8
		}

		private Painter2D m_Painter2D;

		private MeshWriteDataPool m_MeshWriteDataPool;

		private TempMeshAllocatorImpl m_Allocator;

		private MeshGenerationDeferrer m_MeshGenerationDeferrer;

		private MeshGenerationNodeManager m_MeshGenerationNodeManager;

		private static readonly ProfilerMarker k_AllocateMarker;

		private static readonly ProfilerMarker k_DrawVectorImageMarker;

		public VisualElement visualElement { get; private set; }

		internal RenderData renderData { get; private set; }

		public Painter2D painter2D => null;

		internal bool hasPainter2D => false;

		internal IMeshGenerator meshGenerator { get; set; }

		internal EntryRecorder entryRecorder { get; private set; }

		internal Entry parentEntry { get; private set; }

		internal bool disposed { get; private set; }

		internal MeshGenerationContext(MeshWriteDataPool meshWriteDataPool, EntryRecorder entryRecorder, TempMeshAllocatorImpl allocator, MeshGenerationDeferrer meshGenerationDeferrer, MeshGenerationNodeManager meshGenerationNodeManager)
		{
		}

		public void AllocateTempMesh(int vertexCount, int indexCount, out NativeSlice<Vertex> vertices, out NativeSlice<ushort> indices)
		{
			vertices = default(NativeSlice<Vertex>);
			indices = default(NativeSlice<ushort>);
		}

		public void GetTempMeshAllocator(out TempMeshAllocator allocator)
		{
			allocator = default(TempMeshAllocator);
		}

		public void InsertMeshGenerationNode(out MeshGenerationNode node)
		{
			node = default(MeshGenerationNode);
		}

		internal void InsertUnsafeMeshGenerationNode(out UnsafeMeshGenerationNode node)
		{
			node = default(UnsafeMeshGenerationNode);
		}

		public void AddMeshGenerationJob(JobHandle jobHandle)
		{
		}

		internal void AddMeshGenerationCallback(MeshGenerationCallback callback, object userData, MeshGenerationCallbackType callbackType, bool isJobDependent)
		{
		}

		internal void Begin(Entry parentEntry, VisualElement ve, RenderData renderData)
		{
		}

		internal void End()
		{
		}

		internal void Dispose()
		{
		}

		private void Dispose(bool disposing)
		{
		}
	}
}
