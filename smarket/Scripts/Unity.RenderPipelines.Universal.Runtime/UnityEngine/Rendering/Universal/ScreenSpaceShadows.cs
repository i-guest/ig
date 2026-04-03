using System;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal
{
	[SupportedOnRenderer(typeof(UniversalRendererData))]
	[DisallowMultipleRendererFeature("Screen Space Shadows")]
	[Tooltip("Screen Space Shadows")]
	internal class ScreenSpaceShadows : ScriptableRendererFeature
	{
		private class ScreenSpaceShadowsPass : ScriptableRenderPass
		{
			private class PassData
			{
				internal TextureHandle target;

				internal Material material;
			}

			private Material m_Material;

			private ScreenSpaceShadowsSettings m_CurrentSettings;

			private int m_ScreenSpaceShadowmapTextureID;

			private PassData m_PassData;

			private RTHandle m_RenderTarget;

			internal ScreenSpaceShadowsPass()
			{
			}

			public void Dispose()
			{
			}

			internal bool Setup(ScreenSpaceShadowsSettings featureSettings, Material material)
			{
				return false;
			}

			[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
			public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
			{
			}

			private void InitPassData(ref PassData passData)
			{
			}

			public override void RecordRenderGraph(RenderGraph renderGraph, ContextContainer frameData)
			{
			}

			private static void ExecutePass(RasterCommandBuffer cmd, PassData data, RTHandle target)
			{
			}

			private static void ExecutePass(UnsafeCommandBuffer cmd, PassData data, RTHandle target)
			{
			}

			[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
			public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
			{
			}
		}

		private class ScreenSpaceShadowsPostPass : ScriptableRenderPass
		{
			internal class PassData
			{
				internal UniversalShadowData shadowData;
			}

			private static readonly RTHandle k_CurrentActive;

			internal ScreenSpaceShadowsPostPass()
			{
			}

			[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
			public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
			{
			}

			private static void ExecutePass(RasterCommandBuffer cmd, UniversalShadowData shadowData)
			{
			}

			[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
			public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
			{
			}

			public override void RecordRenderGraph(RenderGraph renderGraph, ContextContainer frameData)
			{
			}
		}

		[SerializeField]
		[HideInInspector]
		private Shader m_Shader;

		[SerializeField]
		private ScreenSpaceShadowsSettings m_Settings;

		private Material m_Material;

		private ScreenSpaceShadowsPass m_SSShadowsPass;

		private ScreenSpaceShadowsPostPass m_SSShadowsPostPass;

		private const string k_ShaderName = "Hidden/Universal Render Pipeline/ScreenSpaceShadows";

		public override void Create()
		{
		}

		public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
		{
		}

		protected override void Dispose(bool disposing)
		{
		}

		private bool LoadMaterial()
		{
			return false;
		}
	}
}
