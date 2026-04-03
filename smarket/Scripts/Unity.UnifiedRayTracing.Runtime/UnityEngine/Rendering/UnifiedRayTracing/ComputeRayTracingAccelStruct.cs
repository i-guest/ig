using System;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.Mathematics;
using UnityEngine.Rendering.RadeonRays;

namespace UnityEngine.Rendering.UnifiedRayTracing
{
	internal class ComputeRayTracingAccelStruct : IRayTracingAccelStruct, IDisposable
	{
		private struct Triangle
		{
			public float3 v0;

			public float3 v1;

			public float3 v2;
		}

		private sealed class RadeonRaysInstance
		{
			public (int mesh, int subMeshIndex) geomKey;

			public MeshBlas blas;

			public uint instanceMask;

			public bool triangleCullingEnabled;

			public bool invertTriangleCulling;

			public uint userInstanceID;

			public bool opaqueGeometry;

			public UnityEngine.Rendering.RadeonRays.Transform localToWorldTransform;
		}

		private sealed class MeshBlas
		{
			public MeshBuildInfo buildInfo;

			public BlockAllocator.Allocation bvhAlloc;

			public BlockAllocator.Allocation bvhLeavesAlloc;

			public BlockAllocator.Allocation blasVertices;

			public bool bvhBuilt;

			private uint refCount;

			public void IncRef()
			{
			}

			public void DecRef()
			{
			}

			public bool IsUnreferenced()
			{
				return false;
			}
		}

		private readonly uint m_HandleObfuscation;

		private readonly RadeonRaysAPI m_RadeonRaysAPI;

		private readonly BuildFlags m_BuildFlags;

		private readonly ReferenceCounter m_Counter;

		private readonly Dictionary<(int mesh, int subMeshIndex), MeshBlas> m_Blases;

		internal BlockAllocator m_BlasAllocator;

		private GraphicsBuffer m_BlasBuffer;

		internal BlockAllocator m_BlasLeavesAllocator;

		private GraphicsBuffer m_BlasLeavesBuffer;

		private readonly BLASPositionsPool m_BlasPositions;

		private TopLevelAccelStruct? m_TopLevelAccelStruct;

		private readonly ComputeShader m_CopyShader;

		private readonly Dictionary<int, RadeonRaysInstance> m_RadeonInstances;

		private readonly Queue<uint> m_FreeHandles;

		internal GraphicsBuffer topLevelBvhBuffer => null;

		internal GraphicsBuffer bottomLevelBvhBuffer => null;

		internal GraphicsBuffer instanceInfoBuffer => null;

		internal ComputeRayTracingAccelStruct(AccelerationStructureOptions options, RayTracingResources resources, ReferenceCounter counter, int blasBufferInitialSizeBytes = 67108864)
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

		private void FreeTopLevelAccelStruct()
		{
		}

		private MeshBlas GetOrAllocateMeshBlas(Mesh mesh, int subMeshIndex)
		{
			return null;
		}

		private void AllocateBlas(Mesh mesh, int submeshIndex, MeshBlas blas)
		{
		}

		private GraphicsBuffer LoadIndexBuffer(Mesh mesh)
		{
			return null;
		}

		private GraphicsBuffer LoadPositionBuffer(Mesh mesh, out int stride, out int offset)
		{
			stride = default(int);
			offset = default(int);
			return null;
		}

		private void DeleteMeshBlas((int mesh, int subMeshIndex) geomKey, MeshBlas blas)
		{
		}

		private ulong GetBvhBuildScratchBufferSizeInDwords()
		{
			return 0uL;
		}

		private void CreateBvh(CommandBuffer cmd, GraphicsBuffer scratchBuffer)
		{
		}

		private void BuildMissingBottomLevelAccelStructs(CommandBuffer cmd, GraphicsBuffer scratchBuffer)
		{
		}

		private void BuildTopLevelAccelStruct(CommandBuffer cmd, GraphicsBuffer scratchBuffer)
		{
		}

		private UnityEngine.Rendering.RadeonRays.BuildFlags ConvertFlagsToGpuBuild(BuildFlags flags)
		{
			return default(UnityEngine.Rendering.RadeonRays.BuildFlags);
		}

		public void Bind(CommandBuffer cmd, string name, IRayTracingShader shader)
		{
		}

		public void Bind(CommandBuffer cmd, string name, ComputeShader shader, int kernelIndex)
		{
		}

		private static UnityEngine.Rendering.RadeonRays.Transform ConvertTranform(Matrix4x4 input)
		{
			return default(UnityEngine.Rendering.RadeonRays.Transform);
		}

		private static Matrix4x4 ConvertTranform(UnityEngine.Rendering.RadeonRays.Transform input)
		{
			return default(Matrix4x4);
		}

		private static int3 GetFaceIndices(List<int> indices, int triangleIdx)
		{
			return default(int3);
		}

		private static Triangle GetTriangle(List<Vector3> vertices, int3 idx)
		{
			return default(Triangle);
		}

		private BlockAllocator.Allocation AllocateBlasInternalNodes(int allocationNodeCount)
		{
			return default(BlockAllocator.Allocation);
		}

		private BlockAllocator.Allocation AllocateBlasLeafNodes(int allocationNodeCount)
		{
			return default(BlockAllocator.Allocation);
		}

		private int NewHandle()
		{
			return 0;
		}

		private void ReleaseHandle(int handle)
		{
		}

		[Conditional("UNITY_ASSERTIONS")]
		private void CheckInstanceHandleIsValid(int instanceHandle)
		{
		}
	}
}
