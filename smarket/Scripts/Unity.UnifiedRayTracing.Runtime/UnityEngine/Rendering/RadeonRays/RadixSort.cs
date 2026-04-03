namespace UnityEngine.Rendering.RadeonRays
{
	internal class RadixSort
	{
		private readonly ComputeShader shaderBitHistogram;

		private readonly int kernelBitHistogram;

		private readonly ComputeShader shaderScatter;

		private readonly int kernelScatter;

		private readonly Scan scan;

		private const uint kKeysPerThread = 4u;

		private const uint kGroupSize = 256u;

		private const uint kKeysPerGroup = 1024u;

		private const int kNumBitsPerPass = 4;

		public RadixSort(RadeonRaysShaders shaders)
		{
		}

		public void Execute(CommandBuffer cmd, GraphicsBuffer buffer, uint inputKeysOffset, uint outputKeysOffset, uint inputValuesOffset, uint outputValuesOffset, uint scratchDataOffset, uint size)
		{
		}

		public static ulong GetScratchDataSizeInDwords(uint size)
		{
			return 0uL;
		}
	}
}
