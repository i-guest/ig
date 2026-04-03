using System;

namespace UnityEngine.Rendering
{
	internal class VrsResources : IDisposable
	{
		internal ProfilingSampler conversionProfilingSampler;

		internal ProfilingSampler visualizationProfilingSampler;

		internal GraphicsBuffer conversionLutBuffer;

		internal GraphicsBuffer visualizationLutBuffer;

		internal ComputeShader textureComputeShader;

		internal int textureReduceKernel;

		internal int textureCopyKernel;

		internal Vector2Int tileSize;

		internal GraphicsBuffer validatedShadingRateFragmentSizeBuffer;

		private Shader m_VisualizationShader;

		private Material m_VisualizationMaterial;

		internal Material visualizationMaterial => null;

		internal VrsResources(VrsRenderPipelineRuntimeResources resources)
		{
		}

		~VrsResources()
		{
		}

		public void Dispose()
		{
		}

		private void InitializeResources(VrsRenderPipelineRuntimeResources resources)
		{
		}

		private void DisposeResources()
		{
		}

		private void AllocFragmentSizeBuffer()
		{
		}

		private bool InitComputeShader(VrsRenderPipelineRuntimeResources resources)
		{
			return false;
		}

		private static int TryFindKernel(ComputeShader computeShader, string name)
		{
			return 0;
		}
	}
}
