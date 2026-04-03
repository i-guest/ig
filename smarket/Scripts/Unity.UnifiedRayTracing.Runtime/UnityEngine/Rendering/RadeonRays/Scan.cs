namespace UnityEngine.Rendering.RadeonRays
{
	internal class Scan
	{
		private readonly ComputeShader shaderScan;

		private readonly int kernelScan;

		private readonly ComputeShader shaderReduce;

		private readonly int kernelReduce;

		private const uint kKeysPerThread = 4u;

		private const uint kGroupSize = 256u;

		private const uint kKeysPerGroup = 1024u;

		public Scan(RadeonRaysShaders shaders)
		{
		}

		public void Execute(CommandBuffer cmd, GraphicsBuffer buffer, uint inputKeysOffset, uint outputKeysOffset, uint scratchDataOffset, uint size)
		{
		}

		private void SetState(CommandBuffer cmd, ComputeShader shader, int kernelIndex, uint size, GraphicsBuffer buffer, uint inputKeysOffset, uint scratchDataOffset, uint outputKeysOffset)
		{
		}

		public static ulong GetScratchDataSizeInDwords(uint size)
		{
			return 0uL;
		}
	}
}
