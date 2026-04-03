using System;
using UnityEngine.Categorization;

namespace UnityEngine.Rendering.Universal
{
	[Serializable]
	[SupportedOnRenderPipeline(typeof(UniversalRenderPipelineAsset))]
	[CategoryInfo(Name = "R: 2D Renderer", Order = 1000)]
	[HideInInspector]
	internal class Renderer2DResources : IRenderPipelineResources, IRenderPipelineGraphicsSettings
	{
		[SerializeField]
		[HideInInspector]
		private int m_Version;

		[SerializeField]
		[ResourcePath("Shaders/2D/Light2D.shader", SearchType.ProjectPath)]
		private Shader m_LightShader;

		[SerializeField]
		[ResourcePath("Shaders/2D/Shadow2D-Projected.shader", SearchType.ProjectPath)]
		private Shader m_ProjectedShadowShader;

		[SerializeField]
		[ResourcePath("Shaders/2D/Shadow2D-Shadow-Sprite.shader", SearchType.ProjectPath)]
		private Shader m_SpriteShadowShader;

		[SerializeField]
		[ResourcePath("Shaders/2D/Shadow2D-Unshadow-Sprite.shader", SearchType.ProjectPath)]
		private Shader m_SpriteUnshadowShader;

		[SerializeField]
		[ResourcePath("Shaders/2D/Shadow2D-Shadow-Geometry.shader", SearchType.ProjectPath)]
		private Shader m_GeometryShadowShader;

		[SerializeField]
		[ResourcePath("Shaders/2D/Shadow2D-Unshadow-Geometry.shader", SearchType.ProjectPath)]
		private Shader m_GeometryUnshadowShader;

		[SerializeField]
		[ResourcePath("Runtime/2D/Data/Textures/FalloffLookupTexture.png", SearchType.ProjectPath)]
		[HideInInspector]
		private Texture2D m_FallOffLookup;

		[SerializeField]
		[ResourcePath("Shaders/Utils/CopyDepth.shader", SearchType.ProjectPath)]
		private Shader m_CopyDepthPS;

		public int version => 0;

		bool IRenderPipelineGraphicsSettings.isAvailableInPlayerBuild => false;

		internal Shader lightShader
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal Shader projectedShadowShader
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal Shader spriteShadowShader
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal Shader spriteUnshadowShader
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal Shader geometryShadowShader
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal Shader geometryUnshadowShader
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal Texture2D fallOffLookup
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal Shader copyDepthPS
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
