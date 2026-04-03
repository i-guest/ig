using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[RequiredByNativeCode(Optional = false, GenerateProxy = false)]
	[NativeClass("ScriptingContactPoint2D", "struct ScriptingContactPoint2D;")]
	[NativeHeader("Modules/Physics2D/Public/PhysicsScripting2D.h")]
	public struct ContactPoint2D
	{
		[NativeName("point")]
		private Vector2 m_Point;

		[NativeName("normal")]
		private Vector2 m_Normal;

		[NativeName("relativeVelocity")]
		private Vector2 m_RelativeVelocity;

		[NativeName("friction")]
		private float m_Friction;

		[NativeName("bounciness")]
		private float m_Bounciness;

		[NativeName("separation")]
		private float m_Separation;

		[NativeName("normalImpulse")]
		private float m_NormalImpulse;

		[NativeName("tangentImpulse")]
		private float m_TangentImpulse;

		[NativeName("collider")]
		private EntityId m_Collider;

		[NativeName("otherCollider")]
		private EntityId m_OtherCollider;

		[NativeName("rigidbody")]
		private EntityId m_Rigidbody;

		[NativeName("otherRigidbody")]
		private EntityId m_OtherRigidbody;

		[NativeName("enabled")]
		private int m_Enabled;

		public Vector2 point => default(Vector2);

		public Vector2 normal => default(Vector2);
	}
}
