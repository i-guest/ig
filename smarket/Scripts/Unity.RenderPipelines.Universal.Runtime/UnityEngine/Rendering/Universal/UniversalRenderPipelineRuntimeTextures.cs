using System;
using UnityEngine.Categorization;

namespace UnityEngine.Rendering.Universal
{
	[Serializable]
	[SupportedOnRenderPipeline(typeof(UniversalRenderPipelineAsset))]
	[CategoryInfo(Name = "R: Runtime Textures", Order = 1000)]
	[HideInInspector]
	public class UniversalRenderPipelineRuntimeTextures : IRenderPipelineResources, IRenderPipelineGraphicsSettings
	{
		[SerializeField]
		[HideInInspector]
		private int m_Version;

		[SerializeField]
		[ResourcePath("Textures/BlueNoise64/L/LDR_LLL1_0.png", SearchType.ProjectPath)]
		private Texture2D m_BlueNoise64LTex;

		[SerializeField]
		[ResourcePath("Textures/BayerMatrix.png", SearchType.ProjectPath)]
		private Texture2D m_BayerMatrixTex;

		[SerializeField]
		[ResourcePath("Textures/DebugFont.tga", SearchType.ProjectPath)]
		private Texture2D m_DebugFontTex;

		private Texture2D m_StencilDitherTex;

		public int version => 0;

		bool IRenderPipelineGraphicsSettings.isAvailableInPlayerBuild => false;

		public Texture2D blueNoise64LTex
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Texture2D bayerMatrixTex
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Texture2D debugFontTexture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Texture2D stencilDitherTex => null;
	}
}
