using System;
using System.Collections.Generic;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal
{
	internal class DecalScreenSpaceRenderPass : ScriptableRenderPass
	{
		private class PassData
		{
			internal DecalDrawScreenSpaceSystem drawSystem;

			internal DecalScreenSpaceSettings settings;

			internal bool decalLayers;

			internal bool isGLDevice;

			internal TextureHandle colorTarget;

			internal UniversalCameraData cameraData;

			internal RendererListHandle rendererList;
		}

		private FilteringSettings m_FilteringSettings;

		private List<ShaderTagId> m_ShaderTagIdList;

		private DecalDrawScreenSpaceSystem m_DrawSystem;

		private DecalScreenSpaceSettings m_Settings;

		private bool m_DecalLayers;

		private PassData m_PassData;

		public DecalScreenSpaceRenderPass(DecalScreenSpaceSettings settings, DecalDrawScreenSpaceSystem drawSystem, bool decalLayers)
		{
		}

		private RendererListParams CreateRenderListParams(UniversalRenderingData renderingData, UniversalCameraData cameraData, UniversalLightData lightData)
		{
			return default(RendererListParams);
		}

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		private void InitPassData(UniversalCameraData cameraData, ref PassData passData)
		{
		}

		private static void ExecutePass(RasterCommandBuffer cmd, PassData passData, RendererList rendererList)
		{
		}

		public override void RecordRenderGraph(RenderGraph renderGraph, ContextContainer frameData)
		{
		}

		public override void OnCameraCleanup(CommandBuffer cmd)
		{
		}
	}
}
