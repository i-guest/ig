using System;
using System.Collections.Generic;

namespace UnityEngine.Rendering.UnifiedRayTracing
{
	internal sealed class AccelStructAdapter : IDisposable
	{
		private struct InstanceIDs
		{
			public int InstanceID;

			public int AccelStructID;
		}

		private IRayTracingAccelStruct _accelStruct;

		private AccelStructInstances _instances;

		private readonly Dictionary<int, InstanceIDs[]> _objectHandleToInstances;

		internal AccelStructInstances Instances => null;

		public GeometryPool GeometryPool => null;

		public AccelStructAdapter(IRayTracingAccelStruct accelStruct, GeometryPool geometryPool)
		{
		}

		public AccelStructAdapter(IRayTracingAccelStruct accelStruct, RayTracingResources resources)
		{
		}

		public IRayTracingAccelStruct GetAccelerationStructure()
		{
			return null;
		}

		public void Bind(CommandBuffer cmd, string propertyName, IRayTracingShader shader)
		{
		}

		public void Dispose()
		{
		}

		public void AddInstance(int objectHandle, Component meshRendererOrTerrain, Span<uint> perSubMeshMask, Span<uint> perSubMeshMaterialIDs, Span<bool> perSubMeshIsOpaque, uint renderingLayerMask)
		{
		}

		public void AddInstance(int objectHandle, Mesh mesh, Matrix4x4 localToWorldMatrix, Span<uint> perSubMeshMask, Span<uint> perSubMeshMaterialIDs, Span<bool> perSubMeshIsOpaque, uint renderingLayerMask)
		{
		}

		private void AddInstance(int objectHandle, TerrainDesc terrainDesc)
		{
		}

		private void AddHeightmap(TerrainDesc terrainDesc, ref List<InstanceIDs> instanceHandles)
		{
		}

		private void AddTrees(TerrainDesc terrainDesc, ref List<InstanceIDs> instanceHandles)
		{
		}

		private InstanceIDs AddInstance(MeshInstanceDesc instanceDesc, uint materialID, uint renderingLayerMask)
		{
			return default(InstanceIDs);
		}

		public void RemoveInstance(int objectHandle)
		{
		}

		public void UpdateInstanceTransform(int objectHandle, Matrix4x4 localToWorldMatrix)
		{
		}

		public void UpdateInstanceMaterialIDs(int objectHandle, Span<uint> perSubMeshMaterialIDs)
		{
		}

		public void UpdateInstanceMask(int objectHandle, Span<uint> perSubMeshMask)
		{
		}

		public void UpdateInstanceMask(int objectHandle, uint mask)
		{
		}

		public void Build(CommandBuffer cmd, ref GraphicsBuffer scratchBuffer)
		{
		}

		public void NextFrame()
		{
		}

		public bool GetInstanceIDs(int rendererID, out int[] instanceIDs)
		{
			instanceIDs = null;
			return false;
		}
	}
}
