using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[UsedByNativeCode]
	[NativeHeader(Header = "Modules/Physics2D/Public/PhysicsScripting2D.h")]
	public struct PhysicsShape2D
	{
		private PhysicsShapeType2D m_ShapeType;

		private float m_Radius;

		private int m_VertexStartIndex;

		private int m_VertexCount;

		private int m_UseAdjacentStart;

		private int m_UseAdjacentEnd;

		private Vector2 m_AdjacentStart;

		private Vector2 m_AdjacentEnd;

		public PhysicsShapeType2D shapeType => default(PhysicsShapeType2D);

		public float radius => 0f;

		public int vertexStartIndex => 0;

		public int vertexCount => 0;
	}
}
