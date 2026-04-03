using System;
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
	internal class ATGTextJobSystem
	{
		private class ManagedJobData
		{
			public TextElement textElement;

			public MeshGenerationNode node;

			public NativeTextInfo textInfo;

			public bool success;

			public List<Texture2D> atlases;

			public List<float> sdfScales;

			public List<NativeSlice<Vertex>> vertices;

			public List<NativeSlice<ushort>> indices;

			public List<GlyphRenderMode> renderModes;

			public List<List<List<int>>> textElementIndicesByMesh;

			public List<bool> hasMultipleColorsByMesh;

			public Dictionary<int, HashSet<uint>> missingGlyphsPerFontAsset;

			public bool hasMissingGlyphs;

			public void Clear()
			{
			}
		}

		private struct PrepareShapingJob : IJobFor
		{
			public GCHandle managedJobDataHandle;

			public void Execute(int index)
			{
			}
		}

		private struct GenerateTextJobData : IJobFor
		{
			public GCHandle managedJobDataHandle;

			[ReadOnly]
			public TempMeshAllocator alloc;

			public void Execute(int index)
			{
			}
		}

		private struct ConvertToUIRVertexJobData : IJobFor
		{
			public GCHandle managedJobDataHandle;

			[ReadOnly]
			public TempMeshAllocator alloc;

			public void Execute(int index)
			{
			}
		}

		private GCHandle textJobDatasHandle;

		private List<ManagedJobData> textJobDatas;

		private bool hasPendingTextWork;

		private static readonly UnityEngine.Pool.ObjectPool<ManagedJobData> s_JobDataPool;

		private static UnityEngine.Pool.ObjectPool<Dictionary<int, HashSet<uint>>> s_AggregatedMissingGlyphsPool;

		internal MeshGenerationCallback m_GenerateTextJobifiedCallback;

		internal MeshGenerationCallback m_PopulateGlyphsCallback;

		internal MeshGenerationCallback m_AddDrawEntriesCallback;

		private static readonly ProfilerMarker k_GenerateTextMarker;

		private static readonly ProfilerMarker k_ATGTextJobMarker;

		private static readonly ProfilerMarker k_PrepareShapingMarker;

		private static readonly bool k_IsMultiThreaded;

		private List<TextElement> m_PrepareShapingDataList;

		private static List<uint> s_GlyphsToAddBuffer;

		private static bool PrepareTextElementForJobsOnMainThread(TextElement textElement)
		{
			return false;
		}

		internal void PrepareShapingBeforeLayout(BaseVisualElementPanel panel)
		{
		}

		public void GenerateText(MeshGenerationContext mgc, TextElement textElement)
		{
		}

		private void GenerateTextJobified(MeshGenerationContext mgc, object _)
		{
		}

		private void PopulateGlyphs(MeshGenerationContext mgc, object _)
		{
		}

		private void AddDrawEntries(MeshGenerationContext mgc, object _)
		{
		}

		private static void ConvertMeshInfoToUIRVertex(Span<ATGMeshInfo> meshInfos, TempMeshAllocator alloc, TextElement visualElement, List<List<List<int>>> textElementIndicesByMesh, List<bool> hasMultipleColorsByMesh, ref List<Texture2D> atlases, ref List<NativeSlice<Vertex>> verticesArray, ref List<NativeSlice<ushort>> indicesArray, ref List<GlyphRenderMode> renderModes, ref List<float> sdfScales)
		{
		}
	}
}
