using Unity.Mathematics;

namespace UnityEngine.Rendering.RadeonRays
{
	internal class BvhCheck
	{
		public class VertexBuffers
		{
			public GraphicsBuffer vertices;

			public GraphicsBuffer indices;

			public uint vertexBufferOffset;

			public uint vertexCount;

			public uint vertexStride;

			public uint indexBufferOffset;

			public IndexFormat indexFormat;

			public uint indexCount;
		}

		private sealed class VertexBuffersCPU
		{
			public float[] vertices;

			public uint[] indices;

			public uint vertexStride;
		}

		private struct Triangle
		{
			public float3 v0;

			public float3 v1;

			public float3 v2;
		}

		private const uint kInvalidID = 4294967295u;

		public static VertexBuffers Convert(MeshBuildInfo info)
		{
			return null;
		}

		public static double SurfaceArea(AABB aabb)
		{
			return 0.0;
		}

		public static double NodeSahCost(uint nodeAddr, AABB nodeAabb, AABB parentAabb)
		{
			return 0.0;
		}

		public static double CheckConsistency(VertexBuffers bvhVertexBuffers, BottomLevelLevelAccelStruct bvh, uint primitiveCount)
		{
			return 0.0;
		}

		public static double CheckConsistency(GraphicsBuffer bvhBuffer, uint bvhBufferOffset, uint primitiveCount)
		{
			return 0.0;
		}

		private static double CheckConsistency(VertexBuffers bvhVertexBuffers, GraphicsBuffer bvhBuffer, uint bvhBufferOffset, GraphicsBuffer bvhLeavesBuffer, uint bvhLeavesBufferOffset, uint primitiveCount)
		{
			return 0.0;
		}

		public static int ExtractBits(uint value, int startBit, int count)
		{
			return 0;
		}

		public static bool IsLeafNode(uint nodeAddr)
		{
			return false;
		}

		public static uint GetLeafNodeFirstPrim(uint nodeAddr)
		{
			return 0u;
		}

		public static uint GetLeafNodePrimCount(uint nodeAddr)
		{
			return 0u;
		}

		private static double CheckConsistency(VertexBuffers bvhVertexBuffers, GraphicsBuffer bvhBuffer, uint bvhBufferOffset, GraphicsBuffer bvhLeavesBuffer, uint bvhLeavesBufferOffset, BvhHeader header, uint primitiveCount)
		{
			return 0.0;
		}

		private static uint3 GetFaceIndices(uint[] indices, uint triangleIdx)
		{
			return default(uint3);
		}

		private static float3 GetVertex(float[] vertices, uint stride, uint idx)
		{
			return default(float3);
		}

		private static Triangle GetTriangle(float[] vertices, uint stride, uint3 idx)
		{
			return default(Triangle);
		}

		private static VertexBuffersCPU DownloadVertexData(VertexBuffers vertexBuffers)
		{
			return null;
		}

		private static AABB GetAabb(VertexBuffersCPU bvhVertexBuffers, BvhNode[] bvhNodes, uint4[] bvhLeafNodes, uint nodeAddr, bool isTopLevel)
		{
			return null;
		}
	}
}
