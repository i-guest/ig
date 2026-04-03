using System;
using System.Diagnostics;
using UnityEngine.Rendering.Universal.Internal;

namespace UnityEngine.Rendering.Universal
{
	[SupportedOnRenderer(typeof(UniversalRendererData))]
	[DisallowMultipleRendererFeature("Decal")]
	[Tooltip("With this Renderer Feature, Unity can project specific Materials (decals) onto other objects in the Scene.")]
	public class DecalRendererFeature : ScriptableRendererFeature
	{
		[SerializeField]
		private DecalSettings m_Settings;

		private DecalTechnique m_Technique;

		private DBufferSettings m_DBufferSettings;

		private DecalScreenSpaceSettings m_ScreenSpaceSettings;

		private bool m_RecreateSystems;

		private DecalPreviewPass m_DecalPreviewPass;

		private DecalEntityManager m_DecalEntityManager;

		private DecalUpdateCachedSystem m_DecalUpdateCachedSystem;

		private DecalUpdateCullingGroupSystem m_DecalUpdateCullingGroupSystem;

		private DecalUpdateCulledSystem m_DecalUpdateCulledSystem;

		private DecalCreateDrawCallSystem m_DecalCreateDrawCallSystem;

		private DecalDrawErrorSystem m_DrawErrorSystem;

		private DBufferCopyDepthPass m_CopyDepthPass;

		private DBufferRenderPass m_DBufferRenderPass;

		private DecalForwardEmissivePass m_ForwardEmissivePass;

		private DecalDrawDBufferSystem m_DecalDrawDBufferSystem;

		private DecalDrawFowardEmissiveSystem m_DecalDrawForwardEmissiveSystem;

		private Material m_DBufferClearMaterial;

		private DecalScreenSpaceRenderPass m_ScreenSpaceDecalRenderPass;

		private DecalDrawScreenSpaceSystem m_DecalDrawScreenSpaceSystem;

		private DecalSkipCulledSystem m_DecalSkipCulledSystem;

		private DecalGBufferRenderPass m_GBufferRenderPass;

		private DecalDrawGBufferSystem m_DrawGBufferSystem;

		private DeferredLights m_DeferredLights;

		private static SharedDecalEntityManager sharedDecalEntityManager { get; }

		internal ref DecalSettings settings
		{
			get
			{
				throw null;
			}
		}

		internal bool intermediateRendering => false;

		internal bool requiresDecalLayers => false;

		internal static bool isGLDevice => false;

		public override void Create()
		{
		}

		internal override bool RequireRenderingLayers(bool isDeferred, bool needsGBufferAccurateNormals, out RenderingLayerUtils.Event atEvent, out RenderingLayerUtils.MaskSize maskSize)
		{
			atEvent = default(RenderingLayerUtils.Event);
			maskSize = default(RenderingLayerUtils.MaskSize);
			return false;
		}

		internal DBufferSettings GetDBufferSettings()
		{
			return null;
		}

		internal DecalScreenSpaceSettings GetScreenSpaceSettings()
		{
			return null;
		}

		internal DecalTechnique GetTechnique(ScriptableRendererData renderer)
		{
			return default(DecalTechnique);
		}

		internal DecalTechnique GetTechnique(ScriptableRenderer renderer)
		{
			return default(DecalTechnique);
		}

		internal DecalTechnique GetTechnique(bool isDeferred, bool needsGBufferAccurateNormals, bool checkForInvalidTechniques = true)
		{
			return default(DecalTechnique);
		}

		private bool IsAutomaticDBuffer()
		{
			return false;
		}

		private bool RecreateSystemsIfNeeded(ScriptableRenderer renderer, in CameraData cameraData)
		{
			return false;
		}

		public override void OnCameraPreCull(ScriptableRenderer renderer, in CameraData cameraData)
		{
		}

		public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
		{
		}

		internal override bool SupportsNativeRenderPass()
		{
			return false;
		}

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(6000.2)")]
		public override void SetupRenderPasses(ScriptableRenderer renderer, in RenderingData renderingData)
		{
		}

		protected override void Dispose(bool disposing)
		{
		}

		[Conditional("ENABLE_ADAPTIVE_PERFORMANCE")]
		private void ChangeAdaptivePerformanceDrawDistances()
		{
		}
	}
}
