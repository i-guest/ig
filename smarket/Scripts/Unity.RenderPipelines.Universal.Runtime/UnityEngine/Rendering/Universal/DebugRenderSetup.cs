using System;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal
{
	internal class DebugRenderSetup : IDisposable
	{
		private readonly DebugHandler m_DebugHandler;

		private readonly FilteringSettings m_FilteringSettings;

		private readonly int m_Index;

		private DebugDisplaySettingsMaterial MaterialSettings => null;

		private DebugDisplaySettingsRendering RenderingSettings => null;

		private DebugDisplaySettingsLighting LightingSettings => null;

		internal void Begin(RasterCommandBuffer cmd)
		{
		}

		internal void End(RasterCommandBuffer cmd)
		{
		}

		internal DebugRenderSetup(DebugHandler debugHandler, int index, FilteringSettings filteringSettings)
		{
		}

		internal void CreateRendererList(ScriptableRenderContext context, ref CullingResults cullResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ref RenderStateBlock renderStateBlock, ref RendererList rendererList)
		{
		}

		internal void CreateRendererList(RenderGraph renderGraph, ref CullingResults cullResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ref RenderStateBlock renderStateBlock, ref RendererListHandle rendererListHdl)
		{
		}

		internal void DrawWithRendererList(RasterCommandBuffer cmd, ref RendererList rendererList)
		{
		}

		internal DrawingSettings CreateDrawingSettings(DrawingSettings drawingSettings)
		{
			return default(DrawingSettings);
		}

		internal RenderStateBlock GetRenderStateBlock(RenderStateBlock renderStateBlock)
		{
			return default(RenderStateBlock);
		}

		internal int GetIndex()
		{
			return 0;
		}

		public void Dispose()
		{
		}
	}
}
