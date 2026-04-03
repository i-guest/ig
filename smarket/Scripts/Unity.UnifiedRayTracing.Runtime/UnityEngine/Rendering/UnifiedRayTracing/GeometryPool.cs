using System;
using System.Collections.Generic;
using Unity.Collections;

namespace UnityEngine.Rendering.UnifiedRayTracing
{
	internal sealed class GeometryPool : IDisposable
	{
		private static class GeoPoolShaderIDs
		{
			public static readonly int _InputIBBaseOffset;

			public static readonly int _DispatchIndexOffset;

			public static readonly int _InputIBCount;

			public static readonly int _OutputIBOffset;

			public static readonly int _InputFirstVertex;

			public static readonly int _InputIndexBuffer;

			public static readonly int _OutputIndexBuffer;

			public static readonly int _InputVBCount;

			public static readonly int _InputBaseVertexOffset;

			public static readonly int _DispatchVertexOffset;

			public static readonly int _OutputVBSize;

			public static readonly int _OutputVBOffset;

			public static readonly int _InputPosBufferStride;

			public static readonly int _InputPosBufferOffset;

			public static readonly int _InputUv0BufferStride;

			public static readonly int _InputUv0BufferOffset;

			public static readonly int _InputUv1BufferStride;

			public static readonly int _InputUv1BufferOffset;

			public static readonly int _InputNormalBufferStride;

			public static readonly int _InputNormalBufferOffset;

			public static readonly int _PosBuffer;

			public static readonly int _Uv0Buffer;

			public static readonly int _Uv1Buffer;

			public static readonly int _NormalBuffer;

			public static readonly int _OutputVB;

			public static readonly int _AttributesMask;
		}

		public struct MeshChunk
		{
			public BlockAllocator.Allocation vertexAlloc;

			public BlockAllocator.Allocation indexAlloc;

			public static MeshChunk Invalid => default(MeshChunk);

			public GeoPoolMeshChunk EncodeGPUEntry()
			{
				return default(GeoPoolMeshChunk);
			}
		}

		public struct GeometrySlot
		{
			public uint refCount;

			public uint hash;

			public BlockAllocator.Allocation meshChunkTableAlloc;

			public NativeArray<MeshChunk> meshChunks;

			public bool hasGPUData;

			public static readonly GeometrySlot Invalid;

			public bool valid => false;
		}

		private struct GeoPoolEntrySlot
		{
			public uint refCount;

			public uint hash;

			public int geoSlotHandle;

			public static readonly GeoPoolEntrySlot Invalid;

			public bool valid => false;
		}

		private struct VertexBufferAttribInfo
		{
			public GraphicsBuffer buffer;

			public int stride;

			public int offset;

			public int byteCount;

			public bool valid => false;
		}

		private const int kMaxThreadGroupsPerDispatch = 65535;

		private const int kThreadGroupSize = 256;

		private const int InvalidHandle = -1;

		private const GraphicsBuffer.Target VertexBufferTarget = GraphicsBuffer.Target.Structured;

		private const GraphicsBuffer.Target IndexBufferTarget = GraphicsBuffer.Target.Structured;

		private GraphicsBuffer m_GlobalIndexBuffer;

		private GraphicsBuffer m_GlobalVertexBuffer;

		private GraphicsBuffer m_GlobalMeshChunkTableEntryBuffer;

		private readonly GraphicsBuffer m_DummyBuffer;

		private int m_MaxVertCounts;

		private int m_MaxIndexCounts;

		private int m_MaxMeshChunkTableEntriesCount;

		private BlockAllocator m_VertexAllocator;

		private BlockAllocator m_IndexAllocator;

		private BlockAllocator m_MeshChunkTableAllocator;

		private NativeParallelHashMap<uint, int> m_MeshHashToGeoSlot;

		private List<GeometrySlot> m_GeoSlots;

		private NativeList<int> m_FreeGeoSlots;

		private NativeParallelHashMap<uint, GeometryPoolHandle> m_GeoPoolEntryHashToSlot;

		private NativeList<GeoPoolEntrySlot> m_GeoPoolEntrySlots;

		private NativeList<GeometryPoolHandle> m_FreeGeoPoolEntrySlots;

		private readonly List<GraphicsBuffer> m_InputBufferReferences;

		private readonly ComputeShader m_CopyShader;

		private ComputeShader m_GeometryPoolKernelsCS;

		private int m_KernelMainUpdateIndexBuffer16;

		private int m_KernelMainUpdateIndexBuffer32;

		private int m_KernelMainUpdateVertexBuffer;

		private readonly CommandBuffer m_CmdBuffer;

		private bool m_MustClearCmdBuffer;

		private int m_PendingCmds;

		public GraphicsBuffer globalIndexBuffer => null;

		public GraphicsBuffer globalVertexBuffer => null;

		public int globalVertexBufferStrideBytes => 0;

		public GraphicsBuffer globalMeshChunkTableEntryBuffer => null;

		public int indicesCount => 0;

		public int verticesCount => 0;

		public int meshChunkTablesEntryCount => 0;

		public static int GetVertexByteSize()
		{
			return 0;
		}

		public static int GetIndexByteSize()
		{
			return 0;
		}

		public static int GetMeshChunkTableEntryByteSize()
		{
			return 0;
		}

		private int GetFormatByteCount(VertexAttributeFormat format)
		{
			return 0;
		}

		private static int DivUp(int x, int y)
		{
			return 0;
		}

		public GeometryPool(in GeometryPoolDesc desc, ComputeShader geometryPoolShader, ComputeShader copyShader)
		{
		}

		private void DisposeInputBuffers()
		{
		}

		public void Dispose()
		{
		}

		private void LoadKernels(ComputeShader geometryPoolShader)
		{
		}

		private int CalcVertexCount(int bufferByteSize)
		{
			return 0;
		}

		private int CalcIndexCount(int bufferByteSize)
		{
			return 0;
		}

		private int CalcMeshChunkTablesCount(int bufferByteSize)
		{
			return 0;
		}

		private void DeallocateGeometrySlot(ref GeometrySlot slot)
		{
		}

		private void DeallocateGeometrySlot(int geoSlotHandle)
		{
		}

		private bool AllocateGeo(Mesh mesh, out int allocationHandle)
		{
			allocationHandle = default(int);
			return false;
		}

		private void DeallocateGeoPoolEntrySlot(GeometryPoolHandle handle)
		{
		}

		private void DeallocateGeoPoolEntrySlot(ref GeoPoolEntrySlot geoPoolEntrySlot)
		{
		}

		public GeometryPoolEntryInfo GetEntryInfo(GeometryPoolHandle handle)
		{
			return default(GeometryPoolEntryInfo);
		}

		public GeometrySlot GetEntryGeomAllocation(GeometryPoolHandle handle)
		{
			return default(GeometrySlot);
		}

		public int GetInstanceGeometryIndex(Mesh mesh)
		{
			return 0;
		}

		private void UpdateGeoGpuState(Mesh mesh, GeometryPoolHandle handle)
		{
		}

		private uint FNVHash(uint prevHash, uint dword)
		{
			return 0u;
		}

		private uint CalculateClusterHash(Mesh mesh, GeometryPoolSubmeshData[] submeshData)
		{
			return 0u;
		}

		public GeometryPoolHandle GetHandle(Mesh mesh)
		{
			return default(GeometryPoolHandle);
		}

		private static int FindSubmeshEntryInDesc(int submeshIndex, in GeometryPoolSubmeshData[] submeshData)
		{
			return 0;
		}

		public bool Register(Mesh mesh, out GeometryPoolHandle outHandle)
		{
			outHandle = default(GeometryPoolHandle);
			return false;
		}

		public bool Register(in GeometryPoolEntryDesc entryDesc, out GeometryPoolHandle outHandle)
		{
			outHandle = default(GeometryPoolHandle);
			return false;
		}

		public void Unregister(GeometryPoolHandle handle)
		{
		}

		public void SendGpuCommands()
		{
		}

		private GraphicsBuffer LoadIndexBuffer(Mesh mesh)
		{
			return null;
		}

		private void LoadVertexAttribInfo(Mesh mesh, VertexAttribute attribute, out VertexBufferAttribInfo output)
		{
			output = default(VertexBufferAttribInfo);
		}

		private CommandBuffer AllocateCommandBuffer()
		{
			return null;
		}

		private void AddIndexUpdateCommand(CommandBuffer cmdBuffer, IndexFormat inputFormat, in GraphicsBuffer inputBuffer, in BlockAllocator.Allocation location, int firstVertex, int inputOffset, int indexCount, int outputOffset, GraphicsBuffer outputIdxBuffer)
		{
		}

		private void AddVertexUpdateCommand(CommandBuffer cmdBuffer, int baseVertexOffset, in VertexBufferAttribInfo pos, in VertexBufferAttribInfo uv0, in VertexBufferAttribInfo uv1, in VertexBufferAttribInfo n, in BlockAllocator.Allocation location, GraphicsBuffer outputVertexBuffer)
		{
		}
	}
}
