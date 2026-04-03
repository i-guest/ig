using System;
using System.Collections.Generic;
using UnityEngine.Rendering.RenderGraphModule;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Rendering.Universal
{
	[MovedFrom(true, "UnityEngine.Experimental.Rendering.Universal", null, null)]
	public class RenderObjectsPass : ScriptableRenderPass
	{
		private class PassData
		{
			internal RenderObjects.CustomCameraSettings cameraSettings;

			internal RenderPassEvent renderPassEvent;

			internal TextureHandle color;

			internal RendererListHandle rendererListHdl;

			internal DebugRendererLists debugRendererLists;

			internal UniversalCameraData cameraData;

			internal RendererList rendererList;
		}

		private RenderQueueType renderQueueType;

		private FilteringSettings m_FilteringSettings;

		private RenderObjects.CustomCameraSettings m_CameraSettings;

		private List<ShaderTagId> m_ShaderTagIdList;

		private PassData m_PassData;

		private RenderStateBlock m_RenderStateBlock;

		public Material overrideMaterial { get; set; }

		public int overrideMaterialPassIndex { get; set; }

		public Shader overrideShader { get; set; }

		public int overrideShaderPassIndex { get; set; }

		[Obsolete("Use SetDepthState instead. #from(2023.1) #breakingFrom(2023.1)", true)]
		public void SetDetphState(bool writeEnabled, CompareFunction function = CompareFunction.Less)
		{
		}

		public void SetDepthState(bool writeEnabled, CompareFunction function = CompareFunction.Less)
		{
		}

		public void SetStencilState(int reference, CompareFunction compareFunction, StencilOp passOp, StencilOp failOp, StencilOp zFailOp)
		{
		}

		public RenderObjectsPass(string profilerTag, RenderPassEvent renderPassEvent, string[] shaderTags, RenderQueueType renderQueueType, int layerMask, RenderObjects.CustomCameraSettings cameraSettings)
		{
		}

		internal RenderObjectsPass(URPProfileId profileId, RenderPassEvent renderPassEvent, string[] shaderTags, RenderQueueType renderQueueType, int layerMask, RenderObjects.CustomCameraSettings cameraSettings)
		{
		}

		internal void Init(RenderPassEvent renderPassEvent, string[] shaderTags, RenderQueueType renderQueueType, int layerMask, RenderObjects.CustomCameraSettings cameraSettings)
		{
		}

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		private static void ExecutePass(PassData passData, RasterCommandBuffer cmd, RendererList rendererList, bool isYFlipped)
		{
		}

		private void InitPassData(UniversalCameraData cameraData, ref PassData passData)
		{
		}

		private void InitRendererLists(UniversalRenderingData renderingData, UniversalLightData lightData, ref PassData passData, ScriptableRenderContext context, RenderGraph renderGraph, bool useRenderGraph)
		{
		}

		public override void RecordRenderGraph(RenderGraph renderGraph, ContextContainer frameData)
		{
		}
	}
}
