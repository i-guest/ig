using System;

namespace UnityEngine.Rendering
{
	internal struct GPUInstanceDataBufferGrower : IDisposable
	{
		private static class CopyInstancesKernelIDs
		{
			public static readonly int _InputValidComponentCounts;

			public static readonly int _InstanceCounts;

			public static readonly int _InstanceOffset;

			public static readonly int _OutputInstanceOffset;

			public static readonly int _ValidComponentIndices;

			public static readonly int _ComponentByteCounts;

			public static readonly int _InputComponentAddresses;

			public static readonly int _OutputComponentAddresses;

			public static readonly int _InputComponentInstanceIndexRanges;

			public static readonly int _InputBuffer;

			public static readonly int _OutputBuffer;
		}

		public struct GPUResources : IDisposable
		{
			public ComputeShader cs;

			public int kernelId;

			public void LoadShaders(GPUResidentDrawerResources resources)
			{
			}

			public void CreateResources()
			{
			}

			public void Dispose()
			{
			}
		}

		private GPUInstanceDataBuffer m_SrcBuffer;

		private GPUInstanceDataBuffer m_DstBuffer;

		public GPUInstanceDataBufferGrower(GPUInstanceDataBuffer sourceBuffer, in InstanceNumInfo instanceNumInfo)
		{
			m_SrcBuffer = null;
			m_DstBuffer = null;
		}

		public GPUInstanceDataBuffer SubmitToGpu(ref GPUResources gpuResources)
		{
			return null;
		}

		public void Dispose()
		{
		}
	}
}
