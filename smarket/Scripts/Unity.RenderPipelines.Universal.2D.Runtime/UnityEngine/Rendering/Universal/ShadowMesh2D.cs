using System;
using Unity.Collections;

namespace UnityEngine.Rendering.Universal
{
	[Serializable]
	internal class ShadowMesh2D : ShadowShape2D
	{
		public enum EdgeProcessing
		{
			None = 0,
			Clipping = 1
		}

		internal const int k_CapsuleCapSegments = 8;

		internal const float k_TrimEdgeUninitialized = -1f;

		[SerializeField]
		private Mesh m_Mesh;

		[SerializeField]
		private Bounds m_LocalBounds;

		[SerializeField]
		private EdgeProcessing m_EdgeProcessing;

		[SerializeField]
		private float m_TrimEdge;

		[SerializeField]
		private bool m_FlipX;

		[SerializeField]
		private bool m_FlipY;

		[SerializeField]
		private float m_InitialTrim;

		internal BoundingSphere m_BoundingSphere;

		public Mesh mesh => null;

		public BoundingSphere boundingSphere => default(BoundingSphere);

		public EdgeProcessing edgeProcessing
		{
			get
			{
				return default(EdgeProcessing);
			}
			set
			{
			}
		}

		public float trimEdge
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		internal static void DuplicateShadowMesh(Mesh source, out Mesh dest)
		{
			dest = null;
		}

		internal void CopyFrom(ShadowMesh2D source)
		{
		}

		internal void AddCircle(Vector3 center, float r, NativeArray<Vector3> generatedVertices, NativeArray<int> generatedIndices, bool reverseWindingOrder, ref int vertexWritePos, ref int indexWritePos)
		{
		}

		internal void AddCapsuleCap(Vector3 center, float r, Vector3 otherCenter, NativeArray<Vector3> generatedVertices, NativeArray<int> generatedIndices, bool reverseWindingOrder, ref int vertexWritePos, ref int indexWritePos)
		{
		}

		internal void AddCapsule(Vector3 pt0, Vector3 pt1, float r0, float r1, NativeArray<Vector3> generatedVertices, NativeArray<int> generatedIndices, bool reverseWindingOrder, ref int vertexWritePos, ref int indexWritePos)
		{
		}

		internal int AddShape(NativeArray<Vector3> vertices, NativeArray<int> indices, int indicesProcessed, NativeArray<Vector3> generatedVertices, NativeArray<int> generatedIndices, ref int vertexWritePos, ref int indexWritePos)
		{
			return 0;
		}

		public override void SetShape(NativeArray<Vector3> vertices, NativeArray<int> indices, NativeArray<float> radii, Matrix4x4 transform, WindingOrder windingOrder = WindingOrder.Clockwise, bool allowTriming = true, bool createInteriorGeometry = false)
		{
		}

		private bool AreDegenerateVertices(NativeArray<Vector3> vertices)
		{
			return false;
		}

		public override void SetShape(NativeArray<Vector3> vertices, NativeArray<int> indices, OutlineTopology outlineTopology, WindingOrder windingOrder = WindingOrder.Clockwise, bool allowTrimming = true, bool createInteriorGeometry = false)
		{
		}

		public void SetShapeWithLines(NativeArray<Vector3> vertices, NativeArray<int> indices, bool allowTrimming)
		{
		}

		public override void SetFlip(bool flipX, bool flipY)
		{
		}

		public override void GetFlip(out bool flipX, out bool flipY)
		{
			flipX = default(bool);
			flipY = default(bool);
		}

		public override void SetDefaultTrim(float trim)
		{
		}

		public void UpdateBoundingSphere(Transform transform)
		{
		}
	}
}
