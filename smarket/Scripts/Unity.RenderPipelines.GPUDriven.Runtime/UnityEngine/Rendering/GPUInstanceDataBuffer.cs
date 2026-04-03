using System;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;

namespace UnityEngine.Rendering
{
	internal class GPUInstanceDataBuffer : IDisposable
	{
		internal readonly struct ReadOnly
		{
			private readonly NativeArray<int> instancesNumPrefixSum;

			public ReadOnly(GPUInstanceDataBuffer buffer)
			{
				instancesNumPrefixSum = default(NativeArray<int>);
			}

			public GPUInstanceIndex CPUInstanceToGPUInstance(InstanceHandle instance)
			{
				return default(GPUInstanceIndex);
			}

			public void CPUInstanceArrayToGPUInstanceArray(NativeArray<InstanceHandle> instances, NativeArray<GPUInstanceIndex> gpuInstanceIndices)
			{
			}
		}

		[BurstCompile(DisableSafetyChecks = true, OptimizeFor = OptimizeFor.Performance)]
		private struct ConvertCPUInstancesToGPUInstancesJob : IJobParallelFor
		{
			public const int k_BatchSize = 512;

			[ReadOnly]
			public NativeArray<int> instancesNumPrefixSum;

			[ReadOnly]
			public NativeArray<InstanceHandle> instances;

			[WriteOnly]
			public NativeArray<GPUInstanceIndex> gpuInstanceIndices;

			public void Execute(int index)
			{
			}
		}

		private static int s_NextLayoutVersion;

		public InstanceNumInfo instanceNumInfo;

		public NativeArray<int> instancesNumPrefixSum;

		public NativeArray<int> instancesSpan;

		public int byteSize;

		public int perInstanceComponentCount;

		public int version;

		public int layoutVersion;

		public GraphicsBuffer gpuBuffer;

		public GraphicsBuffer validComponentsIndicesGpuBuffer;

		public GraphicsBuffer componentAddressesGpuBuffer;

		public GraphicsBuffer componentInstanceIndexRangesGpuBuffer;

		public GraphicsBuffer componentByteCountsGpuBuffer;

		public NativeArray<GPUInstanceComponentDesc> descriptions;

		public NativeArray<MetadataValue> defaultMetadata;

		public NativeArray<int> gpuBufferComponentAddress;

		public NativeParallelHashMap<int, int> nameToMetadataMap;

		public bool valid => false;

		public static int NextVersion()
		{
			return 0;
		}

		private static GPUInstanceIndex CPUInstanceToGPUInstance(in NativeArray<int> instancesNumPrefixSum, InstanceHandle instance)
		{
			return default(GPUInstanceIndex);
		}

		public int GetPropertyIndex(int propertyID, bool assertOnFail = true)
		{
			return 0;
		}

		public int GetGpuAddress(string strName, bool assertOnFail = true)
		{
			return 0;
		}

		public int GetGpuAddress(int propertyID, bool assertOnFail = true)
		{
			return 0;
		}

		public GPUInstanceIndex CPUInstanceToGPUInstance(InstanceHandle instance)
		{
			return default(GPUInstanceIndex);
		}

		public InstanceHandle GPUInstanceToCPUInstance(GPUInstanceIndex gpuInstanceIndex)
		{
			return default(InstanceHandle);
		}

		public void CPUInstanceArrayToGPUInstanceArray(NativeArray<InstanceHandle> instances, NativeArray<GPUInstanceIndex> gpuInstanceIndices)
		{
		}

		public void Dispose()
		{
		}

		public ReadOnly AsReadOnly()
		{
			return default(ReadOnly);
		}
	}
}
