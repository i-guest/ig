using System;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine.Serialization;

namespace UnityEngine.Rendering.Universal
{
	[DisplayInfo(name = "URP Global Settings Asset", order = 40002)]
	[SupportedOnRenderPipeline(typeof(UniversalRenderPipelineAsset))]
	[DisplayName("URP")]
	internal class UniversalRenderPipelineGlobalSettings : RenderPipelineGlobalSettings<UniversalRenderPipelineGlobalSettings, UniversalRenderPipeline>
	{
		[SerializeField]
		[Obsolete("Keep for migration. #from(2023.2)")]
		internal ShaderStrippingSetting m_ShaderStrippingSetting;

		[SerializeField]
		[Obsolete("Keep for migration. #from(2023.2)")]
		internal URPShaderStrippingSetting m_URPShaderStrippingSetting;

		[SerializeField]
		[Obsolete("Keep for migration. #from(2023.2)")]
		internal UnityEngine.Rendering.ShaderVariantLogLevel m_ShaderVariantLogLevel;

		[SerializeField]
		[Obsolete("Keep for migration. #from(2023.2)")]
		internal bool m_ExportShaderVariants;

		[SerializeField]
		[Obsolete("Keep for migration. #from(2023.2)")]
		internal bool m_StripDebugVariants;

		[SerializeField]
		[Obsolete("Keep for migration. #from(2023.2)")]
		internal bool m_StripUnusedPostProcessingVariants;

		[SerializeField]
		[Obsolete("Keep for migration. #from(2023.2)")]
		internal bool m_StripUnusedVariants;

		[SerializeField]
		[Obsolete("Keep for migration. #from(2023.2)")]
		internal bool m_StripScreenCoordOverrideVariants;

		[Obsolete("Please use stripRuntimeDebugShaders instead. #from(2023.1)")]
		public bool supportRuntimeDebugDisplay;

		[SerializeField]
		[Obsolete("Keep for migration. #from(2023.2)")]
		internal bool m_EnableRenderGraph;

		[SerializeField]
		private RenderPipelineGraphicsSettingsContainer m_Settings;

		internal const int k_LastVersion = 9;

		[SerializeField]
		[FormerlySerializedAs("k_AssetVersion")]
		internal int m_AssetVersion;

		public const string defaultAssetName = "UniversalRenderPipelineGlobalSettings";

		[SerializeField]
		[FormerlySerializedAs("m_DefaultVolumeProfile")]
		[Obsolete("Kept For Migration. #from(2023.3)")]
		internal VolumeProfile m_ObsoleteDefaultVolumeProfile;

		[SerializeField]
		internal string[] m_RenderingLayerNames;

		[SerializeField]
		private uint m_ValidRenderingLayers;

		[Obsolete("This is obsolete, please use renderingLayerMaskNames instead. #from(2022.2)")]
		public string lightLayerName0;

		[Obsolete("This is obsolete, please use renderingLayerMaskNames instead. #from(2022.2)")]
		public string lightLayerName1;

		[Obsolete("This is obsolete, please use renderingLayerMaskNames instead. #from(2022.2)")]
		public string lightLayerName2;

		[Obsolete("This is obsolete, please use renderingLayerMaskNames instead. #from(2022.2)")]
		public string lightLayerName3;

		[Obsolete("This is obsolete, please use renderingLayerMaskNames instead. #from(2022.2)")]
		public string lightLayerName4;

		[Obsolete("This is obsolete, please use renderingLayerMaskNames instead. #from(2022.2)")]
		public string lightLayerName5;

		[Obsolete("This is obsolete, please use renderingLayerMaskNames instead. #from(2022.2)")]
		public string lightLayerName6;

		[Obsolete("This is obsolete, please use renderingLayerNames instead. #from(2022.2)")]
		public string lightLayerName7;

		[SerializeField]
		internal ProbeVolumeSceneData apvScenesData;

		[Obsolete("No longer used as Shader Prefiltering automatically strips out unused LOD Crossfade variants. Please use the LOD Crossfade setting in the URP Asset to disable the feature if not used. #from(2023.1)")]
		public bool stripUnusedLODCrossFadeVariants
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected override List<IRenderPipelineGraphicsSettings> settingsList => null;

		[Obsolete("This property is obsolete. Use RenderingLayerMask API and Tags & Layers project settings instead. #from(2022.2) #breackingFrom(2023.1)", true)]
		public string[] prefixedLightLayerNames => null;

		[Obsolete("This is obsolete, please use renderingLayerMaskNames instead. #from(2022.2)")]
		public string[] lightLayerNames => null;

		internal bool IsAtLastVersion()
		{
			return false;
		}

		public override void Reset()
		{
		}

		internal static VolumeProfile GetOrCreateDefaultVolumeProfile(VolumeProfile defaultVolumeProfile)
		{
			return null;
		}

		internal void ResetRenderingLayerNames()
		{
		}

		internal ProbeVolumeSceneData GetOrCreateAPVSceneData()
		{
			return null;
		}
	}
}
