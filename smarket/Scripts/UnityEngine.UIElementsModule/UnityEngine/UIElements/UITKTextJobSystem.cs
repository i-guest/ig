using System.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Jobs;
using Unity.Profiling;
using UnityEngine.Pool;
using UnityEngine.TextCore.LowLevel;
using UnityEngine.TextCore.Text;
using UnityEngine.UIElements.UIR;

namespace UnityEngine.UIElements
{
	internal class UITKTextJobSystem
	{
		private class ManagedJobData
		{
			public TextElement visualElement;

			public MeshGenerationNode node;

			public List<Material> materials;

			public List<GlyphRenderMode> renderModes;

			public List<NativeSlice<Vertex>> vertices;

			public List<NativeSlice<ushort>> indices;

			public bool prepareSuccess;

			public void Release()
			{
			}
		}

		private struct PrepareTextJobData : IJobParallelFor
		{
			public GCHandle managedJobDataHandle;

			public void Execute(int index)
			{
			}
		}

		private struct GenerateTextJobData : IJobParallelFor
		{
			public GCHandle managedJobDataHandle;

			[ReadOnly]
			public TempMeshAllocator alloc;

			public void Execute(int index)
			{
			}
		}

		private static readonly ProfilerMarker k_ExecuteMarker;

		private static readonly ProfilerMarker k_UpdateMainThreadMarker;

		private static readonly ProfilerMarker k_PrepareMainThreadMarker;

		private static readonly ProfilerMarker k_PrepareJobifiedMarker;

		private GCHandle textJobDatasHandle;

		private List<ManagedJobData> textJobDatas;

		private bool hasPendingTextWork;

		private static UnityEngine.Pool.ObjectPool<ManagedJobData> s_JobDataPool;

		private static UnityEngine.Pool.ObjectPool<List<Material>> s_MaterialsPool;

		private static UnityEngine.Pool.ObjectPool<List<GlyphRenderMode>> s_RenderModesPool;

		private static UnityEngine.Pool.ObjectPool<List<NativeSlice<Vertex>>> s_VerticesPool;

		private static UnityEngine.Pool.ObjectPool<List<NativeSlice<ushort>>> s_IndicesPool;

		internal MeshGenerationCallback m_PrepareTextJobifiedCallback;

		internal MeshGenerationCallback m_GenerateTextJobifiedCallback;

		internal MeshGenerationCallback m_AddDrawEntriesCallback;

		private static void OnGetManagedJob(ManagedJobData managedJobData)
		{
		}

		internal void GenerateText(MeshGenerationContext mgc, TextElement textElement)
		{
		}

		internal void PrepareTextJobified(MeshGenerationContext mgc, object _)
		{
		}

		private void GenerateTextJobified(MeshGenerationContext mgc, object _)
		{
		}

		private static void ConvertMeshInfoToUIRVertex(MeshInfo[] meshInfos, TempMeshAllocator alloc, TextElement visualElement, ref List<Material> materials, ref List<NativeSlice<Vertex>> verticesArray, ref List<NativeSlice<ushort>> indicesArray, ref List<GlyphRenderMode> renderModes)
		{
		}

		private void AddDrawEntries(MeshGenerationContext mgc, object _)
		{
		}
	}
}
