using System.Collections.Generic;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal
{
	internal class DebugRendererLists
	{
		private readonly DebugHandler m_DebugHandler;

		private readonly FilteringSettings m_FilteringSettings;

		private List<DebugRenderSetup> m_DebugRenderSetups;

		private List<RendererList> m_ActiveDebugRendererList;

		private List<RendererListHandle> m_ActiveDebugRendererListHdl;

		public DebugRendererLists(DebugHandler debugHandler, FilteringSettings filteringSettings)
		{
		}

		private void CreateDebugRenderSetups(FilteringSettings filteringSettings)
		{
		}

		private void DisposeDebugRenderLists()
		{
		}

		internal void CreateRendererListsWithDebugRenderState(ScriptableRenderContext context, ref CullingResults cullResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ref RenderStateBlock renderStateBlock)
		{
		}

		internal void CreateRendererListsWithDebugRenderState(RenderGraph renderGraph, ref CullingResults cullResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ref RenderStateBlock renderStateBlock)
		{
		}

		internal void PrepareRendererListForRasterPass(IRasterRenderGraphBuilder builder)
		{
		}

		internal void DrawWithRendererList(RasterCommandBuffer cmd)
		{
		}
	}
}
