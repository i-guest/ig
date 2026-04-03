using System;
using UnityEngine.Categorization;

namespace UnityEngine.Rendering
{
	[Serializable]
	[SupportedOnRenderPipeline(new Type[] { })]
	[CategoryInfo(Name = "Lighting", Order = 20)]
	public class LightmapSamplingSettings : IRenderPipelineGraphicsSettings
	{
		[SerializeField]
		[HideInInspector]
		private int m_Version;

		[SerializeField]
		[Tooltip("Use Bicubic Lightmap Sampling. Enabling this will improve the appearance of lightmaps, but may worsen performance on lower end platforms.")]
		private bool m_UseBicubicLightmapSampling;

		int IRenderPipelineGraphicsSettings.version => 0;

		bool IRenderPipelineGraphicsSettings.isAvailableInPlayerBuild => false;

		public bool useBicubicLightmapSampling
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
