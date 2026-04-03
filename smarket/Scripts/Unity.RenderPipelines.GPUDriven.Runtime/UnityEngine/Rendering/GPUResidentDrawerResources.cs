using System;
using UnityEngine.Categorization;

namespace UnityEngine.Rendering
{
	[Serializable]
	[SupportedOnRenderPipeline(new Type[] { })]
	[CategoryInfo(Name = "R: GPU Resident Drawers", Order = 1000)]
	[HideInInspector]
	internal class GPUResidentDrawerResources : IRenderPipelineResources, IRenderPipelineGraphicsSettings
	{
		public enum Version
		{
			Initial = 0,
			Count = 1,
			Latest = 0
		}

		[SerializeField]
		[HideInInspector]
		private Version m_Version;

		[SerializeField]
		[ResourcePath("Runtime/RenderPipelineResources/GPUDriven/InstanceDataBufferCopyKernels.compute", SearchType.ProjectPath)]
		private ComputeShader m_InstanceDataBufferCopyKernels;

		[SerializeField]
		[ResourcePath("Runtime/RenderPipelineResources/GPUDriven/InstanceDataBufferUploadKernels.compute", SearchType.ProjectPath)]
		private ComputeShader m_InstanceDataBufferUploadKernels;

		[SerializeField]
		[ResourcePath("Runtime/RenderPipelineResources/GPUDriven/InstanceTransformUpdateKernels.compute", SearchType.ProjectPath)]
		private ComputeShader m_TransformUpdaterKernels;

		[SerializeField]
		[ResourcePath("Runtime/RenderPipelineResources/GPUDriven/InstanceWindDataUpdateKernels.compute", SearchType.ProjectPath)]
		public ComputeShader m_WindDataUpdaterKernels;

		[SerializeField]
		[ResourcePath("Runtime/RenderPipelineResources/GPUDriven/OccluderDepthPyramidKernels.compute", SearchType.ProjectPath)]
		private ComputeShader m_OccluderDepthPyramidKernels;

		[SerializeField]
		[ResourcePath("Runtime/RenderPipelineResources/GPUDriven/InstanceOcclusionCullingKernels.compute", SearchType.ProjectPath)]
		private ComputeShader m_InstanceOcclusionCullingKernels;

		[SerializeField]
		[ResourcePath("Runtime/RenderPipelineResources/GPUDriven/OcclusionCullingDebug.compute", SearchType.ProjectPath)]
		private ComputeShader m_OcclusionCullingDebugKernels;

		[SerializeField]
		[ResourcePath("Runtime/RenderPipelineResources/GPUDriven/DebugOcclusionTest.shader", SearchType.ProjectPath)]
		private Shader m_DebugOcclusionTestPS;

		[SerializeField]
		[ResourcePath("Runtime/RenderPipelineResources/GPUDriven/DebugOccluder.shader", SearchType.ProjectPath)]
		private Shader m_DebugOccluderPS;

		int IRenderPipelineGraphicsSettings.version => 0;

		public ComputeShader instanceDataBufferCopyKernels
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ComputeShader instanceDataBufferUploadKernels
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ComputeShader transformUpdaterKernels
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ComputeShader windDataUpdaterKernels
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ComputeShader occluderDepthPyramidKernels
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ComputeShader instanceOcclusionCullingKernels
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ComputeShader occlusionCullingDebugKernels
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Shader debugOcclusionTestPS
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Shader debugOccluderPS
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
