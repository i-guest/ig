using System;
using UnityEngine.Categorization;

namespace UnityEngine.Rendering
{
	[Serializable]
	[SupportedOnRenderPipeline(new Type[] { })]
	[CategoryInfo(Name = "Render Graph", Order = 50)]
	[ElementInfo(Order = 0)]
	public class RenderGraphGlobalSettings : IRenderPipelineGraphicsSettings
	{
		private enum Version
		{
			Initial = 0,
			Count = 1,
			Last = 0
		}

		[SerializeField]
		[HideInInspector]
		private Version m_version;

		[RecreatePipelineOnChange]
		[SerializeField]
		[Tooltip("Enable caching of render graph compilation from one frame to another.")]
		private bool m_EnableCompilationCaching;

		[RecreatePipelineOnChange]
		[SerializeField]
		[Tooltip("Enable validity checks of render graph in Editor and Development mode. Always disabled in Release build.")]
		private bool m_EnableValidityChecks;

		bool IRenderPipelineGraphicsSettings.isAvailableInPlayerBuild => false;

		int IRenderPipelineGraphicsSettings.version => 0;

		public bool enableCompilationCaching
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool enableValidityChecks
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
