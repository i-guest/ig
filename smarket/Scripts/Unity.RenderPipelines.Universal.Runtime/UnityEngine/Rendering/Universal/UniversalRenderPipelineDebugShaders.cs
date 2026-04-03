using System;
using UnityEngine.Categorization;

namespace UnityEngine.Rendering.Universal
{
	[Serializable]
	[SupportedOnRenderPipeline(typeof(UniversalRenderPipelineAsset))]
	[CategoryInfo(Name = "R: Debug Shaders", Order = 1000)]
	[HideInInspector]
	public class UniversalRenderPipelineDebugShaders : IRenderPipelineResources, IRenderPipelineGraphicsSettings
	{
		[SerializeField]
		[ResourcePath("Shaders/Debug/DebugReplacement.shader", SearchType.ProjectPath)]
		private Shader m_DebugReplacementPS;

		[SerializeField]
		[ResourcePath("Shaders/Debug/HDRDebugView.shader", SearchType.ProjectPath)]
		private Shader m_HdrDebugViewPS;

		[SerializeField]
		[ResourcePath("Shaders/Debug/ProbeVolumeSamplingDebugPositionNormal.compute", SearchType.ProjectPath)]
		private ComputeShader m_ProbeVolumeSamplingDebugComputeShader;

		public int version => 0;

		bool IRenderPipelineGraphicsSettings.isAvailableInPlayerBuild => false;

		public Shader debugReplacementPS
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Shader hdrDebugViewPS
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ComputeShader probeVolumeSamplingDebugComputeShader
		{
			get
			{
				return null;
			}
			set
			{
			}
		}
	}
}
