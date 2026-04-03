using System;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;

namespace UnityEngine.Rendering
{
	internal struct GPUInstanceDataBufferUploader : IDisposable
	{
		private static class UploadKernelIDs
		{
			public static readonly int _InputValidComponentCounts;

			public static readonly int _InputInstanceCounts;

			public static readonly int _InputInstanceByteSize;

			public static readonly int _InputComponentOffsets;

			public static readonly int _InputInstanceData;

			public static readonly int _InputInstanceIndices;

			public static readonly int _InputValidComponentIndices;

			public static readonly int _InputComponentAddresses;

			public static readonly int _InputComponentByteCounts;

			public static readonly int _InputComponentInstanceIndexRanges;

			public static readonly int _OutputBuffer;
		}

		public struct GPUResources : IDisposable
		{
			public ComputeBuffer instanceData;

			public ComputeBuffer instanceIndices;

			public ComputeBuffer inputComponentOffsets;

			public ComputeBuffer validComponentIndices;

			public ComputeShader cs;

			public int kernelId;

			private int m_InstanceDataByteSize;

			private int m_InstanceCount;

			private int m_ComponentCounts;

			private int m_ValidComponentIndicesCount;

			public void LoadShaders(GPUResidentDrawerResources resources)
			{
			}

			public void CreateResources(int newInstanceCount, int sizePerInstance, int newComponentCounts, int validComponentIndicesCount)
			{
			}

			public void Dispose()
			{
			}
		}

		[BurstCompile(DisableSafetyChecks = true, OptimizeFor = OptimizeFor.Performance)]
		internal struct WriteInstanceDataParameterJob : IJobParallelFor
		{
			public const int k_BatchSize = 512;

			[ReadOnly]
			public bool gatherData;

			[ReadOnly]
			public int parameterIndex;

			[ReadOnly]
			public int uintPerParameter;

			[ReadOnly]
			public int uintPerInstance;

			[ReadOnly]
			public NativeArray<int> componentDataIndex;

			[ReadOnly]
			public NativeArray<int> gatherIndices;

			[NativeDisableContainerSafetyRestriction]
			[NoAlias]
			[ReadOnly]
			public NativeArray<uint> instanceData;

			[NativeDisableContainerSafetyRestriction]
			[NoAlias]
			[WriteOnly]
			public NativeArray<uint> tmpDataBuffer;

			public void Execute(int index)
			{
			}
		}

		private int m_UintPerInstance;

		private int m_Capacity;

		private int m_InstanceCount;

		private NativeArray<bool> m_ComponentIsInstanced;

		private NativeArray<int> m_ComponentDataIndex;

		private NativeArray<int> m_DescriptionsUintSize;

		private NativeArray<uint> m_TmpDataBuffer;

		private NativeList<int> m_WritenComponentIndices;

		private NativeArray<int> m_DummyArray;

		public GPUInstanceDataBufferUploader(in NativeArray<GPUInstanceComponentDesc> descriptions, int capacity, InstanceType instanceType)
		{
			m_UintPerInstance = 0;
			m_Capacity = 0;
			m_InstanceCount = 0;
			m_ComponentIsInstanced = default(NativeArray<bool>);
			m_ComponentDataIndex = default(NativeArray<int>);
			m_DescriptionsUintSize = default(NativeArray<int>);
			m_TmpDataBuffer = default(NativeArray<uint>);
			m_WritenComponentIndices = default(NativeList<int>);
			m_DummyArray = default(NativeArray<int>);
		}

		public IntPtr GetUploadBufferPtr()
		{
			return (IntPtr)0;
		}

		public int GetUIntPerInstance()
		{
			return 0;
		}

		public int GetParamUIntOffset(int parameterIndex)
		{
			return 0;
		}

		public int PrepareParamWrite<T>(int parameterIndex) where T : struct
		{
			return 0;
		}

		public void AllocateUploadHandles(int handlesLength)
		{
		}

		public JobHandle WriteInstanceDataJob<T>(int parameterIndex, NativeArray<T> instanceData) where T : struct
		{
			return default(JobHandle);
		}

		public JobHandle WriteInstanceDataJob<T>(int parameterIndex, NativeArray<T> instanceData, NativeArray<int> gatherIndices) where T : struct
		{
			return default(JobHandle);
		}

		public void SubmitToGpu(GPUInstanceDataBuffer instanceDataBuffer, NativeArray<GPUInstanceIndex> gpuInstanceIndices, ref GPUResources gpuResources, bool submitOnlyWrittenParams)
		{
		}

		public void SubmitToGpu(GPUInstanceDataBuffer instanceDataBuffer, NativeArray<InstanceHandle> instances, ref GPUResources gpuResources, bool submitOnlyWrittenParams)
		{
		}

		public void Dispose()
		{
		}
	}
}
