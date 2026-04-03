using System;
using UnityEngine.Categorization;

namespace UnityEngine.Rendering
{
	[Serializable]
	[SupportedOnRenderPipeline(new Type[] { })]
	[CategoryInfo(Name = "VRS - Runtime Resources", Order = 1000)]
	public sealed class VrsRenderPipelineRuntimeResources : IRenderPipelineResources, IRenderPipelineGraphicsSettings
	{
		[SerializeField]
		[Tooltip("Compute shader used for converting textures to shading rate values")]
		[ResourcePath("Runtime/Vrs/Shaders/VrsTexture.compute", SearchType.ProjectPath)]
		private ComputeShader m_TextureComputeShader;

		[SerializeField]
		[Tooltip("Shader used when visualizing shading rate values as a color image")]
		[ResourcePath("Runtime/Vrs/Shaders/VrsVisualization.shader", SearchType.ProjectPath)]
		private Shader m_VisualizationShader;

		[SerializeField]
		[Tooltip("Colors to visualize the shading rates")]
		private VrsLut m_VisualizationLookupTable;

		[SerializeField]
		[Tooltip("Colors to convert between shading rates and textures")]
		private VrsLut m_ConversionLookupTable;

		public int version => 0;

		bool IRenderPipelineGraphicsSettings.isAvailableInPlayerBuild => false;

		public ComputeShader textureComputeShader
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Shader visualizationShader
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public VrsLut visualizationLookupTable
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public VrsLut conversionLookupTable
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
