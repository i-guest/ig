using System;
using UnityEngine.Categorization;

namespace UnityEngine.Rendering.Universal
{
	[Serializable]
	[SupportedOnRenderPipeline(typeof(UniversalRenderPipelineAsset))]
	[CategoryInfo(Name = "R: SSAO Shader", Order = 1000)]
	[ElementInfo(Order = 0)]
	[HideInInspector]
	internal class ScreenSpaceAmbientOcclusionPersistentResources : IRenderPipelineResources, IRenderPipelineGraphicsSettings
	{
		[SerializeField]
		[ResourcePath("Shaders/Utils/ScreenSpaceAmbientOcclusion.shader", SearchType.ProjectPath)]
		private Shader m_Shader;

		[SerializeField]
		[HideInInspector]
		private int m_Version;

		public Shader Shader
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool isAvailableInPlayerBuild => false;

		public int version => 0;
	}
}
