using System;
using UnityEngine.Categorization;

namespace UnityEngine.Rendering.Universal
{
	[Serializable]
	[SupportedOnRenderPipeline(typeof(UniversalRenderPipelineAsset))]
	[CategoryInfo(Name = "R: Runtime Shaders", Order = 1000)]
	[HideInInspector]
	public class UniversalRenderPipelineRuntimeShaders : IRenderPipelineResources, IRenderPipelineGraphicsSettings
	{
		[SerializeField]
		[HideInInspector]
		private int m_Version;

		[SerializeField]
		[ResourcePath("Shaders/Utils/FallbackError.shader", SearchType.ProjectPath)]
		private Shader m_FallbackErrorShader;

		[SerializeField]
		[ResourcePath("Shaders/Utils/BlitHDROverlay.shader", SearchType.ProjectPath)]
		internal Shader m_BlitHDROverlay;

		[SerializeField]
		[ResourcePath("Shaders/Utils/CoreBlit.shader", SearchType.ProjectPath)]
		internal Shader m_CoreBlitPS;

		[SerializeField]
		[ResourcePath("Shaders/Utils/CoreBlitColorAndDepth.shader", SearchType.ProjectPath)]
		internal Shader m_CoreBlitColorAndDepthPS;

		[SerializeField]
		[ResourcePath("Shaders/Utils/Sampling.shader", SearchType.ProjectPath)]
		private Shader m_SamplingPS;

		[Header("Terrain")]
		[SerializeField]
		[ResourcePath("Shaders/Terrain/TerrainDetailLit.shader", SearchType.ProjectPath)]
		private Shader m_TerrainDetailLit;

		[SerializeField]
		[ResourcePath("Shaders/Terrain/WavingGrassBillboard.shader", SearchType.ProjectPath)]
		private Shader m_TerrainDetailGrassBillboard;

		[SerializeField]
		[ResourcePath("Shaders/Terrain/WavingGrass.shader", SearchType.ProjectPath)]
		private Shader m_TerrainDetailGrass;

		public int version => 0;

		bool IRenderPipelineGraphicsSettings.isAvailableInPlayerBuild => false;

		public Shader fallbackErrorShader
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Shader blitHDROverlay
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Shader coreBlitPS
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Shader coreBlitColorAndDepthPS
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Shader samplingPS
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Shader terrainDetailLitShader
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Shader terrainDetailGrassBillboardShader
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Shader terrainDetailGrassShader
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
