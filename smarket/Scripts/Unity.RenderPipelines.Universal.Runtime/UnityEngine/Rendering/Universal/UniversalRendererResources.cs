using System;
using UnityEngine.Categorization;

namespace UnityEngine.Rendering.Universal
{
	[Serializable]
	[SupportedOnRenderPipeline(typeof(UniversalRenderPipelineAsset))]
	[CategoryInfo(Name = "R: Universal Renderer Shaders", Order = 1000)]
	[HideInInspector]
	public class UniversalRendererResources : IRenderPipelineResources, IRenderPipelineGraphicsSettings
	{
		[SerializeField]
		[HideInInspector]
		private int m_Version;

		[SerializeField]
		[ResourcePath("Shaders/Utils/CopyDepth.shader", SearchType.ProjectPath)]
		private Shader m_CopyDepthPS;

		[SerializeField]
		[ResourcePath("Shaders/CameraMotionVectors.shader", SearchType.ProjectPath)]
		private Shader m_CameraMotionVector;

		[SerializeField]
		[ResourcePath("Shaders/Utils/StencilDeferred.shader", SearchType.ProjectPath)]
		private Shader m_StencilDeferredPS;

		[SerializeField]
		[ResourcePath("Shaders/Utils/ClusterDeferred.shader", SearchType.ProjectPath)]
		private Shader m_ClusterDeferred;

		[SerializeField]
		[ResourcePath("Shaders/Utils/StencilDitherMaskSeed.shader", SearchType.ProjectPath)]
		private Shader m_StencilDitherMaskSeedPS;

		[Header("Decal Renderer Feature Specific")]
		[SerializeField]
		[ResourcePath("Runtime/Decal/DBuffer/DBufferClear.shader", SearchType.ProjectPath)]
		private Shader m_DBufferClear;

		public int version => 0;

		bool IRenderPipelineGraphicsSettings.isAvailableInPlayerBuild => false;

		public Shader copyDepthPS
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Shader cameraMotionVector
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Shader stencilDeferredPS
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Shader clusterDeferred
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Shader stencilDitherMaskSeedPS
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Shader decalDBufferClear
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
