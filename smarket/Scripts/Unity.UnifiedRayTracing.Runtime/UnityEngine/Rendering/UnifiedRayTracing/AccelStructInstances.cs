using System;
using System.Collections.Generic;
using Unity.Mathematics;

namespace UnityEngine.Rendering.UnifiedRayTracing
{
	internal sealed class AccelStructInstances : IDisposable
	{
		public struct RTInstance
		{
			public float4x4 localToWorld;

			public float4x4 previousLocalToWorld;

			public float4x4 localToWorldNormals;

			public uint renderingLayerMask;

			public uint instanceMask;

			public uint userMaterialID;

			public uint geometryIndex;
		}

		public class InstanceEntry
		{
			public GeometryPoolHandle geometryPoolHandle;

			public BlockAllocator.Allocation indexInInstanceBuffer;

			public uint instanceMask;

			public uint vertexOffset;

			public uint indexOffset;
		}

		private readonly GeometryPool m_GeometryPool;

		private readonly PersistentGpuArray<RTInstance> m_InstanceBuffer;

		private readonly Dictionary<int, InstanceEntry> m_Instances;

		private uint m_FrameTimestamp;

		private uint m_TransformTouchedLastTimestamp;

		public PersistentGpuArray<RTInstance> instanceBuffer => null;

		public IReadOnlyCollection<InstanceEntry> instances => null;

		public GeometryPool geometryPool => null;

		public GraphicsBuffer indexBuffer => null;

		public GraphicsBuffer vertexBuffer => null;

		public bool instanceListValid => false;

		internal AccelStructInstances(GeometryPool geometryPool)
		{
		}

		public void Dispose()
		{
		}

		public int AddInstance(MeshInstanceDesc meshInstance, uint materialID, uint renderingLayerMask)
		{
			return 0;
		}

		public int AddInstances(Span<MeshInstanceDesc> meshInstances, Span<uint> materialIDs, Span<uint> renderingLayerMask)
		{
			return 0;
		}

		private void AddInstance(BlockAllocator.Allocation slotAllocation, in MeshInstanceDesc meshInstance, uint materialID, uint renderingLayerMask)
		{
		}

		public GeometryPool.MeshChunk GetEntryGeomAllocation(GeometryPoolHandle handle, int submeshIndex)
		{
			return default(GeometryPool.MeshChunk);
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

		public void UpdateInstanceMaterialID(int instanceHandle, uint materialID)
		{
		}

		public void UpdateRenderingLayerMask(int instanceHandle, uint renderingLayerMask)
		{
		}

		public void UpdateInstanceMask(int instanceHandle, uint mask)
		{
		}

		public void NextFrame()
		{
		}

		public void Bind(CommandBuffer cmd, IRayTracingShader shader)
		{
		}

		public int GetInstanceCount()
		{
			return 0;
		}

		private static float4x4 NormalMatrix(float4x4 m)
		{
			return default(float4x4);
		}
	}
}
