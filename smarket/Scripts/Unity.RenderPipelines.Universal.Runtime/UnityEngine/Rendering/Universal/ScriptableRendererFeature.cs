using System;

namespace UnityEngine.Rendering.Universal
{
	[ExcludeFromPreset]
	public abstract class ScriptableRendererFeature : ScriptableObject, IDisposable
	{
		[Obsolete("This enum is not used. #from(6000.3)", false)]
		public enum IntermediateTextureUsage
		{
			Unknown = 0,
			Required = 1,
			NotRequired = 2
		}

		[SerializeField]
		[HideInInspector]
		private bool m_Active;

		public bool isActive => false;

		[Obsolete("This property is not used. #from(6000.3)", false)]
		protected virtual IntermediateTextureUsage useIntermediateTextures => default(IntermediateTextureUsage);

		public abstract void Create();

		public virtual void OnCameraPreCull(ScriptableRenderer renderer, in CameraData cameraData)
		{
		}

		public abstract void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData);

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(6000.2)")]
		public virtual void SetupRenderPasses(ScriptableRenderer renderer, in RenderingData renderingData)
		{
		}

		private void OnEnable()
		{
		}

		private void OnValidate()
		{
		}

		internal virtual bool SupportsNativeRenderPass()
		{
			return false;
		}

		internal virtual bool RequireRenderingLayers(bool isDeferred, bool needsGBufferAccurateNormals, out RenderingLayerUtils.Event atEvent, out RenderingLayerUtils.MaskSize maskSize)
		{
			atEvent = default(RenderingLayerUtils.Event);
			maskSize = default(RenderingLayerUtils.MaskSize);
			return false;
		}

		public void SetActive(bool active)
		{
		}

		public void Dispose()
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}
	}
}
