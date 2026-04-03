using System;
using UnityEngine.Rendering.RenderGraphModule;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Rendering.Universal
{
	[MovedFrom(null)]
	public class FullScreenPassRendererFeature : ScriptableRendererFeature, ISerializationCallbackReceiver
	{
		public enum InjectionPoint
		{
			BeforeRenderingTransparents = 450,
			BeforeRenderingPostProcessing = 550,
			AfterRenderingPostProcessing = 600
		}

		internal class FullScreenRenderPass : ScriptableRenderPass
		{
			private class CopyPassData
			{
				internal TextureHandle inputTexture;
			}

			private class MainPassData
			{
				internal Material material;

				internal int passIndex;

				internal TextureHandle inputTexture;
			}

			private Material m_Material;

			private int m_PassIndex;

			private bool m_FetchActiveColor;

			private bool m_BindDepthStencilAttachment;

			private static MaterialPropertyBlock s_SharedPropertyBlock;

			private RTHandle m_CopiedColor;

			public FullScreenRenderPass(string passName)
			{
			}

			public void SetupMembers(Material material, int passIndex, bool fetchActiveColor, bool bindDepthStencilAttachment)
			{
			}

			[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
			public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
			{
			}

			internal void ReAllocate(RenderTextureDescriptor desc)
			{
			}

			public void Dispose()
			{
			}

			private static void ExecuteCopyColorPass(RasterCommandBuffer cmd, RTHandle sourceTexture)
			{
			}

			private static void ExecuteMainPass(RasterCommandBuffer cmd, RTHandle sourceTexture, Material material, int passIndex)
			{
			}

			[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
			public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
			{
			}

			public override void RecordRenderGraph(RenderGraph renderGraph, ContextContainer frameData)
			{
			}

			private void AddFullscreenRenderPassInputPass(RenderGraph renderGraph, UniversalResourceData resourcesData, UniversalCameraData cameraData, TextureHandle source, TextureHandle destination)
			{
			}

			private void AddCopyPassRenderPassFullscreen(RenderGraph renderGraph, TextureHandle source, TextureHandle destination)
			{
			}
		}

		private enum Version
		{
			Uninitialised = -1,
			Initial = 0,
			AddFetchColorBufferCheckbox = 1,
			Count = 2,
			Latest = 1
		}

		public InjectionPoint injectionPoint;

		public bool fetchColorBuffer;

		public ScriptableRenderPassInput requirements;

		public Material passMaterial;

		public int passIndex;

		public bool bindDepthStencilAttachment;

		private FullScreenRenderPass m_FullScreenPass;

		[SerializeField]
		[HideInInspector]
		private Version m_Version;

		public override void Create()
		{
		}

		internal override bool RequireRenderingLayers(bool isDeferred, bool needsGBufferAccurateNormals, out RenderingLayerUtils.Event atEvent, out RenderingLayerUtils.MaskSize maskSize)
		{
			atEvent = default(RenderingLayerUtils.Event);
			maskSize = default(RenderingLayerUtils.MaskSize);
			return false;
		}

		public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
		{
		}

		protected override void Dispose(bool disposing)
		{
		}

		private void UpgradeIfNeeded()
		{
		}

		void ISerializationCallbackReceiver.OnBeforeSerialize()
		{
		}

		void ISerializationCallbackReceiver.OnAfterDeserialize()
		{
		}
	}
}
