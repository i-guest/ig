using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Collections;

namespace UnityEngine.UIElements.UIR
{
	internal class EntryProcessor
	{
		private struct MaskMesh
		{
			public NativeSlice<Vertex> vertices;

			public NativeSlice<ushort> indices;

			public int indexOffset;
		}

		private EntryPreProcessor m_PreProcessor;

		private RenderTreeManager m_RenderTreeManager;

		private RenderData m_CurrentRenderData;

		private int m_MaskDepth;

		private int m_MaskDepthPopped;

		private int m_MaskDepthPushed;

		private int m_StencilRef;

		private int m_StencilRefPopped;

		private int m_StencilRefPushed;

		private BMPAlloc m_ClipRectId;

		private BMPAlloc m_ClipRectIdPopped;

		private BMPAlloc m_ClipRectIdPushed;

		private bool m_IsDrawingMask;

		private Stack<MaskMesh> m_MaskMeshes;

		private bool m_VertexDataComputed;

		private Matrix4x4 m_Transform;

		private Color32 m_TransformData;

		private Color32 m_OpacityData;

		private Color32 m_TextCoreSettingsPage;

		private MeshHandle m_Mesh;

		private NativeSlice<Vertex> m_Verts;

		private NativeSlice<ushort> m_Indices;

		private ushort m_IndexOffset;

		private int m_AllocVertexCount;

		private int m_AllocIndex;

		private int m_VertsFilled;

		private int m_IndicesFilled;

		private VertexFlags m_RenderType;

		private bool m_RemapUVs;

		private Rect m_AtlasRect;

		private int m_GradientSettingIndexOffset;

		private bool m_IsTail;

		private RenderChainCommand m_FirstCommand;

		private RenderChainCommand m_LastCommand;

		public RenderChainCommand firstHeadCommand { get; private set; }

		public RenderChainCommand lastHeadCommand { get; private set; }

		public RenderChainCommand firstTailCommand { get; private set; }

		public RenderChainCommand lastTailCommand { get; private set; }

		public void Init(Entry root, RenderTreeManager renderTreeManager, RenderData renderData)
		{
		}

		public void ClearReferences()
		{
		}

		public void ProcessHead()
		{
		}

		public void ProcessTail()
		{
		}

		private void ProcessRange(int first, int last)
		{
		}

		private void ProcessMeshEntry(Entry entry, TextureId textureId)
		{
		}

		private void DrawReverseMask()
		{
		}

		private RenderChainCommand CreateMeshDrawCommand(MeshHandle mesh, int indexCount, int indexOffset, Material material, TextureId texture)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void AppendCommand(RenderChainCommand next)
		{
		}

		private void ProcessFirstAlloc(List<EntryPreProcessor.AllocSize> allocList, ref MeshHandle mesh)
		{
		}

		private void ProcessNextAlloc()
		{
		}

		private static void UpdateOrAllocate(ref MeshHandle data, int vertexCount, int indexCount, UIRenderDevice device, out NativeSlice<Vertex> verts, out NativeSlice<ushort> indices, out ushort indexOffset, ref ChainBuilderStats stats)
		{
			verts = default(NativeSlice<Vertex>);
			indices = default(NativeSlice<ushort>);
			indexOffset = default(ushort);
		}
	}
}
