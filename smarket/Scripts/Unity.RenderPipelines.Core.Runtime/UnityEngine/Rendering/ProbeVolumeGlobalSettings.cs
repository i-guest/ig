using System;
using UnityEngine.Categorization;

namespace UnityEngine.Rendering
{
	[Serializable]
	[SupportedOnRenderPipeline(new Type[] { })]
	[CategoryInfo(Name = "Lighting", Order = 20)]
	internal class ProbeVolumeGlobalSettings : IRenderPipelineGraphicsSettings
	{
		[SerializeField]
		[HideInInspector]
		private int m_Version;

		[SerializeField]
		[Tooltip("Enabling this will make APV baked data assets compatible with Addressables and Asset Bundles. This will also make Disk Streaming unavailable. After changing this setting, a clean rebuild may be required for data assets to be included in Adressables and Asset Bundles.")]
		private bool m_ProbeVolumeDisableStreamingAssets;

		public int version => 0;

		public bool probeVolumeDisableStreamingAssets
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
