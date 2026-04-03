using System;
using System.Collections.Generic;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal
{
	internal class DBufferRenderPass : ScriptableRenderPass
	{
		private class PassData
		{
			internal DecalDrawDBufferSystem drawSystem;

			internal DBufferSettings settings;

			internal bool decalLayers;

			internal RTHandle dBufferDepth;

			internal RTHandle[] dBufferColorHandles;

			internal RendererListHandle rendererList;
		}

		internal static string[] s_DBufferNames;

		internal static string s_DBufferDepthName;

		private static readonly int s_SSAOTextureID;

		private DecalDrawDBufferSystem m_DrawSystem;

		private DBufferSettings m_Settings;

		private FilteringSettings m_FilteringSettings;

		private List<ShaderTagId> m_ShaderTagIdList;

		private bool m_DecalLayers;

		private TextureHandle[] dbufferHandles;

		private RTHandle m_DBufferDepth;

		private Material m_DBufferClear;

		private ProfilingSampler m_DBufferClearSampler;

		private PassData m_PassData;

		internal RTHandle[] dBufferColorHandles { get; private set; }

		internal RTHandle depthHandle { get; private set; }

		internal RTHandle dBufferDepth => null;

		public DBufferRenderPass(Material dBufferClear, DBufferSettings settings, DecalDrawDBufferSystem drawSystem, bool decalLayers)
		{
		}

		public void Dispose()
		{
		}

		public void Setup(in CameraData cameraData)
		{
		}

		public void Setup(in CameraData cameraData, RTHandle depthTextureHandle)
		{
		}

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
		{
		}

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		private static void ExecutePass(RasterCommandBuffer cmd, PassData passData, RendererList rendererList, bool renderGraph)
		{
		}

		private static void SetGlobalTextures(CommandBuffer cmd, PassData passData)
		{
		}

		private static void SetKeywords(RasterCommandBuffer cmd, PassData passData)
		{
		}

		private void InitPassData(ref PassData passData)
		{
		}

		private RendererListParams InitRendererListParams(UniversalRenderingData renderingData, UniversalCameraData cameraData, UniversalLightData lightData)
		{
			return default(RendererListParams);
		}

		public override void RecordRenderGraph(RenderGraph renderGraph, ContextContainer frameData)
		{
		}

		public override void OnCameraCleanup(CommandBuffer cmd)
		{
		}
	}
}
