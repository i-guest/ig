using System;
using UnityEngine.Categorization;

namespace UnityEngine.Rendering.Universal
{
	[Serializable]
	[SupportedOnRenderPipeline(typeof(UniversalRenderPipelineAsset))]
	[CategoryInfo(Name = "R: Runtime XR", Order = 1000)]
	[HideInInspector]
	public class UniversalRenderPipelineRuntimeXRResources : IRenderPipelineResources, IRenderPipelineGraphicsSettings
	{
		[SerializeField]
		[ResourcePath("Shaders/XR/XROcclusionMesh.shader", SearchType.ProjectPath)]
		private Shader m_xrOcclusionMeshPS;

		[SerializeField]
		[ResourcePath("Shaders/XR/XRMirrorView.shader", SearchType.ProjectPath)]
		private Shader m_xrMirrorViewPS;

		[SerializeField]
		[ResourcePath("Shaders/XR/XRMotionVector.shader", SearchType.ProjectPath)]
		private Shader m_xrMotionVector;

		public int version => 0;

		bool IRenderPipelineGraphicsSettings.isAvailableInPlayerBuild => false;

		public Shader xrOcclusionMeshPS
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Shader xrMirrorViewPS
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Shader xrMotionVector
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool valid => false;
	}
}
