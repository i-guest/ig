using System;
using System.Collections.Generic;

namespace UnityEngine.Rendering.Universal
{
	public abstract class ScriptableRendererData : ScriptableObject
	{
		[Serializable]
		[Obsolete("Moved to UniversalRenderPipelineDebugShaders on GraphicsSettings. #from(2023.3)")]
		[ReloadGroup]
		public sealed class DebugShaderResources
		{
			[Obsolete("Moved to UniversalRenderPipelineDebugShaders on GraphicsSettings. #from(2023.3)")]
			[Reload("Shaders/Debug/DebugReplacement.shader", ReloadAttribute.Package.Root)]
			public Shader debugReplacementPS;

			[Obsolete("Moved to UniversalRenderPipelineDebugShaders on GraphicsSettings. #from(2023.3)")]
			[Reload("Shaders/Debug/HDRDebugView.shader", ReloadAttribute.Package.Root)]
			public Shader hdrDebugViewPS;
		}

		[Serializable]
		[ReloadGroup]
		[Obsolete("Probe volume debug resource are now in the ProbeVolumeDebugResources class. #from(2023.3)")]
		public sealed class ProbeVolumeResources
		{
			[Obsolete("This shader is now in the ProbeVolumeDebugResources class. #from(2023.3)")]
			public Shader probeVolumeDebugShader;

			[Obsolete("This shader is now in the ProbeVolumeDebugResources class. #from(2023.3)")]
			public Shader probeVolumeFragmentationDebugShader;

			[Obsolete("This shader is now in the ProbeVolumeDebugResources class. #from(2023.3)")]
			public Shader probeVolumeOffsetDebugShader;

			[Obsolete("This shader is now in the ProbeVolumeDebugResources class. #from(2023.3)")]
			public Shader probeVolumeSamplingDebugShader;

			[Obsolete("This shader is now in the ProbeVolumeDebugResources class. #from(2023.3)")]
			public Mesh probeSamplingDebugMesh;

			[Obsolete("This shader is now in the ProbeVolumeDebugResources class. #from(2023.3)")]
			public Texture2D probeSamplingDebugTexture;

			[Obsolete("This shader is now in the ProbeVolumeRuntimeResources class. #from(2023.3)")]
			public ComputeShader probeVolumeBlendStatesCS;
		}

		[Obsolete("Moved to UniversalRenderPipelineDebugShaders on GraphicsSettings. #from(2023.3)")]
		public DebugShaderResources debugShaders;

		[Obsolete("Probe volume debug resource are now in the ProbeVolumeDebugResources class. #from(2023.3)")]
		public ProbeVolumeResources probeVolumeResources;

		[SerializeField]
		internal List<ScriptableRendererFeature> m_RendererFeatures;

		[SerializeField]
		internal List<long> m_RendererFeatureMap;

		[SerializeField]
		private bool m_UseNativeRenderPass;

		[NonSerialized]
		private bool m_StripShadowsOffVariants;

		[NonSerialized]
		private bool m_StripAdditionalLightOffVariants;

		internal bool isInvalidated { get; set; }

		internal virtual bool stripShadowsOffVariants
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal virtual bool stripAdditionalLightOffVariants
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public List<ScriptableRendererFeature> rendererFeatures => null;

		public bool useNativeRenderPass
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected abstract ScriptableRenderer Create();

		public void SetDirty()
		{
		}

		internal ScriptableRenderer InternalCreateRenderer()
		{
			return null;
		}

		protected virtual void OnValidate()
		{
		}

		protected virtual void OnEnable()
		{
		}

		public bool TryGetRendererFeature<T>(out T rendererFeature) where T : ScriptableRendererFeature
		{
			rendererFeature = null;
			return false;
		}
	}
}
