using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Profiling;
using UnityEngine.Pool;

namespace UnityEngine.UIElements.UIR
{
	internal class RenderTreeManager : IDisposable
	{
		internal struct ElementInsertionData
		{
			public VisualElement element;

			public bool canceled;
		}

		internal class VisualChangesProcessor : IDisposable
		{
			private enum VisualsProcessingType
			{
				Head = 0,
				Tail = 1
			}

			private struct EntryProcessingInfo
			{
				public RenderData renderData;

				public VisualsProcessingType type;

				public Entry rootEntry;
			}

			private static readonly ProfilerMarker k_GenerateEntriesMarker;

			private static readonly ProfilerMarker k_ConvertEntriesToCommandsMarker;

			private static readonly ProfilerMarker k_UpdateOpacityIdMarker;

			private RenderTreeManager m_RenderTreeManager;

			private MeshGenerationContext m_MeshGenerationContext;

			private BaseElementBuilder m_ElementBuilder;

			private List<EntryProcessingInfo> m_EntryProcessingList;

			private List<EntryProcessor> m_Processors;

			public BaseElementBuilder elementBuilder => null;

			public MeshGenerationContext meshGenerationContext => null;

			protected bool disposed { get; private set; }

			public VisualChangesProcessor(RenderTreeManager renderTreeManager)
			{
			}

			public void ScheduleMeshGenerationJobs()
			{
			}

			public void ProcessOnVisualsChanged(RenderData renderData, uint dirtyID, ref ChainBuilderStats stats)
			{
			}

			private void DepthFirstOnVisualsChanged(RenderData renderData, uint dirtyID, bool hierarchical, ref ChainBuilderStats stats)
			{
			}

			private static void UpdateWorldFlipsWinding(RenderData renderData)
			{
			}

			public void ConvertEntriesToCommands(ref ChainBuilderStats stats)
			{
			}

			public static void UpdateOpacityId(RenderData renderData, RenderTreeManager renderTreeManager)
			{
			}

			private static void DoUpdateOpacityId(RenderData renderData, RenderTreeManager renderTreeManager, MeshHandle mesh)
			{
			}

			public void Dispose()
			{
			}

			protected void Dispose(bool disposing)
			{
			}
		}

		private RenderTreeCompositor m_Compositor;

		private VisualChangesProcessor m_VisualChangesProcessor;

		private LinkedPool<RenderChainCommand> m_CommandPool;

		private LinkedPool<ExtraRenderData> m_ExtraDataPool;

		private BasicNodePool<MeshHandle> m_MeshHandleNodePool;

		private BasicNodePool<GraphicEntry> m_GraphicEntryPool;

		private Dictionary<RenderData, ExtraRenderData> m_ExtraData;

		internal List<ElementInsertionData> m_InsertionList;

		private MeshGenerationDeferrer m_MeshGenerationDeferrer;

		private Material m_DefaultMat;

		private bool m_BlockDirtyRegistration;

		private ChainBuilderStats m_Stats;

		private uint m_StatsElementsAdded;

		private uint m_StatsElementsRemoved;

		private TextureRegistry m_TextureRegistry;

		private UnityEngine.Pool.ObjectPool<RenderData> m_RenderDataPool;

		private UnityEngine.Pool.ObjectPool<RenderTree> m_RenderTreePool;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _003CblockDirtyRegistration_003Ek__BackingField;

		private static EntryPool s_SharedEntryPool;

		private static readonly ProfilerMarker k_MarkerProcess;

		private static readonly ProfilerMarker k_MarkerSerialize;

		private RenderTree m_RootRenderTree;

		public EntryRecorder entryRecorder;

		internal UIRVEShaderInfoAllocator shaderInfoAllocator;

		internal TextureRegistry textureRegistry => null;

		internal VisualChangesProcessor visualChangesProcessor => null;

		public OpacityIdAccelerator opacityIdAccelerator { get; private set; }

		public TextureSlotCount textureSlotCount { get; set; }

		protected bool disposed { get; private set; }

		internal ref ChainBuilderStats statsByRef
		{
			get
			{
				throw null;
			}
		}

		internal RenderTree rootRenderTree
		{
			set
			{
			}
		}

		internal BaseVisualElementPanel panel { get; private set; }

		internal UIRenderDevice device { get; private set; }

		public BaseElementBuilder elementBuilder => null;

		internal AtlasBase atlas { get; private set; }

		internal VectorImageManager vectorImageManager { get; private set; }

		internal TempMeshAllocatorImpl tempMeshAllocator { get; private set; }

		internal MeshWriteDataPool meshWriteDataPool { get; }

		internal EntryPool entryPool => null;

		public MeshGenerationDeferrer meshGenerationDeferrer => null;

		public MeshGenerationNodeManager meshGenerationNodeManager { get; private set; }

		internal JobManager jobManager { get; private set; }

		internal bool drawStats { get; set; }

		internal bool drawInCameras { get; }

		internal bool isFlat { get; }

		public bool forceGammaRendering { get; }

		internal RenderData GetPooledRenderData()
		{
			return null;
		}

		internal void ReturnPoolRenderData(RenderData data)
		{
		}

		internal RenderTree GetPooledRenderTree(RenderTreeManager renderTreeManager, RenderData rootRenderData)
		{
			return null;
		}

		internal void ReturnPoolRenderTree(RenderTree tree)
		{
		}

		public RenderTreeManager(BaseVisualElementPanel panel)
		{
		}

		public void Dispose()
		{
		}

		protected void Dispose(bool disposing)
		{
		}

		private static void ReverseDepthFirstDisposeRenderTrees(RenderTree renderTree)
		{
		}

		private void DepthFirstProcessChanges(RenderTree renderTree)
		{
		}

		public void ProcessChanges()
		{
		}

		private void SerializeRootTreeCommands()
		{
		}

		public void RenderRootTree()
		{
		}

		private void RenderNestedTrees()
		{
		}

		public void RenderSingleTree(RenderTree renderTree, RenderTexture nestedTreeRT, RectInt nestedTreeViewport, Rect bounds)
		{
		}

		public void CancelInsertion(VisualElement ve)
		{
		}

		public void UIEOnChildAdded(VisualElement ve)
		{
		}

		private void ProcessChildAdded(VisualElement ve)
		{
		}

		public void UIEOnChildrenReordered(VisualElement ve)
		{
		}

		public void UIEOnChildRemoving(VisualElement ve)
		{
		}

		public void UIEOnRenderHintsChanged(VisualElement ve)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void RegisterDirty(VisualElement ve, RenderDataDirtyTypes dirtyTypes, RenderDataDirtyTypeClasses dirtyClasses)
		{
		}

		public void UIEOnClippingChanged(VisualElement ve, bool hierarchical)
		{
		}

		public void UIEOnOpacityChanged(VisualElement ve, bool hierarchical = false)
		{
		}

		public void UIEOnColorChanged(VisualElement ve)
		{
		}

		public void UIEOnTransformOrSizeChanged(VisualElement ve, bool transformChanged, bool clipRectSizeChanged)
		{
		}

		public void UIEOnVisualsChanged(VisualElement ve, bool hierarchical)
		{
		}

		public void UIEOnDisableRenderingChanged(VisualElement ve)
		{
		}

		internal RenderChainCommand AllocCommand()
		{
			return null;
		}

		internal void FreeCommand(RenderChainCommand cmd)
		{
		}

		internal void RepaintTexturedElements()
		{
		}

		private void DepthFirstRepaintTextured(RenderTree renderTree)
		{
		}

		private void DepthFirstRepaintTextured(RenderData renderData)
		{
		}

		public ExtraRenderData GetOrAddExtraData(RenderData renderData)
		{
			return null;
		}

		public void FreeExtraData(RenderData renderData)
		{
		}

		public void InsertExtraMesh(RenderData renderData, MeshHandle mesh)
		{
		}

		public void FreeExtraMeshes(RenderData renderData)
		{
		}

		public void InsertTexture(RenderData renderData, Texture src, TextureId id, bool isAtlas)
		{
		}

		public void InsertVectorImage(RenderData renderData, VectorImage vi)
		{
		}

		public void ResetGraphicEntries(RenderData renderData)
		{
		}

		private void DrawStats()
		{
		}
	}
}
