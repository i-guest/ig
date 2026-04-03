using System.Collections.Generic;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine
{
	public class PhysicsShapeGroup2D
	{
		[NativeHeader(Header = "Modules/Physics2D/Public/PhysicsScripting2D.h")]
		internal struct GroupState
		{
			[NativeName("shapesList")]
			public List<PhysicsShape2D> m_Shapes;

			[NativeName("verticesList")]
			public List<Vector2> m_Vertices;

			[NativeName("localToWorld")]
			public Matrix4x4 m_LocalToWorld;

			public void ClearGeometry()
			{
			}
		}

		internal GroupState m_GroupState;

		internal List<Vector2> groupVertices => null;

		internal List<PhysicsShape2D> groupShapes => null;

		public int shapeCount => 0;

		public PhysicsShapeGroup2D([DefaultValue("1")] int shapeCapacity = 1, [DefaultValue("8")] int vertexCapacity = 8)
		{
		}

		public void Clear()
		{
		}
	}
}
