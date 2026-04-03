using System;
using UnityEngine.Categorization;

namespace UnityEngine.Rendering.Universal
{
	[Serializable]
	[SupportedOnRenderPipeline(typeof(UniversalRenderPipelineAsset))]
	[CategoryInfo(Name = "Render Graph", Order = 50)]
	[ElementInfo(Order = -10)]
	public class RenderGraphSettings : IRenderPipelineGraphicsSettings
	{
		internal enum Version
		{
			Initial = 0
		}

		[SerializeField]
		[HideInInspector]
		private Version m_Version;

		[SerializeField]
		[Tooltip("When enabled, URP does not use the Render Graph API to construct and execute the frame. Use this option only for compatibility purposes.")]
		[RecreatePipelineOnChange]
		private bool m_EnableRenderCompatibilityMode;

		public int version => 0;

		bool IRenderPipelineGraphicsSettings.isAvailableInPlayerBuild => false;

		public bool enableRenderCompatibilityMode
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal void SetCompatibilityModeFromUpgrade(bool value)
		{
		}
	}
}
