using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace UnityEngine.Rendering.UnifiedRayTracing
{
	internal sealed class HardwareRayTracingAccelStruct : IRayTracingAccelStruct, IDisposable
	{
		private readonly RayTracingAccelerationStructureBuildFlags m_BuildFlags;

		private readonly Dictionary<int, Mesh> m_Meshes;

		private readonly ReferenceCounter m_Counter;

		public RayTracingAccelerationStructure accelStruct { get; }

		internal HardwareRayTracingAccelStruct(AccelerationStructureOptions options, ReferenceCounter counter)
		{
		}

		public void Dispose()
		{
		}

		public int AddInstance(MeshInstanceDesc meshInstance)
		{
			return 0;
		}

		public void RemoveInstance(int instanceHandle)
		{
		}

		public void ClearInstances()
		{
		}

		public void UpdateInstanceTransform(int instanceHandle, Matrix4x4 localToWorldMatrix)
		{
		}

		public void UpdateInstanceID(int instanceHandle, uint instanceID)
		{
		}

		public void UpdateInstanceMask(int instanceHandle, uint mask)
		{
		}

		public void Build(CommandBuffer cmd, GraphicsBuffer scratchBuffer)
		{
		}

		public ulong GetBuildScratchBufferRequiredSizeInBytes()
		{
			return 0uL;
		}

		[Conditional("UNITY_ASSERTIONS")]
		private void CheckInstanceHandleIsValid(int instanceHandle)
		{
		}
	}
}
