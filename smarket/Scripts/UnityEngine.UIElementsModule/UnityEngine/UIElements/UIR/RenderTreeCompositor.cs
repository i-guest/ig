using System;
using System.Collections.Generic;

namespace UnityEngine.UIElements.UIR
{
	internal class RenderTreeCompositor : IDisposable
	{
		private enum DrawOperationType
		{
			Undefined = 0,
			RenderTree = 1,
			Effect = 2
		}

		private class DrawOperation
		{
			private DrawOperationType m_Type;

			private VisualElement m_VisualElement;

			private RenderTree m_RenderTree;

			private PostProcessingPass m_FilterPass;

			private int m_FilterPassIndex;

			private FilterFunction m_Filter;

			public RectInt bounds;

			public RectInt drawSourceBounds;

			public Vector4 drawSourceTexOffsets;

			public RenderTreeAtlas.AtlasBlock dstAtlasBlock;

			public TextureId dstTextureId;

			public DrawOperation parent;

			public DrawOperation firstChild;

			public DrawOperation lastChild;

			public DrawOperation prevSibling;

			public DrawOperation nextSibling;

			public DrawOperationType type => default(DrawOperationType);

			public VisualElement visualElement => null;

			public RenderTree renderTree => null;

			public PostProcessingPass FilterPass => default(PostProcessingPass);

			public int FilterPassIndex => 0;

			public FilterFunction filter => default(FilterFunction);

			public void Init(VisualElement ve, in PostProcessingPass filterPass, int filterPassIndex, FilterFunction filter)
			{
			}

			public void Init(RenderTree renderTree)
			{
			}

			private void InitPointers()
			{
			}

			public void Reset()
			{
			}

			public void AddChild(DrawOperation op)
			{
			}
		}

		private readonly RenderTreeManager m_RenderTreeManager;

		private DrawOperation m_RootOperation;

		private List<RenderTexture> m_AllocatedTextures;

		private MaterialPropertyBlock m_Block;

		private ObjectPool<DrawOperation> m_DrawOperationPool;

		private static Vector4[] s_UVRects;

		protected bool disposed { get; private set; }

		public RenderTreeCompositor(RenderTreeManager owner)
		{
		}

		public void Update(RenderTree rootRenderTree)
		{
		}

		private void BuildDrawOperationTree(RenderTree rootRenderTree)
		{
		}

		private void AddChildrenOperations_DepthFirst(DrawOperation parentOperation, RenderTree renderTree)
		{
		}

		private static PostProcessingMargins GetReadMargins(PostProcessingPass effect, FilterFunction func)
		{
			return default(PostProcessingMargins);
		}

		private static PostProcessingMargins GetWriteMargins(PostProcessingPass effect, FilterFunction func)
		{
			return default(PostProcessingMargins);
		}

		private void UpdateDrawBounds_PostOrder(DrawOperation op)
		{
		}

		private void AssignTextureIds_DepthFirst(DrawOperation op)
		{
		}

		public void RenderNestedPasses()
		{
		}

		private void ExecuteDrawOperation_PostOrder(DrawOperation op)
		{
		}

		private void ApplyEffectParameters(PostProcessingPass effect, FilterFunction filter, VisualElement source, bool readsGamma)
		{
		}

		private void CleanupOperationTree()
		{
		}

		private void CleanupOperation_PostOrder(DrawOperation op)
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
