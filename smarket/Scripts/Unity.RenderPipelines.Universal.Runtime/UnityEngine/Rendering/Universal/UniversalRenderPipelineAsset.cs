using System;
using System.ComponentModel;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering.RenderGraphModule;
using UnityEngine.Serialization;

namespace UnityEngine.Rendering.Universal
{
	[ExcludeFromPreset]
	public class UniversalRenderPipelineAsset : RenderPipelineAsset<UniversalRenderPipeline>, ISerializationCallbackReceiver, IProbeVolumeEnabledRenderPipeline, IGPUResidentRenderPipeline, IRenderGraphEnabledRenderPipeline, ISTPEnabledRenderPipeline
	{
		private static class Strings
		{
			public static readonly string notURPRenderer;

			public static readonly string renderingModeIncompatible;
		}

		[Serializable]
		[ReloadGroup]
		[Obsolete("Moved to UniversalRenderPipelineRuntimeTextures on GraphicsSettings. #from(2023.3)")]
		public sealed class TextureResources
		{
			[Reload("Textures/BlueNoise64/L/LDR_LLL1_0.png", ReloadAttribute.Package.Root)]
			public Texture2D blueNoise64LTex;

			[Reload("Textures/BayerMatrix.png", ReloadAttribute.Package.Root)]
			public Texture2D bayerMatrixTex;

			public bool NeedsReload()
			{
				return false;
			}
		}

		private ScriptableRenderer[] m_Renderers;

		private const int k_LastVersion = 13;

		[SerializeField]
		private int k_AssetVersion;

		[SerializeField]
		private int k_AssetPreviousVersion;

		[SerializeField]
		private RendererType m_RendererType;

		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use m_RendererDataList instead. #from(2023.1)")]
		[SerializeField]
		internal ScriptableRendererData m_RendererData;

		[SerializeField]
		internal ScriptableRendererData[] m_RendererDataList;

		[SerializeField]
		internal int m_DefaultRendererIndex;

		[SerializeField]
		private bool m_RequireDepthTexture;

		[SerializeField]
		private bool m_RequireOpaqueTexture;

		[SerializeField]
		private Downsampling m_OpaqueDownsampling;

		[SerializeField]
		private bool m_SupportsTerrainHoles;

		[SerializeField]
		private bool m_SupportsHDR;

		[SerializeField]
		private HDRColorBufferPrecision m_HDRColorBufferPrecision;

		[SerializeField]
		private MsaaQuality m_MSAA;

		[SerializeField]
		private float m_RenderScale;

		[SerializeField]
		private UpscalingFilterSelection m_UpscalingFilter;

		[SerializeField]
		private bool m_FsrOverrideSharpness;

		[SerializeField]
		private float m_FsrSharpness;

		[SerializeField]
		private bool m_EnableLODCrossFade;

		[SerializeField]
		private LODCrossFadeDitheringType m_LODCrossFadeDitheringType;

		[SerializeField]
		private ShEvalMode m_ShEvalMode;

		[SerializeField]
		private LightProbeSystem m_LightProbeSystem;

		[SerializeField]
		private ProbeVolumeTextureMemoryBudget m_ProbeVolumeMemoryBudget;

		[SerializeField]
		private ProbeVolumeBlendingTextureMemoryBudget m_ProbeVolumeBlendingMemoryBudget;

		[SerializeField]
		[FormerlySerializedAs("m_SupportProbeVolumeStreaming")]
		private bool m_SupportProbeVolumeGPUStreaming;

		[SerializeField]
		private bool m_SupportProbeVolumeDiskStreaming;

		[SerializeField]
		private bool m_SupportProbeVolumeScenarios;

		[SerializeField]
		private bool m_SupportProbeVolumeScenarioBlending;

		[SerializeField]
		private ProbeVolumeSHBands m_ProbeVolumeSHBands;

		[SerializeField]
		private LightRenderingMode m_MainLightRenderingMode;

		[SerializeField]
		private bool m_MainLightShadowsSupported;

		[SerializeField]
		private ShadowResolution m_MainLightShadowmapResolution;

		[SerializeField]
		private LightRenderingMode m_AdditionalLightsRenderingMode;

		[SerializeField]
		private int m_AdditionalLightsPerObjectLimit;

		[SerializeField]
		private bool m_AdditionalLightShadowsSupported;

		[SerializeField]
		private ShadowResolution m_AdditionalLightsShadowmapResolution;

		[SerializeField]
		private int m_AdditionalLightsShadowResolutionTierLow;

		[SerializeField]
		private int m_AdditionalLightsShadowResolutionTierMedium;

		[SerializeField]
		private int m_AdditionalLightsShadowResolutionTierHigh;

		[SerializeField]
		private bool m_ReflectionProbeBlending;

		[SerializeField]
		private bool m_ReflectionProbeBoxProjection;

		[SerializeField]
		private bool m_ReflectionProbeAtlas;

		[SerializeField]
		private float m_ShadowDistance;

		[SerializeField]
		private int m_ShadowCascadeCount;

		[SerializeField]
		private float m_Cascade2Split;

		[SerializeField]
		private Vector2 m_Cascade3Split;

		[SerializeField]
		private Vector3 m_Cascade4Split;

		[SerializeField]
		private float m_CascadeBorder;

		[SerializeField]
		private float m_ShadowDepthBias;

		[SerializeField]
		private float m_ShadowNormalBias;

		[SerializeField]
		private bool m_SoftShadowsSupported;

		[SerializeField]
		private bool m_ConservativeEnclosingSphere;

		[SerializeField]
		private int m_NumIterationsEnclosingSphere;

		[SerializeField]
		private SoftShadowQuality m_SoftShadowQuality;

		[SerializeField]
		private LightCookieResolution m_AdditionalLightsCookieResolution;

		[SerializeField]
		private LightCookieFormat m_AdditionalLightsCookieFormat;

		[SerializeField]
		private bool m_UseSRPBatcher;

		[SerializeField]
		private bool m_SupportsDynamicBatching;

		[SerializeField]
		private bool m_MixedLightingSupported;

		[SerializeField]
		private bool m_SupportsLightCookies;

		[SerializeField]
		private bool m_SupportsLightLayers;

		[SerializeField]
		[Obsolete("#from(2022.1) #breakingFrom(2023.1)", true)]
		private PipelineDebugLevel m_DebugLevel;

		[SerializeField]
		private StoreActionsOptimization m_StoreActionsOptimization;

		[SerializeField]
		private bool m_UseAdaptivePerformance;

		[SerializeField]
		private ColorGradingMode m_ColorGradingMode;

		[SerializeField]
		private int m_ColorGradingLutSize;

		[SerializeField]
		private bool m_AllowPostProcessAlphaOutput;

		[SerializeField]
		private bool m_UseFastSRGBLinearConversion;

		[SerializeField]
		private bool m_SupportDataDrivenLensFlare;

		[SerializeField]
		private bool m_SupportScreenSpaceLensFlare;

		[FormerlySerializedAs("m_MacroBatcherMode")]
		[SerializeField]
		private GPUResidentDrawerMode m_GPUResidentDrawerMode;

		[SerializeField]
		private float m_SmallMeshScreenPercentage;

		[SerializeField]
		private bool m_GPUResidentDrawerEnableOcclusionCullingInCameras;

		[SerializeField]
		private ShadowQuality m_ShadowType;

		[SerializeField]
		private bool m_LocalShadowsSupported;

		[SerializeField]
		private ShadowResolution m_LocalShadowsAtlasResolution;

		[SerializeField]
		private int m_MaxPixelLights;

		[SerializeField]
		private ShadowResolution m_ShadowAtlasResolution;

		[SerializeField]
		private VolumeFrameworkUpdateMode m_VolumeFrameworkUpdateMode;

		[SerializeField]
		private VolumeProfile m_VolumeProfile;

		public const int k_MinLutSize = 16;

		public const int k_MaxLutSize = 65;

		internal const int k_ShadowCascadeMinCount = 1;

		internal const int k_ShadowCascadeMaxCount = 4;

		public static readonly int AdditionalLightsDefaultShadowResolutionTierLow;

		public static readonly int AdditionalLightsDefaultShadowResolutionTierMedium;

		public static readonly int AdditionalLightsDefaultShadowResolutionTierHigh;

		private static string[] s_Names;

		private static int[] s_Values;

		private static GraphicsFormat[][] s_LightCookieFormatList;

		[SerializeField]
		[Obsolete("Kept for migration. #from(2023.3")]
		internal ProbeVolumeSceneData apvScenesData;

		private Shader m_DefaultShader;

		[SerializeField]
		private int m_ShaderVariantLogLevel;

		[Obsolete("This is obsolete, please use shadowCascadeCount instead. #from(2021.1)")]
		[SerializeField]
		private ShadowCascadesOption m_ShadowCascades;

		[Obsolete("Moved to UniversalRenderPipelineRuntimeTextures on GraphicsSettings. #from(2023.3)")]
		[SerializeField]
		private TextureResources m_Textures;

		GPUResidentDrawerSettings IGPUResidentRenderPipeline.gpuResidentDrawerSettings => default(GPUResidentDrawerSettings);

		public ReadOnlySpan<ScriptableRendererData> rendererDataList => default(ReadOnlySpan<ScriptableRendererData>);

		public ReadOnlySpan<ScriptableRenderer> renderers => default(ReadOnlySpan<ScriptableRenderer>);

		public bool isImmediateModeSupported => false;

		public ScriptableRenderer scriptableRenderer => null;

		internal ScriptableRendererData scriptableRendererData => null;

		internal GraphicsFormat additionalLightsCookieFormat => default(GraphicsFormat);

		internal Vector2Int additionalLightsCookieResolution => default(Vector2Int);

		internal int[] rendererIndexList => null;

		public bool supportsCameraDepthTexture
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool supportsCameraOpaqueTexture
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Downsampling opaqueDownsampling => default(Downsampling);

		public bool supportsTerrainHoles => false;

		public StoreActionsOptimization storeActionsOptimization
		{
			get
			{
				return default(StoreActionsOptimization);
			}
			set
			{
			}
		}

		public bool supportsHDR
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public HDRColorBufferPrecision hdrColorBufferPrecision
		{
			get
			{
				return default(HDRColorBufferPrecision);
			}
			set
			{
			}
		}

		public int msaaSampleCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public float renderScale
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool enableLODCrossFade => false;

		public LODCrossFadeDitheringType lodCrossFadeDitheringType => default(LODCrossFadeDitheringType);

		public UpscalingFilterSelection upscalingFilter
		{
			get
			{
				return default(UpscalingFilterSelection);
			}
			set
			{
			}
		}

		public string upscalerName => null;

		public bool fsrOverrideSharpness
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float fsrSharpness
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public ShEvalMode shEvalMode
		{
			get
			{
				return default(ShEvalMode);
			}
			internal set
			{
			}
		}

		public LightProbeSystem lightProbeSystem
		{
			get
			{
				return default(LightProbeSystem);
			}
			internal set
			{
			}
		}

		public ProbeVolumeTextureMemoryBudget probeVolumeMemoryBudget
		{
			get
			{
				return default(ProbeVolumeTextureMemoryBudget);
			}
			internal set
			{
			}
		}

		public ProbeVolumeBlendingTextureMemoryBudget probeVolumeBlendingMemoryBudget
		{
			get
			{
				return default(ProbeVolumeBlendingTextureMemoryBudget);
			}
			internal set
			{
			}
		}

		[Obsolete("This is obsolete, use supportProbeVolumeGPUStreaming instead. #from(2023.3)")]
		public bool supportProbeVolumeStreaming
		{
			get
			{
				return false;
			}
			internal set
			{
			}
		}

		public bool supportProbeVolumeGPUStreaming
		{
			get
			{
				return false;
			}
			internal set
			{
			}
		}

		public bool supportProbeVolumeDiskStreaming
		{
			get
			{
				return false;
			}
			internal set
			{
			}
		}

		public bool supportProbeVolumeScenarios
		{
			get
			{
				return false;
			}
			internal set
			{
			}
		}

		public bool supportProbeVolumeScenarioBlending
		{
			get
			{
				return false;
			}
			internal set
			{
			}
		}

		public ProbeVolumeSHBands probeVolumeSHBands
		{
			get
			{
				return default(ProbeVolumeSHBands);
			}
			internal set
			{
			}
		}

		public LightRenderingMode mainLightRenderingMode
		{
			get
			{
				return default(LightRenderingMode);
			}
			internal set
			{
			}
		}

		public bool supportsMainLightShadows
		{
			get
			{
				return false;
			}
			internal set
			{
			}
		}

		public int mainLightShadowmapResolution
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public LightRenderingMode additionalLightsRenderingMode
		{
			get
			{
				return default(LightRenderingMode);
			}
			internal set
			{
			}
		}

		public int maxAdditionalLightsCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool supportsAdditionalLightShadows
		{
			get
			{
				return false;
			}
			internal set
			{
			}
		}

		public int additionalLightsShadowmapResolution
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int additionalLightsShadowResolutionTierLow
		{
			get
			{
				return 0;
			}
			internal set
			{
			}
		}

		public int additionalLightsShadowResolutionTierMedium
		{
			get
			{
				return 0;
			}
			internal set
			{
			}
		}

		public int additionalLightsShadowResolutionTierHigh
		{
			get
			{
				return 0;
			}
			internal set
			{
			}
		}

		public bool reflectionProbeBlending
		{
			get
			{
				return false;
			}
			internal set
			{
			}
		}

		public bool reflectionProbeBoxProjection
		{
			get
			{
				return false;
			}
			internal set
			{
			}
		}

		public bool reflectionProbeAtlas
		{
			get
			{
				return false;
			}
			internal set
			{
			}
		}

		public float shadowDistance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public int shadowCascadeCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public float cascade2Split
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Vector2 cascade3Split
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public Vector3 cascade4Split
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public float cascadeBorder
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float shadowDepthBias
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float shadowNormalBias
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool supportsSoftShadows
		{
			get
			{
				return false;
			}
			internal set
			{
			}
		}

		internal SoftShadowQuality softShadowQuality
		{
			get
			{
				return default(SoftShadowQuality);
			}
			set
			{
			}
		}

		public bool supportsDynamicBatching
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool supportsMixedLighting => false;

		public bool supportsLightCookies => false;

		[Obsolete("This is obsolete, use useRenderingLayers instead. #from(2023.1) #breakingFrom(2023.1)", true)]
		public bool supportsLightLayers => false;

		public bool useRenderingLayers => false;

		public VolumeFrameworkUpdateMode volumeFrameworkUpdateMode => default(VolumeFrameworkUpdateMode);

		public VolumeProfile volumeProfile
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[Obsolete("PipelineDebugLevel is deprecated and replaced to use the profiler. Calling debugLevel is not necessary. #from(2022.2) #breakingFrom(2023.1)", true)]
		public PipelineDebugLevel debugLevel => default(PipelineDebugLevel);

		public bool useSRPBatcher
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[Obsolete("This has been deprecated, please use GraphicsSettings.GetRenderPipelineSettings<RenderGraphSettings>().enableRenderCompatibilityMode instead. #from(2023.3)")]
		public bool enableRenderGraph => false;

		public ColorGradingMode colorGradingMode
		{
			get
			{
				return default(ColorGradingMode);
			}
			set
			{
			}
		}

		public int colorGradingLutSize
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool allowPostProcessAlphaOutput => false;

		public bool useFastSRGBLinearConversion => false;

		public bool supportScreenSpaceLensFlare => false;

		public bool supportDataDrivenLensFlare => false;

		public bool useAdaptivePerformance
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool conservativeEnclosingSphere
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int numIterationsEnclosingSphere
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public override string renderPipelineShaderTag => null;

		protected override bool requiresCompatibleRenderPipelineGlobalSettings => false;

		[Obsolete("This property is obsolete. Use RenderingLayerMask API and Tags & Layers project settings instead. #from(2023.3)")]
		public override string[] renderingLayerMaskNames => null;

		[Obsolete("This property is obsolete. Use RenderingLayerMask API and Tags & Layers project settings instead. #from(2023.3)")]
		public override string[] prefixedRenderingLayerMaskNames => null;

		[Obsolete("This is obsolete, please use renderingLayerMaskNames instead. #from(2023.1) #breakingFrom(2023.1)", true)]
		public string[] lightLayerMaskNames => null;

		public GPUResidentDrawerMode gpuResidentDrawerMode
		{
			get
			{
				return default(GPUResidentDrawerMode);
			}
			set
			{
			}
		}

		public bool gpuResidentDrawerEnableOcclusionCullingInCameras
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float smallMeshScreenPercentage
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool supportProbeVolume => false;

		public ProbeVolumeSHBands maxSHBands => default(ProbeVolumeSHBands);

		[Obsolete("This property is no longer necessary. #from(2023.3)")]
		public ProbeVolumeSceneData probeVolumeSceneData => null;

		public bool isStpUsed => false;

		public override Material defaultMaterial => null;

		public override Material defaultParticleMaterial => null;

		public override Material defaultLineMaterial => null;

		public override Material defaultTerrainMaterial => null;

		public override Material default2DMaterial => null;

		public override Material default2DMaskMaterial => null;

		public Material decalMaterial => null;

		public override Shader defaultShader => null;

		public override Shader terrainDetailLitShader => null;

		public override Shader terrainDetailGrassShader => null;

		public override Shader terrainDetailGrassBillboardShader => null;

		[Obsolete("Use GraphicsSettings.GetRenderPipelineSettings<ShaderStrippingSetting>().shaderVariantLogLevel instead. #from(2022.2)")]
		public ShaderVariantLogLevel shaderVariantLogLevel
		{
			get
			{
				return default(ShaderVariantLogLevel);
			}
			set
			{
			}
		}

		[Obsolete("This is obsolete, please use shadowCascadeCount instead. #from(2021.1) #breakingFrom(2023.1)", true)]
		public ShadowCascadesOption shadowCascadeOption
		{
			get
			{
				return default(ShadowCascadesOption);
			}
			set
			{
			}
		}

		[Obsolete("Moved to UniversalRenderPipelineRuntimeTextures on GraphicsSettings. #from(2023.3)")]
		public TextureResources textures => null;

		[Obsolete("This property is not used. #from(6000.3)", false)]
		public IntermediateTextureMode intermediateTextureMode
		{
			get
			{
				return default(IntermediateTextureMode);
			}
			set
			{
			}
		}

		internal bool IsAtLastVersion()
		{
			return false;
		}

		public ScriptableRendererData LoadBuiltinRendererData(RendererType type = RendererType.UniversalRenderer)
		{
			return null;
		}

		protected override void EnsureGlobalSettings()
		{
		}

		protected override RenderPipeline CreatePipeline()
		{
			return null;
		}

		internal void DestroyRenderers()
		{
		}

		private void DestroyRenderer(ref ScriptableRenderer renderer)
		{
		}

		protected override void OnDisable()
		{
		}

		private void CreateRenderers()
		{
		}

		public ScriptableRenderer GetRenderer(int index)
		{
			return null;
		}

		internal int GetAdditionalLightsShadowResolution(int additionalLightsShadowResolutionTier)
		{
			return 0;
		}

		internal bool ShouldUseReflectionProbeBlending()
		{
			return false;
		}

		internal bool ShouldUseReflectionProbeAtlasBlending(RenderingMode renderingMode)
		{
			return false;
		}

		internal void OnEnableRenderGraphChanged()
		{
		}

		public bool IsGPUResidentDrawerSupportedBySRP(out string message, out LogType severity)
		{
			message = null;
			severity = default(LogType);
			return false;
		}

		public void OnBeforeSerialize()
		{
		}

		public void OnAfterDeserialize()
		{
		}

		private float ValidateShadowBias(float value)
		{
			return 0f;
		}

		private int ValidatePerObjectLights(int value)
		{
			return 0;
		}

		private float ValidateRenderScale(float value)
		{
			return 0f;
		}

		internal bool ValidateRendererDataList(bool partial = false)
		{
			return false;
		}

		internal bool ValidateRendererData(int index)
		{
			return false;
		}

		private Material GetMaterial(DefaultMaterialType materialType)
		{
			return null;
		}
	}
}
