using System;
using System.Runtime.CompilerServices;
using Unity.Profiling;

namespace UnityEngine.UIElements.UIR
{
	internal class RenderTree
	{
		[Flags]
		internal enum AllowedClasses
		{
			Clipping = 1,
			Opacity = 2,
			Color = 4,
			TransformSize = 8,
			Visuals = 0x10,
			All = 0x1F
		}

		private RenderTreeManager m_RenderTreeManager;

		private DepthOrderedDirtyTracking m_DirtyTracker;

		private RenderChainCommand m_FirstCommand;

		private RenderData m_RootRenderData;

		public TextureId quadTextureId;

		public RectInt quadRect;

		public Rect quadUVRect;

		public GCHandlePool m_GCHandlePool;

		internal RenderTree parent;

		internal RenderTree firstChild;

		internal RenderTree nextSibling;

		private static readonly ProfilerMarker k_MarkerClipProcessing;

		private static readonly ProfilerMarker k_MarkerOpacityProcessing;

		private static readonly ProfilerMarker k_MarkerColorsProcessing;

		private static readonly ProfilerMarker k_MarkerTransformProcessing;

		private static readonly ProfilerMarker k_MarkerVisualsProcessing;

		private AllowedClasses m_AllowedDirtyClasses;

		internal RenderTreeManager renderTreeManager => null;

		internal RenderData rootRenderData => null;

		internal ref DepthOrderedDirtyTracking dirtyTracker
		{
			get
			{
				throw null;
			}
		}

		internal RenderChainCommand firstCommand => null;

		internal bool isRootRenderTree
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return false;
			}
		}

		public void Init(RenderTreeManager renderTreeManager, RenderData rootRenderData)
		{
		}

		public void Reset()
		{
		}

		public void Dispose()
		{
		}

		private void DepthFirstResetTextures(RenderData renderData)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void OnRenderDataTransformOrSizeChanged(RenderData renderData, bool transformChanged, bool clipRectSizeChanged)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void OnRenderDataOpacityIdChanged(RenderData renderData)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void OnRenderDataVisualsChanged(RenderData renderData, bool hierarchical)
		{
		}

		public void ProcessChanges(ref ChainBuilderStats stats)
		{
		}

		internal void OnRenderCommandAdded(RenderChainCommand command)
		{
		}

		internal void OnRenderCommandsRemoved(RenderChainCommand firstCommand, RenderChainCommand lastCommand)
		{
		}

		internal void ChildWillBeRemoved(RenderData renderData)
		{
		}
	}
}
