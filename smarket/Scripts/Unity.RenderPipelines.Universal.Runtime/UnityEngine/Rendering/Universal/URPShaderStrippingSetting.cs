using System;
using UnityEngine.Categorization;

namespace UnityEngine.Rendering.Universal
{
	[Serializable]
	[SupportedOnRenderPipeline(typeof(UniversalRenderPipelineAsset))]
	[CategoryInfo(Name = "Additional Shader Stripping Settings", Order = 40)]
	[ElementInfo(Order = 10)]
	public class URPShaderStrippingSetting : IRenderPipelineGraphicsSettings
	{
		internal enum Version
		{
			Initial = 0
		}

		[SerializeField]
		[HideInInspector]
		private Version m_Version;

		[SerializeField]
		[Tooltip("Controls whether to automatically strip post processing shader variants based on VolumeProfile components. Stripping is done based on VolumeProfiles in project, their usage in scenes is not considered.")]
		private bool m_StripUnusedPostProcessingVariants;

		[SerializeField]
		[Tooltip("Controls whether to strip variants if the feature is disabled.")]
		private bool m_StripUnusedVariants;

		[SerializeField]
		[Tooltip("Controls whether Screen Coordinates Override shader variants are automatically stripped.")]
		private bool m_StripScreenCoordOverrideVariants;

		public int version => 0;

		public bool stripUnusedPostProcessingVariants
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool stripUnusedVariants
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool stripScreenCoordOverrideVariants
		{
			get
			{
				return false;
			}
			set
			{
			}
		}
	}
}
