using System;
using Unity.Collections;

namespace UnityEngine.Rendering
{
	internal struct GPUInstanceDataBufferBuilder : IDisposable
	{
		private NativeList<GPUInstanceComponentDesc> m_Components;

		private MetadataValue CreateMetadataValue(int nameID, int gpuAddress, bool isOverridden)
		{
			return default(MetadataValue);
		}

		public void AddComponent<T>(int propertyID, bool isOverriden, bool isPerInstance, InstanceType instanceType, InstanceComponentGroup componentGroup = InstanceComponentGroup.Default) where T : struct
		{
		}

		public void AddComponent(int propertyID, bool isOverriden, int byteSize, bool isPerInstance, InstanceType instanceType, InstanceComponentGroup componentGroup)
		{
		}

		public GPUInstanceDataBuffer Build(in InstanceNumInfo instanceNumInfo)
		{
			return null;
		}

		public void Dispose()
		{
		}
	}
}
