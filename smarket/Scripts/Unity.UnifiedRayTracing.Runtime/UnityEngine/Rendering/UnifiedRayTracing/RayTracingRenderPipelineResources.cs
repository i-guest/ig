using System;
using UnityEngine.Categorization;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Rendering.UnifiedRayTracing
{
	[Serializable]
	[MovedFrom(true, "UnityEngine.Rendering.UnifiedRayTracing", "Unity.Rendering.LightTransport.Runtime", null)]
	[SupportedOnRenderPipeline(new Type[] { })]
	[CategoryInfo(Name = "R: Unified Ray Tracing", Order = 1000)]
	[HideInInspector]
	internal class RayTracingRenderPipelineResources : IRenderPipelineResources, IRenderPipelineGraphicsSettings
	{
		[SerializeField]
		[HideInInspector]
		private int m_Version;

		[SerializeField]
		[ResourcePath("Runtime/UnifiedRayTracing/Common/GeometryPool/GeometryPoolKernels.compute", SearchType.ProjectPath)]
		private ComputeShader m_GeometryPoolKernels;

		[SerializeField]
		[ResourcePath("Runtime/UnifiedRayTracing/Common/Utilities/CopyBuffer.compute", SearchType.ProjectPath)]
		private ComputeShader m_CopyBuffer;

		[SerializeField]
		[ResourcePath("Runtime/UnifiedRayTracing/Compute/RadeonRays/kernels/copyPositions.compute", SearchType.ProjectPath)]
		private ComputeShader m_CopyPositions;

		[SerializeField]
		[ResourcePath("Runtime/UnifiedRayTracing/Compute/RadeonRays/kernels/bit_histogram.compute", SearchType.ProjectPath)]
		private ComputeShader m_BitHistogram;

		[SerializeField]
		[ResourcePath("Runtime/UnifiedRayTracing/Compute/RadeonRays/kernels/block_reduce_part.compute", SearchType.ProjectPath)]
		private ComputeShader m_BlockReducePart;

		[SerializeField]
		[ResourcePath("Runtime/UnifiedRayTracing/Compute/RadeonRays/kernels/block_scan.compute", SearchType.ProjectPath)]
		private ComputeShader m_BlockScan;

		[SerializeField]
		[ResourcePath("Runtime/UnifiedRayTracing/Compute/RadeonRays/kernels/build_hlbvh.compute", SearchType.ProjectPath)]
		private ComputeShader m_BuildHlbvh;

		[SerializeField]
		[ResourcePath("Runtime/UnifiedRayTracing/Compute/RadeonRays/kernels/restructure_bvh.compute", SearchType.ProjectPath)]
		private ComputeShader m_RestructureBvh;

		[SerializeField]
		[ResourcePath("Runtime/UnifiedRayTracing/Compute/RadeonRays/kernels/scatter.compute", SearchType.ProjectPath)]
		private ComputeShader m_Scatter;

		public int version => 0;

		public ComputeShader GeometryPoolKernels
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ComputeShader CopyBuffer
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ComputeShader CopyPositions
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ComputeShader BitHistogram
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ComputeShader BlockReducePart
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ComputeShader BlockScan
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ComputeShader BuildHlbvh
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ComputeShader RestructureBvh
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ComputeShader Scatter
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
