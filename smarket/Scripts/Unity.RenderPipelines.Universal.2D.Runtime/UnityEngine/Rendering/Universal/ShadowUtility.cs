using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AOT;
using Unity.Burst;
using Unity.Collections;

namespace UnityEngine.Rendering.Universal
{
	[BurstCompile]
	internal class ShadowUtility
	{
		public enum ProjectionType
		{
			ProjectionNone = -1,
			ProjectionHard = 0,
			ProjectionSoftLeft = 1,
			ProjectionSoftRight = 3
		}

		internal struct ShadowMeshVertex
		{
			internal Vector3 position;

			internal Vector4 tangent;

			internal ShadowMeshVertex(ProjectionType inProjectionType, Vector2 inEdgePosition0, Vector2 inEdgePosition1)
			{
				position = default(Vector3);
				tangent = default(Vector4);
			}
		}

		internal struct RemappingInfo
		{
			public int count;

			public int index;

			public int v0Offset;

			public int v1Offset;

			public void Initialize()
			{
			}
		}

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate void CalculateProjectionInfo_000002F1_0024PostfixBurstDelegate(ref NativeArray<Vector3> inVertices, ref NativeArray<ShadowEdge> inEdges, ref NativeArray<int> inShapeStartingEdge, ref NativeArray<bool> inShapeIsClosedArray, ref NativeArray<Vector2> outProjectionInfo);

		internal static class CalculateProjectionInfo_000002F1_0024BurstDirectCall
		{
			private static IntPtr Pointer;

			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr P_0)
			{
			}

			private static IntPtr GetFunctionPointer()
			{
				return (IntPtr)0;
			}

			public static void Invoke(ref NativeArray<Vector3> inVertices, ref NativeArray<ShadowEdge> inEdges, ref NativeArray<int> inShapeStartingEdge, ref NativeArray<bool> inShapeIsClosedArray, ref NativeArray<Vector2> outProjectionInfo)
			{
			}
		}

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate void CalculateVertices_000002F2_0024PostfixBurstDelegate(ref NativeArray<Vector3> inVertices, ref NativeArray<ShadowEdge> inEdges, ref NativeArray<Vector2> inEdgeOtherPoints, ref NativeArray<ShadowMeshVertex> outMeshVertices);

		internal static class CalculateVertices_000002F2_0024BurstDirectCall
		{
			private static IntPtr Pointer;

			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr P_0)
			{
			}

			private static IntPtr GetFunctionPointer()
			{
				return (IntPtr)0;
			}

			public static void Invoke(ref NativeArray<Vector3> inVertices, ref NativeArray<ShadowEdge> inEdges, ref NativeArray<Vector2> inEdgeOtherPoints, ref NativeArray<ShadowMeshVertex> outMeshVertices)
			{
			}
		}

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate void CalculateTriangles_000002F3_0024PostfixBurstDelegate(ref NativeArray<Vector3> inVertices, ref NativeArray<ShadowEdge> inEdges, ref NativeArray<int> inShapeStartingEdge, ref NativeArray<bool> inShapeIsClosedArray, ref NativeArray<int> outMeshIndices);

		internal static class CalculateTriangles_000002F3_0024BurstDirectCall
		{
			private static IntPtr Pointer;

			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr P_0)
			{
			}

			private static IntPtr GetFunctionPointer()
			{
				return (IntPtr)0;
			}

			public static void Invoke(ref NativeArray<Vector3> inVertices, ref NativeArray<ShadowEdge> inEdges, ref NativeArray<int> inShapeStartingEdge, ref NativeArray<bool> inShapeIsClosedArray, ref NativeArray<int> outMeshIndices)
			{
			}
		}

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate void CalculateLocalBounds_000002F4_0024PostfixBurstDelegate(ref NativeArray<Vector3> inVertices, out Bounds retBounds);

		internal static class CalculateLocalBounds_000002F4_0024BurstDirectCall
		{
			private static IntPtr Pointer;

			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr P_0)
			{
			}

			private static IntPtr GetFunctionPointer()
			{
				return (IntPtr)0;
			}

			public static void Invoke(ref NativeArray<Vector3> inVertices, out Bounds retBounds)
			{
				retBounds = default(Bounds);
			}
		}

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate void GenerateInteriorMesh_000002F5_0024PostfixBurstDelegate(ref NativeArray<ShadowMeshVertex> inVertices, ref NativeArray<int> inIndices, ref NativeArray<ShadowEdge> inEdges, out NativeArray<ShadowMeshVertex> outVertices, out NativeArray<int> outIndices, out int outStartIndex, out int outIndexCount);

		internal static class GenerateInteriorMesh_000002F5_0024BurstDirectCall
		{
			private static IntPtr Pointer;

			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr P_0)
			{
			}

			private static IntPtr GetFunctionPointer()
			{
				return (IntPtr)0;
			}

			public static void Invoke(ref NativeArray<ShadowMeshVertex> inVertices, ref NativeArray<int> inIndices, ref NativeArray<ShadowEdge> inEdges, out NativeArray<ShadowMeshVertex> outVertices, out NativeArray<int> outIndices, out int outStartIndex, out int outIndexCount)
			{
				outVertices = default(NativeArray<ShadowMeshVertex>);
				outIndices = default(NativeArray<int>);
				outStartIndex = default(int);
				outIndexCount = default(int);
			}
		}

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate void CalculateEdgesFromLines_000002F7_0024PostfixBurstDelegate(ref NativeArray<int> indices, out NativeArray<ShadowEdge> outEdges, out NativeArray<int> outShapeStartingEdge, out NativeArray<bool> outShapeIsClosedArray);

		internal static class CalculateEdgesFromLines_000002F7_0024BurstDirectCall
		{
			private static IntPtr Pointer;

			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr P_0)
			{
			}

			private static IntPtr GetFunctionPointer()
			{
				return (IntPtr)0;
			}

			public static void Invoke(ref NativeArray<int> indices, out NativeArray<ShadowEdge> outEdges, out NativeArray<int> outShapeStartingEdge, out NativeArray<bool> outShapeIsClosedArray)
			{
				outEdges = default(NativeArray<ShadowEdge>);
				outShapeStartingEdge = default(NativeArray<int>);
				outShapeIsClosedArray = default(NativeArray<bool>);
			}
		}

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate void GetVertexReferenceStats_000002F8_0024PostfixBurstDelegate(ref NativeArray<Vector3> vertices, ref NativeArray<ShadowEdge> edges, int vertexCount, out bool hasReusedVertices, out int newVertexCount, out NativeArray<RemappingInfo> remappingInfo);

		internal static class GetVertexReferenceStats_000002F8_0024BurstDirectCall
		{
			private static IntPtr Pointer;

			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr P_0)
			{
			}

			private static IntPtr GetFunctionPointer()
			{
				return (IntPtr)0;
			}

			public static void Invoke(ref NativeArray<Vector3> vertices, ref NativeArray<ShadowEdge> edges, int vertexCount, out bool hasReusedVertices, out int newVertexCount, out NativeArray<RemappingInfo> remappingInfo)
			{
				hasReusedVertices = default(bool);
				newVertexCount = default(int);
				remappingInfo = default(NativeArray<RemappingInfo>);
			}
		}

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate void CalculateEdgesFromTriangles_000002FA_0024PostfixBurstDelegate(ref NativeArray<Vector3> vertices, ref NativeArray<int> indices, bool duplicatesVertices, out NativeArray<Vector3> newVertices, out NativeArray<ShadowEdge> outEdges, out NativeArray<int> outShapeStartingEdge, out NativeArray<bool> outShapeIsClosedArray);

		internal static class CalculateEdgesFromTriangles_000002FA_0024BurstDirectCall
		{
			private static IntPtr Pointer;

			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr P_0)
			{
			}

			private static IntPtr GetFunctionPointer()
			{
				return (IntPtr)0;
			}

			public static void Invoke(ref NativeArray<Vector3> vertices, ref NativeArray<int> indices, bool duplicatesVertices, out NativeArray<Vector3> newVertices, out NativeArray<ShadowEdge> outEdges, out NativeArray<int> outShapeStartingEdge, out NativeArray<bool> outShapeIsClosedArray)
			{
				newVertices = default(NativeArray<Vector3>);
				outEdges = default(NativeArray<ShadowEdge>);
				outShapeStartingEdge = default(NativeArray<int>);
				outShapeIsClosedArray = default(NativeArray<bool>);
			}
		}

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate void ReverseWindingOrder_000002FB_0024PostfixBurstDelegate(ref NativeArray<int> inShapeStartingEdge, ref NativeArray<ShadowEdge> inOutSortedEdges);

		internal static class ReverseWindingOrder_000002FB_0024BurstDirectCall
		{
			private static IntPtr Pointer;

			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr P_0)
			{
			}

			private static IntPtr GetFunctionPointer()
			{
				return (IntPtr)0;
			}

			public static void Invoke(ref NativeArray<int> inShapeStartingEdge, ref NativeArray<ShadowEdge> inOutSortedEdges)
			{
			}
		}

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate void ClipEdges_000002FE_0024PostfixBurstDelegate(ref NativeArray<Vector3> inVertices, ref NativeArray<ShadowEdge> inEdges, ref NativeArray<int> inShapeStartingEdge, ref NativeArray<bool> inShapeIsClosedArray, float contractEdge, out NativeArray<Vector3> outVertices, out NativeArray<ShadowEdge> outEdges, out NativeArray<int> outShapeStartingEdge);

		internal static class ClipEdges_000002FE_0024BurstDirectCall
		{
			private static IntPtr Pointer;

			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr P_0)
			{
			}

			private static IntPtr GetFunctionPointer()
			{
				return (IntPtr)0;
			}

			public static void Invoke(ref NativeArray<Vector3> inVertices, ref NativeArray<ShadowEdge> inEdges, ref NativeArray<int> inShapeStartingEdge, ref NativeArray<bool> inShapeIsClosedArray, float contractEdge, out NativeArray<Vector3> outVertices, out NativeArray<ShadowEdge> outEdges, out NativeArray<int> outShapeStartingEdge)
			{
				outVertices = default(NativeArray<Vector3>);
				outEdges = default(NativeArray<ShadowEdge>);
				outShapeStartingEdge = default(NativeArray<int>);
			}
		}

		internal const int k_AdditionalVerticesPerEdge = 4;

		internal const int k_VerticesPerTriangle = 3;

		internal const int k_TrianglesPerEdge = 3;

		internal const int k_MinimumEdges = 3;

		internal const int k_SafeSize = 40;

		private static VertexAttributeDescriptor[] m_VertexLayout;

		private unsafe static int GetNextShapeStart(int currentShape, int* inShapeStartingEdgePtr, int inShapeStartingEdgeLength, int maxValue)
		{
			return 0;
		}

		[BurstCompile]
		[MonoPInvokeCallback(typeof(CalculateProjectionInfo_000002F1_0024PostfixBurstDelegate))]
		internal static void CalculateProjectionInfo(ref NativeArray<Vector3> inVertices, ref NativeArray<ShadowEdge> inEdges, ref NativeArray<int> inShapeStartingEdge, ref NativeArray<bool> inShapeIsClosedArray, ref NativeArray<Vector2> outProjectionInfo)
		{
		}

		[BurstCompile]
		[MonoPInvokeCallback(typeof(CalculateVertices_000002F2_0024PostfixBurstDelegate))]
		internal static void CalculateVertices(ref NativeArray<Vector3> inVertices, ref NativeArray<ShadowEdge> inEdges, ref NativeArray<Vector2> inEdgeOtherPoints, ref NativeArray<ShadowMeshVertex> outMeshVertices)
		{
		}

		[BurstCompile]
		[MonoPInvokeCallback(typeof(CalculateTriangles_000002F3_0024PostfixBurstDelegate))]
		internal static void CalculateTriangles(ref NativeArray<Vector3> inVertices, ref NativeArray<ShadowEdge> inEdges, ref NativeArray<int> inShapeStartingEdge, ref NativeArray<bool> inShapeIsClosedArray, ref NativeArray<int> outMeshIndices)
		{
		}

		[BurstCompile]
		[MonoPInvokeCallback(typeof(CalculateLocalBounds_000002F4_0024PostfixBurstDelegate))]
		internal static void CalculateLocalBounds(ref NativeArray<Vector3> inVertices, out Bounds retBounds)
		{
			retBounds = default(Bounds);
		}

		[BurstCompile]
		[MonoPInvokeCallback(typeof(GenerateInteriorMesh_000002F5_0024PostfixBurstDelegate))]
		private static void GenerateInteriorMesh(ref NativeArray<ShadowMeshVertex> inVertices, ref NativeArray<int> inIndices, ref NativeArray<ShadowEdge> inEdges, out NativeArray<ShadowMeshVertex> outVertices, out NativeArray<int> outIndices, out int outStartIndex, out int outIndexCount)
		{
			outVertices = default(NativeArray<ShadowMeshVertex>);
			outIndices = default(NativeArray<int>);
			outStartIndex = default(int);
			outIndexCount = default(int);
		}

		public static Bounds GenerateShadowMesh(Mesh mesh, NativeArray<Vector3> inVertices, NativeArray<ShadowEdge> inEdges, NativeArray<int> inShapeStartingEdge, NativeArray<bool> inShapeIsClosedArray, bool allowContraction, bool fill, ShadowShape2D.OutlineTopology topology)
		{
			return default(Bounds);
		}

		[BurstCompile]
		[MonoPInvokeCallback(typeof(CalculateEdgesFromLines_000002F7_0024PostfixBurstDelegate))]
		public static void CalculateEdgesFromLines(ref NativeArray<int> indices, out NativeArray<ShadowEdge> outEdges, out NativeArray<int> outShapeStartingEdge, out NativeArray<bool> outShapeIsClosedArray)
		{
			outEdges = default(NativeArray<ShadowEdge>);
			outShapeStartingEdge = default(NativeArray<int>);
			outShapeIsClosedArray = default(NativeArray<bool>);
		}

		[BurstCompile]
		[MonoPInvokeCallback(typeof(GetVertexReferenceStats_000002F8_0024PostfixBurstDelegate))]
		internal static void GetVertexReferenceStats(ref NativeArray<Vector3> vertices, ref NativeArray<ShadowEdge> edges, int vertexCount, out bool hasReusedVertices, out int newVertexCount, out NativeArray<RemappingInfo> remappingInfo)
		{
			hasReusedVertices = default(bool);
			newVertexCount = default(int);
			remappingInfo = default(NativeArray<RemappingInfo>);
		}

		public static bool IsTriangleReversed(NativeArray<Vector3> vertices, int idx0, int idx1, int idx2)
		{
			return false;
		}

		[BurstCompile]
		[MonoPInvokeCallback(typeof(CalculateEdgesFromTriangles_000002FA_0024PostfixBurstDelegate))]
		public static void CalculateEdgesFromTriangles(ref NativeArray<Vector3> vertices, ref NativeArray<int> indices, bool duplicatesVertices, out NativeArray<Vector3> newVertices, out NativeArray<ShadowEdge> outEdges, out NativeArray<int> outShapeStartingEdge, out NativeArray<bool> outShapeIsClosedArray)
		{
			newVertices = default(NativeArray<Vector3>);
			outEdges = default(NativeArray<ShadowEdge>);
			outShapeStartingEdge = default(NativeArray<int>);
			outShapeIsClosedArray = default(NativeArray<bool>);
		}

		[BurstCompile]
		[MonoPInvokeCallback(typeof(ReverseWindingOrder_000002FB_0024PostfixBurstDelegate))]
		public static void ReverseWindingOrder(ref NativeArray<int> inShapeStartingEdge, ref NativeArray<ShadowEdge> inOutSortedEdges)
		{
		}

		private static int GetClosedPathCount(ref NativeArray<int> inShapeStartingEdge, ref NativeArray<bool> inShapeIsClosedArray)
		{
			return 0;
		}

		private static void GetPathInfo(NativeArray<ShadowEdge> inEdges, NativeArray<int> inShapeStartingEdge, NativeArray<bool> inShapeIsClosedArray, out int closedPathArrayCount, out int closedPathsCount, out int openPathArrayCount, out int openPathsCount)
		{
			closedPathArrayCount = default(int);
			closedPathsCount = default(int);
			openPathArrayCount = default(int);
			openPathsCount = default(int);
		}

		[BurstCompile]
		[MonoPInvokeCallback(typeof(ClipEdges_000002FE_0024PostfixBurstDelegate))]
		public static void ClipEdges(ref NativeArray<Vector3> inVertices, ref NativeArray<ShadowEdge> inEdges, ref NativeArray<int> inShapeStartingEdge, ref NativeArray<bool> inShapeIsClosedArray, float contractEdge, out NativeArray<Vector3> outVertices, out NativeArray<ShadowEdge> outEdges, out NativeArray<int> outShapeStartingEdge)
		{
			outVertices = default(NativeArray<Vector3>);
			outEdges = default(NativeArray<ShadowEdge>);
			outShapeStartingEdge = default(NativeArray<int>);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		internal static void CalculateProjectionInfo_0024BurstManaged(ref NativeArray<Vector3> inVertices, ref NativeArray<ShadowEdge> inEdges, ref NativeArray<int> inShapeStartingEdge, ref NativeArray<bool> inShapeIsClosedArray, ref NativeArray<Vector2> outProjectionInfo)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		internal static void CalculateVertices_0024BurstManaged(ref NativeArray<Vector3> inVertices, ref NativeArray<ShadowEdge> inEdges, ref NativeArray<Vector2> inEdgeOtherPoints, ref NativeArray<ShadowMeshVertex> outMeshVertices)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		internal static void CalculateTriangles_0024BurstManaged(ref NativeArray<Vector3> inVertices, ref NativeArray<ShadowEdge> inEdges, ref NativeArray<int> inShapeStartingEdge, ref NativeArray<bool> inShapeIsClosedArray, ref NativeArray<int> outMeshIndices)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		internal static void CalculateLocalBounds_0024BurstManaged(ref NativeArray<Vector3> inVertices, out Bounds retBounds)
		{
			retBounds = default(Bounds);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		internal static void GenerateInteriorMesh_0024BurstManaged(ref NativeArray<ShadowMeshVertex> inVertices, ref NativeArray<int> inIndices, ref NativeArray<ShadowEdge> inEdges, out NativeArray<ShadowMeshVertex> outVertices, out NativeArray<int> outIndices, out int outStartIndex, out int outIndexCount)
		{
			outVertices = default(NativeArray<ShadowMeshVertex>);
			outIndices = default(NativeArray<int>);
			outStartIndex = default(int);
			outIndexCount = default(int);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		internal static void CalculateEdgesFromLines_0024BurstManaged(ref NativeArray<int> indices, out NativeArray<ShadowEdge> outEdges, out NativeArray<int> outShapeStartingEdge, out NativeArray<bool> outShapeIsClosedArray)
		{
			outEdges = default(NativeArray<ShadowEdge>);
			outShapeStartingEdge = default(NativeArray<int>);
			outShapeIsClosedArray = default(NativeArray<bool>);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		internal static void GetVertexReferenceStats_0024BurstManaged(ref NativeArray<Vector3> vertices, ref NativeArray<ShadowEdge> edges, int vertexCount, out bool hasReusedVertices, out int newVertexCount, out NativeArray<RemappingInfo> remappingInfo)
		{
			hasReusedVertices = default(bool);
			newVertexCount = default(int);
			remappingInfo = default(NativeArray<RemappingInfo>);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		internal static void CalculateEdgesFromTriangles_0024BurstManaged(ref NativeArray<Vector3> vertices, ref NativeArray<int> indices, bool duplicatesVertices, out NativeArray<Vector3> newVertices, out NativeArray<ShadowEdge> outEdges, out NativeArray<int> outShapeStartingEdge, out NativeArray<bool> outShapeIsClosedArray)
		{
			newVertices = default(NativeArray<Vector3>);
			outEdges = default(NativeArray<ShadowEdge>);
			outShapeStartingEdge = default(NativeArray<int>);
			outShapeIsClosedArray = default(NativeArray<bool>);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		internal static void ReverseWindingOrder_0024BurstManaged(ref NativeArray<int> inShapeStartingEdge, ref NativeArray<ShadowEdge> inOutSortedEdges)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		internal static void ClipEdges_0024BurstManaged(ref NativeArray<Vector3> inVertices, ref NativeArray<ShadowEdge> inEdges, ref NativeArray<int> inShapeStartingEdge, ref NativeArray<bool> inShapeIsClosedArray, float contractEdge, out NativeArray<Vector3> outVertices, out NativeArray<ShadowEdge> outEdges, out NativeArray<int> outShapeStartingEdge)
		{
			outVertices = default(NativeArray<Vector3>);
			outEdges = default(NativeArray<ShadowEdge>);
			outShapeStartingEdge = default(NativeArray<int>);
		}
	}
}
