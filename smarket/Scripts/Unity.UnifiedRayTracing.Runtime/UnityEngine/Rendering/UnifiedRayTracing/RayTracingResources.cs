namespace UnityEngine.Rendering.UnifiedRayTracing
{
	public class RayTracingResources
	{
		internal ComputeShader geometryPoolKernels { get; set; }

		internal ComputeShader copyBuffer { get; set; }

		internal ComputeShader copyPositions { get; set; }

		internal ComputeShader bitHistogram { get; set; }

		internal ComputeShader blockReducePart { get; set; }

		internal ComputeShader blockScan { get; set; }

		internal ComputeShader buildHlbvh { get; set; }

		internal ComputeShader restructureBvh { get; set; }

		internal ComputeShader scatter { get; set; }

		public void LoadFromAssetBundle(AssetBundle assetBundle)
		{
		}

		public bool LoadFromRenderPipelineResources()
		{
			return false;
		}
	}
}
